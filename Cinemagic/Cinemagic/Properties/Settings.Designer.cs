﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cinemagic.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-QKV1G6CM\\SQLEXPRESS;Initial Catalog=Cinemagic_DB;Integrated Se" +
            "curity=True;MultipleActiveResultSets=true;")]
        public string Setting {
            get {
                return ((string)(this["Setting"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\JANUS\\SOURCE\\REPOS\\RO" +
            "ESTENBURG-J\\CINEMAGIC_SYSTEM2.1\\CINEMAGIC\\CINEMAGIC\\BIN\\DEBUG\\CINEMAGICDB.MDF;In" +
            "tegrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=F" +
            "alse")]
        public string C__USERS_JANUS_SOURCE_REPOS_ROESTENBURG_J_CINEMAGIC_SYSTEM2_1_CINEMAGIC_CINEMAGIC_BIN_DEBUG_CINEMAGICDB_MDFConnectionString {
            get {
                return ((string)(this["C__USERS_JANUS_SOURCE_REPOS_ROESTENBURG_J_CINEMAGIC_SYSTEM2_1_CINEMAGIC_CINEMAGIC" +
                    "_BIN_DEBUG_CINEMAGICDB_MDFConnectionString"]));
            }
        }
    }
}
