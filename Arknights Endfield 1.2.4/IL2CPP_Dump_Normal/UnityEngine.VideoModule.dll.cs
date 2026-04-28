// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.VideoModule.dll
// Classes:  15
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x200000C  // size: 0x80
    public sealed class EventHandler : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x06DE8490  token: 0x6000080
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x6000081
        public virtual System.Void Invoke(UnityEngine.Video.VideoPlayer source) { }

    }

    // TypeToken: 0x200000D  // size: 0x80
    public sealed class ErrorEventHandler : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x0951C0FC  token: 0x6000082
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02065C10  token: 0x6000083
        public virtual System.Void Invoke(UnityEngine.Video.VideoPlayer source, System.String message) { }

    }

    // TypeToken: 0x200000E  // size: 0x80
    public sealed class FrameReadyEventHandler : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x07977BE4  token: 0x6000084
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02065C10  token: 0x6000085
        public virtual System.Void Invoke(UnityEngine.Video.VideoPlayer source, System.Int64 frameIdx) { }

    }

    // TypeToken: 0x200000F  // size: 0x80
    public sealed class TimeEventHandler : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x09F899B4  token: 0x6000086
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02065C10  token: 0x6000087
        public virtual System.Void Invoke(UnityEngine.Video.VideoPlayer source, System.Double seconds) { }

    }

namespace UnityEngine.Experimental.Video
{

    // TypeToken: 0x2000002  // size: 0x20
    public sealed struct VideoClipPlayable : UnityEngine.Playables.IPlayable, System.IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;  // 0x10

        // Methods
        // RVA: 0x03D695A0  token: 0x6000001
        public virtual UnityEngine.Playables.PlayableHandle GetHandle() { }
        // RVA: 0x09F89A88  token: 0x6000002
        public virtual System.Boolean Equals(UnityEngine.Experimental.Video.VideoClipPlayable other) { }

    }

}

namespace UnityEngine.Video
{

    // TypeToken: 0x2000003  // size: 0x18
    public sealed class VideoClip : UnityEngine.Object
    {
        // Properties
        System.String originalPath { get; /* RVA: 0x09F89D0C */ }
        System.UInt64 frameCount { get; /* RVA: 0x09F89C3C */ }
        System.Double frameRate { get; /* RVA: 0x09F89C70 */ }
        System.Double length { get; /* RVA: 0x09F89CD8 */ }
        System.UInt32 width { get; /* RVA: 0x09F89DDC */ }
        System.UInt32 height { get; /* RVA: 0x09F89CA4 */ }
        System.UInt32 pixelAspectRatioNumerator { get; /* RVA: 0x09F89D74 */ }
        System.UInt32 pixelAspectRatioDenominator { get; /* RVA: 0x09F89D40 */ }
        System.Boolean sRGB { get; /* RVA: 0x09F89DA8 */ }
        System.UInt16 audioTrackCount { get; /* RVA: 0x09F89C08 */ }

        // Methods
        // RVA: 0x09F89BC8  token: 0x6000003
        private System.Void .ctor() { }
        // RVA: 0x09F89AFC  token: 0x600000E
        public System.UInt16 GetAudioChannelCount(System.UInt16 audioTrackIdx) { }
        // RVA: 0x09F89B84  token: 0x600000F
        public System.UInt32 GetAudioSampleRate(System.UInt16 audioTrackIdx) { }
        // RVA: 0x09F89B40  token: 0x6000010
        public System.String GetAudioLanguage(System.UInt16 audioTrackIdx) { }

    }

