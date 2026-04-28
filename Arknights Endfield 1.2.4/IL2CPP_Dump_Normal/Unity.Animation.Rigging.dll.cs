// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Animation.Rigging.dll
// Classes:  136
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x200001E  // size: 0x14
    public sealed struct WorldUpType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpType None;  // const
        public static UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpType SceneUp;  // const
        public static UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpType ObjectUp;  // const
        public static UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpType ObjectRotationUp;  // const
        public static UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpType Vector;  // const

    }

    // TypeToken: 0x200002E  // size: 0x14
    public sealed struct Space
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Animations.Rigging.OverrideTransformJob.Space World;  // const
        public static UnityEngine.Animations.Rigging.OverrideTransformJob.Space Local;  // const
        public static UnityEngine.Animations.Rigging.OverrideTransformJob.Space Pivot;  // const

    }

    // TypeToken: 0x2000032  // size: 0x30
    public sealed struct TransformSyncer : System.IDisposable
    {
        // Fields
        public Unity.Collections.NativeArray<UnityEngine.Animations.TransformSceneHandle> sceneHandles;  // 0x10
        public Unity.Collections.NativeArray<UnityEngine.Animations.TransformStreamHandle> streamHandles;  // 0x20

        // Methods
        // RVA: 0x09B5AF94  token: 0x60000D7
        public static UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.TransformSyncer Create(System.Int32 size) { }
        // RVA: 0x09B5B044  token: 0x60000D8
        public virtual System.Void Dispose() { }
        // RVA: 0x09B5AF18  token: 0x60000D9
        public System.Void BindAt(System.Int32 index, UnityEngine.Animator animator, UnityEngine.Transform transform) { }
        // RVA: 0x09B5B0C0  token: 0x60000DA
        public System.Void Sync(UnityEngine.Animations.AnimationStream& stream) { }

    }

    // TypeToken: 0x2000033  // size: 0x40
    public sealed struct PropertySyncer : System.IDisposable
    {
        // Fields
        public Unity.Collections.NativeArray<UnityEngine.Animations.PropertySceneHandle> sceneHandles;  // 0x10
        public Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> streamHandles;  // 0x20
        public Unity.Collections.NativeArray<System.Single> buffer;  // 0x30

        // Methods
        // RVA: 0x09B5570C  token: 0x60000DB
        public static UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.PropertySyncer Create(System.Int32 size) { }
        // RVA: 0x09B557FC  token: 0x60000DC
        public virtual System.Void Dispose() { }
        // RVA: 0x09B55640  token: 0x60000DD
        public System.Void BindAt(System.Int32 index, UnityEngine.Animator animator, UnityEngine.Component component, System.String property) { }
        // RVA: 0x09B55924  token: 0x60000DE
        public System.Void Sync(UnityEngine.Animations.AnimationStream& stream) { }
        // RVA: 0x09B558A8  token: 0x60000DF
        public Unity.Collections.NativeArray<System.Single> StreamValues(UnityEngine.Animations.AnimationStream& stream) { }

    }

    // TypeToken: 0x200004A  // size: 0x14
    public sealed struct Axis
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis X;  // const
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis X_NEG;  // const
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis Y;  // const
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis Y_NEG;  // const
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis Z;  // const
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis Z_NEG;  // const

    }

    // TypeToken: 0x200004B  // size: 0x14
    public sealed struct WorldUpType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpType None;  // const
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpType SceneUp;  // const
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpType ObjectUp;  // const
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpType ObjectRotationUp;  // const
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpType Vector;  // const

    }

    // TypeToken: 0x2000056  // size: 0x14
    public sealed struct Space
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Animations.Rigging.OverrideTransformData.Space World;  // const
        public static UnityEngine.Animations.Rigging.OverrideTransformData.Space Local;  // const
        public static UnityEngine.Animations.Rigging.OverrideTransformData.Space Pivot;  // const

    }

    // TypeToken: 0x200005B  // size: 0x14
    public sealed struct Axis
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Animations.Rigging.TwistCorrectionData.Axis X;  // const
        public static UnityEngine.Animations.Rigging.TwistCorrectionData.Axis Y;  // const
        public static UnityEngine.Animations.Rigging.TwistCorrectionData.Axis Z;  // const

    }

    // TypeToken: 0x2000065  // size: 0x80
    public sealed class OnAddRigBuilderCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x0613B2F0  token: 0x6000274
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x6000275
        public virtual System.Void Invoke(UnityEngine.Animations.Rigging.RigBuilder rigBuilder) { }
        // RVA: 0x0389C3B0  token: 0x6000276
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.Animations.Rigging.RigBuilder rigBuilder, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000277
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000066  // size: 0x80
    public sealed class OnRemoveRigBuilderCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x0613B2F0  token: 0x6000278
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x6000279
        public virtual System.Void Invoke(UnityEngine.Animations.Rigging.RigBuilder rigBuilder) { }
        // RVA: 0x0389C3B0  token: 0x600027A
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.Animations.Rigging.RigBuilder rigBuilder, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x600027B
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000068  // size: 0x20
    public sealed struct PlayableChain
    {
        // Fields
        public System.String name;  // 0x10
        public UnityEngine.Playables.Playable[] playables;  // 0x18

        // Methods
        // RVA: 0x09B55628  token: 0x6000280
        public System.Boolean IsValid() { }

    }

    // TypeToken: 0x200006D  // size: 0x30
    public sealed struct RigSyncSceneToStreamData : UnityEngine.Animations.Rigging.IAnimationJobData, UnityEngine.Animations.Rigging.IRigSyncSceneToStreamData
    {
        // Fields
        private UnityEngine.Transform[] <syncableTransforms>k__BackingField;  // 0x10
        private UnityEngine.Animations.Rigging.SyncableProperties[] <syncableProperties>k__BackingField;  // 0x18
        private System.Boolean[] <rigStates>k__BackingField;  // 0x20
        private readonly System.Boolean m_IsValid;  // 0x28

        // Properties
        UnityEngine.Transform[] syncableTransforms { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x042715A0 */ }
        UnityEngine.Animations.Rigging.SyncableProperties[] syncableProperties { get; /* RVA: 0x03D50DE0 */ set; /* RVA: 0x0558FF08 */ }
        System.Boolean[] rigStates { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x09B583B8  token: 0x60002AA
        public System.Void .ctor(UnityEngine.Transform[] transforms, UnityEngine.Animations.Rigging.SyncableProperties[] properties, System.Int32 rigCount) { }
        // RVA: 0x09B58230  token: 0x60002AB
        private static System.Int32[] UniqueTransformIndices(UnityEngine.Transform[] transforms) { }
        // RVA: 0x01002A50  token: 0x60002B2
        private virtual System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        // RVA: 0x09B58388  token: 0x60002B3
        private virtual System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x200006E  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly UnityEngine.Animations.Rigging.RigUtils.<>c <>9;  // static @ 0x0
        public static System.Func<System.Reflection.FieldInfo,System.Boolean> <>9__6_0;  // static @ 0x8

        // Methods
        // RVA: 0x09B5C738  token: 0x60002B4
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60002B5
        public System.Void .ctor() { }
        // RVA: 0x09B5C6F8  token: 0x60002B6
        private System.Boolean <ExtractNestedPropertyType>b__6_0(System.Reflection.FieldInfo info) { }

    }

    // TypeToken: 0x2000074  // size: 0xA0
    public sealed struct Enumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private UnityEngine.Animations.Rigging.WeightedTransformArray m_Array;  // 0x10
        private System.Int32 m_Index;  // 0x98

        // Properties
        UnityEngine.Animations.Rigging.WeightedTransform Current { get; /* RVA: 0x09B4FD40 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x09B4FC1C */ }

        // Methods
        // RVA: 0x09B4FC74  token: 0x60002ED
        public System.Void .ctor(UnityEngine.Animations.Rigging.WeightedTransformArray& array) { }
        // RVA: 0x09B4FBC8  token: 0x60002EE
        public virtual System.Boolean MoveNext() { }
        // RVA: 0x03D76380  token: 0x60002EF
        public virtual System.Void Reset() { }
        // RVA: 0x0350B670  token: 0x60002F0
        private virtual System.Void System.IDisposable.Dispose() { }

    }

    // TypeToken: 0x2000080  // size: 0x48
    public sealed struct Style
    {
        // Fields
        public UnityEngine.Mesh shape;  // 0x10
        public UnityEngine.Color color;  // 0x18
        public System.Single size;  // 0x28
        public UnityEngine.Vector3 position;  // 0x2c
        public UnityEngine.Vector3 rotation;  // 0x38

    }

    // TypeToken: 0x2000084  // size: 0x14
    public sealed struct BoneShape
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Animations.Rigging.BoneRenderer.BoneShape Line;  // const
        public static UnityEngine.Animations.Rigging.BoneRenderer.BoneShape Pyramid;  // const
        public static UnityEngine.Animations.Rigging.BoneRenderer.BoneShape Box;  // const

    }

    // TypeToken: 0x2000086  // size: 0x18
    public sealed class <>c__DisplayClass2_0
    {
        // Fields
        public System.Single totalLength;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x600031F
        public System.Void .ctor() { }
        // RVA: 0x03D764E0  token: 0x6000320
        private System.Void <ExtractSteps>b__0(System.Single length) { }

    }

namespace Microsoft.CodeAnalysis
{

    // TypeToken: 0x2000002  // size: 0x10
    public sealed class EmbeddedAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000001
        public System.Void .ctor() { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000003  // size: 0x10
    public sealed class IsUnmanagedAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000002
        public System.Void .ctor() { }

    }

}

namespace UnityEngine.Animations.Rigging
{

    // TypeToken: 0x2000004  // size: 0x14
    public sealed struct CacheIndex
    {
        // Fields
        private System.Int32 idx;  // 0x10

    }

    // TypeToken: 0x2000005  // size: 0x20
    public sealed struct AnimationJobCache : System.IDisposable
    {
        // Fields
        private Unity.Collections.NativeArray<System.Single> m_Data;  // 0x10

        // Methods
        // RVA: 0x09B4C31C  token: 0x6000003
        private System.Void .ctor(System.Single[] data) { }
        // RVA: 0x09B4C2E0  token: 0x6000004
        public virtual System.Void Dispose() { }
        // RVA: 0x03D76310  token: 0x6000005
        public System.Single GetRaw(UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset) { }
        // RVA: 0x03D76320  token: 0x6000006
        public System.Void SetRaw(System.Single val, UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset) { }
        // RVA: -1  // generic def  token: 0x6000007
        public T Get(UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset) { }
        // RVA: -1  // generic def  token: 0x6000008
        public System.Void Set(T val, UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset) { }
        // RVA: -1  // generic def  token: 0x6000009
        public System.Void SetArray(T[] v, UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset) { }

    }

    // TypeToken: 0x2000006  // size: 0x18
    public class AnimationJobCacheBuilder
    {
        // Fields
        private System.Collections.Generic.List<System.Single> m_Data;  // 0x10

        // Methods
        // RVA: 0x09B4C268  token: 0x600000A
        public System.Void .ctor() { }
        // RVA: 0x09B4BFE0  token: 0x600000B
        public UnityEngine.Animations.Rigging.CacheIndex Add(System.Single v) { }
        // RVA: 0x09B4C050  token: 0x600000C
        public UnityEngine.Animations.Rigging.CacheIndex Add(UnityEngine.Vector2 v) { }
        // RVA: 0x09B4BE60  token: 0x600000D
        public UnityEngine.Animations.Rigging.CacheIndex Add(UnityEngine.Vector3 v) { }
        // RVA: 0x09B4BDA0  token: 0x600000E
        public UnityEngine.Animations.Rigging.CacheIndex Add(UnityEngine.Vector4 v) { }
        // RVA: 0x09B4BFC0  token: 0x600000F
        public UnityEngine.Animations.Rigging.CacheIndex Add(UnityEngine.Quaternion v) { }
        // RVA: 0x09B4BF08  token: 0x6000010
        public UnityEngine.Animations.Rigging.CacheIndex Add(UnityEngine.Animations.Rigging.AffineTransform tx) { }
        // RVA: 0x09B4C0D8  token: 0x6000011
        public UnityEngine.Animations.Rigging.CacheIndex AllocateChunk(System.Int32 size) { }
        // RVA: 0x09B4C1DC  token: 0x6000012
        public System.Void SetValue(UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset, System.Single value) { }
        // RVA: 0x09B4C170  token: 0x6000013
        public UnityEngine.Animations.Rigging.AnimationJobCache Build() { }

    }

    // TypeToken: 0x2000007  // size: 0xD4
    public sealed struct BlendConstraintJob : UnityEngine.Animations.Rigging.IWeightedAnimationJob, UnityEngine.Animations.IAnimationJob
    {
        // Fields
        private static System.Int32 k_BlendTranslationMask;  // const
        private static System.Int32 k_BlendRotationMask;  // const
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle driven;  // 0x10
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle sourceA;  // 0x1c
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle sourceB;  // 0x34
        public UnityEngine.Animations.Rigging.AffineTransform sourceAOffset;  // 0x4c
        public UnityEngine.Animations.Rigging.AffineTransform sourceBOffset;  // 0x68
        public UnityEngine.Animations.Rigging.BoolProperty blendPosition;  // 0x84
        public UnityEngine.Animations.Rigging.BoolProperty blendRotation;  // 0x94
        public UnityEngine.Animations.Rigging.FloatProperty positionWeight;  // 0xa4
        public UnityEngine.Animations.Rigging.FloatProperty rotationWeight;  // 0xb4
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;  // 0xc4

