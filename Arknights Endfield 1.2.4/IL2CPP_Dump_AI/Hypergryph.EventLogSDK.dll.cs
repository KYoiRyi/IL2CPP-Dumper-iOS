// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.EventLogSDK.dll
// Classes:  7
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: <Module>
TYPE:  class
TOKEN: 0x2000001
SIZE:  0x1
FIELDS:
METHODS:
END_CLASS

CLASS: Hypergryph.SDK.IEventLogSDK
TYPE:  interface
TOKEN: 0x2000002
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000001  System.Boolean setEnvironment(System.String env)
  RVA=-1  // abstract  token=0x6000002  System.Boolean enableRealTimeSend(System.Boolean enable)
  RVA=-1  // abstract  token=0x6000003  System.Boolean init(System.String appId, System.String regionTag)
  RVA=-1  // abstract  token=0x6000004  System.Boolean setGlobalProperties(System.String appId, System.String globalProperties)
  RVA=-1  // abstract  token=0x6000005  System.Boolean unsetGlobalProperties(System.String appId, System.String propertyKeys)
  RVA=-1  // abstract  token=0x6000006  System.Void clearGlobalProperties(System.String appId)
  RVA=-1  // abstract  token=0x6000007  System.Boolean eventTrack(System.String appId, System.String name, System.String properties)
  RVA=-1  // abstract  token=0x6000008  System.Boolean appStartEvent(System.String appId, System.String channel1, System.String channel2, System.Boolean beat, System.String properties)
  RVA=-1  // abstract  token=0x6000009  System.Void pauseBeat(System.String appId)
  RVA=-1  // abstract  token=0x600000A  System.Void resumeBeat(System.String appId)
  RVA=-1  // abstract  token=0x600000B  System.Boolean userLoginEvent(System.String appId, System.String userId, System.String properties)
  RVA=-1  // abstract  token=0x600000C  System.Void unsetUser(System.String appId)
  RVA=-1  // abstract  token=0x600000D  System.Boolean characterLoginEvent(System.String appId, System.String characterId, System.String serverId, System.String properties)
  RVA=-1  // abstract  token=0x600000E  System.Void unsetCharacter(System.String appId)
  RVA=-1  // abstract  token=0x600000F  System.String getPresetProperties(System.String appId)
  RVA=-1  // abstract  token=0x6000010  System.Void flush(System.String appId)
  RVA=-1  // abstract  token=0x6000011  System.String getStaticPresetProperties(System.String appId)
  RVA=-1  // abstract  token=0x6000012  System.String getDeviceIdProperties(System.String appId)
  RVA=-1  // abstract  token=0x6000013  System.Boolean setGlobalPropertiesV2(System.String globalProperties)
  RVA=-1  // abstract  token=0x6000014  System.Boolean unsetGlobalPropertiesV2(System.String propertyKeys)
  RVA=-1  // abstract  token=0x6000015  System.Void clearGlobalPropertiesV2()
  RVA=-1  // abstract  token=0x6000016  System.Boolean eventTrackV2(System.String name, System.String properties)
  RVA=-1  // abstract  token=0x6000017  System.Boolean appStartEventV2(System.String channel1, System.String channel2, System.Boolean beat, System.String properties)
  RVA=-1  // abstract  token=0x6000018  System.Void pauseBeatV2()
  RVA=-1  // abstract  token=0x6000019  System.Void resumeBeatV2()
  RVA=-1  // abstract  token=0x600001A  System.Boolean userLoginEventV2(System.String userId, System.String properties)
  RVA=-1  // abstract  token=0x600001B  System.Void unsetUserV2()
  RVA=-1  // abstract  token=0x600001C  System.Boolean characterLoginEventV2(System.String characterId, System.String serverId, System.String properties)
  RVA=-1  // abstract  token=0x600001D  System.Void unsetCharacterV2()
  RVA=-1  // abstract  token=0x600001E  System.String getPresetPropertiesV2()
  RVA=-1  // abstract  token=0x600001F  System.Void flushV2()
  RVA=-1  // abstract  token=0x6000020  System.String getStaticPresetPropertiesV2()
  RVA=-1  // abstract  token=0x6000021  System.String getDeviceIdPropertiesV2()
  RVA=-1  // abstract  token=0x6000022  System.Boolean eventTrackV3(System.String appId, System.String name, System.String properties)
END_CLASS

CLASS: Hypergryph.SDK.HGEventLogSDKBridge
TYPE:  static class
TOKEN: 0x2000003
SIZE:  0x10
FIELDS:
  private   static  Hypergryph.SDK.IEventLogSDK     s_el  // static @ 0x0
