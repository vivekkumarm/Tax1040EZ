namespace JTL.Tax1040.BusinessLogic.WorkFlow.Activities {
    
    #line 20 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxesAndPenalties.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxesAndPenalties.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 21 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxesAndPenalties.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxesAndPenalties.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxesAndPenalties.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxesAndPenalties.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 22 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxesAndPenalties.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 23 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxesAndPenalties.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 24 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxesAndPenalties.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 25 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxesAndPenalties.xaml"
    using JTL.Tax1040.BusinessObject;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxesAndPenalties.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class F1040EZTaxesAndPenalties : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly valDataContext0 = ((F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly valDataContext1 = ((F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly valDataContext2 = ((F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly valDataContext3 = ((F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxesAndPenalties_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext3 refDataContext4 = ((F1040EZTaxesAndPenalties_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext4.GetLocation<double>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly valDataContext5 = ((F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext6 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext7 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext8 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext9 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext10 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext11 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext11.GetLocation<System.Collections.Generic.List<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue>>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext12 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext13 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext13.GetLocation<bool>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext14 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly valDataContext15 = ((F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly valDataContext16 = ((F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly valDataContext17 = ((F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZTaxesAndPenalties_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext5 refDataContext18 = ((F1040EZTaxesAndPenalties_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext18.GetLocation<int>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly valDataContext19 = ((F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly valDataContext20 = ((F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZTaxesAndPenalties_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext5 refDataContext21 = ((F1040EZTaxesAndPenalties_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext21.GetLocation<double>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly valDataContext22 = ((F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZTaxesAndPenalties_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext5 refDataContext23 = ((F1040EZTaxesAndPenalties_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext23.GetLocation<System.DateTime>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly valDataContext24 = ((F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new F1040EZTaxesAndPenalties_TypedDataContext5(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext5 refDataContext25 = ((F1040EZTaxesAndPenalties_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext25.GetLocation<int>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new F1040EZTaxesAndPenalties_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext7_ForReadOnly valDataContext26 = ((F1040EZTaxesAndPenalties_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext27 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext28 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext29 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext29.GetLocation<System.DateTime>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext30 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext31 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext32 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext32.GetLocation<System.DateTime>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext33 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext34 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext34.GetLocation<System.DateTime>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext35 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext36 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext36.GetLocation<System.DateTime>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext37 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext38 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext38.GetLocation<System.DateTime>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext39 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext40 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext40.GetLocation<double>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext41 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext42 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext42.GetLocation<double>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext43 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext44 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext44.GetLocation<double>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext45 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext46 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext46.GetLocation<double>(refDataContext46.ValueType___Expr46Get, refDataContext46.ValueType___Expr46Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext47 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext48 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext48.GetLocation<double>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext49 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext50 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext50.GetLocation<double>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext51 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext52 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext52.GetLocation<double>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext53 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext54 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext54.GetLocation<double>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext55 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext56 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext57 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext58 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext58.GetLocation<System.DateTime>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext59 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext60 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext60.GetLocation<int>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext61 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext62 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext62.GetLocation<int>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext63 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext64 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext65 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext65.GetLocation<System.DateTime>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext66 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext67 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext67.GetLocation<System.DateTime>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext68 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext69 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext69.GetLocation<System.DateTime>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext70 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext71 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext71.GetLocation<double>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext72 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext73 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext73.GetLocation<double>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext74 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext75 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext75.GetLocation<double>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 76)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext76 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext77 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext77.GetLocation<double>(refDataContext77.ValueType___Expr77Get, refDataContext77.ValueType___Expr77Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 78)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext78 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext79 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext79.GetLocation<double>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 80)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext80 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext81 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext81.GetLocation<double>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 82)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext82 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext83 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext83.GetLocation<double>(refDataContext83.ValueType___Expr83Get, refDataContext83.ValueType___Expr83Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 84)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext84 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext84.ValueType___Expr84Get();
            }
            if ((expressionId == 85)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext85 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext85.GetLocation<double>(refDataContext85.ValueType___Expr85Get, refDataContext85.ValueType___Expr85Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 86)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext86 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext86.ValueType___Expr86Get();
            }
            if ((expressionId == 87)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext87 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext87.GetLocation<int>(refDataContext87.ValueType___Expr87Get, refDataContext87.ValueType___Expr87Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 88)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext88 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext89 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext89.GetLocation<System.DateTime>(refDataContext89.ValueType___Expr89Get, refDataContext89.ValueType___Expr89Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 90)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext90 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext90.ValueType___Expr90Get();
            }
            if ((expressionId == 91)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext91 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext91.GetLocation<System.DateTime>(refDataContext91.ValueType___Expr91Get, refDataContext91.ValueType___Expr91Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 92)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext92 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext92.ValueType___Expr92Get();
            }
            if ((expressionId == 93)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext93 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext93.GetLocation<double>(refDataContext93.ValueType___Expr93Get, refDataContext93.ValueType___Expr93Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 94)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext94 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext94.ValueType___Expr94Get();
            }
            if ((expressionId == 95)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext95 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext95.GetLocation<double>(refDataContext95.ValueType___Expr95Get, refDataContext95.ValueType___Expr95Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 96)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext96 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext96.ValueType___Expr96Get();
            }
            if ((expressionId == 97)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext97 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext97.GetLocation<double>(refDataContext97.ValueType___Expr97Get, refDataContext97.ValueType___Expr97Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 98)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext98 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext98.ValueType___Expr98Get();
            }
            if ((expressionId == 99)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext99 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext99.GetLocation<double>(refDataContext99.ValueType___Expr99Get, refDataContext99.ValueType___Expr99Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 100)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext100 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext100.ValueType___Expr100Get();
            }
            if ((expressionId == 101)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext101 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext101.GetLocation<double>(refDataContext101.ValueType___Expr101Get, refDataContext101.ValueType___Expr101Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 102)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext102 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext102.ValueType___Expr102Get();
            }
            if ((expressionId == 103)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext103 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext103.GetLocation<double>(refDataContext103.ValueType___Expr103Get, refDataContext103.ValueType___Expr103Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 104)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext104 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext104.ValueType___Expr104Get();
            }
            if ((expressionId == 105)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext105 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext105.GetLocation<double>(refDataContext105.ValueType___Expr105Get, refDataContext105.ValueType___Expr105Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 106)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext106 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext107 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext107.GetLocation<double>(refDataContext107.ValueType___Expr107Get, refDataContext107.ValueType___Expr107Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 108)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext108 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext109 = ((F1040EZTaxesAndPenalties_TypedDataContext8)(cachedCompiledDataContext[9]));
                return refDataContext109.GetLocation<int>(refDataContext109.ValueType___Expr109Get, refDataContext109.ValueType___Expr109Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 110)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext110 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext111 = ((F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext111.ValueType___Expr111Get();
            }
            if ((expressionId == 112)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext112 = ((F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext112.ValueType___Expr112Get();
            }
            if ((expressionId == 113)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext113 = ((F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZTaxesAndPenalties_TypedDataContext9(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9 refDataContext114 = ((F1040EZTaxesAndPenalties_TypedDataContext9)(cachedCompiledDataContext[11]));
                return refDataContext114.GetLocation<System.DateTime>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 115)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext115 = ((F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZTaxesAndPenalties_TypedDataContext9(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9 refDataContext116 = ((F1040EZTaxesAndPenalties_TypedDataContext9)(cachedCompiledDataContext[11]));
                return refDataContext116.GetLocation<System.DateTime>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 117)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext117 = ((F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext117.ValueType___Expr117Get();
            }
            if ((expressionId == 118)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZTaxesAndPenalties_TypedDataContext9(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9 refDataContext118 = ((F1040EZTaxesAndPenalties_TypedDataContext9)(cachedCompiledDataContext[11]));
                return refDataContext118.GetLocation<double>(refDataContext118.ValueType___Expr118Get, refDataContext118.ValueType___Expr118Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 119)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext119 = ((F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext119.ValueType___Expr119Get();
            }
            if ((expressionId == 120)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZTaxesAndPenalties_TypedDataContext9(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9 refDataContext120 = ((F1040EZTaxesAndPenalties_TypedDataContext9)(cachedCompiledDataContext[11]));
                return refDataContext120.GetLocation<double>(refDataContext120.ValueType___Expr120Get, refDataContext120.ValueType___Expr120Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 121)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext121 = ((F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext121.ValueType___Expr121Get();
            }
            if ((expressionId == 122)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZTaxesAndPenalties_TypedDataContext9(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9 refDataContext122 = ((F1040EZTaxesAndPenalties_TypedDataContext9)(cachedCompiledDataContext[11]));
                return refDataContext122.GetLocation<double>(refDataContext122.ValueType___Expr122Get, refDataContext122.ValueType___Expr122Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 123)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext123 = ((F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext123.ValueType___Expr123Get();
            }
            if ((expressionId == 124)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZTaxesAndPenalties_TypedDataContext9(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9 refDataContext124 = ((F1040EZTaxesAndPenalties_TypedDataContext9)(cachedCompiledDataContext[11]));
                return refDataContext124.GetLocation<double>(refDataContext124.ValueType___Expr124Get, refDataContext124.ValueType___Expr124Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 125)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext125 = ((F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext125.ValueType___Expr125Get();
            }
            if ((expressionId == 126)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZTaxesAndPenalties_TypedDataContext9(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9 refDataContext126 = ((F1040EZTaxesAndPenalties_TypedDataContext9)(cachedCompiledDataContext[11]));
                return refDataContext126.GetLocation<double>(refDataContext126.ValueType___Expr126Get, refDataContext126.ValueType___Expr126Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 127)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext127 = ((F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext127.ValueType___Expr127Get();
            }
            if ((expressionId == 128)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new F1040EZTaxesAndPenalties_TypedDataContext9(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9 refDataContext128 = ((F1040EZTaxesAndPenalties_TypedDataContext9)(cachedCompiledDataContext[11]));
                return refDataContext128.GetLocation<double>(refDataContext128.ValueType___Expr128Get, refDataContext128.ValueType___Expr128Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 129)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext129 = ((F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext129.ValueType___Expr129Get();
            }
            if ((expressionId == 130)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext130 = ((F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext130.ValueType___Expr130Get();
            }
            if ((expressionId == 131)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext131 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext131.ValueType___Expr131Get();
            }
            if ((expressionId == 132)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext132 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext132.GetLocation<System.Nullable<double>>(refDataContext132.ValueType___Expr132Get, refDataContext132.ValueType___Expr132Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 133)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext133 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext133.ValueType___Expr133Get();
            }
            if ((expressionId == 134)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext134 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext134.ValueType___Expr134Get();
            }
            if ((expressionId == 135)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext135 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext135.GetLocation<System.DateTime>(refDataContext135.ValueType___Expr135Get, refDataContext135.ValueType___Expr135Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 136)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext136 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext136.ValueType___Expr136Get();
            }
            if ((expressionId == 137)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext137 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext137.GetLocation<double>(refDataContext137.ValueType___Expr137Get, refDataContext137.ValueType___Expr137Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 138)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext138 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext139 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext139.GetLocation<double>(refDataContext139.ValueType___Expr139Get, refDataContext139.ValueType___Expr139Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 140)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext140 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext140.ValueType___Expr140Get();
            }
            if ((expressionId == 141)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext141 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext141.ValueType___Expr141Get();
            }
            if ((expressionId == 142)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext142 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext142.GetLocation<System.DateTime>(refDataContext142.ValueType___Expr142Get, refDataContext142.ValueType___Expr142Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 143)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext143 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext143.ValueType___Expr143Get();
            }
            if ((expressionId == 144)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext144 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext144.GetLocation<double>(refDataContext144.ValueType___Expr144Get, refDataContext144.ValueType___Expr144Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 145)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext145 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext145.ValueType___Expr145Get();
            }
            if ((expressionId == 146)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext146 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext146.GetLocation<double>(refDataContext146.ValueType___Expr146Get, refDataContext146.ValueType___Expr146Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 147)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext147 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext147.ValueType___Expr147Get();
            }
            if ((expressionId == 148)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext148 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext148.GetLocation<double>(refDataContext148.ValueType___Expr148Get, refDataContext148.ValueType___Expr148Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 149)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext149 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext149.GetLocation<double>(refDataContext149.ValueType___Expr149Get, refDataContext149.ValueType___Expr149Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 150)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext150 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext150.ValueType___Expr150Get();
            }
            if ((expressionId == 151)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext151 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext151.GetLocation<double>(refDataContext151.ValueType___Expr151Get, refDataContext151.ValueType___Expr151Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 152)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext152 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext152.ValueType___Expr152Get();
            }
            if ((expressionId == 153)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext153 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext153.GetLocation<double>(refDataContext153.ValueType___Expr153Get, refDataContext153.ValueType___Expr153Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 154)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext154 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext154.ValueType___Expr154Get();
            }
            if ((expressionId == 155)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext155 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext155.GetLocation<double>(refDataContext155.ValueType___Expr155Get, refDataContext155.ValueType___Expr155Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 156)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext156 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext156.ValueType___Expr156Get();
            }
            if ((expressionId == 157)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext157 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext157.GetLocation<double>(refDataContext157.ValueType___Expr157Get, refDataContext157.ValueType___Expr157Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 158)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext158 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext158.ValueType___Expr158Get();
            }
            if ((expressionId == 159)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext159 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext159.GetLocation<double>(refDataContext159.ValueType___Expr159Get, refDataContext159.ValueType___Expr159Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 160)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext160 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext160.ValueType___Expr160Get();
            }
            if ((expressionId == 161)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext161 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext161.GetLocation<double>(refDataContext161.ValueType___Expr161Get, refDataContext161.ValueType___Expr161Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 162)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext162 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext162.ValueType___Expr162Get();
            }
            if ((expressionId == 163)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext163 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext163.GetLocation<double>(refDataContext163.ValueType___Expr163Get, refDataContext163.ValueType___Expr163Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 164)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext164 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext164.ValueType___Expr164Get();
            }
            if ((expressionId == 165)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext165 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext165.GetLocation<double>(refDataContext165.ValueType___Expr165Get, refDataContext165.ValueType___Expr165Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 166)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext166 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext166.ValueType___Expr166Get();
            }
            if ((expressionId == 167)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext167 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext167.GetLocation<double>(refDataContext167.ValueType___Expr167Get, refDataContext167.ValueType___Expr167Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 168)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext168 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext168.ValueType___Expr168Get();
            }
            if ((expressionId == 169)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext169 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext169.ValueType___Expr169Get();
            }
            if ((expressionId == 170)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext170 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext170.GetLocation<string>(refDataContext170.ValueType___Expr170Get, refDataContext170.ValueType___Expr170Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 171)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext171 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext171.ValueType___Expr171Get();
            }
            if ((expressionId == 172)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext172 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext172.GetLocation<string>(refDataContext172.ValueType___Expr172Get, refDataContext172.ValueType___Expr172Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 173)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext173 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext173.ValueType___Expr173Get();
            }
            if ((expressionId == 174)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext174 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext174.ValueType___Expr174Get();
            }
            if ((expressionId == 175)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext175 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext175.GetLocation<string>(refDataContext175.ValueType___Expr175Get, refDataContext175.ValueType___Expr175Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 176)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext176 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext176.ValueType___Expr176Get();
            }
            if ((expressionId == 177)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext177 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext177.GetLocation<string>(refDataContext177.ValueType___Expr177Get, refDataContext177.ValueType___Expr177Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 178)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext178 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext178.ValueType___Expr178Get();
            }
            if ((expressionId == 179)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext179 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext179.ValueType___Expr179Get();
            }
            if ((expressionId == 180)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext180 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext180.GetLocation<string>(refDataContext180.ValueType___Expr180Get, refDataContext180.ValueType___Expr180Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 181)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext181 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext181.ValueType___Expr181Get();
            }
            if ((expressionId == 182)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext182 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext182.GetLocation<string>(refDataContext182.ValueType___Expr182Get, refDataContext182.ValueType___Expr182Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 183)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext183 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext183.ValueType___Expr183Get();
            }
            if ((expressionId == 184)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext184 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext184.GetLocation<System.Nullable<double>>(refDataContext184.ValueType___Expr184Get, refDataContext184.ValueType___Expr184Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 185)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext185 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext185.ValueType___Expr185Get();
            }
            if ((expressionId == 186)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext186 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext186.GetLocation<double>(refDataContext186.ValueType___Expr186Get, refDataContext186.ValueType___Expr186Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 187)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext187 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext187.ValueType___Expr187Get();
            }
            if ((expressionId == 188)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext188 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext188.GetLocation<double>(refDataContext188.ValueType___Expr188Get, refDataContext188.ValueType___Expr188Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 189)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext189 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext189.ValueType___Expr189Get();
            }
            if ((expressionId == 190)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext190 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext190.GetLocation<double>(refDataContext190.ValueType___Expr190Get, refDataContext190.ValueType___Expr190Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 191)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext191 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext191.ValueType___Expr191Get();
            }
            if ((expressionId == 192)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext192 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext192.GetLocation<double>(refDataContext192.ValueType___Expr192Get, refDataContext192.ValueType___Expr192Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 193)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext193 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext193.ValueType___Expr193Get();
            }
            if ((expressionId == 194)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext194 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext194.GetLocation<double>(refDataContext194.ValueType___Expr194Get, refDataContext194.ValueType___Expr194Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 195)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext195 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext195.ValueType___Expr195Get();
            }
            if ((expressionId == 196)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext196 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext196.GetLocation<double>(refDataContext196.ValueType___Expr196Get, refDataContext196.ValueType___Expr196Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 197)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext197 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext197.ValueType___Expr197Get();
            }
            if ((expressionId == 198)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext198 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext198.GetLocation<double>(refDataContext198.ValueType___Expr198Get, refDataContext198.ValueType___Expr198Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 199)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext199 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext199.ValueType___Expr199Get();
            }
            if ((expressionId == 200)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext200 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext200.GetLocation<double>(refDataContext200.ValueType___Expr200Get, refDataContext200.ValueType___Expr200Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 201)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext201 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext201.ValueType___Expr201Get();
            }
            if ((expressionId == 202)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext202 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext202.GetLocation<double>(refDataContext202.ValueType___Expr202Get, refDataContext202.ValueType___Expr202Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 203)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext203 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext203.ValueType___Expr203Get();
            }
            if ((expressionId == 204)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext204 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext204.ValueType___Expr204Get();
            }
            if ((expressionId == 205)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext205 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext205.GetLocation<string>(refDataContext205.ValueType___Expr205Get, refDataContext205.ValueType___Expr205Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 206)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext206 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext206.ValueType___Expr206Get();
            }
            if ((expressionId == 207)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext207 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext207.GetLocation<string>(refDataContext207.ValueType___Expr207Get, refDataContext207.ValueType___Expr207Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 208)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext208 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext208.ValueType___Expr208Get();
            }
            if ((expressionId == 209)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext209 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext209.ValueType___Expr209Get();
            }
            if ((expressionId == 210)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext210 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext210.GetLocation<string>(refDataContext210.ValueType___Expr210Get, refDataContext210.ValueType___Expr210Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 211)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext211 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext211.ValueType___Expr211Get();
            }
            if ((expressionId == 212)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext212 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext212.GetLocation<string>(refDataContext212.ValueType___Expr212Get, refDataContext212.ValueType___Expr212Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 213)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext213 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext213.ValueType___Expr213Get();
            }
            if ((expressionId == 214)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext214 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext214.ValueType___Expr214Get();
            }
            if ((expressionId == 215)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext215 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext215.GetLocation<string>(refDataContext215.ValueType___Expr215Get, refDataContext215.ValueType___Expr215Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 216)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext216 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext216.ValueType___Expr216Get();
            }
            if ((expressionId == 217)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext217 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext217.GetLocation<string>(refDataContext217.ValueType___Expr217Get, refDataContext217.ValueType___Expr217Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 218)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext218 = ((F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext218.ValueType___Expr218Get();
            }
            if ((expressionId == 219)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext219 = ((F1040EZTaxesAndPenalties_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext219.GetLocation<System.Nullable<double>>(refDataContext219.ValueType___Expr219Get, refDataContext219.ValueType___Expr219Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 220)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly valDataContext220 = ((F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext220.ValueType___Expr220Get();
            }
            if ((expressionId == 221)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly valDataContext221 = ((F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext221.ValueType___Expr221Get();
            }
            if ((expressionId == 222)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxesAndPenalties_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext3 refDataContext222 = ((F1040EZTaxesAndPenalties_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext222.GetLocation<double>(refDataContext222.ValueType___Expr222Get, refDataContext222.ValueType___Expr222Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 223)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxesAndPenalties_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 12);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxesAndPenalties_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxesAndPenalties_TypedDataContext3 refDataContext223 = ((F1040EZTaxesAndPenalties_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext223.GetLocation<double>(refDataContext223.ValueType___Expr223Get, refDataContext223.ValueType___Expr223Set, expressionId, this.rootActivity, activityContext);
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
                F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly valDataContext0 = new F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly valDataContext1 = new F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly valDataContext2 = new F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly valDataContext3 = new F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                F1040EZTaxesAndPenalties_TypedDataContext3 refDataContext4 = new F1040EZTaxesAndPenalties_TypedDataContext3(locations, true);
                return refDataContext4.GetLocation<double>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly valDataContext5 = new F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext6 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext7 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext8 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext9 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext10 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext11 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext11.GetLocation<System.Collections.Generic.List<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue>>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext12 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext13 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext13.GetLocation<bool>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext14 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly valDataContext15 = new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly valDataContext16 = new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly valDataContext17 = new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                F1040EZTaxesAndPenalties_TypedDataContext5 refDataContext18 = new F1040EZTaxesAndPenalties_TypedDataContext5(locations, true);
                return refDataContext18.GetLocation<int>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly valDataContext19 = new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly valDataContext20 = new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                F1040EZTaxesAndPenalties_TypedDataContext5 refDataContext21 = new F1040EZTaxesAndPenalties_TypedDataContext5(locations, true);
                return refDataContext21.GetLocation<double>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly valDataContext22 = new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                F1040EZTaxesAndPenalties_TypedDataContext5 refDataContext23 = new F1040EZTaxesAndPenalties_TypedDataContext5(locations, true);
                return refDataContext23.GetLocation<System.DateTime>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set);
            }
            if ((expressionId == 24)) {
                F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly valDataContext24 = new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                F1040EZTaxesAndPenalties_TypedDataContext5 refDataContext25 = new F1040EZTaxesAndPenalties_TypedDataContext5(locations, true);
                return refDataContext25.GetLocation<int>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set);
            }
            if ((expressionId == 26)) {
                F1040EZTaxesAndPenalties_TypedDataContext7_ForReadOnly valDataContext26 = new F1040EZTaxesAndPenalties_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext27 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext28 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext29 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext29.GetLocation<System.DateTime>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
            }
            if ((expressionId == 30)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext30 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext31 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext32 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext32.GetLocation<System.DateTime>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set);
            }
            if ((expressionId == 33)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext33 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext34 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext34.GetLocation<System.DateTime>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set);
            }
            if ((expressionId == 35)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext35 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext36 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext36.GetLocation<System.DateTime>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set);
            }
            if ((expressionId == 37)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext37 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext38 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext38.GetLocation<System.DateTime>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set);
            }
            if ((expressionId == 39)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext39 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext40 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext40.GetLocation<double>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set);
            }
            if ((expressionId == 41)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext41 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext42 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext42.GetLocation<double>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set);
            }
            if ((expressionId == 43)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext43 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext44 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext44.GetLocation<double>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set);
            }
            if ((expressionId == 45)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext45 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext46 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext46.GetLocation<double>(refDataContext46.ValueType___Expr46Get, refDataContext46.ValueType___Expr46Set);
            }
            if ((expressionId == 47)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext47 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext48 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext48.GetLocation<double>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set);
            }
            if ((expressionId == 49)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext49 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext50 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext50.GetLocation<double>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set);
            }
            if ((expressionId == 51)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext51 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext52 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext52.GetLocation<double>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set);
            }
            if ((expressionId == 53)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext53 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext54 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext54.GetLocation<double>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set);
            }
            if ((expressionId == 55)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext55 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext56 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext57 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext58 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext58.GetLocation<System.DateTime>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set);
            }
            if ((expressionId == 59)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext59 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext60 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext60.GetLocation<int>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set);
            }
            if ((expressionId == 61)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext61 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext62 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext62.GetLocation<int>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set);
            }
            if ((expressionId == 63)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext63 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext64 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext65 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext65.GetLocation<System.DateTime>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set);
            }
            if ((expressionId == 66)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext66 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext67 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext67.GetLocation<System.DateTime>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set);
            }
            if ((expressionId == 68)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext68 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext69 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext69.GetLocation<System.DateTime>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set);
            }
            if ((expressionId == 70)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext70 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext71 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext71.GetLocation<double>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set);
            }
            if ((expressionId == 72)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext72 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext73 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext73.GetLocation<double>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set);
            }
            if ((expressionId == 74)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext74 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext75 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext75.GetLocation<double>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set);
            }
            if ((expressionId == 76)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext76 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext77 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext77.GetLocation<double>(refDataContext77.ValueType___Expr77Get, refDataContext77.ValueType___Expr77Set);
            }
            if ((expressionId == 78)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext78 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext79 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext79.GetLocation<double>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set);
            }
            if ((expressionId == 80)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext80 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext81 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext81.GetLocation<double>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set);
            }
            if ((expressionId == 82)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext82 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext83 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext83.GetLocation<double>(refDataContext83.ValueType___Expr83Get, refDataContext83.ValueType___Expr83Set);
            }
            if ((expressionId == 84)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext84 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext84.ValueType___Expr84Get();
            }
            if ((expressionId == 85)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext85 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext85.GetLocation<double>(refDataContext85.ValueType___Expr85Get, refDataContext85.ValueType___Expr85Set);
            }
            if ((expressionId == 86)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext86 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext86.ValueType___Expr86Get();
            }
            if ((expressionId == 87)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext87 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext87.GetLocation<int>(refDataContext87.ValueType___Expr87Get, refDataContext87.ValueType___Expr87Set);
            }
            if ((expressionId == 88)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext88 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext89 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext89.GetLocation<System.DateTime>(refDataContext89.ValueType___Expr89Get, refDataContext89.ValueType___Expr89Set);
            }
            if ((expressionId == 90)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext90 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext90.ValueType___Expr90Get();
            }
            if ((expressionId == 91)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext91 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext91.GetLocation<System.DateTime>(refDataContext91.ValueType___Expr91Get, refDataContext91.ValueType___Expr91Set);
            }
            if ((expressionId == 92)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext92 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext92.ValueType___Expr92Get();
            }
            if ((expressionId == 93)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext93 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext93.GetLocation<double>(refDataContext93.ValueType___Expr93Get, refDataContext93.ValueType___Expr93Set);
            }
            if ((expressionId == 94)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext94 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext94.ValueType___Expr94Get();
            }
            if ((expressionId == 95)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext95 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext95.GetLocation<double>(refDataContext95.ValueType___Expr95Get, refDataContext95.ValueType___Expr95Set);
            }
            if ((expressionId == 96)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext96 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext96.ValueType___Expr96Get();
            }
            if ((expressionId == 97)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext97 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext97.GetLocation<double>(refDataContext97.ValueType___Expr97Get, refDataContext97.ValueType___Expr97Set);
            }
            if ((expressionId == 98)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext98 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext98.ValueType___Expr98Get();
            }
            if ((expressionId == 99)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext99 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext99.GetLocation<double>(refDataContext99.ValueType___Expr99Get, refDataContext99.ValueType___Expr99Set);
            }
            if ((expressionId == 100)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext100 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext100.ValueType___Expr100Get();
            }
            if ((expressionId == 101)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext101 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext101.GetLocation<double>(refDataContext101.ValueType___Expr101Get, refDataContext101.ValueType___Expr101Set);
            }
            if ((expressionId == 102)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext102 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext102.ValueType___Expr102Get();
            }
            if ((expressionId == 103)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext103 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext103.GetLocation<double>(refDataContext103.ValueType___Expr103Get, refDataContext103.ValueType___Expr103Set);
            }
            if ((expressionId == 104)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext104 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext104.ValueType___Expr104Get();
            }
            if ((expressionId == 105)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext105 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext105.GetLocation<double>(refDataContext105.ValueType___Expr105Get, refDataContext105.ValueType___Expr105Set);
            }
            if ((expressionId == 106)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext106 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext107 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext107.GetLocation<double>(refDataContext107.ValueType___Expr107Get, refDataContext107.ValueType___Expr107Set);
            }
            if ((expressionId == 108)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext108 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                F1040EZTaxesAndPenalties_TypedDataContext8 refDataContext109 = new F1040EZTaxesAndPenalties_TypedDataContext8(locations, true);
                return refDataContext109.GetLocation<int>(refDataContext109.ValueType___Expr109Get, refDataContext109.ValueType___Expr109Set);
            }
            if ((expressionId == 110)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext110 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly valDataContext111 = new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext111.ValueType___Expr111Get();
            }
            if ((expressionId == 112)) {
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext112 = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext112.ValueType___Expr112Get();
            }
            if ((expressionId == 113)) {
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext113 = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                F1040EZTaxesAndPenalties_TypedDataContext9 refDataContext114 = new F1040EZTaxesAndPenalties_TypedDataContext9(locations, true);
                return refDataContext114.GetLocation<System.DateTime>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set);
            }
            if ((expressionId == 115)) {
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext115 = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                F1040EZTaxesAndPenalties_TypedDataContext9 refDataContext116 = new F1040EZTaxesAndPenalties_TypedDataContext9(locations, true);
                return refDataContext116.GetLocation<System.DateTime>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set);
            }
            if ((expressionId == 117)) {
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext117 = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext117.ValueType___Expr117Get();
            }
            if ((expressionId == 118)) {
                F1040EZTaxesAndPenalties_TypedDataContext9 refDataContext118 = new F1040EZTaxesAndPenalties_TypedDataContext9(locations, true);
                return refDataContext118.GetLocation<double>(refDataContext118.ValueType___Expr118Get, refDataContext118.ValueType___Expr118Set);
            }
            if ((expressionId == 119)) {
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext119 = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext119.ValueType___Expr119Get();
            }
            if ((expressionId == 120)) {
                F1040EZTaxesAndPenalties_TypedDataContext9 refDataContext120 = new F1040EZTaxesAndPenalties_TypedDataContext9(locations, true);
                return refDataContext120.GetLocation<double>(refDataContext120.ValueType___Expr120Get, refDataContext120.ValueType___Expr120Set);
            }
            if ((expressionId == 121)) {
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext121 = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext121.ValueType___Expr121Get();
            }
            if ((expressionId == 122)) {
                F1040EZTaxesAndPenalties_TypedDataContext9 refDataContext122 = new F1040EZTaxesAndPenalties_TypedDataContext9(locations, true);
                return refDataContext122.GetLocation<double>(refDataContext122.ValueType___Expr122Get, refDataContext122.ValueType___Expr122Set);
            }
            if ((expressionId == 123)) {
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext123 = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext123.ValueType___Expr123Get();
            }
            if ((expressionId == 124)) {
                F1040EZTaxesAndPenalties_TypedDataContext9 refDataContext124 = new F1040EZTaxesAndPenalties_TypedDataContext9(locations, true);
                return refDataContext124.GetLocation<double>(refDataContext124.ValueType___Expr124Get, refDataContext124.ValueType___Expr124Set);
            }
            if ((expressionId == 125)) {
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext125 = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext125.ValueType___Expr125Get();
            }
            if ((expressionId == 126)) {
                F1040EZTaxesAndPenalties_TypedDataContext9 refDataContext126 = new F1040EZTaxesAndPenalties_TypedDataContext9(locations, true);
                return refDataContext126.GetLocation<double>(refDataContext126.ValueType___Expr126Get, refDataContext126.ValueType___Expr126Set);
            }
            if ((expressionId == 127)) {
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext127 = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext127.ValueType___Expr127Get();
            }
            if ((expressionId == 128)) {
                F1040EZTaxesAndPenalties_TypedDataContext9 refDataContext128 = new F1040EZTaxesAndPenalties_TypedDataContext9(locations, true);
                return refDataContext128.GetLocation<double>(refDataContext128.ValueType___Expr128Get, refDataContext128.ValueType___Expr128Set);
            }
            if ((expressionId == 129)) {
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext129 = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext129.ValueType___Expr129Get();
            }
            if ((expressionId == 130)) {
                F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly valDataContext130 = new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext130.ValueType___Expr130Get();
            }
            if ((expressionId == 131)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext131 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext131.ValueType___Expr131Get();
            }
            if ((expressionId == 132)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext132 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext132.GetLocation<System.Nullable<double>>(refDataContext132.ValueType___Expr132Get, refDataContext132.ValueType___Expr132Set);
            }
            if ((expressionId == 133)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext133 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext133.ValueType___Expr133Get();
            }
            if ((expressionId == 134)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext134 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext134.ValueType___Expr134Get();
            }
            if ((expressionId == 135)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext135 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext135.GetLocation<System.DateTime>(refDataContext135.ValueType___Expr135Get, refDataContext135.ValueType___Expr135Set);
            }
            if ((expressionId == 136)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext136 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext136.ValueType___Expr136Get();
            }
            if ((expressionId == 137)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext137 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext137.GetLocation<double>(refDataContext137.ValueType___Expr137Get, refDataContext137.ValueType___Expr137Set);
            }
            if ((expressionId == 138)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext138 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext139 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext139.GetLocation<double>(refDataContext139.ValueType___Expr139Get, refDataContext139.ValueType___Expr139Set);
            }
            if ((expressionId == 140)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext140 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext140.ValueType___Expr140Get();
            }
            if ((expressionId == 141)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext141 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext141.ValueType___Expr141Get();
            }
            if ((expressionId == 142)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext142 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext142.GetLocation<System.DateTime>(refDataContext142.ValueType___Expr142Get, refDataContext142.ValueType___Expr142Set);
            }
            if ((expressionId == 143)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext143 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext143.ValueType___Expr143Get();
            }
            if ((expressionId == 144)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext144 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext144.GetLocation<double>(refDataContext144.ValueType___Expr144Get, refDataContext144.ValueType___Expr144Set);
            }
            if ((expressionId == 145)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext145 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext145.ValueType___Expr145Get();
            }
            if ((expressionId == 146)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext146 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext146.GetLocation<double>(refDataContext146.ValueType___Expr146Get, refDataContext146.ValueType___Expr146Set);
            }
            if ((expressionId == 147)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext147 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext147.ValueType___Expr147Get();
            }
            if ((expressionId == 148)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext148 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext148.GetLocation<double>(refDataContext148.ValueType___Expr148Get, refDataContext148.ValueType___Expr148Set);
            }
            if ((expressionId == 149)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext149 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext149.GetLocation<double>(refDataContext149.ValueType___Expr149Get, refDataContext149.ValueType___Expr149Set);
            }
            if ((expressionId == 150)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext150 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext150.ValueType___Expr150Get();
            }
            if ((expressionId == 151)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext151 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext151.GetLocation<double>(refDataContext151.ValueType___Expr151Get, refDataContext151.ValueType___Expr151Set);
            }
            if ((expressionId == 152)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext152 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext152.ValueType___Expr152Get();
            }
            if ((expressionId == 153)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext153 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext153.GetLocation<double>(refDataContext153.ValueType___Expr153Get, refDataContext153.ValueType___Expr153Set);
            }
            if ((expressionId == 154)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext154 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext154.ValueType___Expr154Get();
            }
            if ((expressionId == 155)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext155 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext155.GetLocation<double>(refDataContext155.ValueType___Expr155Get, refDataContext155.ValueType___Expr155Set);
            }
            if ((expressionId == 156)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext156 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext156.ValueType___Expr156Get();
            }
            if ((expressionId == 157)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext157 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext157.GetLocation<double>(refDataContext157.ValueType___Expr157Get, refDataContext157.ValueType___Expr157Set);
            }
            if ((expressionId == 158)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext158 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext158.ValueType___Expr158Get();
            }
            if ((expressionId == 159)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext159 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext159.GetLocation<double>(refDataContext159.ValueType___Expr159Get, refDataContext159.ValueType___Expr159Set);
            }
            if ((expressionId == 160)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext160 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext160.ValueType___Expr160Get();
            }
            if ((expressionId == 161)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext161 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext161.GetLocation<double>(refDataContext161.ValueType___Expr161Get, refDataContext161.ValueType___Expr161Set);
            }
            if ((expressionId == 162)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext162 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext162.ValueType___Expr162Get();
            }
            if ((expressionId == 163)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext163 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext163.GetLocation<double>(refDataContext163.ValueType___Expr163Get, refDataContext163.ValueType___Expr163Set);
            }
            if ((expressionId == 164)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext164 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext164.ValueType___Expr164Get();
            }
            if ((expressionId == 165)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext165 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext165.GetLocation<double>(refDataContext165.ValueType___Expr165Get, refDataContext165.ValueType___Expr165Set);
            }
            if ((expressionId == 166)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext166 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext166.ValueType___Expr166Get();
            }
            if ((expressionId == 167)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext167 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext167.GetLocation<double>(refDataContext167.ValueType___Expr167Get, refDataContext167.ValueType___Expr167Set);
            }
            if ((expressionId == 168)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext168 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext168.ValueType___Expr168Get();
            }
            if ((expressionId == 169)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext169 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext169.ValueType___Expr169Get();
            }
            if ((expressionId == 170)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext170 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext170.GetLocation<string>(refDataContext170.ValueType___Expr170Get, refDataContext170.ValueType___Expr170Set);
            }
            if ((expressionId == 171)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext171 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext171.ValueType___Expr171Get();
            }
            if ((expressionId == 172)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext172 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext172.GetLocation<string>(refDataContext172.ValueType___Expr172Get, refDataContext172.ValueType___Expr172Set);
            }
            if ((expressionId == 173)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext173 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext173.ValueType___Expr173Get();
            }
            if ((expressionId == 174)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext174 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext174.ValueType___Expr174Get();
            }
            if ((expressionId == 175)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext175 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext175.GetLocation<string>(refDataContext175.ValueType___Expr175Get, refDataContext175.ValueType___Expr175Set);
            }
            if ((expressionId == 176)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext176 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext176.ValueType___Expr176Get();
            }
            if ((expressionId == 177)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext177 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext177.GetLocation<string>(refDataContext177.ValueType___Expr177Get, refDataContext177.ValueType___Expr177Set);
            }
            if ((expressionId == 178)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext178 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext178.ValueType___Expr178Get();
            }
            if ((expressionId == 179)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext179 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext179.ValueType___Expr179Get();
            }
            if ((expressionId == 180)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext180 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext180.GetLocation<string>(refDataContext180.ValueType___Expr180Get, refDataContext180.ValueType___Expr180Set);
            }
            if ((expressionId == 181)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext181 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext181.ValueType___Expr181Get();
            }
            if ((expressionId == 182)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext182 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext182.GetLocation<string>(refDataContext182.ValueType___Expr182Get, refDataContext182.ValueType___Expr182Set);
            }
            if ((expressionId == 183)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext183 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext183.ValueType___Expr183Get();
            }
            if ((expressionId == 184)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext184 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext184.GetLocation<System.Nullable<double>>(refDataContext184.ValueType___Expr184Get, refDataContext184.ValueType___Expr184Set);
            }
            if ((expressionId == 185)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext185 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext185.ValueType___Expr185Get();
            }
            if ((expressionId == 186)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext186 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext186.GetLocation<double>(refDataContext186.ValueType___Expr186Get, refDataContext186.ValueType___Expr186Set);
            }
            if ((expressionId == 187)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext187 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext187.ValueType___Expr187Get();
            }
            if ((expressionId == 188)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext188 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext188.GetLocation<double>(refDataContext188.ValueType___Expr188Get, refDataContext188.ValueType___Expr188Set);
            }
            if ((expressionId == 189)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext189 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext189.ValueType___Expr189Get();
            }
            if ((expressionId == 190)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext190 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext190.GetLocation<double>(refDataContext190.ValueType___Expr190Get, refDataContext190.ValueType___Expr190Set);
            }
            if ((expressionId == 191)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext191 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext191.ValueType___Expr191Get();
            }
            if ((expressionId == 192)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext192 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext192.GetLocation<double>(refDataContext192.ValueType___Expr192Get, refDataContext192.ValueType___Expr192Set);
            }
            if ((expressionId == 193)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext193 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext193.ValueType___Expr193Get();
            }
            if ((expressionId == 194)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext194 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext194.GetLocation<double>(refDataContext194.ValueType___Expr194Get, refDataContext194.ValueType___Expr194Set);
            }
            if ((expressionId == 195)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext195 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext195.ValueType___Expr195Get();
            }
            if ((expressionId == 196)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext196 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext196.GetLocation<double>(refDataContext196.ValueType___Expr196Get, refDataContext196.ValueType___Expr196Set);
            }
            if ((expressionId == 197)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext197 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext197.ValueType___Expr197Get();
            }
            if ((expressionId == 198)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext198 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext198.GetLocation<double>(refDataContext198.ValueType___Expr198Get, refDataContext198.ValueType___Expr198Set);
            }
            if ((expressionId == 199)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext199 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext199.ValueType___Expr199Get();
            }
            if ((expressionId == 200)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext200 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext200.GetLocation<double>(refDataContext200.ValueType___Expr200Get, refDataContext200.ValueType___Expr200Set);
            }
            if ((expressionId == 201)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext201 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext201.ValueType___Expr201Get();
            }
            if ((expressionId == 202)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext202 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext202.GetLocation<double>(refDataContext202.ValueType___Expr202Get, refDataContext202.ValueType___Expr202Set);
            }
            if ((expressionId == 203)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext203 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext203.ValueType___Expr203Get();
            }
            if ((expressionId == 204)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext204 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext204.ValueType___Expr204Get();
            }
            if ((expressionId == 205)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext205 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext205.GetLocation<string>(refDataContext205.ValueType___Expr205Get, refDataContext205.ValueType___Expr205Set);
            }
            if ((expressionId == 206)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext206 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext206.ValueType___Expr206Get();
            }
            if ((expressionId == 207)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext207 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext207.GetLocation<string>(refDataContext207.ValueType___Expr207Get, refDataContext207.ValueType___Expr207Set);
            }
            if ((expressionId == 208)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext208 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext208.ValueType___Expr208Get();
            }
            if ((expressionId == 209)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext209 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext209.ValueType___Expr209Get();
            }
            if ((expressionId == 210)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext210 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext210.GetLocation<string>(refDataContext210.ValueType___Expr210Get, refDataContext210.ValueType___Expr210Set);
            }
            if ((expressionId == 211)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext211 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext211.ValueType___Expr211Get();
            }
            if ((expressionId == 212)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext212 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext212.GetLocation<string>(refDataContext212.ValueType___Expr212Get, refDataContext212.ValueType___Expr212Set);
            }
            if ((expressionId == 213)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext213 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext213.ValueType___Expr213Get();
            }
            if ((expressionId == 214)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext214 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext214.ValueType___Expr214Get();
            }
            if ((expressionId == 215)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext215 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext215.GetLocation<string>(refDataContext215.ValueType___Expr215Get, refDataContext215.ValueType___Expr215Set);
            }
            if ((expressionId == 216)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext216 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext216.ValueType___Expr216Get();
            }
            if ((expressionId == 217)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext217 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext217.GetLocation<string>(refDataContext217.ValueType___Expr217Get, refDataContext217.ValueType___Expr217Set);
            }
            if ((expressionId == 218)) {
                F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly valDataContext218 = new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext218.ValueType___Expr218Get();
            }
            if ((expressionId == 219)) {
                F1040EZTaxesAndPenalties_TypedDataContext4 refDataContext219 = new F1040EZTaxesAndPenalties_TypedDataContext4(locations, true);
                return refDataContext219.GetLocation<System.Nullable<double>>(refDataContext219.ValueType___Expr219Get, refDataContext219.ValueType___Expr219Set);
            }
            if ((expressionId == 220)) {
                F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly valDataContext220 = new F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext220.ValueType___Expr220Get();
            }
            if ((expressionId == 221)) {
                F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly valDataContext221 = new F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext221.ValueType___Expr221Get();
            }
            if ((expressionId == 222)) {
                F1040EZTaxesAndPenalties_TypedDataContext3 refDataContext222 = new F1040EZTaxesAndPenalties_TypedDataContext3(locations, true);
                return refDataContext222.GetLocation<double>(refDataContext222.ValueType___Expr222Get, refDataContext222.ValueType___Expr222Set);
            }
            if ((expressionId == 223)) {
                F1040EZTaxesAndPenalties_TypedDataContext3 refDataContext223 = new F1040EZTaxesAndPenalties_TypedDataContext3(locations, true);
                return refDataContext223.GetLocation<double>(refDataContext223.ValueType___Expr223Get, refDataContext223.ValueType___Expr223Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "new DateTime(DateTime.Today.Year+1, 4, 15);") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object != null) && (Tax1040Object.OutputForms != null) && (Tax1040Object" +
                            ".OutputForms.Tax1040EZPage1 !=null) )") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties.FilingDate.HasValue ? Tax1040Object.TaxesAndPenal" +
                            "ties.FilingDate.Value : new DateTime(DateTime.Today.Year, DateTime.Today.Month, " +
                            "DateTime.Today.Day)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount - Tax1040Object.OutputForms.Ta" +
                            "x1040EZPage1.TotalPaymentsAndCredits") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "taxdueamount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(taxdueamount >= 0 && (filingDate > dueDate))") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(filingDate - dueDate).Days") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(datedifference / 30)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "filingDate - dueDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(taxdueamount * ((double)interestAmount / 100) * ((double)datedifferenc" +
                            "e / 365), 2)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new List<InterestOnUnpaidDue>()") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties !=null && Tax1040Object.TaxesAndPenalties.HasFile" +
                            "dForm4868.HasValue ? Tax1040Object.TaxesAndPenalties.HasFiledForm4868.Value : fa" +
                            "lse") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "hasExtended") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "datedifferentmonth.Days > 0") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "month") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dueDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((filingDate.Year - dueDate.Year) * 12) + filingDate.Month - dueDate.Month") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "month") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "month > 2") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "taxdueamount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "runningCalculation") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dueDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentQuater") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "month") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "monthbetweenfilingdateAndduedate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iteration <= monthbetweenfilingdateAndduedate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new InterestOnUnpaidDue()") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dueDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.QuarterStartDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "currentQuater.Month == staticmonth") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "currentQuater.AddMonths(2)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentQuater") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new DateTime(currentQuater.Year, currentQuater.Month, 1)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentQuater") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dueDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.QuarterStartDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new DateTime(dueDate.Year, currentQuater.Month, DateTime.DaysInMonth(currentQuate" +
                            "r.Year, currentQuater.Month))") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.QuarterEndDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "interestAmount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.interestRate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(interestOnUnpaidDue.QuarterEndDate - interestOnUnpaidDue.QuarterStartDate).Days;" +
                            "") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "datedifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(datedifference / 30, 2)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "monthdifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "datedifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.NumberOfDays") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(taxdueamount * ((double)interestAmount / 100) * ((double)datedifferenc" +
                            "e / 365), 2)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.InterestAmount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "runningCalculation") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.Amount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "runningCalculation + interestOnUnpaidDue.InterestAmount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "runningCalculation") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "runningCalculation") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.Balance") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "interestOnUnpaidDue") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "interestOnUnpaidDue.QuarterEndDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentQuater") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iteration+2") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "iteration") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((filingDate.Year - currentQuater.Year) * 12) + filingDate.Month - currentQuater." +
                            "Month") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "month") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "month > 3") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new DateTime(currentQuater.Year, currentQuater.AddMonths(1).Month, 1)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.QuarterStartDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "currentQuater.AddMonths(3)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentQuater") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new DateTime(currentQuater.Year, currentQuater.Month, DateTime.DaysInMonth(curren" +
                            "tQuater.Year, currentQuater.Month))") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.QuarterEndDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "interestAmount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.interestRate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(interestOnUnpaidDue.QuarterEndDate - interestOnUnpaidDue.QuarterStartDate).Days") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "datedifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(datedifference / 30, 2)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "monthdifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 75;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "datedifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 76;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.NumberOfDays") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 77;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(taxdueamount * ((double)interestAmount / 100) * ((double)datedifferenc" +
                            "e / 365), 2)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 78;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.InterestAmount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 79;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "runningCalculation") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 80;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.Amount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 81;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "runningCalculation + interestOnUnpaidDue.InterestAmount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 82;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "runningCalculation") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 83;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "runningCalculation") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 84;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.Balance") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 85;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iteration+3") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 86;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "iteration") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 87;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new DateTime(currentQuater.Year, currentQuater.AddMonths(1).Month, 1)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 88;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.QuarterStartDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 89;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new DateTime(filingDate.Year, filingDate.Month, filingDate.Day)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 90;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.QuarterEndDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 91;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "interestAmount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 92;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.interestRate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 93;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(interestOnUnpaidDue.QuarterEndDate - interestOnUnpaidDue.QuarterStartDate).Days") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 94;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "datedifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 95;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(datedifference / 30, 2)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 96;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "monthdifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 97;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "datedifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 98;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.NumberOfDays") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 99;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(taxdueamount * ((double)interestAmount / 100) * ((double)datedifferenc" +
                            "e / 365), 2)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 100;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.InterestAmount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 101;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "runningCalculation") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 102;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.Amount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 103;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "runningCalculation + interestOnUnpaidDue.InterestAmount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 104;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "runningCalculation") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 105;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "runningCalculation") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 106;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDue.Balance") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 107;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iteration+month") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 108;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "iteration") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 109;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 110;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "interestOnUnpaidDue") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 111;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new InterestOnUnpaidDue ()") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 112;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dueDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 113;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDuenormal.QuarterStartDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 114;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "filingDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 115;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDuenormal.QuarterEndDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 116;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "interestAmount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 117;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDuenormal.interestRate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 118;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "taxdueamount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 119;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDuenormal.Amount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 120;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(interestOnUnpaidDuenormal.QuarterEndDate - interestOnUnpaidDuenormal.QuarterStar" +
                            "tDate).Days") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 121;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "datedifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 122;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "datedifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 123;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDuenormal.NumberOfDays") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 124;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(taxdueamount * ((double)interestAmount / 100) * ((double)datedifferenc" +
                            "e / 365), 2)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 125;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDuenormal.InterestAmount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 126;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "taxdueamount + interestOnUnpaidDuenormal.InterestAmount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 127;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "interestOnUnpaidDuenormal.Balance") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 128;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 129;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "interestOnUnpaidDuenormal") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 130;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "0") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 131;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 132;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "hasExtended") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 133;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dueDate.AddMonths(6)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 134;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dueDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 135;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(filingDate - dueDate).Days") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 136;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "datedifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 137;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(datedifference / 30)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 138;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "monthdifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 139;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(filingDate - dueDate).Days < 0") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 140;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dueDate.AddMonths(-6)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 141;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dueDate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 142;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(filingDate - dueDate).Days") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 143;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "datedifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 144;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(datedifference / 30, 2)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 145;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "monthdifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 146;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Min((((double)0.5 / 100) * monthdifference * taxdueamount), (((double)25 / 1" +
                            "00) * taxdueamount))") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 147;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LatePaymentPenaltybeforeduedate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 148;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "monthdifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 149;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "LateFilingPenalty + LatePaymentPenaltybeforeduedate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 150;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LateFilingPenaltyforInterest") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 151;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((double)5 / 100) * taxdueamount * monthdifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 152;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "fivepercentpenality") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 153;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((double)25 / 100) * taxdueamount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 154;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "twentyfivepercentpenality") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 155;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Min(fivepercentpenality, twentyfivepercentpenality)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 156;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LateFilingPenalty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 157;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Min((((double)0.5 / 100) * 6 * taxdueamount), (((double)25 / 100) * taxdueam" +
                            "ount))") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 158;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LatePaymentPenaltybeforeduedate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 159;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Min((((double)0.5 / 100) * monthdifference * taxdueamount), (((double)25 / 1" +
                            "00) * taxdueamount))") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 160;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LatePaymentPenaltyafterduedate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 161;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "LateFilingPenalty - LatePaymentPenaltyafterduedate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 162;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LateFilingPenaltyforInterest") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 163;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "LateFilingPenaltyforInterest * ((double)3 / 100) * ((double)datedifference / 365)" +
                            "") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 164;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "InterestonLateFilingPenalty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 165;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue.Select(a => a.InterestAmount)" +
                            ".Sum() + InterestonLateFilingPenalty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 166;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "totalinterest") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 167;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(totalinterest, MidpointRounding.AwayFromZero)>0") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 168;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"INT $\" + Math.Round(totalinterest, MidpointRounding.AwayFromZero).ToString()") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 169;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Interest") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 170;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "string.Empty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 171;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Interest") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 172;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(LateFilingPenalty, MidpointRounding.AwayFromZero)> 0") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 173;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"FTF $\" +Math.Round(LateFilingPenalty, MidpointRounding.AwayFromZero).ToString()") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 174;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.LateFilingPenalty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 175;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "string.Empty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 176;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.LateFilingPenalty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 177;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(LatePaymentPenaltyafterduedate, MidpointRounding.AwayFromZero) > 0") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 178;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"FTP $\" + Math.Round(LatePaymentPenaltyafterduedate, MidpointRounding.AwayFromZer" +
                            "o).ToString()") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 179;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.LatePaymentPenalty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 180;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "string.Empty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 181;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.LatePaymentPenalty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 182;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round((LateFilingPenalty + Math.Max(LatePaymentPenaltybeforeduedate, LatePay" +
                            "mentPenaltyafterduedate)) + totalinterest)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 183;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 184;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(filingDate - dueDate).Days") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 185;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "datedifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 186;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(datedifference / 30)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 187;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "monthdifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 188;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((double)5 / 100) * taxdueamount * monthdifference") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 189;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "fivepercentpenality") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 190;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((double)25 / 100) * taxdueamount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 191;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "twentyfivepercentpenality") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 192;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Min(fivepercentpenality, twentyfivepercentpenality)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 193;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LateFilingPenalty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 194;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Min((((double)0.5 / 100) * monthdifference * taxdueamount), (((double)25 / 1" +
                            "00) * taxdueamount))") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 195;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LatePaymentPenaltyafterduedate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 196;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "LateFilingPenalty - LatePaymentPenaltyafterduedate") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 197;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LateFilingPenaltyforInterest") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 198;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "LateFilingPenaltyforInterest * ((double)3 / 100) * ((double)datedifference / 365)" +
                            "") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 199;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "InterestonLateFilingPenalty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 200;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue.Select(a => a.InterestAmount)" +
                            ".Sum() + InterestonLateFilingPenalty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 201;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "totalinterest") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 202;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(totalinterest, MidpointRounding.AwayFromZero)>0") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 203;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"INT $\" + Math.Round(totalinterest, MidpointRounding.AwayFromZero).ToString()") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 204;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Interest") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 205;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "string.Empty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 206;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Interest") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 207;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(LateFilingPenalty, MidpointRounding.AwayFromZero)> 0") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 208;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"FTF $\"+Math.Round(LateFilingPenalty, MidpointRounding.AwayFromZero).ToString()") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 209;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.LateFilingPenalty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 210;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "string.Empty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 211;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.LateFilingPenalty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 212;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(LatePaymentPenaltyafterduedate, MidpointRounding.AwayFromZero) > 0") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 213;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"FTP $\" + Math.Round(LatePaymentPenaltyafterduedate, MidpointRounding.AwayFromZer" +
                            "o).ToString()") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 214;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.LatePaymentPenalty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 215;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "string.Empty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 216;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.LatePaymentPenalty") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 217;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(Math.Max(LateFilingPenalty, Math.Max(LatePaymentPenaltybeforeduedate, " +
                            "LatePaymentPenaltyafterduedate)) + totalinterest)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 218;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 219;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "taxdueamount < 0") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 220;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(Math.Abs(taxdueamount),2)") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 221;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 222;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount") 
                        && (F1040EZTaxesAndPenalties_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 223;
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
                return new F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext3(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext5(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext5(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext5(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext5(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext7_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr74GetTree();
            }
            if ((expressionId == 75)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr75GetTree();
            }
            if ((expressionId == 76)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr76GetTree();
            }
            if ((expressionId == 77)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr77GetTree();
            }
            if ((expressionId == 78)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr78GetTree();
            }
            if ((expressionId == 79)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr79GetTree();
            }
            if ((expressionId == 80)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr80GetTree();
            }
            if ((expressionId == 81)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr81GetTree();
            }
            if ((expressionId == 82)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr82GetTree();
            }
            if ((expressionId == 83)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr83GetTree();
            }
            if ((expressionId == 84)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr84GetTree();
            }
            if ((expressionId == 85)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr85GetTree();
            }
            if ((expressionId == 86)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr86GetTree();
            }
            if ((expressionId == 87)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr87GetTree();
            }
            if ((expressionId == 88)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr88GetTree();
            }
            if ((expressionId == 89)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr89GetTree();
            }
            if ((expressionId == 90)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr90GetTree();
            }
            if ((expressionId == 91)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr91GetTree();
            }
            if ((expressionId == 92)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr92GetTree();
            }
            if ((expressionId == 93)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr93GetTree();
            }
            if ((expressionId == 94)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr94GetTree();
            }
            if ((expressionId == 95)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr95GetTree();
            }
            if ((expressionId == 96)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr96GetTree();
            }
            if ((expressionId == 97)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr97GetTree();
            }
            if ((expressionId == 98)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr98GetTree();
            }
            if ((expressionId == 99)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr99GetTree();
            }
            if ((expressionId == 100)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr100GetTree();
            }
            if ((expressionId == 101)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr101GetTree();
            }
            if ((expressionId == 102)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr102GetTree();
            }
            if ((expressionId == 103)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr103GetTree();
            }
            if ((expressionId == 104)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr104GetTree();
            }
            if ((expressionId == 105)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr105GetTree();
            }
            if ((expressionId == 106)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr106GetTree();
            }
            if ((expressionId == 107)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr107GetTree();
            }
            if ((expressionId == 108)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr108GetTree();
            }
            if ((expressionId == 109)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8(locationReferences).@__Expr109GetTree();
            }
            if ((expressionId == 110)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr110GetTree();
            }
            if ((expressionId == 111)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(locationReferences).@__Expr111GetTree();
            }
            if ((expressionId == 112)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locationReferences).@__Expr112GetTree();
            }
            if ((expressionId == 113)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locationReferences).@__Expr113GetTree();
            }
            if ((expressionId == 114)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9(locationReferences).@__Expr114GetTree();
            }
            if ((expressionId == 115)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locationReferences).@__Expr115GetTree();
            }
            if ((expressionId == 116)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9(locationReferences).@__Expr116GetTree();
            }
            if ((expressionId == 117)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locationReferences).@__Expr117GetTree();
            }
            if ((expressionId == 118)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9(locationReferences).@__Expr118GetTree();
            }
            if ((expressionId == 119)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locationReferences).@__Expr119GetTree();
            }
            if ((expressionId == 120)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9(locationReferences).@__Expr120GetTree();
            }
            if ((expressionId == 121)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locationReferences).@__Expr121GetTree();
            }
            if ((expressionId == 122)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9(locationReferences).@__Expr122GetTree();
            }
            if ((expressionId == 123)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locationReferences).@__Expr123GetTree();
            }
            if ((expressionId == 124)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9(locationReferences).@__Expr124GetTree();
            }
            if ((expressionId == 125)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locationReferences).@__Expr125GetTree();
            }
            if ((expressionId == 126)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9(locationReferences).@__Expr126GetTree();
            }
            if ((expressionId == 127)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locationReferences).@__Expr127GetTree();
            }
            if ((expressionId == 128)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9(locationReferences).@__Expr128GetTree();
            }
            if ((expressionId == 129)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locationReferences).@__Expr129GetTree();
            }
            if ((expressionId == 130)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(locationReferences).@__Expr130GetTree();
            }
            if ((expressionId == 131)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr131GetTree();
            }
            if ((expressionId == 132)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr132GetTree();
            }
            if ((expressionId == 133)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr133GetTree();
            }
            if ((expressionId == 134)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr134GetTree();
            }
            if ((expressionId == 135)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr135GetTree();
            }
            if ((expressionId == 136)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr136GetTree();
            }
            if ((expressionId == 137)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr137GetTree();
            }
            if ((expressionId == 138)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr138GetTree();
            }
            if ((expressionId == 139)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr139GetTree();
            }
            if ((expressionId == 140)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr140GetTree();
            }
            if ((expressionId == 141)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr141GetTree();
            }
            if ((expressionId == 142)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr142GetTree();
            }
            if ((expressionId == 143)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr143GetTree();
            }
            if ((expressionId == 144)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr144GetTree();
            }
            if ((expressionId == 145)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr145GetTree();
            }
            if ((expressionId == 146)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr146GetTree();
            }
            if ((expressionId == 147)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr147GetTree();
            }
            if ((expressionId == 148)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr148GetTree();
            }
            if ((expressionId == 149)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr149GetTree();
            }
            if ((expressionId == 150)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr150GetTree();
            }
            if ((expressionId == 151)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr151GetTree();
            }
            if ((expressionId == 152)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr152GetTree();
            }
            if ((expressionId == 153)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr153GetTree();
            }
            if ((expressionId == 154)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr154GetTree();
            }
            if ((expressionId == 155)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr155GetTree();
            }
            if ((expressionId == 156)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr156GetTree();
            }
            if ((expressionId == 157)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr157GetTree();
            }
            if ((expressionId == 158)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr158GetTree();
            }
            if ((expressionId == 159)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr159GetTree();
            }
            if ((expressionId == 160)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr160GetTree();
            }
            if ((expressionId == 161)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr161GetTree();
            }
            if ((expressionId == 162)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr162GetTree();
            }
            if ((expressionId == 163)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr163GetTree();
            }
            if ((expressionId == 164)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr164GetTree();
            }
            if ((expressionId == 165)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr165GetTree();
            }
            if ((expressionId == 166)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr166GetTree();
            }
            if ((expressionId == 167)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr167GetTree();
            }
            if ((expressionId == 168)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr168GetTree();
            }
            if ((expressionId == 169)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr169GetTree();
            }
            if ((expressionId == 170)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr170GetTree();
            }
            if ((expressionId == 171)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr171GetTree();
            }
            if ((expressionId == 172)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr172GetTree();
            }
            if ((expressionId == 173)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr173GetTree();
            }
            if ((expressionId == 174)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr174GetTree();
            }
            if ((expressionId == 175)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr175GetTree();
            }
            if ((expressionId == 176)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr176GetTree();
            }
            if ((expressionId == 177)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr177GetTree();
            }
            if ((expressionId == 178)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr178GetTree();
            }
            if ((expressionId == 179)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr179GetTree();
            }
            if ((expressionId == 180)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr180GetTree();
            }
            if ((expressionId == 181)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr181GetTree();
            }
            if ((expressionId == 182)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr182GetTree();
            }
            if ((expressionId == 183)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr183GetTree();
            }
            if ((expressionId == 184)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr184GetTree();
            }
            if ((expressionId == 185)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr185GetTree();
            }
            if ((expressionId == 186)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr186GetTree();
            }
            if ((expressionId == 187)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr187GetTree();
            }
            if ((expressionId == 188)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr188GetTree();
            }
            if ((expressionId == 189)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr189GetTree();
            }
            if ((expressionId == 190)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr190GetTree();
            }
            if ((expressionId == 191)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr191GetTree();
            }
            if ((expressionId == 192)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr192GetTree();
            }
            if ((expressionId == 193)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr193GetTree();
            }
            if ((expressionId == 194)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr194GetTree();
            }
            if ((expressionId == 195)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr195GetTree();
            }
            if ((expressionId == 196)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr196GetTree();
            }
            if ((expressionId == 197)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr197GetTree();
            }
            if ((expressionId == 198)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr198GetTree();
            }
            if ((expressionId == 199)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr199GetTree();
            }
            if ((expressionId == 200)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr200GetTree();
            }
            if ((expressionId == 201)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr201GetTree();
            }
            if ((expressionId == 202)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr202GetTree();
            }
            if ((expressionId == 203)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr203GetTree();
            }
            if ((expressionId == 204)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr204GetTree();
            }
            if ((expressionId == 205)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr205GetTree();
            }
            if ((expressionId == 206)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr206GetTree();
            }
            if ((expressionId == 207)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr207GetTree();
            }
            if ((expressionId == 208)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr208GetTree();
            }
            if ((expressionId == 209)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr209GetTree();
            }
            if ((expressionId == 210)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr210GetTree();
            }
            if ((expressionId == 211)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr211GetTree();
            }
            if ((expressionId == 212)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr212GetTree();
            }
            if ((expressionId == 213)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr213GetTree();
            }
            if ((expressionId == 214)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr214GetTree();
            }
            if ((expressionId == 215)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr215GetTree();
            }
            if ((expressionId == 216)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr216GetTree();
            }
            if ((expressionId == 217)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr217GetTree();
            }
            if ((expressionId == 218)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(locationReferences).@__Expr218GetTree();
            }
            if ((expressionId == 219)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext4(locationReferences).@__Expr219GetTree();
            }
            if ((expressionId == 220)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(locationReferences).@__Expr220GetTree();
            }
            if ((expressionId == 221)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(locationReferences).@__Expr221GetTree();
            }
            if ((expressionId == 222)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext3(locationReferences).@__Expr222GetTree();
            }
            if ((expressionId == 223)) {
                return new F1040EZTaxesAndPenalties_TypedDataContext3(locationReferences).@__Expr223GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZTaxesAndPenalties_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1040EZTaxesAndPenalties_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZTaxesAndPenalties_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1040EZTaxesAndPenalties_TypedDataContext1 : F1040EZTaxesAndPenalties_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZTaxesAndPenalties_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                return F1040EZTaxesAndPenalties_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext1_ForReadOnly : F1040EZTaxesAndPenalties_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZTaxesAndPenalties_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                return F1040EZTaxesAndPenalties_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext2 : F1040EZTaxesAndPenalties_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double taxdueamount;
            
            protected bool latefilingavailable;
            
            protected double interestAmount;
            
            protected System.DateTime dueDate;
            
            public F1040EZTaxesAndPenalties_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                this.taxdueamount = ((double)(this.GetVariableValue((1 + locationsOffset))));
                this.latefilingavailable = ((bool)(this.GetVariableValue((2 + locationsOffset))));
                this.interestAmount = ((double)(this.GetVariableValue((3 + locationsOffset))));
                this.dueDate = ((System.DateTime)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((1 + locationsOffset), this.taxdueamount);
                this.SetVariableValue((2 + locationsOffset), this.latefilingavailable);
                this.SetVariableValue((3 + locationsOffset), this.interestAmount);
                this.SetVariableValue((4 + locationsOffset), this.dueDate);
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
                if (((locationReferences[(offset + 1)].Name != "taxdueamount") 
                            || (locationReferences[(offset + 1)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "latefilingavailable") 
                            || (locationReferences[(offset + 2)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "interestAmount") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "dueDate") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                return F1040EZTaxesAndPenalties_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly : F1040EZTaxesAndPenalties_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double taxdueamount;
            
            protected bool latefilingavailable;
            
            protected double interestAmount;
            
            protected System.DateTime dueDate;
            
            public F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 63 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
          new DateTime(DateTime.Today.Year+1, 4, 15);;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr0Get() {
                
                #line 63 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
          new DateTime(DateTime.Today.Year+1, 4, 15);;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 70 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          ((Tax1040Object != null) && (Tax1040Object.OutputForms != null) && (Tax1040Object.OutputForms.Tax1040EZPage1 !=null) );
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr1Get() {
                
                #line 70 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
          ((Tax1040Object != null) && (Tax1040Object.OutputForms != null) && (Tax1040Object.OutputForms.Tax1040EZPage1 !=null) );
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            protected override void GetValueTypeValues() {
                this.taxdueamount = ((double)(this.GetVariableValue((1 + locationsOffset))));
                this.latefilingavailable = ((bool)(this.GetVariableValue((2 + locationsOffset))));
                this.interestAmount = ((double)(this.GetVariableValue((3 + locationsOffset))));
                this.dueDate = ((System.DateTime)(this.GetVariableValue((4 + locationsOffset))));
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
                if (((locationReferences[(offset + 1)].Name != "taxdueamount") 
                            || (locationReferences[(offset + 1)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "latefilingavailable") 
                            || (locationReferences[(offset + 2)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "interestAmount") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "dueDate") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                return F1040EZTaxesAndPenalties_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext3 : F1040EZTaxesAndPenalties_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double fivepercentpenality;
            
            protected double twentyfivepercentpenality;
            
            protected double LateFilingPenalty;
            
            protected double interest;
            
            protected double LatePayingPenalty;
            
            protected bool hasExtended;
            
            protected System.DateTime filingDate;
            
            public F1040EZTaxesAndPenalties_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 91 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                taxdueamount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr4Get() {
                
                #line 91 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                taxdueamount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(double value) {
                
                #line 91 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                taxdueamount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr222GetTree() {
                
                #line 1522 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr222Get() {
                
                #line 1522 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr222Get() {
                this.GetValueTypeValues();
                return this.@__Expr222Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr222Set(double value) {
                
                #line 1522 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr222Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr222Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr223GetTree() {
                
                #line 1538 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr223Get() {
                
                #line 1538 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                            Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr223Get() {
                this.GetValueTypeValues();
                return this.@__Expr223Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr223Set(double value) {
                
                #line 1538 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                            Tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr223Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr223Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.fivepercentpenality = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.twentyfivepercentpenality = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.LateFilingPenalty = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.interest = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.LatePayingPenalty = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.hasExtended = ((bool)(this.GetVariableValue((10 + locationsOffset))));
                this.filingDate = ((System.DateTime)(this.GetVariableValue((11 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.fivepercentpenality);
                this.SetVariableValue((6 + locationsOffset), this.twentyfivepercentpenality);
                this.SetVariableValue((7 + locationsOffset), this.LateFilingPenalty);
                this.SetVariableValue((8 + locationsOffset), this.interest);
                this.SetVariableValue((9 + locationsOffset), this.LatePayingPenalty);
                this.SetVariableValue((10 + locationsOffset), this.hasExtended);
                this.SetVariableValue((11 + locationsOffset), this.filingDate);
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
                if (((locationReferences[(offset + 5)].Name != "fivepercentpenality") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "twentyfivepercentpenality") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "LateFilingPenalty") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "interest") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "LatePayingPenalty") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "hasExtended") 
                            || (locationReferences[(offset + 10)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "filingDate") 
                            || (locationReferences[(offset + 11)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                return F1040EZTaxesAndPenalties_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly : F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double fivepercentpenality;
            
            protected double twentyfivepercentpenality;
            
            protected double LateFilingPenalty;
            
            protected double interest;
            
            protected double LatePayingPenalty;
            
            protected bool hasExtended;
            
            protected System.DateTime filingDate;
            
            public F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 84 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                Tax1040Object.TaxesAndPenalties.FilingDate.HasValue ? Tax1040Object.TaxesAndPenalties.FilingDate.Value : new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr2Get() {
                
                #line 84 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                Tax1040Object.TaxesAndPenalties.FilingDate.HasValue ? Tax1040Object.TaxesAndPenalties.FilingDate.Value : new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 96 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount - Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr3Get() {
                
                #line 96 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                Tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount - Tax1040Object.OutputForms.Tax1040EZPage1.TotalPaymentsAndCredits;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 104 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  (taxdueamount >= 0 && (filingDate > dueDate));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr5Get() {
                
                #line 104 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                  (taxdueamount >= 0 && (filingDate > dueDate));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr220GetTree() {
                
                #line 1514 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      taxdueamount < 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr220Get() {
                
                #line 1514 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                      taxdueamount < 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr220Get() {
                this.GetValueTypeValues();
                return this.@__Expr220Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr221GetTree() {
                
                #line 1527 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            Math.Round(Math.Abs(taxdueamount),2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr221Get() {
                
                #line 1527 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                            Math.Round(Math.Abs(taxdueamount),2);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr221Get() {
                this.GetValueTypeValues();
                return this.@__Expr221Get();
            }
            
            protected override void GetValueTypeValues() {
                this.fivepercentpenality = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.twentyfivepercentpenality = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.LateFilingPenalty = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.interest = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.LatePayingPenalty = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.hasExtended = ((bool)(this.GetVariableValue((10 + locationsOffset))));
                this.filingDate = ((System.DateTime)(this.GetVariableValue((11 + locationsOffset))));
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
                if (((locationReferences[(offset + 5)].Name != "fivepercentpenality") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "twentyfivepercentpenality") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "LateFilingPenalty") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "interest") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "LatePayingPenalty") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "hasExtended") 
                            || (locationReferences[(offset + 10)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "filingDate") 
                            || (locationReferences[(offset + 11)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                return F1040EZTaxesAndPenalties_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext4 : F1040EZTaxesAndPenalties_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int staticmonth;
            
            protected double datedifference;
            
            protected double monthdifference;
            
            protected System.TimeSpan datedifferentmonth;
            
            protected int month;
            
            protected bool latefilingorpayingPenality;
            
            protected double InterestonUnpaidtaxdue;
            
            protected double LatePaymentPenaltybeforeduedate;
            
            protected double LatePaymentPenaltyafterduedate;
            
            protected double LateFilingPenaltyforInterest;
            
            protected double InterestonLateFilingPenalty;
            
            protected double totalinterest;
            
            public F1040EZTaxesAndPenalties_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue>>> expression = () => 
                        Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue> @__Expr11Get() {
                
                #line 142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                        Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue> ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(System.Collections.Generic.List<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue> value) {
                
                #line 142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                        Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(System.Collections.Generic.List<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue> value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 162 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              hasExtended;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr13Get() {
                
                #line 162 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              hasExtended;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(bool value) {
                
                #line 162 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              hasExtended = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr132GetTree() {
                
                #line 915 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<double>>> expression = () => 
                            Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<double> @__Expr132Get() {
                
                #line 915 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                            Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<double> ValueType___Expr132Get() {
                this.GetValueTypeValues();
                return this.@__Expr132Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr132Set(System.Nullable<double> value) {
                
                #line 915 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                            Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr132Set(System.Nullable<double> value) {
                this.GetValueTypeValues();
                this.@__Expr132Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr135GetTree() {
                
                #line 937 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                              dueDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr135Get() {
                
                #line 937 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              dueDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr135Get() {
                this.GetValueTypeValues();
                return this.@__Expr135Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr135Set(System.DateTime value) {
                
                #line 937 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              dueDate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr135Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr135Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr137GetTree() {
                
                #line 949 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              datedifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr137Get() {
                
                #line 949 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              datedifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr137Get() {
                this.GetValueTypeValues();
                return this.@__Expr137Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr137Set(double value) {
                
                #line 949 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              datedifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr137Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr137Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr139GetTree() {
                
                #line 961 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              monthdifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr139Get() {
                
                #line 961 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              monthdifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr139Get() {
                this.GetValueTypeValues();
                return this.@__Expr139Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr139Set(double value) {
                
                #line 961 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              monthdifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr139Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr139Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr142GetTree() {
                
                #line 981 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                    dueDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr142Get() {
                
                #line 981 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    dueDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr142Get() {
                this.GetValueTypeValues();
                return this.@__Expr142Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr142Set(System.DateTime value) {
                
                #line 981 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    dueDate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr142Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr142Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr144GetTree() {
                
                #line 993 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    datedifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr144Get() {
                
                #line 993 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    datedifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr144Get() {
                this.GetValueTypeValues();
                return this.@__Expr144Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr144Set(double value) {
                
                #line 993 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    datedifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr144Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr144Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr146GetTree() {
                
                #line 1005 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    monthdifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr146Get() {
                
                #line 1005 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    monthdifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr146Get() {
                this.GetValueTypeValues();
                return this.@__Expr146Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr146Set(double value) {
                
                #line 1005 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    monthdifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr146Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr146Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr148GetTree() {
                
                #line 1017 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    LatePaymentPenaltybeforeduedate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr148Get() {
                
                #line 1017 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    LatePaymentPenaltybeforeduedate;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr148Get() {
                this.GetValueTypeValues();
                return this.@__Expr148Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr148Set(double value) {
                
                #line 1017 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    LatePaymentPenaltybeforeduedate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr148Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr148Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr149GetTree() {
                
                #line 1029 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    monthdifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr149Get() {
                
                #line 1029 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    monthdifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr149Get() {
                this.GetValueTypeValues();
                return this.@__Expr149Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr149Set(double value) {
                
                #line 1029 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    monthdifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr149Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr149Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr151GetTree() {
                
                #line 1039 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    LateFilingPenaltyforInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr151Get() {
                
                #line 1039 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    LateFilingPenaltyforInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr151Get() {
                this.GetValueTypeValues();
                return this.@__Expr151Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr151Set(double value) {
                
                #line 1039 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    LateFilingPenaltyforInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr151Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr151Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr153GetTree() {
                
                #line 1055 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    fivepercentpenality;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr153Get() {
                
                #line 1055 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    fivepercentpenality;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr153Get() {
                this.GetValueTypeValues();
                return this.@__Expr153Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr153Set(double value) {
                
                #line 1055 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    fivepercentpenality = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr153Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr153Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr155GetTree() {
                
                #line 1067 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    twentyfivepercentpenality;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr155Get() {
                
                #line 1067 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    twentyfivepercentpenality;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr155Get() {
                this.GetValueTypeValues();
                return this.@__Expr155Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr155Set(double value) {
                
                #line 1067 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    twentyfivepercentpenality = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr155Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr155Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr157GetTree() {
                
                #line 1079 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    LateFilingPenalty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr157Get() {
                
                #line 1079 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    LateFilingPenalty;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr157Get() {
                this.GetValueTypeValues();
                return this.@__Expr157Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr157Set(double value) {
                
                #line 1079 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    LateFilingPenalty = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr157Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr157Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr159GetTree() {
                
                #line 1091 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    LatePaymentPenaltybeforeduedate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr159Get() {
                
                #line 1091 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    LatePaymentPenaltybeforeduedate;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr159Get() {
                this.GetValueTypeValues();
                return this.@__Expr159Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr159Set(double value) {
                
                #line 1091 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    LatePaymentPenaltybeforeduedate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr159Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr159Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr161GetTree() {
                
                #line 1103 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    LatePaymentPenaltyafterduedate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr161Get() {
                
                #line 1103 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    LatePaymentPenaltyafterduedate;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr161Get() {
                this.GetValueTypeValues();
                return this.@__Expr161Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr161Set(double value) {
                
                #line 1103 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    LatePaymentPenaltyafterduedate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr161Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr161Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr163GetTree() {
                
                #line 1115 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    LateFilingPenaltyforInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr163Get() {
                
                #line 1115 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    LateFilingPenaltyforInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr163Get() {
                this.GetValueTypeValues();
                return this.@__Expr163Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr163Set(double value) {
                
                #line 1115 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    LateFilingPenaltyforInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr163Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr163Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr165GetTree() {
                
                #line 1130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              InterestonLateFilingPenalty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr165Get() {
                
                #line 1130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              InterestonLateFilingPenalty;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr165Get() {
                this.GetValueTypeValues();
                return this.@__Expr165Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr165Set(double value) {
                
                #line 1130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              InterestonLateFilingPenalty = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr165Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr165Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr167GetTree() {
                
                #line 1142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              totalinterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr167Get() {
                
                #line 1142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              totalinterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr167Get() {
                this.GetValueTypeValues();
                return this.@__Expr167Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr167Set(double value) {
                
                #line 1142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              totalinterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr167Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr167Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr170GetTree() {
                
                #line 1162 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    Tax1040Object.OutputForms.Interest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr170Get() {
                
                #line 1162 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    Tax1040Object.OutputForms.Interest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr170Get() {
                this.GetValueTypeValues();
                return this.@__Expr170Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr170Set(string value) {
                
                #line 1162 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    Tax1040Object.OutputForms.Interest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr170Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr170Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr172GetTree() {
                
                #line 1176 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    Tax1040Object.OutputForms.Interest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr172Get() {
                
                #line 1176 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    Tax1040Object.OutputForms.Interest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr172Get() {
                this.GetValueTypeValues();
                return this.@__Expr172Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr172Set(string value) {
                
                #line 1176 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    Tax1040Object.OutputForms.Interest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr172Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr172Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr175GetTree() {
                
                #line 1199 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    Tax1040Object.OutputForms.LateFilingPenalty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr175Get() {
                
                #line 1199 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    Tax1040Object.OutputForms.LateFilingPenalty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr175Get() {
                this.GetValueTypeValues();
                return this.@__Expr175Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr175Set(string value) {
                
                #line 1199 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    Tax1040Object.OutputForms.LateFilingPenalty = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr175Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr175Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr177GetTree() {
                
                #line 1213 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    Tax1040Object.OutputForms.LateFilingPenalty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr177Get() {
                
                #line 1213 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    Tax1040Object.OutputForms.LateFilingPenalty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr177Get() {
                this.GetValueTypeValues();
                return this.@__Expr177Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr177Set(string value) {
                
                #line 1213 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    Tax1040Object.OutputForms.LateFilingPenalty = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr177Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr177Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr180GetTree() {
                
                #line 1235 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Tax1040Object.OutputForms.LatePaymentPenalty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr180Get() {
                
                #line 1235 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                  Tax1040Object.OutputForms.LatePaymentPenalty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr180Get() {
                this.GetValueTypeValues();
                return this.@__Expr180Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr180Set(string value) {
                
                #line 1235 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                  Tax1040Object.OutputForms.LatePaymentPenalty = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr180Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr180Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr182GetTree() {
                
                #line 1249 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Tax1040Object.OutputForms.LatePaymentPenalty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr182Get() {
                
                #line 1249 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                  Tax1040Object.OutputForms.LatePaymentPenalty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr182Get() {
                this.GetValueTypeValues();
                return this.@__Expr182Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr182Set(string value) {
                
                #line 1249 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                  Tax1040Object.OutputForms.LatePaymentPenalty = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr182Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr182Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr184GetTree() {
                
                #line 1263 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<double>>> expression = () => 
                              Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<double> @__Expr184Get() {
                
                #line 1263 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<double> ValueType___Expr184Get() {
                this.GetValueTypeValues();
                return this.@__Expr184Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr184Set(System.Nullable<double> value) {
                
                #line 1263 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr184Set(System.Nullable<double> value) {
                this.GetValueTypeValues();
                this.@__Expr184Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr186GetTree() {
                
                #line 1279 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              datedifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr186Get() {
                
                #line 1279 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              datedifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr186Get() {
                this.GetValueTypeValues();
                return this.@__Expr186Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr186Set(double value) {
                
                #line 1279 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              datedifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr186Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr186Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr188GetTree() {
                
                #line 1291 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              monthdifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr188Get() {
                
                #line 1291 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              monthdifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr188Get() {
                this.GetValueTypeValues();
                return this.@__Expr188Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr188Set(double value) {
                
                #line 1291 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              monthdifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr188Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr188Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr190GetTree() {
                
                #line 1303 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              fivepercentpenality;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr190Get() {
                
                #line 1303 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              fivepercentpenality;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr190Get() {
                this.GetValueTypeValues();
                return this.@__Expr190Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr190Set(double value) {
                
                #line 1303 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              fivepercentpenality = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr190Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr190Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr192GetTree() {
                
                #line 1315 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              twentyfivepercentpenality;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr192Get() {
                
                #line 1315 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              twentyfivepercentpenality;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr192Get() {
                this.GetValueTypeValues();
                return this.@__Expr192Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr192Set(double value) {
                
                #line 1315 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              twentyfivepercentpenality = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr192Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr192Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr194GetTree() {
                
                #line 1327 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              LateFilingPenalty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr194Get() {
                
                #line 1327 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              LateFilingPenalty;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr194Get() {
                this.GetValueTypeValues();
                return this.@__Expr194Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr194Set(double value) {
                
                #line 1327 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              LateFilingPenalty = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr194Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr194Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr196GetTree() {
                
                #line 1339 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              LatePaymentPenaltyafterduedate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr196Get() {
                
                #line 1339 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              LatePaymentPenaltyafterduedate;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr196Get() {
                this.GetValueTypeValues();
                return this.@__Expr196Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr196Set(double value) {
                
                #line 1339 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              LatePaymentPenaltyafterduedate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr196Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr196Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr198GetTree() {
                
                #line 1351 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              LateFilingPenaltyforInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr198Get() {
                
                #line 1351 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              LateFilingPenaltyforInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr198Get() {
                this.GetValueTypeValues();
                return this.@__Expr198Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr198Set(double value) {
                
                #line 1351 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              LateFilingPenaltyforInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr198Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr198Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr200GetTree() {
                
                #line 1363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              InterestonLateFilingPenalty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr200Get() {
                
                #line 1363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              InterestonLateFilingPenalty;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr200Get() {
                this.GetValueTypeValues();
                return this.@__Expr200Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr200Set(double value) {
                
                #line 1363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              InterestonLateFilingPenalty = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr200Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr200Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr202GetTree() {
                
                #line 1375 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              totalinterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr202Get() {
                
                #line 1375 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              totalinterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr202Get() {
                this.GetValueTypeValues();
                return this.@__Expr202Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr202Set(double value) {
                
                #line 1375 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              totalinterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr202Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr202Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr205GetTree() {
                
                #line 1395 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    Tax1040Object.OutputForms.Interest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr205Get() {
                
                #line 1395 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    Tax1040Object.OutputForms.Interest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr205Get() {
                this.GetValueTypeValues();
                return this.@__Expr205Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr205Set(string value) {
                
                #line 1395 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    Tax1040Object.OutputForms.Interest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr205Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr205Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr207GetTree() {
                
                #line 1409 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    Tax1040Object.OutputForms.Interest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr207Get() {
                
                #line 1409 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    Tax1040Object.OutputForms.Interest;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr207Get() {
                this.GetValueTypeValues();
                return this.@__Expr207Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr207Set(string value) {
                
                #line 1409 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    Tax1040Object.OutputForms.Interest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr207Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr207Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr210GetTree() {
                
                #line 1432 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    Tax1040Object.OutputForms.LateFilingPenalty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr210Get() {
                
                #line 1432 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    Tax1040Object.OutputForms.LateFilingPenalty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr210Get() {
                this.GetValueTypeValues();
                return this.@__Expr210Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr210Set(string value) {
                
                #line 1432 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    Tax1040Object.OutputForms.LateFilingPenalty = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr210Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr210Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr212GetTree() {
                
                #line 1446 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    Tax1040Object.OutputForms.LateFilingPenalty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr212Get() {
                
                #line 1446 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    Tax1040Object.OutputForms.LateFilingPenalty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr212Get() {
                this.GetValueTypeValues();
                return this.@__Expr212Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr212Set(string value) {
                
                #line 1446 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    Tax1040Object.OutputForms.LateFilingPenalty = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr212Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr212Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr215GetTree() {
                
                #line 1468 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Tax1040Object.OutputForms.LatePaymentPenalty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr215Get() {
                
                #line 1468 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                  Tax1040Object.OutputForms.LatePaymentPenalty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr215Get() {
                this.GetValueTypeValues();
                return this.@__Expr215Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr215Set(string value) {
                
                #line 1468 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                  Tax1040Object.OutputForms.LatePaymentPenalty = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr215Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr215Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr217GetTree() {
                
                #line 1482 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Tax1040Object.OutputForms.LatePaymentPenalty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr217Get() {
                
                #line 1482 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                  Tax1040Object.OutputForms.LatePaymentPenalty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr217Get() {
                this.GetValueTypeValues();
                return this.@__Expr217Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr217Set(string value) {
                
                #line 1482 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                  Tax1040Object.OutputForms.LatePaymentPenalty = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr217Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr217Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr219GetTree() {
                
                #line 1496 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<double>>> expression = () => 
                              Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<double> @__Expr219Get() {
                
                #line 1496 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<double> ValueType___Expr219Get() {
                this.GetValueTypeValues();
                return this.@__Expr219Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr219Set(System.Nullable<double> value) {
                
                #line 1496 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              Tax1040Object.TaxesAndPenalties.PenaltiesAndInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr219Set(System.Nullable<double> value) {
                this.GetValueTypeValues();
                this.@__Expr219Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.staticmonth = ((int)(this.GetVariableValue((12 + locationsOffset))));
                this.datedifference = ((double)(this.GetVariableValue((13 + locationsOffset))));
                this.monthdifference = ((double)(this.GetVariableValue((14 + locationsOffset))));
                this.datedifferentmonth = ((System.TimeSpan)(this.GetVariableValue((15 + locationsOffset))));
                this.month = ((int)(this.GetVariableValue((16 + locationsOffset))));
                this.latefilingorpayingPenality = ((bool)(this.GetVariableValue((17 + locationsOffset))));
                this.InterestonUnpaidtaxdue = ((double)(this.GetVariableValue((18 + locationsOffset))));
                this.LatePaymentPenaltybeforeduedate = ((double)(this.GetVariableValue((19 + locationsOffset))));
                this.LatePaymentPenaltyafterduedate = ((double)(this.GetVariableValue((20 + locationsOffset))));
                this.LateFilingPenaltyforInterest = ((double)(this.GetVariableValue((21 + locationsOffset))));
                this.InterestonLateFilingPenalty = ((double)(this.GetVariableValue((22 + locationsOffset))));
                this.totalinterest = ((double)(this.GetVariableValue((23 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((12 + locationsOffset), this.staticmonth);
                this.SetVariableValue((13 + locationsOffset), this.datedifference);
                this.SetVariableValue((14 + locationsOffset), this.monthdifference);
                this.SetVariableValue((15 + locationsOffset), this.datedifferentmonth);
                this.SetVariableValue((16 + locationsOffset), this.month);
                this.SetVariableValue((17 + locationsOffset), this.latefilingorpayingPenality);
                this.SetVariableValue((18 + locationsOffset), this.InterestonUnpaidtaxdue);
                this.SetVariableValue((19 + locationsOffset), this.LatePaymentPenaltybeforeduedate);
                this.SetVariableValue((20 + locationsOffset), this.LatePaymentPenaltyafterduedate);
                this.SetVariableValue((21 + locationsOffset), this.LateFilingPenaltyforInterest);
                this.SetVariableValue((22 + locationsOffset), this.InterestonLateFilingPenalty);
                this.SetVariableValue((23 + locationsOffset), this.totalinterest);
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
                if (((locationReferences[(offset + 12)].Name != "staticmonth") 
                            || (locationReferences[(offset + 12)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "datedifference") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "monthdifference") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "datedifferentmonth") 
                            || (locationReferences[(offset + 15)].Type != typeof(System.TimeSpan)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "month") 
                            || (locationReferences[(offset + 16)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "latefilingorpayingPenality") 
                            || (locationReferences[(offset + 17)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 18)].Name != "InterestonUnpaidtaxdue") 
                            || (locationReferences[(offset + 18)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "LatePaymentPenaltybeforeduedate") 
                            || (locationReferences[(offset + 19)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "LatePaymentPenaltyafterduedate") 
                            || (locationReferences[(offset + 20)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "LateFilingPenaltyforInterest") 
                            || (locationReferences[(offset + 21)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "InterestonLateFilingPenalty") 
                            || (locationReferences[(offset + 22)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "totalinterest") 
                            || (locationReferences[(offset + 23)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZTaxesAndPenalties_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly : F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int staticmonth;
            
            protected double datedifference;
            
            protected double monthdifference;
            
            protected System.TimeSpan datedifferentmonth;
            
            protected int month;
            
            protected bool latefilingorpayingPenality;
            
            protected double InterestonUnpaidtaxdue;
            
            protected double LatePaymentPenaltybeforeduedate;
            
            protected double LatePaymentPenaltyafterduedate;
            
            protected double LateFilingPenaltyforInterest;
            
            protected double InterestonLateFilingPenalty;
            
            protected double totalinterest;
            
            public F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 113 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        (filingDate - dueDate).Days;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr6Get() {
                
                #line 113 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                        (filingDate - dueDate).Days;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 118 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Math.Round(datedifference / 30);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr7Get() {
                
                #line 118 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                        Math.Round(datedifference / 30);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 123 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                        filingDate - dueDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr8Get() {
                
                #line 123 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                        filingDate - dueDate;
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Math.Round(taxdueamount * ((double)interestAmount / 100) * ((double)datedifference / 365), 2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr9Get() {
                
                #line 130 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                        Math.Round(taxdueamount * ((double)interestAmount / 100) * ((double)datedifference / 365), 2);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 147 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue>>> expression = () => 
                        new List<InterestOnUnpaidDue>();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue> @__Expr10Get() {
                
                #line 147 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                        new List<InterestOnUnpaidDue>();
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue> ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 154 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.TaxesAndPenalties !=null && Tax1040Object.TaxesAndPenalties.HasFiledForm4868.HasValue ? Tax1040Object.TaxesAndPenalties.HasFiledForm4868.Value : false;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr12Get() {
                
                #line 154 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                        Tax1040Object.TaxesAndPenalties !=null && Tax1040Object.TaxesAndPenalties.HasFiledForm4868.HasValue ? Tax1040Object.TaxesAndPenalties.HasFiledForm4868.Value : false;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 175 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        datedifferentmonth.Days > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr14Get() {
                
                #line 175 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                        datedifferentmonth.Days > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr131GetTree() {
                
                #line 920 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<double>>> expression = () => 
                            0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<double> @__Expr131Get() {
                
                #line 920 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                            0;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<double> ValueType___Expr131Get() {
                this.GetValueTypeValues();
                return this.@__Expr131Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr133GetTree() {
                
                #line 929 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        hasExtended;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr133Get() {
                
                #line 929 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                        hasExtended;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr133Get() {
                this.GetValueTypeValues();
                return this.@__Expr133Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr134GetTree() {
                
                #line 942 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                              dueDate.AddMonths(6);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr134Get() {
                
                #line 942 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              dueDate.AddMonths(6);
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr134Get() {
                this.GetValueTypeValues();
                return this.@__Expr134Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr136GetTree() {
                
                #line 954 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              (filingDate - dueDate).Days;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr136Get() {
                
                #line 954 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              (filingDate - dueDate).Days;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr136Get() {
                this.GetValueTypeValues();
                return this.@__Expr136Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr138GetTree() {
                
                #line 966 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Math.Round(datedifference / 30);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr138Get() {
                
                #line 966 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              Math.Round(datedifference / 30);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr138Get() {
                this.GetValueTypeValues();
                return this.@__Expr138Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr140GetTree() {
                
                #line 973 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              (filingDate - dueDate).Days < 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr140Get() {
                
                #line 973 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              (filingDate - dueDate).Days < 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr140Get() {
                this.GetValueTypeValues();
                return this.@__Expr140Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr141GetTree() {
                
                #line 986 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                    dueDate.AddMonths(-6);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr141Get() {
                
                #line 986 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    dueDate.AddMonths(-6);
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr141Get() {
                this.GetValueTypeValues();
                return this.@__Expr141Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr143GetTree() {
                
                #line 998 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    (filingDate - dueDate).Days;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr143Get() {
                
                #line 998 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    (filingDate - dueDate).Days;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr143Get() {
                this.GetValueTypeValues();
                return this.@__Expr143Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr145GetTree() {
                
                #line 1010 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Math.Round(datedifference / 30, 2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr145Get() {
                
                #line 1010 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    Math.Round(datedifference / 30, 2);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr145Get() {
                this.GetValueTypeValues();
                return this.@__Expr145Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr147GetTree() {
                
                #line 1022 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Math.Min((((double)0.5 / 100) * monthdifference * taxdueamount), (((double)25 / 100) * taxdueamount));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr147Get() {
                
                #line 1022 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    Math.Min((((double)0.5 / 100) * monthdifference * taxdueamount), (((double)25 / 100) * taxdueamount));
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr147Get() {
                this.GetValueTypeValues();
                return this.@__Expr147Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr150GetTree() {
                
                #line 1044 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    LateFilingPenalty + LatePaymentPenaltybeforeduedate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr150Get() {
                
                #line 1044 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    LateFilingPenalty + LatePaymentPenaltybeforeduedate;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr150Get() {
                this.GetValueTypeValues();
                return this.@__Expr150Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr152GetTree() {
                
                #line 1060 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    ((double)5 / 100) * taxdueamount * monthdifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr152Get() {
                
                #line 1060 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    ((double)5 / 100) * taxdueamount * monthdifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr152Get() {
                this.GetValueTypeValues();
                return this.@__Expr152Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr154GetTree() {
                
                #line 1072 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    ((double)25 / 100) * taxdueamount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr154Get() {
                
                #line 1072 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    ((double)25 / 100) * taxdueamount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr154Get() {
                this.GetValueTypeValues();
                return this.@__Expr154Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr156GetTree() {
                
                #line 1084 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Math.Min(fivepercentpenality, twentyfivepercentpenality);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr156Get() {
                
                #line 1084 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    Math.Min(fivepercentpenality, twentyfivepercentpenality);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr156Get() {
                this.GetValueTypeValues();
                return this.@__Expr156Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr158GetTree() {
                
                #line 1096 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Math.Min((((double)0.5 / 100) * 6 * taxdueamount), (((double)25 / 100) * taxdueamount));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr158Get() {
                
                #line 1096 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    Math.Min((((double)0.5 / 100) * 6 * taxdueamount), (((double)25 / 100) * taxdueamount));
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr158Get() {
                this.GetValueTypeValues();
                return this.@__Expr158Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr160GetTree() {
                
                #line 1108 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Math.Min((((double)0.5 / 100) * monthdifference * taxdueamount), (((double)25 / 100) * taxdueamount));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr160Get() {
                
                #line 1108 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    Math.Min((((double)0.5 / 100) * monthdifference * taxdueamount), (((double)25 / 100) * taxdueamount));
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr160Get() {
                this.GetValueTypeValues();
                return this.@__Expr160Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr162GetTree() {
                
                #line 1120 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    LateFilingPenalty - LatePaymentPenaltyafterduedate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr162Get() {
                
                #line 1120 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    LateFilingPenalty - LatePaymentPenaltyafterduedate;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr162Get() {
                this.GetValueTypeValues();
                return this.@__Expr162Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr164GetTree() {
                
                #line 1135 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              LateFilingPenaltyforInterest * ((double)3 / 100) * ((double)datedifference / 365);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr164Get() {
                
                #line 1135 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              LateFilingPenaltyforInterest * ((double)3 / 100) * ((double)datedifference / 365);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr164Get() {
                this.GetValueTypeValues();
                return this.@__Expr164Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr166GetTree() {
                
                #line 1147 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue.Select(a => a.InterestAmount).Sum() + InterestonLateFilingPenalty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr166Get() {
                
                #line 1147 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue.Select(a => a.InterestAmount).Sum() + InterestonLateFilingPenalty;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr166Get() {
                this.GetValueTypeValues();
                return this.@__Expr166Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr168GetTree() {
                
                #line 1155 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                Math.Round(totalinterest, MidpointRounding.AwayFromZero)>0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr168Get() {
                
                #line 1155 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                Math.Round(totalinterest, MidpointRounding.AwayFromZero)>0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr168Get() {
                this.GetValueTypeValues();
                return this.@__Expr168Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr169GetTree() {
                
                #line 1167 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    "INT $" + Math.Round(totalinterest, MidpointRounding.AwayFromZero).ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr169Get() {
                
                #line 1167 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    "INT $" + Math.Round(totalinterest, MidpointRounding.AwayFromZero).ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr169Get() {
                this.GetValueTypeValues();
                return this.@__Expr169Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr171GetTree() {
                
                #line 1181 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    string.Empty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr171Get() {
                
                #line 1181 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    string.Empty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr171Get() {
                this.GetValueTypeValues();
                return this.@__Expr171Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr173GetTree() {
                
                #line 1192 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                Math.Round(LateFilingPenalty, MidpointRounding.AwayFromZero)> 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr173Get() {
                
                #line 1192 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                Math.Round(LateFilingPenalty, MidpointRounding.AwayFromZero)> 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr173Get() {
                this.GetValueTypeValues();
                return this.@__Expr173Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr174GetTree() {
                
                #line 1204 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    "FTF $" +Math.Round(LateFilingPenalty, MidpointRounding.AwayFromZero).ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr174Get() {
                
                #line 1204 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    "FTF $" +Math.Round(LateFilingPenalty, MidpointRounding.AwayFromZero).ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr174Get() {
                this.GetValueTypeValues();
                return this.@__Expr174Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr176GetTree() {
                
                #line 1218 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    string.Empty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr176Get() {
                
                #line 1218 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    string.Empty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr176Get() {
                this.GetValueTypeValues();
                return this.@__Expr176Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr178GetTree() {
                
                #line 1228 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Math.Round(LatePaymentPenaltyafterduedate, MidpointRounding.AwayFromZero) > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr178Get() {
                
                #line 1228 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              Math.Round(LatePaymentPenaltyafterduedate, MidpointRounding.AwayFromZero) > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr178Get() {
                this.GetValueTypeValues();
                return this.@__Expr178Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr179GetTree() {
                
                #line 1240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  "FTP $" + Math.Round(LatePaymentPenaltyafterduedate, MidpointRounding.AwayFromZero).ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr179Get() {
                
                #line 1240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                  "FTP $" + Math.Round(LatePaymentPenaltyafterduedate, MidpointRounding.AwayFromZero).ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr179Get() {
                this.GetValueTypeValues();
                return this.@__Expr179Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr181GetTree() {
                
                #line 1254 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  string.Empty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr181Get() {
                
                #line 1254 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                  string.Empty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr181Get() {
                this.GetValueTypeValues();
                return this.@__Expr181Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr183GetTree() {
                
                #line 1268 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Math.Round((LateFilingPenalty + Math.Max(LatePaymentPenaltybeforeduedate, LatePaymentPenaltyafterduedate)) + totalinterest);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr183Get() {
                
                #line 1268 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              Math.Round((LateFilingPenalty + Math.Max(LatePaymentPenaltybeforeduedate, LatePaymentPenaltyafterduedate)) + totalinterest);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr183Get() {
                this.GetValueTypeValues();
                return this.@__Expr183Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr185GetTree() {
                
                #line 1284 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              (filingDate - dueDate).Days;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr185Get() {
                
                #line 1284 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              (filingDate - dueDate).Days;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr185Get() {
                this.GetValueTypeValues();
                return this.@__Expr185Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr187GetTree() {
                
                #line 1296 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Math.Round(datedifference / 30);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr187Get() {
                
                #line 1296 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              Math.Round(datedifference / 30);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr187Get() {
                this.GetValueTypeValues();
                return this.@__Expr187Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr189GetTree() {
                
                #line 1308 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              ((double)5 / 100) * taxdueamount * monthdifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr189Get() {
                
                #line 1308 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              ((double)5 / 100) * taxdueamount * monthdifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr189Get() {
                this.GetValueTypeValues();
                return this.@__Expr189Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr191GetTree() {
                
                #line 1320 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              ((double)25 / 100) * taxdueamount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr191Get() {
                
                #line 1320 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              ((double)25 / 100) * taxdueamount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr191Get() {
                this.GetValueTypeValues();
                return this.@__Expr191Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr193GetTree() {
                
                #line 1332 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Math.Min(fivepercentpenality, twentyfivepercentpenality);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr193Get() {
                
                #line 1332 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              Math.Min(fivepercentpenality, twentyfivepercentpenality);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr193Get() {
                this.GetValueTypeValues();
                return this.@__Expr193Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr195GetTree() {
                
                #line 1344 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Math.Min((((double)0.5 / 100) * monthdifference * taxdueamount), (((double)25 / 100) * taxdueamount));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr195Get() {
                
                #line 1344 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              Math.Min((((double)0.5 / 100) * monthdifference * taxdueamount), (((double)25 / 100) * taxdueamount));
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr195Get() {
                this.GetValueTypeValues();
                return this.@__Expr195Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr197GetTree() {
                
                #line 1356 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              LateFilingPenalty - LatePaymentPenaltyafterduedate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr197Get() {
                
                #line 1356 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              LateFilingPenalty - LatePaymentPenaltyafterduedate;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr197Get() {
                this.GetValueTypeValues();
                return this.@__Expr197Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr199GetTree() {
                
                #line 1368 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              LateFilingPenaltyforInterest * ((double)3 / 100) * ((double)datedifference / 365);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr199Get() {
                
                #line 1368 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              LateFilingPenaltyforInterest * ((double)3 / 100) * ((double)datedifference / 365);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr199Get() {
                this.GetValueTypeValues();
                return this.@__Expr199Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr201GetTree() {
                
                #line 1380 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue.Select(a => a.InterestAmount).Sum() + InterestonLateFilingPenalty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr201Get() {
                
                #line 1380 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue.Select(a => a.InterestAmount).Sum() + InterestonLateFilingPenalty;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr201Get() {
                this.GetValueTypeValues();
                return this.@__Expr201Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr203GetTree() {
                
                #line 1388 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                Math.Round(totalinterest, MidpointRounding.AwayFromZero)>0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr203Get() {
                
                #line 1388 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                Math.Round(totalinterest, MidpointRounding.AwayFromZero)>0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr203Get() {
                this.GetValueTypeValues();
                return this.@__Expr203Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr204GetTree() {
                
                #line 1400 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    "INT $" + Math.Round(totalinterest, MidpointRounding.AwayFromZero).ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr204Get() {
                
                #line 1400 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    "INT $" + Math.Round(totalinterest, MidpointRounding.AwayFromZero).ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr204Get() {
                this.GetValueTypeValues();
                return this.@__Expr204Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr206GetTree() {
                
                #line 1414 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    string.Empty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr206Get() {
                
                #line 1414 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    string.Empty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr206Get() {
                this.GetValueTypeValues();
                return this.@__Expr206Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr208GetTree() {
                
                #line 1425 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                Math.Round(LateFilingPenalty, MidpointRounding.AwayFromZero)> 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr208Get() {
                
                #line 1425 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                Math.Round(LateFilingPenalty, MidpointRounding.AwayFromZero)> 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr208Get() {
                this.GetValueTypeValues();
                return this.@__Expr208Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr209GetTree() {
                
                #line 1437 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    "FTF $"+Math.Round(LateFilingPenalty, MidpointRounding.AwayFromZero).ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr209Get() {
                
                #line 1437 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    "FTF $"+Math.Round(LateFilingPenalty, MidpointRounding.AwayFromZero).ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr209Get() {
                this.GetValueTypeValues();
                return this.@__Expr209Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr211GetTree() {
                
                #line 1451 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    string.Empty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr211Get() {
                
                #line 1451 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    string.Empty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr211Get() {
                this.GetValueTypeValues();
                return this.@__Expr211Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr213GetTree() {
                
                #line 1461 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Math.Round(LatePaymentPenaltyafterduedate, MidpointRounding.AwayFromZero) > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr213Get() {
                
                #line 1461 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              Math.Round(LatePaymentPenaltyafterduedate, MidpointRounding.AwayFromZero) > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr213Get() {
                this.GetValueTypeValues();
                return this.@__Expr213Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr214GetTree() {
                
                #line 1473 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  "FTP $" + Math.Round(LatePaymentPenaltyafterduedate, MidpointRounding.AwayFromZero).ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr214Get() {
                
                #line 1473 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                  "FTP $" + Math.Round(LatePaymentPenaltyafterduedate, MidpointRounding.AwayFromZero).ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr214Get() {
                this.GetValueTypeValues();
                return this.@__Expr214Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr216GetTree() {
                
                #line 1487 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  string.Empty;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr216Get() {
                
                #line 1487 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                  string.Empty;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr216Get() {
                this.GetValueTypeValues();
                return this.@__Expr216Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr218GetTree() {
                
                #line 1501 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Math.Round(Math.Max(LateFilingPenalty, Math.Max(LatePaymentPenaltybeforeduedate, LatePaymentPenaltyafterduedate)) + totalinterest);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr218Get() {
                
                #line 1501 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              Math.Round(Math.Max(LateFilingPenalty, Math.Max(LatePaymentPenaltybeforeduedate, LatePaymentPenaltyafterduedate)) + totalinterest);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr218Get() {
                this.GetValueTypeValues();
                return this.@__Expr218Get();
            }
            
            protected override void GetValueTypeValues() {
                this.staticmonth = ((int)(this.GetVariableValue((12 + locationsOffset))));
                this.datedifference = ((double)(this.GetVariableValue((13 + locationsOffset))));
                this.monthdifference = ((double)(this.GetVariableValue((14 + locationsOffset))));
                this.datedifferentmonth = ((System.TimeSpan)(this.GetVariableValue((15 + locationsOffset))));
                this.month = ((int)(this.GetVariableValue((16 + locationsOffset))));
                this.latefilingorpayingPenality = ((bool)(this.GetVariableValue((17 + locationsOffset))));
                this.InterestonUnpaidtaxdue = ((double)(this.GetVariableValue((18 + locationsOffset))));
                this.LatePaymentPenaltybeforeduedate = ((double)(this.GetVariableValue((19 + locationsOffset))));
                this.LatePaymentPenaltyafterduedate = ((double)(this.GetVariableValue((20 + locationsOffset))));
                this.LateFilingPenaltyforInterest = ((double)(this.GetVariableValue((21 + locationsOffset))));
                this.InterestonLateFilingPenalty = ((double)(this.GetVariableValue((22 + locationsOffset))));
                this.totalinterest = ((double)(this.GetVariableValue((23 + locationsOffset))));
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
                if (((locationReferences[(offset + 12)].Name != "staticmonth") 
                            || (locationReferences[(offset + 12)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "datedifference") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "monthdifference") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "datedifferentmonth") 
                            || (locationReferences[(offset + 15)].Type != typeof(System.TimeSpan)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "month") 
                            || (locationReferences[(offset + 16)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "latefilingorpayingPenality") 
                            || (locationReferences[(offset + 17)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 18)].Name != "InterestonUnpaidtaxdue") 
                            || (locationReferences[(offset + 18)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "LatePaymentPenaltybeforeduedate") 
                            || (locationReferences[(offset + 19)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "LatePaymentPenaltyafterduedate") 
                            || (locationReferences[(offset + 20)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "LateFilingPenaltyforInterest") 
                            || (locationReferences[(offset + 21)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "InterestonLateFilingPenalty") 
                            || (locationReferences[(offset + 22)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "totalinterest") 
                            || (locationReferences[(offset + 23)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZTaxesAndPenalties_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext5 : F1040EZTaxesAndPenalties_TypedDataContext4 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int monthbetweenfilingdateAndduedate;
            
            protected double runningCalculation;
            
            protected System.DateTime currentQuater;
            
            public F1040EZTaxesAndPenalties_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 196 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                              month;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr18Get() {
                
                #line 196 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              month;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(int value) {
                
                #line 196 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                              month = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 216 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    runningCalculation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr21Get() {
                
                #line 216 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    runningCalculation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr21Set(double value) {
                
                #line 216 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    runningCalculation = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 228 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                    currentQuater;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr23Get() {
                
                #line 228 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    currentQuater;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr23Set(System.DateTime value) {
                
                #line 228 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    currentQuater = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr23Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr23Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                    monthbetweenfilingdateAndduedate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr25Get() {
                
                #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    monthbetweenfilingdateAndduedate;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr25Set(int value) {
                
                #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    monthbetweenfilingdateAndduedate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr25Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr25Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.monthbetweenfilingdateAndduedate = ((int)(this.GetVariableValue((24 + locationsOffset))));
                this.runningCalculation = ((double)(this.GetVariableValue((25 + locationsOffset))));
                this.currentQuater = ((System.DateTime)(this.GetVariableValue((26 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((24 + locationsOffset), this.monthbetweenfilingdateAndduedate);
                this.SetVariableValue((25 + locationsOffset), this.runningCalculation);
                this.SetVariableValue((26 + locationsOffset), this.currentQuater);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 27))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 27);
                }
                expectedLocationsCount = 27;
                if (((locationReferences[(offset + 24)].Name != "monthbetweenfilingdateAndduedate") 
                            || (locationReferences[(offset + 24)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 25)].Name != "runningCalculation") 
                            || (locationReferences[(offset + 25)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 26)].Name != "currentQuater") 
                            || (locationReferences[(offset + 26)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                return F1040EZTaxesAndPenalties_TypedDataContext4.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly : F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int monthbetweenfilingdateAndduedate;
            
            protected double runningCalculation;
            
            protected System.DateTime currentQuater;
            
            public F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 183 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                              month;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr15Get() {
                
                #line 183 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              month;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 189 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                              dueDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr16Get() {
                
                #line 189 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              dueDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 201 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                              ((filingDate.Year - dueDate.Year) * 12) + filingDate.Month - dueDate.Month;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr17Get() {
                
                #line 201 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              ((filingDate.Year - dueDate.Year) * 12) + filingDate.Month - dueDate.Month;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 208 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              month > 2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr19Get() {
                
                #line 208 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                              month > 2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 221 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    taxdueamount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr20Get() {
                
                #line 221 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    taxdueamount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 233 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                    dueDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr22Get() {
                
                #line 233 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    dueDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 245 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                    month;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr24Get() {
                
                #line 245 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    month;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            protected override void GetValueTypeValues() {
                this.monthbetweenfilingdateAndduedate = ((int)(this.GetVariableValue((24 + locationsOffset))));
                this.runningCalculation = ((double)(this.GetVariableValue((25 + locationsOffset))));
                this.currentQuater = ((System.DateTime)(this.GetVariableValue((26 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 27))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 27);
                }
                expectedLocationsCount = 27;
                if (((locationReferences[(offset + 24)].Name != "monthbetweenfilingdateAndduedate") 
                            || (locationReferences[(offset + 24)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 25)].Name != "runningCalculation") 
                            || (locationReferences[(offset + 25)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 26)].Name != "currentQuater") 
                            || (locationReferences[(offset + 26)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                return F1040EZTaxesAndPenalties_TypedDataContext4_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext6 : F1040EZTaxesAndPenalties_TypedDataContext5 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int iteration;
            
            public F1040EZTaxesAndPenalties_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                this.iteration = ((int)(this.GetVariableValue((27 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((27 + locationsOffset), this.iteration);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 28))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 28);
                }
                expectedLocationsCount = 28;
                if (((locationReferences[(offset + 27)].Name != "iteration") 
                            || (locationReferences[(offset + 27)].Type != typeof(int)))) {
                    return false;
                }
                return F1040EZTaxesAndPenalties_TypedDataContext5.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext6_ForReadOnly : F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int iteration;
            
            public F1040EZTaxesAndPenalties_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                this.iteration = ((int)(this.GetVariableValue((27 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 28))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 28);
                }
                expectedLocationsCount = 28;
                if (((locationReferences[(offset + 27)].Name != "iteration") 
                            || (locationReferences[(offset + 27)].Type != typeof(int)))) {
                    return false;
                }
                return F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext7 : F1040EZTaxesAndPenalties_TypedDataContext6 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZTaxesAndPenalties_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string variable2 {
                get {
                    return ((string)(this.GetVariableValue((28 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((28 + locationsOffset), value);
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
                            && (locationReferences.Count < 29))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 29);
                }
                expectedLocationsCount = 29;
                if (((locationReferences[(offset + 28)].Name != "variable2") 
                            || (locationReferences[(offset + 28)].Type != typeof(string)))) {
                    return false;
                }
                return F1040EZTaxesAndPenalties_TypedDataContext6.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext7_ForReadOnly : F1040EZTaxesAndPenalties_TypedDataContext6_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZTaxesAndPenalties_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string variable2 {
                get {
                    return ((string)(this.GetVariableValue((28 + locationsOffset))));
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
                
                #line 258 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    iteration <= monthbetweenfilingdateAndduedate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr26Get() {
                
                #line 258 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    iteration <= monthbetweenfilingdateAndduedate;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 29))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 29);
                }
                expectedLocationsCount = 29;
                if (((locationReferences[(offset + 28)].Name != "variable2") 
                            || (locationReferences[(offset + 28)].Type != typeof(string)))) {
                    return false;
                }
                return F1040EZTaxesAndPenalties_TypedDataContext6_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext8 : F1040EZTaxesAndPenalties_TypedDataContext7 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZTaxesAndPenalties_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext8(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.InterestOnUnpaidDue interestOnUnpaidDue {
                get {
                    return ((JTL.Tax1040.BusinessObject.InterestOnUnpaidDue)(this.GetVariableValue((29 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((29 + locationsOffset), value);
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
                
                #line 271 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                          interestOnUnpaidDue.QuarterStartDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr29Get() {
                
                #line 271 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                          interestOnUnpaidDue.QuarterStartDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr29Set(System.DateTime value) {
                
                #line 271 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                          interestOnUnpaidDue.QuarterStartDate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 291 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                currentQuater;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr32Get() {
                
                #line 291 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                currentQuater;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr32Set(System.DateTime value) {
                
                #line 291 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                currentQuater = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr32Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr32Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 303 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                currentQuater;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr34Get() {
                
                #line 303 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                currentQuater;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr34Set(System.DateTime value) {
                
                #line 303 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                currentQuater = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr34Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr34Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 315 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                interestOnUnpaidDue.QuarterStartDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr36Get() {
                
                #line 315 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                interestOnUnpaidDue.QuarterStartDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr36Set(System.DateTime value) {
                
                #line 315 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                interestOnUnpaidDue.QuarterStartDate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr36Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr36Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 327 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                interestOnUnpaidDue.QuarterEndDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr38Get() {
                
                #line 327 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                interestOnUnpaidDue.QuarterEndDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr38Set(System.DateTime value) {
                
                #line 327 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                interestOnUnpaidDue.QuarterEndDate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr38Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr38Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 339 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                interestOnUnpaidDue.interestRate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr40Get() {
                
                #line 339 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                interestOnUnpaidDue.interestRate;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr40Set(double value) {
                
                #line 339 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                interestOnUnpaidDue.interestRate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr40Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr40Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 351 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                datedifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr42Get() {
                
                #line 351 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                datedifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr42Set(double value) {
                
                #line 351 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                datedifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr42Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr42Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                monthdifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr44Get() {
                
                #line 363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                monthdifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr44Set(double value) {
                
                #line 363 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                monthdifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr44Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr44Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 375 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                interestOnUnpaidDue.NumberOfDays;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr46Get() {
                
                #line 375 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                interestOnUnpaidDue.NumberOfDays;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr46Set(double value) {
                
                #line 375 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                interestOnUnpaidDue.NumberOfDays = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr46Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr46Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 387 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                interestOnUnpaidDue.InterestAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr48Get() {
                
                #line 387 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                interestOnUnpaidDue.InterestAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr48Set(double value) {
                
                #line 387 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                interestOnUnpaidDue.InterestAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr48Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr48Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 399 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                interestOnUnpaidDue.Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr50Get() {
                
                #line 399 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                interestOnUnpaidDue.Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr50Set(double value) {
                
                #line 399 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                interestOnUnpaidDue.Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr50Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr50Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 411 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                runningCalculation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr52Get() {
                
                #line 411 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                runningCalculation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr52Set(double value) {
                
                #line 411 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                runningCalculation = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr52Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr52Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 423 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                interestOnUnpaidDue.Balance;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr54Get() {
                
                #line 423 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                interestOnUnpaidDue.Balance;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr54Set(double value) {
                
                #line 423 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                interestOnUnpaidDue.Balance = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr54Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr54Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 445 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                currentQuater;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr58Get() {
                
                #line 445 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                currentQuater;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr58Set(System.DateTime value) {
                
                #line 445 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                currentQuater = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr58Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr58Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 457 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                iteration;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr60Get() {
                
                #line 457 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                iteration;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr60Set(int value) {
                
                #line 457 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                iteration = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr60Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr60Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 473 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                month;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr62Get() {
                
                #line 473 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                month;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr62Set(int value) {
                
                #line 473 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                month = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr62Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr62Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 493 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                      interestOnUnpaidDue.QuarterStartDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr65Get() {
                
                #line 493 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      interestOnUnpaidDue.QuarterStartDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr65Set(System.DateTime value) {
                
                #line 493 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      interestOnUnpaidDue.QuarterStartDate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr65Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr65Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 505 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                      currentQuater;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr67Get() {
                
                #line 505 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      currentQuater;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr67Set(System.DateTime value) {
                
                #line 505 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      currentQuater = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr67Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr67Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 517 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                      interestOnUnpaidDue.QuarterEndDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr69Get() {
                
                #line 517 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      interestOnUnpaidDue.QuarterEndDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr69Set(System.DateTime value) {
                
                #line 517 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      interestOnUnpaidDue.QuarterEndDate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr69Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr69Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 529 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      interestOnUnpaidDue.interestRate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr71Get() {
                
                #line 529 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      interestOnUnpaidDue.interestRate;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr71Set(double value) {
                
                #line 529 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      interestOnUnpaidDue.interestRate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr71Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr71Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 541 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      datedifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr73Get() {
                
                #line 541 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      datedifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr73Set(double value) {
                
                #line 541 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      datedifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr73Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr73Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr75GetTree() {
                
                #line 553 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      monthdifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr75Get() {
                
                #line 553 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      monthdifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr75Get() {
                this.GetValueTypeValues();
                return this.@__Expr75Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr75Set(double value) {
                
                #line 553 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      monthdifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr75Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr75Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr77GetTree() {
                
                #line 565 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      interestOnUnpaidDue.NumberOfDays;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr77Get() {
                
                #line 565 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      interestOnUnpaidDue.NumberOfDays;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr77Get() {
                this.GetValueTypeValues();
                return this.@__Expr77Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr77Set(double value) {
                
                #line 565 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      interestOnUnpaidDue.NumberOfDays = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr77Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr77Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr79GetTree() {
                
                #line 577 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      interestOnUnpaidDue.InterestAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr79Get() {
                
                #line 577 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      interestOnUnpaidDue.InterestAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr79Get() {
                this.GetValueTypeValues();
                return this.@__Expr79Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr79Set(double value) {
                
                #line 577 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      interestOnUnpaidDue.InterestAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr79Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr79Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr81GetTree() {
                
                #line 589 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      interestOnUnpaidDue.Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr81Get() {
                
                #line 589 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      interestOnUnpaidDue.Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr81Get() {
                this.GetValueTypeValues();
                return this.@__Expr81Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr81Set(double value) {
                
                #line 589 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      interestOnUnpaidDue.Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr81Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr81Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr83GetTree() {
                
                #line 601 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      runningCalculation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr83Get() {
                
                #line 601 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      runningCalculation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr83Get() {
                this.GetValueTypeValues();
                return this.@__Expr83Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr83Set(double value) {
                
                #line 601 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      runningCalculation = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr83Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr83Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr85GetTree() {
                
                #line 613 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      interestOnUnpaidDue.Balance;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr85Get() {
                
                #line 613 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      interestOnUnpaidDue.Balance;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr85Get() {
                this.GetValueTypeValues();
                return this.@__Expr85Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr85Set(double value) {
                
                #line 613 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      interestOnUnpaidDue.Balance = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr85Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr85Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr87GetTree() {
                
                #line 625 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                      iteration;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr87Get() {
                
                #line 625 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      iteration;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr87Get() {
                this.GetValueTypeValues();
                return this.@__Expr87Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr87Set(int value) {
                
                #line 625 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      iteration = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr87Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr87Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr89GetTree() {
                
                #line 641 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                      interestOnUnpaidDue.QuarterStartDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr89Get() {
                
                #line 641 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      interestOnUnpaidDue.QuarterStartDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr89Get() {
                this.GetValueTypeValues();
                return this.@__Expr89Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr89Set(System.DateTime value) {
                
                #line 641 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      interestOnUnpaidDue.QuarterStartDate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr89Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr89Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr91GetTree() {
                
                #line 653 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                      interestOnUnpaidDue.QuarterEndDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr91Get() {
                
                #line 653 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      interestOnUnpaidDue.QuarterEndDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr91Get() {
                this.GetValueTypeValues();
                return this.@__Expr91Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr91Set(System.DateTime value) {
                
                #line 653 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      interestOnUnpaidDue.QuarterEndDate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr91Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr91Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr93GetTree() {
                
                #line 665 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      interestOnUnpaidDue.interestRate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr93Get() {
                
                #line 665 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      interestOnUnpaidDue.interestRate;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr93Get() {
                this.GetValueTypeValues();
                return this.@__Expr93Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr93Set(double value) {
                
                #line 665 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      interestOnUnpaidDue.interestRate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr93Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr93Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr95GetTree() {
                
                #line 677 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      datedifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr95Get() {
                
                #line 677 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      datedifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr95Get() {
                this.GetValueTypeValues();
                return this.@__Expr95Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr95Set(double value) {
                
                #line 677 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      datedifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr95Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr95Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr97GetTree() {
                
                #line 689 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      monthdifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr97Get() {
                
                #line 689 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      monthdifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr97Get() {
                this.GetValueTypeValues();
                return this.@__Expr97Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr97Set(double value) {
                
                #line 689 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      monthdifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr97Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr97Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr99GetTree() {
                
                #line 701 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      interestOnUnpaidDue.NumberOfDays;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr99Get() {
                
                #line 701 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      interestOnUnpaidDue.NumberOfDays;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr99Get() {
                this.GetValueTypeValues();
                return this.@__Expr99Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr99Set(double value) {
                
                #line 701 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      interestOnUnpaidDue.NumberOfDays = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr99Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr99Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr101GetTree() {
                
                #line 713 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      interestOnUnpaidDue.InterestAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr101Get() {
                
                #line 713 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      interestOnUnpaidDue.InterestAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr101Get() {
                this.GetValueTypeValues();
                return this.@__Expr101Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr101Set(double value) {
                
                #line 713 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      interestOnUnpaidDue.InterestAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr101Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr101Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr103GetTree() {
                
                #line 725 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      interestOnUnpaidDue.Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr103Get() {
                
                #line 725 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      interestOnUnpaidDue.Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr103Get() {
                this.GetValueTypeValues();
                return this.@__Expr103Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr103Set(double value) {
                
                #line 725 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      interestOnUnpaidDue.Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr103Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr103Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr105GetTree() {
                
                #line 737 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      runningCalculation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr105Get() {
                
                #line 737 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      runningCalculation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr105Get() {
                this.GetValueTypeValues();
                return this.@__Expr105Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr105Set(double value) {
                
                #line 737 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      runningCalculation = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr105Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr105Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr107GetTree() {
                
                #line 749 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      interestOnUnpaidDue.Balance;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr107Get() {
                
                #line 749 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      interestOnUnpaidDue.Balance;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr107Get() {
                this.GetValueTypeValues();
                return this.@__Expr107Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr107Set(double value) {
                
                #line 749 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      interestOnUnpaidDue.Balance = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr107Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr107Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr109GetTree() {
                
                #line 761 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                      iteration;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr109Get() {
                
                #line 761 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      iteration;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr109Get() {
                this.GetValueTypeValues();
                return this.@__Expr109Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr109Set(int value) {
                
                #line 761 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                                      iteration = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr109Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr109Set(value);
                this.SetValueTypeValues();
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
                if (((locationReferences[(offset + 29)].Name != "interestOnUnpaidDue") 
                            || (locationReferences[(offset + 29)].Type != typeof(JTL.Tax1040.BusinessObject.InterestOnUnpaidDue)))) {
                    return false;
                }
                return F1040EZTaxesAndPenalties_TypedDataContext7.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly : F1040EZTaxesAndPenalties_TypedDataContext7_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.InterestOnUnpaidDue interestOnUnpaidDue {
                get {
                    return ((JTL.Tax1040.BusinessObject.InterestOnUnpaidDue)(this.GetVariableValue((29 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 264 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue>> expression = () => 
                                          new InterestOnUnpaidDue();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.InterestOnUnpaidDue @__Expr27Get() {
                
                #line 264 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                          new InterestOnUnpaidDue();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.InterestOnUnpaidDue ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 276 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                          dueDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr28Get() {
                
                #line 276 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                          dueDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 283 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                          currentQuater.Month == staticmonth;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr30Get() {
                
                #line 283 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                          currentQuater.Month == staticmonth;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 296 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                currentQuater.AddMonths(2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr31Get() {
                
                #line 296 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                currentQuater.AddMonths(2);
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 308 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                new DateTime(currentQuater.Year, currentQuater.Month, 1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr33Get() {
                
                #line 308 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                new DateTime(currentQuater.Year, currentQuater.Month, 1);
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 320 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                dueDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr35Get() {
                
                #line 320 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                dueDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 332 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                new DateTime(dueDate.Year, currentQuater.Month, DateTime.DaysInMonth(currentQuater.Year, currentQuater.Month));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr37Get() {
                
                #line 332 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                new DateTime(dueDate.Year, currentQuater.Month, DateTime.DaysInMonth(currentQuater.Year, currentQuater.Month));
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 344 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                interestAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr39Get() {
                
                #line 344 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                interestAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 356 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                (interestOnUnpaidDue.QuarterEndDate - interestOnUnpaidDue.QuarterStartDate).Days;;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr41Get() {
                
                #line 356 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                (interestOnUnpaidDue.QuarterEndDate - interestOnUnpaidDue.QuarterStartDate).Days;;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 368 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                Math.Round(datedifference / 30, 2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr43Get() {
                
                #line 368 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                Math.Round(datedifference / 30, 2);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 380 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                datedifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr45Get() {
                
                #line 380 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                datedifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 392 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                Math.Round(taxdueamount * ((double)interestAmount / 100) * ((double)datedifference / 365), 2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr47Get() {
                
                #line 392 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                Math.Round(taxdueamount * ((double)interestAmount / 100) * ((double)datedifference / 365), 2);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 404 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                runningCalculation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr49Get() {
                
                #line 404 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                runningCalculation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 416 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                runningCalculation + interestOnUnpaidDue.InterestAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr51Get() {
                
                #line 416 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                runningCalculation + interestOnUnpaidDue.InterestAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 428 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                runningCalculation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr53Get() {
                
                #line 428 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                runningCalculation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 439 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue>>> expression = () => 
                                              Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue> @__Expr55Get() {
                
                #line 439 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                              Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue> ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 435 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue>> expression = () => 
                                                interestOnUnpaidDue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.InterestOnUnpaidDue @__Expr56Get() {
                
                #line 435 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                interestOnUnpaidDue;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.InterestOnUnpaidDue ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 450 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                interestOnUnpaidDue.QuarterEndDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr57Get() {
                
                #line 450 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                interestOnUnpaidDue.QuarterEndDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 462 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                iteration+2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr59Get() {
                
                #line 462 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                iteration+2;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 478 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                ((filingDate.Year - currentQuater.Year) * 12) + filingDate.Month - currentQuater.Month;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr61Get() {
                
                #line 478 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                ((filingDate.Year - currentQuater.Year) * 12) + filingDate.Month - currentQuater.Month;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 485 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                month > 3;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr63Get() {
                
                #line 485 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                month > 3;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 498 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                      new DateTime(currentQuater.Year, currentQuater.AddMonths(1).Month, 1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr64Get() {
                
                #line 498 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      new DateTime(currentQuater.Year, currentQuater.AddMonths(1).Month, 1);
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 510 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                      currentQuater.AddMonths(3);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr66Get() {
                
                #line 510 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      currentQuater.AddMonths(3);
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 522 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                      new DateTime(currentQuater.Year, currentQuater.Month, DateTime.DaysInMonth(currentQuater.Year, currentQuater.Month));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr68Get() {
                
                #line 522 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      new DateTime(currentQuater.Year, currentQuater.Month, DateTime.DaysInMonth(currentQuater.Year, currentQuater.Month));
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 534 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      interestAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr70Get() {
                
                #line 534 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      interestAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 546 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      (interestOnUnpaidDue.QuarterEndDate - interestOnUnpaidDue.QuarterStartDate).Days;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr72Get() {
                
                #line 546 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      (interestOnUnpaidDue.QuarterEndDate - interestOnUnpaidDue.QuarterStartDate).Days;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 558 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      Math.Round(datedifference / 30, 2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr74Get() {
                
                #line 558 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      Math.Round(datedifference / 30, 2);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr76GetTree() {
                
                #line 570 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      datedifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr76Get() {
                
                #line 570 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      datedifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr76Get() {
                this.GetValueTypeValues();
                return this.@__Expr76Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr78GetTree() {
                
                #line 582 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      Math.Round(taxdueamount * ((double)interestAmount / 100) * ((double)datedifference / 365), 2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr78Get() {
                
                #line 582 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      Math.Round(taxdueamount * ((double)interestAmount / 100) * ((double)datedifference / 365), 2);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr78Get() {
                this.GetValueTypeValues();
                return this.@__Expr78Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr80GetTree() {
                
                #line 594 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      runningCalculation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr80Get() {
                
                #line 594 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      runningCalculation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr80Get() {
                this.GetValueTypeValues();
                return this.@__Expr80Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr82GetTree() {
                
                #line 606 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      runningCalculation + interestOnUnpaidDue.InterestAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr82Get() {
                
                #line 606 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      runningCalculation + interestOnUnpaidDue.InterestAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr82Get() {
                this.GetValueTypeValues();
                return this.@__Expr82Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr84GetTree() {
                
                #line 618 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      runningCalculation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr84Get() {
                
                #line 618 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      runningCalculation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr84Get() {
                this.GetValueTypeValues();
                return this.@__Expr84Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr86GetTree() {
                
                #line 630 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                      iteration+3;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr86Get() {
                
                #line 630 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      iteration+3;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr86Get() {
                this.GetValueTypeValues();
                return this.@__Expr86Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr88GetTree() {
                
                #line 646 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                      new DateTime(currentQuater.Year, currentQuater.AddMonths(1).Month, 1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr88Get() {
                
                #line 646 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      new DateTime(currentQuater.Year, currentQuater.AddMonths(1).Month, 1);
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr88Get() {
                this.GetValueTypeValues();
                return this.@__Expr88Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr90GetTree() {
                
                #line 658 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                                      new DateTime(filingDate.Year, filingDate.Month, filingDate.Day);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr90Get() {
                
                #line 658 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      new DateTime(filingDate.Year, filingDate.Month, filingDate.Day);
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr90Get() {
                this.GetValueTypeValues();
                return this.@__Expr90Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr92GetTree() {
                
                #line 670 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      interestAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr92Get() {
                
                #line 670 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      interestAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr92Get() {
                this.GetValueTypeValues();
                return this.@__Expr92Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr94GetTree() {
                
                #line 682 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      (interestOnUnpaidDue.QuarterEndDate - interestOnUnpaidDue.QuarterStartDate).Days;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr94Get() {
                
                #line 682 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      (interestOnUnpaidDue.QuarterEndDate - interestOnUnpaidDue.QuarterStartDate).Days;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr94Get() {
                this.GetValueTypeValues();
                return this.@__Expr94Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr96GetTree() {
                
                #line 694 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      Math.Round(datedifference / 30, 2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr96Get() {
                
                #line 694 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      Math.Round(datedifference / 30, 2);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr96Get() {
                this.GetValueTypeValues();
                return this.@__Expr96Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr98GetTree() {
                
                #line 706 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      datedifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr98Get() {
                
                #line 706 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      datedifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr98Get() {
                this.GetValueTypeValues();
                return this.@__Expr98Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr100GetTree() {
                
                #line 718 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      Math.Round(taxdueamount * ((double)interestAmount / 100) * ((double)datedifference / 365), 2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr100Get() {
                
                #line 718 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      Math.Round(taxdueamount * ((double)interestAmount / 100) * ((double)datedifference / 365), 2);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr100Get() {
                this.GetValueTypeValues();
                return this.@__Expr100Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr102GetTree() {
                
                #line 730 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      runningCalculation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr102Get() {
                
                #line 730 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      runningCalculation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr102Get() {
                this.GetValueTypeValues();
                return this.@__Expr102Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr104GetTree() {
                
                #line 742 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      runningCalculation + interestOnUnpaidDue.InterestAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr104Get() {
                
                #line 742 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      runningCalculation + interestOnUnpaidDue.InterestAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr104Get() {
                this.GetValueTypeValues();
                return this.@__Expr104Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr106GetTree() {
                
                #line 754 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                                      runningCalculation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr106Get() {
                
                #line 754 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      runningCalculation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr106Get() {
                this.GetValueTypeValues();
                return this.@__Expr106Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr108GetTree() {
                
                #line 766 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                      iteration+month;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr108Get() {
                
                #line 766 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                      iteration+month;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr108Get() {
                this.GetValueTypeValues();
                return this.@__Expr108Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr110GetTree() {
                
                #line 780 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue>>> expression = () => 
                                              Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue> @__Expr110Get() {
                
                #line 780 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                              Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue> ValueType___Expr110Get() {
                this.GetValueTypeValues();
                return this.@__Expr110Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr111GetTree() {
                
                #line 776 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue>> expression = () => 
                                                interestOnUnpaidDue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.InterestOnUnpaidDue @__Expr111Get() {
                
                #line 776 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                                interestOnUnpaidDue;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.InterestOnUnpaidDue ValueType___Expr111Get() {
                this.GetValueTypeValues();
                return this.@__Expr111Get();
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
                if (((locationReferences[(offset + 29)].Name != "interestOnUnpaidDue") 
                            || (locationReferences[(offset + 29)].Type != typeof(JTL.Tax1040.BusinessObject.InterestOnUnpaidDue)))) {
                    return false;
                }
                return F1040EZTaxesAndPenalties_TypedDataContext7_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext9 : F1040EZTaxesAndPenalties_TypedDataContext5 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZTaxesAndPenalties_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext9(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.InterestOnUnpaidDue interestOnUnpaidDuenormal {
                get {
                    return ((JTL.Tax1040.BusinessObject.InterestOnUnpaidDue)(this.GetVariableValue((27 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((27 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr114GetTree() {
                
                #line 803 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                    interestOnUnpaidDuenormal.QuarterStartDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr114Get() {
                
                #line 803 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    interestOnUnpaidDuenormal.QuarterStartDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr114Get() {
                this.GetValueTypeValues();
                return this.@__Expr114Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr114Set(System.DateTime value) {
                
                #line 803 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    interestOnUnpaidDuenormal.QuarterStartDate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr114Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr114Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr116GetTree() {
                
                #line 815 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                    interestOnUnpaidDuenormal.QuarterEndDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr116Get() {
                
                #line 815 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    interestOnUnpaidDuenormal.QuarterEndDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr116Get() {
                this.GetValueTypeValues();
                return this.@__Expr116Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr116Set(System.DateTime value) {
                
                #line 815 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    interestOnUnpaidDuenormal.QuarterEndDate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr116Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr116Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr118GetTree() {
                
                #line 827 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    interestOnUnpaidDuenormal.interestRate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr118Get() {
                
                #line 827 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    interestOnUnpaidDuenormal.interestRate;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr118Get() {
                this.GetValueTypeValues();
                return this.@__Expr118Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr118Set(double value) {
                
                #line 827 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    interestOnUnpaidDuenormal.interestRate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr118Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr118Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr120GetTree() {
                
                #line 839 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    interestOnUnpaidDuenormal.Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr120Get() {
                
                #line 839 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    interestOnUnpaidDuenormal.Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr120Get() {
                this.GetValueTypeValues();
                return this.@__Expr120Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr120Set(double value) {
                
                #line 839 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    interestOnUnpaidDuenormal.Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr120Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr120Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr122GetTree() {
                
                #line 851 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    datedifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr122Get() {
                
                #line 851 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    datedifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr122Get() {
                this.GetValueTypeValues();
                return this.@__Expr122Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr122Set(double value) {
                
                #line 851 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    datedifference = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr122Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr122Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr124GetTree() {
                
                #line 863 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    interestOnUnpaidDuenormal.NumberOfDays;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr124Get() {
                
                #line 863 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    interestOnUnpaidDuenormal.NumberOfDays;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr124Get() {
                this.GetValueTypeValues();
                return this.@__Expr124Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr124Set(double value) {
                
                #line 863 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    interestOnUnpaidDuenormal.NumberOfDays = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr124Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr124Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr126GetTree() {
                
                #line 875 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    interestOnUnpaidDuenormal.InterestAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr126Get() {
                
                #line 875 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    interestOnUnpaidDuenormal.InterestAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr126Get() {
                this.GetValueTypeValues();
                return this.@__Expr126Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr126Set(double value) {
                
                #line 875 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    interestOnUnpaidDuenormal.InterestAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr126Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr126Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr128GetTree() {
                
                #line 887 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    interestOnUnpaidDuenormal.Balance;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr128Get() {
                
                #line 887 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    interestOnUnpaidDuenormal.Balance;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr128Get() {
                this.GetValueTypeValues();
                return this.@__Expr128Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr128Set(double value) {
                
                #line 887 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                
                                    interestOnUnpaidDuenormal.Balance = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr128Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr128Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 28))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 28);
                }
                expectedLocationsCount = 28;
                if (((locationReferences[(offset + 27)].Name != "interestOnUnpaidDuenormal") 
                            || (locationReferences[(offset + 27)].Type != typeof(JTL.Tax1040.BusinessObject.InterestOnUnpaidDue)))) {
                    return false;
                }
                return F1040EZTaxesAndPenalties_TypedDataContext5.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly : F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxesAndPenalties_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.InterestOnUnpaidDue interestOnUnpaidDuenormal {
                get {
                    return ((JTL.Tax1040.BusinessObject.InterestOnUnpaidDue)(this.GetVariableValue((27 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr112GetTree() {
                
                #line 796 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue>> expression = () => 
                                    new InterestOnUnpaidDue ();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.InterestOnUnpaidDue @__Expr112Get() {
                
                #line 796 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    new InterestOnUnpaidDue ();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.InterestOnUnpaidDue ValueType___Expr112Get() {
                this.GetValueTypeValues();
                return this.@__Expr112Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr113GetTree() {
                
                #line 808 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                    dueDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr113Get() {
                
                #line 808 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    dueDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr113Get() {
                this.GetValueTypeValues();
                return this.@__Expr113Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr115GetTree() {
                
                #line 820 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                                    filingDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr115Get() {
                
                #line 820 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    filingDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr115Get() {
                this.GetValueTypeValues();
                return this.@__Expr115Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr117GetTree() {
                
                #line 832 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    interestAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr117Get() {
                
                #line 832 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    interestAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr117Get() {
                this.GetValueTypeValues();
                return this.@__Expr117Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr119GetTree() {
                
                #line 844 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    taxdueamount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr119Get() {
                
                #line 844 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    taxdueamount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr119Get() {
                this.GetValueTypeValues();
                return this.@__Expr119Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr121GetTree() {
                
                #line 856 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    (interestOnUnpaidDuenormal.QuarterEndDate - interestOnUnpaidDuenormal.QuarterStartDate).Days;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr121Get() {
                
                #line 856 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    (interestOnUnpaidDuenormal.QuarterEndDate - interestOnUnpaidDuenormal.QuarterStartDate).Days;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr121Get() {
                this.GetValueTypeValues();
                return this.@__Expr121Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr123GetTree() {
                
                #line 868 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    datedifference;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr123Get() {
                
                #line 868 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    datedifference;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr123Get() {
                this.GetValueTypeValues();
                return this.@__Expr123Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr125GetTree() {
                
                #line 880 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Math.Round(taxdueamount * ((double)interestAmount / 100) * ((double)datedifference / 365), 2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr125Get() {
                
                #line 880 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    Math.Round(taxdueamount * ((double)interestAmount / 100) * ((double)datedifference / 365), 2);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr125Get() {
                this.GetValueTypeValues();
                return this.@__Expr125Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr127GetTree() {
                
                #line 892 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    taxdueamount + interestOnUnpaidDuenormal.InterestAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr127Get() {
                
                #line 892 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    taxdueamount + interestOnUnpaidDuenormal.InterestAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr127Get() {
                this.GetValueTypeValues();
                return this.@__Expr127Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr129GetTree() {
                
                #line 903 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue>>> expression = () => 
                                  Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue> @__Expr129Get() {
                
                #line 903 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                  Tax1040Object.TaxesAndPenalties.InterestOnUnpaidDue;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue> ValueType___Expr129Get() {
                this.GetValueTypeValues();
                return this.@__Expr129Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr130GetTree() {
                
                #line 899 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.InterestOnUnpaidDue>> expression = () => 
                                    interestOnUnpaidDuenormal;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.InterestOnUnpaidDue @__Expr130Get() {
                
                #line 899 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXESANDPENALTIES.XAML"
                return 
                                    interestOnUnpaidDuenormal;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.InterestOnUnpaidDue ValueType___Expr130Get() {
                this.GetValueTypeValues();
                return this.@__Expr130Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 28))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 28);
                }
                expectedLocationsCount = 28;
                if (((locationReferences[(offset + 27)].Name != "interestOnUnpaidDuenormal") 
                            || (locationReferences[(offset + 27)].Type != typeof(JTL.Tax1040.BusinessObject.InterestOnUnpaidDue)))) {
                    return false;
                }
                return F1040EZTaxesAndPenalties_TypedDataContext5_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
