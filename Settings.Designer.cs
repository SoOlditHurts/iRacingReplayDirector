﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iRacingReplayOverlay {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string WorkingFolder {
            get {
                return ((string)(this["WorkingFolder"]));
            }
            set {
                this["WorkingFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("15")]
        public int videoBitRate {
            get {
                return ((int)(this["videoBitRate"]));
            }
            set {
                this["videoBitRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("48000")]
        public int audioBitRate {
            get {
                return ((int)(this["audioBitRate"]));
            }
            set {
                this["audioBitRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::iRacingReplayOverlay.TrackCameras trackCameras {
            get {
                return ((global::iRacingReplayOverlay.TrackCameras)(this["trackCameras"]));
            }
            set {
                this["trackCameras"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string lastSelectedTrackName {
            get {
                return ((string)(this["lastSelectedTrackName"]));
            }
            set {
                this["lastSelectedTrackName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string lastVideoFile {
            get {
                return ((string)(this["lastVideoFile"]));
            }
            set {
                this["lastVideoFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:20")]
        public global::System.TimeSpan CameraStickyPeriod {
            get {
                return ((global::System.TimeSpan)(this["CameraStickyPeriod"]));
            }
            set {
                this["CameraStickyPeriod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PreferredDriverNames {
            get {
                return ((string)(this["PreferredDriverNames"]));
            }
            set {
                this["PreferredDriverNames"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:01")]
        public global::System.TimeSpan BattleGap {
            get {
                return ((global::System.TimeSpan)(this["BattleGap"]));
            }
            set {
                this["BattleGap"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:02:00")]
        public global::System.TimeSpan BattleStickyPeriod {
            get {
                return ((global::System.TimeSpan)(this["BattleStickyPeriod"]));
            }
            set {
                this["BattleStickyPeriod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.25")]
        public double BattleFactor {
            get {
                return ((double)(this["BattleFactor"]));
            }
            set {
                this["BattleFactor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:20")]
        public global::System.TimeSpan FollowLeaderAtRaceStartPeriod {
            get {
                return ((global::System.TimeSpan)(this["FollowLeaderAtRaceStartPeriod"]));
            }
            set {
                this["FollowLeaderAtRaceStartPeriod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:20")]
        public global::System.TimeSpan FollowLeaderBeforeRaceEndPeriod {
            get {
                return ((global::System.TimeSpan)(this["FollowLeaderBeforeRaceEndPeriod"]));
            }
            set {
                this["FollowLeaderBeforeRaceEndPeriod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:10:00")]
        public global::System.TimeSpan HighlightVideoTargetDuration {
            get {
                return ((global::System.TimeSpan)(this["HighlightVideoTargetDuration"]));
            }
            set {
                this["HighlightVideoTargetDuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FocusOnPreferedDriver {
            get {
                return ((bool)(this["FocusOnPreferedDriver"]));
            }
            set {
                this["FocusOnPreferedDriver"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisableIncidentsSearch {
            get {
                return ((bool)(this["DisableIncidentsSearch"]));
            }
            set {
                this["DisableIncidentsSearch"] = value;
            }
        }
    }
}