PROPERTIES:
  eventLogSdk  get=0x0267F6E0
METHODS:
END_CLASS

CLASS: Hypergryph.SDK.HGEventLogSDKAppInstance
TYPE:  class
TOKEN: 0x2000004
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
METHODS:
  RVA=0x0886A688  token=0x6000024  System.Boolean SetEnvironment(System.String env)
  RVA=0x0886A6B4  token=0x6000025  System.Boolean SetGlobalProperties(System.String globalProperties)
  RVA=0x0886A7A0  token=0x6000026  System.Boolean UnsetGlobalProperties(System.String propertyKeys)
  RVA=0x0886A410  token=0x6000027  System.Void ClearGlobalProperties()
  RVA=0x0267F660  token=0x6000028  System.Boolean EventTrack(System.String name, System.String properties)
  RVA=0x0886A308  token=0x6000029  System.Boolean AppStartEvent(System.String channel1, System.String channel2, System.Boolean beat, System.String properties)
  RVA=0x0886A88C  token=0x600002A  System.Boolean UserLoginEvent(System.String userId, System.String properties)
  RVA=0x0886A81C  token=0x600002B  System.Void UnsetUser()
  RVA=0x0886A368  token=0x600002C  System.Boolean CharacterLoginEvent(System.String characterId, System.String serverId, System.String properties)
  RVA=0x0886A730  token=0x600002D  System.Void UnsetCharacter()
  RVA=0x0315A150  token=0x600002E  System.String GetPresetProperties()
  RVA=0x0886A640  token=0x600002F  System.Void PauseBeat()
  RVA=0x0886A664  token=0x6000030  System.Void ResumeBeat()
  RVA=0x0886A4AC  token=0x6000031  System.Void Flush()
  RVA=0x0886A480  token=0x6000032  System.Boolean EnableRealTimeSend(System.Boolean enable)
  RVA=0x0886A590  token=0x6000033  System.String GetStaticPresetProperties()
  RVA=0x0886A51C  token=0x6000034  System.String GetDeviceIdProperties()
  RVA=0x0886A604  token=0x6000035  System.Void OnApplicationPause(System.Boolean pause)
  RVA=0x0426FE60  token=0x6000036  System.Void .ctor()
END_CLASS

CLASS: Hypergryph.SDK.HGEventLogSDKInstance
TYPE:  class
TOKEN: 0x2000005
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x03B340E0  token=0x6000037  System.Boolean init(System.String appId, System.String region)
  RVA=0x0886A920  token=0x6000038  System.Boolean EventTrackWithAppId(System.String appId, System.String name, System.String properties)
END_CLASS

CLASS: Hypergryph.SDK.HGEventLogSDKMgr
TYPE:  class
TOKEN: 0x2000006
SIZE:  0x18
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static  System.String                   appIdForInstance  // static @ 0x0
METHODS:
  RVA=0x0886B1BC  token=0x6000039  System.Boolean SetEnvironment(System.String env)
  RVA=0x0886AFB8  token=0x600003A  System.Boolean Init(System.String appId, System.String regionTag)
  RVA=0x0886B220  token=0x600003B  System.Boolean SetGlobalProperties(System.String globalProperties)
  RVA=0x0886B3BC  token=0x600003C  System.Boolean UnsetGlobalProperties(System.String propertyKeys)
  RVA=0x0886AB00  token=0x600003D  System.Void ClearGlobalProperties()
  RVA=0x0886ABC0  token=0x600003E  System.Boolean EventTrack(System.String name, System.String properties)
  RVA=0x0886A9C8  token=0x600003F  System.Boolean AppStartEvent(System.String channel1, System.String channel2, System.Boolean beat, System.String properties)
  RVA=0x0886B558  token=0x6000040  System.Boolean UserLoginEvent(System.String userId, System.String properties)
  RVA=0x0886B498  token=0x6000041  System.Void UnsetUser()
  RVA=0x0886AA6C  token=0x6000042  System.Boolean CharacterLoginEvent(System.String characterId, System.String serverId, System.String properties)
  RVA=0x0886B2FC  token=0x6000043  System.Void UnsetCharacter()
  RVA=0x0886AE30  token=0x6000044  System.String GetPresetProperties()
  RVA=0x0886B0F4  token=0x6000045  System.Void PauseBeat()
  RVA=0x0886B158  token=0x6000046  System.Void ResumeBeat()
  RVA=0x0886ACAC  token=0x6000047  System.Void Flush()
  RVA=0x0886A480  token=0x6000048  System.Boolean EnableRealTimeSend(System.Boolean enable)
  RVA=0x0886AEF4  token=0x6000049  System.String GetStaticPresetProperties()
  RVA=0x0886AD6C  token=0x600004A  System.String GetDeviceIdProperties()
  RVA=0x0886B054  token=0x600004B  System.Void OnApplicationPause(System.Boolean pause)
  RVA=0x0426FE60  token=0x600004C  System.Void .ctor()
