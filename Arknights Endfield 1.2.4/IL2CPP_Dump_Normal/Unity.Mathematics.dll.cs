// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Mathematics.dll
// Classes:  94
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000005  // size: 0x11
    public sealed struct RotationOrder
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Unity.Mathematics.math.RotationOrder XYZ;  // const
        public static Unity.Mathematics.math.RotationOrder XZY;  // const
        public static Unity.Mathematics.math.RotationOrder YXZ;  // const
        public static Unity.Mathematics.math.RotationOrder YZX;  // const
        public static Unity.Mathematics.math.RotationOrder ZXY;  // const
        public static Unity.Mathematics.math.RotationOrder ZYX;  // const
        public static Unity.Mathematics.math.RotationOrder Default;  // const

    }

    // TypeToken: 0x2000006  // size: 0x11
    public sealed struct ShuffleComponent
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static Unity.Mathematics.math.ShuffleComponent LeftX;  // const
        public static Unity.Mathematics.math.ShuffleComponent LeftY;  // const
        public static Unity.Mathematics.math.ShuffleComponent LeftZ;  // const
        public static Unity.Mathematics.math.ShuffleComponent LeftW;  // const
        public static Unity.Mathematics.math.ShuffleComponent RightX;  // const
        public static Unity.Mathematics.math.ShuffleComponent RightY;  // const
        public static Unity.Mathematics.math.ShuffleComponent RightZ;  // const
        public static Unity.Mathematics.math.ShuffleComponent RightW;  // const

    }

    // TypeToken: 0x2000007  // size: 0x18
    public sealed struct LongDoubleUnion
    {
        // Fields
        public System.Int64 longValue;  // 0x10
        public System.Double doubleValue;  // 0x10

    }

    // TypeToken: 0x2000009  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

    // TypeToken: 0x200000E  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

    // TypeToken: 0x2000013  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

    // TypeToken: 0x2000018  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

    // TypeToken: 0x200001D  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

    // TypeToken: 0x2000022  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

    // TypeToken: 0x2000027  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

    // TypeToken: 0x200002C  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

    // TypeToken: 0x2000031  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

    // TypeToken: 0x2000037  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

    // TypeToken: 0x2000039  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

    // TypeToken: 0x200003B  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

    // TypeToken: 0x200003D  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

    // TypeToken: 0x2000042  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

    // TypeToken: 0x2000047  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

    // TypeToken: 0x2000051  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

    // TypeToken: 0x2000056  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

    // TypeToken: 0x200005B  // size: 0x10
    public sealed class DebuggerProxy
    {
    }

namespace Unity.IL2CPP.CompilerServices
{

    // TypeToken: 0x2000002  // size: 0x10
    public class Il2CppEagerStaticClassConstructionAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000001
        public System.Void .ctor() { }

    }

}

namespace Unity.Mathematics
{

    // TypeToken: 0x2000003  // size: 0x40
    public sealed struct AffineTransform : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.float3x3 rs;  // 0x10
        public Unity.Mathematics.float3 t;  // 0x34
        public static readonly Unity.Mathematics.AffineTransform identity;  // static @ 0x0

        // Methods
        // RVA: 0x09C5F45C  token: 0x6000002
        public System.Void .ctor(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation) { }
        // RVA: 0x09C5F3B4  token: 0x6000003
        public System.Void .ctor(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 scale) { }
        // RVA: 0x03D7D430  token: 0x6000004
        public System.Void .ctor(Unity.Mathematics.float3 translation, Unity.Mathematics.float3x3 rotationScale) { }
        // RVA: 0x09C5F34C  token: 0x6000005
        public System.Void .ctor(Unity.Mathematics.float3x3 rotationScale) { }
        // RVA: 0x09C5F2F4  token: 0x6000006
        public System.Void .ctor(Unity.Mathematics.RigidTransform rigid) { }
        // RVA: 0x04D2508C  token: 0x6000007
        public System.Void .ctor(Unity.Mathematics.float3x4 m) { }
        // RVA: 0x04D251C4  token: 0x6000008
        public System.Void .ctor(Unity.Mathematics.float4x4 m) { }
        // RVA: 0x09C5EC58  token: 0x6000009
        public virtual System.Boolean Equals(Unity.Mathematics.AffineTransform rhs) { }
        // RVA: 0x09C5EBDC  token: 0x600000A
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C5ECC0  token: 0x600000B
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C5EFC4  token: 0x600000C
        public virtual System.String ToString() { }
        // RVA: 0x09C5ECF0  token: 0x600000D
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x03CB4BF0  token: 0x600000E
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x10
    public static class math
    {
        // Fields
        public static System.Double E_DBL;  // const
        public static System.Double LOG2E_DBL;  // const
        public static System.Double LOG10E_DBL;  // const
        public static System.Double LN2_DBL;  // const
        public static System.Double LN10_DBL;  // const
        public static System.Double PI_DBL;  // const
        public static System.Double PI2_DBL;  // const
        public static System.Double PIHALF_DBL;  // const
        public static System.Double TAU_DBL;  // const
        public static System.Double TODEGREES_DBL;  // const
        public static System.Double TORADIANS_DBL;  // const
        public static System.Double SQRT2_DBL;  // const
        public static System.Double EPSILON_DBL;  // const
        public static System.Double INFINITY_DBL;  // const
        public static System.Double NAN_DBL;  // const
        public static System.Single FLT_MIN_NORMAL;  // const
        public static System.Double DBL_MIN_NORMAL;  // const
        public static System.Single E;  // const
        public static System.Single LOG2E;  // const
        public static System.Single LOG10E;  // const
        public static System.Single LN2;  // const
        public static System.Single LN10;  // const
        public static System.Single PI;  // const
        public static System.Single PI2;  // const
        public static System.Single PIHALF;  // const
        public static System.Single TAU;  // const
        public static System.Single TODEGREES;  // const
        public static System.Single TORADIANS;  // const
        public static System.Single SQRT2;  // const
        public static System.Single EPSILON;  // const
        public static System.Single INFINITY;  // const
        public static System.Single NAN;  // const

        // Methods
        // RVA: 0x09C2C7E8  token: 0x600000F
        public static Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation) { }
        // RVA: 0x09C2C834  token: 0x6000010
        public static Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 scale) { }
        // RVA: 0x03D78240  token: 0x6000011
        public static Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float3 translation, Unity.Mathematics.float3x3 rotationScale) { }
        // RVA: 0x09C2C758  token: 0x6000012
        public static Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float3x3 rotationScale) { }
        // RVA: 0x09C2C79C  token: 0x6000013
        public static Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float4x4 m) { }
        // RVA: 0x09C2C8DC  token: 0x6000014
        public static Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float3x4 m) { }
        // RVA: 0x09C2C898  token: 0x6000015
        public static Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.RigidTransform rigid) { }
        // RVA: 0x09C350EC  token: 0x6000016
        public static Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.AffineTransform transform) { }
        // RVA: 0x09C347A0  token: 0x6000017
        public static Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.AffineTransform transform) { }
        // RVA: 0x09C4A9C8  token: 0x6000018
        public static Unity.Mathematics.AffineTransform mul(Unity.Mathematics.AffineTransform a, Unity.Mathematics.AffineTransform b) { }
        // RVA: 0x09C496D8  token: 0x6000019
        public static Unity.Mathematics.AffineTransform mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.AffineTransform b) { }
        // RVA: 0x09C4C924  token: 0x600001A
        public static Unity.Mathematics.AffineTransform mul(Unity.Mathematics.AffineTransform a, Unity.Mathematics.float3x3 b) { }
        // RVA: 0x09C4F454  token: 0x600001B
        public static Unity.Mathematics.float4 mul(Unity.Mathematics.AffineTransform a, Unity.Mathematics.float4 pos) { }
        // RVA: 0x09C52B98  token: 0x600001C
        public static Unity.Mathematics.float3 rotate(Unity.Mathematics.AffineTransform a, Unity.Mathematics.float3 dir) { }
        // RVA: 0x09C56440  token: 0x600001D
        public static Unity.Mathematics.float3 transform(Unity.Mathematics.AffineTransform a, Unity.Mathematics.float3 pos) { }
        // RVA: 0x09C3D650  token: 0x600001E
        public static Unity.Mathematics.AffineTransform inverse(Unity.Mathematics.AffineTransform a) { }
        // RVA: 0x09C30428  token: 0x600001F
        public static System.Void decompose(Unity.Mathematics.AffineTransform a, Unity.Mathematics.float3& translation, Unity.Mathematics.quaternion& rotation, Unity.Mathematics.float3& scale) { }
        // RVA: 0x09C35E68  token: 0x6000020
        public static System.UInt32 hash(Unity.Mathematics.AffineTransform a) { }
        // RVA: 0x09C3A4BC  token: 0x6000021
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.AffineTransform a) { }
        // RVA: 0x03D787C0  token: 0x6000022
        public static Unity.Mathematics.bool2 bool2(System.Boolean x, System.Boolean y) { }
        // RVA: 0x03D787E0  token: 0x6000023
        public static Unity.Mathematics.bool2 bool2(Unity.Mathematics.bool2 xy) { }
        // RVA: 0x03D787D0  token: 0x6000024
        public static Unity.Mathematics.bool2 bool2(System.Boolean v) { }
        // RVA: 0x09C375E8  token: 0x6000025
        public static System.UInt32 hash(Unity.Mathematics.bool2 v) { }
        // RVA: 0x09C39D58  token: 0x6000026
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.bool2 v) { }
        // RVA: 0x04D580D0  token: 0x6000027
        public static System.Boolean shuffle(Unity.Mathematics.bool2 left, Unity.Mathematics.bool2 right, Unity.Mathematics.math.ShuffleComponent x) { }
        // RVA: 0x04D599E8  token: 0x6000028
        public static Unity.Mathematics.bool2 shuffle(Unity.Mathematics.bool2 left, Unity.Mathematics.bool2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y) { }
        // RVA: 0x04D582B0  token: 0x6000029
        public static Unity.Mathematics.bool3 shuffle(Unity.Mathematics.bool2 left, Unity.Mathematics.bool2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z) { }
        // RVA: 0x04D5887C  token: 0x600002A
        public static Unity.Mathematics.bool4 shuffle(Unity.Mathematics.bool2 left, Unity.Mathematics.bool2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w) { }
        // RVA: 0x04D57694  token: 0x600002B
        private static System.Boolean select_shuffle_component(Unity.Mathematics.bool2 a, Unity.Mathematics.bool2 b, Unity.Mathematics.math.ShuffleComponent component) { }
        // RVA: 0x03D78800  token: 0x600002C
        public static Unity.Mathematics.bool2x2 bool2x2(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1) { }
        // RVA: 0x04D2D538  token: 0x600002D
        public static Unity.Mathematics.bool2x2 bool2x2(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11) { }
        // RVA: 0x09C2EC58  token: 0x600002E
        public static Unity.Mathematics.bool2x2 bool2x2(System.Boolean v) { }
        // RVA: 0x09C56C5C  token: 0x600002F
        public static Unity.Mathematics.bool2x2 transpose(Unity.Mathematics.bool2x2 v) { }
        // RVA: 0x09C3740C  token: 0x6000030
        public static System.UInt32 hash(Unity.Mathematics.bool2x2 v) { }
        // RVA: 0x09C3B9A8  token: 0x6000031
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.bool2x2 v) { }
        // RVA: 0x03D78810  token: 0x6000032
        public static Unity.Mathematics.bool2x3 bool2x3(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1, Unity.Mathematics.bool2 c2) { }
        // RVA: 0x04D2D568  token: 0x6000033
        public static Unity.Mathematics.bool2x3 bool2x3(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12) { }
        // RVA: 0x09C2EC7C  token: 0x6000034
        public static Unity.Mathematics.bool2x3 bool2x3(System.Boolean v) { }
        // RVA: 0x09C56968  token: 0x6000035
        public static Unity.Mathematics.bool3x2 transpose(Unity.Mathematics.bool2x3 v) { }
        // RVA: 0x09C38388  token: 0x6000036
        public static System.UInt32 hash(Unity.Mathematics.bool2x3 v) { }
        // RVA: 0x09C3A160  token: 0x6000037
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.bool2x3 v) { }
        // RVA: 0x03D78830  token: 0x6000038
        public static Unity.Mathematics.bool2x4 bool2x4(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1, Unity.Mathematics.bool2 c2, Unity.Mathematics.bool2 c3) { }
        // RVA: 0x09C2EC98  token: 0x6000039
        public static Unity.Mathematics.bool2x4 bool2x4(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13) { }
        // RVA: 0x09C2ECF0  token: 0x600003A
        public static Unity.Mathematics.bool2x4 bool2x4(System.Boolean v) { }
        // RVA: 0x09C572A8  token: 0x600003B
        public static Unity.Mathematics.bool4x2 transpose(Unity.Mathematics.bool2x4 v) { }
        // RVA: 0x09C37858  token: 0x600003C
        public static System.UInt32 hash(Unity.Mathematics.bool2x4 v) { }
        // RVA: 0x09C3C568  token: 0x600003D
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.bool2x4 v) { }
        // RVA: 0x03D78860  token: 0x600003E
        public static Unity.Mathematics.bool3 bool3(System.Boolean x, System.Boolean y, System.Boolean z) { }
        // RVA: 0x03D788A0  token: 0x600003F
        public static Unity.Mathematics.bool3 bool3(System.Boolean x, Unity.Mathematics.bool2 yz) { }
        // RVA: 0x03D78880  token: 0x6000040
        public static Unity.Mathematics.bool3 bool3(Unity.Mathematics.bool2 xy, System.Boolean z) { }
        // RVA: 0x03D788C0  token: 0x6000041
        public static Unity.Mathematics.bool3 bool3(Unity.Mathematics.bool3 xyz) { }
        // RVA: 0x03D78870  token: 0x6000042
        public static Unity.Mathematics.bool3 bool3(System.Boolean v) { }
        // RVA: 0x04D33EC4  token: 0x6000043
        public static System.UInt32 hash(Unity.Mathematics.bool3 v) { }
        // RVA: 0x09C3AF5C  token: 0x6000044
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.bool3 v) { }
        // RVA: 0x04D58B38  token: 0x6000045
        public static System.Boolean shuffle(Unity.Mathematics.bool3 left, Unity.Mathematics.bool3 right, Unity.Mathematics.math.ShuffleComponent x) { }
        // RVA: 0x09C54898  token: 0x6000046
        public static Unity.Mathematics.bool2 shuffle(Unity.Mathematics.bool3 left, Unity.Mathematics.bool3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y) { }
        // RVA: 0x09C5441C  token: 0x6000047
        public static Unity.Mathematics.bool3 shuffle(Unity.Mathematics.bool3 left, Unity.Mathematics.bool3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z) { }
        // RVA: 0x09C53B30  token: 0x6000048
        public static Unity.Mathematics.bool4 shuffle(Unity.Mathematics.bool3 left, Unity.Mathematics.bool3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w) { }
        // RVA: 0x04D57AE0  token: 0x6000049
        private static System.Boolean select_shuffle_component(Unity.Mathematics.bool3 a, Unity.Mathematics.bool3 b, Unity.Mathematics.math.ShuffleComponent component) { }
        // RVA: 0x03D788E0  token: 0x600004A
        public static Unity.Mathematics.bool3x2 bool3x2(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1) { }
        // RVA: 0x04D2D624  token: 0x600004B
        public static Unity.Mathematics.bool3x2 bool3x2(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11, System.Boolean m20, System.Boolean m21) { }
        // RVA: 0x09C2ED14  token: 0x600004C
        public static Unity.Mathematics.bool3x2 bool3x2(System.Boolean v) { }
        // RVA: 0x09C57538  token: 0x600004D
        public static Unity.Mathematics.bool2x3 transpose(Unity.Mathematics.bool3x2 v) { }
        // RVA: 0x04D35E04  token: 0x600004E
        public static System.UInt32 hash(Unity.Mathematics.bool3x2 v) { }
        // RVA: 0x09C3BBFC  token: 0x600004F
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.bool3x2 v) { }
        // RVA: 0x03D78910  token: 0x6000050
        public static Unity.Mathematics.bool3x3 bool3x3(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1, Unity.Mathematics.bool3 c2) { }
        // RVA: 0x04D2D65C  token: 0x6000051
        public static Unity.Mathematics.bool3x3 bool3x3(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m20, System.Boolean m21, System.Boolean m22) { }
        // RVA: 0x09C2ED30  token: 0x6000052
        public static Unity.Mathematics.bool3x3 bool3x3(System.Boolean v) { }
        // RVA: 0x09C57248  token: 0x6000053
        public static Unity.Mathematics.bool3x3 transpose(Unity.Mathematics.bool3x3 v) { }
        // RVA: 0x04D36C28  token: 0x6000054
        public static System.UInt32 hash(Unity.Mathematics.bool3x3 v) { }
        // RVA: 0x09C3BD24  token: 0x6000055
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.bool3x3 v) { }
        // RVA: 0x03D78950  token: 0x6000056
        public static Unity.Mathematics.bool3x4 bool3x4(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1, Unity.Mathematics.bool3 c2, Unity.Mathematics.bool3 c3) { }
        // RVA: 0x04D2D6BC  token: 0x6000057
        public static Unity.Mathematics.bool3x4 bool3x4(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m23) { }
        // RVA: 0x09C2ED4C  token: 0x6000058
        public static Unity.Mathematics.bool3x4 bool3x4(System.Boolean v) { }
        // RVA: 0x09C57580  token: 0x6000059
        public static Unity.Mathematics.bool4x3 transpose(Unity.Mathematics.bool3x4 v) { }
        // RVA: 0x04D34EC4  token: 0x600005A
        public static System.UInt32 hash(Unity.Mathematics.bool3x4 v) { }
        // RVA: 0x09C3A8C0  token: 0x600005B
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.bool3x4 v) { }
        // RVA: 0x03D789E0  token: 0x600005C
        public static Unity.Mathematics.bool4 bool4(System.Boolean x, System.Boolean y, System.Boolean z, System.Boolean w) { }
        // RVA: 0x03D78A70  token: 0x600005D
        public static Unity.Mathematics.bool4 bool4(System.Boolean x, System.Boolean y, Unity.Mathematics.bool2 zw) { }
        // RVA: 0x03D789C0  token: 0x600005E
        public static Unity.Mathematics.bool4 bool4(System.Boolean x, Unity.Mathematics.bool2 yz, System.Boolean w) { }
        // RVA: 0x03D78AC0  token: 0x600005F
        public static Unity.Mathematics.bool4 bool4(System.Boolean x, Unity.Mathematics.bool3 yzw) { }
        // RVA: 0x03D789A0  token: 0x6000060
        public static Unity.Mathematics.bool4 bool4(Unity.Mathematics.bool2 xy, System.Boolean z, System.Boolean w) { }
        // RVA: 0x03D78A20  token: 0x6000061
        public static Unity.Mathematics.bool4 bool4(Unity.Mathematics.bool2 xy, Unity.Mathematics.bool2 zw) { }
        // RVA: 0x03D78A90  token: 0x6000062
        public static Unity.Mathematics.bool4 bool4(Unity.Mathematics.bool3 xyz, System.Boolean w) { }
        // RVA: 0x03D78A40  token: 0x6000063
        public static Unity.Mathematics.bool4 bool4(Unity.Mathematics.bool4 xyzw) { }
        // RVA: 0x03D78A00  token: 0x6000064
        public static Unity.Mathematics.bool4 bool4(System.Boolean v) { }
        // RVA: 0x04D356BC  token: 0x6000065
        public static System.UInt32 hash(Unity.Mathematics.bool4 v) { }
        // RVA: 0x09C3C174  token: 0x6000066
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.bool4 v) { }
        // RVA: 0x04D580C8  token: 0x6000067
        public static System.Boolean shuffle(Unity.Mathematics.bool4 left, Unity.Mathematics.bool4 right, Unity.Mathematics.math.ShuffleComponent x) { }
        // RVA: 0x04D59D90  token: 0x6000068
        public static Unity.Mathematics.bool2 shuffle(Unity.Mathematics.bool4 left, Unity.Mathematics.bool4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y) { }
        // RVA: 0x04D59868  token: 0x6000069
        public static Unity.Mathematics.bool3 shuffle(Unity.Mathematics.bool4 left, Unity.Mathematics.bool4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z) { }
        // RVA: 0x04D58F28  token: 0x600006A
        public static Unity.Mathematics.bool4 shuffle(Unity.Mathematics.bool4 left, Unity.Mathematics.bool4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w) { }
        // RVA: 0x04D57568  token: 0x600006B
        private static System.Boolean select_shuffle_component(Unity.Mathematics.bool4 a, Unity.Mathematics.bool4 b, Unity.Mathematics.math.ShuffleComponent component) { }
        // RVA: 0x03D78AF0  token: 0x600006C
        public static Unity.Mathematics.bool4x2 bool4x2(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1) { }
        // RVA: 0x09C2ED68  token: 0x600006D
        public static Unity.Mathematics.bool4x2 bool4x2(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11, System.Boolean m20, System.Boolean m21, System.Boolean m30, System.Boolean m31) { }
        // RVA: 0x09C2EDC0  token: 0x600006E
        public static Unity.Mathematics.bool4x2 bool4x2(System.Boolean v) { }
        // RVA: 0x09C567F4  token: 0x600006F
        public static Unity.Mathematics.bool2x4 transpose(Unity.Mathematics.bool4x2 v) { }
        // RVA: 0x04D349A8  token: 0x6000070
        public static System.UInt32 hash(Unity.Mathematics.bool4x2 v) { }
        // RVA: 0x04D399DC  token: 0x6000071
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.bool4x2 v) { }
        // RVA: 0x03D78B00  token: 0x6000072
        public static Unity.Mathematics.bool4x3 bool4x3(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1, Unity.Mathematics.bool4 c2) { }
        // RVA: 0x04D2D7F4  token: 0x6000073
        public static Unity.Mathematics.bool4x3 bool4x3(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m30, System.Boolean m31, System.Boolean m32) { }
        // RVA: 0x09C2EDE4  token: 0x6000074
        public static Unity.Mathematics.bool4x3 bool4x3(System.Boolean v) { }
        // RVA: 0x09C5764C  token: 0x6000075
        public static Unity.Mathematics.bool3x4 transpose(Unity.Mathematics.bool4x3 v) { }
        // RVA: 0x04D35764  token: 0x6000076
        public static System.UInt32 hash(Unity.Mathematics.bool4x3 v) { }
        // RVA: 0x04D39170  token: 0x6000077
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.bool4x3 v) { }
        // RVA: 0x03D78B10  token: 0x6000078
        public static Unity.Mathematics.bool4x4 bool4x4(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1, Unity.Mathematics.bool4 c2, Unity.Mathematics.bool4 c3) { }
        // RVA: 0x04D2D870  token: 0x6000079
        public static Unity.Mathematics.bool4x4 bool4x4(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m23, System.Boolean m30, System.Boolean m31, System.Boolean m32, System.Boolean m33) { }
        // RVA: 0x09C2EE00  token: 0x600007A
        public static Unity.Mathematics.bool4x4 bool4x4(System.Boolean v) { }
        // RVA: 0x09C56764  token: 0x600007B
        public static Unity.Mathematics.bool4x4 transpose(Unity.Mathematics.bool4x4 v) { }
        // RVA: 0x04D369F0  token: 0x600007C
        public static System.UInt32 hash(Unity.Mathematics.bool4x4 v) { }
        // RVA: 0x04D3AC60  token: 0x600007D
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.bool4x4 v) { }
        // RVA: 0x03D79DD0  token: 0x600007E
        public static Unity.Mathematics.double2 double2(System.Double x, System.Double y) { }
        // RVA: 0x03D79EE0  token: 0x600007F
        public static Unity.Mathematics.double2 double2(Unity.Mathematics.double2 xy) { }
        // RVA: 0x03D79F00  token: 0x6000080
        public static Unity.Mathematics.double2 double2(System.Double v) { }
        // RVA: 0x09C30B30  token: 0x6000081
        public static Unity.Mathematics.double2 double2(System.Boolean v) { }
        // RVA: 0x09C30AD8  token: 0x6000082
        public static Unity.Mathematics.double2 double2(Unity.Mathematics.bool2 v) { }
        // RVA: 0x03D79EA0  token: 0x6000083
        public static Unity.Mathematics.double2 double2(System.Int32 v) { }
        // RVA: 0x03D79E40  token: 0x6000084
        public static Unity.Mathematics.double2 double2(Unity.Mathematics.int2 v) { }
        // RVA: 0x03D79DE0  token: 0x6000085
        public static Unity.Mathematics.double2 double2(System.UInt32 v) { }
        // RVA: 0x03D79E70  token: 0x6000086
        public static Unity.Mathematics.double2 double2(Unity.Mathematics.uint2 v) { }
        // RVA: 0x09C30A98  token: 0x6000087
        public static Unity.Mathematics.double2 double2(Unity.Mathematics.half v) { }
        // RVA: 0x09C30AF0  token: 0x6000088
        public static Unity.Mathematics.double2 double2(Unity.Mathematics.half2 v) { }
        // RVA: 0x03D79EC0  token: 0x6000089
        public static Unity.Mathematics.double2 double2(System.Single v) { }
        // RVA: 0x03D79E10  token: 0x600008A
        public static Unity.Mathematics.double2 double2(Unity.Mathematics.float2 v) { }
        // RVA: 0x09C372A8  token: 0x600008B
        public static System.UInt32 hash(Unity.Mathematics.double2 v) { }
        // RVA: 0x09C3B21C  token: 0x600008C
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.double2 v) { }
        // RVA: 0x09C54664  token: 0x600008D
        public static System.Double shuffle(Unity.Mathematics.double2 left, Unity.Mathematics.double2 right, Unity.Mathematics.math.ShuffleComponent x) { }
        // RVA: 0x09C5405C  token: 0x600008E
        public static Unity.Mathematics.double2 shuffle(Unity.Mathematics.double2 left, Unity.Mathematics.double2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y) { }
        // RVA: 0x09C54598  token: 0x600008F
        public static Unity.Mathematics.double3 shuffle(Unity.Mathematics.double2 left, Unity.Mathematics.double2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z) { }
        // RVA: 0x09C54764  token: 0x6000090
        public static Unity.Mathematics.double4 shuffle(Unity.Mathematics.double2 left, Unity.Mathematics.double2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w) { }
        // RVA: 0x04D57474  token: 0x6000091
        private static System.Double select_shuffle_component(Unity.Mathematics.double2 a, Unity.Mathematics.double2 b, Unity.Mathematics.math.ShuffleComponent component) { }
        // RVA: 0x03D79F10  token: 0x6000092
        public static Unity.Mathematics.double2x2 double2x2(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1) { }
        // RVA: 0x04D2F8D4  token: 0x6000093
        public static Unity.Mathematics.double2x2 double2x2(System.Double m00, System.Double m01, System.Double m10, System.Double m11) { }
        // RVA: 0x09C30B68  token: 0x6000094
        public static Unity.Mathematics.double2x2 double2x2(System.Double v) { }
        // RVA: 0x09C30C58  token: 0x6000095
        public static Unity.Mathematics.double2x2 double2x2(System.Boolean v) { }
        // RVA: 0x09C30B84  token: 0x6000096
        public static Unity.Mathematics.double2x2 double2x2(Unity.Mathematics.bool2x2 v) { }
        // RVA: 0x09C30BE8  token: 0x6000097
        public static Unity.Mathematics.double2x2 double2x2(System.Int32 v) { }
        // RVA: 0x09C30C04  token: 0x6000098
        public static Unity.Mathematics.double2x2 double2x2(Unity.Mathematics.int2x2 v) { }
        // RVA: 0x09C30BA4  token: 0x6000099
        public static Unity.Mathematics.double2x2 double2x2(System.UInt32 v) { }
        // RVA: 0x09C30C2C  token: 0x600009A
        public static Unity.Mathematics.double2x2 double2x2(Unity.Mathematics.uint2x2 v) { }
        // RVA: 0x09C30B4C  token: 0x600009B
        public static Unity.Mathematics.double2x2 double2x2(System.Single v) { }
        // RVA: 0x09C30BC0  token: 0x600009C
        public static Unity.Mathematics.double2x2 double2x2(Unity.Mathematics.float2x2 v) { }
        // RVA: 0x09C56C80  token: 0x600009D
        public static Unity.Mathematics.double2x2 transpose(Unity.Mathematics.double2x2 v) { }
        // RVA: 0x09C3D748  token: 0x600009E
        public static Unity.Mathematics.double2x2 inverse(Unity.Mathematics.double2x2 m) { }
        // RVA: 0x03D79C10  token: 0x600009F
        public static System.Double determinant(Unity.Mathematics.double2x2 m) { }
        // RVA: 0x09C372F0  token: 0x60000A0
        public static System.UInt32 hash(Unity.Mathematics.double2x2 v) { }
        // RVA: 0x09C3C0DC  token: 0x60000A1
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.double2x2 v) { }
        // RVA: 0x03D79F40  token: 0x60000A2
        public static Unity.Mathematics.double2x3 double2x3(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1, Unity.Mathematics.double2 c2) { }
        // RVA: 0x04D2F8FC  token: 0x60000A3
        public static Unity.Mathematics.double2x3 double2x3(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12) { }
        // RVA: 0x09C30CB4  token: 0x60000A4
        public static Unity.Mathematics.double2x3 double2x3(System.Double v) { }
        // RVA: 0x09C30D0C  token: 0x60000A5
        public static Unity.Mathematics.double2x3 double2x3(System.Boolean v) { }
        // RVA: 0x09C30D88  token: 0x60000A6
        public static Unity.Mathematics.double2x3 double2x3(Unity.Mathematics.bool2x3 v) { }
        // RVA: 0x09C30D2C  token: 0x60000A7
        public static Unity.Mathematics.double2x3 double2x3(System.Int32 v) { }
        // RVA: 0x09C30DC4  token: 0x60000A8
        public static Unity.Mathematics.double2x3 double2x3(Unity.Mathematics.int2x3 v) { }
        // RVA: 0x09C30C74  token: 0x60000A9
        public static Unity.Mathematics.double2x3 double2x3(System.UInt32 v) { }
        // RVA: 0x09C30D4C  token: 0x60000AA
        public static Unity.Mathematics.double2x3 double2x3(Unity.Mathematics.uint2x3 v) { }
        // RVA: 0x09C30C94  token: 0x60000AB
        public static Unity.Mathematics.double2x3 double2x3(System.Single v) { }
        // RVA: 0x09C30CD4  token: 0x60000AC
        public static Unity.Mathematics.double2x3 double2x3(Unity.Mathematics.float2x3 v) { }
        // RVA: 0x09C575F8  token: 0x60000AD
        public static Unity.Mathematics.double3x2 transpose(Unity.Mathematics.double2x3 v) { }
        // RVA: 0x09C3656C  token: 0x60000AE
        public static System.UInt32 hash(Unity.Mathematics.double2x3 v) { }
        // RVA: 0x09C3BEE8  token: 0x60000AF
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.double2x3 v) { }
        // RVA: 0x03D79F90  token: 0x60000B0
        public static Unity.Mathematics.double2x4 double2x4(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1, Unity.Mathematics.double2 c2, Unity.Mathematics.double2 c3) { }
        // RVA: 0x04D2F9E4  token: 0x60000B1
        public static Unity.Mathematics.double2x4 double2x4(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13) { }
        // RVA: 0x09C30EC0  token: 0x60000B2
        public static Unity.Mathematics.double2x4 double2x4(System.Double v) { }
        // RVA: 0x09C30DFC  token: 0x60000B3
        public static Unity.Mathematics.double2x4 double2x4(System.Boolean v) { }
        // RVA: 0x09C30E5C  token: 0x60000B4
        public static Unity.Mathematics.double2x4 double2x4(Unity.Mathematics.bool2x4 v) { }
        // RVA: 0x09C30F68  token: 0x60000B5
        public static Unity.Mathematics.double2x4 double2x4(System.Int32 v) { }
        // RVA: 0x09C30E84  token: 0x60000B6
        public static Unity.Mathematics.double2x4 double2x4(Unity.Mathematics.int2x4 v) { }
        // RVA: 0x09C30F08  token: 0x60000B7
        public static Unity.Mathematics.double2x4 double2x4(System.UInt32 v) { }
        // RVA: 0x09C30E20  token: 0x60000B8
        public static Unity.Mathematics.double2x4 double2x4(Unity.Mathematics.uint2x4 v) { }
        // RVA: 0x09C30EE4  token: 0x60000B9
        public static Unity.Mathematics.double2x4 double2x4(System.Single v) { }
        // RVA: 0x09C30F2C  token: 0x60000BA
        public static Unity.Mathematics.double2x4 double2x4(Unity.Mathematics.float2x4 v) { }
        // RVA: 0x09C56A34  token: 0x60000BB
        public static Unity.Mathematics.double4x2 transpose(Unity.Mathematics.double2x4 v) { }
        // RVA: 0x09C36BF0  token: 0x60000BC
        public static System.UInt32 hash(Unity.Mathematics.double2x4 v) { }
        // RVA: 0x09C3C674  token: 0x60000BD
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.double2x4 v) { }
        // RVA: 0x03D7A0A0  token: 0x60000BE
        public static Unity.Mathematics.double3 double3(System.Double x, System.Double y, System.Double z) { }
        // RVA: 0x03D7A1B0  token: 0x60000BF
        public static Unity.Mathematics.double3 double3(System.Double x, Unity.Mathematics.double2 yz) { }
        // RVA: 0x03D7A0D0  token: 0x60000C0
        public static Unity.Mathematics.double3 double3(Unity.Mathematics.double2 xy, System.Double z) { }
        // RVA: 0x03D7A150  token: 0x60000C1
        public static Unity.Mathematics.double3 double3(Unity.Mathematics.double3 xyz) { }
        // RVA: 0x03D7A0C0  token: 0x60000C2
        public static Unity.Mathematics.double3 double3(System.Double v) { }
        // RVA: 0x09C31024  token: 0x60000C3
        public static Unity.Mathematics.double3 double3(System.Boolean v) { }
        // RVA: 0x09C30FF0  token: 0x60000C4
        public static Unity.Mathematics.double3 double3(Unity.Mathematics.bool3 v) { }
        // RVA: 0x03D7A180  token: 0x60000C5
        public static Unity.Mathematics.double3 double3(System.Int32 v) { }
        // RVA: 0x03D7A020  token: 0x60000C6
        public static Unity.Mathematics.double3 double3(Unity.Mathematics.int3 v) { }
        // RVA: 0x03D7A070  token: 0x60000C7
        public static Unity.Mathematics.double3 double3(System.UInt32 v) { }
        // RVA: 0x03D7A0F0  token: 0x60000C8
        public static Unity.Mathematics.double3 double3(Unity.Mathematics.uint3 v) { }
        // RVA: 0x09C31044  token: 0x60000C9
        public static Unity.Mathematics.double3 double3(Unity.Mathematics.half v) { }
        // RVA: 0x09C30F8C  token: 0x60000CA
        public static Unity.Mathematics.double3 double3(Unity.Mathematics.half3 v) { }
        // RVA: 0x03D79FF0  token: 0x60000CB
        public static Unity.Mathematics.double3 double3(System.Single v) { }
        // RVA: 0x0337F9A0  token: 0x60000CC
        public static Unity.Mathematics.double3 double3(Unity.Mathematics.float3 v) { }
        // RVA: 0x09C37630  token: 0x60000CD
        public static System.UInt32 hash(Unity.Mathematics.double3 v) { }
        // RVA: 0x09C3A2FC  token: 0x60000CE
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.double3 v) { }
        // RVA: 0x09C54910  token: 0x60000CF
        public static System.Double shuffle(Unity.Mathematics.double3 left, Unity.Mathematics.double3 right, Unity.Mathematics.math.ShuffleComponent x) { }
        // RVA: 0x09C53C14  token: 0x60000D0
        public static Unity.Mathematics.double2 shuffle(Unity.Mathematics.double3 left, Unity.Mathematics.double3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y) { }
        // RVA: 0x09C549B0  token: 0x60000D1
        public static Unity.Mathematics.double3 shuffle(Unity.Mathematics.double3 left, Unity.Mathematics.double3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z) { }
        // RVA: 0x09C53DBC  token: 0x60000D2
        public static Unity.Mathematics.double4 shuffle(Unity.Mathematics.double3 left, Unity.Mathematics.double3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w) { }
        // RVA: 0x09C53830  token: 0x60000D3
        private static System.Double select_shuffle_component(Unity.Mathematics.double3 a, Unity.Mathematics.double3 b, Unity.Mathematics.math.ShuffleComponent component) { }
        // RVA: 0x03D7A1D0  token: 0x60000D4
        public static Unity.Mathematics.double3x2 double3x2(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1) { }
        // RVA: 0x04D2FAF0  token: 0x60000D5
        public static Unity.Mathematics.double3x2 double3x2(System.Double m00, System.Double m01, System.Double m10, System.Double m11, System.Double m20, System.Double m21) { }
        // RVA: 0x09C310F4  token: 0x60000D6
        public static Unity.Mathematics.double3x2 double3x2(System.Double v) { }
        // RVA: 0x09C31150  token: 0x60000D7
        public static Unity.Mathematics.double3x2 double3x2(System.Boolean v) { }
        // RVA: 0x09C31174  token: 0x60000D8
        public static Unity.Mathematics.double3x2 double3x2(Unity.Mathematics.bool3x2 v) { }
        // RVA: 0x09C3120C  token: 0x60000D9
        public static Unity.Mathematics.double3x2 double3x2(System.Int32 v) { }
        // RVA: 0x09C311B0  token: 0x60000DA
        public static Unity.Mathematics.double3x2 double3x2(Unity.Mathematics.int3x2 v) { }
        // RVA: 0x09C31098  token: 0x60000DB
        public static Unity.Mathematics.double3x2 double3x2(System.UInt32 v) { }
        // RVA: 0x09C31114  token: 0x60000DC
        public static Unity.Mathematics.double3x2 double3x2(Unity.Mathematics.uint3x2 v) { }
        // RVA: 0x09C311EC  token: 0x60000DD
        public static Unity.Mathematics.double3x2 double3x2(System.Single v) { }
        // RVA: 0x09C310B8  token: 0x60000DE
        public static Unity.Mathematics.double3x2 double3x2(Unity.Mathematics.float3x2 v) { }
        // RVA: 0x09C56B9C  token: 0x60000DF
        public static Unity.Mathematics.double2x3 transpose(Unity.Mathematics.double3x2 v) { }
        // RVA: 0x09C35A88  token: 0x60000E0
        public static System.UInt32 hash(Unity.Mathematics.double3x2 v) { }
        // RVA: 0x09C38F4C  token: 0x60000E1
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.double3x2 v) { }
        // RVA: 0x03D7A200  token: 0x60000E2
        public static Unity.Mathematics.double3x3 double3x3(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1, Unity.Mathematics.double3 c2) { }
        // RVA: 0x04D2FBD0  token: 0x60000E3
        public static Unity.Mathematics.double3x3 double3x3(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12, System.Double m20, System.Double m21, System.Double m22) { }
        // RVA: 0x09C313CC  token: 0x60000E4
        public static Unity.Mathematics.double3x3 double3x3(System.Double v) { }
        // RVA: 0x09C31350  token: 0x60000E5
        public static Unity.Mathematics.double3x3 double3x3(System.Boolean v) { }
        // RVA: 0x04D2FB38  token: 0x60000E6
        public static Unity.Mathematics.double3x3 double3x3(Unity.Mathematics.bool3x3 v) { }
        // RVA: 0x09C31324  token: 0x60000E7
        public static Unity.Mathematics.double3x3 double3x3(System.Int32 v) { }
        // RVA: 0x09C312D4  token: 0x60000E8
        public static Unity.Mathematics.double3x3 double3x3(Unity.Mathematics.int3x3 v) { }
        // RVA: 0x09C312A8  token: 0x60000E9
        public static Unity.Mathematics.double3x3 double3x3(System.UInt32 v) { }
        // RVA: 0x09C3137C  token: 0x60000EA
        public static Unity.Mathematics.double3x3 double3x3(Unity.Mathematics.uint3x3 v) { }
        // RVA: 0x09C3122C  token: 0x60000EB
        public static Unity.Mathematics.double3x3 double3x3(System.Single v) { }
        // RVA: 0x09C31258  token: 0x60000EC
        public static Unity.Mathematics.double3x3 double3x3(Unity.Mathematics.float3x3 v) { }
        // RVA: 0x09C56D48  token: 0x60000ED
        public static Unity.Mathematics.double3x3 transpose(Unity.Mathematics.double3x3 v) { }
        // RVA: 0x09C3EADC  token: 0x60000EE
        public static Unity.Mathematics.double3x3 inverse(Unity.Mathematics.double3x3 m) { }
        // RVA: 0x03D79570  token: 0x60000EF
        public static System.Double determinant(Unity.Mathematics.double3x3 m) { }
        // RVA: 0x09C36F8C  token: 0x60000F0
        public static System.UInt32 hash(Unity.Mathematics.double3x3 v) { }
        // RVA: 0x09C3BA2C  token: 0x60000F1
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.double3x3 v) { }
        // RVA: 0x03D7A240  token: 0x60000F2
        public static Unity.Mathematics.double3x4 double3x4(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1, Unity.Mathematics.double3 c2, Unity.Mathematics.double3 c3) { }
        // RVA: 0x04D2FD68  token: 0x60000F3
        public static Unity.Mathematics.double3x4 double3x4(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13, System.Double m20, System.Double m21, System.Double m22, System.Double m23) { }
        // RVA: 0x09C313F8  token: 0x60000F4
        public static Unity.Mathematics.double3x4 double3x4(System.Double v) { }
        // RVA: 0x09C31598  token: 0x60000F5
        public static Unity.Mathematics.double3x4 double3x4(System.Boolean v) { }
        // RVA: 0x04D2FF90  token: 0x60000F6
        public static Unity.Mathematics.double3x4 double3x4(Unity.Mathematics.bool3x4 v) { }
        // RVA: 0x09C31424  token: 0x60000F7
        public static Unity.Mathematics.double3x4 double3x4(System.Int32 v) { }
        // RVA: 0x09C314A0  token: 0x60000F8
        public static Unity.Mathematics.double3x4 double3x4(Unity.Mathematics.int3x4 v) { }
        // RVA: 0x09C3151C  token: 0x60000F9
        public static Unity.Mathematics.double3x4 double3x4(System.UInt32 v) { }
        // RVA: 0x09C31548  token: 0x60000FA
        public static Unity.Mathematics.double3x4 double3x4(Unity.Mathematics.uint3x4 v) { }
        // RVA: 0x09C314F0  token: 0x60000FB
        public static Unity.Mathematics.double3x4 double3x4(System.Single v) { }
        // RVA: 0x09C31450  token: 0x60000FC
        public static Unity.Mathematics.double3x4 double3x4(Unity.Mathematics.float3x4 v) { }
        // RVA: 0x09C5745C  token: 0x60000FD
        public static Unity.Mathematics.double4x3 transpose(Unity.Mathematics.double3x4 v) { }
        // RVA: 0x09C33AA8  token: 0x60000FE
        public static Unity.Mathematics.double3x4 fastinverse(Unity.Mathematics.double3x4 m) { }
        // RVA: 0x09C35BB4  token: 0x60000FF
        public static System.UInt32 hash(Unity.Mathematics.double3x4 v) { }
        // RVA: 0x09C3B274  token: 0x6000100
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.double3x4 v) { }
        // RVA: 0x03D7A370  token: 0x6000101
        public static Unity.Mathematics.double4 double4(System.Double x, System.Double y, System.Double z, System.Double w) { }
        // RVA: 0x03D7A290  token: 0x6000102
        public static Unity.Mathematics.double4 double4(System.Double x, System.Double y, Unity.Mathematics.double2 zw) { }
        // RVA: 0x03D7A2B0  token: 0x6000103
        public static Unity.Mathematics.double4 double4(System.Double x, Unity.Mathematics.double2 yz, System.Double w) { }
        // RVA: 0x03D7A3C0  token: 0x6000104
        public static Unity.Mathematics.double4 double4(System.Double x, Unity.Mathematics.double3 yzw) { }
        // RVA: 0x03D7A420  token: 0x6000105
        public static Unity.Mathematics.double4 double4(Unity.Mathematics.double2 xy, System.Double z, System.Double w) { }
        // RVA: 0x03D7A390  token: 0x6000106
        public static Unity.Mathematics.double4 double4(Unity.Mathematics.double2 xy, Unity.Mathematics.double2 zw) { }
        // RVA: 0x03D7A300  token: 0x6000107
        public static Unity.Mathematics.double4 double4(Unity.Mathematics.double3 xyz, System.Double w) { }
        // RVA: 0x09C31608  token: 0x6000108
        public static Unity.Mathematics.double4 double4(Unity.Mathematics.double4 xyzw) { }
        // RVA: 0x03D7A2D0  token: 0x6000109
        public static Unity.Mathematics.double4 double4(System.Double v) { }
        // RVA: 0x09C3167C  token: 0x600010A
        public static Unity.Mathematics.double4 double4(System.Boolean v) { }
        // RVA: 0x09C315EC  token: 0x600010B
        public static Unity.Mathematics.double4 double4(Unity.Mathematics.bool4 v) { }
        // RVA: 0x03D7A330  token: 0x600010C
        public static Unity.Mathematics.double4 double4(System.Int32 v) { }
        // RVA: 0x09C31698  token: 0x600010D
        public static Unity.Mathematics.double4 double4(Unity.Mathematics.int4 v) { }
        // RVA: 0x03D7A3F0  token: 0x600010E
        public static Unity.Mathematics.double4 double4(System.UInt32 v) { }
        // RVA: 0x09C316C0  token: 0x600010F
        public static Unity.Mathematics.double4 double4(Unity.Mathematics.uint4 v) { }
        // RVA: 0x09C31630  token: 0x6000110
        public static Unity.Mathematics.double4 double4(Unity.Mathematics.half v) { }
        // RVA: 0x09C315C8  token: 0x6000111
        public static Unity.Mathematics.double4 double4(Unity.Mathematics.half4 v) { }
        // RVA: 0x03D7A2E0  token: 0x6000112
        public static Unity.Mathematics.double4 double4(System.Single v) { }
        // RVA: 0x09C31654  token: 0x6000113
        public static Unity.Mathematics.double4 double4(Unity.Mathematics.float4 v) { }
        // RVA: 0x09C36424  token: 0x6000114
        public static System.UInt32 hash(Unity.Mathematics.double4 v) { }
        // RVA: 0x09C399A8  token: 0x6000115
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.double4 v) { }
        // RVA: 0x09C5485C  token: 0x6000116
        public static System.Double shuffle(Unity.Mathematics.double4 left, Unity.Mathematics.double4 right, Unity.Mathematics.math.ShuffleComponent x) { }
        // RVA: 0x09C540C8  token: 0x6000117
        public static Unity.Mathematics.double2 shuffle(Unity.Mathematics.double4 left, Unity.Mathematics.double4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y) { }
        // RVA: 0x09C54168  token: 0x6000118
        public static Unity.Mathematics.double3 shuffle(Unity.Mathematics.double4 left, Unity.Mathematics.double4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z) { }
        // RVA: 0x09C53F28  token: 0x6000119
        public static Unity.Mathematics.double4 shuffle(Unity.Mathematics.double4 left, Unity.Mathematics.double4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w) { }
        // RVA: 0x09C536FC  token: 0x600011A
        private static System.Double select_shuffle_component(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b, Unity.Mathematics.math.ShuffleComponent component) { }
        // RVA: 0x03D7A440  token: 0x600011B
        public static Unity.Mathematics.double4x2 double4x2(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1) { }
        // RVA: 0x04D300BC  token: 0x600011C
        public static Unity.Mathematics.double4x2 double4x2(System.Double m00, System.Double m01, System.Double m10, System.Double m11, System.Double m20, System.Double m21, System.Double m30, System.Double m31) { }
        // RVA: 0x09C31748  token: 0x600011D
        public static Unity.Mathematics.double4x2 double4x2(System.Double v) { }
        // RVA: 0x09C31790  token: 0x600011E
        public static Unity.Mathematics.double4x2 double4x2(System.Boolean v) { }
        // RVA: 0x09C31818  token: 0x600011F
        public static Unity.Mathematics.double4x2 double4x2(Unity.Mathematics.bool4x2 v) { }
        // RVA: 0x09C3176C  token: 0x6000120
        public static Unity.Mathematics.double4x2 double4x2(System.Int32 v) { }
        // RVA: 0x09C3170C  token: 0x6000121
        public static Unity.Mathematics.double4x2 double4x2(Unity.Mathematics.int4x2 v) { }
        // RVA: 0x09C317B4  token: 0x6000122
        public static Unity.Mathematics.double4x2 double4x2(System.UInt32 v) { }
        // RVA: 0x09C31840  token: 0x6000123
        public static Unity.Mathematics.double4x2 double4x2(Unity.Mathematics.uint4x2 v) { }
        // RVA: 0x09C316E8  token: 0x6000124
        public static Unity.Mathematics.double4x2 double4x2(System.Single v) { }
        // RVA: 0x09C317DC  token: 0x6000125
        public static Unity.Mathematics.double4x2 double4x2(Unity.Mathematics.float4x2 v) { }
        // RVA: 0x09C56BF0  token: 0x6000126
        public static Unity.Mathematics.double2x4 transpose(Unity.Mathematics.double4x2 v) { }
        // RVA: 0x09C37B64  token: 0x6000127
        public static System.UInt32 hash(Unity.Mathematics.double4x2 v) { }
        // RVA: 0x09C3A3A0  token: 0x6000128
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.double4x2 v) { }
        // RVA: 0x03D7A470  token: 0x6000129
        public static Unity.Mathematics.double4x3 double4x3(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1, Unity.Mathematics.double4 c2) { }
        // RVA: 0x04D30200  token: 0x600012A
        public static Unity.Mathematics.double4x3 double4x3(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12, System.Double m20, System.Double m21, System.Double m22, System.Double m30, System.Double m31, System.Double m32) { }
        // RVA: 0x09C318CC  token: 0x600012B
        public static Unity.Mathematics.double4x3 double4x3(System.Double v) { }
        // RVA: 0x09C319A4  token: 0x600012C
        public static Unity.Mathematics.double4x3 double4x3(System.Boolean v) { }
        // RVA: 0x04D301B8  token: 0x600012D
        public static Unity.Mathematics.double4x3 double4x3(Unity.Mathematics.bool4x3 v) { }
        // RVA: 0x09C318F8  token: 0x600012E
        public static Unity.Mathematics.double4x3 double4x3(System.Int32 v) { }
        // RVA: 0x09C31954  token: 0x600012F
        public static Unity.Mathematics.double4x3 double4x3(Unity.Mathematics.int4x3 v) { }
        // RVA: 0x09C31924  token: 0x6000130
        public static Unity.Mathematics.double4x3 double4x3(System.UInt32 v) { }
        // RVA: 0x09C3187C  token: 0x6000131
        public static Unity.Mathematics.double4x3 double4x3(Unity.Mathematics.uint4x3 v) { }
        // RVA: 0x09C319D0  token: 0x6000132
        public static Unity.Mathematics.double4x3 double4x3(System.Single v) { }
        // RVA: 0x09C319FC  token: 0x6000133
        public static Unity.Mathematics.double4x3 double4x3(Unity.Mathematics.float4x3 v) { }
        // RVA: 0x09C571B8  token: 0x6000134
        public static Unity.Mathematics.double3x4 transpose(Unity.Mathematics.double4x3 v) { }
        // RVA: 0x09C37970  token: 0x6000135
        public static System.UInt32 hash(Unity.Mathematics.double4x3 v) { }
        // RVA: 0x09C39FC4  token: 0x6000136
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.double4x3 v) { }
        // RVA: 0x03D7A4B0  token: 0x6000137
        public static Unity.Mathematics.double4x4 double4x4(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1, Unity.Mathematics.double4 c2, Unity.Mathematics.double4 c3) { }
        // RVA: 0x04D30518  token: 0x6000138
        public static Unity.Mathematics.double4x4 double4x4(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13, System.Double m20, System.Double m21, System.Double m22, System.Double m23, System.Double m30, System.Double m31, System.Double m32, System.Double m33) { }
        // RVA: 0x09C31A84  token: 0x6000139
        public static Unity.Mathematics.double4x4 double4x4(System.Double v) { }
        // RVA: 0x09C31AB8  token: 0x600013A
        public static Unity.Mathematics.double4x4 double4x4(System.Boolean v) { }
        // RVA: 0x09C31C34  token: 0x600013B
        public static Unity.Mathematics.double4x4 double4x4(Unity.Mathematics.bool4x4 v) { }
        // RVA: 0x09C31C78  token: 0x600013C
        public static Unity.Mathematics.double4x4 double4x4(System.Int32 v) { }
        // RVA: 0x09C31AEC  token: 0x600013D
        public static Unity.Mathematics.double4x4 double4x4(Unity.Mathematics.int4x4 v) { }
        // RVA: 0x09C31A4C  token: 0x600013E
        public static Unity.Mathematics.double4x4 double4x4(System.UInt32 v) { }
        // RVA: 0x09C31B48  token: 0x600013F
        public static Unity.Mathematics.double4x4 double4x4(Unity.Mathematics.uint4x4 v) { }
        // RVA: 0x09C31C00  token: 0x6000140
        public static Unity.Mathematics.double4x4 double4x4(System.Single v) { }
        // RVA: 0x09C31BA4  token: 0x6000141
        public static Unity.Mathematics.double4x4 double4x4(Unity.Mathematics.float4x4 v) { }
        // RVA: 0x09C52A48  token: 0x6000142
        public static Unity.Mathematics.double3 rotate(Unity.Mathematics.double4x4 a, Unity.Mathematics.double3 b) { }
        // RVA: 0x09C564E4  token: 0x6000143
        public static Unity.Mathematics.double3 transform(Unity.Mathematics.double4x4 a, Unity.Mathematics.double3 b) { }
        // RVA: 0x09C56E94  token: 0x6000144
        public static Unity.Mathematics.double4x4 transpose(Unity.Mathematics.double4x4 v) { }
        // RVA: 0x09C3DBC8  token: 0x6000145
        public static Unity.Mathematics.double4x4 inverse(Unity.Mathematics.double4x4 m) { }
        // RVA: 0x09C33428  token: 0x6000146
        public static Unity.Mathematics.double4x4 fastinverse(Unity.Mathematics.double4x4 m) { }
        // RVA: 0x03D79300  token: 0x6000147
        public static System.Double determinant(Unity.Mathematics.double4x4 m) { }
        // RVA: 0x09C36218  token: 0x6000148
        public static System.UInt32 hash(Unity.Mathematics.double4x4 v) { }
        // RVA: 0x09C3908C  token: 0x6000149
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.double4x4 v) { }
        // RVA: 0x03D7A720  token: 0x600014A
        public static Unity.Mathematics.float2 float2(System.Single x, System.Single y) { }
        // RVA: 0x03D730E0  token: 0x600014B
        public static Unity.Mathematics.float2 float2(Unity.Mathematics.float2 xy) { }
        // RVA: 0x03D543C0  token: 0x600014C
        public static Unity.Mathematics.float2 float2(System.Single v) { }
        // RVA: 0x09C33DE0  token: 0x600014D
        public static Unity.Mathematics.float2 float2(System.Boolean v) { }
        // RVA: 0x09C33E00  token: 0x600014E
        public static Unity.Mathematics.float2 float2(Unity.Mathematics.bool2 v) { }
        // RVA: 0x03D7A730  token: 0x600014F
        public static Unity.Mathematics.float2 float2(System.Int32 v) { }
        // RVA: 0x03D7A750  token: 0x6000150
        public static Unity.Mathematics.float2 float2(Unity.Mathematics.int2 v) { }
        // RVA: 0x03D7A7A0  token: 0x6000151
        public static Unity.Mathematics.float2 float2(System.UInt32 v) { }
        // RVA: 0x03D7A770  token: 0x6000152
        public static Unity.Mathematics.float2 float2(Unity.Mathematics.uint2 v) { }
        // RVA: 0x09C33E50  token: 0x6000153
        public static Unity.Mathematics.float2 float2(Unity.Mathematics.half v) { }
        // RVA: 0x09C33E24  token: 0x6000154
        public static Unity.Mathematics.float2 float2(Unity.Mathematics.half2 v) { }
        // RVA: 0x03D7A7D0  token: 0x6000155
        public static Unity.Mathematics.float2 float2(System.Double v) { }
        // RVA: 0x03D7A700  token: 0x6000156
        public static Unity.Mathematics.float2 float2(Unity.Mathematics.double2 v) { }
        // RVA: 0x09C35A50  token: 0x6000157
        public static System.UInt32 hash(Unity.Mathematics.float2 v) { }
        // RVA: 0x09C3C098  token: 0x6000158
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.float2 v) { }
        // RVA: 0x04D5898C  token: 0x6000159
        public static System.Single shuffle(Unity.Mathematics.float2 left, Unity.Mathematics.float2 right, Unity.Mathematics.math.ShuffleComponent x) { }
        // RVA: 0x04D59134  token: 0x600015A
        public static Unity.Mathematics.float2 shuffle(Unity.Mathematics.float2 left, Unity.Mathematics.float2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y) { }
        // RVA: 0x04D59328  token: 0x600015B
        public static Unity.Mathematics.float3 shuffle(Unity.Mathematics.float2 left, Unity.Mathematics.float2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z) { }
        // RVA: 0x04D58B70  token: 0x600015C
        public static Unity.Mathematics.float4 shuffle(Unity.Mathematics.float2 left, Unity.Mathematics.float2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w) { }
        // RVA: 0x04D57BE4  token: 0x600015D
        private static System.Single select_shuffle_component(Unity.Mathematics.float2 a, Unity.Mathematics.float2 b, Unity.Mathematics.math.ShuffleComponent component) { }
        // RVA: 0x02232AA0  token: 0x600015E
        public static Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1) { }
        // RVA: 0x09C33E90  token: 0x600015F
        public static Unity.Mathematics.float2x2 float2x2(System.Single m00, System.Single m01, System.Single m10, System.Single m11) { }
        // RVA: 0x09C33E78  token: 0x6000160
        public static Unity.Mathematics.float2x2 float2x2(System.Single v) { }
        // RVA: 0x09C33F78  token: 0x6000161
        public static Unity.Mathematics.float2x2 float2x2(System.Boolean v) { }
        // RVA: 0x09C33F90  token: 0x6000162
        public static Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.bool2x2 v) { }
        // RVA: 0x09C33EDC  token: 0x6000163
        public static Unity.Mathematics.float2x2 float2x2(System.Int32 v) { }
        // RVA: 0x09C33F54  token: 0x6000164
        public static Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.int2x2 v) { }
        // RVA: 0x09C33F24  token: 0x6000165
        public static Unity.Mathematics.float2x2 float2x2(System.UInt32 v) { }
        // RVA: 0x09C33EB4  token: 0x6000166
        public static Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.uint2x2 v) { }
        // RVA: 0x09C33F3C  token: 0x6000167
        public static Unity.Mathematics.float2x2 float2x2(System.Double v) { }
        // RVA: 0x09C33EF4  token: 0x6000168
        public static Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.double2x2 v) { }
        // RVA: 0x09C56848  token: 0x6000169
        public static Unity.Mathematics.float2x2 transpose(Unity.Mathematics.float2x2 v) { }
        // RVA: 0x04D3B638  token: 0x600016A
        public static Unity.Mathematics.float2x2 inverse(Unity.Mathematics.float2x2 m) { }
        // RVA: 0x03D79C40  token: 0x600016B
        public static System.Single determinant(Unity.Mathematics.float2x2 m) { }
        // RVA: 0x09C380A0  token: 0x600016C
        public static System.UInt32 hash(Unity.Mathematics.float2x2 v) { }
        // RVA: 0x09C3C454  token: 0x600016D
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.float2x2 v) { }
        // RVA: 0x03D7A7F0  token: 0x600016E
        public static Unity.Mathematics.float2x3 float2x3(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1, Unity.Mathematics.float2 c2) { }
        // RVA: 0x04D31F5C  token: 0x600016F
        public static Unity.Mathematics.float2x3 float2x3(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12) { }
        // RVA: 0x09C33FAC  token: 0x6000170
        public static Unity.Mathematics.float2x3 float2x3(System.Single v) { }
        // RVA: 0x09C3400C  token: 0x6000171
        public static Unity.Mathematics.float2x3 float2x3(System.Boolean v) { }
        // RVA: 0x09C34068  token: 0x6000172
        public static Unity.Mathematics.float2x3 float2x3(Unity.Mathematics.bool2x3 v) { }
        // RVA: 0x09C340D4  token: 0x6000173
        public static Unity.Mathematics.float2x3 float2x3(System.Int32 v) { }
        // RVA: 0x09C340F4  token: 0x6000174
        public static Unity.Mathematics.float2x3 float2x3(Unity.Mathematics.int2x3 v) { }
        // RVA: 0x09C33FEC  token: 0x6000175
        public static Unity.Mathematics.float2x3 float2x3(System.UInt32 v) { }
        // RVA: 0x09C3409C  token: 0x6000176
        public static Unity.Mathematics.float2x3 float2x3(Unity.Mathematics.uint2x3 v) { }
        // RVA: 0x09C33FCC  token: 0x6000177
        public static Unity.Mathematics.float2x3 float2x3(System.Double v) { }
        // RVA: 0x09C3402C  token: 0x6000178
        public static Unity.Mathematics.float2x3 float2x3(Unity.Mathematics.double2x3 v) { }
        // RVA: 0x09C56FEC  token: 0x6000179
        public static Unity.Mathematics.float3x2 transpose(Unity.Mathematics.float2x3 v) { }
        // RVA: 0x09C36804  token: 0x600017A
        public static System.UInt32 hash(Unity.Mathematics.float2x3 v) { }
        // RVA: 0x09C3975C  token: 0x600017B
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.float2x3 v) { }
        // RVA: 0x03D7A800  token: 0x600017C
        public static Unity.Mathematics.float2x4 float2x4(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1, Unity.Mathematics.float2 c2, Unity.Mathematics.float2 c3) { }
        // RVA: 0x04D31FA0  token: 0x600017D
        public static Unity.Mathematics.float2x4 float2x4(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13) { }
        // RVA: 0x09C341E4  token: 0x600017E
        public static Unity.Mathematics.float2x4 float2x4(System.Single v) { }
        // RVA: 0x09C3412C  token: 0x600017F
        public static Unity.Mathematics.float2x4 float2x4(System.Boolean v) { }
        // RVA: 0x09C3418C  token: 0x6000180
        public static Unity.Mathematics.float2x4 float2x4(Unity.Mathematics.bool2x4 v) { }
        // RVA: 0x09C341C8  token: 0x6000181
        public static Unity.Mathematics.float2x4 float2x4(System.Int32 v) { }
        // RVA: 0x09C34250  token: 0x6000182
        public static Unity.Mathematics.float2x4 float2x4(Unity.Mathematics.int2x4 v) { }
        // RVA: 0x09C341AC  token: 0x6000183
        public static Unity.Mathematics.float2x4 float2x4(System.UInt32 v) { }
        // RVA: 0x09C3421C  token: 0x6000184
        public static Unity.Mathematics.float2x4 float2x4(Unity.Mathematics.uint2x4 v) { }
        // RVA: 0x09C34200  token: 0x6000185
        public static Unity.Mathematics.float2x4 float2x4(System.Double v) { }
        // RVA: 0x09C34148  token: 0x6000186
        public static Unity.Mathematics.float2x4 float2x4(Unity.Mathematics.double2x4 v) { }
        // RVA: 0x09C56DBC  token: 0x6000187
        public static Unity.Mathematics.float4x2 transpose(Unity.Mathematics.float2x4 v) { }
        // RVA: 0x09C3749C  token: 0x6000188
        public static System.UInt32 hash(Unity.Mathematics.float2x4 v) { }
        // RVA: 0x09C3ACB0  token: 0x6000189
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.float2x4 v) { }
        // RVA: 0x03D6D520  token: 0x600018A
        public static Unity.Mathematics.float3 float3(System.Single x, System.Single y, System.Single z) { }
        // RVA: 0x03D7A980  token: 0x600018B
        public static Unity.Mathematics.float3 float3(System.Single x, Unity.Mathematics.float2 yz) { }
        // RVA: 0x03D7A8C0  token: 0x600018C
        public static Unity.Mathematics.float3 float3(Unity.Mathematics.float2 xy, System.Single z) { }
        // RVA: 0x03D7A8F0  token: 0x600018D
        public static Unity.Mathematics.float3 float3(Unity.Mathematics.float3 xyz) { }
        // RVA: 0x03D54500  token: 0x600018E
        public static Unity.Mathematics.float3 float3(System.Single v) { }
        // RVA: 0x09C34284  token: 0x600018F
        public static Unity.Mathematics.float3 float3(System.Boolean v) { }
        // RVA: 0x09C34328  token: 0x6000190
        public static Unity.Mathematics.float3 float3(Unity.Mathematics.bool3 v) { }
        // RVA: 0x03D7A860  token: 0x6000191
        public static Unity.Mathematics.float3 float3(System.Int32 v) { }
        // RVA: 0x03D7A9F0  token: 0x6000192
        public static Unity.Mathematics.float3 float3(Unity.Mathematics.int3 v) { }
        // RVA: 0x03D7A9B0  token: 0x6000193
        public static Unity.Mathematics.float3 float3(System.UInt32 v) { }
        // RVA: 0x03D7A920  token: 0x6000194
        public static Unity.Mathematics.float3 float3(Unity.Mathematics.uint3 v) { }
        // RVA: 0x09C342A0  token: 0x6000195
        public static Unity.Mathematics.float3 float3(Unity.Mathematics.half v) { }
        // RVA: 0x09C342DC  token: 0x6000196
        public static Unity.Mathematics.float3 float3(Unity.Mathematics.half3 v) { }
        // RVA: 0x03D7A890  token: 0x6000197
        public static Unity.Mathematics.float3 float3(System.Double v) { }
        // RVA: 0x03D7A820  token: 0x6000198
        public static Unity.Mathematics.float3 float3(Unity.Mathematics.double3 v) { }
        // RVA: 0x04D3591C  token: 0x6000199
        public static System.UInt32 hash(Unity.Mathematics.float3 v) { }
        // RVA: 0x04D38368  token: 0x600019A
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.float3 v) { }
        // RVA: 0x04D593E8  token: 0x600019B
        public static System.Single shuffle(Unity.Mathematics.float3 left, Unity.Mathematics.float3 right, Unity.Mathematics.math.ShuffleComponent x) { }
        // RVA: 0x04D59AD4  token: 0x600019C
        public static Unity.Mathematics.float2 shuffle(Unity.Mathematics.float3 left, Unity.Mathematics.float3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y) { }
        // RVA: 0x04D59E80  token: 0x600019D
        public static Unity.Mathematics.float3 shuffle(Unity.Mathematics.float3 left, Unity.Mathematics.float3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z) { }
        // RVA: 0x04D59C68  token: 0x600019E
        public static Unity.Mathematics.float4 shuffle(Unity.Mathematics.float3 left, Unity.Mathematics.float3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w) { }
        // RVA: 0x04D57364  token: 0x600019F
        private static System.Single select_shuffle_component(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.math.ShuffleComponent component) { }
        // RVA: 0x03D7AA40  token: 0x60001A0
        public static Unity.Mathematics.float3x2 float3x2(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1) { }
        // RVA: 0x04D3200C  token: 0x60001A1
        public static Unity.Mathematics.float3x2 float3x2(System.Single m00, System.Single m01, System.Single m10, System.Single m11, System.Single m20, System.Single m21) { }
        // RVA: 0x09C344C0  token: 0x60001A2
        public static Unity.Mathematics.float3x2 float3x2(System.Single v) { }
        // RVA: 0x09C343D0  token: 0x60001A3
        public static Unity.Mathematics.float3x2 float3x2(System.Boolean v) { }
        // RVA: 0x09C34488  token: 0x60001A4
        public static Unity.Mathematics.float3x2 float3x2(Unity.Mathematics.bool3x2 v) { }
        // RVA: 0x09C343F0  token: 0x60001A5
        public static Unity.Mathematics.float3x2 float3x2(System.Int32 v) { }
        // RVA: 0x09C34430  token: 0x60001A6
        public static Unity.Mathematics.float3x2 float3x2(Unity.Mathematics.int3x2 v) { }
        // RVA: 0x09C34468  token: 0x60001A7
        public static Unity.Mathematics.float3x2 float3x2(System.UInt32 v) { }
        // RVA: 0x09C34398  token: 0x60001A8
        public static Unity.Mathematics.float3x2 float3x2(Unity.Mathematics.uint3x2 v) { }
        // RVA: 0x09C34410  token: 0x60001A9
        public static Unity.Mathematics.float3x2 float3x2(System.Double v) { }
        // RVA: 0x09C34358  token: 0x60001AA
        public static Unity.Mathematics.float3x2 float3x2(Unity.Mathematics.double3x2 v) { }
        // RVA: 0x09C570F0  token: 0x60001AB
        public static Unity.Mathematics.float2x3 transpose(Unity.Mathematics.float3x2 v) { }
        // RVA: 0x09C38894  token: 0x60001AC
        public static System.UInt32 hash(Unity.Mathematics.float3x2 v) { }
        // RVA: 0x09C39BA8  token: 0x60001AD
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.float3x2 v) { }
        // RVA: 0x02E246E0  token: 0x60001AE
        public static Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2) { }
        // RVA: 0x04D320FC  token: 0x60001AF
        public static Unity.Mathematics.float3x3 float3x3(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12, System.Single m20, System.Single m21, System.Single m22) { }
        // RVA: 0x09C34500  token: 0x60001B0
        public static Unity.Mathematics.float3x3 float3x3(System.Single v) { }
        // RVA: 0x09C344E0  token: 0x60001B1
        public static Unity.Mathematics.float3x3 float3x3(System.Boolean v) { }
        // RVA: 0x09C346E4  token: 0x60001B2
        public static Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.bool3x3 v) { }
        // RVA: 0x09C3460C  token: 0x60001B3
        public static Unity.Mathematics.float3x3 float3x3(System.Int32 v) { }
        // RVA: 0x09C34578  token: 0x60001B4
        public static Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.int3x3 v) { }
        // RVA: 0x09C346A4  token: 0x60001B5
        public static Unity.Mathematics.float3x3 float3x3(System.UInt32 v) { }
        // RVA: 0x09C34664  token: 0x60001B6
        public static Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.uint3x3 v) { }
        // RVA: 0x09C346C4  token: 0x60001B7
        public static Unity.Mathematics.float3x3 float3x3(System.Double v) { }
        // RVA: 0x09C34520  token: 0x60001B8
        public static Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.double3x3 v) { }
        // RVA: 0x09C573D8  token: 0x60001B9
        public static Unity.Mathematics.float3x3 transpose(Unity.Mathematics.float3x3 v) { }
        // RVA: 0x09C3D808  token: 0x60001BA
        public static Unity.Mathematics.float3x3 inverse(Unity.Mathematics.float3x3 m) { }
        // RVA: 0x03D79AC0  token: 0x60001BB
        public static System.Single determinant(Unity.Mathematics.float3x3 m) { }
        // RVA: 0x09C38594  token: 0x60001BC
        public static System.UInt32 hash(Unity.Mathematics.float3x3 v) { }
        // RVA: 0x09C39A3C  token: 0x60001BD
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.float3x3 v) { }
        // RVA: 0x03D7AA70  token: 0x60001BE
        public static Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2, Unity.Mathematics.float3 c3) { }
        // RVA: 0x04D322AC  token: 0x60001BF
        public static Unity.Mathematics.float3x4 float3x4(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13, System.Single m20, System.Single m21, System.Single m22, System.Single m23) { }
        // RVA: 0x09C34898  token: 0x60001C0
        public static Unity.Mathematics.float3x4 float3x4(System.Single v) { }
        // RVA: 0x09C34780  token: 0x60001C1
        public static Unity.Mathematics.float3x4 float3x4(System.Boolean v) { }
        // RVA: 0x09C34744  token: 0x60001C2
        public static Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.bool3x4 v) { }
        // RVA: 0x09C34834  token: 0x60001C3
        public static Unity.Mathematics.float3x4 float3x4(System.Int32 v) { }
        // RVA: 0x09C34854  token: 0x60001C4
        public static Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.int3x4 v) { }
        // RVA: 0x09C3495C  token: 0x60001C5
        public static Unity.Mathematics.float3x4 float3x4(System.UInt32 v) { }
        // RVA: 0x09C34918  token: 0x60001C6
        public static Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.uint3x4 v) { }
        // RVA: 0x09C34724  token: 0x60001C7
        public static Unity.Mathematics.float3x4 float3x4(System.Double v) { }
        // RVA: 0x09C348B8  token: 0x60001C8
        public static Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.double3x4 v) { }
        // RVA: 0x09C56F48  token: 0x60001C9
        public static Unity.Mathematics.float4x3 transpose(Unity.Mathematics.float3x4 v) { }
        // RVA: 0x09C3389C  token: 0x60001CA
        public static Unity.Mathematics.float3x4 fastinverse(Unity.Mathematics.float3x4 m) { }
        // RVA: 0x09C35EBC  token: 0x60001CB
        public static System.UInt32 hash(Unity.Mathematics.float3x4 v) { }
        // RVA: 0x09C393E0  token: 0x60001CC
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.float3x4 v) { }
        // RVA: 0x03D7AAC0  token: 0x60001CD
        public static Unity.Mathematics.float4 float4(System.Single x, System.Single y, System.Single z, System.Single w) { }
        // RVA: 0x03D7AAF0  token: 0x60001CE
        public static Unity.Mathematics.float4 float4(System.Single x, System.Single y, Unity.Mathematics.float2 zw) { }
        // RVA: 0x03D7AB90  token: 0x60001CF
        public static Unity.Mathematics.float4 float4(System.Single x, Unity.Mathematics.float2 yz, System.Single w) { }
        // RVA: 0x03D7AC10  token: 0x60001D0
        public static Unity.Mathematics.float4 float4(System.Single x, Unity.Mathematics.float3 yzw) { }
        // RVA: 0x03D7AB20  token: 0x60001D1
        public static Unity.Mathematics.float4 float4(Unity.Mathematics.float2 xy, System.Single z, System.Single w) { }
        // RVA: 0x03D4E3B0  token: 0x60001D2
        public static Unity.Mathematics.float4 float4(Unity.Mathematics.float2 xy, Unity.Mathematics.float2 zw) { }
        // RVA: 0x03D7AC50  token: 0x60001D3
        public static Unity.Mathematics.float4 float4(Unity.Mathematics.float3 xyz, System.Single w) { }
        // RVA: 0x09C34AEC  token: 0x60001D4
        public static Unity.Mathematics.float4 float4(Unity.Mathematics.float4 xyzw) { }
        // RVA: 0x03D7AAE0  token: 0x60001D5
        public static Unity.Mathematics.float4 float4(System.Single v) { }
        // RVA: 0x09C34AB0  token: 0x60001D6
        public static Unity.Mathematics.float4 float4(System.Boolean v) { }
        // RVA: 0x09C349AC  token: 0x60001D7
        public static Unity.Mathematics.float4 float4(Unity.Mathematics.bool4 v) { }
        // RVA: 0x03D7AB70  token: 0x60001D8
        public static Unity.Mathematics.float4 float4(System.Int32 v) { }
        // RVA: 0x09C34A6C  token: 0x60001D9
        public static Unity.Mathematics.float4 float4(Unity.Mathematics.int4 v) { }
        // RVA: 0x03D7ABC0  token: 0x60001DA
        public static Unity.Mathematics.float4 float4(System.UInt32 v) { }
        // RVA: 0x09C34AC8  token: 0x60001DB
        public static Unity.Mathematics.float4 float4(Unity.Mathematics.uint4 v) { }
        // RVA: 0x09C34A20  token: 0x60001DC
        public static Unity.Mathematics.float4 float4(Unity.Mathematics.half v) { }
        // RVA: 0x09C349C4  token: 0x60001DD
        public static Unity.Mathematics.float4 float4(Unity.Mathematics.half4 v) { }
        // RVA: 0x03D7AB50  token: 0x60001DE
        public static Unity.Mathematics.float4 float4(System.Double v) { }
        // RVA: 0x09C3497C  token: 0x60001DF
        public static Unity.Mathematics.float4 float4(Unity.Mathematics.double4 v) { }
        // RVA: 0x09C369E8  token: 0x60001E0
        public static System.UInt32 hash(Unity.Mathematics.float4 v) { }
        // RVA: 0x09C398EC  token: 0x60001E1
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.float4 v) { }
        // RVA: 0x09C53D94  token: 0x60001E2
        public static System.Single shuffle(Unity.Mathematics.float4 left, Unity.Mathematics.float4 right, Unity.Mathematics.math.ShuffleComponent x) { }
        // RVA: 0x09C54950  token: 0x60001E3
        public static Unity.Mathematics.float2 shuffle(Unity.Mathematics.float4 left, Unity.Mathematics.float4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y) { }
        // RVA: 0x09C544D8  token: 0x60001E4
        public static Unity.Mathematics.float3 shuffle(Unity.Mathematics.float4 left, Unity.Mathematics.float4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z) { }
        // RVA: 0x09C54264  token: 0x60001E5
        public static Unity.Mathematics.float4 shuffle(Unity.Mathematics.float4 left, Unity.Mathematics.float4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w) { }
        // RVA: 0x09C53950  token: 0x60001E6
        private static System.Single select_shuffle_component(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b, Unity.Mathematics.math.ShuffleComponent component) { }
        // RVA: 0x03D7AC80  token: 0x60001E7
        public static Unity.Mathematics.float4x2 float4x2(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1) { }
        // RVA: 0x04D323EC  token: 0x60001E8
        public static Unity.Mathematics.float4x2 float4x2(System.Single m00, System.Single m01, System.Single m10, System.Single m11, System.Single m20, System.Single m21, System.Single m30, System.Single m31) { }
        // RVA: 0x09C34B68  token: 0x60001E9
        public static Unity.Mathematics.float4x2 float4x2(System.Single v) { }
        // RVA: 0x09C34C38  token: 0x60001EA
        public static Unity.Mathematics.float4x2 float4x2(System.Boolean v) { }
        // RVA: 0x09C34C54  token: 0x60001EB
        public static Unity.Mathematics.float4x2 float4x2(Unity.Mathematics.bool4x2 v) { }
        // RVA: 0x09C34BFC  token: 0x60001EC
        public static Unity.Mathematics.float4x2 float4x2(System.Int32 v) { }
        // RVA: 0x09C34BC8  token: 0x60001ED
        public static Unity.Mathematics.float4x2 float4x2(Unity.Mathematics.int4x2 v) { }
        // RVA: 0x09C34C18  token: 0x60001EE
        public static Unity.Mathematics.float4x2 float4x2(System.UInt32 v) { }
        // RVA: 0x09C34B34  token: 0x60001EF
        public static Unity.Mathematics.float4x2 float4x2(Unity.Mathematics.uint4x2 v) { }
        // RVA: 0x09C34B18  token: 0x60001F0
        public static Unity.Mathematics.float4x2 float4x2(System.Double v) { }
        // RVA: 0x09C34B84  token: 0x60001F1
        public static Unity.Mathematics.float4x2 float4x2(Unity.Mathematics.double4x2 v) { }
        // RVA: 0x09C5714C  token: 0x60001F2
        public static Unity.Mathematics.float2x4 transpose(Unity.Mathematics.float4x2 v) { }
        // RVA: 0x09C36EC0  token: 0x60001F3
        public static System.UInt32 hash(Unity.Mathematics.float4x2 v) { }
        // RVA: 0x09C3BFC0  token: 0x60001F4
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.float4x2 v) { }
        // RVA: 0x03D7ACA0  token: 0x60001F5
        public static Unity.Mathematics.float4x3 float4x3(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2) { }
        // RVA: 0x04D324B8  token: 0x60001F6
        public static Unity.Mathematics.float4x3 float4x3(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12, System.Single m20, System.Single m21, System.Single m22, System.Single m30, System.Single m31, System.Single m32) { }
        // RVA: 0x09C34D9C  token: 0x60001F7
        public static Unity.Mathematics.float4x3 float4x3(System.Single v) { }
        // RVA: 0x09C34DBC  token: 0x60001F8
        public static Unity.Mathematics.float4x3 float4x3(System.Boolean v) { }
        // RVA: 0x09C34D1C  token: 0x60001F9
        public static Unity.Mathematics.float4x3 float4x3(Unity.Mathematics.bool4x3 v) { }
        // RVA: 0x09C34DDC  token: 0x60001FA
        public static Unity.Mathematics.float4x3 float4x3(System.Int32 v) { }
        // RVA: 0x09C34DFC  token: 0x60001FB
        public static Unity.Mathematics.float4x3 float4x3(Unity.Mathematics.int4x3 v) { }
        // RVA: 0x09C34CF8  token: 0x60001FC
        public static Unity.Mathematics.float4x3 float4x3(System.UInt32 v) { }
        // RVA: 0x09C34D58  token: 0x60001FD
        public static Unity.Mathematics.float4x3 float4x3(Unity.Mathematics.uint4x3 v) { }
        // RVA: 0x09C34CD8  token: 0x60001FE
        public static Unity.Mathematics.float4x3 float4x3(System.Double v) { }
        // RVA: 0x09C34C78  token: 0x60001FF
        public static Unity.Mathematics.float4x3 float4x3(Unity.Mathematics.double4x3 v) { }
        // RVA: 0x09C56AF8  token: 0x6000200
        public static Unity.Mathematics.float3x4 transpose(Unity.Mathematics.float4x3 v) { }
        // RVA: 0x09C38104  token: 0x6000201
        public static System.UInt32 hash(Unity.Mathematics.float4x3 v) { }
        // RVA: 0x09C392A4  token: 0x6000202
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.float4x3 v) { }
        // RVA: 0x03D7ACC0  token: 0x6000203
        public static Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2, Unity.Mathematics.float4 c3) { }
        // RVA: 0x09C34E3C  token: 0x6000204
        public static Unity.Mathematics.float4x4 float4x4(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13, System.Single m20, System.Single m21, System.Single m22, System.Single m23, System.Single m30, System.Single m31, System.Single m32, System.Single m33) { }
        // RVA: 0x02E25B00  token: 0x6000205
        public static Unity.Mathematics.float4x4 float4x4(System.Single v) { }
        // RVA: 0x09C352B8  token: 0x6000206
        public static Unity.Mathematics.float4x4 float4x4(System.Boolean v) { }
        // RVA: 0x09C35368  token: 0x6000207
        public static Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.bool4x4 v) { }
        // RVA: 0x09C352DC  token: 0x6000208
        public static Unity.Mathematics.float4x4 float4x4(System.Int32 v) { }
        // RVA: 0x09C34F8C  token: 0x6000209
        public static Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.int4x4 v) { }
        // RVA: 0x09C34F64  token: 0x600020A
        public static Unity.Mathematics.float4x4 float4x4(System.UInt32 v) { }
        // RVA: 0x09C351E8  token: 0x600020B
        public static Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.uint4x4 v) { }
        // RVA: 0x09C34FE8  token: 0x600020C
        public static Unity.Mathematics.float4x4 float4x4(System.Double v) { }
        // RVA: 0x09C35060  token: 0x600020D
        public static Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.double4x4 v) { }
        // RVA: 0x09C52970  token: 0x600020E
        public static Unity.Mathematics.float3 rotate(Unity.Mathematics.float4x4 a, Unity.Mathematics.float3 b) { }
        // RVA: 0x09C56668  token: 0x600020F
        public static Unity.Mathematics.float3 transform(Unity.Mathematics.float4x4 a, Unity.Mathematics.float3 b) { }
        // RVA: 0x09C572FC  token: 0x6000210
        public static Unity.Mathematics.float4x4 transpose(Unity.Mathematics.float4x4 v) { }
        // RVA: 0x02E260E0  token: 0x6000211
        public static Unity.Mathematics.float4x4 inverse(Unity.Mathematics.float4x4 m) { }
        // RVA: 0x09C33128  token: 0x6000212
        public static Unity.Mathematics.float4x4 fastinverse(Unity.Mathematics.float4x4 m) { }
        // RVA: 0x03D79630  token: 0x6000213
        public static System.Single determinant(Unity.Mathematics.float4x4 m) { }
        // RVA: 0x09C36088  token: 0x6000214
        public static System.UInt32 hash(Unity.Mathematics.float4x4 v) { }
        // RVA: 0x09C3AB14  token: 0x6000215
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.float4x4 v) { }
        // RVA: 0x03D4FEA0  token: 0x6000216
        public static Unity.Mathematics.half half(Unity.Mathematics.half x) { }
        // RVA: 0x09C35A48  token: 0x6000217
        public static Unity.Mathematics.half half(System.Single v) { }
        // RVA: 0x09C35A3C  token: 0x6000218
        public static Unity.Mathematics.half half(System.Double v) { }
        // RVA: 0x03D7B4B0  token: 0x6000219
        public static System.UInt32 hash(Unity.Mathematics.half v) { }
        // RVA: 0x03D78800  token: 0x600021A
        public static Unity.Mathematics.half2 half2(Unity.Mathematics.half x, Unity.Mathematics.half y) { }
        // RVA: 0x03D76740  token: 0x600021B
        public static Unity.Mathematics.half2 half2(Unity.Mathematics.half2 xy) { }
        // RVA: 0x03D7B2C0  token: 0x600021C
        public static Unity.Mathematics.half2 half2(Unity.Mathematics.half v) { }
        // RVA: 0x09C35780  token: 0x600021D
        public static Unity.Mathematics.half2 half2(System.Single v) { }
        // RVA: 0x09C357A8  token: 0x600021E
        public static Unity.Mathematics.half2 half2(Unity.Mathematics.float2 v) { }
        // RVA: 0x09C35714  token: 0x600021F
        public static Unity.Mathematics.half2 half2(System.Double v) { }
        // RVA: 0x09C35748  token: 0x6000220
        public static Unity.Mathematics.half2 half2(Unity.Mathematics.double2 v) { }
        // RVA: 0x09C386E8  token: 0x6000221
        public static System.UInt32 hash(Unity.Mathematics.half2 v) { }
        // RVA: 0x09C3B66C  token: 0x6000222
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.half2 v) { }
        // RVA: 0x03D78810  token: 0x6000223
        public static Unity.Mathematics.half3 half3(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half z) { }
        // RVA: 0x03D7B310  token: 0x6000224
        public static Unity.Mathematics.half3 half3(Unity.Mathematics.half x, Unity.Mathematics.half2 yz) { }
        // RVA: 0x03D7B330  token: 0x6000225
        public static Unity.Mathematics.half3 half3(Unity.Mathematics.half2 xy, Unity.Mathematics.half z) { }
        // RVA: 0x03D7B2D0  token: 0x6000226
        public static Unity.Mathematics.half3 half3(Unity.Mathematics.half3 xyz) { }
        // RVA: 0x03D7B300  token: 0x6000227
        public static Unity.Mathematics.half3 half3(Unity.Mathematics.half v) { }
        // RVA: 0x09C358B0  token: 0x6000228
        public static Unity.Mathematics.half3 half3(System.Single v) { }
        // RVA: 0x09C3586C  token: 0x6000229
        public static Unity.Mathematics.half3 half3(Unity.Mathematics.float3 v) { }
        // RVA: 0x09C357DC  token: 0x600022A
        public static Unity.Mathematics.half3 half3(System.Double v) { }
        // RVA: 0x09C35820  token: 0x600022B
        public static Unity.Mathematics.half3 half3(Unity.Mathematics.double3 v) { }
        // RVA: 0x04D33234  token: 0x600022C
        public static System.UInt32 hash(Unity.Mathematics.half3 v) { }
        // RVA: 0x04D3930C  token: 0x600022D
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.half3 v) { }
        // RVA: 0x03D78830  token: 0x600022E
        public static Unity.Mathematics.half4 half4(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half z, Unity.Mathematics.half w) { }
        // RVA: 0x03D7B420  token: 0x600022F
        public static Unity.Mathematics.half4 half4(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half2 zw) { }
        // RVA: 0x03D7B3A0  token: 0x6000230
        public static Unity.Mathematics.half4 half4(Unity.Mathematics.half x, Unity.Mathematics.half2 yz, Unity.Mathematics.half w) { }
        // RVA: 0x03D7B480  token: 0x6000231
        public static Unity.Mathematics.half4 half4(Unity.Mathematics.half x, Unity.Mathematics.half3 yzw) { }
        // RVA: 0x03D7B350  token: 0x6000232
        public static Unity.Mathematics.half4 half4(Unity.Mathematics.half2 xy, Unity.Mathematics.half z, Unity.Mathematics.half w) { }
        // RVA: 0x03D7B3D0  token: 0x6000233
        public static Unity.Mathematics.half4 half4(Unity.Mathematics.half2 xy, Unity.Mathematics.half2 zw) { }
        // RVA: 0x03D7B3F0  token: 0x6000234
        public static Unity.Mathematics.half4 half4(Unity.Mathematics.half3 xyz, Unity.Mathematics.half w) { }
        // RVA: 0x03D7B450  token: 0x6000235
        public static Unity.Mathematics.half4 half4(Unity.Mathematics.half4 xyzw) { }
        // RVA: 0x03D7B380  token: 0x6000236
        public static Unity.Mathematics.half4 half4(Unity.Mathematics.half v) { }
        // RVA: 0x09C3594C  token: 0x6000237
        public static Unity.Mathematics.half4 half4(System.Single v) { }
        // RVA: 0x09C359E8  token: 0x6000238
        public static Unity.Mathematics.half4 half4(Unity.Mathematics.float4 v) { }
        // RVA: 0x09C35990  token: 0x6000239
        public static Unity.Mathematics.half4 half4(System.Double v) { }
        // RVA: 0x09C358E8  token: 0x600023A
        public static Unity.Mathematics.half4 half4(Unity.Mathematics.double4 v) { }
        // RVA: 0x04D33194  token: 0x600023B
        public static System.UInt32 hash(Unity.Mathematics.half4 v) { }
        // RVA: 0x04D3AAA4  token: 0x600023C
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.half4 v) { }
        // RVA: 0x03D78AF0  token: 0x600023D
        public static Unity.Mathematics.int2 int2(System.Int32 x, System.Int32 y) { }
        // RVA: 0x03D76940  token: 0x600023E
        public static Unity.Mathematics.int2 int2(Unity.Mathematics.int2 xy) { }
        // RVA: 0x03D7B520  token: 0x600023F
        public static Unity.Mathematics.int2 int2(System.Int32 v) { }
        // RVA: 0x09C3C78C  token: 0x6000240
        public static Unity.Mathematics.int2 int2(System.Boolean v) { }
        // RVA: 0x09C3C7A4  token: 0x6000241
        public static Unity.Mathematics.int2 int2(Unity.Mathematics.bool2 v) { }
        // RVA: 0x03D7B520  token: 0x6000242
        public static Unity.Mathematics.int2 int2(System.UInt32 v) { }
        // RVA: 0x03D76940  token: 0x6000243
        public static Unity.Mathematics.int2 int2(Unity.Mathematics.uint2 v) { }
        // RVA: 0x03D7B500  token: 0x6000244
        public static Unity.Mathematics.int2 int2(System.Single v) { }
        // RVA: 0x03D7B4C0  token: 0x6000245
        public static Unity.Mathematics.int2 int2(Unity.Mathematics.float2 v) { }
        // RVA: 0x03D7B4E0  token: 0x6000246
        public static Unity.Mathematics.int2 int2(System.Double v) { }
        // RVA: 0x03D7B530  token: 0x6000247
        public static Unity.Mathematics.int2 int2(Unity.Mathematics.double2 v) { }
        // RVA: 0x09C37144  token: 0x6000248
        public static System.UInt32 hash(Unity.Mathematics.int2 v) { }
        // RVA: 0x09C3B82C  token: 0x6000249
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.int2 v) { }
        // RVA: 0x04D59424  token: 0x600024A
        public static System.Int32 shuffle(Unity.Mathematics.int2 left, Unity.Mathematics.int2 right, Unity.Mathematics.math.ShuffleComponent x) { }
        // RVA: 0x04D5981C  token: 0x600024B
        public static Unity.Mathematics.int2 shuffle(Unity.Mathematics.int2 left, Unity.Mathematics.int2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y) { }
        // RVA: 0x04D592B8  token: 0x600024C
        public static Unity.Mathematics.int3 shuffle(Unity.Mathematics.int2 left, Unity.Mathematics.int2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z) { }
        // RVA: 0x04D588FC  token: 0x600024D
        public static Unity.Mathematics.int4 shuffle(Unity.Mathematics.int2 left, Unity.Mathematics.int2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w) { }
        // RVA: 0x04D57CE4  token: 0x600024E
        private static System.Int32 select_shuffle_component(Unity.Mathematics.int2 a, Unity.Mathematics.int2 b, Unity.Mathematics.math.ShuffleComponent component) { }
        // RVA: 0x02232AA0  token: 0x600024F
        public static Unity.Mathematics.int2x2 int2x2(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1) { }
        // RVA: 0x09C3C820  token: 0x6000250
        public static Unity.Mathematics.int2x2 int2x2(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11) { }
        // RVA: 0x09C3C808  token: 0x6000251
        public static Unity.Mathematics.int2x2 int2x2(System.Int32 v) { }
        // RVA: 0x09C3C8C4  token: 0x6000252
        public static Unity.Mathematics.int2x2 int2x2(System.Boolean v) { }
        // RVA: 0x09C3C7C4  token: 0x6000253
        public static Unity.Mathematics.int2x2 int2x2(Unity.Mathematics.bool2x2 v) { }
        // RVA: 0x09C3C808  token: 0x6000254
        public static Unity.Mathematics.int2x2 int2x2(System.UInt32 v) { }
        // RVA: 0x09C3C888  token: 0x6000255
        public static Unity.Mathematics.int2x2 int2x2(Unity.Mathematics.uint2x2 v) { }
        // RVA: 0x09C3C870  token: 0x6000256
        public static Unity.Mathematics.int2x2 int2x2(System.Single v) { }
        // RVA: 0x09C3C7E4  token: 0x6000257
        public static Unity.Mathematics.int2x2 int2x2(Unity.Mathematics.float2x2 v) { }
        // RVA: 0x09C3C8AC  token: 0x6000258
        public static Unity.Mathematics.int2x2 int2x2(System.Double v) { }
        // RVA: 0x09C3C840  token: 0x6000259
        public static Unity.Mathematics.int2x2 int2x2(Unity.Mathematics.double2x2 v) { }
        // RVA: 0x09C56888  token: 0x600025A
        public static Unity.Mathematics.int2x2 transpose(Unity.Mathematics.int2x2 v) { }
        // RVA: 0x03D79560  token: 0x600025B
        public static System.Int32 determinant(Unity.Mathematics.int2x2 m) { }
        // RVA: 0x09C37B00  token: 0x600025C
        public static System.UInt32 hash(Unity.Mathematics.int2x2 v) { }
        // RVA: 0x09C3A6B0  token: 0x600025D
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.int2x2 v) { }
        // RVA: 0x03D7A7F0  token: 0x600025E
        public static Unity.Mathematics.int2x3 int2x3(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1, Unity.Mathematics.int2 c2) { }
        // RVA: 0x04D3AE7C  token: 0x600025F
        public static Unity.Mathematics.int2x3 int2x3(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12) { }
        // RVA: 0x09C3C934  token: 0x6000260
        public static Unity.Mathematics.int2x3 int2x3(System.Int32 v) { }
        // RVA: 0x09C3C9E8  token: 0x6000261
        public static Unity.Mathematics.int2x3 int2x3(System.Boolean v) { }
        // RVA: 0x09C3C974  token: 0x6000262
        public static Unity.Mathematics.int2x3 int2x3(Unity.Mathematics.bool2x3 v) { }
        // RVA: 0x09C3C934  token: 0x6000263
        public static Unity.Mathematics.int2x3 int2x3(System.UInt32 v) { }
        // RVA: 0x09C3C8FC  token: 0x6000264
        public static Unity.Mathematics.int2x3 int2x3(Unity.Mathematics.uint2x3 v) { }
        // RVA: 0x09C3C8DC  token: 0x6000265
        public static Unity.Mathematics.int2x3 int2x3(System.Single v) { }
        // RVA: 0x09C3CA08  token: 0x6000266
        public static Unity.Mathematics.int2x3 int2x3(Unity.Mathematics.float2x3 v) { }
        // RVA: 0x09C3C954  token: 0x6000267
        public static Unity.Mathematics.int2x3 int2x3(System.Double v) { }
        // RVA: 0x09C3C9AC  token: 0x6000268
        public static Unity.Mathematics.int2x3 int2x3(Unity.Mathematics.double2x3 v) { }
        // RVA: 0x09C574EC  token: 0x6000269
        public static Unity.Mathematics.int3x2 transpose(Unity.Mathematics.int2x3 v) { }
        // RVA: 0x09C3737C  token: 0x600026A
        public static System.UInt32 hash(Unity.Mathematics.int2x3 v) { }
        // RVA: 0x09C3B5CC  token: 0x600026B
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.int2x3 v) { }
        // RVA: 0x03D7B550  token: 0x600026C
        public static Unity.Mathematics.int2x4 int2x4(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1, Unity.Mathematics.int2 c2, Unity.Mathematics.int2 c3) { }
        // RVA: 0x04D3AEB4  token: 0x600026D
        public static Unity.Mathematics.int2x4 int2x4(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13) { }
        // RVA: 0x09C3CA64  token: 0x600026E
        public static Unity.Mathematics.int2x4 int2x4(System.Int32 v) { }
        // RVA: 0x09C3CAB4  token: 0x600026F
        public static Unity.Mathematics.int2x4 int2x4(System.Boolean v) { }
        // RVA: 0x09C3CA40  token: 0x6000270
        public static Unity.Mathematics.int2x4 int2x4(Unity.Mathematics.bool2x4 v) { }
        // RVA: 0x09C3CA64  token: 0x6000271
        public static Unity.Mathematics.int2x4 int2x4(System.UInt32 v) { }
        // RVA: 0x09C3CA80  token: 0x6000272
        public static Unity.Mathematics.int2x4 int2x4(Unity.Mathematics.uint2x4 v) { }
        // RVA: 0x09C3CB20  token: 0x6000273
        public static Unity.Mathematics.int2x4 int2x4(System.Single v) { }
        // RVA: 0x09C3CAEC  token: 0x6000274
        public static Unity.Mathematics.int2x4 int2x4(Unity.Mathematics.float2x4 v) { }
        // RVA: 0x09C3CAD0  token: 0x6000275
        public static Unity.Mathematics.int2x4 int2x4(System.Double v) { }
        // RVA: 0x09C3CB3C  token: 0x6000276
        public static Unity.Mathematics.int2x4 int2x4(Unity.Mathematics.double2x4 v) { }
        // RVA: 0x09C56AA0  token: 0x6000277
        public static Unity.Mathematics.int4x2 transpose(Unity.Mathematics.int2x4 v) { }
        // RVA: 0x09C36B34  token: 0x6000278
        public static System.UInt32 hash(Unity.Mathematics.int2x4 v) { }
        // RVA: 0x09C39EF8  token: 0x6000279
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.int2x4 v) { }
        // RVA: 0x03D78B00  token: 0x600027A
        public static Unity.Mathematics.int3 int3(System.Int32 x, System.Int32 y, System.Int32 z) { }
        // RVA: 0x03D7B5B0  token: 0x600027B
        public static Unity.Mathematics.int3 int3(System.Int32 x, Unity.Mathematics.int2 yz) { }
        // RVA: 0x03D7B5D0  token: 0x600027C
        public static Unity.Mathematics.int3 int3(Unity.Mathematics.int2 xy, System.Int32 z) { }
        // RVA: 0x03D7B5F0  token: 0x600027D
        public static Unity.Mathematics.int3 int3(Unity.Mathematics.int3 xyz) { }
        // RVA: 0x03D7B570  token: 0x600027E
        public static Unity.Mathematics.int3 int3(System.Int32 v) { }
        // RVA: 0x09C3CB80  token: 0x600027F
        public static Unity.Mathematics.int3 int3(System.Boolean v) { }
        // RVA: 0x09C3CB98  token: 0x6000280
        public static Unity.Mathematics.int3 int3(Unity.Mathematics.bool3 v) { }
        // RVA: 0x03D7B570  token: 0x6000281
        public static Unity.Mathematics.int3 int3(System.UInt32 v) { }
        // RVA: 0x03D7B5F0  token: 0x6000282
        public static Unity.Mathematics.int3 int3(Unity.Mathematics.uint3 v) { }
        // RVA: 0x03D7B640  token: 0x6000283
        public static Unity.Mathematics.int3 int3(System.Single v) { }
        // RVA: 0x03D7B580  token: 0x6000284
        public static Unity.Mathematics.int3 int3(Unity.Mathematics.float3 v) { }
        // RVA: 0x03D7B620  token: 0x6000285
        public static Unity.Mathematics.int3 int3(System.Double v) { }
        // RVA: 0x03D7B660  token: 0x6000286
        public static Unity.Mathematics.int3 int3(Unity.Mathematics.double3 v) { }
        // RVA: 0x09C38520  token: 0x6000287
        public static System.UInt32 hash(Unity.Mathematics.int3 v) { }
        // RVA: 0x04D3A4C4  token: 0x6000288
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.int3 v) { }
        // RVA: 0x04D587A0  token: 0x6000289
        public static System.Int32 shuffle(Unity.Mathematics.int3 left, Unity.Mathematics.int3 right, Unity.Mathematics.math.ShuffleComponent x) { }
        // RVA: 0x04D58C54  token: 0x600028A
        public static Unity.Mathematics.int2 shuffle(Unity.Mathematics.int3 left, Unity.Mathematics.int3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y) { }
        // RVA: 0x04D59638  token: 0x600028B
        public static Unity.Mathematics.int3 shuffle(Unity.Mathematics.int3 left, Unity.Mathematics.int3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z) { }
        // RVA: 0x04D58D90  token: 0x600028C
        public static Unity.Mathematics.int4 shuffle(Unity.Mathematics.int3 left, Unity.Mathematics.int3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w) { }
        // RVA: 0x04D57170  token: 0x600028D
        private static System.Int32 select_shuffle_component(Unity.Mathematics.int3 a, Unity.Mathematics.int3 b, Unity.Mathematics.math.ShuffleComponent component) { }
        // RVA: 0x03D7AA40  token: 0x600028E
        public static Unity.Mathematics.int3x2 int3x2(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1) { }
        // RVA: 0x04D3AF08  token: 0x600028F
        public static Unity.Mathematics.int3x2 int3x2(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11, System.Int32 m20, System.Int32 m21) { }
        // RVA: 0x09C3CC7C  token: 0x6000290
        public static Unity.Mathematics.int3x2 int3x2(System.Int32 v) { }
        // RVA: 0x09C3CC9C  token: 0x6000291
        public static Unity.Mathematics.int3x2 int3x2(System.Boolean v) { }
        // RVA: 0x09C3CCBC  token: 0x6000292
        public static Unity.Mathematics.int3x2 int3x2(Unity.Mathematics.bool3x2 v) { }
        // RVA: 0x09C3CC7C  token: 0x6000293
        public static Unity.Mathematics.int3x2 int3x2(System.UInt32 v) { }
        // RVA: 0x09C3CC0C  token: 0x6000294
        public static Unity.Mathematics.int3x2 int3x2(Unity.Mathematics.uint3x2 v) { }
        // RVA: 0x09C3CCF4  token: 0x6000295
        public static Unity.Mathematics.int3x2 int3x2(System.Single v) { }
        // RVA: 0x09C3CC44  token: 0x6000296
        public static Unity.Mathematics.int3x2 int3x2(Unity.Mathematics.float3x2 v) { }
        // RVA: 0x09C3CD14  token: 0x6000297
        public static Unity.Mathematics.int3x2 int3x2(System.Double v) { }
        // RVA: 0x09C3CBCC  token: 0x6000298
        public static Unity.Mathematics.int3x2 int3x2(Unity.Mathematics.double3x2 v) { }
        // RVA: 0x09C568C4  token: 0x6000299
        public static Unity.Mathematics.int2x3 transpose(Unity.Mathematics.int3x2 v) { }
        // RVA: 0x09C3872C  token: 0x600029A
        public static System.UInt32 hash(Unity.Mathematics.int3x2 v) { }
        // RVA: 0x09C3A5B8  token: 0x600029B
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.int3x2 v) { }
        // RVA: 0x02E246E0  token: 0x600029C
        public static Unity.Mathematics.int3x3 int3x3(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1, Unity.Mathematics.int3 c2) { }
        // RVA: 0x04D3AF98  token: 0x600029D
        public static Unity.Mathematics.int3x3 int3x3(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m20, System.Int32 m21, System.Int32 m22) { }
        // RVA: 0x09C3CD34  token: 0x600029E
        public static Unity.Mathematics.int3x3 int3x3(System.Int32 v) { }
        // RVA: 0x09C3CEAC  token: 0x600029F
        public static Unity.Mathematics.int3x3 int3x3(System.Boolean v) { }
        // RVA: 0x09C3CE6C  token: 0x60002A0
        public static Unity.Mathematics.int3x3 int3x3(Unity.Mathematics.bool3x3 v) { }
        // RVA: 0x09C3CD34  token: 0x60002A1
        public static Unity.Mathematics.int3x3 int3x3(System.UInt32 v) { }
        // RVA: 0x09C3CD74  token: 0x60002A2
        public static Unity.Mathematics.int3x3 int3x3(Unity.Mathematics.uint3x3 v) { }
        // RVA: 0x09C3CD54  token: 0x60002A3
        public static Unity.Mathematics.int3x3 int3x3(System.Single v) { }
        // RVA: 0x09C3CE0C  token: 0x60002A4
        public static Unity.Mathematics.int3x3 int3x3(Unity.Mathematics.float3x3 v) { }
        // RVA: 0x09C3CE4C  token: 0x60002A5
        public static Unity.Mathematics.int3x3 int3x3(System.Double v) { }
        // RVA: 0x09C3CDB4  token: 0x60002A6
        public static Unity.Mathematics.int3x3 int3x3(Unity.Mathematics.double3x3 v) { }
        // RVA: 0x09C56E28  token: 0x60002A7
        public static Unity.Mathematics.int3x3 transpose(Unity.Mathematics.int3x3 v) { }
        // RVA: 0x03D79B70  token: 0x60002A8
        public static System.Int32 determinant(Unity.Mathematics.int3x3 m) { }
        // RVA: 0x09C36894  token: 0x60002A9
        public static System.UInt32 hash(Unity.Mathematics.int3x3 v) { }
        // RVA: 0x09C39D8C  token: 0x60002AA
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.int3x3 v) { }
        // RVA: 0x03D7AA70  token: 0x60002AB
        public static Unity.Mathematics.int3x4 int3x4(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1, Unity.Mathematics.int3 c2, Unity.Mathematics.int3 c3) { }
        // RVA: 0x04D3B05C  token: 0x60002AC
        public static Unity.Mathematics.int3x4 int3x4(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m23) { }
        // RVA: 0x09C3CF88  token: 0x60002AD
        public static Unity.Mathematics.int3x4 int3x4(System.Int32 v) { }
        // RVA: 0x09C3CECC  token: 0x60002AE
        public static Unity.Mathematics.int3x4 int3x4(System.Boolean v) { }
        // RVA: 0x09C3CF4C  token: 0x60002AF
        public static Unity.Mathematics.int3x4 int3x4(Unity.Mathematics.bool3x4 v) { }
        // RVA: 0x09C3CF88  token: 0x60002B0
        public static Unity.Mathematics.int3x4 int3x4(System.UInt32 v) { }
        // RVA: 0x09C3D02C  token: 0x60002B1
        public static Unity.Mathematics.int3x4 int3x4(Unity.Mathematics.uint3x4 v) { }
        // RVA: 0x09C3D00C  token: 0x60002B2
        public static Unity.Mathematics.int3x4 int3x4(System.Single v) { }
        // RVA: 0x09C3CFA8  token: 0x60002B3
        public static Unity.Mathematics.int3x4 int3x4(Unity.Mathematics.float3x4 v) { }
        // RVA: 0x09C3CFEC  token: 0x60002B4
        public static Unity.Mathematics.int3x4 int3x4(System.Double v) { }
        // RVA: 0x09C3CEEC  token: 0x60002B5
        public static Unity.Mathematics.int3x4 int3x4(Unity.Mathematics.double3x4 v) { }
        // RVA: 0x09C569B0  token: 0x60002B6
        public static Unity.Mathematics.int4x3 transpose(Unity.Mathematics.int3x4 v) { }
        // RVA: 0x09C36638  token: 0x60002B7
        public static System.UInt32 hash(Unity.Mathematics.int3x4 v) { }
        // RVA: 0x09C3AD7C  token: 0x60002B8
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.int3x4 v) { }
        // RVA: 0x03D78B10  token: 0x60002B9
        public static Unity.Mathematics.int4 int4(System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w) { }
        // RVA: 0x03D7B730  token: 0x60002BA
        public static Unity.Mathematics.int4 int4(System.Int32 x, System.Int32 y, Unity.Mathematics.int2 zw) { }
        // RVA: 0x03D7B7B0  token: 0x60002BB
        public static Unity.Mathematics.int4 int4(System.Int32 x, Unity.Mathematics.int2 yz, System.Int32 w) { }
        // RVA: 0x03D7B6B0  token: 0x60002BC
        public static Unity.Mathematics.int4 int4(System.Int32 x, Unity.Mathematics.int3 yzw) { }
        // RVA: 0x03D7B750  token: 0x60002BD
        public static Unity.Mathematics.int4 int4(Unity.Mathematics.int2 xy, System.Int32 z, System.Int32 w) { }
        // RVA: 0x03D76960  token: 0x60002BE
        public static Unity.Mathematics.int4 int4(Unity.Mathematics.int2 xy, Unity.Mathematics.int2 zw) { }
        // RVA: 0x03D7B770  token: 0x60002BF
        public static Unity.Mathematics.int4 int4(Unity.Mathematics.int3 xyz, System.Int32 w) { }
        // RVA: 0x09C3D070  token: 0x60002C0
        public static Unity.Mathematics.int4 int4(Unity.Mathematics.int4 xyzw) { }
        // RVA: 0x03D7B6A0  token: 0x60002C1
        public static Unity.Mathematics.int4 int4(System.Int32 v) { }
        // RVA: 0x09C3D09C  token: 0x60002C2
        public static Unity.Mathematics.int4 int4(System.Boolean v) { }
        // RVA: 0x09C3D0BC  token: 0x60002C3
        public static Unity.Mathematics.int4 int4(Unity.Mathematics.bool4 v) { }
        // RVA: 0x03D7B6A0  token: 0x60002C4
        public static Unity.Mathematics.int4 int4(System.UInt32 v) { }
        // RVA: 0x09C3D070  token: 0x60002C5
        public static Unity.Mathematics.int4 int4(Unity.Mathematics.uint4 v) { }
        // RVA: 0x03D7B710  token: 0x60002C6
        public static Unity.Mathematics.int4 int4(System.Single v) { }
        // RVA: 0x09C3D130  token: 0x60002C7
        public static Unity.Mathematics.int4 int4(Unity.Mathematics.float4 v) { }
        // RVA: 0x03D7B6F0  token: 0x60002C8
        public static Unity.Mathematics.int4 int4(System.Double v) { }
        // RVA: 0x09C3D100  token: 0x60002C9
        public static Unity.Mathematics.int4 int4(Unity.Mathematics.double4 v) { }
        // RVA: 0x09C3880C  token: 0x60002CA
        public static System.UInt32 hash(Unity.Mathematics.int4 v) { }
        // RVA: 0x09C3C3D8  token: 0x60002CB
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.int4 v) { }
        // RVA: 0x09C543F4  token: 0x60002CC
        public static System.Int32 shuffle(Unity.Mathematics.int4 left, Unity.Mathematics.int4 right, Unity.Mathematics.math.ShuffleComponent x) { }
        // RVA: 0x09C53AD8  token: 0x60002CD
        public static Unity.Mathematics.int2 shuffle(Unity.Mathematics.int4 left, Unity.Mathematics.int4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y) { }
        // RVA: 0x09C54AB8  token: 0x60002CE
        public static Unity.Mathematics.int3 shuffle(Unity.Mathematics.int4 left, Unity.Mathematics.int4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z) { }
        // RVA: 0x09C53CBC  token: 0x60002CF
        public static Unity.Mathematics.int4 shuffle(Unity.Mathematics.int4 left, Unity.Mathematics.int4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w) { }
        // RVA: 0x04D57784  token: 0x60002D0
        private static System.Int32 select_shuffle_component(Unity.Mathematics.int4 a, Unity.Mathematics.int4 b, Unity.Mathematics.math.ShuffleComponent component) { }
        // RVA: 0x03D7AC80  token: 0x60002D1
        public static Unity.Mathematics.int4x2 int4x2(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1) { }
        // RVA: 0x04D3B124  token: 0x60002D2
        public static Unity.Mathematics.int4x2 int4x2(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11, System.Int32 m20, System.Int32 m21, System.Int32 m30, System.Int32 m31) { }
        // RVA: 0x09C3D1C4  token: 0x60002D3
        public static Unity.Mathematics.int4x2 int4x2(System.Int32 v) { }
        // RVA: 0x09C3D230  token: 0x60002D4
        public static Unity.Mathematics.int4x2 int4x2(System.Boolean v) { }
        // RVA: 0x09C3D280  token: 0x60002D5
        public static Unity.Mathematics.int4x2 int4x2(Unity.Mathematics.bool4x2 v) { }
        // RVA: 0x09C3D1C4  token: 0x60002D6
        public static Unity.Mathematics.int4x2 int4x2(System.UInt32 v) { }
        // RVA: 0x09C3D1E0  token: 0x60002D7
        public static Unity.Mathematics.int4x2 int4x2(Unity.Mathematics.uint4x2 v) { }
        // RVA: 0x09C3D214  token: 0x60002D8
        public static Unity.Mathematics.int4x2 int4x2(System.Single v) { }
        // RVA: 0x09C3D24C  token: 0x60002D9
        public static Unity.Mathematics.int4x2 int4x2(Unity.Mathematics.float4x2 v) { }
        // RVA: 0x09C3D164  token: 0x60002DA
        public static Unity.Mathematics.int4x2 int4x2(System.Double v) { }
        // RVA: 0x09C3D180  token: 0x60002DB
        public static Unity.Mathematics.int4x2 int4x2(Unity.Mathematics.double4x2 v) { }
        // RVA: 0x09C56910  token: 0x60002DC
        public static Unity.Mathematics.int2x4 transpose(Unity.Mathematics.int4x2 v) { }
        // RVA: 0x09C37C74  token: 0x60002DD
        public static System.UInt32 hash(Unity.Mathematics.int4x2 v) { }
        // RVA: 0x09C3A224  token: 0x60002DE
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.int4x2 v) { }
        // RVA: 0x03D7ACA0  token: 0x60002DF
        public static Unity.Mathematics.int4x3 int4x3(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1, Unity.Mathematics.int4 c2) { }
        // RVA: 0x04D3B1D8  token: 0x60002E0
        public static Unity.Mathematics.int4x3 int4x3(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m30, System.Int32 m31, System.Int32 m32) { }
        // RVA: 0x09C3D2C4  token: 0x60002E1
        public static Unity.Mathematics.int4x3 int4x3(System.Int32 v) { }
        // RVA: 0x09C3D3E4  token: 0x60002E2
        public static Unity.Mathematics.int4x3 int4x3(System.Boolean v) { }
        // RVA: 0x09C3D364  token: 0x60002E3
        public static Unity.Mathematics.int4x3 int4x3(Unity.Mathematics.bool4x3 v) { }
        // RVA: 0x09C3D2C4  token: 0x60002E4
        public static Unity.Mathematics.int4x3 int4x3(System.UInt32 v) { }
        // RVA: 0x09C3D3A0  token: 0x60002E5
        public static Unity.Mathematics.int4x3 int4x3(Unity.Mathematics.uint4x3 v) { }
        // RVA: 0x09C3D344  token: 0x60002E6
        public static Unity.Mathematics.int4x3 int4x3(System.Single v) { }
        // RVA: 0x09C3D404  token: 0x60002E7
        public static Unity.Mathematics.int4x3 int4x3(Unity.Mathematics.float4x3 v) { }
        // RVA: 0x09C3D2A4  token: 0x60002E8
        public static Unity.Mathematics.int4x3 int4x3(System.Double v) { }
        // RVA: 0x09C3D2E4  token: 0x60002E9
        public static Unity.Mathematics.int4x3 int4x3(Unity.Mathematics.double4x3 v) { }
        // RVA: 0x09C56CC4  token: 0x60002EA
        public static Unity.Mathematics.int3x4 transpose(Unity.Mathematics.int4x3 v) { }
        // RVA: 0x09C37D40  token: 0x60002EB
        public static System.UInt32 hash(Unity.Mathematics.int4x3 v) { }
        // RVA: 0x09C3B86C  token: 0x60002EC
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.int4x3 v) { }
        // RVA: 0x03D7ACC0  token: 0x60002ED
        public static Unity.Mathematics.int4x4 int4x4(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1, Unity.Mathematics.int4 c2, Unity.Mathematics.int4 c3) { }
        // RVA: 0x04D3B3A0  token: 0x60002EE
        public static Unity.Mathematics.int4x4 int4x4(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m23, System.Int32 m30, System.Int32 m31, System.Int32 m32, System.Int32 m33) { }
        // RVA: 0x09C3D4C4  token: 0x60002EF
        public static Unity.Mathematics.int4x4 int4x4(System.Int32 v) { }
        // RVA: 0x09C3D444  token: 0x60002F0
        public static Unity.Mathematics.int4x4 int4x4(System.Boolean v) { }
        // RVA: 0x09C3D50C  token: 0x60002F1
        public static Unity.Mathematics.int4x4 int4x4(Unity.Mathematics.bool4x4 v) { }
        // RVA: 0x09C3D4C4  token: 0x60002F2
        public static Unity.Mathematics.int4x4 int4x4(System.UInt32 v) { }
        // RVA: 0x09C3D544  token: 0x60002F3
        public static Unity.Mathematics.int4x4 int4x4(Unity.Mathematics.uint4x4 v) { }
        // RVA: 0x09C3D4E8  token: 0x60002F4
        public static Unity.Mathematics.int4x4 int4x4(System.Single v) { }
        // RVA: 0x09C3D468  token: 0x60002F5
        public static Unity.Mathematics.int4x4 int4x4(Unity.Mathematics.float4x4 v) { }
        // RVA: 0x09C3D62C  token: 0x60002F6
        public static Unity.Mathematics.int4x4 int4x4(System.Double v) { }
        // RVA: 0x09C3D5A0  token: 0x60002F7
        public static Unity.Mathematics.int4x4 int4x4(Unity.Mathematics.double4x4 v) { }
        // RVA: 0x09C57048  token: 0x60002F8
        public static Unity.Mathematics.int4x4 transpose(Unity.Mathematics.int4x4 v) { }
        // RVA: 0x03D798A0  token: 0x60002F9
        public static System.Int32 determinant(Unity.Mathematics.int4x4 m) { }
        // RVA: 0x09C376C0  token: 0x60002FA
        public static System.UInt32 hash(Unity.Mathematics.int4x4 v) { }
        // RVA: 0x09C3A724  token: 0x60002FB
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.int4x4 v) { }
        // RVA: 0x03D517B0  token: 0x60002FC
        public static System.Int32 asint(System.UInt32 x) { }
        // RVA: 0x0339AE90  token: 0x60002FD
        public static Unity.Mathematics.int2 asint(Unity.Mathematics.uint2 x) { }
        // RVA: 0x03D56520  token: 0x60002FE
        public static Unity.Mathematics.int3 asint(Unity.Mathematics.uint3 x) { }
        // RVA: 0x03D5B250  token: 0x60002FF
        public static Unity.Mathematics.int4 asint(Unity.Mathematics.uint4 x) { }
        // RVA: 0x03D70290  token: 0x6000300
        public static System.Int32 asint(System.Single x) { }
        // RVA: 0x03D787A0  token: 0x6000301
        public static Unity.Mathematics.int2 asint(Unity.Mathematics.float2 x) { }
        // RVA: 0x03D56520  token: 0x6000302
        public static Unity.Mathematics.int3 asint(Unity.Mathematics.float3 x) { }
        // RVA: 0x03D5B250  token: 0x6000303
        public static Unity.Mathematics.int4 asint(Unity.Mathematics.float4 x) { }
        // RVA: 0x03D517B0  token: 0x6000304
        public static System.UInt32 asuint(System.Int32 x) { }
        // RVA: 0x0339AE90  token: 0x6000305
        public static Unity.Mathematics.uint2 asuint(Unity.Mathematics.int2 x) { }
        // RVA: 0x03D56520  token: 0x6000306
        public static Unity.Mathematics.uint3 asuint(Unity.Mathematics.int3 x) { }
        // RVA: 0x03D5B250  token: 0x6000307
        public static Unity.Mathematics.uint4 asuint(Unity.Mathematics.int4 x) { }
        // RVA: 0x03D70290  token: 0x6000308
        public static System.UInt32 asuint(System.Single x) { }
        // RVA: 0x03D787A0  token: 0x6000309
        public static Unity.Mathematics.uint2 asuint(Unity.Mathematics.float2 x) { }
        // RVA: 0x03D56520  token: 0x600030A
        public static Unity.Mathematics.uint3 asuint(Unity.Mathematics.float3 x) { }
        // RVA: 0x03D5B250  token: 0x600030B
        public static Unity.Mathematics.uint4 asuint(Unity.Mathematics.float4 x) { }
        // RVA: 0x0339AE90  token: 0x600030C
        public static System.Int64 aslong(System.UInt64 x) { }
        // RVA: 0x03D70270  token: 0x600030D
        public static System.Int64 aslong(System.Double x) { }
        // RVA: 0x0339AE90  token: 0x600030E
        public static System.UInt64 asulong(System.Int64 x) { }
        // RVA: 0x03D70270  token: 0x600030F
        public static System.UInt64 asulong(System.Double x) { }
        // RVA: 0x03D6BFD0  token: 0x6000310
        public static System.Single asfloat(System.Int32 x) { }
        // RVA: 0x03D785A0  token: 0x6000311
        public static Unity.Mathematics.float2 asfloat(Unity.Mathematics.int2 x) { }
        // RVA: 0x03D56520  token: 0x6000312
        public static Unity.Mathematics.float3 asfloat(Unity.Mathematics.int3 x) { }
        // RVA: 0x03D5B250  token: 0x6000313
        public static Unity.Mathematics.float4 asfloat(Unity.Mathematics.int4 x) { }
        // RVA: 0x03D6BFD0  token: 0x6000314
        public static System.Single asfloat(System.UInt32 x) { }
        // RVA: 0x03D785A0  token: 0x6000315
        public static Unity.Mathematics.float2 asfloat(Unity.Mathematics.uint2 x) { }
        // RVA: 0x03D56520  token: 0x6000316
        public static Unity.Mathematics.float3 asfloat(Unity.Mathematics.uint3 x) { }
        // RVA: 0x03D5B250  token: 0x6000317
        public static Unity.Mathematics.float4 asfloat(Unity.Mathematics.uint4 x) { }
        // RVA: 0x09C2EC1C  token: 0x6000318
        public static System.Int32 bitmask(Unity.Mathematics.bool4 value) { }
        // RVA: 0x03D70280  token: 0x6000319
        public static System.Double asdouble(System.Int64 x) { }
        // RVA: 0x03D70280  token: 0x600031A
        public static System.Double asdouble(System.UInt64 x) { }
        // RVA: 0x09C3F2B8  token: 0x600031B
        public static System.Boolean isfinite(System.Single x) { }
        // RVA: 0x09C3F240  token: 0x600031C
        public static Unity.Mathematics.bool2 isfinite(Unity.Mathematics.float2 x) { }
        // RVA: 0x09C3F100  token: 0x600031D
        public static Unity.Mathematics.bool3 isfinite(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C3F16C  token: 0x600031E
        public static Unity.Mathematics.bool4 isfinite(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C3F0D8  token: 0x600031F
        public static System.Boolean isfinite(System.Double x) { }
        // RVA: 0x09C3F274  token: 0x6000320
        public static Unity.Mathematics.bool2 isfinite(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C3F2D4  token: 0x6000321
        public static Unity.Mathematics.bool3 isfinite(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C3F1D0  token: 0x6000322
        public static Unity.Mathematics.bool4 isfinite(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C3F348  token: 0x6000323
        public static System.Boolean isinf(System.Single x) { }
        // RVA: 0x09C3F448  token: 0x6000324
        public static Unity.Mathematics.bool2 isinf(Unity.Mathematics.float2 x) { }
        // RVA: 0x09C3F4E0  token: 0x6000325
        public static Unity.Mathematics.bool3 isinf(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C3F4A4  token: 0x6000326
        public static Unity.Mathematics.bool4 isinf(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C3F3D0  token: 0x6000327
        public static System.Boolean isinf(System.Double x) { }
        // RVA: 0x09C3F468  token: 0x6000328
        public static Unity.Mathematics.bool2 isinf(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C3F368  token: 0x6000329
        public static Unity.Mathematics.bool3 isinf(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C3F3FC  token: 0x600032A
        public static Unity.Mathematics.bool4 isinf(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C3F5F4  token: 0x600032B
        public static System.Boolean isnan(System.Single x) { }
        // RVA: 0x09C3F5A8  token: 0x600032C
        public static Unity.Mathematics.bool2 isnan(Unity.Mathematics.float2 x) { }
        // RVA: 0x09C3F750  token: 0x600032D
        public static Unity.Mathematics.bool3 isnan(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C3F6D4  token: 0x600032E
        public static Unity.Mathematics.bool4 isnan(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C3F670  token: 0x600032F
        public static System.Boolean isnan(System.Double x) { }
        // RVA: 0x09C3F694  token: 0x6000330
        public static Unity.Mathematics.bool2 isnan(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C3F548  token: 0x6000331
        public static Unity.Mathematics.bool3 isnan(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C3F608  token: 0x6000332
        public static Unity.Mathematics.bool4 isnan(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C3F81C  token: 0x6000333
        public static System.Boolean ispow2(System.Int32 x) { }
        // RVA: 0x09C3F82C  token: 0x6000334
        public static Unity.Mathematics.bool2 ispow2(Unity.Mathematics.int2 x) { }
        // RVA: 0x09C3F7C8  token: 0x6000335
        public static Unity.Mathematics.bool3 ispow2(Unity.Mathematics.int3 x) { }
        // RVA: 0x09C3F96C  token: 0x6000336
        public static Unity.Mathematics.bool4 ispow2(Unity.Mathematics.int4 x) { }
        // RVA: 0x09C3F8D8  token: 0x6000337
        public static System.Boolean ispow2(System.UInt32 x) { }
        // RVA: 0x09C3F8E8  token: 0x6000338
        public static Unity.Mathematics.bool2 ispow2(Unity.Mathematics.uint2 x) { }
        // RVA: 0x09C3F91C  token: 0x6000339
        public static Unity.Mathematics.bool3 ispow2(Unity.Mathematics.uint3 x) { }
        // RVA: 0x09C3F860  token: 0x600033A
        public static Unity.Mathematics.bool4 ispow2(Unity.Mathematics.uint4 x) { }
        // RVA: 0x09C40B98  token: 0x600033B
        public static System.Int32 min(System.Int32 x, System.Int32 y) { }
        // RVA: 0x09C40E7C  token: 0x600033C
        public static Unity.Mathematics.int2 min(Unity.Mathematics.int2 x, Unity.Mathematics.int2 y) { }
        // RVA: 0x09C40EBC  token: 0x600033D
        public static Unity.Mathematics.int3 min(Unity.Mathematics.int3 x, Unity.Mathematics.int3 y) { }
        // RVA: 0x09C40C74  token: 0x600033E
        public static Unity.Mathematics.int4 min(Unity.Mathematics.int4 x, Unity.Mathematics.int4 y) { }
        // RVA: 0x09C40EB4  token: 0x600033F
        public static System.UInt32 min(System.UInt32 x, System.UInt32 y) { }
        // RVA: 0x09C40D60  token: 0x6000340
        public static Unity.Mathematics.uint2 min(Unity.Mathematics.uint2 x, Unity.Mathematics.uint2 y) { }
        // RVA: 0x09C40DF8  token: 0x6000341
        public static Unity.Mathematics.uint3 min(Unity.Mathematics.uint3 x, Unity.Mathematics.uint3 y) { }
        // RVA: 0x09C40E2C  token: 0x6000342
        public static Unity.Mathematics.uint4 min(Unity.Mathematics.uint4 x, Unity.Mathematics.uint4 y) { }
        // RVA: 0x09C40E70  token: 0x6000343
        public static System.Int64 min(System.Int64 x, System.Int64 y) { }
        // RVA: 0x09C40EA8  token: 0x6000344
        public static System.UInt64 min(System.UInt64 x, System.UInt64 y) { }
        // RVA: 0x09C40D8C  token: 0x6000345
        public static System.Single min(System.Single x, System.Single y) { }
        // RVA: 0x09C40DA0  token: 0x6000346
        public static Unity.Mathematics.float2 min(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y) { }
        // RVA: 0x09C40C0C  token: 0x6000347
        public static Unity.Mathematics.float3 min(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y) { }
        // RVA: 0x04D3D1F0  token: 0x6000348
        public static Unity.Mathematics.float4 min(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y) { }
        // RVA: 0x09C40CB8  token: 0x6000349
        public static System.Double min(System.Double x, System.Double y) { }
        // RVA: 0x04D3D0B0  token: 0x600034A
        public static Unity.Mathematics.double2 min(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y) { }
        // RVA: 0x09C40BA0  token: 0x600034B
        public static Unity.Mathematics.double3 min(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y) { }
        // RVA: 0x09C40CD0  token: 0x600034C
        public static Unity.Mathematics.double4 min(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y) { }
        // RVA: 0x09C40930  token: 0x600034D
        public static System.Int32 max(System.Int32 x, System.Int32 y) { }
        // RVA: 0x09C4085C  token: 0x600034E
        public static Unity.Mathematics.int2 max(Unity.Mathematics.int2 x, Unity.Mathematics.int2 y) { }
        // RVA: 0x09C40828  token: 0x600034F
        public static Unity.Mathematics.int3 max(Unity.Mathematics.int3 x, Unity.Mathematics.int3 y) { }
        // RVA: 0x09C409F0  token: 0x6000350
        public static Unity.Mathematics.int4 max(Unity.Mathematics.int4 x, Unity.Mathematics.int4 y) { }
        // RVA: 0x09C40ACC  token: 0x6000351
        public static System.UInt32 max(System.UInt32 x, System.UInt32 y) { }
        // RVA: 0x09C40AD4  token: 0x6000352
        public static Unity.Mathematics.uint2 max(Unity.Mathematics.uint2 x, Unity.Mathematics.uint2 y) { }
        // RVA: 0x09C40B0C  token: 0x6000353
        public static Unity.Mathematics.uint3 max(Unity.Mathematics.uint3 x, Unity.Mathematics.uint3 y) { }
        // RVA: 0x09C409AC  token: 0x6000354
        public static Unity.Mathematics.uint4 max(Unity.Mathematics.uint4 x, Unity.Mathematics.uint4 y) { }
        // RVA: 0x09C40B00  token: 0x6000355
        public static System.Int64 max(System.Int64 x, System.Int64 y) { }
        // RVA: 0x09C4090C  token: 0x6000356
        public static System.UInt64 max(System.UInt64 x, System.UInt64 y) { }
        // RVA: 0x09C408F8  token: 0x6000357
        public static System.Single max(System.Single x, System.Single y) { }
        // RVA: 0x09C40B40  token: 0x6000358
        public static Unity.Mathematics.float2 max(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y) { }
        // RVA: 0x09C40888  token: 0x6000359
        public static Unity.Mathematics.float3 max(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y) { }
        // RVA: 0x04D3CD68  token: 0x600035A
        public static Unity.Mathematics.float4 max(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y) { }
        // RVA: 0x09C40918  token: 0x600035B
        public static System.Double max(System.Double x, System.Double y) { }
        // RVA: 0x04D3CEB4  token: 0x600035C
        public static Unity.Mathematics.double2 max(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y) { }
        // RVA: 0x09C40938  token: 0x600035D
        public static Unity.Mathematics.double3 max(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y) { }
        // RVA: 0x09C40A34  token: 0x600035E
        public static Unity.Mathematics.double4 max(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y) { }
        // RVA: 0x03D52690  token: 0x600035F
        public static System.Single lerp(System.Single start, System.Single end, System.Single t) { }
        // RVA: 0x09C4005C  token: 0x6000360
        public static Unity.Mathematics.float2 lerp(Unity.Mathematics.float2 start, Unity.Mathematics.float2 end, System.Single t) { }
        // RVA: 0x04D3C0B0  token: 0x6000361
        public static Unity.Mathematics.float3 lerp(Unity.Mathematics.float3 start, Unity.Mathematics.float3 end, System.Single t) { }
        // RVA: 0x09C40098  token: 0x6000362
        public static Unity.Mathematics.float4 lerp(Unity.Mathematics.float4 start, Unity.Mathematics.float4 end, System.Single t) { }
        // RVA: 0x09C3FC90  token: 0x6000363
        public static Unity.Mathematics.float2 lerp(Unity.Mathematics.float2 start, Unity.Mathematics.float2 end, Unity.Mathematics.float2 t) { }
        // RVA: 0x04D3BCA8  token: 0x6000364
        public static Unity.Mathematics.float3 lerp(Unity.Mathematics.float3 start, Unity.Mathematics.float3 end, Unity.Mathematics.float3 t) { }
        // RVA: 0x09C3FC08  token: 0x6000365
        public static Unity.Mathematics.float4 lerp(Unity.Mathematics.float4 start, Unity.Mathematics.float4 end, Unity.Mathematics.float4 t) { }
        // RVA: 0x03D7B850  token: 0x6000366
        public static System.Double lerp(System.Double start, System.Double end, System.Double t) { }
        // RVA: 0x09C3FB8C  token: 0x6000367
        public static Unity.Mathematics.double2 lerp(Unity.Mathematics.double2 start, Unity.Mathematics.double2 end, System.Double t) { }
        // RVA: 0x09C3FF9C  token: 0x6000368
        public static Unity.Mathematics.double3 lerp(Unity.Mathematics.double3 start, Unity.Mathematics.double3 end, System.Double t) { }
        // RVA: 0x09C3FE60  token: 0x6000369
        public static Unity.Mathematics.double4 lerp(Unity.Mathematics.double4 start, Unity.Mathematics.double4 end, System.Double t) { }
        // RVA: 0x09C3FF14  token: 0x600036A
        public static Unity.Mathematics.double2 lerp(Unity.Mathematics.double2 start, Unity.Mathematics.double2 end, Unity.Mathematics.double2 t) { }
        // RVA: 0x09C3FD90  token: 0x600036B
        public static Unity.Mathematics.double3 lerp(Unity.Mathematics.double3 start, Unity.Mathematics.double3 end, Unity.Mathematics.double3 t) { }
        // RVA: 0x09C3FCCC  token: 0x600036C
        public static Unity.Mathematics.double4 lerp(Unity.Mathematics.double4 start, Unity.Mathematics.double4 end, Unity.Mathematics.double4 t) { }
        // RVA: 0x09C58608  token: 0x600036D
        public static System.Single unlerp(System.Single start, System.Single end, System.Single x) { }
        // RVA: 0x09C586D0  token: 0x600036E
        public static Unity.Mathematics.float2 unlerp(Unity.Mathematics.float2 start, Unity.Mathematics.float2 end, Unity.Mathematics.float2 x) { }
        // RVA: 0x04D5E9BC  token: 0x600036F
        public static Unity.Mathematics.float3 unlerp(Unity.Mathematics.float3 start, Unity.Mathematics.float3 end, Unity.Mathematics.float3 x) { }
        // RVA: 0x09C58618  token: 0x6000370
        public static Unity.Mathematics.float4 unlerp(Unity.Mathematics.float4 start, Unity.Mathematics.float4 end, Unity.Mathematics.float4 x) { }
        // RVA: 0x09C58808  token: 0x6000371
        public static System.Double unlerp(System.Double start, System.Double end, System.Double x) { }
        // RVA: 0x09C58590  token: 0x6000372
        public static Unity.Mathematics.double2 unlerp(Unity.Mathematics.double2 start, Unity.Mathematics.double2 end, Unity.Mathematics.double2 x) { }
        // RVA: 0x09C584A0  token: 0x6000373
        public static Unity.Mathematics.double3 unlerp(Unity.Mathematics.double3 start, Unity.Mathematics.double3 end, Unity.Mathematics.double3 x) { }
        // RVA: 0x09C5872C  token: 0x6000374
        public static Unity.Mathematics.double4 unlerp(Unity.Mathematics.double4 start, Unity.Mathematics.double4 end, Unity.Mathematics.double4 x) { }
        // RVA: 0x09C51D50  token: 0x6000375
        public static System.Single remap(System.Single srcStart, System.Single srcEnd, System.Single dstStart, System.Single dstEnd, System.Single x) { }
        // RVA: 0x09C51CCC  token: 0x6000376
        public static Unity.Mathematics.float2 remap(Unity.Mathematics.float2 srcStart, Unity.Mathematics.float2 srcEnd, Unity.Mathematics.float2 dstStart, Unity.Mathematics.float2 dstEnd, Unity.Mathematics.float2 x) { }
        // RVA: 0x04D55754  token: 0x6000377
        public static Unity.Mathematics.float3 remap(Unity.Mathematics.float3 srcStart, Unity.Mathematics.float3 srcEnd, Unity.Mathematics.float3 dstStart, Unity.Mathematics.float3 dstEnd, Unity.Mathematics.float3 x) { }
        // RVA: 0x09C51C18  token: 0x6000378
        public static Unity.Mathematics.float4 remap(Unity.Mathematics.float4 srcStart, Unity.Mathematics.float4 srcEnd, Unity.Mathematics.float4 dstStart, Unity.Mathematics.float4 dstEnd, Unity.Mathematics.float4 x) { }
        // RVA: 0x09C51CA8  token: 0x6000379
        public static System.Double remap(System.Double srcStart, System.Double srcEnd, System.Double dstStart, System.Double dstEnd, System.Double x) { }
        // RVA: 0x09C51E54  token: 0x600037A
        public static Unity.Mathematics.double2 remap(Unity.Mathematics.double2 srcStart, Unity.Mathematics.double2 srcEnd, Unity.Mathematics.double2 dstStart, Unity.Mathematics.double2 dstEnd, Unity.Mathematics.double2 x) { }
        // RVA: 0x09C51D74  token: 0x600037B
        public static Unity.Mathematics.double3 remap(Unity.Mathematics.double3 srcStart, Unity.Mathematics.double3 srcEnd, Unity.Mathematics.double3 dstStart, Unity.Mathematics.double3 dstEnd, Unity.Mathematics.double3 x) { }
        // RVA: 0x09C51EE4  token: 0x600037C
        public static Unity.Mathematics.double4 remap(Unity.Mathematics.double4 srcStart, Unity.Mathematics.double4 srcEnd, Unity.Mathematics.double4 dstStart, Unity.Mathematics.double4 dstEnd, Unity.Mathematics.double4 x) { }
        // RVA: 0x03D7BC50  token: 0x600037D
        public static System.Int32 mad(System.Int32 mulA, System.Int32 mulB, System.Int32 addC) { }
        // RVA: 0x09C40608  token: 0x600037E
        public static Unity.Mathematics.int2 mad(Unity.Mathematics.int2 mulA, Unity.Mathematics.int2 mulB, Unity.Mathematics.int2 addC) { }
        // RVA: 0x04D3CA68  token: 0x600037F
        public static Unity.Mathematics.int3 mad(Unity.Mathematics.int3 mulA, Unity.Mathematics.int3 mulB, Unity.Mathematics.int3 addC) { }
        // RVA: 0x09C405A4  token: 0x6000380
        public static Unity.Mathematics.int4 mad(Unity.Mathematics.int4 mulA, Unity.Mathematics.int4 mulB, Unity.Mathematics.int4 addC) { }
        // RVA: 0x03D7BC50  token: 0x6000381
        public static System.UInt32 mad(System.UInt32 mulA, System.UInt32 mulB, System.UInt32 addC) { }
        // RVA: 0x09C40608  token: 0x6000382
        public static Unity.Mathematics.uint2 mad(Unity.Mathematics.uint2 mulA, Unity.Mathematics.uint2 mulB, Unity.Mathematics.uint2 addC) { }
        // RVA: 0x04D3CA68  token: 0x6000383
        public static Unity.Mathematics.uint3 mad(Unity.Mathematics.uint3 mulA, Unity.Mathematics.uint3 mulB, Unity.Mathematics.uint3 addC) { }
        // RVA: 0x09C405A4  token: 0x6000384
        public static Unity.Mathematics.uint4 mad(Unity.Mathematics.uint4 mulA, Unity.Mathematics.uint4 mulB, Unity.Mathematics.uint4 addC) { }
        // RVA: 0x03D7BC20  token: 0x6000385
        public static System.Int64 mad(System.Int64 mulA, System.Int64 mulB, System.Int64 addC) { }
        // RVA: 0x03D7BC20  token: 0x6000386
        public static System.UInt64 mad(System.UInt64 mulA, System.UInt64 mulB, System.UInt64 addC) { }
        // RVA: 0x03D7BC30  token: 0x6000387
        public static System.Single mad(System.Single mulA, System.Single mulB, System.Single addC) { }
        // RVA: 0x09C406B8  token: 0x6000388
        public static Unity.Mathematics.float2 mad(Unity.Mathematics.float2 mulA, Unity.Mathematics.float2 mulB, Unity.Mathematics.float2 addC) { }
        // RVA: 0x04D3CCE0  token: 0x6000389
        public static Unity.Mathematics.float3 mad(Unity.Mathematics.float3 mulA, Unity.Mathematics.float3 mulB, Unity.Mathematics.float3 addC) { }
        // RVA: 0x09C40734  token: 0x600038A
        public static Unity.Mathematics.float4 mad(Unity.Mathematics.float4 mulA, Unity.Mathematics.float4 mulB, Unity.Mathematics.float4 addC) { }
        // RVA: 0x03D7BC40  token: 0x600038B
        public static System.Double mad(System.Double mulA, System.Double mulB, System.Double addC) { }
        // RVA: 0x09C406D0  token: 0x600038C
        public static Unity.Mathematics.double2 mad(Unity.Mathematics.double2 mulA, Unity.Mathematics.double2 mulB, Unity.Mathematics.double2 addC) { }
        // RVA: 0x09C40620  token: 0x600038D
        public static Unity.Mathematics.double3 mad(Unity.Mathematics.double3 mulA, Unity.Mathematics.double3 mulB, Unity.Mathematics.double3 addC) { }
        // RVA: 0x09C40798  token: 0x600038E
        public static Unity.Mathematics.double4 mad(Unity.Mathematics.double4 mulA, Unity.Mathematics.double4 mulB, Unity.Mathematics.double4 addC) { }
        // RVA: 0x09C2F864  token: 0x600038F
        public static System.Int32 clamp(System.Int32 valueToClamp, System.Int32 lowerBound, System.Int32 upperBound) { }
        // RVA: 0x09C2F8B4  token: 0x6000390
        public static Unity.Mathematics.int2 clamp(Unity.Mathematics.int2 valueToClamp, Unity.Mathematics.int2 lowerBound, Unity.Mathematics.int2 upperBound) { }
        // RVA: 0x04D2E488  token: 0x6000391
        public static Unity.Mathematics.int3 clamp(Unity.Mathematics.int3 valueToClamp, Unity.Mathematics.int3 lowerBound, Unity.Mathematics.int3 upperBound) { }
        // RVA: 0x09C2F7A0  token: 0x6000392
        public static Unity.Mathematics.int4 clamp(Unity.Mathematics.int4 valueToClamp, Unity.Mathematics.int4 lowerBound, Unity.Mathematics.int4 upperBound) { }
        // RVA: 0x09C2F78C  token: 0x6000393
        public static System.UInt32 clamp(System.UInt32 valueToClamp, System.UInt32 lowerBound, System.UInt32 upperBound) { }
        // RVA: 0x09C2F668  token: 0x6000394
        public static Unity.Mathematics.uint2 clamp(Unity.Mathematics.uint2 valueToClamp, Unity.Mathematics.uint2 lowerBound, Unity.Mathematics.uint2 upperBound) { }
        // RVA: 0x04D2E630  token: 0x6000395
        public static Unity.Mathematics.uint3 clamp(Unity.Mathematics.uint3 valueToClamp, Unity.Mathematics.uint3 lowerBound, Unity.Mathematics.uint3 upperBound) { }
        // RVA: 0x09C2F4A0  token: 0x6000396
        public static Unity.Mathematics.uint4 clamp(Unity.Mathematics.uint4 valueToClamp, Unity.Mathematics.uint4 lowerBound, Unity.Mathematics.uint4 upperBound) { }
        // RVA: 0x09C2F6EC  token: 0x6000397
        public static System.Int64 clamp(System.Int64 valueToClamp, System.Int64 lowerBound, System.Int64 upperBound) { }
        // RVA: 0x09C2F8A0  token: 0x6000398
        public static System.UInt64 clamp(System.UInt64 valueToClamp, System.UInt64 lowerBound, System.UInt64 upperBound) { }
        // RVA: 0x09C2F878  token: 0x6000399
        public static System.Single clamp(System.Single valueToClamp, System.Single lowerBound, System.Single upperBound) { }
        // RVA: 0x09C2F6C4  token: 0x600039A
        public static Unity.Mathematics.float2 clamp(Unity.Mathematics.float2 valueToClamp, Unity.Mathematics.float2 lowerBound, Unity.Mathematics.float2 upperBound) { }
        // RVA: 0x09C2F700  token: 0x600039B
        public static Unity.Mathematics.float3 clamp(Unity.Mathematics.float3 valueToClamp, Unity.Mathematics.float3 lowerBound, Unity.Mathematics.float3 upperBound) { }
        // RVA: 0x09C2F564  token: 0x600039C
        public static Unity.Mathematics.float4 clamp(Unity.Mathematics.float4 valueToClamp, Unity.Mathematics.float4 lowerBound, Unity.Mathematics.float4 upperBound) { }
        // RVA: 0x04D2E358  token: 0x600039D
        public static System.Double clamp(System.Double valueToClamp, System.Double lowerBound, System.Double upperBound) { }
        // RVA: 0x09C2F910  token: 0x600039E
        public static Unity.Mathematics.double2 clamp(Unity.Mathematics.double2 valueToClamp, Unity.Mathematics.double2 lowerBound, Unity.Mathematics.double2 upperBound) { }
        // RVA: 0x09C2F5CC  token: 0x600039F
        public static Unity.Mathematics.double3 clamp(Unity.Mathematics.double3 valueToClamp, Unity.Mathematics.double3 lowerBound, Unity.Mathematics.double3 upperBound) { }
        // RVA: 0x09C2F978  token: 0x60003A0
        public static Unity.Mathematics.double4 clamp(Unity.Mathematics.double4 valueToClamp, Unity.Mathematics.double4 lowerBound, Unity.Mathematics.double4 upperBound) { }
        // RVA: 0x089C152C  token: 0x60003A1
        public static System.Single saturate(System.Single x) { }
        // RVA: 0x09C53300  token: 0x60003A2
        public static Unity.Mathematics.float2 saturate(Unity.Mathematics.float2 x) { }
        // RVA: 0x04D56B10  token: 0x60003A3
        public static Unity.Mathematics.float3 saturate(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C532B4  token: 0x60003A4
        public static Unity.Mathematics.float4 saturate(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C532A4  token: 0x60003A5
        public static System.Double saturate(System.Double x) { }
        // RVA: 0x09C533D8  token: 0x60003A6
        public static Unity.Mathematics.double2 saturate(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C5333C  token: 0x60003A7
        public static Unity.Mathematics.double3 saturate(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C53238  token: 0x60003A8
        public static Unity.Mathematics.double4 saturate(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C2E034  token: 0x60003A9
        public static System.Int32 abs(System.Int32 x) { }
        // RVA: 0x09C2DF38  token: 0x60003AA
        public static Unity.Mathematics.int2 abs(Unity.Mathematics.int2 x) { }
        // RVA: 0x04D2C678  token: 0x60003AB
        public static Unity.Mathematics.int3 abs(Unity.Mathematics.int3 x) { }
        // RVA: 0x09C2DF7C  token: 0x60003AC
        public static Unity.Mathematics.int4 abs(Unity.Mathematics.int4 x) { }
        // RVA: 0x09C2DF28  token: 0x60003AD
        public static System.Int64 abs(System.Int64 x) { }
        // RVA: 0x03D782D0  token: 0x60003AE
        public static System.Single abs(System.Single x) { }
        // RVA: 0x03D78390  token: 0x60003AF
        public static Unity.Mathematics.float2 abs(Unity.Mathematics.float2 x) { }
        // RVA: 0x02EE6450  token: 0x60003B0
        public static Unity.Mathematics.float3 abs(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C2DEF4  token: 0x60003B1
        public static Unity.Mathematics.float4 abs(Unity.Mathematics.float4 x) { }
        // RVA: 0x03D78370  token: 0x60003B2
        public static System.Double abs(System.Double x) { }
        // RVA: 0x03D78340  token: 0x60003B3
        public static Unity.Mathematics.double2 abs(Unity.Mathematics.double2 x) { }
        // RVA: 0x03D78290  token: 0x60003B4
        public static Unity.Mathematics.double3 abs(Unity.Mathematics.double3 x) { }
        // RVA: 0x03D782E0  token: 0x60003B5
        public static Unity.Mathematics.double4 abs(Unity.Mathematics.double4 x) { }
        // RVA: 0x03D79CC0  token: 0x60003B6
        public static System.Int32 dot(System.Int32 x, System.Int32 y) { }
        // RVA: 0x03D79D50  token: 0x60003B7
        public static System.Int32 dot(Unity.Mathematics.int2 x, Unity.Mathematics.int2 y) { }
        // RVA: 0x03D4E570  token: 0x60003B8
        public static System.Int32 dot(Unity.Mathematics.int3 x, Unity.Mathematics.int3 y) { }
        // RVA: 0x03D79D10  token: 0x60003B9
        public static System.Int32 dot(Unity.Mathematics.int4 x, Unity.Mathematics.int4 y) { }
        // RVA: 0x03D79CC0  token: 0x60003BA
        public static System.UInt32 dot(System.UInt32 x, System.UInt32 y) { }
        // RVA: 0x03D79D50  token: 0x60003BB
        public static System.UInt32 dot(Unity.Mathematics.uint2 x, Unity.Mathematics.uint2 y) { }
        // RVA: 0x03D4E570  token: 0x60003BC
        public static System.UInt32 dot(Unity.Mathematics.uint3 x, Unity.Mathematics.uint3 y) { }
        // RVA: 0x03D79D10  token: 0x60003BD
        public static System.UInt32 dot(Unity.Mathematics.uint4 x, Unity.Mathematics.uint4 y) { }
        // RVA: 0x03D79D70  token: 0x60003BE
        public static System.Single dot(System.Single x, System.Single y) { }
        // RVA: 0x03D542E0  token: 0x60003BF
        public static System.Single dot(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y) { }
        // RVA: 0x03D54460  token: 0x60003C0
        public static System.Single dot(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y) { }
        // RVA: 0x028B5400  token: 0x60003C1
        public static System.Single dot(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y) { }
        // RVA: 0x03D79D40  token: 0x60003C2
        public static System.Double dot(System.Double x, System.Double y) { }
        // RVA: 0x03D79DB0  token: 0x60003C3
        public static System.Double dot(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y) { }
        // RVA: 0x03D79D80  token: 0x60003C4
        public static System.Double dot(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y) { }
        // RVA: 0x03D79CD0  token: 0x60003C5
        public static System.Double dot(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y) { }
        // RVA: 0x09C56194  token: 0x60003C6
        public static System.Single tan(System.Single x) { }
        // RVA: 0x09C56020  token: 0x60003C7
        public static Unity.Mathematics.float2 tan(Unity.Mathematics.float2 x) { }
        // RVA: 0x04D5B65C  token: 0x60003C8
        public static Unity.Mathematics.float3 tan(Unity.Mathematics.float3 x) { }
        // RVA: 0x04D5B5D8  token: 0x60003C9
        public static Unity.Mathematics.float4 tan(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C56144  token: 0x60003CA
        public static System.Double tan(System.Double x) { }
        // RVA: 0x04D5B3F8  token: 0x60003CB
        public static Unity.Mathematics.double2 tan(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C560E0  token: 0x60003CC
        public static Unity.Mathematics.double3 tan(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C5605C  token: 0x60003CD
        public static Unity.Mathematics.double4 tan(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C56360  token: 0x60003CE
        public static System.Single tanh(System.Single x) { }
        // RVA: 0x09C56324  token: 0x60003CF
        public static Unity.Mathematics.float2 tanh(Unity.Mathematics.float2 x) { }
        // RVA: 0x04D5B8DC  token: 0x60003D0
        public static Unity.Mathematics.float3 tanh(Unity.Mathematics.float3 x) { }
        // RVA: 0x04D5B7C8  token: 0x60003D1
        public static Unity.Mathematics.float4 tanh(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C562D4  token: 0x60003D2
        public static System.Double tanh(System.Double x) { }
        // RVA: 0x04D5B998  token: 0x60003D3
        public static Unity.Mathematics.double2 tanh(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C561EC  token: 0x60003D4
        public static Unity.Mathematics.double3 tanh(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C56250  token: 0x60003D5
        public static Unity.Mathematics.double4 tanh(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C2EAD4  token: 0x60003D6
        public static System.Single atan(System.Single x) { }
        // RVA: 0x09C2EBE0  token: 0x60003D7
        public static Unity.Mathematics.float2 atan(Unity.Mathematics.float2 x) { }
        // RVA: 0x04D2D29C  token: 0x60003D8
        public static Unity.Mathematics.float3 atan(Unity.Mathematics.float3 x) { }
        // RVA: 0x04D2D218  token: 0x60003D9
        public static Unity.Mathematics.float4 atan(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C2EB90  token: 0x60003DA
        public static System.Double atan(System.Double x) { }
        // RVA: 0x04D2D460  token: 0x60003DB
        public static Unity.Mathematics.double2 atan(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C2EB2C  token: 0x60003DC
        public static Unity.Mathematics.double3 atan(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C2EA50  token: 0x60003DD
        public static Unity.Mathematics.double4 atan(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C2E948  token: 0x60003DE
        public static System.Single atan2(System.Single y, System.Single x) { }
        // RVA: 0x09C2E8FC  token: 0x60003DF
        public static Unity.Mathematics.float2 atan2(Unity.Mathematics.float2 y, Unity.Mathematics.float2 x) { }
        // RVA: 0x04D2CFA0  token: 0x60003E0
        public static Unity.Mathematics.float3 atan2(Unity.Mathematics.float3 y, Unity.Mathematics.float3 x) { }
        // RVA: 0x04D2D0D0  token: 0x60003E1
        public static Unity.Mathematics.float4 atan2(Unity.Mathematics.float4 y, Unity.Mathematics.float4 x) { }
        // RVA: 0x09C2E89C  token: 0x60003E2
        public static System.Double atan2(System.Double y, System.Double x) { }
        // RVA: 0x04D2D070  token: 0x60003E3
        public static Unity.Mathematics.double2 atan2(Unity.Mathematics.double2 y, Unity.Mathematics.double2 x) { }
        // RVA: 0x09C2E81C  token: 0x60003E4
        public static Unity.Mathematics.double3 atan2(Unity.Mathematics.double3 y, Unity.Mathematics.double3 x) { }
        // RVA: 0x09C2E9AC  token: 0x60003E5
        public static Unity.Mathematics.double4 atan2(Unity.Mathematics.double4 y, Unity.Mathematics.double4 x) { }
        // RVA: 0x09C2FD74  token: 0x60003E6
        public static System.Single cos(System.Single x) { }
        // RVA: 0x03D78DD0  token: 0x60003E7
        public static Unity.Mathematics.float2 cos(Unity.Mathematics.float2 x) { }
        // RVA: 0x03D78E60  token: 0x60003E8
        public static Unity.Mathematics.float3 cos(Unity.Mathematics.float3 x) { }
        // RVA: 0x03D78F50  token: 0x60003E9
        public static Unity.Mathematics.float4 cos(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C2FDCC  token: 0x60003EA
        public static System.Double cos(System.Double x) { }
        // RVA: 0x03D78EB0  token: 0x60003EB
        public static Unity.Mathematics.double2 cos(Unity.Mathematics.double2 x) { }
        // RVA: 0x03D78E10  token: 0x60003EC
        public static Unity.Mathematics.double3 cos(Unity.Mathematics.double3 x) { }
        // RVA: 0x03D78EF0  token: 0x60003ED
        public static Unity.Mathematics.double4 cos(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C2FE1C  token: 0x60003EE
        public static System.Single cosh(System.Single x) { }
        // RVA: 0x03D78FB0  token: 0x60003EF
        public static Unity.Mathematics.float2 cosh(Unity.Mathematics.float2 x) { }
        // RVA: 0x03D79040  token: 0x60003F0
        public static Unity.Mathematics.float3 cosh(Unity.Mathematics.float3 x) { }
        // RVA: 0x03D790F0  token: 0x60003F1
        public static Unity.Mathematics.float4 cosh(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C2FE74  token: 0x60003F2
        public static System.Double cosh(System.Double x) { }
        // RVA: 0x03D79150  token: 0x60003F3
        public static Unity.Mathematics.double2 cosh(Unity.Mathematics.double2 x) { }
        // RVA: 0x03D78FF0  token: 0x60003F4
        public static Unity.Mathematics.double3 cosh(Unity.Mathematics.double3 x) { }
        // RVA: 0x03D79090  token: 0x60003F5
        public static Unity.Mathematics.double4 cosh(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C2E090  token: 0x60003F6
        public static System.Single acos(System.Single x) { }
        // RVA: 0x03D783C0  token: 0x60003F7
        public static Unity.Mathematics.float2 acos(Unity.Mathematics.float2 x) { }
        // RVA: 0x03D78400  token: 0x60003F8
        public static Unity.Mathematics.float3 acos(Unity.Mathematics.float3 x) { }
        // RVA: 0x03D784B0  token: 0x60003F9
        public static Unity.Mathematics.float4 acos(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C2E040  token: 0x60003FA
        public static System.Double acos(System.Double x) { }
        // RVA: 0x03D78510  token: 0x60003FB
        public static Unity.Mathematics.double2 acos(Unity.Mathematics.double2 x) { }
        // RVA: 0x03D78550  token: 0x60003FC
        public static Unity.Mathematics.double3 acos(Unity.Mathematics.double3 x) { }
        // RVA: 0x03D78450  token: 0x60003FD
        public static Unity.Mathematics.double4 acos(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C54DA4  token: 0x60003FE
        public static System.Single sin(System.Single x) { }
        // RVA: 0x03D7CDA0  token: 0x60003FF
        public static Unity.Mathematics.float2 sin(Unity.Mathematics.float2 x) { }
        // RVA: 0x03D7CC90  token: 0x6000400
        public static Unity.Mathematics.float3 sin(Unity.Mathematics.float3 x) { }
        // RVA: 0x03D7CD40  token: 0x6000401
        public static Unity.Mathematics.float4 sin(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C54DFC  token: 0x6000402
        public static System.Double sin(System.Double x) { }
        // RVA: 0x03D7CDE0  token: 0x6000403
        public static Unity.Mathematics.double2 sin(Unity.Mathematics.double2 x) { }
        // RVA: 0x03D7CC40  token: 0x6000404
        public static Unity.Mathematics.double3 sin(Unity.Mathematics.double3 x) { }
        // RVA: 0x03D7CCE0  token: 0x6000405
        public static Unity.Mathematics.double4 sin(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C55144  token: 0x6000406
        public static System.Single sinh(System.Single x) { }
        // RVA: 0x03D7D040  token: 0x6000407
        public static Unity.Mathematics.float2 sinh(Unity.Mathematics.float2 x) { }
        // RVA: 0x03D7CEE0  token: 0x6000408
        public static Unity.Mathematics.float3 sinh(Unity.Mathematics.float3 x) { }
        // RVA: 0x03D7CFE0  token: 0x6000409
        public static Unity.Mathematics.float4 sinh(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C550F4  token: 0x600040A
        public static System.Double sinh(System.Double x) { }
        // RVA: 0x03D7CEA0  token: 0x600040B
        public static Unity.Mathematics.double2 sinh(Unity.Mathematics.double2 x) { }
        // RVA: 0x03D7CF90  token: 0x600040C
        public static Unity.Mathematics.double3 sinh(Unity.Mathematics.double3 x) { }
        // RVA: 0x03D7CF30  token: 0x600040D
        public static Unity.Mathematics.double4 sinh(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C2E7C4  token: 0x600040E
        public static System.Single asin(System.Single x) { }
        // RVA: 0x03D785C0  token: 0x600040F
        public static Unity.Mathematics.float2 asin(Unity.Mathematics.float2 x) { }
        // RVA: 0x03D78660  token: 0x6000410
        public static Unity.Mathematics.float3 asin(Unity.Mathematics.float3 x) { }
        // RVA: 0x03D78740  token: 0x6000411
        public static Unity.Mathematics.float4 asin(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C2E774  token: 0x6000412
        public static System.Double asin(System.Double x) { }
        // RVA: 0x03D78700  token: 0x6000413
        public static Unity.Mathematics.double2 asin(Unity.Mathematics.double2 x) { }
        // RVA: 0x03D786B0  token: 0x6000414
        public static Unity.Mathematics.double3 asin(Unity.Mathematics.double3 x) { }
        // RVA: 0x03D78600  token: 0x6000415
        public static Unity.Mathematics.double4 asin(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C353A0  token: 0x6000416
        public static System.Single floor(System.Single x) { }
        // RVA: 0x03D7AE40  token: 0x6000417
        public static Unity.Mathematics.float2 floor(Unity.Mathematics.float2 x) { }
        // RVA: 0x033424B0  token: 0x6000418
        public static Unity.Mathematics.float3 floor(Unity.Mathematics.float3 x) { }
        // RVA: 0x03D7ACF0  token: 0x6000419
        public static Unity.Mathematics.float4 floor(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C353F8  token: 0x600041A
        public static System.Double floor(System.Double x) { }
        // RVA: 0x03D7AE00  token: 0x600041B
        public static Unity.Mathematics.double2 floor(Unity.Mathematics.double2 x) { }
        // RVA: 0x03D7AD50  token: 0x600041C
        public static Unity.Mathematics.double3 floor(Unity.Mathematics.double3 x) { }
        // RVA: 0x03D7ADA0  token: 0x600041D
        public static Unity.Mathematics.double4 floor(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C2EE18  token: 0x600041E
        public static System.Single ceil(System.Single x) { }
        // RVA: 0x03D78B80  token: 0x600041F
        public static Unity.Mathematics.float2 ceil(Unity.Mathematics.float2 x) { }
        // RVA: 0x03D78CC0  token: 0x6000420
        public static Unity.Mathematics.float3 ceil(Unity.Mathematics.float3 x) { }
        // RVA: 0x03D78C00  token: 0x6000421
        public static Unity.Mathematics.float4 ceil(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C2EE70  token: 0x6000422
        public static System.Double ceil(System.Double x) { }
        // RVA: 0x03D78BC0  token: 0x6000423
        public static Unity.Mathematics.double2 ceil(Unity.Mathematics.double2 x) { }
        // RVA: 0x03D78B30  token: 0x6000424
        public static Unity.Mathematics.double3 ceil(Unity.Mathematics.double3 x) { }
        // RVA: 0x03D78C60  token: 0x6000425
        public static Unity.Mathematics.double4 ceil(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C52E74  token: 0x6000426
        public static System.Single round(System.Single x) { }
        // RVA: 0x09C52FB4  token: 0x6000427
        public static Unity.Mathematics.float2 round(Unity.Mathematics.float2 x) { }
        // RVA: 0x04D566C4  token: 0x6000428
        public static Unity.Mathematics.float3 round(Unity.Mathematics.float3 x) { }
        // RVA: 0x04D56830  token: 0x6000429
        public static Unity.Mathematics.float4 round(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C52E24  token: 0x600042A
        public static System.Double round(System.Double x) { }
        // RVA: 0x04D5667C  token: 0x600042B
        public static Unity.Mathematics.double2 round(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C52ECC  token: 0x600042C
        public static Unity.Mathematics.double3 round(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C52F30  token: 0x600042D
        public static Unity.Mathematics.double4 round(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C5783C  token: 0x600042E
        public static System.Single trunc(System.Single x) { }
        // RVA: 0x09C57800  token: 0x600042F
        public static Unity.Mathematics.float2 trunc(Unity.Mathematics.float2 x) { }
        // RVA: 0x04D5E128  token: 0x6000430
        public static Unity.Mathematics.float3 trunc(Unity.Mathematics.float3 x) { }
        // RVA: 0x04D5DFD0  token: 0x6000431
        public static Unity.Mathematics.float4 trunc(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C576C8  token: 0x6000432
        public static System.Double trunc(System.Double x) { }
        // RVA: 0x04D5E210  token: 0x6000433
        public static Unity.Mathematics.double2 trunc(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C57718  token: 0x6000434
        public static Unity.Mathematics.double3 trunc(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C5777C  token: 0x6000435
        public static Unity.Mathematics.double4 trunc(Unity.Mathematics.double4 x) { }
        // RVA: 0x03D6D920  token: 0x6000436
        public static System.Single frac(System.Single x) { }
        // RVA: 0x09C35560  token: 0x6000437
        public static Unity.Mathematics.float2 frac(Unity.Mathematics.float2 x) { }
        // RVA: 0x04D32EC4  token: 0x6000438
        public static Unity.Mathematics.float3 frac(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C354FC  token: 0x6000439
        public static Unity.Mathematics.float4 frac(Unity.Mathematics.float4 x) { }
        // RVA: 0x03D7B290  token: 0x600043A
        public static System.Double frac(System.Double x) { }
        // RVA: 0x09C35624  token: 0x600043B
        public static Unity.Mathematics.double2 frac(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C35590  token: 0x600043C
        public static Unity.Mathematics.double3 frac(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C35688  token: 0x600043D
        public static Unity.Mathematics.double4 frac(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C5128C  token: 0x600043E
        public static System.Single rcp(System.Single x) { }
        // RVA: 0x09C5114C  token: 0x600043F
        public static Unity.Mathematics.float2 rcp(Unity.Mathematics.float2 x) { }
        // RVA: 0x09C511B8  token: 0x6000440
        public static Unity.Mathematics.float3 rcp(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C51220  token: 0x6000441
        public static Unity.Mathematics.float4 rcp(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C5113C  token: 0x6000442
        public static System.Double rcp(System.Double x) { }
        // RVA: 0x09C511F8  token: 0x6000443
        public static Unity.Mathematics.double2 rcp(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C51100  token: 0x6000444
        public static Unity.Mathematics.double3 rcp(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C51174  token: 0x6000445
        public static Unity.Mathematics.double4 rcp(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C54B60  token: 0x6000446
        public static System.Int32 sign(System.Int32 x) { }
        // RVA: 0x09C54CA8  token: 0x6000447
        public static Unity.Mathematics.int2 sign(Unity.Mathematics.int2 x) { }
        // RVA: 0x09C54D5C  token: 0x6000448
        public static Unity.Mathematics.int3 sign(Unity.Mathematics.int3 x) { }
        // RVA: 0x09C54C48  token: 0x6000449
        public static Unity.Mathematics.int4 sign(Unity.Mathematics.int4 x) { }
        // RVA: 0x04D59FAC  token: 0x600044A
        public static System.Single sign(System.Single x) { }
        // RVA: 0x09C54BA8  token: 0x600044B
        public static Unity.Mathematics.float2 sign(Unity.Mathematics.float2 x) { }
        // RVA: 0x09C54D24  token: 0x600044C
        public static Unity.Mathematics.float3 sign(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C54C00  token: 0x600044D
        public static Unity.Mathematics.float4 sign(Unity.Mathematics.float4 x) { }
        // RVA: 0x04D59F74  token: 0x600044E
        public static System.Double sign(System.Double x) { }
        // RVA: 0x09C54BD8  token: 0x600044F
        public static Unity.Mathematics.double2 sign(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C54B70  token: 0x6000450
        public static Unity.Mathematics.double3 sign(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C54CDC  token: 0x6000451
        public static Unity.Mathematics.double4 sign(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C5064C  token: 0x6000452
        public static System.Single pow(System.Single x, System.Single y) { }
        // RVA: 0x09C506B0  token: 0x6000453
        public static Unity.Mathematics.float2 pow(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y) { }
        // RVA: 0x04D53BF4  token: 0x6000454
        public static Unity.Mathematics.float3 pow(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y) { }
        // RVA: 0x04D53EEC  token: 0x6000455
        public static Unity.Mathematics.float4 pow(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y) { }
        // RVA: 0x09C506FC  token: 0x6000456
        public static System.Double pow(System.Double x, System.Double y) { }
        // RVA: 0x04D53E8C  token: 0x6000457
        public static Unity.Mathematics.double2 pow(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y) { }
        // RVA: 0x09C505CC  token: 0x6000458
        public static Unity.Mathematics.double3 pow(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y) { }
        // RVA: 0x09C5075C  token: 0x6000459
        public static Unity.Mathematics.double4 pow(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y) { }
        // RVA: 0x09C320B4  token: 0x600045A
        public static System.Single exp(System.Single x) { }
        // RVA: 0x03D7A580  token: 0x600045B
        public static Unity.Mathematics.float2 exp(Unity.Mathematics.float2 x) { }
        // RVA: 0x03D7A6B0  token: 0x600045C
        public static Unity.Mathematics.float3 exp(Unity.Mathematics.float3 x) { }
        // RVA: 0x03D7A520  token: 0x600045D
        public static Unity.Mathematics.float4 exp(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C32064  token: 0x600045E
        public static System.Double exp(System.Double x) { }
        // RVA: 0x03D7A5C0  token: 0x600045F
        public static Unity.Mathematics.double2 exp(Unity.Mathematics.double2 x) { }
        // RVA: 0x03D7A600  token: 0x6000460
        public static Unity.Mathematics.double3 exp(Unity.Mathematics.double3 x) { }
        // RVA: 0x03D7A650  token: 0x6000461
        public static Unity.Mathematics.double4 exp(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C31E88  token: 0x6000462
        public static System.Single exp2(System.Single x) { }
        // RVA: 0x09C32028  token: 0x6000463
        public static Unity.Mathematics.float2 exp2(Unity.Mathematics.float2 x) { }
        // RVA: 0x04D30974  token: 0x6000464
        public static Unity.Mathematics.float3 exp2(Unity.Mathematics.float3 x) { }
        // RVA: 0x04D30C20  token: 0x6000465
        public static Unity.Mathematics.float4 exp2(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C31EE8  token: 0x6000466
        public static System.Double exp2(System.Double x) { }
        // RVA: 0x04D30A90  token: 0x6000467
        public static Unity.Mathematics.double2 exp2(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C31F40  token: 0x6000468
        public static Unity.Mathematics.double3 exp2(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C31FA4  token: 0x6000469
        public static Unity.Mathematics.double4 exp2(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C31E28  token: 0x600046A
        public static System.Single exp10(System.Single x) { }
        // RVA: 0x09C31CAC  token: 0x600046B
        public static Unity.Mathematics.float2 exp10(Unity.Mathematics.float2 x) { }
        // RVA: 0x04D30644  token: 0x600046C
        public static Unity.Mathematics.float3 exp10(Unity.Mathematics.float3 x) { }
        // RVA: 0x04D307B4  token: 0x600046D
        public static Unity.Mathematics.float4 exp10(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C31D6C  token: 0x600046E
        public static System.Double exp10(System.Double x) { }
        // RVA: 0x04D306E8  token: 0x600046F
        public static Unity.Mathematics.double2 exp10(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C31DC4  token: 0x6000470
        public static Unity.Mathematics.double3 exp10(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C31CE8  token: 0x6000471
        public static Unity.Mathematics.double4 exp10(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C403E8  token: 0x6000472
        public static System.Single log(System.Single x) { }
        // RVA: 0x03D7BAE0  token: 0x6000473
        public static Unity.Mathematics.float2 log(Unity.Mathematics.float2 x) { }
        // RVA: 0x03D7BB70  token: 0x6000474
        public static Unity.Mathematics.float3 log(Unity.Mathematics.float3 x) { }
        // RVA: 0x03D7BA80  token: 0x6000475
        public static Unity.Mathematics.float4 log(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C40398  token: 0x6000476
        public static System.Double log(System.Double x) { }
        // RVA: 0x03D7BA40  token: 0x6000477
        public static Unity.Mathematics.double2 log(Unity.Mathematics.double2 x) { }
        // RVA: 0x03D7BB20  token: 0x6000478
        public static Unity.Mathematics.double3 log(Unity.Mathematics.double3 x) { }
        // RVA: 0x03D7BBC0  token: 0x6000479
        public static Unity.Mathematics.double4 log(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C401BC  token: 0x600047A
        public static System.Single log2(System.Single x) { }
        // RVA: 0x09C40218  token: 0x600047B
        public static Unity.Mathematics.float2 log2(Unity.Mathematics.float2 x) { }
        // RVA: 0x04D3C568  token: 0x600047C
        public static Unity.Mathematics.float3 log2(Unity.Mathematics.float3 x) { }
        // RVA: 0x04D3C5CC  token: 0x600047D
        public static Unity.Mathematics.float4 log2(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C40254  token: 0x600047E
        public static System.Double log2(System.Double x) { }
        // RVA: 0x04D3C4C4  token: 0x600047F
        public static Unity.Mathematics.double2 log2(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C402B0  token: 0x6000480
        public static Unity.Mathematics.double3 log2(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C40314  token: 0x6000481
        public static Unity.Mathematics.double4 log2(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C40114  token: 0x6000482
        public static System.Single log10(System.Single x) { }
        // RVA: 0x03D7B9B0  token: 0x6000483
        public static Unity.Mathematics.float2 log10(Unity.Mathematics.float2 x) { }
        // RVA: 0x03D7B9F0  token: 0x6000484
        public static Unity.Mathematics.float3 log10(Unity.Mathematics.float3 x) { }
        // RVA: 0x03D7B900  token: 0x6000485
        public static Unity.Mathematics.float4 log10(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C4016C  token: 0x6000486
        public static System.Double log10(System.Double x) { }
        // RVA: 0x03D7B860  token: 0x6000487
        public static Unity.Mathematics.double2 log10(Unity.Mathematics.double2 x) { }
        // RVA: 0x03D7B960  token: 0x6000488
        public static Unity.Mathematics.double3 log10(Unity.Mathematics.double3 x) { }
        // RVA: 0x03D7B8A0  token: 0x6000489
        public static Unity.Mathematics.double4 log10(Unity.Mathematics.double4 x) { }
        // RVA: 0x03D51650  token: 0x600048A
        public static System.Single fmod(System.Single x, System.Single y) { }
        // RVA: 0x03D7AF60  token: 0x600048B
        public static Unity.Mathematics.float2 fmod(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y) { }
        // RVA: 0x03D7AE80  token: 0x600048C
        public static Unity.Mathematics.float3 fmod(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y) { }
        // RVA: 0x03D7AFB0  token: 0x600048D
        public static Unity.Mathematics.float4 fmod(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y) { }
        // RVA: 0x03D7B110  token: 0x600048E
        public static System.Double fmod(System.Double x, System.Double y) { }
        // RVA: 0x03D7B0B0  token: 0x600048F
        public static Unity.Mathematics.double2 fmod(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y) { }
        // RVA: 0x03D7AEF0  token: 0x6000490
        public static Unity.Mathematics.double3 fmod(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y) { }
        // RVA: 0x03D7B030  token: 0x6000491
        public static Unity.Mathematics.double4 fmod(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y) { }
        // RVA: 0x09C4117C  token: 0x6000492
        public static System.Single modf(System.Single x, System.Single& i) { }
        // RVA: 0x09C41034  token: 0x6000493
        public static Unity.Mathematics.float2 modf(Unity.Mathematics.float2 x, Unity.Mathematics.float2& i) { }
        // RVA: 0x04D3D390  token: 0x6000494
        public static Unity.Mathematics.float3 modf(Unity.Mathematics.float3 x, Unity.Mathematics.float3& i) { }
        // RVA: 0x09C40F94  token: 0x6000495
        public static Unity.Mathematics.float4 modf(Unity.Mathematics.float4 x, Unity.Mathematics.float4& i) { }
        // RVA: 0x09C41008  token: 0x6000496
        public static System.Double modf(System.Double x, System.Double& i) { }
        // RVA: 0x09C41108  token: 0x6000497
        public static Unity.Mathematics.double2 modf(Unity.Mathematics.double2 x, Unity.Mathematics.double2& i) { }
        // RVA: 0x09C40EF0  token: 0x6000498
        public static Unity.Mathematics.double3 modf(Unity.Mathematics.double3 x, Unity.Mathematics.double3& i) { }
        // RVA: 0x09C4106C  token: 0x6000499
        public static Unity.Mathematics.double4 modf(Unity.Mathematics.double4 x, Unity.Mathematics.double4& i) { }
        // RVA: 0x09C55AA4  token: 0x600049A
        public static System.Single sqrt(System.Single x) { }
        // RVA: 0x03D7D080  token: 0x600049B
        public static Unity.Mathematics.float2 sqrt(Unity.Mathematics.float2 x) { }
        // RVA: 0x03D7D370  token: 0x600049C
        public static Unity.Mathematics.float3 sqrt(Unity.Mathematics.float3 x) { }
        // RVA: 0x03D7D0F0  token: 0x600049D
        public static Unity.Mathematics.float4 sqrt(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C55A5C  token: 0x600049E
        public static System.Double sqrt(System.Double x) { }
        // RVA: 0x03D7D1B0  token: 0x600049F
        public static Unity.Mathematics.double2 sqrt(Unity.Mathematics.double2 x) { }
        // RVA: 0x03D7D2E0  token: 0x60004A0
        public static Unity.Mathematics.double3 sqrt(Unity.Mathematics.double3 x) { }
        // RVA: 0x03D7D220  token: 0x60004A1
        public static Unity.Mathematics.double4 sqrt(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C530D8  token: 0x60004A2
        public static System.Single rsqrt(System.Single x) { }
        // RVA: 0x09C5318C  token: 0x60004A3
        public static Unity.Mathematics.float2 rsqrt(Unity.Mathematics.float2 x) { }
        // RVA: 0x04D568F4  token: 0x60004A4
        public static Unity.Mathematics.float3 rsqrt(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C53108  token: 0x60004A5
        public static Unity.Mathematics.float4 rsqrt(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C531C0  token: 0x60004A6
        public static System.Double rsqrt(System.Double x) { }
        // RVA: 0x09C531F0  token: 0x60004A7
        public static Unity.Mathematics.double2 rsqrt(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C52FF0  token: 0x60004A8
        public static Unity.Mathematics.double3 rsqrt(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C53068  token: 0x60004A9
        public static Unity.Mathematics.double4 rsqrt(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C4FDB0  token: 0x60004AA
        public static Unity.Mathematics.float2 normalize(Unity.Mathematics.float2 x) { }
        // RVA: 0x09C4FE18  token: 0x60004AB
        public static Unity.Mathematics.float3 normalize(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C4FCD8  token: 0x60004AC
        public static Unity.Mathematics.float4 normalize(Unity.Mathematics.float4 x) { }
        // RVA: 0x04D536EC  token: 0x60004AD
        public static Unity.Mathematics.double2 normalize(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C4FC58  token: 0x60004AE
        public static Unity.Mathematics.double3 normalize(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C4FD34  token: 0x60004AF
        public static Unity.Mathematics.double4 normalize(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C4FF3C  token: 0x60004B0
        public static Unity.Mathematics.float2 normalizesafe(Unity.Mathematics.float2 x, Unity.Mathematics.float2 defaultvalue) { }
        // RVA: 0x04D539D4  token: 0x60004B1
        public static Unity.Mathematics.float3 normalizesafe(Unity.Mathematics.float3 x, Unity.Mathematics.float3 defaultvalue) { }
        // RVA: 0x09C4FFC4  token: 0x60004B2
        public static Unity.Mathematics.float4 normalizesafe(Unity.Mathematics.float4 x, Unity.Mathematics.float4 defaultvalue) { }
        // RVA: 0x04D53A74  token: 0x60004B3
        public static Unity.Mathematics.double2 normalizesafe(Unity.Mathematics.double2 x, Unity.Mathematics.double2 defaultvalue) { }
        // RVA: 0x09C50110  token: 0x60004B4
        public static Unity.Mathematics.double3 normalizesafe(Unity.Mathematics.double3 x, Unity.Mathematics.double3 defaultvalue) { }
        // RVA: 0x09C4FE8C  token: 0x60004B5
        public static Unity.Mathematics.double4 normalizesafe(Unity.Mathematics.double4 x, Unity.Mathematics.double4 defaultvalue) { }
        // RVA: 0x03D782D0  token: 0x60004B6
        public static System.Single length(System.Single x) { }
        // RVA: 0x03D54350  token: 0x60004B7
        public static System.Single length(Unity.Mathematics.float2 x) { }
        // RVA: 0x09C3F9E4  token: 0x60004B8
        public static System.Single length(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C3FA88  token: 0x60004B9
        public static System.Single length(Unity.Mathematics.float4 x) { }
        // RVA: 0x03D78370  token: 0x60004BA
        public static System.Double length(System.Double x) { }
        // RVA: 0x03D7B7E0  token: 0x60004BB
        public static System.Double length(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C3FA50  token: 0x60004BC
        public static System.Double length(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C3FA1C  token: 0x60004BD
        public static System.Double length(Unity.Mathematics.double4 x) { }
        // RVA: 0x03D51490  token: 0x60004BE
        public static System.Single lengthsq(System.Single x) { }
        // RVA: 0x03D54330  token: 0x60004BF
        public static System.Single lengthsq(Unity.Mathematics.float2 x) { }
        // RVA: 0x09C3FB24  token: 0x60004C0
        public static System.Single lengthsq(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C3FAC4  token: 0x60004C1
        public static System.Single lengthsq(Unity.Mathematics.float4 x) { }
        // RVA: 0x03D7B840  token: 0x60004C2
        public static System.Double lengthsq(System.Double x) { }
        // RVA: 0x03D7B820  token: 0x60004C3
        public static System.Double lengthsq(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C3FAEC  token: 0x60004C4
        public static System.Double lengthsq(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C3FB58  token: 0x60004C5
        public static System.Double lengthsq(Unity.Mathematics.double4 x) { }
        // RVA: 0x03D79C60  token: 0x60004C6
        public static System.Single distance(System.Single x, System.Single y) { }
        // RVA: 0x09C30834  token: 0x60004C7
        public static System.Single distance(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y) { }
        // RVA: 0x09C306C0  token: 0x60004C8
        public static System.Single distance(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y) { }
        // RVA: 0x09C30794  token: 0x60004C9
        public static System.Single distance(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y) { }
        // RVA: 0x03D79C80  token: 0x60004CA
        public static System.Double distance(System.Double x, System.Double y) { }
        // RVA: 0x09C307F4  token: 0x60004CB
        public static System.Double distance(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y) { }
        // RVA: 0x09C3064C  token: 0x60004CC
        public static System.Double distance(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y) { }
        // RVA: 0x09C30728  token: 0x60004CD
        public static System.Double distance(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y) { }
        // RVA: 0x03D79CA0  token: 0x60004CE
        public static System.Single distancesq(System.Single x, System.Single y) { }
        // RVA: 0x09C30870  token: 0x60004CF
        public static System.Single distancesq(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y) { }
        // RVA: 0x09C309CC  token: 0x60004D0
        public static System.Single distancesq(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y) { }
        // RVA: 0x09C308A8  token: 0x60004D1
        public static System.Single distancesq(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y) { }
        // RVA: 0x03D79CB0  token: 0x60004D2
        public static System.Double distancesq(System.Double x, System.Double y) { }
        // RVA: 0x09C30A30  token: 0x60004D3
        public static System.Double distancesq(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y) { }
        // RVA: 0x09C3095C  token: 0x60004D4
        public static System.Double distancesq(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y) { }
        // RVA: 0x09C308F4  token: 0x60004D5
        public static System.Double distancesq(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y) { }
        // RVA: 0x09C30228  token: 0x60004D6
        public static Unity.Mathematics.float3 cross(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y) { }
        // RVA: 0x09C30310  token: 0x60004D7
        public static Unity.Mathematics.double3 cross(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y) { }
        // RVA: 0x09C557AC  token: 0x60004D8
        public static System.Single smoothstep(System.Single xMin, System.Single xMax, System.Single x) { }
        // RVA: 0x09C557F8  token: 0x60004D9
        public static Unity.Mathematics.float2 smoothstep(Unity.Mathematics.float2 xMin, Unity.Mathematics.float2 xMax, Unity.Mathematics.float2 x) { }
        // RVA: 0x04D5A674  token: 0x60004DA
        public static Unity.Mathematics.float3 smoothstep(Unity.Mathematics.float3 xMin, Unity.Mathematics.float3 xMax, Unity.Mathematics.float3 x) { }
        // RVA: 0x09C55914  token: 0x60004DB
        public static Unity.Mathematics.float4 smoothstep(Unity.Mathematics.float4 xMin, Unity.Mathematics.float4 xMax, Unity.Mathematics.float4 x) { }
        // RVA: 0x09C558C8  token: 0x60004DC
        public static System.Double smoothstep(System.Double xMin, System.Double xMax, System.Double x) { }
        // RVA: 0x09C5533C  token: 0x60004DD
        public static Unity.Mathematics.double2 smoothstep(Unity.Mathematics.double2 xMin, Unity.Mathematics.double2 xMax, Unity.Mathematics.double2 x) { }
        // RVA: 0x09C555EC  token: 0x60004DE
        public static Unity.Mathematics.double3 smoothstep(Unity.Mathematics.double3 xMin, Unity.Mathematics.double3 xMax, Unity.Mathematics.double3 x) { }
        // RVA: 0x09C5544C  token: 0x60004DF
        public static Unity.Mathematics.double4 smoothstep(Unity.Mathematics.double4 xMin, Unity.Mathematics.double4 xMax, Unity.Mathematics.double4 x) { }
        // RVA: 0x09C2E5F8  token: 0x60004E0
        public static System.Boolean any(Unity.Mathematics.bool2 x) { }
        // RVA: 0x09C2E6B4  token: 0x60004E1
        public static System.Boolean any(Unity.Mathematics.bool3 x) { }
        // RVA: 0x04D2CD54  token: 0x60004E2
        public static System.Boolean any(Unity.Mathematics.bool4 x) { }
        // RVA: 0x09C2E5E4  token: 0x60004E3
        public static System.Boolean any(Unity.Mathematics.int2 x) { }
        // RVA: 0x09C2E608  token: 0x60004E4
        public static System.Boolean any(Unity.Mathematics.int3 x) { }
        // RVA: 0x09C2E5C8  token: 0x60004E5
        public static System.Boolean any(Unity.Mathematics.int4 x) { }
        // RVA: 0x09C2E5E4  token: 0x60004E6
        public static System.Boolean any(Unity.Mathematics.uint2 x) { }
        // RVA: 0x09C2E608  token: 0x60004E7
        public static System.Boolean any(Unity.Mathematics.uint3 x) { }
        // RVA: 0x09C2E5C8  token: 0x60004E8
        public static System.Boolean any(Unity.Mathematics.uint4 x) { }
        // RVA: 0x09C2E6C8  token: 0x60004E9
        public static System.Boolean any(Unity.Mathematics.float2 x) { }
        // RVA: 0x09C2E644  token: 0x60004EA
        public static System.Boolean any(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C2E6F0  token: 0x60004EB
        public static System.Boolean any(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C2E620  token: 0x60004EC
        public static System.Boolean any(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C2E728  token: 0x60004ED
        public static System.Boolean any(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C2E670  token: 0x60004EE
        public static System.Boolean any(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C2E3B8  token: 0x60004EF
        public static System.Boolean all(Unity.Mathematics.bool2 x) { }
        // RVA: 0x09C2E4E8  token: 0x60004F0
        public static System.Boolean all(Unity.Mathematics.bool3 x) { }
        // RVA: 0x04D2CBB0  token: 0x60004F1
        public static System.Boolean all(Unity.Mathematics.bool4 x) { }
        // RVA: 0x09C2E3C8  token: 0x60004F2
        public static System.Boolean all(Unity.Mathematics.int2 x) { }
        // RVA: 0x04D2CBD0  token: 0x60004F3
        public static System.Boolean all(Unity.Mathematics.int3 x) { }
        // RVA: 0x09C2E46C  token: 0x60004F4
        public static System.Boolean all(Unity.Mathematics.int4 x) { }
        // RVA: 0x09C2E3C8  token: 0x60004F5
        public static System.Boolean all(Unity.Mathematics.uint2 x) { }
        // RVA: 0x04D2CBD0  token: 0x60004F6
        public static System.Boolean all(Unity.Mathematics.uint3 x) { }
        // RVA: 0x09C2E46C  token: 0x60004F7
        public static System.Boolean all(Unity.Mathematics.uint4 x) { }
        // RVA: 0x09C2E488  token: 0x60004F8
        public static System.Boolean all(Unity.Mathematics.float2 x) { }
        // RVA: 0x04D2CBE8  token: 0x60004F9
        public static System.Boolean all(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C2E4B0  token: 0x60004FA
        public static System.Boolean all(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C2E4FC  token: 0x60004FB
        public static System.Boolean all(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C2E420  token: 0x60004FC
        public static System.Boolean all(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C2E3DC  token: 0x60004FD
        public static System.Boolean all(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C5352C  token: 0x60004FE
        public static System.Int32 select(System.Int32 falseValue, System.Int32 trueValue, System.Boolean test) { }
        // RVA: 0x09C53544  token: 0x60004FF
        public static Unity.Mathematics.int2 select(Unity.Mathematics.int2 falseValue, Unity.Mathematics.int2 trueValue, System.Boolean test) { }
        // RVA: 0x09C53568  token: 0x6000500
        public static Unity.Mathematics.int3 select(Unity.Mathematics.int3 falseValue, Unity.Mathematics.int3 trueValue, System.Boolean test) { }
        // RVA: 0x09C53550  token: 0x6000501
        public static Unity.Mathematics.int4 select(Unity.Mathematics.int4 falseValue, Unity.Mathematics.int4 trueValue, System.Boolean test) { }
        // RVA: 0x09C5358C  token: 0x6000502
        public static Unity.Mathematics.int2 select(Unity.Mathematics.int2 falseValue, Unity.Mathematics.int2 trueValue, Unity.Mathematics.bool2 test) { }
        // RVA: 0x04D56E84  token: 0x6000503
        public static Unity.Mathematics.int3 select(Unity.Mathematics.int3 falseValue, Unity.Mathematics.int3 trueValue, Unity.Mathematics.bool3 test) { }
        // RVA: 0x04D56FE8  token: 0x6000504
        public static Unity.Mathematics.int4 select(Unity.Mathematics.int4 falseValue, Unity.Mathematics.int4 trueValue, Unity.Mathematics.bool4 test) { }
        // RVA: 0x09C5352C  token: 0x6000505
        public static System.UInt32 select(System.UInt32 falseValue, System.UInt32 trueValue, System.Boolean test) { }
        // RVA: 0x09C53544  token: 0x6000506
        public static Unity.Mathematics.uint2 select(Unity.Mathematics.uint2 falseValue, Unity.Mathematics.uint2 trueValue, System.Boolean test) { }
        // RVA: 0x09C53568  token: 0x6000507
        public static Unity.Mathematics.uint3 select(Unity.Mathematics.uint3 falseValue, Unity.Mathematics.uint3 trueValue, System.Boolean test) { }
        // RVA: 0x09C53550  token: 0x6000508
        public static Unity.Mathematics.uint4 select(Unity.Mathematics.uint4 falseValue, Unity.Mathematics.uint4 trueValue, System.Boolean test) { }
        // RVA: 0x09C5358C  token: 0x6000509
        public static Unity.Mathematics.uint2 select(Unity.Mathematics.uint2 falseValue, Unity.Mathematics.uint2 trueValue, Unity.Mathematics.bool2 test) { }
        // RVA: 0x04D56E84  token: 0x600050A
        public static Unity.Mathematics.uint3 select(Unity.Mathematics.uint3 falseValue, Unity.Mathematics.uint3 trueValue, Unity.Mathematics.bool3 test) { }
        // RVA: 0x04D56FE8  token: 0x600050B
        public static Unity.Mathematics.uint4 select(Unity.Mathematics.uint4 falseValue, Unity.Mathematics.uint4 trueValue, Unity.Mathematics.bool4 test) { }
        // RVA: 0x09C53520  token: 0x600050C
        public static System.Int64 select(System.Int64 falseValue, System.Int64 trueValue, System.Boolean test) { }
        // RVA: 0x09C53520  token: 0x600050D
        public static System.UInt64 select(System.UInt64 falseValue, System.UInt64 trueValue, System.Boolean test) { }
        // RVA: 0x09C53538  token: 0x600050E
        public static System.Single select(System.Single falseValue, System.Single trueValue, System.Boolean test) { }
        // RVA: 0x09C53544  token: 0x600050F
        public static Unity.Mathematics.float2 select(Unity.Mathematics.float2 falseValue, Unity.Mathematics.float2 trueValue, System.Boolean test) { }
        // RVA: 0x09C53568  token: 0x6000510
        public static Unity.Mathematics.float3 select(Unity.Mathematics.float3 falseValue, Unity.Mathematics.float3 trueValue, System.Boolean test) { }
        // RVA: 0x09C53550  token: 0x6000511
        public static Unity.Mathematics.float4 select(Unity.Mathematics.float4 falseValue, Unity.Mathematics.float4 trueValue, System.Boolean test) { }
        // RVA: 0x04D56EC4  token: 0x6000512
        public static Unity.Mathematics.float2 select(Unity.Mathematics.float2 falseValue, Unity.Mathematics.float2 trueValue, Unity.Mathematics.bool2 test) { }
        // RVA: 0x04D56F08  token: 0x6000513
        public static Unity.Mathematics.float3 select(Unity.Mathematics.float3 falseValue, Unity.Mathematics.float3 trueValue, Unity.Mathematics.bool3 test) { }
        // RVA: 0x04D56F7C  token: 0x6000514
        public static Unity.Mathematics.float4 select(Unity.Mathematics.float4 falseValue, Unity.Mathematics.float4 trueValue, Unity.Mathematics.bool4 test) { }
        // RVA: 0x09C53538  token: 0x6000515
        public static System.Double select(System.Double falseValue, System.Double trueValue, System.Boolean test) { }
        // RVA: 0x09C53550  token: 0x6000516
        public static Unity.Mathematics.double2 select(Unity.Mathematics.double2 falseValue, Unity.Mathematics.double2 trueValue, System.Boolean test) { }
        // RVA: 0x09C536B0  token: 0x6000517
        public static Unity.Mathematics.double3 select(Unity.Mathematics.double3 falseValue, Unity.Mathematics.double3 trueValue, System.Boolean test) { }
        // RVA: 0x09C536D8  token: 0x6000518
        public static Unity.Mathematics.double4 select(Unity.Mathematics.double4 falseValue, Unity.Mathematics.double4 trueValue, System.Boolean test) { }
        // RVA: 0x04D56E50  token: 0x6000519
        public static Unity.Mathematics.double2 select(Unity.Mathematics.double2 falseValue, Unity.Mathematics.double2 trueValue, Unity.Mathematics.bool2 test) { }
        // RVA: 0x09C53630  token: 0x600051A
        public static Unity.Mathematics.double3 select(Unity.Mathematics.double3 falseValue, Unity.Mathematics.double3 trueValue, Unity.Mathematics.bool3 test) { }
        // RVA: 0x09C535BC  token: 0x600051B
        public static Unity.Mathematics.double4 select(Unity.Mathematics.double4 falseValue, Unity.Mathematics.double4 trueValue, Unity.Mathematics.bool4 test) { }
        // RVA: 0x09C55C54  token: 0x600051C
        public static System.Single step(System.Single threshold, System.Single x) { }
        // RVA: 0x09C55FC0  token: 0x600051D
        public static Unity.Mathematics.float2 step(Unity.Mathematics.float2 threshold, Unity.Mathematics.float2 x) { }
        // RVA: 0x09C55E70  token: 0x600051E
        public static Unity.Mathematics.float3 step(Unity.Mathematics.float3 threshold, Unity.Mathematics.float3 x) { }
        // RVA: 0x09C55C7C  token: 0x600051F
        public static Unity.Mathematics.float4 step(Unity.Mathematics.float4 threshold, Unity.Mathematics.float4 x) { }
        // RVA: 0x09C55C68  token: 0x6000520
        public static System.Double step(System.Double threshold, System.Double x) { }
        // RVA: 0x09C55DFC  token: 0x6000521
        public static Unity.Mathematics.double2 step(Unity.Mathematics.double2 threshold, Unity.Mathematics.double2 x) { }
        // RVA: 0x09C55D38  token: 0x6000522
        public static Unity.Mathematics.double3 step(Unity.Mathematics.double3 threshold, Unity.Mathematics.double3 x) { }
        // RVA: 0x09C55F1C  token: 0x6000523
        public static Unity.Mathematics.double4 step(Unity.Mathematics.double4 threshold, Unity.Mathematics.double4 x) { }
        // RVA: 0x09C5129C  token: 0x6000524
        public static Unity.Mathematics.float2 reflect(Unity.Mathematics.float2 i, Unity.Mathematics.float2 n) { }
        // RVA: 0x04D54B90  token: 0x6000525
        public static Unity.Mathematics.float3 reflect(Unity.Mathematics.float3 i, Unity.Mathematics.float3 n) { }
        // RVA: 0x09C51548  token: 0x6000526
        public static Unity.Mathematics.float4 reflect(Unity.Mathematics.float4 i, Unity.Mathematics.float4 n) { }
        // RVA: 0x09C514B0  token: 0x6000527
        public static Unity.Mathematics.double2 reflect(Unity.Mathematics.double2 i, Unity.Mathematics.double2 n) { }
        // RVA: 0x09C513CC  token: 0x6000528
        public static Unity.Mathematics.double3 reflect(Unity.Mathematics.double3 i, Unity.Mathematics.double3 n) { }
        // RVA: 0x09C512F4  token: 0x6000529
        public static Unity.Mathematics.double4 reflect(Unity.Mathematics.double4 i, Unity.Mathematics.double4 n) { }
        // RVA: 0x09C51734  token: 0x600052A
        public static Unity.Mathematics.float2 refract(Unity.Mathematics.float2 i, Unity.Mathematics.float2 n, System.Single indexOfRefraction) { }
        // RVA: 0x04D55064  token: 0x600052B
        public static Unity.Mathematics.float3 refract(Unity.Mathematics.float3 i, Unity.Mathematics.float3 n, System.Single indexOfRefraction) { }
        // RVA: 0x09C51AFC  token: 0x600052C
        public static Unity.Mathematics.float4 refract(Unity.Mathematics.float4 i, Unity.Mathematics.float4 n, System.Single indexOfRefraction) { }
        // RVA: 0x09C51838  token: 0x600052D
        public static Unity.Mathematics.double2 refract(Unity.Mathematics.double2 i, Unity.Mathematics.double2 n, System.Double indexOfRefraction) { }
        // RVA: 0x09C5194C  token: 0x600052E
        public static Unity.Mathematics.double3 refract(Unity.Mathematics.double3 i, Unity.Mathematics.double3 n, System.Double indexOfRefraction) { }
        // RVA: 0x09C515DC  token: 0x600052F
        public static Unity.Mathematics.double4 refract(Unity.Mathematics.double4 i, Unity.Mathematics.double4 n, System.Double indexOfRefraction) { }
        // RVA: 0x09C50800  token: 0x6000530
        public static Unity.Mathematics.float2 project(Unity.Mathematics.float2 a, Unity.Mathematics.float2 ontoB) { }
        // RVA: 0x04D540A4  token: 0x6000531
        public static Unity.Mathematics.float3 project(Unity.Mathematics.float3 a, Unity.Mathematics.float3 ontoB) { }
        // RVA: 0x09C50998  token: 0x6000532
        public static Unity.Mathematics.float4 project(Unity.Mathematics.float4 a, Unity.Mathematics.float4 ontoB) { }
        // RVA: 0x09C50A70  token: 0x6000533
        public static Unity.Mathematics.float2 projectsafe(Unity.Mathematics.float2 a, Unity.Mathematics.float2 ontoB, Unity.Mathematics.float2 defaultValue) { }
        // RVA: 0x04D54364  token: 0x6000534
        public static Unity.Mathematics.float3 projectsafe(Unity.Mathematics.float3 a, Unity.Mathematics.float3 ontoB, Unity.Mathematics.float3 defaultValue) { }
        // RVA: 0x09C50A08  token: 0x6000535
        public static Unity.Mathematics.float4 projectsafe(Unity.Mathematics.float4 a, Unity.Mathematics.float4 ontoB, Unity.Mathematics.float4 defaultValue) { }
        // RVA: 0x04D54030  token: 0x6000536
        public static Unity.Mathematics.double2 project(Unity.Mathematics.double2 a, Unity.Mathematics.double2 ontoB) { }
        // RVA: 0x09C508EC  token: 0x6000537
        public static Unity.Mathematics.double3 project(Unity.Mathematics.double3 a, Unity.Mathematics.double3 ontoB) { }
        // RVA: 0x09C5084C  token: 0x6000538
        public static Unity.Mathematics.double4 project(Unity.Mathematics.double4 a, Unity.Mathematics.double4 ontoB) { }
        // RVA: 0x09C50BAC  token: 0x6000539
        public static Unity.Mathematics.double2 projectsafe(Unity.Mathematics.double2 a, Unity.Mathematics.double2 ontoB, Unity.Mathematics.double2 defaultValue) { }
        // RVA: 0x09C50C10  token: 0x600053A
        public static Unity.Mathematics.double3 projectsafe(Unity.Mathematics.double3 a, Unity.Mathematics.double3 ontoB, Unity.Mathematics.double3 defaultValue) { }
        // RVA: 0x09C50B10  token: 0x600053B
        public static Unity.Mathematics.double4 projectsafe(Unity.Mathematics.double4 a, Unity.Mathematics.double4 ontoB, Unity.Mathematics.double4 defaultValue) { }
        // RVA: 0x09C32F78  token: 0x600053C
        public static Unity.Mathematics.float2 faceforward(Unity.Mathematics.float2 n, Unity.Mathematics.float2 i, Unity.Mathematics.float2 ng) { }
        // RVA: 0x04D31E3C  token: 0x600053D
        public static Unity.Mathematics.float3 faceforward(Unity.Mathematics.float3 n, Unity.Mathematics.float3 i, Unity.Mathematics.float3 ng) { }
        // RVA: 0x09C32E9C  token: 0x600053E
        public static Unity.Mathematics.float4 faceforward(Unity.Mathematics.float4 n, Unity.Mathematics.float4 i, Unity.Mathematics.float4 ng) { }
        // RVA: 0x09C32F04  token: 0x600053F
        public static Unity.Mathematics.double2 faceforward(Unity.Mathematics.double2 n, Unity.Mathematics.double2 i, Unity.Mathematics.double2 ng) { }
        // RVA: 0x09C32FD0  token: 0x6000540
        public static Unity.Mathematics.double3 faceforward(Unity.Mathematics.double3 n, Unity.Mathematics.double3 i, Unity.Mathematics.double3 ng) { }
        // RVA: 0x09C33094  token: 0x6000541
        public static Unity.Mathematics.double4 faceforward(Unity.Mathematics.double4 n, Unity.Mathematics.double4 i, Unity.Mathematics.double4 ng) { }
        // RVA: 0x03D7CE60  token: 0x6000542
        public static System.Void sincos(System.Single x, System.Single& s, System.Single& c) { }
        // RVA: 0x09C550B0  token: 0x6000543
        public static System.Void sincos(Unity.Mathematics.float2 x, Unity.Mathematics.float2& s, Unity.Mathematics.float2& c) { }
        // RVA: 0x09C54ED0  token: 0x6000544
        public static System.Void sincos(Unity.Mathematics.float3 x, Unity.Mathematics.float3& s, Unity.Mathematics.float3& c) { }
        // RVA: 0x09C54F54  token: 0x6000545
        public static System.Void sincos(Unity.Mathematics.float4 x, Unity.Mathematics.float4& s, Unity.Mathematics.float4& c) { }
        // RVA: 0x03D7CE20  token: 0x6000546
        public static System.Void sincos(System.Double x, System.Double& s, System.Double& c) { }
        // RVA: 0x09C54FBC  token: 0x6000547
        public static System.Void sincos(Unity.Mathematics.double2 x, Unity.Mathematics.double2& s, Unity.Mathematics.double2& c) { }
        // RVA: 0x09C55024  token: 0x6000548
        public static System.Void sincos(Unity.Mathematics.double3 x, Unity.Mathematics.double3& s, Unity.Mathematics.double3& c) { }
        // RVA: 0x09C54E4C  token: 0x6000549
        public static System.Void sincos(Unity.Mathematics.double4 x, Unity.Mathematics.double4& s, Unity.Mathematics.double4& c) { }
        // RVA: 0x03D791F0  token: 0x600054A
        public static System.Int32 countbits(System.Int32 x) { }
        // RVA: 0x09C2FEC4  token: 0x600054B
        public static Unity.Mathematics.int2 countbits(Unity.Mathematics.int2 x) { }
        // RVA: 0x09C301C8  token: 0x600054C
        public static Unity.Mathematics.int3 countbits(Unity.Mathematics.int3 x) { }
        // RVA: 0x09C30168  token: 0x600054D
        public static Unity.Mathematics.int4 countbits(Unity.Mathematics.int4 x) { }
        // RVA: 0x03D791F0  token: 0x600054E
        public static System.Int32 countbits(System.UInt32 x) { }
        // RVA: 0x09C2FEDC  token: 0x600054F
        public static Unity.Mathematics.int2 countbits(Unity.Mathematics.uint2 x) { }
        // RVA: 0x04D2EC34  token: 0x6000550
        public static Unity.Mathematics.int3 countbits(Unity.Mathematics.uint3 x) { }
        // RVA: 0x09C2FFD8  token: 0x6000551
        public static Unity.Mathematics.int4 countbits(Unity.Mathematics.uint4 x) { }
        // RVA: 0x03D79190  token: 0x6000552
        public static System.Int32 countbits(System.UInt64 x) { }
        // RVA: 0x03D79190  token: 0x6000553
        public static System.Int32 countbits(System.Int64 x) { }
        // RVA: 0x09C40544  token: 0x6000554
        public static System.Int32 lzcnt(System.Int32 x) { }
        // RVA: 0x09C40510  token: 0x6000555
        public static Unity.Mathematics.int2 lzcnt(Unity.Mathematics.int2 x) { }
        // RVA: 0x09C40440  token: 0x6000556
        public static Unity.Mathematics.int3 lzcnt(Unity.Mathematics.int3 x) { }
        // RVA: 0x09C404C4  token: 0x6000557
        public static Unity.Mathematics.int4 lzcnt(Unity.Mathematics.int4 x) { }
        // RVA: 0x09C40480  token: 0x6000558
        public static System.Int32 lzcnt(System.UInt32 x) { }
        // RVA: 0x09C40510  token: 0x6000559
        public static Unity.Mathematics.int2 lzcnt(Unity.Mathematics.uint2 x) { }
        // RVA: 0x09C40440  token: 0x600055A
        public static Unity.Mathematics.int3 lzcnt(Unity.Mathematics.uint3 x) { }
        // RVA: 0x09C404C4  token: 0x600055B
        public static Unity.Mathematics.int4 lzcnt(Unity.Mathematics.uint4 x) { }
        // RVA: 0x09C4053C  token: 0x600055C
        public static System.Int32 lzcnt(System.Int64 x) { }
        // RVA: 0x09C4054C  token: 0x600055D
        public static System.Int32 lzcnt(System.UInt64 x) { }
        // RVA: 0x09C579A4  token: 0x600055E
        public static System.Int32 tzcnt(System.Int32 x) { }
        // RVA: 0x09C57924  token: 0x600055F
        public static Unity.Mathematics.int2 tzcnt(Unity.Mathematics.int2 x) { }
        // RVA: 0x09C578E0  token: 0x6000560
        public static Unity.Mathematics.int3 tzcnt(Unity.Mathematics.int3 x) { }
        // RVA: 0x09C57950  token: 0x6000561
        public static Unity.Mathematics.int4 tzcnt(Unity.Mathematics.int4 x) { }
        // RVA: 0x09C57898  token: 0x6000562
        public static System.Int32 tzcnt(System.UInt32 x) { }
        // RVA: 0x09C57924  token: 0x6000563
        public static Unity.Mathematics.int2 tzcnt(Unity.Mathematics.uint2 x) { }
        // RVA: 0x09C578E0  token: 0x6000564
        public static Unity.Mathematics.int3 tzcnt(Unity.Mathematics.uint3 x) { }
        // RVA: 0x09C57950  token: 0x6000565
        public static Unity.Mathematics.int4 tzcnt(Unity.Mathematics.uint4 x) { }
        // RVA: 0x09C579AC  token: 0x6000566
        public static System.Int32 tzcnt(System.Int64 x) { }
        // RVA: 0x09C579B4  token: 0x6000567
        public static System.Int32 tzcnt(System.UInt64 x) { }
        // RVA: 0x09C52498  token: 0x6000568
        public static System.Int32 reversebits(System.Int32 x) { }
        // RVA: 0x09C524A0  token: 0x6000569
        public static Unity.Mathematics.int2 reversebits(Unity.Mathematics.int2 x) { }
        // RVA: 0x09C524D0  token: 0x600056A
        public static Unity.Mathematics.int3 reversebits(Unity.Mathematics.int3 x) { }
        // RVA: 0x09C52270  token: 0x600056B
        public static Unity.Mathematics.int4 reversebits(Unity.Mathematics.int4 x) { }
        // RVA: 0x03D7CB90  token: 0x600056C
        public static System.UInt32 reversebits(System.UInt32 x) { }
        // RVA: 0x09C522E4  token: 0x600056D
        public static Unity.Mathematics.uint2 reversebits(Unity.Mathematics.uint2 x) { }
        // RVA: 0x04D55AD0  token: 0x600056E
        public static Unity.Mathematics.uint3 reversebits(Unity.Mathematics.uint3 x) { }
        // RVA: 0x09C51FB8  token: 0x600056F
        public static Unity.Mathematics.uint4 reversebits(Unity.Mathematics.uint4 x) { }
        // RVA: 0x09C52490  token: 0x6000570
        public static System.Int64 reversebits(System.Int64 x) { }
        // RVA: 0x03D7CBD0  token: 0x6000571
        public static System.UInt64 reversebits(System.UInt64 x) { }
        // RVA: 0x03D50D20  token: 0x6000572
        public static System.Int32 rol(System.Int32 x, System.Int32 n) { }
        // RVA: 0x09C526F0  token: 0x6000573
        public static Unity.Mathematics.int2 rol(Unity.Mathematics.int2 x, System.Int32 n) { }
        // RVA: 0x09C52584  token: 0x6000574
        public static Unity.Mathematics.int3 rol(Unity.Mathematics.int3 x, System.Int32 n) { }
        // RVA: 0x09C52604  token: 0x6000575
        public static Unity.Mathematics.int4 rol(Unity.Mathematics.int4 x, System.Int32 n) { }
        // RVA: 0x03D50D20  token: 0x6000576
        public static System.UInt32 rol(System.UInt32 x, System.Int32 n) { }
        // RVA: 0x09C52550  token: 0x6000577
        public static Unity.Mathematics.uint2 rol(Unity.Mathematics.uint2 x, System.Int32 n) { }
        // RVA: 0x04D5607C  token: 0x6000578
        public static Unity.Mathematics.uint3 rol(Unity.Mathematics.uint3 x, System.Int32 n) { }
        // RVA: 0x09C52678  token: 0x6000579
        public static Unity.Mathematics.uint4 rol(Unity.Mathematics.uint4 x, System.Int32 n) { }
        // RVA: 0x03D76910  token: 0x600057A
        public static System.Int64 rol(System.Int64 x, System.Int32 n) { }
        // RVA: 0x03D76910  token: 0x600057B
        public static System.UInt64 rol(System.UInt64 x, System.Int32 n) { }
        // RVA: 0x03D6ED80  token: 0x600057C
        public static System.Int32 ror(System.Int32 x, System.Int32 n) { }
        // RVA: 0x09C52808  token: 0x600057D
        public static Unity.Mathematics.int2 ror(Unity.Mathematics.int2 x, System.Int32 n) { }
        // RVA: 0x09C52878  token: 0x600057E
        public static Unity.Mathematics.int3 ror(Unity.Mathematics.int3 x, System.Int32 n) { }
        // RVA: 0x09C52794  token: 0x600057F
        public static Unity.Mathematics.int4 ror(Unity.Mathematics.int4 x, System.Int32 n) { }
        // RVA: 0x03D6ED80  token: 0x6000580
        public static System.UInt32 ror(System.UInt32 x, System.Int32 n) { }
        // RVA: 0x09C52760  token: 0x6000581
        public static Unity.Mathematics.uint2 ror(Unity.Mathematics.uint2 x, System.Int32 n) { }
        // RVA: 0x04D56110  token: 0x6000582
        public static Unity.Mathematics.uint3 ror(Unity.Mathematics.uint3 x, System.Int32 n) { }
        // RVA: 0x09C528F8  token: 0x6000583
        public static Unity.Mathematics.uint4 ror(Unity.Mathematics.uint4 x, System.Int32 n) { }
        // RVA: 0x03D6EDD0  token: 0x6000584
        public static System.Int64 ror(System.Int64 x, System.Int32 n) { }
        // RVA: 0x03D6EDD0  token: 0x6000585
        public static System.UInt64 ror(System.UInt64 x, System.Int32 n) { }
        // RVA: 0x029CE000  token: 0x6000586
        public static System.Int32 ceilpow2(System.Int32 x) { }
        // RVA: 0x09C2EF6C  token: 0x6000587
        public static Unity.Mathematics.int2 ceilpow2(Unity.Mathematics.int2 x) { }
        // RVA: 0x04D2DC58  token: 0x6000588
        public static Unity.Mathematics.int3 ceilpow2(Unity.Mathematics.int3 x) { }
        // RVA: 0x09C2F26C  token: 0x6000589
        public static Unity.Mathematics.int4 ceilpow2(Unity.Mathematics.int4 x) { }
        // RVA: 0x03D520C0  token: 0x600058A
        public static System.UInt32 ceilpow2(System.UInt32 x) { }
        // RVA: 0x09C2F1B4  token: 0x600058B
        public static Unity.Mathematics.uint2 ceilpow2(Unity.Mathematics.uint2 x) { }
        // RVA: 0x04D2DA44  token: 0x600058C
        public static Unity.Mathematics.uint3 ceilpow2(Unity.Mathematics.uint3 x) { }
        // RVA: 0x09C2F024  token: 0x600058D
        public static Unity.Mathematics.uint4 ceilpow2(Unity.Mathematics.uint4 x) { }
        // RVA: 0x03D78D60  token: 0x600058E
        public static System.Int64 ceilpow2(System.Int64 x) { }
        // RVA: 0x03D78D10  token: 0x600058F
        public static System.UInt64 ceilpow2(System.UInt64 x) { }
        // RVA: 0x04D2DA28  token: 0x6000590
        public static System.Int32 ceillog2(System.Int32 x) { }
        // RVA: 0x09C2EF40  token: 0x6000591
        public static Unity.Mathematics.int2 ceillog2(Unity.Mathematics.int2 x) { }
        // RVA: 0x09C2EEC0  token: 0x6000592
        public static Unity.Mathematics.int3 ceillog2(Unity.Mathematics.int3 x) { }
        // RVA: 0x09C2EEF8  token: 0x6000593
        public static Unity.Mathematics.int4 ceillog2(Unity.Mathematics.int4 x) { }
        // RVA: 0x04D2DA28  token: 0x6000594
        public static System.Int32 ceillog2(System.UInt32 x) { }
        // RVA: 0x09C2EF40  token: 0x6000595
        public static Unity.Mathematics.int2 ceillog2(Unity.Mathematics.uint2 x) { }
        // RVA: 0x09C2EEC0  token: 0x6000596
        public static Unity.Mathematics.int3 ceillog2(Unity.Mathematics.uint3 x) { }
        // RVA: 0x09C2EEF8  token: 0x6000597
        public static Unity.Mathematics.int4 ceillog2(Unity.Mathematics.uint4 x) { }
        // RVA: 0x04D32A74  token: 0x6000598
        public static System.Int32 floorlog2(System.Int32 x) { }
        // RVA: 0x09C354C8  token: 0x6000599
        public static Unity.Mathematics.int2 floorlog2(Unity.Mathematics.int2 x) { }
        // RVA: 0x09C35490  token: 0x600059A
        public static Unity.Mathematics.int3 floorlog2(Unity.Mathematics.int3 x) { }
        // RVA: 0x09C35448  token: 0x600059B
        public static Unity.Mathematics.int4 floorlog2(Unity.Mathematics.int4 x) { }
        // RVA: 0x04D32A74  token: 0x600059C
        public static System.Int32 floorlog2(System.UInt32 x) { }
        // RVA: 0x09C354C8  token: 0x600059D
        public static Unity.Mathematics.int2 floorlog2(Unity.Mathematics.uint2 x) { }
        // RVA: 0x09C35490  token: 0x600059E
        public static Unity.Mathematics.int3 floorlog2(Unity.Mathematics.uint3 x) { }
        // RVA: 0x09C35448  token: 0x600059F
        public static Unity.Mathematics.int4 floorlog2(Unity.Mathematics.uint4 x) { }
        // RVA: 0x03D7CB70  token: 0x60005A0
        public static System.Single radians(System.Single x) { }
        // RVA: 0x09C51024  token: 0x60005A1
        public static Unity.Mathematics.float2 radians(Unity.Mathematics.float2 x) { }
        // RVA: 0x0427033C  token: 0x60005A2
        public static Unity.Mathematics.float3 radians(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C50FEC  token: 0x60005A3
        public static Unity.Mathematics.float4 radians(Unity.Mathematics.float4 x) { }
        // RVA: 0x03D7CB80  token: 0x60005A4
        public static System.Double radians(System.Double x) { }
        // RVA: 0x09C51034  token: 0x60005A5
        public static Unity.Mathematics.double2 radians(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C5106C  token: 0x60005A6
        public static Unity.Mathematics.double3 radians(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C510B8  token: 0x60005A7
        public static Unity.Mathematics.double4 radians(Unity.Mathematics.double4 x) { }
        // RVA: 0x03D792E0  token: 0x60005A8
        public static System.Single degrees(System.Single x) { }
        // RVA: 0x09C305CC  token: 0x60005A9
        public static Unity.Mathematics.float2 degrees(Unity.Mathematics.float2 x) { }
        // RVA: 0x04D2F384  token: 0x60005AA
        public static Unity.Mathematics.float3 degrees(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C305DC  token: 0x60005AB
        public static Unity.Mathematics.float4 degrees(Unity.Mathematics.float4 x) { }
        // RVA: 0x03D792F0  token: 0x60005AC
        public static System.Double degrees(System.Double x) { }
        // RVA: 0x09C30614  token: 0x60005AD
        public static Unity.Mathematics.double2 degrees(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C30538  token: 0x60005AE
        public static Unity.Mathematics.double3 degrees(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C30584  token: 0x60005AF
        public static Unity.Mathematics.double4 degrees(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C2FCB8  token: 0x60005B0
        public static System.Int32 cmin(Unity.Mathematics.int2 x) { }
        // RVA: 0x09C2FB90  token: 0x60005B1
        public static System.Int32 cmin(Unity.Mathematics.int3 x) { }
        // RVA: 0x09C2FC10  token: 0x60005B2
        public static System.Int32 cmin(Unity.Mathematics.int4 x) { }
        // RVA: 0x09C2FC4C  token: 0x60005B3
        public static System.UInt32 cmin(Unity.Mathematics.uint2 x) { }
        // RVA: 0x09C2FD04  token: 0x60005B4
        public static System.UInt32 cmin(Unity.Mathematics.uint3 x) { }
        // RVA: 0x09C2FBA4  token: 0x60005B5
        public static System.UInt32 cmin(Unity.Mathematics.uint4 x) { }
        // RVA: 0x09C2FC94  token: 0x60005B6
        public static System.Single cmin(Unity.Mathematics.float2 x) { }
        // RVA: 0x09C2FC60  token: 0x60005B7
        public static System.Single cmin(Unity.Mathematics.float3 x) { }
        // RVA: 0x04D2E958  token: 0x60005B8
        public static System.Single cmin(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C2FC2C  token: 0x60005B9
        public static System.Double cmin(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C2FCCC  token: 0x60005BA
        public static System.Double cmin(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C2FBC0  token: 0x60005BB
        public static System.Double cmin(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C2FB10  token: 0x60005BC
        public static System.Int32 cmax(Unity.Mathematics.int2 x) { }
        // RVA: 0x09C2FB44  token: 0x60005BD
        public static System.Int32 cmax(Unity.Mathematics.int3 x) { }
        // RVA: 0x09C2FA74  token: 0x60005BE
        public static System.Int32 cmax(Unity.Mathematics.int4 x) { }
        // RVA: 0x09C2FA3C  token: 0x60005BF
        public static System.UInt32 cmax(Unity.Mathematics.uint2 x) { }
        // RVA: 0x09C2FAFC  token: 0x60005C0
        public static System.UInt32 cmax(Unity.Mathematics.uint3 x) { }
        // RVA: 0x09C2FA90  token: 0x60005C1
        public static System.UInt32 cmax(Unity.Mathematics.uint4 x) { }
        // RVA: 0x09C2FA50  token: 0x60005C2
        public static System.Single cmax(Unity.Mathematics.float2 x) { }
        // RVA: 0x09C2FA08  token: 0x60005C3
        public static System.Single cmax(Unity.Mathematics.float3 x) { }
        // RVA: 0x04D2E7E8  token: 0x60005C4
        public static System.Single cmax(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C2FB24  token: 0x60005C5
        public static System.Double cmax(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C2FB58  token: 0x60005C6
        public static System.Double cmax(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C2FAAC  token: 0x60005C7
        public static System.Double cmax(Unity.Mathematics.double4 x) { }
        // RVA: 0x03D79250  token: 0x60005C8
        public static System.Int32 csum(Unity.Mathematics.int2 x) { }
        // RVA: 0x03D792A0  token: 0x60005C9
        public static System.Int32 csum(Unity.Mathematics.int3 x) { }
        // RVA: 0x03D55680  token: 0x60005CA
        public static System.Int32 csum(Unity.Mathematics.int4 x) { }
        // RVA: 0x03D79250  token: 0x60005CB
        public static System.UInt32 csum(Unity.Mathematics.uint2 x) { }
        // RVA: 0x03D792A0  token: 0x60005CC
        public static System.UInt32 csum(Unity.Mathematics.uint3 x) { }
        // RVA: 0x03D55680  token: 0x60005CD
        public static System.UInt32 csum(Unity.Mathematics.uint4 x) { }
        // RVA: 0x03D792B0  token: 0x60005CE
        public static System.Single csum(Unity.Mathematics.float2 x) { }
        // RVA: 0x03D792D0  token: 0x60005CF
        public static System.Single csum(Unity.Mathematics.float3 x) { }
        // RVA: 0x03D79230  token: 0x60005D0
        public static System.Single csum(Unity.Mathematics.float4 x) { }
        // RVA: 0x03D79270  token: 0x60005D1
        public static System.Double csum(Unity.Mathematics.double2 x) { }
        // RVA: 0x03D79260  token: 0x60005D2
        public static System.Double csum(Unity.Mathematics.double3 x) { }
        // RVA: 0x03D79280  token: 0x60005D3
        public static System.Double csum(Unity.Mathematics.double4 x) { }
        // RVA: 0x03D51490  token: 0x60005D4
        public static System.Single square(System.Single x) { }
        // RVA: 0x09C55C4C  token: 0x60005D5
        public static Unity.Mathematics.float2 square(Unity.Mathematics.float2 x) { }
        // RVA: 0x04D5AFFC  token: 0x60005D6
        public static Unity.Mathematics.float3 square(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C55B7C  token: 0x60005D7
        public static Unity.Mathematics.float4 square(Unity.Mathematics.float4 x) { }
        // RVA: 0x03D7B840  token: 0x60005D8
        public static System.Double square(System.Double x) { }
        // RVA: 0x09C55B44  token: 0x60005D9
        public static Unity.Mathematics.double2 square(Unity.Mathematics.double2 x) { }
        // RVA: 0x09C55BBC  token: 0x60005DA
        public static Unity.Mathematics.double3 square(Unity.Mathematics.double3 x) { }
        // RVA: 0x09C55AF4  token: 0x60005DB
        public static Unity.Mathematics.double4 square(Unity.Mathematics.double4 x) { }
        // RVA: 0x03D7D410  token: 0x60005DC
        public static System.Int32 square(System.Int32 x) { }
        // RVA: 0x09C55BB4  token: 0x60005DD
        public static Unity.Mathematics.int2 square(Unity.Mathematics.int2 x) { }
        // RVA: 0x04D5B04C  token: 0x60005DE
        public static Unity.Mathematics.int3 square(Unity.Mathematics.int3 x) { }
        // RVA: 0x09C55C14  token: 0x60005DF
        public static Unity.Mathematics.int4 square(Unity.Mathematics.int4 x) { }
        // RVA: 0x03D7D410  token: 0x60005E0
        public static System.UInt32 square(System.UInt32 x) { }
        // RVA: 0x09C55BB4  token: 0x60005E1
        public static Unity.Mathematics.uint2 square(Unity.Mathematics.uint2 x) { }
        // RVA: 0x04D5B04C  token: 0x60005E2
        public static Unity.Mathematics.uint3 square(Unity.Mathematics.uint3 x) { }
        // RVA: 0x09C55C14  token: 0x60005E3
        public static Unity.Mathematics.uint4 square(Unity.Mathematics.uint4 x) { }
        // RVA: 0x09C2C4B4  token: 0x60005E4
        public static System.Int32 compress(System.Int32* output, System.Int32 index, Unity.Mathematics.int4 val, Unity.Mathematics.bool4 mask) { }
        // RVA: 0x09C2FD18  token: 0x60005E5
        public static System.Int32 compress(System.UInt32* output, System.Int32 index, Unity.Mathematics.uint4 val, Unity.Mathematics.bool4 mask) { }
        // RVA: 0x09C2FD18  token: 0x60005E6
        public static System.Int32 compress(System.Single* output, System.Int32 index, Unity.Mathematics.float4 val, Unity.Mathematics.bool4 mask) { }
        // RVA: 0x04D30EF4  token: 0x60005E7
        public static System.Single f16tof32(System.UInt32 x) { }
        // RVA: 0x09C323D0  token: 0x60005E8
        public static Unity.Mathematics.float2 f16tof32(Unity.Mathematics.uint2 x) { }
        // RVA: 0x09C3210C  token: 0x60005E9
        public static Unity.Mathematics.float3 f16tof32(Unity.Mathematics.uint3 x) { }
        // RVA: 0x09C32524  token: 0x60005EA
        public static Unity.Mathematics.float4 f16tof32(Unity.Mathematics.uint4 x) { }
        // RVA: 0x09C32BD4  token: 0x60005EB
        public static System.UInt32 f32tof16(System.Single x) { }
        // RVA: 0x09C32750  token: 0x60005EC
        public static Unity.Mathematics.uint2 f32tof16(Unity.Mathematics.float2 x) { }
        // RVA: 0x09C328DC  token: 0x60005ED
        public static Unity.Mathematics.uint3 f32tof16(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C32C30  token: 0x60005EE
        public static Unity.Mathematics.uint4 f32tof16(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C501FC  token: 0x60005EF
        public static System.Void orthonormal_basis(Unity.Mathematics.float3 normal, Unity.Mathematics.float3& basis1, Unity.Mathematics.float3& basis2) { }
        // RVA: 0x09C502A0  token: 0x60005F0
        public static System.Void orthonormal_basis(Unity.Mathematics.double3 normal, Unity.Mathematics.double3& basis1, Unity.Mathematics.double3& basis2) { }
        // RVA: 0x03D78DB0  token: 0x60005F1
        public static System.Single chgsign(System.Single x, System.Single y) { }
        // RVA: 0x09C2F3FC  token: 0x60005F2
        public static Unity.Mathematics.float2 chgsign(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y) { }
        // RVA: 0x04D2E18C  token: 0x60005F3
        public static Unity.Mathematics.float3 chgsign(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y) { }
        // RVA: 0x09C2F440  token: 0x60005F4
        public static Unity.Mathematics.float4 chgsign(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y) { }
        // RVA: 0x03D6EF00  token: 0x60005F5
        private static System.UInt32 read32_little_endian(System.Void* pBuffer) { }
        // RVA: 0x09C389B8  token: 0x60005F6
        private static System.UInt32 hash_with_unaligned_loads(System.Void* pBuffer, System.Int32 numBytes, System.UInt32 seed) { }
        // RVA: 0x09C38BD4  token: 0x60005F7
        private static System.UInt32 hash_without_unaligned_loads(System.Void* pBuffer, System.Int32 numBytes, System.UInt32 seed) { }
        // RVA: 0x09C37850  token: 0x60005F8
        public static System.UInt32 hash(System.Void* pBuffer, System.Int32 numBytes, System.UInt32 seed) { }
        // RVA: 0x03D7D420  token: 0x60005F9
        public static Unity.Mathematics.float3 up() { }
        // RVA: 0x03D7A500  token: 0x60005FA
        public static Unity.Mathematics.float3 down() { }
        // RVA: 0x03D7B280  token: 0x60005FB
        public static Unity.Mathematics.float3 forward() { }
        // RVA: 0x03D787B0  token: 0x60005FC
        public static Unity.Mathematics.float3 back() { }
        // RVA: 0x03D7B7D0  token: 0x60005FD
        public static Unity.Mathematics.float3 left() { }
        // RVA: 0x03D7CC30  token: 0x60005FE
        public static Unity.Mathematics.float3 right() { }
        // RVA: 0x09C2C920  token: 0x60005FF
        public static Unity.Mathematics.float3 EulerXYZ(Unity.Mathematics.quaternion q) { }
        // RVA: 0x09C2CCA4  token: 0x6000600
        public static Unity.Mathematics.float3 EulerXZY(Unity.Mathematics.quaternion q) { }
        // RVA: 0x09C2CFFC  token: 0x6000601
        public static Unity.Mathematics.float3 EulerYXZ(Unity.Mathematics.quaternion q) { }
        // RVA: 0x09C2D350  token: 0x6000602
        public static Unity.Mathematics.float3 EulerYZX(Unity.Mathematics.quaternion q) { }
        // RVA: 0x09C2D68C  token: 0x6000603
        public static Unity.Mathematics.float3 EulerZXY(Unity.Mathematics.quaternion q) { }
        // RVA: 0x09C2D9C4  token: 0x6000604
        public static Unity.Mathematics.float3 EulerZYX(Unity.Mathematics.quaternion q) { }
        // RVA: 0x09C2DD1C  token: 0x6000605
        public static Unity.Mathematics.float3 Euler(Unity.Mathematics.quaternion q, Unity.Mathematics.math.RotationOrder order) { }
        // RVA: 0x09C41318  token: 0x6000606
        public static Unity.Mathematics.float3x3 mulScale(Unity.Mathematics.float3x3 m, Unity.Mathematics.float3 s) { }
        // RVA: 0x09C53428  token: 0x6000607
        public static Unity.Mathematics.float3x3 scaleMul(Unity.Mathematics.float3 s, Unity.Mathematics.float3x3 m) { }
        // RVA: 0x09C58884  token: 0x6000608
        private static Unity.Mathematics.float4 unpacklo(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b) { }
        // RVA: 0x09C588D0  token: 0x6000609
        private static Unity.Mathematics.double4 unpacklo(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b) { }
        // RVA: 0x09C2C654  token: 0x600060A
        private static Unity.Mathematics.float4 unpackhi(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b) { }
        // RVA: 0x09C58818  token: 0x600060B
        private static Unity.Mathematics.double4 unpackhi(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b) { }
        // RVA: 0x09C41260  token: 0x600060C
        private static Unity.Mathematics.float4 movelh(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b) { }
        // RVA: 0x09C412AC  token: 0x600060D
        private static Unity.Mathematics.double4 movelh(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b) { }
        // RVA: 0x09C411A8  token: 0x600060E
        private static Unity.Mathematics.float4 movehl(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b) { }
        // RVA: 0x09C411F4  token: 0x600060F
        private static Unity.Mathematics.double4 movehl(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b) { }
        // RVA: 0x03D7B260  token: 0x6000610
        private static System.UInt32 fold_to_uint(System.Double x) { }
        // RVA: 0x03D7B120  token: 0x6000611
        private static Unity.Mathematics.uint2 fold_to_uint(Unity.Mathematics.double2 x) { }
        // RVA: 0x03D7B1F0  token: 0x6000612
        private static Unity.Mathematics.uint3 fold_to_uint(Unity.Mathematics.double3 x) { }
        // RVA: 0x03D7B160  token: 0x6000613
        private static Unity.Mathematics.uint4 fold_to_uint(Unity.Mathematics.double4 x) { }
        // RVA: 0x09C345B8  token: 0x6000614
        public static Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.float4x4 f4x4) { }
        // RVA: 0x09C3462C  token: 0x6000615
        public static Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.quaternion rotation) { }
        // RVA: 0x09C35244  token: 0x6000616
        public static Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.float3x3 rotation, Unity.Mathematics.float3 translation) { }
        // RVA: 0x09C35300  token: 0x6000617
        public static Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 translation) { }
        // RVA: 0x09C3500C  token: 0x6000618
        public static Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.RigidTransform transform) { }
        // RVA: 0x09C50374  token: 0x6000619
        public static Unity.Mathematics.float3x3 orthonormalize(Unity.Mathematics.float3x3 i) { }
        // RVA: 0x09C50CF4  token: 0x600061A
        public static Unity.Mathematics.float3x3 pseudoinverse(Unity.Mathematics.float3x3 m) { }
        // RVA: 0x03D79D70  token: 0x600061B
        public static System.Single mul(System.Single a, System.Single b) { }
        // RVA: 0x03D542E0  token: 0x600061C
        public static System.Single mul(Unity.Mathematics.float2 a, Unity.Mathematics.float2 b) { }
        // RVA: 0x03D7C0C0  token: 0x600061D
        public static Unity.Mathematics.float2 mul(Unity.Mathematics.float2 a, Unity.Mathematics.float2x2 b) { }
        // RVA: 0x03D7C7C0  token: 0x600061E
        public static Unity.Mathematics.float3 mul(Unity.Mathematics.float2 a, Unity.Mathematics.float2x3 b) { }
        // RVA: 0x03D7C860  token: 0x600061F
        public static Unity.Mathematics.float4 mul(Unity.Mathematics.float2 a, Unity.Mathematics.float2x4 b) { }
        // RVA: 0x03D54460  token: 0x6000620
        public static System.Single mul(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b) { }
        // RVA: 0x03D7C250  token: 0x6000621
        public static Unity.Mathematics.float2 mul(Unity.Mathematics.float3 a, Unity.Mathematics.float3x2 b) { }
        // RVA: 0x03D7C1C0  token: 0x6000622
        public static Unity.Mathematics.float3 mul(Unity.Mathematics.float3 a, Unity.Mathematics.float3x3 b) { }
        // RVA: 0x03D7C5F0  token: 0x6000623
        public static Unity.Mathematics.float4 mul(Unity.Mathematics.float3 a, Unity.Mathematics.float3x4 b) { }
        // RVA: 0x028B5400  token: 0x6000624
        public static System.Single mul(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b) { }
        // RVA: 0x03D7C750  token: 0x6000625
        public static Unity.Mathematics.float2 mul(Unity.Mathematics.float4 a, Unity.Mathematics.float4x2 b) { }
        // RVA: 0x03D7BD20  token: 0x6000626
        public static Unity.Mathematics.float3 mul(Unity.Mathematics.float4 a, Unity.Mathematics.float4x3 b) { }
        // RVA: 0x03D7C970  token: 0x6000627
        public static Unity.Mathematics.float4 mul(Unity.Mathematics.float4 a, Unity.Mathematics.float4x4 b) { }
        // RVA: 0x09C429C4  token: 0x6000628
        public static Unity.Mathematics.float2 mul(Unity.Mathematics.float2x2 a, Unity.Mathematics.float2 b) { }
        // RVA: 0x09C4BECC  token: 0x6000629
        public static Unity.Mathematics.float2x2 mul(Unity.Mathematics.float2x2 a, Unity.Mathematics.float2x2 b) { }
        // RVA: 0x09C4CCD8  token: 0x600062A
        public static Unity.Mathematics.float2x3 mul(Unity.Mathematics.float2x2 a, Unity.Mathematics.float2x3 b) { }
        // RVA: 0x09C413E0  token: 0x600062B
        public static Unity.Mathematics.float2x4 mul(Unity.Mathematics.float2x2 a, Unity.Mathematics.float2x4 b) { }
        // RVA: 0x09C43580  token: 0x600062C
        public static Unity.Mathematics.float2 mul(Unity.Mathematics.float2x3 a, Unity.Mathematics.float3 b) { }
        // RVA: 0x09C43C1C  token: 0x600062D
        public static Unity.Mathematics.float2x2 mul(Unity.Mathematics.float2x3 a, Unity.Mathematics.float3x2 b) { }
        // RVA: 0x09C4A1BC  token: 0x600062E
        public static Unity.Mathematics.float2x3 mul(Unity.Mathematics.float2x3 a, Unity.Mathematics.float3x3 b) { }
        // RVA: 0x09C425A4  token: 0x600062F
        public static Unity.Mathematics.float2x4 mul(Unity.Mathematics.float2x3 a, Unity.Mathematics.float3x4 b) { }
        // RVA: 0x09C4B704  token: 0x6000630
        public static Unity.Mathematics.float2 mul(Unity.Mathematics.float2x4 a, Unity.Mathematics.float4 b) { }
        // RVA: 0x09C41564  token: 0x6000631
        public static Unity.Mathematics.float2x2 mul(Unity.Mathematics.float2x4 a, Unity.Mathematics.float4x2 b) { }
        // RVA: 0x09C49E88  token: 0x6000632
        public static Unity.Mathematics.float2x3 mul(Unity.Mathematics.float2x4 a, Unity.Mathematics.float4x3 b) { }
        // RVA: 0x09C4A6BC  token: 0x6000633
        public static Unity.Mathematics.float2x4 mul(Unity.Mathematics.float2x4 a, Unity.Mathematics.float4x4 b) { }
        // RVA: 0x09C44EA4  token: 0x6000634
        public static Unity.Mathematics.float3 mul(Unity.Mathematics.float3x2 a, Unity.Mathematics.float2 b) { }
        // RVA: 0x09C4BB2C  token: 0x6000635
        public static Unity.Mathematics.float3x2 mul(Unity.Mathematics.float3x2 a, Unity.Mathematics.float2x2 b) { }
        // RVA: 0x09C4EE48  token: 0x6000636
        public static Unity.Mathematics.float3x3 mul(Unity.Mathematics.float3x2 a, Unity.Mathematics.float2x3 b) { }
        // RVA: 0x09C416FC  token: 0x6000637
        public static Unity.Mathematics.float3x4 mul(Unity.Mathematics.float3x2 a, Unity.Mathematics.float2x4 b) { }
        // RVA: 0x09C4595C  token: 0x6000638
        public static Unity.Mathematics.float3 mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.float3 b) { }
        // RVA: 0x09C4D7FC  token: 0x6000639
        public static Unity.Mathematics.float3x2 mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.float3x2 b) { }
        // RVA: 0x09C41D38  token: 0x600063A
        public static Unity.Mathematics.float3x3 mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.float3x3 b) { }
        // RVA: 0x09C4870C  token: 0x600063B
        public static Unity.Mathematics.float3x4 mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.float3x4 b) { }
        // RVA: 0x09C47EBC  token: 0x600063C
        public static Unity.Mathematics.float3 mul(Unity.Mathematics.float3x4 a, Unity.Mathematics.float4 b) { }
        // RVA: 0x09C4EA2C  token: 0x600063D
        public static Unity.Mathematics.float3x2 mul(Unity.Mathematics.float3x4 a, Unity.Mathematics.float4x2 b) { }
        // RVA: 0x09C47800  token: 0x600063E
        public static Unity.Mathematics.float3x3 mul(Unity.Mathematics.float3x4 a, Unity.Mathematics.float4x3 b) { }
        // RVA: 0x09C42C28  token: 0x600063F
        public static Unity.Mathematics.float3x4 mul(Unity.Mathematics.float3x4 a, Unity.Mathematics.float4x4 b) { }
        // RVA: 0x09C494D0  token: 0x6000640
        public static Unity.Mathematics.float4 mul(Unity.Mathematics.float4x2 a, Unity.Mathematics.float2 b) { }
        // RVA: 0x09C4A0D8  token: 0x6000641
        public static Unity.Mathematics.float4x2 mul(Unity.Mathematics.float4x2 a, Unity.Mathematics.float2x2 b) { }
        // RVA: 0x09C46C88  token: 0x6000642
        public static Unity.Mathematics.float4x3 mul(Unity.Mathematics.float4x2 a, Unity.Mathematics.float2x3 b) { }
        // RVA: 0x09C48C34  token: 0x6000643
        public static Unity.Mathematics.float4x4 mul(Unity.Mathematics.float4x2 a, Unity.Mathematics.float2x4 b) { }
        // RVA: 0x09C4C380  token: 0x6000644
        public static Unity.Mathematics.float4 mul(Unity.Mathematics.float4x3 a, Unity.Mathematics.float3 b) { }
        // RVA: 0x09C4C4EC  token: 0x6000645
        public static Unity.Mathematics.float4x2 mul(Unity.Mathematics.float4x3 a, Unity.Mathematics.float3x2 b) { }
        // RVA: 0x09C4B1EC  token: 0x6000646
        public static Unity.Mathematics.float4x3 mul(Unity.Mathematics.float4x3 a, Unity.Mathematics.float3x3 b) { }
        // RVA: 0x09C4C9B8  token: 0x6000647
        public static Unity.Mathematics.float4x4 mul(Unity.Mathematics.float4x3 a, Unity.Mathematics.float3x4 b) { }
        // RVA: 0x09C4196C  token: 0x6000648
        public static Unity.Mathematics.float4 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4 b) { }
        // RVA: 0x09C44414  token: 0x6000649
        public static Unity.Mathematics.float4x2 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4x2 b) { }
        // RVA: 0x09C4B41C  token: 0x600064A
        public static Unity.Mathematics.float4x3 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4x3 b) { }
        // RVA: 0x09C4F024  token: 0x600064B
        public static Unity.Mathematics.float4x4 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4x4 b) { }
        // RVA: 0x03D79D40  token: 0x600064C
        public static System.Double mul(System.Double a, System.Double b) { }
        // RVA: 0x03D79DB0  token: 0x600064D
        public static System.Double mul(Unity.Mathematics.double2 a, Unity.Mathematics.double2 b) { }
        // RVA: 0x03D7C820  token: 0x600064E
        public static Unity.Mathematics.double2 mul(Unity.Mathematics.double2 a, Unity.Mathematics.double2x2 b) { }
        // RVA: 0x03D7C2B0  token: 0x600064F
        public static Unity.Mathematics.double3 mul(Unity.Mathematics.double2 a, Unity.Mathematics.double2x3 b) { }
        // RVA: 0x03D7C380  token: 0x6000650
        public static Unity.Mathematics.double4 mul(Unity.Mathematics.double2 a, Unity.Mathematics.double2x4 b) { }
        // RVA: 0x03D79D80  token: 0x6000651
        public static System.Double mul(Unity.Mathematics.double3 a, Unity.Mathematics.double3 b) { }
        // RVA: 0x03D7C320  token: 0x6000652
        public static Unity.Mathematics.double2 mul(Unity.Mathematics.double3 a, Unity.Mathematics.double3x2 b) { }
        // RVA: 0x03D7C400  token: 0x6000653
        public static Unity.Mathematics.double3 mul(Unity.Mathematics.double3 a, Unity.Mathematics.double3x3 b) { }
        // RVA: 0x03D7C100  token: 0x6000654
        public static Unity.Mathematics.double4 mul(Unity.Mathematics.double3 a, Unity.Mathematics.double3x4 b) { }
        // RVA: 0x03D79CD0  token: 0x6000655
        public static System.Double mul(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b) { }
        // RVA: 0x03D7C490  token: 0x6000656
        public static Unity.Mathematics.double2 mul(Unity.Mathematics.double4 a, Unity.Mathematics.double4x2 b) { }
        // RVA: 0x03D7BE80  token: 0x6000657
        public static Unity.Mathematics.double3 mul(Unity.Mathematics.double4 a, Unity.Mathematics.double4x3 b) { }
        // RVA: 0x03D7CA80  token: 0x6000658
        public static Unity.Mathematics.double4 mul(Unity.Mathematics.double4 a, Unity.Mathematics.double4x4 b) { }
        // RVA: 0x09C49660  token: 0x6000659
        public static Unity.Mathematics.double2 mul(Unity.Mathematics.double2x2 a, Unity.Mathematics.double2 b) { }
        // RVA: 0x09C48004  token: 0x600065A
        public static Unity.Mathematics.double2x2 mul(Unity.Mathematics.double2x2 a, Unity.Mathematics.double2x2 b) { }
        // RVA: 0x09C4A378  token: 0x600065B
        public static Unity.Mathematics.double2x3 mul(Unity.Mathematics.double2x2 a, Unity.Mathematics.double2x3 b) { }
        // RVA: 0x09C49A84  token: 0x600065C
        public static Unity.Mathematics.double2x4 mul(Unity.Mathematics.double2x2 a, Unity.Mathematics.double2x4 b) { }
        // RVA: 0x09C41A64  token: 0x600065D
        public static Unity.Mathematics.double2 mul(Unity.Mathematics.double2x3 a, Unity.Mathematics.double3 b) { }
        // RVA: 0x09C48AD0  token: 0x600065E
        public static Unity.Mathematics.double2x2 mul(Unity.Mathematics.double2x3 a, Unity.Mathematics.double3x2 b) { }
        // RVA: 0x09C4D214  token: 0x600065F
        public static Unity.Mathematics.double2x3 mul(Unity.Mathematics.double2x3 a, Unity.Mathematics.double3x3 b) { }
        // RVA: 0x09C4AC48  token: 0x6000660
        public static Unity.Mathematics.double2x4 mul(Unity.Mathematics.double2x3 a, Unity.Mathematics.double3x4 b) { }
        // RVA: 0x09C4E18C  token: 0x6000661
        public static Unity.Mathematics.double2 mul(Unity.Mathematics.double2x4 a, Unity.Mathematics.double4 b) { }
        // RVA: 0x09C433A0  token: 0x6000662
        public static Unity.Mathematics.double2x2 mul(Unity.Mathematics.double2x4 a, Unity.Mathematics.double4x2 b) { }
        // RVA: 0x09C4D514  token: 0x6000663
        public static Unity.Mathematics.double2x3 mul(Unity.Mathematics.double2x4 a, Unity.Mathematics.double4x3 b) { }
        // RVA: 0x09C437EC  token: 0x6000664
        public static Unity.Mathematics.double2x4 mul(Unity.Mathematics.double2x4 a, Unity.Mathematics.double4x4 b) { }
        // RVA: 0x09C48488  token: 0x6000665
        public static Unity.Mathematics.double3 mul(Unity.Mathematics.double3x2 a, Unity.Mathematics.double2 b) { }
        // RVA: 0x09C4ECD0  token: 0x6000666
        public static Unity.Mathematics.double3x2 mul(Unity.Mathematics.double3x2 a, Unity.Mathematics.double2x2 b) { }
        // RVA: 0x09C44AAC  token: 0x6000667
        public static Unity.Mathematics.double3x3 mul(Unity.Mathematics.double3x2 a, Unity.Mathematics.double2x3 b) { }
        // RVA: 0x09C4F540  token: 0x6000668
        public static Unity.Mathematics.double3x4 mul(Unity.Mathematics.double3x2 a, Unity.Mathematics.double2x4 b) { }
        // RVA: 0x09C4C26C  token: 0x6000669
        public static Unity.Mathematics.double3 mul(Unity.Mathematics.double3x3 a, Unity.Mathematics.double3 b) { }
        // RVA: 0x09C44F40  token: 0x600066A
        public static Unity.Mathematics.double3x2 mul(Unity.Mathematics.double3x3 a, Unity.Mathematics.double3x2 b) { }
        // RVA: 0x09C480E0  token: 0x600066B
        public static Unity.Mathematics.double3x3 mul(Unity.Mathematics.double3x3 a, Unity.Mathematics.double3x3 b) { }
        // RVA: 0x09C445F8  token: 0x600066C
        public static Unity.Mathematics.double3x4 mul(Unity.Mathematics.double3x3 a, Unity.Mathematics.double3x4 b) { }
        // RVA: 0x09C4649C  token: 0x600066D
        public static Unity.Mathematics.double3 mul(Unity.Mathematics.double3x4 a, Unity.Mathematics.double4 b) { }
        // RVA: 0x09C48E1C  token: 0x600066E
        public static Unity.Mathematics.double3x2 mul(Unity.Mathematics.double3x4 a, Unity.Mathematics.double4x2 b) { }
        // RVA: 0x09C4DB64  token: 0x600066F
        public static Unity.Mathematics.double3x3 mul(Unity.Mathematics.double3x4 a, Unity.Mathematics.double4x3 b) { }
        // RVA: 0x09C4E3E0  token: 0x6000670
        public static Unity.Mathematics.double3x4 mul(Unity.Mathematics.double3x4 a, Unity.Mathematics.double4x4 b) { }
        // RVA: 0x09C4ABA0  token: 0x6000671
        public static Unity.Mathematics.double4 mul(Unity.Mathematics.double4x2 a, Unity.Mathematics.double2 b) { }
        // RVA: 0x09C4D9F8  token: 0x6000672
        public static Unity.Mathematics.double4x2 mul(Unity.Mathematics.double4x2 a, Unity.Mathematics.double2x2 b) { }
        // RVA: 0x09C4BC78  token: 0x6000673
        public static Unity.Mathematics.double4x3 mul(Unity.Mathematics.double4x2 a, Unity.Mathematics.double2x3 b) { }
        // RVA: 0x09C4F868  token: 0x6000674
        public static Unity.Mathematics.double4x4 mul(Unity.Mathematics.double4x2 a, Unity.Mathematics.double2x4 b) { }
        // RVA: 0x09C47BD8  token: 0x6000675
        public static Unity.Mathematics.double4 mul(Unity.Mathematics.double4x3 a, Unity.Mathematics.double3 b) { }
        // RVA: 0x09C49C6C  token: 0x6000676
        public static Unity.Mathematics.double4x2 mul(Unity.Mathematics.double4x3 a, Unity.Mathematics.double3x2 b) { }
        // RVA: 0x09C4B7B0  token: 0x6000677
        public static Unity.Mathematics.double4x3 mul(Unity.Mathematics.double4x3 a, Unity.Mathematics.double3x3 b) { }
        // RVA: 0x09C45440  token: 0x6000678
        public static Unity.Mathematics.double4x4 mul(Unity.Mathematics.double4x3 a, Unity.Mathematics.double3x4 b) { }
        // RVA: 0x09C427EC  token: 0x6000679
        public static Unity.Mathematics.double4 mul(Unity.Mathematics.double4x4 a, Unity.Mathematics.double4 b) { }
        // RVA: 0x09C497B4  token: 0x600067A
        public static Unity.Mathematics.double4x2 mul(Unity.Mathematics.double4x4 a, Unity.Mathematics.double4x2 b) { }
        // RVA: 0x09C46610  token: 0x600067B
        public static Unity.Mathematics.double4x3 mul(Unity.Mathematics.double4x4 a, Unity.Mathematics.double4x3 b) { }
        // RVA: 0x09C45D90  token: 0x600067C
        public static Unity.Mathematics.double4x4 mul(Unity.Mathematics.double4x4 a, Unity.Mathematics.double4x4 b) { }
        // RVA: 0x03D79CC0  token: 0x600067D
        public static System.Int32 mul(System.Int32 a, System.Int32 b) { }
        // RVA: 0x03D79D50  token: 0x600067E
        public static System.Int32 mul(Unity.Mathematics.int2 a, Unity.Mathematics.int2 b) { }
        // RVA: 0x03D7C6C0  token: 0x600067F
        public static Unity.Mathematics.int2 mul(Unity.Mathematics.int2 a, Unity.Mathematics.int2x2 b) { }
        // RVA: 0x03D7C060  token: 0x6000680
        public static Unity.Mathematics.int3 mul(Unity.Mathematics.int2 a, Unity.Mathematics.int2x3 b) { }
        // RVA: 0x03D7C510  token: 0x6000681
        public static Unity.Mathematics.int4 mul(Unity.Mathematics.int2 a, Unity.Mathematics.int2x4 b) { }
        // RVA: 0x03D4E570  token: 0x6000682
        public static System.Int32 mul(Unity.Mathematics.int3 a, Unity.Mathematics.int3 b) { }
        // RVA: 0x03D7C700  token: 0x6000683
        public static Unity.Mathematics.int2 mul(Unity.Mathematics.int3 a, Unity.Mathematics.int3x2 b) { }
        // RVA: 0x03D7BF40  token: 0x6000684
        public static Unity.Mathematics.int3 mul(Unity.Mathematics.int3 a, Unity.Mathematics.int3x3 b) { }
        // RVA: 0x03D7BFC0  token: 0x6000685
        public static Unity.Mathematics.int4 mul(Unity.Mathematics.int3 a, Unity.Mathematics.int3x4 b) { }
        // RVA: 0x03D79D10  token: 0x6000686
        public static System.Int32 mul(Unity.Mathematics.int4 a, Unity.Mathematics.int4 b) { }
        // RVA: 0x03D7C590  token: 0x6000687
        public static Unity.Mathematics.int2 mul(Unity.Mathematics.int4 a, Unity.Mathematics.int4x2 b) { }
        // RVA: 0x03D7BDE0  token: 0x6000688
        public static Unity.Mathematics.int3 mul(Unity.Mathematics.int4 a, Unity.Mathematics.int4x3 b) { }
        // RVA: 0x03D7BC60  token: 0x6000689
        public static Unity.Mathematics.int4 mul(Unity.Mathematics.int4 a, Unity.Mathematics.int4x4 b) { }
        // RVA: 0x09C45A4C  token: 0x600068A
        public static Unity.Mathematics.int2 mul(Unity.Mathematics.int2x2 a, Unity.Mathematics.int2 b) { }
        // RVA: 0x09C4C438  token: 0x600068B
        public static Unity.Mathematics.int2x2 mul(Unity.Mathematics.int2x2 a, Unity.Mathematics.int2x2 b) { }
        // RVA: 0x09C46394  token: 0x600068C
        public static Unity.Mathematics.int2x3 mul(Unity.Mathematics.int2x2 a, Unity.Mathematics.int2x3 b) { }
        // RVA: 0x09C42014  token: 0x600068D
        public static Unity.Mathematics.int2x4 mul(Unity.Mathematics.int2x2 a, Unity.Mathematics.int2x4 b) { }
        // RVA: 0x09C47CDC  token: 0x600068E
        public static Unity.Mathematics.int2 mul(Unity.Mathematics.int2x3 a, Unity.Mathematics.int3 b) { }
        // RVA: 0x09C49550  token: 0x600068F
        public static Unity.Mathematics.int2x2 mul(Unity.Mathematics.int2x3 a, Unity.Mathematics.int3x2 b) { }
        // RVA: 0x09C45A94  token: 0x6000690
        public static Unity.Mathematics.int2x3 mul(Unity.Mathematics.int2x3 a, Unity.Mathematics.int3x3 b) { }
        // RVA: 0x09C431B4  token: 0x6000691
        public static Unity.Mathematics.int2x4 mul(Unity.Mathematics.int2x3 a, Unity.Mathematics.int3x4 b) { }
        // RVA: 0x09C45178  token: 0x6000692
        public static Unity.Mathematics.int2 mul(Unity.Mathematics.int2x4 a, Unity.Mathematics.int4 b) { }
        // RVA: 0x09C45C2C  token: 0x6000693
        public static Unity.Mathematics.int2x2 mul(Unity.Mathematics.int2x4 a, Unity.Mathematics.int4x2 b) { }
        // RVA: 0x09C42A14  token: 0x6000694
        public static Unity.Mathematics.int2x3 mul(Unity.Mathematics.int2x4 a, Unity.Mathematics.int4x3 b) { }
        // RVA: 0x09C4AF68  token: 0x6000695
        public static Unity.Mathematics.int2x4 mul(Unity.Mathematics.int2x4 a, Unity.Mathematics.int4x4 b) { }
        // RVA: 0x09C458C4  token: 0x6000696
        public static Unity.Mathematics.int3 mul(Unity.Mathematics.int3x2 a, Unity.Mathematics.int2 b) { }
        // RVA: 0x09C4E044  token: 0x6000697
        public static Unity.Mathematics.int3x2 mul(Unity.Mathematics.int3x2 a, Unity.Mathematics.int2x2 b) { }
        // RVA: 0x09C46AB4  token: 0x6000698
        public static Unity.Mathematics.int3x3 mul(Unity.Mathematics.int3x2 a, Unity.Mathematics.int2x3 b) { }
        // RVA: 0x09C4759C  token: 0x6000699
        public static Unity.Mathematics.int3x4 mul(Unity.Mathematics.int3x2 a, Unity.Mathematics.int2x4 b) { }
        // RVA: 0x09C474B0  token: 0x600069A
        public static Unity.Mathematics.int3 mul(Unity.Mathematics.int3x3 a, Unity.Mathematics.int3 b) { }
        // RVA: 0x09C435FC  token: 0x600069B
        public static Unity.Mathematics.int3x2 mul(Unity.Mathematics.int3x3 a, Unity.Mathematics.int3x2 b) { }
        // RVA: 0x09C4BFA0  token: 0x600069C
        public static Unity.Mathematics.int3x3 mul(Unity.Mathematics.int3x3 a, Unity.Mathematics.int3x3 b) { }
        // RVA: 0x09C47104  token: 0x600069D
        public static Unity.Mathematics.int3x4 mul(Unity.Mathematics.int3x3 a, Unity.Mathematics.int3x4 b) { }
        // RVA: 0x09C45220  token: 0x600069E
        public static Unity.Mathematics.int3 mul(Unity.Mathematics.int3x4 a, Unity.Mathematics.int4 b) { }
        // RVA: 0x09C42180  token: 0x600069F
        public static Unity.Mathematics.int3x2 mul(Unity.Mathematics.int3x4 a, Unity.Mathematics.int4x2 b) { }
        // RVA: 0x09C49110  token: 0x60006A0
        public static Unity.Mathematics.int3x3 mul(Unity.Mathematics.int3x4 a, Unity.Mathematics.int4x3 b) { }
        // RVA: 0x09C43EA8  token: 0x60006A1
        public static Unity.Mathematics.int3x4 mul(Unity.Mathematics.int3x4 a, Unity.Mathematics.int4x4 b) { }
        // RVA: 0x09C4294C  token: 0x60006A2
        public static Unity.Mathematics.int4 mul(Unity.Mathematics.int4x2 a, Unity.Mathematics.int2 b) { }
        // RVA: 0x09C45360  token: 0x60006A3
        public static Unity.Mathematics.int4x2 mul(Unity.Mathematics.int4x2 a, Unity.Mathematics.int2x2 b) { }
        // RVA: 0x09C47D58  token: 0x60006A4
        public static Unity.Mathematics.int4x3 mul(Unity.Mathematics.int4x2 a, Unity.Mathematics.int2x3 b) { }
        // RVA: 0x09C4A4EC  token: 0x60006A5
        public static Unity.Mathematics.int4x4 mul(Unity.Mathematics.int4x2 a, Unity.Mathematics.int2x4 b) { }
        // RVA: 0x09C424F0  token: 0x60006A6
        public static Unity.Mathematics.int4 mul(Unity.Mathematics.int4x3 a, Unity.Mathematics.int3 b) { }
        // RVA: 0x09C43D50  token: 0x60006A7
        public static Unity.Mathematics.int4x2 mul(Unity.Mathematics.int4x3 a, Unity.Mathematics.int3x2 b) { }
        // RVA: 0x09C41B1C  token: 0x60006A8
        public static Unity.Mathematics.int4x3 mul(Unity.Mathematics.int4x3 a, Unity.Mathematics.int3x3 b) { }
        // RVA: 0x09C46DFC  token: 0x60006A9
        public static Unity.Mathematics.int4x4 mul(Unity.Mathematics.int4x3 a, Unity.Mathematics.int3x4 b) { }
        // RVA: 0x09C4AAB0  token: 0x60006AA
        public static Unity.Mathematics.int4 mul(Unity.Mathematics.int4x4 a, Unity.Mathematics.int4 b) { }
        // RVA: 0x09C4853C  token: 0x60006AB
        public static Unity.Mathematics.int4x2 mul(Unity.Mathematics.int4x4 a, Unity.Mathematics.int4x2 b) { }
        // RVA: 0x09C4C654  token: 0x60006AC
        public static Unity.Mathematics.int4x3 mul(Unity.Mathematics.int4x4 a, Unity.Mathematics.int4x3 b) { }
        // RVA: 0x09C4CE04  token: 0x60006AD
        public static Unity.Mathematics.int4x4 mul(Unity.Mathematics.int4x4 a, Unity.Mathematics.int4x4 b) { }
        // RVA: 0x03D79CC0  token: 0x60006AE
        public static System.UInt32 mul(System.UInt32 a, System.UInt32 b) { }
        // RVA: 0x03D79D50  token: 0x60006AF
        public static System.UInt32 mul(Unity.Mathematics.uint2 a, Unity.Mathematics.uint2 b) { }
        // RVA: 0x03D7C6C0  token: 0x60006B0
        public static Unity.Mathematics.uint2 mul(Unity.Mathematics.uint2 a, Unity.Mathematics.uint2x2 b) { }
        // RVA: 0x03D7C060  token: 0x60006B1
        public static Unity.Mathematics.uint3 mul(Unity.Mathematics.uint2 a, Unity.Mathematics.uint2x3 b) { }
        // RVA: 0x03D7C8F0  token: 0x60006B2
        public static Unity.Mathematics.uint4 mul(Unity.Mathematics.uint2 a, Unity.Mathematics.uint2x4 b) { }
        // RVA: 0x03D4E570  token: 0x60006B3
        public static System.UInt32 mul(Unity.Mathematics.uint3 a, Unity.Mathematics.uint3 b) { }
        // RVA: 0x03D7C700  token: 0x60006B4
        public static Unity.Mathematics.uint2 mul(Unity.Mathematics.uint3 a, Unity.Mathematics.uint3x2 b) { }
        // RVA: 0x03D7BF40  token: 0x60006B5
        public static Unity.Mathematics.uint3 mul(Unity.Mathematics.uint3 a, Unity.Mathematics.uint3x3 b) { }
        // RVA: 0x03D7BFC0  token: 0x60006B6
        public static Unity.Mathematics.uint4 mul(Unity.Mathematics.uint3 a, Unity.Mathematics.uint3x4 b) { }
        // RVA: 0x03D79D10  token: 0x60006B7
        public static System.UInt32 mul(Unity.Mathematics.uint4 a, Unity.Mathematics.uint4 b) { }
        // RVA: 0x03D7C590  token: 0x60006B8
        public static Unity.Mathematics.uint2 mul(Unity.Mathematics.uint4 a, Unity.Mathematics.uint4x2 b) { }
        // RVA: 0x03D7BDE0  token: 0x60006B9
        public static Unity.Mathematics.uint3 mul(Unity.Mathematics.uint4 a, Unity.Mathematics.uint4x3 b) { }
        // RVA: 0x03D7BC60  token: 0x60006BA
        public static Unity.Mathematics.uint4 mul(Unity.Mathematics.uint4 a, Unity.Mathematics.uint4x4 b) { }
        // RVA: 0x09C45A4C  token: 0x60006BB
        public static Unity.Mathematics.uint2 mul(Unity.Mathematics.uint2x2 a, Unity.Mathematics.uint2 b) { }
        // RVA: 0x09C4C438  token: 0x60006BC
        public static Unity.Mathematics.uint2x2 mul(Unity.Mathematics.uint2x2 a, Unity.Mathematics.uint2x2 b) { }
        // RVA: 0x09C46394  token: 0x60006BD
        public static Unity.Mathematics.uint2x3 mul(Unity.Mathematics.uint2x2 a, Unity.Mathematics.uint2x3 b) { }
        // RVA: 0x09C42014  token: 0x60006BE
        public static Unity.Mathematics.uint2x4 mul(Unity.Mathematics.uint2x2 a, Unity.Mathematics.uint2x4 b) { }
        // RVA: 0x09C47CDC  token: 0x60006BF
        public static Unity.Mathematics.uint2 mul(Unity.Mathematics.uint2x3 a, Unity.Mathematics.uint3 b) { }
        // RVA: 0x09C49550  token: 0x60006C0
        public static Unity.Mathematics.uint2x2 mul(Unity.Mathematics.uint2x3 a, Unity.Mathematics.uint3x2 b) { }
        // RVA: 0x09C45A94  token: 0x60006C1
        public static Unity.Mathematics.uint2x3 mul(Unity.Mathematics.uint2x3 a, Unity.Mathematics.uint3x3 b) { }
        // RVA: 0x09C431B4  token: 0x60006C2
        public static Unity.Mathematics.uint2x4 mul(Unity.Mathematics.uint2x3 a, Unity.Mathematics.uint3x4 b) { }
        // RVA: 0x09C45178  token: 0x60006C3
        public static Unity.Mathematics.uint2 mul(Unity.Mathematics.uint2x4 a, Unity.Mathematics.uint4 b) { }
        // RVA: 0x09C45C2C  token: 0x60006C4
        public static Unity.Mathematics.uint2x2 mul(Unity.Mathematics.uint2x4 a, Unity.Mathematics.uint4x2 b) { }
        // RVA: 0x09C42A14  token: 0x60006C5
        public static Unity.Mathematics.uint2x3 mul(Unity.Mathematics.uint2x4 a, Unity.Mathematics.uint4x3 b) { }
        // RVA: 0x09C4AF68  token: 0x60006C6
        public static Unity.Mathematics.uint2x4 mul(Unity.Mathematics.uint2x4 a, Unity.Mathematics.uint4x4 b) { }
        // RVA: 0x09C458C4  token: 0x60006C7
        public static Unity.Mathematics.uint3 mul(Unity.Mathematics.uint3x2 a, Unity.Mathematics.uint2 b) { }
        // RVA: 0x09C4E044  token: 0x60006C8
        public static Unity.Mathematics.uint3x2 mul(Unity.Mathematics.uint3x2 a, Unity.Mathematics.uint2x2 b) { }
        // RVA: 0x09C46AB4  token: 0x60006C9
        public static Unity.Mathematics.uint3x3 mul(Unity.Mathematics.uint3x2 a, Unity.Mathematics.uint2x3 b) { }
        // RVA: 0x09C4759C  token: 0x60006CA
        public static Unity.Mathematics.uint3x4 mul(Unity.Mathematics.uint3x2 a, Unity.Mathematics.uint2x4 b) { }
        // RVA: 0x09C474B0  token: 0x60006CB
        public static Unity.Mathematics.uint3 mul(Unity.Mathematics.uint3x3 a, Unity.Mathematics.uint3 b) { }
        // RVA: 0x09C435FC  token: 0x60006CC
        public static Unity.Mathematics.uint3x2 mul(Unity.Mathematics.uint3x3 a, Unity.Mathematics.uint3x2 b) { }
        // RVA: 0x09C4BFA0  token: 0x60006CD
        public static Unity.Mathematics.uint3x3 mul(Unity.Mathematics.uint3x3 a, Unity.Mathematics.uint3x3 b) { }
        // RVA: 0x09C47104  token: 0x60006CE
        public static Unity.Mathematics.uint3x4 mul(Unity.Mathematics.uint3x3 a, Unity.Mathematics.uint3x4 b) { }
        // RVA: 0x09C45220  token: 0x60006CF
        public static Unity.Mathematics.uint3 mul(Unity.Mathematics.uint3x4 a, Unity.Mathematics.uint4 b) { }
        // RVA: 0x09C42180  token: 0x60006D0
        public static Unity.Mathematics.uint3x2 mul(Unity.Mathematics.uint3x4 a, Unity.Mathematics.uint4x2 b) { }
        // RVA: 0x09C49110  token: 0x60006D1
        public static Unity.Mathematics.uint3x3 mul(Unity.Mathematics.uint3x4 a, Unity.Mathematics.uint4x3 b) { }
        // RVA: 0x09C43EA8  token: 0x60006D2
        public static Unity.Mathematics.uint3x4 mul(Unity.Mathematics.uint3x4 a, Unity.Mathematics.uint4x4 b) { }
        // RVA: 0x09C4294C  token: 0x60006D3
        public static Unity.Mathematics.uint4 mul(Unity.Mathematics.uint4x2 a, Unity.Mathematics.uint2 b) { }
        // RVA: 0x09C45360  token: 0x60006D4
        public static Unity.Mathematics.uint4x2 mul(Unity.Mathematics.uint4x2 a, Unity.Mathematics.uint2x2 b) { }
        // RVA: 0x09C47D58  token: 0x60006D5
        public static Unity.Mathematics.uint4x3 mul(Unity.Mathematics.uint4x2 a, Unity.Mathematics.uint2x3 b) { }
        // RVA: 0x09C4A4EC  token: 0x60006D6
        public static Unity.Mathematics.uint4x4 mul(Unity.Mathematics.uint4x2 a, Unity.Mathematics.uint2x4 b) { }
        // RVA: 0x09C424F0  token: 0x60006D7
        public static Unity.Mathematics.uint4 mul(Unity.Mathematics.uint4x3 a, Unity.Mathematics.uint3 b) { }
        // RVA: 0x09C43D50  token: 0x60006D8
        public static Unity.Mathematics.uint4x2 mul(Unity.Mathematics.uint4x3 a, Unity.Mathematics.uint3x2 b) { }
        // RVA: 0x09C41B1C  token: 0x60006D9
        public static Unity.Mathematics.uint4x3 mul(Unity.Mathematics.uint4x3 a, Unity.Mathematics.uint3x3 b) { }
        // RVA: 0x09C46DFC  token: 0x60006DA
        public static Unity.Mathematics.uint4x4 mul(Unity.Mathematics.uint4x3 a, Unity.Mathematics.uint3x4 b) { }
        // RVA: 0x09C4AAB0  token: 0x60006DB
        public static Unity.Mathematics.uint4 mul(Unity.Mathematics.uint4x4 a, Unity.Mathematics.uint4 b) { }
        // RVA: 0x09C4853C  token: 0x60006DC
        public static Unity.Mathematics.uint4x2 mul(Unity.Mathematics.uint4x4 a, Unity.Mathematics.uint4x2 b) { }
        // RVA: 0x09C4C654  token: 0x60006DD
        public static Unity.Mathematics.uint4x3 mul(Unity.Mathematics.uint4x4 a, Unity.Mathematics.uint4x3 b) { }
        // RVA: 0x09C4CE04  token: 0x60006DE
        public static Unity.Mathematics.uint4x4 mul(Unity.Mathematics.uint4x4 a, Unity.Mathematics.uint4x4 b) { }
        // RVA: 0x03D7AAC0  token: 0x60006DF
        public static Unity.Mathematics.quaternion quaternion(System.Single x, System.Single y, System.Single z, System.Single w) { }
        // RVA: 0x03D5B250  token: 0x60006E0
        public static Unity.Mathematics.quaternion quaternion(Unity.Mathematics.float4 value) { }
        // RVA: 0x09C50FAC  token: 0x60006E1
        public static Unity.Mathematics.quaternion quaternion(Unity.Mathematics.float3x3 m) { }
        // RVA: 0x09C50F64  token: 0x60006E2
        public static Unity.Mathematics.quaternion quaternion(Unity.Mathematics.float4x4 m) { }
        // RVA: 0x09C2FD34  token: 0x60006E3
        public static Unity.Mathematics.quaternion conjugate(Unity.Mathematics.quaternion q) { }
        // RVA: 0x09C3EF9C  token: 0x60006E4
        public static Unity.Mathematics.quaternion inverse(Unity.Mathematics.quaternion q) { }
        // RVA: 0x09C30A70  token: 0x60006E5
        public static System.Single dot(Unity.Mathematics.quaternion a, Unity.Mathematics.quaternion b) { }
        // RVA: 0x09C3FA88  token: 0x60006E6
        public static System.Single length(Unity.Mathematics.quaternion q) { }
        // RVA: 0x09C3FAC4  token: 0x60006E7
        public static System.Single lengthsq(Unity.Mathematics.quaternion q) { }
        // RVA: 0x09C4FCD8  token: 0x60006E8
        public static Unity.Mathematics.quaternion normalize(Unity.Mathematics.quaternion q) { }
        // RVA: 0x09C50050  token: 0x60006E9
        public static Unity.Mathematics.quaternion normalizesafe(Unity.Mathematics.quaternion q) { }
        // RVA: 0x09C4FFC4  token: 0x60006EA
        public static Unity.Mathematics.quaternion normalizesafe(Unity.Mathematics.quaternion q, Unity.Mathematics.quaternion defaultvalue) { }
        // RVA: 0x04D5E554  token: 0x60006EB
        public static Unity.Mathematics.quaternion unitexp(Unity.Mathematics.quaternion q) { }
        // RVA: 0x04D30CA4  token: 0x60006EC
        public static Unity.Mathematics.quaternion exp(Unity.Mathematics.quaternion q) { }
        // RVA: 0x04D5E678  token: 0x60006ED
        public static Unity.Mathematics.quaternion unitlog(Unity.Mathematics.quaternion q) { }
        // RVA: 0x04D3C860  token: 0x60006EE
        public static Unity.Mathematics.quaternion log(Unity.Mathematics.quaternion q) { }
        // RVA: 0x09C44D18  token: 0x60006EF
        public static Unity.Mathematics.quaternion mul(Unity.Mathematics.quaternion a, Unity.Mathematics.quaternion b) { }
        // RVA: 0x09C4E284  token: 0x60006F0
        public static Unity.Mathematics.float3 mul(Unity.Mathematics.quaternion q, Unity.Mathematics.float3 v) { }
        // RVA: 0x09C4E284  token: 0x60006F1
        public static Unity.Mathematics.float3 rotate(Unity.Mathematics.quaternion q, Unity.Mathematics.float3 v) { }
        // RVA: 0x09C4FB78  token: 0x60006F2
        public static Unity.Mathematics.quaternion nlerp(Unity.Mathematics.quaternion q1, Unity.Mathematics.quaternion q2, System.Single t) { }
        // RVA: 0x09C5519C  token: 0x60006F3
        public static Unity.Mathematics.quaternion slerp(Unity.Mathematics.quaternion q1, Unity.Mathematics.quaternion q2, System.Single t) { }
        // RVA: 0x09C2E520  token: 0x60006F4
        public static System.Single angle(Unity.Mathematics.quaternion q1, Unity.Mathematics.quaternion q2) { }
        // RVA: 0x09C52BF8  token: 0x60006F5
        public static Unity.Mathematics.quaternion rotation(Unity.Mathematics.float3x3 m) { }
        // RVA: 0x09C2E1E8  token: 0x60006F6
        private static Unity.Mathematics.float3x3 adj(Unity.Mathematics.float3x3 m, System.Single& det) { }
        // RVA: 0x09C2E0E8  token: 0x60006F7
        private static System.Boolean adjInverse(Unity.Mathematics.float3x3 m, Unity.Mathematics.float3x3& i, System.Single epsilon) { }
        // RVA: 0x09C38878  token: 0x60006F8
        public static System.UInt32 hash(Unity.Mathematics.quaternion q) { }
        // RVA: 0x09C3B4D0  token: 0x60006F9
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.quaternion q) { }
        // RVA: 0x05543208  token: 0x60006FA
        public static Unity.Mathematics.float3 forward(Unity.Mathematics.quaternion q) { }
        // RVA: 0x03D78270  token: 0x60006FB
        public static Unity.Mathematics.RigidTransform RigidTransform(Unity.Mathematics.quaternion rot, Unity.Mathematics.float3 pos) { }
        // RVA: 0x09C2DE48  token: 0x60006FC
        public static Unity.Mathematics.RigidTransform RigidTransform(Unity.Mathematics.float3x3 rotation, Unity.Mathematics.float3 translation) { }
        // RVA: 0x09C2DEA4  token: 0x60006FD
        public static Unity.Mathematics.RigidTransform RigidTransform(Unity.Mathematics.float4x4 transform) { }
        // RVA: 0x09C3F018  token: 0x60006FE
        public static Unity.Mathematics.RigidTransform inverse(Unity.Mathematics.RigidTransform t) { }
        // RVA: 0x09C4D444  token: 0x60006FF
        public static Unity.Mathematics.RigidTransform mul(Unity.Mathematics.RigidTransform a, Unity.Mathematics.RigidTransform b) { }
        // RVA: 0x09C42414  token: 0x6000700
        public static Unity.Mathematics.float4 mul(Unity.Mathematics.RigidTransform a, Unity.Mathematics.float4 pos) { }
        // RVA: 0x0554451C  token: 0x6000701
        public static Unity.Mathematics.float3 rotate(Unity.Mathematics.RigidTransform a, Unity.Mathematics.float3 dir) { }
        // RVA: 0x09C563B8  token: 0x6000702
        public static Unity.Mathematics.float3 transform(Unity.Mathematics.RigidTransform a, Unity.Mathematics.float3 pos) { }
        // RVA: 0x09C38974  token: 0x6000703
        public static System.UInt32 hash(Unity.Mathematics.RigidTransform t) { }
        // RVA: 0x09C39CA0  token: 0x6000704
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.RigidTransform t) { }
        // RVA: 0x03D78AF0  token: 0x6000705
        public static Unity.Mathematics.uint2 uint2(System.UInt32 x, System.UInt32 y) { }
        // RVA: 0x03D76940  token: 0x6000706
        public static Unity.Mathematics.uint2 uint2(Unity.Mathematics.uint2 xy) { }
        // RVA: 0x03D7B520  token: 0x6000707
        public static Unity.Mathematics.uint2 uint2(System.UInt32 v) { }
        // RVA: 0x09C3C78C  token: 0x6000708
        public static Unity.Mathematics.uint2 uint2(System.Boolean v) { }
        // RVA: 0x09C3C7A4  token: 0x6000709
        public static Unity.Mathematics.uint2 uint2(Unity.Mathematics.bool2 v) { }
        // RVA: 0x03D7B520  token: 0x600070A
        public static Unity.Mathematics.uint2 uint2(System.Int32 v) { }
        // RVA: 0x03D76940  token: 0x600070B
        public static Unity.Mathematics.uint2 uint2(Unity.Mathematics.int2 v) { }
        // RVA: 0x09C57A68  token: 0x600070C
        public static Unity.Mathematics.uint2 uint2(System.Single v) { }
        // RVA: 0x09C57A8C  token: 0x600070D
        public static Unity.Mathematics.uint2 uint2(Unity.Mathematics.float2 v) { }
        // RVA: 0x09C57A48  token: 0x600070E
        public static Unity.Mathematics.uint2 uint2(System.Double v) { }
        // RVA: 0x09C57A18  token: 0x600070F
        public static Unity.Mathematics.uint2 uint2(Unity.Mathematics.double2 v) { }
        // RVA: 0x09C36CFC  token: 0x6000710
        public static System.UInt32 hash(Unity.Mathematics.uint2 v) { }
        // RVA: 0x09C39968  token: 0x6000711
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.uint2 v) { }
        // RVA: 0x04D58FA0  token: 0x6000712
        public static System.UInt32 shuffle(Unity.Mathematics.uint2 left, Unity.Mathematics.uint2 right, Unity.Mathematics.math.ShuffleComponent x) { }
        // RVA: 0x04D581BC  token: 0x6000713
        public static Unity.Mathematics.uint2 shuffle(Unity.Mathematics.uint2 left, Unity.Mathematics.uint2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y) { }
        // RVA: 0x04D58730  token: 0x6000714
        public static Unity.Mathematics.uint3 shuffle(Unity.Mathematics.uint2 left, Unity.Mathematics.uint2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z) { }
        // RVA: 0x04D5978C  token: 0x6000715
        public static Unity.Mathematics.uint4 shuffle(Unity.Mathematics.uint2 left, Unity.Mathematics.uint2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w) { }
        // RVA: 0x04D57274  token: 0x6000716
        private static System.UInt32 select_shuffle_component(Unity.Mathematics.uint2 a, Unity.Mathematics.uint2 b, Unity.Mathematics.math.ShuffleComponent component) { }
        // RVA: 0x02232AA0  token: 0x6000717
        public static Unity.Mathematics.uint2x2 uint2x2(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1) { }
        // RVA: 0x09C3C820  token: 0x6000718
        public static Unity.Mathematics.uint2x2 uint2x2(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11) { }
        // RVA: 0x09C3C808  token: 0x6000719
        public static Unity.Mathematics.uint2x2 uint2x2(System.UInt32 v) { }
        // RVA: 0x09C3C8C4  token: 0x600071A
        public static Unity.Mathematics.uint2x2 uint2x2(System.Boolean v) { }
        // RVA: 0x09C3C7C4  token: 0x600071B
        public static Unity.Mathematics.uint2x2 uint2x2(Unity.Mathematics.bool2x2 v) { }
        // RVA: 0x09C3C808  token: 0x600071C
        public static Unity.Mathematics.uint2x2 uint2x2(System.Int32 v) { }
        // RVA: 0x09C3C888  token: 0x600071D
        public static Unity.Mathematics.uint2x2 uint2x2(Unity.Mathematics.int2x2 v) { }
        // RVA: 0x09C57AB0  token: 0x600071E
        public static Unity.Mathematics.uint2x2 uint2x2(System.Single v) { }
        // RVA: 0x09C57B6C  token: 0x600071F
        public static Unity.Mathematics.uint2x2 uint2x2(Unity.Mathematics.float2x2 v) { }
        // RVA: 0x09C57ACC  token: 0x6000720
        public static Unity.Mathematics.uint2x2 uint2x2(System.Double v) { }
        // RVA: 0x09C57B10  token: 0x6000721
        public static Unity.Mathematics.uint2x2 uint2x2(Unity.Mathematics.double2x2 v) { }
        // RVA: 0x09C56888  token: 0x6000722
        public static Unity.Mathematics.uint2x2 transpose(Unity.Mathematics.uint2x2 v) { }
        // RVA: 0x09C3803C  token: 0x6000723
        public static System.UInt32 hash(Unity.Mathematics.uint2x2 v) { }
        // RVA: 0x09C39878  token: 0x6000724
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.uint2x2 v) { }
        // RVA: 0x03D7A7F0  token: 0x6000725
        public static Unity.Mathematics.uint2x3 uint2x3(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1, Unity.Mathematics.uint2 c2) { }
        // RVA: 0x04D3AE7C  token: 0x6000726
        public static Unity.Mathematics.uint2x3 uint2x3(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12) { }
        // RVA: 0x09C3C934  token: 0x6000727
        public static Unity.Mathematics.uint2x3 uint2x3(System.UInt32 v) { }
        // RVA: 0x09C3C9E8  token: 0x6000728
        public static Unity.Mathematics.uint2x3 uint2x3(System.Boolean v) { }
        // RVA: 0x09C3C974  token: 0x6000729
        public static Unity.Mathematics.uint2x3 uint2x3(Unity.Mathematics.bool2x3 v) { }
        // RVA: 0x09C3C934  token: 0x600072A
        public static Unity.Mathematics.uint2x3 uint2x3(System.Int32 v) { }
        // RVA: 0x09C3C8FC  token: 0x600072B
        public static Unity.Mathematics.uint2x3 uint2x3(Unity.Mathematics.int2x3 v) { }
        // RVA: 0x09C57BEC  token: 0x600072C
        public static Unity.Mathematics.uint2x3 uint2x3(System.Single v) { }
        // RVA: 0x09C57BB4  token: 0x600072D
        public static Unity.Mathematics.uint2x3 uint2x3(Unity.Mathematics.float2x3 v) { }
        // RVA: 0x09C57B94  token: 0x600072E
        public static Unity.Mathematics.uint2x3 uint2x3(System.Double v) { }
        // RVA: 0x09C57C0C  token: 0x600072F
        public static Unity.Mathematics.uint2x3 uint2x3(Unity.Mathematics.double2x3 v) { }
        // RVA: 0x09C574EC  token: 0x6000730
        public static Unity.Mathematics.uint3x2 transpose(Unity.Mathematics.uint2x3 v) { }
        // RVA: 0x09C37558  token: 0x6000731
        public static System.UInt32 hash(Unity.Mathematics.uint2x3 v) { }
        // RVA: 0x09C3C4C8  token: 0x6000732
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.uint2x3 v) { }
        // RVA: 0x03D7B550  token: 0x6000733
        public static Unity.Mathematics.uint2x4 uint2x4(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1, Unity.Mathematics.uint2 c2, Unity.Mathematics.uint2 c3) { }
        // RVA: 0x04D3AEB4  token: 0x6000734
        public static Unity.Mathematics.uint2x4 uint2x4(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13) { }
        // RVA: 0x09C3CA64  token: 0x6000735
        public static Unity.Mathematics.uint2x4 uint2x4(System.UInt32 v) { }
        // RVA: 0x09C3CAB4  token: 0x6000736
        public static Unity.Mathematics.uint2x4 uint2x4(System.Boolean v) { }
        // RVA: 0x09C3CA40  token: 0x6000737
        public static Unity.Mathematics.uint2x4 uint2x4(Unity.Mathematics.bool2x4 v) { }
        // RVA: 0x09C3CA64  token: 0x6000738
        public static Unity.Mathematics.uint2x4 uint2x4(System.Int32 v) { }
        // RVA: 0x09C3CA80  token: 0x6000739
        public static Unity.Mathematics.uint2x4 uint2x4(Unity.Mathematics.int2x4 v) { }
        // RVA: 0x09C57C7C  token: 0x600073A
        public static Unity.Mathematics.uint2x4 uint2x4(System.Single v) { }
        // RVA: 0x09C57C48  token: 0x600073B
        public static Unity.Mathematics.uint2x4 uint2x4(Unity.Mathematics.float2x4 v) { }
        // RVA: 0x09C57C9C  token: 0x600073C
        public static Unity.Mathematics.uint2x4 uint2x4(System.Double v) { }
        // RVA: 0x09C57CB8  token: 0x600073D
        public static Unity.Mathematics.uint2x4 uint2x4(Unity.Mathematics.double2x4 v) { }
        // RVA: 0x09C56AA0  token: 0x600073E
        public static Unity.Mathematics.uint4x2 transpose(Unity.Mathematics.uint2x4 v) { }
        // RVA: 0x09C364B0  token: 0x600073F
        public static System.UInt32 hash(Unity.Mathematics.uint2x4 v) { }
        // RVA: 0x09C3B500  token: 0x6000740
        public static Unity.Mathematics.uint2 hashwide(Unity.Mathematics.uint2x4 v) { }
        // RVA: 0x03D78B00  token: 0x6000741
        public static Unity.Mathematics.uint3 uint3(System.UInt32 x, System.UInt32 y, System.UInt32 z) { }
        // RVA: 0x03D7B5B0  token: 0x6000742
        public static Unity.Mathematics.uint3 uint3(System.UInt32 x, Unity.Mathematics.uint2 yz) { }
        // RVA: 0x03D7B5D0  token: 0x6000743
        public static Unity.Mathematics.uint3 uint3(Unity.Mathematics.uint2 xy, System.UInt32 z) { }
        // RVA: 0x03D7B5F0  token: 0x6000744
        public static Unity.Mathematics.uint3 uint3(Unity.Mathematics.uint3 xyz) { }
        // RVA: 0x03D7B570  token: 0x6000745
        public static Unity.Mathematics.uint3 uint3(System.UInt32 v) { }
        // RVA: 0x09C3CB80  token: 0x6000746
        public static Unity.Mathematics.uint3 uint3(System.Boolean v) { }
        // RVA: 0x09C3CB98  token: 0x6000747
        public static Unity.Mathematics.uint3 uint3(Unity.Mathematics.bool3 v) { }
        // RVA: 0x03D7B570  token: 0x6000748
        public static Unity.Mathematics.uint3 uint3(System.Int32 v) { }
        // RVA: 0x03D7B5F0  token: 0x6000749
        public static Unity.Mathematics.uint3 uint3(Unity.Mathematics.int3 v) { }
        // RVA: 0x09C57D5C  token: 0x600074A
        public static Unity.Mathematics.uint3 uint3(System.Single v) { }
        // RVA: 0x04D5FCE8  token: 0x600074B
        public static Unity.Mathematics.uint3 uint3(Unity.Mathematics.float3 v) { }
        // RVA: 0x09C57D34  token: 0x600074C
        public static Unity.Mathematics.uint3 uint3(System.Double v) { }
        // RVA: 0x09C57CFC  token: 0x600074D
        public static Unity.Mathematics.uint3 uint3(Unity.Mathematics.double3 v) { }
        // RVA: 0x04D33F54  token: 0x600074E
        public static System.UInt32 hash(Unity.Mathematics.uint3 v) { }
        // RVA: 0x04D3A078  token: 0x600074F
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.uint3 v) { }
        // RVA: 0x04D599AC  token: 0x6000750
        public static System.UInt32 shuffle(Unity.Mathematics.uint3 left, Unity.Mathematics.uint3 right, Unity.Mathematics.math.ShuffleComponent x) { }
        // RVA: 0x04D58EA8  token: 0x6000751
        public static Unity.Mathematics.uint2 shuffle(Unity.Mathematics.uint3 left, Unity.Mathematics.uint3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y) { }
        // RVA: 0x04D598D0  token: 0x6000752
        public static Unity.Mathematics.uint3 shuffle(Unity.Mathematics.uint3 left, Unity.Mathematics.uint3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z) { }
        // RVA: 0x04D591A0  token: 0x6000753
        public static Unity.Mathematics.uint4 shuffle(Unity.Mathematics.uint3 left, Unity.Mathematics.uint3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w) { }
        // RVA: 0x04D579DC  token: 0x6000754
        private static System.UInt32 select_shuffle_component(Unity.Mathematics.uint3 a, Unity.Mathematics.uint3 b, Unity.Mathematics.math.ShuffleComponent component) { }
        // RVA: 0x03D7AA40  token: 0x6000755
        public static Unity.Mathematics.uint3x2 uint3x2(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1) { }
        // RVA: 0x04D3AF08  token: 0x6000756
        public static Unity.Mathematics.uint3x2 uint3x2(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11, System.UInt32 m20, System.UInt32 m21) { }
        // RVA: 0x09C3CC7C  token: 0x6000757
        public static Unity.Mathematics.uint3x2 uint3x2(System.UInt32 v) { }
        // RVA: 0x09C3CC9C  token: 0x6000758
        public static Unity.Mathematics.uint3x2 uint3x2(System.Boolean v) { }
        // RVA: 0x09C3CCBC  token: 0x6000759
        public static Unity.Mathematics.uint3x2 uint3x2(Unity.Mathematics.bool3x2 v) { }
        // RVA: 0x09C3CC7C  token: 0x600075A
        public static Unity.Mathematics.uint3x2 uint3x2(System.Int32 v) { }
        // RVA: 0x09C3CC0C  token: 0x600075B
        public static Unity.Mathematics.uint3x2 uint3x2(Unity.Mathematics.int3x2 v) { }
        // RVA: 0x09C57E4C  token: 0x600075C
        public static Unity.Mathematics.uint3x2 uint3x2(System.Single v) { }
        // RVA: 0x09C57E14  token: 0x600075D
        public static Unity.Mathematics.uint3x2 uint3x2(Unity.Mathematics.float3x2 v) { }
        // RVA: 0x09C57D78  token: 0x600075E
        public static Unity.Mathematics.uint3x2 uint3x2(System.Double v) { }
        // RVA: 0x09C57DD8  token: 0x600075F
        public static Unity.Mathematics.uint3x2 uint3x2(Unity.Mathematics.double3x2 v) { }
        // RVA: 0x09C568C4  token: 0x6000760
        public static Unity.Mathematics.uint2x3 transpose(Unity.Mathematics.uint3x2 v) { }
        // RVA: 0x09C36A54  token: 0x6000761
        public static System.UInt32 hash(Unity.Mathematics.uint3x2 v) { }
        // RVA: 0x09C3AFE8  token: 0x6000762
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.uint3x2 v) { }
        // RVA: 0x02E246E0  token: 0x6000763
        public static Unity.Mathematics.uint3x3 uint3x3(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1, Unity.Mathematics.uint3 c2) { }
        // RVA: 0x04D3AF98  token: 0x6000764
        public static Unity.Mathematics.uint3x3 uint3x3(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22) { }
        // RVA: 0x09C3CD34  token: 0x6000765
        public static Unity.Mathematics.uint3x3 uint3x3(System.UInt32 v) { }
        // RVA: 0x09C3CEAC  token: 0x6000766
        public static Unity.Mathematics.uint3x3 uint3x3(System.Boolean v) { }
        // RVA: 0x09C3CE6C  token: 0x6000767
        public static Unity.Mathematics.uint3x3 uint3x3(Unity.Mathematics.bool3x3 v) { }
        // RVA: 0x09C3CD34  token: 0x6000768
        public static Unity.Mathematics.uint3x3 uint3x3(System.Int32 v) { }
        // RVA: 0x09C3CD74  token: 0x6000769
        public static Unity.Mathematics.uint3x3 uint3x3(Unity.Mathematics.int3x3 v) { }
        // RVA: 0x09C57ECC  token: 0x600076A
        public static Unity.Mathematics.uint3x3 uint3x3(System.Single v) { }
        // RVA: 0x09C57E8C  token: 0x600076B
        public static Unity.Mathematics.uint3x3 uint3x3(Unity.Mathematics.float3x3 v) { }
        // RVA: 0x09C57E6C  token: 0x600076C
        public static Unity.Mathematics.uint3x3 uint3x3(System.Double v) { }
        // RVA: 0x09C57EF0  token: 0x600076D
        public static Unity.Mathematics.uint3x3 uint3x3(Unity.Mathematics.double3x3 v) { }
        // RVA: 0x09C56E28  token: 0x600076E
        public static Unity.Mathematics.uint3x3 transpose(Unity.Mathematics.uint3x3 v) { }
        // RVA: 0x09C38234  token: 0x600076F
        public static System.UInt32 hash(Unity.Mathematics.uint3x3 v) { }
        // RVA: 0x09C3B6C0  token: 0x6000770
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.uint3x3 v) { }
        // RVA: 0x03D7AA70  token: 0x6000771
        public static Unity.Mathematics.uint3x4 uint3x4(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1, Unity.Mathematics.uint3 c2, Unity.Mathematics.uint3 c3) { }
        // RVA: 0x04D3B05C  token: 0x6000772
        public static Unity.Mathematics.uint3x4 uint3x4(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m23) { }
        // RVA: 0x09C3CF88  token: 0x6000773
        public static Unity.Mathematics.uint3x4 uint3x4(System.UInt32 v) { }
        // RVA: 0x09C3CECC  token: 0x6000774
        public static Unity.Mathematics.uint3x4 uint3x4(System.Boolean v) { }
        // RVA: 0x09C3CF4C  token: 0x6000775
        public static Unity.Mathematics.uint3x4 uint3x4(Unity.Mathematics.bool3x4 v) { }
        // RVA: 0x09C3CF88  token: 0x6000776
        public static Unity.Mathematics.uint3x4 uint3x4(System.Int32 v) { }
        // RVA: 0x09C3D02C  token: 0x6000777
        public static Unity.Mathematics.uint3x4 uint3x4(Unity.Mathematics.int3x4 v) { }
        // RVA: 0x09C58004  token: 0x6000778
        public static Unity.Mathematics.uint3x4 uint3x4(System.Single v) { }
        // RVA: 0x09C57FC0  token: 0x6000779
        public static Unity.Mathematics.uint3x4 uint3x4(Unity.Mathematics.float3x4 v) { }
        // RVA: 0x09C57F44  token: 0x600077A
        public static Unity.Mathematics.uint3x4 uint3x4(System.Double v) { }
        // RVA: 0x09C57F64  token: 0x600077B
        public static Unity.Mathematics.uint3x4 uint3x4(Unity.Mathematics.double3x4 v) { }
        // RVA: 0x09C569B0  token: 0x600077C
        public static Unity.Mathematics.uint4x3 transpose(Unity.Mathematics.uint3x4 v) { }
        // RVA: 0x09C37E70  token: 0x600077D
        public static System.UInt32 hash(Unity.Mathematics.uint3x4 v) { }
        // RVA: 0x09C3C1F8  token: 0x600077E
        public static Unity.Mathematics.uint3 hashwide(Unity.Mathematics.uint3x4 v) { }
        // RVA: 0x03D78B10  token: 0x600077F
        public static Unity.Mathematics.uint4 uint4(System.UInt32 x, System.UInt32 y, System.UInt32 z, System.UInt32 w) { }
        // RVA: 0x03D7B730  token: 0x6000780
        public static Unity.Mathematics.uint4 uint4(System.UInt32 x, System.UInt32 y, Unity.Mathematics.uint2 zw) { }
        // RVA: 0x03D7B7B0  token: 0x6000781
        public static Unity.Mathematics.uint4 uint4(System.UInt32 x, Unity.Mathematics.uint2 yz, System.UInt32 w) { }
        // RVA: 0x03D7B6B0  token: 0x6000782
        public static Unity.Mathematics.uint4 uint4(System.UInt32 x, Unity.Mathematics.uint3 yzw) { }
        // RVA: 0x03D7B750  token: 0x6000783
        public static Unity.Mathematics.uint4 uint4(Unity.Mathematics.uint2 xy, System.UInt32 z, System.UInt32 w) { }
        // RVA: 0x03D76960  token: 0x6000784
        public static Unity.Mathematics.uint4 uint4(Unity.Mathematics.uint2 xy, Unity.Mathematics.uint2 zw) { }
        // RVA: 0x03D7B770  token: 0x6000785
        public static Unity.Mathematics.uint4 uint4(Unity.Mathematics.uint3 xyz, System.UInt32 w) { }
        // RVA: 0x09C3D070  token: 0x6000786
        public static Unity.Mathematics.uint4 uint4(Unity.Mathematics.uint4 xyzw) { }
        // RVA: 0x03D7B6A0  token: 0x6000787
        public static Unity.Mathematics.uint4 uint4(System.UInt32 v) { }
        // RVA: 0x09C3D09C  token: 0x6000788
        public static Unity.Mathematics.uint4 uint4(System.Boolean v) { }
        // RVA: 0x09C3D0BC  token: 0x6000789
        public static Unity.Mathematics.uint4 uint4(Unity.Mathematics.bool4 v) { }
        // RVA: 0x03D7B6A0  token: 0x600078A
        public static Unity.Mathematics.uint4 uint4(System.Int32 v) { }
        // RVA: 0x09C3D070  token: 0x600078B
        public static Unity.Mathematics.uint4 uint4(Unity.Mathematics.int4 v) { }
        // RVA: 0x09C58070  token: 0x600078C
        public static Unity.Mathematics.uint4 uint4(System.Single v) { }
        // RVA: 0x09C580B8  token: 0x600078D
        public static Unity.Mathematics.uint4 uint4(Unity.Mathematics.float4 v) { }
        // RVA: 0x09C58088  token: 0x600078E
        public static Unity.Mathematics.uint4 uint4(System.Double v) { }
        // RVA: 0x09C58028  token: 0x600078F
        public static Unity.Mathematics.uint4 uint4(Unity.Mathematics.double4 v) { }
        // RVA: 0x09C35DFC  token: 0x6000790
        public static System.UInt32 hash(Unity.Mathematics.uint4 v) { }
        // RVA: 0x09C397FC  token: 0x6000791
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.uint4 v) { }
        // RVA: 0x09C53F00  token: 0x6000792
        public static System.UInt32 shuffle(Unity.Mathematics.uint4 left, Unity.Mathematics.uint4 right, Unity.Mathematics.math.ShuffleComponent x) { }
        // RVA: 0x09C53A80  token: 0x6000793
        public static Unity.Mathematics.uint2 shuffle(Unity.Mathematics.uint4 left, Unity.Mathematics.uint4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y) { }
        // RVA: 0x09C5434C  token: 0x6000794
        public static Unity.Mathematics.uint3 shuffle(Unity.Mathematics.uint4 left, Unity.Mathematics.uint4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z) { }
        // RVA: 0x09C5468C  token: 0x6000795
        public static Unity.Mathematics.uint4 shuffle(Unity.Mathematics.uint4 left, Unity.Mathematics.uint4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w) { }
        // RVA: 0x04D57EF8  token: 0x6000796
        private static System.UInt32 select_shuffle_component(Unity.Mathematics.uint4 a, Unity.Mathematics.uint4 b, Unity.Mathematics.math.ShuffleComponent component) { }
        // RVA: 0x03D7AC80  token: 0x6000797
        public static Unity.Mathematics.uint4x2 uint4x2(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1) { }
        // RVA: 0x04D3B124  token: 0x6000798
        public static Unity.Mathematics.uint4x2 uint4x2(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11, System.UInt32 m20, System.UInt32 m21, System.UInt32 m30, System.UInt32 m31) { }
        // RVA: 0x09C3D1C4  token: 0x6000799
        public static Unity.Mathematics.uint4x2 uint4x2(System.UInt32 v) { }
        // RVA: 0x09C58100  token: 0x600079A
        public static Unity.Mathematics.uint4x2 uint4x2(System.Boolean v) { }
        // RVA: 0x09C580DC  token: 0x600079B
        public static Unity.Mathematics.uint4x2 uint4x2(Unity.Mathematics.bool4x2 v) { }
        // RVA: 0x09C3D1C4  token: 0x600079C
        public static Unity.Mathematics.uint4x2 uint4x2(System.Int32 v) { }
        // RVA: 0x09C3D1E0  token: 0x600079D
        public static Unity.Mathematics.uint4x2 uint4x2(Unity.Mathematics.int4x2 v) { }
        // RVA: 0x09C5811C  token: 0x600079E
        public static Unity.Mathematics.uint4x2 uint4x2(System.Single v) { }
        // RVA: 0x09C58180  token: 0x600079F
        public static Unity.Mathematics.uint4x2 uint4x2(Unity.Mathematics.float4x2 v) { }
        // RVA: 0x09C581B4  token: 0x60007A0
        public static Unity.Mathematics.uint4x2 uint4x2(System.Double v) { }
        // RVA: 0x09C5813C  token: 0x60007A1
        public static Unity.Mathematics.uint4x2 uint4x2(Unity.Mathematics.double4x2 v) { }
        // RVA: 0x09C56910  token: 0x60007A2
        public static Unity.Mathematics.uint2x4 transpose(Unity.Mathematics.uint4x2 v) { }
        // RVA: 0x09C38454  token: 0x60007A3
        public static System.UInt32 hash(Unity.Mathematics.uint4x2 v) { }
        // RVA: 0x09C38E74  token: 0x60007A4
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.uint4x2 v) { }
        // RVA: 0x03D7ACA0  token: 0x60007A5
        public static Unity.Mathematics.uint4x3 uint4x3(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1, Unity.Mathematics.uint4 c2) { }
        // RVA: 0x04D3B1D8  token: 0x60007A6
        public static Unity.Mathematics.uint4x3 uint4x3(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m30, System.UInt32 m31, System.UInt32 m32) { }
        // RVA: 0x09C3D2C4  token: 0x60007A7
        public static Unity.Mathematics.uint4x3 uint4x3(System.UInt32 v) { }
        // RVA: 0x09C582F0  token: 0x60007A8
        public static Unity.Mathematics.uint4x3 uint4x3(System.Boolean v) { }
        // RVA: 0x09C582B4  token: 0x60007A9
        public static Unity.Mathematics.uint4x3 uint4x3(Unity.Mathematics.bool4x3 v) { }
        // RVA: 0x09C3D2C4  token: 0x60007AA
        public static Unity.Mathematics.uint4x3 uint4x3(System.Int32 v) { }
        // RVA: 0x09C3D3A0  token: 0x60007AB
        public static Unity.Mathematics.uint4x3 uint4x3(Unity.Mathematics.int4x3 v) { }
        // RVA: 0x09C58270  token: 0x60007AC
        public static Unity.Mathematics.uint4x3 uint4x3(System.Single v) { }
        // RVA: 0x09C581D0  token: 0x60007AD
        public static Unity.Mathematics.uint4x3 uint4x3(Unity.Mathematics.float4x3 v) { }
        // RVA: 0x09C58294  token: 0x60007AE
        public static Unity.Mathematics.uint4x3 uint4x3(System.Double v) { }
        // RVA: 0x09C58214  token: 0x60007AF
        public static Unity.Mathematics.uint4x3 uint4x3(Unity.Mathematics.double4x3 v) { }
        // RVA: 0x09C56CC4  token: 0x60007B0
        public static Unity.Mathematics.uint3x4 transpose(Unity.Mathematics.uint4x3 v) { }
        // RVA: 0x09C37178  token: 0x60007B1
        public static System.UInt32 hash(Unity.Mathematics.uint4x3 v) { }
        // RVA: 0x09C3B0E0  token: 0x60007B2
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.uint4x3 v) { }
        // RVA: 0x03D7ACC0  token: 0x60007B3
        public static Unity.Mathematics.uint4x4 uint4x4(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1, Unity.Mathematics.uint4 c2, Unity.Mathematics.uint4 c3) { }
        // RVA: 0x04D3B3A0  token: 0x60007B4
        public static Unity.Mathematics.uint4x4 uint4x4(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m23, System.UInt32 m30, System.UInt32 m31, System.UInt32 m32, System.UInt32 m33) { }
        // RVA: 0x09C3D4C4  token: 0x60007B5
        public static Unity.Mathematics.uint4x4 uint4x4(System.UInt32 v) { }
        // RVA: 0x09C58310  token: 0x60007B6
        public static Unity.Mathematics.uint4x4 uint4x4(System.Boolean v) { }
        // RVA: 0x09C58390  token: 0x60007B7
        public static Unity.Mathematics.uint4x4 uint4x4(Unity.Mathematics.bool4x4 v) { }
        // RVA: 0x09C3D4C4  token: 0x60007B8
        public static Unity.Mathematics.uint4x4 uint4x4(System.Int32 v) { }
        // RVA: 0x09C3D544  token: 0x60007B9
        public static Unity.Mathematics.uint4x4 uint4x4(Unity.Mathematics.int4x4 v) { }
        // RVA: 0x09C58454  token: 0x60007BA
        public static Unity.Mathematics.uint4x4 uint4x4(System.Single v) { }
        // RVA: 0x09C58334  token: 0x60007BB
        public static Unity.Mathematics.uint4x4 uint4x4(Unity.Mathematics.float4x4 v) { }
        // RVA: 0x09C5847C  token: 0x60007BC
        public static Unity.Mathematics.uint4x4 uint4x4(System.Double v) { }
        // RVA: 0x09C583C8  token: 0x60007BD
        public static Unity.Mathematics.uint4x4 uint4x4(Unity.Mathematics.double4x4 v) { }
        // RVA: 0x09C57048  token: 0x60007BE
        public static Unity.Mathematics.uint4x4 transpose(Unity.Mathematics.uint4x4 v) { }
        // RVA: 0x09C36D30  token: 0x60007BF
        public static System.UInt32 hash(Unity.Mathematics.uint4x4 v) { }
        // RVA: 0x09C395C0  token: 0x60007C0
        public static Unity.Mathematics.uint4 hashwide(Unity.Mathematics.uint4x4 v) { }

    }

    // TypeToken: 0x2000008  // size: 0x12
    public sealed struct bool2 : System.IEquatable`1
    {
        // Fields
        public System.Boolean x;  // 0x10
        public System.Boolean y;  // 0x11

        // Methods
        // RVA: 0x03D67530  token: 0x60007C1
        public System.Void .ctor(System.Boolean x, System.Boolean y) { }
        // RVA: 0x03D7D460  token: 0x60007C2
        public System.Void .ctor(Unity.Mathematics.bool2 xy) { }
        // RVA: 0x03D7D470  token: 0x60007C3
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x03D787D0  token: 0x60007C4
        public static Unity.Mathematics.bool2 op_Implicit(System.Boolean v) { }
        // RVA: 0x09C5F4B4  token: 0x60007C5
        public virtual System.Boolean Equals(Unity.Mathematics.bool2 rhs) { }
        // RVA: 0x09C5F4C8  token: 0x60007C6
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C5F53C  token: 0x60007C7
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C5F584  token: 0x60007C8
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200000A  // size: 0x14
    public sealed struct bool2x2 : System.IEquatable`1
    {
        // Fields
        public Unity.Mathematics.bool2 c0;  // 0x10
        public Unity.Mathematics.bool2 c1;  // 0x12

        // Methods
        // RVA: 0x03D6EFA0  token: 0x60007C9
        public System.Void .ctor(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1) { }
        // RVA: 0x03D7D4B0  token: 0x60007CA
        public System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11) { }
        // RVA: 0x03D7D480  token: 0x60007CB
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C58FAC  token: 0x60007CC
        public virtual System.Boolean Equals(Unity.Mathematics.bool2x2 rhs) { }
        // RVA: 0x09C5F60C  token: 0x60007CD
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C5F66C  token: 0x60007CE
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C5F674  token: 0x60007CF
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200000B  // size: 0x16
    public sealed struct bool2x3 : System.IEquatable`1
    {
        // Fields
        public Unity.Mathematics.bool2 c0;  // 0x10
        public Unity.Mathematics.bool2 c1;  // 0x12
        public Unity.Mathematics.bool2 c2;  // 0x14

        // Methods
        // RVA: 0x03D7D570  token: 0x60007D0
        public System.Void .ctor(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1, Unity.Mathematics.bool2 c2) { }
        // RVA: 0x03D7D4E0  token: 0x60007D1
        public System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12) { }
        // RVA: 0x03D7D530  token: 0x60007D2
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C59134  token: 0x60007D3
        public virtual System.Boolean Equals(Unity.Mathematics.bool2x3 rhs) { }
        // RVA: 0x09C5F7D0  token: 0x60007D4
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C5F840  token: 0x60007D5
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C5F864  token: 0x60007D6
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200000C  // size: 0x18
    public sealed struct bool2x4 : System.IEquatable`1
    {
        // Fields
        public Unity.Mathematics.bool2 c0;  // 0x10
        public Unity.Mathematics.bool2 c1;  // 0x12
        public Unity.Mathematics.bool2 c2;  // 0x14
        public Unity.Mathematics.bool2 c3;  // 0x16

        // Methods
        // RVA: 0x03D7D630  token: 0x60007D7
        public System.Void .ctor(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1, Unity.Mathematics.bool2 c2, Unity.Mathematics.bool2 c3) { }
        // RVA: 0x03D7D580  token: 0x60007D8
        public System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13) { }
        // RVA: 0x03D7D5E0  token: 0x60007D9
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C5933C  token: 0x60007DA
        public virtual System.Boolean Equals(Unity.Mathematics.bool2x4 rhs) { }
        // RVA: 0x09C5FA2C  token: 0x60007DB
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C5FA8C  token: 0x60007DC
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C5FA94  token: 0x60007DD
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200000D  // size: 0x13
    public sealed struct bool3 : System.IEquatable`1
    {
        // Fields
        public System.Boolean x;  // 0x10
        public System.Boolean y;  // 0x11
        public System.Boolean z;  // 0x12

        // Properties
        System.Boolean Item { get; /* RVA: 0x029BF5F0 */ set; /* RVA: 0x03D5EB10 */ }

        // Methods
        // RVA: 0x03D6B5F0  token: 0x60007DE
        public System.Void .ctor(System.Boolean x, System.Boolean y, System.Boolean z) { }
        // RVA: 0x03D7D660  token: 0x60007DF
        public System.Void .ctor(System.Boolean x, Unity.Mathematics.bool2 yz) { }
        // RVA: 0x03D7D670  token: 0x60007E0
        public System.Void .ctor(Unity.Mathematics.bool2 xy, System.Boolean z) { }
        // RVA: 0x03D7D680  token: 0x60007E1
        public System.Void .ctor(Unity.Mathematics.bool3 xyz) { }
        // RVA: 0x03D7D650  token: 0x60007E2
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x03D78870  token: 0x60007E3
        public static Unity.Mathematics.bool3 op_Implicit(System.Boolean v) { }
        // RVA: 0x02E9FD70  token: 0x60007E4
        public static Unity.Mathematics.bool3 op_BitwiseAnd(Unity.Mathematics.bool3 lhs, Unity.Mathematics.bool3 rhs) { }
        // RVA: 0x09C5FE0C  token: 0x60007E5
        public static Unity.Mathematics.bool3 op_BitwiseOr(Unity.Mathematics.bool3 lhs, Unity.Mathematics.bool3 rhs) { }
        // RVA: 0x09C595C4  token: 0x60007E8
        public virtual System.Boolean Equals(Unity.Mathematics.bool3 rhs) { }
        // RVA: 0x09C5FCC4  token: 0x60007E9
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C5FD34  token: 0x60007EA
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C5FD58  token: 0x60007EB
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200000F  // size: 0x16
    public sealed struct bool3x2 : System.IEquatable`1
    {
        // Fields
        public Unity.Mathematics.bool3 c0;  // 0x10
        public Unity.Mathematics.bool3 c1;  // 0x13

        // Methods
        // RVA: 0x03D7D710  token: 0x60007EC
        public System.Void .ctor(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1) { }
        // RVA: 0x03D7D6A0  token: 0x60007ED
        public System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11, System.Boolean m20, System.Boolean m21) { }
        // RVA: 0x03D7D6E0  token: 0x60007EE
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C5FEAC  token: 0x60007EF
        public virtual System.Boolean Equals(Unity.Mathematics.bool3x2 rhs) { }
        // RVA: 0x09C5FE3C  token: 0x60007F0
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C5FEF8  token: 0x60007F1
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C5FF1C  token: 0x60007F2
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000010  // size: 0x19
    public sealed struct bool3x3 : System.IEquatable`1
    {
        // Fields
        public Unity.Mathematics.bool3 c0;  // 0x10
        public Unity.Mathematics.bool3 c1;  // 0x13
        public Unity.Mathematics.bool3 c2;  // 0x16

        // Methods
        // RVA: 0x03D7D7E0  token: 0x60007F3
        public System.Void .ctor(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1, Unity.Mathematics.bool3 c2) { }
        // RVA: 0x03D7D770  token: 0x60007F4
        public System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m20, System.Boolean m21, System.Boolean m22) { }
        // RVA: 0x03D7D730  token: 0x60007F5
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C60158  token: 0x60007F6
        public virtual System.Boolean Equals(Unity.Mathematics.bool3x3 rhs) { }
        // RVA: 0x09C600E4  token: 0x60007F7
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C601CC  token: 0x60007F8
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C601F4  token: 0x60007F9
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000011  // size: 0x1C
    public sealed struct bool3x4 : System.IEquatable`1
    {
        // Fields
        public Unity.Mathematics.bool3 c0;  // 0x10
        public Unity.Mathematics.bool3 c1;  // 0x13
        public Unity.Mathematics.bool3 c2;  // 0x16
        public Unity.Mathematics.bool3 c3;  // 0x19

        // Methods
        // RVA: 0x03D7D8F0  token: 0x60007FA
        public System.Void .ctor(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1, Unity.Mathematics.bool3 c2, Unity.Mathematics.bool3 c3) { }
        // RVA: 0x03D7D860  token: 0x60007FB
        public System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m23) { }
        // RVA: 0x03D7D810  token: 0x60007FC
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C60458  token: 0x60007FD
        public virtual System.Boolean Equals(Unity.Mathematics.bool3x4 rhs) { }
        // RVA: 0x09C604EC  token: 0x60007FE
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C60560  token: 0x60007FF
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C60584  token: 0x6000800
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000012  // size: 0x14
    public sealed struct bool4 : System.IEquatable`1
    {
        // Fields
        public System.Boolean x;  // 0x10
        public System.Boolean y;  // 0x11
        public System.Boolean z;  // 0x12
        public System.Boolean w;  // 0x13

        // Properties
        System.Int32 Item { set; /* RVA: 0x03D5EB10 */ }

        // Methods
        // RVA: 0x03D76590  token: 0x6000801
        public System.Void .ctor(System.Boolean x, System.Boolean y, System.Boolean z, System.Boolean w) { }
        // RVA: 0x03D7DA10  token: 0x6000802
        public System.Void .ctor(System.Boolean x, System.Boolean y, Unity.Mathematics.bool2 zw) { }
        // RVA: 0x03D7D970  token: 0x6000803
        public System.Void .ctor(System.Boolean x, Unity.Mathematics.bool2 yz, System.Boolean w) { }
        // RVA: 0x03D7D990  token: 0x6000804
        public System.Void .ctor(System.Boolean x, Unity.Mathematics.bool3 yzw) { }
        // RVA: 0x03D7D9B0  token: 0x6000805
        public System.Void .ctor(Unity.Mathematics.bool2 xy, System.Boolean z, System.Boolean w) { }
        // RVA: 0x03D7D9D0  token: 0x6000806
        public System.Void .ctor(Unity.Mathematics.bool2 xy, Unity.Mathematics.bool2 zw) { }
        // RVA: 0x03D7D9F0  token: 0x6000807
        public System.Void .ctor(Unity.Mathematics.bool3 xyz, System.Boolean w) { }
        // RVA: 0x03D7D940  token: 0x6000808
        public System.Void .ctor(Unity.Mathematics.bool4 xyzw) { }
        // RVA: 0x03D7D960  token: 0x6000809
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x03D78A00  token: 0x600080A
        public static Unity.Mathematics.bool4 op_Implicit(System.Boolean v) { }
        // RVA: 0x09C59F38  token: 0x600080C
        public virtual System.Boolean Equals(Unity.Mathematics.bool4 rhs) { }
        // RVA: 0x09C60884  token: 0x600080D
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C608E4  token: 0x600080E
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C608EC  token: 0x600080F
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000014  // size: 0x18
    public sealed struct bool4x2 : System.IEquatable`1
    {
        // Fields
        public Unity.Mathematics.bool4 c0;  // 0x10
        public Unity.Mathematics.bool4 c1;  // 0x14

        // Methods
        // RVA: 0x03D4E4B0  token: 0x6000810
        public System.Void .ctor(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1) { }
        // RVA: 0x03D7DA60  token: 0x6000811
        public System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11, System.Boolean m20, System.Boolean m21, System.Boolean m30, System.Boolean m31) { }
        // RVA: 0x03D7DA30  token: 0x6000812
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C5A0C0  token: 0x6000813
        public virtual System.Boolean Equals(Unity.Mathematics.bool4x2 rhs) { }
        // RVA: 0x09C60A48  token: 0x6000814
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C60AA8  token: 0x6000815
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C60AB0  token: 0x6000816
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000015  // size: 0x1C
    public sealed struct bool4x3 : System.IEquatable`1
    {
        // Fields
        public Unity.Mathematics.bool4 c0;  // 0x10
        public Unity.Mathematics.bool4 c1;  // 0x14
        public Unity.Mathematics.bool4 c2;  // 0x18

        // Methods
        // RVA: 0x03D4E5D0  token: 0x6000817
        public System.Void .ctor(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1, Unity.Mathematics.bool4 c2) { }
        // RVA: 0x03D7DAB0  token: 0x6000818
        public System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m30, System.Boolean m31, System.Boolean m32) { }
        // RVA: 0x03D7DB30  token: 0x6000819
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C60D54  token: 0x600081A
        public virtual System.Boolean Equals(Unity.Mathematics.bool4x3 rhs) { }
        // RVA: 0x09C60CE0  token: 0x600081B
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C60D94  token: 0x600081C
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C60DB8  token: 0x600081D
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000016  // size: 0x20
    public sealed struct bool4x4 : System.IEquatable`1
    {
        // Fields
        public Unity.Mathematics.bool4 c0;  // 0x10
        public Unity.Mathematics.bool4 c1;  // 0x14
        public Unity.Mathematics.bool4 c2;  // 0x18
        public Unity.Mathematics.bool4 c3;  // 0x1c

        // Methods
        // RVA: 0x03D517E0  token: 0x600081E
        public System.Void .ctor(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1, Unity.Mathematics.bool4 c2, Unity.Mathematics.bool4 c3) { }
        // RVA: 0x03D7DB80  token: 0x600081F
        public System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m23, System.Boolean m30, System.Boolean m31, System.Boolean m32, System.Boolean m33) { }
        // RVA: 0x03D7DC30  token: 0x6000820
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C61124  token: 0x6000821
        public virtual System.Boolean Equals(Unity.Mathematics.bool4x4 rhs) { }
        // RVA: 0x09C610B8  token: 0x6000822
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C61174  token: 0x6000823
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C61190  token: 0x6000824
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000017  // size: 0x20
    public sealed struct double2 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public System.Double x;  // 0x10
        public System.Double y;  // 0x18

        // Methods
        // RVA: 0x03D50BD0  token: 0x6000825
        public System.Void .ctor(System.Double x, System.Double y) { }
        // RVA: 0x03D50BC0  token: 0x6000826
        public System.Void .ctor(Unity.Mathematics.double2 xy) { }
        // RVA: 0x03D7DCE0  token: 0x6000827
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C61760  token: 0x6000828
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D253C0  token: 0x6000829
        public System.Void .ctor(Unity.Mathematics.bool2 v) { }
        // RVA: 0x03D7DD10  token: 0x600082A
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D7DCC0  token: 0x600082B
        public System.Void .ctor(Unity.Mathematics.int2 v) { }
        // RVA: 0x03D7DCF0  token: 0x600082C
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D7DD30  token: 0x600082D
        public System.Void .ctor(Unity.Mathematics.uint2 v) { }
        // RVA: 0x09C61724  token: 0x600082E
        public System.Void .ctor(Unity.Mathematics.half v) { }
        // RVA: 0x09C616E4  token: 0x600082F
        public System.Void .ctor(Unity.Mathematics.half2 v) { }
        // RVA: 0x03D7DD50  token: 0x6000830
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x03D7DC90  token: 0x6000831
        public System.Void .ctor(Unity.Mathematics.float2 v) { }
        // RVA: 0x03D79F00  token: 0x6000832
        public static Unity.Mathematics.double2 op_Implicit(System.Double v) { }
        // RVA: 0x03D79EA0  token: 0x6000833
        public static Unity.Mathematics.double2 op_Implicit(System.Int32 v) { }
        // RVA: 0x03D79E40  token: 0x6000834
        public static Unity.Mathematics.double2 op_Implicit(Unity.Mathematics.int2 v) { }
        // RVA: 0x03D79DE0  token: 0x6000835
        public static Unity.Mathematics.double2 op_Implicit(System.UInt32 v) { }
        // RVA: 0x03D79E70  token: 0x6000836
        public static Unity.Mathematics.double2 op_Implicit(Unity.Mathematics.uint2 v) { }
        // RVA: 0x03D79EC0  token: 0x6000837
        public static Unity.Mathematics.double2 op_Implicit(System.Single v) { }
        // RVA: 0x03D79E10  token: 0x6000838
        public static Unity.Mathematics.double2 op_Implicit(Unity.Mathematics.float2 v) { }
        // RVA: 0x03D7DD90  token: 0x6000839
        public static Unity.Mathematics.double2 op_Multiply(Unity.Mathematics.double2 lhs, Unity.Mathematics.double2 rhs) { }
        // RVA: 0x03D7DDE0  token: 0x600083A
        public static Unity.Mathematics.double2 op_Multiply(Unity.Mathematics.double2 lhs, System.Double rhs) { }
        // RVA: 0x03D7DDC0  token: 0x600083B
        public static Unity.Mathematics.double2 op_Multiply(System.Double lhs, Unity.Mathematics.double2 rhs) { }
        // RVA: 0x03D7DD60  token: 0x600083C
        public static Unity.Mathematics.double2 op_Addition(Unity.Mathematics.double2 lhs, Unity.Mathematics.double2 rhs) { }
        // RVA: 0x03D7DE20  token: 0x600083D
        public static Unity.Mathematics.double2 op_Subtraction(Unity.Mathematics.double2 lhs, Unity.Mathematics.double2 rhs) { }
        // RVA: 0x03D7DE00  token: 0x600083E
        public static Unity.Mathematics.double2 op_Subtraction(System.Double lhs, Unity.Mathematics.double2 rhs) { }
        // RVA: 0x09C61790  token: 0x600083F
        public static Unity.Mathematics.double2 op_Division(Unity.Mathematics.double2 lhs, Unity.Mathematics.double2 rhs) { }
        // RVA: 0x09C61774  token: 0x6000840
        public static Unity.Mathematics.double2 op_Division(System.Double lhs, Unity.Mathematics.double2 rhs) { }
        // RVA: 0x09C6180C  token: 0x6000841
        public static Unity.Mathematics.bool2 op_LessThan(Unity.Mathematics.double2 lhs, System.Double rhs) { }
        // RVA: 0x09C617E8  token: 0x6000842
        public static Unity.Mathematics.bool2 op_GreaterThanOrEqual(Unity.Mathematics.double2 lhs, Unity.Mathematics.double2 rhs) { }
        // RVA: 0x03D7DE50  token: 0x6000843
        public static Unity.Mathematics.double2 op_UnaryNegation(Unity.Mathematics.double2 val) { }
        // RVA: 0x09C617B4  token: 0x6000844
        public static Unity.Mathematics.bool2 op_Equality(Unity.Mathematics.double2 lhs, System.Double rhs) { }
        // RVA: 0x09C5AA84  token: 0x6000845
        public virtual System.Boolean Equals(Unity.Mathematics.double2 rhs) { }
        // RVA: 0x09C61560  token: 0x6000846
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C372A8  token: 0x6000847
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C61654  token: 0x6000848
        public virtual System.String ToString() { }
        // RVA: 0x09C615CC  token: 0x6000849
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000019  // size: 0x30
    public sealed struct double2x2 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.double2 c0;  // 0x10
        public Unity.Mathematics.double2 c1;  // 0x20
        public static readonly Unity.Mathematics.double2x2 identity;  // static @ 0x0

        // Methods
        // RVA: 0x03D553F0  token: 0x600084A
        public System.Void .ctor(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1) { }
        // RVA: 0x03D7DEC0  token: 0x600084B
        public System.Void .ctor(System.Double m00, System.Double m01, System.Double m10, System.Double m11) { }
        // RVA: 0x03D7DEA0  token: 0x600084C
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x04D254A8  token: 0x600084D
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D25428  token: 0x600084E
        public System.Void .ctor(Unity.Mathematics.bool2x2 v) { }
        // RVA: 0x03D7DE70  token: 0x600084F
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D7DFE0  token: 0x6000850
        public System.Void .ctor(Unity.Mathematics.int2x2 v) { }
        // RVA: 0x03D7DEE0  token: 0x6000851
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D7DF60  token: 0x6000852
        public System.Void .ctor(Unity.Mathematics.uint2x2 v) { }
        // RVA: 0x03D7DFB0  token: 0x6000853
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x03D7DF20  token: 0x6000854
        public System.Void .ctor(Unity.Mathematics.float2x2 v) { }
        // RVA: 0x09C61BC8  token: 0x6000855
        public static Unity.Mathematics.double2x2 op_Multiply(Unity.Mathematics.double2x2 lhs, System.Double rhs) { }
        // RVA: 0x09C61828  token: 0x6000856
        public virtual System.Boolean Equals(Unity.Mathematics.double2x2 rhs) { }
        // RVA: 0x09C61870  token: 0x6000857
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C618E4  token: 0x6000858
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C61908  token: 0x6000859
        public virtual System.String ToString() { }
        // RVA: 0x09C61A74  token: 0x600085A
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x03CE5E50  token: 0x600085B
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200001A  // size: 0x40
    public sealed struct double2x3 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.double2 c0;  // 0x10
        public Unity.Mathematics.double2 c1;  // 0x20
        public Unity.Mathematics.double2 c2;  // 0x30

        // Methods
        // RVA: 0x03D6B600  token: 0x600085C
        public System.Void .ctor(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1, Unity.Mathematics.double2 c2) { }
        // RVA: 0x03D7E190  token: 0x600085D
        public System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12) { }
        // RVA: 0x03D7E120  token: 0x600085E
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x04D25534  token: 0x600085F
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D25568  token: 0x6000860
        public System.Void .ctor(Unity.Mathematics.bool2x3 v) { }
        // RVA: 0x03D7E280  token: 0x6000861
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D7E030  token: 0x6000862
        public System.Void .ctor(Unity.Mathematics.int2x3 v) { }
        // RVA: 0x03D7E220  token: 0x6000863
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D7E0A0  token: 0x6000864
        public System.Void .ctor(Unity.Mathematics.uint2x3 v) { }
        // RVA: 0x03D7E140  token: 0x6000865
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x03D7E1C0  token: 0x6000866
        public System.Void .ctor(Unity.Mathematics.float2x3 v) { }
        // RVA: 0x09C61C24  token: 0x6000867
        public virtual System.Boolean Equals(Unity.Mathematics.double2x3 rhs) { }
        // RVA: 0x09C61C84  token: 0x6000868
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C61D00  token: 0x6000869
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C61EE4  token: 0x600086A
        public virtual System.String ToString() { }
        // RVA: 0x09C61D30  token: 0x600086B
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x200001B  // size: 0x50
    public sealed struct double2x4 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.double2 c0;  // 0x10
        public Unity.Mathematics.double2 c1;  // 0x20
        public Unity.Mathematics.double2 c2;  // 0x30
        public Unity.Mathematics.double2 c3;  // 0x40

        // Methods
        // RVA: 0x03D7E4A0  token: 0x600086C
        public System.Void .ctor(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1, Unity.Mathematics.double2 c2, Unity.Mathematics.double2 c3) { }
        // RVA: 0x03D7E4D0  token: 0x600086D
        public System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13) { }
        // RVA: 0x03D7E520  token: 0x600086E
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x04D256F8  token: 0x600086F
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D25618  token: 0x6000870
        public System.Void .ctor(Unity.Mathematics.bool2x4 v) { }
        // RVA: 0x03D7E3D0  token: 0x6000871
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D7E5C0  token: 0x6000872
        public System.Void .ctor(Unity.Mathematics.int2x4 v) { }
        // RVA: 0x03D7E540  token: 0x6000873
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D7E330  token: 0x6000874
        public System.Void .ctor(Unity.Mathematics.uint2x4 v) { }
        // RVA: 0x03D7E2D0  token: 0x6000875
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x03D7E430  token: 0x6000876
        public System.Void .ctor(Unity.Mathematics.float2x4 v) { }
        // RVA: 0x09C620C4  token: 0x6000877
        public virtual System.Boolean Equals(Unity.Mathematics.double2x4 rhs) { }
        // RVA: 0x09C62140  token: 0x6000878
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C621C4  token: 0x6000879
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C62410  token: 0x600087A
        public virtual System.String ToString() { }
        // RVA: 0x09C621FC  token: 0x600087B
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x200001C  // size: 0x28
    public sealed struct double3 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public System.Double x;  // 0x10
        public System.Double y;  // 0x18
        public System.Double z;  // 0x20
        public static readonly Unity.Mathematics.double3 zero;  // static @ 0x0

        // Properties
        Unity.Mathematics.double3 yzx { get; /* RVA: 0x03D7E7C0 */ }
        Unity.Mathematics.double3 zxy { get; /* RVA: 0x03D7E7E0 */ }
        System.Double Item { get; /* RVA: 0x03D7E7B0 */ }

        // Methods
        // RVA: 0x03D7E7A0  token: 0x600087C
        public System.Void .ctor(System.Double x, System.Double y, System.Double z) { }
        // RVA: 0x03D7E6D0  token: 0x600087D
        public System.Void .ctor(System.Double x, Unity.Mathematics.double2 yz) { }
        // RVA: 0x03D7E690  token: 0x600087E
        public System.Void .ctor(Unity.Mathematics.double2 xy, System.Double z) { }
        // RVA: 0x03D7E710  token: 0x600087F
        public System.Void .ctor(Unity.Mathematics.double3 xyz) { }
        // RVA: 0x03D7E730  token: 0x6000880
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x04D25778  token: 0x6000881
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D2573C  token: 0x6000882
        public System.Void .ctor(Unity.Mathematics.bool3 v) { }
        // RVA: 0x03D7E6F0  token: 0x6000883
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D7E6B0  token: 0x6000884
        public System.Void .ctor(Unity.Mathematics.int3 v) { }
        // RVA: 0x03D7E740  token: 0x6000885
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D7E770  token: 0x6000886
        public System.Void .ctor(Unity.Mathematics.uint3 v) { }
        // RVA: 0x09C6286C  token: 0x6000887
        public System.Void .ctor(Unity.Mathematics.half v) { }
        // RVA: 0x09C628BC  token: 0x6000888
        public System.Void .ctor(Unity.Mathematics.half3 v) { }
        // RVA: 0x03D7E670  token: 0x6000889
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x03D7E650  token: 0x600088A
        public System.Void .ctor(Unity.Mathematics.float3 v) { }
        // RVA: 0x03D7A0C0  token: 0x600088B
        public static Unity.Mathematics.double3 op_Implicit(System.Double v) { }
        // RVA: 0x03D7A180  token: 0x600088C
        public static Unity.Mathematics.double3 op_Implicit(System.Int32 v) { }
        // RVA: 0x03D7A020  token: 0x600088D
        public static Unity.Mathematics.double3 op_Implicit(Unity.Mathematics.int3 v) { }
        // RVA: 0x03D7A070  token: 0x600088E
        public static Unity.Mathematics.double3 op_Implicit(System.UInt32 v) { }
        // RVA: 0x03D7A0F0  token: 0x600088F
        public static Unity.Mathematics.double3 op_Implicit(Unity.Mathematics.uint3 v) { }
        // RVA: 0x03D79FF0  token: 0x6000890
        public static Unity.Mathematics.double3 op_Implicit(System.Single v) { }
        // RVA: 0x0337F9A0  token: 0x6000891
        public static Unity.Mathematics.double3 op_Implicit(Unity.Mathematics.float3 v) { }
        // RVA: 0x03D7E8A0  token: 0x6000892
        public static Unity.Mathematics.double3 op_Multiply(Unity.Mathematics.double3 lhs, Unity.Mathematics.double3 rhs) { }
        // RVA: 0x03D7E880  token: 0x6000893
        public static Unity.Mathematics.double3 op_Multiply(Unity.Mathematics.double3 lhs, System.Double rhs) { }
        // RVA: 0x03D7E860  token: 0x6000894
        public static Unity.Mathematics.double3 op_Multiply(System.Double lhs, Unity.Mathematics.double3 rhs) { }
        // RVA: 0x03D7E820  token: 0x6000895
        public static Unity.Mathematics.double3 op_Addition(Unity.Mathematics.double3 lhs, Unity.Mathematics.double3 rhs) { }
        // RVA: 0x03D7E800  token: 0x6000896
        public static Unity.Mathematics.double3 op_Addition(Unity.Mathematics.double3 lhs, System.Double rhs) { }
        // RVA: 0x03D7E900  token: 0x6000897
        public static Unity.Mathematics.double3 op_Subtraction(Unity.Mathematics.double3 lhs, Unity.Mathematics.double3 rhs) { }
        // RVA: 0x03D7E8E0  token: 0x6000898
        public static Unity.Mathematics.double3 op_Subtraction(Unity.Mathematics.double3 lhs, System.Double rhs) { }
        // RVA: 0x03D7E940  token: 0x6000899
        public static Unity.Mathematics.double3 op_Subtraction(System.Double lhs, Unity.Mathematics.double3 rhs) { }
        // RVA: 0x09C62910  token: 0x600089A
        public static Unity.Mathematics.double3 op_Division(Unity.Mathematics.double3 lhs, Unity.Mathematics.double3 rhs) { }
        // RVA: 0x09C62944  token: 0x600089B
        public static Unity.Mathematics.double3 op_Division(Unity.Mathematics.double3 lhs, System.Double rhs) { }
        // RVA: 0x09C62964  token: 0x600089C
        public static Unity.Mathematics.double3 op_Division(System.Double lhs, Unity.Mathematics.double3 rhs) { }
        // RVA: 0x09C62A4C  token: 0x600089D
        public static Unity.Mathematics.bool3 op_LessThan(Unity.Mathematics.double3 lhs, System.Double rhs) { }
        // RVA: 0x09C62A10  token: 0x600089E
        public static Unity.Mathematics.bool3 op_LessThanOrEqual(Unity.Mathematics.double3 lhs, Unity.Mathematics.double3 rhs) { }
        // RVA: 0x09C629D8  token: 0x600089F
        public static Unity.Mathematics.bool3 op_GreaterThanOrEqual(Unity.Mathematics.double3 lhs, Unity.Mathematics.double3 rhs) { }
        // RVA: 0x03D7E970  token: 0x60008A0
        public static Unity.Mathematics.double3 op_UnaryNegation(Unity.Mathematics.double3 val) { }
        // RVA: 0x09C62990  token: 0x60008A1
        public static Unity.Mathematics.bool3 op_Equality(Unity.Mathematics.double3 lhs, System.Double rhs) { }
        // RVA: 0x054F18F8  token: 0x60008A5
        public virtual System.Boolean Equals(Unity.Mathematics.double3 rhs) { }
        // RVA: 0x09C62660  token: 0x60008A6
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C626D4  token: 0x60008A7
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C627AC  token: 0x60008A8
        public virtual System.String ToString() { }
        // RVA: 0x09C626FC  token: 0x60008A9
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x200001E  // size: 0x40
    public sealed struct double3x2 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.double3 c0;  // 0x10
        public Unity.Mathematics.double3 c1;  // 0x28

        // Methods
        // RVA: 0x03D6B590  token: 0x60008AA
        public System.Void .ctor(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1) { }
        // RVA: 0x03D7E9E0  token: 0x60008AB
        public System.Void .ctor(System.Double m00, System.Double m01, System.Double m10, System.Double m11, System.Double m20, System.Double m21) { }
        // RVA: 0x03D7EA80  token: 0x60008AC
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x04D25C14  token: 0x60008AD
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C62EB0  token: 0x60008AE
        public System.Void .ctor(Unity.Mathematics.bool3x2 v) { }
        // RVA: 0x03D7EAB0  token: 0x60008AF
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x04D25CE8  token: 0x60008B0
        public System.Void .ctor(Unity.Mathematics.int3x2 v) { }
        // RVA: 0x03D7EA20  token: 0x60008B1
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x04D25A1C  token: 0x60008B2
        public System.Void .ctor(Unity.Mathematics.uint3x2 v) { }
        // RVA: 0x03D7E9A0  token: 0x60008B3
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D25A94  token: 0x60008B4
        public System.Void .ctor(Unity.Mathematics.float3x2 v) { }
        // RVA: 0x09C3120C  token: 0x60008B5
        public static Unity.Mathematics.double3x2 op_Implicit(System.Int32 v) { }
        // RVA: 0x09C310B8  token: 0x60008B6
        public static Unity.Mathematics.double3x2 op_Implicit(Unity.Mathematics.float3x2 v) { }
        // RVA: 0x09C6310C  token: 0x60008B7
        public static Unity.Mathematics.double3x2 op_Multiply(Unity.Mathematics.double3x2 lhs, System.Double rhs) { }
        // RVA: 0x09C62FB4  token: 0x60008B8
        public static Unity.Mathematics.double3x2 op_Addition(Unity.Mathematics.double3x2 lhs, Unity.Mathematics.double3x2 rhs) { }
        // RVA: 0x09C63190  token: 0x60008B9
        public static Unity.Mathematics.double3x2 op_Subtraction(Unity.Mathematics.double3x2 lhs, Unity.Mathematics.double3x2 rhs) { }
        // RVA: 0x09C63078  token: 0x60008BA
        public static Unity.Mathematics.double3x2 op_Division(Unity.Mathematics.double3x2 lhs, System.Double rhs) { }
        // RVA: 0x05538B4C  token: 0x60008BB
        public virtual System.Boolean Equals(Unity.Mathematics.double3x2 rhs) { }
        // RVA: 0x09C62A70  token: 0x60008BC
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C62AEC  token: 0x60008BD
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C62CD0  token: 0x60008BE
        public virtual System.String ToString() { }
        // RVA: 0x09C62B1C  token: 0x60008BF
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x200001F  // size: 0x58
    public sealed struct double3x3 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.double3 c0;  // 0x10
        public Unity.Mathematics.double3 c1;  // 0x28
        public Unity.Mathematics.double3 c2;  // 0x40
        public static readonly Unity.Mathematics.double3x3 identity;  // static @ 0x0

        // Properties
        Unity.Mathematics.double3& Item { get; /* RVA: 0x03D7ED40 */ }

        // Methods
        // RVA: 0x03D7EB60  token: 0x60008C0
        public System.Void .ctor(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1, Unity.Mathematics.double3 c2) { }
        // RVA: 0x03D7ECE0  token: 0x60008C1
        public System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12, System.Double m20, System.Double m21, System.Double m22) { }
        // RVA: 0x03D7EBA0  token: 0x60008C2
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x04D260C8  token: 0x60008C3
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C6388C  token: 0x60008C4
        public System.Void .ctor(Unity.Mathematics.bool3x3 v) { }
        // RVA: 0x03D7EC70  token: 0x60008C5
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x04D26020  token: 0x60008C6
        public System.Void .ctor(Unity.Mathematics.int3x3 v) { }
        // RVA: 0x03D7EBE0  token: 0x60008C7
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x04D25F78  token: 0x60008C8
        public System.Void .ctor(Unity.Mathematics.uint3x3 v) { }
        // RVA: 0x03D7EB00  token: 0x60008C9
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D25D60  token: 0x60008CA
        public System.Void .ctor(Unity.Mathematics.float3x3 v) { }
        // RVA: 0x09C639F8  token: 0x60008CB
        public static Unity.Mathematics.double3x3 op_Multiply(Unity.Mathematics.double3x3 lhs, System.Double rhs) { }
        // RVA: 0x09C632E8  token: 0x60008CD
        public virtual System.Boolean Equals(Unity.Mathematics.double3x3 rhs) { }
        // RVA: 0x09C63254  token: 0x60008CE
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C6337C  token: 0x60008CF
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C633C0  token: 0x60008D0
        public virtual System.String ToString() { }
        // RVA: 0x09C63648  token: 0x60008D1
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x03B5BB30  token: 0x60008D2
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000020  // size: 0x70
    public sealed struct double3x4 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.double3 c0;  // 0x10
        public Unity.Mathematics.double3 c1;  // 0x28
        public Unity.Mathematics.double3 c2;  // 0x40
        public Unity.Mathematics.double3 c3;  // 0x58

        // Properties
        Unity.Mathematics.double3& Item { get; /* RVA: 0x03D7ED40 */ }

        // Methods
        // RVA: 0x03D7ED50  token: 0x60008D3
        public System.Void .ctor(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1, Unity.Mathematics.double3 c2, Unity.Mathematics.double3 c3) { }
        // RVA: 0x03D7EDA0  token: 0x60008D4
        public System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13, System.Double m20, System.Double m21, System.Double m22, System.Double m23) { }
        // RVA: 0x03D7EF60  token: 0x60008D5
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x04D26584  token: 0x60008D6
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C64294  token: 0x60008D7
        public System.Void .ctor(Unity.Mathematics.bool3x4 v) { }
        // RVA: 0x03D7EE20  token: 0x60008D8
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x04D264A8  token: 0x60008D9
        public System.Void .ctor(Unity.Mathematics.int3x4 v) { }
        // RVA: 0x03D7EEA0  token: 0x60008DA
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x04D263CC  token: 0x60008DB
        public System.Void .ctor(Unity.Mathematics.uint3x4 v) { }
        // RVA: 0x03D7EFB0  token: 0x60008DC
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D26700  token: 0x60008DD
        public System.Void .ctor(Unity.Mathematics.float3x4 v) { }
        // RVA: 0x09C31424  token: 0x60008DE
        public static Unity.Mathematics.double3x4 op_Implicit(System.Int32 v) { }
        // RVA: 0x09C63ABC  token: 0x60008E0
        public virtual System.Boolean Equals(Unity.Mathematics.double3x4 rhs) { }
        // RVA: 0x09C63BA4  token: 0x60008E1
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C63C44  token: 0x60008E2
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C63F64  token: 0x60008E3
        public virtual System.String ToString() { }
        // RVA: 0x09C63C90  token: 0x60008E4
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000021  // size: 0x30
    public sealed struct double4 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public System.Double x;  // 0x10
        public System.Double y;  // 0x18
        public System.Double z;  // 0x20
        public System.Double w;  // 0x28
        public static readonly Unity.Mathematics.double4 zero;  // static @ 0x0

        // Properties
        Unity.Mathematics.double3 xyz { get; /* RVA: 0x03D7F230 */ set; /* RVA: 0x03D7E710 */ }
        System.Double Item { get; /* RVA: 0x03D7E7B0 */ set; /* RVA: 0x03D7F3E0 */ }

        // Methods
        // RVA: 0x03D7F0F0  token: 0x60008E5
        public System.Void .ctor(System.Double x, System.Double y, System.Double z, System.Double w) { }
        // RVA: 0x03D7F070  token: 0x60008E6
        public System.Void .ctor(System.Double x, System.Double y, Unity.Mathematics.double2 zw) { }
        // RVA: 0x03D7F090  token: 0x60008E7
        public System.Void .ctor(System.Double x, Unity.Mathematics.double2 yz, System.Double w) { }
        // RVA: 0x03D7F0D0  token: 0x60008E8
        public System.Void .ctor(System.Double x, Unity.Mathematics.double3 yzw) { }
        // RVA: 0x03D7F1D0  token: 0x60008E9
        public System.Void .ctor(Unity.Mathematics.double2 xy, System.Double z, System.Double w) { }
        // RVA: 0x03D7F0B0  token: 0x60008EA
        public System.Void .ctor(Unity.Mathematics.double2 xy, Unity.Mathematics.double2 zw) { }
        // RVA: 0x03D7F1B0  token: 0x60008EB
        public System.Void .ctor(Unity.Mathematics.double3 xyz, System.Double w) { }
        // RVA: 0x03D7F050  token: 0x60008EC
        public System.Void .ctor(Unity.Mathematics.double4 xyzw) { }
        // RVA: 0x03D7F1F0  token: 0x60008ED
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x04D26850  token: 0x60008EE
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D268F8  token: 0x60008EF
        public System.Void .ctor(Unity.Mathematics.bool4 v) { }
        // RVA: 0x03D7F110  token: 0x60008F0
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D7F190  token: 0x60008F1
        public System.Void .ctor(Unity.Mathematics.int4 v) { }
        // RVA: 0x03D7F200  token: 0x60008F2
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D7F140  token: 0x60008F3
        public System.Void .ctor(Unity.Mathematics.uint4 v) { }
        // RVA: 0x04D26894  token: 0x60008F4
        public System.Void .ctor(Unity.Mathematics.half v) { }
        // RVA: 0x04D267DC  token: 0x60008F5
        public System.Void .ctor(Unity.Mathematics.half4 v) { }
        // RVA: 0x03D7F030  token: 0x60008F6
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x03D7F180  token: 0x60008F7
        public System.Void .ctor(Unity.Mathematics.float4 v) { }
        // RVA: 0x03D7A2D0  token: 0x60008F8
        public static Unity.Mathematics.double4 op_Implicit(System.Double v) { }
        // RVA: 0x03D7A330  token: 0x60008F9
        public static Unity.Mathematics.double4 op_Implicit(System.Int32 v) { }
        // RVA: 0x09C31698  token: 0x60008FA
        public static Unity.Mathematics.double4 op_Implicit(Unity.Mathematics.int4 v) { }
        // RVA: 0x03D7A3F0  token: 0x60008FB
        public static Unity.Mathematics.double4 op_Implicit(System.UInt32 v) { }
        // RVA: 0x09C316C0  token: 0x60008FC
        public static Unity.Mathematics.double4 op_Implicit(Unity.Mathematics.uint4 v) { }
        // RVA: 0x03D7A2E0  token: 0x60008FD
        public static Unity.Mathematics.double4 op_Implicit(System.Single v) { }
        // RVA: 0x09C31654  token: 0x60008FE
        public static Unity.Mathematics.double4 op_Implicit(Unity.Mathematics.float4 v) { }
        // RVA: 0x03D7F2C0  token: 0x60008FF
        public static Unity.Mathematics.double4 op_Multiply(Unity.Mathematics.double4 lhs, Unity.Mathematics.double4 rhs) { }
        // RVA: 0x03D7F2A0  token: 0x6000900
        public static Unity.Mathematics.double4 op_Multiply(Unity.Mathematics.double4 lhs, System.Double rhs) { }
        // RVA: 0x03D7F310  token: 0x6000901
        public static Unity.Mathematics.double4 op_Multiply(System.Double lhs, Unity.Mathematics.double4 rhs) { }
        // RVA: 0x03D7F250  token: 0x6000902
        public static Unity.Mathematics.double4 op_Addition(Unity.Mathematics.double4 lhs, Unity.Mathematics.double4 rhs) { }
        // RVA: 0x03D7F370  token: 0x6000903
        public static Unity.Mathematics.double4 op_Subtraction(Unity.Mathematics.double4 lhs, Unity.Mathematics.double4 rhs) { }
        // RVA: 0x03D7F330  token: 0x6000904
        public static Unity.Mathematics.double4 op_Subtraction(System.Double lhs, Unity.Mathematics.double4 rhs) { }
        // RVA: 0x09C6480C  token: 0x6000905
        public static Unity.Mathematics.double4 op_Division(Unity.Mathematics.double4 lhs, Unity.Mathematics.double4 rhs) { }
        // RVA: 0x09C64850  token: 0x6000906
        public static Unity.Mathematics.double4 op_Division(System.Double lhs, Unity.Mathematics.double4 rhs) { }
        // RVA: 0x09C64934  token: 0x6000907
        public static Unity.Mathematics.bool4 op_LessThan(Unity.Mathematics.double4 lhs, System.Double rhs) { }
        // RVA: 0x09C648EC  token: 0x6000908
        public static Unity.Mathematics.bool4 op_GreaterThanOrEqual(Unity.Mathematics.double4 lhs, Unity.Mathematics.double4 rhs) { }
        // RVA: 0x03D7F3C0  token: 0x6000909
        public static Unity.Mathematics.double4 op_UnaryNegation(Unity.Mathematics.double4 val) { }
        // RVA: 0x09C64888  token: 0x600090A
        public static Unity.Mathematics.bool4 op_Equality(Unity.Mathematics.double4 lhs, System.Double rhs) { }
        // RVA: 0x09C644E0  token: 0x600090F
        public virtual System.Boolean Equals(Unity.Mathematics.double4 rhs) { }
        // RVA: 0x09C6446C  token: 0x6000910
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C64528  token: 0x6000911
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C6454C  token: 0x6000912
        public virtual System.String ToString() { }
        // RVA: 0x09C646B8  token: 0x6000913
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000023  // size: 0x50
    public sealed struct double4x2 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.double4 c0;  // 0x10
        public Unity.Mathematics.double4 c1;  // 0x30

        // Methods
        // RVA: 0x03D7F4B0  token: 0x6000914
        public System.Void .ctor(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1) { }
        // RVA: 0x03D7F3F0  token: 0x6000915
        public System.Void .ctor(System.Double m00, System.Double m01, System.Double m10, System.Double m11, System.Double m20, System.Double m21, System.Double m30, System.Double m31) { }
        // RVA: 0x03D7F440  token: 0x6000916
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x04D26DF4  token: 0x6000917
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D26D50  token: 0x6000918
        public System.Void .ctor(Unity.Mathematics.bool4x2 v) { }
        // RVA: 0x03D7F4D0  token: 0x6000919
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x09C64EE4  token: 0x600091A
        public System.Void .ctor(Unity.Mathematics.int4x2 v) { }
        // RVA: 0x04D26CA8  token: 0x600091B
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x09C64F48  token: 0x600091C
        public System.Void .ctor(Unity.Mathematics.uint4x2 v) { }
        // RVA: 0x03D7F470  token: 0x600091D
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x09C64FAC  token: 0x600091E
        public System.Void .ctor(Unity.Mathematics.float4x2 v) { }
        // RVA: 0x09C649E4  token: 0x600091F
        public virtual System.Boolean Equals(Unity.Mathematics.double4x2 rhs) { }
        // RVA: 0x09C64960  token: 0x6000920
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C64A48  token: 0x6000921
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C64C94  token: 0x6000922
        public virtual System.String ToString() { }
        // RVA: 0x09C64A80  token: 0x6000923
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000024  // size: 0x70
    public sealed struct double4x3 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.double4 c0;  // 0x10
        public Unity.Mathematics.double4 c1;  // 0x30
        public Unity.Mathematics.double4 c2;  // 0x50

        // Methods
        // RVA: 0x03D7F6D0  token: 0x6000924
        public System.Void .ctor(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1, Unity.Mathematics.double4 c2) { }
        // RVA: 0x03D7F5D0  token: 0x6000925
        public System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12, System.Double m20, System.Double m21, System.Double m22, System.Double m30, System.Double m31, System.Double m32) { }
        // RVA: 0x03D7F520  token: 0x6000926
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x04D271D8  token: 0x6000927
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D27100  token: 0x6000928
        public System.Void .ctor(Unity.Mathematics.bool4x3 v) { }
        // RVA: 0x03D7F660  token: 0x6000929
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x09C65810  token: 0x600092A
        public System.Void .ctor(Unity.Mathematics.int4x3 v) { }
        // RVA: 0x04D270A4  token: 0x600092B
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x09C658A0  token: 0x600092C
        public System.Void .ctor(Unity.Mathematics.uint4x3 v) { }
        // RVA: 0x03D7F570  token: 0x600092D
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x09C65780  token: 0x600092E
        public System.Void .ctor(Unity.Mathematics.float4x3 v) { }
        // RVA: 0x09C318F8  token: 0x600092F
        public static Unity.Mathematics.double4x3 op_Implicit(System.Int32 v) { }
        // RVA: 0x09C319FC  token: 0x6000930
        public static Unity.Mathematics.double4x3 op_Implicit(Unity.Mathematics.float4x3 v) { }
        // RVA: 0x09C65930  token: 0x6000931
        public static Unity.Mathematics.double4x3 op_Multiply(Unity.Mathematics.double4x3 lhs, Unity.Mathematics.double4x3 rhs) { }
        // RVA: 0x09C65010  token: 0x6000932
        public virtual System.Boolean Equals(Unity.Mathematics.double4x3 rhs) { }
        // RVA: 0x09C65090  token: 0x6000933
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C65130  token: 0x6000934
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C65450  token: 0x6000935
        public virtual System.String ToString() { }
        // RVA: 0x09C6517C  token: 0x6000936
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000025  // size: 0x90
    public sealed struct double4x4 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.double4 c0;  // 0x10
        public Unity.Mathematics.double4 c1;  // 0x30
        public Unity.Mathematics.double4 c2;  // 0x50
        public Unity.Mathematics.double4 c3;  // 0x70
        public static readonly Unity.Mathematics.double4x4 identity;  // static @ 0x0
        public static readonly Unity.Mathematics.double4x4 zero;  // static @ 0x80

        // Methods
        // RVA: 0x03D7F7E0  token: 0x6000937
        public System.Void .ctor(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1, Unity.Mathematics.double4 c2, Unity.Mathematics.double4 c3) { }
        // RVA: 0x03A37140  token: 0x6000938
        public System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13, System.Double m20, System.Double m21, System.Double m22, System.Double m23, System.Double m30, System.Double m31, System.Double m32, System.Double m33) { }
        // RVA: 0x03D7F780  token: 0x6000939
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x04D27390  token: 0x600093A
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D27470  token: 0x600093B
        public System.Void .ctor(Unity.Mathematics.bool4x4 v) { }
        // RVA: 0x03D7F830  token: 0x600093C
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x09C664FC  token: 0x600093D
        public System.Void .ctor(Unity.Mathematics.int4x4 v) { }
        // RVA: 0x04D273F8  token: 0x600093E
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x09C66448  token: 0x600093F
        public System.Void .ctor(Unity.Mathematics.uint4x4 v) { }
        // RVA: 0x03D7F710  token: 0x6000940
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x09C66394  token: 0x6000941
        public System.Void .ctor(Unity.Mathematics.float4x4 v) { }
        // RVA: 0x09C31BA4  token: 0x6000942
        public static Unity.Mathematics.double4x4 op_Implicit(Unity.Mathematics.float4x4 v) { }
        // RVA: 0x09C65A38  token: 0x6000943
        public virtual System.Boolean Equals(Unity.Mathematics.double4x4 rhs) { }
        // RVA: 0x09C65ADC  token: 0x6000944
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C65B94  token: 0x6000945
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C65F84  token: 0x6000946
        public virtual System.String ToString() { }
        // RVA: 0x09C65BF0  token: 0x6000947
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x03A37010  token: 0x6000948
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000026  // size: 0x18
    public sealed struct float2 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public System.Single x;  // 0x10
        public System.Single y;  // 0x14
        public static readonly Unity.Mathematics.float2 zero;  // static @ 0x0

        // Properties
        Unity.Mathematics.float4 xyxy { get; /* RVA: 0x03D7F9D0 */ }
        Unity.Mathematics.float2 xy { get; /* RVA: 0x03D51540 */ }
        Unity.Mathematics.float2 yx { get; /* RVA: 0x03D7F9F0 */ }

        // Methods
        // RVA: 0x03D50430  token: 0x6000949
        public System.Void .ctor(System.Single x, System.Single y) { }
        // RVA: 0x03D7F900  token: 0x600094A
        public System.Void .ctor(Unity.Mathematics.float2 xy) { }
        // RVA: 0x03D7F8C0  token: 0x600094B
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x09C6676C  token: 0x600094C
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D27638  token: 0x600094D
        public System.Void .ctor(Unity.Mathematics.bool2 v) { }
        // RVA: 0x03D7F970  token: 0x600094E
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D7F950  token: 0x600094F
        public System.Void .ctor(Unity.Mathematics.int2 v) { }
        // RVA: 0x03D7F920  token: 0x6000950
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D7F8D0  token: 0x6000951
        public System.Void .ctor(Unity.Mathematics.uint2 v) { }
        // RVA: 0x09C66788  token: 0x6000952
        public System.Void .ctor(Unity.Mathematics.half v) { }
        // RVA: 0x09C667B4  token: 0x6000953
        public System.Void .ctor(Unity.Mathematics.half2 v) { }
        // RVA: 0x03D7F990  token: 0x6000954
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x03D7F9B0  token: 0x6000955
        public System.Void .ctor(Unity.Mathematics.double2 v) { }
        // RVA: 0x03D543C0  token: 0x6000956
        public static Unity.Mathematics.float2 op_Implicit(System.Single v) { }
        // RVA: 0x03D7A730  token: 0x6000957
        public static Unity.Mathematics.float2 op_Implicit(System.Int32 v) { }
        // RVA: 0x03D7A750  token: 0x6000958
        public static Unity.Mathematics.float2 op_Implicit(Unity.Mathematics.int2 v) { }
        // RVA: 0x03D7A7A0  token: 0x6000959
        public static Unity.Mathematics.float2 op_Implicit(System.UInt32 v) { }
        // RVA: 0x03D7A770  token: 0x600095A
        public static Unity.Mathematics.float2 op_Implicit(Unity.Mathematics.uint2 v) { }
        // RVA: 0x03D7A7D0  token: 0x600095B
        public static Unity.Mathematics.float2 op_Explicit(System.Double v) { }
        // RVA: 0x03D7A700  token: 0x600095C
        public static Unity.Mathematics.float2 op_Explicit(Unity.Mathematics.double2 v) { }
        // RVA: 0x03D734A0  token: 0x600095D
        public static Unity.Mathematics.float2 op_Multiply(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs) { }
        // RVA: 0x03D73470  token: 0x600095E
        public static Unity.Mathematics.float2 op_Multiply(Unity.Mathematics.float2 lhs, System.Single rhs) { }
        // RVA: 0x03D7FA60  token: 0x600095F
        public static Unity.Mathematics.float2 op_Multiply(System.Single lhs, Unity.Mathematics.float2 rhs) { }
        // RVA: 0x03D73400  token: 0x6000960
        public static Unity.Mathematics.float2 op_Addition(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs) { }
        // RVA: 0x03D73440  token: 0x6000961
        public static Unity.Mathematics.float2 op_Addition(Unity.Mathematics.float2 lhs, System.Single rhs) { }
        // RVA: 0x03D73510  token: 0x6000962
        public static Unity.Mathematics.float2 op_Subtraction(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs) { }
        // RVA: 0x03D734E0  token: 0x6000963
        public static Unity.Mathematics.float2 op_Subtraction(Unity.Mathematics.float2 lhs, System.Single rhs) { }
        // RVA: 0x03D7FA90  token: 0x6000964
        public static Unity.Mathematics.float2 op_Subtraction(System.Single lhs, Unity.Mathematics.float2 rhs) { }
        // RVA: 0x0950B3B4  token: 0x6000965
        public static Unity.Mathematics.float2 op_Division(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs) { }
        // RVA: 0x0950B8A0  token: 0x6000966
        public static Unity.Mathematics.float2 op_Division(Unity.Mathematics.float2 lhs, System.Single rhs) { }
        // RVA: 0x09C667E4  token: 0x6000967
        public static Unity.Mathematics.float2 op_Division(System.Single lhs, Unity.Mathematics.float2 rhs) { }
        // RVA: 0x03D7FA10  token: 0x6000968
        public static Unity.Mathematics.float2 op_Modulus(Unity.Mathematics.float2 lhs, System.Single rhs) { }
        // RVA: 0x09C668AC  token: 0x6000969
        public static Unity.Mathematics.bool2 op_LessThan(Unity.Mathematics.float2 lhs, System.Single rhs) { }
        // RVA: 0x09C66874  token: 0x600096A
        public static Unity.Mathematics.bool2 op_LessThanOrEqual(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs) { }
        // RVA: 0x09C6683C  token: 0x600096B
        public static Unity.Mathematics.bool2 op_GreaterThanOrEqual(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs) { }
        // RVA: 0x03D7FAB0  token: 0x600096C
        public static Unity.Mathematics.float2 op_UnaryNegation(Unity.Mathematics.float2 val) { }
        // RVA: 0x09C66804  token: 0x600096D
        public static Unity.Mathematics.bool2 op_Equality(Unity.Mathematics.float2 lhs, System.Single rhs) { }
        // RVA: 0x0950B3E8  token: 0x6000971
        public virtual System.Boolean Equals(Unity.Mathematics.float2 rhs) { }
        // RVA: 0x09C665B0  token: 0x6000972
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C66620  token: 0x6000973
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C666DC  token: 0x6000974
        public virtual System.String ToString() { }
        // RVA: 0x09C66654  token: 0x6000975
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x03D730E0  token: 0x6000976
        public static UnityEngine.Vector2 op_Implicit(Unity.Mathematics.float2 v) { }
        // RVA: 0x03D730E0  token: 0x6000977
        public static Unity.Mathematics.float2 op_Implicit(UnityEngine.Vector2 v) { }

    }

    // TypeToken: 0x2000028  // size: 0x20
    public sealed struct float2x2 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.float2 c0;  // 0x10
        public Unity.Mathematics.float2 c1;  // 0x18
        public static readonly Unity.Mathematics.float2x2 identity;  // static @ 0x0

        // Methods
        // RVA: 0x03D4EA10  token: 0x6000978
        public System.Void .ctor(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1) { }
        // RVA: 0x03D7FBC0  token: 0x6000979
        public System.Void .ctor(System.Single m00, System.Single m01, System.Single m10, System.Single m11) { }
        // RVA: 0x03D7FB70  token: 0x600097A
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D276F0  token: 0x600097B
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C66C54  token: 0x600097C
        public System.Void .ctor(Unity.Mathematics.bool2x2 v) { }
        // RVA: 0x03D7FB90  token: 0x600097D
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D7FC20  token: 0x600097E
        public System.Void .ctor(Unity.Mathematics.int2x2 v) { }
        // RVA: 0x03D7FC60  token: 0x600097F
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D7FAE0  token: 0x6000980
        public System.Void .ctor(Unity.Mathematics.uint2x2 v) { }
        // RVA: 0x03D7FB40  token: 0x6000981
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x03D7FBE0  token: 0x6000982
        public System.Void .ctor(Unity.Mathematics.double2x2 v) { }
        // RVA: 0x09C66CD0  token: 0x6000983
        public static Unity.Mathematics.float2x2 op_Multiply(Unity.Mathematics.float2x2 lhs, System.Single rhs) { }
        // RVA: 0x09C668D0  token: 0x6000984
        public virtual System.Boolean Equals(Unity.Mathematics.float2x2 rhs) { }
        // RVA: 0x09C6690C  token: 0x6000985
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C66978  token: 0x6000986
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C66AE8  token: 0x6000987
        public virtual System.String ToString() { }
        // RVA: 0x09C66994  token: 0x6000988
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x03CF6AF0  token: 0x6000989
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000029  // size: 0x28
    public sealed struct float2x3 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.float2 c0;  // 0x10
        public Unity.Mathematics.float2 c1;  // 0x18
        public Unity.Mathematics.float2 c2;  // 0x20

        // Methods
        // RVA: 0x03D54CF0  token: 0x600098A
        public System.Void .ctor(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1, Unity.Mathematics.float2 c2) { }
        // RVA: 0x03D7FE00  token: 0x600098B
        public System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12) { }
        // RVA: 0x03D7FE80  token: 0x600098C
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D278AC  token: 0x600098D
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C671E8  token: 0x600098E
        public System.Void .ctor(Unity.Mathematics.bool2x3 v) { }
        // RVA: 0x03D7FF10  token: 0x600098F
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D7FDA0  token: 0x6000990
        public System.Void .ctor(Unity.Mathematics.int2x3 v) { }
        // RVA: 0x03D7FEA0  token: 0x6000991
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D7FD10  token: 0x6000992
        public System.Void .ctor(Unity.Mathematics.uint2x3 v) { }
        // RVA: 0x03D7FE30  token: 0x6000993
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x03D7FCB0  token: 0x6000994
        public System.Void .ctor(Unity.Mathematics.double2x3 v) { }
        // RVA: 0x09C66DB0  token: 0x6000995
        public virtual System.Boolean Equals(Unity.Mathematics.float2x3 rhs) { }
        // RVA: 0x09C66D3C  token: 0x6000996
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C66E2C  token: 0x6000997
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C66E54  token: 0x6000998
        public virtual System.String ToString() { }
        // RVA: 0x09C67034  token: 0x6000999
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x200002A  // size: 0x30
    public sealed struct float2x4 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.float2 c0;  // 0x10
        public Unity.Mathematics.float2 c1;  // 0x18
        public Unity.Mathematics.float2 c2;  // 0x20
        public Unity.Mathematics.float2 c3;  // 0x28

        // Methods
        // RVA: 0x03D548D0  token: 0x600099A
        public System.Void .ctor(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1, Unity.Mathematics.float2 c2, Unity.Mathematics.float2 c3) { }
        // RVA: 0x03D7FF60  token: 0x600099B
        public System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13) { }
        // RVA: 0x03D80020  token: 0x600099C
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D27A2C  token: 0x600099D
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C67824  token: 0x600099E
        public System.Void .ctor(Unity.Mathematics.bool2x4 v) { }
        // RVA: 0x03D80290  token: 0x600099F
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D80040  token: 0x60009A0
        public System.Void .ctor(Unity.Mathematics.int2x4 v) { }
        // RVA: 0x03D801F0  token: 0x60009A1
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D800C0  token: 0x60009A2
        public System.Void .ctor(Unity.Mathematics.uint2x4 v) { }
        // RVA: 0x03D80180  token: 0x60009A3
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x03D7FFB0  token: 0x60009A4
        public System.Void .ctor(Unity.Mathematics.double2x4 v) { }
        // RVA: 0x09C672A0  token: 0x60009A5
        public virtual System.Boolean Equals(Unity.Mathematics.float2x4 rhs) { }
        // RVA: 0x09C67328  token: 0x60009A6
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C6739C  token: 0x60009A7
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C675D4  token: 0x60009A8
        public virtual System.String ToString() { }
        // RVA: 0x09C673C0  token: 0x60009A9
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x200002B  // size: 0x1C
    public sealed struct float3 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public System.Single x;  // 0x10
        public System.Single y;  // 0x14
        public System.Single z;  // 0x18
        public static readonly Unity.Mathematics.float3 zero;  // static @ 0x0

        // Properties
        Unity.Mathematics.float4 xxxx { get; /* RVA: 0x03D804B0 */ }
        Unity.Mathematics.float4 xxxy { get; /* RVA: 0x03D804D0 */ }
        Unity.Mathematics.float4 xxxz { get; /* RVA: 0x03D804F0 */ }
        Unity.Mathematics.float4 xxyx { get; /* RVA: 0x03D80530 */ }
        Unity.Mathematics.float4 xxyy { get; /* RVA: 0x03D80550 */ }
        Unity.Mathematics.float4 xxyz { get; /* RVA: 0x03D80570 */ }
        Unity.Mathematics.float4 xxzx { get; /* RVA: 0x03D805B0 */ }
        Unity.Mathematics.float4 xxzy { get; /* RVA: 0x03D805D0 */ }
        Unity.Mathematics.float4 xxzz { get; /* RVA: 0x03D805F0 */ }
        Unity.Mathematics.float4 xyxx { get; /* RVA: 0x03D80630 */ }
        Unity.Mathematics.float4 xyxy { get; /* RVA: 0x03D7F9D0 */ }
        Unity.Mathematics.float4 xyxz { get; /* RVA: 0x03D80650 */ }
        Unity.Mathematics.float4 xyyx { get; /* RVA: 0x03D80690 */ }
        Unity.Mathematics.float4 xyyy { get; /* RVA: 0x03D806B0 */ }
        Unity.Mathematics.float4 xyyz { get; /* RVA: 0x03D806D0 */ }
        Unity.Mathematics.float4 xyzx { get; /* RVA: 0x028B4690 */ }
        Unity.Mathematics.float4 xyzy { get; /* RVA: 0x03D806F0 */ }
        Unity.Mathematics.float4 xyzz { get; /* RVA: 0x03D80710 */ }
        Unity.Mathematics.float4 xzxx { get; /* RVA: 0x03D80750 */ }
        Unity.Mathematics.float4 xzxy { get; /* RVA: 0x03D80770 */ }
        Unity.Mathematics.float4 xzxz { get; /* RVA: 0x03D80790 */ }
        Unity.Mathematics.float4 xzyx { get; /* RVA: 0x03D807D0 */ }
        Unity.Mathematics.float4 xzyy { get; /* RVA: 0x03D807F0 */ }
        Unity.Mathematics.float4 xzyz { get; /* RVA: 0x03D80810 */ }
        Unity.Mathematics.float4 xzzx { get; /* RVA: 0x03D80850 */ }
        Unity.Mathematics.float4 xzzy { get; /* RVA: 0x03D80870 */ }
        Unity.Mathematics.float4 xzzz { get; /* RVA: 0x03D80890 */ }
        Unity.Mathematics.float4 yxxx { get; /* RVA: 0x03D808D0 */ }
        Unity.Mathematics.float4 yxxy { get; /* RVA: 0x03D808F0 */ }
        Unity.Mathematics.float4 yxxz { get; /* RVA: 0x03D80910 */ }
        Unity.Mathematics.float4 yxyx { get; /* RVA: 0x03D80950 */ }
        Unity.Mathematics.float4 yxyy { get; /* RVA: 0x03D80970 */ }
        Unity.Mathematics.float4 yxyz { get; /* RVA: 0x03D80990 */ }
        Unity.Mathematics.float4 yxzx { get; /* RVA: 0x03D809D0 */ }
        Unity.Mathematics.float4 yxzy { get; /* RVA: 0x03D809F0 */ }
        Unity.Mathematics.float4 yxzz { get; /* RVA: 0x03D80A10 */ }
        Unity.Mathematics.float4 yyxx { get; /* RVA: 0x03D80A70 */ }
        Unity.Mathematics.float4 yyxy { get; /* RVA: 0x03D80A90 */ }
        Unity.Mathematics.float4 yyxz { get; /* RVA: 0x03D80AB0 */ }
        Unity.Mathematics.float4 yyyx { get; /* RVA: 0x03D80AE0 */ }
        Unity.Mathematics.float4 yyyy { get; /* RVA: 0x03D80B00 */ }
        Unity.Mathematics.float4 yyyz { get; /* RVA: 0x03D80B20 */ }
        Unity.Mathematics.float4 yyzx { get; /* RVA: 0x03D80B60 */ }
        Unity.Mathematics.float4 yyzy { get; /* RVA: 0x03D80B80 */ }
        Unity.Mathematics.float4 yyzz { get; /* RVA: 0x03D80BA0 */ }
        Unity.Mathematics.float4 yzxx { get; /* RVA: 0x03D80BE0 */ }
        Unity.Mathematics.float4 yzxy { get; /* RVA: 0x028B46B0 */ }
        Unity.Mathematics.float4 yzxz { get; /* RVA: 0x028B4710 */ }
        Unity.Mathematics.float4 yzyx { get; /* RVA: 0x03D80C20 */ }
        Unity.Mathematics.float4 yzyy { get; /* RVA: 0x03D80C40 */ }
        Unity.Mathematics.float4 yzyz { get; /* RVA: 0x03D80C60 */ }
        Unity.Mathematics.float4 yzzx { get; /* RVA: 0x03D80CA0 */ }
        Unity.Mathematics.float4 yzzy { get; /* RVA: 0x03D80CC0 */ }
        Unity.Mathematics.float4 yzzz { get; /* RVA: 0x03D80CE0 */ }
        Unity.Mathematics.float4 zxxx { get; /* RVA: 0x03D80D40 */ }
        Unity.Mathematics.float4 zxxy { get; /* RVA: 0x03D80D60 */ }
        Unity.Mathematics.float4 zxxz { get; /* RVA: 0x03D80D80 */ }
        Unity.Mathematics.float4 zxyx { get; /* RVA: 0x03D80DC0 */ }
        Unity.Mathematics.float4 zxyy { get; /* RVA: 0x028B46D0 */ }
        Unity.Mathematics.float4 zxyz { get; /* RVA: 0x028B46F0 */ }
        Unity.Mathematics.float4 zxzx { get; /* RVA: 0x03D80E00 */ }
        Unity.Mathematics.float4 zxzy { get; /* RVA: 0x03D80E20 */ }
        Unity.Mathematics.float4 zxzz { get; /* RVA: 0x03D80E40 */ }
        Unity.Mathematics.float4 zyxx { get; /* RVA: 0x03D80EA0 */ }
        Unity.Mathematics.float4 zyxy { get; /* RVA: 0x03D80EC0 */ }
        Unity.Mathematics.float4 zyxz { get; /* RVA: 0x03D80EE0 */ }
        Unity.Mathematics.float4 zyyx { get; /* RVA: 0x03D80F20 */ }
        Unity.Mathematics.float4 zyyy { get; /* RVA: 0x03D80F40 */ }
        Unity.Mathematics.float4 zyyz { get; /* RVA: 0x03D80F60 */ }
        Unity.Mathematics.float4 zyzx { get; /* RVA: 0x03D80FA0 */ }
        Unity.Mathematics.float4 zyzy { get; /* RVA: 0x03D80FC0 */ }
        Unity.Mathematics.float4 zyzz { get; /* RVA: 0x03D80FE0 */ }
        Unity.Mathematics.float4 zzxx { get; /* RVA: 0x03D81040 */ }
        Unity.Mathematics.float4 zzxy { get; /* RVA: 0x03D81060 */ }
        Unity.Mathematics.float4 zzxz { get; /* RVA: 0x03D81080 */ }
        Unity.Mathematics.float4 zzyx { get; /* RVA: 0x03D810C0 */ }
        Unity.Mathematics.float4 zzyy { get; /* RVA: 0x03D810E0 */ }
        Unity.Mathematics.float4 zzyz { get; /* RVA: 0x03D81100 */ }
        Unity.Mathematics.float4 zzzx { get; /* RVA: 0x03D81130 */ }
        Unity.Mathematics.float4 zzzy { get; /* RVA: 0x03D81150 */ }
        Unity.Mathematics.float4 zzzz { get; /* RVA: 0x03D81170 */ }
        Unity.Mathematics.float3 xxx { get; /* RVA: 0x03D804A0 */ }
        Unity.Mathematics.float3 xxy { get; /* RVA: 0x03D80510 */ }
        Unity.Mathematics.float3 xxz { get; /* RVA: 0x03D80590 */ }
        Unity.Mathematics.float3 xyx { get; /* RVA: 0x03D80610 */ }
        Unity.Mathematics.float3 xyy { get; /* RVA: 0x03D80670 */ }
        Unity.Mathematics.float3 xyz { get; /* RVA: 0x03D514C0 */ set; /* RVA: 0x03D51BE0 */ }
        Unity.Mathematics.float3 xzx { get; /* RVA: 0x03D80730 */ }
        Unity.Mathematics.float3 xzy { get; /* RVA: 0x03D807B0 */ set; /* RVA: 0x03D81360 */ }
        Unity.Mathematics.float3 xzz { get; /* RVA: 0x03D80830 */ }
        Unity.Mathematics.float3 yxx { get; /* RVA: 0x03D808B0 */ }
        Unity.Mathematics.float3 yxy { get; /* RVA: 0x03D80930 */ }
        Unity.Mathematics.float3 yxz { get; /* RVA: 0x03D809B0 */ set; /* RVA: 0x03D813A0 */ }
        Unity.Mathematics.float3 yyx { get; /* RVA: 0x03D80A50 */ }
        Unity.Mathematics.float3 yyy { get; /* RVA: 0x03D80AD0 */ }
        Unity.Mathematics.float3 yyz { get; /* RVA: 0x03D80B40 */ }
        Unity.Mathematics.float3 yzx { get; /* RVA: 0x03D80BC0 */ set; /* RVA: 0x03D813E0 */ }
        Unity.Mathematics.float3 yzy { get; /* RVA: 0x03D80C00 */ }
        Unity.Mathematics.float3 yzz { get; /* RVA: 0x03D80C80 */ }
        Unity.Mathematics.float3 zxx { get; /* RVA: 0x03D80D20 */ }
        Unity.Mathematics.float3 zxy { get; /* RVA: 0x03D80DA0 */ set; /* RVA: 0x03D81420 */ }
        Unity.Mathematics.float3 zxz { get; /* RVA: 0x03D80DE0 */ }
        Unity.Mathematics.float3 zyx { get; /* RVA: 0x03D80E80 */ set; /* RVA: 0x03D81460 */ }
        Unity.Mathematics.float3 zyy { get; /* RVA: 0x03D80F00 */ }
        Unity.Mathematics.float3 zyz { get; /* RVA: 0x03D80F80 */ }
        Unity.Mathematics.float3 zzx { get; /* RVA: 0x03D81020 */ }
        Unity.Mathematics.float3 zzy { get; /* RVA: 0x03D810A0 */ }
        Unity.Mathematics.float3 zzz { get; /* RVA: 0x03D81120 */ }
        Unity.Mathematics.float2 xx { get; /* RVA: 0x03D80490 */ }
        Unity.Mathematics.float2 xy { get; /* RVA: 0x03D51540 */ set; /* RVA: 0x03D7F900 */ }
        Unity.Mathematics.float2 xz { get; /* RVA: 0x03D51590 */ set; /* RVA: 0x03D81340 */ }
        Unity.Mathematics.float2 yx { get; /* RVA: 0x03D7F9F0 */ set; /* RVA: 0x03D81380 */ }
        Unity.Mathematics.float2 yy { get; /* RVA: 0x03D80A30 */ }
        Unity.Mathematics.float2 yz { get; /* RVA: 0x03D54520 */ set; /* RVA: 0x03D813C0 */ }
        Unity.Mathematics.float2 zx { get; /* RVA: 0x03D80D00 */ set; /* RVA: 0x03D81400 */ }
        Unity.Mathematics.float2 zy { get; /* RVA: 0x03D80E60 */ set; /* RVA: 0x03D81440 */ }
        Unity.Mathematics.float2 zz { get; /* RVA: 0x03D81000 */ }
        System.Single Item { get; /* RVA: 0x03D80480 */ set; /* RVA: 0x03D81330 */ }

        // Methods
        // RVA: 0x03D51BD0  token: 0x60009AA
        public System.Void .ctor(System.Single x, System.Single y, System.Single z) { }
        // RVA: 0x03D80430  token: 0x60009AB
        public System.Void .ctor(System.Single x, Unity.Mathematics.float2 yz) { }
        // RVA: 0x03D80360  token: 0x60009AC
        public System.Void .ctor(Unity.Mathematics.float2 xy, System.Single z) { }
        // RVA: 0x03D51BE0  token: 0x60009AD
        public System.Void .ctor(Unity.Mathematics.float3 xyz) { }
        // RVA: 0x03D803F0  token: 0x60009AE
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D27B9C  token: 0x60009AF
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D27BD0  token: 0x60009B0
        public System.Void .ctor(Unity.Mathematics.bool3 v) { }
        // RVA: 0x03D802F0  token: 0x60009B1
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D80400  token: 0x60009B2
        public System.Void .ctor(Unity.Mathematics.int3 v) { }
        // RVA: 0x03D80380  token: 0x60009B3
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D80320  token: 0x60009B4
        public System.Void .ctor(Unity.Mathematics.uint3 v) { }
        // RVA: 0x09C67B64  token: 0x60009B5
        public System.Void .ctor(Unity.Mathematics.half v) { }
        // RVA: 0x09C67B28  token: 0x60009B6
        public System.Void .ctor(Unity.Mathematics.half3 v) { }
        // RVA: 0x03D803C0  token: 0x60009B7
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x03D80450  token: 0x60009B8
        public System.Void .ctor(Unity.Mathematics.double3 v) { }
        // RVA: 0x03D54500  token: 0x60009B9
        public static Unity.Mathematics.float3 op_Implicit(System.Single v) { }
        // RVA: 0x09C34284  token: 0x60009BA
        public static Unity.Mathematics.float3 op_Explicit(System.Boolean v) { }
        // RVA: 0x09C34328  token: 0x60009BB
        public static Unity.Mathematics.float3 op_Explicit(Unity.Mathematics.bool3 v) { }
        // RVA: 0x03D7A860  token: 0x60009BC
        public static Unity.Mathematics.float3 op_Implicit(System.Int32 v) { }
        // RVA: 0x03D7A9F0  token: 0x60009BD
        public static Unity.Mathematics.float3 op_Implicit(Unity.Mathematics.int3 v) { }
        // RVA: 0x03D7A9B0  token: 0x60009BE
        public static Unity.Mathematics.float3 op_Implicit(System.UInt32 v) { }
        // RVA: 0x03D7A920  token: 0x60009BF
        public static Unity.Mathematics.float3 op_Implicit(Unity.Mathematics.uint3 v) { }
        // RVA: 0x09C342A0  token: 0x60009C0
        public static Unity.Mathematics.float3 op_Implicit(Unity.Mathematics.half v) { }
        // RVA: 0x09C342DC  token: 0x60009C1
        public static Unity.Mathematics.float3 op_Implicit(Unity.Mathematics.half3 v) { }
        // RVA: 0x03D7A890  token: 0x60009C2
        public static Unity.Mathematics.float3 op_Explicit(System.Double v) { }
        // RVA: 0x03D7A820  token: 0x60009C3
        public static Unity.Mathematics.float3 op_Explicit(Unity.Mathematics.double3 v) { }
        // RVA: 0x03D51660  token: 0x60009C4
        public static Unity.Mathematics.float3 op_Multiply(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x028B52E0  token: 0x60009C5
        public static Unity.Mathematics.float3 op_Multiply(Unity.Mathematics.float3 lhs, System.Single rhs) { }
        // RVA: 0x028B7A00  token: 0x60009C6
        public static Unity.Mathematics.float3 op_Multiply(System.Single lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x028B7A70  token: 0x60009C7
        public static Unity.Mathematics.float3 op_Addition(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x0333F750  token: 0x60009C8
        public static Unity.Mathematics.float3 op_Addition(Unity.Mathematics.float3 lhs, System.Single rhs) { }
        // RVA: 0x03D81190  token: 0x60009C9
        public static Unity.Mathematics.float3 op_Addition(System.Single lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x028B7A30  token: 0x60009CA
        public static Unity.Mathematics.float3 op_Subtraction(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x0333F780  token: 0x60009CB
        public static Unity.Mathematics.float3 op_Subtraction(Unity.Mathematics.float3 lhs, System.Single rhs) { }
        // RVA: 0x03D81300  token: 0x60009CC
        public static Unity.Mathematics.float3 op_Subtraction(System.Single lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x0950BFE0  token: 0x60009CD
        public static Unity.Mathematics.float3 op_Division(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x094FB6EC  token: 0x60009CE
        public static Unity.Mathematics.float3 op_Division(Unity.Mathematics.float3 lhs, System.Single rhs) { }
        // RVA: 0x09C67BA0  token: 0x60009CF
        public static Unity.Mathematics.float3 op_Division(System.Single lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x03D7AE80  token: 0x60009D0
        public static Unity.Mathematics.float3 op_Modulus(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x03D812A0  token: 0x60009D1
        public static Unity.Mathematics.float3 op_Modulus(Unity.Mathematics.float3 lhs, System.Single rhs) { }
        // RVA: 0x03D81240  token: 0x60009D2
        public static Unity.Mathematics.float3 op_Modulus(System.Single lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x03D81200  token: 0x60009D3
        public static Unity.Mathematics.float3 op_Increment(Unity.Mathematics.float3 val) { }
        // RVA: 0x03D811C0  token: 0x60009D4
        public static Unity.Mathematics.float3 op_Decrement(Unity.Mathematics.float3 val) { }
        // RVA: 0x09C67EE0  token: 0x60009D5
        public static Unity.Mathematics.bool3 op_LessThan(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x09C67F14  token: 0x60009D6
        public static Unity.Mathematics.bool3 op_LessThan(Unity.Mathematics.float3 lhs, System.Single rhs) { }
        // RVA: 0x09C67EB0  token: 0x60009D7
        public static Unity.Mathematics.bool3 op_LessThan(System.Single lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x09C67E1C  token: 0x60009D8
        public static Unity.Mathematics.bool3 op_LessThanOrEqual(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x09C67E88  token: 0x60009D9
        public static Unity.Mathematics.bool3 op_LessThanOrEqual(Unity.Mathematics.float3 lhs, System.Single rhs) { }
        // RVA: 0x09C67E54  token: 0x60009DA
        public static Unity.Mathematics.bool3 op_LessThanOrEqual(System.Single lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x09C67CDC  token: 0x60009DB
        public static Unity.Mathematics.bool3 op_GreaterThan(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x09C67D34  token: 0x60009DC
        public static Unity.Mathematics.bool3 op_GreaterThan(Unity.Mathematics.float3 lhs, System.Single rhs) { }
        // RVA: 0x09C67D10  token: 0x60009DD
        public static Unity.Mathematics.bool3 op_GreaterThan(System.Single lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x09C67C50  token: 0x60009DE
        public static Unity.Mathematics.bool3 op_GreaterThanOrEqual(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x09C67C84  token: 0x60009DF
        public static Unity.Mathematics.bool3 op_GreaterThanOrEqual(Unity.Mathematics.float3 lhs, System.Single rhs) { }
        // RVA: 0x09C67CB4  token: 0x60009E0
        public static Unity.Mathematics.bool3 op_GreaterThanOrEqual(System.Single lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x02E241C0  token: 0x60009E1
        public static Unity.Mathematics.float3 op_UnaryNegation(Unity.Mathematics.float3 val) { }
        // RVA: 0x03D514C0  token: 0x60009E2
        public static Unity.Mathematics.float3 op_UnaryPlus(Unity.Mathematics.float3 val) { }
        // RVA: 0x09C67BCC  token: 0x60009E3
        public static Unity.Mathematics.bool3 op_Equality(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x04D27C0C  token: 0x60009E4
        public static Unity.Mathematics.bool3 op_Equality(Unity.Mathematics.float3 lhs, System.Single rhs) { }
        // RVA: 0x09C67C14  token: 0x60009E5
        public static Unity.Mathematics.bool3 op_Equality(System.Single lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x09C67D98  token: 0x60009E6
        public static Unity.Mathematics.bool3 op_Inequality(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x09C67DDC  token: 0x60009E7
        public static Unity.Mathematics.bool3 op_Inequality(Unity.Mathematics.float3 lhs, System.Single rhs) { }
        // RVA: 0x09C67D60  token: 0x60009E8
        public static Unity.Mathematics.bool3 op_Inequality(System.Single lhs, Unity.Mathematics.float3 rhs) { }
        // RVA: 0x02799940  token: 0x6000A6C
        public virtual System.Boolean Equals(Unity.Mathematics.float3 rhs) { }
        // RVA: 0x09C67920  token: 0x6000A6D
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C67994  token: 0x6000A6E
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C679B8  token: 0x6000A6F
        public virtual System.String ToString() { }
        // RVA: 0x09C67A78  token: 0x6000A70
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x03D514C0  token: 0x6000A71
        public static UnityEngine.Vector3 op_Implicit(Unity.Mathematics.float3 v) { }
        // RVA: 0x03D514C0  token: 0x6000A72
        public static Unity.Mathematics.float3 op_Implicit(UnityEngine.Vector3 v) { }

    }

    // TypeToken: 0x200002D  // size: 0x28
    public sealed struct float3x2 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.float3 c0;  // 0x10
        public Unity.Mathematics.float3 c1;  // 0x1c

        // Methods
        // RVA: 0x03D4FF30  token: 0x6000A73
        public System.Void .ctor(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1) { }
        // RVA: 0x03D814F0  token: 0x6000A74
        public System.Void .ctor(System.Single m00, System.Single m01, System.Single m10, System.Single m11, System.Single m20, System.Single m21) { }
        // RVA: 0x03D814D0  token: 0x6000A75
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D27D00  token: 0x6000A76
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C6DB28  token: 0x6000A77
        public System.Void .ctor(Unity.Mathematics.bool3x2 v) { }
        // RVA: 0x03D81480  token: 0x6000A78
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x04D27EA0  token: 0x6000A79
        public System.Void .ctor(Unity.Mathematics.int3x2 v) { }
        // RVA: 0x03D81520  token: 0x6000A7A
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x04D27E2C  token: 0x6000A7B
        public System.Void .ctor(Unity.Mathematics.uint3x2 v) { }
        // RVA: 0x03D81590  token: 0x6000A7C
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C6DAB0  token: 0x6000A7D
        public System.Void .ctor(Unity.Mathematics.double3x2 v) { }
        // RVA: 0x09C6DBF8  token: 0x6000A7E
        public static Unity.Mathematics.float3x2 op_Multiply(Unity.Mathematics.float3x2 lhs, System.Single rhs) { }
        // RVA: 0x09C6D690  token: 0x6000A7F
        public virtual System.Boolean Equals(Unity.Mathematics.float3x2 rhs) { }
        // RVA: 0x09C6D61C  token: 0x6000A80
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C6D6F4  token: 0x6000A81
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C6D8D0  token: 0x6000A82
        public virtual System.String ToString() { }
        // RVA: 0x09C6D71C  token: 0x6000A83
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x200002E  // size: 0x34
    public sealed struct float3x3 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.float3 c0;  // 0x10
        public Unity.Mathematics.float3 c1;  // 0x1c
        public Unity.Mathematics.float3 c2;  // 0x28
        public static readonly Unity.Mathematics.float3x3 identity;  // static @ 0x0
        public static readonly Unity.Mathematics.float3x3 zero;  // static @ 0x24

        // Properties
        Unity.Mathematics.float3& Item { get; /* RVA: 0x03D81800 */ }

        // Methods
        // RVA: 0x03D55290  token: 0x6000A84
        public System.Void .ctor(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2) { }
        // RVA: 0x03D81650  token: 0x6000A85
        public System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12, System.Single m20, System.Single m21, System.Single m22) { }
        // RVA: 0x03D81760  token: 0x6000A86
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D28060  token: 0x6000A87
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C6E324  token: 0x6000A88
        public System.Void .ctor(Unity.Mathematics.bool3x3 v) { }
        // RVA: 0x03D815E0  token: 0x6000A89
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x04D27F14  token: 0x6000A8A
        public System.Void .ctor(Unity.Mathematics.int3x3 v) { }
        // RVA: 0x03D816B0  token: 0x6000A8B
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x04D280DC  token: 0x6000A8C
        public System.Void .ctor(Unity.Mathematics.uint3x3 v) { }
        // RVA: 0x03D81790  token: 0x6000A8D
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C6E27C  token: 0x6000A8E
        public System.Void .ctor(Unity.Mathematics.double3x3 v) { }
        // RVA: 0x09C3460C  token: 0x6000A8F
        public static Unity.Mathematics.float3x3 op_Implicit(System.Int32 v) { }
        // RVA: 0x09C6E548  token: 0x6000A90
        public static Unity.Mathematics.float3x3 op_Multiply(Unity.Mathematics.float3x3 lhs, System.Single rhs) { }
        // RVA: 0x09C6E448  token: 0x6000A91
        public static Unity.Mathematics.float3x3 op_Addition(Unity.Mathematics.float3x3 lhs, Unity.Mathematics.float3x3 rhs) { }
        // RVA: 0x09C6DCF8  token: 0x6000A93
        public virtual System.Boolean Equals(Unity.Mathematics.float3x3 rhs) { }
        // RVA: 0x09C6DC7C  token: 0x6000A94
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C6DD84  token: 0x6000A95
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C6DDB0  token: 0x6000A96
        public virtual System.String ToString() { }
        // RVA: 0x09C6E038  token: 0x6000A97
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x028B5310  token: 0x6000A98
        public System.Void .ctor(Unity.Mathematics.float4x4 f4x4) { }
        // RVA: 0x028B74E0  token: 0x6000A99
        public System.Void .ctor(Unity.Mathematics.quaternion q) { }
        // RVA: 0x03C7D1C0  token: 0x6000A9A
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200002F  // size: 0x40
    public sealed struct float3x4 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.float3 c0;  // 0x10
        public Unity.Mathematics.float3 c1;  // 0x1c
        public Unity.Mathematics.float3 c2;  // 0x28
        public Unity.Mathematics.float3 c3;  // 0x34
        public static readonly Unity.Mathematics.float3x4 zero;  // static @ 0x0

        // Properties
        Unity.Mathematics.float3& Item { get; /* RVA: 0x03D81800 */ }

        // Methods
        // RVA: 0x03D81850  token: 0x6000A9B
        public System.Void .ctor(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2, Unity.Mathematics.float3 c3) { }
        // RVA: 0x03D81AA0  token: 0x6000A9C
        public System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13, System.Single m20, System.Single m21, System.Single m22, System.Single m23) { }
        // RVA: 0x03D81810  token: 0x6000A9D
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D2837C  token: 0x6000A9E
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C6EE50  token: 0x6000A9F
        public System.Void .ctor(Unity.Mathematics.bool3x4 v) { }
        // RVA: 0x03D81A10  token: 0x6000AA0
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x04D282A8  token: 0x6000AA1
        public System.Void .ctor(Unity.Mathematics.int3x4 v) { }
        // RVA: 0x03D81930  token: 0x6000AA2
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x04D2841C  token: 0x6000AA3
        public System.Void .ctor(Unity.Mathematics.uint3x4 v) { }
        // RVA: 0x03D818A0  token: 0x6000AA4
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C6ED74  token: 0x6000AA5
        public System.Void .ctor(Unity.Mathematics.double3x4 v) { }
        // RVA: 0x09C34834  token: 0x6000AA6
        public static Unity.Mathematics.float3x4 op_Implicit(System.Int32 v) { }
        // RVA: 0x09C6E67C  token: 0x6000AA8
        public virtual System.Boolean Equals(Unity.Mathematics.float3x4 rhs) { }
        // RVA: 0x09C6E600  token: 0x6000AA9
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C6E740  token: 0x6000AAA
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C6EA44  token: 0x6000AAB
        public virtual System.String ToString() { }
        // RVA: 0x09C6E770  token: 0x6000AAC
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000030  // size: 0x20
    public sealed struct float4 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public System.Single x;  // 0x10
        public System.Single y;  // 0x14
        public System.Single z;  // 0x18
        public System.Single w;  // 0x1c
        public static readonly Unity.Mathematics.float4 zero;  // static @ 0x0

        // Properties
        Unity.Mathematics.float4 xxzz { get; /* RVA: 0x03D805F0 */ }
        Unity.Mathematics.float4 xyzx { get; /* RVA: 0x028B4690 */ }
        Unity.Mathematics.float4 xzxz { get; /* RVA: 0x03D80790 */ }
        Unity.Mathematics.float4 yyww { get; /* RVA: 0x03D81E50 */ }
        Unity.Mathematics.float4 yzxy { get; /* RVA: 0x028B46B0 */ }
        Unity.Mathematics.float4 yzxz { get; /* RVA: 0x028B4710 */ }
        Unity.Mathematics.float4 yzxw { get; /* RVA: 0x03D81E70 */ }
        Unity.Mathematics.float4 zxyy { get; /* RVA: 0x028B46D0 */ }
        Unity.Mathematics.float4 zxyz { get; /* RVA: 0x028B46F0 */ }
        Unity.Mathematics.float4 zwxy { get; /* RVA: 0x028B5900 */ }
        Unity.Mathematics.float4 wzyx { get; /* RVA: 0x028B58E0 */ }
        Unity.Mathematics.float4 wwwx { get; /* RVA: 0x03D81D90 */ }
        Unity.Mathematics.float4 wwww { get; /* RVA: 0x03D81D70 */ }
        Unity.Mathematics.float3 xxx { get; /* RVA: 0x03D804A0 */ }
        Unity.Mathematics.float3 xyz { get; /* RVA: 0x03D514C0 */ set; /* RVA: 0x03D51BE0 */ }
        Unity.Mathematics.float3 xyw { get; /* RVA: 0x03D81DF0 */ }
        Unity.Mathematics.float3 yxw { get; /* RVA: 0x03D81E30 */ }
        Unity.Mathematics.float3 yzx { get; /* RVA: 0x03D80BC0 */ }
        Unity.Mathematics.float3 zwx { get; /* RVA: 0x03D81E90 */ }
        Unity.Mathematics.float3 wzy { get; /* RVA: 0x03D81DD0 */ }
        Unity.Mathematics.float3 www { get; /* RVA: 0x03D81D60 */ }
        Unity.Mathematics.float2 xx { get; /* RVA: 0x03D80490 */ }
        Unity.Mathematics.float2 xy { get; /* RVA: 0x03D51540 */ set; /* RVA: 0x03D7F900 */ }
        Unity.Mathematics.float2 xz { get; /* RVA: 0x03D51590 */ }
        Unity.Mathematics.float2 yy { get; /* RVA: 0x03D80A30 */ }
        Unity.Mathematics.float2 yw { get; /* RVA: 0x03D81E10 */ }
        Unity.Mathematics.float2 zw { get; /* RVA: 0x03D67720 */ }
        Unity.Mathematics.float2 wz { get; /* RVA: 0x03D81DB0 */ }
        System.Single Item { get; /* RVA: 0x03D80480 */ set; /* RVA: 0x03D81330 */ }

        // Methods
        // RVA: 0x03D516B0  token: 0x6000AAD
        public System.Void .ctor(System.Single x, System.Single y, System.Single z, System.Single w) { }
        // RVA: 0x03D81C70  token: 0x6000AAE
        public System.Void .ctor(System.Single x, System.Single y, Unity.Mathematics.float2 zw) { }
        // RVA: 0x03D81D10  token: 0x6000AAF
        public System.Void .ctor(System.Single x, Unity.Mathematics.float2 yz, System.Single w) { }
        // RVA: 0x03D81D40  token: 0x6000AB0
        public System.Void .ctor(System.Single x, Unity.Mathematics.float3 yzw) { }
        // RVA: 0x03D81C20  token: 0x6000AB1
        public System.Void .ctor(Unity.Mathematics.float2 xy, System.Single z, System.Single w) { }
        // RVA: 0x03D81B20  token: 0x6000AB2
        public System.Void .ctor(Unity.Mathematics.float2 xy, Unity.Mathematics.float2 zw) { }
        // RVA: 0x03D81C00  token: 0x6000AB3
        public System.Void .ctor(Unity.Mathematics.float3 xyz, System.Single w) { }
        // RVA: 0x03D5DBB0  token: 0x6000AB4
        public System.Void .ctor(Unity.Mathematics.float4 xyzw) { }
        // RVA: 0x03D81BB0  token: 0x6000AB5
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D28748  token: 0x6000AB6
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D2878C  token: 0x6000AB7
        public System.Void .ctor(Unity.Mathematics.bool4 v) { }
        // RVA: 0x03D81CA0  token: 0x6000AB8
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D81D00  token: 0x6000AB9
        public System.Void .ctor(Unity.Mathematics.int4 v) { }
        // RVA: 0x03D81B60  token: 0x6000ABA
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D81CB0  token: 0x6000ABB
        public System.Void .ctor(Unity.Mathematics.uint4 v) { }
        // RVA: 0x09C6F34C  token: 0x6000ABC
        public System.Void .ctor(Unity.Mathematics.half v) { }
        // RVA: 0x09C6F2F4  token: 0x6000ABD
        public System.Void .ctor(Unity.Mathematics.half4 v) { }
        // RVA: 0x03D81C50  token: 0x6000ABE
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x03D81BC0  token: 0x6000ABF
        public System.Void .ctor(Unity.Mathematics.double4 v) { }
        // RVA: 0x03D7AAE0  token: 0x6000AC0
        public static Unity.Mathematics.float4 op_Implicit(System.Single v) { }
        // RVA: 0x03D7AB70  token: 0x6000AC1
        public static Unity.Mathematics.float4 op_Implicit(System.Int32 v) { }
        // RVA: 0x09C34A6C  token: 0x6000AC2
        public static Unity.Mathematics.float4 op_Implicit(Unity.Mathematics.int4 v) { }
        // RVA: 0x03D7ABC0  token: 0x6000AC3
        public static Unity.Mathematics.float4 op_Implicit(System.UInt32 v) { }
        // RVA: 0x09C34AC8  token: 0x6000AC4
        public static Unity.Mathematics.float4 op_Implicit(Unity.Mathematics.uint4 v) { }
        // RVA: 0x09C349C4  token: 0x6000AC5
        public static Unity.Mathematics.float4 op_Implicit(Unity.Mathematics.half4 v) { }
        // RVA: 0x03D7AB50  token: 0x6000AC6
        public static Unity.Mathematics.float4 op_Explicit(System.Double v) { }
        // RVA: 0x09C3497C  token: 0x6000AC7
        public static Unity.Mathematics.float4 op_Explicit(Unity.Mathematics.double4 v) { }
        // RVA: 0x028B5D10  token: 0x6000AC8
        public static Unity.Mathematics.float4 op_Multiply(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs) { }
        // RVA: 0x02E260C0  token: 0x6000AC9
        public static Unity.Mathematics.float4 op_Multiply(Unity.Mathematics.float4 lhs, System.Single rhs) { }
        // RVA: 0x028B53E0  token: 0x6000ACA
        public static Unity.Mathematics.float4 op_Multiply(System.Single lhs, Unity.Mathematics.float4 rhs) { }
        // RVA: 0x028B5D60  token: 0x6000ACB
        public static Unity.Mathematics.float4 op_Addition(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs) { }
        // RVA: 0x03D73570  token: 0x6000ACC
        public static Unity.Mathematics.float4 op_Addition(Unity.Mathematics.float4 lhs, System.Single rhs) { }
        // RVA: 0x028B4640  token: 0x6000ACD
        public static Unity.Mathematics.float4 op_Subtraction(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs) { }
        // RVA: 0x03D73590  token: 0x6000ACE
        public static Unity.Mathematics.float4 op_Subtraction(Unity.Mathematics.float4 lhs, System.Single rhs) { }
        // RVA: 0x03D81EB0  token: 0x6000ACF
        public static Unity.Mathematics.float4 op_Subtraction(System.Single lhs, Unity.Mathematics.float4 rhs) { }
        // RVA: 0x0950C700  token: 0x6000AD0
        public static Unity.Mathematics.float4 op_Division(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs) { }
        // RVA: 0x0950C744  token: 0x6000AD1
        public static Unity.Mathematics.float4 op_Division(Unity.Mathematics.float4 lhs, System.Single rhs) { }
        // RVA: 0x09C6F394  token: 0x6000AD2
        public static Unity.Mathematics.float4 op_Division(System.Single lhs, Unity.Mathematics.float4 rhs) { }
        // RVA: 0x09C6F4B0  token: 0x6000AD3
        public static Unity.Mathematics.bool4 op_LessThan(Unity.Mathematics.float4 lhs, System.Single rhs) { }
        // RVA: 0x09C6F474  token: 0x6000AD4
        public static Unity.Mathematics.bool4 op_GreaterThan(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs) { }
        // RVA: 0x09C6F430  token: 0x6000AD5
        public static Unity.Mathematics.bool4 op_GreaterThanOrEqual(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs) { }
        // RVA: 0x03D81EF0  token: 0x6000AD6
        public static Unity.Mathematics.float4 op_UnaryNegation(Unity.Mathematics.float4 val) { }
        // RVA: 0x09C6F3CC  token: 0x6000AD7
        public static Unity.Mathematics.bool4 op_Equality(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs) { }
        // RVA: 0x04D287E0  token: 0x6000AD8
        public static Unity.Mathematics.bool4 op_Equality(Unity.Mathematics.float4 lhs, System.Single rhs) { }
        // RVA: 0x022CDA10  token: 0x6000AF9
        public virtual System.Boolean Equals(Unity.Mathematics.float4 rhs) { }
        // RVA: 0x09C6EFC8  token: 0x6000AFA
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C38878  token: 0x6000AFB
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C6F034  token: 0x6000AFC
        public virtual System.String ToString() { }
        // RVA: 0x09C6F1A0  token: 0x6000AFD
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x0294BC80  token: 0x6000AFE
        public static Unity.Mathematics.float4 op_Implicit(UnityEngine.Vector4 v) { }
        // RVA: 0x0294BC80  token: 0x6000AFF
        public static UnityEngine.Vector4 op_Implicit(Unity.Mathematics.float4 v) { }

    }

    // TypeToken: 0x2000032  // size: 0x30
    public sealed struct float4x2 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.float4 c0;  // 0x10
        public Unity.Mathematics.float4 c1;  // 0x20

        // Methods
        // RVA: 0x03D553F0  token: 0x6000B00
        public System.Void .ctor(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1) { }
        // RVA: 0x03D81FE0  token: 0x6000B01
        public System.Void .ctor(System.Single m00, System.Single m01, System.Single m10, System.Single m11, System.Single m20, System.Single m21, System.Single m30, System.Single m31) { }
        // RVA: 0x03D81FC0  token: 0x6000B02
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D28AB4  token: 0x6000B03
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D288EC  token: 0x6000B04
        public System.Void .ctor(Unity.Mathematics.bool4x2 v) { }
        // RVA: 0x03D81F10  token: 0x6000B05
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x09C6FA70  token: 0x6000B06
        public System.Void .ctor(Unity.Mathematics.int4x2 v) { }
        // RVA: 0x04D28A84  token: 0x6000B07
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x09C6FA1C  token: 0x6000B08
        public System.Void .ctor(Unity.Mathematics.uint4x2 v) { }
        // RVA: 0x03D81F30  token: 0x6000B09
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C6FB14  token: 0x6000B0A
        public System.Void .ctor(Unity.Mathematics.double4x2 v) { }
        // RVA: 0x02293810  token: 0x6000B0B
        public static Unity.Mathematics.float4x2 op_Implicit(System.Int32 v) { }
        // RVA: 0x09C6F4D8  token: 0x6000B0C
        public virtual System.Boolean Equals(Unity.Mathematics.float4x2 rhs) { }
        // RVA: 0x09C6F520  token: 0x6000B0D
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C6F594  token: 0x6000B0E
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C6F7CC  token: 0x6000B0F
        public virtual System.String ToString() { }
        // RVA: 0x09C6F5B8  token: 0x6000B10
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000033  // size: 0x40
    public sealed struct float4x3 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.float4 c0;  // 0x10
        public Unity.Mathematics.float4 c1;  // 0x20
        public Unity.Mathematics.float4 c2;  // 0x30

        // Properties
        Unity.Mathematics.float4& Item { get; /* RVA: 0x03D82200 */ }

        // Methods
        // RVA: 0x03D6B600  token: 0x6000B11
        public System.Void .ctor(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2) { }
        // RVA: 0x03D82140  token: 0x6000B12
        public System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12, System.Single m20, System.Single m21, System.Single m22, System.Single m30, System.Single m31, System.Single m32) { }
        // RVA: 0x03D82110  token: 0x6000B13
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D28B88  token: 0x6000B14
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D28AD8  token: 0x6000B15
        public System.Void .ctor(Unity.Mathematics.bool4x3 v) { }
        // RVA: 0x02752510  token: 0x6000B16
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x09C70288  token: 0x6000B17
        public System.Void .ctor(Unity.Mathematics.int4x3 v) { }
        // RVA: 0x04D28DC4  token: 0x6000B18
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x09C70378  token: 0x6000B19
        public System.Void .ctor(Unity.Mathematics.uint4x3 v) { }
        // RVA: 0x03D82050  token: 0x6000B1A
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C703F0  token: 0x6000B1B
        public System.Void .ctor(Unity.Mathematics.double4x3 v) { }
        // RVA: 0x09C34DDC  token: 0x6000B1C
        public static Unity.Mathematics.float4x3 op_Implicit(System.Int32 v) { }
        // RVA: 0x09C70538  token: 0x6000B1D
        public static Unity.Mathematics.float4x3 op_Multiply(Unity.Mathematics.float4x3 lhs, Unity.Mathematics.float4x3 rhs) { }
        // RVA: 0x09C705F4  token: 0x6000B1E
        public static Unity.Mathematics.float4x3 op_Multiply(Unity.Mathematics.float4x3 lhs, System.Single rhs) { }
        // RVA: 0x09C7047C  token: 0x6000B1F
        public static Unity.Mathematics.float4x3 op_Addition(Unity.Mathematics.float4x3 lhs, Unity.Mathematics.float4x3 rhs) { }
        // RVA: 0x09C6FBF4  token: 0x6000B21
        public virtual System.Boolean Equals(Unity.Mathematics.float4x3 rhs) { }
        // RVA: 0x09C6FB78  token: 0x6000B22
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C6FC54  token: 0x6000B23
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C6FF58  token: 0x6000B24
        public virtual System.String ToString() { }
        // RVA: 0x09C6FC84  token: 0x6000B25
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000034  // size: 0x50
    public sealed struct float4x4 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.float4 c0;  // 0x10
        public Unity.Mathematics.float4 c1;  // 0x20
        public Unity.Mathematics.float4 c2;  // 0x30
        public Unity.Mathematics.float4 c3;  // 0x40
        public static readonly Unity.Mathematics.float4x4 identity;  // static @ 0x0
        public static readonly Unity.Mathematics.float4x4 zero;  // static @ 0x40

        // Properties
        Unity.Mathematics.float4& Item { get; /* RVA: 0x03D82200 */ }

        // Methods
        // RVA: 0x03D7E4A0  token: 0x6000B26
        public System.Void .ctor(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2, Unity.Mathematics.float4 c3) { }
        // RVA: 0x02A591D0  token: 0x6000B27
        public System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13, System.Single m20, System.Single m21, System.Single m22, System.Single m23, System.Single m30, System.Single m31, System.Single m32, System.Single m33) { }
        // RVA: 0x02E25B30  token: 0x6000B28
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D28EE8  token: 0x6000B29
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D28E08  token: 0x6000B2A
        public System.Void .ctor(Unity.Mathematics.bool4x4 v) { }
        // RVA: 0x0327D9B0  token: 0x6000B2B
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x09C71638  token: 0x6000B2C
        public System.Void .ctor(Unity.Mathematics.int4x4 v) { }
        // RVA: 0x04D28FE4  token: 0x6000B2D
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x09C715A0  token: 0x6000B2E
        public System.Void .ctor(Unity.Mathematics.uint4x4 v) { }
        // RVA: 0x03D82210  token: 0x6000B2F
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C714E8  token: 0x6000B30
        public System.Void .ctor(Unity.Mathematics.double4x4 v) { }
        // RVA: 0x02E25B00  token: 0x6000B31
        public static Unity.Mathematics.float4x4 op_Implicit(System.Single v) { }
        // RVA: 0x09C352DC  token: 0x6000B32
        public static Unity.Mathematics.float4x4 op_Implicit(System.Int32 v) { }
        // RVA: 0x09C7195C  token: 0x6000B33
        public static Unity.Mathematics.float4x4 op_Multiply(Unity.Mathematics.float4x4 lhs, System.Single rhs) { }
        // RVA: 0x09C71770  token: 0x6000B34
        public static Unity.Mathematics.bool4x4 op_Equality(Unity.Mathematics.float4x4 lhs, Unity.Mathematics.float4x4 rhs) { }
        // RVA: 0x09C70680  token: 0x6000B36
        public virtual System.Boolean Equals(Unity.Mathematics.float4x4 rhs) { }
        // RVA: 0x09C706FC  token: 0x6000B37
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C70780  token: 0x6000B38
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C70A5C  token: 0x6000B39
        public virtual System.String ToString() { }
        // RVA: 0x09C70E6C  token: 0x6000B3A
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x09C71844  token: 0x6000B3B
        public static Unity.Mathematics.float4x4 op_Implicit(UnityEngine.Matrix4x4 m) { }
        // RVA: 0x02A592D0  token: 0x6000B3C
        public static UnityEngine.Matrix4x4 op_Implicit(Unity.Mathematics.float4x4 m) { }
        // RVA: 0x09C71200  token: 0x6000B3D
        public System.Void .ctor(Unity.Mathematics.float3x3 rotation, Unity.Mathematics.float3 translation) { }
        // RVA: 0x09C712C0  token: 0x6000B3E
        public System.Void .ctor(Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 translation) { }
        // RVA: 0x09C713C4  token: 0x6000B3F
        public System.Void .ctor(Unity.Mathematics.RigidTransform transform) { }
        // RVA: 0x09C707B8  token: 0x6000B40
        public static Unity.Mathematics.float4x4 Ortho(System.Single width, System.Single height, System.Single near, System.Single far) { }
        // RVA: 0x09C708A4  token: 0x6000B41
        public static Unity.Mathematics.float4x4 TRS(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 scale) { }
        // RVA: 0x03C915F0  token: 0x6000B42
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000035  // size: 0x12
    public sealed struct half : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public System.UInt16 value;  // 0x10
        public static readonly Unity.Mathematics.half zero;  // static @ 0x0

        // Methods
        // RVA: 0x03D4F9B0  token: 0x6000B43
        public System.Void .ctor(Unity.Mathematics.half x) { }
        // RVA: 0x09C7250C  token: 0x6000B44
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x09C724F0  token: 0x6000B45
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C35A48  token: 0x6000B46
        public static Unity.Mathematics.half op_Explicit(System.Single v) { }
        // RVA: 0x09C35A3C  token: 0x6000B47
        public static Unity.Mathematics.half op_Explicit(System.Double v) { }
        // RVA: 0x09C72544  token: 0x6000B48
        public static System.Single op_Implicit(Unity.Mathematics.half d) { }
        // RVA: 0x09C7252C  token: 0x6000B49
        public static System.Double op_Implicit(Unity.Mathematics.half d) { }
        // RVA: 0x09C72524  token: 0x6000B4A
        public static System.Boolean op_Equality(Unity.Mathematics.half lhs, Unity.Mathematics.half rhs) { }
        // RVA: 0x031DF9C0  token: 0x6000B4B
        public virtual System.Boolean Equals(Unity.Mathematics.half rhs) { }
        // RVA: 0x09C72438  token: 0x6000B4C
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x03D4F990  token: 0x6000B4D
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C72498  token: 0x6000B4E
        public virtual System.String ToString() { }
        // RVA: 0x09C724BC  token: 0x6000B4F
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000036  // size: 0x14
    public sealed struct half2 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.half x;  // 0x10
        public Unity.Mathematics.half y;  // 0x12

        // Methods
        // RVA: 0x03D6EFA0  token: 0x6000B50
        public System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half y) { }
        // RVA: 0x03D82320  token: 0x6000B51
        public System.Void .ctor(Unity.Mathematics.half2 xy) { }
        // RVA: 0x03D82310  token: 0x6000B52
        public System.Void .ctor(Unity.Mathematics.half v) { }
        // RVA: 0x09C71C24  token: 0x6000B53
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x09C71C4C  token: 0x6000B54
        public System.Void .ctor(Unity.Mathematics.float2 v) { }
        // RVA: 0x09C71BF4  token: 0x6000B55
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C71C7C  token: 0x6000B56
        public System.Void .ctor(Unity.Mathematics.double2 v) { }
        // RVA: 0x09C357A8  token: 0x6000B57
        public static Unity.Mathematics.half2 op_Explicit(Unity.Mathematics.float2 v) { }
        // RVA: 0x09C71A88  token: 0x6000B58
        public virtual System.Boolean Equals(Unity.Mathematics.half2 rhs) { }
        // RVA: 0x09C71A14  token: 0x6000B59
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C71A9C  token: 0x6000B5A
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C71B68  token: 0x6000B5B
        public virtual System.String ToString() { }
        // RVA: 0x09C71AE4  token: 0x6000B5C
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000038  // size: 0x16
    public sealed struct half3 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.half x;  // 0x10
        public Unity.Mathematics.half y;  // 0x12
        public Unity.Mathematics.half z;  // 0x14

        // Methods
        // RVA: 0x03D7D570  token: 0x6000B5D
        public System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half z) { }
        // RVA: 0x03D82330  token: 0x6000B5E
        public System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half2 yz) { }
        // RVA: 0x03D82350  token: 0x6000B5F
        public System.Void .ctor(Unity.Mathematics.half2 xy, Unity.Mathematics.half z) { }
        // RVA: 0x03D82360  token: 0x6000B60
        public System.Void .ctor(Unity.Mathematics.half3 xyz) { }
        // RVA: 0x03D82380  token: 0x6000B61
        public System.Void .ctor(Unity.Mathematics.half v) { }
        // RVA: 0x09C71F70  token: 0x6000B62
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x09C71FA8  token: 0x6000B63
        public System.Void .ctor(Unity.Mathematics.float3 v) { }
        // RVA: 0x09C71EE4  token: 0x6000B64
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C71F28  token: 0x6000B65
        public System.Void .ctor(Unity.Mathematics.double3 v) { }
        // RVA: 0x09C3586C  token: 0x6000B66
        public static Unity.Mathematics.half3 op_Explicit(Unity.Mathematics.float3 v) { }
        // RVA: 0x09C35820  token: 0x6000B67
        public static Unity.Mathematics.half3 op_Explicit(Unity.Mathematics.double3 v) { }
        // RVA: 0x09C71CB0  token: 0x6000B68
        public virtual System.Boolean Equals(Unity.Mathematics.half3 rhs) { }
        // RVA: 0x09C71CD4  token: 0x6000B69
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C71D60  token: 0x6000B6A
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C71E2C  token: 0x6000B6B
        public virtual System.String ToString() { }
        // RVA: 0x09C71D84  token: 0x6000B6C
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x200003A  // size: 0x18
    public sealed struct half4 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.half x;  // 0x10
        public Unity.Mathematics.half y;  // 0x12
        public Unity.Mathematics.half z;  // 0x14
        public Unity.Mathematics.half w;  // 0x16
        public static readonly Unity.Mathematics.half4 zero;  // static @ 0x0

        // Methods
        // RVA: 0x03D7D630  token: 0x6000B6D
        public System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half z, Unity.Mathematics.half w) { }
        // RVA: 0x03D82400  token: 0x6000B6E
        public System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half2 zw) { }
        // RVA: 0x03D82420  token: 0x6000B6F
        public System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half2 yz, Unity.Mathematics.half w) { }
        // RVA: 0x03D82470  token: 0x6000B70
        public System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half3 yzw) { }
        // RVA: 0x03D82390  token: 0x6000B71
        public System.Void .ctor(Unity.Mathematics.half2 xy, Unity.Mathematics.half z, Unity.Mathematics.half w) { }
        // RVA: 0x03D823B0  token: 0x6000B72
        public System.Void .ctor(Unity.Mathematics.half2 xy, Unity.Mathematics.half2 zw) { }
        // RVA: 0x03D82450  token: 0x6000B73
        public System.Void .ctor(Unity.Mathematics.half3 xyz, Unity.Mathematics.half w) { }
        // RVA: 0x03D823D0  token: 0x6000B74
        public System.Void .ctor(Unity.Mathematics.half4 xyzw) { }
        // RVA: 0x03D82440  token: 0x6000B75
        public System.Void .ctor(Unity.Mathematics.half v) { }
        // RVA: 0x09C723F4  token: 0x6000B76
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x09C722F8  token: 0x6000B77
        public System.Void .ctor(Unity.Mathematics.float4 v) { }
        // RVA: 0x09C723A0  token: 0x6000B78
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C72344  token: 0x6000B79
        public System.Void .ctor(Unity.Mathematics.double4 v) { }
        // RVA: 0x09C359E8  token: 0x6000B7A
        public static Unity.Mathematics.half4 op_Explicit(Unity.Mathematics.float4 v) { }
        // RVA: 0x09C6A134  token: 0x6000B7B
        public virtual System.Boolean Equals(Unity.Mathematics.half4 rhs) { }
        // RVA: 0x09C71FE4  token: 0x6000B7C
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C72044  token: 0x6000B7D
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C7204C  token: 0x6000B7E
        public virtual System.String ToString() { }
        // RVA: 0x09C721B0  token: 0x6000B7F
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x200003C  // size: 0x18
    public sealed struct int2 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public System.Int32 x;  // 0x10
        public System.Int32 y;  // 0x14
        public static readonly Unity.Mathematics.int2 zero;  // static @ 0x0

        // Properties
        Unity.Mathematics.int2 xy { get; /* RVA: 0x03D5DE50 */ }
        System.Int32 Item { set; /* RVA: 0x03D56010 */ }

        // Methods
        // RVA: 0x03D4E4B0  token: 0x6000B80
        public System.Void .ctor(System.Int32 x, System.Int32 y) { }
        // RVA: 0x03D824F0  token: 0x6000B81
        public System.Void .ctor(Unity.Mathematics.int2 xy) { }
        // RVA: 0x03D82490  token: 0x6000B82
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x09C72704  token: 0x6000B83
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C72714  token: 0x6000B84
        public System.Void .ctor(Unity.Mathematics.bool2 v) { }
        // RVA: 0x03D82490  token: 0x6000B85
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D824F0  token: 0x6000B86
        public System.Void .ctor(Unity.Mathematics.uint2 v) { }
        // RVA: 0x03D824E0  token: 0x6000B87
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x03D824B0  token: 0x6000B88
        public System.Void .ctor(Unity.Mathematics.float2 v) { }
        // RVA: 0x03D824D0  token: 0x6000B89
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x03D824A0  token: 0x6000B8A
        public System.Void .ctor(Unity.Mathematics.double2 v) { }
        // RVA: 0x03D7B520  token: 0x6000B8B
        public static Unity.Mathematics.int2 op_Implicit(System.Int32 v) { }
        // RVA: 0x03D7B520  token: 0x6000B8C
        public static Unity.Mathematics.int2 op_Explicit(System.UInt32 v) { }
        // RVA: 0x03D76940  token: 0x6000B8D
        public static Unity.Mathematics.int2 op_Explicit(Unity.Mathematics.uint2 v) { }
        // RVA: 0x03D7B500  token: 0x6000B8E
        public static Unity.Mathematics.int2 op_Explicit(System.Single v) { }
        // RVA: 0x03D7B4C0  token: 0x6000B8F
        public static Unity.Mathematics.int2 op_Explicit(Unity.Mathematics.float2 v) { }
        // RVA: 0x03D7B4E0  token: 0x6000B90
        public static Unity.Mathematics.int2 op_Explicit(System.Double v) { }
        // RVA: 0x03D7B530  token: 0x6000B91
        public static Unity.Mathematics.int2 op_Explicit(Unity.Mathematics.double2 v) { }
        // RVA: 0x03D82560  token: 0x6000B92
        public static Unity.Mathematics.int2 op_Multiply(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs) { }
        // RVA: 0x03D82540  token: 0x6000B93
        public static Unity.Mathematics.int2 op_Multiply(Unity.Mathematics.int2 lhs, System.Int32 rhs) { }
        // RVA: 0x03D4E4E0  token: 0x6000B94
        public static Unity.Mathematics.int2 op_Addition(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs) { }
        // RVA: 0x03D82500  token: 0x6000B95
        public static Unity.Mathematics.int2 op_Addition(Unity.Mathematics.int2 lhs, System.Int32 rhs) { }
        // RVA: 0x03D825B0  token: 0x6000B96
        public static Unity.Mathematics.int2 op_Subtraction(Unity.Mathematics.int2 lhs, System.Int32 rhs) { }
        // RVA: 0x09C72730  token: 0x6000B97
        public static Unity.Mathematics.int2 op_Division(Unity.Mathematics.int2 lhs, System.Int32 rhs) { }
        // RVA: 0x09C72774  token: 0x6000B98
        public static Unity.Mathematics.bool2 op_GreaterThan(Unity.Mathematics.int2 lhs, System.Int32 rhs) { }
        // RVA: 0x09C72754  token: 0x6000B99
        public static Unity.Mathematics.bool2 op_GreaterThanOrEqual(Unity.Mathematics.int2 lhs, System.Int32 rhs) { }
        // RVA: 0x03D825D0  token: 0x6000B9A
        public static Unity.Mathematics.int2 op_UnaryNegation(Unity.Mathematics.int2 val) { }
        // RVA: 0x03D82580  token: 0x6000B9B
        public static Unity.Mathematics.int2 op_RightShift(Unity.Mathematics.int2 x, System.Int32 n) { }
        // RVA: 0x03D82520  token: 0x6000B9C
        public static Unity.Mathematics.int2 op_BitwiseOr(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs) { }
        // RVA: 0x051404D0  token: 0x6000B9F
        public virtual System.Boolean Equals(Unity.Mathematics.int2 rhs) { }
        // RVA: 0x09C7254C  token: 0x6000BA0
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C725C0  token: 0x6000BA1
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C7267C  token: 0x6000BA2
        public virtual System.String ToString() { }
        // RVA: 0x09C725F4  token: 0x6000BA3
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x200003E  // size: 0x20
    public sealed struct int2x2 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.int2 c0;  // 0x10
        public Unity.Mathematics.int2 c1;  // 0x18
        public static readonly Unity.Mathematics.int2x2 identity;  // static @ 0x0

        // Methods
        // RVA: 0x03D4EA10  token: 0x6000BA4
        public System.Void .ctor(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1) { }
        // RVA: 0x03D82730  token: 0x6000BA5
        public System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11) { }
        // RVA: 0x03D82670  token: 0x6000BA6
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x09C72B34  token: 0x6000BA7
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C72AC4  token: 0x6000BA8
        public System.Void .ctor(Unity.Mathematics.bool2x2 v) { }
        // RVA: 0x03D82670  token: 0x6000BA9
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D82760  token: 0x6000BAA
        public System.Void .ctor(Unity.Mathematics.uint2x2 v) { }
        // RVA: 0x03D825F0  token: 0x6000BAB
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x03D826E0  token: 0x6000BAC
        public System.Void .ctor(Unity.Mathematics.float2x2 v) { }
        // RVA: 0x03D826A0  token: 0x6000BAD
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x03D82630  token: 0x6000BAE
        public System.Void .ctor(Unity.Mathematics.double2x2 v) { }
        // RVA: 0x09C6A4D4  token: 0x6000BAF
        public virtual System.Boolean Equals(Unity.Mathematics.int2x2 rhs) { }
        // RVA: 0x09C7278C  token: 0x6000BB0
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C727F8  token: 0x6000BB1
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C72814  token: 0x6000BB2
        public virtual System.String ToString() { }
        // RVA: 0x09C72970  token: 0x6000BB3
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x03CBAC80  token: 0x6000BB4
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200003F  // size: 0x28
    public sealed struct int2x3 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.int2 c0;  // 0x10
        public Unity.Mathematics.int2 c1;  // 0x18
        public Unity.Mathematics.int2 c2;  // 0x20

        // Properties
        Unity.Mathematics.int2& Item { get; /* RVA: 0x03D829E0 */ }

        // Methods
        // RVA: 0x03D54CF0  token: 0x6000BB5
        public System.Void .ctor(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1, Unity.Mathematics.int2 c2) { }
        // RVA: 0x03D82990  token: 0x6000BB6
        public System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12) { }
        // RVA: 0x03D82900  token: 0x6000BB7
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x09C73090  token: 0x6000BB8
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C72FF8  token: 0x6000BB9
        public System.Void .ctor(Unity.Mathematics.bool2x3 v) { }
        // RVA: 0x03D82900  token: 0x6000BBA
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D82940  token: 0x6000BBB
        public System.Void .ctor(Unity.Mathematics.uint2x3 v) { }
        // RVA: 0x03D82850  token: 0x6000BBC
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x03D828A0  token: 0x6000BBD
        public System.Void .ctor(Unity.Mathematics.float2x3 v) { }
        // RVA: 0x03D827A0  token: 0x6000BBE
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x03D827F0  token: 0x6000BBF
        public System.Void .ctor(Unity.Mathematics.double2x3 v) { }
        // RVA: 0x09C72B7C  token: 0x6000BC1
        public virtual System.Boolean Equals(Unity.Mathematics.int2x3 rhs) { }
        // RVA: 0x09C72BE0  token: 0x6000BC2
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C72C54  token: 0x6000BC3
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C72C7C  token: 0x6000BC4
        public virtual System.String ToString() { }
        // RVA: 0x09C72E44  token: 0x6000BC5
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000040  // size: 0x30
    public sealed struct int2x4 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.int2 c0;  // 0x10
        public Unity.Mathematics.int2 c1;  // 0x18
        public Unity.Mathematics.int2 c2;  // 0x20
        public Unity.Mathematics.int2 c3;  // 0x28

        // Methods
        // RVA: 0x03D4EA20  token: 0x6000BC6
        public System.Void .ctor(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1, Unity.Mathematics.int2 c2, Unity.Mathematics.int2 c3) { }
        // RVA: 0x03D82AE0  token: 0x6000BC7
        public System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13) { }
        // RVA: 0x03D82BC0  token: 0x6000BC8
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x09C73710  token: 0x6000BC9
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C73644  token: 0x6000BCA
        public System.Void .ctor(Unity.Mathematics.bool2x4 v) { }
        // RVA: 0x03D82BC0  token: 0x6000BCB
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D82A70  token: 0x6000BCC
        public System.Void .ctor(Unity.Mathematics.uint2x4 v) { }
        // RVA: 0x03D82C10  token: 0x6000BCD
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x03D829F0  token: 0x6000BCE
        public System.Void .ctor(Unity.Mathematics.float2x4 v) { }
        // RVA: 0x03D82C80  token: 0x6000BCF
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x03D82B40  token: 0x6000BD0
        public System.Void .ctor(Unity.Mathematics.double2x4 v) { }
        // RVA: 0x09C73168  token: 0x6000BD1
        public virtual System.Boolean Equals(Unity.Mathematics.int2x4 rhs) { }
        // RVA: 0x09C730F4  token: 0x6000BD2
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C731DC  token: 0x6000BD3
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C73414  token: 0x6000BD4
        public virtual System.String ToString() { }
        // RVA: 0x09C73200  token: 0x6000BD5
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000041  // size: 0x1C
    public sealed struct int3 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public System.Int32 x;  // 0x10
        public System.Int32 y;  // 0x14
        public System.Int32 z;  // 0x18
        public static readonly Unity.Mathematics.int3 zero;  // static @ 0x0

        // Properties
        Unity.Mathematics.int3 xyz { set; /* RVA: 0x03D51BE0 */ }
        Unity.Mathematics.int3 xzy { get; /* RVA: 0x03D807B0 */ }
        Unity.Mathematics.int2 xy { get; /* RVA: 0x03D5DE50 */ set; /* RVA: 0x03D824F0 */ }
        Unity.Mathematics.int2 yz { get; /* RVA: 0x03D82DA0 */ }
        Unity.Mathematics.int2 zx { get; /* RVA: 0x03D82DC0 */ }
        System.Int32 Item { get; /* RVA: 0x03D55FF0 */ set; /* RVA: 0x03D56010 */ }

        // Methods
        // RVA: 0x03D4E5D0  token: 0x6000BD6
        public System.Void .ctor(System.Int32 x, System.Int32 y, System.Int32 z) { }
        // RVA: 0x03D82CF0  token: 0x6000BD7
        public System.Void .ctor(System.Int32 x, Unity.Mathematics.int2 yz) { }
        // RVA: 0x03D82D90  token: 0x6000BD8
        public System.Void .ctor(Unity.Mathematics.int2 xy, System.Int32 z) { }
        // RVA: 0x03D51BE0  token: 0x6000BD9
        public System.Void .ctor(Unity.Mathematics.int3 xyz) { }
        // RVA: 0x03D82D60  token: 0x6000BDA
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x09C73998  token: 0x6000BDB
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C7396C  token: 0x6000BDC
        public System.Void .ctor(Unity.Mathematics.bool3 v) { }
        // RVA: 0x03D82D60  token: 0x6000BDD
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D51BE0  token: 0x6000BDE
        public System.Void .ctor(Unity.Mathematics.uint3 v) { }
        // RVA: 0x03D82D20  token: 0x6000BDF
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x03D82D00  token: 0x6000BE0
        public System.Void .ctor(Unity.Mathematics.float3 v) { }
        // RVA: 0x03D82D40  token: 0x6000BE1
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x03D82D70  token: 0x6000BE2
        public System.Void .ctor(Unity.Mathematics.double3 v) { }
        // RVA: 0x03D7B570  token: 0x6000BE3
        public static Unity.Mathematics.int3 op_Implicit(System.Int32 v) { }
        // RVA: 0x03D7B570  token: 0x6000BE4
        public static Unity.Mathematics.int3 op_Explicit(System.UInt32 v) { }
        // RVA: 0x03D7B5F0  token: 0x6000BE5
        public static Unity.Mathematics.int3 op_Explicit(Unity.Mathematics.uint3 v) { }
        // RVA: 0x03D7B640  token: 0x6000BE6
        public static Unity.Mathematics.int3 op_Explicit(System.Single v) { }
        // RVA: 0x03D7B580  token: 0x6000BE7
        public static Unity.Mathematics.int3 op_Explicit(Unity.Mathematics.float3 v) { }
        // RVA: 0x03D7B620  token: 0x6000BE8
        public static Unity.Mathematics.int3 op_Explicit(System.Double v) { }
        // RVA: 0x03D7B660  token: 0x6000BE9
        public static Unity.Mathematics.int3 op_Explicit(Unity.Mathematics.double3 v) { }
        // RVA: 0x0304D500  token: 0x6000BEA
        public static Unity.Mathematics.int3 op_Multiply(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs) { }
        // RVA: 0x03D82E30  token: 0x6000BEB
        public static Unity.Mathematics.int3 op_Multiply(Unity.Mathematics.int3 lhs, System.Int32 rhs) { }
        // RVA: 0x025BE440  token: 0x6000BEC
        public static Unity.Mathematics.int3 op_Addition(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs) { }
        // RVA: 0x03D82DE0  token: 0x6000BED
        public static Unity.Mathematics.int3 op_Addition(Unity.Mathematics.int3 lhs, System.Int32 rhs) { }
        // RVA: 0x03D82EA0  token: 0x6000BEE
        public static Unity.Mathematics.int3 op_Subtraction(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs) { }
        // RVA: 0x03D82E80  token: 0x6000BEF
        public static Unity.Mathematics.int3 op_Subtraction(Unity.Mathematics.int3 lhs, System.Int32 rhs) { }
        // RVA: 0x09C739AC  token: 0x6000BF0
        public static Unity.Mathematics.int3 op_Division(Unity.Mathematics.int3 lhs, System.Int32 rhs) { }
        // RVA: 0x09C73A8C  token: 0x6000BF1
        public static Unity.Mathematics.bool3 op_LessThanOrEqual(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs) { }
        // RVA: 0x09C73A20  token: 0x6000BF2
        public static Unity.Mathematics.bool3 op_GreaterThan(Unity.Mathematics.int3 lhs, System.Int32 rhs) { }
        // RVA: 0x09C739D4  token: 0x6000BF3
        public static Unity.Mathematics.bool3 op_GreaterThanOrEqual(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs) { }
        // RVA: 0x09C73A00  token: 0x6000BF4
        public static Unity.Mathematics.bool3 op_GreaterThanOrEqual(Unity.Mathematics.int3 lhs, System.Int32 rhs) { }
        // RVA: 0x03D82EC0  token: 0x6000BF5
        public static Unity.Mathematics.int3 op_UnaryNegation(Unity.Mathematics.int3 val) { }
        // RVA: 0x03D82E50  token: 0x6000BF6
        public static Unity.Mathematics.int3 op_RightShift(Unity.Mathematics.int3 x, System.Int32 n) { }
        // RVA: 0x09C73A60  token: 0x6000BF7
        public static Unity.Mathematics.bool3 op_Inequality(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs) { }
        // RVA: 0x09C73A40  token: 0x6000BF8
        public static Unity.Mathematics.bool3 op_Inequality(Unity.Mathematics.int3 lhs, System.Int32 rhs) { }
        // RVA: 0x03D82E10  token: 0x6000BF9
        public static Unity.Mathematics.int3 op_BitwiseOr(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs) { }
        // RVA: 0x051408A4  token: 0x6000C02
        public virtual System.Boolean Equals(Unity.Mathematics.int3 rhs) { }
        // RVA: 0x09C73794  token: 0x6000C03
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x05D00010  token: 0x6000C04
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C738B8  token: 0x6000C05
        public virtual System.String ToString() { }
        // RVA: 0x09C73808  token: 0x6000C06
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000043  // size: 0x28
    public sealed struct int3x2 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.int3 c0;  // 0x10
        public Unity.Mathematics.int3 c1;  // 0x1c

        // Methods
        // RVA: 0x03D4FF30  token: 0x6000C07
        public System.Void .ctor(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1) { }
        // RVA: 0x03D82EE0  token: 0x6000C08
        public System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11, System.Int32 m20, System.Int32 m21) { }
        // RVA: 0x03D82F70  token: 0x6000C09
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x04D29BD0  token: 0x6000C0A
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C73F48  token: 0x6000C0B
        public System.Void .ctor(Unity.Mathematics.bool3x2 v) { }
        // RVA: 0x03D82F70  token: 0x6000C0C
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x04D29DA0  token: 0x6000C0D
        public System.Void .ctor(Unity.Mathematics.uint3x2 v) { }
        // RVA: 0x03D82F20  token: 0x6000C0E
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D29E14  token: 0x6000C0F
        public System.Void .ctor(Unity.Mathematics.float3x2 v) { }
        // RVA: 0x03D82FA0  token: 0x6000C10
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C73ED0  token: 0x6000C11
        public System.Void .ctor(Unity.Mathematics.double3x2 v) { }
        // RVA: 0x0553EA68  token: 0x6000C12
        public virtual System.Boolean Equals(Unity.Mathematics.int3x2 rhs) { }
        // RVA: 0x09C73AB8  token: 0x6000C13
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C73B2C  token: 0x6000C14
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C73D08  token: 0x6000C15
        public virtual System.String ToString() { }
        // RVA: 0x09C73B54  token: 0x6000C16
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000044  // size: 0x34
    public sealed struct int3x3 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.int3 c0;  // 0x10
        public Unity.Mathematics.int3 c1;  // 0x1c
        public Unity.Mathematics.int3 c2;  // 0x28
        public static readonly Unity.Mathematics.int3x3 identity;  // static @ 0x0

        // Methods
        // RVA: 0x03D55290  token: 0x6000C17
        public System.Void .ctor(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1, Unity.Mathematics.int3 c2) { }
        // RVA: 0x03B6C9D0  token: 0x6000C18
        public System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m20, System.Int32 m21, System.Int32 m22) { }
        // RVA: 0x03D82FF0  token: 0x6000C19
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x04D2A078  token: 0x6000C1A
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C74610  token: 0x6000C1B
        public System.Void .ctor(Unity.Mathematics.bool3x3 v) { }
        // RVA: 0x03D82FF0  token: 0x6000C1C
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x04D2A108  token: 0x6000C1D
        public System.Void .ctor(Unity.Mathematics.uint3x3 v) { }
        // RVA: 0x03D830B0  token: 0x6000C1E
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D29FD4  token: 0x6000C1F
        public System.Void .ctor(Unity.Mathematics.float3x3 v) { }
        // RVA: 0x03D83040  token: 0x6000C20
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C74758  token: 0x6000C21
        public System.Void .ctor(Unity.Mathematics.double3x3 v) { }
        // RVA: 0x09C740B0  token: 0x6000C22
        public virtual System.Boolean Equals(Unity.Mathematics.int3x3 rhs) { }
        // RVA: 0x09C74034  token: 0x6000C23
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C7413C  token: 0x6000C24
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C743AC  token: 0x6000C25
        public virtual System.String ToString() { }
        // RVA: 0x09C74168  token: 0x6000C26
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x03B6CA30  token: 0x6000C27
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000045  // size: 0x40
    public sealed struct int3x4 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.int3 c0;  // 0x10
        public Unity.Mathematics.int3 c1;  // 0x1c
        public Unity.Mathematics.int3 c2;  // 0x28
        public Unity.Mathematics.int3 c3;  // 0x34

        // Methods
        // RVA: 0x03D81850  token: 0x6000C28
        public System.Void .ctor(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1, Unity.Mathematics.int3 c2, Unity.Mathematics.int3 c3) { }
        // RVA: 0x03D832A0  token: 0x6000C29
        public System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m23) { }
        // RVA: 0x03D831B0  token: 0x6000C2A
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x04D2A3FC  token: 0x6000C2B
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C74F44  token: 0x6000C2C
        public System.Void .ctor(Unity.Mathematics.bool3x4 v) { }
        // RVA: 0x03D831B0  token: 0x6000C2D
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x04D2A254  token: 0x6000C2E
        public System.Void .ctor(Unity.Mathematics.uint3x4 v) { }
        // RVA: 0x03D83120  token: 0x6000C2F
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D2A328  token: 0x6000C30
        public System.Void .ctor(Unity.Mathematics.float3x4 v) { }
        // RVA: 0x03D83210  token: 0x6000C31
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C750D8  token: 0x6000C32
        public System.Void .ctor(Unity.Mathematics.double3x4 v) { }
        // RVA: 0x09C7487C  token: 0x6000C33
        public virtual System.Boolean Equals(Unity.Mathematics.int3x4 rhs) { }
        // RVA: 0x09C74800  token: 0x6000C34
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C74940  token: 0x6000C35
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C74970  token: 0x6000C36
        public virtual System.String ToString() { }
        // RVA: 0x09C74C70  token: 0x6000C37
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000046  // size: 0x20
    public sealed struct int4 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public System.Int32 x;  // 0x10
        public System.Int32 y;  // 0x14
        public System.Int32 z;  // 0x18
        public System.Int32 w;  // 0x1c
        public static readonly Unity.Mathematics.int4 zero;  // static @ 0x0

        // Properties
        System.Int32 Item { get; /* RVA: 0x03D55FF0 */ set; /* RVA: 0x03D56010 */ }

        // Methods
        // RVA: 0x03D517E0  token: 0x6000C38
        public System.Void .ctor(System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w) { }
        // RVA: 0x03D83330  token: 0x6000C39
        public System.Void .ctor(System.Int32 x, System.Int32 y, Unity.Mathematics.int2 zw) { }
        // RVA: 0x03D83430  token: 0x6000C3A
        public System.Void .ctor(System.Int32 x, Unity.Mathematics.int2 yz, System.Int32 w) { }
        // RVA: 0x03D83400  token: 0x6000C3B
        public System.Void .ctor(System.Int32 x, Unity.Mathematics.int3 yzw) { }
        // RVA: 0x03D83450  token: 0x6000C3C
        public System.Void .ctor(Unity.Mathematics.int2 xy, System.Int32 z, System.Int32 w) { }
        // RVA: 0x03D83350  token: 0x6000C3D
        public System.Void .ctor(Unity.Mathematics.int2 xy, Unity.Mathematics.int2 zw) { }
        // RVA: 0x03D833E0  token: 0x6000C3E
        public System.Void .ctor(Unity.Mathematics.int3 xyz, System.Int32 w) { }
        // RVA: 0x03D5DBB0  token: 0x6000C3F
        public System.Void .ctor(Unity.Mathematics.int4 xyzw) { }
        // RVA: 0x03D83390  token: 0x6000C40
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x09C754EC  token: 0x6000C41
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C75508  token: 0x6000C42
        public System.Void .ctor(Unity.Mathematics.bool4 v) { }
        // RVA: 0x03D83390  token: 0x6000C43
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x03D5DBB0  token: 0x6000C44
        public System.Void .ctor(Unity.Mathematics.uint4 v) { }
        // RVA: 0x03D83370  token: 0x6000C45
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x03D83420  token: 0x6000C46
        public System.Void .ctor(Unity.Mathematics.float4 v) { }
        // RVA: 0x03D833A0  token: 0x6000C47
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x03D833C0  token: 0x6000C48
        public System.Void .ctor(Unity.Mathematics.double4 v) { }
        // RVA: 0x03D7B6A0  token: 0x6000C49
        public static Unity.Mathematics.int4 op_Implicit(System.Int32 v) { }
        // RVA: 0x03D7B6A0  token: 0x6000C4A
        public static Unity.Mathematics.int4 op_Explicit(System.UInt32 v) { }
        // RVA: 0x09C3D070  token: 0x6000C4B
        public static Unity.Mathematics.int4 op_Explicit(Unity.Mathematics.uint4 v) { }
        // RVA: 0x03D7B710  token: 0x6000C4C
        public static Unity.Mathematics.int4 op_Explicit(System.Single v) { }
        // RVA: 0x09C3D130  token: 0x6000C4D
        public static Unity.Mathematics.int4 op_Explicit(Unity.Mathematics.float4 v) { }
        // RVA: 0x03D7B6F0  token: 0x6000C4E
        public static Unity.Mathematics.int4 op_Explicit(System.Double v) { }
        // RVA: 0x09C3D100  token: 0x6000C4F
        public static Unity.Mathematics.int4 op_Explicit(Unity.Mathematics.double4 v) { }
        // RVA: 0x03D834D0  token: 0x6000C50
        public static Unity.Mathematics.int4 op_Multiply(Unity.Mathematics.int4 lhs, Unity.Mathematics.int4 rhs) { }
        // RVA: 0x03D83500  token: 0x6000C51
        public static Unity.Mathematics.int4 op_Multiply(Unity.Mathematics.int4 lhs, System.Int32 rhs) { }
        // RVA: 0x03D834A0  token: 0x6000C52
        public static Unity.Mathematics.int4 op_Addition(Unity.Mathematics.int4 lhs, Unity.Mathematics.int4 rhs) { }
        // RVA: 0x03D83470  token: 0x6000C53
        public static Unity.Mathematics.int4 op_Addition(Unity.Mathematics.int4 lhs, System.Int32 rhs) { }
        // RVA: 0x03D83560  token: 0x6000C54
        public static Unity.Mathematics.int4 op_Subtraction(Unity.Mathematics.int4 lhs, System.Int32 rhs) { }
        // RVA: 0x09C75570  token: 0x6000C55
        public static Unity.Mathematics.bool4 op_GreaterThan(Unity.Mathematics.int4 lhs, System.Int32 rhs) { }
        // RVA: 0x09C7554C  token: 0x6000C56
        public static Unity.Mathematics.bool4 op_GreaterThanOrEqual(Unity.Mathematics.int4 lhs, System.Int32 rhs) { }
        // RVA: 0x03D83590  token: 0x6000C57
        public static Unity.Mathematics.int4 op_UnaryNegation(Unity.Mathematics.int4 val) { }
        // RVA: 0x03D83530  token: 0x6000C58
        public static Unity.Mathematics.int4 op_RightShift(Unity.Mathematics.int4 x, System.Int32 n) { }
        // RVA: 0x028B58B0  token: 0x6000C59
        public static Unity.Mathematics.int4 op_BitwiseOr(Unity.Mathematics.int4 lhs, Unity.Mathematics.int4 rhs) { }
        // RVA: 0x05688F1C  token: 0x6000C5C
        public virtual System.Boolean Equals(Unity.Mathematics.int4 rhs) { }
        // RVA: 0x09C751B4  token: 0x6000C5D
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C75220  token: 0x6000C5E
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C7523C  token: 0x6000C5F
        public virtual System.String ToString() { }
        // RVA: 0x09C75398  token: 0x6000C60
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000048  // size: 0x30
    public sealed struct int4x2 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.int4 c0;  // 0x10
        public Unity.Mathematics.int4 c1;  // 0x20

        // Methods
        // RVA: 0x03D553F0  token: 0x6000C61
        public System.Void .ctor(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1) { }
        // RVA: 0x03D83620  token: 0x6000C62
        public System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11, System.Int32 m20, System.Int32 m21, System.Int32 m30, System.Int32 m31) { }
        // RVA: 0x03D835C0  token: 0x6000C63
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x04D2A7F8  token: 0x6000C64
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D2A77C  token: 0x6000C65
        public System.Void .ctor(Unity.Mathematics.bool4x2 v) { }
        // RVA: 0x03D835C0  token: 0x6000C66
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x09C75B18  token: 0x6000C67
        public System.Void .ctor(Unity.Mathematics.uint4x2 v) { }
        // RVA: 0x03D83600  token: 0x6000C68
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D2A8E8  token: 0x6000C69
        public System.Void .ctor(Unity.Mathematics.float4x2 v) { }
        // RVA: 0x03D83670  token: 0x6000C6A
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C75AB4  token: 0x6000C6B
        public System.Void .ctor(Unity.Mathematics.double4x2 v) { }
        // RVA: 0x02293840  token: 0x6000C6C
        public static Unity.Mathematics.int4x2 op_Implicit(System.Int32 v) { }
        // RVA: 0x09C75594  token: 0x6000C6D
        public virtual System.Boolean Equals(Unity.Mathematics.int4x2 rhs) { }
        // RVA: 0x09C755D8  token: 0x6000C6E
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C7564C  token: 0x6000C6F
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C75670  token: 0x6000C70
        public virtual System.String ToString() { }
        // RVA: 0x09C758A0  token: 0x6000C71
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000049  // size: 0x40
    public sealed struct int4x3 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.int4 c0;  // 0x10
        public Unity.Mathematics.int4 c1;  // 0x20
        public Unity.Mathematics.int4 c2;  // 0x30

        // Methods
        // RVA: 0x03D6B600  token: 0x6000C72
        public System.Void .ctor(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1, Unity.Mathematics.int4 c2) { }
        // RVA: 0x03D83750  token: 0x6000C73
        public System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m30, System.Int32 m31, System.Int32 m32) { }
        // RVA: 0x03D837D0  token: 0x6000C74
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x04D2AA28  token: 0x6000C75
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D2A970  token: 0x6000C76
        public System.Void .ctor(Unity.Mathematics.bool4x3 v) { }
        // RVA: 0x03D837D0  token: 0x6000C77
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x09C76260  token: 0x6000C78
        public System.Void .ctor(Unity.Mathematics.uint4x3 v) { }
        // RVA: 0x03D83820  token: 0x6000C79
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D2AAE4  token: 0x6000C7A
        public System.Void .ctor(Unity.Mathematics.float4x3 v) { }
        // RVA: 0x03D836D0  token: 0x6000C7B
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C762E8  token: 0x6000C7C
        public System.Void .ctor(Unity.Mathematics.double4x3 v) { }
        // RVA: 0x09C75BFC  token: 0x6000C7D
        public virtual System.Boolean Equals(Unity.Mathematics.int4x3 rhs) { }
        // RVA: 0x09C75B80  token: 0x6000C7E
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C75C5C  token: 0x6000C7F
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C75F60  token: 0x6000C80
        public virtual System.String ToString() { }
        // RVA: 0x09C75C8C  token: 0x6000C81
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x200004A  // size: 0x50
    public sealed struct int4x4 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.int4 c0;  // 0x10
        public Unity.Mathematics.int4 c1;  // 0x20
        public Unity.Mathematics.int4 c2;  // 0x30
        public Unity.Mathematics.int4 c3;  // 0x40
        public static readonly Unity.Mathematics.int4x4 identity;  // static @ 0x0

        // Methods
        // RVA: 0x03D7E4A0  token: 0x6000C82
        public System.Void .ctor(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1, Unity.Mathematics.int4 c2, Unity.Mathematics.int4 c3) { }
        // RVA: 0x03A4DCE0  token: 0x6000C83
        public System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m23, System.Int32 m30, System.Int32 m31, System.Int32 m32, System.Int32 m33) { }
        // RVA: 0x03D83900  token: 0x6000C84
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x04D2AC34  token: 0x6000C85
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D2AD24  token: 0x6000C86
        public System.Void .ctor(Unity.Mathematics.bool4x4 v) { }
        // RVA: 0x03D83900  token: 0x6000C87
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x09C76C10  token: 0x6000C88
        public System.Void .ctor(Unity.Mathematics.uint4x4 v) { }
        // RVA: 0x03D83960  token: 0x6000C89
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D2AEC0  token: 0x6000C8A
        public System.Void .ctor(Unity.Mathematics.float4x4 v) { }
        // RVA: 0x03D83850  token: 0x6000C8B
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C76CBC  token: 0x6000C8C
        public System.Void .ctor(Unity.Mathematics.double4x4 v) { }
        // RVA: 0x09C763F8  token: 0x6000C8D
        public virtual System.Boolean Equals(Unity.Mathematics.int4x4 rhs) { }
        // RVA: 0x09C76374  token: 0x6000C8E
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C76474  token: 0x6000C8F
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C76840  token: 0x6000C90
        public virtual System.String ToString() { }
        // RVA: 0x09C764AC  token: 0x6000C91
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x03A4DD90  token: 0x6000C92
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200004B  // size: 0x20
    public sealed struct quaternion : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.float4 value;  // 0x10
        public static readonly Unity.Mathematics.quaternion identity;  // static @ 0x0

        // Methods
        // RVA: 0x0294BC80  token: 0x6000C93
        public static UnityEngine.Quaternion op_Implicit(Unity.Mathematics.quaternion q) { }
        // RVA: 0x0294BC80  token: 0x6000C94
        public static Unity.Mathematics.quaternion op_Implicit(UnityEngine.Quaternion q) { }
        // RVA: 0x03D516B0  token: 0x6000C95
        public System.Void .ctor(System.Single x, System.Single y, System.Single z, System.Single w) { }
        // RVA: 0x03D5E620  token: 0x6000C96
        public System.Void .ctor(Unity.Mathematics.float4 value) { }
        // RVA: 0x03D5B250  token: 0x6000C97
        public static Unity.Mathematics.quaternion op_Implicit(Unity.Mathematics.float4 v) { }
        // RVA: 0x028B5440  token: 0x6000C98
        public System.Void .ctor(Unity.Mathematics.float3x3 m) { }
        // RVA: 0x09C7C788  token: 0x6000C99
        public System.Void .ctor(Unity.Mathematics.float4x4 m) { }
        // RVA: 0x050C94C0  token: 0x6000C9A
        public static Unity.Mathematics.quaternion AxisAngle(Unity.Mathematics.float3 axis, System.Single angle) { }
        // RVA: 0x050C95CC  token: 0x6000C9B
        public static Unity.Mathematics.quaternion EulerXYZ(Unity.Mathematics.float3 xyz) { }
        // RVA: 0x050C97AC  token: 0x6000C9C
        public static Unity.Mathematics.quaternion EulerXZY(Unity.Mathematics.float3 xyz) { }
        // RVA: 0x050C998C  token: 0x6000C9D
        public static Unity.Mathematics.quaternion EulerYXZ(Unity.Mathematics.float3 xyz) { }
        // RVA: 0x050C9B6C  token: 0x6000C9E
        public static Unity.Mathematics.quaternion EulerYZX(Unity.Mathematics.float3 xyz) { }
        // RVA: 0x09C7BC88  token: 0x6000C9F
        public static Unity.Mathematics.quaternion EulerZXY(Unity.Mathematics.float3 xyz) { }
        // RVA: 0x050C9D84  token: 0x6000CA0
        public static Unity.Mathematics.quaternion EulerZYX(Unity.Mathematics.float3 xyz) { }
        // RVA: 0x09C7BBA8  token: 0x6000CA1
        public static Unity.Mathematics.quaternion EulerXYZ(System.Single x, System.Single y, System.Single z) { }
        // RVA: 0x09C7BBE0  token: 0x6000CA2
        public static Unity.Mathematics.quaternion EulerXZY(System.Single x, System.Single y, System.Single z) { }
        // RVA: 0x09C7BC18  token: 0x6000CA3
        public static Unity.Mathematics.quaternion EulerYXZ(System.Single x, System.Single y, System.Single z) { }
        // RVA: 0x09C7BC50  token: 0x6000CA4
        public static Unity.Mathematics.quaternion EulerYZX(System.Single x, System.Single y, System.Single z) { }
        // RVA: 0x050C9D4C  token: 0x6000CA5
        public static Unity.Mathematics.quaternion EulerZXY(System.Single x, System.Single y, System.Single z) { }
        // RVA: 0x09C7BE68  token: 0x6000CA6
        public static Unity.Mathematics.quaternion EulerZYX(System.Single x, System.Single y, System.Single z) { }
        // RVA: 0x09C7BEDC  token: 0x6000CA7
        public static Unity.Mathematics.quaternion Euler(Unity.Mathematics.float3 xyz, Unity.Mathematics.math.RotationOrder order) { }
        // RVA: 0x09C7BEA0  token: 0x6000CA8
        public static Unity.Mathematics.quaternion Euler(System.Single x, System.Single y, System.Single z, Unity.Mathematics.math.RotationOrder order) { }
        // RVA: 0x050C9F64  token: 0x6000CA9
        public static Unity.Mathematics.quaternion RotateX(System.Single angle) { }
        // RVA: 0x09C7C464  token: 0x6000CAA
        public static Unity.Mathematics.quaternion RotateY(System.Single angle) { }
        // RVA: 0x050C9FC8  token: 0x6000CAB
        public static Unity.Mathematics.quaternion RotateZ(System.Single angle) { }
        // RVA: 0x09C7C348  token: 0x6000CAC
        public static Unity.Mathematics.quaternion LookRotation(Unity.Mathematics.float3 forward, Unity.Mathematics.float3 up) { }
        // RVA: 0x09C7C038  token: 0x6000CAD
        public static Unity.Mathematics.quaternion LookRotationSafe(Unity.Mathematics.float3 forward, Unity.Mathematics.float3 up) { }
        // RVA: 0x022CDA10  token: 0x6000CAE
        public virtual System.Boolean Equals(Unity.Mathematics.quaternion x) { }
        // RVA: 0x09C7BB3C  token: 0x6000CAF
        public virtual System.Boolean Equals(System.Object x) { }
        // RVA: 0x09C38878  token: 0x6000CB0
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C7C4C8  token: 0x6000CB1
        public virtual System.String ToString() { }
        // RVA: 0x09C7C634  token: 0x6000CB2
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x03D3AA20  token: 0x6000CB3
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200004C  // size: 0x10
    public static class noise
    {
        // Methods
        // RVA: 0x09C7A550  token: 0x6000CB4
        public static System.Single cnoise(Unity.Mathematics.float2 P) { }
        // RVA: 0x09C7AE40  token: 0x6000CB5
        public static System.Single pnoise(Unity.Mathematics.float2 P, Unity.Mathematics.float2 rep) { }
        // RVA: 0x09C7ABF0  token: 0x6000CB6
        private static Unity.Mathematics.float2 mod289(Unity.Mathematics.float2 x) { }
        // RVA: 0x09C7AB24  token: 0x6000CB7
        private static Unity.Mathematics.float3 mod289(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C7AC40  token: 0x6000CB8
        private static Unity.Mathematics.float4 mod289(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C7AD7C  token: 0x6000CB9
        private static Unity.Mathematics.float3 permute(Unity.Mathematics.float3 x) { }
        // RVA: 0x09C7ACE4  token: 0x6000CBA
        private static Unity.Mathematics.float4 permute(Unity.Mathematics.float4 x) { }
        // RVA: 0x09C7BAE4  token: 0x6000CBB
        private static Unity.Mathematics.float4 taylorInvSqrt(Unity.Mathematics.float4 r) { }
        // RVA: 0x09C7AAA8  token: 0x6000CBC
        private static Unity.Mathematics.float2 fade(Unity.Mathematics.float2 t) { }
        // RVA: 0x09C7B3D4  token: 0x6000CBD
        public static System.Single snoise(Unity.Mathematics.float2 v) { }

    }

    // TypeToken: 0x200004D  // size: 0x14
    public sealed struct Random
    {
        // Fields
        public System.UInt32 state;  // 0x10

        // Methods
        // RVA: 0x03D839D0  token: 0x6000CBE
        public System.Void .ctor(System.UInt32 seed) { }
        // RVA: 0x09C7A118  token: 0x6000CBF
        public static Unity.Mathematics.Random CreateFromIndex(System.UInt32 index) { }
        // RVA: 0x03C843E0  token: 0x6000CC0
        private static System.UInt32 WangHash(System.UInt32 n) { }
        // RVA: 0x02AF8270  token: 0x6000CC1
        public System.Single NextFloat() { }
        // RVA: 0x062C603C  token: 0x6000CC2
        public Unity.Mathematics.float3 NextFloat3() { }
        // RVA: 0x03D839A0  token: 0x6000CC3
        private System.UInt32 NextState() { }

    }

    // TypeToken: 0x200004E  // size: 0x2C
    public sealed struct RigidTransform
    {
        // Fields
        public Unity.Mathematics.quaternion rot;  // 0x10
        public Unity.Mathematics.float3 pos;  // 0x20
        public static readonly Unity.Mathematics.RigidTransform identity;  // static @ 0x0

        // Methods
        // RVA: 0x03D839F0  token: 0x6000CC4
        public System.Void .ctor(Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 translation) { }
        // RVA: 0x09C7A470  token: 0x6000CC5
        public System.Void .ctor(Unity.Mathematics.float3x3 rotation, Unity.Mathematics.float3 translation) { }
        // RVA: 0x09C7A4D4  token: 0x6000CC6
        public System.Void .ctor(Unity.Mathematics.float4x4 transform) { }
        // RVA: 0x09C7A1BC  token: 0x6000CC7
        public System.Boolean Equals(Unity.Mathematics.RigidTransform x) { }
        // RVA: 0x09C7A140  token: 0x6000CC8
        public virtual System.Boolean Equals(System.Object x) { }
        // RVA: 0x09C7A20C  token: 0x6000CC9
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C7A258  token: 0x6000CCA
        public virtual System.String ToString() { }
        // RVA: 0x03D21080  token: 0x6000CCB
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200004F  // size: 0x10
    public static class svd
    {
        // Methods
        // RVA: 0x04D5EC88  token: 0x6000CCC
        private static System.Void condSwap(System.Boolean c, System.Single& x, System.Single& y) { }
        // RVA: 0x04D5EC14  token: 0x6000CCD
        private static System.Void condNegSwap(System.Boolean c, Unity.Mathematics.float3& x, Unity.Mathematics.float3& y) { }
        // RVA: 0x09C7CB4C  token: 0x6000CCE
        private static Unity.Mathematics.quaternion condNegSwapQuat(System.Boolean c, Unity.Mathematics.quaternion q, Unity.Mathematics.float4 mask) { }
        // RVA: 0x09C7D718  token: 0x6000CCF
        private static System.Void sortSingularValues(Unity.Mathematics.float3x3& b, Unity.Mathematics.quaternion& v) { }
        // RVA: 0x09C7CAA8  token: 0x6000CD0
        private static Unity.Mathematics.quaternion approxGivensQuat(Unity.Mathematics.float3 pq, Unity.Mathematics.float4 mask) { }
        // RVA: 0x09C7D320  token: 0x6000CD1
        private static Unity.Mathematics.quaternion qrGivensQuat(Unity.Mathematics.float2 pq, Unity.Mathematics.float4 mask) { }
        // RVA: 0x09C7CC08  token: 0x6000CD2
        private static Unity.Mathematics.quaternion givensQRFactorization(Unity.Mathematics.float3x3 b, Unity.Mathematics.float3x3& r) { }
        // RVA: 0x09C7CEB0  token: 0x6000CD3
        private static Unity.Mathematics.quaternion jacobiIteration(Unity.Mathematics.float3x3& s, System.Int32 iterations) { }
        // RVA: 0x09C7D52C  token: 0x6000CD4
        private static Unity.Mathematics.float3 singularValuesDecomposition(Unity.Mathematics.float3x3 a, Unity.Mathematics.quaternion& u, Unity.Mathematics.quaternion& v) { }
        // RVA: 0x09C7D41C  token: 0x6000CD5
        private static Unity.Mathematics.float3 rcpsafe(Unity.Mathematics.float3 x, System.Single epsilon) { }
        // RVA: 0x09C7D8C0  token: 0x6000CD6
        public static Unity.Mathematics.float3x3 svdInverse(Unity.Mathematics.float3x3 a) { }
        // RVA: 0x09C7DA88  token: 0x6000CD7
        public static Unity.Mathematics.quaternion svdRotation(Unity.Mathematics.float3x3 a) { }

    }

    // TypeToken: 0x2000050  // size: 0x18
    public sealed struct uint2 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public System.UInt32 x;  // 0x10
        public System.UInt32 y;  // 0x14

        // Methods
        // RVA: 0x03D4E4B0  token: 0x6000CD8
        public System.Void .ctor(System.UInt32 x, System.UInt32 y) { }
        // RVA: 0x03D824F0  token: 0x6000CD9
        public System.Void .ctor(Unity.Mathematics.uint2 xy) { }
        // RVA: 0x03D82490  token: 0x6000CDA
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x09C72704  token: 0x6000CDB
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C72714  token: 0x6000CDC
        public System.Void .ctor(Unity.Mathematics.bool2 v) { }
        // RVA: 0x03D82490  token: 0x6000CDD
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D824F0  token: 0x6000CDE
        public System.Void .ctor(Unity.Mathematics.int2 v) { }
        // RVA: 0x04D5F760  token: 0x6000CDF
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x09C7DCFC  token: 0x6000CE0
        public System.Void .ctor(Unity.Mathematics.float2 v) { }
        // RVA: 0x09C7DCE0  token: 0x6000CE1
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C7DD38  token: 0x6000CE2
        public System.Void .ctor(Unity.Mathematics.double2 v) { }
        // RVA: 0x03D7B520  token: 0x6000CE3
        public static Unity.Mathematics.uint2 op_Implicit(System.UInt32 v) { }
        // RVA: 0x03D7B520  token: 0x6000CE4
        public static Unity.Mathematics.uint2 op_Explicit(System.Int32 v) { }
        // RVA: 0x03D76940  token: 0x6000CE5
        public static Unity.Mathematics.uint2 op_Explicit(Unity.Mathematics.int2 v) { }
        // RVA: 0x09C57A68  token: 0x6000CE6
        public static Unity.Mathematics.uint2 op_Explicit(System.Single v) { }
        // RVA: 0x09C57A8C  token: 0x6000CE7
        public static Unity.Mathematics.uint2 op_Explicit(Unity.Mathematics.float2 v) { }
        // RVA: 0x09C57A48  token: 0x6000CE8
        public static Unity.Mathematics.uint2 op_Explicit(System.Double v) { }
        // RVA: 0x09C57A18  token: 0x6000CE9
        public static Unity.Mathematics.uint2 op_Explicit(Unity.Mathematics.double2 v) { }
        // RVA: 0x03D82560  token: 0x6000CEA
        public static Unity.Mathematics.uint2 op_Multiply(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs) { }
        // RVA: 0x03D82540  token: 0x6000CEB
        public static Unity.Mathematics.uint2 op_Multiply(Unity.Mathematics.uint2 lhs, System.UInt32 rhs) { }
        // RVA: 0x03D4E4E0  token: 0x6000CEC
        public static Unity.Mathematics.uint2 op_Addition(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs) { }
        // RVA: 0x03D82500  token: 0x6000CED
        public static Unity.Mathematics.uint2 op_Addition(Unity.Mathematics.uint2 lhs, System.UInt32 rhs) { }
        // RVA: 0x03D4E500  token: 0x6000CEE
        public static Unity.Mathematics.uint2 op_Subtraction(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs) { }
        // RVA: 0x03D825B0  token: 0x6000CEF
        public static Unity.Mathematics.uint2 op_Subtraction(Unity.Mathematics.uint2 lhs, System.UInt32 rhs) { }
        // RVA: 0x09C7DD74  token: 0x6000CF0
        public static Unity.Mathematics.bool2 op_GreaterThan(Unity.Mathematics.uint2 lhs, System.UInt32 rhs) { }
        // RVA: 0x03D83A50  token: 0x6000CF1
        public static Unity.Mathematics.uint2 op_LeftShift(Unity.Mathematics.uint2 x, System.Int32 n) { }
        // RVA: 0x03D83A80  token: 0x6000CF2
        public static Unity.Mathematics.uint2 op_RightShift(Unity.Mathematics.uint2 x, System.Int32 n) { }
        // RVA: 0x09C7DD5C  token: 0x6000CF3
        public static Unity.Mathematics.bool2 op_Equality(Unity.Mathematics.uint2 lhs, System.UInt32 rhs) { }
        // RVA: 0x03D83A10  token: 0x6000CF4
        public static Unity.Mathematics.uint2 op_BitwiseAnd(Unity.Mathematics.uint2 lhs, System.UInt32 rhs) { }
        // RVA: 0x03D82520  token: 0x6000CF5
        public static Unity.Mathematics.uint2 op_BitwiseOr(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs) { }
        // RVA: 0x03D83A30  token: 0x6000CF6
        public static Unity.Mathematics.uint2 op_ExclusiveOr(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs) { }
        // RVA: 0x051404D0  token: 0x6000CF7
        public virtual System.Boolean Equals(Unity.Mathematics.uint2 rhs) { }
        // RVA: 0x09C7DB28  token: 0x6000CF8
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C7DB9C  token: 0x6000CF9
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C7DC58  token: 0x6000CFA
        public virtual System.String ToString() { }
        // RVA: 0x09C7DBD0  token: 0x6000CFB
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000052  // size: 0x20
    public sealed struct uint2x2 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.uint2 c0;  // 0x10
        public Unity.Mathematics.uint2 c1;  // 0x18
        public static readonly Unity.Mathematics.uint2x2 identity;  // static @ 0x0

        // Methods
        // RVA: 0x03D4EA10  token: 0x6000CFC
        public System.Void .ctor(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1) { }
        // RVA: 0x03D82730  token: 0x6000CFD
        public System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11) { }
        // RVA: 0x03D82670  token: 0x6000CFE
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x09C72B34  token: 0x6000CFF
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C72AC4  token: 0x6000D00
        public System.Void .ctor(Unity.Mathematics.bool2x2 v) { }
        // RVA: 0x03D82670  token: 0x6000D01
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D82760  token: 0x6000D02
        public System.Void .ctor(Unity.Mathematics.int2x2 v) { }
        // RVA: 0x04D5F8F8  token: 0x6000D03
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D5F8C0  token: 0x6000D04
        public System.Void .ctor(Unity.Mathematics.float2x2 v) { }
        // RVA: 0x09C7E11C  token: 0x6000D05
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C7E0C4  token: 0x6000D06
        public System.Void .ctor(Unity.Mathematics.double2x2 v) { }
        // RVA: 0x09C6A4D4  token: 0x6000D07
        public virtual System.Boolean Equals(Unity.Mathematics.uint2x2 rhs) { }
        // RVA: 0x09C7DD8C  token: 0x6000D08
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C7DDF8  token: 0x6000D09
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C7DF68  token: 0x6000D0A
        public virtual System.String ToString() { }
        // RVA: 0x09C7DE14  token: 0x6000D0B
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x03CBAC20  token: 0x6000D0C
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000053  // size: 0x28
    public sealed struct uint2x3 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.uint2 c0;  // 0x10
        public Unity.Mathematics.uint2 c1;  // 0x18
        public Unity.Mathematics.uint2 c2;  // 0x20

        // Methods
        // RVA: 0x03D54CF0  token: 0x6000D0D
        public System.Void .ctor(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1, Unity.Mathematics.uint2 c2) { }
        // RVA: 0x03D82990  token: 0x6000D0E
        public System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12) { }
        // RVA: 0x03D82900  token: 0x6000D0F
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x09C73090  token: 0x6000D10
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C72FF8  token: 0x6000D11
        public System.Void .ctor(Unity.Mathematics.bool2x3 v) { }
        // RVA: 0x03D82900  token: 0x6000D12
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D82940  token: 0x6000D13
        public System.Void .ctor(Unity.Mathematics.int2x3 v) { }
        // RVA: 0x04D5F9D8  token: 0x6000D14
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D5F920  token: 0x6000D15
        public System.Void .ctor(Unity.Mathematics.float2x3 v) { }
        // RVA: 0x09C7E578  token: 0x6000D16
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C7E5D4  token: 0x6000D17
        public System.Void .ctor(Unity.Mathematics.double2x3 v) { }
        // RVA: 0x09C72B7C  token: 0x6000D18
        public virtual System.Boolean Equals(Unity.Mathematics.uint2x3 rhs) { }
        // RVA: 0x09C7E160  token: 0x6000D19
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C7E1D4  token: 0x6000D1A
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C7E1FC  token: 0x6000D1B
        public virtual System.String ToString() { }
        // RVA: 0x09C7E3C4  token: 0x6000D1C
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000054  // size: 0x30
    public sealed struct uint2x4 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.uint2 c0;  // 0x10
        public Unity.Mathematics.uint2 c1;  // 0x18
        public Unity.Mathematics.uint2 c2;  // 0x20
        public Unity.Mathematics.uint2 c3;  // 0x28

        // Methods
        // RVA: 0x03D4EA20  token: 0x6000D1D
        public System.Void .ctor(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1, Unity.Mathematics.uint2 c2, Unity.Mathematics.uint2 c3) { }
        // RVA: 0x03D82AE0  token: 0x6000D1E
        public System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13) { }
        // RVA: 0x03D82BC0  token: 0x6000D1F
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x09C73710  token: 0x6000D20
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C73644  token: 0x6000D21
        public System.Void .ctor(Unity.Mathematics.bool2x4 v) { }
        // RVA: 0x03D82BC0  token: 0x6000D22
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D82A70  token: 0x6000D23
        public System.Void .ctor(Unity.Mathematics.int2x4 v) { }
        // RVA: 0x04D5FBB0  token: 0x6000D24
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D5FBF0  token: 0x6000D25
        public System.Void .ctor(Unity.Mathematics.float2x4 v) { }
        // RVA: 0x09C7EBCC  token: 0x6000D26
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C7EB2C  token: 0x6000D27
        public System.Void .ctor(Unity.Mathematics.double2x4 v) { }
        // RVA: 0x09C73168  token: 0x6000D28
        public virtual System.Boolean Equals(Unity.Mathematics.uint2x4 rhs) { }
        // RVA: 0x09C7E650  token: 0x6000D29
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C7E6C4  token: 0x6000D2A
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C7E6E8  token: 0x6000D2B
        public virtual System.String ToString() { }
        // RVA: 0x09C7E918  token: 0x6000D2C
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000055  // size: 0x1C
    public sealed struct uint3 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public System.UInt32 x;  // 0x10
        public System.UInt32 y;  // 0x14
        public System.UInt32 z;  // 0x18

        // Properties
        Unity.Mathematics.uint4 xyzz { get; /* RVA: 0x03D80710 */ }
        System.UInt32 Item { get; /* RVA: 0x03D55FF0 */ set; /* RVA: 0x03D56010 */ }

        // Methods
        // RVA: 0x03D4E5D0  token: 0x6000D2D
        public System.Void .ctor(System.UInt32 x, System.UInt32 y, System.UInt32 z) { }
        // RVA: 0x03D82CF0  token: 0x6000D2E
        public System.Void .ctor(System.UInt32 x, Unity.Mathematics.uint2 yz) { }
        // RVA: 0x03D82D90  token: 0x6000D2F
        public System.Void .ctor(Unity.Mathematics.uint2 xy, System.UInt32 z) { }
        // RVA: 0x03D51BE0  token: 0x6000D30
        public System.Void .ctor(Unity.Mathematics.uint3 xyz) { }
        // RVA: 0x03D82D60  token: 0x6000D31
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x09C73998  token: 0x6000D32
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C7396C  token: 0x6000D33
        public System.Void .ctor(Unity.Mathematics.bool3 v) { }
        // RVA: 0x03D82D60  token: 0x6000D34
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D51BE0  token: 0x6000D35
        public System.Void .ctor(Unity.Mathematics.int3 v) { }
        // RVA: 0x04D5FCB0  token: 0x6000D36
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D5FC64  token: 0x6000D37
        public System.Void .ctor(Unity.Mathematics.float3 v) { }
        // RVA: 0x09C7EE90  token: 0x6000D38
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C7EE60  token: 0x6000D39
        public System.Void .ctor(Unity.Mathematics.double3 v) { }
        // RVA: 0x03D7B570  token: 0x6000D3A
        public static Unity.Mathematics.uint3 op_Implicit(System.UInt32 v) { }
        // RVA: 0x03D7B570  token: 0x6000D3B
        public static Unity.Mathematics.uint3 op_Explicit(System.Int32 v) { }
        // RVA: 0x03D7B5F0  token: 0x6000D3C
        public static Unity.Mathematics.uint3 op_Explicit(Unity.Mathematics.int3 v) { }
        // RVA: 0x09C57D5C  token: 0x6000D3D
        public static Unity.Mathematics.uint3 op_Explicit(System.Single v) { }
        // RVA: 0x04D5FCE8  token: 0x6000D3E
        public static Unity.Mathematics.uint3 op_Explicit(Unity.Mathematics.float3 v) { }
        // RVA: 0x09C57D34  token: 0x6000D3F
        public static Unity.Mathematics.uint3 op_Explicit(System.Double v) { }
        // RVA: 0x09C57CFC  token: 0x6000D40
        public static Unity.Mathematics.uint3 op_Explicit(Unity.Mathematics.double3 v) { }
        // RVA: 0x0304D500  token: 0x6000D41
        public static Unity.Mathematics.uint3 op_Multiply(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs) { }
        // RVA: 0x03D82E30  token: 0x6000D42
        public static Unity.Mathematics.uint3 op_Multiply(Unity.Mathematics.uint3 lhs, System.UInt32 rhs) { }
        // RVA: 0x025BE440  token: 0x6000D43
        public static Unity.Mathematics.uint3 op_Addition(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs) { }
        // RVA: 0x03D82DE0  token: 0x6000D44
        public static Unity.Mathematics.uint3 op_Addition(Unity.Mathematics.uint3 lhs, System.UInt32 rhs) { }
        // RVA: 0x03D82EA0  token: 0x6000D45
        public static Unity.Mathematics.uint3 op_Subtraction(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs) { }
        // RVA: 0x03D82E80  token: 0x6000D46
        public static Unity.Mathematics.uint3 op_Subtraction(Unity.Mathematics.uint3 lhs, System.UInt32 rhs) { }
        // RVA: 0x09C7EED4  token: 0x6000D47
        public static Unity.Mathematics.bool3 op_GreaterThan(Unity.Mathematics.uint3 lhs, System.UInt32 rhs) { }
        // RVA: 0x03D83AF0  token: 0x6000D48
        public static Unity.Mathematics.uint3 op_LeftShift(Unity.Mathematics.uint3 x, System.Int32 n) { }
        // RVA: 0x03D83B20  token: 0x6000D49
        public static Unity.Mathematics.uint3 op_RightShift(Unity.Mathematics.uint3 x, System.Int32 n) { }
        // RVA: 0x09C7EEB4  token: 0x6000D4A
        public static Unity.Mathematics.bool3 op_Equality(Unity.Mathematics.uint3 lhs, System.UInt32 rhs) { }
        // RVA: 0x03D83AB0  token: 0x6000D4B
        public static Unity.Mathematics.uint3 op_BitwiseAnd(Unity.Mathematics.uint3 lhs, System.UInt32 rhs) { }
        // RVA: 0x03D82E10  token: 0x6000D4C
        public static Unity.Mathematics.uint3 op_BitwiseOr(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs) { }
        // RVA: 0x03D83AD0  token: 0x6000D4D
        public static Unity.Mathematics.uint3 op_BitwiseOr(System.UInt32 lhs, Unity.Mathematics.uint3 rhs) { }
        // RVA: 0x028B79E0  token: 0x6000D4E
        public static Unity.Mathematics.uint3 op_ExclusiveOr(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs) { }
        // RVA: 0x051408A4  token: 0x6000D52
        public virtual System.Boolean Equals(Unity.Mathematics.uint3 rhs) { }
        // RVA: 0x09C7EC44  token: 0x6000D53
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C7ECD8  token: 0x6000D54
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C7EDAC  token: 0x6000D55
        public virtual System.String ToString() { }
        // RVA: 0x09C7ECFC  token: 0x6000D56
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000057  // size: 0x28
    public sealed struct uint3x2 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.uint3 c0;  // 0x10
        public Unity.Mathematics.uint3 c1;  // 0x1c

        // Methods
        // RVA: 0x03D4FF30  token: 0x6000D57
        public System.Void .ctor(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1) { }
        // RVA: 0x03D82EE0  token: 0x6000D58
        public System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11, System.UInt32 m20, System.UInt32 m21) { }
        // RVA: 0x03D82F70  token: 0x6000D59
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x04D29BD0  token: 0x6000D5A
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C73F48  token: 0x6000D5B
        public System.Void .ctor(Unity.Mathematics.bool3x2 v) { }
        // RVA: 0x03D82F70  token: 0x6000D5C
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x04D29DA0  token: 0x6000D5D
        public System.Void .ctor(Unity.Mathematics.int3x2 v) { }
        // RVA: 0x04D5FD34  token: 0x6000D5E
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D5FD90  token: 0x6000D5F
        public System.Void .ctor(Unity.Mathematics.float3x2 v) { }
        // RVA: 0x09C7F37C  token: 0x6000D60
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C7F3D8  token: 0x6000D61
        public System.Void .ctor(Unity.Mathematics.double3x2 v) { }
        // RVA: 0x09C7EF68  token: 0x6000D62
        public virtual System.Boolean Equals(Unity.Mathematics.uint3x2 rhs) { }
        // RVA: 0x09C7EEF4  token: 0x6000D63
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C7EFD8  token: 0x6000D64
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C7F1B4  token: 0x6000D65
        public virtual System.String ToString() { }
        // RVA: 0x09C7F000  token: 0x6000D66
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x2000058  // size: 0x34
    public sealed struct uint3x3 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.uint3 c0;  // 0x10
        public Unity.Mathematics.uint3 c1;  // 0x1c
        public Unity.Mathematics.uint3 c2;  // 0x28
        public static readonly Unity.Mathematics.uint3x3 identity;  // static @ 0x0

        // Methods
        // RVA: 0x03D55290  token: 0x6000D67
        public System.Void .ctor(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1, Unity.Mathematics.uint3 c2) { }
        // RVA: 0x03B6C9D0  token: 0x6000D68
        public System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22) { }
        // RVA: 0x03D82FF0  token: 0x6000D69
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x04D2A078  token: 0x6000D6A
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C74610  token: 0x6000D6B
        public System.Void .ctor(Unity.Mathematics.bool3x3 v) { }
        // RVA: 0x03D82FF0  token: 0x6000D6C
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x04D2A108  token: 0x6000D6D
        public System.Void .ctor(Unity.Mathematics.int3x3 v) { }
        // RVA: 0x04D5FF18  token: 0x6000D6E
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D6005C  token: 0x6000D6F
        public System.Void .ctor(Unity.Mathematics.float3x3 v) { }
        // RVA: 0x04D5FE94  token: 0x6000D70
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C7FA58  token: 0x6000D71
        public System.Void .ctor(Unity.Mathematics.double3x3 v) { }
        // RVA: 0x09C7F4E4  token: 0x6000D72
        public virtual System.Boolean Equals(Unity.Mathematics.uint3x3 rhs) { }
        // RVA: 0x09C7F468  token: 0x6000D73
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C7F584  token: 0x6000D74
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C7F5B0  token: 0x6000D75
        public virtual System.String ToString() { }
        // RVA: 0x09C7F814  token: 0x6000D76
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x03B6C930  token: 0x6000D77
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000059  // size: 0x40
    public sealed struct uint3x4 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.uint3 c0;  // 0x10
        public Unity.Mathematics.uint3 c1;  // 0x1c
        public Unity.Mathematics.uint3 c2;  // 0x28
        public Unity.Mathematics.uint3 c3;  // 0x34

        // Methods
        // RVA: 0x03D81850  token: 0x6000D78
        public System.Void .ctor(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1, Unity.Mathematics.uint3 c2, Unity.Mathematics.uint3 c3) { }
        // RVA: 0x03D832A0  token: 0x6000D79
        public System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m23) { }
        // RVA: 0x03D831B0  token: 0x6000D7A
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x04D2A3FC  token: 0x6000D7B
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C74F44  token: 0x6000D7C
        public System.Void .ctor(Unity.Mathematics.bool3x4 v) { }
        // RVA: 0x03D831B0  token: 0x6000D7D
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x04D2A254  token: 0x6000D7E
        public System.Void .ctor(Unity.Mathematics.int3x4 v) { }
        // RVA: 0x04D6020C  token: 0x6000D7F
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D60350  token: 0x6000D80
        public System.Void .ctor(Unity.Mathematics.float3x4 v) { }
        // RVA: 0x04D602A8  token: 0x6000D81
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C80260  token: 0x6000D82
        public System.Void .ctor(Unity.Mathematics.double3x4 v) { }
        // RVA: 0x09C7FBA0  token: 0x6000D83
        public virtual System.Boolean Equals(Unity.Mathematics.uint3x4 rhs) { }
        // RVA: 0x09C7FB24  token: 0x6000D84
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C7FC5C  token: 0x6000D85
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C7FF60  token: 0x6000D86
        public virtual System.String ToString() { }
        // RVA: 0x09C7FC8C  token: 0x6000D87
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x200005A  // size: 0x20
    public sealed struct uint4 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public System.UInt32 x;  // 0x10
        public System.UInt32 y;  // 0x14
        public System.UInt32 z;  // 0x18
        public System.UInt32 w;  // 0x1c

        // Properties
        System.UInt32 Item { get; /* RVA: 0x03D55FF0 */ set; /* RVA: 0x03D56010 */ }

        // Methods
        // RVA: 0x03D517E0  token: 0x6000D88
        public System.Void .ctor(System.UInt32 x, System.UInt32 y, System.UInt32 z, System.UInt32 w) { }
        // RVA: 0x03D83330  token: 0x6000D89
        public System.Void .ctor(System.UInt32 x, System.UInt32 y, Unity.Mathematics.uint2 zw) { }
        // RVA: 0x03D83430  token: 0x6000D8A
        public System.Void .ctor(System.UInt32 x, Unity.Mathematics.uint2 yz, System.UInt32 w) { }
        // RVA: 0x03D83400  token: 0x6000D8B
        public System.Void .ctor(System.UInt32 x, Unity.Mathematics.uint3 yzw) { }
        // RVA: 0x03D83450  token: 0x6000D8C
        public System.Void .ctor(Unity.Mathematics.uint2 xy, System.UInt32 z, System.UInt32 w) { }
        // RVA: 0x03D83350  token: 0x6000D8D
        public System.Void .ctor(Unity.Mathematics.uint2 xy, Unity.Mathematics.uint2 zw) { }
        // RVA: 0x03D833E0  token: 0x6000D8E
        public System.Void .ctor(Unity.Mathematics.uint3 xyz, System.UInt32 w) { }
        // RVA: 0x03D5DBB0  token: 0x6000D8F
        public System.Void .ctor(Unity.Mathematics.uint4 xyzw) { }
        // RVA: 0x03D83390  token: 0x6000D90
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x09C754EC  token: 0x6000D91
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x09C75508  token: 0x6000D92
        public System.Void .ctor(Unity.Mathematics.bool4 v) { }
        // RVA: 0x03D83390  token: 0x6000D93
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x03D5DBB0  token: 0x6000D94
        public System.Void .ctor(Unity.Mathematics.int4 v) { }
        // RVA: 0x04D60488  token: 0x6000D95
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x04D60424  token: 0x6000D96
        public System.Void .ctor(Unity.Mathematics.float4 v) { }
        // RVA: 0x09C806A4  token: 0x6000D97
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C806D0  token: 0x6000D98
        public System.Void .ctor(Unity.Mathematics.double4 v) { }
        // RVA: 0x03D7B6A0  token: 0x6000D99
        public static Unity.Mathematics.uint4 op_Implicit(System.UInt32 v) { }
        // RVA: 0x03D7B6A0  token: 0x6000D9A
        public static Unity.Mathematics.uint4 op_Explicit(System.Int32 v) { }
        // RVA: 0x09C3D070  token: 0x6000D9B
        public static Unity.Mathematics.uint4 op_Explicit(Unity.Mathematics.int4 v) { }
        // RVA: 0x09C58070  token: 0x6000D9C
        public static Unity.Mathematics.uint4 op_Explicit(System.Single v) { }
        // RVA: 0x09C580B8  token: 0x6000D9D
        public static Unity.Mathematics.uint4 op_Explicit(Unity.Mathematics.float4 v) { }
        // RVA: 0x09C58088  token: 0x6000D9E
        public static Unity.Mathematics.uint4 op_Explicit(System.Double v) { }
        // RVA: 0x09C58028  token: 0x6000D9F
        public static Unity.Mathematics.uint4 op_Explicit(Unity.Mathematics.double4 v) { }
        // RVA: 0x03D834D0  token: 0x6000DA0
        public static Unity.Mathematics.uint4 op_Multiply(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs) { }
        // RVA: 0x03D83500  token: 0x6000DA1
        public static Unity.Mathematics.uint4 op_Multiply(Unity.Mathematics.uint4 lhs, System.UInt32 rhs) { }
        // RVA: 0x03D83BC0  token: 0x6000DA2
        public static Unity.Mathematics.uint4 op_Multiply(System.UInt32 lhs, Unity.Mathematics.uint4 rhs) { }
        // RVA: 0x03D834A0  token: 0x6000DA3
        public static Unity.Mathematics.uint4 op_Addition(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs) { }
        // RVA: 0x03D83470  token: 0x6000DA4
        public static Unity.Mathematics.uint4 op_Addition(Unity.Mathematics.uint4 lhs, System.UInt32 rhs) { }
        // RVA: 0x03D83C40  token: 0x6000DA5
        public static Unity.Mathematics.uint4 op_Subtraction(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs) { }
        // RVA: 0x03D83560  token: 0x6000DA6
        public static Unity.Mathematics.uint4 op_Subtraction(Unity.Mathematics.uint4 lhs, System.UInt32 rhs) { }
        // RVA: 0x09C80730  token: 0x6000DA7
        public static Unity.Mathematics.bool4 op_GreaterThan(Unity.Mathematics.uint4 lhs, System.UInt32 rhs) { }
        // RVA: 0x03D83B90  token: 0x6000DA8
        public static Unity.Mathematics.uint4 op_LeftShift(Unity.Mathematics.uint4 x, System.Int32 n) { }
        // RVA: 0x03D83BF0  token: 0x6000DA9
        public static Unity.Mathematics.uint4 op_RightShift(Unity.Mathematics.uint4 x, System.Int32 n) { }
        // RVA: 0x09C8070C  token: 0x6000DAA
        public static Unity.Mathematics.bool4 op_Equality(Unity.Mathematics.uint4 lhs, System.UInt32 rhs) { }
        // RVA: 0x028B5880  token: 0x6000DAB
        public static Unity.Mathematics.uint4 op_OnesComplement(Unity.Mathematics.uint4 val) { }
        // RVA: 0x028B5820  token: 0x6000DAC
        public static Unity.Mathematics.uint4 op_BitwiseAnd(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs) { }
        // RVA: 0x03D83B60  token: 0x6000DAD
        public static Unity.Mathematics.uint4 op_BitwiseAnd(Unity.Mathematics.uint4 lhs, System.UInt32 rhs) { }
        // RVA: 0x028B58B0  token: 0x6000DAE
        public static Unity.Mathematics.uint4 op_BitwiseOr(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs) { }
        // RVA: 0x028B5850  token: 0x6000DAF
        public static Unity.Mathematics.uint4 op_ExclusiveOr(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs) { }
        // RVA: 0x05688F1C  token: 0x6000DB2
        public virtual System.Boolean Equals(Unity.Mathematics.uint4 rhs) { }
        // RVA: 0x09C8036C  token: 0x6000DB3
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C803D8  token: 0x6000DB4
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C80548  token: 0x6000DB5
        public virtual System.String ToString() { }
        // RVA: 0x09C803F4  token: 0x6000DB6
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x200005C  // size: 0x30
    public sealed struct uint4x2 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.uint4 c0;  // 0x10
        public Unity.Mathematics.uint4 c1;  // 0x20

        // Methods
        // RVA: 0x03D553F0  token: 0x6000DB7
        public System.Void .ctor(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1) { }
        // RVA: 0x03D83620  token: 0x6000DB8
        public System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11, System.UInt32 m20, System.UInt32 m21, System.UInt32 m30, System.UInt32 m31) { }
        // RVA: 0x03D835C0  token: 0x6000DB9
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x04D605C0  token: 0x6000DBA
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D60738  token: 0x6000DBB
        public System.Void .ctor(Unity.Mathematics.bool4x2 v) { }
        // RVA: 0x03D835C0  token: 0x6000DBC
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x09C75B18  token: 0x6000DBD
        public System.Void .ctor(Unity.Mathematics.int4x2 v) { }
        // RVA: 0x04D606A0  token: 0x6000DBE
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x09C80CCC  token: 0x6000DBF
        public System.Void .ctor(Unity.Mathematics.float4x2 v) { }
        // RVA: 0x04D60634  token: 0x6000DC0
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C80C30  token: 0x6000DC1
        public System.Void .ctor(Unity.Mathematics.double4x2 v) { }
        // RVA: 0x09C75594  token: 0x6000DC2
        public virtual System.Boolean Equals(Unity.Mathematics.uint4x2 rhs) { }
        // RVA: 0x09C80754  token: 0x6000DC3
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C807C8  token: 0x6000DC4
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C807EC  token: 0x6000DC5
        public virtual System.String ToString() { }
        // RVA: 0x09C80A1C  token: 0x6000DC6
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x200005D  // size: 0x40
    public sealed struct uint4x3 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.uint4 c0;  // 0x10
        public Unity.Mathematics.uint4 c1;  // 0x20
        public Unity.Mathematics.uint4 c2;  // 0x30

        // Methods
        // RVA: 0x03D6B600  token: 0x6000DC7
        public System.Void .ctor(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1, Unity.Mathematics.uint4 c2) { }
        // RVA: 0x03D83750  token: 0x6000DC8
        public System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m30, System.UInt32 m31, System.UInt32 m32) { }
        // RVA: 0x03D837D0  token: 0x6000DC9
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x04D60B74  token: 0x6000DCA
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D60918  token: 0x6000DCB
        public System.Void .ctor(Unity.Mathematics.bool4x3 v) { }
        // RVA: 0x03D837D0  token: 0x6000DCC
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x09C76260  token: 0x6000DCD
        public System.Void .ctor(Unity.Mathematics.int4x3 v) { }
        // RVA: 0x04D60A24  token: 0x6000DCE
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x09C813A0  token: 0x6000DCF
        public System.Void .ctor(Unity.Mathematics.float4x3 v) { }
        // RVA: 0x04D60878  token: 0x6000DD0
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C81418  token: 0x6000DD1
        public System.Void .ctor(Unity.Mathematics.double4x3 v) { }
        // RVA: 0x09C75BFC  token: 0x6000DD2
        public virtual System.Boolean Equals(Unity.Mathematics.uint4x3 rhs) { }
        // RVA: 0x09C80D20  token: 0x6000DD3
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C80D9C  token: 0x6000DD4
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C80DCC  token: 0x6000DD5
        public virtual System.String ToString() { }
        // RVA: 0x09C810CC  token: 0x6000DD6
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x200005E  // size: 0x50
    public sealed struct uint4x4 : System.IEquatable`1, System.IFormattable
    {
        // Fields
        public Unity.Mathematics.uint4 c0;  // 0x10
        public Unity.Mathematics.uint4 c1;  // 0x20
        public Unity.Mathematics.uint4 c2;  // 0x30
        public Unity.Mathematics.uint4 c3;  // 0x40
        public static readonly Unity.Mathematics.uint4x4 identity;  // static @ 0x0

        // Methods
        // RVA: 0x03D7E4A0  token: 0x6000DD7
        public System.Void .ctor(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1, Unity.Mathematics.uint4 c2, Unity.Mathematics.uint4 c3) { }
        // RVA: 0x03A4DCE0  token: 0x6000DD8
        public System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m23, System.UInt32 m30, System.UInt32 m31, System.UInt32 m32, System.UInt32 m33) { }
        // RVA: 0x03D83900  token: 0x6000DD9
        public System.Void .ctor(System.UInt32 v) { }
        // RVA: 0x04D60C18  token: 0x6000DDA
        public System.Void .ctor(System.Boolean v) { }
        // RVA: 0x04D60F6C  token: 0x6000DDB
        public System.Void .ctor(Unity.Mathematics.bool4x4 v) { }
        // RVA: 0x03D83900  token: 0x6000DDC
        public System.Void .ctor(System.Int32 v) { }
        // RVA: 0x09C76C10  token: 0x6000DDD
        public System.Void .ctor(Unity.Mathematics.int4x4 v) { }
        // RVA: 0x04D60DBC  token: 0x6000DDE
        public System.Void .ctor(System.Single v) { }
        // RVA: 0x09C81E50  token: 0x6000DDF
        public System.Void .ctor(Unity.Mathematics.float4x4 v) { }
        // RVA: 0x04D60CEC  token: 0x6000DE0
        public System.Void .ctor(System.Double v) { }
        // RVA: 0x09C81D20  token: 0x6000DE1
        public System.Void .ctor(Unity.Mathematics.double4x4 v) { }
        // RVA: 0x09C763F8  token: 0x6000DE2
        public virtual System.Boolean Equals(Unity.Mathematics.uint4x4 rhs) { }
        // RVA: 0x09C81500  token: 0x6000DE3
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x09C81584  token: 0x6000DE4
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09C815BC  token: 0x6000DE5
        public virtual System.String ToString() { }
        // RVA: 0x09C8198C  token: 0x6000DE6
        public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        // RVA: 0x03A4DBF0  token: 0x6000DE7
        private static System.Void .cctor() { }

    }

}

