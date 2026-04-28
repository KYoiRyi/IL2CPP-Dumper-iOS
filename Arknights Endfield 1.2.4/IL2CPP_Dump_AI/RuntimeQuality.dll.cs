// ========================================================
// Dumped by @desirepro
// Assembly: RuntimeQuality.dll
// Classes:  91
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

CLASS: MatchType
TYPE:  sealed struct
TOKEN: 0x200000D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.DeviceInfo.MatchTypeWhiteList  // const
  public    static  Beyond.Scripts.Quality.DeviceInfo.MatchTypeSystemVersion  // const
  public    static  Beyond.Scripts.Quality.DeviceInfo.MatchTypeGPU  // const
  public    static  Beyond.Scripts.Quality.DeviceInfo.MatchTypeCPU  // const
  public    static  Beyond.Scripts.Quality.DeviceInfo.MatchTypeDefaultScore  // const
  public    static  Beyond.Scripts.Quality.DeviceInfo.MatchTypeMemoryCorrection  // const
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000017
SIZE:  0x10
FIELDS:
  public    static readonly Beyond.Scripts.Quality.QualityManager.<>c<>9  // static @ 0x0
  public    static  System.Func<Beyond.Scripts.Quality.Components.QualityTierLevel,System.Int32><>9__29_0  // static @ 0x8
  public    static  System.Func<Beyond.Scripts.Quality.Components.QualityTierComponentMatch,System.Int32><>9__30_0  // static @ 0x10
  public    static  System.Func<Beyond.Scripts.Quality.DeviceQualityMapItem,System.Int32><>9__31_0  // static @ 0x18
  public    static  System.Func<Beyond.Scripts.Quality.DeviceQualityMapItem,System.Int32><>9__32_0  // static @ 0x20
  public    static  System.Comparison<System.Int32> <>9__66_0  // static @ 0x28
  public    static  System.Comparison<System.Int32> <>9__67_0  // static @ 0x30
  public    static  System.Comparison<System.Int32> <>9__68_0  // static @ 0x38
  public    static  System.Comparison<Beyond.Scripts.Quality.Components.QualityTierComponentMatch><>9__70_0  // static @ 0x40
METHODS:
  RVA=0x03D18350  token=0x600007C  System.Void .cctor()
  RVA=0x0350B670  token=0x600007D  System.Void .ctor()
  RVA=0x03C90770  token=0x600007E  System.Int32 <LoadQualityTier>b__29_0(Beyond.Scripts.Quality.Components.QualityTierLevel s)
  RVA=0x038960E0  token=0x600007F  System.Int32 <setQualityTier>b__30_0(Beyond.Scripts.Quality.Components.QualityTierComponentMatch x)
  RVA=0x03D60790  token=0x6000080  System.Int32 <ApplyQualityScore>b__31_0(Beyond.Scripts.Quality.DeviceQualityMapItem s)
  RVA=0x03D60790  token=0x6000081  System.Int32 <ApplyShaderTier>b__32_0(Beyond.Scripts.Quality.DeviceQualityMapItem s)
  RVA=0x096669D8  token=0x6000082  System.Int32 <GetQualityComponentDefaultTier>b__66_0(System.Int32 a, System.Int32 b)
  RVA=0x096669D8  token=0x6000083  System.Int32 <GetQualityComponentTier>b__67_0(System.Int32 a, System.Int32 b)
  RVA=0x096669D8  token=0x6000084  System.Int32 <SetQualityComponentTier>b__68_0(System.Int32 a, System.Int32 b)
  RVA=0x096669F4  token=0x6000085  System.Int32 <_GetCurrentComponentTierIndex>b__70_0(Beyond.Scripts.Quality.Components.QualityTierComponentMatch a, Beyond.Scripts.Quality.Components.QualityTierComponentMatch b)
END_CLASS

CLASS: AntiAliasing
TYPE:  sealed struct
TOKEN: 0x200001A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.AntiAliasingQuality.AntiAliasingNone  // const
  public    static  Beyond.Scripts.Quality.Components.AntiAliasingQuality.AntiAliasingCSAA  // const
  public    static  Beyond.Scripts.Quality.Components.AntiAliasingQuality.AntiAliasingFXAA  // const
  public    static  Beyond.Scripts.Quality.Components.AntiAliasingQuality.AntiAliasingMSAA  // const
METHODS:
END_CLASS

CLASS: MatchSource
TYPE:  sealed struct
TOKEN: 0x2000021
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSourceUpClosest  // const
  public    static  Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSourceDownClosest  // const
  public    static  Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSourceMatched  // const
  public    static  Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSourceOverride  // const
METHODS:
END_CLASS

CLASS: DLSSFrameGenQualityEnum
TYPE:  sealed struct
TOKEN: 0x2000028
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.DLSSFrameGenQuality.DLSSFrameGenQualityEnumAuto  // const
  public    static  Beyond.Scripts.Quality.Components.DLSSFrameGenQuality.DLSSFrameGenQualityEnumX1  // const
  public    static  Beyond.Scripts.Quality.Components.DLSSFrameGenQuality.DLSSFrameGenQualityEnumX2  // const
  public    static  Beyond.Scripts.Quality.Components.DLSSFrameGenQuality.DLSSFrameGenQualityEnumX3  // const
METHODS:
END_CLASS

CLASS: FrameGenMode
TYPE:  sealed struct
TOKEN: 0x200002C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.FrameGenQuality.FrameGenModeNone  // const
  public    static  Beyond.Scripts.Quality.Components.FrameGenQuality.FrameGenModeDLSS  // const
METHODS:
END_CLASS

CLASS: FrameRateQualityEnum
TYPE:  sealed struct
TOKEN: 0x200002F
SIZE:  0x11
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnumFPS120  // const
  public    static  Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnumFPS60  // const
  public    static  Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnumFPS30  // const
METHODS:
END_CLASS

CLASS: ReasonEnum
TYPE:  sealed struct
TOKEN: 0x2000031
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnumDefault  // const
  public    static  Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnumInit  // const
  public    static  Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnumQuality  // const
  public    static  Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnumDialog  // const
  public    static  Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnumCutscene  // const
  public    static  Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnumGMCommand  // const
METHODS:
END_CLASS

CLASS: FrameRateQualityMobileEnum
TYPE:  sealed struct
TOKEN: 0x2000033
SIZE:  0x11
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnumFPS60  // const
  public    static  Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnumFPS45  // const
  public    static  Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnumFPS30  // const
METHODS:
END_CLASS

CLASS: HGAnisoLevel
TYPE:  sealed struct
TOKEN: 0x2000038
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.HGAnisoLevelQuality.HGAnisoLevelX1  // const
  public    static  Beyond.Scripts.Quality.Components.HGAnisoLevelQuality.HGAnisoLevelX2  // const
  public    static  Beyond.Scripts.Quality.Components.HGAnisoLevelQuality.HGAnisoLevelX4  // const
  public    static  Beyond.Scripts.Quality.Components.HGAnisoLevelQuality.HGAnisoLevelX8  // const
METHODS:
END_CLASS

CLASS: TextureQualityEnum
TYPE:  sealed struct
TOKEN: 0x2000041
SIZE:  0x11
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.HGTextureQuality.TextureQualityEnumHigh  // const
  public    static  Beyond.Scripts.Quality.Components.HGTextureQuality.TextureQualityEnumMedium  // const
  public    static  Beyond.Scripts.Quality.Components.HGTextureQuality.TextureQualityEnumLow  // const
METHODS:
END_CLASS

CLASS: RenderingScaleMode
TYPE:  sealed struct
TOKEN: 0x200004A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleModeExHigh  // const
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleModeHigh  // const
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleModeMedium  // const
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleModeLow  // const
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleModeExLow  // const
METHODS:
END_CLASS

CLASS: RenderingScaleMode
TYPE:  sealed struct
TOKEN: 0x200004C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleModePercent100  // const
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleModePercent90  // const
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleModePercent80  // const
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleModePercent70  // const
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleModePercent60  // const
METHODS:
END_CLASS

CLASS: ShaderLodEnum
TYPE:  sealed struct
TOKEN: 0x2000050
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnumPC600  // const
  public    static  Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnumMobile500  // const
  public    static  Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnumMobile400  // const
  public    static  Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnumMobile300  // const
  public    static  Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnumMobile200  // const
  public    static  Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnumMobile100  // const
METHODS:
END_CLASS

CLASS: UpscalerMode
TYPE:  sealed struct
TOKEN: 0x2000055
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.UpscalerQuality.UpscalerModeDLSS  // const
  public    static  Beyond.Scripts.Quality.Components.UpscalerQuality.UpscalerModeTAAU  // const
  public    static  Beyond.Scripts.Quality.Components.UpscalerQuality.UpscalerModeFSR3  // const
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.BeyondPerformance.LogicQualityLevel
TYPE:  sealed struct
TOKEN: 0x2000009
SIZE:  0x11
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Gameplay.BeyondPerformance.LogicQualityLevelEconomy  // const
  public    static  Beyond.Gameplay.BeyondPerformance.LogicQualityLevelBalanced  // const
  public    static  Beyond.Gameplay.BeyondPerformance.LogicQualityLevelPerformance  // const
  public    static  Beyond.Gameplay.BeyondPerformance.LogicQualityLevelMax  // const
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.BeyondPerformance.ThermalState
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x11
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Gameplay.BeyondPerformance.ThermalStateGameNormal  // const
  public    static  Beyond.Gameplay.BeyondPerformance.ThermalStateGameFair  // const
  public    static  Beyond.Gameplay.BeyondPerformance.ThermalStateGameSerious  // const
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.BeyondPerformance.LogicQualityConst
TYPE:  static class
TOKEN: 0x200000B
SIZE:  0x10
FIELDS:
  public    static  System.Single                   s_reduceQualityLevelFPSThresholdRatio  // static @ 0x0
  public    static  System.Single                   s_recoverQualityLevelFPSThresholdRatio  // static @ 0x4
METHODS:
  RVA=0x03D2C030  token=0x6000009  System.Void .cctor()
END_CLASS

CLASS: Beyond.PoolCore.ListPoolInitializer_RuntimeQuality
TYPE:  static class
TOKEN: 0x2000003
SIZE:  0x10
FIELDS:
  private   static  System.Boolean                  s_initialized  // static @ 0x0
METHODS:
  RVA=0x03CB2BE0  token=0x6000002  System.Void InitializeAtRuntime()
  RVA=0x03CB2C10  token=0x6000003  System.Void Initialize()
END_CLASS

