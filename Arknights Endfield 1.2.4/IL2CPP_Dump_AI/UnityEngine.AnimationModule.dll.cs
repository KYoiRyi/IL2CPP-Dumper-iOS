// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AnimationModule.dll
// Classes:  102
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

CLASS: Enumerator
TYPE:  sealed class
TOKEN: 0x200000D
SIZE:  0x20
IMPLEMENTS: System.Collections.IEnumerator
FIELDS:
  private           UnityEngine.Animation           m_Outer  // 0x10
  private           System.Int32                    m_CurrentIndex  // 0x18
PROPERTIES:
  Current  get=0x0329DB70
METHODS:
  RVA=0x025CE600  token=0x600004F  System.Void .ctor(UnityEngine.Animation outer)
  RVA=0x031AB930  token=0x6000051  System.Boolean MoveNext()
  RVA=0x03D50330  token=0x6000052  System.Void Reset()
END_CLASS

CLASS: AnimationEventCallback
TYPE:  sealed class
TOKEN: 0x2000029
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x03CC43E0  token=0x600029C  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x021126B0  token=0x600029D  System.Boolean Invoke(UnityEngine.Animator animator, UnityEngine.FastAnimationEvent fastAnimationEvent)
END_CLASS

CLASS: AnimatorStateChangeCallback
TYPE:  sealed class
TOKEN: 0x200002A
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x0349B320  token=0x600029E  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x09D8F4F0  token=0x600029F  System.Void Invoke(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo animatorStateInfo, System.Int32 layerIndex)
END_CLASS

CLASS: AnimationEventCallbackOpt
TYPE:  sealed class
TOKEN: 0x200002B
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x027ACE40  token=0x60002A0  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x09D8AA38  token=0x60002A1  System.Boolean Invoke(UnityEngine.Animator animator, UnityEngine.FastAnimationEventGroup fastAnimationEvent)
END_CLASS

CLASS: AniamtorCommonCallback
TYPE:  sealed class
TOKEN: 0x200002C
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x0613B2F0  token=0x60002A2  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x60002A3  System.Void Invoke(UnityEngine.Animator animator)
END_CLASS

CLASS: OnOverrideControllerDirtyCallback
TYPE:  sealed class
TOKEN: 0x2000030
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x042BE04C  token=0x60002C6  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x042BE03C  token=0x60002C7  System.Void Invoke()
END_CLASS

CLASS: ExecuteJobFunction
TYPE:  sealed class
TOKEN: 0x200004E
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=-1  // runtime  token=0x600031B  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=-1  // runtime  token=0x600031C  System.Void Invoke(T& data, System.IntPtr animationStreamPtr, System.IntPtr unusedPtr, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
END_CLASS

CLASS: UnityEngine.IAnimationClipSource
TYPE:  interface
TOKEN: 0x2000002
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.SharedBetweenAnimatorsAttribute
TYPE:  sealed class
TOKEN: 0x2000003
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000001  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.StateMachineBehaviour
TYPE:  abstract class
TOKEN: 0x2000004
SIZE:  0x18
EXTENDS: UnityEngine.ScriptableObject
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000002  System.Void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex)
  RVA=0x0350B670  token=0x6000003  System.Void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex)
  RVA=0x0350B670  token=0x6000004  System.Void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex)
  RVA=0x0350B670  token=0x6000005  System.Void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex)
  RVA=0x0350B670  token=0x6000006  System.Void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex)
  RVA=0x0350B670  token=0x6000007  System.Void OnStatePreExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex)
  RVA=0x0350B670  token=0x6000008  System.Void OnStateMachineEnter(UnityEngine.Animator animator, System.Int32 stateMachinePathHash)
  RVA=0x0350B670  token=0x6000009  System.Void OnStateMachineExit(UnityEngine.Animator animator, System.Int32 stateMachinePathHash)
  RVA=0x0350B670  token=0x600000A  System.Void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller)
  RVA=0x0350B670  token=0x600000B  System.Void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller)
  RVA=0x0350B670  token=0x600000C  System.Void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller)
  RVA=0x0350B670  token=0x600000D  System.Void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller)
  RVA=0x0350B670  token=0x600000E  System.Void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller)
  RVA=0x0350B670  token=0x600000F  System.Void OnStatePreExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller)
  RVA=0x0350B670  token=0x6000010  System.Void OnStateMachineEnter(UnityEngine.Animator animator, System.Int32 stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller)
  RVA=0x0350B670  token=0x6000011  System.Void OnStateMachineExit(UnityEngine.Animator animator, System.Int32 stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller)
  RVA=0x0286F540  token=0x6000012  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.PlayMode
TYPE:  sealed struct
TOKEN: 0x2000005
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.PlayMode            StopSameLayer  // const
  public    static  UnityEngine.PlayMode            StopAll  // const
METHODS:
END_CLASS

CLASS: UnityEngine.QueueMode
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.QueueMode           CompleteOthers  // const
  public    static  UnityEngine.QueueMode           PlayNow  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AnimationBlendMode
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimationBlendMode  Blend  // const
  public    static  UnityEngine.AnimationBlendMode  Additive  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AnimationPlayMode
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimationPlayMode   Stop  // const
  public    static  UnityEngine.AnimationPlayMode   Queue  // const
  public    static  UnityEngine.AnimationPlayMode   Mix  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AnimationCullingType
TYPE:  sealed struct
TOKEN: 0x2000009
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimationCullingTypeAlwaysAnimate  // const
  public    static  UnityEngine.AnimationCullingTypeBasedOnRenderers  // const
  public    static  UnityEngine.AnimationCullingTypeBasedOnClipBounds  // const
  public    static  UnityEngine.AnimationCullingTypeBasedOnUserBounds  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AnimationEventSource
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimationEventSourceNoSource  // const
  public    static  UnityEngine.AnimationEventSourceLegacy  // const
  public    static  UnityEngine.AnimationEventSourceAnimator  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AnimEventHashCodeType
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimEventHashCodeTypeNone  // const
  public    static  UnityEngine.AnimEventHashCodeTypeCRC32  // const
  public    static  UnityEngine.AnimEventHashCodeTypeHashCode64  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Animation
TYPE:  sealed class
TOKEN: 0x200000C
SIZE:  0x18
EXTENDS: UnityEngine.Behaviour
IMPLEMENTS: System.Collections.IEnumerable
FIELDS:
PROPERTIES:
  clip  get=0x09D8DDF4  set=0x09D8DFF4
  playAutomatically  get=0x09D8DF04  set=0x025CBA30
  wrapMode  get=0x09D8DF38  set=0x09D8E0D0
  isPlaying  get=0x09D8DE5C
  Item  get=0x09D8DD80
  animatePhysics  get=0x09D8DDC0  set=0x09D8DFB0
  animateOnlyIfVisible  get=0x09D8DD8C  set=0x09D8DF6C
  cullingType  get=0x09D8DE28  set=0x09D8E038
  localBounds  get=0x09D8DED4  set=0x09D8E0BC
METHODS:
  RVA=0x02C6CE90  token=0x6000019  System.Void Stop()
  RVA=0x09D8DD38  token=0x600001A  System.Void Stop(System.String name)
  RVA=0x09D8DCF4  token=0x600001B  System.Void StopNamed(System.String name)
  RVA=0x09D8DC84  token=0x600001C  System.Void Rewind()
  RVA=0x09D8DCB8  token=0x600001D  System.Void Rewind(System.String name)
  RVA=0x09D8DC40  token=0x600001E  System.Void RewindNamed(System.String name)
  RVA=0x09D8DCC0  token=0x600001F  System.Void Sample()
  RVA=0x09D8DAD0  token=0x6000021  System.Boolean IsPlaying(System.String name)
  RVA=0x03787540  token=0x6000023  System.Boolean Play()
  RVA=0x04276B58  token=0x6000024  System.Boolean Play(UnityEngine.PlayMode mode)
  RVA=0x03D1EA50  token=0x6000025  System.Boolean PlayDefaultAnimation(UnityEngine.PlayMode mode)
  RVA=0x04276B48  token=0x6000026  System.Boolean Play(System.String animation)
  RVA=0x03CC4640  token=0x6000027  System.Boolean Play(System.String animation, UnityEngine.PlayMode mode)
  RVA=0x09D8DA8C  token=0x6000028  System.Void CrossFade(System.String animation)
  RVA=0x09D8DA0C  token=0x6000029  System.Void CrossFade(System.String animation, System.Single fadeLength)
  RVA=0x09D8DA28  token=0x600002A  System.Void CrossFade(System.String animation, System.Single fadeLength, UnityEngine.PlayMode mode)
  RVA=0x09D8D8C8  token=0x600002B  System.Void Blend(System.String animation)
  RVA=0x09D8D93C  token=0x600002C  System.Void Blend(System.String animation, System.Single targetWeight)
  RVA=0x09D8D8D8  token=0x600002D  System.Void Blend(System.String animation, System.Single targetWeight, System.Single fadeLength)
  RVA=0x09D8D994  token=0x600002E  UnityEngine.AnimationState CrossFadeQueued(System.String animation)
  RVA=0x09D8D95C  token=0x600002F  UnityEngine.AnimationState CrossFadeQueued(System.String animation, System.Single fadeLength)
  RVA=0x09D8D978  token=0x6000030  UnityEngine.AnimationState CrossFadeQueued(System.String animation, System.Single fadeLength, UnityEngine.QueueMode queue)
  RVA=0x09D8D9A8  token=0x6000031  UnityEngine.AnimationState CrossFadeQueued(System.String animation, System.Single fadeLength, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode)
  RVA=0x09D8DB14  token=0x6000032  UnityEngine.AnimationState PlayQueued(System.String animation)
  RVA=0x09D8DB88  token=0x6000033  UnityEngine.AnimationState PlayQueued(System.String animation, UnityEngine.QueueMode queue)
  RVA=0x09D8DB24  token=0x6000034  UnityEngine.AnimationState PlayQueued(System.String animation, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode)
  RVA=0x09D8D83C  token=0x6000035  System.Void AddClip(UnityEngine.AnimationClip clip, System.String newName)
  RVA=0x09D8D818  token=0x6000036  System.Void AddClip(UnityEngine.AnimationClip clip, System.String newName, System.Int32 firstFrame, System.Int32 lastFrame)
  RVA=0x09D8D864  token=0x6000037  System.Void AddClip(UnityEngine.AnimationClip clip, System.String newName, System.Int32 firstFrame, System.Int32 lastFrame, System.Boolean addLoopFrame)
  RVA=0x09D8DBFC  token=0x6000038  System.Void RemoveClip(UnityEngine.AnimationClip clip)
  RVA=0x09D8DBF4  token=0x6000039  System.Void RemoveClip(System.String clipName)
  RVA=0x09D8DBB0  token=0x600003A  System.Void RemoveClipNamed(System.String clipName)
  RVA=0x09D8DA9C  token=0x600003B  System.Int32 GetClipCount()
  RVA=0x04276B58  token=0x600003C  System.Boolean Play(UnityEngine.AnimationPlayMode mode)
  RVA=0x09D8DBA4  token=0x600003D  System.Boolean Play(System.String animation, UnityEngine.AnimationPlayMode mode)
  RVA=0x09D8DD40  token=0x600003E  System.Void SyncLayer(System.Int32 layer)
  RVA=0x025CE5A0  token=0x600003F  System.Collections.IEnumerator GetEnumerator()
  RVA=0x02C6CE40  token=0x6000040  UnityEngine.AnimationState GetState(System.String name)
  RVA=0x0329DBA0  token=0x6000041  UnityEngine.AnimationState GetStateAtIndex(System.Int32 index)
  RVA=0x031AB9A0  token=0x6000042  System.Int32 GetStateCount()
  RVA=0x02C6CE10  token=0x6000043  UnityEngine.AnimationClip GetClip(System.String name)
  RVA=0x0426FE60  token=0x600004C  System.Void .ctor()
  RVA=0x09D8DE90  token=0x600004D  System.Void get_localBounds_Injected(UnityEngine.Bounds& ret)
  RVA=0x09D8E078  token=0x600004E  System.Void set_localBounds_Injected(UnityEngine.Bounds& value)
END_CLASS

CLASS: UnityEngine.AnimationState
TYPE:  sealed class
TOKEN: 0x200000E
SIZE:  0x18
EXTENDS: UnityEngine.TrackedReference
FIELDS:
PROPERTIES:
  enabled  get=0x09D8D138  set=0x09D8D2E4
  weight  get=0x09D8D270  set=0x09D8D47C
  wrapMode  get=0x025CBEB0  set=0x09D8D4C0
  time  get=0x09D8D23C  set=0x09D8D438
  normalizedTime  get=0x09D8D1D4  set=0x09D8D3B0
  speed  get=0x09D8D208  set=0x09D8D3F4
  normalizedSpeed  get=0x09D8D1A0  set=0x09D8D36C
  length  get=0x025CC780
  layer  get=0x09D8D16C  set=0x025CE3C0
  clip  get=0x025CE210
  name  get=0x025CD470  set=0x09D8D328
  blendMode  get=0x09D8D104  set=0x09D8D2A4
METHODS:
  RVA=0x09D8D060  token=0x6000069  System.Void AddMixingTransform(UnityEngine.Transform mix)
  RVA=0x09D8D06C  token=0x600006A  System.Void AddMixingTransform(UnityEngine.Transform mix, System.Boolean recursive)
  RVA=0x09D8D0C0  token=0x600006B  System.Void RemoveMixingTransform(UnityEngine.Transform mix)
  RVA=0x0350B670  token=0x600006C  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.FastAnimationEvent
TYPE:  sealed struct
TOKEN: 0x200000F
SIZE:  0x48
FIELDS:
  private           System.Single                   m_Time  // 0x10
  private           System.Single                   m_ClipWeight  // 0x14
  private           System.String                   m_FunctionName  // 0x18
  private           System.String                   m_StringParameter  // 0x20
  private           UnityEngine.Object              m_ObjectReferenceParameter  // 0x28
  private           System.Single                   m_FloatParameter  // 0x30
  private           System.Int32                    m_IntParameter  // 0x34
  private           UnityEngine.SendMessageOptions  m_MessageOptions  // 0x38
  private           System.Int32                    m_StringParameterHashCode  // 0x3c
  private           System.Int32                    m_FunctionNameHashCode  // 0x40
  private           System.Boolean                  m_IsInTransition  // 0x44
  private           System.Boolean                  m_IsFromMaxWeightClipState  // 0x45
  private           System.Boolean                  m_IsFromNextMaxWeightClipState  // 0x46
PROPERTIES:
  stringParameter  get=0x03D66B80  set=0x0426FEE0
  floatParameter  get=0x03D85A70  set=0x03D4F2F0
  intParameter  get=0x03D85AA0  set=0x03D4E2F0
  functionName  get=0x03D85A90
  time  get=0x03D85AE0  set=0x03D58BD0
  messageOptions  set=0x03D4EBA0
  clipWeight  get=0x03D85850  set=0x03D58BF0
  isInTransition  get=0x03D85AD0  set=0x03D4F590
  isFromMaxWeightClipState  get=0x03D85AB0  set=0x03D4F580
  isFromNextMaxWeightClipState  get=0x03D85AC0  set=0x03D85AF0
  functionNameHashCode  get=0x03D85A80  set=0x03D4EE10
METHODS:
END_CLASS

CLASS: UnityEngine.FastAnimationEventGroup
TYPE:  sealed struct
TOKEN: 0x2000010
SIZE:  0x78
FIELDS:
  public            System.Int32                    count  // 0x10
  public            System.IntPtr                   times  // 0x18
  public            System.IntPtr                   clipWeights  // 0x20
  public            System.IntPtr                   functionNames  // 0x28
  public            System.IntPtr                   stringParameters  // 0x30
  public            System.IntPtr                   functionNamesHashCode  // 0x38
  public            System.IntPtr                   stringParametersHashCode  // 0x40
  public            System.IntPtr                   floatParameters  // 0x48
  public            System.IntPtr                   intParameters  // 0x50
  public            System.IntPtr                   messageOptions  // 0x58
  public            System.IntPtr                   inTransitions  // 0x60
  public            System.IntPtr                   isFromMaxWeightClipStatus  // 0x68
  public            System.IntPtr                   isFromNextMaxWeightClipStatus  // 0x70
METHODS:
END_CLASS

CLASS: UnityEngine.AnimationEvent
TYPE:  sealed class
TOKEN: 0x2000011
SIZE:  0x90
FIELDS:
  private           System.Single                   m_Time  // 0x10
  private           System.String                   m_FunctionName  // 0x18
  private           System.String                   m_StringParameter  // 0x20
  private           UnityEngine.Object              m_ObjectReferenceParameter  // 0x28
  private           System.Single                   m_FloatParameter  // 0x30
  private           System.Int32                    m_IntParameter  // 0x34
  private           System.Int32                    m_MessageOptions  // 0x38
  private           UnityEngine.AnimationEventSourcem_Source  // 0x3c
  private           UnityEngine.AnimationState      m_StateSender  // 0x40
  private           UnityEngine.AnimatorStateInfo   m_AnimatorStateInfo  // 0x48
  private           UnityEngine.AnimatorClipInfo    m_AnimatorClipInfo  // 0x7c
  private           System.Int32                    m_FunctionNameHashCode  // 0x84
  private           System.Int32                    m_StringParameterHashCode  // 0x88
  private           UnityEngine.AnimEventHashCodeTypem_HashCodeType  // 0x8c
PROPERTIES:
  stringParameter  get=0x03D85A20  set=0x04271930
  floatParameter  get=0x03D84BA0  set=0x03D4F5E0
  intParameter  get=0x03D85A10  set=0x03D4EE40
  objectReferenceParameter  set=0x02C92F10
  functionName  get=0x03D61D00  set=0x022C3A90
  time  get=0x03D85830  set=0x03D50CA0
  messageOptions  set=0x03D4ECB0
  isFiredByAnimator  get=0x09D8AB9C
  animatorClipInfo  get=0x09D8AB40
METHODS:
  RVA=0x09D8AAA4  token=0x6000081  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.AnimationClip