        // Properties
        UnityEngine.Animations.Rigging.FloatProperty jobWeight { get; /* RVA: 0x03D76330 */ set; /* RVA: 0x03D76340 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000016
        public virtual System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B4DB00  token: 0x6000017
        public virtual System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x2000008
    public interface IBlendConstraintData
    {
        // Properties
        UnityEngine.Transform constrainedObject { get; /* RVA: -1  // abstract */ }
        UnityEngine.Transform sourceObjectA { get; /* RVA: -1  // abstract */ }
        UnityEngine.Transform sourceObjectB { get; /* RVA: -1  // abstract */ }
        System.Boolean maintainPositionOffsets { get; /* RVA: -1  // abstract */ }
        System.Boolean maintainRotationOffsets { get; /* RVA: -1  // abstract */ }
        System.String blendPositionBoolProperty { get; /* RVA: -1  // abstract */ }
        System.String blendRotationBoolProperty { get; /* RVA: -1  // abstract */ }
        System.String positionWeightFloatProperty { get; /* RVA: -1  // abstract */ }
        System.String rotationWeightFloatProperty { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000009
    public class BlendConstraintJobBinder`1 : UnityEngine.Animations.Rigging.AnimationJobBinder`2
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x6000021
        public virtual UnityEngine.Animations.Rigging.BlendConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        // RVA: -1  // not resolved  token: 0x6000022
        public virtual System.Void Destroy(UnityEngine.Animations.Rigging.BlendConstraintJob job) { }
        // RVA: -1  // not resolved  token: 0x6000023
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000A  // size: 0xC8
    public sealed struct ChainIKConstraintJob : UnityEngine.Animations.Rigging.IWeightedAnimationJob, UnityEngine.Animations.IAnimationJob
    {
        // Fields
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadWriteTransformHandle> chain;  // 0x10
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle target;  // 0x20
        public UnityEngine.Animations.Rigging.AffineTransform targetOffset;  // 0x38
        public Unity.Collections.NativeArray<System.Single> linkLengths;  // 0x58
        public Unity.Collections.NativeArray<UnityEngine.Vector3> linkPositions;  // 0x68
        public UnityEngine.Animations.Rigging.FloatProperty chainRotationWeight;  // 0x78
        public UnityEngine.Animations.Rigging.FloatProperty tipRotationWeight;  // 0x88
        public UnityEngine.Animations.Rigging.CacheIndex toleranceIdx;  // 0x98
        public UnityEngine.Animations.Rigging.CacheIndex maxIterationsIdx;  // 0x9c
        public UnityEngine.Animations.Rigging.AnimationJobCache cache;  // 0xa0
        public System.Single maxReach;  // 0xb0
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;  // 0xb4

        // Properties
        UnityEngine.Animations.Rigging.FloatProperty jobWeight { get; /* RVA: 0x03D76350 */ set; /* RVA: 0x03D76360 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000026
        public virtual System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B4E4EC  token: 0x6000027
        public virtual System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x200000B
    public interface IChainIKConstraintData
    {
        // Properties
        UnityEngine.Transform root { get; /* RVA: -1  // abstract */ }
        UnityEngine.Transform tip { get; /* RVA: -1  // abstract */ }
        UnityEngine.Transform target { get; /* RVA: -1  // abstract */ }
        System.Int32 maxIterations { get; /* RVA: -1  // abstract */ }
        System.Single tolerance { get; /* RVA: -1  // abstract */ }
        System.Boolean maintainTargetPositionOffset { get; /* RVA: -1  // abstract */ }
        System.Boolean maintainTargetRotationOffset { get; /* RVA: -1  // abstract */ }
        System.String chainRotationWeightFloatProperty { get; /* RVA: -1  // abstract */ }
        System.String tipRotationWeightFloatProperty { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x200000C
    public class ChainIKConstraintJobBinder`1 : UnityEngine.Animations.Rigging.AnimationJobBinder`2
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x6000031
        public virtual UnityEngine.Animations.Rigging.ChainIKConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        // RVA: -1  // not resolved  token: 0x6000032
        public virtual System.Void Destroy(UnityEngine.Animations.Rigging.ChainIKConstraintJob job) { }
        // RVA: -1  // not resolved  token: 0x6000033
        public virtual System.Void Update(UnityEngine.Animations.Rigging.ChainIKConstraintJob job, T& data) { }
        // RVA: -1  // not resolved  token: 0x6000034
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000D  // size: 0xA8
    public sealed struct DampedTransformJob : UnityEngine.Animations.Rigging.IWeightedAnimationJob, UnityEngine.Animations.IAnimationJob
    {
        // Fields
        private static System.Single k_FixedDt;  // const
        private static System.Single k_DampFactor;  // const
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle driven;  // 0x10
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle source;  // 0x1c
        public UnityEngine.Animations.Rigging.AffineTransform localBindTx;  // 0x34
        public UnityEngine.Vector3 aimBindAxis;  // 0x50
        public UnityEngine.Animations.Rigging.AffineTransform prevDrivenTx;  // 0x5c
        public UnityEngine.Animations.Rigging.FloatProperty dampPosition;  // 0x78
        public UnityEngine.Animations.Rigging.FloatProperty dampRotation;  // 0x88
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;  // 0x98

        // Properties
        UnityEngine.Animations.Rigging.FloatProperty jobWeight { get; /* RVA: 0x03D5C7E0 */ set; /* RVA: 0x03D76370 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000037
        public virtual System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B4F368  token: 0x6000038
        public virtual System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x200000E
    public interface IDampedTransformData
    {
        // Properties
        UnityEngine.Transform constrainedObject { get; /* RVA: -1  // abstract */ }
        UnityEngine.Transform sourceObject { get; /* RVA: -1  // abstract */ }
        System.Boolean maintainAim { get; /* RVA: -1  // abstract */ }
        System.String dampPositionFloatProperty { get; /* RVA: -1  // abstract */ }
        System.String dampRotationFloatProperty { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x200000F
    public class DampedTransformJobBinder`1 : UnityEngine.Animations.Rigging.AnimationJobBinder`2
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x600003E
        public virtual UnityEngine.Animations.Rigging.DampedTransformJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        // RVA: -1  // not resolved  token: 0x600003F
        public virtual System.Void Destroy(UnityEngine.Animations.Rigging.DampedTransformJob job) { }
        // RVA: -1  // not resolved  token: 0x6000040
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000010
    public interface IAnimatableProperty`1
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000041
        public virtual T Get(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: -1  // abstract  token: 0x6000042
        public virtual System.Void Set(UnityEngine.Animations.AnimationStream stream, T value) { }

    }

    // TypeToken: 0x2000011  // size: 0x20
    public sealed struct BoolProperty : UnityEngine.Animations.Rigging.IAnimatableProperty`1
    {
        // Fields
        public UnityEngine.Animations.PropertyStreamHandle value;  // 0x10

        // Methods
        // RVA: 0x09B4E1A0  token: 0x6000043
        public static UnityEngine.Animations.Rigging.BoolProperty Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name) { }
        // RVA: 0x09B4E168  token: 0x6000044
        public static UnityEngine.Animations.Rigging.BoolProperty BindCustom(UnityEngine.Animator animator, System.String property) { }
        // RVA: 0x09B4E230  token: 0x6000045
        public virtual System.Boolean Get(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B4E26C  token: 0x6000046
        public virtual System.Void Set(UnityEngine.Animations.AnimationStream stream, System.Boolean v) { }

    }

    // TypeToken: 0x2000012  // size: 0x20
    public sealed struct IntProperty : UnityEngine.Animations.Rigging.IAnimatableProperty`1
    {
        // Fields
        public UnityEngine.Animations.PropertyStreamHandle value;  // 0x10

        // Methods
        // RVA: 0x09B4E1A0  token: 0x6000047
        public static UnityEngine.Animations.Rigging.IntProperty Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name) { }
        // RVA: 0x09B4FE60  token: 0x6000048
        public static UnityEngine.Animations.Rigging.IntProperty BindCustom(UnityEngine.Animator animator, System.String property) { }
        // RVA: 0x09B4FE98  token: 0x6000049
        public virtual System.Int32 Get(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B4FED4  token: 0x600004A
        public virtual System.Void Set(UnityEngine.Animations.AnimationStream stream, System.Int32 v) { }

    }

    // TypeToken: 0x2000013  // size: 0x20
    public sealed struct FloatProperty : UnityEngine.Animations.Rigging.IAnimatableProperty`1
    {
        // Fields
        public UnityEngine.Animations.PropertyStreamHandle value;  // 0x10

        // Methods
        // RVA: 0x09B4E1A0  token: 0x600004B
        public static UnityEngine.Animations.Rigging.FloatProperty Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name) { }
        // RVA: 0x09B4FDB0  token: 0x600004C
        public static UnityEngine.Animations.Rigging.FloatProperty BindCustom(UnityEngine.Animator animator, System.String property) { }
        // RVA: 0x09B4FDE8  token: 0x600004D
        public virtual System.Single Get(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B4FE24  token: 0x600004E
        public virtual System.Void Set(UnityEngine.Animations.AnimationStream stream, System.Single v) { }

    }

    // TypeToken: 0x2000014  // size: 0x30
    public sealed struct Vector2Property : UnityEngine.Animations.Rigging.IAnimatableProperty`1
    {
        // Fields
        public UnityEngine.Animations.PropertyStreamHandle x;  // 0x10
        public UnityEngine.Animations.PropertyStreamHandle y;  // 0x20

        // Methods
        // RVA: 0x09B5C864  token: 0x600004F
        public static UnityEngine.Animations.Rigging.Vector2Property Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name) { }
        // RVA: 0x09B5C79C  token: 0x6000050
        public static UnityEngine.Animations.Rigging.Vector2Property BindCustom(UnityEngine.Animator animator, System.String name) { }
        // RVA: 0x09B5C984  token: 0x6000051
        public virtual UnityEngine.Vector2 Get(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B5CA2C  token: 0x6000052
        public virtual System.Void Set(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector2 value) { }

    }

    // TypeToken: 0x2000015  // size: 0x40
    public sealed struct Vector3Property : UnityEngine.Animations.Rigging.IAnimatableProperty`1
    {
        // Fields
        public UnityEngine.Animations.PropertyStreamHandle x;  // 0x10
        public UnityEngine.Animations.PropertyStreamHandle y;  // 0x20
        public UnityEngine.Animations.PropertyStreamHandle z;  // 0x30

        // Methods
        // RVA: 0x09B5D488  token: 0x6000053
        public static UnityEngine.Animations.Rigging.Vector3Property Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name) { }
        // RVA: 0x09B5D378  token: 0x6000054
        public static UnityEngine.Animations.Rigging.Vector3Property BindCustom(UnityEngine.Animator animator, System.String name) { }
        // RVA: 0x09B5D600  token: 0x6000055
        public virtual UnityEngine.Vector3 Get(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B5D700  token: 0x6000056
        public virtual System.Void Set(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 value) { }

    }

    // TypeToken: 0x2000016  // size: 0x40
    public sealed struct Vector3IntProperty : UnityEngine.Animations.Rigging.IAnimatableProperty`1
    {
        // Fields
        public UnityEngine.Animations.PropertyStreamHandle x;  // 0x10
        public UnityEngine.Animations.PropertyStreamHandle y;  // 0x20
        public UnityEngine.Animations.PropertyStreamHandle z;  // 0x30

        // Methods
        // RVA: 0x09B5D038  token: 0x6000057
        public static UnityEngine.Animations.Rigging.Vector3IntProperty Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name) { }
        // RVA: 0x09B5CF28  token: 0x6000058
        public static UnityEngine.Animations.Rigging.Vector3IntProperty BindCustom(UnityEngine.Animator animator, System.String name) { }
        // RVA: 0x09B5D1B0  token: 0x6000059
        public virtual UnityEngine.Vector3Int Get(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B5D2A0  token: 0x600005A
        public virtual System.Void Set(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3Int value) { }

    }

    // TypeToken: 0x2000017  // size: 0x40
    public sealed struct Vector3BoolProperty : UnityEngine.Animations.Rigging.IAnimatableProperty`1
    {
        // Fields
        public UnityEngine.Animations.PropertyStreamHandle x;  // 0x10
        public UnityEngine.Animations.PropertyStreamHandle y;  // 0x20
        public UnityEngine.Animations.PropertyStreamHandle z;  // 0x30

        // Methods
        // RVA: 0x09B5CBE8  token: 0x600005B
        public static UnityEngine.Animations.Rigging.Vector3BoolProperty Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name) { }
        // RVA: 0x09B5CAD8  token: 0x600005C
        public static UnityEngine.Animations.Rigging.Vector3BoolProperty BindCustom(UnityEngine.Animator animator, System.String name) { }
        // RVA: 0x09B5CD60  token: 0x600005D
        public virtual UnityEngine.Animations.Rigging.Vector3Bool Get(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B5CE50  token: 0x600005E
        public virtual System.Void Set(UnityEngine.Animations.AnimationStream stream, UnityEngine.Animations.Rigging.Vector3Bool value) { }

    }

    // TypeToken: 0x2000018  // size: 0x50
    public sealed struct Vector4Property : UnityEngine.Animations.Rigging.IAnimatableProperty`1
    {
        // Fields
        public UnityEngine.Animations.PropertyStreamHandle x;  // 0x10
        public UnityEngine.Animations.PropertyStreamHandle y;  // 0x20
        public UnityEngine.Animations.PropertyStreamHandle z;  // 0x30
        public UnityEngine.Animations.PropertyStreamHandle w;  // 0x40

        // Methods
        // RVA: 0x09B5D92C  token: 0x600005F
        public static UnityEngine.Animations.Rigging.Vector4Property Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name) { }
        // RVA: 0x09B5D7DC  token: 0x6000060
        public static UnityEngine.Animations.Rigging.Vector4Property BindCustom(UnityEngine.Animator animator, System.String name) { }
        // RVA: 0x09B5DAF8  token: 0x6000061
        public virtual UnityEngine.Vector4 Get(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B5DC44  token: 0x6000062
        public virtual System.Void Set(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector4 value) { }

    }

    // TypeToken: 0x2000019
    public interface IAnimationJobBinder
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000063
        public virtual UnityEngine.Animations.IAnimationJob Create(UnityEngine.Animator animator, UnityEngine.Animations.Rigging.IAnimationJobData data, UnityEngine.Component component) { }
        // RVA: -1  // abstract  token: 0x6000064
        public virtual System.Void Destroy(UnityEngine.Animations.IAnimationJob job) { }
        // RVA: -1  // abstract  token: 0x6000065
        public virtual System.Void Update(UnityEngine.Animations.IAnimationJob job, UnityEngine.Animations.Rigging.IAnimationJobData data) { }
        // RVA: -1  // abstract  token: 0x6000066
        public virtual UnityEngine.Animations.AnimationScriptPlayable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.IAnimationJob job) { }

    }

    // TypeToken: 0x200001A
    public abstract class AnimationJobBinder`2 : UnityEngine.Animations.Rigging.IAnimationJobBinder
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000067
        public virtual TJob Create(UnityEngine.Animator animator, TData& data, UnityEngine.Component component) { }
        // RVA: -1  // abstract  token: 0x6000068
        public virtual System.Void Destroy(TJob job) { }
        // RVA: -1  // not resolved  token: 0x6000069
        public virtual System.Void Update(TJob job, TData& data) { }
        // RVA: -1  // not resolved  token: 0x600006A
        private virtual UnityEngine.Animations.IAnimationJob UnityEngine.Animations.Rigging.IAnimationJobBinder.Create(UnityEngine.Animator animator, UnityEngine.Animations.Rigging.IAnimationJobData data, UnityEngine.Component component) { }
        // RVA: -1  // not resolved  token: 0x600006B
        private virtual System.Void UnityEngine.Animations.Rigging.IAnimationJobBinder.Destroy(UnityEngine.Animations.IAnimationJob job) { }
        // RVA: -1  // not resolved  token: 0x600006C
        private virtual System.Void UnityEngine.Animations.Rigging.IAnimationJobBinder.Update(UnityEngine.Animations.IAnimationJob job, UnityEngine.Animations.Rigging.IAnimationJobData data) { }
        // RVA: -1  // not resolved  token: 0x600006D
        private virtual UnityEngine.Animations.AnimationScriptPlayable UnityEngine.Animations.Rigging.IAnimationJobBinder.CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.IAnimationJob job) { }
        // RVA: -1  // not resolved  token: 0x600006E
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x200001B
    public interface IAnimationJobData
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600006F
        public virtual System.Boolean IsValid() { }
        // RVA: -1  // abstract  token: 0x6000070
        public virtual System.Void SetDefaultValues() { }

    }

    // TypeToken: 0x200001C
    public interface IWeightedAnimationJob : UnityEngine.Animations.IAnimationJob
    {
        // Properties
        UnityEngine.Animations.Rigging.FloatProperty jobWeight { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x200001D  // size: 0x128
    public sealed struct MultiAimConstraintJob : UnityEngine.Animations.Rigging.IWeightedAnimationJob, UnityEngine.Animations.IAnimationJob
    {
        // Fields
        private static System.Single k_Epsilon;  // const
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle driven;  // 0x10
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle drivenParent;  // 0x1c
        public UnityEngine.Animations.Rigging.Vector3Property drivenOffset;  // 0x34
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadOnlyTransformHandle> sourceTransforms;  // 0x68
        public Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> sourceWeights;  // 0x78
        public Unity.Collections.NativeArray<UnityEngine.Quaternion> sourceOffsets;  // 0x88
        public Unity.Collections.NativeArray<System.Single> weightBuffer;  // 0x98
        public UnityEngine.Vector3 aimAxis;  // 0xa8
        public UnityEngine.Vector3 upAxis;  // 0xb4
        public UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpType worldUpType;  // 0xc0
        public UnityEngine.Vector3 worldUpAxis;  // 0xc4
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle worldUpObject;  // 0xd0
        public UnityEngine.Vector3 axesMask;  // 0xe8
        public UnityEngine.Animations.Rigging.FloatProperty minLimit;  // 0xf4
        public UnityEngine.Animations.Rigging.FloatProperty maxLimit;  // 0x104
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;  // 0x114

        // Properties
        UnityEngine.Animations.Rigging.FloatProperty jobWeight { get; /* RVA: 0x03D76450 */ set; /* RVA: 0x03D76460 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000075
        public virtual System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B50684  token: 0x6000076
        public virtual System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B50404  token: 0x6000077
        private UnityEngine.Vector3 ComputeWorldUpVector(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x200001F
    public interface IMultiAimConstraintData
    {
        // Properties
        UnityEngine.Transform constrainedObject { get; /* RVA: -1  // abstract */ }
        UnityEngine.Animations.Rigging.WeightedTransformArray sourceObjects { get; /* RVA: -1  // abstract */ }
        System.Boolean maintainOffset { get; /* RVA: -1  // abstract */ }
        UnityEngine.Vector3 aimAxis { get; /* RVA: -1  // abstract */ }
        UnityEngine.Vector3 upAxis { get; /* RVA: -1  // abstract */ }
        System.Int32 worldUpType { get; /* RVA: -1  // abstract */ }
        UnityEngine.Vector3 worldUpAxis { get; /* RVA: -1  // abstract */ }
        UnityEngine.Transform worldUpObject { get; /* RVA: -1  // abstract */ }
        System.Boolean constrainedXAxis { get; /* RVA: -1  // abstract */ }
        System.Boolean constrainedYAxis { get; /* RVA: -1  // abstract */ }
        System.Boolean constrainedZAxis { get; /* RVA: -1  // abstract */ }
        System.String offsetVector3Property { get; /* RVA: -1  // abstract */ }
        System.String minLimitFloatProperty { get; /* RVA: -1  // abstract */ }
        System.String maxLimitFloatProperty { get; /* RVA: -1  // abstract */ }
        System.String sourceObjectsProperty { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000020
    public class MultiAimConstraintJobBinder`1 : UnityEngine.Animations.Rigging.AnimationJobBinder`2
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x6000087
        public virtual UnityEngine.Animations.Rigging.MultiAimConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        // RVA: -1  // not resolved  token: 0x6000088
        public virtual System.Void Destroy(UnityEngine.Animations.Rigging.MultiAimConstraintJob job) { }
        // RVA: -1  // not resolved  token: 0x6000089
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000021  // size: 0xA0
    public sealed struct MultiParentConstraintJob : UnityEngine.Animations.Rigging.IWeightedAnimationJob, UnityEngine.Animations.IAnimationJob
    {
        // Fields
        private static System.Single k_Epsilon;  // const
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle driven;  // 0x10
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle drivenParent;  // 0x1c
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadOnlyTransformHandle> sourceTransforms;  // 0x38
        public Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> sourceWeights;  // 0x48
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.AffineTransform> sourceOffsets;  // 0x58
        public Unity.Collections.NativeArray<System.Single> weightBuffer;  // 0x68
        public UnityEngine.Vector3 positionAxesMask;  // 0x78
        public UnityEngine.Vector3 rotationAxesMask;  // 0x84
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;  // 0x90

        // Properties
        UnityEngine.Animations.Rigging.FloatProperty jobWeight { get; /* RVA: 0x03D5AAF0 */ set; /* RVA: 0x03D68EB0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600008C
        public virtual System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B51A08  token: 0x600008D
        public virtual System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x2000022
    public interface IMultiParentConstraintData
    {
        // Properties
        UnityEngine.Transform constrainedObject { get; /* RVA: -1  // abstract */ }
        UnityEngine.Animations.Rigging.WeightedTransformArray sourceObjects { get; /* RVA: -1  // abstract */ }
        System.Boolean maintainPositionOffset { get; /* RVA: -1  // abstract */ }
        System.Boolean maintainRotationOffset { get; /* RVA: -1  // abstract */ }
        System.Boolean constrainedPositionXAxis { get; /* RVA: -1  // abstract */ }
        System.Boolean constrainedPositionYAxis { get; /* RVA: -1  // abstract */ }
        System.Boolean constrainedPositionZAxis { get; /* RVA: -1  // abstract */ }
        System.Boolean constrainedRotationXAxis { get; /* RVA: -1  // abstract */ }
        System.Boolean constrainedRotationYAxis { get; /* RVA: -1  // abstract */ }
        System.Boolean constrainedRotationZAxis { get; /* RVA: -1  // abstract */ }
        System.String sourceObjectsProperty { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000023
    public class MultiParentConstraintJobBinder`1 : UnityEngine.Animations.Rigging.AnimationJobBinder`2
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x6000099
        public virtual UnityEngine.Animations.Rigging.MultiParentConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        // RVA: -1  // not resolved  token: 0x600009A
        public virtual System.Void Destroy(UnityEngine.Animations.Rigging.MultiParentConstraintJob job) { }
        // RVA: -1  // not resolved  token: 0x600009B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000024  // size: 0xC8
    public sealed struct MultiPositionConstraintJob : UnityEngine.Animations.Rigging.IWeightedAnimationJob, UnityEngine.Animations.IAnimationJob
    {
        // Fields
        private static System.Single k_Epsilon;  // const
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle driven;  // 0x10
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle drivenParent;  // 0x1c
        public UnityEngine.Animations.Rigging.Vector3Property drivenOffset;  // 0x34
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadOnlyTransformHandle> sourceTransforms;  // 0x68
        public Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> sourceWeights;  // 0x78
        public Unity.Collections.NativeArray<UnityEngine.Vector3> sourceOffsets;  // 0x88
        public Unity.Collections.NativeArray<System.Single> weightBuffer;  // 0x98
        public UnityEngine.Vector3 axesMask;  // 0xa8
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;  // 0xb4

        // Properties
        UnityEngine.Animations.Rigging.FloatProperty jobWeight { get; /* RVA: 0x03D76350 */ set; /* RVA: 0x03D76360 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600009E
        public virtual System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B528D8  token: 0x600009F
        public virtual System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x2000025
    public interface IMultiPositionConstraintData
    {
        // Properties
        UnityEngine.Transform constrainedObject { get; /* RVA: -1  // abstract */ }
        UnityEngine.Animations.Rigging.WeightedTransformArray sourceObjects { get; /* RVA: -1  // abstract */ }
        System.Boolean maintainOffset { get; /* RVA: -1  // abstract */ }
        System.String offsetVector3Property { get; /* RVA: -1  // abstract */ }
        System.String sourceObjectsProperty { get; /* RVA: -1  // abstract */ }
        System.Boolean constrainedXAxis { get; /* RVA: -1  // abstract */ }
        System.Boolean constrainedYAxis { get; /* RVA: -1  // abstract */ }
        System.Boolean constrainedZAxis { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000026
    public class MultiPositionConstraintJobBinder`1 : UnityEngine.Animations.Rigging.AnimationJobBinder`2
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x60000A8
        public virtual UnityEngine.Animations.Rigging.MultiPositionConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        // RVA: -1  // not resolved  token: 0x60000A9
        public virtual System.Void Destroy(UnityEngine.Animations.Rigging.MultiPositionConstraintJob job) { }
        // RVA: -1  // not resolved  token: 0x60000AA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000027  // size: 0x68
    public sealed struct MultiReferentialConstraintJob : UnityEngine.Animations.Rigging.IWeightedAnimationJob, UnityEngine.Animations.IAnimationJob
    {
        // Fields
        public UnityEngine.Animations.Rigging.IntProperty driver;  // 0x10
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadWriteTransformHandle> sources;  // 0x20
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.AffineTransform> sourceBindTx;  // 0x30
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.AffineTransform> offsetTx;  // 0x40
        private System.Int32 m_PrevDriverIdx;  // 0x50
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;  // 0x54

        // Properties
        UnityEngine.Animations.Rigging.FloatProperty jobWeight { get; /* RVA: 0x03D76190 */ set; /* RVA: 0x03D761A0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60000AD
        public virtual System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B5355C  token: 0x60000AE
        public virtual System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B53A14  token: 0x60000AF
        private System.Void UpdateOffsets(System.Int32 driver) { }

    }

    // TypeToken: 0x2000028
    public interface IMultiReferentialConstraintData
    {
        // Properties
        System.Int32 driverValue { get; /* RVA: -1  // abstract */ }
        System.String driverIntProperty { get; /* RVA: -1  // abstract */ }
        UnityEngine.Transform[] sourceObjects { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000029
    public class MultiReferentialConstraintJobBinder`1 : UnityEngine.Animations.Rigging.AnimationJobBinder`2
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x60000B3
        public virtual UnityEngine.Animations.Rigging.MultiReferentialConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        // RVA: -1  // not resolved  token: 0x60000B4
        public virtual System.Void Destroy(UnityEngine.Animations.Rigging.MultiReferentialConstraintJob job) { }
        // RVA: -1  // not resolved  token: 0x60000B5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002A  // size: 0xC8
    public sealed struct MultiRotationConstraintJob : UnityEngine.Animations.Rigging.IWeightedAnimationJob, UnityEngine.Animations.IAnimationJob
    {
        // Fields
        private static System.Single k_Epsilon;  // const
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle driven;  // 0x10
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle drivenParent;  // 0x1c
        public UnityEngine.Animations.Rigging.Vector3Property drivenOffset;  // 0x34
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadOnlyTransformHandle> sourceTransforms;  // 0x68
        public Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> sourceWeights;  // 0x78
        public Unity.Collections.NativeArray<UnityEngine.Quaternion> sourceOffsets;  // 0x88
        public Unity.Collections.NativeArray<System.Single> weightBuffer;  // 0x98
        public UnityEngine.Vector3 axesMask;  // 0xa8
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;  // 0xb4

        // Properties
        UnityEngine.Animations.Rigging.FloatProperty jobWeight { get; /* RVA: 0x03D76350 */ set; /* RVA: 0x03D76360 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60000B8
        public virtual System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B53EB8  token: 0x60000B9
        public virtual System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x200002B
    public interface IMultiRotationConstraintData
    {
        // Properties
        UnityEngine.Transform constrainedObject { get; /* RVA: -1  // abstract */ }
        UnityEngine.Animations.Rigging.WeightedTransformArray sourceObjects { get; /* RVA: -1  // abstract */ }
        System.Boolean maintainOffset { get; /* RVA: -1  // abstract */ }
        System.String offsetVector3Property { get; /* RVA: -1  // abstract */ }
        System.String sourceObjectsProperty { get; /* RVA: -1  // abstract */ }
        System.Boolean constrainedXAxis { get; /* RVA: -1  // abstract */ }
        System.Boolean constrainedYAxis { get; /* RVA: -1  // abstract */ }
        System.Boolean constrainedZAxis { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x200002C
    public class MultiRotationConstraintJobBinder`1 : UnityEngine.Animations.Rigging.AnimationJobBinder`2
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x60000C2
        public virtual UnityEngine.Animations.Rigging.MultiRotationConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        // RVA: -1  // not resolved  token: 0x60000C3
        public virtual System.Void Destroy(UnityEngine.Animations.Rigging.MultiRotationConstraintJob job) { }
        // RVA: -1  // not resolved  token: 0x60000C4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002D  // size: 0x128
    public sealed struct OverrideTransformJob : UnityEngine.Animations.Rigging.IWeightedAnimationJob, UnityEngine.Animations.IAnimationJob
    {
        // Fields
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle driven;  // 0x10
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle source;  // 0x1c
        public UnityEngine.Animations.Rigging.AffineTransform sourceInvLocalBindTx;  // 0x34
        public UnityEngine.Quaternion sourceToWorldRot;  // 0x50
        public UnityEngine.Quaternion sourceToLocalRot;  // 0x60
        public UnityEngine.Quaternion sourceToPivotRot;  // 0x70
        public UnityEngine.Animations.Rigging.CacheIndex spaceIdx;  // 0x80
        public UnityEngine.Animations.Rigging.CacheIndex sourceToCurrSpaceRotIdx;  // 0x84
        public UnityEngine.Animations.Rigging.Vector3Property position;  // 0x88
        public UnityEngine.Animations.Rigging.Vector3Property rotation;  // 0xb8
        public UnityEngine.Animations.Rigging.FloatProperty positionWeight;  // 0xe8
        public UnityEngine.Animations.Rigging.FloatProperty rotationWeight;  // 0xf8
        public UnityEngine.Animations.Rigging.AnimationJobCache cache;  // 0x108
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;  // 0x118

        // Properties
        UnityEngine.Animations.Rigging.FloatProperty jobWeight { get; /* RVA: 0x03D75440 */ set; /* RVA: 0x03D754A0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60000C7
        public virtual System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B54C74  token: 0x60000C8
        public virtual System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B554D0  token: 0x60000C9
        private System.Void UpdateSpace(System.Int32 space) { }

    }

    // TypeToken: 0x200002F
    public interface IOverrideTransformData
    {
        // Properties
        UnityEngine.Transform constrainedObject { get; /* RVA: -1  // abstract */ }
        UnityEngine.Transform sourceObject { get; /* RVA: -1  // abstract */ }
        System.Int32 space { get; /* RVA: -1  // abstract */ }
        System.String positionWeightFloatProperty { get; /* RVA: -1  // abstract */ }
        System.String rotationWeightFloatProperty { get; /* RVA: -1  // abstract */ }
        System.String positionVector3Property { get; /* RVA: -1  // abstract */ }
        System.String rotationVector3Property { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000030
    public class OverrideTransformJobBinder`1 : UnityEngine.Animations.Rigging.AnimationJobBinder`2
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x60000D1
        public virtual UnityEngine.Animations.Rigging.OverrideTransformJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        // RVA: -1  // not resolved  token: 0x60000D2
        public virtual System.Void Destroy(UnityEngine.Animations.Rigging.OverrideTransformJob job) { }
        // RVA: -1  // not resolved  token: 0x60000D3
        public virtual System.Void Update(UnityEngine.Animations.Rigging.OverrideTransformJob job, T& data) { }
        // RVA: -1  // not resolved  token: 0x60000D4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000031  // size: 0xF0
    public sealed struct RigSyncSceneToStreamJob : UnityEngine.Animations.IAnimationJob
    {
        // Fields
        public UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.TransformSyncer transformSyncer;  // 0x10
        public UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.PropertySyncer propertySyncer;  // 0x30
        public UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.PropertySyncer rigWeightSyncer;  // 0x60
        public UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.PropertySyncer constraintWeightSyncer;  // 0x90
        public Unity.Collections.NativeArray<System.Single> rigStates;  // 0xc0
        public Unity.Collections.NativeArray<System.Int32> rigConstraintEndIdx;  // 0xd0
        public Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> modulatedConstraintWeights;  // 0xe0

        // Methods
        // RVA: 0x0350B670  token: 0x60000D5
        public virtual System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B58540  token: 0x60000D6
        public virtual System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x2000034  // size: 0x20
    public sealed struct SyncableProperties
    {
        // Fields
        public UnityEngine.Animations.Rigging.RigProperties rig;  // 0x10
        public UnityEngine.Animations.Rigging.ConstraintProperties[] constraints;  // 0x18

    }

    // TypeToken: 0x2000035
    public interface IRigSyncSceneToStreamData
    {
        // Properties
        UnityEngine.Transform[] syncableTransforms { get; /* RVA: -1  // abstract */ }
        UnityEngine.Animations.Rigging.SyncableProperties[] syncableProperties { get; /* RVA: -1  // abstract */ }
        System.Boolean[] rigStates { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000036
    public class RigSyncSceneToStreamJobBinder`1 : UnityEngine.Animations.Rigging.AnimationJobBinder`2
    {
        // Fields
        private static System.String[] s_PropertyElementNames;  // static @ 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60000E3
        public virtual UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        // RVA: -1  // not resolved  token: 0x60000E4
        public virtual System.Void Destroy(UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob job) { }
        // RVA: -1  // not resolved  token: 0x60000E5
        public virtual System.Void Update(UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob job, T& data) { }
        // RVA: -1  // not resolved  token: 0x60000E6
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60000E7
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000037  // size: 0x1C
    public sealed struct ReadWriteTransformHandle
    {
        // Fields
        private UnityEngine.Animations.TransformStreamHandle m_Handle;  // 0x10

        // Methods
        // RVA: 0x09B5640C  token: 0x60000E8
        public UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B56464  token: 0x60000E9
        public UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B564B4  token: 0x60000EA
        public UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B5650C  token: 0x60000EB
        public System.Void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        // RVA: 0x09B56730  token: 0x60000EC
        public System.Void SetLocalPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position) { }
        // RVA: 0x09B56784  token: 0x60000ED
        public System.Void SetLocalRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09B567CC  token: 0x60000EE
        public System.Void SetLocalScale(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 scale) { }
        // RVA: 0x09B56820  token: 0x60000EF
        public System.Void SetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, System.Boolean useMask) { }
        // RVA: 0x09B5655C  token: 0x60000F0
        public UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B565B4  token: 0x60000F1
        public UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B563C8  token: 0x60000F2
        public System.Void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        // RVA: 0x09B568AC  token: 0x60000F3
        public System.Void SetPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position) { }
        // RVA: 0x09B56900  token: 0x60000F4
        public System.Void SetRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09B566B8  token: 0x60000F5
        public System.Void SetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Boolean useMask) { }
        // RVA: 0x09B56604  token: 0x60000F6
        public System.Boolean IsResolved(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B56640  token: 0x60000F7
        public System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B5667C  token: 0x60000F8
        public System.Void Resolve(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B56234  token: 0x60000F9
        public static UnityEngine.Animations.Rigging.ReadWriteTransformHandle Bind(UnityEngine.Animator animator, UnityEngine.Transform transform) { }

    }

    // TypeToken: 0x2000038  // size: 0x28
    public sealed struct ReadOnlyTransformHandle
    {
        // Fields
        private UnityEngine.Animations.TransformStreamHandle m_StreamHandle;  // 0x10
        private UnityEngine.Animations.TransformSceneHandle m_SceneHandle;  // 0x1c
        private System.Byte m_InStream;  // 0x24

        // Methods
        // RVA: 0x09B55EBC  token: 0x60000FA
        public UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B55F34  token: 0x60000FB
        public UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B55FA4  token: 0x60000FC
        public UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B5601C  token: 0x60000FD
        public System.Void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        // RVA: 0x09B56078  token: 0x60000FE
        public UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B560F0  token: 0x60000FF
        public UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B55E70  token: 0x6000100
        public System.Void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        // RVA: 0x09B56160  token: 0x6000101
        public System.Boolean IsResolved(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B561A4  token: 0x6000102
        public System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B561F0  token: 0x6000103
        public System.Void Resolve(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B55D24  token: 0x6000104
        public static UnityEngine.Animations.Rigging.ReadOnlyTransformHandle Bind(UnityEngine.Animator animator, UnityEngine.Transform transform) { }

    }

    // TypeToken: 0x2000039  // size: 0x78
    public sealed struct TwistChainConstraintJob : UnityEngine.Animations.Rigging.IWeightedAnimationJob, UnityEngine.Animations.IAnimationJob
    {
        // Fields
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle rootTarget;  // 0x10
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle tipTarget;  // 0x1c
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadWriteTransformHandle> chain;  // 0x28
        public Unity.Collections.NativeArray<System.Single> steps;  // 0x38
        public Unity.Collections.NativeArray<System.Single> weights;  // 0x48
        public Unity.Collections.NativeArray<UnityEngine.Quaternion> rotations;  // 0x58
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;  // 0x68

        // Properties
        UnityEngine.Animations.Rigging.FloatProperty jobWeight { get; /* RVA: 0x03D50820 */ set; /* RVA: 0x03D71980 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000107
        public virtual System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B5B3E0  token: 0x6000108
        public virtual System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x200003A
    public interface ITwistChainConstraintData
    {
        // Properties
        UnityEngine.Transform root { get; /* RVA: -1  // abstract */ }
        UnityEngine.Transform tip { get; /* RVA: -1  // abstract */ }
        UnityEngine.Transform rootTarget { get; /* RVA: -1  // abstract */ }
        UnityEngine.Transform tipTarget { get; /* RVA: -1  // abstract */ }
        UnityEngine.AnimationCurve curve { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x200003B
    public class TwistChainConstraintJobBinder`1 : UnityEngine.Animations.Rigging.AnimationJobBinder`2
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x600010E
        public virtual UnityEngine.Animations.Rigging.TwistChainConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        // RVA: -1  // not resolved  token: 0x600010F
        public virtual System.Void Destroy(UnityEngine.Animations.Rigging.TwistChainConstraintJob job) { }
        // RVA: -1  // not resolved  token: 0x6000110
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003C  // size: 0x98
    public sealed struct TwistCorrectionJob : UnityEngine.Animations.Rigging.IWeightedAnimationJob, UnityEngine.Animations.IAnimationJob
    {
        // Fields
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle source;  // 0x10
        public UnityEngine.Quaternion sourceInverseBindRotation;  // 0x28
        public UnityEngine.Vector3 axisMask;  // 0x38
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadWriteTransformHandle> twistTransforms;  // 0x48
        public Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> twistWeights;  // 0x58
        public Unity.Collections.NativeArray<UnityEngine.Quaternion> twistBindRotations;  // 0x68
        public Unity.Collections.NativeArray<System.Single> weightBuffer;  // 0x78
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;  // 0x88

        // Properties
        UnityEngine.Animations.Rigging.FloatProperty jobWeight { get; /* RVA: 0x03D58660 */ set; /* RVA: 0x03D6C700 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000113
        public virtual System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B5BB2C  token: 0x6000114
        public virtual System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x03D764A0  token: 0x6000115
        private static UnityEngine.Quaternion TwistRotation(UnityEngine.Vector3 axis, UnityEngine.Quaternion rot) { }

    }

    // TypeToken: 0x200003D
    public interface ITwistCorrectionData
    {
        // Properties
        UnityEngine.Transform source { get; /* RVA: -1  // abstract */ }
        UnityEngine.Animations.Rigging.WeightedTransformArray twistNodes { get; /* RVA: -1  // abstract */ }
        UnityEngine.Vector3 twistAxis { get; /* RVA: -1  // abstract */ }
        System.String twistNodesProperty { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x200003E
    public class TwistCorrectionJobBinder`1 : UnityEngine.Animations.Rigging.AnimationJobBinder`2
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x600011A
        public virtual UnityEngine.Animations.Rigging.TwistCorrectionJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        // RVA: -1  // not resolved  token: 0x600011B
        public virtual System.Void Destroy(UnityEngine.Animations.Rigging.TwistCorrectionJob job) { }
        // RVA: -1  // not resolved  token: 0x600011C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003F  // size: 0xC0
    public sealed struct TwoBoneIKConstraintJob : UnityEngine.Animations.Rigging.IWeightedAnimationJob, UnityEngine.Animations.IAnimationJob
    {
        // Fields
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle root;  // 0x10
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle mid;  // 0x1c
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle tip;  // 0x28
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle hint;  // 0x34
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle target;  // 0x4c
        public UnityEngine.Animations.Rigging.AffineTransform targetOffset;  // 0x64
        public UnityEngine.Animations.Rigging.FloatProperty targetPositionWeight;  // 0x80
        public UnityEngine.Animations.Rigging.FloatProperty targetRotationWeight;  // 0x90
        public UnityEngine.Animations.Rigging.FloatProperty hintWeight;  // 0xa0
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;  // 0xb0

        // Properties
        UnityEngine.Animations.Rigging.FloatProperty jobWeight { get; /* RVA: 0x03D6C070 */ set; /* RVA: 0x03D6C0F0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600011F
        public virtual System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        // RVA: 0x09B5C28C  token: 0x6000120
        public virtual System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x2000040
    public interface ITwoBoneIKConstraintData
    {
        // Properties
        UnityEngine.Transform root { get; /* RVA: -1  // abstract */ }
        UnityEngine.Transform mid { get; /* RVA: -1  // abstract */ }
        UnityEngine.Transform tip { get; /* RVA: -1  // abstract */ }
        UnityEngine.Transform target { get; /* RVA: -1  // abstract */ }
        UnityEngine.Transform hint { get; /* RVA: -1  // abstract */ }
        System.Boolean maintainTargetPositionOffset { get; /* RVA: -1  // abstract */ }
        System.Boolean maintainTargetRotationOffset { get; /* RVA: -1  // abstract */ }
        System.String targetPositionWeightFloatProperty { get; /* RVA: -1  // abstract */ }
        System.String targetRotationWeightFloatProperty { get; /* RVA: -1  // abstract */ }
        System.String hintWeightFloatProperty { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000041
    public class TwoBoneIKConstraintJobBinder`1 : UnityEngine.Animations.Rigging.AnimationJobBinder`2
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x600012B
        public virtual UnityEngine.Animations.Rigging.TwoBoneIKConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        // RVA: -1  // not resolved  token: 0x600012C
        public virtual System.Void Destroy(UnityEngine.Animations.Rigging.TwoBoneIKConstraintJob job) { }
        // RVA: -1  // not resolved  token: 0x600012D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000042  // size: 0x10
    public class WeightedTransformArrayBinder
    {
        // Methods
        // RVA: 0x09B5DD60  token: 0x600012E
        public static System.Void BindReadOnlyTransforms(UnityEngine.Animator animator, UnityEngine.Component component, UnityEngine.Animations.Rigging.WeightedTransformArray weightedTransformArray, Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadOnlyTransformHandle>& transforms) { }
        // RVA: 0x09B5DE74  token: 0x600012F
        public static System.Void BindReadWriteTransforms(UnityEngine.Animator animator, UnityEngine.Component component, UnityEngine.Animations.Rigging.WeightedTransformArray weightedTransformArray, Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadWriteTransformHandle>& transforms) { }
        // RVA: 0x09B5DF84  token: 0x6000130
        public static System.Void BindWeights(UnityEngine.Animator animator, UnityEngine.Component component, UnityEngine.Animations.Rigging.WeightedTransformArray weightedTransformArray, System.String name, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle>& weights) { }
        // RVA: 0x0350B670  token: 0x6000131
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000043  // size: 0x38
    public sealed struct BlendConstraintData : UnityEngine.Animations.Rigging.IAnimationJobData, UnityEngine.Animations.Rigging.IBlendConstraintData
    {
        // Fields
        private UnityEngine.Transform m_ConstrainedObject;  // 0x10
        private UnityEngine.Transform m_SourceA;  // 0x18
        private UnityEngine.Transform m_SourceB;  // 0x20
        private System.Boolean m_BlendPosition;  // 0x28
        private System.Boolean m_BlendRotation;  // 0x29
        private System.Single m_PositionWeight;  // 0x2c
        private System.Single m_RotationWeight;  // 0x30
        private System.Boolean m_MaintainPositionOffsets;  // 0x34
        private System.Boolean m_MaintainRotationOffsets;  // 0x35

        // Properties
        UnityEngine.Transform constrainedObject { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x042715A0 */ }
        UnityEngine.Transform sourceObjectA { get; /* RVA: 0x03D50DE0 */ set; /* RVA: 0x0558FF08 */ }
        UnityEngine.Transform sourceObjectB { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.Boolean blendPosition { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        System.Boolean blendRotation { get; /* RVA: 0x03D4EF80 */ set; /* RVA: 0x03D4EFB0 */ }
        System.Single positionWeight { get; /* RVA: 0x03D4F110 */ set; /* RVA: 0x04270578 */ }
        System.Single rotationWeight { get; /* RVA: 0x03D4F2E0 */ set; /* RVA: 0x089D3648 */ }
        System.Boolean maintainPositionOffsets { get; /* RVA: 0x03D4F090 */ set; /* RVA: 0x03D4F0A0 */ }
        System.Boolean maintainRotationOffsets { get; /* RVA: 0x03D4F130 */ set; /* RVA: 0x03D4F150 */ }
        System.String UnityEngine.Animations.Rigging.IBlendConstraintData.blendPositionBoolProperty { get; /* RVA: 0x09B4DA30 */ }
        System.String UnityEngine.Animations.Rigging.IBlendConstraintData.blendRotationBoolProperty { get; /* RVA: 0x09B4DA64 */ }
        System.String UnityEngine.Animations.Rigging.IBlendConstraintData.positionWeightFloatProperty { get; /* RVA: 0x09B4DA98 */ }
        System.String UnityEngine.Animations.Rigging.IBlendConstraintData.rotationWeightFloatProperty { get; /* RVA: 0x09B4DACC */ }

        // Methods
        // RVA: 0x09B4D94C  token: 0x6000148
        private virtual System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        // RVA: 0x09B4D9E4  token: 0x6000149
        private virtual System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x2000044  // size: 0x48
    public class BlendConstraint : UnityEngine.Animations.Rigging.RigConstraint`3
    {
        // Methods
        // RVA: 0x09B4E084  token: 0x600014A
        protected virtual System.Void OnValidate() { }
        // RVA: 0x09B4E0E8  token: 0x600014B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000045  // size: 0x40
    public sealed struct ChainIKConstraintData : UnityEngine.Animations.Rigging.IAnimationJobData, UnityEngine.Animations.Rigging.IChainIKConstraintData
    {
        // Fields
        private static System.Int32 k_MinIterations;  // const
        private static System.Int32 k_MaxIterations;  // const
        private static System.Single k_MinTolerance;  // const
        private static System.Single k_MaxTolerance;  // const
        private UnityEngine.Transform m_Root;  // 0x10
        private UnityEngine.Transform m_Tip;  // 0x18
        private UnityEngine.Transform m_Target;  // 0x20
        private System.Single m_ChainRotationWeight;  // 0x28
        private System.Single m_TipRotationWeight;  // 0x2c
        private System.Int32 m_MaxIterations;  // 0x30
        private System.Single m_Tolerance;  // 0x34
        private System.Boolean m_MaintainTargetPositionOffset;  // 0x38
        private System.Boolean m_MaintainTargetRotationOffset;  // 0x39

        // Properties
        UnityEngine.Transform root { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x042715A0 */ }
        UnityEngine.Transform tip { get; /* RVA: 0x03D50DE0 */ set; /* RVA: 0x0558FF08 */ }
        UnityEngine.Transform target { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.Single chainRotationWeight { get; /* RVA: 0x03D4EBF0 */ set; /* RVA: 0x07B4A6B8 */ }
        System.Single tipRotationWeight { get; /* RVA: 0x03D4F110 */ set; /* RVA: 0x04270578 */ }
        System.Int32 maxIterations { get; /* RVA: 0x01003B50 */ set; /* RVA: 0x09B4E4A8 */ }
        System.Single tolerance { get; /* RVA: 0x03D524F0 */ set; /* RVA: 0x09B4E4C8 */ }
        System.Boolean maintainTargetPositionOffset { get; /* RVA: 0x03D4ED50 */ set; /* RVA: 0x03D4ED60 */ }
        System.Boolean maintainTargetRotationOffset { get; /* RVA: 0x03D4F2A0 */ set; /* RVA: 0x03D4F2B0 */ }
        System.String UnityEngine.Animations.Rigging.IChainIKConstraintData.chainRotationWeightFloatProperty { get; /* RVA: 0x09B4E440 */ }
        System.String UnityEngine.Animations.Rigging.IChainIKConstraintData.tipRotationWeightFloatProperty { get; /* RVA: 0x09B4E474 */ }

        // Methods
        // RVA: 0x09B4E2A8  token: 0x6000160
        private virtual System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        // RVA: 0x09B4E3EC  token: 0x6000161
        private virtual System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x2000046  // size: 0x50
    public class ChainIKConstraint : UnityEngine.Animations.Rigging.RigConstraint`3
    {
        // Methods
        // RVA: 0x09B4EC00  token: 0x6000162
        protected virtual System.Void OnValidate() { }
        // RVA: 0x09B4ECB4  token: 0x6000163
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000047  // size: 0x30
    public sealed struct DampedTransformData : UnityEngine.Animations.Rigging.IAnimationJobData, UnityEngine.Animations.Rigging.IDampedTransformData
    {
        // Fields
        private UnityEngine.Transform m_ConstrainedObject;  // 0x10
        private UnityEngine.Transform m_Source;  // 0x18
        private System.Single m_DampPosition;  // 0x20
        private System.Single m_DampRotation;  // 0x24
        private System.Boolean m_MaintainAim;  // 0x28

        // Properties
        UnityEngine.Transform constrainedObject { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x042715A0 */ }
        UnityEngine.Transform sourceObject { get; /* RVA: 0x03D50DE0 */ set; /* RVA: 0x0558FF08 */ }
        System.Single dampPosition { get; /* RVA: 0x03D4E7A0 */ set; /* RVA: 0x09B4F338 */ }
        System.Single dampRotation { get; /* RVA: 0x03D51930 */ set; /* RVA: 0x09B4F350 */ }
        System.Boolean maintainAim { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        System.String UnityEngine.Animations.Rigging.IDampedTransformData.dampPositionFloatProperty { get; /* RVA: 0x09B4F2D0 */ }
        System.String UnityEngine.Animations.Rigging.IDampedTransformData.dampRotationFloatProperty { get; /* RVA: 0x09B4F304 */ }

        // Methods
        // RVA: 0x09B4F21C  token: 0x6000170
        private virtual System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        // RVA: 0x09B4F294  token: 0x6000171
        private virtual System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x2000048  // size: 0x40
    public class DampedTransform : UnityEngine.Animations.Rigging.RigConstraint`3
    {
        // Methods
        // RVA: 0x09B4FB10  token: 0x6000172
        protected virtual System.Void OnValidate() { }
        // RVA: 0x09B4FB74  token: 0x6000173
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000049  // size: 0xD0
    public sealed struct MultiAimConstraintData : UnityEngine.Animations.Rigging.IAnimationJobData, UnityEngine.Animations.Rigging.IMultiAimConstraintData
    {
        // Fields
        private static System.Single k_MinAngularLimit;  // const
        private static System.Single k_MaxAngularLimit;  // const
        private UnityEngine.Transform m_ConstrainedObject;  // 0x10
        private UnityEngine.Animations.Rigging.WeightedTransformArray m_SourceObjects;  // 0x18
        private UnityEngine.Vector3 m_Offset;  // 0xa0
        private System.Single m_MinLimit;  // 0xac
        private System.Single m_MaxLimit;  // 0xb0
        private UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis m_AimAxis;  // 0xb4
        private UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis m_UpAxis;  // 0xb8
        private UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpType m_WorldUpType;  // 0xbc
        private UnityEngine.Transform m_WorldUpObject;  // 0xc0
        private UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis m_WorldUpAxis;  // 0xc8
        private System.Boolean m_MaintainOffset;  // 0xcc
        private UnityEngine.Animations.Rigging.Vector3Bool m_ConstrainedAxes;  // 0xcd

        // Properties
        UnityEngine.Transform constrainedObject { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x042715A0 */ }
        UnityEngine.Animations.Rigging.WeightedTransformArray sourceObjects { get; /* RVA: 0x03D763C0 */ set; /* RVA: 0x09B503A0 */ }
        System.Boolean maintainOffset { get; /* RVA: 0x03D5B230 */ set; /* RVA: 0x03D5B240 */ }
        UnityEngine.Vector3 offset { get; /* RVA: 0x03D5B810 */ set; /* RVA: 0x03D5E1E0 */ }
        UnityEngine.Vector2 limits { get; /* RVA: 0x03D738E0 */ set; /* RVA: 0x09B50340 */ }
        UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis aimAxis { get; /* RVA: 0x03D51870 */ set; /* RVA: 0x03D518B0 */ }
        UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis upAxis { get; /* RVA: 0x03D51860 */ set; /* RVA: 0x03D518A0 */ }
        UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpType worldUpType { get; /* RVA: 0x03D51880 */ set; /* RVA: 0x03D518C0 */ }
        UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis worldUpAxis { get; /* RVA: 0x03D57DA0 */ set; /* RVA: 0x03D57DC0 */ }
        UnityEngine.Transform worldUpObject { get; /* RVA: 0x03D4EAD0 */ set; /* RVA: 0x02B47080 */ }
        System.Boolean constrainedXAxis { get; /* RVA: 0x03D76390 */ set; /* RVA: 0x03D76420 */ }
        System.Boolean constrainedYAxis { get; /* RVA: 0x03D763A0 */ set; /* RVA: 0x03D76430 */ }
        System.Boolean constrainedZAxis { get; /* RVA: 0x03D763B0 */ set; /* RVA: 0x03D76440 */ }
        UnityEngine.Vector3 UnityEngine.Animations.Rigging.IMultiAimConstraintData.aimAxis { get; /* RVA: 0x09B501D4 */ }
        UnityEngine.Vector3 UnityEngine.Animations.Rigging.IMultiAimConstraintData.upAxis { get; /* RVA: 0x09B502D8 */ }
        System.Int32 UnityEngine.Animations.Rigging.IMultiAimConstraintData.worldUpType { get; /* RVA: 0x03D51880 */ }
        UnityEngine.Vector3 UnityEngine.Animations.Rigging.IMultiAimConstraintData.worldUpAxis { get; /* RVA: 0x09B5030C */ }
        System.String UnityEngine.Animations.Rigging.IMultiAimConstraintData.offsetVector3Property { get; /* RVA: 0x09B50270 */ }
        System.String UnityEngine.Animations.Rigging.IMultiAimConstraintData.minLimitFloatProperty { get; /* RVA: 0x09B5023C */ }
        System.String UnityEngine.Animations.Rigging.IMultiAimConstraintData.maxLimitFloatProperty { get; /* RVA: 0x09B50208 */ }
        System.String UnityEngine.Animations.Rigging.IMultiAimConstraintData.sourceObjectsProperty { get; /* RVA: 0x09B502A4 */ }

        // Methods
        // RVA: 0x09B4FF7C  token: 0x6000196
        private virtual System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        // RVA: 0x09B50100  token: 0x6000197
        private virtual System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }
        // RVA: 0x09B4FF10  token: 0x6000198
        private static UnityEngine.Vector3 Convert(UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis axis) { }

    }

    // TypeToken: 0x200004C  // size: 0xE0
    public class MultiAimConstraint : UnityEngine.Animations.Rigging.RigConstraint`3
    {
        // Methods
        // RVA: 0x09B515D4  token: 0x6000199
        protected virtual System.Void OnValidate() { }
        // RVA: 0x09B51778  token: 0x600019A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004D  // size: 0xA8
    public sealed struct MultiParentConstraintData : UnityEngine.Animations.Rigging.IAnimationJobData, UnityEngine.Animations.Rigging.IMultiParentConstraintData
    {
        // Fields
        private UnityEngine.Transform m_ConstrainedObject;  // 0x10
        private UnityEngine.Animations.Rigging.WeightedTransformArray m_SourceObjects;  // 0x18
        private UnityEngine.Animations.Rigging.Vector3Bool m_ConstrainedPositionAxes;  // 0xa0
        private UnityEngine.Animations.Rigging.Vector3Bool m_ConstrainedRotationAxes;  // 0xa3
        private System.Boolean m_MaintainPositionOffset;  // 0xa6
        private System.Boolean m_MaintainRotationOffset;  // 0xa7

        // Properties
        UnityEngine.Transform constrainedObject { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x042715A0 */ }
        UnityEngine.Animations.Rigging.WeightedTransformArray sourceObjects { get; /* RVA: 0x03D763C0 */ set; /* RVA: 0x09B503A0 */ }
        System.Boolean maintainPositionOffset { get; /* RVA: 0x03D52040 */ set; /* RVA: 0x03D6C5E0 */ }
        System.Boolean maintainRotationOffset { get; /* RVA: 0x03D76470 */ set; /* RVA: 0x03D76490 */ }
        System.Boolean constrainedPositionXAxis { get; /* RVA: 0x03D58A70 */ set; /* RVA: 0x03D58AB0 */ }
        System.Boolean constrainedPositionYAxis { get; /* RVA: 0x03D50B80 */ set; /* RVA: 0x03D50BA0 */ }
        System.Boolean constrainedPositionZAxis { get; /* RVA: 0x03D50B90 */ set; /* RVA: 0x03D50BB0 */ }
        System.Boolean constrainedRotationXAxis { get; /* RVA: 0x03D75420 */ set; /* RVA: 0x03D75BF0 */ }
        System.Boolean constrainedRotationYAxis { get; /* RVA: 0x03D6CD80 */ set; /* RVA: 0x03D6CD90 */ }
        System.Boolean constrainedRotationZAxis { get; /* RVA: 0x03D52050 */ set; /* RVA: 0x03D76480 */ }
        System.String UnityEngine.Animations.Rigging.IMultiParentConstraintData.sourceObjectsProperty { get; /* RVA: 0x09B519D4 */ }

        // Methods
        // RVA: 0x09B517CC  token: 0x60001B0
        private virtual System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        // RVA: 0x09B51950  token: 0x60001B1
        private virtual System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x200004E  // size: 0xB8
    public class MultiParentConstraint : UnityEngine.Animations.Rigging.RigConstraint`3
    {
        // Methods
        // RVA: 0x09B524D4  token: 0x60001B2
        protected virtual System.Void OnValidate() { }
        // RVA: 0x09B52610  token: 0x60001B3
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004F  // size: 0xB0
    public sealed struct MultiPositionConstraintData : UnityEngine.Animations.Rigging.IAnimationJobData, UnityEngine.Animations.Rigging.IMultiPositionConstraintData
    {
        // Fields
        private UnityEngine.Transform m_ConstrainedObject;  // 0x10
        private UnityEngine.Animations.Rigging.WeightedTransformArray m_SourceObjects;  // 0x18
        private UnityEngine.Vector3 m_Offset;  // 0xa0
        private UnityEngine.Animations.Rigging.Vector3Bool m_ConstrainedAxes;  // 0xac
        private System.Boolean m_MaintainOffset;  // 0xaf

        // Properties
        UnityEngine.Transform constrainedObject { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x042715A0 */ }
        UnityEngine.Animations.Rigging.WeightedTransformArray sourceObjects { get; /* RVA: 0x03D763C0 */ set; /* RVA: 0x09B503A0 */ }
        System.Boolean maintainOffset { get; /* RVA: 0x03D6E0A0 */ set; /* RVA: 0x03D6E0F0 */ }
        UnityEngine.Vector3 offset { get; /* RVA: 0x03D5B810 */ set; /* RVA: 0x03D5E1E0 */ }
        System.Boolean constrainedXAxis { get; /* RVA: 0x03D5E1C0 */ set; /* RVA: 0x03D5E200 */ }
        System.Boolean constrainedYAxis { get; /* RVA: 0x03D6E090 */ set; /* RVA: 0x03D6E0E0 */ }
        System.Boolean constrainedZAxis { get; /* RVA: 0x03D6E0B0 */ set; /* RVA: 0x03D6E100 */ }
        System.String UnityEngine.Animations.Rigging.IMultiPositionConstraintData.offsetVector3Property { get; /* RVA: 0x09B52870 */ }
        System.String UnityEngine.Animations.Rigging.IMultiPositionConstraintData.sourceObjectsProperty { get; /* RVA: 0x09B528A4 */ }

        // Methods
        // RVA: 0x09B52664  token: 0x60001C4
        private virtual System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        // RVA: 0x09B527E8  token: 0x60001C5
        private virtual System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x2000050  // size: 0xC0
    public class MultiPositionConstraint : UnityEngine.Animations.Rigging.RigConstraint`3
    {
        // Methods
        // RVA: 0x09B52FD4  token: 0x60001C6
        protected virtual System.Void OnValidate() { }
        // RVA: 0x09B53110  token: 0x60001C7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000051  // size: 0x20
    public sealed struct MultiReferentialConstraintData : UnityEngine.Animations.Rigging.IAnimationJobData, UnityEngine.Animations.Rigging.IMultiReferentialConstraintData
    {
        // Fields
        private System.Int32 m_Driver;  // 0x10
        private System.Collections.Generic.List<UnityEngine.Transform> m_SourceObjects;  // 0x18

        // Properties
        System.Int32 driver { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x09B53490 */ }
        System.Collections.Generic.List<UnityEngine.Transform> sourceObjects { get; /* RVA: 0x09B5340C */ set; /* RVA: 0x09B534EC */ }
        UnityEngine.Transform[] UnityEngine.Animations.Rigging.IMultiReferentialConstraintData.sourceObjects { get; /* RVA: 0x09B53374 */ }
        System.Int32 UnityEngine.Animations.Rigging.IMultiReferentialConstraintData.driverValue { get; /* RVA: 0x03D4E980 */ }
        System.String UnityEngine.Animations.Rigging.IMultiReferentialConstraintData.driverIntProperty { get; /* RVA: 0x09B53340 */ }

        // Methods
        // RVA: 0x09B53164  token: 0x60001CF
        private virtual System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        // RVA: 0x09B532C8  token: 0x60001D0
        private virtual System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }
        // RVA: 0x09B533BC  token: 0x60001D1
        public System.Void UpdateDriver() { }

    }

    // TypeToken: 0x2000052  // size: 0x30
    public class MultiReferentialConstraint : UnityEngine.Animations.Rigging.RigConstraint`3
    {
        // Methods
        // RVA: 0x09B53BAC  token: 0x60001D2
        protected virtual System.Void OnValidate() { }
        // RVA: 0x09B53BF0  token: 0x60001D3
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000053  // size: 0xB0
    public sealed struct MultiRotationConstraintData : UnityEngine.Animations.Rigging.IAnimationJobData, UnityEngine.Animations.Rigging.IMultiRotationConstraintData
    {
        // Fields
        private UnityEngine.Transform m_ConstrainedObject;  // 0x10
        private UnityEngine.Animations.Rigging.WeightedTransformArray m_SourceObjects;  // 0x18
        private UnityEngine.Vector3 m_Offset;  // 0xa0
        private UnityEngine.Animations.Rigging.Vector3Bool m_ConstrainedAxes;  // 0xac
        private System.Boolean m_MaintainOffset;  // 0xaf

        // Properties
        UnityEngine.Transform constrainedObject { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x042715A0 */ }
        UnityEngine.Animations.Rigging.WeightedTransformArray sourceObjects { get; /* RVA: 0x03D763C0 */ set; /* RVA: 0x09B503A0 */ }
        System.Boolean maintainOffset { get; /* RVA: 0x03D6E0A0 */ set; /* RVA: 0x03D6E0F0 */ }
        UnityEngine.Vector3 offset { get; /* RVA: 0x03D5B810 */ set; /* RVA: 0x03D5E1E0 */ }
        System.Boolean constrainedXAxis { get; /* RVA: 0x03D5E1C0 */ set; /* RVA: 0x03D5E200 */ }
        System.Boolean constrainedYAxis { get; /* RVA: 0x03D6E090 */ set; /* RVA: 0x03D6E0E0 */ }
        System.Boolean constrainedZAxis { get; /* RVA: 0x03D6E0B0 */ set; /* RVA: 0x03D6E100 */ }
        System.String UnityEngine.Animations.Rigging.IMultiRotationConstraintData.offsetVector3Property { get; /* RVA: 0x09B53E50 */ }
        System.String UnityEngine.Animations.Rigging.IMultiRotationConstraintData.sourceObjectsProperty { get; /* RVA: 0x09B53E84 */ }

        // Methods
        // RVA: 0x09B53C44  token: 0x60001E4
        private virtual System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        // RVA: 0x09B53DC8  token: 0x60001E5
        private virtual System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x2000054  // size: 0xC0
    public class MultiRotationConstraint : UnityEngine.Animations.Rigging.RigConstraint`3
    {
        // Methods
        // RVA: 0x09B545A8  token: 0x60001E6
        protected virtual System.Void OnValidate() { }
        // RVA: 0x09B546E4  token: 0x60001E7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000055  // size: 0x48
    public sealed struct OverrideTransformData : UnityEngine.Animations.Rigging.IAnimationJobData, UnityEngine.Animations.Rigging.IOverrideTransformData
    {
        // Fields
        private UnityEngine.Transform m_ConstrainedObject;  // 0x10
        private UnityEngine.Transform m_OverrideSource;  // 0x18
        private UnityEngine.Vector3 m_OverridePosition;  // 0x20
        private UnityEngine.Vector3 m_OverrideRotation;  // 0x2c
        private System.Single m_PositionWeight;  // 0x38
        private System.Single m_RotationWeight;  // 0x3c
        private UnityEngine.Animations.Rigging.OverrideTransformData.Space m_Space;  // 0x40

        // Properties
        UnityEngine.Transform constrainedObject { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x042715A0 */ }
        UnityEngine.Transform sourceObject { get; /* RVA: 0x03D50DE0 */ set; /* RVA: 0x0558FF08 */ }
        UnityEngine.Animations.Rigging.OverrideTransformData.Space space { get; /* RVA: 0x03D4ED20 */ set; /* RVA: 0x03D4EE10 */ }
        UnityEngine.Vector3 position { get; /* RVA: 0x03D55550 */ set; /* RVA: 0x03D55570 */ }
        UnityEngine.Vector3 rotation { get; /* RVA: 0x03D568F0 */ set; /* RVA: 0x03D5CBC0 */ }
        System.Single positionWeight { get; /* RVA: 0x03D4F480 */ set; /* RVA: 0x09B54C44 */ }
        System.Single rotationWeight { get; /* RVA: 0x03D4F3A0 */ set; /* RVA: 0x09B54C5C */ }
        System.Int32 UnityEngine.Animations.Rigging.IOverrideTransformData.space { get; /* RVA: 0x03D4ED20 */ }
        System.String UnityEngine.Animations.Rigging.IOverrideTransformData.positionWeightFloatProperty { get; /* RVA: 0x09B54BA8 */ }
        System.String UnityEngine.Animations.Rigging.IOverrideTransformData.rotationWeightFloatProperty { get; /* RVA: 0x09B54C10 */ }
        System.String UnityEngine.Animations.Rigging.IOverrideTransformData.positionVector3Property { get; /* RVA: 0x09B54B74 */ }
        System.String UnityEngine.Animations.Rigging.IOverrideTransformData.rotationVector3Property { get; /* RVA: 0x09B54BDC */ }

        // Methods
        // RVA: 0x09B54AB4  token: 0x60001FB
        private virtual System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        // RVA: 0x09B54B04  token: 0x60001FC
        private virtual System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x2000057  // size: 0x58
    public class OverrideTransform : UnityEngine.Animations.Rigging.RigConstraint`3
    {
        // Methods
        // RVA: 0x09B55570  token: 0x60001FD
        protected virtual System.Void OnValidate() { }
        // RVA: 0x09B555D4  token: 0x60001FE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000058  // size: 0x38
    public sealed struct TwistChainConstraintData : UnityEngine.Animations.Rigging.IAnimationJobData, UnityEngine.Animations.Rigging.ITwistChainConstraintData
    {
        // Fields
        private UnityEngine.Transform m_Root;  // 0x10
        private UnityEngine.Transform m_Tip;  // 0x18
        private UnityEngine.Transform m_RootTarget;  // 0x20
        private UnityEngine.Transform m_TipTarget;  // 0x28
        private UnityEngine.AnimationCurve m_Curve;  // 0x30

        // Properties
        UnityEngine.Transform root { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x042715A0 */ }
        UnityEngine.Transform tip { get; /* RVA: 0x03D50DE0 */ set; /* RVA: 0x0558FF08 */ }
        UnityEngine.Transform rootTarget { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        UnityEngine.Transform tipTarget { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        UnityEngine.AnimationCurve curve { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }

        // Methods
        // RVA: 0x09B5B28C  token: 0x6000209
        private virtual System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        // RVA: 0x09B5B374  token: 0x600020A
        private virtual System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x2000059  // size: 0x48
    public class TwistChainConstraint : UnityEngine.Animations.Rigging.RigConstraint`3
    {
        // Methods
        // RVA: 0x09B5B8D8  token: 0x600020B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005A  // size: 0xA8
    public sealed struct TwistCorrectionData : UnityEngine.Animations.Rigging.IAnimationJobData, UnityEngine.Animations.Rigging.ITwistCorrectionData
    {
        // Fields
        private UnityEngine.Transform m_Source;  // 0x10
        private UnityEngine.Animations.Rigging.TwistCorrectionData.Axis m_TwistAxis;  // 0x18
        private UnityEngine.Animations.Rigging.WeightedTransformArray m_TwistNodes;  // 0x20

        // Properties
        UnityEngine.Transform sourceObject { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x042715A0 */ }
        UnityEngine.Animations.Rigging.WeightedTransformArray twistNodes { get; /* RVA: 0x03D62BB0 */ set; /* RVA: 0x09B5BAC8 */ }
        UnityEngine.Animations.Rigging.TwistCorrectionData.Axis twistAxis { get; /* RVA: 0x03D516F0 */ set; /* RVA: 0x03D51710 */ }
        UnityEngine.Transform UnityEngine.Animations.Rigging.ITwistCorrectionData.source { get; /* RVA: 0x020C61B0 */ }
        UnityEngine.Vector3 UnityEngine.Animations.Rigging.ITwistCorrectionData.twistAxis { get; /* RVA: 0x09B5BA64 */ }
        System.String UnityEngine.Animations.Rigging.ITwistCorrectionData.twistNodesProperty { get; /* RVA: 0x09B5BA94 */ }

        // Methods
        // RVA: 0x095F5C38  token: 0x6000215
        private static UnityEngine.Vector3 Convert(UnityEngine.Animations.Rigging.TwistCorrectionData.Axis axis) { }
        // RVA: 0x09B5B92C  token: 0x6000216
        private virtual System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        // RVA: 0x09B5BA04  token: 0x6000217
        private virtual System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x200005C  // size: 0xB8
    public class TwistCorrection : UnityEngine.Animations.Rigging.RigConstraint`3
    {
        // Methods
        // RVA: 0x09B5BEE8  token: 0x6000218
        protected virtual System.Void OnValidate() { }
        // RVA: 0x09B5C02C  token: 0x6000219
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005D  // size: 0x48
    public sealed struct TwoBoneIKConstraintData : UnityEngine.Animations.Rigging.IAnimationJobData, UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData
    {
        // Fields
        private UnityEngine.Transform m_Root;  // 0x10
        private UnityEngine.Transform m_Mid;  // 0x18
        private UnityEngine.Transform m_Tip;  // 0x20
        private UnityEngine.Transform m_Target;  // 0x28
        private UnityEngine.Transform m_Hint;  // 0x30
        private System.Single m_TargetPositionWeight;  // 0x38
        private System.Single m_TargetRotationWeight;  // 0x3c
        private System.Single m_HintWeight;  // 0x40
        private System.Boolean m_MaintainTargetPositionOffset;  // 0x44
        private System.Boolean m_MaintainTargetRotationOffset;  // 0x45

        // Properties
        UnityEngine.Transform root { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x042715A0 */ }
        UnityEngine.Transform mid { get; /* RVA: 0x03D50DE0 */ set; /* RVA: 0x0558FF08 */ }
        UnityEngine.Transform tip { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        UnityEngine.Transform target { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        UnityEngine.Transform hint { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        System.Single targetPositionWeight { get; /* RVA: 0x03D4F480 */ set; /* RVA: 0x09B54C44 */ }
        System.Single targetRotationWeight { get; /* RVA: 0x03D4F3A0 */ set; /* RVA: 0x09B54C5C */ }
        System.Single hintWeight { get; /* RVA: 0x03D4F5D0 */ set; /* RVA: 0x09B5C274 */ }
        System.Boolean maintainTargetPositionOffset { get; /* RVA: 0x03D4F570 */ set; /* RVA: 0x03D4F590 */ }
        System.Boolean maintainTargetRotationOffset { get; /* RVA: 0x03D4F560 */ set; /* RVA: 0x03D4F580 */ }
        System.String UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData.targetPositionWeightFloatProperty { get; /* RVA: 0x09B5C20C */ }
        System.String UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData.targetRotationWeightFloatProperty { get; /* RVA: 0x09B5C240 */ }
        System.String UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData.hintWeightFloatProperty { get; /* RVA: 0x09B5C1D8 */ }

        // Methods
        // RVA: 0x09B5C080  token: 0x6000231
        private virtual System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        // RVA: 0x09B5C174  token: 0x6000232
        private virtual System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x200005E  // size: 0x58
    public class TwoBoneIKConstraint : UnityEngine.Animations.Rigging.RigConstraint`3
    {
        // Methods
        // RVA: 0x09B5C62C  token: 0x6000233
        protected virtual System.Void OnValidate() { }
        // RVA: 0x09B5C6A4  token: 0x6000234
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005F
    public interface IRigConstraint
    {
        // Properties
        UnityEngine.Animations.Rigging.IAnimationJobData data { get; /* RVA: -1  // abstract */ }
        UnityEngine.Animations.Rigging.IAnimationJobBinder binder { get; /* RVA: -1  // abstract */ }
        UnityEngine.Component component { get; /* RVA: -1  // abstract */ }
        System.Single weight { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000235
        public virtual System.Boolean IsValid() { }
        // RVA: -1  // abstract  token: 0x6000236
        public virtual UnityEngine.Animations.IAnimationJob CreateJob(UnityEngine.Animator animator) { }
        // RVA: -1  // abstract  token: 0x6000237
        public virtual System.Void UpdateJob(UnityEngine.Animations.IAnimationJob job) { }
        // RVA: -1  // abstract  token: 0x6000238
        public virtual System.Void DestroyJob(UnityEngine.Animations.IAnimationJob job) { }

    }

    // TypeToken: 0x2000060
    public interface IRigLayer
    {
        // Properties
        UnityEngine.Animations.Rigging.Rig rig { get; /* RVA: -1  // abstract */ }
        UnityEngine.Animations.Rigging.IRigConstraint[] constraints { get; /* RVA: -1  // abstract */ }
        UnityEngine.Animations.IAnimationJob[] jobs { get; /* RVA: -1  // abstract */ }
        System.Boolean active { get; /* RVA: -1  // abstract */ }
        System.String name { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000243
        public virtual System.Boolean Initialize(UnityEngine.Animator animator) { }
        // RVA: -1  // abstract  token: 0x6000244
        public virtual System.Void Update() { }
        // RVA: -1  // abstract  token: 0x6000245
        public virtual System.Void Reset() { }
        // RVA: -1  // abstract  token: 0x6000246
        public virtual System.Boolean IsValid() { }

    }

    // TypeToken: 0x2000061
    public class OverrideRigConstraint`4 : UnityEngine.Animations.Rigging.IRigConstraint
    {
        // Fields
        protected TConstraint m_Constraint;  // 0x0
        private static readonly TBinder s_Binder;  // static @ 0x0

        // Properties
        UnityEngine.Animations.Rigging.IAnimationJobBinder UnityEngine.Animations.Rigging.IRigConstraint.binder { get; /* RVA: -1  // not resolved */ }
        UnityEngine.Animations.Rigging.IAnimationJobData UnityEngine.Animations.Rigging.IRigConstraint.data { get; /* RVA: -1  // not resolved */ }
        UnityEngine.Component UnityEngine.Animations.Rigging.IRigConstraint.component { get; /* RVA: -1  // not resolved */ }
        System.Single weight { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000247
        public System.Void .ctor(TConstraint baseConstraint) { }
        // RVA: -1  // not resolved  token: 0x6000248
        public virtual UnityEngine.Animations.IAnimationJob CreateJob(UnityEngine.Animator animator) { }
        // RVA: -1  // not resolved  token: 0x6000249
        public virtual System.Void DestroyJob(UnityEngine.Animations.IAnimationJob job) { }
        // RVA: -1  // not resolved  token: 0x600024A
        public virtual System.Void UpdateJob(UnityEngine.Animations.IAnimationJob job) { }
        // RVA: -1  // not resolved  token: 0x600024B
        public virtual System.Boolean IsValid() { }
        // RVA: -1  // not resolved  token: 0x6000251
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000062  // size: 0x38
    public class OverrideRigLayer : UnityEngine.Animations.Rigging.IRigLayer
    {
        // Fields
        private UnityEngine.Animations.Rigging.Rig m_Rig;  // 0x10
        private System.Boolean m_Active;  // 0x18
        private UnityEngine.Animations.Rigging.IRigConstraint[] m_Constraints;  // 0x20
        private UnityEngine.Animations.IAnimationJob[] m_Jobs;  // 0x28
        private System.Boolean <isInitialized>k__BackingField;  // 0x30

        // Properties
        UnityEngine.Animations.Rigging.Rig rig { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.Boolean active { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        System.String name { get; /* RVA: 0x09B54A24 */ }
        UnityEngine.Animations.Rigging.IRigConstraint[] constraints { get; /* RVA: 0x09B54A04 */ }
        UnityEngine.Animations.IAnimationJob[] jobs { get; /* RVA: 0x09B54A14 */ }
        System.Boolean isInitialized { get; /* RVA: 0x03D4EF60 */ set; /* RVA: 0x03D4EF70 */ }

        // Methods
        // RVA: 0x09B549D4  token: 0x600025B
        public System.Void .ctor(UnityEngine.Animations.Rigging.Rig rig, UnityEngine.Animations.Rigging.IRigConstraint[] constraints, System.Boolean active) { }
        // RVA: 0x09B54738  token: 0x600025C
        public virtual System.Boolean Initialize(UnityEngine.Animator animator) { }
        // RVA: 0x09B54968  token: 0x600025D
        public virtual System.Void Update() { }
        // RVA: 0x09B548C4  token: 0x600025E
        public virtual System.Void Reset() { }
        // RVA: 0x09B54868  token: 0x600025F
        public virtual System.Boolean IsValid() { }

    }

    // TypeToken: 0x2000063  // size: 0x28
    public class Rig : UnityEngine.MonoBehaviour, UnityEngine.Animations.Rigging.IRigEffectorHolder
    {
        // Fields
        private System.Single m_Weight;  // 0x18
        private System.Collections.Generic.List<UnityEngine.Animations.Rigging.RigEffectorData> m_Effectors;  // 0x20

        // Properties
        System.Single weight { get; /* RVA: 0x03D4EBF0 */ set; /* RVA: 0x07B4A6B8 */ }

        // Methods
        // RVA: 0x09B5A9D4  token: 0x6000262
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000064  // size: 0x48
    public class RigBuilder : UnityEngine.MonoBehaviour, UnityEngine.Animations.IAnimationWindowPreview, UnityEngine.Animations.Rigging.IRigEffectorHolder
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Animations.Rigging.RigLayer> m_RigLayers;  // 0x18
        private UnityEngine.Animations.Rigging.IRigLayer[] m_RuntimeRigLayers;  // 0x20
        private UnityEngine.Animations.Rigging.SyncSceneToStreamLayer m_SyncSceneToStreamLayer;  // 0x28
        private System.Collections.Generic.List<UnityEngine.Animations.Rigging.RigEffectorData> m_Effectors;  // 0x30
        public static UnityEngine.Animations.Rigging.RigBuilder.OnAddRigBuilderCallback onAddRigBuilder;  // static @ 0x0
        public static UnityEngine.Animations.Rigging.RigBuilder.OnRemoveRigBuilderCallback onRemoveRigBuilder;  // static @ 0x8
        private UnityEngine.Playables.PlayableGraph <graph>k__BackingField;  // 0x38

        // Properties
        System.Collections.Generic.List<UnityEngine.Animations.Rigging.RigLayer> layers { get; /* RVA: 0x09B57DC4 */ set; /* RVA: 0x022C3A90 */ }
        UnityEngine.Animations.Rigging.SyncSceneToStreamLayer syncSceneToStreamLayer { get; /* RVA: 0x09B57E48 */ set; /* RVA: 0x02C92F10 */ }
        UnityEngine.Playables.PlayableGraph graph { get; /* RVA: 0x03D5A120 */ set; /* RVA: 0x03D5C3C0 */ }

        // Methods
        // RVA: 0x09B57A0C  token: 0x6000263
        private System.Void OnEnable() { }
        // RVA: 0x09B579A4  token: 0x6000264
        private System.Void OnDisable() { }
        // RVA: 0x09B5799C  token: 0x6000265
        private System.Void OnDestroy() { }
        // RVA: 0x09B57C50  token: 0x6000266
        private System.Void Update() { }
        // RVA: 0x09B5770C  token: 0x6000267
        public System.Boolean Build() { }
        // RVA: 0x09B57884  token: 0x6000268
        public System.Void Clear() { }
        // RVA: 0x09B57A70  token: 0x6000269
        public virtual System.Void StartPreview() { }
        // RVA: 0x09B57B70  token: 0x600026A
        public virtual System.Void StopPreview() { }
        // RVA: 0x09B57BA4  token: 0x600026B
        public virtual System.Void UpdatePreviewGraph(UnityEngine.Playables.PlayableGraph graph) { }
        // RVA: 0x09B57450  token: 0x600026C
        public virtual UnityEngine.Playables.Playable BuildPreviewGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable inputPlayable) { }
        // RVA: 0x09B57D44  token: 0x6000273
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000067  // size: 0x10
    public static class RigBuilderUtils
    {
        // Fields
        private static readonly System.UInt16 k_AnimationOutputPriority;  // static @ 0x0

        // Methods
        // RVA: 0x09B571F0  token: 0x600027C
        public static UnityEngine.Playables.Playable[] BuildRigPlayables(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.Rigging.IRigLayer layer) { }
        // RVA: 0x09B56C98  token: 0x600027D
        public static System.Collections.Generic.IEnumerable<UnityEngine.Animations.Rigging.RigBuilderUtils.PlayableChain> BuildPlayables(UnityEngine.Animator animator, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers, UnityEngine.Animations.Rigging.SyncSceneToStreamLayer syncSceneToStreamLayer) { }
        // RVA: 0x09B56948  token: 0x600027E
        public static UnityEngine.Playables.PlayableGraph BuildPlayableGraph(UnityEngine.Animator animator, System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers, UnityEngine.Animations.Rigging.SyncSceneToStreamLayer syncSceneToStreamLayer) { }
        // RVA: 0x09B57418  token: 0x600027F
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000069
    public class RigConstraint`3 : UnityEngine.MonoBehaviour, UnityEngine.Animations.Rigging.IRigConstraint
    {
        // Fields
        protected System.Single m_Weight;  // 0x0
        protected TData m_Data;  // 0x0
        private static readonly TBinder s_Binder;  // static @ 0x0

        // Properties
        TData& data { get; /* RVA: -1  // not resolved */ }
        System.Single weight { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        UnityEngine.Animations.Rigging.IAnimationJobBinder UnityEngine.Animations.Rigging.IRigConstraint.binder { get; /* RVA: -1  // not resolved */ }
        UnityEngine.Animations.Rigging.IAnimationJobData UnityEngine.Animations.Rigging.IRigConstraint.data { get; /* RVA: -1  // not resolved */ }
        UnityEngine.Component UnityEngine.Animations.Rigging.IRigConstraint.component { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000281
        public System.Void Reset() { }
        // RVA: -1  // not resolved  token: 0x6000282
        public virtual System.Boolean IsValid() { }
        // RVA: -1  // not resolved  token: 0x6000283
        protected virtual System.Void OnValidate() { }
        // RVA: -1  // not resolved  token: 0x6000287
        public virtual UnityEngine.Animations.IAnimationJob CreateJob(UnityEngine.Animator animator) { }
        // RVA: -1  // not resolved  token: 0x6000288
        public virtual System.Void DestroyJob(UnityEngine.Animations.IAnimationJob job) { }
        // RVA: -1  // not resolved  token: 0x6000289
        public virtual System.Void UpdateJob(UnityEngine.Animations.IAnimationJob job) { }
        // RVA: -1  // not resolved  token: 0x600028D
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x600028E
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200006A  // size: 0x38
    public class RigLayer : UnityEngine.Animations.Rigging.IRigLayer
    {
        // Fields
        private UnityEngine.Animations.Rigging.Rig m_Rig;  // 0x10
        private System.Boolean m_Active;  // 0x18
        private UnityEngine.Animations.Rigging.IRigConstraint[] m_Constraints;  // 0x20
        private UnityEngine.Animations.IAnimationJob[] m_Jobs;  // 0x28
        private System.Boolean <isInitialized>k__BackingField;  // 0x30

        // Properties
        UnityEngine.Animations.Rigging.Rig rig { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.Boolean active { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        System.String name { get; /* RVA: 0x09B58144 */ }
        UnityEngine.Animations.Rigging.IRigConstraint[] constraints { get; /* RVA: 0x09B54A04 */ }
        UnityEngine.Animations.IAnimationJob[] jobs { get; /* RVA: 0x09B54A14 */ }
        System.Boolean isInitialized { get; /* RVA: 0x03D4EF60 */ set; /* RVA: 0x03D4EF70 */ }

        // Methods
        // RVA: 0x092E5BF4  token: 0x6000298
        public System.Void .ctor(UnityEngine.Animations.Rigging.Rig rig, System.Boolean active) { }
        // RVA: 0x09B57EF4  token: 0x6000299
        public virtual System.Boolean Initialize(UnityEngine.Animator animator) { }
        // RVA: 0x09B580C0  token: 0x600029A
        public virtual System.Void Update() { }
        // RVA: 0x09B58038  token: 0x600029B
        public virtual System.Void Reset() { }
        // RVA: 0x09B57FDC  token: 0x600029C
        public virtual System.Boolean IsValid() { }

    }

    // TypeToken: 0x200006B  // size: 0x18
    public class RigTransform : UnityEngine.MonoBehaviour
    {
        // Methods
        // RVA: 0x0426FE60  token: 0x600029D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006C  // size: 0x10
    public static class RigUtils
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.Type,UnityEngine.Animations.Rigging.PropertyDescriptor> s_SupportedPropertyTypeToDescriptor;  // static @ 0x0
        private static readonly UnityEngine.Animations.Rigging.IAnimationJobBinder <syncSceneToStreamBinder>k__BackingField;  // static @ 0x8

        // Properties
        UnityEngine.Animations.Rigging.IAnimationJobBinder syncSceneToStreamBinder { get; /* RVA: 0x09B5A984 */ }

        // Methods
        // RVA: 0x09B5A3D8  token: 0x600029E
        public static UnityEngine.Animations.Rigging.IRigConstraint[] GetConstraints(UnityEngine.Animations.Rigging.Rig rig) { }
        // RVA: 0x09B5A50C  token: 0x600029F
        private static UnityEngine.Transform[] GetSyncableRigTransforms(UnityEngine.Animator animator) { }
        // RVA: 0x09B59A18  token: 0x60002A0
        private static System.Boolean ExtractTransformType(UnityEngine.Animator animator, System.Reflection.FieldInfo field, System.Object data, System.Collections.Generic.List<UnityEngine.Transform> syncableTransforms) { }
        // RVA: 0x09B598D8  token: 0x60002A1
        private static System.Boolean ExtractPropertyType(System.Reflection.FieldInfo field, System.Object data, System.Collections.Generic.List<UnityEngine.Animations.Rigging.Property> syncableProperties, System.String namePrefix) { }
        // RVA: 0x09B59DC8  token: 0x60002A2
        private static System.Boolean ExtractWeightedTransforms(UnityEngine.Animator animator, System.Reflection.FieldInfo field, System.Object data, System.Collections.Generic.List<UnityEngine.Transform> syncableTransforms, System.Collections.Generic.List<UnityEngine.Animations.Rigging.Property> syncableProperties) { }
        // RVA: 0x09B5938C  token: 0x60002A3
        private static System.Boolean ExtractNestedPropertyType(UnityEngine.Animator animator, System.Reflection.FieldInfo field, System.Object data, System.Collections.Generic.List<UnityEngine.Transform> syncableTransforms, System.Collections.Generic.List<UnityEngine.Animations.Rigging.Property> syncableProperties, System.String namePrefix) { }
        // RVA: 0x09B588FC  token: 0x60002A4
        private static System.Void ExtractAllSyncableData(UnityEngine.Animator animator, System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers, System.Collections.Generic.List<UnityEngine.Transform>& syncableTransforms, System.Collections.Generic.List<UnityEngine.Animations.Rigging.SyncableProperties>& syncableProperties) { }
        // RVA: 0x09B5868C  token: 0x60002A5
        public static UnityEngine.Animations.IAnimationJob[] CreateAnimationJobs(UnityEngine.Animator animator, UnityEngine.Animations.Rigging.IRigConstraint[] constraints) { }
        // RVA: 0x09B5888C  token: 0x60002A6
        public static System.Void DestroyAnimationJobs(UnityEngine.Animations.Rigging.IRigConstraint[] constraints, UnityEngine.Animations.IAnimationJob[] jobs) { }
        // RVA: 0x09B58758  token: 0x60002A7
        private static UnityEngine.Animations.Rigging.IAnimationJobData CreateSyncSceneToStreamData(UnityEngine.Animator animator, System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers) { }
        // RVA: 0x09B5A5F8  token: 0x60002A9
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200006F  // size: 0x30
    public class SyncSceneToStreamLayer
    {
        // Fields
        private System.Boolean <isInitialized>k__BackingField;  // 0x10
        public UnityEngine.Animations.IAnimationJob job;  // 0x18
        private UnityEngine.Animations.Rigging.IAnimationJobData m_Data;  // 0x20
        private System.Collections.Generic.List<System.Int32> m_RigIndices;  // 0x28

        // Properties
        System.Boolean isInitialized { get; /* RVA: 0x011797F0 */ set; /* RVA: 0x03D4E960 */ }

        // Methods
        // RVA: 0x09B5AA5C  token: 0x60002B7
        public System.Boolean Initialize(UnityEngine.Animator animator, System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers) { }
        // RVA: 0x09B5AD24  token: 0x60002B8
        public System.Void Update(System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers) { }
        // RVA: 0x09B5AC64  token: 0x60002B9
        public System.Void Reset() { }
        // RVA: 0x09B5AC50  token: 0x60002BA
        public System.Boolean IsValid() { }
        // RVA: 0x0350B670  token: 0x60002BD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000070
    public interface ITransformProvider
    {
        // Properties
        UnityEngine.Transform transform { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000071
    public interface IWeightProvider
    {
        // Properties
        System.Single weight { get; /* RVA: -1  // abstract */ set; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000072  // size: 0x20
    public sealed struct WeightedTransform : UnityEngine.Animations.Rigging.ITransformProvider, UnityEngine.Animations.Rigging.IWeightProvider, System.IEquatable`1
    {
        // Fields
        public UnityEngine.Transform transform;  // 0x10
        public System.Single weight;  // 0x18

        // Properties
        UnityEngine.Transform UnityEngine.Animations.Rigging.ITransformProvider.transform { get; /* RVA: 0x020C61B0 */ set; /* RVA: 0x042715A0 */ }
        System.Single UnityEngine.Animations.Rigging.IWeightProvider.weight { get; /* RVA: 0x03D58BB0 */ set; /* RVA: 0x09B5F764 */ }

        // Methods
        // RVA: 0x09B5F77C  token: 0x60002C2
        public System.Void .ctor(UnityEngine.Transform transform, System.Single weight) { }
        // RVA: 0x09B5F6C4  token: 0x60002C3
        public static UnityEngine.Animations.Rigging.WeightedTransform Default(System.Single weight) { }
        // RVA: 0x09B5F6EC  token: 0x60002C4
        public virtual System.Boolean Equals(UnityEngine.Animations.Rigging.WeightedTransform other) { }

    }

    // TypeToken: 0x2000073  // size: 0x98
    public sealed struct WeightedTransformArray : System.Collections.Generic.IList`1, System.Collections.Generic.ICollection`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection
    {
        // Fields
        public static readonly System.Int32 k_MaxLength;  // static @ 0x0
        private System.Int32 m_Length;  // 0x10
        private UnityEngine.Animations.Rigging.WeightedTransform m_Item0;  // 0x18
        private UnityEngine.Animations.Rigging.WeightedTransform m_Item1;  // 0x28
        private UnityEngine.Animations.Rigging.WeightedTransform m_Item2;  // 0x38
        private UnityEngine.Animations.Rigging.WeightedTransform m_Item3;  // 0x48
        private UnityEngine.Animations.Rigging.WeightedTransform m_Item4;  // 0x58
        private UnityEngine.Animations.Rigging.WeightedTransform m_Item5;  // 0x68
        private UnityEngine.Animations.Rigging.WeightedTransform m_Item6;  // 0x78
        private UnityEngine.Animations.Rigging.WeightedTransform m_Item7;  // 0x88

        // Properties
        System.Object System.Collections.IList.Item { get; /* RVA: 0x09B5F434 */ set; /* RVA: 0x09B5F4B0 */ }
        UnityEngine.Animations.Rigging.WeightedTransform Item { get; /* RVA: 0x09B5F5E8 */ set; /* RVA: 0x09B5F658 */ }
        System.Int32 Count { get; /* RVA: 0x03D4E980 */ }
        System.Boolean IsReadOnly { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean IsFixedSize { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean System.Collections.ICollection.IsSynchronized { get; /* RVA: 0x0232EB60 */ }
        System.Object System.Collections.ICollection.SyncRoot { get; /* RVA: 0x01002730 */ }

        // Methods
        // RVA: 0x09B5F574  token: 0x60002C9
        public System.Void .ctor(System.Int32 size) { }
        // RVA: 0x09B5E610  token: 0x60002CA
        public virtual System.Collections.Generic.IEnumerator<UnityEngine.Animations.Rigging.WeightedTransform> GetEnumerator() { }
        // RVA: 0x09B5F108  token: 0x60002CB
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: 0x09B5F1C8  token: 0x60002CC
        private virtual System.Int32 System.Collections.IList.Add(System.Object value) { }
        // RVA: 0x09B5E114  token: 0x60002CD
        public virtual System.Void Add(UnityEngine.Animations.Rigging.WeightedTransform value) { }
        // RVA: 0x03D5BBD0  token: 0x60002CE
        public virtual System.Void Clear() { }
        // RVA: 0x09B5F2BC  token: 0x60002CF
        private virtual System.Int32 System.Collections.IList.IndexOf(System.Object value) { }
        // RVA: 0x09B5E840  token: 0x60002D0
        public virtual System.Int32 IndexOf(UnityEngine.Animations.Rigging.WeightedTransform value) { }
        // RVA: 0x09B5F244  token: 0x60002D1
        private virtual System.Boolean System.Collections.IList.Contains(System.Object value) { }
        // RVA: 0x09B5E3AC  token: 0x60002D2
        public virtual System.Boolean Contains(UnityEngine.Animations.Rigging.WeightedTransform value) { }
        // RVA: 0x09B5EF20  token: 0x60002D3
        private virtual System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 arrayIndex) { }
        // RVA: 0x09B5E448  token: 0x60002D4
        public virtual System.Void CopyTo(UnityEngine.Animations.Rigging.WeightedTransform[] array, System.Int32 arrayIndex) { }
        // RVA: 0x09B5F3BC  token: 0x60002D5
        private virtual System.Void System.Collections.IList.Remove(System.Object value) { }
        // RVA: 0x09B5EC08  token: 0x60002D6
        public virtual System.Boolean Remove(UnityEngine.Animations.Rigging.WeightedTransform value) { }
        // RVA: 0x09B5EB70  token: 0x60002D7
        public virtual System.Void RemoveAt(System.Int32 index) { }
        // RVA: 0x09B5F334  token: 0x60002D8
        private virtual System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value) { }
        // RVA: 0x09B5E8DC  token: 0x60002D9
        public virtual System.Void Insert(System.Int32 index, UnityEngine.Animations.Rigging.WeightedTransform value) { }
        // RVA: 0x09B5E358  token: 0x60002DA
        private static System.Int32 ClampSize(System.Int32 size) { }
        // RVA: 0x09B5E248  token: 0x60002DB
        private System.Void CheckOutOfRangeIndex(System.Int32 index) { }
        // RVA: 0x09B5E784  token: 0x60002DC
        private UnityEngine.Animations.Rigging.WeightedTransform Get(System.Int32 index) { }
        // RVA: 0x09B5EE24  token: 0x60002DD
        private System.Void Set(System.Int32 index, UnityEngine.Animations.Rigging.WeightedTransform value) { }
        // RVA: 0x09B5ED94  token: 0x60002DE
        public System.Void SetWeight(System.Int32 index, System.Single weight) { }
        // RVA: 0x09B5E728  token: 0x60002DF
        public System.Single GetWeight(System.Int32 index) { }
        // RVA: 0x09B5ECF4  token: 0x60002E0
        public System.Void SetTransform(System.Int32 index, UnityEngine.Transform transform) { }
        // RVA: 0x09B5E6D0  token: 0x60002E1
        public UnityEngine.Transform GetTransform(System.Int32 index) { }
        // RVA: 0x09B5EAAC  token: 0x60002E2
        public static System.Void OnValidate(UnityEngine.Animations.Rigging.WeightedTransformArray& array, System.Single min, System.Single max) { }
        // RVA: 0x09B5F538  token: 0x60002EC
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000075  // size: 0x10
    public sealed class ExpandChildrenAttribute : UnityEngine.PropertyAttribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60002F3
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000076  // size: 0x10
    public sealed class SyncSceneToStreamAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60002F4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000077  // size: 0x11
    public sealed struct PropertyType
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static UnityEngine.Animations.Rigging.PropertyType Bool;  // const
        public static UnityEngine.Animations.Rigging.PropertyType Int;  // const
        public static UnityEngine.Animations.Rigging.PropertyType Float;  // const

    }

    // TypeToken: 0x2000078  // size: 0x18
    public sealed struct PropertyDescriptor
    {
        // Fields
        public System.Int32 size;  // 0x10
        public UnityEngine.Animations.Rigging.PropertyType type;  // 0x14

    }

    // TypeToken: 0x2000079  // size: 0x20
    public sealed struct Property
    {
        // Fields
        public System.String name;  // 0x10
        public UnityEngine.Animations.Rigging.PropertyDescriptor descriptor;  // 0x18

    }

    // TypeToken: 0x200007A  // size: 0x18
    public sealed struct RigProperties
    {
        // Fields
        public static System.String s_Weight;  // static @ 0x0
        public UnityEngine.Component component;  // 0x10

        // Methods
        // RVA: 0x09B581D4  token: 0x60002F5
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200007B  // size: 0x20
    public sealed struct ConstraintProperties
    {
        // Fields
        public static System.String s_Weight;  // static @ 0x0
        public UnityEngine.Component component;  // 0x10
        public UnityEngine.Animations.Rigging.Property[] properties;  // 0x18

        // Methods
        // RVA: 0x09B4ED08  token: 0x60002F6
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200007C  // size: 0x10
    public static class PropertyUtils
    {
        // Methods
        // RVA: 0x09B559EC  token: 0x60002F7
        public static System.String ConstructConstraintDataPropertyName(System.String property) { }
        // RVA: 0x09B559F4  token: 0x60002F8
        public static System.String ConstructCustomPropertyName(UnityEngine.Component component, System.String property) { }

    }

    // TypeToken: 0x200007D  // size: 0x18
    public sealed class WeightRangeAttribute : UnityEngine.PropertyAttribute
    {
        // Fields
        public readonly System.Single min;  // 0x10
        public readonly System.Single max;  // 0x14

        // Methods
        // RVA: 0x03D5E2F0  token: 0x60002F9
        public System.Void .ctor(System.Single min, System.Single max) { }

    }

    // TypeToken: 0x200007E
    public interface IRigEffectorHolder
    {
    }

    // TypeToken: 0x200007F  // size: 0x58
    public class RigEffectorData
    {
        // Fields
        private UnityEngine.Transform m_Transform;  // 0x10
        private UnityEngine.Animations.Rigging.RigEffectorData.Style m_Style;  // 0x18
        private System.Boolean m_Visible;  // 0x50

        // Properties
        UnityEngine.Transform transform { get; /* RVA: 0x020B7B20 */ }
        UnityEngine.Animations.Rigging.RigEffectorData.Style style { get; /* RVA: 0x03D62FD0 */ }
        System.Boolean visible { get; /* RVA: 0x03D4F000 */ set; /* RVA: 0x03D4F030 */ }

        // Methods
        // RVA: 0x09B57EA4  token: 0x60002FE
        public System.Void Initialize(UnityEngine.Transform transform, UnityEngine.Animations.Rigging.RigEffectorData.Style style) { }
        // RVA: 0x03D75180  token: 0x60002FF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000081  // size: 0x2C
    public sealed struct AffineTransform
    {
        // Fields
        public UnityEngine.Vector3 translation;  // 0x10
        public UnityEngine.Quaternion rotation;  // 0x1c
        private static readonly UnityEngine.Animations.Rigging.AffineTransform <identity>k__BackingField;  // static @ 0x0

        // Properties
        UnityEngine.Animations.Rigging.AffineTransform identity { get; /* RVA: 0x09B4BC2C */ }

        // Methods
        // RVA: 0x03D5C820  token: 0x6000300
        public System.Void .ctor(UnityEngine.Vector3 t, UnityEngine.Quaternion r) { }
        // RVA: 0x03D5C820  token: 0x6000301
        public System.Void Set(UnityEngine.Vector3 t, UnityEngine.Quaternion r) { }
        // RVA: 0x05E2197C  token: 0x6000302
        public UnityEngine.Vector3 Transform(UnityEngine.Vector3 p) { }
        // RVA: 0x05E2180C  token: 0x6000303
        public UnityEngine.Vector3 InverseTransform(UnityEngine.Vector3 p) { }
        // RVA: 0x05E218CC  token: 0x6000304
        public UnityEngine.Animations.Rigging.AffineTransform Inverse() { }
        // RVA: 0x05E216E4  token: 0x6000305
        public UnityEngine.Animations.Rigging.AffineTransform InverseMul(UnityEngine.Animations.Rigging.AffineTransform transform) { }
        // RVA: 0x05E2197C  token: 0x6000306
        public static UnityEngine.Vector3 op_Multiply(UnityEngine.Animations.Rigging.AffineTransform lhs, UnityEngine.Vector3 rhs) { }
        // RVA: 0x09B4BC8C  token: 0x6000307
        public static UnityEngine.Animations.Rigging.AffineTransform op_Multiply(UnityEngine.Animations.Rigging.AffineTransform lhs, UnityEngine.Animations.Rigging.AffineTransform rhs) { }
        // RVA: 0x05E21C08  token: 0x6000308
        public static UnityEngine.Animations.Rigging.AffineTransform op_Multiply(UnityEngine.Quaternion lhs, UnityEngine.Animations.Rigging.AffineTransform rhs) { }
        // RVA: 0x05E21CA8  token: 0x6000309
        public static UnityEngine.Animations.Rigging.AffineTransform op_Multiply(UnityEngine.Animations.Rigging.AffineTransform lhs, UnityEngine.Quaternion rhs) { }
        // RVA: 0x09B4BBA0  token: 0x600030B
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000082  // size: 0x10
    public static class AnimationRuntimeUtils
    {
        // Fields
        private static System.Single k_SqrEpsilon;  // const

        // Methods
        // RVA: 0x09B4CB58  token: 0x600030C
        public static System.Void SolveTwoBoneIK(UnityEngine.Animations.AnimationStream stream, UnityEngine.Animations.Rigging.ReadWriteTransformHandle root, UnityEngine.Animations.Rigging.ReadWriteTransformHandle mid, UnityEngine.Animations.Rigging.ReadWriteTransformHandle tip, UnityEngine.Animations.Rigging.ReadOnlyTransformHandle target, UnityEngine.Animations.Rigging.ReadOnlyTransformHandle hint, System.Single posWeight, System.Single rotWeight, System.Single hintWeight, UnityEngine.Animations.Rigging.AffineTransform targetOffset) { }
        // RVA: 0x09B4D8FC  token: 0x600030D
        private static System.Single TriangleAngle(System.Single aLen, System.Single aLen1, System.Single aLen2) { }
        // RVA: 0x09B4C6AC  token: 0x600030E
        public static System.Boolean SolveFABRIK(Unity.Collections.NativeArray<UnityEngine.Vector3>& linkPositions, Unity.Collections.NativeArray<System.Single>& linkLengths, UnityEngine.Vector3 target, System.Single tolerance, System.Single maxReach, System.Int32 maxIterations) { }
        // RVA: 0x05671F48  token: 0x600030F
        public static System.Single SqrDistance(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs) { }
        // RVA: 0x03D51490  token: 0x6000310
        public static System.Single Square(System.Single value) { }
        // RVA: 0x09B4C380  token: 0x6000311
        public static UnityEngine.Vector3 Lerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 t) { }
        // RVA: 0x09B4C6A0  token: 0x6000312
        public static System.Single Select(System.Single a, System.Single b, System.Single c) { }
        // RVA: 0x09B4C644  token: 0x6000313
        public static UnityEngine.Vector3 Select(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c) { }
        // RVA: 0x09B4C584  token: 0x6000314
        public static UnityEngine.Vector3 ProjectOnPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal) { }
        // RVA: 0x09B4D8D4  token: 0x6000315
        private static System.Single Sum(UnityEngine.Animations.Rigging.AnimationJobCache cache, UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 count) { }
        // RVA: 0x09B4D8AC  token: 0x6000316
        public static System.Single Sum(Unity.Collections.NativeArray<System.Single> floatBuffer) { }
        // RVA: 0x09B4C484  token: 0x6000317
        public static System.Void PassThrough(UnityEngine.Animations.AnimationStream stream, UnityEngine.Animations.Rigging.ReadWriteTransformHandle handle) { }

    }

    // TypeToken: 0x2000083  // size: 0x40
    public class BoneRenderer : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.Animations.Rigging.BoneRenderer.BoneShape boneShape;  // 0x18
        public System.Boolean drawBones;  // 0x1c
        public System.Boolean drawTripods;  // 0x1d
        public System.Single boneSize;  // 0x20
        public System.Single tripodSize;  // 0x24
        public UnityEngine.Color boneColor;  // 0x28
        private UnityEngine.Transform[] m_Transforms;  // 0x38

        // Properties
        UnityEngine.Transform[] transforms { get; /* RVA: 0x03D4E2A0 */ }

        // Methods
        // RVA: 0x09B4E13C  token: 0x6000319
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000085  // size: 0x10
    public static class ConstraintsUtils
    {
        // Methods
        // RVA: 0x09B4EED0  token: 0x600031A
        public static UnityEngine.Transform[] ExtractChain(UnityEngine.Transform root, UnityEngine.Transform tip) { }
        // RVA: 0x09B4F020  token: 0x600031B
        public static System.Single[] ExtractLengths(UnityEngine.Transform[] chain) { }
        // RVA: 0x09B4F0EC  token: 0x600031C
        public static System.Single[] ExtractSteps(UnityEngine.Transform[] chain) { }
        // RVA: 0x09B4ED64  token: 0x600031D
        public static System.String ConstructConstraintDataPropertyName(System.String property) { }
        // RVA: 0x09B4EDA0  token: 0x600031E
        public static System.String ConstructCustomPropertyName(UnityEngine.Component component, System.String property) { }

    }

    // TypeToken: 0x2000087  // size: 0x10
    public static class QuaternionExt
    {
        // Fields
        private static System.Single k_FloatMin;  // const
        public static readonly UnityEngine.Quaternion zero;  // static @ 0x0

        // Methods
        // RVA: 0x09B55A80  token: 0x6000321
        public static UnityEngine.Quaternion FromToRotation(UnityEngine.Vector3 from, UnityEngine.Vector3 to) { }
        // RVA: 0x09B559FC  token: 0x6000322
        public static UnityEngine.Quaternion Add(UnityEngine.Quaternion rhs, UnityEngine.Quaternion lhs) { }
        // RVA: 0x02E260C0  token: 0x6000323
        public static UnityEngine.Quaternion Scale(UnityEngine.Quaternion q, System.Single scale) { }
        // RVA: 0x09B55C74  token: 0x6000324
        public static UnityEngine.Quaternion NormalizeSafe(UnityEngine.Quaternion q) { }
        // RVA: 0x09B55CE8  token: 0x6000325
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000088  // size: 0x13
    public sealed struct Vector3Bool
    {
        // Fields
        public System.Boolean x;  // 0x10
        public System.Boolean y;  // 0x11
        public System.Boolean z;  // 0x12

        // Methods
        // RVA: 0x03D764F0  token: 0x6000326
        public System.Void .ctor(System.Boolean val) { }
        // RVA: 0x03D6B5F0  token: 0x6000327
        public System.Void .ctor(System.Boolean x, System.Boolean y, System.Boolean z) { }

    }

}

