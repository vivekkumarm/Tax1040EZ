namespace JTL.Tax1040.BusinessLogic.WorkFlow.Activities.CalculationWithNoValidation {
    
    #line 22 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\Form1040EZSSBEligibilityWithNoValidation.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\Form1040EZSSBEligibilityWithNoValidation.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 23 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\Form1040EZSSBEligibilityWithNoValidation.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\Form1040EZSSBEligibilityWithNoValidation.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\Form1040EZSSBEligibilityWithNoValidation.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\Form1040EZSSBEligibilityWithNoValidation.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 24 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\Form1040EZSSBEligibilityWithNoValidation.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 25 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\Form1040EZSSBEligibilityWithNoValidation.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 26 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\Form1040EZSSBEligibilityWithNoValidation.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 27 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\Form1040EZSSBEligibilityWithNoValidation.xaml"
    using JTL.Tax1040.BusinessObject;
    
    #line default
    #line hidden
    
    #line 28 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\Form1040EZSSBEligibilityWithNoValidation.xaml"
    using JTL.Tax1040.Core.Object;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\CalculationWithNoValidation\Form1040EZSSBEligibilityWithNoValidation.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class Form1040EZSSBEligibilityWithNoValidation : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext0 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext1 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext2 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext3 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext4 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext5 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext6 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext7 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext7.GetLocation<double>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext8 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext9 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext10 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext10.GetLocation<double>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly valDataContext11 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly valDataContext12 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly valDataContext13 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly valDataContext14 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly valDataContext15 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3 refDataContext16 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext16.GetLocation<double>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly valDataContext17 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly valDataContext18 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3 refDataContext19 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext19.GetLocation<double>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext20 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext21 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext22 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext22.GetLocation<JTL.Tax1040.BusinessObject.F1040EZ>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext23 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext24 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext24.GetLocation<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext25 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext26 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext26.GetLocation<JTL.Tax1040.BusinessObject.SSBWorkSheet>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext27 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext28 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext29 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext29.GetLocation<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext30 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext31 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext31.GetLocation<JTL.Tax1040.BusinessObject.SSBWorkSheet>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext32 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext33 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext34 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext34.GetLocation<JTL.Tax1040.BusinessObject.SSBWorkSheet>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly valDataContext35 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext36 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext36.GetLocation<double>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly valDataContext37 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext38 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext38.GetLocation<bool>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly valDataContext39 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext40 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext40.GetLocation<double>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext41 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext41.GetLocation<bool>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext42 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext42.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext43 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext43.GetLocation<double>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext44 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext44.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext45 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext45.GetLocation<double>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext46 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext46.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext46.ValueType___Expr46Get, refDataContext46.ValueType___Expr46Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext47 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext47.GetLocation<double>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly valDataContext48 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext49 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext49.GetLocation<double>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5 refDataContext50 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext50.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5 refDataContext51 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext51.GetLocation<double>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5 refDataContext52 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext52.GetLocation<double>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5 refDataContext53 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext53.GetLocation<double>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5 refDataContext54 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext54.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5 refDataContext55 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext55.GetLocation<double>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly valDataContext56 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5 refDataContext57 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext57.GetLocation<double>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly valDataContext58 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5 refDataContext59 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext59.GetLocation<double>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly valDataContext60 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext61 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext61.GetLocation<double>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly valDataContext62 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext63 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext63.GetLocation<double>(refDataContext63.ValueType___Expr63Get, refDataContext63.ValueType___Expr63Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly valDataContext64 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext65 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext65.GetLocation<double>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext66 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext67 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext68 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext69 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext70 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext70.GetLocation<double>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext71 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext72 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext72.GetLocation<bool>(refDataContext72.ValueType___Expr72Get, refDataContext72.ValueType___Expr72Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext73 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext73.GetLocation<bool>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext74 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext75 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext75.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 76)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext76 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext77 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext78 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext79 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext79.GetLocation<double>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 80)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext80 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext81 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext81.GetLocation<bool>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 82)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext82 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext82.GetLocation<bool>(refDataContext82.ValueType___Expr82Get, refDataContext82.ValueType___Expr82Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 83)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext83 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext84 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext84.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 85)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext85 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext86 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext86.ValueType___Expr86Get();
            }
            if ((expressionId == 87)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext87 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext88 = ((Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext88.GetLocation<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>(refDataContext88.ValueType___Expr88Get, refDataContext88.ValueType___Expr88Set, expressionId, this.rootActivity, activityContext);
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
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext0 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext1 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext2 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext3 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext4 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext5 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext6 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext7 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext7.GetLocation<double>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext8 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext9 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext10 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext10.GetLocation<double>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly valDataContext11 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly valDataContext12 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly valDataContext13 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly valDataContext14 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly valDataContext15 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3 refDataContext16 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3(locations, true);
                return refDataContext16.GetLocation<double>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            if ((expressionId == 17)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly valDataContext17 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly valDataContext18 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3 refDataContext19 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3(locations, true);
                return refDataContext19.GetLocation<double>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            if ((expressionId == 20)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext20 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext21 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext22 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext22.GetLocation<JTL.Tax1040.BusinessObject.F1040EZ>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set);
            }
            if ((expressionId == 23)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext23 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext24 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext24.GetLocation<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set);
            }
            if ((expressionId == 25)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext25 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext26 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext26.GetLocation<JTL.Tax1040.BusinessObject.SSBWorkSheet>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext27 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext28 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext29 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext29.GetLocation<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
            }
            if ((expressionId == 30)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext30 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext31 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext31.GetLocation<JTL.Tax1040.BusinessObject.SSBWorkSheet>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set);
            }
            if ((expressionId == 32)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext32 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext33 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext34 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext34.GetLocation<JTL.Tax1040.BusinessObject.SSBWorkSheet>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set);
            }
            if ((expressionId == 35)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly valDataContext35 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext36 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext36.GetLocation<double>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set);
            }
            if ((expressionId == 37)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly valDataContext37 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext38 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext38.GetLocation<bool>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set);
            }
            if ((expressionId == 39)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly valDataContext39 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext40 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext40.GetLocation<double>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set);
            }
            if ((expressionId == 41)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext41 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext41.GetLocation<bool>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set);
            }
            if ((expressionId == 42)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext42 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext42.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set);
            }
            if ((expressionId == 43)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext43 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext43.GetLocation<double>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set);
            }
            if ((expressionId == 44)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext44 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext44.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set);
            }
            if ((expressionId == 45)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext45 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext45.GetLocation<double>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set);
            }
            if ((expressionId == 46)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext46 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext46.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext46.ValueType___Expr46Get, refDataContext46.ValueType___Expr46Set);
            }
            if ((expressionId == 47)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext47 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext47.GetLocation<double>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set);
            }
            if ((expressionId == 48)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly valDataContext48 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext49 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext49.GetLocation<double>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set);
            }
            if ((expressionId == 50)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5 refDataContext50 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext50.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set);
            }
            if ((expressionId == 51)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5 refDataContext51 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext51.GetLocation<double>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set);
            }
            if ((expressionId == 52)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5 refDataContext52 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext52.GetLocation<double>(refDataContext52.ValueType___Expr52Get, refDataContext52.ValueType___Expr52Set);
            }
            if ((expressionId == 53)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5 refDataContext53 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext53.GetLocation<double>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set);
            }
            if ((expressionId == 54)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5 refDataContext54 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext54.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set);
            }
            if ((expressionId == 55)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5 refDataContext55 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext55.GetLocation<double>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set);
            }
            if ((expressionId == 56)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly valDataContext56 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5 refDataContext57 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext57.GetLocation<double>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set);
            }
            if ((expressionId == 58)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly valDataContext58 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5 refDataContext59 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locations, true);
                return refDataContext59.GetLocation<double>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set);
            }
            if ((expressionId == 60)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly valDataContext60 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext61 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext61.GetLocation<double>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set);
            }
            if ((expressionId == 62)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly valDataContext62 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext63 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext63.GetLocation<double>(refDataContext63.ValueType___Expr63Get, refDataContext63.ValueType___Expr63Set);
            }
            if ((expressionId == 64)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly valDataContext64 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 refDataContext65 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locations, true);
                return refDataContext65.GetLocation<double>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set);
            }
            if ((expressionId == 66)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext66 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext67 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext68 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext69 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext70 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext70.GetLocation<double>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set);
            }
            if ((expressionId == 71)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext71 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext72 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext72.GetLocation<bool>(refDataContext72.ValueType___Expr72Get, refDataContext72.ValueType___Expr72Set);
            }
            if ((expressionId == 73)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext73 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext73.GetLocation<bool>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set);
            }
            if ((expressionId == 74)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext74 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext75 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext75.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set);
            }
            if ((expressionId == 76)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext76 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext77 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext78 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext79 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext79.GetLocation<double>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set);
            }
            if ((expressionId == 80)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext80 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext81 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext81.GetLocation<bool>(refDataContext81.ValueType___Expr81Get, refDataContext81.ValueType___Expr81Set);
            }
            if ((expressionId == 82)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext82 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext82.GetLocation<bool>(refDataContext82.ValueType___Expr82Get, refDataContext82.ValueType___Expr82Set);
            }
            if ((expressionId == 83)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext83 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext84 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext84.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set);
            }
            if ((expressionId == 85)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext85 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext86 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext86.ValueType___Expr86Get();
            }
            if ((expressionId == 87)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly valDataContext87 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 refDataContext88 = new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locations, true);
                return refDataContext88.GetLocation<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>(refDataContext88.ValueType___Expr88Get, refDataContext88.ValueType___Expr88Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.ErrorMessages") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object != null && Tax1040Object.Income!=null && Tax1040Object.Income.Other" +
                            "Income !=null") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.Income.OtherIncome.SSB != null)") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.Primary" +
                            "TaxPayer != null)") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits !=null") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.HasValue ? Tax1040Object" +
                            ".Income.OtherIncome.SSB.TaxpayerNetBenefits.Value:0") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "SSA") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits != null || Tax1040Object" +
                            ".Income.OtherIncome.SSB.SpouseNetBenefits !=null") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"(Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.Value:0 )+ (Tax1040Object.Income.OtherIncome.SSB.SpouseNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.SSB.SpouseNetBenefits.Value:0)") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "SSA") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.Income.OtherIncome.RRB != null)") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.Primary" +
                            "TaxPayer != null)") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits !=null") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.HasValue ? Tax1040Object" +
                            ".Income.OtherIncome.RRB.TaxpayerNetBenefits.Value:0") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RRB") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits != null || Tax1040Object" +
                            ".Income.OtherIncome.RRB.SpouseNetBenefits !=null") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"(Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.Value:0 )+( Tax1040Object.Income.OtherIncome.RRB.SpouseNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.RRB.SpouseNetBenefits.Value:0)") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RRB") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.F1040EZ==null)") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new F1040EZ()") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new F1040EZWorkSheets()") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new SSBWorkSheet()") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.F1040EZ.F1040EZWorkSheets==null)") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new F1040EZWorkSheets()") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new SSBWorkSheet()") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet==null)") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new SSBWorkSheet()") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(SSA)+Math.Round(RRB)") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount > 0)") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine2SSBTaxable") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount/2") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line2Amount") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine2SSBTaxable") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalWages") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "UnEmployment") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Alaska") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "UnEmployment+Alaska") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalUnemployment") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TaxableExcemptInterestINT") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "F1099INTAmount") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TaxableExcemptInterestOID") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "F1099OIDAmount") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "F1099OIDAmount + F1099INTAmount") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TaxableInterest") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TaxableExcemptInterestINT + TaxableExcemptInterestOID") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TaxableExcemptInterest") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TotalWages + TotalUnemployment") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line3Amount") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TaxableInterest + TaxableExcemptInterest") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line4Amount") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line2Amount+Tax1040Object.F1" +
                            "040EZ.F1040EZWorkSheets.SSBWorkSheet.Line3Amount + Tax1040Object.F1040EZ.F1040EZ" +
                            "WorkSheets.SSBWorkSheet.Line4Amount") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails !=null") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer !=null") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "SingleLimit") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line6Amount") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount <= SingleLimit") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.OTHERINCOME_TAXABLE_SOCIAL_SECURITY_AND_RAILROAD_BENEFITS" +
                            "]") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 75;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 76;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 77;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "MFJLimit") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 78;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line6Amount") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 79;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount <= MFJLimit") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 80;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 81;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 82;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.OTHERINCOME_TAXABLE_SOCIAL_SECURITY_AND_RAILROAD_BENEFITS" +
                            "]") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 83;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 84;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 85;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 86;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 87;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.ErrorMessages") 
                        && (Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 88;
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
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr74GetTree();
            }
            if ((expressionId == 75)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locationReferences).@__Expr75GetTree();
            }
            if ((expressionId == 76)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr76GetTree();
            }
            if ((expressionId == 77)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr77GetTree();
            }
            if ((expressionId == 78)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr78GetTree();
            }
            if ((expressionId == 79)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locationReferences).@__Expr79GetTree();
            }
            if ((expressionId == 80)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr80GetTree();
            }
            if ((expressionId == 81)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locationReferences).@__Expr81GetTree();
            }
            if ((expressionId == 82)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locationReferences).@__Expr82GetTree();
            }
            if ((expressionId == 83)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr83GetTree();
            }
            if ((expressionId == 84)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locationReferences).@__Expr84GetTree();
            }
            if ((expressionId == 85)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr85GetTree();
            }
            if ((expressionId == 86)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr86GetTree();
            }
            if ((expressionId == 87)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(locationReferences).@__Expr87GetTree();
            }
            if ((expressionId == 88)) {
                return new Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(locationReferences).@__Expr88GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZSSBEligibilityWithNoValidation_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class Form1040EZSSBEligibilityWithNoValidation_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class Form1040EZSSBEligibilityWithNoValidation_TypedDataContext1 : Form1040EZSSBEligibilityWithNoValidation_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                return Form1040EZSSBEligibilityWithNoValidation_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZSSBEligibilityWithNoValidation_TypedDataContext1_ForReadOnly : Form1040EZSSBEligibilityWithNoValidation_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                return Form1040EZSSBEligibilityWithNoValidation_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 : Form1040EZSSBEligibilityWithNoValidation_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double SSA;
            
            protected double RRB;
            
            protected double SingleLimit;
            
            protected double MFJLimit;
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 113 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    SSA;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr7Get() {
                
                #line 113 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                    SSA;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(double value) {
                
                #line 113 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                                    SSA = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 136 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    SSA;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr10Get() {
                
                #line 136 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                    SSA;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(double value) {
                
                #line 136 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                                    SSA = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 248 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZ>> expression = () => 
                          Tax1040Object.F1040EZ;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZ @__Expr22Get() {
                
                #line 248 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.F1040EZ;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZ ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr22Set(JTL.Tax1040.BusinessObject.F1040EZ value) {
                
                #line 248 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                          Tax1040Object.F1040EZ = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr22Set(JTL.Tax1040.BusinessObject.F1040EZ value) {
                this.GetValueTypeValues();
                this.@__Expr22Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 260 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>> expression = () => 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets @__Expr24Get() {
                
                #line 260 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr24Set(JTL.Tax1040.BusinessObject.F1040EZWorkSheets value) {
                
                #line 260 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                          Tax1040Object.F1040EZ.F1040EZWorkSheets = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr24Set(JTL.Tax1040.BusinessObject.F1040EZWorkSheets value) {
                this.GetValueTypeValues();
                this.@__Expr24Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 272 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.SSBWorkSheet>> expression = () => 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.SSBWorkSheet @__Expr26Get() {
                
                #line 272 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.SSBWorkSheet ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(JTL.Tax1040.BusinessObject.SSBWorkSheet value) {
                
                #line 272 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(JTL.Tax1040.BusinessObject.SSBWorkSheet value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 295 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets @__Expr29Get() {
                
                #line 295 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr29Set(JTL.Tax1040.BusinessObject.F1040EZWorkSheets value) {
                
                #line 295 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.F1040EZ.F1040EZWorkSheets = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(JTL.Tax1040.BusinessObject.F1040EZWorkSheets value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 307 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.SSBWorkSheet>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.SSBWorkSheet @__Expr31Get() {
                
                #line 307 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.SSBWorkSheet ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr31Set(JTL.Tax1040.BusinessObject.SSBWorkSheet value) {
                
                #line 307 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr31Set(JTL.Tax1040.BusinessObject.SSBWorkSheet value) {
                this.GetValueTypeValues();
                this.@__Expr31Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 329 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.SSBWorkSheet>> expression = () => 
                                Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.SSBWorkSheet @__Expr34Get() {
                
                #line 329 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.SSBWorkSheet ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr34Set(JTL.Tax1040.BusinessObject.SSBWorkSheet value) {
                
                #line 329 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                                Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr34Set(JTL.Tax1040.BusinessObject.SSBWorkSheet value) {
                this.GetValueTypeValues();
                this.@__Expr34Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 592 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line6Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr70Get() {
                
                #line 592 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line6Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr70Set(double value) {
                
                #line 592 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line6Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr70Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr70Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 611 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr72Get() {
                
                #line 611 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr72Set(bool value) {
                
                #line 611 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr72Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr72Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 624 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr73Get() {
                
                #line 624 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr73Set(bool value) {
                
                #line 624 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr73Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr73Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr75GetTree() {
                
                #line 635 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr75Get() {
                
                #line 635 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
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
                
                #line 635 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                                      ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr75Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr75Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr79GetTree() {
                
                #line 663 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line6Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr79Get() {
                
                #line 663 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line6Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr79Get() {
                this.GetValueTypeValues();
                return this.@__Expr79Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr79Set(double value) {
                
                #line 663 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line6Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr79Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr79Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr81GetTree() {
                
                #line 682 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr81Get() {
                
                #line 682 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr81Get() {
                this.GetValueTypeValues();
                return this.@__Expr81Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr81Set(bool value) {
                
                #line 682 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr81Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr81Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr82GetTree() {
                
                #line 695 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr82Get() {
                
                #line 695 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr82Get() {
                this.GetValueTypeValues();
                return this.@__Expr82Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr82Set(bool value) {
                
                #line 695 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr82Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr82Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr84GetTree() {
                
                #line 706 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr84Get() {
                
                #line 706 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
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
                
                #line 706 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                                      ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr84Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr84Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr88GetTree() {
                
                #line 741 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                  Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr88Get() {
                
                #line 741 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                  Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr88Get() {
                this.GetValueTypeValues();
                return this.@__Expr88Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr88Set(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> value) {
                
                #line 741 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                  Tax1040Object.ErrorMessages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr88Set(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> value) {
                this.GetValueTypeValues();
                this.@__Expr88Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.SSA = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.RRB = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.SingleLimit = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.MFJLimit = ((double)(this.GetVariableValue((7 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((4 + locationsOffset), this.SSA);
                this.SetVariableValue((5 + locationsOffset), this.RRB);
                this.SetVariableValue((6 + locationsOffset), this.SingleLimit);
                this.SetVariableValue((7 + locationsOffset), this.MFJLimit);
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
                if (((locationReferences[(offset + 2)].Name != "ErrorMessage") 
                            || (locationReferences[(offset + 2)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessage)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "ErrorMessageList") 
                            || (locationReferences[(offset + 3)].Type != typeof(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "SSA") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "RRB") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "SingleLimit") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "MFJLimit") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                return Form1040EZSSBEligibilityWithNoValidation_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly : Form1040EZSSBEligibilityWithNoValidation_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double SSA;
            
            protected double RRB;
            
            protected double SingleLimit;
            
            protected double MFJLimit;
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 64 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
          Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr0Get() {
                
                #line 64 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
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
                
                #line 75 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          Tax1040Object != null && Tax1040Object.Income!=null && Tax1040Object.Income.OtherIncome !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr1Get() {
                
                #line 75 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
          Tax1040Object != null && Tax1040Object.Income!=null && Tax1040Object.Income.OtherIncome !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 85 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    (Tax1040Object.Income.OtherIncome.SSB != null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr2Get() {
                
                #line 85 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                    (Tax1040Object.Income.OtherIncome.SSB != null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 92 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        (Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.PrimaryTaxPayer != null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr3Get() {
                
                #line 92 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                        (Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.PrimaryTaxPayer != null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 99 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.FilingStatus>> expression = () => 
                            Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.FilingStatus @__Expr4Get() {
                
                #line 99 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.FilingStatus ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 106 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr5Get() {
                
                #line 106 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 118 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.Value:0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr6Get() {
                
                #line 118 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                    Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.Value:0;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 129 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits != null || Tax1040Object.Income.OtherIncome.SSB.SpouseNetBenefits !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr8Get() {
                
                #line 129 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits != null || Tax1040Object.Income.OtherIncome.SSB.SpouseNetBenefits !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 141 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    (Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.Value:0 )+ (Tax1040Object.Income.OtherIncome.SSB.SpouseNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.SSB.SpouseNetBenefits.Value:0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr9Get() {
                
                #line 141 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                    (Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.Value:0 )+ (Tax1040Object.Income.OtherIncome.SSB.SpouseNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.SSB.SpouseNetBenefits.Value:0);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    (Tax1040Object.F1040EZ==null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr20Get() {
                
                #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                    (Tax1040Object.F1040EZ==null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 253 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZ>> expression = () => 
                          new F1040EZ();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZ @__Expr21Get() {
                
                #line 253 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                          new F1040EZ();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZ ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 265 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>> expression = () => 
                          new F1040EZWorkSheets();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets @__Expr23Get() {
                
                #line 265 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                          new F1040EZWorkSheets();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 277 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.SSBWorkSheet>> expression = () => 
                          new SSBWorkSheet();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.SSBWorkSheet @__Expr25Get() {
                
                #line 277 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                          new SSBWorkSheet();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.SSBWorkSheet ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 287 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        (Tax1040Object.F1040EZ.F1040EZWorkSheets==null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr27Get() {
                
                #line 287 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                        (Tax1040Object.F1040EZ.F1040EZWorkSheets==null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 300 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>> expression = () => 
                              new F1040EZWorkSheets();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets @__Expr28Get() {
                
                #line 300 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                              new F1040EZWorkSheets();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 312 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.SSBWorkSheet>> expression = () => 
                              new SSBWorkSheet();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.SSBWorkSheet @__Expr30Get() {
                
                #line 312 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                              new SSBWorkSheet();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.SSBWorkSheet ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 322 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            (Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet==null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr32Get() {
                
                #line 322 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                            (Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet==null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 334 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.SSBWorkSheet>> expression = () => 
                                new SSBWorkSheet();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.SSBWorkSheet @__Expr33Get() {
                
                #line 334 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                new SSBWorkSheet();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.SSBWorkSheet ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 571 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  Tax1040Object.PersonalDetails !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr66Get() {
                
                #line 571 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                  Tax1040Object.PersonalDetails !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 578 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.PersonalDetails.PrimaryTaxPayer !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr67Get() {
                
                #line 578 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                      Tax1040Object.PersonalDetails.PrimaryTaxPayer !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 585 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.FilingStatus>> expression = () => 
                          Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.FilingStatus @__Expr68Get() {
                
                #line 585 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.FilingStatus ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 597 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              SingleLimit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr69Get() {
                
                #line 597 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                              SingleLimit;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 604 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount <= SingleLimit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr71Get() {
                
                #line 604 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount <= SingleLimit;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 640 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessages[Constants.OTHERINCOME_TAXABLE_SOCIAL_SECURITY_AND_RAILROAD_BENEFITS];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr74Get() {
                
                #line 640 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                      ErrorMessages[Constants.OTHERINCOME_TAXABLE_SOCIAL_SECURITY_AND_RAILROAD_BENEFITS];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr76GetTree() {
                
                #line 651 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                    ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr76Get() {
                
                #line 651 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
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
                
                #line 647 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr77Get() {
                
                #line 647 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
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
                
                #line 668 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              MFJLimit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr78Get() {
                
                #line 668 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                              MFJLimit;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr78Get() {
                this.GetValueTypeValues();
                return this.@__Expr78Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr80GetTree() {
                
                #line 675 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount <= MFJLimit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr80Get() {
                
                #line 675 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount <= MFJLimit;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr80Get() {
                this.GetValueTypeValues();
                return this.@__Expr80Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr83GetTree() {
                
                #line 711 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessages[Constants.OTHERINCOME_TAXABLE_SOCIAL_SECURITY_AND_RAILROAD_BENEFITS];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr83Get() {
                
                #line 711 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                      ErrorMessages[Constants.OTHERINCOME_TAXABLE_SOCIAL_SECURITY_AND_RAILROAD_BENEFITS];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr83Get() {
                this.GetValueTypeValues();
                return this.@__Expr83Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr85GetTree() {
                
                #line 722 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                    ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr85Get() {
                
                #line 722 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
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
                
                #line 718 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr86Get() {
                
                #line 718 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                      ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr86Get() {
                this.GetValueTypeValues();
                return this.@__Expr86Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr87GetTree() {
                
                #line 746 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                  ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr87Get() {
                
                #line 746 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                  ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr87Get() {
                this.GetValueTypeValues();
                return this.@__Expr87Get();
            }
            
            protected override void GetValueTypeValues() {
                this.SSA = ((double)(this.GetVariableValue((4 + locationsOffset))));
                this.RRB = ((double)(this.GetVariableValue((5 + locationsOffset))));
                this.SingleLimit = ((double)(this.GetVariableValue((6 + locationsOffset))));
                this.MFJLimit = ((double)(this.GetVariableValue((7 + locationsOffset))));
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
                if (((locationReferences[(offset + 2)].Name != "ErrorMessage") 
                            || (locationReferences[(offset + 2)].Type != typeof(JTL.Tax1040.Core.Object.ErrorMessage)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "ErrorMessageList") 
                            || (locationReferences[(offset + 3)].Type != typeof(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "SSA") 
                            || (locationReferences[(offset + 4)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "RRB") 
                            || (locationReferences[(offset + 5)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "SingleLimit") 
                            || (locationReferences[(offset + 6)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "MFJLimit") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                return Form1040EZSSBEligibilityWithNoValidation_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3 : Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.RailroadRetirementIncome RailRoadBenefit {
                get {
                    return ((JTL.Tax1040.BusinessObject.RailroadRetirementIncome)(this.GetVariableValue((8 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 192 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    RRB;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr16Get() {
                
                #line 192 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                    RRB;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(double value) {
                
                #line 192 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                                    RRB = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 214 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  RRB;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr19Get() {
                
                #line 214 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                  RRB;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(double value) {
                
                #line 214 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                                  RRB = value;
                
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
                            && (locationReferences.Count < 9))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 9);
                }
                expectedLocationsCount = 9;
                if (((locationReferences[(offset + 8)].Name != "RailRoadBenefit") 
                            || (locationReferences[(offset + 8)].Type != typeof(JTL.Tax1040.BusinessObject.RailroadRetirementIncome)))) {
                    return false;
                }
                return Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly : Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected JTL.Tax1040.BusinessObject.RailroadRetirementIncome RailRoadBenefit {
                get {
                    return ((JTL.Tax1040.BusinessObject.RailroadRetirementIncome)(this.GetVariableValue((8 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 164 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    (Tax1040Object.Income.OtherIncome.RRB != null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr11Get() {
                
                #line 164 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                    (Tax1040Object.Income.OtherIncome.RRB != null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 171 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        (Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.PrimaryTaxPayer != null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr12Get() {
                
                #line 171 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                        (Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.PrimaryTaxPayer != null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 178 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.FilingStatus>> expression = () => 
                            Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.FilingStatus @__Expr13Get() {
                
                #line 178 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                            Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.FilingStatus ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 185 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr14Get() {
                
                #line 185 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 197 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.Value:0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr15Get() {
                
                #line 197 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                    Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.Value:0;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 207 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits != null || Tax1040Object.Income.OtherIncome.RRB.SpouseNetBenefits !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr17Get() {
                
                #line 207 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                              Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits != null || Tax1040Object.Income.OtherIncome.RRB.SpouseNetBenefits !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 219 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                  (Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.Value:0 )+( Tax1040Object.Income.OtherIncome.RRB.SpouseNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.RRB.SpouseNetBenefits.Value:0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr18Get() {
                
                #line 219 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                                  (Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.Value:0 )+( Tax1040Object.Income.OtherIncome.RRB.SpouseNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.RRB.SpouseNetBenefits.Value:0);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
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
                if (((locationReferences[(offset + 8)].Name != "RailRoadBenefit") 
                            || (locationReferences[(offset + 8)].Type != typeof(JTL.Tax1040.BusinessObject.RailroadRetirementIncome)))) {
                    return false;
                }
                return Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 : Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double UnEmployment;
            
            protected double TotalWages;
            
            protected double TaxableInterest;
            
            protected double F1099INTAmount;
            
            protected double F1099OIDAmount;
            
            protected double TaxableExcemptInterestINT;
            
            protected double TaxableExcemptInterestOID;
            
            protected double TaxableExcemptInterest;
            
            protected double Alaska;
            
            protected double TotalUnemployment;
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 361 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr36Get() {
                
                #line 361 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr36Set(double value) {
                
                #line 361 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr36Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr36Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 381 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine2SSBTaxable;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr38Get() {
                
                #line 381 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine2SSBTaxable;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr38Set(bool value) {
                
                #line 381 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine2SSBTaxable = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr38Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr38Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 391 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line2Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr40Get() {
                
                #line 391 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line2Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr40Set(double value) {
                
                #line 391 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line2Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr40Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr40Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 406 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine2SSBTaxable;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr41Get() {
                
                #line 406 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine2SSBTaxable;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr41Set(bool value) {
                
                #line 406 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                        Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine2SSBTaxable = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr41Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr41Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 419 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                      Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr42Get() {
                
                #line 419 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                      Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr42Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 419 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                      Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr42Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr42Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 424 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                      TotalWages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr43Get() {
                
                #line 424 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                      TotalWages;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr43Set(double value) {
                
                #line 424 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                      TotalWages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr43Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr43Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 431 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                      Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr44Get() {
                
                #line 431 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                      Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr44Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 431 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                      Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr44Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr44Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 436 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                      UnEmployment;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr45Get() {
                
                #line 436 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                      UnEmployment;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr45Set(double value) {
                
                #line 436 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                      UnEmployment = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr45Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr45Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 448 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                      Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr46Get() {
                
                #line 448 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                      Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr46Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 448 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                      Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr46Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr46Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 443 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                      Alaska;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr47Get() {
                
                #line 443 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                      Alaska;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr47Set(double value) {
                
                #line 443 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                      Alaska = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr47Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr47Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 456 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        TotalUnemployment;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr49Get() {
                
                #line 456 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                        TotalUnemployment;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr49Set(double value) {
                
                #line 456 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                        TotalUnemployment = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr49Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr49Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 534 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line3Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr61Get() {
                
                #line 534 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line3Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr61Set(double value) {
                
                #line 534 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line3Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr61Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr61Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 546 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line4Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr63Get() {
                
                #line 546 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line4Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr63Set(double value) {
                
                #line 546 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line4Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr63Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr63Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 558 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr65Get() {
                
                #line 558 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr65Set(double value) {
                
                #line 558 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr65Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr65Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.UnEmployment = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.TotalWages = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.TaxableInterest = ((double)(this.GetVariableValue((10 + locationsOffset))));
                this.F1099INTAmount = ((double)(this.GetVariableValue((11 + locationsOffset))));
                this.F1099OIDAmount = ((double)(this.GetVariableValue((12 + locationsOffset))));
                this.TaxableExcemptInterestINT = ((double)(this.GetVariableValue((13 + locationsOffset))));
                this.TaxableExcemptInterestOID = ((double)(this.GetVariableValue((14 + locationsOffset))));
                this.TaxableExcemptInterest = ((double)(this.GetVariableValue((15 + locationsOffset))));
                this.Alaska = ((double)(this.GetVariableValue((16 + locationsOffset))));
                this.TotalUnemployment = ((double)(this.GetVariableValue((17 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((8 + locationsOffset), this.UnEmployment);
                this.SetVariableValue((9 + locationsOffset), this.TotalWages);
                this.SetVariableValue((10 + locationsOffset), this.TaxableInterest);
                this.SetVariableValue((11 + locationsOffset), this.F1099INTAmount);
                this.SetVariableValue((12 + locationsOffset), this.F1099OIDAmount);
                this.SetVariableValue((13 + locationsOffset), this.TaxableExcemptInterestINT);
                this.SetVariableValue((14 + locationsOffset), this.TaxableExcemptInterestOID);
                this.SetVariableValue((15 + locationsOffset), this.TaxableExcemptInterest);
                this.SetVariableValue((16 + locationsOffset), this.Alaska);
                this.SetVariableValue((17 + locationsOffset), this.TotalUnemployment);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                if (((locationReferences[(offset + 8)].Name != "UnEmployment") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "TotalWages") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "TaxableInterest") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "F1099INTAmount") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "F1099OIDAmount") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "TaxableExcemptInterestINT") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "TaxableExcemptInterestOID") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "TaxableExcemptInterest") 
                            || (locationReferences[(offset + 15)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "Alaska") 
                            || (locationReferences[(offset + 16)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "TotalUnemployment") 
                            || (locationReferences[(offset + 17)].Type != typeof(double)))) {
                    return false;
                }
                return Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly : Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double UnEmployment;
            
            protected double TotalWages;
            
            protected double TaxableInterest;
            
            protected double F1099INTAmount;
            
            protected double F1099OIDAmount;
            
            protected double TaxableExcemptInterestINT;
            
            protected double TaxableExcemptInterestOID;
            
            protected double TaxableExcemptInterest;
            
            protected double Alaska;
            
            protected double TotalUnemployment;
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 366 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Math.Round(SSA)+Math.Round(RRB);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr35Get() {
                
                #line 366 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                    Math.Round(SSA)+Math.Round(RRB);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 373 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    (Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount > 0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr37Get() {
                
                #line 373 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                    (Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount > 0);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 396 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount/2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr39Get() {
                
                #line 396 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount/2;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 461 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        UnEmployment+Alaska;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr48Get() {
                
                #line 461 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                        UnEmployment+Alaska;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 539 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    TotalWages + TotalUnemployment;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr60Get() {
                
                #line 539 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                    TotalWages + TotalUnemployment;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 551 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    TaxableInterest + TaxableExcemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr62Get() {
                
                #line 551 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                    TaxableInterest + TaxableExcemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 563 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line2Amount+Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line3Amount + Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line4Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr64Get() {
                
                #line 563 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line2Amount+Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line3Amount + Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line4Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            protected override void GetValueTypeValues() {
                this.UnEmployment = ((double)(this.GetVariableValue((8 + locationsOffset))));
                this.TotalWages = ((double)(this.GetVariableValue((9 + locationsOffset))));
                this.TaxableInterest = ((double)(this.GetVariableValue((10 + locationsOffset))));
                this.F1099INTAmount = ((double)(this.GetVariableValue((11 + locationsOffset))));
                this.F1099OIDAmount = ((double)(this.GetVariableValue((12 + locationsOffset))));
                this.TaxableExcemptInterestINT = ((double)(this.GetVariableValue((13 + locationsOffset))));
                this.TaxableExcemptInterestOID = ((double)(this.GetVariableValue((14 + locationsOffset))));
                this.TaxableExcemptInterest = ((double)(this.GetVariableValue((15 + locationsOffset))));
                this.Alaska = ((double)(this.GetVariableValue((16 + locationsOffset))));
                this.TotalUnemployment = ((double)(this.GetVariableValue((17 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 18))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 18);
                }
                expectedLocationsCount = 18;
                if (((locationReferences[(offset + 8)].Name != "UnEmployment") 
                            || (locationReferences[(offset + 8)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "TotalWages") 
                            || (locationReferences[(offset + 9)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "TaxableInterest") 
                            || (locationReferences[(offset + 10)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "F1099INTAmount") 
                            || (locationReferences[(offset + 11)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "F1099OIDAmount") 
                            || (locationReferences[(offset + 12)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "TaxableExcemptInterestINT") 
                            || (locationReferences[(offset + 13)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "TaxableExcemptInterestOID") 
                            || (locationReferences[(offset + 14)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "TaxableExcemptInterest") 
                            || (locationReferences[(offset + 15)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "Alaska") 
                            || (locationReferences[(offset + 16)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "TotalUnemployment") 
                            || (locationReferences[(offset + 17)].Type != typeof(double)))) {
                    return false;
                }
                return Form1040EZSSBEligibilityWithNoValidation_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5 : Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected new double F1099INTAmount;
            
            protected new double F1099OIDAmount;
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 474 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr50Get() {
                
                #line 474 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
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
                
                #line 474 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
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
                
                #line 484 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        TaxableExcemptInterestINT;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr51Get() {
                
                #line 484 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                        TaxableExcemptInterestINT;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr51Set(double value) {
                
                #line 484 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                        TaxableExcemptInterestINT = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr51Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr51Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 479 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        F1099INTAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr52Get() {
                
                #line 479 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                        F1099INTAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr52Set(double value) {
                
                #line 479 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                        F1099INTAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr52Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr52Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 501 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        TaxableExcemptInterestOID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr53Get() {
                
                #line 501 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                        TaxableExcemptInterestOID;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr53Set(double value) {
                
                #line 501 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                        TaxableExcemptInterestOID = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr53Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr53Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 491 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                        Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr54Get() {
                
                #line 491 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                        Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr54Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 491 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                        Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr54Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr54Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 496 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        F1099OIDAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr55Get() {
                
                #line 496 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                        F1099OIDAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr55Set(double value) {
                
                #line 496 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                        F1099OIDAmount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr55Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr55Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 508 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        TaxableInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr57Get() {
                
                #line 508 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                        TaxableInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr57Set(double value) {
                
                #line 508 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                        TaxableInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr57Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr57Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 520 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        TaxableExcemptInterest;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr59Get() {
                
                #line 520 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                        TaxableExcemptInterest;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr59Set(double value) {
                
                #line 520 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                
                        TaxableExcemptInterest = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr59Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr59Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.F1099INTAmount = ((double)(this.GetVariableValue((18 + locationsOffset))));
                this.F1099OIDAmount = ((double)(this.GetVariableValue((19 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((18 + locationsOffset), this.F1099INTAmount);
                this.SetVariableValue((19 + locationsOffset), this.F1099OIDAmount);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 20))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 20);
                }
                expectedLocationsCount = 20;
                if (((locationReferences[(offset + 18)].Name != "F1099INTAmount") 
                            || (locationReferences[(offset + 18)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "F1099OIDAmount") 
                            || (locationReferences[(offset + 19)].Type != typeof(double)))) {
                    return false;
                }
                return Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly : Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected new double F1099INTAmount;
            
            protected new double F1099OIDAmount;
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligibilityWithNoValidation_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 513 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        F1099OIDAmount + F1099INTAmount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr56Get() {
                
                #line 513 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                        F1099OIDAmount + F1099INTAmount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 525 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        TaxableExcemptInterestINT + TaxableExcemptInterestOID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr58Get() {
                
                #line 525 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\CALCULATIONWITHNOVALIDATION\FORM1040EZSSBELIGIBILITYWITHNOVALIDATION.XAML"
                return 
                        TaxableExcemptInterestINT + TaxableExcemptInterestOID;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            protected override void GetValueTypeValues() {
                this.F1099INTAmount = ((double)(this.GetVariableValue((18 + locationsOffset))));
                this.F1099OIDAmount = ((double)(this.GetVariableValue((19 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 20))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 20);
                }
                expectedLocationsCount = 20;
                if (((locationReferences[(offset + 18)].Name != "F1099INTAmount") 
                            || (locationReferences[(offset + 18)].Type != typeof(double)))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "F1099OIDAmount") 
                            || (locationReferences[(offset + 19)].Type != typeof(double)))) {
                    return false;
                }
                return Form1040EZSSBEligibilityWithNoValidation_TypedDataContext4_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}