TYPE:  sealed class
TOKEN: 0x2000012
SIZE:  0x20
EXTENDS: UnityEngine.Motion
FIELDS:
PROPERTIES:
  length  get=0x02383B20
  startTime  get=0x09D8A7B8
  stopTime  get=0x09D8A7EC
  frameRate  get=0x09D8A5A4  set=0x09D8A8D4
  clipTag  get=0x09D8A4F8  set=0x09D8A888
  wrapMode  get=0x025CE310  set=0x09D8A9F8
  localBounds  get=0x09D8A788  set=0x09D8A9A0
  legacy  get=0x09D8A710  set=0x09D8A918
  humanMotion  get=0x09D8A6DC
  empty  get=0x09D8A52C
  hasGenericRootTransform  get=0x09D8A5D8
  hasMotionFloatCurves  get=0x09D8A640
  hasMotionCurves  get=0x09D8A60C
  hasRootCurves  get=0x09D8A674
  hasRootMotion  get=0x09D8A6A8
  transferRotationCompressed  get=0x09D8A820  set=0x09D8A9B4
  uniqueId  get=0x09D8A854
  events  get=0x09D8A560  set=0x09D8A8CC
METHODS:
  RVA=0x033570D0  token=0x6000090  System.Void .ctor()
  RVA=0x03357130  token=0x6000091  System.Void Internal_CreateAnimationClip(UnityEngine.AnimationClip self)
  RVA=0x025CE270  token=0x6000092  System.Void SampleAnimation(UnityEngine.GameObject go, System.Single time)
  RVA=0x02806BB0  token=0x6000093  System.Void SampleAnimationFast(UnityEngine.GameObject go, System.Single time)
  RVA=0x025CE350  token=0x6000094  System.Void SampleAnimation(UnityEngine.GameObject go, UnityEngine.AnimationClip clip, System.Single inTime, UnityEngine.WrapMode wrapMode)
  RVA=0x02806B40  token=0x6000095  System.Void SampleAnimationFast(UnityEngine.GameObject go, UnityEngine.AnimationClip clip, System.Single inTime, UnityEngine.WrapMode wrapMode)
  RVA=0x09D8A450  token=0x600009D  System.Void SetCurve(System.String relativePath, System.Type type, System.String propertyName, UnityEngine.AnimationCurve curve)
  RVA=0x09D8A394  token=0x600009E  System.Boolean GetAnimatorFloatCurve(System.String propertyName, UnityEngine.AnimationCurve curve)
  RVA=0x09D8A360  token=0x600009F  System.Void EnsureQuaternionContinuity()
  RVA=0x09D8A32C  token=0x60000A0  System.Void ClearCurves()
  RVA=0x09D8A41C  token=0x60000A1  System.UInt32 GetRuntimeMemorySize()
  RVA=0x09D8A2C0  token=0x60000B2  System.Void AddEvent(UnityEngine.AnimationEvent evt)
  RVA=0x09D8A27C  token=0x60000B3  System.Void AddEventInternal(System.Object evt)
  RVA=0x09D8A4B4  token=0x60000B6  System.Void SetEventsInternal(System.Array value)
  RVA=0x09D8A3E8  token=0x60000B7  System.Array GetEventsInternal()
  RVA=0x09D8A744  token=0x60000B8  System.Void get_localBounds_Injected(UnityEngine.Bounds& ret)
  RVA=0x09D8A95C  token=0x60000B9  System.Void set_localBounds_Injected(UnityEngine.Bounds& value)
END_CLASS

CLASS: UnityEngine.AvatarTarget
TYPE:  sealed struct
TOKEN: 0x2000013
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AvatarTarget        Root  // const
  public    static  UnityEngine.AvatarTarget        Body  // const
  public    static  UnityEngine.AvatarTarget        LeftFoot  // const
  public    static  UnityEngine.AvatarTarget        RightFoot  // const
  public    static  UnityEngine.AvatarTarget        LeftHand  // const
  public    static  UnityEngine.AvatarTarget        RightHand  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AvatarIKGoal
TYPE:  sealed struct
TOKEN: 0x2000014
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AvatarIKGoal        LeftFoot  // const
  public    static  UnityEngine.AvatarIKGoal        RightFoot  // const
  public    static  UnityEngine.AvatarIKGoal        LeftHand  // const
  public    static  UnityEngine.AvatarIKGoal        RightHand  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AvatarIKHint
TYPE:  sealed struct
TOKEN: 0x2000015
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AvatarIKHint        LeftKnee  // const
  public    static  UnityEngine.AvatarIKHint        RightKnee  // const
  public    static  UnityEngine.AvatarIKHint        LeftElbow  // const
  public    static  UnityEngine.AvatarIKHint        RightElbow  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorControllerParameterType
TYPE:  sealed struct
TOKEN: 0x2000016
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimatorControllerParameterTypeFloat  // const
  public    static  UnityEngine.AnimatorControllerParameterTypeInt  // const
  public    static  UnityEngine.AnimatorControllerParameterTypeBool  // const
  public    static  UnityEngine.AnimatorControllerParameterTypeTrigger  // const
METHODS:
END_CLASS

CLASS: UnityEngine.StateInfoIndex
TYPE:  sealed struct
TOKEN: 0x2000017
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.StateInfoIndex      CurrentState  // const
  public    static  UnityEngine.StateInfoIndex      NextState  // const
  public    static  UnityEngine.StateInfoIndex      ExitState  // const
  public    static  UnityEngine.StateInfoIndex      InterruptedState  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AnimationBlendStyle
TYPE:  sealed struct
TOKEN: 0x2000018
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimationBlendStyle Linear  // const
  public    static  UnityEngine.AnimationBlendStyle CubicIn  // const
  public    static  UnityEngine.AnimationBlendStyle HermiteCubic  // const
  public    static  UnityEngine.AnimationBlendStyle Sinusoidal  // const
  public    static  UnityEngine.AnimationBlendStyle CubicInOut  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorTransitionInterruptionSource
TYPE:  sealed struct
TOKEN: 0x2000019
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimatorTransitionInterruptionSourceNone  // const
  public    static  UnityEngine.AnimatorTransitionInterruptionSourceCurrent  // const
  public    static  UnityEngine.AnimatorTransitionInterruptionSourceNext  // const
  public    static  UnityEngine.AnimatorTransitionInterruptionSourceCurrentThenNext  // const
  public    static  UnityEngine.AnimatorTransitionInterruptionSourceNextThenCurrent  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorRecorderMode
TYPE:  sealed struct
TOKEN: 0x200001A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimatorRecorderModeOffline  // const
  public    static  UnityEngine.AnimatorRecorderModePlayback  // const
  public    static  UnityEngine.AnimatorRecorderModeRecord  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorUroMode
TYPE:  sealed struct
TOKEN: 0x200001B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimatorUroMode     Origin  // const
  public    static  UnityEngine.AnimatorUroMode     Predict  // const
  public    static  UnityEngine.AnimatorUroMode     PredictWithTick  // const
  public    static  UnityEngine.AnimatorUroMode     PredictWithTickAndRootMotion  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorCullingMode
TYPE:  sealed struct
TOKEN: 0x200001C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimatorCullingMode AlwaysAnimate  // const
  public    static  UnityEngine.AnimatorCullingMode CullUpdateTransforms  // const
  public    static  UnityEngine.AnimatorCullingMode CullCompletely  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorUpdateMode
TYPE:  sealed struct
TOKEN: 0x200001D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimatorUpdateMode  Normal  // const
  public    static  UnityEngine.AnimatorUpdateMode  AnimatePhysics  // const
  public    static  UnityEngine.AnimatorUpdateMode  UnscaledTime  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorJobDispatchMode
TYPE:  sealed struct
TOKEN: 0x200001E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimatorJobDispatchModeDefault  // const
  public    static  UnityEngine.AnimatorJobDispatchModeForceMainThread  // const
  public    static  UnityEngine.AnimatorJobDispatchModePreUpdate  // const
  public    static  UnityEngine.AnimatorJobDispatchModeCrossFrame  // const
  public    static  UnityEngine.AnimatorJobDispatchModeCrossFrameLateUpdate  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorLOD
TYPE:  sealed struct
TOKEN: 0x200001F
SIZE:  0x2C
FIELDS:
  public            System.Single                   worldAbsoluteDistance  // 0x10
  public            System.Single                   maxDeltaTime  // 0x14
  public            System.Int32                    framesPerUpdate  // 0x18
  public            System.Single                   maxBlendDeltaTime  // 0x1c
  public            System.Int32                    framesPerWrite  // 0x20
  public            System.Int32                    delayFrame  // 0x24
  public            UnityEngine.AnimatorUroMode     uroMode  // 0x28
METHODS:
  RVA=0x03D85A30  token=0x60000BA  System.Void .ctor(System.Single worldAbsoluteDistance, System.Int32 framesPerUpdate, System.Single maxDeltaTime, System.Int32 framesPerWrite, System.Single maxBlendDeltaTime, UnityEngine.AnimatorUroMode uroMode, System.Int32 delayFrame)
END_CLASS

CLASS: UnityEngine.AnimationTransformRWBufferHandle
TYPE:  sealed struct
TOKEN: 0x2000020
SIZE:  0x80
FIELDS:
  public            System.UInt16                   count  // 0x10
  public            System.UInt16                   invalidCount  // 0x12
  public            System.IntPtr                   validTransformIndexsPtr  // 0x18
  public            System.IntPtr                   invalidTransformIndexsPtr  // 0x20
  public            System.IntPtr                   localPositionsPtr  // 0x28
  public            System.IntPtr                   localRotationsPtr  // 0x30
  public            System.IntPtr                   localScalesPtr  // 0x38
  public            System.IntPtr                   positionsPtr  // 0x40
  public            System.IntPtr                   rotationsPtr  // 0x48
  public            System.IntPtr                   scalesPtr  // 0x50
  public            System.IntPtr                   physicsRatioPtr  // 0x58
  public            System.IntPtr                   writeFlagPtr  // 0x60
  public            System.IntPtr                   relativePostionPtr  // 0x68
  public            System.IntPtr                   relativeRotationPtr  // 0x70
  public            System.IntPtr                   relativeScalePtr  // 0x78
METHODS:
END_CLASS

CLASS: UnityEngine.HGAnimParameterSGHandle
TYPE:  sealed struct
TOKEN: 0x2000021
SIZE:  0x58
FIELDS:
  public            System.Int32                    errorCode  // 0x10
  public            System.UInt16                   floatParameterCount  // 0x14
  public            System.UInt16                   boolParameterCount  // 0x16
  public            System.UInt16                   intParameterCount  // 0x18
  public            System.UInt16                   layerCount  // 0x1a
  public            System.IntPtr                   floatParameterNamesPtr  // 0x20
  public            System.IntPtr                   floatParameterValuesPtr  // 0x28
  public            System.IntPtr                   boolParameterNamesPtr  // 0x30
  public            System.IntPtr                   boolParameterValuesPtr  // 0x38
  public            System.IntPtr                   intParameterNamesPtr  // 0x40
  public            System.IntPtr                   intParameterValuesPtr  // 0x48
  public            System.IntPtr                   layerWeightPtr  // 0x50
METHODS:
END_CLASS

CLASS: UnityEngine.AnimFrameSyncMode
TYPE:  sealed struct
TOKEN: 0x2000022
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimFrameSyncMode   FrameSyncInRootPlayable  // const
  public    static  UnityEngine.AnimFrameSyncMode   FrameSyncInBaseLayerState  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorClipInfo
TYPE:  sealed struct
TOKEN: 0x2000023
SIZE:  0x18
FIELDS:
  private           System.Int32                    m_ClipInstanceID  // 0x10
  private           System.Single                   m_Weight  // 0x14
PROPERTIES:
  clip  get=0x09D8E144
  weight  get=0x03D85850
METHODS:
  RVA=0x09D8E110  token=0x60000BD  UnityEngine.AnimationClip InstanceIDToAnimationClipPPtr(System.Int32 instanceID)
END_CLASS

CLASS: UnityEngine.AnimatorStateInfo
TYPE:  sealed struct
TOKEN: 0x2000024
SIZE:  0x44
FIELDS:
  private           System.Int32                    m_Name  // 0x10
  private           System.Int32                    m_Path  // 0x14
  private           System.Int32                    m_FullPath  // 0x18
  private           System.Single                   m_NormalizedTime  // 0x1c
  private           System.Single                   m_Length  // 0x20
  private           System.Single                   m_Speed  // 0x24
  private           System.Single                   m_SpeedMultiplier  // 0x28
  private           System.Int32                    m_Tag  // 0x2c
  private           System.Int32                    m_Loop  // 0x30
  private           System.Int32                    m_SyncGroup  // 0x34
  private           System.Int32                    m_SyncGroupRole  // 0x38
  private           System.Int32                    m_CullingMode  // 0x3c
  private           System.Int32                    m_SourceMsg  // 0x40
PROPERTIES:
  fullPathHash  get=0x03D68070
  shortNameHash  get=0x03D85860
  normalizedTime  get=0x03D85A60
  length  get=0x03D85830
  tagHash  get=0x03D66B90
  loop  get=0x0272C740
METHODS:
  RVA=0x09D8F538  token=0x60000BE  System.Boolean IsName(System.String name)
  RVA=0x038DF820  token=0x60000C4  System.Boolean IsTag(System.String tag)
END_CLASS

CLASS: UnityEngine.AnimatorStateRootMotionInfo
TYPE:  sealed struct
TOKEN: 0x2000025
SIZE:  0x7C
FIELDS:
  private           System.Int32                    m_NameHashLeft  // 0x10
  private           UnityEngine.Vector3             m_DeltaPositionLeft  // 0x14
  private           UnityEngine.Quaternion          m_DeltaRotationLeft  // 0x20
  private           System.Int32                    m_NameHashRight  // 0x30
  private           UnityEngine.Vector3             m_DeltaPositionRight  // 0x34
  private           UnityEngine.Quaternion          m_DeltaRotationRight  // 0x40
  private           System.Single                   m_TransitionWeight  // 0x50
  private           System.Single                   m_DeltaTime  // 0x54
  private           System.Single                   m_InterruptedTransitionWeight  // 0x58
  private           System.Int32                    m_NameHashinterrupted  // 0x5c
  private           UnityEngine.Vector3             m_DeltaPositioninterrupted  // 0x60
  private           UnityEngine.Quaternion          m_DeltaRotationinterrupted  // 0x6c
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorTransitionInfo
TYPE:  sealed struct
TOKEN: 0x2000026
SIZE:  0x30
FIELDS:
  private           System.Int32                    m_FullPath  // 0x10
  private           System.Int32                    m_UserName  // 0x14
  private           System.Int32                    m_Name  // 0x18
  private           System.Boolean                  m_HasFixedDuration  // 0x1c
  private           System.Single                   m_Duration  // 0x20
  private           System.Single                   m_NormalizedTime  // 0x24
  private           System.Boolean                  m_AnyState  // 0x28
  private           System.Int32                    m_TransitionType  // 0x2c
PROPERTIES:
  nameHash  get=0x03D68070
METHODS:
  RVA=0x09D8F568  token=0x60000C6  System.Boolean IsUserName(System.String name)
END_CLASS

CLASS: UnityEngine.MatchTargetWeightMask
TYPE:  sealed struct
TOKEN: 0x2000027
SIZE:  0x20
FIELDS:
  private           UnityEngine.Vector3             m_PositionXYZWeight  // 0x10
  private           System.Single                   m_RotationWeight  // 0x1c
METHODS:
  RVA=0x02103850  token=0x60000C8  System.Void .ctor(UnityEngine.Vector3 positionXYZWeight, System.Single rotationWeight)
END_CLASS

CLASS: UnityEngine.Animator
TYPE:  class
TOKEN: 0x2000028
SIZE:  0x48
EXTENDS: UnityEngine.Behaviour
FIELDS:
  private           UnityEngine.Animator.AnimationEventCallbackonAnimationEvent  // 0x18
  private           UnityEngine.Animator.AnimationEventCallbackOptonAnimationEventOpt  // 0x20
  private           UnityEngine.Animator.AnimatorStateChangeCallbackonAnimatorStateEnter  // 0x28
  private           UnityEngine.Animator.AnimatorStateChangeCallbackonAnimatorStateExit  // 0x30
  private           UnityEngine.Animator.AnimatorStateChangeCallbackonAnimatorStatePreExit  // 0x38
  private           UnityEngine.Animator.AniamtorCommonCallbackafterAnimatorUpdateGraphCB  // 0x40