CLASS: Beyond.Scripts.Quality.DeviceInfo
TYPE:  class
TOKEN: 0x200000C
SIZE:  0x88
FIELDS:
  public            UnityEngine.RuntimePlatform     m_platform  // 0x10
  private           System.Int32                    <DevicesScore>k__BackingField  // 0x14
  public    readonly System.String                   m_deviceModel  // 0x18
  public    readonly System.String                   m_deviceName  // 0x20
  public    readonly System.String                   m_graphicsDeviceName  // 0x28
  public    readonly System.String                   m_graphicsDeviceVersion  // 0x30
  public    readonly System.String                   m_cpuDeviceName  // 0x38
  public    readonly System.Int32                    m_systemMemorySize  // 0x40
  public    readonly System.Int32                    m_GPUMemorySize  // 0x44
  public    readonly System.Int32                    m_processorCount  // 0x48
  public    readonly UnityEngine.Rendering.GraphicsDeviceTypem_graphicsDeviceType  // 0x4c
  public            Beyond.Scripts.Quality.DeviceMatchRulesm_matchRules  // 0x50
  public            Beyond.Scripts.Quality.DeviceMatchResultm_matchResult  // 0x58
  public            System.Boolean                  bEditorSimulator  // 0x78
  public    readonly System.String                   m_SystemInfo  // 0x80
  private   static  System.String                   ADRENO_KEY  // const
  private   static  System.String                   ADRENO_PATTERN  // const
  private   static  System.String                   ADRENO_STANDARD_FORMAT  // const
  private   static  System.String                   MALI_KEY  // const
  private   static  System.String                   MALI_PATTERN  // const
  private   static  System.String                   MALI_STANDARD_FORMAT  // const
  private   static  System.String                   POWER_VR_KEY  // const
  private   static  System.String                   POWER_VR_PATTERN  // const
  private   static  System.String                   POWER_VR_STANDARD_FORMAT  // const
  private   static  System.String                   NVIDIA_KEY  // const
  private   static  System.String                   NVIDIA_PATTERN  // const
  private   static  System.String                   NVIDIA_STANDARD_FORMAT  // const
  private   static  System.String                   TITAN_PATTERN  // const
  private   static  System.String                   NVIDIA_FALLBACK  // const
  private   static  System.String                   AMD_KEY  // const
  private   static  System.String                   AMD_PATTERN  // const
  private   static  System.String                   AMD_STANDARD_FORMAT  // const
  private   static  System.String                   AMD_FALLBACK  // const
  private   static  System.String                   INTEL_KEY  // const
  private   static  System.String                   INTEL_PATTERN  // const
  private   static  System.String                   INTEL_STANDARD_FORMAT  // const
  private   static  System.String                   INTEL_PATTERN_2  // const
  private   static  System.String                   INTEL_FALLBACK  // const
PROPERTIES:
  DevicesScore  get=0x03D50CC0  set=0x03D595B0
  cpuName  get=0x04273158
METHODS:
  RVA=0x02CDA040  token=0x600000C  System.Void .ctor(System.String remoteJson)
  RVA=0x0965EAD4  token=0x600000D  System.Void .ctor(UnityEngine.RuntimePlatform platform, System.String deviceName, System.String deviceModel, System.String graphicsDeviceName, System.String graphicsDeviceVersion, System.String systemMemorySize, System.String processorName, System.String processorCount, System.String processorFrequency)
  RVA=0x02CDC4F0  token=0x600000E  System.Void SupplementFromRemote(System.String json)
  RVA=0x0363B2A0  token=0x600000F  System.String ToString()
  RVA=0x0965E248  token=0x6000010  System.Boolean IsNoMatchDevice()
  RVA=0x03B315F0  token=0x6000011  System.Boolean IsZeroDevices()
  RVA=0x0965E18C  token=0x6000013  System.Boolean IsHUAWEIDevice()
  RVA=0x0965E2A4  token=0x6000014  System.Boolean IsQualcommDevice()
  RVA=0x02CDBF90  token=0x6000015  Beyond.Scripts.Quality.DeviceMatchRules LoadingSettingRules()
  RVA=0x02CDBF20  token=0x6000016  System.Int32 GetDeviceScore(System.String remoteJson)
  RVA=0x0965D380  token=0x6000017  System.Int32 EditorSimulateGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo)
  RVA=0x0965DE4C  token=0x6000018  System.Int32 IOSGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo)
  RVA=0x0965D184  token=0x6000019  System.Int32 AndroidGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo)
  RVA=0x02CDC020  token=0x600001A  System.Int32 StandaloneGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo)
  RVA=0x0965E804  token=0x600001B  System.Int32 StandaloneOSXGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo)
  RVA=0x0965E858  token=0x600001C  System.Int32 StandalonePS5GetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo)
  RVA=0x0965D32C  token=0x600001D  System.Int32 DefaultGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo)
  RVA=0x02CDCF70  token=0x600001E  System.Boolean RuleSuffixMatch(System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> list, System.String name, Beyond.Scripts.Quality.RankingRule& matchedRule)
  RVA=0x0965E624  token=0x600001F  System.Boolean RuleFullNameMatch(System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> list, System.String name, Beyond.Scripts.Quality.RankingRule& matchedRule)
  RVA=0x0965E328  token=0x6000020  System.Boolean MatchDeviceModeRule(System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> list, System.String deviceModel, Beyond.Scripts.Quality.RankingRule& rule)
  RVA=0x0965E3D0  token=0x6000021  System.Boolean MatchGPURule(Beyond.Scripts.Quality.DeviceMatchRules rules, System.String gpu, Beyond.Scripts.Quality.RankingRule& rule, System.String& standardName)
  RVA=0x02CDC5A0  token=0x6000022  System.Boolean StandaloneMatchGPURule(Beyond.Scripts.Quality.DeviceMatchRules rules, System.String gpu, Beyond.Scripts.Quality.RankingRule& rule, System.String& standardName)
  RVA=0x0965DAC8  token=0x6000023  System.String GetNvidiaStandardGPUName(System.String gpu)
  RVA=0x02CDC720  token=0x6000024  System.String GetAmdStandardGPUName(System.String gpu)
  RVA=0x0965D580  token=0x6000025  System.String GetIntelStandardGPUName(System.String gpu)
  RVA=0x0965D444  token=0x6000026  System.String GetAdrenoStandardGPUName(System.String gpu)
  RVA=0x0965D7E0  token=0x6000027  System.String GetMaliStandardGPUName(System.String gpu)
  RVA=0x0965DD10  token=0x6000028  System.String GetPowerVRStandardGPUName(System.String gpu)
  RVA=0x0965E908  token=0x6000029  System.Void _ReportMatchRuleFailed(Beyond.Scripts.Quality.DeviceInfo deviceModel)
  RVA=0x05459F38  token=0x600002A  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Scripts.Quality.RankingRule
TYPE:  sealed struct
TOKEN: 0x200000E
SIZE:  0x20
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            System.String                   regexPattern  // 0x10
  public            System.Int32                    targetScore  // 0x18
METHODS:
  RVA=0x02AB5050  token=0x600002B  System.Boolean Equals(Beyond.Scripts.Quality.RankingRule other)
  RVA=0x0363B7D0  token=0x600002C  System.String ToString()
  RVA=0x09665EAC  token=0x600002D  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Scripts.Quality.MemoryRule
TYPE:  sealed struct
TOKEN: 0x200000F
SIZE:  0x1C
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            UnityEngine.Vector2             range  // 0x10
  public            System.Int32                    targetScore  // 0x18
METHODS:
  RVA=0x09662A4C  token=0x600002E  System.String ToString()
  RVA=0x096629DC  token=0x600002F  System.Boolean Equals(Beyond.Scripts.Quality.MemoryRule other)
  RVA=0x09662B18  token=0x6000030  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Scripts.Quality.ListUtils
TYPE:  static class
TOKEN: 0x2000010
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000031  System.Void AddOrReplace(System.Collections.Generic.List<TItem> source, System.Collections.Generic.List<TItem> remote)
END_CLASS

CLASS: Beyond.Scripts.Quality.DeviceMatchRules
TYPE:  class
TOKEN: 0x2000011
SIZE:  0x98
FIELDS:
  public            System.Int32                    DefaultIOSRankingRule  // 0x10
  public            System.Int32                    DefaultAndroidScore  // 0x14
  public            System.Int32                    DefaultStandAloneScore  // 0x18
  public            System.Int32                    DefaultPowerVRScore  // 0x1c
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>appleWhiteList  // 0x20
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>appleGPUList  // 0x28
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>androidWhiteList  // 0x30
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>adrenoRulesList  // 0x38
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>maliRulesList  // 0x40
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>powerVRRulesList  // 0x48
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>androidGPUWhiteList  // 0x50
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>androidCPUWhiteList  // 0x58
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.MemoryRule>iOSMemoryRules  // 0x60
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.MemoryRule>androidMemoryRules  // 0x68
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>nvidiaRulesList  // 0x70
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>amdRulesList  // 0x78
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>intelRulesList  // 0x80
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.MemoryRule>standaloneMemoryRules  // 0x88
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>macSocRulesList  // 0x90
METHODS:
  RVA=0x02CDD7A0  token=0x6000032  System.Void Combine(Beyond.Scripts.Quality.DeviceMatchRules other)
  RVA=0x03D23720  token=0x6000033  System.Void .ctor()
END_CLASS

CLASS: Beyond.Scripts.Quality.DeviceMatchResult
TYPE:  sealed struct
TOKEN: 0x2000012
SIZE:  0x30
FIELDS:
  private           Beyond.Scripts.Quality.RankingRulem_rule  // 0x10
  private           Beyond.Scripts.Quality.DeviceInfo.MatchTypem_matchType  // 0x20
  private           System.String                   gpuStandardName  // 0x28
METHODS:
  RVA=0x02CDC4C0  token=0x6000034  System.Void .ctor(Beyond.Scripts.Quality.RankingRule r, Beyond.Scripts.Quality.DeviceInfo.MatchType type, System.String gpuStandardName)
  RVA=0x0363B640  token=0x6000035  System.String ToString()
  RVA=0x0965EB6C  token=0x6000036  System.Boolean IsNoMatch()
  RVA=0x0965EBB8  token=0x6000037  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Scripts.Quality.DeviceQualityMapItem
TYPE:  sealed struct
TOKEN: 0x2000013
SIZE:  0x38
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Int32                    deviceScore  // 0x18
  public            System.Int32                    defaultLevel  // 0x1c
  public            System.Int32                    veryLowLevel  // 0x20
  public            System.Int32                    lowLevel  // 0x24
  public            System.Int32                    middleLevel  // 0x28
  public            System.Int32                    highLevel  // 0x2c
  public            System.Int32                    veryHighLevel  // 0x30
METHODS:
  RVA=0x0965EC10  token=0x6000038  System.String ToString()
  RVA=0x0965EEA8  token=0x6000039  UnityEngine.Color getColor(System.Int32 level)
  RVA=0x0965F110  token=0x600003A  UnityEngine.Color getVeryLowColor()
  RVA=0x0965EFB4  token=0x600003B  UnityEngine.Color getLowColor()
  RVA=0x0965F028  token=0x600003C  UnityEngine.Color getMiddleColor()
  RVA=0x0965EF40  token=0x600003D  UnityEngine.Color getHighColor()
  RVA=0x0965F09C  token=0x600003E  UnityEngine.Color getVeryHighColor()
  RVA=0x0965EE44  token=0x600003F  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Scripts.Quality.DeviceQualityMap
