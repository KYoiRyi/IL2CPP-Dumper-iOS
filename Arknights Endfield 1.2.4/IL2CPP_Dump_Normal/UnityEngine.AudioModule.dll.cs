// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AudioModule.dll
// Classes:  19
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000003  // size: 0x80
    public sealed class AudioConfigurationChangeHandler : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x06892B88  token: 0x6000004
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x6000005
        public virtual System.Void Invoke(System.Boolean deviceWasChanged) { }

    }

    // TypeToken: 0x2000005  // size: 0x80
    public sealed class PCMReaderCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x06DE8490  token: 0x600000B
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x600000C
        public virtual System.Void Invoke(System.Single[] data) { }

    }

    // TypeToken: 0x2000006  // size: 0x80
    public sealed class PCMSetPositionCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x056ECA08  token: 0x600000D
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x600000E
        public virtual System.Void Invoke(System.Int32 position) { }

    }

    // TypeToken: 0x2000013  // size: 0x80
    public sealed class SampleFramesHandler : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x09D99790  token: 0x6000052
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02065C10  token: 0x6000053
        public virtual System.Void Invoke(UnityEngine.Experimental.Audio.AudioSampleProvider provider, System.UInt32 sampleFrameCount) { }

    }

namespace UnityEngine
{

    // TypeToken: 0x2000002  // size: 0x10
    public sealed class AudioSettings
    {
        // Fields
        private static UnityEngine.AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged;  // static @ 0x0
        private static System.Action OnAudioSystemShuttingDown;  // static @ 0x8
        private static System.Action OnAudioSystemStartedUp;  // static @ 0x10

        // Methods
        // RVA: 0x09D99078  token: 0x6000001
        private static System.Void InvokeOnAudioConfigurationChanged(System.Boolean deviceWasChanged) { }
        // RVA: 0x09D990C8  token: 0x6000002
        private static System.Void InvokeOnAudioSystemShuttingDown() { }
        // RVA: 0x09D9910C  token: 0x6000003
        private static System.Void InvokeOnAudioSystemStartedUp() { }

    }

    // TypeToken: 0x2000004  // size: 0x28
    public sealed class AudioClip : UnityEngine.Object
    {
        // Fields
        private UnityEngine.AudioClip.PCMReaderCallback m_PCMReaderCallback;  // 0x18
        private UnityEngine.AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback;  // 0x20

        // Properties
        System.Single length { get; /* RVA: 0x09D98488 */ }
        System.Int32 samples { get; /* RVA: 0x09D984BC */ }
        System.Int32 frequency { get; /* RVA: 0x09D98454 */ }

        // Methods
        // RVA: 0x09D98424  token: 0x6000009
        private System.Void InvokePCMReaderCallback_Internal(System.Single[] data) { }
        // RVA: 0x09D9843C  token: 0x600000A
        private System.Void InvokePCMSetPositionCallback_Internal(System.Int32 position) { }

    }

    // TypeToken: 0x2000007  // size: 0x18
    public class AudioBehaviour : UnityEngine.Behaviour
    {
        // Methods
        // RVA: 0x0426FE60  token: 0x600000F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000008  // size: 0x18
    public sealed class AudioListener : UnityEngine.AudioBehaviour
    {
    }

    // TypeToken: 0x2000009  // size: 0x18
    public sealed class AudioSource : UnityEngine.AudioBehaviour
    {
        // Properties
        System.Single volume { set; /* RVA: 0x09D9974C */ }
        System.Single pitch { set; /* RVA: 0x09D99678 */ }
        System.Single time { get; /* RVA: 0x09D99534 */ set; /* RVA: 0x09D99708 */ }
        UnityEngine.AudioClip clip { set; /* RVA: 0x09D995AC */ }
        UnityEngine.Audio.AudioMixerGroup outputAudioMixerGroup { set; /* RVA: 0x09D995F0 */ }
        System.Boolean isPlaying { get; /* RVA: 0x09D99500 */ }
        System.Boolean playOnAwake { set; /* RVA: 0x09D99680 */ }
        System.Single panStereo { set; /* RVA: 0x09D99634 */ }
        System.Single spatialBlend { set; /* RVA: 0x09D996C4 */ }
        System.Boolean bypassReverbZones { set; /* RVA: 0x09D99568 */ }