PROPERTIES:
  fastAnimationEventsOpt  get=0x09D936F0  set=0x027ACDA0
  callBackAfterUpdateGraph  get=0x09D93688  set=0x09D94218
  fastAnimationEvents  get=0x09D93724  set=0x027ACDF0
  notifyAnimatorStateEnterAndExitEvent  get=0x09D93B40  set=0x0349B3D0
  keepStateOnChangeActive  get=0x09D9396C  set=0x09D942EC
  pausePlayableOnChangeActive  get=0x09D93B74  set=0x09D944C4
  resetControllerPlayableOnChangeActive  get=0x09D93D04  set=0x09D9454C
  isOptimizable  get=0x09D938C4
  isHuman  get=0x09D93828
  hasRootMotion  get=0x09D937C0
  isRootPositionOrRotationControlledByCurves  get=0x09D938F8
  humanScale  get=0x09D937F4
  isInitialized  get=0x09D9385C
  isVisible  get=0x02DDAB60
  updatedLastFrame  get=0x0287C8A0
  enableLOD  get=0x09D936BC  set=0x0297B950
  LODLevel  get=0x027AFEE0
  motionDeltaTime  get=0x09D93B0C
  deltaPosition  get=0x02D66490
  deltaRotation  get=0x031DEB30
  velocity  get=0x02D66330
  angularVelocity  get=0x02D663E0
  rootPosition  get=0x09D93DB0  set=0x09D945D4
  rootRotation  get=0x09D93E20  set=0x09D9462C
  applyRootMotion  get=0x09D934AC  set=0x09D940A4
  linearVelocityBlending  get=0x09D93A08  set=0x09D94374
  animatePhysics  get=0x09D93460  set=0x09D94040
  updateMode  get=0x02DBAAC0  set=0x09D94684
  hasTransformHierarchy  get=0x029F0ED0
  allowConstantClipSamplingOptimization  get=0x09D9342C  set=0x09D93FFC
  gravityWeight  get=0x033585D0
  bodyPosition  get=0x09D93584  set=0x09D94140
  bodyPositionInternal  get=0x09D93558  set=0x09D9412C
  bodyRotation  get=0x09D93644  set=0x09D941DC
  bodyRotationInternal  get=0x09D93618  set=0x09D941C8
  stabilizeFeet  get=0x09D93E80  set=0x09D94640
  layerCount  get=0x02EF2010
  parameters  get=0x02EEDD70
  parameterCount  get=0x03B1FD20
  feetPivotActive  get=0x09D93758  set=0x09D9425C
  pivotWeight  get=0x09D93C18
  pivotPosition  get=0x09D93BEC
  isMatchingTarget  get=0x09D93890
  timeScale  get=0x02E68A40  set=0x02B3DE50
  speed  get=0x09D93E4C  set=0x02B3DEA0
  targetPosition  get=0x09D93F2C
  targetRotation  get=0x09D93F9C
  avatarRoot  get=0x09D934E0
  cullingMode  get=0x027B2E80  set=0x028069F0
  playbackTime  get=0x09D93C84  set=0x09D94508
  recorderStartTime  get=0x09D93CEC  set=0x0350B670
  recorderStopTime  get=0x09D93CF8  set=0x0350B670
  recorderMode  get=0x09D93CB8
  runtimeAnimatorController  get=0x02B9A040  set=0x02F49A40
  hasBoundPlayables  get=0x022B3C10
  avatar  get=0x022D8D60  set=0x03A508A0
  morphAvatar  get=0x09D93AD8  set=0x09D94480
  lodBoneMask  get=0x09D93A70  set=0x09D943F8
  lodBoneMaskLevel  get=0x09D93A3C  set=0x09D943B8
  playableGraph  get=0x09D93C4C
  applyMorphPose  get=0x09D93478  set=0x09D94060
  layersAffectMassCenter  get=0x09D939A0  set=0x09D94330
  leftFeetBottomHeight  get=0x09D939D4
  rightFeetBottomHeight  get=0x09D93D38
  supportsOnAnimatorMove  get=0x09D93EB4
  logWarnings  get=0x09D93AA4  set=0x09D9443C
  fireEvents  get=0x09D9378C  set=0x09D942A0
  keepAnimatorControllerStateOnDisable  get=0x09D9392C  set=0x09D942E4
  keepAnimatorStateOnDisable  get=0x09D93938  set=0x036110E0
  writeDefaultValuesOnDisable  get=0x09D93FC8  set=0x02F49830