TYPE:  class
TOKEN: 0x2000014
SIZE:  0x20
FIELDS:
  public            UnityEngine.RuntimePlatform     m_platform  // 0x10
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.DeviceQualityMapItem>items  // 0x18
METHODS:
  RVA=0x03CA7500  token=0x6000040  System.Void .ctor()
END_CLASS

CLASS: Beyond.Scripts.Quality.QualityConst
TYPE:  static class
TOKEN: 0x2000015
SIZE:  0x10
FIELDS:
  public    static  System.String                   SIMULATE_DEVICE_LIST  // const
  public    static  System.String                   SETTING_RULES  // const
  public    static  System.String                   QUALITY_MAP  // const
  public    static  System.String                   QUALITY_TIER_COMPONENTS  // const
METHODS:
END_CLASS

CLASS: Beyond.Scripts.Quality.QualityManager
TYPE:  class
TOKEN: 0x2000016
SIZE:  0x98
EXTENDS: Beyond.Singleton`1
IMPLEMENTS: System.IDisposable
FIELDS:
  private           Beyond.Scripts.Quality.DeviceInfom_deviceInfo  // 0x10
  private           Beyond.Scripts.Quality.DeviceQualityMapm_qualityMap  // 0x18
  private           Beyond.Scripts.Quality.DeviceQualityMapItemm_matchedConfig  // 0x20
  private           System.Collections.Generic.Dictionary<Beyond.GameSetting.GameSettingVideoQuality,System.Int32>m_qualityScoreMap  // 0x48
  private           System.Collections.Generic.List<Beyond.Scripts.Quality.Components.QualityTierLevel>m_qualityTiers  // 0x50
  private           System.Collections.Generic.HashSet<System.Type>m_qualityTierTypes  // 0x58
  private           System.Collections.Generic.Dictionary<System.Type,Beyond.Scripts.Quality.Components.QualityTierComponentMatch>m_currentQualityTierComponent  // 0x60
  private           System.Collections.Generic.Dictionary<System.Type,Beyond.Scripts.Quality.Components.QualityTierComponentMatch>m_overrideQualityTierComponent  // 0x68
  private           System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.Type,System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>>>m_qualityTierComponentChangeCallBack  // 0x70
  private           System.Collections.Generic.Queue<System.ValueTuple<System.Type,System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>>>m_queue  // 0x78
  private           System.Int32                    m_defaultTier  // 0x80
  private           System.Int32                    m_currentTier  // 0x84
  private           System.Boolean                  m_overrideFinish  // 0x88
  private           System.Func<System.Type,System.Boolean>resetSaveQualityTier  // 0x90
  private   static  System.Collections.Generic.HashSet<System.Int32>s_matchCount  // static @ 0x0
  private   static  System.Collections.Generic.HashSet<Beyond.Scripts.Quality.Components.QualityTierComponentMatch>s_matchQuality  // static @ 0x8
PROPERTIES:
  Config  get=0x03D581B0
  currentTier  get=0x03D4F370
  defaultTier  get=0x03D4EC20
  device  get=0x020B7B20
  isInitializing  get=0x02AB2090
METHODS:
  RVA=0x03A26670  token=0x6000045  System.Void .ctor()
  RVA=0x03100CE0  token=0x6000046  System.Void Init(System.String remoteJson)
  RVA=0x03B34E20  token=0x6000047  System.Void InitOnlyDevice(System.String remoteJson)
  RVA=0x031010C0  token=0x6000048  System.Void InitShaderLod()
  RVA=0x02AB7210  token=0x6000049  System.Void FinishInit()
  RVA=0x03103210  token=0x600004B  System.Void Dispose()
  RVA=0x0283C160  token=0x600004C  System.Void LoadQualityTier(System.String overridePlatform)
  RVA=0x02AB5120  token=0x600004D  System.Void setQualityTier(System.Int32 qualityTier)
  RVA=0x030FF830  token=0x600004E  System.Void ApplyQualityScore()
  RVA=0x03100280  token=0x600004F  System.Void ApplyShaderTier()
  RVA=0x0283F990  token=0x6000050  System.Type _GetQualityComponentByName(System.String typeName)
  RVA=0x09665048  token=0x6000051  System.Void SetQualityTierByVideoQuality(Beyond.GameSetting.GameSettingVideoQuality VideoQuality)
  RVA=0x096633C8  token=0x6000052  Beyond.GameSetting.GameSettingVideoQuality GetDefaultVideoQuality()
  RVA=0x03B315B0  token=0x6000053  System.Boolean NoMatchDeviceOrZeroScore()
  RVA=0x09664B04  token=0x6000054  System.Boolean IsQualcommDevice()
  RVA=0x09664A3C  token=0x6000055  System.Boolean IsHUAWEIDevice()
  RVA=0x09664A90  token=0x6000056  System.Boolean IsIpadDevice()
  RVA=0x09664C68  token=0x6000057  System.Boolean IsVideoQualityEnable(Beyond.GameSetting.GameSettingVideoQuality VideoQuality)
  RVA=0x03C84EC0  token=0x6000058  System.Void InitResetQualityTierComponentFunction(System.Func<System.Type,System.Boolean> func)
  RVA=0x02AB0C60  token=0x6000059  System.Boolean ResetQualityTierComponentValue(System.Type type)
  RVA=0x0283CCE0  token=0x600005A  Beyond.Scripts.Quality.Components.QualityTierComponentMatch _SetQualityTierComponentLevel(System.Type type, System.Int32 level)
  RVA=0x03100B70  token=0x600005B  System.Void ForceSetQualityTierComponentLevel(System.String type, System.Int32 level)
  RVA=0x09664EBC  token=0x600005C  System.Void RevertSetQualityTierComponentLevel(System.String type)
  RVA=0x09664CC4  token=0x600005D  System.Boolean NeedRestart()
  RVA=0x02AB7150  token=0x600005E  System.Void ApplyCallBack()
  RVA=0x02AB3D80  token=0x600005F  Beyond.Scripts.Quality.Components.QualityTierComponentMatch _GetOverrideQualityTierComponentLevel(System.Type type)
  RVA=0x02AB6FF0  token=0x6000060  Beyond.Scripts.Quality.Components.QualityTierType GetQualityTierComponentTierType(System.String type)
  RVA=0x02AB6260  token=0x6000061  System.Int32 GetQualityTierComponentTierVersion(System.String type)
  RVA=0x02AB3C60  token=0x6000062  System.Boolean _IsToggleQualityTierComponent(System.String type)
  RVA=0x039C4C10  token=0x6000063  System.Void _ToggleQualityTierComponentLevel(System.String type, System.Int32 index)
  RVA=0x02AB48D0  token=0x6000064  System.Boolean IsEnumQualityTierComponent(System.String type)
  RVA=0x09663534  token=0x6000065  System.Int32 GetEnumQualityTierComponentCount(System.String type)
  RVA=0x03A20110  token=0x6000066  System.Void SetEnumQualityTierComponentCount(System.String type, System.Int32 index)
  RVA=0x02AB49B0  token=0x6000067  System.Boolean IsSliderQualityTierComponent(System.String type)
  RVA=0x096650E8  token=0x6000068  System.Void SetSliderQualityTierComponentCount(System.String type, System.Single value)
  RVA=0x09664778  token=0x6000069  UnityEngine.Vector3 GetSliderQualityTierComponent(System.String type)
  RVA=0x096648AC  token=0x600006A  System.Boolean InvokeQualityTierComponent(System.String type, System.String functionName, System.Object[] parameters)
  RVA=-1  // generic def  token=0x600006B  System.Void RegisterQualityTierComponentChange(System.Type tierType, System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent> cb)
  RVA=0x02AB4A90  token=0x600006C  System.Void InvokeChangeCallBack(System.Type type, Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent)
  RVA=0x09664408  token=0x600006D  System.ValueTuple<System.Single,System.Single> GetQualityTierComponentTierCount(System.String type)
  RVA=0x09663608  token=0x600006E  System.Single GetQualityComponentDefaultTier(System.String type)
  RVA=0x09663D0C  token=0x600006F  System.Single GetQualityComponentTier(System.String type)
  RVA=0x028F43E0  token=0x6000070  System.Void SetQualityComponentTier(System.String type, System.Single index)
  RVA=0x09664B58  token=0x6000071  System.Boolean IsQualitySubSettingTierValid(System.String type, System.Int32 tier)
  RVA=0x09665498  token=0x6000072  System.Void _GetCurrentComponentTierIndex(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent, System.Int32& index, System.Int32& defaultTierIndex)
  RVA=0x09665238  token=0x6000073  System.String ToString()
  RVA=0x09662D9C  token=0x6000074  System.String DebugQualityTierComponentInfo()
  RVA=0x02AB21C0  token=0x6000075  System.Void _ReportQuality()
  RVA=0x03102880  token=0x6000076  System.Void _DynamicInitQualitySetting()
  RVA=0x03102710  token=0x6000077  System.Void _DynamicReleaseQualitySetting()
  RVA=0x02AB3E40  token=0x6000078  System.Void DynamicQualityChange(Beyond.EventData<Beyond.Gameplay.BeyondPerformance.LogicQualityLevel,Beyond.Gameplay.BeyondPerformance.LogicQualityLevel>& data)
  RVA=0x096631C8  token=0x6000079  System.Void DynamicThermalChange(Beyond.EventData<Beyond.Gameplay.BeyondPerformance.ThermalState,Beyond.Gameplay.BeyondPerformance.ThermalState>& data)
  RVA=0x03C7A9D0  token=0x600007A  System.Void .cctor()
  RVA=0x05459F38  token=0x600007B  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Scripts.Quality.QualityUtility
TYPE:  static class
TOKEN: 0x2000018
SIZE:  0x10
FIELDS:
  private   static  Newtonsoft.Json.JsonSerializerSettingss_settings  // static @ 0x0
PROPERTIES:
  JsonSerializerSettings  get=0x02AB6440
METHODS:
  RVA=-1  // generic def  token=0x6000086  T LoadFromCompressedJson()
  RVA=-1  // generic def  token=0x6000087  T LoadingQualityJson(System.String path)
  RVA=-1  // generic def  token=0x6000088  T LoadingQualityJsonFromString(System.String value)
  RVA=0x09665BEC  token=0x6000089  System.Byte[] Decompress(System.Byte[] data)
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.AntiAliasingQuality
TYPE:  class
TOKEN: 0x2000019
SIZE:  0x30
EXTENDS: Beyond.Scripts.Quality.Components.EnumQualityComponent`1
FIELDS:
METHODS:
  RVA=0x0965CE64  token=0x600008B  System.Void Apply()
  RVA=0x0965CEA4  token=0x600008C  System.Void .ctor()
  RVA=0x05A73D24  token=0x600008D  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.IEnumQualityComponent
