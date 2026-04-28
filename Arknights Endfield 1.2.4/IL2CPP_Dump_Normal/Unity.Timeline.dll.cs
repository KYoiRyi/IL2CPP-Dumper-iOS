// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Timeline.dll
// Classes:  191
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x200001D  // size: 0x14
    public sealed struct PostPlaybackState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.ActivationTrack.PostPlaybackState Active;  // const
        public static UnityEngine.Timeline.ActivationTrack.PostPlaybackState Inactive;  // const
        public static UnityEngine.Timeline.ActivationTrack.PostPlaybackState Revert;  // const
        public static UnityEngine.Timeline.ActivationTrack.PostPlaybackState LeaveAsIs;  // const

    }

    // TypeToken: 0x200001F  // size: 0x38
    public sealed struct WeightInfo
    {
        // Fields
        public UnityEngine.Playables.Playable mixer;  // 0x10
        public UnityEngine.Playables.Playable parentMixer;  // 0x20
        public System.Int32 port;  // 0x30

    }

    // TypeToken: 0x2000021  // size: 0x14
    public sealed struct LoopMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.AnimationPlayableAsset.LoopMode UseSourceAsset;  // const
        public static UnityEngine.Timeline.AnimationPlayableAsset.LoopMode On;  // const
        public static UnityEngine.Timeline.AnimationPlayableAsset.LoopMode Off;  // const

    }

    // TypeToken: 0x2000022  // size: 0x14
    public sealed struct ClothResetOption
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOption SoftReset;  // const
        public static UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOption UseClothRelativeTeleport;  // const
        public static UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOption UseStablizationTime;  // const
        public static UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOption DisablePhysics;  // const

    }

    // TypeToken: 0x2000023  // size: 0x14
    public sealed struct AnimationEventTriggerMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.AnimationPlayableAsset.AnimationEventTriggerMode Default;  // const
        public static UnityEngine.Timeline.AnimationPlayableAsset.AnimationEventTriggerMode MuteAllEvents;  // const
        public static UnityEngine.Timeline.AnimationPlayableAsset.AnimationEventTriggerMode SeekAllEvents;  // const

    }

    // TypeToken: 0x2000024  // size: 0x14
    public sealed struct Versions
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.AnimationPlayableAsset.Versions Initial;  // const
        public static UnityEngine.Timeline.AnimationPlayableAsset.Versions RotationAsEuler;  // const

    }

    // TypeToken: 0x2000025  // size: 0x10
    public static class AnimationPlayableAssetUpgrade
    {
        // Methods
        // RVA: 0x09D20838  token: 0x6000097
        public static System.Void ConvertRotationToEuler(UnityEngine.Timeline.AnimationPlayableAsset asset) { }

    }

    // TypeToken: 0x2000026  // size: 0x48
    public sealed class <get_outputs>d__83 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private UnityEngine.Playables.PlayableBinding <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x38
        public UnityEngine.Timeline.AnimationPlayableAsset <>4__this;  // 0x40

        // Properties
        UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get; /* RVA: 0x03D60DC0 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x09D351D8 */ }

        // Methods
        // RVA: 0x09D343A4  token: 0x6000098
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000099
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09D34C24  token: 0x600009A
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09D3518C  token: 0x600009C
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x09D350F8  token: 0x600009E
        private virtual System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }
        // RVA: 0x09D35184  token: 0x600009F
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200002D  // size: 0x10
    public static class AnimationTrackUpgrade
    {
        // Methods
        // RVA: 0x09D21BE8  token: 0x6000100
        public static System.Void ConvertRotationsToEuler(UnityEngine.Timeline.AnimationTrack track) { }
        // RVA: 0x09D21B80  token: 0x6000101
        public static System.Void ConvertRootMotion(UnityEngine.Timeline.AnimationTrack track) { }
        // RVA: 0x09D21B40  token: 0x6000102
        public static System.Void ConvertInfiniteTrack(UnityEngine.Timeline.AnimationTrack track) { }

    }

    // TypeToken: 0x200002E  // size: 0x48
    public sealed class <get_outputs>d__72 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private UnityEngine.Playables.PlayableBinding <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x38
        public UnityEngine.Timeline.AnimationTrack <>4__this;  // 0x40

        // Properties
        UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get; /* RVA: 0x03D60DC0 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x09D34D84 */ }

        // Methods
        // RVA: 0x09D343A4  token: 0x6000103
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000104
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09D34C24  token: 0x6000105
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09D34D38  token: 0x6000107
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x09D34CA4  token: 0x6000109
        private virtual System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }
        // RVA: 0x09D34D30  token: 0x600010A
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000031  // size: 0x14
    public sealed struct Versions
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.TimelineClip.Versions Initial;  // const
        public static UnityEngine.Timeline.TimelineClip.Versions ClipInFromGlobalToLocal;  // const

    }

    // TypeToken: 0x2000032  // size: 0x10
    public static class TimelineClipUpgrade
    {
        // Methods
        // RVA: 0x09D2C9F0  token: 0x600014E
        public static System.Void UpgradeClipInFromGlobalToLocal(UnityEngine.Timeline.TimelineClip clip) { }

    }

    // TypeToken: 0x2000033  // size: 0x14
    public sealed struct ClipExtrapolation
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.TimelineClip.ClipExtrapolation None;  // const
        public static UnityEngine.Timeline.TimelineClip.ClipExtrapolation Hold;  // const
        public static UnityEngine.Timeline.TimelineClip.ClipExtrapolation Loop;  // const
        public static UnityEngine.Timeline.TimelineClip.ClipExtrapolation PingPong;  // const
        public static UnityEngine.Timeline.TimelineClip.ClipExtrapolation Continue;  // const

    }

    // TypeToken: 0x2000034  // size: 0x14
    public sealed struct BlendCurveMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.TimelineClip.BlendCurveMode Auto;  // const
        public static UnityEngine.Timeline.TimelineClip.BlendCurveMode Manual;  // const

    }

    // TypeToken: 0x2000036  // size: 0x14
    public sealed struct Versions
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.TimelineAsset.Versions Initial;  // const

    }

    // TypeToken: 0x2000037  // size: 0x10
    public static class TimelineAssetUpgrade
    {
    }

    // TypeToken: 0x2000038  // size: 0x14
    public sealed struct MediaType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.TimelineAsset.MediaType Animation;  // const
        public static UnityEngine.Timeline.TimelineAsset.MediaType Audio;  // const
        public static UnityEngine.Timeline.TimelineAsset.MediaType Texture;  // const
        public static UnityEngine.Timeline.TimelineAsset.MediaType Video;  // const
        public static UnityEngine.Timeline.TimelineAsset.MediaType Script;  // const
        public static UnityEngine.Timeline.TimelineAsset.MediaType Hybrid;  // const
        public static UnityEngine.Timeline.TimelineAsset.MediaType Group;  // const

    }

    // TypeToken: 0x2000039  // size: 0x14
    public sealed struct DurationMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.TimelineAsset.DurationMode BasedOnClips;  // const
        public static UnityEngine.Timeline.TimelineAsset.DurationMode FixedLength;  // const

    }

    // TypeToken: 0x200003A  // size: 0x20
    public class EditorSettings
    {
        // Fields
        private static readonly System.Double kMinFrameRate;  // static @ 0x0
        private static readonly System.Double kMaxFrameRate;  // static @ 0x8
        private static readonly System.Double kDefaultFrameRate;  // static @ 0x10
        private System.Double m_Framerate;  // 0x10
        private System.Boolean m_ScenePreview;  // 0x18

        // Properties
        System.Double frameRate { get; /* RVA: 0x03D61CF0 */ set; /* RVA: 0x09D29F64 */ }

        // Methods
        // RVA: 0x03151BE0  token: 0x6000181
        public System.Void .ctor() { }
        // RVA: 0x03CEE6F0  token: 0x6000182
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200003B  // size: 0x58
    public sealed class <get_outputs>d__28 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private UnityEngine.Playables.PlayableBinding <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x38
        public UnityEngine.Timeline.TimelineAsset <>4__this;  // 0x40
        private System.Collections.Generic.IEnumerator<UnityEngine.Timeline.TrackAsset> <>7__wrap1;  // 0x48
        private System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> <>7__wrap2;  // 0x50

        // Properties
        UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get; /* RVA: 0x03D60DC0 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x09D34924 */ }

        // Methods
        // RVA: 0x09D343A4  token: 0x6000183
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x09D34974  token: 0x6000184
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09D343C0  token: 0x6000185
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09D34A60  token: 0x6000186
        private System.Void <>m__Finally1() { }
        // RVA: 0x09D34AA8  token: 0x6000187
        private System.Void <>m__Finally2() { }
        // RVA: 0x09D348D8  token: 0x6000189
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x09D34844  token: 0x600018B
        private virtual System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }
        // RVA: 0x09D348D0  token: 0x600018C
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200003D  // size: 0x14
    public sealed struct Versions
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.TrackAsset.Versions Initial;  // const
        public static UnityEngine.Timeline.TrackAsset.Versions RotationAsEuler;  // const
        public static UnityEngine.Timeline.TrackAsset.Versions RootMotionUpgrade;  // const
        public static UnityEngine.Timeline.TrackAsset.Versions AnimatedTrackProperties;  // const

    }

    // TypeToken: 0x200003E  // size: 0x10
    public static class TrackAssetUpgrade
    {
    }

    // TypeToken: 0x200003F  // size: 0x28
    public sealed struct TransientBuildData
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> trackList;  // 0x10
        public System.Collections.Generic.List<UnityEngine.Timeline.TimelineClip> clipList;  // 0x18
        public System.Collections.Generic.List<UnityEngine.Timeline.IMarker> markerList;  // 0x20

        // Methods
        // RVA: 0x031513A0  token: 0x60001F9
        public static UnityEngine.Timeline.TrackAsset.TransientBuildData Create() { }
        // RVA: 0x09D33EC4  token: 0x60001FA
        public System.Void Clear() { }

    }

    // TypeToken: 0x2000040  // size: 0x48
    public sealed class <get_outputs>d__74 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private UnityEngine.Playables.PlayableBinding <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x38
        public UnityEngine.Timeline.TrackAsset <>4__this;  // 0x40

        // Properties
        UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get; /* RVA: 0x03D60DC0 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x09D350A8 */ }

        // Methods
        // RVA: 0x09D343A4  token: 0x60001FB
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60001FC
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09D34DD4  token: 0x60001FD
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09D3505C  token: 0x60001FF
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x09D34FC8  token: 0x6000201
        private virtual System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }
        // RVA: 0x09D35054  token: 0x6000202
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000041  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly UnityEngine.Timeline.TrackAsset.<>c <>9;  // static @ 0x0
        public static System.Comparison<UnityEngine.Timeline.TimelineClip> <>9__131_0;  // static @ 0x8

        // Methods
        // RVA: 0x09D34190  token: 0x6000203
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000204
        public System.Void .ctor() { }
        // RVA: 0x09D34154  token: 0x6000205
        private System.Int32 <SortClips>b__131_0(UnityEngine.Timeline.TimelineClip clip1, UnityEngine.Timeline.TimelineClip clip2) { }

    }

    // TypeToken: 0x2000049  // size: 0x48
    public sealed class <get_outputs>d__16 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private UnityEngine.Playables.PlayableBinding <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x38
        public UnityEngine.Timeline.AudioPlayableAsset <>4__this;  // 0x40

        // Properties
        UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get; /* RVA: 0x03D60DC0 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x09D34354 */ }

        // Methods
        // RVA: 0x09D343A4  token: 0x6000217
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000218
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09D341F4  token: 0x6000219
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09D34308  token: 0x600021B
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x09D34274  token: 0x600021D
        private virtual System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }
        // RVA: 0x09D34300  token: 0x600021E
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200004B  // size: 0x48
    public sealed class <get_outputs>d__4 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private UnityEngine.Playables.PlayableBinding <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x38
        public UnityEngine.Timeline.AudioTrack <>4__this;  // 0x40

        // Properties
        UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get; /* RVA: 0x03D60DC0 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x09D34BD4 */ }

        // Methods
        // RVA: 0x09D343A4  token: 0x6000224
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000225
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09D341F4  token: 0x6000226
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09D34B88  token: 0x6000228
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x09D34AF4  token: 0x600022A
        private virtual System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }
        // RVA: 0x09D34B80  token: 0x600022B
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000051  // size: 0x14
    public sealed struct DescriptorBlendTreeType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeType Direct;  // const
        public static UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeType Simple1D;  // const
        public static UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeType Simple2D;  // const
        public static UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeType Complex2D;  // const

    }

    // TypeToken: 0x2000059  // size: 0x48
    public sealed class <GetControlableScripts>d__53 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private UnityEngine.MonoBehaviour <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x20
        private UnityEngine.GameObject root;  // 0x28
        public UnityEngine.GameObject <>3__root;  // 0x30
        private UnityEngine.MonoBehaviour[] <>7__wrap1;  // 0x38
        private System.Int32 <>7__wrap2;  // 0x40

        // Properties
        UnityEngine.MonoBehaviour System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x025D6DC0  token: 0x6000267
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000268
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09D33F4C  token: 0x6000269
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09D34108  token: 0x600026B
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x09D3406C  token: 0x600026D
        private virtual System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour> System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour>.GetEnumerator() { }
        // RVA: 0x09D34100  token: 0x600026E
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200005C  // size: 0x38
    public class TransformAdditive
    {
        // Fields
        public UnityEngine.Vector3 position;  // 0x10
        public UnityEngine.Vector3 rotationEuler;  // 0x1c
        public UnityEngine.Vector3 scale;  // 0x28

        // Methods
        // RVA: 0x09D33EBC  token: 0x6000278
        public System.Void .ctor() { }
        // RVA: 0x09D33E5C  token: 0x6000279
        public System.Void Reset() { }
        // RVA: 0x09D33D40  token: 0x600027A
        public System.Boolean HasChanges() { }

    }

    // TypeToken: 0x200005E  // size: 0x38
    public class TransformAdditive
    {
        // Fields
        public UnityEngine.Vector3 position;  // 0x10
        public UnityEngine.Vector3 rotationEular;  // 0x1c
        public UnityEngine.Vector3 scale;  // 0x28

        // Methods
        // RVA: 0x09D33E5C  token: 0x6000280
        public System.Void Reset() { }
        // RVA: 0x0350B670  token: 0x6000281
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000061  // size: 0x28
    public class AnimationCurveInfo
    {
        // Fields
        public System.String path;  // 0x10
        public System.String propertyName;  // 0x18
        public UnityEngine.AnimationCurve curve;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x600028F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000073
    public sealed struct Entry
    {
        // Fields
        public System.Int64 intervalStart;  // 0x0
        public System.Int64 intervalEnd;  // 0x0
        public T item;  // 0x0

    }

    // TypeToken: 0x2000081  // size: 0x20
    public class EventKeyValue
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Timeline.SignalAsset> m_Signals;  // 0x10
        private System.Collections.Generic.List<UnityEngine.Events.UnityEvent> m_Events;  // 0x18

        // Properties
        System.Collections.Generic.List<UnityEngine.Timeline.SignalAsset> signals { get; /* RVA: 0x020B7B20 */ }
        System.Collections.Generic.List<UnityEngine.Events.UnityEvent> events { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x09D381F0  token: 0x600035A
        public System.Boolean TryGetValue(UnityEngine.Timeline.SignalAsset key, UnityEngine.Events.UnityEvent& value) { }
        // RVA: 0x09D38048  token: 0x600035B
        public System.Void Append(UnityEngine.Timeline.SignalAsset key, UnityEngine.Events.UnityEvent value) { }
        // RVA: 0x09D38174  token: 0x600035C
        public System.Void Remove(System.Int32 idx) { }
        // RVA: 0x09D380D0  token: 0x600035D
        public System.Void Remove(UnityEngine.Timeline.SignalAsset key) { }
        // RVA: 0x09D38298  token: 0x6000360
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000088  // size: 0x14
    public sealed struct PostPlaybackState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState Active;  // const
        public static UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState Inactive;  // const
        public static UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState Revert;  // const

    }

    // TypeToken: 0x2000089  // size: 0x14
    public sealed struct InitialState
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.ActivationControlPlayable.InitialState Unset;  // const
        public static UnityEngine.Timeline.ActivationControlPlayable.InitialState Active;  // const
        public static UnityEngine.Timeline.ActivationControlPlayable.InitialState Inactive;  // const

    }

    // TypeToken: 0x2000094  // size: 0x28
    public sealed struct NotificationEntry
    {
        // Fields
        public System.Double time;  // 0x10
        public UnityEngine.Playables.INotification payload;  // 0x18
        public System.Boolean notificationFired;  // 0x20
        public UnityEngine.Timeline.NotificationFlags flags;  // 0x22

        // Properties
        System.Boolean triggerInEditor { get; /* RVA: 0x09D394F4 */ }
        System.Boolean prewarm { get; /* RVA: 0x09D394EC */ }
        System.Boolean triggerOnce { get; /* RVA: 0x09D394FC */ }

    }

    // TypeToken: 0x2000095  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly UnityEngine.Timeline.TimeNotificationBehaviour.<>c <>9;  // static @ 0x0
        public static System.Comparison<UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry> <>9__15_0;  // static @ 0x8

        // Methods
        // RVA: 0x09D46140  token: 0x60003C2
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60003C3
        public System.Void .ctor() { }
        // RVA: 0x09D46088  token: 0x60003C4
        private System.Int32 <SortNotifications>b__15_0(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry x, UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry y) { }

    }

    // TypeToken: 0x20000A4  // size: 0x14
    public sealed struct UseEditMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.TimeFieldAttribute.UseEditMode None;  // const
        public static UnityEngine.Timeline.TimeFieldAttribute.UseEditMode ApplyEditMode;  // const

    }

    // TypeToken: 0x20000AE  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly UnityEngine.Timeline.Extrapolation.<>c <>9;  // static @ 0x0
        public static System.Comparison<UnityEngine.Timeline.TimelineClip> <>9__2_0;  // static @ 0x8

        // Methods
        // RVA: 0x09D461A4  token: 0x6000401
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000402
        public System.Void .ctor() { }
        // RVA: 0x09D34154  token: 0x6000403
        private System.Int32 <SortClipsByStartTime>b__2_0(UnityEngine.Timeline.TimelineClip clip1, UnityEngine.Timeline.TimelineClip clip2) { }

    }

    // TypeToken: 0x20000B6  // size: 0x18
    public sealed class <>c__DisplayClass0_0
    {
        // Fields
        public System.String name;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x600041E
        public System.Void .ctor() { }
        // RVA: 0x09D460A4  token: 0x600041F
        private System.Boolean <GenerateUniqueActorName>b__0(UnityEngine.ScriptableObject x) { }

    }

    // TypeToken: 0x20000B7  // size: 0x18
    public sealed class <>c__DisplayClass0_1
    {
        // Fields
        public System.String result;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000420
        public System.Void .ctor() { }
        // RVA: 0x09D460A4  token: 0x6000421
        private System.Boolean <GenerateUniqueActorName>b__1(UnityEngine.ScriptableObject x) { }

    }

    // TypeToken: 0x20000BC  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly UnityEngine.Timeline.TimeUtility.<>c <>9;  // static @ 0x0

        // Methods
        // RVA: 0x09D460DC  token: 0x600042F
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000430
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000BF  // size: 0x10
    public sealed class <PrivateImplementationDetails>
    {
        // Methods
        // RVA: 0x056516CC  token: 0x6000434
        private static System.UInt32 ComputeStringHash(System.String s) { }

    }

namespace Beyond.Gameplay.Core
{

    // TypeToken: 0x200000F  // size: 0x10
    public class DontAutoBindAttribute : Beyond.Gameplay.Core.DontAutoBindRuntimeAttribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000011
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000010  // size: 0x10
    public class DontAutoBindRuntimeAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000012
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000011  // size: 0x30
    public class BeyondUseAutoBindingPlayableAsset : UnityEngine.Playables.PlayableAsset
    {
        // Fields
        public System.Boolean useAutoBinding;  // 0x18
        public System.String autoBindingPath;  // 0x20
        protected UnityEngine.GameObject m_bindingGo;  // 0x28

        // Properties
        UnityEngine.GameObject bindingGameObject { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }

        // Methods
        // RVA: 0x09D26F30  token: 0x6000015
        public System.Void SetBindingGameObject(UnityEngine.GameObject tBindingGameObject) { }
        // RVA: 0x0350B670  token: 0x6000016
        protected virtual System.Void OnBindGoChanged() { }
        // RVA: 0x09D26EE4  token: 0x6000017
        public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        // RVA: 0x0286F540  token: 0x6000018
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000012  // size: 0x10
    public class RuntimeJumpBehaviour : UnityEngine.Playables.PlayableBehaviour
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000019
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000013  // size: 0x30
    public class RuntimeJumpClip : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
    {
        // Fields
        public System.Boolean isReverseJump;  // 0x18
        public System.Boolean needChangeOptionAfterJump;  // 0x19
        public System.Int32 optionIndexAfterJump;  // 0x1c
        public System.Double crossFadeDurationAfterJump;  // 0x20
        public System.Boolean isJumpFirst;  // 0x28

        // Properties
        UnityEngine.Timeline.ClipCaps clipCaps { get; /* RVA: 0x03D5CA10 */ }

        // Methods
        // RVA: 0x09D29FFC  token: 0x600001B
        public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        // RVA: 0x0286F540  token: 0x600001C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000014  // size: 0xC0
    public class RuntimeJumpTrack : UnityEngine.Timeline.TrackAsset
    {
        // Methods
        // RVA: 0x09D2A094  token: 0x600001D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000015  // size: 0x10
    public class RuntimeLoopBehaviour : UnityEngine.Playables.PlayableBehaviour
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600001E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000016  // size: 0x20
    public class RuntimeLoopClip : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
    {
        // Fields
        public System.Double crossFadeDuration;  // 0x18

        // Properties
        UnityEngine.Timeline.ClipCaps clipCaps { get; /* RVA: 0x03D567A0 */ }

