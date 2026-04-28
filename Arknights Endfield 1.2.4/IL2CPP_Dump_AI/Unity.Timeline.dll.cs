// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Timeline.dll
// Classes:  191
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

CLASS: PostPlaybackState
TYPE:  sealed struct
TOKEN: 0x200001D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.ActivationTrack.PostPlaybackStateActive  // const
  public    static  UnityEngine.Timeline.ActivationTrack.PostPlaybackStateInactive  // const
  public    static  UnityEngine.Timeline.ActivationTrack.PostPlaybackStateRevert  // const
  public    static  UnityEngine.Timeline.ActivationTrack.PostPlaybackStateLeaveAsIs  // const
METHODS:
END_CLASS

CLASS: WeightInfo
TYPE:  sealed struct
TOKEN: 0x200001F
SIZE:  0x38
FIELDS:
  public            UnityEngine.Playables.Playable  mixer  // 0x10
  public            UnityEngine.Playables.Playable  parentMixer  // 0x20
  public            System.Int32                    port  // 0x30
METHODS:
END_CLASS

CLASS: LoopMode
TYPE:  sealed struct
TOKEN: 0x2000021
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.LoopModeUseSourceAsset  // const
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.LoopModeOn  // const
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.LoopModeOff  // const
METHODS:
END_CLASS

CLASS: ClothResetOption
TYPE:  sealed struct
TOKEN: 0x2000022
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOptionSoftReset  // const
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOptionUseClothRelativeTeleport  // const
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOptionUseStablizationTime  // const
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOptionDisablePhysics  // const
METHODS:
END_CLASS

CLASS: AnimationEventTriggerMode
TYPE:  sealed struct
TOKEN: 0x2000023
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.AnimationEventTriggerModeDefault  // const
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.AnimationEventTriggerModeMuteAllEvents  // const
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.AnimationEventTriggerModeSeekAllEvents  // const
METHODS:
END_CLASS

CLASS: Versions
TYPE:  sealed struct
TOKEN: 0x2000024
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.VersionsInitial  // const
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.VersionsRotationAsEuler  // const
METHODS:
END_CLASS

CLASS: AnimationPlayableAssetUpgrade
TYPE:  static class
TOKEN: 0x2000025
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09D20838  token=0x6000097  System.Void ConvertRotationToEuler(UnityEngine.Timeline.AnimationPlayableAsset asset)
END_CLASS

CLASS: <get_outputs>d__83
TYPE:  sealed class
TOKEN: 0x2000026
SIZE:  0x48
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           UnityEngine.Playables.PlayableBinding<>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x38
  public            UnityEngine.Timeline.AnimationPlayableAsset<>4__this  // 0x40
PROPERTIES:
  System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current  get=0x03D60DC0
  System.Collections.IEnumerator.Current  get=0x09D351D8
METHODS:
  RVA=0x09D343A4  token=0x6000098  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000099  System.Void System.IDisposable.Dispose()
  RVA=0x09D34C24  token=0x600009A  System.Boolean MoveNext()
  RVA=0x09D3518C  token=0x600009C  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x09D350F8  token=0x600009E  System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator()
  RVA=0x09D35184  token=0x600009F  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: AnimationTrackUpgrade
TYPE:  static class
TOKEN: 0x200002D
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09D21BE8  token=0x6000100  System.Void ConvertRotationsToEuler(UnityEngine.Timeline.AnimationTrack track)
  RVA=0x09D21B80  token=0x6000101  System.Void ConvertRootMotion(UnityEngine.Timeline.AnimationTrack track)
  RVA=0x09D21B40  token=0x6000102  System.Void ConvertInfiniteTrack(UnityEngine.Timeline.AnimationTrack track)
END_CLASS

CLASS: <get_outputs>d__72
TYPE:  sealed class
TOKEN: 0x200002E
SIZE:  0x48
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           UnityEngine.Playables.PlayableBinding<>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x38
  public            UnityEngine.Timeline.AnimationTrack<>4__this  // 0x40
PROPERTIES:
  System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current  get=0x03D60DC0
  System.Collections.IEnumerator.Current  get=0x09D34D84
METHODS:
  RVA=0x09D343A4  token=0x6000103  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000104  System.Void System.IDisposable.Dispose()
  RVA=0x09D34C24  token=0x6000105  System.Boolean MoveNext()
  RVA=0x09D34D38  token=0x6000107  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x09D34CA4  token=0x6000109  System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator()
  RVA=0x09D34D30  token=0x600010A  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Versions
TYPE:  sealed struct
TOKEN: 0x2000031
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TimelineClip.VersionsInitial  // const
  public    static  UnityEngine.Timeline.TimelineClip.VersionsClipInFromGlobalToLocal  // const
METHODS:
END_CLASS

CLASS: TimelineClipUpgrade
TYPE:  static class
TOKEN: 0x2000032
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09D2C9F0  token=0x600014E  System.Void UpgradeClipInFromGlobalToLocal(UnityEngine.Timeline.TimelineClip clip)
END_CLASS

CLASS: ClipExtrapolation
TYPE:  sealed struct
TOKEN: 0x2000033
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TimelineClip.ClipExtrapolationNone  // const
  public    static  UnityEngine.Timeline.TimelineClip.ClipExtrapolationHold  // const
  public    static  UnityEngine.Timeline.TimelineClip.ClipExtrapolationLoop  // const
  public    static  UnityEngine.Timeline.TimelineClip.ClipExtrapolationPingPong  // const
  public    static  UnityEngine.Timeline.TimelineClip.ClipExtrapolationContinue  // const
METHODS:
END_CLASS

CLASS: BlendCurveMode
TYPE:  sealed struct
TOKEN: 0x2000034
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TimelineClip.BlendCurveModeAuto  // const
  public    static  UnityEngine.Timeline.TimelineClip.BlendCurveModeManual  // const
METHODS:
END_CLASS

CLASS: Versions
TYPE:  sealed struct
TOKEN: 0x2000036
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TimelineAsset.VersionsInitial  // const
METHODS:
END_CLASS

CLASS: TimelineAssetUpgrade
TYPE:  static class
TOKEN: 0x2000037
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: MediaType
TYPE:  sealed struct
TOKEN: 0x2000038
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TimelineAsset.MediaTypeAnimation  // const
  public    static  UnityEngine.Timeline.TimelineAsset.MediaTypeAudio  // const
  public    static  UnityEngine.Timeline.TimelineAsset.MediaTypeTexture  // const
  public    static  UnityEngine.Timeline.TimelineAsset.MediaTypeVideo  // const
  public    static  UnityEngine.Timeline.TimelineAsset.MediaTypeScript  // const
  public    static  UnityEngine.Timeline.TimelineAsset.MediaTypeHybrid  // const
  public    static  UnityEngine.Timeline.TimelineAsset.MediaTypeGroup  // const
METHODS:
END_CLASS

CLASS: DurationMode
TYPE:  sealed struct
TOKEN: 0x2000039
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TimelineAsset.DurationModeBasedOnClips  // const
  public    static  UnityEngine.Timeline.TimelineAsset.DurationModeFixedLength  // const
METHODS:
END_CLASS

CLASS: EditorSettings
TYPE:  class
TOKEN: 0x200003A
SIZE:  0x20
FIELDS:
  private   static readonly System.Double                   kMinFrameRate  // static @ 0x0
  private   static readonly System.Double                   kMaxFrameRate  // static @ 0x8
  private   static readonly System.Double                   kDefaultFrameRate  // static @ 0x10
  private           System.Double                   m_Framerate  // 0x10
  private           System.Boolean                  m_ScenePreview  // 0x18
PROPERTIES:
  frameRate  get=0x03D61CF0  set=0x09D29F64
METHODS:
  RVA=0x03151BE0  token=0x6000181  System.Void .ctor()
  RVA=0x03CEE6F0  token=0x6000182  System.Void .cctor()
END_CLASS

CLASS: <get_outputs>d__28
TYPE:  sealed class
TOKEN: 0x200003B
SIZE:  0x58
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           UnityEngine.Playables.PlayableBinding<>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x38
  public            UnityEngine.Timeline.TimelineAsset<>4__this  // 0x40
  private           System.Collections.Generic.IEnumerator<UnityEngine.Timeline.TrackAsset><>7__wrap1  // 0x48
  private           System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding><>7__wrap2  // 0x50
PROPERTIES:
  System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current  get=0x03D60DC0
  System.Collections.IEnumerator.Current  get=0x09D34924
METHODS:
  RVA=0x09D343A4  token=0x6000183  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x09D34974  token=0x6000184  System.Void System.IDisposable.Dispose()
  RVA=0x09D343C0  token=0x6000185  System.Boolean MoveNext()
  RVA=0x09D34A60  token=0x6000186  System.Void <>m__Finally1()
  RVA=0x09D34AA8  token=0x6000187  System.Void <>m__Finally2()
  RVA=0x09D348D8  token=0x6000189  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x09D34844  token=0x600018B  System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator()
  RVA=0x09D348D0  token=0x600018C  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Versions
TYPE:  sealed struct
TOKEN: 0x200003D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TrackAsset.VersionsInitial  // const
  public    static  UnityEngine.Timeline.TrackAsset.VersionsRotationAsEuler  // const
  public    static  UnityEngine.Timeline.TrackAsset.VersionsRootMotionUpgrade  // const
  public    static  UnityEngine.Timeline.TrackAsset.VersionsAnimatedTrackProperties  // const
METHODS:
END_CLASS

CLASS: TrackAssetUpgrade
TYPE:  static class
TOKEN: 0x200003E
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: TransientBuildData
TYPE:  sealed struct
TOKEN: 0x200003F
SIZE:  0x28
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset>trackList  // 0x10
  public            System.Collections.Generic.List<UnityEngine.Timeline.TimelineClip>clipList  // 0x18
  public            System.Collections.Generic.List<UnityEngine.Timeline.IMarker>markerList  // 0x20
METHODS:
  RVA=0x031513A0  token=0x60001F9  UnityEngine.Timeline.TrackAsset.TransientBuildData Create()
  RVA=0x09D33EC4  token=0x60001FA  System.Void Clear()
END_CLASS

CLASS: <get_outputs>d__74
TYPE:  sealed class
TOKEN: 0x2000040
SIZE:  0x48
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           UnityEngine.Playables.PlayableBinding<>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x38
  public            UnityEngine.Timeline.TrackAsset <>4__this  // 0x40
PROPERTIES:
  System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current  get=0x03D60DC0
  System.Collections.IEnumerator.Current  get=0x09D350A8
METHODS:
  RVA=0x09D343A4  token=0x60001FB  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x60001FC  System.Void System.IDisposable.Dispose()
  RVA=0x09D34DD4  token=0x60001FD  System.Boolean MoveNext()
  RVA=0x09D3505C  token=0x60001FF  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x09D34FC8  token=0x6000201  System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator()
  RVA=0x09D35054  token=0x6000202  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000041
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.Timeline.TrackAsset.<>c<>9  // static @ 0x0
  public    static  System.Comparison<UnityEngine.Timeline.TimelineClip><>9__131_0  // static @ 0x8
METHODS:
  RVA=0x09D34190  token=0x6000203  System.Void .cctor()
  RVA=0x0350B670  token=0x6000204  System.Void .ctor()
  RVA=0x09D34154  token=0x6000205  System.Int32 <SortClips>b__131_0(UnityEngine.Timeline.TimelineClip clip1, UnityEngine.Timeline.TimelineClip clip2)
END_CLASS

CLASS: <get_outputs>d__16
TYPE:  sealed class
TOKEN: 0x2000049
SIZE:  0x48
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           UnityEngine.Playables.PlayableBinding<>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x38
  public            UnityEngine.Timeline.AudioPlayableAsset<>4__this  // 0x40
PROPERTIES:
  System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current  get=0x03D60DC0
  System.Collections.IEnumerator.Current  get=0x09D34354
METHODS:
  RVA=0x09D343A4  token=0x6000217  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000218  System.Void System.IDisposable.Dispose()
  RVA=0x09D341F4  token=0x6000219  System.Boolean MoveNext()
  RVA=0x09D34308  token=0x600021B  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x09D34274  token=0x600021D  System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator()
  RVA=0x09D34300  token=0x600021E  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: <get_outputs>d__4
TYPE:  sealed class
TOKEN: 0x200004B
SIZE:  0x48
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           UnityEngine.Playables.PlayableBinding<>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x38
  public            UnityEngine.Timeline.AudioTrack <>4__this  // 0x40
PROPERTIES:
  System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current  get=0x03D60DC0
  System.Collections.IEnumerator.Current  get=0x09D34BD4
METHODS:
  RVA=0x09D343A4  token=0x6000224  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000225  System.Void System.IDisposable.Dispose()
  RVA=0x09D341F4  token=0x6000226  System.Boolean MoveNext()
  RVA=0x09D34B88  token=0x6000228  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x09D34AF4  token=0x600022A  System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator()
  RVA=0x09D34B80  token=0x600022B  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: DescriptorBlendTreeType
TYPE:  sealed struct
TOKEN: 0x2000051
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeTypeDirect  // const
  public    static  UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeTypeSimple1D  // const
  public    static  UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeTypeSimple2D  // const
  public    static  UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeTypeComplex2D  // const
METHODS:
END_CLASS

CLASS: <GetControlableScripts>d__53
TYPE:  sealed class
TOKEN: 0x2000059
SIZE:  0x48
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x10
  private           UnityEngine.MonoBehaviour       <>2__current  // 0x18
  private           System.Int32                    <>l__initialThreadId  // 0x20
  private           UnityEngine.GameObject          root  // 0x28
  public            UnityEngine.GameObject          <>3__root  // 0x30
  private           UnityEngine.MonoBehaviour[]     <>7__wrap1  // 0x38
  private           System.Int32                    <>7__wrap2  // 0x40
PROPERTIES:
  System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour>.Current  get=0x01041090
  System.Collections.IEnumerator.Current  get=0x01041090
METHODS:
  RVA=0x025D6DC0  token=0x6000267  System.Void .ctor(System.Int32 <>1__state)
  RVA=0x0350B670  token=0x6000268  System.Void System.IDisposable.Dispose()
  RVA=0x09D33F4C  token=0x6000269  System.Boolean MoveNext()
  RVA=0x09D34108  token=0x600026B  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x09D3406C  token=0x600026D  System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour> System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour>.GetEnumerator()
  RVA=0x09D34100  token=0x600026E  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: TransformAdditive
TYPE:  class
TOKEN: 0x200005C
SIZE:  0x38
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Vector3             rotationEuler  // 0x1c
  public            UnityEngine.Vector3             scale  // 0x28
METHODS:
  RVA=0x09D33EBC  token=0x6000278  System.Void .ctor()
  RVA=0x09D33E5C  token=0x6000279  System.Void Reset()
  RVA=0x09D33D40  token=0x600027A  System.Boolean HasChanges()
END_CLASS

CLASS: TransformAdditive
TYPE:  class
TOKEN: 0x200005E
SIZE:  0x38
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Vector3             rotationEular  // 0x1c
  public            UnityEngine.Vector3             scale  // 0x28
METHODS:
  RVA=0x09D33E5C  token=0x6000280  System.Void Reset()
  RVA=0x0350B670  token=0x6000281  System.Void .ctor()
END_CLASS

CLASS: AnimationCurveInfo
TYPE:  class
TOKEN: 0x2000061
SIZE:  0x28
FIELDS:
  public            System.String                   path  // 0x10
  public            System.String                   propertyName  // 0x18
  public            UnityEngine.AnimationCurve      curve  // 0x20
METHODS:
  RVA=0x0350B670  token=0x600028F  System.Void .ctor()
END_CLASS

CLASS: Entry
TYPE:  sealed struct
TOKEN: 0x2000073
FIELDS:
  public            System.Int64                    intervalStart  // 0x0
  public            System.Int64                    intervalEnd  // 0x0
  public            T                               item  // 0x0
METHODS:
END_CLASS

CLASS: EventKeyValue
TYPE:  class
TOKEN: 0x2000081
SIZE:  0x20
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.Timeline.SignalAsset>m_Signals  // 0x10
  private           System.Collections.Generic.List<UnityEngine.Events.UnityEvent>m_Events  // 0x18
PROPERTIES:
  signals  get=0x020B7B20
  events  get=0x01041090
METHODS:
  RVA=0x09D381F0  token=0x600035A  System.Boolean TryGetValue(UnityEngine.Timeline.SignalAsset key, UnityEngine.Events.UnityEvent& value)
  RVA=0x09D38048  token=0x600035B  System.Void Append(UnityEngine.Timeline.SignalAsset key, UnityEngine.Events.UnityEvent value)
  RVA=0x09D38174  token=0x600035C  System.Void Remove(System.Int32 idx)
  RVA=0x09D380D0  token=0x600035D  System.Void Remove(UnityEngine.Timeline.SignalAsset key)
  RVA=0x09D38298  token=0x6000360  System.Void .ctor()
END_CLASS

CLASS: PostPlaybackState
TYPE:  sealed struct
TOKEN: 0x2000088
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackStateActive  // const
  public    static  UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackStateInactive  // const
  public    static  UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackStateRevert  // const
METHODS:
END_CLASS

CLASS: InitialState
TYPE:  sealed struct
TOKEN: 0x2000089
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.ActivationControlPlayable.InitialStateUnset  // const
  public    static  UnityEngine.Timeline.ActivationControlPlayable.InitialStateActive  // const
  public    static  UnityEngine.Timeline.ActivationControlPlayable.InitialStateInactive  // const
METHODS:
END_CLASS

CLASS: NotificationEntry
TYPE:  sealed struct
TOKEN: 0x2000094
SIZE:  0x28
FIELDS:
  public            System.Double                   time  // 0x10
  public            UnityEngine.Playables.INotificationpayload  // 0x18
  public            System.Boolean                  notificationFired  // 0x20
  public            UnityEngine.Timeline.NotificationFlagsflags  // 0x22
PROPERTIES:
  triggerInEditor  get=0x09D394F4
  prewarm  get=0x09D394EC
  triggerOnce  get=0x09D394FC
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000095
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.Timeline.TimeNotificationBehaviour.<>c<>9  // static @ 0x0
  public    static  System.Comparison<UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry><>9__15_0  // static @ 0x8
METHODS:
  RVA=0x09D46140  token=0x60003C2  System.Void .cctor()
  RVA=0x0350B670  token=0x60003C3  System.Void .ctor()
  RVA=0x09D46088  token=0x60003C4  System.Int32 <SortNotifications>b__15_0(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry x, UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry y)
END_CLASS

CLASS: UseEditMode
TYPE:  sealed struct
TOKEN: 0x20000A4
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TimeFieldAttribute.UseEditModeNone  // const
  public    static  UnityEngine.Timeline.TimeFieldAttribute.UseEditModeApplyEditMode  // const
METHODS:
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000AE
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.Timeline.Extrapolation.<>c<>9  // static @ 0x0
  public    static  System.Comparison<UnityEngine.Timeline.TimelineClip><>9__2_0  // static @ 0x8
METHODS:
  RVA=0x09D461A4  token=0x6000401  System.Void .cctor()
  RVA=0x0350B670  token=0x6000402  System.Void .ctor()
  RVA=0x09D34154  token=0x6000403  System.Int32 <SortClipsByStartTime>b__2_0(UnityEngine.Timeline.TimelineClip clip1, UnityEngine.Timeline.TimelineClip clip2)
END_CLASS

CLASS: <>c__DisplayClass0_0
TYPE:  sealed class
TOKEN: 0x20000B6
SIZE:  0x18
FIELDS:
  public            System.String                   name  // 0x10
METHODS:
  RVA=0x0350B670  token=0x600041E  System.Void .ctor()
  RVA=0x09D460A4  token=0x600041F  System.Boolean <GenerateUniqueActorName>b__0(UnityEngine.ScriptableObject x)
END_CLASS

CLASS: <>c__DisplayClass0_1
TYPE:  sealed class
TOKEN: 0x20000B7
SIZE:  0x18
FIELDS:
  public            System.String                   result  // 0x10
METHODS:
  RVA=0x0350B670  token=0x6000420  System.Void .ctor()
  RVA=0x09D460A4  token=0x6000421  System.Boolean <GenerateUniqueActorName>b__1(UnityEngine.ScriptableObject x)
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x20000BC
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.Timeline.TimeUtility.<>c<>9  // static @ 0x0
METHODS:
  RVA=0x09D460DC  token=0x600042F  System.Void .cctor()
  RVA=0x0350B670  token=0x6000430  System.Void .ctor()
END_CLASS

CLASS: <PrivateImplementationDetails>
TYPE:  sealed class
TOKEN: 0x20000BF
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x056516CC  token=0x6000434  System.UInt32 ComputeStringHash(System.String s)
END_CLASS

