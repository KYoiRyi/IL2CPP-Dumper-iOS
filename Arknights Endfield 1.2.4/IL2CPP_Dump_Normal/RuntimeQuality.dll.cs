// ========================================================
// Dumped by @desirepro
// Assembly: RuntimeQuality.dll
// Classes:  91
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x200000D  // size: 0x14
    public sealed struct MatchType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Scripts.Quality.DeviceInfo.MatchType WhiteList;  // const
        public static Beyond.Scripts.Quality.DeviceInfo.MatchType SystemVersion;  // const
        public static Beyond.Scripts.Quality.DeviceInfo.MatchType GPU;  // const
        public static Beyond.Scripts.Quality.DeviceInfo.MatchType CPU;  // const
        public static Beyond.Scripts.Quality.DeviceInfo.MatchType DefaultScore;  // const
        public static Beyond.Scripts.Quality.DeviceInfo.MatchType MemoryCorrection;  // const

    }

    // TypeToken: 0x2000017  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Beyond.Scripts.Quality.QualityManager.<>c <>9;  // static @ 0x0
        public static System.Func<Beyond.Scripts.Quality.Components.QualityTierLevel,System.Int32> <>9__29_0;  // static @ 0x8
        public static System.Func<Beyond.Scripts.Quality.Components.QualityTierComponentMatch,System.Int32> <>9__30_0;  // static @ 0x10
        public static System.Func<Beyond.Scripts.Quality.DeviceQualityMapItem,System.Int32> <>9__31_0;  // static @ 0x18
        public static System.Func<Beyond.Scripts.Quality.DeviceQualityMapItem,System.Int32> <>9__32_0;  // static @ 0x20
        public static System.Comparison<System.Int32> <>9__66_0;  // static @ 0x28
        public static System.Comparison<System.Int32> <>9__67_0;  // static @ 0x30
        public static System.Comparison<System.Int32> <>9__68_0;  // static @ 0x38
        public static System.Comparison<Beyond.Scripts.Quality.Components.QualityTierComponentMatch> <>9__70_0;  // static @ 0x40

        // Methods
        // RVA: 0x03D18350  token: 0x600007C
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600007D
        public System.Void .ctor() { }
        // RVA: 0x03C90770  token: 0x600007E
        private System.Int32 <LoadQualityTier>b__29_0(Beyond.Scripts.Quality.Components.QualityTierLevel s) { }
        // RVA: 0x038960E0  token: 0x600007F
        private System.Int32 <setQualityTier>b__30_0(Beyond.Scripts.Quality.Components.QualityTierComponentMatch x) { }
        // RVA: 0x03D60790  token: 0x6000080
        private System.Int32 <ApplyQualityScore>b__31_0(Beyond.Scripts.Quality.DeviceQualityMapItem s) { }
        // RVA: 0x03D60790  token: 0x6000081
        private System.Int32 <ApplyShaderTier>b__32_0(Beyond.Scripts.Quality.DeviceQualityMapItem s) { }
        // RVA: 0x096669D8  token: 0x6000082
        private System.Int32 <GetQualityComponentDefaultTier>b__66_0(System.Int32 a, System.Int32 b) { }
        // RVA: 0x096669D8  token: 0x6000083
        private System.Int32 <GetQualityComponentTier>b__67_0(System.Int32 a, System.Int32 b) { }
        // RVA: 0x096669D8  token: 0x6000084
        private System.Int32 <SetQualityComponentTier>b__68_0(System.Int32 a, System.Int32 b) { }
        // RVA: 0x096669F4  token: 0x6000085
        private System.Int32 <_GetCurrentComponentTierIndex>b__70_0(Beyond.Scripts.Quality.Components.QualityTierComponentMatch a, Beyond.Scripts.Quality.Components.QualityTierComponentMatch b) { }

    }

    // TypeToken: 0x200001A  // size: 0x14
    public sealed struct AntiAliasing
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Scripts.Quality.Components.AntiAliasingQuality.AntiAliasing None;  // const
        public static Beyond.Scripts.Quality.Components.AntiAliasingQuality.AntiAliasing CSAA;  // const
        public static Beyond.Scripts.Quality.Components.AntiAliasingQuality.AntiAliasing FXAA;  // const
        public static Beyond.Scripts.Quality.Components.AntiAliasingQuality.AntiAliasing MSAA;  // const

    }

    // TypeToken: 0x2000021  // size: 0x14
    public sealed struct MatchSource
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSource UpClosest;  // const
        public static Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSource DownClosest;  // const
        public static Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSource Matched;  // const
        public static Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSource Override;  // const

    }

    // TypeToken: 0x2000028  // size: 0x14
    public sealed struct DLSSFrameGenQualityEnum
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Scripts.Quality.Components.DLSSFrameGenQuality.DLSSFrameGenQualityEnum Auto;  // const
        public static Beyond.Scripts.Quality.Components.DLSSFrameGenQuality.DLSSFrameGenQualityEnum X1;  // const
        public static Beyond.Scripts.Quality.Components.DLSSFrameGenQuality.DLSSFrameGenQualityEnum X2;  // const
        public static Beyond.Scripts.Quality.Components.DLSSFrameGenQuality.DLSSFrameGenQualityEnum X3;  // const

    }

    // TypeToken: 0x200002C  // size: 0x14
    public sealed struct FrameGenMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Scripts.Quality.Components.FrameGenQuality.FrameGenMode None;  // const
        public static Beyond.Scripts.Quality.Components.FrameGenQuality.FrameGenMode DLSS;  // const

    }

    // TypeToken: 0x200002F  // size: 0x11
    public sealed struct FrameRateQualityEnum
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnum FPS120;  // const
        public static Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnum FPS60;  // const
        public static Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnum FPS30;  // const

    }

    // TypeToken: 0x2000031  // size: 0x14
    public sealed struct ReasonEnum
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum Default;  // const
        public static Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum Init;  // const
        public static Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum Quality;  // const
        public static Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum Dialog;  // const
        public static Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum Cutscene;  // const
        public static Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum GMCommand;  // const

    }

    // TypeToken: 0x2000033  // size: 0x11
    public sealed struct FrameRateQualityMobileEnum
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnum FPS60;  // const
        public static Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnum FPS45;  // const
        public static Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnum FPS30;  // const

    }

    // TypeToken: 0x2000038  // size: 0x14
    public sealed struct HGAnisoLevel
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Scripts.Quality.Components.HGAnisoLevelQuality.HGAnisoLevel X1;  // const
        public static Beyond.Scripts.Quality.Components.HGAnisoLevelQuality.HGAnisoLevel X2;  // const
        public static Beyond.Scripts.Quality.Components.HGAnisoLevelQuality.HGAnisoLevel X4;  // const
        public static Beyond.Scripts.Quality.Components.HGAnisoLevelQuality.HGAnisoLevel X8;  // const

    }

    // TypeToken: 0x2000041  // size: 0x11
    public sealed struct TextureQualityEnum
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Scripts.Quality.Components.HGTextureQuality.TextureQualityEnum High;  // const
        public static Beyond.Scripts.Quality.Components.HGTextureQuality.TextureQualityEnum Medium;  // const
        public static Beyond.Scripts.Quality.Components.HGTextureQuality.TextureQualityEnum Low;  // const

    }

    // TypeToken: 0x200004A  // size: 0x14
    public sealed struct RenderingScaleMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleMode ExHigh;  // const
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleMode High;  // const
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleMode Medium;  // const
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleMode Low;  // const
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleMode ExLow;  // const

    }

    // TypeToken: 0x200004C  // size: 0x14
    public sealed struct RenderingScaleMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleMode Percent100;  // const
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleMode Percent90;  // const
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleMode Percent80;  // const
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleMode Percent70;  // const
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleMode Percent60;  // const

    }

    // TypeToken: 0x2000050  // size: 0x14
    public sealed struct ShaderLodEnum
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnum PC600;  // const
        public static Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnum Mobile500;  // const
        public static Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnum Mobile400;  // const
        public static Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnum Mobile300;  // const
        public static Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnum Mobile200;  // const
        public static Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnum Mobile100;  // const

    }

    // TypeToken: 0x2000055  // size: 0x14
    public sealed struct UpscalerMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Scripts.Quality.Components.UpscalerQuality.UpscalerMode DLSS;  // const
        public static Beyond.Scripts.Quality.Components.UpscalerQuality.UpscalerMode TAAU;  // const
        public static Beyond.Scripts.Quality.Components.UpscalerQuality.UpscalerMode FSR3;  // const

    }

namespace Beyond.Gameplay.BeyondPerformance
{

    // TypeToken: 0x2000009  // size: 0x11
    public sealed struct LogicQualityLevel
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Gameplay.BeyondPerformance.LogicQualityLevel Economy;  // const
        public static Beyond.Gameplay.BeyondPerformance.LogicQualityLevel Balanced;  // const
        public static Beyond.Gameplay.BeyondPerformance.LogicQualityLevel Performance;  // const
        public static Beyond.Gameplay.BeyondPerformance.LogicQualityLevel Max;  // const

    }

    // TypeToken: 0x200000A  // size: 0x11
    public sealed struct ThermalState
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Beyond.Gameplay.BeyondPerformance.ThermalState GameNormal;  // const
        public static Beyond.Gameplay.BeyondPerformance.ThermalState GameFair;  // const
        public static Beyond.Gameplay.BeyondPerformance.ThermalState GameSerious;  // const

    }

    // TypeToken: 0x200000B  // size: 0x10
    public static class LogicQualityConst
    {
        // Fields
        public static System.Single s_reduceQualityLevelFPSThresholdRatio;  // static @ 0x0
        public static System.Single s_recoverQualityLevelFPSThresholdRatio;  // static @ 0x4

        // Methods
        // RVA: 0x03D2C030  token: 0x6000009
        private static System.Void .cctor() { }

    }

}

namespace Beyond.PoolCore
{

    // TypeToken: 0x2000003  // size: 0x10
    public static class ListPoolInitializer_RuntimeQuality
    {
        // Fields
        private static System.Boolean s_initialized;  // static @ 0x0

        // Methods
        // RVA: 0x03CB2BE0  token: 0x6000002
        private static System.Void InitializeAtRuntime() { }
        // RVA: 0x03CB2C10  token: 0x6000003
        private static System.Void Initialize() { }

    }

}

namespace Beyond.Scripts.Quality
{