END_CLASS

CLASS: Hypergryph.SDK.HGEventLogSDKPluginWindows
TYPE:  class
TOKEN: 0x2000007
SIZE:  0x10
IMPLEMENTS: Hypergryph.SDK.IEventLogSDK
FIELDS:
METHODS:
  RVA=0x0886C0E8  token=0x600004D  System.Boolean EventLogSetEnvironment(System.String env)
  RVA=0x022C7D90  token=0x600004E  System.Boolean EventLogInitInstance(System.String appId, System.String regionTag)
  RVA=0x0886C1A0  token=0x600004F  System.Boolean EventLogSetGlobalProperties(System.String appId, System.String globalProperties)
  RVA=0x0886C38C  token=0x6000050  System.Boolean EventLogUnsetGlobalProperties(System.String appId, System.String propertyKeys)
  RVA=0x0886BBEC  token=0x6000051  System.Boolean EventLogClearGlobalProperties(System.String appId)
  RVA=0x0886BCC0  token=0x6000052  System.Boolean EventLogEvent(System.String appId, System.String name, System.String properties)
  RVA=0x0886B738  token=0x6000053  System.Boolean EventLogAppStartEvent(System.String appId, System.String channel1, System.String channel2, System.Boolean beat, System.String properties)
  RVA=0x0886B874  token=0x6000054  System.Boolean EventLogBeatPause(System.String appId)
  RVA=0x0886B938  token=0x6000055  System.Boolean EventLogBeatResume(System.String appId)
  RVA=0x0886C55C  token=0x6000056  System.Boolean EventLogUserLoginEvent(System.String appId, System.String userId, System.String properties)
  RVA=0x0886C478  token=0x6000057  System.Boolean EventLogUnsetUser(System.String appId)
  RVA=0x0886BAB4  token=0x6000058  System.Boolean EventLogCharacterLoginEvent(System.String appId, System.String characterId, System.String serverId, System.String properties)
  RVA=0x0886C294  token=0x6000059  System.Boolean EventLogUnsetCharacter(System.String appId)
  RVA=0x0886BF84  token=0x600005A  System.IntPtr EventLogGetPresetProperties(System.String appId)
  RVA=0x0886C050  token=0x600005B  System.IntPtr EventLogGetStaticPresetProperties(System.String appId)
  RVA=0x0886BEEC  token=0x600005C  System.IntPtr EventLogGetDeviceIdProperties(System.String appId)
  RVA=0x0886BC48  token=0x600005D  System.Boolean EventLogEnableRealTimeSend(System.Boolean enable)
  RVA=0x0886BE04  token=0x600005E  System.Void EventLogFlush(System.String appId)
  RVA=0x0315A340  token=0x600005F  System.Boolean EventLogFree(System.IntPtr buf)
  RVA=0x0886C2F0  token=0x6000060  System.Boolean EventLogUnsetGlobalPropertiesV2(System.String property_keys)
  RVA=0x0886C144  token=0x6000061  System.Boolean EventLogSetGlobalPropertiesV2(System.String global_properties)
  RVA=0x0886BBB8  token=0x6000062  System.Void EventLogClearGlobalPropertiesV2()
  RVA=0x022C7590  token=0x6000063  System.Boolean EventLogEventV2(System.String name, System.String json_str)
  RVA=0x0886B644  token=0x6000064  System.Boolean EventLogAppStartEventV2(System.String channel1, System.String channel2, System.Boolean beat, System.String json_str)
  RVA=0x0886B848  token=0x6000065  System.Void EventLogBeatPauseV2()
  RVA=0x0886B8D0  token=0x6000066  System.Void EventLogBeatResumeV2()
  RVA=0x0886C4D4  token=0x6000067  System.Boolean EventLogUserLoginEventV2(System.String user_id, System.String json_str)
  RVA=0x0886C44C  token=0x6000068  System.Void EventLogUnsetUserV2()
  RVA=0x0886B9D4  token=0x6000069  System.Boolean EventLogCharacterLoginEventV2(System.String character_id, System.String server_id, System.String json_str)
  RVA=0x0886C260  token=0x600006A  System.Void EventLogUnsetCharacterV2()
  RVA=0x0315A310  token=0x600006B  System.IntPtr EventLogGetPresetPropertiesV2()
  RVA=0x0886C01C  token=0x600006C  System.IntPtr EventLogGetStaticPresetPropertiesV2()
  RVA=0x0886BE84  token=0x600006D  System.IntPtr EventLogGetDeviceIdPropertiesV2()
  RVA=0x0886BD9C  token=0x600006E  System.Void EventLogFlushV2()
  RVA=0x0350B670  token=0x600006F  System.Void .ctor()
  RVA=0x0886CF98  token=0x6000070  System.Boolean setEnvironment(System.String env)
  RVA=0x03B34190  token=0x6000071  System.Boolean init(System.String appId, System.String regionTag)
  RVA=0x0886D020  token=0x6000072  System.Boolean setGlobalProperties(System.String appId, System.String globalProperties)
  RVA=0x0886D134  token=0x6000073  System.Boolean unsetGlobalProperties(System.String appId, System.String propertyKeys)
  RVA=0x0886C7C4  token=0x6000074  System.Void clearGlobalProperties(System.String appId)
  RVA=0x0886C8CC  token=0x6000075  System.Boolean eventTrack(System.String appId, System.String name, System.String properties)
  RVA=0x0886C66C  token=0x6000076  System.Boolean appStartEvent(System.String appId, System.String channel1, System.String channel2, System.Boolean beat, System.String properties)
  RVA=0x0886CE98  token=0x6000077  System.Void pauseBeat(System.String appId)
  RVA=0x0886CF1C  token=0x6000078  System.Void resumeBeat(System.String appId)
  RVA=0x0886D250  token=0x6000079  System.Boolean userLoginEvent(System.String appId, System.String userId, System.String properties)
  RVA=0x0886D1C0  token=0x600007A  System.Void unsetUser(System.String appId)
  RVA=0x0886C724  token=0x600007B  System.Boolean characterLoginEvent(System.String appId, System.String characterId, System.String serverId, System.String properties)
  RVA=0x0886D0AC  token=0x600007C  System.Void unsetCharacter(System.String appId)
  RVA=0x0886CBBC  token=0x600007D  System.String getPresetProperties(System.String appId)
  RVA=0x0886CD9C  token=0x600007E  System.String getStaticPresetProperties(System.String appId)
  RVA=0x0886CAC8  token=0x600007F  System.String getDeviceIdProperties(System.String appId)
  RVA=0x0886C960  token=0x6000080  System.Void flush(System.String appId)
  RVA=0x0886C840  token=0x6000081  System.Boolean enableRealTimeSend(System.Boolean enable)
  RVA=0x0886D014  token=0x6000082  System.Boolean setGlobalPropertiesV2(System.String globalProperties)
  RVA=0x0886D128  token=0x6000083  System.Boolean unsetGlobalPropertiesV2(System.String propertyKeys)
  RVA=0x0886C7BC  token=0x6000084  System.Void clearGlobalPropertiesV2()
  RVA=0x04270FA4  token=0x6000085  System.Boolean eventTrackV2(System.String name, System.String properties)
  RVA=0x0886C63C  token=0x6000086  System.Boolean appStartEventV2(System.String channel1, System.String channel2, System.Boolean beat, System.String properties)
  RVA=0x0886CE90  token=0x6000087  System.Void pauseBeatV2()
  RVA=0x0886CF14  token=0x6000088  System.Void resumeBeatV2()
  RVA=0x0886D23C  token=0x6000089  System.Boolean userLoginEventV2(System.String userId, System.String properties)
  RVA=0x0886D1B8  token=0x600008A  System.Void unsetUserV2()
  RVA=0x0886C70C  token=0x600008B  System.Boolean characterLoginEventV2(System.String characterId, System.String serverId, System.String properties)
  RVA=0x0886D0A4  token=0x600008C  System.Void unsetCharacterV2()
  RVA=0x0315A1C0  token=0x600008D  System.String getPresetPropertiesV2()
  RVA=0x0886C958  token=0x600008E  System.Void flushV2()
  RVA=0x0886CCB0  token=0x600008F  System.String getStaticPresetPropertiesV2()
  RVA=0x0886C9DC  token=0x6000090  System.String getDeviceIdPropertiesV2()
  RVA=0x0886C8BC  token=0x6000091  System.Boolean eventTrackV3(System.String appId, System.String name, System.String properties)
END_CLASS