CLASS: Beyond.Gameplay.Core.DontAutoBindAttribute
TYPE:  class
TOKEN: 0x200000F
SIZE:  0x10
EXTENDS: Beyond.Gameplay.Core.DontAutoBindRuntimeAttribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000011  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.DontAutoBindRuntimeAttribute
TYPE:  class
TOKEN: 0x2000010
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000012  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.BeyondUseAutoBindingPlayableAsset
TYPE:  class
TOKEN: 0x2000011
SIZE:  0x30
EXTENDS: UnityEngine.Playables.PlayableAsset
FIELDS:
  public            System.Boolean                  useAutoBinding  // 0x18
  public            System.String                   autoBindingPath  // 0x20
  protected         UnityEngine.GameObject          m_bindingGo  // 0x28
PROPERTIES:
  bindingGameObject  get=0x03D4EAC0  set=0x02C92F10
METHODS:
  RVA=0x09D26F30  token=0x6000015  System.Void SetBindingGameObject(UnityEngine.GameObject tBindingGameObject)
  RVA=0x0350B670  token=0x6000016  System.Void OnBindGoChanged()
  RVA=0x09D26EE4  token=0x6000017  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  RVA=0x0286F540  token=0x6000018  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.RuntimeJumpBehaviour
TYPE:  class
TOKEN: 0x2000012
SIZE:  0x10
EXTENDS: UnityEngine.Playables.PlayableBehaviour
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000019  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.RuntimeJumpClip
TYPE:  class
TOKEN: 0x2000013
SIZE:  0x30
EXTENDS: UnityEngine.Playables.PlayableAsset
IMPLEMENTS: UnityEngine.Timeline.ITimelineClipAsset
FIELDS:
  public            System.Boolean                  isReverseJump  // 0x18
  public            System.Boolean                  needChangeOptionAfterJump  // 0x19
  public            System.Int32                    optionIndexAfterJump  // 0x1c
  public            System.Double                   crossFadeDurationAfterJump  // 0x20
  public            System.Boolean                  isJumpFirst  // 0x28
PROPERTIES:
  clipCaps  get=0x03D5CA10
METHODS:
  RVA=0x09D29FFC  token=0x600001B  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  RVA=0x0286F540  token=0x600001C  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.RuntimeJumpTrack
TYPE:  class
TOKEN: 0x2000014
SIZE:  0xC0
EXTENDS: UnityEngine.Timeline.TrackAsset
FIELDS:
METHODS:
  RVA=0x09D2A094  token=0x600001D  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.RuntimeLoopBehaviour
TYPE:  class
TOKEN: 0x2000015
SIZE:  0x10
EXTENDS: UnityEngine.Playables.PlayableBehaviour
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600001E  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.RuntimeLoopClip
TYPE:  class
TOKEN: 0x2000016
SIZE:  0x20
EXTENDS: UnityEngine.Playables.PlayableAsset
IMPLEMENTS: UnityEngine.Timeline.ITimelineClipAsset
FIELDS:
  public            System.Double                   crossFadeDuration  // 0x18
PROPERTIES:
  clipCaps  get=0x03D567A0
METHODS:
  RVA=0x09D2A0E0  token=0x6000020  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  RVA=0x0286F540  token=0x6000021  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.RuntimeLoopTrack
TYPE:  class
TOKEN: 0x2000017
SIZE:  0xC0
EXTENDS: UnityEngine.Timeline.TrackAsset
FIELDS:
METHODS:
  RVA=0x09D2A178  token=0x6000022  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.TimelineNPCLookAtController
TYPE:  class
TOKEN: 0x2000018
SIZE:  0x38
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private   static readonly System.Collections.Generic.HashSet<Beyond.Gameplay.Core.TimelineNPCLookAtController>s_instances  // static @ 0x0
  public            System.Boolean                  m_lookAtDirty  // 0x18
  public            ScriptAnimation.TimelineNPCLookAtTargetlookAtTarget  // 0x20
  public            ScriptAnimation.TimelineNPCLookAtEyeTargetlookAtEyeTarget  // 0x28
  public            System.Boolean                  lookAtEnabled  // 0x30
  public            System.Boolean                  lookAtEyeEnabled  // 0x31
PROPERTIES:
  Instances  get=0x09D2E11C
  lookAtDirty  get=0x01002A50  set=0x01002B40
  lookAtWeight  get=0x09D2E67C  set=0x09D2EC70
  lookAtBodyWeight  get=0x09D2E2C4  set=0x09D2E8A8
  lookAtRoll  get=0x09D2E518  set=0x09D2EB04
  lookAtHorizontal  get=0x09D2E494  set=0x09D2EA88
  lookAtVertical  get=0x09D2E5F8  set=0x09D2EBF4
  lookAtEyeWeight  get=0x09D2E418  set=0x09D2EA10
  lookAtUseDegree  get=0x09D2E58C  set=0x09D2EB7C
  EyeUseDegree  get=0x09D2E0B0  set=0x09D2E6F0
  lookAtEyeUp  get=0x09D2E3A8  set=0x09D2E998
  lookAtEyeDown  get=0x09D2E338  set=0x09D2E920
  finalPosition  get=0x09D2E218  set=0x09D2E808
  finalEyePosition  get=0x09D2E16C  set=0x09D2E768
METHODS:
  RVA=0x09D2DFA4  token=0x6000024  System.Void OnEnable()
  RVA=0x09D2DF34  token=0x6000025  System.Void OnDisable()
  RVA=0x0350B670  token=0x6000040  System.Void MarkLookAtDirty()
  RVA=0x09D2E0A0  token=0x6000041  System.Void .ctor()
  RVA=0x09D2E014  token=0x6000042  System.Void .cctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardUtility
TYPE:  static class
TOKEN: 0x200000A
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x200000B
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600000D  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x200000C
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600000E  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x200000D
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600000F  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x200000E
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000010  System.Void .ctor()
END_CLASS

CLASS: Events.INotificationTrack
TYPE:  interface
TOKEN: 0x2000008
FIELDS:
METHODS:
END_CLASS

CLASS: Events.ITimelineNotification
TYPE:  interface
TOKEN: 0x2000009
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600000C  System.Void OnNotify(UnityEngine.Timeline.ITimelineRootMarker root)
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

CLASS: ScriptAnimation.TimelineNPCClothWeightController
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x38
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.Boolean                  forceSetPhysicsClothWeight  // 0x18
  public            System.Single                   physicsClothWeight  // 0x1c
  public            System.Boolean                  forceSetPhysicsClothPart1Weight  // 0x20
  public            System.Single                   physicsClothPart1Weight  // 0x24
  public            System.Boolean                  forceSetPhysicsClothPart2Weight  // 0x28
  public            System.Single                   physicsClothPart2Weight  // 0x2c
  public            System.Boolean                  forceSetLoopBodyAddWeight  // 0x30
  public            System.Single                   loopBodyAddWeight  // 0x34
METHODS:
  RVA=0x09D2DF10  token=0x6000002  System.Void .ctor()
END_CLASS

CLASS: ScriptAnimation.TimelineNPCLookAtEyeTarget
TYPE:  class
TOKEN: 0x2000004
SIZE:  0x28
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.Single                   lookAtWeight  // 0x18
  public            System.Boolean                  useDegree  // 0x1c
  public            System.Single                   lookAtUp  // 0x20
  public            System.Single                   lookAtDown  // 0x24
METHODS:
  RVA=0x03D65C60  token=0x6000003  System.Void ResetLookAtWeight()
  RVA=0x0426FE60  token=0x6000004  System.Void .ctor()
END_CLASS

CLASS: ScriptAnimation.TimelineNPCLookAtTarget
TYPE:  class
TOKEN: 0x2000005
SIZE:  0x30
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            System.Single                   lookAtWeight  // 0x18
  public            System.Single                   lookAtBodyWeight  // 0x1c
  public            System.Boolean                  useDegree  // 0x20
  public            System.Single                   lookAtHorizontal  // 0x24
  public            System.Single                   lookAtVertical  // 0x28
  public            System.Single                   lookAtRoll  // 0x2c
METHODS:
  RVA=0x03D85650  token=0x6000005  System.Void ResetLookAtWeight()
  RVA=0x09D2ECE8  token=0x6000006  System.Void .ctor()
END_CLASS

CLASS: ScriptAnimation.ScriptAnimationApply.ScriptAnimationApplyBehaviour
TYPE:  class
TOKEN: 0x2000006
SIZE:  0x18
EXTENDS: UnityEngine.Playables.PlayableBehaviour
FIELDS:
  private           UnityEngine.Timeline.IScriptAnimationJobSyncm_JobSync  // 0x10
METHODS:
  RVA=0x09D2A1C4  token=0x6000007  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x0426FEE0  token=0x6000008  System.Void InitBehaviour(UnityEngine.Timeline.IScriptAnimationJobSync jobSync)
  RVA=0x0350B670  token=0x6000009  System.Void .ctor()
END_CLASS

CLASS: ScriptAnimation.ScriptAnimationApply.ScriptAnimationApplyPlayable
TYPE:  class
TOKEN: 0x2000007
SIZE:  0x18
EXTENDS: UnityEngine.Playables.PlayableAsset
FIELDS:
METHODS:
  RVA=0x09D2A234  token=0x600000A  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  RVA=0x0286F540  token=0x600000B  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.PlayerLoopChecker
TYPE:  static class
TOKEN: 0x2000019
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.ActivationMixerPlayable
TYPE:  class
TOKEN: 0x200001A
SIZE:  0x20
EXTENDS: UnityEngine.Playables.PlayableBehaviour
FIELDS:
  private           UnityEngine.Timeline.ActivationTrack.PostPlaybackStatem_PostPlaybackState  // 0x10
  private           System.Boolean                  m_BoundGameObjectInitialStateIsActive  // 0x14
  private           UnityEngine.GameObject          m_BoundGameObject  // 0x18
PROPERTIES:
  postPlaybackState  set=0x010410F0
METHODS:
  RVA=0x09D1DF24  token=0x6000043  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.ActivationMixerPlayable> Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  RVA=0x09D1E1A8  token=0x6000045  System.Void SetBoundGameObject(UnityEngine.GameObject go)
  RVA=0x0350B670  token=0x6000046  System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable)
  RVA=0x09D1DFB0  token=0x6000047  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D1E0C8  token=0x6000048  System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
  RVA=0x09D1DFF4  token=0x6000049  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D1E238  token=0x600004A  System.Void _DoSetActive(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
  RVA=0x0350B670  token=0x600004B  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ActivationPlayableAsset
TYPE:  class
TOKEN: 0x200001B
SIZE:  0x18
EXTENDS: UnityEngine.Playables.PlayableAsset
IMPLEMENTS: UnityEngine.Timeline.ITimelineClipAsset
FIELDS:
PROPERTIES:
  clipCaps  get=0x01002730
METHODS:
  RVA=0x09D1E3BC  token=0x600004D  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go)
  RVA=0x0286F540  token=0x600004E  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ActivationTrack
TYPE:  class
TOKEN: 0x200001C
SIZE:  0xD0
EXTENDS: UnityEngine.Timeline.TrackAsset
FIELDS:
  private           UnityEngine.Timeline.ActivationTrack.PostPlaybackStatem_PostPlaybackState  // 0xc0
  private           UnityEngine.Timeline.ActivationMixerPlayablem_ActivationMixer  // 0xc8
PROPERTIES:
  postPlaybackState  get=0x03D57EF0  set=0x09D1E7F4
METHODS:
  RVA=0x09D1E428  token=0x600004F  System.Boolean CanCompileClips()
  RVA=0x09D1E458  token=0x6000052  UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount)
  RVA=0x09D1E688  token=0x6000053  UnityEngine.GameObject GetBinding(UnityEngine.Playables.PlayableDirector director)
  RVA=0x09D1E7D8  token=0x6000054  System.Void UpdateTrackMode()
  RVA=0x09D1E5E8  token=0x6000055  System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
  RVA=0x09D1E788  token=0x6000056  System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip)
  RVA=0x031514D0  token=0x6000057  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AnimationOutputWeightProcessor
TYPE:  class
TOKEN: 0x200001E
SIZE:  0x30
IMPLEMENTS: UnityEngine.Timeline.ITimelineEvaluateCallback
FIELDS:
  private           UnityEngine.Animator            m_outputAnimator  // 0x10
  private           UnityEngine.Animations.AnimationPlayableOutputm_Output  // 0x18
  private   readonly System.Collections.Generic.List<UnityEngine.Timeline.AnimationOutputWeightProcessor.WeightInfo>m_Mixers  // 0x28
METHODS:
  RVA=0x09D20768  token=0x6000058  System.Void .ctor(UnityEngine.Animations.AnimationPlayableOutput output, UnityEngine.Animator animator)
  RVA=0x09D203A0  token=0x6000059  System.Void FindMixers()
  RVA=0x09D20494  token=0x600005A  System.Void FindMixers(UnityEngine.Playables.Playable parent, System.Int32 port, UnityEngine.Playables.Playable node)
  RVA=0x09D201A4  token=0x600005B  System.Void Evaluate()
END_CLASS

CLASS: UnityEngine.Timeline.AnimationPlayableAsset
TYPE:  class
TOKEN: 0x2000020
SIZE:  0x90
EXTENDS: UnityEngine.Playables.PlayableAsset
IMPLEMENTS: UnityEngine.Timeline.ITimelineClipAsset UnityEngine.Timeline.IPropertyPreview UnityEngine.ISerializationCallbackReceiver
FIELDS:
  private           UnityEngine.AnimationClip       m_Clip  // 0x18
  private           UnityEngine.Vector3             m_Position  // 0x20
  private           UnityEngine.Vector3             m_EulerAngles  // 0x2c
  private           System.Boolean                  m_UseTrackMatchFields  // 0x38
  private           UnityEngine.Timeline.MatchTargetFieldsm_MatchTargetFields  // 0x3c
  private           System.Boolean                  m_RemoveStartOffset  // 0x40
  private           System.Boolean                  m_ApplyFootIK  // 0x41
  private           UnityEngine.Timeline.AnimationPlayableAsset.LoopModem_Loop  // 0x44
  private           System.Boolean                  m_IgniteOnce  // 0x48
  private           System.Boolean                  m_OnlyDeltaTime  // 0x49
  private           System.Boolean                  m_DynamicLink  // 0x4a
  private           UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOptionm_ClothResetOption  // 0x4c
  private           UnityEngine.Timeline.AnimationPlayableAsset.AnimationEventTriggerModem_AnimationEventTriggerMode  // 0x50
  private           System.Boolean                  m_MixWitherAnotherClip  // 0x54
  private           System.Single                   m_MainClipMixWeight  // 0x58
  private           UnityEngine.AnimationClip       m_AnotherClip  // 0x60
  private           UnityEngine.Timeline.AppliedOffsetMode<appliedOffsetMode>k__BackingField  // 0x68
  private           UnityEngine.Timeline.ITimelineAnimationEventContextBinding<TimelineAnimationEventContextBinding>k__BackingField  // 0x70
  private   static readonly System.Int32                    k_LatestVersion  // static @ 0x0
  private           System.Int32                    m_Version  // 0x78
  private           UnityEngine.Quaternion          m_Rotation  // 0x7c
PROPERTIES:
  position  get=0x03D59660  set=0x03D5AE00
  rotation  get=0x09D21A38  set=0x09D21B18
  eulerAngles  get=0x03D59800  set=0x03D5BF30
  useTrackMatchFields  get=0x03D4F190  set=0x03D4E280
  matchTargetFields  get=0x03D4ED90  set=0x03D4EDC0
  removeStartOffset  get=0x03D4EE90  set=0x03D4EEB0
  applyFootIK  get=0x03D4F7B0  set=0x03D4F7D0
  loop  get=0x03D4EE80  set=0x03D4EEA0
  IgniteOnce  get=0x03D4EFE0  set=0x03D4F010
  OnlyDeltaTime  get=0x03D4EFF0  set=0x03D4F020
  DynamicLink  get=0x03D4F780  set=0x03D4F790
  MixWithAnotherClip  get=0x03D4F320  set=0x03D4F350
  AnotherClip  get=0x03D4EB00  set=0x039274B0
  MainClipMixWeight  get=0x03D51080  set=0x03D510B0
  hasRootTransforms  get=0x09D21948
  appliedOffsetMode  get=0x03D4EEE0  set=0x03D4EF30
  TimelineAnimationEventContextBinding  get=0x03D4EB30  set=0x0519C3C8
  clip  get=0x01041090  set=0x09D21A74
  duration  get=0x09D218E0
  clothResetOption  get=0x03D4EDF0  set=0x03D4EE30
  animationEventTriggerMode  get=0x03D4EED0  set=0x03D4EF20
  outputs  get=0x09D219C8
  clipCaps  get=0x09D217F0
METHODS:
  RVA=0x09D211EC  token=0x6000085  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go)
  RVA=0x09D20ED4  token=0x6000086  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, UnityEngine.Vector3 positionOffset, UnityEngine.Vector3 eulerOffset, System.Boolean removeStartOffset, UnityEngine.Timeline.AppliedOffsetMode mode, System.Boolean applyFootIK, UnityEngine.Timeline.AnimationPlayableAsset.LoopMode loop)
  RVA=0x09D20914  token=0x6000087  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.AnimationPlayableAsset playableAsset)
  RVA=0x09D20890  token=0x6000088  UnityEngine.Animations.AnimationClipPlayable CreateAnimationClipPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, System.Boolean removeStartOffset, System.Boolean applyFootIK, UnityEngine.Timeline.AnimationPlayableAsset.LoopMode loop)
  RVA=0x09D213F0  token=0x6000089  System.Boolean ShouldApplyOffset(UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.AnimationClip clip)
  RVA=0x09D21388  token=0x600008A  System.Boolean ShouldApplyEventControl(UnityEngine.Timeline.AnimationPlayableAsset playableAsset)
  RVA=0x09D21460  token=0x600008B  UnityEngine.Playables.Playable TryApplyAnimationEventControl(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable root, UnityEngine.Timeline.AnimationPlayableAsset playableAsset)
  RVA=0x09D2144C  token=0x600008C  System.Boolean ShouldApplyScaleRemove(UnityEngine.Timeline.AppliedOffsetMode mode)
  RVA=0x09D21364  token=0x600008E  System.Void ResetOffsets()
  RVA=0x09D21264  token=0x600008F  System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
  RVA=0x09D212B4  token=0x6000090  System.Boolean HasRootTransforms(UnityEngine.AnimationClip clip)
  RVA=0x09D20870  token=0x6000091  UnityEngine.AnimationEvent[] CollectAnimationEvents()
  RVA=0x09D216B0  token=0x6000092  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  RVA=0x09D2164C  token=0x6000093  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  RVA=0x09D21354  token=0x6000094  System.Void OnUpgradeFromVersion(System.Int32 oldVersion)
  RVA=0x09D21744  token=0x6000095  System.Void .ctor()
  RVA=0x09D21708  token=0x6000096  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.AnimationPreviewUpdateCallback
TYPE:  class
TOKEN: 0x2000027
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.MatchTargetFields
TYPE:  sealed struct
TOKEN: 0x2000028
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.MatchTargetFieldsPositionX  // const
  public    static  UnityEngine.Timeline.MatchTargetFieldsPositionY  // const
  public    static  UnityEngine.Timeline.MatchTargetFieldsPositionZ  // const
  public    static  UnityEngine.Timeline.MatchTargetFieldsRotationX  // const
  public    static  UnityEngine.Timeline.MatchTargetFieldsRotationY  // const
  public    static  UnityEngine.Timeline.MatchTargetFieldsRotationZ  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.TrackOffset
TYPE:  sealed struct
TOKEN: 0x2000029
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TrackOffsetApplyTransformOffsets  // const
  public    static  UnityEngine.Timeline.TrackOffsetApplySceneOffsets  // const
  public    static  UnityEngine.Timeline.TrackOffsetAuto  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.AppliedOffsetMode
TYPE:  sealed struct
TOKEN: 0x200002A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.AppliedOffsetModeNoRootTransform  // const
  public    static  UnityEngine.Timeline.AppliedOffsetModeTransformOffset  // const
  public    static  UnityEngine.Timeline.AppliedOffsetModeSceneOffset  // const
  public    static  UnityEngine.Timeline.AppliedOffsetModeTransformOffsetLegacy  // const
  public    static  UnityEngine.Timeline.AppliedOffsetModeSceneOffsetLegacy  // const
  public    static  UnityEngine.Timeline.AppliedOffsetModeSceneOffsetEditor  // const
  public    static  UnityEngine.Timeline.AppliedOffsetModeSceneOffsetLegacyEditor  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.MatchTargetFieldConstants