TYPE:  interface
TOKEN: 0x200001B
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600008E  System.Int32 GetEnumIndex(System.Enum enumValue)
  RVA=-1  // abstract  token=0x600008F  System.Int32 GetEnumIndex()
  RVA=-1  // abstract  token=0x6000090  System.Int32 GetDefaultEnumIndex()
  RVA=-1  // abstract  token=0x6000091  System.Int32 GetEnumCount()
  RVA=-1  // abstract  token=0x6000092  System.Void SetEnumIndex(System.Int32 value)
  RVA=-1  // abstract  token=0x6000093  System.String GetEnumName(System.Int32 index)
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.EnumQualityComponent`1
TYPE:  class
TOKEN: 0x200001C
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
IMPLEMENTS: Beyond.Scripts.Quality.Components.IEnumQualityComponent Beyond.Scripts.Quality.Components.IQualityComponentExtension`1
FIELDS:
  private           T                               enumValue  // 0x0
  private           System.Nullable<System.Int32>   m_currentValue  // 0x0
  private           System.String[]                 m_strings  // 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000094  System.Int32 GetEnumIndex(System.Enum enumValue)
  RVA=-1  // not resolved  token=0x6000095  System.Int32 GetEnumIndex()
  RVA=-1  // not resolved  token=0x6000096  System.Int32 GetDefaultEnumIndex()
  RVA=-1  // not resolved  token=0x6000097  System.Int32 GetEnumCount()
  RVA=-1  // not resolved  token=0x6000098  System.Void SetEnumIndex(System.Int32 value)
  RVA=-1  // not resolved  token=0x6000099  System.String GetEnumName(System.Int32 index)
  RVA=-1  // not resolved  token=0x600009A  System.Void SetEnum(T value)
  RVA=-1  // not resolved  token=0x600009B  T GetValue()
  RVA=-1  // not resolved  token=0x600009C  T GetDefaultValue()
  RVA=-1  // not resolved  token=0x600009D  System.Void SetEnumWithOutApply(T value)
  RVA=-1  // not resolved  token=0x600009E  System.Void .ctor()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.QualityTierType
TYPE:  sealed struct
TOKEN: 0x200001D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.QualityTierTypeQuality  // const
  public    static  Beyond.Scripts.Quality.Components.QualityTierTypeToggleQuality  // const
  public    static  Beyond.Scripts.Quality.Components.QualityTierTypeEnumQuality  // const
  public    static  Beyond.Scripts.Quality.Components.QualityTierTypeSliderQuality  // const
METHODS:
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.IQualityComponentExtension`1
TYPE:  interface
TOKEN: 0x200001E
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600009F  T GetValue()
  RVA=-1  // abstract  token=0x60000A0  T GetDefaultValue()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.QualityTierComponent
TYPE:  abstract class
TOKEN: 0x200001F
SIZE:  0x18
FIELDS:
  public    static  System.Action<System.String,System.Int32>s_removeRegisterKeyAction  // static @ 0x0
  private           System.Boolean                  isNeedStartDirty  // 0x10
METHODS:
  RVA=0x03B2EA60  token=0x60000A1  System.Void Apply()
  RVA=0x02AB6220  token=0x60000A2  System.Void InitApply()
  RVA=0x09665A84  token=0x60000A3  System.Void LowMemory()
  RVA=0x02AB3D40  token=0x60000A4  System.Void DynamicQualityChange(Beyond.Gameplay.BeyondPerformance.LogicQualityLevel current, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel last)
  RVA=0x09665A20  token=0x60000A5  System.Void DynamicThermalChange(Beyond.Gameplay.BeyondPerformance.ThermalState current, Beyond.Gameplay.BeyondPerformance.ThermalState last)
  RVA=0x02AB63A0  token=0x60000A6  System.Int32 Version()
  RVA=0x09665BA4  token=0x60000A7  System.Boolean TierLimit()
  RVA=0x02AB61F0  token=0x60000A8  System.Int32 ApplyOrder()
  RVA=0x09665AC4  token=0x60000A9  System.Void RemoveQualitySettingSaveValue(System.String settingId)
  RVA=0x02AB20A0  token=0x60000AA  System.Void SafeApply()
  RVA=0x03A2D0F0  token=0x60000AB  System.Void RemoveRegisterKey()
  RVA=0x02AB50A0  token=0x60000AC  System.Void SafeLowMemory(System.Boolean init)
  RVA=0x02AB4800  token=0x60000AD  System.Void CallDynamicQualityChange(Beyond.Gameplay.BeyondPerformance.LogicQualityLevel current, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel last)
  RVA=0x096659A8  token=0x60000AE  System.Void CallDynamicThermalChange(Beyond.Gameplay.BeyondPerformance.ThermalState current, Beyond.Gameplay.BeyondPerformance.ThermalState last)
  RVA=0x0350B670  token=0x60000AF  System.Void .ctor()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.QualityTierComponentMatch
TYPE:  sealed struct
TOKEN: 0x2000020
SIZE:  0x20
FIELDS:
  public            Beyond.Scripts.Quality.Components.QualityTierComponentcomponent  // 0x10
  public            Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSourcematchSource  // 0x18
  public            System.Int32                    matchQualityTier  // 0x1c
METHODS:
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.QualityTierLevel
TYPE:  class
TOKEN: 0x2000022
SIZE:  0x20
FIELDS:
  public            System.Int32                    qualityTier  // 0x10
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.Components.QualityTierComponent>qualityTierComponents  // 0x18
METHODS:
  RVA=0x03915F20  token=0x60000B0  System.Void .ctor()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.SliderQualityComponent
TYPE:  class
TOKEN: 0x2000023
SIZE:  0x30
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  private           System.Single                   sliderValue  // 0x18
  private           System.Single                   MaxSliderValue  // 0x1c
  private           System.Single                   MinSliderValue  // 0x20
  private           System.Nullable<System.Single>  m_currentSliderValue  // 0x24
METHODS:
  RVA=0x02AB1BB0  token=0x60000B1  System.Single GetValue()
  RVA=0x02AB1C20  token=0x60000B2  System.Single GetDefaultValue()
  RVA=0x096667C8  token=0x60000B3  UnityEngine.Vector2 GetRange()
  RVA=0x09666820  token=0x60000B4  System.Void SetValue(System.Single value)
  RVA=0x0350B670  token=0x60000B5  System.Void .ctor()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.ToggleQualityComponent
TYPE:  class
TOKEN: 0x2000024
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
IMPLEMENTS: Beyond.Scripts.Quality.Components.IQualityComponentExtension`1
FIELDS:
  private           System.Boolean                  toggleVal  // 0x18
  private           System.Nullable<System.Boolean> m_currentValue  // 0x19
METHODS:
  RVA=0x02AB6B20  token=0x60000B6  System.Void Apply()
  RVA=0x09666984  token=0x60000B7  System.Void Toggle(System.Boolean value)
  RVA=0x039C4D50  token=0x60000B8  System.Void ChangeToggle(System.Int32 index)
  RVA=0x02AB63D0  token=0x60000B9  System.Boolean GetValue()
  RVA=0x02AB1C50  token=0x60000BA  System.Boolean GetDefaultValue()
  RVA=0x0350B670  token=0x60000BB  System.Void .ctor()
  RVA=0x05A73D24  token=0x60000BC  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.CharacterRenderFeatureQuality
TYPE:  class
TOKEN: 0x2000025
SIZE:  0x28
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            System.Int32                    characterSelfShadowOffLodQuality  // 0x18
  public            System.Int32                    characterShadowTierLevel  // 0x1c
  public            System.Int32                    characterOutlineTierLevel  // 0x20
METHODS:
  RVA=0x03CE0400  token=0x60000BD  System.Void Apply()
  RVA=0x03D4B940  token=0x60000BE  System.Void .ctor()
  RVA=0x05A73D24  token=0x60000BF  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.ChromaticAberrationQuality
TYPE:  class
TOKEN: 0x2000026
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.ToggleQualityComponent
FIELDS:
  private   static  System.Int32                    ENABLE_TIER  // const
  private   static  System.Int32                    DISABLE_TIER  // const
METHODS:
  RVA=0x035A5650  token=0x60000C0  System.Void Toggle(System.Boolean value)
  RVA=0x0350B670  token=0x60000C1  System.Void .ctor()
  RVA=0x0965CECC  token=0x60000C2  System.Void <>iFixBaseProxy_Toggle(System.Boolean P0)
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.DLSSFrameGenQuality
TYPE:  class
TOKEN: 0x2000027
SIZE:  0x38
EXTENDS: Beyond.Scripts.Quality.Components.EnumQualityComponent`1
FIELDS:
  private           System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>callback  // 0x30
METHODS:
  RVA=0x03B0DD70  token=0x60000C3  System.Void Apply()
  RVA=0x02C99490  token=0x60000C4  System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
  RVA=0x02AB1070  token=0x60000C5  System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent)
  RVA=0x0965CED4  token=0x60000C6  System.Boolean ShouldShowAuto()
  RVA=0x0965CF20  token=0x60000C7  System.Boolean ShouldShowX1()
  RVA=0x0965CF6C  token=0x60000C8  System.Boolean ShouldShowX2()
  RVA=0x0965CFC8  token=0x60000C9  System.Boolean ShouldShowX3()
  RVA=0x0965D024  token=0x60000CA  System.Boolean ShouldShow()
  RVA=0x03D47AA0  token=0x60000CB  System.Void .ctor()
  RVA=0x05A73D24  token=0x60000CC  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.DLSSUpscalerQuality
TYPE:  class
TOKEN: 0x2000029
SIZE:  0x38
EXTENDS: Beyond.Scripts.Quality.Components.EnumQualityComponent`1
FIELDS:
  private           System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>callback  // 0x30
METHODS:
  RVA=0x03B212A0  token=0x60000CD  System.Void Apply()
  RVA=0x0965D0CC  token=0x60000CE  System.Boolean ShouldShow()
  RVA=0x02C99530  token=0x60000CF  System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
  RVA=0x02AB1110  token=0x60000D0  System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent)
  RVA=0x03D47A70  token=0x60000D1  System.Void .ctor()
  RVA=0x05A73D24  token=0x60000D2  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.EnvironmentRenderingFeatureQuality
TYPE:  class
TOKEN: 0x200002A
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            System.Int32                    environmentRenderingFeatureQualityTier  // 0x18
METHODS:
  RVA=0x035A5B50  token=0x60000D3  System.Void Apply()
  RVA=0x0350B670  token=0x60000D4  System.Void .ctor()
  RVA=0x05A73D24  token=0x60000D5  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.FrameGenQuality
