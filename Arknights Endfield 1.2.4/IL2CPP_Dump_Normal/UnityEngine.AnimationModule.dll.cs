// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AnimationModule.dll
// Classes:  102
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x200000D  // size: 0x20
    public sealed class Enumerator : System.Collections.IEnumerator
    {
        // Fields
        private UnityEngine.Animation m_Outer;  // 0x10
        private System.Int32 m_CurrentIndex;  // 0x18

        // Properties
        System.Object Current { get; /* RVA: 0x0329DB70 */ }

        // Methods
        // RVA: 0x025CE600  token: 0x600004F
        private System.Void .ctor(UnityEngine.Animation outer) { }
        // RVA: 0x031AB930  token: 0x6000051
        public virtual System.Boolean MoveNext() { }
        // RVA: 0x03D50330  token: 0x6000052
        public virtual System.Void Reset() { }

    }

    // TypeToken: 0x2000029  // size: 0x80
    public sealed class AnimationEventCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x03CC43E0  token: 0x600029C
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x021126B0  token: 0x600029D
        public virtual System.Boolean Invoke(UnityEngine.Animator animator, UnityEngine.FastAnimationEvent fastAnimationEvent) { }

    }

    // TypeToken: 0x200002A  // size: 0x80
    public sealed class AnimatorStateChangeCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x0349B320  token: 0x600029E
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x09D8F4F0  token: 0x600029F
        public virtual System.Void Invoke(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo animatorStateInfo, System.Int32 layerIndex) { }

    }

    // TypeToken: 0x200002B  // size: 0x80
    public sealed class AnimationEventCallbackOpt : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x027ACE40  token: 0x60002A0
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x09D8AA38  token: 0x60002A1
        public virtual System.Boolean Invoke(UnityEngine.Animator animator, UnityEngine.FastAnimationEventGroup fastAnimationEvent) { }

    }

    // TypeToken: 0x200002C  // size: 0x80
    public sealed class AniamtorCommonCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x0613B2F0  token: 0x60002A2
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x60002A3
        public virtual System.Void Invoke(UnityEngine.Animator animator) { }

    }

    // TypeToken: 0x2000030  // size: 0x80
    public sealed class OnOverrideControllerDirtyCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x042BE04C  token: 0x60002C6
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x042BE03C  token: 0x60002C7
        public virtual System.Void Invoke() { }

    }

    // TypeToken: 0x200004E
    public sealed class ExecuteJobFunction : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x600031B
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x600031C
        public virtual System.Void Invoke(T& data, System.IntPtr animationStreamPtr, System.IntPtr unusedPtr, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }

    }

namespace UnityEngine
{

    // TypeToken: 0x2000002
    public interface IAnimationClipSource
    {
    }