METHODS:
  RVA=0x09D933E0  token=0x60000C9  System.Void .ctor()
  RVA=0x09D91708  token=0x60000CA  System.Void Internal_CallAnimatorStateChangeCallback(UnityEngine.Animator anim, UnityEngine.AnimatorStateInfo animatorStateInfo, System.Int32 layerIndex, System.Int32 methodIdx)
  RVA=0x09D9169C  token=0x60000CB  System.Void Internal_CallAfterUpdateGraph(UnityEngine.Animator anim)
  RVA=0x033D90D0  token=0x60000CC  System.Boolean Internal_InvokeAnimationEventCallback(UnityEngine.Animator animator, UnityEngine.FastAnimationEvent fastAnimationEvent)
  RVA=0x028309E0  token=0x60000CD  System.Boolean Internal_InvokeAnimationEventCallbackOpt(UnityEngine.Animator animator, UnityEngine.FastAnimationEventGroup fastAnimationEvent)
  RVA=0x03CB2D80  token=0x60000CE  System.Void SetCallbackAfterRootMotionStageCallback(UnityEngine.Animator.AniamtorCommonCallback cb)
  RVA=0x022C3A90  token=0x60000CF  System.Void SetAnimationEventCallback(UnityEngine.Animator.AnimationEventCallback onAnimationEvent)
  RVA=0x04271930  token=0x60000D0  System.Void SetAnimationEventCallbackOpt(UnityEngine.Animator.AnimationEventCallbackOpt onAnimationEvent)
  RVA=0x0349B3A0  token=0x60000D1  System.Void SetNotifyAnimatorStateEnterAndExitEventCallBack(UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStateEnter, UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStateExit)
  RVA=0x0388FF30  token=0x60000D2  System.Void SetNotifyAnimatorStatePreExitEventCallBack(UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStatePreExit)
  RVA=0x02EF05A0  token=0x60000EC  System.Boolean SetLODLevel(System.Int32 level)
  RVA=0x09D90CFC  token=0x60000ED  System.Int32 GetCurrentLODLevel()
  RVA=0x02DDC330  token=0x60000EE  UnityEngine.AnimatorLOD[] GetLODs()
  RVA=0x02E38680  token=0x60000EF  System.Void SetLODs(UnityEngine.AnimatorLOD[] lods)
  RVA=0x09D92394  token=0x60000F0  System.Void SetConstraintEnableImmediately(System.Int32 nameHash)
  RVA=0x09D92304  token=0x60000F1  System.Void SetConstraintDisableImmediately(System.Int32 nameHash)
  RVA=0x09D92344  token=0x60000F2  System.Void SetConstraintEnableBlendIn(System.Int32 nameHash, System.Single duration)
  RVA=0x09D922B4  token=0x60000F3  System.Void SetConstraintDisableBlendOut(System.Int32 nameHash, System.Single duration)
  RVA=0x0349BCC0  token=0x60000F4  System.Void BecameVisible()
  RVA=0x03703960  token=0x60000F5  System.Void SetAnimatorJobOptEnable(System.Boolean enabel)
  RVA=0x037039A0  token=0x60000F6  System.Void SetAnimatorJobOptFunc(System.Int32 value)
  RVA=0x037039E0  token=0x60000F7  System.Void SetAnimatorWriteTransformOpt(System.Boolean value)
  RVA=0x03703A20  token=0x60000F8  System.Void SetGlobalAnimatorClipBindingsOpt(System.Boolean value)
  RVA=0x03703A60  token=0x60000F9  System.Void SetGlobalAnimatorClipBindingsConstantOpt(System.Boolean value)
  RVA=0x03703AA0  token=0x60000FA  System.Void SetGlobalAnimatorClipBindingsOptByAvatar(System.Boolean value)
  RVA=0x09D920A0  token=0x60000FB  System.Void SetAnimatorUroMaxDeltaTimePerframe(System.Single value)
  RVA=0x03703AE0  token=0x60000FC  System.Void SetGlobalAnimatorCacheClipBindingsOpt(System.Boolean value)
  RVA=0x09D906D4  token=0x60000FD  System.Single GetAnimatorUroMaxDeltaTimePerframe()
  RVA=0x09D9206C  token=0x60000FE  System.Void SetAnimatorMainThreadJobCount(System.Int32 value)
  RVA=0x09D930A0  token=0x60000FF  System.Void SetPrepareFrameJobBatchCountOpt(System.Int32 value)
  RVA=0x09D930D4  token=0x6000100  System.Void SetProcessAnimJobBatchCountOpt(System.Int32 value)
  RVA=0x03703B20  token=0x6000101  System.Void SetAnimatorEnableProcessOneStage(System.Boolean value)
  RVA=0x09D91FD0  token=0x6000102  System.Void SetAnimatorEnableApplyOnMoveInJob(System.Boolean value)
  RVA=0x09D92038  token=0x6000103  System.Void SetAnimatorEnableRequireEventsAndBehaviour(System.Boolean value)
  RVA=0x09D920DC  token=0x6000104  System.Void SetApplyBuildInRootMotionInJob(System.Boolean enable)
  RVA=0x03703B60  token=0x6000105  System.Void SetAnimatorForbbidenApplyOnMoveCb(System.Boolean value)
  RVA=0x09D92004  token=0x6000106  System.Void SetAnimatorEnableCrossFrameJobs(System.Boolean enabel)
  RVA=0x027ABF40  token=0x6000107  System.Void SetAbilityLevel(System.Int32 abilityLevel)
  RVA=0x027AFEA0  token=0x6000108  System.Int32 GetAbilityLevel()
  RVA=0x09D93108  token=0x6000109  System.Void SetSampleClipCacheCreatePreFrameCount(System.Int32 value)
  RVA=0x09D9313C  token=0x600010A  System.Void SetSampleClipCacheMaxCount(System.Int32 value)
  RVA=0x09D92B94  token=0x600010B  System.Void SetLayerMeshSpace(System.Int32 layerIndex, System.Boolean enable)
  RVA=0x09D912C4  token=0x600010C  System.Boolean GetLayerMeshSpace(System.Int32 layerIndex)
  RVA=0x09D923D4  token=0x600010D  System.Void SetControllerDefaultValues(System.Boolean value)
  RVA=0x04271FA0  token=0x600010E  System.Single GetFloat(System.String name)
  RVA=0x04270C3C  token=0x600010F  System.Single GetFloat(System.Int32 id)
  RVA=0x09D90E4C  token=0x6000110  System.Single GetFloatFromTransition(System.Int32 layerIndex, System.Int32 id)
  RVA=0x04275FB0  token=0x6000111  System.Single GetFloatFromTransitionWithDefault(System.Int32 layerIndex, System.Int32 id, System.Single defValue)
  RVA=0x042706B4  token=0x6000112  System.Void SetFloat(System.String name, System.Single value)
  RVA=0x09D9274C  token=0x6000113  System.Void SetFloat(System.String name, System.Single value, System.Single dampTime, System.Single deltaTime)
  RVA=0x04271FAC  token=0x6000114  System.Void SetFloat(System.Int32 id, System.Single value)
  RVA=0x09D9275C  token=0x6000115  System.Void SetFloat(System.Int32 id, System.Single value, System.Single dampTime, System.Single deltaTime)
  RVA=0x09D90B34  token=0x6000116  System.Boolean GetBool(System.String name)
  RVA=0x04274670  token=0x6000117  System.Boolean GetBool(System.Int32 id)
  RVA=0x04276650  token=0x6000118  System.Void SetBool(System.String name, System.Boolean value)
  RVA=0x04270030  token=0x6000119  System.Void SetBool(System.Int32 id, System.Boolean value)
  RVA=0x09D912B8  token=0x600011A  System.Int32 GetInteger(System.String name)
  RVA=0x0426FFE8  token=0x600011B  System.Int32 GetInteger(System.Int32 id)
  RVA=0x09D92B8C  token=0x600011C  System.Void SetInteger(System.String name, System.Int32 value)
  RVA=0x04270028  token=0x600011D  System.Void SetInteger(System.Int32 id, System.Int32 value)
  RVA=0x0426F564  token=0x600011E  System.Void SetTrigger(System.String name)
  RVA=0x09D931C8  token=0x600011F  System.Void SetTrigger(System.Int32 id)
  RVA=0x0426F55C  token=0x6000120  System.Void ResetTrigger(System.String name)
  RVA=0x04270C34  token=0x6000121  System.Void ResetTrigger(System.Int32 id)
  RVA=0x09D91A34  token=0x6000122  System.Boolean IsParameterControlledByCurve(System.String name)
  RVA=0x09D91A40  token=0x6000123  System.Boolean IsParameterControlledByCurve(System.Int32 id)
  RVA=0x09D91F8C  token=0x6000136  System.Void SetAllowConstantClipSamplingOpt(System.Boolean enable)
  RVA=0x09D9118C  token=0x6000142  UnityEngine.Vector3 GetIKPosition(UnityEngine.AvatarIKGoal goal)
  RVA=0x09D90EA8  token=0x6000143  UnityEngine.Vector3 GetGoalPosition(UnityEngine.AvatarIKGoal goal)
  RVA=0x09D92A5C  token=0x6000144  System.Void SetIKPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition)
  RVA=0x09D927BC  token=0x6000145  System.Void SetGoalPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition)
  RVA=0x09D9121C  token=0x6000146  UnityEngine.Quaternion GetIKRotation(UnityEngine.AvatarIKGoal goal)
  RVA=0x09D90F28  token=0x6000147  UnityEngine.Quaternion GetGoalRotation(UnityEngine.AvatarIKGoal goal)
  RVA=0x09D92AF0  token=0x6000148  System.Void SetIKRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation)
  RVA=0x09D92820  token=0x6000149  System.Void SetGoalRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation)
  RVA=0x09D9115C  token=0x600014A  System.Single GetIKPositionWeight(UnityEngine.AvatarIKGoal goal)
  RVA=0x09D90F58  token=0x600014B  System.Single GetGoalWeightPosition(UnityEngine.AvatarIKGoal goal)
  RVA=0x09D92A1C  token=0x600014C  System.Void SetIKPositionWeight(UnityEngine.AvatarIKGoal goal, System.Single value)
  RVA=0x09D92834  token=0x600014D  System.Void SetGoalWeightPosition(UnityEngine.AvatarIKGoal goal, System.Single value)
  RVA=0x09D911EC  token=0x600014E  System.Single GetIKRotationWeight(UnityEngine.AvatarIKGoal goal)
  RVA=0x09D90F98  token=0x600014F  System.Single GetGoalWeightRotation(UnityEngine.AvatarIKGoal goal)
  RVA=0x09D92AB0  token=0x6000150  System.Void SetIKRotationWeight(UnityEngine.AvatarIKGoal goal, System.Single value)
  RVA=0x09D92884  token=0x6000151  System.Void SetGoalWeightRotation(UnityEngine.AvatarIKGoal goal, System.Single value)
  RVA=0x09D910FC  token=0x6000152  UnityEngine.Vector3 GetIKHintPosition(UnityEngine.AvatarIKHint hint)
  RVA=0x09D9105C  token=0x6000153  UnityEngine.Vector3 GetHintPosition(UnityEngine.AvatarIKHint hint)
  RVA=0x09D929C8  token=0x6000154  System.Void SetIKHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition)
  RVA=0x09D92924  token=0x6000155  System.Void SetHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition)
  RVA=0x09D910CC  token=0x6000156  System.Single GetIKHintPositionWeight(UnityEngine.AvatarIKHint hint)
  RVA=0x09D9108C  token=0x6000157  System.Single GetHintWeightPosition(UnityEngine.AvatarIKHint hint)
  RVA=0x09D92988  token=0x6000158  System.Void SetIKHintPositionWeight(UnityEngine.AvatarIKHint hint, System.Single value)
  RVA=0x09D92938  token=0x6000159  System.Void SetHintWeightPosition(UnityEngine.AvatarIKHint hint, System.Single value)
  RVA=0x09D92C40  token=0x600015A  System.Void SetLookAtPosition(UnityEngine.Vector3 lookAtPosition)
  RVA=0x09D92C2C  token=0x600015B  System.Void SetLookAtPositionInternal(UnityEngine.Vector3 lookAtPosition)
  RVA=0x09D92EB0  token=0x600015C  System.Void SetLookAtWeight(System.Single weight)
  RVA=0x09D92CEC  token=0x600015D  System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight)
  RVA=0x09D92E40  token=0x600015E  System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight)
  RVA=0x09D92D50  token=0x600015F  System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight)
  RVA=0x09D92DC8  token=0x6000160  System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight)
  RVA=0x09D92C84  token=0x6000161  System.Void SetLookAtWeightInternal(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight)
  RVA=0x09D921C8  token=0x6000162  System.Void SetBoneLocalRotation(UnityEngine.HumanBodyBones humanBoneId, UnityEngine.Quaternion rotation)
  RVA=0x09D921B4  token=0x6000163  System.Void SetBoneLocalRotationInternal(System.Int32 humanBoneId, UnityEngine.Quaternion rotation)
  RVA=0x09D931C0  token=0x6000164  System.Void SetTransformHierarchy(System.Boolean bHas)
  RVA=0x03B33D60  token=0x6000165  System.Void SetTransformHierarchyInternal(System.Boolean bHas)
  RVA=0x09D9083C  token=0x6000166  System.Boolean GetBoneGlobalTRS(System.Int32 avatarAssetBoneID, UnityEngine.AnimationTransformf& trs)
  RVA=0x09D907EC  token=0x6000167  System.Boolean GetBoneGlobalTRSInternal(System.Int32 avatarAssetBoneID, UnityEngine.AnimationTransformf& trs)
  RVA=0x09D909A0  token=0x6000168  UnityEngine.AnimationTransformf GetBoneRootTRS(System.Int32 avatarAssetBoneID)
  RVA=0x09D90968  token=0x6000169  UnityEngine.AnimationTransformf GetBoneRootTRSInternal(System.Int32 avatarAssetBoneID)
  RVA=0x09D908D0  token=0x600016A  UnityEngine.AnimationTransformf GetBoneLocalTRS(System.Int32 avatarAssetBoneID)
  RVA=0x09D90898  token=0x600016B  UnityEngine.AnimationTransformf GetBoneLocalTRSInternal(System.Int32 avatarAssetBoneID)
  RVA=0x09D92418  token=0x600016C  System.Void SetCorrectiveBoneData(UnityEngine.HGCorrectiveBoneData bindings)
  RVA=0x09D92578  token=0x600016D  System.Void SetEnableCorrectiveBoneSystem(System.Boolean enable)
  RVA=0x03000FB0  token=0x600016E  System.Void SetSequenceLayerSkipTimeThreshold(System.Single value)
  RVA=0x09D91550  token=0x600016F  System.Single GetSequenceLayerSkipTimeThreshold()
  RVA=0x09D90420  token=0x6000170  System.Void ForceUpdateCorrectiveBoneDataInEditor()
  RVA=0x09D92120  token=0x6000171  System.Void SetBakedBindingData(UnityEngine.HGAnimationSetBindings bindings)
  RVA=0x09D90338  token=0x6000172  System.Void EnableBakedBindingData(System.Boolean enable)
  RVA=0x09D9221C  token=0x6000173  System.Boolean SetClipByIndex(UnityEngine.AnimationClip overrideClip, System.Int32 index)
  RVA=0x09D93324  token=0x6000174  System.Void UnloadClipsNoRebind(UnityEngine.AnimationClip[] overrideClip, System.Boolean clearCache)
  RVA=0x09D91ED4  token=0x6000175  System.Void ReloadClipsNoRebind(UnityEngine.AnimationClip[] overrideClip)
  RVA=0x030F6980  token=0x6000176  System.Void CaptureLastHumanPose()
  RVA=0x03000F60  token=0x6000177  System.Void SetWriteTransformDefAsPostProcess(System.Boolean enable)
  RVA=0x09D931D0  token=0x6000178  System.Void SetWriteTransformDefAsPostProcessSkipOpt(System.Boolean enable)
  RVA=0x03850240  token=0x6000179  System.Void SetAnimatorJobDispatchMode(UnityEngine.AnimatorJobDispatchMode mode)
  RVA=0x09D9054C  token=0x600017A  UnityEngine.AnimatorJobDispatchMode GetAnimatorJobDispatchMode()
  RVA=0x09D8F58C  token=0x600017B  System.Boolean AddToFrameSyncGroup(System.String groupName, System.Boolean isMaster, UnityEngine.AnimFrameSyncMode syncMode)
  RVA=0x09D91F18  token=0x600017C  System.Boolean RemoveFromFrameSyncGroup()
  RVA=0x09D92534  token=0x600017D  System.Void SetEnableCollisionConstraintSolver(System.Boolean enable)
  RVA=0x09D925BC  token=0x600017E  System.Void SetEnableDefaultValuesForceUseDefaultPose(System.Boolean enable)
  RVA=0x09D91948  token=0x600017F  System.Boolean IsEnableDefaultValuesForceUseDefaultPose()
  RVA=0x09D92644  token=0x6000180  System.Void SetEnableWriteDefaultValues(System.Boolean enable)
  RVA=0x09D924F0  token=0x6000181  System.Void SetEnableClipBindingOpt(System.Boolean enable)
  RVA=0x09D92600  token=0x6000182  System.Void SetEnableOptBindingByAvatar(System.Boolean enable)
  RVA=0x02EF34D0  token=0x6000183  System.Boolean AddClipsToBindingsNoGrown(UnityEngine.AnimationClip[] overrideClip, System.Int32 nameHash)
  RVA=0x02F49A90  token=0x6000184  System.Void SetDynamicBindingReserveCount(System.Int32 count)
  RVA=0x09D9245C  token=0x6000185  System.Void SetDynamicBindingReserveCountByTag(System.Int32 stringHash, System.Int32 count)
  RVA=0x09D91E8C  token=0x6000186  System.Void ReCreatePlayableMemory()
  RVA=0x09D8F854  token=0x6000187  UnityEngine.AnimationTransformRWBufferHandle CreateClothBindings(UnityEngine.Transform[] transformAccessArray)
  RVA=0x09D8F7B8  token=0x6000188  UnityEngine.AnimationTransformRWBufferHandle CreateClothBindingsByNameLst(System.String[] transformPathArray)
  RVA=0x09D902D0  token=0x6000189  System.Void DestroyClothBindings()
  RVA=0x09D9037C  token=0x600018A  System.Void EnableClothBindings()
  RVA=0x09D90304  token=0x600018B  System.Void DisableClothBindings()
  RVA=0x09D92270  token=0x600018C  System.Void SetClothBindingsEnableWorldSpace(System.Boolean value)
  RVA=0x09D8F624  token=0x600018D  System.Boolean CheckClothBindingsEnableWorldSpace()
  RVA=0x09D92F08  token=0x600018E  System.Void SetMorphBindingsEnableWorldSpace(System.Boolean value)
  RVA=0x09D8F6FC  token=0x600018F  System.Boolean CheckMorphBindingsEnableWorldSpace()
  RVA=0x02FADD50  token=0x6000190  UnityEngine.AnimationTransformRWBufferHandle CreateMorphBindings(UnityEngine.Transform[] transformAccessArray)
  RVA=0x09D8F8F0  token=0x6000191  UnityEngine.AnimationTransformRWBufferHandle CreateMorphBindingsByNameLst(System.String[] transformPathArray)
  RVA=0x02FADD10  token=0x6000192  System.Void EnableMorphBindings()
  RVA=0x02F5D9F0  token=0x6000193  System.Void DisableMorphBindings()
  RVA=0x03627320  token=0x6000194  System.Void SetOptimizedAvatarDataSet(System.Boolean optimized)
  RVA=0x09D924AC  token=0x6000195  System.Void SetEnabelMorphBindingWriteInLateUpdate(System.Boolean enable)
  RVA=0x09D90700  token=0x6000196  UnityEngine.ScriptableObject GetBehaviour(System.Type type)
  RVA=-1  // generic def  token=0x6000197  T GetBehaviour()
  RVA=-1  // generic def  token=0x6000198  T[] ConvertStateMachineBehaviour(UnityEngine.ScriptableObject[] rawObjects)
  RVA=-1  // generic def  token=0x6000199  T[] GetBehaviours()
  RVA=0x09D91658  token=0x600019A  UnityEngine.ScriptableObject[] InternalGetBehaviours(System.Type type)
  RVA=0x09D90744  token=0x600019B  UnityEngine.StateMachineBehaviour[] GetBehaviours(System.Int32 fullPathHash, System.Int32 layerIndex)
  RVA=0x09D915F8  token=0x600019C  UnityEngine.ScriptableObject[] InternalGetBehavioursByKey(System.Int32 fullPathHash, System.Int32 layerIndex, System.Type type)
  RVA=0x03A2D3F0  token=0x60001A0  System.String GetLayerName(System.Int32 layerIndex)
  RVA=0x02EF3A40  token=0x60001A1  System.Int32 GetLayerIndex(System.String layerName)
  RVA=0x09D91304  token=0x60001A2  System.Single GetLayerWeight(System.Int32 layerIndex)
  RVA=0x03336E20  token=0x60001A3  System.Void SetLayerWeight(System.Int32 layerIndex, System.Single weight)
  RVA=0x0292F3B0  token=0x60001A4  System.Void GetAnimatorStateInfo(System.Int32 layerIndex, UnityEngine.StateInfoIndex stateInfoIndex, UnityEngine.AnimatorStateInfo& info)
  RVA=0x0292F300  token=0x60001A5  UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(System.Int32 layerIndex)
  RVA=0x0292F240  token=0x60001A6  UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(System.Int32 layerIndex)
  RVA=0x09D90630  token=0x60001A7  System.Void GetAnimatorTransitionInfo(System.Int32 layerIndex, UnityEngine.AnimatorTransitionInfo& info)
  RVA=0x09D90680  token=0x60001A8  UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfo(System.Int32 layerIndex)
  RVA=0x09D90498  token=0x60001A9  System.Int32 GetAnimatorClipInfoCount(System.Int32 layerIndex, System.Boolean current)
  RVA=0x09D90B40  token=0x60001AA  System.Int32 GetCurrentAnimatorClipInfoCount(System.Int32 layerIndex)
  RVA=0x09D913F0  token=0x60001AB  System.Int32 GetNextAnimatorClipInfoCount(System.Int32 layerIndex)
  RVA=0x09D90BC8  token=0x60001AC  UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(System.Int32 layerIndex)
  RVA=0x09D91478  token=0x60001AD  UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo(System.Int32 layerIndex)
  RVA=0x09D90D90  token=0x60001AE  System.Boolean GetDebugAnimatorClipInfo(System.Int32 layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips)
  RVA=0x09D90B50  token=0x60001AF  System.Void GetCurrentAnimatorClipInfo(System.Int32 layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips)
  RVA=0x09D904EC  token=0x60001B0  System.Void GetAnimatorClipInfoInternal(System.Int32 layerIndex, System.Boolean isCurrent, System.Object clips)
  RVA=0x09D90D40  token=0x60001B1  System.Boolean GetDebugAnimatorClipInfoInternal(System.Int32 layerIndex, System.Object clips)
  RVA=0x09D91400  token=0x60001B2  System.Void GetNextAnimatorClipInfo(System.Int32 layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips)
  RVA=0x0292F420  token=0x60001B3  System.Boolean IsInTransition(System.Int32 layerIndex)
  RVA=0x02931680  token=0x60001B4  System.Boolean IsPlayingTag(System.Int32 layerIndex, System.Int32 tagHash)
  RVA=0x0272A910  token=0x60001B5  System.Boolean IsPlayingState(System.Int32 layerIndex, System.Int32 stateNameHash)
  RVA=0x029318B0  token=0x60001B6  System.Int32 GetAnimatorStateCullMode(System.Int32 layerIndex)
  RVA=0x09D90C08  token=0x60001B7  UnityEngine.AnimatorStateRootMotionInfo GetCurrentAnimatorStateRootmotionInfo(System.Int32 layerIndex)
  RVA=0x09D905E0  token=0x60001B8  System.Void GetAnimatorStateRootMotionInfo(System.Int32 layerIndex, UnityEngine.AnimatorStateRootMotionInfo& output)
  RVA=0x09D915B8  token=0x60001B9  System.Boolean HasTrigger(System.Int32 triggerId)
  RVA=0x039DD090  token=0x60001BC  UnityEngine.AnimatorControllerParameter GetParameterInternal(System.Int32 index)
  RVA=0x039DD050  token=0x60001BD  UnityEngine.AnimatorControllerParameter GetParameter(System.Int32 index)
  RVA=0x09D91BA8  token=0x60001C2  System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, System.Int32 targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch)
  RVA=0x09D91B2C  token=0x60001C3  System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime)
  RVA=0x09D91AB0  token=0x60001C4  System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime)
  RVA=0x09D91BF8  token=0x60001C5  System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch)
  RVA=0x09D918F8  token=0x60001C6  System.Void InterruptMatchTarget()
  RVA=0x09D918B4  token=0x60001C7  System.Void InterruptMatchTarget(System.Boolean completeMatch)
  RVA=0x09D90400  token=0x60001CD  System.Void ForceStateNormalizedTime(System.Single normalizedTime)
  RVA=0x09D8FCDC  token=0x60001CE  System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration)
  RVA=0x09D8FAA0  token=0x60001CF  System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer)
  RVA=0x09D8FBAC  token=0x60001D0  System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset)
  RVA=0x09D8FAFC  token=0x60001D1  System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  RVA=0x09D8F9A4  token=0x60001D2  System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  RVA=0x09D8FD2C  token=0x60001D3  System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource, System.Boolean enableBlendRootMotion)
  RVA=0x09D8FA1C  token=0x60001D4  System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  RVA=0x09D8FB6C  token=0x60001D5  System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime)
  RVA=0x09D8FC10  token=0x60001D6  System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset)
  RVA=0x09D8F938  token=0x60001D7  System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer)
  RVA=0x09D8F96C  token=0x60001D8  System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration)
  RVA=0x09D8FC4C  token=0x60001D9  System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  RVA=0x0278DC00  token=0x60001DA  System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  RVA=0x09D8FC98  token=0x60001DB  System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  RVA=0x0278DC50  token=0x60001DC  System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource, System.Boolean enableBlendRootMotion)
  RVA=0x09D933AC  token=0x60001DD  System.Void WriteDefaultValues()
  RVA=0x02D27BF0  token=0x60001DE  System.Void WriteDefaultValuesDirty()
  RVA=0x09D90188  token=0x60001DF  System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime)
  RVA=0x09D8FEA0  token=0x60001E0  System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset)
  RVA=0x09D8FE6C  token=0x60001E1  System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer)
  RVA=0x09D90100  token=0x60001E2  System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration)
  RVA=0x09D901C4  token=0x60001E3  System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource, System.Boolean enableBlendRootMotion)
  RVA=0x09D8FDB0  token=0x60001E4  System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  RVA=0x09D90004  token=0x60001E5  System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  RVA=0x09D9007C  token=0x60001E6  System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  RVA=0x09D8FF64  token=0x60001E7  System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource, System.Boolean enableBlendRootMotion)
  RVA=0x09D8FED8  token=0x60001E8  System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime)
  RVA=0x09D90248  token=0x60001E9  System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset)
  RVA=0x09D8FE30  token=0x60001EA  System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer)
  RVA=0x09D8FFC4  token=0x60001EB  System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration)
  RVA=0x09D9013C  token=0x60001EC  System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  RVA=0x09D8FF18  token=0x60001ED  System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  RVA=0x09D90284  token=0x60001EE  System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  RVA=0x03CB7F70  token=0x60001EF  System.Void ResetToDefaultStates()
  RVA=0x09D91D7C  token=0x60001F0  System.Void PlayInFixedTime(System.String stateName, System.Int32 layer)
  RVA=0x09D91D04  token=0x60001F1  System.Void PlayInFixedTime(System.String stateName)
  RVA=0x09D91D2C  token=0x60001F2  System.Void PlayInFixedTime(System.String stateName, System.Int32 layer, System.Single fixedTime)
  RVA=0x09D91D9C  token=0x60001F3  System.Void PlayInFixedTime(System.Int32 stateNameHash, System.Int32 layer, System.Single fixedTime)
  RVA=0x09D91CE4  token=0x60001F4  System.Void PlayInFixedTime(System.Int32 stateNameHash, System.Int32 layer)
  RVA=0x09D91DFC  token=0x60001F5  System.Void PlayInFixedTime(System.Int32 stateNameHash)
  RVA=0x09D91E24  token=0x60001F6  System.Void Play(System.String stateName, System.Int32 layer)
  RVA=0x0285CE40  token=0x60001F7  System.Void Play(System.String stateName)
  RVA=0x0285D3C0  token=0x60001F8  System.Void Play(System.String stateName, System.Int32 layer, System.Single normalizedTime)
  RVA=0x0285D410  token=0x60001F9  System.Void Play(System.Int32 stateNameHash, System.Int32 layer, System.Single normalizedTime)
  RVA=0x09D91E44  token=0x60001FA  System.Void Play(System.Int32 stateNameHash, System.Int32 layer)
  RVA=0x09D91E64  token=0x60001FB  System.Void Play(System.Int32 stateNameHash)
  RVA=0x09D93170  token=0x60001FC  System.Void SetTarget(UnityEngine.AvatarTarget targetIndex, System.Single targetNormalizedTime)
  RVA=0x03D4E3A0  token=0x60001FF  System.Boolean IsControlled(UnityEngine.Transform transform)
  RVA=0x09D91904  token=0x6000200  System.Boolean IsBoneTransform(UnityEngine.Transform transform)
  RVA=0x09D90A28  token=0x6000202  UnityEngine.Transform GetBoneTransform(UnityEngine.HumanBodyBones humanBoneId)
  RVA=0x09D909E8  token=0x6000203  UnityEngine.Transform GetBoneTransformInternal(System.Int32 humanBoneId)
  RVA=0x029F0300  token=0x6000204  UnityEngine.Transform GetBoneTransformByBoneId(System.Int32 boneID)
  RVA=0x029F02B0  token=0x6000205  UnityEngine.Transform GetBoneTransformByBoneIdInternal(System.Int32 boneId)
  RVA=0x09D93214  token=0x6000208  System.Void StartPlayback()
  RVA=0x09D93288  token=0x6000209  System.Void StopPlayback()
  RVA=0x09D93248  token=0x600020C  System.Void StartRecording(System.Int32 frameCount)
  RVA=0x09D932BC  token=0x600020D  System.Void StopRecording()
  RVA=0x09D914E8  token=0x6000210  System.Single GetRecorderStartTime()
  RVA=0x09D9151C  token=0x6000213  System.Single GetRecorderStopTime()
  RVA=0x09D8F730  token=0x6000218  System.Void ClearInternalControllerPlayable()
  RVA=0x02F496D0  token=0x6000219  System.Boolean HasState(System.Int32 layerIndex, System.Int32 stateID)
  RVA=0x0291C100  token=0x600021A  System.Int32 StringToHash(System.String name)
  RVA=0x09D932F0  token=0x600021B  System.Int32 StringToHashCRC32(System.IntPtr name)
  RVA=0x09D91584  token=0x6000224  System.String GetStats()
  RVA=0x09D90CB8  token=0x6000226  System.Void GetCurrentGraph(UnityEngine.Playables.PlayableGraph& graph)
  RVA=0x09D8F68C  token=0x6000227  System.Void CheckIfInIKPass()
  RVA=0x09D9197C  token=0x6000228  System.Boolean IsInIKPass()
  RVA=0x030FDBE0  token=0x6000229  System.Void SetFloatString(System.String name, System.Single value)
  RVA=0x02EECE10  token=0x600022A  System.Void SetFloatID(System.Int32 id, System.Single value)
  RVA=0x03300150  token=0x600022B  System.Single GetFloatString(System.String name)
  RVA=0x02D85B80  token=0x600022C  System.Single GetFloatID(System.Int32 id)
  RVA=0x09D90DFC  token=0x600022D  System.Single GetFloatFromTransitionByID(System.Int32 layerIndex, System.Int32 id)
  RVA=0x036C6D20  token=0x600022E  System.Single GetFloatFromTransitionByIDWithDefault(System.Int32 layerIndex, System.Int32 id, System.Single defValue)
  RVA=0x038D1DC0  token=0x600022F  System.Void SetBoolString(System.String name, System.Boolean value)
  RVA=0x0349AD90  token=0x6000230  System.Void SetBoolID(System.Int32 id, System.Boolean value)
  RVA=0x09D90AF0  token=0x6000231  System.Boolean GetBoolString(System.String name)
  RVA=0x032DA0C0  token=0x6000232  System.Boolean GetBoolID(System.Int32 id)
  RVA=0x09D92B38  token=0x6000233  System.Void SetIntegerString(System.String name, System.Int32 value)
  RVA=0x03856710  token=0x6000234  System.Void SetIntegerID(System.Int32 id, System.Int32 value)
  RVA=0x09D91274  token=0x6000235  System.Int32 GetIntegerString(System.String name)
  RVA=0x032707D0  token=0x6000236  System.Int32 GetIntegerID(System.Int32 id)
  RVA=0x03495FC0  token=0x6000237  System.Void SetTriggerString(System.String name)
  RVA=0x038E93C0  token=0x6000238  System.Void SetTriggerID(System.Int32 id)
  RVA=0x03295E30  token=0x6000239  System.Void ResetTriggerString(System.String name)
  RVA=0x02E97050  token=0x600023A  System.Void ResetTriggerID(System.Int32 id)
  RVA=0x09D919F0  token=0x600023B  System.Boolean IsParameterControlledByCurveString(System.String name)
  RVA=0x09D919B0  token=0x600023C  System.Boolean IsParameterControlledByCurveID(System.Int32 id)
  RVA=0x09D926E8  token=0x600023D  System.Void SetFloatStringDamp(System.String name, System.Single value, System.Single dampTime, System.Single deltaTime)
  RVA=0x09D92688  token=0x600023E  System.Void SetFloatIDDamp(System.Int32 id, System.Single value, System.Single dampTime, System.Single deltaTime)
  RVA=0x09D90FD8  token=0x600023F  UnityEngine.HGAnimParameterSGHandle[] GetHGParameterHandles()
  RVA=0x09D8F658  token=0x6000240  System.Boolean CheckHGParmeterHandleValid()
  RVA=0x09D91344  token=0x6000243  System.Int32 GetMorphBoneCount()
  RVA=0x09D913CC  token=0x6000244  System.Void GetMorphBoneIds(Unity.Collections.NativeArray<System.Int32> arrayToFill)
  RVA=0x09D91378  token=0x6000245  System.Void GetMorphBoneIdsUnsafe(System.Int32 count, Unity.Collections.NativeArray<System.Int32> arrayToFill)
  RVA=0x09D91804  token=0x6000246  System.Void Internal_GetMorphBoneIds(System.Int32 count, System.IntPtr arrayToFill)
  RVA=0x09D93048  token=0x6000247  System.Void SetMorphTransforms(Unity.Collections.NativeArray<System.Int32> boneIds, Unity.Collections.NativeArray<UnityEngine.Vector3> translation, Unity.Collections.NativeArray<UnityEngine.Vector3> euler, Unity.Collections.NativeArray<UnityEngine.Vector3> scale)
  RVA=0x09D92F4C  token=0x6000248  System.Void SetMorphTransformsUnsafe(Unity.Collections.NativeArray<System.Int32> boneIds, Unity.Collections.NativeArray<UnityEngine.Vector3> translation, Unity.Collections.NativeArray<UnityEngine.Vector3> euler, Unity.Collections.NativeArray<UnityEngine.Vector3> scale)
  RVA=0x09D91854  token=0x6000249  System.Void Internal_SetMorphTransforms(System.Int32 count, System.IntPtr boneIds, System.IntPtr translation, System.IntPtr euler, System.IntPtr scale)
  RVA=0x09D91CB0  token=0x600024F  System.Void OnUpdateModeChanged()
  RVA=0x09D91C7C  token=0x6000250  System.Void OnCullingModeChanged()
  RVA=0x09D93378  token=0x6000251  System.Void WriteDefaultPose()
  RVA=0x033D4680  token=0x6000252  System.Void Update(System.Single deltaTime)
  RVA=0x09D90454  token=0x6000253  System.Void ForceUpdate(System.Single deltaTime)
  RVA=0x09D91EC0  token=0x6000254  System.Void Rebind()
  RVA=0x03D00B20  token=0x6000255  System.Void Rebind(System.Boolean writeDefaultValues)
  RVA=0x09D8F5F0  token=0x6000256  System.Void ApplyBuiltinRootMotion()
  RVA=0x09D903F4  token=0x6000257  System.Void EvaluateController()
  RVA=0x09D903B0  token=0x6000258  System.Void EvaluateController(System.Single deltaTime)
  RVA=0x09D90D30  token=0x6000259  System.String GetCurrentStateName(System.Int32 layerIndex)
  RVA=0x09D914B8  token=0x600025A  System.String GetNextStateName(System.Int32 layerIndex)
  RVA=0x09D9058C  token=0x600025B  System.String GetAnimatorStateName(System.Int32 layerIndex, System.Boolean current)
  RVA=0x09D91F4C  token=0x600025C  System.String ResolveHash(System.Int32 hash)
  RVA=0x09D90580  token=0x600025D  System.String GetAnimatorStateName(System.Int32 stateID)
  RVA=0x04276254  token=0x600025E  System.Void GotoState(System.Int32 layer, System.Int32 stateId, System.Single normalizedTime, System.Single transitionDuration, System.Single transitionTime, UnityEngine.AnimationBlendStyle blendStyle)
  RVA=0x04270040  token=0x600025F  System.Void GotoStateInFixedTime(System.Int32 layerIndex, System.Int32 stateId, System.Single fixedTime, System.Single fixedTransitionDuration, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle)
  RVA=0x04274798  token=0x6000260  System.Void SetAnimationStateOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride, System.Boolean rebind)
  RVA=0x04270038  token=0x6000261  System.Void RefreshStateOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride)
  RVA=0x04272C58  token=0x6000262  System.Void SetRuntimeControllerNoRebind(UnityEngine.RuntimeAnimatorController controller)
  RVA=0x09D91ECC  token=0x6000263  System.Void RefreshAnimationStateAsyncCompleteOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride)
  RVA=0x03C8F890  token=0x6000264  System.Void Internal_GotoState(System.Int32 layer, System.Int32 stateId, System.Single normalizedTime, System.Single transitionDuration, System.Single transitionTime, UnityEngine.AnimationBlendStyle blendStyle)
  RVA=0x03C8F900  token=0x6000265  System.Void Internal_GotoStateInFixedTime(System.Int32 layerIndex, System.Int32 stateId, System.Single fixedTime, System.Single fixedTransitionDuration, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle)
  RVA=0x039CF8F0  token=0x6000266  System.Void Internal_SetAnimationStateOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride, System.Boolean rebind)
  RVA=0x03CA4370  token=0x6000267  System.Void Internal_RefreshAnimationStateOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride)
  RVA=0x03CA4320  token=0x6000268  System.Void Internal_SetRuntimeControllerNoRebind(UnityEngine.RuntimeAnimatorController controller)
  RVA=0x03B13590  token=0x6000269  System.Void Internal_RefreshAnimationStateAsyncCompleteOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride)
  RVA=0x04275140  token=0x600026A  System.Void SetAvatarNoBind(UnityEngine.Avatar avatar)
  RVA=0x03626660  token=0x600026B  System.Void Internal_SetAvatarNoBind(UnityEngine.Avatar avatar)
  RVA=0x03D86AF0  token=0x6000276  UnityEngine.Vector3 GetVector(System.String name)
  RVA=0x03D86AF0  token=0x6000277  UnityEngine.Vector3 GetVector(System.Int32 id)
  RVA=0x0350B670  token=0x6000278  System.Void SetVector(System.String name, UnityEngine.Vector3 value)
  RVA=0x0350B670  token=0x6000279  System.Void SetVector(System.Int32 id, UnityEngine.Vector3 value)
  RVA=0x09D914C8  token=0x600027A  UnityEngine.Quaternion GetQuaternion(System.String name)
  RVA=0x09D914C8  token=0x600027B  UnityEngine.Quaternion GetQuaternion(System.Int32 id)
  RVA=0x0350B670  token=0x600027C  System.Void SetQuaternion(System.String name, UnityEngine.Quaternion value)
  RVA=0x0350B670  token=0x600027D  System.Void SetQuaternion(System.Int32 id, UnityEngine.Quaternion value)
  RVA=0x02D664F0  token=0x600027E  System.Void get_deltaPosition_Injected(UnityEngine.Vector3& ret)
  RVA=0x031DEB90  token=0x600027F  System.Void get_deltaRotation_Injected(UnityEngine.Quaternion& ret)
  RVA=0x02D66390  token=0x6000280  System.Void get_velocity_Injected(UnityEngine.Vector3& ret)
  RVA=0x02D66440  token=0x6000281  System.Void get_angularVelocity_Injected(UnityEngine.Vector3& ret)
  RVA=0x09D93D6C  token=0x6000282  System.Void get_rootPosition_Injected(UnityEngine.Vector3& ret)
  RVA=0x09D94590  token=0x6000283  System.Void set_rootPosition_Injected(UnityEngine.Vector3& value)
  RVA=0x09D93DDC  token=0x6000284  System.Void get_rootRotation_Injected(UnityEngine.Quaternion& ret)
  RVA=0x09D945E8  token=0x6000285  System.Void set_rootRotation_Injected(UnityEngine.Quaternion& value)
  RVA=0x09D93514  token=0x6000286  System.Void get_bodyPositionInternal_Injected(UnityEngine.Vector3& ret)
  RVA=0x09D940E8  token=0x6000287  System.Void set_bodyPositionInternal_Injected(UnityEngine.Vector3& value)
  RVA=0x09D935D4  token=0x6000288  System.Void get_bodyRotationInternal_Injected(UnityEngine.Quaternion& ret)
  RVA=0x09D94184  token=0x6000289  System.Void set_bodyRotationInternal_Injected(UnityEngine.Quaternion& value)
  RVA=0x09D90E58  token=0x600028A  System.Void GetGoalPosition_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3& ret)
  RVA=0x09D9276C  token=0x600028B  System.Void SetGoalPosition_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3& goalPosition)
  RVA=0x09D90ED8  token=0x600028C  System.Void GetGoalRotation_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion& ret)
  RVA=0x09D927D0  token=0x600028D  System.Void SetGoalRotation_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion& goalRotation)
  RVA=0x09D9100C  token=0x600028E  System.Void GetHintPosition_Injected(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3& ret)
  RVA=0x09D928D4  token=0x600028F  System.Void SetHintPosition_Injected(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3& hintPosition)
  RVA=0x09D92BE8  token=0x6000290  System.Void SetLookAtPositionInternal_Injected(UnityEngine.Vector3& lookAtPosition)
  RVA=0x09D92164  token=0x6000291  System.Void SetBoneLocalRotationInternal_Injected(System.Int32 humanBoneId, UnityEngine.Quaternion& rotation)
  RVA=0x09D90918  token=0x6000292  System.Void GetBoneRootTRSInternal_Injected(System.Int32 avatarAssetBoneID, UnityEngine.AnimationTransformf& ret)
  RVA=0x09D90848  token=0x6000293  System.Void GetBoneLocalTRSInternal_Injected(System.Int32 avatarAssetBoneID, UnityEngine.AnimationTransformf& ret)
  RVA=0x09D8F800  token=0x6000294  System.Void CreateClothBindings_Injected(UnityEngine.Transform[] transformAccessArray, UnityEngine.AnimationTransformRWBufferHandle& ret)
  RVA=0x09D8F764  token=0x6000295  System.Void CreateClothBindingsByNameLst_Injected(System.String[] transformPathArray, UnityEngine.AnimationTransformRWBufferHandle& ret)
  RVA=0x02FADCB0  token=0x6000296  System.Void CreateMorphBindings_Injected(UnityEngine.Transform[] transformAccessArray, UnityEngine.AnimationTransformRWBufferHandle& ret)
  RVA=0x09D8F89C  token=0x6000297  System.Void CreateMorphBindingsByNameLst_Injected(System.String[] transformPathArray, UnityEngine.AnimationTransformRWBufferHandle& ret)
  RVA=0x09D93BA8  token=0x6000298  System.Void get_pivotPosition_Injected(UnityEngine.Vector3& ret)
  RVA=0x09D91A4C  token=0x6000299  System.Void MatchTarget_Injected(UnityEngine.Vector3& matchPosition, UnityEngine.Quaternion& matchRotation, System.Int32 targetBodyPart, UnityEngine.MatchTargetWeightMask& weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch)
  RVA=0x09D93EE8  token=0x600029A  System.Void get_targetPosition_Injected(UnityEngine.Vector3& ret)
  RVA=0x09D93F58  token=0x600029B  System.Void get_targetRotation_Injected(UnityEngine.Quaternion& ret)