TYPE:  static class
TOKEN: 0x200002B
SIZE:  0x10
FIELDS:
  public    static  UnityEngine.Timeline.MatchTargetFieldsAll  // static @ 0x0
  public    static  UnityEngine.Timeline.MatchTargetFieldsNone  // static @ 0x4
  public    static  UnityEngine.Timeline.MatchTargetFieldsPosition  // static @ 0x8
  public    static  UnityEngine.Timeline.MatchTargetFieldsRotation  // static @ 0xc
METHODS:
  RVA=0x09D29F84  token=0x60000A0  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.AnimationTrack
TYPE:  class
TOKEN: 0x200002C
SIZE:  0x188
EXTENDS: UnityEngine.Timeline.TrackAsset
IMPLEMENTS: UnityEngine.Timeline.ILayerable
FIELDS:
  private   static  System.String                   k_DefaultInfiniteClipName  // const
  private   static  System.String                   k_DefaultRecordableClipName  // const
  private           UnityEngine.Timeline.TimelineClip.ClipExtrapolationm_InfiniteClipPreExtrapolation  // 0xc0
  private           UnityEngine.Timeline.TimelineClip.ClipExtrapolationm_InfiniteClipPostExtrapolation  // 0xc4
  private           UnityEngine.Vector3             m_InfiniteClipOffsetPosition  // 0xc8
  private           UnityEngine.Vector3             m_InfiniteClipOffsetEulerAngles  // 0xd4
  private           System.Double                   m_InfiniteClipTimeOffset  // 0xe0
  private           System.Boolean                  m_InfiniteClipRemoveOffset  // 0xe8
  private           System.Boolean                  m_InfiniteClipApplyFootIK  // 0xe9
  private           UnityEngine.Timeline.AnimationPlayableAsset.LoopModemInfiniteClipLoop  // 0xec
  private           UnityEngine.Timeline.MatchTargetFieldsm_MatchTargetFields  // 0xf0
  private           UnityEngine.Vector3             m_Position  // 0xf4
  private           UnityEngine.Vector3             m_EulerAngles  // 0x100
  private           UnityEngine.AvatarMask          m_AvatarMask  // 0x110
  private           System.Boolean                  m_ApplyAvatarMask  // 0x118
  private           System.Boolean                  m_DisableFloatCurveOnMask  // 0x119
  private           UnityEngine.Timeline.TrackOffsetm_TrackOffset  // 0x11c
  private           UnityEngine.AnimationClip       m_InfiniteClip  // 0x120
  private           System.Boolean                  m_IsAdditive  // 0x128
  private           System.Boolean                  m_IsAdditiveToLast  // 0x129
  public            System.Boolean                  muteScriptAnimAddon  // 0x12a
  private           System.Boolean                  m_UseScriptAnimAddon  // 0x12b
  private           System.Boolean                  m_useTPoseAsDefaultPose  // 0x12c
  private           UnityEngine.AnimationClip       m_TPoseClip  // 0x130
  private           UnityEngine.ScriptableObject    m_TimelineNPCDescriptor  // 0x138
  private           System.String                   m_LookAtTargetPath  // 0x140
  private           System.Boolean                  m_LookAtUseAdditive  // 0x148
  private           System.Boolean                  m_WriteTransformDefAsPostProcess  // 0x149
  private           UnityEngine.Transform           m_LookAtTarget  // 0x150
  private           System.Collections.Generic.HashSet<UnityEngine.Timeline.RuntimeElement>m_allRuntimeClipUnderTrack  // 0x158
  private   static readonly System.Collections.Generic.Queue<UnityEngine.Transform>s_CachedQueue  // static @ 0x0
  private           UnityEngine.Quaternion          m_OpenClipOffsetRotation  // 0x160
  private           UnityEngine.Quaternion          m_Rotation  // 0x170
  private           System.Boolean                  m_ApplyOffsets  // 0x180
PROPERTIES:
  position  get=0x03D85530  set=0x03D855F0
  rotation  get=0x09D26038  set=0x09D26124
  eulerAngles  get=0x03D854C0  set=0x03D85560
  applyOffsets  get=0x0115F4C0  set=0x0350B670
  trackOffset  get=0x03D5D760  set=0x03D5D770
  matchTargetFields  get=0x03D50F00  set=0x09D260A8
  infiniteClip  get=0x03D56D50  set=0x04275CA4
  infiniteClipRemoveOffset  get=0x03D554A0  set=0x03D554D0
  avatarMask  get=0x03D56CF0  set=0x04275CF4
  applyAvatarMask  get=0x03D57B90  set=0x03D5E110
  disableFloatCurveOnMask  get=0x03D854B0  set=0x03D85550
  isUsingScriptAnimAddon  get=0x03D85520  set=0x03D855E0
  lookAtUseAdditive  get=0x03D57CB0  set=0x03D5A1F0
  outputs  get=0x09D25FC8
  inClipMode  get=0x09D25F18
  infiniteClipOffsetPosition  get=0x03D85500  set=0x03D855B0
  infiniteClipOffsetRotation  get=0x09D25F60  set=0x09D26078
  infiniteClipOffsetEulerAngles  get=0x03D854E0  set=0x03D85590
  infiniteClipApplyFootIK  get=0x03D58EB0  set=0x03D85580
  infiniteClipTimeOffset  get=0x03D6B260  set=0x03D855D0
  infiniteClipPreExtrapolation  get=0x03D57EF0  set=0x03D57F70
  infiniteClipPostExtrapolation  get=0x03D68ED0  set=0x03D68F40
  infiniteClipLoop  get=0x03D58150  set=0x03D68F50
  openClipOffsetPosition  get=0x03D85500  set=0x03D855B0
  openClipOffsetRotation  get=0x09D25FA0  set=0x09D26104
  openClipOffsetEulerAngles  get=0x03D854E0  set=0x03D85590
  openClipPreExtrapolation  get=0x03D57EF0  set=0x03D57F70
  openClipPostExtrapolation  get=0x03D68ED0  set=0x03D68F40
METHODS:
  RVA=0x09D2559C  token=0x60000BB  System.Boolean IsControlByThisTrack(UnityEngine.Timeline.RuntimeElement element)
  RVA=0x09D22EB8  token=0x60000BC  System.Boolean CanCompileClips()
  RVA=0x09D25A00  token=0x60000CF  System.Void ResetOffsets()
  RVA=0x09D2379C  token=0x60000D0  UnityEngine.Timeline.TimelineClip CreateClip(UnityEngine.AnimationClip clip)
  RVA=0x09D238A8  token=0x60000D1  System.Void CreateInfiniteClip(System.String infiniteClipName)
  RVA=0x09D24A20  token=0x60000D2  UnityEngine.Timeline.TimelineClip CreateRecordableClip(System.String animClipName)
  RVA=0x09D258A4  token=0x60000D3  System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip)
  RVA=0x09D22E44  token=0x60000D4  System.Int32 CalculateItemsHash()
  RVA=0x0350B670  token=0x60000D5  System.Void UpdateClipOffsets()
  RVA=0x09D25B9C  token=0x60000D6  UnityEngine.Playables.Playable _CreatePlayableFromClip(UnityEngine.Timeline.TimelineClip c, UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.Timeline.ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding)
  RVA=0x09D22F6C  token=0x60000D7  UnityEngine.Playables.Playable CompileTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.AnimationTrack track, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.Timeline.ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding)
  RVA=0x09D25A30  token=0x60000D8  System.Boolean ShouldLinkWithMainTrackMixer(UnityEngine.Timeline.AnimationTrack animationTrack)
  RVA=0x09D220A0  token=0x60000D9  UnityEngine.Playables.Playable ApplyScriptAnimationPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable mixer, UnityEngine.GameObject go)
  RVA=0x09D25AB4  token=0x60000DA  UnityEngine.Playables.Playable UnityEngine.Timeline.ILayerable.CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount)
  RVA=0x09D23CFC  token=0x60000DB  UnityEngine.Playables.Playable CreateMixerPlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree)
  RVA=0x0350B670  token=0x60000DC  System.Void AttachCustomBlend(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable layerMixer)
  RVA=0x09D228B8  token=0x60000DD  System.Void AttachLastAdditiveClip(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable layerMixer, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, System.Collections.Generic.List<UnityEngine.Timeline.AnimationTrack> flattenTracks, UnityEngine.Timeline.ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding)
  RVA=0x01168950  token=0x60000DE  System.Int32 GetDefaultBlendCount()
  RVA=0x0350B670  token=0x60000DF  System.Void AttachDefaultBlend(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable mixer, System.Boolean requireOffset, UnityEngine.Animator animator)
  RVA=0x09D22D0C  token=0x60000E0  UnityEngine.Playables.Playable AttachOffsetPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable playable, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  RVA=0x09D2591C  token=0x60000E1  System.Boolean RequiresMotionXPlayable(UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.GameObject gameObject)
  RVA=0x09D25B04  token=0x60000E2  System.Boolean UsesAbsoluteMotion(UnityEngine.Timeline.AppliedOffsetMode mode)
  RVA=0x09D254BC  token=0x60000E3  System.Boolean HasController(UnityEngine.GameObject gameObject)
  RVA=0x09D24FDC  token=0x60000E4  UnityEngine.Animator GetBinding(UnityEngine.Playables.PlayableDirector director)
  RVA=0x09D23830  token=0x60000E5  UnityEngine.Animations.AnimationLayerMixerPlayable CreateGroupMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount)
  RVA=0x09D23994  token=0x60000E6  UnityEngine.Playables.Playable CreateInfiniteTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.AppliedOffsetMode mode)
  RVA=0x09D22550  token=0x60000E7  UnityEngine.Playables.Playable ApplyTrackOffset(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable root, UnityEngine.GameObject go, UnityEngine.Timeline.AppliedOffsetMode mode)
  RVA=0x09D25B14  token=0x60000E8  System.Void _AddClipIntoTree(UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.RuntimeClip clip)
  RVA=0x09D25154  token=0x60000E9  System.Void GetEvaluationTime(System.Double& outStart, System.Double& outDuration)
  RVA=0x09D253EC  token=0x60000EA  System.Void GetSequenceTime(System.Double& outStart, System.Double& outDuration)
  RVA=0x09D226D4  token=0x60000EB  System.Void AssignAnimationClip(UnityEngine.Timeline.TimelineClip clip, UnityEngine.AnimationClip animClip)
  RVA=0x0350B670  token=0x60000EC  System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
  RVA=0x09D24CEC  token=0x60000ED  System.Void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> animClips)
  RVA=0x09D25388  token=0x60000EE  UnityEngine.Timeline.AppliedOffsetMode GetOffsetMode(UnityEngine.GameObject go, System.Boolean animatesRootTransform)
  RVA=0x09D255F8  token=0x60000EF  System.Boolean IsRootTransformDisabledByMask(UnityEngine.GameObject gameObject, UnityEngine.Transform genericRootNode)
  RVA=0x09D251E0  token=0x60000F0  UnityEngine.Transform GetGenericRootNode(UnityEngine.GameObject gameObject)
  RVA=0x09D21C50  token=0x60000F1  System.Boolean AnimatesRootTransform()
  RVA=0x09D24B2C  token=0x60000F2  UnityEngine.Transform FindInHierarchyBreadthFirst(UnityEngine.Transform t, System.String name)
  RVA=0x09D258DC  token=0x60000FD  System.Void OnUpgradeFromVersion(System.Int32 oldVersion)
  RVA=0x09D25D94  token=0x60000FE  System.Void .ctor()
  RVA=0x09D25D00  token=0x60000FF  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.ICurvesOwner
TYPE:  interface
TOKEN: 0x200002F
FIELDS:
PROPERTIES:
  defaultCurvesName  get=-1  // abstract
  asset  get=-1  // abstract
  assetOwner  get=-1  // abstract
  targetTrack  get=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.TimelineClip
TYPE:  class
TOKEN: 0x2000030
SIZE:  0xB8
IMPLEMENTS: UnityEngine.Timeline.ICurvesOwner UnityEngine.ISerializationCallbackReceiver
FIELDS:
  private   static  System.Int32                    k_LatestVersion  // const
  private           System.Int32                    m_Version  // 0x10
  public    static readonly UnityEngine.Timeline.ClipCaps   kDefaultClipCaps  // static @ 0x0
  public    static readonly System.Single                   kDefaultClipDurationInSeconds  // static @ 0x4
  public    static readonly System.Double                   kTimeScaleMin  // static @ 0x8
  public    static readonly System.Double                   kTimeScaleMax  // static @ 0x10
  private   static readonly System.String                   kDefaultCurvesName  // static @ 0x18
  private   static readonly System.Double                   kMinDuration  // static @ 0x20
  private   static readonly System.Double                   kMaxTimeValue  // static @ 0x28
  public            System.Int32                    optionIndex  // 0x14
  private           System.Double                   m_Start  // 0x18
  private           System.Double                   m_ClipIn  // 0x20
  private           UnityEngine.Object              m_Asset  // 0x28
  private           System.Double                   m_Duration  // 0x30
  private           System.Double                   m_TimeScale  // 0x38
  private           UnityEngine.Timeline.TrackAsset m_ParentTrack  // 0x40
  private           System.Double                   m_EaseInDuration  // 0x48
  private           System.Double                   m_EaseOutDuration  // 0x50
  private           System.Double                   m_BlendInDuration  // 0x58
  private           System.Double                   m_BlendOutDuration  // 0x60
  private           UnityEngine.AnimationCurve      m_MixInCurve  // 0x68
  private           UnityEngine.AnimationCurve      m_MixOutCurve  // 0x70
  private           UnityEngine.Timeline.TimelineClip.BlendCurveModem_BlendInCurveMode  // 0x78
  private           UnityEngine.Timeline.TimelineClip.BlendCurveModem_BlendOutCurveMode  // 0x7c
  private           System.Collections.Generic.List<System.String>m_ExposedParameterNames  // 0x80
  private           UnityEngine.AnimationClip       m_AnimationCurves  // 0x88
  private           System.Boolean                  m_Recordable  // 0x90
  private           UnityEngine.Timeline.TimelineClip.ClipExtrapolationm_PostExtrapolationMode  // 0x94
  private           UnityEngine.Timeline.TimelineClip.ClipExtrapolationm_PreExtrapolationMode  // 0x98
  private           System.Double                   m_PostExtrapolationTime  // 0xa0
  private           System.Double                   m_PreExtrapolationTime  // 0xa8
  private           System.String                   m_DisplayName  // 0xb0
PROPERTIES:
  timeScale  get=0x09D2DA8C
  start  get=0x03D4EBD0  set=0x09D2DE24
  duration  get=0x03D4F240  set=0x09D2DB50
  end  get=0x03D85640
  clipIn  get=0x09D2D658
  displayName  get=0x03D4EAD0  set=0x02B47080
  clipAssetDuration  get=0x09D2D588
  curves  get=0x03D4EA60
  UnityEngine.Timeline.ICurvesOwner.defaultCurvesName  get=0x09D2D4B8
  asset  get=0x03D4EAC0  set=0x02C92F10
  UnityEngine.Timeline.ICurvesOwner.assetOwner  get=0x03D4E2B0
  UnityEngine.Timeline.ICurvesOwner.targetTrack  get=0x03D4E2B0
  easeInDuration  get=0x09D2D67C  set=0x09D2DBE4
  easeOutDuration  get=0x09D2D710  set=0x09D2DCC8
  blendInDuration  get=0x09D2D540
  blendOutDuration  get=0x09D2D564
  hasBlendIn  get=0x09D2D880
  hasBlendOut  get=0x09D2D8B0
  mixInCurve  get=0x09D2D8E0  set=0x038C5570
  mixInDuration  get=0x09D2D948
  mixOutCurve  get=0x09D2D978  set=0x0519C3C8
  mixOutTime  get=0x09D2DA10
  mixOutDuration  get=0x09D2D9E0
  recordable  get=0x03D58A70  set=0x03D58AB0
  clipCaps  get=0x09D2D5E0
  postExtrapolationMode  get=0x09D2DA44  set=0x09D2DDAC
  preExtrapolationMode  get=0x09D2DA68  set=0x09D2DDE8
  extrapolatedStart  get=0x09D2D868
  extrapolatedDuration  get=0x09D2D7A4
METHODS:
  RVA=0x09D2D508  token=0x600010F  System.Void UpgradeToLatestVersion()
  RVA=0x09D2D518  token=0x6000110  System.Void .ctor(UnityEngine.Timeline.TrackAsset parent)
  RVA=0x03D4E2B0  token=0x6000121  UnityEngine.Timeline.TrackAsset GetParentTrack()
  RVA=0x09D2D148  token=0x6000122  System.Void SetParentTrack_Internal(UnityEngine.Timeline.TrackAsset newParentTrack)
  RVA=0x09D2CF04  token=0x6000135  System.Int32 Hash()
  RVA=0x09D2CC90  token=0x6000136  System.Single EvaluateMixOut(System.Double time)
  RVA=0x09D2CBCC  token=0x6000137  System.Single EvaluateMixOutAtGivenTime(System.Double time, System.Double mixOutTime, System.Double mixOutDuration)
  RVA=0x09D2CAF0  token=0x6000138  System.Single EvaluateMixIn(System.Double time)
  RVA=0x09D2CA2C  token=0x6000139  System.Single EvaluateMixInAtGivenTime(System.Double time, System.Double runtimeMixInTime, System.Double mixInDuration)
  RVA=0x09D2CD74  token=0x600013A  UnityEngine.AnimationCurve GetDefaultMixInCurve()
  RVA=0x09D2CD9C  token=0x600013B  UnityEngine.AnimationCurve GetDefaultMixOutCurve()
  RVA=0x09D2D228  token=0x600013C  System.Double ToLocalTime(System.Double time)
  RVA=0x09D2D050  token=0x600013D  System.Double SanitizeTimeValue(System.Double value, System.Double defaultValue)
  RVA=0x03D85620  token=0x6000142  System.Void SetPostExtrapolationTime(System.Double time)
  RVA=0x03D85630  token=0x6000143  System.Void SetPreExtrapolationTime(System.Double time)
  RVA=0x09D2D008  token=0x6000144  System.Boolean IsPreExtrapolatedTime(System.Double sequenceTime)
  RVA=0x09D2CFB0  token=0x6000145  System.Boolean IsPostExtrapolatedTime(System.Double sequenceTime)
  RVA=0x09D2CDC4  token=0x6000148  System.Double GetExtrapolatedTime(System.Double time, UnityEngine.Timeline.TimelineClip.ClipExtrapolation mode, System.Double duration)
  RVA=0x03D51DD0  token=0x6000149  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  RVA=0x03528C50  token=0x600014A  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  RVA=0x09D2D33C  token=0x600014B  System.String ToString()
  RVA=0x0350B670  token=0x600014C  System.Void UpdateDirty(System.Double oldValue, System.Double newValue)
  RVA=0x03C916F0  token=0x600014D  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.TimelineAsset
TYPE:  class
TOKEN: 0x2000035
SIZE:  0x68
EXTENDS: UnityEngine.Playables.PlayableAsset
IMPLEMENTS: UnityEngine.ISerializationCallbackReceiver UnityEngine.Timeline.ITimelineClipAsset UnityEngine.Timeline.IPropertyPreview
FIELDS:
  private   static  System.Int32                    k_LatestVersion  // const
  private           System.Int32                    m_Version  // 0x18
  private           System.Collections.Generic.List<UnityEngine.ScriptableObject>m_Tracks  // 0x20
  private           System.Double                   m_FixedDuration  // 0x28
  private           UnityEngine.Timeline.TrackAsset[]m_CacheOutputTracks  // 0x30
  private           UnityEngine.Timeline.GroupTrack[]m_CacheGroupTracks  // 0x38
  private           System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset>m_CacheRootTracks  // 0x40
  private           UnityEngine.Timeline.TrackAsset[]m_CacheFlattenedTracks  // 0x48
  private           UnityEngine.Timeline.TimelineAsset.EditorSettingsm_EditorSettings  // 0x50
  private           UnityEngine.Timeline.TimelineAsset.DurationModem_DurationMode  // 0x58
  private           UnityEngine.Timeline.MarkerTrackm_MarkerTrack  // 0x60
PROPERTIES:
  editorSettings  get=0x03D4EAF0
  duration  get=0x09D2C640
  fixedDuration  get=0x09D2C6C0  set=0x09D2C978
  durationMode  get=0x03D4EF00  set=0x03D4EF50
  outputs  get=0x09D2C8C0
  clipCaps  get=0x09D2C42C
  outputTrackCount  get=0x09D2C898
  rootTrackCount  get=0x09D2C930
  flattenedTracks  get=0x09D2C740
  markerTrack  get=0x03D4EB00
  trackObjects  get=0x03D4EB40
