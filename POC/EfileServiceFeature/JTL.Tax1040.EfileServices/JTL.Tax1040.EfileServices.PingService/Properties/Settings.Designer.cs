﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JTL.Tax1040.EfileServices.PingService.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:9080/a2a/mef/mtom/GetNew2290Schedule1s")]
        public string JTL_Tax1040_EfileServices_PingService_ETECTransmitterServicesMTOM_GetNew2290Schedule1s {
            get {
                return ((string)(this["JTL_Tax1040_EfileServices_PingService_ETECTransmitterServicesMTOM_GetNew2290Sched" +
                    "ule1s"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.irs.gov/a2a/mef/ChangePassword")]
        public string JTL_Tax1040_EfileServices_PingService_MeFMSIServices_ChangePassword {
            get {
                return ((string)(this["JTL_Tax1040_EfileServices_PingService_MeFMSIServices_ChangePassword"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:9080/a2a/mef/mtom/SendSubmissions")]
        public string JTL_Tax1040_EfileServices_PingService_MeFTransmitterServicesMTOM_SendSubmissions {
            get {
                return ((string)(this["JTL_Tax1040_EfileServices_PingService_MeFTransmitterServicesMTOM_SendSubmissions"]));
            }
        }
    }
}