        // Methods
        // RVA: 0x09D2A0E0  token: 0x6000020
        public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        // RVA: 0x0286F540  token: 0x6000021
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000017  // size: 0xC0
    public class RuntimeLoopTrack : UnityEngine.Timeline.TrackAsset
    {
        // Methods
        // RVA: 0x09D2A178  token: 0x6000022
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000018  // size: 0x38
    public class TimelineNPCLookAtController : UnityEngine.MonoBehaviour
    {
        // Fields
        private static readonly System.Collections.Generic.HashSet<Beyond.Gameplay.Core.TimelineNPCLookAtController> s_instances;  // static @ 0x0
        public System.Boolean m_lookAtDirty;  // 0x18
        public ScriptAnimation.TimelineNPCLookAtTarget lookAtTarget;  // 0x20
        public ScriptAnimation.TimelineNPCLookAtEyeTarget lookAtEyeTarget;  // 0x28
        public System.Boolean lookAtEnabled;  // 0x30
        public System.Boolean lookAtEyeEnabled;  // 0x31

        // Properties
        System.Collections.Generic.IEnumerable<Beyond.Gameplay.Core.TimelineNPCLookAtController> Instances { get; /* RVA: 0x09D2E11C */ }
        System.Boolean lookAtDirty { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        System.Single lookAtWeight { get; /* RVA: 0x09D2E67C */ set; /* RVA: 0x09D2EC70 */ }
        System.Single lookAtBodyWeight { get; /* RVA: 0x09D2E2C4 */ set; /* RVA: 0x09D2E8A8 */ }
        System.Single lookAtRoll { get; /* RVA: 0x09D2E518 */ set; /* RVA: 0x09D2EB04 */ }
        System.Single lookAtHorizontal { get; /* RVA: 0x09D2E494 */ set; /* RVA: 0x09D2EA88 */ }
        System.Single lookAtVertical { get; /* RVA: 0x09D2E5F8 */ set; /* RVA: 0x09D2EBF4 */ }
        System.Single lookAtEyeWeight { get; /* RVA: 0x09D2E418 */ set; /* RVA: 0x09D2EA10 */ }
        System.Boolean lookAtUseDegree { get; /* RVA: 0x09D2E58C */ set; /* RVA: 0x09D2EB7C */ }
        System.Boolean EyeUseDegree { get; /* RVA: 0x09D2E0B0 */ set; /* RVA: 0x09D2E6F0 */ }
        System.Single lookAtEyeUp { get; /* RVA: 0x09D2E3A8 */ set; /* RVA: 0x09D2E998 */ }
        System.Single lookAtEyeDown { get; /* RVA: 0x09D2E338 */ set; /* RVA: 0x09D2E920 */ }
        UnityEngine.Vector3 finalPosition { get; /* RVA: 0x09D2E218 */ set; /* RVA: 0x09D2E808 */ }
        UnityEngine.Vector3 finalEyePosition { get; /* RVA: 0x09D2E16C */ set; /* RVA: 0x09D2E768 */ }

        // Methods
        // RVA: 0x09D2DFA4  token: 0x6000024
        private System.Void OnEnable() { }
        // RVA: 0x09D2DF34  token: 0x6000025
        private System.Void OnDisable() { }
        // RVA: 0x0350B670  token: 0x6000040
        public System.Void MarkLookAtDirty() { }
        // RVA: 0x09D2E0A0  token: 0x6000041
        public System.Void .ctor() { }
        // RVA: 0x09D2E014  token: 0x6000042
        private static System.Void .cctor() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x200000A  // size: 0x10
    public static class AnimatorBlackboardUtility
    {
    }

    // TypeToken: 0x200000B  // size: 0x10
    public class AnimatorBlackboardAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600000D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000C  // size: 0x10
    public class DataNAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600000E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000D  // size: 0x10
    public class CameraControlConfigAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600000F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000E  // size: 0x10
    public class ECSComponentAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000010
        public System.Void .ctor() { }

    }

}

namespace Events
{

    // TypeToken: 0x2000008
    public interface INotificationTrack
    {
    }

    // TypeToken: 0x2000009
    public interface ITimelineNotification
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600000C
        public virtual System.Void OnNotify(UnityEngine.Timeline.ITimelineRootMarker root) { }

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

namespace ScriptAnimation
{

    // TypeToken: 0x2000003  // size: 0x38
    public class TimelineNPCClothWeightController : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Boolean forceSetPhysicsClothWeight;  // 0x18
        public System.Single physicsClothWeight;  // 0x1c
        public System.Boolean forceSetPhysicsClothPart1Weight;  // 0x20
        public System.Single physicsClothPart1Weight;  // 0x24
        public System.Boolean forceSetPhysicsClothPart2Weight;  // 0x28
        public System.Single physicsClothPart2Weight;  // 0x2c
        public System.Boolean forceSetLoopBodyAddWeight;  // 0x30
        public System.Single loopBodyAddWeight;  // 0x34

        // Methods
        // RVA: 0x09D2DF10  token: 0x6000002
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x28
    public class TimelineNPCLookAtEyeTarget : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Single lookAtWeight;  // 0x18
        public System.Boolean useDegree;  // 0x1c
        public System.Single lookAtUp;  // 0x20
        public System.Single lookAtDown;  // 0x24

        // Methods
        // RVA: 0x03D65C60  token: 0x6000003
        public System.Void ResetLookAtWeight() { }
        // RVA: 0x0426FE60  token: 0x6000004
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000005  // size: 0x30
    public class TimelineNPCLookAtTarget : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Single lookAtWeight;  // 0x18
        public System.Single lookAtBodyWeight;  // 0x1c
        public System.Boolean useDegree;  // 0x20
        public System.Single lookAtHorizontal;  // 0x24
        public System.Single lookAtVertical;  // 0x28
        public System.Single lookAtRoll;  // 0x2c

        // Methods
        // RVA: 0x03D85650  token: 0x6000005
        public System.Void ResetLookAtWeight() { }
        // RVA: 0x09D2ECE8  token: 0x6000006
        public System.Void .ctor() { }

    }

}

namespace ScriptAnimation.ScriptAnimationApply
{

    // TypeToken: 0x2000006  // size: 0x18
    public class ScriptAnimationApplyBehaviour : UnityEngine.Playables.PlayableBehaviour
    {
        // Fields
        private UnityEngine.Timeline.IScriptAnimationJobSync m_JobSync;  // 0x10

        // Methods
        // RVA: 0x09D2A1C4  token: 0x6000007
        public virtual System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x0426FEE0  token: 0x6000008
        public System.Void InitBehaviour(UnityEngine.Timeline.IScriptAnimationJobSync jobSync) { }
        // RVA: 0x0350B670  token: 0x6000009
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000007  // size: 0x18
    public class ScriptAnimationApplyPlayable : UnityEngine.Playables.PlayableAsset
    {
        // Methods
        // RVA: 0x09D2A234  token: 0x600000A
        public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        // RVA: 0x0286F540  token: 0x600000B
        public System.Void .ctor() { }

    }

}

namespace UnityEngine
{

    // TypeToken: 0x2000019  // size: 0x10
    public static class PlayerLoopChecker
    {
    }

}

namespace UnityEngine.Timeline
{

    // TypeToken: 0x200001A  // size: 0x20
    public class ActivationMixerPlayable : UnityEngine.Playables.PlayableBehaviour
    {
        // Fields
        private UnityEngine.Timeline.ActivationTrack.PostPlaybackState m_PostPlaybackState;  // 0x10
        private System.Boolean m_BoundGameObjectInitialStateIsActive;  // 0x14
        private UnityEngine.GameObject m_BoundGameObject;  // 0x18

        // Properties
        UnityEngine.Timeline.ActivationTrack.PostPlaybackState postPlaybackState { set; /* RVA: 0x010410F0 */ }

        // Methods
        // RVA: 0x09D1DF24  token: 0x6000043
        public static UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.ActivationMixerPlayable> Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        // RVA: 0x09D1E1A8  token: 0x6000045
        public System.Void SetBoundGameObject(UnityEngine.GameObject go) { }
        // RVA: 0x0350B670  token: 0x6000046
        public virtual System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x09D1DFB0  token: 0x6000047
        public virtual System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D1E0C8  token: 0x6000048
        public virtual System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        // RVA: 0x09D1DFF4  token: 0x6000049
        public virtual System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D1E238  token: 0x600004A
        private System.Void _DoSetActive(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        // RVA: 0x0350B670  token: 0x600004B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001B  // size: 0x18
    public class ActivationPlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
    {
        // Properties
        UnityEngine.Timeline.ClipCaps clipCaps { get; /* RVA: 0x01002730 */ }

        // Methods
        // RVA: 0x09D1E3BC  token: 0x600004D
        public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go) { }
        // RVA: 0x0286F540  token: 0x600004E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001C  // size: 0xD0
    public class ActivationTrack : UnityEngine.Timeline.TrackAsset
    {
        // Fields
        private UnityEngine.Timeline.ActivationTrack.PostPlaybackState m_PostPlaybackState;  // 0xc0
        private UnityEngine.Timeline.ActivationMixerPlayable m_ActivationMixer;  // 0xc8

        // Properties
        UnityEngine.Timeline.ActivationTrack.PostPlaybackState postPlaybackState { get; /* RVA: 0x03D57EF0 */ set; /* RVA: 0x09D1E7F4 */ }

        // Methods
        // RVA: 0x09D1E428  token: 0x600004F
        private virtual System.Boolean CanCompileClips() { }
        // RVA: 0x09D1E458  token: 0x6000052
        public virtual UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount) { }
        // RVA: 0x09D1E688  token: 0x6000053
        private UnityEngine.GameObject GetBinding(UnityEngine.Playables.PlayableDirector director) { }
        // RVA: 0x09D1E7D8  token: 0x6000054
        private System.Void UpdateTrackMode() { }
        // RVA: 0x09D1E5E8  token: 0x6000055
        public virtual System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }
        // RVA: 0x09D1E788  token: 0x6000056
        protected virtual System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip) { }
        // RVA: 0x031514D0  token: 0x6000057
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001E  // size: 0x30
    public class AnimationOutputWeightProcessor : UnityEngine.Timeline.ITimelineEvaluateCallback
    {
        // Fields
        private UnityEngine.Animator m_outputAnimator;  // 0x10
        private UnityEngine.Animations.AnimationPlayableOutput m_Output;  // 0x18
        private readonly System.Collections.Generic.List<UnityEngine.Timeline.AnimationOutputWeightProcessor.WeightInfo> m_Mixers;  // 0x28

        // Methods
        // RVA: 0x09D20768  token: 0x6000058
        public System.Void .ctor(UnityEngine.Animations.AnimationPlayableOutput output, UnityEngine.Animator animator) { }
        // RVA: 0x09D203A0  token: 0x6000059
        private System.Void FindMixers() { }
        // RVA: 0x09D20494  token: 0x600005A
        private System.Void FindMixers(UnityEngine.Playables.Playable parent, System.Int32 port, UnityEngine.Playables.Playable node) { }
        // RVA: 0x09D201A4  token: 0x600005B
        public virtual System.Void Evaluate() { }

    }

    // TypeToken: 0x2000020  // size: 0x90
    public class AnimationPlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset, UnityEngine.Timeline.IPropertyPreview, UnityEngine.ISerializationCallbackReceiver
    {
        // Fields
        private UnityEngine.AnimationClip m_Clip;  // 0x18
        private UnityEngine.Vector3 m_Position;  // 0x20
        private UnityEngine.Vector3 m_EulerAngles;  // 0x2c
        private System.Boolean m_UseTrackMatchFields;  // 0x38
        private UnityEngine.Timeline.MatchTargetFields m_MatchTargetFields;  // 0x3c
        private System.Boolean m_RemoveStartOffset;  // 0x40
        private System.Boolean m_ApplyFootIK;  // 0x41
        private UnityEngine.Timeline.AnimationPlayableAsset.LoopMode m_Loop;  // 0x44
        private System.Boolean m_IgniteOnce;  // 0x48
        private System.Boolean m_OnlyDeltaTime;  // 0x49
        private System.Boolean m_DynamicLink;  // 0x4a
        private UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOption m_ClothResetOption;  // 0x4c
        private UnityEngine.Timeline.AnimationPlayableAsset.AnimationEventTriggerMode m_AnimationEventTriggerMode;  // 0x50
        private System.Boolean m_MixWitherAnotherClip;  // 0x54
        private System.Single m_MainClipMixWeight;  // 0x58
        private UnityEngine.AnimationClip m_AnotherClip;  // 0x60
        private UnityEngine.Timeline.AppliedOffsetMode <appliedOffsetMode>k__BackingField;  // 0x68
        private UnityEngine.Timeline.ITimelineAnimationEventContextBinding <TimelineAnimationEventContextBinding>k__BackingField;  // 0x70
        private static readonly System.Int32 k_LatestVersion;  // static @ 0x0
        private System.Int32 m_Version;  // 0x78
        private UnityEngine.Quaternion m_Rotation;  // 0x7c

        // Properties
        UnityEngine.Vector3 position { get; /* RVA: 0x03D59660 */ set; /* RVA: 0x03D5AE00 */ }
        UnityEngine.Quaternion rotation { get; /* RVA: 0x09D21A38 */ set; /* RVA: 0x09D21B18 */ }
        UnityEngine.Vector3 eulerAngles { get; /* RVA: 0x03D59800 */ set; /* RVA: 0x03D5BF30 */ }
        System.Boolean useTrackMatchFields { get; /* RVA: 0x03D4F190 */ set; /* RVA: 0x03D4E280 */ }
        UnityEngine.Timeline.MatchTargetFields matchTargetFields { get; /* RVA: 0x03D4ED90 */ set; /* RVA: 0x03D4EDC0 */ }
        System.Boolean removeStartOffset { get; /* RVA: 0x03D4EE90 */ set; /* RVA: 0x03D4EEB0 */ }
        System.Boolean applyFootIK { get; /* RVA: 0x03D4F7B0 */ set; /* RVA: 0x03D4F7D0 */ }
        UnityEngine.Timeline.AnimationPlayableAsset.LoopMode loop { get; /* RVA: 0x03D4EE80 */ set; /* RVA: 0x03D4EEA0 */ }
        System.Boolean IgniteOnce { get; /* RVA: 0x03D4EFE0 */ set; /* RVA: 0x03D4F010 */ }
        System.Boolean OnlyDeltaTime { get; /* RVA: 0x03D4EFF0 */ set; /* RVA: 0x03D4F020 */ }
        System.Boolean DynamicLink { get; /* RVA: 0x03D4F780 */ set; /* RVA: 0x03D4F790 */ }
        System.Boolean MixWithAnotherClip { get; /* RVA: 0x03D4F320 */ set; /* RVA: 0x03D4F350 */ }
        UnityEngine.AnimationClip AnotherClip { get; /* RVA: 0x03D4EB00 */ set; /* RVA: 0x039274B0 */ }
        System.Single MainClipMixWeight { get; /* RVA: 0x03D51080 */ set; /* RVA: 0x03D510B0 */ }
        System.Boolean hasRootTransforms { get; /* RVA: 0x09D21948 */ }
        UnityEngine.Timeline.AppliedOffsetMode appliedOffsetMode { get; /* RVA: 0x03D4EEE0 */ set; /* RVA: 0x03D4EF30 */ }
        UnityEngine.Timeline.ITimelineAnimationEventContextBinding TimelineAnimationEventContextBinding { get; /* RVA: 0x03D4EB30 */ set; /* RVA: 0x0519C3C8 */ }
        UnityEngine.AnimationClip clip { get; /* RVA: 0x01041090 */ set; /* RVA: 0x09D21A74 */ }
        System.Double duration { get; /* RVA: 0x09D218E0 */ }
        UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOption clothResetOption { get; /* RVA: 0x03D4EDF0 */ set; /* RVA: 0x03D4EE30 */ }
        UnityEngine.Timeline.AnimationPlayableAsset.AnimationEventTriggerMode animationEventTriggerMode { get; /* RVA: 0x03D4EED0 */ set; /* RVA: 0x03D4EF20 */ }
        System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> outputs { get; /* RVA: 0x09D219C8 */ }
        UnityEngine.Timeline.ClipCaps clipCaps { get; /* RVA: 0x09D217F0 */ }

        // Methods
        // RVA: 0x09D211EC  token: 0x6000085
        public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go) { }
        // RVA: 0x09D20ED4  token: 0x6000086
        private static UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, UnityEngine.Vector3 positionOffset, UnityEngine.Vector3 eulerOffset, System.Boolean removeStartOffset, UnityEngine.Timeline.AppliedOffsetMode mode, System.Boolean applyFootIK, UnityEngine.Timeline.AnimationPlayableAsset.LoopMode loop) { }
        // RVA: 0x09D20914  token: 0x6000087
        private static UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.AnimationPlayableAsset playableAsset) { }
        // RVA: 0x09D20890  token: 0x6000088
        private static UnityEngine.Animations.AnimationClipPlayable CreateAnimationClipPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, System.Boolean removeStartOffset, System.Boolean applyFootIK, UnityEngine.Timeline.AnimationPlayableAsset.LoopMode loop) { }
        // RVA: 0x09D213F0  token: 0x6000089
        private static System.Boolean ShouldApplyOffset(UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.AnimationClip clip) { }
        // RVA: 0x09D21388  token: 0x600008A
        private static System.Boolean ShouldApplyEventControl(UnityEngine.Timeline.AnimationPlayableAsset playableAsset) { }
        // RVA: 0x09D21460  token: 0x600008B
        private static UnityEngine.Playables.Playable TryApplyAnimationEventControl(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable root, UnityEngine.Timeline.AnimationPlayableAsset playableAsset) { }
        // RVA: 0x09D2144C  token: 0x600008C
        private static System.Boolean ShouldApplyScaleRemove(UnityEngine.Timeline.AppliedOffsetMode mode) { }
        // RVA: 0x09D21364  token: 0x600008E
        public System.Void ResetOffsets() { }
        // RVA: 0x09D21264  token: 0x600008F
        public virtual System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }
        // RVA: 0x09D212B4  token: 0x6000090
        private static System.Boolean HasRootTransforms(UnityEngine.AnimationClip clip) { }
        // RVA: 0x09D20870  token: 0x6000091
        public UnityEngine.AnimationEvent[] CollectAnimationEvents() { }
        // RVA: 0x09D216B0  token: 0x6000092
        private virtual System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        // RVA: 0x09D2164C  token: 0x6000093
        private virtual System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        // RVA: 0x09D21354  token: 0x6000094
        private System.Void OnUpgradeFromVersion(System.Int32 oldVersion) { }
        // RVA: 0x09D21744  token: 0x6000095
        public System.Void .ctor() { }
        // RVA: 0x09D21708  token: 0x6000096
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000027  // size: 0x10
    public class AnimationPreviewUpdateCallback
    {
    }

    // TypeToken: 0x2000028  // size: 0x14
    public sealed struct MatchTargetFields
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.MatchTargetFields PositionX;  // const
        public static UnityEngine.Timeline.MatchTargetFields PositionY;  // const
        public static UnityEngine.Timeline.MatchTargetFields PositionZ;  // const
        public static UnityEngine.Timeline.MatchTargetFields RotationX;  // const
        public static UnityEngine.Timeline.MatchTargetFields RotationY;  // const
        public static UnityEngine.Timeline.MatchTargetFields RotationZ;  // const

    }

    // TypeToken: 0x2000029  // size: 0x14
    public sealed struct TrackOffset
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.TrackOffset ApplyTransformOffsets;  // const
        public static UnityEngine.Timeline.TrackOffset ApplySceneOffsets;  // const
        public static UnityEngine.Timeline.TrackOffset Auto;  // const

    }

    // TypeToken: 0x200002A  // size: 0x14
    public sealed struct AppliedOffsetMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.AppliedOffsetMode NoRootTransform;  // const
        public static UnityEngine.Timeline.AppliedOffsetMode TransformOffset;  // const
        public static UnityEngine.Timeline.AppliedOffsetMode SceneOffset;  // const
        public static UnityEngine.Timeline.AppliedOffsetMode TransformOffsetLegacy;  // const
        public static UnityEngine.Timeline.AppliedOffsetMode SceneOffsetLegacy;  // const
        public static UnityEngine.Timeline.AppliedOffsetMode SceneOffsetEditor;  // const
        public static UnityEngine.Timeline.AppliedOffsetMode SceneOffsetLegacyEditor;  // const

    }

    // TypeToken: 0x200002B  // size: 0x10
    public static class MatchTargetFieldConstants
    {
        // Fields
        public static UnityEngine.Timeline.MatchTargetFields All;  // static @ 0x0
        public static UnityEngine.Timeline.MatchTargetFields None;  // static @ 0x4
        public static UnityEngine.Timeline.MatchTargetFields Position;  // static @ 0x8
        public static UnityEngine.Timeline.MatchTargetFields Rotation;  // static @ 0xc

        // Methods
        // RVA: 0x09D29F84  token: 0x60000A0
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200002C  // size: 0x188
    public class AnimationTrack : UnityEngine.Timeline.TrackAsset, UnityEngine.Timeline.ILayerable
    {
        // Fields
        private static System.String k_DefaultInfiniteClipName;  // const
        private static System.String k_DefaultRecordableClipName;  // const
        private UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation;  // 0xc0
        private UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation;  // 0xc4
        private UnityEngine.Vector3 m_InfiniteClipOffsetPosition;  // 0xc8
        private UnityEngine.Vector3 m_InfiniteClipOffsetEulerAngles;  // 0xd4
        private System.Double m_InfiniteClipTimeOffset;  // 0xe0
        private System.Boolean m_InfiniteClipRemoveOffset;  // 0xe8
        private System.Boolean m_InfiniteClipApplyFootIK;  // 0xe9
        private UnityEngine.Timeline.AnimationPlayableAsset.LoopMode mInfiniteClipLoop;  // 0xec
        private UnityEngine.Timeline.MatchTargetFields m_MatchTargetFields;  // 0xf0
        private UnityEngine.Vector3 m_Position;  // 0xf4
        private UnityEngine.Vector3 m_EulerAngles;  // 0x100
        private UnityEngine.AvatarMask m_AvatarMask;  // 0x110
        private System.Boolean m_ApplyAvatarMask;  // 0x118
        private System.Boolean m_DisableFloatCurveOnMask;  // 0x119
        private UnityEngine.Timeline.TrackOffset m_TrackOffset;  // 0x11c
        private UnityEngine.AnimationClip m_InfiniteClip;  // 0x120
        private System.Boolean m_IsAdditive;  // 0x128
        private System.Boolean m_IsAdditiveToLast;  // 0x129
        public System.Boolean muteScriptAnimAddon;  // 0x12a
        private System.Boolean m_UseScriptAnimAddon;  // 0x12b
        private System.Boolean m_useTPoseAsDefaultPose;  // 0x12c
        private UnityEngine.AnimationClip m_TPoseClip;  // 0x130
        private UnityEngine.ScriptableObject m_TimelineNPCDescriptor;  // 0x138
        private System.String m_LookAtTargetPath;  // 0x140
        private System.Boolean m_LookAtUseAdditive;  // 0x148
        private System.Boolean m_WriteTransformDefAsPostProcess;  // 0x149
        private UnityEngine.Transform m_LookAtTarget;  // 0x150
        private System.Collections.Generic.HashSet<UnityEngine.Timeline.RuntimeElement> m_allRuntimeClipUnderTrack;  // 0x158
        private static readonly System.Collections.Generic.Queue<UnityEngine.Transform> s_CachedQueue;  // static @ 0x0
        private UnityEngine.Quaternion m_OpenClipOffsetRotation;  // 0x160
        private UnityEngine.Quaternion m_Rotation;  // 0x170
        private System.Boolean m_ApplyOffsets;  // 0x180