    // TypeToken: 0x2000004  // size: 0x14
    public sealed struct VideoRenderMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Video.VideoRenderMode CameraFarPlane;  // const
        public static UnityEngine.Video.VideoRenderMode CameraNearPlane;  // const
        public static UnityEngine.Video.VideoRenderMode RenderTexture;  // const
        public static UnityEngine.Video.VideoRenderMode MaterialOverride;  // const
        public static UnityEngine.Video.VideoRenderMode APIOnly;  // const

    }

    // TypeToken: 0x2000005  // size: 0x14
    public sealed struct Video3DLayout
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Video.Video3DLayout No3D;  // const
        public static UnityEngine.Video.Video3DLayout SideBySide3D;  // const
        public static UnityEngine.Video.Video3DLayout OverUnder3D;  // const

    }

    // TypeToken: 0x2000006  // size: 0x14
    public sealed struct VideoAspectRatio
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Video.VideoAspectRatio NoScaling;  // const
        public static UnityEngine.Video.VideoAspectRatio FitVertically;  // const
        public static UnityEngine.Video.VideoAspectRatio FitHorizontally;  // const
        public static UnityEngine.Video.VideoAspectRatio FitInside;  // const
        public static UnityEngine.Video.VideoAspectRatio FitOutside;  // const
        public static UnityEngine.Video.VideoAspectRatio Stretch;  // const

    }

    // TypeToken: 0x2000007  // size: 0x14
    public sealed struct VideoTimeSource
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Video.VideoTimeSource AudioDSPTimeSource;  // const
        public static UnityEngine.Video.VideoTimeSource GameTimeSource;  // const

    }

    // TypeToken: 0x2000008  // size: 0x14
    public sealed struct VideoTimeReference
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Video.VideoTimeReference Freerun;  // const
        public static UnityEngine.Video.VideoTimeReference InternalTime;  // const
        public static UnityEngine.Video.VideoTimeReference ExternalTime;  // const

    }

    // TypeToken: 0x2000009  // size: 0x14
    public sealed struct VideoSource
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Video.VideoSource VideoClip;  // const
        public static UnityEngine.Video.VideoSource Url;  // const

    }

    // TypeToken: 0x200000A  // size: 0x14
    public sealed struct VideoAudioOutputMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Video.VideoAudioOutputMode None;  // const
        public static UnityEngine.Video.VideoAudioOutputMode AudioSource;  // const
        public static UnityEngine.Video.VideoAudioOutputMode Direct;  // const
        public static UnityEngine.Video.VideoAudioOutputMode APIOnly;  // const

    }

    // TypeToken: 0x200000B  // size: 0x58
    public sealed class VideoPlayer : UnityEngine.Behaviour
    {
        // Fields
        private UnityEngine.Video.VideoPlayer.EventHandler prepareCompleted;  // 0x18
        private UnityEngine.Video.VideoPlayer.EventHandler loopPointReached;  // 0x20
        private UnityEngine.Video.VideoPlayer.EventHandler started;  // 0x28
        private UnityEngine.Video.VideoPlayer.EventHandler frameDropped;  // 0x30
        private UnityEngine.Video.VideoPlayer.ErrorEventHandler errorReceived;  // 0x38
        private UnityEngine.Video.VideoPlayer.EventHandler seekCompleted;  // 0x40
        private UnityEngine.Video.VideoPlayer.TimeEventHandler clockResyncOccurred;  // 0x48
        private UnityEngine.Video.VideoPlayer.FrameReadyEventHandler frameReady;  // 0x50

        // Properties
        UnityEngine.Video.VideoSource source { get; /* RVA: 0x09F8AEC0 */ set; /* RVA: 0x09F8B9E4 */ }
        System.String url { get; /* RVA: 0x09F8B0FC */ set; /* RVA: 0x09F8BC7C */ }
        UnityEngine.Video.VideoClip clip { get; /* RVA: 0x09F8AAAC */ set; /* RVA: 0x09F8B6B8 */ }
        UnityEngine.Video.VideoRenderMode renderMode { get; /* RVA: 0x09F8AE24 */ set; /* RVA: 0x09F8B91C */ }
        UnityEngine.Camera targetCamera { get; /* RVA: 0x09F8AF5C */ set; /* RVA: 0x09F8BAA8 */ }
        UnityEngine.RenderTexture targetTexture { get; /* RVA: 0x09F8AFF8 */ set; /* RVA: 0x09F8BB74 */ }
        UnityEngine.Renderer targetMaterialRenderer { get; /* RVA: 0x09F8AFC4 */ set; /* RVA: 0x09F8BB30 */ }
        System.String targetMaterialProperty { get; /* RVA: 0x09F8AF90 */ set; /* RVA: 0x09F8BAEC */ }
        UnityEngine.Video.VideoAspectRatio aspectRatio { get; /* RVA: 0x09F8A8D8 */ set; /* RVA: 0x09F8B638 */ }
        System.Single targetCameraAlpha { get; /* RVA: 0x09F8AF28 */ set; /* RVA: 0x09F8BA64 */ }
        UnityEngine.Video.Video3DLayout targetCamera3DLayout { get; /* RVA: 0x09F8AEF4 */ set; /* RVA: 0x09F8BA24 */ }
        UnityEngine.Texture texture { get; /* RVA: 0x09F8B02C */ }
        System.Boolean isPrepared { get; /* RVA: 0x09F8ACEC */ }
        System.Boolean waitForFirstFrame { get; /* RVA: 0x09F8B130 */ set; /* RVA: 0x09F8BCC0 */ }
        System.Boolean playOnAwake { get; /* RVA: 0x09F8ADBC */ set; /* RVA: 0x09F8B894 */ }
        System.Boolean isPlaying { get; /* RVA: 0x09F8ACB8 */ }
        System.Boolean isPaused { get; /* RVA: 0x09F8AC84 */ }
        System.Boolean canSetTime { get; /* RVA: 0x09F8AA44 */ }
        System.Double time { get; /* RVA: 0x09F8B0C8 */ set; /* RVA: 0x09F8BC38 */ }
        System.Int64 frame { get; /* RVA: 0x09F8ABE8 */ set; /* RVA: 0x09F8B80C */ }
        System.Double clockTime { get; /* RVA: 0x09F8AAE0 */ }
        System.Boolean canStep { get; /* RVA: 0x09F8AA78 */ }
        System.Boolean canSetPlaybackSpeed { get; /* RVA: 0x09F8A9A8 */ }
        System.Single playbackSpeed { get; /* RVA: 0x09F8ADF0 */ set; /* RVA: 0x09F8B8D8 */ }
        System.Boolean isLooping { get; /* RVA: 0x09F8AC50 */ set; /* RVA: 0x09F8B850 */ }
        System.Boolean canSetTimeSource { get; /* RVA: 0x09F8AA10 */ }
        UnityEngine.Video.VideoTimeSource timeSource { get; /* RVA: 0x09F8B094 */ set; /* RVA: 0x09F8BBF8 */ }
        UnityEngine.Video.VideoTimeReference timeReference { get; /* RVA: 0x09F8B060 */ set; /* RVA: 0x09F8BBB8 */ }
        System.Double externalReferenceTime { get; /* RVA: 0x09F8AB4C */ set; /* RVA: 0x09F8B7C8 */ }
        System.Boolean canSetSkipOnDrop { get; /* RVA: 0x09F8A9DC */ }
        System.Boolean skipOnDrop { get; /* RVA: 0x09F8AE8C */ set; /* RVA: 0x09F8B9A0 */ }
        System.UInt64 frameCount { get; /* RVA: 0x09F8AB80 */ }
        System.Single frameRate { get; /* RVA: 0x09F8ABB4 */ }
        System.Double length { get; /* RVA: 0x09F8AD20 */ }
        System.UInt32 width { get; /* RVA: 0x09F8B164 */ }
        System.UInt32 height { get; /* RVA: 0x09F8AC1C */ }
        System.UInt32 pixelAspectRatioNumerator { get; /* RVA: 0x09F8AD88 */ }
        System.UInt32 pixelAspectRatioDenominator { get; /* RVA: 0x09F8AD54 */ }
        System.UInt16 audioTrackCount { get; /* RVA: 0x09F8A940 */ }
        System.UInt16 controlledAudioTrackMaxCount { get; /* RVA: 0x09F8AB20 */ }
        System.UInt16 controlledAudioTrackCount { get; /* RVA: 0x09F8AB14 */ set; /* RVA: 0x09F8B6FC */ }
        UnityEngine.Video.VideoAudioOutputMode audioOutputMode { get; /* RVA: 0x09F8A90C */ set; /* RVA: 0x09F8B678 */ }
        System.Boolean canSetDirectAudioVolume { get; /* RVA: 0x09F8A974 */ }
        System.Boolean sendFrameReadyEvents { get; /* RVA: 0x09F8AE58 */ set; /* RVA: 0x09F8B95C */ }

        // Events
        event UnityEngine.Video.VideoPlayer.EventHandler prepareCompleted;
        event UnityEngine.Video.VideoPlayer.EventHandler loopPointReached;
        event UnityEngine.Video.VideoPlayer.EventHandler started;
        event UnityEngine.Video.VideoPlayer.EventHandler frameDropped;
        event UnityEngine.Video.VideoPlayer.ErrorEventHandler errorReceived;
        event UnityEngine.Video.VideoPlayer.EventHandler seekCompleted;
        event UnityEngine.Video.VideoPlayer.TimeEventHandler clockResyncOccurred;
        event UnityEngine.Video.VideoPlayer.FrameReadyEventHandler frameReady;

        // Methods
        // RVA: 0x09F8A25C  token: 0x6000028
        public System.Void Prepare() { }
        // RVA: 0x09F8A228  token: 0x600002E
        public System.Void Play() { }
        // RVA: 0x09F8A1F4  token: 0x600002F
        public System.Void Pause() { }
        // RVA: 0x09F8A404  token: 0x6000030
        public System.Void Stop() { }
        // RVA: 0x09F8A3D0  token: 0x600003A
        public System.Void StepForward() { }
        // RVA: 0x09F89EA8  token: 0x6000052
        public System.String GetAudioLanguageCode(System.UInt16 trackIndex) { }
        // RVA: 0x09F89E64  token: 0x6000053
        public System.UInt16 GetAudioChannelCount(System.UInt16 trackIndex) { }
        // RVA: 0x09F89EEC  token: 0x6000054
        public System.UInt32 GetAudioSampleRate(System.UInt16 trackIndex) { }
        // RVA: 0x09F89F30  token: 0x6000058
        private System.UInt16 GetControlledAudioTrackCount() { }
        // RVA: 0x09F8A290  token: 0x6000059
        private System.Void SetControlledAudioTrackCount(System.UInt16 value) { }
        // RVA: 0x09F89E10  token: 0x600005A
        public System.Void EnableAudioTrack(System.UInt16 trackIndex, System.Boolean enabled) { }
        // RVA: 0x09F8A1B0  token: 0x600005B
        public System.Boolean IsAudioTrackEnabled(System.UInt16 trackIndex) { }
        // RVA: 0x09F89FA8  token: 0x600005F
        public System.Single GetDirectAudioVolume(System.UInt16 trackIndex) { }
        // RVA: 0x09F8A328  token: 0x6000060
        public System.Void SetDirectAudioVolume(System.UInt16 trackIndex, System.Single volume) { }
        // RVA: 0x09F89F64  token: 0x6000061
        public System.Boolean GetDirectAudioMute(System.UInt16 trackIndex) { }
        // RVA: 0x09F8A2D4  token: 0x6000062
        public System.Void SetDirectAudioMute(System.UInt16 trackIndex, System.Boolean mute) { }
        // RVA: 0x09F89FEC  token: 0x6000063
        public UnityEngine.AudioSource GetTargetAudioSource(System.UInt16 trackIndex) { }
        // RVA: 0x09F8A37C  token: 0x6000064
        public System.Void SetTargetAudioSource(System.UInt16 trackIndex, UnityEngine.AudioSource source) { }
        // RVA: 0x09F8A120  token: 0x6000077
        private static System.Void InvokePrepareCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source) { }
        // RVA: 0x09F8A0C0  token: 0x6000078
        private static System.Void InvokeFrameReadyCallback_Internal(UnityEngine.Video.VideoPlayer source, System.Int64 frameIdx) { }
        // RVA: 0x09F8A0F0  token: 0x6000079
        private static System.Void InvokeLoopPointReachedCallback_Internal(UnityEngine.Video.VideoPlayer source) { }
        // RVA: 0x09F8A180  token: 0x600007A
        private static System.Void InvokeStartedCallback_Internal(UnityEngine.Video.VideoPlayer source) { }
        // RVA: 0x09F8A090  token: 0x600007B
        private static System.Void InvokeFrameDroppedCallback_Internal(UnityEngine.Video.VideoPlayer source) { }
        // RVA: 0x09F8A060  token: 0x600007C
        private static System.Void InvokeErrorReceivedCallback_Internal(UnityEngine.Video.VideoPlayer source, System.String errorStr) { }
        // RVA: 0x09F8A150  token: 0x600007D
        private static System.Void InvokeSeekCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source) { }
        // RVA: 0x09F8A030  token: 0x600007E
        private static System.Void InvokeClockResyncOccurredCallback_Internal(UnityEngine.Video.VideoPlayer source, System.Double seconds) { }
        // RVA: 0x0426FE60  token: 0x600007F
        public System.Void .ctor() { }

    }

}

