﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1 {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class SettingsApp : global::System.Configuration.ApplicationSettingsBase {
        
        private static SettingsApp defaultInstance = ((SettingsApp)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new SettingsApp())));
        
        public static SettingsApp Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GradientActiveCaption")]
        public global::System.Drawing.Color TheColor {
            get {
                return ((global::System.Drawing.Color)(this["TheColor"]));
            }
            set {
                this["TheColor"] = value;
            }
        }
    }
}