    // TypeToken: 0x200000C  // size: 0x88
    public class DeviceInfo
    {
        // Fields
        public UnityEngine.RuntimePlatform m_platform;  // 0x10
        private System.Int32 <DevicesScore>k__BackingField;  // 0x14
        public readonly System.String m_deviceModel;  // 0x18
        public readonly System.String m_deviceName;  // 0x20
        public readonly System.String m_graphicsDeviceName;  // 0x28
        public readonly System.String m_graphicsDeviceVersion;  // 0x30
        public readonly System.String m_cpuDeviceName;  // 0x38
        public readonly System.Int32 m_systemMemorySize;  // 0x40
        public readonly System.Int32 m_GPUMemorySize;  // 0x44
        public readonly System.Int32 m_processorCount;  // 0x48
        public readonly UnityEngine.Rendering.GraphicsDeviceType m_graphicsDeviceType;  // 0x4c
        public Beyond.Scripts.Quality.DeviceMatchRules m_matchRules;  // 0x50
        public Beyond.Scripts.Quality.DeviceMatchResult m_matchResult;  // 0x58
        public System.Boolean bEditorSimulator;  // 0x78
        public readonly System.String m_SystemInfo;  // 0x80
        private static System.String ADRENO_KEY;  // const
        private static System.String ADRENO_PATTERN;  // const
        private static System.String ADRENO_STANDARD_FORMAT;  // const
        private static System.String MALI_KEY;  // const
        private static System.String MALI_PATTERN;  // const
        private static System.String MALI_STANDARD_FORMAT;  // const
        private static System.String POWER_VR_KEY;  // const
        private static System.String POWER_VR_PATTERN;  // const
        private static System.String POWER_VR_STANDARD_FORMAT;  // const
        private static System.String NVIDIA_KEY;  // const
        private static System.String NVIDIA_PATTERN;  // const
        private static System.String NVIDIA_STANDARD_FORMAT;  // const
        private static System.String TITAN_PATTERN;  // const
        private static System.String NVIDIA_FALLBACK;  // const
        private static System.String AMD_KEY;  // const
        private static System.String AMD_PATTERN;  // const
        private static System.String AMD_STANDARD_FORMAT;  // const
        private static System.String AMD_FALLBACK;  // const
        private static System.String INTEL_KEY;  // const
        private static System.String INTEL_PATTERN;  // const
        private static System.String INTEL_STANDARD_FORMAT;  // const
        private static System.String INTEL_PATTERN_2;  // const
        private static System.String INTEL_FALLBACK;  // const

        // Properties
        System.Int32 DevicesScore { get; /* RVA: 0x03D50CC0 */ set; /* RVA: 0x03D595B0 */ }
        System.String cpuName { get; /* RVA: 0x04273158 */ }