    // TypeToken: 0x2000003  // size: 0x10
    public sealed class SharedBetweenAnimatorsAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000001
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x18
    public abstract class StateMachineBehaviour : UnityEngine.ScriptableObject
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000002
        public virtual System.Void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex) { }
        // RVA: 0x0350B670  token: 0x6000003
        public virtual System.Void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex) { }
        // RVA: 0x0350B670  token: 0x6000004
        public virtual System.Void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex) { }
        // RVA: 0x0350B670  token: 0x6000005
        public virtual System.Void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex) { }
        // RVA: 0x0350B670  token: 0x6000006
        public virtual System.Void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex) { }
        // RVA: 0x0350B670  token: 0x6000007
        public virtual System.Void OnStatePreExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex) { }
        // RVA: 0x0350B670  token: 0x6000008
        public virtual System.Void OnStateMachineEnter(UnityEngine.Animator animator, System.Int32 stateMachinePathHash) { }
        // RVA: 0x0350B670  token: 0x6000009
        public virtual System.Void OnStateMachineExit(UnityEngine.Animator animator, System.Int32 stateMachinePathHash) { }
        // RVA: 0x0350B670  token: 0x600000A
        public virtual System.Void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller) { }
        // RVA: 0x0350B670  token: 0x600000B
        public virtual System.Void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller) { }
        // RVA: 0x0350B670  token: 0x600000C
        public virtual System.Void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller) { }
        // RVA: 0x0350B670  token: 0x600000D
        public virtual System.Void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller) { }
        // RVA: 0x0350B670  token: 0x600000E
        public virtual System.Void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller) { }
        // RVA: 0x0350B670  token: 0x600000F
        public virtual System.Void OnStatePreExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller) { }
        // RVA: 0x0350B670  token: 0x6000010
        public virtual System.Void OnStateMachineEnter(UnityEngine.Animator animator, System.Int32 stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller) { }
        // RVA: 0x0350B670  token: 0x6000011
        public virtual System.Void OnStateMachineExit(UnityEngine.Animator animator, System.Int32 stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller) { }
        // RVA: 0x0286F540  token: 0x6000012
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000005  // size: 0x14
    public sealed struct PlayMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.PlayMode StopSameLayer;  // const
        public static UnityEngine.PlayMode StopAll;  // const

    }

    // TypeToken: 0x2000006  // size: 0x14
    public sealed struct QueueMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.QueueMode CompleteOthers;  // const
        public static UnityEngine.QueueMode PlayNow;  // const

    }

    // TypeToken: 0x2000007  // size: 0x14
    public sealed struct AnimationBlendMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AnimationBlendMode Blend;  // const
        public static UnityEngine.AnimationBlendMode Additive;  // const

    }

    // TypeToken: 0x2000008  // size: 0x14
    public sealed struct AnimationPlayMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AnimationPlayMode Stop;  // const
        public static UnityEngine.AnimationPlayMode Queue;  // const
        public static UnityEngine.AnimationPlayMode Mix;  // const

    }

    // TypeToken: 0x2000009  // size: 0x14
    public sealed struct AnimationCullingType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AnimationCullingType AlwaysAnimate;  // const
        public static UnityEngine.AnimationCullingType BasedOnRenderers;  // const
        public static UnityEngine.AnimationCullingType BasedOnClipBounds;  // const
        public static UnityEngine.AnimationCullingType BasedOnUserBounds;  // const

    }

    // TypeToken: 0x200000A  // size: 0x14
    public sealed struct AnimationEventSource
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AnimationEventSource NoSource;  // const
        public static UnityEngine.AnimationEventSource Legacy;  // const
        public static UnityEngine.AnimationEventSource Animator;  // const

    }

    // TypeToken: 0x200000B  // size: 0x14
    public sealed struct AnimEventHashCodeType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AnimEventHashCodeType None;  // const
        public static UnityEngine.AnimEventHashCodeType CRC32;  // const
        public static UnityEngine.AnimEventHashCodeType HashCode64;  // const

    }

    // TypeToken: 0x200000C  // size: 0x18
    public sealed class Animation : UnityEngine.Behaviour, System.Collections.IEnumerable
    {
        // Properties
        UnityEngine.AnimationClip clip { get; /* RVA: 0x09D8DDF4 */ set; /* RVA: 0x09D8DFF4 */ }
        System.Boolean playAutomatically { get; /* RVA: 0x09D8DF04 */ set; /* RVA: 0x025CBA30 */ }
        UnityEngine.WrapMode wrapMode { get; /* RVA: 0x09D8DF38 */ set; /* RVA: 0x09D8E0D0 */ }
        System.Boolean isPlaying { get; /* RVA: 0x09D8DE5C */ }
        UnityEngine.AnimationState Item { get; /* RVA: 0x09D8DD80 */ }
        System.Boolean animatePhysics { get; /* RVA: 0x09D8DDC0 */ set; /* RVA: 0x09D8DFB0 */ }
        System.Boolean animateOnlyIfVisible { get; /* RVA: 0x09D8DD8C */ set; /* RVA: 0x09D8DF6C */ }
        UnityEngine.AnimationCullingType cullingType { get; /* RVA: 0x09D8DE28 */ set; /* RVA: 0x09D8E038 */ }
        UnityEngine.Bounds localBounds { get; /* RVA: 0x09D8DED4 */ set; /* RVA: 0x09D8E0BC */ }

        // Methods
        // RVA: 0x02C6CE90  token: 0x6000019
        public System.Void Stop() { }
        // RVA: 0x09D8DD38  token: 0x600001A
        public System.Void Stop(System.String name) { }
        // RVA: 0x09D8DCF4  token: 0x600001B
        private System.Void StopNamed(System.String name) { }
        // RVA: 0x09D8DC84  token: 0x600001C
        public System.Void Rewind() { }
        // RVA: 0x09D8DCB8  token: 0x600001D
        public System.Void Rewind(System.String name) { }
        // RVA: 0x09D8DC40  token: 0x600001E
        private System.Void RewindNamed(System.String name) { }
        // RVA: 0x09D8DCC0  token: 0x600001F
        public System.Void Sample() { }
        // RVA: 0x09D8DAD0  token: 0x6000021
        public System.Boolean IsPlaying(System.String name) { }
        // RVA: 0x03787540  token: 0x6000023
        public System.Boolean Play() { }
        // RVA: 0x04276B58  token: 0x6000024
        public System.Boolean Play(UnityEngine.PlayMode mode) { }
        // RVA: 0x03D1EA50  token: 0x6000025
        private System.Boolean PlayDefaultAnimation(UnityEngine.PlayMode mode) { }
        // RVA: 0x04276B48  token: 0x6000026
        public System.Boolean Play(System.String animation) { }
        // RVA: 0x03CC4640  token: 0x6000027
        public System.Boolean Play(System.String animation, UnityEngine.PlayMode mode) { }
        // RVA: 0x09D8DA8C  token: 0x6000028
        public System.Void CrossFade(System.String animation) { }
        // RVA: 0x09D8DA0C  token: 0x6000029
        public System.Void CrossFade(System.String animation, System.Single fadeLength) { }
        // RVA: 0x09D8DA28  token: 0x600002A
        public System.Void CrossFade(System.String animation, System.Single fadeLength, UnityEngine.PlayMode mode) { }
        // RVA: 0x09D8D8C8  token: 0x600002B
        public System.Void Blend(System.String animation) { }
        // RVA: 0x09D8D93C  token: 0x600002C
        public System.Void Blend(System.String animation, System.Single targetWeight) { }
        // RVA: 0x09D8D8D8  token: 0x600002D
        public System.Void Blend(System.String animation, System.Single targetWeight, System.Single fadeLength) { }
        // RVA: 0x09D8D994  token: 0x600002E
        public UnityEngine.AnimationState CrossFadeQueued(System.String animation) { }
        // RVA: 0x09D8D95C  token: 0x600002F
        public UnityEngine.AnimationState CrossFadeQueued(System.String animation, System.Single fadeLength) { }
        // RVA: 0x09D8D978  token: 0x6000030
        public UnityEngine.AnimationState CrossFadeQueued(System.String animation, System.Single fadeLength, UnityEngine.QueueMode queue) { }
        // RVA: 0x09D8D9A8  token: 0x6000031
        public UnityEngine.AnimationState CrossFadeQueued(System.String animation, System.Single fadeLength, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode) { }
        // RVA: 0x09D8DB14  token: 0x6000032
        public UnityEngine.AnimationState PlayQueued(System.String animation) { }
        // RVA: 0x09D8DB88  token: 0x6000033
        public UnityEngine.AnimationState PlayQueued(System.String animation, UnityEngine.QueueMode queue) { }
        // RVA: 0x09D8DB24  token: 0x6000034
        public UnityEngine.AnimationState PlayQueued(System.String animation, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode) { }
        // RVA: 0x09D8D83C  token: 0x6000035
        public System.Void AddClip(UnityEngine.AnimationClip clip, System.String newName) { }
        // RVA: 0x09D8D818  token: 0x6000036
        public System.Void AddClip(UnityEngine.AnimationClip clip, System.String newName, System.Int32 firstFrame, System.Int32 lastFrame) { }
        // RVA: 0x09D8D864  token: 0x6000037
        public System.Void AddClip(UnityEngine.AnimationClip clip, System.String newName, System.Int32 firstFrame, System.Int32 lastFrame, System.Boolean addLoopFrame) { }
        // RVA: 0x09D8DBFC  token: 0x6000038
        public System.Void RemoveClip(UnityEngine.AnimationClip clip) { }
        // RVA: 0x09D8DBF4  token: 0x6000039
        public System.Void RemoveClip(System.String clipName) { }
        // RVA: 0x09D8DBB0  token: 0x600003A
        private System.Void RemoveClipNamed(System.String clipName) { }
        // RVA: 0x09D8DA9C  token: 0x600003B
        public System.Int32 GetClipCount() { }
        // RVA: 0x04276B58  token: 0x600003C
        public System.Boolean Play(UnityEngine.AnimationPlayMode mode) { }
        // RVA: 0x09D8DBA4  token: 0x600003D
        public System.Boolean Play(System.String animation, UnityEngine.AnimationPlayMode mode) { }
        // RVA: 0x09D8DD40  token: 0x600003E
        public System.Void SyncLayer(System.Int32 layer) { }
        // RVA: 0x025CE5A0  token: 0x600003F
        public virtual System.Collections.IEnumerator GetEnumerator() { }
        // RVA: 0x02C6CE40  token: 0x6000040
        private UnityEngine.AnimationState GetState(System.String name) { }
        // RVA: 0x0329DBA0  token: 0x6000041
        private UnityEngine.AnimationState GetStateAtIndex(System.Int32 index) { }
        // RVA: 0x031AB9A0  token: 0x6000042
        private System.Int32 GetStateCount() { }
        // RVA: 0x02C6CE10  token: 0x6000043
        public UnityEngine.AnimationClip GetClip(System.String name) { }
        // RVA: 0x0426FE60  token: 0x600004C
        public System.Void .ctor() { }
        // RVA: 0x09D8DE90  token: 0x600004D
        private System.Void get_localBounds_Injected(UnityEngine.Bounds& ret) { }
        // RVA: 0x09D8E078  token: 0x600004E
        private System.Void set_localBounds_Injected(UnityEngine.Bounds& value) { }

    }

    // TypeToken: 0x200000E  // size: 0x18
    public sealed class AnimationState : UnityEngine.TrackedReference
    {
        // Properties
        System.Boolean enabled { get; /* RVA: 0x09D8D138 */ set; /* RVA: 0x09D8D2E4 */ }
        System.Single weight { get; /* RVA: 0x09D8D270 */ set; /* RVA: 0x09D8D47C */ }
        UnityEngine.WrapMode wrapMode { get; /* RVA: 0x025CBEB0 */ set; /* RVA: 0x09D8D4C0 */ }
        System.Single time { get; /* RVA: 0x09D8D23C */ set; /* RVA: 0x09D8D438 */ }
        System.Single normalizedTime { get; /* RVA: 0x09D8D1D4 */ set; /* RVA: 0x09D8D3B0 */ }
        System.Single speed { get; /* RVA: 0x09D8D208 */ set; /* RVA: 0x09D8D3F4 */ }
        System.Single normalizedSpeed { get; /* RVA: 0x09D8D1A0 */ set; /* RVA: 0x09D8D36C */ }
        System.Single length { get; /* RVA: 0x025CC780 */ }
        System.Int32 layer { get; /* RVA: 0x09D8D16C */ set; /* RVA: 0x025CE3C0 */ }
        UnityEngine.AnimationClip clip { get; /* RVA: 0x025CE210 */ }
        System.String name { get; /* RVA: 0x025CD470 */ set; /* RVA: 0x09D8D328 */ }
        UnityEngine.AnimationBlendMode blendMode { get; /* RVA: 0x09D8D104 */ set; /* RVA: 0x09D8D2A4 */ }

        // Methods
        // RVA: 0x09D8D060  token: 0x6000069
        public System.Void AddMixingTransform(UnityEngine.Transform mix) { }
        // RVA: 0x09D8D06C  token: 0x600006A
        public System.Void AddMixingTransform(UnityEngine.Transform mix, System.Boolean recursive) { }
        // RVA: 0x09D8D0C0  token: 0x600006B
        public System.Void RemoveMixingTransform(UnityEngine.Transform mix) { }
        // RVA: 0x0350B670  token: 0x600006C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000F  // size: 0x48
    public sealed struct FastAnimationEvent
    {
        // Fields
        private System.Single m_Time;  // 0x10
        private System.Single m_ClipWeight;  // 0x14
        private System.String m_FunctionName;  // 0x18
        private System.String m_StringParameter;  // 0x20
        private UnityEngine.Object m_ObjectReferenceParameter;  // 0x28
        private System.Single m_FloatParameter;  // 0x30
        private System.Int32 m_IntParameter;  // 0x34
        private UnityEngine.SendMessageOptions m_MessageOptions;  // 0x38
        private System.Int32 m_StringParameterHashCode;  // 0x3c
        private System.Int32 m_FunctionNameHashCode;  // 0x40
        private System.Boolean m_IsInTransition;  // 0x44
        private System.Boolean m_IsFromMaxWeightClipState;  // 0x45
        private System.Boolean m_IsFromNextMaxWeightClipState;  // 0x46

        // Properties
        System.String stringParameter { get; /* RVA: 0x03D66B80 */ set; /* RVA: 0x0426FEE0 */ }
        System.Single floatParameter { get; /* RVA: 0x03D85A70 */ set; /* RVA: 0x03D4F2F0 */ }
        System.Int32 intParameter { get; /* RVA: 0x03D85AA0 */ set; /* RVA: 0x03D4E2F0 */ }
        System.String functionName { get; /* RVA: 0x03D85A90 */ }
        System.Single time { get; /* RVA: 0x03D85AE0 */ set; /* RVA: 0x03D58BD0 */ }
        UnityEngine.SendMessageOptions messageOptions { set; /* RVA: 0x03D4EBA0 */ }
        System.Single clipWeight { get; /* RVA: 0x03D85850 */ set; /* RVA: 0x03D58BF0 */ }
        System.Boolean isInTransition { get; /* RVA: 0x03D85AD0 */ set; /* RVA: 0x03D4F590 */ }
        System.Boolean isFromMaxWeightClipState { get; /* RVA: 0x03D85AB0 */ set; /* RVA: 0x03D4F580 */ }
        System.Boolean isFromNextMaxWeightClipState { get; /* RVA: 0x03D85AC0 */ set; /* RVA: 0x03D85AF0 */ }
        System.Int32 functionNameHashCode { get; /* RVA: 0x03D85A80 */ set; /* RVA: 0x03D4EE10 */ }

    }

    // TypeToken: 0x2000010  // size: 0x78
    public sealed struct FastAnimationEventGroup
    {
        // Fields
        public System.Int32 count;  // 0x10
        public System.IntPtr times;  // 0x18
        public System.IntPtr clipWeights;  // 0x20
        public System.IntPtr functionNames;  // 0x28
        public System.IntPtr stringParameters;  // 0x30
        public System.IntPtr functionNamesHashCode;  // 0x38
        public System.IntPtr stringParametersHashCode;  // 0x40
        public System.IntPtr floatParameters;  // 0x48
        public System.IntPtr intParameters;  // 0x50
        public System.IntPtr messageOptions;  // 0x58
        public System.IntPtr inTransitions;  // 0x60
        public System.IntPtr isFromMaxWeightClipStatus;  // 0x68
        public System.IntPtr isFromNextMaxWeightClipStatus;  // 0x70

    }

    // TypeToken: 0x2000011  // size: 0x90
    public sealed class AnimationEvent
    {
        // Fields
        private System.Single m_Time;  // 0x10
        private System.String m_FunctionName;  // 0x18
        private System.String m_StringParameter;  // 0x20
        private UnityEngine.Object m_ObjectReferenceParameter;  // 0x28
        private System.Single m_FloatParameter;  // 0x30
        private System.Int32 m_IntParameter;  // 0x34
        private System.Int32 m_MessageOptions;  // 0x38
        private UnityEngine.AnimationEventSource m_Source;  // 0x3c
        private UnityEngine.AnimationState m_StateSender;  // 0x40
        private UnityEngine.AnimatorStateInfo m_AnimatorStateInfo;  // 0x48
        private UnityEngine.AnimatorClipInfo m_AnimatorClipInfo;  // 0x7c
        private System.Int32 m_FunctionNameHashCode;  // 0x84
        private System.Int32 m_StringParameterHashCode;  // 0x88
        private UnityEngine.AnimEventHashCodeType m_HashCodeType;  // 0x8c

        // Properties
        System.String stringParameter { get; /* RVA: 0x03D85A20 */ set; /* RVA: 0x04271930 */ }
        System.Single floatParameter { get; /* RVA: 0x03D84BA0 */ set; /* RVA: 0x03D4F5E0 */ }
        System.Int32 intParameter { get; /* RVA: 0x03D85A10 */ set; /* RVA: 0x03D4EE40 */ }
        UnityEngine.Object objectReferenceParameter { set; /* RVA: 0x02C92F10 */ }
        System.String functionName { get; /* RVA: 0x03D61D00 */ set; /* RVA: 0x022C3A90 */ }
        System.Single time { get; /* RVA: 0x03D85830 */ set; /* RVA: 0x03D50CA0 */ }
        UnityEngine.SendMessageOptions messageOptions { set; /* RVA: 0x03D4ECB0 */ }
        System.Boolean isFiredByAnimator { get; /* RVA: 0x09D8AB9C */ }
        UnityEngine.AnimatorClipInfo animatorClipInfo { get; /* RVA: 0x09D8AB40 */ }

        // Methods
        // RVA: 0x09D8AAA4  token: 0x6000081
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000012  // size: 0x20
    public sealed class AnimationClip : UnityEngine.Motion
    {
        // Properties
        System.Single length { get; /* RVA: 0x02383B20 */ }
        System.Single startTime { get; /* RVA: 0x09D8A7B8 */ }
        System.Single stopTime { get; /* RVA: 0x09D8A7EC */ }
        System.Single frameRate { get; /* RVA: 0x09D8A5A4 */ set; /* RVA: 0x09D8A8D4 */ }
        System.UInt16 clipTag { get; /* RVA: 0x09D8A4F8 */ set; /* RVA: 0x09D8A888 */ }
        UnityEngine.WrapMode wrapMode { get; /* RVA: 0x025CE310 */ set; /* RVA: 0x09D8A9F8 */ }
        UnityEngine.Bounds localBounds { get; /* RVA: 0x09D8A788 */ set; /* RVA: 0x09D8A9A0 */ }
        System.Boolean legacy { get; /* RVA: 0x09D8A710 */ set; /* RVA: 0x09D8A918 */ }
        System.Boolean humanMotion { get; /* RVA: 0x09D8A6DC */ }
        System.Boolean empty { get; /* RVA: 0x09D8A52C */ }
        System.Boolean hasGenericRootTransform { get; /* RVA: 0x09D8A5D8 */ }
        System.Boolean hasMotionFloatCurves { get; /* RVA: 0x09D8A640 */ }
        System.Boolean hasMotionCurves { get; /* RVA: 0x09D8A60C */ }
        System.Boolean hasRootCurves { get; /* RVA: 0x09D8A674 */ }
        System.Boolean hasRootMotion { get; /* RVA: 0x09D8A6A8 */ }
        System.Boolean transferRotationCompressed { get; /* RVA: 0x09D8A820 */ set; /* RVA: 0x09D8A9B4 */ }
        System.UInt64 uniqueId { get; /* RVA: 0x09D8A854 */ }
        UnityEngine.AnimationEvent[] events { get; /* RVA: 0x09D8A560 */ set; /* RVA: 0x09D8A8CC */ }

        // Methods
        // RVA: 0x033570D0  token: 0x6000090
        public System.Void .ctor() { }
        // RVA: 0x03357130  token: 0x6000091
        private static System.Void Internal_CreateAnimationClip(UnityEngine.AnimationClip self) { }
        // RVA: 0x025CE270  token: 0x6000092
        public System.Void SampleAnimation(UnityEngine.GameObject go, System.Single time) { }
        // RVA: 0x02806BB0  token: 0x6000093
        public System.Void SampleAnimationFast(UnityEngine.GameObject go, System.Single time) { }
        // RVA: 0x025CE350  token: 0x6000094
        private static System.Void SampleAnimation(UnityEngine.GameObject go, UnityEngine.AnimationClip clip, System.Single inTime, UnityEngine.WrapMode wrapMode) { }
        // RVA: 0x02806B40  token: 0x6000095
        private static System.Void SampleAnimationFast(UnityEngine.GameObject go, UnityEngine.AnimationClip clip, System.Single inTime, UnityEngine.WrapMode wrapMode) { }
        // RVA: 0x09D8A450  token: 0x600009D
        public System.Void SetCurve(System.String relativePath, System.Type type, System.String propertyName, UnityEngine.AnimationCurve curve) { }
        // RVA: 0x09D8A394  token: 0x600009E
        public System.Boolean GetAnimatorFloatCurve(System.String propertyName, UnityEngine.AnimationCurve curve) { }
        // RVA: 0x09D8A360  token: 0x600009F
        public System.Void EnsureQuaternionContinuity() { }
        // RVA: 0x09D8A32C  token: 0x60000A0
        public System.Void ClearCurves() { }
        // RVA: 0x09D8A41C  token: 0x60000A1
        public System.UInt32 GetRuntimeMemorySize() { }
        // RVA: 0x09D8A2C0  token: 0x60000B2
        public System.Void AddEvent(UnityEngine.AnimationEvent evt) { }
        // RVA: 0x09D8A27C  token: 0x60000B3
        private System.Void AddEventInternal(System.Object evt) { }
        // RVA: 0x09D8A4B4  token: 0x60000B6
        private System.Void SetEventsInternal(System.Array value) { }
        // RVA: 0x09D8A3E8  token: 0x60000B7
        private System.Array GetEventsInternal() { }
        // RVA: 0x09D8A744  token: 0x60000B8
        private System.Void get_localBounds_Injected(UnityEngine.Bounds& ret) { }
        // RVA: 0x09D8A95C  token: 0x60000B9
        private System.Void set_localBounds_Injected(UnityEngine.Bounds& value) { }

    }

    // TypeToken: 0x2000013  // size: 0x14
    public sealed struct AvatarTarget
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AvatarTarget Root;  // const
        public static UnityEngine.AvatarTarget Body;  // const
        public static UnityEngine.AvatarTarget LeftFoot;  // const
        public static UnityEngine.AvatarTarget RightFoot;  // const
        public static UnityEngine.AvatarTarget LeftHand;  // const
        public static UnityEngine.AvatarTarget RightHand;  // const

    }

    // TypeToken: 0x2000014  // size: 0x14
    public sealed struct AvatarIKGoal
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AvatarIKGoal LeftFoot;  // const
        public static UnityEngine.AvatarIKGoal RightFoot;  // const
        public static UnityEngine.AvatarIKGoal LeftHand;  // const
        public static UnityEngine.AvatarIKGoal RightHand;  // const

    }

    // TypeToken: 0x2000015  // size: 0x14
    public sealed struct AvatarIKHint
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AvatarIKHint LeftKnee;  // const
        public static UnityEngine.AvatarIKHint RightKnee;  // const
        public static UnityEngine.AvatarIKHint LeftElbow;  // const
        public static UnityEngine.AvatarIKHint RightElbow;  // const

    }

    // TypeToken: 0x2000016  // size: 0x14
    public sealed struct AnimatorControllerParameterType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AnimatorControllerParameterType Float;  // const
        public static UnityEngine.AnimatorControllerParameterType Int;  // const
        public static UnityEngine.AnimatorControllerParameterType Bool;  // const
        public static UnityEngine.AnimatorControllerParameterType Trigger;  // const

    }

    // TypeToken: 0x2000017  // size: 0x14
    public sealed struct StateInfoIndex
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.StateInfoIndex CurrentState;  // const
        public static UnityEngine.StateInfoIndex NextState;  // const
        public static UnityEngine.StateInfoIndex ExitState;  // const
        public static UnityEngine.StateInfoIndex InterruptedState;  // const

    }

    // TypeToken: 0x2000018  // size: 0x14
    public sealed struct AnimationBlendStyle
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AnimationBlendStyle Linear;  // const
        public static UnityEngine.AnimationBlendStyle CubicIn;  // const
        public static UnityEngine.AnimationBlendStyle HermiteCubic;  // const
        public static UnityEngine.AnimationBlendStyle Sinusoidal;  // const
        public static UnityEngine.AnimationBlendStyle CubicInOut;  // const

    }

    // TypeToken: 0x2000019  // size: 0x14
    public sealed struct AnimatorTransitionInterruptionSource
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AnimatorTransitionInterruptionSource None;  // const
        public static UnityEngine.AnimatorTransitionInterruptionSource Current;  // const
        public static UnityEngine.AnimatorTransitionInterruptionSource Next;  // const
        public static UnityEngine.AnimatorTransitionInterruptionSource CurrentThenNext;  // const
        public static UnityEngine.AnimatorTransitionInterruptionSource NextThenCurrent;  // const

    }

    // TypeToken: 0x200001A  // size: 0x14
    public sealed struct AnimatorRecorderMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AnimatorRecorderMode Offline;  // const
        public static UnityEngine.AnimatorRecorderMode Playback;  // const
        public static UnityEngine.AnimatorRecorderMode Record;  // const

    }

    // TypeToken: 0x200001B  // size: 0x14
    public sealed struct AnimatorUroMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AnimatorUroMode Origin;  // const
        public static UnityEngine.AnimatorUroMode Predict;  // const
        public static UnityEngine.AnimatorUroMode PredictWithTick;  // const
        public static UnityEngine.AnimatorUroMode PredictWithTickAndRootMotion;  // const

    }

    // TypeToken: 0x200001C  // size: 0x14
    public sealed struct AnimatorCullingMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AnimatorCullingMode AlwaysAnimate;  // const
        public static UnityEngine.AnimatorCullingMode CullUpdateTransforms;  // const
        public static UnityEngine.AnimatorCullingMode CullCompletely;  // const

    }

    // TypeToken: 0x200001D  // size: 0x14
    public sealed struct AnimatorUpdateMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AnimatorUpdateMode Normal;  // const
        public static UnityEngine.AnimatorUpdateMode AnimatePhysics;  // const
        public static UnityEngine.AnimatorUpdateMode UnscaledTime;  // const

    }

    // TypeToken: 0x200001E  // size: 0x14
    public sealed struct AnimatorJobDispatchMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AnimatorJobDispatchMode Default;  // const
        public static UnityEngine.AnimatorJobDispatchMode ForceMainThread;  // const
        public static UnityEngine.AnimatorJobDispatchMode PreUpdate;  // const
        public static UnityEngine.AnimatorJobDispatchMode CrossFrame;  // const
        public static UnityEngine.AnimatorJobDispatchMode CrossFrameLateUpdate;  // const

    }

    // TypeToken: 0x200001F  // size: 0x2C
    public sealed struct AnimatorLOD
    {
        // Fields
        public System.Single worldAbsoluteDistance;  // 0x10
        public System.Single maxDeltaTime;  // 0x14
        public System.Int32 framesPerUpdate;  // 0x18
        public System.Single maxBlendDeltaTime;  // 0x1c
        public System.Int32 framesPerWrite;  // 0x20
        public System.Int32 delayFrame;  // 0x24
        public UnityEngine.AnimatorUroMode uroMode;  // 0x28

        // Methods
        // RVA: 0x03D85A30  token: 0x60000BA
        public System.Void .ctor(System.Single worldAbsoluteDistance, System.Int32 framesPerUpdate, System.Single maxDeltaTime, System.Int32 framesPerWrite, System.Single maxBlendDeltaTime, UnityEngine.AnimatorUroMode uroMode, System.Int32 delayFrame) { }

    }

    // TypeToken: 0x2000020  // size: 0x80
    public sealed struct AnimationTransformRWBufferHandle
    {
        // Fields
        public System.UInt16 count;  // 0x10
        public System.UInt16 invalidCount;  // 0x12
        public System.IntPtr validTransformIndexsPtr;  // 0x18
        public System.IntPtr invalidTransformIndexsPtr;  // 0x20
        public System.IntPtr localPositionsPtr;  // 0x28
        public System.IntPtr localRotationsPtr;  // 0x30
        public System.IntPtr localScalesPtr;  // 0x38
        public System.IntPtr positionsPtr;  // 0x40
        public System.IntPtr rotationsPtr;  // 0x48
        public System.IntPtr scalesPtr;  // 0x50
        public System.IntPtr physicsRatioPtr;  // 0x58
        public System.IntPtr writeFlagPtr;  // 0x60
        public System.IntPtr relativePostionPtr;  // 0x68
        public System.IntPtr relativeRotationPtr;  // 0x70
        public System.IntPtr relativeScalePtr;  // 0x78

    }

    // TypeToken: 0x2000021  // size: 0x58
    public sealed struct HGAnimParameterSGHandle
    {
        // Fields
        public System.Int32 errorCode;  // 0x10
        public System.UInt16 floatParameterCount;  // 0x14
        public System.UInt16 boolParameterCount;  // 0x16
        public System.UInt16 intParameterCount;  // 0x18
        public System.UInt16 layerCount;  // 0x1a
        public System.IntPtr floatParameterNamesPtr;  // 0x20
        public System.IntPtr floatParameterValuesPtr;  // 0x28
        public System.IntPtr boolParameterNamesPtr;  // 0x30
        public System.IntPtr boolParameterValuesPtr;  // 0x38
        public System.IntPtr intParameterNamesPtr;  // 0x40
        public System.IntPtr intParameterValuesPtr;  // 0x48
        public System.IntPtr layerWeightPtr;  // 0x50

    }

    // TypeToken: 0x2000022  // size: 0x14
    public sealed struct AnimFrameSyncMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AnimFrameSyncMode FrameSyncInRootPlayable;  // const
        public static UnityEngine.AnimFrameSyncMode FrameSyncInBaseLayerState;  // const

    }

    // TypeToken: 0x2000023  // size: 0x18
    public sealed struct AnimatorClipInfo
    {
        // Fields
        private System.Int32 m_ClipInstanceID;  // 0x10
        private System.Single m_Weight;  // 0x14

        // Properties
        UnityEngine.AnimationClip clip { get; /* RVA: 0x09D8E144 */ }
        System.Single weight { get; /* RVA: 0x03D85850 */ }

        // Methods
        // RVA: 0x09D8E110  token: 0x60000BD
        private static UnityEngine.AnimationClip InstanceIDToAnimationClipPPtr(System.Int32 instanceID) { }

    }

    // TypeToken: 0x2000024  // size: 0x44
    public sealed struct AnimatorStateInfo
    {
        // Fields
        private System.Int32 m_Name;  // 0x10
        private System.Int32 m_Path;  // 0x14
        private System.Int32 m_FullPath;  // 0x18
        private System.Single m_NormalizedTime;  // 0x1c
        private System.Single m_Length;  // 0x20
        private System.Single m_Speed;  // 0x24
        private System.Single m_SpeedMultiplier;  // 0x28
        private System.Int32 m_Tag;  // 0x2c
        private System.Int32 m_Loop;  // 0x30
        private System.Int32 m_SyncGroup;  // 0x34
        private System.Int32 m_SyncGroupRole;  // 0x38
        private System.Int32 m_CullingMode;  // 0x3c
        private System.Int32 m_SourceMsg;  // 0x40

        // Properties
        System.Int32 fullPathHash { get; /* RVA: 0x03D68070 */ }
        System.Int32 shortNameHash { get; /* RVA: 0x03D85860 */ }
        System.Single normalizedTime { get; /* RVA: 0x03D85A60 */ }
        System.Single length { get; /* RVA: 0x03D85830 */ }
        System.Int32 tagHash { get; /* RVA: 0x03D66B90 */ }
        System.Boolean loop { get; /* RVA: 0x0272C740 */ }

        // Methods
        // RVA: 0x09D8F538  token: 0x60000BE
        public System.Boolean IsName(System.String name) { }
        // RVA: 0x038DF820  token: 0x60000C4
        public System.Boolean IsTag(System.String tag) { }

    }

    // TypeToken: 0x2000025  // size: 0x7C
    public sealed struct AnimatorStateRootMotionInfo
    {
        // Fields
        private System.Int32 m_NameHashLeft;  // 0x10
        private UnityEngine.Vector3 m_DeltaPositionLeft;  // 0x14
        private UnityEngine.Quaternion m_DeltaRotationLeft;  // 0x20
        private System.Int32 m_NameHashRight;  // 0x30
        private UnityEngine.Vector3 m_DeltaPositionRight;  // 0x34
        private UnityEngine.Quaternion m_DeltaRotationRight;  // 0x40
        private System.Single m_TransitionWeight;  // 0x50
        private System.Single m_DeltaTime;  // 0x54
        private System.Single m_InterruptedTransitionWeight;  // 0x58
        private System.Int32 m_NameHashinterrupted;  // 0x5c
        private UnityEngine.Vector3 m_DeltaPositioninterrupted;  // 0x60
        private UnityEngine.Quaternion m_DeltaRotationinterrupted;  // 0x6c

    }

    // TypeToken: 0x2000026  // size: 0x30
    public sealed struct AnimatorTransitionInfo
    {
        // Fields
        private System.Int32 m_FullPath;  // 0x10
        private System.Int32 m_UserName;  // 0x14
        private System.Int32 m_Name;  // 0x18
        private System.Boolean m_HasFixedDuration;  // 0x1c
        private System.Single m_Duration;  // 0x20
        private System.Single m_NormalizedTime;  // 0x24
        private System.Boolean m_AnyState;  // 0x28
        private System.Int32 m_TransitionType;  // 0x2c

        // Properties
        System.Int32 nameHash { get; /* RVA: 0x03D68070 */ }

        // Methods
        // RVA: 0x09D8F568  token: 0x60000C6
        public System.Boolean IsUserName(System.String name) { }

    }

    // TypeToken: 0x2000027  // size: 0x20
    public sealed struct MatchTargetWeightMask
    {
        // Fields
        private UnityEngine.Vector3 m_PositionXYZWeight;  // 0x10
        private System.Single m_RotationWeight;  // 0x1c

        // Methods
        // RVA: 0x02103850  token: 0x60000C8
        public System.Void .ctor(UnityEngine.Vector3 positionXYZWeight, System.Single rotationWeight) { }

    }

    // TypeToken: 0x2000028  // size: 0x48
    public class Animator : UnityEngine.Behaviour
    {
        // Fields
        private UnityEngine.Animator.AnimationEventCallback onAnimationEvent;  // 0x18
        private UnityEngine.Animator.AnimationEventCallbackOpt onAnimationEventOpt;  // 0x20
        private UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStateEnter;  // 0x28
        private UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStateExit;  // 0x30
        private UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStatePreExit;  // 0x38
        private UnityEngine.Animator.AniamtorCommonCallback afterAnimatorUpdateGraphCB;  // 0x40

        // Properties
        System.Boolean fastAnimationEventsOpt { get; /* RVA: 0x09D936F0 */ set; /* RVA: 0x027ACDA0 */ }
        System.Boolean callBackAfterUpdateGraph { get; /* RVA: 0x09D93688 */ set; /* RVA: 0x09D94218 */ }
        System.Boolean fastAnimationEvents { get; /* RVA: 0x09D93724 */ set; /* RVA: 0x027ACDF0 */ }
        System.Boolean notifyAnimatorStateEnterAndExitEvent { get; /* RVA: 0x09D93B40 */ set; /* RVA: 0x0349B3D0 */ }
        System.Boolean keepStateOnChangeActive { get; /* RVA: 0x09D9396C */ set; /* RVA: 0x09D942EC */ }
        System.Boolean pausePlayableOnChangeActive { get; /* RVA: 0x09D93B74 */ set; /* RVA: 0x09D944C4 */ }
        System.Boolean resetControllerPlayableOnChangeActive { get; /* RVA: 0x09D93D04 */ set; /* RVA: 0x09D9454C */ }
        System.Boolean isOptimizable { get; /* RVA: 0x09D938C4 */ }
        System.Boolean isHuman { get; /* RVA: 0x09D93828 */ }
        System.Boolean hasRootMotion { get; /* RVA: 0x09D937C0 */ }
        System.Boolean isRootPositionOrRotationControlledByCurves { get; /* RVA: 0x09D938F8 */ }
        System.Single humanScale { get; /* RVA: 0x09D937F4 */ }
        System.Boolean isInitialized { get; /* RVA: 0x09D9385C */ }
        System.Boolean isVisible { get; /* RVA: 0x02DDAB60 */ }
        System.Boolean updatedLastFrame { get; /* RVA: 0x0287C8A0 */ }
        System.Boolean enableLOD { get; /* RVA: 0x09D936BC */ set; /* RVA: 0x0297B950 */ }
        System.Int32 LODLevel { get; /* RVA: 0x027AFEE0 */ }
        System.Single motionDeltaTime { get; /* RVA: 0x09D93B0C */ }
        UnityEngine.Vector3 deltaPosition { get; /* RVA: 0x02D66490 */ }
        UnityEngine.Quaternion deltaRotation { get; /* RVA: 0x031DEB30 */ }
        UnityEngine.Vector3 velocity { get; /* RVA: 0x02D66330 */ }
        UnityEngine.Vector3 angularVelocity { get; /* RVA: 0x02D663E0 */ }
        UnityEngine.Vector3 rootPosition { get; /* RVA: 0x09D93DB0 */ set; /* RVA: 0x09D945D4 */ }
        UnityEngine.Quaternion rootRotation { get; /* RVA: 0x09D93E20 */ set; /* RVA: 0x09D9462C */ }
        System.Boolean applyRootMotion { get; /* RVA: 0x09D934AC */ set; /* RVA: 0x09D940A4 */ }
        System.Boolean linearVelocityBlending { get; /* RVA: 0x09D93A08 */ set; /* RVA: 0x09D94374 */ }
        System.Boolean animatePhysics { get; /* RVA: 0x09D93460 */ set; /* RVA: 0x09D94040 */ }
        UnityEngine.AnimatorUpdateMode updateMode { get; /* RVA: 0x02DBAAC0 */ set; /* RVA: 0x09D94684 */ }
        System.Boolean hasTransformHierarchy { get; /* RVA: 0x029F0ED0 */ }
        System.Boolean allowConstantClipSamplingOptimization { get; /* RVA: 0x09D9342C */ set; /* RVA: 0x09D93FFC */ }
        System.Single gravityWeight { get; /* RVA: 0x033585D0 */ }
        UnityEngine.Vector3 bodyPosition { get; /* RVA: 0x09D93584 */ set; /* RVA: 0x09D94140 */ }
        UnityEngine.Vector3 bodyPositionInternal { get; /* RVA: 0x09D93558 */ set; /* RVA: 0x09D9412C */ }
        UnityEngine.Quaternion bodyRotation { get; /* RVA: 0x09D93644 */ set; /* RVA: 0x09D941DC */ }
        UnityEngine.Quaternion bodyRotationInternal { get; /* RVA: 0x09D93618 */ set; /* RVA: 0x09D941C8 */ }
        System.Boolean stabilizeFeet { get; /* RVA: 0x09D93E80 */ set; /* RVA: 0x09D94640 */ }
        System.Int32 layerCount { get; /* RVA: 0x02EF2010 */ }
        UnityEngine.AnimatorControllerParameter[] parameters { get; /* RVA: 0x02EEDD70 */ }
        System.Int32 parameterCount { get; /* RVA: 0x03B1FD20 */ }
        System.Single feetPivotActive { get; /* RVA: 0x09D93758 */ set; /* RVA: 0x09D9425C */ }
        System.Single pivotWeight { get; /* RVA: 0x09D93C18 */ }
        UnityEngine.Vector3 pivotPosition { get; /* RVA: 0x09D93BEC */ }
        System.Boolean isMatchingTarget { get; /* RVA: 0x09D93890 */ }
        System.Single timeScale { get; /* RVA: 0x02E68A40 */ set; /* RVA: 0x02B3DE50 */ }
        System.Single speed { get; /* RVA: 0x09D93E4C */ set; /* RVA: 0x02B3DEA0 */ }
        UnityEngine.Vector3 targetPosition { get; /* RVA: 0x09D93F2C */ }
        UnityEngine.Quaternion targetRotation { get; /* RVA: 0x09D93F9C */ }
        UnityEngine.Transform avatarRoot { get; /* RVA: 0x09D934E0 */ }
        UnityEngine.AnimatorCullingMode cullingMode { get; /* RVA: 0x027B2E80 */ set; /* RVA: 0x028069F0 */ }
        System.Single playbackTime { get; /* RVA: 0x09D93C84 */ set; /* RVA: 0x09D94508 */ }
        System.Single recorderStartTime { get; /* RVA: 0x09D93CEC */ set; /* RVA: 0x0350B670 */ }
        System.Single recorderStopTime { get; /* RVA: 0x09D93CF8 */ set; /* RVA: 0x0350B670 */ }
        UnityEngine.AnimatorRecorderMode recorderMode { get; /* RVA: 0x09D93CB8 */ }
        UnityEngine.RuntimeAnimatorController runtimeAnimatorController { get; /* RVA: 0x02B9A040 */ set; /* RVA: 0x02F49A40 */ }
        System.Boolean hasBoundPlayables { get; /* RVA: 0x022B3C10 */ }
        UnityEngine.Avatar avatar { get; /* RVA: 0x022D8D60 */ set; /* RVA: 0x03A508A0 */ }
        UnityEngine.HGSkeletalMorphAvatar morphAvatar { get; /* RVA: 0x09D93AD8 */ set; /* RVA: 0x09D94480 */ }
        UnityEngine.LodBoneMask lodBoneMask { get; /* RVA: 0x09D93A70 */ set; /* RVA: 0x09D943F8 */ }
        System.UInt32 lodBoneMaskLevel { get; /* RVA: 0x09D93A3C */ set; /* RVA: 0x09D943B8 */ }
        UnityEngine.Playables.PlayableGraph playableGraph { get; /* RVA: 0x09D93C4C */ }
        System.Boolean applyMorphPose { get; /* RVA: 0x09D93478 */ set; /* RVA: 0x09D94060 */ }
        System.Boolean layersAffectMassCenter { get; /* RVA: 0x09D939A0 */ set; /* RVA: 0x09D94330 */ }
        System.Single leftFeetBottomHeight { get; /* RVA: 0x09D939D4 */ }
        System.Single rightFeetBottomHeight { get; /* RVA: 0x09D93D38 */ }
        System.Boolean supportsOnAnimatorMove { get; /* RVA: 0x09D93EB4 */ }
        System.Boolean logWarnings { get; /* RVA: 0x09D93AA4 */ set; /* RVA: 0x09D9443C */ }
        System.Boolean fireEvents { get; /* RVA: 0x09D9378C */ set; /* RVA: 0x09D942A0 */ }
        System.Boolean keepAnimatorControllerStateOnDisable { get; /* RVA: 0x09D9392C */ set; /* RVA: 0x09D942E4 */ }
        System.Boolean keepAnimatorStateOnDisable { get; /* RVA: 0x09D93938 */ set; /* RVA: 0x036110E0 */ }
        System.Boolean writeDefaultValuesOnDisable { get; /* RVA: 0x09D93FC8 */ set; /* RVA: 0x02F49830 */ }

        // Methods
        // RVA: 0x09D933E0  token: 0x60000C9
        public System.Void .ctor() { }
        // RVA: 0x09D91708  token: 0x60000CA
        private static System.Void Internal_CallAnimatorStateChangeCallback(UnityEngine.Animator anim, UnityEngine.AnimatorStateInfo animatorStateInfo, System.Int32 layerIndex, System.Int32 methodIdx) { }
        // RVA: 0x09D9169C  token: 0x60000CB
        private static System.Void Internal_CallAfterUpdateGraph(UnityEngine.Animator anim) { }
        // RVA: 0x033D90D0  token: 0x60000CC
        private static System.Boolean Internal_InvokeAnimationEventCallback(UnityEngine.Animator animator, UnityEngine.FastAnimationEvent fastAnimationEvent) { }
        // RVA: 0x028309E0  token: 0x60000CD
        private static System.Boolean Internal_InvokeAnimationEventCallbackOpt(UnityEngine.Animator animator, UnityEngine.FastAnimationEventGroup fastAnimationEvent) { }
        // RVA: 0x03CB2D80  token: 0x60000CE
        public System.Void SetCallbackAfterRootMotionStageCallback(UnityEngine.Animator.AniamtorCommonCallback cb) { }
        // RVA: 0x022C3A90  token: 0x60000CF
        public System.Void SetAnimationEventCallback(UnityEngine.Animator.AnimationEventCallback onAnimationEvent) { }
        // RVA: 0x04271930  token: 0x60000D0
        public System.Void SetAnimationEventCallbackOpt(UnityEngine.Animator.AnimationEventCallbackOpt onAnimationEvent) { }
        // RVA: 0x0349B3A0  token: 0x60000D1
        public System.Void SetNotifyAnimatorStateEnterAndExitEventCallBack(UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStateEnter, UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStateExit) { }
        // RVA: 0x0388FF30  token: 0x60000D2
        public System.Void SetNotifyAnimatorStatePreExitEventCallBack(UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStatePreExit) { }
        // RVA: 0x02EF05A0  token: 0x60000EC
        public System.Boolean SetLODLevel(System.Int32 level) { }
        // RVA: 0x09D90CFC  token: 0x60000ED
        public System.Int32 GetCurrentLODLevel() { }
        // RVA: 0x02DDC330  token: 0x60000EE
        public UnityEngine.AnimatorLOD[] GetLODs() { }
        // RVA: 0x02E38680  token: 0x60000EF
        public System.Void SetLODs(UnityEngine.AnimatorLOD[] lods) { }
        // RVA: 0x09D92394  token: 0x60000F0
        public System.Void SetConstraintEnableImmediately(System.Int32 nameHash) { }
        // RVA: 0x09D92304  token: 0x60000F1
        public System.Void SetConstraintDisableImmediately(System.Int32 nameHash) { }
        // RVA: 0x09D92344  token: 0x60000F2
        public System.Void SetConstraintEnableBlendIn(System.Int32 nameHash, System.Single duration) { }
        // RVA: 0x09D922B4  token: 0x60000F3
        public System.Void SetConstraintDisableBlendOut(System.Int32 nameHash, System.Single duration) { }
        // RVA: 0x0349BCC0  token: 0x60000F4
        public System.Void BecameVisible() { }
        // RVA: 0x03703960  token: 0x60000F5
        public static System.Void SetAnimatorJobOptEnable(System.Boolean enabel) { }
        // RVA: 0x037039A0  token: 0x60000F6
        public static System.Void SetAnimatorJobOptFunc(System.Int32 value) { }
        // RVA: 0x037039E0  token: 0x60000F7
        public static System.Void SetAnimatorWriteTransformOpt(System.Boolean value) { }
        // RVA: 0x03703A20  token: 0x60000F8
        public static System.Void SetGlobalAnimatorClipBindingsOpt(System.Boolean value) { }
        // RVA: 0x03703A60  token: 0x60000F9
        public static System.Void SetGlobalAnimatorClipBindingsConstantOpt(System.Boolean value) { }
        // RVA: 0x03703AA0  token: 0x60000FA
        public static System.Void SetGlobalAnimatorClipBindingsOptByAvatar(System.Boolean value) { }
        // RVA: 0x09D920A0  token: 0x60000FB
        public static System.Void SetAnimatorUroMaxDeltaTimePerframe(System.Single value) { }
        // RVA: 0x03703AE0  token: 0x60000FC
        public static System.Void SetGlobalAnimatorCacheClipBindingsOpt(System.Boolean value) { }
        // RVA: 0x09D906D4  token: 0x60000FD
        public static System.Single GetAnimatorUroMaxDeltaTimePerframe() { }
        // RVA: 0x09D9206C  token: 0x60000FE
        public static System.Void SetAnimatorMainThreadJobCount(System.Int32 value) { }
        // RVA: 0x09D930A0  token: 0x60000FF
        public static System.Void SetPrepareFrameJobBatchCountOpt(System.Int32 value) { }
        // RVA: 0x09D930D4  token: 0x6000100
        public static System.Void SetProcessAnimJobBatchCountOpt(System.Int32 value) { }
        // RVA: 0x03703B20  token: 0x6000101
        public static System.Void SetAnimatorEnableProcessOneStage(System.Boolean value) { }
        // RVA: 0x09D91FD0  token: 0x6000102
        public static System.Void SetAnimatorEnableApplyOnMoveInJob(System.Boolean value) { }
        // RVA: 0x09D92038  token: 0x6000103
        public static System.Void SetAnimatorEnableRequireEventsAndBehaviour(System.Boolean value) { }
        // RVA: 0x09D920DC  token: 0x6000104
        public System.Void SetApplyBuildInRootMotionInJob(System.Boolean enable) { }
        // RVA: 0x03703B60  token: 0x6000105
        public static System.Void SetAnimatorForbbidenApplyOnMoveCb(System.Boolean value) { }
        // RVA: 0x09D92004  token: 0x6000106
        public static System.Void SetAnimatorEnableCrossFrameJobs(System.Boolean enabel) { }
        // RVA: 0x027ABF40  token: 0x6000107
        public System.Void SetAbilityLevel(System.Int32 abilityLevel) { }
        // RVA: 0x027AFEA0  token: 0x6000108
        public System.Int32 GetAbilityLevel() { }
        // RVA: 0x09D93108  token: 0x6000109
        public static System.Void SetSampleClipCacheCreatePreFrameCount(System.Int32 value) { }
        // RVA: 0x09D9313C  token: 0x600010A
        public static System.Void SetSampleClipCacheMaxCount(System.Int32 value) { }
        // RVA: 0x09D92B94  token: 0x600010B
        public System.Void SetLayerMeshSpace(System.Int32 layerIndex, System.Boolean enable) { }
        // RVA: 0x09D912C4  token: 0x600010C
        public System.Boolean GetLayerMeshSpace(System.Int32 layerIndex) { }
        // RVA: 0x09D923D4  token: 0x600010D
        public System.Void SetControllerDefaultValues(System.Boolean value) { }
        // RVA: 0x04271FA0  token: 0x600010E
        public System.Single GetFloat(System.String name) { }
        // RVA: 0x04270C3C  token: 0x600010F
        public System.Single GetFloat(System.Int32 id) { }
        // RVA: 0x09D90E4C  token: 0x6000110
        public System.Single GetFloatFromTransition(System.Int32 layerIndex, System.Int32 id) { }
        // RVA: 0x04275FB0  token: 0x6000111
        public System.Single GetFloatFromTransitionWithDefault(System.Int32 layerIndex, System.Int32 id, System.Single defValue) { }
        // RVA: 0x042706B4  token: 0x6000112
        public System.Void SetFloat(System.String name, System.Single value) { }
        // RVA: 0x09D9274C  token: 0x6000113
        public System.Void SetFloat(System.String name, System.Single value, System.Single dampTime, System.Single deltaTime) { }
        // RVA: 0x04271FAC  token: 0x6000114
        public System.Void SetFloat(System.Int32 id, System.Single value) { }
        // RVA: 0x09D9275C  token: 0x6000115
        public System.Void SetFloat(System.Int32 id, System.Single value, System.Single dampTime, System.Single deltaTime) { }
        // RVA: 0x09D90B34  token: 0x6000116
        public System.Boolean GetBool(System.String name) { }
        // RVA: 0x04274670  token: 0x6000117
        public System.Boolean GetBool(System.Int32 id) { }
        // RVA: 0x04276650  token: 0x6000118
        public System.Void SetBool(System.String name, System.Boolean value) { }
        // RVA: 0x04270030  token: 0x6000119
        public System.Void SetBool(System.Int32 id, System.Boolean value) { }
        // RVA: 0x09D912B8  token: 0x600011A
        public System.Int32 GetInteger(System.String name) { }
        // RVA: 0x0426FFE8  token: 0x600011B
        public System.Int32 GetInteger(System.Int32 id) { }
        // RVA: 0x09D92B8C  token: 0x600011C
        public System.Void SetInteger(System.String name, System.Int32 value) { }
        // RVA: 0x04270028  token: 0x600011D
        public System.Void SetInteger(System.Int32 id, System.Int32 value) { }
        // RVA: 0x0426F564  token: 0x600011E
        public System.Void SetTrigger(System.String name) { }
        // RVA: 0x09D931C8  token: 0x600011F
        public System.Void SetTrigger(System.Int32 id) { }
        // RVA: 0x0426F55C  token: 0x6000120
        public System.Void ResetTrigger(System.String name) { }
        // RVA: 0x04270C34  token: 0x6000121
        public System.Void ResetTrigger(System.Int32 id) { }
        // RVA: 0x09D91A34  token: 0x6000122
        public System.Boolean IsParameterControlledByCurve(System.String name) { }
        // RVA: 0x09D91A40  token: 0x6000123
        public System.Boolean IsParameterControlledByCurve(System.Int32 id) { }
        // RVA: 0x09D91F8C  token: 0x6000136
        public System.Void SetAllowConstantClipSamplingOpt(System.Boolean enable) { }
        // RVA: 0x09D9118C  token: 0x6000142
        public UnityEngine.Vector3 GetIKPosition(UnityEngine.AvatarIKGoal goal) { }
        // RVA: 0x09D90EA8  token: 0x6000143
        private UnityEngine.Vector3 GetGoalPosition(UnityEngine.AvatarIKGoal goal) { }
        // RVA: 0x09D92A5C  token: 0x6000144
        public System.Void SetIKPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition) { }
        // RVA: 0x09D927BC  token: 0x6000145
        private System.Void SetGoalPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition) { }
        // RVA: 0x09D9121C  token: 0x6000146
        public UnityEngine.Quaternion GetIKRotation(UnityEngine.AvatarIKGoal goal) { }
        // RVA: 0x09D90F28  token: 0x6000147
        private UnityEngine.Quaternion GetGoalRotation(UnityEngine.AvatarIKGoal goal) { }
        // RVA: 0x09D92AF0  token: 0x6000148
        public System.Void SetIKRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation) { }
        // RVA: 0x09D92820  token: 0x6000149
        private System.Void SetGoalRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation) { }
        // RVA: 0x09D9115C  token: 0x600014A
        public System.Single GetIKPositionWeight(UnityEngine.AvatarIKGoal goal) { }
        // RVA: 0x09D90F58  token: 0x600014B
        private System.Single GetGoalWeightPosition(UnityEngine.AvatarIKGoal goal) { }
        // RVA: 0x09D92A1C  token: 0x600014C
        public System.Void SetIKPositionWeight(UnityEngine.AvatarIKGoal goal, System.Single value) { }
        // RVA: 0x09D92834  token: 0x600014D
        private System.Void SetGoalWeightPosition(UnityEngine.AvatarIKGoal goal, System.Single value) { }
        // RVA: 0x09D911EC  token: 0x600014E
        public System.Single GetIKRotationWeight(UnityEngine.AvatarIKGoal goal) { }
        // RVA: 0x09D90F98  token: 0x600014F
        private System.Single GetGoalWeightRotation(UnityEngine.AvatarIKGoal goal) { }
        // RVA: 0x09D92AB0  token: 0x6000150
        public System.Void SetIKRotationWeight(UnityEngine.AvatarIKGoal goal, System.Single value) { }
        // RVA: 0x09D92884  token: 0x6000151
        private System.Void SetGoalWeightRotation(UnityEngine.AvatarIKGoal goal, System.Single value) { }
        // RVA: 0x09D910FC  token: 0x6000152
        public UnityEngine.Vector3 GetIKHintPosition(UnityEngine.AvatarIKHint hint) { }
        // RVA: 0x09D9105C  token: 0x6000153
        private UnityEngine.Vector3 GetHintPosition(UnityEngine.AvatarIKHint hint) { }
        // RVA: 0x09D929C8  token: 0x6000154
        public System.Void SetIKHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition) { }
        // RVA: 0x09D92924  token: 0x6000155
        private System.Void SetHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition) { }
        // RVA: 0x09D910CC  token: 0x6000156
        public System.Single GetIKHintPositionWeight(UnityEngine.AvatarIKHint hint) { }
        // RVA: 0x09D9108C  token: 0x6000157
        private System.Single GetHintWeightPosition(UnityEngine.AvatarIKHint hint) { }
        // RVA: 0x09D92988  token: 0x6000158
        public System.Void SetIKHintPositionWeight(UnityEngine.AvatarIKHint hint, System.Single value) { }
        // RVA: 0x09D92938  token: 0x6000159
        private System.Void SetHintWeightPosition(UnityEngine.AvatarIKHint hint, System.Single value) { }
        // RVA: 0x09D92C40  token: 0x600015A
        public System.Void SetLookAtPosition(UnityEngine.Vector3 lookAtPosition) { }
        // RVA: 0x09D92C2C  token: 0x600015B
        private System.Void SetLookAtPositionInternal(UnityEngine.Vector3 lookAtPosition) { }
        // RVA: 0x09D92EB0  token: 0x600015C
        public System.Void SetLookAtWeight(System.Single weight) { }
        // RVA: 0x09D92CEC  token: 0x600015D
        public System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight) { }
        // RVA: 0x09D92E40  token: 0x600015E
        public System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight) { }
        // RVA: 0x09D92D50  token: 0x600015F
        public System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight) { }
        // RVA: 0x09D92DC8  token: 0x6000160
        public System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight) { }
        // RVA: 0x09D92C84  token: 0x6000161
        private System.Void SetLookAtWeightInternal(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight) { }
        // RVA: 0x09D921C8  token: 0x6000162
        public System.Void SetBoneLocalRotation(UnityEngine.HumanBodyBones humanBoneId, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09D921B4  token: 0x6000163
        private System.Void SetBoneLocalRotationInternal(System.Int32 humanBoneId, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09D931C0  token: 0x6000164
        public System.Void SetTransformHierarchy(System.Boolean bHas) { }
        // RVA: 0x03B33D60  token: 0x6000165
        private System.Void SetTransformHierarchyInternal(System.Boolean bHas) { }
        // RVA: 0x09D9083C  token: 0x6000166
        public System.Boolean GetBoneGlobalTRS(System.Int32 avatarAssetBoneID, UnityEngine.AnimationTransformf& trs) { }
        // RVA: 0x09D907EC  token: 0x6000167
        private System.Boolean GetBoneGlobalTRSInternal(System.Int32 avatarAssetBoneID, UnityEngine.AnimationTransformf& trs) { }
        // RVA: 0x09D909A0  token: 0x6000168
        public UnityEngine.AnimationTransformf GetBoneRootTRS(System.Int32 avatarAssetBoneID) { }
        // RVA: 0x09D90968  token: 0x6000169
        private UnityEngine.AnimationTransformf GetBoneRootTRSInternal(System.Int32 avatarAssetBoneID) { }
        // RVA: 0x09D908D0  token: 0x600016A
        public UnityEngine.AnimationTransformf GetBoneLocalTRS(System.Int32 avatarAssetBoneID) { }
        // RVA: 0x09D90898  token: 0x600016B
        private UnityEngine.AnimationTransformf GetBoneLocalTRSInternal(System.Int32 avatarAssetBoneID) { }
        // RVA: 0x09D92418  token: 0x600016C
        public System.Void SetCorrectiveBoneData(UnityEngine.HGCorrectiveBoneData bindings) { }
        // RVA: 0x09D92578  token: 0x600016D
        public System.Void SetEnableCorrectiveBoneSystem(System.Boolean enable) { }
        // RVA: 0x03000FB0  token: 0x600016E
        public System.Void SetSequenceLayerSkipTimeThreshold(System.Single value) { }
        // RVA: 0x09D91550  token: 0x600016F
        public System.Single GetSequenceLayerSkipTimeThreshold() { }
        // RVA: 0x09D90420  token: 0x6000170
        public System.Void ForceUpdateCorrectiveBoneDataInEditor() { }
        // RVA: 0x09D92120  token: 0x6000171
        public System.Void SetBakedBindingData(UnityEngine.HGAnimationSetBindings bindings) { }
        // RVA: 0x09D90338  token: 0x6000172
        public System.Void EnableBakedBindingData(System.Boolean enable) { }
        // RVA: 0x09D9221C  token: 0x6000173
        public System.Boolean SetClipByIndex(UnityEngine.AnimationClip overrideClip, System.Int32 index) { }
        // RVA: 0x09D93324  token: 0x6000174
        public System.Void UnloadClipsNoRebind(UnityEngine.AnimationClip[] overrideClip, System.Boolean clearCache) { }
        // RVA: 0x09D91ED4  token: 0x6000175
        public System.Void ReloadClipsNoRebind(UnityEngine.AnimationClip[] overrideClip) { }
        // RVA: 0x030F6980  token: 0x6000176
        public System.Void CaptureLastHumanPose() { }
        // RVA: 0x03000F60  token: 0x6000177
        public System.Void SetWriteTransformDefAsPostProcess(System.Boolean enable) { }
        // RVA: 0x09D931D0  token: 0x6000178
        public System.Void SetWriteTransformDefAsPostProcessSkipOpt(System.Boolean enable) { }
        // RVA: 0x03850240  token: 0x6000179
        public System.Void SetAnimatorJobDispatchMode(UnityEngine.AnimatorJobDispatchMode mode) { }
        // RVA: 0x09D9054C  token: 0x600017A
        public UnityEngine.AnimatorJobDispatchMode GetAnimatorJobDispatchMode() { }
        // RVA: 0x09D8F58C  token: 0x600017B
        public System.Boolean AddToFrameSyncGroup(System.String groupName, System.Boolean isMaster, UnityEngine.AnimFrameSyncMode syncMode) { }
        // RVA: 0x09D91F18  token: 0x600017C
        public System.Boolean RemoveFromFrameSyncGroup() { }
        // RVA: 0x09D92534  token: 0x600017D
        public System.Void SetEnableCollisionConstraintSolver(System.Boolean enable) { }
        // RVA: 0x09D925BC  token: 0x600017E
        public System.Void SetEnableDefaultValuesForceUseDefaultPose(System.Boolean enable) { }
        // RVA: 0x09D91948  token: 0x600017F
        public System.Boolean IsEnableDefaultValuesForceUseDefaultPose() { }
        // RVA: 0x09D92644  token: 0x6000180
        public System.Void SetEnableWriteDefaultValues(System.Boolean enable) { }
        // RVA: 0x09D924F0  token: 0x6000181
        public System.Void SetEnableClipBindingOpt(System.Boolean enable) { }
        // RVA: 0x09D92600  token: 0x6000182
        public System.Void SetEnableOptBindingByAvatar(System.Boolean enable) { }
        // RVA: 0x02EF34D0  token: 0x6000183
        public System.Boolean AddClipsToBindingsNoGrown(UnityEngine.AnimationClip[] overrideClip, System.Int32 nameHash) { }
        // RVA: 0x02F49A90  token: 0x6000184
        public System.Void SetDynamicBindingReserveCount(System.Int32 count) { }
        // RVA: 0x09D9245C  token: 0x6000185
        public System.Void SetDynamicBindingReserveCountByTag(System.Int32 stringHash, System.Int32 count) { }
        // RVA: 0x09D91E8C  token: 0x6000186
        public System.Void ReCreatePlayableMemory() { }
        // RVA: 0x09D8F854  token: 0x6000187
        public UnityEngine.AnimationTransformRWBufferHandle CreateClothBindings(UnityEngine.Transform[] transformAccessArray) { }
        // RVA: 0x09D8F7B8  token: 0x6000188
        public UnityEngine.AnimationTransformRWBufferHandle CreateClothBindingsByNameLst(System.String[] transformPathArray) { }
        // RVA: 0x09D902D0  token: 0x6000189
        public System.Void DestroyClothBindings() { }
        // RVA: 0x09D9037C  token: 0x600018A
        public System.Void EnableClothBindings() { }
        // RVA: 0x09D90304  token: 0x600018B
        public System.Void DisableClothBindings() { }
        // RVA: 0x09D92270  token: 0x600018C
        public System.Void SetClothBindingsEnableWorldSpace(System.Boolean value) { }
        // RVA: 0x09D8F624  token: 0x600018D
        public System.Boolean CheckClothBindingsEnableWorldSpace() { }
        // RVA: 0x09D92F08  token: 0x600018E
        public System.Void SetMorphBindingsEnableWorldSpace(System.Boolean value) { }
        // RVA: 0x09D8F6FC  token: 0x600018F
        public System.Boolean CheckMorphBindingsEnableWorldSpace() { }
        // RVA: 0x02FADD50  token: 0x6000190
        public UnityEngine.AnimationTransformRWBufferHandle CreateMorphBindings(UnityEngine.Transform[] transformAccessArray) { }
        // RVA: 0x09D8F8F0  token: 0x6000191
        public UnityEngine.AnimationTransformRWBufferHandle CreateMorphBindingsByNameLst(System.String[] transformPathArray) { }
        // RVA: 0x02FADD10  token: 0x6000192
        public System.Void EnableMorphBindings() { }
        // RVA: 0x02F5D9F0  token: 0x6000193
        public System.Void DisableMorphBindings() { }
        // RVA: 0x03627320  token: 0x6000194
        public System.Void SetOptimizedAvatarDataSet(System.Boolean optimized) { }
        // RVA: 0x09D924AC  token: 0x6000195
        public System.Void SetEnabelMorphBindingWriteInLateUpdate(System.Boolean enable) { }
        // RVA: 0x09D90700  token: 0x6000196
        private UnityEngine.ScriptableObject GetBehaviour(System.Type type) { }
        // RVA: -1  // generic def  token: 0x6000197
        public T GetBehaviour() { }
        // RVA: -1  // generic def  token: 0x6000198
        private static T[] ConvertStateMachineBehaviour(UnityEngine.ScriptableObject[] rawObjects) { }
        // RVA: -1  // generic def  token: 0x6000199
        public T[] GetBehaviours() { }
        // RVA: 0x09D91658  token: 0x600019A
        private UnityEngine.ScriptableObject[] InternalGetBehaviours(System.Type type) { }
        // RVA: 0x09D90744  token: 0x600019B
        public UnityEngine.StateMachineBehaviour[] GetBehaviours(System.Int32 fullPathHash, System.Int32 layerIndex) { }
        // RVA: 0x09D915F8  token: 0x600019C
        private UnityEngine.ScriptableObject[] InternalGetBehavioursByKey(System.Int32 fullPathHash, System.Int32 layerIndex, System.Type type) { }
        // RVA: 0x03A2D3F0  token: 0x60001A0
        public System.String GetLayerName(System.Int32 layerIndex) { }
        // RVA: 0x02EF3A40  token: 0x60001A1
        public System.Int32 GetLayerIndex(System.String layerName) { }
        // RVA: 0x09D91304  token: 0x60001A2
        public System.Single GetLayerWeight(System.Int32 layerIndex) { }
        // RVA: 0x03336E20  token: 0x60001A3
        public System.Void SetLayerWeight(System.Int32 layerIndex, System.Single weight) { }
        // RVA: 0x0292F3B0  token: 0x60001A4
        private System.Void GetAnimatorStateInfo(System.Int32 layerIndex, UnityEngine.StateInfoIndex stateInfoIndex, UnityEngine.AnimatorStateInfo& info) { }
        // RVA: 0x0292F300  token: 0x60001A5
        public UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(System.Int32 layerIndex) { }
        // RVA: 0x0292F240  token: 0x60001A6
        public UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(System.Int32 layerIndex) { }
        // RVA: 0x09D90630  token: 0x60001A7
        private System.Void GetAnimatorTransitionInfo(System.Int32 layerIndex, UnityEngine.AnimatorTransitionInfo& info) { }
        // RVA: 0x09D90680  token: 0x60001A8
        public UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfo(System.Int32 layerIndex) { }
        // RVA: 0x09D90498  token: 0x60001A9
        private System.Int32 GetAnimatorClipInfoCount(System.Int32 layerIndex, System.Boolean current) { }
        // RVA: 0x09D90B40  token: 0x60001AA
        public System.Int32 GetCurrentAnimatorClipInfoCount(System.Int32 layerIndex) { }
        // RVA: 0x09D913F0  token: 0x60001AB
        public System.Int32 GetNextAnimatorClipInfoCount(System.Int32 layerIndex) { }
        // RVA: 0x09D90BC8  token: 0x60001AC
        public UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(System.Int32 layerIndex) { }
        // RVA: 0x09D91478  token: 0x60001AD
        public UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo(System.Int32 layerIndex) { }
        // RVA: 0x09D90D90  token: 0x60001AE
        public System.Boolean GetDebugAnimatorClipInfo(System.Int32 layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) { }
        // RVA: 0x09D90B50  token: 0x60001AF
        public System.Void GetCurrentAnimatorClipInfo(System.Int32 layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) { }
        // RVA: 0x09D904EC  token: 0x60001B0
        private System.Void GetAnimatorClipInfoInternal(System.Int32 layerIndex, System.Boolean isCurrent, System.Object clips) { }
        // RVA: 0x09D90D40  token: 0x60001B1
        private System.Boolean GetDebugAnimatorClipInfoInternal(System.Int32 layerIndex, System.Object clips) { }
        // RVA: 0x09D91400  token: 0x60001B2
        public System.Void GetNextAnimatorClipInfo(System.Int32 layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) { }
        // RVA: 0x0292F420  token: 0x60001B3
        public System.Boolean IsInTransition(System.Int32 layerIndex) { }
        // RVA: 0x02931680  token: 0x60001B4
        public System.Boolean IsPlayingTag(System.Int32 layerIndex, System.Int32 tagHash) { }
        // RVA: 0x0272A910  token: 0x60001B5
        public System.Boolean IsPlayingState(System.Int32 layerIndex, System.Int32 stateNameHash) { }
        // RVA: 0x029318B0  token: 0x60001B6
        public System.Int32 GetAnimatorStateCullMode(System.Int32 layerIndex) { }
        // RVA: 0x09D90C08  token: 0x60001B7
        public UnityEngine.AnimatorStateRootMotionInfo GetCurrentAnimatorStateRootmotionInfo(System.Int32 layerIndex) { }
        // RVA: 0x09D905E0  token: 0x60001B8
        private System.Void GetAnimatorStateRootMotionInfo(System.Int32 layerIndex, UnityEngine.AnimatorStateRootMotionInfo& output) { }
        // RVA: 0x09D915B8  token: 0x60001B9
        public System.Boolean HasTrigger(System.Int32 triggerId) { }
        // RVA: 0x039DD090  token: 0x60001BC
        private UnityEngine.AnimatorControllerParameter GetParameterInternal(System.Int32 index) { }
        // RVA: 0x039DD050  token: 0x60001BD
        public UnityEngine.AnimatorControllerParameter GetParameter(System.Int32 index) { }
        // RVA: 0x09D91BA8  token: 0x60001C2
        private System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, System.Int32 targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch) { }
        // RVA: 0x09D91B2C  token: 0x60001C3
        public System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime) { }
        // RVA: 0x09D91AB0  token: 0x60001C4
        public System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime) { }
        // RVA: 0x09D91BF8  token: 0x60001C5
        public System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch) { }
        // RVA: 0x09D918F8  token: 0x60001C6
        public System.Void InterruptMatchTarget() { }
        // RVA: 0x09D918B4  token: 0x60001C7
        public System.Void InterruptMatchTarget(System.Boolean completeMatch) { }
        // RVA: 0x09D90400  token: 0x60001CD
        public System.Void ForceStateNormalizedTime(System.Single normalizedTime) { }
        // RVA: 0x09D8FCDC  token: 0x60001CE
        public System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration) { }
        // RVA: 0x09D8FAA0  token: 0x60001CF
        public System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer) { }
        // RVA: 0x09D8FBAC  token: 0x60001D0
        public System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset) { }
        // RVA: 0x09D8FAFC  token: 0x60001D1
        public System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        // RVA: 0x09D8F9A4  token: 0x60001D2
        public System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        // RVA: 0x09D8FD2C  token: 0x60001D3
        public System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource, System.Boolean enableBlendRootMotion) { }
        // RVA: 0x09D8FA1C  token: 0x60001D4
        public System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        // RVA: 0x09D8FB6C  token: 0x60001D5
        public System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime) { }
        // RVA: 0x09D8FC10  token: 0x60001D6
        public System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset) { }
        // RVA: 0x09D8F938  token: 0x60001D7
        public System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer) { }
        // RVA: 0x09D8F96C  token: 0x60001D8
        public System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration) { }
        // RVA: 0x09D8FC4C  token: 0x60001D9
        public System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        // RVA: 0x0278DC00  token: 0x60001DA
        public System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        // RVA: 0x09D8FC98  token: 0x60001DB
        public System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        // RVA: 0x0278DC50  token: 0x60001DC
        public System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource, System.Boolean enableBlendRootMotion) { }
        // RVA: 0x09D933AC  token: 0x60001DD
        public System.Void WriteDefaultValues() { }
        // RVA: 0x02D27BF0  token: 0x60001DE
        public System.Void WriteDefaultValuesDirty() { }
        // RVA: 0x09D90188  token: 0x60001DF
        public System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime) { }
        // RVA: 0x09D8FEA0  token: 0x60001E0
        public System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset) { }
        // RVA: 0x09D8FE6C  token: 0x60001E1
        public System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer) { }
        // RVA: 0x09D90100  token: 0x60001E2
        public System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration) { }
        // RVA: 0x09D901C4  token: 0x60001E3
        public System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource, System.Boolean enableBlendRootMotion) { }
        // RVA: 0x09D8FDB0  token: 0x60001E4
        public System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        // RVA: 0x09D90004  token: 0x60001E5
        public System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        // RVA: 0x09D9007C  token: 0x60001E6
        public System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        // RVA: 0x09D8FF64  token: 0x60001E7
        public System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource, System.Boolean enableBlendRootMotion) { }
        // RVA: 0x09D8FED8  token: 0x60001E8
        public System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime) { }
        // RVA: 0x09D90248  token: 0x60001E9
        public System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset) { }
        // RVA: 0x09D8FE30  token: 0x60001EA
        public System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer) { }
        // RVA: 0x09D8FFC4  token: 0x60001EB
        public System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration) { }
        // RVA: 0x09D9013C  token: 0x60001EC
        public System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        // RVA: 0x09D8FF18  token: 0x60001ED
        public System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        // RVA: 0x09D90284  token: 0x60001EE
        public System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        // RVA: 0x03CB7F70  token: 0x60001EF
        public System.Void ResetToDefaultStates() { }
        // RVA: 0x09D91D7C  token: 0x60001F0
        public System.Void PlayInFixedTime(System.String stateName, System.Int32 layer) { }
        // RVA: 0x09D91D04  token: 0x60001F1
        public System.Void PlayInFixedTime(System.String stateName) { }
        // RVA: 0x09D91D2C  token: 0x60001F2
        public System.Void PlayInFixedTime(System.String stateName, System.Int32 layer, System.Single fixedTime) { }
        // RVA: 0x09D91D9C  token: 0x60001F3
        public System.Void PlayInFixedTime(System.Int32 stateNameHash, System.Int32 layer, System.Single fixedTime) { }
        // RVA: 0x09D91CE4  token: 0x60001F4
        public System.Void PlayInFixedTime(System.Int32 stateNameHash, System.Int32 layer) { }
        // RVA: 0x09D91DFC  token: 0x60001F5
        public System.Void PlayInFixedTime(System.Int32 stateNameHash) { }
        // RVA: 0x09D91E24  token: 0x60001F6
        public System.Void Play(System.String stateName, System.Int32 layer) { }
        // RVA: 0x0285CE40  token: 0x60001F7
        public System.Void Play(System.String stateName) { }
        // RVA: 0x0285D3C0  token: 0x60001F8
        public System.Void Play(System.String stateName, System.Int32 layer, System.Single normalizedTime) { }
        // RVA: 0x0285D410  token: 0x60001F9
        public System.Void Play(System.Int32 stateNameHash, System.Int32 layer, System.Single normalizedTime) { }
        // RVA: 0x09D91E44  token: 0x60001FA
        public System.Void Play(System.Int32 stateNameHash, System.Int32 layer) { }
        // RVA: 0x09D91E64  token: 0x60001FB
        public System.Void Play(System.Int32 stateNameHash) { }
        // RVA: 0x09D93170  token: 0x60001FC
        public System.Void SetTarget(UnityEngine.AvatarTarget targetIndex, System.Single targetNormalizedTime) { }
        // RVA: 0x03D4E3A0  token: 0x60001FF
        public System.Boolean IsControlled(UnityEngine.Transform transform) { }
        // RVA: 0x09D91904  token: 0x6000200
        private System.Boolean IsBoneTransform(UnityEngine.Transform transform) { }
        // RVA: 0x09D90A28  token: 0x6000202
        public UnityEngine.Transform GetBoneTransform(UnityEngine.HumanBodyBones humanBoneId) { }
        // RVA: 0x09D909E8  token: 0x6000203
        private UnityEngine.Transform GetBoneTransformInternal(System.Int32 humanBoneId) { }
        // RVA: 0x029F0300  token: 0x6000204
        public UnityEngine.Transform GetBoneTransformByBoneId(System.Int32 boneID) { }
        // RVA: 0x029F02B0  token: 0x6000205
        private UnityEngine.Transform GetBoneTransformByBoneIdInternal(System.Int32 boneId) { }
        // RVA: 0x09D93214  token: 0x6000208
        public System.Void StartPlayback() { }
        // RVA: 0x09D93288  token: 0x6000209
        public System.Void StopPlayback() { }
        // RVA: 0x09D93248  token: 0x600020C
        public System.Void StartRecording(System.Int32 frameCount) { }
        // RVA: 0x09D932BC  token: 0x600020D
        public System.Void StopRecording() { }
        // RVA: 0x09D914E8  token: 0x6000210
        private System.Single GetRecorderStartTime() { }
        // RVA: 0x09D9151C  token: 0x6000213
        private System.Single GetRecorderStopTime() { }
        // RVA: 0x09D8F730  token: 0x6000218
        private System.Void ClearInternalControllerPlayable() { }
        // RVA: 0x02F496D0  token: 0x6000219
        public System.Boolean HasState(System.Int32 layerIndex, System.Int32 stateID) { }
        // RVA: 0x0291C100  token: 0x600021A
        public static System.Int32 StringToHash(System.String name) { }
        // RVA: 0x09D932F0  token: 0x600021B
        public static System.Int32 StringToHashCRC32(System.IntPtr name) { }
        // RVA: 0x09D91584  token: 0x6000224
        private System.String GetStats() { }
        // RVA: 0x09D90CB8  token: 0x6000226
        private System.Void GetCurrentGraph(UnityEngine.Playables.PlayableGraph& graph) { }
        // RVA: 0x09D8F68C  token: 0x6000227
        private System.Void CheckIfInIKPass() { }
        // RVA: 0x09D9197C  token: 0x6000228
        private System.Boolean IsInIKPass() { }
        // RVA: 0x030FDBE0  token: 0x6000229
        private System.Void SetFloatString(System.String name, System.Single value) { }
        // RVA: 0x02EECE10  token: 0x600022A
        private System.Void SetFloatID(System.Int32 id, System.Single value) { }
        // RVA: 0x03300150  token: 0x600022B
        private System.Single GetFloatString(System.String name) { }
        // RVA: 0x02D85B80  token: 0x600022C
        private System.Single GetFloatID(System.Int32 id) { }
        // RVA: 0x09D90DFC  token: 0x600022D
        private System.Single GetFloatFromTransitionByID(System.Int32 layerIndex, System.Int32 id) { }
        // RVA: 0x036C6D20  token: 0x600022E
        private System.Single GetFloatFromTransitionByIDWithDefault(System.Int32 layerIndex, System.Int32 id, System.Single defValue) { }
        // RVA: 0x038D1DC0  token: 0x600022F
        private System.Void SetBoolString(System.String name, System.Boolean value) { }
        // RVA: 0x0349AD90  token: 0x6000230
        private System.Void SetBoolID(System.Int32 id, System.Boolean value) { }
        // RVA: 0x09D90AF0  token: 0x6000231
        private System.Boolean GetBoolString(System.String name) { }
        // RVA: 0x032DA0C0  token: 0x6000232
        private System.Boolean GetBoolID(System.Int32 id) { }
        // RVA: 0x09D92B38  token: 0x6000233
        private System.Void SetIntegerString(System.String name, System.Int32 value) { }
        // RVA: 0x03856710  token: 0x6000234
        private System.Void SetIntegerID(System.Int32 id, System.Int32 value) { }
        // RVA: 0x09D91274  token: 0x6000235
        private System.Int32 GetIntegerString(System.String name) { }
        // RVA: 0x032707D0  token: 0x6000236
        private System.Int32 GetIntegerID(System.Int32 id) { }
        // RVA: 0x03495FC0  token: 0x6000237
        private System.Void SetTriggerString(System.String name) { }
        // RVA: 0x038E93C0  token: 0x6000238
        private System.Void SetTriggerID(System.Int32 id) { }
        // RVA: 0x03295E30  token: 0x6000239
        private System.Void ResetTriggerString(System.String name) { }
        // RVA: 0x02E97050  token: 0x600023A
        private System.Void ResetTriggerID(System.Int32 id) { }
        // RVA: 0x09D919F0  token: 0x600023B
        private System.Boolean IsParameterControlledByCurveString(System.String name) { }
        // RVA: 0x09D919B0  token: 0x600023C
        private System.Boolean IsParameterControlledByCurveID(System.Int32 id) { }
        // RVA: 0x09D926E8  token: 0x600023D
        private System.Void SetFloatStringDamp(System.String name, System.Single value, System.Single dampTime, System.Single deltaTime) { }
        // RVA: 0x09D92688  token: 0x600023E
        private System.Void SetFloatIDDamp(System.Int32 id, System.Single value, System.Single dampTime, System.Single deltaTime) { }
        // RVA: 0x09D90FD8  token: 0x600023F
        public UnityEngine.HGAnimParameterSGHandle[] GetHGParameterHandles() { }
        // RVA: 0x09D8F658  token: 0x6000240
        public System.Boolean CheckHGParmeterHandleValid() { }
        // RVA: 0x09D91344  token: 0x6000243
        public System.Int32 GetMorphBoneCount() { }
        // RVA: 0x09D913CC  token: 0x6000244
        public System.Void GetMorphBoneIds(Unity.Collections.NativeArray<System.Int32> arrayToFill) { }
        // RVA: 0x09D91378  token: 0x6000245
        public System.Void GetMorphBoneIdsUnsafe(System.Int32 count, Unity.Collections.NativeArray<System.Int32> arrayToFill) { }
        // RVA: 0x09D91804  token: 0x6000246
        private System.Void Internal_GetMorphBoneIds(System.Int32 count, System.IntPtr arrayToFill) { }
        // RVA: 0x09D93048  token: 0x6000247
        public System.Void SetMorphTransforms(Unity.Collections.NativeArray<System.Int32> boneIds, Unity.Collections.NativeArray<UnityEngine.Vector3> translation, Unity.Collections.NativeArray<UnityEngine.Vector3> euler, Unity.Collections.NativeArray<UnityEngine.Vector3> scale) { }
        // RVA: 0x09D92F4C  token: 0x6000248
        public System.Void SetMorphTransformsUnsafe(Unity.Collections.NativeArray<System.Int32> boneIds, Unity.Collections.NativeArray<UnityEngine.Vector3> translation, Unity.Collections.NativeArray<UnityEngine.Vector3> euler, Unity.Collections.NativeArray<UnityEngine.Vector3> scale) { }
        // RVA: 0x09D91854  token: 0x6000249
        private System.Void Internal_SetMorphTransforms(System.Int32 count, System.IntPtr boneIds, System.IntPtr translation, System.IntPtr euler, System.IntPtr scale) { }
        // RVA: 0x09D91CB0  token: 0x600024F
        private System.Void OnUpdateModeChanged() { }
        // RVA: 0x09D91C7C  token: 0x6000250
        private System.Void OnCullingModeChanged() { }
        // RVA: 0x09D93378  token: 0x6000251
        private System.Void WriteDefaultPose() { }
        // RVA: 0x033D4680  token: 0x6000252
        public System.Void Update(System.Single deltaTime) { }
        // RVA: 0x09D90454  token: 0x6000253
        public System.Void ForceUpdate(System.Single deltaTime) { }
        // RVA: 0x09D91EC0  token: 0x6000254
        public System.Void Rebind() { }
        // RVA: 0x03D00B20  token: 0x6000255
        private System.Void Rebind(System.Boolean writeDefaultValues) { }
        // RVA: 0x09D8F5F0  token: 0x6000256
        public System.Void ApplyBuiltinRootMotion() { }
        // RVA: 0x09D903F4  token: 0x6000257
        private System.Void EvaluateController() { }
        // RVA: 0x09D903B0  token: 0x6000258
        private System.Void EvaluateController(System.Single deltaTime) { }
        // RVA: 0x09D90D30  token: 0x6000259
        private System.String GetCurrentStateName(System.Int32 layerIndex) { }
        // RVA: 0x09D914B8  token: 0x600025A
        private System.String GetNextStateName(System.Int32 layerIndex) { }
        // RVA: 0x09D9058C  token: 0x600025B
        private System.String GetAnimatorStateName(System.Int32 layerIndex, System.Boolean current) { }
        // RVA: 0x09D91F4C  token: 0x600025C
        private System.String ResolveHash(System.Int32 hash) { }
        // RVA: 0x09D90580  token: 0x600025D
        public System.String GetAnimatorStateName(System.Int32 stateID) { }
        // RVA: 0x04276254  token: 0x600025E
        public System.Void GotoState(System.Int32 layer, System.Int32 stateId, System.Single normalizedTime, System.Single transitionDuration, System.Single transitionTime, UnityEngine.AnimationBlendStyle blendStyle) { }
        // RVA: 0x04270040  token: 0x600025F
        public System.Void GotoStateInFixedTime(System.Int32 layerIndex, System.Int32 stateId, System.Single fixedTime, System.Single fixedTransitionDuration, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle) { }
        // RVA: 0x04274798  token: 0x6000260
        public System.Void SetAnimationStateOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride, System.Boolean rebind) { }
        // RVA: 0x04270038  token: 0x6000261
        public System.Void RefreshStateOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride) { }
        // RVA: 0x04272C58  token: 0x6000262
        public System.Void SetRuntimeControllerNoRebind(UnityEngine.RuntimeAnimatorController controller) { }
        // RVA: 0x09D91ECC  token: 0x6000263
        public System.Void RefreshAnimationStateAsyncCompleteOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride) { }
        // RVA: 0x03C8F890  token: 0x6000264
        private System.Void Internal_GotoState(System.Int32 layer, System.Int32 stateId, System.Single normalizedTime, System.Single transitionDuration, System.Single transitionTime, UnityEngine.AnimationBlendStyle blendStyle) { }
        // RVA: 0x03C8F900  token: 0x6000265
        private System.Void Internal_GotoStateInFixedTime(System.Int32 layerIndex, System.Int32 stateId, System.Single fixedTime, System.Single fixedTransitionDuration, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle) { }
        // RVA: 0x039CF8F0  token: 0x6000266
        private System.Void Internal_SetAnimationStateOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride, System.Boolean rebind) { }
        // RVA: 0x03CA4370  token: 0x6000267
        private System.Void Internal_RefreshAnimationStateOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride) { }
        // RVA: 0x03CA4320  token: 0x6000268
        private System.Void Internal_SetRuntimeControllerNoRebind(UnityEngine.RuntimeAnimatorController controller) { }
        // RVA: 0x03B13590  token: 0x6000269
        private System.Void Internal_RefreshAnimationStateAsyncCompleteOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride) { }
        // RVA: 0x04275140  token: 0x600026A
        public System.Void SetAvatarNoBind(UnityEngine.Avatar avatar) { }
        // RVA: 0x03626660  token: 0x600026B
        private System.Void Internal_SetAvatarNoBind(UnityEngine.Avatar avatar) { }
        // RVA: 0x03D86AF0  token: 0x6000276
        public UnityEngine.Vector3 GetVector(System.String name) { }
        // RVA: 0x03D86AF0  token: 0x6000277
        public UnityEngine.Vector3 GetVector(System.Int32 id) { }
        // RVA: 0x0350B670  token: 0x6000278
        public System.Void SetVector(System.String name, UnityEngine.Vector3 value) { }
        // RVA: 0x0350B670  token: 0x6000279
        public System.Void SetVector(System.Int32 id, UnityEngine.Vector3 value) { }
        // RVA: 0x09D914C8  token: 0x600027A
        public UnityEngine.Quaternion GetQuaternion(System.String name) { }
        // RVA: 0x09D914C8  token: 0x600027B
        public UnityEngine.Quaternion GetQuaternion(System.Int32 id) { }
        // RVA: 0x0350B670  token: 0x600027C
        public System.Void SetQuaternion(System.String name, UnityEngine.Quaternion value) { }
        // RVA: 0x0350B670  token: 0x600027D
        public System.Void SetQuaternion(System.Int32 id, UnityEngine.Quaternion value) { }
        // RVA: 0x02D664F0  token: 0x600027E
        private System.Void get_deltaPosition_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x031DEB90  token: 0x600027F
        private System.Void get_deltaRotation_Injected(UnityEngine.Quaternion& ret) { }
        // RVA: 0x02D66390  token: 0x6000280
        private System.Void get_velocity_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x02D66440  token: 0x6000281
        private System.Void get_angularVelocity_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x09D93D6C  token: 0x6000282
        private System.Void get_rootPosition_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x09D94590  token: 0x6000283
        private System.Void set_rootPosition_Injected(UnityEngine.Vector3& value) { }
        // RVA: 0x09D93DDC  token: 0x6000284
        private System.Void get_rootRotation_Injected(UnityEngine.Quaternion& ret) { }
        // RVA: 0x09D945E8  token: 0x6000285
        private System.Void set_rootRotation_Injected(UnityEngine.Quaternion& value) { }
        // RVA: 0x09D93514  token: 0x6000286
        private System.Void get_bodyPositionInternal_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x09D940E8  token: 0x6000287
        private System.Void set_bodyPositionInternal_Injected(UnityEngine.Vector3& value) { }
        // RVA: 0x09D935D4  token: 0x6000288
        private System.Void get_bodyRotationInternal_Injected(UnityEngine.Quaternion& ret) { }
        // RVA: 0x09D94184  token: 0x6000289
        private System.Void set_bodyRotationInternal_Injected(UnityEngine.Quaternion& value) { }
        // RVA: 0x09D90E58  token: 0x600028A
        private System.Void GetGoalPosition_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3& ret) { }
        // RVA: 0x09D9276C  token: 0x600028B
        private System.Void SetGoalPosition_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3& goalPosition) { }
        // RVA: 0x09D90ED8  token: 0x600028C
        private System.Void GetGoalRotation_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion& ret) { }
        // RVA: 0x09D927D0  token: 0x600028D
        private System.Void SetGoalRotation_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion& goalRotation) { }
        // RVA: 0x09D9100C  token: 0x600028E
        private System.Void GetHintPosition_Injected(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3& ret) { }
        // RVA: 0x09D928D4  token: 0x600028F
        private System.Void SetHintPosition_Injected(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3& hintPosition) { }
        // RVA: 0x09D92BE8  token: 0x6000290
        private System.Void SetLookAtPositionInternal_Injected(UnityEngine.Vector3& lookAtPosition) { }
        // RVA: 0x09D92164  token: 0x6000291
        private System.Void SetBoneLocalRotationInternal_Injected(System.Int32 humanBoneId, UnityEngine.Quaternion& rotation) { }
        // RVA: 0x09D90918  token: 0x6000292
        private System.Void GetBoneRootTRSInternal_Injected(System.Int32 avatarAssetBoneID, UnityEngine.AnimationTransformf& ret) { }
        // RVA: 0x09D90848  token: 0x6000293
        private System.Void GetBoneLocalTRSInternal_Injected(System.Int32 avatarAssetBoneID, UnityEngine.AnimationTransformf& ret) { }
        // RVA: 0x09D8F800  token: 0x6000294
        private System.Void CreateClothBindings_Injected(UnityEngine.Transform[] transformAccessArray, UnityEngine.AnimationTransformRWBufferHandle& ret) { }
        // RVA: 0x09D8F764  token: 0x6000295
        private System.Void CreateClothBindingsByNameLst_Injected(System.String[] transformPathArray, UnityEngine.AnimationTransformRWBufferHandle& ret) { }
        // RVA: 0x02FADCB0  token: 0x6000296
        private System.Void CreateMorphBindings_Injected(UnityEngine.Transform[] transformAccessArray, UnityEngine.AnimationTransformRWBufferHandle& ret) { }
        // RVA: 0x09D8F89C  token: 0x6000297
        private System.Void CreateMorphBindingsByNameLst_Injected(System.String[] transformPathArray, UnityEngine.AnimationTransformRWBufferHandle& ret) { }
        // RVA: 0x09D93BA8  token: 0x6000298
        private System.Void get_pivotPosition_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x09D91A4C  token: 0x6000299
        private System.Void MatchTarget_Injected(UnityEngine.Vector3& matchPosition, UnityEngine.Quaternion& matchRotation, System.Int32 targetBodyPart, UnityEngine.MatchTargetWeightMask& weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch) { }
        // RVA: 0x09D93EE8  token: 0x600029A
        private System.Void get_targetPosition_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x09D93F58  token: 0x600029B
        private System.Void get_targetRotation_Injected(UnityEngine.Quaternion& ret) { }

    }

    // TypeToken: 0x200002D  // size: 0x28
    public class AnimatorControllerParameter
    {
        // Fields
        private System.String m_Name;  // 0x10
        private UnityEngine.AnimatorControllerParameterType m_Type;  // 0x18
        private System.Single m_DefaultFloat;  // 0x1c
        private System.Int32 m_DefaultInt;  // 0x20
        private System.Boolean m_DefaultBool;  // 0x24

        // Properties
        System.String name { get; /* RVA: 0x03D66B80 */ }
        System.Int32 nameHash { get; /* RVA: 0x04274684 */ }
        UnityEngine.AnimatorControllerParameterType type { get; /* RVA: 0x03D68AE0 */ }

        // Methods
        // RVA: 0x09D8E160  token: 0x60002A7
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x06FAB9A8  token: 0x60002A8
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09D8E1F8  token: 0x60002A9
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002E  // size: 0x20
    public class AnimationClipPair
    {
        // Fields
        public UnityEngine.AnimationClip originalClip;  // 0x10
        public UnityEngine.AnimationClip overrideClip;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60002AA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002F  // size: 0x20
    public class AnimatorOverrideController : UnityEngine.RuntimeAnimatorController
    {
        // Fields
        private UnityEngine.AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty;  // 0x18

        // Properties
        UnityEngine.RuntimeAnimatorController runtimeAnimatorController { get; /* RVA: 0x09D8F350 */ set; /* RVA: 0x09D8F4AC */ }
        UnityEngine.AnimationClip Item { get; /* RVA: 0x09D8F15C */ set; /* RVA: 0x09D8F3A0 */ }
        UnityEngine.AnimationClip Item { get; /* RVA: 0x09D8F15C */ set; /* RVA: 0x09D8F3A0 */ }
        System.Boolean enableBindingOpt { get; /* RVA: 0x09D8F2B4 */ set; /* RVA: 0x09D8F424 */ }
        System.Byte reserveCount { get; /* RVA: 0x09D8F31C */ set; /* RVA: 0x09D8F468 */ }
        System.Int32 overridesCount { get; /* RVA: 0x09D8F2E8 */ }
        UnityEngine.AnimationClipPair[] clips { get; /* RVA: 0x09D8F16C */ set; /* RVA: 0x09D8F3A8 */ }

        // Methods
        // RVA: 0x09D8F0D8  token: 0x60002AB
        public System.Void .ctor() { }
        // RVA: 0x09D8F10C  token: 0x60002AC
        public System.Void .ctor(UnityEngine.RuntimeAnimatorController controller) { }
        // RVA: 0x09D8EEF4  token: 0x60002AD
        private static System.Void Internal_Create(UnityEngine.AnimatorOverrideController self, UnityEngine.RuntimeAnimatorController controller) { }
        // RVA: 0x09D8EF38  token: 0x60002B2
        private UnityEngine.AnimationClip Internal_GetClipByName(System.String name, System.Boolean returnEffectiveClip) { }
        // RVA: 0x09D8EF8C  token: 0x60002B3
        private System.Void Internal_SetClipByName(System.String name, UnityEngine.AnimationClip clip) { }
        // RVA: 0x09D8EC98  token: 0x60002BA
        private UnityEngine.AnimationClip GetClip(UnityEngine.AnimationClip originalClip, System.Boolean returnEffectiveClip) { }
        // RVA: 0x09D8F074  token: 0x60002BB
        private System.Void SetClip(UnityEngine.AnimationClip originalClip, UnityEngine.AnimationClip overrideClip, System.Boolean notify) { }
        // RVA: 0x09D8F040  token: 0x60002BC
        private System.Void SendNotification() { }
        // RVA: 0x09D8ECEC  token: 0x60002BD
        private UnityEngine.AnimationClip GetOriginalClip(System.Int32 index) { }
        // RVA: 0x09D8ED2C  token: 0x60002BE
        private UnityEngine.AnimationClip GetOverrideClip(UnityEngine.AnimationClip originalClip) { }
        // RVA: 0x09D8ED70  token: 0x60002C0
        public System.Void GetOverrides(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides) { }
        // RVA: 0x09D8EB6C  token: 0x60002C1
        public System.Void ApplyOverrides(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides) { }
        // RVA: 0x09D8F00C  token: 0x60002C4
        private System.Void PerformOverrideClipListCleanup() { }
        // RVA: 0x09D8EFE0  token: 0x60002C5
        private static System.Void OnInvalidateOverrideController(UnityEngine.AnimatorOverrideController controller) { }

    }

    // TypeToken: 0x2000031  // size: 0x10
    public class AnimatorUtility
    {
        // Methods
        // RVA: 0x03627370  token: 0x60002C8
        public static System.Void OptimizeTransformHierarchy(UnityEngine.GameObject go, System.String[] exposedTransforms) { }
        // RVA: 0x03C7DB90  token: 0x60002C9
        public static System.Void DeoptimizeTransformHierarchy(UnityEngine.GameObject go) { }

    }

    // TypeToken: 0x2000032  // size: 0x14
    public sealed struct HumanBodyBones
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.HumanBodyBones Hips;  // const
        public static UnityEngine.HumanBodyBones LeftUpperLeg;  // const
        public static UnityEngine.HumanBodyBones RightUpperLeg;  // const
        public static UnityEngine.HumanBodyBones LeftLowerLeg;  // const
        public static UnityEngine.HumanBodyBones RightLowerLeg;  // const
        public static UnityEngine.HumanBodyBones LeftFoot;  // const
        public static UnityEngine.HumanBodyBones RightFoot;  // const
        public static UnityEngine.HumanBodyBones Spine;  // const
        public static UnityEngine.HumanBodyBones Chest;  // const
        public static UnityEngine.HumanBodyBones UpperChest;  // const
        public static UnityEngine.HumanBodyBones Neck;  // const
        public static UnityEngine.HumanBodyBones Head;  // const
        public static UnityEngine.HumanBodyBones LeftShoulder;  // const
        public static UnityEngine.HumanBodyBones RightShoulder;  // const
        public static UnityEngine.HumanBodyBones LeftUpperArm;  // const
        public static UnityEngine.HumanBodyBones RightUpperArm;  // const
        public static UnityEngine.HumanBodyBones LeftLowerArm;  // const
        public static UnityEngine.HumanBodyBones RightLowerArm;  // const
        public static UnityEngine.HumanBodyBones LeftHand;  // const
        public static UnityEngine.HumanBodyBones RightHand;  // const
        public static UnityEngine.HumanBodyBones LeftToes;  // const
        public static UnityEngine.HumanBodyBones RightToes;  // const
        public static UnityEngine.HumanBodyBones LeftEye;  // const
        public static UnityEngine.HumanBodyBones RightEye;  // const
        public static UnityEngine.HumanBodyBones Jaw;  // const
        public static UnityEngine.HumanBodyBones LeftThumbProximal;  // const
        public static UnityEngine.HumanBodyBones LeftThumbIntermediate;  // const
        public static UnityEngine.HumanBodyBones LeftThumbDistal;  // const
        public static UnityEngine.HumanBodyBones LeftIndexProximal;  // const
        public static UnityEngine.HumanBodyBones LeftIndexIntermediate;  // const
        public static UnityEngine.HumanBodyBones LeftIndexDistal;  // const
        public static UnityEngine.HumanBodyBones LeftMiddleProximal;  // const
        public static UnityEngine.HumanBodyBones LeftMiddleIntermediate;  // const
        public static UnityEngine.HumanBodyBones LeftMiddleDistal;  // const
        public static UnityEngine.HumanBodyBones LeftRingProximal;  // const
        public static UnityEngine.HumanBodyBones LeftRingIntermediate;  // const
        public static UnityEngine.HumanBodyBones LeftRingDistal;  // const
        public static UnityEngine.HumanBodyBones LeftLittleProximal;  // const
        public static UnityEngine.HumanBodyBones LeftLittleIntermediate;  // const
        public static UnityEngine.HumanBodyBones LeftLittleDistal;  // const
        public static UnityEngine.HumanBodyBones RightThumbProximal;  // const
        public static UnityEngine.HumanBodyBones RightThumbIntermediate;  // const
        public static UnityEngine.HumanBodyBones RightThumbDistal;  // const
        public static UnityEngine.HumanBodyBones RightIndexProximal;  // const
        public static UnityEngine.HumanBodyBones RightIndexIntermediate;  // const
        public static UnityEngine.HumanBodyBones RightIndexDistal;  // const
        public static UnityEngine.HumanBodyBones RightMiddleProximal;  // const
        public static UnityEngine.HumanBodyBones RightMiddleIntermediate;  // const
        public static UnityEngine.HumanBodyBones RightMiddleDistal;  // const
        public static UnityEngine.HumanBodyBones RightRingProximal;  // const
        public static UnityEngine.HumanBodyBones RightRingIntermediate;  // const
        public static UnityEngine.HumanBodyBones RightRingDistal;  // const
        public static UnityEngine.HumanBodyBones RightLittleProximal;  // const
        public static UnityEngine.HumanBodyBones RightLittleIntermediate;  // const
        public static UnityEngine.HumanBodyBones RightLittleDistal;  // const
        public static UnityEngine.HumanBodyBones LastBone;  // const

    }

    // TypeToken: 0x2000033  // size: 0x38
    public sealed struct AnimationTransformf
    {
        // Fields
        public UnityEngine.Vector3 t;  // 0x10
        public UnityEngine.Quaternion q;  // 0x1c
        public UnityEngine.Vector3 s;  // 0x2c

    }

    // TypeToken: 0x2000034  // size: 0x18
    public class Avatar : UnityEngine.Object
    {
        // Properties
        System.Boolean isValid { get; /* RVA: 0x022D5F00 */ }
        System.Boolean isHuman { get; /* RVA: 0x029F0F10 */ }
        UnityEngine.HumanDescription humanDescription { get; /* RVA: 0x09D94E3C */ }

        // Methods
        // RVA: 0x09D94DB8  token: 0x60002CA
        private System.Void .ctor() { }
        // RVA: 0x09D94D08  token: 0x60002CE
        private System.Void SetMuscleMinMax(System.Int32 muscleId, System.Single min, System.Single max) { }
        // RVA: 0x09D94D68  token: 0x60002CF
        private System.Void SetParameter(System.Int32 parameterId, System.Single value) { }
        // RVA: 0x09D947D4  token: 0x60002D0
        private System.Single GetAxisLength(System.Int32 humanId) { }
        // RVA: 0x09D948CC  token: 0x60002D1
        private UnityEngine.Quaternion GetPreRotation(System.Int32 humanId) { }
        // RVA: 0x09D94884  token: 0x60002D2
        private UnityEngine.Quaternion GetPostRotation(System.Int32 humanId) { }
        // RVA: 0x09D94914  token: 0x60002D3
        private UnityEngine.Quaternion GetZYPostQ(System.Int32 humanId, UnityEngine.Quaternion parentQ, UnityEngine.Quaternion q) { }
        // RVA: 0x09D94998  token: 0x60002D4
        private UnityEngine.Quaternion GetZYRoll(System.Int32 humanId, UnityEngine.Vector3 uvw) { }
        // RVA: 0x09D94830  token: 0x60002D5
        private UnityEngine.Vector3 GetLimitSign(System.Int32 humanId) { }
        // RVA: 0x09D94A08  token: 0x60002D6
        private System.Single Internal_GetAxisLength(System.Int32 humanId) { }
        // RVA: 0x09D94B98  token: 0x60002D7
        private UnityEngine.Quaternion Internal_GetPreRotation(System.Int32 humanId) { }
        // RVA: 0x09D94B18  token: 0x60002D8
        private UnityEngine.Quaternion Internal_GetPostRotation(System.Int32 humanId) { }
        // RVA: 0x09D94C28  token: 0x60002D9
        private UnityEngine.Quaternion Internal_GetZYPostQ(System.Int32 humanId, UnityEngine.Quaternion parentQ, UnityEngine.Quaternion q) { }
        // RVA: 0x09D94CCC  token: 0x60002DA
        private UnityEngine.Quaternion Internal_GetZYRoll(System.Int32 humanId, UnityEngine.Vector3 uvw) { }
        // RVA: 0x09D94A98  token: 0x60002DB
        private UnityEngine.Vector3 Internal_GetLimitSign(System.Int32 humanId) { }
        // RVA: 0x09D947FC  token: 0x60002DC
        public System.String[] GetBonePaths() { }
        // RVA: 0x09D94DF8  token: 0x60002DD
        private System.Void get_humanDescription_Injected(UnityEngine.HumanDescription& ret) { }
        // RVA: 0x09D94B48  token: 0x60002DE
        private System.Void Internal_GetPreRotation_Injected(System.Int32 humanId, UnityEngine.Quaternion& ret) { }
        // RVA: 0x09D94AC8  token: 0x60002DF
        private System.Void Internal_GetPostRotation_Injected(System.Int32 humanId, UnityEngine.Quaternion& ret) { }
        // RVA: 0x09D94BC8  token: 0x60002E0
        private System.Void Internal_GetZYPostQ_Injected(System.Int32 humanId, UnityEngine.Quaternion& parentQ, UnityEngine.Quaternion& q, UnityEngine.Quaternion& ret) { }
        // RVA: 0x09D94C6C  token: 0x60002E1
        private System.Void Internal_GetZYRoll_Injected(System.Int32 humanId, UnityEngine.Vector3& uvw, UnityEngine.Quaternion& ret) { }
        // RVA: 0x09D94A48  token: 0x60002E2
        private System.Void Internal_GetLimitSign_Injected(System.Int32 humanId, UnityEngine.Vector3& ret) { }

    }

    // TypeToken: 0x2000035  // size: 0x48
    public sealed struct SkeletonBone
    {
        // Fields
        public System.String name;  // 0x10
        private System.String parentName;  // 0x18
        public UnityEngine.Vector3 position;  // 0x20
        public UnityEngine.Quaternion rotation;  // 0x2c
        public UnityEngine.Vector3 scale;  // 0x3c

    }

    // TypeToken: 0x2000036  // size: 0x3C
    public sealed struct HumanLimit
    {
        // Fields
        private UnityEngine.Vector3 m_Min;  // 0x10
        private UnityEngine.Vector3 m_Max;  // 0x1c
        private UnityEngine.Vector3 m_Center;  // 0x28
        private System.Single m_AxisLength;  // 0x34
        private System.Int32 m_UseDefaultValues;  // 0x38

    }

    // TypeToken: 0x2000037  // size: 0x50
    public sealed struct HumanBone
    {
        // Fields
        private System.String m_BoneName;  // 0x10
        private System.String m_HumanName;  // 0x18
        public UnityEngine.HumanLimit limit;  // 0x20

    }

    // TypeToken: 0x2000038  // size: 0x50
    public sealed struct HumanDescription
    {
        // Fields
        public UnityEngine.HumanBone[] human;  // 0x10
        public UnityEngine.SkeletonBone[] skeleton;  // 0x18
        private System.Single m_ArmTwist;  // 0x20
        private System.Single m_ForeArmTwist;  // 0x24
        private System.Single m_UpperLegTwist;  // 0x28
        private System.Single m_LegTwist;  // 0x2c
        private System.Single m_ArmStretch;  // 0x30
        private System.Single m_LegStretch;  // 0x34
        private System.Single m_FeetSpacing;  // 0x38
        private System.Single m_GlobalScale;  // 0x3c
        private System.String m_RootMotionBoneName;  // 0x40
        private System.Boolean m_HasTranslationDoF;  // 0x48
        private System.Boolean m_HasExtraRoot;  // 0x49
        private System.Boolean m_SkeletonHasParents;  // 0x4a

    }

    // TypeToken: 0x2000039  // size: 0x14
    public sealed struct AvatarMaskBodyPart
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AvatarMaskBodyPart Root;  // const
        public static UnityEngine.AvatarMaskBodyPart Body;  // const
        public static UnityEngine.AvatarMaskBodyPart Head;  // const
        public static UnityEngine.AvatarMaskBodyPart LeftLeg;  // const
        public static UnityEngine.AvatarMaskBodyPart RightLeg;  // const
        public static UnityEngine.AvatarMaskBodyPart LeftArm;  // const
        public static UnityEngine.AvatarMaskBodyPart RightArm;  // const
        public static UnityEngine.AvatarMaskBodyPart LeftFingers;  // const
        public static UnityEngine.AvatarMaskBodyPart RightFingers;  // const
        public static UnityEngine.AvatarMaskBodyPart LeftFootIK;  // const
        public static UnityEngine.AvatarMaskBodyPart RightFootIK;  // const
        public static UnityEngine.AvatarMaskBodyPart LeftHandIK;  // const
        public static UnityEngine.AvatarMaskBodyPart RightHandIK;  // const
        public static UnityEngine.AvatarMaskBodyPart LastBodyPart;  // const

    }

    // TypeToken: 0x200003A  // size: 0x18
    public sealed class AvatarMask : UnityEngine.Object
    {
        // Properties
        System.Int32 transformCount { get; /* RVA: 0x09D947A0 */ }

        // Methods
        // RVA: 0x09D946C4  token: 0x60002E3
        public System.Boolean GetHumanoidBodyPartActive(UnityEngine.AvatarMaskBodyPart index) { }
        // RVA: 0x09D94720  token: 0x60002E5
        public System.String GetTransformPath(System.Int32 index) { }
        // RVA: 0x09D94760  token: 0x60002E6
        private System.Single GetTransformWeight(System.Int32 index) { }
        // RVA: 0x09D94704  token: 0x60002E7
        public System.Boolean GetTransformActive(System.Int32 index) { }

    }

    // TypeToken: 0x200003B  // size: 0x18
    public class HGAnimationSetBindings : UnityEngine.Object
    {
    }

    // TypeToken: 0x200003C  // size: 0x18
    public class HGCorrectiveBoneData : UnityEngine.Object
    {
        // Methods
        // RVA: 0x09D94EA8  token: 0x60002E8
        public System.Void .ctor() { }
        // RVA: 0x09D94E74  token: 0x60002E9
        private static System.Void Internal_Create(UnityEngine.HGCorrectiveBoneData self) { }

    }

    // TypeToken: 0x200003D  // size: 0x18
    public sealed class HGSkeletalMorphAvatar : UnityEngine.Object
    {
        // Methods
        // RVA: 0x09D94F28  token: 0x60002EA
        private System.Void .ctor() { }
        // RVA: 0x09D94EF4  token: 0x60002EB
        private static System.Void Internal_Create(UnityEngine.HGSkeletalMorphAvatar self) { }

    }

    // TypeToken: 0x200003E  // size: 0x38
    public sealed struct HumanPose
    {
        // Fields
        public UnityEngine.Vector3 bodyPosition;  // 0x10
        public UnityEngine.Quaternion bodyRotation;  // 0x1c
        public System.Single[] muscles;  // 0x30

        // Methods
        // RVA: 0x09D95350  token: 0x60002EC
        private System.Void Init() { }

    }

    // TypeToken: 0x200003F  // size: 0x18
    public class HumanPoseHandler : System.IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;  // 0x10

        // Methods
        // RVA: 0x09D950CC  token: 0x60002ED
        private static System.IntPtr Internal_CreateFromRoot(UnityEngine.Avatar avatar, UnityEngine.Transform root) { }
        // RVA: 0x09D95110  token: 0x60002EE
        private static System.Void Internal_Destroy(System.IntPtr ptr) { }
        // RVA: 0x09D94FCC  token: 0x60002EF
        private System.Void GetHumanPose(UnityEngine.Vector3& bodyPosition, UnityEngine.Quaternion& bodyRotation, System.Single[] muscles) { }
        // RVA: 0x09D94F74  token: 0x60002F0
        public virtual System.Void Dispose() { }
        // RVA: 0x09D95144  token: 0x60002F1
        public System.Void .ctor(UnityEngine.Avatar avatar, UnityEngine.Transform root) { }
        // RVA: 0x09D95030  token: 0x60002F2
        public System.Void GetHumanPose(UnityEngine.HumanPose& humanPose) { }

    }

    // TypeToken: 0x2000040  // size: 0x10
    public class HumanTrait
    {
        // Properties
        System.Int32 MuscleCount { get; /* RVA: 0x09D95488 */ }
        System.String[] MuscleName { get; /* RVA: 0x09D954B4 */ }

        // Methods
        // RVA: 0x09D95454  token: 0x60002F4
        private static System.Int32 GetBoneIndexFromMono(System.Int32 humanId) { }

    }

    // TypeToken: 0x2000041  // size: 0x18
    public class LodBoneMask : UnityEngine.Object
    {
        // Methods
        // RVA: 0x09D95514  token: 0x60002F6
        public System.Void .ctor() { }
        // RVA: 0x09D954E0  token: 0x60002F7
        private static System.Void Internal_Create(UnityEngine.LodBoneMask self) { }

    }

    // TypeToken: 0x2000042  // size: 0x20
    public class Motion : UnityEngine.Object
    {
        // Fields
        private readonly System.Boolean <isAnimatorMotion>k__BackingField;  // 0x18

        // Properties
        System.Boolean isLooping { get; /* RVA: 0x02966620 */ }

        // Methods
        // RVA: 0x033570F0  token: 0x60002F8
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000043  // size: 0x18
    public class RuntimeAnimatorController : UnityEngine.Object
    {
        // Properties
        UnityEngine.AnimationClip[] animationClips { get; /* RVA: 0x03CB7F30 */ }

        // Methods
        // RVA: 0x09D95D30  token: 0x60002FA
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000044  // size: 0x18
    public class RuntimeAnimatorStateOverride : UnityEngine.Object
    {
        // Methods
        // RVA: 0x02F49AE0  token: 0x60002FC
        public System.Void .ctor() { }
        // RVA: 0x02F49B30  token: 0x60002FD
        private static System.Void Internal_Create(UnityEngine.RuntimeAnimatorStateOverride self) { }
        // RVA: 0x04276BA0  token: 0x60002FE
        public System.Void SetClip(System.Int32 stateID, UnityEngine.AnimationClip overrideClip) { }
        // RVA: 0x04276BA8  token: 0x60002FF
        public System.Void SetClipAsync(System.Int32 stateID, System.Single length, System.Boolean isHumanoid) { }
        // RVA: 0x09D95DF0  token: 0x6000300
        public System.Void RemoveClip(System.Int32 stateID) { }
        // RVA: 0x04272C60  token: 0x6000301
        public System.Void ClearClip() { }
        // RVA: 0x0427616C  token: 0x6000302
        public System.Boolean PreloadClip(UnityEngine.AnimationClip clipB) { }
        // RVA: 0x04276BDC  token: 0x6000303
        public System.Void SetTransition(System.Int32 transUserNameID, System.Single transitionDuration, System.Single transitionOffset, System.Single exitTime) { }
        // RVA: 0x09D95DF8  token: 0x6000304
        public System.Void RemoveTransition(System.Int32 transUserNameID) { }
        // RVA: 0x042747A0  token: 0x6000305
        public System.Void SetSyncGroupCurve(System.UInt32 clipNameID, UnityEngine.AnimationCurve curve) { }
        // RVA: 0x038E48A0  token: 0x6000306
        private System.Void Internal_SetClip(System.UInt32 stateID, UnityEngine.AnimationClip overrideClip) { }
        // RVA: 0x03CFFD20  token: 0x6000307
        private System.Void Internal_SetClipAsync(System.UInt32 stateID, System.Single length, System.Boolean isHumanoid) { }
        // RVA: 0x09D95D70  token: 0x6000308
        private System.Void Internal_RemoveClip(System.UInt32 stateID) { }
        // RVA: 0x03D27550  token: 0x6000309
        private System.Void Internal_ClearClip() { }
        // RVA: 0x03871DB0  token: 0x600030A
        private System.Boolean Internal_PreloadClip(UnityEngine.AnimationClip clipB) { }
        // RVA: 0x03A09540  token: 0x600030B
        private System.Void Internal_SetTransition(System.UInt32 transUserNameID, System.Single transitionDuration, System.Single transitionOffset, System.Single exitTime) { }
        // RVA: 0x09D95DB0  token: 0x600030C
        private System.Void Internal_RemoveTransition(System.UInt32 transUserNameID) { }
        // RVA: 0x033D9170  token: 0x600030D
        private System.Void Internal_SetSyncGroupCurve(System.UInt32 clipNameID, UnityEngine.AnimationCurve curve) { }

    }

}

namespace UnityEngine.Animations
{

    // TypeToken: 0x2000047  // size: 0x10
    public static class AnimationPlayableBinding
    {
        // Methods
        // RVA: 0x09D8C044  token: 0x6000314
        public static UnityEngine.Playables.PlayableBinding Create(System.String name, UnityEngine.Object key) { }
        // RVA: 0x09D8C004  token: 0x6000315
        private static UnityEngine.Playables.PlayableOutput CreateAnimationOutput(UnityEngine.Playables.PlayableGraph graph, System.String name) { }

    }

    // TypeToken: 0x2000048  // size: 0x10
    public class DiscreteEvaluationAttribute : System.Attribute
    {
    }

    // TypeToken: 0x2000049
    public interface IAnimationJob
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000316
        public virtual System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: -1  // abstract  token: 0x6000317
        public virtual System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x200004A
    public interface IAnimationWindowPreview
    {
    }

    // TypeToken: 0x200004B  // size: 0x10
    public class NotKeyableAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000318
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004C  // size: 0x14
    public sealed struct JobMethodIndex
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Animations.JobMethodIndex ProcessRootMotionMethodIndex;  // const
        public static UnityEngine.Animations.JobMethodIndex ProcessAnimationMethodIndex;  // const
        public static UnityEngine.Animations.JobMethodIndex MethodIndexCount;  // const

    }

    // TypeToken: 0x200004D  // size: 0x11
    public sealed struct ProcessAnimationJobStruct`1
    {
        // Fields
        private static System.IntPtr jobReflectionData;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000319
        public static System.IntPtr GetJobReflectionData() { }
        // RVA: -1  // not resolved  token: 0x600031A
        public static System.Void Execute(T& data, System.IntPtr animationStreamPtr, System.IntPtr methodIndex, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }

    }

    // TypeToken: 0x200004F  // size: 0x20
    public sealed struct AdvancedAnimationMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;  // 0x10
        private static readonly UnityEngine.Animations.AdvancedAnimationMixerPlayable m_NullPlayable;  // static @ 0x0

        // Methods
        // RVA: 0x03326790  token: 0x600031D
        public static UnityEngine.Animations.AdvancedAnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        // RVA: 0x03326840  token: 0x600031E
        private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        // RVA: 0x03326A70  token: 0x600031F
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        // RVA: 0x03D695A0  token: 0x6000320
        public virtual UnityEngine.Playables.PlayableHandle GetHandle() { }
        // RVA: 0x09D89F48  token: 0x6000321
        public virtual System.Boolean Equals(UnityEngine.Animations.AdvancedAnimationMixerPlayable other) { }
        // RVA: 0x033269C0  token: 0x6000322
        private static System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle) { }
        // RVA: 0x03326700  token: 0x6000323
        private static System.Void .cctor() { }
        // RVA: 0x03326A20  token: 0x6000324
        private static System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x2000050  // size: 0x20
    public sealed struct AnimationClipPlayable : UnityEngine.Playables.IPlayable, System.IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;  // 0x10

        // Methods
        // RVA: 0x02809460  token: 0x6000325
        public static UnityEngine.Animations.AnimationClipPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip) { }
        // RVA: 0x02809590  token: 0x6000326
        private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip) { }
        // RVA: 0x02809720  token: 0x6000327
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        // RVA: 0x03D695A0  token: 0x6000328
        public virtual UnityEngine.Playables.PlayableHandle GetHandle() { }
        // RVA: 0x03D85A00  token: 0x6000329
        public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationClipPlayable playable) { }
        // RVA: 0x09D8A204  token: 0x600032A
        public static UnityEngine.Animations.AnimationClipPlayable op_Explicit(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x09D89FD4  token: 0x600032B
        public virtual System.Boolean Equals(UnityEngine.Animations.AnimationClipPlayable other) { }
        // RVA: 0x0426FA88  token: 0x600032C
        public UnityEngine.AnimationClip GetAnimationClip() { }
        // RVA: 0x09D8A07C  token: 0x600032D
        public System.Single GetAnimationClipPlayableLengthUncheck() { }
        // RVA: 0x0427467C  token: 0x600032E
        public System.Void SetAnimationClip(UnityEngine.AnimationClip clip) { }
        // RVA: 0x042751B0  token: 0x600032F
        public System.Void SetAnimationClipAsync(System.Single length, System.Boolean isHumanoid) { }
        // RVA: 0x09D8A0CC  token: 0x6000330
        public System.Void SetApplyFootIK(System.Boolean value) { }
        // RVA: 0x09D8A118  token: 0x6000331
        public System.Void SetApplyPlayableIK(System.Boolean value) { }
        // RVA: 0x09D8A1FC  token: 0x6000332
        private System.Void SetRemoveStartOffset(System.Boolean value) { }
        // RVA: 0x09D8A1B0  token: 0x6000333
        private System.Void SetOverrideLoopTime(System.Boolean value) { }
        // RVA: 0x09D8A164  token: 0x6000334
        private System.Void SetLoopTime(System.Boolean value) { }
        // RVA: 0x04271BAC  token: 0x6000335
        private static System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, UnityEngine.Playables.PlayableHandle& handle) { }
        // RVA: 0x03027760  token: 0x6000336
        private static UnityEngine.AnimationClip GetAnimationClipInternal(UnityEngine.Playables.PlayableHandle& handle) { }
        // RVA: 0x036BF110  token: 0x6000337
        private static System.Void SetAnimationClipInternal(UnityEngine.Playables.PlayableHandle& handle, UnityEngine.AnimationClip clip) { }
        // RVA: 0x03C7B990  token: 0x6000338
        private static System.Void SetAnimationClipAsyncInternal(UnityEngine.Playables.PlayableHandle& handle, System.Single length, System.Boolean isHumanoid) { }
        // RVA: 0x09D8A088  token: 0x6000339
        private static System.Void SetApplyFootIKInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }
        // RVA: 0x09D8A0D4  token: 0x600033A
        private static System.Void SetApplyPlayableIKInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }
        // RVA: 0x09D8A1B8  token: 0x600033B
        private static System.Void SetRemoveStartOffsetInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }
        // RVA: 0x09D8A16C  token: 0x600033C
        private static System.Void SetOverrideLoopTimeInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }
        // RVA: 0x09D8A120  token: 0x600033D
        private static System.Void SetLoopTimeInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }
        // RVA: 0x09D8A048  token: 0x600033E
        private static System.Single GetAnimationClipPlayableLengthInternalUncheck(UnityEngine.Playables.PlayableHandle& handle) { }
        // RVA: 0x0332D860  token: 0x600033F
        private static System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.AnimationClip clip, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x2000051  // size: 0x18
    public sealed struct AnimationHumanStream
    {
        // Fields
        private System.IntPtr stream;  // 0x10

    }

    // TypeToken: 0x2000052  // size: 0x20
    public sealed struct AnimationLayerMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;  // 0x10
        private static readonly UnityEngine.Animations.AnimationLayerMixerPlayable m_NullPlayable;  // static @ 0x0

        // Properties
        UnityEngine.Animations.AnimationLayerMixerPlayable Null { get; /* RVA: 0x09D8B37C */ }

        // Methods
        // RVA: 0x02967A80  token: 0x6000341
        public static UnityEngine.Animations.AnimationLayerMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        // RVA: 0x02967B20  token: 0x6000342
        public static UnityEngine.Animations.AnimationLayerMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount, System.Boolean singleLayerOptimization) { }
        // RVA: 0x02967BF0  token: 0x6000343
        private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        // RVA: 0x02967E20  token: 0x6000344
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle, System.Boolean singleLayerOptimization) { }
        // RVA: 0x03D695A0  token: 0x6000345
        public virtual UnityEngine.Playables.PlayableHandle GetHandle() { }
        // RVA: 0x09D8B450  token: 0x6000346
        public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationLayerMixerPlayable playable) { }
        // RVA: 0x09D8B3D4  token: 0x6000347
        public static UnityEngine.Animations.AnimationLayerMixerPlayable op_Explicit(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x09D8ABA4  token: 0x6000348
        public virtual System.Boolean Equals(UnityEngine.Animations.AnimationLayerMixerPlayable other) { }
        // RVA: 0x09D8AC84  token: 0x6000349
        public System.Void SetLayerAdditive(System.UInt32 layerIndex, System.Boolean value) { }
        // RVA: 0x09D8AFE8  token: 0x600034A
        public System.Void SetLayerMaskFromAvatarMask(System.UInt32 layerIndex, UnityEngine.AvatarMask mask) { }
        // RVA: 0x09D8B21C  token: 0x600034B
        public System.Void SetLayerRootMotionDisable(System.UInt32 layerIndex, System.Boolean value) { }
        // RVA: 0x09D8AE38  token: 0x600034C
        public System.Void SetLayerEnableFloatCurve(System.UInt32 layerIndex, System.Boolean value) { }
        // RVA: 0x02967D70  token: 0x600034D
        private static System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle) { }
        // RVA: 0x09D8AC30  token: 0x600034E
        private static System.Void SetLayerAdditiveInternal(UnityEngine.Playables.PlayableHandle& handle, System.UInt32 layerIndex, System.Boolean value) { }
        // RVA: 0x02967F20  token: 0x600034F
        private static System.Void SetSingleLayerOptimizationInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }
        // RVA: 0x09D8AF98  token: 0x6000350
        private static System.Void SetLayerMaskFromAvatarMaskInternal(UnityEngine.Playables.PlayableHandle& handle, System.UInt32 layerIndex, UnityEngine.AvatarMask mask) { }
        // RVA: 0x09D8B1C8  token: 0x6000351
        private static System.Void SetLayerRootMotionDisableInternal(UnityEngine.Playables.PlayableHandle& handle, System.UInt32 layerIndex, System.Boolean value) { }
        // RVA: 0x09D8ADE4  token: 0x6000352
        private static System.Void SetLayerEnableFloatCurveInternal(UnityEngine.Playables.PlayableHandle& handle, System.UInt32 layerIndex, System.Boolean value) { }
        // RVA: 0x02967F70  token: 0x6000353
        private static System.Void .cctor() { }
        // RVA: 0x02967DD0  token: 0x6000354
        private static System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x2000053  // size: 0x20
    public sealed struct AnimationMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;  // 0x10
        private static readonly UnityEngine.Animations.AnimationMixerPlayable m_NullPlayable;  // static @ 0x0

        // Methods
        // RVA: 0x09D8B4A4  token: 0x6000355
        public static UnityEngine.Animations.AnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount, System.Boolean normalizeWeights) { }
        // RVA: 0x02808450  token: 0x6000356
        public static UnityEngine.Animations.AnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        // RVA: 0x02808500  token: 0x6000357
        private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        // RVA: 0x028086F0  token: 0x6000358
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        // RVA: 0x03D695A0  token: 0x6000359
        public virtual UnityEngine.Playables.PlayableHandle GetHandle() { }
        // RVA: 0x09D8B5B0  token: 0x600035A
        public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMixerPlayable playable) { }
        // RVA: 0x09D8B524  token: 0x600035B
        public virtual System.Boolean Equals(UnityEngine.Animations.AnimationMixerPlayable other) { }
        // RVA: 0x028099E0  token: 0x600035C
        private static System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle) { }
        // RVA: 0x03CE5560  token: 0x600035D
        private static System.Void .cctor() { }
        // RVA: 0x02809A40  token: 0x600035E
        private static System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x2000054  // size: 0x20
    public sealed struct AnimationMotionXToDeltaPlayable : UnityEngine.Playables.IPlayable, System.IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;  // 0x10
        private static readonly UnityEngine.Animations.AnimationMotionXToDeltaPlayable m_NullPlayable;  // static @ 0x0

        // Methods
        // RVA: 0x09D8B780  token: 0x600035F
        public static UnityEngine.Animations.AnimationMotionXToDeltaPlayable Create(UnityEngine.Playables.PlayableGraph graph) { }
        // RVA: 0x09D8B6A4  token: 0x6000360
        private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph) { }
        // RVA: 0x09D8B9C4  token: 0x6000361
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        // RVA: 0x03D695A0  token: 0x6000362
        public virtual UnityEngine.Playables.PlayableHandle GetHandle() { }
        // RVA: 0x09D8BA9C  token: 0x6000363
        public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMotionXToDeltaPlayable playable) { }
        // RVA: 0x09D8B814  token: 0x6000364
        public virtual System.Boolean Equals(UnityEngine.Animations.AnimationMotionXToDeltaPlayable other) { }
        // RVA: 0x09D8B8E4  token: 0x6000365
        public System.Void SetAbsoluteMotion(System.Boolean value) { }
        // RVA: 0x09D8B648  token: 0x6000366
        private static System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle) { }
        // RVA: 0x09D8B8A0  token: 0x6000367
        private static System.Void SetAbsoluteMotionInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }
        // RVA: 0x09D8B940  token: 0x6000368
        private static System.Void .cctor() { }
        // RVA: 0x09D8B604  token: 0x6000369
        private static System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x2000055  // size: 0x20
    public sealed struct AnimationOffsetPlayable : UnityEngine.Playables.IPlayable, System.IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;  // 0x10
        private static readonly UnityEngine.Animations.AnimationOffsetPlayable m_NullPlayable;  // static @ 0x0

        // Methods
        // RVA: 0x09D8BCE4  token: 0x600036A
        public static UnityEngine.Animations.AnimationOffsetPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int32 inputCount) { }
        // RVA: 0x09D8BBC8  token: 0x600036B
        private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int32 inputCount) { }
        // RVA: 0x09D8BED8  token: 0x600036C
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        // RVA: 0x03D695A0  token: 0x600036D
        public virtual UnityEngine.Playables.PlayableHandle GetHandle() { }
        // RVA: 0x09D8BFB0  token: 0x600036E
        public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationOffsetPlayable playable) { }
        // RVA: 0x09D8BDC0  token: 0x600036F
        public virtual System.Boolean Equals(UnityEngine.Animations.AnimationOffsetPlayable other) { }
        // RVA: 0x09D8BB54  token: 0x6000370
        private static System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Playables.PlayableHandle& handle) { }
        // RVA: 0x09D8BE54  token: 0x6000371
        private static System.Void .cctor() { }
        // RVA: 0x09D8BAF0  token: 0x6000372
        private static System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x2000056  // size: 0x10
    public static class AnimationPlayableExtensions
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000373
        public static System.Void SetAnimatedProperties(U playable, UnityEngine.AnimationClip clip) { }
        // RVA: 0x09D8C160  token: 0x6000374
        private static System.Void SetAnimatedPropertiesInternal(UnityEngine.Playables.PlayableHandle& playable, UnityEngine.AnimationClip animatedProperties) { }

    }

    // TypeToken: 0x2000057  // size: 0x10
    public static class AnimationPlayableGraphExtensions
    {
        // Methods
        // RVA: 0x02966E40  token: 0x6000375
        private static System.Boolean InternalCreateAnimationOutput(UnityEngine.Playables.PlayableGraph& graph, System.String name, UnityEngine.Playables.PlayableOutputHandle& handle) { }

    }

    // TypeToken: 0x2000058  // size: 0x20
    public sealed struct AnimationPlayableOutput : UnityEngine.Playables.IPlayableOutput
    {
        // Fields
        private UnityEngine.Playables.PlayableOutputHandle m_Handle;  // 0x10

        // Properties
        UnityEngine.Animations.AnimationPlayableOutput Null { get; /* RVA: 0x09D8C31C */ }

        // Methods
        // RVA: 0x02966D80  token: 0x6000376
        public static UnityEngine.Animations.AnimationPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, System.String name, UnityEngine.Animator target) { }
        // RVA: 0x02966EA0  token: 0x6000377
        private System.Void .ctor(UnityEngine.Playables.PlayableOutputHandle handle) { }
        // RVA: 0x03D695A0  token: 0x6000379
        public virtual UnityEngine.Playables.PlayableOutputHandle GetHandle() { }
        // RVA: 0x03D85A00  token: 0x600037A
        public static UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Animations.AnimationPlayableOutput output) { }
        // RVA: 0x09D8C394  token: 0x600037B
        public static UnityEngine.Animations.AnimationPlayableOutput op_Explicit(UnityEngine.Playables.PlayableOutput output) { }
        // RVA: 0x09D8C290  token: 0x600037C
        public UnityEngine.Animator GetTarget() { }
        // RVA: 0x04272110  token: 0x600037D
        public System.Void SetTarget(UnityEngine.Animator value) { }
        // RVA: 0x09D8C314  token: 0x600037E
        public System.Void SetNeedRebindOnChanged(System.Boolean value) { }
        // RVA: 0x09D8C29C  token: 0x600037F
        private static UnityEngine.Animator InternalGetTarget(UnityEngine.Playables.PlayableOutputHandle& handle) { }
        // RVA: 0x03540510  token: 0x6000380
        private static System.Void InternalSetTarget(UnityEngine.Playables.PlayableOutputHandle& handle, UnityEngine.Animator target) { }
        // RVA: 0x09D8C2D0  token: 0x6000381
        private static System.Void InternalSetNeedRebindOnChanged(UnityEngine.Playables.PlayableOutputHandle& handle, System.Boolean value) { }

    }

    // TypeToken: 0x2000059  // size: 0x20
    public sealed struct AnimationPosePlayable : UnityEngine.Playables.IPlayable, System.IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;  // 0x10
        private static readonly UnityEngine.Animations.AnimationPosePlayable m_NullPlayable;  // static @ 0x0

        // Methods
        // RVA: 0x09D8C524  token: 0x6000382
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        // RVA: 0x03D695A0  token: 0x6000383
        public virtual UnityEngine.Playables.PlayableHandle GetHandle() { }
        // RVA: 0x09D8C40C  token: 0x6000384
        public virtual System.Boolean Equals(UnityEngine.Animations.AnimationPosePlayable other) { }
        // RVA: 0x09D8C4A0  token: 0x6000385
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200005A  // size: 0x20
    public sealed struct AnimationRemoveScalePlayable : UnityEngine.Playables.IPlayable, System.IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;  // 0x10
        private static readonly UnityEngine.Animations.AnimationRemoveScalePlayable m_NullPlayable;  // static @ 0x0

        // Methods
        // RVA: 0x09D8C784  token: 0x6000386
        public static UnityEngine.Animations.AnimationRemoveScalePlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        // RVA: 0x09D8C69C  token: 0x6000387
        private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        // RVA: 0x09D8C940  token: 0x6000388
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        // RVA: 0x03D695A0  token: 0x6000389
        public virtual UnityEngine.Playables.PlayableHandle GetHandle() { }
        // RVA: 0x09D8CA18  token: 0x600038A
        public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationRemoveScalePlayable playable) { }
        // RVA: 0x09D8C828  token: 0x600038B
        public virtual System.Boolean Equals(UnityEngine.Animations.AnimationRemoveScalePlayable other) { }
        // RVA: 0x09D8C640  token: 0x600038C
        private static System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle) { }
        // RVA: 0x09D8C8BC  token: 0x600038D
        private static System.Void .cctor() { }
        // RVA: 0x09D8C5FC  token: 0x600038E
        private static System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x200005B  // size: 0x20
    public sealed struct AnimationScriptPlayable : UnityEngine.Playables.IPlayable, System.IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;  // 0x10
        private static readonly UnityEngine.Animations.AnimationScriptPlayable m_NullPlayable;  // static @ 0x0

        // Methods
        // RVA: -1  // generic def  token: 0x600038F
        public static UnityEngine.Animations.AnimationScriptPlayable Create(UnityEngine.Playables.PlayableGraph graph, T jobData, System.Int32 inputCount) { }
        // RVA: -1  // generic def  token: 0x6000390
        private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        // RVA: 0x09D8CF34  token: 0x6000391
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        // RVA: 0x03D695A0  token: 0x6000392
        public virtual UnityEngine.Playables.PlayableHandle GetHandle() { }
        // RVA: -1  // generic def  token: 0x6000393
        private System.Void CheckJobTypeValidity() { }
        // RVA: -1  // generic def  token: 0x6000394
        public virtual System.Void SetJobData(T jobData) { }
        // RVA: 0x09D8D00C  token: 0x6000395
        public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationScriptPlayable playable) { }
        // RVA: 0x09D8CC2C  token: 0x6000396
        public virtual System.Boolean Equals(UnityEngine.Animations.AnimationScriptPlayable other) { }
        // RVA: 0x09D8CE54  token: 0x6000397
        public System.Void SetForceWriteRootMotionParam(System.Boolean value) { }
        // RVA: 0x09D8CD58  token: 0x6000398
        public System.Void SetForceResetParam(System.Boolean value) { }
        // RVA: 0x09D8CBC8  token: 0x6000399
        private static System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle, System.IntPtr jobReflectionData) { }
        // RVA: 0x09D8CDF8  token: 0x600039A
        private static System.Void SetForceWriteRootMotionParamInternal(UnityEngine.Playables.PlayableHandle handle, System.Boolean value) { }
        // RVA: 0x09D8CCFC  token: 0x600039B
        private static System.Void SetForceResetParamInternal(UnityEngine.Playables.PlayableHandle handle, System.Boolean value) { }
        // RVA: 0x09D8CEB0  token: 0x600039C
        private static System.Void .cctor() { }
        // RVA: 0x09D8CB74  token: 0x600039D
        private static System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle, System.IntPtr jobReflectionData) { }
        // RVA: 0x09D8CDB4  token: 0x600039E
        private static System.Void SetForceWriteRootMotionParamInternal_Injected(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }
        // RVA: 0x09D8CCB8  token: 0x600039F
        private static System.Void SetForceResetParamInternal_Injected(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }

    }

    // TypeToken: 0x200005C  // size: 0x48
    public sealed struct AnimationStream
    {
        // Fields
        private System.UInt32 m_AnimatorBindingsVersion;  // 0x10
        private System.IntPtr constant;  // 0x18
        private System.IntPtr input;  // 0x20
        private System.IntPtr output;  // 0x28
        private System.IntPtr workspace;  // 0x30
        private System.IntPtr inputStreamAccessor;  // 0x38
        private System.IntPtr animationHandleBinder;  // 0x40

        // Properties
        System.UInt32 animatorBindingsVersion { get; /* RVA: 0x03D85860 */ }
        System.Boolean isValid { get; /* RVA: 0x09D8D7F0 */ }
        System.Single deltaTime { get; /* RVA: 0x09D8D7D0 */ }

        // Methods
        // RVA: 0x09D8D728  token: 0x60003A2
        private System.Void CheckIsValid() { }
        // RVA: 0x09D8D7C8  token: 0x60003A4
        private System.Single GetDeltaTime() { }
        // RVA: 0x09D8D794  token: 0x60003A5
        private static System.Single GetDeltaTime_Injected(UnityEngine.Animations.AnimationStream& _unity_self) { }

    }

    // TypeToken: 0x200005D  // size: 0x1C
    public sealed struct TransformStreamHandle
    {
        // Fields
        private System.UInt32 m_AnimatorBindingsVersion;  // 0x10
        private System.Int32 handleIndex;  // 0x14
        private System.Int32 skeletonIndex;  // 0x18

        // Properties
        System.Boolean createdByNative { get; /* RVA: 0x09D95D04 */ }
        System.Boolean hasHandleIndex { get; /* RVA: 0x09D95D18 */ }
        System.Boolean hasSkeletonIndex { get; /* RVA: 0x09D95D24 */ }
        System.UInt32 animatorBindingsVersion { get; /* RVA: 0x03D85860 */ }

        // Methods
        // RVA: 0x09D96D74  token: 0x60003A6
        public System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D96D44  token: 0x60003A7
        private System.Boolean IsValidInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D95968  token: 0x60003A9
        private System.Boolean IsSameVersionAsStream(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D96DD4  token: 0x60003AD
        public System.Void Resolve(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D96D30  token: 0x60003AE
        public System.Boolean IsResolved(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D96CF4  token: 0x60003AF
        private System.Boolean IsResolvedInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D965A4  token: 0x60003B0
        private System.Void CheckIsValidAndResolve(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D96BB0  token: 0x60003B1
        public UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D972B4  token: 0x60003B2
        public System.Void SetPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position) { }
        // RVA: 0x09D96C98  token: 0x60003B3
        public UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D97370  token: 0x60003B4
        public System.Void SetRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09D96820  token: 0x60003B5
        public UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D96F54  token: 0x60003B6
        public System.Void SetLocalPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position) { }
        // RVA: 0x09D96908  token: 0x60003B7
        public UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D97010  token: 0x60003B8
        public System.Void SetLocalRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09D969EC  token: 0x60003B9
        public UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D970C4  token: 0x60003BA
        public System.Void SetLocalScale(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 scale) { }
        // RVA: 0x09D96AC4  token: 0x60003BB
        public System.Void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        // RVA: 0x09D971A8  token: 0x60003BC
        public System.Void SetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, System.Boolean useMask) { }
        // RVA: 0x09D96740  token: 0x60003BD
        public System.Void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        // RVA: 0x09D96E6C  token: 0x60003BE
        public System.Void SetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Boolean useMask) { }
        // RVA: 0x09D96DCC  token: 0x60003BF
        private System.Void ResolveInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D96B7C  token: 0x60003C0
        private UnityEngine.Vector3 GetPositionInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D972A0  token: 0x60003C1
        private System.Void SetPositionInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 position) { }
        // RVA: 0x09D96C68  token: 0x60003C2
        private UnityEngine.Quaternion GetRotationInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D9735C  token: 0x60003C3
        private System.Void SetRotationInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09D967EC  token: 0x60003C4
        private UnityEngine.Vector3 GetLocalPositionInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D96F40  token: 0x60003C5
        private System.Void SetLocalPositionInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 position) { }
        // RVA: 0x09D968D8  token: 0x60003C6
        private UnityEngine.Quaternion GetLocalRotationInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D96FFC  token: 0x60003C7
        private System.Void SetLocalRotationInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09D969B8  token: 0x60003C8
        private UnityEngine.Vector3 GetLocalScaleInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D970B0  token: 0x60003C9
        private System.Void SetLocalScaleInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 scale) { }
        // RVA: 0x09D96AB4  token: 0x60003CA
        private System.Void GetLocalTRSInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        // RVA: 0x09D9717C  token: 0x60003CB
        private System.Void SetLocalTRSInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, System.Boolean useMask) { }
        // RVA: 0x09D96730  token: 0x60003CC
        private System.Void GetGlobalTRInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        // RVA: 0x09D96E4C  token: 0x60003CD
        private System.Void SetGlobalTRInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Boolean useMask) { }
        // RVA: 0x09D96D88  token: 0x60003CE
        private static System.Void ResolveInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D96B28  token: 0x60003CF
        private static System.Void GetPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret) { }
        // RVA: 0x09D9724C  token: 0x60003D0
        private static System.Void SetPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position) { }
        // RVA: 0x09D96C14  token: 0x60003D1
        private static System.Void GetRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& ret) { }
        // RVA: 0x09D97308  token: 0x60003D2
        private static System.Void SetRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& rotation) { }
        // RVA: 0x09D96798  token: 0x60003D3
        private static System.Void GetLocalPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret) { }
        // RVA: 0x09D96EEC  token: 0x60003D4
        private static System.Void SetLocalPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position) { }
        // RVA: 0x09D96884  token: 0x60003D5
        private static System.Void GetLocalRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& ret) { }
        // RVA: 0x09D96FA8  token: 0x60003D6
        private static System.Void SetLocalRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& rotation) { }
        // RVA: 0x09D96964  token: 0x60003D7
        private static System.Void GetLocalScaleInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret) { }
        // RVA: 0x09D9705C  token: 0x60003D8
        private static System.Void SetLocalScaleInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& scale) { }
        // RVA: 0x09D96A50  token: 0x60003D9
        private static System.Void GetLocalTRSInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        // RVA: 0x09D97118  token: 0x60003DA
        private static System.Void SetLocalTRSInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale, System.Boolean useMask) { }
        // RVA: 0x09D966CC  token: 0x60003DB
        private static System.Void GetGlobalTRInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        // RVA: 0x09D96DE8  token: 0x60003DC
        private static System.Void SetGlobalTRInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, System.Boolean useMask) { }

    }

    // TypeToken: 0x200005E  // size: 0x20
    public sealed struct PropertyStreamHandle
    {
        // Fields
        private System.UInt32 m_AnimatorBindingsVersion;  // 0x10
        private System.Int32 handleIndex;  // 0x14
        private System.Int32 valueArrayIndex;  // 0x18
        private System.Int32 bindType;  // 0x1c

        // Properties
        System.Boolean createdByNative { get; /* RVA: 0x09D95D04 */ }
        System.Boolean hasHandleIndex { get; /* RVA: 0x09D95D18 */ }
        System.Boolean hasValueArrayIndex { get; /* RVA: 0x09D95D24 */ }
        System.Boolean hasBindType { get; /* RVA: 0x09D95D10 */ }
        System.UInt32 animatorBindingsVersion { get; /* RVA: 0x03D85860 */ }

        // Methods
        // RVA: 0x09D959A8  token: 0x60003DD
        public System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D95974  token: 0x60003DE
        private System.Boolean IsValidInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D95968  token: 0x60003E0
        private System.Boolean IsSameVersionAsStream(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D9592C  token: 0x60003E5
        private System.Boolean IsResolvedInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D95560  token: 0x60003E6
        private System.Void CheckIsValidAndResolve(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D957BC  token: 0x60003E7
        public System.Single GetFloat(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D95B64  token: 0x60003E8
        public System.Void SetFloat(UnityEngine.Animations.AnimationStream stream, System.Single value) { }
        // RVA: 0x09D95894  token: 0x60003E9
        public System.Int32 GetInt(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D95C5C  token: 0x60003EA
        public System.Void SetInt(UnityEngine.Animations.AnimationStream stream, System.Int32 value) { }
        // RVA: 0x09D956DC  token: 0x60003EB
        public System.Boolean GetBool(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D95A64  token: 0x60003EC
        public System.Void SetBool(UnityEngine.Animations.AnimationStream stream, System.Boolean value) { }
        // RVA: 0x09D95A00  token: 0x60003ED
        private System.Void ResolveInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D957B4  token: 0x60003EE
        private System.Single GetFloatInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D95B5C  token: 0x60003EF
        private System.Void SetFloatInternal(UnityEngine.Animations.AnimationStream& stream, System.Single value) { }
        // RVA: 0x09D9588C  token: 0x60003F0
        private System.Int32 GetIntInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D95C54  token: 0x60003F1
        private System.Void SetIntInternal(UnityEngine.Animations.AnimationStream& stream, System.Int32 value) { }
        // RVA: 0x09D956D4  token: 0x60003F2
        private System.Boolean GetBoolInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D95A5C  token: 0x60003F3
        private System.Void SetBoolInternal(UnityEngine.Animations.AnimationStream& stream, System.Boolean value) { }
        // RVA: 0x09D959BC  token: 0x60003F4
        private static System.Void ResolveInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D95770  token: 0x60003F5
        private static System.Single GetFloatInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D95B08  token: 0x60003F6
        private static System.Void SetFloatInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, System.Single value) { }
        // RVA: 0x09D95848  token: 0x60003F7
        private static System.Int32 GetIntInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D95C00  token: 0x60003F8
        private static System.Void SetIntInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, System.Int32 value) { }
        // RVA: 0x09D95690  token: 0x60003F9
        private static System.Boolean GetBoolInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D95A08  token: 0x60003FA
        private static System.Void SetBoolInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, System.Boolean value) { }

    }

    // TypeToken: 0x200005F  // size: 0x18
    public sealed struct TransformSceneHandle
    {
        // Fields
        private System.UInt32 valid;  // 0x10
        private System.Int32 transformSceneHandleDefinitionIndex;  // 0x14

        // Properties
        System.Boolean createdByNative { get; /* RVA: 0x0426F724 */ }
        System.Boolean hasTransformSceneHandleDefinitionIndex { get; /* RVA: 0x09D95D18 */ }

        // Methods
        // RVA: 0x09D9655C  token: 0x60003FB
        public System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D95E00  token: 0x60003FE
        private System.Void CheckIsValid(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D963CC  token: 0x60003FF
        public UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D9603C  token: 0x6000400
        public UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D964B4  token: 0x6000401
        public UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D96124  token: 0x6000402
        public UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D96208  token: 0x6000403
        public UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09D962E0  token: 0x6000404
        public System.Void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        // RVA: 0x09D95F5C  token: 0x6000405
        public System.Void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        // RVA: 0x09D96554  token: 0x6000406
        private System.Boolean HasValidTransform(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D96398  token: 0x6000407
        private UnityEngine.Vector3 GetPositionInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D96008  token: 0x6000408
        private UnityEngine.Vector3 GetLocalPositionInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D96484  token: 0x6000409
        private UnityEngine.Quaternion GetRotationInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D960F4  token: 0x600040A
        private UnityEngine.Quaternion GetLocalRotationInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D961D4  token: 0x600040B
        private UnityEngine.Vector3 GetLocalScaleInternal(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D962D0  token: 0x600040C
        private System.Void GetLocalTRSInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        // RVA: 0x09D95F4C  token: 0x600040D
        private System.Void GetGlobalTRInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        // RVA: 0x09D96510  token: 0x600040E
        private static System.Boolean HasValidTransform_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09D96344  token: 0x600040F
        private static System.Void GetPositionInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret) { }
        // RVA: 0x09D95FB4  token: 0x6000410
        private static System.Void GetLocalPositionInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret) { }
        // RVA: 0x09D96430  token: 0x6000411
        private static System.Void GetRotationInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& ret) { }
        // RVA: 0x09D960A0  token: 0x6000412
        private static System.Void GetLocalRotationInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& ret) { }
        // RVA: 0x09D96180  token: 0x6000413
        private static System.Void GetLocalScaleInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret) { }
        // RVA: 0x09D9626C  token: 0x6000414
        private static System.Void GetLocalTRSInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        // RVA: 0x09D95EE8  token: 0x6000415
        private static System.Void GetGlobalTRInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }

    }

    // TypeToken: 0x2000060  // size: 0x18
    public sealed struct PropertySceneHandle
    {
        // Fields
        private System.UInt32 valid;  // 0x10
        private System.Int32 handleIndex;  // 0x14

    }

    // TypeToken: 0x2000061  // size: 0x10
    public static class AnimationSceneHandleUtility
    {
        // Methods
        // RVA: 0x09D8CA6C  token: 0x6000416
        public static System.Void ReadFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertySceneHandle> handles, Unity.Collections.NativeArray<System.Single> buffer) { }
        // RVA: -1  // generic def  token: 0x6000417
        private static System.Int32 ValidateAndGetArrayCount(UnityEngine.Animations.AnimationStream& stream, Unity.Collections.NativeArray<T0> handles, Unity.Collections.NativeArray<T1> buffer) { }
        // RVA: 0x09D8CB10  token: 0x6000418
        private static System.Void ReadSceneFloatsInternal(UnityEngine.Animations.AnimationStream& stream, System.Void* propertySceneHandles, System.Void* floatBuffer, System.Int32 count) { }

    }

    // TypeToken: 0x2000062  // size: 0x10
    public static class AnimationStreamHandleUtility
    {
        // Methods
        // RVA: 0x09D8D60C  token: 0x6000419
        public static System.Void WriteFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<System.Single> buffer, System.Boolean useMask) { }
        // RVA: 0x09D8D500  token: 0x600041A
        public static System.Void ReadFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<System.Single> buffer) { }
        // RVA: 0x09D8D5A8  token: 0x600041B
        private static System.Void ReadStreamFloatsInternal(UnityEngine.Animations.AnimationStream& stream, System.Void* propertyStreamHandles, System.Void* floatBuffer, System.Int32 count) { }
        // RVA: 0x09D8D6C4  token: 0x600041C
        private static System.Void WriteStreamFloatsInternal(UnityEngine.Animations.AnimationStream& stream, System.Void* propertyStreamHandles, System.Void* floatBuffer, System.Int32 count, System.Boolean useMask) { }

    }

    // TypeToken: 0x2000063  // size: 0x20
    public sealed struct AnimatorControllerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;  // 0x10
        private static readonly UnityEngine.Animations.AnimatorControllerPlayable m_NullPlayable;  // static @ 0x0

        // Methods
        // RVA: 0x09D8E3C8  token: 0x600041D
        public static UnityEngine.Animations.AnimatorControllerPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller) { }
        // RVA: 0x09D8E2F0  token: 0x600041E
        private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller) { }
        // RVA: 0x09D8E758  token: 0x600041F
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        // RVA: 0x03D695A0  token: 0x6000420
        public virtual UnityEngine.Playables.PlayableHandle GetHandle() { }
        // RVA: 0x09D8E590  token: 0x6000421
        public System.Void SetHandle(UnityEngine.Playables.PlayableHandle handle) { }
        // RVA: 0x09D8E46C  token: 0x6000422
        public virtual System.Boolean Equals(UnityEngine.Animations.AnimatorControllerPlayable other) { }
        // RVA: 0x09D8E538  token: 0x6000423
        public System.Boolean IsInTransition(System.Int32 layerIndex) { }
        // RVA: 0x09D8E28C  token: 0x6000424
        private static System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller, UnityEngine.Playables.PlayableHandle& handle) { }
        // RVA: 0x09D8E4F8  token: 0x6000425
        private static System.Boolean IsInTransitionInternal(UnityEngine.Playables.PlayableHandle& handle, System.Int32 layerIndex) { }
        // RVA: 0x09D8E6D4  token: 0x6000426
        private static System.Void .cctor() { }
        // RVA: 0x09D8E238  token: 0x6000427
        private static System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.RuntimeAnimatorController controller, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x2000064  // size: 0x14
    public sealed struct CustomStreamPropertyType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Animations.CustomStreamPropertyType Float;  // const
        public static UnityEngine.Animations.CustomStreamPropertyType Bool;  // const
        public static UnityEngine.Animations.CustomStreamPropertyType Int;  // const

    }

    // TypeToken: 0x2000065  // size: 0x10
    public static class AnimatorJobExtensions
    {
        // Methods
        // RVA: 0x09D8E948  token: 0x6000428
        public static UnityEngine.Animations.TransformStreamHandle BindStreamTransform(UnityEngine.Animator animator, UnityEngine.Transform transform) { }
        // RVA: 0x09D8E904  token: 0x6000429
        public static UnityEngine.Animations.PropertyStreamHandle BindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property) { }
        // RVA: 0x09D8E7E0  token: 0x600042A
        public static UnityEngine.Animations.PropertyStreamHandle BindCustomStreamProperty(UnityEngine.Animator animator, System.String property, UnityEngine.Animations.CustomStreamPropertyType type) { }
        // RVA: 0x09D8E89C  token: 0x600042B
        public static UnityEngine.Animations.PropertyStreamHandle BindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property, System.Boolean isObjectReference) { }
        // RVA: 0x09D8E878  token: 0x600042C
        public static UnityEngine.Animations.TransformSceneHandle BindSceneTransform(UnityEngine.Animator animator, UnityEngine.Transform transform) { }
        // RVA: 0x09D8E85C  token: 0x600042D
        public static UnityEngine.Animations.PropertySceneHandle BindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property) { }
        // RVA: 0x09D8E828  token: 0x600042E
        public static UnityEngine.Animations.PropertySceneHandle BindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property, System.Boolean isObjectReference) { }
        // RVA: 0x09D8EB18  token: 0x600042F
        private static System.Void InternalBindStreamTransform(UnityEngine.Animator animator, UnityEngine.Transform transform, UnityEngine.Animations.TransformStreamHandle& transformStreamHandle) { }
        // RVA: 0x09D8EAB4  token: 0x6000430
        private static System.Void InternalBindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property, System.Boolean isObjectReference, UnityEngine.Animations.PropertyStreamHandle& propertyStreamHandle) { }
        // RVA: 0x09D8E998  token: 0x6000431
        private static System.Void InternalBindCustomStreamProperty(UnityEngine.Animator animator, System.String property, UnityEngine.Animations.CustomStreamPropertyType propertyType, UnityEngine.Animations.PropertyStreamHandle& propertyStreamHandle) { }
        // RVA: 0x09D8EA60  token: 0x6000432
        private static System.Void InternalBindSceneTransform(UnityEngine.Animator animator, UnityEngine.Transform transform, UnityEngine.Animations.TransformSceneHandle& transformSceneHandle) { }
        // RVA: 0x09D8E9FC  token: 0x6000433
        private static System.Void InternalBindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property, System.Boolean isObjectReference, UnityEngine.Animations.PropertySceneHandle& propertySceneHandle) { }

    }

    // TypeToken: 0x2000066  // size: 0x14
    public sealed struct Axis
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Animations.Axis None;  // const
        public static UnityEngine.Animations.Axis X;  // const
        public static UnityEngine.Animations.Axis Y;  // const
        public static UnityEngine.Animations.Axis Z;  // const

    }

}

namespace UnityEngine.Experimental.Animations
{

    // TypeToken: 0x2000045  // size: 0x14
    public sealed struct AnimationStreamSource
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Experimental.Animations.AnimationStreamSource DefaultValues;  // const
        public static UnityEngine.Experimental.Animations.AnimationStreamSource PreviousInputs;  // const

    }

    // TypeToken: 0x2000046  // size: 0x10
    public static class AnimationPlayableOutputExtensions
    {
        // Methods
        // RVA: 0x09D8C24C  token: 0x600030E
        public static System.Void SetAnimationStreamSource(UnityEngine.Animations.AnimationPlayableOutput output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource) { }
        // RVA: 0x09D8C26C  token: 0x600030F
        public static System.Void SetSortingOrder(UnityEngine.Animations.AnimationPlayableOutput output, System.UInt16 sortingOrder) { }
        // RVA: 0x09D8C1E4  token: 0x6000310
        private static System.Void InternalSetAnimationStreamSource(UnityEngine.Playables.PlayableOutputHandle output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource) { }
        // RVA: 0x09D8C238  token: 0x6000311
        private static System.Void InternalSetSortingOrder(UnityEngine.Playables.PlayableOutputHandle output, System.Int32 sortingOrder) { }
        // RVA: 0x09D8C1A4  token: 0x6000312
        private static System.Void InternalSetAnimationStreamSource_Injected(UnityEngine.Playables.PlayableOutputHandle& output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource) { }
        // RVA: 0x09D8C1F8  token: 0x6000313
        private static System.Void InternalSetSortingOrder_Injected(UnityEngine.Playables.PlayableOutputHandle& output, System.Int32 sortingOrder) { }

    }

}