        // Properties
        UnityEngine.Vector3 position { get; /* RVA: 0x03D85530 */ set; /* RVA: 0x03D855F0 */ }
        UnityEngine.Quaternion rotation { get; /* RVA: 0x09D26038 */ set; /* RVA: 0x09D26124 */ }
        UnityEngine.Vector3 eulerAngles { get; /* RVA: 0x03D854C0 */ set; /* RVA: 0x03D85560 */ }
        System.Boolean applyOffsets { get; /* RVA: 0x0115F4C0 */ set; /* RVA: 0x0350B670 */ }
        UnityEngine.Timeline.TrackOffset trackOffset { get; /* RVA: 0x03D5D760 */ set; /* RVA: 0x03D5D770 */ }
        UnityEngine.Timeline.MatchTargetFields matchTargetFields { get; /* RVA: 0x03D50F00 */ set; /* RVA: 0x09D260A8 */ }
        UnityEngine.AnimationClip infiniteClip { get; /* RVA: 0x03D56D50 */ set; /* RVA: 0x04275CA4 */ }
        System.Boolean infiniteClipRemoveOffset { get; /* RVA: 0x03D554A0 */ set; /* RVA: 0x03D554D0 */ }
        UnityEngine.AvatarMask avatarMask { get; /* RVA: 0x03D56CF0 */ set; /* RVA: 0x04275CF4 */ }
        System.Boolean applyAvatarMask { get; /* RVA: 0x03D57B90 */ set; /* RVA: 0x03D5E110 */ }
        System.Boolean disableFloatCurveOnMask { get; /* RVA: 0x03D854B0 */ set; /* RVA: 0x03D85550 */ }
        System.Boolean isUsingScriptAnimAddon { get; /* RVA: 0x03D85520 */ set; /* RVA: 0x03D855E0 */ }
        System.Boolean lookAtUseAdditive { get; /* RVA: 0x03D57CB0 */ set; /* RVA: 0x03D5A1F0 */ }
        System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> outputs { get; /* RVA: 0x09D25FC8 */ }
        System.Boolean inClipMode { get; /* RVA: 0x09D25F18 */ }
        UnityEngine.Vector3 infiniteClipOffsetPosition { get; /* RVA: 0x03D85500 */ set; /* RVA: 0x03D855B0 */ }
        UnityEngine.Quaternion infiniteClipOffsetRotation { get; /* RVA: 0x09D25F60 */ set; /* RVA: 0x09D26078 */ }
        UnityEngine.Vector3 infiniteClipOffsetEulerAngles { get; /* RVA: 0x03D854E0 */ set; /* RVA: 0x03D85590 */ }
        System.Boolean infiniteClipApplyFootIK { get; /* RVA: 0x03D58EB0 */ set; /* RVA: 0x03D85580 */ }
        System.Double infiniteClipTimeOffset { get; /* RVA: 0x03D6B260 */ set; /* RVA: 0x03D855D0 */ }
        UnityEngine.Timeline.TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation { get; /* RVA: 0x03D57EF0 */ set; /* RVA: 0x03D57F70 */ }
        UnityEngine.Timeline.TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation { get; /* RVA: 0x03D68ED0 */ set; /* RVA: 0x03D68F40 */ }
        UnityEngine.Timeline.AnimationPlayableAsset.LoopMode infiniteClipLoop { get; /* RVA: 0x03D58150 */ set; /* RVA: 0x03D68F50 */ }
        UnityEngine.Vector3 openClipOffsetPosition { get; /* RVA: 0x03D85500 */ set; /* RVA: 0x03D855B0 */ }
        UnityEngine.Quaternion openClipOffsetRotation { get; /* RVA: 0x09D25FA0 */ set; /* RVA: 0x09D26104 */ }
        UnityEngine.Vector3 openClipOffsetEulerAngles { get; /* RVA: 0x03D854E0 */ set; /* RVA: 0x03D85590 */ }
        UnityEngine.Timeline.TimelineClip.ClipExtrapolation openClipPreExtrapolation { get; /* RVA: 0x03D57EF0 */ set; /* RVA: 0x03D57F70 */ }
        UnityEngine.Timeline.TimelineClip.ClipExtrapolation openClipPostExtrapolation { get; /* RVA: 0x03D68ED0 */ set; /* RVA: 0x03D68F40 */ }

