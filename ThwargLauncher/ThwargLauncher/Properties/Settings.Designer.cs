﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThwargLauncher.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SelectedUser {
            get {
                return ((int)(this["SelectedUser"]));
            }
            set {
                this["SelectedUser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Turbine\\Asheron\'s Call\\acclient.exe")]
        public string ACLocation {
            get {
                return ((string)(this["ACLocation"]));
            }
            set {
                this["ACLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Default")]
        public string LastProfileName {
            get {
                return ((string)(this["LastProfileName"]));
            }
            set {
                this["LastProfileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool NeedsUpgrade {
            get {
                return ((bool)(this["NeedsUpgrade"]));
            }
            set {
                this["NeedsUpgrade"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowHelpAtStart {
            get {
                return ((bool)(this["ShowHelpAtStart"]));
            }
            set {
                this["ShowHelpAtStart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public string ShowSimpleLaunch {
            get {
                return ((string)(this["ShowSimpleLaunch"]));
            }
            set {
                this["ShowSimpleLaunch"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://thwargle.com/thwarglauncher/GDLPublishedServerInfo.xml")]
        public string GDLServerListUrl {
            get {
                return ((string)(this["GDLServerListUrl"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SimpleLaunch_Username {
            get {
                return ((string)(this["SimpleLaunch_Username"]));
            }
            set {
                this["SimpleLaunch_Username"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SimpleLaunch_Password {
            get {
                return ((string)(this["SimpleLaunch_Password"]));
            }
            set {
                this["SimpleLaunch_Password"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SimpleLaunch_ServerHashCode {
            get {
                return ((int)(this["SimpleLaunch_ServerHashCode"]));
            }
            set {
                this["SimpleLaunch_ServerHashCode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LastUsedSimpleLaunch {
            get {
                return ((bool)(this["LastUsedSimpleLaunch"]));
            }
            set {
                this["LastUsedSimpleLaunch"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ServerMonitorEnabled {
            get {
                return ((bool)(this["ServerMonitorEnabled"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool InjectDecal {
            get {
                return ((bool)(this["InjectDecal"]));
            }
            set {
                this["InjectDecal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoRelaunch {
            get {
                return ((bool)(this["AutoRelaunch"]));
            }
            set {
                this["AutoRelaunch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CheckServerStatus {
            get {
                return ((bool)(this["CheckServerStatus"]));
            }
            set {
                this["CheckServerStatus"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://thwargle.com/thwarglauncher/ACEPublishedServerInfo.xml")]
        public string ACEServerListUrl {
            get {
                return ((string)(this["ACEServerListUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://thwargle.com/thwarglauncher/DFPublishedServerInfo.xml")]
        public string DFServerListUrl {
            get {
                return ((string)(this["DFServerListUrl"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://treestats.net/player_counts-latest.json")]
        public string ServerCountUrl {
            get {
                return ((string)(this["ServerCountUrl"]));
            }
            set {
                this["ServerCountUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowCheckedAccounts {
            get {
                return ((bool)(this["ShowCheckedAccounts"]));
            }
            set {
                this["ShowCheckedAccounts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowPassword {
            get {
                return ((bool)(this["ShowPassword"]));
            }
            set {
                this["ShowPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SaveGameWindows {
            get {
                return ((bool)(this["SaveGameWindows"]));
            }
            set {
                this["SaveGameWindows"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool RestoreGameWindows {
            get {
                return ((bool)(this["RestoreGameWindows"]));
            }
            set {
                this["RestoreGameWindows"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/Thwargle/ThwargLauncher/master/ThwargLauncher/T" +
            "hwargLauncher/ServerLists/WildWestPublishedServerInfo.xml")]
        public string WildWestServerListUrl {
            get {
                return ((string)(this["WildWestServerListUrl"]));
            }
        }
    }
}