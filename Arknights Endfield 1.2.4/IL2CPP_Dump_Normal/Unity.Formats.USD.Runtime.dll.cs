// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Formats.USD.Runtime.dll
// Classes:  112
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x200000F  // size: 0x18
    public sealed class <>c__DisplayClass5_0
    {
        // Fields
        public pxr.UsdVariantSets variantSets;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000032
        public System.Void .ctor() { }
        // RVA: 0x09B79730  token: 0x6000033
        private System.String <LoadFromUsd>b__0(System.String setName) { }
        // RVA: 0x09B79750  token: 0x6000034
        private System.Collections.Generic.IEnumerable<System.String> <LoadFromUsd>b__1(System.String setName) { }
        // RVA: 0x09B79780  token: 0x6000035
        private System.Int32 <LoadFromUsd>b__2(System.String setName) { }

    }

    // TypeToken: 0x2000019  // size: 0x90
    public sealed class <Import>d__5 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public USD.NET.Scene scene;  // 0x20
        public Unity.Formats.USD.MeshImportStrategy <>4__this;  // 0x28
        public Unity.Formats.USD.PrimMap primMap;  // 0x30
        public Unity.Formats.USD.SceneImportOptions importOptions;  // 0x38
        private System.Reflection.MemberInfo <faceVertexCounts>5__2;  // 0x40
        private System.Reflection.MemberInfo <faceVertexIndices>5__3;  // 0x48
        private System.Reflection.MemberInfo <orientation>5__4;  // 0x50
        private System.Reflection.MemberInfo <points>5__5;  // 0x58
        private System.Reflection.MemberInfo <normals>5__6;  // 0x60
        private System.Reflection.MemberInfo <colors>5__7;  // 0x68
        private System.Reflection.MemberInfo <purpose>5__8;  // 0x70
        private System.Reflection.MemberInfo <visibility>5__9;  // 0x78
        private System.Boolean <isDynamic>5__10;  // 0x80
        private System.Collections.Generic.IEnumerator<USD.NET.SampleEnumerator.SampleHolder<Unity.Formats.USD.SanitizedMeshSample>> <>7__wrap10;  // 0x88

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000057
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x09B79634  token: 0x6000058
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09B77EE4  token: 0x6000059
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09B796AC  token: 0x600005A
        private System.Void <>m__Finally1() { }
        // RVA: 0x09B795E8  token: 0x600005C
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200001B  // size: 0x18
    public class GeometrySubsets
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,System.Int32[]> <Subsets>k__BackingField;  // 0x10

        // Properties
        System.Collections.Generic.Dictionary<System.String,System.Int32[]> Subsets { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x09B6B244  token: 0x600006D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001C  // size: 0x30
    public sealed class <>c__DisplayClass5_0
    {
        // Fields
        public UnityEngine.Mesh unityMesh;  // 0x10
        public UnityEngine.Renderer renderer;  // 0x18
        public System.String path;  // 0x20
        public Unity.Formats.USD.SanitizedMeshSample usdMesh;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x600006E
        public System.Void .ctor() { }
        // RVA: 0x09B796FC  token: 0x600006F
        private System.Void <BuildMesh_>b__0(USD.NET.Scene scene, UnityEngine.Material boundMat, System.Collections.Generic.List<System.String> primvars) { }

    }

    // TypeToken: 0x200001D  // size: 0x20
    public sealed class <>c__DisplayClass5_1
    {
        // Fields
        public System.Int32 idx;  // 0x10
        public Unity.Formats.USD.MeshImporter.<>c__DisplayClass5_0 CS$<>8__locals1;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000070
        public System.Void .ctor() { }
        // RVA: 0x09B797C0  token: 0x6000071
        private System.Void <BuildMesh_>b__1(USD.NET.Scene scene, UnityEngine.Material boundMat, System.Collections.Generic.List<System.String> primvars) { }

    }

    // TypeToken: 0x2000027  // size: 0x80
    public sealed class ExportHandler : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x08145D50  token: 0x600008B
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x01028930  token: 0x600008C
        public virtual System.Void Invoke(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath) { }
        // RVA: 0x05539CE4  token: 0x600008D
        public virtual System.IAsyncResult BeginInvoke(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x600008E
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000029  // size: 0x80
    public sealed class TextureResolver : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x09B90260  token: 0x6000096
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x01035ED0  token: 0x6000097
        public virtual UnityEngine.Texture2D Invoke(pxr.SdfAssetPath textureAssetPath, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions importOptions) { }
        // RVA: 0x09B901D8  token: 0x6000098
        public virtual System.IAsyncResult BeginInvoke(pxr.SdfAssetPath textureAssetPath, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions importOptions, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x04276D7C  token: 0x6000099
        public virtual UnityEngine.Texture2D EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200002B  // size: 0x80
    public sealed class MaterialBinder : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x08147754  token: 0x60000AC
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x011360D0  token: 0x60000AD
        public virtual System.Void Invoke(USD.NET.Scene scene, UnityEngine.Material mat, System.Collections.Generic.List<System.String> uvPrimvars) { }
        // RVA: 0x050C0AC4  token: 0x60000AE
        public virtual System.IAsyncResult BeginInvoke(USD.NET.Scene scene, UnityEngine.Material mat, System.Collections.Generic.List<System.String> uvPrimvars, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x60000AF
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200002D  // size: 0x14
    public sealed struct ConversionType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Unity.Formats.USD.ShaderExporterBase.ConversionType None;  // const
        public static Unity.Formats.USD.ShaderExporterBase.ConversionType SwapRASmoothnessToBGRoughness;  // const
        public static Unity.Formats.USD.ShaderExporterBase.ConversionType InvertAlpha;  // const
        public static Unity.Formats.USD.ShaderExporterBase.ConversionType UnpackNormal;  // const
        public static Unity.Formats.USD.ShaderExporterBase.ConversionType MaskMapToORM;  // const
        public static Unity.Formats.USD.ShaderExporterBase.ConversionType RemoveAlpha;  // const

    }

    // TypeToken: 0x200002F  // size: 0x18
    public sealed class <>c__DisplayClass34_0
    {
        // Fields
        public System.String localName;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60000BC
        public System.Void .ctor() { }
        // RVA: 0x06091C38  token: 0x60000BD
        private System.Boolean <MergePrimvars>b__0(System.String str) { }

    }

    // TypeToken: 0x2000031  // size: 0x14
    public sealed struct StandardShaderBlendMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Unity.Formats.USD.StandardShaderExporter.StandardShaderBlendMode Opaque;  // const
        public static Unity.Formats.USD.StandardShaderExporter.StandardShaderBlendMode Cutout;  // const
        public static Unity.Formats.USD.StandardShaderExporter.StandardShaderBlendMode Fade;  // const
        public static Unity.Formats.USD.StandardShaderExporter.StandardShaderBlendMode Transparent;  // const

    }

    // TypeToken: 0x200003F  // size: 0x48
    public sealed struct HierInfo
    {
        // Fields
        public System.Boolean isVisible;  // 0x10
        public System.Boolean isInstance;  // 0x11
        public System.Boolean isAssembly;  // 0x12
        public System.Boolean isModel;  // 0x13
        public System.Boolean hasPayload;  // 0x14
        public pxr.UsdPrim prim;  // 0x18
        public pxr.UsdSkelBindingVector skelBindings;  // 0x20
        public pxr.SdfPath[] skelJoints;  // 0x28
        public System.String modelAssetPath;  // 0x30
        public System.String modelName;  // 0x38
        public System.String modelVersion;  // 0x40

    }

    // TypeToken: 0x2000040  // size: 0x11
    public sealed struct ReadHierJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public static Unity.Formats.USD.HierarchyBuilder.HierInfo[] result;  // static @ 0x0
        public static USD.NET.Scene scene;  // static @ 0x8
        public static pxr.UsdSkelCache skelCache;  // static @ 0x10
        public static pxr.SdfPath[] paths;  // static @ 0x18

        // Methods
        // RVA: 0x09B85084  token: 0x6000106
        public System.Void Run() { }
        // RVA: 0x09B84E98  token: 0x6000107
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000042
    public interface IQuery
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600010A
        public virtual pxr.SdfPath[] Find(USD.NET.Scene scene, pxr.SdfPath usdRoot) { }

    }

    // TypeToken: 0x2000043  // size: 0x11
    public sealed struct Query`1 : IQuery
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x600010B
        public virtual pxr.SdfPath[] Find(USD.NET.Scene scene, pxr.SdfPath usdRoot) { }

    }

    // TypeToken: 0x2000041  // size: 0x11
    public sealed struct FindPathsJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public static pxr.SdfPath usdRoot;  // static @ 0x0
        public static USD.NET.Scene scene;  // static @ 0x8
        public static pxr.SdfPath[][] results;  // static @ 0x10
        public static Unity.Formats.USD.HierarchyBuilder.FindPathsJob.IQuery[] queries;  // static @ 0x18

        // Methods
        // RVA: 0x09B7F51C  token: 0x6000108
        public System.Void Run() { }
        // RVA: 0x09B7F46C  token: 0x6000109
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000044  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Unity.Formats.USD.HierarchyBuilder.<>c <>9;  // static @ 0x0
        public static System.Func<pxr.SdfPath[],System.Boolean> <>9__4_0;  // static @ 0x8
        public static System.Func<pxr.SdfPath[],System.Collections.Generic.IEnumerable<pxr.SdfPath>> <>9__4_1;  // static @ 0x10

        // Methods
        // RVA: 0x09B97104  token: 0x600010C
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600010D
        public System.Void .ctor() { }
        // RVA: 0x0686B910  token: 0x600010E
        private System.Boolean <BeginReading>b__4_0(pxr.SdfPath[] i) { }
        // RVA: 0x03D51810  token: 0x600010F
        private System.Collections.Generic.IEnumerable<pxr.SdfPath> <BeginReading>b__4_1(pxr.SdfPath[] i) { }

    }

    // TypeToken: 0x200004A  // size: 0x20
    public sealed struct InstanceRoot
    {
        // Fields
        public UnityEngine.GameObject gameObject;  // 0x10
        public pxr.SdfPath masterPath;  // 0x18

    }

    // TypeToken: 0x2000053  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly Unity.Formats.USD.SceneExporter.<>c <>9;  // static @ 0x0
        public static System.Func<UnityEngine.Transform,System.String> <>9__8_0;  // static @ 0x8
        public static System.Func<System.String,System.String> <>9__8_1;  // static @ 0x10

        // Methods
        // RVA: 0x09B97168  token: 0x6000152
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000153
        public System.Void .ctor() { }
        // RVA: 0x09B970B8  token: 0x6000154
        private System.String <MergeBonesBelowAnimator>b__8_0(UnityEngine.Transform boneXf) { }
        // RVA: 0x03D51810  token: 0x6000155
        private System.String <MergeBonesBelowAnimator>b__8_1(System.String str) { }

    }

    // TypeToken: 0x2000056  // size: 0x90
    public class ImportException : System.Exception
    {
        // Methods
        // RVA: 0x09B830AC  token: 0x6000162
        public System.Void .ctor() { }
        // RVA: 0x09B83158  token: 0x6000163
        public System.Void .ctor(System.String message) { }
        // RVA: 0x09B830F8  token: 0x6000164
        public System.Void .ctor(System.String message, System.Exception innerException) { }

    }

    // TypeToken: 0x2000057  // size: 0x110
    public sealed class <BuildScene>d__8 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Unity.Formats.USD.SceneImportOptions importOptions;  // 0x20
        public System.Single targetFrameMilliseconds;  // 0x28
        public UnityEngine.GameObject root;  // 0x30
        public Unity.Formats.USD.PrimMap primMap;  // 0x38
        public USD.NET.Scene scene;  // 0x40
        public System.Boolean composingSubtree;  // 0x48
        private System.Diagnostics.Stopwatch <timer>5__2;  // 0x50
        private pxr.SdfPath <usdPrimRoot>5__3;  // 0x58
        private System.Single <targetTime>5__4;  // 0x60
        private System.Collections.Generic.List<pxr.UsdSkelRoot> <skelRoots>5__5;  // 0x68
        private Unity.Formats.USD.ReadAllJob<Unity.Formats.USD.SanitizedXformSample> <readXforms>5__6;  // 0x70
        private pxr.SdfPath[] <>7__wrap6;  // 0x78
        private System.Int32 <>7__wrap7;  // 0x80
        private System.Collections.Generic.IEnumerator<USD.NET.SampleEnumerator.SampleHolder<USD.NET.Unity.MaterialSample>> <>7__wrap8;  // 0x88
        private System.Collections.Generic.IEnumerator<USD.NET.SampleEnumerator.SampleHolder<Unity.Formats.USD.SanitizedXformSample>> <>7__wrap9;  // 0x90
        private System.Collections.Generic.IEnumerator<USD.NET.SampleEnumerator.SampleHolder<USD.NET.Unity.XformSample>> <>7__wrap10;  // 0x98
        private System.Collections.IEnumerator <it>5__12;  // 0xa0
        private System.Collections.Generic.IEnumerator<USD.NET.SampleEnumerator.SampleHolder<USD.NET.Unity.CubeSample>> <>7__wrap12;  // 0xa8
        private System.Collections.Generic.IEnumerator<USD.NET.SampleEnumerator.SampleHolder<USD.NET.Unity.SphereSample>> <>7__wrap13;  // 0xb0
        private System.Collections.Generic.IEnumerator<USD.NET.SampleEnumerator.SampleHolder<Unity.Formats.USD.SanitizedCameraSample>> <>7__wrap14;  // 0xb8
        private System.Collections.Generic.Dictionary.KeyCollection.Enumerator<pxr.SdfPath,UnityEngine.GameObject> <>7__wrap15;  // 0xc0
        private System.Collections.Generic.Dictionary<pxr.SdfPath,Unity.Formats.USD.SkeletonSample> <skeletonSamples>5__17;  // 0xd8
        private System.Collections.Generic.Dictionary.Enumerator<pxr.SdfPath,Unity.Formats.USD.SkeletonSample> <>7__wrap17;  // 0xe0
        private System.Collections.Generic.IEnumerator<USD.NET.SampleEnumerator.SampleHolder<USD.NET.Unity.PointInstancerSample>> <>7__wrap18;  // 0x108

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000165
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x09B968F4  token: 0x6000166
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09B90388  token: 0x6000167
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09B96E10  token: 0x6000168
        private System.Void <>m__Finally1() { }
        // RVA: 0x09B96E60  token: 0x6000169
        private System.Void <>m__Finally2() { }
        // RVA: 0x09B96EB0  token: 0x600016A
        private System.Void <>m__Finally3() { }
        // RVA: 0x09B96F00  token: 0x600016B
        private System.Void <>m__Finally4() { }
        // RVA: 0x09B96F50  token: 0x600016C
        private System.Void <>m__Finally5() { }
        // RVA: 0x09B96FA0  token: 0x600016D
        private System.Void <>m__Finally6() { }
        // RVA: 0x09B96FF0  token: 0x600016E
        private System.Void <>m__Finally7() { }
        // RVA: 0x09B97040  token: 0x600016F
        private System.Void <>m__Finally8() { }
        // RVA: 0x09B9707C  token: 0x6000170
        private System.Void <>m__Finally9() { }
        // RVA: 0x09B96DC0  token: 0x6000171
        private System.Void <>m__Finally10() { }
        // RVA: 0x09B968A8  token: 0x6000173
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200006C  // size: 0x70
    public sealed class <>c__DisplayClass17_0
    {
        // Fields
        public Unity.Formats.USD.UsdRecorderBehaviour <>4__this;  // 0x10
        public UnityEngine.Playables.Playable playable;  // 0x18
        public UnityEngine.Playables.FrameData info;  // 0x28
        public System.Object playerData;  // 0x68

        // Methods
        // RVA: 0x0350B670  token: 0x60001AC
        public System.Void .ctor() { }
        // RVA: 0x09B9AAC4  token: 0x60001AD
        private System.Void <ProcessFrame>b__0() { }

    }

    // TypeToken: 0x2000070  // size: 0x28
    public sealed class <WaitForEndOfFrame>d__4 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public Unity.Formats.USD.UsdWaitForEndOfFrame <>4__this;  // 0x20

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x60001BE
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60001BF
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09B9AB2C  token: 0x60001C0
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09B9ADB0  token: 0x60001C2
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000003  // size: 0x10
    public static class AnimatorBlackboardUtility
    {
        // Fields
        private static System.Boolean s_enableFastPathBuffer;  // static @ 0x0

        // Methods
        // RVA: -1  // generic def  token: 0x6000002
        private static System.Void ClearAndEnsureDictionaryCapacity(System.Collections.Generic.Dictionary<TKey,TValue>& dict, System.Int32 capacity) { }

    }

    // TypeToken: 0x2000004  // size: 0x10
    public class AnimatorBlackboardAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000003
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000005  // size: 0x10
    public class CameraControlConfigAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000004
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000006  // size: 0x20
    public class DataNAttribute : System.Attribute
    {
        // Fields
        public System.Int32 capacity;  // 0x10
        public System.Int32 tSize;  // 0x14
        public System.Boolean ring;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000005
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000007  // size: 0x18
    public class ECSComponentAttribute : System.Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;  // 0x10
        public System.Boolean isTag;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x6000006
        public System.Void .ctor() { }

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

namespace Unity.Formats.USD
{

    // TypeToken: 0x2000008  // size: 0x18
    public class UsdAssemblyRoot : UnityEngine.MonoBehaviour
    {
        // Methods
        // RVA: 0x0426FE60  token: 0x6000007
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000009  // size: 0xD0
    public class UsdAsset : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.String m_usdFile;  // 0x18
        public System.String m_projectAssetPath;  // 0x20
        public System.String m_usdRootPath;  // 0x28
        public System.Single m_usdTimeOffset;  // 0x30
        public Unity.Formats.USD.PayloadPolicy m_payloadPolicy;  // 0x34
        public System.Boolean m_importHierarchy;  // 0x38
        public System.Single m_scale;  // 0x3c
        public Unity.Formats.USD.BasisTransformation m_changeHandedness;  // 0x40
        public USD.NET.Scene.InterpolationMode m_interpolation;  // 0x44
        public System.Boolean m_useOriginalShaderIfAvailable;  // 0x48
        public UnityEngine.Material m_displayColorMaterial;  // 0x50
        public UnityEngine.Material m_specularWorkflowMaterial;  // 0x58
        public UnityEngine.Material m_metallicWorkflowMaterial;  // 0x60
        public System.Boolean m_enableGpuInstancing;  // 0x68
        public Unity.Formats.USD.ImportMode m_points;  // 0x6c
        public Unity.Formats.USD.ImportMode m_topology;  // 0x70
        public Unity.Formats.USD.ImportMode m_boundingBox;  // 0x74
        public Unity.Formats.USD.ImportMode m_color;  // 0x78
        public Unity.Formats.USD.ImportMode m_normals;  // 0x7c
        public Unity.Formats.USD.ImportMode m_tangents;  // 0x80
        public System.Boolean m_generateLightmapUVs;  // 0x84
        public System.Single m_unwrapAngleError;  // 0x88
        public System.Single m_unwrapAreaError;  // 0x8c
        public System.Single m_unwrapHardAngle;  // 0x90
        public System.Int32 m_unwrapPackMargin;  // 0x94
        public Unity.Formats.USD.MaterialImportMode m_materialImportMode;  // 0x98
        public System.Boolean m_importCameras;  // 0x9c
        public System.Boolean m_importMeshes;  // 0x9d
        public System.Boolean m_importSkinning;  // 0x9e
        public System.Boolean m_importTransforms;  // 0x9f
        public System.Boolean m_importSceneInstances;  // 0xa0
        public System.Boolean m_importPointInstances;  // 0xa1
        public System.Boolean m_importMonoBehaviors;  // 0xa2
        public System.Boolean m_debugShowSkeletonBindPose;  // 0xa3
        public System.Boolean m_debugShowSkeletonRestPose;  // 0xa4
        public System.Boolean m_debugPrintVariabilityCache;  // 0xa5
        public System.Boolean m_usdVariabilityCache;  // 0xa6
        public Unity.Formats.USD.BasisTransformation LastHandedness;  // 0xa8
        public System.Single LastScale;  // 0xac
        private System.Single m_lastTime;  // 0xb0
        private USD.NET.Scene m_lastScene;  // 0xb8
        private Unity.Formats.USD.PrimMap m_lastPrimMap;  // 0xc0
        private USD.NET.AccessMask m_lastAccessMask;  // 0xc8

        // Properties
        System.Double Length { get; /* RVA: 0x09B7CE4C */ }
        System.String usdFullPath { get; /* RVA: 0x09B7CE54 */ set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x09B7A858  token: 0x600000B
        private System.Void OnDestroy() { }
        // RVA: 0x01002730  token: 0x600000C
        private System.String GetPrefabAssetPath(UnityEngine.GameObject root) { }
        // RVA: 0x09B7A900  token: 0x600000D
        public System.Void OptionsToState(Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x09B7C958  token: 0x600000E
        public System.Void StateToOptions(Unity.Formats.USD.SceneImportOptions& options) { }
        // RVA: 0x09B7AF44  token: 0x600000F
        private System.Boolean SceneFileChanged() { }
        // RVA: 0x09B7A374  token: 0x6000010
        public USD.NET.Scene GetScene() { }
        // RVA: 0x09B7A89C  token: 0x6000011
        private System.Void OnReload() { }
        // RVA: 0x09B79D24  token: 0x6000012
        private System.Void DestroyComponent(UnityEngine.Component comp) { }
        // RVA: 0x09B79B54  token: 0x6000013
        private System.Void ClearLastData() { }
        // RVA: 0x09B7AD48  token: 0x6000014
        public System.Void RemoveAllUsdComponents() { }
        // RVA: 0x09B79C00  token: 0x6000015
        public System.Void DestroyAllImportedObjects() { }
        // RVA: 0x09B7ABC0  token: 0x6000016
        public System.Void Reload(System.Boolean forceRebuild) { }
        // RVA: 0x09B7A2D8  token: 0x6000017
        private pxr.UsdPrim GetFirstPrim(USD.NET.Scene scene) { }
        // RVA: 0x09B79D84  token: 0x6000018
        public System.Void ExportOverrides(USD.NET.Scene sceneInWhichToStoreTransforms) { }
        // RVA: 0x09B79B9C  token: 0x6000019
        private System.Double ComputeLength() { }
        // RVA: 0x09B7B88C  token: 0x600001A
        public System.Void SetTime(System.Double time, Unity.Formats.USD.UsdAsset foreignRoot, System.Boolean saveMeshUpdates) { }
        // RVA: 0x09B7CD50  token: 0x600001B
        private System.Void Update() { }
        // RVA: 0x09B7AB3C  token: 0x600001C
        public static System.Void PrepOptionsForTimeChange(Unity.Formats.USD.SceneImportOptions& options) { }
        // RVA: 0x09B7A688  token: 0x600001D
        public System.Void ImportUsdAsCoroutine(UnityEngine.GameObject goRoot, System.String usdFilePath, System.Double time, Unity.Formats.USD.SceneImportOptions importOptions, System.Single targetFrameMilliseconds) { }
        // RVA: 0x09B7B044  token: 0x600001E
        public System.Void SetPayloadState(UnityEngine.GameObject go, System.Boolean isLoaded) { }
        // RVA: 0x09B79810  token: 0x600001F
        private System.Void ApplyVariantSelectionState(USD.NET.Scene scene, Unity.Formats.USD.UsdVariantSet variants) { }
        // RVA: 0x09B7C04C  token: 0x6000020
        public System.Void SetVariantSelection(UnityEngine.GameObject go, System.String usdPrimPath, System.Collections.Generic.Dictionary<System.String,System.String> selections) { }
        // RVA: 0x09B7CD90  token: 0x6000021
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000A  // size: 0x30
    public class UsdLayerStack : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.String m_targetLayer;  // 0x18
        public System.String[] m_layerStack;  // 0x20
        public System.String[] m_mutedLayers;  // 0x28

        // Methods
        // RVA: 0x09B7D3B0  token: 0x6000022
        private System.Void SetupNewSubLayer(USD.NET.Scene parentScene, USD.NET.Scene subLayerScene) { }
        // RVA: 0x09B7CECC  token: 0x6000023
        public System.Void SaveLayerStack(USD.NET.Scene scene, System.String[] layerStack) { }
        // RVA: 0x09B7D078  token: 0x6000024
        public System.Void SaveToLayer() { }
        // RVA: 0x0426FE60  token: 0x6000025
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000B  // size: 0x30
    public class UsdModelRoot : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.String m_modelName;  // 0x18
        public System.String m_modelVersion;  // 0x20
        public System.String m_modelAssetPath;  // 0x28

        // Methods
        // RVA: 0x0426FE60  token: 0x6000026
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000C  // size: 0x20
    public class UsdPayload : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Boolean m_isLoaded;  // 0x18
        private System.Boolean m_wasLoaded;  // 0x19

        // Properties
        System.Boolean IsLoaded { get; /* RVA: 0x01002A50 */ }

        // Methods
        // RVA: 0x03D587A0  token: 0x6000028
        public System.Void Load() { }
        // RVA: 0x03D566B0  token: 0x6000029
        public System.Void Unload() { }
        // RVA: 0x03D76A40  token: 0x600002A
        public System.Void SetInitialState(System.Boolean loaded) { }
        // RVA: 0x09B7D440  token: 0x600002B
        public System.Void Update() { }
        // RVA: 0x09B7D4CC  token: 0x600002C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000D  // size: 0x20
    public class UsdPrimSource : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.String m_usdPrimPath;  // 0x18

        // Methods
        // RVA: 0x0426FE60  token: 0x600002D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000E  // size: 0x40
    public class UsdVariantSet : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.String[] m_variantSetNames;  // 0x18
        public System.String[] m_selected;  // 0x20
        public System.String[] m_variants;  // 0x28
        public System.Int32[] m_variantCounts;  // 0x30
        public System.String m_primPath;  // 0x38

        // Methods
        // RVA: 0x09B7D644  token: 0x600002E
        public System.Void LoadFromUsd(pxr.UsdPrim prim) { }
        // RVA: 0x09B7D4DC  token: 0x600002F
        public System.Void ApplyVariantSelections() { }
        // RVA: 0x09B7D574  token: 0x6000030
        public System.Collections.Generic.Dictionary<System.String,System.String> GetVariantSelections() { }
        // RVA: 0x0426FE60  token: 0x6000031
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000010  // size: 0x28
    public class SkinnedMeshUnityDiff : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.SkinnedMeshRenderer m_usdMesh;  // 0x18
        public UnityEngine.SkinnedMeshRenderer m_unityMesh;  // 0x20

        // Methods
        // RVA: 0x09B75208  token: 0x6000036
        private System.Void OnEnable() { }
        // RVA: 0x09B75170  token: 0x6000037
        private System.Boolean Approximately(UnityEngine.Matrix4x4 rhs, UnityEngine.Matrix4x4 lhs) { }
        // RVA: 0x09B761DC  token: 0x6000038
        private System.Boolean WeightsMatch(UnityEngine.BoneWeight w1, UnityEngine.BoneWeight w2) { }
        // RVA: 0x09B751DC  token: 0x6000039
        private System.Boolean IndicesMatch(UnityEngine.BoneWeight w1, UnityEngine.BoneWeight w2) { }
        // RVA: 0x0350B670  token: 0x600003A
        private System.Void Update() { }
        // RVA: 0x0426FE60  token: 0x600003B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000011  // size: 0x30
    public class SkinnedMeshUsdDiff : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.String m_usdFile;  // 0x18
        public System.String m_usdMeshPath;  // 0x20
        public Unity.Formats.USD.BasisTransformation m_basisTransform;  // 0x28

        // Methods
        // RVA: 0x09B763E8  token: 0x600003C
        private System.Void OnEnable() { }
        // RVA: -1  // generic def  token: 0x600003D
        private System.String GetUsdBoneData(System.Int32 bone, System.Int32 weightIndex, USD.NET.Primvar<T[]> primvar) { }
        // RVA: 0x09B76244  token: 0x600003E
        private USD.NET.Scene GetScene() { }
        // RVA: 0x09B777A0  token: 0x600003F
        private Unity.Formats.USD.SkelBindingSample ReadUsdWeights(USD.NET.Scene scene) { }
        // RVA: 0x09B77384  token: 0x6000040
        private Unity.Formats.USD.SkeletonSample ReadUsdSkeleton(USD.NET.Scene scene, System.String& skelRootPath) { }
        // RVA: 0x0350B670  token: 0x6000041
        private System.Void Update() { }
        // RVA: 0x0426FE60  token: 0x6000042
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000012  // size: 0x10
    public static class CameraExporter
    {
        // Methods
        // RVA: 0x09B693EC  token: 0x6000043
        public static System.Void ExportCamera(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }

    }

    // TypeToken: 0x2000013  // size: 0x10
    public static class CameraImporter
    {
        // Methods
        // RVA: 0x09B696B4  token: 0x6000044
        public static System.Void BuildCamera(USD.NET.Unity.CameraSample usdCamera, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options) { }

    }

    // TypeToken: 0x2000014  // size: 0x10
    public static class CubeImporter
    {
        // Methods
        // RVA: 0x09B69770  token: 0x6000045
        public static System.Void BuildCube(USD.NET.Unity.CubeSample usdCube, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options, System.Boolean skinnedMesh) { }
        // RVA: 0x094C2728  token: 0x6000046
        private static System.Boolean ShouldImport(Unity.Formats.USD.ImportMode mode) { }
        // RVA: 0x05A36584  token: 0x6000047
        private static System.Boolean ShouldCompute(Unity.Formats.USD.ImportMode mode) { }

    }

    // TypeToken: 0x2000015  // size: 0x10
    public static class InstanceImporter
    {
        // Methods
        // RVA: 0x09B6DB58  token: 0x6000048
        public static System.Void BuildSceneInstances(Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x09B6D4C4  token: 0x6000049
        public static System.Void BuildPointInstances(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, System.String pointInstancerPath, USD.NET.Unity.PointInstancerSample sample, UnityEngine.GameObject root, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x09B6E150  token: 0x600004A
        private static System.Void EnableGpuInstancing(UnityEngine.GameObject go) { }

    }

    // TypeToken: 0x2000016  // size: 0x10
    public static class MeshExporter
    {
        // Fields
        private static pxr.TfToken m_materialBindToken;  // static @ 0x0
        private static pxr.TfToken m_subMeshesToken;  // static @ 0x8

        // Methods
        // RVA: 0x09B72618  token: 0x600004B
        public static System.Void ExportSkinnedMesh(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }
        // RVA: 0x09B720C4  token: 0x600004C
        private static System.Void ExportSkelWeights(USD.NET.Scene scene, System.String path, UnityEngine.Mesh unityMesh, UnityEngine.Transform rootBone, UnityEngine.Transform[] bones, System.String skeletonPath) { }
        // RVA: 0x09B71F94  token: 0x600004D
        public static System.Void ExportMesh(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }
        // RVA: 0x09B70B18  token: 0x600004E
        private static System.Void ExportMesh(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext, UnityEngine.Mesh mesh, UnityEngine.Material sharedMaterial, UnityEngine.Material[] sharedMaterials, System.Boolean exportMeshPose) { }
        // RVA: 0x09B72918  token: 0x600004F
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000017
    public sealed class MeshImportFunction`1 : System.MulticastDelegate
    {
        // Methods
        // RVA: -1  // runtime  token: 0x6000050
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: -1  // runtime  token: 0x6000051
        public virtual System.Void Invoke(System.String path, T sample, Unity.Formats.USD.MeshImporter.GeometrySubsets subsets, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions option, System.Boolean isDynamic, pxr.UsdSkelSkinningQuery query) { }
        // RVA: -1  // runtime  token: 0x6000052
        public virtual System.IAsyncResult BeginInvoke(System.String path, T sample, Unity.Formats.USD.MeshImporter.GeometrySubsets subsets, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions option, System.Boolean isDynamic, pxr.UsdSkelSkinningQuery query, System.AsyncCallback callback, System.Object object) { }
        // RVA: -1  // runtime  token: 0x6000053
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000018  // size: 0x28
    public class MeshImportStrategy : Unity.Formats.USD.IImporter
    {
        // Fields
        private Unity.Formats.USD.MeshImportFunction<Unity.Formats.USD.SanitizedMeshSample> m_meshImporter;  // 0x10
        private Unity.Formats.USD.MeshImportFunction<Unity.Formats.USD.SanitizedMeshSample> m_skinnedMeshImporter;  // 0x18
        private Unity.Formats.USD.ReadAllJob<Unity.Formats.USD.SanitizedMeshSample> m_readMeshesJob;  // 0x20

        // Methods
        // RVA: 0x02676770  token: 0x6000054
        public System.Void .ctor(Unity.Formats.USD.MeshImportFunction<Unity.Formats.USD.SanitizedMeshSample> meshImporter, Unity.Formats.USD.MeshImportFunction<Unity.Formats.USD.SanitizedMeshSample> skinnedMeshImporter) { }
        // RVA: 0x09B72A08  token: 0x6000055
        public virtual System.Void BeginReading(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions) { }
        // RVA: 0x09B72AD4  token: 0x6000056
        public virtual System.Collections.IEnumerator Import(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions) { }

    }

    // TypeToken: 0x200001A  // size: 0x10
    public static class MeshImporter
    {
        // Methods
        // RVA: 0x09B74D18  token: 0x600005E
        public static Unity.Formats.USD.MeshImporter.GeometrySubsets ReadGeomSubsets(USD.NET.Scene scene, System.String path) { }
        // RVA: 0x09B740F0  token: 0x600005F
        public static System.Void BuildSkinnedMesh(System.String path, Unity.Formats.USD.SanitizedMeshSample usdMesh, Unity.Formats.USD.MeshImporter.GeometrySubsets geomSubsets, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options, System.Boolean isDynamic, pxr.UsdSkelSkinningQuery skinningQuery) { }
        // RVA: 0x09B742B0  token: 0x6000060
        public static System.Void ImportSkinning(System.String path, Unity.Formats.USD.SanitizedMeshSample usdMesh, UnityEngine.Mesh unityMesh, pxr.UsdSkelSkinningQuery skinningQuery) { }
        // RVA: 0x09B73F38  token: 0x6000061
        public static System.Void BuildMesh(System.String path, Unity.Formats.USD.SanitizedMeshSample usdMesh, Unity.Formats.USD.MeshImporter.GeometrySubsets geomSubsets, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options, System.Boolean isDynamic, pxr.UsdSkelSkinningQuery skinQuery) { }
        // RVA: 0x09B72C70  token: 0x6000062
        private static System.Void BuildMesh_(System.String path, Unity.Formats.USD.SanitizedMeshSample usdMesh, UnityEngine.Mesh unityMesh, Unity.Formats.USD.MeshImporter.GeometrySubsets geomSubsets, UnityEngine.GameObject go, UnityEngine.Renderer renderer, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x09B74A80  token: 0x6000063
        private static System.Void LoadPrimvars(UnityEngine.Mesh unityMesh, System.String usdMeshPath, System.Collections.Generic.List<System.String> primvars, USD.NET.Unity.MeshSample sample) { }
        // RVA: 0x09B72C20  token: 0x6000064
        private static System.Void BindMat(UnityEngine.Mesh unityMesh, UnityEngine.Material mat, UnityEngine.Renderer renderer, System.String usdMeshPath, System.Collections.Generic.List<System.String> primvars, USD.NET.Unity.MeshSample sample) { }
        // RVA: 0x09B72B7C  token: 0x6000065
        private static System.Void BindMat(UnityEngine.Mesh unityMesh, UnityEngine.Material mat, UnityEngine.Renderer renderer, System.Int32 index, System.String usdMeshPath, System.Collections.Generic.List<System.String> primvars, USD.NET.Unity.MeshSample sample) { }
        // RVA: -1  // generic def  token: 0x6000066
        private static T[] TryGetPrimvarValue(USD.NET.Primvar<System.Object> primvar) { }
        // RVA: 0x09B748C8  token: 0x6000067
        private static System.Void ImportUv(UnityEngine.Mesh unityMesh, System.Int32 uvSetIndex, USD.NET.Primvar<System.Object> uv) { }
        // RVA: 0x094C2728  token: 0x6000068
        public static System.Boolean ShouldImport(Unity.Formats.USD.ImportMode mode) { }
        // RVA: 0x05A36584  token: 0x6000069
        public static System.Boolean ShouldCompute(Unity.Formats.USD.ImportMode mode) { }
        // RVA: 0x09B750C0  token: 0x600006A
        private static System.String UniqueMeshName(System.String meshName) { }

    }

    // TypeToken: 0x200001E  // size: 0x14
    public sealed struct ImportMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Unity.Formats.USD.ImportMode Import;  // const
        public static Unity.Formats.USD.ImportMode ImportOrCompute;  // const
        public static Unity.Formats.USD.ImportMode Compute;  // const
        public static Unity.Formats.USD.ImportMode Ignore;  // const

    }

    // TypeToken: 0x200001F  // size: 0x40
    public class MeshImportOptions
    {
        // Fields
        public System.Boolean debugShowSkeletonRestPose;  // 0x10
        public System.Boolean debugShowSkeletonBindPose;  // 0x11
        public Unity.Formats.USD.ImportMode points;  // 0x14
        public Unity.Formats.USD.ImportMode topology;  // 0x18
        public System.Boolean triangulateMesh;  // 0x1c
        public System.Boolean generateLightmapUVs;  // 0x1d
        public System.Single unwrapAngleError;  // 0x20
        public System.Single unwrapAreaError;  // 0x24
        public System.Single unwrapHardAngle;  // 0x28
        public System.Int32 unwrapPackMargin;  // 0x2c
        public Unity.Formats.USD.ImportMode color;  // 0x30
        public Unity.Formats.USD.ImportMode normals;  // 0x34
        public Unity.Formats.USD.ImportMode tangents;  // 0x38
        public Unity.Formats.USD.ImportMode boundingBox;  // 0x3c

        // Methods
        // RVA: 0x03D76A00  token: 0x6000072
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000020  // size: 0x10
    public static class SphereImporter
    {
        // Methods
        // RVA: 0x09B778BC  token: 0x6000073
        public static System.Void BuildSphere(USD.NET.Unity.SphereSample usdSphere, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options, System.Boolean skinnedMesh) { }
        // RVA: 0x094C2728  token: 0x6000074
        private static System.Boolean ShouldImport(Unity.Formats.USD.ImportMode mode) { }
        // RVA: 0x05A36584  token: 0x6000075
        private static System.Boolean ShouldCompute(Unity.Formats.USD.ImportMode mode) { }

    }

    // TypeToken: 0x2000021  // size: 0x10
    public static class XformExporter
    {
        // Methods
        // RVA: 0x09B7D8CC  token: 0x6000076
        public static System.Void ExportXform(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }
        // RVA: 0x09B7DE28  token: 0x6000077
        public static System.Void WriteSparseOverrides(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.BasisTransformation changeHandedness, System.Single tolerance) { }
        // RVA: 0x09B7DB58  token: 0x6000078
        public static UnityEngine.Matrix4x4 GetLocalTransformMatrix(UnityEngine.Transform tr, System.Boolean correctZUp, System.Boolean isRootPrim, Unity.Formats.USD.BasisTransformation conversionType) { }

    }

    // TypeToken: 0x2000022  // size: 0x10
    public static class XformImporter
    {
        // Methods
        // RVA: 0x09B7E690  token: 0x6000079
        public static System.Void BuildXform(pxr.SdfPath path, USD.NET.Unity.XformableSample usdXf, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options, USD.NET.Scene scene) { }
        // RVA: 0x09B7E4F0  token: 0x600007A
        public static System.Void BuildXform(UnityEngine.Matrix4x4 xf, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x09B7E810  token: 0x600007B
        public static System.Void ImportXform(UnityEngine.Matrix4x4& mat, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x09B7E150  token: 0x600007C
        public static System.Void BuildSceneRoot(USD.NET.Scene scene, UnityEngine.Transform root, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x09B7E8F8  token: 0x600007D
        public static System.Void UndoRootTransform(USD.NET.Scene scene, Unity.Formats.USD.UsdAsset stageRoot, UnityEngine.Vector3& localScale, UnityEngine.Quaternion& localRotation) { }

    }

    // TypeToken: 0x2000023  // size: 0x10
    public static class ImporterBase
    {
        // Methods
        // RVA: 0x09B6D010  token: 0x600007E
        public static System.String MakeRelativePath(System.String anchorPath, System.String pathToMakeRelative) { }
        // RVA: 0x09B6CFA8  token: 0x600007F
        public static System.Boolean ApproximatelyEqual(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs) { }
        // RVA: 0x09B6D2AC  token: 0x6000080
        public static System.Void MoveComponentFirst(UnityEngine.Component comp) { }
        // RVA: 0x09B6D300  token: 0x6000081
        public static System.Void MoveComponentLast(UnityEngine.Component comp) { }
        // RVA: -1  // generic def  token: 0x6000082
        public static T GetOrAddComponent(UnityEngine.GameObject go, System.Boolean insertFirst) { }
        // RVA: 0x09B6D354  token: 0x6000083
        public static System.String SafeGetDirectoryName(System.String fullPath) { }

    }

    // TypeToken: 0x2000024  // size: 0x10
    public class HdrpShaderExporter : Unity.Formats.USD.ShaderExporterBase
    {
        // Methods
        // RVA: 0x09B6B2BC  token: 0x6000084
        public static System.Void ExportLit(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, USD.NET.Unity.PreviewSurfaceSample surface, System.String destTexturePath) { }
        // RVA: 0x0350B670  token: 0x6000085
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000025  // size: 0x100
    public class HdrpShaderImporter : Unity.Formats.USD.ShaderImporterBase
    {
        // Fields
        private static UnityEngine.Material ChannelCombinerMat;  // static @ 0x0

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000086
        public System.Void .ctor(UnityEngine.Material material) { }
        // RVA: 0x09B6C980  token: 0x6000087
        public virtual System.Void ImportFromUsd() { }
        // RVA: 0x09B6C274  token: 0x6000088
        private static UnityEngine.Texture2D BuildMaskMap(UnityEngine.Texture2D red, UnityEngine.Texture2D green, UnityEngine.Texture2D blue, UnityEngine.Texture2D alpha) { }

    }

    // TypeToken: 0x2000026  // size: 0x10
    public static class MaterialExporter
    {
        // Fields
        public static readonly System.String kStandardFallbackHandler;  // static @ 0x0
        public static readonly System.String kHdrpFallbackHandler;  // static @ 0x8
        public static readonly System.String kLwrpFallbackHandler;  // static @ 0x10
        public static System.Collections.Generic.Dictionary<System.String,Unity.Formats.USD.MaterialExporter.ExportHandler> ExportRegistry;  // static @ 0x18

        // Methods
        // RVA: 0x09B6E8C8  token: 0x6000089
        private static System.Void .cctor() { }
        // RVA: 0x09B6E3A8  token: 0x600008A
        public static System.Void ExportMaterial(USD.NET.Scene scene, UnityEngine.Material mat, System.String usdMaterialPath) { }

    }

    // TypeToken: 0x2000028  // size: 0x10
    public static class MaterialImporter
    {
        // Fields
        private static readonly pxr.TfToken materialBindToken;  // static @ 0x0
        private static UnityEngine.Material AlbedoGlossCombiner;  // static @ 0x8
        public static Unity.Formats.USD.MaterialImporter.TextureResolver OnResolveTexture;  // static @ 0x10

        // Methods
        // RVA: 0x09B70574  token: 0x600008F
        public static System.Void ProcessMaterialBindings(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions) { }
        // RVA: 0x09B6EF70  token: 0x6000090
        public static UnityEngine.Material BuildMaterial(USD.NET.Scene scene, System.String materialPath, USD.NET.Unity.MaterialSample sample, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: -1  // generic def  token: 0x6000091
        public static UnityEngine.Texture2D ImportConnectedTexture(USD.NET.Scene scene, USD.NET.Connectable<T> connection, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions options, System.String& uvPrimvar) { }
        // RVA: 0x01002730  token: 0x6000092
        private static UnityEngine.Texture2D DefaultTextureResolver(pxr.SdfAssetPath textureAssetPath, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x09B70058  token: 0x6000093
        public static UnityEngine.Texture2D CombineRoughness(UnityEngine.Texture2D rgbTex, UnityEngine.Texture2D roughnessTex, System.String fileNameSuffix) { }
        // RVA: 0x09B70358  token: 0x6000094
        public static Unity.Formats.USD.UnityPreviewSurfaceSample GetSurfaceShaderPrim(USD.NET.Scene scene, System.String primPath) { }
        // RVA: 0x09B70A88  token: 0x6000095
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200002A  // size: 0x50
    public class MaterialMap : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.Material> m_map;  // 0x10
        private System.Collections.Generic.Dictionary<UnityEngine.Color,UnityEngine.Material> m_colorMap;  // 0x18
        private System.Collections.Generic.Dictionary<System.String,Unity.Formats.USD.MaterialMap.MaterialBinder> m_requestedBindings;  // 0x20
        private System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.String>> m_primvars;  // 0x28
        public System.Boolean useOriginalShaderIfAvailable;  // 0x30
        private UnityEngine.Material m_displayColorMaterial;  // 0x38
        private UnityEngine.Material m_specularWorkflowMaterial;  // 0x40
        private UnityEngine.Material m_metallicWorkflowMaterial;  // 0x48

        // Properties
        UnityEngine.Material DisplayColorMaterial { get; /* RVA: 0x09B83FDC */ set; /* RVA: 0x0388FF30 */ }
        UnityEngine.Material SpecularWorkflowMaterial { get; /* RVA: 0x09B84110 */ set; /* RVA: 0x03CB2D80 */ }
        UnityEngine.Material MetallicWorkflowMaterial { get; /* RVA: 0x09B840AC */ set; /* RVA: 0x02692290 */ }
        UnityEngine.Material Item { get; /* RVA: 0x09B84040 */ set; /* RVA: 0x09B84174 */ }

        // Methods
        // RVA: 0x09B83A4C  token: 0x60000A0
        private System.Void InstantiateMaterials() { }
        // RVA: 0x09B83914  token: 0x60000A1
        public System.Collections.Generic.Dictionary<System.String,Unity.Formats.USD.MaterialMap.MaterialBinder> ClearRequestedBindings() { }
        // RVA: 0x09B83D34  token: 0x60000A2
        public System.Void RequestBinding(System.String usdPath, Unity.Formats.USD.MaterialMap.MaterialBinder binder) { }
        // RVA: 0x09B839E4  token: 0x60000A5
        public System.Collections.Generic.List<System.String> GetPrimvars(System.String materialPath) { }
        // RVA: 0x09B83D98  token: 0x60000A6
        public System.Void SetPrimvars(System.String materialPath, System.Collections.Generic.List<System.String> primvars) { }
        // RVA: 0x09B83C1C  token: 0x60000A7
        public UnityEngine.Material InstantiateSolidColor(UnityEngine.Color color) { }
        // RVA: 0x09B83860  token: 0x60000A8
        public static System.Void AssignColor(UnityEngine.Material material, UnityEngine.Color color) { }
        // RVA: 0x09B8399C  token: 0x60000A9
        public virtual System.Collections.IEnumerator GetEnumerator() { }
        // RVA: 0x09B83DFC  token: 0x60000AA
        private virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Material>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Material>>.GetEnumerator() { }
        // RVA: 0x09B83E84  token: 0x60000AB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002C  // size: 0x10
    public class ShaderExporterBase
    {
        // Fields
        private static UnityEngine.Material _metalGlossChannelSwapMaterial;  // static @ 0x0
        private static UnityEngine.Material _normalChannelMaterial;  // static @ 0x8

        // Methods
        // RVA: 0x09B8BF50  token: 0x60000B0
        protected static System.String SetupTexture(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, USD.NET.Unity.PreviewSurfaceSample surface, UnityEngine.Vector4 scale, System.String destTexturePath, System.String textureName, System.String textureOutput, Unity.Formats.USD.ShaderExporterBase.ConversionType conversionType) { }
        // RVA: 0x0350B670  token: 0x60000B1
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002E  // size: 0x100
    public abstract class ShaderImporterBase
    {
        // Fields
        private UnityEngine.Material <Material>k__BackingField;  // 0x10
        private System.Boolean <IsSpecularWorkflow>k__BackingField;  // 0x18
        public System.Nullable<UnityEngine.Color> Diffuse;  // 0x1c
        public UnityEngine.Texture2D DiffuseMap;  // 0x30
        public System.Nullable<UnityEngine.Color> Specular;  // 0x38
        public UnityEngine.Texture2D SpecularMap;  // 0x50
        public System.Nullable<UnityEngine.Vector3> Normal;  // 0x58
        public UnityEngine.Texture2D NormalMap;  // 0x68
        public System.Nullable<System.Single> Displacement;  // 0x70
        public UnityEngine.Texture2D DisplacementMap;  // 0x78
        public System.Nullable<System.Single> Occlusion;  // 0x80
        public UnityEngine.Texture2D OcclusionMap;  // 0x88
        public System.Nullable<UnityEngine.Color> Emission;  // 0x90
        public UnityEngine.Texture2D EmissionMap;  // 0xa8
        public System.Nullable<System.Single> Roughness;  // 0xb0
        public UnityEngine.Texture2D RoughnessMap;  // 0xb8
        public System.Nullable<System.Single> Metallic;  // 0xc0
        public UnityEngine.Texture2D MetallicMap;  // 0xc8
        public System.Nullable<System.Single> Clearcoat;  // 0xd0
        public UnityEngine.Texture2D ClearcoatMap;  // 0xd8
        public System.Nullable<System.Single> ClearcoatRoughness;  // 0xe0
        public System.Nullable<System.Single> OpacityThreshold;  // 0xe8
        public System.Nullable<System.Single> Opacity;  // 0xf0
        public UnityEngine.Texture2D OpacityMap;  // 0xf8

        // Properties
        UnityEngine.Material Material { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        System.Boolean IsSpecularWorkflow { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x60000B6
        public System.Void .ctor(UnityEngine.Material material) { }
        // RVA: -1  // abstract  token: 0x60000B7
        public virtual System.Void ImportFromUsd() { }
        // RVA: 0x09B8D748  token: 0x60000B8
        protected System.Void ImportColorOrMap(USD.NET.Scene scene, USD.NET.Connectable<UnityEngine.Vector3> usdParam, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions options, UnityEngine.Texture2D& map, System.Nullable<UnityEngine.Color>& value, System.String& uvPrimvar) { }
        // RVA: -1  // generic def  token: 0x60000B9
        protected System.Void ImportValueOrMap(USD.NET.Scene scene, USD.NET.Connectable<T> usdParam, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions options, UnityEngine.Texture2D& map, System.Nullable<T>& value, System.String& uvPrimvar) { }
        // RVA: 0x09B8DD28  token: 0x60000BA
        private System.Void MergePrimvars(System.String newPrimvar, System.Collections.Generic.List<System.String> primvars) { }
        // RVA: 0x09B8D8A0  token: 0x60000BB
        public virtual System.Void ImportParametersFromUsd(USD.NET.Scene scene, System.String materialPath, USD.NET.Unity.MaterialSample materialSample, USD.NET.Unity.PreviewSurfaceSample previewSurf, Unity.Formats.USD.SceneImportOptions options) { }

    }

    // TypeToken: 0x2000030  // size: 0x10
    public class StandardShaderExporter : Unity.Formats.USD.ShaderExporterBase
    {
        // Methods
        // RVA: 0x09B8F300  token: 0x60000BE
        public static System.Void ExportStandardSpecular(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath) { }
        // RVA: 0x09B8EEC4  token: 0x60000BF
        public static System.Void ExportStandardRoughness(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath) { }
        // RVA: 0x09B8F5FC  token: 0x60000C0
        public static System.Void ExportStandard(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath) { }
        // RVA: 0x09B8DE30  token: 0x60000C1
        public static System.Void ExportGeneric(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath) { }
        // RVA: 0x09B8E4B0  token: 0x60000C2
        private static System.Void ExportStandardCommon(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material mat, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath) { }
        // RVA: 0x09B8F930  token: 0x60000C3
        private static System.Boolean ShouldUseSpecularWorkflow(UnityEngine.Material material) { }
        // RVA: 0x0350B670  token: 0x60000C4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000032  // size: 0x100
    public class StandardShaderImporter : Unity.Formats.USD.ShaderImporterBase
    {
        // Methods
        // RVA: 0x0426FEE0  token: 0x60000C5
        public System.Void .ctor(UnityEngine.Material material) { }
        // RVA: 0x09B8FA64  token: 0x60000C6
        public virtual System.Void ImportFromUsd() { }

    }

    // TypeToken: 0x2000033  // size: 0x38
    public class UnityMaterialData : USD.NET.SampleBase
    {
        // Fields
        public System.String shaderName;  // 0x10
        public System.String[] shaderKeywords;  // 0x18
        public System.Collections.Generic.Dictionary<System.String,System.Single> floatArgs;  // 0x20
        public System.Collections.Generic.Dictionary<System.String,UnityEngine.Color> colorArgs;  // 0x28
        public System.Collections.Generic.Dictionary<System.String,UnityEngine.Vector4> vectorArgs;  // 0x30

        // Methods
        // RVA: 0x09B971CC  token: 0x60000C7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000034  // size: 0x98
    public class UnityPreviewSurfaceSample : USD.NET.Unity.PreviewSurfaceSample
    {
        // Fields
        public Unity.Formats.USD.UnityMaterialData unity;  // 0x90

        // Methods
        // RVA: 0x09B972D8  token: 0x60000C8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000035  // size: 0x100
    public class UrpShaderImporter : Unity.Formats.USD.ShaderImporterBase
    {
        // Methods
        // RVA: 0x0426FEE0  token: 0x60000C9
        public System.Void .ctor(UnityEngine.Material material) { }
        // RVA: 0x09B9734C  token: 0x60000CA
        public virtual System.Void ImportFromUsd() { }

    }

    // TypeToken: 0x2000036  // size: 0x11
    public sealed struct ReadAllJob`1 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, Unity.Jobs.IJobParallelFor
    {
        // Fields
        private static USD.NET.Scene m_scene;  // static @ 0x0
        private static pxr.SdfPath[] m_paths;  // static @ 0x0
        private static T[] m_results;  // static @ 0x0
        private static System.Object[] m_done;  // static @ 0x0
        private static USD.NET.SampleEnumerator.SampleHolder<T> m_current;  // static @ 0x0
        private static System.Threading.AutoResetEvent m_ready;  // static @ 0x0
        private static Unity.Formats.USD.SceneImportOptions m_importOptions;  // static @ 0x0

        // Properties
        USD.NET.SampleEnumerator.SampleHolder<T> Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60000CD
        public System.Void .ctor(USD.NET.Scene scene, pxr.SdfPath[] paths, Unity.Formats.USD.SceneImportOptions importOptions) { }
        // RVA: -1  // not resolved  token: 0x60000CE
        private System.Boolean ShouldReadPath(USD.NET.Scene scene, pxr.SdfPath path) { }
        // RVA: -1  // not resolved  token: 0x60000CF
        public System.Void Run() { }
        // RVA: -1  // not resolved  token: 0x60000D0
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x60000D1
        private static System.Void AddPrimvarsFromMaterial(System.Int32 index, USD.NET.IArbitraryPrimvars& sample) { }
        // RVA: -1  // not resolved  token: 0x60000D2
        public virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x60000D3
        public virtual System.Void Reset() { }
        // RVA: -1  // not resolved  token: 0x60000D4
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x60000D5
        public virtual System.Collections.Generic.IEnumerator<USD.NET.SampleEnumerator.SampleHolder<T>> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60000D6
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000037
    public interface IRestorable
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60000D7
        public virtual System.Boolean IsRestoredFromCachedData() { }
        // RVA: -1  // abstract  token: 0x60000D8
        public virtual System.Void FromCachedData(USD.NET.IRestorableData data) { }
        // RVA: -1  // abstract  token: 0x60000D9
        public virtual USD.NET.IRestorableData ToCachedData() { }

    }

    // TypeToken: 0x2000038
    public interface ISanitizable
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60000DA
        public virtual System.Void Sanitize(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions) { }

    }

    // TypeToken: 0x2000039  // size: 0x28
    public class MeshStaticPropertiesData : USD.NET.IRestorableData
    {
        // Fields
        private System.Int32[] originalFaceVertexCounts;  // 0x10
        private System.Int32[] originalFaceVertexIndices;  // 0x18
        private System.Boolean arePrimvarsFaceVarying;  // 0x20
        private USD.NET.Orientation orientation;  // 0x24

        // Methods
        // RVA: 0x0350B670  token: 0x60000DB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003A  // size: 0x60
    public class SanitizedXformSample : USD.NET.Unity.XformSample, Unity.Formats.USD.ISanitizable
    {
        // Methods
        // RVA: 0x09B850F0  token: 0x60000DC
        public virtual System.Void Sanitize(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions) { }
        // RVA: 0x09B85118  token: 0x60000DD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003B  // size: 0xA0
    public class SanitizedCameraSample : USD.NET.Unity.CameraSample, Unity.Formats.USD.ISanitizable
    {
        // Methods
        // RVA: 0x09B850F0  token: 0x60000DE
        public virtual System.Void Sanitize(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions) { }
        // RVA: 0x09B85118  token: 0x60000DF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003C  // size: 0xF0
    public class SanitizedMeshSample : USD.NET.Unity.MeshSample, Unity.Formats.USD.ISanitizable, Unity.Formats.USD.IRestorable
    {
        // Fields
        private System.Int32[] originalFaceVertexCounts;  // 0xc0
        private System.Int32[] originalFaceVertexIndices;  // 0xc8
        private System.Boolean arePrimvarsFaceVarying;  // 0xd0
        private System.Int32[] faceMapping;  // 0xd8
        private System.Int32[] triangulatedFaceVertexIndices;  // 0xe0
        private System.Boolean isRestoredFromCachedData;  // 0xe8

        // Methods
        // RVA: 0x03D554A0  token: 0x60000E0
        public virtual System.Boolean IsRestoredFromCachedData() { }
        // RVA: 0x09B858A0  token: 0x60000E1
        public virtual System.Void FromCachedData(USD.NET.IRestorableData restorableData) { }
        // RVA: 0x09B867A8  token: 0x60000E2
        public virtual USD.NET.IRestorableData ToCachedData() { }
        // RVA: 0x09B85294  token: 0x60000E3
        public System.Void BackupTopology() { }
        // RVA: 0x09B85C44  token: 0x60000E4
        public System.Boolean IsTopologyBackedUp() { }
        // RVA: 0x09B85C60  token: 0x60000E5
        public virtual System.Void Sanitize(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions) { }
        // RVA: 0x09B86830  token: 0x60000E6
        private System.Void Triangulate(System.Boolean changeHandedness) { }
        // RVA: 0x09B865CC  token: 0x60000E7
        private System.Boolean ShouldUnweldVertices(System.Boolean bindMaterials) { }
        // RVA: 0x09B85120  token: 0x60000E8
        private System.Boolean AreAnyArbitraryPrimvarsFaceVarying() { }
        // RVA: -1  // generic def  token: 0x60000E9
        private static System.Void Flatten(T[]& values, System.Int32[] indices) { }
        // RVA: 0x09B86C94  token: 0x60000EA
        private System.Void UnweldPrimvar(USD.NET.Primvar<System.Object> primvar, System.Boolean changeHandedness) { }
        // RVA: 0x09B8569C  token: 0x60000EB
        private static System.Void FlattenPrimvar(USD.NET.Primvar<System.Object> primvar) { }
        // RVA: -1  // generic def  token: 0x60000EC
        private static System.Void TriangulateAttributes(T[]& values, System.Int32[] faceVertexCounts, System.Boolean changeHandedness) { }
        // RVA: -1  // generic def  token: 0x60000ED
        private System.Void ConvertInterpolationToFaceVarying(T[]& values, System.Int32[] vertexIndices, System.Boolean changeHandedness, pxr.TfToken interpolation) { }
        // RVA: 0x09B8594C  token: 0x60000EE
        private pxr.TfToken GuessInterpolation(System.Int32 count) { }
        // RVA: 0x09B85AA4  token: 0x60000EF
        private System.Boolean IsInterpolationValid(pxr.TfToken interpolation, System.Int32 count) { }
        // RVA: -1  // generic def  token: 0x60000F0
        private System.Void UniformToFaceVarying(T[]& values, System.Int32 vertexCount) { }
        // RVA: 0x09B8539C  token: 0x60000F1
        private static System.Void ComputeNormals(UnityEngine.Vector3[] points, System.Int32[] faceVertexIndices, UnityEngine.Vector3[]& normals) { }
        // RVA: 0x09B86790  token: 0x60000F2
        private System.Boolean ShouldUnwindVertices(System.Boolean changeHandedness) { }
        // RVA: 0x09B8704C  token: 0x60000F3
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003D  // size: 0x10
    public static class ExportHelpers
    {
        // Methods
        // RVA: 0x09B7F29C  token: 0x60000F4
        public static USD.NET.Scene InitForSave(System.String filePath) { }
        // RVA: 0x09B7F02C  token: 0x60000F5
        public static System.Void ExportGameObjects(UnityEngine.GameObject[] objects, USD.NET.Scene scene, Unity.Formats.USD.BasisTransformation basisTransform, System.Boolean exportMonoBehaviours) { }

    }

    // TypeToken: 0x200003E  // size: 0x10
    public static class HierarchyBuilder
    {
        // Fields
        private static readonly pxr.SdfPath kAbsoluteRootPath;  // static @ 0x0

        // Methods
        // RVA: 0x09B7FA50  token: 0x60000F6
        private static Unity.Jobs.JobHandle BeginReading(USD.NET.Scene scene, pxr.SdfPath usdRoot, Unity.Formats.USD.PrimMap map, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x09B81310  token: 0x60000F7
        private static Unity.Formats.USD.HierarchyBuilder.HierInfo[] BuildObjectLists(USD.NET.Scene scene, UnityEngine.GameObject unityRoot, pxr.SdfPath usdRoot, Unity.Formats.USD.PrimMap map, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x09B80428  token: 0x60000F8
        public static Unity.Formats.USD.PrimMap BuildGameObjects(USD.NET.Scene scene, UnityEngine.GameObject unityRoot, pxr.SdfPath usdRoot, System.Collections.Generic.IEnumerable<pxr.SdfPath> paths, Unity.Formats.USD.PrimMap map, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x09B81DDC  token: 0x60000F9
        private static System.Boolean IsVisible(pxr.UsdPrim usdPrim) { }
        // RVA: 0x09B7F9C0  token: 0x60000FA
        private static System.Void ApplySelfVisibility(UnityEngine.GameObject go, pxr.UsdPrim usdPrim) { }
        // RVA: 0x09B814A4  token: 0x60000FB
        private static System.Void CreateAncestors(pxr.SdfPath path, Unity.Formats.USD.PrimMap map, UnityEngine.GameObject unityRoot, pxr.SdfPath usdRoot, Unity.Formats.USD.SceneImportOptions options, UnityEngine.GameObject& parentGo) { }
        // RVA: 0x09B821A8  token: 0x60000FC
        private static System.Void ProcessPaths(Unity.Formats.USD.HierarchyBuilder.HierInfo[] infos, USD.NET.Scene scene, UnityEngine.GameObject unityRoot, pxr.SdfPath usdRoot, Unity.Formats.USD.PrimMap map, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x09B81F24  token: 0x60000FD
        private static System.Void PopulateSkelCache(Unity.Formats.USD.HierarchyBuilder.HierInfo& skelRootInfo, pxr.UsdSkelCache skelCache) { }
        // RVA: 0x09B82A3C  token: 0x60000FE
        private static System.Void ReadSkeletonJoints(Unity.Formats.USD.HierarchyBuilder.HierInfo& skelRootInfo) { }
        // RVA: 0x09B817F0  token: 0x60000FF
        private static System.Void ExpandSkeleton(Unity.Formats.USD.HierarchyBuilder.HierInfo info, UnityEngine.GameObject unityRoot, pxr.SdfPath usdRoot, pxr.UsdPrim prim, Unity.Formats.USD.PrimMap map, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x09B82744  token: 0x6000100
        private static System.Void ReadModelInfo(Unity.Formats.USD.HierarchyBuilder.HierInfo& info) { }
        // RVA: 0x09B7F588  token: 0x6000101
        private static System.Void AddModelRoot(UnityEngine.GameObject go, Unity.Formats.USD.HierarchyBuilder.HierInfo info) { }
        // RVA: 0x09B7F798  token: 0x6000102
        private static System.Void AddPayload(UnityEngine.GameObject go, Unity.Formats.USD.HierarchyBuilder.HierInfo info, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x09B7F890  token: 0x6000103
        private static System.Void AddVariantSet(UnityEngine.GameObject go, pxr.UsdPrim prim) { }
        // RVA: 0x09B81B3C  token: 0x6000104
        private static UnityEngine.GameObject FindOrCreateGameObject(UnityEngine.Transform parent, pxr.SdfPath path, UnityEngine.Transform unityRoot, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x09B8305C  token: 0x6000105
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000045  // size: 0x10
    public static class ImportHelpers
    {
        // Methods
        // RVA: 0x09B83384  token: 0x6000110
        public static UnityEngine.GameObject ImportSceneAsGameObject(USD.NET.Scene scene, UnityEngine.GameObject parent, Unity.Formats.USD.SceneImportOptions importOptions) { }
        // RVA: 0x09B835EC  token: 0x6000111
        public static USD.NET.Scene InitForOpen(System.String path, pxr.UsdStage.InitialLoadSet loadSet) { }
        // RVA: 0x09B831B4  token: 0x6000112
        private static pxr.SdfPath GetDefaultRoot(USD.NET.Scene scene) { }
        // RVA: 0x09B83660  token: 0x6000113
        private static UnityEngine.GameObject UsdToGameObject(UnityEngine.GameObject parent, USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions) { }
        // RVA: 0x09B83268  token: 0x6000114
        private static System.String GetObjectName(pxr.SdfPath rootPrimName, System.String path) { }
        // RVA: 0x09B832F0  token: 0x6000115
        private static System.String GetObjectName(System.String path) { }
        // RVA: 0x09B8333C  token: 0x6000116
        private static System.String GetPrefabName(System.String path) { }

    }

    // TypeToken: 0x2000046
    public interface IImportProcessUsd
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000117
        public virtual System.Void ProcessUsd(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions sceneImportOptions) { }

    }

    // TypeToken: 0x2000047
    public interface IImportPostProcessHierarchy
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000118
        public virtual System.Void PostProcessHierarchy(Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions sceneImportOptions) { }

    }

    // TypeToken: 0x2000048
    public interface IImportPostProcessComponents
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000119
        public virtual System.Void PostProcessComponents(Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions sceneImportOptions) { }

    }

    // TypeToken: 0x2000049  // size: 0x98
    public class PrimMap : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        public pxr.UsdSkelCache SkelCache;  // 0x10
        public System.Collections.Generic.Dictionary<pxr.SdfPath,pxr.UsdSkelBindingVector> SkelBindings;  // 0x18
        public System.Collections.Generic.Dictionary<pxr.SdfPath,pxr.UsdSkelSkinningQuery> SkinningQueries;  // 0x20
        public System.Collections.Generic.Dictionary<pxr.SdfPath,Unity.Formats.USD.MeshImporter.GeometrySubsets> MeshSubsets;  // 0x28
        private pxr.SdfPath[] <Cameras>k__BackingField;  // 0x30
        private pxr.SdfPath[] <Meshes>k__BackingField;  // 0x38
        private pxr.SdfPath[] <Cubes>k__BackingField;  // 0x40
        private pxr.SdfPath[] <Spheres>k__BackingField;  // 0x48
        private pxr.SdfPath[] <Xforms>k__BackingField;  // 0x50
        private pxr.SdfPath[] <SkelRoots>k__BackingField;  // 0x58
        private pxr.SdfPath[] <Skeletons>k__BackingField;  // 0x60
        private pxr.SdfPath[] <Materials>k__BackingField;  // 0x68
        private System.Boolean <ContainsPointInstances>k__BackingField;  // 0x70
        private System.Boolean <HasErrors>k__BackingField;  // 0x71
        private System.Collections.Generic.Dictionary<pxr.SdfPath,UnityEngine.GameObject> m_prims;  // 0x78
        private System.Collections.Generic.Dictionary<pxr.SdfPath,Unity.Formats.USD.PrimMap.InstanceRoot> m_instanceRoots;  // 0x80
        private System.Collections.Generic.HashSet<UnityEngine.GameObject> m_instances;  // 0x88
        private System.Collections.Generic.Dictionary<pxr.SdfPath,UnityEngine.GameObject> m_masterRoots;  // 0x90

        // Properties
        pxr.SdfPath[] Cameras { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }
        pxr.SdfPath[] Meshes { get; /* RVA: 0x03D4E2A0 */ set; /* RVA: 0x0388FF30 */ }
        pxr.SdfPath[] Cubes { get; /* RVA: 0x03D4E2B0 */ set; /* RVA: 0x03CB2D80 */ }
        pxr.SdfPath[] Spheres { get; /* RVA: 0x03D4EA70 */ set; /* RVA: 0x02692290 */ }
        pxr.SdfPath[] Xforms { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x02C926C0 */ }
        pxr.SdfPath[] SkelRoots { get; /* RVA: 0x03D4EAA0 */ set; /* RVA: 0x03081D30 */ }
        pxr.SdfPath[] Skeletons { get; /* RVA: 0x03D4EB00 */ set; /* RVA: 0x039274B0 */ }
        pxr.SdfPath[] Materials { get; /* RVA: 0x03D4EAB0 */ set; /* RVA: 0x038C5570 */ }
        System.Boolean ContainsPointInstances { get; /* RVA: 0x03D4F260 */ set; /* RVA: 0x03D4F290 */ }
        System.Boolean HasErrors { get; /* RVA: 0x03D51CF0 */ set; /* RVA: 0x03D51D00 */ }
        UnityEngine.GameObject Item { get; /* RVA: 0x09B84D48 */ set; /* RVA: 0x09B84E34 */ }

        // Methods
        // RVA: 0x09B84B5C  token: 0x600012E
        public System.Void .ctor() { }
        // RVA: 0x09B84AF8  token: 0x6000131
        public System.Boolean TryGetValue(pxr.SdfPath key, UnityEngine.GameObject& obj) { }
        // RVA: 0x09B84958  token: 0x6000132
        public virtual System.Collections.IEnumerator GetEnumerator() { }
        // RVA: 0x09B84A70  token: 0x6000133
        private virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<pxr.SdfPath,UnityEngine.GameObject>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<pxr.SdfPath,UnityEngine.GameObject>>.GetEnumerator() { }
        // RVA: 0x09B84284  token: 0x6000134
        public System.Void AddInstance(UnityEngine.GameObject goInst) { }
        // RVA: 0x09B842DC  token: 0x6000135
        public System.Void AddMasterRoot(pxr.SdfPath path, UnityEngine.GameObject go) { }
        // RVA: 0x09B841D8  token: 0x6000136
        public System.Void AddInstanceRoot(pxr.SdfPath instancePath, UnityEngine.GameObject go, pxr.SdfPath masterPath) { }
        // RVA: 0x09B84A28  token: 0x6000137
        public System.Collections.Generic.Dictionary.KeyCollection<pxr.SdfPath,UnityEngine.GameObject> GetMasterRootPaths() { }
        // RVA: 0x09B849E0  token: 0x6000138
        public System.Collections.Generic.Dictionary.ValueCollection<pxr.SdfPath,Unity.Formats.USD.PrimMap.InstanceRoot> GetInstanceRoots() { }
        // RVA: 0x09B84480  token: 0x6000139
        public System.Void DestroyAll() { }
        // RVA: 0x09B84354  token: 0x600013A
        public System.Void Clear() { }

    }

    // TypeToken: 0x200004B  // size: 0x80
    public sealed class ExportFunction : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x09B7EF64  token: 0x600013B
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x069DD2E4  token: 0x600013C
        public virtual System.Void Invoke(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }
        // RVA: 0x09B7EEDC  token: 0x600013D
        public virtual System.IAsyncResult BeginInvoke(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x600013E
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200004C  // size: 0x80
    public sealed class ObjectProcessor : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x0951C0FC  token: 0x600013F
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02065C10  token: 0x6000140
        public virtual System.Void Invoke(UnityEngine.GameObject go, Unity.Formats.USD.ExportContext context) { }
        // RVA: 0x04CB7664  token: 0x6000141
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.GameObject go, Unity.Formats.USD.ExportContext context, System.AsyncCallback callback, System.Object object) { }
        // RVA: 0x042BD330  token: 0x6000142
        public virtual System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200004D  // size: 0x30
    public sealed struct ObjectContext
    {
        // Fields
        public UnityEngine.GameObject gameObject;  // 0x10
        public System.String path;  // 0x18
        public USD.NET.SampleBase sample;  // 0x20
        public System.Object additionalData;  // 0x28

    }

    // TypeToken: 0x200004E  // size: 0x14
    public sealed struct ActiveExportPolicy
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Unity.Formats.USD.ActiveExportPolicy ExportAsVisibility;  // const
        public static Unity.Formats.USD.ActiveExportPolicy ExportAsActive;  // const
        public static Unity.Formats.USD.ActiveExportPolicy DoNotExport;  // const
        public static Unity.Formats.USD.ActiveExportPolicy Ignore;  // const

    }

    // TypeToken: 0x200004F  // size: 0x88
    public class ExportContext
    {
        // Fields
        public USD.NET.Scene scene;  // 0x10
        public UnityEngine.Transform exportRoot;  // 0x18
        public System.Boolean exportMaterials;  // 0x20
        public System.Boolean exportNative;  // 0x21
        public System.Single scale;  // 0x24
        public System.Boolean exportTransformOverrides;  // 0x28
        public Unity.Formats.USD.BasisTransformation basisTransform;  // 0x2c
        public Unity.Formats.USD.ActiveExportPolicy activePolicy;  // 0x30
        public System.Collections.Generic.Dictionary<UnityEngine.GameObject,Unity.Formats.USD.ExportPlan> plans;  // 0x38
        public System.Collections.Generic.Dictionary<UnityEngine.Material,System.String> matMap;  // 0x40
        public System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform> meshToSkelRoot;  // 0x48
        public System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform[]> meshToBones;  // 0x50
        public System.Collections.Generic.Dictionary<UnityEngine.Transform,System.Collections.Generic.List<System.String>> skelSortedMap;  // 0x58
        public System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> pathToBone;  // 0x60
        public System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform> boneToRoot;  // 0x68
        public System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Matrix4x4> bindPoses;  // 0x70
        public System.Collections.Generic.Dictionary<System.Type,USD.NET.SampleBase> samples;  // 0x78
        public System.Diagnostics.Stopwatch analyticsTotalTimeStopwatch;  // 0x80

        // Methods
        // RVA: 0x09B7EBE4  token: 0x6000143
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000050  // size: 0x30
    public class Exporter
    {
        // Fields
        public System.String path;  // 0x10
        public USD.NET.SampleBase sample;  // 0x18
        public Unity.Formats.USD.ExportFunction exportFunc;  // 0x20
        public System.Object data;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x6000144
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000051  // size: 0x18
    public class ExportPlan
    {
        // Fields
        public System.Collections.Generic.List<Unity.Formats.USD.Exporter> exporters;  // 0x10

        // Methods
        // RVA: 0x09B7F3F4  token: 0x6000145
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000052  // size: 0x10
    public static class SceneExporter
    {
        // Methods
        // RVA: 0x09B88A60  token: 0x6000146
        public static System.Void Export(UnityEngine.GameObject root, USD.NET.Scene scene, Unity.Formats.USD.BasisTransformation basisTransform, System.Boolean exportUnvarying, System.Boolean zeroRootTransform, System.Boolean exportMaterials, System.Boolean exportMonoBehaviours, System.Boolean exportOverrides) { }
        // RVA: 0x09B884CC  token: 0x6000147
        public static System.Void Export(UnityEngine.GameObject root, Unity.Formats.USD.ExportContext context, System.Boolean zeroRootTransform) { }
        // RVA: 0x09B87794  token: 0x6000148
        private static System.Void ExportImpl(UnityEngine.GameObject root, Unity.Formats.USD.ExportContext context) { }
        // RVA: 0x09B8B63C  token: 0x6000149
        private static System.Void Traverse(UnityEngine.GameObject obj, Unity.Formats.USD.ObjectProcessor processor, Unity.Formats.USD.ExportContext context) { }
        // RVA: 0x09B87054  token: 0x600014A
        private static System.Void AccumNestedBones(UnityEngine.Transform curXf, System.Collections.Generic.List<UnityEngine.Transform> children, Unity.Formats.USD.ExportContext ctx) { }
        // RVA: -1  // generic def  token: 0x600014B
        private static T CreateSample(Unity.Formats.USD.ExportContext context) { }
        // RVA: 0x09B8A40C  token: 0x600014C
        public static System.Void SyncExportContext(UnityEngine.GameObject exportRoot, Unity.Formats.USD.ExportContext context) { }
        // RVA: 0x09B88BD0  token: 0x600014D
        private static System.Void InitExportableObjects(UnityEngine.GameObject go, Unity.Formats.USD.ExportContext context) { }
        // RVA: 0x09B895F8  token: 0x600014E
        private static UnityEngine.Transform MergeBonesBelowAnimator(UnityEngine.Transform animator, Unity.Formats.USD.ExportContext context) { }
        // RVA: 0x09B89FBC  token: 0x600014F
        private static System.Void MergeBonesSimple(UnityEngine.Transform source, UnityEngine.Transform rootBone, UnityEngine.Transform[] bones, UnityEngine.Matrix4x4[] bindPoses, Unity.Formats.USD.ExportContext context) { }
        // RVA: 0x09B873C4  token: 0x6000150
        private static System.Void CreateExportPlan(UnityEngine.GameObject go, USD.NET.SampleBase sample, Unity.Formats.USD.ExportFunction exportFunc, Unity.Formats.USD.ExportContext context, System.String pathSuffix, System.Boolean insertFirst) { }
        // RVA: 0x09B8724C  token: 0x6000151
        private static UnityEngine.Matrix4x4 ComputeWorldXf(UnityEngine.Transform curBone, Unity.Formats.USD.ExportContext context) { }

    }

    // TypeToken: 0x2000054
    public interface IImporter
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000156
        public virtual System.Void BeginReading(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions) { }
        // RVA: -1  // abstract  token: 0x6000157
        public virtual System.Collections.IEnumerator Import(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions) { }

    }

    // TypeToken: 0x2000055  // size: 0x10
    public static class SceneImporter
    {
        // Fields
        public static Unity.Formats.USD.IImporter ActiveMeshImporter;  // static @ 0x0

        // Methods
        // RVA: 0x09B8BE40  token: 0x6000158
        private static System.Void .cctor() { }
        // RVA: 0x09B8BA60  token: 0x6000159
        public static System.Void ImportUsd(UnityEngine.GameObject goRoot, USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions) { }
        // RVA: 0x09B8BADC  token: 0x600015A
        public static System.Void ImportUsd(UnityEngine.GameObject goRoot, USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, System.Boolean composingSubtree, Unity.Formats.USD.SceneImportOptions importOptions) { }
        // RVA: 0x09B8B9E8  token: 0x600015B
        private static Unity.Formats.USD.UsdEditorAnalytics.ImportResult CreateImportResult(System.Boolean success, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.ImportType importType) { }
        // RVA: 0x09B8B810  token: 0x600015C
        public static Unity.Formats.USD.PrimMap BuildScene(USD.NET.Scene scene, UnityEngine.GameObject root, Unity.Formats.USD.SceneImportOptions importOptions, Unity.Formats.USD.PrimMap primMap, System.Boolean composingSubtree) { }
        // RVA: -1  // generic def  token: 0x600015D
        private static System.Void RemoveComponent(UnityEngine.GameObject go) { }
        // RVA: 0x09B8B92C  token: 0x600015E
        public static System.Collections.IEnumerator BuildScene(USD.NET.Scene scene, UnityEngine.GameObject root, Unity.Formats.USD.SceneImportOptions importOptions, Unity.Formats.USD.PrimMap primMap, System.Single targetFrameMilliseconds, System.Boolean composingSubtree) { }
        // RVA: 0x09B8BE04  token: 0x600015F
        private static System.Boolean ShouldYield(System.Single targetTime, System.Diagnostics.Stopwatch timer) { }
        // RVA: 0x09B8BDCC  token: 0x6000160
        private static System.Void ResetTimer(System.Diagnostics.Stopwatch timer) { }
        // RVA: 0x09B8BD10  token: 0x6000161
        private static System.Boolean IsSkinnedMesh(pxr.UsdPrim prim, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions) { }

    }

    // TypeToken: 0x2000058  // size: 0x14
    public sealed struct PayloadPolicy
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Unity.Formats.USD.PayloadPolicy DontLoadPayloads;  // const
        public static Unity.Formats.USD.PayloadPolicy LoadAll;  // const

    }

    // TypeToken: 0x2000059  // size: 0x14
    public sealed struct BasisTransformation
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Unity.Formats.USD.BasisTransformation FastWithNegativeScale;  // const
        public static Unity.Formats.USD.BasisTransformation SlowAndSafe;  // const
        public static Unity.Formats.USD.BasisTransformation SlowAndSafeAsFBX;  // const
        public static Unity.Formats.USD.BasisTransformation None;  // const

    }

    // TypeToken: 0x200005A  // size: 0x14
    public sealed struct MaterialImportMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static Unity.Formats.USD.MaterialImportMode ImportPreviewSurface;  // const
        public static Unity.Formats.USD.MaterialImportMode ImportDisplayColor;  // const
        public static Unity.Formats.USD.MaterialImportMode None;  // const

    }

    // TypeToken: 0x200005B  // size: 0x60
    public class SceneImportOptions
    {
        // Fields
        public System.String projectAssetPath;  // 0x10
        public pxr.SdfPath usdRootPath;  // 0x18
        public System.Boolean forceRebuild;  // 0x20
        public Unity.Formats.USD.PayloadPolicy payloadPolicy;  // 0x24
        public System.Boolean importHierarchy;  // 0x28
        public System.Boolean importCameras;  // 0x29
        public System.Boolean importMeshes;  // 0x2a
        public System.Boolean importSkinning;  // 0x2b
        public System.Boolean importSkinWeights;  // 0x2c
        public System.Boolean importTransforms;  // 0x2d
        public System.Boolean importSceneInstances;  // 0x2e
        public System.Boolean importPointInstances;  // 0x2f
        public System.Boolean importMonoBehaviours;  // 0x30
        public Unity.Formats.USD.BasisTransformation changeHandedness;  // 0x34
        public System.Single scale;  // 0x38
        public System.Boolean interpolate;  // 0x3c
        public System.Boolean enableGpuInstancing;  // 0x3d
        public System.Boolean useDisplayColorAsFallbackMaterial;  // 0x3e
        public Unity.Formats.USD.MaterialImportMode materialImportMode;  // 0x40
        public Unity.Formats.USD.MaterialMap materialMap;  // 0x48
        public Unity.Formats.USD.MeshImportOptions meshOptions;  // 0x50
        private Unity.Formats.USD.ImportType <ImportType>k__BackingField;  // 0x58

        // Properties
        System.Boolean ShouldBindMaterials { get; /* RVA: 0x056A4630 */ }
        Unity.Formats.USD.ImportType ImportType { get; /* RVA: 0x03D4EF00 */ set; /* RVA: 0x03D4EF50 */ }

        // Methods
        // RVA: 0x09B97AC0  token: 0x6000178
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005C  // size: 0x10
    public class UsdzExporter
    {
        // Methods
        // RVA: 0x09B9CD64  token: 0x6000179
        public static System.Void ExportUsdz(System.String usdzFilePath, UnityEngine.GameObject root) { }
        // RVA: 0x0350B670  token: 0x600017A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005D  // size: 0x10
    public static class SkeletonExporter
    {
        // Methods
        // RVA: 0x09B98944  token: 0x600017B
        public static System.Void ExportSkeleton(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }
        // RVA: 0x09B984A4  token: 0x600017C
        public static System.Void ExportSkelRoot(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }
        // RVA: 0x09B97DAC  token: 0x600017D
        public static System.Void ExportSkelAnimation(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }

    }

    // TypeToken: 0x200005E  // size: 0x10
    public static class SkeletonImporter
    {
        // Methods
        // RVA: 0x09B99C44  token: 0x600017E
        public static System.Void BuildSkeletonBone(System.String skelPath, UnityEngine.GameObject go, UnityEngine.Matrix4x4 restXform, pxr.VtTokenArray joints, Unity.Formats.USD.SceneImportOptions importOptions) { }
        // RVA: 0x09B993A4  token: 0x600017F
        public static System.Void BuildDebugBindTransforms(Unity.Formats.USD.SkeletonSample skelSample, UnityEngine.GameObject goSkeleton, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x09B99298  token: 0x6000180
        public static System.Void BuildBindTransforms(System.String path, Unity.Formats.USD.SkeletonSample skelSample, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x09B9A918  token: 0x6000181
        private static System.Boolean JointsMatch(System.String[] lhs, System.String[] rhs) { }
        // RVA: 0x09B9A0B4  token: 0x6000182
        public static System.Void BuildSkinnedMesh(System.String meshPath, System.String skelPath, Unity.Formats.USD.SkeletonSample skeleton, pxr.UsdSkelSkinningQuery skinningQuery, UnityEngine.GameObject go, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions options) { }

    }

    // TypeToken: 0x200005F  // size: 0x20
    public class UnitySkeleton
    {
        // Fields
        public UnityEngine.Transform rootBone;  // 0x10
        public UnityEngine.Transform[] bones;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000183
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000060  // size: 0x50
    public class SkelBindingSample : USD.NET.SampleBase
    {
        // Fields
        public System.String[] blendShapes;  // 0x10
        public USD.NET.Relationship blendShapeTargets;  // 0x18
        public USD.NET.Relationship animationSource;  // 0x20
        public USD.NET.Relationship skeleton;  // 0x28
        public System.String[] joints;  // 0x30
        public USD.NET.Primvar<System.Int32[]> jointIndices;  // 0x38
        public USD.NET.Primvar<UnityEngine.Matrix4x4> geomBindTransform;  // 0x40
        public USD.NET.Primvar<System.Single[]> jointWeights;  // 0x48

        // Methods
        // RVA: 0x09B97BE0  token: 0x6000184
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000061  // size: 0x88
    public class SkelRootSample : USD.NET.Unity.BoundableSample
    {
        // Fields
        public USD.NET.Relationship skeleton;  // 0x78
        public USD.NET.Relationship animationSource;  // 0x80

        // Methods
        // RVA: 0x09B97D30  token: 0x6000185
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000062  // size: 0x78
    public class SkeletonSample : USD.NET.Unity.XformableSample
    {
        // Fields
        public System.String[] joints;  // 0x60
        public UnityEngine.Matrix4x4[] bindTransforms;  // 0x68
        public UnityEngine.Matrix4x4[] restTransforms;  // 0x70

        // Methods
        // RVA: 0x09B85118  token: 0x6000186
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000063  // size: 0x40
    public class SkelAnimationSample : USD.NET.SampleBase
    {
        // Fields
        public System.String[] joints;  // 0x10
        public UnityEngine.Vector3[] translations;  // 0x18
        public UnityEngine.Quaternion[] rotations;  // 0x20
        public pxr.VtVec3hArray scales;  // 0x28
        public System.String[] blendShapes;  // 0x30
        public System.Single[] blendShapeWeights;  // 0x38

        // Methods
        // RVA: 0x0350B670  token: 0x6000187
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000064  // size: 0x20
    public class BlendShapeSample : USD.NET.SampleBase
    {
        // Fields
        public UnityEngine.Vector3[] offsets;  // 0x10
        public System.UInt32[] pointIndices;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000188
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000065  // size: 0x18
    public class SkeletonIo
    {
        // Fields
        private System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform[]> m_bindings;  // 0x10

        // Methods
        // RVA: 0x09B9A994  token: 0x6000189
        public UnityEngine.Transform[] GetBones(UnityEngine.Transform rootBone) { }
        // RVA: 0x09B9A9E8  token: 0x600018A
        public System.Void RegisterSkeleton(UnityEngine.Transform rootBone, UnityEngine.Transform[] bones) { }
        // RVA: 0x09B9AA4C  token: 0x600018B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000066  // size: 0x10
    public class NativeExporter
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600018C
        public static System.Void ExportObject(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }
        // RVA: 0x0350B670  token: 0x600018D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000067  // size: 0x10
    public class NativeImporter
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600018E
        public static System.Void ImportObject(USD.NET.Scene scene, UnityEngine.GameObject go, pxr.UsdPrim usdPrim, Unity.Formats.USD.SceneImportOptions options) { }
        // RVA: 0x0350B670  token: 0x600018F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000068  // size: 0x30
    public class UsdPlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
    {
        // Fields
        private Unity.Formats.USD.UsdAsset m_sourceUsdAsset;  // 0x18
        public UnityEngine.ExposedReference<Unity.Formats.USD.UsdAsset> SourceUsdAsset;  // 0x20

        // Properties
        UnityEngine.Timeline.ClipCaps clipCaps { get; /* RVA: 0x03D55AE0 */ }
        System.Double duration { get; /* RVA: 0x09B9AFF4 */ }

        // Methods
        // RVA: 0x09B9AFC8  token: 0x6000191
        public Unity.Formats.USD.UsdAsset GetUsdAsset(System.String usdRootPath) { }
        // RVA: 0x09B9ADFC  token: 0x6000192
        public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        // RVA: 0x0286F540  token: 0x6000194
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000069  // size: 0x20
    public class UsdPlayableBehaviour : UnityEngine.Playables.PlayableBehaviour
    {
        // Fields
        public Unity.Formats.USD.UsdPlayableAsset playableAsset;  // 0x10
        private System.Boolean m_errorOnce;  // 0x18

        // Methods
        // RVA: 0x09B9B14C  token: 0x6000195
        public virtual System.Void OnGraphStart(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x0350B670  token: 0x6000196
        public virtual System.Void OnGraphStop(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x0350B670  token: 0x6000197
        public virtual System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x0350B670  token: 0x6000198
        public virtual System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x0350B670  token: 0x6000199
        public virtual System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09B9B154  token: 0x600019A
        public virtual System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        // RVA: 0x0350B670  token: 0x600019B
        public virtual System.Void PrepareData(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x03D587A0  token: 0x600019C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006A  // size: 0xC0
    public class UsdPlayableTrack : UnityEngine.Timeline.TrackAsset
    {
        // Methods
        // RVA: 0x09B9B2D4  token: 0x600019D
        protected virtual System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip) { }
        // RVA: 0x09B9B310  token: 0x600019E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006B  // size: 0x50
    public class UsdRecorderBehaviour : UnityEngine.Playables.PlayableBehaviour
    {
        // Fields
        private static System.Int32 kExportFrameRate;  // const
        private System.Boolean m_isPaused;  // 0x10
        public Unity.Formats.USD.UsdRecorderClip Clip;  // 0x18
        private System.String usdcFileName;  // 0x20
        private System.String usdzFileName;  // 0x28
        private System.String usdzFilePath;  // 0x30
        private System.String currentDir;  // 0x38
        private System.IO.DirectoryInfo usdzTemporaryDir;  // 0x40
        private UnityEngine.GameObject _root;  // 0x48

        // Methods
        // RVA: 0x09B9B35C  token: 0x600019F
        public System.Void BeginRecording(System.Double currentTime, UnityEngine.GameObject root) { }
        // RVA: 0x09B9C410  token: 0x60001A0
        public System.Void StopRecording(System.Double currentTime) { }
        // RVA: 0x09B9C28C  token: 0x60001A1
        private System.Void ProcessRecording(System.Double currentTime, UnityEngine.GameObject root) { }
        // RVA: 0x0232EB60  token: 0x60001A2
        private System.Boolean IsPlaying() { }
        // RVA: 0x0350B670  token: 0x60001A3
        public virtual System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x09B9C118  token: 0x60001A4
        public virtual System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x09B9BFF8  token: 0x60001A5
        public virtual System.Void OnGraphStart(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x09B9C0C0  token: 0x60001A6
        public virtual System.Void OnGraphStop(UnityEngine.Playables.Playable playable) { }
        // RVA: 0x09B9C170  token: 0x60001A7
        public virtual System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        // RVA: 0x03D557C0  token: 0x60001A8
        public virtual System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x01168960  token: 0x60001A9
        public virtual System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        // RVA: 0x09B9BF10  token: 0x60001AA
        public System.Void OnFrameEnd(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        // RVA: 0x0350B670  token: 0x60001AB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006D  // size: 0x58
    public class UsdRecorderClip : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
    {
        // Fields
        public UnityEngine.ExposedReference<UnityEngine.GameObject> m_exportRoot;  // 0x18
        private UnityEngine.GameObject[] m_trackedRoots;  // 0x28
        public System.Boolean m_exportMaterials;  // 0x30
        public Unity.Formats.USD.BasisTransformation m_convertHandedness;  // 0x34
        public Unity.Formats.USD.ActiveExportPolicy m_activePolicy;  // 0x38
        public System.String m_usdFile;  // 0x40
        private USD.NET.Scene <UsdScene>k__BackingField;  // 0x48
        private Unity.Formats.USD.ExportContext m_context;  // 0x50

        // Properties
        USD.NET.Scene UsdScene { get; /* RVA: 0x03D4EA70 */ set; /* RVA: 0x02692290 */ }
        Unity.Formats.USD.ExportContext Context { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x02C926C0 */ }
        UnityEngine.Timeline.ClipCaps clipCaps { get; /* RVA: 0x01002730 */ }
        System.Boolean IsUSDZ { get; /* RVA: 0x09B9C9DC */ }

        // Methods
        // RVA: 0x09B9C8EC  token: 0x60001B2
        public UnityEngine.GameObject GetExportRoot(UnityEngine.Playables.PlayableGraph graph) { }
        // RVA: 0x09B9C7F4  token: 0x60001B5
        public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        // RVA: 0x0350B670  token: 0x60001B6
        public virtual System.Void OnDestroy() { }
        // RVA: 0x09B9C940  token: 0x60001B7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006E  // size: 0xC0
    public class UsdRecorderTrack : UnityEngine.Timeline.TrackAsset
    {
        // Methods
        // RVA: 0x09B9CA48  token: 0x60001B8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006F  // size: 0x20
    public class UsdWaitForEndOfFrame : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<System.Action> m_pending;  // 0x18
        private static Unity.Formats.USD.UsdWaitForEndOfFrame s_instance;  // static @ 0x0

        // Methods
        // RVA: 0x09B9CAE8  token: 0x60001B9
        private static Unity.Formats.USD.UsdWaitForEndOfFrame GetInstance() { }
        // RVA: 0x09B9CA94  token: 0x60001BA
        public static System.Void Add(System.Action callback) { }
        // RVA: 0x09B9CC88  token: 0x60001BB
        private System.Collections.IEnumerator WaitForEndOfFrame() { }
        // RVA: 0x09B9CC64  token: 0x60001BC
        private System.Void LateUpdate() { }
        // RVA: 0x09B9CCE4  token: 0x60001BD
        public System.Void .ctor() { }

    }

}

