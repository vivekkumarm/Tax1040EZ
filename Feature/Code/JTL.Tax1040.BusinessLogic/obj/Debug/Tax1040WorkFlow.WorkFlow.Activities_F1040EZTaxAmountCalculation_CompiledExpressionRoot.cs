namespace Tax1040WorkFlow.WorkFlow.Activities {
    
    #line 23 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxAmountCalculation.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxAmountCalculation.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 24 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxAmountCalculation.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxAmountCalculation.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxAmountCalculation.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxAmountCalculation.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 25 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxAmountCalculation.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 26 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxAmountCalculation.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 27 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxAmountCalculation.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 28 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxAmountCalculation.xaml"
    using JTL.Tax1040.BusinessObject;
    
    #line default
    #line hidden
    
    #line 29 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxAmountCalculation.xaml"
    using System.Collections.Concurrent;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\F1040EZTaxAmountCalculation.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class F1040EZTaxAmountCalculation : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly valDataContext0 = ((F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly valDataContext1 = ((F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly valDataContext2 = ((F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext3 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext4 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext5 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext6 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext6.GetLocation<double>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext7 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext8 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext8.GetLocation<double>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext9 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext10 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext11 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext11.GetLocation<double>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext12 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext12.GetLocation<bool>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext13 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext14 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext15 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext15.GetLocation<double>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext16 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext17 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext17.GetLocation<double>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext18 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext19 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext20 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext20.GetLocation<double>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext21 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext22 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext22.GetLocation<double>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext23 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext23.GetLocation<bool>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext24 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext25 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext26 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext26.GetLocation<double>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext27 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext28 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext28.GetLocation<double>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext29 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext30 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext31 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext31.GetLocation<double>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext32 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext33 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext33.GetLocation<double>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext34 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext34.GetLocation<bool>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext35 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext36 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext37 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext37.GetLocation<double>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext38 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext39 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext39.GetLocation<double>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext40 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext41 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext42 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext42.GetLocation<double>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext43 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext44 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext44.GetLocation<double>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext45 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext45.GetLocation<bool>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext46 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext47 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext48 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext48.GetLocation<double>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext49 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext50 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext50.GetLocation<double>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext51 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext52 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext53 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext53.GetLocation<double>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext54 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext55 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext55.GetLocation<double>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext56 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext56.GetLocation<bool>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext57 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext58 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext59 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext59.GetLocation<double>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext60 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext61 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext61.GetLocation<double>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext62 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext63 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext64 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext64.GetLocation<double>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext65 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext66 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext66.GetLocation<double>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext67 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext67.GetLocation<bool>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext68 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext69 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext70 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext70.GetLocation<double>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext71 = ((F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext72 = ((F1040EZTaxAmountCalculation_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext72.GetLocation<double>(refDataContext72.ValueType___Expr72Get, refDataContext72.ValueType___Expr72Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly valDataContext73 = ((F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = F1040EZTaxAmountCalculation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new F1040EZTaxAmountCalculation_TypedDataContext2(locations, activityContext, true);
                }
                F1040EZTaxAmountCalculation_TypedDataContext2 refDataContext74 = ((F1040EZTaxAmountCalculation_TypedDataContext2)(cachedCompiledDataContext[3]));
                return refDataContext74.GetLocation<double>(refDataContext74.ValueType___Expr74Get, refDataContext74.ValueType___Expr74Set, expressionId, this.rootActivity, activityContext);
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
                F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly valDataContext0 = new F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly valDataContext1 = new F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly valDataContext2 = new F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext3 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext4 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext5 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext6 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext6.GetLocation<double>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext7 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext8 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext8.GetLocation<double>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext9 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext10 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext11 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext11.GetLocation<double>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext12 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext12.GetLocation<bool>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext13 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext14 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext15 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext15.GetLocation<double>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            if ((expressionId == 16)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext16 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext17 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext17.GetLocation<double>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext18 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext19 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext20 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext20.GetLocation<double>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set);
            }
            if ((expressionId == 21)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext21 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext22 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext22.GetLocation<double>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set);
            }
            if ((expressionId == 23)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext23 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext23.GetLocation<bool>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set);
            }
            if ((expressionId == 24)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext24 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext25 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext26 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext26.GetLocation<double>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext27 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext28 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext28.GetLocation<double>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set);
            }
            if ((expressionId == 29)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext29 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext30 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext31 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext31.GetLocation<double>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set);
            }
            if ((expressionId == 32)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext32 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext33 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext33.GetLocation<double>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set);
            }
            if ((expressionId == 34)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext34 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext34.GetLocation<bool>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set);
            }
            if ((expressionId == 35)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext35 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext36 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext37 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext37.GetLocation<double>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set);
            }
            if ((expressionId == 38)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext38 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext39 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext39.GetLocation<double>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set);
            }
            if ((expressionId == 40)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext40 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext41 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext42 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext42.GetLocation<double>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set);
            }
            if ((expressionId == 43)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext43 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext44 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext44.GetLocation<double>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set);
            }
            if ((expressionId == 45)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext45 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext45.GetLocation<bool>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set);
            }
            if ((expressionId == 46)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext46 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext47 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext48 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext48.GetLocation<double>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set);
            }
            if ((expressionId == 49)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext49 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext50 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext50.GetLocation<double>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set);
            }
            if ((expressionId == 51)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext51 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext52 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext53 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext53.GetLocation<double>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set);
            }
            if ((expressionId == 54)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext54 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext55 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext55.GetLocation<double>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set);
            }
            if ((expressionId == 56)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext56 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext56.GetLocation<bool>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set);
            }
            if ((expressionId == 57)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext57 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext58 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext59 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext59.GetLocation<double>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set);
            }
            if ((expressionId == 60)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext60 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext61 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext61.GetLocation<double>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set);
            }
            if ((expressionId == 62)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext62 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext63 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext64 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext64.GetLocation<double>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set);
            }
            if ((expressionId == 65)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext65 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext66 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext66.GetLocation<double>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set);
            }
            if ((expressionId == 67)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext67 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext67.GetLocation<bool>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set);
            }
            if ((expressionId == 68)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext68 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext69 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext70 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext70.GetLocation<double>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set);
            }
            if ((expressionId == 71)) {
                F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly valDataContext71 = new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                F1040EZTaxAmountCalculation_TypedDataContext3 refDataContext72 = new F1040EZTaxAmountCalculation_TypedDataContext3(locations, true);
                return refDataContext72.GetLocation<double>(refDataContext72.ValueType___Expr72Get, refDataContext72.ValueType___Expr72Set);
            }
            if ((expressionId == 73)) {
                F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly valDataContext73 = new F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                F1040EZTaxAmountCalculation_TypedDataContext2 refDataContext74 = new F1040EZTaxAmountCalculation_TypedDataContext2(locations, true);
                return refDataContext74.GetLocation<double>(refDataContext74.ValueType___Expr74Get, refDataContext74.ValueType___Expr74Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
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
                        && (F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome>0.0") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange1End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "SingleRange1End - SingleRange1Start") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ProcessingIncome") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax + (ProcessingIncome * Range1TaxRate)") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange1End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax + (ProcessingIncome * Range1TaxRate)") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsCaseContinue") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange2End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "SingleRange2End - SingleRange1End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ProcessingIncome") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax + (ProcessingIncome * Range2TaxRate)") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange2End && IsCa" +
                            "seContinue") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange1End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ProcessingIncome") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax + (ProcessingIncome * Range2TaxRate)") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsCaseContinue") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange3End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "SingleRange3End - SingleRange2End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ProcessingIncome") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax + (ProcessingIncome * Range3TaxRate)") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange3End && IsCa" +
                            "seContinue") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange2End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ProcessingIncome") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax + (ProcessingIncome * Range3TaxRate)") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsCaseContinue") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange4End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "SingleRange4End - SingleRange3End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ProcessingIncome") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax + (ProcessingIncome * Range4TaxRate)") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange4End && IsCa" +
                            "seContinue") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange3End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ProcessingIncome") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax + (ProcessingIncome * Range4TaxRate)") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsCaseContinue") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange5End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "SingleRange5End - SingleRange4End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ProcessingIncome") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax + (ProcessingIncome * Range5TaxRate)") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange5End && IsCa" +
                            "seContinue") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange4End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ProcessingIncome") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax + (ProcessingIncome * Range5TaxRate)") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsCaseContinue") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange6End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "SingleRange6End - SingleRange5End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ProcessingIncome") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax + (ProcessingIncome * Range6TaxRate)") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange6End && IsCa" +
                            "seContinue") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange5End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ProcessingIncome") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax + (ProcessingIncome * Range6TaxRate)") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsCaseContinue") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome >= SingleRange7Start") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange6End") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ProcessingIncome") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax + (ProcessingIncome * Range7TaxRate)") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(Tax,MidpointRounding.AwayFromZero)") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalTaxAmount") 
                        && (F1040EZTaxAmountCalculation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
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
                return new F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext3(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new F1040EZTaxAmountCalculation_TypedDataContext2(locationReferences).@__Expr74GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxAmountCalculation_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZTaxAmountCalculation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxAmountCalculation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxAmountCalculation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1040EZTaxAmountCalculation_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public F1040EZTaxAmountCalculation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxAmountCalculation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxAmountCalculation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class F1040EZTaxAmountCalculation_TypedDataContext1 : F1040EZTaxAmountCalculation_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalTaxAmount;
            
            protected int EICOut;
            
            public F1040EZTaxAmountCalculation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxAmountCalculation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxAmountCalculation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                this.TotalTaxAmount = ((double)(this.GetVariableValue((1 + locationsOffset))));
                this.EICOut = ((int)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((1 + locationsOffset), this.TotalTaxAmount);
                this.SetVariableValue((2 + locationsOffset), this.EICOut);
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
                if (((locationReferences[(offset + 1)].Name != "TotalTaxAmount") 
                            || (locationReferences[(offset + 1)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "EICOut") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                return F1040EZTaxAmountCalculation_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxAmountCalculation_TypedDataContext1_ForReadOnly : F1040EZTaxAmountCalculation_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double TotalTaxAmount;
            
            protected int EICOut;
            
            public F1040EZTaxAmountCalculation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxAmountCalculation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxAmountCalculation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                this.TotalTaxAmount = ((double)(this.GetVariableValue((1 + locationsOffset))));
                this.EICOut = ((int)(this.GetVariableValue((2 + locationsOffset))));
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
                if (((locationReferences[(offset + 1)].Name != "TotalTaxAmount") 
                            || (locationReferences[(offset + 1)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "EICOut") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                return F1040EZTaxAmountCalculation_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxAmountCalculation_TypedDataContext2 : F1040EZTaxAmountCalculation_TypedDataContext1 {
            
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
            
            protected double Range1TaxRate;
            
            public F1040EZTaxAmountCalculation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxAmountCalculation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxAmountCalculation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Concurrent.ConcurrentDictionary<int, int> Form1040ezEICCollection {
                get {
                    return ((System.Collections.Concurrent.ConcurrentDictionary<int, int>)(this.GetVariableValue((13 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 665 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
          TotalTaxAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr74Get() {
                
                #line 665 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
          TotalTaxAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr74Set(double value) {
                
                #line 665 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
          TotalTaxAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr74Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr74Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.ProcessingIncome = ((double)(this.GetVariableValue((3 + locationsOffset))));
                this.Tax = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.Range2TaxRate = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.Range3TaxRate = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.Range4TaxRate = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.Range5TaxRate = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.Range6TaxRate = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.IsCaseContinue = ((bool)(this.GetVariableValue((10 + locationsOffset))));
                this.Range7TaxRate = ((double)(this.GetVariableValue((11 + locationsOffset))));
                this.Range1TaxRate = ((double)(this.GetVariableValue((12 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((3 + locationsOffset), this.ProcessingIncome);
                this.SetVariableValue((4 + locationsOffset), this.Tax);
                this.SetVariableValue((5 + locationsOffset), this.Range2TaxRate);
                this.SetVariableValue((6 + locationsOffset), this.Range3TaxRate);
                this.SetVariableValue((7 + locationsOffset), this.Range4TaxRate);
                this.SetVariableValue((8 + locationsOffset), this.Range5TaxRate);
                this.SetVariableValue((9 + locationsOffset), this.Range6TaxRate);
                this.SetVariableValue((10 + locationsOffset), this.IsCaseContinue);
                this.SetVariableValue((11 + locationsOffset), this.Range7TaxRate);
                this.SetVariableValue((12 + locationsOffset), this.Range1TaxRate);
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
                if (((locationReferences[(offset + 13)].Name != "Form1040ezEICCollection") 
                            || (locationReferences[(offset + 13)].Type != typeof(System.Collections.Concurrent.ConcurrentDictionary<int, int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "ProcessingIncome") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Tax") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Range2TaxRate") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Range3TaxRate") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "Range4TaxRate") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "Range5TaxRate") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "Range6TaxRate") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "IsCaseContinue") 
                            || (locationReferences[(offset + 10)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "Range7TaxRate") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "Range1TaxRate") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZTaxAmountCalculation_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly : F1040EZTaxAmountCalculation_TypedDataContext1_ForReadOnly {
            
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
            
            protected double Range1TaxRate;
            
            public F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Concurrent.ConcurrentDictionary<int, int> Form1040ezEICCollection {
                get {
                    return ((System.Collections.Concurrent.ConcurrentDictionary<int, int>)(this.GetVariableValue((13 + locationsOffset))));
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
                
                #line 57 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr0Get() {
                
                #line 57 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 71 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
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
            public System.Collections.Concurrent.ConcurrentDictionary<int, int> @__Expr1Get() {
                
                #line 71 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
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
            
            public System.Collections.Concurrent.ConcurrentDictionary<int, int> ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 110 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.FilingStatus>> expression = () => 
          Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.FilingStatus @__Expr2Get() {
                
                #line 110 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
          Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.FilingStatus ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 670 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
          Math.Round(Tax,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr73Get() {
                
                #line 670 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
          Math.Round(Tax,MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
            }
            
            protected override void GetValueTypeValues() {
                this.ProcessingIncome = ((double)(this.GetVariableValue((3 + locationsOffset))));
                this.Tax = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.Range2TaxRate = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.Range3TaxRate = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.Range4TaxRate = ((double)(this.GetVariableValue((7 + locationsOffset))));
                this.Range5TaxRate = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.Range6TaxRate = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.IsCaseContinue = ((bool)(this.GetVariableValue((10 + locationsOffset))));
                this.Range7TaxRate = ((double)(this.GetVariableValue((11 + locationsOffset))));
                this.Range1TaxRate = ((double)(this.GetVariableValue((12 + locationsOffset))));
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
                if (((locationReferences[(offset + 13)].Name != "Form1040ezEICCollection") 
                            || (locationReferences[(offset + 13)].Type != typeof(System.Collections.Concurrent.ConcurrentDictionary<int, int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "ProcessingIncome") 
                            || (locationReferences[(offset + 3)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Tax") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Range2TaxRate") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Range3TaxRate") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "Range4TaxRate") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "Range5TaxRate") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "Range6TaxRate") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "IsCaseContinue") 
                            || (locationReferences[(offset + 10)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "Range7TaxRate") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "Range1TaxRate") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZTaxAmountCalculation_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxAmountCalculation_TypedDataContext3 : F1040EZTaxAmountCalculation_TypedDataContext2 {
            
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
            
            public F1040EZTaxAmountCalculation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxAmountCalculation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxAmountCalculation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string variable2 {
                get {
                    return ((string)(this.GetVariableValue((27 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 149 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          ProcessingIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr6Get() {
                
                #line 149 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          ProcessingIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(double value) {
                
                #line 149 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                          ProcessingIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 161 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr8Get() {
                
                #line 161 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          Tax;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(double value) {
                
                #line 161 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                          Tax = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 184 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr11Get() {
                
                #line 184 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              Tax;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(double value) {
                
                #line 184 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                              Tax = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 196 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              IsCaseContinue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr12Get() {
                
                #line 196 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              IsCaseContinue;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(bool value) {
                
                #line 196 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                              IsCaseContinue = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 219 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          ProcessingIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr15Get() {
                
                #line 219 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          ProcessingIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(double value) {
                
                #line 219 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                          ProcessingIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 231 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr17Get() {
                
                #line 231 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          Tax;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(double value) {
                
                #line 231 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                          Tax = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 254 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              ProcessingIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr20Get() {
                
                #line 254 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              ProcessingIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr20Set(double value) {
                
                #line 254 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                              ProcessingIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr20Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr20Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 266 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr22Get() {
                
                #line 266 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              Tax;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr22Set(double value) {
                
                #line 266 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                              Tax = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr22Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr22Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 278 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              IsCaseContinue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr23Get() {
                
                #line 278 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              IsCaseContinue;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr23Set(bool value) {
                
                #line 278 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                              IsCaseContinue = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr23Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr23Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 301 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          ProcessingIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr26Get() {
                
                #line 301 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          ProcessingIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(double value) {
                
                #line 301 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                          ProcessingIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 313 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr28Get() {
                
                #line 313 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          Tax;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr28Set(double value) {
                
                #line 313 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                          Tax = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr28Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr28Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 336 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              ProcessingIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr31Get() {
                
                #line 336 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              ProcessingIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr31Set(double value) {
                
                #line 336 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                              ProcessingIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr31Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr31Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 348 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr33Get() {
                
                #line 348 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              Tax;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(double value) {
                
                #line 348 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                              Tax = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr33Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr33Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 360 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              IsCaseContinue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr34Get() {
                
                #line 360 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              IsCaseContinue;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr34Set(bool value) {
                
                #line 360 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                              IsCaseContinue = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr34Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr34Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 383 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          ProcessingIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr37Get() {
                
                #line 383 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          ProcessingIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr37Set(double value) {
                
                #line 383 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                          ProcessingIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr37Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr37Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 395 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr39Get() {
                
                #line 395 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          Tax;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr39Set(double value) {
                
                #line 395 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                          Tax = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr39Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr39Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 418 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              ProcessingIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr42Get() {
                
                #line 418 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              ProcessingIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr42Set(double value) {
                
                #line 418 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                              ProcessingIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr42Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr42Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 430 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr44Get() {
                
                #line 430 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              Tax;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr44Set(double value) {
                
                #line 430 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                              Tax = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr44Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr44Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 442 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              IsCaseContinue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr45Get() {
                
                #line 442 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              IsCaseContinue;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr45Set(bool value) {
                
                #line 442 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                              IsCaseContinue = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr45Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr45Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 465 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          ProcessingIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr48Get() {
                
                #line 465 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          ProcessingIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr48Set(double value) {
                
                #line 465 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                          ProcessingIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr48Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr48Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 477 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr50Get() {
                
                #line 477 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          Tax;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr50Set(double value) {
                
                #line 477 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                          Tax = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr50Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr50Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 500 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              ProcessingIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr53Get() {
                
                #line 500 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              ProcessingIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr53Set(double value) {
                
                #line 500 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                              ProcessingIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr53Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr53Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 512 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr55Get() {
                
                #line 512 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              Tax;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr55Set(double value) {
                
                #line 512 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                              Tax = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr55Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr55Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 524 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              IsCaseContinue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr56Get() {
                
                #line 524 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              IsCaseContinue;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr56Set(bool value) {
                
                #line 524 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                              IsCaseContinue = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr56Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr56Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 547 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          ProcessingIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr59Get() {
                
                #line 547 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          ProcessingIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr59Set(double value) {
                
                #line 547 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                          ProcessingIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr59Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr59Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 559 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr61Get() {
                
                #line 559 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          Tax;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr61Set(double value) {
                
                #line 559 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                          Tax = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr61Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr61Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 582 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              ProcessingIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr64Get() {
                
                #line 582 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              ProcessingIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr64Set(double value) {
                
                #line 582 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                              ProcessingIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr64Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr64Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 594 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr66Get() {
                
                #line 594 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              Tax;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr66Set(double value) {
                
                #line 594 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                              Tax = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr66Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr66Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 606 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              IsCaseContinue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr67Get() {
                
                #line 606 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              IsCaseContinue;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr67Set(bool value) {
                
                #line 606 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                              IsCaseContinue = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr67Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr67Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 629 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          ProcessingIncome;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr70Get() {
                
                #line 629 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          ProcessingIncome;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr70Set(double value) {
                
                #line 629 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                          ProcessingIncome = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr70Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr70Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 641 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr72Get() {
                
                #line 641 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          Tax;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr72Set(double value) {
                
                #line 641 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                
                          Tax = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr72Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr72Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.SingleRange1Start = ((double)(this.GetVariableValue((14 + locationsOffset))));
                this.SingleRange7Start = ((double)(this.GetVariableValue((15 + locationsOffset))));
                this.SingleRange6End = ((double)(this.GetVariableValue((16 + locationsOffset))));
                this.SingleRange6Start = ((double)(this.GetVariableValue((17 + locationsOffset))));
                this.SingleRange5End = ((double)(this.GetVariableValue((18 + locationsOffset))));
                this.SingleRange5Start = ((double)(this.GetVariableValue((19 + locationsOffset))));
                this.SingleRange4Start = ((double)(this.GetVariableValue((20 + locationsOffset))));
                this.SingleRange4End = ((double)(this.GetVariableValue((21 + locationsOffset))));
                this.SingleRange1End = ((double)(this.GetVariableValue((22 + locationsOffset))));
                this.SingleRange2Start = ((double)(this.GetVariableValue((23 + locationsOffset))));
                this.SingleRange3Start = ((double)(this.GetVariableValue((24 + locationsOffset))));
                this.SingleRange3End = ((double)(this.GetVariableValue((25 + locationsOffset))));
                this.SingleRange2End = ((double)(this.GetVariableValue((26 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((14 + locationsOffset), this.SingleRange1Start);
                this.SetVariableValue((15 + locationsOffset), this.SingleRange7Start);
                this.SetVariableValue((16 + locationsOffset), this.SingleRange6End);
                this.SetVariableValue((17 + locationsOffset), this.SingleRange6Start);
                this.SetVariableValue((18 + locationsOffset), this.SingleRange5End);
                this.SetVariableValue((19 + locationsOffset), this.SingleRange5Start);
                this.SetVariableValue((20 + locationsOffset), this.SingleRange4Start);
                this.SetVariableValue((21 + locationsOffset), this.SingleRange4End);
                this.SetVariableValue((22 + locationsOffset), this.SingleRange1End);
                this.SetVariableValue((23 + locationsOffset), this.SingleRange2Start);
                this.SetVariableValue((24 + locationsOffset), this.SingleRange3Start);
                this.SetVariableValue((25 + locationsOffset), this.SingleRange3End);
                this.SetVariableValue((26 + locationsOffset), this.SingleRange2End);
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
                if (((locationReferences[(offset + 27)].Name != "variable2") 
                            || (locationReferences[(offset + 27)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "SingleRange1Start") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "SingleRange7Start") 
                            || (locationReferences[(offset + 15)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "SingleRange6End") 
                            || (locationReferences[(offset + 16)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "SingleRange6Start") 
                            || (locationReferences[(offset + 17)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 18)].Name != "SingleRange5End") 
                            || (locationReferences[(offset + 18)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "SingleRange5Start") 
                            || (locationReferences[(offset + 19)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "SingleRange4Start") 
                            || (locationReferences[(offset + 20)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "SingleRange4End") 
                            || (locationReferences[(offset + 21)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "SingleRange1End") 
                            || (locationReferences[(offset + 22)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "SingleRange2Start") 
                            || (locationReferences[(offset + 23)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 24)].Name != "SingleRange3Start") 
                            || (locationReferences[(offset + 24)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 25)].Name != "SingleRange3End") 
                            || (locationReferences[(offset + 25)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 26)].Name != "SingleRange2End") 
                            || (locationReferences[(offset + 26)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZTaxAmountCalculation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly : F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly {
            
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
            
            public F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public F1040EZTaxAmountCalculation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string variable2 {
                get {
                    return ((string)(this.GetVariableValue((27 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 133 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome>0.0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr3Get() {
                
                #line 133 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome>0.0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 141 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange1End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr4Get() {
                
                #line 141 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange1End;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 154 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          SingleRange1End - SingleRange1Start;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr5Get() {
                
                #line 154 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          SingleRange1End - SingleRange1Start;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 166 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax + (ProcessingIncome * Range1TaxRate);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr7Get() {
                
                #line 166 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          Tax + (ProcessingIncome * Range1TaxRate);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 176 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange1End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr9Get() {
                
                #line 176 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange1End;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 189 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax + (ProcessingIncome * Range1TaxRate);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr10Get() {
                
                #line 189 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              Tax + (ProcessingIncome * Range1TaxRate);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 211 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange2End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr13Get() {
                
                #line 211 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange2End;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 224 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          SingleRange2End - SingleRange1End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr14Get() {
                
                #line 224 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          SingleRange2End - SingleRange1End;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 236 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax + (ProcessingIncome * Range2TaxRate);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr16Get() {
                
                #line 236 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          Tax + (ProcessingIncome * Range2TaxRate);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 246 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange2End && IsCaseContinue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr18Get() {
                
                #line 246 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange2End && IsCaseContinue;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 259 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange1End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr19Get() {
                
                #line 259 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange1End;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 271 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax + (ProcessingIncome * Range2TaxRate);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr21Get() {
                
                #line 271 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              Tax + (ProcessingIncome * Range2TaxRate);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 293 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange3End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr24Get() {
                
                #line 293 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange3End;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 306 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          SingleRange3End - SingleRange2End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr25Get() {
                
                #line 306 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          SingleRange3End - SingleRange2End;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 318 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax + (ProcessingIncome * Range3TaxRate);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr27Get() {
                
                #line 318 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          Tax + (ProcessingIncome * Range3TaxRate);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 328 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange3End && IsCaseContinue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr29Get() {
                
                #line 328 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange3End && IsCaseContinue;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 341 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange2End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr30Get() {
                
                #line 341 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange2End;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 353 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax + (ProcessingIncome * Range3TaxRate);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr32Get() {
                
                #line 353 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              Tax + (ProcessingIncome * Range3TaxRate);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 375 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange4End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr35Get() {
                
                #line 375 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange4End;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 388 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          SingleRange4End - SingleRange3End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr36Get() {
                
                #line 388 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          SingleRange4End - SingleRange3End;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 400 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax + (ProcessingIncome * Range4TaxRate);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr38Get() {
                
                #line 400 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          Tax + (ProcessingIncome * Range4TaxRate);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 410 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange4End && IsCaseContinue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr40Get() {
                
                #line 410 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange4End && IsCaseContinue;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 423 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange3End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr41Get() {
                
                #line 423 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange3End;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 435 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax + (ProcessingIncome * Range4TaxRate);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr43Get() {
                
                #line 435 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              Tax + (ProcessingIncome * Range4TaxRate);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 457 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange5End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr46Get() {
                
                #line 457 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange5End;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 470 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          SingleRange5End - SingleRange4End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr47Get() {
                
                #line 470 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          SingleRange5End - SingleRange4End;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 482 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax + (ProcessingIncome * Range5TaxRate);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr49Get() {
                
                #line 482 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          Tax + (ProcessingIncome * Range5TaxRate);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 492 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange5End && IsCaseContinue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr51Get() {
                
                #line 492 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange5End && IsCaseContinue;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 505 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange4End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr52Get() {
                
                #line 505 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange4End;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 517 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax + (ProcessingIncome * Range5TaxRate);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr54Get() {
                
                #line 517 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              Tax + (ProcessingIncome * Range5TaxRate);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 539 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange6End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr57Get() {
                
                #line 539 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome > SingleRange6End;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 552 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          SingleRange6End - SingleRange5End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr58Get() {
                
                #line 552 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          SingleRange6End - SingleRange5End;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 564 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax + (ProcessingIncome * Range6TaxRate);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr60Get() {
                
                #line 564 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          Tax + (ProcessingIncome * Range6TaxRate);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 574 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange6End && IsCaseContinue;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr62Get() {
                
                #line 574 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                        Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome <= SingleRange6End && IsCaseContinue;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 587 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange5End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr63Get() {
                
                #line 587 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange5End;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 599 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax + (ProcessingIncome * Range6TaxRate);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr65Get() {
                
                #line 599 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                              Tax + (ProcessingIncome * Range6TaxRate);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 621 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome >= SingleRange7Start;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr68Get() {
                
                #line 621 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome >= SingleRange7Start;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 634 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange6End;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr69Get() {
                
                #line 634 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          Tax1040Object.OutputForms.Tax1040EZPage1.TaxableIncome - SingleRange6End;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 646 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax + (ProcessingIncome * Range7TaxRate);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr71Get() {
                
                #line 646 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\F1040EZTAXAMOUNTCALCULATION.XAML"
                return 
                          Tax + (ProcessingIncome * Range7TaxRate);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            protected override void GetValueTypeValues() {
                this.SingleRange1Start = ((double)(this.GetVariableValue((14 + locationsOffset))));
                this.SingleRange7Start = ((double)(this.GetVariableValue((15 + locationsOffset))));
                this.SingleRange6End = ((double)(this.GetVariableValue((16 + locationsOffset))));
                this.SingleRange6Start = ((double)(this.GetVariableValue((17 + locationsOffset))));
                this.SingleRange5End = ((double)(this.GetVariableValue((18 + locationsOffset))));
                this.SingleRange5Start = ((double)(this.GetVariableValue((19 + locationsOffset))));
                this.SingleRange4Start = ((double)(this.GetVariableValue((20 + locationsOffset))));
                this.SingleRange4End = ((double)(this.GetVariableValue((21 + locationsOffset))));
                this.SingleRange1End = ((double)(this.GetVariableValue((22 + locationsOffset))));
                this.SingleRange2Start = ((double)(this.GetVariableValue((23 + locationsOffset))));
                this.SingleRange3Start = ((double)(this.GetVariableValue((24 + locationsOffset))));
                this.SingleRange3End = ((double)(this.GetVariableValue((25 + locationsOffset))));
                this.SingleRange2End = ((double)(this.GetVariableValue((26 + locationsOffset))));
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
                if (((locationReferences[(offset + 27)].Name != "variable2") 
                            || (locationReferences[(offset + 27)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "SingleRange1Start") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "SingleRange7Start") 
                            || (locationReferences[(offset + 15)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "SingleRange6End") 
                            || (locationReferences[(offset + 16)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "SingleRange6Start") 
                            || (locationReferences[(offset + 17)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 18)].Name != "SingleRange5End") 
                            || (locationReferences[(offset + 18)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "SingleRange5Start") 
                            || (locationReferences[(offset + 19)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "SingleRange4Start") 
                            || (locationReferences[(offset + 20)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "SingleRange4End") 
                            || (locationReferences[(offset + 21)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "SingleRange1End") 
                            || (locationReferences[(offset + 22)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "SingleRange2Start") 
                            || (locationReferences[(offset + 23)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 24)].Name != "SingleRange3Start") 
                            || (locationReferences[(offset + 24)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 25)].Name != "SingleRange3End") 
                            || (locationReferences[(offset + 25)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 26)].Name != "SingleRange2End") 
                            || (locationReferences[(offset + 26)].Type != typeof(double)))) {
                    return false;
                }
                return F1040EZTaxAmountCalculation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