TYPE:  class
TOKEN: 0x200002B
SIZE:  0x30
EXTENDS: Beyond.Scripts.Quality.Components.EnumQualityComponent`1
FIELDS:
METHODS:
  RVA=0x02AB13E0  token=0x60000D6  System.Void Apply()
  RVA=0x0965F46C  token=0x60000D7  System.Boolean ShouldShow()
  RVA=0x0965F41C  token=0x60000D8  System.Boolean ShouldShowDLSS()
  RVA=0x03D479E0  token=0x60000D9  System.Void .ctor()
  RVA=0x05A73D24  token=0x60000DA  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.FrameGenQualityMobile
TYPE:  class
TOKEN: 0x200002D
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.ToggleQualityComponent
FIELDS:
METHODS:
  RVA=0x0965F23C  token=0x60000DB  System.Void Apply()
  RVA=0x0965F348  token=0x60000DC  System.Boolean ShouldShow()
  RVA=0x0350B670  token=0x60000DD  System.Void .ctor()
  RVA=0x0965F414  token=0x60000DE  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.FrameRateQuality
TYPE:  class
TOKEN: 0x200002E
SIZE:  0x30
EXTENDS: Beyond.Scripts.Quality.Components.EnumQualityComponent`1
FIELDS:
PROPERTIES:
  frameRate  get=0x037FF410
METHODS:
  RVA=0x037FF460  token=0x60000E0  System.Int32 GetFrameRateFromEnum(Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnum enumValue)
  RVA=0x03D1F290  token=0x60000E1  System.Int32 Version()
  RVA=0x0965F9C4  token=0x60000E2  System.Boolean ShouldShow()
  RVA=0x037FF390  token=0x60000E3  System.Void Apply()
  RVA=0x0965F854  token=0x60000E4  System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent)
  RVA=0x02C9A3E0  token=0x60000E5  System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
  RVA=0x0965FA6C  token=0x60000E6  System.Boolean _FPS30Enabled()
  RVA=0x0965FAB8  token=0x60000E7  System.Boolean _FPS60Enabled()
  RVA=0x0965FB04  token=0x60000E8  System.Boolean _FPSBNoLimitEnabled()
  RVA=0x0965FB50  token=0x60000E9  System.Boolean _IsGDLSSGDisable()
  RVA=0x03D479B0  token=0x60000EA  System.Void .ctor()
  RVA=0x060BBCC0  token=0x60000EB  System.Int32 <>iFixBaseProxy_Version()
  RVA=0x05A73D24  token=0x60000EC  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HgFrameRateControl
TYPE:  class
TOKEN: 0x2000030
SIZE:  0x10
FIELDS:
  public    static  System.Int32                    s_cinematicFrameRate  // static @ 0x0
  public    static  System.Collections.Generic.Stack<System.ValueTuple<System.Int32,System.Int32,Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum>>s_rateStack  // static @ 0x8
  public    static  System.Action<System.Int32,System.Int32>s_OnFrameRateChanged  // static @ 0x10
METHODS:
  RVA=0x037FF360  token=0x60000ED  System.Int32 GetDefaultFrameRate()
  RVA=0x037FF240  token=0x60000EE  System.Void Init()
  RVA=0x09660320  token=0x60000EF  System.Void SetFrameRateOverrider(System.Int32 frameRate, Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum reason)
  RVA=0x0965FED8  token=0x60000F0  System.Int32 GetFrameRate()
  RVA=0x09660050  token=0x60000F1  System.Boolean IsHighFrameRate()
  RVA=0x09660074  token=0x60000F2  System.Int32 RecommendedDefaultFrameRate()
  RVA=0x0965FF1C  token=0x60000F3  System.Int32 GetUserSettingFrameRate()
  RVA=0x037FF4A0  token=0x60000F4  System.Void __ForceSetFrameRate(System.Int32 frameRate, Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum reason)
  RVA=0x096601A8  token=0x60000F5  System.Void ResetFrameRate()
  RVA=0x0350B670  token=0x60000F6  System.Void .ctor()
  RVA=0x037FF2B0  token=0x60000F7  System.Void .cctor()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.FrameRateQualityMobile
TYPE:  class
TOKEN: 0x2000032
SIZE:  0x38
EXTENDS: Beyond.Scripts.Quality.Components.EnumQualityComponent`1
FIELDS:
  private           System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>callback  // 0x30
PROPERTIES:
  frameRate  get=0x0965F810
METHODS:
  RVA=0x0965F544  token=0x60000F9  System.Int32 GetFrameRateFromEnum(Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnum enumValue)
  RVA=0x0965F798  token=0x60000FA  System.Int32 Version()
  RVA=0x0965F4BC  token=0x60000FB  System.Void Apply()
  RVA=0x0965F5B8  token=0x60000FC  System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
  RVA=0x0965F7E8  token=0x60000FD  System.Void .ctor()
  RVA=0x060BBCC0  token=0x60000FE  System.Int32 <>iFixBaseProxy_Version()
  RVA=0x05A73D24  token=0x60000FF  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.FSR3UpscalerQuality
TYPE:  class
TOKEN: 0x2000034
SIZE:  0x38
EXTENDS: Beyond.Scripts.Quality.Components.EnumQualityComponent`1
FIELDS:
  private           System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>callback  // 0x30
METHODS:
  RVA=0x03B21160  token=0x6000100  System.Void Apply()
  RVA=0x0965F184  token=0x6000101  System.Boolean ShouldShow()
  RVA=0x02C995D0  token=0x6000102  System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
  RVA=0x02AB11E0  token=0x6000103  System.Void FSR3Change(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent)
  RVA=0x03D47A40  token=0x6000104  System.Void .ctor()
  RVA=0x05A73D24  token=0x6000105  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.GrassSparsityQuality
TYPE:  class
TOKEN: 0x2000035
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            System.Int32                    grassSparsityQualityTier  // 0x18
METHODS:
  RVA=0x035A56E0  token=0x6000106  System.Void Apply()
  RVA=0x0350B670  token=0x6000107  System.Void .ctor()
  RVA=0x05A73D24  token=0x6000108  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGAmbientOcclusionQuality
TYPE:  class
TOKEN: 0x2000036
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            System.Int32                    aoQualityTier  // 0x18
METHODS:
  RVA=0x035A5BF0  token=0x6000109  System.Void Apply()
  RVA=0x0350B670  token=0x600010A  System.Void .ctor()
  RVA=0x05A73D24  token=0x600010B  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGAnisoLevelQuality
TYPE:  class
TOKEN: 0x2000037
SIZE:  0x30
EXTENDS: Beyond.Scripts.Quality.Components.EnumQualityComponent`1
FIELDS:
METHODS:
  RVA=0x03CC45A0  token=0x600010C  System.Void InitApply()
  RVA=0x0965FBF8  token=0x600010D  System.Void Apply()
  RVA=0x03D47980  token=0x600010E  System.Void .ctor()
  RVA=0x0965FCFC  token=0x600010F  System.Void <>iFixBaseProxy_InitApply()
  RVA=0x05A73D24  token=0x6000110  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGContactShadowQuality
TYPE:  class
TOKEN: 0x2000039
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.ToggleQualityComponent
FIELDS:
  private   static  System.Int32                    ENABLE_TIER  // const
  private   static  System.Int32                    DISABLE_TIER  // const
METHODS:
  RVA=0x035A5750  token=0x6000111  System.Void Toggle(System.Boolean value)
  RVA=0x0350B670  token=0x6000112  System.Void .ctor()
  RVA=0x0965CECC  token=0x6000113  System.Void <>iFixBaseProxy_Toggle(System.Boolean P0)
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGIrradianceVolumeQuality
TYPE:  class
TOKEN: 0x200003A
SIZE:  0x18
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
METHODS:
  RVA=0x0965FD04  token=0x6000114  System.Void LowMemory()
  RVA=0x0350B670  token=0x6000115  System.Void .ctor()
  RVA=0x05A73D2C  token=0x6000116  System.Void <>iFixBaseProxy_LowMemory()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGLODStreamingComponent
TYPE:  class
TOKEN: 0x200003B
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            System.Boolean                  enableLODStreaming  // 0x18
METHODS:
  RVA=0x03D00F70  token=0x6000117  System.Void Apply()
  RVA=0x0965FD48  token=0x6000118  System.Void LowMemory()
  RVA=0x0350B670  token=0x6000119  System.Void .ctor()
  RVA=0x05A73D24  token=0x600011A  System.Void <>iFixBaseProxy_Apply()
  RVA=0x05A73D2C  token=0x600011B  System.Void <>iFixBaseProxy_LowMemory()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGReflectionProbeBinningQuality
TYPE:  class
TOKEN: 0x200003C
SIZE:  0x18
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
METHODS:
  RVA=0x0965FE50  token=0x600011C  System.Void LowMemory()
  RVA=0x0350B670  token=0x600011D  System.Void .ctor()
  RVA=0x05A73D2C  token=0x600011E  System.Void <>iFixBaseProxy_LowMemory()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGRPTierQuality
TYPE:  class
TOKEN: 0x200003D
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            System.Int32                    HGRP_QualityTier  // 0x18
METHODS:
  RVA=0x035A5A40  token=0x600011F  System.Void Apply()
  RVA=0x03D42BD0  token=0x6000120  System.Void .ctor()
  RVA=0x05A73D24  token=0x6000121  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGScreenSpaceReflectionQuality
TYPE:  class
TOKEN: 0x200003E
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            System.Int32                    ssrQualityTier  // 0x18
METHODS:
  RVA=0x035A57E0  token=0x6000122  System.Void Apply()
  RVA=0x0350B670  token=0x6000123  System.Void .ctor()
  RVA=0x05A73D24  token=0x6000124  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGShadowQuality
TYPE:  class
TOKEN: 0x200003F
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            System.Int32                    shadowQualityTier  // 0x18
METHODS:
  RVA=0x035A5850  token=0x6000125  System.Void Apply()
  RVA=0x0350B670  token=0x6000126  System.Void .ctor()
  RVA=0x05A73D24  token=0x6000127  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGTextureQuality
TYPE:  class
TOKEN: 0x2000040
SIZE:  0x30
EXTENDS: Beyond.Scripts.Quality.Components.EnumQualityComponent`1
FIELDS:
PROPERTIES:
  textureQualityTier  get=0x035A5970
METHODS:
  RVA=0x035A58C0  token=0x6000129  System.Void Apply()
  RVA=0x03D47950  token=0x600012A  System.Void .ctor()
  RVA=0x05A73D24  token=0x600012B  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGVolumetricFogQuality
