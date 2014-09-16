namespace Tax1040WorkFlow.WorkFlow.Activities {
    
    #line 22 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZSSBEligiblity.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZSSBEligiblity.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 23 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZSSBEligiblity.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZSSBEligiblity.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZSSBEligiblity.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZSSBEligiblity.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 24 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZSSBEligiblity.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 25 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZSSBEligiblity.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 26 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZSSBEligiblity.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 27 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZSSBEligiblity.xaml"
    using JTL.Tax1040.BusinessObject;
    
    #line default
    #line hidden
    
    #line 28 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZSSBEligiblity.xaml"
    using JTL.Tax1040.Core.Object;
    
    #line default
    #line hidden
    
    #line 1 "E:\Tax1040EZ\Tax1040Latest\Jeevan1040\Feature\Code\JTL.Tax1040.BusinessLogic\WorkFlow\Activities\Form1040EZSSBEligiblity.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class Form1040EZSSBEligiblity : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext0 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext1 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext2 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext2.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext3 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext4 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext5 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext6 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext7 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext8 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext9 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext9.GetLocation<double>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext10 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext11 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext12 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext12.GetLocation<double>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Form1040EZSSBEligiblity_TypedDataContext3(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext3 refDataContext13 = ((Form1040EZSSBEligiblity_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext13.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly valDataContext14 = ((Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly valDataContext15 = ((Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly valDataContext16 = ((Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly valDataContext17 = ((Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly valDataContext18 = ((Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly valDataContext19 = ((Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Form1040EZSSBEligiblity_TypedDataContext3(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext3 refDataContext20 = ((Form1040EZSSBEligiblity_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext20.GetLocation<double>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly valDataContext21 = ((Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly valDataContext22 = ((Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Form1040EZSSBEligiblity_TypedDataContext3(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext3 refDataContext23 = ((Form1040EZSSBEligiblity_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext23.GetLocation<double>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext24 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext25 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext26 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext26.GetLocation<JTL.Tax1040.BusinessObject.F1040EZ>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext27 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext28 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext28.GetLocation<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext29 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext30 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext30.GetLocation<JTL.Tax1040.BusinessObject.SSBWorkSheet>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext31 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext32 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext33 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext33.GetLocation<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext34 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext35 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext35.GetLocation<JTL.Tax1040.BusinessObject.SSBWorkSheet>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext36 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext37 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext38 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext38.GetLocation<JTL.Tax1040.BusinessObject.SSBWorkSheet>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext39 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext40 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext40.GetLocation<double>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext41 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext42 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext42.GetLocation<bool>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext43 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext44 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext44.GetLocation<double>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext45 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext45.GetLocation<bool>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext46 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext47 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext47.GetLocation<double>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext48 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext49 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext49.GetLocation<double>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext50 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext51 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext51.GetLocation<double>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext52 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext53 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext54 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext55 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext56 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext56.GetLocation<double>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext57 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext58 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext58.GetLocation<bool>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext59 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext59.GetLocation<bool>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext60 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext61 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext61.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext62 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext63 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext64 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext65 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext65.GetLocation<double>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext66 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext67 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext67.GetLocation<bool>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext68 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext68.GetLocation<bool>(refDataContext68.ValueType___Expr68Get, refDataContext68.ValueType___Expr68Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext69 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext70 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext70.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext71 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext72 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext73 = ((Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Form1040EZSSBEligiblity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Form1040EZSSBEligiblity_TypedDataContext2(locations, activityContext, true);
                }
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext74 = ((Form1040EZSSBEligiblity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext74.GetLocation<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>(refDataContext74.ValueType___Expr74Get, refDataContext74.ValueType___Expr74Set, expressionId, this.rootActivity, activityContext);
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
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext0 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext1 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext2 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext2.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext3 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext4 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext5 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext6 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext7 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext8 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext9 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext9.GetLocation<double>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext10 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext11 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext12 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext12.GetLocation<double>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                Form1040EZSSBEligiblity_TypedDataContext3 refDataContext13 = new Form1040EZSSBEligiblity_TypedDataContext3(locations, true);
                return refDataContext13.GetLocation<JTL.Tax1040.BusinessObject.Tax1040>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly valDataContext14 = new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly valDataContext15 = new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly valDataContext16 = new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly valDataContext17 = new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly valDataContext18 = new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly valDataContext19 = new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                Form1040EZSSBEligiblity_TypedDataContext3 refDataContext20 = new Form1040EZSSBEligiblity_TypedDataContext3(locations, true);
                return refDataContext20.GetLocation<double>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set);
            }
            if ((expressionId == 21)) {
                Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly valDataContext21 = new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly valDataContext22 = new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                Form1040EZSSBEligiblity_TypedDataContext3 refDataContext23 = new Form1040EZSSBEligiblity_TypedDataContext3(locations, true);
                return refDataContext23.GetLocation<double>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set);
            }
            if ((expressionId == 24)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext24 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext25 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext26 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext26.GetLocation<JTL.Tax1040.BusinessObject.F1040EZ>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext27 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext28 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext28.GetLocation<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set);
            }
            if ((expressionId == 29)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext29 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext30 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext30.GetLocation<JTL.Tax1040.BusinessObject.SSBWorkSheet>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set);
            }
            if ((expressionId == 31)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext31 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext32 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext33 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext33.GetLocation<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set);
            }
            if ((expressionId == 34)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext34 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext35 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext35.GetLocation<JTL.Tax1040.BusinessObject.SSBWorkSheet>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set);
            }
            if ((expressionId == 36)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext36 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext37 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext38 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext38.GetLocation<JTL.Tax1040.BusinessObject.SSBWorkSheet>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set);
            }
            if ((expressionId == 39)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext39 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext40 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext40.GetLocation<double>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set);
            }
            if ((expressionId == 41)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext41 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext42 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext42.GetLocation<bool>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set);
            }
            if ((expressionId == 43)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext43 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext44 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext44.GetLocation<double>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set);
            }
            if ((expressionId == 45)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext45 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext45.GetLocation<bool>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set);
            }
            if ((expressionId == 46)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext46 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext47 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext47.GetLocation<double>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set);
            }
            if ((expressionId == 48)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext48 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext49 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext49.GetLocation<double>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set);
            }
            if ((expressionId == 50)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext50 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext51 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext51.GetLocation<double>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set);
            }
            if ((expressionId == 52)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext52 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext53 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext54 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext55 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext56 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext56.GetLocation<double>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set);
            }
            if ((expressionId == 57)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext57 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext58 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext58.GetLocation<bool>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set);
            }
            if ((expressionId == 59)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext59 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext59.GetLocation<bool>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set);
            }
            if ((expressionId == 60)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext60 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext61 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext61.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set);
            }
            if ((expressionId == 62)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext62 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext63 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext64 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext65 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext65.GetLocation<double>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set);
            }
            if ((expressionId == 66)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext66 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext67 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext67.GetLocation<bool>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set);
            }
            if ((expressionId == 68)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext68 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext68.GetLocation<bool>(refDataContext68.ValueType___Expr68Get, refDataContext68.ValueType___Expr68Set);
            }
            if ((expressionId == 69)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext69 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext70 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext70.GetLocation<JTL.Tax1040.Core.Object.ErrorMessage>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set);
            }
            if ((expressionId == 71)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext71 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext72 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly valDataContext73 = new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                Form1040EZSSBEligiblity_TypedDataContext2 refDataContext74 = new Form1040EZSSBEligiblity_TypedDataContext2(locations, true);
                return refDataContext74.GetLocation<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>(refDataContext74.ValueType___Expr74Get, refDataContext74.ValueType___Expr74Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.ErrorMessages") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object != null && Tax1040Object.Income!=null && Tax1040Object.Income.Other" +
                            "Income !=null") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Tax1040Object.Income.OtherIncome.SSB != null))") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.Primary" +
                            "TaxPayer != null)") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits!=null") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.Value") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "SSA") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits!=null) || (Tax1040Objec" +
                            "t.Income.OtherIncome.SSB.SpouseNetBenefits!=null)") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"(Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.Value:0 )+ (Tax1040Object.Income.OtherIncome.SSB.SpouseNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.SSB.SpouseNetBenefits.Value:0)") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "SSA") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object") 
                        && (Form1040EZSSBEligiblity_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages") 
                        && (Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.Income.OtherIncome.RRB != null)") 
                        && (Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.Primary" +
                            "TaxPayer != null)") 
                        && (Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus") 
                        && (Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits!=null") 
                        && (Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.Value") 
                        && (Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RRB") 
                        && (Form1040EZSSBEligiblity_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits!=null)|| (Tax1040Object" +
                            ".Income.OtherIncome.RRB.SpouseNetBenefits!=null)") 
                        && (Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"(Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.Value:0 )+( Tax1040Object.Income.OtherIncome.RRB.SpouseNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.RRB.SpouseNetBenefits.Value:0)") 
                        && (Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RRB") 
                        && (Form1040EZSSBEligiblity_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.F1040EZ==null)") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new F1040EZ()") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new F1040EZWorkSheets()") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new SSBWorkSheet()") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.F1040EZ.F1040EZWorkSheets==null)") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new F1040EZWorkSheets()") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new SSBWorkSheet()") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet==null)") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new SSBWorkSheet()") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Round(SSA, MidpointRounding.AwayFromZero) + Math.Round(RRB, MidpointRounding" +
                            ".AwayFromZero)") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount > 0)") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine2SSBTaxable") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount/2") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line2Amount") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine2SSBTaxable") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages+Tax1040Object.OutputForms.Tax" +
                            "1040EZPage1.UnemploymentCompensation") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line3Amount") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + Tax1040Object.OutputFo" +
                            "rms.Tax1040EZPage1.TEI") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line4Amount") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line2Amount+Tax1040Object.F1" +
                            "040EZ.F1040EZWorkSheets.SSBWorkSheet.Line3Amount + Tax1040Object.F1040EZ.F1040EZ" +
                            "WorkSheets.SSBWorkSheet.Line4Amount") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails !=null") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer !=null") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "SingleLimit") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line6Amount") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount <= SingleLimit") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.SOCIAL_SECURITY_AND_RAILROAD_BENEFITS]") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "MFJLimit") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line6Amount") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount <= MFJLimit") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessages[Constants.SOCIAL_SECURITY_AND_RAILROAD_BENEFITS]") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ErrorMessage") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessage") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ErrorMessageList") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Tax1040Object.ErrorMessages") 
                        && (Form1040EZSSBEligiblity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
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
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new Form1040EZSSBEligiblity_TypedDataContext3(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new Form1040EZSSBEligiblity_TypedDataContext3(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new Form1040EZSSBEligiblity_TypedDataContext3(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new Form1040EZSSBEligiblity_TypedDataContext2(locationReferences).@__Expr74GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZSSBEligiblity_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Form1040EZSSBEligiblity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligiblity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligiblity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class Form1040EZSSBEligiblity_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Form1040EZSSBEligiblity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligiblity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligiblity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class Form1040EZSSBEligiblity_TypedDataContext1 : Form1040EZSSBEligiblity_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Form1040EZSSBEligiblity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligiblity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligiblity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                return Form1040EZSSBEligiblity_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZSSBEligiblity_TypedDataContext1_ForReadOnly : Form1040EZSSBEligiblity_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Form1040EZSSBEligiblity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligiblity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligiblity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                return Form1040EZSSBEligiblity_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZSSBEligiblity_TypedDataContext2 : Form1040EZSSBEligiblity_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double SSA;
            
            protected double RRB;
            
            protected double SingleLimit;
            
            protected double MFJLimit;
            
            public Form1040EZSSBEligiblity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligiblity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligiblity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 91 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                    Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr2Get() {
                
                #line 91 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
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
                
                #line 91 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                    Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 126 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    SSA;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr9Get() {
                
                #line 126 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                    SSA;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(double value) {
                
                #line 126 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                                    SSA = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 149 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    SSA;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr12Get() {
                
                #line 149 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                    SSA;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(double value) {
                
                #line 149 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                                    SSA = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 275 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZ>> expression = () => 
                          Tax1040Object.F1040EZ;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZ @__Expr26Get() {
                
                #line 275 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                          Tax1040Object.F1040EZ;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZ ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(JTL.Tax1040.BusinessObject.F1040EZ value) {
                
                #line 275 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                          Tax1040Object.F1040EZ = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(JTL.Tax1040.BusinessObject.F1040EZ value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 287 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>> expression = () => 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets @__Expr28Get() {
                
                #line 287 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr28Set(JTL.Tax1040.BusinessObject.F1040EZWorkSheets value) {
                
                #line 287 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                          Tax1040Object.F1040EZ.F1040EZWorkSheets = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr28Set(JTL.Tax1040.BusinessObject.F1040EZWorkSheets value) {
                this.GetValueTypeValues();
                this.@__Expr28Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 299 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.SSBWorkSheet>> expression = () => 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.SSBWorkSheet @__Expr30Get() {
                
                #line 299 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.SSBWorkSheet ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr30Set(JTL.Tax1040.BusinessObject.SSBWorkSheet value) {
                
                #line 299 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr30Set(JTL.Tax1040.BusinessObject.SSBWorkSheet value) {
                this.GetValueTypeValues();
                this.@__Expr30Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 322 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets @__Expr33Get() {
                
                #line 322 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(JTL.Tax1040.BusinessObject.F1040EZWorkSheets value) {
                
                #line 322 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                              Tax1040Object.F1040EZ.F1040EZWorkSheets = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr33Set(JTL.Tax1040.BusinessObject.F1040EZWorkSheets value) {
                this.GetValueTypeValues();
                this.@__Expr33Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 334 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.SSBWorkSheet>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.SSBWorkSheet @__Expr35Get() {
                
                #line 334 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.SSBWorkSheet ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr35Set(JTL.Tax1040.BusinessObject.SSBWorkSheet value) {
                
                #line 334 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr35Set(JTL.Tax1040.BusinessObject.SSBWorkSheet value) {
                this.GetValueTypeValues();
                this.@__Expr35Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 356 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.SSBWorkSheet>> expression = () => 
                                Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.SSBWorkSheet @__Expr38Get() {
                
                #line 356 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.SSBWorkSheet ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr38Set(JTL.Tax1040.BusinessObject.SSBWorkSheet value) {
                
                #line 356 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                                Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr38Set(JTL.Tax1040.BusinessObject.SSBWorkSheet value) {
                this.GetValueTypeValues();
                this.@__Expr38Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 376 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr40Get() {
                
                #line 376 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr40Set(double value) {
                
                #line 376 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr40Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr40Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 396 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine2SSBTaxable;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr42Get() {
                
                #line 396 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine2SSBTaxable;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr42Set(bool value) {
                
                #line 396 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine2SSBTaxable = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr42Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr42Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 406 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line2Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr44Get() {
                
                #line 406 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line2Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr44Set(double value) {
                
                #line 406 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line2Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr44Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr44Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 421 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine2SSBTaxable;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr45Get() {
                
                #line 421 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                        Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine2SSBTaxable;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr45Set(bool value) {
                
                #line 421 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                        Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine2SSBTaxable = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr45Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr45Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 433 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line3Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr47Get() {
                
                #line 433 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line3Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr47Set(double value) {
                
                #line 433 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line3Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr47Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr47Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 445 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line4Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr49Get() {
                
                #line 445 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line4Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr49Set(double value) {
                
                #line 445 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line4Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr49Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr49Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 457 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr51Get() {
                
                #line 457 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr51Set(double value) {
                
                #line 457 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr51Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr51Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 491 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line6Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr56Get() {
                
                #line 491 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line6Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr56Set(double value) {
                
                #line 491 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line6Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr56Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr56Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 510 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr58Get() {
                
                #line 510 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr58Set(bool value) {
                
                #line 510 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr58Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr58Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 523 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr59Get() {
                
                #line 523 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr59Set(bool value) {
                
                #line 523 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr59Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr59Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 534 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr61Get() {
                
                #line 534 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
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
                
                #line 534 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                                      ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr61Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr61Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 562 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line6Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr65Get() {
                
                #line 562 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line6Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr65Set(double value) {
                
                #line 562 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line6Amount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr65Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr65Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 581 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr67Get() {
                
                #line 581 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr67Set(bool value) {
                
                #line 581 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                                  Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr67Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr67Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 594 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr68Get() {
                
                #line 594 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr68Set(bool value) {
                
                #line 594 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.IsLine7SSBTaxable = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr68Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr68Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 605 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr70Get() {
                
                #line 605 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
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
                
                #line 605 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                                      ErrorMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr70Set(JTL.Tax1040.Core.Object.ErrorMessage value) {
                this.GetValueTypeValues();
                this.@__Expr70Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 640 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                  Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr74Get() {
                
                #line 640 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                  Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr74Set(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> value) {
                
                #line 640 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                  Tax1040Object.ErrorMessages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr74Set(System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> value) {
                this.GetValueTypeValues();
                this.@__Expr74Set(value);
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
                return Form1040EZSSBEligiblity_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly : Form1040EZSSBEligiblity_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double SSA;
            
            protected double RRB;
            
            protected double SingleLimit;
            
            protected double MFJLimit;
            
            public Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 65 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
          Tax1040Object.ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr0Get() {
                
                #line 65 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
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
                
                #line 76 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          Tax1040Object != null && Tax1040Object.Income!=null && Tax1040Object.Income.OtherIncome !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr1Get() {
                
                #line 76 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
          Tax1040Object != null && Tax1040Object.Income!=null && Tax1040Object.Income.OtherIncome !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 86 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessages>> expression = () => 
                    ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessages @__Expr3Get() {
                
                #line 86 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                    ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessages ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 98 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    ((Tax1040Object.Income.OtherIncome.SSB != null));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr4Get() {
                
                #line 98 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                    ((Tax1040Object.Income.OtherIncome.SSB != null));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 105 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        (Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.PrimaryTaxPayer != null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr5Get() {
                
                #line 105 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                        (Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.PrimaryTaxPayer != null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 112 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.FilingStatus>> expression = () => 
                            Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.FilingStatus @__Expr6Get() {
                
                #line 112 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                            Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.FilingStatus ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 119 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits!=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr7Get() {
                
                #line 119 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits!=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 131 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.Value;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr8Get() {
                
                #line 131 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                    Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.Value;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                (Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits!=null) || (Tax1040Object.Income.OtherIncome.SSB.SpouseNetBenefits!=null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr10Get() {
                
                #line 142 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                (Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits!=null) || (Tax1040Object.Income.OtherIncome.SSB.SpouseNetBenefits!=null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 154 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    (Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.Value:0 )+ (Tax1040Object.Income.OtherIncome.SSB.SpouseNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.SSB.SpouseNetBenefits.Value:0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr11Get() {
                
                #line 154 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                    (Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.SSB.TaxpayerNetBenefits.Value:0 )+ (Tax1040Object.Income.OtherIncome.SSB.SpouseNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.SSB.SpouseNetBenefits.Value:0);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 267 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    (Tax1040Object.F1040EZ==null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr24Get() {
                
                #line 267 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                    (Tax1040Object.F1040EZ==null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 280 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZ>> expression = () => 
                          new F1040EZ();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZ @__Expr25Get() {
                
                #line 280 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                          new F1040EZ();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZ ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 292 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>> expression = () => 
                          new F1040EZWorkSheets();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets @__Expr27Get() {
                
                #line 292 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                          new F1040EZWorkSheets();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 304 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.SSBWorkSheet>> expression = () => 
                          new SSBWorkSheet();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.SSBWorkSheet @__Expr29Get() {
                
                #line 304 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                          new SSBWorkSheet();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.SSBWorkSheet ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 314 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        (Tax1040Object.F1040EZ.F1040EZWorkSheets==null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr31Get() {
                
                #line 314 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                        (Tax1040Object.F1040EZ.F1040EZWorkSheets==null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 327 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.F1040EZWorkSheets>> expression = () => 
                              new F1040EZWorkSheets();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets @__Expr32Get() {
                
                #line 327 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                              new F1040EZWorkSheets();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.F1040EZWorkSheets ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 339 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.SSBWorkSheet>> expression = () => 
                              new SSBWorkSheet();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.SSBWorkSheet @__Expr34Get() {
                
                #line 339 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                              new SSBWorkSheet();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.SSBWorkSheet ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 349 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            (Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet==null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr36Get() {
                
                #line 349 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                            (Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet==null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 361 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.SSBWorkSheet>> expression = () => 
                                new SSBWorkSheet();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.SSBWorkSheet @__Expr37Get() {
                
                #line 361 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                new SSBWorkSheet();
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.SSBWorkSheet ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 381 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Math.Round(SSA, MidpointRounding.AwayFromZero) + Math.Round(RRB, MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr39Get() {
                
                #line 381 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                    Math.Round(SSA, MidpointRounding.AwayFromZero) + Math.Round(RRB, MidpointRounding.AwayFromZero);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 388 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    (Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount > 0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr41Get() {
                
                #line 388 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                    (Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount > 0);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 411 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount/2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr43Get() {
                
                #line 411 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                          Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line1Amount/2;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 438 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages+Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr46Get() {
                
                #line 438 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TotalWages+Tax1040Object.OutputForms.Tax1040EZPage1.UnemploymentCompensation;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 450 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + Tax1040Object.OutputForms.Tax1040EZPage1.TEI;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr48Get() {
                
                #line 450 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                    Tax1040Object.OutputForms.Tax1040EZPage1.TaxableInterest + Tax1040Object.OutputForms.Tax1040EZPage1.TEI;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 462 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line2Amount+Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line3Amount + Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line4Amount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr50Get() {
                
                #line 462 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                    Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line2Amount+Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line3Amount + Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line4Amount;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 470 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  Tax1040Object.PersonalDetails !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr52Get() {
                
                #line 470 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                  Tax1040Object.PersonalDetails !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 477 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Tax1040Object.PersonalDetails.PrimaryTaxPayer !=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr53Get() {
                
                #line 477 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                      Tax1040Object.PersonalDetails.PrimaryTaxPayer !=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 484 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.FilingStatus>> expression = () => 
                          Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.FilingStatus @__Expr54Get() {
                
                #line 484 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                          Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.FilingStatus ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 496 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              SingleLimit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr55Get() {
                
                #line 496 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                              SingleLimit;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 503 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount <= SingleLimit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr57Get() {
                
                #line 503 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount <= SingleLimit;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 539 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessages[Constants.SOCIAL_SECURITY_AND_RAILROAD_BENEFITS];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr60Get() {
                
                #line 539 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                      ErrorMessages[Constants.SOCIAL_SECURITY_AND_RAILROAD_BENEFITS];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 550 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                    ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr62Get() {
                
                #line 550 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
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
                
                #line 546 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr63Get() {
                
                #line 546 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                      ErrorMessage;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 567 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                              MFJLimit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr64Get() {
                
                #line 567 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                              MFJLimit;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 574 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount <= MFJLimit;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr66Get() {
                
                #line 574 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                              Tax1040Object.F1040EZ.F1040EZWorkSheets.SSBWorkSheet.Line5Amount <= MFJLimit;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 610 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessages[Constants.SOCIAL_SECURITY_AND_RAILROAD_BENEFITS];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr69Get() {
                
                #line 610 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                      ErrorMessages[Constants.SOCIAL_SECURITY_AND_RAILROAD_BENEFITS];
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessage ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 621 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                                    ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr71Get() {
                
                #line 621 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
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
                
                #line 617 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessage>> expression = () => 
                                      ErrorMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessage @__Expr72Get() {
                
                #line 617 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
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
                
                #line 645 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage>>> expression = () => 
                  ErrorMessageList;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> @__Expr73Get() {
                
                #line 645 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                  ErrorMessageList;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<JTL.Tax1040.Core.Object.ErrorMessage> ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
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
                return Form1040EZSSBEligiblity_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZSSBEligiblity_TypedDataContext3 : Form1040EZSSBEligiblity_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Form1040EZSSBEligiblity_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligiblity_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligiblity_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 182 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.BusinessObject.Tax1040>> expression = () => 
                    Tax1040Object;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.BusinessObject.Tax1040 @__Expr13Get() {
                
                #line 182 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                    Tax1040Object;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.BusinessObject.Tax1040 ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                
                #line 182 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                    Tax1040Object = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(JTL.Tax1040.BusinessObject.Tax1040 value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 217 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    RRB;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr20Get() {
                
                #line 217 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                    RRB;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr20Set(double value) {
                
                #line 217 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                                    RRB = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr20Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr20Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    RRB;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr23Get() {
                
                #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                    RRB;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr23Set(double value) {
                
                #line 240 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                
                                    RRB = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr23Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr23Set(value);
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
                return Form1040EZSSBEligiblity_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly : Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Form1040EZSSBEligiblity_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 177 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.ErrorMessages>> expression = () => 
                    ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.ErrorMessages @__Expr14Get() {
                
                #line 177 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                    ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.ErrorMessages ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 189 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    (Tax1040Object.Income.OtherIncome.RRB != null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr15Get() {
                
                #line 189 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                    (Tax1040Object.Income.OtherIncome.RRB != null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 196 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        (Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.PrimaryTaxPayer != null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr16Get() {
                
                #line 196 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                        (Tax1040Object.PersonalDetails != null) && (Tax1040Object.PersonalDetails.PrimaryTaxPayer != null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 203 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<JTL.Tax1040.Core.Object.FilingStatus>> expression = () => 
                            Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public JTL.Tax1040.Core.Object.FilingStatus @__Expr17Get() {
                
                #line 203 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                            Tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                
                #line default
                #line hidden
            }
            
            public JTL.Tax1040.Core.Object.FilingStatus ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 210 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits!=null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr18Get() {
                
                #line 210 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits!=null;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 222 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.Value;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr19Get() {
                
                #line 222 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                    Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.Value;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 233 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                (Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits!=null)|| (Tax1040Object.Income.OtherIncome.RRB.SpouseNetBenefits!=null);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr21Get() {
                
                #line 233 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                (Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits!=null)|| (Tax1040Object.Income.OtherIncome.RRB.SpouseNetBenefits!=null);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 245 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                    (Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.Value:0 )+( Tax1040Object.Income.OtherIncome.RRB.SpouseNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.RRB.SpouseNetBenefits.Value:0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr22Get() {
                
                #line 245 "E:\TAX1040EZ\TAX1040LATEST\JEEVAN1040\FEATURE\CODE\JTL.TAX1040.BUSINESSLOGIC\WORKFLOW\ACTIVITIES\FORM1040EZSSBELIGIBLITY.XAML"
                return 
                                    (Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.RRB.TaxpayerNetBenefits.Value:0 )+( Tax1040Object.Income.OtherIncome.RRB.SpouseNetBenefits.HasValue ? Tax1040Object.Income.OtherIncome.RRB.SpouseNetBenefits.Value:0);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
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
                return Form1040EZSSBEligiblity_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