METHODS:
  RVA=0x0350B670  token=0x600014F  System.Void UpgradeToLatestVersion()
  RVA=0x09D2BE0C  token=0x600015A  System.Void OnValidate()
  RVA=0x09D2B930  token=0x600015B  UnityEngine.Timeline.TrackAsset GetRootTrack(System.Int32 index)
  RVA=0x09D2B98C  token=0x600015C  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetRootTracks()
  RVA=0x09D2B8D0  token=0x600015D  UnityEngine.Timeline.TrackAsset GetOutputTrack(System.Int32 index)
  RVA=0x09D2B914  token=0x600015E  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetOutputTracks()
  RVA=0x09D2B8B4  token=0x600015F  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.GroupTrack> GetGroupTracks()
  RVA=0x09D2B9A8  token=0x6000160  System.Double GetValidFrameRate(System.Double frameRate)
  RVA=0x09D2C1A4  token=0x6000161  System.Void UpdateRootTrackCache()
  RVA=0x09D2BF5C  token=0x6000162  System.Void UpdateOutputTrackCache()
  RVA=0x09D2B8AC  token=0x6000164  UnityEngine.Timeline.TrackAsset[] GetAllTracks()
  RVA=0x09D2A4A4  token=0x6000167  System.Void AddTrackInternal(UnityEngine.Timeline.TrackAsset track)
  RVA=0x09D2BE40  token=0x6000168  System.Void RemoveTrack(UnityEngine.Timeline.TrackAsset track)
  RVA=0x09D2A978  token=0x6000169  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go)
  RVA=0x03D85610  token=0x600016A  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  RVA=0x03190890  token=0x600016B  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  RVA=0x0336A0D0  token=0x600016C  System.Void __internalAwake()
  RVA=0x09D2B748  token=0x600016D  System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
  RVA=0x09D2A8A4  token=0x600016E  System.Void CreateMarkerTrack()
  RVA=0x03190D90  token=0x600016F  System.Void Invalidate()
  RVA=0x09D2BF00  token=0x6000170  System.Void UpdateFixedDurationWithItemsDuration()
  RVA=0x09D2A770  token=0x6000171  UnityEngine.Timeline.DiscreteTime CalculateItemsDuration()
  RVA=0x09D2A2CC  token=0x6000172  System.Void AddSubTracksRecursive(UnityEngine.Timeline.TrackAsset track, System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset>& allTracks)
  RVA=0x09D2AC80  token=0x6000173  UnityEngine.Timeline.TrackAsset CreateTrack(System.Type type, UnityEngine.Timeline.TrackAsset parent, System.String name)
  RVA=-1  // generic def  token=0x6000174  T CreateTrack(UnityEngine.Timeline.TrackAsset parent, System.String trackName)
  RVA=-1  // generic def  token=0x6000175  T CreateTrack(System.String trackName)
  RVA=-1  // generic def  token=0x6000176  T CreateTrack()
  RVA=0x09D2AF9C  token=0x6000177  System.Boolean DeleteClip(UnityEngine.Timeline.TimelineClip clip)
  RVA=0x09D2B3BC  token=0x6000178  System.Boolean DeleteTrack(UnityEngine.Timeline.TrackAsset track)
  RVA=0x09D2BA48  token=0x6000179  System.Void MoveLastTrackBefore(UnityEngine.Timeline.TrackAsset asset)
  RVA=0x09D2BC04  token=0x600017A  System.Void MoveTrackAfter(UnityEngine.Timeline.TrackAsset trackToMove, UnityEngine.Timeline.TrackAsset targetTrack)
  RVA=0x09D2A514  token=0x600017B  UnityEngine.Timeline.TrackAsset AllocateTrack(UnityEngine.Timeline.TrackAsset trackAssetParent, System.String trackName, System.Type trackType)
  RVA=0x09D2B138  token=0x600017C  System.Void DeleteRecordedAnimation(UnityEngine.Timeline.TrackAsset track)
  RVA=0x09D2B23C  token=0x600017D  System.Void DeleteRecordedAnimation(UnityEngine.Timeline.TimelineClip clip)
  RVA=0x03151690  token=0x600017E  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.TrackAsset
TYPE:  abstract class
TOKEN: 0x200003C
SIZE:  0xC0
EXTENDS: UnityEngine.Playables.PlayableAsset
IMPLEMENTS: UnityEngine.ISerializationCallbackReceiver UnityEngine.Timeline.IPropertyPreview UnityEngine.Timeline.ICurvesOwner UnityEngine.Timeline.IDynamicBinding
FIELDS:
  private   static  System.Int32                    k_LatestVersion  // const
  private           System.Int32                    m_Version  // 0x18
  private           UnityEngine.AnimationClip       m_AnimClip  // 0x20
  public            System.Boolean                  useAutoBinding  // 0x28
  public            System.String                   autoBindingPath  // 0x30
  public            System.String                   uniqueId  // 0x38
  private   static  UnityEngine.Timeline.TrackAsset.TransientBuildDatas_BuildData  // static @ 0x0
  private   static  System.String                   kDefaultCurvesName  // const
  private   static  System.Action<UnityEngine.Timeline.TimelineClip,UnityEngine.GameObject,UnityEngine.Playables.Playable>OnClipPlayableCreate  // static @ 0x18
  private   static  System.Action<UnityEngine.Timeline.TrackAsset,UnityEngine.GameObject,UnityEngine.Playables.Playable>OnTrackAnimationPlayableCreate  // static @ 0x20
  private           System.Boolean                  m_RuntimeMuted  // 0x40
  private           System.Boolean                  m_Locked  // 0x41
  private           System.Boolean                  m_Muted  // 0x42
  private           System.String                   m_CustomPlayableFullTypename  // 0x48
  private           UnityEngine.AnimationClip       m_Curves  // 0x50
  private           UnityEngine.Playables.PlayableAssetm_Parent  // 0x58
  private           System.Collections.Generic.List<UnityEngine.ScriptableObject>m_Children  // 0x60
  private           System.Int32                    m_ItemsHash  // 0x68
  private           UnityEngine.Timeline.TimelineClip[]m_ClipsCache  // 0x70
  private           UnityEngine.Timeline.DiscreteTimem_Start  // 0x78
  private           UnityEngine.Timeline.DiscreteTimem_End  // 0x80
  private           System.Boolean                  m_CacheSorted  // 0x88
  private           System.Nullable<System.Boolean> m_SupportsNotifications  // 0x89
  private   static  UnityEngine.Timeline.TrackAsset[]s_EmptyCache  // static @ 0x28
  private           System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset>m_ChildTrackCache  // 0x90
  private   static  System.Collections.Generic.Dictionary<System.Type,UnityEngine.Timeline.TrackBindingTypeAttribute>s_TrackBindingTypeAttributeCache  // static @ 0x30
  protected internal        System.Collections.Generic.List<UnityEngine.Timeline.TimelineClip>m_Clips  // 0x98
  private           UnityEngine.Timeline.MarkerList m_Markers  // 0xa0
  public            System.Int32                    OptionIndex  // 0xb8
  public            System.Boolean                  useRuntimeMuted  // 0xbc
PROPERTIES:
  start  get=0x09D33AD8
  end  get=0x09D3366C
  duration  get=0x09D33608
  muted  get=0x09D33A54  set=0x03D4F7C0
  runtimeMuted  get=0x03D4EE90  set=0x03D4EEB0
  mutedInHierarchy  get=0x09D33960
  timelineAsset  get=0x03190C70
  parent  get=0x03D4EAA0  set=0x03081D30
  clips  get=0x09D3353C
  isEmpty  get=0x09D33778
  hasClips  get=0x09D336C0
  hasCurves  get=0x09D33708
  isSubTrack  get=0x09D337B4
  outputs  get=0x09D33A68
  customPlayableTypename  get=0x03D4EA70  set=0x02692290
  curves  get=0x03D4EAF0  set=0x02C926C0
  UnityEngine.Timeline.ICurvesOwner.defaultCurvesName  get=0x09D32F20
  UnityEngine.Timeline.ICurvesOwner.asset  get=0x0339AE90
  UnityEngine.Timeline.ICurvesOwner.assetOwner  get=0x09D32F18
  UnityEngine.Timeline.ICurvesOwner.targetTrack  get=0x0339AE90
  subTracksObjects  get=0x03D4EB00
  locked  get=0x03D4F7B0  set=0x03D4F7D0
  lockedInHierarchy  get=0x09D33874
  supportsNotifications  get=0x09D33B28
EVENTS:
  OnClipPlayableCreate  add=add_OnClipPlayableCreate  remove=remove_OnClipPlayableCreate
  OnTrackAnimationPlayableCreate  add=add_OnTrackAnimationPlayableCreate  remove=remove_OnTrackAnimationPlayableCreate
METHODS:
  RVA=0x0350B670  token=0x600018D  System.Void OnBeforeTrackSerialize()
  RVA=0x0350B670  token=0x600018E  System.Void OnAfterTrackDeserialize()
  RVA=0x0350B670  token=0x600018F  System.Void OnUpgradeFromVersion(System.Int32 oldVersion)
  RVA=0x09D32E04  token=0x6000190  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  RVA=0x031908A0  token=0x6000191  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  RVA=0x0350B670  token=0x6000192  System.Void UpgradeToLatestVersion()
  RVA=0x09D32120  token=0x60001A2  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TimelineClip> GetClips()
  RVA=0x09D31DBC  token=0x60001A9  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetChildTracks()
  RVA=0x03504410  token=0x60001B7  System.Void __internalAwake()
  RVA=0x09D2FE38  token=0x60001B8  System.Void CreateCurves(System.String curvesClipName)
  RVA=0x09D313F4  token=0x60001B9  UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount)
  RVA=0x09D31138  token=0x60001BA  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go)
  RVA=0x09D2FED8  token=0x60001BB  UnityEngine.Timeline.TimelineClip CreateDefaultClip()
  RVA=-1  // generic def  token=0x60001BC  UnityEngine.Timeline.TimelineClip CreateClip()
  RVA=0x09D31464  token=0x60001BD  System.Boolean DeleteClip(UnityEngine.Timeline.TimelineClip clip)
  RVA=0x09D30238  token=0x60001BE  UnityEngine.Timeline.IMarker CreateMarker(System.Type type, System.Double time)
  RVA=-1  // generic def  token=0x60001BF  T CreateMarker(System.Double time)
  RVA=0x09D315B4  token=0x60001C0  System.Boolean DeleteMarker(UnityEngine.Timeline.IMarker marker)
  RVA=0x03190B20  token=0x60001C1  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetMarkers()
  RVA=0x09D31DDC  token=0x60001C2  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetClipMarkers()
  RVA=0x09D32440  token=0x60001C3  System.Int32 GetMarkerCount()
  RVA=0x09D32450  token=0x60001C4  UnityEngine.Timeline.IMarker GetMarker(System.Int32 idx)
  RVA=0x09D2FD1C  token=0x60001C5  UnityEngine.Timeline.TimelineClip CreateClip(System.Type requestedType)
  RVA=0x09D2F668  token=0x60001C6  UnityEngine.Timeline.TimelineClip CreateAndAddNewClipOfType(System.Type requestedType)
  RVA=0x09D2FB04  token=0x60001C7  UnityEngine.Timeline.TimelineClip CreateClipOfType(System.Type requestedType)
  RVA=0x09D2F8C0  token=0x60001C8  UnityEngine.Timeline.TimelineClip CreateClipFromPlayableAsset(UnityEngine.Playables.IPlayableAsset asset)
  RVA=0x09D2F69C  token=0x60001C9  UnityEngine.Timeline.TimelineClip CreateClipFromAsset(UnityEngine.ScriptableObject playableAsset)
  RVA=0x03D4EA80  token=0x60001CA  System.Collections.Generic.IEnumerable<UnityEngine.ScriptableObject> GetMarkersRaw()
  RVA=0x09D2F13C  token=0x60001CB  System.Void ClearMarkers()
  RVA=0x09D2EE38  token=0x60001CC  System.Void AddMarker(UnityEngine.ScriptableObject e)
  RVA=0x09D31574  token=0x60001CD  System.Boolean DeleteMarkerRaw(UnityEngine.ScriptableObject marker)
  RVA=0x09D325CC  token=0x60001CE  System.Int32 GetTimeRangeHash()
  RVA=0x09D2EDA4  token=0x60001CF  System.Void AddClip(UnityEngine.Timeline.TimelineClip newClip)
  RVA=0x09D30B34  token=0x60001D0  UnityEngine.Playables.Playable CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable mixerPlayable, UnityEngine.GameObject go, UnityEngine.Playables.Playable timelinePlayable)
  RVA=0x09D30E8C  token=0x60001D1  UnityEngine.Playables.Playable CreatePlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Playables.Playable timelinePlayable)
  RVA=0x09D2F1CC  token=0x60001D2  UnityEngine.Playables.Playable CompileClips(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.Timeline.TimelineClip> timelineClips, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree)
  RVA=0x09D315C4  token=0x60001D3  System.Void GatherCompilableTracks(System.Collections.Generic.IList<UnityEngine.Timeline.TrackAsset> tracks)
  RVA=0x09D31784  token=0x60001D4  System.Void GatherNotifications(System.Collections.Generic.List<UnityEngine.Timeline.IMarker> markers)
  RVA=0x09D3025C  token=0x60001D5  UnityEngine.Playables.Playable CreateMixerPlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree)
  RVA=0x09D2F530  token=0x60001D6  System.Void ConfigureTrackAnimation(UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.GameObject go, UnityEngine.Playables.Playable blend)
  RVA=0x09D32CC4  token=0x60001D7  System.Void SortClips()
  RVA=0x09D2F0B0  token=0x60001D8  System.Void ClearClipsInternal()
  RVA=0x09D2F14C  token=0x60001D9  System.Void ClearSubTracksInternal()
  RVA=0x03D71DF0  token=0x60001DA  System.Void OnClipMove()
  RVA=0x09D308F8  token=0x60001DB  UnityEngine.Timeline.TimelineClip CreateNewClipContainerInternal()
  RVA=0x09D2ED08  token=0x60001DC  System.Void AddChild(UnityEngine.Timeline.TrackAsset child)
  RVA=0x09D32A24  token=0x60001DD  System.Void MoveLastTrackBefore(UnityEngine.Timeline.TrackAsset asset)
  RVA=0x09D32C48  token=0x60001DE  System.Boolean RemoveSubTrack(UnityEngine.Timeline.TrackAsset child)
  RVA=0x09D32BE0  token=0x60001DF  System.Void RemoveClip(UnityEngine.Timeline.TimelineClip clip)
  RVA=0x09D32128  token=0x60001E0  System.Void GetEvaluationTime(System.Double& outStart, System.Double& outDuration)
  RVA=0x09D325B4  token=0x60001E1  System.Void GetSequenceTime(System.Double& outStart, System.Double& outDuration)
  RVA=0x09D31980  token=0x60001E2  System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
  RVA=0x09D32334  token=0x60001E3  UnityEngine.GameObject GetGameObjectBinding(UnityEngine.Playables.PlayableDirector director)
  RVA=0x09D331A4  token=0x60001E4  System.Boolean ValidateClipType(System.Type clipType)
  RVA=0x0350B670  token=0x60001E5  System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip)
  RVA=0x09D330D8  token=0x60001E6  System.Void UpdateDuration()
  RVA=0x09D2EE48  token=0x60001E7  System.Int32 CalculateItemsHash()
  RVA=0x09D31188  token=0x60001E8  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject gameObject, UnityEngine.Timeline.TimelineClip clip)
  RVA=0x03190BD0  token=0x60001E9  System.Void Invalidate()
  RVA=0x09D32460  token=0x60001EA  System.Double GetNotificationDuration()
  RVA=0x09D2EEE0  token=0x60001EB  System.Boolean CanCompileClips()
  RVA=0x09D32714  token=0x60001EC  System.Boolean HasChildTracks()
  RVA=0x09D2F0A0  token=0x60001ED  System.Boolean CanCreateTrackMixer()
  RVA=0x09D32824  token=0x60001EE  System.Boolean IsCompilable()
  RVA=0x09D32F4C  token=0x60001EF  System.Void UpdateChildTrackCache()
  RVA=0x09D327E0  token=0x60001F0  System.Int32 Hash()
  RVA=0x09D31FD8  token=0x60001F1  System.Int32 GetClipsHash()
  RVA=0x09D31CFC  token=0x60001F2  System.Int32 GetAnimationClipHash(UnityEngine.AnimationClip clip)
  RVA=0x09D3275C  token=0x60001F3  System.Boolean HasNotifications()
  RVA=0x09D2EF1C  token=0x60001F4  System.Boolean CanCompileNotifications()
  RVA=0x09D2EF48  token=0x60001F5  System.Boolean CanCreateMixerRecursive()
  RVA=0x09D300F8  token=0x60001F6  UnityEngine.Playables.Playable CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount)
  RVA=0x03151700  token=0x60001F7  System.Void .ctor()
  RVA=0x03151280  token=0x60001F8  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.ForbidScriptDefaultValueWhenExportAttribute
TYPE:  class
TOKEN: 0x2000042
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000206  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.TimelineHelpURLAttribute
TYPE:  class
TOKEN: 0x2000043
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.TrackColorAttribute
TYPE:  class
TOKEN: 0x2000044
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  private           UnityEngine.Color               m_Color  // 0x10
METHODS:
  RVA=0x03871E00  token=0x6000207  System.Void .ctor(System.Single r, System.Single g, System.Single b)
END_CLASS

CLASS: UnityEngine.Timeline.UseScriptDefaultValueWhenExportAttribute
TYPE:  class
TOKEN: 0x2000045
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000208  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AudioClipProperties
TYPE:  class
TOKEN: 0x2000046
SIZE:  0x18
EXTENDS: UnityEngine.Playables.PlayableBehaviour
FIELDS:
  public            System.Single                   volume  // 0x10
METHODS:
  RVA=0x03D4FB80  token=0x6000209  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AudioMixerProperties
TYPE:  class
TOKEN: 0x2000047
SIZE:  0x20
EXTENDS: UnityEngine.Playables.PlayableBehaviour
FIELDS:
  public            System.Single                   volume  // 0x10
  public            System.Single                   stereoPan  // 0x14
  public            System.Single                   spatialBlend  // 0x18
METHODS:
  RVA=0x09D26154  token=0x600020A  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x03D4FB80  token=0x600020B  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AudioPlayableAsset
TYPE:  class
TOKEN: 0x2000048
SIZE:  0x30
EXTENDS: UnityEngine.Playables.PlayableAsset
IMPLEMENTS: UnityEngine.Timeline.ITimelineClipAsset
FIELDS:
  private           UnityEngine.AudioClip           m_Clip  // 0x18
  private           System.Boolean                  m_Loop  // 0x20
  private           System.Single                   m_bufferingTime  // 0x24
  private           UnityEngine.Timeline.AudioClipPropertiesm_ClipProperties  // 0x28
PROPERTIES:
  bufferingTime  get=0x03D524F0  set=0x03D52500
  clip  get=0x01041090  set=0x022C3A90
  loop  get=0x03D4EF90  set=0x03D4EFC0
  duration  get=0x09D26578
  outputs  get=0x09D26620
  clipCaps  get=0x09D26568
METHODS:
  RVA=0x09D263E4  token=0x6000214  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go)
  RVA=0x09D26500  token=0x6000216  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AudioTrack
TYPE:  class
TOKEN: 0x200004A
SIZE:  0xC8
EXTENDS: UnityEngine.Timeline.TrackAsset
FIELDS:
  private           UnityEngine.Timeline.AudioMixerPropertiesm_TrackProperties  // 0xc0
PROPERTIES:
  outputs  get=0x09D26DC4
METHODS:
  RVA=0x09D26BC4  token=0x600021F  UnityEngine.Timeline.TimelineClip CreateClip(UnityEngine.AudioClip clip)
  RVA=0x09D26690  token=0x6000220  UnityEngine.Playables.Playable CompileClips(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.Timeline.TimelineClip> timelineClips, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree)
  RVA=0x09D26CD8  token=0x6000222  System.Void OnValidate()
  RVA=0x09D26D44  token=0x6000223  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ACConditionDescriptor
TYPE:  sealed struct
TOKEN: 0x200004C
SIZE:  0x28
FIELDS:
  private           System.Int32                    m_ConditionMode  // 0x10
  private           System.String                   m_ConditionEvent  // 0x18
  private           System.Single                   m_EventTreshold  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.ACTransitionDescriptor
TYPE:  class
TOKEN: 0x200004D
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600022C  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.BeyondCommunicator
TYPE:  static class
TOKEN: 0x200004E
SIZE:  0x10
FIELDS:
  public    static  System.Boolean                  setAddonLayerAdditive  // static @ 0x0
  private   static  System.Action<UnityEngine.Animator,UnityEngine.Animations.AnimationLayerMixerPlayable,UnityEngine.Timeline.AnimationTrack,UnityEngine.ScriptableObject,UnityEngine.Transform,UnityEngine.Timeline.CommunicatorParam><ConnectToJobSync>k__BackingField  // static @ 0x8
