// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.EventLogSDK.dll
// Classes:  7
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

namespace Hypergryph.SDK
{

    // TypeToken: 0x2000002
    public interface IEventLogSDK
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000001
        public virtual System.Boolean setEnvironment(System.String env) { }
        // RVA: -1  // abstract  token: 0x6000002
        public virtual System.Boolean enableRealTimeSend(System.Boolean enable) { }
        // RVA: -1  // abstract  token: 0x6000003
        public virtual System.Boolean init(System.String appId, System.String regionTag) { }
        // RVA: -1  // abstract  token: 0x6000004
        public virtual System.Boolean setGlobalProperties(System.String appId, System.String globalProperties) { }
        // RVA: -1  // abstract  token: 0x6000005
        public virtual System.Boolean unsetGlobalProperties(System.String appId, System.String propertyKeys) { }
        // RVA: -1  // abstract  token: 0x6000006
        public virtual System.Void clearGlobalProperties(System.String appId) { }
        // RVA: -1  // abstract  token: 0x6000007
        public virtual System.Boolean eventTrack(System.String appId, System.String name, System.String properties) { }
        // RVA: -1  // abstract  token: 0x6000008
        public virtual System.Boolean appStartEvent(System.String appId, System.String channel1, System.String channel2, System.Boolean beat, System.String properties) { }
        // RVA: -1  // abstract  token: 0x6000009
        public virtual System.Void pauseBeat(System.String appId) { }
        // RVA: -1  // abstract  token: 0x600000A
        public virtual System.Void resumeBeat(System.String appId) { }
        // RVA: -1  // abstract  token: 0x600000B
        public virtual System.Boolean userLoginEvent(System.String appId, System.String userId, System.String properties) { }
        // RVA: -1  // abstract  token: 0x600000C
        public virtual System.Void unsetUser(System.String appId) { }
        // RVA: -1  // abstract  token: 0x600000D
        public virtual System.Boolean characterLoginEvent(System.String appId, System.String characterId, System.String serverId, System.String properties) { }
        // RVA: -1  // abstract  token: 0x600000E
        public virtual System.Void unsetCharacter(System.String appId) { }
        // RVA: -1  // abstract  token: 0x600000F
        public virtual System.String getPresetProperties(System.String appId) { }
        // RVA: -1  // abstract  token: 0x6000010
        public virtual System.Void flush(System.String appId) { }
        // RVA: -1  // abstract  token: 0x6000011
        public virtual System.String getStaticPresetProperties(System.String appId) { }
        // RVA: -1  // abstract  token: 0x6000012
        public virtual System.String getDeviceIdProperties(System.String appId) { }
        // RVA: -1  // abstract  token: 0x6000013
        public virtual System.Boolean setGlobalPropertiesV2(System.String globalProperties) { }
        // RVA: -1  // abstract  token: 0x6000014
        public virtual System.Boolean unsetGlobalPropertiesV2(System.String propertyKeys) { }
        // RVA: -1  // abstract  token: 0x6000015
        public virtual System.Void clearGlobalPropertiesV2() { }
        // RVA: -1  // abstract  token: 0x6000016
        public virtual System.Boolean eventTrackV2(System.String name, System.String properties) { }
        // RVA: -1  // abstract  token: 0x6000017
        public virtual System.Boolean appStartEventV2(System.String channel1, System.String channel2, System.Boolean beat, System.String properties) { }
        // RVA: -1  // abstract  token: 0x6000018
        public virtual System.Void pauseBeatV2() { }
        // RVA: -1  // abstract  token: 0x6000019
        public virtual System.Void resumeBeatV2() { }
        // RVA: -1  // abstract  token: 0x600001A
        public virtual System.Boolean userLoginEventV2(System.String userId, System.String properties) { }
        // RVA: -1  // abstract  token: 0x600001B
        public virtual System.Void unsetUserV2() { }
        // RVA: -1  // abstract  token: 0x600001C
        public virtual System.Boolean characterLoginEventV2(System.String characterId, System.String serverId, System.String properties) { }
        // RVA: -1  // abstract  token: 0x600001D
        public virtual System.Void unsetCharacterV2() { }
        // RVA: -1  // abstract  token: 0x600001E
        public virtual System.String getPresetPropertiesV2() { }
        // RVA: -1  // abstract  token: 0x600001F
        public virtual System.Void flushV2() { }
        // RVA: -1  // abstract  token: 0x6000020
        public virtual System.String getStaticPresetPropertiesV2() { }
        // RVA: -1  // abstract  token: 0x6000021
        public virtual System.String getDeviceIdPropertiesV2() { }
        // RVA: -1  // abstract  token: 0x6000022
        public virtual System.Boolean eventTrackV3(System.String appId, System.String name, System.String properties) { }

    }

    // TypeToken: 0x2000003  // size: 0x10
    public static class HGEventLogSDKBridge
    {
        // Fields
        private static Hypergryph.SDK.IEventLogSDK s_el;  // static @ 0x0

        // Properties
        Hypergryph.SDK.IEventLogSDK eventLogSdk { get; /* RVA: 0x0267F6E0 */ }

    }

    // TypeToken: 0x2000004  // size: 0x18
    public class HGEventLogSDKAppInstance : UnityEngine.MonoBehaviour
    {
        // Methods
        // RVA: 0x0886A688  token: 0x6000024
        public static System.Boolean SetEnvironment(System.String env) { }
        // RVA: 0x0886A6B4  token: 0x6000025
        public static System.Boolean SetGlobalProperties(System.String globalProperties) { }
        // RVA: 0x0886A7A0  token: 0x6000026
        public static System.Boolean UnsetGlobalProperties(System.String propertyKeys) { }
        // RVA: 0x0886A410  token: 0x6000027
        public static System.Void ClearGlobalProperties() { }
        // RVA: 0x0267F660  token: 0x6000028
        public static System.Boolean EventTrack(System.String name, System.String properties) { }
        // RVA: 0x0886A308  token: 0x6000029
        public static System.Boolean AppStartEvent(System.String channel1, System.String channel2, System.Boolean beat, System.String properties) { }
        // RVA: 0x0886A88C  token: 0x600002A
        public static System.Boolean UserLoginEvent(System.String userId, System.String properties) { }
        // RVA: 0x0886A81C  token: 0x600002B
        public static System.Void UnsetUser() { }
        // RVA: 0x0886A368  token: 0x600002C
        public static System.Boolean CharacterLoginEvent(System.String characterId, System.String serverId, System.String properties) { }
        // RVA: 0x0886A730  token: 0x600002D
        public static System.Void UnsetCharacter() { }
        // RVA: 0x0315A150  token: 0x600002E
        public static System.String GetPresetProperties() { }
        // RVA: 0x0886A640  token: 0x600002F
        public static System.Void PauseBeat() { }
        // RVA: 0x0886A664  token: 0x6000030
        public static System.Void ResumeBeat() { }
        // RVA: 0x0886A4AC  token: 0x6000031
        public static System.Void Flush() { }
        // RVA: 0x0886A480  token: 0x6000032
        public static System.Boolean EnableRealTimeSend(System.Boolean enable) { }
        // RVA: 0x0886A590  token: 0x6000033
        public static System.String GetStaticPresetProperties() { }
        // RVA: 0x0886A51C  token: 0x6000034
        public static System.String GetDeviceIdProperties() { }
        // RVA: 0x0886A604  token: 0x6000035
        private System.Void OnApplicationPause(System.Boolean pause) { }
        // RVA: 0x0426FE60  token: 0x6000036
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000005  // size: 0x10
    public class HGEventLogSDKInstance
    {
        // Methods
        // RVA: 0x03B340E0  token: 0x6000037
        public static System.Boolean init(System.String appId, System.String region) { }
        // RVA: 0x0886A920  token: 0x6000038
        public static System.Boolean EventTrackWithAppId(System.String appId, System.String name, System.String properties) { }

    }

    // TypeToken: 0x2000006  // size: 0x18
    public class HGEventLogSDKMgr : UnityEngine.MonoBehaviour
    {
        // Fields
        private static System.String appIdForInstance;  // static @ 0x0

        // Methods
        // RVA: 0x0886B1BC  token: 0x6000039
        public static System.Boolean SetEnvironment(System.String env) { }
        // RVA: 0x0886AFB8  token: 0x600003A
        public static System.Boolean Init(System.String appId, System.String regionTag) { }
        // RVA: 0x0886B220  token: 0x600003B
        public static System.Boolean SetGlobalProperties(System.String globalProperties) { }
        // RVA: 0x0886B3BC  token: 0x600003C
        public static System.Boolean UnsetGlobalProperties(System.String propertyKeys) { }
        // RVA: 0x0886AB00  token: 0x600003D
        public static System.Void ClearGlobalProperties() { }
        // RVA: 0x0886ABC0  token: 0x600003E
        public static System.Boolean EventTrack(System.String name, System.String properties) { }
        // RVA: 0x0886A9C8  token: 0x600003F
        public static System.Boolean AppStartEvent(System.String channel1, System.String channel2, System.Boolean beat, System.String properties) { }
        // RVA: 0x0886B558  token: 0x6000040
        public static System.Boolean UserLoginEvent(System.String userId, System.String properties) { }
        // RVA: 0x0886B498  token: 0x6000041
        public static System.Void UnsetUser() { }
        // RVA: 0x0886AA6C  token: 0x6000042
        public static System.Boolean CharacterLoginEvent(System.String characterId, System.String serverId, System.String properties) { }
        // RVA: 0x0886B2FC  token: 0x6000043
        public static System.Void UnsetCharacter() { }
        // RVA: 0x0886AE30  token: 0x6000044
        public static System.String GetPresetProperties() { }
        // RVA: 0x0886B0F4  token: 0x6000045
        public static System.Void PauseBeat() { }
        // RVA: 0x0886B158  token: 0x6000046
        public static System.Void ResumeBeat() { }
        // RVA: 0x0886ACAC  token: 0x6000047
        public static System.Void Flush() { }
        // RVA: 0x0886A480  token: 0x6000048
        public static System.Boolean EnableRealTimeSend(System.Boolean enable) { }
        // RVA: 0x0886AEF4  token: 0x6000049
        public static System.String GetStaticPresetProperties() { }
        // RVA: 0x0886AD6C  token: 0x600004A
        public static System.String GetDeviceIdProperties() { }
        // RVA: 0x0886B054  token: 0x600004B
        private System.Void OnApplicationPause(System.Boolean pause) { }
        // RVA: 0x0426FE60  token: 0x600004C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000007  // size: 0x10
    public class HGEventLogSDKPluginWindows : Hypergryph.SDK.IEventLogSDK
    {
        // Methods
        // RVA: 0x0886C0E8  token: 0x600004D
        private static System.Boolean EventLogSetEnvironment(System.String env) { }
        // RVA: 0x022C7D90  token: 0x600004E
        private static System.Boolean EventLogInitInstance(System.String appId, System.String regionTag) { }
        // RVA: 0x0886C1A0  token: 0x600004F
        private static System.Boolean EventLogSetGlobalProperties(System.String appId, System.String globalProperties) { }
        // RVA: 0x0886C38C  token: 0x6000050
        private static System.Boolean EventLogUnsetGlobalProperties(System.String appId, System.String propertyKeys) { }
        // RVA: 0x0886BBEC  token: 0x6000051
        private static System.Boolean EventLogClearGlobalProperties(System.String appId) { }
        // RVA: 0x0886BCC0  token: 0x6000052
        private static System.Boolean EventLogEvent(System.String appId, System.String name, System.String properties) { }
        // RVA: 0x0886B738  token: 0x6000053
        private static System.Boolean EventLogAppStartEvent(System.String appId, System.String channel1, System.String channel2, System.Boolean beat, System.String properties) { }
        // RVA: 0x0886B874  token: 0x6000054
        private static System.Boolean EventLogBeatPause(System.String appId) { }
        // RVA: 0x0886B938  token: 0x6000055
        private static System.Boolean EventLogBeatResume(System.String appId) { }
        // RVA: 0x0886C55C  token: 0x6000056
        private static System.Boolean EventLogUserLoginEvent(System.String appId, System.String userId, System.String properties) { }
        // RVA: 0x0886C478  token: 0x6000057
        private static System.Boolean EventLogUnsetUser(System.String appId) { }
        // RVA: 0x0886BAB4  token: 0x6000058
        private static System.Boolean EventLogCharacterLoginEvent(System.String appId, System.String characterId, System.String serverId, System.String properties) { }
        // RVA: 0x0886C294  token: 0x6000059
        private static System.Boolean EventLogUnsetCharacter(System.String appId) { }
        // RVA: 0x0886BF84  token: 0x600005A
        private static System.IntPtr EventLogGetPresetProperties(System.String appId) { }
        // RVA: 0x0886C050  token: 0x600005B
        private static System.IntPtr EventLogGetStaticPresetProperties(System.String appId) { }
        // RVA: 0x0886BEEC  token: 0x600005C
        private static System.IntPtr EventLogGetDeviceIdProperties(System.String appId) { }
        // RVA: 0x0886BC48  token: 0x600005D
        private static System.Boolean EventLogEnableRealTimeSend(System.Boolean enable) { }
        // RVA: 0x0886BE04  token: 0x600005E
        private static System.Void EventLogFlush(System.String appId) { }
        // RVA: 0x0315A340  token: 0x600005F
        private static System.Boolean EventLogFree(System.IntPtr buf) { }
        // RVA: 0x0886C2F0  token: 0x6000060
        private static System.Boolean EventLogUnsetGlobalPropertiesV2(System.String property_keys) { }
        // RVA: 0x0886C144  token: 0x6000061
        private static System.Boolean EventLogSetGlobalPropertiesV2(System.String global_properties) { }
        // RVA: 0x0886BBB8  token: 0x6000062
        private static System.Void EventLogClearGlobalPropertiesV2() { }
        // RVA: 0x022C7590  token: 0x6000063
        private static System.Boolean EventLogEventV2(System.String name, System.String json_str) { }
        // RVA: 0x0886B644  token: 0x6000064
        private static System.Boolean EventLogAppStartEventV2(System.String channel1, System.String channel2, System.Boolean beat, System.String json_str) { }
        // RVA: 0x0886B848  token: 0x6000065
        private static System.Void EventLogBeatPauseV2() { }
        // RVA: 0x0886B8D0  token: 0x6000066
        private static System.Void EventLogBeatResumeV2() { }
        // RVA: 0x0886C4D4  token: 0x6000067
        private static System.Boolean EventLogUserLoginEventV2(System.String user_id, System.String json_str) { }
        // RVA: 0x0886C44C  token: 0x6000068
        private static System.Void EventLogUnsetUserV2() { }
        // RVA: 0x0886B9D4  token: 0x6000069
        private static System.Boolean EventLogCharacterLoginEventV2(System.String character_id, System.String server_id, System.String json_str) { }
        // RVA: 0x0886C260  token: 0x600006A
        private static System.Void EventLogUnsetCharacterV2() { }
        // RVA: 0x0315A310  token: 0x600006B
        private static System.IntPtr EventLogGetPresetPropertiesV2() { }
        // RVA: 0x0886C01C  token: 0x600006C
        private static System.IntPtr EventLogGetStaticPresetPropertiesV2() { }
        // RVA: 0x0886BE84  token: 0x600006D
        private static System.IntPtr EventLogGetDeviceIdPropertiesV2() { }
        // RVA: 0x0886BD9C  token: 0x600006E
        private static System.Void EventLogFlushV2() { }
        // RVA: 0x0350B670  token: 0x600006F
        public System.Void .ctor() { }
        // RVA: 0x0886CF98  token: 0x6000070
        public virtual System.Boolean setEnvironment(System.String env) { }
        // RVA: 0x03B34190  token: 0x6000071
        public virtual System.Boolean init(System.String appId, System.String regionTag) { }
        // RVA: 0x0886D020  token: 0x6000072
        public virtual System.Boolean setGlobalProperties(System.String appId, System.String globalProperties) { }
        // RVA: 0x0886D134  token: 0x6000073
        public virtual System.Boolean unsetGlobalProperties(System.String appId, System.String propertyKeys) { }
        // RVA: 0x0886C7C4  token: 0x6000074
        public virtual System.Void clearGlobalProperties(System.String appId) { }
        // RVA: 0x0886C8CC  token: 0x6000075
        public virtual System.Boolean eventTrack(System.String appId, System.String name, System.String properties) { }
        // RVA: 0x0886C66C  token: 0x6000076
        public virtual System.Boolean appStartEvent(System.String appId, System.String channel1, System.String channel2, System.Boolean beat, System.String properties) { }
        // RVA: 0x0886CE98  token: 0x6000077
        public virtual System.Void pauseBeat(System.String appId) { }
        // RVA: 0x0886CF1C  token: 0x6000078
        public virtual System.Void resumeBeat(System.String appId) { }
        // RVA: 0x0886D250  token: 0x6000079
        public virtual System.Boolean userLoginEvent(System.String appId, System.String userId, System.String properties) { }
        // RVA: 0x0886D1C0  token: 0x600007A
        public virtual System.Void unsetUser(System.String appId) { }
        // RVA: 0x0886C724  token: 0x600007B
        public virtual System.Boolean characterLoginEvent(System.String appId, System.String characterId, System.String serverId, System.String properties) { }
        // RVA: 0x0886D0AC  token: 0x600007C
        public virtual System.Void unsetCharacter(System.String appId) { }
        // RVA: 0x0886CBBC  token: 0x600007D
        public virtual System.String getPresetProperties(System.String appId) { }
        // RVA: 0x0886CD9C  token: 0x600007E
        public virtual System.String getStaticPresetProperties(System.String appId) { }
        // RVA: 0x0886CAC8  token: 0x600007F
        public virtual System.String getDeviceIdProperties(System.String appId) { }
        // RVA: 0x0886C960  token: 0x6000080
        public virtual System.Void flush(System.String appId) { }
        // RVA: 0x0886C840  token: 0x6000081
        public virtual System.Boolean enableRealTimeSend(System.Boolean enable) { }
        // RVA: 0x0886D014  token: 0x6000082
        public virtual System.Boolean setGlobalPropertiesV2(System.String globalProperties) { }
        // RVA: 0x0886D128  token: 0x6000083
        public virtual System.Boolean unsetGlobalPropertiesV2(System.String propertyKeys) { }
        // RVA: 0x0886C7BC  token: 0x6000084
        public virtual System.Void clearGlobalPropertiesV2() { }
        // RVA: 0x04270FA4  token: 0x6000085
        public virtual System.Boolean eventTrackV2(System.String name, System.String properties) { }
        // RVA: 0x0886C63C  token: 0x6000086
        public virtual System.Boolean appStartEventV2(System.String channel1, System.String channel2, System.Boolean beat, System.String properties) { }
        // RVA: 0x0886CE90  token: 0x6000087
        public virtual System.Void pauseBeatV2() { }
        // RVA: 0x0886CF14  token: 0x6000088
        public virtual System.Void resumeBeatV2() { }
        // RVA: 0x0886D23C  token: 0x6000089
        public virtual System.Boolean userLoginEventV2(System.String userId, System.String properties) { }
        // RVA: 0x0886D1B8  token: 0x600008A
        public virtual System.Void unsetUserV2() { }
        // RVA: 0x0886C70C  token: 0x600008B
        public virtual System.Boolean characterLoginEventV2(System.String characterId, System.String serverId, System.String properties) { }
        // RVA: 0x0886D0A4  token: 0x600008C
        public virtual System.Void unsetCharacterV2() { }
        // RVA: 0x0315A1C0  token: 0x600008D
        public virtual System.String getPresetPropertiesV2() { }
        // RVA: 0x0886C958  token: 0x600008E
        public virtual System.Void flushV2() { }
        // RVA: 0x0886CCB0  token: 0x600008F
        public virtual System.String getStaticPresetPropertiesV2() { }
        // RVA: 0x0886C9DC  token: 0x6000090
        public virtual System.String getDeviceIdPropertiesV2() { }
        // RVA: 0x0886C8BC  token: 0x6000091
        public virtual System.Boolean eventTrackV3(System.String appId, System.String name, System.String properties) { }

    }

}