END_CLASS

CLASS: UnityEngine.AnimatorControllerParameter
TYPE:  class
TOKEN: 0x200002D
SIZE:  0x28
FIELDS:
  private           System.String                   m_Name  // 0x10
  private           UnityEngine.AnimatorControllerParameterTypem_Type  // 0x18
  private           System.Single                   m_DefaultFloat  // 0x1c
  private           System.Int32                    m_DefaultInt  // 0x20
  private           System.Boolean                  m_DefaultBool  // 0x24
PROPERTIES:
  name  get=0x03D66B80
  nameHash  get=0x04274684
  type  get=0x03D68AE0
METHODS:
  RVA=0x09D8E160  token=0x60002A7  System.Boolean Equals(System.Object o)
  RVA=0x06FAB9A8  token=0x60002A8  System.Int32 GetHashCode()
  RVA=0x09D8E1F8  token=0x60002A9  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.AnimationClipPair
TYPE:  class
TOKEN: 0x200002E
SIZE:  0x20
FIELDS:
  public            UnityEngine.AnimationClip       originalClip  // 0x10
  public            UnityEngine.AnimationClip       overrideClip  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60002AA  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.AnimatorOverrideController
TYPE:  class
TOKEN: 0x200002F
SIZE:  0x20
EXTENDS: UnityEngine.RuntimeAnimatorController
FIELDS:
  private           UnityEngine.AnimatorOverrideController.OnOverrideControllerDirtyCallbackOnOverrideControllerDirty  // 0x18
PROPERTIES:
  runtimeAnimatorController  get=0x09D8F350  set=0x09D8F4AC
  Item  get=0x09D8F15C  set=0x09D8F3A0
  Item  get=0x09D8F15C  set=0x09D8F3A0
  enableBindingOpt  get=0x09D8F2B4  set=0x09D8F424
  reserveCount  get=0x09D8F31C  set=0x09D8F468
  overridesCount  get=0x09D8F2E8
  clips  get=0x09D8F16C  set=0x09D8F3A8
METHODS:
  RVA=0x09D8F0D8  token=0x60002AB  System.Void .ctor()
  RVA=0x09D8F10C  token=0x60002AC  System.Void .ctor(UnityEngine.RuntimeAnimatorController controller)
  RVA=0x09D8EEF4  token=0x60002AD  System.Void Internal_Create(UnityEngine.AnimatorOverrideController self, UnityEngine.RuntimeAnimatorController controller)
  RVA=0x09D8EF38  token=0x60002B2  UnityEngine.AnimationClip Internal_GetClipByName(System.String name, System.Boolean returnEffectiveClip)
  RVA=0x09D8EF8C  token=0x60002B3  System.Void Internal_SetClipByName(System.String name, UnityEngine.AnimationClip clip)
  RVA=0x09D8EC98  token=0x60002BA  UnityEngine.AnimationClip GetClip(UnityEngine.AnimationClip originalClip, System.Boolean returnEffectiveClip)
  RVA=0x09D8F074  token=0x60002BB  System.Void SetClip(UnityEngine.AnimationClip originalClip, UnityEngine.AnimationClip overrideClip, System.Boolean notify)
  RVA=0x09D8F040  token=0x60002BC  System.Void SendNotification()
  RVA=0x09D8ECEC  token=0x60002BD  UnityEngine.AnimationClip GetOriginalClip(System.Int32 index)
  RVA=0x09D8ED2C  token=0x60002BE  UnityEngine.AnimationClip GetOverrideClip(UnityEngine.AnimationClip originalClip)
  RVA=0x09D8ED70  token=0x60002C0  System.Void GetOverrides(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides)
  RVA=0x09D8EB6C  token=0x60002C1  System.Void ApplyOverrides(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides)
  RVA=0x09D8F00C  token=0x60002C4  System.Void PerformOverrideClipListCleanup()
  RVA=0x09D8EFE0  token=0x60002C5  System.Void OnInvalidateOverrideController(UnityEngine.AnimatorOverrideController controller)
END_CLASS

CLASS: UnityEngine.AnimatorUtility
TYPE:  class
TOKEN: 0x2000031
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x03627370  token=0x60002C8  System.Void OptimizeTransformHierarchy(UnityEngine.GameObject go, System.String[] exposedTransforms)
  RVA=0x03C7DB90  token=0x60002C9  System.Void DeoptimizeTransformHierarchy(UnityEngine.GameObject go)
END_CLASS

CLASS: UnityEngine.HumanBodyBones
TYPE:  sealed struct
TOKEN: 0x2000032
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HumanBodyBones      Hips  // const
  public    static  UnityEngine.HumanBodyBones      LeftUpperLeg  // const
  public    static  UnityEngine.HumanBodyBones      RightUpperLeg  // const
  public    static  UnityEngine.HumanBodyBones      LeftLowerLeg  // const
  public    static  UnityEngine.HumanBodyBones      RightLowerLeg  // const
  public    static  UnityEngine.HumanBodyBones      LeftFoot  // const
  public    static  UnityEngine.HumanBodyBones      RightFoot  // const
  public    static  UnityEngine.HumanBodyBones      Spine  // const
  public    static  UnityEngine.HumanBodyBones      Chest  // const
  public    static  UnityEngine.HumanBodyBones      UpperChest  // const
  public    static  UnityEngine.HumanBodyBones      Neck  // const
  public    static  UnityEngine.HumanBodyBones      Head  // const
  public    static  UnityEngine.HumanBodyBones      LeftShoulder  // const
  public    static  UnityEngine.HumanBodyBones      RightShoulder  // const
  public    static  UnityEngine.HumanBodyBones      LeftUpperArm  // const
  public    static  UnityEngine.HumanBodyBones      RightUpperArm  // const
  public    static  UnityEngine.HumanBodyBones      LeftLowerArm  // const
  public    static  UnityEngine.HumanBodyBones      RightLowerArm  // const
  public    static  UnityEngine.HumanBodyBones      LeftHand  // const
  public    static  UnityEngine.HumanBodyBones      RightHand  // const
  public    static  UnityEngine.HumanBodyBones      LeftToes  // const
  public    static  UnityEngine.HumanBodyBones      RightToes  // const
  public    static  UnityEngine.HumanBodyBones      LeftEye  // const
  public    static  UnityEngine.HumanBodyBones      RightEye  // const
  public    static  UnityEngine.HumanBodyBones      Jaw  // const
  public    static  UnityEngine.HumanBodyBones      LeftThumbProximal  // const
  public    static  UnityEngine.HumanBodyBones      LeftThumbIntermediate  // const
  public    static  UnityEngine.HumanBodyBones      LeftThumbDistal  // const
  public    static  UnityEngine.HumanBodyBones      LeftIndexProximal  // const
  public    static  UnityEngine.HumanBodyBones      LeftIndexIntermediate  // const
  public    static  UnityEngine.HumanBodyBones      LeftIndexDistal  // const
  public    static  UnityEngine.HumanBodyBones      LeftMiddleProximal  // const
  public    static  UnityEngine.HumanBodyBones      LeftMiddleIntermediate  // const
  public    static  UnityEngine.HumanBodyBones      LeftMiddleDistal  // const
  public    static  UnityEngine.HumanBodyBones      LeftRingProximal  // const
  public    static  UnityEngine.HumanBodyBones      LeftRingIntermediate  // const
  public    static  UnityEngine.HumanBodyBones      LeftRingDistal  // const
  public    static  UnityEngine.HumanBodyBones      LeftLittleProximal  // const
  public    static  UnityEngine.HumanBodyBones      LeftLittleIntermediate  // const
  public    static  UnityEngine.HumanBodyBones      LeftLittleDistal  // const
  public    static  UnityEngine.HumanBodyBones      RightThumbProximal  // const
  public    static  UnityEngine.HumanBodyBones      RightThumbIntermediate  // const
  public    static  UnityEngine.HumanBodyBones      RightThumbDistal  // const
  public    static  UnityEngine.HumanBodyBones      RightIndexProximal  // const
  public    static  UnityEngine.HumanBodyBones      RightIndexIntermediate  // const
  public    static  UnityEngine.HumanBodyBones      RightIndexDistal  // const
  public    static  UnityEngine.HumanBodyBones      RightMiddleProximal  // const
  public    static  UnityEngine.HumanBodyBones      RightMiddleIntermediate  // const
  public    static  UnityEngine.HumanBodyBones      RightMiddleDistal  // const
  public    static  UnityEngine.HumanBodyBones      RightRingProximal  // const
  public    static  UnityEngine.HumanBodyBones      RightRingIntermediate  // const
  public    static  UnityEngine.HumanBodyBones      RightRingDistal  // const
  public    static  UnityEngine.HumanBodyBones      RightLittleProximal  // const
  public    static  UnityEngine.HumanBodyBones      RightLittleIntermediate  // const
  public    static  UnityEngine.HumanBodyBones      RightLittleDistal  // const
  public    static  UnityEngine.HumanBodyBones      LastBone  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AnimationTransformf