PROPERTIES:
  ConnectToJobSync  get=0x09D26E34  set=0x09D26E84
METHODS:
  RVA=0x03D44B60  token=0x600022F  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.BlendMotionDescriptor
TYPE:  class
TOKEN: 0x200004F
SIZE:  0x30
FIELDS:
  public            UnityEngine.AnimationClip       motion  // 0x10
  public            System.String                   poseTimerParam  // 0x18
  public            System.String                   blendParam  // 0x20
  public            System.Single                   threshold  // 0x28
METHODS:
  RVA=0x0350B670  token=0x6000230  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.BlendTreeDescriptor
TYPE:  class
TOKEN: 0x2000050
SIZE:  0x30
FIELDS:
  public            UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeTypeblendType  // 0x10
  public            System.Collections.Generic.List<UnityEngine.Timeline.BlendMotionDescriptor>motionDescriptorList  // 0x18
  private           System.String                   <speedParameter>k__BackingField  // 0x20
  private           System.Boolean                  <speedParameterActive>k__BackingField  // 0x28
METHODS:
  RVA=0x0350B670  token=0x6000231  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ITimelineRootMarker
TYPE:  interface
TOKEN: 0x2000052
FIELDS:
PROPERTIES:
  topDirector  get=-1  // abstract
  rootGo  get=-1  // abstract
  useEarlyUpdate  get=-1  // abstract
  enableLoop  get=-1  // abstract
  isOptimizingHolding  get=-1  // abstract
  onlyEvaluateTopDirector  get=-1  // abstract
  fixedFrameRate  get=-1  // abstract
  manualTickDeltaTime  get=-1  // abstract
  isManualTicking  get=-1  // abstract
  director2ControlPlayable  get=-1  // abstract  set=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000235  System.Void RegisterLoopSegmentRuntimeClip(System.String key, UnityEngine.Timeline.RuntimeClip runtimeClip)
  RVA=-1  // abstract  token=0x6000236  System.Void UpdateAllVFXFollowBoneTools()
END_CLASS

CLASS: UnityEngine.Timeline.LayerDescriptor
TYPE:  class
TOKEN: 0x2000053
SIZE:  0x38
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  public            System.String                   layerName  // 0x18
  public            UnityEngine.AvatarMask          avatarMask  // 0x20
  public            System.Boolean                  isAdditive  // 0x28
  public            System.Collections.Generic.List<UnityEngine.Timeline.StateDescriptor>stateDescriptors  // 0x30
METHODS:
  RVA=0x0286F540  token=0x600023F  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.MotionDescriptor
TYPE:  class
TOKEN: 0x2000054
SIZE:  0x58
FIELDS:
  public            System.String                   stateName  // 0x10
  public            UnityEngine.AnimationClip       motion  // 0x18
  public            System.Single                   speed  // 0x20
  public            System.String                   speedParameter  // 0x28
  public            System.Boolean                  speedParameterActive  // 0x30
  public            System.String                   mirrorParameter  // 0x38
  public            System.Boolean                  mirrorParameterActive  // 0x40
  public            System.String                   timeParameter  // 0x48
  public            System.Boolean                  timeParameterActive  // 0x50
METHODS:
  RVA=0x0350B670  token=0x6000240  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.StateDescriptor
TYPE:  class
TOKEN: 0x2000055
SIZE:  0x40
FIELDS:
  public            System.String                   stateName  // 0x10
  public            System.Boolean                  isDefaultState  // 0x18
  public            System.String                   stateWeightParameter  // 0x20
  public            System.Boolean                  stateWeightParameterActive  // 0x28
  public            System.Boolean                  isBlendTree  // 0x29
  public            UnityEngine.Timeline.MotionDescriptormotionDescriptor  // 0x30
  public            UnityEngine.Timeline.BlendTreeDescriptorblendTreeDescriptor  // 0x38
METHODS:
  RVA=0x0350B670  token=0x6000241  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ClipCaps
TYPE:  sealed struct
TOKEN: 0x2000056
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.ClipCaps   None  // const
  public    static  UnityEngine.Timeline.ClipCaps   Looping  // const
  public    static  UnityEngine.Timeline.ClipCaps   Extrapolation  // const
  public    static  UnityEngine.Timeline.ClipCaps   ClipIn  // const
  public    static  UnityEngine.Timeline.ClipCaps   SpeedMultiplier  // const
  public    static  UnityEngine.Timeline.ClipCaps   Blending  // const
  public    static  UnityEngine.Timeline.ClipCaps   AutoScale  // const
  public    static  UnityEngine.Timeline.ClipCaps   ClipMarker  // const
  public    static  UnityEngine.Timeline.ClipCaps   DialogLoopSegment  // const
  public    static  UnityEngine.Timeline.ClipCaps   IgniteOnce  // const
  public    static  UnityEngine.Timeline.ClipCaps   OnlyDeltaTime  // const
  public    static  UnityEngine.Timeline.ClipCaps   DialogJumpSegment  // const
  public    static  UnityEngine.Timeline.ClipCaps   EvaluateTwiceWhenEnabled  // const
  public    static  UnityEngine.Timeline.ClipCaps   DynamicLink  // const
  public    static  UnityEngine.Timeline.ClipCaps   CustomBehaviourControl  // const
  public    static  UnityEngine.Timeline.ClipCaps   ConditionBlend  // const
  public    static  UnityEngine.Timeline.ClipCaps   All  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.TimelineClipCapsExtensions
TYPE:  static class
TOKEN: 0x2000057
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09D2C9D0  token=0x6000242  System.Boolean SupportsExtrapolation(UnityEngine.Timeline.TimelineClip clip)
  RVA=0x05D658E8  token=0x6000243  System.Boolean HasAny(UnityEngine.Timeline.ClipCaps caps, UnityEngine.Timeline.ClipCaps flags)
END_CLASS

CLASS: UnityEngine.Timeline.ControlPlayableAsset
TYPE:  class
TOKEN: 0x2000058
SIZE:  0x78
EXTENDS: Beyond.Gameplay.Core.BeyondUseAutoBindingPlayableAsset
IMPLEMENTS: UnityEngine.Timeline.IPropertyPreview UnityEngine.Timeline.ITimelineClipAsset
FIELDS:
  private   static  System.Int32                    k_MaxRandInt  // const
  private   static readonly System.Collections.Generic.List<UnityEngine.Playables.PlayableDirector>k_EmptyDirectorsList  // static @ 0x0
  private   static readonly System.Collections.Generic.List<UnityEngine.ParticleSystem>k_EmptyParticlesList  // static @ 0x8
  private   static readonly System.Collections.Generic.HashSet<UnityEngine.ParticleSystem>s_SubEmitterCollector  // static @ 0x10
  public            UnityEngine.ExposedReference<UnityEngine.GameObject>sourceGameObject  // 0x30
  public            UnityEngine.GameObject          prefabGameObject  // 0x40
  public            System.Boolean                  updateParticle  // 0x48
  public            System.UInt32                   particleRandomSeed  // 0x4c
  public            System.Boolean                  forceRuntimeSimulate  // 0x50
  public            System.Boolean                  updateDirector  // 0x51
  public            System.Boolean                  updateITimeControl  // 0x52
  public            System.Boolean                  searchHierarchy  // 0x53
  public            System.Boolean                  active  // 0x54
  public            UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackStatepostPlayback  // 0x58
  private           System.Boolean                  m_OnlyDeltaTime  // 0x5c
  private           System.Boolean                  m_IgniteOnce  // 0x5d
  private           UnityEngine.Playables.PlayableAssetm_ControlDirectorAsset  // 0x60
  private           System.Double                   m_Duration  // 0x68
  private           System.Boolean                  m_SupportLoop  // 0x70
  private   static  System.Collections.Generic.HashSet<UnityEngine.Playables.PlayableDirector>s_ProcessedDirectors  // static @ 0x18
  private   static  System.Collections.Generic.HashSet<UnityEngine.GameObject>s_CreatedPrefabs  // static @ 0x20
  private           System.Boolean                  <controllingDirectors>k__BackingField  // 0x71
  private           System.Boolean                  <controllingParticles>k__BackingField  // 0x72
PROPERTIES:
  bindingGameObject  get=0x09D29E58
  showBaseParam  get=0x0232EB60
  controllingDirectors  get=0x03D51CF0  set=0x03D51D00
  controllingParticles  get=0x03D5BFA0  set=0x03D5BFD0
  OnlyDeltaTime  get=0x03D4F600  set=0x03D4F620
  IgniteOnce  get=0x03D71350  set=0x03D71390
  duration  get=0x03D4F6E0
  clipCaps  get=0x09D29EE8
METHODS:
  RVA=0x09D28454  token=0x600024E  System.Void OnEnable()
  RVA=0x09D27360  token=0x6000251  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go)
  RVA=0x09D270F0  token=0x6000252  UnityEngine.Playables.Playable ConnectPlayablesToMixer(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> playables)
  RVA=0x09D2724C  token=0x6000253  System.Void CreateActivationPlayable(UnityEngine.GameObject root, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables)
  RVA=0x09D29454  token=0x6000254  System.Void SearchHierarchyAndConnectParticleSystem(System.Collections.Generic.IEnumerable<UnityEngine.ParticleSystem> particleSystems, System.Single clipIn, System.Single speedMultiplier, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables)
  RVA=0x09D291C0  token=0x6000255  System.Void SearchHierarchyAndConnectDirector(System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableDirector> directors, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables, System.Boolean disableSelfReferences)
  RVA=0x09D28FC0  token=0x6000256  System.Void SearchHierarchyAndConnectControlableScripts(System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> controlableScripts, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables)
  RVA=0x09D27030  token=0x6000257  System.Void ConnectMixerAndPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable mixer, UnityEngine.Playables.Playable playable, System.Int32 portIndex)
  RVA=0x09D28E6C  token=0x6000258  UnityEngine.GameObject ResolveSourceGameObject(UnityEngine.IExposedPropertyTable resolver)
  RVA=-1  // generic def  token=0x6000259  System.Collections.Generic.IList<T> GetComponent(UnityEngine.GameObject gameObject)
  RVA=0x09D28148  token=0x600025A  System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> GetControlableScripts(UnityEngine.GameObject root)
  RVA=0x09D296BC  token=0x600025B  System.Void UpdateDurationAndLoopFlag(System.Collections.Generic.IList<UnityEngine.Playables.PlayableDirector> directors, System.Collections.Generic.IList<UnityEngine.ParticleSystem> particleSystems)
  RVA=0x09D281B8  token=0x600025C  System.Collections.Generic.IList<UnityEngine.ParticleSystem> GetControllableParticleSystems(UnityEngine.GameObject go)
  RVA=0x09D28304  token=0x600025D  System.Void GetControllableParticleSystems(UnityEngine.Transform t, System.Collections.Generic.ICollection<UnityEngine.ParticleSystem> roots, System.Collections.Generic.HashSet<UnityEngine.ParticleSystem> subEmitters)
  RVA=0x09D26F58  token=0x600025E  System.Void CacheSubEmitters(UnityEngine.ParticleSystem ps, System.Collections.Generic.HashSet<UnityEngine.ParticleSystem> subEmitters)
  RVA=0x09D27EBC  token=0x600025F  System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
  RVA=0x09D287A4  token=0x6000260  System.Void PreviewParticlesWithControlPlayableAsset(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.ParticleSystem> particles)
  RVA=0x09D28800  token=0x6000261  System.Void PreviewParticles(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.ParticleSystem> particles)
  RVA=0x09D28480  token=0x6000262  System.Void PreviewActivation(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.GameObject> objects)
  RVA=0x09D289A4  token=0x6000263  System.Void PreviewTimeControl(UnityEngine.Timeline.IPropertyCollector driver, UnityEngine.Playables.PlayableDirector director, System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> scripts)
  RVA=0x09D285CC  token=0x6000264  System.Void PreviewDirectors(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableDirector> directors)
  RVA=0x09D29DEC  token=0x6000265  System.Void .ctor()
  RVA=0x09D29BB8  token=0x6000266  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.ControlTrack
TYPE:  class
TOKEN: 0x200005A
SIZE:  0xC0
EXTENDS: UnityEngine.Timeline.TrackAsset
FIELDS:
METHODS:
  RVA=0x09D29F18  token=0x600026F  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AdditiveAnimApplyMono
TYPE:  class
TOKEN: 0x200005B
SIZE:  0x30
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Timeline.AdditiveAnimApplyMono.TransformAdditive>pendingAdditives  // 0x18
  private           System.Boolean                  hasnewPendingUpdates  // 0x20
  private           UnityEngine.Timeline.ITimelineRootMarker_parentTimelineRoot  // 0x28
METHODS:
  RVA=0x09D1EC60  token=0x6000270  System.Void Awake()
  RVA=0x09D1EECC  token=0x6000271  System.Void RecordAdditiveTransform(UnityEngine.Transform bone, UnityEngine.Vector3 position, UnityEngine.Vector3 rotationEuler, UnityEngine.Vector3 scale)
  RVA=0x09D1EE2C  token=0x6000272  System.Void LateUpdate()
  RVA=0x09D1E804  token=0x6000273  System.Void ApplyPendingTransforms()
  RVA=0x09D1ECD8  token=0x6000274  System.Void ClearPendingTransforms()
  RVA=0x09D1EE58  token=0x6000275  System.Void NotifyCutsceneRootToUpdateVFXTools()
  RVA=0x09D1F028  token=0x6000276  System.Void RegisterRootComponent()
  RVA=0x09D1F0A8  token=0x6000277  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AdditiveAnimMixer
TYPE:  class
TOKEN: 0x200005D
SIZE:  0x40
EXTENDS: UnityEngine.Playables.PlayableBehaviour
FIELDS:
  public            UnityEngine.Timeline.AdditiveAnimTracktrack  // 0x10
  private           UnityEngine.GameObject          bindingGo  // 0x18
  private           System.Boolean                  thisFrameAlreadyCalcualted  // 0x20
  private           System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Timeline.AdditiveAnimMixer.TransformAdditive>additiveCache  // 0x28
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform>bonePaths  // 0x30
  private           System.Collections.Generic.HashSet<System.String>notFoundBonePaths  // 0x38
METHODS:
  RVA=0x03D5B630  token=0x600027B  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D1F128  token=0x600027C  System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
  RVA=0x09D1F4D8  token=0x600027D  System.Void _AddToAdditiveCache(UnityEngine.Timeline.AdditiveAnimPlayable additiveAnimPlayable, System.Single clipTime, System.Single weight)
  RVA=0x09D1FE00  token=0x600027E  System.Void _ApplyAdditive()
  RVA=0x09D20098  token=0x600027F  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AdditiveAnimPlayable
TYPE:  class
TOKEN: 0x200005F
SIZE:  0x20
EXTENDS: UnityEngine.Playables.PlayableBehaviour
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.Timeline.AdditiveAnimPlayableAsset.AnimationCurveInfo>extractedCurves  // 0x10
  private           System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.Timeline.AdditiveAnimPlayableAsset.AnimationCurveInfo>>_curveCache  // 0x18
METHODS:
  RVA=0x09D3664C  token=0x6000282  System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable)
  RVA=0x09D363BC  token=0x6000283  System.Void InitializeCurveCache()
  RVA=0x09D36214  token=0x6000284  UnityEngine.AnimationCurve GetCurve(System.String path, System.String propertyName)
  RVA=0x09D361DC  token=0x6000285  System.Single EvaluateCurve(System.String path, System.String propertyName, System.Single time)
  RVA=0x09D366C4  token=0x6000286  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AdditiveAnimPlayableAsset
TYPE:  class
TOKEN: 0x2000060
SIZE:  0x48
EXTENDS: UnityEngine.Playables.PlayableAsset
IMPLEMENTS: UnityEngine.Timeline.ITimelineClipAsset
FIELDS:
  public            UnityEngine.AnimationClip       additiveClip  // 0x18
  private           UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.AdditiveAnimPlayable>additiveAnimPlayable  // 0x20
  public            System.Collections.Generic.List<UnityEngine.Timeline.AdditiveAnimPlayableAsset.AnimationCurveInfo>extractedCurves  // 0x30
  private           System.Boolean                  m_OnlyDeltaTime  // 0x38
  private           System.Boolean                  m_IgniteOnce  // 0x39
  private           UnityEngine.AnimationClip       _lastProcessedClip  // 0x40
PROPERTIES:
  OnlyDeltaTime  get=0x03D4F190  set=0x03D4E280
  IgniteOnce  get=0x03D4F300  set=0x03D4F330
  clipCaps  get=0x09D361B8
METHODS:
  RVA=0x09D35F68  token=0x600028B  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  RVA=0x09D36094  token=0x600028C  System.Void _InitializeBehaviourCurveCache()
  RVA=0x09D36138  token=0x600028E  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AdditiveAnimTrack
TYPE:  class
TOKEN: 0x2000062
SIZE:  0xD0
EXTENDS: UnityEngine.Timeline.TrackAsset
FIELDS:
  private   static  System.String                   k_DefaultRecordableClipName  // const
  private           System.Boolean                  m_InfiniteClip  // 0xc0
  private           UnityEngine.AnimationClip       m_RecordableClip  // 0xc8
METHODS:
  RVA=0x09D36764  token=0x6000290  UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount)
  RVA=0x09D36860  token=0x6000291  System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
  RVA=0x09D3673C  token=0x6000292  UnityEngine.Timeline.TimelineClip CreateRecordableClip(System.String animClipName)
  RVA=0x09D36A38  token=0x6000293  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.CombineToTopPlayableAttribute
TYPE:  class
TOKEN: 0x2000063
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000294  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.CustomControlPlayableAsset
TYPE:  class
TOKEN: 0x2000064
SIZE:  0x20
EXTENDS: UnityEngine.Playables.PlayableAsset
IMPLEMENTS: UnityEngine.Timeline.ITimelineClipAsset UnityEngine.Timeline.ICustomControlBehaviour
FIELDS:
  protected         UnityEngine.Timeline.CustomControlPlayableBehaviourm_CustomControlBehaviour  // 0x18
PROPERTIES:
  clipCaps  get=0x09D370C4
  extraClipCaps  get=0x01002730