TYPE:  class
TOKEN: 0x2000042
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            System.Int32                    volumetricFogQualityTier  // 0x18
METHODS:
  RVA=0x035A59D0  token=0x600012C  System.Void Apply()
  RVA=0x0350B670  token=0x600012D  System.Void .ctor()
  RVA=0x05A73D24  token=0x600012E  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.LODGroupQuality
TYPE:  class
TOKEN: 0x2000043
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            System.Single                   lodBias  // 0x18
  public            System.Int32                    lodOffset  // 0x1c
METHODS:
  RVA=0x09662980  token=0x600012F  System.Void Apply()
  RVA=0x0350B670  token=0x6000130  System.Void .ctor()
  RVA=0x05A73D24  token=0x6000131  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.PhysicsClothQuality
TYPE:  class
TOKEN: 0x2000044
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            System.Boolean                  UsePhysicCloth  // 0x18
  public            System.Boolean                  UseCrossFrameJob  // 0x19
METHODS:
  RVA=0x09662B70  token=0x6000132  System.Void Apply()
  RVA=0x03D74E40  token=0x6000133  System.Void .ctor()
  RVA=0x05A73D24  token=0x6000134  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.PrefabInstantiateQuality
TYPE:  class
TOKEN: 0x2000045
SIZE:  0x38
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            System.Single                   normalMaxUpdateTimeInMsThreshold  // 0x18
  public            System.Single                   busyMaxUpdateTimeInMsThreshold  // 0x1c
  public            System.Single                   burstMaxUpdateTimeInMsThreshold  // 0x20
  public            System.Single                   normalUnloadMaxUpdateTimeInMsThreshold  // 0x24
  public            System.Single                   burstUnloadMaxUpdateTimeInMsThreshold  // 0x28
  public            System.Single                   normalCallbackMaxUpdateTimeInMsThreshold  // 0x2c
  public            System.Single                   burstCallbackMaxUpdateTimeInMsThreshold  // 0x30
  public            System.Int32                    normalMaxDestroyCount  // 0x34
METHODS:
  RVA=0x09662C20  token=0x6000135  System.Void Apply()
  RVA=0x03D74E50  token=0x6000136  System.Void .ctor()
  RVA=0x05A73D24  token=0x6000137  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.PreloadLoadSettingQuality
TYPE:  class
TOKEN: 0x2000046
SIZE:  0x38
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            System.Single                   normalMaxUpdateTimeInMsThreshold  // 0x18
  public            System.Single                   busyMaxUpdateTimeInMsThreshold  // 0x1c
  public            System.Single                   burstMaxUpdateTimeInMsThreshold  // 0x20
  public            System.Single                   normalUnloadMaxUpdateTimeInMsThreshold  // 0x24
  public            System.Single                   burstUnloadMaxUpdateTimeInMsThreshold  // 0x28
  public            System.Single                   normalCallbackMaxUpdateTimeInMsThreshold  // 0x2c
  public            System.Single                   burstCallbackMaxUpdateTimeInMsThreshold  // 0x30
  public            System.Single                   preloadManagerUnloadKeepTime  // 0x34
METHODS:
  RVA=0x03B122E0  token=0x6000138  System.Void Apply()
  RVA=0x03D1EDE0  token=0x6000139  System.Void .ctor()
  RVA=0x05A73D24  token=0x600013A  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.RayTracingQuality
TYPE:  class
TOKEN: 0x2000047
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.ToggleQualityComponent
FIELDS:
PROPERTIES:
  supportsRayTracing  get=0x03A2D050
METHODS:
  RVA=0x03A2CFF0  token=0x600013C  System.Void InitApply()
  RVA=0x09665EFC  token=0x600013D  System.Void Apply()
  RVA=0x09665FF0  token=0x600013E  System.Boolean ShouldShow()
  RVA=0x03D47590  token=0x600013F  System.Int32 ApplyOrder()
  RVA=0x0350B670  token=0x6000140  System.Void .ctor()
  RVA=0x0965FCFC  token=0x6000141  System.Void <>iFixBaseProxy_InitApply()
  RVA=0x0965F414  token=0x6000142  System.Void <>iFixBaseProxy_Apply()
  RVA=0x09666040  token=0x6000143  System.Int32 <>iFixBaseProxy_ApplyOrder()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.ReflexQuality
TYPE:  class
TOKEN: 0x2000048
SIZE:  0x38
EXTENDS: Beyond.Scripts.Quality.Components.EnumQualityComponent`1
FIELDS:
  private           System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>callback  // 0x30
METHODS:
  RVA=0x02AB0EF0  token=0x6000144  System.Void Apply()
  RVA=0x096661A8  token=0x6000145  System.Boolean ShouldShow()
  RVA=0x02C99670  token=0x6000146  System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
  RVA=0x09666048  token=0x6000147  System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent)
  RVA=0x03D47560  token=0x6000148  System.Void .ctor()
  RVA=0x05A73D24  token=0x6000149  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile
TYPE:  class
TOKEN: 0x2000049
SIZE:  0x30
EXTENDS: Beyond.Scripts.Quality.Components.EnumQualityComponent`1
FIELDS:
PROPERTIES:
  renderingScaleFactor  get=0x0966639C
METHODS:
  RVA=0x09666268  token=0x600014B  System.Void Apply()
  RVA=0x09666374  token=0x600014C  System.Void .ctor()
  RVA=0x05A73D24  token=0x600014D  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.RenderingScaleQualityPC
TYPE:  class
TOKEN: 0x200004B
SIZE:  0x38
EXTENDS: Beyond.Scripts.Quality.Components.EnumQualityComponent`1
FIELDS:
  private           System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>callback  // 0x30
PROPERTIES:
  renderingScale  get=0x02AB16E0
METHODS:
  RVA=0x02AB1580  token=0x600014F  System.Void Apply()
  RVA=0x09666468  token=0x6000150  System.Boolean ShouldShow()
  RVA=0x02C99710  token=0x6000151  System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
  RVA=0x02AB12B0  token=0x6000152  System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent)
  RVA=0x03D47530  token=0x6000153  System.Void .ctor()
  RVA=0x05A73D24  token=0x6000154  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.ResLoadSettingQuality
TYPE:  class
TOKEN: 0x200004D
SIZE:  0x50
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            System.Boolean                  debugCloseBundleUnload  // 0x18
  public            System.Boolean                  debugCloseBundleUnloadUntilBurstMode  // 0x19
  public            System.Boolean                  enableForceSyncUnload  // 0x1a
  public            System.Boolean                  enableUnloadLocker  // 0x1b
  public            System.Int32                    enableUnloadLockerBundleNum  // 0x1c
  public            System.Int32                    maxUnloadOpNum_Normal  // 0x20
  public            System.Int32                    maxUnloadOpNum_BusyMode  // 0x24
  public            System.Int32                    bundleFrameDelayToUnload_NormalMode  // 0x28
  public            System.Int32                    bundleFrameDelayToUnload_BusyMode  // 0x2c
  public            System.Int32                    bundleFrameDelayToUnload_BurstMode  // 0x30
  public            System.Int32                    bundleFrameDelayToUnload_SwitchScene  // 0x34
  public            System.Int32                    bundleFrameDelayToUnload_Fast  // 0x38
  public            System.Int32                    enterBusyOperationNum  // 0x3c
  public            System.Int32                    exitBusyOperationNum  // 0x40
  public            System.Single                   unloadBudgetFloatingCoefficient  // 0x44
  public            System.Single                   unloadMaxFloatingBudget  // 0x48
METHODS:
  RVA=0x03A92FF0  token=0x6000155  System.Void Apply()
  RVA=0x09666550  token=0x6000156  System.Void LowMemory()
  RVA=0x03CDD770  token=0x6000157  System.Void .ctor()
  RVA=0x05A73D24  token=0x6000158  System.Void <>iFixBaseProxy_Apply()
  RVA=0x05A73D2C  token=0x6000159  System.Void <>iFixBaseProxy_LowMemory()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.SceneDetailQuality
TYPE:  class
TOKEN: 0x200004E
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            System.Int32                    sceneDetailQualityTier  // 0x18
METHODS:
  RVA=0x035A5C90  token=0x600015A  System.Void Apply()
  RVA=0x0350B670  token=0x600015B  System.Void .ctor()
  RVA=0x05A73D24  token=0x600015C  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.ShaderLodQuality
TYPE:  class
TOKEN: 0x200004F
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnumShaderLod  // 0x18
METHODS:
  RVA=0x03CA43C0  token=0x600015D  System.Void InitApply()
  RVA=0x09666614  token=0x600015E  System.Void Apply()
  RVA=0x0350B670  token=0x600015F  System.Void .ctor()
  RVA=0x0965FCFC  token=0x6000160  System.Void <>iFixBaseProxy_InitApply()
  RVA=0x05A73D24  token=0x6000161  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.SharpnessQuality
TYPE:  class
TOKEN: 0x2000051
SIZE:  0x30
EXTENDS: Beyond.Scripts.Quality.Components.SliderQualityComponent
FIELDS:
METHODS:
  RVA=0x02AB1740  token=0x6000162  System.Void Apply()
  RVA=0x096666E4  token=0x6000163  System.Boolean ShouldShow()
  RVA=0x0350B670  token=0x6000164  System.Void .ctor()
  RVA=0x05A73D24  token=0x6000165  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.SliderTestComponent
TYPE:  class
TOKEN: 0x2000052
SIZE:  0x30
EXTENDS: Beyond.Scripts.Quality.Components.SliderQualityComponent
FIELDS:
METHODS:
  RVA=0x096668CC  token=0x6000166  System.Void Apply()
  RVA=0x0350B670  token=0x6000167  System.Void .ctor()
  RVA=0x05A73D24  token=0x6000168  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.TickExclusiveQuality
TYPE:  class
TOKEN: 0x2000053
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            Beyond.TickExclusiveMode        quality  // 0x18
  private           Beyond.Gameplay.BeyondPerformance.LogicQualityLevelm_currentQuality  // 0x1c
  private           Beyond.Gameplay.BeyondPerformance.ThermalStatem_currentThermalState  // 0x1d
METHODS:
  RVA=0x03CFE3F0  token=0x6000169  System.Void Apply()
  RVA=0x02AB66C0  token=0x600016A  System.Void DynamicQualityChange(Beyond.Gameplay.BeyondPerformance.LogicQualityLevel current, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel last)
  RVA=0x09666910  token=0x600016B  System.Void DynamicThermalChange(Beyond.Gameplay.BeyondPerformance.ThermalState current, Beyond.Gameplay.BeyondPerformance.ThermalState last)
  RVA=0x02AB6760  token=0x600016C  System.Void _OnQualityOrThermalChanged()
  RVA=0x03D4CD80  token=0x600016D  System.Void .ctor()
  RVA=0x05A73D24  token=0x600016E  System.Void <>iFixBaseProxy_Apply()
  RVA=0x05D6EA20  token=0x600016F  System.Void <>iFixBaseProxy_DynamicQualityChange(Beyond.Gameplay.BeyondPerformance.LogicQualityLevel P0, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel P1)
  RVA=0x05D6EA28  token=0x6000170  System.Void <>iFixBaseProxy_DynamicThermalChange(Beyond.Gameplay.BeyondPerformance.ThermalState P0, Beyond.Gameplay.BeyondPerformance.ThermalState P1)
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.UpscalerQuality
TYPE:  class
TOKEN: 0x2000054
SIZE:  0x30
EXTENDS: Beyond.Scripts.Quality.Components.EnumQualityComponent`1
FIELDS:
METHODS:
  RVA=0x02AB1890  token=0x6000171  System.Void Apply()
  RVA=0x09666AAC  token=0x6000172  System.Boolean ShouldShow()
  RVA=0x09666A0C  token=0x6000173  System.Boolean ShouldShowDLSS()
  RVA=0x09666A5C  token=0x6000174  System.Boolean ShouldShowFSR3()
  RVA=0x03D47380  token=0x6000175  System.Int32 Version()
  RVA=0x03D47350  token=0x6000176  System.Void .ctor()
  RVA=0x05A73D24  token=0x6000177  System.Void <>iFixBaseProxy_Apply()
  RVA=0x060BBCC0  token=0x6000178  System.Int32 <>iFixBaseProxy_Version()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.VSyncQuality