        // Methods
        // RVA: 0x09D9946C  token: 0x6000010
        private static System.Void SetPitch(UnityEngine.AudioSource source, System.Single pitch) { }
        // RVA: 0x09D99320  token: 0x6000011
        private static System.Void PlayHelper(UnityEngine.AudioSource source, System.UInt64 delay) { }
        // RVA: 0x09D99364  token: 0x6000012
        private static System.Void PlayOneShotHelper(UnityEngine.AudioSource source, UnityEngine.AudioClip clip, System.Single volumeScale) { }
        // RVA: 0x09D994BC  token: 0x6000013
        private System.Void Stop(System.Boolean stopOneShots) { }
        // RVA: 0x09D99460  token: 0x600001A
        public System.Void Play() { }
        // RVA: 0x09D993B8  token: 0x600001B
        public System.Void PlayOneShot(UnityEngine.AudioClip clip, System.Single volumeScale) { }
        // RVA: 0x09D994B0  token: 0x600001C
        public System.Void Stop() { }
        // RVA: 0x09D99150  token: 0x600001E
        public static System.Void PlayClipAtPoint(UnityEngine.AudioClip clip, UnityEngine.Vector3 position, System.Single volume) { }
        // RVA: 0x0426FE60  token: 0x6000023
        public System.Void .ctor() { }

    }

}

namespace UnityEngine.Audio
{

    // TypeToken: 0x200000A  // size: 0x20
    public sealed struct AudioClipPlayable : UnityEngine.Playables.IPlayable, System.IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;  // 0x10