TYPE:  sealed struct
TOKEN: 0x2000033
SIZE:  0x38
FIELDS:
  public            UnityEngine.Vector3             t  // 0x10
  public            UnityEngine.Quaternion          q  // 0x1c
  public            UnityEngine.Vector3             s  // 0x2c
METHODS:
END_CLASS

CLASS: UnityEngine.Avatar
TYPE:  class
TOKEN: 0x2000034
SIZE:  0x18
EXTENDS: UnityEngine.Object
FIELDS:
PROPERTIES:
  isValid  get=0x022D5F00
  isHuman  get=0x029F0F10
  humanDescription  get=0x09D94E3C
METHODS:
  RVA=0x09D94DB8  token=0x60002CA  System.Void .ctor()
  RVA=0x09D94D08  token=0x60002CE  System.Void SetMuscleMinMax(System.Int32 muscleId, System.Single min, System.Single max)
  RVA=0x09D94D68  token=0x60002CF  System.Void SetParameter(System.Int32 parameterId, System.Single value)
  RVA=0x09D947D4  token=0x60002D0  System.Single GetAxisLength(System.Int32 humanId)
  RVA=0x09D948CC  token=0x60002D1  UnityEngine.Quaternion GetPreRotation(System.Int32 humanId)
  RVA=0x09D94884  token=0x60002D2  UnityEngine.Quaternion GetPostRotation(System.Int32 humanId)
  RVA=0x09D94914  token=0x60002D3  UnityEngine.Quaternion GetZYPostQ(System.Int32 humanId, UnityEngine.Quaternion parentQ, UnityEngine.Quaternion q)
  RVA=0x09D94998  token=0x60002D4  UnityEngine.Quaternion GetZYRoll(System.Int32 humanId, UnityEngine.Vector3 uvw)
  RVA=0x09D94830  token=0x60002D5  UnityEngine.Vector3 GetLimitSign(System.Int32 humanId)
  RVA=0x09D94A08  token=0x60002D6  System.Single Internal_GetAxisLength(System.Int32 humanId)
  RVA=0x09D94B98  token=0x60002D7  UnityEngine.Quaternion Internal_GetPreRotation(System.Int32 humanId)
  RVA=0x09D94B18  token=0x60002D8  UnityEngine.Quaternion Internal_GetPostRotation(System.Int32 humanId)
  RVA=0x09D94C28  token=0x60002D9  UnityEngine.Quaternion Internal_GetZYPostQ(System.Int32 humanId, UnityEngine.Quaternion parentQ, UnityEngine.Quaternion q)
  RVA=0x09D94CCC  token=0x60002DA  UnityEngine.Quaternion Internal_GetZYRoll(System.Int32 humanId, UnityEngine.Vector3 uvw)
  RVA=0x09D94A98  token=0x60002DB  UnityEngine.Vector3 Internal_GetLimitSign(System.Int32 humanId)
  RVA=0x09D947FC  token=0x60002DC  System.String[] GetBonePaths()
  RVA=0x09D94DF8  token=0x60002DD  System.Void get_humanDescription_Injected(UnityEngine.HumanDescription& ret)
  RVA=0x09D94B48  token=0x60002DE  System.Void Internal_GetPreRotation_Injected(System.Int32 humanId, UnityEngine.Quaternion& ret)
  RVA=0x09D94AC8  token=0x60002DF  System.Void Internal_GetPostRotation_Injected(System.Int32 humanId, UnityEngine.Quaternion& ret)
  RVA=0x09D94BC8  token=0x60002E0  System.Void Internal_GetZYPostQ_Injected(System.Int32 humanId, UnityEngine.Quaternion& parentQ, UnityEngine.Quaternion& q, UnityEngine.Quaternion& ret)
  RVA=0x09D94C6C  token=0x60002E1  System.Void Internal_GetZYRoll_Injected(System.Int32 humanId, UnityEngine.Vector3& uvw, UnityEngine.Quaternion& ret)
  RVA=0x09D94A48  token=0x60002E2  System.Void Internal_GetLimitSign_Injected(System.Int32 humanId, UnityEngine.Vector3& ret)
END_CLASS

CLASS: UnityEngine.SkeletonBone
TYPE:  sealed struct
TOKEN: 0x2000035
SIZE:  0x48
FIELDS:
  public            System.String                   name  // 0x10
  private           System.String                   parentName  // 0x18
  public            UnityEngine.Vector3             position  // 0x20
  public            UnityEngine.Quaternion          rotation  // 0x2c
  public            UnityEngine.Vector3             scale  // 0x3c
METHODS:
END_CLASS

CLASS: UnityEngine.HumanLimit
TYPE:  sealed struct
TOKEN: 0x2000036
SIZE:  0x3C
FIELDS:
  private           UnityEngine.Vector3             m_Min  // 0x10
  private           UnityEngine.Vector3             m_Max  // 0x1c
  private           UnityEngine.Vector3             m_Center  // 0x28
  private           System.Single                   m_AxisLength  // 0x34
  private           System.Int32                    m_UseDefaultValues  // 0x38
METHODS:
END_CLASS

CLASS: UnityEngine.HumanBone
TYPE:  sealed struct
TOKEN: 0x2000037
SIZE:  0x50
FIELDS:
  private           System.String                   m_BoneName  // 0x10
  private           System.String                   m_HumanName  // 0x18
  public            UnityEngine.HumanLimit          limit  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HumanDescription
TYPE:  sealed struct
TOKEN: 0x2000038
SIZE:  0x50
FIELDS:
  public            UnityEngine.HumanBone[]         human  // 0x10
  public            UnityEngine.SkeletonBone[]      skeleton  // 0x18
  private           System.Single                   m_ArmTwist  // 0x20
  private           System.Single                   m_ForeArmTwist  // 0x24
  private           System.Single                   m_UpperLegTwist  // 0x28
  private           System.Single                   m_LegTwist  // 0x2c
  private           System.Single                   m_ArmStretch  // 0x30
  private           System.Single                   m_LegStretch  // 0x34
  private           System.Single                   m_FeetSpacing  // 0x38
  private           System.Single                   m_GlobalScale  // 0x3c
  private           System.String                   m_RootMotionBoneName  // 0x40
  private           System.Boolean                  m_HasTranslationDoF  // 0x48
  private           System.Boolean                  m_HasExtraRoot  // 0x49
  private           System.Boolean                  m_SkeletonHasParents  // 0x4a
METHODS:
END_CLASS

CLASS: UnityEngine.AvatarMaskBodyPart
TYPE:  sealed struct
TOKEN: 0x2000039
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AvatarMaskBodyPart  Root  // const
  public    static  UnityEngine.AvatarMaskBodyPart  Body  // const
  public    static  UnityEngine.AvatarMaskBodyPart  Head  // const
  public    static  UnityEngine.AvatarMaskBodyPart  LeftLeg  // const
  public    static  UnityEngine.AvatarMaskBodyPart  RightLeg  // const
  public    static  UnityEngine.AvatarMaskBodyPart  LeftArm  // const
  public    static  UnityEngine.AvatarMaskBodyPart  RightArm  // const
  public    static  UnityEngine.AvatarMaskBodyPart  LeftFingers  // const
  public    static  UnityEngine.AvatarMaskBodyPart  RightFingers  // const
  public    static  UnityEngine.AvatarMaskBodyPart  LeftFootIK  // const
  public    static  UnityEngine.AvatarMaskBodyPart  RightFootIK  // const
  public    static  UnityEngine.AvatarMaskBodyPart  LeftHandIK  // const
  public    static  UnityEngine.AvatarMaskBodyPart  RightHandIK  // const
  public    static  UnityEngine.AvatarMaskBodyPart  LastBodyPart  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AvatarMask
TYPE:  sealed class
TOKEN: 0x200003A
SIZE:  0x18
EXTENDS: UnityEngine.Object
FIELDS:
PROPERTIES:
  transformCount  get=0x09D947A0
METHODS:
  RVA=0x09D946C4  token=0x60002E3  System.Boolean GetHumanoidBodyPartActive(UnityEngine.AvatarMaskBodyPart index)
  RVA=0x09D94720  token=0x60002E5  System.String GetTransformPath(System.Int32 index)
  RVA=0x09D94760  token=0x60002E6  System.Single GetTransformWeight(System.Int32 index)
  RVA=0x09D94704  token=0x60002E7  System.Boolean GetTransformActive(System.Int32 index)
END_CLASS

CLASS: UnityEngine.HGAnimationSetBindings
TYPE:  class
TOKEN: 0x200003B
SIZE:  0x18
EXTENDS: UnityEngine.Object
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.HGCorrectiveBoneData
TYPE:  class
TOKEN: 0x200003C
SIZE:  0x18
EXTENDS: UnityEngine.Object
FIELDS:
METHODS:
  RVA=0x09D94EA8  token=0x60002E8  System.Void .ctor()
  RVA=0x09D94E74  token=0x60002E9  System.Void Internal_Create(UnityEngine.HGCorrectiveBoneData self)
END_CLASS

CLASS: UnityEngine.HGSkeletalMorphAvatar
TYPE:  sealed class
TOKEN: 0x200003D
SIZE:  0x18
EXTENDS: UnityEngine.Object
FIELDS:
METHODS:
  RVA=0x09D94F28  token=0x60002EA  System.Void .ctor()
  RVA=0x09D94EF4  token=0x60002EB  System.Void Internal_Create(UnityEngine.HGSkeletalMorphAvatar self)
END_CLASS

CLASS: UnityEngine.HumanPose
TYPE:  sealed struct
TOKEN: 0x200003E
SIZE:  0x38
FIELDS:
  public            UnityEngine.Vector3             bodyPosition  // 0x10
  public            UnityEngine.Quaternion          bodyRotation  // 0x1c
  public            System.Single[]                 muscles  // 0x30
METHODS:
  RVA=0x09D95350  token=0x60002EC  System.Void Init()
END_CLASS

CLASS: UnityEngine.HumanPoseHandler
TYPE:  class
TOKEN: 0x200003F
SIZE:  0x18
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  RVA=0x09D950CC  token=0x60002ED  System.IntPtr Internal_CreateFromRoot(UnityEngine.Avatar avatar, UnityEngine.Transform root)
  RVA=0x09D95110  token=0x60002EE  System.Void Internal_Destroy(System.IntPtr ptr)
  RVA=0x09D94FCC  token=0x60002EF  System.Void GetHumanPose(UnityEngine.Vector3& bodyPosition, UnityEngine.Quaternion& bodyRotation, System.Single[] muscles)
  RVA=0x09D94F74  token=0x60002F0  System.Void Dispose()
  RVA=0x09D95144  token=0x60002F1  System.Void .ctor(UnityEngine.Avatar avatar, UnityEngine.Transform root)
  RVA=0x09D95030  token=0x60002F2  System.Void GetHumanPose(UnityEngine.HumanPose& humanPose)
END_CLASS

CLASS: UnityEngine.HumanTrait
TYPE:  class
TOKEN: 0x2000040
SIZE:  0x10
FIELDS:
PROPERTIES:
  MuscleCount  get=0x09D95488
  MuscleName  get=0x09D954B4
METHODS:
  RVA=0x09D95454  token=0x60002F4  System.Int32 GetBoneIndexFromMono(System.Int32 humanId)
END_CLASS

CLASS: UnityEngine.LodBoneMask
TYPE:  class
TOKEN: 0x2000041
SIZE:  0x18
EXTENDS: UnityEngine.Object
FIELDS:
METHODS:
  RVA=0x09D95514  token=0x60002F6  System.Void .ctor()
  RVA=0x09D954E0  token=0x60002F7  System.Void Internal_Create(UnityEngine.LodBoneMask self)
END_CLASS

CLASS: UnityEngine.Motion
TYPE:  class
TOKEN: 0x2000042
SIZE:  0x20
EXTENDS: UnityEngine.Object
FIELDS:
  private   readonly System.Boolean                  <isAnimatorMotion>k__BackingField  // 0x18
PROPERTIES:
  isLooping  get=0x02966620
METHODS:
  RVA=0x033570F0  token=0x60002F8  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.RuntimeAnimatorController
TYPE:  class
TOKEN: 0x2000043
SIZE:  0x18
EXTENDS: UnityEngine.Object
FIELDS:
PROPERTIES:
  animationClips  get=0x03CB7F30
METHODS:
  RVA=0x09D95D30  token=0x60002FA  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.RuntimeAnimatorStateOverride
TYPE:  class
TOKEN: 0x2000044
SIZE:  0x18
EXTENDS: UnityEngine.Object
FIELDS:
METHODS:
  RVA=0x02F49AE0  token=0x60002FC  System.Void .ctor()
  RVA=0x02F49B30  token=0x60002FD  System.Void Internal_Create(UnityEngine.RuntimeAnimatorStateOverride self)
  RVA=0x04276BA0  token=0x60002FE  System.Void SetClip(System.Int32 stateID, UnityEngine.AnimationClip overrideClip)
  RVA=0x04276BA8  token=0x60002FF  System.Void SetClipAsync(System.Int32 stateID, System.Single length, System.Boolean isHumanoid)
  RVA=0x09D95DF0  token=0x6000300  System.Void RemoveClip(System.Int32 stateID)
  RVA=0x04272C60  token=0x6000301  System.Void ClearClip()
  RVA=0x0427616C  token=0x6000302  System.Boolean PreloadClip(UnityEngine.AnimationClip clipB)
  RVA=0x04276BDC  token=0x6000303  System.Void SetTransition(System.Int32 transUserNameID, System.Single transitionDuration, System.Single transitionOffset, System.Single exitTime)
  RVA=0x09D95DF8  token=0x6000304  System.Void RemoveTransition(System.Int32 transUserNameID)
  RVA=0x042747A0  token=0x6000305  System.Void SetSyncGroupCurve(System.UInt32 clipNameID, UnityEngine.AnimationCurve curve)
  RVA=0x038E48A0  token=0x6000306  System.Void Internal_SetClip(System.UInt32 stateID, UnityEngine.AnimationClip overrideClip)
  RVA=0x03CFFD20  token=0x6000307  System.Void Internal_SetClipAsync(System.UInt32 stateID, System.Single length, System.Boolean isHumanoid)
  RVA=0x09D95D70  token=0x6000308  System.Void Internal_RemoveClip(System.UInt32 stateID)
  RVA=0x03D27550  token=0x6000309  System.Void Internal_ClearClip()
  RVA=0x03871DB0  token=0x600030A  System.Boolean Internal_PreloadClip(UnityEngine.AnimationClip clipB)
  RVA=0x03A09540  token=0x600030B  System.Void Internal_SetTransition(System.UInt32 transUserNameID, System.Single transitionDuration, System.Single transitionOffset, System.Single exitTime)
  RVA=0x09D95DB0  token=0x600030C  System.Void Internal_RemoveTransition(System.UInt32 transUserNameID)
  RVA=0x033D9170  token=0x600030D  System.Void Internal_SetSyncGroupCurve(System.UInt32 clipNameID, UnityEngine.AnimationCurve curve)
END_CLASS

CLASS: UnityEngine.Animations.AnimationPlayableBinding
TYPE:  static class
TOKEN: 0x2000047
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09D8C044  token=0x6000314  UnityEngine.Playables.PlayableBinding Create(System.String name, UnityEngine.Object key)
  RVA=0x09D8C004  token=0x6000315  UnityEngine.Playables.PlayableOutput CreateAnimationOutput(UnityEngine.Playables.PlayableGraph graph, System.String name)
END_CLASS

CLASS: UnityEngine.Animations.DiscreteEvaluationAttribute
TYPE:  class
TOKEN: 0x2000048
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.IAnimationJob
TYPE:  interface
TOKEN: 0x2000049
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x6000316  System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
  RVA=-1  // abstract  token=0x6000317  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
END_CLASS

CLASS: UnityEngine.Animations.IAnimationWindowPreview
TYPE:  interface
TOKEN: 0x200004A
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.NotKeyableAttribute
TYPE:  class
TOKEN: 0x200004B
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000318  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.JobMethodIndex
TYPE:  sealed struct
TOKEN: 0x200004C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Animations.JobMethodIndexProcessRootMotionMethodIndex  // const
  public    static  UnityEngine.Animations.JobMethodIndexProcessAnimationMethodIndex  // const
  public    static  UnityEngine.Animations.JobMethodIndexMethodIndexCount  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.ProcessAnimationJobStruct`1
TYPE:  sealed struct
TOKEN: 0x200004D
SIZE:  0x11
FIELDS:
  private   static  System.IntPtr                   jobReflectionData  // static @ 0x0
METHODS:
  RVA=-1  // not resolved  token=0x6000319  System.IntPtr GetJobReflectionData()
  RVA=-1  // not resolved  token=0x600031A  System.Void Execute(T& data, System.IntPtr animationStreamPtr, System.IntPtr methodIndex, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
END_CLASS

CLASS: UnityEngine.Animations.AdvancedAnimationMixerPlayable
TYPE:  sealed struct
TOKEN: 0x200004F
SIZE:  0x20
IMPLEMENTS: UnityEngine.Playables.IPlayable System.IEquatable`1
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AdvancedAnimationMixerPlayablem_NullPlayable  // static @ 0x0
METHODS:
  RVA=0x03326790  token=0x600031D  UnityEngine.Animations.AdvancedAnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  RVA=0x03326840  token=0x600031E  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  RVA=0x03326A70  token=0x600031F  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  RVA=0x03D695A0  token=0x6000320  UnityEngine.Playables.PlayableHandle GetHandle()
  RVA=0x09D89F48  token=0x6000321  System.Boolean Equals(UnityEngine.Animations.AdvancedAnimationMixerPlayable other)
  RVA=0x033269C0  token=0x6000322  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle)
  RVA=0x03326700  token=0x6000323  System.Void .cctor()
  RVA=0x03326A20  token=0x6000324  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.AnimationClipPlayable
