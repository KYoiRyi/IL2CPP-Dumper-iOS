// ========================================================
// Dumped by @desirepro
// Assembly: SkeletalUnsafe.Gameplay.Beyond.dll
// Classes:  24
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000006  // size: 0x10
    public static class SimpleWriteLock
    {
        // Methods
        // RVA: 0x0966E29C  token: 0x6000004
        public static System.Boolean EnterLock(Unity.Collections.NativeArray<System.Int32> lockFlag, System.Int32 maxSpinCount) { }
        // RVA: 0x02FABFA0  token: 0x6000005
        public static System.Void MainThreadEnterLock(Unity.Collections.NativeArray<System.Int32> lockFlag, System.Int32 millisecondsTimeout, System.Int32 spinBeforeTiming) { }
        // RVA: 0x02FABF50  token: 0x6000006
        public static System.Void ExitLock(Unity.Collections.NativeArray<System.Int32> lockFlag) { }

    }

    // TypeToken: 0x2000007  // size: 0x28
    public sealed struct TrackerLock : Unity.Jobs.IJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> flag;  // 0x10
        public System.Boolean isEnter;  // 0x20

        // Methods
        // RVA: 0x0966E518  token: 0x6000007
        public virtual System.Void Execute() { }

    }

    // TypeToken: 0x2000008  // size: 0xA8
    public sealed struct ApplyBoneToAnimatorTransJob : Unity.Jobs.IJob
    {
        // Fields
        public System.Boolean runtime_writeNoDirty;  // 0x10
        public System.Single runtime_applyWeight;  // 0x14
        public Unity.Collections.NativeArray<Beyond.Gameplay.Core.FBoneRuntimeData> runtime_allBoneBasePose;  // 0x18
        public Unity.Collections.NativeArray<Beyond.Gameplay.Core.FBoneRuntimeData> runtime_allBonePose;  // 0x28
        public UnityEngine.AnimationTransformRWBufferHandle runtime_allBonesTransformRWBufferHandle;  // 0x38

        // Methods
        // RVA: 0x0966AD10  token: 0x6000008
        public virtual System.Void Execute() { }
        // RVA: 0x02514AD0  token: 0x6000009
        public static System.Void CleanAnimatorTransJob(UnityEngine.AnimationTransformRWBufferHandle rwHandler) { }
        // RVA: 0x029F8070  token: 0x600000A
        public static System.Void SetAnimatorTransPhysicsRatioPtr(UnityEngine.AnimationTransformRWBufferHandle rwHandler, System.Single value) { }

    }

    // TypeToken: 0x2000014  // size: 0x10
    public class __JobReflectionRegistrationOutput__2734917912
    {
        // Methods
        // RVA: 0x0227D630  token: 0x6000023
        public static System.Void CreateJobReflectionData() { }
        // RVA: 0x0227DE40  token: 0x6000024
        public static System.Void EarlyInit() { }

    }

namespace Beyond.Gameplay.Core
{

