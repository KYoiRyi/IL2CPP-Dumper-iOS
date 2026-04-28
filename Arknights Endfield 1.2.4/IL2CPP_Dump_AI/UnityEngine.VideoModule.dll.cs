// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.VideoModule.dll
// Classes:  15
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

CLASS: EventHandler
TYPE:  sealed class
TOKEN: 0x200000C
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x06DE8490  token=0x6000080  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x6000081  System.Void Invoke(UnityEngine.Video.VideoPlayer source)
END_CLASS

CLASS: ErrorEventHandler
TYPE:  sealed class
TOKEN: 0x200000D
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x0951C0FC  token=0x6000082  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x6000083  System.Void Invoke(UnityEngine.Video.VideoPlayer source, System.String message)
END_CLASS

CLASS: FrameReadyEventHandler
TYPE:  sealed class
TOKEN: 0x200000E
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x07977BE4  token=0x6000084  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x6000085  System.Void Invoke(UnityEngine.Video.VideoPlayer source, System.Int64 frameIdx)
END_CLASS

CLASS: TimeEventHandler
TYPE:  sealed class
TOKEN: 0x200000F
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09F899B4  token=0x6000086  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x6000087  System.Void Invoke(UnityEngine.Video.VideoPlayer source, System.Double seconds)
END_CLASS