TYPE:  sealed struct
TOKEN: 0x2000050
SIZE:  0x20
IMPLEMENTS: UnityEngine.Playables.IPlayable System.IEquatable`1
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
METHODS:
  RVA=0x02809460  token=0x6000325  UnityEngine.Animations.AnimationClipPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip)
  RVA=0x02809590  token=0x6000326  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip)
  RVA=0x02809720  token=0x6000327  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  RVA=0x03D695A0  token=0x6000328  UnityEngine.Playables.PlayableHandle GetHandle()
  RVA=0x03D85A00  token=0x6000329  UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationClipPlayable playable)
  RVA=0x09D8A204  token=0x600032A  UnityEngine.Animations.AnimationClipPlayable op_Explicit(UnityEngine.Playables.Playable playable)
  RVA=0x09D89FD4  token=0x600032B  System.Boolean Equals(UnityEngine.Animations.AnimationClipPlayable other)
  RVA=0x0426FA88  token=0x600032C  UnityEngine.AnimationClip GetAnimationClip()
  RVA=0x09D8A07C  token=0x600032D  System.Single GetAnimationClipPlayableLengthUncheck()
  RVA=0x0427467C  token=0x600032E  System.Void SetAnimationClip(UnityEngine.AnimationClip clip)
  RVA=0x042751B0  token=0x600032F  System.Void SetAnimationClipAsync(System.Single length, System.Boolean isHumanoid)
  RVA=0x09D8A0CC  token=0x6000330  System.Void SetApplyFootIK(System.Boolean value)
  RVA=0x09D8A118  token=0x6000331  System.Void SetApplyPlayableIK(System.Boolean value)
  RVA=0x09D8A1FC  token=0x6000332  System.Void SetRemoveStartOffset(System.Boolean value)
  RVA=0x09D8A1B0  token=0x6000333  System.Void SetOverrideLoopTime(System.Boolean value)
  RVA=0x09D8A164  token=0x6000334  System.Void SetLoopTime(System.Boolean value)
  RVA=0x04271BAC  token=0x6000335  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, UnityEngine.Playables.PlayableHandle& handle)
  RVA=0x03027760  token=0x6000336  UnityEngine.AnimationClip GetAnimationClipInternal(UnityEngine.Playables.PlayableHandle& handle)
  RVA=0x036BF110  token=0x6000337  System.Void SetAnimationClipInternal(UnityEngine.Playables.PlayableHandle& handle, UnityEngine.AnimationClip clip)
  RVA=0x03C7B990  token=0x6000338  System.Void SetAnimationClipAsyncInternal(UnityEngine.Playables.PlayableHandle& handle, System.Single length, System.Boolean isHumanoid)
  RVA=0x09D8A088  token=0x6000339  System.Void SetApplyFootIKInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
  RVA=0x09D8A0D4  token=0x600033A  System.Void SetApplyPlayableIKInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
  RVA=0x09D8A1B8  token=0x600033B  System.Void SetRemoveStartOffsetInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
  RVA=0x09D8A16C  token=0x600033C  System.Void SetOverrideLoopTimeInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
  RVA=0x09D8A120  token=0x600033D  System.Void SetLoopTimeInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
  RVA=0x09D8A048  token=0x600033E  System.Single GetAnimationClipPlayableLengthInternalUncheck(UnityEngine.Playables.PlayableHandle& handle)
  RVA=0x0332D860  token=0x600033F  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.AnimationClip clip, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.AnimationHumanStream
TYPE:  sealed struct
TOKEN: 0x2000051
SIZE:  0x18
FIELDS:
  private           System.IntPtr                   stream  // 0x10
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.AnimationLayerMixerPlayable
TYPE:  sealed struct
TOKEN: 0x2000052
SIZE:  0x20
IMPLEMENTS: UnityEngine.Playables.IPlayable System.IEquatable`1
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AnimationLayerMixerPlayablem_NullPlayable  // static @ 0x0
PROPERTIES:
  Null  get=0x09D8B37C
METHODS:
  RVA=0x02967A80  token=0x6000341  UnityEngine.Animations.AnimationLayerMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  RVA=0x02967B20  token=0x6000342  UnityEngine.Animations.AnimationLayerMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount, System.Boolean singleLayerOptimization)
  RVA=0x02967BF0  token=0x6000343  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  RVA=0x02967E20  token=0x6000344  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle, System.Boolean singleLayerOptimization)
  RVA=0x03D695A0  token=0x6000345  UnityEngine.Playables.PlayableHandle GetHandle()
  RVA=0x09D8B450  token=0x6000346  UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationLayerMixerPlayable playable)
  RVA=0x09D8B3D4  token=0x6000347  UnityEngine.Animations.AnimationLayerMixerPlayable op_Explicit(UnityEngine.Playables.Playable playable)
  RVA=0x09D8ABA4  token=0x6000348  System.Boolean Equals(UnityEngine.Animations.AnimationLayerMixerPlayable other)
  RVA=0x09D8AC84  token=0x6000349  System.Void SetLayerAdditive(System.UInt32 layerIndex, System.Boolean value)
  RVA=0x09D8AFE8  token=0x600034A  System.Void SetLayerMaskFromAvatarMask(System.UInt32 layerIndex, UnityEngine.AvatarMask mask)
  RVA=0x09D8B21C  token=0x600034B  System.Void SetLayerRootMotionDisable(System.UInt32 layerIndex, System.Boolean value)
  RVA=0x09D8AE38  token=0x600034C  System.Void SetLayerEnableFloatCurve(System.UInt32 layerIndex, System.Boolean value)
  RVA=0x02967D70  token=0x600034D  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle)
  RVA=0x09D8AC30  token=0x600034E  System.Void SetLayerAdditiveInternal(UnityEngine.Playables.PlayableHandle& handle, System.UInt32 layerIndex, System.Boolean value)
  RVA=0x02967F20  token=0x600034F  System.Void SetSingleLayerOptimizationInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
  RVA=0x09D8AF98  token=0x6000350  System.Void SetLayerMaskFromAvatarMaskInternal(UnityEngine.Playables.PlayableHandle& handle, System.UInt32 layerIndex, UnityEngine.AvatarMask mask)
  RVA=0x09D8B1C8  token=0x6000351  System.Void SetLayerRootMotionDisableInternal(UnityEngine.Playables.PlayableHandle& handle, System.UInt32 layerIndex, System.Boolean value)
  RVA=0x09D8ADE4  token=0x6000352  System.Void SetLayerEnableFloatCurveInternal(UnityEngine.Playables.PlayableHandle& handle, System.UInt32 layerIndex, System.Boolean value)
  RVA=0x02967F70  token=0x6000353  System.Void .cctor()
  RVA=0x02967DD0  token=0x6000354  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.AnimationMixerPlayable
TYPE:  sealed struct
TOKEN: 0x2000053
SIZE:  0x20
IMPLEMENTS: UnityEngine.Playables.IPlayable System.IEquatable`1
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AnimationMixerPlayablem_NullPlayable  // static @ 0x0
METHODS:
  RVA=0x09D8B4A4  token=0x6000355  UnityEngine.Animations.AnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount, System.Boolean normalizeWeights)
  RVA=0x02808450  token=0x6000356  UnityEngine.Animations.AnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  RVA=0x02808500  token=0x6000357  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  RVA=0x028086F0  token=0x6000358  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  RVA=0x03D695A0  token=0x6000359  UnityEngine.Playables.PlayableHandle GetHandle()
  RVA=0x09D8B5B0  token=0x600035A  UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMixerPlayable playable)
  RVA=0x09D8B524  token=0x600035B  System.Boolean Equals(UnityEngine.Animations.AnimationMixerPlayable other)
  RVA=0x028099E0  token=0x600035C  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle)
  RVA=0x03CE5560  token=0x600035D  System.Void .cctor()
  RVA=0x02809A40  token=0x600035E  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.AnimationMotionXToDeltaPlayable
TYPE:  sealed struct
TOKEN: 0x2000054
SIZE:  0x20
IMPLEMENTS: UnityEngine.Playables.IPlayable System.IEquatable`1
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AnimationMotionXToDeltaPlayablem_NullPlayable  // static @ 0x0
METHODS:
  RVA=0x09D8B780  token=0x600035F  UnityEngine.Animations.AnimationMotionXToDeltaPlayable Create(UnityEngine.Playables.PlayableGraph graph)
  RVA=0x09D8B6A4  token=0x6000360  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph)
  RVA=0x09D8B9C4  token=0x6000361  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  RVA=0x03D695A0  token=0x6000362  UnityEngine.Playables.PlayableHandle GetHandle()
  RVA=0x09D8BA9C  token=0x6000363  UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMotionXToDeltaPlayable playable)
  RVA=0x09D8B814  token=0x6000364  System.Boolean Equals(UnityEngine.Animations.AnimationMotionXToDeltaPlayable other)
  RVA=0x09D8B8E4  token=0x6000365  System.Void SetAbsoluteMotion(System.Boolean value)
  RVA=0x09D8B648  token=0x6000366  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle)
  RVA=0x09D8B8A0  token=0x6000367  System.Void SetAbsoluteMotionInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
  RVA=0x09D8B940  token=0x6000368  System.Void .cctor()
  RVA=0x09D8B604  token=0x6000369  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.AnimationOffsetPlayable
TYPE:  sealed struct
TOKEN: 0x2000055
SIZE:  0x20
IMPLEMENTS: UnityEngine.Playables.IPlayable System.IEquatable`1
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AnimationOffsetPlayablem_NullPlayable  // static @ 0x0
METHODS:
  RVA=0x09D8BCE4  token=0x600036A  UnityEngine.Animations.AnimationOffsetPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int32 inputCount)
  RVA=0x09D8BBC8  token=0x600036B  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int32 inputCount)
  RVA=0x09D8BED8  token=0x600036C  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  RVA=0x03D695A0  token=0x600036D  UnityEngine.Playables.PlayableHandle GetHandle()
  RVA=0x09D8BFB0  token=0x600036E  UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationOffsetPlayable playable)
  RVA=0x09D8BDC0  token=0x600036F  System.Boolean Equals(UnityEngine.Animations.AnimationOffsetPlayable other)
  RVA=0x09D8BB54  token=0x6000370  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Playables.PlayableHandle& handle)
  RVA=0x09D8BE54  token=0x6000371  System.Void .cctor()
  RVA=0x09D8BAF0  token=0x6000372  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.AnimationPlayableExtensions
TYPE:  static class
TOKEN: 0x2000056
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000373  System.Void SetAnimatedProperties(U playable, UnityEngine.AnimationClip clip)
  RVA=0x09D8C160  token=0x6000374  System.Void SetAnimatedPropertiesInternal(UnityEngine.Playables.PlayableHandle& playable, UnityEngine.AnimationClip animatedProperties)
END_CLASS

CLASS: UnityEngine.Animations.AnimationPlayableGraphExtensions
TYPE:  static class
TOKEN: 0x2000057
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x02966E40  token=0x6000375  System.Boolean InternalCreateAnimationOutput(UnityEngine.Playables.PlayableGraph& graph, System.String name, UnityEngine.Playables.PlayableOutputHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.AnimationPlayableOutput
TYPE:  sealed struct
TOKEN: 0x2000058
SIZE:  0x20
IMPLEMENTS: UnityEngine.Playables.IPlayableOutput
FIELDS:
  private           UnityEngine.Playables.PlayableOutputHandlem_Handle  // 0x10
PROPERTIES:
  Null  get=0x09D8C31C
METHODS:
  RVA=0x02966D80  token=0x6000376  UnityEngine.Animations.AnimationPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, System.String name, UnityEngine.Animator target)
  RVA=0x02966EA0  token=0x6000377  System.Void .ctor(UnityEngine.Playables.PlayableOutputHandle handle)
  RVA=0x03D695A0  token=0x6000379  UnityEngine.Playables.PlayableOutputHandle GetHandle()
  RVA=0x03D85A00  token=0x600037A  UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Animations.AnimationPlayableOutput output)
  RVA=0x09D8C394  token=0x600037B  UnityEngine.Animations.AnimationPlayableOutput op_Explicit(UnityEngine.Playables.PlayableOutput output)
  RVA=0x09D8C290  token=0x600037C  UnityEngine.Animator GetTarget()
  RVA=0x04272110  token=0x600037D  System.Void SetTarget(UnityEngine.Animator value)
  RVA=0x09D8C314  token=0x600037E  System.Void SetNeedRebindOnChanged(System.Boolean value)
  RVA=0x09D8C29C  token=0x600037F  UnityEngine.Animator InternalGetTarget(UnityEngine.Playables.PlayableOutputHandle& handle)
  RVA=0x03540510  token=0x6000380  System.Void InternalSetTarget(UnityEngine.Playables.PlayableOutputHandle& handle, UnityEngine.Animator target)
  RVA=0x09D8C2D0  token=0x6000381  System.Void InternalSetNeedRebindOnChanged(UnityEngine.Playables.PlayableOutputHandle& handle, System.Boolean value)
END_CLASS

CLASS: UnityEngine.Animations.AnimationPosePlayable
TYPE:  sealed struct
TOKEN: 0x2000059
SIZE:  0x20
IMPLEMENTS: UnityEngine.Playables.IPlayable System.IEquatable`1
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AnimationPosePlayablem_NullPlayable  // static @ 0x0
METHODS:
  RVA=0x09D8C524  token=0x6000382  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  RVA=0x03D695A0  token=0x6000383  UnityEngine.Playables.PlayableHandle GetHandle()
  RVA=0x09D8C40C  token=0x6000384  System.Boolean Equals(UnityEngine.Animations.AnimationPosePlayable other)
  RVA=0x09D8C4A0  token=0x6000385  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Animations.AnimationRemoveScalePlayable