METHODS:
  RVA=0x09D36FBC  token=0x6000297  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  RVA=0x09D37068  token=0x6000298  System.Void OnClipEnable(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D3700C  token=0x6000299  System.Void OnClipDisable(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x0286F540  token=0x600029A  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.CustomControlPlayableBehaviour
TYPE:  class
TOKEN: 0x2000065
SIZE:  0x10
EXTENDS: UnityEngine.Playables.PlayableBehaviour
IMPLEMENTS: UnityEngine.Timeline.ICustomControlBehaviour
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600029B  System.Void OnClipEnable(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x0350B670  token=0x600029C  System.Void OnClipDisable(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x0350B670  token=0x600029D  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ICustomControlBehaviour
TYPE:  interface
TOKEN: 0x2000066
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600029E  System.Void OnClipEnable(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=-1  // abstract  token=0x600029F  System.Void OnClipDisable(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
END_CLASS

CLASS: UnityEngine.Timeline.IDynamicBinding
TYPE:  interface
TOKEN: 0x2000067
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.ITimelineAnimationEventContextBinding
TYPE:  interface
TOKEN: 0x2000068
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60002A0  System.Void RegisterAnimationEventRuntimeContext(System.Int32 playableId, UnityEngine.AnimationEvent[] animationEvents, UnityEngine.Timeline.AnimationPlayableAsset.AnimationEventTriggerMode triggerMode, System.Single curClipTime)
  RVA=-1  // abstract  token=0x60002A1  System.Void UnregisterAnimationEventRuntimeContext(System.Int32 playableId, UnityEngine.AnimationEvent[] animationEvents)
  RVA=-1  // abstract  token=0x60002A2  System.Void UpdateClipTime(System.Int32 playableId, System.Single curClipTime)
END_CLASS

CLASS: UnityEngine.Timeline.SegmentLoopPlayableBehaviour
TYPE:  class
TOKEN: 0x2000069
SIZE:  0x10
EXTENDS: UnityEngine.Playables.PlayableBehaviour
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60002A3  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.SegmentLoopPlayableClip
TYPE:  class
TOKEN: 0x200006A
SIZE:  0x20
EXTENDS: UnityEngine.Playables.PlayableAsset
IMPLEMENTS: UnityEngine.Timeline.ITimelineClipAsset
FIELDS:
  public            System.String                   loopSegmentKey  // 0x18
PROPERTIES:
  clipCaps  get=0x03D567A0
METHODS:
  RVA=0x09D3CAA8  token=0x60002A4  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  RVA=0x0286F540  token=0x60002A6  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.SegmentLoopTrack
TYPE:  class
TOKEN: 0x200006B
SIZE:  0xC0
EXTENDS: UnityEngine.Timeline.TrackAsset
FIELDS:
METHODS:
  RVA=0x09D3CB54  token=0x60002A7  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.DiscreteTime
TYPE:  sealed struct
TOKEN: 0x200006C
SIZE:  0x18
IMPLEMENTS: System.IComparable
FIELDS:
  private   static  System.Double                   k_Tick  // const
  public    static readonly UnityEngine.Timeline.DiscreteTimekMaxTime  // static @ 0x0
  private   readonly System.Int64                    m_DiscreteTime  // 0x10
PROPERTIES:
  tickValue  get=0x03D856B0
METHODS:
  RVA=0x03D51730  token=0x60002A9  System.Void .ctor(System.Int64 time)
  RVA=0x09D37F00  token=0x60002AA  System.Void .ctor(System.Double time)
  RVA=0x09D37EA8  token=0x60002AB  System.Void .ctor(System.Int32 time)
  RVA=0x03D85680  token=0x60002AC  UnityEngine.Timeline.DiscreteTime OneTickBefore()
  RVA=0x03D85670  token=0x60002AD  UnityEngine.Timeline.DiscreteTime OneTickAfter()
  RVA=0x0339AE90  token=0x60002AE  UnityEngine.Timeline.DiscreteTime FromTicks(System.Int64 ticks)
  RVA=0x09D37BE0  token=0x60002AF  System.Int32 CompareTo(System.Object obj)
  RVA=0x022A9C20  token=0x60002B0  System.Boolean Equals(UnityEngine.Timeline.DiscreteTime other)
  RVA=0x09D37CFC  token=0x60002B1  System.Boolean Equals(System.Object obj)
  RVA=0x09D37C48  token=0x60002B2  System.Int64 DoubleToDiscreteTime(System.Double time)
  RVA=0x09D37DB8  token=0x60002B3  System.Int64 IntToDiscreteTime(System.Int32 time)
  RVA=0x03D85690  token=0x60002B4  System.Double ToDouble(System.Int64 time)
  RVA=0x09D37F5C  token=0x60002B5  System.Double op_Explicit(UnityEngine.Timeline.DiscreteTime b)
  RVA=0x09D37FAC  token=0x60002B6  UnityEngine.Timeline.DiscreteTime op_Explicit(System.Double time)
  RVA=0x09D37FD4  token=0x60002B7  UnityEngine.Timeline.DiscreteTime op_Implicit(System.Int32 time)
  RVA=0x0232CE30  token=0x60002B8  System.Boolean op_Equality(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs)
  RVA=0x09D37FFC  token=0x60002B9  System.Boolean op_Inequality(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs)
  RVA=0x0925CFFC  token=0x60002BA  System.Boolean op_LessThanOrEqual(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs)
  RVA=0x022E54E0  token=0x60002BB  System.Boolean op_GreaterThanOrEqual(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs)
  RVA=0x03D856C0  token=0x60002BC  UnityEngine.Timeline.DiscreteTime op_Subtraction(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs)
  RVA=0x09D37E60  token=0x60002BD  System.String ToString()
  RVA=0x03D70930  token=0x60002BE  System.Int32 GetHashCode()
  RVA=0x09D37E08  token=0x60002BF  UnityEngine.Timeline.DiscreteTime Max(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs)
  RVA=0x09D37D68  token=0x60002C0  System.Int64 GetNearestTick(System.Double time)
  RVA=0x09D37E68  token=0x60002C1  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.InfiniteRuntimeClip
TYPE:  class
TOKEN: 0x200006D
SIZE:  0x30
EXTENDS: UnityEngine.Timeline.RuntimeElement
FIELDS:
  private           UnityEngine.Playables.Playable  m_Playable  // 0x18
  private   static readonly System.Int64                    kIntervalEnd  // static @ 0x0
  private           System.Int32                    <optionIndex>k__BackingField  // 0x28
PROPERTIES:
  intervalStart  get=0x01002730
  intervalEnd  get=0x09D38B74
  optionIndex  get=0x03D4EB90  set=0x03D4EBA0
  enable  set=0x09D38BC4
METHODS:
  RVA=0x03D51D90  token=0x60002C2  System.Void .ctor(UnityEngine.Playables.Playable playable)
  RVA=0x09D38A8C  token=0x60002C8  System.Void EvaluateAt(System.Double localTime, UnityEngine.Playables.FrameData frameData, UnityEngine.Timeline.ITimelineRootMarker timelineRoot)
  RVA=0x09D38A2C  token=0x60002C9  System.Void DisableAt(System.Double localTime, System.Double rootDuration, UnityEngine.Playables.FrameData frameData)
  RVA=0x09D38AE4  token=0x60002CA  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.IInterval
TYPE:  interface
TOKEN: 0x200006E
FIELDS:
PROPERTIES:
  intervalStart  get=-1  // abstract
  intervalEnd  get=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.IRuntimeReset
TYPE:  interface
TOKEN: 0x200006F
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60002CD  System.Void RuntimeReset()
END_CLASS

CLASS: UnityEngine.Timeline.IOption
TYPE:  interface
TOKEN: 0x2000070
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.IntervalTreeNode
TYPE:  sealed struct
TOKEN: 0x2000071
SIZE:  0x28
FIELDS:
  public            System.Int64                    center  // 0x10
  public            System.Int32                    first  // 0x18
  public            System.Int32                    last  // 0x1c
  public            System.Int32                    left  // 0x20
  public            System.Int32                    right  // 0x24
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.IntervalTree`1
TYPE:  class
TOKEN: 0x2000072
FIELDS:
  private   static  System.Int32                    kMinNodeSize  // const
  private   static  System.Int32                    kInvalidNode  // const
  private   static  System.Int64                    kCenterUnknown  // const
  private   readonly System.Collections.Generic.List<UnityEngine.Timeline.IntervalTree.Entry<T>>m_Entries  // 0x0
  private   readonly System.Collections.Generic.List<UnityEngine.Timeline.IntervalTreeNode>m_Nodes  // 0x0
  private           System.Boolean                  <dirty>k__BackingField  // 0x0
PROPERTIES:
  dirty  get=-1  // not resolved  set=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x60002D0  System.Void Add(T item)
  RVA=-1  // not resolved  token=0x60002D1  System.Void IntersectsWith(System.Int64 value, System.Collections.Generic.List<T> results)
  RVA=-1  // not resolved  token=0x60002D2  System.Void IntersectsWithRange(System.Int64 start, System.Int64 end, System.Collections.Generic.List<T> results)
  RVA=-1  // not resolved  token=0x60002D3  System.Void UpdateIntervals()
  RVA=-1  // not resolved  token=0x60002D4  System.Void RuntimeReset()
  RVA=-1  // not resolved  token=0x60002D5  System.Void Query(UnityEngine.Timeline.IntervalTreeNode intervalTreeNode, System.Int64 value, System.Collections.Generic.List<T> results)
  RVA=-1  // not resolved  token=0x60002D6  System.Void QueryRange(UnityEngine.Timeline.IntervalTreeNode intervalTreeNode, System.Int64 start, System.Int64 end, System.Collections.Generic.List<T> results)
  RVA=-1  // not resolved  token=0x60002D7  System.Void Rebuild()
  RVA=-1  // not resolved  token=0x60002D8  System.Int32 Rebuild(System.Int32 start, System.Int32 end)
  RVA=-1  // not resolved  token=0x60002D9  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.RuntimeClip
TYPE:  class
TOKEN: 0x2000074
SIZE:  0xA8
EXTENDS: UnityEngine.Timeline.RuntimeClipBase
FIELDS:
  public            System.Double                   runtimeLocalTimeOffset  // 0x20
  public            System.Double                   runtimeMixOutTime  // 0x28
  public            System.Double                   runtimeMixOutDuration  // 0x30
  public            System.Double                   runtimeMixInTime  // 0x38
  public            System.Double                   runtimeMixInDuration  // 0x40
  public            System.Boolean                  runtimeLooping  // 0x48
  public            System.Boolean                  runtimeLoopingMute  // 0x49
  private           System.Boolean                  _isInMixIn  // 0x4a
  private           System.Boolean                  _isMixIn  // 0x4b
  private           System.Boolean                  _hadIgniteOnce  // 0x4c
  private           System.Double                   lastTickTime  // 0x50
  private           System.Boolean                  _onlyDeltaTimeLooped  // 0x58
  private           System.Int32                    <optionIndex>k__BackingField  // 0x5c
  private           System.Int32                    m_originalPort  // 0x60
  private           System.Boolean                  _hadClipEnabled  // 0x64
  public            System.Boolean                  isRuntimeJumpExhaust  // 0x65
  private           UnityEngine.Timeline.TimelineClipm_Clip  // 0x68
  private           UnityEngine.Playables.Playable  m_Playable  // 0x70
  private           UnityEngine.Playables.Playable  m_ParentMixer  // 0x80
  private           UnityEngine.Playables.Playable  m_RootPlayable  // 0x90
  private           System.Boolean                  m_enabled  // 0xa0
PROPERTIES:
  optionIndex  get=0x03D4EEF0  set=0x03D4EF40
  dynamicLink  get=0x09D3C164
  customBehaviourControl  get=0x09D3C110
  start  get=0x09D3C2B8
  end  get=0x09D3C18C
  duration  get=0x09D3C138
  clip  get=0x03D4EAB0
  mixer  get=0x03D5AAF0
  playable  get=0x03D5AAE0
  intervalStart  get=0x09D3C25C
  intervalEnd  get=0x09D3C1E4
  enable  set=0x09D3C2E4
  isEnabling  get=0x03D50A40
METHODS:
  RVA=0x09D3C0B8  token=0x60002E1  System.Void .ctor(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, System.Int32 originalPort)
  RVA=0x09D3B1C8  token=0x60002E2  System.Void Create(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, System.Int32 originalPort)
  RVA=0x09D3BE10  token=0x60002EA  System.Void SetTime(System.Double time)
  RVA=0x09D3BDB8  token=0x60002EB  System.Void SetDuration(System.Double duration)
  RVA=0x09D3B47C  token=0x60002EC  System.Void EvaluateAt(System.Double localTime, UnityEngine.Playables.FrameData frameData, UnityEngine.Timeline.ITimelineRootMarker timelineRoot)
  RVA=0x09D3B7CC  token=0x60002ED  System.Single EvaluateMixIn(System.Single localTime)
  RVA=0x09D3B888  token=0x60002EE  System.Single EvaluateMixOut(System.Single localTime)
  RVA=0x09D3BE68  token=0x60002EF  System.Double ToLocalTime(System.Double localTime, UnityEngine.Playables.FrameData frameData, UnityEngine.Timeline.ITimelineRootMarker timelineRoot)
  RVA=0x09D3B2DC  token=0x60002F0  System.Void DisableAt(System.Double localTime, System.Double rootDuration, UnityEngine.Playables.FrameData frameData)
  RVA=0x09D3B17C  token=0x60002F1  System.Boolean CheckIfRuntimeTimeLoop(System.Boolean& canSkip, System.Double& reverseTime)
  RVA=0x09D3B050  token=0x60002F2  System.Boolean CheckIfRuntimeTimeJump(System.Double& jumpTime, System.Boolean& isReverseJump)
  RVA=0x09D3BB28  token=0x60002F3  System.Void RuntimeLoopOver()
  RVA=0x09D3BAF8  token=0x60002F4  System.Void RuntimeLoopOn()
  RVA=0x09D3B918  token=0x60002F5  System.Void GetRuntimeCrossFadeDuration(System.Double& duration, System.Double& jumpTargetTime)
  RVA=0x09D3BA3C  token=0x60002F6  System.Void RecalculateRuntimeCrossFadeMixIn(System.Double mixInTime, System.Double mixInDuration)
  RVA=0x09D3BA8C  token=0x60002F7  System.Void RecalculateRuntimeCrossFadeMixOut(System.Double curTime, System.Double mixStartTime, System.Double mixDuration)
  RVA=0x09D3BFF0  token=0x60002F8  System.Boolean TryGetJumpClip(Beyond.Gameplay.Core.RuntimeJumpClip& jumpClip)
  RVA=0x09D3BB58  token=0x60002F9  System.Void RuntimeReset()
END_CLASS

CLASS: UnityEngine.Timeline.RuntimeClipBase
TYPE:  abstract class
TOKEN: 0x2000075
SIZE:  0x20
EXTENDS: UnityEngine.Timeline.RuntimeElement
FIELDS:
  private           System.Int32                    <optionIndex>k__BackingField  // 0x18
PROPERTIES:
  start  get=-1  // abstract
  duration  get=-1  // abstract
  end  get=-1  // abstract
  optionIndex  get=0x020D1AC0  set=0x03D4E9C0
  intervalStart  get=0x09D3AFF4
  intervalEnd  get=0x09D3AF7C
METHODS:
  RVA=0x0350B670  token=0x6000301  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.RuntimeElement
TYPE:  abstract class
TOKEN: 0x2000076
SIZE:  0x18
IMPLEMENTS: UnityEngine.Timeline.IInterval UnityEngine.Timeline.IOption UnityEngine.Timeline.IRuntimeReset
FIELDS:
  private           System.Int32                    <intervalBit>k__BackingField  // 0x10
  private           System.Boolean                  <isLooping>k__BackingField  // 0x14
PROPERTIES:
  intervalStart  get=-1  // abstract
  intervalEnd  get=-1  // abstract
  optionIndex  get=-1  // abstract  set=-1  // abstract
  intervalBit  get=0x03D4E340  set=0x010410F0
  isLooping  get=0x03D58C00  set=0x03D58C20
  enable  set=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x600030B  System.Void EvaluateAt(System.Double localTime, UnityEngine.Playables.FrameData frameData, UnityEngine.Timeline.ITimelineRootMarker timelineRoot)
  RVA=-1  // abstract  token=0x600030C  System.Void DisableAt(System.Double localTime, System.Double rootDuration, UnityEngine.Playables.FrameData frameData)
  RVA=0x03D857E0  token=0x600030D  System.Boolean CheckIfRuntimeTimeLoop(System.Boolean& canSkip, System.Double& reverseTime)
  RVA=0x03D857D0  token=0x600030E  System.Boolean CheckIfRuntimeTimeJump(System.Double& jumpTime, System.Boolean& isReverseJump)
  RVA=0x0350B670  token=0x600030F  System.Void RuntimeLoopOver()
  RVA=0x0350B670  token=0x6000310  System.Void RuntimeLoopOn()
  RVA=0x03D857F0  token=0x6000311  System.Void GetRuntimeCrossFadeDuration(System.Double& duration, System.Double& jumpTargetTime)
  RVA=0x0350B670  token=0x6000312  System.Void RecalculateRuntimeCrossFadeMixIn(System.Double mixInTime, System.Double mixDuration)
  RVA=0x0350B670  token=0x6000313  System.Void RecalculateRuntimeCrossFadeMixOut(System.Double curTime, System.Double mixStartTime, System.Double mixDuration)
  RVA=0x0350B670  token=0x6000314  System.Void RuntimeReset()
  RVA=0x0350B670  token=0x6000315  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ScheduleRuntimeClip
TYPE:  class
TOKEN: 0x2000077
SIZE:  0x60
EXTENDS: UnityEngine.Timeline.RuntimeClipBase
FIELDS:
  private           UnityEngine.Timeline.TimelineClipm_Clip  // 0x20
  private           UnityEngine.Playables.Playable  m_Playable  // 0x28
  private           UnityEngine.Playables.Playable  m_ParentMixer  // 0x38
  private           System.Double                   m_StartDelay  // 0x48
  private           System.Double                   m_FinishTail  // 0x50
  private           System.Boolean                  m_Started  // 0x58
PROPERTIES:
  start  get=0x09D3C938
  duration  get=0x09D3C8B4
  end  get=0x09D3C8FC
  clip  get=0x03D4EB40
  mixer  get=0x03D5A120
  playable  get=0x03D59E20
  enable  set=0x09D3C9B0
METHODS:
  RVA=0x09D3C864  token=0x600031C  System.Void .ctor(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, System.Double startDelay, System.Double finishTail)
  RVA=0x09D3C520  token=0x600031D  System.Void Create(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, System.Double startDelay, System.Double finishTail)
  RVA=0x09D3C5B8  token=0x600031F  System.Void EvaluateAt(System.Double localTime, UnityEngine.Playables.FrameData frameData, UnityEngine.Timeline.ITimelineRootMarker timelineRoot)
  RVA=0x05755818  token=0x6000320  System.Void DisableAt(System.Double localTime, System.Double rootDuration, UnityEngine.Playables.FrameData frameData)
END_CLASS

CLASS: UnityEngine.Timeline.IMarker
TYPE:  interface
TOKEN: 0x2000078
FIELDS:
PROPERTIES:
  time  get=-1  // abstract  set=-1  // abstract
  parent  get=-1  // abstract
METHODS:
  RVA=-1  // abstract  token=0x6000324  System.Void Initialize(UnityEngine.Timeline.TrackAsset parent)
END_CLASS

CLASS: UnityEngine.Timeline.INotificationOptionProvider
TYPE:  interface
TOKEN: 0x2000079
FIELDS:
PROPERTIES:
  flags  get=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.Marker
TYPE:  abstract class
TOKEN: 0x200007A
SIZE:  0x28
EXTENDS: UnityEngine.ScriptableObject
IMPLEMENTS: UnityEngine.Timeline.IMarker
FIELDS:
  private           System.Double                   m_Time  // 0x18
  private           UnityEngine.Timeline.TrackAsset <parent>k__BackingField  // 0x20
PROPERTIES:
  parent  get=0x03D4EB40  set=0x04271930
  time  get=0x03D4EBD0  set=0x09D39494
METHODS:
  RVA=0x09D39374  token=0x600032A  System.Void UnityEngine.Timeline.IMarker.Initialize(UnityEngine.Timeline.TrackAsset parentTrack)
  RVA=0x0350B670  token=0x600032B  System.Void OnInitialize(UnityEngine.Timeline.TrackAsset aPent)
  RVA=0x0286F540  token=0x600032C  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.MarkerList
TYPE:  sealed struct
TOKEN: 0x200007B
SIZE:  0x28
IMPLEMENTS: UnityEngine.ISerializationCallbackReceiver
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.ScriptableObject>m_Objects  // 0x10
  private           System.Collections.Generic.List<UnityEngine.Timeline.IMarker>m_Cache  // 0x18
  private           System.Boolean                  m_CacheDirty  // 0x20
  private           System.Boolean                  m_HasNotifications  // 0x21
PROPERTIES:
  markers  get=0x04275B08
  Count  get=0x09D39128
  Item  get=0x09D39170
METHODS:
  RVA=0x03151860  token=0x600032E  System.Void .ctor(System.Int32 capacity)
  RVA=0x09D38C28  token=0x600032F  System.Void Add(UnityEngine.ScriptableObject item)
  RVA=0x09D38F74  token=0x6000330  System.Boolean Remove(UnityEngine.Timeline.IMarker item)
  RVA=0x09D39078  token=0x6000331  System.Boolean Remove(UnityEngine.ScriptableObject item, UnityEngine.Timeline.TimelineAsset timelineAsset, UnityEngine.Playables.PlayableAsset thingToDirty)
  RVA=0x09D38CAC  token=0x6000332  System.Void Clear()
  RVA=0x04275B08  token=0x6000333  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetMarkers()
  RVA=0x020C61B0  token=0x6000336  System.Collections.Generic.List<UnityEngine.ScriptableObject> GetRawMarkerList()
  RVA=0x09D38CF8  token=0x6000337  UnityEngine.Timeline.IMarker CreateMarker(System.Type type, System.Double time, UnityEngine.Timeline.TrackAsset owner)
  RVA=0x09D38F58  token=0x6000338  System.Boolean HasNotifications()
  RVA=0x0350B670  token=0x6000339  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  RVA=0x01168960  token=0x600033A  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  RVA=0x03151940  token=0x600033B  System.Void BuildCache()
END_CLASS

CLASS: UnityEngine.Timeline.MarkerTrack
TYPE:  class
TOKEN: 0x200007C
SIZE:  0xC0
EXTENDS: UnityEngine.Timeline.TrackAsset
IMPLEMENTS: Events.INotificationTrack
FIELDS:
PROPERTIES:
  outputs  get=0x09D39218
METHODS:
  RVA=0x09D391CC  token=0x600033D  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.CustomSignalEventDrawer
TYPE:  class
TOKEN: 0x200007D
SIZE:  0x10
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x600033E  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.SignalAsset
TYPE:  class
TOKEN: 0x200007E
SIZE:  0x18
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
  private   static  System.Action<UnityEngine.Timeline.SignalAsset>OnEnableCallback  // static @ 0x0
EVENTS:
  OnEnableCallback  add=add_OnEnableCallback  remove=remove_OnEnableCallback
METHODS:
  RVA=0x09D3CBA0  token=0x6000341  System.Void OnEnable()
  RVA=0x0286F540  token=0x6000342  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.SignalEmitter
TYPE:  class
TOKEN: 0x200007F
SIZE:  0x38
EXTENDS: UnityEngine.Timeline.Marker
IMPLEMENTS: UnityEngine.Playables.INotification UnityEngine.Timeline.INotificationOptionProvider
FIELDS:
  private           System.Boolean                  m_Retroactive  // 0x28
  private           System.Boolean                  m_EmitOnce  // 0x29
  private           UnityEngine.Timeline.SignalAssetm_Asset  // 0x30
PROPERTIES:
  retroactive  get=0x03D4ED50  set=0x03D4ED60
  emitOnce  get=0x03D4F2A0  set=0x03D4F2B0
  asset  get=0x01003830  set=0x04270470
  UnityEngine.Playables.INotification.id  get=0x09D3CD28
  UnityEngine.Timeline.INotificationOptionProvider.flags  get=0x09D3CDCC
METHODS:
  RVA=0x0286F540  token=0x600034B  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.SignalReceiver
TYPE:  class
TOKEN: 0x2000080
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
IMPLEMENTS: UnityEngine.Playables.INotificationReceiver
FIELDS:
  private           UnityEngine.Timeline.SignalReceiver.EventKeyValuem_Events  // 0x18
METHODS:
  RVA=0x09D3D4E8  token=0x600034C  System.Void OnNotify(UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, System.Object context)
  RVA=0x09D3CE60  token=0x600034D  System.Void AddReaction(UnityEngine.Timeline.SignalAsset asset, UnityEngine.Events.UnityEvent reaction)
  RVA=0x09D3CDF4  token=0x600034E  System.Int32 AddEmptyReaction(UnityEngine.Events.UnityEvent reaction)
  RVA=0x09D3D670  token=0x600034F  System.Void Remove(UnityEngine.Timeline.SignalAsset asset)
  RVA=0x092E734C  token=0x6000350  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.SignalAsset> GetRegisteredSignals()
  RVA=0x09D3D3F4  token=0x6000351  UnityEngine.Events.UnityEvent GetReaction(UnityEngine.Timeline.SignalAsset key)
  RVA=0x09D3D2F0  token=0x6000352  System.Int32 Count()
  RVA=0x09D3D088  token=0x6000353  System.Void ChangeSignalAtIndex(System.Int32 idx, UnityEngine.Timeline.SignalAsset newKey)
  RVA=0x09D3D5C8  token=0x6000354  System.Void RemoveAtIndex(System.Int32 idx)
  RVA=0x09D3CFBC  token=0x6000355  System.Void ChangeReactionAtIndex(System.Int32 idx, UnityEngine.Events.UnityEvent reaction)
  RVA=0x09D3D338  token=0x6000356  UnityEngine.Events.UnityEvent GetReactionAtIndex(System.Int32 idx)
  RVA=0x09D3D42C  token=0x6000357  UnityEngine.Timeline.SignalAsset GetSignalAssetAtIndex(System.Int32 idx)
  RVA=0x0350B670  token=0x6000358  System.Void OnEnable()
  RVA=0x09D3D738  token=0x6000359  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.SignalTrack
TYPE:  class
TOKEN: 0x2000082
SIZE:  0xC0
EXTENDS: UnityEngine.Timeline.MarkerTrack
FIELDS:
METHODS:
  RVA=0x09D3D7A8  token=0x6000361  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.TrackAssetExtensions
TYPE:  static class
TOKEN: 0x2000083
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.GroupTrack
TYPE:  class
TOKEN: 0x2000084
SIZE:  0xC8
EXTENDS: UnityEngine.Timeline.TrackAsset
FIELDS:
  public            Beyond.PackageBridge.Timeline.TimelineConditionBaseenableOnCondition  // 0xc0
PROPERTIES:
  outputs  get=0x09D38950
METHODS:
  RVA=0x09D388C8  token=0x6000362  System.Void CalculateRuntimeMuted()
  RVA=0x0115F4C0  token=0x6000363  System.Boolean CanCompileClips()
  RVA=0x03151580  token=0x6000365  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ILayerable
TYPE:  interface
TOKEN: 0x2000085
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000366  UnityEngine.Playables.Playable CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount)
END_CLASS

CLASS: UnityEngine.Timeline.ITimeDilationListener
TYPE:  interface
TOKEN: 0x2000086
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000367  System.Void OnTimeDilationChanged(System.Single timeDilation)
END_CLASS

CLASS: UnityEngine.Timeline.ActivationControlPlayable
TYPE:  class
TOKEN: 0x2000087
SIZE:  0x20
EXTENDS: UnityEngine.Timeline.ControlPlayableBehaviour
FIELDS:
  public            UnityEngine.GameObject          gameObject  // 0x10
  public            UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackStatepostPlayback  // 0x18
  private           UnityEngine.Timeline.ActivationControlPlayable.InitialStatem_InitialState  // 0x1c
METHODS:
  RVA=0x09D35BA8  token=0x6000368  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.ActivationControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject gameObject, UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState postPlaybackState)
  RVA=0x09D35D68  token=0x6000369  System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D35CDC  token=0x600036A  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D35EF8  token=0x600036B  System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object userData)
  RVA=0x09D35DD8  token=0x600036C  System.Void OnGraphStart(UnityEngine.Playables.Playable playable)
  RVA=0x09D35E54  token=0x600036D  System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable)
  RVA=0x0350B670  token=0x600036E  System.Void RuntimeReset()
  RVA=0x03D56C80  token=0x600036F  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AnimationEventRuntimeContextPlayable
TYPE:  class
TOKEN: 0x200008A
SIZE:  0x30
EXTENDS: UnityEngine.Playables.PlayableBehaviour
FIELDS:
  private           UnityEngine.Timeline.ITimelineAnimationEventContextBindingm_TimelineAnimationEventContextBinding  // 0x10
  private           UnityEngine.Timeline.AnimationPlayableAsset.AnimationEventTriggerModem_TriggerMode  // 0x18
  private           UnityEngine.AnimationEvent[]    m_CachedAnimationEvents  // 0x20
  private           System.Single                   m_ClipDuration  // 0x28
  private           System.Boolean                  m_IsRegistered  // 0x2c
  private           System.Boolean                  m_HasRegisteredOnce  // 0x2d
METHODS:
  RVA=0x09D36A84  token=0x6000370  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.AnimationEventRuntimeContextPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding, UnityEngine.Timeline.AnimationPlayableAsset.AnimationEventTriggerMode triggerMode, UnityEngine.AnimationEvent[] cachedAnimationEvents, System.Single clipDuration, System.Int32 inputCount)
  RVA=0x09D36BC8  token=0x6000371  System.Void Initialize(UnityEngine.Timeline.ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding, UnityEngine.Timeline.AnimationPlayableAsset.AnimationEventTriggerMode triggerMode, UnityEngine.AnimationEvent[] cachedAnimationEvents, System.Single clipDuration)
  RVA=0x09D36C08  token=0x6000372  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D36D38  token=0x6000373  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x0350B670  token=0x6000374  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.BasicPlayableBehaviour
TYPE:  class
TOKEN: 0x200008B
SIZE:  0x18
EXTENDS: UnityEngine.ScriptableObject
IMPLEMENTS: UnityEngine.Playables.IPlayableAsset UnityEngine.Playables.IPlayableBehaviour
FIELDS:
PROPERTIES:
  duration  get=0x09D36F1C
  outputs  get=0x09D36F6C
METHODS:
  RVA=0x0350B670  token=0x6000377  System.Void OnGraphStart(UnityEngine.Playables.Playable playable)
  RVA=0x0350B670  token=0x6000378  System.Void OnGraphStop(UnityEngine.Playables.Playable playable)
  RVA=0x0350B670  token=0x6000379  System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable)
  RVA=0x0350B670  token=0x600037A  System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable)
  RVA=0x0350B670  token=0x600037B  System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x0350B670  token=0x600037C  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x0350B670  token=0x600037D  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x0350B670  token=0x600037E  System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
  RVA=0x09D36E5C  token=0x600037F  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  RVA=0x0286F540  token=0x6000380  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ControlPlayableBehaviour
TYPE:  class
TOKEN: 0x200008C
SIZE:  0x10
EXTENDS: UnityEngine.Playables.PlayableBehaviour
IMPLEMENTS: UnityEngine.Timeline.IBehaviourRuntimeReset
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000381  System.Void RuntimeReset()
  RVA=0x0350B670  token=0x6000382  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.DirectorControlPlayable
TYPE:  class
TOKEN: 0x200008D
SIZE:  0x38
EXTENDS: UnityEngine.Timeline.ControlPlayableBehaviour
FIELDS:
  public            UnityEngine.Playables.PlayableDirectordirector  // 0x10
  public            UnityEngine.Timeline.ITimelineRootMarkerrootMarker  // 0x18
  private   static  System.Single                   SYNC_START_FORBID_THRESHOLD  // const
  private           System.Boolean                  m_SyncTime  // 0x20
  private           System.Double                   m_AssetDuration  // 0x28
  private           UnityEngine.Timeline.TimelinePlayablem_TimelinePlayable  // 0x30
METHODS:
  RVA=0x09D370E0  token=0x6000383  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.DirectorControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableDirector director)
  RVA=0x09D374B8  token=0x6000384  System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable)
  RVA=0x09D37554  token=0x6000385  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D37400  token=0x6000386  System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D37348  token=0x6000387  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D3777C  token=0x6000388  System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
  RVA=0x09D378AC  token=0x6000389  System.Void SyncSpeed(System.Double speed)
  RVA=0x09D379F8  token=0x600038A  System.Void SyncStart(UnityEngine.Playables.PlayableGraph graph, System.Double time)
  RVA=0x09D37B1C  token=0x600038B  System.Void SyncStop(UnityEngine.Playables.PlayableGraph graph, System.Double time)
  RVA=0x0350B670  token=0x600038C  System.Void RuntimeReset()
  RVA=0x03D85660  token=0x600038D  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ITimeControl
TYPE:  interface
TOKEN: 0x200008E
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600038E  System.Void SetTime(System.Double time)
  RVA=-1  // abstract  token=0x600038F  System.Void OnControlTimeStart()
  RVA=-1  // abstract  token=0x6000390  System.Void OnControlTimeStop()
END_CLASS

CLASS: UnityEngine.Timeline.NotificationFlags
TYPE:  sealed struct
TOKEN: 0x200008F
SIZE:  0x12
FIELDS:
  public            System.Int16                    value__  // 0x10
  public    static  UnityEngine.Timeline.NotificationFlagsTriggerInEditMode  // const
  public    static  UnityEngine.Timeline.NotificationFlagsRetroactive  // const
  public    static  UnityEngine.Timeline.NotificationFlagsTriggerOnce  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.ParticleControlPlayable
TYPE:  class
TOKEN: 0x2000090
SIZE:  0x40
EXTENDS: UnityEngine.Timeline.ControlPlayableBehaviour
IMPLEMENTS: UnityEngine.Timeline.ITimeDilationListener
FIELDS:
  private           System.Single                   m_LastPlayableTime  // 0x10
  private           System.Single                   m_LastParticleTime  // 0x14
  private           System.UInt32                   m_RandomSeed  // 0x18
  private           System.Boolean                  m_forceRuntimeSimulate  // 0x1c
  private           System.Single                   m_clipIn  // 0x20
  private           System.Boolean                  m_hadInitialized  // 0x24
  private           System.Single                   originalSimulateSpeed  // 0x28
  private           System.Single                   simulateSpeedModifier  // 0x2c
  private           UnityEngine.ParticleSystem      <particleSystem>k__BackingField  // 0x30
  private           System.Boolean                  m_hadIgnite  // 0x38
  private           System.Boolean                  m_hadSimulate  // 0x39
  private           System.Boolean                  m_hadPlayed  // 0x3a
PROPERTIES:
  particleSystem  get=0x01003830  set=0x04270470
  shouldSimulate  get=0x09D3A474
METHODS:
  RVA=0x09D399EC  token=0x6000391  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.ParticleControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.ParticleSystem component, System.UInt32 randomSeed, System.Single clipIn, System.Single speedMultiplier, System.Boolean forceRuntimeSimulate)
  RVA=0x09D39B80  token=0x6000395  System.Void Initialize(UnityEngine.ParticleSystem ps, System.UInt32 randomSeed, System.Single clipIn, System.Single simulateSpeed, System.Boolean forceRuntimeSimulate)
  RVA=0x09D39EF4  token=0x6000396  System.Void SetOriginalSimulateSpeed(UnityEngine.ParticleSystem particleSystem, System.Double simulateSpeed)
  RVA=0x09D3A02C  token=0x6000397  System.Void SetRandomSeed(UnityEngine.ParticleSystem particleSystem, System.UInt32 randomSeed)
  RVA=0x09D39D50  token=0x6000398  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData data)
  RVA=0x09D3A400  token=0x6000399  System.Void _SimulateParticle(System.Single time, System.Single particleTime, System.Boolean previewMode)
  RVA=0x03D85780  token=0x600039A  System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D3A2E8  token=0x600039B  System.Void _PlayOrQueuedParticleSystem()
  RVA=0x09D39C40  token=0x600039C  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D3A128  token=0x600039D  System.Void Simulate(System.Single time, System.Boolean restart)
  RVA=0x03D85790  token=0x600039E  System.Void RuntimeReset()
  RVA=0x09D39CFC  token=0x600039F  System.Void OnTimeDilationChanged(System.Single timeScale)
  RVA=0x03D857A0  token=0x60003A0  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.PrefabControlPlayable
TYPE:  class
TOKEN: 0x2000091
SIZE:  0x18
EXTENDS: UnityEngine.Playables.PlayableBehaviour
FIELDS:
  private           UnityEngine.GameObject          m_Instance  // 0x10
PROPERTIES:
  prefabInstance  get=0x020B7B20
METHODS:
  RVA=0x09D3A84C  token=0x60003A1  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.PrefabControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject prefabGameObject, UnityEngine.Transform parentTransform)
  RVA=0x09D3A97C  token=0x60003A3  UnityEngine.GameObject Initialize(UnityEngine.GameObject prefabGameObject, UnityEngine.Transform parentTransform)
  RVA=0x09D3ACCC  token=0x60003A4  System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable)
  RVA=0x09D3AC5C  token=0x60003A5  System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D3ABD0  token=0x60003A6  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D3AD54  token=0x60003A7  System.Void SetHideFlagsRecursive(UnityEngine.GameObject gameObject)
  RVA=0x0350B670  token=0x60003A8  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.TimeControlPlayable
TYPE:  class
TOKEN: 0x2000092
SIZE:  0x20
EXTENDS: UnityEngine.Timeline.ControlPlayableBehaviour
FIELDS:
  private           UnityEngine.Timeline.ITimeControlm_timeControl  // 0x10
  private           System.Boolean                  m_started  // 0x18
METHODS:
  RVA=0x09D3D7B0  token=0x60003A9  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.ITimeControl timeControl)
  RVA=0x0426FEE0  token=0x60003AA  System.Void Initialize(UnityEngine.Timeline.ITimeControl timeControl)
  RVA=0x09D3D948  token=0x60003AB  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D3D8F4  token=0x60003AC  System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D3D8A0  token=0x60003AD  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x0350B670  token=0x60003AE  System.Void RuntimeReset()
  RVA=0x0350B670  token=0x60003AF  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.TimeNotificationBehaviour
TYPE:  class
TOKEN: 0x2000093
SIZE:  0x38
EXTENDS: UnityEngine.Playables.PlayableBehaviour
FIELDS:
  private   readonly System.Collections.Generic.List<UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry>m_Notifications  // 0x10
  private           System.Double                   m_PreviousTime  // 0x18
  private           System.Boolean                  m_NeedSortNotifications  // 0x20
  private           System.Boolean                  m_IsManualUpdate  // 0x21
  private           UnityEngine.Playables.Playable  m_TimeSource  // 0x28
PROPERTIES:
  timeSource  set=0x03D59E30
  isManualUpdate  set=0x03D4F080
METHODS:
  RVA=0x09D3DAA4  token=0x60003B2  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> Create(UnityEngine.Playables.PlayableGraph graph, System.Double duration, UnityEngine.Playables.DirectorWrapMode loopMode)
  RVA=0x09D3D9C0  token=0x60003B3  System.Void AddNotification(System.Double time, UnityEngine.Playables.INotification payload, UnityEngine.Timeline.NotificationFlags flags)
  RVA=0x09D3DD5C  token=0x60003B4  System.Void OnGraphStart(UnityEngine.Playables.Playable playable)
  RVA=0x09D3DBB4  token=0x60003B5  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D3DEFC  token=0x60003B6  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D3E2D0  token=0x60003B7  System.Void SortNotifications()
  RVA=0x09D3DA74  token=0x60003B8  System.Boolean CanRestoreNotification(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e, UnityEngine.Playables.FrameData info, System.Double currentTime, System.Double previousTime)
  RVA=0x09D3E4D8  token=0x60003B9  System.Void TriggerNotificationsInRange(System.Double start, System.Double end, UnityEngine.Playables.FrameData info, UnityEngine.Playables.Playable playable, System.Boolean checkState)
  RVA=0x09D3E3F8  token=0x60003BA  System.Void SyncDurationWithExternalSource(UnityEngine.Playables.Playable playable)
  RVA=0x09D3E6B8  token=0x60003BB  System.Void Trigger_internal(UnityEngine.Playables.Playable playable, UnityEngine.Playables.PlayableOutput output, UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry& e)
  RVA=0x03D557C0  token=0x60003BC  System.Void Restore_internal(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry& e)
  RVA=0x09D3E734  token=0x60003BD  System.Double _GetPlayableTime(UnityEngine.Playables.Playable playable)
  RVA=0x09D3E7F8  token=0x60003BE  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.CommunicatorParam
TYPE:  class
TOKEN: 0x2000096
SIZE:  0x28
FIELDS:
  public            UnityEngine.Timeline.IScriptAnimationJobSyncjobSync  // 0x10
  public            System.String                   uniqueId  // 0x18
  public            System.Boolean                  lookAtUseAdditive  // 0x20
METHODS:
  RVA=0x0350B670  token=0x60003C5  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.IAutoGenMono
TYPE:  interface
TOKEN: 0x2000097
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.IBehaviourRuntimeReset
TYPE:  interface
TOKEN: 0x2000098
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.IScriptAnimationJobSync
TYPE:  interface
TOKEN: 0x2000099
IMPLEMENTS: UnityEngine.Timeline.IAutoGenMono
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60003C6  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
  RVA=-1  // abstract  token=0x60003C7  System.Void CalcLayerMainStream(System.Single deltaTime)
  RVA=-1  // abstract  token=0x60003C8  System.Void ResetCloth(System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> activeRuntimeElements, System.Boolean useSoftReset, System.Boolean keepPose, System.Boolean useRelativeTeleport)
END_CLASS

CLASS: UnityEngine.Timeline.TimelineScriptAnimationJob
TYPE:  sealed struct
TOKEN: 0x200009A
SIZE:  0x20
IMPLEMENTS: UnityEngine.Animations.IAnimationJob
FIELDS:
  public            UnityEngine.Timeline.IScriptAnimationJobSyncbindedScriptAnimationJobSync  // 0x10
  public            UnityEngine.Animator            bindedAnimator  // 0x18
METHODS:
  RVA=0x032C7BF0  token=0x60003C9  System.Void .ctor(UnityEngine.Timeline.IScriptAnimationJobSync job, UnityEngine.Animator animator)
  RVA=0x0350B670  token=0x60003CA  System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D45FE0  token=0x60003CB  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
END_CLASS

CLASS: UnityEngine.Timeline.PlayableTrack
TYPE:  class
TOKEN: 0x200009B
SIZE:  0xC0
EXTENDS: UnityEngine.Timeline.TrackAsset
FIELDS:
METHODS:
  RVA=0x09D3A768  token=0x60003CC  System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip)
  RVA=0x09D3A800  token=0x60003CD  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.TrackMediaType
TYPE:  class
TOKEN: 0x200009C
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.TrackClipTypeAttribute
TYPE:  class
TOKEN: 0x200009D
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.Type                     inspectedType  // 0x10
  public    readonly System.Boolean                  allowAutoCreate  // 0x18
METHODS:
  RVA=0x03809A70  token=0x60003CE  System.Void .ctor(System.Type clipClass)
  RVA=0x03D4D900  token=0x60003CF  System.Void .ctor(System.Type clipClass, System.Boolean allowAutoCreate)
END_CLASS

CLASS: UnityEngine.Timeline.NotKeyableAttribute
TYPE:  class
TOKEN: 0x200009E
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60003D0  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.TrackBindingFlags
TYPE:  sealed struct
TOKEN: 0x200009F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TrackBindingFlagsNone  // const
  public    static  UnityEngine.Timeline.TrackBindingFlagsAllowCreateComponent  // const
  public    static  UnityEngine.Timeline.TrackBindingFlagsAll  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.TrackBindingTypeAttribute
TYPE:  class
TOKEN: 0x20000A0
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.Type                     type  // 0x10
  public    readonly UnityEngine.Timeline.TrackBindingFlagsflags  // 0x18
METHODS:
  RVA=0x038BA920  token=0x60003D1  System.Void .ctor(System.Type type)
  RVA=0x02738A30  token=0x60003D2  System.Void .ctor(System.Type type, UnityEngine.Timeline.TrackBindingFlags flags)
END_CLASS

CLASS: UnityEngine.Timeline.SupportsChildTracksAttribute
TYPE:  class
TOKEN: 0x20000A1
SIZE:  0x20
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.Type                     childType  // 0x10
  public    readonly System.Int32                    levels  // 0x18
METHODS:
  RVA=0x03CBB760  token=0x60003D3  System.Void .ctor(System.Type childType, System.Int32 levels)
END_CLASS

CLASS: UnityEngine.Timeline.IgnoreOnPlayableTrackAttribute
TYPE:  class
TOKEN: 0x20000A2
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60003D4  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.TimeFieldAttribute
TYPE:  class
TOKEN: 0x20000A3
SIZE:  0x18
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
  private   readonly UnityEngine.Timeline.TimeFieldAttribute.UseEditMode<useEditMode>k__BackingField  // 0x10
METHODS:
  RVA=0x010410F0  token=0x60003D5  System.Void .ctor(UnityEngine.Timeline.TimeFieldAttribute.UseEditMode useEditMode)
END_CLASS

CLASS: UnityEngine.Timeline.FrameRateFieldAttribute
TYPE:  class
TOKEN: 0x20000A5
SIZE:  0x10
EXTENDS: UnityEngine.PropertyAttribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60003D6  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.HideInMenuAttribute
TYPE:  class
TOKEN: 0x20000A6
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60003D7  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.CustomStyleAttribute
TYPE:  class
TOKEN: 0x20000A7
SIZE:  0x18
EXTENDS: System.Attribute
FIELDS:
  public    readonly System.String                   ussStyle  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60003D8  System.Void .ctor(System.String ussStyle)
END_CLASS

CLASS: UnityEngine.Timeline.MenuCategoryAttribute
TYPE:  class
TOKEN: 0x20000A8
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.ITimelineClipAsset
TYPE:  interface
TOKEN: 0x20000A9
FIELDS:
PROPERTIES:
  clipCaps  get=-1  // abstract
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.ITimelineEvaluateCallback
TYPE:  interface
TOKEN: 0x20000AA
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x60003DA  System.Void Evaluate()
END_CLASS

CLASS: UnityEngine.Timeline.TimelinePlayable
TYPE:  class
TOKEN: 0x20000AB
SIZE:  0xB0
EXTENDS: UnityEngine.Playables.PlayableBehaviour
FIELDS:
  public            System.Double                   timeOffset  // 0x10
  public            System.Int32                    newOptionIndex  // 0x18
  public            System.Int32                    curOptionIndex  // 0x1c
  public            System.Int32                    lastOptionIndex  // 0x20
  public            System.Boolean                  checkTimeJumpForNextSeek  // 0x24
  private           UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement>m_IntervalTree  // 0x28
  private           System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement>m_ActiveClips  // 0x30
  private           System.Collections.Generic.HashSet<UnityEngine.Timeline.RuntimeElement>m_ActiveClipsSet  // 0x38
  private           System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement>m_CurrentListOfActiveClips  // 0x40
  private           System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement>m_ActiveClipsCalcCache  // 0x48
  private           System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement>m_RuntimeResetClipCache  // 0x50
  private           System.Collections.Generic.List<UnityEngine.Timeline.ITimeDilationListener>m_timeDialationListeners  // 0x58
  private           System.Int32                    m_ActiveBit  // 0x60
  private           System.Boolean                  m_needEvaluateTwice  // 0x64
  private           System.Boolean                  m_isTimelineEnded  // 0x65
  private           System.Collections.Generic.List<UnityEngine.Timeline.ITimelineEvaluateCallback>m_EvaluateCallbacks  // 0x68
  private           System.Collections.Generic.Dictionary<UnityEngine.Timeline.TrackAsset,UnityEngine.Playables.Playable>m_PlayableCache  // 0x70
  private           UnityEngine.Playables.PlayableDirectorm_TopDirector  // 0x78
  private           System.Collections.Generic.List<UnityEngine.Playables.PlayableDirector>m_AllDirectorUnderRoot  // 0x80
  private           UnityEngine.Playables.PlayableDirectorm_DirectorHoldingThisPlayable  // 0x88
  private           UnityEngine.Timeline.ITimelineRootMarkerm_RootMarker  // 0x90
  private           System.Collections.Generic.List<UnityEngine.Timeline.IScriptAnimationJobSync>m_ScriptAnimationJobSyncs  // 0x98
  private           System.Collections.Generic.HashSet<UnityEngine.Playables.Playable>m_forbidPostProcessMixers  // 0xa0
  private   static  System.Boolean                  muteAudioScrubbing  // static @ 0x0
  private           System.Double                   m_timeForNextFrame  // 0xa8
PROPERTIES:
  timeForNextFrame  get=0x03D85810
  timelineRootMarker  get=0x03D4EA90
  enableLoop  get=0x09D43324
METHODS:
  RVA=0x09D40E4C  token=0x60003DE  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimelinePlayable> Create(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, System.Boolean autoRebalance, System.Boolean createOutputs)
  RVA=0x09D3FB34  token=0x60003DF  System.Void Compile(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, System.Boolean autoRebalance, System.Boolean createOutputs)
  RVA=0x03D85800  token=0x60003E0  System.Void MarkTimelineEnd()
  RVA=0x03D5CA70  token=0x60003E1  System.Boolean IsTimelineEnded()
  RVA=0x09D3F418  token=0x60003E2  System.Void CompileCombineTopTopTrackList(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Boolean createOutputs)
  RVA=0x09D3F24C  token=0x60003E3  System.Void CollectCombineToTopTracksRecursive(UnityEngine.Timeline.TrackAsset track, System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> combineTracks)
  RVA=0x09D3F8E0  token=0x60003E4  System.Void CompileTrackList(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, System.Boolean createOutputs, System.Boolean isCompilingCombineToTopTracks)
  RVA=0x09D400B4  token=0x60003E5  System.Void CreateTrackOutput(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.TrackAsset track, UnityEngine.GameObject go, UnityEngine.Playables.Playable playable, System.Int32 port)
  RVA=0x09D414A0  token=0x60003E6  System.Void EvaluateWeightsForAnimationPlayableOutput(UnityEngine.Timeline.TrackAsset track, UnityEngine.Animations.AnimationPlayableOutput animOutput, UnityEngine.Animator animator)
  RVA=0x09D40A14  token=0x60003E7  UnityEngine.Playables.Playable CreateTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, UnityEngine.Timeline.TrackAsset track, UnityEngine.GameObject go, System.Boolean createOutputs)
  RVA=0x09D42734  token=0x60003E8  System.Void UpdateIntervalTree()
  RVA=0x09D424F8  token=0x60003E9  System.Void RuntimeResetIntervalTree()
  RVA=0x09D42158  token=0x60003EA  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  RVA=0x09D42E20  token=0x60003EB  System.Void _ResetScriptAnimationJobySyncs()
  RVA=0x09D42C54  token=0x60003EC  System.Void _EvaluateTwice()
  RVA=0x03D4E2B0  token=0x60003ED  System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> GetCurrentActiveClips()
  RVA=0x09D42024  token=0x60003EE  System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> GetActiveClipsAtGivenTime(System.Double givenTime, System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> activeClips)
  RVA=0x09D41F28  token=0x60003EF  System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> GetActiveClipsAtGivenTimeRange(System.Double startTime, System.Double endTime, System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> activeClips)
  RVA=0x09D4154C  token=0x60003F0  System.Void Evaluate(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData frameData)
  RVA=0x09D41230  token=0x60003F1  System.Boolean DoReverseLoop(System.Double reverseTime)
  RVA=0x09D41154  token=0x60003F2  System.Boolean DoReverseJump(UnityEngine.Timeline.RuntimeClip runtimeClip, System.Double jumpTime)
  RVA=0x09D4109C  token=0x60003F3  System.Boolean DoJump(UnityEngine.Timeline.RuntimeClip runtimeClip, System.Double localTime, System.Double jumpTime)
  RVA=0x09D4277C  token=0x60003F4  System.Boolean _CheckIfTimeJumping(UnityEngine.Playables.FrameData frameData, System.Double localTime)
  RVA=0x09D3F178  token=0x60003F5  System.Void CacheTrack(UnityEngine.Timeline.TrackAsset track, UnityEngine.Playables.Playable playable, System.Int32 port, UnityEngine.Playables.Playable parent)
  RVA=0x03D85630  token=0x60003F6  System.Void SetTimeForNextFrame(System.Double newTime)
  RVA=0x09D424A4  token=0x60003F7  System.Void RegisterTimeDilationListener(UnityEngine.Timeline.ITimeDilationListener listener)
  RVA=0x09D420F4  token=0x60003F8  System.Void MarkMixerForbidPostProcess(UnityEngine.Playables.Playable mixer)
  RVA=0x09D3F1E8  token=0x60003F9  System.Boolean CheckIfMixerForbidPostProcess(UnityEngine.Playables.Playable mixer)
  RVA=0x09D42540  token=0x60003FA  System.Void SetTimeScale(System.Single usingTimeScale)
  RVA=0x09D42D04  token=0x60003FB  System.Void _NotifyTimeScaleChanged(System.Single usingTimeScale)
  RVA=0x09D42FD4  token=0x60003FC  System.Void .ctor()
  RVA=0x09D42F9C  token=0x60003FD  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.AnimationPreviewUtilities
TYPE:  static class
TOKEN: 0x20000AC
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.Extrapolation
TYPE:  static class
TOKEN: 0x20000AD
SIZE:  0x10
FIELDS:
  private   static readonly System.Double                   kMinExtrapolationTime  // static @ 0x0
METHODS:
  RVA=0x09D38358  token=0x60003FE  System.Void CalculateExtrapolationTimes(UnityEngine.Timeline.TrackAsset asset)
  RVA=0x09D38718  token=0x60003FF  UnityEngine.Timeline.TimelineClip[] SortClipsByStartTime(UnityEngine.Timeline.TimelineClip[] clips)
  RVA=0x09D3885C  token=0x6000400  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.HashUtility
TYPE:  static class
TOKEN: 0x20000AF
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x03D85760  token=0x6000404  System.Int32 CombineHash(System.Int32 h1, System.Int32 h2)
  RVA=0x03D85720  token=0x6000405  System.Int32 CombineHash(System.Int32 h1, System.Int32 h2, System.Int32 h3)
  RVA=0x03D856D0  token=0x6000406  System.Int32 CombineHash(System.Int32 h1, System.Int32 h2, System.Int32 h3, System.Int32 h4)
  RVA=0x09D389A0  token=0x6000407  System.Int32 CombineHash(System.Int32 h1, System.Int32 h2, System.Int32 h3, System.Int32 h4, System.Int32 h5)
  RVA=0x09D389D8  token=0x6000408  System.Int32 CombineHash(System.Int32 h1, System.Int32 h2, System.Int32 h3, System.Int32 h4, System.Int32 h5, System.Int32 h6)
END_CLASS

CLASS: UnityEngine.Timeline.IPropertyCollector
TYPE:  interface
TOKEN: 0x20000B0
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000409  System.Void PushActiveGameObject(UnityEngine.GameObject gameObject)
  RVA=-1  // abstract  token=0x600040A  System.Void PopActiveGameObject()
  RVA=-1  // abstract  token=0x600040B  System.Void AddFromClip(UnityEngine.AnimationClip clip)
  RVA=-1  // abstract  token=0x600040C  System.Void AddFromName(System.String name)
  RVA=-1  // abstract  token=0x600040D  System.Void AddFromName(UnityEngine.GameObject obj, System.String name)
  RVA=-1  // abstract  token=0x600040E  System.Void AddFromName(UnityEngine.GameObject obj, System.String name)
  RVA=-1  // abstract  token=0x600040F  System.Void AddFromComponent(UnityEngine.GameObject obj, UnityEngine.Component component)
  RVA=-1  // abstract  token=0x6000410  System.Void AddObjectProperties(UnityEngine.Object obj, UnityEngine.AnimationClip clip)
END_CLASS

CLASS: UnityEngine.Timeline.IPropertyPreview
TYPE:  interface
TOKEN: 0x20000B1
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000411  System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
END_CLASS

CLASS: UnityEngine.Timeline.NotificationUtilities
TYPE:  static class
TOKEN: 0x20000B2
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09D39504  token=0x6000412  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> markers, System.Double duration, UnityEngine.Playables.DirectorWrapMode extrapolationMode)
  RVA=0x09D398CC  token=0x6000413  System.Boolean TrackTypeSupportsNotifications(System.Type type)
END_CLASS

CLASS: UnityEngine.Timeline.PlayableDirectorUtility
TYPE:  static class
TOKEN: 0x20000B3
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09D3A738  token=0x6000414  System.Void SetOptionIndexSingleDirector(UnityEngine.Playables.PlayableDirector director, System.Int32 curOptionIndex, System.Int32 lastOptionIndex)
  RVA=0x09D3A6BC  token=0x6000415  UnityEngine.Timeline.TimelinePlayable GetTimelinePlayable(UnityEngine.Playables.PlayableDirector director)
  RVA=0x09D3A60C  token=0x6000416  UnityEngine.Timeline.TimelinePlayable GetTimelinePlayable(UnityEngine.Playables.PlayableGraph graph)
  RVA=0x09D3A560  token=0x6000417  UnityEngine.Timeline.TimelinePlayable GetTimelinePlayableFromChildPlayable(UnityEngine.Playables.Playable playable)
  RVA=0x09D3A49C  token=0x6000418  System.Boolean CheckIfTimelineFunctional(UnityEngine.Playables.Playable playable)
END_CLASS

CLASS: UnityEngine.Timeline.TimelineClipExtensions
TYPE:  static class
TOKEN: 0x20000B4
SIZE:  0x10
FIELDS:
  private   static readonly System.String                   k_UndoSetParentTrackText  // static @ 0x0
METHODS:
  RVA=0x09D3E944  token=0x6000419  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.TimelineCreateUtilities
TYPE:  static class
TOKEN: 0x20000B5
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09D3EBE0  token=0x600041A  System.String GenerateUniqueActorName(System.Collections.Generic.List<UnityEngine.ScriptableObject> tracks, System.String name)
  RVA=0x09D3EE94  token=0x600041B  System.Void SaveAssetIntoObject(UnityEngine.Object childAsset, UnityEngine.Object masterAsset)
  RVA=0x09D3EA3C  token=0x600041C  UnityEngine.AnimationClip CreateAnimationClipForTrack(System.String name, UnityEngine.Timeline.TrackAsset track, System.Boolean isLegacy)
  RVA=0x09D3EF54  token=0x600041D  System.Boolean ValidateParentTrack(UnityEngine.Timeline.TrackAsset parent, System.Type childType)
END_CLASS

CLASS: UnityEngine.Timeline.TimelineRuntimeUtils
TYPE:  class
TOKEN: 0x20000B8
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09D45A38  token=0x6000422  System.Double GetTimelineDeltaTime(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData frameData)
  RVA=0x09D43398  token=0x6000423  System.Boolean CheckWillRuntimeElementEnabled(UnityEngine.Timeline.RuntimeElement element, System.Int32 curOptionIndex, System.Int32 lastOptionIndex, System.Int64 curDiscreteTime)
  RVA=0x09D44440  token=0x6000424  System.Void DoReverseJump(UnityEngine.Timeline.RuntimeClip jumpClip, UnityEngine.Timeline.ITimelineRootMarker timelineRoot, System.Double curTime, System.Double jumpTime, System.Double mixDuration, System.Int32 curOptionIndex, System.Int32 lastOptionIndex, System.Boolean needChangeOptionAfterJump, System.Int32 newOptionIndex)
  RVA=0x09D4343C  token=0x6000425  System.Void DoJump(UnityEngine.Timeline.RuntimeClip jumpClip, UnityEngine.Timeline.ITimelineRootMarker timelineRoot, System.Double curTime, System.Double jumpTime, System.Double mixDuration, System.Int32 curOptionIndex, System.Int32 lastOptionIndex, System.Boolean needChangeOptionAfterJump, System.Int32 optionIndexChangingTo)
  RVA=0x09D458E0  token=0x6000426  System.Double GetSubDirectorTimeForDirectorControl(UnityEngine.Playables.Playable playable, UnityEngine.Playables.PlayableDirector director)
  RVA=0x09D45D20  token=0x6000427  System.Void SetNewTimeForCutsceneRoot(UnityEngine.Timeline.ITimelineRootMarker timelineRoot, System.Double newTime, System.Boolean useThisTimeNextFrame)
  RVA=0x09D4543C  token=0x6000428  UnityEngine.AnimationClip FindTPoseClipFromLayerDescriptors(System.Collections.Generic.List<UnityEngine.Timeline.LayerDescriptor> layerDescriptors)
  RVA=0x09D45C4C  token=0x6000429  System.Void LinkDefaultTPoseIfNeeded(UnityEngine.Animations.AnimationLayerMixerPlayable mixer, System.Collections.Generic.List<UnityEngine.Timeline.LayerDescriptor> layerDescriptors, System.String gameObjectName, System.Boolean disableBaseTPoseClip)
  RVA=0x09D45AB0  token=0x600042A  System.Void LinkDefaultTPoseClip(UnityEngine.Animations.AnimationLayerMixerPlayable mixer, UnityEngine.AnimationClip tposeClip, System.String gameObjectName)
  RVA=0x0350B670  token=0x600042B  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.TimelineUndo
TYPE:  static class
TOKEN: 0x20000B9
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09D46028  token=0x600042C  System.Void PushDestroyUndo(UnityEngine.Timeline.TimelineAsset timeline, UnityEngine.Object thingToDirty, UnityEngine.Object objectToDestroy)
END_CLASS

CLASS: UnityEngine.Timeline.StandardFrameRates
TYPE:  sealed struct
TOKEN: 0x20000BA
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.StandardFrameRatesFps24  // const
  public    static  UnityEngine.Timeline.StandardFrameRatesFps23_97  // const
  public    static  UnityEngine.Timeline.StandardFrameRatesFps25  // const
  public    static  UnityEngine.Timeline.StandardFrameRatesFps30  // const
  public    static  UnityEngine.Timeline.StandardFrameRatesFps29_97  // const
  public    static  UnityEngine.Timeline.StandardFrameRatesFps50  // const
  public    static  UnityEngine.Timeline.StandardFrameRatesFps60  // const
  public    static  UnityEngine.Timeline.StandardFrameRatesFps59_94  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.TimeUtility
TYPE:  static class
TOKEN: 0x20000BB
SIZE:  0x10
FIELDS:
  public    static readonly System.Double                   kTimeEpsilon  // static @ 0x0
  public    static readonly System.Double                   kFrameRateEpsilon  // static @ 0x8
  public    static readonly System.Double                   k_MaxTimelineDurationInSeconds  // static @ 0x10
  public    static readonly System.Double                   kFrameRateRounding  // static @ 0x18
METHODS:
  RVA=0x09D3E870  token=0x600042D  System.Double GetAnimationClipLength(UnityEngine.AnimationClip clip)
  RVA=0x03CF7830  token=0x600042E  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.WeightUtility
TYPE:  static class
TOKEN: 0x20000BD
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09D46208  token=0x6000431  System.Single NormalizeMixer(UnityEngine.Playables.Playable mixer)
END_CLASS

CLASS: UnityEngine.Timeline.Condition.TimelineConditionControlMono
TYPE:  class
TOKEN: 0x20000BE
SIZE:  0x20
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  public            Beyond.PackageBridge.Timeline.TimelineConditionBasecondition  // 0x18
METHODS:
  RVA=0x09D3E9A0  token=0x6000432  System.Void RefreshOnCondition()
  RVA=0x0426FE60  token=0x6000433  System.Void .ctor()
END_CLASS