TYPE:  class
TOKEN: 0x2000056
SIZE:  0x20
EXTENDS: Beyond.Scripts.Quality.Components.QualityTierComponent
FIELDS:
  public            System.Boolean                  bVSync  // 0x18
METHODS:
  RVA=0x09666CF0  token=0x6000179  System.Void Apply()
  RVA=0x09666D48  token=0x600017A  System.Void Remove()
  RVA=0x03CAB5A0  token=0x600017B  System.Void Init()
  RVA=0x03D587A0  token=0x600017C  System.Void .ctor()
  RVA=0x05A73D24  token=0x600017D  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.VSyncQualityV2
TYPE:  class
TOKEN: 0x2000057
SIZE:  0x28
EXTENDS: Beyond.Scripts.Quality.Components.ToggleQualityComponent
FIELDS:
  private           System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>callback  // 0x20
METHODS:
  RVA=0x039E1EB0  token=0x600017E  System.Void Toggle(System.Boolean value)
  RVA=0x03CAB5D0  token=0x600017F  System.Void Init()
  RVA=0x03D1F1D0  token=0x6000180  System.Int32 Version()
  RVA=0x02C997B0  token=0x6000181  System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
  RVA=0x09666AFC  token=0x6000182  System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent)
  RVA=0x09666C48  token=0x6000183  System.Boolean ShouldShow()
  RVA=0x0350B670  token=0x6000184  System.Void .ctor()
  RVA=0x0965CECC  token=0x6000185  System.Void <>iFixBaseProxy_Toggle(System.Boolean P0)
  RVA=0x060BBCC0  token=0x6000186  System.Int32 <>iFixBaseProxy_Version()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000004
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  RVA=0x0350B670  token=0x6000004  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000005
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000005  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000006
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  RVA=0x0350B670  token=0x6000006  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardUtility
TYPE:  static class
TOKEN: 0x2000007
SIZE:  0x10
FIELDS:
  private   static  System.Boolean                  s_enableFastPathBuffer  // static @ 0x0
METHODS:
  RVA=-1  // generic def  token=0x6000007  System.Void ClearAndEnsureDictionaryCapacity(System.Collections.Generic.Dictionary<TKey,TValue>& dict, System.Int32 capacity)
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000008
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000008  System.Void .ctor()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000002
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000001  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000058
SIZE:  0x28
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // static @ 0x0
METHODS:
  RVA=0x03020510  token=0x6000187  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  RVA=0x050F3444  token=0x6000188  System.Void __Gen_Wrap_0()
  RVA=0x05163BA0  token=0x6000189  System.Void __Gen_Wrap_1(System.Object P0, System.Object P1)
  RVA=0x0966149C  token=0x600018A  System.String __Gen_Wrap_2(Beyond.Scripts.Quality.RankingRule& P0)
  RVA=0x09661940  token=0x600018B  System.String __Gen_Wrap_3(Beyond.Scripts.Quality.DeviceMatchResult& P0)
  RVA=0x09661FD0  token=0x600018C  System.String __Gen_Wrap_4(System.Object P0)
  RVA=0x096624A4  token=0x600018D  System.Boolean __Gen_Wrap_5(Beyond.Scripts.Quality.DeviceMatchResult& P0)
  RVA=0x0514EF5C  token=0x600018E  System.Boolean __Gen_Wrap_6(System.Object P0)
  RVA=0x096625EC  token=0x600018F  Beyond.Scripts.Quality.DeviceMatchRules __Gen_Wrap_7(System.Object P0)
  RVA=0x096626DC  token=0x6000190  System.String __Gen_Wrap_8(System.Object P0, System.Object P1)
  RVA=0x096627E8  token=0x6000191  System.Boolean __Gen_Wrap_9(System.Object P0, System.Object P1, System.Object P2, Beyond.Scripts.Quality.RankingRule& P3)
  RVA=0x09660410  token=0x6000192  System.Boolean __Gen_Wrap_10(System.Object P0, System.Object P1, System.Object P2, Beyond.Scripts.Quality.RankingRule& P3, System.String& P4)
  RVA=0x04274234  token=0x6000193  System.Void __Gen_Wrap_11(System.Object P0)
  RVA=0x05152714  token=0x6000194  System.Int32 __Gen_Wrap_12(System.Object P0, System.Object P1)
  RVA=0x096605F0  token=0x6000195  System.Boolean __Gen_Wrap_13(System.Object P0, System.Object P1, Beyond.Scripts.Quality.RankingRule& P2)
  RVA=0x09660760  token=0x6000196  System.Boolean __Gen_Wrap_14(Beyond.Scripts.Quality.RankingRule& P0, Beyond.Scripts.Quality.RankingRule P1)
  RVA=0x096608E0  token=0x6000197  System.String __Gen_Wrap_15(Beyond.Scripts.Quality.MemoryRule& P0)
  RVA=0x09660A34  token=0x6000198  System.Boolean __Gen_Wrap_16(Beyond.Scripts.Quality.MemoryRule& P0, Beyond.Scripts.Quality.MemoryRule P1)
  RVA=0x09660BB0  token=0x6000199  System.String __Gen_Wrap_17(Beyond.Scripts.Quality.DeviceQualityMapItem& P0)
  RVA=0x09660D1C  token=0x600019A  UnityEngine.Color __Gen_Wrap_18(Beyond.Scripts.Quality.DeviceQualityMapItem& P0, System.Int32 P1)
  RVA=0x09660EC0  token=0x600019B  UnityEngine.Color __Gen_Wrap_19(Beyond.Scripts.Quality.DeviceQualityMapItem& P0)
  RVA=0x050EF614  token=0x600019C  System.Int32 __Gen_Wrap_20(System.Object P0)
  RVA=0x05477F10  token=0x600019D  System.Int32 __Gen_Wrap_21(Beyond.Scripts.Quality.Components.QualityTierLevel P0)
  RVA=0x09661048  token=0x600019E  System.Int32 __Gen_Wrap_22(Beyond.Scripts.Quality.DeviceQualityMapItem P0)
  RVA=0x0966114C  token=0x600019F  Beyond.Scripts.Quality.Components.QualityTierComponentMatch __Gen_Wrap_23(System.Object P0, System.Object P1, System.Int32 P2)
  RVA=0x09661284  token=0x60001A0  System.Int32 __Gen_Wrap_24(Beyond.Scripts.Quality.Components.QualityTierComponentMatch P0)
  RVA=0x05150B1C  token=0x60001A1  System.Void __Gen_Wrap_25(System.Object P0, System.Object P1, System.Object P2)
  RVA=0x05477860  token=0x60001A2  System.Void __Gen_Wrap_26(System.Object P0, System.Boolean P1)
  RVA=0x09661374  token=0x60001A3  Beyond.Scripts.Quality.Components.QualityTierComponentMatch __Gen_Wrap_27(System.Object P0, System.Object P1)
  RVA=0x0549D548  token=0x60001A4  System.Void __Gen_Wrap_28(System.Object P0, System.Int32 P1)
  RVA=0x05E5E690  token=0x60001A5  System.Void __Gen_Wrap_29(System.Object P0, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel P1, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel P2)
  RVA=0x096615F8  token=0x60001A6  System.Void __Gen_Wrap_30(System.Object P0, Beyond.EventData<Beyond.Gameplay.BeyondPerformance.LogicQualityLevel,Beyond.Gameplay.BeyondPerformance.LogicQualityLevel>& P1)
  RVA=0x05E5E788  token=0x60001A7  System.Void __Gen_Wrap_31(System.Object P0, Beyond.Gameplay.BeyondPerformance.ThermalState P1, Beyond.Gameplay.BeyondPerformance.ThermalState P2)
  RVA=0x0966171C  token=0x60001A8  System.Void __Gen_Wrap_32(System.Object P0, Beyond.EventData<Beyond.Gameplay.BeyondPerformance.ThermalState,Beyond.Gameplay.BeyondPerformance.ThermalState>& P1)
  RVA=0x09661834  token=0x60001A9  System.Type __Gen_Wrap_33(System.Object P0, System.Object P1)
  RVA=0x054A1028  token=0x60001AA  System.Void __Gen_Wrap_34(System.Object P0, System.Object P1, System.Int32 P2)
  RVA=0x055FFD60  token=0x60001AB  System.Void __Gen_Wrap_35(System.Object P0, Beyond.GameSetting.GameSettingVideoQuality P1)
  RVA=0x05477F10  token=0x60001AC  Beyond.GameSetting.GameSettingVideoQuality __Gen_Wrap_36(System.Object P0)
  RVA=0x050F1D3C  token=0x60001AD  System.Boolean __Gen_Wrap_37()
  RVA=0x05153920  token=0x60001AE  System.Boolean __Gen_Wrap_38(System.Object P0, System.Object P1)
  RVA=0x05152714  token=0x60001AF  Beyond.Scripts.Quality.Components.QualityTierType __Gen_Wrap_39(System.Object P0, System.Object P1)
  RVA=0x050F0008  token=0x60001B0  System.Void __Gen_Wrap_40(System.Object P0, System.Single P1)
  RVA=0x05E7B3B0  token=0x60001B1  System.Void __Gen_Wrap_41(System.Object P0, System.Object P1, System.Single P2)
  RVA=0x09661AAC  token=0x60001B2  UnityEngine.Vector2 __Gen_Wrap_42(System.Object P0)
  RVA=0x054AB08C  token=0x60001B3  System.Single __Gen_Wrap_43(System.Object P0)
  RVA=0x09661B88  token=0x60001B4  UnityEngine.Vector3 __Gen_Wrap_44(System.Object P0, System.Object P1)
  RVA=0x09661CA8  token=0x60001B5  System.Boolean __Gen_Wrap_45(System.Object P0, System.Object P1, System.Object P2, System.Object P3)
  RVA=0x09661DB0  token=0x60001B6  System.ValueTuple<System.Single,System.Single> __Gen_Wrap_46(System.Object P0, System.Object P1)
  RVA=0x0871E788  token=0x60001B7  System.Int32 __Gen_Wrap_47(System.Int32 P0, System.Int32 P1)
  RVA=0x054AB15C  token=0x60001B8  System.Single __Gen_Wrap_48(System.Object P0, System.Object P1)
  RVA=0x09661EA8  token=0x60001B9  System.Int32 __Gen_Wrap_49(Beyond.Scripts.Quality.Components.QualityTierComponentMatch P0, Beyond.Scripts.Quality.Components.QualityTierComponentMatch P1)
  RVA=0x096620C0  token=0x60001BA  System.Void __Gen_Wrap_50(System.Object P0, System.Object P1, System.Int32& P2, System.Int32& P3)
  RVA=0x05646730  token=0x60001BB  System.Boolean __Gen_Wrap_51(System.Object P0, System.Object P1, System.Int32 P2)
  RVA=0x096621FC  token=0x60001BC  System.Byte[] __Gen_Wrap_52(System.Object P0)
  RVA=0x096622D8  token=0x60001BD  Newtonsoft.Json.JsonSerializerSettings __Gen_Wrap_53()
  RVA=0x096623A4  token=0x60001BE  System.Void __Gen_Wrap_54(System.Object P0, System.Runtime.Serialization.StreamingContext P1)
  RVA=0x056280E8  token=0x60001BF  System.Int32 __Gen_Wrap_55(Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnum P0)
  RVA=0x056458FC  token=0x60001C0  System.Void __Gen_Wrap_56(System.Int32 P0, Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum P1)
  RVA=0x050F1DD4  token=0x60001C1  System.Int32 __Gen_Wrap_57()
  RVA=0x0562802C  token=0x60001C2  System.Int32 __Gen_Wrap_58(Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnum P0)
  RVA=0x03D056B0  token=0x60001C3  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000059