        // Methods
        // RVA: 0x09D97C74  token: 0x6000024
        public static UnityEngine.Audio.AudioClipPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AudioClip clip, System.Boolean looping) { }
        // RVA: 0x09D97BAC  token: 0x6000025
        private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AudioClip clip, System.Boolean looping) { }
        // RVA: 0x09D982D4  token: 0x6000026
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        // RVA: 0x03D695A0  token: 0x6000027
        public virtual UnityEngine.Playables.PlayableHandle GetHandle() { }
        // RVA: 0x03D85A00  token: 0x6000028
        public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Audio.AudioClipPlayable playable) { }
        // RVA: 0x09D983AC  token: 0x6000029
        public static UnityEngine.Audio.AudioClipPlayable op_Explicit(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x09D97D88  token: 0x600002A
        public virtual System.Boolean Equals(UnityEngine.Audio.AudioClipPlayable other) { }
        // RVA: 0x09D9822C  token: 0x600002B
        private System.Void SetVolume(System.Single value) { }
        // RVA: 0x09D9813C  token: 0x600002C
        private System.Void SetStereoPan(System.Single value) { }
        // RVA: 0x09D9800C  token: 0x600002D
        private System.Void SetSpatialBlend(System.Single value) { }
        // RVA: 0x09D97E60  token: 0x600002E
        public System.Void Seek(System.Double startTime, System.Double startDelay, System.Double duration) { }
        // RVA: 0x09D981E8  token: 0x600002F
        private static System.Void SetVolumeInternal(UnityEngine.Playables.PlayableHandle& hdl, System.Single volume) { }
        // RVA: 0x09D980F8  token: 0x6000030
        private static System.Void SetStereoPanInternal(UnityEngine.Playables.PlayableHandle& hdl, System.Single stereoPan) { }
        // RVA: 0x09D97FC8  token: 0x6000031
        private static System.Void SetSpatialBlendInternal(UnityEngine.Playables.PlayableHandle& hdl, System.Single spatialBlend) { }
        // RVA: 0x09D980B4  token: 0x6000032
        private static System.Void SetStartDelayInternal(UnityEngine.Playables.PlayableHandle& hdl, System.Double delay) { }
        // RVA: 0x09D97F84  token: 0x6000033
        private static System.Void SetPauseDelayInternal(UnityEngine.Playables.PlayableHandle& hdl, System.Double delay) { }
        // RVA: 0x09D97DFC  token: 0x6000034
        private static System.Boolean InternalCreateAudioClipPlayable(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.AudioClip clip, System.Boolean looping, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x200000B  // size: 0x18
    public class AudioMixer : UnityEngine.Object
    {
        // Methods
        // RVA: 0x09D98B40  token: 0x6000035
        private System.Void .ctor() { }
        // RVA: 0x09D98878  token: 0x6000036
        public UnityEngine.Audio.AudioMixerSnapshot FindSnapshot(System.String name) { }
        // RVA: 0x09D98910  token: 0x6000037
        private System.Void TransitionToSnapshot(UnityEngine.Audio.AudioMixerSnapshot snapshot, System.Single timeToReach) { }
        // RVA: 0x09D988BC  token: 0x6000038
        private System.Void TransitionToSnapshotInternal(UnityEngine.Audio.AudioMixerSnapshot snapshot, System.Single timeToReach) { }

    }

    // TypeToken: 0x200000C  // size: 0x18
    public class AudioMixerGroup : UnityEngine.Object
    {
    }

    // TypeToken: 0x200000D  // size: 0x20
    public sealed struct AudioMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;  // 0x10

        // Methods
        // RVA: 0x09D98618  token: 0x6000039
        public static UnityEngine.Audio.AudioMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount, System.Boolean normalizeInputVolumes) { }
        // RVA: 0x09D98544  token: 0x600003A
        private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount, System.Boolean normalizeInputVolumes) { }
        // RVA: 0x09D986EC  token: 0x600003B
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        // RVA: 0x03D695A0  token: 0x600003C
        public virtual UnityEngine.Playables.PlayableHandle GetHandle() { }
        // RVA: 0x03D85A00  token: 0x600003D
        public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Audio.AudioMixerPlayable playable) { }
        // RVA: 0x09D98678  token: 0x600003E
        public virtual System.Boolean Equals(UnityEngine.Audio.AudioMixerPlayable other) { }
        // RVA: 0x09D984F0  token: 0x600003F
        private static System.Boolean CreateAudioMixerPlayableInternal(UnityEngine.Playables.PlayableGraph& graph, System.Boolean normalizeInputVolumes, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x200000E  // size: 0x18
    public class AudioMixerSnapshot : UnityEngine.Object
    {
        // Properties
        UnityEngine.Audio.AudioMixer audioMixer { get; /* RVA: 0x09D98844 */ }

        // Methods
        // RVA: 0x09D98804  token: 0x6000040
        private System.Void .ctor() { }
        // RVA: 0x09D987C4  token: 0x6000042
        public System.Void TransitionTo(System.Single timeToReach) { }

    }

    // TypeToken: 0x200000F  // size: 0x10
    public static class AudioPlayableBinding
    {
        // Methods
        // RVA: 0x09D98BC0  token: 0x6000043
        public static UnityEngine.Playables.PlayableBinding Create(System.String name, UnityEngine.Object key) { }
        // RVA: 0x09D98B80  token: 0x6000044
        private static UnityEngine.Playables.PlayableOutput CreateAudioOutput(UnityEngine.Playables.PlayableGraph graph, System.String name) { }

    }

    // TypeToken: 0x2000010  // size: 0x10
    public static class AudioPlayableGraphExtensions
    {
        // Methods
        // RVA: 0x09D98CDC  token: 0x6000045
        private static System.Boolean InternalCreateAudioOutput(UnityEngine.Playables.PlayableGraph& graph, System.String name, UnityEngine.Playables.PlayableOutputHandle& handle) { }

    }

    // TypeToken: 0x2000011  // size: 0x20
    public sealed struct AudioPlayableOutput : UnityEngine.Playables.IPlayableOutput
    {
        // Fields
        private UnityEngine.Playables.PlayableOutputHandle m_Handle;  // 0x10

        // Properties
        UnityEngine.Audio.AudioPlayableOutput Null { get; /* RVA: 0x09D98F38 */ }

        // Methods
        // RVA: 0x09D98D30  token: 0x6000046
        public static UnityEngine.Audio.AudioPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, System.String name, UnityEngine.AudioSource target) { }
        // RVA: 0x09D98E60  token: 0x6000047
        private System.Void .ctor(UnityEngine.Playables.PlayableOutputHandle handle) { }
        // RVA: 0x03D695A0  token: 0x6000049
        public virtual UnityEngine.Playables.PlayableOutputHandle GetHandle() { }
        // RVA: 0x03D85A00  token: 0x600004A
        public static UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Audio.AudioPlayableOutput output) { }
        // RVA: 0x09D98FB0  token: 0x600004B
        public static UnityEngine.Audio.AudioPlayableOutput op_Explicit(UnityEngine.Playables.PlayableOutput output) { }
        // RVA: 0x09D98E58  token: 0x600004C
        public System.Void SetTarget(UnityEngine.AudioSource value) { }
        // RVA: 0x09D98E50  token: 0x600004D
        public System.Void SetEvaluateOnSeek(System.Boolean value) { }
        // RVA: 0x09D98E0C  token: 0x600004E
        private static System.Void InternalSetTarget(UnityEngine.Playables.PlayableOutputHandle& output, UnityEngine.AudioSource target) { }
        // RVA: 0x09D98DC8  token: 0x600004F
        private static System.Void InternalSetEvaluateOnSeek(UnityEngine.Playables.PlayableOutputHandle& output, System.Boolean value) { }

    }

}

namespace UnityEngine.Experimental.Audio
{

    // TypeToken: 0x2000012  // size: 0x20
    public class AudioSampleProvider
    {
        // Fields
        private UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesAvailable;  // 0x10
        private UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesOverflow;  // 0x18

        // Methods
        // RVA: 0x09D99028  token: 0x6000050
        private System.Void InvokeSampleFramesAvailable(System.Int32 sampleFrameCount) { }
        // RVA: 0x09D99050  token: 0x6000051
        private System.Void InvokeSampleFramesOverflow(System.Int32 droppedSampleFrameCount) { }

    }

}