    // TypeToken: 0x2000004  // size: 0x10
    public static class NativeArrayExtensions
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000003
        public static System.Void FastCopy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst) { }

    }

    // TypeToken: 0x2000005  // size: 0x10
    public static class SkeletalMorphUnsafeJobDefines
    {
    }

    // TypeToken: 0x2000009  // size: 0x20
    public sealed struct FSkeletalMorphShaderPropMappingData
    {
        // Fields
        public System.Int32 vectorIndex;  // 0x10
        public UnityEngine.Rendering.ShaderPropertyType propertyType;  // 0x14
        public System.Int32 paramNameID;  // 0x18
        public System.Int32 paramRuntimeIdx;  // 0x1c

    }

    // TypeToken: 0x200000A  // size: 0x38
    public sealed struct FBoneRuntimeData
    {
        // Fields
        public UnityEngine.Vector3 pos;  // 0x10
        public UnityEngine.Vector3 rot;  // 0x1c
        public UnityEngine.Vector3 sca;  // 0x28
        public System.Boolean bIsDirty;  // 0x34

        // Methods
        // RVA: 0x0966AF24  token: 0x600000B
        public virtual System.String ToString() { }
        // RVA: 0x0966B038  token: 0x600000C
        public System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x200000B  // size: 0x3C
    public sealed struct FSkeletalMorphBoneData
    {
        // Fields
        public System.Int32 boneNameHash;  // 0x10
        public System.Int32 boneID;  // 0x14
        public UnityEngine.Vector3 position;  // 0x18
        public UnityEngine.Vector3 rotation;  // 0x24
        public UnityEngine.Vector3 scale;  // 0x30

    }

    // TypeToken: 0x200000C  // size: 0x14
    public sealed struct EMorphPartType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Beyond.Gameplay.Core.EMorphPartType None;  // const
        public static Beyond.Gameplay.Core.EMorphPartType REyeMorphs;  // const
        public static Beyond.Gameplay.Core.EMorphPartType LEyeMorphs;  // const
        public static Beyond.Gameplay.Core.EMorphPartType RBrowMorphs;  // const
        public static Beyond.Gameplay.Core.EMorphPartType LBrowMorphs;  // const
        public static Beyond.Gameplay.Core.EMorphPartType MouthMorphs;  // const
        public static Beyond.Gameplay.Core.EMorphPartType Other;  // const
        public static Beyond.Gameplay.Core.EMorphPartType LEar;  // const
        public static Beyond.Gameplay.Core.EMorphPartType REar;  // const
        public static Beyond.Gameplay.Core.EMorphPartType All;  // const

    }

    // TypeToken: 0x200000D  // size: 0x38
    public sealed struct FSkeletalMorphMappingData
    {
        // Fields
        public System.Int32 id;  // 0x10
        public System.Int32 nameHash;  // 0x14
        public System.Int32 tagHash;  // 0x18
        public Beyond.Gameplay.Core.EMorphPartType partType;  // 0x1c
        public System.Int32 boneOffset;  // 0x20
        public System.Int32 boneLen;  // 0x24
        public Beyond.Gameplay.Core.FSkeletalMorphBoneData* bones;  // 0x28
        public System.Boolean bIsShaderProp;  // 0x30
        public static Beyond.Gameplay.Core.FSkeletalMorphMappingData s_defaultMappingData;  // static @ 0x0

        // Methods
        // RVA: 0x0966B390  token: 0x600000D
        public System.Boolean IsValid() { }
        // RVA: 0x0966B284  token: 0x600000E
        public Beyond.Gameplay.Core.FSkeletalMorphBoneData GetBoneData(System.Int32 idx) { }
        // RVA: 0x029F2B10  token: 0x600000F
        public System.Void SetMapping(Unity.Collections.NativeArray<Beyond.Gameplay.Core.FSkeletalMorphBoneData> bigList, System.Int32 bonesOffset, System.Int32 bonesLen) { }
        // RVA: 0x0350B670  token: 0x6000010
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200000E
    public sealed struct PtrList`1
    {
        // Fields
        public System.Int32 len;  // 0x0
        public T* data;  // 0x0

    }

    // TypeToken: 0x200000F  // size: 0xA0
    public sealed struct FSkeletalMorphAnim
    {
        // Fields
        public static Beyond.Gameplay.Core.FSkeletalMorphAnim INVALID;  // static @ 0x0
        public System.Int32 animSoTagID;  // 0x10
        public System.Single duration;  // 0x14
        public System.Boolean bIsAdditiveClip;  // 0x18
        public System.Boolean bIsOverride;  // 0x19
        public System.Boolean bIsPauseAutoBlink;  // 0x1a
        public System.Boolean bIsPoseAnim;  // 0x1b
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve> eyeCurveR;  // 0x20
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve> eyeCurveL;  // 0x30
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve> browCurveR;  // 0x40
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve> browCurveL;  // 0x50
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve> mouthCurve;  // 0x60
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve> otherCurve;  // 0x70
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve> lEarCurve;  // 0x80
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve> rEarCurve;  // 0x90

        // Methods
        // RVA: 0x029F2EF0  token: 0x6000011
        public System.Boolean IsValid() { }
        // RVA: 0x02CFCC30  token: 0x6000012
        public Unity.Collections.NativeArray<Beyond.Gameplay.Core.FMorphCtrlCurve> Create(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 curveLen) { }
        // RVA: 0x0966B09C  token: 0x6000013
        public System.Boolean GetCurveData(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 idx, Beyond.Gameplay.Core.FMorphCtrlCurve& curve) { }
        // RVA: 0x0966B1DC  token: 0x6000014
        public System.Int32 GetCurveLen(Beyond.Gameplay.Core.EMorphPartType partType) { }
        // RVA: 0x02CFCB10  token: 0x6000015
        public System.Void SetCurveData(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 idx, Beyond.Gameplay.Core.FMorphCtrlCurve& curve) { }
        // RVA: 0x0350B670  token: 0x6000016
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000010  // size: 0x30
    public sealed struct FMorphCtrlCurve
    {
        // Fields
        public static System.Int32 RESOLUTION;  // const
        public System.Int32 ctrlNameHash;  // 0x10
        public Beyond.FPtrAnimNativeCurve curve;  // 0x18

        // Methods
        // RVA: 0x02FAC6A0  token: 0x6000017
        public Unity.Collections.NativeArray<UnityEngine.Keyframe> Create(System.String name, UnityEngine.AnimationCurve animCurve, Unity.Collections.Allocator allocator) { }
        // RVA: 0x02CFBFB0  token: 0x6000018
        public Unity.Collections.NativeArray<UnityEngine.Keyframe> Create(System.String name, System.Single poseVal, Unity.Collections.Allocator allocator) { }

    }

    // TypeToken: 0x2000011  // size: 0x78
    public sealed struct FSkeletalMorphPose
    {
        // Fields
        public static Beyond.Gameplay.Core.FSkeletalMorphPose INVALID;  // static @ 0x0
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue> eyeValueR;  // 0x10
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue> eyeValueL;  // 0x20
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue> browValueR;  // 0x30
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue> browValueL;  // 0x40
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue> mouthValue;  // 0x50
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue> otherValue;  // 0x60
        public System.Boolean bIsAdditivePose;  // 0x70

        // Methods
        // RVA: 0x0966B704  token: 0x6000019
        public System.Boolean IsValid() { }
        // RVA: 0x0966B3DC  token: 0x600001A
        public System.Int32 AllCurveNum() { }
        // RVA: 0x0966B434  token: 0x600001B
        public Unity.Collections.NativeArray<Beyond.Gameplay.Core.FMorphCtrlValue> Create(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 curveLen) { }
        // RVA: 0x0966B588  token: 0x600001C
        public System.Boolean GetValueData(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 idx, Beyond.Gameplay.Core.FMorphCtrlValue& curve) { }
        // RVA: 0x0966B674  token: 0x600001D
        public System.Int32 GetValueLen(Beyond.Gameplay.Core.EMorphPartType partType) { }
        // RVA: 0x0966B778  token: 0x600001E
        public System.Void SetValueData(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 idx, Beyond.Gameplay.Core.FMorphCtrlValue& curve) { }
        // RVA: 0x0350B670  token: 0x600001F
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000012  // size: 0x18
    public sealed struct FMorphCtrlValue
    {
        // Fields
        public System.Int32 ctrlNameHash;  // 0x10
        public System.Single value;  // 0x14

    }

    // TypeToken: 0x2000013  // size: 0x10
    public static class SkeletalMorphUnsafeJobUtils
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000020
        public static T& GetUnsafeElementRef(Unity.Collections.NativeArray<T> array, System.Int32 idx) { }
        // RVA: -1  // generic def  token: 0x6000021
        public static System.Void SetUnsafeElementRef(Unity.Collections.NativeArray<T> array, System.Int32 idx, T& val) { }
        // RVA: 0x0966E350  token: 0x6000022
        public static UnityEngine.Quaternion FromMaya(UnityEngine.Vector3 eulerAngle) { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000015  // size: 0x28
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10
        private System.Int32 methodId;  // 0x18
        private System.Object anonObj;  // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;  // static @ 0x0

        // Methods
        // RVA: 0x03020510  token: 0x6000025
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        // RVA: 0x0966B854  token: 0x6000026
        public System.Boolean __Gen_Wrap_0(Unity.Collections.NativeArray<System.Int32> P0, System.Int32 P1) { }
        // RVA: 0x0966CCF4  token: 0x6000027
        public System.Void __Gen_Wrap_1(Unity.Collections.NativeArray<System.Int32> P0, System.Int32 P1, System.Int32 P2) { }
        // RVA: 0x0966D7A8  token: 0x6000028
        public System.Void __Gen_Wrap_2(Unity.Collections.NativeArray<System.Int32> P0) { }
        // RVA: 0x0966D8A0  token: 0x6000029
        public System.Void __Gen_Wrap_3(Beyond.Gameplay.Core.SkeletalMorphUnsafeJobDefines.TrackerLock& P0) { }
        // RVA: 0x0966D9D4  token: 0x600002A
        public UnityEngine.Quaternion __Gen_Wrap_4(UnityEngine.Vector3 P0) { }
        // RVA: 0x0966DAFC  token: 0x600002B
        public System.Void __Gen_Wrap_5(Beyond.Gameplay.Core.SkeletalMorphUnsafeJobDefines.ApplyBoneToAnimatorTransJob& P0) { }
        // RVA: 0x0966DCD8  token: 0x600002C
        public System.Void __Gen_Wrap_6(UnityEngine.AnimationTransformRWBufferHandle P0) { }
        // RVA: 0x0966DE00  token: 0x600002D
        public System.Void __Gen_Wrap_7(UnityEngine.AnimationTransformRWBufferHandle P0, System.Single P1) { }
        // RVA: 0x0966DF50  token: 0x600002E
        public System.String __Gen_Wrap_8(Beyond.Gameplay.Core.FBoneRuntimeData& P0) { }
        // RVA: 0x0966E0B4  token: 0x600002F
        public System.Boolean __Gen_Wrap_9(Beyond.Gameplay.Core.FSkeletalMorphMappingData& P0) { }
        // RVA: 0x0966B960  token: 0x6000030
        public Beyond.Gameplay.Core.FSkeletalMorphBoneData __Gen_Wrap_10(Beyond.Gameplay.Core.FSkeletalMorphMappingData& P0, System.Int32 P1) { }
        // RVA: 0x0966BB14  token: 0x6000031
        public System.Void __Gen_Wrap_11(Beyond.Gameplay.Core.FSkeletalMorphMappingData& P0, Unity.Collections.NativeArray<Beyond.Gameplay.Core.FSkeletalMorphBoneData> P1, System.Int32 P2, System.Int32 P3) { }
        // RVA: 0x0966BCD4  token: 0x6000032
        public System.Boolean __Gen_Wrap_12(Beyond.Gameplay.Core.FSkeletalMorphAnim& P0) { }
        // RVA: 0x0966BEC4  token: 0x6000033
        public Unity.Collections.NativeArray<Beyond.Gameplay.Core.FMorphCtrlCurve> __Gen_Wrap_13(Beyond.Gameplay.Core.FSkeletalMorphAnim& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2) { }
        // RVA: 0x0966C104  token: 0x6000034
        public System.Boolean __Gen_Wrap_14(Beyond.Gameplay.Core.FSkeletalMorphAnim& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2, Beyond.Gameplay.Core.FMorphCtrlCurve& P3) { }
        // RVA: 0x0966C364  token: 0x6000035
        public System.Int32 __Gen_Wrap_15(Beyond.Gameplay.Core.FSkeletalMorphAnim& P0, Beyond.Gameplay.Core.EMorphPartType P1) { }
        // RVA: 0x0966C558  token: 0x6000036
        public System.Void __Gen_Wrap_16(Beyond.Gameplay.Core.FSkeletalMorphAnim& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2, Beyond.Gameplay.Core.FMorphCtrlCurve& P3) { }
        // RVA: 0x0966C7F0  token: 0x6000037
        public Unity.Collections.NativeArray<UnityEngine.Keyframe> __Gen_Wrap_17(Beyond.Gameplay.Core.FMorphCtrlCurve& P0, System.Object P1, System.Object P2, Unity.Collections.Allocator P3) { }
        // RVA: 0x0966C9A8  token: 0x6000038
        public Unity.Collections.NativeArray<UnityEngine.Keyframe> __Gen_Wrap_18(Beyond.Gameplay.Core.FMorphCtrlCurve& P0, System.Object P1, System.Single P2, Unity.Collections.Allocator P3) { }
        // RVA: 0x0966CB60  token: 0x6000039
        public System.Boolean __Gen_Wrap_19(Beyond.Gameplay.Core.FSkeletalMorphPose& P0) { }
        // RVA: 0x0966CE20  token: 0x600003A
        public System.Int32 __Gen_Wrap_20(Beyond.Gameplay.Core.FSkeletalMorphPose& P0) { }
        // RVA: 0x0966CFB4  token: 0x600003B
        public Unity.Collections.NativeArray<Beyond.Gameplay.Core.FMorphCtrlValue> __Gen_Wrap_21(Beyond.Gameplay.Core.FSkeletalMorphPose& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2) { }
        // RVA: 0x0966D1B0  token: 0x600003C
        public System.Boolean __Gen_Wrap_22(Beyond.Gameplay.Core.FSkeletalMorphPose& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2, Beyond.Gameplay.Core.FMorphCtrlValue& P3) { }
        // RVA: 0x0966D3C8  token: 0x600003D
        public System.Int32 __Gen_Wrap_23(Beyond.Gameplay.Core.FSkeletalMorphPose& P0, Beyond.Gameplay.Core.EMorphPartType P1) { }
        // RVA: 0x0966D578  token: 0x600003E
        public System.Void __Gen_Wrap_24(Beyond.Gameplay.Core.FSkeletalMorphPose& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2, Beyond.Gameplay.Core.FMorphCtrlValue& P3) { }
        // RVA: 0x03D05720  token: 0x600003F
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000016  // size: 0x40
    public class ILFixInterfaceBridge : IFix.Core.AnonymousStorey
    {
        // Methods
        // RVA: 0x0966E208  token: 0x6000040
        public System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0350B670  token: 0x6000041
        public System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000017  // size: 0x18
    public class WrappersManagerImpl : IFix.Core.WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000042
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0966E774  token: 0x6000043
        public static IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        // RVA: 0x029F2F80  token: 0x6000044
        public static System.Boolean IsPatched(System.Int32 id) { }
        // RVA: 0x0966E630  token: 0x6000045
        public virtual System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        // RVA: 0x0966E6FC  token: 0x6000046
        public virtual System.Object CreateWrapper(System.Int32 id) { }
        // RVA: 0x0966E7D8  token: 0x6000047
        public virtual System.Object InitWrapperArray(System.Int32 len) { }
        // RVA: 0x0966E58C  token: 0x6000048
        public virtual IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000018  // size: 0x14
    public sealed struct IDMAP0
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static IFix.IDMAP0 Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-SimpleWriteLock-EnterLock0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-SimpleWriteLock-MainThreadEnterLock0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-SimpleWriteLock-ExitLock0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-TrackerLock-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-SkeletalMorphUnsafeJobUtils-FromMaya0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-ApplyBoneToAnimatorTransJob-Execute0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-ApplyBoneToAnimatorTransJob-CleanAnimatorTransJob0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-ApplyBoneToAnimatorTransJob-SetAnimatorTransPhysicsRatioPtr0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FBoneRuntimeData-ToString0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphMappingData-IsValid0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphMappingData-GetBoneData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphMappingData-SetMapping0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphAnim-IsValid0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphAnim-Create0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphAnim-GetCurveData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphAnim-GetCurveLen0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphAnim-SetCurveData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FMorphCtrlCurve-Create0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FMorphCtrlCurve-Create1;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphPose-IsValid0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphPose-AllCurveNum0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphPose-Create0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphPose-GetValueData0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphPose-GetValueLen0;  // const
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphPose-SetValueData0;  // const

    }

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

