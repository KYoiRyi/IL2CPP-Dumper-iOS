// ========================================================
// Dumped by @desirepro
// Assembly: AK.Wwise.Unity.API.dll
// Classes:  182
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000002  // size: 0x20
    public class Ak3DAudioSinkCapabilities : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        AkChannelConfig channelConfig { get; /* RVA: 0x0427A7DC */ set; /* RVA: 0x0427A9C8 */ }
        System.UInt32 uMaxSystemAudioObjects { get; /* RVA: 0x0427A8A8 */ set; /* RVA: 0x0427AA84 */ }
        System.UInt32 uAvailableSystemAudioObjects { get; /* RVA: 0x0427A858 */ set; /* RVA: 0x0427AA30 */ }
        System.Boolean bPassthrough { get; /* RVA: 0x0427A78C */ set; /* RVA: 0x0427A974 */ }
        System.Boolean bMultiChannelObjects { get; /* RVA: 0x0427A73C */ set; /* RVA: 0x0427A920 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000001
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000002
        private static System.IntPtr getCPtr(Ak3DAudioSinkCapabilities obj) { }
        // RVA: 0x0427A8F8  token: 0x6000003
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427A668  token: 0x6000004
        protected virtual System.Void Finalize() { }
        // RVA: 0x0427A618  token: 0x6000005
        public virtual System.Void Dispose() { }
        // RVA: 0x0427A504  token: 0x6000006
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0427A6DC  token: 0x6000011
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000003  // size: 0x20
    public class Ak3dData : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        AkTransform xform { get; /* RVA: 0x0427ADF0 */ set; /* RVA: 0x0427AF98 */ }
        System.Single spread { get; /* RVA: 0x0427AD50 */ set; /* RVA: 0x0427AEEC */ }
        System.Single focus { get; /* RVA: 0x0427AD00 */ set; /* RVA: 0x0427AE94 */ }
        System.UInt32 uEmitterChannelMask { get; /* RVA: 0x0427ADA0 */ set; /* RVA: 0x0427AF44 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000012
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000013
        private static System.IntPtr getCPtr(Ak3dData obj) { }
        // RVA: 0x0427AE6C  token: 0x6000014
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427AC3C  token: 0x6000015
        protected virtual System.Void Finalize() { }
        // RVA: 0x0427ABEC  token: 0x6000016
        public virtual System.Void Dispose() { }
        // RVA: 0x0427AAD8  token: 0x6000017
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0427ACB0  token: 0x6000018
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x14
    public sealed struct Ak3DPositionType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Ak3DPositionType AK_3DPositionType_Emitter;  // const
        public static Ak3DPositionType AK_3DPositionType_EmitterWithAutomation;  // const
        public static Ak3DPositionType AK_3DPositionType_ListenerWithAutomation;  // const

    }

    // TypeToken: 0x2000005  // size: 0x14
    public sealed struct Ak3DSpatializationMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Ak3DSpatializationMode AK_SpatializationMode_None;  // const
        public static Ak3DSpatializationMode AK_SpatializationMode_PositionOnly;  // const
        public static Ak3DSpatializationMode AK_SpatializationMode_PositionAndOrientation;  // const

    }

    // TypeToken: 0x2000006  // size: 0x20
    public class AkAcousticSurface : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt32 textureID { get; /* RVA: 0x0427B3DC */ set; /* RVA: 0x0427B4F8 */ }
        System.Single transmissionLoss { get; /* RVA: 0x0427B42C */ set; /* RVA: 0x0427B54C */ }
        System.String strName { get; /* RVA: 0x0427B370 */ set; /* RVA: 0x0427B4A4 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000021
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000022
        private static System.IntPtr getCPtr(AkAcousticSurface obj) { }
        // RVA: 0x0427B47C  token: 0x6000023
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427B26C  token: 0x6000024
        protected virtual System.Void Finalize() { }
        // RVA: 0x0427B108  token: 0x6000025
        public virtual System.Void Dispose() { }
        // RVA: 0x0427B158  token: 0x6000026
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0427B320  token: 0x6000027
        public System.Void .ctor() { }
        // RVA: 0x0427B000  token: 0x600002E
        public System.Void Clear() { }
        // RVA: 0x0427B0B8  token: 0x600002F
        public System.Void DeleteName() { }
        // RVA: 0x0427B2E0  token: 0x6000030
        public static System.Int32 GetSizeOf() { }
        // RVA: 0x0427B050  token: 0x6000031
        public System.Void Clone(AkAcousticSurface other) { }

    }

    // TypeToken: 0x2000007  // size: 0x14
    public sealed struct AkActionOnEventType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkActionOnEventType AkActionOnEventType_Stop;  // const
        public static AkActionOnEventType AkActionOnEventType_Pause;  // const
        public static AkActionOnEventType AkActionOnEventType_Resume;  // const
        public static AkActionOnEventType AkActionOnEventType_Break;  // const
        public static AkActionOnEventType AkActionOnEventType_ReleaseEnvelope;  // const

    }

    // TypeToken: 0x2000008  // size: 0x14
    public sealed struct AkAttenuationCurveType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkAttenuationCurveType AttenuationCurveID_VolumeDry;  // const
        public static AkAttenuationCurveType AttenuationCurveID_VolumeAuxGameDef;  // const
        public static AkAttenuationCurveType AttenuationCurveID_VolumeAuxUserDef;  // const
        public static AkAttenuationCurveType AttenuationCurveID_LowPassFilter;  // const
        public static AkAttenuationCurveType AttenuationCurveID_HighPassFilter;  // const
        public static AkAttenuationCurveType AttenuationCurveID_Spread;  // const
        public static AkAttenuationCurveType AttenuationCurveID_Focus;  // const
        public static AkAttenuationCurveType AttenuationCurveID_ObstructionVolume;  // const
        public static AkAttenuationCurveType AttenuationCurveID_ObstructionLPF;  // const
        public static AkAttenuationCurveType AttenuationCurveID_ObstructionHPF;  // const
        public static AkAttenuationCurveType AttenuationCurveID_OcclusionVolume;  // const
        public static AkAttenuationCurveType AttenuationCurveID_OcclusionLPF;  // const
        public static AkAttenuationCurveType AttenuationCurveID_OcclusionHPF;  // const
        public static AkAttenuationCurveType AttenuationCurveID_DiffractionVolume;  // const
        public static AkAttenuationCurveType AttenuationCurveID_DiffractionLPF;  // const
        public static AkAttenuationCurveType AttenuationCurveID_DiffractionHPF;  // const
        public static AkAttenuationCurveType AttenuationCurveID_TransmissionVolume;  // const
        public static AkAttenuationCurveType AttenuationCurveID_TransmissionLPF;  // const
        public static AkAttenuationCurveType AttenuationCurveID_TransmissionHPF;  // const
        public static AkAttenuationCurveType AttenuationCurveID_MaxCount;  // const
        public static AkAttenuationCurveType AttenuationCurveID_Project;  // const
        public static AkAttenuationCurveType AttenuationCurveID_None;  // const

    }

    // TypeToken: 0x2000009  // size: 0x14
    public sealed struct AkAudioDeviceState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkAudioDeviceState AkDeviceState_Unknown;  // const
        public static AkAudioDeviceState AkDeviceState_Active;  // const
        public static AkAudioDeviceState AkDeviceState_Disabled;  // const
        public static AkAudioDeviceState AkDeviceState_NotPresent;  // const
        public static AkAudioDeviceState AkDeviceState_Unplugged;  // const
        public static AkAudioDeviceState AkDeviceState_All;  // const

    }

    // TypeToken: 0x200000A  // size: 0x20
    public class AkAudioFormat : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt32 uSampleRate { get; /* RVA: 0x0427BB64 */ set; /* RVA: 0x0427BD90 */ }
        AkChannelConfig channelConfig { get; /* RVA: 0x0427B9F8 */ set; /* RVA: 0x0427BC2C */ }
        System.UInt32 uBitsPerSample { get; /* RVA: 0x0427BA74 */ set; /* RVA: 0x0427BC94 */ }
        System.UInt32 uBlockAlign { get; /* RVA: 0x0427BAC4 */ set; /* RVA: 0x0427BCE8 */ }
        System.UInt32 uTypeID { get; /* RVA: 0x0427BBB4 */ set; /* RVA: 0x0427BDE4 */ }
        System.UInt32 uInterleaveID { get; /* RVA: 0x0427BB14 */ set; /* RVA: 0x0427BD3C */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000032
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000033
        private static System.IntPtr getCPtr(AkAudioFormat obj) { }
        // RVA: 0x0427BC04  token: 0x6000034
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427B708  token: 0x6000035
        protected virtual System.Void Finalize() { }
        // RVA: 0x0427B5A4  token: 0x6000036
        public virtual System.Void Dispose() { }
        // RVA: 0x0427B5F4  token: 0x6000037
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0427B86C  token: 0x6000044
        public System.UInt32 GetNumChannels() { }
        // RVA: 0x0427B77C  token: 0x6000045
        public System.UInt32 GetBitsPerSample() { }
        // RVA: 0x0427B7CC  token: 0x6000046
        public System.UInt32 GetBlockAlign() { }
        // RVA: 0x0427B8BC  token: 0x6000047
        public System.UInt32 GetTypeID() { }
        // RVA: 0x0427B81C  token: 0x6000048
        public System.UInt32 GetInterleaveID() { }
        // RVA: 0x0427B90C  token: 0x6000049
        public System.Void SetAll(System.UInt32 in_uSampleRate, AkChannelConfig in_channelConfig, System.UInt32 in_uBitsPerSample, System.UInt32 in_uBlockAlign, System.UInt32 in_uTypeID, System.UInt32 in_uInterleaveID) { }
        // RVA: 0x0427B9A8  token: 0x600004A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000B  // size: 0x20
    public class AkAudioInterruptionCallbackInfo : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Boolean bEnterInterruption { get; /* RVA: 0x0427C060 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x600004B
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x600004C
        private static System.IntPtr getCPtr(AkAudioInterruptionCallbackInfo obj) { }
        // RVA: 0x0427C0B0  token: 0x600004D
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427BF9C  token: 0x600004E
        protected virtual System.Void Finalize() { }
        // RVA: 0x0427BE38  token: 0x600004F
        public virtual System.Void Dispose() { }
        // RVA: 0x0427BE88  token: 0x6000050
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0427C010  token: 0x6000052
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000C  // size: 0x14
    public sealed struct AkAudioObjectDestination
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkAudioObjectDestination eDefault;  // const
        public static AkAudioObjectDestination eMainMix;  // const
        public static AkAudioObjectDestination ePassthrough;  // const
        public static AkAudioObjectDestination eSystemAudioObject;  // const

    }

    // TypeToken: 0x200000D  // size: 0x20
    public class AkAudioSettings : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt32 uNumSamplesPerFrame { get; /* RVA: 0x0427C300 */ set; /* RVA: 0x0427C3C8 */ }
        System.UInt32 uNumSamplesPerSecond { get; /* RVA: 0x0427C350 */ set; /* RVA: 0x0427C41C */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000053
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000054
        private static System.IntPtr getCPtr(AkAudioSettings obj) { }
        // RVA: 0x0427C3A0  token: 0x6000055
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427C23C  token: 0x6000056
        protected virtual System.Void Finalize() { }
        // RVA: 0x0427C1EC  token: 0x6000057
        public virtual System.Void Dispose() { }
        // RVA: 0x0427C0D8  token: 0x6000058
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0427C2B0  token: 0x600005D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000E  // size: 0x20
    public class AkAudioSourceChangeCallbackInfo : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Boolean bOtherAudioPlaying { get; /* RVA: 0x0427C698 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x600005E
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x600005F
        private static System.IntPtr getCPtr(AkAudioSourceChangeCallbackInfo obj) { }
        // RVA: 0x0427C6E8  token: 0x6000060
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427C5D4  token: 0x6000061
        protected virtual System.Void Finalize() { }
        // RVA: 0x0427C470  token: 0x6000062
        public virtual System.Void Dispose() { }
        // RVA: 0x0427C4C0  token: 0x6000063
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0427C648  token: 0x6000065
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000F  // size: 0x20
    public class AkAuxSendValue : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt64 listenerID { get; /* RVA: 0x0427CB90 */ set; /* RVA: 0x0427CCB4 */ }
        System.UInt32 auxBusID { get; /* RVA: 0x0427CAF0 */ set; /* RVA: 0x0427CC08 */ }
        System.Single fControlValue { get; /* RVA: 0x0427CB40 */ set; /* RVA: 0x0427CC5C */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000066
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000067
        private static System.IntPtr getCPtr(AkAuxSendValue obj) { }
        // RVA: 0x0427CBE0  token: 0x6000068
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427C874  token: 0x6000069
        protected virtual System.Void Finalize() { }
        // RVA: 0x0427C710  token: 0x600006A
        public virtual System.Void Dispose() { }
        // RVA: 0x0427C760  token: 0x600006B
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0427CA78  token: 0x6000072
        public System.Void Set(System.UInt64 listener, System.UInt32 id, System.Single value) { }
        // RVA: 0x0427C928  token: 0x6000073
        public System.Boolean IsSame(System.UInt64 listener, System.UInt32 id) { }
        // RVA: 0x0427C9F8  token: 0x6000074
        public System.Void Set(UnityEngine.GameObject listener, System.UInt32 id, System.Single value) { }
        // RVA: 0x0427C98C  token: 0x6000075
        public System.Boolean IsSame(UnityEngine.GameObject listener, System.UInt32 id) { }
        // RVA: 0x0427C8E8  token: 0x6000076
        public static System.Int32 GetSizeOf() { }

    }

    // TypeToken: 0x2000010  // size: 0x20
    public class AkBankCallbackInfo : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt32 bankID { get; /* RVA: 0x0269B090 */ }
        System.IntPtr inMemoryBankPtr { get; /* RVA: 0x0269AF50 */ }
        AKRESULT loadResult { get; /* RVA: 0x0269AFF0 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000077
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000078
        private static System.IntPtr getCPtr(AkBankCallbackInfo obj) { }
        // RVA: 0x042711F8  token: 0x6000079
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427CD08  token: 0x600007A
        protected virtual System.Void Finalize() { }
        // RVA: 0x032678F0  token: 0x600007B
        public virtual System.Void Dispose() { }
        // RVA: 0x03267950  token: 0x600007C
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0427CD7C  token: 0x6000080
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000011  // size: 0x14
    public sealed struct AkBankContent
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkBankContent AkBankContent_StructureOnly;  // const
        public static AkBankContent AkBankContent_All;  // const

    }

    // TypeToken: 0x2000012  // size: 0x14
    public sealed struct AkBankTypeEnum
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkBankTypeEnum AkBankType_User;  // const
        public static AkBankTypeEnum AkBankType_Event;  // const
        public static AkBankTypeEnum AkBankType_Bus;  // const

    }

    // TypeToken: 0x2000013  // size: 0x20
    public class AkBehavioralPositioningData : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Single center { get; /* RVA: 0x0427CFF4 */ set; /* RVA: 0x0427D29C */ }
        System.Single panLR { get; /* RVA: 0x0427D134 */ set; /* RVA: 0x0427D3F8 */ }
        System.Single panBF { get; /* RVA: 0x0427D094 */ set; /* RVA: 0x0427D348 */ }
        System.Single panDU { get; /* RVA: 0x0427D0E4 */ set; /* RVA: 0x0427D3A0 */ }
        System.Single panSpatMix { get; /* RVA: 0x0427D184 */ set; /* RVA: 0x0427D450 */ }
        Ak3DSpatializationMode spatMode { get; /* RVA: 0x0427D224 */ set; /* RVA: 0x0427D4FC */ }
        AkSpeakerPanningType panType { get; /* RVA: 0x0427D1D4 */ set; /* RVA: 0x0427D4A8 */ }
        System.Boolean enableHeightSpread { get; /* RVA: 0x0427D044 */ set; /* RVA: 0x0427D2F4 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000081
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000082
        private static System.IntPtr getCPtr(AkBehavioralPositioningData obj) { }
        // RVA: 0x0427D274  token: 0x6000083
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427CF30  token: 0x6000084
        protected virtual System.Void Finalize() { }
        // RVA: 0x0427CEE0  token: 0x6000085
        public virtual System.Void Dispose() { }
        // RVA: 0x0427CDCC  token: 0x6000086
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0427CFA4  token: 0x6000087
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000014  // size: 0x14
    public sealed struct AkBusHierarchyFlags
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkBusHierarchyFlags AkBusHierarchy_Primary;  // const
        public static AkBusHierarchyFlags AkBusHierarchy_Secondary;  // const
        public static AkBusHierarchyFlags AkBusHierarchy_IsMaster;  // const

    }

    // TypeToken: 0x2000015  // size: 0x20
    public class AkCallbackInfo : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.IntPtr pCookie { get; /* RVA: 0x0269F6C0 */ }
        System.UInt64 gameObjID { get; /* RVA: 0x0269F7A0 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000098
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000099
        private static System.IntPtr getCPtr(AkCallbackInfo obj) { }
        // RVA: 0x04275DD4  token: 0x600009A
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427D550  token: 0x600009B
        protected virtual System.Void Finalize() { }
        // RVA: 0x032962F0  token: 0x600009C
        public virtual System.Void Dispose() { }
        // RVA: 0x03038DB0  token: 0x600009D
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0427D5C8  token: 0x60000A0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000016  // size: 0x20
    public class AkCallbackSerializer : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Methods
        // RVA: 0x03D4E290  token: 0x60000A1
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60000A2
        private static System.IntPtr getCPtr(AkCallbackSerializer obj) { }
        // RVA: 0x0427D974  token: 0x60000A3
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427D7EC  token: 0x60000A4
        protected virtual System.Void Finalize() { }
        // RVA: 0x0427D688  token: 0x60000A5
        public virtual System.Void Dispose() { }
        // RVA: 0x0427D6D8  token: 0x60000A6
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x02A01D30  token: 0x60000A7
        public static AKRESULT Init() { }
        // RVA: 0x0427D8E4  token: 0x60000A8
        public static System.Void Term() { }
        // RVA: 0x0269D100  token: 0x60000A9
        public static System.IntPtr Lock() { }
        // RVA: 0x03020340  token: 0x60000AA
        public static System.Void Unlock() { }
        // RVA: 0x0427D860  token: 0x60000AB
        public static System.Void SetLocalOutput(System.UInt32 in_uErrorLevel, System.String in_ip, System.UInt32 in_port, System.String in_xmlFilePath, System.UInt32 in_msXmlTranslatorTimeout, System.UInt32 in_msWaapiTranslatorTimeout) { }
        // RVA: 0x0427D618  token: 0x60000AC
        public static AKRESULT AudioSourceChangeCallbackFunc(System.Boolean in_bOtherAudioPlaying, System.Object in_pCookie) { }
        // RVA: 0x0427D924  token: 0x60000AD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000017  // size: 0x14
    public sealed struct AkCallbackType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkCallbackType AK_EndOfEvent;  // const
        public static AkCallbackType AK_EndOfDynamicSequenceItem;  // const
        public static AkCallbackType AK_Marker;  // const
        public static AkCallbackType AK_Duration;  // const
        public static AkCallbackType AK_SpeakerVolumeMatrix;  // const
        public static AkCallbackType AK_Starvation;  // const
        public static AkCallbackType AK_MusicPlaylistSelect;  // const
        public static AkCallbackType AK_MusicPlayStarted;  // const
        public static AkCallbackType AK_MusicSyncBeat;  // const
        public static AkCallbackType AK_MusicSyncBar;  // const
        public static AkCallbackType AK_MusicSyncEntry;  // const
        public static AkCallbackType AK_MusicSyncExit;  // const
        public static AkCallbackType AK_MusicSyncGrid;  // const
        public static AkCallbackType AK_MusicSyncUserCue;  // const
        public static AkCallbackType AK_MusicSyncPoint;  // const
        public static AkCallbackType AK_MusicSyncAll;  // const
        public static AkCallbackType AK_MIDIEvent;  // const
        public static AkCallbackType AK_CallbackBits;  // const
        public static AkCallbackType AK_EnableGetSourcePlayPosition;  // const
        public static AkCallbackType AK_EnableGetMusicPlayPosition;  // const
        public static AkCallbackType AK_EnableGetSourceStreamBuffering;  // const
        public static AkCallbackType AK_Monitoring;  // const
        public static AkCallbackType AK_Bank;  // const
        public static AkCallbackType AK_AudioInterruption;  // const
        public static AkCallbackType AK_AudioSourceChange;  // const

    }

    // TypeToken: 0x2000018  // size: 0x20
    public class AkChannelConfig : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt32 uNumChannels { get; /* RVA: 0x02690360 */ set; /* RVA: 0x0427E154 */ }
        System.UInt32 eConfigType { get; /* RVA: 0x026902D0 */ set; /* RVA: 0x0427E0AC */ }
        System.UInt32 uChannelMask { get; /* RVA: 0x02690240 */ set; /* RVA: 0x0427E100 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60000AE
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60000AF
        private static System.IntPtr getCPtr(AkChannelConfig obj) { }
        // RVA: 0x0427E084  token: 0x60000B0
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x03805D40  token: 0x60000B1
        protected virtual System.Void Finalize() { }
        // RVA: 0x0427DB20  token: 0x60000B2
        public virtual System.Void Dispose() { }
        // RVA: 0x03805D90  token: 0x60000B3
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0427DF60  token: 0x60000BA
        public static AkChannelConfig Standard(System.UInt32 in_uChannelMask) { }
        // RVA: 0x0427DA0C  token: 0x60000BB
        public static AkChannelConfig Anonymous(System.UInt32 in_uNumChannels) { }
        // RVA: 0x0427D99C  token: 0x60000BC
        public static AkChannelConfig Ambisonic(System.UInt32 in_uNumChannels) { }
        // RVA: 0x0427DBC0  token: 0x60000BD
        public static AkChannelConfig Object() { }
        // RVA: 0x0427DFD0  token: 0x60000BE
        public System.Void .ctor() { }
        // RVA: 0x0427E020  token: 0x60000BF
        public System.Void .ctor(System.UInt32 in_uNumChannels, System.UInt32 in_uChannelMask) { }
        // RVA: 0x0427DA7C  token: 0x60000C0
        public System.Void Clear() { }
        // RVA: 0x0427DF0C  token: 0x60000C1
        public System.Void SetStandard(System.UInt32 in_uChannelMask) { }
        // RVA: 0x0427DEA8  token: 0x60000C2
        public System.Void SetStandardOrAnonymous(System.UInt32 in_uNumChannels, System.UInt32 in_uChannelMask) { }
        // RVA: 0x02A4F3D0  token: 0x60000C3
        public System.Void SetAnonymous(System.UInt32 in_uNumChannels) { }
        // RVA: 0x0427DD64  token: 0x60000C4
        public System.Void SetAmbisonic(System.UInt32 in_uNumChannels) { }
        // RVA: 0x0427DDB8  token: 0x60000C5
        public System.Void SetObject() { }
        // RVA: 0x0427DE08  token: 0x60000C6
        public System.Void SetSameAsMainMix() { }
        // RVA: 0x0427DE58  token: 0x60000C7
        public System.Void SetSameAsPassthrough() { }
        // RVA: 0x0427DB70  token: 0x60000C8
        public System.Boolean IsValid() { }
        // RVA: 0x0427DD14  token: 0x60000C9
        public System.UInt32 Serialize() { }
        // RVA: 0x0427DACC  token: 0x60000CA
        public System.Void Deserialize(System.UInt32 in_uChannelConfig) { }
        // RVA: 0x0427DCA0  token: 0x60000CB
        public AkChannelConfig RemoveLFE() { }
        // RVA: 0x0427DC2C  token: 0x60000CC
        public AkChannelConfig RemoveCenter() { }

    }

    // TypeToken: 0x2000019  // size: 0x14
    public sealed struct AkChannelConfigType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkChannelConfigType AK_ChannelConfigType_Anonymous;  // const
        public static AkChannelConfigType AK_ChannelConfigType_Standard;  // const
        public static AkChannelConfigType AK_ChannelConfigType_Ambisonic;  // const
        public static AkChannelConfigType AK_ChannelConfigType_Objects;  // const
        public static AkChannelConfigType AK_ChannelConfigType_UseDeviceMain;  // const
        public static AkChannelConfigType AK_ChannelConfigType_UseDevicePassthrough;  // const

    }

    // TypeToken: 0x200001A  // size: 0x20
    public class AkChannelEmitter : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        AkWorldTransform position { get; /* RVA: 0x0427E3EC */ set; /* RVA: 0x0427E534 */ }
        System.UInt32 uInputChannels { get; /* RVA: 0x0427E468 */ set; /* RVA: 0x0427E59C */ }
        System.String padding { get; /* RVA: 0x0427E380 */ set; /* RVA: 0x0427E4E0 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60000CD
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60000CE
        private static System.IntPtr getCPtr(AkChannelEmitter obj) { }
        // RVA: 0x0427E4B8  token: 0x60000CF
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427E30C  token: 0x60000D0
        protected virtual System.Void Finalize() { }
        // RVA: 0x0427E2BC  token: 0x60000D1
        public virtual System.Void Dispose() { }
        // RVA: 0x0427E1A8  token: 0x60000D2
        protected virtual System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x200001B  // size: 0x14
    public sealed struct AkChannelOrdering
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkChannelOrdering ChannelOrdering_Standard;  // const
        public static AkChannelOrdering ChannelOrdering_RunTime;  // const

    }

    // TypeToken: 0x200001C  // size: 0x14
    public sealed struct AkConnectionType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkConnectionType ConnectionType_Direct;  // const
        public static AkConnectionType ConnectionType_GameDefSend;  // const
        public static AkConnectionType ConnectionType_UserDefSend;  // const
        public static AkConnectionType ConnectionType_ReflectionsSend;  // const

    }

    // TypeToken: 0x200001D  // size: 0x14
    public sealed struct AkCurveInterpolation
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkCurveInterpolation AkCurveInterpolation_Log3;  // const
        public static AkCurveInterpolation AkCurveInterpolation_Sine;  // const
        public static AkCurveInterpolation AkCurveInterpolation_Log1;  // const
        public static AkCurveInterpolation AkCurveInterpolation_InvSCurve;  // const
        public static AkCurveInterpolation AkCurveInterpolation_Linear;  // const
        public static AkCurveInterpolation AkCurveInterpolation_SCurve;  // const
        public static AkCurveInterpolation AkCurveInterpolation_Exp1;  // const
        public static AkCurveInterpolation AkCurveInterpolation_SineRecip;  // const
        public static AkCurveInterpolation AkCurveInterpolation_Exp3;  // const
        public static AkCurveInterpolation AkCurveInterpolation_LastFadeCurve;  // const
        public static AkCurveInterpolation AkCurveInterpolation_Constant;  // const

    }

    // TypeToken: 0x200001E  // size: 0x20
    public class AkDeviceDescription : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt32 idDevice { get; /* RVA: 0x03618130 */ set; /* RVA: 0x0427EF58 */ }
        System.String deviceName { get; /* RVA: 0x0427EDCC */ set; /* RVA: 0x0427EEB0 */ }
        AkAudioDeviceState deviceStateMask { get; /* RVA: 0x0427EE38 */ set; /* RVA: 0x0427EF04 */ }
        System.Boolean isDefaultDevice { get; /* RVA: 0x03617F70 */ set; /* RVA: 0x0427EFAC */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60000D9
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60000DA
        private static System.IntPtr getCPtr(AkDeviceDescription obj) { }
        // RVA: 0x0427EE88  token: 0x60000DB
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x035A52A0  token: 0x60000DC
        protected virtual System.Void Finalize() { }
        // RVA: 0x0427ECEC  token: 0x60000DD
        public virtual System.Void Dispose() { }
        // RVA: 0x035A52F0  token: 0x60000DE
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0427EC34  token: 0x60000E7
        public System.Void Clear() { }
        // RVA: 0x0427ED3C  token: 0x60000E8
        public static System.Int32 GetSizeOf() { }
        // RVA: 0x0427EC84  token: 0x60000E9
        public System.Void Clone(AkDeviceDescription other) { }
        // RVA: 0x0427ED7C  token: 0x60000EA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001F  // size: 0x20
    public class AkDeviceSettings : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.IntPtr pIOMemory { get; /* RVA: 0x0427F140 */ set; /* RVA: 0x0427F418 */ }
        System.UInt32 uIOMemorySize { get; /* RVA: 0x0427F2AC */ set; /* RVA: 0x02A04150 */ }
        System.UInt32 uIOMemoryAlignment { get; /* RVA: 0x0427F25C */ set; /* RVA: 0x0427F528 */ }
        System.UInt32 ePoolAttributes { get; /* RVA: 0x0427F0A0 */ set; /* RVA: 0x0427F3C4 */ }
        System.UInt32 uGranularity { get; /* RVA: 0x0427F20C */ set; /* RVA: 0x0427F4D4 */ }
        AkThreadProperties threadProperties { get; /* RVA: 0x0427F190 */ set; /* RVA: 0x0427F46C */ }
        System.Single fTargetAutoStmBufferLength { get; /* RVA: 0x0427F0F0 */ set; /* RVA: 0x02A040A0 */ }
        System.UInt32 uMaxConcurrentIO { get; /* RVA: 0x0427F34C */ set; /* RVA: 0x0427F57C */ }
        System.Boolean bUseStreamCache { get; /* RVA: 0x0427F050 */ set; /* RVA: 0x02A03FF0 */ }
        System.UInt32 uMaxCachePinnedBytes { get; /* RVA: 0x0427F2FC */ set; /* RVA: 0x02A03F50 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60000EB
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60000EC
        private static System.IntPtr getCPtr(AkDeviceSettings obj) { }
        // RVA: 0x0427F39C  token: 0x60000ED
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x03924810  token: 0x60000EE
        protected virtual System.Void Finalize() { }
        // RVA: 0x0427F000  token: 0x60000EF
        public virtual System.Void Dispose() { }
        // RVA: 0x03924860  token: 0x60000F0
        protected virtual System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x2000020  // size: 0x20
    public class AkDiffractionPathInfo : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18
        public static System.UInt32 kMaxNodes;  // const

        // Properties
        AkVector64 emitterPos { get; /* RVA: 0x0427FA64 */ set; /* RVA: 0x0427FD5C */ }
        AkWorldTransform virtualPos { get; /* RVA: 0x0427FC60 */ set; /* RVA: 0x0427FF7C */ }
        System.UInt32 nodeCount { get; /* RVA: 0x0427FAD0 */ set; /* RVA: 0x0427FDC8 */ }
        System.Single diffraction { get; /* RVA: 0x0427FA14 */ set; /* RVA: 0x0427FD04 */ }
        System.Single transmissionLoss { get; /* RVA: 0x0427FC10 */ set; /* RVA: 0x0427FF24 */ }
        System.Single totLength { get; /* RVA: 0x0427FBC0 */ set; /* RVA: 0x0427FECC */ }
        System.Single obstructionValue { get; /* RVA: 0x0427FB20 */ set; /* RVA: 0x0427FE1C */ }
        System.Single occlusionValue { get; /* RVA: 0x0427FB70 */ set; /* RVA: 0x0427FE74 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000105
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000106
        private static System.IntPtr getCPtr(AkDiffractionPathInfo obj) { }
        // RVA: 0x0427FCDC  token: 0x6000107
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427F79C  token: 0x6000108
        protected virtual System.Void Finalize() { }
        // RVA: 0x0427F638  token: 0x6000109
        public virtual System.Void Dispose() { }
        // RVA: 0x0427F688  token: 0x600010A
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0427F984  token: 0x600011B
        public static System.Int32 GetSizeOf() { }
        // RVA: 0x0427F864  token: 0x600011C
        public UnityEngine.Vector3 GetNodes(System.UInt32 idx) { }
        // RVA: 0x0427F810  token: 0x600011D
        public System.Single GetAngles(System.UInt32 idx) { }
        // RVA: 0x0427F8DC  token: 0x600011E
        public System.UInt64 GetPortals(System.UInt32 idx) { }
        // RVA: 0x0427F930  token: 0x600011F
        public System.UInt64 GetRooms(System.UInt32 idx) { }
        // RVA: 0x0427F5D0  token: 0x6000120
        public System.Void Clone(AkDiffractionPathInfo other) { }
        // RVA: 0x0427F9C4  token: 0x6000121
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000021  // size: 0x30
    public class AkDurationCallbackInfo : AkEventCallbackInfo
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x28

        // Properties
        System.Single fDuration { get; /* RVA: 0x04280214 */ }
        System.Single fEstimatedDuration { get; /* RVA: 0x04280264 */ }
        System.UInt32 audioNodeID { get; /* RVA: 0x04280174 */ }
        System.UInt32 mediaID { get; /* RVA: 0x042802B4 */ }
        System.Boolean bStreaming { get; /* RVA: 0x042801C4 */ }

        // Methods
        // RVA: 0x031D89D0  token: 0x6000122
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x04280164  token: 0x6000123
        private static System.IntPtr getCPtr(AkDurationCallbackInfo obj) { }
        // RVA: 0x04280304  token: 0x6000124
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427FFE4  token: 0x6000125
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x04280114  token: 0x600012B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000022  // size: 0x28
    public class AkDynamicSequenceItemCallbackInfo : AkCallbackInfo
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x20

        // Properties
        System.UInt32 playingID { get; /* RVA: 0x04280594 */ }
        System.UInt32 audioNodeID { get; /* RVA: 0x042804F4 */ }
        System.IntPtr pCustomInfo { get; /* RVA: 0x04280544 */ }

        // Methods
        // RVA: 0x031D8500  token: 0x600012C
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x042804E4  token: 0x600012D
        private static System.IntPtr getCPtr(AkDynamicSequenceItemCallbackInfo obj) { }
        // RVA: 0x042805E4  token: 0x600012E
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x04280364  token: 0x600012F
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x04280494  token: 0x6000133
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000023  // size: 0x14
    public sealed struct AkDynamicSequenceType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkDynamicSequenceType DynamicSequenceType_SampleAccurate;  // const
        public static AkDynamicSequenceType DynamicSequenceType_NormalTransition;  // const

    }

    // TypeToken: 0x2000024  // size: 0x28
    public class AkEventCallbackInfo : AkCallbackInfo
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x20

        // Properties
        System.UInt32 playingID { get; /* RVA: 0x04280694 */ }
        System.UInt32 eventID { get; /* RVA: 0x0269F840 */ }

        // Methods
        // RVA: 0x031D8870  token: 0x6000134
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x042804E4  token: 0x6000135
        private static System.IntPtr getCPtr(AkEventCallbackInfo obj) { }
        // RVA: 0x031D88F0  token: 0x6000136
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x030388E0  token: 0x6000137
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x04280644  token: 0x600013A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000025  // size: 0x20
    public class AkExtent : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Single halfWidth { get; /* RVA: 0x04280A28 */ set; /* RVA: 0x04280B50 */ }
        System.Single halfHeight { get; /* RVA: 0x042809D8 */ set; /* RVA: 0x04280AF8 */ }
        System.Single halfDepth { get; /* RVA: 0x04280988 */ set; /* RVA: 0x04280AA0 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x600013B
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x600013C
        private static System.IntPtr getCPtr(AkExtent obj) { }
        // RVA: 0x04280A78  token: 0x600013D
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x04280848  token: 0x600013E
        protected virtual System.Void Finalize() { }
        // RVA: 0x042807F8  token: 0x600013F
        public virtual System.Void Dispose() { }
        // RVA: 0x042806E4  token: 0x6000140
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042808BC  token: 0x6000141
        public System.Void .ctor() { }
        // RVA: 0x0428090C  token: 0x6000142
        public System.Void .ctor(System.Single in_halfWidth, System.Single in_halfHeight, System.Single in_halfDepth) { }

    }

    // TypeToken: 0x2000026  // size: 0x20
    public class AkExternalSourceInfo : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt32 iExternalSrcCookie { get; /* RVA: 0x04280EAC */ set; /* RVA: 0x029507E0 */ }
        System.UInt32 idCodec { get; /* RVA: 0x04280EFC */ set; /* RVA: 0x02950730 */ }
        System.String szFile { get; /* RVA: 0x04280FEC */ set; /* RVA: 0x02950890 */ }
        System.IntPtr pInMemory { get; /* RVA: 0x04280F9C */ set; /* RVA: 0x04281124 */ }
        System.UInt32 uiMemorySize { get; /* RVA: 0x04281058 */ set; /* RVA: 0x04281178 */ }
        System.UInt32 idFile { get; /* RVA: 0x04280F4C */ set; /* RVA: 0x042810D0 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000149
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x600014A
        private static System.IntPtr getCPtr(AkExternalSourceInfo obj) { }
        // RVA: 0x042810A8  token: 0x600014B
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x03543B20  token: 0x600014C
        protected virtual System.Void Finalize() { }
        // RVA: 0x04280C60  token: 0x600014D
        public virtual System.Void Dispose() { }
        // RVA: 0x03543B70  token: 0x600014E
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x04280DDC  token: 0x600014F
        public System.Void .ctor() { }
        // RVA: 0x04280E2C  token: 0x6000150
        public System.Void .ctor(System.IntPtr in_pInMemory, System.UInt32 in_uiMemorySize, System.UInt32 in_iExternalSrcCookie, System.UInt32 in_idCodec) { }
        // RVA: 0x04280D64  token: 0x6000151
        public System.Void .ctor(System.String in_pszFileName, System.UInt32 in_iExternalSrcCookie, System.UInt32 in_idCodec) { }
        // RVA: 0x04280CF0  token: 0x6000152
        public System.Void .ctor(System.UInt32 in_idFile, System.UInt32 in_iExternalSrcCookie, System.UInt32 in_idCodec) { }
        // RVA: 0x04280BA8  token: 0x6000153
        public System.Void Clear() { }
        // RVA: 0x04280BF8  token: 0x6000154
        public System.Void Clone(AkExternalSourceInfo other) { }
        // RVA: 0x04280CB0  token: 0x6000155
        public static System.Int32 GetSizeOf() { }

    }

    // TypeToken: 0x2000027  // size: 0x14
    public sealed struct AkFloorPlane
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkFloorPlane AkFloorPlane_XZ;  // const
        public static AkFloorPlane AkFloorPlane_XY;  // const
        public static AkFloorPlane AkFloorPlane_YZ;  // const
        public static AkFloorPlane AkFloorPlane_Default;  // const

    }

    // TypeToken: 0x2000028  // size: 0x20
    public class AkGeometryInstanceParams : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        AkWorldTransform PositionAndOrientation { get; /* RVA: 0x042813F4 */ set; /* RVA: 0x04281550 */ }
        UnityEngine.Vector3 Scale { get; /* RVA: 0x04281470 */ set; /* RVA: 0x042815B8 */ }
        System.Boolean UseForReflectionAndDiffraction { get; /* RVA: 0x042814D8 */ set; /* RVA: 0x04281620 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000162
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000163
        private static System.IntPtr getCPtr(AkGeometryInstanceParams obj) { }
        // RVA: 0x04281528  token: 0x6000164
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x04281330  token: 0x6000165
        protected virtual System.Void Finalize() { }
        // RVA: 0x042811CC  token: 0x6000166
        public virtual System.Void Dispose() { }
        // RVA: 0x0428121C  token: 0x6000167
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042813A4  token: 0x6000168
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000029  // size: 0x14
    public sealed struct AkGlobalCallbackLocation
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_Register;  // const
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_Begin;  // const
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_PreProcessMessageQueueForRender;  // const
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_PostMessagesProcessed;  // const
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_BeginRender;  // const
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_EndRender;  // const
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_End;  // const
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_Term;  // const
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_Monitor;  // const
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_MonitorRecap;  // const
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_Init;  // const
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_Suspend;  // const
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_WakeupFromSuspend;  // const
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_Num;  // const

    }

    // TypeToken: 0x200002A  // size: 0x14
    public sealed struct AkGroupType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkGroupType AkGroupType_Switch;  // const
        public static AkGroupType AkGroupType_State;  // const

    }

    // TypeToken: 0x200002B  // size: 0x20
    public class AkImageSourceParams : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        AkVector64 sourcePosition { get; /* RVA: 0x04281A68 */ set; /* RVA: 0x04281CFC */ }
        System.Single fDistanceScalingFactor { get; /* RVA: 0x04281978 */ set; /* RVA: 0x04281BF4 */ }
        System.Single fLevel { get; /* RVA: 0x042819C8 */ set; /* RVA: 0x04281C4C */ }
        System.Single fDiffraction { get; /* RVA: 0x04281928 */ set; /* RVA: 0x04281B9C */ }
        System.Single fOcclusion { get; /* RVA: 0x04281A18 */ set; /* RVA: 0x04281CA4 */ }
        System.Byte uDiffractionEmitterSide { get; /* RVA: 0x04281AD4 */ set; /* RVA: 0x04281D68 */ }
        System.Byte uDiffractionListenerSide { get; /* RVA: 0x04281B24 */ set; /* RVA: 0x04281DBC */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x600016F
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000170
        private static System.IntPtr getCPtr(AkImageSourceParams obj) { }
        // RVA: 0x04281B74  token: 0x6000171
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042817D8  token: 0x6000172
        protected virtual System.Void Finalize() { }
        // RVA: 0x04281674  token: 0x6000173
        public virtual System.Void Dispose() { }
        // RVA: 0x042816C4  token: 0x6000174
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0428184C  token: 0x6000175
        public System.Void .ctor() { }
        // RVA: 0x0428189C  token: 0x6000176
        public System.Void .ctor(AkVector64 in_sourcePosition, System.Single in_fDistanceScalingFactor, System.Single in_fLevel) { }

    }

    // TypeToken: 0x200002C  // size: 0x20
    public class AkImageSourceSettings : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        AkImageSourceParams params_ { get; /* RVA: 0x04282118 */ set; /* RVA: 0x042821BC */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000185
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000186
        private static System.IntPtr getCPtr(AkImageSourceSettings obj) { }
        // RVA: 0x04282194  token: 0x6000187
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x04281F74  token: 0x6000188
        protected virtual System.Void Finalize() { }
        // RVA: 0x04281F24  token: 0x6000189
        public virtual System.Void Dispose() { }
        // RVA: 0x04281E10  token: 0x600018A
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042820C8  token: 0x600018B
        public System.Void .ctor() { }
        // RVA: 0x0428203C  token: 0x600018C
        public System.Void .ctor(AkVector64 in_sourcePosition, System.Single in_fDistanceScalingFactor, System.Single in_fLevel) { }
        // RVA: 0x04281FE8  token: 0x600018D
        public System.Void SetOneTexture(System.UInt32 in_texture) { }

    }

    // TypeToken: 0x200002D  // size: 0x20
    public class AkInitializationSettings : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        AkStreamMgrSettings streamMgrSettings { get; /* RVA: 0x02A03870 */ set; /* RVA: 0x04282CB8 */ }
        AkDeviceSettings deviceSettings { get; /* RVA: 0x02A02C10 */ set; /* RVA: 0x04282B18 */ }
        AkInitSettings initSettings { get; /* RVA: 0x02A02B40 */ set; /* RVA: 0x04282B80 */ }
        AkPlatformInitSettings platformSettings { get; /* RVA: 0x02A02A70 */ set; /* RVA: 0x04282C50 */ }
        AkMusicSettings musicSettings { get; /* RVA: 0x02A037A0 */ set; /* RVA: 0x04282BE8 */ }
        AkUnityPlatformSpecificSettings unityPlatformSpecificSettings { get; /* RVA: 0x02A029A0 */ set; /* RVA: 0x04282D20 */ }
        System.UInt32 uMemAllocationSizeLimit { get; /* RVA: 0x04282A00 */ set; /* RVA: 0x02A01BE0 */ }
        System.UInt32 uMemDebugLevel { get; /* RVA: 0x04282A50 */ set; /* RVA: 0x02A03EB0 */ }
        System.UInt32 uMemSpanCount { get; /* RVA: 0x04282AA0 */ set; /* RVA: 0x02A03E10 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000190
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x02524410  token: 0x6000191
        private static System.IntPtr getCPtr(AkInitializationSettings obj) { }
        // RVA: 0x04282AF0  token: 0x6000192
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x039C1A20  token: 0x6000193
        protected virtual System.Void Finalize() { }
        // RVA: 0x042829B0  token: 0x6000194
        public virtual System.Void Dispose() { }
        // RVA: 0x039C1A70  token: 0x6000195
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x02A03CF0  token: 0x6000196
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002E  // size: 0x20
    public class AkInitSettings : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt32 uMaxNumPaths { get; /* RVA: 0x04282634 */ set; /* RVA: 0x02A4EB00 */ }
        System.UInt32 uCommandQueueSize { get; /* RVA: 0x042824F4 */ set; /* RVA: 0x02A4EA60 */ }
        System.Boolean bEnableGameSyncPreparation { get; /* RVA: 0x042822C4 */ set; /* RVA: 0x02A01A80 */ }
        System.UInt32 uContinuousPlaybackLookAhead { get; /* RVA: 0x04282544 */ set; /* RVA: 0x02A019E0 */ }
        System.UInt32 uNumSamplesPerFrame { get; /* RVA: 0x042826D4 */ set; /* RVA: 0x02A4E9C0 */ }
        System.UInt32 uMonitorQueuePoolSize { get; /* RVA: 0x04282684 */ set; /* RVA: 0x02A01940 */ }
        System.UInt32 uCpuMonitorQueueMaxSize { get; /* RVA: 0x04282594 */ set; /* RVA: 0x0428295C */ }
        AkOutputSettings settingsMainOutput { get; /* RVA: 0x02A4E890 */ set; /* RVA: 0x042828A0 */ }
        System.UInt32 uMaxHardwareTimeoutMs { get; /* RVA: 0x042825E4 */ set; /* RVA: 0x02A018A0 */ }
        System.Boolean bUseSoundBankMgrThread { get; /* RVA: 0x04282364 */ set; /* RVA: 0x042827A0 */ }
        System.Boolean bUseLEngineThread { get; /* RVA: 0x04282314 */ set; /* RVA: 0x0428274C */ }
        System.String szPluginDLLPath { get; /* RVA: 0x02A4E730 */ set; /* RVA: 0x02A4E960 */ }
        AkFloorPlane eFloorPlane { get; /* RVA: 0x042823B4 */ set; /* RVA: 0x042827F4 */ }
        System.Single fGameUnitsToMeters { get; /* RVA: 0x04282454 */ set; /* RVA: 0x04282848 */ }
        System.UInt32 uBankReadBufferSize { get; /* RVA: 0x042824A4 */ set; /* RVA: 0x04282908 */ }
        System.Single fDebugOutOfRangeLimit { get; /* RVA: 0x04282404 */ set; /* RVA: 0x02A017F0 */ }
        System.Boolean bDebugOutOfRangeCheckEnabled { get; /* RVA: 0x04282274 */ set; /* RVA: 0x02A01740 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60001A9
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60001AA
        private static System.IntPtr getCPtr(AkInitSettings obj) { }
        // RVA: 0x04282724  token: 0x60001AB
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x03924510  token: 0x60001AC
        protected virtual System.Void Finalize() { }
        // RVA: 0x04282224  token: 0x60001AD
        public virtual System.Void Dispose() { }
        // RVA: 0x03924560  token: 0x60001AE
        protected virtual System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x200002F  // size: 0x20
    public class AkIterator : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        AkPlaylistItem pItem { get; /* RVA: 0x042831DC */ set; /* RVA: 0x04283280 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60001D1
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60001D2
        private static System.IntPtr getCPtr(AkIterator obj) { }
        // RVA: 0x04283258  token: 0x60001D3
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x04282EEC  token: 0x60001D4
        protected virtual System.Void Finalize() { }
        // RVA: 0x04282E9C  token: 0x60001D5
        public virtual System.Void Dispose() { }
        // RVA: 0x04282D88  token: 0x60001D6
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042830A4  token: 0x60001D9
        public AkIterator NextIter() { }
        // RVA: 0x04283118  token: 0x60001DA
        public AkIterator PrevIter() { }
        // RVA: 0x04282F60  token: 0x60001DB
        public AkPlaylistItem GetItem() { }
        // RVA: 0x0428303C  token: 0x60001DC
        public System.Boolean IsEqualTo(AkIterator in_rOp) { }
        // RVA: 0x04282FD4  token: 0x60001DD
        public System.Boolean IsDifferentFrom(AkIterator in_rOp) { }
        // RVA: 0x0428318C  token: 0x60001DE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000030  // size: 0x30
    public class AkMarkerCallbackInfo : AkEventCallbackInfo
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x28

        // Properties
        System.UInt32 uIdentifier { get; /* RVA: 0x04285730 */ }
        System.UInt32 uPosition { get; /* RVA: 0x04285780 */ }
        System.String strLabel { get; /* RVA: 0x042856C4 */ }

        // Methods
        // RVA: 0x031D87B0  token: 0x60001DF
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x04280164  token: 0x60001E0
        private static System.IntPtr getCPtr(AkMarkerCallbackInfo obj) { }
        // RVA: 0x042857D0  token: 0x60001E1
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x04285544  token: 0x60001E2
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x04285674  token: 0x60001E6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000031  // size: 0x20
    public class AkMemCategroyStats : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt64 uUsed { get; /* RVA: 0x04285AF8 */ set; /* RVA: 0x04285C6C */ }
        System.UInt64 uPeakUsed { get; /* RVA: 0x04285AA8 */ set; /* RVA: 0x04285C18 */ }
        System.UInt32 uAllocs { get; /* RVA: 0x04285A08 */ set; /* RVA: 0x04285B70 */ }
        System.UInt32 uFrees { get; /* RVA: 0x04285A58 */ set; /* RVA: 0x04285BC4 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60001E7
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60001E8
        private static System.IntPtr getCPtr(AkMemCategroyStats obj) { }
        // RVA: 0x04285B48  token: 0x60001E9
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x04285994  token: 0x60001EA
        protected virtual System.Void Finalize() { }
        // RVA: 0x04285830  token: 0x60001EB
        public virtual System.Void Dispose() { }
        // RVA: 0x04285880  token: 0x60001EC
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x03B38030  token: 0x60001F5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000032  // size: 0x20
    public class AkMemGlobalStats : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt64 uUsed { get; /* RVA: 0x04285FD8 */ set; /* RVA: 0x0428614C */ }
        System.UInt64 uDeviceUsed { get; /* RVA: 0x04285EE8 */ set; /* RVA: 0x04286050 */ }
        System.UInt64 uReserved { get; /* RVA: 0x04285F88 */ set; /* RVA: 0x042860F8 */ }
        System.UInt64 uMax { get; /* RVA: 0x04285F38 */ set; /* RVA: 0x042860A4 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60001F6
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60001F7
        private static System.IntPtr getCPtr(AkMemGlobalStats obj) { }
        // RVA: 0x04286028  token: 0x60001F8
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x04285E24  token: 0x60001F9
        protected virtual System.Void Finalize() { }
        // RVA: 0x04285DD4  token: 0x60001FA
        public virtual System.Void Dispose() { }
        // RVA: 0x04285CC0  token: 0x60001FB
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x04285E98  token: 0x6000204
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000033  // size: 0x14
    public sealed struct AkMemID
    {
        // Fields
        public System.UInt32 value__;  // 0x10
        public static AkMemID AkMemID_Object;  // const
        public static AkMemID AkMemID_Event;  // const
        public static AkMemID AkMemID_Structure;  // const
        public static AkMemID AkMemID_Media;  // const
        public static AkMemID AkMemID_GameObject;  // const
        public static AkMemID AkMemID_Processing;  // const
        public static AkMemID AkMemID_ProcessingPlugin;  // const
        public static AkMemID AkMemID_Streaming;  // const
        public static AkMemID AkMemID_StreamingIO;  // const
        public static AkMemID AkMemID_SpatialAudio;  // const
        public static AkMemID AkMemID_SpatialAudioGeometry;  // const
        public static AkMemID AkMemID_SpatialAudioPaths;  // const
        public static AkMemID AkMemID_GameSim;  // const
        public static AkMemID AkMemID_MonitorQueue;  // const
        public static AkMemID AkMemID_Profiler;  // const
        public static AkMemID AkMemID_FilePackage;  // const
        public static AkMemID AkMemID_SoundEngine;  // const
        public static AkMemID AkMemID_Integration;  // const
        public static AkMemID AkMemID_JobMgr;  // const
        public static AkMemID AkMemID_TempAudioRender;  // const
        public static AkMemID AkMemID_NUM;  // const
        public static AkMemID AkMemID_MASK;  // const
        public static AkMemID AkMemType_Media;  // const
        public static AkMemID AkMemType_Device;  // const
        public static AkMemID AkMemType_NoTrack;  // const

    }

    // TypeToken: 0x2000034  // size: 0x14
    public sealed struct AkMeteringFlags
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkMeteringFlags AK_NoMetering;  // const
        public static AkMeteringFlags AK_EnableBusMeter_Peak;  // const
        public static AkMeteringFlags AK_EnableBusMeter_TruePeak;  // const
        public static AkMeteringFlags AK_EnableBusMeter_RMS;  // const
        public static AkMeteringFlags AK_EnableBusMeter_KPower;  // const
        public static AkMeteringFlags AK_EnableBusMeter_3DMeter;  // const

    }

    // TypeToken: 0x2000035  // size: 0x14
    public sealed struct AkMIDICcTypes
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkMIDICcTypes BANK_SELECT_COARSE;  // const
        public static AkMIDICcTypes MOD_WHEEL_COARSE;  // const
        public static AkMIDICcTypes BREATH_CTRL_COARSE;  // const
        public static AkMIDICcTypes CTRL_3_COARSE;  // const
        public static AkMIDICcTypes FOOT_PEDAL_COARSE;  // const
        public static AkMIDICcTypes PORTAMENTO_COARSE;  // const
        public static AkMIDICcTypes DATA_ENTRY_COARSE;  // const
        public static AkMIDICcTypes VOLUME_COARSE;  // const
        public static AkMIDICcTypes BALANCE_COARSE;  // const
        public static AkMIDICcTypes CTRL_9_COARSE;  // const
        public static AkMIDICcTypes PAN_POSITION_COARSE;  // const
        public static AkMIDICcTypes EXPRESSION_COARSE;  // const
        public static AkMIDICcTypes EFFECT_CTRL_1_COARSE;  // const
        public static AkMIDICcTypes EFFECT_CTRL_2_COARSE;  // const
        public static AkMIDICcTypes CTRL_14_COARSE;  // const
        public static AkMIDICcTypes CTRL_15_COARSE;  // const
        public static AkMIDICcTypes GEN_SLIDER_1;  // const
        public static AkMIDICcTypes GEN_SLIDER_2;  // const
        public static AkMIDICcTypes GEN_SLIDER_3;  // const
        public static AkMIDICcTypes GEN_SLIDER_4;  // const
        public static AkMIDICcTypes CTRL_20_COARSE;  // const
        public static AkMIDICcTypes CTRL_21_COARSE;  // const
        public static AkMIDICcTypes CTRL_22_COARSE;  // const
        public static AkMIDICcTypes CTRL_23_COARSE;  // const
        public static AkMIDICcTypes CTRL_24_COARSE;  // const
        public static AkMIDICcTypes CTRL_25_COARSE;  // const
        public static AkMIDICcTypes CTRL_26_COARSE;  // const
        public static AkMIDICcTypes CTRL_27_COARSE;  // const
        public static AkMIDICcTypes CTRL_28_COARSE;  // const
        public static AkMIDICcTypes CTRL_29_COARSE;  // const
        public static AkMIDICcTypes CTRL_30_COARSE;  // const
        public static AkMIDICcTypes CTRL_31_COARSE;  // const
        public static AkMIDICcTypes BANK_SELECT_FINE;  // const
        public static AkMIDICcTypes MOD_WHEEL_FINE;  // const
        public static AkMIDICcTypes BREATH_CTRL_FINE;  // const
        public static AkMIDICcTypes CTRL_3_FINE;  // const
        public static AkMIDICcTypes FOOT_PEDAL_FINE;  // const
        public static AkMIDICcTypes PORTAMENTO_FINE;  // const
        public static AkMIDICcTypes DATA_ENTRY_FINE;  // const
        public static AkMIDICcTypes VOLUME_FINE;  // const
        public static AkMIDICcTypes BALANCE_FINE;  // const
        public static AkMIDICcTypes CTRL_9_FINE;  // const
        public static AkMIDICcTypes PAN_POSITION_FINE;  // const
        public static AkMIDICcTypes EXPRESSION_FINE;  // const
        public static AkMIDICcTypes EFFECT_CTRL_1_FINE;  // const
        public static AkMIDICcTypes EFFECT_CTRL_2_FINE;  // const
        public static AkMIDICcTypes CTRL_14_FINE;  // const
        public static AkMIDICcTypes CTRL_15_FINE;  // const
        public static AkMIDICcTypes CTRL_20_FINE;  // const
        public static AkMIDICcTypes CTRL_21_FINE;  // const
        public static AkMIDICcTypes CTRL_22_FINE;  // const
        public static AkMIDICcTypes CTRL_23_FINE;  // const
        public static AkMIDICcTypes CTRL_24_FINE;  // const
        public static AkMIDICcTypes CTRL_25_FINE;  // const
        public static AkMIDICcTypes CTRL_26_FINE;  // const
        public static AkMIDICcTypes CTRL_27_FINE;  // const
        public static AkMIDICcTypes CTRL_28_FINE;  // const
        public static AkMIDICcTypes CTRL_29_FINE;  // const
        public static AkMIDICcTypes CTRL_30_FINE;  // const
        public static AkMIDICcTypes CTRL_31_FINE;  // const
        public static AkMIDICcTypes HOLD_PEDAL;  // const
        public static AkMIDICcTypes PORTAMENTO_ON_OFF;  // const
        public static AkMIDICcTypes SUSTENUTO_PEDAL;  // const
        public static AkMIDICcTypes SOFT_PEDAL;  // const
        public static AkMIDICcTypes LEGATO_PEDAL;  // const
        public static AkMIDICcTypes HOLD_PEDAL_2;  // const
        public static AkMIDICcTypes SOUND_VARIATION;  // const
        public static AkMIDICcTypes SOUND_TIMBRE;  // const
        public static AkMIDICcTypes SOUND_RELEASE_TIME;  // const
        public static AkMIDICcTypes SOUND_ATTACK_TIME;  // const
        public static AkMIDICcTypes SOUND_BRIGHTNESS;  // const
        public static AkMIDICcTypes SOUND_CTRL_6;  // const
        public static AkMIDICcTypes SOUND_CTRL_7;  // const
        public static AkMIDICcTypes SOUND_CTRL_8;  // const
        public static AkMIDICcTypes SOUND_CTRL_9;  // const
        public static AkMIDICcTypes SOUND_CTRL_10;  // const
        public static AkMIDICcTypes GENERAL_BUTTON_1;  // const
        public static AkMIDICcTypes GENERAL_BUTTON_2;  // const
        public static AkMIDICcTypes GENERAL_BUTTON_3;  // const
        public static AkMIDICcTypes GENERAL_BUTTON_4;  // const
        public static AkMIDICcTypes REVERB_LEVEL;  // const
        public static AkMIDICcTypes TREMOLO_LEVEL;  // const
        public static AkMIDICcTypes CHORUS_LEVEL;  // const
        public static AkMIDICcTypes CELESTE_LEVEL;  // const
        public static AkMIDICcTypes PHASER_LEVEL;  // const
        public static AkMIDICcTypes DATA_BUTTON_P1;  // const
        public static AkMIDICcTypes DATA_BUTTON_M1;  // const
        public static AkMIDICcTypes NON_REGISTER_COARSE;  // const
        public static AkMIDICcTypes NON_REGISTER_FINE;  // const
        public static AkMIDICcTypes ALL_SOUND_OFF;  // const
        public static AkMIDICcTypes ALL_CONTROLLERS_OFF;  // const
        public static AkMIDICcTypes LOCAL_KEYBOARD;  // const
        public static AkMIDICcTypes ALL_NOTES_OFF;  // const
        public static AkMIDICcTypes OMNI_MODE_OFF;  // const
        public static AkMIDICcTypes OMNI_MODE_ON;  // const
        public static AkMIDICcTypes OMNI_MONOPHONIC_ON;  // const
        public static AkMIDICcTypes OMNI_POLYPHONIC_ON;  // const

    }

    // TypeToken: 0x2000037  // size: 0x20
    public class tGen : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Byte byParam1 { get; /* RVA: 0x042A91DC */ set; /* RVA: 0x042A92A4 */ }
        System.Byte byParam2 { get; /* RVA: 0x042A922C */ set; /* RVA: 0x042A92F8 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000238
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000239
        private static System.IntPtr getCPtr(AkMIDIEvent.tGen obj) { }
        // RVA: 0x042A927C  token: 0x600023A
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042A9118  token: 0x600023B
        protected virtual System.Void Finalize() { }
        // RVA: 0x042A8FB4  token: 0x600023C
        public virtual System.Void Dispose() { }
        // RVA: 0x042A9004  token: 0x600023D
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042A918C  token: 0x6000242
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000038  // size: 0x20
    public class tNoteOnOff : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Byte byNote { get; /* RVA: 0x042A990C */ set; /* RVA: 0x042A99D4 */ }
        System.Byte byVelocity { get; /* RVA: 0x042A995C */ set; /* RVA: 0x042A9A28 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000243
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000244
        private static System.IntPtr getCPtr(AkMIDIEvent.tNoteOnOff obj) { }
        // RVA: 0x042A99AC  token: 0x6000245
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042A9848  token: 0x6000246
        protected virtual System.Void Finalize() { }
        // RVA: 0x042A96E4  token: 0x6000247
        public virtual System.Void Dispose() { }
        // RVA: 0x042A9734  token: 0x6000248
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042A98BC  token: 0x600024D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000039  // size: 0x20
    public class tCc : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Byte byCc { get; /* RVA: 0x042A8B50 */ set; /* RVA: 0x042A8C18 */ }
        System.Byte byValue { get; /* RVA: 0x042A8BA0 */ set; /* RVA: 0x042A8C6C */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x600024E
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x600024F
        private static System.IntPtr getCPtr(AkMIDIEvent.tCc obj) { }
        // RVA: 0x042A8BF0  token: 0x6000250
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042A8A8C  token: 0x6000251
        protected virtual System.Void Finalize() { }
        // RVA: 0x042A8A3C  token: 0x6000252
        public virtual System.Void Dispose() { }
        // RVA: 0x042A8928  token: 0x6000253
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042A8B00  token: 0x6000258
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003A  // size: 0x20
    public class tPitchBend : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Byte byValueLsb { get; /* RVA: 0x042A9CA4 */ set; /* RVA: 0x042A9D6C */ }
        System.Byte byValueMsb { get; /* RVA: 0x042A9CF4 */ set; /* RVA: 0x042A9DC0 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000259
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x600025A
        private static System.IntPtr getCPtr(AkMIDIEvent.tPitchBend obj) { }
        // RVA: 0x042A9D44  token: 0x600025B
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042A9BE0  token: 0x600025C
        protected virtual System.Void Finalize() { }
        // RVA: 0x042A9B90  token: 0x600025D
        public virtual System.Void Dispose() { }
        // RVA: 0x042A9A7C  token: 0x600025E
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042A9C54  token: 0x6000263
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003B  // size: 0x20
    public class tNoteAftertouch : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Byte byNote { get; /* RVA: 0x042A9574 */ set; /* RVA: 0x042A963C */ }
        System.Byte byValue { get; /* RVA: 0x042A95C4 */ set; /* RVA: 0x042A9690 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000264
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000265
        private static System.IntPtr getCPtr(AkMIDIEvent.tNoteAftertouch obj) { }
        // RVA: 0x042A9614  token: 0x6000266
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042A94B0  token: 0x6000267
        protected virtual System.Void Finalize() { }
        // RVA: 0x042A9460  token: 0x6000268
        public virtual System.Void Dispose() { }
        // RVA: 0x042A934C  token: 0x6000269
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042A9524  token: 0x600026E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003C  // size: 0x20
    public class tChanAftertouch : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Byte byValue { get; /* RVA: 0x042A8EE8 */ set; /* RVA: 0x042A8F60 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x600026F
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000270
        private static System.IntPtr getCPtr(AkMIDIEvent.tChanAftertouch obj) { }
        // RVA: 0x042A8F38  token: 0x6000271
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042A8E24  token: 0x6000272
        protected virtual System.Void Finalize() { }
        // RVA: 0x042A8CC0  token: 0x6000273
        public virtual System.Void Dispose() { }
        // RVA: 0x042A8D10  token: 0x6000274
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042A8E98  token: 0x6000277
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003D  // size: 0x20
    public class tProgramChange : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Byte byProgramNum { get; /* RVA: 0x042AA03C */ set; /* RVA: 0x042AA0B4 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000278
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000279
        private static System.IntPtr getCPtr(AkMIDIEvent.tProgramChange obj) { }
        // RVA: 0x042AA08C  token: 0x600027A
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042A9F78  token: 0x600027B
        protected virtual System.Void Finalize() { }
        // RVA: 0x042A9E14  token: 0x600027C
        public virtual System.Void Dispose() { }
        // RVA: 0x042A9E64  token: 0x600027D
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042A9FEC  token: 0x6000280
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003E  // size: 0x20
    public class tWwiseCmd : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt16 uCmd { get; /* RVA: 0x042AA380 */ set; /* RVA: 0x042AA44C */ }
        System.UInt32 uArg { get; /* RVA: 0x042AA330 */ set; /* RVA: 0x042AA3F8 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000281
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000282
        private static System.IntPtr getCPtr(AkMIDIEvent.tWwiseCmd obj) { }
        // RVA: 0x042AA3D0  token: 0x6000283
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042AA26C  token: 0x6000284
        protected virtual System.Void Finalize() { }
        // RVA: 0x042AA108  token: 0x6000285
        public virtual System.Void Dispose() { }
        // RVA: 0x042AA158  token: 0x6000286
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042AA2E0  token: 0x600028B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000036  // size: 0x20
    public class AkMIDIEvent : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Byte byChan { get; /* RVA: 0x04283FFC */ set; /* RVA: 0x042847D4 */ }
        AkMIDIEvent.tGen Gen { get; /* RVA: 0x04283BD4 */ set; /* RVA: 0x04284414 */ }
        AkMIDIEvent.tCc Cc { get; /* RVA: 0x04283ADC */ set; /* RVA: 0x04284344 */ }
        AkMIDIEvent.tNoteOnOff NoteOnOff { get; /* RVA: 0x04283CCC */ set; /* RVA: 0x042844E4 */ }
        AkMIDIEvent.tPitchBend PitchBend { get; /* RVA: 0x04283D48 */ set; /* RVA: 0x0428454C */ }
        AkMIDIEvent.tNoteAftertouch NoteAftertouch { get; /* RVA: 0x04283C50 */ set; /* RVA: 0x0428447C */ }
        AkMIDIEvent.tChanAftertouch ChanAftertouch { get; /* RVA: 0x04283B58 */ set; /* RVA: 0x042843AC */ }
        AkMIDIEvent.tProgramChange ProgramChange { get; /* RVA: 0x04283DC4 */ set; /* RVA: 0x042845B4 */ }
        AkMIDIEvent.tWwiseCmd WwiseCmd { get; /* RVA: 0x04283E40 */ set; /* RVA: 0x0428461C */ }
        AkMIDIEventTypes byType { get; /* RVA: 0x0428413C */ set; /* RVA: 0x04284924 */ }
        System.Byte byOnOffNote { get; /* RVA: 0x0428409C */ set; /* RVA: 0x0428487C */ }
        System.Byte byVelocity { get; /* RVA: 0x0428422C */ set; /* RVA: 0x04284A20 */ }
        AkMIDICcTypes byCc { get; /* RVA: 0x04283F5C */ set; /* RVA: 0x0428472C */ }
        System.Byte byCcValue { get; /* RVA: 0x04283F0C */ set; /* RVA: 0x042846D8 */ }
        System.Byte byValueLsb { get; /* RVA: 0x0428418C */ set; /* RVA: 0x04284978 */ }
        System.Byte byValueMsb { get; /* RVA: 0x042841DC */ set; /* RVA: 0x042849CC */ }
        System.Byte byAftertouchNote { get; /* RVA: 0x04283EBC */ set; /* RVA: 0x04284684 */ }
        System.Byte byNoteAftertouchValue { get; /* RVA: 0x0428404C */ set; /* RVA: 0x04284828 */ }
        System.Byte byChanAftertouchValue { get; /* RVA: 0x04283FAC */ set; /* RVA: 0x04284780 */ }
        System.Byte byProgramNum { get; /* RVA: 0x042840EC */ set; /* RVA: 0x042848D0 */ }
        System.UInt16 uCmd { get; /* RVA: 0x042842CC */ set; /* RVA: 0x04284AC8 */ }
        System.UInt32 uArg { get; /* RVA: 0x0428427C */ set; /* RVA: 0x04284A74 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000205
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000206
        private static System.IntPtr getCPtr(AkMIDIEvent obj) { }
        // RVA: 0x0428431C  token: 0x6000207
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427D550  token: 0x6000208
        protected virtual System.Void Finalize() { }
        // RVA: 0x04283928  token: 0x6000209
        public virtual System.Void Dispose() { }
        // RVA: 0x04283978  token: 0x600020A
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x04283A8C  token: 0x6000237
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003F  // size: 0x30
    public class AkMIDIEventCallbackInfo : AkEventCallbackInfo
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x28

        // Properties
        System.Byte byChan { get; /* RVA: 0x042835A8 */ }
        System.Byte byParam1 { get; /* RVA: 0x04283698 */ }
        System.Byte byParam2 { get; /* RVA: 0x042836E8 */ }
        AkMIDIEventTypes byType { get; /* RVA: 0x04283788 */ }
        System.Byte byOnOffNote { get; /* RVA: 0x04283648 */ }
        System.Byte byVelocity { get; /* RVA: 0x04283878 */ }
        AkMIDICcTypes byCc { get; /* RVA: 0x04283508 */ }
        System.Byte byCcValue { get; /* RVA: 0x042834B8 */ }
        System.Byte byValueLsb { get; /* RVA: 0x042837D8 */ }
        System.Byte byValueMsb { get; /* RVA: 0x04283828 */ }
        System.Byte byAftertouchNote { get; /* RVA: 0x04283468 */ }
        System.Byte byNoteAftertouchValue { get; /* RVA: 0x042835F8 */ }
        System.Byte byChanAftertouchValue { get; /* RVA: 0x04283558 */ }
        System.Byte byProgramNum { get; /* RVA: 0x04283738 */ }

        // Methods
        // RVA: 0x031D86B0  token: 0x600028C
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x04280164  token: 0x600028D
        private static System.IntPtr getCPtr(AkMIDIEventCallbackInfo obj) { }
        // RVA: 0x042838C8  token: 0x600028E
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042832E8  token: 0x600028F
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x04283418  token: 0x600029E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000040  // size: 0x14
    public sealed struct AkMIDIEventTypes
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkMIDIEventTypes NOTE_OFF;  // const
        public static AkMIDIEventTypes NOTE_ON;  // const
        public static AkMIDIEventTypes NOTE_AFTERTOUCH;  // const
        public static AkMIDIEventTypes CONTROLLER;  // const
        public static AkMIDIEventTypes PROGRAM_CHANGE;  // const
        public static AkMIDIEventTypes CHANNEL_AFTERTOUCH;  // const
        public static AkMIDIEventTypes PITCH_BEND;  // const
        public static AkMIDIEventTypes SYSEX;  // const
        public static AkMIDIEventTypes ESCAPE;  // const
        public static AkMIDIEventTypes META;  // const

    }

    // TypeToken: 0x2000041  // size: 0x28
    public class AkMIDIPost : AkMIDIEvent
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x20

        // Properties
        System.UInt64 uOffset { get; /* RVA: 0x04285440 */ set; /* RVA: 0x042854F0 */ }

        // Methods
        // RVA: 0x04285388  token: 0x600029F
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x042804E4  token: 0x60002A0
        private static System.IntPtr getCPtr(AkMIDIPost obj) { }
        // RVA: 0x04285490  token: 0x60002A1
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x04284B84  token: 0x60002A2
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x04284EE4  token: 0x60002A5
        public System.UInt32 PostOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uNumPosts) { }
        // RVA: 0x04284F80  token: 0x60002A6
        public System.UInt32 PostOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets) { }
        // RVA: 0x042850D0  token: 0x60002A7
        public System.UInt32 PostOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        // RVA: 0x04284CF4  token: 0x60002A8
        public System.UInt32 PostOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_playingID) { }
        // RVA: 0x042852E4  token: 0x60002A9
        public System.UInt32 PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uNumPosts) { }
        // RVA: 0x04285024  token: 0x60002AA
        public System.UInt32 PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets) { }
        // RVA: 0x04284E10  token: 0x60002AB
        public System.UInt32 PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        // RVA: 0x042851E4  token: 0x60002AC
        public System.UInt32 PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_playingID) { }
        // RVA: 0x04284B1C  token: 0x60002AD
        public System.Void Clone(AkMIDIPost other) { }
        // RVA: 0x04284CB4  token: 0x60002AE
        public static System.Int32 GetSizeOf() { }
        // RVA: 0x042853F0  token: 0x60002AF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000042  // size: 0x14
    public sealed struct AkMonitorErrorCode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkMonitorErrorCode ErrorCode_NoError;  // const
        public static AkMonitorErrorCode ErrorCode_FileNotFound;  // const
        public static AkMonitorErrorCode ErrorCode_CannotOpenFile;  // const
        public static AkMonitorErrorCode ErrorCode_CannotStartStreamNoMemory;  // const
        public static AkMonitorErrorCode ErrorCode_IODevice;  // const
        public static AkMonitorErrorCode ErrorCode_IncompatibleIOSettings;  // const
        public static AkMonitorErrorCode ErrorCode_PluginUnsupportedChannelConfiguration;  // const
        public static AkMonitorErrorCode ErrorCode_PluginMediaUnavailable;  // const
        public static AkMonitorErrorCode ErrorCode_PluginInitialisationFailed;  // const
        public static AkMonitorErrorCode ErrorCode_PluginProcessingFailed;  // const
        public static AkMonitorErrorCode ErrorCode_PluginExecutionInvalid;  // const
        public static AkMonitorErrorCode ErrorCode_PluginAllocationFailed;  // const
        public static AkMonitorErrorCode ErrorCode_VorbisSeekTableRecommended;  // const
        public static AkMonitorErrorCode ErrorCode_VorbisDecodeError;  // const
        public static AkMonitorErrorCode ErrorCode_ATRAC9DecodeFailed;  // const
        public static AkMonitorErrorCode ErrorCode_ATRAC9LoopSectionTooSmall;  // const
        public static AkMonitorErrorCode ErrorCode_InvalidAudioFileHeader;  // const
        public static AkMonitorErrorCode ErrorCode_AudioFileHeaderTooLarge;  // const
        public static AkMonitorErrorCode ErrorCode_LoopTooSmall;  // const
        public static AkMonitorErrorCode ErrorCode_TransitionNotAccurateChannel;  // const
        public static AkMonitorErrorCode ErrorCode_TransitionNotAccuratePluginMismatch;  // const
        public static AkMonitorErrorCode ErrorCode_TransitionNotAccurateRejectedByPlugin;  // const
        public static AkMonitorErrorCode ErrorCode_TransitionNotAccurateStarvation;  // const
        public static AkMonitorErrorCode ErrorCode_TransitionNotAccurateCodecError;  // const
        public static AkMonitorErrorCode ErrorCode_NothingToPlay;  // const
        public static AkMonitorErrorCode ErrorCode_PlayFailed;  // const
        public static AkMonitorErrorCode ErrorCode_StingerCouldNotBeScheduled;  // const
        public static AkMonitorErrorCode ErrorCode_TooLongSegmentLookAhead;  // const
        public static AkMonitorErrorCode ErrorCode_CannotScheduleMusicSwitch;  // const
        public static AkMonitorErrorCode ErrorCode_TooManySimultaneousMusicSegments;  // const
        public static AkMonitorErrorCode ErrorCode_PlaylistStoppedForEditing;  // const
        public static AkMonitorErrorCode ErrorCode_MusicClipsRescheduledAfterTrackEdit;  // const
        public static AkMonitorErrorCode ErrorCode_CannotPlaySource_Create;  // const
        public static AkMonitorErrorCode ErrorCode_CannotPlaySource_VirtualOff;  // const
        public static AkMonitorErrorCode ErrorCode_CannotPlaySource_TimeSkip;  // const
        public static AkMonitorErrorCode ErrorCode_CannotPlaySource_InconsistentState;  // const
        public static AkMonitorErrorCode ErrorCode_MediaNotLoaded;  // const
        public static AkMonitorErrorCode ErrorCode_VoiceStarving;  // const
        public static AkMonitorErrorCode ErrorCode_StreamingSourceStarving;  // const
        public static AkMonitorErrorCode ErrorCode_XMADecoderSourceStarving;  // const
        public static AkMonitorErrorCode ErrorCode_XMADecodingError;  // const
        public static AkMonitorErrorCode ErrorCode_InvalidXMAData;  // const
        public static AkMonitorErrorCode ErrorCode_PluginNotRegistered;  // const
        public static AkMonitorErrorCode ErrorCode_CodecNotRegistered;  // const
        public static AkMonitorErrorCode ErrorCode_PluginVersionMismatch;  // const
        public static AkMonitorErrorCode ErrorCode_EventIDNotFound;  // const
        public static AkMonitorErrorCode ErrorCode_InvalidGroupID;  // const
        public static AkMonitorErrorCode ErrorCode_SelectedNodeNotAvailable;  // const
        public static AkMonitorErrorCode ErrorCode_SelectedMediaNotAvailable;  // const
        public static AkMonitorErrorCode ErrorCode_NoValidSwitch;  // const
        public static AkMonitorErrorCode ErrorCode_BankLoadFailed;  // const
        public static AkMonitorErrorCode ErrorCode_ErrorWhileLoadingBank;  // const
        public static AkMonitorErrorCode ErrorCode_InsufficientSpaceToLoadBank;  // const
        public static AkMonitorErrorCode ErrorCode_LowerEngineCommandListFull;  // const
        public static AkMonitorErrorCode ErrorCode_SeekNoMarker;  // const
        public static AkMonitorErrorCode ErrorCode_CannotSeekContinuous;  // const
        public static AkMonitorErrorCode ErrorCode_SeekAfterEof;  // const
        public static AkMonitorErrorCode ErrorCode_UnknownGameObject;  // const
        public static AkMonitorErrorCode ErrorCode_GameObjectNeverRegistered;  // const
        public static AkMonitorErrorCode ErrorCode_DeadGameObject;  // const
        public static AkMonitorErrorCode ErrorCode_GameObjectIsNotEmitter;  // const
        public static AkMonitorErrorCode ErrorCode_ExternalSourceNotResolved;  // const
        public static AkMonitorErrorCode ErrorCode_FileFormatMismatch;  // const
        public static AkMonitorErrorCode ErrorCode_CommandQueueFull;  // const
        public static AkMonitorErrorCode ErrorCode_CommandTooLarge;  // const
        public static AkMonitorErrorCode ErrorCode_XMACreateDecoderLimitReached;  // const
        public static AkMonitorErrorCode ErrorCode_XMAStreamBufferTooSmall;  // const
        public static AkMonitorErrorCode ErrorCode_ModulatorScopeError_Inst;  // const
        public static AkMonitorErrorCode ErrorCode_ModulatorScopeError_Obj;  // const
        public static AkMonitorErrorCode ErrorCode_SeekAfterEndOfPlaylist;  // const
        public static AkMonitorErrorCode ErrorCode_OpusRequireSeekTable;  // const
        public static AkMonitorErrorCode ErrorCode_OpusDecodeError;  // const
        public static AkMonitorErrorCode ErrorCode_SourcePluginNotFound;  // const
        public static AkMonitorErrorCode ErrorCode_VirtualVoiceLimit;  // const
        public static AkMonitorErrorCode ErrorCode_NotEnoughMemoryToStart;  // const
        public static AkMonitorErrorCode ErrorCode_UnknownOpusError;  // const
        public static AkMonitorErrorCode ErrorCode_AudioDeviceInitFailure;  // const
        public static AkMonitorErrorCode ErrorCode_AudioDeviceRemoveFailure;  // const
        public static AkMonitorErrorCode ErrorCode_AudioDeviceNotFound;  // const
        public static AkMonitorErrorCode ErrorCode_AudioDeviceNotValid;  // const
        public static AkMonitorErrorCode ErrorCode_SpatialAudio_ListenerAutomationNotSupported;  // const
        public static AkMonitorErrorCode ErrorCode_MediaDuplicationLength;  // const
        public static AkMonitorErrorCode ErrorCode_HwVoicesSystemInitFailed;  // const
        public static AkMonitorErrorCode ErrorCode_HwVoicesDecodeBatchFailed;  // const
        public static AkMonitorErrorCode ErrorCode_HwVoiceLimitReached;  // const
        public static AkMonitorErrorCode ErrorCode_HwVoiceInitFailed;  // const
        public static AkMonitorErrorCode ErrorCode_OpusHWCommandFailed;  // const
        public static AkMonitorErrorCode ErrorCode_AddOutputListenerIdWithZeroListeners;  // const
        public static AkMonitorErrorCode ErrorCode_3DObjectLimitExceeded;  // const
        public static AkMonitorErrorCode ErrorCode_OpusHWFatalError;  // const
        public static AkMonitorErrorCode ErrorCode_OpusHWDecodeUnavailable;  // const
        public static AkMonitorErrorCode ErrorCode_OpusHWTimeout;  // const
        public static AkMonitorErrorCode ErrorCode_SystemAudioObjectsUnavailable;  // const
        public static AkMonitorErrorCode ErrorCode_AddOutputNoDistinctListener;  // const
        public static AkMonitorErrorCode ErrorCode_PluginCannotRunOnObjectConfig;  // const
        public static AkMonitorErrorCode ErrorCode_SpatialAudio_ReflectionBusError;  // const
        public static AkMonitorErrorCode ErrorCode_VorbisHWDecodeUnavailable;  // const
        public static AkMonitorErrorCode ErrorCode_ExternalSourceNoMemorySize;  // const
        public static AkMonitorErrorCode ErrorCode_MonitorQueueFull;  // const
        public static AkMonitorErrorCode ErrorCode_MonitorMsgTooLarge;  // const
        public static AkMonitorErrorCode ErrorCode_NonCompliantDeviceMemory;  // const
        public static AkMonitorErrorCode ErrorCode_JobWorkerFuncCallMismatch;  // const
        public static AkMonitorErrorCode ErrorCode_JobMgrOutOfMemory;  // const
        public static AkMonitorErrorCode ErrorCode_InvalidFileSize;  // const
        public static AkMonitorErrorCode ErrorCode_PluginMsg;  // const
        public static AkMonitorErrorCode ErrorCode_SinkOpenSL;  // const
        public static AkMonitorErrorCode ErrorCode_AudioOutOfRange;  // const
        public static AkMonitorErrorCode ErrorCode_AudioOutOfRangeOnBus;  // const
        public static AkMonitorErrorCode ErrorCode_AudioOutOfRangeOnBusFx;  // const
        public static AkMonitorErrorCode ErrorCode_AudioOutOfRangeRay;  // const
        public static AkMonitorErrorCode ErrorCode_UnknownDialogueEvent;  // const
        public static AkMonitorErrorCode ErrorCode_FailedPostingEvent;  // const
        public static AkMonitorErrorCode ErrorCode_OutputDeviceInitializationFailed;  // const
        public static AkMonitorErrorCode ErrorCode_UnloadBankFailed;  // const
        public static AkMonitorErrorCode ErrorCode_PluginFileNotFound;  // const
        public static AkMonitorErrorCode ErrorCode_PluginFileIncompatible;  // const
        public static AkMonitorErrorCode ErrorCode_PluginFileNotEnoughMemoryToStart;  // const
        public static AkMonitorErrorCode ErrorCode_PluginFileInvalid;  // const
        public static AkMonitorErrorCode ErrorCode_PluginFileRegisterFailed;  // const
        public static AkMonitorErrorCode ErrorCode_UnknownArgument;  // const
        public static AkMonitorErrorCode ErrorCode_DynamicSequenceAlreadyClosed;  // const
        public static AkMonitorErrorCode ErrorCode_PendingActionDestroyed;  // const
        public static AkMonitorErrorCode ErrorCode_CrossFadeTransitionIgnored;  // const
        public static AkMonitorErrorCode ErrorCode_MusicRendererSeekingFailed;  // const
        public static AkMonitorErrorCode ErrorCode_DynamicSequenceIdNotFound;  // const
        public static AkMonitorErrorCode ErrorCode_BusNotFoundByName;  // const
        public static AkMonitorErrorCode ErrorCode_AudioDeviceShareSetNotFound;  // const
        public static AkMonitorErrorCode ErrorCode_AudioDeviceShareSetNotFoundByName;  // const
        public static AkMonitorErrorCode ErrorCode_SoundEngineTooManyGameObjects;  // const
        public static AkMonitorErrorCode ErrorCode_SoundEngineTooManyPositions;  // const
        public static AkMonitorErrorCode ErrorCode_SoundEngineCantCallOnChildBus;  // const
        public static AkMonitorErrorCode ErrorCode_SoundEnginePlayingIdNotFound;  // const
        public static AkMonitorErrorCode ErrorCode_SoundEngineInvalidTransform;  // const
        public static AkMonitorErrorCode ErrorCode_SoundEngineTooManyEventPosts;  // const
        public static AkMonitorErrorCode ErrorCode_AudioSubsystemStoppedResponding;  // const
        public static AkMonitorErrorCode ErrorCode_NotEnoughMemInFunction;  // const
        public static AkMonitorErrorCode ErrorCode_FXNotFound;  // const
        public static AkMonitorErrorCode ErrorCode_SetMixerNotABus;  // const
        public static AkMonitorErrorCode ErrorCode_AudioNodeNotFound;  // const
        public static AkMonitorErrorCode ErrorCode_SetMixerFailed;  // const
        public static AkMonitorErrorCode ErrorCode_SetBusConfigUnsupported;  // const
        public static AkMonitorErrorCode ErrorCode_BusNotFound;  // const
        public static AkMonitorErrorCode ErrorCode_MismatchingMediaSize;  // const
        public static AkMonitorErrorCode ErrorCode_IncompatibleBankVersion;  // const
        public static AkMonitorErrorCode ErrorCode_UnexpectedPrepareGameSyncsCall;  // const
        public static AkMonitorErrorCode ErrorCode_MusicEngineNotInitialized;  // const
        public static AkMonitorErrorCode ErrorCode_LoadingBankMismatch;  // const
        public static AkMonitorErrorCode ErrorCode_MasterBusStructureNotLoaded;  // const
        public static AkMonitorErrorCode ErrorCode_TooManyChildren;  // const
        public static AkMonitorErrorCode ErrorCode_BankContainUneditableEffect;  // const
        public static AkMonitorErrorCode ErrorCode_MemoryAllocationFailed;  // const
        public static AkMonitorErrorCode ErrorCode_InvalidFloatPriority;  // const
        public static AkMonitorErrorCode ErrorCode_SoundLoadFailedInsufficientMemory;  // const
        public static AkMonitorErrorCode ErrorCode_NXDeviceRegistrationFailed;  // const
        public static AkMonitorErrorCode ErrorCode_MixPluginOnObjectBus;  // const
        public static AkMonitorErrorCode ErrorCode_XboxXMAVoiceResetFailed;  // const
        public static AkMonitorErrorCode ErrorCode_XboxACPMessage;  // const
        public static AkMonitorErrorCode ErrorCode_XboxFrameDropped;  // const
        public static AkMonitorErrorCode ErrorCode_XboxACPError;  // const
        public static AkMonitorErrorCode ErrorCode_XboxXMAFatalError;  // const
        public static AkMonitorErrorCode ErrorCode_MissingMusicNodeParent;  // const
        public static AkMonitorErrorCode ErrorCode_HardwareOpusDecoderError;  // const
        public static AkMonitorErrorCode ErrorCode_SetGeometryTooManyTriangleConnected;  // const
        public static AkMonitorErrorCode ErrorCode_SetGeometryTriangleTooLarge;  // const
        public static AkMonitorErrorCode ErrorCode_SetGeometryFailed;  // const
        public static AkMonitorErrorCode ErrorCode_RemovingGeometrySetFailed;  // const
        public static AkMonitorErrorCode ErrorCode_SetGeometryInstanceFailed;  // const
        public static AkMonitorErrorCode ErrorCode_RemovingGeometryInstanceFailed;  // const
        public static AkMonitorErrorCode ErrorCode_RevertingToDefaultAudioDevice;  // const
        public static AkMonitorErrorCode ErrorCode_RevertingToDummyAudioDevice;  // const
        public static AkMonitorErrorCode ErrorCode_AudioThreadSuspended;  // const
        public static AkMonitorErrorCode ErrorCode_AudioThreadResumed;  // const
        public static AkMonitorErrorCode ErrorCode_ResetPlaylistActionIgnoredGlobalScope;  // const
        public static AkMonitorErrorCode ErrorCode_ResetPlaylistActionIgnoredContinuous;  // const
        public static AkMonitorErrorCode ErrorCode_PlayingTriggerRateNotSupported;  // const
        public static AkMonitorErrorCode ErrorCode_SetGeometryTriangleIsSkipped;  // const
        public static AkMonitorErrorCode ErrorCode_SetGeometryInstanceInvalidTransform;  // const
        public static AkMonitorErrorCode ErrorCode_SetGameObjectRadiusSizeError;  // const
        public static AkMonitorErrorCode ErrorCode_SetPortalNonDistinctRoom;  // const
        public static AkMonitorErrorCode ErrorCode_SetPortalInvalidExtent;  // const
        public static AkMonitorErrorCode ErrorCode_SpatialAudio_PortalNotFound;  // const
        public static AkMonitorErrorCode ErrorCode_InvalidFloatInFunction;  // const
        public static AkMonitorErrorCode ErrorCode_FLTMAXNotSupported;  // const
        public static AkMonitorErrorCode ErrorCode_CannotInitializeAmbisonicChannelConfiguration;  // const
        public static AkMonitorErrorCode ErrorCode_CannotInitializePassthrough;  // const
        public static AkMonitorErrorCode ErrorCode_3DAudioUnsupportedSize;  // const
        public static AkMonitorErrorCode ErrorCode_AmbisonicNotAvailable;  // const
        public static AkMonitorErrorCode ErrorCode_NoAudioDevice;  // const
        public static AkMonitorErrorCode ErrorCode_Support;  // const
        public static AkMonitorErrorCode ErrorCode_ReplayMessage;  // const
        public static AkMonitorErrorCode ErrorCode_GameMessage;  // const
        public static AkMonitorErrorCode ErrorCode_TestMessage;  // const
        public static AkMonitorErrorCode ErrorCode_TranslatorStandardTagTest;  // const
        public static AkMonitorErrorCode ErrorCode_TranslatorWwiseTagTest;  // const
        public static AkMonitorErrorCode ErrorCode_TranslatorStringSizeTest;  // const
        public static AkMonitorErrorCode ErrorCode_InvalidParameter;  // const
        public static AkMonitorErrorCode ErrorCode_MaxAudioObjExceeded;  // const
        public static AkMonitorErrorCode ErrorCode_MMSNotEnabled;  // const
        public static AkMonitorErrorCode ErrorCode_NotEnoughSystemObj;  // const
        public static AkMonitorErrorCode ErrorCode_NotEnoughSystemObjWin;  // const
        public static AkMonitorErrorCode ErrorCode_TransitionNotAccurateSourceTooShort;  // const
        public static AkMonitorErrorCode ErrorCode_AlreadyInitialized;  // const
        public static AkMonitorErrorCode ErrorCode_WrongNumberOfArguments;  // const
        public static AkMonitorErrorCode ErrorCode_DataAlignement;  // const
        public static AkMonitorErrorCode ErrorCode_PluginMsgWithShareSet;  // const
        public static AkMonitorErrorCode ErrorCode_SoundEngineNotInit;  // const
        public static AkMonitorErrorCode ErrorCode_NoDefaultSwitch;  // const
        public static AkMonitorErrorCode ErrorCode_CantSetBoundSwitch;  // const
        public static AkMonitorErrorCode ErrorCode_IODeviceInitFailed;  // const
        public static AkMonitorErrorCode ErrorCode_SwitchListEmpty;  // const
        public static AkMonitorErrorCode ErrorCode_NoSwitchSelected;  // const
        public static AkMonitorErrorCode ErrorCode_FilePermissionError;  // const
        public static AkMonitorErrorCode ErrorCode_SetEffectOnRendered;  // const
        public static AkMonitorErrorCode ErrorCode_GeometryNotWatertight;  // const
        public static AkMonitorErrorCode ErrorCode_CannotInitialize3DAudio;  // const
        public static AkMonitorErrorCode ErrorCode_CannotInitializeInputCallbacks;  // const
        public static AkMonitorErrorCode ErrorCode_CannotConnectAVAudioEngineSource;  // const
        public static AkMonitorErrorCode ErrorCode_ChannelConfigRequestDenied;  // const
        public static AkMonitorErrorCode ErrorCode_MediaUpdatedFromWwise;  // const
        public static AkMonitorErrorCode ErrorCode_MediaErrorFromWwise;  // const
        public static AkMonitorErrorCode ErrorCode_OutputAlreadyExists;  // const
        public static AkMonitorErrorCode ErrorCode_UnknownStateGroup;  // const
        public static AkMonitorErrorCode ErrorCode_MediaErrorWwiseMRUFull;  // const
        public static AkMonitorErrorCode ErrorCode_AudioOut2ContextCreateError;  // const
        public static AkMonitorErrorCode ErrorCode_AudioOut2UserCreateError;  // const
        public static AkMonitorErrorCode ErrorCode_FeedbackOnAudioObjectsBus;  // const
        public static AkMonitorErrorCode ErrorCode_AssetSwapEnabled;  // const
        public static AkMonitorErrorCode ErrorCode_SpatialAudio_SiblingPortal;  // const
        public static AkMonitorErrorCode Num_ErrorCodes;  // const

    }

    // TypeToken: 0x2000043  // size: 0x14
    public sealed struct AkMonitorErrorLevel
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkMonitorErrorLevel ErrorLevel_Message;  // const
        public static AkMonitorErrorLevel ErrorLevel_Error;  // const
        public static AkMonitorErrorLevel ErrorLevel_All;  // const

    }

    // TypeToken: 0x2000044  // size: 0x20
    public class AkMonitoringCallbackInfo : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        AkMonitorErrorCode errorCode { get; /* RVA: 0x042863C8 */ }
        AkMonitorErrorLevel errorLevel { get; /* RVA: 0x04286418 */ }
        System.UInt32 playingID { get; /* RVA: 0x04286524 */ }
        System.UInt64 gameObjID { get; /* RVA: 0x04286468 */ }
        System.String message { get; /* RVA: 0x042864B8 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60002B0
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60002B1
        private static System.IntPtr getCPtr(AkMonitoringCallbackInfo obj) { }
        // RVA: 0x04286574  token: 0x60002B2
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x04286304  token: 0x60002B3
        protected virtual System.Void Finalize() { }
        // RVA: 0x042862B4  token: 0x60002B4
        public virtual System.Void Dispose() { }
        // RVA: 0x042861A0  token: 0x60002B5
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x04286378  token: 0x60002BB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000045  // size: 0x14
    public sealed struct AkMultiPositionType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkMultiPositionType MultiPositionType_SingleSource;  // const
        public static AkMultiPositionType MultiPositionType_MultiSources;  // const
        public static AkMultiPositionType MultiPositionType_MultiDirections;  // const

    }

    // TypeToken: 0x2000046  // size: 0x30
    public class AkMusicPlaylistCallbackInfo : AkEventCallbackInfo
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x28

        // Properties
        System.UInt32 playlistID { get; /* RVA: 0x0428671C */ }
        System.UInt32 uNumPlaylistItems { get; /* RVA: 0x0428676C */ }
        System.UInt32 uPlaylistSelection { get; /* RVA: 0x0428680C */ }
        System.UInt32 uPlaylistItemDone { get; /* RVA: 0x042867BC */ }

        // Methods
        // RVA: 0x031D85B0  token: 0x60002BC
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x04280164  token: 0x60002BD
        private static System.IntPtr getCPtr(AkMusicPlaylistCallbackInfo obj) { }
        // RVA: 0x0428685C  token: 0x60002BE
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0428659C  token: 0x60002BF
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042866CC  token: 0x60002C4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000047  // size: 0x20
    public class AkMusicSettings : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Single fStreamingLookAheadRatio { get; /* RVA: 0x0428690C */ set; /* RVA: 0x02A04340 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60002C5
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60002C6
        private static System.IntPtr getCPtr(AkMusicSettings obj) { }
        // RVA: 0x0428695C  token: 0x60002C7
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x03A50EB0  token: 0x60002C8
        protected virtual System.Void Finalize() { }
        // RVA: 0x042868BC  token: 0x60002C9
        public virtual System.Void Dispose() { }
        // RVA: 0x03A50F00  token: 0x60002CA
        protected virtual System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x2000048  // size: 0x28
    public class AkMusicSyncCallbackInfo : AkCallbackInfo
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x20

        // Properties
        System.UInt32 playingID { get; /* RVA: 0x04286B54 */ }
        System.Int32 segmentInfo_iCurrentPosition { get; /* RVA: 0x04286D34 */ }
        System.Int32 segmentInfo_iPreEntryDuration { get; /* RVA: 0x04286DD4 */ }
        System.Int32 segmentInfo_iActiveDuration { get; /* RVA: 0x04286CE4 */ }
        System.Int32 segmentInfo_iPostExitDuration { get; /* RVA: 0x04286D84 */ }
        System.Int32 segmentInfo_iRemainingLookAheadTime { get; /* RVA: 0x04286E24 */ }
        System.Single segmentInfo_fBeatDuration { get; /* RVA: 0x04286BF4 */ }
        System.Single segmentInfo_fBarDuration { get; /* RVA: 0x04286BA4 */ }
        System.Single segmentInfo_fGridDuration { get; /* RVA: 0x04286C44 */ }
        System.Single segmentInfo_fGridOffset { get; /* RVA: 0x04286C94 */ }
        AkCallbackType musicSyncType { get; /* RVA: 0x04286B04 */ }
        System.String userCueName { get; /* RVA: 0x04286E74 */ }

        // Methods
        // RVA: 0x031D8450  token: 0x60002CD
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x042804E4  token: 0x60002CE
        private static System.IntPtr getCPtr(AkMusicSyncCallbackInfo obj) { }
        // RVA: 0x04286EE0  token: 0x60002CF
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x04286984  token: 0x60002D0
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x04286AB4  token: 0x60002DD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000049  // size: 0x20
    public class AkObjectInfo : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt32 objID { get; /* RVA: 0x042872B0 */ set; /* RVA: 0x042873CC */ }
        System.UInt32 parentID { get; /* RVA: 0x04287300 */ set; /* RVA: 0x04287420 */ }
        System.Int32 iDepth { get; /* RVA: 0x04287260 */ set; /* RVA: 0x04287378 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60002DE
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60002DF
        private static System.IntPtr getCPtr(AkObjectInfo obj) { }
        // RVA: 0x04287350  token: 0x60002E0
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0428715C  token: 0x60002E1
        protected virtual System.Void Finalize() { }
        // RVA: 0x0428710C  token: 0x60002E2
        public virtual System.Void Dispose() { }
        // RVA: 0x04286FF8  token: 0x60002E3
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x04286F40  token: 0x60002EA
        public System.Void Clear() { }
        // RVA: 0x042871D0  token: 0x60002EB
        public static System.Int32 GetSizeOf() { }
        // RVA: 0x04286F90  token: 0x60002EC
        public System.Void Clone(AkObjectInfo other) { }
        // RVA: 0x04287210  token: 0x60002ED
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004A  // size: 0x20
    public class AkObstructionOcclusionValues : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Single occlusion { get; /* RVA: 0x042877E4 */ set; /* RVA: 0x042878B4 */ }
        System.Single obstruction { get; /* RVA: 0x04287794 */ set; /* RVA: 0x0428785C */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60002EE
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60002EF
        private static System.IntPtr getCPtr(AkObstructionOcclusionValues obj) { }
        // RVA: 0x04287834  token: 0x60002F0
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x04287690  token: 0x60002F1
        protected virtual System.Void Finalize() { }
        // RVA: 0x04287640  token: 0x60002F2
        public virtual System.Void Dispose() { }
        // RVA: 0x0428752C  token: 0x60002F3
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x04287474  token: 0x60002F8
        public System.Void Clear() { }
        // RVA: 0x04287704  token: 0x60002F9
        public static System.Int32 GetSizeOf() { }
        // RVA: 0x042874C4  token: 0x60002FA
        public System.Void Clone(AkObstructionOcclusionValues other) { }
        // RVA: 0x04287744  token: 0x60002FB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004B  // size: 0x20
    public class AkOutputSettings : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt32 audioDeviceShareset { get; /* RVA: 0x04287B80 */ set; /* RVA: 0x02A4F5B0 */ }
        System.UInt32 idDevice { get; /* RVA: 0x04287C20 */ set; /* RVA: 0x02A4F510 */ }
        AkPanningRule ePanningRule { get; /* RVA: 0x04287BD0 */ set; /* RVA: 0x02A4F470 */ }
        AkChannelConfig channelConfig { get; /* RVA: 0x02A4F2C0 */ set; /* RVA: 0x04287C98 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60002FC
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60002FD
        private static System.IntPtr getCPtr(AkOutputSettings obj) { }
        // RVA: 0x04287C70  token: 0x60002FE
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x03A50BD0  token: 0x60002FF
        protected virtual System.Void Finalize() { }
        // RVA: 0x0428790C  token: 0x6000300
        public virtual System.Void Dispose() { }
        // RVA: 0x03A50C20  token: 0x6000301
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x04287B30  token: 0x6000302
        public System.Void .ctor() { }
        // RVA: 0x04287AA8  token: 0x6000303
        public System.Void .ctor(System.String in_szDeviceShareSet, System.UInt32 in_idDevice, AkChannelConfig in_channelConfig, AkPanningRule in_ePanning) { }
        // RVA: 0x042879B4  token: 0x6000304
        public System.Void .ctor(System.String in_szDeviceShareSet, System.UInt32 in_idDevice, AkChannelConfig in_channelConfig) { }
        // RVA: 0x04287A40  token: 0x6000305
        public System.Void .ctor(System.String in_szDeviceShareSet, System.UInt32 in_idDevice) { }
        // RVA: 0x0428795C  token: 0x6000306
        public System.Void .ctor(System.String in_szDeviceShareSet) { }

    }

    // TypeToken: 0x200004C  // size: 0x14
    public sealed struct AkPanningRule
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkPanningRule AkPanningRule_Speakers;  // const
        public static AkPanningRule AkPanningRule_Headphones;  // const

    }

    // TypeToken: 0x200004D  // size: 0x28
    public class AkPlaylist : AkPlaylistArray
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x20

        // Methods
        // RVA: 0x04289C04  token: 0x600030F
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x042804E4  token: 0x6000310
        private static System.IntPtr getCPtr(AkPlaylist obj) { }
        // RVA: 0x04289C6C  token: 0x6000311
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x04289824  token: 0x6000312
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x04289A8C  token: 0x6000313
        public AKRESULT Enqueue(System.UInt32 in_audioNodeID, System.Int32 in_msDelay, System.IntPtr in_pCustomInfo, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources) { }
        // RVA: 0x042899B8  token: 0x6000314
        public AKRESULT Enqueue(System.UInt32 in_audioNodeID, System.Int32 in_msDelay, System.IntPtr in_pCustomInfo, System.UInt32 in_cExternals) { }
        // RVA: 0x04289B3C  token: 0x6000315
        public AKRESULT Enqueue(System.UInt32 in_audioNodeID, System.Int32 in_msDelay, System.IntPtr in_pCustomInfo) { }
        // RVA: 0x04289954  token: 0x6000316
        public AKRESULT Enqueue(System.UInt32 in_audioNodeID, System.Int32 in_msDelay) { }
        // RVA: 0x04289A38  token: 0x6000317
        public AKRESULT Enqueue(System.UInt32 in_audioNodeID) { }
        // RVA: 0x04289BB4  token: 0x6000318
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004E  // size: 0x20
    public class AkPlaylistArray : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Methods
        // RVA: 0x03D4E290  token: 0x6000319
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x600031A
        private static System.IntPtr getCPtr(AkPlaylistArray obj) { }
        // RVA: 0x042891DC  token: 0x600031B
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427D550  token: 0x600031C
        protected virtual System.Void Finalize() { }
        // RVA: 0x042886C0  token: 0x600031D
        public virtual System.Void Dispose() { }
        // RVA: 0x042885AC  token: 0x600031E
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0428918C  token: 0x600031F
        public System.Void .ctor() { }
        // RVA: 0x04288454  token: 0x6000320
        public AkIterator Begin() { }
        // RVA: 0x04288710  token: 0x6000321
        public AkIterator End() { }
        // RVA: 0x042889E4  token: 0x6000322
        public AkIterator FindEx(AkPlaylistItem in_Item) { }
        // RVA: 0x04288868  token: 0x6000323
        public AkIterator Erase(AkIterator in_rIter) { }
        // RVA: 0x042888F8  token: 0x6000324
        public System.Void Erase(System.UInt32 in_uIndex) { }
        // RVA: 0x04288784  token: 0x6000325
        public AkIterator EraseSwap(AkIterator in_rIter) { }
        // RVA: 0x04288814  token: 0x6000326
        public System.Void EraseSwap(System.UInt32 in_uIndex) { }
        // RVA: 0x04288C80  token: 0x6000327
        public System.Boolean IsGrowingAllowed() { }
        // RVA: 0x04288FDC  token: 0x6000328
        public AKRESULT Reserve(System.UInt32 in_ulReserve) { }
        // RVA: 0x04288F88  token: 0x6000329
        public AKRESULT ReserveExtra(System.UInt32 in_ulReserve) { }
        // RVA: 0x04289030  token: 0x600032A
        public System.UInt32 Reserved() { }
        // RVA: 0x042890D4  token: 0x600032B
        public System.Void Term() { }
        // RVA: 0x04288DC8  token: 0x600032C
        public System.UInt32 Length() { }
        // RVA: 0x04288530  token: 0x600032D
        public AkPlaylistItem Data() { }
        // RVA: 0x04288C30  token: 0x600032E
        public System.Boolean IsEmpty() { }
        // RVA: 0x0428894C  token: 0x600032F
        public AkPlaylistItem Exists(AkPlaylistItem in_Item) { }
        // RVA: 0x04288340  token: 0x6000330
        public AkPlaylistItem AddLast() { }
        // RVA: 0x042883BC  token: 0x6000331
        public AkPlaylistItem AddLast(AkPlaylistItem in_rItem) { }
        // RVA: 0x04288D54  token: 0x6000332
        public AkPlaylistItem Last() { }
        // RVA: 0x04288E68  token: 0x6000333
        public System.Void RemoveLast() { }
        // RVA: 0x04288F20  token: 0x6000334
        public AKRESULT Remove(AkPlaylistItem in_rItem) { }
        // RVA: 0x04288EB8  token: 0x6000335
        public AKRESULT RemoveSwap(AkPlaylistItem in_rItem) { }
        // RVA: 0x04288E18  token: 0x6000336
        public System.Void RemoveAll() { }
        // RVA: 0x04288CD0  token: 0x6000337
        public AkPlaylistItem ItemAtIndex(System.UInt32 uiIndex) { }
        // RVA: 0x04288BA0  token: 0x6000338
        public AkIterator Insert(AkIterator in_rIter) { }
        // RVA: 0x04288B18  token: 0x6000339
        public AkPlaylistItem Insert(System.UInt32 in_uIndex) { }
        // RVA: 0x04288A74  token: 0x600033A
        public System.Boolean GrowArray() { }
        // RVA: 0x04288AC4  token: 0x600033B
        public System.Boolean GrowArray(System.UInt32 in_uGrowBy) { }
        // RVA: 0x04289080  token: 0x600033C
        public System.Boolean Resize(System.UInt32 in_uiSize) { }
        // RVA: 0x04289124  token: 0x600033D
        public System.Void Transfer(AkPlaylistArray in_rSource) { }
        // RVA: 0x042884C8  token: 0x600033E
        public AKRESULT Copy(AkPlaylistArray in_rSource) { }

    }

    // TypeToken: 0x200004F  // size: 0x20
    public class AkPlaylistItem : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt32 audioNodeID { get; /* RVA: 0x04289610 */ set; /* RVA: 0x04289728 */ }
        System.Int32 msDelay { get; /* RVA: 0x04289660 */ set; /* RVA: 0x0428977C */ }
        System.IntPtr pCustomInfo { get; /* RVA: 0x042896B0 */ set; /* RVA: 0x042897D0 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x600033F
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000340
        private static System.IntPtr getCPtr(AkPlaylistItem obj) { }
        // RVA: 0x04289700  token: 0x6000341
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042893F8  token: 0x6000342
        protected virtual System.Void Finalize() { }
        // RVA: 0x042893A8  token: 0x6000343
        public virtual System.Void Dispose() { }
        // RVA: 0x04289294  token: 0x6000344
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x04289554  token: 0x6000345
        public System.Void .ctor() { }
        // RVA: 0x042895A4  token: 0x6000346
        public System.Void .ctor(AkPlaylistItem in_rCopy) { }
        // RVA: 0x04289204  token: 0x6000347
        public AkPlaylistItem Assign(AkPlaylistItem in_rCopy) { }
        // RVA: 0x0428946C  token: 0x6000348
        public System.Boolean IsEqualTo(AkPlaylistItem in_rCopy) { }
        // RVA: 0x042894D4  token: 0x6000349
        public AKRESULT SetExternalSources(System.UInt32 in_nExternalSrc, AkExternalSourceInfoArray in_pExternalSrc) { }

    }

    // TypeToken: 0x2000050  // size: 0x14
    public sealed struct AkPluginType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkPluginType AkPluginTypeNone;  // const
        public static AkPluginType AkPluginTypeCodec;  // const
        public static AkPluginType AkPluginTypeSource;  // const
        public static AkPluginType AkPluginTypeEffect;  // const
        public static AkPluginType AkPluginTypeMixer;  // const
        public static AkPluginType AkPluginTypeSink;  // const
        public static AkPluginType AkPluginTypeGlobalExtension;  // const
        public static AkPluginType AkPluginTypeMetadata;  // const
        public static AkPluginType AkPluginTypeMask;  // const

    }

    // TypeToken: 0x2000051  // size: 0x20
    public class AkPositioningData : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        Ak3dData threeD { get; /* RVA: 0x04289F70 */ set; /* RVA: 0x0428A07C */ }
        AkBehavioralPositioningData behavioral { get; /* RVA: 0x04289EF4 */ set; /* RVA: 0x0428A014 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000350
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000351
        private static System.IntPtr getCPtr(AkPositioningData obj) { }
        // RVA: 0x04289FEC  token: 0x6000352
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x04289E30  token: 0x6000353
        protected virtual System.Void Finalize() { }
        // RVA: 0x04289CCC  token: 0x6000354
        public virtual System.Void Dispose() { }
        // RVA: 0x04289D1C  token: 0x6000355
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x04289EA4  token: 0x600035A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000052  // size: 0x20
    public class AkPositioningInfo : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Single fCenterPct { get; /* RVA: 0x0428A5DC */ set; /* RVA: 0x0428ABD8 */ }
        AkSpeakerPanningType pannerType { get; /* RVA: 0x0428A85C */ set; /* RVA: 0x0428AE98 */ }
        Ak3DPositionType e3dPositioningType { get; /* RVA: 0x0428A58C */ set; /* RVA: 0x0428AB84 */ }
        System.Boolean bHoldEmitterPosAndOrient { get; /* RVA: 0x0428A49C */ set; /* RVA: 0x0428AA88 */ }
        Ak3DSpatializationMode e3DSpatializationMode { get; /* RVA: 0x0428A53C */ set; /* RVA: 0x0428AB30 */ }
        System.Boolean bEnableAttenuation { get; /* RVA: 0x0428A44C */ set; /* RVA: 0x0428AA34 */ }
        System.Boolean bUseConeAttenuation { get; /* RVA: 0x0428A4EC */ set; /* RVA: 0x0428AADC */ }
        System.Single fInnerAngle { get; /* RVA: 0x0428A67C */ set; /* RVA: 0x0428AC88 */ }
        System.Single fOuterAngle { get; /* RVA: 0x0428A71C */ set; /* RVA: 0x0428AD38 */ }
        System.Single fConeMaxAttenuation { get; /* RVA: 0x0428A62C */ set; /* RVA: 0x0428AC30 */ }
        System.Single LPFCone { get; /* RVA: 0x0428A3AC */ set; /* RVA: 0x0428A984 */ }
        System.Single HPFCone { get; /* RVA: 0x0428A30C */ set; /* RVA: 0x0428A8D4 */ }
        System.Single fMaxDistance { get; /* RVA: 0x0428A6CC */ set; /* RVA: 0x0428ACE0 */ }
        System.Single fVolDryAtMaxDist { get; /* RVA: 0x0428A80C */ set; /* RVA: 0x0428AE40 */ }
        System.Single fVolAuxGameDefAtMaxDist { get; /* RVA: 0x0428A76C */ set; /* RVA: 0x0428AD90 */ }
        System.Single fVolAuxUserDefAtMaxDist { get; /* RVA: 0x0428A7BC */ set; /* RVA: 0x0428ADE8 */ }
        System.Single LPFValueAtMaxDist { get; /* RVA: 0x0428A3FC */ set; /* RVA: 0x0428A9DC */ }
        System.Single HPFValueAtMaxDist { get; /* RVA: 0x0428A35C */ set; /* RVA: 0x0428A92C */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x600035B
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x600035C
        private static System.IntPtr getCPtr(AkPositioningInfo obj) { }
        // RVA: 0x0428A8AC  token: 0x600035D
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0428A248  token: 0x600035E
        protected virtual System.Void Finalize() { }
        // RVA: 0x0428A0E4  token: 0x600035F
        public virtual System.Void Dispose() { }
        // RVA: 0x0428A134  token: 0x6000360
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0428A2BC  token: 0x6000385
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000053  // size: 0x14
    public sealed struct AkPreparationType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkPreparationType Preparation_Load;  // const
        public static AkPreparationType Preparation_Unload;  // const
        public static AkPreparationType Preparation_LoadAndDecode;  // const

    }

    // TypeToken: 0x2000054  // size: 0x14
    public sealed struct AkQueryRTPCValue
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkQueryRTPCValue RTPCValue_Default;  // const
        public static AkQueryRTPCValue RTPCValue_Global;  // const
        public static AkQueryRTPCValue RTPCValue_GameObject;  // const
        public static AkQueryRTPCValue RTPCValue_PlayingID;  // const
        public static AkQueryRTPCValue RTPCValue_Unavailable;  // const

    }

    // TypeToken: 0x2000055  // size: 0x20
    public class AkRamp : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Single fPrev { get; /* RVA: 0x0428B1CC */ set; /* RVA: 0x0428B29C */ }
        System.Single fNext { get; /* RVA: 0x0428B17C */ set; /* RVA: 0x0428B244 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000386
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000387
        private static System.IntPtr getCPtr(AkRamp obj) { }
        // RVA: 0x0428B21C  token: 0x6000388
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0428B050  token: 0x6000389
        protected virtual System.Void Finalize() { }
        // RVA: 0x0428B000  token: 0x600038A
        public virtual System.Void Dispose() { }
        // RVA: 0x0428AEEC  token: 0x600038B
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0428B12C  token: 0x600038C
        public System.Void .ctor() { }
        // RVA: 0x0428B0C4  token: 0x600038D
        public System.Void .ctor(System.Single in_fPrev, System.Single in_fNext) { }

    }

    // TypeToken: 0x2000056  // size: 0x20
    public class AkReflectionPathInfo : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        AkVector64 imageSource { get; /* RVA: 0x0428B714 */ set; /* RVA: 0x0428B8E8 */ }
        System.UInt32 numPathPoints { get; /* RVA: 0x0428B820 */ set; /* RVA: 0x0428BA00 */ }
        System.UInt32 numReflections { get; /* RVA: 0x0428B870 */ set; /* RVA: 0x0428BA54 */ }
        System.Single level { get; /* RVA: 0x0428B7D0 */ set; /* RVA: 0x0428B9A8 */ }
        System.Boolean isOccluded { get; /* RVA: 0x0428B780 */ set; /* RVA: 0x0428B954 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000392
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000393
        private static System.IntPtr getCPtr(AkReflectionPathInfo obj) { }
        // RVA: 0x0428B8C0  token: 0x6000394
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0428B4C0  token: 0x6000395
        protected virtual System.Void Finalize() { }
        // RVA: 0x0428B35C  token: 0x6000396
        public virtual System.Void Dispose() { }
        // RVA: 0x0428B3AC  token: 0x6000397
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0428B684  token: 0x60003A2
        public static System.Int32 GetSizeOf() { }
        // RVA: 0x0428B60C  token: 0x60003A3
        public UnityEngine.Vector3 GetPathPoint(System.UInt32 idx) { }
        // RVA: 0x0428B534  token: 0x60003A4
        public AkAcousticSurface GetAcousticSurface(System.UInt32 idx) { }
        // RVA: 0x0428B5B8  token: 0x60003A5
        public System.Single GetDiffraction(System.UInt32 idx) { }
        // RVA: 0x0428B2F4  token: 0x60003A6
        public System.Void Clone(AkReflectionPathInfo other) { }
        // RVA: 0x0428B6C4  token: 0x60003A7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000057  // size: 0x20
    public class AkResourceMonitorDataSummary : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Single totalCPU { get; /* RVA: 0x0428BDC0 */ set; /* RVA: 0x0428BFD8 */ }
        System.Single pluginCPU { get; /* RVA: 0x0428BD70 */ set; /* RVA: 0x0428BF80 */ }
        System.UInt32 physicalVoices { get; /* RVA: 0x0428BD20 */ set; /* RVA: 0x0428BF2C */ }
        System.UInt32 virtualVoices { get; /* RVA: 0x0428BE60 */ set; /* RVA: 0x0428C084 */ }
        System.UInt32 totalVoices { get; /* RVA: 0x0428BE10 */ set; /* RVA: 0x0428C030 */ }
        System.UInt32 nbActiveEvents { get; /* RVA: 0x0428BCD0 */ set; /* RVA: 0x0428BED8 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60003A8
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60003A9
        private static System.IntPtr getCPtr(AkResourceMonitorDataSummary obj) { }
        // RVA: 0x0428BEB0  token: 0x60003AA
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0428BC0C  token: 0x60003AB
        protected virtual System.Void Finalize() { }
        // RVA: 0x0428BAA8  token: 0x60003AC
        public virtual System.Void Dispose() { }
        // RVA: 0x0428BAF8  token: 0x60003AD
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0428BC80  token: 0x60003BA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000058  // size: 0x14
    public sealed struct AKRESULT
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AKRESULT AK_NotImplemented;  // const
        public static AKRESULT AK_Success;  // const
        public static AKRESULT AK_Fail;  // const
        public static AKRESULT AK_PartialSuccess;  // const
        public static AKRESULT AK_NotCompatible;  // const
        public static AKRESULT AK_AlreadyConnected;  // const
        public static AKRESULT AK_InvalidFile;  // const
        public static AKRESULT AK_AudioFileHeaderTooLarge;  // const
        public static AKRESULT AK_MaxReached;  // const
        public static AKRESULT AK_InvalidID;  // const
        public static AKRESULT AK_IDNotFound;  // const
        public static AKRESULT AK_InvalidInstanceID;  // const
        public static AKRESULT AK_NoMoreData;  // const
        public static AKRESULT AK_InvalidStateGroup;  // const
        public static AKRESULT AK_ChildAlreadyHasAParent;  // const
        public static AKRESULT AK_InvalidLanguage;  // const
        public static AKRESULT AK_CannotAddItselfAsAChild;  // const
        public static AKRESULT AK_InvalidParameter;  // const
        public static AKRESULT AK_ElementAlreadyInList;  // const
        public static AKRESULT AK_PathNotFound;  // const
        public static AKRESULT AK_PathNoVertices;  // const
        public static AKRESULT AK_PathNotRunning;  // const
        public static AKRESULT AK_PathNotPaused;  // const
        public static AKRESULT AK_PathNodeAlreadyInList;  // const
        public static AKRESULT AK_PathNodeNotInList;  // const
        public static AKRESULT AK_DataNeeded;  // const
        public static AKRESULT AK_NoDataNeeded;  // const
        public static AKRESULT AK_DataReady;  // const
        public static AKRESULT AK_NoDataReady;  // const
        public static AKRESULT AK_InsufficientMemory;  // const
        public static AKRESULT AK_Cancelled;  // const
        public static AKRESULT AK_UnknownBankID;  // const
        public static AKRESULT AK_BankReadError;  // const
        public static AKRESULT AK_InvalidSwitchType;  // const
        public static AKRESULT AK_FormatNotReady;  // const
        public static AKRESULT AK_WrongBankVersion;  // const
        public static AKRESULT AK_FileNotFound;  // const
        public static AKRESULT AK_DeviceNotReady;  // const
        public static AKRESULT AK_BankAlreadyLoaded;  // const
        public static AKRESULT AK_RenderedFX;  // const
        public static AKRESULT AK_ProcessNeeded;  // const
        public static AKRESULT AK_ProcessDone;  // const
        public static AKRESULT AK_MemManagerNotInitialized;  // const
        public static AKRESULT AK_StreamMgrNotInitialized;  // const
        public static AKRESULT AK_SSEInstructionsNotSupported;  // const
        public static AKRESULT AK_Busy;  // const
        public static AKRESULT AK_UnsupportedChannelConfig;  // const
        public static AKRESULT AK_PluginMediaNotAvailable;  // const
        public static AKRESULT AK_MustBeVirtualized;  // const
        public static AKRESULT AK_CommandTooLarge;  // const
        public static AKRESULT AK_RejectedByFilter;  // const
        public static AKRESULT AK_InvalidCustomPlatformName;  // const
        public static AKRESULT AK_DLLCannotLoad;  // const
        public static AKRESULT AK_DLLPathNotFound;  // const
        public static AKRESULT AK_NoJavaVM;  // const
        public static AKRESULT AK_OpenSLError;  // const
        public static AKRESULT AK_PluginNotRegistered;  // const
        public static AKRESULT AK_DataAlignmentError;  // const
        public static AKRESULT AK_DeviceNotCompatible;  // const
        public static AKRESULT AK_DuplicateUniqueID;  // const
        public static AKRESULT AK_InitBankNotLoaded;  // const
        public static AKRESULT AK_DeviceNotFound;  // const
        public static AKRESULT AK_PlayingIDNotFound;  // const
        public static AKRESULT AK_InvalidFloatValue;  // const
        public static AKRESULT AK_FileFormatMismatch;  // const
        public static AKRESULT AK_NoDistinctListener;  // const
        public static AKRESULT AK_ACP_Error;  // const
        public static AKRESULT AK_ResourceInUse;  // const
        public static AKRESULT AK_InvalidBankType;  // const
        public static AKRESULT AK_AlreadyInitialized;  // const
        public static AKRESULT AK_NotInitialized;  // const
        public static AKRESULT AK_FilePermissionError;  // const
        public static AKRESULT AK_UnknownFileError;  // const
        public static AKRESULT AK_TooManyConcurrentOperations;  // const
        public static AKRESULT AK_InvalidFileSize;  // const
        public static AKRESULT AK_Deferred;  // const
        public static AKRESULT AK_FilePathTooLong;  // const
        public static AKRESULT AK_InvalidState;  // const

    }

    // TypeToken: 0x2000059  // size: 0x20
    public class AkRoomParams : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        UnityEngine.Vector3 Front { get; /* RVA: 0x0428C2B0 */ set; /* RVA: 0x031AD520 */ }
        UnityEngine.Vector3 Up { get; /* RVA: 0x0428C4F8 */ set; /* RVA: 0x031AD440 */ }
        System.UInt32 ReverbAuxBus { get; /* RVA: 0x0428C318 */ set; /* RVA: 0x031AD0A0 */ }
        System.Single ReverbLevel { get; /* RVA: 0x0428C368 */ set; /* RVA: 0x031AD380 */ }
        System.Single TransmissionLoss { get; /* RVA: 0x0428C4A8 */ set; /* RVA: 0x031AD2C0 */ }
        System.Single RoomGameObj_AuxSendLevelToSelf { get; /* RVA: 0x0428C3B8 */ set; /* RVA: 0x031AD200 */ }
        System.Boolean RoomGameObj_KeepRegistered { get; /* RVA: 0x0428C408 */ set; /* RVA: 0x031AD150 */ }
        System.UInt32 RoomPriority { get; /* RVA: 0x0428C458 */ set; /* RVA: 0x031ACFF0 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60003BB
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x02524410  token: 0x60003BC
        private static System.IntPtr getCPtr(AkRoomParams obj) { }
        // RVA: 0x0428C560  token: 0x60003BD
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0428C23C  token: 0x60003BE
        protected virtual System.Void Finalize() { }
        // RVA: 0x0428C1EC  token: 0x60003BF
        public virtual System.Void Dispose() { }
        // RVA: 0x0428C0D8  token: 0x60003C0
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x03B0E670  token: 0x60003C1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005A  // size: 0x20
    public class AkSegmentInfo : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Int32 iCurrentPosition { get; /* RVA: 0x0428C940 */ set; /* RVA: 0x0428CC5C */ }
        System.Int32 iPreEntryDuration { get; /* RVA: 0x0428C9E0 */ set; /* RVA: 0x0428CD04 */ }
        System.Int32 iActiveDuration { get; /* RVA: 0x0428C8F0 */ set; /* RVA: 0x0428CC08 */ }
        System.Int32 iPostExitDuration { get; /* RVA: 0x0428C990 */ set; /* RVA: 0x0428CCB0 */ }
        System.Int32 iRemainingLookAheadTime { get; /* RVA: 0x0428CA30 */ set; /* RVA: 0x0428CD58 */ }
        System.Single fBeatDuration { get; /* RVA: 0x0428C800 */ set; /* RVA: 0x0428CB00 */ }
        System.Single fBarDuration { get; /* RVA: 0x0428C7B0 */ set; /* RVA: 0x0428CAA8 */ }
        System.Single fGridDuration { get; /* RVA: 0x0428C850 */ set; /* RVA: 0x0428CB58 */ }
        System.Single fGridOffset { get; /* RVA: 0x0428C8A0 */ set; /* RVA: 0x0428CBB0 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60003D2
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60003D3
        private static System.IntPtr getCPtr(AkSegmentInfo obj) { }
        // RVA: 0x0428CA80  token: 0x60003D4
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0428C6EC  token: 0x60003D5
        protected virtual System.Void Finalize() { }
        // RVA: 0x0428C588  token: 0x60003D6
        public virtual System.Void Dispose() { }
        // RVA: 0x0428C5D8  token: 0x60003D7
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0428C760  token: 0x60003EA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005B  // size: 0x20
    public class AkSerializedCallbackHeader : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.IntPtr pPackage { get; /* RVA: 0x0428D0F0 */ }
        System.UInt32 eType { get; /* RVA: 0x0428D024 */ }
        AkSerializedCallbackHeader pNext { get; /* RVA: 0x0428D074 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60003EB
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60003EC
        private static System.IntPtr getCPtr(AkSerializedCallbackHeader obj) { }
        // RVA: 0x0428D140  token: 0x60003ED
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0428CF10  token: 0x60003EE
        protected virtual System.Void Finalize() { }
        // RVA: 0x0428CDAC  token: 0x60003EF
        public virtual System.Void Dispose() { }
        // RVA: 0x0428CDFC  token: 0x60003F0
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0428CF84  token: 0x60003F3
        public System.IntPtr GetData() { }
        // RVA: 0x0428CFD4  token: 0x60003F5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005C  // size: 0x14
    public sealed struct AkSetPositionFlags
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkSetPositionFlags AkSetPositionFlags_Emitter;  // const
        public static AkSetPositionFlags AkSetPositionFlags_Listener;  // const
        public static AkSetPositionFlags AkSetPositionFlags_Default;  // const

    }

    // TypeToken: 0x200005D  // size: 0x14
    public sealed struct AkSourceChannelOrdering
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkSourceChannelOrdering SourceChannelOrdering_Standard;  // const
        public static AkSourceChannelOrdering SourceChannelOrdering_Film;  // const
        public static AkSourceChannelOrdering SourceChannelOrdering_FuMa;  // const
        public static AkSourceChannelOrdering SourceChannelOrdering_Last;  // const

    }

    // TypeToken: 0x200005E  // size: 0x20
    public class AkSourceSettings : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt32 sourceID { get; /* RVA: 0x042A5EDC */ set; /* RVA: 0x042A5FF8 */ }
        System.IntPtr pMediaMemory { get; /* RVA: 0x042A5E8C */ set; /* RVA: 0x042A5FA4 */ }
        System.UInt32 uMediaSize { get; /* RVA: 0x042A5F2C */ set; /* RVA: 0x042A604C */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60003F6
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60003F7
        private static System.IntPtr getCPtr(AkSourceSettings obj) { }
        // RVA: 0x042A5F7C  token: 0x60003F8
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042A5D88  token: 0x60003F9
        protected virtual System.Void Finalize() { }
        // RVA: 0x042A5C24  token: 0x60003FA
        public virtual System.Void Dispose() { }
        // RVA: 0x042A5C74  token: 0x60003FB
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042A5B6C  token: 0x6000402
        public System.Void Clear() { }
        // RVA: 0x042A5DFC  token: 0x6000403
        public static System.Int32 GetSizeOf() { }
        // RVA: 0x042A5BBC  token: 0x6000404
        public System.Void Clone(AkSourceSettings other) { }
        // RVA: 0x042A5E3C  token: 0x6000405
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005F  // size: 0x20
    public class AkSpatialAudioInitSettings : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt32 uMaxSoundPropagationDepth { get; /* RVA: 0x042A6320 */ set; /* RVA: 0x02A036B0 */ }
        System.Single fMovementThreshold { get; /* RVA: 0x042A6230 */ set; /* RVA: 0x02A03600 */ }
        System.UInt32 uNumberOfPrimaryRays { get; /* RVA: 0x02A020C0 */ set; /* RVA: 0x02A03560 */ }
        System.UInt32 uMaxReflectionOrder { get; /* RVA: 0x02A03B40 */ set; /* RVA: 0x02A034C0 */ }
        System.UInt32 uMaxDiffractionOrder { get; /* RVA: 0x02A03AB0 */ set; /* RVA: 0x02A03420 */ }
        System.UInt32 uMaxEmitterRoomAuxSends { get; /* RVA: 0x042A62D0 */ set; /* RVA: 0x02A03380 */ }
        System.UInt32 uDiffractionOnReflectionsOrder { get; /* RVA: 0x042A6280 */ set; /* RVA: 0x02A032E0 */ }
        System.Single fMaxPathLength { get; /* RVA: 0x042A61E0 */ set; /* RVA: 0x02A03230 */ }
        System.Single fCPULimitPercentage { get; /* RVA: 0x042A6190 */ set; /* RVA: 0x02A03180 */ }
        System.UInt32 uLoadBalancingSpread { get; /* RVA: 0x02A03A20 */ set; /* RVA: 0x02A030E0 */ }
        System.Boolean bEnableGeometricDiffractionAndTransmission { get; /* RVA: 0x042A6140 */ set; /* RVA: 0x02A03030 */ }
        System.Boolean bCalcEmitterVirtualPosition { get; /* RVA: 0x042A60F0 */ set; /* RVA: 0x02A02F80 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000406
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x02524410  token: 0x6000407
        private static System.IntPtr getCPtr(AkSpatialAudioInitSettings obj) { }
        // RVA: 0x042A6370  token: 0x6000408
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x03891700  token: 0x6000409
        protected virtual System.Void Finalize() { }
        // RVA: 0x042A60A0  token: 0x600040A
        public virtual System.Void Dispose() { }
        // RVA: 0x03891750  token: 0x600040B
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x02A02D80  token: 0x600040C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000060  // size: 0x14
    public sealed struct AkSpeakerPanningType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkSpeakerPanningType AK_DirectSpeakerAssignment;  // const
        public static AkSpeakerPanningType AK_BalanceFadeHeight;  // const
        public static AkSpeakerPanningType AK_SteeringPanner;  // const

    }

    // TypeToken: 0x2000061  // size: 0x20
    public class AkStdMovePolicy : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Methods
        // RVA: 0x03D4E290  token: 0x6000425
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000426
        private static System.IntPtr getCPtr(AkStdMovePolicy obj) { }
        // RVA: 0x042A6600  token: 0x6000427
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042A64FC  token: 0x6000428
        protected virtual System.Void Finalize() { }
        // RVA: 0x042A6398  token: 0x6000429
        public virtual System.Void Dispose() { }
        // RVA: 0x042A63E8  token: 0x600042A
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042A6570  token: 0x600042B
        public static System.Boolean IsTrivial() { }
        // RVA: 0x042A65B0  token: 0x600042C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000062  // size: 0x20
    public class AkStreamMgrSettings : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Methods
        // RVA: 0x03D4E290  token: 0x600042D
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x600042E
        private static System.IntPtr getCPtr(AkStreamMgrSettings obj) { }
        // RVA: 0x042A6678  token: 0x600042F
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x03A508F0  token: 0x6000430
        protected virtual System.Void Finalize() { }
        // RVA: 0x042A6628  token: 0x6000431
        public virtual System.Void Dispose() { }
        // RVA: 0x03A50940  token: 0x6000432
        protected virtual System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x2000063  // size: 0x20
    public class AkTransform : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Methods
        // RVA: 0x03D4E290  token: 0x6000433
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000434
        private static System.IntPtr getCPtr(AkTransform obj) { }
        // RVA: 0x042A6DB4  token: 0x6000435
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042A6804  token: 0x6000436
        protected virtual System.Void Finalize() { }
        // RVA: 0x042A67B4  token: 0x6000437
        public virtual System.Void Dispose() { }
        // RVA: 0x042A66A0  token: 0x6000438
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042A6948  token: 0x6000439
        public UnityEngine.Vector3 Position() { }
        // RVA: 0x042A6878  token: 0x600043A
        public UnityEngine.Vector3 OrientationFront() { }
        // RVA: 0x042A68E0  token: 0x600043B
        public UnityEngine.Vector3 OrientationTop() { }
        // RVA: 0x042A6BD0  token: 0x600043C
        public System.Void Set(UnityEngine.Vector3 in_position, UnityEngine.Vector3 in_orientationFront, UnityEngine.Vector3 in_orientationTop) { }
        // RVA: 0x042A6C84  token: 0x600043D
        public System.Void Set(System.Single in_positionX, System.Single in_positionY, System.Single in_positionZ, System.Single in_orientFrontX, System.Single in_orientFrontY, System.Single in_orientFrontZ, System.Single in_orientTopX, System.Single in_orientTopY, System.Single in_orientTopZ) { }
        // RVA: 0x042A6AE8  token: 0x600043E
        public System.Void SetPosition(UnityEngine.Vector3 in_position) { }
        // RVA: 0x042A6B50  token: 0x600043F
        public System.Void SetPosition(System.Single in_x, System.Single in_y, System.Single in_z) { }
        // RVA: 0x042A69B0  token: 0x6000440
        public System.Void SetOrientation(UnityEngine.Vector3 in_orientationFront, UnityEngine.Vector3 in_orientationTop) { }
        // RVA: 0x042A6A3C  token: 0x6000441
        public System.Void SetOrientation(System.Single in_orientFrontX, System.Single in_orientFrontY, System.Single in_orientFrontZ, System.Single in_orientTopX, System.Single in_orientTopY, System.Single in_orientTopZ) { }
        // RVA: 0x042A6D64  token: 0x6000442
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000064  // size: 0x20
    public class AkTriangle : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt16 point0 { get; /* RVA: 0x042A7180 */ set; /* RVA: 0x042A72E8 */ }
        System.UInt16 point1 { get; /* RVA: 0x042A71D0 */ set; /* RVA: 0x042A733C */ }
        System.UInt16 point2 { get; /* RVA: 0x042A7220 */ set; /* RVA: 0x042A7390 */ }
        System.UInt16 surface { get; /* RVA: 0x042A7270 */ set; /* RVA: 0x042A73E4 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000443
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000444
        private static System.IntPtr getCPtr(AkTriangle obj) { }
        // RVA: 0x042A72C0  token: 0x6000445
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042A6FF8  token: 0x6000446
        protected virtual System.Void Finalize() { }
        // RVA: 0x042A6FA8  token: 0x6000447
        public virtual System.Void Dispose() { }
        // RVA: 0x042A6E94  token: 0x6000448
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042A70AC  token: 0x6000449
        public System.Void .ctor() { }
        // RVA: 0x042A70FC  token: 0x600044A
        public System.Void .ctor(System.UInt16 in_pt0, System.UInt16 in_pt1, System.UInt16 in_pt2, System.UInt16 in_surfaceInfo) { }
        // RVA: 0x042A6DDC  token: 0x6000453
        public System.Void Clear() { }
        // RVA: 0x042A706C  token: 0x6000454
        public static System.Int32 GetSizeOf() { }
        // RVA: 0x042A6E2C  token: 0x6000455
        public System.Void Clone(AkTriangle other) { }

    }

    // TypeToken: 0x2000065  // size: 0x20
    public class AkTrivialStdMovePolicy : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Methods
        // RVA: 0x03D4E290  token: 0x6000456
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000457
        private static System.IntPtr getCPtr(AkTrivialStdMovePolicy obj) { }
        // RVA: 0x042A76A0  token: 0x6000458
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042A759C  token: 0x6000459
        protected virtual System.Void Finalize() { }
        // RVA: 0x042A754C  token: 0x600045A
        public virtual System.Void Dispose() { }
        // RVA: 0x042A7438  token: 0x600045B
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042A7610  token: 0x600045C
        public static System.Boolean IsTrivial() { }
        // RVA: 0x042A7650  token: 0x600045D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000066  // size: 0x20
    public class AkWorldTransform : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Methods
        // RVA: 0x03D4E290  token: 0x600045E
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x600045F
        private static System.IntPtr getCPtr(AkWorldTransform obj) { }
        // RVA: 0x042A7DE8  token: 0x6000460
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042A782C  token: 0x6000461
        protected virtual System.Void Finalize() { }
        // RVA: 0x042A76C8  token: 0x6000462
        public virtual System.Void Dispose() { }
        // RVA: 0x042A7718  token: 0x6000463
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042A7970  token: 0x6000464
        public AkVector64 Position() { }
        // RVA: 0x042A78A0  token: 0x6000465
        public UnityEngine.Vector3 OrientationFront() { }
        // RVA: 0x042A7908  token: 0x6000466
        public UnityEngine.Vector3 OrientationTop() { }
        // RVA: 0x042A7CE0  token: 0x6000467
        public System.Void Set(AkVector64 in_position, UnityEngine.Vector3 in_orientationFront, UnityEngine.Vector3 in_orientationTop) { }
        // RVA: 0x042A7C00  token: 0x6000468
        public System.Void Set(System.Double in_positionX, System.Double in_positionY, System.Double in_positionZ, System.Single in_orientFrontX, System.Single in_orientFrontY, System.Single in_orientFrontZ, System.Single in_orientTopX, System.Single in_orientTopY, System.Single in_orientTopZ) { }
        // RVA: 0x042A7B14  token: 0x6000469
        public System.Void SetPosition(AkVector64 in_position) { }
        // RVA: 0x042A7B80  token: 0x600046A
        public System.Void SetPosition(System.Double in_x, System.Double in_y, System.Double in_z) { }
        // RVA: 0x042A7A88  token: 0x600046B
        public System.Void SetOrientation(UnityEngine.Vector3 in_orientationFront, UnityEngine.Vector3 in_orientationTop) { }
        // RVA: 0x042A79DC  token: 0x600046C
        public System.Void SetOrientation(System.Single in_orientFrontX, System.Single in_orientFrontY, System.Single in_orientFrontZ, System.Single in_orientTopX, System.Single in_orientTopY, System.Single in_orientTopZ) { }
        // RVA: 0x042A7D98  token: 0x600046D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000067  // size: 0x20
    public class MonitorErrorInfo : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.String m_name { get; /* RVA: 0x042A8164 */ set; /* RVA: 0x042A824C */ }
        System.String m_message { get; /* RVA: 0x042A80F8 */ set; /* RVA: 0x042A81F8 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x600046E
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x600046F
        private static System.IntPtr getCPtr(MonitorErrorInfo obj) { }
        // RVA: 0x042A81D0  token: 0x6000470
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042A7F74  token: 0x6000471
        protected virtual System.Void Finalize() { }
        // RVA: 0x042A7F24  token: 0x6000472
        public virtual System.Void Dispose() { }
        // RVA: 0x042A7E10  token: 0x6000473
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042A7FE8  token: 0x6000474
        public System.Void .ctor(System.String in_name, System.String in_message) { }
        // RVA: 0x042A8050  token: 0x6000475
        public System.Void .ctor(System.String in_name) { }
        // RVA: 0x042A80A8  token: 0x6000476
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000068  // size: 0x20
    public class MsgContext : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt32 in_playingID { get; /* RVA: 0x042A8710 */ set; /* RVA: 0x042A8880 */ }
        System.UInt64 in_gameObjID { get; /* RVA: 0x042A86C0 */ set; /* RVA: 0x042A882C */ }
        System.UInt32 in_soundID { get; /* RVA: 0x042A8760 */ set; /* RVA: 0x042A88D4 */ }
        System.Boolean in_bIsBus { get; /* RVA: 0x042A8670 */ set; /* RVA: 0x042A87D8 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x600047B
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x600047C
        private static System.IntPtr getCPtr(MsgContext obj) { }
        // RVA: 0x042A87B0  token: 0x600047D
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042A8404  token: 0x600047E
        protected virtual System.Void Finalize() { }
        // RVA: 0x042A83B4  token: 0x600047F
        public virtual System.Void Dispose() { }
        // RVA: 0x042A82A0  token: 0x6000480
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042A85F4  token: 0x6000481
        public System.Void .ctor(System.UInt32 pId, System.UInt64 goId, System.UInt32 nodeId, System.Boolean isBus) { }
        // RVA: 0x042A8478  token: 0x6000482
        public System.Void .ctor(System.UInt32 pId, System.UInt64 goId, System.UInt32 nodeId) { }
        // RVA: 0x042A8590  token: 0x6000483
        public System.Void .ctor(System.UInt32 pId, System.UInt64 goId) { }
        // RVA: 0x042A853C  token: 0x6000484
        public System.Void .ctor(System.UInt32 pId) { }
        // RVA: 0x042A84EC  token: 0x6000485
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006A  // size: 0x14
    public sealed struct AkCommSystem
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkCommunicationSettings.AkCommSystem AkCommSystem_Socket;  // const
        public static AkCommunicationSettings.AkCommSystem AkCommSystem_HTCS;  // const

    }

    // TypeToken: 0x2000069  // size: 0x20
    public class AkCommunicationSettings : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.UInt32 uPoolSize { get; /* RVA: 0x0427E9C4 */ set; /* RVA: 0x0427EBE0 */ }
        System.UInt16 uDiscoveryBroadcastPort { get; /* RVA: 0x0427E974 */ set; /* RVA: 0x0427EB8C */ }
        System.UInt16 uCommandPort { get; /* RVA: 0x0427E924 */ set; /* RVA: 0x0427EB38 */ }
        AkCommunicationSettings.AkCommSystem commSystem { get; /* RVA: 0x0427E868 */ set; /* RVA: 0x0427EA90 */ }
        System.Boolean bInitSystemLib { get; /* RVA: 0x0427E818 */ set; /* RVA: 0x0427EA3C */ }
        System.String szAppNetworkName { get; /* RVA: 0x0427E8B8 */ set; /* RVA: 0x0427EAE4 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x600048E
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x600048F
        private static System.IntPtr getCPtr(AkCommunicationSettings obj) { }
        // RVA: 0x0427EA14  token: 0x6000490
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x0427E754  token: 0x6000491
        protected virtual System.Void Finalize() { }
        // RVA: 0x0427E5F0  token: 0x6000492
        public virtual System.Void Dispose() { }
        // RVA: 0x0427E640  token: 0x6000493
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x0427E7C8  token: 0x6000494
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006B  // size: 0x20
    public class AkPlatformInitSettings : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        AkThreadProperties threadLEngine { get; /* RVA: 0x04287E6C */ set; /* RVA: 0x04288208 */ }
        AkThreadProperties threadOutputMgr { get; /* RVA: 0x04287F64 */ set; /* RVA: 0x042882D8 */ }
        AkThreadProperties threadBankManager { get; /* RVA: 0x04287DF0 */ set; /* RVA: 0x042881A0 */ }
        AkThreadProperties threadMonitor { get; /* RVA: 0x04287EE8 */ set; /* RVA: 0x04288270 */ }
        System.UInt16 uNumRefillsInVoice { get; /* RVA: 0x04288030 */ set; /* RVA: 0x02A041F0 */ }
        System.UInt32 uSampleRate { get; /* RVA: 0x04288080 */ set; /* RVA: 0x02A042A0 */ }
        System.Boolean bEnableAvxSupport { get; /* RVA: 0x04287D50 */ set; /* RVA: 0x042880F8 */ }
        System.UInt32 uMaxSystemAudioObjects { get; /* RVA: 0x04287FE0 */ set; /* RVA: 0x03C977B0 */ }
        System.Boolean bEnableDirectInputSupport { get; /* RVA: 0x04287DA0 */ set; /* RVA: 0x0428814C */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x60004A1
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x60004A2
        private static System.IntPtr getCPtr(AkPlatformInitSettings obj) { }
        // RVA: 0x042880D0  token: 0x60004A3
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x03924210  token: 0x60004A4
        protected virtual System.Void Finalize() { }
        // RVA: 0x04287D00  token: 0x60004A5
        public virtual System.Void Dispose() { }
        // RVA: 0x03924260  token: 0x60004A6
        protected virtual System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x200006C  // size: 0x10
    public class AkSoundEnginePINVOKE
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60004B9
        private static System.Void .cctor() { }
        // RVA: 0x0429C188  token: 0x60004BA
        public static System.UInt32 CSharp_JoystickIdToWwiseId(System.UInt32 jarg1) { }
        // RVA: 0x0428D3C8  token: 0x60004BB
        public static System.UInt32 CSharp_AK_INVALID_SHARE_SET_ID_get() { }
        // RVA: 0x0428D39C  token: 0x60004BC
        public static System.UInt32 CSharp_AK_INVALID_PIPELINE_ID_get() { }
        // RVA: 0x0428D2A0  token: 0x60004BD
        public static System.UInt64 CSharp_AK_INVALID_AUDIO_OBJECT_ID_get() { }
        // RVA: 0x0428D4D0  token: 0x60004BE
        public static System.UInt32 CSharp_AK_SOUNDBANK_VERSION_get() { }
        // RVA: 0x04291E0C  token: 0x60004BF
        public static System.UInt32 CSharp_AkJobType_Generic_get() { }
        // RVA: 0x04291DE0  token: 0x60004C0
        public static System.UInt32 CSharp_AkJobType_AudioProcessing_get() { }
        // RVA: 0x04291E38  token: 0x60004C1
        public static System.UInt32 CSharp_AkJobType_SpatialAudio_get() { }
        // RVA: 0x0428D4A4  token: 0x60004C2
        public static System.UInt32 CSharp_AK_NUM_JOB_TYPES_get() { }
        // RVA: 0x0428E5B4  token: 0x60004C3
        public static System.Void CSharp_AkAudioSettings_uNumSamplesPerFrame_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428E580  token: 0x60004C4
        public static System.UInt32 CSharp_AkAudioSettings_uNumSamplesPerFrame_get(System.IntPtr jarg1) { }
        // RVA: 0x0428E628  token: 0x60004C5
        public static System.Void CSharp_AkAudioSettings_uNumSamplesPerSecond_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428E5F4  token: 0x60004C6
        public static System.UInt32 CSharp_AkAudioSettings_uNumSamplesPerSecond_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4724  token: 0x60004C7
        public static System.IntPtr CSharp_new_AkAudioSettings() { }
        // RVA: 0x042A3778  token: 0x60004C8
        public static System.Void CSharp_delete_AkAudioSettings(System.IntPtr jarg1) { }
        // RVA: 0x0428FC2C  token: 0x60004C9
        public static System.Void CSharp_AkDeviceDescription_idDevice_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x03618180  token: 0x60004CA
        public static System.UInt32 CSharp_AkDeviceDescription_idDevice_get(System.IntPtr jarg1) { }
        // RVA: 0x0428FB2C  token: 0x60004CB
        public static System.Void CSharp_AkDeviceDescription_deviceName_set(System.IntPtr jarg1, System.String jarg2) { }
        // RVA: 0x0428FAF8  token: 0x60004CC
        public static System.IntPtr CSharp_AkDeviceDescription_deviceName_get(System.IntPtr jarg1) { }
        // RVA: 0x0428FBEC  token: 0x60004CD
        public static System.Void CSharp_AkDeviceDescription_deviceStateMask_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x0428FBB8  token: 0x60004CE
        public static System.Int32 CSharp_AkDeviceDescription_deviceStateMask_get(System.IntPtr jarg1) { }
        // RVA: 0x0428FC6C  token: 0x60004CF
        public static System.Void CSharp_AkDeviceDescription_isDefaultDevice_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x03617FD0  token: 0x60004D0
        public static System.Boolean CSharp_AkDeviceDescription_isDefaultDevice_get(System.IntPtr jarg1) { }
        // RVA: 0x03799C20  token: 0x60004D1
        public static System.Void CSharp_AkDeviceDescription_Clear(System.IntPtr jarg1) { }
        // RVA: 0x03694FF0  token: 0x60004D2
        public static System.Int32 CSharp_AkDeviceDescription_GetSizeOf() { }
        // RVA: 0x0428FAB4  token: 0x60004D3
        public static System.Void CSharp_AkDeviceDescription_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042A4904  token: 0x60004D4
        public static System.IntPtr CSharp_new_AkDeviceDescription() { }
        // RVA: 0x042A394C  token: 0x60004D5
        public static System.Void CSharp_delete_AkDeviceDescription(System.IntPtr jarg1) { }
        // RVA: 0x042986CC  token: 0x60004D6
        public static AkVector64 CSharp_AkWorldTransform_Position(System.IntPtr jarg1) { }
        // RVA: 0x042985A4  token: 0x60004D7
        public static UnityEngine.Vector3 CSharp_AkWorldTransform_OrientationFront(System.IntPtr jarg1) { }
        // RVA: 0x04298638  token: 0x60004D8
        public static UnityEngine.Vector3 CSharp_AkWorldTransform_OrientationTop(System.IntPtr jarg1) { }
        // RVA: 0x0429897C  token: 0x60004D9
        public static System.Void CSharp_AkWorldTransform_Set__SWIG_0(System.IntPtr jarg1, AkVector64 jarg2, UnityEngine.Vector3 jarg3, UnityEngine.Vector3 jarg4) { }
        // RVA: 0x04298A58  token: 0x60004DA
        public static System.Void CSharp_AkWorldTransform_Set__SWIG_1(System.IntPtr jarg1, System.Double jarg2, System.Double jarg3, System.Double jarg4, System.Single jarg5, System.Single jarg6, System.Single jarg7, System.Single jarg8, System.Single jarg9, System.Single jarg10) { }
        // RVA: 0x04298880  token: 0x60004DB
        public static System.Void CSharp_AkWorldTransform_SetPosition__SWIG_0(System.IntPtr jarg1, AkVector64 jarg2) { }
        // RVA: 0x0429891C  token: 0x60004DC
        public static System.Void CSharp_AkWorldTransform_SetPosition__SWIG_1(System.IntPtr jarg1, System.Double jarg2, System.Double jarg3, System.Double jarg4) { }
        // RVA: 0x04298764  token: 0x60004DD
        public static System.Void CSharp_AkWorldTransform_SetOrientation__SWIG_0(System.IntPtr jarg1, UnityEngine.Vector3 jarg2, UnityEngine.Vector3 jarg3) { }
        // RVA: 0x04298820  token: 0x60004DE
        public static System.Void CSharp_AkWorldTransform_SetOrientation__SWIG_1(System.IntPtr jarg1, System.Single jarg2, System.Single jarg3, System.Single jarg4, System.Single jarg5, System.Single jarg6, System.Single jarg7) { }
        // RVA: 0x042A57AC  token: 0x60004DF
        public static System.IntPtr CSharp_new_AkWorldTransform() { }
        // RVA: 0x042A4444  token: 0x60004E0
        public static System.Void CSharp_delete_AkWorldTransform(System.IntPtr jarg1) { }
        // RVA: 0x04298084  token: 0x60004E1
        public static UnityEngine.Vector3 CSharp_AkTransform_Position(System.IntPtr jarg1) { }
        // RVA: 0x04297F5C  token: 0x60004E2
        public static UnityEngine.Vector3 CSharp_AkTransform_OrientationFront(System.IntPtr jarg1) { }
        // RVA: 0x04297FF0  token: 0x60004E3
        public static UnityEngine.Vector3 CSharp_AkTransform_OrientationTop(System.IntPtr jarg1) { }
        // RVA: 0x031ADC80  token: 0x60004E4
        public static System.Void CSharp_AkTransform_Set__SWIG_0(System.IntPtr jarg1, UnityEngine.Vector3 jarg2, UnityEngine.Vector3 jarg3, UnityEngine.Vector3 jarg4) { }
        // RVA: 0x0429832C  token: 0x60004E5
        public static System.Void CSharp_AkTransform_Set__SWIG_1(System.IntPtr jarg1, System.Single jarg2, System.Single jarg3, System.Single jarg4, System.Single jarg5, System.Single jarg6, System.Single jarg7, System.Single jarg8, System.Single jarg9, System.Single jarg10) { }
        // RVA: 0x04298234  token: 0x60004E6
        public static System.Void CSharp_AkTransform_SetPosition__SWIG_0(System.IntPtr jarg1, UnityEngine.Vector3 jarg2) { }
        // RVA: 0x042982CC  token: 0x60004E7
        public static System.Void CSharp_AkTransform_SetPosition__SWIG_1(System.IntPtr jarg1, System.Single jarg2, System.Single jarg3, System.Single jarg4) { }
        // RVA: 0x04298118  token: 0x60004E8
        public static System.Void CSharp_AkTransform_SetOrientation__SWIG_0(System.IntPtr jarg1, UnityEngine.Vector3 jarg2, UnityEngine.Vector3 jarg3) { }
        // RVA: 0x042981D4  token: 0x60004E9
        public static System.Void CSharp_AkTransform_SetOrientation__SWIG_1(System.IntPtr jarg1, System.Single jarg2, System.Single jarg3, System.Single jarg4, System.Single jarg5, System.Single jarg6, System.Single jarg7) { }
        // RVA: 0x02A01BB0  token: 0x60004EA
        public static System.IntPtr CSharp_new_AkTransform() { }
        // RVA: 0x042A4374  token: 0x60004EB
        public static System.Void CSharp_delete_AkTransform(System.IntPtr jarg1) { }
        // RVA: 0x04298F4C  token: 0x60004EC
        public static UnityEngine.Vector3 CSharp_ConvertAkVector64ToAkVector(AkVector64 jarg1) { }
        // RVA: 0x042990A4  token: 0x60004ED
        public static System.IntPtr CSharp_ConvertAkWorldTransformToAkTransform(System.IntPtr jarg1) { }
        // RVA: 0x04298FF8  token: 0x60004EE
        public static AkVector64 CSharp_ConvertAkVectorToAkVector64(UnityEngine.Vector3 jarg1) { }
        // RVA: 0x04298F18  token: 0x60004EF
        public static System.IntPtr CSharp_ConvertAkTransformToAkWorldTransform(System.IntPtr jarg1) { }
        // RVA: 0x04294B34  token: 0x60004F0
        public static System.Void CSharp_AkObstructionOcclusionValues_occlusion_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04294B00  token: 0x60004F1
        public static System.Single CSharp_AkObstructionOcclusionValues_occlusion_get(System.IntPtr jarg1) { }
        // RVA: 0x04294ABC  token: 0x60004F2
        public static System.Void CSharp_AkObstructionOcclusionValues_obstruction_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04294A88  token: 0x60004F3
        public static System.Single CSharp_AkObstructionOcclusionValues_obstruction_get(System.IntPtr jarg1) { }
        // RVA: 0x042949E4  token: 0x60004F4
        public static System.Void CSharp_AkObstructionOcclusionValues_Clear(System.IntPtr jarg1) { }
        // RVA: 0x04294A5C  token: 0x60004F5
        public static System.Int32 CSharp_AkObstructionOcclusionValues_GetSizeOf() { }
        // RVA: 0x04294A18  token: 0x60004F6
        public static System.Void CSharp_AkObstructionOcclusionValues_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042A50C0  token: 0x60004F7
        public static System.IntPtr CSharp_new_AkObstructionOcclusionValues() { }
        // RVA: 0x042A3FCC  token: 0x60004F8
        public static System.Void CSharp_delete_AkObstructionOcclusionValues(System.IntPtr jarg1) { }
        // RVA: 0x0428F554  token: 0x60004F9
        public static System.Void CSharp_AkChannelEmitter_position_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x0428F518  token: 0x60004FA
        public static System.IntPtr CSharp_AkChannelEmitter_position_get(System.IntPtr jarg1) { }
        // RVA: 0x0428F5CC  token: 0x60004FB
        public static System.Void CSharp_AkChannelEmitter_uInputChannels_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428F598  token: 0x60004FC
        public static System.UInt32 CSharp_AkChannelEmitter_uInputChannels_get(System.IntPtr jarg1) { }
        // RVA: 0x0428F484  token: 0x60004FD
        public static System.Void CSharp_AkChannelEmitter_padding_set(System.IntPtr jarg1, System.String jarg2) { }
        // RVA: 0x0428F450  token: 0x60004FE
        public static System.IntPtr CSharp_AkChannelEmitter_padding_get(System.IntPtr jarg1) { }
        // RVA: 0x042A38E4  token: 0x60004FF
        public static System.Void CSharp_delete_AkChannelEmitter(System.IntPtr jarg1) { }
        // RVA: 0x0428E95C  token: 0x6000500
        public static System.Void CSharp_AkAuxSendValue_listenerID_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        // RVA: 0x0428E8E4  token: 0x6000501
        public static System.UInt64 CSharp_AkAuxSendValue_listenerID_get(System.IntPtr jarg1) { }
        // RVA: 0x0428E7F4  token: 0x6000502
        public static System.Void CSharp_AkAuxSendValue_auxBusID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428E7C0  token: 0x6000503
        public static System.UInt32 CSharp_AkAuxSendValue_auxBusID_get(System.IntPtr jarg1) { }
        // RVA: 0x0428E8A0  token: 0x6000504
        public static System.Void CSharp_AkAuxSendValue_fControlValue_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x0428E874  token: 0x6000505
        public static System.Single CSharp_AkAuxSendValue_fControlValue_get(System.IntPtr jarg1) { }
        // RVA: 0x0428E764  token: 0x6000506
        public static System.Void CSharp_AkAuxSendValue_Set(System.IntPtr jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.Single jarg4) { }
        // RVA: 0x0428E6CC  token: 0x6000507
        public static System.Boolean CSharp_AkAuxSendValue_IsSame(System.IntPtr jarg1, System.UInt64 jarg2, System.UInt32 jarg3) { }
        // RVA: 0x0428E6A0  token: 0x6000508
        public static System.Int32 CSharp_AkAuxSendValue_GetSizeOf() { }
        // RVA: 0x042A37E0  token: 0x6000509
        public static System.Void CSharp_delete_AkAuxSendValue(System.IntPtr jarg1) { }
        // RVA: 0x042A5504  token: 0x600050A
        public static System.IntPtr CSharp_new_AkRamp__SWIG_0() { }
        // RVA: 0x042A5538  token: 0x600050B
        public static System.IntPtr CSharp_new_AkRamp__SWIG_1(System.Single jarg1, System.Single jarg2) { }
        // RVA: 0x04296B48  token: 0x600050C
        public static System.Void CSharp_AkRamp_fPrev_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04296B14  token: 0x600050D
        public static System.Single CSharp_AkRamp_fPrev_get(System.IntPtr jarg1) { }
        // RVA: 0x04296AD8  token: 0x600050E
        public static System.Void CSharp_AkRamp_fNext_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04296AA4  token: 0x600050F
        public static System.Single CSharp_AkRamp_fNext_get(System.IntPtr jarg1) { }
        // RVA: 0x042A416C  token: 0x6000510
        public static System.Void CSharp_delete_AkRamp(System.IntPtr jarg1) { }
        // RVA: 0x0428D238  token: 0x6000511
        public static System.UInt16 CSharp_AK_INT_get() { }
        // RVA: 0x0428D168  token: 0x6000512
        public static System.UInt16 CSharp_AK_FLOAT_get() { }
        // RVA: 0x0428D1D0  token: 0x6000513
        public static System.Byte CSharp_AK_INTERLEAVED_get() { }
        // RVA: 0x0428D478  token: 0x6000514
        public static System.Byte CSharp_AK_NONINTERLEAVED_get() { }
        // RVA: 0x0428D3F4  token: 0x6000515
        public static System.UInt32 CSharp_AK_LE_NATIVE_BITSPERSAMPLE_get() { }
        // RVA: 0x0428D44C  token: 0x6000516
        public static System.UInt32 CSharp_AK_LE_NATIVE_SAMPLETYPE_get() { }
        // RVA: 0x0428D420  token: 0x6000517
        public static System.UInt32 CSharp_AK_LE_NATIVE_INTERLEAVE_get() { }
        // RVA: 0x0428E494  token: 0x6000518
        public static System.Void CSharp_AkAudioFormat_uSampleRate_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428E460  token: 0x6000519
        public static System.UInt32 CSharp_AkAudioFormat_uSampleRate_get(System.IntPtr jarg1) { }
        // RVA: 0x0428E284  token: 0x600051A
        public static System.Void CSharp_AkAudioFormat_channelConfig_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x0428E248  token: 0x600051B
        public static System.IntPtr CSharp_AkAudioFormat_channelConfig_get(System.IntPtr jarg1) { }
        // RVA: 0x0428E338  token: 0x600051C
        public static System.Void CSharp_AkAudioFormat_uBitsPerSample_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428E304  token: 0x600051D
        public static System.UInt32 CSharp_AkAudioFormat_uBitsPerSample_get(System.IntPtr jarg1) { }
        // RVA: 0x0428E3AC  token: 0x600051E
        public static System.Void CSharp_AkAudioFormat_uBlockAlign_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428E378  token: 0x600051F
        public static System.UInt32 CSharp_AkAudioFormat_uBlockAlign_get(System.IntPtr jarg1) { }
        // RVA: 0x0428E508  token: 0x6000520
        public static System.Void CSharp_AkAudioFormat_uTypeID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428E4D4  token: 0x6000521
        public static System.UInt32 CSharp_AkAudioFormat_uTypeID_get(System.IntPtr jarg1) { }
        // RVA: 0x0428E420  token: 0x6000522
        public static System.Void CSharp_AkAudioFormat_uInterleaveID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428E3EC  token: 0x6000523
        public static System.UInt32 CSharp_AkAudioFormat_uInterleaveID_get(System.IntPtr jarg1) { }
        // RVA: 0x0428E140  token: 0x6000524
        public static System.UInt32 CSharp_AkAudioFormat_GetNumChannels(System.IntPtr jarg1) { }
        // RVA: 0x0428E060  token: 0x6000525
        public static System.UInt32 CSharp_AkAudioFormat_GetBitsPerSample(System.IntPtr jarg1) { }
        // RVA: 0x0428E0D8  token: 0x6000526
        public static System.UInt32 CSharp_AkAudioFormat_GetBlockAlign(System.IntPtr jarg1) { }
        // RVA: 0x0428E174  token: 0x6000527
        public static System.UInt32 CSharp_AkAudioFormat_GetTypeID(System.IntPtr jarg1) { }
        // RVA: 0x0428E10C  token: 0x6000528
        public static System.UInt32 CSharp_AkAudioFormat_GetInterleaveID(System.IntPtr jarg1) { }
        // RVA: 0x0428E1A8  token: 0x6000529
        public static System.Void CSharp_AkAudioFormat_SetAll(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.UInt32 jarg4, System.UInt32 jarg5, System.UInt32 jarg6, System.UInt32 jarg7) { }
        // RVA: 0x042A46CC  token: 0x600052A
        public static System.IntPtr CSharp_new_AkAudioFormat() { }
        // RVA: 0x042A36CC  token: 0x600052B
        public static System.Void CSharp_delete_AkAudioFormat(System.IntPtr jarg1) { }
        // RVA: 0x0429C0BC  token: 0x600052C
        public static System.Boolean CSharp_IsBankCodecID(System.UInt32 jarg1) { }
        // RVA: 0x042A4674  token: 0x600052D
        public static System.IntPtr CSharp_new_Ak3dData() { }
        // RVA: 0x0428DE74  token: 0x600052E
        public static System.Void CSharp_Ak3dData_xform_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x0428DE38  token: 0x600052F
        public static System.IntPtr CSharp_Ak3dData_xform_get(System.IntPtr jarg1) { }
        // RVA: 0x0428DD80  token: 0x6000530
        public static System.Void CSharp_Ak3dData_spread_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x0428DD4C  token: 0x6000531
        public static System.Single CSharp_Ak3dData_spread_get(System.IntPtr jarg1) { }
        // RVA: 0x0428DD08  token: 0x6000532
        public static System.Void CSharp_Ak3dData_focus_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x0428DCD4  token: 0x6000533
        public static System.Single CSharp_Ak3dData_focus_get(System.IntPtr jarg1) { }
        // RVA: 0x0428DDF8  token: 0x6000534
        public static System.Void CSharp_Ak3dData_uEmitterChannelMask_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428DDC4  token: 0x6000535
        public static System.UInt32 CSharp_Ak3dData_uEmitterChannelMask_get(System.IntPtr jarg1) { }
        // RVA: 0x042A3620  token: 0x6000536
        public static System.Void CSharp_delete_Ak3dData(System.IntPtr jarg1) { }
        // RVA: 0x042A47A8  token: 0x6000537
        public static System.IntPtr CSharp_new_AkBehavioralPositioningData() { }
        // RVA: 0x0428EA14  token: 0x6000538
        public static System.Void CSharp_AkBehavioralPositioningData_center_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x0428E9E0  token: 0x6000539
        public static System.Single CSharp_AkBehavioralPositioningData_center_get(System.IntPtr jarg1) { }
        // RVA: 0x0428EBE8  token: 0x600053A
        public static System.Void CSharp_AkBehavioralPositioningData_panLR_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x0428EBB4  token: 0x600053B
        public static System.Single CSharp_AkBehavioralPositioningData_panLR_get(System.IntPtr jarg1) { }
        // RVA: 0x0428EB00  token: 0x600053C
        public static System.Void CSharp_AkBehavioralPositioningData_panBF_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x0428EAD4  token: 0x600053D
        public static System.Single CSharp_AkBehavioralPositioningData_panBF_get(System.IntPtr jarg1) { }
        // RVA: 0x0428EB70  token: 0x600053E
        public static System.Void CSharp_AkBehavioralPositioningData_panDU_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x0428EB3C  token: 0x600053F
        public static System.Single CSharp_AkBehavioralPositioningData_panDU_get(System.IntPtr jarg1) { }
        // RVA: 0x0428EC60  token: 0x6000540
        public static System.Void CSharp_AkBehavioralPositioningData_panSpatMix_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x0428EC2C  token: 0x6000541
        public static System.Single CSharp_AkBehavioralPositioningData_panSpatMix_get(System.IntPtr jarg1) { }
        // RVA: 0x0428ED4C  token: 0x6000542
        public static System.Void CSharp_AkBehavioralPositioningData_spatMode_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x0428ED18  token: 0x6000543
        public static System.Int32 CSharp_AkBehavioralPositioningData_spatMode_get(System.IntPtr jarg1) { }
        // RVA: 0x0428ECD8  token: 0x6000544
        public static System.Void CSharp_AkBehavioralPositioningData_panType_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x0428ECA4  token: 0x6000545
        public static System.Int32 CSharp_AkBehavioralPositioningData_panType_get(System.IntPtr jarg1) { }
        // RVA: 0x0428EA90  token: 0x6000546
        public static System.Void CSharp_AkBehavioralPositioningData_enableHeightSpread_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x0428EA58  token: 0x6000547
        public static System.Boolean CSharp_AkBehavioralPositioningData_enableHeightSpread_get(System.IntPtr jarg1) { }
        // RVA: 0x042A3848  token: 0x6000548
        public static System.Void CSharp_delete_AkBehavioralPositioningData(System.IntPtr jarg1) { }
        // RVA: 0x042961CC  token: 0x6000549
        public static System.Void CSharp_AkPositioningData_threeD_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04296198  token: 0x600054A
        public static System.IntPtr CSharp_AkPositioningData_threeD_get(System.IntPtr jarg1) { }
        // RVA: 0x04296114  token: 0x600054B
        public static System.Void CSharp_AkPositioningData_behavioral_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042960E0  token: 0x600054C
        public static System.IntPtr CSharp_AkPositioningData_behavioral_get(System.IntPtr jarg1) { }
        // RVA: 0x042A5470  token: 0x600054D
        public static System.IntPtr CSharp_new_AkPositioningData() { }
        // RVA: 0x042A4104  token: 0x600054E
        public static System.Void CSharp_delete_AkPositioningData(System.IntPtr jarg1) { }
        // RVA: 0x0428DBA8  token: 0x600054F
        public static System.Void CSharp_Ak3DAudioSinkCapabilities_channelConfig_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x0428DB6C  token: 0x6000550
        public static System.IntPtr CSharp_Ak3DAudioSinkCapabilities_channelConfig_get(System.IntPtr jarg1) { }
        // RVA: 0x0428DC94  token: 0x6000551
        public static System.Void CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428DC60  token: 0x6000552
        public static System.UInt32 CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_get(System.IntPtr jarg1) { }
        // RVA: 0x0428DC20  token: 0x6000553
        public static System.Void CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428DBEC  token: 0x6000554
        public static System.UInt32 CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_get(System.IntPtr jarg1) { }
        // RVA: 0x0428DB28  token: 0x6000555
        public static System.Void CSharp_Ak3DAudioSinkCapabilities_bPassthrough_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x0428DAF0  token: 0x6000556
        public static System.Boolean CSharp_Ak3DAudioSinkCapabilities_bPassthrough_get(System.IntPtr jarg1) { }
        // RVA: 0x0428DAAC  token: 0x6000557
        public static System.Void CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x0428DA74  token: 0x6000558
        public static System.Boolean CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4648  token: 0x6000559
        public static System.IntPtr CSharp_new_Ak3DAudioSinkCapabilities() { }
        // RVA: 0x042A35EC  token: 0x600055A
        public static System.Void CSharp_delete_Ak3DAudioSinkCapabilities(System.IntPtr jarg1) { }
        // RVA: 0x04291D9C  token: 0x600055B
        public static System.Void CSharp_AkIterator_pItem_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04291D68  token: 0x600055C
        public static System.IntPtr CSharp_AkIterator_pItem_get(System.IntPtr jarg1) { }
        // RVA: 0x04291D00  token: 0x600055D
        public static System.IntPtr CSharp_AkIterator_NextIter(System.IntPtr jarg1) { }
        // RVA: 0x04291D34  token: 0x600055E
        public static System.IntPtr CSharp_AkIterator_PrevIter(System.IntPtr jarg1) { }
        // RVA: 0x04291BFC  token: 0x600055F
        public static System.IntPtr CSharp_AkIterator_GetItem(System.IntPtr jarg1) { }
        // RVA: 0x04291C78  token: 0x6000560
        public static System.Boolean CSharp_AkIterator_IsEqualTo(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04291C30  token: 0x6000561
        public static System.Boolean CSharp_AkIterator_IsDifferentFrom(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042A4DA0  token: 0x6000562
        public static System.IntPtr CSharp_new_AkIterator() { }
        // RVA: 0x042A3BBC  token: 0x6000563
        public static System.Void CSharp_delete_AkIterator(System.IntPtr jarg1) { }
        // RVA: 0x04297DD0  token: 0x6000564
        public static System.Boolean CSharp_AkStdMovePolicy_IsTrivial() { }
        // RVA: 0x042A5658  token: 0x6000565
        public static System.IntPtr CSharp_new_AkStdMovePolicy() { }
        // RVA: 0x042A42D8  token: 0x6000566
        public static System.Void CSharp_delete_AkStdMovePolicy(System.IntPtr jarg1) { }
        // RVA: 0x04298574  token: 0x6000567
        public static System.Boolean CSharp_AkTrivialStdMovePolicy_IsTrivial() { }
        // RVA: 0x042A5780  token: 0x6000568
        public static System.IntPtr CSharp_new_AkTrivialStdMovePolicy() { }
        // RVA: 0x042A43DC  token: 0x6000569
        public static System.Void CSharp_delete_AkTrivialStdMovePolicy(System.IntPtr jarg1) { }
        // RVA: 0x042A53E4  token: 0x600056A
        public static System.IntPtr CSharp_new_AkPlaylistItem__SWIG_0() { }
        // RVA: 0x042A5410  token: 0x600056B
        public static System.IntPtr CSharp_new_AkPlaylistItem__SWIG_1(System.IntPtr jarg1) { }
        // RVA: 0x042A409C  token: 0x600056C
        public static System.Void CSharp_delete_AkPlaylistItem(System.IntPtr jarg1) { }
        // RVA: 0x04295B40  token: 0x600056D
        public static System.IntPtr CSharp_AkPlaylistItem_Assign(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04295B84  token: 0x600056E
        public static System.Boolean CSharp_AkPlaylistItem_IsEqualTo(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04295C0C  token: 0x600056F
        public static System.Int32 CSharp_AkPlaylistItem_SetExternalSources(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3) { }
        // RVA: 0x04295CD0  token: 0x6000570
        public static System.Void CSharp_AkPlaylistItem_audioNodeID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04295C9C  token: 0x6000571
        public static System.UInt32 CSharp_AkPlaylistItem_audioNodeID_get(System.IntPtr jarg1) { }
        // RVA: 0x04295D44  token: 0x6000572
        public static System.Void CSharp_AkPlaylistItem_msDelay_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x04295D10  token: 0x6000573
        public static System.Int32 CSharp_AkPlaylistItem_msDelay_get(System.IntPtr jarg1) { }
        // RVA: 0x04295DB8  token: 0x6000574
        public static System.Void CSharp_AkPlaylistItem_pCustomInfo_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04295D84  token: 0x6000575
        public static System.IntPtr CSharp_AkPlaylistItem_pCustomInfo_get(System.IntPtr jarg1) { }
        // RVA: 0x042A53B8  token: 0x6000576
        public static System.IntPtr CSharp_new_AkPlaylistArray() { }
        // RVA: 0x042A4068  token: 0x6000577
        public static System.Void CSharp_delete_AkPlaylistArray(System.IntPtr jarg1) { }
        // RVA: 0x04295210  token: 0x6000578
        public static System.IntPtr CSharp_AkPlaylistArray_Begin(System.IntPtr jarg1) { }
        // RVA: 0x04295304  token: 0x6000579
        public static System.IntPtr CSharp_AkPlaylistArray_End(System.IntPtr jarg1) { }
        // RVA: 0x042954C4  token: 0x600057A
        public static System.IntPtr CSharp_AkPlaylistArray_FindEx(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042953FC  token: 0x600057B
        public static System.IntPtr CSharp_AkPlaylistArray_Erase__SWIG_0(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04295440  token: 0x600057C
        public static System.Void CSharp_AkPlaylistArray_Erase__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04295338  token: 0x600057D
        public static System.IntPtr CSharp_AkPlaylistArray_EraseSwap__SWIG_0(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042953BC  token: 0x600057E
        public static System.Void CSharp_AkPlaylistArray_EraseSwap__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04295700  token: 0x600057F
        public static System.Boolean CSharp_AkPlaylistArray_IsGrowingAllowed(System.IntPtr jarg1) { }
        // RVA: 0x042959D0  token: 0x6000580
        public static System.Int32 CSharp_AkPlaylistArray_Reserve(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04295990  token: 0x6000581
        public static System.Int32 CSharp_AkPlaylistArray_ReserveExtra(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04295A10  token: 0x6000582
        public static System.UInt32 CSharp_AkPlaylistArray_Reserved(System.IntPtr jarg1) { }
        // RVA: 0x04295AC8  token: 0x6000583
        public static System.Void CSharp_AkPlaylistArray_Term(System.IntPtr jarg1) { }
        // RVA: 0x0429582C  token: 0x6000584
        public static System.UInt32 CSharp_AkPlaylistArray_Length(System.IntPtr jarg1) { }
        // RVA: 0x042952D0  token: 0x6000585
        public static System.IntPtr CSharp_AkPlaylistArray_Data(System.IntPtr jarg1) { }
        // RVA: 0x042956C8  token: 0x6000586
        public static System.Boolean CSharp_AkPlaylistArray_IsEmpty(System.IntPtr jarg1) { }
        // RVA: 0x04295480  token: 0x6000587
        public static System.IntPtr CSharp_AkPlaylistArray_Exists(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04295114  token: 0x6000588
        public static System.IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_0(System.IntPtr jarg1) { }
        // RVA: 0x0429518C  token: 0x6000589
        public static System.IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_1(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042957F8  token: 0x600058A
        public static System.IntPtr CSharp_AkPlaylistArray_Last(System.IntPtr jarg1) { }
        // RVA: 0x04295894  token: 0x600058B
        public static System.Void CSharp_AkPlaylistArray_RemoveLast(System.IntPtr jarg1) { }
        // RVA: 0x0429590C  token: 0x600058C
        public static System.Int32 CSharp_AkPlaylistArray_Remove(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042958C8  token: 0x600058D
        public static System.Int32 CSharp_AkPlaylistArray_RemoveSwap(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04295860  token: 0x600058E
        public static System.Void CSharp_AkPlaylistArray_RemoveAll(System.IntPtr jarg1) { }
        // RVA: 0x04295778  token: 0x600058F
        public static System.IntPtr CSharp_AkPlaylistArray_ItemAtIndex(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04295604  token: 0x6000590
        public static System.IntPtr CSharp_AkPlaylistArray_Insert__SWIG_0(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04295648  token: 0x6000591
        public static System.IntPtr CSharp_AkPlaylistArray_Insert__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04295548  token: 0x6000592
        public static System.Boolean CSharp_AkPlaylistArray_GrowArray__SWIG_0(System.IntPtr jarg1) { }
        // RVA: 0x04295580  token: 0x6000593
        public static System.Boolean CSharp_AkPlaylistArray_GrowArray__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04295A44  token: 0x6000594
        public static System.Boolean CSharp_AkPlaylistArray_Resize(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04295AFC  token: 0x6000595
        public static System.Void CSharp_AkPlaylistArray_Transfer(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x0429524C  token: 0x6000596
        public static System.Int32 CSharp_AkPlaylistArray_Copy(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04295DFC  token: 0x6000597
        public static System.Int32 CSharp_AkPlaylist_Enqueue__SWIG_0(System.IntPtr jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.IntPtr jarg4, System.UInt32 jarg5, System.IntPtr jarg6) { }
        // RVA: 0x04295E9C  token: 0x6000598
        public static System.Int32 CSharp_AkPlaylist_Enqueue__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.IntPtr jarg4, System.UInt32 jarg5) { }
        // RVA: 0x04295F3C  token: 0x6000599
        public static System.Int32 CSharp_AkPlaylist_Enqueue__SWIG_2(System.IntPtr jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.IntPtr jarg4) { }
        // RVA: 0x04295FDC  token: 0x600059A
        public static System.Int32 CSharp_AkPlaylist_Enqueue__SWIG_3(System.IntPtr jarg1, System.UInt32 jarg2, System.Int32 jarg3) { }
        // RVA: 0x0429606C  token: 0x600059B
        public static System.Int32 CSharp_AkPlaylist_Enqueue__SWIG_4(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042A5444  token: 0x600059C
        public static System.IntPtr CSharp_new_AkPlaylist() { }
        // RVA: 0x042A40D0  token: 0x600059D
        public static System.Void CSharp_delete_AkPlaylist(System.IntPtr jarg1) { }
        // RVA: 0x04299308  token: 0x600059E
        public static System.UInt32 CSharp_DynamicSequenceOpen__SWIG_0(System.UInt64 jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.Int32 jarg5) { }
        // RVA: 0x042993A8  token: 0x600059F
        public static System.UInt32 CSharp_DynamicSequenceOpen__SWIG_1(System.UInt64 jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4) { }
        // RVA: 0x04299448  token: 0x60005A0
        public static System.UInt32 CSharp_DynamicSequenceOpen__SWIG_2(System.UInt64 jarg1) { }
        // RVA: 0x042991CC  token: 0x60005A1
        public static System.Int32 CSharp_DynamicSequenceClose(System.UInt32 jarg1) { }
        // RVA: 0x04299600  token: 0x60005A2
        public static System.Int32 CSharp_DynamicSequencePlay__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Int32 jarg3) { }
        // RVA: 0x0429968C  token: 0x60005A3
        public static System.Int32 CSharp_DynamicSequencePlay__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2) { }
        // RVA: 0x0429970C  token: 0x60005A4
        public static System.Int32 CSharp_DynamicSequencePlay__SWIG_2(System.UInt32 jarg1) { }
        // RVA: 0x042994C0  token: 0x60005A5
        public static System.Int32 CSharp_DynamicSequencePause__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Int32 jarg3) { }
        // RVA: 0x0429954C  token: 0x60005A6
        public static System.Int32 CSharp_DynamicSequencePause__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2) { }
        // RVA: 0x042995CC  token: 0x60005A7
        public static System.Int32 CSharp_DynamicSequencePause__SWIG_2(System.UInt32 jarg1) { }
        // RVA: 0x04299740  token: 0x60005A8
        public static System.Int32 CSharp_DynamicSequenceResume__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Int32 jarg3) { }
        // RVA: 0x042997CC  token: 0x60005A9
        public static System.Int32 CSharp_DynamicSequenceResume__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2) { }
        // RVA: 0x0429980C  token: 0x60005AA
        public static System.Int32 CSharp_DynamicSequenceResume__SWIG_2(System.UInt32 jarg1) { }
        // RVA: 0x04299840  token: 0x60005AB
        public static System.Int32 CSharp_DynamicSequenceStop__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Int32 jarg3) { }
        // RVA: 0x04299890  token: 0x60005AC
        public static System.Int32 CSharp_DynamicSequenceStop__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2) { }
        // RVA: 0x042998D0  token: 0x60005AD
        public static System.Int32 CSharp_DynamicSequenceStop__SWIG_2(System.UInt32 jarg1) { }
        // RVA: 0x04299154  token: 0x60005AE
        public static System.Int32 CSharp_DynamicSequenceBreak(System.UInt32 jarg1) { }
        // RVA: 0x042A051C  token: 0x60005AF
        public static System.Int32 CSharp_Seek__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Boolean jarg3) { }
        // RVA: 0x042A056C  token: 0x60005B0
        public static System.Int32 CSharp_Seek__SWIG_1(System.UInt32 jarg1, System.Single jarg2, System.Boolean jarg3) { }
        // RVA: 0x04299200  token: 0x60005B1
        public static System.Int32 CSharp_DynamicSequenceGetPauseTimes(System.UInt32 jarg1, System.UInt32& jarg2, System.UInt32& jarg3) { }
        // RVA: 0x04299290  token: 0x60005B2
        public static System.IntPtr CSharp_DynamicSequenceLockPlaylist(System.UInt32 jarg1) { }
        // RVA: 0x04299948  token: 0x60005B3
        public static System.Int32 CSharp_DynamicSequenceUnlockPlaylist(System.UInt32 jarg1) { }
        // RVA: 0x042A50EC  token: 0x60005B4
        public static System.IntPtr CSharp_new_AkOutputSettings__SWIG_0() { }
        // RVA: 0x042A5118  token: 0x60005B5
        public static System.IntPtr CSharp_new_AkOutputSettings__SWIG_1(System.String jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.Int32 jarg4) { }
        // RVA: 0x042A51D4  token: 0x60005B6
        public static System.IntPtr CSharp_new_AkOutputSettings__SWIG_2(System.String jarg1, System.UInt32 jarg2, System.IntPtr jarg3) { }
        // RVA: 0x042A5280  token: 0x60005B7
        public static System.IntPtr CSharp_new_AkOutputSettings__SWIG_3(System.String jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042A5320  token: 0x60005B8
        public static System.IntPtr CSharp_new_AkOutputSettings__SWIG_4(System.String jarg1) { }
        // RVA: 0x02A4F610  token: 0x60005B9
        public static System.Void CSharp_AkOutputSettings_audioDeviceShareset_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04294B78  token: 0x60005BA
        public static System.UInt32 CSharp_AkOutputSettings_audioDeviceShareset_get(System.IntPtr jarg1) { }
        // RVA: 0x02A4F570  token: 0x60005BB
        public static System.Void CSharp_AkOutputSettings_idDevice_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04294C68  token: 0x60005BC
        public static System.UInt32 CSharp_AkOutputSettings_idDevice_get(System.IntPtr jarg1) { }
        // RVA: 0x02A4F4D0  token: 0x60005BD
        public static System.Void CSharp_AkOutputSettings_ePanningRule_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x04294C34  token: 0x60005BE
        public static System.Int32 CSharp_AkOutputSettings_ePanningRule_get(System.IntPtr jarg1) { }
        // RVA: 0x04294BF0  token: 0x60005BF
        public static System.Void CSharp_AkOutputSettings_channelConfig_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x02A4F350  token: 0x60005C0
        public static System.IntPtr CSharp_AkOutputSettings_channelConfig_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4000  token: 0x60005C1
        public static System.Void CSharp_delete_AkOutputSettings(System.IntPtr jarg1) { }
        // RVA: 0x02A4EB60  token: 0x60005C2
        public static System.Void CSharp_AkInitSettings_uMaxNumPaths_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042918EC  token: 0x60005C3
        public static System.UInt32 CSharp_AkInitSettings_uMaxNumPaths_get(System.IntPtr jarg1) { }
        // RVA: 0x02A4EAC0  token: 0x60005C4
        public static System.Void CSharp_AkInitSettings_uCommandQueueSize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042917DC  token: 0x60005C5
        public static System.UInt32 CSharp_AkInitSettings_uCommandQueueSize_get(System.IntPtr jarg1) { }
        // RVA: 0x02A01AE0  token: 0x60005C6
        public static System.Void CSharp_AkInitSettings_bEnableGameSyncPreparation_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x04291494  token: 0x60005C7
        public static System.Boolean CSharp_AkInitSettings_bEnableGameSyncPreparation_get(System.IntPtr jarg1) { }
        // RVA: 0x02A01A40  token: 0x60005C8
        public static System.Void CSharp_AkInitSettings_uContinuousPlaybackLookAhead_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04291810  token: 0x60005C9
        public static System.UInt32 CSharp_AkInitSettings_uContinuousPlaybackLookAhead_get(System.IntPtr jarg1) { }
        // RVA: 0x02A4EA20  token: 0x60005CA
        public static System.Void CSharp_AkInitSettings_uNumSamplesPerFrame_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04291954  token: 0x60005CB
        public static System.UInt32 CSharp_AkInitSettings_uNumSamplesPerFrame_get(System.IntPtr jarg1) { }
        // RVA: 0x02A019A0  token: 0x60005CC
        public static System.Void CSharp_AkInitSettings_uMonitorQueuePoolSize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04291920  token: 0x60005CD
        public static System.UInt32 CSharp_AkInitSettings_uMonitorQueuePoolSize_get(System.IntPtr jarg1) { }
        // RVA: 0x04291878  token: 0x60005CE
        public static System.Void CSharp_AkInitSettings_uCpuMonitorQueueMaxSize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04291844  token: 0x60005CF
        public static System.UInt32 CSharp_AkInitSettings_uCpuMonitorQueueMaxSize_get(System.IntPtr jarg1) { }
        // RVA: 0x04291724  token: 0x60005D0
        public static System.Void CSharp_AkInitSettings_settingsMainOutput_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x02A4E920  token: 0x60005D1
        public static System.IntPtr CSharp_AkInitSettings_settingsMainOutput_get(System.IntPtr jarg1) { }
        // RVA: 0x02A01900  token: 0x60005D2
        public static System.Void CSharp_AkInitSettings_uMaxHardwareTimeoutMs_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042918B8  token: 0x60005D3
        public static System.UInt32 CSharp_AkInitSettings_uMaxHardwareTimeoutMs_get(System.IntPtr jarg1) { }
        // RVA: 0x042915C0  token: 0x60005D4
        public static System.Void CSharp_AkInitSettings_bUseSoundBankMgrThread_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x04291588  token: 0x60005D5
        public static System.Boolean CSharp_AkInitSettings_bUseSoundBankMgrThread_get(System.IntPtr jarg1) { }
        // RVA: 0x04291544  token: 0x60005D6
        public static System.Void CSharp_AkInitSettings_bUseLEngineThread_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x0429150C  token: 0x60005D7
        public static System.Boolean CSharp_AkInitSettings_bUseLEngineThread_get(System.IntPtr jarg1) { }
        // RVA: 0x02A4F650  token: 0x60005D8
        public static System.Void CSharp_AkInitSettings_szPluginDLLPath_set(System.IntPtr jarg1, System.String jarg2) { }
        // RVA: 0x02A4E7B0  token: 0x60005D9
        public static System.IntPtr CSharp_AkInitSettings_szPluginDLLPath_get(System.IntPtr jarg1) { }
        // RVA: 0x04291638  token: 0x60005DA
        public static System.Void CSharp_AkInitSettings_eFloorPlane_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x04291604  token: 0x60005DB
        public static System.Int32 CSharp_AkInitSettings_eFloorPlane_get(System.IntPtr jarg1) { }
        // RVA: 0x042916E0  token: 0x60005DC
        public static System.Void CSharp_AkInitSettings_fGameUnitsToMeters_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x042916AC  token: 0x60005DD
        public static System.Single CSharp_AkInitSettings_fGameUnitsToMeters_get(System.IntPtr jarg1) { }
        // RVA: 0x0429179C  token: 0x60005DE
        public static System.Void CSharp_AkInitSettings_uBankReadBufferSize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04291768  token: 0x60005DF
        public static System.UInt32 CSharp_AkInitSettings_uBankReadBufferSize_get(System.IntPtr jarg1) { }
        // RVA: 0x02A01850  token: 0x60005E0
        public static System.Void CSharp_AkInitSettings_fDebugOutOfRangeLimit_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04291678  token: 0x60005E1
        public static System.Single CSharp_AkInitSettings_fDebugOutOfRangeLimit_get(System.IntPtr jarg1) { }
        // RVA: 0x02A017A0  token: 0x60005E2
        public static System.Void CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x0429145C  token: 0x60005E3
        public static System.Boolean CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_get(System.IntPtr jarg1) { }
        // RVA: 0x042A3B88  token: 0x60005E4
        public static System.Void CSharp_delete_AkInitSettings(System.IntPtr jarg1) { }
        // RVA: 0x04297B74  token: 0x60005E5
        public static System.Void CSharp_AkSourceSettings_sourceID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04297B40  token: 0x60005E6
        public static System.UInt32 CSharp_AkSourceSettings_sourceID_get(System.IntPtr jarg1) { }
        // RVA: 0x04297AFC  token: 0x60005E7
        public static System.Void CSharp_AkSourceSettings_pMediaMemory_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04297AC8  token: 0x60005E8
        public static System.IntPtr CSharp_AkSourceSettings_pMediaMemory_get(System.IntPtr jarg1) { }
        // RVA: 0x04297BE8  token: 0x60005E9
        public static System.Void CSharp_AkSourceSettings_uMediaSize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04297BB4  token: 0x60005EA
        public static System.UInt32 CSharp_AkSourceSettings_uMediaSize_get(System.IntPtr jarg1) { }
        // RVA: 0x04297A1C  token: 0x60005EB
        public static System.Void CSharp_AkSourceSettings_Clear(System.IntPtr jarg1) { }
        // RVA: 0x04297A94  token: 0x60005EC
        public static System.Int32 CSharp_AkSourceSettings_GetSizeOf() { }
        // RVA: 0x04297A50  token: 0x60005ED
        public static System.Void CSharp_AkSourceSettings_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042A562C  token: 0x60005EE
        public static System.IntPtr CSharp_new_AkSourceSettings() { }
        // RVA: 0x042A42A4  token: 0x60005EF
        public static System.Void CSharp_delete_AkSourceSettings(System.IntPtr jarg1) { }
        // RVA: 0x02690440  token: 0x60005F0
        public static System.Boolean CSharp_IsInitialized() { }
        // RVA: 0x0429A094  token: 0x60005F1
        public static System.Int32 CSharp_GetAudioSettings(System.IntPtr jarg1) { }
        // RVA: 0x0429BA44  token: 0x60005F2
        public static System.IntPtr CSharp_GetSpeakerConfiguration__SWIG_0(System.UInt64 jarg1) { }
        // RVA: 0x02690210  token: 0x60005F3
        public static System.IntPtr CSharp_GetSpeakerConfiguration__SWIG_1() { }
        // RVA: 0x0429AC04  token: 0x60005F4
        public static System.Int32 CSharp_GetOutputDeviceConfiguration(System.UInt64 jarg1, System.IntPtr jarg2, System.IntPtr jarg3) { }
        // RVA: 0x0429ADB4  token: 0x60005F5
        public static System.Int32 CSharp_GetPanningRule__SWIG_0(System.Int32& jarg1, System.UInt64 jarg2) { }
        // RVA: 0x0429AE38  token: 0x60005F6
        public static System.Int32 CSharp_GetPanningRule__SWIG_1(System.Int32& jarg1) { }
        // RVA: 0x042A1B90  token: 0x60005F7
        public static System.Int32 CSharp_SetPanningRule__SWIG_0(System.Int32 jarg1, System.UInt64 jarg2) { }
        // RVA: 0x042A1C10  token: 0x60005F8
        public static System.Int32 CSharp_SetPanningRule__SWIG_1(System.Int32 jarg1) { }
        // RVA: 0x0429B900  token: 0x60005F9
        public static System.Int32 CSharp_GetSpeakerAngles__SWIG_0(System.Single[] jarg1, System.UInt32& jarg2, System.Single& jarg3, System.UInt64 jarg4) { }
        // RVA: 0x0429B9A8  token: 0x60005FA
        public static System.Int32 CSharp_GetSpeakerAngles__SWIG_1(System.Single[] jarg1, System.UInt32& jarg2, System.Single& jarg3) { }
        // RVA: 0x042A2450  token: 0x60005FB
        public static System.Int32 CSharp_SetSpeakerAngles__SWIG_0(System.Single[] jarg1, System.UInt32 jarg2, System.Single jarg3, System.UInt64 jarg4) { }
        // RVA: 0x042A24B4  token: 0x60005FC
        public static System.Int32 CSharp_SetSpeakerAngles__SWIG_1(System.Single[] jarg1, System.UInt32 jarg2, System.Single jarg3) { }
        // RVA: 0x042A26D0  token: 0x60005FD
        public static System.Int32 CSharp_SetVolumeThreshold(System.Single jarg1) { }
        // RVA: 0x042A1404  token: 0x60005FE
        public static System.Int32 CSharp_SetMaxNumVoicesLimit(System.UInt16 jarg1) { }
        // RVA: 0x042A117C  token: 0x60005FF
        public static System.Int32 CSharp_SetJobMgrMaxActiveWorkers(System.UInt32 jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0429F15C  token: 0x6000600
        public static System.Int32 CSharp_RenderAudio__SWIG_0(System.Boolean jarg1) { }
        // RVA: 0x0269BD20  token: 0x6000601
        public static System.Int32 CSharp_RenderAudio__SWIG_1() { }
        // RVA: 0x0429ED6C  token: 0x6000602
        public static System.Int32 CSharp_RegisterPluginDLL__SWIG_0(System.String jarg1, System.String jarg2) { }
        // RVA: 0x0429EE04  token: 0x6000603
        public static System.Int32 CSharp_RegisterPluginDLL__SWIG_1(System.String jarg1) { }
        // RVA: 0x0429C0F4  token: 0x6000604
        public static System.Boolean CSharp_IsPluginRegistered(System.Int32 jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        // RVA: 0x03594130  token: 0x6000605
        public static System.UInt32 CSharp_GetIDFromString__SWIG_0(System.String jarg1) { }
        // RVA: 0x0429D46C  token: 0x6000606
        public static System.UInt32 CSharp_PostEvent__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.UInt32 jarg8) { }
        // RVA: 0x029506D0  token: 0x6000607
        public static System.UInt32 CSharp_PostEvent__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5, System.UInt32 jarg6, System.IntPtr jarg7) { }
        // RVA: 0x0269E470  token: 0x6000608
        public static System.UInt32 CSharp_PostEvent__SWIG_2(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5) { }
        // RVA: 0x0429D50C  token: 0x6000609
        public static System.UInt32 CSharp_PostEvent__SWIG_3(System.UInt32 jarg1, System.UInt64 jarg2) { }
        // RVA: 0x0429D58C  token: 0x600060A
        public static System.UInt32 CSharp_PostEvent__SWIG_4(System.String jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.UInt32 jarg8) { }
        // RVA: 0x0429D63C  token: 0x600060B
        public static System.UInt32 CSharp_PostEvent__SWIG_5(System.String jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5, System.UInt32 jarg6, System.IntPtr jarg7) { }
        // RVA: 0x0429D6E8  token: 0x600060C
        public static System.UInt32 CSharp_PostEvent__SWIG_6(System.String jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5) { }
        // RVA: 0x0429D794  token: 0x600060D
        public static System.UInt32 CSharp_PostEvent__SWIG_7(System.String jarg1, System.UInt64 jarg2) { }
        // RVA: 0x0429997C  token: 0x600060E
        public static System.Int32 CSharp_ExecuteActionOnEvent__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.UInt32 jarg6) { }
        // RVA: 0x04299A18  token: 0x600060F
        public static System.Int32 CSharp_ExecuteActionOnEvent__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5) { }
        // RVA: 0x04299AB4  token: 0x6000610
        public static System.Int32 CSharp_ExecuteActionOnEvent__SWIG_2(System.UInt32 jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4) { }
        // RVA: 0x04299B50  token: 0x6000611
        public static System.Int32 CSharp_ExecuteActionOnEvent__SWIG_3(System.UInt32 jarg1, System.Int32 jarg2, System.UInt64 jarg3) { }
        // RVA: 0x04299BDC  token: 0x6000612
        public static System.Int32 CSharp_ExecuteActionOnEvent__SWIG_4(System.UInt32 jarg1, System.Int32 jarg2) { }
        // RVA: 0x04299C5C  token: 0x6000613
        public static System.Int32 CSharp_ExecuteActionOnEvent__SWIG_5(System.String jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.UInt32 jarg6) { }
        // RVA: 0x04299D04  token: 0x6000614
        public static System.Int32 CSharp_ExecuteActionOnEvent__SWIG_6(System.String jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5) { }
        // RVA: 0x04299DAC  token: 0x6000615
        public static System.Int32 CSharp_ExecuteActionOnEvent__SWIG_7(System.String jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4) { }
        // RVA: 0x04299E54  token: 0x6000616
        public static System.Int32 CSharp_ExecuteActionOnEvent__SWIG_8(System.String jarg1, System.Int32 jarg2, System.UInt64 jarg3) { }
        // RVA: 0x04299EEC  token: 0x6000617
        public static System.Int32 CSharp_ExecuteActionOnEvent__SWIG_9(System.String jarg1, System.Int32 jarg2) { }
        // RVA: 0x0429D820  token: 0x6000618
        public static System.UInt32 CSharp_PostMIDIOnEvent__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.IntPtr jarg3, System.UInt16 jarg4, System.Boolean jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.IntPtr jarg8, System.UInt32 jarg9) { }
        // RVA: 0x0429D8D8  token: 0x6000619
        public static System.UInt32 CSharp_PostMIDIOnEvent__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2, System.IntPtr jarg3, System.UInt16 jarg4, System.Boolean jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.IntPtr jarg8) { }
        // RVA: 0x0429D988  token: 0x600061A
        public static System.UInt32 CSharp_PostMIDIOnEvent__SWIG_2(System.UInt32 jarg1, System.UInt64 jarg2, System.IntPtr jarg3, System.UInt16 jarg4, System.Boolean jarg5) { }
        // RVA: 0x0429DA38  token: 0x600061B
        public static System.UInt32 CSharp_PostMIDIOnEvent__SWIG_3(System.UInt32 jarg1, System.UInt64 jarg2, System.IntPtr jarg3, System.UInt16 jarg4) { }
        // RVA: 0x042A297C  token: 0x600061C
        public static System.Int32 CSharp_StopMIDIOnEvent__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3) { }
        // RVA: 0x042A2A0C  token: 0x600061D
        public static System.Int32 CSharp_StopMIDIOnEvent__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2) { }
        // RVA: 0x042A2A4C  token: 0x600061E
        public static System.Int32 CSharp_StopMIDIOnEvent__SWIG_2(System.UInt32 jarg1) { }
        // RVA: 0x042A2A80  token: 0x600061F
        public static System.Int32 CSharp_StopMIDIOnEvent__SWIG_3() { }
        // RVA: 0x0429CFC4  token: 0x6000620
        public static System.Int32 CSharp_PinEventInStreamCache__SWIG_0(System.UInt32 jarg1, System.SByte jarg2, System.SByte jarg3) { }
        // RVA: 0x0429D054  token: 0x6000621
        public static System.Int32 CSharp_PinEventInStreamCache__SWIG_1(System.String jarg1, System.SByte jarg2, System.SByte jarg3) { }
        // RVA: 0x042A330C  token: 0x6000622
        public static System.Int32 CSharp_UnpinEventInStreamCache__SWIG_0(System.UInt32 jarg1) { }
        // RVA: 0x042A3384  token: 0x6000623
        public static System.Int32 CSharp_UnpinEventInStreamCache__SWIG_1(System.String jarg1) { }
        // RVA: 0x0429A134  token: 0x6000624
        public static System.Int32 CSharp_GetBufferStatusForPinnedEvent__SWIG_0(System.UInt32 jarg1, System.Single& jarg2, System.Int32& jarg3) { }
        // RVA: 0x0429A1C4  token: 0x6000625
        public static System.Int32 CSharp_GetBufferStatusForPinnedEvent__SWIG_1(System.String jarg1, System.Single& jarg2, System.Int32& jarg3) { }
        // RVA: 0x0429FF2C  token: 0x6000626
        public static System.Int32 CSharp_SeekOnEvent__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Boolean jarg4, System.UInt32 jarg5) { }
        // RVA: 0x042A019C  token: 0x6000627
        public static System.Int32 CSharp_SeekOnEvent__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Boolean jarg4) { }
        // RVA: 0x042A023C  token: 0x6000628
        public static System.Int32 CSharp_SeekOnEvent__SWIG_2(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3) { }
        // RVA: 0x042A02CC  token: 0x6000629
        public static System.Int32 CSharp_SeekOnEvent__SWIG_3(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Boolean jarg4, System.UInt32 jarg5) { }
        // RVA: 0x042A0378  token: 0x600062A
        public static System.Int32 CSharp_SeekOnEvent__SWIG_4(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Boolean jarg4) { }
        // RVA: 0x042A0424  token: 0x600062B
        public static System.Int32 CSharp_SeekOnEvent__SWIG_5(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3) { }
        // RVA: 0x042A04C0  token: 0x600062C
        public static System.Int32 CSharp_SeekOnEvent__SWIG_9(System.UInt32 jarg1, System.UInt64 jarg2, System.Single jarg3, System.Boolean jarg4, System.UInt32 jarg5) { }
        // RVA: 0x0429FFCC  token: 0x600062D
        public static System.Int32 CSharp_SeekOnEvent__SWIG_10(System.UInt32 jarg1, System.UInt64 jarg2, System.Single jarg3, System.Boolean jarg4) { }
        // RVA: 0x042A0028  token: 0x600062E
        public static System.Int32 CSharp_SeekOnEvent__SWIG_11(System.UInt32 jarg1, System.UInt64 jarg2, System.Single jarg3) { }
        // RVA: 0x042A0074  token: 0x600062F
        public static System.Int32 CSharp_SeekOnEvent__SWIG_12(System.String jarg1, System.UInt64 jarg2, System.Single jarg3, System.Boolean jarg4, System.UInt32 jarg5) { }
        // RVA: 0x042A00DC  token: 0x6000630
        public static System.Int32 CSharp_SeekOnEvent__SWIG_13(System.String jarg1, System.UInt64 jarg2, System.Single jarg3, System.Boolean jarg4) { }
        // RVA: 0x042A0144  token: 0x6000631
        public static System.Int32 CSharp_SeekOnEvent__SWIG_14(System.String jarg1, System.UInt64 jarg2, System.Single jarg3) { }
        // RVA: 0x04298B6C  token: 0x6000632
        public static System.Void CSharp_CancelEventCallbackCookie(System.IntPtr jarg1) { }
        // RVA: 0x04298BA0  token: 0x6000633
        public static System.Void CSharp_CancelEventCallbackGameObject(System.UInt64 jarg1) { }
        // RVA: 0x04298BD4  token: 0x6000634
        public static System.Void CSharp_CancelEventCallback(System.UInt32 jarg1) { }
        // RVA: 0x0429B760  token: 0x6000635
        public static System.Int32 CSharp_GetSourcePlayPosition__SWIG_0(System.UInt32 jarg1, System.Int32& jarg2, System.Boolean jarg3) { }
        // RVA: 0x0429B7F0  token: 0x6000636
        public static System.Int32 CSharp_GetSourcePlayPosition__SWIG_1(System.UInt32 jarg1, System.Int32& jarg2) { }
        // RVA: 0x0429B870  token: 0x6000637
        public static System.Int32 CSharp_GetSourceStreamBuffering(System.UInt32 jarg1, System.Int32& jarg2, System.Int32& jarg3) { }
        // RVA: 0x02AF8690  token: 0x6000638
        public static System.Void CSharp_StopAll__SWIG_0(System.UInt64 jarg1) { }
        // RVA: 0x042A291C  token: 0x6000639
        public static System.Void CSharp_StopAll__SWIG_1() { }
        // RVA: 0x042A2B14  token: 0x600063A
        public static System.Void CSharp_StopPlayingID__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Int32 jarg3) { }
        // RVA: 0x042A2BA0  token: 0x600063B
        public static System.Void CSharp_StopPlayingID__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2) { }
        // RVA: 0x042A2C20  token: 0x600063C
        public static System.Void CSharp_StopPlayingID__SWIG_2(System.UInt32 jarg1) { }
        // RVA: 0x04299F78  token: 0x600063D
        public static System.Void CSharp_ExecuteActionOnPlayingID__SWIG_0(System.Int32 jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.Int32 jarg4) { }
        // RVA: 0x02A9E7B0  token: 0x600063E
        public static System.Void CSharp_ExecuteActionOnPlayingID__SWIG_1(System.Int32 jarg1, System.UInt32 jarg2, System.Int32 jarg3) { }
        // RVA: 0x0429A014  token: 0x600063F
        public static System.Void CSharp_ExecuteActionOnPlayingID__SWIG_2(System.Int32 jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042A22EC  token: 0x6000640
        public static System.Void CSharp_SetRandomSeed(System.UInt32 jarg1) { }
        // RVA: 0x0429CF20  token: 0x6000641
        public static System.Void CSharp_MuteBackgroundMusic(System.Boolean jarg1) { }
        // RVA: 0x0429A0C8  token: 0x6000642
        public static System.Boolean CSharp_GetBackgroundMusicMute() { }
        // RVA: 0x042A05B8  token: 0x6000643
        public static System.Int32 CSharp_SendPluginCustomGameData(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.UInt32 jarg4, System.UInt32 jarg5, System.IntPtr jarg6, System.UInt32 jarg7) { }
        // RVA: 0x042A3400  token: 0x6000644
        public static System.Int32 CSharp_UnregisterAllGameObj() { }
        // RVA: 0x042A16A8  token: 0x6000645
        public static System.Int32 CSharp_SetMultiplePositions__SWIG_0(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3, System.Int32 jarg4, System.Int32 jarg5) { }
        // RVA: 0x03287A90  token: 0x6000646
        public static System.Int32 CSharp_SetMultiplePositions__SWIG_1(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3, System.Int32 jarg4) { }
        // RVA: 0x042A174C  token: 0x6000647
        public static System.Int32 CSharp_SetMultiplePositions__SWIG_2(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3) { }
        // RVA: 0x042A17E0  token: 0x6000648
        public static System.Int32 CSharp_SetMultiplePositions__SWIG_3(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3, System.Int32 jarg4, System.Int32 jarg5) { }
        // RVA: 0x042A1884  token: 0x6000649
        public static System.Int32 CSharp_SetMultiplePositions__SWIG_4(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3, System.Int32 jarg4) { }
        // RVA: 0x042A1928  token: 0x600064A
        public static System.Int32 CSharp_SetMultiplePositions__SWIG_5(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3) { }
        // RVA: 0x02EA2400  token: 0x600064B
        public static System.Int32 CSharp_SetScalingFactor(System.UInt64 jarg1, System.Single jarg2) { }
        // RVA: 0x042A0B64  token: 0x600064C
        public static System.Int32 CSharp_SetDistanceProbe(System.UInt64 jarg1, System.UInt64 jarg2) { }
        // RVA: 0x04298D34  token: 0x600064D
        public static System.Int32 CSharp_ClearBanks() { }
        // RVA: 0x042A077C  token: 0x600064E
        public static System.Int32 CSharp_SetBankLoadIOSettings(System.Single jarg1, System.SByte jarg2) { }
        // RVA: 0x0429C6E0  token: 0x600064F
        public static System.Int32 CSharp_LoadBank__SWIG_0(System.String jarg1, System.UInt32& jarg2, System.UInt32 jarg3) { }
        // RVA: 0x0429C77C  token: 0x6000650
        public static System.Int32 CSharp_LoadBank__SWIG_1(System.String jarg1, System.UInt32& jarg2) { }
        // RVA: 0x0429C808  token: 0x6000651
        public static System.Int32 CSharp_LoadBank__SWIG_4(System.UInt32 jarg1, System.UInt32 jarg2) { }
        // RVA: 0x02951F60  token: 0x6000652
        public static System.Int32 CSharp_LoadBank__SWIG_5(System.UInt32 jarg1) { }
        // RVA: 0x0429C470  token: 0x6000653
        public static System.Int32 CSharp_LoadBankMemoryView__SWIG_0(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32& jarg3) { }
        // RVA: 0x0429C500  token: 0x6000654
        public static System.Int32 CSharp_LoadBankMemoryView__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32& jarg3, System.UInt32& jarg4) { }
        // RVA: 0x0429C200  token: 0x6000655
        public static System.Int32 CSharp_LoadBankMemoryCopy__SWIG_0(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32& jarg3) { }
        // RVA: 0x0429C290  token: 0x6000656
        public static System.Int32 CSharp_LoadBankMemoryCopy__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32& jarg3, System.UInt32& jarg4) { }
        // RVA: 0x0429C888  token: 0x6000657
        public static System.Int32 CSharp_LoadBank__SWIG_6(System.String jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.UInt32& jarg4, System.UInt32 jarg5) { }
        // RVA: 0x0429C934  token: 0x6000658
        public static System.Int32 CSharp_LoadBank__SWIG_7(System.String jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.UInt32& jarg4) { }
        // RVA: 0x0269FFB0  token: 0x6000659
        public static System.Int32 CSharp_LoadBank__SWIG_10(System.UInt32 jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.UInt32 jarg4) { }
        // RVA: 0x03594210  token: 0x600065A
        public static System.Int32 CSharp_LoadBank__SWIG_11(System.UInt32 jarg1, System.IntPtr jarg2, System.IntPtr jarg3) { }
        // RVA: 0x0429C5A0  token: 0x600065B
        public static System.Int32 CSharp_LoadBankMemoryView__SWIG_2(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32& jarg5) { }
        // RVA: 0x0429C640  token: 0x600065C
        public static System.Int32 CSharp_LoadBankMemoryView__SWIG_3(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32& jarg5, System.UInt32& jarg6) { }
        // RVA: 0x0429C330  token: 0x600065D
        public static System.Int32 CSharp_LoadBankMemoryCopy__SWIG_2(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32& jarg5) { }
        // RVA: 0x0429C3D0  token: 0x600065E
        public static System.Int32 CSharp_LoadBankMemoryCopy__SWIG_3(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32& jarg5, System.UInt32& jarg6) { }
        // RVA: 0x042A2EDC  token: 0x600065F
        public static System.Int32 CSharp_UnloadBank__SWIG_0(System.String jarg1, System.IntPtr jarg2, System.UInt32 jarg3) { }
        // RVA: 0x042A3018  token: 0x6000660
        public static System.Int32 CSharp_UnloadBank__SWIG_1(System.String jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042A30A4  token: 0x6000661
        public static System.Int32 CSharp_UnloadBank__SWIG_4(System.UInt32 jarg1, System.IntPtr jarg2, System.UInt32 jarg3) { }
        // RVA: 0x042A3134  token: 0x6000662
        public static System.Int32 CSharp_UnloadBank__SWIG_5(System.UInt32 jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042A31B4  token: 0x6000663
        public static System.Int32 CSharp_UnloadBank__SWIG_6(System.String jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32 jarg5) { }
        // RVA: 0x042A3260  token: 0x6000664
        public static System.Int32 CSharp_UnloadBank__SWIG_7(System.String jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.IntPtr jarg4) { }
        // RVA: 0x026A05C0  token: 0x6000665
        public static System.Int32 CSharp_UnloadBank__SWIG_10(System.UInt32 jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32 jarg5) { }
        // RVA: 0x042A2F78  token: 0x6000666
        public static System.Int32 CSharp_UnloadBank__SWIG_11(System.UInt32 jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.IntPtr jarg4) { }
        // RVA: 0x04298B38  token: 0x6000667
        public static System.Void CSharp_CancelBankCallbackCookie(System.IntPtr jarg1) { }
        // RVA: 0x0429DED4  token: 0x6000668
        public static System.Int32 CSharp_PrepareBank__SWIG_0(System.Int32 jarg1, System.String jarg2, System.Int32 jarg3, System.UInt32 jarg4) { }
        // RVA: 0x0429E2A0  token: 0x6000669
        public static System.Int32 CSharp_PrepareBank__SWIG_1(System.Int32 jarg1, System.String jarg2, System.Int32 jarg3) { }
        // RVA: 0x0429E338  token: 0x600066A
        public static System.Int32 CSharp_PrepareBank__SWIG_2(System.Int32 jarg1, System.String jarg2) { }
        // RVA: 0x0429E3C4  token: 0x600066B
        public static System.Int32 CSharp_PrepareBank__SWIG_6(System.Int32 jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.UInt32 jarg4) { }
        // RVA: 0x0429E460  token: 0x600066C
        public static System.Int32 CSharp_PrepareBank__SWIG_7(System.Int32 jarg1, System.UInt32 jarg2, System.Int32 jarg3) { }
        // RVA: 0x0429E4EC  token: 0x600066D
        public static System.Int32 CSharp_PrepareBank__SWIG_8(System.Int32 jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0429E56C  token: 0x600066E
        public static System.Int32 CSharp_PrepareBank__SWIG_9(System.Int32 jarg1, System.String jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.Int32 jarg5, System.UInt32 jarg6) { }
        // RVA: 0x0429DF7C  token: 0x600066F
        public static System.Int32 CSharp_PrepareBank__SWIG_10(System.Int32 jarg1, System.String jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.Int32 jarg5) { }
        // RVA: 0x0429E024  token: 0x6000670
        public static System.Int32 CSharp_PrepareBank__SWIG_11(System.Int32 jarg1, System.String jarg2, System.IntPtr jarg3, System.IntPtr jarg4) { }
        // RVA: 0x0429E0CC  token: 0x6000671
        public static System.Int32 CSharp_PrepareBank__SWIG_15(System.Int32 jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.Int32 jarg5, System.UInt32 jarg6) { }
        // RVA: 0x0429E168  token: 0x6000672
        public static System.Int32 CSharp_PrepareBank__SWIG_16(System.Int32 jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.Int32 jarg5) { }
        // RVA: 0x0429E204  token: 0x6000673
        public static System.Int32 CSharp_PrepareBank__SWIG_17(System.Int32 jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4) { }
        // RVA: 0x04298EB0  token: 0x6000674
        public static System.Int32 CSharp_ClearPreparedEvents() { }
        // RVA: 0x0429E614  token: 0x6000675
        public static System.Int32 CSharp_PrepareEvent__SWIG_0(System.Int32 jarg1, System.IntPtr jarg2, System.UInt32 jarg3) { }
        // RVA: 0x0429E6A4  token: 0x6000676
        public static System.Int32 CSharp_PrepareEvent__SWIG_1(System.Int32 jarg1, System.UInt32[] jarg2, System.UInt32 jarg3) { }
        // RVA: 0x0429E73C  token: 0x6000677
        public static System.Int32 CSharp_PrepareEvent__SWIG_2(System.Int32 jarg1, System.IntPtr jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5) { }
        // RVA: 0x026A0010  token: 0x6000678
        public static System.Int32 CSharp_PrepareEvent__SWIG_3(System.Int32 jarg1, System.UInt32[] jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5) { }
        // RVA: 0x042A147C  token: 0x6000679
        public static System.Int32 CSharp_SetMedia(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042A3494  token: 0x600067A
        public static System.Int32 CSharp_UnsetMedia(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0429E7DC  token: 0x600067B
        public static System.Int32 CSharp_PrepareGameSyncs__SWIG_0(System.Int32 jarg1, System.Int32 jarg2, System.String jarg3, System.IntPtr jarg4, System.UInt32 jarg5) { }
        // RVA: 0x0429E884  token: 0x600067C
        public static System.Int32 CSharp_PrepareGameSyncs__SWIG_1(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt32[] jarg4, System.UInt32 jarg5) { }
        // RVA: 0x0429E92C  token: 0x600067D
        public static System.Int32 CSharp_PrepareGameSyncs__SWIG_2(System.Int32 jarg1, System.Int32 jarg2, System.String jarg3, System.IntPtr jarg4, System.UInt32 jarg5, System.IntPtr jarg6, System.IntPtr jarg7) { }
        // RVA: 0x0429E9D4  token: 0x600067E
        public static System.Int32 CSharp_PrepareGameSyncs__SWIG_3(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt32[] jarg4, System.UInt32 jarg5, System.IntPtr jarg6, System.IntPtr jarg7) { }
        // RVA: 0x0428D718  token: 0x600067F
        public static System.Int32 CSharp_AddListener(System.UInt64 jarg1, System.UInt64 jarg2) { }
        // RVA: 0x0429EFF8  token: 0x6000680
        public static System.Int32 CSharp_RemoveListener(System.UInt64 jarg1, System.UInt64 jarg2) { }
        // RVA: 0x0428D6A0  token: 0x6000681
        public static System.Int32 CSharp_AddDefaultListener(System.UInt64 jarg1) { }
        // RVA: 0x0429EE44  token: 0x6000682
        public static System.Int32 CSharp_RemoveDefaultListener(System.UInt64 jarg1) { }
        // RVA: 0x0429F2E8  token: 0x6000683
        public static System.Int32 CSharp_ResetListenersToDefault(System.UInt64 jarg1) { }
        // RVA: 0x042A11FC  token: 0x6000684
        public static System.Int32 CSharp_SetListenerSpatialization__SWIG_0(System.UInt64 jarg1, System.Boolean jarg2, System.IntPtr jarg3, System.Single[] jarg4) { }
        // RVA: 0x042A12A4  token: 0x6000685
        public static System.Int32 CSharp_SetListenerSpatialization__SWIG_1(System.UInt64 jarg1, System.Boolean jarg2, System.IntPtr jarg3) { }
        // RVA: 0x042A1FC4  token: 0x6000686
        public static System.Int32 CSharp_SetRTPCValue__SWIG_0(System.UInt32 jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.Boolean jarg6) { }
        // RVA: 0x042A2028  token: 0x6000687
        public static System.Int32 CSharp_SetRTPCValue__SWIG_1(System.UInt32 jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5) { }
        // RVA: 0x02830C00  token: 0x6000688
        public static System.Int32 CSharp_SetRTPCValue__SWIG_2(System.UInt32 jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4) { }
        // RVA: 0x042A2084  token: 0x6000689
        public static System.Int32 CSharp_SetRTPCValue__SWIG_3(System.UInt32 jarg1, System.Single jarg2, System.UInt64 jarg3) { }
        // RVA: 0x042A20D0  token: 0x600068A
        public static System.Int32 CSharp_SetRTPCValue__SWIG_4(System.UInt32 jarg1, System.Single jarg2) { }
        // RVA: 0x042A210C  token: 0x600068B
        public static System.Int32 CSharp_SetRTPCValue__SWIG_5(System.String jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.Boolean jarg6) { }
        // RVA: 0x042A217C  token: 0x600068C
        public static System.Int32 CSharp_SetRTPCValue__SWIG_6(System.String jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5) { }
        // RVA: 0x042A21E4  token: 0x600068D
        public static System.Int32 CSharp_SetRTPCValue__SWIG_7(System.String jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4) { }
        // RVA: 0x042A224C  token: 0x600068E
        public static System.Int32 CSharp_SetRTPCValue__SWIG_8(System.String jarg1, System.Single jarg2, System.UInt64 jarg3) { }
        // RVA: 0x042A22A4  token: 0x600068F
        public static System.Int32 CSharp_SetRTPCValue__SWIG_9(System.String jarg1, System.Single jarg2) { }
        // RVA: 0x042A1D20  token: 0x6000690
        public static System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_0(System.UInt32 jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.Boolean jarg6) { }
        // RVA: 0x042A1D84  token: 0x6000691
        public static System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_1(System.UInt32 jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4, System.Int32 jarg5) { }
        // RVA: 0x02A361A0  token: 0x6000692
        public static System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_2(System.UInt32 jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4) { }
        // RVA: 0x042A1DE0  token: 0x6000693
        public static System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_3(System.UInt32 jarg1, System.Single jarg2, System.UInt32 jarg3) { }
        // RVA: 0x042A1E2C  token: 0x6000694
        public static System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_4(System.String jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.Boolean jarg6) { }
        // RVA: 0x042A1E9C  token: 0x6000695
        public static System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_5(System.String jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4, System.Int32 jarg5) { }
        // RVA: 0x042A1F04  token: 0x6000696
        public static System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_6(System.String jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4) { }
        // RVA: 0x042A1F6C  token: 0x6000697
        public static System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_7(System.String jarg1, System.Single jarg2, System.UInt32 jarg3) { }
        // RVA: 0x0429F83C  token: 0x6000698
        public static System.Int32 CSharp_ResetRTPCValue__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Int32 jarg4, System.Boolean jarg5) { }
        // RVA: 0x0429F8E8  token: 0x6000699
        public static System.Int32 CSharp_ResetRTPCValue__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Int32 jarg4) { }
        // RVA: 0x0429F988  token: 0x600069A
        public static System.Int32 CSharp_ResetRTPCValue__SWIG_2(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3) { }
        // RVA: 0x0429FA18  token: 0x600069B
        public static System.Int32 CSharp_ResetRTPCValue__SWIG_3(System.UInt32 jarg1, System.UInt64 jarg2) { }
        // RVA: 0x0429FA58  token: 0x600069C
        public static System.Int32 CSharp_ResetRTPCValue__SWIG_4(System.UInt32 jarg1) { }
        // RVA: 0x0429FA8C  token: 0x600069D
        public static System.Int32 CSharp_ResetRTPCValue__SWIG_5(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Int32 jarg4, System.Boolean jarg5) { }
        // RVA: 0x0429FB48  token: 0x600069E
        public static System.Int32 CSharp_ResetRTPCValue__SWIG_6(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Int32 jarg4) { }
        // RVA: 0x0429FBF4  token: 0x600069F
        public static System.Int32 CSharp_ResetRTPCValue__SWIG_7(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3) { }
        // RVA: 0x0429FC8C  token: 0x60006A0
        public static System.Int32 CSharp_ResetRTPCValue__SWIG_8(System.String jarg1, System.UInt64 jarg2) { }
        // RVA: 0x0429FD18  token: 0x60006A1
        public static System.Int32 CSharp_ResetRTPCValue__SWIG_9(System.String jarg1) { }
        // RVA: 0x0429F360  token: 0x60006A2
        public static System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.Int32 jarg4, System.Boolean jarg5) { }
        // RVA: 0x0429F40C  token: 0x60006A3
        public static System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_1(System.UInt32 jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.Int32 jarg4) { }
        // RVA: 0x0429F4A8  token: 0x60006A4
        public static System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_2(System.UInt32 jarg1, System.UInt32 jarg2, System.Int32 jarg3) { }
        // RVA: 0x0429F534  token: 0x60006A5
        public static System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_3(System.UInt32 jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0429F5B4  token: 0x60006A6
        public static System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_4(System.String jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.Int32 jarg4, System.Boolean jarg5) { }
        // RVA: 0x0429F670  token: 0x60006A7
        public static System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_5(System.String jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.Int32 jarg4) { }
        // RVA: 0x0429F718  token: 0x60006A8
        public static System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_6(System.String jarg1, System.UInt32 jarg2, System.Int32 jarg3) { }
        // RVA: 0x0429F7B0  token: 0x60006A9
        public static System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_7(System.String jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042A25A0  token: 0x60006AA
        public static System.Int32 CSharp_SetSwitch__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt64 jarg3) { }
        // RVA: 0x042A262C  token: 0x60006AB
        public static System.Int32 CSharp_SetSwitch__SWIG_1(System.String jarg1, System.String jarg2, System.UInt64 jarg3) { }
        // RVA: 0x0429DE08  token: 0x60006AC
        public static System.Int32 CSharp_PostTrigger__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2) { }
        // RVA: 0x0429DE48  token: 0x60006AD
        public static System.Int32 CSharp_PostTrigger__SWIG_1(System.String jarg1, System.UInt64 jarg2) { }
        // RVA: 0x03232340  token: 0x60006AE
        public static System.Int32 CSharp_SetState__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042A2508  token: 0x60006AF
        public static System.Int32 CSharp_SetState__SWIG_1(System.String jarg1, System.String jarg2) { }
        // RVA: 0x042A0D4C  token: 0x60006B0
        public static System.Int32 CSharp_SetGameObjectAuxSendValues(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt32 jarg3) { }
        // RVA: 0x042A0E60  token: 0x60006B1
        public static System.Int32 CSharp_SetGameObjectOutputBusVolume(System.UInt64 jarg1, System.UInt64 jarg2, System.Single jarg3) { }
        // RVA: 0x042A0658  token: 0x60006B2
        public static System.Int32 CSharp_SetActorMixerEffect(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        // RVA: 0x042A0A40  token: 0x60006B3
        public static System.Int32 CSharp_SetBusEffect__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        // RVA: 0x042A0ACC  token: 0x60006B4
        public static System.Int32 CSharp_SetBusEffect__SWIG_1(System.String jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        // RVA: 0x042A1AC4  token: 0x60006B5
        public static System.Int32 CSharp_SetOutputDeviceEffect(System.UInt64 jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        // RVA: 0x042A14FC  token: 0x60006B6
        public static System.Int32 CSharp_SetMixer__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042A157C  token: 0x60006B7
        public static System.Int32 CSharp_SetMixer__SWIG_1(System.String jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042A07F8  token: 0x60006B8
        public static System.Int32 CSharp_SetBusConfig__SWIG_0(System.UInt32 jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042A0878  token: 0x60006B9
        public static System.Int32 CSharp_SetBusConfig__SWIG_1(System.String jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042A19BC  token: 0x60006BA
        public static System.Int32 CSharp_SetObjectObstructionAndOcclusion(System.UInt64 jarg1, System.UInt64 jarg2, System.Single jarg3, System.Single jarg4) { }
        // RVA: 0x042A1608  token: 0x60006BB
        public static System.Int32 CSharp_SetMultipleObstructionAndOcclusion(System.UInt64 jarg1, System.UInt64 jarg2, System.IntPtr jarg3, System.UInt32 jarg4) { }
        // RVA: 0x042A2738  token: 0x60006BC
        public static System.Int32 CSharp_StartOutputCapture(System.String jarg1) { }
        // RVA: 0x042A2AE8  token: 0x60006BD
        public static System.Int32 CSharp_StopOutputCapture() { }
        // RVA: 0x0428D7DC  token: 0x60006BE
        public static System.Int32 CSharp_AddOutputCaptureMarker(System.String jarg1) { }
        // RVA: 0x0428D79C  token: 0x60006BF
        public static System.Int32 CSharp_AddOutputCaptureBinaryMarker(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0429B350  token: 0x60006C0
        public static System.UInt32 CSharp_GetSampleRate() { }
        // RVA: 0x042A27E0  token: 0x60006C1
        public static System.Int32 CSharp_StartProfilerCapture(System.String jarg1) { }
        // RVA: 0x042A2CC4  token: 0x60006C2
        public static System.Int32 CSharp_StopProfilerCapture() { }
        // RVA: 0x042A1A18  token: 0x60006C3
        public static System.Int32 CSharp_SetOfflineRenderingFrameTime(System.Single jarg1) { }
        // RVA: 0x042A1A4C  token: 0x60006C4
        public static System.Int32 CSharp_SetOfflineRendering(System.Boolean jarg1) { }
        // RVA: 0x0429F07C  token: 0x60006C5
        public static System.Int32 CSharp_RemoveOutput(System.UInt64 jarg1) { }
        // RVA: 0x0429F1D4  token: 0x60006C6
        public static System.Int32 CSharp_ReplaceOutput__SWIG_0(System.IntPtr jarg1, System.UInt64 jarg2, System.UInt64& jarg3) { }
        // RVA: 0x0429F264  token: 0x60006C7
        public static System.Int32 CSharp_ReplaceOutput__SWIG_1(System.IntPtr jarg1, System.UInt64 jarg2) { }
        // RVA: 0x0429AC94  token: 0x60006C8
        public static System.UInt64 CSharp_GetOutputID__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0429AD14  token: 0x60006C9
        public static System.UInt64 CSharp_GetOutputID__SWIG_1(System.String jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042A0904  token: 0x60006CA
        public static System.Int32 CSharp_SetBusDevice__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042A0984  token: 0x60006CB
        public static System.Int32 CSharp_SetBusDevice__SWIG_1(System.String jarg1, System.String jarg2) { }
        // RVA: 0x0429A5F8  token: 0x60006CC
        public static System.Int32 CSharp_GetDeviceList__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt32& jarg3, System.IntPtr jarg4) { }
        // RVA: 0x03618250  token: 0x60006CD
        public static System.Int32 CSharp_GetDeviceList__SWIG_1(System.UInt32 jarg1, System.UInt32& jarg2, System.IntPtr jarg3) { }
        // RVA: 0x042A1B54  token: 0x60006CE
        public static System.Int32 CSharp_SetOutputVolume(System.UInt64 jarg1, System.Single jarg2) { }
        // RVA: 0x036180F0  token: 0x60006CF
        public static System.Int32 CSharp_GetDeviceSpatialAudioSupport(System.UInt32 jarg1) { }
        // RVA: 0x042A2D24  token: 0x60006D0
        public static System.Int32 CSharp_Suspend__SWIG_0(System.Boolean jarg1, System.Boolean jarg2) { }
        // RVA: 0x042A2DA4  token: 0x60006D1
        public static System.Int32 CSharp_Suspend__SWIG_1(System.Boolean jarg1) { }
        // RVA: 0x042A2E1C  token: 0x60006D2
        public static System.Int32 CSharp_Suspend__SWIG_2() { }
        // RVA: 0x042A358C  token: 0x60006D3
        public static System.Int32 CSharp_WakeupFromSuspend__SWIG_0(System.UInt32 jarg1) { }
        // RVA: 0x042A35C0  token: 0x60006D4
        public static System.Int32 CSharp_WakeupFromSuspend__SWIG_1() { }
        // RVA: 0x0429A26C  token: 0x60006D5
        public static System.UInt32 CSharp_GetBufferTick() { }
        // RVA: 0x0429B37C  token: 0x60006D6
        public static System.UInt64 CSharp_GetSampleTick() { }
        // RVA: 0x04297840  token: 0x60006D7
        public static System.Void CSharp_AkSegmentInfo_iCurrentPosition_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x0429780C  token: 0x60006D8
        public static System.Int32 CSharp_AkSegmentInfo_iCurrentPosition_get(System.IntPtr jarg1) { }
        // RVA: 0x04297968  token: 0x60006D9
        public static System.Void CSharp_AkSegmentInfo_iPreEntryDuration_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x04297934  token: 0x60006DA
        public static System.Int32 CSharp_AkSegmentInfo_iPreEntryDuration_get(System.IntPtr jarg1) { }
        // RVA: 0x042977CC  token: 0x60006DB
        public static System.Void CSharp_AkSegmentInfo_iActiveDuration_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x04297798  token: 0x60006DC
        public static System.Int32 CSharp_AkSegmentInfo_iActiveDuration_get(System.IntPtr jarg1) { }
        // RVA: 0x042978F4  token: 0x60006DD
        public static System.Void CSharp_AkSegmentInfo_iPostExitDuration_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x042978C0  token: 0x60006DE
        public static System.Int32 CSharp_AkSegmentInfo_iPostExitDuration_get(System.IntPtr jarg1) { }
        // RVA: 0x042979DC  token: 0x60006DF
        public static System.Void CSharp_AkSegmentInfo_iRemainingLookAheadTime_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x042979A8  token: 0x60006E0
        public static System.Int32 CSharp_AkSegmentInfo_iRemainingLookAheadTime_get(System.IntPtr jarg1) { }
        // RVA: 0x0429766C  token: 0x60006E1
        public static System.Void CSharp_AkSegmentInfo_fBeatDuration_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04297638  token: 0x60006E2
        public static System.Single CSharp_AkSegmentInfo_fBeatDuration_get(System.IntPtr jarg1) { }
        // RVA: 0x042975F4  token: 0x60006E3
        public static System.Void CSharp_AkSegmentInfo_fBarDuration_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x042975C0  token: 0x60006E4
        public static System.Single CSharp_AkSegmentInfo_fBarDuration_get(System.IntPtr jarg1) { }
        // RVA: 0x042976E4  token: 0x60006E5
        public static System.Void CSharp_AkSegmentInfo_fGridDuration_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x042976B0  token: 0x60006E6
        public static System.Single CSharp_AkSegmentInfo_fGridDuration_get(System.IntPtr jarg1) { }
        // RVA: 0x0429775C  token: 0x60006E7
        public static System.Void CSharp_AkSegmentInfo_fGridOffset_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04297728  token: 0x60006E8
        public static System.Single CSharp_AkSegmentInfo_fGridOffset_get(System.IntPtr jarg1) { }
        // RVA: 0x042A55D4  token: 0x60006E9
        public static System.IntPtr CSharp_new_AkSegmentInfo() { }
        // RVA: 0x042A423C  token: 0x60006EA
        public static System.Void CSharp_delete_AkSegmentInfo(System.IntPtr jarg1) { }
        // RVA: 0x04297238  token: 0x60006EB
        public static System.Void CSharp_AkResourceMonitorDataSummary_totalCPU_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04297204  token: 0x60006EC
        public static System.Single CSharp_AkResourceMonitorDataSummary_totalCPU_get(System.IntPtr jarg1) { }
        // RVA: 0x042971C8  token: 0x60006ED
        public static System.Void CSharp_AkResourceMonitorDataSummary_pluginCPU_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04297194  token: 0x60006EE
        public static System.Single CSharp_AkResourceMonitorDataSummary_pluginCPU_get(System.IntPtr jarg1) { }
        // RVA: 0x04297154  token: 0x60006EF
        public static System.Void CSharp_AkResourceMonitorDataSummary_physicalVoices_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04297120  token: 0x60006F0
        public static System.UInt32 CSharp_AkResourceMonitorDataSummary_physicalVoices_get(System.IntPtr jarg1) { }
        // RVA: 0x04297324  token: 0x60006F1
        public static System.Void CSharp_AkResourceMonitorDataSummary_virtualVoices_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042972F0  token: 0x60006F2
        public static System.UInt32 CSharp_AkResourceMonitorDataSummary_virtualVoices_get(System.IntPtr jarg1) { }
        // RVA: 0x042972B0  token: 0x60006F3
        public static System.Void CSharp_AkResourceMonitorDataSummary_totalVoices_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0429727C  token: 0x60006F4
        public static System.UInt32 CSharp_AkResourceMonitorDataSummary_totalVoices_get(System.IntPtr jarg1) { }
        // RVA: 0x042970E0  token: 0x60006F5
        public static System.Void CSharp_AkResourceMonitorDataSummary_nbActiveEvents_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042970AC  token: 0x60006F6
        public static System.UInt32 CSharp_AkResourceMonitorDataSummary_nbActiveEvents_get(System.IntPtr jarg1) { }
        // RVA: 0x042A55A8  token: 0x60006F7
        public static System.IntPtr CSharp_new_AkResourceMonitorDataSummary() { }
        // RVA: 0x042A41D4  token: 0x60006F8
        public static System.Void CSharp_delete_AkResourceMonitorDataSummary(System.IntPtr jarg1) { }
        // RVA: 0x0428D308  token: 0x60006F9
        public static System.Byte CSharp_AK_INVALID_MIDI_CHANNEL_get() { }
        // RVA: 0x0428D370  token: 0x60006FA
        public static System.Byte CSharp_AK_INVALID_MIDI_NOTE_get() { }
        // RVA: 0x04292968  token: 0x60006FB
        public static System.Void CSharp_AkMIDIEvent_byChan_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04292934  token: 0x60006FC
        public static System.Byte CSharp_AkMIDIEvent_byChan_get(System.IntPtr jarg1) { }
        // RVA: 0x04292F6C  token: 0x60006FD
        public static System.Void CSharp_AkMIDIEvent_tGen_byParam1_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04292F38  token: 0x60006FE
        public static System.Byte CSharp_AkMIDIEvent_tGen_byParam1_get(System.IntPtr jarg1) { }
        // RVA: 0x04293024  token: 0x60006FF
        public static System.Void CSharp_AkMIDIEvent_tGen_byParam2_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04292FAC  token: 0x6000700
        public static System.Byte CSharp_AkMIDIEvent_tGen_byParam2_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4E7C  token: 0x6000701
        public static System.IntPtr CSharp_new_AkMIDIEvent_tGen() { }
        // RVA: 0x042A3CC0  token: 0x6000702
        public static System.Void CSharp_delete_AkMIDIEvent_tGen(System.IntPtr jarg1) { }
        // RVA: 0x042931C4  token: 0x6000703
        public static System.Void CSharp_AkMIDIEvent_tNoteOnOff_byNote_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04293190  token: 0x6000704
        public static System.Byte CSharp_AkMIDIEvent_tNoteOnOff_byNote_get(System.IntPtr jarg1) { }
        // RVA: 0x04293238  token: 0x6000705
        public static System.Void CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04293204  token: 0x6000706
        public static System.Byte CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4ED4  token: 0x6000707
        public static System.IntPtr CSharp_new_AkMIDIEvent_tNoteOnOff() { }
        // RVA: 0x042A3D28  token: 0x6000708
        public static System.Void CSharp_delete_AkMIDIEvent_tNoteOnOff(System.IntPtr jarg1) { }
        // RVA: 0x04292D8C  token: 0x6000709
        public static System.Void CSharp_AkMIDIEvent_tCc_byCc_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04292D58  token: 0x600070A
        public static System.Byte CSharp_AkMIDIEvent_tCc_byCc_get(System.IntPtr jarg1) { }
        // RVA: 0x04292E44  token: 0x600070B
        public static System.Void CSharp_AkMIDIEvent_tCc_byValue_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04292DCC  token: 0x600070C
        public static System.Byte CSharp_AkMIDIEvent_tCc_byValue_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4E24  token: 0x600070D
        public static System.IntPtr CSharp_new_AkMIDIEvent_tCc() { }
        // RVA: 0x042A3C58  token: 0x600070E
        public static System.Void CSharp_delete_AkMIDIEvent_tCc(System.IntPtr jarg1) { }
        // RVA: 0x042932EC  token: 0x600070F
        public static System.Void CSharp_AkMIDIEvent_tPitchBend_byValueLsb_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x042932B8  token: 0x6000710
        public static System.Byte CSharp_AkMIDIEvent_tPitchBend_byValueLsb_get(System.IntPtr jarg1) { }
        // RVA: 0x042933A0  token: 0x6000711
        public static System.Void CSharp_AkMIDIEvent_tPitchBend_byValueMsb_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x0429336C  token: 0x6000712
        public static System.Byte CSharp_AkMIDIEvent_tPitchBend_byValueMsb_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4F00  token: 0x6000713
        public static System.IntPtr CSharp_new_AkMIDIEvent_tPitchBend() { }
        // RVA: 0x042A3D5C  token: 0x6000714
        public static System.Void CSharp_delete_AkMIDIEvent_tPitchBend(System.IntPtr jarg1) { }
        // RVA: 0x04293098  token: 0x6000715
        public static System.Void CSharp_AkMIDIEvent_tNoteAftertouch_byNote_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04293064  token: 0x6000716
        public static System.Byte CSharp_AkMIDIEvent_tNoteAftertouch_byNote_get(System.IntPtr jarg1) { }
        // RVA: 0x04293150  token: 0x6000717
        public static System.Void CSharp_AkMIDIEvent_tNoteAftertouch_byValue_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x042930D8  token: 0x6000718
        public static System.Byte CSharp_AkMIDIEvent_tNoteAftertouch_byValue_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4EA8  token: 0x6000719
        public static System.IntPtr CSharp_new_AkMIDIEvent_tNoteAftertouch() { }
        // RVA: 0x042A3CF4  token: 0x600071A
        public static System.Void CSharp_delete_AkMIDIEvent_tNoteAftertouch(System.IntPtr jarg1) { }
        // RVA: 0x04292EF8  token: 0x600071B
        public static System.Void CSharp_AkMIDIEvent_tChanAftertouch_byValue_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04292EC4  token: 0x600071C
        public static System.Byte CSharp_AkMIDIEvent_tChanAftertouch_byValue_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4E50  token: 0x600071D
        public static System.IntPtr CSharp_new_AkMIDIEvent_tChanAftertouch() { }
        // RVA: 0x042A3C8C  token: 0x600071E
        public static System.Void CSharp_delete_AkMIDIEvent_tChanAftertouch(System.IntPtr jarg1) { }
        // RVA: 0x04293498  token: 0x600071F
        public static System.Void CSharp_AkMIDIEvent_tProgramChange_byProgramNum_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04293420  token: 0x6000720
        public static System.Byte CSharp_AkMIDIEvent_tProgramChange_byProgramNum_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4F2C  token: 0x6000721
        public static System.IntPtr CSharp_new_AkMIDIEvent_tProgramChange() { }
        // RVA: 0x042A3D90  token: 0x6000722
        public static System.Void CSharp_delete_AkMIDIEvent_tProgramChange(System.IntPtr jarg1) { }
        // RVA: 0x042935C0  token: 0x6000723
        public static System.Void CSharp_AkMIDIEvent_tWwiseCmd_uCmd_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        // RVA: 0x0429358C  token: 0x6000724
        public static System.UInt16 CSharp_AkMIDIEvent_tWwiseCmd_uCmd_get(System.IntPtr jarg1) { }
        // RVA: 0x0429350C  token: 0x6000725
        public static System.Void CSharp_AkMIDIEvent_tWwiseCmd_uArg_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042934D8  token: 0x6000726
        public static System.UInt32 CSharp_AkMIDIEvent_tWwiseCmd_uArg_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4F58  token: 0x6000727
        public static System.IntPtr CSharp_new_AkMIDIEvent_tWwiseCmd() { }
        // RVA: 0x042A3DC4  token: 0x6000728
        public static System.Void CSharp_delete_AkMIDIEvent_tWwiseCmd(System.IntPtr jarg1) { }
        // RVA: 0x042923B0  token: 0x6000729
        public static System.Void CSharp_AkMIDIEvent_Gen_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x0429237C  token: 0x600072A
        public static System.IntPtr CSharp_AkMIDIEvent_Gen_get(System.IntPtr jarg1) { }
        // RVA: 0x04292278  token: 0x600072B
        public static System.Void CSharp_AkMIDIEvent_Cc_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04292244  token: 0x600072C
        public static System.IntPtr CSharp_AkMIDIEvent_Cc_get(System.IntPtr jarg1) { }
        // RVA: 0x042924A0  token: 0x600072D
        public static System.Void CSharp_AkMIDIEvent_NoteOnOff_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x0429246C  token: 0x600072E
        public static System.IntPtr CSharp_AkMIDIEvent_NoteOnOff_get(System.IntPtr jarg1) { }
        // RVA: 0x04292520  token: 0x600072F
        public static System.Void CSharp_AkMIDIEvent_PitchBend_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042924E4  token: 0x6000730
        public static System.IntPtr CSharp_AkMIDIEvent_PitchBend_get(System.IntPtr jarg1) { }
        // RVA: 0x04292428  token: 0x6000731
        public static System.Void CSharp_AkMIDIEvent_NoteAftertouch_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042923F4  token: 0x6000732
        public static System.IntPtr CSharp_AkMIDIEvent_NoteAftertouch_get(System.IntPtr jarg1) { }
        // RVA: 0x04292338  token: 0x6000733
        public static System.Void CSharp_AkMIDIEvent_ChanAftertouch_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042922FC  token: 0x6000734
        public static System.IntPtr CSharp_AkMIDIEvent_ChanAftertouch_get(System.IntPtr jarg1) { }
        // RVA: 0x04292598  token: 0x6000735
        public static System.Void CSharp_AkMIDIEvent_ProgramChange_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04292564  token: 0x6000736
        public static System.IntPtr CSharp_AkMIDIEvent_ProgramChange_get(System.IntPtr jarg1) { }
        // RVA: 0x04292618  token: 0x6000737
        public static System.Void CSharp_AkMIDIEvent_WwiseCmd_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042925DC  token: 0x6000738
        public static System.IntPtr CSharp_AkMIDIEvent_WwiseCmd_get(System.IntPtr jarg1) { }
        // RVA: 0x04292BBC  token: 0x6000739
        public static System.Void CSharp_AkMIDIEvent_byType_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x04292B88  token: 0x600073A
        public static System.Int32 CSharp_AkMIDIEvent_byType_get(System.IntPtr jarg1) { }
        // RVA: 0x04292A94  token: 0x600073B
        public static System.Void CSharp_AkMIDIEvent_byOnOffNote_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04292A60  token: 0x600073C
        public static System.Byte CSharp_AkMIDIEvent_byOnOffNote_get(System.IntPtr jarg1) { }
        // RVA: 0x04292D18  token: 0x600073D
        public static System.Void CSharp_AkMIDIEvent_byVelocity_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04292CE4  token: 0x600073E
        public static System.Byte CSharp_AkMIDIEvent_byVelocity_get(System.IntPtr jarg1) { }
        // RVA: 0x042927FC  token: 0x600073F
        public static System.Void CSharp_AkMIDIEvent_byCc_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x042927C8  token: 0x6000740
        public static System.Int32 CSharp_AkMIDIEvent_byCc_get(System.IntPtr jarg1) { }
        // RVA: 0x04292788  token: 0x6000741
        public static System.Void CSharp_AkMIDIEvent_byCcValue_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04292710  token: 0x6000742
        public static System.Byte CSharp_AkMIDIEvent_byCcValue_get(System.IntPtr jarg1) { }
        // RVA: 0x04292C30  token: 0x6000743
        public static System.Void CSharp_AkMIDIEvent_byValueLsb_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04292BFC  token: 0x6000744
        public static System.Byte CSharp_AkMIDIEvent_byValueLsb_get(System.IntPtr jarg1) { }
        // RVA: 0x04292CA4  token: 0x6000745
        public static System.Void CSharp_AkMIDIEvent_byValueMsb_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04292C70  token: 0x6000746
        public static System.Byte CSharp_AkMIDIEvent_byValueMsb_get(System.IntPtr jarg1) { }
        // RVA: 0x04292690  token: 0x6000747
        public static System.Void CSharp_AkMIDIEvent_byAftertouchNote_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x0429265C  token: 0x6000748
        public static System.Byte CSharp_AkMIDIEvent_byAftertouchNote_get(System.IntPtr jarg1) { }
        // RVA: 0x04292A20  token: 0x6000749
        public static System.Void CSharp_AkMIDIEvent_byNoteAftertouchValue_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x042929A8  token: 0x600074A
        public static System.Byte CSharp_AkMIDIEvent_byNoteAftertouchValue_get(System.IntPtr jarg1) { }
        // RVA: 0x042928B4  token: 0x600074B
        public static System.Void CSharp_AkMIDIEvent_byChanAftertouchValue_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x0429283C  token: 0x600074C
        public static System.Byte CSharp_AkMIDIEvent_byChanAftertouchValue_get(System.IntPtr jarg1) { }
        // RVA: 0x04292B48  token: 0x600074D
        public static System.Void CSharp_AkMIDIEvent_byProgramNum_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04292B14  token: 0x600074E
        public static System.Byte CSharp_AkMIDIEvent_byProgramNum_get(System.IntPtr jarg1) { }
        // RVA: 0x04293730  token: 0x600074F
        public static System.Void CSharp_AkMIDIEvent_uCmd_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        // RVA: 0x042936B8  token: 0x6000750
        public static System.UInt16 CSharp_AkMIDIEvent_uCmd_get(System.IntPtr jarg1) { }
        // RVA: 0x04293678  token: 0x6000751
        public static System.Void CSharp_AkMIDIEvent_uArg_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04293644  token: 0x6000752
        public static System.UInt32 CSharp_AkMIDIEvent_uArg_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4DF8  token: 0x6000753
        public static System.IntPtr CSharp_new_AkMIDIEvent() { }
        // RVA: 0x042A3C24  token: 0x6000754
        public static System.Void CSharp_delete_AkMIDIEvent(System.IntPtr jarg1) { }
        // RVA: 0x04293B84  token: 0x6000755
        public static System.Void CSharp_AkMIDIPost_uOffset_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        // RVA: 0x04293B0C  token: 0x6000756
        public static System.UInt64 CSharp_AkMIDIPost_uOffset_get(System.IntPtr jarg1) { }
        // RVA: 0x04293824  token: 0x6000757
        public static System.UInt32 CSharp_AkMIDIPost_PostOnEvent__SWIG_0(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt64 jarg3, System.UInt32 jarg4) { }
        // RVA: 0x042938C4  token: 0x6000758
        public static System.UInt32 CSharp_AkMIDIPost_PostOnEvent__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt64 jarg3, System.UInt32 jarg4, System.Boolean jarg5) { }
        // RVA: 0x04293974  token: 0x6000759
        public static System.UInt32 CSharp_AkMIDIPost_PostOnEvent__SWIG_2(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt64 jarg3, System.UInt32 jarg4, System.Boolean jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.IntPtr jarg8) { }
        // RVA: 0x04293A24  token: 0x600075A
        public static System.UInt32 CSharp_AkMIDIPost_PostOnEvent__SWIG_3(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt64 jarg3, System.UInt32 jarg4, System.Boolean jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.IntPtr jarg8, System.UInt32 jarg9) { }
        // RVA: 0x042937B4  token: 0x600075B
        public static System.Void CSharp_AkMIDIPost_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042937F8  token: 0x600075C
        public static System.Int32 CSharp_AkMIDIPost_GetSizeOf() { }
        // RVA: 0x042A4F8C  token: 0x600075D
        public static System.IntPtr CSharp_new_AkMIDIPost() { }
        // RVA: 0x042A3DF8  token: 0x600075E
        public static System.Void CSharp_delete_AkMIDIPost(System.IntPtr jarg1) { }
        // RVA: 0x04293E7C  token: 0x600075F
        public static System.Void CSharp_AkMemCategroyStats_uUsed_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        // RVA: 0x04293E48  token: 0x6000760
        public static System.UInt64 CSharp_AkMemCategroyStats_uUsed_get(System.IntPtr jarg1) { }
        // RVA: 0x04293DC4  token: 0x6000761
        public static System.Void CSharp_AkMemCategroyStats_uPeakUsed_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        // RVA: 0x04293D4C  token: 0x6000762
        public static System.UInt64 CSharp_AkMemCategroyStats_uPeakUsed_get(System.IntPtr jarg1) { }
        // RVA: 0x04293C98  token: 0x6000763
        public static System.Void CSharp_AkMemCategroyStats_uAllocs_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04293C64  token: 0x6000764
        public static System.UInt32 CSharp_AkMemCategroyStats_uAllocs_get(System.IntPtr jarg1) { }
        // RVA: 0x04293D0C  token: 0x6000765
        public static System.Void CSharp_AkMemCategroyStats_uFrees_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04293CD8  token: 0x6000766
        public static System.UInt32 CSharp_AkMemCategroyStats_uFrees_get(System.IntPtr jarg1) { }
        // RVA: 0x03B38080  token: 0x6000767
        public static System.IntPtr CSharp_new_AkMemCategroyStats() { }
        // RVA: 0x042A3E60  token: 0x6000768
        public static System.Void CSharp_delete_AkMemCategroyStats(System.IntPtr jarg1) { }
        // RVA: 0x0429429C  token: 0x6000769
        public static System.Void CSharp_AkMemGlobalStats_uUsed_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        // RVA: 0x04294224  token: 0x600076A
        public static System.UInt64 CSharp_AkMemGlobalStats_uUsed_get(System.IntPtr jarg1) { }
        // RVA: 0x04293FE8  token: 0x600076B
        public static System.Void CSharp_AkMemGlobalStats_uDeviceUsed_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        // RVA: 0x04293FB4  token: 0x600076C
        public static System.UInt64 CSharp_AkMemGlobalStats_uDeviceUsed_get(System.IntPtr jarg1) { }
        // RVA: 0x042941A0  token: 0x600076D
        public static System.Void CSharp_AkMemGlobalStats_uReserved_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        // RVA: 0x04294128  token: 0x600076E
        public static System.UInt64 CSharp_AkMemGlobalStats_uReserved_get(System.IntPtr jarg1) { }
        // RVA: 0x042940E4  token: 0x600076F
        public static System.Void CSharp_AkMemGlobalStats_uMax_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        // RVA: 0x0429406C  token: 0x6000770
        public static System.UInt64 CSharp_AkMemGlobalStats_uMax_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4FE4  token: 0x6000771
        public static System.IntPtr CSharp_new_AkMemGlobalStats() { }
        // RVA: 0x042A3E94  token: 0x6000772
        public static System.Void CSharp_delete_AkMemGlobalStats(System.IntPtr jarg1) { }
        // RVA: 0x04293F00  token: 0x6000773
        public static System.Void CSharp_AkMemGetCategoryStats(System.Int32 jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04293F80  token: 0x6000774
        public static System.Void CSharp_AkMemGetGlobalStats(System.IntPtr jarg1) { }
        // RVA: 0x042A27B4  token: 0x6000775
        public static System.Void CSharp_StartProfileThreadUsage() { }
        // RVA: 0x042A2C98  token: 0x6000776
        public static System.UInt64 CSharp_StopProfileThreadUsage() { }
        // RVA: 0x042990D8  token: 0x6000777
        public static System.Void CSharp_DumpToFile(System.String jarg1) { }
        // RVA: 0x0429A9AC  token: 0x6000778
        public static System.UInt64 CSharp_GetGlobalUsed() { }
        // RVA: 0x0429A944  token: 0x6000779
        public static System.UInt64 CSharp_GetGlobalReserved() { }
        // RVA: 0x02A043A0  token: 0x600077A
        public static System.Void CSharp_AkMusicSettings_fStreamingLookAheadRatio_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04294540  token: 0x600077B
        public static System.Single CSharp_AkMusicSettings_fStreamingLookAheadRatio_get(System.IntPtr jarg1) { }
        // RVA: 0x042A3F30  token: 0x600077C
        public static System.Void CSharp_delete_AkMusicSettings(System.IntPtr jarg1) { }
        // RVA: 0x0429AFBC  token: 0x600077D
        public static System.Int32 CSharp_GetPlayingSegmentInfo__SWIG_0(System.UInt32 jarg1, System.IntPtr jarg2, System.Boolean jarg3) { }
        // RVA: 0x0429B04C  token: 0x600077E
        public static System.Int32 CSharp_GetPlayingSegmentInfo__SWIG_1(System.UInt32 jarg1, System.IntPtr jarg2) { }
        // RVA: 0x0269D860  token: 0x600077F
        public static System.IntPtr CSharp_AkSerializedCallbackHeader_pPackage_get(System.IntPtr jarg1) { }
        // RVA: 0x0269D920  token: 0x6000780
        public static System.UInt32 CSharp_AkSerializedCallbackHeader_eType_get(System.IntPtr jarg1) { }
        // RVA: 0x0269D820  token: 0x6000781
        public static System.IntPtr CSharp_AkSerializedCallbackHeader_GetData(System.IntPtr jarg1) { }
        // RVA: 0x0269D8A0  token: 0x6000782
        public static System.IntPtr CSharp_AkSerializedCallbackHeader_pNext_get(System.IntPtr jarg1) { }
        // RVA: 0x042A5600  token: 0x6000783
        public static System.IntPtr CSharp_new_AkSerializedCallbackHeader() { }
        // RVA: 0x042A4270  token: 0x6000784
        public static System.Void CSharp_delete_AkSerializedCallbackHeader(System.IntPtr jarg1) { }
        // RVA: 0x0269F720  token: 0x6000785
        public static System.IntPtr CSharp_AkCallbackInfo_pCookie_get(System.IntPtr jarg1) { }
        // RVA: 0x0269F810  token: 0x6000786
        public static System.UInt64 CSharp_AkCallbackInfo_gameObjID_get(System.IntPtr jarg1) { }
        // RVA: 0x042A47D4  token: 0x6000787
        public static System.IntPtr CSharp_new_AkCallbackInfo() { }
        // RVA: 0x042A387C  token: 0x6000788
        public static System.Void CSharp_delete_AkCallbackInfo(System.IntPtr jarg1) { }
        // RVA: 0x042908B0  token: 0x6000789
        public static System.UInt32 CSharp_AkEventCallbackInfo_playingID_get(System.IntPtr jarg1) { }
        // RVA: 0x0269F8B0  token: 0x600078A
        public static System.UInt32 CSharp_AkEventCallbackInfo_eventID_get(System.IntPtr jarg1) { }
        // RVA: 0x042A49B4  token: 0x600078B
        public static System.IntPtr CSharp_new_AkEventCallbackInfo() { }
        // RVA: 0x042A3A50  token: 0x600078C
        public static System.Void CSharp_delete_AkEventCallbackInfo(System.IntPtr jarg1) { }
        // RVA: 0x04291F70  token: 0x600078D
        public static System.Byte CSharp_AkMIDIEventCallbackInfo_byChan_get(System.IntPtr jarg1) { }
        // RVA: 0x0429200C  token: 0x600078E
        public static System.Byte CSharp_AkMIDIEventCallbackInfo_byParam1_get(System.IntPtr jarg1) { }
        // RVA: 0x04292040  token: 0x600078F
        public static System.Byte CSharp_AkMIDIEventCallbackInfo_byParam2_get(System.IntPtr jarg1) { }
        // RVA: 0x042920EC  token: 0x6000790
        public static System.Int32 CSharp_AkMIDIEventCallbackInfo_byType_get(System.IntPtr jarg1) { }
        // RVA: 0x04291FD8  token: 0x6000791
        public static System.Byte CSharp_AkMIDIEventCallbackInfo_byOnOffNote_get(System.IntPtr jarg1) { }
        // RVA: 0x042921CC  token: 0x6000792
        public static System.Byte CSharp_AkMIDIEventCallbackInfo_byVelocity_get(System.IntPtr jarg1) { }
        // RVA: 0x04291F08  token: 0x6000793
        public static System.Int32 CSharp_AkMIDIEventCallbackInfo_byCc_get(System.IntPtr jarg1) { }
        // RVA: 0x04291ED4  token: 0x6000794
        public static System.Byte CSharp_AkMIDIEventCallbackInfo_byCcValue_get(System.IntPtr jarg1) { }
        // RVA: 0x04292120  token: 0x6000795
        public static System.Byte CSharp_AkMIDIEventCallbackInfo_byValueLsb_get(System.IntPtr jarg1) { }
        // RVA: 0x04292198  token: 0x6000796
        public static System.Byte CSharp_AkMIDIEventCallbackInfo_byValueMsb_get(System.IntPtr jarg1) { }
        // RVA: 0x04291EA0  token: 0x6000797
        public static System.Byte CSharp_AkMIDIEventCallbackInfo_byAftertouchNote_get(System.IntPtr jarg1) { }
        // RVA: 0x04291FA4  token: 0x6000798
        public static System.Byte CSharp_AkMIDIEventCallbackInfo_byNoteAftertouchValue_get(System.IntPtr jarg1) { }
        // RVA: 0x04291F3C  token: 0x6000799
        public static System.Byte CSharp_AkMIDIEventCallbackInfo_byChanAftertouchValue_get(System.IntPtr jarg1) { }
        // RVA: 0x042920B8  token: 0x600079A
        public static System.Byte CSharp_AkMIDIEventCallbackInfo_byProgramNum_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4DCC  token: 0x600079B
        public static System.IntPtr CSharp_new_AkMIDIEventCallbackInfo() { }
        // RVA: 0x042A3BF0  token: 0x600079C
        public static System.Void CSharp_delete_AkMIDIEventCallbackInfo(System.IntPtr jarg1) { }
        // RVA: 0x04293BFC  token: 0x600079D
        public static System.UInt32 CSharp_AkMarkerCallbackInfo_uIdentifier_get(System.IntPtr jarg1) { }
        // RVA: 0x04293C30  token: 0x600079E
        public static System.UInt32 CSharp_AkMarkerCallbackInfo_uPosition_get(System.IntPtr jarg1) { }
        // RVA: 0x04293BC8  token: 0x600079F
        public static System.IntPtr CSharp_AkMarkerCallbackInfo_strLabel_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4FB8  token: 0x60007A0
        public static System.IntPtr CSharp_new_AkMarkerCallbackInfo() { }
        // RVA: 0x042A3E2C  token: 0x60007A1
        public static System.Void CSharp_delete_AkMarkerCallbackInfo(System.IntPtr jarg1) { }
        // RVA: 0x04290770  token: 0x60007A2
        public static System.Single CSharp_AkDurationCallbackInfo_fDuration_get(System.IntPtr jarg1) { }
        // RVA: 0x042907A4  token: 0x60007A3
        public static System.Single CSharp_AkDurationCallbackInfo_fEstimatedDuration_get(System.IntPtr jarg1) { }
        // RVA: 0x04290704  token: 0x60007A4
        public static System.UInt32 CSharp_AkDurationCallbackInfo_audioNodeID_get(System.IntPtr jarg1) { }
        // RVA: 0x042907D8  token: 0x60007A5
        public static System.UInt32 CSharp_AkDurationCallbackInfo_mediaID_get(System.IntPtr jarg1) { }
        // RVA: 0x04290738  token: 0x60007A6
        public static System.Boolean CSharp_AkDurationCallbackInfo_bStreaming_get(System.IntPtr jarg1) { }
        // RVA: 0x042A495C  token: 0x60007A7
        public static System.IntPtr CSharp_new_AkDurationCallbackInfo() { }
        // RVA: 0x042A39E8  token: 0x60007A8
        public static System.Void CSharp_delete_AkDurationCallbackInfo(System.IntPtr jarg1) { }
        // RVA: 0x0429087C  token: 0x60007A9
        public static System.UInt32 CSharp_AkDynamicSequenceItemCallbackInfo_playingID_get(System.IntPtr jarg1) { }
        // RVA: 0x0429080C  token: 0x60007AA
        public static System.UInt32 CSharp_AkDynamicSequenceItemCallbackInfo_audioNodeID_get(System.IntPtr jarg1) { }
        // RVA: 0x04290840  token: 0x60007AB
        public static System.IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_pCustomInfo_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4988  token: 0x60007AC
        public static System.IntPtr CSharp_new_AkDynamicSequenceItemCallbackInfo() { }
        // RVA: 0x042A3A1C  token: 0x60007AD
        public static System.Void CSharp_delete_AkDynamicSequenceItemCallbackInfo(System.IntPtr jarg1) { }
        // RVA: 0x042945A8  token: 0x60007AE
        public static System.UInt32 CSharp_AkMusicSyncCallbackInfo_playingID_get(System.IntPtr jarg1) { }
        // RVA: 0x042946E0  token: 0x60007AF
        public static System.Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iCurrentPosition_get(System.IntPtr jarg1) { }
        // RVA: 0x04294748  token: 0x60007B0
        public static System.Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPreEntryDuration_get(System.IntPtr jarg1) { }
        // RVA: 0x042946AC  token: 0x60007B1
        public static System.Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iActiveDuration_get(System.IntPtr jarg1) { }
        // RVA: 0x04294714  token: 0x60007B2
        public static System.Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPostExitDuration_get(System.IntPtr jarg1) { }
        // RVA: 0x0429477C  token: 0x60007B3
        public static System.Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iRemainingLookAheadTime_get(System.IntPtr jarg1) { }
        // RVA: 0x04294610  token: 0x60007B4
        public static System.Single CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBeatDuration_get(System.IntPtr jarg1) { }
        // RVA: 0x042945DC  token: 0x60007B5
        public static System.Single CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBarDuration_get(System.IntPtr jarg1) { }
        // RVA: 0x04294644  token: 0x60007B6
        public static System.Single CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridDuration_get(System.IntPtr jarg1) { }
        // RVA: 0x04294678  token: 0x60007B7
        public static System.Single CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridOffset_get(System.IntPtr jarg1) { }
        // RVA: 0x04294574  token: 0x60007B8
        public static System.Int32 CSharp_AkMusicSyncCallbackInfo_musicSyncType_get(System.IntPtr jarg1) { }
        // RVA: 0x042947B0  token: 0x60007B9
        public static System.IntPtr CSharp_AkMusicSyncCallbackInfo_userCueName_get(System.IntPtr jarg1) { }
        // RVA: 0x042A5068  token: 0x60007BA
        public static System.IntPtr CSharp_new_AkMusicSyncCallbackInfo() { }
        // RVA: 0x042A3F64  token: 0x60007BB
        public static System.Void CSharp_delete_AkMusicSyncCallbackInfo(System.IntPtr jarg1) { }
        // RVA: 0x04294470  token: 0x60007BC
        public static System.UInt32 CSharp_AkMusicPlaylistCallbackInfo_playlistID_get(System.IntPtr jarg1) { }
        // RVA: 0x042944A4  token: 0x60007BD
        public static System.UInt32 CSharp_AkMusicPlaylistCallbackInfo_uNumPlaylistItems_get(System.IntPtr jarg1) { }
        // RVA: 0x0429450C  token: 0x60007BE
        public static System.UInt32 CSharp_AkMusicPlaylistCallbackInfo_uPlaylistSelection_get(System.IntPtr jarg1) { }
        // RVA: 0x042944D8  token: 0x60007BF
        public static System.UInt32 CSharp_AkMusicPlaylistCallbackInfo_uPlaylistItemDone_get(System.IntPtr jarg1) { }
        // RVA: 0x042A503C  token: 0x60007C0
        public static System.IntPtr CSharp_new_AkMusicPlaylistCallbackInfo() { }
        // RVA: 0x042A3EFC  token: 0x60007C1
        public static System.Void CSharp_delete_AkMusicPlaylistCallbackInfo(System.IntPtr jarg1) { }
        // RVA: 0x0269B0F0  token: 0x60007C2
        public static System.UInt32 CSharp_AkBankCallbackInfo_bankID_get(System.IntPtr jarg1) { }
        // RVA: 0x0269AFB0  token: 0x60007C3
        public static System.IntPtr CSharp_AkBankCallbackInfo_inMemoryBankPtr_get(System.IntPtr jarg1) { }
        // RVA: 0x0269B050  token: 0x60007C4
        public static System.Int32 CSharp_AkBankCallbackInfo_loadResult_get(System.IntPtr jarg1) { }
        // RVA: 0x042A477C  token: 0x60007C5
        public static System.IntPtr CSharp_new_AkBankCallbackInfo() { }
        // RVA: 0x042A3814  token: 0x60007C6
        public static System.Void CSharp_delete_AkBankCallbackInfo(System.IntPtr jarg1) { }
        // RVA: 0x04294320  token: 0x60007C7
        public static System.Int32 CSharp_AkMonitoringCallbackInfo_errorCode_get(System.IntPtr jarg1) { }
        // RVA: 0x04294354  token: 0x60007C8
        public static System.Int32 CSharp_AkMonitoringCallbackInfo_errorLevel_get(System.IntPtr jarg1) { }
        // RVA: 0x0429443C  token: 0x60007C9
        public static System.UInt32 CSharp_AkMonitoringCallbackInfo_playingID_get(System.IntPtr jarg1) { }
        // RVA: 0x04294388  token: 0x60007CA
        public static System.UInt64 CSharp_AkMonitoringCallbackInfo_gameObjID_get(System.IntPtr jarg1) { }
        // RVA: 0x04294400  token: 0x60007CB
        public static System.IntPtr CSharp_AkMonitoringCallbackInfo_message_get(System.IntPtr jarg1) { }
        // RVA: 0x042A5010  token: 0x60007CC
        public static System.IntPtr CSharp_new_AkMonitoringCallbackInfo() { }
        // RVA: 0x042A3EC8  token: 0x60007CD
        public static System.Void CSharp_delete_AkMonitoringCallbackInfo(System.IntPtr jarg1) { }
        // RVA: 0x0428E548  token: 0x60007CE
        public static System.Boolean CSharp_AkAudioInterruptionCallbackInfo_bEnterInterruption_get(System.IntPtr jarg1) { }
        // RVA: 0x042A46F8  token: 0x60007CF
        public static System.IntPtr CSharp_new_AkAudioInterruptionCallbackInfo() { }
        // RVA: 0x042A3744  token: 0x60007D0
        public static System.Void CSharp_delete_AkAudioInterruptionCallbackInfo(System.IntPtr jarg1) { }
        // RVA: 0x0428E668  token: 0x60007D1
        public static System.Boolean CSharp_AkAudioSourceChangeCallbackInfo_bOtherAudioPlaying_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4750  token: 0x60007D2
        public static System.IntPtr CSharp_new_AkAudioSourceChangeCallbackInfo() { }
        // RVA: 0x042A37AC  token: 0x60007D3
        public static System.Void CSharp_delete_AkAudioSourceChangeCallbackInfo(System.IntPtr jarg1) { }
        // RVA: 0x02A01D70  token: 0x60007D4
        public static System.Int32 CSharp_AkCallbackSerializer_Init() { }
        // RVA: 0x0428EEE8  token: 0x60007D5
        public static System.Void CSharp_AkCallbackSerializer_Term() { }
        // RVA: 0x0269D170  token: 0x60007D6
        public static System.IntPtr CSharp_AkCallbackSerializer_Lock() { }
        // RVA: 0x03020390  token: 0x60007D7
        public static System.Void CSharp_AkCallbackSerializer_Unlock() { }
        // RVA: 0x0428EE0C  token: 0x60007D8
        public static System.Void CSharp_AkCallbackSerializer_SetLocalOutput(System.UInt32 jarg1, System.String jarg2, System.UInt32 jarg3, System.String jarg4, System.UInt32 jarg5, System.UInt32 jarg6) { }
        // RVA: 0x0428ED8C  token: 0x60007D9
        public static System.Int32 CSharp_AkCallbackSerializer_AudioSourceChangeCallbackFunc(System.Boolean jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042A4800  token: 0x60007DA
        public static System.IntPtr CSharp_new_AkCallbackSerializer() { }
        // RVA: 0x042A38B0  token: 0x60007DB
        public static System.Void CSharp_delete_AkCallbackSerializer(System.IntPtr jarg1) { }
        // RVA: 0x042A5918  token: 0x60007DC
        public static System.IntPtr CSharp_new_MsgContext__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.Boolean jarg4) { }
        // RVA: 0x042A59B8  token: 0x60007DD
        public static System.IntPtr CSharp_new_MsgContext__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3) { }
        // RVA: 0x042A5A48  token: 0x60007DE
        public static System.IntPtr CSharp_new_MsgContext__SWIG_2(System.UInt32 jarg1, System.UInt64 jarg2) { }
        // RVA: 0x042A5AC8  token: 0x60007DF
        public static System.IntPtr CSharp_new_MsgContext__SWIG_3(System.UInt32 jarg1) { }
        // RVA: 0x042A5B40  token: 0x60007E0
        public static System.IntPtr CSharp_new_MsgContext__SWIG_4() { }
        // RVA: 0x0429CE6C  token: 0x60007E1
        public static System.Void CSharp_MsgContext_in_playingID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0429CE38  token: 0x60007E2
        public static System.UInt32 CSharp_MsgContext_in_playingID_get(System.IntPtr jarg1) { }
        // RVA: 0x0429CDB4  token: 0x60007E3
        public static System.Void CSharp_MsgContext_in_gameObjID_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        // RVA: 0x0429CD3C  token: 0x60007E4
        public static System.UInt64 CSharp_MsgContext_in_gameObjID_get(System.IntPtr jarg1) { }
        // RVA: 0x0429CEE0  token: 0x60007E5
        public static System.Void CSharp_MsgContext_in_soundID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0429CEAC  token: 0x60007E6
        public static System.UInt32 CSharp_MsgContext_in_soundID_get(System.IntPtr jarg1) { }
        // RVA: 0x0429CCF8  token: 0x60007E7
        public static System.Void CSharp_MsgContext_in_bIsBus_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x0429CCC0  token: 0x60007E8
        public static System.Boolean CSharp_MsgContext_in_bIsBus_get(System.IntPtr jarg1) { }
        // RVA: 0x042A44AC  token: 0x60007E9
        public static System.Void CSharp_delete_MsgContext(System.IntPtr jarg1) { }
        // RVA: 0x042A57D8  token: 0x60007EA
        public static System.IntPtr CSharp_new_MonitorErrorInfo__SWIG_0(System.String jarg1, System.String jarg2) { }
        // RVA: 0x042A5870  token: 0x60007EB
        public static System.IntPtr CSharp_new_MonitorErrorInfo__SWIG_1(System.String jarg1) { }
        // RVA: 0x042A58EC  token: 0x60007EC
        public static System.IntPtr CSharp_new_MonitorErrorInfo__SWIG_2() { }
        // RVA: 0x0429CAE4  token: 0x60007ED
        public static System.Void CSharp_MonitorErrorInfo_m_name_set(System.IntPtr jarg1, System.String jarg2) { }
        // RVA: 0x0429CAA8  token: 0x60007EE
        public static System.IntPtr CSharp_MonitorErrorInfo_m_name_get(System.IntPtr jarg1) { }
        // RVA: 0x0429CA1C  token: 0x60007EF
        public static System.Void CSharp_MonitorErrorInfo_m_message_set(System.IntPtr jarg1, System.String jarg2) { }
        // RVA: 0x0429C9E0  token: 0x60007F0
        public static System.IntPtr CSharp_MonitorErrorInfo_m_message_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4478  token: 0x60007F1
        public static System.Void CSharp_delete_MonitorErrorInfo(System.IntPtr jarg1) { }
        // RVA: 0x0429D17C  token: 0x60007F2
        public static System.Int32 CSharp_PostCode__SWIG_0(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4, System.UInt32 jarg5, System.Boolean jarg6) { }
        // RVA: 0x0429D228  token: 0x60007F3
        public static System.Int32 CSharp_PostCode__SWIG_1(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4, System.UInt32 jarg5) { }
        // RVA: 0x0429D2C4  token: 0x60007F4
        public static System.Int32 CSharp_PostCode__SWIG_2(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4) { }
        // RVA: 0x0429D360  token: 0x60007F5
        public static System.Int32 CSharp_PostCode__SWIG_3(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3) { }
        // RVA: 0x0429D3EC  token: 0x60007F6
        public static System.Int32 CSharp_PostCode__SWIG_4(System.Int32 jarg1, System.Int32 jarg2) { }
        // RVA: 0x0429D0F0  token: 0x60007F7
        public static System.Int32 CSharp_PostCodeVarArg(System.Int32 jarg1, System.Int32 jarg2, System.IntPtr jarg3) { }
        // RVA: 0x0429DAD8  token: 0x60007F8
        public static System.Int32 CSharp_PostString__SWIG_0(System.String jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4, System.UInt32 jarg5, System.Boolean jarg6) { }
        // RVA: 0x0429DB94  token: 0x60007F9
        public static System.Int32 CSharp_PostString__SWIG_1(System.String jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4, System.UInt32 jarg5) { }
        // RVA: 0x0429DC3C  token: 0x60007FA
        public static System.Int32 CSharp_PostString__SWIG_2(System.String jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4) { }
        // RVA: 0x0429DCE4  token: 0x60007FB
        public static System.Int32 CSharp_PostString__SWIG_3(System.String jarg1, System.Int32 jarg2, System.UInt32 jarg3) { }
        // RVA: 0x0429DD7C  token: 0x60007FC
        public static System.Int32 CSharp_PostString__SWIG_4(System.String jarg1, System.Int32 jarg2) { }
        // RVA: 0x0429FDC0  token: 0x60007FD
        public static System.Int32 CSharp_ResetTranslator() { }
        // RVA: 0x0429BD5C  token: 0x60007FE
        public static System.Int32 CSharp_GetTimeStamp() { }
        // RVA: 0x0429CB70  token: 0x60007FF
        public static System.Void CSharp_MonitorStreamMgrInit(System.IntPtr jarg1) { }
        // RVA: 0x0429CC40  token: 0x6000800
        public static System.Void CSharp_MonitorStreamingDeviceInit(System.UInt32 jarg1, System.IntPtr jarg2) { }
        // RVA: 0x0429CC0C  token: 0x6000801
        public static System.Void CSharp_MonitorStreamingDeviceDestroyed(System.UInt32 jarg1) { }
        // RVA: 0x0429CBA4  token: 0x6000802
        public static System.Void CSharp_MonitorStreamMgrTerm() { }
        // RVA: 0x04290F30  token: 0x6000803
        public static System.Void CSharp_AkGetDefaultHighPriorityThreadProperties(System.IntPtr jarg1) { }
        // RVA: 0x0429FDEC  token: 0x6000804
        public static System.UInt32 CSharp_ResolveDialogueEvent__SWIG_0(System.UInt32 jarg1, System.UInt32[] jarg2, System.UInt32 jarg3, System.UInt32 jarg4) { }
        // RVA: 0x0429FE94  token: 0x6000805
        public static System.UInt32 CSharp_ResolveDialogueEvent__SWIG_1(System.UInt32 jarg1, System.UInt32[] jarg2, System.UInt32 jarg3) { }
        // RVA: 0x0429A694  token: 0x6000806
        public static System.Int32 CSharp_GetDialogueEventCustomPropertyValue__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.Int32& jarg3) { }
        // RVA: 0x0429A720  token: 0x6000807
        public static System.Int32 CSharp_GetDialogueEventCustomPropertyValue__SWIG_1(System.UInt32 jarg1, System.UInt32 jarg2, System.Single& jarg3) { }
        // RVA: 0x042966B4  token: 0x6000808
        public static System.Void CSharp_AkPositioningInfo_fCenterPct_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04296680  token: 0x6000809
        public static System.Single CSharp_AkPositioningInfo_fCenterPct_get(System.IntPtr jarg1) { }
        // RVA: 0x04296A64  token: 0x600080A
        public static System.Void CSharp_AkPositioningInfo_pannerType_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x04296A30  token: 0x600080B
        public static System.Int32 CSharp_AkPositioningInfo_pannerType_get(System.IntPtr jarg1) { }
        // RVA: 0x04296640  token: 0x600080C
        public static System.Void CSharp_AkPositioningInfo_e3dPositioningType_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x0429660C  token: 0x600080D
        public static System.Int32 CSharp_AkPositioningInfo_e3dPositioningType_get(System.IntPtr jarg1) { }
        // RVA: 0x0429649C  token: 0x600080E
        public static System.Void CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x04296464  token: 0x600080F
        public static System.Boolean CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_get(System.IntPtr jarg1) { }
        // RVA: 0x042965CC  token: 0x6000810
        public static System.Void CSharp_AkPositioningInfo_e3DSpatializationMode_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x04296598  token: 0x6000811
        public static System.Int32 CSharp_AkPositioningInfo_e3DSpatializationMode_get(System.IntPtr jarg1) { }
        // RVA: 0x04296420  token: 0x6000812
        public static System.Void CSharp_AkPositioningInfo_bEnableAttenuation_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x042963E8  token: 0x6000813
        public static System.Boolean CSharp_AkPositioningInfo_bEnableAttenuation_get(System.IntPtr jarg1) { }
        // RVA: 0x04296554  token: 0x6000814
        public static System.Void CSharp_AkPositioningInfo_bUseConeAttenuation_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x0429651C  token: 0x6000815
        public static System.Boolean CSharp_AkPositioningInfo_bUseConeAttenuation_get(System.IntPtr jarg1) { }
        // RVA: 0x042967A4  token: 0x6000816
        public static System.Void CSharp_AkPositioningInfo_fInnerAngle_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04296770  token: 0x6000817
        public static System.Single CSharp_AkPositioningInfo_fInnerAngle_get(System.IntPtr jarg1) { }
        // RVA: 0x0429688C  token: 0x6000818
        public static System.Void CSharp_AkPositioningInfo_fOuterAngle_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04296858  token: 0x6000819
        public static System.Single CSharp_AkPositioningInfo_fOuterAngle_get(System.IntPtr jarg1) { }
        // RVA: 0x0429672C  token: 0x600081A
        public static System.Void CSharp_AkPositioningInfo_fConeMaxAttenuation_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x042966F8  token: 0x600081B
        public static System.Single CSharp_AkPositioningInfo_fConeMaxAttenuation_get(System.IntPtr jarg1) { }
        // RVA: 0x0429632C  token: 0x600081C
        public static System.Void CSharp_AkPositioningInfo_LPFCone_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x042962F8  token: 0x600081D
        public static System.Single CSharp_AkPositioningInfo_LPFCone_get(System.IntPtr jarg1) { }
        // RVA: 0x0429623C  token: 0x600081E
        public static System.Void CSharp_AkPositioningInfo_HPFCone_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04296210  token: 0x600081F
        public static System.Single CSharp_AkPositioningInfo_HPFCone_get(System.IntPtr jarg1) { }
        // RVA: 0x0429681C  token: 0x6000820
        public static System.Void CSharp_AkPositioningInfo_fMaxDistance_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x042967E8  token: 0x6000821
        public static System.Single CSharp_AkPositioningInfo_fMaxDistance_get(System.IntPtr jarg1) { }
        // RVA: 0x042969F4  token: 0x6000822
        public static System.Void CSharp_AkPositioningInfo_fVolDryAtMaxDist_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x042969C0  token: 0x6000823
        public static System.Single CSharp_AkPositioningInfo_fVolDryAtMaxDist_get(System.IntPtr jarg1) { }
        // RVA: 0x04296904  token: 0x6000824
        public static System.Void CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x042968D0  token: 0x6000825
        public static System.Single CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_get(System.IntPtr jarg1) { }
        // RVA: 0x0429697C  token: 0x6000826
        public static System.Void CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04296948  token: 0x6000827
        public static System.Single CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_get(System.IntPtr jarg1) { }
        // RVA: 0x042963A4  token: 0x6000828
        public static System.Void CSharp_AkPositioningInfo_LPFValueAtMaxDist_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04296370  token: 0x6000829
        public static System.Single CSharp_AkPositioningInfo_LPFValueAtMaxDist_get(System.IntPtr jarg1) { }
        // RVA: 0x042962B4  token: 0x600082A
        public static System.Void CSharp_AkPositioningInfo_HPFValueAtMaxDist_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04296280  token: 0x600082B
        public static System.Single CSharp_AkPositioningInfo_HPFValueAtMaxDist_get(System.IntPtr jarg1) { }
        // RVA: 0x042A549C  token: 0x600082C
        public static System.IntPtr CSharp_new_AkPositioningInfo() { }
        // RVA: 0x042A4138  token: 0x600082D
        public static System.Void CSharp_delete_AkPositioningInfo(System.IntPtr jarg1) { }
        // RVA: 0x04294930  token: 0x600082E
        public static System.Void CSharp_AkObjectInfo_objID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042948FC  token: 0x600082F
        public static System.UInt32 CSharp_AkObjectInfo_objID_get(System.IntPtr jarg1) { }
        // RVA: 0x042949A4  token: 0x6000830
        public static System.Void CSharp_AkObjectInfo_parentID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04294970  token: 0x6000831
        public static System.UInt32 CSharp_AkObjectInfo_parentID_get(System.IntPtr jarg1) { }
        // RVA: 0x042948BC  token: 0x6000832
        public static System.Void CSharp_AkObjectInfo_iDepth_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x04294888  token: 0x6000833
        public static System.Int32 CSharp_AkObjectInfo_iDepth_get(System.IntPtr jarg1) { }
        // RVA: 0x042947E4  token: 0x6000834
        public static System.Void CSharp_AkObjectInfo_Clear(System.IntPtr jarg1) { }
        // RVA: 0x0429485C  token: 0x6000835
        public static System.Int32 CSharp_AkObjectInfo_GetSizeOf() { }
        // RVA: 0x04294818  token: 0x6000836
        public static System.Void CSharp_AkObjectInfo_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042A5094  token: 0x6000837
        public static System.IntPtr CSharp_new_AkObjectInfo() { }
        // RVA: 0x042A3F98  token: 0x6000838
        public static System.Void CSharp_delete_AkObjectInfo(System.IntPtr jarg1) { }
        // RVA: 0x0429B0CC  token: 0x6000839
        public static System.Int32 CSharp_GetPosition(System.UInt64 jarg1, System.IntPtr jarg2) { }
        // RVA: 0x0429AA10  token: 0x600083A
        public static System.Int32 CSharp_GetListenerPosition(System.UInt64 jarg1, System.IntPtr jarg2) { }
        // RVA: 0x0429B1D0  token: 0x600083B
        public static System.Int32 CSharp_GetRTPCValue__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.Single& jarg4, System.Int32& jarg5) { }
        // RVA: 0x0429B270  token: 0x600083C
        public static System.Int32 CSharp_GetRTPCValue__SWIG_1(System.String jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.Single& jarg4, System.Int32& jarg5) { }
        // RVA: 0x0429BC30  token: 0x600083D
        public static System.Int32 CSharp_GetSwitch__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32& jarg3) { }
        // RVA: 0x0429BCC0  token: 0x600083E
        public static System.Int32 CSharp_GetSwitch__SWIG_1(System.String jarg1, System.UInt64 jarg2, System.UInt32& jarg3) { }
        // RVA: 0x0429BABC  token: 0x600083F
        public static System.Int32 CSharp_GetState__SWIG_0(System.UInt32 jarg1, System.UInt32& jarg2) { }
        // RVA: 0x0429BB3C  token: 0x6000840
        public static System.Int32 CSharp_GetState__SWIG_1(System.String jarg1, System.UInt32& jarg2) { }
        // RVA: 0x0429A7AC  token: 0x6000841
        public static System.Int32 CSharp_GetGameObjectAuxSendValues(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt32& jarg3) { }
        // RVA: 0x0429A83C  token: 0x6000842
        public static System.Int32 CSharp_GetGameObjectDryLevelValue(System.UInt64 jarg1, System.UInt64 jarg2, System.Single& jarg3) { }
        // RVA: 0x0429AB64  token: 0x6000843
        public static System.Int32 CSharp_GetObjectObstructionAndOcclusion(System.UInt64 jarg1, System.UInt64 jarg2, System.Single& jarg3, System.Single& jarg4) { }
        // RVA: 0x0429EA7C  token: 0x6000844
        public static System.Int32 CSharp_QueryAudioObjectIDs__SWIG_0(System.UInt32 jarg1, System.UInt32& jarg2, System.IntPtr jarg3) { }
        // RVA: 0x0429EB0C  token: 0x6000845
        public static System.Int32 CSharp_QueryAudioObjectIDs__SWIG_1(System.String jarg1, System.UInt32& jarg2, System.IntPtr jarg3) { }
        // RVA: 0x0429B150  token: 0x6000846
        public static System.Int32 CSharp_GetPositioningInfo(System.UInt32 jarg1, System.IntPtr jarg2) { }
        // RVA: 0x0429A9D8  token: 0x6000847
        public static System.Boolean CSharp_GetIsGameObjectActive(System.UInt64 jarg1) { }
        // RVA: 0x0429AB38  token: 0x6000848
        public static System.Single CSharp_GetMaxRadius(System.UInt64 jarg1) { }
        // RVA: 0x02A9F010  token: 0x6000849
        public static System.UInt32 CSharp_GetEventIDFromPlayingID(System.UInt32 jarg1) { }
        // RVA: 0x0429A8CC  token: 0x600084A
        public static System.UInt64 CSharp_GetGameObjectFromPlayingID(System.UInt32 jarg1) { }
        // RVA: 0x0429AEB0  token: 0x600084B
        public static System.Int32 CSharp_GetPlayingIDsFromGameObject(System.UInt64 jarg1, System.UInt32& jarg2, System.UInt32[] jarg3) { }
        // RVA: 0x0429A360  token: 0x600084C
        public static System.Int32 CSharp_GetCustomPropertyValue__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.Int32& jarg3) { }
        // RVA: 0x0429A3EC  token: 0x600084D
        public static System.Int32 CSharp_GetCustomPropertyValue__SWIG_1(System.UInt32 jarg1, System.UInt32 jarg2, System.Single& jarg3) { }
        // RVA: 0x0428D5B0  token: 0x600084E
        public static System.Void CSharp_AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(System.UInt32& jarg1) { }
        // RVA: 0x0428D628  token: 0x600084F
        public static System.Void CSharp_AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(System.UInt32& jarg1) { }
        // RVA: 0x0428D538  token: 0x6000850
        public static System.Void CSharp_AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(System.UInt32& jarg1) { }
        // RVA: 0x04298CBC  token: 0x6000851
        public static System.Byte CSharp_ChannelMaskToNumChannels(System.UInt32 jarg1) { }
        // RVA: 0x04298C88  token: 0x6000852
        public static System.UInt32 CSharp_ChannelMaskFromNumChannels(System.UInt32 jarg1) { }
        // RVA: 0x04298C08  token: 0x6000853
        public static System.Byte CSharp_ChannelBitToIndex(System.UInt32 jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0429C024  token: 0x6000854
        public static System.Boolean CSharp_HasSurroundChannels(System.UInt32 jarg1) { }
        // RVA: 0x0429BFAC  token: 0x6000855
        public static System.Boolean CSharp_HasStrictlyOnePairOfSurroundChannels(System.UInt32 jarg1) { }
        // RVA: 0x0429BF74  token: 0x6000856
        public static System.Boolean CSharp_HasSideAndRearChannels(System.UInt32 jarg1) { }
        // RVA: 0x0429BF3C  token: 0x6000857
        public static System.Boolean CSharp_HasHeightChannels(System.UInt32 jarg1) { }
        // RVA: 0x04298AC0  token: 0x6000858
        public static System.UInt32 CSharp_BackToSideChannels(System.UInt32 jarg1) { }
        // RVA: 0x042A2890  token: 0x6000859
        public static System.UInt32 CSharp_StdChannelIndexToDisplayIndex(System.Int32 jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        // RVA: 0x0428F410  token: 0x600085A
        public static System.Void CSharp_AkChannelConfig_uNumChannels_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x026903B0  token: 0x600085B
        public static System.UInt32 CSharp_AkChannelConfig_uNumChannels_get(System.IntPtr jarg1) { }
        // RVA: 0x0428F350  token: 0x600085C
        public static System.Void CSharp_AkChannelConfig_eConfigType_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x02690320  token: 0x600085D
        public static System.UInt32 CSharp_AkChannelConfig_eConfigType_get(System.IntPtr jarg1) { }
        // RVA: 0x0428F3D0  token: 0x600085E
        public static System.Void CSharp_AkChannelConfig_uChannelMask_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x02690290  token: 0x600085F
        public static System.UInt32 CSharp_AkChannelConfig_uChannelMask_get(System.IntPtr jarg1) { }
        // RVA: 0x0428F31C  token: 0x6000860
        public static System.IntPtr CSharp_AkChannelConfig_Standard(System.UInt32 jarg1) { }
        // RVA: 0x0428EF84  token: 0x6000861
        public static System.IntPtr CSharp_AkChannelConfig_Anonymous(System.UInt32 jarg1) { }
        // RVA: 0x0428EF50  token: 0x6000862
        public static System.IntPtr CSharp_AkChannelConfig_Ambisonic(System.UInt32 jarg1) { }
        // RVA: 0x0428F0A8  token: 0x6000863
        public static System.IntPtr CSharp_AkChannelConfig_Object() { }
        // RVA: 0x042A482C  token: 0x6000864
        public static System.IntPtr CSharp_new_AkChannelConfig__SWIG_0() { }
        // RVA: 0x042A4858  token: 0x6000865
        public static System.IntPtr CSharp_new_AkChannelConfig__SWIG_1(System.UInt32 jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428EFFC  token: 0x6000866
        public static System.Void CSharp_AkChannelConfig_Clear(System.IntPtr jarg1) { }
        // RVA: 0x0428F2DC  token: 0x6000867
        public static System.Void CSharp_AkChannelConfig_SetStandard(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428F24C  token: 0x6000868
        public static System.Void CSharp_AkChannelConfig_SetStandardOrAnonymous(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        // RVA: 0x02A4F430  token: 0x6000869
        public static System.Void CSharp_AkChannelConfig_SetAnonymous(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428F170  token: 0x600086A
        public static System.Void CSharp_AkChannelConfig_SetAmbisonic(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428F1B0  token: 0x600086B
        public static System.Void CSharp_AkChannelConfig_SetObject(System.IntPtr jarg1) { }
        // RVA: 0x0428F1E4  token: 0x600086C
        public static System.Void CSharp_AkChannelConfig_SetSameAsMainMix(System.IntPtr jarg1) { }
        // RVA: 0x0428F218  token: 0x600086D
        public static System.Void CSharp_AkChannelConfig_SetSameAsPassthrough(System.IntPtr jarg1) { }
        // RVA: 0x0428F070  token: 0x600086E
        public static System.Boolean CSharp_AkChannelConfig_IsValid(System.IntPtr jarg1) { }
        // RVA: 0x0428F13C  token: 0x600086F
        public static System.UInt32 CSharp_AkChannelConfig_Serialize(System.IntPtr jarg1) { }
        // RVA: 0x0428F030  token: 0x6000870
        public static System.Void CSharp_AkChannelConfig_Deserialize(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428F108  token: 0x6000871
        public static System.IntPtr CSharp_AkChannelConfig_RemoveLFE(System.IntPtr jarg1) { }
        // RVA: 0x0428F0D4  token: 0x6000872
        public static System.IntPtr CSharp_AkChannelConfig_RemoveCenter(System.IntPtr jarg1) { }
        // RVA: 0x038060C0  token: 0x6000873
        public static System.Void CSharp_delete_AkChannelConfig(System.IntPtr jarg1) { }
        // RVA: 0x042A4C80  token: 0x6000874
        public static System.IntPtr CSharp_new_AkImageSourceParams__SWIG_0() { }
        // RVA: 0x042A4CAC  token: 0x6000875
        public static System.IntPtr CSharp_new_AkImageSourceParams__SWIG_1(AkVector64 jarg1, System.Single jarg2, System.Single jarg3) { }
        // RVA: 0x042911DC  token: 0x6000876
        public static System.Void CSharp_AkImageSourceParams_sourcePosition_set(System.IntPtr jarg1, AkVector64 jarg2) { }
        // RVA: 0x04291144  token: 0x6000877
        public static AkVector64 CSharp_AkImageSourceParams_sourcePosition_get(System.IntPtr jarg1) { }
        // RVA: 0x04291010  token: 0x6000878
        public static System.Void CSharp_AkImageSourceParams_fDistanceScalingFactor_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04290FDC  token: 0x6000879
        public static System.Single CSharp_AkImageSourceParams_fDistanceScalingFactor_get(System.IntPtr jarg1) { }
        // RVA: 0x04291088  token: 0x600087A
        public static System.Void CSharp_AkImageSourceParams_fLevel_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04291054  token: 0x600087B
        public static System.Single CSharp_AkImageSourceParams_fLevel_get(System.IntPtr jarg1) { }
        // RVA: 0x04290F98  token: 0x600087C
        public static System.Void CSharp_AkImageSourceParams_fDiffraction_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04290F64  token: 0x600087D
        public static System.Single CSharp_AkImageSourceParams_fDiffraction_get(System.IntPtr jarg1) { }
        // RVA: 0x04291100  token: 0x600087E
        public static System.Void CSharp_AkImageSourceParams_fOcclusion_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x042910CC  token: 0x600087F
        public static System.Single CSharp_AkImageSourceParams_fOcclusion_get(System.IntPtr jarg1) { }
        // RVA: 0x042912F0  token: 0x6000880
        public static System.Void CSharp_AkImageSourceParams_uDiffractionEmitterSide_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04291278  token: 0x6000881
        public static System.Byte CSharp_AkImageSourceParams_uDiffractionEmitterSide_get(System.IntPtr jarg1) { }
        // RVA: 0x04291364  token: 0x6000882
        public static System.Void CSharp_AkImageSourceParams_uDiffractionListenerSide_set(System.IntPtr jarg1, System.Byte jarg2) { }
        // RVA: 0x04291330  token: 0x6000883
        public static System.Byte CSharp_AkImageSourceParams_uDiffractionListenerSide_get(System.IntPtr jarg1) { }
        // RVA: 0x042A3B20  token: 0x6000884
        public static System.Void CSharp_delete_AkImageSourceParams(System.IntPtr jarg1) { }
        // RVA: 0x042A44E0  token: 0x6000885
        public static System.UInt32 CSharp_kDefaultDiffractionMaxEdges_get() { }
        // RVA: 0x042A450C  token: 0x6000886
        public static System.UInt32 CSharp_kDefaultDiffractionMaxPaths_get() { }
        // RVA: 0x042A45F8  token: 0x6000887
        public static System.Single CSharp_kMaxDiffraction_get() { }
        // RVA: 0x042A4590  token: 0x6000888
        public static System.UInt32 CSharp_kHashListBlockAllocItemCount_get() { }
        // RVA: 0x042A4538  token: 0x6000889
        public static System.UInt32 CSharp_kDiffractionMaxEdges_get() { }
        // RVA: 0x042A4564  token: 0x600088A
        public static System.UInt32 CSharp_kDiffractionMaxPaths_get() { }
        // RVA: 0x042A461C  token: 0x600088B
        public static System.UInt32 CSharp_kPortalToPortalDiffractionMaxPaths_get() { }
        // RVA: 0x02A02DE0  token: 0x600088C
        public static System.IntPtr CSharp_new_AkSpatialAudioInitSettings() { }
        // RVA: 0x02A03710  token: 0x600088D
        public static System.Void CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04297D9C  token: 0x600088E
        public static System.UInt32 CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_get(System.IntPtr jarg1) { }
        // RVA: 0x02A03660  token: 0x600088F
        public static System.Void CSharp_AkSpatialAudioInitSettings_fMovementThreshold_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04297D00  token: 0x6000890
        public static System.Single CSharp_AkSpatialAudioInitSettings_fMovementThreshold_get(System.IntPtr jarg1) { }
        // RVA: 0x02A035C0  token: 0x6000891
        public static System.Void CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x02A02110  token: 0x6000892
        public static System.UInt32 CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_get(System.IntPtr jarg1) { }
        // RVA: 0x02A03520  token: 0x6000893
        public static System.Void CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x02A03B90  token: 0x6000894
        public static System.UInt32 CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_get(System.IntPtr jarg1) { }
        // RVA: 0x02A03480  token: 0x6000895
        public static System.Void CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x02A03B00  token: 0x6000896
        public static System.UInt32 CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_get(System.IntPtr jarg1) { }
        // RVA: 0x02A033E0  token: 0x6000897
        public static System.Void CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04297D68  token: 0x6000898
        public static System.UInt32 CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_get(System.IntPtr jarg1) { }
        // RVA: 0x02A03340  token: 0x6000899
        public static System.Void CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04297D34  token: 0x600089A
        public static System.UInt32 CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_get(System.IntPtr jarg1) { }
        // RVA: 0x02A03290  token: 0x600089B
        public static System.Void CSharp_AkSpatialAudioInitSettings_fMaxPathLength_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04297CCC  token: 0x600089C
        public static System.Single CSharp_AkSpatialAudioInitSettings_fMaxPathLength_get(System.IntPtr jarg1) { }
        // RVA: 0x02A031E0  token: 0x600089D
        public static System.Void CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04297C98  token: 0x600089E
        public static System.Single CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_get(System.IntPtr jarg1) { }
        // RVA: 0x02A03140  token: 0x600089F
        public static System.Void CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x02A03A70  token: 0x60008A0
        public static System.UInt32 CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_get(System.IntPtr jarg1) { }
        // RVA: 0x02A03090  token: 0x60008A1
        public static System.Void CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x04297C60  token: 0x60008A2
        public static System.Boolean CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_get(System.IntPtr jarg1) { }
        // RVA: 0x02A02FE0  token: 0x60008A3
        public static System.Void CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x04297C28  token: 0x60008A4
        public static System.Boolean CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_get(System.IntPtr jarg1) { }
        // RVA: 0x03891A80  token: 0x60008A5
        public static System.Void CSharp_delete_AkSpatialAudioInitSettings(System.IntPtr jarg1) { }
        // RVA: 0x042A4D10  token: 0x60008A6
        public static System.IntPtr CSharp_new_AkImageSourceSettings__SWIG_0() { }
        // RVA: 0x042A4D3C  token: 0x60008A7
        public static System.IntPtr CSharp_new_AkImageSourceSettings__SWIG_1(AkVector64 jarg1, System.Single jarg2, System.Single jarg3) { }
        // RVA: 0x042913A4  token: 0x60008A8
        public static System.Void CSharp_AkImageSourceSettings_SetOneTexture(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04291418  token: 0x60008A9
        public static System.Void CSharp_AkImageSourceSettings_params__set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042913E4  token: 0x60008AA
        public static System.IntPtr CSharp_AkImageSourceSettings_params__get(System.IntPtr jarg1) { }
        // RVA: 0x042A3B54  token: 0x60008AB
        public static System.Void CSharp_delete_AkImageSourceSettings(System.IntPtr jarg1) { }
        // RVA: 0x042A49E0  token: 0x60008AC
        public static System.IntPtr CSharp_new_AkExtent__SWIG_0() { }
        // RVA: 0x042A4A0C  token: 0x60008AD
        public static System.IntPtr CSharp_new_AkExtent__SWIG_1(System.Single jarg1, System.Single jarg2, System.Single jarg3) { }
        // RVA: 0x04290A08  token: 0x60008AE
        public static System.Void CSharp_AkExtent_halfWidth_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x042909D4  token: 0x60008AF
        public static System.Single CSharp_AkExtent_halfWidth_get(System.IntPtr jarg1) { }
        // RVA: 0x04290990  token: 0x60008B0
        public static System.Void CSharp_AkExtent_halfHeight_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x0429095C  token: 0x60008B1
        public static System.Single CSharp_AkExtent_halfHeight_get(System.IntPtr jarg1) { }
        // RVA: 0x04290918  token: 0x60008B2
        public static System.Void CSharp_AkExtent_halfDepth_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x042908E4  token: 0x60008B3
        public static System.Single CSharp_AkExtent_halfDepth_get(System.IntPtr jarg1) { }
        // RVA: 0x042A3A84  token: 0x60008B4
        public static System.Void CSharp_delete_AkExtent(System.IntPtr jarg1) { }
        // RVA: 0x042A56B0  token: 0x60008B5
        public static System.IntPtr CSharp_new_AkTriangle__SWIG_0() { }
        // RVA: 0x042A56DC  token: 0x60008B6
        public static System.IntPtr CSharp_new_AkTriangle__SWIG_1(System.UInt16 jarg1, System.UInt16 jarg2, System.UInt16 jarg3, System.UInt16 jarg4) { }
        // RVA: 0x026D77F0  token: 0x60008B7
        public static System.Void CSharp_AkTriangle_point0_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        // RVA: 0x042983D8  token: 0x60008B8
        public static System.UInt16 CSharp_AkTriangle_point0_get(System.IntPtr jarg1) { }
        // RVA: 0x026D77A0  token: 0x60008B9
        public static System.Void CSharp_AkTriangle_point1_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        // RVA: 0x04298450  token: 0x60008BA
        public static System.UInt16 CSharp_AkTriangle_point1_get(System.IntPtr jarg1) { }
        // RVA: 0x026D7710  token: 0x60008BB
        public static System.Void CSharp_AkTriangle_point2_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        // RVA: 0x04298484  token: 0x60008BC
        public static System.UInt16 CSharp_AkTriangle_point2_get(System.IntPtr jarg1) { }
        // RVA: 0x026D7750  token: 0x60008BD
        public static System.Void CSharp_AkTriangle_surface_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        // RVA: 0x042984FC  token: 0x60008BE
        public static System.UInt16 CSharp_AkTriangle_surface_get(System.IntPtr jarg1) { }
        // RVA: 0x026D0090  token: 0x60008BF
        public static System.Void CSharp_AkTriangle_Clear(System.IntPtr jarg1) { }
        // RVA: 0x026CFF10  token: 0x60008C0
        public static System.Int32 CSharp_AkTriangle_GetSizeOf() { }
        // RVA: 0x04298394  token: 0x60008C1
        public static System.Void CSharp_AkTriangle_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042A43A8  token: 0x60008C2
        public static System.Void CSharp_delete_AkTriangle(System.IntPtr jarg1) { }
        // RVA: 0x042A46A0  token: 0x60008C3
        public static System.IntPtr CSharp_new_AkAcousticSurface() { }
        // RVA: 0x026D5630  token: 0x60008C4
        public static System.Void CSharp_AkAcousticSurface_textureID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428DFF8  token: 0x60008C5
        public static System.UInt32 CSharp_AkAcousticSurface_textureID_get(System.IntPtr jarg1) { }
        // RVA: 0x026D55E0  token: 0x60008C6
        public static System.Void CSharp_AkAcousticSurface_transmissionLoss_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x0428E02C  token: 0x60008C7
        public static System.Single CSharp_AkAcousticSurface_transmissionLoss_get(System.IntPtr jarg1) { }
        // RVA: 0x0428DF64  token: 0x60008C8
        public static System.Void CSharp_AkAcousticSurface_strName_set(System.IntPtr jarg1, System.String jarg2) { }
        // RVA: 0x0428DF30  token: 0x60008C9
        public static System.IntPtr CSharp_AkAcousticSurface_strName_get(System.IntPtr jarg1) { }
        // RVA: 0x026D01D0  token: 0x60008CA
        public static System.Void CSharp_AkAcousticSurface_Clear(System.IntPtr jarg1) { }
        // RVA: 0x0428DEFC  token: 0x60008CB
        public static System.Void CSharp_AkAcousticSurface_DeleteName(System.IntPtr jarg1) { }
        // RVA: 0x026CFF40  token: 0x60008CC
        public static System.Int32 CSharp_AkAcousticSurface_GetSizeOf() { }
        // RVA: 0x0428DEB8  token: 0x60008CD
        public static System.Void CSharp_AkAcousticSurface_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042A3698  token: 0x60008CE
        public static System.Void CSharp_delete_AkAcousticSurface(System.IntPtr jarg1) { }
        // RVA: 0x04296DF4  token: 0x60008CF
        public static System.Void CSharp_AkReflectionPathInfo_imageSource_set(System.IntPtr jarg1, AkVector64 jarg2) { }
        // RVA: 0x04296D5C  token: 0x60008D0
        public static AkVector64 CSharp_AkReflectionPathInfo_imageSource_get(System.IntPtr jarg1) { }
        // RVA: 0x04296FF8  token: 0x60008D1
        public static System.Void CSharp_AkReflectionPathInfo_numPathPoints_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04296FC4  token: 0x60008D2
        public static System.UInt32 CSharp_AkReflectionPathInfo_numPathPoints_get(System.IntPtr jarg1) { }
        // RVA: 0x0429706C  token: 0x60008D3
        public static System.Void CSharp_AkReflectionPathInfo_numReflections_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04297038  token: 0x60008D4
        public static System.UInt32 CSharp_AkReflectionPathInfo_numReflections_get(System.IntPtr jarg1) { }
        // RVA: 0x04296F80  token: 0x60008D5
        public static System.Void CSharp_AkReflectionPathInfo_level_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04296F4C  token: 0x60008D6
        public static System.Single CSharp_AkReflectionPathInfo_level_get(System.IntPtr jarg1) { }
        // RVA: 0x04296F08  token: 0x60008D7
        public static System.Void CSharp_AkReflectionPathInfo_isOccluded_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x04296E90  token: 0x60008D8
        public static System.Boolean CSharp_AkReflectionPathInfo_isOccluded_get(System.IntPtr jarg1) { }
        // RVA: 0x04296D30  token: 0x60008D9
        public static System.Int32 CSharp_AkReflectionPathInfo_GetSizeOf() { }
        // RVA: 0x04296C8C  token: 0x60008DA
        public static UnityEngine.Vector3 CSharp_AkReflectionPathInfo_GetPathPoint(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04296BD0  token: 0x60008DB
        public static System.IntPtr CSharp_AkReflectionPathInfo_GetAcousticSurface(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04296C50  token: 0x60008DC
        public static System.Single CSharp_AkReflectionPathInfo_GetDiffraction(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04296B8C  token: 0x60008DD
        public static System.Void CSharp_AkReflectionPathInfo_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042A557C  token: 0x60008DE
        public static System.IntPtr CSharp_new_AkReflectionPathInfo() { }
        // RVA: 0x042A41A0  token: 0x60008DF
        public static System.Void CSharp_delete_AkReflectionPathInfo(System.IntPtr jarg1) { }
        // RVA: 0x0429039C  token: 0x60008E0
        public static System.Void CSharp_AkDiffractionPathInfo_emitterPos_set(System.IntPtr jarg1, AkVector64 jarg2) { }
        // RVA: 0x04290304  token: 0x60008E1
        public static AkVector64 CSharp_AkDiffractionPathInfo_emitterPos_get(System.IntPtr jarg1) { }
        // RVA: 0x042906C0  token: 0x60008E2
        public static System.Void CSharp_AkDiffractionPathInfo_virtualPos_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x0429068C  token: 0x60008E3
        public static System.IntPtr CSharp_AkDiffractionPathInfo_virtualPos_get(System.IntPtr jarg1) { }
        // RVA: 0x0429046C  token: 0x60008E4
        public static System.Void CSharp_AkDiffractionPathInfo_nodeCount_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04290438  token: 0x60008E5
        public static System.UInt32 CSharp_AkDiffractionPathInfo_nodeCount_get(System.IntPtr jarg1) { }
        // RVA: 0x042902C8  token: 0x60008E6
        public static System.Void CSharp_AkDiffractionPathInfo_diffraction_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04290294  token: 0x60008E7
        public static System.Single CSharp_AkDiffractionPathInfo_diffraction_get(System.IntPtr jarg1) { }
        // RVA: 0x04290648  token: 0x60008E8
        public static System.Void CSharp_AkDiffractionPathInfo_transmissionLoss_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04290614  token: 0x60008E9
        public static System.Single CSharp_AkDiffractionPathInfo_transmissionLoss_get(System.IntPtr jarg1) { }
        // RVA: 0x042905D0  token: 0x60008EA
        public static System.Void CSharp_AkDiffractionPathInfo_totLength_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x0429059C  token: 0x60008EB
        public static System.Single CSharp_AkDiffractionPathInfo_totLength_get(System.IntPtr jarg1) { }
        // RVA: 0x042904E0  token: 0x60008EC
        public static System.Void CSharp_AkDiffractionPathInfo_obstructionValue_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x042904AC  token: 0x60008ED
        public static System.Single CSharp_AkDiffractionPathInfo_obstructionValue_get(System.IntPtr jarg1) { }
        // RVA: 0x04290558  token: 0x60008EE
        public static System.Void CSharp_AkDiffractionPathInfo_occlusionValue_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04290524  token: 0x60008EF
        public static System.Single CSharp_AkDiffractionPathInfo_occlusionValue_get(System.IntPtr jarg1) { }
        // RVA: 0x04290268  token: 0x60008F0
        public static System.Int32 CSharp_AkDiffractionPathInfo_GetSizeOf() { }
        // RVA: 0x042900C4  token: 0x60008F1
        public static UnityEngine.Vector3 CSharp_AkDiffractionPathInfo_GetNodes(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04290088  token: 0x60008F2
        public static System.Single CSharp_AkDiffractionPathInfo_GetAngles(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04290168  token: 0x60008F3
        public static System.UInt64 CSharp_AkDiffractionPathInfo_GetPortals(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042901E8  token: 0x60008F4
        public static System.UInt64 CSharp_AkDiffractionPathInfo_GetRooms(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04290044  token: 0x60008F5
        public static System.Void CSharp_AkDiffractionPathInfo_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x042A4930  token: 0x60008F6
        public static System.IntPtr CSharp_new_AkDiffractionPathInfo() { }
        // RVA: 0x042A39B4  token: 0x60008F7
        public static System.Void CSharp_delete_AkDiffractionPathInfo(System.IntPtr jarg1) { }
        // RVA: 0x03B0E6C0  token: 0x60008F8
        public static System.IntPtr CSharp_new_AkRoomParams() { }
        // RVA: 0x031AD5B0  token: 0x60008F9
        public static System.Void CSharp_AkRoomParams_Front_set(System.IntPtr jarg1, UnityEngine.Vector3 jarg2) { }
        // RVA: 0x04297364  token: 0x60008FA
        public static UnityEngine.Vector3 CSharp_AkRoomParams_Front_get(System.IntPtr jarg1) { }
        // RVA: 0x031AD4D0  token: 0x60008FB
        public static System.Void CSharp_AkRoomParams_Up_set(System.IntPtr jarg1, UnityEngine.Vector3 jarg2) { }
        // RVA: 0x0429752C  token: 0x60008FC
        public static UnityEngine.Vector3 CSharp_AkRoomParams_Up_get(System.IntPtr jarg1) { }
        // RVA: 0x031AD100  token: 0x60008FD
        public static System.Void CSharp_AkRoomParams_ReverbAuxBus_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042973F8  token: 0x60008FE
        public static System.UInt32 CSharp_AkRoomParams_ReverbAuxBus_get(System.IntPtr jarg1) { }
        // RVA: 0x031AD3F0  token: 0x60008FF
        public static System.Void CSharp_AkRoomParams_ReverbLevel_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x0429742C  token: 0x6000900
        public static System.Single CSharp_AkRoomParams_ReverbLevel_get(System.IntPtr jarg1) { }
        // RVA: 0x031AD330  token: 0x6000901
        public static System.Void CSharp_AkRoomParams_TransmissionLoss_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x042974F8  token: 0x6000902
        public static System.Single CSharp_AkRoomParams_TransmissionLoss_get(System.IntPtr jarg1) { }
        // RVA: 0x031AD270  token: 0x6000903
        public static System.Void CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x04297460  token: 0x6000904
        public static System.Single CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_get(System.IntPtr jarg1) { }
        // RVA: 0x031AD1C0  token: 0x6000905
        public static System.Void CSharp_AkRoomParams_RoomGameObj_KeepRegistered_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x0429748C  token: 0x6000906
        public static System.Boolean CSharp_AkRoomParams_RoomGameObj_KeepRegistered_get(System.IntPtr jarg1) { }
        // RVA: 0x031AD050  token: 0x6000907
        public static System.Void CSharp_AkRoomParams_RoomPriority_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042974C4  token: 0x6000908
        public static System.UInt32 CSharp_AkRoomParams_RoomPriority_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4208  token: 0x6000909
        public static System.Void CSharp_delete_AkRoomParams(System.IntPtr jarg1) { }
        // RVA: 0x042A4C54  token: 0x600090A
        public static System.IntPtr CSharp_new_AkGeometryInstanceParams() { }
        // RVA: 0x04290CC8  token: 0x600090B
        public static System.Void CSharp_AkGeometryInstanceParams_PositionAndOrientation_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04290C8C  token: 0x600090C
        public static System.IntPtr CSharp_AkGeometryInstanceParams_PositionAndOrientation_get(System.IntPtr jarg1) { }
        // RVA: 0x04290DA0  token: 0x600090D
        public static System.Void CSharp_AkGeometryInstanceParams_Scale_set(System.IntPtr jarg1, UnityEngine.Vector3 jarg2) { }
        // RVA: 0x04290D0C  token: 0x600090E
        public static UnityEngine.Vector3 CSharp_AkGeometryInstanceParams_Scale_get(System.IntPtr jarg1) { }
        // RVA: 0x04290EB0  token: 0x600090F
        public static System.Void CSharp_AkGeometryInstanceParams_UseForReflectionAndDiffraction_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x04290E38  token: 0x6000910
        public static System.Boolean CSharp_AkGeometryInstanceParams_UseForReflectionAndDiffraction_get(System.IntPtr jarg1) { }
        // RVA: 0x042A3AEC  token: 0x6000911
        public static System.Void CSharp_delete_AkGeometryInstanceParams(System.IntPtr jarg1) { }
        // RVA: 0x042A0EAC  token: 0x6000912
        public static System.Int32 CSharp_SetGameObjectRadius(System.UInt64 jarg1, System.Single jarg2, System.Single jarg3) { }
        // RVA: 0x042A0F44  token: 0x6000913
        public static System.Int32 CSharp_SetImageSource__SWIG_0(System.UInt32 jarg1, System.IntPtr jarg2, System.String jarg3, System.UInt32 jarg4, System.UInt64 jarg5) { }
        // RVA: 0x042A100C  token: 0x6000914
        public static System.Int32 CSharp_SetImageSource__SWIG_1(System.UInt32 jarg1, System.IntPtr jarg2, System.String jarg3, System.UInt32 jarg4) { }
        // RVA: 0x042A10C8  token: 0x6000915
        public static System.Int32 CSharp_SetImageSource__SWIG_2(System.UInt32 jarg1, System.IntPtr jarg2, System.String jarg3) { }
        // RVA: 0x0429EE78  token: 0x6000916
        public static System.Int32 CSharp_RemoveImageSource__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt64 jarg3) { }
        // RVA: 0x0429EF04  token: 0x6000917
        public static System.Int32 CSharp_RemoveImageSource__SWIG_1(System.UInt32 jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0429EF80  token: 0x6000918
        public static System.Int32 CSharp_RemoveImageSource__SWIG_2(System.UInt32 jarg1) { }
        // RVA: 0x04298DC8  token: 0x6000919
        public static System.Int32 CSharp_ClearImageSources__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2) { }
        // RVA: 0x04298E48  token: 0x600091A
        public static System.Int32 CSharp_ClearImageSources__SWIG_1(System.UInt32 jarg1) { }
        // RVA: 0x04298E7C  token: 0x600091B
        public static System.Int32 CSharp_ClearImageSources__SWIG_2() { }
        // RVA: 0x031AE770  token: 0x600091C
        public static System.Int32 CSharp_RemoveGeometry(System.UInt64 jarg1) { }
        // RVA: 0x02AF6B40  token: 0x600091D
        public static System.Int32 CSharp_RemoveGeometryInstance(System.UInt64 jarg1) { }
        // RVA: 0x02AF6A60  token: 0x600091E
        public static System.Int32 CSharp_RemoveRoom(System.UInt64 jarg1) { }
        // RVA: 0x0429F0F4  token: 0x600091F
        public static System.Int32 CSharp_RemovePortal(System.UInt64 jarg1) { }
        // RVA: 0x031AD850  token: 0x6000920
        public static System.Int32 CSharp_SetReverbZone(System.UInt64 jarg1, System.UInt64 jarg2, System.Single jarg3) { }
        // RVA: 0x0429F128  token: 0x6000921
        public static System.Int32 CSharp_RemoveReverbZone(System.UInt64 jarg1) { }
        // RVA: 0x042A0DDC  token: 0x6000922
        public static System.Int32 CSharp_SetGameObjectInRoom(System.UInt64 jarg1, System.UInt64 jarg2) { }
        // RVA: 0x042A3460  token: 0x6000923
        public static System.Int32 CSharp_UnsetGameObjectInRoom(System.UInt64 jarg1) { }
        // RVA: 0x02A01DA0  token: 0x6000924
        public static System.Int32 CSharp_SetReflectionsOrder(System.UInt32 jarg1, System.Boolean jarg2) { }
        // RVA: 0x02A01E30  token: 0x6000925
        public static System.Int32 CSharp_SetDiffractionOrder(System.UInt32 jarg1, System.Boolean jarg2) { }
        // RVA: 0x042A13D0  token: 0x6000926
        public static System.Int32 CSharp_SetMaxEmitterRoomAuxSends(System.UInt32 jarg1) { }
        // RVA: 0x02A03BD0  token: 0x6000927
        public static System.Int32 CSharp_SetNumberOfPrimaryRays(System.UInt32 jarg1) { }
        // RVA: 0x02A03990  token: 0x6000928
        public static System.Int32 CSharp_SetLoadBalancingSpread(System.UInt32 jarg1) { }
        // RVA: 0x042A0BE8  token: 0x6000929
        public static System.Int32 CSharp_SetEarlyReflectionsAuxSend(System.UInt64 jarg1, System.UInt32 jarg2) { }
        // RVA: 0x042A0C68  token: 0x600092A
        public static System.Int32 CSharp_SetEarlyReflectionsVolume(System.UInt64 jarg1, System.Single jarg2) { }
        // RVA: 0x042A1C88  token: 0x600092B
        public static System.Int32 CSharp_SetPortalObstructionAndOcclusion(System.UInt64 jarg1, System.Single jarg2, System.Single jarg3) { }
        // RVA: 0x042A0EF8  token: 0x600092C
        public static System.Int32 CSharp_SetGameObjectToPortalObstruction(System.UInt64 jarg1, System.UInt64 jarg2, System.Single jarg3) { }
        // RVA: 0x042A1CD4  token: 0x600092D
        public static System.Int32 CSharp_SetPortalToPortalObstruction(System.UInt64 jarg1, System.UInt64 jarg2, System.Single jarg3) { }
        // RVA: 0x0429ECE8  token: 0x600092E
        public static System.Int32 CSharp_QueryWetDiffraction(System.UInt64 jarg1, System.Single& jarg2) { }
        // RVA: 0x0429FD94  token: 0x600092F
        public static System.Int32 CSharp_ResetStochasticEngine() { }
        // RVA: 0x04294E7C  token: 0x6000930
        public static System.Void CSharp_AkPlatformInitSettings_threadLEngine_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04294E48  token: 0x6000931
        public static System.IntPtr CSharp_AkPlatformInitSettings_threadLEngine_get(System.IntPtr jarg1) { }
        // RVA: 0x04294F6C  token: 0x6000932
        public static System.Void CSharp_AkPlatformInitSettings_threadOutputMgr_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04294F38  token: 0x6000933
        public static System.IntPtr CSharp_AkPlatformInitSettings_threadOutputMgr_get(System.IntPtr jarg1) { }
        // RVA: 0x04294E04  token: 0x6000934
        public static System.Void CSharp_AkPlatformInitSettings_threadBankManager_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04294DD0  token: 0x6000935
        public static System.IntPtr CSharp_AkPlatformInitSettings_threadBankManager_get(System.IntPtr jarg1) { }
        // RVA: 0x04294EF4  token: 0x6000936
        public static System.Void CSharp_AkPlatformInitSettings_threadMonitor_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04294EC0  token: 0x6000937
        public static System.IntPtr CSharp_AkPlatformInitSettings_threadMonitor_get(System.IntPtr jarg1) { }
        // RVA: 0x02A04250  token: 0x6000938
        public static System.Void CSharp_AkPlatformInitSettings_uNumRefillsInVoice_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        // RVA: 0x04295024  token: 0x6000939
        public static System.UInt16 CSharp_AkPlatformInitSettings_uNumRefillsInVoice_get(System.IntPtr jarg1) { }
        // RVA: 0x02A04300  token: 0x600093A
        public static System.Void CSharp_AkPlatformInitSettings_uSampleRate_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0429509C  token: 0x600093B
        public static System.UInt32 CSharp_AkPlatformInitSettings_uSampleRate_get(System.IntPtr jarg1) { }
        // RVA: 0x04294CD4  token: 0x600093C
        public static System.Void CSharp_AkPlatformInitSettings_bEnableAvxSupport_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x04294C9C  token: 0x600093D
        public static System.Boolean CSharp_AkPlatformInitSettings_bEnableAvxSupport_get(System.IntPtr jarg1) { }
        // RVA: 0x03C97810  token: 0x600093E
        public static System.Void CSharp_AkPlatformInitSettings_uMaxSystemAudioObjects_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04294FF0  token: 0x600093F
        public static System.UInt32 CSharp_AkPlatformInitSettings_uMaxSystemAudioObjects_get(System.IntPtr jarg1) { }
        // RVA: 0x04294D50  token: 0x6000940
        public static System.Void CSharp_AkPlatformInitSettings_bEnableDirectInputSupport_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x04294D18  token: 0x6000941
        public static System.Boolean CSharp_AkPlatformInitSettings_bEnableDirectInputSupport_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4034  token: 0x6000942
        public static System.Void CSharp_delete_AkPlatformInitSettings(System.IntPtr jarg1) { }
        // RVA: 0x0429A57C  token: 0x6000943
        public static System.UInt32 CSharp_GetDeviceIDFromName(System.String jarg1) { }
        // RVA: 0x0429BE2C  token: 0x6000944
        public static System.IntPtr CSharp_GetWindowsDeviceName__SWIG_0(System.Int32 jarg1, System.UInt32& jarg2, System.Int32 jarg3) { }
        // RVA: 0x0429BEBC  token: 0x6000945
        public static System.IntPtr CSharp_GetWindowsDeviceName__SWIG_1(System.Int32 jarg1, System.UInt32& jarg2) { }
        // RVA: 0x0429BD88  token: 0x6000946
        public static System.UInt32 CSharp_GetWindowsDeviceCount__SWIG_0(System.Int32 jarg1) { }
        // RVA: 0x0429BE00  token: 0x6000947
        public static System.UInt32 CSharp_GetWindowsDeviceCount__SWIG_1() { }
        // RVA: 0x042A430C  token: 0x6000948
        public static System.Void CSharp_delete_AkStreamMgrSettings(System.IntPtr jarg1) { }
        // RVA: 0x0428FDC4  token: 0x6000949
        public static System.Void CSharp_AkDeviceSettings_pIOMemory_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x0428FD90  token: 0x600094A
        public static System.IntPtr CSharp_AkDeviceSettings_pIOMemory_get(System.IntPtr jarg1) { }
        // RVA: 0x02A041B0  token: 0x600094B
        public static System.Void CSharp_AkDeviceSettings_uIOMemorySize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428FF68  token: 0x600094C
        public static System.UInt32 CSharp_AkDeviceSettings_uIOMemorySize_get(System.IntPtr jarg1) { }
        // RVA: 0x0428FF28  token: 0x600094D
        public static System.Void CSharp_AkDeviceSettings_uIOMemoryAlignment_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428FEF4  token: 0x600094E
        public static System.UInt32 CSharp_AkDeviceSettings_uIOMemoryAlignment_get(System.IntPtr jarg1) { }
        // RVA: 0x0428FD1C  token: 0x600094F
        public static System.Void CSharp_AkDeviceSettings_ePoolAttributes_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428FCE8  token: 0x6000950
        public static System.UInt32 CSharp_AkDeviceSettings_ePoolAttributes_get(System.IntPtr jarg1) { }
        // RVA: 0x0428FEB4  token: 0x6000951
        public static System.Void CSharp_AkDeviceSettings_uGranularity_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428FE80  token: 0x6000952
        public static System.UInt32 CSharp_AkDeviceSettings_uGranularity_get(System.IntPtr jarg1) { }
        // RVA: 0x0428FE3C  token: 0x6000953
        public static System.Void CSharp_AkDeviceSettings_threadProperties_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x0428FE08  token: 0x6000954
        public static System.IntPtr CSharp_AkDeviceSettings_threadProperties_get(System.IntPtr jarg1) { }
        // RVA: 0x02A04100  token: 0x6000955
        public static System.Void CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_set(System.IntPtr jarg1, System.Single jarg2) { }
        // RVA: 0x0428FD5C  token: 0x6000956
        public static System.Single CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_get(System.IntPtr jarg1) { }
        // RVA: 0x04290004  token: 0x6000957
        public static System.Void CSharp_AkDeviceSettings_uMaxConcurrentIO_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428FFD0  token: 0x6000958
        public static System.UInt32 CSharp_AkDeviceSettings_uMaxConcurrentIO_get(System.IntPtr jarg1) { }
        // RVA: 0x02A04050  token: 0x6000959
        public static System.Void CSharp_AkDeviceSettings_bUseStreamCache_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x0428FCB0  token: 0x600095A
        public static System.Boolean CSharp_AkDeviceSettings_bUseStreamCache_get(System.IntPtr jarg1) { }
        // RVA: 0x02A03FB0  token: 0x600095B
        public static System.Void CSharp_AkDeviceSettings_uMaxCachePinnedBytes_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428FF9C  token: 0x600095C
        public static System.UInt32 CSharp_AkDeviceSettings_uMaxCachePinnedBytes_get(System.IntPtr jarg1) { }
        // RVA: 0x042A3980  token: 0x600095D
        public static System.Void CSharp_delete_AkDeviceSettings(System.IntPtr jarg1) { }
        // RVA: 0x04297EA8  token: 0x600095E
        public static System.Void CSharp_AkThreadProperties_nPriority_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x04297E74  token: 0x600095F
        public static System.Int32 CSharp_AkThreadProperties_nPriority_get(System.IntPtr jarg1) { }
        // RVA: 0x04297E34  token: 0x6000960
        public static System.Void CSharp_AkThreadProperties_dwAffinityMask_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04297E00  token: 0x6000961
        public static System.UInt32 CSharp_AkThreadProperties_dwAffinityMask_get(System.IntPtr jarg1) { }
        // RVA: 0x04297F1C  token: 0x6000962
        public static System.Void CSharp_AkThreadProperties_uStackSize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04297EE8  token: 0x6000963
        public static System.UInt32 CSharp_AkThreadProperties_uStackSize_get(System.IntPtr jarg1) { }
        // RVA: 0x042A5684  token: 0x6000964
        public static System.IntPtr CSharp_new_AkThreadProperties() { }
        // RVA: 0x042A4340  token: 0x6000965
        public static System.Void CSharp_delete_AkThreadProperties(System.IntPtr jarg1) { }
        // RVA: 0x022C6E80  token: 0x6000966
        public static System.Void CSharp_SetErrorLogger__SWIG_0(AkLogger.ErrorLoggerInteropDelegate jarg1) { }
        // RVA: 0x042A0CA4  token: 0x6000967
        public static System.Void CSharp_SetErrorLogger__SWIG_1() { }
        // RVA: 0x042A06E4  token: 0x6000968
        public static System.Void CSharp_SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate jarg1, AkAudioInputManager.AudioFormatInteropDelegate jarg2) { }
        // RVA: 0x042A4410  token: 0x6000969
        public static System.Void CSharp_delete_AkUnityPlatformSpecificSettings(System.IntPtr jarg1) { }
        // RVA: 0x042A48D8  token: 0x600096A
        public static System.IntPtr CSharp_new_AkCommunicationSettings() { }
        // RVA: 0x0428FA74  token: 0x600096B
        public static System.Void CSharp_AkCommunicationSettings_uPoolSize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x0428F9FC  token: 0x600096C
        public static System.UInt32 CSharp_AkCommunicationSettings_uPoolSize_get(System.IntPtr jarg1) { }
        // RVA: 0x0428F978  token: 0x600096D
        public static System.Void CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        // RVA: 0x0428F900  token: 0x600096E
        public static System.UInt16 CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_get(System.IntPtr jarg1) { }
        // RVA: 0x0428F87C  token: 0x600096F
        public static System.Void CSharp_AkCommunicationSettings_uCommandPort_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        // RVA: 0x0428F804  token: 0x6000970
        public static System.UInt16 CSharp_AkCommunicationSettings_uCommandPort_get(System.IntPtr jarg1) { }
        // RVA: 0x0428F6BC  token: 0x6000971
        public static System.Void CSharp_AkCommunicationSettings_commSystem_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        // RVA: 0x0428F688  token: 0x6000972
        public static System.Int32 CSharp_AkCommunicationSettings_commSystem_get(System.IntPtr jarg1) { }
        // RVA: 0x0428F644  token: 0x6000973
        public static System.Void CSharp_AkCommunicationSettings_bInitSystemLib_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        // RVA: 0x0428F60C  token: 0x6000974
        public static System.Boolean CSharp_AkCommunicationSettings_bInitSystemLib_get(System.IntPtr jarg1) { }
        // RVA: 0x0428F770  token: 0x6000975
        public static System.Void CSharp_AkCommunicationSettings_szAppNetworkName_set(System.IntPtr jarg1, System.String jarg2) { }
        // RVA: 0x0428F73C  token: 0x6000976
        public static System.IntPtr CSharp_AkCommunicationSettings_szAppNetworkName_get(System.IntPtr jarg1) { }
        // RVA: 0x042A3918  token: 0x6000977
        public static System.Void CSharp_delete_AkCommunicationSettings(System.IntPtr jarg1) { }
        // RVA: 0x02A03D40  token: 0x6000978
        public static System.IntPtr CSharp_new_AkInitializationSettings() { }
        // RVA: 0x039C1D80  token: 0x6000979
        public static System.Void CSharp_delete_AkInitializationSettings(System.IntPtr jarg1) { }
        // RVA: 0x04291AD8  token: 0x600097A
        public static System.Void CSharp_AkInitializationSettings_streamMgrSettings_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x02A03900  token: 0x600097B
        public static System.IntPtr CSharp_AkInitializationSettings_streamMgrSettings_get(System.IntPtr jarg1) { }
        // RVA: 0x04291988  token: 0x600097C
        public static System.Void CSharp_AkInitializationSettings_deviceSettings_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x02A02CA0  token: 0x600097D
        public static System.IntPtr CSharp_AkInitializationSettings_deviceSettings_get(System.IntPtr jarg1) { }
        // RVA: 0x04291A0C  token: 0x600097E
        public static System.Void CSharp_AkInitializationSettings_initSettings_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x02A02BD0  token: 0x600097F
        public static System.IntPtr CSharp_AkInitializationSettings_initSettings_get(System.IntPtr jarg1) { }
        // RVA: 0x04291A94  token: 0x6000980
        public static System.Void CSharp_AkInitializationSettings_platformSettings_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x02A02B00  token: 0x6000981
        public static System.IntPtr CSharp_AkInitializationSettings_platformSettings_get(System.IntPtr jarg1) { }
        // RVA: 0x04291A50  token: 0x6000982
        public static System.Void CSharp_AkInitializationSettings_musicSettings_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x02A03830  token: 0x6000983
        public static System.IntPtr CSharp_AkInitializationSettings_musicSettings_get(System.IntPtr jarg1) { }
        // RVA: 0x04291BB8  token: 0x6000984
        public static System.Void CSharp_AkInitializationSettings_unityPlatformSpecificSettings_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x02A02A30  token: 0x6000985
        public static System.IntPtr CSharp_AkInitializationSettings_unityPlatformSpecificSettings_get(System.IntPtr jarg1) { }
        // RVA: 0x02A01C40  token: 0x6000986
        public static System.Void CSharp_AkInitializationSettings_uMemAllocationSizeLimit_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04291B1C  token: 0x6000987
        public static System.UInt32 CSharp_AkInitializationSettings_uMemAllocationSizeLimit_get(System.IntPtr jarg1) { }
        // RVA: 0x02A03F10  token: 0x6000988
        public static System.Void CSharp_AkInitializationSettings_uMemDebugLevel_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04291B50  token: 0x6000989
        public static System.UInt32 CSharp_AkInitializationSettings_uMemDebugLevel_get(System.IntPtr jarg1) { }
        // RVA: 0x02A03E70  token: 0x600098A
        public static System.Void CSharp_AkInitializationSettings_uMemSpanCount_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04291B84  token: 0x600098B
        public static System.UInt32 CSharp_AkInitializationSettings_uMemSpanCount_get(System.IntPtr jarg1) { }
        // RVA: 0x042A4A64  token: 0x600098C
        public static System.IntPtr CSharp_new_AkExternalSourceInfo__SWIG_0() { }
        // RVA: 0x042A3AB8  token: 0x600098D
        public static System.Void CSharp_delete_AkExternalSourceInfo(System.IntPtr jarg1) { }
        // RVA: 0x042A4A90  token: 0x600098E
        public static System.IntPtr CSharp_new_AkExternalSourceInfo__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32 jarg3, System.UInt32 jarg4) { }
        // RVA: 0x042A4B30  token: 0x600098F
        public static System.IntPtr CSharp_new_AkExternalSourceInfo__SWIG_2(System.String jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        // RVA: 0x042A4BC8  token: 0x6000990
        public static System.IntPtr CSharp_new_AkExternalSourceInfo__SWIG_3(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        // RVA: 0x03C947C0  token: 0x6000991
        public static System.Void CSharp_AkExternalSourceInfo_Clear(System.IntPtr jarg1) { }
        // RVA: 0x04290A4C  token: 0x6000992
        public static System.Void CSharp_AkExternalSourceInfo_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x03742290  token: 0x6000993
        public static System.Int32 CSharp_AkExternalSourceInfo_GetSizeOf() { }
        // RVA: 0x02950840  token: 0x6000994
        public static System.Void CSharp_AkExternalSourceInfo_iExternalSrcCookie_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04290A90  token: 0x6000995
        public static System.UInt32 CSharp_AkExternalSourceInfo_iExternalSrcCookie_get(System.IntPtr jarg1) { }
        // RVA: 0x02950790  token: 0x6000996
        public static System.Void CSharp_AkExternalSourceInfo_idCodec_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04290AC4  token: 0x6000997
        public static System.UInt32 CSharp_AkExternalSourceInfo_idCodec_get(System.IntPtr jarg1) { }
        // RVA: 0x02950900  token: 0x6000998
        public static System.Void CSharp_AkExternalSourceInfo_szFile_set(System.IntPtr jarg1, System.String jarg2) { }
        // RVA: 0x04290BE4  token: 0x6000999
        public static System.IntPtr CSharp_AkExternalSourceInfo_szFile_get(System.IntPtr jarg1) { }
        // RVA: 0x04290BA0  token: 0x600099A
        public static System.Void CSharp_AkExternalSourceInfo_pInMemory_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        // RVA: 0x04290B6C  token: 0x600099B
        public static System.IntPtr CSharp_AkExternalSourceInfo_pInMemory_get(System.IntPtr jarg1) { }
        // RVA: 0x04290C4C  token: 0x600099C
        public static System.Void CSharp_AkExternalSourceInfo_uiMemorySize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04290C18  token: 0x600099D
        public static System.UInt32 CSharp_AkExternalSourceInfo_uiMemorySize_get(System.IntPtr jarg1) { }
        // RVA: 0x04290B2C  token: 0x600099E
        public static System.Void CSharp_AkExternalSourceInfo_idFile_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        // RVA: 0x04290AF8  token: 0x600099F
        public static System.UInt32 CSharp_AkExternalSourceInfo_idFile_get(System.IntPtr jarg1) { }
        // RVA: 0x02A01F20  token: 0x60009A0
        public static System.Int32 CSharp_Init(System.IntPtr jarg1) { }
        // RVA: 0x02A01FC0  token: 0x60009A1
        public static System.Int32 CSharp_InitSpatialAudio(System.IntPtr jarg1) { }
        // RVA: 0x0429C088  token: 0x60009A2
        public static System.Int32 CSharp_InitCommunication(System.IntPtr jarg1) { }
        // RVA: 0x042A2E48  token: 0x60009A3
        public static System.Void CSharp_Term() { }
        // RVA: 0x027612C0  token: 0x60009A4
        public static System.Int32 CSharp_RegisterGameObjInternal(System.UInt64 jarg1) { }
        // RVA: 0x02AF8780  token: 0x60009A5
        public static System.Int32 CSharp_UnregisterGameObjInternal(System.UInt64 jarg1) { }
        // RVA: 0x031ADF90  token: 0x60009A6
        public static System.Int32 CSharp_RegisterGameObjInternal_WithName(System.UInt64 jarg1, System.String jarg2) { }
        // RVA: 0x042A07B8  token: 0x60009A7
        public static System.Int32 CSharp_SetBasePath(System.String jarg1) { }
        // RVA: 0x02951D50  token: 0x60009A8
        public static System.Int32 CSharp_SetCurrentLanguage(System.String jarg1) { }
        // RVA: 0x02CB3A70  token: 0x60009A9
        public static System.Int32 CSharp_LoadFilePackage(System.String jarg1, System.UInt32& jarg2) { }
        // RVA: 0x03708510  token: 0x60009AA
        public static System.Int32 CSharp_AddBasePath(System.String jarg1) { }
        // RVA: 0x042A0D0C  token: 0x60009AB
        public static System.Int32 CSharp_SetGameName(System.String jarg1) { }
        // RVA: 0x0429A334  token: 0x60009AC
        public static System.IntPtr CSharp_GetCurrentLanguage() { }
        // RVA: 0x02CB4230  token: 0x60009AD
        public static System.Int32 CSharp_UnloadFilePackage(System.UInt32 jarg1) { }
        // RVA: 0x042A2EB0  token: 0x60009AE
        public static System.Int32 CSharp_UnloadAllFilePackages() { }
        // RVA: 0x028BB4D0  token: 0x60009AF
        public static System.Int32 CSharp_SetObjectPosition(System.UInt64 jarg1, UnityEngine.Vector3 jarg2, UnityEngine.Vector3 jarg3, UnityEngine.Vector3 jarg4) { }
        // RVA: 0x0429B3A8  token: 0x60009B0
        public static System.Int32 CSharp_GetSourceMultiplePlayPositions__SWIG_0(System.UInt32 jarg1, System.UInt32[] jarg2, System.UInt32[] jarg3, System.Int32[] jarg4, System.UInt32& jarg5, System.Boolean jarg6) { }
        // RVA: 0x0429B58C  token: 0x60009B1
        public static System.Int32 CSharp_GetSourceMultiplePlayPositions__SWIG_1(System.UInt32 jarg1, System.UInt32[] jarg2, System.UInt32[] jarg3, System.Int32[] jarg4, System.UInt32& jarg5) { }
        // RVA: 0x042A1334  token: 0x60009B2
        public static System.Int32 CSharp_SetListeners(System.UInt64 jarg1, System.UInt64[] jarg2, System.UInt32 jarg3) { }
        // RVA: 0x026BD170  token: 0x60009B3
        public static System.Int32 CSharp_SetDefaultListeners(System.UInt64[] jarg1, System.UInt32 jarg2) { }
        // RVA: 0x03618060  token: 0x60009B4
        public static System.UInt32 CSharp_GetNumOutputDevices(System.UInt32 jarg1) { }
        // RVA: 0x0428D874  token: 0x60009B5
        public static System.Int32 CSharp_AddOutput__SWIG_0(System.IntPtr jarg1, System.UInt64& jarg2, System.UInt64[] jarg3, System.UInt32 jarg4) { }
        // RVA: 0x0428D920  token: 0x60009B6
        public static System.Int32 CSharp_AddOutput__SWIG_1(System.IntPtr jarg1, System.UInt64& jarg2, System.UInt64[] jarg3) { }
        // RVA: 0x0428D9BC  token: 0x60009B7
        public static System.Int32 CSharp_AddOutput__SWIG_2(System.IntPtr jarg1, System.UInt64& jarg2) { }
        // RVA: 0x0428DA40  token: 0x60009B8
        public static System.Int32 CSharp_AddOutput__SWIG_3(System.IntPtr jarg1) { }
        // RVA: 0x0429A548  token: 0x60009B9
        public static System.Void CSharp_GetDefaultStreamSettings(System.IntPtr jarg1) { }
        // RVA: 0x0429A478  token: 0x60009BA
        public static System.Void CSharp_GetDefaultDeviceSettings(System.IntPtr jarg1) { }
        // RVA: 0x0429A4E0  token: 0x60009BB
        public static System.Void CSharp_GetDefaultMusicSettings(System.IntPtr jarg1) { }
        // RVA: 0x0429A4AC  token: 0x60009BC
        public static System.Void CSharp_GetDefaultInitSettings(System.IntPtr jarg1) { }
        // RVA: 0x0429A514  token: 0x60009BD
        public static System.Void CSharp_GetDefaultPlatformInitSettings(System.IntPtr jarg1) { }
        // RVA: 0x0429AB0C  token: 0x60009BE
        public static System.UInt32 CSharp_GetMajorMinorVersion() { }
        // RVA: 0x0429BBC8  token: 0x60009BF
        public static System.UInt32 CSharp_GetSubminorBuildVersion() { }
        // RVA: 0x042A285C  token: 0x60009C0
        public static System.Void CSharp_StartResourceMonitoring() { }
        // RVA: 0x042A2CF0  token: 0x60009C1
        public static System.Void CSharp_StopResourceMonitoring() { }
        // RVA: 0x0429B31C  token: 0x60009C2
        public static System.Void CSharp_GetResourceMonitorDataSummary(System.IntPtr jarg1) { }
        // RVA: 0x042A2704  token: 0x60009C3
        public static System.Void CSharp_StartDeviceCapture(System.UInt64 jarg1) { }
        // RVA: 0x042A2948  token: 0x60009C4
        public static System.Void CSharp_StopDeviceCapture(System.UInt64 jarg1) { }
        // RVA: 0x04298D60  token: 0x60009C5
        public static System.Void CSharp_ClearCaptureData() { }
        // RVA: 0x042A3514  token: 0x60009C6
        public static System.UInt32 CSharp_UpdateCaptureSampleCount(System.UInt64 jarg1) { }
        // RVA: 0x0429A298  token: 0x60009C7
        public static System.UInt32 CSharp_GetCaptureSamples(System.UInt64 jarg1, System.Single[] jarg2, System.UInt32 jarg3) { }
        // RVA: 0x042A2364  token: 0x60009C8
        public static System.Int32 CSharp_SetRoomPortal(System.UInt64 jarg1, System.UInt64 jarg2, System.UInt64 jarg3, System.IntPtr jarg4, System.IntPtr jarg5, System.Boolean jarg6, System.String jarg7) { }
        // RVA: 0x031ACF70  token: 0x60009C9
        public static System.Int32 CSharp_SetRoom(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt64 jarg3, System.String jarg4) { }
        // RVA: 0x026BD0F0  token: 0x60009CA
        public static System.Int32 CSharp_RegisterSpatialAudioListener(System.UInt64 jarg1) { }
        // RVA: 0x042A342C  token: 0x60009CB
        public static System.Int32 CSharp_UnregisterSpatialAudioListener(System.UInt64 jarg1) { }
        // RVA: 0x026D54B0  token: 0x60009CC
        public static System.Int32 CSharp_SetGeometry(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt32 jarg3, UnityEngine.Vector3[] jarg4, System.UInt32 jarg5, System.IntPtr jarg6, System.UInt32 jarg7, System.Boolean jarg8, System.Boolean jarg9) { }
        // RVA: 0x031ADBF0  token: 0x60009CD
        public static System.Int32 CSharp_SetGeometryInstance(System.UInt64 jarg1, System.IntPtr jarg2, UnityEngine.Vector3 jarg3, System.UInt64 jarg4, System.UInt64 jarg5, System.Boolean jarg6) { }
        // RVA: 0x0429EC48  token: 0x60009CE
        public static System.Int32 CSharp_QueryReflectionPaths(System.UInt64 jarg1, System.UInt32 jarg2, UnityEngine.Vector3& jarg3, UnityEngine.Vector3& jarg4, System.IntPtr jarg5, System.UInt32& jarg6) { }
        // RVA: 0x0429EBA8  token: 0x60009CF
        public static System.Int32 CSharp_QueryDiffractionPaths(System.UInt64 jarg1, System.UInt32 jarg2, UnityEngine.Vector3& jarg3, UnityEngine.Vector3& jarg4, System.IntPtr jarg5, System.UInt32& jarg6) { }
        // RVA: 0x0429CF98  token: 0x60009D0
        public static System.Void CSharp_PerformStreamMgrIO() { }
        // RVA: 0x0429C05C  token: 0x60009D1
        public static System.Void CSharp_HgMemShrink() { }
        // RVA: 0x0269BAA0  token: 0x60009D2
        public static System.UInt64 CSharp_HgGetGlobalMemoryUsed() { }
        // RVA: 0x039CB020  token: 0x60009D3
        public static System.UInt64 CSharp_HgGetGlobalMemoryReserved() { }
        // RVA: 0x036563A0  token: 0x60009D4
        public static System.Void CSharp_InitScePad() { }
        // RVA: 0x0429AA94  token: 0x60009D5
        public static System.UInt32 CSharp_GetMMDeviceIdFromPadContainerInfo(System.Int32 jarg1) { }
        // RVA: 0x042960AC  token: 0x60009D6
        public static System.IntPtr CSharp_AkPlaylist_SWIGUpcast(System.IntPtr jarg1) { }
        // RVA: 0x04293AD8  token: 0x60009D7
        public static System.IntPtr CSharp_AkMIDIPost_SWIGUpcast(System.IntPtr jarg1) { }
        // RVA: 0x031D8990  token: 0x60009D8
        public static System.IntPtr CSharp_AkEventCallbackInfo_SWIGUpcast(System.IntPtr jarg1) { }
        // RVA: 0x031D8730  token: 0x60009D9
        public static System.IntPtr CSharp_AkMIDIEventCallbackInfo_SWIGUpcast(System.IntPtr jarg1) { }
        // RVA: 0x031D8830  token: 0x60009DA
        public static System.IntPtr CSharp_AkMarkerCallbackInfo_SWIGUpcast(System.IntPtr jarg1) { }
        // RVA: 0x031D8A50  token: 0x60009DB
        public static System.IntPtr CSharp_AkDurationCallbackInfo_SWIGUpcast(System.IntPtr jarg1) { }
        // RVA: 0x031D8570  token: 0x60009DC
        public static System.IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_SWIGUpcast(System.IntPtr jarg1) { }
        // RVA: 0x031D84C0  token: 0x60009DD
        public static System.IntPtr CSharp_AkMusicSyncCallbackInfo_SWIGUpcast(System.IntPtr jarg1) { }
        // RVA: 0x031D8630  token: 0x60009DE
        public static System.IntPtr CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast(System.IntPtr jarg1) { }
        // RVA: 0x0350B670  token: 0x60009DF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006E  // size: 0x80
    public sealed class GameObjectHashFunction : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x0389C3E0  token: 0x6000C11
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x0102B410  token: 0x6000C12
        public virtual System.UInt64 Invoke(UnityEngine.GameObject gameObject) { }
        // RVA: 0x0389C3B0  token: 0x6000C13
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.GameObject gameObject, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BDEE8  token: 0x6000C14
        public virtual System.UInt64 EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200006D  // size: 0x10
    public class AkSoundEngine
    {
        // Fields
        public static System.Int32 _WIN32_WINNT;  // const
        public static System.Int32 AK_SIMD_ALIGNMENT;  // const
        public static System.Int32 AK_BUFFER_ALIGNMENT;  // const
        public static System.Int32 AK_XAUDIO2_FLAGS;  // const
        public static System.Int32 AK_MAX_PATH;  // const
        public static System.Int32 AK_BANK_PLATFORM_DATA_ALIGNMENT;  // const
        public static System.String AK_OSCHAR_FMT;  // const
        public static System.UInt32 AK_INVALID_PLUGINID;  // const
        public static System.UInt64 AK_INVALID_GAME_OBJECT;  // const
        public static System.UInt32 AK_INVALID_UNIQUE_ID;  // const
        public static System.UInt32 AK_INVALID_RTPC_ID;  // const
        public static System.UInt32 AK_INVALID_LISTENER_INDEX;  // const
        public static System.UInt32 AK_INVALID_PLAYING_ID;  // const
        public static System.UInt32 AK_DEFAULT_SWITCH_STATE;  // const
        public static System.Int32 AK_INVALID_POOL_ID;  // const
        public static System.Int32 AK_DEFAULT_POOL_ID;  // const
        public static System.UInt32 AK_INVALID_AUX_ID;  // const
        public static System.UInt32 AK_INVALID_FILE_ID;  // const
        public static System.UInt32 AK_INVALID_DEVICE_ID;  // const
        public static System.UInt32 AK_INVALID_BANK_ID;  // const
        public static System.UInt32 AK_FALLBACK_ARGUMENTVALUE_ID;  // const
        public static System.UInt32 AK_INVALID_CHANNELMASK;  // const
        public static System.UInt32 AK_INVALID_OUTPUT_DEVICE_ID;  // const
        public static System.UInt32 AK_MIXER_FX_SLOT;  // const
        public static System.UInt64 AK_DEFAULT_LISTENER_OBJ;  // const
        public static System.UInt32 AK_DEFAULT_PRIORITY;  // const
        public static System.UInt32 AK_MIN_PRIORITY;  // const
        public static System.UInt32 AK_MAX_PRIORITY;  // const
        public static System.UInt32 AK_DEFAULT_BANK_IO_PRIORITY;  // const
        public static System.Double AK_DEFAULT_BANK_THROUGHPUT;  // const
        public static System.UInt32 AKCOMPANYID_AUDIOKINETIC;  // const
        public static System.UInt32 AK_LISTENERS_MASK_ALL;  // const
        public static System.Int32 NULL;  // const
        public static System.Int32 AKCURVEINTERPOLATION_NUM_STORAGE_BIT;  // const
        public static System.Int32 AK_MAX_LANGUAGE_NAME_SIZE;  // const
        public static System.Int32 AKCOMPANYID_PLUGINDEV_MIN;  // const
        public static System.Int32 AKCOMPANYID_PLUGINDEV_MAX;  // const
        public static System.Int32 AKCOMPANYID_AUDIOKINETIC_EXTERNAL;  // const
        public static System.Int32 AKCOMPANYID_MCDSP;  // const
        public static System.Int32 AKCOMPANYID_WAVEARTS;  // const
        public static System.Int32 AKCOMPANYID_PHONETICARTS;  // const
        public static System.Int32 AKCOMPANYID_IZOTOPE;  // const
        public static System.Int32 AKCOMPANYID_CRANKCASEAUDIO;  // const
        public static System.Int32 AKCOMPANYID_IOSONO;  // const
        public static System.Int32 AKCOMPANYID_AUROTECHNOLOGIES;  // const
        public static System.Int32 AKCOMPANYID_DOLBY;  // const
        public static System.Int32 AKCOMPANYID_TWOBIGEARS;  // const
        public static System.Int32 AKCOMPANYID_OCULUS;  // const
        public static System.Int32 AKCOMPANYID_BLUERIPPLESOUND;  // const
        public static System.Int32 AKCOMPANYID_ENZIEN;  // const
        public static System.Int32 AKCOMPANYID_KROTOS;  // const
        public static System.Int32 AKCOMPANYID_NURULIZE;  // const
        public static System.Int32 AKCOMPANYID_SUPERPOWERED;  // const
        public static System.Int32 AKCOMPANYID_GOOGLE;  // const
        public static System.Int32 AKCOMPANYID_VISISONICS;  // const
        public static System.Int32 AKCODECID_BANK;  // const
        public static System.Int32 AKCODECID_PCM;  // const
        public static System.Int32 AKCODECID_ADPCM;  // const
        public static System.Int32 AKCODECID_XMA;  // const
        public static System.Int32 AKCODECID_VORBIS;  // const
        public static System.Int32 AKCODECID_WIIADPCM;  // const
        public static System.Int32 AKCODECID_PCMEX;  // const
        public static System.Int32 AKCODECID_EXTERNAL_SOURCE;  // const
        public static System.Int32 AKCODECID_XWMA;  // const
        public static System.Int32 AKCODECID_FILE_PACKAGE;  // const
        public static System.Int32 AKCODECID_ATRAC9;  // const
        public static System.Int32 AKCODECID_VAG;  // const
        public static System.Int32 AKCODECID_PROFILERCAPTURE;  // const
        public static System.Int32 AKCODECID_ANALYSISFILE;  // const
        public static System.Int32 AKCODECID_MIDI;  // const
        public static System.Int32 AKCODECID_OPUSNX;  // const
        public static System.Int32 AKCODECID_CAF;  // const
        public static System.Int32 AKCODECID_AKOPUS;  // const
        public static System.Int32 AKCODECID_AKOPUS_WEM;  // const
        public static System.Int32 AKCODECID_MEMORYMGR_DUMP;  // const
        public static System.Int32 AKCODECID_SONY360;  // const
        public static System.Int32 AKCODECID_BANK_EVENT;  // const
        public static System.Int32 AKCODECID_BANK_BUS;  // const
        public static System.Int32 AKPLUGINID_METER;  // const
        public static System.Int32 AKPLUGINID_RECORDER;  // const
        public static System.Int32 AKPLUGINID_IMPACTER;  // const
        public static System.Int32 AKPLUGINID_SYSTEM_OUTPUT_META;  // const
        public static System.Int32 AKPLUGINID_AUDIO_OBJECT_ATTENUATION_META;  // const
        public static System.Int32 AKPLUGINID_AUDIO_OBJECT_PRIORITY_META;  // const
        public static System.Int32 AKEXTENSIONID_SPATIALAUDIO;  // const
        public static System.Int32 AKEXTENSIONID_INTERACTIVEMUSIC;  // const
        public static System.Int32 AKEXTENSIONID_MIDIDEVICEMGR;  // const
        public static System.Int32 AK_WAVE_FORMAT_VAG;  // const
        public static System.Int32 AK_WAVE_FORMAT_AT9;  // const
        public static System.Int32 AK_WAVE_FORMAT_VORBIS;  // const
        public static System.Int32 AK_WAVE_FORMAT_OPUSNX;  // const
        public static System.Int32 AK_WAVE_FORMAT_OPUS;  // const
        public static System.Int32 AK_WAVE_FORMAT_OPUS_WEM;  // const
        public static System.Int32 WAVE_FORMAT_XMA2;  // const
        public static System.Int32 AK_PANNER_NUM_STORAGE_BITS;  // const
        public static System.Int32 AK_POSSOURCE_NUM_STORAGE_BITS;  // const
        public static System.Int32 AK_SPAT_NUM_STORAGE_BITS;  // const
        public static System.Int32 AK_MAX_BITS_METERING_FLAGS;  // const
        public static System.Boolean AK_ASYNC_OPEN_DEFAULT;  // const
        public static System.Int32 AK_COMM_DEFAULT_DISCOVERY_PORT;  // const
        public static System.Double AK_DEFAULT_LISTENER_POSITION_X;  // const
        public static System.Double AK_DEFAULT_LISTENER_POSITION_Y;  // const
        public static System.Double AK_DEFAULT_LISTENER_POSITION_Z;  // const
        public static System.Double AK_DEFAULT_LISTENER_FRONT_X;  // const
        public static System.Double AK_DEFAULT_LISTENER_FRONT_Y;  // const
        public static System.Double AK_DEFAULT_LISTENER_FRONT_Z;  // const
        public static System.Double AK_DEFAULT_TOP_X;  // const
        public static System.Double AK_DEFAULT_TOP_Y;  // const
        public static System.Double AK_DEFAULT_TOP_Z;  // const
        public static System.Double AK_SA_EPSILON;  // const
        public static System.Double AK_SA_DIFFRACTION_EPSILON;  // const
        public static System.Double AK_SA_PLANE_THICKNESS;  // const
        public static System.Double AK_SA_MIN_ENVIRONMENT_ABSORPTION;  // const
        public static System.Double AK_SA_MIN_ENVIRONMENT_SURFACE_AREA;  // const
        public static System.Int32 AK_MIDI_EVENT_TYPE_INVALID;  // const
        public static System.Int32 AK_MIDI_EVENT_TYPE_NOTE_OFF;  // const
        public static System.Int32 AK_MIDI_EVENT_TYPE_NOTE_ON;  // const
        public static System.Int32 AK_MIDI_EVENT_TYPE_NOTE_AFTERTOUCH;  // const
        public static System.Int32 AK_MIDI_EVENT_TYPE_CONTROLLER;  // const
        public static System.Int32 AK_MIDI_EVENT_TYPE_PROGRAM_CHANGE;  // const
        public static System.Int32 AK_MIDI_EVENT_TYPE_CHANNEL_AFTERTOUCH;  // const
        public static System.Int32 AK_MIDI_EVENT_TYPE_PITCH_BEND;  // const
        public static System.Int32 AK_MIDI_EVENT_TYPE_SYSEX;  // const
        public static System.Int32 AK_MIDI_EVENT_TYPE_ESCAPE;  // const
        public static System.Int32 AK_MIDI_EVENT_TYPE_WWISE_CMD;  // const
        public static System.Int32 AK_MIDI_EVENT_TYPE_META;  // const
        public static System.Int32 AK_MIDI_CC_BANK_SELECT_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_MOD_WHEEL_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_BREATH_CTRL_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_3_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_FOOT_PEDAL_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_PORTAMENTO_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_DATA_ENTRY_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_VOLUME_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_BALANCE_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_9_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_PAN_POSITION_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_EXPRESSION_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_EFFECT_CTRL_1_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_EFFECT_CTRL_2_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_14_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_15_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_GEN_SLIDER_1;  // const
        public static System.Int32 AK_MIDI_CC_GEN_SLIDER_2;  // const
        public static System.Int32 AK_MIDI_CC_GEN_SLIDER_3;  // const
        public static System.Int32 AK_MIDI_CC_GEN_SLIDER_4;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_20_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_21_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_22_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_23_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_24_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_25_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_26_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_27_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_28_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_29_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_30_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_31_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_BANK_SELECT_FINE;  // const
        public static System.Int32 AK_MIDI_CC_MOD_WHEEL_FINE;  // const
        public static System.Int32 AK_MIDI_CC_BREATH_CTRL_FINE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_3_FINE;  // const
        public static System.Int32 AK_MIDI_CC_FOOT_PEDAL_FINE;  // const
        public static System.Int32 AK_MIDI_CC_PORTAMENTO_FINE;  // const
        public static System.Int32 AK_MIDI_CC_DATA_ENTRY_FINE;  // const
        public static System.Int32 AK_MIDI_CC_VOLUME_FINE;  // const
        public static System.Int32 AK_MIDI_CC_BALANCE_FINE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_9_FINE;  // const
        public static System.Int32 AK_MIDI_CC_PAN_POSITION_FINE;  // const
        public static System.Int32 AK_MIDI_CC_EXPRESSION_FINE;  // const
        public static System.Int32 AK_MIDI_CC_EFFECT_CTRL_1_FINE;  // const
        public static System.Int32 AK_MIDI_CC_EFFECT_CTRL_2_FINE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_14_FINE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_15_FINE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_20_FINE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_21_FINE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_22_FINE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_23_FINE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_24_FINE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_25_FINE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_26_FINE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_27_FINE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_28_FINE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_29_FINE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_30_FINE;  // const
        public static System.Int32 AK_MIDI_CC_CTRL_31_FINE;  // const
        public static System.Int32 AK_MIDI_CC_HOLD_PEDAL;  // const
        public static System.Int32 AK_MIDI_CC_PORTAMENTO_ON_OFF;  // const
        public static System.Int32 AK_MIDI_CC_SUSTENUTO_PEDAL;  // const
        public static System.Int32 AK_MIDI_CC_SOFT_PEDAL;  // const
        public static System.Int32 AK_MIDI_CC_LEGATO_PEDAL;  // const
        public static System.Int32 AK_MIDI_CC_HOLD_PEDAL_2;  // const
        public static System.Int32 AK_MIDI_CC_SOUND_VARIATION;  // const
        public static System.Int32 AK_MIDI_CC_SOUND_TIMBRE;  // const
        public static System.Int32 AK_MIDI_CC_SOUND_RELEASE_TIME;  // const
        public static System.Int32 AK_MIDI_CC_SOUND_ATTACK_TIME;  // const
        public static System.Int32 AK_MIDI_CC_SOUND_BRIGHTNESS;  // const
        public static System.Int32 AK_MIDI_CC_SOUND_CTRL_6;  // const
        public static System.Int32 AK_MIDI_CC_SOUND_CTRL_7;  // const
        public static System.Int32 AK_MIDI_CC_SOUND_CTRL_8;  // const
        public static System.Int32 AK_MIDI_CC_SOUND_CTRL_9;  // const
        public static System.Int32 AK_MIDI_CC_SOUND_CTRL_10;  // const
        public static System.Int32 AK_MIDI_CC_GENERAL_BUTTON_1;  // const
        public static System.Int32 AK_MIDI_CC_GENERAL_BUTTON_2;  // const
        public static System.Int32 AK_MIDI_CC_GENERAL_BUTTON_3;  // const
        public static System.Int32 AK_MIDI_CC_GENERAL_BUTTON_4;  // const
        public static System.Int32 AK_MIDI_CC_REVERB_LEVEL;  // const
        public static System.Int32 AK_MIDI_CC_TREMOLO_LEVEL;  // const
        public static System.Int32 AK_MIDI_CC_CHORUS_LEVEL;  // const
        public static System.Int32 AK_MIDI_CC_CELESTE_LEVEL;  // const
        public static System.Int32 AK_MIDI_CC_PHASER_LEVEL;  // const
        public static System.Int32 AK_MIDI_CC_DATA_BUTTON_P1;  // const
        public static System.Int32 AK_MIDI_CC_DATA_BUTTON_M1;  // const
        public static System.Int32 AK_MIDI_CC_NON_REGISTER_COARSE;  // const
        public static System.Int32 AK_MIDI_CC_NON_REGISTER_FINE;  // const
        public static System.Int32 AK_MIDI_CC_ALL_SOUND_OFF;  // const
        public static System.Int32 AK_MIDI_CC_ALL_CONTROLLERS_OFF;  // const
        public static System.Int32 AK_MIDI_CC_LOCAL_KEYBOARD;  // const
        public static System.Int32 AK_MIDI_CC_ALL_NOTES_OFF;  // const
        public static System.Int32 AK_MIDI_CC_OMNI_MODE_OFF;  // const
        public static System.Int32 AK_MIDI_CC_OMNI_MODE_ON;  // const
        public static System.Int32 AK_MIDI_CC_OMNI_MONOPHONIC_ON;  // const
        public static System.Int32 AK_MIDI_CC_OMNI_POLYPHONIC_ON;  // const
        public static System.Int32 AK_MIDI_WWISE_CMD_PLAY;  // const
        public static System.Int32 AK_MIDI_WWISE_CMD_STOP;  // const
        public static System.Int32 AK_MIDI_WWISE_CMD_PAUSE;  // const
        public static System.Int32 AK_MIDI_WWISE_CMD_RESUME;  // const
        public static System.Int32 AK_MIDI_WWISE_CMD_SEEK_MS;  // const
        public static System.Int32 AK_MIDI_WWISE_CMD_SEEK_SAMPLES;  // const
        public static System.Int32 AK_SPEAKER_FRONT_LEFT;  // const
        public static System.Int32 AK_SPEAKER_FRONT_RIGHT;  // const
        public static System.Int32 AK_SPEAKER_FRONT_CENTER;  // const
        public static System.Int32 AK_SPEAKER_LOW_FREQUENCY;  // const
        public static System.Int32 AK_SPEAKER_BACK_LEFT;  // const
        public static System.Int32 AK_SPEAKER_BACK_RIGHT;  // const
        public static System.Int32 AK_SPEAKER_BACK_CENTER;  // const
        public static System.Int32 AK_SPEAKER_SIDE_LEFT;  // const
        public static System.Int32 AK_SPEAKER_SIDE_RIGHT;  // const
        public static System.Int32 AK_SPEAKER_TOP;  // const
        public static System.Int32 AK_SPEAKER_HEIGHT_FRONT_LEFT;  // const
        public static System.Int32 AK_SPEAKER_HEIGHT_FRONT_CENTER;  // const
        public static System.Int32 AK_SPEAKER_HEIGHT_FRONT_RIGHT;  // const
        public static System.Int32 AK_SPEAKER_HEIGHT_BACK_LEFT;  // const
        public static System.Int32 AK_SPEAKER_HEIGHT_BACK_CENTER;  // const
        public static System.Int32 AK_SPEAKER_HEIGHT_BACK_RIGHT;  // const
        public static System.Int32 AK_SPEAKER_SETUP_MONO;  // const
        public static System.Int32 AK_SPEAKER_SETUP_0POINT1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_1POINT1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_STEREO;  // const
        public static System.Int32 AK_SPEAKER_SETUP_2POINT1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_3STEREO;  // const
        public static System.Int32 AK_SPEAKER_SETUP_3POINT1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_4;  // const
        public static System.Int32 AK_SPEAKER_SETUP_4POINT1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_5;  // const
        public static System.Int32 AK_SPEAKER_SETUP_5POINT1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_6;  // const
        public static System.Int32 AK_SPEAKER_SETUP_6POINT1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_7;  // const
        public static System.Int32 AK_SPEAKER_SETUP_7POINT1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_SURROUND;  // const
        public static System.Int32 AK_SPEAKER_SETUP_DPL2;  // const
        public static System.Int32 AK_SPEAKER_SETUP_HEIGHT_2;  // const
        public static System.Int32 AK_SPEAKER_SETUP_HEIGHT_4;  // const
        public static System.Int32 AK_SPEAKER_SETUP_HEIGHT_5;  // const
        public static System.Int32 AK_SPEAKER_SETUP_HEIGHT_ALL;  // const
        public static System.Int32 AK_SPEAKER_SETUP_HEIGHT_4_TOP;  // const
        public static System.Int32 AK_SPEAKER_SETUP_HEIGHT_5_TOP;  // const
        public static System.Int32 AK_SPEAKER_SETUP_AURO_222;  // const
        public static System.Int32 AK_SPEAKER_SETUP_AURO_8;  // const
        public static System.Int32 AK_SPEAKER_SETUP_AURO_9;  // const
        public static System.Int32 AK_SPEAKER_SETUP_AURO_9POINT1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_AURO_10;  // const
        public static System.Int32 AK_SPEAKER_SETUP_AURO_10POINT1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_AURO_11;  // const
        public static System.Int32 AK_SPEAKER_SETUP_AURO_11POINT1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_AURO_11_740;  // const
        public static System.Int32 AK_SPEAKER_SETUP_AURO_11POINT1_740;  // const
        public static System.Int32 AK_SPEAKER_SETUP_AURO_13_751;  // const
        public static System.Int32 AK_SPEAKER_SETUP_AURO_13POINT1_751;  // const
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_5_0_2;  // const
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_5_1_2;  // const
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_6_0_2;  // const
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_6_1_2;  // const
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_6_0_4;  // const
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_6_1_4;  // const
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_7_0_2;  // const
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_7_1_2;  // const
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_7_0_4;  // const
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_7_1_4;  // const
        public static System.Int32 AK_SPEAKER_SETUP_ALL_SPEAKERS;  // const
        public static System.Int32 AK_IDX_SETUP_FRONT_LEFT;  // const
        public static System.Int32 AK_IDX_SETUP_FRONT_RIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_CENTER;  // const
        public static System.Int32 AK_IDX_SETUP_NOCENTER_BACK_LEFT;  // const
        public static System.Int32 AK_IDX_SETUP_NOCENTER_BACK_RIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_NOCENTER_SIDE_LEFT;  // const
        public static System.Int32 AK_IDX_SETUP_NOCENTER_SIDE_RIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_WITHCENTER_BACK_LEFT;  // const
        public static System.Int32 AK_IDX_SETUP_WITHCENTER_BACK_RIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_WITHCENTER_SIDE_LEFT;  // const
        public static System.Int32 AK_IDX_SETUP_WITHCENTER_SIDE_RIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_WITHCENTER_HEIGHT_FRONT_LEFT;  // const
        public static System.Int32 AK_IDX_SETUP_WITHCENTER_HEIGHT_FRONT_RIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_WITHCENTER_HEIGHT_BACK_LEFT;  // const
        public static System.Int32 AK_IDX_SETUP_WITHCENTER_HEIGHT_BACK_RIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_0_LFE;  // const
        public static System.Int32 AK_IDX_SETUP_1_CENTER;  // const
        public static System.Int32 AK_IDX_SETUP_1_LFE;  // const
        public static System.Int32 AK_IDX_SETUP_2_LEFT;  // const
        public static System.Int32 AK_IDX_SETUP_2_RIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_2_LFE;  // const
        public static System.Int32 AK_IDX_SETUP_3_LEFT;  // const
        public static System.Int32 AK_IDX_SETUP_3_RIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_3_CENTER;  // const
        public static System.Int32 AK_IDX_SETUP_3_LFE;  // const
        public static System.Int32 AK_IDX_SETUP_4_FRONTLEFT;  // const
        public static System.Int32 AK_IDX_SETUP_4_FRONTRIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_4_REARLEFT;  // const
        public static System.Int32 AK_IDX_SETUP_4_REARRIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_4_LFE;  // const
        public static System.Int32 AK_IDX_SETUP_5_FRONTLEFT;  // const
        public static System.Int32 AK_IDX_SETUP_5_FRONTRIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_5_CENTER;  // const
        public static System.Int32 AK_IDX_SETUP_5_REARLEFT;  // const
        public static System.Int32 AK_IDX_SETUP_5_REARRIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_5_LFE;  // const
        public static System.Int32 AK_IDX_SETUP_6_FRONTLEFT;  // const
        public static System.Int32 AK_IDX_SETUP_6_FRONTRIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_6_REARLEFT;  // const
        public static System.Int32 AK_IDX_SETUP_6_REARRIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_6_SIDELEFT;  // const
        public static System.Int32 AK_IDX_SETUP_6_SIDERIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_6_LFE;  // const
        public static System.Int32 AK_IDX_SETUP_7_FRONTLEFT;  // const
        public static System.Int32 AK_IDX_SETUP_7_FRONTRIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_7_CENTER;  // const
        public static System.Int32 AK_IDX_SETUP_7_REARLEFT;  // const
        public static System.Int32 AK_IDX_SETUP_7_REARRIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_7_SIDELEFT;  // const
        public static System.Int32 AK_IDX_SETUP_7_SIDERIGHT;  // const
        public static System.Int32 AK_IDX_SETUP_7_LFE;  // const
        public static System.Int32 AK_SPEAKER_SETUP_0_1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_1_0_CENTER;  // const
        public static System.Int32 AK_SPEAKER_SETUP_1_1_CENTER;  // const
        public static System.Int32 AK_SPEAKER_SETUP_2_0;  // const
        public static System.Int32 AK_SPEAKER_SETUP_2_1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_3_0;  // const
        public static System.Int32 AK_SPEAKER_SETUP_3_1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_FRONT;  // const
        public static System.Int32 AK_SPEAKER_SETUP_4_0;  // const
        public static System.Int32 AK_SPEAKER_SETUP_4_1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_5_0;  // const
        public static System.Int32 AK_SPEAKER_SETUP_5_1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_6_0;  // const
        public static System.Int32 AK_SPEAKER_SETUP_6_1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_7_0;  // const
        public static System.Int32 AK_SPEAKER_SETUP_7_1;  // const
        public static System.Int32 AK_SPEAKER_SETUP_DEFAULT_PLANE;  // const
        public static System.Int32 AK_SUPPORTED_STANDARD_CHANNEL_MASK;  // const
        public static System.Int32 AK_STANDARD_MAX_NUM_CHANNELS;  // const
        public static System.Int32 AK_MAX_AMBISONICS_ORDER;  // const
        public static System.Int32 AK_MAX_NUM_TEXTURE;  // const
        public static System.Int32 AK_MAX_REFLECT_ORDER;  // const
        public static System.Int32 AK_MAX_REFLECTION_PATH_LENGTH;  // const
        public static System.Int32 AK_STOCHASTIC_RESERVE_LENGTH;  // const
        public static System.Int32 AK_MAX_SOUND_PROPAGATION_DEPTH;  // const
        public static System.Int32 AK_MAX_SOUND_PROPAGATION_WIDTH;  // const
        public static System.Double AK_SA_DIFFRACTION_DOT_EPSILON;  // const
        public static System.Double AK_DEFAULT_GEOMETRY_POSITION_X;  // const
        public static System.Double AK_DEFAULT_GEOMETRY_POSITION_Y;  // const
        public static System.Double AK_DEFAULT_GEOMETRY_POSITION_Z;  // const
        public static System.Double AK_DEFAULT_GEOMETRY_FRONT_X;  // const
        public static System.Double AK_DEFAULT_GEOMETRY_FRONT_Y;  // const
        public static System.Double AK_DEFAULT_GEOMETRY_FRONT_Z;  // const
        public static System.Double AK_DEFAULT_GEOMETRY_TOP_X;  // const
        public static System.Double AK_DEFAULT_GEOMETRY_TOP_Y;  // const
        public static System.Double AK_DEFAULT_GEOMETRY_TOP_Z;  // const
        private static AkSoundEngine.GameObjectHashFunction gameObjectHash;  // static @ 0x0
        public static System.UInt32 AK_PENDING_EVENT_LOAD_ID;  // const

        // Properties
        System.UInt32 AK_INVALID_SHARE_SET_ID { get; /* RVA: 0x042BBFA4 */ }
        System.UInt32 AK_INVALID_PIPELINE_ID { get; /* RVA: 0x042BBF64 */ }
        System.UInt64 AK_INVALID_AUDIO_OBJECT_ID { get; /* RVA: 0x042BBEA4 */ }
        System.UInt32 AK_SOUNDBANK_VERSION { get; /* RVA: 0x042BC124 */ }
        System.UInt32 AkJobType_Generic { get; /* RVA: 0x042BC1A4 */ }
        System.UInt32 AkJobType_AudioProcessing { get; /* RVA: 0x042BC164 */ }
        System.UInt32 AkJobType_SpatialAudio { get; /* RVA: 0x042BC1E4 */ }
        System.UInt32 AK_NUM_JOB_TYPES { get; /* RVA: 0x042BC0E4 */ }
        System.UInt16 AK_INT { get; /* RVA: 0x042BBE64 */ }
        System.UInt16 AK_FLOAT { get; /* RVA: 0x042BBDE4 */ }
        System.Byte AK_INTERLEAVED { get; /* RVA: 0x042BBE24 */ }
        System.Byte AK_NONINTERLEAVED { get; /* RVA: 0x042BC0A4 */ }
        System.UInt32 AK_LE_NATIVE_BITSPERSAMPLE { get; /* RVA: 0x042BBFE4 */ }
        System.UInt32 AK_LE_NATIVE_SAMPLETYPE { get; /* RVA: 0x042BC064 */ }
        System.UInt32 AK_LE_NATIVE_INTERLEAVE { get; /* RVA: 0x042BC024 */ }
        System.Byte AK_INVALID_MIDI_CHANNEL { get; /* RVA: 0x042BBEE4 */ }
        System.Byte AK_INVALID_MIDI_NOTE { get; /* RVA: 0x042BBF24 */ }
        System.UInt32 kDefaultDiffractionMaxEdges { get; /* RVA: 0x042BC3B4 */ }
        System.UInt32 kDefaultDiffractionMaxPaths { get; /* RVA: 0x042BC3F4 */ }
        System.Single kMaxDiffraction { get; /* RVA: 0x042BC4F4 */ }
        System.UInt32 kHashListBlockAllocItemCount { get; /* RVA: 0x042BC4B4 */ }
        System.UInt32 kDiffractionMaxEdges { get; /* RVA: 0x042BC434 */ }
        System.UInt32 kDiffractionMaxPaths { get; /* RVA: 0x042BC474 */ }
        System.UInt32 kPortalToPortalDiffractionMaxPaths { get; /* RVA: 0x042BC534 */ }
        AkSoundEngine.GameObjectHashFunction GameObjectHash { set; /* RVA: 0x042BC574 */ }
        System.String WwiseVersion { get; /* RVA: 0x042BC224 */ }

        // Methods
        // RVA: 0x042B1EC4  token: 0x60009E0
        public static System.UInt32 JoystickIdToWwiseId(System.UInt32 joyStickID) { }
        // RVA: 0x042AE8E0  token: 0x60009E9
        public static UnityEngine.Vector3 ConvertAkVector64ToAkVector(AkVector64 in_) { }
        // RVA: 0x042AE9D8  token: 0x60009EA
        public static AkTransform ConvertAkWorldTransformToAkTransform(AkWorldTransform in_) { }
        // RVA: 0x042AE95C  token: 0x60009EB
        public static AkVector64 ConvertAkVectorToAkVector64(UnityEngine.Vector3 in_) { }
        // RVA: 0x042AE864  token: 0x60009EC
        public static AkWorldTransform ConvertAkTransformToAkWorldTransform(AkTransform in_) { }
        // RVA: 0x042B1E20  token: 0x60009F4
        public static System.Boolean IsBankCodecID(System.UInt32 in_codecID) { }
        // RVA: 0x042AED14  token: 0x60009F5
        public static System.UInt32 DynamicSequenceOpen(System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType) { }
        // RVA: 0x042AEDEC  token: 0x60009F6
        public static System.UInt32 DynamicSequenceOpen(System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        // RVA: 0x042AEF48  token: 0x60009F7
        public static System.UInt32 DynamicSequenceOpen(System.UInt64 in_gameObjectID) { }
        // RVA: 0x042AEAE8  token: 0x60009F8
        public static AKRESULT DynamicSequenceClose(System.UInt32 in_playingID) { }
        // RVA: 0x042AF1AC  token: 0x60009F9
        public static AKRESULT DynamicSequencePlay(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042AF208  token: 0x60009FA
        public static AKRESULT DynamicSequencePlay(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration) { }
        // RVA: 0x042AF260  token: 0x60009FB
        public static AKRESULT DynamicSequencePlay(System.UInt32 in_playingID) { }
        // RVA: 0x042AF0F8  token: 0x60009FC
        public static AKRESULT DynamicSequencePause(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042AF154  token: 0x60009FD
        public static AKRESULT DynamicSequencePause(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration) { }
        // RVA: 0x042AF0B0  token: 0x60009FE
        public static AKRESULT DynamicSequencePause(System.UInt32 in_playingID) { }
        // RVA: 0x042AF348  token: 0x60009FF
        public static AKRESULT DynamicSequenceResume(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042AF2A8  token: 0x6000A00
        public static AKRESULT DynamicSequenceResume(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration) { }
        // RVA: 0x042AF300  token: 0x6000A01
        public static AKRESULT DynamicSequenceResume(System.UInt32 in_playingID) { }
        // RVA: 0x042AF3A4  token: 0x6000A02
        public static AKRESULT DynamicSequenceStop(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042AF400  token: 0x6000A03
        public static AKRESULT DynamicSequenceStop(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration) { }
        // RVA: 0x042AF458  token: 0x6000A04
        public static AKRESULT DynamicSequenceStop(System.UInt32 in_playingID) { }
        // RVA: 0x042AEAA0  token: 0x6000A05
        public static AKRESULT DynamicSequenceBreak(System.UInt32 in_playingID) { }
        // RVA: 0x042B7AC8  token: 0x6000A06
        public static AKRESULT Seek(System.UInt32 in_playingID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker) { }
        // RVA: 0x042B7B24  token: 0x6000A07
        public static AKRESULT Seek(System.UInt32 in_playingID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker) { }
        // RVA: 0x042AEB30  token: 0x6000A08
        public static AKRESULT DynamicSequenceGetPauseTimes(System.UInt32 in_playingID, System.UInt32& out_uTime, System.UInt32& out_uDuration) { }
        // RVA: 0x042AEB90  token: 0x6000A09
        public static AkPlaylist DynamicSequenceLockPlaylist(System.UInt32 in_playingID) { }
        // RVA: 0x042AF4A0  token: 0x6000A0A
        public static AKRESULT DynamicSequenceUnlockPlaylist(System.UInt32 in_playingID) { }
        // RVA: 0x026903F0  token: 0x6000A0B
        public static System.Boolean IsInitialized() { }
        // RVA: 0x042AFF24  token: 0x6000A0C
        public static AKRESULT GetAudioSettings(AkAudioSettings out_audioSettings) { }
        // RVA: 0x042B1714  token: 0x6000A0D
        public static AkChannelConfig GetSpeakerConfiguration(System.UInt64 in_idOutput) { }
        // RVA: 0x02690190  token: 0x6000A0E
        public static AkChannelConfig GetSpeakerConfiguration() { }
        // RVA: 0x042B0C20  token: 0x6000A0F
        public static AKRESULT GetOutputDeviceConfiguration(System.UInt64 in_idOutput, AkChannelConfig io_channelConfig, Ak3DAudioSinkCapabilities io_capabilities) { }
        // RVA: 0x042B0DA0  token: 0x6000A10
        public static AKRESULT GetPanningRule(System.Int32& out_ePanningRule, System.UInt64 in_idOutput) { }
        // RVA: 0x042B0D54  token: 0x6000A11
        public static AKRESULT GetPanningRule(System.Int32& out_ePanningRule) { }
        // RVA: 0x042B9BB0  token: 0x6000A12
        public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule, System.UInt64 in_idOutput) { }
        // RVA: 0x042B9B68  token: 0x6000A13
        public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule) { }
        // RVA: 0x042B1640  token: 0x6000A14
        public static AKRESULT GetSpeakerAngles(System.Single[] io_pfSpeakerAngles, System.UInt32& io_uNumAngles, System.Single& out_fHeightAngle, System.UInt64 in_idOutput) { }
        // RVA: 0x042B16B4  token: 0x6000A15
        public static AKRESULT GetSpeakerAngles(System.Single[] io_pfSpeakerAngles, System.UInt32& io_uNumAngles, System.Single& out_fHeightAngle) { }
        // RVA: 0x042BAA5C  token: 0x6000A16
        public static AKRESULT SetSpeakerAngles(System.Single[] in_pfSpeakerAngles, System.UInt32 in_uNumAngles, System.Single in_fHeightAngle, System.UInt64 in_idOutput) { }
        // RVA: 0x042BAAD0  token: 0x6000A17
        public static AKRESULT SetSpeakerAngles(System.Single[] in_pfSpeakerAngles, System.UInt32 in_uNumAngles, System.Single in_fHeightAngle) { }
        // RVA: 0x042BAD54  token: 0x6000A18
        public static AKRESULT SetVolumeThreshold(System.Single in_fVolumeThresholdDB) { }
        // RVA: 0x042B8E00  token: 0x6000A19
        public static AKRESULT SetMaxNumVoicesLimit(System.UInt16 in_maxNumberVoices) { }
        // RVA: 0x042B8A44  token: 0x6000A1A
        public static AKRESULT SetJobMgrMaxActiveWorkers(System.UInt32 in_jobType, System.UInt32 in_uNewMaxActiveWorkers) { }
        // RVA: 0x042B5FB8  token: 0x6000A1B
        public static AKRESULT RenderAudio(System.Boolean in_bAllowSyncRender) { }
        // RVA: 0x0269BCD0  token: 0x6000A1C
        public static AKRESULT RenderAudio() { }
        // RVA: 0x042B5AB0  token: 0x6000A1D
        public static AKRESULT RegisterPluginDLL(System.String in_DllName, System.String in_DllPath) { }
        // RVA: 0x042B5B0C  token: 0x6000A1E
        public static AKRESULT RegisterPluginDLL(System.String in_DllName) { }
        // RVA: 0x042B1E68  token: 0x6000A1F
        public static System.Boolean IsPluginRegistered(AkPluginType in_eType, System.UInt32 in_ulCompanyID, System.UInt32 in_ulPluginID) { }
        // RVA: 0x035940E0  token: 0x6000A20
        public static System.UInt32 GetIDFromString(System.String in_pszString) { }
        // RVA: 0x042B2DA4  token: 0x6000A21
        public static System.UInt32 PostEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources, System.UInt32 in_PlayingID) { }
        // RVA: 0x02950580  token: 0x6000A22
        public static System.UInt32 PostEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources) { }
        // RVA: 0x0269E1D0  token: 0x6000A23
        public static System.UInt32 PostEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        // RVA: 0x042B3124  token: 0x6000A24
        public static System.UInt32 PostEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID) { }
        // RVA: 0x042B38D4  token: 0x6000A25
        public static System.UInt32 PostEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources, System.UInt32 in_PlayingID) { }
        // RVA: 0x042B3014  token: 0x6000A26
        public static System.UInt32 PostEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources) { }
        // RVA: 0x042B36FC  token: 0x6000A27
        public static System.UInt32 PostEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        // RVA: 0x042B3418  token: 0x6000A28
        public static System.UInt32 PostEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID) { }
        // RVA: 0x042AF9D0  token: 0x6000A29
        public static AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, System.UInt32 in_PlayingID) { }
        // RVA: 0x042AF79C  token: 0x6000A2A
        public static AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042AFD88  token: 0x6000A2B
        public static AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration) { }
        // RVA: 0x042AF580  token: 0x6000A2C
        public static AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID) { }
        // RVA: 0x042AFB40  token: 0x6000A2D
        public static AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType) { }
        // RVA: 0x042AF718  token: 0x6000A2E
        public static AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, System.UInt32 in_PlayingID) { }
        // RVA: 0x042AFAC4  token: 0x6000A2F
        public static AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042AFA50  token: 0x6000A30
        public static AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration) { }
        // RVA: 0x042AF5DC  token: 0x6000A31
        public static AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID) { }
        // RVA: 0x042AF6C0  token: 0x6000A32
        public static AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType) { }
        // RVA: 0x042B39F8  token: 0x6000A33
        public static System.UInt32 PostMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, AkMIDIPostArray in_pPosts, System.UInt16 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_playingID) { }
        // RVA: 0x042B3D24  token: 0x6000A34
        public static System.UInt32 PostMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, AkMIDIPostArray in_pPosts, System.UInt16 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        // RVA: 0x042B3C74  token: 0x6000A35
        public static System.UInt32 PostMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, AkMIDIPostArray in_pPosts, System.UInt16 in_uNumPosts, System.Boolean in_bAbsoluteOffsets) { }
        // RVA: 0x042B3BCC  token: 0x6000A36
        public static System.UInt32 PostMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, AkMIDIPostArray in_pPosts, System.UInt16 in_uNumPosts) { }
        // RVA: 0x042BB230  token: 0x6000A37
        public static AKRESULT StopMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_playingID) { }
        // RVA: 0x042BB1D8  token: 0x6000A38
        public static AKRESULT StopMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID) { }
        // RVA: 0x042BB190  token: 0x6000A39
        public static AKRESULT StopMIDIOnEvent(System.UInt32 in_eventID) { }
        // RVA: 0x042BB150  token: 0x6000A3A
        public static AKRESULT StopMIDIOnEvent() { }
        // RVA: 0x042B277C  token: 0x6000A3B
        public static AKRESULT PinEventInStreamCache(System.UInt32 in_eventID, System.SByte in_uActivePriority, System.SByte in_uInactivePriority) { }
        // RVA: 0x042B27DC  token: 0x6000A3C
        public static AKRESULT PinEventInStreamCache(System.String in_pszEventName, System.SByte in_uActivePriority, System.SByte in_uInactivePriority) { }
        // RVA: 0x042BB9D8  token: 0x6000A3D
        public static AKRESULT UnpinEventInStreamCache(System.UInt32 in_eventID) { }
        // RVA: 0x042BB98C  token: 0x6000A3E
        public static AKRESULT UnpinEventInStreamCache(System.String in_pszEventName) { }
        // RVA: 0x042B0018  token: 0x6000A3F
        public static AKRESULT GetBufferStatusForPinnedEvent(System.UInt32 in_eventID, System.Single& out_fPercentBuffered, System.Int32& out_bCachePinnedMemoryFull) { }
        // RVA: 0x042AFFB8  token: 0x6000A40
        public static AKRESULT GetBufferStatusForPinnedEvent(System.String in_pszEventName, System.Single& out_fPercentBuffered, System.Int32& out_bCachePinnedMemoryFull) { }
        // RVA: 0x042B6FC8  token: 0x6000A41
        public static AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID) { }
        // RVA: 0x042B70C0  token: 0x6000A42
        public static AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker) { }
        // RVA: 0x042B749C  token: 0x6000A43
        public static AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Int32 in_iPosition) { }
        // RVA: 0x042B7240  token: 0x6000A44
        public static AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID) { }
        // RVA: 0x042B6E80  token: 0x6000A45
        public static AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker) { }
        // RVA: 0x042B79E0  token: 0x6000A46
        public static AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Int32 in_iPosition) { }
        // RVA: 0x042B76C0  token: 0x6000A47
        public static AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID) { }
        // RVA: 0x042B6EF4  token: 0x6000A48
        public static AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker) { }
        // RVA: 0x042B6F68  token: 0x6000A49
        public static AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Single in_fPercent) { }
        // RVA: 0x042B7044  token: 0x6000A4A
        public static AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID) { }
        // RVA: 0x042B71CC  token: 0x6000A4B
        public static AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker) { }
        // RVA: 0x042B78E8  token: 0x6000A4C
        public static AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Single in_fPercent) { }
        // RVA: 0x042AE420  token: 0x6000A4D
        public static System.Void CancelEventCallbackCookie(System.Object in_pCookie) { }
        // RVA: 0x042AE4D4  token: 0x6000A4E
        public static System.Void CancelEventCallbackGameObject(System.UInt64 in_gameObjectID) { }
        // RVA: 0x042AE520  token: 0x6000A4F
        public static System.Void CancelEventCallback(System.UInt32 in_playingID) { }
        // RVA: 0x042B1580  token: 0x6000A50
        public static AKRESULT GetSourcePlayPosition(System.UInt32 in_PlayingID, System.Int32& out_puPosition, System.Boolean in_bExtrapolate) { }
        // RVA: 0x042B1528  token: 0x6000A51
        public static AKRESULT GetSourcePlayPosition(System.UInt32 in_PlayingID, System.Int32& out_puPosition) { }
        // RVA: 0x042B15E0  token: 0x6000A52
        public static AKRESULT GetSourceStreamBuffering(System.UInt32 in_PlayingID, System.Int32& out_buffering, System.Int32& out_bIsBuffering) { }
        // RVA: 0x02AF8640  token: 0x6000A53
        public static System.Void StopAll(System.UInt64 in_gameObjectID) { }
        // RVA: 0x042BAFCC  token: 0x6000A54
        public static System.Void StopAll() { }
        // RVA: 0x042BB2D0  token: 0x6000A55
        public static System.Void StopPlayingID(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042BB32C  token: 0x6000A56
        public static System.Void StopPlayingID(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration) { }
        // RVA: 0x042BB384  token: 0x6000A57
        public static System.Void StopPlayingID(System.UInt32 in_playingID) { }
        // RVA: 0x042AFE50  token: 0x6000A58
        public static System.Void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x02A9E740  token: 0x6000A59
        public static System.Void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, System.UInt32 in_playingID, System.Int32 in_uTransitionDuration) { }
        // RVA: 0x042AFDF8  token: 0x6000A5A
        public static System.Void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, System.UInt32 in_playingID) { }
        // RVA: 0x042BA8E4  token: 0x6000A5B
        public static System.Void SetRandomSeed(System.UInt32 in_uSeed) { }
        // RVA: 0x042B26F0  token: 0x6000A5C
        public static System.Void MuteBackgroundMusic(System.Boolean in_bMute) { }
        // RVA: 0x042AFF78  token: 0x6000A5D
        public static System.Boolean GetBackgroundMusicMute() { }
        // RVA: 0x042B7B84  token: 0x6000A5E
        public static AKRESULT SendPluginCustomGameData(System.UInt32 in_busID, System.UInt64 in_busObjectID, AkPluginType in_eType, System.UInt32 in_uCompanyID, System.UInt32 in_uPluginID, System.IntPtr in_pData, System.UInt32 in_uSizeInBytes) { }
        // RVA: 0x042BBA20  token: 0x6000A5F
        public static AKRESULT UnregisterAllGameObj() { }
        // RVA: 0x042B90BC  token: 0x6000A60
        public static AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkPositionArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType, AkSetPositionFlags in_eFlags) { }
        // RVA: 0x032879F0  token: 0x6000A61
        public static AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkPositionArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType) { }
        // RVA: 0x042B94C8  token: 0x6000A62
        public static AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkPositionArray in_pPositions, System.UInt16 in_NumPositions) { }
        // RVA: 0x042B914C  token: 0x6000A63
        public static AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkChannelEmitterArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType, AkSetPositionFlags in_eFlags) { }
        // RVA: 0x042B9250  token: 0x6000A64
        public static AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkChannelEmitterArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType) { }
        // RVA: 0x042B91DC  token: 0x6000A65
        public static AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkChannelEmitterArray in_pPositions, System.UInt16 in_NumPositions) { }
        // RVA: 0x02EA23A0  token: 0x6000A66
        public static AKRESULT SetScalingFactor(System.UInt64 in_GameObjectID, System.Single in_fAttenuationScalingFactor) { }
        // RVA: 0x042B8060  token: 0x6000A67
        public static AKRESULT SetDistanceProbe(System.UInt64 in_listenerGameObjectID, System.UInt64 in_distanceProbeGameObjectID) { }
        // RVA: 0x042AE650  token: 0x6000A68
        public static AKRESULT ClearBanks() { }
        // RVA: 0x042B7D80  token: 0x6000A69
        public static AKRESULT SetBankLoadIOSettings(System.Single in_fThroughput, System.SByte in_priority) { }
        // RVA: 0x042B2550  token: 0x6000A6A
        public static AKRESULT LoadBank(System.String in_pszString, System.UInt32& out_bankID, System.UInt32 in_bankType) { }
        // RVA: 0x042B249C  token: 0x6000A6B
        public static AKRESULT LoadBank(System.String in_pszString, System.UInt32& out_bankID) { }
        // RVA: 0x042B24F8  token: 0x6000A6C
        public static AKRESULT LoadBank(System.UInt32 in_bankID, System.UInt32 in_bankType) { }
        // RVA: 0x02951F10  token: 0x6000A6D
        public static AKRESULT LoadBank(System.UInt32 in_bankID) { }
        // RVA: 0x042B2258  token: 0x6000A6E
        public static AKRESULT LoadBankMemoryView(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, System.UInt32& out_bankID) { }
        // RVA: 0x042B21E4  token: 0x6000A6F
        public static AKRESULT LoadBankMemoryView(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, System.UInt32& out_bankID, System.UInt32& out_bankType) { }
        // RVA: 0x042B1FB0  token: 0x6000A70
        public static AKRESULT LoadBankMemoryCopy(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, System.UInt32& out_bankID) { }
        // RVA: 0x042B2010  token: 0x6000A71
        public static AKRESULT LoadBankMemoryCopy(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, System.UInt32& out_bankID, System.UInt32& out_bankType) { }
        // RVA: 0x042B23F8  token: 0x6000A72
        public static AKRESULT LoadBank(System.String in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID, System.UInt32 in_bankType) { }
        // RVA: 0x042B235C  token: 0x6000A73
        public static AKRESULT LoadBank(System.String in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID) { }
        // RVA: 0x0269FDF0  token: 0x6000A74
        public static AKRESULT LoadBank(System.UInt32 in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32 in_bankType) { }
        // RVA: 0x03594170  token: 0x6000A75
        public static AKRESULT LoadBank(System.UInt32 in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        // RVA: 0x042B22B8  token: 0x6000A76
        public static AKRESULT LoadBankMemoryView(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID) { }
        // RVA: 0x042B2134  token: 0x6000A77
        public static AKRESULT LoadBankMemoryView(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID, System.UInt32& out_bankType) { }
        // RVA: 0x042B1F0C  token: 0x6000A78
        public static AKRESULT LoadBankMemoryCopy(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID) { }
        // RVA: 0x042B2084  token: 0x6000A79
        public static AKRESULT LoadBankMemoryCopy(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID, System.UInt32& out_bankType) { }
        // RVA: 0x042BB7D4  token: 0x6000A7A
        public static AKRESULT UnloadBank(System.String in_pszString, System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_bankType) { }
        // RVA: 0x042BB894  token: 0x6000A7B
        public static AKRESULT UnloadBank(System.String in_pszString, System.IntPtr in_pInMemoryBankPtr) { }
        // RVA: 0x042BB834  token: 0x6000A7C
        public static AKRESULT UnloadBank(System.UInt32 in_bankID, System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_bankType) { }
        // RVA: 0x042BB63C  token: 0x6000A7D
        public static AKRESULT UnloadBank(System.UInt32 in_bankID, System.IntPtr in_pInMemoryBankPtr) { }
        // RVA: 0x042BB694  token: 0x6000A7E
        public static AKRESULT UnloadBank(System.String in_pszString, System.IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32 in_bankType) { }
        // RVA: 0x042BB8F0  token: 0x6000A7F
        public static AKRESULT UnloadBank(System.String in_pszString, System.IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        // RVA: 0x026A0510  token: 0x6000A80
        public static AKRESULT UnloadBank(System.UInt32 in_bankID, System.IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32 in_bankType) { }
        // RVA: 0x042BB738  token: 0x6000A81
        public static AKRESULT UnloadBank(System.UInt32 in_bankID, System.IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        // RVA: 0x042AE3D4  token: 0x6000A82
        public static System.Void CancelBankCallbackCookie(System.Object in_pCookie) { }
        // RVA: 0x042B471C  token: 0x6000A83
        public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString, AkBankContent in_uFlags, System.UInt32 in_bankType) { }
        // RVA: 0x042B493C  token: 0x6000A84
        public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString, AkBankContent in_uFlags) { }
        // RVA: 0x042B4490  token: 0x6000A85
        public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString) { }
        // RVA: 0x042B499C  token: 0x6000A86
        public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID, AkBankContent in_uFlags, System.UInt32 in_bankType) { }
        // RVA: 0x042B4834  token: 0x6000A87
        public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID, AkBankContent in_uFlags) { }
        // RVA: 0x042B46C4  token: 0x6000A88
        public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID) { }
        // RVA: 0x042B4890  token: 0x6000A89
        public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, AkBankContent in_uFlags, System.UInt32 in_bankType) { }
        // RVA: 0x042B4790  token: 0x6000A8A
        public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, AkBankContent in_uFlags) { }
        // RVA: 0x042B44E8  token: 0x6000A8B
        public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        // RVA: 0x042B4584  token: 0x6000A8C
        public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, AkBankContent in_uFlags, System.UInt32 in_bankType) { }
        // RVA: 0x042B43F0  token: 0x6000A8D
        public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, AkBankContent in_uFlags) { }
        // RVA: 0x042B462C  token: 0x6000A8E
        public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        // RVA: 0x042AE824  token: 0x6000A8F
        public static AKRESULT ClearPreparedEvents() { }
        // RVA: 0x042B4CC0  token: 0x6000A90
        public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, System.String[] in_ppszString, System.UInt32 in_uNumEvent) { }
        // RVA: 0x042B4A0C  token: 0x6000A91
        public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, System.UInt32[] in_pEventID, System.UInt32 in_uNumEvent) { }
        // RVA: 0x042B4A6C  token: 0x6000A92
        public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, System.String[] in_ppszString, System.UInt32 in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        // RVA: 0x0269FD40  token: 0x6000A93
        public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, System.UInt32[] in_pEventID, System.UInt32 in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        // RVA: 0x042B8E4C  token: 0x6000A94
        public static AKRESULT SetMedia(AkSourceSettingsArray in_pSourceSettings, System.UInt32 in_uNumSourceSettings) { }
        // RVA: 0x042BBCA4  token: 0x6000A95
        public static AKRESULT UnsetMedia(AkSourceSettingsArray in_pSourceSettings, System.UInt32 in_uNumSourceSettings) { }
        // RVA: 0x042B4F48  token: 0x6000A96
        public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, System.String in_pszGroupName, System.String[] in_ppszGameSyncName, System.UInt32 in_uNumGameSyncs) { }
        // RVA: 0x042B4ED0  token: 0x6000A97
        public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, System.UInt32 in_GroupID, System.UInt32[] in_paGameSyncID, System.UInt32 in_uNumGameSyncs) { }
        // RVA: 0x042B5234  token: 0x6000A98
        public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, System.String in_pszGroupName, System.String[] in_ppszGameSyncName, System.UInt32 in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        // RVA: 0x042B5174  token: 0x6000A99
        public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, System.UInt32 in_GroupID, System.UInt32[] in_paGameSyncID, System.UInt32 in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        // RVA: 0x042ADF50  token: 0x6000A9A
        public static AKRESULT AddListener(System.UInt64 in_emitterGameObj, System.UInt64 in_listenerGameObj) { }
        // RVA: 0x042B5E78  token: 0x6000A9B
        public static AKRESULT RemoveListener(System.UInt64 in_emitterGameObj, System.UInt64 in_listenerGameObj) { }
        // RVA: 0x042ADF04  token: 0x6000A9C
        public static AKRESULT AddDefaultListener(System.UInt64 in_listenerGameObj) { }
        // RVA: 0x042B5BC0  token: 0x6000A9D
        public static AKRESULT RemoveDefaultListener(System.UInt64 in_listenerGameObj) { }
        // RVA: 0x042B6144  token: 0x6000A9E
        public static AKRESULT ResetListenersToDefault(System.UInt64 in_emitterGameObj) { }
        // RVA: 0x042B8B10  token: 0x6000A9F
        public static AKRESULT SetListenerSpatialization(System.UInt64 in_uListenerID, System.Boolean in_bSpatialized, AkChannelConfig in_channelConfig, System.Single[] in_pVolumeOffsets) { }
        // RVA: 0x042B8A9C  token: 0x6000AA0
        public static AKRESULT SetListenerSpatialization(System.UInt64 in_uListenerID, System.Boolean in_bSpatialized, AkChannelConfig in_channelConfig) { }
        // RVA: 0x042BA224  token: 0x6000AA1
        public static AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        // RVA: 0x042BA148  token: 0x6000AA2
        public static AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x02830B70  token: 0x6000AA3
        public static AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration) { }
        // RVA: 0x042BA1C4  token: 0x6000AA4
        public static AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, System.UInt64 in_gameObjectID) { }
        // RVA: 0x042BA6E0  token: 0x6000AA5
        public static AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value) { }
        // RVA: 0x042BA0BC  token: 0x6000AA6
        public static AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        // RVA: 0x042BA320  token: 0x6000AA7
        public static AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042BA2AC  token: 0x6000AA8
        public static AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration) { }
        // RVA: 0x042BA680  token: 0x6000AA9
        public static AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, System.UInt64 in_gameObjectID) { }
        // RVA: 0x042BA888  token: 0x6000AAA
        public static AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value) { }
        // RVA: 0x042B9D8C  token: 0x6000AAB
        public static AKRESULT SetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        // RVA: 0x042B9EA0  token: 0x6000AAC
        public static AKRESULT SetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x02A36110  token: 0x6000AAD
        public static AKRESULT SetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration) { }
        // RVA: 0x042B9CCC  token: 0x6000AAE
        public static AKRESULT SetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.Single in_value, System.UInt32 in_playingID) { }
        // RVA: 0x042B9E14  token: 0x6000AAF
        public static AKRESULT SetRTPCValueByPlayingID(System.String in_pszRtpcName, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        // RVA: 0x042B9F1C  token: 0x6000AB0
        public static AKRESULT SetRTPCValueByPlayingID(System.String in_pszRtpcName, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042B9F98  token: 0x6000AB1
        public static AKRESULT SetRTPCValueByPlayingID(System.String in_pszRtpcName, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration) { }
        // RVA: 0x042B9D2C  token: 0x6000AB2
        public static AKRESULT SetRTPCValueByPlayingID(System.String in_pszRtpcName, System.Single in_value, System.UInt32 in_playingID) { }
        // RVA: 0x042B6A30  token: 0x6000AB3
        public static AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        // RVA: 0x042B6974  token: 0x6000AB4
        public static AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042B6758  token: 0x6000AB5
        public static AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration) { }
        // RVA: 0x042B691C  token: 0x6000AB6
        public static AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, System.UInt64 in_gameObjectID) { }
        // RVA: 0x042B69E8  token: 0x6000AB7
        public static AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID) { }
        // RVA: 0x042B67B8  token: 0x6000AB8
        public static AKRESULT ResetRTPCValue(System.String in_pszRtpcName, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        // RVA: 0x042B6834  token: 0x6000AB9
        public static AKRESULT ResetRTPCValue(System.String in_pszRtpcName, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042B64D4  token: 0x6000ABA
        public static AKRESULT ResetRTPCValue(System.String in_pszRtpcName, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration) { }
        // RVA: 0x042B6CD0  token: 0x6000ABB
        public static AKRESULT ResetRTPCValue(System.String in_pszRtpcName, System.UInt64 in_gameObjectID) { }
        // RVA: 0x042B6BEC  token: 0x6000ABC
        public static AKRESULT ResetRTPCValue(System.String in_pszRtpcName) { }
        // RVA: 0x042B62B8  token: 0x6000ABD
        public static AKRESULT ResetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        // RVA: 0x042B6190  token: 0x6000ABE
        public static AKRESULT ResetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042B6388  token: 0x6000ABF
        public static AKRESULT ResetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration) { }
        // RVA: 0x042B6200  token: 0x6000AC0
        public static AKRESULT ResetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.UInt32 in_playingID) { }
        // RVA: 0x042B63E4  token: 0x6000AC1
        public static AKRESULT ResetRTPCValueByPlayingID(System.String in_pszRtpcName, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        // RVA: 0x042B6460  token: 0x6000AC2
        public static AKRESULT ResetRTPCValueByPlayingID(System.String in_pszRtpcName, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042B6258  token: 0x6000AC3
        public static AKRESULT ResetRTPCValueByPlayingID(System.String in_pszRtpcName, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration) { }
        // RVA: 0x042B6330  token: 0x6000AC4
        public static AKRESULT ResetRTPCValueByPlayingID(System.String in_pszRtpcName, System.UInt32 in_playingID) { }
        // RVA: 0x042BAB8C  token: 0x6000AC5
        public static AKRESULT SetSwitch(System.UInt32 in_switchGroup, System.UInt32 in_switchState, System.UInt64 in_gameObjectID) { }
        // RVA: 0x042BAC70  token: 0x6000AC6
        public static AKRESULT SetSwitch(System.String in_pszSwitchGroup, System.String in_pszSwitchState, System.UInt64 in_gameObjectID) { }
        // RVA: 0x042B4398  token: 0x6000AC7
        public static AKRESULT PostTrigger(System.UInt32 in_triggerID, System.UInt64 in_gameObjectID) { }
        // RVA: 0x042B4250  token: 0x6000AC8
        public static AKRESULT PostTrigger(System.String in_pszTrigger, System.UInt64 in_gameObjectID) { }
        // RVA: 0x032322E0  token: 0x6000AC9
        public static AKRESULT SetState(System.UInt32 in_stateGroup, System.UInt32 in_state) { }
        // RVA: 0x042BAB30  token: 0x6000ACA
        public static AKRESULT SetState(System.String in_pszStateGroup, System.String in_pszState) { }
        // RVA: 0x042B837C  token: 0x6000ACB
        public static AKRESULT SetGameObjectAuxSendValues(System.UInt64 in_gameObjectID, AkAuxSendArray in_aAuxSendValues, System.UInt32 in_uNumSendValues) { }
        // RVA: 0x042B8554  token: 0x6000ACC
        public static AKRESULT SetGameObjectOutputBusVolume(System.UInt64 in_emitterObjID, System.UInt64 in_listenerObjID, System.Single in_fControlValue) { }
        // RVA: 0x042B7CC8  token: 0x6000ACD
        public static AKRESULT SetActorMixerEffect(System.UInt32 in_audioNodeID, System.UInt32 in_uFXIndex, System.UInt32 in_shareSetID) { }
        // RVA: 0x042B7FA4  token: 0x6000ACE
        public static AKRESULT SetBusEffect(System.UInt32 in_audioNodeID, System.UInt32 in_uFXIndex, System.UInt32 in_shareSetID) { }
        // RVA: 0x042B8000  token: 0x6000ACF
        public static AKRESULT SetBusEffect(System.String in_pszBusName, System.UInt32 in_uFXIndex, System.UInt32 in_shareSetID) { }
        // RVA: 0x042B9AAC  token: 0x6000AD0
        public static AKRESULT SetOutputDeviceEffect(System.UInt64 in_outputDeviceID, System.UInt32 in_uFXIndex, System.UInt32 in_FXShareSetID) { }
        // RVA: 0x042B8EB8  token: 0x6000AD1
        public static AKRESULT SetMixer(System.UInt32 in_audioNodeID, System.UInt32 in_shareSetID) { }
        // RVA: 0x042B8F10  token: 0x6000AD2
        public static AKRESULT SetMixer(System.String in_pszBusName, System.UInt32 in_shareSetID) { }
        // RVA: 0x042B7E8C  token: 0x6000AD3
        public static AKRESULT SetBusConfig(System.UInt32 in_audioNodeID, AkChannelConfig in_channelConfig) { }
        // RVA: 0x042B7E28  token: 0x6000AD4
        public static AKRESULT SetBusConfig(System.String in_pszBusName, AkChannelConfig in_channelConfig) { }
        // RVA: 0x042B967C  token: 0x6000AD5
        public static AKRESULT SetObjectObstructionAndOcclusion(System.UInt64 in_EmitterID, System.UInt64 in_ListenerID, System.Single in_fObstructionLevel, System.Single in_fOcclusionLevel) { }
        // RVA: 0x042B8F68  token: 0x6000AD6
        public static AKRESULT SetMultipleObstructionAndOcclusion(System.UInt64 in_EmitterID, System.UInt64 in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, System.UInt32 in_uNumOcclusionObstruction) { }
        // RVA: 0x042BADF0  token: 0x6000AD7
        public static AKRESULT StartOutputCapture(System.String in_CaptureFileName) { }
        // RVA: 0x042BB290  token: 0x6000AD8
        public static AKRESULT StopOutputCapture() { }
        // RVA: 0x042AE088  token: 0x6000AD9
        public static AKRESULT AddOutputCaptureMarker(System.String in_MarkerText) { }
        // RVA: 0x042AE030  token: 0x6000ADA
        public static AKRESULT AddOutputCaptureBinaryMarker(System.IntPtr in_pMarkerData, System.UInt32 in_uMarkerDataSize) { }
        // RVA: 0x042B13A8  token: 0x6000ADB
        public static System.UInt32 GetSampleRate() { }
        // RVA: 0x042BAE7C  token: 0x6000ADC
        public static AKRESULT StartProfilerCapture(System.String in_CaptureFileName) { }
        // RVA: 0x042BB40C  token: 0x6000ADD
        public static AKRESULT StopProfilerCapture() { }
        // RVA: 0x042B9A10  token: 0x6000ADE
        public static AKRESULT SetOfflineRenderingFrameTime(System.Single in_fFrameTimeInSeconds) { }
        // RVA: 0x042B9A60  token: 0x6000ADF
        public static AKRESULT SetOfflineRendering(System.Boolean in_bEnableOfflineRendering) { }
        // RVA: 0x042B5ED4  token: 0x6000AE0
        public static AKRESULT RemoveOutput(System.UInt64 in_idOutput) { }
        // RVA: 0x042B6068  token: 0x6000AE1
        public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, System.UInt64 in_outputDeviceId, System.UInt64& out_pOutputDeviceId) { }
        // RVA: 0x042B6004  token: 0x6000AE2
        public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, System.UInt64 in_outputDeviceId) { }
        // RVA: 0x042B0CA4  token: 0x6000AE3
        public static System.UInt64 GetOutputID(System.UInt32 in_idShareset, System.UInt32 in_idDevice) { }
        // RVA: 0x042B0CFC  token: 0x6000AE4
        public static System.UInt64 GetOutputID(System.String in_szShareSet, System.UInt32 in_idDevice) { }
        // RVA: 0x042B7F4C  token: 0x6000AE5
        public static AKRESULT SetBusDevice(System.UInt32 in_idBus, System.UInt32 in_idNewDevice) { }
        // RVA: 0x042B7EF0  token: 0x6000AE6
        public static AKRESULT SetBusDevice(System.String in_BusName, System.String in_DeviceName) { }
        // RVA: 0x042B0420  token: 0x6000AE7
        public static AKRESULT GetDeviceList(System.UInt32 in_ulCompanyID, System.UInt32 in_ulPluginID, System.UInt32& io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions) { }
        // RVA: 0x036181C0  token: 0x6000AE8
        public static AKRESULT GetDeviceList(System.UInt32 in_audioDeviceShareSetID, System.UInt32& io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions) { }
        // RVA: 0x042B9B0C  token: 0x6000AE9
        public static AKRESULT SetOutputVolume(System.UInt64 in_idOutput, System.Single in_fVolume) { }
        // RVA: 0x036180A0  token: 0x6000AEA
        public static AKRESULT GetDeviceSpatialAudioSupport(System.UInt32 in_idDevice) { }
        // RVA: 0x042BB560  token: 0x6000AEB
        public static AKRESULT Suspend(System.Boolean in_bRenderAnyway, System.Boolean in_bFadeOut) { }
        // RVA: 0x042BB4D4  token: 0x6000AEC
        public static AKRESULT Suspend(System.Boolean in_bRenderAnyway) { }
        // RVA: 0x042BB520  token: 0x6000AED
        public static AKRESULT Suspend() { }
        // RVA: 0x042BBD5C  token: 0x6000AEE
        public static AKRESULT WakeupFromSuspend(System.UInt32 in_uDelayMs) { }
        // RVA: 0x042BBDA4  token: 0x6000AEF
        public static AKRESULT WakeupFromSuspend() { }
        // RVA: 0x042B0078  token: 0x6000AF0
        public static System.UInt32 GetBufferTick() { }
        // RVA: 0x042B13E8  token: 0x6000AF1
        public static System.UInt64 GetSampleTick() { }
        // RVA: 0x042AE2D4  token: 0x6000AF4
        public static System.Void AkMemGetCategoryStats(System.Int32 in_poolId, AkMemCategroyStats out_poolStats) { }
        // RVA: 0x042AE338  token: 0x6000AF5
        public static System.Void AkMemGetGlobalStats(AkMemGlobalStats out_stats) { }
        // RVA: 0x042BAE3C  token: 0x6000AF6
        public static System.Void StartProfileThreadUsage() { }
        // RVA: 0x042BB3CC  token: 0x6000AF7
        public static System.UInt64 StopProfileThreadUsage() { }
        // RVA: 0x042AEA54  token: 0x6000AF8
        public static System.Void DumpToFile(System.String pszFilename) { }
        // RVA: 0x042B07E4  token: 0x6000AF9
        public static System.UInt64 GetGlobalUsed() { }
        // RVA: 0x042B07A4  token: 0x6000AFA
        public static System.UInt64 GetGlobalReserved() { }
        // RVA: 0x042B0EE4  token: 0x6000AFB
        public static AKRESULT GetPlayingSegmentInfo(System.UInt32 in_PlayingID, AkSegmentInfo out_segmentInfo, System.Boolean in_bExtrapolate) { }
        // RVA: 0x042B0F58  token: 0x6000AFC
        public static AKRESULT GetPlayingSegmentInfo(System.UInt32 in_PlayingID, AkSegmentInfo out_segmentInfo) { }
        // RVA: 0x042B2C28  token: 0x6000AFD
        public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.UInt32 in_audioNodeID, System.Boolean in_bIsBus) { }
        // RVA: 0x042B2A54  token: 0x6000AFE
        public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.UInt32 in_audioNodeID) { }
        // RVA: 0x042B28AC  token: 0x6000AFF
        public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID) { }
        // RVA: 0x042B2B74  token: 0x6000B00
        public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID) { }
        // RVA: 0x042B2BD0  token: 0x6000B01
        public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel) { }
        // RVA: 0x042B283C  token: 0x6000B02
        public static AKRESULT PostCodeVarArg(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, MsgContext msgContext) { }
        // RVA: 0x042B4060  token: 0x6000B03
        public static AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.UInt32 in_audioNodeID, System.Boolean in_bIsBus) { }
        // RVA: 0x042B3E44  token: 0x6000B04
        public static AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.UInt32 in_audioNodeID) { }
        // RVA: 0x042B413C  token: 0x6000B05
        public static AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID) { }
        // RVA: 0x042B4000  token: 0x6000B06
        public static AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID) { }
        // RVA: 0x042B40E4  token: 0x6000B07
        public static AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel) { }
        // RVA: 0x042B6D6C  token: 0x6000B08
        public static AKRESULT ResetTranslator() { }
        // RVA: 0x042B1A44  token: 0x6000B09
        public static System.Int32 GetTimeStamp() { }
        // RVA: 0x042B25B0  token: 0x6000B0A
        public static System.Void MonitorStreamMgrInit(AkStreamMgrSettings in_streamMgrSettings) { }
        // RVA: 0x042B268C  token: 0x6000B0B
        public static System.Void MonitorStreamingDeviceInit(System.UInt32 in_deviceID, AkDeviceSettings in_deviceSettings) { }
        // RVA: 0x042B2644  token: 0x6000B0C
        public static System.Void MonitorStreamingDeviceDestroyed(System.UInt32 in_deviceID) { }
        // RVA: 0x042B2604  token: 0x6000B0D
        public static System.Void MonitorStreamMgrTerm() { }
        // RVA: 0x042AE280  token: 0x6000B0E
        public static System.Void AkGetDefaultHighPriorityThreadProperties(AkThreadProperties out_threadProperties) { }
        // RVA: 0x042B6DAC  token: 0x6000B0F
        public static System.UInt32 ResolveDialogueEvent(System.UInt32 in_eventID, System.UInt32[] in_aArgumentValues, System.UInt32 in_uNumArguments, System.UInt32 in_idSequence) { }
        // RVA: 0x042B6E20  token: 0x6000B10
        public static System.UInt32 ResolveDialogueEvent(System.UInt32 in_eventID, System.UInt32[] in_aArgumentValues, System.UInt32 in_uNumArguments) { }
        // RVA: 0x042B0508  token: 0x6000B11
        public static AKRESULT GetDialogueEventCustomPropertyValue(System.UInt32 in_eventID, System.UInt32 in_uPropID, System.Int32& out_iValue) { }
        // RVA: 0x042B04AC  token: 0x6000B12
        public static AKRESULT GetDialogueEventCustomPropertyValue(System.UInt32 in_eventID, System.UInt32 in_uPropID, System.Single& out_fValue) { }
        // RVA: 0x042B0FBC  token: 0x6000B13
        public static AKRESULT GetPosition(System.UInt64 in_GameObjectID, AkWorldTransform out_rPosition) { }
        // RVA: 0x042B08D8  token: 0x6000B14
        public static AKRESULT GetListenerPosition(System.UInt64 in_uListenerID, AkWorldTransform out_rPosition) { }
        // RVA: 0x042B11B4  token: 0x6000B15
        public static AKRESULT GetRTPCValue(System.UInt32 in_rtpcID, System.UInt64 in_gameObjectID, System.UInt32 in_playingID, System.Single& out_rValue, System.Int32& io_rValueType) { }
        // RVA: 0x042B12D4  token: 0x6000B16
        public static AKRESULT GetRTPCValue(System.String in_pszRtpcName, System.UInt64 in_gameObjectID, System.UInt32 in_playingID, System.Single& out_rValue, System.Int32& io_rValueType) { }
        // RVA: 0x042B1878  token: 0x6000B17
        public static AKRESULT GetSwitch(System.UInt32 in_switchGroup, System.UInt64 in_gameObjectID, System.UInt32& out_rSwitchState) { }
        // RVA: 0x042B19E4  token: 0x6000B18
        public static AKRESULT GetSwitch(System.String in_pstrSwitchGroupName, System.UInt64 in_GameObj, System.UInt32& out_rSwitchState) { }
        // RVA: 0x042B17E0  token: 0x6000B19
        public static AKRESULT GetState(System.UInt32 in_stateGroup, System.UInt32& out_rState) { }
        // RVA: 0x042B1784  token: 0x6000B1A
        public static AKRESULT GetState(System.String in_pstrStateGroupName, System.UInt32& out_rState) { }
        // RVA: 0x042B05F8  token: 0x6000B1B
        public static AKRESULT GetGameObjectAuxSendValues(System.UInt64 in_gameObjectID, AkAuxSendArray out_paAuxSendValues, System.UInt32& io_ruNumSendValues) { }
        // RVA: 0x042B0668  token: 0x6000B1C
        public static AKRESULT GetGameObjectDryLevelValue(System.UInt64 in_EmitterID, System.UInt64 in_ListenerID, System.Single& out_rfControlValue) { }
        // RVA: 0x042B0B04  token: 0x6000B1D
        public static AKRESULT GetObjectObstructionAndOcclusion(System.UInt64 in_EmitterID, System.UInt64 in_ListenerID, System.Single& out_rfObstructionLevel, System.Single& out_rfOcclusionLevel) { }
        // RVA: 0x042B5518  token: 0x6000B1E
        public static AKRESULT QueryAudioObjectIDs(System.UInt32 in_eventID, System.UInt32& io_ruNumItems, AkObjectInfoArray out_aObjectInfos) { }
        // RVA: 0x042B549C  token: 0x6000B1F
        public static AKRESULT QueryAudioObjectIDs(System.String in_pszEventName, System.UInt32& io_ruNumItems, AkObjectInfoArray out_aObjectInfos) { }
        // RVA: 0x042B10AC  token: 0x6000B20
        public static AKRESULT GetPositioningInfo(System.UInt32 in_ObjectID, AkPositioningInfo out_rPositioningInfo) { }
        // RVA: 0x042B088C  token: 0x6000B21
        public static System.Boolean GetIsGameObjectActive(System.UInt64 in_GameObjId) { }
        // RVA: 0x042B0AB8  token: 0x6000B22
        public static System.Single GetMaxRadius(System.UInt64 in_GameObjId) { }
        // RVA: 0x02A9EFC0  token: 0x6000B23
        public static System.UInt32 GetEventIDFromPlayingID(System.UInt32 in_playingID) { }
        // RVA: 0x042B075C  token: 0x6000B24
        public static System.UInt64 GetGameObjectFromPlayingID(System.UInt32 in_playingID) { }
        // RVA: 0x042B0E84  token: 0x6000B25
        public static AKRESULT GetPlayingIDsFromGameObject(System.UInt64 in_GameObjId, System.UInt32& io_ruNumIDs, System.UInt32[] out_aPlayingIDs) { }
        // RVA: 0x042B0178  token: 0x6000B26
        public static AKRESULT GetCustomPropertyValue(System.UInt32 in_ObjectID, System.UInt32 in_uPropID, System.Int32& out_iValue) { }
        // RVA: 0x042B01D4  token: 0x6000B27
        public static AKRESULT GetCustomPropertyValue(System.UInt32 in_ObjectID, System.UInt32 in_uPropID, System.Single& out_fValue) { }
        // RVA: 0x042ADE04  token: 0x6000B28
        public static System.Void AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(System.UInt32& io_uChannelMask) { }
        // RVA: 0x042ADE50  token: 0x6000B29
        public static System.Void AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(System.UInt32& io_uChannelMask) { }
        // RVA: 0x042ADDB8  token: 0x6000B2A
        public static System.Void AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(System.UInt32& io_uChannelMask) { }
        // RVA: 0x042AE608  token: 0x6000B2B
        public static System.Byte ChannelMaskToNumChannels(System.UInt32 in_uChannelMask) { }
        // RVA: 0x042AE5C0  token: 0x6000B2C
        public static System.UInt32 ChannelMaskFromNumChannels(System.UInt32 in_uNumChannels) { }
        // RVA: 0x042AE568  token: 0x6000B2D
        public static System.Byte ChannelBitToIndex(System.UInt32 in_uChannelBit, System.UInt32 in_uChannelMask) { }
        // RVA: 0x042B1CDC  token: 0x6000B2E
        public static System.Boolean HasSurroundChannels(System.UInt32 in_uChannelMask) { }
        // RVA: 0x042B1C94  token: 0x6000B2F
        public static System.Boolean HasStrictlyOnePairOfSurroundChannels(System.UInt32 in_uChannelMask) { }
        // RVA: 0x042B1C4C  token: 0x6000B30
        public static System.Boolean HasSideAndRearChannels(System.UInt32 in_uChannelMask) { }
        // RVA: 0x042B1C04  token: 0x6000B31
        public static System.Boolean HasHeightChannels(System.UInt32 in_uChannelMask) { }
        // RVA: 0x042AE38C  token: 0x6000B32
        public static System.UInt32 BackToSideChannels(System.UInt32 in_uChannelMask) { }
        // RVA: 0x042BAF08  token: 0x6000B33
        public static System.UInt32 StdChannelIndexToDisplayIndex(AkChannelOrdering in_eOrdering, System.UInt32 in_uChannelMask, System.UInt32 in_uChannelIdx) { }
        // RVA: 0x042B85B4  token: 0x6000B3B
        public static AKRESULT SetGameObjectRadius(System.UInt64 in_gameObjectID, System.Single in_outerRadius, System.Single in_innerRadius) { }
        // RVA: 0x042B89BC  token: 0x6000B3C
        public static AKRESULT SetImageSource(System.UInt32 in_srcID, AkImageSourceSettings in_info, System.String in_name, System.UInt32 in_AuxBusID, System.UInt64 in_gameObjectID) { }
        // RVA: 0x042B893C  token: 0x6000B3D
        public static AKRESULT SetImageSource(System.UInt32 in_srcID, AkImageSourceSettings in_info, System.String in_name, System.UInt32 in_AuxBusID) { }
        // RVA: 0x042B88C8  token: 0x6000B3E
        public static AKRESULT SetImageSource(System.UInt32 in_srcID, AkImageSourceSettings in_info, System.String in_name) { }
        // RVA: 0x042B5D98  token: 0x6000B3F
        public static AKRESULT RemoveImageSource(System.UInt32 in_srcID, System.UInt32 in_AuxBusID, System.UInt64 in_gameObjectID) { }
        // RVA: 0x042B5C74  token: 0x6000B40
        public static AKRESULT RemoveImageSource(System.UInt32 in_srcID, System.UInt32 in_AuxBusID) { }
        // RVA: 0x042B5D50  token: 0x6000B41
        public static AKRESULT RemoveImageSource(System.UInt32 in_srcID) { }
        // RVA: 0x042AE744  token: 0x6000B42
        public static AKRESULT ClearImageSources(System.UInt32 in_AuxBusID, System.UInt64 in_gameObjectID) { }
        // RVA: 0x042AE79C  token: 0x6000B43
        public static AKRESULT ClearImageSources(System.UInt32 in_AuxBusID) { }
        // RVA: 0x042AE7E4  token: 0x6000B44
        public static AKRESULT ClearImageSources() { }
        // RVA: 0x031AE720  token: 0x6000B45
        public static AKRESULT RemoveGeometry(System.UInt64 in_SetID) { }
        // RVA: 0x02AF6AF0  token: 0x6000B46
        public static AKRESULT RemoveGeometryInstance(System.UInt64 in_GeometryInstanceID) { }
        // RVA: 0x02AF6A10  token: 0x6000B47
        public static AKRESULT RemoveRoom(System.UInt64 in_RoomID) { }
        // RVA: 0x042B5F20  token: 0x6000B48
        public static AKRESULT RemovePortal(System.UInt64 in_PortalID) { }
        // RVA: 0x031AD7E0  token: 0x6000B49
        public static AKRESULT SetReverbZone(System.UInt64 in_ReverbZone, System.UInt64 in_ParentRoom, System.Single in_transitionRegionWidth) { }
        // RVA: 0x042B5F6C  token: 0x6000B4A
        public static AKRESULT RemoveReverbZone(System.UInt64 in_ReverbZone) { }
        // RVA: 0x042B83EC  token: 0x6000B4B
        public static AKRESULT SetGameObjectInRoom(System.UInt64 in_gameObjectID, System.UInt64 in_CurrentRoomID) { }
        // RVA: 0x042BBC58  token: 0x6000B4C
        public static AKRESULT UnsetGameObjectInRoom(System.UInt64 in_gameObjectID) { }
        // RVA: 0x02A02000  token: 0x6000B4D
        public static AKRESULT SetReflectionsOrder(System.UInt32 in_uReflectionsOrder, System.Boolean in_bUpdatePaths) { }
        // RVA: 0x02A02060  token: 0x6000B4E
        public static AKRESULT SetDiffractionOrder(System.UInt32 in_uDiffractionOrder, System.Boolean in_bUpdatePaths) { }
        // RVA: 0x042B8DB8  token: 0x6000B4F
        public static AKRESULT SetMaxEmitterRoomAuxSends(System.UInt32 in_uMaxEmitterRoomAuxSends) { }
        // RVA: 0x02A039D0  token: 0x6000B50
        public static AKRESULT SetNumberOfPrimaryRays(System.UInt32 in_uNbPrimaryRays) { }
        // RVA: 0x02A03940  token: 0x6000B51
        public static AKRESULT SetLoadBalancingSpread(System.UInt32 in_uNbFrames) { }
        // RVA: 0x042B80BC  token: 0x6000B52
        public static AKRESULT SetEarlyReflectionsAuxSend(System.UInt64 in_gameObjectID, System.UInt32 in_auxBusID) { }
        // RVA: 0x042B8188  token: 0x6000B53
        public static AKRESULT SetEarlyReflectionsVolume(System.UInt64 in_gameObjectID, System.Single in_fSendVolume) { }
        // RVA: 0x042B9C08  token: 0x6000B54
        public static AKRESULT SetPortalObstructionAndOcclusion(System.UInt64 in_PortalID, System.Single in_fObstruction, System.Single in_fOcclusion) { }
        // RVA: 0x042B8618  token: 0x6000B55
        public static AKRESULT SetGameObjectToPortalObstruction(System.UInt64 in_gameObjectID, System.UInt64 in_PortalID, System.Single in_fObstruction) { }
        // RVA: 0x042B9C6C  token: 0x6000B56
        public static AKRESULT SetPortalToPortalObstruction(System.UInt64 in_PortalID0, System.UInt64 in_PortalID1, System.Single in_fObstruction) { }
        // RVA: 0x042B5894  token: 0x6000B57
        public static AKRESULT QueryWetDiffraction(System.UInt64 in_portal, System.Single& out_wetDiffraction) { }
        // RVA: 0x042B6D2C  token: 0x6000B58
        public static AKRESULT ResetStochasticEngine() { }
        // RVA: 0x042B03D4  token: 0x6000B59
        public static System.UInt32 GetDeviceIDFromName(System.String in_szToken) { }
        // RVA: 0x042B1B80  token: 0x6000B5A
        public static System.String GetWindowsDeviceName(System.Int32 index, System.UInt32& out_uDeviceID, AkAudioDeviceState uDeviceStateMask) { }
        // RVA: 0x042B1B0C  token: 0x6000B5B
        public static System.String GetWindowsDeviceName(System.Int32 index, System.UInt32& out_uDeviceID) { }
        // RVA: 0x042B1A84  token: 0x6000B5C
        public static System.UInt32 GetWindowsDeviceCount(AkAudioDeviceState uDeviceStateMask) { }
        // RVA: 0x042B1ACC  token: 0x6000B5D
        public static System.UInt32 GetWindowsDeviceCount() { }
        // RVA: 0x039C5A70  token: 0x6000B5E
        public static System.Void SetErrorLogger(AkLogger.ErrorLoggerInteropDelegate logger) { }
        // RVA: 0x042B825C  token: 0x6000B5F
        public static System.Void SetErrorLogger() { }
        // RVA: 0x042B7D24  token: 0x6000B60
        public static System.Void SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate getAudioSamples, AkAudioInputManager.AudioFormatInteropDelegate getAudioFormat) { }
        // RVA: 0x02A01EC0  token: 0x6000B61
        public static AKRESULT Init(AkInitializationSettings settings) { }
        // RVA: 0x02A01F60  token: 0x6000B62
        public static AKRESULT InitSpatialAudio(AkSpatialAudioInitSettings settings) { }
        // RVA: 0x042B1D64  token: 0x6000B63
        public static AKRESULT InitCommunication(AkCommunicationSettings settings) { }
        // RVA: 0x042BB5BC  token: 0x6000B64
        public static System.Void Term() { }
        // RVA: 0x02761270  token: 0x6000B65
        public static AKRESULT RegisterGameObjInternal(System.UInt64 in_GameObj) { }
        // RVA: 0x02AF8730  token: 0x6000B66
        public static AKRESULT UnregisterGameObjInternal(System.UInt64 in_GameObj) { }
        // RVA: 0x031ADF30  token: 0x6000B67
        public static AKRESULT RegisterGameObjInternal_WithName(System.UInt64 in_GameObj, System.String in_pszObjName) { }
        // RVA: 0x042B7DDC  token: 0x6000B68
        public static AKRESULT SetBasePath(System.String in_pszBasePath) { }
        // RVA: 0x02951D00  token: 0x6000B69
        public static AKRESULT SetCurrentLanguage(System.String in_pszAudioSrcPath) { }
        // RVA: 0x02CB3A10  token: 0x6000B6A
        public static AKRESULT LoadFilePackage(System.String in_pszFilePackageName, System.UInt32& out_uPackageID) { }
        // RVA: 0x037084C0  token: 0x6000B6B
        public static AKRESULT AddBasePath(System.String in_pszBasePath) { }
        // RVA: 0x042B829C  token: 0x6000B6C
        public static AKRESULT SetGameName(System.String in_GameName) { }
        // RVA: 0x042B0118  token: 0x6000B6D
        public static System.String GetCurrentLanguage() { }
        // RVA: 0x02CB41E0  token: 0x6000B6E
        public static AKRESULT UnloadFilePackage(System.UInt32 in_uPackageID) { }
        // RVA: 0x042BB5FC  token: 0x6000B6F
        public static AKRESULT UnloadAllFilePackages() { }
        // RVA: 0x028BB3F0  token: 0x6000B70
        public static AKRESULT SetObjectPosition(System.UInt64 in_GameObjectID, UnityEngine.Vector3 Pos, UnityEngine.Vector3 Front, UnityEngine.Vector3 Top) { }
        // RVA: 0x042B14A4  token: 0x6000B71
        public static AKRESULT GetSourceMultiplePlayPositions(System.UInt32 in_PlayingID, System.UInt32[] out_audioNodeID, System.UInt32[] out_mediaID, System.Int32[] out_msTime, System.UInt32& io_pcPositions, System.Boolean in_bExtrapolate) { }
        // RVA: 0x042B1428  token: 0x6000B72
        public static AKRESULT GetSourceMultiplePlayPositions(System.UInt32 in_PlayingID, System.UInt32[] out_audioNodeID, System.UInt32[] out_mediaID, System.Int32[] out_msTime, System.UInt32& io_pcPositions) { }
        // RVA: 0x042B8D58  token: 0x6000B73
        public static AKRESULT SetListeners(System.UInt64 in_emitterGameObj, System.UInt64[] in_pListenerGameObjs, System.UInt32 in_uNumListeners) { }
        // RVA: 0x026BD090  token: 0x6000B74
        public static AKRESULT SetDefaultListeners(System.UInt64[] in_pListenerObjs, System.UInt32 in_uNumListeners) { }
        // RVA: 0x03618010  token: 0x6000B75
        public static System.UInt32 GetNumOutputDevices(System.UInt32 in_AudioDeviceShareSetID) { }
        // RVA: 0x042AE0D4  token: 0x6000B76
        public static AKRESULT AddOutput(AkOutputSettings in_Settings, System.UInt64& out_pDeviceID, System.UInt64[] in_pListenerIDs, System.UInt32 in_uNumListeners) { }
        // RVA: 0x042AE1A8  token: 0x6000B77
        public static AKRESULT AddOutput(AkOutputSettings in_Settings, System.UInt64& out_pDeviceID, System.UInt64[] in_pListenerIDs) { }
        // RVA: 0x042AE21C  token: 0x6000B78
        public static AKRESULT AddOutput(AkOutputSettings in_Settings, System.UInt64& out_pDeviceID) { }
        // RVA: 0x042AE154  token: 0x6000B79
        public static AKRESULT AddOutput(AkOutputSettings in_Settings) { }
        // RVA: 0x042B0380  token: 0x6000B7A
        public static System.Void GetDefaultStreamSettings(AkStreamMgrSettings out_settings) { }
        // RVA: 0x042B0230  token: 0x6000B7B
        public static System.Void GetDefaultDeviceSettings(AkDeviceSettings out_settings) { }
        // RVA: 0x042B02D8  token: 0x6000B7C
        public static System.Void GetDefaultMusicSettings(AkMusicSettings out_settings) { }
        // RVA: 0x042B0284  token: 0x6000B7D
        public static System.Void GetDefaultInitSettings(AkInitSettings out_settings) { }
        // RVA: 0x042B032C  token: 0x6000B7E
        public static System.Void GetDefaultPlatformInitSettings(AkPlatformInitSettings out_settings) { }
        // RVA: 0x042B0A10  token: 0x6000B7F
        public static System.UInt32 GetMajorMinorVersion() { }
        // RVA: 0x042B1838  token: 0x6000B80
        public static System.UInt32 GetSubminorBuildVersion() { }
        // RVA: 0x042BAEC8  token: 0x6000B81
        public static System.Void StartResourceMonitoring() { }
        // RVA: 0x042BB44C  token: 0x6000B82
        public static System.Void StopResourceMonitoring() { }
        // RVA: 0x042B1354  token: 0x6000B83
        public static System.Void GetResourceMonitorDataSummary(AkResourceMonitorDataSummary resourceMonitorDataSummary) { }
        // RVA: 0x042BADA4  token: 0x6000B84
        public static System.Void StartDeviceCapture(System.UInt64 in_idOutputDeviceID) { }
        // RVA: 0x042BB00C  token: 0x6000B85
        public static System.Void StopDeviceCapture(System.UInt64 in_idOutputDeviceID) { }
        // RVA: 0x042AE690  token: 0x6000B86
        public static System.Void ClearCaptureData() { }
        // RVA: 0x042BBD10  token: 0x6000B87
        public static System.UInt32 UpdateCaptureSampleCount(System.UInt64 in_idOutputDeviceID) { }
        // RVA: 0x042B00B8  token: 0x6000B88
        public static System.UInt32 GetCaptureSamples(System.UInt64 in_idOutputDeviceID, System.Single[] out_pSamples, System.UInt32 in_uBufferSize) { }
        // RVA: 0x042BA92C  token: 0x6000B89
        public static AKRESULT SetRoomPortal(System.UInt64 in_PortalID, System.UInt64 FrontRoom, System.UInt64 BackRoom, AkTransform Transform, AkExtent Extent, System.Boolean bEnabled, System.String in_pName) { }
        // RVA: 0x031ACEE0  token: 0x6000B8A
        public static AKRESULT SetRoom(System.UInt64 in_RoomID, AkRoomParams in_roomParams, System.UInt64 GeometryInstanceID, System.String in_pName) { }
        // RVA: 0x026BD040  token: 0x6000B8B
        public static AKRESULT RegisterSpatialAudioListener(System.UInt64 in_gameObjectID) { }
        // RVA: 0x042BBBA4  token: 0x6000B8C
        public static AKRESULT UnregisterSpatialAudioListener(System.UInt64 in_gameObjectID) { }
        // RVA: 0x042B8724  token: 0x6000B8D
        public static AKRESULT SetGeometry(System.UInt64 in_GeomSetID, AkTriangleArray Triangles, System.UInt32 NumTriangles, UnityEngine.Vector3[] Vertices, System.UInt32 NumVertices, AkAcousticSurfaceArray Surfaces, System.UInt32 NumSurfaces, System.Boolean EnableDiffraction, System.Boolean EnableDiffractionOnBoundaryEdges) { }
        // RVA: 0x042B8678  token: 0x6000B8E
        public static AKRESULT SetGeometryInstance(System.UInt64 in_GeomInstanceID, AkTransform Transform, UnityEngine.Vector3 Scale, System.UInt64 GeometrySetID, System.UInt64 RoomID, System.Boolean UseForReflectionAndDiffraction) { }
        // RVA: 0x042B5714  token: 0x6000B8F
        public static AKRESULT QueryReflectionPaths(System.UInt64 in_gameObjectID, System.UInt32 in_positionIndex, UnityEngine.Vector3& out_listenerPos, UnityEngine.Vector3& out_emitterPos, AkReflectionPathInfoArray out_aPaths, System.UInt32& io_uArraySize) { }
        // RVA: 0x042B5594  token: 0x6000B90
        public static AKRESULT QueryDiffractionPaths(System.UInt64 in_gameObjectID, System.UInt32 in_positionIndex, UnityEngine.Vector3& out_listenerPos, UnityEngine.Vector3& out_emitterPos, AkDiffractionPathInfoArray out_aPaths, System.UInt32& io_uArraySize) { }
        // RVA: 0x042B273C  token: 0x6000B91
        public static System.Void PerformStreamMgrIO() { }
        // RVA: 0x042B1D24  token: 0x6000B92
        public static System.Void HgMemShrink() { }
        // RVA: 0x0269BA50  token: 0x6000B93
        public static System.UInt64 HgGetGlobalMemoryUsed() { }
        // RVA: 0x039CAFD0  token: 0x6000B94
        public static System.UInt64 HgGetGlobalMemoryReserved() { }
        // RVA: 0x03656360  token: 0x6000B95
        public static System.Void InitScePad() { }
        // RVA: 0x042B09C8  token: 0x6000B96
        public static System.UInt32 GetMMDeviceIdFromPadContainerInfo(System.Int32 in_padHandle) { }
        // RVA: 0x042BB48C  token: 0x6000B97
        public static System.String StringFromIntPtrString(System.IntPtr ptr) { }
        // RVA: 0x02A4E840  token: 0x6000B98
        public static System.String StringFromIntPtrWString(System.IntPtr ptr) { }
        // RVA: 0x042B1DB8  token: 0x6000B99
        private static System.UInt64 InternalGameObjectHash(UnityEngine.GameObject gameObject) { }
        // RVA: 0x042AFEC0  token: 0x6000B9B
        public static System.UInt64 GetAkGameObjectID(UnityEngine.GameObject gameObject) { }
        // RVA: 0x042B59D0  token: 0x6000B9C
        public static AKRESULT RegisterGameObj(UnityEngine.GameObject gameObject) { }
        // RVA: 0x042B5A38  token: 0x6000B9D
        public static AKRESULT RegisterGameObj(UnityEngine.GameObject gameObject, System.String name) { }
        // RVA: 0x042BBB08  token: 0x6000B9E
        public static AKRESULT UnregisterGameObj(UnityEngine.GameObject gameObject) { }
        // RVA: 0x042BBA60  token: 0x6000B9F
        public static System.Void UnregisterAllGameObjects() { }
        // RVA: 0x042B97C4  token: 0x6000BA1
        public static AKRESULT SetObjectPosition(UnityEngine.GameObject gameObject, UnityEngine.Transform transform) { }
        // RVA: 0x042B98D0  token: 0x6000BA2
        public static AKRESULT SetObjectPosition(UnityEngine.GameObject gameObject, System.Single posX, System.Single posY, System.Single posZ, System.Single frontX, System.Single frontY, System.Single frontZ, System.Single topX, System.Single topY, System.Single topZ) { }
        // RVA: 0x0350B670  token: 0x6000BA3
        public static System.Void PreGameObjectAPICall(UnityEngine.GameObject gameObject, System.UInt64 id) { }
        // RVA: 0x042AEFB0  token: 0x6000BA4
        public static System.UInt32 DynamicSequenceOpen(UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType) { }
        // RVA: 0x042AEC1C  token: 0x6000BA5
        public static System.UInt32 DynamicSequenceOpen(UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        // RVA: 0x042AEEBC  token: 0x6000BA6
        public static System.UInt32 DynamicSequenceOpen(UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042B32D0  token: 0x6000BA7
        public static System.UInt32 PostEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources, System.UInt32 in_PlayingID) { }
        // RVA: 0x042B3490  token: 0x6000BA8
        public static System.UInt32 PostEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources) { }
        // RVA: 0x042B2CA8  token: 0x6000BA9
        public static System.UInt32 PostEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        // RVA: 0x042B3198  token: 0x6000BAA
        public static System.UInt32 PostEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042B2EC8  token: 0x6000BAB
        public static System.UInt32 PostEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources, System.UInt32 in_PlayingID) { }
        // RVA: 0x042B35C4  token: 0x6000BAC
        public static System.UInt32 PostEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources) { }
        // RVA: 0x042B37D8  token: 0x6000BAD
        public static System.UInt32 PostEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        // RVA: 0x042B3234  token: 0x6000BAE
        public static System.UInt32 PostEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042AFC40  token: 0x6000BAF
        public static AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, System.UInt32 in_PlayingID) { }
        // RVA: 0x042AF930  token: 0x6000BB0
        public static AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042AF898  token: 0x6000BB1
        public static AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration) { }
        // RVA: 0x042AF814  token: 0x6000BB2
        public static AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042AFB98  token: 0x6000BB3
        public static AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, System.UInt32 in_PlayingID) { }
        // RVA: 0x042AFCE8  token: 0x6000BB4
        public static AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042AF4E8  token: 0x6000BB5
        public static AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration) { }
        // RVA: 0x042AF63C  token: 0x6000BB6
        public static AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042B3B24  token: 0x6000BB7
        public static AKRESULT PostMIDIOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, AkMIDIPostArray in_pPosts, System.UInt16 in_uNumPosts) { }
        // RVA: 0x042BB0DC  token: 0x6000BB8
        public static AKRESULT StopMIDIOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042BB058  token: 0x6000BB9
        public static AKRESULT StopMIDIOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_playingID) { }
        // RVA: 0x042B773C  token: 0x6000BBA
        public static AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID) { }
        // RVA: 0x042B7134  token: 0x6000BBB
        public static AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker) { }
        // RVA: 0x042B7864  token: 0x6000BBC
        public static AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition) { }
        // RVA: 0x042B73F8  token: 0x6000BBD
        public static AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID) { }
        // RVA: 0x042B735C  token: 0x6000BBE
        public static AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker) { }
        // RVA: 0x042B77DC  token: 0x6000BBF
        public static AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition) { }
        // RVA: 0x042B72BC  token: 0x6000BC0
        public static AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID) { }
        // RVA: 0x042B7948  token: 0x6000BC1
        public static AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker) { }
        // RVA: 0x042B75A0  token: 0x6000BC2
        public static AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent) { }
        // RVA: 0x042B74FC  token: 0x6000BC3
        public static AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID) { }
        // RVA: 0x042B7624  token: 0x6000BC4
        public static AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker) { }
        // RVA: 0x042B7A40  token: 0x6000BC5
        public static AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent) { }
        // RVA: 0x042AE46C  token: 0x6000BC6
        public static System.Void CancelEventCallbackGameObject(UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042BAF64  token: 0x6000BC7
        public static System.Void StopAll(UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042B7C14  token: 0x6000BC8
        public static AKRESULT SendPluginCustomGameData(System.UInt32 in_busID, UnityEngine.GameObject in_busObjectID, AkPluginType in_eType, System.UInt32 in_uCompanyID, System.UInt32 in_uPluginID, System.IntPtr in_pData, System.UInt32 in_uSizeInBytes) { }
        // RVA: 0x042B941C  token: 0x6000BC9
        public static AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkPositionArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType) { }
        // RVA: 0x042B92D8  token: 0x6000BCA
        public static AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkPositionArray in_pPositions, System.UInt16 in_NumPositions) { }
        // RVA: 0x042B9370  token: 0x6000BCB
        public static AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType) { }
        // RVA: 0x042B953C  token: 0x6000BCC
        public static AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, System.UInt16 in_NumPositions) { }
        // RVA: 0x042BA9E4  token: 0x6000BCD
        public static AKRESULT SetScalingFactor(UnityEngine.GameObject in_GameObjectID, System.Single in_fAttenuationScalingFactor) { }
        // RVA: 0x042ADFAC  token: 0x6000BCE
        public static AKRESULT AddListener(UnityEngine.GameObject in_emitterGameObj, UnityEngine.GameObject in_listenerGameObj) { }
        // RVA: 0x042B5DF4  token: 0x6000BCF
        public static AKRESULT RemoveListener(UnityEngine.GameObject in_emitterGameObj, UnityEngine.GameObject in_listenerGameObj) { }
        // RVA: 0x042ADE9C  token: 0x6000BD0
        public static AKRESULT AddDefaultListener(UnityEngine.GameObject in_listenerGameObj) { }
        // RVA: 0x042B5C0C  token: 0x6000BD1
        public static AKRESULT RemoveDefaultListener(UnityEngine.GameObject in_listenerGameObj) { }
        // RVA: 0x042B60DC  token: 0x6000BD2
        public static AKRESULT ResetListenersToDefault(UnityEngine.GameObject in_emitterGameObj) { }
        // RVA: 0x042B8C2C  token: 0x6000BD3
        public static AKRESULT SetListenerSpatialization(UnityEngine.GameObject in_uListenerID, System.Boolean in_bSpatialized, AkChannelConfig in_channelConfig, System.Single[] in_pVolumeOffsets) { }
        // RVA: 0x042B8B90  token: 0x6000BD4
        public static AKRESULT SetListenerSpatialization(UnityEngine.GameObject in_uListenerID, System.Boolean in_bSpatialized, AkChannelConfig in_channelConfig) { }
        // RVA: 0x042BA7D8  token: 0x6000BD5
        public static AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        // RVA: 0x042BA738  token: 0x6000BD6
        public static AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042BA420  token: 0x6000BD7
        public static AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration) { }
        // RVA: 0x042BA39C  token: 0x6000BD8
        public static AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042BA00C  token: 0x6000BD9
        public static AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        // RVA: 0x042BA4B8  token: 0x6000BDA
        public static AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042BA5E4  token: 0x6000BDB
        public static AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration) { }
        // RVA: 0x042BA55C  token: 0x6000BDC
        public static AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042B6630  token: 0x6000BDD
        public static AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        // RVA: 0x042B6C38  token: 0x6000BDE
        public static AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042B6534  token: 0x6000BDF
        public static AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration) { }
        // RVA: 0x042B68A8  token: 0x6000BE0
        public static AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042B6B48  token: 0x6000BE1
        public static AKRESULT ResetRTPCValue(System.String in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        // RVA: 0x042B6AAC  token: 0x6000BE2
        public static AKRESULT ResetRTPCValue(System.String in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        // RVA: 0x042B66D0  token: 0x6000BE3
        public static AKRESULT ResetRTPCValue(System.String in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration) { }
        // RVA: 0x042B65B8  token: 0x6000BE4
        public static AKRESULT ResetRTPCValue(System.String in_pszRtpcName, UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042BACD0  token: 0x6000BE5
        public static AKRESULT SetSwitch(System.UInt32 in_switchGroup, System.UInt32 in_switchState, UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042BABE8  token: 0x6000BE6
        public static AKRESULT SetSwitch(System.String in_pszSwitchGroup, System.String in_pszSwitchState, UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042B42AC  token: 0x6000BE7
        public static AKRESULT PostTrigger(System.UInt32 in_triggerID, UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042B4320  token: 0x6000BE8
        public static AKRESULT PostTrigger(System.String in_pszTrigger, UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042B82E8  token: 0x6000BE9
        public static AKRESULT SetGameObjectAuxSendValues(UnityEngine.GameObject in_gameObjectID, AkAuxSendArray in_aAuxSendValues, System.UInt32 in_uNumSendValues) { }
        // RVA: 0x042B84C0  token: 0x6000BEA
        public static AKRESULT SetGameObjectOutputBusVolume(UnityEngine.GameObject in_emitterObjID, UnityEngine.GameObject in_listenerObjID, System.Single in_fControlValue) { }
        // RVA: 0x042B95D4  token: 0x6000BEB
        public static AKRESULT SetObjectObstructionAndOcclusion(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_ListenerID, System.Single in_fObstructionLevel, System.Single in_fOcclusionLevel) { }
        // RVA: 0x042B8FF8  token: 0x6000BEC
        public static AKRESULT SetMultipleObstructionAndOcclusion(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, System.UInt32 in_uNumOcclusionObstruction) { }
        // RVA: 0x042B2ACC  token: 0x6000BED
        public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID, System.UInt32 in_audioNodeID, System.Boolean in_bIsBus) { }
        // RVA: 0x042B291C  token: 0x6000BEE
        public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID, System.UInt32 in_audioNodeID) { }
        // RVA: 0x042B29BC  token: 0x6000BEF
        public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID) { }
        // RVA: 0x042B3F58  token: 0x6000BF0
        public static AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID, System.UInt32 in_audioNodeID, System.Boolean in_bIsBus) { }
        // RVA: 0x042B41B0  token: 0x6000BF1
        public static AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID, System.UInt32 in_audioNodeID) { }
        // RVA: 0x042B3EC0  token: 0x6000BF2
        public static AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID) { }
        // RVA: 0x042B1020  token: 0x6000BF3
        public static AKRESULT GetPosition(UnityEngine.GameObject in_GameObjectID, AkTransform out_rPosition) { }
        // RVA: 0x042B093C  token: 0x6000BF4
        public static AKRESULT GetListenerPosition(UnityEngine.GameObject in_uIndex, AkTransform out_rPosition) { }
        // RVA: 0x042B1230  token: 0x6000BF5
        public static AKRESULT GetRTPCValue(System.UInt32 in_rtpcID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_playingID, System.Single& out_rValue, System.Int32& io_rValueType) { }
        // RVA: 0x042B1110  token: 0x6000BF6
        public static AKRESULT GetRTPCValue(System.String in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_playingID, System.Single& out_rValue, System.Int32& io_rValueType) { }
        // RVA: 0x042B18D8  token: 0x6000BF7
        public static AKRESULT GetSwitch(System.UInt32 in_switchGroup, UnityEngine.GameObject in_gameObjectID, System.UInt32& out_rSwitchState) { }
        // RVA: 0x042B195C  token: 0x6000BF8
        public static AKRESULT GetSwitch(System.String in_pstrSwitchGroupName, UnityEngine.GameObject in_GameObj, System.UInt32& out_rSwitchState) { }
        // RVA: 0x042B0564  token: 0x6000BF9
        public static AKRESULT GetGameObjectAuxSendValues(UnityEngine.GameObject in_gameObjectID, AkAuxSendArray out_paAuxSendValues, System.UInt32& io_ruNumSendValues) { }
        // RVA: 0x042B06C8  token: 0x6000BFA
        public static AKRESULT GetGameObjectDryLevelValue(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_ListenerID, System.Single& out_rfControlValue) { }
        // RVA: 0x042B0B78  token: 0x6000BFB
        public static AKRESULT GetObjectObstructionAndOcclusion(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_ListenerID, System.Single& out_rfObstructionLevel, System.Single& out_rfOcclusionLevel) { }
        // RVA: 0x042B0824  token: 0x6000BFC
        public static System.Boolean GetIsGameObjectActive(UnityEngine.GameObject in_GameObjId) { }
        // RVA: 0x042B0A50  token: 0x6000BFD
        public static System.Single GetMaxRadius(UnityEngine.GameObject in_GameObjId) { }
        // RVA: 0x042B0DFC  token: 0x6000BFE
        public static AKRESULT GetPlayingIDsFromGameObject(UnityEngine.GameObject in_GameObjId, System.UInt32& io_ruNumIDs, System.UInt32[] out_aPlayingIDs) { }
        // RVA: 0x042B8810  token: 0x6000BFF
        public static AKRESULT SetImageSource(System.UInt32 in_srcID, AkImageSourceSettings in_info, System.String in_imageSourceName, System.UInt32 in_AuxBusID, UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042B5CCC  token: 0x6000C00
        public static AKRESULT RemoveImageSource(System.UInt32 in_srcID, System.UInt32 in_AuxBusID, UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042AE6D0  token: 0x6000C01
        public static AKRESULT ClearImageSources(System.UInt32 in_AuxBusID, UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042B57C0  token: 0x6000C02
        public static AKRESULT QueryReflectionPaths(UnityEngine.GameObject in_gameObjectID, System.UInt32 in_positionIndex, UnityEngine.Vector3& out_listenerPos, UnityEngine.Vector3& out_emitterPos, AkReflectionPathInfoArray out_aPaths, System.UInt32& io_uArraySize) { }
        // RVA: 0x042B8448  token: 0x6000C03
        public static AKRESULT SetGameObjectInRoom(UnityEngine.GameObject in_gameObjectID, System.UInt64 in_CurrentRoomID) { }
        // RVA: 0x042B8114  token: 0x6000C04
        public static AKRESULT SetEarlyReflectionsAuxSend(UnityEngine.GameObject in_gameObjectID, System.UInt32 in_auxBusID) { }
        // RVA: 0x042B81E4  token: 0x6000C05
        public static AKRESULT SetEarlyReflectionsVolume(UnityEngine.GameObject in_gameObjectID, System.Single in_fSendVolume) { }
        // RVA: 0x042B5640  token: 0x6000C06
        public static AKRESULT QueryDiffractionPaths(UnityEngine.GameObject in_gameObjectID, System.UInt32 in_positionIndex, UnityEngine.Vector3& out_listenerPos, UnityEngine.Vector3& out_emitterPos, AkDiffractionPathInfoArray out_aPaths, System.UInt32& io_uArraySize) { }
        // RVA: 0x042B5968  token: 0x6000C07
        public static AKRESULT RegisterGameObjInternal(UnityEngine.GameObject in_GameObj) { }
        // RVA: 0x042BBAA0  token: 0x6000C08
        public static AKRESULT UnregisterGameObjInternal(UnityEngine.GameObject in_GameObj) { }
        // RVA: 0x042B58F0  token: 0x6000C09
        public static AKRESULT RegisterGameObjInternal_WithName(UnityEngine.GameObject in_GameObj, System.String in_pszObjName) { }
        // RVA: 0x042B96F0  token: 0x6000C0A
        public static AKRESULT SetObjectPosition(UnityEngine.GameObject in_GameObjectID, UnityEngine.Vector3 Pos, UnityEngine.Vector3 Front, UnityEngine.Vector3 Top) { }
        // RVA: 0x042B8CD0  token: 0x6000C0B
        public static AKRESULT SetListeners(UnityEngine.GameObject in_emitterGameObj, System.UInt64[] in_pListenerGameObjs, System.UInt32 in_uNumListeners) { }
        // RVA: 0x042B5B58  token: 0x6000C0C
        public static AKRESULT RegisterSpatialAudioListener(UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x042BBBF0  token: 0x6000C0D
        public static AKRESULT UnregisterSpatialAudioListener(UnityEngine.GameObject in_gameObjectID) { }
        // RVA: 0x02A4E7F0  token: 0x6000C0E
        public static System.String StringFromIntPtrOSString(System.IntPtr ptr) { }
        // RVA: 0x0350B670  token: 0x6000C0F
        public System.Void .ctor() { }
        // RVA: 0x03B3A280  token: 0x6000C10
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200006F  // size: 0x20
    public class AkThreadProperties : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Properties
        System.Int32 nPriority { get; /* RVA: 0x042BCA18 */ set; /* RVA: 0x042BCB34 */ }
        System.UInt32 dwAffinityMask { get; /* RVA: 0x042BC9C8 */ set; /* RVA: 0x042BCAE0 */ }
        System.UInt32 uStackSize { get; /* RVA: 0x042BCA68 */ set; /* RVA: 0x042BCB88 */ }

        // Methods
        // RVA: 0x03D4E290  token: 0x6000C15
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000C16
        private static System.IntPtr getCPtr(AkThreadProperties obj) { }
        // RVA: 0x042BCAB8  token: 0x6000C17
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x042BC904  token: 0x6000C18
        protected virtual System.Void Finalize() { }
        // RVA: 0x042BC7A0  token: 0x6000C19
        public virtual System.Void Dispose() { }
        // RVA: 0x042BC7F0  token: 0x6000C1A
        protected virtual System.Void Dispose(System.Boolean disposing) { }
        // RVA: 0x042BC978  token: 0x6000C21
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000070  // size: 0x20
    public class AkUnityPlatformSpecificSettings : System.IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;  // 0x10
        protected System.Boolean swigCMemOwn;  // 0x18

        // Methods
        // RVA: 0x03D4E290  token: 0x6000C22
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        // RVA: 0x0427A72C  token: 0x6000C23
        private static System.IntPtr getCPtr(AkUnityPlatformSpecificSettings obj) { }
        // RVA: 0x042BCDB0  token: 0x6000C24
        private virtual System.Void setCPtr(System.IntPtr cPtr) { }
        // RVA: 0x03923F10  token: 0x6000C25
        protected virtual System.Void Finalize() { }
        // RVA: 0x042BCD60  token: 0x6000C26
        public virtual System.Void Dispose() { }
        // RVA: 0x03923F60  token: 0x6000C27
        protected virtual System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x2000073  // size: 0x14
    public sealed struct AudioAPI
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkAndroidSettings.PlatformAdvancedSettings.AudioAPI None;  // const
        public static AkAndroidSettings.PlatformAdvancedSettings.AudioAPI AAudio;  // const
        public static AkAndroidSettings.PlatformAdvancedSettings.AudioAPI OpenSL_ES;  // const
        public static AkAndroidSettings.PlatformAdvancedSettings.AudioAPI Default;  // const

    }

    // TypeToken: 0x2000072  // size: 0x58
    public class PlatformAdvancedSettings : AkCommonAdvancedSettings
    {
        // Fields
        public AkAndroidSettings.PlatformAdvancedSettings.AudioAPI m_AudioAPI;  // 0x50
        public System.Boolean m_RoundFrameSizeToHardwareSize;  // 0x54
        public System.Boolean m_UseLowLatencyMode;  // 0x55

        // Methods
        // RVA: 0x0350B670  token: 0x6000C2C
        public virtual System.Void CopyTo(AkPlatformInitSettings settings) { }
        // RVA: 0x03D2DFA0  token: 0x6000C2D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000071  // size: 0x48
    public class AkAndroidSettings : PlatformSettings
    {
        // Fields
        public AkCommonUserSettings UserSettings;  // 0x30
        public AkAndroidSettings.PlatformAdvancedSettings AdvancedSettings;  // 0x38
        public AkCommonCommSettings CommsSettings;  // 0x40

        // Methods
        // RVA: 0x0346E970  token: 0x6000C28
        public System.Void .ctor() { }
        // RVA: 0x01003830  token: 0x6000C29
        protected virtual AkCommonUserSettings GetUserSettings() { }
        // RVA: 0x03D4E2A0  token: 0x6000C2A
        protected virtual AkCommonAdvancedSettings GetAdvancedSettings() { }
        // RVA: 0x03D4E2B0  token: 0x6000C2B
        protected virtual AkCommonCommSettings GetCommsSettings() { }

    }

    // TypeToken: 0x2000075  // size: 0x80
    public sealed class AudioFormatDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x042BD450  token: 0x6000C36
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02065C10  token: 0x6000C37
        public virtual System.Void Invoke(System.UInt32 playingID, AkAudioFormat format) { }
        // RVA: 0x042BD2B0  token: 0x6000C38
        public virtual System.IAsyncResult BeginInvoke(System.UInt32 playingID, AkAudioFormat format, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000C39
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000076  // size: 0x80
    public sealed class AudioFormatInteropDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x042BD5AC  token: 0x6000C3A
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02065C10  token: 0x6000C3B
        public virtual System.Void Invoke(System.UInt32 playingID, System.IntPtr format) { }
        // RVA: 0x042BD518  token: 0x6000C3C
        public virtual System.IAsyncResult BeginInvoke(System.UInt32 playingID, System.IntPtr format, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000C3D
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000077  // size: 0x80
    public sealed class AudioSamplesDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x042BDA1C  token: 0x6000C3E
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x01035ED0  token: 0x6000C3F
        public virtual System.Boolean Invoke(System.UInt32 playingID, System.UInt32 channelIndex, System.Single[] samples) { }
        // RVA: 0x042BD85C  token: 0x6000C40
        public virtual System.IAsyncResult BeginInvoke(System.UInt32 playingID, System.UInt32 channelIndex, System.Single[] samples, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD8EC  token: 0x6000C41
        public virtual System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000078  // size: 0x80
    public sealed class AudioSamplesInteropDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x042BDB94  token: 0x6000C42
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x0101C850  token: 0x6000C43
        public virtual System.Boolean Invoke(System.UInt32 playingID, System.Single[] samples, System.UInt32 channelIndex, System.UInt32 frames) { }
        // RVA: 0x042BDAE4  token: 0x6000C44
        public virtual System.IAsyncResult BeginInvoke(System.UInt32 playingID, System.Single[] samples, System.UInt32 channelIndex, System.UInt32 frames, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD8EC  token: 0x6000C45
        public virtual System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000074  // size: 0x10
    public static class AkAudioInputManager
    {
        // Fields
        private static System.Boolean initialized;  // static @ 0x0
        private static readonly System.Collections.Generic.Dictionary<System.UInt32,AkAudioInputManager.AudioSamplesDelegate> audioSamplesDelegates;  // static @ 0x8
        private static readonly System.Collections.Generic.Dictionary<System.UInt32,AkAudioInputManager.AudioFormatDelegate> audioFormatDelegates;  // static @ 0x10
        private static readonly AkAudioFormat audioFormat;  // static @ 0x18
        private static readonly AkAudioInputManager.AudioSamplesInteropDelegate audioSamplesDelegate;  // static @ 0x20
        private static readonly AkAudioInputManager.AudioFormatInteropDelegate audioFormatDelegate;  // static @ 0x28

        // Methods
        // RVA: 0x042AA9DC  token: 0x6000C2E
        public static System.UInt32 PostAudioInputEvent(System.UInt32 akEventID, UnityEngine.GameObject gameObject, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate) { }
        // RVA: 0x042AAAE0  token: 0x6000C2F
        public static System.UInt32 PostAudioInputEvent(System.String akEventName, UnityEngine.GameObject gameObject, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate) { }
        // RVA: 0x042AA8F0  token: 0x6000C30
        private static System.Boolean InternalAudioSamplesDelegate(System.UInt32 playingID, System.Single[] samples, System.UInt32 channelIndex, System.UInt32 frames) { }
        // RVA: 0x042AA7EC  token: 0x6000C31
        private static System.Void InternalAudioFormatDelegate(System.UInt32 playingID, System.IntPtr format) { }
        // RVA: 0x042AABE4  token: 0x6000C32
        private static System.Void TryInitialize() { }
        // RVA: 0x042AA624  token: 0x6000C33
        private static System.Void AddPlayingID(System.UInt32 playingID, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate) { }
        // RVA: 0x042AA6FC  token: 0x6000C34
        private static System.Void EventCallback(System.Object cookie, AkCallbackType type, AkCallbackInfo callbackInfo) { }
        // RVA: 0x042AAC88  token: 0x6000C35
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000079  // size: 0x20
    public class AkBasePathGetter
    {
        // Fields
        public static readonly System.String DefaultBasePath;  // static @ 0x0
        private static System.Boolean <IsWwiseProjectAvailable>k__BackingField;  // static @ 0x8
        private System.String <SoundBankBasePath>k__BackingField;  // 0x10
        private System.String <PersistentDataPath>k__BackingField;  // 0x18
        private static System.String <WwiseProjectFullPath>k__BackingField;  // static @ 0x10
        private static AkBasePathGetter Instance;  // static @ 0x18

        // Properties
        System.Boolean IsWwiseProjectAvailable { get; /* RVA: 0x042AB718 */ set; /* RVA: 0x042AB7B8 */ }
        System.String SoundBankBasePath { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.String PersistentDataPath { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.String WwiseProjectFullPath { get; /* RVA: 0x042AB768 */ set; /* RVA: 0x042AB80C */ }

        // Methods
        // RVA: 0x02A02570  token: 0x6000C46
        public static System.String GetPlatformName() { }
        // RVA: 0x042AB558  token: 0x6000C4F
        public static System.String GetPlatformBasePath(System.String platformName) { }
        // RVA: 0x042AB648  token: 0x6000C50
        public static AkBasePathGetter Get() { }
        // RVA: 0x03D20BF0  token: 0x6000C51
        public static System.Void Reset() { }
        // RVA: 0x042AB44C  token: 0x6000C52
        public System.Void EvaluateGamePaths() { }
        // RVA: 0x0350B670  token: 0x6000C53
        public System.Void .ctor() { }
        // RVA: 0x03CE05E0  token: 0x6000C54
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200007B  // size: 0x80
    public sealed class EventCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x03593670  token: 0x6000C66
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x011360D0  token: 0x6000C67
        public virtual System.Void Invoke(System.Object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info) { }
        // RVA: 0x042BDE60  token: 0x6000C68
        public virtual System.IAsyncResult BeginInvoke(System.Object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000C69
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200007C  // size: 0x80
    public sealed class MonitoringCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x03A46BB0  token: 0x6000C6A
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x01028930  token: 0x6000C6B
        public virtual System.Void Invoke(AkMonitorErrorCode in_errorCode, AkMonitorErrorLevel in_errorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.String in_msg) { }
        // RVA: 0x042BE110  token: 0x6000C6C
        public virtual System.IAsyncResult BeginInvoke(AkMonitorErrorCode in_errorCode, AkMonitorErrorLevel in_errorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.String in_msg, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000C6D
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200007D  // size: 0x80
    public sealed class BankCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x03594830  token: 0x6000C6E
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02097E50  token: 0x6000C6F
        public virtual System.Void Invoke(System.UInt32 in_bankID, System.IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, System.Object in_Cookie) { }
        // RVA: 0x042BDDA4  token: 0x6000C70
        public virtual System.IAsyncResult BeginInvoke(System.UInt32 in_bankID, System.IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, System.Object in_Cookie, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000C71
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200007E  // size: 0x28
    public class EventCallbackPackage
    {
        // Fields
        public AkCallbackManager.EventCallback callback;  // 0x10
        public System.Object cookie;  // 0x18
        public System.UInt32 playingID;  // 0x20

        // Methods
        // RVA: 0x0269B1E0  token: 0x6000C72
        private static System.Void Recycle(AkCallbackManager.EventCallbackPackage inPkg) { }
        // RVA: 0x0269E2E0  token: 0x6000C73
        public static AkCallbackManager.EventCallbackPackage Create(AkCallbackManager.EventCallback inCb, System.Object inCookie, System.UInt32& ioFlags) { }
        // RVA: 0x0350B670  token: 0x6000C74
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007F  // size: 0x20
    public class BankCallbackPackage
    {
        // Fields
        public AkCallbackManager.BankCallback callback;  // 0x10
        public System.Object cookie;  // 0x18

        // Methods
        // RVA: 0x0269FEA0  token: 0x6000C75
        public static AkCallbackManager.BankCallbackPackage Create(AkCallbackManager.BankCallback inCb, System.Object inCookie) { }
        // RVA: 0x0269B130  token: 0x6000C76
        public static System.Void Recycle(AkCallbackManager.BankCallbackPackage pkg) { }
        // RVA: 0x0350B670  token: 0x6000C77
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000080
    public class SimplePool`1
    {
        // Fields
        private readonly T[] m_pool;  // 0x0
        private readonly System.Int32 m_poolSize;  // 0x0
        private System.Int32 m_poolIndex;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000C78
        public System.Void .ctor(System.Int32 poolSize) { }
        // RVA: -1  // not resolved  token: 0x6000C79
        public T Alloc() { }
        // RVA: -1  // not resolved  token: 0x6000C7A
        public System.Void Recycle(T obj) { }

    }

    // TypeToken: 0x2000081  // size: 0x80
    public sealed class BGMCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x042BDCDC  token: 0x6000C7B
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x01165340  token: 0x6000C7C
        public virtual AKRESULT Invoke(System.Boolean in_bOtherAudioPlaying, System.Object in_Cookie) { }
        // RVA: 0x042BDC5C  token: 0x6000C7D
        public virtual System.IAsyncResult BeginInvoke(System.Boolean in_bOtherAudioPlaying, System.Object in_Cookie, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x04279B70  token: 0x6000C7E
        public virtual AKRESULT EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000082  // size: 0x20
    public class BGMCallbackPackage
    {
        // Fields
        public AkCallbackManager.BGMCallback m_Callback;  // 0x10
        public System.Object m_Cookie;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000C7F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007A  // size: 0x10
    public static class AkCallbackManager
    {
        // Fields
        private static readonly AkEventCallbackInfo AkEventCallbackInfo;  // static @ 0x0
        private static readonly AkDynamicSequenceItemCallbackInfo AkDynamicSequenceItemCallbackInfo;  // static @ 0x8
        private static readonly AkMIDIEventCallbackInfo AkMIDIEventCallbackInfo;  // static @ 0x10
        private static readonly AkMarkerCallbackInfo AkMarkerCallbackInfo;  // static @ 0x18
        private static readonly AkDurationCallbackInfo AkDurationCallbackInfo;  // static @ 0x20
        private static readonly AkMusicSyncCallbackInfo AkMusicSyncCallbackInfo;  // static @ 0x28
        private static readonly AkMusicPlaylistCallbackInfo AkMusicPlaylistCallbackInfo;  // static @ 0x30
        private static readonly AkAudioSourceChangeCallbackInfo AkAudioSourceChangeCallbackInfo;  // static @ 0x38
        private static readonly AkMonitoringCallbackInfo AkMonitoringCallbackInfo;  // static @ 0x40
        private static readonly AkBankCallbackInfo AkBankCallbackInfo;  // static @ 0x48
        private static readonly AkCallbackManager.SimplePool<AkCallbackManager.EventCallbackPackage> s_EventCallbackPackagePool;  // static @ 0x50
        private static readonly AkCallbackManager.SimplePool<AkCallbackManager.BankCallbackPackage> s_BankCallbackPackagePool;  // static @ 0x58
        private static readonly System.Collections.Generic.Dictionary<System.Int32,AkCallbackManager.BankCallbackPackage> s_mapBankCallbacks;  // static @ 0x60
        private static readonly System.Collections.Generic.Dictionary<System.Int32,AkCallbackManager.EventCallbackPackage> s_mapEventCallbacks;  // static @ 0x68
        private static AkCallbackManager.EventCallbackPackage s_lastAddedEventPackage;  // static @ 0x70
        private static AkCallbackManager.MonitoringCallback m_MonitoringCB;  // static @ 0x78
        private static AkCallbackManager.BGMCallbackPackage ms_sourceChangeCallbackPkg;  // static @ 0x80

        // Properties
        System.Int32 bnkCallbackCount { get; /* RVA: 0x042AC57C */ }
        System.Int32 evtCallbackCount { get; /* RVA: 0x042AC5DC */ }

        // Methods
        // RVA: 0x042AB90C  token: 0x6000C57
        public static System.Void CancelAllCallbacks() { }
        // RVA: 0x042AC24C  token: 0x6000C58
        public static System.Void RemoveEventCallback(System.UInt32 in_playingID) { }
        // RVA: 0x042ABF80  token: 0x6000C59
        public static System.Void RemoveEventCallbackCookie(System.Object in_cookie) { }
        // RVA: 0x042ABCB4  token: 0x6000C5A
        public static System.Void RemoveBankCallback(System.Object in_cookie) { }
        // RVA: 0x0269E4D0  token: 0x6000C5B
        public static System.Void SetLastAddedPlayingID(System.UInt32 in_playingID) { }
        // RVA: 0x02A01CE0  token: 0x6000C5C
        public static System.Void Init() { }
        // RVA: 0x042AC574  token: 0x6000C5D
        public static System.Void Term() { }
        // RVA: 0x03A46B40  token: 0x6000C5E
        public static System.Void SetMonitoringCallback(AkMonitorErrorLevel in_Level, AkCallbackManager.MonitoringCallback in_CB) { }
        // RVA: 0x0350B670  token: 0x6000C5F
        private static System.Void SetLocalOutput(AkMonitorErrorLevel in_Level) { }
        // RVA: 0x042AC4BC  token: 0x6000C60
        public static System.Void SetBGMCallback(AkCallbackManager.BGMCallback in_CB, System.Object in_cookie) { }
        // RVA: 0x042ABC64  token: 0x6000C61
        public static System.Void PostCallbacksNoInvoke() { }
        // RVA: 0x0269BEA0  token: 0x6000C62
        public static System.Int32 PostCallbacks() { }
        // RVA: 0x0269AD50  token: 0x6000C63
        private static System.Void _ProcessBankCallback(System.IntPtr pPackage, System.IntPtr pData) { }
        // RVA: 0x0269B300  token: 0x6000C64
        private static AkCallbackInfo _ProcessEventCallback(AkCallbackType eType, System.IntPtr pData) { }
        // RVA: 0x031D7F00  token: 0x6000C65
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000083  // size: 0x18
    public class AkBasePlatformSettings : UnityEngine.ScriptableObject
    {
        // Properties
        AkInitializationSettings AkInitializationSettings { get; /* RVA: 0x02A03750 */ }
        AkSpatialAudioInitSettings AkSpatialAudioInitSettings { get; /* RVA: 0x02A02D30 */ }
        System.String SoundBankPersistentDataPath { get; /* RVA: 0x01002730 */ }
        System.String SoundbankPath { get; /* RVA: 0x042AB8BC */ }
        AkCommunicationSettings AkCommunicationSettings { get; /* RVA: 0x042AB86C */ }
        System.UInt32 MemoryAllocationSizeLimit { get; /* RVA: 0x01002730 */ }
        System.UInt32 MemoryDebugLevel { get; /* RVA: 0x01002730 */ }

        // Methods
        // RVA: 0x0286F540  token: 0x6000C87
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000085  // size: 0x14
    public sealed struct PanningRule
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkCommonOutputSettings.PanningRule Speakers;  // const
        public static AkCommonOutputSettings.PanningRule Headphones;  // const

    }

    // TypeToken: 0x2000087  // size: 0x14
    public sealed struct ChannelConfigType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelConfigType Anonymous;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelConfigType Standard;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelConfigType Ambisonic;  // const

    }

    // TypeToken: 0x2000088  // size: 0x14
    public sealed struct ChannelMask
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask NONE;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask FRONT_LEFT;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask FRONT_RIGHT;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask FRONT_CENTER;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask LOW_FREQUENCY;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask BACK_LEFT;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask BACK_RIGHT;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask BACK_CENTER;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SIDE_LEFT;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SIDE_RIGHT;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask TOP;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask HEIGHT_FRONT_LEFT;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask HEIGHT_FRONT_CENTER;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask HEIGHT_FRONT_RIGHT;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask HEIGHT_BACK_LEFT;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask HEIGHT_BACK_CENTER;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask HEIGHT_BACK_RIGHT;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_MONO;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_0POINT1;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_1POINT1;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_STEREO;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_2POINT1;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_3STEREO;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_3POINT1;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_4;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_4POINT1;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_5;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_5POINT1;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_6;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_6POINT1;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_7;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_7POINT1;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_SURROUND;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DPL2;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_HEIGHT_4;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_HEIGHT_5;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_HEIGHT_ALL;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_222;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_8;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_9;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_9POINT1;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_10;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_10POINT1;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_11;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_11POINT1;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_11_740;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_11POINT1_740;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_13_751;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_13POINT1_751;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_5_0_2;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_5_1_2;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_6_0_2;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_6_1_2;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_6_0_4;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_6_1_4;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_7_0_2;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_7_1_2;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_7_0_4;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_7_1_4;  // const
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_ALL_SPEAKERS;  // const

    }

    // TypeToken: 0x2000086  // size: 0x20
    public class ChannelConfiguration
    {
        // Fields
        public AkCommonOutputSettings.ChannelConfiguration.ChannelConfigType m_ChannelConfigType;  // 0x10
        public AkCommonOutputSettings.ChannelConfiguration.ChannelMask m_ChannelMask;  // 0x14
        public System.UInt32 m_NumberOfChannels;  // 0x18

        // Methods
        // RVA: 0x02A4F390  token: 0x6000C8A
        public System.Void CopyTo(AkChannelConfig config) { }
        // RVA: 0x0350B670  token: 0x6000C8B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000084  // size: 0x28
    public class AkCommonOutputSettings
    {
        // Fields
        public System.String m_AudioDeviceShareset;  // 0x10
        public System.UInt32 m_DeviceID;  // 0x18
        public AkCommonOutputSettings.PanningRule m_PanningRule;  // 0x1c
        public AkCommonOutputSettings.ChannelConfiguration m_ChannelConfig;  // 0x20

        // Methods
        // RVA: 0x02A4F220  token: 0x6000C88
        public System.Void CopyTo(AkOutputSettings settings) { }
        // RVA: 0x0346E640  token: 0x6000C89
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008A  // size: 0x40
    public class SpatialAudioSettings
    {
        // Fields
        public System.UInt32 m_MaxSoundPropagationDepth;  // 0x10
        public System.Single m_MovementThreshold;  // 0x14
        public System.UInt32 m_NumberOfPrimaryRays;  // 0x18
        public System.UInt32 m_MaxReflectionOrder;  // 0x1c
        public System.UInt32 m_MaxDiffractionOrder;  // 0x20
        public System.UInt32 m_DiffractionOnReflectionsOrder;  // 0x24
        public System.UInt32 m_MaxEmitterRoomAuxSends;  // 0x28
        public System.Single m_MaxPathLength;  // 0x2c
        public System.Single m_CPULimitPercentage;  // 0x30
        public System.Boolean m_EnableGeometricDiffractionAndTransmission;  // 0x34
        public System.Boolean m_CalcEmitterVirtualPosition;  // 0x35
        public System.UInt32 m_LoadBalancingSpread;  // 0x38

        // Methods
        // RVA: 0x03B226C0  token: 0x6000C97
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000089  // size: 0x48
    public class AkCommonUserSettings
    {
        // Fields
        public System.String m_BasePath;  // 0x10
        public System.UInt32 m_MaximumNumberOfPositioningPaths;  // 0x18
        public System.UInt32 m_CommandQueueSize;  // 0x1c
        public System.UInt32 m_SamplesPerFrame;  // 0x20
        public AkCommonOutputSettings m_MainOutputSettings;  // 0x28
        public System.Single m_StreamingLookAheadRatio;  // 0x30
        public System.UInt32 m_SampleRate;  // 0x34
        public System.UInt16 m_NumberOfRefillsInVoice;  // 0x38
        public AkCommonUserSettings.SpatialAudioSettings m_SpatialAudioSettings;  // 0x40

        // Methods
        // RVA: 0x02A4D2D0  token: 0x6000C8C
        protected static System.String GetPluginPath() { }
        // RVA: 0x02A4E5F0  token: 0x6000C8D
        public virtual System.Void CopyTo(AkInitSettings settings) { }
        // RVA: 0x02A03C50  token: 0x6000C8E
        public System.Void CopyTo(AkMusicSettings settings) { }
        // RVA: 0x0350B670  token: 0x6000C8F
        public System.Void CopyTo(AkStreamMgrSettings settings) { }
        // RVA: 0x0350B670  token: 0x6000C90
        public virtual System.Void CopyTo(AkDeviceSettings settings) { }
        // RVA: 0x02A03CC0  token: 0x6000C91
        private System.Void SetSampleRate(AkPlatformInitSettings settings) { }
        // RVA: 0x02A03C80  token: 0x6000C92
        public virtual System.Void CopyTo(AkPlatformInitSettings settings) { }
        // RVA: 0x02A02E10  token: 0x6000C93
        public virtual System.Void CopyTo(AkSpatialAudioInitSettings settings) { }
        // RVA: 0x0350B670  token: 0x6000C94
        public virtual System.Void CopyTo(AkUnityPlatformSpecificSettings settings) { }
        // RVA: 0x042ACBC0  token: 0x6000C95
        public virtual System.Void Validate() { }
        // RVA: 0x0346E5B0  token: 0x6000C96
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008C  // size: 0x14
    public sealed struct MemSpanCount
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkCommonAdvancedSettings.MemSpanCount Small;  // const
        public static AkCommonAdvancedSettings.MemSpanCount Medium;  // const
        public static AkCommonAdvancedSettings.MemSpanCount Huge;  // const

    }

    // TypeToken: 0x200008B  // size: 0x50
    public class AkCommonAdvancedSettings
    {
        // Fields
        public System.UInt32 m_IOMemorySize;  // 0x10
        public System.Single m_TargetAutoStreamBufferLengthMs;  // 0x14
        public System.Boolean m_UseStreamCache;  // 0x18
        public System.UInt32 m_MaximumPinnedBytesInCache;  // 0x1c
        public System.Boolean m_EnableGameSyncPreparation;  // 0x20
        public System.UInt32 m_ContinuousPlaybackLookAhead;  // 0x24
        public System.UInt32 m_MonitorQueuePoolSize;  // 0x28
        public System.UInt32 m_MaximumHardwareTimeoutMs;  // 0x2c
        public System.Boolean m_DebugOutOfRangeCheckEnabled;  // 0x30
        public System.Single m_DebugOutOfRangeLimit;  // 0x34
        public System.String m_SoundBankPersistentDataPath;  // 0x38
        public System.UInt32 m_MemoryAllocationSizeLimit;  // 0x40
        public System.UInt32 m_MemoryDebugLevel;  // 0x44
        public AkCommonAdvancedSettings.MemSpanCount m_MemorySpanCount;  // 0x48

        // Methods
        // RVA: 0x02A03DB0  token: 0x6000C98
        public virtual System.Void CopyTo(AkDeviceSettings settings) { }
        // RVA: 0x02A016C0  token: 0x6000C99
        public virtual System.Void CopyTo(AkInitSettings settings) { }
        // RVA: 0x0350B670  token: 0x6000C9A
        public virtual System.Void CopyTo(AkPlatformInitSettings settings) { }
        // RVA: 0x0350B670  token: 0x6000C9B
        public virtual System.Void CopyTo(AkUnityPlatformSpecificSettings settings) { }
        // RVA: 0x03D4E300  token: 0x6000C9C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008D  // size: 0x30
    public class AkCommonCommSettings
    {
        // Fields
        public System.UInt32 m_PoolSize;  // 0x10
        public static System.UInt16 DefaultDiscoveryBroadcastPort;  // static @ 0x0
        public System.UInt16 m_DiscoveryBroadcastPort;  // 0x14
        public System.UInt16 m_CommandPort;  // 0x16
        public System.UInt16 m_NotificationPort;  // 0x18
        public System.Boolean m_InitializeSystemComms;  // 0x1a
        public System.String m_NetworkName;  // 0x20
        public AkCommunicationSettings.AkCommSystem m_commSystem;  // 0x28

        // Methods
        // RVA: 0x042ACA4C  token: 0x6000C9D
        public virtual System.Void CopyTo(AkCommunicationSettings settings) { }
        // RVA: 0x0350B670  token: 0x6000C9E
        public virtual System.Void Validate() { }
        // RVA: 0x0346E540  token: 0x6000C9F
        public System.Void .ctor() { }
        // RVA: 0x03D42760  token: 0x6000CA0
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200008E  // size: 0x18
    public abstract class AkCommonPlatformSettings : AkBasePlatformSettings
    {
        // Properties
        AkInitializationSettings AkInitializationSettings { get; /* RVA: 0x02A02820 */ }
        AkSpatialAudioInitSettings AkSpatialAudioInitSettings { get; /* RVA: 0x02A02CE0 */ }
        System.String SoundBankPersistentDataPath { get; /* RVA: 0x042ACB80 */ }
        System.String SoundbankPath { get; /* RVA: 0x042ACBA0 */ }
        System.UInt32 MemoryAllocationSizeLimit { get; /* RVA: 0x042ACB40 */ }
        System.UInt32 MemoryDebugLevel { get; /* RVA: 0x042ACB60 */ }
        AkCommunicationSettings AkCommunicationSettings { get; /* RVA: 0x042ACAE0 */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000CA1
        protected virtual AkCommonUserSettings GetUserSettings() { }
        // RVA: -1  // abstract  token: 0x6000CA2
        protected virtual AkCommonAdvancedSettings GetAdvancedSettings() { }
        // RVA: -1  // abstract  token: 0x6000CA3
        protected virtual AkCommonCommSettings GetCommsSettings() { }
        // RVA: 0x0286F540  token: 0x6000CAB
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200008F  // size: 0x18
    public class AkEnumFlagAttribute : UnityEngine.PropertyAttribute
    {
        // Fields
        public System.Type Type;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000CAC
        public System.Void .ctor(System.Type type) { }

    }

    // TypeToken: 0x2000091  // size: 0x80
    public sealed class ErrorLoggerInteropDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x02EAAEC0  token: 0x6000CB6
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x6000CB7
        public virtual System.Void Invoke(System.String message) { }
        // RVA: 0x0389C3B0  token: 0x6000CB8
        public virtual System.IAsyncResult BeginInvoke(System.String message, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000CB9
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000090  // size: 0x18
    public class AkLogger
    {
        // Fields
        private static AkLogger ms_Instance;  // static @ 0x0
        private AkLogger.ErrorLoggerInteropDelegate errorLoggerDelegate;  // 0x10

        // Properties
        AkLogger Instance { get; /* RVA: 0x042AD27C */ }

        // Methods
        // RVA: 0x039C5950  token: 0x6000CAD
        private System.Void .ctor() { }
        // RVA: 0x042ACF0C  token: 0x6000CAF
        protected virtual System.Void Finalize() { }
        // RVA: 0x0350B670  token: 0x6000CB0
        public System.Void Init() { }
        // RVA: 0x042AD1DC  token: 0x6000CB1
        public static System.Void WwiseInternalLogError(System.String message) { }
        // RVA: 0x042AD09C  token: 0x6000CB2
        public static System.Void Message(System.String message) { }
        // RVA: 0x042AD13C  token: 0x6000CB3
        public static System.Void Warning(System.String message) { }
        // RVA: 0x042ACE6C  token: 0x6000CB4
        public static System.Void Error(System.String message) { }
        // RVA: 0x039C58E0  token: 0x6000CB5
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000093  // size: 0x80
    public sealed class InitializationDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x042BE04C  token: 0x6000CBF
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x042BE03C  token: 0x6000CC0
        public virtual System.Void Invoke() { }
        // RVA: 0x042BE018  token: 0x6000CC1
        public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000CC2
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000094  // size: 0x80
    public sealed class TerminationDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x042BE04C  token: 0x6000CC3
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x042BE03C  token: 0x6000CC4
        public virtual System.Void Invoke() { }
        // RVA: 0x042BE018  token: 0x6000CC5
        public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000CC6
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000092  // size: 0x10
    public static class AkSoundEngineInitialization
    {
        // Fields
        public static AkSoundEngineInitialization.InitializationDelegate s_initializationDelegate;  // static @ 0x0
        public static AkSoundEngineInitialization.TerminationDelegate s_terminationDelegate;  // static @ 0x8

        // Methods
        // RVA: 0x02A02150  token: 0x6000CBA
        public static System.Boolean InitializeSoundEngine() { }
        // RVA: 0x02A022A0  token: 0x6000CBB
        private static System.Void _TryInitSpatialAudio(AkBasePlatformSettings& activePlatformSettings) { }
        // RVA: 0x0350B670  token: 0x6000CBC
        private static System.Void _TryInitCommunication(AkBasePlatformSettings& activePlatformSettings) { }
        // RVA: 0x042ADC58  token: 0x6000CBD
        public static System.Void TerminateSoundEngine(System.Boolean hgDeepTerm) { }
        // RVA: 0x042ADD58  token: 0x6000CBE
        private static System.Void _WaitCallbacks(System.Int32 retry) { }

    }

    // TypeToken: 0x2000096  // size: 0x10
    public class ShortIDGenerator
    {
        // Fields
        private static System.UInt32 s_prime32;  // const
        private static System.UInt32 s_offsetBasis32;  // const
        private static System.Byte s_hashSize;  // static @ 0x0
        private static System.UInt32 s_mask;  // static @ 0x4

        // Properties
        System.Byte HashSize { get; /* RVA: 0x042BE384 */ set; /* RVA: 0x042BE3D4 */ }

        // Methods
        // RVA: 0x042BE378  token: 0x6000CCB
        private static System.Void .cctor() { }
        // RVA: 0x042BE280  token: 0x6000CCE
        public static System.UInt32 Compute(System.String in_name) { }
        // RVA: 0x0350B670  token: 0x6000CCF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000095  // size: 0x10
    public class AkUtilities
    {
        // Methods
        // RVA: 0x042BCE44  token: 0x6000CC7
        public static System.Void FixSlashes(System.String& path, System.Char separatorChar, System.Char badChar, System.Boolean addTrailingSlash) { }
        // RVA: 0x042BCDD8  token: 0x6000CC8
        public static System.Void FixSlashes(System.String& path) { }
        // RVA: 0x042BCF70  token: 0x6000CC9
        public static System.String GetPathInPackage(System.String relativePath) { }
        // RVA: 0x0350B670  token: 0x6000CCA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000097  // size: 0x28
    public sealed struct AkVector64
    {
        // Fields
        public System.Double X;  // 0x10
        public System.Double Y;  // 0x18
        public System.Double Z;  // 0x20

        // Methods
        // RVA: 0x03D4E350  token: 0x6000CD0
        public System.Void Zero() { }
        // RVA: 0x02BA1B00  token: 0x6000CD1
        public static AkVector64 op_Implicit(UnityEngine.Vector3 vector) { }

    }

    // TypeToken: 0x2000099  // size: 0x30
    public abstract class PlatformSettings : AkCommonPlatformSettings
    {
        // Fields
        private System.Collections.Generic.List<System.String> IgnorePropertyNameList;  // 0x18
        private System.Collections.Generic.List<System.String> GlobalPropertyNameList;  // 0x20
        private System.Collections.Generic.HashSet<System.String> _GlobalPropertyHashSet;  // 0x28

        // Properties
        System.Collections.Generic.HashSet<System.String> GlobalPropertyHashSet { get; /* RVA: 0x042BE1EC */ set; /* RVA: 0x02C92F10 */ }

        // Methods
        // RVA: 0x0346EAD0  token: 0x6000CDE
        public System.Void IgnorePropertyValue(System.String propertyPath) { }
        // RVA: 0x0346EB50  token: 0x6000CDF
        public System.Boolean IsPropertyIgnored(System.String propertyPath) { }
        // RVA: 0x0346E430  token: 0x6000CE0
        protected System.Void .ctor() { }
        // RVA: 0x03470930  token: 0x6000CE1
        public System.Void SetUseGlobalPropertyValue(System.String propertyPath, System.Boolean use) { }
        // RVA: 0x02B65990  token: 0x6000CE2
        public System.Void SetGlobalPropertyValues(System.Collections.IEnumerable enumerable) { }
        // RVA: 0x02B65E00  token: 0x6000CE3
        private System.Boolean IsUsingGlobalPropertyValue(System.String propertyPath) { }

    }

    // TypeToken: 0x200009A  // size: 0x48
    public class CommonPlatformSettings : PlatformSettings
    {
        // Fields
        public AkCommonUserSettings UserSettings;  // 0x30
        public AkCommonAdvancedSettings AdvancedSettings;  // 0x38
        public AkCommonCommSettings CommsSettings;  // 0x40

        // Methods
        // RVA: 0x01003830  token: 0x6000CE6
        protected virtual AkCommonUserSettings GetUserSettings() { }
        // RVA: 0x03D4E2A0  token: 0x6000CE7
        protected virtual AkCommonAdvancedSettings GetAdvancedSettings() { }
        // RVA: 0x03D4E2B0  token: 0x6000CE8
        protected virtual AkCommonCommSettings GetCommsSettings() { }
        // RVA: 0x0346E240  token: 0x6000CE9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000098  // size: 0x48
    public class AkWwiseInitializationSettings : AkCommonPlatformSettings
    {
        // Fields
        public System.Collections.Generic.List<System.String> PlatformSettingsNameList;  // 0x18
        public System.Collections.Generic.List<AkWwiseInitializationSettings.PlatformSettings> PlatformSettingsList;  // 0x20
        public System.Collections.Generic.List<System.String> InvalidReferencePlatforms;  // 0x28
        public AkCommonUserSettings UserSettings;  // 0x30
        public AkCommonAdvancedSettings AdvancedSettings;  // 0x38
        public AkCommonCommSettings CommsSettings;  // 0x40
        private static readonly System.String[] AllGlobalValues;  // static @ 0x0
        private static AkWwiseInitializationSettings m_Instance;  // static @ 0x8
        private static AkBasePlatformSettings m_ActivePlatformSettings;  // static @ 0x10

        // Properties
        System.Boolean IsValid { get; /* RVA: 0x02A01C80 */ }
        System.Int32 Count { get; /* RVA: 0x02A02700 */ }
        AkWwiseInitializationSettings Instance { get; /* RVA: 0x02A02740 */ set; /* RVA: 0x042BD250 */ }
        AkBasePlatformSettings ActivePlatformSettings { get; /* RVA: 0x02A02430 */ }

        // Methods
        // RVA: 0x01003830  token: 0x6000CD4
        protected virtual AkCommonUserSettings GetUserSettings() { }
        // RVA: 0x03D4E2A0  token: 0x6000CD5
        protected virtual AkCommonAdvancedSettings GetAdvancedSettings() { }
        // RVA: 0x03D4E2B0  token: 0x6000CD6
        protected virtual AkCommonCommSettings GetCommsSettings() { }
        // RVA: 0x02A025A0  token: 0x6000CD9
        private static AkBasePlatformSettings GetPlatformSettings(System.String platformName) { }
        // RVA: 0x0350B670  token: 0x6000CDB
        private System.Void OnEnable() { }
        // RVA: 0x0346E250  token: 0x6000CDC
        public System.Void .ctor() { }
        // RVA: 0x036FC180  token: 0x6000CDD
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200009B  // size: 0x20
    public class AkAcousticSurfaceArray : AkBaseArray`1
    {
        // Properties
        System.Int32 StructureSize { get; /* RVA: 0x042AA5E4 */ }

        // Methods
        // RVA: 0x042AA59C  token: 0x6000CEA
        public System.Void .ctor(System.Int32 count) { }
        // RVA: 0x042AA550  token: 0x6000CEC
        protected virtual System.Void DefaultConstructAtIntPtr(System.IntPtr address) { }
        // RVA: 0x042AA504  token: 0x6000CED
        protected virtual AkAcousticSurface CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        // RVA: 0x042AA4A0  token: 0x6000CEE
        protected virtual System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkAcousticSurface other) { }

    }

    // TypeToken: 0x200009C  // size: 0x28
    public class AkAuxSendArray : System.IDisposable
    {
        // Fields
        private static System.Int32 MAX_COUNT;  // const
        private readonly System.Int32 SIZE_OF_AKAUXSENDVALUE;  // 0x10
        private System.IntPtr m_Buffer;  // 0x18
        private System.Int32 m_Count;  // 0x20

        // Properties
        AkAuxSendValue Item { get; /* RVA: 0x042AB378 */ }
        System.Boolean isFull { get; /* RVA: 0x042AB438 */ }

        // Methods
        // RVA: 0x042AB2FC  token: 0x6000CEF
        public System.Void .ctor() { }
        // RVA: 0x042AB144  token: 0x6000CF2
        public virtual System.Void Dispose() { }
        // RVA: 0x042AB1A4  token: 0x6000CF3
        protected virtual System.Void Finalize() { }
        // RVA: 0x03D4E2C0  token: 0x6000CF4
        public System.Void Reset() { }
        // RVA: 0x042AAEB4  token: 0x6000CF5
        public System.Boolean Add(System.UInt64 in_listenerGameObj, System.UInt32 in_AuxBusID, System.Single in_fValue) { }
        // RVA: 0x042AAF64  token: 0x6000CF6
        public System.Boolean Add(System.UInt32 in_AuxBusID, System.Single in_fValue) { }
        // RVA: 0x042AB004  token: 0x6000CF7
        public System.Boolean Contains(System.UInt64 in_listenerGameObj, System.UInt32 in_AuxBusID) { }
        // RVA: 0x042AB0A4  token: 0x6000CF8
        public System.Boolean Contains(System.UInt32 in_AuxBusID) { }
        // RVA: 0x042AB288  token: 0x6000CF9
        public AKRESULT SetValues(System.UInt64 gameObject) { }
        // RVA: 0x042AB214  token: 0x6000CFA
        public AKRESULT GetValues(System.UInt64 gameObject) { }
        // RVA: 0x01041090  token: 0x6000CFB
        public System.IntPtr GetBuffer() { }
        // RVA: 0x01003B50  token: 0x6000CFC
        public System.Int32 Count() { }
        // RVA: 0x042AB2EC  token: 0x6000CFD
        private System.IntPtr _GetObjectPtr(System.Int32 index) { }

    }

    // TypeToken: 0x200009D
    public abstract class AkBaseArray`1 : System.IDisposable
    {
        // Fields
        private System.Int32 <Capacity>k__BackingField;  // 0x0
        private System.IntPtr m_Buffer;  // 0x0

        // Properties
        System.Int32 Capacity { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        System.Int32 StructureSize { get; /* RVA: -1  // abstract */ }
        T Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000CFE
        public System.Void .ctor(System.Int32 capacity) { }
        // RVA: -1  // not resolved  token: 0x6000CFF
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000D00
        protected virtual System.Void Finalize() { }
        // RVA: -1  // not resolved  token: 0x6000D03
        public virtual System.Int32 Count() { }
        // RVA: -1  // not resolved  token: 0x6000D05
        protected virtual System.Void DefaultConstructAtIntPtr(System.IntPtr address) { }
        // RVA: -1  // not resolved  token: 0x6000D06
        protected virtual System.Void ReleaseAllocatedMemoryFromReferenceAtIntPtr(System.IntPtr address) { }
        // RVA: -1  // abstract  token: 0x6000D07
        protected virtual T CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        // RVA: -1  // abstract  token: 0x6000D08
        protected virtual System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, T other) { }
        // RVA: -1  // not resolved  token: 0x6000D0B
        public System.IntPtr GetBuffer() { }
        // RVA: -1  // not resolved  token: 0x6000D0C
        protected System.IntPtr GetObjectPtr(System.Int32 index) { }

    }

    // TypeToken: 0x200009E  // size: 0x28
    public class AkChannelEmitterArray : System.IDisposable
    {
        // Fields
        public System.IntPtr m_Buffer;  // 0x10
        private System.IntPtr m_Current;  // 0x18
        private System.UInt32 m_MaxCount;  // 0x20
        private System.UInt32 <Count>k__BackingField;  // 0x24

        // Properties
        System.UInt32 Count { get; /* RVA: 0x03D4E2E0 */ set; /* RVA: 0x03D4E2F0 */ }

        // Methods
        // RVA: 0x042AC9F0  token: 0x6000D0D
        public System.Void .ctor(System.UInt32 in_Count) { }
        // RVA: 0x042AC920  token: 0x6000D10
        public virtual System.Void Dispose() { }
        // RVA: 0x042AC980  token: 0x6000D11
        protected virtual System.Void Finalize() { }
        // RVA: 0x03D4E2D0  token: 0x6000D12
        public System.Void Reset() { }
        // RVA: 0x042AC63C  token: 0x6000D13
        public System.Void Add(AkVector64 in_Pos, UnityEngine.Vector3 in_Forward, UnityEngine.Vector3 in_Top, System.UInt32 in_ChannelMask) { }

    }

    // TypeToken: 0x200009F  // size: 0x20
    public class AkDeviceDescriptionArray : AkBaseArray`1
    {
        // Properties
        System.Int32 StructureSize { get; /* RVA: 0x03694FA0 */ }

        // Methods
        // RVA: 0x036182F0  token: 0x6000D14
        public System.Void .ctor(System.Int32 count) { }
        // RVA: 0x03799BD0  token: 0x6000D16
        protected virtual System.Void DefaultConstructAtIntPtr(System.IntPtr address) { }
        // RVA: 0x0386C0D0  token: 0x6000D17
        protected virtual AkDeviceDescription CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        // RVA: 0x042ACC20  token: 0x6000D18
        protected virtual System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkDeviceDescription other) { }

    }

    // TypeToken: 0x20000A0  // size: 0x20
    public class AkDiffractionPathInfoArray : AkBaseArray`1
    {
        // Properties
        System.Int32 StructureSize { get; /* RVA: 0x042ACD7C */ }

        // Methods
        // RVA: 0x042ACD34  token: 0x6000D19
        public System.Void .ctor(System.Int32 count) { }
        // RVA: 0x042ACCE8  token: 0x6000D1B
        protected virtual AkDiffractionPathInfo CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        // RVA: 0x042ACC84  token: 0x6000D1C
        protected virtual System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkDiffractionPathInfo other) { }

    }

    // TypeToken: 0x20000A1  // size: 0x20
    public class AkExternalSourceInfoArray : AkBaseArray`1
    {
        // Properties
        System.Int32 StructureSize { get; /* RVA: 0x03742240 */ }

        // Methods
        // RVA: 0x03828020  token: 0x6000D1D
        public System.Void .ctor(System.Int32 count) { }
        // RVA: 0x03C94770  token: 0x6000D1F
        protected virtual System.Void DefaultConstructAtIntPtr(System.IntPtr address) { }
        // RVA: 0x042ACE20  token: 0x6000D20
        protected virtual System.Void ReleaseAllocatedMemoryFromReferenceAtIntPtr(System.IntPtr address) { }
        // RVA: 0x03766780  token: 0x6000D21
        protected virtual AkExternalSourceInfo CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        // RVA: 0x042ACDBC  token: 0x6000D22
        protected virtual System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkExternalSourceInfo other) { }

    }

    // TypeToken: 0x20000A2  // size: 0x20
    public class AkMIDIPostArray
    {
        // Fields
        private readonly System.Int32 m_Count;  // 0x10
        private readonly System.Int32 SIZE_OF;  // 0x14
        private System.IntPtr m_Buffer;  // 0x18

        // Properties
        AkMIDIPost Item { get; /* RVA: 0x042AD5A8 */ set; /* RVA: 0x042AD674 */ }

        // Methods
        // RVA: 0x042AD520  token: 0x6000D23
        public System.Void .ctor(System.Int32 size) { }
        // RVA: 0x042AD2CC  token: 0x6000D26
        protected virtual System.Void Finalize() { }
        // RVA: 0x042AD38C  token: 0x6000D27
        public System.Void PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject gameObject) { }
        // RVA: 0x042AD428  token: 0x6000D28
        public System.Void PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject gameObject, System.Int32 count) { }
        // RVA: 0x01041090  token: 0x6000D29
        public System.IntPtr GetBuffer() { }
        // RVA: 0x03D4E340  token: 0x6000D2A
        public System.Int32 Count() { }
        // RVA: 0x042AD37C  token: 0x6000D2B
        private System.IntPtr GetObjectPtr(System.Int32 index) { }

    }

    // TypeToken: 0x20000A3  // size: 0x20
    public class AkObjectInfoArray : AkBaseArray`1
    {
        // Properties
        System.Int32 StructureSize { get; /* RVA: 0x042AD88C */ }

        // Methods
        // RVA: 0x042AD844  token: 0x6000D2C
        public System.Void .ctor(System.Int32 count) { }
        // RVA: 0x042AD7F8  token: 0x6000D2E
        protected virtual System.Void DefaultConstructAtIntPtr(System.IntPtr address) { }
        // RVA: 0x042AD7AC  token: 0x6000D2F
        protected virtual AkObjectInfo CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        // RVA: 0x042AD748  token: 0x6000D30
        protected virtual System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkObjectInfo other) { }

    }

    // TypeToken: 0x20000A4  // size: 0x20
    public class AkObstructionOcclusionValuesArray : AkBaseArray`1
    {
        // Properties
        System.Int32 StructureSize { get; /* RVA: 0x042ADA10 */ }

        // Methods
        // RVA: 0x042AD9C8  token: 0x6000D31
        public System.Void .ctor(System.Int32 count) { }
        // RVA: 0x042AD97C  token: 0x6000D33
        protected virtual System.Void DefaultConstructAtIntPtr(System.IntPtr address) { }
        // RVA: 0x042AD930  token: 0x6000D34
        protected virtual AkObstructionOcclusionValues CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        // RVA: 0x042AD8CC  token: 0x6000D35
        protected virtual System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkObstructionOcclusionValues other) { }

    }

    // TypeToken: 0x20000A5  // size: 0x28
    public class AkPositionArray : System.IDisposable
    {
        // Fields
        public System.IntPtr m_Buffer;  // 0x10
        private System.IntPtr m_Current;  // 0x18
        private System.UInt32 m_MaxCount;  // 0x20
        private System.UInt32 <Count>k__BackingField;  // 0x24

        // Properties
        System.UInt32 Count { get; /* RVA: 0x03D4E2E0 */ set; /* RVA: 0x03D4E2F0 */ }

        // Methods
        // RVA: 0x03287E20  token: 0x6000D36
        public System.Void .ctor(System.UInt32 in_Count) { }
        // RVA: 0x042ADA50  token: 0x6000D39
        public virtual System.Void Dispose() { }
        // RVA: 0x042ADAB0  token: 0x6000D3A
        protected virtual System.Void Finalize() { }
        // RVA: 0x03D4E2D0  token: 0x6000D3B
        public System.Void Reset() { }
        // RVA: 0x03287BD0  token: 0x6000D3C
        public System.Void Add(AkVector64 in_Pos, UnityEngine.Vector3 in_Forward, UnityEngine.Vector3 in_Top) { }

    }

    // TypeToken: 0x20000A6  // size: 0x20
    public class AkReflectionPathInfoArray : AkBaseArray`1
    {
        // Properties
        System.Int32 StructureSize { get; /* RVA: 0x042ADC18 */ }

        // Methods
        // RVA: 0x042ADBD0  token: 0x6000D3D
        public System.Void .ctor(System.Int32 count) { }
        // RVA: 0x042ADB84  token: 0x6000D3F
        protected virtual AkReflectionPathInfo CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        // RVA: 0x042ADB20  token: 0x6000D40
        protected virtual System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkReflectionPathInfo other) { }

    }

    // TypeToken: 0x20000A7  // size: 0x20
    public class AkSourceSettingsArray : AkBaseArray`1
    {
        // Properties
        System.Int32 StructureSize { get; /* RVA: 0x042BC760 */ }

        // Methods
        // RVA: 0x042BC718  token: 0x6000D41
        public System.Void .ctor(System.Int32 count) { }
        // RVA: 0x042BC6CC  token: 0x6000D43
        protected virtual System.Void DefaultConstructAtIntPtr(System.IntPtr address) { }
        // RVA: 0x042BC680  token: 0x6000D44
        protected virtual AkSourceSettings CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        // RVA: 0x042BC61C  token: 0x6000D45
        protected virtual System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkSourceSettings other) { }

    }

    // TypeToken: 0x20000A8  // size: 0x20
    public class AkTriangleArray : AkBaseArray`1
    {
        // Properties
        System.Int32 StructureSize { get; /* RVA: 0x042BCD20 */ }

        // Methods
        // RVA: 0x042BCCD8  token: 0x6000D46
        public System.Void .ctor(System.Int32 count) { }
        // RVA: 0x042BCC8C  token: 0x6000D48
        protected virtual System.Void DefaultConstructAtIntPtr(System.IntPtr address) { }
        // RVA: 0x042BCC40  token: 0x6000D49
        protected virtual AkTriangle CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        // RVA: 0x042BCBDC  token: 0x6000D4A
        protected virtual System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkTriangle other) { }

    }

    // TypeToken: 0x20000AA  // size: 0x20
    public sealed struct AudioTriangleArrayNoGc : System.IDisposable
    {
        // Fields
        private System.IntPtr m_buffer;  // 0x10
        private System.Int32 m_capacity;  // 0x18
        private System.Int32 m_elementSize;  // 0x1c

        // Properties
        System.IntPtr Buffer { get; /* RVA: 0x020C61B0 */ }

        // Methods
        // RVA: 0x026CFF70  token: 0x6000D52
        public System.Void .ctor(System.Int32 capacity) { }
        // RVA: 0x026D75D0  token: 0x6000D53
        public System.Void Set(System.Int32 idx, System.UInt16 p0, System.UInt16 p1, System.UInt16 p2, System.UInt16 surface) { }
        // RVA: 0x026CFE30  token: 0x6000D54
        public virtual System.Void Dispose() { }

    }

    // TypeToken: 0x20000AB  // size: 0x20
    public sealed struct AudioAcousticSurfaceArrayNoGc : System.IDisposable
    {
        // Fields
        private System.IntPtr m_buffer;  // 0x10
        private System.Int32 m_capacity;  // 0x18
        private System.Int32 m_elementSize;  // 0x1c

        // Properties
        System.IntPtr Buffer { get; /* RVA: 0x020C61B0 */ }

        // Methods
        // RVA: 0x026D00D0  token: 0x6000D56
        public System.Void .ctor(System.Int32 capacity) { }
        // RVA: 0x026D5540  token: 0x6000D57
        public System.Void Set(System.Int32 idx, System.Single transmissionLoss, System.UInt32 textureId) { }
        // RVA: 0x026CFEA0  token: 0x6000D58
        public virtual System.Void Dispose() { }

    }

    // TypeToken: 0x20000A9  // size: 0x10
    public static class AudioNativeHelper
    {
        // Fields
        private static System.IntPtr s_reusedTransformPtr;  // static @ 0x0

        // Methods
        // RVA: 0x02A01B30  token: 0x6000D4B
        private static System.Void Init() { }
        // RVA: 0x042BD7F4  token: 0x6000D4C
        private static System.Void Term() { }
        // RVA: 0x042BD674  token: 0x6000D4D
        public static AKRESULT SetRoomPortal(System.UInt64 portalID, System.UInt64 frontRoom, System.UInt64 backRoom, UnityEngine.Vector3 position, UnityEngine.Vector3 orientationFront, UnityEngine.Vector3 orientationTop, UnityEngine.Vector3 extent, System.Boolean enabled, System.String portalName) { }
        // RVA: 0x026D53E0  token: 0x6000D4E
        public static AKRESULT SetGeometry(System.UInt64 geoId, AudioNativeHelper.AudioTriangleArrayNoGc triangles, System.UInt32 numTriangles, UnityEngine.Vector3[] vertices, System.UInt32 numVertices, AudioNativeHelper.AudioAcousticSurfaceArrayNoGc surfaces, System.UInt32 numSurfaces, System.Boolean enableDiffraction, System.Boolean enableDiffractionOnBoundaryEdges) { }
        // RVA: 0x031AD9E0  token: 0x6000D4F
        public static AKRESULT SetGeometryInstance(System.UInt64 geomInstanceID, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 scale, System.UInt64 geometrySetID, System.UInt64 roomID, System.Boolean useForReflectionAndDiffraction) { }
        // RVA: 0x03D44BE0  token: 0x6000D50
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000AE  // size: 0x14
    public sealed struct Category
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkiOSSettings.PlatformAdvancedSettings.Category Ambient;  // const
        public static AkiOSSettings.PlatformAdvancedSettings.Category SoloAmbient;  // const
        public static AkiOSSettings.PlatformAdvancedSettings.Category PlayAndRecord;  // const
        public static AkiOSSettings.PlatformAdvancedSettings.Category Playback;  // const

    }

    // TypeToken: 0x20000AF  // size: 0x14
    public sealed struct CategoryOptions
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkiOSSettings.PlatformAdvancedSettings.CategoryOptions MixWithOthers;  // const
        public static AkiOSSettings.PlatformAdvancedSettings.CategoryOptions DuckOthers;  // const
        public static AkiOSSettings.PlatformAdvancedSettings.CategoryOptions AllowBluetooth;  // const
        public static AkiOSSettings.PlatformAdvancedSettings.CategoryOptions DefaultToSpeaker;  // const

    }

    // TypeToken: 0x20000B0  // size: 0x14
    public sealed struct Mode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static AkiOSSettings.PlatformAdvancedSettings.Mode Default;  // const
        public static AkiOSSettings.PlatformAdvancedSettings.Mode VoiceChat;  // const
        public static AkiOSSettings.PlatformAdvancedSettings.Mode GameChat;  // const
        public static AkiOSSettings.PlatformAdvancedSettings.Mode VideoRecording;  // const
        public static AkiOSSettings.PlatformAdvancedSettings.Mode Measurement;  // const
        public static AkiOSSettings.PlatformAdvancedSettings.Mode MoviePlayback;  // const
        public static AkiOSSettings.PlatformAdvancedSettings.Mode VideoChat;  // const

    }

    // TypeToken: 0x20000AD  // size: 0x68
    public class PlatformAdvancedSettings : AkCommonAdvancedSettings
    {
        // Fields
        public AkiOSSettings.PlatformAdvancedSettings.Category m_AudioSessionCategory;  // 0x50
        public AkiOSSettings.PlatformAdvancedSettings.CategoryOptions m_AudioSessionCategoryOptions;  // 0x54
        public AkiOSSettings.PlatformAdvancedSettings.Mode m_AudioSessionMode;  // 0x58
        public System.UInt32 NumSpatialAudioPointSources;  // 0x5c
        public System.Boolean VerboseSystemOutput;  // 0x60

        // Methods
        // RVA: 0x0350B670  token: 0x6000D5D
        public virtual System.Void CopyTo(AkPlatformInitSettings settings) { }
        // RVA: 0x03D2DF50  token: 0x6000D5E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000AC  // size: 0x48
    public class AkiOSSettings : PlatformSettings
    {
        // Fields
        public AkCommonUserSettings UserSettings;  // 0x30
        public AkiOSSettings.PlatformAdvancedSettings AdvancedSettings;  // 0x38
        public AkCommonCommSettings CommsSettings;  // 0x40

        // Methods
        // RVA: 0x0346EBB0  token: 0x6000D59
        public System.Void .ctor() { }
        // RVA: 0x01003830  token: 0x6000D5A
        protected virtual AkCommonUserSettings GetUserSettings() { }
        // RVA: 0x03D4E2A0  token: 0x6000D5B
        protected virtual AkCommonAdvancedSettings GetAdvancedSettings() { }
        // RVA: 0x03D4E2B0  token: 0x6000D5C
        protected virtual AkCommonCommSettings GetCommsSettings() { }

    }

    // TypeToken: 0x20000B2  // size: 0x58
    public class PlatformAdvancedSettings : AkCommonAdvancedSettings
    {
        // Fields
        public System.UInt32 NumSpatialAudioPointSources;  // 0x50
        public System.Boolean VerboseSystemOutput;  // 0x54

        // Methods
        // RVA: 0x0350B670  token: 0x6000D63
        public virtual System.Void CopyTo(AkPlatformInitSettings settings) { }
        // RVA: 0x03D4E360  token: 0x6000D64
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B1  // size: 0x48
    public class AkMacSettings : PlatformSettings
    {
        // Fields
        public AkCommonUserSettings UserSettings;  // 0x30
        public AkMacSettings.PlatformAdvancedSettings AdvancedSettings;  // 0x38
        public AkCommonCommSettings CommsSettings;  // 0x40

        // Methods
        // RVA: 0x01003830  token: 0x6000D5F
        protected virtual AkCommonUserSettings GetUserSettings() { }
        // RVA: 0x03D4E2A0  token: 0x6000D60
        protected virtual AkCommonAdvancedSettings GetAdvancedSettings() { }
        // RVA: 0x03D4E2B0  token: 0x6000D61
        protected virtual AkCommonCommSettings GetCommsSettings() { }
        // RVA: 0x0346E240  token: 0x6000D62
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B4  // size: 0x68
    public class PlatformAdvancedSettings : AkCommonAdvancedSettings
    {
        // Fields
        public System.UInt32 NumAudioOut2Ports;  // 0x50
        public System.UInt32 NumAudioOut2ObjectPorts;  // 0x54
        public System.Boolean HwCodecLowLatencyMode;  // 0x58
        public System.Boolean VorbisHwAcceleration;  // 0x59
        public System.Boolean Enable3DAudioSync;  // 0x5a
        public System.UInt32 NumOperationsForHwMixing;  // 0x5c
        public System.Boolean PlotQueueLevel;  // 0x60

        // Methods
        // RVA: 0x0350B670  token: 0x6000D69
        public virtual System.Void CopyTo(AkPlatformInitSettings settings) { }
        // RVA: 0x03471420  token: 0x6000D6A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B3  // size: 0x48
    public class AkPS5Settings : PlatformSettings
    {
        // Fields
        public AkCommonUserSettings UserSettings;  // 0x30
        public AkPS5Settings.PlatformAdvancedSettings AdvancedSettings;  // 0x38
        public AkCommonCommSettings CommsSettings;  // 0x40

        // Methods
        // RVA: 0x03470CB0  token: 0x6000D65
        public System.Void .ctor() { }
        // RVA: 0x01003830  token: 0x6000D66
        protected virtual AkCommonUserSettings GetUserSettings() { }
        // RVA: 0x03D4E2A0  token: 0x6000D67
        protected virtual AkCommonAdvancedSettings GetAdvancedSettings() { }
        // RVA: 0x03D4E2B0  token: 0x6000D68
        protected virtual AkCommonCommSettings GetCommsSettings() { }

    }

    // TypeToken: 0x20000B6  // size: 0x58
    public class PlatformAdvancedSettings : AkCommonAdvancedSettings
    {
        // Fields
        public System.UInt32 MaxSystemAudioObjects;  // 0x50

        // Methods
        // RVA: 0x03C97780  token: 0x6000D6F
        public virtual System.Void CopyTo(AkPlatformInitSettings settings) { }
        // RVA: 0x03D4E360  token: 0x6000D70
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B5  // size: 0x48
    public class AkWindowsSettings : PlatformSettings
    {
        // Fields
        public AkCommonUserSettings UserSettings;  // 0x30
        public AkWindowsSettings.PlatformAdvancedSettings AdvancedSettings;  // 0x38
        public AkCommonCommSettings CommsSettings;  // 0x40

        // Methods
        // RVA: 0x01003830  token: 0x6000D6B
        protected virtual AkCommonUserSettings GetUserSettings() { }
        // RVA: 0x03D4E2A0  token: 0x6000D6C
        protected virtual AkCommonAdvancedSettings GetAdvancedSettings() { }
        // RVA: 0x03D4E2B0  token: 0x6000D6D
        protected virtual AkCommonCommSettings GetCommsSettings() { }
        // RVA: 0x0346E240  token: 0x6000D6E
        public System.Void .ctor() { }

    }