        // Methods
        // RVA: 0x09D2559C  token: 0x60000BB
        public System.Boolean IsControlByThisTrack(UnityEngine.Timeline.RuntimeElement element) { }
        // RVA: 0x09D22EB8  token: 0x60000BC
        private virtual System.Boolean CanCompileClips() { }
        // RVA: 0x09D25A00  token: 0x60000CF
        private System.Void ResetOffsets() { }
        // RVA: 0x09D2379C  token: 0x60000D0
        public UnityEngine.Timeline.TimelineClip CreateClip(UnityEngine.AnimationClip clip) { }
        // RVA: 0x09D238A8  token: 0x60000D1
        public System.Void CreateInfiniteClip(System.String infiniteClipName) { }
        // RVA: 0x09D24A20  token: 0x60000D2
        public UnityEngine.Timeline.TimelineClip CreateRecordableClip(System.String animClipName) { }
        // RVA: 0x09D258A4  token: 0x60000D3
        protected virtual System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip) { }
        // RVA: 0x09D22E44  token: 0x60000D4
        protected internal virtual System.Int32 CalculateItemsHash() { }
        // RVA: 0x0350B670  token: 0x60000D5
        private System.Void UpdateClipOffsets() { }
        // RVA: 0x09D25B9C  token: 0x60000D6
        private UnityEngine.Playables.Playable _CreatePlayableFromClip(UnityEngine.Timeline.TimelineClip c, UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.Timeline.ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding) { }
        // RVA: 0x09D22F6C  token: 0x60000D7
        private UnityEngine.Playables.Playable CompileTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.AnimationTrack track, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.Timeline.ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding) { }
        // RVA: 0x09D25A30  token: 0x60000D8
        private System.Boolean ShouldLinkWithMainTrackMixer(UnityEngine.Timeline.AnimationTrack animationTrack) { }
        // RVA: 0x09D220A0  token: 0x60000D9
        private UnityEngine.Playables.Playable ApplyScriptAnimationPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable mixer, UnityEngine.GameObject go) { }
        // RVA: 0x09D25AB4  token: 0x60000DA
        private virtual UnityEngine.Playables.Playable UnityEngine.Timeline.ILayerable.CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount) { }
        // RVA: 0x09D23CFC  token: 0x60000DB
        private virtual UnityEngine.Playables.Playable CreateMixerPlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree) { }
        // RVA: 0x0350B670  token: 0x60000DC
        private System.Void AttachCustomBlend(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable layerMixer) { }
        // RVA: 0x09D228B8  token: 0x60000DD
        private System.Void AttachLastAdditiveClip(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable layerMixer, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, System.Collections.Generic.List<UnityEngine.Timeline.AnimationTrack> flattenTracks, UnityEngine.Timeline.ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding) { }
        // RVA: 0x01168950  token: 0x60000DE
        private System.Int32 GetDefaultBlendCount() { }
        // RVA: 0x0350B670  token: 0x60000DF
        private System.Void AttachDefaultBlend(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable mixer, System.Boolean requireOffset, UnityEngine.Animator animator) { }
        // RVA: 0x09D22D0C  token: 0x60000E0
        private UnityEngine.Playables.Playable AttachOffsetPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable playable, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        // RVA: 0x09D2591C  token: 0x60000E1
        private System.Boolean RequiresMotionXPlayable(UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.GameObject gameObject) { }
        // RVA: 0x09D25B04  token: 0x60000E2
        private static System.Boolean UsesAbsoluteMotion(UnityEngine.Timeline.AppliedOffsetMode mode) { }
        // RVA: 0x09D254BC  token: 0x60000E3
        private System.Boolean HasController(UnityEngine.GameObject gameObject) { }
        // RVA: 0x09D24FDC  token: 0x60000E4
        private UnityEngine.Animator GetBinding(UnityEngine.Playables.PlayableDirector director) { }
        // RVA: 0x09D23830  token: 0x60000E5
        private static UnityEngine.Animations.AnimationLayerMixerPlayable CreateGroupMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount) { }
        // RVA: 0x09D23994  token: 0x60000E6
        private UnityEngine.Playables.Playable CreateInfiniteTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.AppliedOffsetMode mode) { }
        // RVA: 0x09D22550  token: 0x60000E7
        private UnityEngine.Playables.Playable ApplyTrackOffset(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable root, UnityEngine.GameObject go, UnityEngine.Timeline.AppliedOffsetMode mode) { }
        // RVA: 0x09D25B14  token: 0x60000E8
        private System.Void _AddClipIntoTree(UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.RuntimeClip clip) { }
        // RVA: 0x09D25154  token: 0x60000E9
        private virtual System.Void GetEvaluationTime(System.Double& outStart, System.Double& outDuration) { }
        // RVA: 0x09D253EC  token: 0x60000EA
        private virtual System.Void GetSequenceTime(System.Double& outStart, System.Double& outDuration) { }
        // RVA: 0x09D226D4  token: 0x60000EB
        private System.Void AssignAnimationClip(UnityEngine.Timeline.TimelineClip clip, UnityEngine.AnimationClip animClip) { }
        // RVA: 0x0350B670  token: 0x60000EC
        public virtual System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }
        // RVA: 0x09D24CEC  token: 0x60000ED
        private System.Void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> animClips) { }
        // RVA: 0x09D25388  token: 0x60000EE
        private UnityEngine.Timeline.AppliedOffsetMode GetOffsetMode(UnityEngine.GameObject go, System.Boolean animatesRootTransform) { }
        // RVA: 0x09D255F8  token: 0x60000EF
        private System.Boolean IsRootTransformDisabledByMask(UnityEngine.GameObject gameObject, UnityEngine.Transform genericRootNode) { }
        // RVA: 0x09D251E0  token: 0x60000F0
        private UnityEngine.Transform GetGenericRootNode(UnityEngine.GameObject gameObject) { }
        // RVA: 0x09D21C50  token: 0x60000F1
        private System.Boolean AnimatesRootTransform() { }
        // RVA: 0x09D24B2C  token: 0x60000F2
        private static UnityEngine.Transform FindInHierarchyBreadthFirst(UnityEngine.Transform t, System.String name) { }
        // RVA: 0x09D258DC  token: 0x60000FD
        private virtual System.Void OnUpgradeFromVersion(System.Int32 oldVersion) { }
        // RVA: 0x09D25D94  token: 0x60000FE
        public System.Void .ctor() { }
        // RVA: 0x09D25D00  token: 0x60000FF
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200002F
    public interface ICurvesOwner
    {
        // Properties
        System.String defaultCurvesName { get; /* RVA: -1  // abstract */ }
        UnityEngine.Object asset { get; /* RVA: -1  // abstract */ }
        UnityEngine.Object assetOwner { get; /* RVA: -1  // abstract */ }
        UnityEngine.Timeline.TrackAsset targetTrack { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000030  // size: 0xB8
    public class TimelineClip : UnityEngine.Timeline.ICurvesOwner, UnityEngine.ISerializationCallbackReceiver
    {
        // Fields
        private static System.Int32 k_LatestVersion;  // const
        private System.Int32 m_Version;  // 0x10
        public static readonly UnityEngine.Timeline.ClipCaps kDefaultClipCaps;  // static @ 0x0
        public static readonly System.Single kDefaultClipDurationInSeconds;  // static @ 0x4
        public static readonly System.Double kTimeScaleMin;  // static @ 0x8
        public static readonly System.Double kTimeScaleMax;  // static @ 0x10
        private static readonly System.String kDefaultCurvesName;  // static @ 0x18
        private static readonly System.Double kMinDuration;  // static @ 0x20
        private static readonly System.Double kMaxTimeValue;  // static @ 0x28
        public System.Int32 optionIndex;  // 0x14
        private System.Double m_Start;  // 0x18
        private System.Double m_ClipIn;  // 0x20
        private UnityEngine.Object m_Asset;  // 0x28
        private System.Double m_Duration;  // 0x30
        private System.Double m_TimeScale;  // 0x38
        private UnityEngine.Timeline.TrackAsset m_ParentTrack;  // 0x40
        private System.Double m_EaseInDuration;  // 0x48
        private System.Double m_EaseOutDuration;  // 0x50
        private System.Double m_BlendInDuration;  // 0x58
        private System.Double m_BlendOutDuration;  // 0x60
        private UnityEngine.AnimationCurve m_MixInCurve;  // 0x68
        private UnityEngine.AnimationCurve m_MixOutCurve;  // 0x70
        private UnityEngine.Timeline.TimelineClip.BlendCurveMode m_BlendInCurveMode;  // 0x78
        private UnityEngine.Timeline.TimelineClip.BlendCurveMode m_BlendOutCurveMode;  // 0x7c
        private System.Collections.Generic.List<System.String> m_ExposedParameterNames;  // 0x80
        private UnityEngine.AnimationClip m_AnimationCurves;  // 0x88
        private System.Boolean m_Recordable;  // 0x90
        private UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_PostExtrapolationMode;  // 0x94
        private UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_PreExtrapolationMode;  // 0x98
        private System.Double m_PostExtrapolationTime;  // 0xa0
        private System.Double m_PreExtrapolationTime;  // 0xa8
        private System.String m_DisplayName;  // 0xb0

        // Properties
        System.Double timeScale { get; /* RVA: 0x09D2DA8C */ }
        System.Double start { get; /* RVA: 0x03D4EBD0 */ set; /* RVA: 0x09D2DE24 */ }
        System.Double duration { get; /* RVA: 0x03D4F240 */ set; /* RVA: 0x09D2DB50 */ }
        System.Double end { get; /* RVA: 0x03D85640 */ }
        System.Double clipIn { get; /* RVA: 0x09D2D658 */ }
        System.String displayName { get; /* RVA: 0x03D4EAD0 */ set; /* RVA: 0x02B47080 */ }
        System.Double clipAssetDuration { get; /* RVA: 0x09D2D588 */ }
        UnityEngine.AnimationClip curves { get; /* RVA: 0x03D4EA60 */ }
        System.String UnityEngine.Timeline.ICurvesOwner.defaultCurvesName { get; /* RVA: 0x09D2D4B8 */ }
        UnityEngine.Object asset { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }
        UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.assetOwner { get; /* RVA: 0x03D4E2B0 */ }
        UnityEngine.Timeline.TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack { get; /* RVA: 0x03D4E2B0 */ }
        System.Double easeInDuration { get; /* RVA: 0x09D2D67C */ set; /* RVA: 0x09D2DBE4 */ }
        System.Double easeOutDuration { get; /* RVA: 0x09D2D710 */ set; /* RVA: 0x09D2DCC8 */ }
        System.Double blendInDuration { get; /* RVA: 0x09D2D540 */ }
        System.Double blendOutDuration { get; /* RVA: 0x09D2D564 */ }
        System.Boolean hasBlendIn { get; /* RVA: 0x09D2D880 */ }
        System.Boolean hasBlendOut { get; /* RVA: 0x09D2D8B0 */ }
        UnityEngine.AnimationCurve mixInCurve { get; /* RVA: 0x09D2D8E0 */ set; /* RVA: 0x038C5570 */ }
        System.Double mixInDuration { get; /* RVA: 0x09D2D948 */ }
        UnityEngine.AnimationCurve mixOutCurve { get; /* RVA: 0x09D2D978 */ set; /* RVA: 0x0519C3C8 */ }
        System.Double mixOutTime { get; /* RVA: 0x09D2DA10 */ }
        System.Double mixOutDuration { get; /* RVA: 0x09D2D9E0 */ }
        System.Boolean recordable { get; /* RVA: 0x03D58A70 */ set; /* RVA: 0x03D58AB0 */ }
        UnityEngine.Timeline.ClipCaps clipCaps { get; /* RVA: 0x09D2D5E0 */ }
        UnityEngine.Timeline.TimelineClip.ClipExtrapolation postExtrapolationMode { get; /* RVA: 0x09D2DA44 */ set; /* RVA: 0x09D2DDAC */ }
        UnityEngine.Timeline.TimelineClip.ClipExtrapolation preExtrapolationMode { get; /* RVA: 0x09D2DA68 */ set; /* RVA: 0x09D2DDE8 */ }
        System.Double extrapolatedStart { get; /* RVA: 0x09D2D868 */ }
        System.Double extrapolatedDuration { get; /* RVA: 0x09D2D7A4 */ }

        // Methods
        // RVA: 0x09D2D508  token: 0x600010F
        private System.Void UpgradeToLatestVersion() { }
        // RVA: 0x09D2D518  token: 0x6000110
        private System.Void .ctor(UnityEngine.Timeline.TrackAsset parent) { }
        // RVA: 0x03D4E2B0  token: 0x6000121
        public UnityEngine.Timeline.TrackAsset GetParentTrack() { }
        // RVA: 0x09D2D148  token: 0x6000122
        private System.Void SetParentTrack_Internal(UnityEngine.Timeline.TrackAsset newParentTrack) { }
        // RVA: 0x09D2CF04  token: 0x6000135
        private System.Int32 Hash() { }
        // RVA: 0x09D2CC90  token: 0x6000136
        public System.Single EvaluateMixOut(System.Double time) { }
        // RVA: 0x09D2CBCC  token: 0x6000137
        public System.Single EvaluateMixOutAtGivenTime(System.Double time, System.Double mixOutTime, System.Double mixOutDuration) { }
        // RVA: 0x09D2CAF0  token: 0x6000138
        public System.Single EvaluateMixIn(System.Double time) { }
        // RVA: 0x09D2CA2C  token: 0x6000139
        public System.Single EvaluateMixInAtGivenTime(System.Double time, System.Double runtimeMixInTime, System.Double mixInDuration) { }
        // RVA: 0x09D2CD74  token: 0x600013A
        private static UnityEngine.AnimationCurve GetDefaultMixInCurve() { }
        // RVA: 0x09D2CD9C  token: 0x600013B
        private static UnityEngine.AnimationCurve GetDefaultMixOutCurve() { }
        // RVA: 0x09D2D228  token: 0x600013C
        public System.Double ToLocalTime(System.Double time) { }
        // RVA: 0x09D2D050  token: 0x600013D
        private static System.Double SanitizeTimeValue(System.Double value, System.Double defaultValue) { }
        // RVA: 0x03D85620  token: 0x6000142
        private System.Void SetPostExtrapolationTime(System.Double time) { }
        // RVA: 0x03D85630  token: 0x6000143
        private System.Void SetPreExtrapolationTime(System.Double time) { }
        // RVA: 0x09D2D008  token: 0x6000144
        public System.Boolean IsPreExtrapolatedTime(System.Double sequenceTime) { }
        // RVA: 0x09D2CFB0  token: 0x6000145
        public System.Boolean IsPostExtrapolatedTime(System.Double sequenceTime) { }
        // RVA: 0x09D2CDC4  token: 0x6000148
        private static System.Double GetExtrapolatedTime(System.Double time, UnityEngine.Timeline.TimelineClip.ClipExtrapolation mode, System.Double duration) { }
        // RVA: 0x03D51DD0  token: 0x6000149
        private virtual System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        // RVA: 0x03528C50  token: 0x600014A
        private virtual System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        // RVA: 0x09D2D33C  token: 0x600014B
        public virtual System.String ToString() { }
        // RVA: 0x0350B670  token: 0x600014C
        private System.Void UpdateDirty(System.Double oldValue, System.Double newValue) { }
        // RVA: 0x03C916F0  token: 0x600014D
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000035  // size: 0x68
    public class TimelineAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.ISerializationCallbackReceiver, UnityEngine.Timeline.ITimelineClipAsset, UnityEngine.Timeline.IPropertyPreview
    {
        // Fields
        private static System.Int32 k_LatestVersion;  // const
        private System.Int32 m_Version;  // 0x18
        private System.Collections.Generic.List<UnityEngine.ScriptableObject> m_Tracks;  // 0x20
        private System.Double m_FixedDuration;  // 0x28
        private UnityEngine.Timeline.TrackAsset[] m_CacheOutputTracks;  // 0x30
        private UnityEngine.Timeline.GroupTrack[] m_CacheGroupTracks;  // 0x38
        private System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> m_CacheRootTracks;  // 0x40
        private UnityEngine.Timeline.TrackAsset[] m_CacheFlattenedTracks;  // 0x48
        private UnityEngine.Timeline.TimelineAsset.EditorSettings m_EditorSettings;  // 0x50
        private UnityEngine.Timeline.TimelineAsset.DurationMode m_DurationMode;  // 0x58
        private UnityEngine.Timeline.MarkerTrack m_MarkerTrack;  // 0x60

        // Properties
        UnityEngine.Timeline.TimelineAsset.EditorSettings editorSettings { get; /* RVA: 0x03D4EAF0 */ }
        System.Double duration { get; /* RVA: 0x09D2C640 */ }
        System.Double fixedDuration { get; /* RVA: 0x09D2C6C0 */ set; /* RVA: 0x09D2C978 */ }
        UnityEngine.Timeline.TimelineAsset.DurationMode durationMode { get; /* RVA: 0x03D4EF00 */ set; /* RVA: 0x03D4EF50 */ }
        System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> outputs { get; /* RVA: 0x09D2C8C0 */ }
        UnityEngine.Timeline.ClipCaps clipCaps { get; /* RVA: 0x09D2C42C */ }
        System.Int32 outputTrackCount { get; /* RVA: 0x09D2C898 */ }
        System.Int32 rootTrackCount { get; /* RVA: 0x09D2C930 */ }
        UnityEngine.Timeline.TrackAsset[] flattenedTracks { get; /* RVA: 0x09D2C740 */ }
        UnityEngine.Timeline.MarkerTrack markerTrack { get; /* RVA: 0x03D4EB00 */ }
        System.Collections.Generic.List<UnityEngine.ScriptableObject> trackObjects { get; /* RVA: 0x03D4EB40 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600014F
        private System.Void UpgradeToLatestVersion() { }
        // RVA: 0x09D2BE0C  token: 0x600015A
        private System.Void OnValidate() { }
        // RVA: 0x09D2B930  token: 0x600015B
        public UnityEngine.Timeline.TrackAsset GetRootTrack(System.Int32 index) { }
        // RVA: 0x09D2B98C  token: 0x600015C
        public System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetRootTracks() { }
        // RVA: 0x09D2B8D0  token: 0x600015D
        public UnityEngine.Timeline.TrackAsset GetOutputTrack(System.Int32 index) { }
        // RVA: 0x09D2B914  token: 0x600015E
        public System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetOutputTracks() { }
        // RVA: 0x09D2B8B4  token: 0x600015F
        public System.Collections.Generic.IEnumerable<UnityEngine.Timeline.GroupTrack> GetGroupTracks() { }
        // RVA: 0x09D2B9A8  token: 0x6000160
        private static System.Double GetValidFrameRate(System.Double frameRate) { }
        // RVA: 0x09D2C1A4  token: 0x6000161
        private System.Void UpdateRootTrackCache() { }
        // RVA: 0x09D2BF5C  token: 0x6000162
        private System.Void UpdateOutputTrackCache() { }
        // RVA: 0x09D2B8AC  token: 0x6000164
        public UnityEngine.Timeline.TrackAsset[] GetAllTracks() { }
        // RVA: 0x09D2A4A4  token: 0x6000167
        private System.Void AddTrackInternal(UnityEngine.Timeline.TrackAsset track) { }
        // RVA: 0x09D2BE40  token: 0x6000168
        private System.Void RemoveTrack(UnityEngine.Timeline.TrackAsset track) { }
        // RVA: 0x09D2A978  token: 0x6000169
        public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go) { }
        // RVA: 0x03D85610  token: 0x600016A
        private virtual System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        // RVA: 0x03190890  token: 0x600016B
        private virtual System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        // RVA: 0x0336A0D0  token: 0x600016C
        private System.Void __internalAwake() { }
        // RVA: 0x09D2B748  token: 0x600016D
        public virtual System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }
        // RVA: 0x09D2A8A4  token: 0x600016E
        public System.Void CreateMarkerTrack() { }
        // RVA: 0x03190D90  token: 0x600016F
        private System.Void Invalidate() { }
        // RVA: 0x09D2BF00  token: 0x6000170
        private System.Void UpdateFixedDurationWithItemsDuration() { }
        // RVA: 0x09D2A770  token: 0x6000171
        private UnityEngine.Timeline.DiscreteTime CalculateItemsDuration() { }
        // RVA: 0x09D2A2CC  token: 0x6000172
        private static System.Void AddSubTracksRecursive(UnityEngine.Timeline.TrackAsset track, System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset>& allTracks) { }
        // RVA: 0x09D2AC80  token: 0x6000173
        public UnityEngine.Timeline.TrackAsset CreateTrack(System.Type type, UnityEngine.Timeline.TrackAsset parent, System.String name) { }
        // RVA: -1  // generic def  token: 0x6000174
        public T CreateTrack(UnityEngine.Timeline.TrackAsset parent, System.String trackName) { }
        // RVA: -1  // generic def  token: 0x6000175
        public T CreateTrack(System.String trackName) { }
        // RVA: -1  // generic def  token: 0x6000176
        public T CreateTrack() { }
        // RVA: 0x09D2AF9C  token: 0x6000177
        public System.Boolean DeleteClip(UnityEngine.Timeline.TimelineClip clip) { }
        // RVA: 0x09D2B3BC  token: 0x6000178
        public System.Boolean DeleteTrack(UnityEngine.Timeline.TrackAsset track) { }
        // RVA: 0x09D2BA48  token: 0x6000179
        private System.Void MoveLastTrackBefore(UnityEngine.Timeline.TrackAsset asset) { }
        // RVA: 0x09D2BC04  token: 0x600017A
        public System.Void MoveTrackAfter(UnityEngine.Timeline.TrackAsset trackToMove, UnityEngine.Timeline.TrackAsset targetTrack) { }
        // RVA: 0x09D2A514  token: 0x600017B
        private UnityEngine.Timeline.TrackAsset AllocateTrack(UnityEngine.Timeline.TrackAsset trackAssetParent, System.String trackName, System.Type trackType) { }
        // RVA: 0x09D2B138  token: 0x600017C
        private System.Void DeleteRecordedAnimation(UnityEngine.Timeline.TrackAsset track) { }
        // RVA: 0x09D2B23C  token: 0x600017D
        private System.Void DeleteRecordedAnimation(UnityEngine.Timeline.TimelineClip clip) { }
        // RVA: 0x03151690  token: 0x600017E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003C  // size: 0xC0
    public abstract class TrackAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.ISerializationCallbackReceiver, UnityEngine.Timeline.IPropertyPreview, UnityEngine.Timeline.ICurvesOwner, UnityEngine.Timeline.IDynamicBinding
    {
        // Fields
        private static System.Int32 k_LatestVersion;  // const
        private System.Int32 m_Version;  // 0x18
        private UnityEngine.AnimationClip m_AnimClip;  // 0x20
        public System.Boolean useAutoBinding;  // 0x28
        public System.String autoBindingPath;  // 0x30
        public System.String uniqueId;  // 0x38
        private static UnityEngine.Timeline.TrackAsset.TransientBuildData s_BuildData;  // static @ 0x0
        private static System.String kDefaultCurvesName;  // const
        private static System.Action<UnityEngine.Timeline.TimelineClip,UnityEngine.GameObject,UnityEngine.Playables.Playable> OnClipPlayableCreate;  // static @ 0x18
        private static System.Action<UnityEngine.Timeline.TrackAsset,UnityEngine.GameObject,UnityEngine.Playables.Playable> OnTrackAnimationPlayableCreate;  // static @ 0x20
        private System.Boolean m_RuntimeMuted;  // 0x40
        private System.Boolean m_Locked;  // 0x41
        private System.Boolean m_Muted;  // 0x42
        private System.String m_CustomPlayableFullTypename;  // 0x48
        private UnityEngine.AnimationClip m_Curves;  // 0x50
        private UnityEngine.Playables.PlayableAsset m_Parent;  // 0x58
        private System.Collections.Generic.List<UnityEngine.ScriptableObject> m_Children;  // 0x60
        private System.Int32 m_ItemsHash;  // 0x68
        private UnityEngine.Timeline.TimelineClip[] m_ClipsCache;  // 0x70
        private UnityEngine.Timeline.DiscreteTime m_Start;  // 0x78
        private UnityEngine.Timeline.DiscreteTime m_End;  // 0x80
        private System.Boolean m_CacheSorted;  // 0x88
        private System.Nullable<System.Boolean> m_SupportsNotifications;  // 0x89
        private static UnityEngine.Timeline.TrackAsset[] s_EmptyCache;  // static @ 0x28
        private System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> m_ChildTrackCache;  // 0x90
        private static System.Collections.Generic.Dictionary<System.Type,UnityEngine.Timeline.TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache;  // static @ 0x30
        protected internal System.Collections.Generic.List<UnityEngine.Timeline.TimelineClip> m_Clips;  // 0x98
        private UnityEngine.Timeline.MarkerList m_Markers;  // 0xa0
        public System.Int32 OptionIndex;  // 0xb8
        public System.Boolean useRuntimeMuted;  // 0xbc

        // Properties
        System.Double start { get; /* RVA: 0x09D33AD8 */ }
        System.Double end { get; /* RVA: 0x09D3366C */ }
        System.Double duration { get; /* RVA: 0x09D33608 */ }
        System.Boolean muted { get; /* RVA: 0x09D33A54 */ set; /* RVA: 0x03D4F7C0 */ }
        System.Boolean runtimeMuted { get; /* RVA: 0x03D4EE90 */ set; /* RVA: 0x03D4EEB0 */ }
        System.Boolean mutedInHierarchy { get; /* RVA: 0x09D33960 */ }
        UnityEngine.Timeline.TimelineAsset timelineAsset { get; /* RVA: 0x03190C70 */ }
        UnityEngine.Playables.PlayableAsset parent { get; /* RVA: 0x03D4EAA0 */ set; /* RVA: 0x03081D30 */ }
        UnityEngine.Timeline.TimelineClip[] clips { get; /* RVA: 0x09D3353C */ }
        System.Boolean isEmpty { get; /* RVA: 0x09D33778 */ }
        System.Boolean hasClips { get; /* RVA: 0x09D336C0 */ }
        System.Boolean hasCurves { get; /* RVA: 0x09D33708 */ }
        System.Boolean isSubTrack { get; /* RVA: 0x09D337B4 */ }
        System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> outputs { get; /* RVA: 0x09D33A68 */ }
        System.String customPlayableTypename { get; /* RVA: 0x03D4EA70 */ set; /* RVA: 0x02692290 */ }
        UnityEngine.AnimationClip curves { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x02C926C0 */ }
        System.String UnityEngine.Timeline.ICurvesOwner.defaultCurvesName { get; /* RVA: 0x09D32F20 */ }
        UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.asset { get; /* RVA: 0x0339AE90 */ }
        UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.assetOwner { get; /* RVA: 0x09D32F18 */ }
        UnityEngine.Timeline.TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack { get; /* RVA: 0x0339AE90 */ }
        System.Collections.Generic.List<UnityEngine.ScriptableObject> subTracksObjects { get; /* RVA: 0x03D4EB00 */ }
        System.Boolean locked { get; /* RVA: 0x03D4F7B0 */ set; /* RVA: 0x03D4F7D0 */ }
        System.Boolean lockedInHierarchy { get; /* RVA: 0x09D33874 */ }
        System.Boolean supportsNotifications { get; /* RVA: 0x09D33B28 */ }

        // Events
        event System.Action<UnityEngine.Timeline.TimelineClip,UnityEngine.GameObject,UnityEngine.Playables.Playable> OnClipPlayableCreate;
        event System.Action<UnityEngine.Timeline.TrackAsset,UnityEngine.GameObject,UnityEngine.Playables.Playable> OnTrackAnimationPlayableCreate;

        // Methods
        // RVA: 0x0350B670  token: 0x600018D
        protected virtual System.Void OnBeforeTrackSerialize() { }
        // RVA: 0x0350B670  token: 0x600018E
        protected virtual System.Void OnAfterTrackDeserialize() { }
        // RVA: 0x0350B670  token: 0x600018F
        private virtual System.Void OnUpgradeFromVersion(System.Int32 oldVersion) { }
        // RVA: 0x09D32E04  token: 0x6000190
        private virtual System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        // RVA: 0x031908A0  token: 0x6000191
        private virtual System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        // RVA: 0x0350B670  token: 0x6000192
        private System.Void UpgradeToLatestVersion() { }
        // RVA: 0x09D32120  token: 0x60001A2
        public System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TimelineClip> GetClips() { }
        // RVA: 0x09D31DBC  token: 0x60001A9
        public System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetChildTracks() { }
        // RVA: 0x03504410  token: 0x60001B7
        private System.Void __internalAwake() { }
        // RVA: 0x09D2FE38  token: 0x60001B8
        public virtual System.Void CreateCurves(System.String curvesClipName) { }
        // RVA: 0x09D313F4  token: 0x60001B9
        public virtual UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount) { }
        // RVA: 0x09D31138  token: 0x60001BA
        public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go) { }
        // RVA: 0x09D2FED8  token: 0x60001BB
        public UnityEngine.Timeline.TimelineClip CreateDefaultClip() { }
        // RVA: -1  // generic def  token: 0x60001BC
        public UnityEngine.Timeline.TimelineClip CreateClip() { }
        // RVA: 0x09D31464  token: 0x60001BD
        public System.Boolean DeleteClip(UnityEngine.Timeline.TimelineClip clip) { }
        // RVA: 0x09D30238  token: 0x60001BE
        public UnityEngine.Timeline.IMarker CreateMarker(System.Type type, System.Double time) { }
        // RVA: -1  // generic def  token: 0x60001BF
        public T CreateMarker(System.Double time) { }
        // RVA: 0x09D315B4  token: 0x60001C0
        public System.Boolean DeleteMarker(UnityEngine.Timeline.IMarker marker) { }
        // RVA: 0x03190B20  token: 0x60001C1
        public System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetMarkers() { }
        // RVA: 0x09D31DDC  token: 0x60001C2
        public System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetClipMarkers() { }
        // RVA: 0x09D32440  token: 0x60001C3
        public System.Int32 GetMarkerCount() { }
        // RVA: 0x09D32450  token: 0x60001C4
        public UnityEngine.Timeline.IMarker GetMarker(System.Int32 idx) { }
        // RVA: 0x09D2FD1C  token: 0x60001C5
        private UnityEngine.Timeline.TimelineClip CreateClip(System.Type requestedType) { }
        // RVA: 0x09D2F668  token: 0x60001C6
        private UnityEngine.Timeline.TimelineClip CreateAndAddNewClipOfType(System.Type requestedType) { }
        // RVA: 0x09D2FB04  token: 0x60001C7
        private UnityEngine.Timeline.TimelineClip CreateClipOfType(System.Type requestedType) { }
        // RVA: 0x09D2F8C0  token: 0x60001C8
        private UnityEngine.Timeline.TimelineClip CreateClipFromPlayableAsset(UnityEngine.Playables.IPlayableAsset asset) { }
        // RVA: 0x09D2F69C  token: 0x60001C9
        private UnityEngine.Timeline.TimelineClip CreateClipFromAsset(UnityEngine.ScriptableObject playableAsset) { }
        // RVA: 0x03D4EA80  token: 0x60001CA
        private System.Collections.Generic.IEnumerable<UnityEngine.ScriptableObject> GetMarkersRaw() { }
        // RVA: 0x09D2F13C  token: 0x60001CB
        private System.Void ClearMarkers() { }
        // RVA: 0x09D2EE38  token: 0x60001CC
        private System.Void AddMarker(UnityEngine.ScriptableObject e) { }
        // RVA: 0x09D31574  token: 0x60001CD
        private System.Boolean DeleteMarkerRaw(UnityEngine.ScriptableObject marker) { }
        // RVA: 0x09D325CC  token: 0x60001CE
        private System.Int32 GetTimeRangeHash() { }
        // RVA: 0x09D2EDA4  token: 0x60001CF
        private System.Void AddClip(UnityEngine.Timeline.TimelineClip newClip) { }
        // RVA: 0x09D30B34  token: 0x60001D0
        private UnityEngine.Playables.Playable CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable mixerPlayable, UnityEngine.GameObject go, UnityEngine.Playables.Playable timelinePlayable) { }
        // RVA: 0x09D30E8C  token: 0x60001D1
        private UnityEngine.Playables.Playable CreatePlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Playables.Playable timelinePlayable) { }
        // RVA: 0x09D2F1CC  token: 0x60001D2
        private virtual UnityEngine.Playables.Playable CompileClips(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.Timeline.TimelineClip> timelineClips, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree) { }
        // RVA: 0x09D315C4  token: 0x60001D3
        private System.Void GatherCompilableTracks(System.Collections.Generic.IList<UnityEngine.Timeline.TrackAsset> tracks) { }
        // RVA: 0x09D31784  token: 0x60001D4
        private System.Void GatherNotifications(System.Collections.Generic.List<UnityEngine.Timeline.IMarker> markers) { }
        // RVA: 0x09D3025C  token: 0x60001D5
        private virtual UnityEngine.Playables.Playable CreateMixerPlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree) { }
        // RVA: 0x09D2F530  token: 0x60001D6
        private System.Void ConfigureTrackAnimation(UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.GameObject go, UnityEngine.Playables.Playable blend) { }
        // RVA: 0x09D32CC4  token: 0x60001D7
        private System.Void SortClips() { }
        // RVA: 0x09D2F0B0  token: 0x60001D8
        private System.Void ClearClipsInternal() { }
        // RVA: 0x09D2F14C  token: 0x60001D9
        private System.Void ClearSubTracksInternal() { }
        // RVA: 0x03D71DF0  token: 0x60001DA
        private System.Void OnClipMove() { }
        // RVA: 0x09D308F8  token: 0x60001DB
        private UnityEngine.Timeline.TimelineClip CreateNewClipContainerInternal() { }
        // RVA: 0x09D2ED08  token: 0x60001DC
        private System.Void AddChild(UnityEngine.Timeline.TrackAsset child) { }
        // RVA: 0x09D32A24  token: 0x60001DD
        private System.Void MoveLastTrackBefore(UnityEngine.Timeline.TrackAsset asset) { }
        // RVA: 0x09D32C48  token: 0x60001DE
        private System.Boolean RemoveSubTrack(UnityEngine.Timeline.TrackAsset child) { }
        // RVA: 0x09D32BE0  token: 0x60001DF
        private System.Void RemoveClip(UnityEngine.Timeline.TimelineClip clip) { }
        // RVA: 0x09D32128  token: 0x60001E0
        private virtual System.Void GetEvaluationTime(System.Double& outStart, System.Double& outDuration) { }
        // RVA: 0x09D325B4  token: 0x60001E1
        private virtual System.Void GetSequenceTime(System.Double& outStart, System.Double& outDuration) { }
        // RVA: 0x09D31980  token: 0x60001E2
        public virtual System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }
        // RVA: 0x09D32334  token: 0x60001E3
        private UnityEngine.GameObject GetGameObjectBinding(UnityEngine.Playables.PlayableDirector director) { }
        // RVA: 0x09D331A4  token: 0x60001E4
        private System.Boolean ValidateClipType(System.Type clipType) { }
        // RVA: 0x0350B670  token: 0x60001E5
        protected virtual System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip) { }
        // RVA: 0x09D330D8  token: 0x60001E6
        private System.Void UpdateDuration() { }
        // RVA: 0x09D2EE48  token: 0x60001E7
        protected internal virtual System.Int32 CalculateItemsHash() { }
        // RVA: 0x09D31188  token: 0x60001E8
        protected virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject gameObject, UnityEngine.Timeline.TimelineClip clip) { }
        // RVA: 0x03190BD0  token: 0x60001E9
        private System.Void Invalidate() { }
        // RVA: 0x09D32460  token: 0x60001EA
        private System.Double GetNotificationDuration() { }
        // RVA: 0x09D2EEE0  token: 0x60001EB
        private virtual System.Boolean CanCompileClips() { }
        // RVA: 0x09D32714  token: 0x60001EC
        public System.Boolean HasChildTracks() { }
        // RVA: 0x09D2F0A0  token: 0x60001ED
        public virtual System.Boolean CanCreateTrackMixer() { }
        // RVA: 0x09D32824  token: 0x60001EE
        private System.Boolean IsCompilable() { }
        // RVA: 0x09D32F4C  token: 0x60001EF
        private System.Void UpdateChildTrackCache() { }
        // RVA: 0x09D327E0  token: 0x60001F0
        private virtual System.Int32 Hash() { }
        // RVA: 0x09D31FD8  token: 0x60001F1
        private System.Int32 GetClipsHash() { }
        // RVA: 0x09D31CFC  token: 0x60001F2
        protected static System.Int32 GetAnimationClipHash(UnityEngine.AnimationClip clip) { }
        // RVA: 0x09D3275C  token: 0x60001F3
        private System.Boolean HasNotifications() { }
        // RVA: 0x09D2EF1C  token: 0x60001F4
        private System.Boolean CanCompileNotifications() { }
        // RVA: 0x09D2EF48  token: 0x60001F5
        private System.Boolean CanCreateMixerRecursive() { }
        // RVA: 0x09D300F8  token: 0x60001F6
        public UnityEngine.Playables.Playable CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount) { }
        // RVA: 0x03151700  token: 0x60001F7
        protected System.Void .ctor() { }
        // RVA: 0x03151280  token: 0x60001F8
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000042  // size: 0x10
    public class ForbidScriptDefaultValueWhenExportAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000206
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000043  // size: 0x10
    public class TimelineHelpURLAttribute : System.Attribute
    {
    }

    // TypeToken: 0x2000044  // size: 0x20
    public class TrackColorAttribute : System.Attribute
    {
        // Fields
        private UnityEngine.Color m_Color;  // 0x10

        // Methods
        // RVA: 0x03871E00  token: 0x6000207
        public System.Void .ctor(System.Single r, System.Single g, System.Single b) { }

    }

    // TypeToken: 0x2000045  // size: 0x10
    public class UseScriptDefaultValueWhenExportAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000208
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000046  // size: 0x18
    public class AudioClipProperties : UnityEngine.Playables.PlayableBehaviour
    {
        // Fields
        public System.Single volume;  // 0x10

        // Methods
        // RVA: 0x03D4FB80  token: 0x6000209
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000047  // size: 0x20
    public class AudioMixerProperties : UnityEngine.Playables.PlayableBehaviour
    {
        // Fields
        public System.Single volume;  // 0x10
        public System.Single stereoPan;  // 0x14
        public System.Single spatialBlend;  // 0x18

        // Methods
        // RVA: 0x09D26154  token: 0x600020A
        public virtual System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x03D4FB80  token: 0x600020B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000048  // size: 0x30
    public class AudioPlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
    {
        // Fields
        private UnityEngine.AudioClip m_Clip;  // 0x18
        private System.Boolean m_Loop;  // 0x20
        private System.Single m_bufferingTime;  // 0x24
        private UnityEngine.Timeline.AudioClipProperties m_ClipProperties;  // 0x28

        // Properties
        System.Single bufferingTime { get; /* RVA: 0x03D524F0 */ set; /* RVA: 0x03D52500 */ }
        UnityEngine.AudioClip clip { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.Boolean loop { get; /* RVA: 0x03D4EF90 */ set; /* RVA: 0x03D4EFC0 */ }
        System.Double duration { get; /* RVA: 0x09D26578 */ }
        System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> outputs { get; /* RVA: 0x09D26620 */ }
        UnityEngine.Timeline.ClipCaps clipCaps { get; /* RVA: 0x09D26568 */ }

        // Methods
        // RVA: 0x09D263E4  token: 0x6000214
        public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go) { }
        // RVA: 0x09D26500  token: 0x6000216
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004A  // size: 0xC8
    public class AudioTrack : UnityEngine.Timeline.TrackAsset
    {
        // Fields
        private UnityEngine.Timeline.AudioMixerProperties m_TrackProperties;  // 0xc0

        // Properties
        System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> outputs { get; /* RVA: 0x09D26DC4 */ }

        // Methods
        // RVA: 0x09D26BC4  token: 0x600021F
        public UnityEngine.Timeline.TimelineClip CreateClip(UnityEngine.AudioClip clip) { }
        // RVA: 0x09D26690  token: 0x6000220
        private virtual UnityEngine.Playables.Playable CompileClips(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.Timeline.TimelineClip> timelineClips, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree) { }
        // RVA: 0x09D26CD8  token: 0x6000222
        private System.Void OnValidate() { }
        // RVA: 0x09D26D44  token: 0x6000223
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004C  // size: 0x28
    public sealed struct ACConditionDescriptor
    {
        // Fields
        private System.Int32 m_ConditionMode;  // 0x10
        private System.String m_ConditionEvent;  // 0x18
        private System.Single m_EventTreshold;  // 0x20

    }

    // TypeToken: 0x200004D  // size: 0x10
    public class ACTransitionDescriptor
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600022C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004E  // size: 0x10
    public static class BeyondCommunicator
    {
        // Fields
        public static System.Boolean setAddonLayerAdditive;  // static @ 0x0
        private static System.Action<UnityEngine.Animator,UnityEngine.Animations.AnimationLayerMixerPlayable,UnityEngine.Timeline.AnimationTrack,UnityEngine.ScriptableObject,UnityEngine.Transform,UnityEngine.Timeline.CommunicatorParam> <ConnectToJobSync>k__BackingField;  // static @ 0x8

        // Properties
        System.Action<UnityEngine.Animator,UnityEngine.Animations.AnimationLayerMixerPlayable,UnityEngine.Timeline.AnimationTrack,UnityEngine.ScriptableObject,UnityEngine.Transform,UnityEngine.Timeline.CommunicatorParam> ConnectToJobSync { get; /* RVA: 0x09D26E34 */ set; /* RVA: 0x09D26E84 */ }

        // Methods
        // RVA: 0x03D44B60  token: 0x600022F
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200004F  // size: 0x30
    public class BlendMotionDescriptor
    {
        // Fields
        public UnityEngine.AnimationClip motion;  // 0x10
        public System.String poseTimerParam;  // 0x18
        public System.String blendParam;  // 0x20
        public System.Single threshold;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x6000230
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000050  // size: 0x30
    public class BlendTreeDescriptor
    {
        // Fields
        public UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeType blendType;  // 0x10
        public System.Collections.Generic.List<UnityEngine.Timeline.BlendMotionDescriptor> motionDescriptorList;  // 0x18
        private System.String <speedParameter>k__BackingField;  // 0x20
        private System.Boolean <speedParameterActive>k__BackingField;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x6000231
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000052
    public interface ITimelineRootMarker
    {
        // Properties
        UnityEngine.Playables.PlayableDirector topDirector { get; /* RVA: -1  // abstract */ }
        UnityEngine.GameObject rootGo { get; /* RVA: -1  // abstract */ }
        System.Boolean useEarlyUpdate { get; /* RVA: -1  // abstract */ }
        System.Boolean enableLoop { get; /* RVA: -1  // abstract */ }
        System.Boolean isOptimizingHolding { get; /* RVA: -1  // abstract */ }
        System.Boolean onlyEvaluateTopDirector { get; /* RVA: -1  // abstract */ }
        System.Single fixedFrameRate { get; /* RVA: -1  // abstract */ }
        System.Single manualTickDeltaTime { get; /* RVA: -1  // abstract */ }
        System.Boolean isManualTicking { get; /* RVA: -1  // abstract */ }
        System.Collections.Generic.Dictionary<UnityEngine.Playables.PlayableDirector,UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.DirectorControlPlayable>> director2ControlPlayable { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000235
        public virtual System.Void RegisterLoopSegmentRuntimeClip(System.String key, UnityEngine.Timeline.RuntimeClip runtimeClip) { }
        // RVA: -1  // abstract  token: 0x6000236
        public virtual System.Void UpdateAllVFXFollowBoneTools() { }

    }

    // TypeToken: 0x2000053  // size: 0x38
    public class LayerDescriptor : UnityEngine.ScriptableObject
    {
        // Fields
        public System.String layerName;  // 0x18
        public UnityEngine.AvatarMask avatarMask;  // 0x20
        public System.Boolean isAdditive;  // 0x28
        public System.Collections.Generic.List<UnityEngine.Timeline.StateDescriptor> stateDescriptors;  // 0x30

        // Methods
        // RVA: 0x0286F540  token: 0x600023F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000054  // size: 0x58
    public class MotionDescriptor
    {
        // Fields
        public System.String stateName;  // 0x10
        public UnityEngine.AnimationClip motion;  // 0x18
        public System.Single speed;  // 0x20
        public System.String speedParameter;  // 0x28
        public System.Boolean speedParameterActive;  // 0x30
        public System.String mirrorParameter;  // 0x38
        public System.Boolean mirrorParameterActive;  // 0x40
        public System.String timeParameter;  // 0x48
        public System.Boolean timeParameterActive;  // 0x50

        // Methods
        // RVA: 0x0350B670  token: 0x6000240
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000055  // size: 0x40
    public class StateDescriptor
    {
        // Fields
        public System.String stateName;  // 0x10
        public System.Boolean isDefaultState;  // 0x18
        public System.String stateWeightParameter;  // 0x20
        public System.Boolean stateWeightParameterActive;  // 0x28
        public System.Boolean isBlendTree;  // 0x29
        public UnityEngine.Timeline.MotionDescriptor motionDescriptor;  // 0x30
        public UnityEngine.Timeline.BlendTreeDescriptor blendTreeDescriptor;  // 0x38

        // Methods
        // RVA: 0x0350B670  token: 0x6000241
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000056  // size: 0x14
    public sealed struct ClipCaps
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.ClipCaps None;  // const
        public static UnityEngine.Timeline.ClipCaps Looping;  // const
        public static UnityEngine.Timeline.ClipCaps Extrapolation;  // const
        public static UnityEngine.Timeline.ClipCaps ClipIn;  // const
        public static UnityEngine.Timeline.ClipCaps SpeedMultiplier;  // const
        public static UnityEngine.Timeline.ClipCaps Blending;  // const
        public static UnityEngine.Timeline.ClipCaps AutoScale;  // const
        public static UnityEngine.Timeline.ClipCaps ClipMarker;  // const
        public static UnityEngine.Timeline.ClipCaps DialogLoopSegment;  // const
        public static UnityEngine.Timeline.ClipCaps IgniteOnce;  // const
        public static UnityEngine.Timeline.ClipCaps OnlyDeltaTime;  // const
        public static UnityEngine.Timeline.ClipCaps DialogJumpSegment;  // const
        public static UnityEngine.Timeline.ClipCaps EvaluateTwiceWhenEnabled;  // const
        public static UnityEngine.Timeline.ClipCaps DynamicLink;  // const
        public static UnityEngine.Timeline.ClipCaps CustomBehaviourControl;  // const
        public static UnityEngine.Timeline.ClipCaps ConditionBlend;  // const
        public static UnityEngine.Timeline.ClipCaps All;  // const

    }

    // TypeToken: 0x2000057  // size: 0x10
    public static class TimelineClipCapsExtensions
    {
        // Methods
        // RVA: 0x09D2C9D0  token: 0x6000242
        public static System.Boolean SupportsExtrapolation(UnityEngine.Timeline.TimelineClip clip) { }
        // RVA: 0x05D658E8  token: 0x6000243
        public static System.Boolean HasAny(UnityEngine.Timeline.ClipCaps caps, UnityEngine.Timeline.ClipCaps flags) { }

    }

    // TypeToken: 0x2000058  // size: 0x78
    public class ControlPlayableAsset : Beyond.Gameplay.Core.BeyondUseAutoBindingPlayableAsset, UnityEngine.Timeline.IPropertyPreview, UnityEngine.Timeline.ITimelineClipAsset
    {
        // Fields
        private static System.Int32 k_MaxRandInt;  // const
        private static readonly System.Collections.Generic.List<UnityEngine.Playables.PlayableDirector> k_EmptyDirectorsList;  // static @ 0x0
        private static readonly System.Collections.Generic.List<UnityEngine.ParticleSystem> k_EmptyParticlesList;  // static @ 0x8
        private static readonly System.Collections.Generic.HashSet<UnityEngine.ParticleSystem> s_SubEmitterCollector;  // static @ 0x10
        public UnityEngine.ExposedReference<UnityEngine.GameObject> sourceGameObject;  // 0x30
        public UnityEngine.GameObject prefabGameObject;  // 0x40
        public System.Boolean updateParticle;  // 0x48
        public System.UInt32 particleRandomSeed;  // 0x4c
        public System.Boolean forceRuntimeSimulate;  // 0x50
        public System.Boolean updateDirector;  // 0x51
        public System.Boolean updateITimeControl;  // 0x52
        public System.Boolean searchHierarchy;  // 0x53
        public System.Boolean active;  // 0x54
        public UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState postPlayback;  // 0x58
        private System.Boolean m_OnlyDeltaTime;  // 0x5c
        private System.Boolean m_IgniteOnce;  // 0x5d
        private UnityEngine.Playables.PlayableAsset m_ControlDirectorAsset;  // 0x60
        private System.Double m_Duration;  // 0x68
        private System.Boolean m_SupportLoop;  // 0x70
        private static System.Collections.Generic.HashSet<UnityEngine.Playables.PlayableDirector> s_ProcessedDirectors;  // static @ 0x18
        private static System.Collections.Generic.HashSet<UnityEngine.GameObject> s_CreatedPrefabs;  // static @ 0x20
        private System.Boolean <controllingDirectors>k__BackingField;  // 0x71
        private System.Boolean <controllingParticles>k__BackingField;  // 0x72

        // Properties
        UnityEngine.GameObject bindingGameObject { get; /* RVA: 0x09D29E58 */ }
        System.Boolean showBaseParam { get; /* RVA: 0x0232EB60 */ }
        System.Boolean controllingDirectors { get; /* RVA: 0x03D51CF0 */ set; /* RVA: 0x03D51D00 */ }
        System.Boolean controllingParticles { get; /* RVA: 0x03D5BFA0 */ set; /* RVA: 0x03D5BFD0 */ }
        System.Boolean OnlyDeltaTime { get; /* RVA: 0x03D4F600 */ set; /* RVA: 0x03D4F620 */ }
        System.Boolean IgniteOnce { get; /* RVA: 0x03D71350 */ set; /* RVA: 0x03D71390 */ }
        System.Double duration { get; /* RVA: 0x03D4F6E0 */ }
        UnityEngine.Timeline.ClipCaps clipCaps { get; /* RVA: 0x09D29EE8 */ }

        // Methods
        // RVA: 0x09D28454  token: 0x600024E
        public System.Void OnEnable() { }
        // RVA: 0x09D27360  token: 0x6000251
        public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go) { }
        // RVA: 0x09D270F0  token: 0x6000252
        private static UnityEngine.Playables.Playable ConnectPlayablesToMixer(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> playables) { }
        // RVA: 0x09D2724C  token: 0x6000253
        private System.Void CreateActivationPlayable(UnityEngine.GameObject root, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables) { }
        // RVA: 0x09D29454  token: 0x6000254
        protected virtual System.Void SearchHierarchyAndConnectParticleSystem(System.Collections.Generic.IEnumerable<UnityEngine.ParticleSystem> particleSystems, System.Single clipIn, System.Single speedMultiplier, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables) { }
        // RVA: 0x09D291C0  token: 0x6000255
        private System.Void SearchHierarchyAndConnectDirector(System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableDirector> directors, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables, System.Boolean disableSelfReferences) { }
        // RVA: 0x09D28FC0  token: 0x6000256
        private static System.Void SearchHierarchyAndConnectControlableScripts(System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> controlableScripts, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables) { }
        // RVA: 0x09D27030  token: 0x6000257
        private static System.Void ConnectMixerAndPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable mixer, UnityEngine.Playables.Playable playable, System.Int32 portIndex) { }
        // RVA: 0x09D28E6C  token: 0x6000258
        protected virtual UnityEngine.GameObject ResolveSourceGameObject(UnityEngine.IExposedPropertyTable resolver) { }
        // RVA: -1  // generic def  token: 0x6000259
        private System.Collections.Generic.IList<T> GetComponent(UnityEngine.GameObject gameObject) { }
        // RVA: 0x09D28148  token: 0x600025A
        private static System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> GetControlableScripts(UnityEngine.GameObject root) { }
        // RVA: 0x09D296BC  token: 0x600025B
        private System.Void UpdateDurationAndLoopFlag(System.Collections.Generic.IList<UnityEngine.Playables.PlayableDirector> directors, System.Collections.Generic.IList<UnityEngine.ParticleSystem> particleSystems) { }
        // RVA: 0x09D281B8  token: 0x600025C
        private System.Collections.Generic.IList<UnityEngine.ParticleSystem> GetControllableParticleSystems(UnityEngine.GameObject go) { }
        // RVA: 0x09D28304  token: 0x600025D
        private static System.Void GetControllableParticleSystems(UnityEngine.Transform t, System.Collections.Generic.ICollection<UnityEngine.ParticleSystem> roots, System.Collections.Generic.HashSet<UnityEngine.ParticleSystem> subEmitters) { }
        // RVA: 0x09D26F58  token: 0x600025E
        private static System.Void CacheSubEmitters(UnityEngine.ParticleSystem ps, System.Collections.Generic.HashSet<UnityEngine.ParticleSystem> subEmitters) { }
        // RVA: 0x09D27EBC  token: 0x600025F
        public virtual System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }
        // RVA: 0x09D287A4  token: 0x6000260
        private System.Void PreviewParticlesWithControlPlayableAsset(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.ParticleSystem> particles) { }
        // RVA: 0x09D28800  token: 0x6000261
        private static System.Void PreviewParticles(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.ParticleSystem> particles) { }
        // RVA: 0x09D28480  token: 0x6000262
        private static System.Void PreviewActivation(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.GameObject> objects) { }
        // RVA: 0x09D289A4  token: 0x6000263
        private static System.Void PreviewTimeControl(UnityEngine.Timeline.IPropertyCollector driver, UnityEngine.Playables.PlayableDirector director, System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> scripts) { }
        // RVA: 0x09D285CC  token: 0x6000264
        private static System.Void PreviewDirectors(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableDirector> directors) { }
        // RVA: 0x09D29DEC  token: 0x6000265
        public System.Void .ctor() { }
        // RVA: 0x09D29BB8  token: 0x6000266
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200005A  // size: 0xC0
    public class ControlTrack : UnityEngine.Timeline.TrackAsset
    {
        // Methods
        // RVA: 0x09D29F18  token: 0x600026F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005B  // size: 0x30
    public class AdditiveAnimApplyMono : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Timeline.AdditiveAnimApplyMono.TransformAdditive> pendingAdditives;  // 0x18
        private System.Boolean hasnewPendingUpdates;  // 0x20
        private UnityEngine.Timeline.ITimelineRootMarker _parentTimelineRoot;  // 0x28

        // Methods
        // RVA: 0x09D1EC60  token: 0x6000270
        private System.Void Awake() { }
        // RVA: 0x09D1EECC  token: 0x6000271
        public System.Void RecordAdditiveTransform(UnityEngine.Transform bone, UnityEngine.Vector3 position, UnityEngine.Vector3 rotationEuler, UnityEngine.Vector3 scale) { }
        // RVA: 0x09D1EE2C  token: 0x6000272
        private System.Void LateUpdate() { }
        // RVA: 0x09D1E804  token: 0x6000273
        public System.Void ApplyPendingTransforms() { }
        // RVA: 0x09D1ECD8  token: 0x6000274
        public System.Void ClearPendingTransforms() { }
        // RVA: 0x09D1EE58  token: 0x6000275
        private System.Void NotifyCutsceneRootToUpdateVFXTools() { }
        // RVA: 0x09D1F028  token: 0x6000276
        public System.Void RegisterRootComponent() { }
        // RVA: 0x09D1F0A8  token: 0x6000277
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005D  // size: 0x40
    public class AdditiveAnimMixer : UnityEngine.Playables.PlayableBehaviour
    {
        // Fields
        public UnityEngine.Timeline.AdditiveAnimTrack track;  // 0x10
        private UnityEngine.GameObject bindingGo;  // 0x18
        private System.Boolean thisFrameAlreadyCalcualted;  // 0x20
        private System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Timeline.AdditiveAnimMixer.TransformAdditive> additiveCache;  // 0x28
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> bonePaths;  // 0x30
        private System.Collections.Generic.HashSet<System.String> notFoundBonePaths;  // 0x38

        // Methods
        // RVA: 0x03D5B630  token: 0x600027B
        public virtual System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D1F128  token: 0x600027C
        public virtual System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        // RVA: 0x09D1F4D8  token: 0x600027D
        private System.Void _AddToAdditiveCache(UnityEngine.Timeline.AdditiveAnimPlayable additiveAnimPlayable, System.Single clipTime, System.Single weight) { }
        // RVA: 0x09D1FE00  token: 0x600027E
        private System.Void _ApplyAdditive() { }
        // RVA: 0x09D20098  token: 0x600027F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005F  // size: 0x20
    public class AdditiveAnimPlayable : UnityEngine.Playables.PlayableBehaviour
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Timeline.AdditiveAnimPlayableAsset.AnimationCurveInfo> extractedCurves;  // 0x10
        private System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.Timeline.AdditiveAnimPlayableAsset.AnimationCurveInfo>> _curveCache;  // 0x18

        // Methods
        // RVA: 0x09D3664C  token: 0x6000282
        public virtual System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x09D363BC  token: 0x6000283
        public System.Void InitializeCurveCache() { }
        // RVA: 0x09D36214  token: 0x6000284
        public UnityEngine.AnimationCurve GetCurve(System.String path, System.String propertyName) { }
        // RVA: 0x09D361DC  token: 0x6000285
        public System.Single EvaluateCurve(System.String path, System.String propertyName, System.Single time) { }
        // RVA: 0x09D366C4  token: 0x6000286
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000060  // size: 0x48
    public class AdditiveAnimPlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
    {
        // Fields
        public UnityEngine.AnimationClip additiveClip;  // 0x18
        private UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.AdditiveAnimPlayable> additiveAnimPlayable;  // 0x20
        public System.Collections.Generic.List<UnityEngine.Timeline.AdditiveAnimPlayableAsset.AnimationCurveInfo> extractedCurves;  // 0x30
        private System.Boolean m_OnlyDeltaTime;  // 0x38
        private System.Boolean m_IgniteOnce;  // 0x39
        private UnityEngine.AnimationClip _lastProcessedClip;  // 0x40

        // Properties
        System.Boolean OnlyDeltaTime { get; /* RVA: 0x03D4F190 */ set; /* RVA: 0x03D4E280 */ }
        System.Boolean IgniteOnce { get; /* RVA: 0x03D4F300 */ set; /* RVA: 0x03D4F330 */ }
        UnityEngine.Timeline.ClipCaps clipCaps { get; /* RVA: 0x09D361B8 */ }

        // Methods
        // RVA: 0x09D35F68  token: 0x600028B
        public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        // RVA: 0x09D36094  token: 0x600028C
        private System.Void _InitializeBehaviourCurveCache() { }
        // RVA: 0x09D36138  token: 0x600028E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000062  // size: 0xD0
    public class AdditiveAnimTrack : UnityEngine.Timeline.TrackAsset
    {
        // Fields
        private static System.String k_DefaultRecordableClipName;  // const
        private System.Boolean m_InfiniteClip;  // 0xc0
        private UnityEngine.AnimationClip m_RecordableClip;  // 0xc8

        // Methods
        // RVA: 0x09D36764  token: 0x6000290
        public virtual UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount) { }
        // RVA: 0x09D36860  token: 0x6000291
        public virtual System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }
        // RVA: 0x09D3673C  token: 0x6000292
        public UnityEngine.Timeline.TimelineClip CreateRecordableClip(System.String animClipName) { }
        // RVA: 0x09D36A38  token: 0x6000293
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000063  // size: 0x10
    public class CombineToTopPlayableAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000294
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000064  // size: 0x20
    public class CustomControlPlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset, UnityEngine.Timeline.ICustomControlBehaviour
    {
        // Fields
        protected UnityEngine.Timeline.CustomControlPlayableBehaviour m_CustomControlBehaviour;  // 0x18

        // Properties
        UnityEngine.Timeline.ClipCaps clipCaps { get; /* RVA: 0x09D370C4 */ }
        UnityEngine.Timeline.ClipCaps extraClipCaps { get; /* RVA: 0x01002730 */ }

        // Methods
        // RVA: 0x09D36FBC  token: 0x6000297
        public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        // RVA: 0x09D37068  token: 0x6000298
        public virtual System.Void OnClipEnable(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D3700C  token: 0x6000299
        public virtual System.Void OnClipDisable(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x0286F540  token: 0x600029A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000065  // size: 0x10
    public class CustomControlPlayableBehaviour : UnityEngine.Playables.PlayableBehaviour, UnityEngine.Timeline.ICustomControlBehaviour
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600029B
        public virtual System.Void OnClipEnable(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x0350B670  token: 0x600029C
        public virtual System.Void OnClipDisable(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x0350B670  token: 0x600029D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000066
    public interface ICustomControlBehaviour
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600029E
        public virtual System.Void OnClipEnable(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: -1  // abstract  token: 0x600029F
        public virtual System.Void OnClipDisable(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }

    }

    // TypeToken: 0x2000067
    public interface IDynamicBinding
    {
    }

    // TypeToken: 0x2000068
    public interface ITimelineAnimationEventContextBinding
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60002A0
        public virtual System.Void RegisterAnimationEventRuntimeContext(System.Int32 playableId, UnityEngine.AnimationEvent[] animationEvents, UnityEngine.Timeline.AnimationPlayableAsset.AnimationEventTriggerMode triggerMode, System.Single curClipTime) { }
        // RVA: -1  // abstract  token: 0x60002A1
        public virtual System.Void UnregisterAnimationEventRuntimeContext(System.Int32 playableId, UnityEngine.AnimationEvent[] animationEvents) { }
        // RVA: -1  // abstract  token: 0x60002A2
        public virtual System.Void UpdateClipTime(System.Int32 playableId, System.Single curClipTime) { }

    }

    // TypeToken: 0x2000069  // size: 0x10
    public class SegmentLoopPlayableBehaviour : UnityEngine.Playables.PlayableBehaviour
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60002A3
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006A  // size: 0x20
    public class SegmentLoopPlayableClip : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
    {
        // Fields
        public System.String loopSegmentKey;  // 0x18

        // Properties
        UnityEngine.Timeline.ClipCaps clipCaps { get; /* RVA: 0x03D567A0 */ }

        // Methods
        // RVA: 0x09D3CAA8  token: 0x60002A4
        public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        // RVA: 0x0286F540  token: 0x60002A6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006B  // size: 0xC0
    public class SegmentLoopTrack : UnityEngine.Timeline.TrackAsset
    {
        // Methods
        // RVA: 0x09D3CB54  token: 0x60002A7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006C  // size: 0x18
    public sealed struct DiscreteTime : System.IComparable
    {
        // Fields
        private static System.Double k_Tick;  // const
        public static readonly UnityEngine.Timeline.DiscreteTime kMaxTime;  // static @ 0x0
        private readonly System.Int64 m_DiscreteTime;  // 0x10

        // Properties
        System.Double tickValue { get; /* RVA: 0x03D856B0 */ }

        // Methods
        // RVA: 0x03D51730  token: 0x60002A9
        private System.Void .ctor(System.Int64 time) { }
        // RVA: 0x09D37F00  token: 0x60002AA
        public System.Void .ctor(System.Double time) { }
        // RVA: 0x09D37EA8  token: 0x60002AB
        public System.Void .ctor(System.Int32 time) { }
        // RVA: 0x03D85680  token: 0x60002AC
        public UnityEngine.Timeline.DiscreteTime OneTickBefore() { }
        // RVA: 0x03D85670  token: 0x60002AD
        public UnityEngine.Timeline.DiscreteTime OneTickAfter() { }
        // RVA: 0x0339AE90  token: 0x60002AE
        public static UnityEngine.Timeline.DiscreteTime FromTicks(System.Int64 ticks) { }
        // RVA: 0x09D37BE0  token: 0x60002AF
        public virtual System.Int32 CompareTo(System.Object obj) { }
        // RVA: 0x022A9C20  token: 0x60002B0
        public System.Boolean Equals(UnityEngine.Timeline.DiscreteTime other) { }
        // RVA: 0x09D37CFC  token: 0x60002B1
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09D37C48  token: 0x60002B2
        private static System.Int64 DoubleToDiscreteTime(System.Double time) { }
        // RVA: 0x09D37DB8  token: 0x60002B3
        private static System.Int64 IntToDiscreteTime(System.Int32 time) { }
        // RVA: 0x03D85690  token: 0x60002B4
        private static System.Double ToDouble(System.Int64 time) { }
        // RVA: 0x09D37F5C  token: 0x60002B5
        public static System.Double op_Explicit(UnityEngine.Timeline.DiscreteTime b) { }
        // RVA: 0x09D37FAC  token: 0x60002B6
        public static UnityEngine.Timeline.DiscreteTime op_Explicit(System.Double time) { }
        // RVA: 0x09D37FD4  token: 0x60002B7
        public static UnityEngine.Timeline.DiscreteTime op_Implicit(System.Int32 time) { }
        // RVA: 0x0232CE30  token: 0x60002B8
        public static System.Boolean op_Equality(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs) { }
        // RVA: 0x09D37FFC  token: 0x60002B9
        public static System.Boolean op_Inequality(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs) { }
        // RVA: 0x0925CFFC  token: 0x60002BA
        public static System.Boolean op_LessThanOrEqual(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs) { }
        // RVA: 0x022E54E0  token: 0x60002BB
        public static System.Boolean op_GreaterThanOrEqual(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs) { }
        // RVA: 0x03D856C0  token: 0x60002BC
        public static UnityEngine.Timeline.DiscreteTime op_Subtraction(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs) { }
        // RVA: 0x09D37E60  token: 0x60002BD
        public virtual System.String ToString() { }
        // RVA: 0x03D70930  token: 0x60002BE
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09D37E08  token: 0x60002BF
        public static UnityEngine.Timeline.DiscreteTime Max(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs) { }
        // RVA: 0x09D37D68  token: 0x60002C0
        public static System.Int64 GetNearestTick(System.Double time) { }
        // RVA: 0x09D37E68  token: 0x60002C1
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200006D  // size: 0x30
    public class InfiniteRuntimeClip : UnityEngine.Timeline.RuntimeElement
    {
        // Fields
        private UnityEngine.Playables.Playable m_Playable;  // 0x18
        private static readonly System.Int64 kIntervalEnd;  // static @ 0x0
        private System.Int32 <optionIndex>k__BackingField;  // 0x28

        // Properties
        System.Int64 intervalStart { get; /* RVA: 0x01002730 */ }
        System.Int64 intervalEnd { get; /* RVA: 0x09D38B74 */ }
        System.Int32 optionIndex { get; /* RVA: 0x03D4EB90 */ set; /* RVA: 0x03D4EBA0 */ }
        System.Boolean enable { set; /* RVA: 0x09D38BC4 */ }

        // Methods
        // RVA: 0x03D51D90  token: 0x60002C2
        public System.Void .ctor(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x09D38A8C  token: 0x60002C8
        public virtual System.Void EvaluateAt(System.Double localTime, UnityEngine.Playables.FrameData frameData, UnityEngine.Timeline.ITimelineRootMarker timelineRoot) { }
        // RVA: 0x09D38A2C  token: 0x60002C9
        public virtual System.Void DisableAt(System.Double localTime, System.Double rootDuration, UnityEngine.Playables.FrameData frameData) { }
        // RVA: 0x09D38AE4  token: 0x60002CA
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200006E
    public interface IInterval
    {
        // Properties
        System.Int64 intervalStart { get; /* RVA: -1  // abstract */ }
        System.Int64 intervalEnd { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x200006F
    public interface IRuntimeReset
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60002CD
        public virtual System.Void RuntimeReset() { }

    }

    // TypeToken: 0x2000070
    public interface IOption
    {
    }

    // TypeToken: 0x2000071  // size: 0x28
    public sealed struct IntervalTreeNode
    {
        // Fields
        public System.Int64 center;  // 0x10
        public System.Int32 first;  // 0x18
        public System.Int32 last;  // 0x1c
        public System.Int32 left;  // 0x20
        public System.Int32 right;  // 0x24

    }

    // TypeToken: 0x2000072
    public class IntervalTree`1
    {
        // Fields
        private static System.Int32 kMinNodeSize;  // const
        private static System.Int32 kInvalidNode;  // const
        private static System.Int64 kCenterUnknown;  // const
        private readonly System.Collections.Generic.List<UnityEngine.Timeline.IntervalTree.Entry<T>> m_Entries;  // 0x0
        private readonly System.Collections.Generic.List<UnityEngine.Timeline.IntervalTreeNode> m_Nodes;  // 0x0
        private System.Boolean <dirty>k__BackingField;  // 0x0

        // Properties
        System.Boolean dirty { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60002D0
        public System.Void Add(T item) { }
        // RVA: -1  // not resolved  token: 0x60002D1
        public System.Void IntersectsWith(System.Int64 value, System.Collections.Generic.List<T> results) { }
        // RVA: -1  // not resolved  token: 0x60002D2
        public System.Void IntersectsWithRange(System.Int64 start, System.Int64 end, System.Collections.Generic.List<T> results) { }
        // RVA: -1  // not resolved  token: 0x60002D3
        public System.Void UpdateIntervals() { }
        // RVA: -1  // not resolved  token: 0x60002D4
        public System.Void RuntimeReset() { }
        // RVA: -1  // not resolved  token: 0x60002D5
        private System.Void Query(UnityEngine.Timeline.IntervalTreeNode intervalTreeNode, System.Int64 value, System.Collections.Generic.List<T> results) { }
        // RVA: -1  // not resolved  token: 0x60002D6
        private System.Void QueryRange(UnityEngine.Timeline.IntervalTreeNode intervalTreeNode, System.Int64 start, System.Int64 end, System.Collections.Generic.List<T> results) { }
        // RVA: -1  // not resolved  token: 0x60002D7
        public System.Void Rebuild() { }
        // RVA: -1  // not resolved  token: 0x60002D8
        private System.Int32 Rebuild(System.Int32 start, System.Int32 end) { }
        // RVA: -1  // not resolved  token: 0x60002D9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000074  // size: 0xA8
    public class RuntimeClip : UnityEngine.Timeline.RuntimeClipBase
    {
        // Fields
        public System.Double runtimeLocalTimeOffset;  // 0x20
        public System.Double runtimeMixOutTime;  // 0x28
        public System.Double runtimeMixOutDuration;  // 0x30
        public System.Double runtimeMixInTime;  // 0x38
        public System.Double runtimeMixInDuration;  // 0x40
        public System.Boolean runtimeLooping;  // 0x48
        public System.Boolean runtimeLoopingMute;  // 0x49
        private System.Boolean _isInMixIn;  // 0x4a
        private System.Boolean _isMixIn;  // 0x4b
        private System.Boolean _hadIgniteOnce;  // 0x4c
        private System.Double lastTickTime;  // 0x50
        private System.Boolean _onlyDeltaTimeLooped;  // 0x58
        private System.Int32 <optionIndex>k__BackingField;  // 0x5c
        private System.Int32 m_originalPort;  // 0x60
        private System.Boolean _hadClipEnabled;  // 0x64
        public System.Boolean isRuntimeJumpExhaust;  // 0x65
        private UnityEngine.Timeline.TimelineClip m_Clip;  // 0x68
        private UnityEngine.Playables.Playable m_Playable;  // 0x70
        private UnityEngine.Playables.Playable m_ParentMixer;  // 0x80
        private UnityEngine.Playables.Playable m_RootPlayable;  // 0x90
        private System.Boolean m_enabled;  // 0xa0

        // Properties
        System.Int32 optionIndex { get; /* RVA: 0x03D4EEF0 */ set; /* RVA: 0x03D4EF40 */ }
        System.Boolean dynamicLink { get; /* RVA: 0x09D3C164 */ }
        System.Boolean customBehaviourControl { get; /* RVA: 0x09D3C110 */ }
        System.Double start { get; /* RVA: 0x09D3C2B8 */ }
        System.Double end { get; /* RVA: 0x09D3C18C */ }
        System.Double duration { get; /* RVA: 0x09D3C138 */ }
        UnityEngine.Timeline.TimelineClip clip { get; /* RVA: 0x03D4EAB0 */ }
        UnityEngine.Playables.Playable mixer { get; /* RVA: 0x03D5AAF0 */ }
        UnityEngine.Playables.Playable playable { get; /* RVA: 0x03D5AAE0 */ }
        System.Int64 intervalStart { get; /* RVA: 0x09D3C25C */ }
        System.Int64 intervalEnd { get; /* RVA: 0x09D3C1E4 */ }
        System.Boolean enable { set; /* RVA: 0x09D3C2E4 */ }
        System.Boolean isEnabling { get; /* RVA: 0x03D50A40 */ }

        // Methods
        // RVA: 0x09D3C0B8  token: 0x60002E1
        public System.Void .ctor(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, System.Int32 originalPort) { }
        // RVA: 0x09D3B1C8  token: 0x60002E2
        private System.Void Create(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, System.Int32 originalPort) { }
        // RVA: 0x09D3BE10  token: 0x60002EA
        public System.Void SetTime(System.Double time) { }
        // RVA: 0x09D3BDB8  token: 0x60002EB
        public System.Void SetDuration(System.Double duration) { }
        // RVA: 0x09D3B47C  token: 0x60002EC
        public virtual System.Void EvaluateAt(System.Double localTime, UnityEngine.Playables.FrameData frameData, UnityEngine.Timeline.ITimelineRootMarker timelineRoot) { }
        // RVA: 0x09D3B7CC  token: 0x60002ED
        public System.Single EvaluateMixIn(System.Single localTime) { }
        // RVA: 0x09D3B888  token: 0x60002EE
        public System.Single EvaluateMixOut(System.Single localTime) { }
        // RVA: 0x09D3BE68  token: 0x60002EF
        public System.Double ToLocalTime(System.Double localTime, UnityEngine.Playables.FrameData frameData, UnityEngine.Timeline.ITimelineRootMarker timelineRoot) { }
        // RVA: 0x09D3B2DC  token: 0x60002F0
        public virtual System.Void DisableAt(System.Double localTime, System.Double rootDuration, UnityEngine.Playables.FrameData frameData) { }
        // RVA: 0x09D3B17C  token: 0x60002F1
        public virtual System.Boolean CheckIfRuntimeTimeLoop(System.Boolean& canSkip, System.Double& reverseTime) { }
        // RVA: 0x09D3B050  token: 0x60002F2
        public virtual System.Boolean CheckIfRuntimeTimeJump(System.Double& jumpTime, System.Boolean& isReverseJump) { }
        // RVA: 0x09D3BB28  token: 0x60002F3
        public virtual System.Void RuntimeLoopOver() { }
        // RVA: 0x09D3BAF8  token: 0x60002F4
        public virtual System.Void RuntimeLoopOn() { }
        // RVA: 0x09D3B918  token: 0x60002F5
        public virtual System.Void GetRuntimeCrossFadeDuration(System.Double& duration, System.Double& jumpTargetTime) { }
        // RVA: 0x09D3BA3C  token: 0x60002F6
        public virtual System.Void RecalculateRuntimeCrossFadeMixIn(System.Double mixInTime, System.Double mixInDuration) { }
        // RVA: 0x09D3BA8C  token: 0x60002F7
        public virtual System.Void RecalculateRuntimeCrossFadeMixOut(System.Double curTime, System.Double mixStartTime, System.Double mixDuration) { }
        // RVA: 0x09D3BFF0  token: 0x60002F8
        public System.Boolean TryGetJumpClip(Beyond.Gameplay.Core.RuntimeJumpClip& jumpClip) { }
        // RVA: 0x09D3BB58  token: 0x60002F9
        public virtual System.Void RuntimeReset() { }

    }

    // TypeToken: 0x2000075  // size: 0x20
    public abstract class RuntimeClipBase : UnityEngine.Timeline.RuntimeElement
    {
        // Fields
        private System.Int32 <optionIndex>k__BackingField;  // 0x18

        // Properties
        System.Double start { get; /* RVA: -1  // abstract */ }
        System.Double duration { get; /* RVA: -1  // abstract */ }
        System.Double end { get; /* RVA: -1  // abstract */ }
        System.Int32 optionIndex { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }
        System.Int64 intervalStart { get; /* RVA: 0x09D3AFF4 */ }
        System.Int64 intervalEnd { get; /* RVA: 0x09D3AF7C */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000301
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000076  // size: 0x18
    public abstract class RuntimeElement : UnityEngine.Timeline.IInterval, UnityEngine.Timeline.IOption, UnityEngine.Timeline.IRuntimeReset
    {
        // Fields
        private System.Int32 <intervalBit>k__BackingField;  // 0x10
        private System.Boolean <isLooping>k__BackingField;  // 0x14

        // Properties
        System.Int64 intervalStart { get; /* RVA: -1  // abstract */ }
        System.Int64 intervalEnd { get; /* RVA: -1  // abstract */ }
        System.Int32 optionIndex { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        System.Int32 intervalBit { get; /* RVA: 0x03D4E340 */ set; /* RVA: 0x010410F0 */ }
        System.Boolean isLooping { get; /* RVA: 0x03D58C00 */ set; /* RVA: 0x03D58C20 */ }
        System.Boolean enable { set; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x600030B
        public virtual System.Void EvaluateAt(System.Double localTime, UnityEngine.Playables.FrameData frameData, UnityEngine.Timeline.ITimelineRootMarker timelineRoot) { }
        // RVA: -1  // abstract  token: 0x600030C
        public virtual System.Void DisableAt(System.Double localTime, System.Double rootDuration, UnityEngine.Playables.FrameData frameData) { }
        // RVA: 0x03D857E0  token: 0x600030D
        public virtual System.Boolean CheckIfRuntimeTimeLoop(System.Boolean& canSkip, System.Double& reverseTime) { }
        // RVA: 0x03D857D0  token: 0x600030E
        public virtual System.Boolean CheckIfRuntimeTimeJump(System.Double& jumpTime, System.Boolean& isReverseJump) { }
        // RVA: 0x0350B670  token: 0x600030F
        public virtual System.Void RuntimeLoopOver() { }
        // RVA: 0x0350B670  token: 0x6000310
        public virtual System.Void RuntimeLoopOn() { }
        // RVA: 0x03D857F0  token: 0x6000311
        public virtual System.Void GetRuntimeCrossFadeDuration(System.Double& duration, System.Double& jumpTargetTime) { }
        // RVA: 0x0350B670  token: 0x6000312
        public virtual System.Void RecalculateRuntimeCrossFadeMixIn(System.Double mixInTime, System.Double mixDuration) { }
        // RVA: 0x0350B670  token: 0x6000313
        public virtual System.Void RecalculateRuntimeCrossFadeMixOut(System.Double curTime, System.Double mixStartTime, System.Double mixDuration) { }
        // RVA: 0x0350B670  token: 0x6000314
        public virtual System.Void RuntimeReset() { }
        // RVA: 0x0350B670  token: 0x6000315
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000077  // size: 0x60
    public class ScheduleRuntimeClip : UnityEngine.Timeline.RuntimeClipBase
    {
        // Fields
        private UnityEngine.Timeline.TimelineClip m_Clip;  // 0x20
        private UnityEngine.Playables.Playable m_Playable;  // 0x28
        private UnityEngine.Playables.Playable m_ParentMixer;  // 0x38
        private System.Double m_StartDelay;  // 0x48
        private System.Double m_FinishTail;  // 0x50
        private System.Boolean m_Started;  // 0x58

        // Properties
        System.Double start { get; /* RVA: 0x09D3C938 */ }
        System.Double duration { get; /* RVA: 0x09D3C8B4 */ }
        System.Double end { get; /* RVA: 0x09D3C8FC */ }
        UnityEngine.Timeline.TimelineClip clip { get; /* RVA: 0x03D4EB40 */ }
        UnityEngine.Playables.Playable mixer { get; /* RVA: 0x03D5A120 */ }
        UnityEngine.Playables.Playable playable { get; /* RVA: 0x03D59E20 */ }
        System.Boolean enable { set; /* RVA: 0x09D3C9B0 */ }

        // Methods
        // RVA: 0x09D3C864  token: 0x600031C
        public System.Void .ctor(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, System.Double startDelay, System.Double finishTail) { }
        // RVA: 0x09D3C520  token: 0x600031D
        private System.Void Create(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, System.Double startDelay, System.Double finishTail) { }
        // RVA: 0x09D3C5B8  token: 0x600031F
        public virtual System.Void EvaluateAt(System.Double localTime, UnityEngine.Playables.FrameData frameData, UnityEngine.Timeline.ITimelineRootMarker timelineRoot) { }
        // RVA: 0x05755818  token: 0x6000320
        public virtual System.Void DisableAt(System.Double localTime, System.Double rootDuration, UnityEngine.Playables.FrameData frameData) { }

    }

    // TypeToken: 0x2000078
    public interface IMarker
    {
        // Properties
        System.Double time { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }
        UnityEngine.Timeline.TrackAsset parent { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000324
        public virtual System.Void Initialize(UnityEngine.Timeline.TrackAsset parent) { }

    }

    // TypeToken: 0x2000079
    public interface INotificationOptionProvider
    {
        // Properties
        UnityEngine.Timeline.NotificationFlags flags { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x200007A  // size: 0x28
    public abstract class Marker : UnityEngine.ScriptableObject, UnityEngine.Timeline.IMarker
    {
        // Fields
        private System.Double m_Time;  // 0x18
        private UnityEngine.Timeline.TrackAsset <parent>k__BackingField;  // 0x20

        // Properties
        UnityEngine.Timeline.TrackAsset parent { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        System.Double time { get; /* RVA: 0x03D4EBD0 */ set; /* RVA: 0x09D39494 */ }

        // Methods
        // RVA: 0x09D39374  token: 0x600032A
        private virtual System.Void UnityEngine.Timeline.IMarker.Initialize(UnityEngine.Timeline.TrackAsset parentTrack) { }
        // RVA: 0x0350B670  token: 0x600032B
        public virtual System.Void OnInitialize(UnityEngine.Timeline.TrackAsset aPent) { }
        // RVA: 0x0286F540  token: 0x600032C
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200007B  // size: 0x28
    public sealed struct MarkerList : UnityEngine.ISerializationCallbackReceiver
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.ScriptableObject> m_Objects;  // 0x10
        private System.Collections.Generic.List<UnityEngine.Timeline.IMarker> m_Cache;  // 0x18
        private System.Boolean m_CacheDirty;  // 0x20
        private System.Boolean m_HasNotifications;  // 0x21

        // Properties
        System.Collections.Generic.List<UnityEngine.Timeline.IMarker> markers { get; /* RVA: 0x04275B08 */ }
        System.Int32 Count { get; /* RVA: 0x09D39128 */ }
        UnityEngine.Timeline.IMarker Item { get; /* RVA: 0x09D39170 */ }

        // Methods
        // RVA: 0x03151860  token: 0x600032E
        public System.Void .ctor(System.Int32 capacity) { }
        // RVA: 0x09D38C28  token: 0x600032F
        public System.Void Add(UnityEngine.ScriptableObject item) { }
        // RVA: 0x09D38F74  token: 0x6000330
        public System.Boolean Remove(UnityEngine.Timeline.IMarker item) { }
        // RVA: 0x09D39078  token: 0x6000331
        public System.Boolean Remove(UnityEngine.ScriptableObject item, UnityEngine.Timeline.TimelineAsset timelineAsset, UnityEngine.Playables.PlayableAsset thingToDirty) { }
        // RVA: 0x09D38CAC  token: 0x6000332
        public System.Void Clear() { }
        // RVA: 0x04275B08  token: 0x6000333
        public System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetMarkers() { }
        // RVA: 0x020C61B0  token: 0x6000336
        public System.Collections.Generic.List<UnityEngine.ScriptableObject> GetRawMarkerList() { }
        // RVA: 0x09D38CF8  token: 0x6000337
        public UnityEngine.Timeline.IMarker CreateMarker(System.Type type, System.Double time, UnityEngine.Timeline.TrackAsset owner) { }
        // RVA: 0x09D38F58  token: 0x6000338
        public System.Boolean HasNotifications() { }
        // RVA: 0x0350B670  token: 0x6000339
        private virtual System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        // RVA: 0x01168960  token: 0x600033A
        private virtual System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        // RVA: 0x03151940  token: 0x600033B
        private System.Void BuildCache() { }

    }

    // TypeToken: 0x200007C  // size: 0xC0
    public class MarkerTrack : UnityEngine.Timeline.TrackAsset, Events.INotificationTrack
    {
        // Properties
        System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> outputs { get; /* RVA: 0x09D39218 */ }

        // Methods
        // RVA: 0x09D391CC  token: 0x600033D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007D  // size: 0x10
    public class CustomSignalEventDrawer : UnityEngine.PropertyAttribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600033E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007E  // size: 0x18
    public class SignalAsset : UnityEngine.ScriptableObject
    {
        // Fields
        private static System.Action<UnityEngine.Timeline.SignalAsset> OnEnableCallback;  // static @ 0x0

        // Events
        event System.Action<UnityEngine.Timeline.SignalAsset> OnEnableCallback;

        // Methods
        // RVA: 0x09D3CBA0  token: 0x6000341
        private System.Void OnEnable() { }
        // RVA: 0x0286F540  token: 0x6000342
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007F  // size: 0x38
    public class SignalEmitter : UnityEngine.Timeline.Marker, UnityEngine.Playables.INotification, UnityEngine.Timeline.INotificationOptionProvider
    {
        // Fields
        private System.Boolean m_Retroactive;  // 0x28
        private System.Boolean m_EmitOnce;  // 0x29
        private UnityEngine.Timeline.SignalAsset m_Asset;  // 0x30

        // Properties
        System.Boolean retroactive { get; /* RVA: 0x03D4ED50 */ set; /* RVA: 0x03D4ED60 */ }
        System.Boolean emitOnce { get; /* RVA: 0x03D4F2A0 */ set; /* RVA: 0x03D4F2B0 */ }
        UnityEngine.Timeline.SignalAsset asset { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }
        UnityEngine.PropertyName UnityEngine.Playables.INotification.id { get; /* RVA: 0x09D3CD28 */ }
        UnityEngine.Timeline.NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.flags { get; /* RVA: 0x09D3CDCC */ }

        // Methods
        // RVA: 0x0286F540  token: 0x600034B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000080  // size: 0x20
    public class SignalReceiver : UnityEngine.MonoBehaviour, UnityEngine.Playables.INotificationReceiver
    {
        // Fields
        private UnityEngine.Timeline.SignalReceiver.EventKeyValue m_Events;  // 0x18

        // Methods
        // RVA: 0x09D3D4E8  token: 0x600034C
        public virtual System.Void OnNotify(UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, System.Object context) { }
        // RVA: 0x09D3CE60  token: 0x600034D
        public System.Void AddReaction(UnityEngine.Timeline.SignalAsset asset, UnityEngine.Events.UnityEvent reaction) { }
        // RVA: 0x09D3CDF4  token: 0x600034E
        public System.Int32 AddEmptyReaction(UnityEngine.Events.UnityEvent reaction) { }
        // RVA: 0x09D3D670  token: 0x600034F
        public System.Void Remove(UnityEngine.Timeline.SignalAsset asset) { }
        // RVA: 0x092E734C  token: 0x6000350
        public System.Collections.Generic.IEnumerable<UnityEngine.Timeline.SignalAsset> GetRegisteredSignals() { }
        // RVA: 0x09D3D3F4  token: 0x6000351
        public UnityEngine.Events.UnityEvent GetReaction(UnityEngine.Timeline.SignalAsset key) { }
        // RVA: 0x09D3D2F0  token: 0x6000352
        public System.Int32 Count() { }
        // RVA: 0x09D3D088  token: 0x6000353
        public System.Void ChangeSignalAtIndex(System.Int32 idx, UnityEngine.Timeline.SignalAsset newKey) { }
        // RVA: 0x09D3D5C8  token: 0x6000354
        public System.Void RemoveAtIndex(System.Int32 idx) { }
        // RVA: 0x09D3CFBC  token: 0x6000355
        public System.Void ChangeReactionAtIndex(System.Int32 idx, UnityEngine.Events.UnityEvent reaction) { }
        // RVA: 0x09D3D338  token: 0x6000356
        public UnityEngine.Events.UnityEvent GetReactionAtIndex(System.Int32 idx) { }
        // RVA: 0x09D3D42C  token: 0x6000357
        public UnityEngine.Timeline.SignalAsset GetSignalAssetAtIndex(System.Int32 idx) { }
        // RVA: 0x0350B670  token: 0x6000358
        private System.Void OnEnable() { }
        // RVA: 0x09D3D738  token: 0x6000359
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000082  // size: 0xC0
    public class SignalTrack : UnityEngine.Timeline.MarkerTrack
    {
        // Methods
        // RVA: 0x09D3D7A8  token: 0x6000361
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000083  // size: 0x10
    public static class TrackAssetExtensions
    {
    }

    // TypeToken: 0x2000084  // size: 0xC8
    public class GroupTrack : UnityEngine.Timeline.TrackAsset
    {
        // Fields
        public Beyond.PackageBridge.Timeline.TimelineConditionBase enableOnCondition;  // 0xc0

        // Properties
        System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> outputs { get; /* RVA: 0x09D38950 */ }

        // Methods
        // RVA: 0x09D388C8  token: 0x6000362
        public System.Void CalculateRuntimeMuted() { }
        // RVA: 0x0115F4C0  token: 0x6000363
        private virtual System.Boolean CanCompileClips() { }
        // RVA: 0x03151580  token: 0x6000365
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000085
    public interface ILayerable
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000366
        public virtual UnityEngine.Playables.Playable CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount) { }

    }

    // TypeToken: 0x2000086
    public interface ITimeDilationListener
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000367
        public virtual System.Void OnTimeDilationChanged(System.Single timeDilation) { }

    }

    // TypeToken: 0x2000087  // size: 0x20
    public class ActivationControlPlayable : UnityEngine.Timeline.ControlPlayableBehaviour
    {
        // Fields
        public UnityEngine.GameObject gameObject;  // 0x10
        public UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState postPlayback;  // 0x18
        private UnityEngine.Timeline.ActivationControlPlayable.InitialState m_InitialState;  // 0x1c

        // Methods
        // RVA: 0x09D35BA8  token: 0x6000368
        public static UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.ActivationControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject gameObject, UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState postPlaybackState) { }
        // RVA: 0x09D35D68  token: 0x6000369
        public virtual System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D35CDC  token: 0x600036A
        public virtual System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D35EF8  token: 0x600036B
        public virtual System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object userData) { }
        // RVA: 0x09D35DD8  token: 0x600036C
        public virtual System.Void OnGraphStart(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x09D35E54  token: 0x600036D
        public virtual System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x0350B670  token: 0x600036E
        public virtual System.Void RuntimeReset() { }
        // RVA: 0x03D56C80  token: 0x600036F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008A  // size: 0x30
    public class AnimationEventRuntimeContextPlayable : UnityEngine.Playables.PlayableBehaviour
    {
        // Fields
        private UnityEngine.Timeline.ITimelineAnimationEventContextBinding m_TimelineAnimationEventContextBinding;  // 0x10
        private UnityEngine.Timeline.AnimationPlayableAsset.AnimationEventTriggerMode m_TriggerMode;  // 0x18
        private UnityEngine.AnimationEvent[] m_CachedAnimationEvents;  // 0x20
        private System.Single m_ClipDuration;  // 0x28
        private System.Boolean m_IsRegistered;  // 0x2c
        private System.Boolean m_HasRegisteredOnce;  // 0x2d

        // Methods
        // RVA: 0x09D36A84  token: 0x6000370
        public static UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.AnimationEventRuntimeContextPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding, UnityEngine.Timeline.AnimationPlayableAsset.AnimationEventTriggerMode triggerMode, UnityEngine.AnimationEvent[] cachedAnimationEvents, System.Single clipDuration, System.Int32 inputCount) { }
        // RVA: 0x09D36BC8  token: 0x6000371
        public System.Void Initialize(UnityEngine.Timeline.ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding, UnityEngine.Timeline.AnimationPlayableAsset.AnimationEventTriggerMode triggerMode, UnityEngine.AnimationEvent[] cachedAnimationEvents, System.Single clipDuration) { }
        // RVA: 0x09D36C08  token: 0x6000372
        public virtual System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D36D38  token: 0x6000373
        public virtual System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x0350B670  token: 0x6000374
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008B  // size: 0x18
    public class BasicPlayableBehaviour : UnityEngine.ScriptableObject, UnityEngine.Playables.IPlayableAsset, UnityEngine.Playables.IPlayableBehaviour
    {
        // Properties
        System.Double duration { get; /* RVA: 0x09D36F1C */ }
        System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> outputs { get; /* RVA: 0x09D36F6C */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000377
        public virtual System.Void OnGraphStart(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x0350B670  token: 0x6000378
        public virtual System.Void OnGraphStop(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x0350B670  token: 0x6000379
        public virtual System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x0350B670  token: 0x600037A
        public virtual System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x0350B670  token: 0x600037B
        public virtual System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x0350B670  token: 0x600037C
        public virtual System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x0350B670  token: 0x600037D
        public virtual System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x0350B670  token: 0x600037E
        public virtual System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        // RVA: 0x09D36E5C  token: 0x600037F
        public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        // RVA: 0x0286F540  token: 0x6000380
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008C  // size: 0x10
    public class ControlPlayableBehaviour : UnityEngine.Playables.PlayableBehaviour, UnityEngine.Timeline.IBehaviourRuntimeReset
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000381
        public virtual System.Void RuntimeReset() { }
        // RVA: 0x0350B670  token: 0x6000382
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008D  // size: 0x38
    public class DirectorControlPlayable : UnityEngine.Timeline.ControlPlayableBehaviour
    {
        // Fields
        public UnityEngine.Playables.PlayableDirector director;  // 0x10
        public UnityEngine.Timeline.ITimelineRootMarker rootMarker;  // 0x18
        private static System.Single SYNC_START_FORBID_THRESHOLD;  // const
        private System.Boolean m_SyncTime;  // 0x20
        private System.Double m_AssetDuration;  // 0x28
        private UnityEngine.Timeline.TimelinePlayable m_TimelinePlayable;  // 0x30

        // Methods
        // RVA: 0x09D370E0  token: 0x6000383
        public static UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.DirectorControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableDirector director) { }
        // RVA: 0x09D374B8  token: 0x6000384
        public virtual System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x09D37554  token: 0x6000385
        public virtual System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D37400  token: 0x6000386
        public virtual System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D37348  token: 0x6000387
        public virtual System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D3777C  token: 0x6000388
        public virtual System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        // RVA: 0x09D378AC  token: 0x6000389
        private System.Void SyncSpeed(System.Double speed) { }
        // RVA: 0x09D379F8  token: 0x600038A
        private System.Void SyncStart(UnityEngine.Playables.PlayableGraph graph, System.Double time) { }
        // RVA: 0x09D37B1C  token: 0x600038B
        private System.Void SyncStop(UnityEngine.Playables.PlayableGraph graph, System.Double time) { }
        // RVA: 0x0350B670  token: 0x600038C
        public virtual System.Void RuntimeReset() { }
        // RVA: 0x03D85660  token: 0x600038D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008E
    public interface ITimeControl
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600038E
        public virtual System.Void SetTime(System.Double time) { }
        // RVA: -1  // abstract  token: 0x600038F
        public virtual System.Void OnControlTimeStart() { }
        // RVA: -1  // abstract  token: 0x6000390
        public virtual System.Void OnControlTimeStop() { }

    }

    // TypeToken: 0x200008F  // size: 0x12
    public sealed struct NotificationFlags
    {
        // Fields
        public System.Int16 value__;  // 0x10
        public static UnityEngine.Timeline.NotificationFlags TriggerInEditMode;  // const
        public static UnityEngine.Timeline.NotificationFlags Retroactive;  // const
        public static UnityEngine.Timeline.NotificationFlags TriggerOnce;  // const

    }

    // TypeToken: 0x2000090  // size: 0x40
    public class ParticleControlPlayable : UnityEngine.Timeline.ControlPlayableBehaviour, UnityEngine.Timeline.ITimeDilationListener
    {
        // Fields
        private System.Single m_LastPlayableTime;  // 0x10
        private System.Single m_LastParticleTime;  // 0x14
        private System.UInt32 m_RandomSeed;  // 0x18
        private System.Boolean m_forceRuntimeSimulate;  // 0x1c
        private System.Single m_clipIn;  // 0x20
        private System.Boolean m_hadInitialized;  // 0x24
        private System.Single originalSimulateSpeed;  // 0x28
        private System.Single simulateSpeedModifier;  // 0x2c
        private UnityEngine.ParticleSystem <particleSystem>k__BackingField;  // 0x30
        private System.Boolean m_hadIgnite;  // 0x38
        private System.Boolean m_hadSimulate;  // 0x39
        private System.Boolean m_hadPlayed;  // 0x3a

        // Properties
        UnityEngine.ParticleSystem particleSystem { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }
        System.Boolean shouldSimulate { get; /* RVA: 0x09D3A474 */ }

        // Methods
        // RVA: 0x09D399EC  token: 0x6000391
        public static UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.ParticleControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.ParticleSystem component, System.UInt32 randomSeed, System.Single clipIn, System.Single speedMultiplier, System.Boolean forceRuntimeSimulate) { }
        // RVA: 0x09D39B80  token: 0x6000395
        public System.Void Initialize(UnityEngine.ParticleSystem ps, System.UInt32 randomSeed, System.Single clipIn, System.Single simulateSpeed, System.Boolean forceRuntimeSimulate) { }
        // RVA: 0x09D39EF4  token: 0x6000396
        private System.Void SetOriginalSimulateSpeed(UnityEngine.ParticleSystem particleSystem, System.Double simulateSpeed) { }
        // RVA: 0x09D3A02C  token: 0x6000397
        private static System.Void SetRandomSeed(UnityEngine.ParticleSystem particleSystem, System.UInt32 randomSeed) { }
        // RVA: 0x09D39D50  token: 0x6000398
        public virtual System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData data) { }
        // RVA: 0x09D3A400  token: 0x6000399
        private System.Void _SimulateParticle(System.Single time, System.Single particleTime, System.Boolean previewMode) { }
        // RVA: 0x03D85780  token: 0x600039A
        public virtual System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D3A2E8  token: 0x600039B
        private System.Void _PlayOrQueuedParticleSystem() { }
        // RVA: 0x09D39C40  token: 0x600039C
        public virtual System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D3A128  token: 0x600039D
        private System.Void Simulate(System.Single time, System.Boolean restart) { }
        // RVA: 0x03D85790  token: 0x600039E
        public virtual System.Void RuntimeReset() { }
        // RVA: 0x09D39CFC  token: 0x600039F
        public virtual System.Void OnTimeDilationChanged(System.Single timeScale) { }
        // RVA: 0x03D857A0  token: 0x60003A0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000091  // size: 0x18
    public class PrefabControlPlayable : UnityEngine.Playables.PlayableBehaviour
    {
        // Fields
        private UnityEngine.GameObject m_Instance;  // 0x10

        // Properties
        UnityEngine.GameObject prefabInstance { get; /* RVA: 0x020B7B20 */ }

        // Methods
        // RVA: 0x09D3A84C  token: 0x60003A1
        public static UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.PrefabControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject prefabGameObject, UnityEngine.Transform parentTransform) { }
        // RVA: 0x09D3A97C  token: 0x60003A3
        public UnityEngine.GameObject Initialize(UnityEngine.GameObject prefabGameObject, UnityEngine.Transform parentTransform) { }
        // RVA: 0x09D3ACCC  token: 0x60003A4
        public virtual System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x09D3AC5C  token: 0x60003A5
        public virtual System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D3ABD0  token: 0x60003A6
        public virtual System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D3AD54  token: 0x60003A7
        private static System.Void SetHideFlagsRecursive(UnityEngine.GameObject gameObject) { }
        // RVA: 0x0350B670  token: 0x60003A8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000092  // size: 0x20
    public class TimeControlPlayable : UnityEngine.Timeline.ControlPlayableBehaviour
    {
        // Fields
        private UnityEngine.Timeline.ITimeControl m_timeControl;  // 0x10
        private System.Boolean m_started;  // 0x18

        // Methods
        // RVA: 0x09D3D7B0  token: 0x60003A9
        public static UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.ITimeControl timeControl) { }
        // RVA: 0x0426FEE0  token: 0x60003AA
        public System.Void Initialize(UnityEngine.Timeline.ITimeControl timeControl) { }
        // RVA: 0x09D3D948  token: 0x60003AB
        public virtual System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D3D8F4  token: 0x60003AC
        public virtual System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D3D8A0  token: 0x60003AD
        public virtual System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x0350B670  token: 0x60003AE
        public virtual System.Void RuntimeReset() { }
        // RVA: 0x0350B670  token: 0x60003AF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000093  // size: 0x38
    public class TimeNotificationBehaviour : UnityEngine.Playables.PlayableBehaviour
    {
        // Fields
        private readonly System.Collections.Generic.List<UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry> m_Notifications;  // 0x10
        private System.Double m_PreviousTime;  // 0x18
        private System.Boolean m_NeedSortNotifications;  // 0x20
        private System.Boolean m_IsManualUpdate;  // 0x21
        private UnityEngine.Playables.Playable m_TimeSource;  // 0x28

        // Properties
        UnityEngine.Playables.Playable timeSource { set; /* RVA: 0x03D59E30 */ }
        System.Boolean isManualUpdate { set; /* RVA: 0x03D4F080 */ }

        // Methods
        // RVA: 0x09D3DAA4  token: 0x60003B2
        public static UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> Create(UnityEngine.Playables.PlayableGraph graph, System.Double duration, UnityEngine.Playables.DirectorWrapMode loopMode) { }
        // RVA: 0x09D3D9C0  token: 0x60003B3
        public System.Void AddNotification(System.Double time, UnityEngine.Playables.INotification payload, UnityEngine.Timeline.NotificationFlags flags) { }
        // RVA: 0x09D3DD5C  token: 0x60003B4
        public virtual System.Void OnGraphStart(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x09D3DBB4  token: 0x60003B5
        public virtual System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D3DEFC  token: 0x60003B6
        public virtual System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D3E2D0  token: 0x60003B7
        private System.Void SortNotifications() { }
        // RVA: 0x09D3DA74  token: 0x60003B8
        private static System.Boolean CanRestoreNotification(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e, UnityEngine.Playables.FrameData info, System.Double currentTime, System.Double previousTime) { }
        // RVA: 0x09D3E4D8  token: 0x60003B9
        private System.Void TriggerNotificationsInRange(System.Double start, System.Double end, UnityEngine.Playables.FrameData info, UnityEngine.Playables.Playable playable, System.Boolean checkState) { }
        // RVA: 0x09D3E3F8  token: 0x60003BA
        private System.Void SyncDurationWithExternalSource(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x09D3E6B8  token: 0x60003BB
        private static System.Void Trigger_internal(UnityEngine.Playables.Playable playable, UnityEngine.Playables.PlayableOutput output, UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry& e) { }
        // RVA: 0x03D557C0  token: 0x60003BC
        private static System.Void Restore_internal(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry& e) { }
        // RVA: 0x09D3E734  token: 0x60003BD
        private static System.Double _GetPlayableTime(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x09D3E7F8  token: 0x60003BE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000096  // size: 0x28
    public class CommunicatorParam
    {
        // Fields
        public UnityEngine.Timeline.IScriptAnimationJobSync jobSync;  // 0x10
        public System.String uniqueId;  // 0x18
        public System.Boolean lookAtUseAdditive;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x60003C5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000097
    public interface IAutoGenMono
    {
    }

    // TypeToken: 0x2000098
    public interface IBehaviourRuntimeReset
    {
    }

    // TypeToken: 0x2000099
    public interface IScriptAnimationJobSync : UnityEngine.Timeline.IAutoGenMono
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60003C6
        public virtual System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: -1  // abstract  token: 0x60003C7
        public virtual System.Void CalcLayerMainStream(System.Single deltaTime) { }
        // RVA: -1  // abstract  token: 0x60003C8
        public virtual System.Void ResetCloth(System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> activeRuntimeElements, System.Boolean useSoftReset, System.Boolean keepPose, System.Boolean useRelativeTeleport) { }

    }

    // TypeToken: 0x200009A  // size: 0x20
    public sealed struct TimelineScriptAnimationJob : UnityEngine.Animations.IAnimationJob
    {
        // Fields
        public UnityEngine.Timeline.IScriptAnimationJobSync bindedScriptAnimationJobSync;  // 0x10
        public UnityEngine.Animator bindedAnimator;  // 0x18

        // Methods
        // RVA: 0x032C7BF0  token: 0x60003C9
        public System.Void .ctor(UnityEngine.Timeline.IScriptAnimationJobSync job, UnityEngine.Animator animator) { }
        // RVA: 0x0350B670  token: 0x60003CA
        public virtual System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D45FE0  token: 0x60003CB
        public virtual System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x200009B  // size: 0xC0
    public class PlayableTrack : UnityEngine.Timeline.TrackAsset
    {
        // Methods
        // RVA: 0x09D3A768  token: 0x60003CC
        protected virtual System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip) { }
        // RVA: 0x09D3A800  token: 0x60003CD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200009C  // size: 0x10
    public class TrackMediaType : System.Attribute
    {
    }

    // TypeToken: 0x200009D  // size: 0x20
    public class TrackClipTypeAttribute : System.Attribute
    {
        // Fields
        public readonly System.Type inspectedType;  // 0x10
        public readonly System.Boolean allowAutoCreate;  // 0x18

        // Methods
        // RVA: 0x03809A70  token: 0x60003CE
        public System.Void .ctor(System.Type clipClass) { }
        // RVA: 0x03D4D900  token: 0x60003CF
        public System.Void .ctor(System.Type clipClass, System.Boolean allowAutoCreate) { }

    }

    // TypeToken: 0x200009E  // size: 0x10
    public class NotKeyableAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60003D0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200009F  // size: 0x14
    public sealed struct TrackBindingFlags
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.TrackBindingFlags None;  // const
        public static UnityEngine.Timeline.TrackBindingFlags AllowCreateComponent;  // const
        public static UnityEngine.Timeline.TrackBindingFlags All;  // const

    }

    // TypeToken: 0x20000A0  // size: 0x20
    public class TrackBindingTypeAttribute : System.Attribute
    {
        // Fields
        public readonly System.Type type;  // 0x10
        public readonly UnityEngine.Timeline.TrackBindingFlags flags;  // 0x18

        // Methods
        // RVA: 0x038BA920  token: 0x60003D1
        public System.Void .ctor(System.Type type) { }
        // RVA: 0x02738A30  token: 0x60003D2
        public System.Void .ctor(System.Type type, UnityEngine.Timeline.TrackBindingFlags flags) { }

    }

    // TypeToken: 0x20000A1  // size: 0x20
    public class SupportsChildTracksAttribute : System.Attribute
    {
        // Fields
        public readonly System.Type childType;  // 0x10
        public readonly System.Int32 levels;  // 0x18

        // Methods
        // RVA: 0x03CBB760  token: 0x60003D3
        public System.Void .ctor(System.Type childType, System.Int32 levels) { }

    }

    // TypeToken: 0x20000A2  // size: 0x10
    public class IgnoreOnPlayableTrackAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60003D4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A3  // size: 0x18
    public class TimeFieldAttribute : UnityEngine.PropertyAttribute
    {
        // Fields
        private readonly UnityEngine.Timeline.TimeFieldAttribute.UseEditMode <useEditMode>k__BackingField;  // 0x10

        // Methods
        // RVA: 0x010410F0  token: 0x60003D5
        public System.Void .ctor(UnityEngine.Timeline.TimeFieldAttribute.UseEditMode useEditMode) { }

    }

    // TypeToken: 0x20000A5  // size: 0x10
    public class FrameRateFieldAttribute : UnityEngine.PropertyAttribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60003D6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A6  // size: 0x10
    public class HideInMenuAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60003D7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A7  // size: 0x18
    public class CustomStyleAttribute : System.Attribute
    {
        // Fields
        public readonly System.String ussStyle;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x60003D8
        public System.Void .ctor(System.String ussStyle) { }

    }

    // TypeToken: 0x20000A8  // size: 0x10
    public class MenuCategoryAttribute : System.Attribute
    {
    }

    // TypeToken: 0x20000A9
    public interface ITimelineClipAsset
    {
        // Properties
        UnityEngine.Timeline.ClipCaps clipCaps { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x20000AA
    public interface ITimelineEvaluateCallback
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60003DA
        public virtual System.Void Evaluate() { }

    }

    // TypeToken: 0x20000AB  // size: 0xB0
    public class TimelinePlayable : UnityEngine.Playables.PlayableBehaviour
    {
        // Fields
        public System.Double timeOffset;  // 0x10
        public System.Int32 newOptionIndex;  // 0x18
        public System.Int32 curOptionIndex;  // 0x1c
        public System.Int32 lastOptionIndex;  // 0x20
        public System.Boolean checkTimeJumpForNextSeek;  // 0x24
        private UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> m_IntervalTree;  // 0x28
        private System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> m_ActiveClips;  // 0x30
        private System.Collections.Generic.HashSet<UnityEngine.Timeline.RuntimeElement> m_ActiveClipsSet;  // 0x38
        private System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> m_CurrentListOfActiveClips;  // 0x40
        private System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> m_ActiveClipsCalcCache;  // 0x48
        private System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> m_RuntimeResetClipCache;  // 0x50
        private System.Collections.Generic.List<UnityEngine.Timeline.ITimeDilationListener> m_timeDialationListeners;  // 0x58
        private System.Int32 m_ActiveBit;  // 0x60
        private System.Boolean m_needEvaluateTwice;  // 0x64
        private System.Boolean m_isTimelineEnded;  // 0x65
        private System.Collections.Generic.List<UnityEngine.Timeline.ITimelineEvaluateCallback> m_EvaluateCallbacks;  // 0x68
        private System.Collections.Generic.Dictionary<UnityEngine.Timeline.TrackAsset,UnityEngine.Playables.Playable> m_PlayableCache;  // 0x70
        private UnityEngine.Playables.PlayableDirector m_TopDirector;  // 0x78
        private System.Collections.Generic.List<UnityEngine.Playables.PlayableDirector> m_AllDirectorUnderRoot;  // 0x80
        private UnityEngine.Playables.PlayableDirector m_DirectorHoldingThisPlayable;  // 0x88
        private UnityEngine.Timeline.ITimelineRootMarker m_RootMarker;  // 0x90
        private System.Collections.Generic.List<UnityEngine.Timeline.IScriptAnimationJobSync> m_ScriptAnimationJobSyncs;  // 0x98
        private System.Collections.Generic.HashSet<UnityEngine.Playables.Playable> m_forbidPostProcessMixers;  // 0xa0
        private static System.Boolean muteAudioScrubbing;  // static @ 0x0
        private System.Double m_timeForNextFrame;  // 0xa8

        // Properties
        System.Double timeForNextFrame { get; /* RVA: 0x03D85810 */ }
        UnityEngine.Timeline.ITimelineRootMarker timelineRootMarker { get; /* RVA: 0x03D4EA90 */ }
        System.Boolean enableLoop { get; /* RVA: 0x09D43324 */ }

        // Methods
        // RVA: 0x09D40E4C  token: 0x60003DE
        public static UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimelinePlayable> Create(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, System.Boolean autoRebalance, System.Boolean createOutputs) { }
        // RVA: 0x09D3FB34  token: 0x60003DF
        public System.Void Compile(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, System.Boolean autoRebalance, System.Boolean createOutputs) { }
        // RVA: 0x03D85800  token: 0x60003E0
        public System.Void MarkTimelineEnd() { }
        // RVA: 0x03D5CA70  token: 0x60003E1
        public System.Boolean IsTimelineEnded() { }
        // RVA: 0x09D3F418  token: 0x60003E2
        private System.Void CompileCombineTopTopTrackList(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Boolean createOutputs) { }
        // RVA: 0x09D3F24C  token: 0x60003E3
        private static System.Void CollectCombineToTopTracksRecursive(UnityEngine.Timeline.TrackAsset track, System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> combineTracks) { }
        // RVA: 0x09D3F8E0  token: 0x60003E4
        private System.Void CompileTrackList(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, System.Boolean createOutputs, System.Boolean isCompilingCombineToTopTracks) { }
        // RVA: 0x09D400B4  token: 0x60003E5
        private System.Void CreateTrackOutput(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.TrackAsset track, UnityEngine.GameObject go, UnityEngine.Playables.Playable playable, System.Int32 port) { }
        // RVA: 0x09D414A0  token: 0x60003E6
        private System.Void EvaluateWeightsForAnimationPlayableOutput(UnityEngine.Timeline.TrackAsset track, UnityEngine.Animations.AnimationPlayableOutput animOutput, UnityEngine.Animator animator) { }
        // RVA: 0x09D40A14  token: 0x60003E7
        private UnityEngine.Playables.Playable CreateTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, UnityEngine.Timeline.TrackAsset track, UnityEngine.GameObject go, System.Boolean createOutputs) { }
        // RVA: 0x09D42734  token: 0x60003E8
        public System.Void UpdateIntervalTree() { }
        // RVA: 0x09D424F8  token: 0x60003E9
        public System.Void RuntimeResetIntervalTree() { }
        // RVA: 0x09D42158  token: 0x60003EA
        public virtual System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09D42E20  token: 0x60003EB
        private System.Void _ResetScriptAnimationJobySyncs() { }
        // RVA: 0x09D42C54  token: 0x60003EC
        private System.Void _EvaluateTwice() { }
        // RVA: 0x03D4E2B0  token: 0x60003ED
        public System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> GetCurrentActiveClips() { }
        // RVA: 0x09D42024  token: 0x60003EE
        public System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> GetActiveClipsAtGivenTime(System.Double givenTime, System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> activeClips) { }
        // RVA: 0x09D41F28  token: 0x60003EF
        public System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> GetActiveClipsAtGivenTimeRange(System.Double startTime, System.Double endTime, System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> activeClips) { }
        // RVA: 0x09D4154C  token: 0x60003F0
        protected virtual System.Void Evaluate(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData frameData) { }
        // RVA: 0x09D41230  token: 0x60003F1
        private System.Boolean DoReverseLoop(System.Double reverseTime) { }
        // RVA: 0x09D41154  token: 0x60003F2
        private System.Boolean DoReverseJump(UnityEngine.Timeline.RuntimeClip runtimeClip, System.Double jumpTime) { }
        // RVA: 0x09D4109C  token: 0x60003F3
        private System.Boolean DoJump(UnityEngine.Timeline.RuntimeClip runtimeClip, System.Double localTime, System.Double jumpTime) { }
        // RVA: 0x09D4277C  token: 0x60003F4
        private System.Boolean _CheckIfTimeJumping(UnityEngine.Playables.FrameData frameData, System.Double localTime) { }
        // RVA: 0x09D3F178  token: 0x60003F5
        private System.Void CacheTrack(UnityEngine.Timeline.TrackAsset track, UnityEngine.Playables.Playable playable, System.Int32 port, UnityEngine.Playables.Playable parent) { }
        // RVA: 0x03D85630  token: 0x60003F6
        public System.Void SetTimeForNextFrame(System.Double newTime) { }
        // RVA: 0x09D424A4  token: 0x60003F7
        public System.Void RegisterTimeDilationListener(UnityEngine.Timeline.ITimeDilationListener listener) { }
        // RVA: 0x09D420F4  token: 0x60003F8
        public System.Void MarkMixerForbidPostProcess(UnityEngine.Playables.Playable mixer) { }
        // RVA: 0x09D3F1E8  token: 0x60003F9
        public System.Boolean CheckIfMixerForbidPostProcess(UnityEngine.Playables.Playable mixer) { }
        // RVA: 0x09D42540  token: 0x60003FA
        public System.Void SetTimeScale(System.Single usingTimeScale) { }
        // RVA: 0x09D42D04  token: 0x60003FB
        private System.Void _NotifyTimeScaleChanged(System.Single usingTimeScale) { }
        // RVA: 0x09D42FD4  token: 0x60003FC
        public System.Void .ctor() { }
        // RVA: 0x09D42F9C  token: 0x60003FD
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000AC  // size: 0x10
    public static class AnimationPreviewUtilities
    {
    }

    // TypeToken: 0x20000AD  // size: 0x10
    public static class Extrapolation
    {
        // Fields
        private static readonly System.Double kMinExtrapolationTime;  // static @ 0x0

        // Methods
        // RVA: 0x09D38358  token: 0x60003FE
        private static System.Void CalculateExtrapolationTimes(UnityEngine.Timeline.TrackAsset asset) { }
        // RVA: 0x09D38718  token: 0x60003FF
        private static UnityEngine.Timeline.TimelineClip[] SortClipsByStartTime(UnityEngine.Timeline.TimelineClip[] clips) { }
        // RVA: 0x09D3885C  token: 0x6000400
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000AF  // size: 0x10
    public static class HashUtility
    {
        // Methods
        // RVA: 0x03D85760  token: 0x6000404
        public static System.Int32 CombineHash(System.Int32 h1, System.Int32 h2) { }
        // RVA: 0x03D85720  token: 0x6000405
        public static System.Int32 CombineHash(System.Int32 h1, System.Int32 h2, System.Int32 h3) { }
        // RVA: 0x03D856D0  token: 0x6000406
        public static System.Int32 CombineHash(System.Int32 h1, System.Int32 h2, System.Int32 h3, System.Int32 h4) { }
        // RVA: 0x09D389A0  token: 0x6000407
        public static System.Int32 CombineHash(System.Int32 h1, System.Int32 h2, System.Int32 h3, System.Int32 h4, System.Int32 h5) { }
        // RVA: 0x09D389D8  token: 0x6000408
        public static System.Int32 CombineHash(System.Int32 h1, System.Int32 h2, System.Int32 h3, System.Int32 h4, System.Int32 h5, System.Int32 h6) { }

    }

    // TypeToken: 0x20000B0
    public interface IPropertyCollector
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000409
        public virtual System.Void PushActiveGameObject(UnityEngine.GameObject gameObject) { }
        // RVA: -1  // abstract  token: 0x600040A
        public virtual System.Void PopActiveGameObject() { }
        // RVA: -1  // abstract  token: 0x600040B
        public virtual System.Void AddFromClip(UnityEngine.AnimationClip clip) { }
        // RVA: -1  // abstract  token: 0x600040C
        public virtual System.Void AddFromName(System.String name) { }
        // RVA: -1  // abstract  token: 0x600040D
        public virtual System.Void AddFromName(UnityEngine.GameObject obj, System.String name) { }
        // RVA: -1  // abstract  token: 0x600040E
        public virtual System.Void AddFromName(UnityEngine.GameObject obj, System.String name) { }
        // RVA: -1  // abstract  token: 0x600040F
        public virtual System.Void AddFromComponent(UnityEngine.GameObject obj, UnityEngine.Component component) { }
        // RVA: -1  // abstract  token: 0x6000410
        public virtual System.Void AddObjectProperties(UnityEngine.Object obj, UnityEngine.AnimationClip clip) { }

    }

    // TypeToken: 0x20000B1
    public interface IPropertyPreview
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000411
        public virtual System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }

    }

    // TypeToken: 0x20000B2  // size: 0x10
    public static class NotificationUtilities
    {
        // Methods
        // RVA: 0x09D39504  token: 0x6000412
        public static UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> markers, System.Double duration, UnityEngine.Playables.DirectorWrapMode extrapolationMode) { }
        // RVA: 0x09D398CC  token: 0x6000413
        public static System.Boolean TrackTypeSupportsNotifications(System.Type type) { }

    }

    // TypeToken: 0x20000B3  // size: 0x10
    public static class PlayableDirectorUtility
    {
        // Methods
        // RVA: 0x09D3A738  token: 0x6000414
        public static System.Void SetOptionIndexSingleDirector(UnityEngine.Playables.PlayableDirector director, System.Int32 curOptionIndex, System.Int32 lastOptionIndex) { }
        // RVA: 0x09D3A6BC  token: 0x6000415
        public static UnityEngine.Timeline.TimelinePlayable GetTimelinePlayable(UnityEngine.Playables.PlayableDirector director) { }
        // RVA: 0x09D3A60C  token: 0x6000416
        public static UnityEngine.Timeline.TimelinePlayable GetTimelinePlayable(UnityEngine.Playables.PlayableGraph graph) { }
        // RVA: 0x09D3A560  token: 0x6000417
        public static UnityEngine.Timeline.TimelinePlayable GetTimelinePlayableFromChildPlayable(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x09D3A49C  token: 0x6000418
        public static System.Boolean CheckIfTimelineFunctional(UnityEngine.Playables.Playable playable) { }

    }

    // TypeToken: 0x20000B4  // size: 0x10
    public static class TimelineClipExtensions
    {
        // Fields
        private static readonly System.String k_UndoSetParentTrackText;  // static @ 0x0

        // Methods
        // RVA: 0x09D3E944  token: 0x6000419
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000B5  // size: 0x10
    public static class TimelineCreateUtilities
    {
        // Methods
        // RVA: 0x09D3EBE0  token: 0x600041A
        public static System.String GenerateUniqueActorName(System.Collections.Generic.List<UnityEngine.ScriptableObject> tracks, System.String name) { }
        // RVA: 0x09D3EE94  token: 0x600041B
        public static System.Void SaveAssetIntoObject(UnityEngine.Object childAsset, UnityEngine.Object masterAsset) { }
        // RVA: 0x09D3EA3C  token: 0x600041C
        public static UnityEngine.AnimationClip CreateAnimationClipForTrack(System.String name, UnityEngine.Timeline.TrackAsset track, System.Boolean isLegacy) { }
        // RVA: 0x09D3EF54  token: 0x600041D
        public static System.Boolean ValidateParentTrack(UnityEngine.Timeline.TrackAsset parent, System.Type childType) { }

    }

    // TypeToken: 0x20000B8  // size: 0x10
    public class TimelineRuntimeUtils
    {
        // Methods
        // RVA: 0x09D45A38  token: 0x6000422
        public static System.Double GetTimelineDeltaTime(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData frameData) { }
        // RVA: 0x09D43398  token: 0x6000423
        public static System.Boolean CheckWillRuntimeElementEnabled(UnityEngine.Timeline.RuntimeElement element, System.Int32 curOptionIndex, System.Int32 lastOptionIndex, System.Int64 curDiscreteTime) { }
        // RVA: 0x09D44440  token: 0x6000424
        public static System.Void DoReverseJump(UnityEngine.Timeline.RuntimeClip jumpClip, UnityEngine.Timeline.ITimelineRootMarker timelineRoot, System.Double curTime, System.Double jumpTime, System.Double mixDuration, System.Int32 curOptionIndex, System.Int32 lastOptionIndex, System.Boolean needChangeOptionAfterJump, System.Int32 newOptionIndex) { }
        // RVA: 0x09D4343C  token: 0x6000425
        public static System.Void DoJump(UnityEngine.Timeline.RuntimeClip jumpClip, UnityEngine.Timeline.ITimelineRootMarker timelineRoot, System.Double curTime, System.Double jumpTime, System.Double mixDuration, System.Int32 curOptionIndex, System.Int32 lastOptionIndex, System.Boolean needChangeOptionAfterJump, System.Int32 optionIndexChangingTo) { }
        // RVA: 0x09D458E0  token: 0x6000426
        public static System.Double GetSubDirectorTimeForDirectorControl(UnityEngine.Playables.Playable playable, UnityEngine.Playables.PlayableDirector director) { }
        // RVA: 0x09D45D20  token: 0x6000427
        public static System.Void SetNewTimeForCutsceneRoot(UnityEngine.Timeline.ITimelineRootMarker timelineRoot, System.Double newTime, System.Boolean useThisTimeNextFrame) { }
        // RVA: 0x09D4543C  token: 0x6000428
        public static UnityEngine.AnimationClip FindTPoseClipFromLayerDescriptors(System.Collections.Generic.List<UnityEngine.Timeline.LayerDescriptor> layerDescriptors) { }
        // RVA: 0x09D45C4C  token: 0x6000429
        public static System.Void LinkDefaultTPoseIfNeeded(UnityEngine.Animations.AnimationLayerMixerPlayable mixer, System.Collections.Generic.List<UnityEngine.Timeline.LayerDescriptor> layerDescriptors, System.String gameObjectName, System.Boolean disableBaseTPoseClip) { }
        // RVA: 0x09D45AB0  token: 0x600042A
        public static System.Void LinkDefaultTPoseClip(UnityEngine.Animations.AnimationLayerMixerPlayable mixer, UnityEngine.AnimationClip tposeClip, System.String gameObjectName) { }
        // RVA: 0x0350B670  token: 0x600042B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B9  // size: 0x10
    public static class TimelineUndo
    {
        // Methods
        // RVA: 0x09D46028  token: 0x600042C
        public static System.Void PushDestroyUndo(UnityEngine.Timeline.TimelineAsset timeline, UnityEngine.Object thingToDirty, UnityEngine.Object objectToDestroy) { }

    }

    // TypeToken: 0x20000BA  // size: 0x14
    public sealed struct StandardFrameRates
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Timeline.StandardFrameRates Fps24;  // const
        public static UnityEngine.Timeline.StandardFrameRates Fps23_97;  // const
        public static UnityEngine.Timeline.StandardFrameRates Fps25;  // const
        public static UnityEngine.Timeline.StandardFrameRates Fps30;  // const
        public static UnityEngine.Timeline.StandardFrameRates Fps29_97;  // const
        public static UnityEngine.Timeline.StandardFrameRates Fps50;  // const
        public static UnityEngine.Timeline.StandardFrameRates Fps60;  // const
        public static UnityEngine.Timeline.StandardFrameRates Fps59_94;  // const

    }

    // TypeToken: 0x20000BB  // size: 0x10
    public static class TimeUtility
    {
        // Fields
        public static readonly System.Double kTimeEpsilon;  // static @ 0x0
        public static readonly System.Double kFrameRateEpsilon;  // static @ 0x8
        public static readonly System.Double k_MaxTimelineDurationInSeconds;  // static @ 0x10
        public static readonly System.Double kFrameRateRounding;  // static @ 0x18

        // Methods
        // RVA: 0x09D3E870  token: 0x600042D
        public static System.Double GetAnimationClipLength(UnityEngine.AnimationClip clip) { }
        // RVA: 0x03CF7830  token: 0x600042E
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x20000BD  // size: 0x10
    public static class WeightUtility
    {
        // Methods
        // RVA: 0x09D46208  token: 0x6000431
        public static System.Single NormalizeMixer(UnityEngine.Playables.Playable mixer) { }

    }

}

namespace UnityEngine.Timeline.Condition
{

    // TypeToken: 0x20000BE  // size: 0x20
    public class TimelineConditionControlMono : UnityEngine.MonoBehaviour
    {
        // Fields
        public Beyond.PackageBridge.Timeline.TimelineConditionBase condition;  // 0x18

        // Methods
        // RVA: 0x09D3E9A0  token: 0x6000432
        public System.Void RefreshOnCondition() { }
        // RVA: 0x0426FE60  token: 0x6000433
        public System.Void .ctor() { }

    }

}