SIZE:  0x40
EXTENDS: IFix.Core.AnonymousStorey
FIELDS:
METHODS:
  RVA=0x09666D98  token=0x60001C4  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  RVA=0x0350B670  token=0x60001C5  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x200005A
SIZE:  0x18
IMPLEMENTS: IFix.Core.WrappersManager
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60001C6  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine)
  RVA=0x09667014  token=0x60001C7  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  RVA=0x02AB4860  token=0x60001C8  System.Boolean IsPatched(System.Int32 id)
  RVA=0x09666ED0  token=0x60001C9  System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon)
  RVA=0x09666F9C  token=0x60001CA  System.Object CreateWrapper(System.Int32 id)
  RVA=0x09667078  token=0x60001CB  System.Object InitWrapperArray(System.Int32 len)
  RVA=0x09666E2C  token=0x60001CC  IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine)
END_CLASS

CLASS: IFix.IDMAP0
TYPE:  sealed struct
TOKEN: 0x200005B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-PoolCore-ListPoolInitializer_RuntimeQuality-Initialize0  // const
  public    static  IFix.IDMAP0                     Beyond-PoolCore-ListPoolInitializer_RuntimeQuality-InitializeAtRuntime0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceMatchRules-Combine0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-SupplementFromRemote0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-RankingRule-ToString0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceMatchResult-ToString0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-ToString0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceMatchResult-IsNoMatch0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-IsNoMatchDevice0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-IsZeroDevices0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-IsHUAWEIDevice0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-IsQualcommDevice0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-LoadingSettingRules0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-GetNvidiaStandardGPUName0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-RuleSuffixMatch0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-GetAmdStandardGPUName0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-GetIntelStandardGPUName0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-StandaloneMatchGPURule0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-_ReportMatchRuleFailed0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-StandaloneGetMatchedRule0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-GetDeviceScore0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-RuleFullNameMatch0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-MatchDeviceModeRule0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-GetAdrenoStandardGPUName0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-GetMaliStandardGPUName0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-MatchGPURule0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-AndroidGetMatchedRule0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-IOSGetMatchedRule0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-DefaultGetMatchedRule0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-EditorSimulateGetMatchedRule0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-StandaloneOSXGetMatchedRule0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-StandalonePS5GetMatchedRule0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-GetPowerVRStandardGPUName0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-RankingRule-Equals0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-MemoryRule-ToString0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-MemoryRule-Equals0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceQualityMapItem-ToString0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceQualityMapItem-getColor0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceQualityMapItem-getVeryLowColor0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceQualityMapItem-getLowColor0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceQualityMapItem-getMiddleColor0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceQualityMapItem-getHighColor0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceQualityMapItem-getVeryHighColor0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-ApplyOrder0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-LoadQualityTier0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-_SetQualityTierComponentLevel0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-InitApply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-LowMemory0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-InvokeChangeCallBack0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-SafeApply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-SafeLowMemory0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-_GetOverrideQualityTierComponentLevel0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-ApplyCallBack0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-setQualityTier0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-ApplyQualityScore0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-DynamicQualityChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-CallDynamicQualityChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-DynamicQualityChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-DynamicThermalChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-CallDynamicThermalChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-DynamicThermalChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-_DynamicInitQualitySetting0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-InitOnlyDevice0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-_GetQualityComponentByName0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-ForceSetQualityTierComponentLevel0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-FinishInit0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-ApplyShaderTier0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-InitShaderLod0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-_DynamicReleaseQualitySetting0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-Dispose0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-SetQualityTierByVideoQuality0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-GetDefaultVideoQuality0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-NoMatchDeviceOrZeroScore0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-IsQualcommDevice0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-IsHUAWEIDevice0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-IsIpadDevice0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-InitResetQualityTierComponentFunction0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-ResetQualityTierComponentValue0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-RevertSetQualityTierComponentLevel0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-NeedRestart0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierType0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-Version0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierVersion0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-_IsToggleQualityTierComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ToggleQualityComponent-ChangeToggle0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ToggleQualityComponent-GetValue0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-_ToggleQualityTierComponentLevel0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-IsEnumQualityTierComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-GetEnumQualityTierComponentCount0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-SetEnumQualityTierComponentCount0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-IsSliderQualityTierComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-SliderQualityComponent-SetValue0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-SetSliderQualityTierComponentCount0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-SliderQualityComponent-GetRange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-SliderQualityComponent-GetValue0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-GetSliderQualityTierComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-InvokeQualityTierComponent0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierCount0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ToggleQualityComponent-GetDefaultValue0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-SliderQualityComponent-GetDefaultValue0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-GetQualityComponentDefaultTier0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-GetQualityComponentTier0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-_ReportQuality0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-SetQualityComponentTier0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-TierLimit0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-_GetCurrentComponentTierIndex0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-IsQualitySubSettingTierValid0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-ToString0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-DebugQualityTierComponentInfo0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityUtility-Decompress0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityUtility-get_JsonSerializerSettings0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-AntiAliasingQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-RemoveQualitySettingSaveValue0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-RemoveRegisterKey0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ToggleQualityComponent-Toggle0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ToggleQualityComponent-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-CharacterRenderFeatureQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ChromaticAberrationQuality-Toggle0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-DlSSChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-OnDeserialized0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowAuto0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX10  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX20  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX30  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShow0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-ShouldShow0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-DlSSChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-OnDeserialized0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-EnvironmentRenderingFeatureQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameGenQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShowDLSS0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShow0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameGenQualityMobile-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameGenQualityMobile-ShouldShow0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-GetFrameRateFromEnum0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-Version0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-ShouldShow0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HgFrameRateControl-__ForceSetFrameRate0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-DlSSChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-OnDeserialized0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-_FPS30Enabled0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-_FPS60Enabled0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-_FPSBNoLimitEnabled0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-_IsGDLSSGDisable0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HgFrameRateControl-GetDefaultFrameRate0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HgFrameRateControl-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HgFrameRateControl-SetFrameRateOverrider0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HgFrameRateControl-GetFrameRate0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HgFrameRateControl-RecommendedDefaultFrameRate0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HgFrameRateControl-GetUserSettingFrameRate0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HgFrameRateControl-ResetFrameRate0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQualityMobile-GetFrameRateFromEnum0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQualityMobile-Version0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQualityMobile-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQualityMobile-OnDeserialized0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-ShouldShow0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-FSR3Change0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-OnDeserialized0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-GrassSparsityQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGAmbientOcclusionQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGAnisoLevelQuality-InitApply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGAnisoLevelQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGContactShadowQuality-Toggle0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGIrradianceVolumeQuality-LowMemory0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGLODStreamingComponent-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGLODStreamingComponent-LowMemory0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGReflectionProbeBinningQuality-LowMemory0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGRPTierQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGScreenSpaceReflectionQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGShadowQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGTextureQuality-get_textureQualityTier0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGTextureQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGVolumetricFogQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-LODGroupQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-PhysicsClothQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-PrefabInstantiateQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-PreloadLoadSettingQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RayTracingQuality-InitApply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RayTracingQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RayTracingQuality-ShouldShow0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RayTracingQuality-ApplyOrder0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ReflexQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ReflexQuality-ShouldShow0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ReflexQuality-DlSSChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ReflexQuality-OnDeserialized0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RenderingScaleQualityMobile-get_renderingScaleFactor0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RenderingScaleQualityMobile-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-get_renderingScale0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-ShouldShow0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-DlSSChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-OnDeserialized0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ResLoadSettingQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ResLoadSettingQuality-LowMemory0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-SceneDetailQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ShaderLodQuality-InitApply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ShaderLodQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-SharpnessQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-SharpnessQuality-ShouldShow0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-SliderTestComponent-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-TickExclusiveQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-TickExclusiveQuality-_OnQualityOrThermalChanged0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-TickExclusiveQuality-DynamicQualityChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-TickExclusiveQuality-DynamicThermalChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-UpscalerQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShowDLSS0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShow0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShowFSR30  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-UpscalerQuality-Version0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQuality-Apply0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQuality-Remove0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQuality-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQualityV2-Toggle0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQualityV2-Init0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQualityV2-Version0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQualityV2-DlSSChange0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQualityV2-OnDeserialized0  // const
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQualityV2-ShouldShow0  // const
METHODS:
END_CLASS