TYPE:  sealed struct
TOKEN: 0x200005A
SIZE:  0x20
IMPLEMENTS: UnityEngine.Playables.IPlayable System.IEquatable`1
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AnimationRemoveScalePlayablem_NullPlayable  // static @ 0x0
METHODS:
  RVA=0x09D8C784  token=0x6000386  UnityEngine.Animations.AnimationRemoveScalePlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  RVA=0x09D8C69C  token=0x6000387  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  RVA=0x09D8C940  token=0x6000388  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  RVA=0x03D695A0  token=0x6000389  UnityEngine.Playables.PlayableHandle GetHandle()
  RVA=0x09D8CA18  token=0x600038A  UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationRemoveScalePlayable playable)
  RVA=0x09D8C828  token=0x600038B  System.Boolean Equals(UnityEngine.Animations.AnimationRemoveScalePlayable other)
  RVA=0x09D8C640  token=0x600038C  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle)
  RVA=0x09D8C8BC  token=0x600038D  System.Void .cctor()
  RVA=0x09D8C5FC  token=0x600038E  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.AnimationScriptPlayable
TYPE:  sealed struct
TOKEN: 0x200005B
SIZE:  0x20
IMPLEMENTS: UnityEngine.Playables.IPlayable System.IEquatable`1
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AnimationScriptPlayablem_NullPlayable  // static @ 0x0
METHODS:
  RVA=-1  // generic def  token=0x600038F  UnityEngine.Animations.AnimationScriptPlayable Create(UnityEngine.Playables.PlayableGraph graph, T jobData, System.Int32 inputCount)
  RVA=-1  // generic def  token=0x6000390  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  RVA=0x09D8CF34  token=0x6000391  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  RVA=0x03D695A0  token=0x6000392  UnityEngine.Playables.PlayableHandle GetHandle()
  RVA=-1  // generic def  token=0x6000393  System.Void CheckJobTypeValidity()
  RVA=-1  // generic def  token=0x6000394  System.Void SetJobData(T jobData)
  RVA=0x09D8D00C  token=0x6000395  UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationScriptPlayable playable)
  RVA=0x09D8CC2C  token=0x6000396  System.Boolean Equals(UnityEngine.Animations.AnimationScriptPlayable other)
  RVA=0x09D8CE54  token=0x6000397  System.Void SetForceWriteRootMotionParam(System.Boolean value)
  RVA=0x09D8CD58  token=0x6000398  System.Void SetForceResetParam(System.Boolean value)
  RVA=0x09D8CBC8  token=0x6000399  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle, System.IntPtr jobReflectionData)
  RVA=0x09D8CDF8  token=0x600039A  System.Void SetForceWriteRootMotionParamInternal(UnityEngine.Playables.PlayableHandle handle, System.Boolean value)
  RVA=0x09D8CCFC  token=0x600039B  System.Void SetForceResetParamInternal(UnityEngine.Playables.PlayableHandle handle, System.Boolean value)
  RVA=0x09D8CEB0  token=0x600039C  System.Void .cctor()
  RVA=0x09D8CB74  token=0x600039D  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle, System.IntPtr jobReflectionData)
  RVA=0x09D8CDB4  token=0x600039E  System.Void SetForceWriteRootMotionParamInternal_Injected(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
  RVA=0x09D8CCB8  token=0x600039F  System.Void SetForceResetParamInternal_Injected(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
END_CLASS

CLASS: UnityEngine.Animations.AnimationStream
TYPE:  sealed struct
TOKEN: 0x200005C
SIZE:  0x48
FIELDS:
  private           System.UInt32                   m_AnimatorBindingsVersion  // 0x10
  private           System.IntPtr                   constant  // 0x18
  private           System.IntPtr                   input  // 0x20
  private           System.IntPtr                   output  // 0x28
  private           System.IntPtr                   workspace  // 0x30
  private           System.IntPtr                   inputStreamAccessor  // 0x38
  private           System.IntPtr                   animationHandleBinder  // 0x40
PROPERTIES:
  animatorBindingsVersion  get=0x03D85860
  isValid  get=0x09D8D7F0
  deltaTime  get=0x09D8D7D0
METHODS:
  RVA=0x09D8D728  token=0x60003A2  System.Void CheckIsValid()
  RVA=0x09D8D7C8  token=0x60003A4  System.Single GetDeltaTime()
  RVA=0x09D8D794  token=0x60003A5  System.Single GetDeltaTime_Injected(UnityEngine.Animations.AnimationStream& _unity_self)
END_CLASS

CLASS: UnityEngine.Animations.TransformStreamHandle
TYPE:  sealed struct
TOKEN: 0x200005D
SIZE:  0x1C
FIELDS:
  private           System.UInt32                   m_AnimatorBindingsVersion  // 0x10
  private           System.Int32                    handleIndex  // 0x14
  private           System.Int32                    skeletonIndex  // 0x18
PROPERTIES:
  createdByNative  get=0x09D95D04
  hasHandleIndex  get=0x09D95D18
  hasSkeletonIndex  get=0x09D95D24
  animatorBindingsVersion  get=0x03D85860
METHODS:
  RVA=0x09D96D74  token=0x60003A6  System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D96D44  token=0x60003A7  System.Boolean IsValidInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D95968  token=0x60003A9  System.Boolean IsSameVersionAsStream(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D96DD4  token=0x60003AD  System.Void Resolve(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D96D30  token=0x60003AE  System.Boolean IsResolved(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D96CF4  token=0x60003AF  System.Boolean IsResolvedInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D965A4  token=0x60003B0  System.Void CheckIsValidAndResolve(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D96BB0  token=0x60003B1  UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D972B4  token=0x60003B2  System.Void SetPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position)
  RVA=0x09D96C98  token=0x60003B3  UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D97370  token=0x60003B4  System.Void SetRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation)
  RVA=0x09D96820  token=0x60003B5  UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D96F54  token=0x60003B6  System.Void SetLocalPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position)
  RVA=0x09D96908  token=0x60003B7  UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D97010  token=0x60003B8  System.Void SetLocalRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation)
  RVA=0x09D969EC  token=0x60003B9  UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D970C4  token=0x60003BA  System.Void SetLocalScale(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 scale)
  RVA=0x09D96AC4  token=0x60003BB  System.Void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  RVA=0x09D971A8  token=0x60003BC  System.Void SetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, System.Boolean useMask)
  RVA=0x09D96740  token=0x60003BD  System.Void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  RVA=0x09D96E6C  token=0x60003BE  System.Void SetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Boolean useMask)
  RVA=0x09D96DCC  token=0x60003BF  System.Void ResolveInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D96B7C  token=0x60003C0  UnityEngine.Vector3 GetPositionInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D972A0  token=0x60003C1  System.Void SetPositionInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 position)
  RVA=0x09D96C68  token=0x60003C2  UnityEngine.Quaternion GetRotationInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D9735C  token=0x60003C3  System.Void SetRotationInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion rotation)
  RVA=0x09D967EC  token=0x60003C4  UnityEngine.Vector3 GetLocalPositionInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D96F40  token=0x60003C5  System.Void SetLocalPositionInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 position)
  RVA=0x09D968D8  token=0x60003C6  UnityEngine.Quaternion GetLocalRotationInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D96FFC  token=0x60003C7  System.Void SetLocalRotationInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion rotation)
  RVA=0x09D969B8  token=0x60003C8  UnityEngine.Vector3 GetLocalScaleInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D970B0  token=0x60003C9  System.Void SetLocalScaleInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 scale)
  RVA=0x09D96AB4  token=0x60003CA  System.Void GetLocalTRSInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  RVA=0x09D9717C  token=0x60003CB  System.Void SetLocalTRSInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, System.Boolean useMask)
  RVA=0x09D96730  token=0x60003CC  System.Void GetGlobalTRInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  RVA=0x09D96E4C  token=0x60003CD  System.Void SetGlobalTRInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Boolean useMask)
  RVA=0x09D96D88  token=0x60003CE  System.Void ResolveInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D96B28  token=0x60003CF  System.Void GetPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret)
  RVA=0x09D9724C  token=0x60003D0  System.Void SetPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position)
  RVA=0x09D96C14  token=0x60003D1  System.Void GetRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& ret)
  RVA=0x09D97308  token=0x60003D2  System.Void SetRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& rotation)
  RVA=0x09D96798  token=0x60003D3  System.Void GetLocalPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret)
  RVA=0x09D96EEC  token=0x60003D4  System.Void SetLocalPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position)
  RVA=0x09D96884  token=0x60003D5  System.Void GetLocalRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& ret)
  RVA=0x09D96FA8  token=0x60003D6  System.Void SetLocalRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& rotation)
  RVA=0x09D96964  token=0x60003D7  System.Void GetLocalScaleInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret)
  RVA=0x09D9705C  token=0x60003D8  System.Void SetLocalScaleInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& scale)
  RVA=0x09D96A50  token=0x60003D9  System.Void GetLocalTRSInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  RVA=0x09D97118  token=0x60003DA  System.Void SetLocalTRSInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale, System.Boolean useMask)
  RVA=0x09D966CC  token=0x60003DB  System.Void GetGlobalTRInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  RVA=0x09D96DE8  token=0x60003DC  System.Void SetGlobalTRInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, System.Boolean useMask)
END_CLASS

CLASS: UnityEngine.Animations.PropertyStreamHandle
TYPE:  sealed struct
TOKEN: 0x200005E
SIZE:  0x20
FIELDS:
  private           System.UInt32                   m_AnimatorBindingsVersion  // 0x10
  private           System.Int32                    handleIndex  // 0x14
  private           System.Int32                    valueArrayIndex  // 0x18
  private           System.Int32                    bindType  // 0x1c
PROPERTIES:
  createdByNative  get=0x09D95D04
  hasHandleIndex  get=0x09D95D18
  hasValueArrayIndex  get=0x09D95D24
  hasBindType  get=0x09D95D10
  animatorBindingsVersion  get=0x03D85860
METHODS:
  RVA=0x09D959A8  token=0x60003DD  System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D95974  token=0x60003DE  System.Boolean IsValidInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D95968  token=0x60003E0  System.Boolean IsSameVersionAsStream(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D9592C  token=0x60003E5  System.Boolean IsResolvedInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D95560  token=0x60003E6  System.Void CheckIsValidAndResolve(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D957BC  token=0x60003E7  System.Single GetFloat(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D95B64  token=0x60003E8  System.Void SetFloat(UnityEngine.Animations.AnimationStream stream, System.Single value)
  RVA=0x09D95894  token=0x60003E9  System.Int32 GetInt(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D95C5C  token=0x60003EA  System.Void SetInt(UnityEngine.Animations.AnimationStream stream, System.Int32 value)
  RVA=0x09D956DC  token=0x60003EB  System.Boolean GetBool(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D95A64  token=0x60003EC  System.Void SetBool(UnityEngine.Animations.AnimationStream stream, System.Boolean value)
  RVA=0x09D95A00  token=0x60003ED  System.Void ResolveInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D957B4  token=0x60003EE  System.Single GetFloatInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D95B5C  token=0x60003EF  System.Void SetFloatInternal(UnityEngine.Animations.AnimationStream& stream, System.Single value)
  RVA=0x09D9588C  token=0x60003F0  System.Int32 GetIntInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D95C54  token=0x60003F1  System.Void SetIntInternal(UnityEngine.Animations.AnimationStream& stream, System.Int32 value)
  RVA=0x09D956D4  token=0x60003F2  System.Boolean GetBoolInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D95A5C  token=0x60003F3  System.Void SetBoolInternal(UnityEngine.Animations.AnimationStream& stream, System.Boolean value)
  RVA=0x09D959BC  token=0x60003F4  System.Void ResolveInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D95770  token=0x60003F5  System.Single GetFloatInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D95B08  token=0x60003F6  System.Void SetFloatInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, System.Single value)
  RVA=0x09D95848  token=0x60003F7  System.Int32 GetIntInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D95C00  token=0x60003F8  System.Void SetIntInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, System.Int32 value)
  RVA=0x09D95690  token=0x60003F9  System.Boolean GetBoolInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D95A08  token=0x60003FA  System.Void SetBoolInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, System.Boolean value)
END_CLASS

CLASS: UnityEngine.Animations.TransformSceneHandle
TYPE:  sealed struct
TOKEN: 0x200005F
SIZE:  0x18
FIELDS:
  private           System.UInt32                   valid  // 0x10
  private           System.Int32                    transformSceneHandleDefinitionIndex  // 0x14
PROPERTIES:
  createdByNative  get=0x0426F724
  hasTransformSceneHandleDefinitionIndex  get=0x09D95D18
METHODS:
  RVA=0x09D9655C  token=0x60003FB  System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D95E00  token=0x60003FE  System.Void CheckIsValid(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D963CC  token=0x60003FF  UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D9603C  token=0x6000400  UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D964B4  token=0x6000401  UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D96124  token=0x6000402  UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D96208  token=0x6000403  UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream)
  RVA=0x09D962E0  token=0x6000404  System.Void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  RVA=0x09D95F5C  token=0x6000405  System.Void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  RVA=0x09D96554  token=0x6000406  System.Boolean HasValidTransform(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D96398  token=0x6000407  UnityEngine.Vector3 GetPositionInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D96008  token=0x6000408  UnityEngine.Vector3 GetLocalPositionInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D96484  token=0x6000409  UnityEngine.Quaternion GetRotationInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D960F4  token=0x600040A  UnityEngine.Quaternion GetLocalRotationInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D961D4  token=0x600040B  UnityEngine.Vector3 GetLocalScaleInternal(UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D962D0  token=0x600040C  System.Void GetLocalTRSInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  RVA=0x09D95F4C  token=0x600040D  System.Void GetGlobalTRInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  RVA=0x09D96510  token=0x600040E  System.Boolean HasValidTransform_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream)
  RVA=0x09D96344  token=0x600040F  System.Void GetPositionInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret)
  RVA=0x09D95FB4  token=0x6000410  System.Void GetLocalPositionInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret)
  RVA=0x09D96430  token=0x6000411  System.Void GetRotationInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& ret)
  RVA=0x09D960A0  token=0x6000412  System.Void GetLocalRotationInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& ret)
  RVA=0x09D96180  token=0x6000413  System.Void GetLocalScaleInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret)
  RVA=0x09D9626C  token=0x6000414  System.Void GetLocalTRSInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  RVA=0x09D95EE8  token=0x6000415  System.Void GetGlobalTRInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
END_CLASS

CLASS: UnityEngine.Animations.PropertySceneHandle
TYPE:  sealed struct
TOKEN: 0x2000060
SIZE:  0x18
FIELDS:
  private           System.UInt32                   valid  // 0x10
  private           System.Int32                    handleIndex  // 0x14
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.AnimationSceneHandleUtility
TYPE:  static class
TOKEN: 0x2000061
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09D8CA6C  token=0x6000416  System.Void ReadFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertySceneHandle> handles, Unity.Collections.NativeArray<System.Single> buffer)
  RVA=-1  // generic def  token=0x6000417  System.Int32 ValidateAndGetArrayCount(UnityEngine.Animations.AnimationStream& stream, Unity.Collections.NativeArray<T0> handles, Unity.Collections.NativeArray<T1> buffer)
  RVA=0x09D8CB10  token=0x6000418  System.Void ReadSceneFloatsInternal(UnityEngine.Animations.AnimationStream& stream, System.Void* propertySceneHandles, System.Void* floatBuffer, System.Int32 count)
END_CLASS

CLASS: UnityEngine.Animations.AnimationStreamHandleUtility
TYPE:  static class
TOKEN: 0x2000062
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09D8D60C  token=0x6000419  System.Void WriteFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<System.Single> buffer, System.Boolean useMask)
  RVA=0x09D8D500  token=0x600041A  System.Void ReadFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<System.Single> buffer)
  RVA=0x09D8D5A8  token=0x600041B  System.Void ReadStreamFloatsInternal(UnityEngine.Animations.AnimationStream& stream, System.Void* propertyStreamHandles, System.Void* floatBuffer, System.Int32 count)
  RVA=0x09D8D6C4  token=0x600041C  System.Void WriteStreamFloatsInternal(UnityEngine.Animations.AnimationStream& stream, System.Void* propertyStreamHandles, System.Void* floatBuffer, System.Int32 count, System.Boolean useMask)
END_CLASS

CLASS: UnityEngine.Animations.AnimatorControllerPlayable
TYPE:  sealed struct
TOKEN: 0x2000063
SIZE:  0x20
IMPLEMENTS: UnityEngine.Playables.IPlayable System.IEquatable`1
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AnimatorControllerPlayablem_NullPlayable  // static @ 0x0
METHODS:
  RVA=0x09D8E3C8  token=0x600041D  UnityEngine.Animations.AnimatorControllerPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller)
  RVA=0x09D8E2F0  token=0x600041E  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller)
  RVA=0x09D8E758  token=0x600041F  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  RVA=0x03D695A0  token=0x6000420  UnityEngine.Playables.PlayableHandle GetHandle()
  RVA=0x09D8E590  token=0x6000421  System.Void SetHandle(UnityEngine.Playables.PlayableHandle handle)
  RVA=0x09D8E46C  token=0x6000422  System.Boolean Equals(UnityEngine.Animations.AnimatorControllerPlayable other)
  RVA=0x09D8E538  token=0x6000423  System.Boolean IsInTransition(System.Int32 layerIndex)
  RVA=0x09D8E28C  token=0x6000424  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller, UnityEngine.Playables.PlayableHandle& handle)
  RVA=0x09D8E4F8  token=0x6000425  System.Boolean IsInTransitionInternal(UnityEngine.Playables.PlayableHandle& handle, System.Int32 layerIndex)
  RVA=0x09D8E6D4  token=0x6000426  System.Void .cctor()
  RVA=0x09D8E238  token=0x6000427  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.RuntimeAnimatorController controller, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.CustomStreamPropertyType
TYPE:  sealed struct
TOKEN: 0x2000064
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Animations.CustomStreamPropertyTypeFloat  // const
  public    static  UnityEngine.Animations.CustomStreamPropertyTypeBool  // const
  public    static  UnityEngine.Animations.CustomStreamPropertyTypeInt  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.AnimatorJobExtensions
TYPE:  static class
TOKEN: 0x2000065
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09D8E948  token=0x6000428  UnityEngine.Animations.TransformStreamHandle BindStreamTransform(UnityEngine.Animator animator, UnityEngine.Transform transform)
  RVA=0x09D8E904  token=0x6000429  UnityEngine.Animations.PropertyStreamHandle BindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property)
  RVA=0x09D8E7E0  token=0x600042A  UnityEngine.Animations.PropertyStreamHandle BindCustomStreamProperty(UnityEngine.Animator animator, System.String property, UnityEngine.Animations.CustomStreamPropertyType type)
  RVA=0x09D8E89C  token=0x600042B  UnityEngine.Animations.PropertyStreamHandle BindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property, System.Boolean isObjectReference)
  RVA=0x09D8E878  token=0x600042C  UnityEngine.Animations.TransformSceneHandle BindSceneTransform(UnityEngine.Animator animator, UnityEngine.Transform transform)
  RVA=0x09D8E85C  token=0x600042D  UnityEngine.Animations.PropertySceneHandle BindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property)
  RVA=0x09D8E828  token=0x600042E  UnityEngine.Animations.PropertySceneHandle BindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property, System.Boolean isObjectReference)
  RVA=0x09D8EB18  token=0x600042F  System.Void InternalBindStreamTransform(UnityEngine.Animator animator, UnityEngine.Transform transform, UnityEngine.Animations.TransformStreamHandle& transformStreamHandle)
  RVA=0x09D8EAB4  token=0x6000430  System.Void InternalBindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property, System.Boolean isObjectReference, UnityEngine.Animations.PropertyStreamHandle& propertyStreamHandle)
  RVA=0x09D8E998  token=0x6000431  System.Void InternalBindCustomStreamProperty(UnityEngine.Animator animator, System.String property, UnityEngine.Animations.CustomStreamPropertyType propertyType, UnityEngine.Animations.PropertyStreamHandle& propertyStreamHandle)
  RVA=0x09D8EA60  token=0x6000432  System.Void InternalBindSceneTransform(UnityEngine.Animator animator, UnityEngine.Transform transform, UnityEngine.Animations.TransformSceneHandle& transformSceneHandle)
  RVA=0x09D8E9FC  token=0x6000433  System.Void InternalBindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property, System.Boolean isObjectReference, UnityEngine.Animations.PropertySceneHandle& propertySceneHandle)
END_CLASS

CLASS: UnityEngine.Animations.Axis
TYPE:  sealed struct
TOKEN: 0x2000066
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Animations.Axis     None  // const
  public    static  UnityEngine.Animations.Axis     X  // const
  public    static  UnityEngine.Animations.Axis     Y  // const
  public    static  UnityEngine.Animations.Axis     Z  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Animations.AnimationStreamSource
TYPE:  sealed struct
TOKEN: 0x2000045
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.Animations.AnimationStreamSourceDefaultValues  // const
  public    static  UnityEngine.Experimental.Animations.AnimationStreamSourcePreviousInputs  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions
TYPE:  static class
TOKEN: 0x2000046
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09D8C24C  token=0x600030E  System.Void SetAnimationStreamSource(UnityEngine.Animations.AnimationPlayableOutput output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource)
  RVA=0x09D8C26C  token=0x600030F  System.Void SetSortingOrder(UnityEngine.Animations.AnimationPlayableOutput output, System.UInt16 sortingOrder)
  RVA=0x09D8C1E4  token=0x6000310  System.Void InternalSetAnimationStreamSource(UnityEngine.Playables.PlayableOutputHandle output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource)
  RVA=0x09D8C238  token=0x6000311  System.Void InternalSetSortingOrder(UnityEngine.Playables.PlayableOutputHandle output, System.Int32 sortingOrder)
  RVA=0x09D8C1A4  token=0x6000312  System.Void InternalSetAnimationStreamSource_Injected(UnityEngine.Playables.PlayableOutputHandle& output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource)
  RVA=0x09D8C1F8  token=0x6000313  System.Void InternalSetSortingOrder_Injected(UnityEngine.Playables.PlayableOutputHandle& output, System.Int32 sortingOrder)
END_CLASS