        // Methods
        // RVA: 0x02CDA040  token: 0x600000C
        public System.Void .ctor(System.String remoteJson) { }
        // RVA: 0x0965EAD4  token: 0x600000D
        public System.Void .ctor(UnityEngine.RuntimePlatform platform, System.String deviceName, System.String deviceModel, System.String graphicsDeviceName, System.String graphicsDeviceVersion, System.String systemMemorySize, System.String processorName, System.String processorCount, System.String processorFrequency) { }
        // RVA: 0x02CDC4F0  token: 0x600000E
        public System.Void SupplementFromRemote(System.String json) { }
        // RVA: 0x0363B2A0  token: 0x600000F
        public virtual System.String ToString() { }
        // RVA: 0x0965E248  token: 0x6000010
        public System.Boolean IsNoMatchDevice() { }
        // RVA: 0x03B315F0  token: 0x6000011
        public System.Boolean IsZeroDevices() { }
        // RVA: 0x0965E18C  token: 0x6000013
        public System.Boolean IsHUAWEIDevice() { }
        // RVA: 0x0965E2A4  token: 0x6000014
        public System.Boolean IsQualcommDevice() { }
        // RVA: 0x02CDBF90  token: 0x6000015
        public Beyond.Scripts.Quality.DeviceMatchRules LoadingSettingRules() { }
        // RVA: 0x02CDBF20  token: 0x6000016
        public System.Int32 GetDeviceScore(System.String remoteJson) { }
        // RVA: 0x0965D380  token: 0x6000017
        public System.Int32 EditorSimulateGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo) { }
        // RVA: 0x0965DE4C  token: 0x6000018
        public System.Int32 IOSGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo) { }
        // RVA: 0x0965D184  token: 0x6000019
        public System.Int32 AndroidGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo) { }
        // RVA: 0x02CDC020  token: 0x600001A
        public System.Int32 StandaloneGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo) { }
        // RVA: 0x0965E804  token: 0x600001B
        public System.Int32 StandaloneOSXGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo) { }
        // RVA: 0x0965E858  token: 0x600001C
        public System.Int32 StandalonePS5GetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo) { }
        // RVA: 0x0965D32C  token: 0x600001D
        public System.Int32 DefaultGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo) { }
        // RVA: 0x02CDCF70  token: 0x600001E
        public System.Boolean RuleSuffixMatch(System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> list, System.String name, Beyond.Scripts.Quality.RankingRule& matchedRule) { }
        // RVA: 0x0965E624  token: 0x600001F
        public static System.Boolean RuleFullNameMatch(System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> list, System.String name, Beyond.Scripts.Quality.RankingRule& matchedRule) { }
        // RVA: 0x0965E328  token: 0x6000020
        public System.Boolean MatchDeviceModeRule(System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> list, System.String deviceModel, Beyond.Scripts.Quality.RankingRule& rule) { }
        // RVA: 0x0965E3D0  token: 0x6000021
        public System.Boolean MatchGPURule(Beyond.Scripts.Quality.DeviceMatchRules rules, System.String gpu, Beyond.Scripts.Quality.RankingRule& rule, System.String& standardName) { }
        // RVA: 0x02CDC5A0  token: 0x6000022
        private System.Boolean StandaloneMatchGPURule(Beyond.Scripts.Quality.DeviceMatchRules rules, System.String gpu, Beyond.Scripts.Quality.RankingRule& rule, System.String& standardName) { }
        // RVA: 0x0965DAC8  token: 0x6000023
        private System.String GetNvidiaStandardGPUName(System.String gpu) { }
        // RVA: 0x02CDC720  token: 0x6000024
        private System.String GetAmdStandardGPUName(System.String gpu) { }
        // RVA: 0x0965D580  token: 0x6000025
        private System.String GetIntelStandardGPUName(System.String gpu) { }
        // RVA: 0x0965D444  token: 0x6000026
        private System.String GetAdrenoStandardGPUName(System.String gpu) { }
        // RVA: 0x0965D7E0  token: 0x6000027
        private System.String GetMaliStandardGPUName(System.String gpu) { }
        // RVA: 0x0965DD10  token: 0x6000028
        private System.String GetPowerVRStandardGPUName(System.String gpu) { }
        // RVA: 0x0965E908  token: 0x6000029
        private static System.Void _ReportMatchRuleFailed(Beyond.Scripts.Quality.DeviceInfo deviceModel) { }
        // RVA: 0x05459F38  token: 0x600002A
        public System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x200000E  // size: 0x20
    public sealed struct RankingRule : System.IEquatable`1
    {
        // Fields
        public System.String regexPattern;  // 0x10
        public System.Int32 targetScore;  // 0x18

        // Methods
        // RVA: 0x02AB5050  token: 0x600002B
        public virtual System.Boolean Equals(Beyond.Scripts.Quality.RankingRule other) { }
        // RVA: 0x0363B7D0  token: 0x600002C
        public virtual System.String ToString() { }
        // RVA: 0x09665EAC  token: 0x600002D
        public System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x200000F  // size: 0x1C
    public sealed struct MemoryRule : System.IEquatable`1
    {
        // Fields
        public UnityEngine.Vector2 range;  // 0x10
        public System.Int32 targetScore;  // 0x18

        // Methods
        // RVA: 0x09662A4C  token: 0x600002E
        public virtual System.String ToString() { }
        // RVA: 0x096629DC  token: 0x600002F
        public virtual System.Boolean Equals(Beyond.Scripts.Quality.MemoryRule other) { }
        // RVA: 0x09662B18  token: 0x6000030
        public System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000010  // size: 0x10
    public static class ListUtils
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000031
        public static System.Void AddOrReplace(System.Collections.Generic.List<TItem> source, System.Collections.Generic.List<TItem> remote) { }

    }

    // TypeToken: 0x2000011  // size: 0x98
    public class DeviceMatchRules
    {
        // Fields
        public System.Int32 DefaultIOSRankingRule;  // 0x10
        public System.Int32 DefaultAndroidScore;  // 0x14
        public System.Int32 DefaultStandAloneScore;  // 0x18
        public System.Int32 DefaultPowerVRScore;  // 0x1c
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> appleWhiteList;  // 0x20
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> appleGPUList;  // 0x28
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> androidWhiteList;  // 0x30
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> adrenoRulesList;  // 0x38
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> maliRulesList;  // 0x40
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> powerVRRulesList;  // 0x48
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> androidGPUWhiteList;  // 0x50
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> androidCPUWhiteList;  // 0x58
        public System.Collections.Generic.List<Beyond.Scripts.Quality.MemoryRule> iOSMemoryRules;  // 0x60
        public System.Collections.Generic.List<Beyond.Scripts.Quality.MemoryRule> androidMemoryRules;  // 0x68
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> nvidiaRulesList;  // 0x70
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> amdRulesList;  // 0x78
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> intelRulesList;  // 0x80
        public System.Collections.Generic.List<Beyond.Scripts.Quality.MemoryRule> standaloneMemoryRules;  // 0x88
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> macSocRulesList;  // 0x90

        // Methods
        // RVA: 0x02CDD7A0  token: 0x6000032
        public System.Void Combine(Beyond.Scripts.Quality.DeviceMatchRules other) { }
        // RVA: 0x03D23720  token: 0x6000033
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000012  // size: 0x30
    public sealed struct DeviceMatchResult
    {
        // Fields
        private Beyond.Scripts.Quality.RankingRule m_rule;  // 0x10
        private Beyond.Scripts.Quality.DeviceInfo.MatchType m_matchType;  // 0x20
        private System.String gpuStandardName;  // 0x28

        // Methods
        // RVA: 0x02CDC4C0  token: 0x6000034
        public System.Void .ctor(Beyond.Scripts.Quality.RankingRule r, Beyond.Scripts.Quality.DeviceInfo.MatchType type, System.String gpuStandardName) { }
        // RVA: 0x0363B640  token: 0x6000035
        public virtual System.String ToString() { }
        // RVA: 0x0965EB6C  token: 0x6000036
        public System.Boolean IsNoMatch() { }
        // RVA: 0x0965EBB8  token: 0x6000037
        public System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000013  // size: 0x38
    public sealed struct DeviceQualityMapItem
    {
        // Fields
        public System.String name;  // 0x10
        public System.Int32 deviceScore;  // 0x18
        public System.Int32 defaultLevel;  // 0x1c
        public System.Int32 veryLowLevel;  // 0x20
        public System.Int32 lowLevel;  // 0x24
        public System.Int32 middleLevel;  // 0x28
        public System.Int32 highLevel;  // 0x2c
        public System.Int32 veryHighLevel;  // 0x30

        // Methods
        // RVA: 0x0965EC10  token: 0x6000038
        public virtual System.String ToString() { }
        // RVA: 0x0965EEA8  token: 0x6000039
        private UnityEngine.Color getColor(System.Int32 level) { }
        // RVA: 0x0965F110  token: 0x600003A
        private UnityEngine.Color getVeryLowColor() { }
        // RVA: 0x0965EFB4  token: 0x600003B
        private UnityEngine.Color getLowColor() { }
        // RVA: 0x0965F028  token: 0x600003C
        private UnityEngine.Color getMiddleColor() { }
        // RVA: 0x0965EF40  token: 0x600003D
        private UnityEngine.Color getHighColor() { }
        // RVA: 0x0965F09C  token: 0x600003E
        private UnityEngine.Color getVeryHighColor() { }
        // RVA: 0x0965EE44  token: 0x600003F
        public System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000014  // size: 0x20
    public class DeviceQualityMap
    {
        // Fields
        public UnityEngine.RuntimePlatform m_platform;  // 0x10
        public System.Collections.Generic.List<Beyond.Scripts.Quality.DeviceQualityMapItem> items;  // 0x18

        // Methods
        // RVA: 0x03CA7500  token: 0x6000040
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000015  // size: 0x10
    public static class QualityConst
    {
        // Fields
        public static System.String SIMULATE_DEVICE_LIST;  // const
        public static System.String SETTING_RULES;  // const
        public static System.String QUALITY_MAP;  // const
        public static System.String QUALITY_TIER_COMPONENTS;  // const

    }

    // TypeToken: 0x2000016  // size: 0x98
    public class QualityManager : Beyond.Singleton`1, System.IDisposable
    {
        // Fields
        private Beyond.Scripts.Quality.DeviceInfo m_deviceInfo;  // 0x10
        private Beyond.Scripts.Quality.DeviceQualityMap m_qualityMap;  // 0x18
        private Beyond.Scripts.Quality.DeviceQualityMapItem m_matchedConfig;  // 0x20
        private System.Collections.Generic.Dictionary<Beyond.GameSetting.GameSettingVideoQuality,System.Int32> m_qualityScoreMap;  // 0x48
        private System.Collections.Generic.List<Beyond.Scripts.Quality.Components.QualityTierLevel> m_qualityTiers;  // 0x50
        private System.Collections.Generic.HashSet<System.Type> m_qualityTierTypes;  // 0x58
        private System.Collections.Generic.Dictionary<System.Type,Beyond.Scripts.Quality.Components.QualityTierComponentMatch> m_currentQualityTierComponent;  // 0x60
        private System.Collections.Generic.Dictionary<System.Type,Beyond.Scripts.Quality.Components.QualityTierComponentMatch> m_overrideQualityTierComponent;  // 0x68
        private System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.Type,System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>>> m_qualityTierComponentChangeCallBack;  // 0x70
        private System.Collections.Generic.Queue<System.ValueTuple<System.Type,System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>>> m_queue;  // 0x78
        private System.Int32 m_defaultTier;  // 0x80
        private System.Int32 m_currentTier;  // 0x84
        private System.Boolean m_overrideFinish;  // 0x88
        private System.Func<System.Type,System.Boolean> resetSaveQualityTier;  // 0x90
        private static System.Collections.Generic.HashSet<System.Int32> s_matchCount;  // static @ 0x0
        private static System.Collections.Generic.HashSet<Beyond.Scripts.Quality.Components.QualityTierComponentMatch> s_matchQuality;  // static @ 0x8

        // Properties
        Beyond.Scripts.Quality.DeviceQualityMapItem Config { get; /* RVA: 0x03D581B0 */ }
        System.Int32 currentTier { get; /* RVA: 0x03D4F370 */ }
        System.Int32 defaultTier { get; /* RVA: 0x03D4EC20 */ }
        Beyond.Scripts.Quality.DeviceInfo device { get; /* RVA: 0x020B7B20 */ }
        System.Boolean isInitializing { get; /* RVA: 0x02AB2090 */ }

        // Methods
        // RVA: 0x03A26670  token: 0x6000045
        private System.Void .ctor() { }
        // RVA: 0x03100CE0  token: 0x6000046
        public System.Void Init(System.String remoteJson) { }
        // RVA: 0x03B34E20  token: 0x6000047
        public System.Void InitOnlyDevice(System.String remoteJson) { }
        // RVA: 0x031010C0  token: 0x6000048
        public System.Void InitShaderLod() { }
        // RVA: 0x02AB7210  token: 0x6000049
        public System.Void FinishInit() { }
        // RVA: 0x03103210  token: 0x600004B
        public virtual System.Void Dispose() { }
        // RVA: 0x0283C160  token: 0x600004C
        public System.Void LoadQualityTier(System.String overridePlatform) { }
        // RVA: 0x02AB5120  token: 0x600004D
        private System.Void setQualityTier(System.Int32 qualityTier) { }
        // RVA: 0x030FF830  token: 0x600004E
        public System.Void ApplyQualityScore() { }
        // RVA: 0x03100280  token: 0x600004F
        public System.Void ApplyShaderTier() { }
        // RVA: 0x0283F990  token: 0x6000050
        private System.Type _GetQualityComponentByName(System.String typeName) { }
        // RVA: 0x09665048  token: 0x6000051
        public System.Void SetQualityTierByVideoQuality(Beyond.GameSetting.GameSettingVideoQuality VideoQuality) { }
        // RVA: 0x096633C8  token: 0x6000052
        public Beyond.GameSetting.GameSettingVideoQuality GetDefaultVideoQuality() { }
        // RVA: 0x03B315B0  token: 0x6000053
        public System.Boolean NoMatchDeviceOrZeroScore() { }
        // RVA: 0x09664B04  token: 0x6000054
        public System.Boolean IsQualcommDevice() { }
        // RVA: 0x09664A3C  token: 0x6000055
        public System.Boolean IsHUAWEIDevice() { }
        // RVA: 0x09664A90  token: 0x6000056
        public static System.Boolean IsIpadDevice() { }
        // RVA: 0x09664C68  token: 0x6000057
        public System.Boolean IsVideoQualityEnable(Beyond.GameSetting.GameSettingVideoQuality VideoQuality) { }
        // RVA: 0x03C84EC0  token: 0x6000058
        public System.Void InitResetQualityTierComponentFunction(System.Func<System.Type,System.Boolean> func) { }
        // RVA: 0x02AB0C60  token: 0x6000059
        public System.Boolean ResetQualityTierComponentValue(System.Type type) { }
        // RVA: 0x0283CCE0  token: 0x600005A
        private Beyond.Scripts.Quality.Components.QualityTierComponentMatch _SetQualityTierComponentLevel(System.Type type, System.Int32 level) { }
        // RVA: 0x03100B70  token: 0x600005B
        public System.Void ForceSetQualityTierComponentLevel(System.String type, System.Int32 level) { }
        // RVA: 0x09664EBC  token: 0x600005C
        public System.Void RevertSetQualityTierComponentLevel(System.String type) { }
        // RVA: 0x09664CC4  token: 0x600005D
        public System.Boolean NeedRestart() { }
        // RVA: 0x02AB7150  token: 0x600005E
        public System.Void ApplyCallBack() { }
        // RVA: 0x02AB3D80  token: 0x600005F
        private Beyond.Scripts.Quality.Components.QualityTierComponentMatch _GetOverrideQualityTierComponentLevel(System.Type type) { }
        // RVA: 0x02AB6FF0  token: 0x6000060
        public Beyond.Scripts.Quality.Components.QualityTierType GetQualityTierComponentTierType(System.String type) { }
        // RVA: 0x02AB6260  token: 0x6000061
        public System.Int32 GetQualityTierComponentTierVersion(System.String type) { }
        // RVA: 0x02AB3C60  token: 0x6000062
        private System.Boolean _IsToggleQualityTierComponent(System.String type) { }
        // RVA: 0x039C4C10  token: 0x6000063
        private System.Void _ToggleQualityTierComponentLevel(System.String type, System.Int32 index) { }
        // RVA: 0x02AB48D0  token: 0x6000064
        public System.Boolean IsEnumQualityTierComponent(System.String type) { }
        // RVA: 0x09663534  token: 0x6000065
        public System.Int32 GetEnumQualityTierComponentCount(System.String type) { }
        // RVA: 0x03A20110  token: 0x6000066
        public System.Void SetEnumQualityTierComponentCount(System.String type, System.Int32 index) { }
        // RVA: 0x02AB49B0  token: 0x6000067
        public System.Boolean IsSliderQualityTierComponent(System.String type) { }
        // RVA: 0x096650E8  token: 0x6000068
        public System.Void SetSliderQualityTierComponentCount(System.String type, System.Single value) { }
        // RVA: 0x09664778  token: 0x6000069
        public UnityEngine.Vector3 GetSliderQualityTierComponent(System.String type) { }
        // RVA: 0x096648AC  token: 0x600006A
        public System.Boolean InvokeQualityTierComponent(System.String type, System.String functionName, System.Object[] parameters) { }
        // RVA: -1  // generic def  token: 0x600006B
        public System.Void RegisterQualityTierComponentChange(System.Type tierType, System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent> cb) { }
        // RVA: 0x02AB4A90  token: 0x600006C
        private System.Void InvokeChangeCallBack(System.Type type, Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent) { }
        // RVA: 0x09664408  token: 0x600006D
        public System.ValueTuple<System.Single,System.Single> GetQualityTierComponentTierCount(System.String type) { }
        // RVA: 0x09663608  token: 0x600006E
        public System.Single GetQualityComponentDefaultTier(System.String type) { }
        // RVA: 0x09663D0C  token: 0x600006F
        public System.Single GetQualityComponentTier(System.String type) { }
        // RVA: 0x028F43E0  token: 0x6000070
        public System.Void SetQualityComponentTier(System.String type, System.Single index) { }
        // RVA: 0x09664B58  token: 0x6000071
        public System.Boolean IsQualitySubSettingTierValid(System.String type, System.Int32 tier) { }
        // RVA: 0x09665498  token: 0x6000072
        private System.Void _GetCurrentComponentTierIndex(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent, System.Int32& index, System.Int32& defaultTierIndex) { }
        // RVA: 0x09665238  token: 0x6000073
        public virtual System.String ToString() { }
        // RVA: 0x09662D9C  token: 0x6000074
        public System.String DebugQualityTierComponentInfo() { }
        // RVA: 0x02AB21C0  token: 0x6000075
        private static System.Void _ReportQuality() { }
        // RVA: 0x03102880  token: 0x6000076
        private System.Void _DynamicInitQualitySetting() { }
        // RVA: 0x03102710  token: 0x6000077
        private System.Void _DynamicReleaseQualitySetting() { }
        // RVA: 0x02AB3E40  token: 0x6000078
        private System.Void DynamicQualityChange(Beyond.EventData<Beyond.Gameplay.BeyondPerformance.LogicQualityLevel,Beyond.Gameplay.BeyondPerformance.LogicQualityLevel>& data) { }
        // RVA: 0x096631C8  token: 0x6000079
        private System.Void DynamicThermalChange(Beyond.EventData<Beyond.Gameplay.BeyondPerformance.ThermalState,Beyond.Gameplay.BeyondPerformance.ThermalState>& data) { }
        // RVA: 0x03C7A9D0  token: 0x600007A
        private static System.Void .cctor() { }
        // RVA: 0x05459F38  token: 0x600007B
        public System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000018  // size: 0x10
    public static class QualityUtility
    {
        // Fields
        private static Newtonsoft.Json.JsonSerializerSettings s_settings;  // static @ 0x0

        // Properties
        Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get; /* RVA: 0x02AB6440 */ }

        // Methods
        // RVA: -1  // generic def  token: 0x6000086
        public static T LoadFromCompressedJson() { }
        // RVA: -1  // generic def  token: 0x6000087
        public static T LoadingQualityJson(System.String path) { }
        // RVA: -1  // generic def  token: 0x6000088
        public static T LoadingQualityJsonFromString(System.String value) { }
        // RVA: 0x09665BEC  token: 0x6000089
        private static System.Byte[] Decompress(System.Byte[] data) { }

    }

}

namespace Beyond.Scripts.Quality.Components
{

    // TypeToken: 0x2000019  // size: 0x30
    public class AntiAliasingQuality : Beyond.Scripts.Quality.Components.EnumQualityComponent`1
    {
        // Methods
        // RVA: 0x0965CE64  token: 0x600008B
        protected virtual System.Void Apply() { }
        // RVA: 0x0965CEA4  token: 0x600008C
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x600008D
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200001B
    public interface IEnumQualityComponent
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600008E
        public virtual System.Int32 GetEnumIndex(System.Enum enumValue) { }
        // RVA: -1  // abstract  token: 0x600008F
        public virtual System.Int32 GetEnumIndex() { }
        // RVA: -1  // abstract  token: 0x6000090
        public virtual System.Int32 GetDefaultEnumIndex() { }
        // RVA: -1  // abstract  token: 0x6000091
        public virtual System.Int32 GetEnumCount() { }
        // RVA: -1  // abstract  token: 0x6000092
        public virtual System.Void SetEnumIndex(System.Int32 value) { }
        // RVA: -1  // abstract  token: 0x6000093
        public virtual System.String GetEnumName(System.Int32 index) { }

    }

    // TypeToken: 0x200001C
    public class EnumQualityComponent`1 : Beyond.Scripts.Quality.Components.QualityTierComponent, Beyond.Scripts.Quality.Components.IEnumQualityComponent, Beyond.Scripts.Quality.Components.IQualityComponentExtension`1
    {
        // Fields
        private T enumValue;  // 0x0
        private System.Nullable<System.Int32> m_currentValue;  // 0x0
        private System.String[] m_strings;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000094
        public virtual System.Int32 GetEnumIndex(System.Enum enumValue) { }
        // RVA: -1  // not resolved  token: 0x6000095
        public virtual System.Int32 GetEnumIndex() { }
        // RVA: -1  // not resolved  token: 0x6000096
        public virtual System.Int32 GetDefaultEnumIndex() { }
        // RVA: -1  // not resolved  token: 0x6000097
        public virtual System.Int32 GetEnumCount() { }
        // RVA: -1  // not resolved  token: 0x6000098
        public virtual System.Void SetEnumIndex(System.Int32 value) { }
        // RVA: -1  // not resolved  token: 0x6000099
        public virtual System.String GetEnumName(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600009A
        public System.Void SetEnum(T value) { }
        // RVA: -1  // not resolved  token: 0x600009B
        public virtual T GetValue() { }
        // RVA: -1  // not resolved  token: 0x600009C
        public virtual T GetDefaultValue() { }
        // RVA: -1  // not resolved  token: 0x600009D
        public System.Void SetEnumWithOutApply(T value) { }
        // RVA: -1  // not resolved  token: 0x600009E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001D  // size: 0x14
    public sealed struct QualityTierType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Scripts.Quality.Components.QualityTierType Quality;  // const
        public static Beyond.Scripts.Quality.Components.QualityTierType ToggleQuality;  // const
        public static Beyond.Scripts.Quality.Components.QualityTierType EnumQuality;  // const
        public static Beyond.Scripts.Quality.Components.QualityTierType SliderQuality;  // const

    }

    // TypeToken: 0x200001E
    public interface IQualityComponentExtension`1
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600009F
        public virtual T GetValue() { }
        // RVA: -1  // abstract  token: 0x60000A0
        public virtual T GetDefaultValue() { }

    }

    // TypeToken: 0x200001F  // size: 0x18
    public abstract class QualityTierComponent
    {
        // Fields
        public static System.Action<System.String,System.Int32> s_removeRegisterKeyAction;  // static @ 0x0
        private System.Boolean isNeedStartDirty;  // 0x10

        // Methods
        // RVA: 0x03B2EA60  token: 0x60000A1
        protected virtual System.Void Apply() { }
        // RVA: 0x02AB6220  token: 0x60000A2
        protected virtual System.Void InitApply() { }
        // RVA: 0x09665A84  token: 0x60000A3
        protected virtual System.Void LowMemory() { }
        // RVA: 0x02AB3D40  token: 0x60000A4
        protected virtual System.Void DynamicQualityChange(Beyond.Gameplay.BeyondPerformance.LogicQualityLevel current, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel last) { }
        // RVA: 0x09665A20  token: 0x60000A5
        protected virtual System.Void DynamicThermalChange(Beyond.Gameplay.BeyondPerformance.ThermalState current, Beyond.Gameplay.BeyondPerformance.ThermalState last) { }
        // RVA: 0x02AB63A0  token: 0x60000A6
        public virtual System.Int32 Version() { }
        // RVA: 0x09665BA4  token: 0x60000A7
        public virtual System.Boolean TierLimit() { }
        // RVA: 0x02AB61F0  token: 0x60000A8
        private virtual System.Int32 ApplyOrder() { }
        // RVA: 0x09665AC4  token: 0x60000A9
        private System.Void RemoveQualitySettingSaveValue(System.String settingId) { }
        // RVA: 0x02AB20A0  token: 0x60000AA
        private System.Void SafeApply() { }
        // RVA: 0x03A2D0F0  token: 0x60000AB
        private System.Void RemoveRegisterKey() { }
        // RVA: 0x02AB50A0  token: 0x60000AC
        private System.Void SafeLowMemory(System.Boolean init) { }
        // RVA: 0x02AB4800  token: 0x60000AD
        private System.Void CallDynamicQualityChange(Beyond.Gameplay.BeyondPerformance.LogicQualityLevel current, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel last) { }
        // RVA: 0x096659A8  token: 0x60000AE
        private virtual System.Void CallDynamicThermalChange(Beyond.Gameplay.BeyondPerformance.ThermalState current, Beyond.Gameplay.BeyondPerformance.ThermalState last) { }
        // RVA: 0x0350B670  token: 0x60000AF
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000020  // size: 0x20
    public sealed struct QualityTierComponentMatch
    {
        // Fields
        public Beyond.Scripts.Quality.Components.QualityTierComponent component;  // 0x10
        public Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSource matchSource;  // 0x18
        public System.Int32 matchQualityTier;  // 0x1c

    }

    // TypeToken: 0x2000022  // size: 0x20
    public class QualityTierLevel
    {
        // Fields
        public System.Int32 qualityTier;  // 0x10
        public System.Collections.Generic.List<Beyond.Scripts.Quality.Components.QualityTierComponent> qualityTierComponents;  // 0x18

        // Methods
        // RVA: 0x03915F20  token: 0x60000B0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000023  // size: 0x30
    public class SliderQualityComponent : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        private System.Single sliderValue;  // 0x18
        private System.Single MaxSliderValue;  // 0x1c
        private System.Single MinSliderValue;  // 0x20
        private System.Nullable<System.Single> m_currentSliderValue;  // 0x24

        // Methods
        // RVA: 0x02AB1BB0  token: 0x60000B1
        public System.Single GetValue() { }
        // RVA: 0x02AB1C20  token: 0x60000B2
        public System.Single GetDefaultValue() { }
        // RVA: 0x096667C8  token: 0x60000B3
        public UnityEngine.Vector2 GetRange() { }
        // RVA: 0x09666820  token: 0x60000B4
        public System.Void SetValue(System.Single value) { }
        // RVA: 0x0350B670  token: 0x60000B5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000024  // size: 0x20
    public class ToggleQualityComponent : Beyond.Scripts.Quality.Components.QualityTierComponent, Beyond.Scripts.Quality.Components.IQualityComponentExtension`1
    {
        // Fields
        private System.Boolean toggleVal;  // 0x18
        private System.Nullable<System.Boolean> m_currentValue;  // 0x19

        // Methods
        // RVA: 0x02AB6B20  token: 0x60000B6
        protected virtual System.Void Apply() { }
        // RVA: 0x09666984  token: 0x60000B7
        protected virtual System.Void Toggle(System.Boolean value) { }
        // RVA: 0x039C4D50  token: 0x60000B8
        public System.Void ChangeToggle(System.Int32 index) { }
        // RVA: 0x02AB63D0  token: 0x60000B9
        public virtual System.Boolean GetValue() { }
        // RVA: 0x02AB1C50  token: 0x60000BA
        public virtual System.Boolean GetDefaultValue() { }
        // RVA: 0x0350B670  token: 0x60000BB
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x60000BC
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000025  // size: 0x28
    public class CharacterRenderFeatureQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public System.Int32 characterSelfShadowOffLodQuality;  // 0x18
        public System.Int32 characterShadowTierLevel;  // 0x1c
        public System.Int32 characterOutlineTierLevel;  // 0x20

        // Methods
        // RVA: 0x03CE0400  token: 0x60000BD
        protected virtual System.Void Apply() { }
        // RVA: 0x03D4B940  token: 0x60000BE
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x60000BF
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000026  // size: 0x20
    public class ChromaticAberrationQuality : Beyond.Scripts.Quality.Components.ToggleQualityComponent
    {
        // Fields
        private static System.Int32 ENABLE_TIER;  // const
        private static System.Int32 DISABLE_TIER;  // const

        // Methods
        // RVA: 0x035A5650  token: 0x60000C0
        protected virtual System.Void Toggle(System.Boolean value) { }
        // RVA: 0x0350B670  token: 0x60000C1
        public System.Void .ctor() { }
        // RVA: 0x0965CECC  token: 0x60000C2
        public System.Void <>iFixBaseProxy_Toggle(System.Boolean P0) { }

    }

    // TypeToken: 0x2000027  // size: 0x38
    public class DLSSFrameGenQuality : Beyond.Scripts.Quality.Components.EnumQualityComponent`1
    {
        // Fields
        private System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent> callback;  // 0x30

        // Methods
        // RVA: 0x03B0DD70  token: 0x60000C3
        protected virtual System.Void Apply() { }
        // RVA: 0x02C99490  token: 0x60000C4
        protected System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x02AB1070  token: 0x60000C5
        private System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent) { }
        // RVA: 0x0965CED4  token: 0x60000C6
        public System.Boolean ShouldShowAuto() { }
        // RVA: 0x0965CF20  token: 0x60000C7
        public System.Boolean ShouldShowX1() { }
        // RVA: 0x0965CF6C  token: 0x60000C8
        public System.Boolean ShouldShowX2() { }
        // RVA: 0x0965CFC8  token: 0x60000C9
        public System.Boolean ShouldShowX3() { }
        // RVA: 0x0965D024  token: 0x60000CA
        public System.Boolean ShouldShow() { }
        // RVA: 0x03D47AA0  token: 0x60000CB
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x60000CC
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000029  // size: 0x38
    public class DLSSUpscalerQuality : Beyond.Scripts.Quality.Components.EnumQualityComponent`1
    {
        // Fields
        private System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent> callback;  // 0x30

        // Methods
        // RVA: 0x03B212A0  token: 0x60000CD
        protected virtual System.Void Apply() { }
        // RVA: 0x0965D0CC  token: 0x60000CE
        public System.Boolean ShouldShow() { }
        // RVA: 0x02C99530  token: 0x60000CF
        protected System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x02AB1110  token: 0x60000D0
        private System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent) { }
        // RVA: 0x03D47A70  token: 0x60000D1
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x60000D2
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200002A  // size: 0x20
    public class EnvironmentRenderingFeatureQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public System.Int32 environmentRenderingFeatureQualityTier;  // 0x18

        // Methods
        // RVA: 0x035A5B50  token: 0x60000D3
        protected virtual System.Void Apply() { }
        // RVA: 0x0350B670  token: 0x60000D4
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x60000D5
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200002B  // size: 0x30
    public class FrameGenQuality : Beyond.Scripts.Quality.Components.EnumQualityComponent`1
    {
        // Methods
        // RVA: 0x02AB13E0  token: 0x60000D6
        protected virtual System.Void Apply() { }
        // RVA: 0x0965F46C  token: 0x60000D7
        public System.Boolean ShouldShow() { }
        // RVA: 0x0965F41C  token: 0x60000D8
        public System.Boolean ShouldShowDLSS() { }
        // RVA: 0x03D479E0  token: 0x60000D9
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x60000DA
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200002D  // size: 0x20
    public class FrameGenQualityMobile : Beyond.Scripts.Quality.Components.ToggleQualityComponent
    {
        // Methods
        // RVA: 0x0965F23C  token: 0x60000DB
        protected virtual System.Void Apply() { }
        // RVA: 0x0965F348  token: 0x60000DC
        public System.Boolean ShouldShow() { }
        // RVA: 0x0350B670  token: 0x60000DD
        public System.Void .ctor() { }
        // RVA: 0x0965F414  token: 0x60000DE
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200002E  // size: 0x30
    public class FrameRateQuality : Beyond.Scripts.Quality.Components.EnumQualityComponent`1
    {
        // Properties
        System.Int32 frameRate { get; /* RVA: 0x037FF410 */ }

        // Methods
        // RVA: 0x037FF460  token: 0x60000E0
        public static System.Int32 GetFrameRateFromEnum(Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnum enumValue) { }
        // RVA: 0x03D1F290  token: 0x60000E1
        public virtual System.Int32 Version() { }
        // RVA: 0x0965F9C4  token: 0x60000E2
        public System.Boolean ShouldShow() { }
        // RVA: 0x037FF390  token: 0x60000E3
        protected virtual System.Void Apply() { }
        // RVA: 0x0965F854  token: 0x60000E4
        private System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent) { }
        // RVA: 0x02C9A3E0  token: 0x60000E5
        protected System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x0965FA6C  token: 0x60000E6
        private System.Boolean _FPS30Enabled() { }
        // RVA: 0x0965FAB8  token: 0x60000E7
        private System.Boolean _FPS60Enabled() { }
        // RVA: 0x0965FB04  token: 0x60000E8
        private System.Boolean _FPSBNoLimitEnabled() { }
        // RVA: 0x0965FB50  token: 0x60000E9
        private System.Boolean _IsGDLSSGDisable() { }
        // RVA: 0x03D479B0  token: 0x60000EA
        public System.Void .ctor() { }
        // RVA: 0x060BBCC0  token: 0x60000EB
        public System.Int32 <>iFixBaseProxy_Version() { }
        // RVA: 0x05A73D24  token: 0x60000EC
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000030  // size: 0x10
    public class HgFrameRateControl
    {
        // Fields
        public static System.Int32 s_cinematicFrameRate;  // static @ 0x0
        public static System.Collections.Generic.Stack<System.ValueTuple<System.Int32,System.Int32,Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum>> s_rateStack;  // static @ 0x8
        public static System.Action<System.Int32,System.Int32> s_OnFrameRateChanged;  // static @ 0x10

        // Methods
        // RVA: 0x037FF360  token: 0x60000ED
        public static System.Int32 GetDefaultFrameRate() { }
        // RVA: 0x037FF240  token: 0x60000EE
        public static System.Void Init() { }
        // RVA: 0x09660320  token: 0x60000EF
        public static System.Void SetFrameRateOverrider(System.Int32 frameRate, Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum reason) { }
        // RVA: 0x0965FED8  token: 0x60000F0
        public static System.Int32 GetFrameRate() { }
        // RVA: 0x09660050  token: 0x60000F1
        public static System.Boolean IsHighFrameRate() { }
        // RVA: 0x09660074  token: 0x60000F2
        public static System.Int32 RecommendedDefaultFrameRate() { }
        // RVA: 0x0965FF1C  token: 0x60000F3
        public static System.Int32 GetUserSettingFrameRate() { }
        // RVA: 0x037FF4A0  token: 0x60000F4
        public static System.Void __ForceSetFrameRate(System.Int32 frameRate, Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum reason) { }
        // RVA: 0x096601A8  token: 0x60000F5
        public static System.Void ResetFrameRate() { }
        // RVA: 0x0350B670  token: 0x60000F6
        public System.Void .ctor() { }
        // RVA: 0x037FF2B0  token: 0x60000F7
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000032  // size: 0x38
    public class FrameRateQualityMobile : Beyond.Scripts.Quality.Components.EnumQualityComponent`1
    {
        // Fields
        private System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent> callback;  // 0x30

        // Properties
        System.Int32 frameRate { get; /* RVA: 0x0965F810 */ }

        // Methods
        // RVA: 0x0965F544  token: 0x60000F9
        public static System.Int32 GetFrameRateFromEnum(Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnum enumValue) { }
        // RVA: 0x0965F798  token: 0x60000FA
        public virtual System.Int32 Version() { }
        // RVA: 0x0965F4BC  token: 0x60000FB
        protected virtual System.Void Apply() { }
        // RVA: 0x0965F5B8  token: 0x60000FC
        protected System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x0965F7E8  token: 0x60000FD
        public System.Void .ctor() { }
        // RVA: 0x060BBCC0  token: 0x60000FE
        public System.Int32 <>iFixBaseProxy_Version() { }
        // RVA: 0x05A73D24  token: 0x60000FF
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000034  // size: 0x38
    public class FSR3UpscalerQuality : Beyond.Scripts.Quality.Components.EnumQualityComponent`1
    {
        // Fields
        private System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent> callback;  // 0x30

        // Methods
        // RVA: 0x03B21160  token: 0x6000100
        protected virtual System.Void Apply() { }
        // RVA: 0x0965F184  token: 0x6000101
        public System.Boolean ShouldShow() { }
        // RVA: 0x02C995D0  token: 0x6000102
        protected System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x02AB11E0  token: 0x6000103
        private System.Void FSR3Change(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent) { }
        // RVA: 0x03D47A40  token: 0x6000104
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x6000105
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000035  // size: 0x20
    public class GrassSparsityQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public System.Int32 grassSparsityQualityTier;  // 0x18

        // Methods
        // RVA: 0x035A56E0  token: 0x6000106
        protected virtual System.Void Apply() { }
        // RVA: 0x0350B670  token: 0x6000107
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x6000108
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000036  // size: 0x20
    public class HGAmbientOcclusionQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public System.Int32 aoQualityTier;  // 0x18

        // Methods
        // RVA: 0x035A5BF0  token: 0x6000109
        protected virtual System.Void Apply() { }
        // RVA: 0x0350B670  token: 0x600010A
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x600010B
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000037  // size: 0x30
    public class HGAnisoLevelQuality : Beyond.Scripts.Quality.Components.EnumQualityComponent`1
    {
        // Methods
        // RVA: 0x03CC45A0  token: 0x600010C
        protected virtual System.Void InitApply() { }
        // RVA: 0x0965FBF8  token: 0x600010D
        protected virtual System.Void Apply() { }
        // RVA: 0x03D47980  token: 0x600010E
        public System.Void .ctor() { }
        // RVA: 0x0965FCFC  token: 0x600010F
        public System.Void <>iFixBaseProxy_InitApply() { }
        // RVA: 0x05A73D24  token: 0x6000110
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000039  // size: 0x20
    public class HGContactShadowQuality : Beyond.Scripts.Quality.Components.ToggleQualityComponent
    {
        // Fields
        private static System.Int32 ENABLE_TIER;  // const
        private static System.Int32 DISABLE_TIER;  // const

        // Methods
        // RVA: 0x035A5750  token: 0x6000111
        protected virtual System.Void Toggle(System.Boolean value) { }
        // RVA: 0x0350B670  token: 0x6000112
        public System.Void .ctor() { }
        // RVA: 0x0965CECC  token: 0x6000113
        public System.Void <>iFixBaseProxy_Toggle(System.Boolean P0) { }

    }

    // TypeToken: 0x200003A  // size: 0x18
    public class HGIrradianceVolumeQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Methods
        // RVA: 0x0965FD04  token: 0x6000114
        protected virtual System.Void LowMemory() { }
        // RVA: 0x0350B670  token: 0x6000115
        public System.Void .ctor() { }
        // RVA: 0x05A73D2C  token: 0x6000116
        public System.Void <>iFixBaseProxy_LowMemory() { }

    }

    // TypeToken: 0x200003B  // size: 0x20
    public class HGLODStreamingComponent : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public System.Boolean enableLODStreaming;  // 0x18

        // Methods
        // RVA: 0x03D00F70  token: 0x6000117
        protected virtual System.Void Apply() { }
        // RVA: 0x0965FD48  token: 0x6000118
        protected virtual System.Void LowMemory() { }
        // RVA: 0x0350B670  token: 0x6000119
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x600011A
        public System.Void <>iFixBaseProxy_Apply() { }
        // RVA: 0x05A73D2C  token: 0x600011B
        public System.Void <>iFixBaseProxy_LowMemory() { }

    }

    // TypeToken: 0x200003C  // size: 0x18
    public class HGReflectionProbeBinningQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Methods
        // RVA: 0x0965FE50  token: 0x600011C
        protected virtual System.Void LowMemory() { }
        // RVA: 0x0350B670  token: 0x600011D
        public System.Void .ctor() { }
        // RVA: 0x05A73D2C  token: 0x600011E
        public System.Void <>iFixBaseProxy_LowMemory() { }

    }

    // TypeToken: 0x200003D  // size: 0x20
    public class HGRPTierQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public System.Int32 HGRP_QualityTier;  // 0x18

        // Methods
        // RVA: 0x035A5A40  token: 0x600011F
        protected virtual System.Void Apply() { }
        // RVA: 0x03D42BD0  token: 0x6000120
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x6000121
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200003E  // size: 0x20
    public class HGScreenSpaceReflectionQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public System.Int32 ssrQualityTier;  // 0x18

        // Methods
        // RVA: 0x035A57E0  token: 0x6000122
        protected virtual System.Void Apply() { }
        // RVA: 0x0350B670  token: 0x6000123
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x6000124
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200003F  // size: 0x20
    public class HGShadowQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public System.Int32 shadowQualityTier;  // 0x18

        // Methods
        // RVA: 0x035A5850  token: 0x6000125
        protected virtual System.Void Apply() { }
        // RVA: 0x0350B670  token: 0x6000126
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x6000127
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000040  // size: 0x30
    public class HGTextureQuality : Beyond.Scripts.Quality.Components.EnumQualityComponent`1
    {
        // Properties
        System.Int32 textureQualityTier { get; /* RVA: 0x035A5970 */ }

        // Methods
        // RVA: 0x035A58C0  token: 0x6000129
        protected virtual System.Void Apply() { }
        // RVA: 0x03D47950  token: 0x600012A
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x600012B
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000042  // size: 0x20
    public class HGVolumetricFogQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public System.Int32 volumetricFogQualityTier;  // 0x18

        // Methods
        // RVA: 0x035A59D0  token: 0x600012C
        protected virtual System.Void Apply() { }
        // RVA: 0x0350B670  token: 0x600012D
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x600012E
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000043  // size: 0x20
    public class LODGroupQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public System.Single lodBias;  // 0x18
        public System.Int32 lodOffset;  // 0x1c

        // Methods
        // RVA: 0x09662980  token: 0x600012F
        protected virtual System.Void Apply() { }
        // RVA: 0x0350B670  token: 0x6000130
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x6000131
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000044  // size: 0x20
    public class PhysicsClothQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public System.Boolean UsePhysicCloth;  // 0x18
        public System.Boolean UseCrossFrameJob;  // 0x19

        // Methods
        // RVA: 0x09662B70  token: 0x6000132
        protected virtual System.Void Apply() { }
        // RVA: 0x03D74E40  token: 0x6000133
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x6000134
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000045  // size: 0x38
    public class PrefabInstantiateQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public System.Single normalMaxUpdateTimeInMsThreshold;  // 0x18
        public System.Single busyMaxUpdateTimeInMsThreshold;  // 0x1c
        public System.Single burstMaxUpdateTimeInMsThreshold;  // 0x20
        public System.Single normalUnloadMaxUpdateTimeInMsThreshold;  // 0x24
        public System.Single burstUnloadMaxUpdateTimeInMsThreshold;  // 0x28
        public System.Single normalCallbackMaxUpdateTimeInMsThreshold;  // 0x2c
        public System.Single burstCallbackMaxUpdateTimeInMsThreshold;  // 0x30
        public System.Int32 normalMaxDestroyCount;  // 0x34

        // Methods
        // RVA: 0x09662C20  token: 0x6000135
        protected virtual System.Void Apply() { }
        // RVA: 0x03D74E50  token: 0x6000136
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x6000137
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000046  // size: 0x38
    public class PreloadLoadSettingQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public System.Single normalMaxUpdateTimeInMsThreshold;  // 0x18
        public System.Single busyMaxUpdateTimeInMsThreshold;  // 0x1c
        public System.Single burstMaxUpdateTimeInMsThreshold;  // 0x20
        public System.Single normalUnloadMaxUpdateTimeInMsThreshold;  // 0x24
        public System.Single burstUnloadMaxUpdateTimeInMsThreshold;  // 0x28
        public System.Single normalCallbackMaxUpdateTimeInMsThreshold;  // 0x2c
        public System.Single burstCallbackMaxUpdateTimeInMsThreshold;  // 0x30
        public System.Single preloadManagerUnloadKeepTime;  // 0x34

        // Methods
        // RVA: 0x03B122E0  token: 0x6000138
        protected virtual System.Void Apply() { }
        // RVA: 0x03D1EDE0  token: 0x6000139
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x600013A
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000047  // size: 0x20
    public class RayTracingQuality : Beyond.Scripts.Quality.Components.ToggleQualityComponent
    {
        // Properties
        System.Boolean supportsRayTracing { get; /* RVA: 0x03A2D050 */ }

        // Methods
        // RVA: 0x03A2CFF0  token: 0x600013C
        protected virtual System.Void InitApply() { }
        // RVA: 0x09665EFC  token: 0x600013D
        protected virtual System.Void Apply() { }
        // RVA: 0x09665FF0  token: 0x600013E
        public System.Boolean ShouldShow() { }
        // RVA: 0x03D47590  token: 0x600013F
        private virtual System.Int32 ApplyOrder() { }
        // RVA: 0x0350B670  token: 0x6000140
        public System.Void .ctor() { }
        // RVA: 0x0965FCFC  token: 0x6000141
        public System.Void <>iFixBaseProxy_InitApply() { }
        // RVA: 0x0965F414  token: 0x6000142
        public System.Void <>iFixBaseProxy_Apply() { }
        // RVA: 0x09666040  token: 0x6000143
        public System.Int32 <>iFixBaseProxy_ApplyOrder() { }

    }

    // TypeToken: 0x2000048  // size: 0x38
    public class ReflexQuality : Beyond.Scripts.Quality.Components.EnumQualityComponent`1
    {
        // Fields
        private System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent> callback;  // 0x30

        // Methods
        // RVA: 0x02AB0EF0  token: 0x6000144
        protected virtual System.Void Apply() { }
        // RVA: 0x096661A8  token: 0x6000145
        public System.Boolean ShouldShow() { }
        // RVA: 0x02C99670  token: 0x6000146
        protected System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x09666048  token: 0x6000147
        private System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent) { }
        // RVA: 0x03D47560  token: 0x6000148
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x6000149
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000049  // size: 0x30
    public class RenderingScaleQualityMobile : Beyond.Scripts.Quality.Components.EnumQualityComponent`1
    {
        // Properties
        System.Single renderingScaleFactor { get; /* RVA: 0x0966639C */ }

        // Methods
        // RVA: 0x09666268  token: 0x600014B
        protected virtual System.Void Apply() { }
        // RVA: 0x09666374  token: 0x600014C
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x600014D
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200004B  // size: 0x38
    public class RenderingScaleQualityPC : Beyond.Scripts.Quality.Components.EnumQualityComponent`1
    {
        // Fields
        private System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent> callback;  // 0x30

        // Properties
        System.Single renderingScale { get; /* RVA: 0x02AB16E0 */ }

        // Methods
        // RVA: 0x02AB1580  token: 0x600014F
        protected virtual System.Void Apply() { }
        // RVA: 0x09666468  token: 0x6000150
        public System.Boolean ShouldShow() { }
        // RVA: 0x02C99710  token: 0x6000151
        protected System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x02AB12B0  token: 0x6000152
        private System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent) { }
        // RVA: 0x03D47530  token: 0x6000153
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x6000154
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200004D  // size: 0x50
    public class ResLoadSettingQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public System.Boolean debugCloseBundleUnload;  // 0x18
        public System.Boolean debugCloseBundleUnloadUntilBurstMode;  // 0x19
        public System.Boolean enableForceSyncUnload;  // 0x1a
        public System.Boolean enableUnloadLocker;  // 0x1b
        public System.Int32 enableUnloadLockerBundleNum;  // 0x1c
        public System.Int32 maxUnloadOpNum_Normal;  // 0x20
        public System.Int32 maxUnloadOpNum_BusyMode;  // 0x24
        public System.Int32 bundleFrameDelayToUnload_NormalMode;  // 0x28
        public System.Int32 bundleFrameDelayToUnload_BusyMode;  // 0x2c
        public System.Int32 bundleFrameDelayToUnload_BurstMode;  // 0x30
        public System.Int32 bundleFrameDelayToUnload_SwitchScene;  // 0x34
        public System.Int32 bundleFrameDelayToUnload_Fast;  // 0x38
        public System.Int32 enterBusyOperationNum;  // 0x3c
        public System.Int32 exitBusyOperationNum;  // 0x40
        public System.Single unloadBudgetFloatingCoefficient;  // 0x44
        public System.Single unloadMaxFloatingBudget;  // 0x48

        // Methods
        // RVA: 0x03A92FF0  token: 0x6000155
        protected virtual System.Void Apply() { }
        // RVA: 0x09666550  token: 0x6000156
        protected virtual System.Void LowMemory() { }
        // RVA: 0x03CDD770  token: 0x6000157
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x6000158
        public System.Void <>iFixBaseProxy_Apply() { }
        // RVA: 0x05A73D2C  token: 0x6000159
        public System.Void <>iFixBaseProxy_LowMemory() { }

    }

    // TypeToken: 0x200004E  // size: 0x20
    public class SceneDetailQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public System.Int32 sceneDetailQualityTier;  // 0x18

        // Methods
        // RVA: 0x035A5C90  token: 0x600015A
        protected virtual System.Void Apply() { }
        // RVA: 0x0350B670  token: 0x600015B
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x600015C
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200004F  // size: 0x20
    public class ShaderLodQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnum ShaderLod;  // 0x18

        // Methods
        // RVA: 0x03CA43C0  token: 0x600015D
        protected virtual System.Void InitApply() { }
        // RVA: 0x09666614  token: 0x600015E
        protected virtual System.Void Apply() { }
        // RVA: 0x0350B670  token: 0x600015F
        public System.Void .ctor() { }
        // RVA: 0x0965FCFC  token: 0x6000160
        public System.Void <>iFixBaseProxy_InitApply() { }
        // RVA: 0x05A73D24  token: 0x6000161
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000051  // size: 0x30
    public class SharpnessQuality : Beyond.Scripts.Quality.Components.SliderQualityComponent
    {
        // Methods
        // RVA: 0x02AB1740  token: 0x6000162
        protected virtual System.Void Apply() { }
        // RVA: 0x096666E4  token: 0x6000163
        public System.Boolean ShouldShow() { }
        // RVA: 0x0350B670  token: 0x6000164
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x6000165
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000052  // size: 0x30
    public class SliderTestComponent : Beyond.Scripts.Quality.Components.SliderQualityComponent
    {
        // Methods
        // RVA: 0x096668CC  token: 0x6000166
        protected virtual System.Void Apply() { }
        // RVA: 0x0350B670  token: 0x6000167
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x6000168
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000053  // size: 0x20
    public class TickExclusiveQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public Beyond.TickExclusiveMode quality;  // 0x18
        private Beyond.Gameplay.BeyondPerformance.LogicQualityLevel m_currentQuality;  // 0x1c
        private Beyond.Gameplay.BeyondPerformance.ThermalState m_currentThermalState;  // 0x1d

        // Methods
        // RVA: 0x03CFE3F0  token: 0x6000169
        protected virtual System.Void Apply() { }
        // RVA: 0x02AB66C0  token: 0x600016A
        protected virtual System.Void DynamicQualityChange(Beyond.Gameplay.BeyondPerformance.LogicQualityLevel current, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel last) { }
        // RVA: 0x09666910  token: 0x600016B
        protected virtual System.Void DynamicThermalChange(Beyond.Gameplay.BeyondPerformance.ThermalState current, Beyond.Gameplay.BeyondPerformance.ThermalState last) { }
        // RVA: 0x02AB6760  token: 0x600016C
        private System.Void _OnQualityOrThermalChanged() { }
        // RVA: 0x03D4CD80  token: 0x600016D
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x600016E
        public System.Void <>iFixBaseProxy_Apply() { }
        // RVA: 0x05D6EA20  token: 0x600016F
        public System.Void <>iFixBaseProxy_DynamicQualityChange(Beyond.Gameplay.BeyondPerformance.LogicQualityLevel P0, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel P1) { }
        // RVA: 0x05D6EA28  token: 0x6000170
        public System.Void <>iFixBaseProxy_DynamicThermalChange(Beyond.Gameplay.BeyondPerformance.ThermalState P0, Beyond.Gameplay.BeyondPerformance.ThermalState P1) { }

    }

    // TypeToken: 0x2000054  // size: 0x30
    public class UpscalerQuality : Beyond.Scripts.Quality.Components.EnumQualityComponent`1
    {
        // Methods
        // RVA: 0x02AB1890  token: 0x6000171
        protected virtual System.Void Apply() { }
        // RVA: 0x09666AAC  token: 0x6000172
        public System.Boolean ShouldShow() { }
        // RVA: 0x09666A0C  token: 0x6000173
        public System.Boolean ShouldShowDLSS() { }
        // RVA: 0x09666A5C  token: 0x6000174
        public System.Boolean ShouldShowFSR3() { }
        // RVA: 0x03D47380  token: 0x6000175
        public virtual System.Int32 Version() { }
        // RVA: 0x03D47350  token: 0x6000176
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x6000177
        public System.Void <>iFixBaseProxy_Apply() { }
        // RVA: 0x060BBCC0  token: 0x6000178
        public System.Int32 <>iFixBaseProxy_Version() { }

    }

    // TypeToken: 0x2000056  // size: 0x20
    public class VSyncQuality : Beyond.Scripts.Quality.Components.QualityTierComponent
    {
        // Fields
        public System.Boolean bVSync;  // 0x18

        // Methods
        // RVA: 0x09666CF0  token: 0x6000179
        protected virtual System.Void Apply() { }
        // RVA: 0x09666D48  token: 0x600017A
        protected System.Void Remove() { }
        // RVA: 0x03CAB5A0  token: 0x600017B
        public static System.Void Init() { }
        // RVA: 0x03D587A0  token: 0x600017C
        public System.Void .ctor() { }
        // RVA: 0x05A73D24  token: 0x600017D
        public System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000057  // size: 0x28
    public class VSyncQualityV2 : Beyond.Scripts.Quality.Components.ToggleQualityComponent
    {
        // Fields
        private System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent> callback;  // 0x20

        // Methods
        // RVA: 0x039E1EB0  token: 0x600017E
        protected virtual System.Void Toggle(System.Boolean value) { }
        // RVA: 0x03CAB5D0  token: 0x600017F
        public static System.Void Init() { }
        // RVA: 0x03D1F1D0  token: 0x6000180
        public virtual System.Int32 Version() { }
        // RVA: 0x02C997B0  token: 0x6000181
        protected System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        // RVA: 0x09666AFC  token: 0x6000182
        private System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent) { }
        // RVA: 0x09666C48  token: 0x6000183
        public System.Boolean ShouldShow() { }
        // RVA: 0x0350B670  token: 0x6000184
        public System.Void .ctor() { }
        // RVA: 0x0965CECC  token: 0x6000185
        public System.Void <>iFixBaseProxy_Toggle(System.Boolean P0) { }
        // RVA: 0x060BBCC0  token: 0x6000186
        public System.Int32 <>iFixBaseProxy_Version() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000004  // size: 0x18
    public class ECSComponentAttribute : System.Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;  // 0x10
        public System.Boolean isTag;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x6000004
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000005  // size: 0x10
    public class CameraControlConfigAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000005
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000006  // size: 0x20
    public class DataNAttribute : System.Attribute
    {
        // Fields
        public System.Int32 capacity;  // 0x10
        public System.Int32 tSize;  // 0x14
        public System.Boolean ring;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000006
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000007  // size: 0x10
    public static class AnimatorBlackboardUtility
    {
        // Fields
        private static System.Boolean s_enableFastPathBuffer;  // static @ 0x0

        // Methods
        // RVA: -1  // generic def  token: 0x6000007
        private static System.Void ClearAndEnsureDictionaryCapacity(System.Collections.Generic.Dictionary<TKey,TValue>& dict, System.Int32 capacity) { }

    }

    // TypeToken: 0x2000008  // size: 0x10
    public class AnimatorBlackboardAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000008
        public System.Void .ctor() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000002  // size: 0x10
    public class HGConstantBufferLayoutAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000001
        public System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000058  // size: 0x28
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10
        private System.Int32 methodId;  // 0x18
        private System.Object anonObj;  // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;  // static @ 0x0

        // Methods
        // RVA: 0x03020510  token: 0x6000187
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        // RVA: 0x050F3444  token: 0x6000188
        public System.Void __Gen_Wrap_0() { }
        // RVA: 0x05163BA0  token: 0x6000189
        public System.Void __Gen_Wrap_1(System.Object P0, System.Object P1) { }
        // RVA: 0x0966149C  token: 0x600018A
        public System.String __Gen_Wrap_2(Beyond.Scripts.Quality.RankingRule& P0) { }
        // RVA: 0x09661940  token: 0x600018B
        public System.String __Gen_Wrap_3(Beyond.Scripts.Quality.DeviceMatchResult& P0) { }
        // RVA: 0x09661FD0  token: 0x600018C
        public System.String __Gen_Wrap_4(System.Object P0) { }
        // RVA: 0x096624A4  token: 0x600018D
        public System.Boolean __Gen_Wrap_5(Beyond.Scripts.Quality.DeviceMatchResult& P0) { }
        // RVA: 0x0514EF5C  token: 0x600018E
        public System.Boolean __Gen_Wrap_6(System.Object P0) { }
        // RVA: 0x096625EC  token: 0x600018F
        public Beyond.Scripts.Quality.DeviceMatchRules __Gen_Wrap_7(System.Object P0) { }
        // RVA: 0x096626DC  token: 0x6000190
        public System.String __Gen_Wrap_8(System.Object P0, System.Object P1) { }
        // RVA: 0x096627E8  token: 0x6000191
        public System.Boolean __Gen_Wrap_9(System.Object P0, System.Object P1, System.Object P2, Beyond.Scripts.Quality.RankingRule& P3) { }
        // RVA: 0x09660410  token: 0x6000192
        public System.Boolean __Gen_Wrap_10(System.Object P0, System.Object P1, System.Object P2, Beyond.Scripts.Quality.RankingRule& P3, System.String& P4) { }
        // RVA: 0x04274234  token: 0x6000193
        public System.Void __Gen_Wrap_11(System.Object P0) { }
        // RVA: 0x05152714  token: 0x6000194
        public System.Int32 __Gen_Wrap_12(System.Object P0, System.Object P1) { }
        // RVA: 0x096605F0  token: 0x6000195
        public System.Boolean __Gen_Wrap_13(System.Object P0, System.Object P1, Beyond.Scripts.Quality.RankingRule& P2) { }
        // RVA: 0x09660760  token: 0x6000196
        public System.Boolean __Gen_Wrap_14(Beyond.Scripts.Quality.RankingRule& P0, Beyond.Scripts.Quality.RankingRule P1) { }
        // RVA: 0x096608E0  token: 0x6000197
        public System.String __Gen_Wrap_15(Beyond.Scripts.Quality.MemoryRule& P0) { }
        // RVA: 0x09660A34  token: 0x6000198
        public System.Boolean __Gen_Wrap_16(Beyond.Scripts.Quality.MemoryRule& P0, Beyond.Scripts.Quality.MemoryRule P1) { }
        // RVA: 0x09660BB0  token: 0x6000199
        public System.String __Gen_Wrap_17(Beyond.Scripts.Quality.DeviceQualityMapItem& P0) { }
        // RVA: 0x09660D1C  token: 0x600019A
        public UnityEngine.Color __Gen_Wrap_18(Beyond.Scripts.Quality.DeviceQualityMapItem& P0, System.Int32 P1) { }
        // RVA: 0x09660EC0  token: 0x600019B
        public UnityEngine.Color __Gen_Wrap_19(Beyond.Scripts.Quality.DeviceQualityMapItem& P0) { }
        // RVA: 0x050EF614  token: 0x600019C
        public System.Int32 __Gen_Wrap_20(System.Object P0) { }
        // RVA: 0x05477F10  token: 0x600019D
        public System.Int32 __Gen_Wrap_21(Beyond.Scripts.Quality.Components.QualityTierLevel P0) { }
        // RVA: 0x09661048  token: 0x600019E
        public System.Int32 __Gen_Wrap_22(Beyond.Scripts.Quality.DeviceQualityMapItem P0) { }
        // RVA: 0x0966114C  token: 0x600019F
        public Beyond.Scripts.Quality.Components.QualityTierComponentMatch __Gen_Wrap_23(System.Object P0, System.Object P1, System.Int32 P2) { }
        // RVA: 0x09661284  token: 0x60001A0
        public System.Int32 __Gen_Wrap_24(Beyond.Scripts.Quality.Components.QualityTierComponentMatch P0) { }
        // RVA: 0x05150B1C  token: 0x60001A1
        public System.Void __Gen_Wrap_25(System.Object P0, System.Object P1, System.Object P2) { }
        // RVA: 0x05477860  token: 0x60001A2
        public System.Void __Gen_Wrap_26(System.Object P0, System.Boolean P1) { }
        // RVA: 0x09661374  token: 0x60001A3
        public Beyond.Scripts.Quality.Components.QualityTierComponentMatch __Gen_Wrap_27(System.Object P0, System.Object P1) { }
        // RVA: 0x0549D548  token: 0x60001A4
        public System.Void __Gen_Wrap_28(System.Object P0, System.Int32 P1) { }
        // RVA: 0x05E5E690  token: 0x60001A5
        public System.Void __Gen_Wrap_29(System.Object P0, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel P1, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel P2) { }
        // RVA: 0x096615F8  token: 0x60001A6
        public System.Void __Gen_Wrap_30(System.Object P0, Beyond.EventData<Beyond.Gameplay.BeyondPerformance.LogicQualityLevel,Beyond.Gameplay.BeyondPerformance.LogicQualityLevel>& P1) { }
        // RVA: 0x05E5E788  token: 0x60001A7
        public System.Void __Gen_Wrap_31(System.Object P0, Beyond.Gameplay.BeyondPerformance.ThermalState P1, Beyond.Gameplay.BeyondPerformance.ThermalState P2) { }
        // RVA: 0x0966171C  token: 0x60001A8
        public System.Void __Gen_Wrap_32(System.Object P0, Beyond.EventData<Beyond.Gameplay.BeyondPerformance.ThermalState,Beyond.Gameplay.BeyondPerformance.ThermalState>& P1) { }
        // RVA: 0x09661834  token: 0x60001A9
        public System.Type __Gen_Wrap_33(System.Object P0, System.Object P1) { }
        // RVA: 0x054A1028  token: 0x60001AA
        public System.Void __Gen_Wrap_34(System.Object P0, System.Object P1, System.Int32 P2) { }
        // RVA: 0x055FFD60  token: 0x60001AB
        public System.Void __Gen_Wrap_35(System.Object P0, Beyond.GameSetting.GameSettingVideoQuality P1) { }
        // RVA: 0x05477F10  token: 0x60001AC
        public Beyond.GameSetting.GameSettingVideoQuality __Gen_Wrap_36(System.Object P0) { }
        // RVA: 0x050F1D3C  token: 0x60001AD
        public System.Boolean __Gen_Wrap_37() { }
        // RVA: 0x05153920  token: 0x60001AE
        public System.Boolean __Gen_Wrap_38(System.Object P0, System.Object P1) { }
        // RVA: 0x05152714  token: 0x60001AF
        public Beyond.Scripts.Quality.Components.QualityTierType __Gen_Wrap_39(System.Object P0, System.Object P1) { }
        // RVA: 0x050F0008  token: 0x60001B0
        public System.Void __Gen_Wrap_40(System.Object P0, System.Single P1) { }
        // RVA: 0x05E7B3B0  token: 0x60001B1
        public System.Void __Gen_Wrap_41(System.Object P0, System.Object P1, System.Single P2) { }
        // RVA: 0x09661AAC  token: 0x60001B2
        public UnityEngine.Vector2 __Gen_Wrap_42(System.Object P0) { }
        // RVA: 0x054AB08C  token: 0x60001B3
        public System.Single __Gen_Wrap_43(System.Object P0) { }
        // RVA: 0x09661B88  token: 0x60001B4
        public UnityEngine.Vector3 __Gen_Wrap_44(System.Object P0, System.Object P1) { }
        // RVA: 0x09661CA8  token: 0x60001B5
        public System.Boolean __Gen_Wrap_45(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        // RVA: 0x09661DB0  token: 0x60001B6
        public System.ValueTuple<System.Single,System.Single> __Gen_Wrap_46(System.Object P0, System.Object P1) { }
        // RVA: 0x0871E788  token: 0x60001B7
        public System.Int32 __Gen_Wrap_47(System.Int32 P0, System.Int32 P1) { }
        // RVA: 0x054AB15C  token: 0x60001B8
        public System.Single __Gen_Wrap_48(System.Object P0, System.Object P1) { }
        // RVA: 0x09661EA8  token: 0x60001B9
        public System.Int32 __Gen_Wrap_49(Beyond.Scripts.Quality.Components.QualityTierComponentMatch P0, Beyond.Scripts.Quality.Components.QualityTierComponentMatch P1) { }
        // RVA: 0x096620C0  token: 0x60001BA
        public System.Void __Gen_Wrap_50(System.Object P0, System.Object P1, System.Int32& P2, System.Int32& P3) { }
        // RVA: 0x05646730  token: 0x60001BB
        public System.Boolean __Gen_Wrap_51(System.Object P0, System.Object P1, System.Int32 P2) { }
        // RVA: 0x096621FC  token: 0x60001BC
        public System.Byte[] __Gen_Wrap_52(System.Object P0) { }
        // RVA: 0x096622D8  token: 0x60001BD
        public Newtonsoft.Json.JsonSerializerSettings __Gen_Wrap_53() { }
        // RVA: 0x096623A4  token: 0x60001BE
        public System.Void __Gen_Wrap_54(System.Object P0, System.Runtime.Serialization.StreamingContext P1) { }
        // RVA: 0x056280E8  token: 0x60001BF
        public System.Int32 __Gen_Wrap_55(Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnum P0) { }
        // RVA: 0x056458FC  token: 0x60001C0
        public System.Void __Gen_Wrap_56(System.Int32 P0, Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum P1) { }
        // RVA: 0x050F1DD4  token: 0x60001C1
        public System.Int32 __Gen_Wrap_57() { }
        // RVA: 0x0562802C  token: 0x60001C2
        public System.Int32 __Gen_Wrap_58(Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnum P0) { }
        // RVA: 0x03D056B0  token: 0x60001C3
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000059  // size: 0x40
    public class ILFixInterfaceBridge : IFix.Core.AnonymousStorey
    {
        // Methods
        // RVA: 0x09666D98  token: 0x60001C4
        public System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0350B670  token: 0x60001C5
        public System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x200005A  // size: 0x18
    public class WrappersManagerImpl : IFix.Core.WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x60001C6
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x09667014  token: 0x60001C7
        public static IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        // RVA: 0x02AB4860  token: 0x60001C8
        public static System.Boolean IsPatched(System.Int32 id) { }
        // RVA: 0x09666ED0  token: 0x60001C9
        public virtual System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        // RVA: 0x09666F9C  token: 0x60001CA
        public virtual System.Object CreateWrapper(System.Int32 id) { }
        // RVA: 0x09667078  token: 0x60001CB
        public virtual System.Object InitWrapperArray(System.Int32 len) { }
        // RVA: 0x09666E2C  token: 0x60001CC
        public virtual IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x200005B  // size: 0x14
    public sealed struct IDMAP0
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static IFix.IDMAP0 Beyond-PoolCore-ListPoolInitializer_RuntimeQuality-Initialize0;  // const
        public static IFix.IDMAP0 Beyond-PoolCore-ListPoolInitializer_RuntimeQuality-InitializeAtRuntime0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceMatchRules-Combine0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-SupplementFromRemote0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-RankingRule-ToString0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceMatchResult-ToString0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-ToString0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceMatchResult-IsNoMatch0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-IsNoMatchDevice0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-IsZeroDevices0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-IsHUAWEIDevice0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-IsQualcommDevice0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-LoadingSettingRules0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-GetNvidiaStandardGPUName0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-RuleSuffixMatch0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-GetAmdStandardGPUName0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-GetIntelStandardGPUName0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-StandaloneMatchGPURule0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-_ReportMatchRuleFailed0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-StandaloneGetMatchedRule0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-GetDeviceScore0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-RuleFullNameMatch0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-MatchDeviceModeRule0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-GetAdrenoStandardGPUName0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-GetMaliStandardGPUName0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-MatchGPURule0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-AndroidGetMatchedRule0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-IOSGetMatchedRule0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-DefaultGetMatchedRule0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-EditorSimulateGetMatchedRule0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-StandaloneOSXGetMatchedRule0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-StandalonePS5GetMatchedRule0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-GetPowerVRStandardGPUName0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-RankingRule-Equals0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-MemoryRule-ToString0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-MemoryRule-Equals0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceQualityMapItem-ToString0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceQualityMapItem-getColor0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceQualityMapItem-getVeryLowColor0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceQualityMapItem-getLowColor0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceQualityMapItem-getMiddleColor0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceQualityMapItem-getHighColor0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceQualityMapItem-getVeryHighColor0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-ApplyOrder0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-LoadQualityTier0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-_SetQualityTierComponentLevel0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-InitApply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-LowMemory0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-InvokeChangeCallBack0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-SafeApply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-SafeLowMemory0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-_GetOverrideQualityTierComponentLevel0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-ApplyCallBack0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-setQualityTier0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-ApplyQualityScore0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-DynamicQualityChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-CallDynamicQualityChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-DynamicQualityChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-DynamicThermalChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-CallDynamicThermalChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-DynamicThermalChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-_DynamicInitQualitySetting0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-Init0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-InitOnlyDevice0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-_GetQualityComponentByName0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-ForceSetQualityTierComponentLevel0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-FinishInit0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-ApplyShaderTier0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-InitShaderLod0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-_DynamicReleaseQualitySetting0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-SetQualityTierByVideoQuality0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-GetDefaultVideoQuality0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-NoMatchDeviceOrZeroScore0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-IsQualcommDevice0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-IsHUAWEIDevice0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-IsIpadDevice0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-InitResetQualityTierComponentFunction0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-ResetQualityTierComponentValue0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-RevertSetQualityTierComponentLevel0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-NeedRestart0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierType0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-Version0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierVersion0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-_IsToggleQualityTierComponent0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ToggleQualityComponent-ChangeToggle0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ToggleQualityComponent-GetValue0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-_ToggleQualityTierComponentLevel0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-IsEnumQualityTierComponent0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-GetEnumQualityTierComponentCount0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-SetEnumQualityTierComponentCount0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-IsSliderQualityTierComponent0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-SliderQualityComponent-SetValue0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-SetSliderQualityTierComponentCount0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-SliderQualityComponent-GetRange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-SliderQualityComponent-GetValue0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-GetSliderQualityTierComponent0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-InvokeQualityTierComponent0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierCount0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ToggleQualityComponent-GetDefaultValue0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-SliderQualityComponent-GetDefaultValue0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-GetQualityComponentDefaultTier0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-GetQualityComponentTier0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-_ReportQuality0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-SetQualityComponentTier0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-TierLimit0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-_GetCurrentComponentTierIndex0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-IsQualitySubSettingTierValid0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-ToString0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-DebugQualityTierComponentInfo0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityUtility-Decompress0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityUtility-get_JsonSerializerSettings0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-AntiAliasingQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-RemoveQualitySettingSaveValue0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-RemoveRegisterKey0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ToggleQualityComponent-Toggle0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ToggleQualityComponent-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-CharacterRenderFeatureQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ChromaticAberrationQuality-Toggle0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-DlSSChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-OnDeserialized0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowAuto0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX10;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX20;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX30;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShow0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-ShouldShow0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-DlSSChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-OnDeserialized0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-EnvironmentRenderingFeatureQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameGenQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShowDLSS0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShow0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameGenQualityMobile-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameGenQualityMobile-ShouldShow0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-GetFrameRateFromEnum0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-Version0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-ShouldShow0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HgFrameRateControl-__ForceSetFrameRate0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-DlSSChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-OnDeserialized0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-_FPS30Enabled0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-_FPS60Enabled0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-_FPSBNoLimitEnabled0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-_IsGDLSSGDisable0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HgFrameRateControl-GetDefaultFrameRate0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HgFrameRateControl-Init0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HgFrameRateControl-SetFrameRateOverrider0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HgFrameRateControl-GetFrameRate0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HgFrameRateControl-RecommendedDefaultFrameRate0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HgFrameRateControl-GetUserSettingFrameRate0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HgFrameRateControl-ResetFrameRate0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQualityMobile-GetFrameRateFromEnum0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQualityMobile-Version0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQualityMobile-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQualityMobile-OnDeserialized0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-ShouldShow0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-FSR3Change0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-OnDeserialized0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-GrassSparsityQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGAmbientOcclusionQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGAnisoLevelQuality-InitApply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGAnisoLevelQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGContactShadowQuality-Toggle0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGIrradianceVolumeQuality-LowMemory0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGLODStreamingComponent-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGLODStreamingComponent-LowMemory0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGReflectionProbeBinningQuality-LowMemory0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGRPTierQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGScreenSpaceReflectionQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGShadowQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGTextureQuality-get_textureQualityTier0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGTextureQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGVolumetricFogQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-LODGroupQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-PhysicsClothQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-PrefabInstantiateQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-PreloadLoadSettingQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RayTracingQuality-InitApply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RayTracingQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RayTracingQuality-ShouldShow0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RayTracingQuality-ApplyOrder0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ReflexQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ReflexQuality-ShouldShow0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ReflexQuality-DlSSChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ReflexQuality-OnDeserialized0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RenderingScaleQualityMobile-get_renderingScaleFactor0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RenderingScaleQualityMobile-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-get_renderingScale0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-ShouldShow0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-DlSSChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-OnDeserialized0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ResLoadSettingQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ResLoadSettingQuality-LowMemory0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-SceneDetailQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ShaderLodQuality-InitApply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ShaderLodQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-SharpnessQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-SharpnessQuality-ShouldShow0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-SliderTestComponent-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-TickExclusiveQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-TickExclusiveQuality-_OnQualityOrThermalChanged0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-TickExclusiveQuality-DynamicQualityChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-TickExclusiveQuality-DynamicThermalChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-UpscalerQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShowDLSS0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShow0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShowFSR30;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-UpscalerQuality-Version0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQuality-Apply0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQuality-Remove0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQuality-Init0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQualityV2-Toggle0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQualityV2-Init0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQualityV2-Version0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQualityV2-DlSSChange0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQualityV2-OnDeserialized0;  // const
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQualityV2-ShouldShow0;  // const

    }

}

