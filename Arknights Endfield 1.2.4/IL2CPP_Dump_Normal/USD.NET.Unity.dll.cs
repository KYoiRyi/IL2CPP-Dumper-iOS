// ========================================================
// Dumped by @desirepro
// Assembly: USD.NET.Unity.dll
// Classes:  52
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000004  // size: 0x14
    public sealed struct CurveType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static USD.NET.Unity.BasisCurvesSample.CurveType Linear;  // const
        public static USD.NET.Unity.BasisCurvesSample.CurveType Cubic;  // const

    }

    // TypeToken: 0x2000005  // size: 0x14
    public sealed struct Basis
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static USD.NET.Unity.BasisCurvesSample.Basis Bezier;  // const
        public static USD.NET.Unity.BasisCurvesSample.Basis Bspline;  // const
        public static USD.NET.Unity.BasisCurvesSample.Basis CatmullRom;  // const
        public static USD.NET.Unity.BasisCurvesSample.Basis Hermite;  // const
        public static USD.NET.Unity.BasisCurvesSample.Basis Power;  // const

    }

    // TypeToken: 0x2000006  // size: 0x14
    public sealed struct WrapMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static USD.NET.Unity.BasisCurvesSample.WrapMode Nonperiodic;  // const
        public static USD.NET.Unity.BasisCurvesSample.WrapMode Periodic;  // const

    }

    // TypeToken: 0x2000009  // size: 0x14
    public sealed struct ProjectionType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static USD.NET.Unity.CameraSample.ProjectionType Perspective;  // const
        public static USD.NET.Unity.CameraSample.ProjectionType Orthographic;  // const

    }

    // TypeToken: 0x200000A  // size: 0x14
    public sealed struct StereoRole
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static USD.NET.Unity.CameraSample.StereoRole Mono;  // const
        public static USD.NET.Unity.CameraSample.StereoRole Left;  // const
        public static USD.NET.Unity.CameraSample.StereoRole Right;  // const

    }

    // TypeToken: 0x200000B  // size: 0x20
    public class Shutter : USD.NET.SampleBase
    {
        // Fields
        public System.Double open;  // 0x10
        public System.Double close;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600000C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000020  // size: 0x20
    public sealed class <>c__DisplayClass3_0
    {
        // Fields
        public System.Type inputParamType;  // 0x10
        public System.Func<System.Reflection.FieldInfo,System.Boolean> <>9__0;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000042
        public System.Void .ctor() { }
        // RVA: 0x09FD711C  token: 0x6000043
        private System.Boolean <GetInputParameters>b__0(System.Reflection.FieldInfo info) { }

    }

    // TypeToken: 0x2000021  // size: 0x60
    public sealed class <GetInputParameters>d__3 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private USD.NET.Unity.ParameterInfo <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x40
        public USD.NET.Unity.ShaderSample <>4__this;  // 0x48
        private USD.NET.Unity.ShaderSample.<>c__DisplayClass3_0 <>8__1;  // 0x50
        private System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo> <>7__wrap1;  // 0x58

        // Properties
        USD.NET.Unity.ParameterInfo System.Collections.Generic.IEnumerator<USD.NET.Unity.ParameterInfo>.Current { get; /* RVA: 0x03D5CA30 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x09FD5B04 */ }

        // Methods
        // RVA: 0x09FD5C20  token: 0x6000044
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x09FD5B60  token: 0x6000045
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09FD52A8  token: 0x6000046
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09FD5BD8  token: 0x6000047
        private System.Void <>m__Finally1() { }
        // RVA: 0x09FD5AB8  token: 0x6000049
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x09FD5A24  token: 0x600004B
        private virtual System.Collections.Generic.IEnumerator<USD.NET.Unity.ParameterInfo> System.Collections.Generic.IEnumerable<USD.NET.Unity.ParameterInfo>.GetEnumerator() { }
        // RVA: 0x09FD5AB0  token: 0x600004C
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000022  // size: 0x20
    public sealed class <>c__DisplayClass4_0
    {
        // Fields
        public System.Type inputParamType;  // 0x10
        public System.Func<System.Reflection.FieldInfo,System.Boolean> <>9__0;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600004D
        public System.Void .ctor() { }
        // RVA: 0x09FD711C  token: 0x600004E
        private System.Boolean <GetInputTextures>b__0(System.Reflection.FieldInfo info) { }

    }

    // TypeToken: 0x2000023  // size: 0x68
    public sealed class <GetInputTextures>d__4 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private USD.NET.Unity.ParameterInfo <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x40
        public USD.NET.Unity.ShaderSample <>4__this;  // 0x48
        private USD.NET.Unity.ShaderSample.<>c__DisplayClass4_0 <>8__1;  // 0x50
        private System.Type <requireKeywordType>5__2;  // 0x58
        private System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo> <>7__wrap2;  // 0x60

        // Properties
        USD.NET.Unity.ParameterInfo System.Collections.Generic.IEnumerator<USD.NET.Unity.ParameterInfo>.Current { get; /* RVA: 0x03D5CA30 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x09FD663C */ }

        // Methods
        // RVA: 0x09FD5C20  token: 0x600004F
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x09FD6698  token: 0x6000050
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09FD5C3C  token: 0x6000051
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09FD6710  token: 0x6000052
        private System.Void <>m__Finally1() { }
        // RVA: 0x09FD65F0  token: 0x6000054
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x09FD655C  token: 0x6000056
        private virtual System.Collections.Generic.IEnumerator<USD.NET.Unity.ParameterInfo> System.Collections.Generic.IEnumerable<USD.NET.Unity.ParameterInfo>.GetEnumerator() { }
        // RVA: 0x09FD65E8  token: 0x6000057
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000027  // size: 0x20
    public class Outputs : USD.NET.SampleBase
    {
        // Fields
        public pxr.TfToken displacement;  // 0x10
        public pxr.TfToken surface;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600005B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000029
    public class Outputs : USD.NET.SampleBase
    {
        // Fields
        public System.Nullable<T> result;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600005D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002D  // size: 0x14
    public sealed struct WrapMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static USD.NET.Unity.TextureReaderSample.WrapMode Black;  // const
        public static USD.NET.Unity.TextureReaderSample.WrapMode Clamp;  // const
        public static USD.NET.Unity.TextureReaderSample.WrapMode Repeat;  // const
        public static USD.NET.Unity.TextureReaderSample.WrapMode Mirror;  // const

    }

    // TypeToken: 0x200002E  // size: 0x14
    public sealed struct SRGBMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static USD.NET.Unity.TextureReaderSample.SRGBMode Yes;  // const
        public static USD.NET.Unity.TextureReaderSample.SRGBMode No;  // const
        public static USD.NET.Unity.TextureReaderSample.SRGBMode Auto;  // const

    }

    // TypeToken: 0x200002F  // size: 0x58
    public class Outputs : USD.NET.SampleBase
    {
        // Fields
        public System.Nullable<System.Single> r;  // 0x10
        public System.Nullable<System.Single> g;  // 0x18
        public System.Nullable<System.Single> b;  // 0x20
        public System.Nullable<System.Single> a;  // 0x28
        public System.Nullable<UnityEngine.Vector3> rgb;  // 0x30
        public System.Nullable<UnityEngine.Vector4> rgba;  // 0x40

        // Methods
        // RVA: 0x0350B670  token: 0x6000064
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000031  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly USD.NET.Unity.UnityTypeBindings.<>c <>9;  // static @ 0x0
        public static USD.NET.ToVtConverter <>9__2_0;  // static @ 0x8
        public static USD.NET.ToCsConverter <>9__2_1;  // static @ 0x10
        public static USD.NET.ToVtConverter <>9__2_2;  // static @ 0x18
        public static USD.NET.ToCsConverter <>9__2_3;  // static @ 0x20
        public static USD.NET.ToVtConverter <>9__2_4;  // static @ 0x28
        public static USD.NET.ToCsConverter <>9__2_5;  // static @ 0x30
        public static USD.NET.ToVtConverter <>9__2_6;  // static @ 0x38
        public static USD.NET.ToCsConverter <>9__2_7;  // static @ 0x40
        public static USD.NET.ToVtConverter <>9__2_8;  // static @ 0x48
        public static USD.NET.ToCsConverter <>9__2_9;  // static @ 0x50
        public static USD.NET.ToVtConverter <>9__2_10;  // static @ 0x58
        public static USD.NET.ToCsConverter <>9__2_11;  // static @ 0x60
        public static USD.NET.ToVtConverter <>9__2_12;  // static @ 0x68
        public static USD.NET.ToCsConverter <>9__2_13;  // static @ 0x70
        public static USD.NET.ToVtConverter <>9__2_14;  // static @ 0x78
        public static USD.NET.ToCsConverter <>9__2_15;  // static @ 0x80
        public static USD.NET.ToVtConverter <>9__2_16;  // static @ 0x88
        public static USD.NET.ToCsConverter <>9__2_17;  // static @ 0x90
        public static USD.NET.ToVtConverter <>9__2_18;  // static @ 0x98
        public static USD.NET.ToCsConverter <>9__2_19;  // static @ 0xa0

        // Methods
        // RVA: 0x09FD7134  token: 0x6000067
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000068
        public System.Void .ctor() { }
        // RVA: 0x09FD6758  token: 0x6000069
        private pxr.VtValue <RegisterTypes>b__2_0(System.Object obj) { }
        // RVA: 0x09FD6C5C  token: 0x600006A
        private System.Object <RegisterTypes>b__2_1(pxr.VtValue value) { }
        // RVA: 0x09FD6CD8  token: 0x600006B
        private pxr.VtValue <RegisterTypes>b__2_2(System.Object obj) { }
        // RVA: 0x09FD6D40  token: 0x600006C
        private System.Object <RegisterTypes>b__2_3(pxr.VtValue value) { }
        // RVA: 0x09FD6DB0  token: 0x600006D
        private pxr.VtValue <RegisterTypes>b__2_4(System.Object obj) { }
        // RVA: 0x09FD6E28  token: 0x600006E
        private System.Object <RegisterTypes>b__2_5(pxr.VtValue value) { }
        // RVA: 0x09FD6EAC  token: 0x600006F
        private pxr.VtValue <RegisterTypes>b__2_6(System.Object obj) { }
        // RVA: 0x09FD6F1C  token: 0x6000070
        private System.Object <RegisterTypes>b__2_7(pxr.VtValue value) { }
        // RVA: 0x09FD6F98  token: 0x6000071
        private pxr.VtValue <RegisterTypes>b__2_8(System.Object obj) { }
        // RVA: 0x09FD7008  token: 0x6000072
        private System.Object <RegisterTypes>b__2_9(pxr.VtValue value) { }
        // RVA: 0x09FD67C8  token: 0x6000073
        private pxr.VtValue <RegisterTypes>b__2_10(System.Object obj) { }
        // RVA: 0x09FD6830  token: 0x6000074
        private System.Object <RegisterTypes>b__2_11(pxr.VtValue vtVal) { }
        // RVA: 0x09FD6880  token: 0x6000075
        private pxr.VtValue <RegisterTypes>b__2_12(System.Object obj) { }
        // RVA: 0x09FD68F0  token: 0x6000076
        private System.Object <RegisterTypes>b__2_13(pxr.VtValue vtVal) { }
        // RVA: 0x09FD696C  token: 0x6000077
        private pxr.VtValue <RegisterTypes>b__2_14(System.Object obj) { }
        // RVA: 0x09FD69D0  token: 0x6000078
        private System.Object <RegisterTypes>b__2_15(pxr.VtValue vtVal) { }
        // RVA: 0x09FD6A40  token: 0x6000079
        private pxr.VtValue <RegisterTypes>b__2_16(System.Object obj) { }
        // RVA: 0x09FD6ABC  token: 0x600007A
        private System.Object <RegisterTypes>b__2_17(pxr.VtValue vtVal) { }
        // RVA: 0x09FD6B34  token: 0x600007B
        private pxr.VtValue <RegisterTypes>b__2_18(System.Object obj) { }
        // RVA: 0x09FD6BC0  token: 0x600007C
        private System.Object <RegisterTypes>b__2_19(pxr.VtValue vtVal) { }

    }

    // TypeToken: 0x2000034  // size: 0x20
    public sealed class <>c__DisplayClass11_0
    {
        // Fields
        public UnityEngine.Transform transform;  // 0x10
        public System.String name;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60000C8
        public System.Void .ctor() { }
        // RVA: 0x09FD7084  token: 0x60000C9
        private System.Boolean <HasAnySiblingsWithName>b__0(UnityEngine.GameObject sibling) { }

    }

namespace USD.NET.Unity
{

    // TypeToken: 0x2000002  // size: 0x10
    public class DiagnosticHandler : pxr.DiagnosticHandler
    {
        // Methods
        // RVA: 0x09FD2F00  token: 0x6000001
        public System.Void .ctor() { }
        // RVA: 0x09FD2D98  token: 0x6000002
        public virtual System.Void OnFatalError(System.String msg) { }
        // RVA: 0x09FD2CD4  token: 0x6000003
        public virtual System.Void OnError(System.String msg) { }
        // RVA: 0x09FD2E9C  token: 0x6000004
        public virtual System.Void OnWarning(System.String msg) { }
        // RVA: 0x09FD2E38  token: 0x6000005
        public virtual System.Void OnInfo(System.String msg) { }

    }

    // TypeToken: 0x2000003  // size: 0xC0
    public class BasisCurvesSample : USD.NET.Unity.CurvesSample
    {
        // Fields
        public USD.NET.Unity.BasisCurvesSample.CurveType type;  // 0xb0
        public USD.NET.Unity.BasisCurvesSample.Basis basis;  // 0xb4
        public USD.NET.Unity.BasisCurvesSample.WrapMode wrap;  // 0xb8

        // Methods
        // RVA: 0x09FD2738  token: 0x6000006
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000007  // size: 0x78
    public class BoundableSample : USD.NET.Unity.XformableSample
    {
        // Fields
        public UnityEngine.Bounds extent;  // 0x60

        // Methods
        // RVA: 0x09B85118  token: 0x6000007
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000008  // size: 0xA0
    public class CameraSample : USD.NET.Unity.XformSample
    {
        // Fields
        public USD.NET.Unity.CameraSample.ProjectionType projection;  // 0x60
        public System.Single horizontalAperture;  // 0x64
        public System.Single horizontalApertureOffset;  // 0x68
        public System.Single verticalAperture;  // 0x6c
        public System.Single verticalApertureOffset;  // 0x70
        public System.Single focalLength;  // 0x74
        public UnityEngine.Vector2 clippingRange;  // 0x78
        public UnityEngine.Vector4[] clippingPlanes;  // 0x80
        public System.Single fStop;  // 0x88
        public System.Single focusDistance;  // 0x8c
        public USD.NET.Unity.CameraSample.StereoRole stereoRole;  // 0x90
        public USD.NET.Unity.CameraSample.Shutter shutter;  // 0x98

        // Methods
        // RVA: 0x09B85118  token: 0x6000008
        public System.Void .ctor() { }
        // RVA: 0x09FD2BC8  token: 0x6000009
        public System.Void .ctor(UnityEngine.Camera fromCamera) { }
        // RVA: 0x09FD2740  token: 0x600000A
        public System.Void CopyFromCamera(UnityEngine.Camera camera, System.Boolean convertTransformToUsd) { }
        // RVA: 0x09FD2970  token: 0x600000B
        public System.Void CopyToCamera(UnityEngine.Camera camera, System.Boolean setTransform) { }

    }

    // TypeToken: 0x200000C  // size: 0x88
    public class CubeSample : USD.NET.Unity.GprimSample
    {
        // Fields
        private System.Double m_size;  // 0x80

        // Properties
        System.Double size { get; /* RVA: 0x03D50B60 */ set; /* RVA: 0x09FD2C28 */ }

        // Methods
        // RVA: 0x09FD2738  token: 0x600000D
        public System.Void .ctor() { }
        // RVA: 0x09FD2BFC  token: 0x600000E
        public System.Void .ctor(System.Double size) { }

    }

    // TypeToken: 0x200000D  // size: 0xB0
    public class CurvesSample : USD.NET.Unity.PointBasedSample
    {
        // Fields
        public System.Boolean doubleSided;  // 0x80
        public USD.NET.Orientation orientation;  // 0x84
        public UnityEngine.Vector3[] points;  // 0x88
        public UnityEngine.Vector3[] normals;  // 0x90
        public UnityEngine.Vector3[] velocities;  // 0x98
        public System.Int32[] curveVertexCounts;  // 0xa0
        public System.Single[] widths;  // 0xa8

        // Methods
        // RVA: 0x09FD2738  token: 0x6000011
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000E  // size: 0x80
    public class GprimSample : USD.NET.Unity.BoundableSample
    {
        // Fields
        public USD.NET.Primvar<UnityEngine.Color[]> colors;  // 0x78

        // Methods
        // RVA: 0x09FD2F08  token: 0x6000012
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000F  // size: 0x10
    public class ImageableSample : USD.NET.SampleBase
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000013
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000010  // size: 0xC0
    public class MeshSample : USD.NET.Unity.MeshSampleBase
    {
        // Fields
        public USD.NET.Visibility visibility;  // 0xa8
        public USD.NET.Purpose purpose;  // 0xac
        public System.Boolean doubleSided;  // 0xb0
        public USD.NET.Orientation orientation;  // 0xb4
        public System.Int32[] faceVertexCounts;  // 0xb8

        // Methods
        // RVA: 0x09FD3E5C  token: 0x6000014
        public System.Void SetTriangles(System.Int32[] triangleIndices) { }
        // RVA: 0x09B8704C  token: 0x6000015
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000011  // size: 0xA8
    public class MeshSampleBase : USD.NET.Unity.PointBasedSample, USD.NET.IArbitraryPrimvars
    {
        // Fields
        public System.Int32[] faceVertexIndices;  // 0x80
        public UnityEngine.Vector3[] points;  // 0x88
        public UnityEngine.Vector3[] normals;  // 0x90
        public USD.NET.Primvar<UnityEngine.Vector4[]> tangents;  // 0x98
        public System.Collections.Generic.Dictionary<System.String,USD.NET.Primvar<System.Object>> ArbitraryPrimvars;  // 0xa0

        // Methods
        // RVA: 0x03D4EA80  token: 0x6000016
        public virtual System.Collections.Generic.Dictionary<System.String,USD.NET.Primvar<System.Object>> GetArbitraryPrimvars() { }
        // RVA: 0x09FD3D8C  token: 0x6000017
        public System.Void .ctor() { }
        // RVA: 0x09FD3BAC  token: 0x6000018
        public virtual System.Void AddPrimvars(System.Collections.Generic.List<System.String> primvars) { }

    }

    // TypeToken: 0x2000012  // size: 0x80
    public class PointBasedSample : USD.NET.Unity.GprimSample
    {
        // Methods
        // RVA: 0x09FD2738  token: 0x6000019
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000013  // size: 0x80
    public class PointInstancerPrototypesSample : USD.NET.Unity.BoundableSample
    {
        // Fields
        public USD.NET.Relationship prototypes;  // 0x78

        // Methods
        // RVA: 0x09FD4050  token: 0x600001A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000014  // size: 0xC0
    public class PointInstancerSample : USD.NET.Unity.PointInstancerPrototypesSample
    {
        // Fields
        public System.Int32[] protoIndices;  // 0x80
        public System.Int64[] ids;  // 0x88
        public System.Int64[] invisibleIds;  // 0x90
        public UnityEngine.Vector3[] positions;  // 0x98
        public UnityEngine.Quaternion[] rotations;  // 0xa0
        public UnityEngine.Vector3[] scales;  // 0xa8
        public UnityEngine.Vector3[] velocities;  // 0xb0
        public UnityEngine.Vector3[] angularVelocities;  // 0xb8

        // Methods
        // RVA: 0x09FD40A8  token: 0x600001B
        public UnityEngine.Matrix4x4[] ComputeInstanceMatrices(USD.NET.Scene scene, System.String primPath) { }
        // RVA: 0x09FD42FC  token: 0x600001C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000015  // size: 0x10
    public class ScopeSample : USD.NET.Unity.ImageableSample
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600001D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000016  // size: 0x88
    public class SphereSample : USD.NET.Unity.GprimSample
    {
        // Fields
        private System.Double m_radius;  // 0x80

        // Properties
        System.Double radius { get; /* RVA: 0x03D50B60 */ set; /* RVA: 0x09FD4800 */ }

        // Methods
        // RVA: 0x09FD2738  token: 0x600001E
        public System.Void .ctor() { }
        // RVA: 0x09FD2BFC  token: 0x600001F
        public System.Void .ctor(System.Double radius) { }

    }

    // TypeToken: 0x2000017  // size: 0x60
    public class XformableSample : USD.NET.Unity.ImageableSample
    {
        // Fields
        private readonly System.String[] kXformOpTransform;  // 0x10
        private UnityEngine.Matrix4x4 m_xf;  // 0x18
        public System.String[] xformOpOrder;  // 0x58

        // Properties
        UnityEngine.Matrix4x4 transform { get; /* RVA: 0x03D58F00 */ set; /* RVA: 0x09FDD744 */ }

        // Methods
        // RVA: 0x09FDD548  token: 0x6000022
        public static USD.NET.Unity.XformableSample FromTransform(UnityEngine.Transform transform) { }
        // RVA: 0x09FDD680  token: 0x6000023
        public System.Void .ctor() { }
        // RVA: 0x09FDD484  token: 0x6000026
        public System.Void ConvertTransform() { }

    }

    // TypeToken: 0x2000018  // size: 0x60
    public class XformSample : USD.NET.Unity.XformableSample
    {
        // Methods
        // RVA: 0x09B85118  token: 0x6000027
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000019  // size: 0x18
    public class MaterialBindingSample : USD.NET.SampleBase
    {
        // Fields
        public USD.NET.Relationship binding;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000028
        public System.Void .ctor() { }
        // RVA: 0x09FD30DC  token: 0x6000029
        public System.Void .ctor(System.String materialPath) { }

    }

    // TypeToken: 0x200001A  // size: 0x28
    public class MaterialSample : USD.NET.SampleBase
    {
        // Fields
        public USD.NET.Connectable<pxr.TfToken> surface;  // 0x10
        public USD.NET.Connectable<pxr.TfToken> displacement;  // 0x18
        public System.String[] requiredKeywords;  // 0x20

        // Methods
        // RVA: 0x09FD3A64  token: 0x600002A
        public System.Void .ctor() { }
        // RVA: 0x09FD39BC  token: 0x600002B
        public System.Void .ctor(System.String surfacePath) { }
        // RVA: 0x09FD3ADC  token: 0x600002C
        public System.Void .ctor(System.String surfacePath, System.String displacementPath) { }
        // RVA: 0x09FD33DC  token: 0x600002D
        public static System.Boolean ReadMaterial(USD.NET.Scene scene, System.String geometryPath, USD.NET.Unity.MaterialSample materialSample, System.String& shaderId) { }
        // RVA: 0x09FD3154  token: 0x600002E
        public static System.Void Bind(USD.NET.Scene scene, System.String primPath, System.String materialPath) { }
        // RVA: 0x09FD3864  token: 0x600002F
        public static System.Void Unbind(USD.NET.Scene scene, System.String primPath) { }

    }

    // TypeToken: 0x200001B  // size: 0x38
    public sealed struct ParameterInfo
    {
        // Fields
        public System.Object value;  // 0x10
        public System.String connectedPath;  // 0x18
        public System.String usdName;  // 0x20
        public System.String unityName;  // 0x28
        public System.String[] requiredShaderKeywords;  // 0x30

        // Methods
        // RVA: 0x09FD3F18  token: 0x6000030
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200001C  // size: 0x20
    public class InputParameterAttribute : USD.NET.UsdNamespaceAttribute
    {
        // Fields
        private System.String <UnityName>k__BackingField;  // 0x18

        // Properties
        System.String UnityName { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x09FD2FCC  token: 0x6000033
        public System.Void .ctor() { }
        // RVA: 0x09FD2F74  token: 0x6000034
        public System.Void .ctor(System.String unityName) { }

    }

    // TypeToken: 0x200001D  // size: 0x20
    public class InputTextureAttribute : USD.NET.UsdNamespaceAttribute
    {
        // Fields
        private System.String <UnityName>k__BackingField;  // 0x18

        // Properties
        System.String UnityName { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x09FD3028  token: 0x6000037
        public System.Void .ctor() { }
        // RVA: 0x09FD3084  token: 0x6000038
        public System.Void .ctor(System.String unityName) { }

    }

    // TypeToken: 0x200001E  // size: 0x18
    public class RequireShaderKeywordsAttribute : System.Attribute
    {
        // Fields
        private System.String[] <Keywords>k__BackingField;  // 0x10

        // Properties
        System.String[] Keywords { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x09FD4684  token: 0x600003B
        public System.Void .ctor(System.String keyword) { }
        // RVA: 0x0426FEE0  token: 0x600003C
        public System.Void .ctor(System.String[] keywords) { }

    }

    // TypeToken: 0x200001F  // size: 0x18
    public class ShaderSample : USD.NET.SampleBase
    {
        // Fields
        public pxr.TfToken id;  // 0x10

        // Methods
        // RVA: 0x0426F82C  token: 0x600003D
        private System.Type GetClassType() { }
        // RVA: 0x09FD47E0  token: 0x600003E
        private System.Object GetValue(System.Reflection.FieldInfo info) { }
        // RVA: 0x09FD4700  token: 0x600003F
        public System.Collections.Generic.IEnumerable<USD.NET.Unity.ParameterInfo> GetInputParameters() { }
        // RVA: 0x09FD4770  token: 0x6000040
        public System.Collections.Generic.IEnumerable<USD.NET.Unity.ParameterInfo> GetInputTextures() { }
        // RVA: 0x0350B670  token: 0x6000041
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000024  // size: 0xF8
    public class StandardShaderSample : USD.NET.Unity.ShaderSample
    {
        // Fields
        public System.Boolean enableGpuInstancing;  // 0x18
        public USD.NET.Connectable<UnityEngine.Color> albedo;  // 0x20
        public USD.NET.Connectable<UnityEngine.Color> albedoMap;  // 0x28
        public USD.NET.Connectable<System.Single> cutoff;  // 0x30
        public USD.NET.Connectable<System.Single> smoothness;  // 0x38
        public USD.NET.Connectable<System.Single> smoothnessScale;  // 0x40
        public USD.NET.Connectable<System.Single> smoothnessTextureChannel;  // 0x48
        public USD.NET.Connectable<System.Single> metallicMap;  // 0x50
        public USD.NET.Connectable<System.Single> metallicScale;  // 0x58
        public USD.NET.Connectable<System.Boolean> enableSpecularHighlights;  // 0x60
        public USD.NET.Connectable<System.Boolean> enableGlossyReflections;  // 0x68
        public USD.NET.Connectable<UnityEngine.Color> normalMap;  // 0x70
        public USD.NET.Connectable<System.Single> normalMapScale;  // 0x78
        public USD.NET.Connectable<UnityEngine.Color> parallaxMap;  // 0x80
        public USD.NET.Connectable<System.Single> parallaxMapScale;  // 0x88
        public USD.NET.Connectable<System.Single> occlusionMap;  // 0x90
        public USD.NET.Connectable<System.Single> occlusionMapScale;  // 0x98
        public USD.NET.Connectable<UnityEngine.Color> emission;  // 0xa0
        public USD.NET.Connectable<UnityEngine.Color> emissionMap;  // 0xa8
        public USD.NET.Connectable<UnityEngine.Color> detailMask;  // 0xb0
        public USD.NET.Connectable<UnityEngine.Color> detailAlbedoMap;  // 0xb8
        public USD.NET.Connectable<UnityEngine.Color> detailNormalMap;  // 0xc0
        public USD.NET.Connectable<System.Single> detailNormalMapScale;  // 0xc8
        public USD.NET.Connectable<System.Single> uvSetForSecondaryTextures;  // 0xd0
        public USD.NET.Connectable<System.Single> renderingMode;  // 0xd8
        public USD.NET.Connectable<System.Single> srcBlend;  // 0xe0
        public USD.NET.Connectable<System.Single> dstBlend;  // 0xe8
        public USD.NET.Connectable<System.Single> zwrite;  // 0xf0

        // Methods
        // RVA: 0x09FD48D0  token: 0x6000058
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000025  // size: 0x20
    public class Texture2DSample : USD.NET.SampleBase
    {
        // Fields
        public USD.NET.Connectable<System.String> sourceFile;  // 0x10
        public System.Boolean sRgb;  // 0x18

        // Methods
        // RVA: 0x09FD4DF8  token: 0x6000059
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000026  // size: 0x90
    public class PreviewSurfaceSample : USD.NET.Unity.ShaderSample
    {
        // Fields
        public USD.NET.Connectable<UnityEngine.Vector3> diffuseColor;  // 0x18
        public USD.NET.Connectable<UnityEngine.Vector3> emissiveColor;  // 0x20
        public USD.NET.Connectable<System.Int32> useSpecularWorkflow;  // 0x28
        public USD.NET.Connectable<UnityEngine.Vector3> specularColor;  // 0x30
        public USD.NET.Connectable<System.Single> metallic;  // 0x38
        public USD.NET.Connectable<System.Single> roughness;  // 0x40
        public USD.NET.Connectable<System.Single> clearcoat;  // 0x48
        public USD.NET.Connectable<System.Single> clearcoatRoughness;  // 0x50
        public USD.NET.Connectable<System.Single> opacity;  // 0x58
        public USD.NET.Connectable<System.Single> opacityThreshold;  // 0x60
        public USD.NET.Connectable<System.Single> ior;  // 0x68
        public USD.NET.Connectable<UnityEngine.Vector3> normal;  // 0x70
        public USD.NET.Connectable<System.Single> displacement;  // 0x78
        public USD.NET.Connectable<System.Single> occlusion;  // 0x80
        public USD.NET.Unity.PreviewSurfaceSample.Outputs outputs;  // 0x88

        // Methods
        // RVA: 0x09FD4304  token: 0x600005A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000028
    public class PrimvarReaderSample`1 : USD.NET.Unity.ShaderSample
    {
        // Fields
        public USD.NET.Connectable<T> fallback;  // 0x0
        public USD.NET.Unity.PrimvarReaderSample.Outputs<T> outputs;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600005C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002A
    public class PrimvarReaderImportSample`1 : USD.NET.Unity.PrimvarReaderSample`1
    {
        // Fields
        public USD.NET.Connectable<System.String> varname;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600005E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002B
    public class PrimvarReaderExportSample`1 : USD.NET.Unity.PrimvarReaderSample`1
    {
        // Fields
        public USD.NET.Connectable<pxr.TfToken> varname;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x600005F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002C  // size: 0x60
    public class TextureReaderSample : USD.NET.Unity.ShaderSample
    {
        // Fields
        public USD.NET.Connectable<pxr.SdfAssetPath> file;  // 0x18
        public USD.NET.Connectable<UnityEngine.Vector2> st;  // 0x20
        public USD.NET.Connectable<USD.NET.Unity.TextureReaderSample.WrapMode> wrapS;  // 0x28
        public USD.NET.Connectable<USD.NET.Unity.TextureReaderSample.WrapMode> wrapT;  // 0x30
        public USD.NET.Connectable<UnityEngine.Vector4> fallback;  // 0x38
        public USD.NET.Connectable<UnityEngine.Vector4> scale;  // 0x40
        public USD.NET.Connectable<UnityEngine.Vector4> bias;  // 0x48
        public USD.NET.Connectable<USD.NET.Unity.TextureReaderSample.SRGBMode> isSRGB;  // 0x50
        public USD.NET.Unity.TextureReaderSample.Outputs outputs;  // 0x58

        // Methods
        // RVA: 0x09FD4E7C  token: 0x6000060
        public System.Void .ctor() { }
        // RVA: 0x09FD5220  token: 0x6000061
        public System.Void .ctor(System.String filePath) { }
        // RVA: 0x09FD515C  token: 0x6000062
        public System.Void .ctor(System.String filePath, System.String stConnectionPath) { }
        // RVA: 0x09FD4E54  token: 0x6000063
        public static USD.NET.Unity.TextureReaderSample.WrapMode GetWrapMode(UnityEngine.TextureWrapMode wrap) { }

    }

    // TypeToken: 0x2000030  // size: 0x10
    public static class UnityTypeBindings
    {
        // Fields
        private static System.Boolean isInitialized;  // static @ 0x0

        // Methods
        // RVA: 0x09FD8AB0  token: 0x6000065
        private static System.Void .cctor() { }
        // RVA: 0x09FD7198  token: 0x6000066
        public static System.Void RegisterTypes() { }

    }

    // TypeToken: 0x2000032  // size: 0x10
    public class PreserveAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600007D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000033  // size: 0x10
    public class UnityTypeConverter : USD.NET.IntrinsicTypeConverter
    {
        // Fields
        public static UnityEngine.Matrix4x4 basisChange;  // static @ 0x0
        public static UnityEngine.Matrix4x4 inverseBasisChange;  // static @ 0x40

        // Methods
        // RVA: 0x09FD9074  token: 0x600007E
        public static UnityEngine.Matrix4x4 ChangeBasis(UnityEngine.Matrix4x4 input) { }
        // RVA: 0x09FD8FEC  token: 0x600007F
        public static UnityEngine.Vector3 ChangeBasis(UnityEngine.Vector3 point) { }
        // RVA: 0x09FDBFEC  token: 0x6000080
        public static System.Void SetTransform(UnityEngine.Matrix4x4 localXf, UnityEngine.Transform transform) { }
        // RVA: 0x09FD95C4  token: 0x6000081
        public static System.Boolean Decompose(UnityEngine.Matrix4x4 matrix, UnityEngine.Vector3& translation, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        // RVA: 0x09FDD2F4  token: 0x6000082
        private static UnityEngine.Vector3 WeightedAvg(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single aWeight, System.Single bWeight) { }
        // RVA: 0x09FDA52C  token: 0x6000083
        public static System.Void ExtractTrs(UnityEngine.Matrix4x4 transform, UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation, UnityEngine.Vector3& localScale) { }
        // RVA: 0x09FDA3B0  token: 0x6000084
        private static UnityEngine.Quaternion ExtractRotation(UnityEngine.Matrix4x4 mat4) { }
        // RVA: 0x03D8A030  token: 0x6000085
        private static UnityEngine.Vector3 ExtractPosition(UnityEngine.Matrix4x4 mat4) { }
        // RVA: 0x09FDA440  token: 0x6000086
        private static UnityEngine.Vector3 ExtractScale(UnityEngine.Matrix4x4 mat4) { }
        // RVA: 0x09FDB3F0  token: 0x6000087
        private static System.Boolean HasAnySiblingsWithName(UnityEngine.Transform transform, System.String name) { }
        // RVA: 0x09FDB334  token: 0x6000088
        public static System.String GetUniqueName(UnityEngine.Transform transform) { }
        // RVA: 0x09FDB2E8  token: 0x6000089
        public static System.String GetPath(UnityEngine.Transform unityObj) { }
        // RVA: 0x09FDB120  token: 0x600008A
        public static System.String GetPath(UnityEngine.Transform unityObj, UnityEngine.Transform unityObjRoot) { }
        // RVA: 0x09FDB03C  token: 0x600008B
        public static UnityEngine.Matrix4x4 GetLocalToParentXf(UnityEngine.Transform unityXf) { }
        // RVA: 0x09FDC194  token: 0x600008C
        public static pxr.GfMatrix4d ToGfMatrix(UnityEngine.Transform unityXf) { }
        // RVA: 0x09FDC210  token: 0x600008D
        public static pxr.GfMatrix4d ToGfMatrix(UnityEngine.Matrix4x4 unityMat4) { }
        // RVA: 0x09FDA648  token: 0x600008E
        public static UnityEngine.Matrix4x4 FromMatrix(pxr.GfMatrix4d gfMat) { }
        // RVA: 0x09FDC880  token: 0x600008F
        public static pxr.VtMatrix4dArray ToVtArray(UnityEngine.Matrix4x4[] input) { }
        // RVA: 0x09FDACB0  token: 0x6000090
        public static UnityEngine.Matrix4x4[] FromVtArray(pxr.VtMatrix4dArray input) { }
        // RVA: 0x09FDBDD4  token: 0x6000091
        public static pxr.VtMatrix4dArray ListToVtArray(System.Collections.Generic.List<UnityEngine.Matrix4x4> input) { }
        // RVA: 0x09FDB778  token: 0x6000092
        public static System.Collections.Generic.List<UnityEngine.Matrix4x4> ListFromVtArray(pxr.VtMatrix4dArray input) { }
        // RVA: 0x09FD9344  token: 0x6000093
        public static pxr.GfVec4f Color32ToVec4f(UnityEngine.Color32 c) { }
        // RVA: 0x09FDD0AC  token: 0x6000094
        public static UnityEngine.Color32 Vec4fToColor32(pxr.GfVec4f v) { }
        // RVA: 0x09FDCC5C  token: 0x6000095
        public static pxr.VtVec4fArray ToVtArray(System.Collections.Generic.List<UnityEngine.Color32> input) { }
        // RVA: 0x09FDCB40  token: 0x6000096
        public static System.Void ToVtArray(System.Collections.Generic.List<UnityEngine.Color32> input, pxr.VtVec3fArray& rgb, pxr.VtFloatArray& alpha) { }
        // RVA: 0x09FDCEB4  token: 0x6000097
        public static pxr.VtVec4fArray ToVtArray(UnityEngine.Color32[] input) { }
        // RVA: 0x09FD91C0  token: 0x6000098
        public static UnityEngine.Color32[] Color32FromVtArray(pxr.VtVec4fArray input) { }
        // RVA: 0x09FD954C  token: 0x6000099
        public static pxr.GfVec4f ColorToVec4f(UnityEngine.Color c) { }
        // RVA: 0x09FDD108  token: 0x600009A
        public static UnityEngine.Color Vec4fToColor(pxr.GfVec4f v) { }
        // RVA: 0x09FDC504  token: 0x600009B
        public static pxr.VtVec4fArray ToVtArray(System.Collections.Generic.List<UnityEngine.Color> input) { }
        // RVA: 0x09FDC6D4  token: 0x600009C
        public static System.Void ToVtArray(System.Collections.Generic.List<UnityEngine.Color> input, pxr.VtVec3fArray& rgb, pxr.VtFloatArray& alpha) { }
        // RVA: 0x09FDC644  token: 0x600009D
        public static pxr.VtVec4fArray ToVtArray(UnityEngine.Color[] input) { }
        // RVA: 0x09FD93A8  token: 0x600009E
        public static UnityEngine.Color[] ColorFromVtArray(pxr.VtVec4fArray input) { }
        // RVA: 0x09FD9458  token: 0x600009F
        public static UnityEngine.Color[] ColorFromVtArray(pxr.VtVec4fArray input, UnityEngine.Color[]& output) { }
        // RVA: 0x09FDCCC8  token: 0x60000A0
        public static System.Void ToVtArray(UnityEngine.Color32[] input, pxr.VtVec3fArray& rgb, pxr.VtFloatArray& alpha) { }
        // RVA: 0x09FDA168  token: 0x60000A1
        public static UnityEngine.Vector3[] ExtractRgb(UnityEngine.Color32[] colors) { }
        // RVA: 0x09FD9FE0  token: 0x60000A2
        public static System.Single[] ExtractAlpha(UnityEngine.Color32[] colors) { }
        // RVA: 0x09FDC97C  token: 0x60000A3
        public static System.Void ToVtArray(UnityEngine.Color[] input, pxr.VtVec3fArray& rgb, pxr.VtFloatArray& alpha) { }
        // RVA: 0x09FDADDC  token: 0x60000A4
        public static UnityEngine.Color[] FromVtArray(pxr.VtVec3fArray rgbIn, pxr.VtFloatArray alphaIn) { }
        // RVA: 0x09FDA2AC  token: 0x60000A5
        public static UnityEngine.Vector3[] ExtractRgb(UnityEngine.Color[] colors) { }
        // RVA: 0x09FDA0AC  token: 0x60000A6
        public static System.Single[] ExtractAlpha(UnityEngine.Color[] colors) { }
        // RVA: 0x09FDC0F8  token: 0x60000A7
        private static System.Void SwapQuaternionReal(UnityEngine.Quaternion[]& input) { }
        // RVA: 0x09FDBE40  token: 0x60000A8
        public static pxr.GfQuatf QuaternionToQuatf(UnityEngine.Quaternion quaternion) { }
        // RVA: 0x09FDBEB8  token: 0x60000A9
        public static UnityEngine.Quaternion QuatfToQuaternion(pxr.GfQuatf quat) { }
        // RVA: 0x09FDC570  token: 0x60000AA
        public static pxr.VtQuatfArray ToVtArray(UnityEngine.Quaternion[] input) { }
        // RVA: 0x09FDA964  token: 0x60000AB
        public static UnityEngine.Quaternion[] FromVtArray(pxr.VtQuatfArray input) { }
        // RVA: 0x09FDBD68  token: 0x60000AC
        public static pxr.VtQuatfArray ListToVtArray(System.Collections.Generic.List<UnityEngine.Quaternion> input) { }
        // RVA: 0x09FDBB2C  token: 0x60000AD
        public static System.Collections.Generic.List<UnityEngine.Quaternion> ListFromVtArray(pxr.VtQuatfArray input) { }
        // RVA: 0x09FDC760  token: 0x60000AE
        public static pxr.VtVec4fArray ToVtArray(UnityEngine.Vector4[] input) { }
        // RVA: 0x09FDAB38  token: 0x60000AF
        public static UnityEngine.Vector4[] FromVtArray(pxr.VtVec4fArray input) { }
        // RVA: 0x09FDBC90  token: 0x60000B0
        public static pxr.VtVec4fArray ListToVtArray(System.Collections.Generic.List<UnityEngine.Vector4> input) { }
        // RVA: 0x09FDB8BC  token: 0x60000B1
        public static System.Collections.Generic.List<UnityEngine.Vector4> ListFromVtArray(pxr.VtVec4fArray input) { }
        // RVA: 0x09FD8E2C  token: 0x60000B2
        public static pxr.VtVec3fArray BoundsToVtArray(UnityEngine.Bounds input) { }
        // RVA: 0x09FD8BB8  token: 0x60000B3
        public static UnityEngine.Bounds BoundsFromVtArray(pxr.VtValue vtBounds) { }
        // RVA: 0x09FD8AB8  token: 0x60000B4
        public static UnityEngine.Bounds BoundsFromVtArray(pxr.VtValue vtBounds, UnityEngine.Vector3[] bbox) { }
        // RVA: 0x09FDC7F0  token: 0x60000B5
        public static pxr.VtVec3fArray ToVtArray(UnityEngine.Vector3[] input) { }
        // RVA: 0x09FDAF84  token: 0x60000B6
        public static UnityEngine.Vector3[] FromVtArray(pxr.VtVec3fArray input) { }
        // RVA: 0x09FDAA48  token: 0x60000B7
        public static System.Void FromVtArray(pxr.VtVec3fArray input, UnityEngine.Vector3[]& output) { }
        // RVA: 0x09FDBC24  token: 0x60000B8
        public static pxr.VtVec3fArray ListToVtArray(System.Collections.Generic.List<UnityEngine.Vector3> input) { }
        // RVA: 0x09FDB98C  token: 0x60000B9
        public static System.Collections.Generic.List<UnityEngine.Vector3> ListFromVtArray(pxr.VtVec3fArray input) { }
        // RVA: 0x09FDCBCC  token: 0x60000BA
        public static pxr.VtVec2fArray ToVtArray(UnityEngine.Vector2[] input) { }
        // RVA: 0x09FDABF4  token: 0x60000BB
        public static UnityEngine.Vector2[] FromVtArray(pxr.VtVec2fArray input) { }
        // RVA: 0x09FDBCFC  token: 0x60000BC
        public static pxr.VtVec2fArray ListToVtArray(System.Collections.Generic.List<UnityEngine.Vector2> input) { }
        // RVA: 0x09FDBA5C  token: 0x60000BD
        public static System.Collections.Generic.List<UnityEngine.Vector2> ListFromVtArray(pxr.VtVec2fArray input) { }
        // RVA: 0x09FDD1A8  token: 0x60000BE
        public static pxr.GfVec2f Vector2ToVec2f(UnityEngine.Vector2 vec2) { }
        // RVA: 0x09FDCFA0  token: 0x60000BF
        public static UnityEngine.Vector2 Vec2fToVector2(pxr.GfVec2f value) { }
        // RVA: 0x09FDD20C  token: 0x60000C0
        public static pxr.GfVec3f Vector3ToVec3f(UnityEngine.Vector3 vec3) { }
        // RVA: 0x09FDD030  token: 0x60000C1
        public static UnityEngine.Vector3 Vec3fToVector3(pxr.GfVec3f v3) { }
        // RVA: 0x09FDD27C  token: 0x60000C2
        public static pxr.GfVec4f Vector4ToVec4f(UnityEngine.Vector4 vector4) { }
        // RVA: 0x09FDD108  token: 0x60000C3
        public static UnityEngine.Vector4 Vec4fToVector4(pxr.GfVec4f v4) { }
        // RVA: 0x09FDBF74  token: 0x60000C4
        public static pxr.GfVec4f RectToVtVec4(UnityEngine.Rect rect) { }
        // RVA: 0x09FDD108  token: 0x60000C5
        public static UnityEngine.Rect Vec4fToRect(pxr.GfVec4f v4) { }
        // RVA: 0x0350B670  token: 0x60000C6
        public System.Void .ctor() { }
        // RVA: 0x09FDD390  token: 0x60000C7
        private static System.Void .cctor() { }

    }

}