CLASS: UnityEngine.Experimental.Video.VideoClipPlayable
TYPE:  sealed struct
TOKEN: 0x2000002
SIZE:  0x20
IMPLEMENTS: UnityEngine.Playables.IPlayable System.IEquatable`1
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
METHODS:
  RVA=0x03D695A0  token=0x6000001  UnityEngine.Playables.PlayableHandle GetHandle()
  RVA=0x09F89A88  token=0x6000002  System.Boolean Equals(UnityEngine.Experimental.Video.VideoClipPlayable other)
END_CLASS

CLASS: UnityEngine.Video.VideoClip
TYPE:  sealed class
TOKEN: 0x2000003
SIZE:  0x18
EXTENDS: UnityEngine.Object
FIELDS:
PROPERTIES:
  originalPath  get=0x09F89D0C
  frameCount  get=0x09F89C3C
  frameRate  get=0x09F89C70
  length  get=0x09F89CD8
  width  get=0x09F89DDC
  height  get=0x09F89CA4
  pixelAspectRatioNumerator  get=0x09F89D74
  pixelAspectRatioDenominator  get=0x09F89D40
  sRGB  get=0x09F89DA8
  audioTrackCount  get=0x09F89C08
METHODS:
  RVA=0x09F89BC8  token=0x6000003  System.Void .ctor()
  RVA=0x09F89AFC  token=0x600000E  System.UInt16 GetAudioChannelCount(System.UInt16 audioTrackIdx)
  RVA=0x09F89B84  token=0x600000F  System.UInt32 GetAudioSampleRate(System.UInt16 audioTrackIdx)
  RVA=0x09F89B40  token=0x6000010  System.String GetAudioLanguage(System.UInt16 audioTrackIdx)
END_CLASS

CLASS: UnityEngine.Video.VideoRenderMode
TYPE:  sealed struct
TOKEN: 0x2000004
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Video.VideoRenderModeCameraFarPlane  // const
  public    static  UnityEngine.Video.VideoRenderModeCameraNearPlane  // const
  public    static  UnityEngine.Video.VideoRenderModeRenderTexture  // const
  public    static  UnityEngine.Video.VideoRenderModeMaterialOverride  // const
  public    static  UnityEngine.Video.VideoRenderModeAPIOnly  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Video.Video3DLayout
TYPE:  sealed struct
TOKEN: 0x2000005
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Video.Video3DLayout No3D  // const
  public    static  UnityEngine.Video.Video3DLayout SideBySide3D  // const
  public    static  UnityEngine.Video.Video3DLayout OverUnder3D  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Video.VideoAspectRatio
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Video.VideoAspectRatioNoScaling  // const
  public    static  UnityEngine.Video.VideoAspectRatioFitVertically  // const
  public    static  UnityEngine.Video.VideoAspectRatioFitHorizontally  // const
  public    static  UnityEngine.Video.VideoAspectRatioFitInside  // const
  public    static  UnityEngine.Video.VideoAspectRatioFitOutside  // const
  public    static  UnityEngine.Video.VideoAspectRatioStretch  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Video.VideoTimeSource
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Video.VideoTimeSourceAudioDSPTimeSource  // const
  public    static  UnityEngine.Video.VideoTimeSourceGameTimeSource  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Video.VideoTimeReference
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Video.VideoTimeReferenceFreerun  // const
  public    static  UnityEngine.Video.VideoTimeReferenceInternalTime  // const
  public    static  UnityEngine.Video.VideoTimeReferenceExternalTime  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Video.VideoSource
TYPE:  sealed struct
TOKEN: 0x2000009
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Video.VideoSource   VideoClip  // const
  public    static  UnityEngine.Video.VideoSource   Url  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Video.VideoAudioOutputMode
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Video.VideoAudioOutputModeNone  // const
  public    static  UnityEngine.Video.VideoAudioOutputModeAudioSource  // const
  public    static  UnityEngine.Video.VideoAudioOutputModeDirect  // const
  public    static  UnityEngine.Video.VideoAudioOutputModeAPIOnly  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Video.VideoPlayer
TYPE:  sealed class
TOKEN: 0x200000B
SIZE:  0x58
EXTENDS: UnityEngine.Behaviour
FIELDS:
  private           UnityEngine.Video.VideoPlayer.EventHandlerprepareCompleted  // 0x18
  private           UnityEngine.Video.VideoPlayer.EventHandlerloopPointReached  // 0x20
  private           UnityEngine.Video.VideoPlayer.EventHandlerstarted  // 0x28
  private           UnityEngine.Video.VideoPlayer.EventHandlerframeDropped  // 0x30
  private           UnityEngine.Video.VideoPlayer.ErrorEventHandlererrorReceived  // 0x38
  private           UnityEngine.Video.VideoPlayer.EventHandlerseekCompleted  // 0x40
  private           UnityEngine.Video.VideoPlayer.TimeEventHandlerclockResyncOccurred  // 0x48
  private           UnityEngine.Video.VideoPlayer.FrameReadyEventHandlerframeReady  // 0x50
PROPERTIES:
  source  get=0x09F8AEC0  set=0x09F8B9E4
  url  get=0x09F8B0FC  set=0x09F8BC7C
  clip  get=0x09F8AAAC  set=0x09F8B6B8
  renderMode  get=0x09F8AE24  set=0x09F8B91C
  targetCamera  get=0x09F8AF5C  set=0x09F8BAA8
  targetTexture  get=0x09F8AFF8  set=0x09F8BB74
  targetMaterialRenderer  get=0x09F8AFC4  set=0x09F8BB30
  targetMaterialProperty  get=0x09F8AF90  set=0x09F8BAEC
  aspectRatio  get=0x09F8A8D8  set=0x09F8B638
  targetCameraAlpha  get=0x09F8AF28  set=0x09F8BA64
  targetCamera3DLayout  get=0x09F8AEF4  set=0x09F8BA24
  texture  get=0x09F8B02C
  isPrepared  get=0x09F8ACEC
  waitForFirstFrame  get=0x09F8B130  set=0x09F8BCC0
  playOnAwake  get=0x09F8ADBC  set=0x09F8B894
  isPlaying  get=0x09F8ACB8
  isPaused  get=0x09F8AC84
  canSetTime  get=0x09F8AA44
  time  get=0x09F8B0C8  set=0x09F8BC38
  frame  get=0x09F8ABE8  set=0x09F8B80C
  clockTime  get=0x09F8AAE0
  canStep  get=0x09F8AA78
  canSetPlaybackSpeed  get=0x09F8A9A8
  playbackSpeed  get=0x09F8ADF0  set=0x09F8B8D8
  isLooping  get=0x09F8AC50  set=0x09F8B850
  canSetTimeSource  get=0x09F8AA10
  timeSource  get=0x09F8B094  set=0x09F8BBF8
  timeReference  get=0x09F8B060  set=0x09F8BBB8
  externalReferenceTime  get=0x09F8AB4C  set=0x09F8B7C8
  canSetSkipOnDrop  get=0x09F8A9DC
  skipOnDrop  get=0x09F8AE8C  set=0x09F8B9A0
  frameCount  get=0x09F8AB80
  frameRate  get=0x09F8ABB4
  length  get=0x09F8AD20
  width  get=0x09F8B164
  height  get=0x09F8AC1C
  pixelAspectRatioNumerator  get=0x09F8AD88
  pixelAspectRatioDenominator  get=0x09F8AD54
  audioTrackCount  get=0x09F8A940
  controlledAudioTrackMaxCount  get=0x09F8AB20
  controlledAudioTrackCount  get=0x09F8AB14  set=0x09F8B6FC
  audioOutputMode  get=0x09F8A90C  set=0x09F8B678
  canSetDirectAudioVolume  get=0x09F8A974
  sendFrameReadyEvents  get=0x09F8AE58  set=0x09F8B95C
EVENTS:
  prepareCompleted  add=add_prepareCompleted  remove=remove_prepareCompleted
  loopPointReached  add=add_loopPointReached  remove=remove_loopPointReached
  started  add=add_started  remove=remove_started
  frameDropped  add=add_frameDropped  remove=remove_frameDropped
  errorReceived  add=add_errorReceived  remove=remove_errorReceived
  seekCompleted  add=add_seekCompleted  remove=remove_seekCompleted
  clockResyncOccurred  add=add_clockResyncOccurred  remove=remove_clockResyncOccurred
  frameReady  add=add_frameReady  remove=remove_frameReady
METHODS:
  RVA=0x09F8A25C  token=0x6000028  System.Void Prepare()
  RVA=0x09F8A228  token=0x600002E  System.Void Play()
  RVA=0x09F8A1F4  token=0x600002F  System.Void Pause()
  RVA=0x09F8A404  token=0x6000030  System.Void Stop()
  RVA=0x09F8A3D0  token=0x600003A  System.Void StepForward()
  RVA=0x09F89EA8  token=0x6000052  System.String GetAudioLanguageCode(System.UInt16 trackIndex)
  RVA=0x09F89E64  token=0x6000053  System.UInt16 GetAudioChannelCount(System.UInt16 trackIndex)
  RVA=0x09F89EEC  token=0x6000054  System.UInt32 GetAudioSampleRate(System.UInt16 trackIndex)
  RVA=0x09F89F30  token=0x6000058  System.UInt16 GetControlledAudioTrackCount()
  RVA=0x09F8A290  token=0x6000059  System.Void SetControlledAudioTrackCount(System.UInt16 value)
  RVA=0x09F89E10  token=0x600005A  System.Void EnableAudioTrack(System.UInt16 trackIndex, System.Boolean enabled)
  RVA=0x09F8A1B0  token=0x600005B  System.Boolean IsAudioTrackEnabled(System.UInt16 trackIndex)
  RVA=0x09F89FA8  token=0x600005F  System.Single GetDirectAudioVolume(System.UInt16 trackIndex)
  RVA=0x09F8A328  token=0x6000060  System.Void SetDirectAudioVolume(System.UInt16 trackIndex, System.Single volume)
  RVA=0x09F89F64  token=0x6000061  System.Boolean GetDirectAudioMute(System.UInt16 trackIndex)
  RVA=0x09F8A2D4  token=0x6000062  System.Void SetDirectAudioMute(System.UInt16 trackIndex, System.Boolean mute)
  RVA=0x09F89FEC  token=0x6000063  UnityEngine.AudioSource GetTargetAudioSource(System.UInt16 trackIndex)
  RVA=0x09F8A37C  token=0x6000064  System.Void SetTargetAudioSource(System.UInt16 trackIndex, UnityEngine.AudioSource source)
  RVA=0x09F8A120  token=0x6000077  System.Void InvokePrepareCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source)
  RVA=0x09F8A0C0  token=0x6000078  System.Void InvokeFrameReadyCallback_Internal(UnityEngine.Video.VideoPlayer source, System.Int64 frameIdx)
  RVA=0x09F8A0F0  token=0x6000079  System.Void InvokeLoopPointReachedCallback_Internal(UnityEngine.Video.VideoPlayer source)
  RVA=0x09F8A180  token=0x600007A  System.Void InvokeStartedCallback_Internal(UnityEngine.Video.VideoPlayer source)
  RVA=0x09F8A090  token=0x600007B  System.Void InvokeFrameDroppedCallback_Internal(UnityEngine.Video.VideoPlayer source)
  RVA=0x09F8A060  token=0x600007C  System.Void InvokeErrorReceivedCallback_Internal(UnityEngine.Video.VideoPlayer source, System.String errorStr)
  RVA=0x09F8A150  token=0x600007D  System.Void InvokeSeekCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source)
  RVA=0x09F8A030  token=0x600007E  System.Void InvokeClockResyncOccurredCallback_Internal(UnityEngine.Video.VideoPlayer source, System.Double seconds)
  RVA=0x0426FE60  token=0x600007F  System.Void .ctor()
END_CLASS

