// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Mathematics.dll
// Classes:  94
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

CLASS: RotationOrder
TYPE:  sealed struct
TOKEN: 0x2000005
SIZE:  0x11
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Unity.Mathematics.math.RotationOrderXYZ  // const
  public    static  Unity.Mathematics.math.RotationOrderXZY  // const
  public    static  Unity.Mathematics.math.RotationOrderYXZ  // const
  public    static  Unity.Mathematics.math.RotationOrderYZX  // const
  public    static  Unity.Mathematics.math.RotationOrderZXY  // const
  public    static  Unity.Mathematics.math.RotationOrderZYX  // const
  public    static  Unity.Mathematics.math.RotationOrderDefault  // const
METHODS:
END_CLASS

CLASS: ShuffleComponent
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x11
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Unity.Mathematics.math.ShuffleComponentLeftX  // const
  public    static  Unity.Mathematics.math.ShuffleComponentLeftY  // const
  public    static  Unity.Mathematics.math.ShuffleComponentLeftZ  // const
  public    static  Unity.Mathematics.math.ShuffleComponentLeftW  // const
  public    static  Unity.Mathematics.math.ShuffleComponentRightX  // const
  public    static  Unity.Mathematics.math.ShuffleComponentRightY  // const
  public    static  Unity.Mathematics.math.ShuffleComponentRightZ  // const
  public    static  Unity.Mathematics.math.ShuffleComponentRightW  // const
METHODS:
END_CLASS

CLASS: LongDoubleUnion
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0x18
FIELDS:
  public            System.Int64                    longValue  // 0x10
  public            System.Double                   doubleValue  // 0x10
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x2000009
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x200000E
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x2000013
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x2000018
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x200001D
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x2000022
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x2000027
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x200002C
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x2000031
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x2000037
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x2000039
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x200003B
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x200003D
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x2000042
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x2000047
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x2000051
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x2000056
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  sealed class
TOKEN: 0x200005B
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstructionAttribute
TYPE:  class
TOKEN: 0x2000002
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000001  System.Void .ctor()
END_CLASS

CLASS: Unity.Mathematics.AffineTransform
TYPE:  sealed struct
TOKEN: 0x2000003
SIZE:  0x40
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.float3x3      rs  // 0x10
  public            Unity.Mathematics.float3        t  // 0x34
  public    static readonly Unity.Mathematics.AffineTransformidentity  // static @ 0x0
METHODS:
  RVA=0x09C5F45C  token=0x6000002  System.Void .ctor(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation)
  RVA=0x09C5F3B4  token=0x6000003  System.Void .ctor(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 scale)
  RVA=0x03D7D430  token=0x6000004  System.Void .ctor(Unity.Mathematics.float3 translation, Unity.Mathematics.float3x3 rotationScale)
  RVA=0x09C5F34C  token=0x6000005  System.Void .ctor(Unity.Mathematics.float3x3 rotationScale)
  RVA=0x09C5F2F4  token=0x6000006  System.Void .ctor(Unity.Mathematics.RigidTransform rigid)
  RVA=0x04D2508C  token=0x6000007  System.Void .ctor(Unity.Mathematics.float3x4 m)
  RVA=0x04D251C4  token=0x6000008  System.Void .ctor(Unity.Mathematics.float4x4 m)
  RVA=0x09C5EC58  token=0x6000009  System.Boolean Equals(Unity.Mathematics.AffineTransform rhs)
  RVA=0x09C5EBDC  token=0x600000A  System.Boolean Equals(System.Object o)
  RVA=0x09C5ECC0  token=0x600000B  System.Int32 GetHashCode()
  RVA=0x09C5EFC4  token=0x600000C  System.String ToString()
  RVA=0x09C5ECF0  token=0x600000D  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x03CB4BF0  token=0x600000E  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.math
TYPE:  static class
TOKEN: 0x2000004
SIZE:  0x10
FIELDS:
  public    static  System.Double                   E_DBL  // const
  public    static  System.Double                   LOG2E_DBL  // const
  public    static  System.Double                   LOG10E_DBL  // const
  public    static  System.Double                   LN2_DBL  // const
  public    static  System.Double                   LN10_DBL  // const
  public    static  System.Double                   PI_DBL  // const
  public    static  System.Double                   PI2_DBL  // const
  public    static  System.Double                   PIHALF_DBL  // const
  public    static  System.Double                   TAU_DBL  // const
  public    static  System.Double                   TODEGREES_DBL  // const
  public    static  System.Double                   TORADIANS_DBL  // const
  public    static  System.Double                   SQRT2_DBL  // const
  public    static  System.Double                   EPSILON_DBL  // const
  public    static  System.Double                   INFINITY_DBL  // const
  public    static  System.Double                   NAN_DBL  // const
  public    static  System.Single                   FLT_MIN_NORMAL  // const
  public    static  System.Double                   DBL_MIN_NORMAL  // const
  public    static  System.Single                   E  // const
  public    static  System.Single                   LOG2E  // const
  public    static  System.Single                   LOG10E  // const
  public    static  System.Single                   LN2  // const
  public    static  System.Single                   LN10  // const
  public    static  System.Single                   PI  // const
  public    static  System.Single                   PI2  // const
  public    static  System.Single                   PIHALF  // const
  public    static  System.Single                   TAU  // const
  public    static  System.Single                   TODEGREES  // const
  public    static  System.Single                   TORADIANS  // const
  public    static  System.Single                   SQRT2  // const
  public    static  System.Single                   EPSILON  // const
  public    static  System.Single                   INFINITY  // const
  public    static  System.Single                   NAN  // const
METHODS:
  RVA=0x09C2C7E8  token=0x600000F  Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation)
  RVA=0x09C2C834  token=0x6000010  Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 scale)
  RVA=0x03D78240  token=0x6000011  Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float3 translation, Unity.Mathematics.float3x3 rotationScale)
  RVA=0x09C2C758  token=0x6000012  Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float3x3 rotationScale)
  RVA=0x09C2C79C  token=0x6000013  Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float4x4 m)
  RVA=0x09C2C8DC  token=0x6000014  Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float3x4 m)
  RVA=0x09C2C898  token=0x6000015  Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.RigidTransform rigid)
  RVA=0x09C350EC  token=0x6000016  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.AffineTransform transform)
  RVA=0x09C347A0  token=0x6000017  Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.AffineTransform transform)
  RVA=0x09C4A9C8  token=0x6000018  Unity.Mathematics.AffineTransform mul(Unity.Mathematics.AffineTransform a, Unity.Mathematics.AffineTransform b)
  RVA=0x09C496D8  token=0x6000019  Unity.Mathematics.AffineTransform mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.AffineTransform b)
  RVA=0x09C4C924  token=0x600001A  Unity.Mathematics.AffineTransform mul(Unity.Mathematics.AffineTransform a, Unity.Mathematics.float3x3 b)
  RVA=0x09C4F454  token=0x600001B  Unity.Mathematics.float4 mul(Unity.Mathematics.AffineTransform a, Unity.Mathematics.float4 pos)
  RVA=0x09C52B98  token=0x600001C  Unity.Mathematics.float3 rotate(Unity.Mathematics.AffineTransform a, Unity.Mathematics.float3 dir)
  RVA=0x09C56440  token=0x600001D  Unity.Mathematics.float3 transform(Unity.Mathematics.AffineTransform a, Unity.Mathematics.float3 pos)
  RVA=0x09C3D650  token=0x600001E  Unity.Mathematics.AffineTransform inverse(Unity.Mathematics.AffineTransform a)
  RVA=0x09C30428  token=0x600001F  System.Void decompose(Unity.Mathematics.AffineTransform a, Unity.Mathematics.float3& translation, Unity.Mathematics.quaternion& rotation, Unity.Mathematics.float3& scale)
  RVA=0x09C35E68  token=0x6000020  System.UInt32 hash(Unity.Mathematics.AffineTransform a)
  RVA=0x09C3A4BC  token=0x6000021  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.AffineTransform a)
  RVA=0x03D787C0  token=0x6000022  Unity.Mathematics.bool2 bool2(System.Boolean x, System.Boolean y)
  RVA=0x03D787E0  token=0x6000023  Unity.Mathematics.bool2 bool2(Unity.Mathematics.bool2 xy)
  RVA=0x03D787D0  token=0x6000024  Unity.Mathematics.bool2 bool2(System.Boolean v)
  RVA=0x09C375E8  token=0x6000025  System.UInt32 hash(Unity.Mathematics.bool2 v)
  RVA=0x09C39D58  token=0x6000026  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.bool2 v)
  RVA=0x04D580D0  token=0x6000027  System.Boolean shuffle(Unity.Mathematics.bool2 left, Unity.Mathematics.bool2 right, Unity.Mathematics.math.ShuffleComponent x)
  RVA=0x04D599E8  token=0x6000028  Unity.Mathematics.bool2 shuffle(Unity.Mathematics.bool2 left, Unity.Mathematics.bool2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  RVA=0x04D582B0  token=0x6000029  Unity.Mathematics.bool3 shuffle(Unity.Mathematics.bool2 left, Unity.Mathematics.bool2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  RVA=0x04D5887C  token=0x600002A  Unity.Mathematics.bool4 shuffle(Unity.Mathematics.bool2 left, Unity.Mathematics.bool2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  RVA=0x04D57694  token=0x600002B  System.Boolean select_shuffle_component(Unity.Mathematics.bool2 a, Unity.Mathematics.bool2 b, Unity.Mathematics.math.ShuffleComponent component)
  RVA=0x03D78800  token=0x600002C  Unity.Mathematics.bool2x2 bool2x2(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1)
  RVA=0x04D2D538  token=0x600002D  Unity.Mathematics.bool2x2 bool2x2(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11)
  RVA=0x09C2EC58  token=0x600002E  Unity.Mathematics.bool2x2 bool2x2(System.Boolean v)
  RVA=0x09C56C5C  token=0x600002F  Unity.Mathematics.bool2x2 transpose(Unity.Mathematics.bool2x2 v)
  RVA=0x09C3740C  token=0x6000030  System.UInt32 hash(Unity.Mathematics.bool2x2 v)
  RVA=0x09C3B9A8  token=0x6000031  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.bool2x2 v)
  RVA=0x03D78810  token=0x6000032  Unity.Mathematics.bool2x3 bool2x3(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1, Unity.Mathematics.bool2 c2)
  RVA=0x04D2D568  token=0x6000033  Unity.Mathematics.bool2x3 bool2x3(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12)
  RVA=0x09C2EC7C  token=0x6000034  Unity.Mathematics.bool2x3 bool2x3(System.Boolean v)
  RVA=0x09C56968  token=0x6000035  Unity.Mathematics.bool3x2 transpose(Unity.Mathematics.bool2x3 v)
  RVA=0x09C38388  token=0x6000036  System.UInt32 hash(Unity.Mathematics.bool2x3 v)
  RVA=0x09C3A160  token=0x6000037  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.bool2x3 v)
  RVA=0x03D78830  token=0x6000038  Unity.Mathematics.bool2x4 bool2x4(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1, Unity.Mathematics.bool2 c2, Unity.Mathematics.bool2 c3)
  RVA=0x09C2EC98  token=0x6000039  Unity.Mathematics.bool2x4 bool2x4(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13)
  RVA=0x09C2ECF0  token=0x600003A  Unity.Mathematics.bool2x4 bool2x4(System.Boolean v)
  RVA=0x09C572A8  token=0x600003B  Unity.Mathematics.bool4x2 transpose(Unity.Mathematics.bool2x4 v)
  RVA=0x09C37858  token=0x600003C  System.UInt32 hash(Unity.Mathematics.bool2x4 v)
  RVA=0x09C3C568  token=0x600003D  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.bool2x4 v)
  RVA=0x03D78860  token=0x600003E  Unity.Mathematics.bool3 bool3(System.Boolean x, System.Boolean y, System.Boolean z)
  RVA=0x03D788A0  token=0x600003F  Unity.Mathematics.bool3 bool3(System.Boolean x, Unity.Mathematics.bool2 yz)
  RVA=0x03D78880  token=0x6000040  Unity.Mathematics.bool3 bool3(Unity.Mathematics.bool2 xy, System.Boolean z)
  RVA=0x03D788C0  token=0x6000041  Unity.Mathematics.bool3 bool3(Unity.Mathematics.bool3 xyz)
  RVA=0x03D78870  token=0x6000042  Unity.Mathematics.bool3 bool3(System.Boolean v)
  RVA=0x04D33EC4  token=0x6000043  System.UInt32 hash(Unity.Mathematics.bool3 v)
  RVA=0x09C3AF5C  token=0x6000044  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.bool3 v)
  RVA=0x04D58B38  token=0x6000045  System.Boolean shuffle(Unity.Mathematics.bool3 left, Unity.Mathematics.bool3 right, Unity.Mathematics.math.ShuffleComponent x)
  RVA=0x09C54898  token=0x6000046  Unity.Mathematics.bool2 shuffle(Unity.Mathematics.bool3 left, Unity.Mathematics.bool3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  RVA=0x09C5441C  token=0x6000047  Unity.Mathematics.bool3 shuffle(Unity.Mathematics.bool3 left, Unity.Mathematics.bool3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  RVA=0x09C53B30  token=0x6000048  Unity.Mathematics.bool4 shuffle(Unity.Mathematics.bool3 left, Unity.Mathematics.bool3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  RVA=0x04D57AE0  token=0x6000049  System.Boolean select_shuffle_component(Unity.Mathematics.bool3 a, Unity.Mathematics.bool3 b, Unity.Mathematics.math.ShuffleComponent component)
  RVA=0x03D788E0  token=0x600004A  Unity.Mathematics.bool3x2 bool3x2(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1)
  RVA=0x04D2D624  token=0x600004B  Unity.Mathematics.bool3x2 bool3x2(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11, System.Boolean m20, System.Boolean m21)
  RVA=0x09C2ED14  token=0x600004C  Unity.Mathematics.bool3x2 bool3x2(System.Boolean v)
  RVA=0x09C57538  token=0x600004D  Unity.Mathematics.bool2x3 transpose(Unity.Mathematics.bool3x2 v)
  RVA=0x04D35E04  token=0x600004E  System.UInt32 hash(Unity.Mathematics.bool3x2 v)
  RVA=0x09C3BBFC  token=0x600004F  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.bool3x2 v)
  RVA=0x03D78910  token=0x6000050  Unity.Mathematics.bool3x3 bool3x3(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1, Unity.Mathematics.bool3 c2)
  RVA=0x04D2D65C  token=0x6000051  Unity.Mathematics.bool3x3 bool3x3(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m20, System.Boolean m21, System.Boolean m22)
  RVA=0x09C2ED30  token=0x6000052  Unity.Mathematics.bool3x3 bool3x3(System.Boolean v)
  RVA=0x09C57248  token=0x6000053  Unity.Mathematics.bool3x3 transpose(Unity.Mathematics.bool3x3 v)
  RVA=0x04D36C28  token=0x6000054  System.UInt32 hash(Unity.Mathematics.bool3x3 v)
  RVA=0x09C3BD24  token=0x6000055  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.bool3x3 v)
  RVA=0x03D78950  token=0x6000056  Unity.Mathematics.bool3x4 bool3x4(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1, Unity.Mathematics.bool3 c2, Unity.Mathematics.bool3 c3)
  RVA=0x04D2D6BC  token=0x6000057  Unity.Mathematics.bool3x4 bool3x4(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m23)
  RVA=0x09C2ED4C  token=0x6000058  Unity.Mathematics.bool3x4 bool3x4(System.Boolean v)
  RVA=0x09C57580  token=0x6000059  Unity.Mathematics.bool4x3 transpose(Unity.Mathematics.bool3x4 v)
  RVA=0x04D34EC4  token=0x600005A  System.UInt32 hash(Unity.Mathematics.bool3x4 v)
  RVA=0x09C3A8C0  token=0x600005B  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.bool3x4 v)
  RVA=0x03D789E0  token=0x600005C  Unity.Mathematics.bool4 bool4(System.Boolean x, System.Boolean y, System.Boolean z, System.Boolean w)
  RVA=0x03D78A70  token=0x600005D  Unity.Mathematics.bool4 bool4(System.Boolean x, System.Boolean y, Unity.Mathematics.bool2 zw)
  RVA=0x03D789C0  token=0x600005E  Unity.Mathematics.bool4 bool4(System.Boolean x, Unity.Mathematics.bool2 yz, System.Boolean w)
  RVA=0x03D78AC0  token=0x600005F  Unity.Mathematics.bool4 bool4(System.Boolean x, Unity.Mathematics.bool3 yzw)
  RVA=0x03D789A0  token=0x6000060  Unity.Mathematics.bool4 bool4(Unity.Mathematics.bool2 xy, System.Boolean z, System.Boolean w)
  RVA=0x03D78A20  token=0x6000061  Unity.Mathematics.bool4 bool4(Unity.Mathematics.bool2 xy, Unity.Mathematics.bool2 zw)
  RVA=0x03D78A90  token=0x6000062  Unity.Mathematics.bool4 bool4(Unity.Mathematics.bool3 xyz, System.Boolean w)
  RVA=0x03D78A40  token=0x6000063  Unity.Mathematics.bool4 bool4(Unity.Mathematics.bool4 xyzw)
  RVA=0x03D78A00  token=0x6000064  Unity.Mathematics.bool4 bool4(System.Boolean v)
  RVA=0x04D356BC  token=0x6000065  System.UInt32 hash(Unity.Mathematics.bool4 v)
  RVA=0x09C3C174  token=0x6000066  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.bool4 v)
  RVA=0x04D580C8  token=0x6000067  System.Boolean shuffle(Unity.Mathematics.bool4 left, Unity.Mathematics.bool4 right, Unity.Mathematics.math.ShuffleComponent x)
  RVA=0x04D59D90  token=0x6000068  Unity.Mathematics.bool2 shuffle(Unity.Mathematics.bool4 left, Unity.Mathematics.bool4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  RVA=0x04D59868  token=0x6000069  Unity.Mathematics.bool3 shuffle(Unity.Mathematics.bool4 left, Unity.Mathematics.bool4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  RVA=0x04D58F28  token=0x600006A  Unity.Mathematics.bool4 shuffle(Unity.Mathematics.bool4 left, Unity.Mathematics.bool4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  RVA=0x04D57568  token=0x600006B  System.Boolean select_shuffle_component(Unity.Mathematics.bool4 a, Unity.Mathematics.bool4 b, Unity.Mathematics.math.ShuffleComponent component)
  RVA=0x03D78AF0  token=0x600006C  Unity.Mathematics.bool4x2 bool4x2(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1)
  RVA=0x09C2ED68  token=0x600006D  Unity.Mathematics.bool4x2 bool4x2(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11, System.Boolean m20, System.Boolean m21, System.Boolean m30, System.Boolean m31)
  RVA=0x09C2EDC0  token=0x600006E  Unity.Mathematics.bool4x2 bool4x2(System.Boolean v)
  RVA=0x09C567F4  token=0x600006F  Unity.Mathematics.bool2x4 transpose(Unity.Mathematics.bool4x2 v)
  RVA=0x04D349A8  token=0x6000070  System.UInt32 hash(Unity.Mathematics.bool4x2 v)
  RVA=0x04D399DC  token=0x6000071  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.bool4x2 v)
  RVA=0x03D78B00  token=0x6000072  Unity.Mathematics.bool4x3 bool4x3(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1, Unity.Mathematics.bool4 c2)
  RVA=0x04D2D7F4  token=0x6000073  Unity.Mathematics.bool4x3 bool4x3(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m30, System.Boolean m31, System.Boolean m32)
  RVA=0x09C2EDE4  token=0x6000074  Unity.Mathematics.bool4x3 bool4x3(System.Boolean v)
  RVA=0x09C5764C  token=0x6000075  Unity.Mathematics.bool3x4 transpose(Unity.Mathematics.bool4x3 v)
  RVA=0x04D35764  token=0x6000076  System.UInt32 hash(Unity.Mathematics.bool4x3 v)
  RVA=0x04D39170  token=0x6000077  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.bool4x3 v)
  RVA=0x03D78B10  token=0x6000078  Unity.Mathematics.bool4x4 bool4x4(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1, Unity.Mathematics.bool4 c2, Unity.Mathematics.bool4 c3)
  RVA=0x04D2D870  token=0x6000079  Unity.Mathematics.bool4x4 bool4x4(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m23, System.Boolean m30, System.Boolean m31, System.Boolean m32, System.Boolean m33)
  RVA=0x09C2EE00  token=0x600007A  Unity.Mathematics.bool4x4 bool4x4(System.Boolean v)
  RVA=0x09C56764  token=0x600007B  Unity.Mathematics.bool4x4 transpose(Unity.Mathematics.bool4x4 v)
  RVA=0x04D369F0  token=0x600007C  System.UInt32 hash(Unity.Mathematics.bool4x4 v)
  RVA=0x04D3AC60  token=0x600007D  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.bool4x4 v)
  RVA=0x03D79DD0  token=0x600007E  Unity.Mathematics.double2 double2(System.Double x, System.Double y)
  RVA=0x03D79EE0  token=0x600007F  Unity.Mathematics.double2 double2(Unity.Mathematics.double2 xy)
  RVA=0x03D79F00  token=0x6000080  Unity.Mathematics.double2 double2(System.Double v)
  RVA=0x09C30B30  token=0x6000081  Unity.Mathematics.double2 double2(System.Boolean v)
  RVA=0x09C30AD8  token=0x6000082  Unity.Mathematics.double2 double2(Unity.Mathematics.bool2 v)
  RVA=0x03D79EA0  token=0x6000083  Unity.Mathematics.double2 double2(System.Int32 v)
  RVA=0x03D79E40  token=0x6000084  Unity.Mathematics.double2 double2(Unity.Mathematics.int2 v)
  RVA=0x03D79DE0  token=0x6000085  Unity.Mathematics.double2 double2(System.UInt32 v)
  RVA=0x03D79E70  token=0x6000086  Unity.Mathematics.double2 double2(Unity.Mathematics.uint2 v)
  RVA=0x09C30A98  token=0x6000087  Unity.Mathematics.double2 double2(Unity.Mathematics.half v)
  RVA=0x09C30AF0  token=0x6000088  Unity.Mathematics.double2 double2(Unity.Mathematics.half2 v)
  RVA=0x03D79EC0  token=0x6000089  Unity.Mathematics.double2 double2(System.Single v)
  RVA=0x03D79E10  token=0x600008A  Unity.Mathematics.double2 double2(Unity.Mathematics.float2 v)
  RVA=0x09C372A8  token=0x600008B  System.UInt32 hash(Unity.Mathematics.double2 v)
  RVA=0x09C3B21C  token=0x600008C  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.double2 v)
  RVA=0x09C54664  token=0x600008D  System.Double shuffle(Unity.Mathematics.double2 left, Unity.Mathematics.double2 right, Unity.Mathematics.math.ShuffleComponent x)
  RVA=0x09C5405C  token=0x600008E  Unity.Mathematics.double2 shuffle(Unity.Mathematics.double2 left, Unity.Mathematics.double2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  RVA=0x09C54598  token=0x600008F  Unity.Mathematics.double3 shuffle(Unity.Mathematics.double2 left, Unity.Mathematics.double2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  RVA=0x09C54764  token=0x6000090  Unity.Mathematics.double4 shuffle(Unity.Mathematics.double2 left, Unity.Mathematics.double2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  RVA=0x04D57474  token=0x6000091  System.Double select_shuffle_component(Unity.Mathematics.double2 a, Unity.Mathematics.double2 b, Unity.Mathematics.math.ShuffleComponent component)
  RVA=0x03D79F10  token=0x6000092  Unity.Mathematics.double2x2 double2x2(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1)
  RVA=0x04D2F8D4  token=0x6000093  Unity.Mathematics.double2x2 double2x2(System.Double m00, System.Double m01, System.Double m10, System.Double m11)
  RVA=0x09C30B68  token=0x6000094  Unity.Mathematics.double2x2 double2x2(System.Double v)
  RVA=0x09C30C58  token=0x6000095  Unity.Mathematics.double2x2 double2x2(System.Boolean v)
  RVA=0x09C30B84  token=0x6000096  Unity.Mathematics.double2x2 double2x2(Unity.Mathematics.bool2x2 v)
  RVA=0x09C30BE8  token=0x6000097  Unity.Mathematics.double2x2 double2x2(System.Int32 v)
  RVA=0x09C30C04  token=0x6000098  Unity.Mathematics.double2x2 double2x2(Unity.Mathematics.int2x2 v)
  RVA=0x09C30BA4  token=0x6000099  Unity.Mathematics.double2x2 double2x2(System.UInt32 v)
  RVA=0x09C30C2C  token=0x600009A  Unity.Mathematics.double2x2 double2x2(Unity.Mathematics.uint2x2 v)
  RVA=0x09C30B4C  token=0x600009B  Unity.Mathematics.double2x2 double2x2(System.Single v)
  RVA=0x09C30BC0  token=0x600009C  Unity.Mathematics.double2x2 double2x2(Unity.Mathematics.float2x2 v)
  RVA=0x09C56C80  token=0x600009D  Unity.Mathematics.double2x2 transpose(Unity.Mathematics.double2x2 v)
  RVA=0x09C3D748  token=0x600009E  Unity.Mathematics.double2x2 inverse(Unity.Mathematics.double2x2 m)
  RVA=0x03D79C10  token=0x600009F  System.Double determinant(Unity.Mathematics.double2x2 m)
  RVA=0x09C372F0  token=0x60000A0  System.UInt32 hash(Unity.Mathematics.double2x2 v)
  RVA=0x09C3C0DC  token=0x60000A1  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.double2x2 v)
  RVA=0x03D79F40  token=0x60000A2  Unity.Mathematics.double2x3 double2x3(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1, Unity.Mathematics.double2 c2)
  RVA=0x04D2F8FC  token=0x60000A3  Unity.Mathematics.double2x3 double2x3(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12)
  RVA=0x09C30CB4  token=0x60000A4  Unity.Mathematics.double2x3 double2x3(System.Double v)
  RVA=0x09C30D0C  token=0x60000A5  Unity.Mathematics.double2x3 double2x3(System.Boolean v)
  RVA=0x09C30D88  token=0x60000A6  Unity.Mathematics.double2x3 double2x3(Unity.Mathematics.bool2x3 v)
  RVA=0x09C30D2C  token=0x60000A7  Unity.Mathematics.double2x3 double2x3(System.Int32 v)
  RVA=0x09C30DC4  token=0x60000A8  Unity.Mathematics.double2x3 double2x3(Unity.Mathematics.int2x3 v)
  RVA=0x09C30C74  token=0x60000A9  Unity.Mathematics.double2x3 double2x3(System.UInt32 v)
  RVA=0x09C30D4C  token=0x60000AA  Unity.Mathematics.double2x3 double2x3(Unity.Mathematics.uint2x3 v)
  RVA=0x09C30C94  token=0x60000AB  Unity.Mathematics.double2x3 double2x3(System.Single v)
  RVA=0x09C30CD4  token=0x60000AC  Unity.Mathematics.double2x3 double2x3(Unity.Mathematics.float2x3 v)
  RVA=0x09C575F8  token=0x60000AD  Unity.Mathematics.double3x2 transpose(Unity.Mathematics.double2x3 v)
  RVA=0x09C3656C  token=0x60000AE  System.UInt32 hash(Unity.Mathematics.double2x3 v)
  RVA=0x09C3BEE8  token=0x60000AF  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.double2x3 v)
  RVA=0x03D79F90  token=0x60000B0  Unity.Mathematics.double2x4 double2x4(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1, Unity.Mathematics.double2 c2, Unity.Mathematics.double2 c3)
  RVA=0x04D2F9E4  token=0x60000B1  Unity.Mathematics.double2x4 double2x4(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13)
  RVA=0x09C30EC0  token=0x60000B2  Unity.Mathematics.double2x4 double2x4(System.Double v)
  RVA=0x09C30DFC  token=0x60000B3  Unity.Mathematics.double2x4 double2x4(System.Boolean v)
  RVA=0x09C30E5C  token=0x60000B4  Unity.Mathematics.double2x4 double2x4(Unity.Mathematics.bool2x4 v)
  RVA=0x09C30F68  token=0x60000B5  Unity.Mathematics.double2x4 double2x4(System.Int32 v)
  RVA=0x09C30E84  token=0x60000B6  Unity.Mathematics.double2x4 double2x4(Unity.Mathematics.int2x4 v)
  RVA=0x09C30F08  token=0x60000B7  Unity.Mathematics.double2x4 double2x4(System.UInt32 v)
  RVA=0x09C30E20  token=0x60000B8  Unity.Mathematics.double2x4 double2x4(Unity.Mathematics.uint2x4 v)
  RVA=0x09C30EE4  token=0x60000B9  Unity.Mathematics.double2x4 double2x4(System.Single v)
  RVA=0x09C30F2C  token=0x60000BA  Unity.Mathematics.double2x4 double2x4(Unity.Mathematics.float2x4 v)
  RVA=0x09C56A34  token=0x60000BB  Unity.Mathematics.double4x2 transpose(Unity.Mathematics.double2x4 v)
  RVA=0x09C36BF0  token=0x60000BC  System.UInt32 hash(Unity.Mathematics.double2x4 v)
  RVA=0x09C3C674  token=0x60000BD  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.double2x4 v)
  RVA=0x03D7A0A0  token=0x60000BE  Unity.Mathematics.double3 double3(System.Double x, System.Double y, System.Double z)
  RVA=0x03D7A1B0  token=0x60000BF  Unity.Mathematics.double3 double3(System.Double x, Unity.Mathematics.double2 yz)
  RVA=0x03D7A0D0  token=0x60000C0  Unity.Mathematics.double3 double3(Unity.Mathematics.double2 xy, System.Double z)
  RVA=0x03D7A150  token=0x60000C1  Unity.Mathematics.double3 double3(Unity.Mathematics.double3 xyz)
  RVA=0x03D7A0C0  token=0x60000C2  Unity.Mathematics.double3 double3(System.Double v)
  RVA=0x09C31024  token=0x60000C3  Unity.Mathematics.double3 double3(System.Boolean v)
  RVA=0x09C30FF0  token=0x60000C4  Unity.Mathematics.double3 double3(Unity.Mathematics.bool3 v)
  RVA=0x03D7A180  token=0x60000C5  Unity.Mathematics.double3 double3(System.Int32 v)
  RVA=0x03D7A020  token=0x60000C6  Unity.Mathematics.double3 double3(Unity.Mathematics.int3 v)
  RVA=0x03D7A070  token=0x60000C7  Unity.Mathematics.double3 double3(System.UInt32 v)
  RVA=0x03D7A0F0  token=0x60000C8  Unity.Mathematics.double3 double3(Unity.Mathematics.uint3 v)
  RVA=0x09C31044  token=0x60000C9  Unity.Mathematics.double3 double3(Unity.Mathematics.half v)
  RVA=0x09C30F8C  token=0x60000CA  Unity.Mathematics.double3 double3(Unity.Mathematics.half3 v)
  RVA=0x03D79FF0  token=0x60000CB  Unity.Mathematics.double3 double3(System.Single v)
  RVA=0x0337F9A0  token=0x60000CC  Unity.Mathematics.double3 double3(Unity.Mathematics.float3 v)
  RVA=0x09C37630  token=0x60000CD  System.UInt32 hash(Unity.Mathematics.double3 v)
  RVA=0x09C3A2FC  token=0x60000CE  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.double3 v)
  RVA=0x09C54910  token=0x60000CF  System.Double shuffle(Unity.Mathematics.double3 left, Unity.Mathematics.double3 right, Unity.Mathematics.math.ShuffleComponent x)
  RVA=0x09C53C14  token=0x60000D0  Unity.Mathematics.double2 shuffle(Unity.Mathematics.double3 left, Unity.Mathematics.double3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  RVA=0x09C549B0  token=0x60000D1  Unity.Mathematics.double3 shuffle(Unity.Mathematics.double3 left, Unity.Mathematics.double3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  RVA=0x09C53DBC  token=0x60000D2  Unity.Mathematics.double4 shuffle(Unity.Mathematics.double3 left, Unity.Mathematics.double3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  RVA=0x09C53830  token=0x60000D3  System.Double select_shuffle_component(Unity.Mathematics.double3 a, Unity.Mathematics.double3 b, Unity.Mathematics.math.ShuffleComponent component)
  RVA=0x03D7A1D0  token=0x60000D4  Unity.Mathematics.double3x2 double3x2(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1)
  RVA=0x04D2FAF0  token=0x60000D5  Unity.Mathematics.double3x2 double3x2(System.Double m00, System.Double m01, System.Double m10, System.Double m11, System.Double m20, System.Double m21)
  RVA=0x09C310F4  token=0x60000D6  Unity.Mathematics.double3x2 double3x2(System.Double v)
  RVA=0x09C31150  token=0x60000D7  Unity.Mathematics.double3x2 double3x2(System.Boolean v)
  RVA=0x09C31174  token=0x60000D8  Unity.Mathematics.double3x2 double3x2(Unity.Mathematics.bool3x2 v)
  RVA=0x09C3120C  token=0x60000D9  Unity.Mathematics.double3x2 double3x2(System.Int32 v)
  RVA=0x09C311B0  token=0x60000DA  Unity.Mathematics.double3x2 double3x2(Unity.Mathematics.int3x2 v)
  RVA=0x09C31098  token=0x60000DB  Unity.Mathematics.double3x2 double3x2(System.UInt32 v)
  RVA=0x09C31114  token=0x60000DC  Unity.Mathematics.double3x2 double3x2(Unity.Mathematics.uint3x2 v)
  RVA=0x09C311EC  token=0x60000DD  Unity.Mathematics.double3x2 double3x2(System.Single v)
  RVA=0x09C310B8  token=0x60000DE  Unity.Mathematics.double3x2 double3x2(Unity.Mathematics.float3x2 v)
  RVA=0x09C56B9C  token=0x60000DF  Unity.Mathematics.double2x3 transpose(Unity.Mathematics.double3x2 v)
  RVA=0x09C35A88  token=0x60000E0  System.UInt32 hash(Unity.Mathematics.double3x2 v)
  RVA=0x09C38F4C  token=0x60000E1  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.double3x2 v)
  RVA=0x03D7A200  token=0x60000E2  Unity.Mathematics.double3x3 double3x3(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1, Unity.Mathematics.double3 c2)
  RVA=0x04D2FBD0  token=0x60000E3  Unity.Mathematics.double3x3 double3x3(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12, System.Double m20, System.Double m21, System.Double m22)
  RVA=0x09C313CC  token=0x60000E4  Unity.Mathematics.double3x3 double3x3(System.Double v)
  RVA=0x09C31350  token=0x60000E5  Unity.Mathematics.double3x3 double3x3(System.Boolean v)
  RVA=0x04D2FB38  token=0x60000E6  Unity.Mathematics.double3x3 double3x3(Unity.Mathematics.bool3x3 v)
  RVA=0x09C31324  token=0x60000E7  Unity.Mathematics.double3x3 double3x3(System.Int32 v)
  RVA=0x09C312D4  token=0x60000E8  Unity.Mathematics.double3x3 double3x3(Unity.Mathematics.int3x3 v)
  RVA=0x09C312A8  token=0x60000E9  Unity.Mathematics.double3x3 double3x3(System.UInt32 v)
  RVA=0x09C3137C  token=0x60000EA  Unity.Mathematics.double3x3 double3x3(Unity.Mathematics.uint3x3 v)
  RVA=0x09C3122C  token=0x60000EB  Unity.Mathematics.double3x3 double3x3(System.Single v)
  RVA=0x09C31258  token=0x60000EC  Unity.Mathematics.double3x3 double3x3(Unity.Mathematics.float3x3 v)
  RVA=0x09C56D48  token=0x60000ED  Unity.Mathematics.double3x3 transpose(Unity.Mathematics.double3x3 v)
  RVA=0x09C3EADC  token=0x60000EE  Unity.Mathematics.double3x3 inverse(Unity.Mathematics.double3x3 m)
  RVA=0x03D79570  token=0x60000EF  System.Double determinant(Unity.Mathematics.double3x3 m)
  RVA=0x09C36F8C  token=0x60000F0  System.UInt32 hash(Unity.Mathematics.double3x3 v)
  RVA=0x09C3BA2C  token=0x60000F1  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.double3x3 v)
  RVA=0x03D7A240  token=0x60000F2  Unity.Mathematics.double3x4 double3x4(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1, Unity.Mathematics.double3 c2, Unity.Mathematics.double3 c3)
  RVA=0x04D2FD68  token=0x60000F3  Unity.Mathematics.double3x4 double3x4(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13, System.Double m20, System.Double m21, System.Double m22, System.Double m23)
  RVA=0x09C313F8  token=0x60000F4  Unity.Mathematics.double3x4 double3x4(System.Double v)
  RVA=0x09C31598  token=0x60000F5  Unity.Mathematics.double3x4 double3x4(System.Boolean v)
  RVA=0x04D2FF90  token=0x60000F6  Unity.Mathematics.double3x4 double3x4(Unity.Mathematics.bool3x4 v)
  RVA=0x09C31424  token=0x60000F7  Unity.Mathematics.double3x4 double3x4(System.Int32 v)
  RVA=0x09C314A0  token=0x60000F8  Unity.Mathematics.double3x4 double3x4(Unity.Mathematics.int3x4 v)
  RVA=0x09C3151C  token=0x60000F9  Unity.Mathematics.double3x4 double3x4(System.UInt32 v)
  RVA=0x09C31548  token=0x60000FA  Unity.Mathematics.double3x4 double3x4(Unity.Mathematics.uint3x4 v)
  RVA=0x09C314F0  token=0x60000FB  Unity.Mathematics.double3x4 double3x4(System.Single v)
  RVA=0x09C31450  token=0x60000FC  Unity.Mathematics.double3x4 double3x4(Unity.Mathematics.float3x4 v)
  RVA=0x09C5745C  token=0x60000FD  Unity.Mathematics.double4x3 transpose(Unity.Mathematics.double3x4 v)
  RVA=0x09C33AA8  token=0x60000FE  Unity.Mathematics.double3x4 fastinverse(Unity.Mathematics.double3x4 m)
  RVA=0x09C35BB4  token=0x60000FF  System.UInt32 hash(Unity.Mathematics.double3x4 v)
  RVA=0x09C3B274  token=0x6000100  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.double3x4 v)
  RVA=0x03D7A370  token=0x6000101  Unity.Mathematics.double4 double4(System.Double x, System.Double y, System.Double z, System.Double w)
  RVA=0x03D7A290  token=0x6000102  Unity.Mathematics.double4 double4(System.Double x, System.Double y, Unity.Mathematics.double2 zw)
  RVA=0x03D7A2B0  token=0x6000103  Unity.Mathematics.double4 double4(System.Double x, Unity.Mathematics.double2 yz, System.Double w)
  RVA=0x03D7A3C0  token=0x6000104  Unity.Mathematics.double4 double4(System.Double x, Unity.Mathematics.double3 yzw)
  RVA=0x03D7A420  token=0x6000105  Unity.Mathematics.double4 double4(Unity.Mathematics.double2 xy, System.Double z, System.Double w)
  RVA=0x03D7A390  token=0x6000106  Unity.Mathematics.double4 double4(Unity.Mathematics.double2 xy, Unity.Mathematics.double2 zw)
  RVA=0x03D7A300  token=0x6000107  Unity.Mathematics.double4 double4(Unity.Mathematics.double3 xyz, System.Double w)
  RVA=0x09C31608  token=0x6000108  Unity.Mathematics.double4 double4(Unity.Mathematics.double4 xyzw)
  RVA=0x03D7A2D0  token=0x6000109  Unity.Mathematics.double4 double4(System.Double v)
  RVA=0x09C3167C  token=0x600010A  Unity.Mathematics.double4 double4(System.Boolean v)
  RVA=0x09C315EC  token=0x600010B  Unity.Mathematics.double4 double4(Unity.Mathematics.bool4 v)
  RVA=0x03D7A330  token=0x600010C  Unity.Mathematics.double4 double4(System.Int32 v)
  RVA=0x09C31698  token=0x600010D  Unity.Mathematics.double4 double4(Unity.Mathematics.int4 v)
  RVA=0x03D7A3F0  token=0x600010E  Unity.Mathematics.double4 double4(System.UInt32 v)
  RVA=0x09C316C0  token=0x600010F  Unity.Mathematics.double4 double4(Unity.Mathematics.uint4 v)
  RVA=0x09C31630  token=0x6000110  Unity.Mathematics.double4 double4(Unity.Mathematics.half v)
  RVA=0x09C315C8  token=0x6000111  Unity.Mathematics.double4 double4(Unity.Mathematics.half4 v)
  RVA=0x03D7A2E0  token=0x6000112  Unity.Mathematics.double4 double4(System.Single v)
  RVA=0x09C31654  token=0x6000113  Unity.Mathematics.double4 double4(Unity.Mathematics.float4 v)
  RVA=0x09C36424  token=0x6000114  System.UInt32 hash(Unity.Mathematics.double4 v)
  RVA=0x09C399A8  token=0x6000115  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.double4 v)
  RVA=0x09C5485C  token=0x6000116  System.Double shuffle(Unity.Mathematics.double4 left, Unity.Mathematics.double4 right, Unity.Mathematics.math.ShuffleComponent x)
  RVA=0x09C540C8  token=0x6000117  Unity.Mathematics.double2 shuffle(Unity.Mathematics.double4 left, Unity.Mathematics.double4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  RVA=0x09C54168  token=0x6000118  Unity.Mathematics.double3 shuffle(Unity.Mathematics.double4 left, Unity.Mathematics.double4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  RVA=0x09C53F28  token=0x6000119  Unity.Mathematics.double4 shuffle(Unity.Mathematics.double4 left, Unity.Mathematics.double4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  RVA=0x09C536FC  token=0x600011A  System.Double select_shuffle_component(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b, Unity.Mathematics.math.ShuffleComponent component)
  RVA=0x03D7A440  token=0x600011B  Unity.Mathematics.double4x2 double4x2(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1)
  RVA=0x04D300BC  token=0x600011C  Unity.Mathematics.double4x2 double4x2(System.Double m00, System.Double m01, System.Double m10, System.Double m11, System.Double m20, System.Double m21, System.Double m30, System.Double m31)
  RVA=0x09C31748  token=0x600011D  Unity.Mathematics.double4x2 double4x2(System.Double v)
  RVA=0x09C31790  token=0x600011E  Unity.Mathematics.double4x2 double4x2(System.Boolean v)
  RVA=0x09C31818  token=0x600011F  Unity.Mathematics.double4x2 double4x2(Unity.Mathematics.bool4x2 v)
  RVA=0x09C3176C  token=0x6000120  Unity.Mathematics.double4x2 double4x2(System.Int32 v)
  RVA=0x09C3170C  token=0x6000121  Unity.Mathematics.double4x2 double4x2(Unity.Mathematics.int4x2 v)
  RVA=0x09C317B4  token=0x6000122  Unity.Mathematics.double4x2 double4x2(System.UInt32 v)
  RVA=0x09C31840  token=0x6000123  Unity.Mathematics.double4x2 double4x2(Unity.Mathematics.uint4x2 v)
  RVA=0x09C316E8  token=0x6000124  Unity.Mathematics.double4x2 double4x2(System.Single v)
  RVA=0x09C317DC  token=0x6000125  Unity.Mathematics.double4x2 double4x2(Unity.Mathematics.float4x2 v)
  RVA=0x09C56BF0  token=0x6000126  Unity.Mathematics.double2x4 transpose(Unity.Mathematics.double4x2 v)
  RVA=0x09C37B64  token=0x6000127  System.UInt32 hash(Unity.Mathematics.double4x2 v)
  RVA=0x09C3A3A0  token=0x6000128  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.double4x2 v)
  RVA=0x03D7A470  token=0x6000129  Unity.Mathematics.double4x3 double4x3(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1, Unity.Mathematics.double4 c2)
  RVA=0x04D30200  token=0x600012A  Unity.Mathematics.double4x3 double4x3(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12, System.Double m20, System.Double m21, System.Double m22, System.Double m30, System.Double m31, System.Double m32)
  RVA=0x09C318CC  token=0x600012B  Unity.Mathematics.double4x3 double4x3(System.Double v)
  RVA=0x09C319A4  token=0x600012C  Unity.Mathematics.double4x3 double4x3(System.Boolean v)
  RVA=0x04D301B8  token=0x600012D  Unity.Mathematics.double4x3 double4x3(Unity.Mathematics.bool4x3 v)
  RVA=0x09C318F8  token=0x600012E  Unity.Mathematics.double4x3 double4x3(System.Int32 v)
  RVA=0x09C31954  token=0x600012F  Unity.Mathematics.double4x3 double4x3(Unity.Mathematics.int4x3 v)
  RVA=0x09C31924  token=0x6000130  Unity.Mathematics.double4x3 double4x3(System.UInt32 v)
  RVA=0x09C3187C  token=0x6000131  Unity.Mathematics.double4x3 double4x3(Unity.Mathematics.uint4x3 v)
  RVA=0x09C319D0  token=0x6000132  Unity.Mathematics.double4x3 double4x3(System.Single v)
  RVA=0x09C319FC  token=0x6000133  Unity.Mathematics.double4x3 double4x3(Unity.Mathematics.float4x3 v)
  RVA=0x09C571B8  token=0x6000134  Unity.Mathematics.double3x4 transpose(Unity.Mathematics.double4x3 v)
  RVA=0x09C37970  token=0x6000135  System.UInt32 hash(Unity.Mathematics.double4x3 v)
  RVA=0x09C39FC4  token=0x6000136  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.double4x3 v)
  RVA=0x03D7A4B0  token=0x6000137  Unity.Mathematics.double4x4 double4x4(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1, Unity.Mathematics.double4 c2, Unity.Mathematics.double4 c3)
  RVA=0x04D30518  token=0x6000138  Unity.Mathematics.double4x4 double4x4(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13, System.Double m20, System.Double m21, System.Double m22, System.Double m23, System.Double m30, System.Double m31, System.Double m32, System.Double m33)
  RVA=0x09C31A84  token=0x6000139  Unity.Mathematics.double4x4 double4x4(System.Double v)
  RVA=0x09C31AB8  token=0x600013A  Unity.Mathematics.double4x4 double4x4(System.Boolean v)
  RVA=0x09C31C34  token=0x600013B  Unity.Mathematics.double4x4 double4x4(Unity.Mathematics.bool4x4 v)
  RVA=0x09C31C78  token=0x600013C  Unity.Mathematics.double4x4 double4x4(System.Int32 v)
  RVA=0x09C31AEC  token=0x600013D  Unity.Mathematics.double4x4 double4x4(Unity.Mathematics.int4x4 v)
  RVA=0x09C31A4C  token=0x600013E  Unity.Mathematics.double4x4 double4x4(System.UInt32 v)
  RVA=0x09C31B48  token=0x600013F  Unity.Mathematics.double4x4 double4x4(Unity.Mathematics.uint4x4 v)
  RVA=0x09C31C00  token=0x6000140  Unity.Mathematics.double4x4 double4x4(System.Single v)
  RVA=0x09C31BA4  token=0x6000141  Unity.Mathematics.double4x4 double4x4(Unity.Mathematics.float4x4 v)
  RVA=0x09C52A48  token=0x6000142  Unity.Mathematics.double3 rotate(Unity.Mathematics.double4x4 a, Unity.Mathematics.double3 b)
  RVA=0x09C564E4  token=0x6000143  Unity.Mathematics.double3 transform(Unity.Mathematics.double4x4 a, Unity.Mathematics.double3 b)
  RVA=0x09C56E94  token=0x6000144  Unity.Mathematics.double4x4 transpose(Unity.Mathematics.double4x4 v)
  RVA=0x09C3DBC8  token=0x6000145  Unity.Mathematics.double4x4 inverse(Unity.Mathematics.double4x4 m)
  RVA=0x09C33428  token=0x6000146  Unity.Mathematics.double4x4 fastinverse(Unity.Mathematics.double4x4 m)
  RVA=0x03D79300  token=0x6000147  System.Double determinant(Unity.Mathematics.double4x4 m)
  RVA=0x09C36218  token=0x6000148  System.UInt32 hash(Unity.Mathematics.double4x4 v)
  RVA=0x09C3908C  token=0x6000149  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.double4x4 v)
  RVA=0x03D7A720  token=0x600014A  Unity.Mathematics.float2 float2(System.Single x, System.Single y)
  RVA=0x03D730E0  token=0x600014B  Unity.Mathematics.float2 float2(Unity.Mathematics.float2 xy)
  RVA=0x03D543C0  token=0x600014C  Unity.Mathematics.float2 float2(System.Single v)
  RVA=0x09C33DE0  token=0x600014D  Unity.Mathematics.float2 float2(System.Boolean v)
  RVA=0x09C33E00  token=0x600014E  Unity.Mathematics.float2 float2(Unity.Mathematics.bool2 v)
  RVA=0x03D7A730  token=0x600014F  Unity.Mathematics.float2 float2(System.Int32 v)
  RVA=0x03D7A750  token=0x6000150  Unity.Mathematics.float2 float2(Unity.Mathematics.int2 v)
  RVA=0x03D7A7A0  token=0x6000151  Unity.Mathematics.float2 float2(System.UInt32 v)
  RVA=0x03D7A770  token=0x6000152  Unity.Mathematics.float2 float2(Unity.Mathematics.uint2 v)
  RVA=0x09C33E50  token=0x6000153  Unity.Mathematics.float2 float2(Unity.Mathematics.half v)
  RVA=0x09C33E24  token=0x6000154  Unity.Mathematics.float2 float2(Unity.Mathematics.half2 v)
  RVA=0x03D7A7D0  token=0x6000155  Unity.Mathematics.float2 float2(System.Double v)
  RVA=0x03D7A700  token=0x6000156  Unity.Mathematics.float2 float2(Unity.Mathematics.double2 v)
  RVA=0x09C35A50  token=0x6000157  System.UInt32 hash(Unity.Mathematics.float2 v)
  RVA=0x09C3C098  token=0x6000158  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.float2 v)
  RVA=0x04D5898C  token=0x6000159  System.Single shuffle(Unity.Mathematics.float2 left, Unity.Mathematics.float2 right, Unity.Mathematics.math.ShuffleComponent x)
  RVA=0x04D59134  token=0x600015A  Unity.Mathematics.float2 shuffle(Unity.Mathematics.float2 left, Unity.Mathematics.float2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  RVA=0x04D59328  token=0x600015B  Unity.Mathematics.float3 shuffle(Unity.Mathematics.float2 left, Unity.Mathematics.float2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  RVA=0x04D58B70  token=0x600015C  Unity.Mathematics.float4 shuffle(Unity.Mathematics.float2 left, Unity.Mathematics.float2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  RVA=0x04D57BE4  token=0x600015D  System.Single select_shuffle_component(Unity.Mathematics.float2 a, Unity.Mathematics.float2 b, Unity.Mathematics.math.ShuffleComponent component)
  RVA=0x02232AA0  token=0x600015E  Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1)
  RVA=0x09C33E90  token=0x600015F  Unity.Mathematics.float2x2 float2x2(System.Single m00, System.Single m01, System.Single m10, System.Single m11)
  RVA=0x09C33E78  token=0x6000160  Unity.Mathematics.float2x2 float2x2(System.Single v)
  RVA=0x09C33F78  token=0x6000161  Unity.Mathematics.float2x2 float2x2(System.Boolean v)
  RVA=0x09C33F90  token=0x6000162  Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.bool2x2 v)
  RVA=0x09C33EDC  token=0x6000163  Unity.Mathematics.float2x2 float2x2(System.Int32 v)
  RVA=0x09C33F54  token=0x6000164  Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.int2x2 v)
  RVA=0x09C33F24  token=0x6000165  Unity.Mathematics.float2x2 float2x2(System.UInt32 v)
  RVA=0x09C33EB4  token=0x6000166  Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.uint2x2 v)
  RVA=0x09C33F3C  token=0x6000167  Unity.Mathematics.float2x2 float2x2(System.Double v)
  RVA=0x09C33EF4  token=0x6000168  Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.double2x2 v)
  RVA=0x09C56848  token=0x6000169  Unity.Mathematics.float2x2 transpose(Unity.Mathematics.float2x2 v)
  RVA=0x04D3B638  token=0x600016A  Unity.Mathematics.float2x2 inverse(Unity.Mathematics.float2x2 m)
  RVA=0x03D79C40  token=0x600016B  System.Single determinant(Unity.Mathematics.float2x2 m)
  RVA=0x09C380A0  token=0x600016C  System.UInt32 hash(Unity.Mathematics.float2x2 v)
  RVA=0x09C3C454  token=0x600016D  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.float2x2 v)
  RVA=0x03D7A7F0  token=0x600016E  Unity.Mathematics.float2x3 float2x3(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1, Unity.Mathematics.float2 c2)
  RVA=0x04D31F5C  token=0x600016F  Unity.Mathematics.float2x3 float2x3(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12)
  RVA=0x09C33FAC  token=0x6000170  Unity.Mathematics.float2x3 float2x3(System.Single v)
  RVA=0x09C3400C  token=0x6000171  Unity.Mathematics.float2x3 float2x3(System.Boolean v)
  RVA=0x09C34068  token=0x6000172  Unity.Mathematics.float2x3 float2x3(Unity.Mathematics.bool2x3 v)
  RVA=0x09C340D4  token=0x6000173  Unity.Mathematics.float2x3 float2x3(System.Int32 v)
  RVA=0x09C340F4  token=0x6000174  Unity.Mathematics.float2x3 float2x3(Unity.Mathematics.int2x3 v)
  RVA=0x09C33FEC  token=0x6000175  Unity.Mathematics.float2x3 float2x3(System.UInt32 v)
  RVA=0x09C3409C  token=0x6000176  Unity.Mathematics.float2x3 float2x3(Unity.Mathematics.uint2x3 v)
  RVA=0x09C33FCC  token=0x6000177  Unity.Mathematics.float2x3 float2x3(System.Double v)
  RVA=0x09C3402C  token=0x6000178  Unity.Mathematics.float2x3 float2x3(Unity.Mathematics.double2x3 v)
  RVA=0x09C56FEC  token=0x6000179  Unity.Mathematics.float3x2 transpose(Unity.Mathematics.float2x3 v)
  RVA=0x09C36804  token=0x600017A  System.UInt32 hash(Unity.Mathematics.float2x3 v)
  RVA=0x09C3975C  token=0x600017B  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.float2x3 v)
  RVA=0x03D7A800  token=0x600017C  Unity.Mathematics.float2x4 float2x4(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1, Unity.Mathematics.float2 c2, Unity.Mathematics.float2 c3)
  RVA=0x04D31FA0  token=0x600017D  Unity.Mathematics.float2x4 float2x4(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13)
  RVA=0x09C341E4  token=0x600017E  Unity.Mathematics.float2x4 float2x4(System.Single v)
  RVA=0x09C3412C  token=0x600017F  Unity.Mathematics.float2x4 float2x4(System.Boolean v)
  RVA=0x09C3418C  token=0x6000180  Unity.Mathematics.float2x4 float2x4(Unity.Mathematics.bool2x4 v)
  RVA=0x09C341C8  token=0x6000181  Unity.Mathematics.float2x4 float2x4(System.Int32 v)
  RVA=0x09C34250  token=0x6000182  Unity.Mathematics.float2x4 float2x4(Unity.Mathematics.int2x4 v)
  RVA=0x09C341AC  token=0x6000183  Unity.Mathematics.float2x4 float2x4(System.UInt32 v)
  RVA=0x09C3421C  token=0x6000184  Unity.Mathematics.float2x4 float2x4(Unity.Mathematics.uint2x4 v)
  RVA=0x09C34200  token=0x6000185  Unity.Mathematics.float2x4 float2x4(System.Double v)
  RVA=0x09C34148  token=0x6000186  Unity.Mathematics.float2x4 float2x4(Unity.Mathematics.double2x4 v)
  RVA=0x09C56DBC  token=0x6000187  Unity.Mathematics.float4x2 transpose(Unity.Mathematics.float2x4 v)
  RVA=0x09C3749C  token=0x6000188  System.UInt32 hash(Unity.Mathematics.float2x4 v)
  RVA=0x09C3ACB0  token=0x6000189  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.float2x4 v)
  RVA=0x03D6D520  token=0x600018A  Unity.Mathematics.float3 float3(System.Single x, System.Single y, System.Single z)
  RVA=0x03D7A980  token=0x600018B  Unity.Mathematics.float3 float3(System.Single x, Unity.Mathematics.float2 yz)
  RVA=0x03D7A8C0  token=0x600018C  Unity.Mathematics.float3 float3(Unity.Mathematics.float2 xy, System.Single z)
  RVA=0x03D7A8F0  token=0x600018D  Unity.Mathematics.float3 float3(Unity.Mathematics.float3 xyz)
  RVA=0x03D54500  token=0x600018E  Unity.Mathematics.float3 float3(System.Single v)
  RVA=0x09C34284  token=0x600018F  Unity.Mathematics.float3 float3(System.Boolean v)
  RVA=0x09C34328  token=0x6000190  Unity.Mathematics.float3 float3(Unity.Mathematics.bool3 v)
  RVA=0x03D7A860  token=0x6000191  Unity.Mathematics.float3 float3(System.Int32 v)
  RVA=0x03D7A9F0  token=0x6000192  Unity.Mathematics.float3 float3(Unity.Mathematics.int3 v)
  RVA=0x03D7A9B0  token=0x6000193  Unity.Mathematics.float3 float3(System.UInt32 v)
  RVA=0x03D7A920  token=0x6000194  Unity.Mathematics.float3 float3(Unity.Mathematics.uint3 v)
  RVA=0x09C342A0  token=0x6000195  Unity.Mathematics.float3 float3(Unity.Mathematics.half v)
  RVA=0x09C342DC  token=0x6000196  Unity.Mathematics.float3 float3(Unity.Mathematics.half3 v)
  RVA=0x03D7A890  token=0x6000197  Unity.Mathematics.float3 float3(System.Double v)
  RVA=0x03D7A820  token=0x6000198  Unity.Mathematics.float3 float3(Unity.Mathematics.double3 v)
  RVA=0x04D3591C  token=0x6000199  System.UInt32 hash(Unity.Mathematics.float3 v)
  RVA=0x04D38368  token=0x600019A  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.float3 v)
  RVA=0x04D593E8  token=0x600019B  System.Single shuffle(Unity.Mathematics.float3 left, Unity.Mathematics.float3 right, Unity.Mathematics.math.ShuffleComponent x)
  RVA=0x04D59AD4  token=0x600019C  Unity.Mathematics.float2 shuffle(Unity.Mathematics.float3 left, Unity.Mathematics.float3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  RVA=0x04D59E80  token=0x600019D  Unity.Mathematics.float3 shuffle(Unity.Mathematics.float3 left, Unity.Mathematics.float3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  RVA=0x04D59C68  token=0x600019E  Unity.Mathematics.float4 shuffle(Unity.Mathematics.float3 left, Unity.Mathematics.float3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  RVA=0x04D57364  token=0x600019F  System.Single select_shuffle_component(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.math.ShuffleComponent component)
  RVA=0x03D7AA40  token=0x60001A0  Unity.Mathematics.float3x2 float3x2(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1)
  RVA=0x04D3200C  token=0x60001A1  Unity.Mathematics.float3x2 float3x2(System.Single m00, System.Single m01, System.Single m10, System.Single m11, System.Single m20, System.Single m21)
  RVA=0x09C344C0  token=0x60001A2  Unity.Mathematics.float3x2 float3x2(System.Single v)
  RVA=0x09C343D0  token=0x60001A3  Unity.Mathematics.float3x2 float3x2(System.Boolean v)
  RVA=0x09C34488  token=0x60001A4  Unity.Mathematics.float3x2 float3x2(Unity.Mathematics.bool3x2 v)
  RVA=0x09C343F0  token=0x60001A5  Unity.Mathematics.float3x2 float3x2(System.Int32 v)
  RVA=0x09C34430  token=0x60001A6  Unity.Mathematics.float3x2 float3x2(Unity.Mathematics.int3x2 v)
  RVA=0x09C34468  token=0x60001A7  Unity.Mathematics.float3x2 float3x2(System.UInt32 v)
  RVA=0x09C34398  token=0x60001A8  Unity.Mathematics.float3x2 float3x2(Unity.Mathematics.uint3x2 v)
  RVA=0x09C34410  token=0x60001A9  Unity.Mathematics.float3x2 float3x2(System.Double v)
  RVA=0x09C34358  token=0x60001AA  Unity.Mathematics.float3x2 float3x2(Unity.Mathematics.double3x2 v)
  RVA=0x09C570F0  token=0x60001AB  Unity.Mathematics.float2x3 transpose(Unity.Mathematics.float3x2 v)
  RVA=0x09C38894  token=0x60001AC  System.UInt32 hash(Unity.Mathematics.float3x2 v)
  RVA=0x09C39BA8  token=0x60001AD  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.float3x2 v)
  RVA=0x02E246E0  token=0x60001AE  Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2)
  RVA=0x04D320FC  token=0x60001AF  Unity.Mathematics.float3x3 float3x3(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12, System.Single m20, System.Single m21, System.Single m22)
  RVA=0x09C34500  token=0x60001B0  Unity.Mathematics.float3x3 float3x3(System.Single v)
  RVA=0x09C344E0  token=0x60001B1  Unity.Mathematics.float3x3 float3x3(System.Boolean v)
  RVA=0x09C346E4  token=0x60001B2  Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.bool3x3 v)
  RVA=0x09C3460C  token=0x60001B3  Unity.Mathematics.float3x3 float3x3(System.Int32 v)
  RVA=0x09C34578  token=0x60001B4  Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.int3x3 v)
  RVA=0x09C346A4  token=0x60001B5  Unity.Mathematics.float3x3 float3x3(System.UInt32 v)
  RVA=0x09C34664  token=0x60001B6  Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.uint3x3 v)
  RVA=0x09C346C4  token=0x60001B7  Unity.Mathematics.float3x3 float3x3(System.Double v)
  RVA=0x09C34520  token=0x60001B8  Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.double3x3 v)
  RVA=0x09C573D8  token=0x60001B9  Unity.Mathematics.float3x3 transpose(Unity.Mathematics.float3x3 v)
  RVA=0x09C3D808  token=0x60001BA  Unity.Mathematics.float3x3 inverse(Unity.Mathematics.float3x3 m)
  RVA=0x03D79AC0  token=0x60001BB  System.Single determinant(Unity.Mathematics.float3x3 m)
  RVA=0x09C38594  token=0x60001BC  System.UInt32 hash(Unity.Mathematics.float3x3 v)
  RVA=0x09C39A3C  token=0x60001BD  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.float3x3 v)
  RVA=0x03D7AA70  token=0x60001BE  Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2, Unity.Mathematics.float3 c3)
  RVA=0x04D322AC  token=0x60001BF  Unity.Mathematics.float3x4 float3x4(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13, System.Single m20, System.Single m21, System.Single m22, System.Single m23)
  RVA=0x09C34898  token=0x60001C0  Unity.Mathematics.float3x4 float3x4(System.Single v)
  RVA=0x09C34780  token=0x60001C1  Unity.Mathematics.float3x4 float3x4(System.Boolean v)
  RVA=0x09C34744  token=0x60001C2  Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.bool3x4 v)
  RVA=0x09C34834  token=0x60001C3  Unity.Mathematics.float3x4 float3x4(System.Int32 v)
  RVA=0x09C34854  token=0x60001C4  Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.int3x4 v)
  RVA=0x09C3495C  token=0x60001C5  Unity.Mathematics.float3x4 float3x4(System.UInt32 v)
  RVA=0x09C34918  token=0x60001C6  Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.uint3x4 v)
  RVA=0x09C34724  token=0x60001C7  Unity.Mathematics.float3x4 float3x4(System.Double v)
  RVA=0x09C348B8  token=0x60001C8  Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.double3x4 v)
  RVA=0x09C56F48  token=0x60001C9  Unity.Mathematics.float4x3 transpose(Unity.Mathematics.float3x4 v)
  RVA=0x09C3389C  token=0x60001CA  Unity.Mathematics.float3x4 fastinverse(Unity.Mathematics.float3x4 m)
  RVA=0x09C35EBC  token=0x60001CB  System.UInt32 hash(Unity.Mathematics.float3x4 v)
  RVA=0x09C393E0  token=0x60001CC  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.float3x4 v)
  RVA=0x03D7AAC0  token=0x60001CD  Unity.Mathematics.float4 float4(System.Single x, System.Single y, System.Single z, System.Single w)
  RVA=0x03D7AAF0  token=0x60001CE  Unity.Mathematics.float4 float4(System.Single x, System.Single y, Unity.Mathematics.float2 zw)
  RVA=0x03D7AB90  token=0x60001CF  Unity.Mathematics.float4 float4(System.Single x, Unity.Mathematics.float2 yz, System.Single w)
  RVA=0x03D7AC10  token=0x60001D0  Unity.Mathematics.float4 float4(System.Single x, Unity.Mathematics.float3 yzw)
  RVA=0x03D7AB20  token=0x60001D1  Unity.Mathematics.float4 float4(Unity.Mathematics.float2 xy, System.Single z, System.Single w)
  RVA=0x03D4E3B0  token=0x60001D2  Unity.Mathematics.float4 float4(Unity.Mathematics.float2 xy, Unity.Mathematics.float2 zw)
  RVA=0x03D7AC50  token=0x60001D3  Unity.Mathematics.float4 float4(Unity.Mathematics.float3 xyz, System.Single w)
  RVA=0x09C34AEC  token=0x60001D4  Unity.Mathematics.float4 float4(Unity.Mathematics.float4 xyzw)
  RVA=0x03D7AAE0  token=0x60001D5  Unity.Mathematics.float4 float4(System.Single v)
  RVA=0x09C34AB0  token=0x60001D6  Unity.Mathematics.float4 float4(System.Boolean v)
  RVA=0x09C349AC  token=0x60001D7  Unity.Mathematics.float4 float4(Unity.Mathematics.bool4 v)
  RVA=0x03D7AB70  token=0x60001D8  Unity.Mathematics.float4 float4(System.Int32 v)
  RVA=0x09C34A6C  token=0x60001D9  Unity.Mathematics.float4 float4(Unity.Mathematics.int4 v)
  RVA=0x03D7ABC0  token=0x60001DA  Unity.Mathematics.float4 float4(System.UInt32 v)
  RVA=0x09C34AC8  token=0x60001DB  Unity.Mathematics.float4 float4(Unity.Mathematics.uint4 v)
  RVA=0x09C34A20  token=0x60001DC  Unity.Mathematics.float4 float4(Unity.Mathematics.half v)
  RVA=0x09C349C4  token=0x60001DD  Unity.Mathematics.float4 float4(Unity.Mathematics.half4 v)
  RVA=0x03D7AB50  token=0x60001DE  Unity.Mathematics.float4 float4(System.Double v)
  RVA=0x09C3497C  token=0x60001DF  Unity.Mathematics.float4 float4(Unity.Mathematics.double4 v)
  RVA=0x09C369E8  token=0x60001E0  System.UInt32 hash(Unity.Mathematics.float4 v)
  RVA=0x09C398EC  token=0x60001E1  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.float4 v)
  RVA=0x09C53D94  token=0x60001E2  System.Single shuffle(Unity.Mathematics.float4 left, Unity.Mathematics.float4 right, Unity.Mathematics.math.ShuffleComponent x)
  RVA=0x09C54950  token=0x60001E3  Unity.Mathematics.float2 shuffle(Unity.Mathematics.float4 left, Unity.Mathematics.float4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  RVA=0x09C544D8  token=0x60001E4  Unity.Mathematics.float3 shuffle(Unity.Mathematics.float4 left, Unity.Mathematics.float4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  RVA=0x09C54264  token=0x60001E5  Unity.Mathematics.float4 shuffle(Unity.Mathematics.float4 left, Unity.Mathematics.float4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  RVA=0x09C53950  token=0x60001E6  System.Single select_shuffle_component(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b, Unity.Mathematics.math.ShuffleComponent component)
  RVA=0x03D7AC80  token=0x60001E7  Unity.Mathematics.float4x2 float4x2(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1)
  RVA=0x04D323EC  token=0x60001E8  Unity.Mathematics.float4x2 float4x2(System.Single m00, System.Single m01, System.Single m10, System.Single m11, System.Single m20, System.Single m21, System.Single m30, System.Single m31)
  RVA=0x09C34B68  token=0x60001E9  Unity.Mathematics.float4x2 float4x2(System.Single v)
  RVA=0x09C34C38  token=0x60001EA  Unity.Mathematics.float4x2 float4x2(System.Boolean v)
  RVA=0x09C34C54  token=0x60001EB  Unity.Mathematics.float4x2 float4x2(Unity.Mathematics.bool4x2 v)
  RVA=0x09C34BFC  token=0x60001EC  Unity.Mathematics.float4x2 float4x2(System.Int32 v)
  RVA=0x09C34BC8  token=0x60001ED  Unity.Mathematics.float4x2 float4x2(Unity.Mathematics.int4x2 v)
  RVA=0x09C34C18  token=0x60001EE  Unity.Mathematics.float4x2 float4x2(System.UInt32 v)
  RVA=0x09C34B34  token=0x60001EF  Unity.Mathematics.float4x2 float4x2(Unity.Mathematics.uint4x2 v)
  RVA=0x09C34B18  token=0x60001F0  Unity.Mathematics.float4x2 float4x2(System.Double v)
  RVA=0x09C34B84  token=0x60001F1  Unity.Mathematics.float4x2 float4x2(Unity.Mathematics.double4x2 v)
  RVA=0x09C5714C  token=0x60001F2  Unity.Mathematics.float2x4 transpose(Unity.Mathematics.float4x2 v)
  RVA=0x09C36EC0  token=0x60001F3  System.UInt32 hash(Unity.Mathematics.float4x2 v)
  RVA=0x09C3BFC0  token=0x60001F4  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.float4x2 v)
  RVA=0x03D7ACA0  token=0x60001F5  Unity.Mathematics.float4x3 float4x3(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2)
  RVA=0x04D324B8  token=0x60001F6  Unity.Mathematics.float4x3 float4x3(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12, System.Single m20, System.Single m21, System.Single m22, System.Single m30, System.Single m31, System.Single m32)
  RVA=0x09C34D9C  token=0x60001F7  Unity.Mathematics.float4x3 float4x3(System.Single v)
  RVA=0x09C34DBC  token=0x60001F8  Unity.Mathematics.float4x3 float4x3(System.Boolean v)
  RVA=0x09C34D1C  token=0x60001F9  Unity.Mathematics.float4x3 float4x3(Unity.Mathematics.bool4x3 v)
  RVA=0x09C34DDC  token=0x60001FA  Unity.Mathematics.float4x3 float4x3(System.Int32 v)
  RVA=0x09C34DFC  token=0x60001FB  Unity.Mathematics.float4x3 float4x3(Unity.Mathematics.int4x3 v)
  RVA=0x09C34CF8  token=0x60001FC  Unity.Mathematics.float4x3 float4x3(System.UInt32 v)
  RVA=0x09C34D58  token=0x60001FD  Unity.Mathematics.float4x3 float4x3(Unity.Mathematics.uint4x3 v)
  RVA=0x09C34CD8  token=0x60001FE  Unity.Mathematics.float4x3 float4x3(System.Double v)
  RVA=0x09C34C78  token=0x60001FF  Unity.Mathematics.float4x3 float4x3(Unity.Mathematics.double4x3 v)
  RVA=0x09C56AF8  token=0x6000200  Unity.Mathematics.float3x4 transpose(Unity.Mathematics.float4x3 v)
  RVA=0x09C38104  token=0x6000201  System.UInt32 hash(Unity.Mathematics.float4x3 v)
  RVA=0x09C392A4  token=0x6000202  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.float4x3 v)
  RVA=0x03D7ACC0  token=0x6000203  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2, Unity.Mathematics.float4 c3)
  RVA=0x09C34E3C  token=0x6000204  Unity.Mathematics.float4x4 float4x4(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13, System.Single m20, System.Single m21, System.Single m22, System.Single m23, System.Single m30, System.Single m31, System.Single m32, System.Single m33)
  RVA=0x02E25B00  token=0x6000205  Unity.Mathematics.float4x4 float4x4(System.Single v)
  RVA=0x09C352B8  token=0x6000206  Unity.Mathematics.float4x4 float4x4(System.Boolean v)
  RVA=0x09C35368  token=0x6000207  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.bool4x4 v)
  RVA=0x09C352DC  token=0x6000208  Unity.Mathematics.float4x4 float4x4(System.Int32 v)
  RVA=0x09C34F8C  token=0x6000209  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.int4x4 v)
  RVA=0x09C34F64  token=0x600020A  Unity.Mathematics.float4x4 float4x4(System.UInt32 v)
  RVA=0x09C351E8  token=0x600020B  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.uint4x4 v)
  RVA=0x09C34FE8  token=0x600020C  Unity.Mathematics.float4x4 float4x4(System.Double v)
  RVA=0x09C35060  token=0x600020D  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.double4x4 v)
  RVA=0x09C52970  token=0x600020E  Unity.Mathematics.float3 rotate(Unity.Mathematics.float4x4 a, Unity.Mathematics.float3 b)
  RVA=0x09C56668  token=0x600020F  Unity.Mathematics.float3 transform(Unity.Mathematics.float4x4 a, Unity.Mathematics.float3 b)
  RVA=0x09C572FC  token=0x6000210  Unity.Mathematics.float4x4 transpose(Unity.Mathematics.float4x4 v)
  RVA=0x02E260E0  token=0x6000211  Unity.Mathematics.float4x4 inverse(Unity.Mathematics.float4x4 m)
  RVA=0x09C33128  token=0x6000212  Unity.Mathematics.float4x4 fastinverse(Unity.Mathematics.float4x4 m)
  RVA=0x03D79630  token=0x6000213  System.Single determinant(Unity.Mathematics.float4x4 m)
  RVA=0x09C36088  token=0x6000214  System.UInt32 hash(Unity.Mathematics.float4x4 v)
  RVA=0x09C3AB14  token=0x6000215  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.float4x4 v)
  RVA=0x03D4FEA0  token=0x6000216  Unity.Mathematics.half half(Unity.Mathematics.half x)
  RVA=0x09C35A48  token=0x6000217  Unity.Mathematics.half half(System.Single v)
  RVA=0x09C35A3C  token=0x6000218  Unity.Mathematics.half half(System.Double v)
  RVA=0x03D7B4B0  token=0x6000219  System.UInt32 hash(Unity.Mathematics.half v)
  RVA=0x03D78800  token=0x600021A  Unity.Mathematics.half2 half2(Unity.Mathematics.half x, Unity.Mathematics.half y)
  RVA=0x03D76740  token=0x600021B  Unity.Mathematics.half2 half2(Unity.Mathematics.half2 xy)
  RVA=0x03D7B2C0  token=0x600021C  Unity.Mathematics.half2 half2(Unity.Mathematics.half v)
  RVA=0x09C35780  token=0x600021D  Unity.Mathematics.half2 half2(System.Single v)
  RVA=0x09C357A8  token=0x600021E  Unity.Mathematics.half2 half2(Unity.Mathematics.float2 v)
  RVA=0x09C35714  token=0x600021F  Unity.Mathematics.half2 half2(System.Double v)
  RVA=0x09C35748  token=0x6000220  Unity.Mathematics.half2 half2(Unity.Mathematics.double2 v)
  RVA=0x09C386E8  token=0x6000221  System.UInt32 hash(Unity.Mathematics.half2 v)
  RVA=0x09C3B66C  token=0x6000222  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.half2 v)
  RVA=0x03D78810  token=0x6000223  Unity.Mathematics.half3 half3(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half z)
  RVA=0x03D7B310  token=0x6000224  Unity.Mathematics.half3 half3(Unity.Mathematics.half x, Unity.Mathematics.half2 yz)
  RVA=0x03D7B330  token=0x6000225  Unity.Mathematics.half3 half3(Unity.Mathematics.half2 xy, Unity.Mathematics.half z)
  RVA=0x03D7B2D0  token=0x6000226  Unity.Mathematics.half3 half3(Unity.Mathematics.half3 xyz)
  RVA=0x03D7B300  token=0x6000227  Unity.Mathematics.half3 half3(Unity.Mathematics.half v)
  RVA=0x09C358B0  token=0x6000228  Unity.Mathematics.half3 half3(System.Single v)
  RVA=0x09C3586C  token=0x6000229  Unity.Mathematics.half3 half3(Unity.Mathematics.float3 v)
  RVA=0x09C357DC  token=0x600022A  Unity.Mathematics.half3 half3(System.Double v)
  RVA=0x09C35820  token=0x600022B  Unity.Mathematics.half3 half3(Unity.Mathematics.double3 v)
  RVA=0x04D33234  token=0x600022C  System.UInt32 hash(Unity.Mathematics.half3 v)
  RVA=0x04D3930C  token=0x600022D  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.half3 v)
  RVA=0x03D78830  token=0x600022E  Unity.Mathematics.half4 half4(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half z, Unity.Mathematics.half w)
  RVA=0x03D7B420  token=0x600022F  Unity.Mathematics.half4 half4(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half2 zw)
  RVA=0x03D7B3A0  token=0x6000230  Unity.Mathematics.half4 half4(Unity.Mathematics.half x, Unity.Mathematics.half2 yz, Unity.Mathematics.half w)
  RVA=0x03D7B480  token=0x6000231  Unity.Mathematics.half4 half4(Unity.Mathematics.half x, Unity.Mathematics.half3 yzw)
  RVA=0x03D7B350  token=0x6000232  Unity.Mathematics.half4 half4(Unity.Mathematics.half2 xy, Unity.Mathematics.half z, Unity.Mathematics.half w)
  RVA=0x03D7B3D0  token=0x6000233  Unity.Mathematics.half4 half4(Unity.Mathematics.half2 xy, Unity.Mathematics.half2 zw)
  RVA=0x03D7B3F0  token=0x6000234  Unity.Mathematics.half4 half4(Unity.Mathematics.half3 xyz, Unity.Mathematics.half w)
  RVA=0x03D7B450  token=0x6000235  Unity.Mathematics.half4 half4(Unity.Mathematics.half4 xyzw)
  RVA=0x03D7B380  token=0x6000236  Unity.Mathematics.half4 half4(Unity.Mathematics.half v)
  RVA=0x09C3594C  token=0x6000237  Unity.Mathematics.half4 half4(System.Single v)
  RVA=0x09C359E8  token=0x6000238  Unity.Mathematics.half4 half4(Unity.Mathematics.float4 v)
  RVA=0x09C35990  token=0x6000239  Unity.Mathematics.half4 half4(System.Double v)
  RVA=0x09C358E8  token=0x600023A  Unity.Mathematics.half4 half4(Unity.Mathematics.double4 v)
  RVA=0x04D33194  token=0x600023B  System.UInt32 hash(Unity.Mathematics.half4 v)
  RVA=0x04D3AAA4  token=0x600023C  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.half4 v)
  RVA=0x03D78AF0  token=0x600023D  Unity.Mathematics.int2 int2(System.Int32 x, System.Int32 y)
  RVA=0x03D76940  token=0x600023E  Unity.Mathematics.int2 int2(Unity.Mathematics.int2 xy)
  RVA=0x03D7B520  token=0x600023F  Unity.Mathematics.int2 int2(System.Int32 v)
  RVA=0x09C3C78C  token=0x6000240  Unity.Mathematics.int2 int2(System.Boolean v)
  RVA=0x09C3C7A4  token=0x6000241  Unity.Mathematics.int2 int2(Unity.Mathematics.bool2 v)
  RVA=0x03D7B520  token=0x6000242  Unity.Mathematics.int2 int2(System.UInt32 v)
  RVA=0x03D76940  token=0x6000243  Unity.Mathematics.int2 int2(Unity.Mathematics.uint2 v)
  RVA=0x03D7B500  token=0x6000244  Unity.Mathematics.int2 int2(System.Single v)
  RVA=0x03D7B4C0  token=0x6000245  Unity.Mathematics.int2 int2(Unity.Mathematics.float2 v)
  RVA=0x03D7B4E0  token=0x6000246  Unity.Mathematics.int2 int2(System.Double v)
  RVA=0x03D7B530  token=0x6000247  Unity.Mathematics.int2 int2(Unity.Mathematics.double2 v)
  RVA=0x09C37144  token=0x6000248  System.UInt32 hash(Unity.Mathematics.int2 v)
  RVA=0x09C3B82C  token=0x6000249  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.int2 v)
  RVA=0x04D59424  token=0x600024A  System.Int32 shuffle(Unity.Mathematics.int2 left, Unity.Mathematics.int2 right, Unity.Mathematics.math.ShuffleComponent x)
  RVA=0x04D5981C  token=0x600024B  Unity.Mathematics.int2 shuffle(Unity.Mathematics.int2 left, Unity.Mathematics.int2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  RVA=0x04D592B8  token=0x600024C  Unity.Mathematics.int3 shuffle(Unity.Mathematics.int2 left, Unity.Mathematics.int2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  RVA=0x04D588FC  token=0x600024D  Unity.Mathematics.int4 shuffle(Unity.Mathematics.int2 left, Unity.Mathematics.int2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  RVA=0x04D57CE4  token=0x600024E  System.Int32 select_shuffle_component(Unity.Mathematics.int2 a, Unity.Mathematics.int2 b, Unity.Mathematics.math.ShuffleComponent component)
  RVA=0x02232AA0  token=0x600024F  Unity.Mathematics.int2x2 int2x2(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1)
  RVA=0x09C3C820  token=0x6000250  Unity.Mathematics.int2x2 int2x2(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11)
  RVA=0x09C3C808  token=0x6000251  Unity.Mathematics.int2x2 int2x2(System.Int32 v)
  RVA=0x09C3C8C4  token=0x6000252  Unity.Mathematics.int2x2 int2x2(System.Boolean v)
  RVA=0x09C3C7C4  token=0x6000253  Unity.Mathematics.int2x2 int2x2(Unity.Mathematics.bool2x2 v)
  RVA=0x09C3C808  token=0x6000254  Unity.Mathematics.int2x2 int2x2(System.UInt32 v)
  RVA=0x09C3C888  token=0x6000255  Unity.Mathematics.int2x2 int2x2(Unity.Mathematics.uint2x2 v)
  RVA=0x09C3C870  token=0x6000256  Unity.Mathematics.int2x2 int2x2(System.Single v)
  RVA=0x09C3C7E4  token=0x6000257  Unity.Mathematics.int2x2 int2x2(Unity.Mathematics.float2x2 v)
  RVA=0x09C3C8AC  token=0x6000258  Unity.Mathematics.int2x2 int2x2(System.Double v)
  RVA=0x09C3C840  token=0x6000259  Unity.Mathematics.int2x2 int2x2(Unity.Mathematics.double2x2 v)
  RVA=0x09C56888  token=0x600025A  Unity.Mathematics.int2x2 transpose(Unity.Mathematics.int2x2 v)
  RVA=0x03D79560  token=0x600025B  System.Int32 determinant(Unity.Mathematics.int2x2 m)
  RVA=0x09C37B00  token=0x600025C  System.UInt32 hash(Unity.Mathematics.int2x2 v)
  RVA=0x09C3A6B0  token=0x600025D  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.int2x2 v)
  RVA=0x03D7A7F0  token=0x600025E  Unity.Mathematics.int2x3 int2x3(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1, Unity.Mathematics.int2 c2)
  RVA=0x04D3AE7C  token=0x600025F  Unity.Mathematics.int2x3 int2x3(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12)
  RVA=0x09C3C934  token=0x6000260  Unity.Mathematics.int2x3 int2x3(System.Int32 v)
  RVA=0x09C3C9E8  token=0x6000261  Unity.Mathematics.int2x3 int2x3(System.Boolean v)
  RVA=0x09C3C974  token=0x6000262  Unity.Mathematics.int2x3 int2x3(Unity.Mathematics.bool2x3 v)
  RVA=0x09C3C934  token=0x6000263  Unity.Mathematics.int2x3 int2x3(System.UInt32 v)
  RVA=0x09C3C8FC  token=0x6000264  Unity.Mathematics.int2x3 int2x3(Unity.Mathematics.uint2x3 v)
  RVA=0x09C3C8DC  token=0x6000265  Unity.Mathematics.int2x3 int2x3(System.Single v)
  RVA=0x09C3CA08  token=0x6000266  Unity.Mathematics.int2x3 int2x3(Unity.Mathematics.float2x3 v)
  RVA=0x09C3C954  token=0x6000267  Unity.Mathematics.int2x3 int2x3(System.Double v)
  RVA=0x09C3C9AC  token=0x6000268  Unity.Mathematics.int2x3 int2x3(Unity.Mathematics.double2x3 v)
  RVA=0x09C574EC  token=0x6000269  Unity.Mathematics.int3x2 transpose(Unity.Mathematics.int2x3 v)
  RVA=0x09C3737C  token=0x600026A  System.UInt32 hash(Unity.Mathematics.int2x3 v)
  RVA=0x09C3B5CC  token=0x600026B  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.int2x3 v)
  RVA=0x03D7B550  token=0x600026C  Unity.Mathematics.int2x4 int2x4(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1, Unity.Mathematics.int2 c2, Unity.Mathematics.int2 c3)
  RVA=0x04D3AEB4  token=0x600026D  Unity.Mathematics.int2x4 int2x4(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13)
  RVA=0x09C3CA64  token=0x600026E  Unity.Mathematics.int2x4 int2x4(System.Int32 v)
  RVA=0x09C3CAB4  token=0x600026F  Unity.Mathematics.int2x4 int2x4(System.Boolean v)
  RVA=0x09C3CA40  token=0x6000270  Unity.Mathematics.int2x4 int2x4(Unity.Mathematics.bool2x4 v)
  RVA=0x09C3CA64  token=0x6000271  Unity.Mathematics.int2x4 int2x4(System.UInt32 v)
  RVA=0x09C3CA80  token=0x6000272  Unity.Mathematics.int2x4 int2x4(Unity.Mathematics.uint2x4 v)
  RVA=0x09C3CB20  token=0x6000273  Unity.Mathematics.int2x4 int2x4(System.Single v)
  RVA=0x09C3CAEC  token=0x6000274  Unity.Mathematics.int2x4 int2x4(Unity.Mathematics.float2x4 v)
  RVA=0x09C3CAD0  token=0x6000275  Unity.Mathematics.int2x4 int2x4(System.Double v)
  RVA=0x09C3CB3C  token=0x6000276  Unity.Mathematics.int2x4 int2x4(Unity.Mathematics.double2x4 v)
  RVA=0x09C56AA0  token=0x6000277  Unity.Mathematics.int4x2 transpose(Unity.Mathematics.int2x4 v)
  RVA=0x09C36B34  token=0x6000278  System.UInt32 hash(Unity.Mathematics.int2x4 v)
  RVA=0x09C39EF8  token=0x6000279  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.int2x4 v)
  RVA=0x03D78B00  token=0x600027A  Unity.Mathematics.int3 int3(System.Int32 x, System.Int32 y, System.Int32 z)
  RVA=0x03D7B5B0  token=0x600027B  Unity.Mathematics.int3 int3(System.Int32 x, Unity.Mathematics.int2 yz)
  RVA=0x03D7B5D0  token=0x600027C  Unity.Mathematics.int3 int3(Unity.Mathematics.int2 xy, System.Int32 z)
  RVA=0x03D7B5F0  token=0x600027D  Unity.Mathematics.int3 int3(Unity.Mathematics.int3 xyz)
  RVA=0x03D7B570  token=0x600027E  Unity.Mathematics.int3 int3(System.Int32 v)
  RVA=0x09C3CB80  token=0x600027F  Unity.Mathematics.int3 int3(System.Boolean v)
  RVA=0x09C3CB98  token=0x6000280  Unity.Mathematics.int3 int3(Unity.Mathematics.bool3 v)
  RVA=0x03D7B570  token=0x6000281  Unity.Mathematics.int3 int3(System.UInt32 v)
  RVA=0x03D7B5F0  token=0x6000282  Unity.Mathematics.int3 int3(Unity.Mathematics.uint3 v)
  RVA=0x03D7B640  token=0x6000283  Unity.Mathematics.int3 int3(System.Single v)
  RVA=0x03D7B580  token=0x6000284  Unity.Mathematics.int3 int3(Unity.Mathematics.float3 v)
  RVA=0x03D7B620  token=0x6000285  Unity.Mathematics.int3 int3(System.Double v)
  RVA=0x03D7B660  token=0x6000286  Unity.Mathematics.int3 int3(Unity.Mathematics.double3 v)
  RVA=0x09C38520  token=0x6000287  System.UInt32 hash(Unity.Mathematics.int3 v)
  RVA=0x04D3A4C4  token=0x6000288  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.int3 v)
  RVA=0x04D587A0  token=0x6000289  System.Int32 shuffle(Unity.Mathematics.int3 left, Unity.Mathematics.int3 right, Unity.Mathematics.math.ShuffleComponent x)
  RVA=0x04D58C54  token=0x600028A  Unity.Mathematics.int2 shuffle(Unity.Mathematics.int3 left, Unity.Mathematics.int3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  RVA=0x04D59638  token=0x600028B  Unity.Mathematics.int3 shuffle(Unity.Mathematics.int3 left, Unity.Mathematics.int3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  RVA=0x04D58D90  token=0x600028C  Unity.Mathematics.int4 shuffle(Unity.Mathematics.int3 left, Unity.Mathematics.int3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  RVA=0x04D57170  token=0x600028D  System.Int32 select_shuffle_component(Unity.Mathematics.int3 a, Unity.Mathematics.int3 b, Unity.Mathematics.math.ShuffleComponent component)
  RVA=0x03D7AA40  token=0x600028E  Unity.Mathematics.int3x2 int3x2(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1)
  RVA=0x04D3AF08  token=0x600028F  Unity.Mathematics.int3x2 int3x2(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11, System.Int32 m20, System.Int32 m21)
  RVA=0x09C3CC7C  token=0x6000290  Unity.Mathematics.int3x2 int3x2(System.Int32 v)
  RVA=0x09C3CC9C  token=0x6000291  Unity.Mathematics.int3x2 int3x2(System.Boolean v)
  RVA=0x09C3CCBC  token=0x6000292  Unity.Mathematics.int3x2 int3x2(Unity.Mathematics.bool3x2 v)
  RVA=0x09C3CC7C  token=0x6000293  Unity.Mathematics.int3x2 int3x2(System.UInt32 v)
  RVA=0x09C3CC0C  token=0x6000294  Unity.Mathematics.int3x2 int3x2(Unity.Mathematics.uint3x2 v)
  RVA=0x09C3CCF4  token=0x6000295  Unity.Mathematics.int3x2 int3x2(System.Single v)
  RVA=0x09C3CC44  token=0x6000296  Unity.Mathematics.int3x2 int3x2(Unity.Mathematics.float3x2 v)
  RVA=0x09C3CD14  token=0x6000297  Unity.Mathematics.int3x2 int3x2(System.Double v)
  RVA=0x09C3CBCC  token=0x6000298  Unity.Mathematics.int3x2 int3x2(Unity.Mathematics.double3x2 v)
  RVA=0x09C568C4  token=0x6000299  Unity.Mathematics.int2x3 transpose(Unity.Mathematics.int3x2 v)
  RVA=0x09C3872C  token=0x600029A  System.UInt32 hash(Unity.Mathematics.int3x2 v)
  RVA=0x09C3A5B8  token=0x600029B  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.int3x2 v)
  RVA=0x02E246E0  token=0x600029C  Unity.Mathematics.int3x3 int3x3(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1, Unity.Mathematics.int3 c2)
  RVA=0x04D3AF98  token=0x600029D  Unity.Mathematics.int3x3 int3x3(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m20, System.Int32 m21, System.Int32 m22)
  RVA=0x09C3CD34  token=0x600029E  Unity.Mathematics.int3x3 int3x3(System.Int32 v)
  RVA=0x09C3CEAC  token=0x600029F  Unity.Mathematics.int3x3 int3x3(System.Boolean v)
  RVA=0x09C3CE6C  token=0x60002A0  Unity.Mathematics.int3x3 int3x3(Unity.Mathematics.bool3x3 v)
  RVA=0x09C3CD34  token=0x60002A1  Unity.Mathematics.int3x3 int3x3(System.UInt32 v)
  RVA=0x09C3CD74  token=0x60002A2  Unity.Mathematics.int3x3 int3x3(Unity.Mathematics.uint3x3 v)
  RVA=0x09C3CD54  token=0x60002A3  Unity.Mathematics.int3x3 int3x3(System.Single v)
  RVA=0x09C3CE0C  token=0x60002A4  Unity.Mathematics.int3x3 int3x3(Unity.Mathematics.float3x3 v)
  RVA=0x09C3CE4C  token=0x60002A5  Unity.Mathematics.int3x3 int3x3(System.Double v)
  RVA=0x09C3CDB4  token=0x60002A6  Unity.Mathematics.int3x3 int3x3(Unity.Mathematics.double3x3 v)
  RVA=0x09C56E28  token=0x60002A7  Unity.Mathematics.int3x3 transpose(Unity.Mathematics.int3x3 v)
  RVA=0x03D79B70  token=0x60002A8  System.Int32 determinant(Unity.Mathematics.int3x3 m)
  RVA=0x09C36894  token=0x60002A9  System.UInt32 hash(Unity.Mathematics.int3x3 v)
  RVA=0x09C39D8C  token=0x60002AA  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.int3x3 v)
  RVA=0x03D7AA70  token=0x60002AB  Unity.Mathematics.int3x4 int3x4(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1, Unity.Mathematics.int3 c2, Unity.Mathematics.int3 c3)
  RVA=0x04D3B05C  token=0x60002AC  Unity.Mathematics.int3x4 int3x4(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m23)
  RVA=0x09C3CF88  token=0x60002AD  Unity.Mathematics.int3x4 int3x4(System.Int32 v)
  RVA=0x09C3CECC  token=0x60002AE  Unity.Mathematics.int3x4 int3x4(System.Boolean v)
  RVA=0x09C3CF4C  token=0x60002AF  Unity.Mathematics.int3x4 int3x4(Unity.Mathematics.bool3x4 v)
  RVA=0x09C3CF88  token=0x60002B0  Unity.Mathematics.int3x4 int3x4(System.UInt32 v)
  RVA=0x09C3D02C  token=0x60002B1  Unity.Mathematics.int3x4 int3x4(Unity.Mathematics.uint3x4 v)
  RVA=0x09C3D00C  token=0x60002B2  Unity.Mathematics.int3x4 int3x4(System.Single v)
  RVA=0x09C3CFA8  token=0x60002B3  Unity.Mathematics.int3x4 int3x4(Unity.Mathematics.float3x4 v)
  RVA=0x09C3CFEC  token=0x60002B4  Unity.Mathematics.int3x4 int3x4(System.Double v)
  RVA=0x09C3CEEC  token=0x60002B5  Unity.Mathematics.int3x4 int3x4(Unity.Mathematics.double3x4 v)
  RVA=0x09C569B0  token=0x60002B6  Unity.Mathematics.int4x3 transpose(Unity.Mathematics.int3x4 v)
  RVA=0x09C36638  token=0x60002B7  System.UInt32 hash(Unity.Mathematics.int3x4 v)
  RVA=0x09C3AD7C  token=0x60002B8  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.int3x4 v)
  RVA=0x03D78B10  token=0x60002B9  Unity.Mathematics.int4 int4(System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w)
  RVA=0x03D7B730  token=0x60002BA  Unity.Mathematics.int4 int4(System.Int32 x, System.Int32 y, Unity.Mathematics.int2 zw)
  RVA=0x03D7B7B0  token=0x60002BB  Unity.Mathematics.int4 int4(System.Int32 x, Unity.Mathematics.int2 yz, System.Int32 w)
  RVA=0x03D7B6B0  token=0x60002BC  Unity.Mathematics.int4 int4(System.Int32 x, Unity.Mathematics.int3 yzw)
  RVA=0x03D7B750  token=0x60002BD  Unity.Mathematics.int4 int4(Unity.Mathematics.int2 xy, System.Int32 z, System.Int32 w)
  RVA=0x03D76960  token=0x60002BE  Unity.Mathematics.int4 int4(Unity.Mathematics.int2 xy, Unity.Mathematics.int2 zw)
  RVA=0x03D7B770  token=0x60002BF  Unity.Mathematics.int4 int4(Unity.Mathematics.int3 xyz, System.Int32 w)
  RVA=0x09C3D070  token=0x60002C0  Unity.Mathematics.int4 int4(Unity.Mathematics.int4 xyzw)
  RVA=0x03D7B6A0  token=0x60002C1  Unity.Mathematics.int4 int4(System.Int32 v)
  RVA=0x09C3D09C  token=0x60002C2  Unity.Mathematics.int4 int4(System.Boolean v)
  RVA=0x09C3D0BC  token=0x60002C3  Unity.Mathematics.int4 int4(Unity.Mathematics.bool4 v)
  RVA=0x03D7B6A0  token=0x60002C4  Unity.Mathematics.int4 int4(System.UInt32 v)
  RVA=0x09C3D070  token=0x60002C5  Unity.Mathematics.int4 int4(Unity.Mathematics.uint4 v)
  RVA=0x03D7B710  token=0x60002C6  Unity.Mathematics.int4 int4(System.Single v)
  RVA=0x09C3D130  token=0x60002C7  Unity.Mathematics.int4 int4(Unity.Mathematics.float4 v)
  RVA=0x03D7B6F0  token=0x60002C8  Unity.Mathematics.int4 int4(System.Double v)
  RVA=0x09C3D100  token=0x60002C9  Unity.Mathematics.int4 int4(Unity.Mathematics.double4 v)
  RVA=0x09C3880C  token=0x60002CA  System.UInt32 hash(Unity.Mathematics.int4 v)
  RVA=0x09C3C3D8  token=0x60002CB  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.int4 v)
  RVA=0x09C543F4  token=0x60002CC  System.Int32 shuffle(Unity.Mathematics.int4 left, Unity.Mathematics.int4 right, Unity.Mathematics.math.ShuffleComponent x)
  RVA=0x09C53AD8  token=0x60002CD  Unity.Mathematics.int2 shuffle(Unity.Mathematics.int4 left, Unity.Mathematics.int4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  RVA=0x09C54AB8  token=0x60002CE  Unity.Mathematics.int3 shuffle(Unity.Mathematics.int4 left, Unity.Mathematics.int4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  RVA=0x09C53CBC  token=0x60002CF  Unity.Mathematics.int4 shuffle(Unity.Mathematics.int4 left, Unity.Mathematics.int4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  RVA=0x04D57784  token=0x60002D0  System.Int32 select_shuffle_component(Unity.Mathematics.int4 a, Unity.Mathematics.int4 b, Unity.Mathematics.math.ShuffleComponent component)
  RVA=0x03D7AC80  token=0x60002D1  Unity.Mathematics.int4x2 int4x2(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1)
  RVA=0x04D3B124  token=0x60002D2  Unity.Mathematics.int4x2 int4x2(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11, System.Int32 m20, System.Int32 m21, System.Int32 m30, System.Int32 m31)
  RVA=0x09C3D1C4  token=0x60002D3  Unity.Mathematics.int4x2 int4x2(System.Int32 v)
  RVA=0x09C3D230  token=0x60002D4  Unity.Mathematics.int4x2 int4x2(System.Boolean v)
  RVA=0x09C3D280  token=0x60002D5  Unity.Mathematics.int4x2 int4x2(Unity.Mathematics.bool4x2 v)
  RVA=0x09C3D1C4  token=0x60002D6  Unity.Mathematics.int4x2 int4x2(System.UInt32 v)
  RVA=0x09C3D1E0  token=0x60002D7  Unity.Mathematics.int4x2 int4x2(Unity.Mathematics.uint4x2 v)
  RVA=0x09C3D214  token=0x60002D8  Unity.Mathematics.int4x2 int4x2(System.Single v)
  RVA=0x09C3D24C  token=0x60002D9  Unity.Mathematics.int4x2 int4x2(Unity.Mathematics.float4x2 v)
  RVA=0x09C3D164  token=0x60002DA  Unity.Mathematics.int4x2 int4x2(System.Double v)
  RVA=0x09C3D180  token=0x60002DB  Unity.Mathematics.int4x2 int4x2(Unity.Mathematics.double4x2 v)
  RVA=0x09C56910  token=0x60002DC  Unity.Mathematics.int2x4 transpose(Unity.Mathematics.int4x2 v)
  RVA=0x09C37C74  token=0x60002DD  System.UInt32 hash(Unity.Mathematics.int4x2 v)
  RVA=0x09C3A224  token=0x60002DE  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.int4x2 v)
  RVA=0x03D7ACA0  token=0x60002DF  Unity.Mathematics.int4x3 int4x3(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1, Unity.Mathematics.int4 c2)
  RVA=0x04D3B1D8  token=0x60002E0  Unity.Mathematics.int4x3 int4x3(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m30, System.Int32 m31, System.Int32 m32)
  RVA=0x09C3D2C4  token=0x60002E1  Unity.Mathematics.int4x3 int4x3(System.Int32 v)
  RVA=0x09C3D3E4  token=0x60002E2  Unity.Mathematics.int4x3 int4x3(System.Boolean v)
  RVA=0x09C3D364  token=0x60002E3  Unity.Mathematics.int4x3 int4x3(Unity.Mathematics.bool4x3 v)
  RVA=0x09C3D2C4  token=0x60002E4  Unity.Mathematics.int4x3 int4x3(System.UInt32 v)
  RVA=0x09C3D3A0  token=0x60002E5  Unity.Mathematics.int4x3 int4x3(Unity.Mathematics.uint4x3 v)
  RVA=0x09C3D344  token=0x60002E6  Unity.Mathematics.int4x3 int4x3(System.Single v)
  RVA=0x09C3D404  token=0x60002E7  Unity.Mathematics.int4x3 int4x3(Unity.Mathematics.float4x3 v)
  RVA=0x09C3D2A4  token=0x60002E8  Unity.Mathematics.int4x3 int4x3(System.Double v)
  RVA=0x09C3D2E4  token=0x60002E9  Unity.Mathematics.int4x3 int4x3(Unity.Mathematics.double4x3 v)
  RVA=0x09C56CC4  token=0x60002EA  Unity.Mathematics.int3x4 transpose(Unity.Mathematics.int4x3 v)
  RVA=0x09C37D40  token=0x60002EB  System.UInt32 hash(Unity.Mathematics.int4x3 v)
  RVA=0x09C3B86C  token=0x60002EC  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.int4x3 v)
  RVA=0x03D7ACC0  token=0x60002ED  Unity.Mathematics.int4x4 int4x4(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1, Unity.Mathematics.int4 c2, Unity.Mathematics.int4 c3)
  RVA=0x04D3B3A0  token=0x60002EE  Unity.Mathematics.int4x4 int4x4(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m23, System.Int32 m30, System.Int32 m31, System.Int32 m32, System.Int32 m33)
  RVA=0x09C3D4C4  token=0x60002EF  Unity.Mathematics.int4x4 int4x4(System.Int32 v)
  RVA=0x09C3D444  token=0x60002F0  Unity.Mathematics.int4x4 int4x4(System.Boolean v)
  RVA=0x09C3D50C  token=0x60002F1  Unity.Mathematics.int4x4 int4x4(Unity.Mathematics.bool4x4 v)
  RVA=0x09C3D4C4  token=0x60002F2  Unity.Mathematics.int4x4 int4x4(System.UInt32 v)
  RVA=0x09C3D544  token=0x60002F3  Unity.Mathematics.int4x4 int4x4(Unity.Mathematics.uint4x4 v)
  RVA=0x09C3D4E8  token=0x60002F4  Unity.Mathematics.int4x4 int4x4(System.Single v)
  RVA=0x09C3D468  token=0x60002F5  Unity.Mathematics.int4x4 int4x4(Unity.Mathematics.float4x4 v)
  RVA=0x09C3D62C  token=0x60002F6  Unity.Mathematics.int4x4 int4x4(System.Double v)
  RVA=0x09C3D5A0  token=0x60002F7  Unity.Mathematics.int4x4 int4x4(Unity.Mathematics.double4x4 v)
  RVA=0x09C57048  token=0x60002F8  Unity.Mathematics.int4x4 transpose(Unity.Mathematics.int4x4 v)
  RVA=0x03D798A0  token=0x60002F9  System.Int32 determinant(Unity.Mathematics.int4x4 m)
  RVA=0x09C376C0  token=0x60002FA  System.UInt32 hash(Unity.Mathematics.int4x4 v)
  RVA=0x09C3A724  token=0x60002FB  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.int4x4 v)
  RVA=0x03D517B0  token=0x60002FC  System.Int32 asint(System.UInt32 x)
  RVA=0x0339AE90  token=0x60002FD  Unity.Mathematics.int2 asint(Unity.Mathematics.uint2 x)
  RVA=0x03D56520  token=0x60002FE  Unity.Mathematics.int3 asint(Unity.Mathematics.uint3 x)
  RVA=0x03D5B250  token=0x60002FF  Unity.Mathematics.int4 asint(Unity.Mathematics.uint4 x)
  RVA=0x03D70290  token=0x6000300  System.Int32 asint(System.Single x)
  RVA=0x03D787A0  token=0x6000301  Unity.Mathematics.int2 asint(Unity.Mathematics.float2 x)
  RVA=0x03D56520  token=0x6000302  Unity.Mathematics.int3 asint(Unity.Mathematics.float3 x)
  RVA=0x03D5B250  token=0x6000303  Unity.Mathematics.int4 asint(Unity.Mathematics.float4 x)
  RVA=0x03D517B0  token=0x6000304  System.UInt32 asuint(System.Int32 x)
  RVA=0x0339AE90  token=0x6000305  Unity.Mathematics.uint2 asuint(Unity.Mathematics.int2 x)
  RVA=0x03D56520  token=0x6000306  Unity.Mathematics.uint3 asuint(Unity.Mathematics.int3 x)
  RVA=0x03D5B250  token=0x6000307  Unity.Mathematics.uint4 asuint(Unity.Mathematics.int4 x)
  RVA=0x03D70290  token=0x6000308  System.UInt32 asuint(System.Single x)
  RVA=0x03D787A0  token=0x6000309  Unity.Mathematics.uint2 asuint(Unity.Mathematics.float2 x)
  RVA=0x03D56520  token=0x600030A  Unity.Mathematics.uint3 asuint(Unity.Mathematics.float3 x)
  RVA=0x03D5B250  token=0x600030B  Unity.Mathematics.uint4 asuint(Unity.Mathematics.float4 x)
  RVA=0x0339AE90  token=0x600030C  System.Int64 aslong(System.UInt64 x)
  RVA=0x03D70270  token=0x600030D  System.Int64 aslong(System.Double x)
  RVA=0x0339AE90  token=0x600030E  System.UInt64 asulong(System.Int64 x)
  RVA=0x03D70270  token=0x600030F  System.UInt64 asulong(System.Double x)
  RVA=0x03D6BFD0  token=0x6000310  System.Single asfloat(System.Int32 x)
  RVA=0x03D785A0  token=0x6000311  Unity.Mathematics.float2 asfloat(Unity.Mathematics.int2 x)
  RVA=0x03D56520  token=0x6000312  Unity.Mathematics.float3 asfloat(Unity.Mathematics.int3 x)
  RVA=0x03D5B250  token=0x6000313  Unity.Mathematics.float4 asfloat(Unity.Mathematics.int4 x)
  RVA=0x03D6BFD0  token=0x6000314  System.Single asfloat(System.UInt32 x)
  RVA=0x03D785A0  token=0x6000315  Unity.Mathematics.float2 asfloat(Unity.Mathematics.uint2 x)
  RVA=0x03D56520  token=0x6000316  Unity.Mathematics.float3 asfloat(Unity.Mathematics.uint3 x)
  RVA=0x03D5B250  token=0x6000317  Unity.Mathematics.float4 asfloat(Unity.Mathematics.uint4 x)
  RVA=0x09C2EC1C  token=0x6000318  System.Int32 bitmask(Unity.Mathematics.bool4 value)
  RVA=0x03D70280  token=0x6000319  System.Double asdouble(System.Int64 x)
  RVA=0x03D70280  token=0x600031A  System.Double asdouble(System.UInt64 x)
  RVA=0x09C3F2B8  token=0x600031B  System.Boolean isfinite(System.Single x)
  RVA=0x09C3F240  token=0x600031C  Unity.Mathematics.bool2 isfinite(Unity.Mathematics.float2 x)
  RVA=0x09C3F100  token=0x600031D  Unity.Mathematics.bool3 isfinite(Unity.Mathematics.float3 x)
  RVA=0x09C3F16C  token=0x600031E  Unity.Mathematics.bool4 isfinite(Unity.Mathematics.float4 x)
  RVA=0x09C3F0D8  token=0x600031F  System.Boolean isfinite(System.Double x)
  RVA=0x09C3F274  token=0x6000320  Unity.Mathematics.bool2 isfinite(Unity.Mathematics.double2 x)
  RVA=0x09C3F2D4  token=0x6000321  Unity.Mathematics.bool3 isfinite(Unity.Mathematics.double3 x)
  RVA=0x09C3F1D0  token=0x6000322  Unity.Mathematics.bool4 isfinite(Unity.Mathematics.double4 x)
  RVA=0x09C3F348  token=0x6000323  System.Boolean isinf(System.Single x)
  RVA=0x09C3F448  token=0x6000324  Unity.Mathematics.bool2 isinf(Unity.Mathematics.float2 x)
  RVA=0x09C3F4E0  token=0x6000325  Unity.Mathematics.bool3 isinf(Unity.Mathematics.float3 x)
  RVA=0x09C3F4A4  token=0x6000326  Unity.Mathematics.bool4 isinf(Unity.Mathematics.float4 x)
  RVA=0x09C3F3D0  token=0x6000327  System.Boolean isinf(System.Double x)
  RVA=0x09C3F468  token=0x6000328  Unity.Mathematics.bool2 isinf(Unity.Mathematics.double2 x)
  RVA=0x09C3F368  token=0x6000329  Unity.Mathematics.bool3 isinf(Unity.Mathematics.double3 x)
  RVA=0x09C3F3FC  token=0x600032A  Unity.Mathematics.bool4 isinf(Unity.Mathematics.double4 x)
  RVA=0x09C3F5F4  token=0x600032B  System.Boolean isnan(System.Single x)
  RVA=0x09C3F5A8  token=0x600032C  Unity.Mathematics.bool2 isnan(Unity.Mathematics.float2 x)
  RVA=0x09C3F750  token=0x600032D  Unity.Mathematics.bool3 isnan(Unity.Mathematics.float3 x)
  RVA=0x09C3F6D4  token=0x600032E  Unity.Mathematics.bool4 isnan(Unity.Mathematics.float4 x)
  RVA=0x09C3F670  token=0x600032F  System.Boolean isnan(System.Double x)
  RVA=0x09C3F694  token=0x6000330  Unity.Mathematics.bool2 isnan(Unity.Mathematics.double2 x)
  RVA=0x09C3F548  token=0x6000331  Unity.Mathematics.bool3 isnan(Unity.Mathematics.double3 x)
  RVA=0x09C3F608  token=0x6000332  Unity.Mathematics.bool4 isnan(Unity.Mathematics.double4 x)
  RVA=0x09C3F81C  token=0x6000333  System.Boolean ispow2(System.Int32 x)
  RVA=0x09C3F82C  token=0x6000334  Unity.Mathematics.bool2 ispow2(Unity.Mathematics.int2 x)
  RVA=0x09C3F7C8  token=0x6000335  Unity.Mathematics.bool3 ispow2(Unity.Mathematics.int3 x)
  RVA=0x09C3F96C  token=0x6000336  Unity.Mathematics.bool4 ispow2(Unity.Mathematics.int4 x)
  RVA=0x09C3F8D8  token=0x6000337  System.Boolean ispow2(System.UInt32 x)
  RVA=0x09C3F8E8  token=0x6000338  Unity.Mathematics.bool2 ispow2(Unity.Mathematics.uint2 x)
  RVA=0x09C3F91C  token=0x6000339  Unity.Mathematics.bool3 ispow2(Unity.Mathematics.uint3 x)
  RVA=0x09C3F860  token=0x600033A  Unity.Mathematics.bool4 ispow2(Unity.Mathematics.uint4 x)
  RVA=0x09C40B98  token=0x600033B  System.Int32 min(System.Int32 x, System.Int32 y)
  RVA=0x09C40E7C  token=0x600033C  Unity.Mathematics.int2 min(Unity.Mathematics.int2 x, Unity.Mathematics.int2 y)
  RVA=0x09C40EBC  token=0x600033D  Unity.Mathematics.int3 min(Unity.Mathematics.int3 x, Unity.Mathematics.int3 y)
  RVA=0x09C40C74  token=0x600033E  Unity.Mathematics.int4 min(Unity.Mathematics.int4 x, Unity.Mathematics.int4 y)
  RVA=0x09C40EB4  token=0x600033F  System.UInt32 min(System.UInt32 x, System.UInt32 y)
  RVA=0x09C40D60  token=0x6000340  Unity.Mathematics.uint2 min(Unity.Mathematics.uint2 x, Unity.Mathematics.uint2 y)
  RVA=0x09C40DF8  token=0x6000341  Unity.Mathematics.uint3 min(Unity.Mathematics.uint3 x, Unity.Mathematics.uint3 y)
  RVA=0x09C40E2C  token=0x6000342  Unity.Mathematics.uint4 min(Unity.Mathematics.uint4 x, Unity.Mathematics.uint4 y)
  RVA=0x09C40E70  token=0x6000343  System.Int64 min(System.Int64 x, System.Int64 y)
  RVA=0x09C40EA8  token=0x6000344  System.UInt64 min(System.UInt64 x, System.UInt64 y)
  RVA=0x09C40D8C  token=0x6000345  System.Single min(System.Single x, System.Single y)
  RVA=0x09C40DA0  token=0x6000346  Unity.Mathematics.float2 min(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y)
  RVA=0x09C40C0C  token=0x6000347  Unity.Mathematics.float3 min(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  RVA=0x04D3D1F0  token=0x6000348  Unity.Mathematics.float4 min(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y)
  RVA=0x09C40CB8  token=0x6000349  System.Double min(System.Double x, System.Double y)
  RVA=0x04D3D0B0  token=0x600034A  Unity.Mathematics.double2 min(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y)
  RVA=0x09C40BA0  token=0x600034B  Unity.Mathematics.double3 min(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y)
  RVA=0x09C40CD0  token=0x600034C  Unity.Mathematics.double4 min(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y)
  RVA=0x09C40930  token=0x600034D  System.Int32 max(System.Int32 x, System.Int32 y)
  RVA=0x09C4085C  token=0x600034E  Unity.Mathematics.int2 max(Unity.Mathematics.int2 x, Unity.Mathematics.int2 y)
  RVA=0x09C40828  token=0x600034F  Unity.Mathematics.int3 max(Unity.Mathematics.int3 x, Unity.Mathematics.int3 y)
  RVA=0x09C409F0  token=0x6000350  Unity.Mathematics.int4 max(Unity.Mathematics.int4 x, Unity.Mathematics.int4 y)
  RVA=0x09C40ACC  token=0x6000351  System.UInt32 max(System.UInt32 x, System.UInt32 y)
  RVA=0x09C40AD4  token=0x6000352  Unity.Mathematics.uint2 max(Unity.Mathematics.uint2 x, Unity.Mathematics.uint2 y)
  RVA=0x09C40B0C  token=0x6000353  Unity.Mathematics.uint3 max(Unity.Mathematics.uint3 x, Unity.Mathematics.uint3 y)
  RVA=0x09C409AC  token=0x6000354  Unity.Mathematics.uint4 max(Unity.Mathematics.uint4 x, Unity.Mathematics.uint4 y)
  RVA=0x09C40B00  token=0x6000355  System.Int64 max(System.Int64 x, System.Int64 y)
  RVA=0x09C4090C  token=0x6000356  System.UInt64 max(System.UInt64 x, System.UInt64 y)
  RVA=0x09C408F8  token=0x6000357  System.Single max(System.Single x, System.Single y)
  RVA=0x09C40B40  token=0x6000358  Unity.Mathematics.float2 max(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y)
  RVA=0x09C40888  token=0x6000359  Unity.Mathematics.float3 max(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  RVA=0x04D3CD68  token=0x600035A  Unity.Mathematics.float4 max(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y)
  RVA=0x09C40918  token=0x600035B  System.Double max(System.Double x, System.Double y)
  RVA=0x04D3CEB4  token=0x600035C  Unity.Mathematics.double2 max(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y)
  RVA=0x09C40938  token=0x600035D  Unity.Mathematics.double3 max(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y)
  RVA=0x09C40A34  token=0x600035E  Unity.Mathematics.double4 max(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y)
  RVA=0x03D52690  token=0x600035F  System.Single lerp(System.Single start, System.Single end, System.Single t)
  RVA=0x09C4005C  token=0x6000360  Unity.Mathematics.float2 lerp(Unity.Mathematics.float2 start, Unity.Mathematics.float2 end, System.Single t)
  RVA=0x04D3C0B0  token=0x6000361  Unity.Mathematics.float3 lerp(Unity.Mathematics.float3 start, Unity.Mathematics.float3 end, System.Single t)
  RVA=0x09C40098  token=0x6000362  Unity.Mathematics.float4 lerp(Unity.Mathematics.float4 start, Unity.Mathematics.float4 end, System.Single t)
  RVA=0x09C3FC90  token=0x6000363  Unity.Mathematics.float2 lerp(Unity.Mathematics.float2 start, Unity.Mathematics.float2 end, Unity.Mathematics.float2 t)
  RVA=0x04D3BCA8  token=0x6000364  Unity.Mathematics.float3 lerp(Unity.Mathematics.float3 start, Unity.Mathematics.float3 end, Unity.Mathematics.float3 t)
  RVA=0x09C3FC08  token=0x6000365  Unity.Mathematics.float4 lerp(Unity.Mathematics.float4 start, Unity.Mathematics.float4 end, Unity.Mathematics.float4 t)
  RVA=0x03D7B850  token=0x6000366  System.Double lerp(System.Double start, System.Double end, System.Double t)
  RVA=0x09C3FB8C  token=0x6000367  Unity.Mathematics.double2 lerp(Unity.Mathematics.double2 start, Unity.Mathematics.double2 end, System.Double t)
  RVA=0x09C3FF9C  token=0x6000368  Unity.Mathematics.double3 lerp(Unity.Mathematics.double3 start, Unity.Mathematics.double3 end, System.Double t)
  RVA=0x09C3FE60  token=0x6000369  Unity.Mathematics.double4 lerp(Unity.Mathematics.double4 start, Unity.Mathematics.double4 end, System.Double t)
  RVA=0x09C3FF14  token=0x600036A  Unity.Mathematics.double2 lerp(Unity.Mathematics.double2 start, Unity.Mathematics.double2 end, Unity.Mathematics.double2 t)
  RVA=0x09C3FD90  token=0x600036B  Unity.Mathematics.double3 lerp(Unity.Mathematics.double3 start, Unity.Mathematics.double3 end, Unity.Mathematics.double3 t)
  RVA=0x09C3FCCC  token=0x600036C  Unity.Mathematics.double4 lerp(Unity.Mathematics.double4 start, Unity.Mathematics.double4 end, Unity.Mathematics.double4 t)
  RVA=0x09C58608  token=0x600036D  System.Single unlerp(System.Single start, System.Single end, System.Single x)
  RVA=0x09C586D0  token=0x600036E  Unity.Mathematics.float2 unlerp(Unity.Mathematics.float2 start, Unity.Mathematics.float2 end, Unity.Mathematics.float2 x)
  RVA=0x04D5E9BC  token=0x600036F  Unity.Mathematics.float3 unlerp(Unity.Mathematics.float3 start, Unity.Mathematics.float3 end, Unity.Mathematics.float3 x)
  RVA=0x09C58618  token=0x6000370  Unity.Mathematics.float4 unlerp(Unity.Mathematics.float4 start, Unity.Mathematics.float4 end, Unity.Mathematics.float4 x)
  RVA=0x09C58808  token=0x6000371  System.Double unlerp(System.Double start, System.Double end, System.Double x)
  RVA=0x09C58590  token=0x6000372  Unity.Mathematics.double2 unlerp(Unity.Mathematics.double2 start, Unity.Mathematics.double2 end, Unity.Mathematics.double2 x)
  RVA=0x09C584A0  token=0x6000373  Unity.Mathematics.double3 unlerp(Unity.Mathematics.double3 start, Unity.Mathematics.double3 end, Unity.Mathematics.double3 x)
  RVA=0x09C5872C  token=0x6000374  Unity.Mathematics.double4 unlerp(Unity.Mathematics.double4 start, Unity.Mathematics.double4 end, Unity.Mathematics.double4 x)
  RVA=0x09C51D50  token=0x6000375  System.Single remap(System.Single srcStart, System.Single srcEnd, System.Single dstStart, System.Single dstEnd, System.Single x)
  RVA=0x09C51CCC  token=0x6000376  Unity.Mathematics.float2 remap(Unity.Mathematics.float2 srcStart, Unity.Mathematics.float2 srcEnd, Unity.Mathematics.float2 dstStart, Unity.Mathematics.float2 dstEnd, Unity.Mathematics.float2 x)
  RVA=0x04D55754  token=0x6000377  Unity.Mathematics.float3 remap(Unity.Mathematics.float3 srcStart, Unity.Mathematics.float3 srcEnd, Unity.Mathematics.float3 dstStart, Unity.Mathematics.float3 dstEnd, Unity.Mathematics.float3 x)
  RVA=0x09C51C18  token=0x6000378  Unity.Mathematics.float4 remap(Unity.Mathematics.float4 srcStart, Unity.Mathematics.float4 srcEnd, Unity.Mathematics.float4 dstStart, Unity.Mathematics.float4 dstEnd, Unity.Mathematics.float4 x)
  RVA=0x09C51CA8  token=0x6000379  System.Double remap(System.Double srcStart, System.Double srcEnd, System.Double dstStart, System.Double dstEnd, System.Double x)
  RVA=0x09C51E54  token=0x600037A  Unity.Mathematics.double2 remap(Unity.Mathematics.double2 srcStart, Unity.Mathematics.double2 srcEnd, Unity.Mathematics.double2 dstStart, Unity.Mathematics.double2 dstEnd, Unity.Mathematics.double2 x)
  RVA=0x09C51D74  token=0x600037B  Unity.Mathematics.double3 remap(Unity.Mathematics.double3 srcStart, Unity.Mathematics.double3 srcEnd, Unity.Mathematics.double3 dstStart, Unity.Mathematics.double3 dstEnd, Unity.Mathematics.double3 x)
  RVA=0x09C51EE4  token=0x600037C  Unity.Mathematics.double4 remap(Unity.Mathematics.double4 srcStart, Unity.Mathematics.double4 srcEnd, Unity.Mathematics.double4 dstStart, Unity.Mathematics.double4 dstEnd, Unity.Mathematics.double4 x)
  RVA=0x03D7BC50  token=0x600037D  System.Int32 mad(System.Int32 mulA, System.Int32 mulB, System.Int32 addC)
  RVA=0x09C40608  token=0x600037E  Unity.Mathematics.int2 mad(Unity.Mathematics.int2 mulA, Unity.Mathematics.int2 mulB, Unity.Mathematics.int2 addC)
  RVA=0x04D3CA68  token=0x600037F  Unity.Mathematics.int3 mad(Unity.Mathematics.int3 mulA, Unity.Mathematics.int3 mulB, Unity.Mathematics.int3 addC)
  RVA=0x09C405A4  token=0x6000380  Unity.Mathematics.int4 mad(Unity.Mathematics.int4 mulA, Unity.Mathematics.int4 mulB, Unity.Mathematics.int4 addC)
  RVA=0x03D7BC50  token=0x6000381  System.UInt32 mad(System.UInt32 mulA, System.UInt32 mulB, System.UInt32 addC)
  RVA=0x09C40608  token=0x6000382  Unity.Mathematics.uint2 mad(Unity.Mathematics.uint2 mulA, Unity.Mathematics.uint2 mulB, Unity.Mathematics.uint2 addC)
  RVA=0x04D3CA68  token=0x6000383  Unity.Mathematics.uint3 mad(Unity.Mathematics.uint3 mulA, Unity.Mathematics.uint3 mulB, Unity.Mathematics.uint3 addC)
  RVA=0x09C405A4  token=0x6000384  Unity.Mathematics.uint4 mad(Unity.Mathematics.uint4 mulA, Unity.Mathematics.uint4 mulB, Unity.Mathematics.uint4 addC)
  RVA=0x03D7BC20  token=0x6000385  System.Int64 mad(System.Int64 mulA, System.Int64 mulB, System.Int64 addC)
  RVA=0x03D7BC20  token=0x6000386  System.UInt64 mad(System.UInt64 mulA, System.UInt64 mulB, System.UInt64 addC)
  RVA=0x03D7BC30  token=0x6000387  System.Single mad(System.Single mulA, System.Single mulB, System.Single addC)
  RVA=0x09C406B8  token=0x6000388  Unity.Mathematics.float2 mad(Unity.Mathematics.float2 mulA, Unity.Mathematics.float2 mulB, Unity.Mathematics.float2 addC)
  RVA=0x04D3CCE0  token=0x6000389  Unity.Mathematics.float3 mad(Unity.Mathematics.float3 mulA, Unity.Mathematics.float3 mulB, Unity.Mathematics.float3 addC)
  RVA=0x09C40734  token=0x600038A  Unity.Mathematics.float4 mad(Unity.Mathematics.float4 mulA, Unity.Mathematics.float4 mulB, Unity.Mathematics.float4 addC)
  RVA=0x03D7BC40  token=0x600038B  System.Double mad(System.Double mulA, System.Double mulB, System.Double addC)
  RVA=0x09C406D0  token=0x600038C  Unity.Mathematics.double2 mad(Unity.Mathematics.double2 mulA, Unity.Mathematics.double2 mulB, Unity.Mathematics.double2 addC)
  RVA=0x09C40620  token=0x600038D  Unity.Mathematics.double3 mad(Unity.Mathematics.double3 mulA, Unity.Mathematics.double3 mulB, Unity.Mathematics.double3 addC)
  RVA=0x09C40798  token=0x600038E  Unity.Mathematics.double4 mad(Unity.Mathematics.double4 mulA, Unity.Mathematics.double4 mulB, Unity.Mathematics.double4 addC)
  RVA=0x09C2F864  token=0x600038F  System.Int32 clamp(System.Int32 valueToClamp, System.Int32 lowerBound, System.Int32 upperBound)
  RVA=0x09C2F8B4  token=0x6000390  Unity.Mathematics.int2 clamp(Unity.Mathematics.int2 valueToClamp, Unity.Mathematics.int2 lowerBound, Unity.Mathematics.int2 upperBound)
  RVA=0x04D2E488  token=0x6000391  Unity.Mathematics.int3 clamp(Unity.Mathematics.int3 valueToClamp, Unity.Mathematics.int3 lowerBound, Unity.Mathematics.int3 upperBound)
  RVA=0x09C2F7A0  token=0x6000392  Unity.Mathematics.int4 clamp(Unity.Mathematics.int4 valueToClamp, Unity.Mathematics.int4 lowerBound, Unity.Mathematics.int4 upperBound)
  RVA=0x09C2F78C  token=0x6000393  System.UInt32 clamp(System.UInt32 valueToClamp, System.UInt32 lowerBound, System.UInt32 upperBound)
  RVA=0x09C2F668  token=0x6000394  Unity.Mathematics.uint2 clamp(Unity.Mathematics.uint2 valueToClamp, Unity.Mathematics.uint2 lowerBound, Unity.Mathematics.uint2 upperBound)
  RVA=0x04D2E630  token=0x6000395  Unity.Mathematics.uint3 clamp(Unity.Mathematics.uint3 valueToClamp, Unity.Mathematics.uint3 lowerBound, Unity.Mathematics.uint3 upperBound)
  RVA=0x09C2F4A0  token=0x6000396  Unity.Mathematics.uint4 clamp(Unity.Mathematics.uint4 valueToClamp, Unity.Mathematics.uint4 lowerBound, Unity.Mathematics.uint4 upperBound)
  RVA=0x09C2F6EC  token=0x6000397  System.Int64 clamp(System.Int64 valueToClamp, System.Int64 lowerBound, System.Int64 upperBound)
  RVA=0x09C2F8A0  token=0x6000398  System.UInt64 clamp(System.UInt64 valueToClamp, System.UInt64 lowerBound, System.UInt64 upperBound)
  RVA=0x09C2F878  token=0x6000399  System.Single clamp(System.Single valueToClamp, System.Single lowerBound, System.Single upperBound)
  RVA=0x09C2F6C4  token=0x600039A  Unity.Mathematics.float2 clamp(Unity.Mathematics.float2 valueToClamp, Unity.Mathematics.float2 lowerBound, Unity.Mathematics.float2 upperBound)
  RVA=0x09C2F700  token=0x600039B  Unity.Mathematics.float3 clamp(Unity.Mathematics.float3 valueToClamp, Unity.Mathematics.float3 lowerBound, Unity.Mathematics.float3 upperBound)
  RVA=0x09C2F564  token=0x600039C  Unity.Mathematics.float4 clamp(Unity.Mathematics.float4 valueToClamp, Unity.Mathematics.float4 lowerBound, Unity.Mathematics.float4 upperBound)
  RVA=0x04D2E358  token=0x600039D  System.Double clamp(System.Double valueToClamp, System.Double lowerBound, System.Double upperBound)
  RVA=0x09C2F910  token=0x600039E  Unity.Mathematics.double2 clamp(Unity.Mathematics.double2 valueToClamp, Unity.Mathematics.double2 lowerBound, Unity.Mathematics.double2 upperBound)
  RVA=0x09C2F5CC  token=0x600039F  Unity.Mathematics.double3 clamp(Unity.Mathematics.double3 valueToClamp, Unity.Mathematics.double3 lowerBound, Unity.Mathematics.double3 upperBound)
  RVA=0x09C2F978  token=0x60003A0  Unity.Mathematics.double4 clamp(Unity.Mathematics.double4 valueToClamp, Unity.Mathematics.double4 lowerBound, Unity.Mathematics.double4 upperBound)
  RVA=0x089C152C  token=0x60003A1  System.Single saturate(System.Single x)
  RVA=0x09C53300  token=0x60003A2  Unity.Mathematics.float2 saturate(Unity.Mathematics.float2 x)
  RVA=0x04D56B10  token=0x60003A3  Unity.Mathematics.float3 saturate(Unity.Mathematics.float3 x)
  RVA=0x09C532B4  token=0x60003A4  Unity.Mathematics.float4 saturate(Unity.Mathematics.float4 x)
  RVA=0x09C532A4  token=0x60003A5  System.Double saturate(System.Double x)
  RVA=0x09C533D8  token=0x60003A6  Unity.Mathematics.double2 saturate(Unity.Mathematics.double2 x)
  RVA=0x09C5333C  token=0x60003A7  Unity.Mathematics.double3 saturate(Unity.Mathematics.double3 x)
  RVA=0x09C53238  token=0x60003A8  Unity.Mathematics.double4 saturate(Unity.Mathematics.double4 x)
  RVA=0x09C2E034  token=0x60003A9  System.Int32 abs(System.Int32 x)
  RVA=0x09C2DF38  token=0x60003AA  Unity.Mathematics.int2 abs(Unity.Mathematics.int2 x)
  RVA=0x04D2C678  token=0x60003AB  Unity.Mathematics.int3 abs(Unity.Mathematics.int3 x)
  RVA=0x09C2DF7C  token=0x60003AC  Unity.Mathematics.int4 abs(Unity.Mathematics.int4 x)
  RVA=0x09C2DF28  token=0x60003AD  System.Int64 abs(System.Int64 x)
  RVA=0x03D782D0  token=0x60003AE  System.Single abs(System.Single x)
  RVA=0x03D78390  token=0x60003AF  Unity.Mathematics.float2 abs(Unity.Mathematics.float2 x)
  RVA=0x02EE6450  token=0x60003B0  Unity.Mathematics.float3 abs(Unity.Mathematics.float3 x)
  RVA=0x09C2DEF4  token=0x60003B1  Unity.Mathematics.float4 abs(Unity.Mathematics.float4 x)
  RVA=0x03D78370  token=0x60003B2  System.Double abs(System.Double x)
  RVA=0x03D78340  token=0x60003B3  Unity.Mathematics.double2 abs(Unity.Mathematics.double2 x)
  RVA=0x03D78290  token=0x60003B4  Unity.Mathematics.double3 abs(Unity.Mathematics.double3 x)
  RVA=0x03D782E0  token=0x60003B5  Unity.Mathematics.double4 abs(Unity.Mathematics.double4 x)
  RVA=0x03D79CC0  token=0x60003B6  System.Int32 dot(System.Int32 x, System.Int32 y)
  RVA=0x03D79D50  token=0x60003B7  System.Int32 dot(Unity.Mathematics.int2 x, Unity.Mathematics.int2 y)
  RVA=0x03D4E570  token=0x60003B8  System.Int32 dot(Unity.Mathematics.int3 x, Unity.Mathematics.int3 y)
  RVA=0x03D79D10  token=0x60003B9  System.Int32 dot(Unity.Mathematics.int4 x, Unity.Mathematics.int4 y)
  RVA=0x03D79CC0  token=0x60003BA  System.UInt32 dot(System.UInt32 x, System.UInt32 y)
  RVA=0x03D79D50  token=0x60003BB  System.UInt32 dot(Unity.Mathematics.uint2 x, Unity.Mathematics.uint2 y)
  RVA=0x03D4E570  token=0x60003BC  System.UInt32 dot(Unity.Mathematics.uint3 x, Unity.Mathematics.uint3 y)
  RVA=0x03D79D10  token=0x60003BD  System.UInt32 dot(Unity.Mathematics.uint4 x, Unity.Mathematics.uint4 y)
  RVA=0x03D79D70  token=0x60003BE  System.Single dot(System.Single x, System.Single y)
  RVA=0x03D542E0  token=0x60003BF  System.Single dot(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y)
  RVA=0x03D54460  token=0x60003C0  System.Single dot(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  RVA=0x028B5400  token=0x60003C1  System.Single dot(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y)
  RVA=0x03D79D40  token=0x60003C2  System.Double dot(System.Double x, System.Double y)
  RVA=0x03D79DB0  token=0x60003C3  System.Double dot(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y)
  RVA=0x03D79D80  token=0x60003C4  System.Double dot(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y)
  RVA=0x03D79CD0  token=0x60003C5  System.Double dot(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y)
  RVA=0x09C56194  token=0x60003C6  System.Single tan(System.Single x)
  RVA=0x09C56020  token=0x60003C7  Unity.Mathematics.float2 tan(Unity.Mathematics.float2 x)
  RVA=0x04D5B65C  token=0x60003C8  Unity.Mathematics.float3 tan(Unity.Mathematics.float3 x)
  RVA=0x04D5B5D8  token=0x60003C9  Unity.Mathematics.float4 tan(Unity.Mathematics.float4 x)
  RVA=0x09C56144  token=0x60003CA  System.Double tan(System.Double x)
  RVA=0x04D5B3F8  token=0x60003CB  Unity.Mathematics.double2 tan(Unity.Mathematics.double2 x)
  RVA=0x09C560E0  token=0x60003CC  Unity.Mathematics.double3 tan(Unity.Mathematics.double3 x)
  RVA=0x09C5605C  token=0x60003CD  Unity.Mathematics.double4 tan(Unity.Mathematics.double4 x)
  RVA=0x09C56360  token=0x60003CE  System.Single tanh(System.Single x)
  RVA=0x09C56324  token=0x60003CF  Unity.Mathematics.float2 tanh(Unity.Mathematics.float2 x)
  RVA=0x04D5B8DC  token=0x60003D0  Unity.Mathematics.float3 tanh(Unity.Mathematics.float3 x)
  RVA=0x04D5B7C8  token=0x60003D1  Unity.Mathematics.float4 tanh(Unity.Mathematics.float4 x)
  RVA=0x09C562D4  token=0x60003D2  System.Double tanh(System.Double x)
  RVA=0x04D5B998  token=0x60003D3  Unity.Mathematics.double2 tanh(Unity.Mathematics.double2 x)
  RVA=0x09C561EC  token=0x60003D4  Unity.Mathematics.double3 tanh(Unity.Mathematics.double3 x)
  RVA=0x09C56250  token=0x60003D5  Unity.Mathematics.double4 tanh(Unity.Mathematics.double4 x)
  RVA=0x09C2EAD4  token=0x60003D6  System.Single atan(System.Single x)
  RVA=0x09C2EBE0  token=0x60003D7  Unity.Mathematics.float2 atan(Unity.Mathematics.float2 x)
  RVA=0x04D2D29C  token=0x60003D8  Unity.Mathematics.float3 atan(Unity.Mathematics.float3 x)
  RVA=0x04D2D218  token=0x60003D9  Unity.Mathematics.float4 atan(Unity.Mathematics.float4 x)
  RVA=0x09C2EB90  token=0x60003DA  System.Double atan(System.Double x)
  RVA=0x04D2D460  token=0x60003DB  Unity.Mathematics.double2 atan(Unity.Mathematics.double2 x)
  RVA=0x09C2EB2C  token=0x60003DC  Unity.Mathematics.double3 atan(Unity.Mathematics.double3 x)
  RVA=0x09C2EA50  token=0x60003DD  Unity.Mathematics.double4 atan(Unity.Mathematics.double4 x)
  RVA=0x09C2E948  token=0x60003DE  System.Single atan2(System.Single y, System.Single x)
  RVA=0x09C2E8FC  token=0x60003DF  Unity.Mathematics.float2 atan2(Unity.Mathematics.float2 y, Unity.Mathematics.float2 x)
  RVA=0x04D2CFA0  token=0x60003E0  Unity.Mathematics.float3 atan2(Unity.Mathematics.float3 y, Unity.Mathematics.float3 x)
  RVA=0x04D2D0D0  token=0x60003E1  Unity.Mathematics.float4 atan2(Unity.Mathematics.float4 y, Unity.Mathematics.float4 x)
  RVA=0x09C2E89C  token=0x60003E2  System.Double atan2(System.Double y, System.Double x)
  RVA=0x04D2D070  token=0x60003E3  Unity.Mathematics.double2 atan2(Unity.Mathematics.double2 y, Unity.Mathematics.double2 x)
  RVA=0x09C2E81C  token=0x60003E4  Unity.Mathematics.double3 atan2(Unity.Mathematics.double3 y, Unity.Mathematics.double3 x)
  RVA=0x09C2E9AC  token=0x60003E5  Unity.Mathematics.double4 atan2(Unity.Mathematics.double4 y, Unity.Mathematics.double4 x)
  RVA=0x09C2FD74  token=0x60003E6  System.Single cos(System.Single x)
  RVA=0x03D78DD0  token=0x60003E7  Unity.Mathematics.float2 cos(Unity.Mathematics.float2 x)
  RVA=0x03D78E60  token=0x60003E8  Unity.Mathematics.float3 cos(Unity.Mathematics.float3 x)
  RVA=0x03D78F50  token=0x60003E9  Unity.Mathematics.float4 cos(Unity.Mathematics.float4 x)
  RVA=0x09C2FDCC  token=0x60003EA  System.Double cos(System.Double x)
  RVA=0x03D78EB0  token=0x60003EB  Unity.Mathematics.double2 cos(Unity.Mathematics.double2 x)
  RVA=0x03D78E10  token=0x60003EC  Unity.Mathematics.double3 cos(Unity.Mathematics.double3 x)
  RVA=0x03D78EF0  token=0x60003ED  Unity.Mathematics.double4 cos(Unity.Mathematics.double4 x)
  RVA=0x09C2FE1C  token=0x60003EE  System.Single cosh(System.Single x)
  RVA=0x03D78FB0  token=0x60003EF  Unity.Mathematics.float2 cosh(Unity.Mathematics.float2 x)
  RVA=0x03D79040  token=0x60003F0  Unity.Mathematics.float3 cosh(Unity.Mathematics.float3 x)
  RVA=0x03D790F0  token=0x60003F1  Unity.Mathematics.float4 cosh(Unity.Mathematics.float4 x)
  RVA=0x09C2FE74  token=0x60003F2  System.Double cosh(System.Double x)
  RVA=0x03D79150  token=0x60003F3  Unity.Mathematics.double2 cosh(Unity.Mathematics.double2 x)
  RVA=0x03D78FF0  token=0x60003F4  Unity.Mathematics.double3 cosh(Unity.Mathematics.double3 x)
  RVA=0x03D79090  token=0x60003F5  Unity.Mathematics.double4 cosh(Unity.Mathematics.double4 x)
  RVA=0x09C2E090  token=0x60003F6  System.Single acos(System.Single x)
  RVA=0x03D783C0  token=0x60003F7  Unity.Mathematics.float2 acos(Unity.Mathematics.float2 x)
  RVA=0x03D78400  token=0x60003F8  Unity.Mathematics.float3 acos(Unity.Mathematics.float3 x)
  RVA=0x03D784B0  token=0x60003F9  Unity.Mathematics.float4 acos(Unity.Mathematics.float4 x)
  RVA=0x09C2E040  token=0x60003FA  System.Double acos(System.Double x)
  RVA=0x03D78510  token=0x60003FB  Unity.Mathematics.double2 acos(Unity.Mathematics.double2 x)
  RVA=0x03D78550  token=0x60003FC  Unity.Mathematics.double3 acos(Unity.Mathematics.double3 x)
  RVA=0x03D78450  token=0x60003FD  Unity.Mathematics.double4 acos(Unity.Mathematics.double4 x)
  RVA=0x09C54DA4  token=0x60003FE  System.Single sin(System.Single x)
  RVA=0x03D7CDA0  token=0x60003FF  Unity.Mathematics.float2 sin(Unity.Mathematics.float2 x)
  RVA=0x03D7CC90  token=0x6000400  Unity.Mathematics.float3 sin(Unity.Mathematics.float3 x)
  RVA=0x03D7CD40  token=0x6000401  Unity.Mathematics.float4 sin(Unity.Mathematics.float4 x)
  RVA=0x09C54DFC  token=0x6000402  System.Double sin(System.Double x)
  RVA=0x03D7CDE0  token=0x6000403  Unity.Mathematics.double2 sin(Unity.Mathematics.double2 x)
  RVA=0x03D7CC40  token=0x6000404  Unity.Mathematics.double3 sin(Unity.Mathematics.double3 x)
  RVA=0x03D7CCE0  token=0x6000405  Unity.Mathematics.double4 sin(Unity.Mathematics.double4 x)
  RVA=0x09C55144  token=0x6000406  System.Single sinh(System.Single x)
  RVA=0x03D7D040  token=0x6000407  Unity.Mathematics.float2 sinh(Unity.Mathematics.float2 x)
  RVA=0x03D7CEE0  token=0x6000408  Unity.Mathematics.float3 sinh(Unity.Mathematics.float3 x)
  RVA=0x03D7CFE0  token=0x6000409  Unity.Mathematics.float4 sinh(Unity.Mathematics.float4 x)
  RVA=0x09C550F4  token=0x600040A  System.Double sinh(System.Double x)
  RVA=0x03D7CEA0  token=0x600040B  Unity.Mathematics.double2 sinh(Unity.Mathematics.double2 x)
  RVA=0x03D7CF90  token=0x600040C  Unity.Mathematics.double3 sinh(Unity.Mathematics.double3 x)
  RVA=0x03D7CF30  token=0x600040D  Unity.Mathematics.double4 sinh(Unity.Mathematics.double4 x)
  RVA=0x09C2E7C4  token=0x600040E  System.Single asin(System.Single x)
  RVA=0x03D785C0  token=0x600040F  Unity.Mathematics.float2 asin(Unity.Mathematics.float2 x)
  RVA=0x03D78660  token=0x6000410  Unity.Mathematics.float3 asin(Unity.Mathematics.float3 x)
  RVA=0x03D78740  token=0x6000411  Unity.Mathematics.float4 asin(Unity.Mathematics.float4 x)
  RVA=0x09C2E774  token=0x6000412  System.Double asin(System.Double x)
  RVA=0x03D78700  token=0x6000413  Unity.Mathematics.double2 asin(Unity.Mathematics.double2 x)
  RVA=0x03D786B0  token=0x6000414  Unity.Mathematics.double3 asin(Unity.Mathematics.double3 x)
  RVA=0x03D78600  token=0x6000415  Unity.Mathematics.double4 asin(Unity.Mathematics.double4 x)
  RVA=0x09C353A0  token=0x6000416  System.Single floor(System.Single x)
  RVA=0x03D7AE40  token=0x6000417  Unity.Mathematics.float2 floor(Unity.Mathematics.float2 x)
  RVA=0x033424B0  token=0x6000418  Unity.Mathematics.float3 floor(Unity.Mathematics.float3 x)
  RVA=0x03D7ACF0  token=0x6000419  Unity.Mathematics.float4 floor(Unity.Mathematics.float4 x)
  RVA=0x09C353F8  token=0x600041A  System.Double floor(System.Double x)
  RVA=0x03D7AE00  token=0x600041B  Unity.Mathematics.double2 floor(Unity.Mathematics.double2 x)
  RVA=0x03D7AD50  token=0x600041C  Unity.Mathematics.double3 floor(Unity.Mathematics.double3 x)
  RVA=0x03D7ADA0  token=0x600041D  Unity.Mathematics.double4 floor(Unity.Mathematics.double4 x)
  RVA=0x09C2EE18  token=0x600041E  System.Single ceil(System.Single x)
  RVA=0x03D78B80  token=0x600041F  Unity.Mathematics.float2 ceil(Unity.Mathematics.float2 x)
  RVA=0x03D78CC0  token=0x6000420  Unity.Mathematics.float3 ceil(Unity.Mathematics.float3 x)
  RVA=0x03D78C00  token=0x6000421  Unity.Mathematics.float4 ceil(Unity.Mathematics.float4 x)
  RVA=0x09C2EE70  token=0x6000422  System.Double ceil(System.Double x)
  RVA=0x03D78BC0  token=0x6000423  Unity.Mathematics.double2 ceil(Unity.Mathematics.double2 x)
  RVA=0x03D78B30  token=0x6000424  Unity.Mathematics.double3 ceil(Unity.Mathematics.double3 x)
  RVA=0x03D78C60  token=0x6000425  Unity.Mathematics.double4 ceil(Unity.Mathematics.double4 x)
  RVA=0x09C52E74  token=0x6000426  System.Single round(System.Single x)
  RVA=0x09C52FB4  token=0x6000427  Unity.Mathematics.float2 round(Unity.Mathematics.float2 x)
  RVA=0x04D566C4  token=0x6000428  Unity.Mathematics.float3 round(Unity.Mathematics.float3 x)
  RVA=0x04D56830  token=0x6000429  Unity.Mathematics.float4 round(Unity.Mathematics.float4 x)
  RVA=0x09C52E24  token=0x600042A  System.Double round(System.Double x)
  RVA=0x04D5667C  token=0x600042B  Unity.Mathematics.double2 round(Unity.Mathematics.double2 x)
  RVA=0x09C52ECC  token=0x600042C  Unity.Mathematics.double3 round(Unity.Mathematics.double3 x)
  RVA=0x09C52F30  token=0x600042D  Unity.Mathematics.double4 round(Unity.Mathematics.double4 x)
  RVA=0x09C5783C  token=0x600042E  System.Single trunc(System.Single x)
  RVA=0x09C57800  token=0x600042F  Unity.Mathematics.float2 trunc(Unity.Mathematics.float2 x)
  RVA=0x04D5E128  token=0x6000430  Unity.Mathematics.float3 trunc(Unity.Mathematics.float3 x)
  RVA=0x04D5DFD0  token=0x6000431  Unity.Mathematics.float4 trunc(Unity.Mathematics.float4 x)
  RVA=0x09C576C8  token=0x6000432  System.Double trunc(System.Double x)
  RVA=0x04D5E210  token=0x6000433  Unity.Mathematics.double2 trunc(Unity.Mathematics.double2 x)
  RVA=0x09C57718  token=0x6000434  Unity.Mathematics.double3 trunc(Unity.Mathematics.double3 x)
  RVA=0x09C5777C  token=0x6000435  Unity.Mathematics.double4 trunc(Unity.Mathematics.double4 x)
  RVA=0x03D6D920  token=0x6000436  System.Single frac(System.Single x)
  RVA=0x09C35560  token=0x6000437  Unity.Mathematics.float2 frac(Unity.Mathematics.float2 x)
  RVA=0x04D32EC4  token=0x6000438  Unity.Mathematics.float3 frac(Unity.Mathematics.float3 x)
  RVA=0x09C354FC  token=0x6000439  Unity.Mathematics.float4 frac(Unity.Mathematics.float4 x)
  RVA=0x03D7B290  token=0x600043A  System.Double frac(System.Double x)
  RVA=0x09C35624  token=0x600043B  Unity.Mathematics.double2 frac(Unity.Mathematics.double2 x)
  RVA=0x09C35590  token=0x600043C  Unity.Mathematics.double3 frac(Unity.Mathematics.double3 x)
  RVA=0x09C35688  token=0x600043D  Unity.Mathematics.double4 frac(Unity.Mathematics.double4 x)
  RVA=0x09C5128C  token=0x600043E  System.Single rcp(System.Single x)
  RVA=0x09C5114C  token=0x600043F  Unity.Mathematics.float2 rcp(Unity.Mathematics.float2 x)
  RVA=0x09C511B8  token=0x6000440  Unity.Mathematics.float3 rcp(Unity.Mathematics.float3 x)
  RVA=0x09C51220  token=0x6000441  Unity.Mathematics.float4 rcp(Unity.Mathematics.float4 x)
  RVA=0x09C5113C  token=0x6000442  System.Double rcp(System.Double x)
  RVA=0x09C511F8  token=0x6000443  Unity.Mathematics.double2 rcp(Unity.Mathematics.double2 x)
  RVA=0x09C51100  token=0x6000444  Unity.Mathematics.double3 rcp(Unity.Mathematics.double3 x)
  RVA=0x09C51174  token=0x6000445  Unity.Mathematics.double4 rcp(Unity.Mathematics.double4 x)
  RVA=0x09C54B60  token=0x6000446  System.Int32 sign(System.Int32 x)
  RVA=0x09C54CA8  token=0x6000447  Unity.Mathematics.int2 sign(Unity.Mathematics.int2 x)
  RVA=0x09C54D5C  token=0x6000448  Unity.Mathematics.int3 sign(Unity.Mathematics.int3 x)
  RVA=0x09C54C48  token=0x6000449  Unity.Mathematics.int4 sign(Unity.Mathematics.int4 x)
  RVA=0x04D59FAC  token=0x600044A  System.Single sign(System.Single x)
  RVA=0x09C54BA8  token=0x600044B  Unity.Mathematics.float2 sign(Unity.Mathematics.float2 x)
  RVA=0x09C54D24  token=0x600044C  Unity.Mathematics.float3 sign(Unity.Mathematics.float3 x)
  RVA=0x09C54C00  token=0x600044D  Unity.Mathematics.float4 sign(Unity.Mathematics.float4 x)
  RVA=0x04D59F74  token=0x600044E  System.Double sign(System.Double x)
  RVA=0x09C54BD8  token=0x600044F  Unity.Mathematics.double2 sign(Unity.Mathematics.double2 x)
  RVA=0x09C54B70  token=0x6000450  Unity.Mathematics.double3 sign(Unity.Mathematics.double3 x)
  RVA=0x09C54CDC  token=0x6000451  Unity.Mathematics.double4 sign(Unity.Mathematics.double4 x)
  RVA=0x09C5064C  token=0x6000452  System.Single pow(System.Single x, System.Single y)
  RVA=0x09C506B0  token=0x6000453  Unity.Mathematics.float2 pow(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y)
  RVA=0x04D53BF4  token=0x6000454  Unity.Mathematics.float3 pow(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  RVA=0x04D53EEC  token=0x6000455  Unity.Mathematics.float4 pow(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y)
  RVA=0x09C506FC  token=0x6000456  System.Double pow(System.Double x, System.Double y)
  RVA=0x04D53E8C  token=0x6000457  Unity.Mathematics.double2 pow(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y)
  RVA=0x09C505CC  token=0x6000458  Unity.Mathematics.double3 pow(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y)
  RVA=0x09C5075C  token=0x6000459  Unity.Mathematics.double4 pow(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y)
  RVA=0x09C320B4  token=0x600045A  System.Single exp(System.Single x)
  RVA=0x03D7A580  token=0x600045B  Unity.Mathematics.float2 exp(Unity.Mathematics.float2 x)
  RVA=0x03D7A6B0  token=0x600045C  Unity.Mathematics.float3 exp(Unity.Mathematics.float3 x)
  RVA=0x03D7A520  token=0x600045D  Unity.Mathematics.float4 exp(Unity.Mathematics.float4 x)
  RVA=0x09C32064  token=0x600045E  System.Double exp(System.Double x)
  RVA=0x03D7A5C0  token=0x600045F  Unity.Mathematics.double2 exp(Unity.Mathematics.double2 x)
  RVA=0x03D7A600  token=0x6000460  Unity.Mathematics.double3 exp(Unity.Mathematics.double3 x)
  RVA=0x03D7A650  token=0x6000461  Unity.Mathematics.double4 exp(Unity.Mathematics.double4 x)
  RVA=0x09C31E88  token=0x6000462  System.Single exp2(System.Single x)
  RVA=0x09C32028  token=0x6000463  Unity.Mathematics.float2 exp2(Unity.Mathematics.float2 x)
  RVA=0x04D30974  token=0x6000464  Unity.Mathematics.float3 exp2(Unity.Mathematics.float3 x)
  RVA=0x04D30C20  token=0x6000465  Unity.Mathematics.float4 exp2(Unity.Mathematics.float4 x)
  RVA=0x09C31EE8  token=0x6000466  System.Double exp2(System.Double x)
  RVA=0x04D30A90  token=0x6000467  Unity.Mathematics.double2 exp2(Unity.Mathematics.double2 x)
  RVA=0x09C31F40  token=0x6000468  Unity.Mathematics.double3 exp2(Unity.Mathematics.double3 x)
  RVA=0x09C31FA4  token=0x6000469  Unity.Mathematics.double4 exp2(Unity.Mathematics.double4 x)
  RVA=0x09C31E28  token=0x600046A  System.Single exp10(System.Single x)
  RVA=0x09C31CAC  token=0x600046B  Unity.Mathematics.float2 exp10(Unity.Mathematics.float2 x)
  RVA=0x04D30644  token=0x600046C  Unity.Mathematics.float3 exp10(Unity.Mathematics.float3 x)
  RVA=0x04D307B4  token=0x600046D  Unity.Mathematics.float4 exp10(Unity.Mathematics.float4 x)
  RVA=0x09C31D6C  token=0x600046E  System.Double exp10(System.Double x)
  RVA=0x04D306E8  token=0x600046F  Unity.Mathematics.double2 exp10(Unity.Mathematics.double2 x)
  RVA=0x09C31DC4  token=0x6000470  Unity.Mathematics.double3 exp10(Unity.Mathematics.double3 x)
  RVA=0x09C31CE8  token=0x6000471  Unity.Mathematics.double4 exp10(Unity.Mathematics.double4 x)
  RVA=0x09C403E8  token=0x6000472  System.Single log(System.Single x)
  RVA=0x03D7BAE0  token=0x6000473  Unity.Mathematics.float2 log(Unity.Mathematics.float2 x)
  RVA=0x03D7BB70  token=0x6000474  Unity.Mathematics.float3 log(Unity.Mathematics.float3 x)
  RVA=0x03D7BA80  token=0x6000475  Unity.Mathematics.float4 log(Unity.Mathematics.float4 x)
  RVA=0x09C40398  token=0x6000476  System.Double log(System.Double x)
  RVA=0x03D7BA40  token=0x6000477  Unity.Mathematics.double2 log(Unity.Mathematics.double2 x)
  RVA=0x03D7BB20  token=0x6000478  Unity.Mathematics.double3 log(Unity.Mathematics.double3 x)
  RVA=0x03D7BBC0  token=0x6000479  Unity.Mathematics.double4 log(Unity.Mathematics.double4 x)
  RVA=0x09C401BC  token=0x600047A  System.Single log2(System.Single x)
  RVA=0x09C40218  token=0x600047B  Unity.Mathematics.float2 log2(Unity.Mathematics.float2 x)
  RVA=0x04D3C568  token=0x600047C  Unity.Mathematics.float3 log2(Unity.Mathematics.float3 x)
  RVA=0x04D3C5CC  token=0x600047D  Unity.Mathematics.float4 log2(Unity.Mathematics.float4 x)
  RVA=0x09C40254  token=0x600047E  System.Double log2(System.Double x)
  RVA=0x04D3C4C4  token=0x600047F  Unity.Mathematics.double2 log2(Unity.Mathematics.double2 x)
  RVA=0x09C402B0  token=0x6000480  Unity.Mathematics.double3 log2(Unity.Mathematics.double3 x)
  RVA=0x09C40314  token=0x6000481  Unity.Mathematics.double4 log2(Unity.Mathematics.double4 x)
  RVA=0x09C40114  token=0x6000482  System.Single log10(System.Single x)
  RVA=0x03D7B9B0  token=0x6000483  Unity.Mathematics.float2 log10(Unity.Mathematics.float2 x)
  RVA=0x03D7B9F0  token=0x6000484  Unity.Mathematics.float3 log10(Unity.Mathematics.float3 x)
  RVA=0x03D7B900  token=0x6000485  Unity.Mathematics.float4 log10(Unity.Mathematics.float4 x)
  RVA=0x09C4016C  token=0x6000486  System.Double log10(System.Double x)
  RVA=0x03D7B860  token=0x6000487  Unity.Mathematics.double2 log10(Unity.Mathematics.double2 x)
  RVA=0x03D7B960  token=0x6000488  Unity.Mathematics.double3 log10(Unity.Mathematics.double3 x)
  RVA=0x03D7B8A0  token=0x6000489  Unity.Mathematics.double4 log10(Unity.Mathematics.double4 x)
  RVA=0x03D51650  token=0x600048A  System.Single fmod(System.Single x, System.Single y)
  RVA=0x03D7AF60  token=0x600048B  Unity.Mathematics.float2 fmod(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y)
  RVA=0x03D7AE80  token=0x600048C  Unity.Mathematics.float3 fmod(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  RVA=0x03D7AFB0  token=0x600048D  Unity.Mathematics.float4 fmod(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y)
  RVA=0x03D7B110  token=0x600048E  System.Double fmod(System.Double x, System.Double y)
  RVA=0x03D7B0B0  token=0x600048F  Unity.Mathematics.double2 fmod(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y)
  RVA=0x03D7AEF0  token=0x6000490  Unity.Mathematics.double3 fmod(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y)
  RVA=0x03D7B030  token=0x6000491  Unity.Mathematics.double4 fmod(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y)
  RVA=0x09C4117C  token=0x6000492  System.Single modf(System.Single x, System.Single& i)
  RVA=0x09C41034  token=0x6000493  Unity.Mathematics.float2 modf(Unity.Mathematics.float2 x, Unity.Mathematics.float2& i)
  RVA=0x04D3D390  token=0x6000494  Unity.Mathematics.float3 modf(Unity.Mathematics.float3 x, Unity.Mathematics.float3& i)
  RVA=0x09C40F94  token=0x6000495  Unity.Mathematics.float4 modf(Unity.Mathematics.float4 x, Unity.Mathematics.float4& i)
  RVA=0x09C41008  token=0x6000496  System.Double modf(System.Double x, System.Double& i)
  RVA=0x09C41108  token=0x6000497  Unity.Mathematics.double2 modf(Unity.Mathematics.double2 x, Unity.Mathematics.double2& i)
  RVA=0x09C40EF0  token=0x6000498  Unity.Mathematics.double3 modf(Unity.Mathematics.double3 x, Unity.Mathematics.double3& i)
  RVA=0x09C4106C  token=0x6000499  Unity.Mathematics.double4 modf(Unity.Mathematics.double4 x, Unity.Mathematics.double4& i)
  RVA=0x09C55AA4  token=0x600049A  System.Single sqrt(System.Single x)
  RVA=0x03D7D080  token=0x600049B  Unity.Mathematics.float2 sqrt(Unity.Mathematics.float2 x)
  RVA=0x03D7D370  token=0x600049C  Unity.Mathematics.float3 sqrt(Unity.Mathematics.float3 x)
  RVA=0x03D7D0F0  token=0x600049D  Unity.Mathematics.float4 sqrt(Unity.Mathematics.float4 x)
  RVA=0x09C55A5C  token=0x600049E  System.Double sqrt(System.Double x)
  RVA=0x03D7D1B0  token=0x600049F  Unity.Mathematics.double2 sqrt(Unity.Mathematics.double2 x)
  RVA=0x03D7D2E0  token=0x60004A0  Unity.Mathematics.double3 sqrt(Unity.Mathematics.double3 x)
  RVA=0x03D7D220  token=0x60004A1  Unity.Mathematics.double4 sqrt(Unity.Mathematics.double4 x)
  RVA=0x09C530D8  token=0x60004A2  System.Single rsqrt(System.Single x)
  RVA=0x09C5318C  token=0x60004A3  Unity.Mathematics.float2 rsqrt(Unity.Mathematics.float2 x)
  RVA=0x04D568F4  token=0x60004A4  Unity.Mathematics.float3 rsqrt(Unity.Mathematics.float3 x)
  RVA=0x09C53108  token=0x60004A5  Unity.Mathematics.float4 rsqrt(Unity.Mathematics.float4 x)
  RVA=0x09C531C0  token=0x60004A6  System.Double rsqrt(System.Double x)
  RVA=0x09C531F0  token=0x60004A7  Unity.Mathematics.double2 rsqrt(Unity.Mathematics.double2 x)
  RVA=0x09C52FF0  token=0x60004A8  Unity.Mathematics.double3 rsqrt(Unity.Mathematics.double3 x)
  RVA=0x09C53068  token=0x60004A9  Unity.Mathematics.double4 rsqrt(Unity.Mathematics.double4 x)
  RVA=0x09C4FDB0  token=0x60004AA  Unity.Mathematics.float2 normalize(Unity.Mathematics.float2 x)
  RVA=0x09C4FE18  token=0x60004AB  Unity.Mathematics.float3 normalize(Unity.Mathematics.float3 x)
  RVA=0x09C4FCD8  token=0x60004AC  Unity.Mathematics.float4 normalize(Unity.Mathematics.float4 x)
  RVA=0x04D536EC  token=0x60004AD  Unity.Mathematics.double2 normalize(Unity.Mathematics.double2 x)
  RVA=0x09C4FC58  token=0x60004AE  Unity.Mathematics.double3 normalize(Unity.Mathematics.double3 x)
  RVA=0x09C4FD34  token=0x60004AF  Unity.Mathematics.double4 normalize(Unity.Mathematics.double4 x)
  RVA=0x09C4FF3C  token=0x60004B0  Unity.Mathematics.float2 normalizesafe(Unity.Mathematics.float2 x, Unity.Mathematics.float2 defaultvalue)
  RVA=0x04D539D4  token=0x60004B1  Unity.Mathematics.float3 normalizesafe(Unity.Mathematics.float3 x, Unity.Mathematics.float3 defaultvalue)
  RVA=0x09C4FFC4  token=0x60004B2  Unity.Mathematics.float4 normalizesafe(Unity.Mathematics.float4 x, Unity.Mathematics.float4 defaultvalue)
  RVA=0x04D53A74  token=0x60004B3  Unity.Mathematics.double2 normalizesafe(Unity.Mathematics.double2 x, Unity.Mathematics.double2 defaultvalue)
  RVA=0x09C50110  token=0x60004B4  Unity.Mathematics.double3 normalizesafe(Unity.Mathematics.double3 x, Unity.Mathematics.double3 defaultvalue)
  RVA=0x09C4FE8C  token=0x60004B5  Unity.Mathematics.double4 normalizesafe(Unity.Mathematics.double4 x, Unity.Mathematics.double4 defaultvalue)
  RVA=0x03D782D0  token=0x60004B6  System.Single length(System.Single x)
  RVA=0x03D54350  token=0x60004B7  System.Single length(Unity.Mathematics.float2 x)
  RVA=0x09C3F9E4  token=0x60004B8  System.Single length(Unity.Mathematics.float3 x)
  RVA=0x09C3FA88  token=0x60004B9  System.Single length(Unity.Mathematics.float4 x)
  RVA=0x03D78370  token=0x60004BA  System.Double length(System.Double x)
  RVA=0x03D7B7E0  token=0x60004BB  System.Double length(Unity.Mathematics.double2 x)
  RVA=0x09C3FA50  token=0x60004BC  System.Double length(Unity.Mathematics.double3 x)
  RVA=0x09C3FA1C  token=0x60004BD  System.Double length(Unity.Mathematics.double4 x)
  RVA=0x03D51490  token=0x60004BE  System.Single lengthsq(System.Single x)
  RVA=0x03D54330  token=0x60004BF  System.Single lengthsq(Unity.Mathematics.float2 x)
  RVA=0x09C3FB24  token=0x60004C0  System.Single lengthsq(Unity.Mathematics.float3 x)
  RVA=0x09C3FAC4  token=0x60004C1  System.Single lengthsq(Unity.Mathematics.float4 x)
  RVA=0x03D7B840  token=0x60004C2  System.Double lengthsq(System.Double x)
  RVA=0x03D7B820  token=0x60004C3  System.Double lengthsq(Unity.Mathematics.double2 x)
  RVA=0x09C3FAEC  token=0x60004C4  System.Double lengthsq(Unity.Mathematics.double3 x)
  RVA=0x09C3FB58  token=0x60004C5  System.Double lengthsq(Unity.Mathematics.double4 x)
  RVA=0x03D79C60  token=0x60004C6  System.Single distance(System.Single x, System.Single y)
  RVA=0x09C30834  token=0x60004C7  System.Single distance(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y)
  RVA=0x09C306C0  token=0x60004C8  System.Single distance(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  RVA=0x09C30794  token=0x60004C9  System.Single distance(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y)
  RVA=0x03D79C80  token=0x60004CA  System.Double distance(System.Double x, System.Double y)
  RVA=0x09C307F4  token=0x60004CB  System.Double distance(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y)
  RVA=0x09C3064C  token=0x60004CC  System.Double distance(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y)
  RVA=0x09C30728  token=0x60004CD  System.Double distance(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y)
  RVA=0x03D79CA0  token=0x60004CE  System.Single distancesq(System.Single x, System.Single y)
  RVA=0x09C30870  token=0x60004CF  System.Single distancesq(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y)
  RVA=0x09C309CC  token=0x60004D0  System.Single distancesq(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  RVA=0x09C308A8  token=0x60004D1  System.Single distancesq(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y)
  RVA=0x03D79CB0  token=0x60004D2  System.Double distancesq(System.Double x, System.Double y)
  RVA=0x09C30A30  token=0x60004D3  System.Double distancesq(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y)
  RVA=0x09C3095C  token=0x60004D4  System.Double distancesq(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y)
  RVA=0x09C308F4  token=0x60004D5  System.Double distancesq(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y)
  RVA=0x09C30228  token=0x60004D6  Unity.Mathematics.float3 cross(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  RVA=0x09C30310  token=0x60004D7  Unity.Mathematics.double3 cross(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y)
  RVA=0x09C557AC  token=0x60004D8  System.Single smoothstep(System.Single xMin, System.Single xMax, System.Single x)
  RVA=0x09C557F8  token=0x60004D9  Unity.Mathematics.float2 smoothstep(Unity.Mathematics.float2 xMin, Unity.Mathematics.float2 xMax, Unity.Mathematics.float2 x)
  RVA=0x04D5A674  token=0x60004DA  Unity.Mathematics.float3 smoothstep(Unity.Mathematics.float3 xMin, Unity.Mathematics.float3 xMax, Unity.Mathematics.float3 x)
  RVA=0x09C55914  token=0x60004DB  Unity.Mathematics.float4 smoothstep(Unity.Mathematics.float4 xMin, Unity.Mathematics.float4 xMax, Unity.Mathematics.float4 x)
  RVA=0x09C558C8  token=0x60004DC  System.Double smoothstep(System.Double xMin, System.Double xMax, System.Double x)
  RVA=0x09C5533C  token=0x60004DD  Unity.Mathematics.double2 smoothstep(Unity.Mathematics.double2 xMin, Unity.Mathematics.double2 xMax, Unity.Mathematics.double2 x)
  RVA=0x09C555EC  token=0x60004DE  Unity.Mathematics.double3 smoothstep(Unity.Mathematics.double3 xMin, Unity.Mathematics.double3 xMax, Unity.Mathematics.double3 x)
  RVA=0x09C5544C  token=0x60004DF  Unity.Mathematics.double4 smoothstep(Unity.Mathematics.double4 xMin, Unity.Mathematics.double4 xMax, Unity.Mathematics.double4 x)
  RVA=0x09C2E5F8  token=0x60004E0  System.Boolean any(Unity.Mathematics.bool2 x)
  RVA=0x09C2E6B4  token=0x60004E1  System.Boolean any(Unity.Mathematics.bool3 x)
  RVA=0x04D2CD54  token=0x60004E2  System.Boolean any(Unity.Mathematics.bool4 x)
  RVA=0x09C2E5E4  token=0x60004E3  System.Boolean any(Unity.Mathematics.int2 x)
  RVA=0x09C2E608  token=0x60004E4  System.Boolean any(Unity.Mathematics.int3 x)
  RVA=0x09C2E5C8  token=0x60004E5  System.Boolean any(Unity.Mathematics.int4 x)
  RVA=0x09C2E5E4  token=0x60004E6  System.Boolean any(Unity.Mathematics.uint2 x)
  RVA=0x09C2E608  token=0x60004E7  System.Boolean any(Unity.Mathematics.uint3 x)
  RVA=0x09C2E5C8  token=0x60004E8  System.Boolean any(Unity.Mathematics.uint4 x)
  RVA=0x09C2E6C8  token=0x60004E9  System.Boolean any(Unity.Mathematics.float2 x)
  RVA=0x09C2E644  token=0x60004EA  System.Boolean any(Unity.Mathematics.float3 x)
  RVA=0x09C2E6F0  token=0x60004EB  System.Boolean any(Unity.Mathematics.float4 x)
  RVA=0x09C2E620  token=0x60004EC  System.Boolean any(Unity.Mathematics.double2 x)
  RVA=0x09C2E728  token=0x60004ED  System.Boolean any(Unity.Mathematics.double3 x)
  RVA=0x09C2E670  token=0x60004EE  System.Boolean any(Unity.Mathematics.double4 x)
  RVA=0x09C2E3B8  token=0x60004EF  System.Boolean all(Unity.Mathematics.bool2 x)
  RVA=0x09C2E4E8  token=0x60004F0  System.Boolean all(Unity.Mathematics.bool3 x)
  RVA=0x04D2CBB0  token=0x60004F1  System.Boolean all(Unity.Mathematics.bool4 x)
  RVA=0x09C2E3C8  token=0x60004F2  System.Boolean all(Unity.Mathematics.int2 x)
  RVA=0x04D2CBD0  token=0x60004F3  System.Boolean all(Unity.Mathematics.int3 x)
  RVA=0x09C2E46C  token=0x60004F4  System.Boolean all(Unity.Mathematics.int4 x)
  RVA=0x09C2E3C8  token=0x60004F5  System.Boolean all(Unity.Mathematics.uint2 x)
  RVA=0x04D2CBD0  token=0x60004F6  System.Boolean all(Unity.Mathematics.uint3 x)
  RVA=0x09C2E46C  token=0x60004F7  System.Boolean all(Unity.Mathematics.uint4 x)
  RVA=0x09C2E488  token=0x60004F8  System.Boolean all(Unity.Mathematics.float2 x)
  RVA=0x04D2CBE8  token=0x60004F9  System.Boolean all(Unity.Mathematics.float3 x)
  RVA=0x09C2E4B0  token=0x60004FA  System.Boolean all(Unity.Mathematics.float4 x)
  RVA=0x09C2E4FC  token=0x60004FB  System.Boolean all(Unity.Mathematics.double2 x)
  RVA=0x09C2E420  token=0x60004FC  System.Boolean all(Unity.Mathematics.double3 x)
  RVA=0x09C2E3DC  token=0x60004FD  System.Boolean all(Unity.Mathematics.double4 x)
  RVA=0x09C5352C  token=0x60004FE  System.Int32 select(System.Int32 falseValue, System.Int32 trueValue, System.Boolean test)
  RVA=0x09C53544  token=0x60004FF  Unity.Mathematics.int2 select(Unity.Mathematics.int2 falseValue, Unity.Mathematics.int2 trueValue, System.Boolean test)
  RVA=0x09C53568  token=0x6000500  Unity.Mathematics.int3 select(Unity.Mathematics.int3 falseValue, Unity.Mathematics.int3 trueValue, System.Boolean test)
  RVA=0x09C53550  token=0x6000501  Unity.Mathematics.int4 select(Unity.Mathematics.int4 falseValue, Unity.Mathematics.int4 trueValue, System.Boolean test)
  RVA=0x09C5358C  token=0x6000502  Unity.Mathematics.int2 select(Unity.Mathematics.int2 falseValue, Unity.Mathematics.int2 trueValue, Unity.Mathematics.bool2 test)
  RVA=0x04D56E84  token=0x6000503  Unity.Mathematics.int3 select(Unity.Mathematics.int3 falseValue, Unity.Mathematics.int3 trueValue, Unity.Mathematics.bool3 test)
  RVA=0x04D56FE8  token=0x6000504  Unity.Mathematics.int4 select(Unity.Mathematics.int4 falseValue, Unity.Mathematics.int4 trueValue, Unity.Mathematics.bool4 test)
  RVA=0x09C5352C  token=0x6000505  System.UInt32 select(System.UInt32 falseValue, System.UInt32 trueValue, System.Boolean test)
  RVA=0x09C53544  token=0x6000506  Unity.Mathematics.uint2 select(Unity.Mathematics.uint2 falseValue, Unity.Mathematics.uint2 trueValue, System.Boolean test)
  RVA=0x09C53568  token=0x6000507  Unity.Mathematics.uint3 select(Unity.Mathematics.uint3 falseValue, Unity.Mathematics.uint3 trueValue, System.Boolean test)
  RVA=0x09C53550  token=0x6000508  Unity.Mathematics.uint4 select(Unity.Mathematics.uint4 falseValue, Unity.Mathematics.uint4 trueValue, System.Boolean test)
  RVA=0x09C5358C  token=0x6000509  Unity.Mathematics.uint2 select(Unity.Mathematics.uint2 falseValue, Unity.Mathematics.uint2 trueValue, Unity.Mathematics.bool2 test)
  RVA=0x04D56E84  token=0x600050A  Unity.Mathematics.uint3 select(Unity.Mathematics.uint3 falseValue, Unity.Mathematics.uint3 trueValue, Unity.Mathematics.bool3 test)
  RVA=0x04D56FE8  token=0x600050B  Unity.Mathematics.uint4 select(Unity.Mathematics.uint4 falseValue, Unity.Mathematics.uint4 trueValue, Unity.Mathematics.bool4 test)
  RVA=0x09C53520  token=0x600050C  System.Int64 select(System.Int64 falseValue, System.Int64 trueValue, System.Boolean test)
  RVA=0x09C53520  token=0x600050D  System.UInt64 select(System.UInt64 falseValue, System.UInt64 trueValue, System.Boolean test)
  RVA=0x09C53538  token=0x600050E  System.Single select(System.Single falseValue, System.Single trueValue, System.Boolean test)
  RVA=0x09C53544  token=0x600050F  Unity.Mathematics.float2 select(Unity.Mathematics.float2 falseValue, Unity.Mathematics.float2 trueValue, System.Boolean test)
  RVA=0x09C53568  token=0x6000510  Unity.Mathematics.float3 select(Unity.Mathematics.float3 falseValue, Unity.Mathematics.float3 trueValue, System.Boolean test)
  RVA=0x09C53550  token=0x6000511  Unity.Mathematics.float4 select(Unity.Mathematics.float4 falseValue, Unity.Mathematics.float4 trueValue, System.Boolean test)
  RVA=0x04D56EC4  token=0x6000512  Unity.Mathematics.float2 select(Unity.Mathematics.float2 falseValue, Unity.Mathematics.float2 trueValue, Unity.Mathematics.bool2 test)
  RVA=0x04D56F08  token=0x6000513  Unity.Mathematics.float3 select(Unity.Mathematics.float3 falseValue, Unity.Mathematics.float3 trueValue, Unity.Mathematics.bool3 test)
  RVA=0x04D56F7C  token=0x6000514  Unity.Mathematics.float4 select(Unity.Mathematics.float4 falseValue, Unity.Mathematics.float4 trueValue, Unity.Mathematics.bool4 test)
  RVA=0x09C53538  token=0x6000515  System.Double select(System.Double falseValue, System.Double trueValue, System.Boolean test)
  RVA=0x09C53550  token=0x6000516  Unity.Mathematics.double2 select(Unity.Mathematics.double2 falseValue, Unity.Mathematics.double2 trueValue, System.Boolean test)
  RVA=0x09C536B0  token=0x6000517  Unity.Mathematics.double3 select(Unity.Mathematics.double3 falseValue, Unity.Mathematics.double3 trueValue, System.Boolean test)
  RVA=0x09C536D8  token=0x6000518  Unity.Mathematics.double4 select(Unity.Mathematics.double4 falseValue, Unity.Mathematics.double4 trueValue, System.Boolean test)
  RVA=0x04D56E50  token=0x6000519  Unity.Mathematics.double2 select(Unity.Mathematics.double2 falseValue, Unity.Mathematics.double2 trueValue, Unity.Mathematics.bool2 test)
  RVA=0x09C53630  token=0x600051A  Unity.Mathematics.double3 select(Unity.Mathematics.double3 falseValue, Unity.Mathematics.double3 trueValue, Unity.Mathematics.bool3 test)
  RVA=0x09C535BC  token=0x600051B  Unity.Mathematics.double4 select(Unity.Mathematics.double4 falseValue, Unity.Mathematics.double4 trueValue, Unity.Mathematics.bool4 test)
  RVA=0x09C55C54  token=0x600051C  System.Single step(System.Single threshold, System.Single x)
  RVA=0x09C55FC0  token=0x600051D  Unity.Mathematics.float2 step(Unity.Mathematics.float2 threshold, Unity.Mathematics.float2 x)
  RVA=0x09C55E70  token=0x600051E  Unity.Mathematics.float3 step(Unity.Mathematics.float3 threshold, Unity.Mathematics.float3 x)
  RVA=0x09C55C7C  token=0x600051F  Unity.Mathematics.float4 step(Unity.Mathematics.float4 threshold, Unity.Mathematics.float4 x)
  RVA=0x09C55C68  token=0x6000520  System.Double step(System.Double threshold, System.Double x)
  RVA=0x09C55DFC  token=0x6000521  Unity.Mathematics.double2 step(Unity.Mathematics.double2 threshold, Unity.Mathematics.double2 x)
  RVA=0x09C55D38  token=0x6000522  Unity.Mathematics.double3 step(Unity.Mathematics.double3 threshold, Unity.Mathematics.double3 x)
  RVA=0x09C55F1C  token=0x6000523  Unity.Mathematics.double4 step(Unity.Mathematics.double4 threshold, Unity.Mathematics.double4 x)
  RVA=0x09C5129C  token=0x6000524  Unity.Mathematics.float2 reflect(Unity.Mathematics.float2 i, Unity.Mathematics.float2 n)
  RVA=0x04D54B90  token=0x6000525  Unity.Mathematics.float3 reflect(Unity.Mathematics.float3 i, Unity.Mathematics.float3 n)
  RVA=0x09C51548  token=0x6000526  Unity.Mathematics.float4 reflect(Unity.Mathematics.float4 i, Unity.Mathematics.float4 n)
  RVA=0x09C514B0  token=0x6000527  Unity.Mathematics.double2 reflect(Unity.Mathematics.double2 i, Unity.Mathematics.double2 n)
  RVA=0x09C513CC  token=0x6000528  Unity.Mathematics.double3 reflect(Unity.Mathematics.double3 i, Unity.Mathematics.double3 n)
  RVA=0x09C512F4  token=0x6000529  Unity.Mathematics.double4 reflect(Unity.Mathematics.double4 i, Unity.Mathematics.double4 n)
  RVA=0x09C51734  token=0x600052A  Unity.Mathematics.float2 refract(Unity.Mathematics.float2 i, Unity.Mathematics.float2 n, System.Single indexOfRefraction)
  RVA=0x04D55064  token=0x600052B  Unity.Mathematics.float3 refract(Unity.Mathematics.float3 i, Unity.Mathematics.float3 n, System.Single indexOfRefraction)
  RVA=0x09C51AFC  token=0x600052C  Unity.Mathematics.float4 refract(Unity.Mathematics.float4 i, Unity.Mathematics.float4 n, System.Single indexOfRefraction)
  RVA=0x09C51838  token=0x600052D  Unity.Mathematics.double2 refract(Unity.Mathematics.double2 i, Unity.Mathematics.double2 n, System.Double indexOfRefraction)
  RVA=0x09C5194C  token=0x600052E  Unity.Mathematics.double3 refract(Unity.Mathematics.double3 i, Unity.Mathematics.double3 n, System.Double indexOfRefraction)
  RVA=0x09C515DC  token=0x600052F  Unity.Mathematics.double4 refract(Unity.Mathematics.double4 i, Unity.Mathematics.double4 n, System.Double indexOfRefraction)
  RVA=0x09C50800  token=0x6000530  Unity.Mathematics.float2 project(Unity.Mathematics.float2 a, Unity.Mathematics.float2 ontoB)
  RVA=0x04D540A4  token=0x6000531  Unity.Mathematics.float3 project(Unity.Mathematics.float3 a, Unity.Mathematics.float3 ontoB)
  RVA=0x09C50998  token=0x6000532  Unity.Mathematics.float4 project(Unity.Mathematics.float4 a, Unity.Mathematics.float4 ontoB)
  RVA=0x09C50A70  token=0x6000533  Unity.Mathematics.float2 projectsafe(Unity.Mathematics.float2 a, Unity.Mathematics.float2 ontoB, Unity.Mathematics.float2 defaultValue)
  RVA=0x04D54364  token=0x6000534  Unity.Mathematics.float3 projectsafe(Unity.Mathematics.float3 a, Unity.Mathematics.float3 ontoB, Unity.Mathematics.float3 defaultValue)
  RVA=0x09C50A08  token=0x6000535  Unity.Mathematics.float4 projectsafe(Unity.Mathematics.float4 a, Unity.Mathematics.float4 ontoB, Unity.Mathematics.float4 defaultValue)
  RVA=0x04D54030  token=0x6000536  Unity.Mathematics.double2 project(Unity.Mathematics.double2 a, Unity.Mathematics.double2 ontoB)
  RVA=0x09C508EC  token=0x6000537  Unity.Mathematics.double3 project(Unity.Mathematics.double3 a, Unity.Mathematics.double3 ontoB)
  RVA=0x09C5084C  token=0x6000538  Unity.Mathematics.double4 project(Unity.Mathematics.double4 a, Unity.Mathematics.double4 ontoB)
  RVA=0x09C50BAC  token=0x6000539  Unity.Mathematics.double2 projectsafe(Unity.Mathematics.double2 a, Unity.Mathematics.double2 ontoB, Unity.Mathematics.double2 defaultValue)
  RVA=0x09C50C10  token=0x600053A  Unity.Mathematics.double3 projectsafe(Unity.Mathematics.double3 a, Unity.Mathematics.double3 ontoB, Unity.Mathematics.double3 defaultValue)
  RVA=0x09C50B10  token=0x600053B  Unity.Mathematics.double4 projectsafe(Unity.Mathematics.double4 a, Unity.Mathematics.double4 ontoB, Unity.Mathematics.double4 defaultValue)
  RVA=0x09C32F78  token=0x600053C  Unity.Mathematics.float2 faceforward(Unity.Mathematics.float2 n, Unity.Mathematics.float2 i, Unity.Mathematics.float2 ng)
  RVA=0x04D31E3C  token=0x600053D  Unity.Mathematics.float3 faceforward(Unity.Mathematics.float3 n, Unity.Mathematics.float3 i, Unity.Mathematics.float3 ng)
  RVA=0x09C32E9C  token=0x600053E  Unity.Mathematics.float4 faceforward(Unity.Mathematics.float4 n, Unity.Mathematics.float4 i, Unity.Mathematics.float4 ng)
  RVA=0x09C32F04  token=0x600053F  Unity.Mathematics.double2 faceforward(Unity.Mathematics.double2 n, Unity.Mathematics.double2 i, Unity.Mathematics.double2 ng)
  RVA=0x09C32FD0  token=0x6000540  Unity.Mathematics.double3 faceforward(Unity.Mathematics.double3 n, Unity.Mathematics.double3 i, Unity.Mathematics.double3 ng)
  RVA=0x09C33094  token=0x6000541  Unity.Mathematics.double4 faceforward(Unity.Mathematics.double4 n, Unity.Mathematics.double4 i, Unity.Mathematics.double4 ng)
  RVA=0x03D7CE60  token=0x6000542  System.Void sincos(System.Single x, System.Single& s, System.Single& c)
  RVA=0x09C550B0  token=0x6000543  System.Void sincos(Unity.Mathematics.float2 x, Unity.Mathematics.float2& s, Unity.Mathematics.float2& c)
  RVA=0x09C54ED0  token=0x6000544  System.Void sincos(Unity.Mathematics.float3 x, Unity.Mathematics.float3& s, Unity.Mathematics.float3& c)
  RVA=0x09C54F54  token=0x6000545  System.Void sincos(Unity.Mathematics.float4 x, Unity.Mathematics.float4& s, Unity.Mathematics.float4& c)
  RVA=0x03D7CE20  token=0x6000546  System.Void sincos(System.Double x, System.Double& s, System.Double& c)
  RVA=0x09C54FBC  token=0x6000547  System.Void sincos(Unity.Mathematics.double2 x, Unity.Mathematics.double2& s, Unity.Mathematics.double2& c)
  RVA=0x09C55024  token=0x6000548  System.Void sincos(Unity.Mathematics.double3 x, Unity.Mathematics.double3& s, Unity.Mathematics.double3& c)
  RVA=0x09C54E4C  token=0x6000549  System.Void sincos(Unity.Mathematics.double4 x, Unity.Mathematics.double4& s, Unity.Mathematics.double4& c)
  RVA=0x03D791F0  token=0x600054A  System.Int32 countbits(System.Int32 x)
  RVA=0x09C2FEC4  token=0x600054B  Unity.Mathematics.int2 countbits(Unity.Mathematics.int2 x)
  RVA=0x09C301C8  token=0x600054C  Unity.Mathematics.int3 countbits(Unity.Mathematics.int3 x)
  RVA=0x09C30168  token=0x600054D  Unity.Mathematics.int4 countbits(Unity.Mathematics.int4 x)
  RVA=0x03D791F0  token=0x600054E  System.Int32 countbits(System.UInt32 x)
  RVA=0x09C2FEDC  token=0x600054F  Unity.Mathematics.int2 countbits(Unity.Mathematics.uint2 x)
  RVA=0x04D2EC34  token=0x6000550  Unity.Mathematics.int3 countbits(Unity.Mathematics.uint3 x)
  RVA=0x09C2FFD8  token=0x6000551  Unity.Mathematics.int4 countbits(Unity.Mathematics.uint4 x)
  RVA=0x03D79190  token=0x6000552  System.Int32 countbits(System.UInt64 x)
  RVA=0x03D79190  token=0x6000553  System.Int32 countbits(System.Int64 x)
  RVA=0x09C40544  token=0x6000554  System.Int32 lzcnt(System.Int32 x)
  RVA=0x09C40510  token=0x6000555  Unity.Mathematics.int2 lzcnt(Unity.Mathematics.int2 x)
  RVA=0x09C40440  token=0x6000556  Unity.Mathematics.int3 lzcnt(Unity.Mathematics.int3 x)
  RVA=0x09C404C4  token=0x6000557  Unity.Mathematics.int4 lzcnt(Unity.Mathematics.int4 x)
  RVA=0x09C40480  token=0x6000558  System.Int32 lzcnt(System.UInt32 x)
  RVA=0x09C40510  token=0x6000559  Unity.Mathematics.int2 lzcnt(Unity.Mathematics.uint2 x)
  RVA=0x09C40440  token=0x600055A  Unity.Mathematics.int3 lzcnt(Unity.Mathematics.uint3 x)
  RVA=0x09C404C4  token=0x600055B  Unity.Mathematics.int4 lzcnt(Unity.Mathematics.uint4 x)
  RVA=0x09C4053C  token=0x600055C  System.Int32 lzcnt(System.Int64 x)
  RVA=0x09C4054C  token=0x600055D  System.Int32 lzcnt(System.UInt64 x)
  RVA=0x09C579A4  token=0x600055E  System.Int32 tzcnt(System.Int32 x)
  RVA=0x09C57924  token=0x600055F  Unity.Mathematics.int2 tzcnt(Unity.Mathematics.int2 x)
  RVA=0x09C578E0  token=0x6000560  Unity.Mathematics.int3 tzcnt(Unity.Mathematics.int3 x)
  RVA=0x09C57950  token=0x6000561  Unity.Mathematics.int4 tzcnt(Unity.Mathematics.int4 x)
  RVA=0x09C57898  token=0x6000562  System.Int32 tzcnt(System.UInt32 x)
  RVA=0x09C57924  token=0x6000563  Unity.Mathematics.int2 tzcnt(Unity.Mathematics.uint2 x)
  RVA=0x09C578E0  token=0x6000564  Unity.Mathematics.int3 tzcnt(Unity.Mathematics.uint3 x)
  RVA=0x09C57950  token=0x6000565  Unity.Mathematics.int4 tzcnt(Unity.Mathematics.uint4 x)
  RVA=0x09C579AC  token=0x6000566  System.Int32 tzcnt(System.Int64 x)
  RVA=0x09C579B4  token=0x6000567  System.Int32 tzcnt(System.UInt64 x)
  RVA=0x09C52498  token=0x6000568  System.Int32 reversebits(System.Int32 x)
  RVA=0x09C524A0  token=0x6000569  Unity.Mathematics.int2 reversebits(Unity.Mathematics.int2 x)
  RVA=0x09C524D0  token=0x600056A  Unity.Mathematics.int3 reversebits(Unity.Mathematics.int3 x)
  RVA=0x09C52270  token=0x600056B  Unity.Mathematics.int4 reversebits(Unity.Mathematics.int4 x)
  RVA=0x03D7CB90  token=0x600056C  System.UInt32 reversebits(System.UInt32 x)
  RVA=0x09C522E4  token=0x600056D  Unity.Mathematics.uint2 reversebits(Unity.Mathematics.uint2 x)
  RVA=0x04D55AD0  token=0x600056E  Unity.Mathematics.uint3 reversebits(Unity.Mathematics.uint3 x)
  RVA=0x09C51FB8  token=0x600056F  Unity.Mathematics.uint4 reversebits(Unity.Mathematics.uint4 x)
  RVA=0x09C52490  token=0x6000570  System.Int64 reversebits(System.Int64 x)
  RVA=0x03D7CBD0  token=0x6000571  System.UInt64 reversebits(System.UInt64 x)
  RVA=0x03D50D20  token=0x6000572  System.Int32 rol(System.Int32 x, System.Int32 n)
  RVA=0x09C526F0  token=0x6000573  Unity.Mathematics.int2 rol(Unity.Mathematics.int2 x, System.Int32 n)
  RVA=0x09C52584  token=0x6000574  Unity.Mathematics.int3 rol(Unity.Mathematics.int3 x, System.Int32 n)
  RVA=0x09C52604  token=0x6000575  Unity.Mathematics.int4 rol(Unity.Mathematics.int4 x, System.Int32 n)
  RVA=0x03D50D20  token=0x6000576  System.UInt32 rol(System.UInt32 x, System.Int32 n)
  RVA=0x09C52550  token=0x6000577  Unity.Mathematics.uint2 rol(Unity.Mathematics.uint2 x, System.Int32 n)
  RVA=0x04D5607C  token=0x6000578  Unity.Mathematics.uint3 rol(Unity.Mathematics.uint3 x, System.Int32 n)
  RVA=0x09C52678  token=0x6000579  Unity.Mathematics.uint4 rol(Unity.Mathematics.uint4 x, System.Int32 n)
  RVA=0x03D76910  token=0x600057A  System.Int64 rol(System.Int64 x, System.Int32 n)
  RVA=0x03D76910  token=0x600057B  System.UInt64 rol(System.UInt64 x, System.Int32 n)
  RVA=0x03D6ED80  token=0x600057C  System.Int32 ror(System.Int32 x, System.Int32 n)
  RVA=0x09C52808  token=0x600057D  Unity.Mathematics.int2 ror(Unity.Mathematics.int2 x, System.Int32 n)
  RVA=0x09C52878  token=0x600057E  Unity.Mathematics.int3 ror(Unity.Mathematics.int3 x, System.Int32 n)
  RVA=0x09C52794  token=0x600057F  Unity.Mathematics.int4 ror(Unity.Mathematics.int4 x, System.Int32 n)
  RVA=0x03D6ED80  token=0x6000580  System.UInt32 ror(System.UInt32 x, System.Int32 n)
  RVA=0x09C52760  token=0x6000581  Unity.Mathematics.uint2 ror(Unity.Mathematics.uint2 x, System.Int32 n)
  RVA=0x04D56110  token=0x6000582  Unity.Mathematics.uint3 ror(Unity.Mathematics.uint3 x, System.Int32 n)
  RVA=0x09C528F8  token=0x6000583  Unity.Mathematics.uint4 ror(Unity.Mathematics.uint4 x, System.Int32 n)
  RVA=0x03D6EDD0  token=0x6000584  System.Int64 ror(System.Int64 x, System.Int32 n)
  RVA=0x03D6EDD0  token=0x6000585  System.UInt64 ror(System.UInt64 x, System.Int32 n)
  RVA=0x029CE000  token=0x6000586  System.Int32 ceilpow2(System.Int32 x)
  RVA=0x09C2EF6C  token=0x6000587  Unity.Mathematics.int2 ceilpow2(Unity.Mathematics.int2 x)
  RVA=0x04D2DC58  token=0x6000588  Unity.Mathematics.int3 ceilpow2(Unity.Mathematics.int3 x)
  RVA=0x09C2F26C  token=0x6000589  Unity.Mathematics.int4 ceilpow2(Unity.Mathematics.int4 x)
  RVA=0x03D520C0  token=0x600058A  System.UInt32 ceilpow2(System.UInt32 x)
  RVA=0x09C2F1B4  token=0x600058B  Unity.Mathematics.uint2 ceilpow2(Unity.Mathematics.uint2 x)
  RVA=0x04D2DA44  token=0x600058C  Unity.Mathematics.uint3 ceilpow2(Unity.Mathematics.uint3 x)
  RVA=0x09C2F024  token=0x600058D  Unity.Mathematics.uint4 ceilpow2(Unity.Mathematics.uint4 x)
  RVA=0x03D78D60  token=0x600058E  System.Int64 ceilpow2(System.Int64 x)
  RVA=0x03D78D10  token=0x600058F  System.UInt64 ceilpow2(System.UInt64 x)
  RVA=0x04D2DA28  token=0x6000590  System.Int32 ceillog2(System.Int32 x)
  RVA=0x09C2EF40  token=0x6000591  Unity.Mathematics.int2 ceillog2(Unity.Mathematics.int2 x)
  RVA=0x09C2EEC0  token=0x6000592  Unity.Mathematics.int3 ceillog2(Unity.Mathematics.int3 x)
  RVA=0x09C2EEF8  token=0x6000593  Unity.Mathematics.int4 ceillog2(Unity.Mathematics.int4 x)
  RVA=0x04D2DA28  token=0x6000594  System.Int32 ceillog2(System.UInt32 x)
  RVA=0x09C2EF40  token=0x6000595  Unity.Mathematics.int2 ceillog2(Unity.Mathematics.uint2 x)
  RVA=0x09C2EEC0  token=0x6000596  Unity.Mathematics.int3 ceillog2(Unity.Mathematics.uint3 x)
  RVA=0x09C2EEF8  token=0x6000597  Unity.Mathematics.int4 ceillog2(Unity.Mathematics.uint4 x)
  RVA=0x04D32A74  token=0x6000598  System.Int32 floorlog2(System.Int32 x)
  RVA=0x09C354C8  token=0x6000599  Unity.Mathematics.int2 floorlog2(Unity.Mathematics.int2 x)
  RVA=0x09C35490  token=0x600059A  Unity.Mathematics.int3 floorlog2(Unity.Mathematics.int3 x)
  RVA=0x09C35448  token=0x600059B  Unity.Mathematics.int4 floorlog2(Unity.Mathematics.int4 x)
  RVA=0x04D32A74  token=0x600059C  System.Int32 floorlog2(System.UInt32 x)
  RVA=0x09C354C8  token=0x600059D  Unity.Mathematics.int2 floorlog2(Unity.Mathematics.uint2 x)
  RVA=0x09C35490  token=0x600059E  Unity.Mathematics.int3 floorlog2(Unity.Mathematics.uint3 x)
  RVA=0x09C35448  token=0x600059F  Unity.Mathematics.int4 floorlog2(Unity.Mathematics.uint4 x)
  RVA=0x03D7CB70  token=0x60005A0  System.Single radians(System.Single x)
  RVA=0x09C51024  token=0x60005A1  Unity.Mathematics.float2 radians(Unity.Mathematics.float2 x)
  RVA=0x0427033C  token=0x60005A2  Unity.Mathematics.float3 radians(Unity.Mathematics.float3 x)
  RVA=0x09C50FEC  token=0x60005A3  Unity.Mathematics.float4 radians(Unity.Mathematics.float4 x)
  RVA=0x03D7CB80  token=0x60005A4  System.Double radians(System.Double x)
  RVA=0x09C51034  token=0x60005A5  Unity.Mathematics.double2 radians(Unity.Mathematics.double2 x)
  RVA=0x09C5106C  token=0x60005A6  Unity.Mathematics.double3 radians(Unity.Mathematics.double3 x)
  RVA=0x09C510B8  token=0x60005A7  Unity.Mathematics.double4 radians(Unity.Mathematics.double4 x)
  RVA=0x03D792E0  token=0x60005A8  System.Single degrees(System.Single x)
  RVA=0x09C305CC  token=0x60005A9  Unity.Mathematics.float2 degrees(Unity.Mathematics.float2 x)
  RVA=0x04D2F384  token=0x60005AA  Unity.Mathematics.float3 degrees(Unity.Mathematics.float3 x)
  RVA=0x09C305DC  token=0x60005AB  Unity.Mathematics.float4 degrees(Unity.Mathematics.float4 x)
  RVA=0x03D792F0  token=0x60005AC  System.Double degrees(System.Double x)
  RVA=0x09C30614  token=0x60005AD  Unity.Mathematics.double2 degrees(Unity.Mathematics.double2 x)
  RVA=0x09C30538  token=0x60005AE  Unity.Mathematics.double3 degrees(Unity.Mathematics.double3 x)
  RVA=0x09C30584  token=0x60005AF  Unity.Mathematics.double4 degrees(Unity.Mathematics.double4 x)
  RVA=0x09C2FCB8  token=0x60005B0  System.Int32 cmin(Unity.Mathematics.int2 x)
  RVA=0x09C2FB90  token=0x60005B1  System.Int32 cmin(Unity.Mathematics.int3 x)
  RVA=0x09C2FC10  token=0x60005B2  System.Int32 cmin(Unity.Mathematics.int4 x)
  RVA=0x09C2FC4C  token=0x60005B3  System.UInt32 cmin(Unity.Mathematics.uint2 x)
  RVA=0x09C2FD04  token=0x60005B4  System.UInt32 cmin(Unity.Mathematics.uint3 x)
  RVA=0x09C2FBA4  token=0x60005B5  System.UInt32 cmin(Unity.Mathematics.uint4 x)
  RVA=0x09C2FC94  token=0x60005B6  System.Single cmin(Unity.Mathematics.float2 x)
  RVA=0x09C2FC60  token=0x60005B7  System.Single cmin(Unity.Mathematics.float3 x)
  RVA=0x04D2E958  token=0x60005B8  System.Single cmin(Unity.Mathematics.float4 x)
  RVA=0x09C2FC2C  token=0x60005B9  System.Double cmin(Unity.Mathematics.double2 x)
  RVA=0x09C2FCCC  token=0x60005BA  System.Double cmin(Unity.Mathematics.double3 x)
  RVA=0x09C2FBC0  token=0x60005BB  System.Double cmin(Unity.Mathematics.double4 x)
  RVA=0x09C2FB10  token=0x60005BC  System.Int32 cmax(Unity.Mathematics.int2 x)
  RVA=0x09C2FB44  token=0x60005BD  System.Int32 cmax(Unity.Mathematics.int3 x)
  RVA=0x09C2FA74  token=0x60005BE  System.Int32 cmax(Unity.Mathematics.int4 x)
  RVA=0x09C2FA3C  token=0x60005BF  System.UInt32 cmax(Unity.Mathematics.uint2 x)
  RVA=0x09C2FAFC  token=0x60005C0  System.UInt32 cmax(Unity.Mathematics.uint3 x)
  RVA=0x09C2FA90  token=0x60005C1  System.UInt32 cmax(Unity.Mathematics.uint4 x)
  RVA=0x09C2FA50  token=0x60005C2  System.Single cmax(Unity.Mathematics.float2 x)
  RVA=0x09C2FA08  token=0x60005C3  System.Single cmax(Unity.Mathematics.float3 x)
  RVA=0x04D2E7E8  token=0x60005C4  System.Single cmax(Unity.Mathematics.float4 x)
  RVA=0x09C2FB24  token=0x60005C5  System.Double cmax(Unity.Mathematics.double2 x)
  RVA=0x09C2FB58  token=0x60005C6  System.Double cmax(Unity.Mathematics.double3 x)
  RVA=0x09C2FAAC  token=0x60005C7  System.Double cmax(Unity.Mathematics.double4 x)
  RVA=0x03D79250  token=0x60005C8  System.Int32 csum(Unity.Mathematics.int2 x)
  RVA=0x03D792A0  token=0x60005C9  System.Int32 csum(Unity.Mathematics.int3 x)
  RVA=0x03D55680  token=0x60005CA  System.Int32 csum(Unity.Mathematics.int4 x)
  RVA=0x03D79250  token=0x60005CB  System.UInt32 csum(Unity.Mathematics.uint2 x)
  RVA=0x03D792A0  token=0x60005CC  System.UInt32 csum(Unity.Mathematics.uint3 x)
  RVA=0x03D55680  token=0x60005CD  System.UInt32 csum(Unity.Mathematics.uint4 x)
  RVA=0x03D792B0  token=0x60005CE  System.Single csum(Unity.Mathematics.float2 x)
  RVA=0x03D792D0  token=0x60005CF  System.Single csum(Unity.Mathematics.float3 x)
  RVA=0x03D79230  token=0x60005D0  System.Single csum(Unity.Mathematics.float4 x)
  RVA=0x03D79270  token=0x60005D1  System.Double csum(Unity.Mathematics.double2 x)
  RVA=0x03D79260  token=0x60005D2  System.Double csum(Unity.Mathematics.double3 x)
  RVA=0x03D79280  token=0x60005D3  System.Double csum(Unity.Mathematics.double4 x)
  RVA=0x03D51490  token=0x60005D4  System.Single square(System.Single x)
  RVA=0x09C55C4C  token=0x60005D5  Unity.Mathematics.float2 square(Unity.Mathematics.float2 x)
  RVA=0x04D5AFFC  token=0x60005D6  Unity.Mathematics.float3 square(Unity.Mathematics.float3 x)
  RVA=0x09C55B7C  token=0x60005D7  Unity.Mathematics.float4 square(Unity.Mathematics.float4 x)
  RVA=0x03D7B840  token=0x60005D8  System.Double square(System.Double x)
  RVA=0x09C55B44  token=0x60005D9  Unity.Mathematics.double2 square(Unity.Mathematics.double2 x)
  RVA=0x09C55BBC  token=0x60005DA  Unity.Mathematics.double3 square(Unity.Mathematics.double3 x)
  RVA=0x09C55AF4  token=0x60005DB  Unity.Mathematics.double4 square(Unity.Mathematics.double4 x)
  RVA=0x03D7D410  token=0x60005DC  System.Int32 square(System.Int32 x)
  RVA=0x09C55BB4  token=0x60005DD  Unity.Mathematics.int2 square(Unity.Mathematics.int2 x)
  RVA=0x04D5B04C  token=0x60005DE  Unity.Mathematics.int3 square(Unity.Mathematics.int3 x)
  RVA=0x09C55C14  token=0x60005DF  Unity.Mathematics.int4 square(Unity.Mathematics.int4 x)
  RVA=0x03D7D410  token=0x60005E0  System.UInt32 square(System.UInt32 x)
  RVA=0x09C55BB4  token=0x60005E1  Unity.Mathematics.uint2 square(Unity.Mathematics.uint2 x)
  RVA=0x04D5B04C  token=0x60005E2  Unity.Mathematics.uint3 square(Unity.Mathematics.uint3 x)
  RVA=0x09C55C14  token=0x60005E3  Unity.Mathematics.uint4 square(Unity.Mathematics.uint4 x)
  RVA=0x09C2C4B4  token=0x60005E4  System.Int32 compress(System.Int32* output, System.Int32 index, Unity.Mathematics.int4 val, Unity.Mathematics.bool4 mask)
  RVA=0x09C2FD18  token=0x60005E5  System.Int32 compress(System.UInt32* output, System.Int32 index, Unity.Mathematics.uint4 val, Unity.Mathematics.bool4 mask)
  RVA=0x09C2FD18  token=0x60005E6  System.Int32 compress(System.Single* output, System.Int32 index, Unity.Mathematics.float4 val, Unity.Mathematics.bool4 mask)
  RVA=0x04D30EF4  token=0x60005E7  System.Single f16tof32(System.UInt32 x)
  RVA=0x09C323D0  token=0x60005E8  Unity.Mathematics.float2 f16tof32(Unity.Mathematics.uint2 x)
  RVA=0x09C3210C  token=0x60005E9  Unity.Mathematics.float3 f16tof32(Unity.Mathematics.uint3 x)
  RVA=0x09C32524  token=0x60005EA  Unity.Mathematics.float4 f16tof32(Unity.Mathematics.uint4 x)
  RVA=0x09C32BD4  token=0x60005EB  System.UInt32 f32tof16(System.Single x)
  RVA=0x09C32750  token=0x60005EC  Unity.Mathematics.uint2 f32tof16(Unity.Mathematics.float2 x)
  RVA=0x09C328DC  token=0x60005ED  Unity.Mathematics.uint3 f32tof16(Unity.Mathematics.float3 x)
  RVA=0x09C32C30  token=0x60005EE  Unity.Mathematics.uint4 f32tof16(Unity.Mathematics.float4 x)
  RVA=0x09C501FC  token=0x60005EF  System.Void orthonormal_basis(Unity.Mathematics.float3 normal, Unity.Mathematics.float3& basis1, Unity.Mathematics.float3& basis2)
  RVA=0x09C502A0  token=0x60005F0  System.Void orthonormal_basis(Unity.Mathematics.double3 normal, Unity.Mathematics.double3& basis1, Unity.Mathematics.double3& basis2)
  RVA=0x03D78DB0  token=0x60005F1  System.Single chgsign(System.Single x, System.Single y)
  RVA=0x09C2F3FC  token=0x60005F2  Unity.Mathematics.float2 chgsign(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y)
  RVA=0x04D2E18C  token=0x60005F3  Unity.Mathematics.float3 chgsign(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  RVA=0x09C2F440  token=0x60005F4  Unity.Mathematics.float4 chgsign(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y)
  RVA=0x03D6EF00  token=0x60005F5  System.UInt32 read32_little_endian(System.Void* pBuffer)
  RVA=0x09C389B8  token=0x60005F6  System.UInt32 hash_with_unaligned_loads(System.Void* pBuffer, System.Int32 numBytes, System.UInt32 seed)
  RVA=0x09C38BD4  token=0x60005F7  System.UInt32 hash_without_unaligned_loads(System.Void* pBuffer, System.Int32 numBytes, System.UInt32 seed)
  RVA=0x09C37850  token=0x60005F8  System.UInt32 hash(System.Void* pBuffer, System.Int32 numBytes, System.UInt32 seed)
  RVA=0x03D7D420  token=0x60005F9  Unity.Mathematics.float3 up()
  RVA=0x03D7A500  token=0x60005FA  Unity.Mathematics.float3 down()
  RVA=0x03D7B280  token=0x60005FB  Unity.Mathematics.float3 forward()
  RVA=0x03D787B0  token=0x60005FC  Unity.Mathematics.float3 back()
  RVA=0x03D7B7D0  token=0x60005FD  Unity.Mathematics.float3 left()
  RVA=0x03D7CC30  token=0x60005FE  Unity.Mathematics.float3 right()
  RVA=0x09C2C920  token=0x60005FF  Unity.Mathematics.float3 EulerXYZ(Unity.Mathematics.quaternion q)
  RVA=0x09C2CCA4  token=0x6000600  Unity.Mathematics.float3 EulerXZY(Unity.Mathematics.quaternion q)
  RVA=0x09C2CFFC  token=0x6000601  Unity.Mathematics.float3 EulerYXZ(Unity.Mathematics.quaternion q)
  RVA=0x09C2D350  token=0x6000602  Unity.Mathematics.float3 EulerYZX(Unity.Mathematics.quaternion q)
  RVA=0x09C2D68C  token=0x6000603  Unity.Mathematics.float3 EulerZXY(Unity.Mathematics.quaternion q)
  RVA=0x09C2D9C4  token=0x6000604  Unity.Mathematics.float3 EulerZYX(Unity.Mathematics.quaternion q)
  RVA=0x09C2DD1C  token=0x6000605  Unity.Mathematics.float3 Euler(Unity.Mathematics.quaternion q, Unity.Mathematics.math.RotationOrder order)
  RVA=0x09C41318  token=0x6000606  Unity.Mathematics.float3x3 mulScale(Unity.Mathematics.float3x3 m, Unity.Mathematics.float3 s)
  RVA=0x09C53428  token=0x6000607  Unity.Mathematics.float3x3 scaleMul(Unity.Mathematics.float3 s, Unity.Mathematics.float3x3 m)
  RVA=0x09C58884  token=0x6000608  Unity.Mathematics.float4 unpacklo(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b)
  RVA=0x09C588D0  token=0x6000609  Unity.Mathematics.double4 unpacklo(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b)
  RVA=0x09C2C654  token=0x600060A  Unity.Mathematics.float4 unpackhi(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b)
  RVA=0x09C58818  token=0x600060B  Unity.Mathematics.double4 unpackhi(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b)
  RVA=0x09C41260  token=0x600060C  Unity.Mathematics.float4 movelh(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b)
  RVA=0x09C412AC  token=0x600060D  Unity.Mathematics.double4 movelh(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b)
  RVA=0x09C411A8  token=0x600060E  Unity.Mathematics.float4 movehl(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b)
  RVA=0x09C411F4  token=0x600060F  Unity.Mathematics.double4 movehl(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b)
  RVA=0x03D7B260  token=0x6000610  System.UInt32 fold_to_uint(System.Double x)
  RVA=0x03D7B120  token=0x6000611  Unity.Mathematics.uint2 fold_to_uint(Unity.Mathematics.double2 x)
  RVA=0x03D7B1F0  token=0x6000612  Unity.Mathematics.uint3 fold_to_uint(Unity.Mathematics.double3 x)
  RVA=0x03D7B160  token=0x6000613  Unity.Mathematics.uint4 fold_to_uint(Unity.Mathematics.double4 x)
  RVA=0x09C345B8  token=0x6000614  Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.float4x4 f4x4)
  RVA=0x09C3462C  token=0x6000615  Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.quaternion rotation)
  RVA=0x09C35244  token=0x6000616  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.float3x3 rotation, Unity.Mathematics.float3 translation)
  RVA=0x09C35300  token=0x6000617  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 translation)
  RVA=0x09C3500C  token=0x6000618  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.RigidTransform transform)
  RVA=0x09C50374  token=0x6000619  Unity.Mathematics.float3x3 orthonormalize(Unity.Mathematics.float3x3 i)
  RVA=0x09C50CF4  token=0x600061A  Unity.Mathematics.float3x3 pseudoinverse(Unity.Mathematics.float3x3 m)
  RVA=0x03D79D70  token=0x600061B  System.Single mul(System.Single a, System.Single b)
  RVA=0x03D542E0  token=0x600061C  System.Single mul(Unity.Mathematics.float2 a, Unity.Mathematics.float2 b)
  RVA=0x03D7C0C0  token=0x600061D  Unity.Mathematics.float2 mul(Unity.Mathematics.float2 a, Unity.Mathematics.float2x2 b)
  RVA=0x03D7C7C0  token=0x600061E  Unity.Mathematics.float3 mul(Unity.Mathematics.float2 a, Unity.Mathematics.float2x3 b)
  RVA=0x03D7C860  token=0x600061F  Unity.Mathematics.float4 mul(Unity.Mathematics.float2 a, Unity.Mathematics.float2x4 b)
  RVA=0x03D54460  token=0x6000620  System.Single mul(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b)
  RVA=0x03D7C250  token=0x6000621  Unity.Mathematics.float2 mul(Unity.Mathematics.float3 a, Unity.Mathematics.float3x2 b)
  RVA=0x03D7C1C0  token=0x6000622  Unity.Mathematics.float3 mul(Unity.Mathematics.float3 a, Unity.Mathematics.float3x3 b)
  RVA=0x03D7C5F0  token=0x6000623  Unity.Mathematics.float4 mul(Unity.Mathematics.float3 a, Unity.Mathematics.float3x4 b)
  RVA=0x028B5400  token=0x6000624  System.Single mul(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b)
  RVA=0x03D7C750  token=0x6000625  Unity.Mathematics.float2 mul(Unity.Mathematics.float4 a, Unity.Mathematics.float4x2 b)
  RVA=0x03D7BD20  token=0x6000626  Unity.Mathematics.float3 mul(Unity.Mathematics.float4 a, Unity.Mathematics.float4x3 b)
  RVA=0x03D7C970  token=0x6000627  Unity.Mathematics.float4 mul(Unity.Mathematics.float4 a, Unity.Mathematics.float4x4 b)
  RVA=0x09C429C4  token=0x6000628  Unity.Mathematics.float2 mul(Unity.Mathematics.float2x2 a, Unity.Mathematics.float2 b)
  RVA=0x09C4BECC  token=0x6000629  Unity.Mathematics.float2x2 mul(Unity.Mathematics.float2x2 a, Unity.Mathematics.float2x2 b)
  RVA=0x09C4CCD8  token=0x600062A  Unity.Mathematics.float2x3 mul(Unity.Mathematics.float2x2 a, Unity.Mathematics.float2x3 b)
  RVA=0x09C413E0  token=0x600062B  Unity.Mathematics.float2x4 mul(Unity.Mathematics.float2x2 a, Unity.Mathematics.float2x4 b)
  RVA=0x09C43580  token=0x600062C  Unity.Mathematics.float2 mul(Unity.Mathematics.float2x3 a, Unity.Mathematics.float3 b)
  RVA=0x09C43C1C  token=0x600062D  Unity.Mathematics.float2x2 mul(Unity.Mathematics.float2x3 a, Unity.Mathematics.float3x2 b)
  RVA=0x09C4A1BC  token=0x600062E  Unity.Mathematics.float2x3 mul(Unity.Mathematics.float2x3 a, Unity.Mathematics.float3x3 b)
  RVA=0x09C425A4  token=0x600062F  Unity.Mathematics.float2x4 mul(Unity.Mathematics.float2x3 a, Unity.Mathematics.float3x4 b)
  RVA=0x09C4B704  token=0x6000630  Unity.Mathematics.float2 mul(Unity.Mathematics.float2x4 a, Unity.Mathematics.float4 b)
  RVA=0x09C41564  token=0x6000631  Unity.Mathematics.float2x2 mul(Unity.Mathematics.float2x4 a, Unity.Mathematics.float4x2 b)
  RVA=0x09C49E88  token=0x6000632  Unity.Mathematics.float2x3 mul(Unity.Mathematics.float2x4 a, Unity.Mathematics.float4x3 b)
  RVA=0x09C4A6BC  token=0x6000633  Unity.Mathematics.float2x4 mul(Unity.Mathematics.float2x4 a, Unity.Mathematics.float4x4 b)
  RVA=0x09C44EA4  token=0x6000634  Unity.Mathematics.float3 mul(Unity.Mathematics.float3x2 a, Unity.Mathematics.float2 b)
  RVA=0x09C4BB2C  token=0x6000635  Unity.Mathematics.float3x2 mul(Unity.Mathematics.float3x2 a, Unity.Mathematics.float2x2 b)
  RVA=0x09C4EE48  token=0x6000636  Unity.Mathematics.float3x3 mul(Unity.Mathematics.float3x2 a, Unity.Mathematics.float2x3 b)
  RVA=0x09C416FC  token=0x6000637  Unity.Mathematics.float3x4 mul(Unity.Mathematics.float3x2 a, Unity.Mathematics.float2x4 b)
  RVA=0x09C4595C  token=0x6000638  Unity.Mathematics.float3 mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.float3 b)
  RVA=0x09C4D7FC  token=0x6000639  Unity.Mathematics.float3x2 mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.float3x2 b)
  RVA=0x09C41D38  token=0x600063A  Unity.Mathematics.float3x3 mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.float3x3 b)
  RVA=0x09C4870C  token=0x600063B  Unity.Mathematics.float3x4 mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.float3x4 b)
  RVA=0x09C47EBC  token=0x600063C  Unity.Mathematics.float3 mul(Unity.Mathematics.float3x4 a, Unity.Mathematics.float4 b)
  RVA=0x09C4EA2C  token=0x600063D  Unity.Mathematics.float3x2 mul(Unity.Mathematics.float3x4 a, Unity.Mathematics.float4x2 b)
  RVA=0x09C47800  token=0x600063E  Unity.Mathematics.float3x3 mul(Unity.Mathematics.float3x4 a, Unity.Mathematics.float4x3 b)
  RVA=0x09C42C28  token=0x600063F  Unity.Mathematics.float3x4 mul(Unity.Mathematics.float3x4 a, Unity.Mathematics.float4x4 b)
  RVA=0x09C494D0  token=0x6000640  Unity.Mathematics.float4 mul(Unity.Mathematics.float4x2 a, Unity.Mathematics.float2 b)
  RVA=0x09C4A0D8  token=0x6000641  Unity.Mathematics.float4x2 mul(Unity.Mathematics.float4x2 a, Unity.Mathematics.float2x2 b)
  RVA=0x09C46C88  token=0x6000642  Unity.Mathematics.float4x3 mul(Unity.Mathematics.float4x2 a, Unity.Mathematics.float2x3 b)
  RVA=0x09C48C34  token=0x6000643  Unity.Mathematics.float4x4 mul(Unity.Mathematics.float4x2 a, Unity.Mathematics.float2x4 b)
  RVA=0x09C4C380  token=0x6000644  Unity.Mathematics.float4 mul(Unity.Mathematics.float4x3 a, Unity.Mathematics.float3 b)
  RVA=0x09C4C4EC  token=0x6000645  Unity.Mathematics.float4x2 mul(Unity.Mathematics.float4x3 a, Unity.Mathematics.float3x2 b)
  RVA=0x09C4B1EC  token=0x6000646  Unity.Mathematics.float4x3 mul(Unity.Mathematics.float4x3 a, Unity.Mathematics.float3x3 b)
  RVA=0x09C4C9B8  token=0x6000647  Unity.Mathematics.float4x4 mul(Unity.Mathematics.float4x3 a, Unity.Mathematics.float3x4 b)
  RVA=0x09C4196C  token=0x6000648  Unity.Mathematics.float4 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4 b)
  RVA=0x09C44414  token=0x6000649  Unity.Mathematics.float4x2 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4x2 b)
  RVA=0x09C4B41C  token=0x600064A  Unity.Mathematics.float4x3 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4x3 b)
  RVA=0x09C4F024  token=0x600064B  Unity.Mathematics.float4x4 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4x4 b)
  RVA=0x03D79D40  token=0x600064C  System.Double mul(System.Double a, System.Double b)
  RVA=0x03D79DB0  token=0x600064D  System.Double mul(Unity.Mathematics.double2 a, Unity.Mathematics.double2 b)
  RVA=0x03D7C820  token=0x600064E  Unity.Mathematics.double2 mul(Unity.Mathematics.double2 a, Unity.Mathematics.double2x2 b)
  RVA=0x03D7C2B0  token=0x600064F  Unity.Mathematics.double3 mul(Unity.Mathematics.double2 a, Unity.Mathematics.double2x3 b)
  RVA=0x03D7C380  token=0x6000650  Unity.Mathematics.double4 mul(Unity.Mathematics.double2 a, Unity.Mathematics.double2x4 b)
  RVA=0x03D79D80  token=0x6000651  System.Double mul(Unity.Mathematics.double3 a, Unity.Mathematics.double3 b)
  RVA=0x03D7C320  token=0x6000652  Unity.Mathematics.double2 mul(Unity.Mathematics.double3 a, Unity.Mathematics.double3x2 b)
  RVA=0x03D7C400  token=0x6000653  Unity.Mathematics.double3 mul(Unity.Mathematics.double3 a, Unity.Mathematics.double3x3 b)
  RVA=0x03D7C100  token=0x6000654  Unity.Mathematics.double4 mul(Unity.Mathematics.double3 a, Unity.Mathematics.double3x4 b)
  RVA=0x03D79CD0  token=0x6000655  System.Double mul(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b)
  RVA=0x03D7C490  token=0x6000656  Unity.Mathematics.double2 mul(Unity.Mathematics.double4 a, Unity.Mathematics.double4x2 b)
  RVA=0x03D7BE80  token=0x6000657  Unity.Mathematics.double3 mul(Unity.Mathematics.double4 a, Unity.Mathematics.double4x3 b)
  RVA=0x03D7CA80  token=0x6000658  Unity.Mathematics.double4 mul(Unity.Mathematics.double4 a, Unity.Mathematics.double4x4 b)
  RVA=0x09C49660  token=0x6000659  Unity.Mathematics.double2 mul(Unity.Mathematics.double2x2 a, Unity.Mathematics.double2 b)
  RVA=0x09C48004  token=0x600065A  Unity.Mathematics.double2x2 mul(Unity.Mathematics.double2x2 a, Unity.Mathematics.double2x2 b)
  RVA=0x09C4A378  token=0x600065B  Unity.Mathematics.double2x3 mul(Unity.Mathematics.double2x2 a, Unity.Mathematics.double2x3 b)
  RVA=0x09C49A84  token=0x600065C  Unity.Mathematics.double2x4 mul(Unity.Mathematics.double2x2 a, Unity.Mathematics.double2x4 b)
  RVA=0x09C41A64  token=0x600065D  Unity.Mathematics.double2 mul(Unity.Mathematics.double2x3 a, Unity.Mathematics.double3 b)
  RVA=0x09C48AD0  token=0x600065E  Unity.Mathematics.double2x2 mul(Unity.Mathematics.double2x3 a, Unity.Mathematics.double3x2 b)
  RVA=0x09C4D214  token=0x600065F  Unity.Mathematics.double2x3 mul(Unity.Mathematics.double2x3 a, Unity.Mathematics.double3x3 b)
  RVA=0x09C4AC48  token=0x6000660  Unity.Mathematics.double2x4 mul(Unity.Mathematics.double2x3 a, Unity.Mathematics.double3x4 b)
  RVA=0x09C4E18C  token=0x6000661  Unity.Mathematics.double2 mul(Unity.Mathematics.double2x4 a, Unity.Mathematics.double4 b)
  RVA=0x09C433A0  token=0x6000662  Unity.Mathematics.double2x2 mul(Unity.Mathematics.double2x4 a, Unity.Mathematics.double4x2 b)
  RVA=0x09C4D514  token=0x6000663  Unity.Mathematics.double2x3 mul(Unity.Mathematics.double2x4 a, Unity.Mathematics.double4x3 b)
  RVA=0x09C437EC  token=0x6000664  Unity.Mathematics.double2x4 mul(Unity.Mathematics.double2x4 a, Unity.Mathematics.double4x4 b)
  RVA=0x09C48488  token=0x6000665  Unity.Mathematics.double3 mul(Unity.Mathematics.double3x2 a, Unity.Mathematics.double2 b)
  RVA=0x09C4ECD0  token=0x6000666  Unity.Mathematics.double3x2 mul(Unity.Mathematics.double3x2 a, Unity.Mathematics.double2x2 b)
  RVA=0x09C44AAC  token=0x6000667  Unity.Mathematics.double3x3 mul(Unity.Mathematics.double3x2 a, Unity.Mathematics.double2x3 b)
  RVA=0x09C4F540  token=0x6000668  Unity.Mathematics.double3x4 mul(Unity.Mathematics.double3x2 a, Unity.Mathematics.double2x4 b)
  RVA=0x09C4C26C  token=0x6000669  Unity.Mathematics.double3 mul(Unity.Mathematics.double3x3 a, Unity.Mathematics.double3 b)
  RVA=0x09C44F40  token=0x600066A  Unity.Mathematics.double3x2 mul(Unity.Mathematics.double3x3 a, Unity.Mathematics.double3x2 b)
  RVA=0x09C480E0  token=0x600066B  Unity.Mathematics.double3x3 mul(Unity.Mathematics.double3x3 a, Unity.Mathematics.double3x3 b)
  RVA=0x09C445F8  token=0x600066C  Unity.Mathematics.double3x4 mul(Unity.Mathematics.double3x3 a, Unity.Mathematics.double3x4 b)
  RVA=0x09C4649C  token=0x600066D  Unity.Mathematics.double3 mul(Unity.Mathematics.double3x4 a, Unity.Mathematics.double4 b)
  RVA=0x09C48E1C  token=0x600066E  Unity.Mathematics.double3x2 mul(Unity.Mathematics.double3x4 a, Unity.Mathematics.double4x2 b)
  RVA=0x09C4DB64  token=0x600066F  Unity.Mathematics.double3x3 mul(Unity.Mathematics.double3x4 a, Unity.Mathematics.double4x3 b)
  RVA=0x09C4E3E0  token=0x6000670  Unity.Mathematics.double3x4 mul(Unity.Mathematics.double3x4 a, Unity.Mathematics.double4x4 b)
  RVA=0x09C4ABA0  token=0x6000671  Unity.Mathematics.double4 mul(Unity.Mathematics.double4x2 a, Unity.Mathematics.double2 b)
  RVA=0x09C4D9F8  token=0x6000672  Unity.Mathematics.double4x2 mul(Unity.Mathematics.double4x2 a, Unity.Mathematics.double2x2 b)
  RVA=0x09C4BC78  token=0x6000673  Unity.Mathematics.double4x3 mul(Unity.Mathematics.double4x2 a, Unity.Mathematics.double2x3 b)
  RVA=0x09C4F868  token=0x6000674  Unity.Mathematics.double4x4 mul(Unity.Mathematics.double4x2 a, Unity.Mathematics.double2x4 b)
  RVA=0x09C47BD8  token=0x6000675  Unity.Mathematics.double4 mul(Unity.Mathematics.double4x3 a, Unity.Mathematics.double3 b)
  RVA=0x09C49C6C  token=0x6000676  Unity.Mathematics.double4x2 mul(Unity.Mathematics.double4x3 a, Unity.Mathematics.double3x2 b)
  RVA=0x09C4B7B0  token=0x6000677  Unity.Mathematics.double4x3 mul(Unity.Mathematics.double4x3 a, Unity.Mathematics.double3x3 b)
  RVA=0x09C45440  token=0x6000678  Unity.Mathematics.double4x4 mul(Unity.Mathematics.double4x3 a, Unity.Mathematics.double3x4 b)
  RVA=0x09C427EC  token=0x6000679  Unity.Mathematics.double4 mul(Unity.Mathematics.double4x4 a, Unity.Mathematics.double4 b)
  RVA=0x09C497B4  token=0x600067A  Unity.Mathematics.double4x2 mul(Unity.Mathematics.double4x4 a, Unity.Mathematics.double4x2 b)
  RVA=0x09C46610  token=0x600067B  Unity.Mathematics.double4x3 mul(Unity.Mathematics.double4x4 a, Unity.Mathematics.double4x3 b)
  RVA=0x09C45D90  token=0x600067C  Unity.Mathematics.double4x4 mul(Unity.Mathematics.double4x4 a, Unity.Mathematics.double4x4 b)
  RVA=0x03D79CC0  token=0x600067D  System.Int32 mul(System.Int32 a, System.Int32 b)
  RVA=0x03D79D50  token=0x600067E  System.Int32 mul(Unity.Mathematics.int2 a, Unity.Mathematics.int2 b)
  RVA=0x03D7C6C0  token=0x600067F  Unity.Mathematics.int2 mul(Unity.Mathematics.int2 a, Unity.Mathematics.int2x2 b)
  RVA=0x03D7C060  token=0x6000680  Unity.Mathematics.int3 mul(Unity.Mathematics.int2 a, Unity.Mathematics.int2x3 b)
  RVA=0x03D7C510  token=0x6000681  Unity.Mathematics.int4 mul(Unity.Mathematics.int2 a, Unity.Mathematics.int2x4 b)
  RVA=0x03D4E570  token=0x6000682  System.Int32 mul(Unity.Mathematics.int3 a, Unity.Mathematics.int3 b)
  RVA=0x03D7C700  token=0x6000683  Unity.Mathematics.int2 mul(Unity.Mathematics.int3 a, Unity.Mathematics.int3x2 b)
  RVA=0x03D7BF40  token=0x6000684  Unity.Mathematics.int3 mul(Unity.Mathematics.int3 a, Unity.Mathematics.int3x3 b)
  RVA=0x03D7BFC0  token=0x6000685  Unity.Mathematics.int4 mul(Unity.Mathematics.int3 a, Unity.Mathematics.int3x4 b)
  RVA=0x03D79D10  token=0x6000686  System.Int32 mul(Unity.Mathematics.int4 a, Unity.Mathematics.int4 b)
  RVA=0x03D7C590  token=0x6000687  Unity.Mathematics.int2 mul(Unity.Mathematics.int4 a, Unity.Mathematics.int4x2 b)
  RVA=0x03D7BDE0  token=0x6000688  Unity.Mathematics.int3 mul(Unity.Mathematics.int4 a, Unity.Mathematics.int4x3 b)
  RVA=0x03D7BC60  token=0x6000689  Unity.Mathematics.int4 mul(Unity.Mathematics.int4 a, Unity.Mathematics.int4x4 b)
  RVA=0x09C45A4C  token=0x600068A  Unity.Mathematics.int2 mul(Unity.Mathematics.int2x2 a, Unity.Mathematics.int2 b)
  RVA=0x09C4C438  token=0x600068B  Unity.Mathematics.int2x2 mul(Unity.Mathematics.int2x2 a, Unity.Mathematics.int2x2 b)
  RVA=0x09C46394  token=0x600068C  Unity.Mathematics.int2x3 mul(Unity.Mathematics.int2x2 a, Unity.Mathematics.int2x3 b)
  RVA=0x09C42014  token=0x600068D  Unity.Mathematics.int2x4 mul(Unity.Mathematics.int2x2 a, Unity.Mathematics.int2x4 b)
  RVA=0x09C47CDC  token=0x600068E  Unity.Mathematics.int2 mul(Unity.Mathematics.int2x3 a, Unity.Mathematics.int3 b)
  RVA=0x09C49550  token=0x600068F  Unity.Mathematics.int2x2 mul(Unity.Mathematics.int2x3 a, Unity.Mathematics.int3x2 b)
  RVA=0x09C45A94  token=0x6000690  Unity.Mathematics.int2x3 mul(Unity.Mathematics.int2x3 a, Unity.Mathematics.int3x3 b)
  RVA=0x09C431B4  token=0x6000691  Unity.Mathematics.int2x4 mul(Unity.Mathematics.int2x3 a, Unity.Mathematics.int3x4 b)
  RVA=0x09C45178  token=0x6000692  Unity.Mathematics.int2 mul(Unity.Mathematics.int2x4 a, Unity.Mathematics.int4 b)
  RVA=0x09C45C2C  token=0x6000693  Unity.Mathematics.int2x2 mul(Unity.Mathematics.int2x4 a, Unity.Mathematics.int4x2 b)
  RVA=0x09C42A14  token=0x6000694  Unity.Mathematics.int2x3 mul(Unity.Mathematics.int2x4 a, Unity.Mathematics.int4x3 b)
  RVA=0x09C4AF68  token=0x6000695  Unity.Mathematics.int2x4 mul(Unity.Mathematics.int2x4 a, Unity.Mathematics.int4x4 b)
  RVA=0x09C458C4  token=0x6000696  Unity.Mathematics.int3 mul(Unity.Mathematics.int3x2 a, Unity.Mathematics.int2 b)
  RVA=0x09C4E044  token=0x6000697  Unity.Mathematics.int3x2 mul(Unity.Mathematics.int3x2 a, Unity.Mathematics.int2x2 b)
  RVA=0x09C46AB4  token=0x6000698  Unity.Mathematics.int3x3 mul(Unity.Mathematics.int3x2 a, Unity.Mathematics.int2x3 b)
  RVA=0x09C4759C  token=0x6000699  Unity.Mathematics.int3x4 mul(Unity.Mathematics.int3x2 a, Unity.Mathematics.int2x4 b)
  RVA=0x09C474B0  token=0x600069A  Unity.Mathematics.int3 mul(Unity.Mathematics.int3x3 a, Unity.Mathematics.int3 b)
  RVA=0x09C435FC  token=0x600069B  Unity.Mathematics.int3x2 mul(Unity.Mathematics.int3x3 a, Unity.Mathematics.int3x2 b)
  RVA=0x09C4BFA0  token=0x600069C  Unity.Mathematics.int3x3 mul(Unity.Mathematics.int3x3 a, Unity.Mathematics.int3x3 b)
  RVA=0x09C47104  token=0x600069D  Unity.Mathematics.int3x4 mul(Unity.Mathematics.int3x3 a, Unity.Mathematics.int3x4 b)
  RVA=0x09C45220  token=0x600069E  Unity.Mathematics.int3 mul(Unity.Mathematics.int3x4 a, Unity.Mathematics.int4 b)
  RVA=0x09C42180  token=0x600069F  Unity.Mathematics.int3x2 mul(Unity.Mathematics.int3x4 a, Unity.Mathematics.int4x2 b)
  RVA=0x09C49110  token=0x60006A0  Unity.Mathematics.int3x3 mul(Unity.Mathematics.int3x4 a, Unity.Mathematics.int4x3 b)
  RVA=0x09C43EA8  token=0x60006A1  Unity.Mathematics.int3x4 mul(Unity.Mathematics.int3x4 a, Unity.Mathematics.int4x4 b)
  RVA=0x09C4294C  token=0x60006A2  Unity.Mathematics.int4 mul(Unity.Mathematics.int4x2 a, Unity.Mathematics.int2 b)
  RVA=0x09C45360  token=0x60006A3  Unity.Mathematics.int4x2 mul(Unity.Mathematics.int4x2 a, Unity.Mathematics.int2x2 b)
  RVA=0x09C47D58  token=0x60006A4  Unity.Mathematics.int4x3 mul(Unity.Mathematics.int4x2 a, Unity.Mathematics.int2x3 b)
  RVA=0x09C4A4EC  token=0x60006A5  Unity.Mathematics.int4x4 mul(Unity.Mathematics.int4x2 a, Unity.Mathematics.int2x4 b)
  RVA=0x09C424F0  token=0x60006A6  Unity.Mathematics.int4 mul(Unity.Mathematics.int4x3 a, Unity.Mathematics.int3 b)
  RVA=0x09C43D50  token=0x60006A7  Unity.Mathematics.int4x2 mul(Unity.Mathematics.int4x3 a, Unity.Mathematics.int3x2 b)
  RVA=0x09C41B1C  token=0x60006A8  Unity.Mathematics.int4x3 mul(Unity.Mathematics.int4x3 a, Unity.Mathematics.int3x3 b)
  RVA=0x09C46DFC  token=0x60006A9  Unity.Mathematics.int4x4 mul(Unity.Mathematics.int4x3 a, Unity.Mathematics.int3x4 b)
  RVA=0x09C4AAB0  token=0x60006AA  Unity.Mathematics.int4 mul(Unity.Mathematics.int4x4 a, Unity.Mathematics.int4 b)
  RVA=0x09C4853C  token=0x60006AB  Unity.Mathematics.int4x2 mul(Unity.Mathematics.int4x4 a, Unity.Mathematics.int4x2 b)
  RVA=0x09C4C654  token=0x60006AC  Unity.Mathematics.int4x3 mul(Unity.Mathematics.int4x4 a, Unity.Mathematics.int4x3 b)
  RVA=0x09C4CE04  token=0x60006AD  Unity.Mathematics.int4x4 mul(Unity.Mathematics.int4x4 a, Unity.Mathematics.int4x4 b)
  RVA=0x03D79CC0  token=0x60006AE  System.UInt32 mul(System.UInt32 a, System.UInt32 b)
  RVA=0x03D79D50  token=0x60006AF  System.UInt32 mul(Unity.Mathematics.uint2 a, Unity.Mathematics.uint2 b)
  RVA=0x03D7C6C0  token=0x60006B0  Unity.Mathematics.uint2 mul(Unity.Mathematics.uint2 a, Unity.Mathematics.uint2x2 b)
  RVA=0x03D7C060  token=0x60006B1  Unity.Mathematics.uint3 mul(Unity.Mathematics.uint2 a, Unity.Mathematics.uint2x3 b)
  RVA=0x03D7C8F0  token=0x60006B2  Unity.Mathematics.uint4 mul(Unity.Mathematics.uint2 a, Unity.Mathematics.uint2x4 b)
  RVA=0x03D4E570  token=0x60006B3  System.UInt32 mul(Unity.Mathematics.uint3 a, Unity.Mathematics.uint3 b)
  RVA=0x03D7C700  token=0x60006B4  Unity.Mathematics.uint2 mul(Unity.Mathematics.uint3 a, Unity.Mathematics.uint3x2 b)
  RVA=0x03D7BF40  token=0x60006B5  Unity.Mathematics.uint3 mul(Unity.Mathematics.uint3 a, Unity.Mathematics.uint3x3 b)
  RVA=0x03D7BFC0  token=0x60006B6  Unity.Mathematics.uint4 mul(Unity.Mathematics.uint3 a, Unity.Mathematics.uint3x4 b)
  RVA=0x03D79D10  token=0x60006B7  System.UInt32 mul(Unity.Mathematics.uint4 a, Unity.Mathematics.uint4 b)
  RVA=0x03D7C590  token=0x60006B8  Unity.Mathematics.uint2 mul(Unity.Mathematics.uint4 a, Unity.Mathematics.uint4x2 b)
  RVA=0x03D7BDE0  token=0x60006B9  Unity.Mathematics.uint3 mul(Unity.Mathematics.uint4 a, Unity.Mathematics.uint4x3 b)
  RVA=0x03D7BC60  token=0x60006BA  Unity.Mathematics.uint4 mul(Unity.Mathematics.uint4 a, Unity.Mathematics.uint4x4 b)
  RVA=0x09C45A4C  token=0x60006BB  Unity.Mathematics.uint2 mul(Unity.Mathematics.uint2x2 a, Unity.Mathematics.uint2 b)
  RVA=0x09C4C438  token=0x60006BC  Unity.Mathematics.uint2x2 mul(Unity.Mathematics.uint2x2 a, Unity.Mathematics.uint2x2 b)
  RVA=0x09C46394  token=0x60006BD  Unity.Mathematics.uint2x3 mul(Unity.Mathematics.uint2x2 a, Unity.Mathematics.uint2x3 b)
  RVA=0x09C42014  token=0x60006BE  Unity.Mathematics.uint2x4 mul(Unity.Mathematics.uint2x2 a, Unity.Mathematics.uint2x4 b)
  RVA=0x09C47CDC  token=0x60006BF  Unity.Mathematics.uint2 mul(Unity.Mathematics.uint2x3 a, Unity.Mathematics.uint3 b)
  RVA=0x09C49550  token=0x60006C0  Unity.Mathematics.uint2x2 mul(Unity.Mathematics.uint2x3 a, Unity.Mathematics.uint3x2 b)
  RVA=0x09C45A94  token=0x60006C1  Unity.Mathematics.uint2x3 mul(Unity.Mathematics.uint2x3 a, Unity.Mathematics.uint3x3 b)
  RVA=0x09C431B4  token=0x60006C2  Unity.Mathematics.uint2x4 mul(Unity.Mathematics.uint2x3 a, Unity.Mathematics.uint3x4 b)
  RVA=0x09C45178  token=0x60006C3  Unity.Mathematics.uint2 mul(Unity.Mathematics.uint2x4 a, Unity.Mathematics.uint4 b)
  RVA=0x09C45C2C  token=0x60006C4  Unity.Mathematics.uint2x2 mul(Unity.Mathematics.uint2x4 a, Unity.Mathematics.uint4x2 b)
  RVA=0x09C42A14  token=0x60006C5  Unity.Mathematics.uint2x3 mul(Unity.Mathematics.uint2x4 a, Unity.Mathematics.uint4x3 b)
  RVA=0x09C4AF68  token=0x60006C6  Unity.Mathematics.uint2x4 mul(Unity.Mathematics.uint2x4 a, Unity.Mathematics.uint4x4 b)
  RVA=0x09C458C4  token=0x60006C7  Unity.Mathematics.uint3 mul(Unity.Mathematics.uint3x2 a, Unity.Mathematics.uint2 b)
  RVA=0x09C4E044  token=0x60006C8  Unity.Mathematics.uint3x2 mul(Unity.Mathematics.uint3x2 a, Unity.Mathematics.uint2x2 b)
  RVA=0x09C46AB4  token=0x60006C9  Unity.Mathematics.uint3x3 mul(Unity.Mathematics.uint3x2 a, Unity.Mathematics.uint2x3 b)
  RVA=0x09C4759C  token=0x60006CA  Unity.Mathematics.uint3x4 mul(Unity.Mathematics.uint3x2 a, Unity.Mathematics.uint2x4 b)
  RVA=0x09C474B0  token=0x60006CB  Unity.Mathematics.uint3 mul(Unity.Mathematics.uint3x3 a, Unity.Mathematics.uint3 b)
  RVA=0x09C435FC  token=0x60006CC  Unity.Mathematics.uint3x2 mul(Unity.Mathematics.uint3x3 a, Unity.Mathematics.uint3x2 b)
  RVA=0x09C4BFA0  token=0x60006CD  Unity.Mathematics.uint3x3 mul(Unity.Mathematics.uint3x3 a, Unity.Mathematics.uint3x3 b)
  RVA=0x09C47104  token=0x60006CE  Unity.Mathematics.uint3x4 mul(Unity.Mathematics.uint3x3 a, Unity.Mathematics.uint3x4 b)
  RVA=0x09C45220  token=0x60006CF  Unity.Mathematics.uint3 mul(Unity.Mathematics.uint3x4 a, Unity.Mathematics.uint4 b)
  RVA=0x09C42180  token=0x60006D0  Unity.Mathematics.uint3x2 mul(Unity.Mathematics.uint3x4 a, Unity.Mathematics.uint4x2 b)
  RVA=0x09C49110  token=0x60006D1  Unity.Mathematics.uint3x3 mul(Unity.Mathematics.uint3x4 a, Unity.Mathematics.uint4x3 b)
  RVA=0x09C43EA8  token=0x60006D2  Unity.Mathematics.uint3x4 mul(Unity.Mathematics.uint3x4 a, Unity.Mathematics.uint4x4 b)
  RVA=0x09C4294C  token=0x60006D3  Unity.Mathematics.uint4 mul(Unity.Mathematics.uint4x2 a, Unity.Mathematics.uint2 b)
  RVA=0x09C45360  token=0x60006D4  Unity.Mathematics.uint4x2 mul(Unity.Mathematics.uint4x2 a, Unity.Mathematics.uint2x2 b)
  RVA=0x09C47D58  token=0x60006D5  Unity.Mathematics.uint4x3 mul(Unity.Mathematics.uint4x2 a, Unity.Mathematics.uint2x3 b)
  RVA=0x09C4A4EC  token=0x60006D6  Unity.Mathematics.uint4x4 mul(Unity.Mathematics.uint4x2 a, Unity.Mathematics.uint2x4 b)
  RVA=0x09C424F0  token=0x60006D7  Unity.Mathematics.uint4 mul(Unity.Mathematics.uint4x3 a, Unity.Mathematics.uint3 b)
  RVA=0x09C43D50  token=0x60006D8  Unity.Mathematics.uint4x2 mul(Unity.Mathematics.uint4x3 a, Unity.Mathematics.uint3x2 b)
  RVA=0x09C41B1C  token=0x60006D9  Unity.Mathematics.uint4x3 mul(Unity.Mathematics.uint4x3 a, Unity.Mathematics.uint3x3 b)
  RVA=0x09C46DFC  token=0x60006DA  Unity.Mathematics.uint4x4 mul(Unity.Mathematics.uint4x3 a, Unity.Mathematics.uint3x4 b)
  RVA=0x09C4AAB0  token=0x60006DB  Unity.Mathematics.uint4 mul(Unity.Mathematics.uint4x4 a, Unity.Mathematics.uint4 b)
  RVA=0x09C4853C  token=0x60006DC  Unity.Mathematics.uint4x2 mul(Unity.Mathematics.uint4x4 a, Unity.Mathematics.uint4x2 b)
  RVA=0x09C4C654  token=0x60006DD  Unity.Mathematics.uint4x3 mul(Unity.Mathematics.uint4x4 a, Unity.Mathematics.uint4x3 b)
  RVA=0x09C4CE04  token=0x60006DE  Unity.Mathematics.uint4x4 mul(Unity.Mathematics.uint4x4 a, Unity.Mathematics.uint4x4 b)
  RVA=0x03D7AAC0  token=0x60006DF  Unity.Mathematics.quaternion quaternion(System.Single x, System.Single y, System.Single z, System.Single w)
  RVA=0x03D5B250  token=0x60006E0  Unity.Mathematics.quaternion quaternion(Unity.Mathematics.float4 value)
  RVA=0x09C50FAC  token=0x60006E1  Unity.Mathematics.quaternion quaternion(Unity.Mathematics.float3x3 m)
  RVA=0x09C50F64  token=0x60006E2  Unity.Mathematics.quaternion quaternion(Unity.Mathematics.float4x4 m)
  RVA=0x09C2FD34  token=0x60006E3  Unity.Mathematics.quaternion conjugate(Unity.Mathematics.quaternion q)
  RVA=0x09C3EF9C  token=0x60006E4  Unity.Mathematics.quaternion inverse(Unity.Mathematics.quaternion q)
  RVA=0x09C30A70  token=0x60006E5  System.Single dot(Unity.Mathematics.quaternion a, Unity.Mathematics.quaternion b)
  RVA=0x09C3FA88  token=0x60006E6  System.Single length(Unity.Mathematics.quaternion q)
  RVA=0x09C3FAC4  token=0x60006E7  System.Single lengthsq(Unity.Mathematics.quaternion q)
  RVA=0x09C4FCD8  token=0x60006E8  Unity.Mathematics.quaternion normalize(Unity.Mathematics.quaternion q)
  RVA=0x09C50050  token=0x60006E9  Unity.Mathematics.quaternion normalizesafe(Unity.Mathematics.quaternion q)
  RVA=0x09C4FFC4  token=0x60006EA  Unity.Mathematics.quaternion normalizesafe(Unity.Mathematics.quaternion q, Unity.Mathematics.quaternion defaultvalue)
  RVA=0x04D5E554  token=0x60006EB  Unity.Mathematics.quaternion unitexp(Unity.Mathematics.quaternion q)
  RVA=0x04D30CA4  token=0x60006EC  Unity.Mathematics.quaternion exp(Unity.Mathematics.quaternion q)
  RVA=0x04D5E678  token=0x60006ED  Unity.Mathematics.quaternion unitlog(Unity.Mathematics.quaternion q)
  RVA=0x04D3C860  token=0x60006EE  Unity.Mathematics.quaternion log(Unity.Mathematics.quaternion q)
  RVA=0x09C44D18  token=0x60006EF  Unity.Mathematics.quaternion mul(Unity.Mathematics.quaternion a, Unity.Mathematics.quaternion b)
  RVA=0x09C4E284  token=0x60006F0  Unity.Mathematics.float3 mul(Unity.Mathematics.quaternion q, Unity.Mathematics.float3 v)
  RVA=0x09C4E284  token=0x60006F1  Unity.Mathematics.float3 rotate(Unity.Mathematics.quaternion q, Unity.Mathematics.float3 v)
  RVA=0x09C4FB78  token=0x60006F2  Unity.Mathematics.quaternion nlerp(Unity.Mathematics.quaternion q1, Unity.Mathematics.quaternion q2, System.Single t)
  RVA=0x09C5519C  token=0x60006F3  Unity.Mathematics.quaternion slerp(Unity.Mathematics.quaternion q1, Unity.Mathematics.quaternion q2, System.Single t)
  RVA=0x09C2E520  token=0x60006F4  System.Single angle(Unity.Mathematics.quaternion q1, Unity.Mathematics.quaternion q2)
  RVA=0x09C52BF8  token=0x60006F5  Unity.Mathematics.quaternion rotation(Unity.Mathematics.float3x3 m)
  RVA=0x09C2E1E8  token=0x60006F6  Unity.Mathematics.float3x3 adj(Unity.Mathematics.float3x3 m, System.Single& det)
  RVA=0x09C2E0E8  token=0x60006F7  System.Boolean adjInverse(Unity.Mathematics.float3x3 m, Unity.Mathematics.float3x3& i, System.Single epsilon)
  RVA=0x09C38878  token=0x60006F8  System.UInt32 hash(Unity.Mathematics.quaternion q)
  RVA=0x09C3B4D0  token=0x60006F9  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.quaternion q)
  RVA=0x05543208  token=0x60006FA  Unity.Mathematics.float3 forward(Unity.Mathematics.quaternion q)
  RVA=0x03D78270  token=0x60006FB  Unity.Mathematics.RigidTransform RigidTransform(Unity.Mathematics.quaternion rot, Unity.Mathematics.float3 pos)
  RVA=0x09C2DE48  token=0x60006FC  Unity.Mathematics.RigidTransform RigidTransform(Unity.Mathematics.float3x3 rotation, Unity.Mathematics.float3 translation)
  RVA=0x09C2DEA4  token=0x60006FD  Unity.Mathematics.RigidTransform RigidTransform(Unity.Mathematics.float4x4 transform)
  RVA=0x09C3F018  token=0x60006FE  Unity.Mathematics.RigidTransform inverse(Unity.Mathematics.RigidTransform t)
  RVA=0x09C4D444  token=0x60006FF  Unity.Mathematics.RigidTransform mul(Unity.Mathematics.RigidTransform a, Unity.Mathematics.RigidTransform b)
  RVA=0x09C42414  token=0x6000700  Unity.Mathematics.float4 mul(Unity.Mathematics.RigidTransform a, Unity.Mathematics.float4 pos)
  RVA=0x0554451C  token=0x6000701  Unity.Mathematics.float3 rotate(Unity.Mathematics.RigidTransform a, Unity.Mathematics.float3 dir)
  RVA=0x09C563B8  token=0x6000702  Unity.Mathematics.float3 transform(Unity.Mathematics.RigidTransform a, Unity.Mathematics.float3 pos)
  RVA=0x09C38974  token=0x6000703  System.UInt32 hash(Unity.Mathematics.RigidTransform t)
  RVA=0x09C39CA0  token=0x6000704  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.RigidTransform t)
  RVA=0x03D78AF0  token=0x6000705  Unity.Mathematics.uint2 uint2(System.UInt32 x, System.UInt32 y)
  RVA=0x03D76940  token=0x6000706  Unity.Mathematics.uint2 uint2(Unity.Mathematics.uint2 xy)
  RVA=0x03D7B520  token=0x6000707  Unity.Mathematics.uint2 uint2(System.UInt32 v)
  RVA=0x09C3C78C  token=0x6000708  Unity.Mathematics.uint2 uint2(System.Boolean v)
  RVA=0x09C3C7A4  token=0x6000709  Unity.Mathematics.uint2 uint2(Unity.Mathematics.bool2 v)
  RVA=0x03D7B520  token=0x600070A  Unity.Mathematics.uint2 uint2(System.Int32 v)
  RVA=0x03D76940  token=0x600070B  Unity.Mathematics.uint2 uint2(Unity.Mathematics.int2 v)
  RVA=0x09C57A68  token=0x600070C  Unity.Mathematics.uint2 uint2(System.Single v)
  RVA=0x09C57A8C  token=0x600070D  Unity.Mathematics.uint2 uint2(Unity.Mathematics.float2 v)
  RVA=0x09C57A48  token=0x600070E  Unity.Mathematics.uint2 uint2(System.Double v)
  RVA=0x09C57A18  token=0x600070F  Unity.Mathematics.uint2 uint2(Unity.Mathematics.double2 v)
  RVA=0x09C36CFC  token=0x6000710  System.UInt32 hash(Unity.Mathematics.uint2 v)
  RVA=0x09C39968  token=0x6000711  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.uint2 v)
  RVA=0x04D58FA0  token=0x6000712  System.UInt32 shuffle(Unity.Mathematics.uint2 left, Unity.Mathematics.uint2 right, Unity.Mathematics.math.ShuffleComponent x)
  RVA=0x04D581BC  token=0x6000713  Unity.Mathematics.uint2 shuffle(Unity.Mathematics.uint2 left, Unity.Mathematics.uint2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  RVA=0x04D58730  token=0x6000714  Unity.Mathematics.uint3 shuffle(Unity.Mathematics.uint2 left, Unity.Mathematics.uint2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  RVA=0x04D5978C  token=0x6000715  Unity.Mathematics.uint4 shuffle(Unity.Mathematics.uint2 left, Unity.Mathematics.uint2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  RVA=0x04D57274  token=0x6000716  System.UInt32 select_shuffle_component(Unity.Mathematics.uint2 a, Unity.Mathematics.uint2 b, Unity.Mathematics.math.ShuffleComponent component)
  RVA=0x02232AA0  token=0x6000717  Unity.Mathematics.uint2x2 uint2x2(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1)
  RVA=0x09C3C820  token=0x6000718  Unity.Mathematics.uint2x2 uint2x2(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11)
  RVA=0x09C3C808  token=0x6000719  Unity.Mathematics.uint2x2 uint2x2(System.UInt32 v)
  RVA=0x09C3C8C4  token=0x600071A  Unity.Mathematics.uint2x2 uint2x2(System.Boolean v)
  RVA=0x09C3C7C4  token=0x600071B  Unity.Mathematics.uint2x2 uint2x2(Unity.Mathematics.bool2x2 v)
  RVA=0x09C3C808  token=0x600071C  Unity.Mathematics.uint2x2 uint2x2(System.Int32 v)
  RVA=0x09C3C888  token=0x600071D  Unity.Mathematics.uint2x2 uint2x2(Unity.Mathematics.int2x2 v)
  RVA=0x09C57AB0  token=0x600071E  Unity.Mathematics.uint2x2 uint2x2(System.Single v)
  RVA=0x09C57B6C  token=0x600071F  Unity.Mathematics.uint2x2 uint2x2(Unity.Mathematics.float2x2 v)
  RVA=0x09C57ACC  token=0x6000720  Unity.Mathematics.uint2x2 uint2x2(System.Double v)
  RVA=0x09C57B10  token=0x6000721  Unity.Mathematics.uint2x2 uint2x2(Unity.Mathematics.double2x2 v)
  RVA=0x09C56888  token=0x6000722  Unity.Mathematics.uint2x2 transpose(Unity.Mathematics.uint2x2 v)
  RVA=0x09C3803C  token=0x6000723  System.UInt32 hash(Unity.Mathematics.uint2x2 v)
  RVA=0x09C39878  token=0x6000724  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.uint2x2 v)
  RVA=0x03D7A7F0  token=0x6000725  Unity.Mathematics.uint2x3 uint2x3(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1, Unity.Mathematics.uint2 c2)
  RVA=0x04D3AE7C  token=0x6000726  Unity.Mathematics.uint2x3 uint2x3(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12)
  RVA=0x09C3C934  token=0x6000727  Unity.Mathematics.uint2x3 uint2x3(System.UInt32 v)
  RVA=0x09C3C9E8  token=0x6000728  Unity.Mathematics.uint2x3 uint2x3(System.Boolean v)
  RVA=0x09C3C974  token=0x6000729  Unity.Mathematics.uint2x3 uint2x3(Unity.Mathematics.bool2x3 v)
  RVA=0x09C3C934  token=0x600072A  Unity.Mathematics.uint2x3 uint2x3(System.Int32 v)
  RVA=0x09C3C8FC  token=0x600072B  Unity.Mathematics.uint2x3 uint2x3(Unity.Mathematics.int2x3 v)
  RVA=0x09C57BEC  token=0x600072C  Unity.Mathematics.uint2x3 uint2x3(System.Single v)
  RVA=0x09C57BB4  token=0x600072D  Unity.Mathematics.uint2x3 uint2x3(Unity.Mathematics.float2x3 v)
  RVA=0x09C57B94  token=0x600072E  Unity.Mathematics.uint2x3 uint2x3(System.Double v)
  RVA=0x09C57C0C  token=0x600072F  Unity.Mathematics.uint2x3 uint2x3(Unity.Mathematics.double2x3 v)
  RVA=0x09C574EC  token=0x6000730  Unity.Mathematics.uint3x2 transpose(Unity.Mathematics.uint2x3 v)
  RVA=0x09C37558  token=0x6000731  System.UInt32 hash(Unity.Mathematics.uint2x3 v)
  RVA=0x09C3C4C8  token=0x6000732  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.uint2x3 v)
  RVA=0x03D7B550  token=0x6000733  Unity.Mathematics.uint2x4 uint2x4(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1, Unity.Mathematics.uint2 c2, Unity.Mathematics.uint2 c3)
  RVA=0x04D3AEB4  token=0x6000734  Unity.Mathematics.uint2x4 uint2x4(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13)
  RVA=0x09C3CA64  token=0x6000735  Unity.Mathematics.uint2x4 uint2x4(System.UInt32 v)
  RVA=0x09C3CAB4  token=0x6000736  Unity.Mathematics.uint2x4 uint2x4(System.Boolean v)
  RVA=0x09C3CA40  token=0x6000737  Unity.Mathematics.uint2x4 uint2x4(Unity.Mathematics.bool2x4 v)
  RVA=0x09C3CA64  token=0x6000738  Unity.Mathematics.uint2x4 uint2x4(System.Int32 v)
  RVA=0x09C3CA80  token=0x6000739  Unity.Mathematics.uint2x4 uint2x4(Unity.Mathematics.int2x4 v)
  RVA=0x09C57C7C  token=0x600073A  Unity.Mathematics.uint2x4 uint2x4(System.Single v)
  RVA=0x09C57C48  token=0x600073B  Unity.Mathematics.uint2x4 uint2x4(Unity.Mathematics.float2x4 v)
  RVA=0x09C57C9C  token=0x600073C  Unity.Mathematics.uint2x4 uint2x4(System.Double v)
  RVA=0x09C57CB8  token=0x600073D  Unity.Mathematics.uint2x4 uint2x4(Unity.Mathematics.double2x4 v)
  RVA=0x09C56AA0  token=0x600073E  Unity.Mathematics.uint4x2 transpose(Unity.Mathematics.uint2x4 v)
  RVA=0x09C364B0  token=0x600073F  System.UInt32 hash(Unity.Mathematics.uint2x4 v)
  RVA=0x09C3B500  token=0x6000740  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.uint2x4 v)
  RVA=0x03D78B00  token=0x6000741  Unity.Mathematics.uint3 uint3(System.UInt32 x, System.UInt32 y, System.UInt32 z)
  RVA=0x03D7B5B0  token=0x6000742  Unity.Mathematics.uint3 uint3(System.UInt32 x, Unity.Mathematics.uint2 yz)
  RVA=0x03D7B5D0  token=0x6000743  Unity.Mathematics.uint3 uint3(Unity.Mathematics.uint2 xy, System.UInt32 z)
  RVA=0x03D7B5F0  token=0x6000744  Unity.Mathematics.uint3 uint3(Unity.Mathematics.uint3 xyz)
  RVA=0x03D7B570  token=0x6000745  Unity.Mathematics.uint3 uint3(System.UInt32 v)
  RVA=0x09C3CB80  token=0x6000746  Unity.Mathematics.uint3 uint3(System.Boolean v)
  RVA=0x09C3CB98  token=0x6000747  Unity.Mathematics.uint3 uint3(Unity.Mathematics.bool3 v)
  RVA=0x03D7B570  token=0x6000748  Unity.Mathematics.uint3 uint3(System.Int32 v)
  RVA=0x03D7B5F0  token=0x6000749  Unity.Mathematics.uint3 uint3(Unity.Mathematics.int3 v)
  RVA=0x09C57D5C  token=0x600074A  Unity.Mathematics.uint3 uint3(System.Single v)
  RVA=0x04D5FCE8  token=0x600074B  Unity.Mathematics.uint3 uint3(Unity.Mathematics.float3 v)
  RVA=0x09C57D34  token=0x600074C  Unity.Mathematics.uint3 uint3(System.Double v)
  RVA=0x09C57CFC  token=0x600074D  Unity.Mathematics.uint3 uint3(Unity.Mathematics.double3 v)
  RVA=0x04D33F54  token=0x600074E  System.UInt32 hash(Unity.Mathematics.uint3 v)
  RVA=0x04D3A078  token=0x600074F  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.uint3 v)
  RVA=0x04D599AC  token=0x6000750  System.UInt32 shuffle(Unity.Mathematics.uint3 left, Unity.Mathematics.uint3 right, Unity.Mathematics.math.ShuffleComponent x)
  RVA=0x04D58EA8  token=0x6000751  Unity.Mathematics.uint2 shuffle(Unity.Mathematics.uint3 left, Unity.Mathematics.uint3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  RVA=0x04D598D0  token=0x6000752  Unity.Mathematics.uint3 shuffle(Unity.Mathematics.uint3 left, Unity.Mathematics.uint3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  RVA=0x04D591A0  token=0x6000753  Unity.Mathematics.uint4 shuffle(Unity.Mathematics.uint3 left, Unity.Mathematics.uint3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  RVA=0x04D579DC  token=0x6000754  System.UInt32 select_shuffle_component(Unity.Mathematics.uint3 a, Unity.Mathematics.uint3 b, Unity.Mathematics.math.ShuffleComponent component)
  RVA=0x03D7AA40  token=0x6000755  Unity.Mathematics.uint3x2 uint3x2(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1)
  RVA=0x04D3AF08  token=0x6000756  Unity.Mathematics.uint3x2 uint3x2(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11, System.UInt32 m20, System.UInt32 m21)
  RVA=0x09C3CC7C  token=0x6000757  Unity.Mathematics.uint3x2 uint3x2(System.UInt32 v)
  RVA=0x09C3CC9C  token=0x6000758  Unity.Mathematics.uint3x2 uint3x2(System.Boolean v)
  RVA=0x09C3CCBC  token=0x6000759  Unity.Mathematics.uint3x2 uint3x2(Unity.Mathematics.bool3x2 v)
  RVA=0x09C3CC7C  token=0x600075A  Unity.Mathematics.uint3x2 uint3x2(System.Int32 v)
  RVA=0x09C3CC0C  token=0x600075B  Unity.Mathematics.uint3x2 uint3x2(Unity.Mathematics.int3x2 v)
  RVA=0x09C57E4C  token=0x600075C  Unity.Mathematics.uint3x2 uint3x2(System.Single v)
  RVA=0x09C57E14  token=0x600075D  Unity.Mathematics.uint3x2 uint3x2(Unity.Mathematics.float3x2 v)
  RVA=0x09C57D78  token=0x600075E  Unity.Mathematics.uint3x2 uint3x2(System.Double v)
  RVA=0x09C57DD8  token=0x600075F  Unity.Mathematics.uint3x2 uint3x2(Unity.Mathematics.double3x2 v)
  RVA=0x09C568C4  token=0x6000760  Unity.Mathematics.uint2x3 transpose(Unity.Mathematics.uint3x2 v)
  RVA=0x09C36A54  token=0x6000761  System.UInt32 hash(Unity.Mathematics.uint3x2 v)
  RVA=0x09C3AFE8  token=0x6000762  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.uint3x2 v)
  RVA=0x02E246E0  token=0x6000763  Unity.Mathematics.uint3x3 uint3x3(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1, Unity.Mathematics.uint3 c2)
  RVA=0x04D3AF98  token=0x6000764  Unity.Mathematics.uint3x3 uint3x3(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22)
  RVA=0x09C3CD34  token=0x6000765  Unity.Mathematics.uint3x3 uint3x3(System.UInt32 v)
  RVA=0x09C3CEAC  token=0x6000766  Unity.Mathematics.uint3x3 uint3x3(System.Boolean v)
  RVA=0x09C3CE6C  token=0x6000767  Unity.Mathematics.uint3x3 uint3x3(Unity.Mathematics.bool3x3 v)
  RVA=0x09C3CD34  token=0x6000768  Unity.Mathematics.uint3x3 uint3x3(System.Int32 v)
  RVA=0x09C3CD74  token=0x6000769  Unity.Mathematics.uint3x3 uint3x3(Unity.Mathematics.int3x3 v)
  RVA=0x09C57ECC  token=0x600076A  Unity.Mathematics.uint3x3 uint3x3(System.Single v)
  RVA=0x09C57E8C  token=0x600076B  Unity.Mathematics.uint3x3 uint3x3(Unity.Mathematics.float3x3 v)
  RVA=0x09C57E6C  token=0x600076C  Unity.Mathematics.uint3x3 uint3x3(System.Double v)
  RVA=0x09C57EF0  token=0x600076D  Unity.Mathematics.uint3x3 uint3x3(Unity.Mathematics.double3x3 v)
  RVA=0x09C56E28  token=0x600076E  Unity.Mathematics.uint3x3 transpose(Unity.Mathematics.uint3x3 v)
  RVA=0x09C38234  token=0x600076F  System.UInt32 hash(Unity.Mathematics.uint3x3 v)
  RVA=0x09C3B6C0  token=0x6000770  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.uint3x3 v)
  RVA=0x03D7AA70  token=0x6000771  Unity.Mathematics.uint3x4 uint3x4(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1, Unity.Mathematics.uint3 c2, Unity.Mathematics.uint3 c3)
  RVA=0x04D3B05C  token=0x6000772  Unity.Mathematics.uint3x4 uint3x4(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m23)
  RVA=0x09C3CF88  token=0x6000773  Unity.Mathematics.uint3x4 uint3x4(System.UInt32 v)
  RVA=0x09C3CECC  token=0x6000774  Unity.Mathematics.uint3x4 uint3x4(System.Boolean v)
  RVA=0x09C3CF4C  token=0x6000775  Unity.Mathematics.uint3x4 uint3x4(Unity.Mathematics.bool3x4 v)
  RVA=0x09C3CF88  token=0x6000776  Unity.Mathematics.uint3x4 uint3x4(System.Int32 v)
  RVA=0x09C3D02C  token=0x6000777  Unity.Mathematics.uint3x4 uint3x4(Unity.Mathematics.int3x4 v)
  RVA=0x09C58004  token=0x6000778  Unity.Mathematics.uint3x4 uint3x4(System.Single v)
  RVA=0x09C57FC0  token=0x6000779  Unity.Mathematics.uint3x4 uint3x4(Unity.Mathematics.float3x4 v)
  RVA=0x09C57F44  token=0x600077A  Unity.Mathematics.uint3x4 uint3x4(System.Double v)
  RVA=0x09C57F64  token=0x600077B  Unity.Mathematics.uint3x4 uint3x4(Unity.Mathematics.double3x4 v)
  RVA=0x09C569B0  token=0x600077C  Unity.Mathematics.uint4x3 transpose(Unity.Mathematics.uint3x4 v)
  RVA=0x09C37E70  token=0x600077D  System.UInt32 hash(Unity.Mathematics.uint3x4 v)
  RVA=0x09C3C1F8  token=0x600077E  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.uint3x4 v)
  RVA=0x03D78B10  token=0x600077F  Unity.Mathematics.uint4 uint4(System.UInt32 x, System.UInt32 y, System.UInt32 z, System.UInt32 w)
  RVA=0x03D7B730  token=0x6000780  Unity.Mathematics.uint4 uint4(System.UInt32 x, System.UInt32 y, Unity.Mathematics.uint2 zw)
  RVA=0x03D7B7B0  token=0x6000781  Unity.Mathematics.uint4 uint4(System.UInt32 x, Unity.Mathematics.uint2 yz, System.UInt32 w)
  RVA=0x03D7B6B0  token=0x6000782  Unity.Mathematics.uint4 uint4(System.UInt32 x, Unity.Mathematics.uint3 yzw)
  RVA=0x03D7B750  token=0x6000783  Unity.Mathematics.uint4 uint4(Unity.Mathematics.uint2 xy, System.UInt32 z, System.UInt32 w)
  RVA=0x03D76960  token=0x6000784  Unity.Mathematics.uint4 uint4(Unity.Mathematics.uint2 xy, Unity.Mathematics.uint2 zw)
  RVA=0x03D7B770  token=0x6000785  Unity.Mathematics.uint4 uint4(Unity.Mathematics.uint3 xyz, System.UInt32 w)
  RVA=0x09C3D070  token=0x6000786  Unity.Mathematics.uint4 uint4(Unity.Mathematics.uint4 xyzw)
  RVA=0x03D7B6A0  token=0x6000787  Unity.Mathematics.uint4 uint4(System.UInt32 v)
  RVA=0x09C3D09C  token=0x6000788  Unity.Mathematics.uint4 uint4(System.Boolean v)
  RVA=0x09C3D0BC  token=0x6000789  Unity.Mathematics.uint4 uint4(Unity.Mathematics.bool4 v)
  RVA=0x03D7B6A0  token=0x600078A  Unity.Mathematics.uint4 uint4(System.Int32 v)
  RVA=0x09C3D070  token=0x600078B  Unity.Mathematics.uint4 uint4(Unity.Mathematics.int4 v)
  RVA=0x09C58070  token=0x600078C  Unity.Mathematics.uint4 uint4(System.Single v)
  RVA=0x09C580B8  token=0x600078D  Unity.Mathematics.uint4 uint4(Unity.Mathematics.float4 v)
  RVA=0x09C58088  token=0x600078E  Unity.Mathematics.uint4 uint4(System.Double v)
  RVA=0x09C58028  token=0x600078F  Unity.Mathematics.uint4 uint4(Unity.Mathematics.double4 v)
  RVA=0x09C35DFC  token=0x6000790  System.UInt32 hash(Unity.Mathematics.uint4 v)
  RVA=0x09C397FC  token=0x6000791  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.uint4 v)
  RVA=0x09C53F00  token=0x6000792  System.UInt32 shuffle(Unity.Mathematics.uint4 left, Unity.Mathematics.uint4 right, Unity.Mathematics.math.ShuffleComponent x)
  RVA=0x09C53A80  token=0x6000793  Unity.Mathematics.uint2 shuffle(Unity.Mathematics.uint4 left, Unity.Mathematics.uint4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  RVA=0x09C5434C  token=0x6000794  Unity.Mathematics.uint3 shuffle(Unity.Mathematics.uint4 left, Unity.Mathematics.uint4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  RVA=0x09C5468C  token=0x6000795  Unity.Mathematics.uint4 shuffle(Unity.Mathematics.uint4 left, Unity.Mathematics.uint4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  RVA=0x04D57EF8  token=0x6000796  System.UInt32 select_shuffle_component(Unity.Mathematics.uint4 a, Unity.Mathematics.uint4 b, Unity.Mathematics.math.ShuffleComponent component)
  RVA=0x03D7AC80  token=0x6000797  Unity.Mathematics.uint4x2 uint4x2(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1)
  RVA=0x04D3B124  token=0x6000798  Unity.Mathematics.uint4x2 uint4x2(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11, System.UInt32 m20, System.UInt32 m21, System.UInt32 m30, System.UInt32 m31)
  RVA=0x09C3D1C4  token=0x6000799  Unity.Mathematics.uint4x2 uint4x2(System.UInt32 v)
  RVA=0x09C58100  token=0x600079A  Unity.Mathematics.uint4x2 uint4x2(System.Boolean v)
  RVA=0x09C580DC  token=0x600079B  Unity.Mathematics.uint4x2 uint4x2(Unity.Mathematics.bool4x2 v)
  RVA=0x09C3D1C4  token=0x600079C  Unity.Mathematics.uint4x2 uint4x2(System.Int32 v)
  RVA=0x09C3D1E0  token=0x600079D  Unity.Mathematics.uint4x2 uint4x2(Unity.Mathematics.int4x2 v)
  RVA=0x09C5811C  token=0x600079E  Unity.Mathematics.uint4x2 uint4x2(System.Single v)
  RVA=0x09C58180  token=0x600079F  Unity.Mathematics.uint4x2 uint4x2(Unity.Mathematics.float4x2 v)
  RVA=0x09C581B4  token=0x60007A0  Unity.Mathematics.uint4x2 uint4x2(System.Double v)
  RVA=0x09C5813C  token=0x60007A1  Unity.Mathematics.uint4x2 uint4x2(Unity.Mathematics.double4x2 v)
  RVA=0x09C56910  token=0x60007A2  Unity.Mathematics.uint2x4 transpose(Unity.Mathematics.uint4x2 v)
  RVA=0x09C38454  token=0x60007A3  System.UInt32 hash(Unity.Mathematics.uint4x2 v)
  RVA=0x09C38E74  token=0x60007A4  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.uint4x2 v)
  RVA=0x03D7ACA0  token=0x60007A5  Unity.Mathematics.uint4x3 uint4x3(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1, Unity.Mathematics.uint4 c2)
  RVA=0x04D3B1D8  token=0x60007A6  Unity.Mathematics.uint4x3 uint4x3(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m30, System.UInt32 m31, System.UInt32 m32)
  RVA=0x09C3D2C4  token=0x60007A7  Unity.Mathematics.uint4x3 uint4x3(System.UInt32 v)
  RVA=0x09C582F0  token=0x60007A8  Unity.Mathematics.uint4x3 uint4x3(System.Boolean v)
  RVA=0x09C582B4  token=0x60007A9  Unity.Mathematics.uint4x3 uint4x3(Unity.Mathematics.bool4x3 v)
  RVA=0x09C3D2C4  token=0x60007AA  Unity.Mathematics.uint4x3 uint4x3(System.Int32 v)
  RVA=0x09C3D3A0  token=0x60007AB  Unity.Mathematics.uint4x3 uint4x3(Unity.Mathematics.int4x3 v)
  RVA=0x09C58270  token=0x60007AC  Unity.Mathematics.uint4x3 uint4x3(System.Single v)
  RVA=0x09C581D0  token=0x60007AD  Unity.Mathematics.uint4x3 uint4x3(Unity.Mathematics.float4x3 v)
  RVA=0x09C58294  token=0x60007AE  Unity.Mathematics.uint4x3 uint4x3(System.Double v)
  RVA=0x09C58214  token=0x60007AF  Unity.Mathematics.uint4x3 uint4x3(Unity.Mathematics.double4x3 v)
  RVA=0x09C56CC4  token=0x60007B0  Unity.Mathematics.uint3x4 transpose(Unity.Mathematics.uint4x3 v)
  RVA=0x09C37178  token=0x60007B1  System.UInt32 hash(Unity.Mathematics.uint4x3 v)
  RVA=0x09C3B0E0  token=0x60007B2  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.uint4x3 v)
  RVA=0x03D7ACC0  token=0x60007B3  Unity.Mathematics.uint4x4 uint4x4(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1, Unity.Mathematics.uint4 c2, Unity.Mathematics.uint4 c3)
  RVA=0x04D3B3A0  token=0x60007B4  Unity.Mathematics.uint4x4 uint4x4(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m23, System.UInt32 m30, System.UInt32 m31, System.UInt32 m32, System.UInt32 m33)
  RVA=0x09C3D4C4  token=0x60007B5  Unity.Mathematics.uint4x4 uint4x4(System.UInt32 v)
  RVA=0x09C58310  token=0x60007B6  Unity.Mathematics.uint4x4 uint4x4(System.Boolean v)
  RVA=0x09C58390  token=0x60007B7  Unity.Mathematics.uint4x4 uint4x4(Unity.Mathematics.bool4x4 v)
  RVA=0x09C3D4C4  token=0x60007B8  Unity.Mathematics.uint4x4 uint4x4(System.Int32 v)
  RVA=0x09C3D544  token=0x60007B9  Unity.Mathematics.uint4x4 uint4x4(Unity.Mathematics.int4x4 v)
  RVA=0x09C58454  token=0x60007BA  Unity.Mathematics.uint4x4 uint4x4(System.Single v)
  RVA=0x09C58334  token=0x60007BB  Unity.Mathematics.uint4x4 uint4x4(Unity.Mathematics.float4x4 v)
  RVA=0x09C5847C  token=0x60007BC  Unity.Mathematics.uint4x4 uint4x4(System.Double v)
  RVA=0x09C583C8  token=0x60007BD  Unity.Mathematics.uint4x4 uint4x4(Unity.Mathematics.double4x4 v)
  RVA=0x09C57048  token=0x60007BE  Unity.Mathematics.uint4x4 transpose(Unity.Mathematics.uint4x4 v)
  RVA=0x09C36D30  token=0x60007BF  System.UInt32 hash(Unity.Mathematics.uint4x4 v)
  RVA=0x09C395C0  token=0x60007C0  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.uint4x4 v)
END_CLASS

CLASS: Unity.Mathematics.bool2
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x12
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            System.Boolean                  x  // 0x10
  public            System.Boolean                  y  // 0x11
METHODS:
  RVA=0x03D67530  token=0x60007C1  System.Void .ctor(System.Boolean x, System.Boolean y)
  RVA=0x03D7D460  token=0x60007C2  System.Void .ctor(Unity.Mathematics.bool2 xy)
  RVA=0x03D7D470  token=0x60007C3  System.Void .ctor(System.Boolean v)
  RVA=0x03D787D0  token=0x60007C4  Unity.Mathematics.bool2 op_Implicit(System.Boolean v)
  RVA=0x09C5F4B4  token=0x60007C5  System.Boolean Equals(Unity.Mathematics.bool2 rhs)
  RVA=0x09C5F4C8  token=0x60007C6  System.Boolean Equals(System.Object o)
  RVA=0x09C5F53C  token=0x60007C7  System.Int32 GetHashCode()
  RVA=0x09C5F584  token=0x60007C8  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool2x2
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x14
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            Unity.Mathematics.bool2         c0  // 0x10
  public            Unity.Mathematics.bool2         c1  // 0x12
METHODS:
  RVA=0x03D6EFA0  token=0x60007C9  System.Void .ctor(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1)
  RVA=0x03D7D4B0  token=0x60007CA  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11)
  RVA=0x03D7D480  token=0x60007CB  System.Void .ctor(System.Boolean v)
  RVA=0x09C58FAC  token=0x60007CC  System.Boolean Equals(Unity.Mathematics.bool2x2 rhs)
  RVA=0x09C5F60C  token=0x60007CD  System.Boolean Equals(System.Object o)
  RVA=0x09C5F66C  token=0x60007CE  System.Int32 GetHashCode()
  RVA=0x09C5F674  token=0x60007CF  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool2x3
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x16
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            Unity.Mathematics.bool2         c0  // 0x10
  public            Unity.Mathematics.bool2         c1  // 0x12
  public            Unity.Mathematics.bool2         c2  // 0x14
METHODS:
  RVA=0x03D7D570  token=0x60007D0  System.Void .ctor(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1, Unity.Mathematics.bool2 c2)
  RVA=0x03D7D4E0  token=0x60007D1  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12)
  RVA=0x03D7D530  token=0x60007D2  System.Void .ctor(System.Boolean v)
  RVA=0x09C59134  token=0x60007D3  System.Boolean Equals(Unity.Mathematics.bool2x3 rhs)
  RVA=0x09C5F7D0  token=0x60007D4  System.Boolean Equals(System.Object o)
  RVA=0x09C5F840  token=0x60007D5  System.Int32 GetHashCode()
  RVA=0x09C5F864  token=0x60007D6  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool2x4
TYPE:  sealed struct
TOKEN: 0x200000C
SIZE:  0x18
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            Unity.Mathematics.bool2         c0  // 0x10
  public            Unity.Mathematics.bool2         c1  // 0x12
  public            Unity.Mathematics.bool2         c2  // 0x14
  public            Unity.Mathematics.bool2         c3  // 0x16
METHODS:
  RVA=0x03D7D630  token=0x60007D7  System.Void .ctor(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1, Unity.Mathematics.bool2 c2, Unity.Mathematics.bool2 c3)
  RVA=0x03D7D580  token=0x60007D8  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13)
  RVA=0x03D7D5E0  token=0x60007D9  System.Void .ctor(System.Boolean v)
  RVA=0x09C5933C  token=0x60007DA  System.Boolean Equals(Unity.Mathematics.bool2x4 rhs)
  RVA=0x09C5FA2C  token=0x60007DB  System.Boolean Equals(System.Object o)
  RVA=0x09C5FA8C  token=0x60007DC  System.Int32 GetHashCode()
  RVA=0x09C5FA94  token=0x60007DD  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool3
TYPE:  sealed struct
TOKEN: 0x200000D
SIZE:  0x13
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            System.Boolean                  x  // 0x10
  public            System.Boolean                  y  // 0x11
  public            System.Boolean                  z  // 0x12
PROPERTIES:
  Item  get=0x029BF5F0  set=0x03D5EB10
METHODS:
  RVA=0x03D6B5F0  token=0x60007DE  System.Void .ctor(System.Boolean x, System.Boolean y, System.Boolean z)
  RVA=0x03D7D660  token=0x60007DF  System.Void .ctor(System.Boolean x, Unity.Mathematics.bool2 yz)
  RVA=0x03D7D670  token=0x60007E0  System.Void .ctor(Unity.Mathematics.bool2 xy, System.Boolean z)
  RVA=0x03D7D680  token=0x60007E1  System.Void .ctor(Unity.Mathematics.bool3 xyz)
  RVA=0x03D7D650  token=0x60007E2  System.Void .ctor(System.Boolean v)
  RVA=0x03D78870  token=0x60007E3  Unity.Mathematics.bool3 op_Implicit(System.Boolean v)
  RVA=0x02E9FD70  token=0x60007E4  Unity.Mathematics.bool3 op_BitwiseAnd(Unity.Mathematics.bool3 lhs, Unity.Mathematics.bool3 rhs)
  RVA=0x09C5FE0C  token=0x60007E5  Unity.Mathematics.bool3 op_BitwiseOr(Unity.Mathematics.bool3 lhs, Unity.Mathematics.bool3 rhs)
  RVA=0x09C595C4  token=0x60007E8  System.Boolean Equals(Unity.Mathematics.bool3 rhs)
  RVA=0x09C5FCC4  token=0x60007E9  System.Boolean Equals(System.Object o)
  RVA=0x09C5FD34  token=0x60007EA  System.Int32 GetHashCode()
  RVA=0x09C5FD58  token=0x60007EB  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool3x2
TYPE:  sealed struct
TOKEN: 0x200000F
SIZE:  0x16
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            Unity.Mathematics.bool3         c0  // 0x10
  public            Unity.Mathematics.bool3         c1  // 0x13
METHODS:
  RVA=0x03D7D710  token=0x60007EC  System.Void .ctor(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1)
  RVA=0x03D7D6A0  token=0x60007ED  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11, System.Boolean m20, System.Boolean m21)
  RVA=0x03D7D6E0  token=0x60007EE  System.Void .ctor(System.Boolean v)
  RVA=0x09C5FEAC  token=0x60007EF  System.Boolean Equals(Unity.Mathematics.bool3x2 rhs)
  RVA=0x09C5FE3C  token=0x60007F0  System.Boolean Equals(System.Object o)
  RVA=0x09C5FEF8  token=0x60007F1  System.Int32 GetHashCode()
  RVA=0x09C5FF1C  token=0x60007F2  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool3x3
TYPE:  sealed struct
TOKEN: 0x2000010
SIZE:  0x19
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            Unity.Mathematics.bool3         c0  // 0x10
  public            Unity.Mathematics.bool3         c1  // 0x13
  public            Unity.Mathematics.bool3         c2  // 0x16
METHODS:
  RVA=0x03D7D7E0  token=0x60007F3  System.Void .ctor(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1, Unity.Mathematics.bool3 c2)
  RVA=0x03D7D770  token=0x60007F4  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m20, System.Boolean m21, System.Boolean m22)
  RVA=0x03D7D730  token=0x60007F5  System.Void .ctor(System.Boolean v)
  RVA=0x09C60158  token=0x60007F6  System.Boolean Equals(Unity.Mathematics.bool3x3 rhs)
  RVA=0x09C600E4  token=0x60007F7  System.Boolean Equals(System.Object o)
  RVA=0x09C601CC  token=0x60007F8  System.Int32 GetHashCode()
  RVA=0x09C601F4  token=0x60007F9  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool3x4
TYPE:  sealed struct
TOKEN: 0x2000011
SIZE:  0x1C
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            Unity.Mathematics.bool3         c0  // 0x10
  public            Unity.Mathematics.bool3         c1  // 0x13
  public            Unity.Mathematics.bool3         c2  // 0x16
  public            Unity.Mathematics.bool3         c3  // 0x19
METHODS:
  RVA=0x03D7D8F0  token=0x60007FA  System.Void .ctor(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1, Unity.Mathematics.bool3 c2, Unity.Mathematics.bool3 c3)
  RVA=0x03D7D860  token=0x60007FB  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m23)
  RVA=0x03D7D810  token=0x60007FC  System.Void .ctor(System.Boolean v)
  RVA=0x09C60458  token=0x60007FD  System.Boolean Equals(Unity.Mathematics.bool3x4 rhs)
  RVA=0x09C604EC  token=0x60007FE  System.Boolean Equals(System.Object o)
  RVA=0x09C60560  token=0x60007FF  System.Int32 GetHashCode()
  RVA=0x09C60584  token=0x6000800  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool4
TYPE:  sealed struct
TOKEN: 0x2000012
SIZE:  0x14
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            System.Boolean                  x  // 0x10
  public            System.Boolean                  y  // 0x11
  public            System.Boolean                  z  // 0x12
  public            System.Boolean                  w  // 0x13
PROPERTIES:
  Item  set=0x03D5EB10
METHODS:
  RVA=0x03D76590  token=0x6000801  System.Void .ctor(System.Boolean x, System.Boolean y, System.Boolean z, System.Boolean w)
  RVA=0x03D7DA10  token=0x6000802  System.Void .ctor(System.Boolean x, System.Boolean y, Unity.Mathematics.bool2 zw)
  RVA=0x03D7D970  token=0x6000803  System.Void .ctor(System.Boolean x, Unity.Mathematics.bool2 yz, System.Boolean w)
  RVA=0x03D7D990  token=0x6000804  System.Void .ctor(System.Boolean x, Unity.Mathematics.bool3 yzw)
  RVA=0x03D7D9B0  token=0x6000805  System.Void .ctor(Unity.Mathematics.bool2 xy, System.Boolean z, System.Boolean w)
  RVA=0x03D7D9D0  token=0x6000806  System.Void .ctor(Unity.Mathematics.bool2 xy, Unity.Mathematics.bool2 zw)
  RVA=0x03D7D9F0  token=0x6000807  System.Void .ctor(Unity.Mathematics.bool3 xyz, System.Boolean w)
  RVA=0x03D7D940  token=0x6000808  System.Void .ctor(Unity.Mathematics.bool4 xyzw)
  RVA=0x03D7D960  token=0x6000809  System.Void .ctor(System.Boolean v)
  RVA=0x03D78A00  token=0x600080A  Unity.Mathematics.bool4 op_Implicit(System.Boolean v)
  RVA=0x09C59F38  token=0x600080C  System.Boolean Equals(Unity.Mathematics.bool4 rhs)
  RVA=0x09C60884  token=0x600080D  System.Boolean Equals(System.Object o)
  RVA=0x09C608E4  token=0x600080E  System.Int32 GetHashCode()
  RVA=0x09C608EC  token=0x600080F  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool4x2
TYPE:  sealed struct
TOKEN: 0x2000014
SIZE:  0x18
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            Unity.Mathematics.bool4         c0  // 0x10
  public            Unity.Mathematics.bool4         c1  // 0x14
METHODS:
  RVA=0x03D4E4B0  token=0x6000810  System.Void .ctor(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1)
  RVA=0x03D7DA60  token=0x6000811  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11, System.Boolean m20, System.Boolean m21, System.Boolean m30, System.Boolean m31)
  RVA=0x03D7DA30  token=0x6000812  System.Void .ctor(System.Boolean v)
  RVA=0x09C5A0C0  token=0x6000813  System.Boolean Equals(Unity.Mathematics.bool4x2 rhs)
  RVA=0x09C60A48  token=0x6000814  System.Boolean Equals(System.Object o)
  RVA=0x09C60AA8  token=0x6000815  System.Int32 GetHashCode()
  RVA=0x09C60AB0  token=0x6000816  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool4x3
TYPE:  sealed struct
TOKEN: 0x2000015
SIZE:  0x1C
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            Unity.Mathematics.bool4         c0  // 0x10
  public            Unity.Mathematics.bool4         c1  // 0x14
  public            Unity.Mathematics.bool4         c2  // 0x18
METHODS:
  RVA=0x03D4E5D0  token=0x6000817  System.Void .ctor(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1, Unity.Mathematics.bool4 c2)
  RVA=0x03D7DAB0  token=0x6000818  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m30, System.Boolean m31, System.Boolean m32)
  RVA=0x03D7DB30  token=0x6000819  System.Void .ctor(System.Boolean v)
  RVA=0x09C60D54  token=0x600081A  System.Boolean Equals(Unity.Mathematics.bool4x3 rhs)
  RVA=0x09C60CE0  token=0x600081B  System.Boolean Equals(System.Object o)
  RVA=0x09C60D94  token=0x600081C  System.Int32 GetHashCode()
  RVA=0x09C60DB8  token=0x600081D  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool4x4
TYPE:  sealed struct
TOKEN: 0x2000016
SIZE:  0x20
IMPLEMENTS: System.IEquatable`1
FIELDS:
  public            Unity.Mathematics.bool4         c0  // 0x10
  public            Unity.Mathematics.bool4         c1  // 0x14
  public            Unity.Mathematics.bool4         c2  // 0x18
  public            Unity.Mathematics.bool4         c3  // 0x1c
METHODS:
  RVA=0x03D517E0  token=0x600081E  System.Void .ctor(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1, Unity.Mathematics.bool4 c2, Unity.Mathematics.bool4 c3)
  RVA=0x03D7DB80  token=0x600081F  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m23, System.Boolean m30, System.Boolean m31, System.Boolean m32, System.Boolean m33)
  RVA=0x03D7DC30  token=0x6000820  System.Void .ctor(System.Boolean v)
  RVA=0x09C61124  token=0x6000821  System.Boolean Equals(Unity.Mathematics.bool4x4 rhs)
  RVA=0x09C610B8  token=0x6000822  System.Boolean Equals(System.Object o)
  RVA=0x09C61174  token=0x6000823  System.Int32 GetHashCode()
  RVA=0x09C61190  token=0x6000824  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.double2
TYPE:  sealed struct
TOKEN: 0x2000017
SIZE:  0x20
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            System.Double                   x  // 0x10
  public            System.Double                   y  // 0x18
METHODS:
  RVA=0x03D50BD0  token=0x6000825  System.Void .ctor(System.Double x, System.Double y)
  RVA=0x03D50BC0  token=0x6000826  System.Void .ctor(Unity.Mathematics.double2 xy)
  RVA=0x03D7DCE0  token=0x6000827  System.Void .ctor(System.Double v)
  RVA=0x09C61760  token=0x6000828  System.Void .ctor(System.Boolean v)
  RVA=0x04D253C0  token=0x6000829  System.Void .ctor(Unity.Mathematics.bool2 v)
  RVA=0x03D7DD10  token=0x600082A  System.Void .ctor(System.Int32 v)
  RVA=0x03D7DCC0  token=0x600082B  System.Void .ctor(Unity.Mathematics.int2 v)
  RVA=0x03D7DCF0  token=0x600082C  System.Void .ctor(System.UInt32 v)
  RVA=0x03D7DD30  token=0x600082D  System.Void .ctor(Unity.Mathematics.uint2 v)
  RVA=0x09C61724  token=0x600082E  System.Void .ctor(Unity.Mathematics.half v)
  RVA=0x09C616E4  token=0x600082F  System.Void .ctor(Unity.Mathematics.half2 v)
  RVA=0x03D7DD50  token=0x6000830  System.Void .ctor(System.Single v)
  RVA=0x03D7DC90  token=0x6000831  System.Void .ctor(Unity.Mathematics.float2 v)
  RVA=0x03D79F00  token=0x6000832  Unity.Mathematics.double2 op_Implicit(System.Double v)
  RVA=0x03D79EA0  token=0x6000833  Unity.Mathematics.double2 op_Implicit(System.Int32 v)
  RVA=0x03D79E40  token=0x6000834  Unity.Mathematics.double2 op_Implicit(Unity.Mathematics.int2 v)
  RVA=0x03D79DE0  token=0x6000835  Unity.Mathematics.double2 op_Implicit(System.UInt32 v)
  RVA=0x03D79E70  token=0x6000836  Unity.Mathematics.double2 op_Implicit(Unity.Mathematics.uint2 v)
  RVA=0x03D79EC0  token=0x6000837  Unity.Mathematics.double2 op_Implicit(System.Single v)
  RVA=0x03D79E10  token=0x6000838  Unity.Mathematics.double2 op_Implicit(Unity.Mathematics.float2 v)
  RVA=0x03D7DD90  token=0x6000839  Unity.Mathematics.double2 op_Multiply(Unity.Mathematics.double2 lhs, Unity.Mathematics.double2 rhs)
  RVA=0x03D7DDE0  token=0x600083A  Unity.Mathematics.double2 op_Multiply(Unity.Mathematics.double2 lhs, System.Double rhs)
  RVA=0x03D7DDC0  token=0x600083B  Unity.Mathematics.double2 op_Multiply(System.Double lhs, Unity.Mathematics.double2 rhs)
  RVA=0x03D7DD60  token=0x600083C  Unity.Mathematics.double2 op_Addition(Unity.Mathematics.double2 lhs, Unity.Mathematics.double2 rhs)
  RVA=0x03D7DE20  token=0x600083D  Unity.Mathematics.double2 op_Subtraction(Unity.Mathematics.double2 lhs, Unity.Mathematics.double2 rhs)
  RVA=0x03D7DE00  token=0x600083E  Unity.Mathematics.double2 op_Subtraction(System.Double lhs, Unity.Mathematics.double2 rhs)
  RVA=0x09C61790  token=0x600083F  Unity.Mathematics.double2 op_Division(Unity.Mathematics.double2 lhs, Unity.Mathematics.double2 rhs)
  RVA=0x09C61774  token=0x6000840  Unity.Mathematics.double2 op_Division(System.Double lhs, Unity.Mathematics.double2 rhs)
  RVA=0x09C6180C  token=0x6000841  Unity.Mathematics.bool2 op_LessThan(Unity.Mathematics.double2 lhs, System.Double rhs)
  RVA=0x09C617E8  token=0x6000842  Unity.Mathematics.bool2 op_GreaterThanOrEqual(Unity.Mathematics.double2 lhs, Unity.Mathematics.double2 rhs)
  RVA=0x03D7DE50  token=0x6000843  Unity.Mathematics.double2 op_UnaryNegation(Unity.Mathematics.double2 val)
  RVA=0x09C617B4  token=0x6000844  Unity.Mathematics.bool2 op_Equality(Unity.Mathematics.double2 lhs, System.Double rhs)
  RVA=0x09C5AA84  token=0x6000845  System.Boolean Equals(Unity.Mathematics.double2 rhs)
  RVA=0x09C61560  token=0x6000846  System.Boolean Equals(System.Object o)
  RVA=0x09C372A8  token=0x6000847  System.Int32 GetHashCode()
  RVA=0x09C61654  token=0x6000848  System.String ToString()
  RVA=0x09C615CC  token=0x6000849  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double2x2
TYPE:  sealed struct
TOKEN: 0x2000019
SIZE:  0x30
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.double2       c0  // 0x10
  public            Unity.Mathematics.double2       c1  // 0x20
  public    static readonly Unity.Mathematics.double2x2     identity  // static @ 0x0
METHODS:
  RVA=0x03D553F0  token=0x600084A  System.Void .ctor(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1)
  RVA=0x03D7DEC0  token=0x600084B  System.Void .ctor(System.Double m00, System.Double m01, System.Double m10, System.Double m11)
  RVA=0x03D7DEA0  token=0x600084C  System.Void .ctor(System.Double v)
  RVA=0x04D254A8  token=0x600084D  System.Void .ctor(System.Boolean v)
  RVA=0x04D25428  token=0x600084E  System.Void .ctor(Unity.Mathematics.bool2x2 v)
  RVA=0x03D7DE70  token=0x600084F  System.Void .ctor(System.Int32 v)
  RVA=0x03D7DFE0  token=0x6000850  System.Void .ctor(Unity.Mathematics.int2x2 v)
  RVA=0x03D7DEE0  token=0x6000851  System.Void .ctor(System.UInt32 v)
  RVA=0x03D7DF60  token=0x6000852  System.Void .ctor(Unity.Mathematics.uint2x2 v)
  RVA=0x03D7DFB0  token=0x6000853  System.Void .ctor(System.Single v)
  RVA=0x03D7DF20  token=0x6000854  System.Void .ctor(Unity.Mathematics.float2x2 v)
  RVA=0x09C61BC8  token=0x6000855  Unity.Mathematics.double2x2 op_Multiply(Unity.Mathematics.double2x2 lhs, System.Double rhs)
  RVA=0x09C61828  token=0x6000856  System.Boolean Equals(Unity.Mathematics.double2x2 rhs)
  RVA=0x09C61870  token=0x6000857  System.Boolean Equals(System.Object o)
  RVA=0x09C618E4  token=0x6000858  System.Int32 GetHashCode()
  RVA=0x09C61908  token=0x6000859  System.String ToString()
  RVA=0x09C61A74  token=0x600085A  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x03CE5E50  token=0x600085B  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.double2x3
TYPE:  sealed struct
TOKEN: 0x200001A
SIZE:  0x40
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.double2       c0  // 0x10
  public            Unity.Mathematics.double2       c1  // 0x20
  public            Unity.Mathematics.double2       c2  // 0x30
METHODS:
  RVA=0x03D6B600  token=0x600085C  System.Void .ctor(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1, Unity.Mathematics.double2 c2)
  RVA=0x03D7E190  token=0x600085D  System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12)
  RVA=0x03D7E120  token=0x600085E  System.Void .ctor(System.Double v)
  RVA=0x04D25534  token=0x600085F  System.Void .ctor(System.Boolean v)
  RVA=0x04D25568  token=0x6000860  System.Void .ctor(Unity.Mathematics.bool2x3 v)
  RVA=0x03D7E280  token=0x6000861  System.Void .ctor(System.Int32 v)
  RVA=0x03D7E030  token=0x6000862  System.Void .ctor(Unity.Mathematics.int2x3 v)
  RVA=0x03D7E220  token=0x6000863  System.Void .ctor(System.UInt32 v)
  RVA=0x03D7E0A0  token=0x6000864  System.Void .ctor(Unity.Mathematics.uint2x3 v)
  RVA=0x03D7E140  token=0x6000865  System.Void .ctor(System.Single v)
  RVA=0x03D7E1C0  token=0x6000866  System.Void .ctor(Unity.Mathematics.float2x3 v)
  RVA=0x09C61C24  token=0x6000867  System.Boolean Equals(Unity.Mathematics.double2x3 rhs)
  RVA=0x09C61C84  token=0x6000868  System.Boolean Equals(System.Object o)
  RVA=0x09C61D00  token=0x6000869  System.Int32 GetHashCode()
  RVA=0x09C61EE4  token=0x600086A  System.String ToString()
  RVA=0x09C61D30  token=0x600086B  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double2x4
TYPE:  sealed struct
TOKEN: 0x200001B
SIZE:  0x50
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.double2       c0  // 0x10
  public            Unity.Mathematics.double2       c1  // 0x20
  public            Unity.Mathematics.double2       c2  // 0x30
  public            Unity.Mathematics.double2       c3  // 0x40
METHODS:
  RVA=0x03D7E4A0  token=0x600086C  System.Void .ctor(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1, Unity.Mathematics.double2 c2, Unity.Mathematics.double2 c3)
  RVA=0x03D7E4D0  token=0x600086D  System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13)
  RVA=0x03D7E520  token=0x600086E  System.Void .ctor(System.Double v)
  RVA=0x04D256F8  token=0x600086F  System.Void .ctor(System.Boolean v)
  RVA=0x04D25618  token=0x6000870  System.Void .ctor(Unity.Mathematics.bool2x4 v)
  RVA=0x03D7E3D0  token=0x6000871  System.Void .ctor(System.Int32 v)
  RVA=0x03D7E5C0  token=0x6000872  System.Void .ctor(Unity.Mathematics.int2x4 v)
  RVA=0x03D7E540  token=0x6000873  System.Void .ctor(System.UInt32 v)
  RVA=0x03D7E330  token=0x6000874  System.Void .ctor(Unity.Mathematics.uint2x4 v)
  RVA=0x03D7E2D0  token=0x6000875  System.Void .ctor(System.Single v)
  RVA=0x03D7E430  token=0x6000876  System.Void .ctor(Unity.Mathematics.float2x4 v)
  RVA=0x09C620C4  token=0x6000877  System.Boolean Equals(Unity.Mathematics.double2x4 rhs)
  RVA=0x09C62140  token=0x6000878  System.Boolean Equals(System.Object o)
  RVA=0x09C621C4  token=0x6000879  System.Int32 GetHashCode()
  RVA=0x09C62410  token=0x600087A  System.String ToString()
  RVA=0x09C621FC  token=0x600087B  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double3
TYPE:  sealed struct
TOKEN: 0x200001C
SIZE:  0x28
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            System.Double                   x  // 0x10
  public            System.Double                   y  // 0x18
  public            System.Double                   z  // 0x20
  public    static readonly Unity.Mathematics.double3       zero  // static @ 0x0
PROPERTIES:
  yzx  get=0x03D7E7C0
  zxy  get=0x03D7E7E0
  Item  get=0x03D7E7B0
METHODS:
  RVA=0x03D7E7A0  token=0x600087C  System.Void .ctor(System.Double x, System.Double y, System.Double z)
  RVA=0x03D7E6D0  token=0x600087D  System.Void .ctor(System.Double x, Unity.Mathematics.double2 yz)
  RVA=0x03D7E690  token=0x600087E  System.Void .ctor(Unity.Mathematics.double2 xy, System.Double z)
  RVA=0x03D7E710  token=0x600087F  System.Void .ctor(Unity.Mathematics.double3 xyz)
  RVA=0x03D7E730  token=0x6000880  System.Void .ctor(System.Double v)
  RVA=0x04D25778  token=0x6000881  System.Void .ctor(System.Boolean v)
  RVA=0x04D2573C  token=0x6000882  System.Void .ctor(Unity.Mathematics.bool3 v)
  RVA=0x03D7E6F0  token=0x6000883  System.Void .ctor(System.Int32 v)
  RVA=0x03D7E6B0  token=0x6000884  System.Void .ctor(Unity.Mathematics.int3 v)
  RVA=0x03D7E740  token=0x6000885  System.Void .ctor(System.UInt32 v)
  RVA=0x03D7E770  token=0x6000886  System.Void .ctor(Unity.Mathematics.uint3 v)
  RVA=0x09C6286C  token=0x6000887  System.Void .ctor(Unity.Mathematics.half v)
  RVA=0x09C628BC  token=0x6000888  System.Void .ctor(Unity.Mathematics.half3 v)
  RVA=0x03D7E670  token=0x6000889  System.Void .ctor(System.Single v)
  RVA=0x03D7E650  token=0x600088A  System.Void .ctor(Unity.Mathematics.float3 v)
  RVA=0x03D7A0C0  token=0x600088B  Unity.Mathematics.double3 op_Implicit(System.Double v)
  RVA=0x03D7A180  token=0x600088C  Unity.Mathematics.double3 op_Implicit(System.Int32 v)
  RVA=0x03D7A020  token=0x600088D  Unity.Mathematics.double3 op_Implicit(Unity.Mathematics.int3 v)
  RVA=0x03D7A070  token=0x600088E  Unity.Mathematics.double3 op_Implicit(System.UInt32 v)
  RVA=0x03D7A0F0  token=0x600088F  Unity.Mathematics.double3 op_Implicit(Unity.Mathematics.uint3 v)
  RVA=0x03D79FF0  token=0x6000890  Unity.Mathematics.double3 op_Implicit(System.Single v)
  RVA=0x0337F9A0  token=0x6000891  Unity.Mathematics.double3 op_Implicit(Unity.Mathematics.float3 v)
  RVA=0x03D7E8A0  token=0x6000892  Unity.Mathematics.double3 op_Multiply(Unity.Mathematics.double3 lhs, Unity.Mathematics.double3 rhs)
  RVA=0x03D7E880  token=0x6000893  Unity.Mathematics.double3 op_Multiply(Unity.Mathematics.double3 lhs, System.Double rhs)
  RVA=0x03D7E860  token=0x6000894  Unity.Mathematics.double3 op_Multiply(System.Double lhs, Unity.Mathematics.double3 rhs)
  RVA=0x03D7E820  token=0x6000895  Unity.Mathematics.double3 op_Addition(Unity.Mathematics.double3 lhs, Unity.Mathematics.double3 rhs)
  RVA=0x03D7E800  token=0x6000896  Unity.Mathematics.double3 op_Addition(Unity.Mathematics.double3 lhs, System.Double rhs)
  RVA=0x03D7E900  token=0x6000897  Unity.Mathematics.double3 op_Subtraction(Unity.Mathematics.double3 lhs, Unity.Mathematics.double3 rhs)
  RVA=0x03D7E8E0  token=0x6000898  Unity.Mathematics.double3 op_Subtraction(Unity.Mathematics.double3 lhs, System.Double rhs)
  RVA=0x03D7E940  token=0x6000899  Unity.Mathematics.double3 op_Subtraction(System.Double lhs, Unity.Mathematics.double3 rhs)
  RVA=0x09C62910  token=0x600089A  Unity.Mathematics.double3 op_Division(Unity.Mathematics.double3 lhs, Unity.Mathematics.double3 rhs)
  RVA=0x09C62944  token=0x600089B  Unity.Mathematics.double3 op_Division(Unity.Mathematics.double3 lhs, System.Double rhs)
  RVA=0x09C62964  token=0x600089C  Unity.Mathematics.double3 op_Division(System.Double lhs, Unity.Mathematics.double3 rhs)
  RVA=0x09C62A4C  token=0x600089D  Unity.Mathematics.bool3 op_LessThan(Unity.Mathematics.double3 lhs, System.Double rhs)
  RVA=0x09C62A10  token=0x600089E  Unity.Mathematics.bool3 op_LessThanOrEqual(Unity.Mathematics.double3 lhs, Unity.Mathematics.double3 rhs)
  RVA=0x09C629D8  token=0x600089F  Unity.Mathematics.bool3 op_GreaterThanOrEqual(Unity.Mathematics.double3 lhs, Unity.Mathematics.double3 rhs)
  RVA=0x03D7E970  token=0x60008A0  Unity.Mathematics.double3 op_UnaryNegation(Unity.Mathematics.double3 val)
  RVA=0x09C62990  token=0x60008A1  Unity.Mathematics.bool3 op_Equality(Unity.Mathematics.double3 lhs, System.Double rhs)
  RVA=0x054F18F8  token=0x60008A5  System.Boolean Equals(Unity.Mathematics.double3 rhs)
  RVA=0x09C62660  token=0x60008A6  System.Boolean Equals(System.Object o)
  RVA=0x09C626D4  token=0x60008A7  System.Int32 GetHashCode()
  RVA=0x09C627AC  token=0x60008A8  System.String ToString()
  RVA=0x09C626FC  token=0x60008A9  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double3x2
TYPE:  sealed struct
TOKEN: 0x200001E
SIZE:  0x40
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.double3       c0  // 0x10
  public            Unity.Mathematics.double3       c1  // 0x28
METHODS:
  RVA=0x03D6B590  token=0x60008AA  System.Void .ctor(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1)
  RVA=0x03D7E9E0  token=0x60008AB  System.Void .ctor(System.Double m00, System.Double m01, System.Double m10, System.Double m11, System.Double m20, System.Double m21)
  RVA=0x03D7EA80  token=0x60008AC  System.Void .ctor(System.Double v)
  RVA=0x04D25C14  token=0x60008AD  System.Void .ctor(System.Boolean v)
  RVA=0x09C62EB0  token=0x60008AE  System.Void .ctor(Unity.Mathematics.bool3x2 v)
  RVA=0x03D7EAB0  token=0x60008AF  System.Void .ctor(System.Int32 v)
  RVA=0x04D25CE8  token=0x60008B0  System.Void .ctor(Unity.Mathematics.int3x2 v)
  RVA=0x03D7EA20  token=0x60008B1  System.Void .ctor(System.UInt32 v)
  RVA=0x04D25A1C  token=0x60008B2  System.Void .ctor(Unity.Mathematics.uint3x2 v)
  RVA=0x03D7E9A0  token=0x60008B3  System.Void .ctor(System.Single v)
  RVA=0x04D25A94  token=0x60008B4  System.Void .ctor(Unity.Mathematics.float3x2 v)
  RVA=0x09C3120C  token=0x60008B5  Unity.Mathematics.double3x2 op_Implicit(System.Int32 v)
  RVA=0x09C310B8  token=0x60008B6  Unity.Mathematics.double3x2 op_Implicit(Unity.Mathematics.float3x2 v)
  RVA=0x09C6310C  token=0x60008B7  Unity.Mathematics.double3x2 op_Multiply(Unity.Mathematics.double3x2 lhs, System.Double rhs)
  RVA=0x09C62FB4  token=0x60008B8  Unity.Mathematics.double3x2 op_Addition(Unity.Mathematics.double3x2 lhs, Unity.Mathematics.double3x2 rhs)
  RVA=0x09C63190  token=0x60008B9  Unity.Mathematics.double3x2 op_Subtraction(Unity.Mathematics.double3x2 lhs, Unity.Mathematics.double3x2 rhs)
  RVA=0x09C63078  token=0x60008BA  Unity.Mathematics.double3x2 op_Division(Unity.Mathematics.double3x2 lhs, System.Double rhs)
  RVA=0x05538B4C  token=0x60008BB  System.Boolean Equals(Unity.Mathematics.double3x2 rhs)
  RVA=0x09C62A70  token=0x60008BC  System.Boolean Equals(System.Object o)
  RVA=0x09C62AEC  token=0x60008BD  System.Int32 GetHashCode()
  RVA=0x09C62CD0  token=0x60008BE  System.String ToString()
  RVA=0x09C62B1C  token=0x60008BF  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double3x3
TYPE:  sealed struct
TOKEN: 0x200001F
SIZE:  0x58
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.double3       c0  // 0x10
  public            Unity.Mathematics.double3       c1  // 0x28
  public            Unity.Mathematics.double3       c2  // 0x40
  public    static readonly Unity.Mathematics.double3x3     identity  // static @ 0x0
PROPERTIES:
  Item  get=0x03D7ED40
METHODS:
  RVA=0x03D7EB60  token=0x60008C0  System.Void .ctor(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1, Unity.Mathematics.double3 c2)
  RVA=0x03D7ECE0  token=0x60008C1  System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12, System.Double m20, System.Double m21, System.Double m22)
  RVA=0x03D7EBA0  token=0x60008C2  System.Void .ctor(System.Double v)
  RVA=0x04D260C8  token=0x60008C3  System.Void .ctor(System.Boolean v)
  RVA=0x09C6388C  token=0x60008C4  System.Void .ctor(Unity.Mathematics.bool3x3 v)
  RVA=0x03D7EC70  token=0x60008C5  System.Void .ctor(System.Int32 v)
  RVA=0x04D26020  token=0x60008C6  System.Void .ctor(Unity.Mathematics.int3x3 v)
  RVA=0x03D7EBE0  token=0x60008C7  System.Void .ctor(System.UInt32 v)
  RVA=0x04D25F78  token=0x60008C8  System.Void .ctor(Unity.Mathematics.uint3x3 v)
  RVA=0x03D7EB00  token=0x60008C9  System.Void .ctor(System.Single v)
  RVA=0x04D25D60  token=0x60008CA  System.Void .ctor(Unity.Mathematics.float3x3 v)
  RVA=0x09C639F8  token=0x60008CB  Unity.Mathematics.double3x3 op_Multiply(Unity.Mathematics.double3x3 lhs, System.Double rhs)
  RVA=0x09C632E8  token=0x60008CD  System.Boolean Equals(Unity.Mathematics.double3x3 rhs)
  RVA=0x09C63254  token=0x60008CE  System.Boolean Equals(System.Object o)
  RVA=0x09C6337C  token=0x60008CF  System.Int32 GetHashCode()
  RVA=0x09C633C0  token=0x60008D0  System.String ToString()
  RVA=0x09C63648  token=0x60008D1  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x03B5BB30  token=0x60008D2  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.double3x4
TYPE:  sealed struct
TOKEN: 0x2000020
SIZE:  0x70
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.double3       c0  // 0x10
  public            Unity.Mathematics.double3       c1  // 0x28
  public            Unity.Mathematics.double3       c2  // 0x40
  public            Unity.Mathematics.double3       c3  // 0x58
PROPERTIES:
  Item  get=0x03D7ED40
METHODS:
  RVA=0x03D7ED50  token=0x60008D3  System.Void .ctor(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1, Unity.Mathematics.double3 c2, Unity.Mathematics.double3 c3)
  RVA=0x03D7EDA0  token=0x60008D4  System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13, System.Double m20, System.Double m21, System.Double m22, System.Double m23)
  RVA=0x03D7EF60  token=0x60008D5  System.Void .ctor(System.Double v)
  RVA=0x04D26584  token=0x60008D6  System.Void .ctor(System.Boolean v)
  RVA=0x09C64294  token=0x60008D7  System.Void .ctor(Unity.Mathematics.bool3x4 v)
  RVA=0x03D7EE20  token=0x60008D8  System.Void .ctor(System.Int32 v)
  RVA=0x04D264A8  token=0x60008D9  System.Void .ctor(Unity.Mathematics.int3x4 v)
  RVA=0x03D7EEA0  token=0x60008DA  System.Void .ctor(System.UInt32 v)
  RVA=0x04D263CC  token=0x60008DB  System.Void .ctor(Unity.Mathematics.uint3x4 v)
  RVA=0x03D7EFB0  token=0x60008DC  System.Void .ctor(System.Single v)
  RVA=0x04D26700  token=0x60008DD  System.Void .ctor(Unity.Mathematics.float3x4 v)
  RVA=0x09C31424  token=0x60008DE  Unity.Mathematics.double3x4 op_Implicit(System.Int32 v)
  RVA=0x09C63ABC  token=0x60008E0  System.Boolean Equals(Unity.Mathematics.double3x4 rhs)
  RVA=0x09C63BA4  token=0x60008E1  System.Boolean Equals(System.Object o)
  RVA=0x09C63C44  token=0x60008E2  System.Int32 GetHashCode()
  RVA=0x09C63F64  token=0x60008E3  System.String ToString()
  RVA=0x09C63C90  token=0x60008E4  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double4
TYPE:  sealed struct
TOKEN: 0x2000021
SIZE:  0x30
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            System.Double                   x  // 0x10
  public            System.Double                   y  // 0x18
  public            System.Double                   z  // 0x20
  public            System.Double                   w  // 0x28
  public    static readonly Unity.Mathematics.double4       zero  // static @ 0x0
PROPERTIES:
  xyz  get=0x03D7F230  set=0x03D7E710
  Item  get=0x03D7E7B0  set=0x03D7F3E0
METHODS:
  RVA=0x03D7F0F0  token=0x60008E5  System.Void .ctor(System.Double x, System.Double y, System.Double z, System.Double w)
  RVA=0x03D7F070  token=0x60008E6  System.Void .ctor(System.Double x, System.Double y, Unity.Mathematics.double2 zw)
  RVA=0x03D7F090  token=0x60008E7  System.Void .ctor(System.Double x, Unity.Mathematics.double2 yz, System.Double w)
  RVA=0x03D7F0D0  token=0x60008E8  System.Void .ctor(System.Double x, Unity.Mathematics.double3 yzw)
  RVA=0x03D7F1D0  token=0x60008E9  System.Void .ctor(Unity.Mathematics.double2 xy, System.Double z, System.Double w)
  RVA=0x03D7F0B0  token=0x60008EA  System.Void .ctor(Unity.Mathematics.double2 xy, Unity.Mathematics.double2 zw)
  RVA=0x03D7F1B0  token=0x60008EB  System.Void .ctor(Unity.Mathematics.double3 xyz, System.Double w)
  RVA=0x03D7F050  token=0x60008EC  System.Void .ctor(Unity.Mathematics.double4 xyzw)
  RVA=0x03D7F1F0  token=0x60008ED  System.Void .ctor(System.Double v)
  RVA=0x04D26850  token=0x60008EE  System.Void .ctor(System.Boolean v)
  RVA=0x04D268F8  token=0x60008EF  System.Void .ctor(Unity.Mathematics.bool4 v)
  RVA=0x03D7F110  token=0x60008F0  System.Void .ctor(System.Int32 v)
  RVA=0x03D7F190  token=0x60008F1  System.Void .ctor(Unity.Mathematics.int4 v)
  RVA=0x03D7F200  token=0x60008F2  System.Void .ctor(System.UInt32 v)
  RVA=0x03D7F140  token=0x60008F3  System.Void .ctor(Unity.Mathematics.uint4 v)
  RVA=0x04D26894  token=0x60008F4  System.Void .ctor(Unity.Mathematics.half v)
  RVA=0x04D267DC  token=0x60008F5  System.Void .ctor(Unity.Mathematics.half4 v)
  RVA=0x03D7F030  token=0x60008F6  System.Void .ctor(System.Single v)
  RVA=0x03D7F180  token=0x60008F7  System.Void .ctor(Unity.Mathematics.float4 v)
  RVA=0x03D7A2D0  token=0x60008F8  Unity.Mathematics.double4 op_Implicit(System.Double v)
  RVA=0x03D7A330  token=0x60008F9  Unity.Mathematics.double4 op_Implicit(System.Int32 v)
  RVA=0x09C31698  token=0x60008FA  Unity.Mathematics.double4 op_Implicit(Unity.Mathematics.int4 v)
  RVA=0x03D7A3F0  token=0x60008FB  Unity.Mathematics.double4 op_Implicit(System.UInt32 v)
  RVA=0x09C316C0  token=0x60008FC  Unity.Mathematics.double4 op_Implicit(Unity.Mathematics.uint4 v)
  RVA=0x03D7A2E0  token=0x60008FD  Unity.Mathematics.double4 op_Implicit(System.Single v)
  RVA=0x09C31654  token=0x60008FE  Unity.Mathematics.double4 op_Implicit(Unity.Mathematics.float4 v)
  RVA=0x03D7F2C0  token=0x60008FF  Unity.Mathematics.double4 op_Multiply(Unity.Mathematics.double4 lhs, Unity.Mathematics.double4 rhs)
  RVA=0x03D7F2A0  token=0x6000900  Unity.Mathematics.double4 op_Multiply(Unity.Mathematics.double4 lhs, System.Double rhs)
  RVA=0x03D7F310  token=0x6000901  Unity.Mathematics.double4 op_Multiply(System.Double lhs, Unity.Mathematics.double4 rhs)
  RVA=0x03D7F250  token=0x6000902  Unity.Mathematics.double4 op_Addition(Unity.Mathematics.double4 lhs, Unity.Mathematics.double4 rhs)
  RVA=0x03D7F370  token=0x6000903  Unity.Mathematics.double4 op_Subtraction(Unity.Mathematics.double4 lhs, Unity.Mathematics.double4 rhs)
  RVA=0x03D7F330  token=0x6000904  Unity.Mathematics.double4 op_Subtraction(System.Double lhs, Unity.Mathematics.double4 rhs)
  RVA=0x09C6480C  token=0x6000905  Unity.Mathematics.double4 op_Division(Unity.Mathematics.double4 lhs, Unity.Mathematics.double4 rhs)
  RVA=0x09C64850  token=0x6000906  Unity.Mathematics.double4 op_Division(System.Double lhs, Unity.Mathematics.double4 rhs)
  RVA=0x09C64934  token=0x6000907  Unity.Mathematics.bool4 op_LessThan(Unity.Mathematics.double4 lhs, System.Double rhs)
  RVA=0x09C648EC  token=0x6000908  Unity.Mathematics.bool4 op_GreaterThanOrEqual(Unity.Mathematics.double4 lhs, Unity.Mathematics.double4 rhs)
  RVA=0x03D7F3C0  token=0x6000909  Unity.Mathematics.double4 op_UnaryNegation(Unity.Mathematics.double4 val)
  RVA=0x09C64888  token=0x600090A  Unity.Mathematics.bool4 op_Equality(Unity.Mathematics.double4 lhs, System.Double rhs)
  RVA=0x09C644E0  token=0x600090F  System.Boolean Equals(Unity.Mathematics.double4 rhs)
  RVA=0x09C6446C  token=0x6000910  System.Boolean Equals(System.Object o)
  RVA=0x09C64528  token=0x6000911  System.Int32 GetHashCode()
  RVA=0x09C6454C  token=0x6000912  System.String ToString()
  RVA=0x09C646B8  token=0x6000913  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double4x2
TYPE:  sealed struct
TOKEN: 0x2000023
SIZE:  0x50
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.double4       c0  // 0x10
  public            Unity.Mathematics.double4       c1  // 0x30
METHODS:
  RVA=0x03D7F4B0  token=0x6000914  System.Void .ctor(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1)
  RVA=0x03D7F3F0  token=0x6000915  System.Void .ctor(System.Double m00, System.Double m01, System.Double m10, System.Double m11, System.Double m20, System.Double m21, System.Double m30, System.Double m31)
  RVA=0x03D7F440  token=0x6000916  System.Void .ctor(System.Double v)
  RVA=0x04D26DF4  token=0x6000917  System.Void .ctor(System.Boolean v)
  RVA=0x04D26D50  token=0x6000918  System.Void .ctor(Unity.Mathematics.bool4x2 v)
  RVA=0x03D7F4D0  token=0x6000919  System.Void .ctor(System.Int32 v)
  RVA=0x09C64EE4  token=0x600091A  System.Void .ctor(Unity.Mathematics.int4x2 v)
  RVA=0x04D26CA8  token=0x600091B  System.Void .ctor(System.UInt32 v)
  RVA=0x09C64F48  token=0x600091C  System.Void .ctor(Unity.Mathematics.uint4x2 v)
  RVA=0x03D7F470  token=0x600091D  System.Void .ctor(System.Single v)
  RVA=0x09C64FAC  token=0x600091E  System.Void .ctor(Unity.Mathematics.float4x2 v)
  RVA=0x09C649E4  token=0x600091F  System.Boolean Equals(Unity.Mathematics.double4x2 rhs)
  RVA=0x09C64960  token=0x6000920  System.Boolean Equals(System.Object o)
  RVA=0x09C64A48  token=0x6000921  System.Int32 GetHashCode()
  RVA=0x09C64C94  token=0x6000922  System.String ToString()
  RVA=0x09C64A80  token=0x6000923  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double4x3
TYPE:  sealed struct
TOKEN: 0x2000024
SIZE:  0x70
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.double4       c0  // 0x10
  public            Unity.Mathematics.double4       c1  // 0x30
  public            Unity.Mathematics.double4       c2  // 0x50
METHODS:
  RVA=0x03D7F6D0  token=0x6000924  System.Void .ctor(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1, Unity.Mathematics.double4 c2)
  RVA=0x03D7F5D0  token=0x6000925  System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12, System.Double m20, System.Double m21, System.Double m22, System.Double m30, System.Double m31, System.Double m32)
  RVA=0x03D7F520  token=0x6000926  System.Void .ctor(System.Double v)
  RVA=0x04D271D8  token=0x6000927  System.Void .ctor(System.Boolean v)
  RVA=0x04D27100  token=0x6000928  System.Void .ctor(Unity.Mathematics.bool4x3 v)
  RVA=0x03D7F660  token=0x6000929  System.Void .ctor(System.Int32 v)
  RVA=0x09C65810  token=0x600092A  System.Void .ctor(Unity.Mathematics.int4x3 v)
  RVA=0x04D270A4  token=0x600092B  System.Void .ctor(System.UInt32 v)
  RVA=0x09C658A0  token=0x600092C  System.Void .ctor(Unity.Mathematics.uint4x3 v)
  RVA=0x03D7F570  token=0x600092D  System.Void .ctor(System.Single v)
  RVA=0x09C65780  token=0x600092E  System.Void .ctor(Unity.Mathematics.float4x3 v)
  RVA=0x09C318F8  token=0x600092F  Unity.Mathematics.double4x3 op_Implicit(System.Int32 v)
  RVA=0x09C319FC  token=0x6000930  Unity.Mathematics.double4x3 op_Implicit(Unity.Mathematics.float4x3 v)
  RVA=0x09C65930  token=0x6000931  Unity.Mathematics.double4x3 op_Multiply(Unity.Mathematics.double4x3 lhs, Unity.Mathematics.double4x3 rhs)
  RVA=0x09C65010  token=0x6000932  System.Boolean Equals(Unity.Mathematics.double4x3 rhs)
  RVA=0x09C65090  token=0x6000933  System.Boolean Equals(System.Object o)
  RVA=0x09C65130  token=0x6000934  System.Int32 GetHashCode()
  RVA=0x09C65450  token=0x6000935  System.String ToString()
  RVA=0x09C6517C  token=0x6000936  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double4x4
TYPE:  sealed struct
TOKEN: 0x2000025
SIZE:  0x90
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.double4       c0  // 0x10
  public            Unity.Mathematics.double4       c1  // 0x30
  public            Unity.Mathematics.double4       c2  // 0x50
  public            Unity.Mathematics.double4       c3  // 0x70
  public    static readonly Unity.Mathematics.double4x4     identity  // static @ 0x0
  public    static readonly Unity.Mathematics.double4x4     zero  // static @ 0x80
METHODS:
  RVA=0x03D7F7E0  token=0x6000937  System.Void .ctor(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1, Unity.Mathematics.double4 c2, Unity.Mathematics.double4 c3)
  RVA=0x03A37140  token=0x6000938  System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13, System.Double m20, System.Double m21, System.Double m22, System.Double m23, System.Double m30, System.Double m31, System.Double m32, System.Double m33)
  RVA=0x03D7F780  token=0x6000939  System.Void .ctor(System.Double v)
  RVA=0x04D27390  token=0x600093A  System.Void .ctor(System.Boolean v)
  RVA=0x04D27470  token=0x600093B  System.Void .ctor(Unity.Mathematics.bool4x4 v)
  RVA=0x03D7F830  token=0x600093C  System.Void .ctor(System.Int32 v)
  RVA=0x09C664FC  token=0x600093D  System.Void .ctor(Unity.Mathematics.int4x4 v)
  RVA=0x04D273F8  token=0x600093E  System.Void .ctor(System.UInt32 v)
  RVA=0x09C66448  token=0x600093F  System.Void .ctor(Unity.Mathematics.uint4x4 v)
  RVA=0x03D7F710  token=0x6000940  System.Void .ctor(System.Single v)
  RVA=0x09C66394  token=0x6000941  System.Void .ctor(Unity.Mathematics.float4x4 v)
  RVA=0x09C31BA4  token=0x6000942  Unity.Mathematics.double4x4 op_Implicit(Unity.Mathematics.float4x4 v)
  RVA=0x09C65A38  token=0x6000943  System.Boolean Equals(Unity.Mathematics.double4x4 rhs)
  RVA=0x09C65ADC  token=0x6000944  System.Boolean Equals(System.Object o)
  RVA=0x09C65B94  token=0x6000945  System.Int32 GetHashCode()
  RVA=0x09C65F84  token=0x6000946  System.String ToString()
  RVA=0x09C65BF0  token=0x6000947  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x03A37010  token=0x6000948  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.float2
TYPE:  sealed struct
TOKEN: 0x2000026
SIZE:  0x18
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            System.Single                   x  // 0x10
  public            System.Single                   y  // 0x14
  public    static readonly Unity.Mathematics.float2        zero  // static @ 0x0
PROPERTIES:
  xyxy  get=0x03D7F9D0
  xy  get=0x03D51540
  yx  get=0x03D7F9F0
METHODS:
  RVA=0x03D50430  token=0x6000949  System.Void .ctor(System.Single x, System.Single y)
  RVA=0x03D7F900  token=0x600094A  System.Void .ctor(Unity.Mathematics.float2 xy)
  RVA=0x03D7F8C0  token=0x600094B  System.Void .ctor(System.Single v)
  RVA=0x09C6676C  token=0x600094C  System.Void .ctor(System.Boolean v)
  RVA=0x04D27638  token=0x600094D  System.Void .ctor(Unity.Mathematics.bool2 v)
  RVA=0x03D7F970  token=0x600094E  System.Void .ctor(System.Int32 v)
  RVA=0x03D7F950  token=0x600094F  System.Void .ctor(Unity.Mathematics.int2 v)
  RVA=0x03D7F920  token=0x6000950  System.Void .ctor(System.UInt32 v)
  RVA=0x03D7F8D0  token=0x6000951  System.Void .ctor(Unity.Mathematics.uint2 v)
  RVA=0x09C66788  token=0x6000952  System.Void .ctor(Unity.Mathematics.half v)
  RVA=0x09C667B4  token=0x6000953  System.Void .ctor(Unity.Mathematics.half2 v)
  RVA=0x03D7F990  token=0x6000954  System.Void .ctor(System.Double v)
  RVA=0x03D7F9B0  token=0x6000955  System.Void .ctor(Unity.Mathematics.double2 v)
  RVA=0x03D543C0  token=0x6000956  Unity.Mathematics.float2 op_Implicit(System.Single v)
  RVA=0x03D7A730  token=0x6000957  Unity.Mathematics.float2 op_Implicit(System.Int32 v)
  RVA=0x03D7A750  token=0x6000958  Unity.Mathematics.float2 op_Implicit(Unity.Mathematics.int2 v)
  RVA=0x03D7A7A0  token=0x6000959  Unity.Mathematics.float2 op_Implicit(System.UInt32 v)
  RVA=0x03D7A770  token=0x600095A  Unity.Mathematics.float2 op_Implicit(Unity.Mathematics.uint2 v)
  RVA=0x03D7A7D0  token=0x600095B  Unity.Mathematics.float2 op_Explicit(System.Double v)
  RVA=0x03D7A700  token=0x600095C  Unity.Mathematics.float2 op_Explicit(Unity.Mathematics.double2 v)
  RVA=0x03D734A0  token=0x600095D  Unity.Mathematics.float2 op_Multiply(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs)
  RVA=0x03D73470  token=0x600095E  Unity.Mathematics.float2 op_Multiply(Unity.Mathematics.float2 lhs, System.Single rhs)
  RVA=0x03D7FA60  token=0x600095F  Unity.Mathematics.float2 op_Multiply(System.Single lhs, Unity.Mathematics.float2 rhs)
  RVA=0x03D73400  token=0x6000960  Unity.Mathematics.float2 op_Addition(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs)
  RVA=0x03D73440  token=0x6000961  Unity.Mathematics.float2 op_Addition(Unity.Mathematics.float2 lhs, System.Single rhs)
  RVA=0x03D73510  token=0x6000962  Unity.Mathematics.float2 op_Subtraction(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs)
  RVA=0x03D734E0  token=0x6000963  Unity.Mathematics.float2 op_Subtraction(Unity.Mathematics.float2 lhs, System.Single rhs)
  RVA=0x03D7FA90  token=0x6000964  Unity.Mathematics.float2 op_Subtraction(System.Single lhs, Unity.Mathematics.float2 rhs)
  RVA=0x0950B3B4  token=0x6000965  Unity.Mathematics.float2 op_Division(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs)
  RVA=0x0950B8A0  token=0x6000966  Unity.Mathematics.float2 op_Division(Unity.Mathematics.float2 lhs, System.Single rhs)
  RVA=0x09C667E4  token=0x6000967  Unity.Mathematics.float2 op_Division(System.Single lhs, Unity.Mathematics.float2 rhs)
  RVA=0x03D7FA10  token=0x6000968  Unity.Mathematics.float2 op_Modulus(Unity.Mathematics.float2 lhs, System.Single rhs)
  RVA=0x09C668AC  token=0x6000969  Unity.Mathematics.bool2 op_LessThan(Unity.Mathematics.float2 lhs, System.Single rhs)
  RVA=0x09C66874  token=0x600096A  Unity.Mathematics.bool2 op_LessThanOrEqual(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs)
  RVA=0x09C6683C  token=0x600096B  Unity.Mathematics.bool2 op_GreaterThanOrEqual(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs)
  RVA=0x03D7FAB0  token=0x600096C  Unity.Mathematics.float2 op_UnaryNegation(Unity.Mathematics.float2 val)
  RVA=0x09C66804  token=0x600096D  Unity.Mathematics.bool2 op_Equality(Unity.Mathematics.float2 lhs, System.Single rhs)
  RVA=0x0950B3E8  token=0x6000971  System.Boolean Equals(Unity.Mathematics.float2 rhs)
  RVA=0x09C665B0  token=0x6000972  System.Boolean Equals(System.Object o)
  RVA=0x09C66620  token=0x6000973  System.Int32 GetHashCode()
  RVA=0x09C666DC  token=0x6000974  System.String ToString()
  RVA=0x09C66654  token=0x6000975  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x03D730E0  token=0x6000976  UnityEngine.Vector2 op_Implicit(Unity.Mathematics.float2 v)
  RVA=0x03D730E0  token=0x6000977  Unity.Mathematics.float2 op_Implicit(UnityEngine.Vector2 v)
END_CLASS

CLASS: Unity.Mathematics.float2x2
TYPE:  sealed struct
TOKEN: 0x2000028
SIZE:  0x20
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.float2        c0  // 0x10
  public            Unity.Mathematics.float2        c1  // 0x18
  public    static readonly Unity.Mathematics.float2x2      identity  // static @ 0x0
METHODS:
  RVA=0x03D4EA10  token=0x6000978  System.Void .ctor(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1)
  RVA=0x03D7FBC0  token=0x6000979  System.Void .ctor(System.Single m00, System.Single m01, System.Single m10, System.Single m11)
  RVA=0x03D7FB70  token=0x600097A  System.Void .ctor(System.Single v)
  RVA=0x04D276F0  token=0x600097B  System.Void .ctor(System.Boolean v)
  RVA=0x09C66C54  token=0x600097C  System.Void .ctor(Unity.Mathematics.bool2x2 v)
  RVA=0x03D7FB90  token=0x600097D  System.Void .ctor(System.Int32 v)
  RVA=0x03D7FC20  token=0x600097E  System.Void .ctor(Unity.Mathematics.int2x2 v)
  RVA=0x03D7FC60  token=0x600097F  System.Void .ctor(System.UInt32 v)
  RVA=0x03D7FAE0  token=0x6000980  System.Void .ctor(Unity.Mathematics.uint2x2 v)
  RVA=0x03D7FB40  token=0x6000981  System.Void .ctor(System.Double v)
  RVA=0x03D7FBE0  token=0x6000982  System.Void .ctor(Unity.Mathematics.double2x2 v)
  RVA=0x09C66CD0  token=0x6000983  Unity.Mathematics.float2x2 op_Multiply(Unity.Mathematics.float2x2 lhs, System.Single rhs)
  RVA=0x09C668D0  token=0x6000984  System.Boolean Equals(Unity.Mathematics.float2x2 rhs)
  RVA=0x09C6690C  token=0x6000985  System.Boolean Equals(System.Object o)
  RVA=0x09C66978  token=0x6000986  System.Int32 GetHashCode()
  RVA=0x09C66AE8  token=0x6000987  System.String ToString()
  RVA=0x09C66994  token=0x6000988  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x03CF6AF0  token=0x6000989  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.float2x3
TYPE:  sealed struct
TOKEN: 0x2000029
SIZE:  0x28
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.float2        c0  // 0x10
  public            Unity.Mathematics.float2        c1  // 0x18
  public            Unity.Mathematics.float2        c2  // 0x20
METHODS:
  RVA=0x03D54CF0  token=0x600098A  System.Void .ctor(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1, Unity.Mathematics.float2 c2)
  RVA=0x03D7FE00  token=0x600098B  System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12)
  RVA=0x03D7FE80  token=0x600098C  System.Void .ctor(System.Single v)
  RVA=0x04D278AC  token=0x600098D  System.Void .ctor(System.Boolean v)
  RVA=0x09C671E8  token=0x600098E  System.Void .ctor(Unity.Mathematics.bool2x3 v)
  RVA=0x03D7FF10  token=0x600098F  System.Void .ctor(System.Int32 v)
  RVA=0x03D7FDA0  token=0x6000990  System.Void .ctor(Unity.Mathematics.int2x3 v)
  RVA=0x03D7FEA0  token=0x6000991  System.Void .ctor(System.UInt32 v)
  RVA=0x03D7FD10  token=0x6000992  System.Void .ctor(Unity.Mathematics.uint2x3 v)
  RVA=0x03D7FE30  token=0x6000993  System.Void .ctor(System.Double v)
  RVA=0x03D7FCB0  token=0x6000994  System.Void .ctor(Unity.Mathematics.double2x3 v)
  RVA=0x09C66DB0  token=0x6000995  System.Boolean Equals(Unity.Mathematics.float2x3 rhs)
  RVA=0x09C66D3C  token=0x6000996  System.Boolean Equals(System.Object o)
  RVA=0x09C66E2C  token=0x6000997  System.Int32 GetHashCode()
  RVA=0x09C66E54  token=0x6000998  System.String ToString()
  RVA=0x09C67034  token=0x6000999  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.float2x4
TYPE:  sealed struct
TOKEN: 0x200002A
SIZE:  0x30
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.float2        c0  // 0x10
  public            Unity.Mathematics.float2        c1  // 0x18
  public            Unity.Mathematics.float2        c2  // 0x20
  public            Unity.Mathematics.float2        c3  // 0x28
METHODS:
  RVA=0x03D548D0  token=0x600099A  System.Void .ctor(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1, Unity.Mathematics.float2 c2, Unity.Mathematics.float2 c3)
  RVA=0x03D7FF60  token=0x600099B  System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13)
  RVA=0x03D80020  token=0x600099C  System.Void .ctor(System.Single v)
  RVA=0x04D27A2C  token=0x600099D  System.Void .ctor(System.Boolean v)
  RVA=0x09C67824  token=0x600099E  System.Void .ctor(Unity.Mathematics.bool2x4 v)
  RVA=0x03D80290  token=0x600099F  System.Void .ctor(System.Int32 v)
  RVA=0x03D80040  token=0x60009A0  System.Void .ctor(Unity.Mathematics.int2x4 v)
  RVA=0x03D801F0  token=0x60009A1  System.Void .ctor(System.UInt32 v)
  RVA=0x03D800C0  token=0x60009A2  System.Void .ctor(Unity.Mathematics.uint2x4 v)
  RVA=0x03D80180  token=0x60009A3  System.Void .ctor(System.Double v)
  RVA=0x03D7FFB0  token=0x60009A4  System.Void .ctor(Unity.Mathematics.double2x4 v)
  RVA=0x09C672A0  token=0x60009A5  System.Boolean Equals(Unity.Mathematics.float2x4 rhs)
  RVA=0x09C67328  token=0x60009A6  System.Boolean Equals(System.Object o)
  RVA=0x09C6739C  token=0x60009A7  System.Int32 GetHashCode()
  RVA=0x09C675D4  token=0x60009A8  System.String ToString()
  RVA=0x09C673C0  token=0x60009A9  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.float3
TYPE:  sealed struct
TOKEN: 0x200002B
SIZE:  0x1C
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            System.Single                   x  // 0x10
  public            System.Single                   y  // 0x14
  public            System.Single                   z  // 0x18
  public    static readonly Unity.Mathematics.float3        zero  // static @ 0x0
PROPERTIES:
  xxxx  get=0x03D804B0
  xxxy  get=0x03D804D0
  xxxz  get=0x03D804F0
  xxyx  get=0x03D80530
  xxyy  get=0x03D80550
  xxyz  get=0x03D80570
  xxzx  get=0x03D805B0
  xxzy  get=0x03D805D0
  xxzz  get=0x03D805F0
  xyxx  get=0x03D80630
  xyxy  get=0x03D7F9D0
  xyxz  get=0x03D80650
  xyyx  get=0x03D80690
  xyyy  get=0x03D806B0
  xyyz  get=0x03D806D0
  xyzx  get=0x028B4690
  xyzy  get=0x03D806F0
  xyzz  get=0x03D80710
  xzxx  get=0x03D80750
  xzxy  get=0x03D80770
  xzxz  get=0x03D80790
  xzyx  get=0x03D807D0
  xzyy  get=0x03D807F0
  xzyz  get=0x03D80810
  xzzx  get=0x03D80850
  xzzy  get=0x03D80870
  xzzz  get=0x03D80890
  yxxx  get=0x03D808D0
  yxxy  get=0x03D808F0
  yxxz  get=0x03D80910
  yxyx  get=0x03D80950
  yxyy  get=0x03D80970
  yxyz  get=0x03D80990
  yxzx  get=0x03D809D0
  yxzy  get=0x03D809F0
  yxzz  get=0x03D80A10
  yyxx  get=0x03D80A70
  yyxy  get=0x03D80A90
  yyxz  get=0x03D80AB0
  yyyx  get=0x03D80AE0
  yyyy  get=0x03D80B00
  yyyz  get=0x03D80B20
  yyzx  get=0x03D80B60
  yyzy  get=0x03D80B80
  yyzz  get=0x03D80BA0
  yzxx  get=0x03D80BE0
  yzxy  get=0x028B46B0
  yzxz  get=0x028B4710
  yzyx  get=0x03D80C20
  yzyy  get=0x03D80C40
  yzyz  get=0x03D80C60
  yzzx  get=0x03D80CA0
  yzzy  get=0x03D80CC0
  yzzz  get=0x03D80CE0
  zxxx  get=0x03D80D40
  zxxy  get=0x03D80D60
  zxxz  get=0x03D80D80
  zxyx  get=0x03D80DC0
  zxyy  get=0x028B46D0
  zxyz  get=0x028B46F0
  zxzx  get=0x03D80E00
  zxzy  get=0x03D80E20
  zxzz  get=0x03D80E40
  zyxx  get=0x03D80EA0
  zyxy  get=0x03D80EC0
  zyxz  get=0x03D80EE0
  zyyx  get=0x03D80F20
  zyyy  get=0x03D80F40
  zyyz  get=0x03D80F60
  zyzx  get=0x03D80FA0
  zyzy  get=0x03D80FC0
  zyzz  get=0x03D80FE0
  zzxx  get=0x03D81040
  zzxy  get=0x03D81060
  zzxz  get=0x03D81080
  zzyx  get=0x03D810C0
  zzyy  get=0x03D810E0
  zzyz  get=0x03D81100
  zzzx  get=0x03D81130
  zzzy  get=0x03D81150
  zzzz  get=0x03D81170
  xxx  get=0x03D804A0
  xxy  get=0x03D80510
  xxz  get=0x03D80590
  xyx  get=0x03D80610
  xyy  get=0x03D80670
  xyz  get=0x03D514C0  set=0x03D51BE0
  xzx  get=0x03D80730
  xzy  get=0x03D807B0  set=0x03D81360
  xzz  get=0x03D80830
  yxx  get=0x03D808B0
  yxy  get=0x03D80930
  yxz  get=0x03D809B0  set=0x03D813A0
  yyx  get=0x03D80A50
  yyy  get=0x03D80AD0
  yyz  get=0x03D80B40
  yzx  get=0x03D80BC0  set=0x03D813E0
  yzy  get=0x03D80C00
  yzz  get=0x03D80C80
  zxx  get=0x03D80D20
  zxy  get=0x03D80DA0  set=0x03D81420
  zxz  get=0x03D80DE0
  zyx  get=0x03D80E80  set=0x03D81460
  zyy  get=0x03D80F00
  zyz  get=0x03D80F80
  zzx  get=0x03D81020
  zzy  get=0x03D810A0
  zzz  get=0x03D81120
  xx  get=0x03D80490
  xy  get=0x03D51540  set=0x03D7F900
  xz  get=0x03D51590  set=0x03D81340
  yx  get=0x03D7F9F0  set=0x03D81380
  yy  get=0x03D80A30
  yz  get=0x03D54520  set=0x03D813C0
  zx  get=0x03D80D00  set=0x03D81400
  zy  get=0x03D80E60  set=0x03D81440
  zz  get=0x03D81000
  Item  get=0x03D80480  set=0x03D81330
METHODS:
  RVA=0x03D51BD0  token=0x60009AA  System.Void .ctor(System.Single x, System.Single y, System.Single z)
  RVA=0x03D80430  token=0x60009AB  System.Void .ctor(System.Single x, Unity.Mathematics.float2 yz)
  RVA=0x03D80360  token=0x60009AC  System.Void .ctor(Unity.Mathematics.float2 xy, System.Single z)
  RVA=0x03D51BE0  token=0x60009AD  System.Void .ctor(Unity.Mathematics.float3 xyz)
  RVA=0x03D803F0  token=0x60009AE  System.Void .ctor(System.Single v)
  RVA=0x04D27B9C  token=0x60009AF  System.Void .ctor(System.Boolean v)
  RVA=0x04D27BD0  token=0x60009B0  System.Void .ctor(Unity.Mathematics.bool3 v)
  RVA=0x03D802F0  token=0x60009B1  System.Void .ctor(System.Int32 v)
  RVA=0x03D80400  token=0x60009B2  System.Void .ctor(Unity.Mathematics.int3 v)
  RVA=0x03D80380  token=0x60009B3  System.Void .ctor(System.UInt32 v)
  RVA=0x03D80320  token=0x60009B4  System.Void .ctor(Unity.Mathematics.uint3 v)
  RVA=0x09C67B64  token=0x60009B5  System.Void .ctor(Unity.Mathematics.half v)
  RVA=0x09C67B28  token=0x60009B6  System.Void .ctor(Unity.Mathematics.half3 v)
  RVA=0x03D803C0  token=0x60009B7  System.Void .ctor(System.Double v)
  RVA=0x03D80450  token=0x60009B8  System.Void .ctor(Unity.Mathematics.double3 v)
  RVA=0x03D54500  token=0x60009B9  Unity.Mathematics.float3 op_Implicit(System.Single v)
  RVA=0x09C34284  token=0x60009BA  Unity.Mathematics.float3 op_Explicit(System.Boolean v)
  RVA=0x09C34328  token=0x60009BB  Unity.Mathematics.float3 op_Explicit(Unity.Mathematics.bool3 v)
  RVA=0x03D7A860  token=0x60009BC  Unity.Mathematics.float3 op_Implicit(System.Int32 v)
  RVA=0x03D7A9F0  token=0x60009BD  Unity.Mathematics.float3 op_Implicit(Unity.Mathematics.int3 v)
  RVA=0x03D7A9B0  token=0x60009BE  Unity.Mathematics.float3 op_Implicit(System.UInt32 v)
  RVA=0x03D7A920  token=0x60009BF  Unity.Mathematics.float3 op_Implicit(Unity.Mathematics.uint3 v)
  RVA=0x09C342A0  token=0x60009C0  Unity.Mathematics.float3 op_Implicit(Unity.Mathematics.half v)
  RVA=0x09C342DC  token=0x60009C1  Unity.Mathematics.float3 op_Implicit(Unity.Mathematics.half3 v)
  RVA=0x03D7A890  token=0x60009C2  Unity.Mathematics.float3 op_Explicit(System.Double v)
  RVA=0x03D7A820  token=0x60009C3  Unity.Mathematics.float3 op_Explicit(Unity.Mathematics.double3 v)
  RVA=0x03D51660  token=0x60009C4  Unity.Mathematics.float3 op_Multiply(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  RVA=0x028B52E0  token=0x60009C5  Unity.Mathematics.float3 op_Multiply(Unity.Mathematics.float3 lhs, System.Single rhs)
  RVA=0x028B7A00  token=0x60009C6  Unity.Mathematics.float3 op_Multiply(System.Single lhs, Unity.Mathematics.float3 rhs)
  RVA=0x028B7A70  token=0x60009C7  Unity.Mathematics.float3 op_Addition(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  RVA=0x0333F750  token=0x60009C8  Unity.Mathematics.float3 op_Addition(Unity.Mathematics.float3 lhs, System.Single rhs)
  RVA=0x03D81190  token=0x60009C9  Unity.Mathematics.float3 op_Addition(System.Single lhs, Unity.Mathematics.float3 rhs)
  RVA=0x028B7A30  token=0x60009CA  Unity.Mathematics.float3 op_Subtraction(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  RVA=0x0333F780  token=0x60009CB  Unity.Mathematics.float3 op_Subtraction(Unity.Mathematics.float3 lhs, System.Single rhs)
  RVA=0x03D81300  token=0x60009CC  Unity.Mathematics.float3 op_Subtraction(System.Single lhs, Unity.Mathematics.float3 rhs)
  RVA=0x0950BFE0  token=0x60009CD  Unity.Mathematics.float3 op_Division(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  RVA=0x094FB6EC  token=0x60009CE  Unity.Mathematics.float3 op_Division(Unity.Mathematics.float3 lhs, System.Single rhs)
  RVA=0x09C67BA0  token=0x60009CF  Unity.Mathematics.float3 op_Division(System.Single lhs, Unity.Mathematics.float3 rhs)
  RVA=0x03D7AE80  token=0x60009D0  Unity.Mathematics.float3 op_Modulus(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  RVA=0x03D812A0  token=0x60009D1  Unity.Mathematics.float3 op_Modulus(Unity.Mathematics.float3 lhs, System.Single rhs)
  RVA=0x03D81240  token=0x60009D2  Unity.Mathematics.float3 op_Modulus(System.Single lhs, Unity.Mathematics.float3 rhs)
  RVA=0x03D81200  token=0x60009D3  Unity.Mathematics.float3 op_Increment(Unity.Mathematics.float3 val)
  RVA=0x03D811C0  token=0x60009D4  Unity.Mathematics.float3 op_Decrement(Unity.Mathematics.float3 val)
  RVA=0x09C67EE0  token=0x60009D5  Unity.Mathematics.bool3 op_LessThan(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  RVA=0x09C67F14  token=0x60009D6  Unity.Mathematics.bool3 op_LessThan(Unity.Mathematics.float3 lhs, System.Single rhs)
  RVA=0x09C67EB0  token=0x60009D7  Unity.Mathematics.bool3 op_LessThan(System.Single lhs, Unity.Mathematics.float3 rhs)
  RVA=0x09C67E1C  token=0x60009D8  Unity.Mathematics.bool3 op_LessThanOrEqual(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  RVA=0x09C67E88  token=0x60009D9  Unity.Mathematics.bool3 op_LessThanOrEqual(Unity.Mathematics.float3 lhs, System.Single rhs)
  RVA=0x09C67E54  token=0x60009DA  Unity.Mathematics.bool3 op_LessThanOrEqual(System.Single lhs, Unity.Mathematics.float3 rhs)
  RVA=0x09C67CDC  token=0x60009DB  Unity.Mathematics.bool3 op_GreaterThan(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  RVA=0x09C67D34  token=0x60009DC  Unity.Mathematics.bool3 op_GreaterThan(Unity.Mathematics.float3 lhs, System.Single rhs)
  RVA=0x09C67D10  token=0x60009DD  Unity.Mathematics.bool3 op_GreaterThan(System.Single lhs, Unity.Mathematics.float3 rhs)
  RVA=0x09C67C50  token=0x60009DE  Unity.Mathematics.bool3 op_GreaterThanOrEqual(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  RVA=0x09C67C84  token=0x60009DF  Unity.Mathematics.bool3 op_GreaterThanOrEqual(Unity.Mathematics.float3 lhs, System.Single rhs)
  RVA=0x09C67CB4  token=0x60009E0  Unity.Mathematics.bool3 op_GreaterThanOrEqual(System.Single lhs, Unity.Mathematics.float3 rhs)
  RVA=0x02E241C0  token=0x60009E1  Unity.Mathematics.float3 op_UnaryNegation(Unity.Mathematics.float3 val)
  RVA=0x03D514C0  token=0x60009E2  Unity.Mathematics.float3 op_UnaryPlus(Unity.Mathematics.float3 val)
  RVA=0x09C67BCC  token=0x60009E3  Unity.Mathematics.bool3 op_Equality(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  RVA=0x04D27C0C  token=0x60009E4  Unity.Mathematics.bool3 op_Equality(Unity.Mathematics.float3 lhs, System.Single rhs)
  RVA=0x09C67C14  token=0x60009E5  Unity.Mathematics.bool3 op_Equality(System.Single lhs, Unity.Mathematics.float3 rhs)
  RVA=0x09C67D98  token=0x60009E6  Unity.Mathematics.bool3 op_Inequality(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  RVA=0x09C67DDC  token=0x60009E7  Unity.Mathematics.bool3 op_Inequality(Unity.Mathematics.float3 lhs, System.Single rhs)
  RVA=0x09C67D60  token=0x60009E8  Unity.Mathematics.bool3 op_Inequality(System.Single lhs, Unity.Mathematics.float3 rhs)
  RVA=0x02799940  token=0x6000A6C  System.Boolean Equals(Unity.Mathematics.float3 rhs)
  RVA=0x09C67920  token=0x6000A6D  System.Boolean Equals(System.Object o)
  RVA=0x09C67994  token=0x6000A6E  System.Int32 GetHashCode()
  RVA=0x09C679B8  token=0x6000A6F  System.String ToString()
  RVA=0x09C67A78  token=0x6000A70  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x03D514C0  token=0x6000A71  UnityEngine.Vector3 op_Implicit(Unity.Mathematics.float3 v)
  RVA=0x03D514C0  token=0x6000A72  Unity.Mathematics.float3 op_Implicit(UnityEngine.Vector3 v)
END_CLASS

CLASS: Unity.Mathematics.float3x2
TYPE:  sealed struct
TOKEN: 0x200002D
SIZE:  0x28
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.float3        c0  // 0x10
  public            Unity.Mathematics.float3        c1  // 0x1c
METHODS:
  RVA=0x03D4FF30  token=0x6000A73  System.Void .ctor(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1)
  RVA=0x03D814F0  token=0x6000A74  System.Void .ctor(System.Single m00, System.Single m01, System.Single m10, System.Single m11, System.Single m20, System.Single m21)
  RVA=0x03D814D0  token=0x6000A75  System.Void .ctor(System.Single v)
  RVA=0x04D27D00  token=0x6000A76  System.Void .ctor(System.Boolean v)
  RVA=0x09C6DB28  token=0x6000A77  System.Void .ctor(Unity.Mathematics.bool3x2 v)
  RVA=0x03D81480  token=0x6000A78  System.Void .ctor(System.Int32 v)
  RVA=0x04D27EA0  token=0x6000A79  System.Void .ctor(Unity.Mathematics.int3x2 v)
  RVA=0x03D81520  token=0x6000A7A  System.Void .ctor(System.UInt32 v)
  RVA=0x04D27E2C  token=0x6000A7B  System.Void .ctor(Unity.Mathematics.uint3x2 v)
  RVA=0x03D81590  token=0x6000A7C  System.Void .ctor(System.Double v)
  RVA=0x09C6DAB0  token=0x6000A7D  System.Void .ctor(Unity.Mathematics.double3x2 v)
  RVA=0x09C6DBF8  token=0x6000A7E  Unity.Mathematics.float3x2 op_Multiply(Unity.Mathematics.float3x2 lhs, System.Single rhs)
  RVA=0x09C6D690  token=0x6000A7F  System.Boolean Equals(Unity.Mathematics.float3x2 rhs)
  RVA=0x09C6D61C  token=0x6000A80  System.Boolean Equals(System.Object o)
  RVA=0x09C6D6F4  token=0x6000A81  System.Int32 GetHashCode()
  RVA=0x09C6D8D0  token=0x6000A82  System.String ToString()
  RVA=0x09C6D71C  token=0x6000A83  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.float3x3
TYPE:  sealed struct
TOKEN: 0x200002E
SIZE:  0x34
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.float3        c0  // 0x10
  public            Unity.Mathematics.float3        c1  // 0x1c
  public            Unity.Mathematics.float3        c2  // 0x28
  public    static readonly Unity.Mathematics.float3x3      identity  // static @ 0x0
  public    static readonly Unity.Mathematics.float3x3      zero  // static @ 0x24
PROPERTIES:
  Item  get=0x03D81800
METHODS:
  RVA=0x03D55290  token=0x6000A84  System.Void .ctor(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2)
  RVA=0x03D81650  token=0x6000A85  System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12, System.Single m20, System.Single m21, System.Single m22)
  RVA=0x03D81760  token=0x6000A86  System.Void .ctor(System.Single v)
  RVA=0x04D28060  token=0x6000A87  System.Void .ctor(System.Boolean v)
  RVA=0x09C6E324  token=0x6000A88  System.Void .ctor(Unity.Mathematics.bool3x3 v)
  RVA=0x03D815E0  token=0x6000A89  System.Void .ctor(System.Int32 v)
  RVA=0x04D27F14  token=0x6000A8A  System.Void .ctor(Unity.Mathematics.int3x3 v)
  RVA=0x03D816B0  token=0x6000A8B  System.Void .ctor(System.UInt32 v)
  RVA=0x04D280DC  token=0x6000A8C  System.Void .ctor(Unity.Mathematics.uint3x3 v)
  RVA=0x03D81790  token=0x6000A8D  System.Void .ctor(System.Double v)
  RVA=0x09C6E27C  token=0x6000A8E  System.Void .ctor(Unity.Mathematics.double3x3 v)
  RVA=0x09C3460C  token=0x6000A8F  Unity.Mathematics.float3x3 op_Implicit(System.Int32 v)
  RVA=0x09C6E548  token=0x6000A90  Unity.Mathematics.float3x3 op_Multiply(Unity.Mathematics.float3x3 lhs, System.Single rhs)
  RVA=0x09C6E448  token=0x6000A91  Unity.Mathematics.float3x3 op_Addition(Unity.Mathematics.float3x3 lhs, Unity.Mathematics.float3x3 rhs)
  RVA=0x09C6DCF8  token=0x6000A93  System.Boolean Equals(Unity.Mathematics.float3x3 rhs)
  RVA=0x09C6DC7C  token=0x6000A94  System.Boolean Equals(System.Object o)
  RVA=0x09C6DD84  token=0x6000A95  System.Int32 GetHashCode()
  RVA=0x09C6DDB0  token=0x6000A96  System.String ToString()
  RVA=0x09C6E038  token=0x6000A97  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x028B5310  token=0x6000A98  System.Void .ctor(Unity.Mathematics.float4x4 f4x4)
  RVA=0x028B74E0  token=0x6000A99  System.Void .ctor(Unity.Mathematics.quaternion q)
  RVA=0x03C7D1C0  token=0x6000A9A  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.float3x4
TYPE:  sealed struct
TOKEN: 0x200002F
SIZE:  0x40
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.float3        c0  // 0x10
  public            Unity.Mathematics.float3        c1  // 0x1c
  public            Unity.Mathematics.float3        c2  // 0x28
  public            Unity.Mathematics.float3        c3  // 0x34
  public    static readonly Unity.Mathematics.float3x4      zero  // static @ 0x0
PROPERTIES:
  Item  get=0x03D81800
METHODS:
  RVA=0x03D81850  token=0x6000A9B  System.Void .ctor(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2, Unity.Mathematics.float3 c3)
  RVA=0x03D81AA0  token=0x6000A9C  System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13, System.Single m20, System.Single m21, System.Single m22, System.Single m23)
  RVA=0x03D81810  token=0x6000A9D  System.Void .ctor(System.Single v)
  RVA=0x04D2837C  token=0x6000A9E  System.Void .ctor(System.Boolean v)
  RVA=0x09C6EE50  token=0x6000A9F  System.Void .ctor(Unity.Mathematics.bool3x4 v)
  RVA=0x03D81A10  token=0x6000AA0  System.Void .ctor(System.Int32 v)
  RVA=0x04D282A8  token=0x6000AA1  System.Void .ctor(Unity.Mathematics.int3x4 v)
  RVA=0x03D81930  token=0x6000AA2  System.Void .ctor(System.UInt32 v)
  RVA=0x04D2841C  token=0x6000AA3  System.Void .ctor(Unity.Mathematics.uint3x4 v)
  RVA=0x03D818A0  token=0x6000AA4  System.Void .ctor(System.Double v)
  RVA=0x09C6ED74  token=0x6000AA5  System.Void .ctor(Unity.Mathematics.double3x4 v)
  RVA=0x09C34834  token=0x6000AA6  Unity.Mathematics.float3x4 op_Implicit(System.Int32 v)
  RVA=0x09C6E67C  token=0x6000AA8  System.Boolean Equals(Unity.Mathematics.float3x4 rhs)
  RVA=0x09C6E600  token=0x6000AA9  System.Boolean Equals(System.Object o)
  RVA=0x09C6E740  token=0x6000AAA  System.Int32 GetHashCode()
  RVA=0x09C6EA44  token=0x6000AAB  System.String ToString()
  RVA=0x09C6E770  token=0x6000AAC  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.float4
TYPE:  sealed struct
TOKEN: 0x2000030
SIZE:  0x20
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            System.Single                   x  // 0x10
  public            System.Single                   y  // 0x14
  public            System.Single                   z  // 0x18
  public            System.Single                   w  // 0x1c
  public    static readonly Unity.Mathematics.float4        zero  // static @ 0x0
PROPERTIES:
  xxzz  get=0x03D805F0
  xyzx  get=0x028B4690
  xzxz  get=0x03D80790
  yyww  get=0x03D81E50
  yzxy  get=0x028B46B0
  yzxz  get=0x028B4710
  yzxw  get=0x03D81E70
  zxyy  get=0x028B46D0
  zxyz  get=0x028B46F0
  zwxy  get=0x028B5900
  wzyx  get=0x028B58E0
  wwwx  get=0x03D81D90
  wwww  get=0x03D81D70
  xxx  get=0x03D804A0
  xyz  get=0x03D514C0  set=0x03D51BE0
  xyw  get=0x03D81DF0
  yxw  get=0x03D81E30
  yzx  get=0x03D80BC0
  zwx  get=0x03D81E90
  wzy  get=0x03D81DD0
  www  get=0x03D81D60
  xx  get=0x03D80490
  xy  get=0x03D51540  set=0x03D7F900
  xz  get=0x03D51590
  yy  get=0x03D80A30
  yw  get=0x03D81E10
  zw  get=0x03D67720
  wz  get=0x03D81DB0
  Item  get=0x03D80480  set=0x03D81330
METHODS:
  RVA=0x03D516B0  token=0x6000AAD  System.Void .ctor(System.Single x, System.Single y, System.Single z, System.Single w)
  RVA=0x03D81C70  token=0x6000AAE  System.Void .ctor(System.Single x, System.Single y, Unity.Mathematics.float2 zw)
  RVA=0x03D81D10  token=0x6000AAF  System.Void .ctor(System.Single x, Unity.Mathematics.float2 yz, System.Single w)
  RVA=0x03D81D40  token=0x6000AB0  System.Void .ctor(System.Single x, Unity.Mathematics.float3 yzw)
  RVA=0x03D81C20  token=0x6000AB1  System.Void .ctor(Unity.Mathematics.float2 xy, System.Single z, System.Single w)
  RVA=0x03D81B20  token=0x6000AB2  System.Void .ctor(Unity.Mathematics.float2 xy, Unity.Mathematics.float2 zw)
  RVA=0x03D81C00  token=0x6000AB3  System.Void .ctor(Unity.Mathematics.float3 xyz, System.Single w)
  RVA=0x03D5DBB0  token=0x6000AB4  System.Void .ctor(Unity.Mathematics.float4 xyzw)
  RVA=0x03D81BB0  token=0x6000AB5  System.Void .ctor(System.Single v)
  RVA=0x04D28748  token=0x6000AB6  System.Void .ctor(System.Boolean v)
  RVA=0x04D2878C  token=0x6000AB7  System.Void .ctor(Unity.Mathematics.bool4 v)
  RVA=0x03D81CA0  token=0x6000AB8  System.Void .ctor(System.Int32 v)
  RVA=0x03D81D00  token=0x6000AB9  System.Void .ctor(Unity.Mathematics.int4 v)
  RVA=0x03D81B60  token=0x6000ABA  System.Void .ctor(System.UInt32 v)
  RVA=0x03D81CB0  token=0x6000ABB  System.Void .ctor(Unity.Mathematics.uint4 v)
  RVA=0x09C6F34C  token=0x6000ABC  System.Void .ctor(Unity.Mathematics.half v)
  RVA=0x09C6F2F4  token=0x6000ABD  System.Void .ctor(Unity.Mathematics.half4 v)
  RVA=0x03D81C50  token=0x6000ABE  System.Void .ctor(System.Double v)
  RVA=0x03D81BC0  token=0x6000ABF  System.Void .ctor(Unity.Mathematics.double4 v)
  RVA=0x03D7AAE0  token=0x6000AC0  Unity.Mathematics.float4 op_Implicit(System.Single v)
  RVA=0x03D7AB70  token=0x6000AC1  Unity.Mathematics.float4 op_Implicit(System.Int32 v)
  RVA=0x09C34A6C  token=0x6000AC2  Unity.Mathematics.float4 op_Implicit(Unity.Mathematics.int4 v)
  RVA=0x03D7ABC0  token=0x6000AC3  Unity.Mathematics.float4 op_Implicit(System.UInt32 v)
  RVA=0x09C34AC8  token=0x6000AC4  Unity.Mathematics.float4 op_Implicit(Unity.Mathematics.uint4 v)
  RVA=0x09C349C4  token=0x6000AC5  Unity.Mathematics.float4 op_Implicit(Unity.Mathematics.half4 v)
  RVA=0x03D7AB50  token=0x6000AC6  Unity.Mathematics.float4 op_Explicit(System.Double v)
  RVA=0x09C3497C  token=0x6000AC7  Unity.Mathematics.float4 op_Explicit(Unity.Mathematics.double4 v)
  RVA=0x028B5D10  token=0x6000AC8  Unity.Mathematics.float4 op_Multiply(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs)
  RVA=0x02E260C0  token=0x6000AC9  Unity.Mathematics.float4 op_Multiply(Unity.Mathematics.float4 lhs, System.Single rhs)
  RVA=0x028B53E0  token=0x6000ACA  Unity.Mathematics.float4 op_Multiply(System.Single lhs, Unity.Mathematics.float4 rhs)
  RVA=0x028B5D60  token=0x6000ACB  Unity.Mathematics.float4 op_Addition(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs)
  RVA=0x03D73570  token=0x6000ACC  Unity.Mathematics.float4 op_Addition(Unity.Mathematics.float4 lhs, System.Single rhs)
  RVA=0x028B4640  token=0x6000ACD  Unity.Mathematics.float4 op_Subtraction(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs)
  RVA=0x03D73590  token=0x6000ACE  Unity.Mathematics.float4 op_Subtraction(Unity.Mathematics.float4 lhs, System.Single rhs)
  RVA=0x03D81EB0  token=0x6000ACF  Unity.Mathematics.float4 op_Subtraction(System.Single lhs, Unity.Mathematics.float4 rhs)
  RVA=0x0950C700  token=0x6000AD0  Unity.Mathematics.float4 op_Division(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs)
  RVA=0x0950C744  token=0x6000AD1  Unity.Mathematics.float4 op_Division(Unity.Mathematics.float4 lhs, System.Single rhs)
  RVA=0x09C6F394  token=0x6000AD2  Unity.Mathematics.float4 op_Division(System.Single lhs, Unity.Mathematics.float4 rhs)
  RVA=0x09C6F4B0  token=0x6000AD3  Unity.Mathematics.bool4 op_LessThan(Unity.Mathematics.float4 lhs, System.Single rhs)
  RVA=0x09C6F474  token=0x6000AD4  Unity.Mathematics.bool4 op_GreaterThan(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs)
  RVA=0x09C6F430  token=0x6000AD5  Unity.Mathematics.bool4 op_GreaterThanOrEqual(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs)
  RVA=0x03D81EF0  token=0x6000AD6  Unity.Mathematics.float4 op_UnaryNegation(Unity.Mathematics.float4 val)
  RVA=0x09C6F3CC  token=0x6000AD7  Unity.Mathematics.bool4 op_Equality(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs)
  RVA=0x04D287E0  token=0x6000AD8  Unity.Mathematics.bool4 op_Equality(Unity.Mathematics.float4 lhs, System.Single rhs)
  RVA=0x022CDA10  token=0x6000AF9  System.Boolean Equals(Unity.Mathematics.float4 rhs)
  RVA=0x09C6EFC8  token=0x6000AFA  System.Boolean Equals(System.Object o)
  RVA=0x09C38878  token=0x6000AFB  System.Int32 GetHashCode()
  RVA=0x09C6F034  token=0x6000AFC  System.String ToString()
  RVA=0x09C6F1A0  token=0x6000AFD  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x0294BC80  token=0x6000AFE  Unity.Mathematics.float4 op_Implicit(UnityEngine.Vector4 v)
  RVA=0x0294BC80  token=0x6000AFF  UnityEngine.Vector4 op_Implicit(Unity.Mathematics.float4 v)
END_CLASS

CLASS: Unity.Mathematics.float4x2
TYPE:  sealed struct
TOKEN: 0x2000032
SIZE:  0x30
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.float4        c0  // 0x10
  public            Unity.Mathematics.float4        c1  // 0x20
METHODS:
  RVA=0x03D553F0  token=0x6000B00  System.Void .ctor(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1)
  RVA=0x03D81FE0  token=0x6000B01  System.Void .ctor(System.Single m00, System.Single m01, System.Single m10, System.Single m11, System.Single m20, System.Single m21, System.Single m30, System.Single m31)
  RVA=0x03D81FC0  token=0x6000B02  System.Void .ctor(System.Single v)
  RVA=0x04D28AB4  token=0x6000B03  System.Void .ctor(System.Boolean v)
  RVA=0x04D288EC  token=0x6000B04  System.Void .ctor(Unity.Mathematics.bool4x2 v)
  RVA=0x03D81F10  token=0x6000B05  System.Void .ctor(System.Int32 v)
  RVA=0x09C6FA70  token=0x6000B06  System.Void .ctor(Unity.Mathematics.int4x2 v)
  RVA=0x04D28A84  token=0x6000B07  System.Void .ctor(System.UInt32 v)
  RVA=0x09C6FA1C  token=0x6000B08  System.Void .ctor(Unity.Mathematics.uint4x2 v)
  RVA=0x03D81F30  token=0x6000B09  System.Void .ctor(System.Double v)
  RVA=0x09C6FB14  token=0x6000B0A  System.Void .ctor(Unity.Mathematics.double4x2 v)
  RVA=0x02293810  token=0x6000B0B  Unity.Mathematics.float4x2 op_Implicit(System.Int32 v)
  RVA=0x09C6F4D8  token=0x6000B0C  System.Boolean Equals(Unity.Mathematics.float4x2 rhs)
  RVA=0x09C6F520  token=0x6000B0D  System.Boolean Equals(System.Object o)
  RVA=0x09C6F594  token=0x6000B0E  System.Int32 GetHashCode()
  RVA=0x09C6F7CC  token=0x6000B0F  System.String ToString()
  RVA=0x09C6F5B8  token=0x6000B10  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.float4x3
TYPE:  sealed struct
TOKEN: 0x2000033
SIZE:  0x40
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.float4        c0  // 0x10
  public            Unity.Mathematics.float4        c1  // 0x20
  public            Unity.Mathematics.float4        c2  // 0x30
PROPERTIES:
  Item  get=0x03D82200
METHODS:
  RVA=0x03D6B600  token=0x6000B11  System.Void .ctor(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2)
  RVA=0x03D82140  token=0x6000B12  System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12, System.Single m20, System.Single m21, System.Single m22, System.Single m30, System.Single m31, System.Single m32)
  RVA=0x03D82110  token=0x6000B13  System.Void .ctor(System.Single v)
  RVA=0x04D28B88  token=0x6000B14  System.Void .ctor(System.Boolean v)
  RVA=0x04D28AD8  token=0x6000B15  System.Void .ctor(Unity.Mathematics.bool4x3 v)
  RVA=0x02752510  token=0x6000B16  System.Void .ctor(System.Int32 v)
  RVA=0x09C70288  token=0x6000B17  System.Void .ctor(Unity.Mathematics.int4x3 v)
  RVA=0x04D28DC4  token=0x6000B18  System.Void .ctor(System.UInt32 v)
  RVA=0x09C70378  token=0x6000B19  System.Void .ctor(Unity.Mathematics.uint4x3 v)
  RVA=0x03D82050  token=0x6000B1A  System.Void .ctor(System.Double v)
  RVA=0x09C703F0  token=0x6000B1B  System.Void .ctor(Unity.Mathematics.double4x3 v)
  RVA=0x09C34DDC  token=0x6000B1C  Unity.Mathematics.float4x3 op_Implicit(System.Int32 v)
  RVA=0x09C70538  token=0x6000B1D  Unity.Mathematics.float4x3 op_Multiply(Unity.Mathematics.float4x3 lhs, Unity.Mathematics.float4x3 rhs)
  RVA=0x09C705F4  token=0x6000B1E  Unity.Mathematics.float4x3 op_Multiply(Unity.Mathematics.float4x3 lhs, System.Single rhs)
  RVA=0x09C7047C  token=0x6000B1F  Unity.Mathematics.float4x3 op_Addition(Unity.Mathematics.float4x3 lhs, Unity.Mathematics.float4x3 rhs)
  RVA=0x09C6FBF4  token=0x6000B21  System.Boolean Equals(Unity.Mathematics.float4x3 rhs)
  RVA=0x09C6FB78  token=0x6000B22  System.Boolean Equals(System.Object o)
  RVA=0x09C6FC54  token=0x6000B23  System.Int32 GetHashCode()
  RVA=0x09C6FF58  token=0x6000B24  System.String ToString()
  RVA=0x09C6FC84  token=0x6000B25  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.float4x4
TYPE:  sealed struct
TOKEN: 0x2000034
SIZE:  0x50
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.float4        c0  // 0x10
  public            Unity.Mathematics.float4        c1  // 0x20
  public            Unity.Mathematics.float4        c2  // 0x30
  public            Unity.Mathematics.float4        c3  // 0x40
  public    static readonly Unity.Mathematics.float4x4      identity  // static @ 0x0
  public    static readonly Unity.Mathematics.float4x4      zero  // static @ 0x40
PROPERTIES:
  Item  get=0x03D82200
METHODS:
  RVA=0x03D7E4A0  token=0x6000B26  System.Void .ctor(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2, Unity.Mathematics.float4 c3)
  RVA=0x02A591D0  token=0x6000B27  System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13, System.Single m20, System.Single m21, System.Single m22, System.Single m23, System.Single m30, System.Single m31, System.Single m32, System.Single m33)
  RVA=0x02E25B30  token=0x6000B28  System.Void .ctor(System.Single v)
  RVA=0x04D28EE8  token=0x6000B29  System.Void .ctor(System.Boolean v)
  RVA=0x04D28E08  token=0x6000B2A  System.Void .ctor(Unity.Mathematics.bool4x4 v)
  RVA=0x0327D9B0  token=0x6000B2B  System.Void .ctor(System.Int32 v)
  RVA=0x09C71638  token=0x6000B2C  System.Void .ctor(Unity.Mathematics.int4x4 v)
  RVA=0x04D28FE4  token=0x6000B2D  System.Void .ctor(System.UInt32 v)
  RVA=0x09C715A0  token=0x6000B2E  System.Void .ctor(Unity.Mathematics.uint4x4 v)
  RVA=0x03D82210  token=0x6000B2F  System.Void .ctor(System.Double v)
  RVA=0x09C714E8  token=0x6000B30  System.Void .ctor(Unity.Mathematics.double4x4 v)
  RVA=0x02E25B00  token=0x6000B31  Unity.Mathematics.float4x4 op_Implicit(System.Single v)
  RVA=0x09C352DC  token=0x6000B32  Unity.Mathematics.float4x4 op_Implicit(System.Int32 v)
  RVA=0x09C7195C  token=0x6000B33  Unity.Mathematics.float4x4 op_Multiply(Unity.Mathematics.float4x4 lhs, System.Single rhs)
  RVA=0x09C71770  token=0x6000B34  Unity.Mathematics.bool4x4 op_Equality(Unity.Mathematics.float4x4 lhs, Unity.Mathematics.float4x4 rhs)
  RVA=0x09C70680  token=0x6000B36  System.Boolean Equals(Unity.Mathematics.float4x4 rhs)
  RVA=0x09C706FC  token=0x6000B37  System.Boolean Equals(System.Object o)
  RVA=0x09C70780  token=0x6000B38  System.Int32 GetHashCode()
  RVA=0x09C70A5C  token=0x6000B39  System.String ToString()
  RVA=0x09C70E6C  token=0x6000B3A  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x09C71844  token=0x6000B3B  Unity.Mathematics.float4x4 op_Implicit(UnityEngine.Matrix4x4 m)
  RVA=0x02A592D0  token=0x6000B3C  UnityEngine.Matrix4x4 op_Implicit(Unity.Mathematics.float4x4 m)
  RVA=0x09C71200  token=0x6000B3D  System.Void .ctor(Unity.Mathematics.float3x3 rotation, Unity.Mathematics.float3 translation)
  RVA=0x09C712C0  token=0x6000B3E  System.Void .ctor(Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 translation)
  RVA=0x09C713C4  token=0x6000B3F  System.Void .ctor(Unity.Mathematics.RigidTransform transform)
  RVA=0x09C707B8  token=0x6000B40  Unity.Mathematics.float4x4 Ortho(System.Single width, System.Single height, System.Single near, System.Single far)
  RVA=0x09C708A4  token=0x6000B41  Unity.Mathematics.float4x4 TRS(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 scale)
  RVA=0x03C915F0  token=0x6000B42  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.half
TYPE:  sealed struct
TOKEN: 0x2000035
SIZE:  0x12
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            System.UInt16                   value  // 0x10
  public    static readonly Unity.Mathematics.half          zero  // static @ 0x0
METHODS:
  RVA=0x03D4F9B0  token=0x6000B43  System.Void .ctor(Unity.Mathematics.half x)
  RVA=0x09C7250C  token=0x6000B44  System.Void .ctor(System.Single v)
  RVA=0x09C724F0  token=0x6000B45  System.Void .ctor(System.Double v)
  RVA=0x09C35A48  token=0x6000B46  Unity.Mathematics.half op_Explicit(System.Single v)
  RVA=0x09C35A3C  token=0x6000B47  Unity.Mathematics.half op_Explicit(System.Double v)
  RVA=0x09C72544  token=0x6000B48  System.Single op_Implicit(Unity.Mathematics.half d)
  RVA=0x09C7252C  token=0x6000B49  System.Double op_Implicit(Unity.Mathematics.half d)
  RVA=0x09C72524  token=0x6000B4A  System.Boolean op_Equality(Unity.Mathematics.half lhs, Unity.Mathematics.half rhs)
  RVA=0x031DF9C0  token=0x6000B4B  System.Boolean Equals(Unity.Mathematics.half rhs)
  RVA=0x09C72438  token=0x6000B4C  System.Boolean Equals(System.Object o)
  RVA=0x03D4F990  token=0x6000B4D  System.Int32 GetHashCode()
  RVA=0x09C72498  token=0x6000B4E  System.String ToString()
  RVA=0x09C724BC  token=0x6000B4F  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.half2
TYPE:  sealed struct
TOKEN: 0x2000036
SIZE:  0x14
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.half          x  // 0x10
  public            Unity.Mathematics.half          y  // 0x12
METHODS:
  RVA=0x03D6EFA0  token=0x6000B50  System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half y)
  RVA=0x03D82320  token=0x6000B51  System.Void .ctor(Unity.Mathematics.half2 xy)
  RVA=0x03D82310  token=0x6000B52  System.Void .ctor(Unity.Mathematics.half v)
  RVA=0x09C71C24  token=0x6000B53  System.Void .ctor(System.Single v)
  RVA=0x09C71C4C  token=0x6000B54  System.Void .ctor(Unity.Mathematics.float2 v)
  RVA=0x09C71BF4  token=0x6000B55  System.Void .ctor(System.Double v)
  RVA=0x09C71C7C  token=0x6000B56  System.Void .ctor(Unity.Mathematics.double2 v)
  RVA=0x09C357A8  token=0x6000B57  Unity.Mathematics.half2 op_Explicit(Unity.Mathematics.float2 v)
  RVA=0x09C71A88  token=0x6000B58  System.Boolean Equals(Unity.Mathematics.half2 rhs)
  RVA=0x09C71A14  token=0x6000B59  System.Boolean Equals(System.Object o)
  RVA=0x09C71A9C  token=0x6000B5A  System.Int32 GetHashCode()
  RVA=0x09C71B68  token=0x6000B5B  System.String ToString()
  RVA=0x09C71AE4  token=0x6000B5C  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.half3
TYPE:  sealed struct
TOKEN: 0x2000038
SIZE:  0x16
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.half          x  // 0x10
  public            Unity.Mathematics.half          y  // 0x12
  public            Unity.Mathematics.half          z  // 0x14
METHODS:
  RVA=0x03D7D570  token=0x6000B5D  System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half z)
  RVA=0x03D82330  token=0x6000B5E  System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half2 yz)
  RVA=0x03D82350  token=0x6000B5F  System.Void .ctor(Unity.Mathematics.half2 xy, Unity.Mathematics.half z)
  RVA=0x03D82360  token=0x6000B60  System.Void .ctor(Unity.Mathematics.half3 xyz)
  RVA=0x03D82380  token=0x6000B61  System.Void .ctor(Unity.Mathematics.half v)
  RVA=0x09C71F70  token=0x6000B62  System.Void .ctor(System.Single v)
  RVA=0x09C71FA8  token=0x6000B63  System.Void .ctor(Unity.Mathematics.float3 v)
  RVA=0x09C71EE4  token=0x6000B64  System.Void .ctor(System.Double v)
  RVA=0x09C71F28  token=0x6000B65  System.Void .ctor(Unity.Mathematics.double3 v)
  RVA=0x09C3586C  token=0x6000B66  Unity.Mathematics.half3 op_Explicit(Unity.Mathematics.float3 v)
  RVA=0x09C35820  token=0x6000B67  Unity.Mathematics.half3 op_Explicit(Unity.Mathematics.double3 v)
  RVA=0x09C71CB0  token=0x6000B68  System.Boolean Equals(Unity.Mathematics.half3 rhs)
  RVA=0x09C71CD4  token=0x6000B69  System.Boolean Equals(System.Object o)
  RVA=0x09C71D60  token=0x6000B6A  System.Int32 GetHashCode()
  RVA=0x09C71E2C  token=0x6000B6B  System.String ToString()
  RVA=0x09C71D84  token=0x6000B6C  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.half4
TYPE:  sealed struct
TOKEN: 0x200003A
SIZE:  0x18
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.half          x  // 0x10
  public            Unity.Mathematics.half          y  // 0x12
  public            Unity.Mathematics.half          z  // 0x14
  public            Unity.Mathematics.half          w  // 0x16
  public    static readonly Unity.Mathematics.half4         zero  // static @ 0x0
METHODS:
  RVA=0x03D7D630  token=0x6000B6D  System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half z, Unity.Mathematics.half w)
  RVA=0x03D82400  token=0x6000B6E  System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half2 zw)
  RVA=0x03D82420  token=0x6000B6F  System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half2 yz, Unity.Mathematics.half w)
  RVA=0x03D82470  token=0x6000B70  System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half3 yzw)
  RVA=0x03D82390  token=0x6000B71  System.Void .ctor(Unity.Mathematics.half2 xy, Unity.Mathematics.half z, Unity.Mathematics.half w)
  RVA=0x03D823B0  token=0x6000B72  System.Void .ctor(Unity.Mathematics.half2 xy, Unity.Mathematics.half2 zw)
  RVA=0x03D82450  token=0x6000B73  System.Void .ctor(Unity.Mathematics.half3 xyz, Unity.Mathematics.half w)
  RVA=0x03D823D0  token=0x6000B74  System.Void .ctor(Unity.Mathematics.half4 xyzw)
  RVA=0x03D82440  token=0x6000B75  System.Void .ctor(Unity.Mathematics.half v)
  RVA=0x09C723F4  token=0x6000B76  System.Void .ctor(System.Single v)
  RVA=0x09C722F8  token=0x6000B77  System.Void .ctor(Unity.Mathematics.float4 v)
  RVA=0x09C723A0  token=0x6000B78  System.Void .ctor(System.Double v)
  RVA=0x09C72344  token=0x6000B79  System.Void .ctor(Unity.Mathematics.double4 v)
  RVA=0x09C359E8  token=0x6000B7A  Unity.Mathematics.half4 op_Explicit(Unity.Mathematics.float4 v)
  RVA=0x09C6A134  token=0x6000B7B  System.Boolean Equals(Unity.Mathematics.half4 rhs)
  RVA=0x09C71FE4  token=0x6000B7C  System.Boolean Equals(System.Object o)
  RVA=0x09C72044  token=0x6000B7D  System.Int32 GetHashCode()
  RVA=0x09C7204C  token=0x6000B7E  System.String ToString()
  RVA=0x09C721B0  token=0x6000B7F  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int2
TYPE:  sealed struct
TOKEN: 0x200003C
SIZE:  0x18
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            System.Int32                    x  // 0x10
  public            System.Int32                    y  // 0x14
  public    static readonly Unity.Mathematics.int2          zero  // static @ 0x0
PROPERTIES:
  xy  get=0x03D5DE50
  Item  set=0x03D56010
METHODS:
  RVA=0x03D4E4B0  token=0x6000B80  System.Void .ctor(System.Int32 x, System.Int32 y)
  RVA=0x03D824F0  token=0x6000B81  System.Void .ctor(Unity.Mathematics.int2 xy)
  RVA=0x03D82490  token=0x6000B82  System.Void .ctor(System.Int32 v)
  RVA=0x09C72704  token=0x6000B83  System.Void .ctor(System.Boolean v)
  RVA=0x09C72714  token=0x6000B84  System.Void .ctor(Unity.Mathematics.bool2 v)
  RVA=0x03D82490  token=0x6000B85  System.Void .ctor(System.UInt32 v)
  RVA=0x03D824F0  token=0x6000B86  System.Void .ctor(Unity.Mathematics.uint2 v)
  RVA=0x03D824E0  token=0x6000B87  System.Void .ctor(System.Single v)
  RVA=0x03D824B0  token=0x6000B88  System.Void .ctor(Unity.Mathematics.float2 v)
  RVA=0x03D824D0  token=0x6000B89  System.Void .ctor(System.Double v)
  RVA=0x03D824A0  token=0x6000B8A  System.Void .ctor(Unity.Mathematics.double2 v)
  RVA=0x03D7B520  token=0x6000B8B  Unity.Mathematics.int2 op_Implicit(System.Int32 v)
  RVA=0x03D7B520  token=0x6000B8C  Unity.Mathematics.int2 op_Explicit(System.UInt32 v)
  RVA=0x03D76940  token=0x6000B8D  Unity.Mathematics.int2 op_Explicit(Unity.Mathematics.uint2 v)
  RVA=0x03D7B500  token=0x6000B8E  Unity.Mathematics.int2 op_Explicit(System.Single v)
  RVA=0x03D7B4C0  token=0x6000B8F  Unity.Mathematics.int2 op_Explicit(Unity.Mathematics.float2 v)
  RVA=0x03D7B4E0  token=0x6000B90  Unity.Mathematics.int2 op_Explicit(System.Double v)
  RVA=0x03D7B530  token=0x6000B91  Unity.Mathematics.int2 op_Explicit(Unity.Mathematics.double2 v)
  RVA=0x03D82560  token=0x6000B92  Unity.Mathematics.int2 op_Multiply(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs)
  RVA=0x03D82540  token=0x6000B93  Unity.Mathematics.int2 op_Multiply(Unity.Mathematics.int2 lhs, System.Int32 rhs)
  RVA=0x03D4E4E0  token=0x6000B94  Unity.Mathematics.int2 op_Addition(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs)
  RVA=0x03D82500  token=0x6000B95  Unity.Mathematics.int2 op_Addition(Unity.Mathematics.int2 lhs, System.Int32 rhs)
  RVA=0x03D825B0  token=0x6000B96  Unity.Mathematics.int2 op_Subtraction(Unity.Mathematics.int2 lhs, System.Int32 rhs)
  RVA=0x09C72730  token=0x6000B97  Unity.Mathematics.int2 op_Division(Unity.Mathematics.int2 lhs, System.Int32 rhs)
  RVA=0x09C72774  token=0x6000B98  Unity.Mathematics.bool2 op_GreaterThan(Unity.Mathematics.int2 lhs, System.Int32 rhs)
  RVA=0x09C72754  token=0x6000B99  Unity.Mathematics.bool2 op_GreaterThanOrEqual(Unity.Mathematics.int2 lhs, System.Int32 rhs)
  RVA=0x03D825D0  token=0x6000B9A  Unity.Mathematics.int2 op_UnaryNegation(Unity.Mathematics.int2 val)
  RVA=0x03D82580  token=0x6000B9B  Unity.Mathematics.int2 op_RightShift(Unity.Mathematics.int2 x, System.Int32 n)
  RVA=0x03D82520  token=0x6000B9C  Unity.Mathematics.int2 op_BitwiseOr(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs)
  RVA=0x051404D0  token=0x6000B9F  System.Boolean Equals(Unity.Mathematics.int2 rhs)
  RVA=0x09C7254C  token=0x6000BA0  System.Boolean Equals(System.Object o)
  RVA=0x09C725C0  token=0x6000BA1  System.Int32 GetHashCode()
  RVA=0x09C7267C  token=0x6000BA2  System.String ToString()
  RVA=0x09C725F4  token=0x6000BA3  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int2x2
TYPE:  sealed struct
TOKEN: 0x200003E
SIZE:  0x20
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.int2          c0  // 0x10
  public            Unity.Mathematics.int2          c1  // 0x18
  public    static readonly Unity.Mathematics.int2x2        identity  // static @ 0x0
METHODS:
  RVA=0x03D4EA10  token=0x6000BA4  System.Void .ctor(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1)
  RVA=0x03D82730  token=0x6000BA5  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11)
  RVA=0x03D82670  token=0x6000BA6  System.Void .ctor(System.Int32 v)
  RVA=0x09C72B34  token=0x6000BA7  System.Void .ctor(System.Boolean v)
  RVA=0x09C72AC4  token=0x6000BA8  System.Void .ctor(Unity.Mathematics.bool2x2 v)
  RVA=0x03D82670  token=0x6000BA9  System.Void .ctor(System.UInt32 v)
  RVA=0x03D82760  token=0x6000BAA  System.Void .ctor(Unity.Mathematics.uint2x2 v)
  RVA=0x03D825F0  token=0x6000BAB  System.Void .ctor(System.Single v)
  RVA=0x03D826E0  token=0x6000BAC  System.Void .ctor(Unity.Mathematics.float2x2 v)
  RVA=0x03D826A0  token=0x6000BAD  System.Void .ctor(System.Double v)
  RVA=0x03D82630  token=0x6000BAE  System.Void .ctor(Unity.Mathematics.double2x2 v)
  RVA=0x09C6A4D4  token=0x6000BAF  System.Boolean Equals(Unity.Mathematics.int2x2 rhs)
  RVA=0x09C7278C  token=0x6000BB0  System.Boolean Equals(System.Object o)
  RVA=0x09C727F8  token=0x6000BB1  System.Int32 GetHashCode()
  RVA=0x09C72814  token=0x6000BB2  System.String ToString()
  RVA=0x09C72970  token=0x6000BB3  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x03CBAC80  token=0x6000BB4  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.int2x3
TYPE:  sealed struct
TOKEN: 0x200003F
SIZE:  0x28
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.int2          c0  // 0x10
  public            Unity.Mathematics.int2          c1  // 0x18
  public            Unity.Mathematics.int2          c2  // 0x20
PROPERTIES:
  Item  get=0x03D829E0
METHODS:
  RVA=0x03D54CF0  token=0x6000BB5  System.Void .ctor(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1, Unity.Mathematics.int2 c2)
  RVA=0x03D82990  token=0x6000BB6  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12)
  RVA=0x03D82900  token=0x6000BB7  System.Void .ctor(System.Int32 v)
  RVA=0x09C73090  token=0x6000BB8  System.Void .ctor(System.Boolean v)
  RVA=0x09C72FF8  token=0x6000BB9  System.Void .ctor(Unity.Mathematics.bool2x3 v)
  RVA=0x03D82900  token=0x6000BBA  System.Void .ctor(System.UInt32 v)
  RVA=0x03D82940  token=0x6000BBB  System.Void .ctor(Unity.Mathematics.uint2x3 v)
  RVA=0x03D82850  token=0x6000BBC  System.Void .ctor(System.Single v)
  RVA=0x03D828A0  token=0x6000BBD  System.Void .ctor(Unity.Mathematics.float2x3 v)
  RVA=0x03D827A0  token=0x6000BBE  System.Void .ctor(System.Double v)
  RVA=0x03D827F0  token=0x6000BBF  System.Void .ctor(Unity.Mathematics.double2x3 v)
  RVA=0x09C72B7C  token=0x6000BC1  System.Boolean Equals(Unity.Mathematics.int2x3 rhs)
  RVA=0x09C72BE0  token=0x6000BC2  System.Boolean Equals(System.Object o)
  RVA=0x09C72C54  token=0x6000BC3  System.Int32 GetHashCode()
  RVA=0x09C72C7C  token=0x6000BC4  System.String ToString()
  RVA=0x09C72E44  token=0x6000BC5  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int2x4
TYPE:  sealed struct
TOKEN: 0x2000040
SIZE:  0x30
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.int2          c0  // 0x10
  public            Unity.Mathematics.int2          c1  // 0x18
  public            Unity.Mathematics.int2          c2  // 0x20
  public            Unity.Mathematics.int2          c3  // 0x28
METHODS:
  RVA=0x03D4EA20  token=0x6000BC6  System.Void .ctor(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1, Unity.Mathematics.int2 c2, Unity.Mathematics.int2 c3)
  RVA=0x03D82AE0  token=0x6000BC7  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13)
  RVA=0x03D82BC0  token=0x6000BC8  System.Void .ctor(System.Int32 v)
  RVA=0x09C73710  token=0x6000BC9  System.Void .ctor(System.Boolean v)
  RVA=0x09C73644  token=0x6000BCA  System.Void .ctor(Unity.Mathematics.bool2x4 v)
  RVA=0x03D82BC0  token=0x6000BCB  System.Void .ctor(System.UInt32 v)
  RVA=0x03D82A70  token=0x6000BCC  System.Void .ctor(Unity.Mathematics.uint2x4 v)
  RVA=0x03D82C10  token=0x6000BCD  System.Void .ctor(System.Single v)
  RVA=0x03D829F0  token=0x6000BCE  System.Void .ctor(Unity.Mathematics.float2x4 v)
  RVA=0x03D82C80  token=0x6000BCF  System.Void .ctor(System.Double v)
  RVA=0x03D82B40  token=0x6000BD0  System.Void .ctor(Unity.Mathematics.double2x4 v)
  RVA=0x09C73168  token=0x6000BD1  System.Boolean Equals(Unity.Mathematics.int2x4 rhs)
  RVA=0x09C730F4  token=0x6000BD2  System.Boolean Equals(System.Object o)
  RVA=0x09C731DC  token=0x6000BD3  System.Int32 GetHashCode()
  RVA=0x09C73414  token=0x6000BD4  System.String ToString()
  RVA=0x09C73200  token=0x6000BD5  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int3
TYPE:  sealed struct
TOKEN: 0x2000041
SIZE:  0x1C
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            System.Int32                    x  // 0x10
  public            System.Int32                    y  // 0x14
  public            System.Int32                    z  // 0x18
  public    static readonly Unity.Mathematics.int3          zero  // static @ 0x0
PROPERTIES:
  xyz  set=0x03D51BE0
  xzy  get=0x03D807B0
  xy  get=0x03D5DE50  set=0x03D824F0
  yz  get=0x03D82DA0
  zx  get=0x03D82DC0
  Item  get=0x03D55FF0  set=0x03D56010
METHODS:
  RVA=0x03D4E5D0  token=0x6000BD6  System.Void .ctor(System.Int32 x, System.Int32 y, System.Int32 z)
  RVA=0x03D82CF0  token=0x6000BD7  System.Void .ctor(System.Int32 x, Unity.Mathematics.int2 yz)
  RVA=0x03D82D90  token=0x6000BD8  System.Void .ctor(Unity.Mathematics.int2 xy, System.Int32 z)
  RVA=0x03D51BE0  token=0x6000BD9  System.Void .ctor(Unity.Mathematics.int3 xyz)
  RVA=0x03D82D60  token=0x6000BDA  System.Void .ctor(System.Int32 v)
  RVA=0x09C73998  token=0x6000BDB  System.Void .ctor(System.Boolean v)
  RVA=0x09C7396C  token=0x6000BDC  System.Void .ctor(Unity.Mathematics.bool3 v)
  RVA=0x03D82D60  token=0x6000BDD  System.Void .ctor(System.UInt32 v)
  RVA=0x03D51BE0  token=0x6000BDE  System.Void .ctor(Unity.Mathematics.uint3 v)
  RVA=0x03D82D20  token=0x6000BDF  System.Void .ctor(System.Single v)
  RVA=0x03D82D00  token=0x6000BE0  System.Void .ctor(Unity.Mathematics.float3 v)
  RVA=0x03D82D40  token=0x6000BE1  System.Void .ctor(System.Double v)
  RVA=0x03D82D70  token=0x6000BE2  System.Void .ctor(Unity.Mathematics.double3 v)
  RVA=0x03D7B570  token=0x6000BE3  Unity.Mathematics.int3 op_Implicit(System.Int32 v)
  RVA=0x03D7B570  token=0x6000BE4  Unity.Mathematics.int3 op_Explicit(System.UInt32 v)
  RVA=0x03D7B5F0  token=0x6000BE5  Unity.Mathematics.int3 op_Explicit(Unity.Mathematics.uint3 v)
  RVA=0x03D7B640  token=0x6000BE6  Unity.Mathematics.int3 op_Explicit(System.Single v)
  RVA=0x03D7B580  token=0x6000BE7  Unity.Mathematics.int3 op_Explicit(Unity.Mathematics.float3 v)
  RVA=0x03D7B620  token=0x6000BE8  Unity.Mathematics.int3 op_Explicit(System.Double v)
  RVA=0x03D7B660  token=0x6000BE9  Unity.Mathematics.int3 op_Explicit(Unity.Mathematics.double3 v)
  RVA=0x0304D500  token=0x6000BEA  Unity.Mathematics.int3 op_Multiply(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs)
  RVA=0x03D82E30  token=0x6000BEB  Unity.Mathematics.int3 op_Multiply(Unity.Mathematics.int3 lhs, System.Int32 rhs)
  RVA=0x025BE440  token=0x6000BEC  Unity.Mathematics.int3 op_Addition(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs)
  RVA=0x03D82DE0  token=0x6000BED  Unity.Mathematics.int3 op_Addition(Unity.Mathematics.int3 lhs, System.Int32 rhs)
  RVA=0x03D82EA0  token=0x6000BEE  Unity.Mathematics.int3 op_Subtraction(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs)
  RVA=0x03D82E80  token=0x6000BEF  Unity.Mathematics.int3 op_Subtraction(Unity.Mathematics.int3 lhs, System.Int32 rhs)
  RVA=0x09C739AC  token=0x6000BF0  Unity.Mathematics.int3 op_Division(Unity.Mathematics.int3 lhs, System.Int32 rhs)
  RVA=0x09C73A8C  token=0x6000BF1  Unity.Mathematics.bool3 op_LessThanOrEqual(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs)
  RVA=0x09C73A20  token=0x6000BF2  Unity.Mathematics.bool3 op_GreaterThan(Unity.Mathematics.int3 lhs, System.Int32 rhs)
  RVA=0x09C739D4  token=0x6000BF3  Unity.Mathematics.bool3 op_GreaterThanOrEqual(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs)
  RVA=0x09C73A00  token=0x6000BF4  Unity.Mathematics.bool3 op_GreaterThanOrEqual(Unity.Mathematics.int3 lhs, System.Int32 rhs)
  RVA=0x03D82EC0  token=0x6000BF5  Unity.Mathematics.int3 op_UnaryNegation(Unity.Mathematics.int3 val)
  RVA=0x03D82E50  token=0x6000BF6  Unity.Mathematics.int3 op_RightShift(Unity.Mathematics.int3 x, System.Int32 n)
  RVA=0x09C73A60  token=0x6000BF7  Unity.Mathematics.bool3 op_Inequality(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs)
  RVA=0x09C73A40  token=0x6000BF8  Unity.Mathematics.bool3 op_Inequality(Unity.Mathematics.int3 lhs, System.Int32 rhs)
  RVA=0x03D82E10  token=0x6000BF9  Unity.Mathematics.int3 op_BitwiseOr(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs)
  RVA=0x051408A4  token=0x6000C02  System.Boolean Equals(Unity.Mathematics.int3 rhs)
  RVA=0x09C73794  token=0x6000C03  System.Boolean Equals(System.Object o)
  RVA=0x05D00010  token=0x6000C04  System.Int32 GetHashCode()
  RVA=0x09C738B8  token=0x6000C05  System.String ToString()
  RVA=0x09C73808  token=0x6000C06  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int3x2
TYPE:  sealed struct
TOKEN: 0x2000043
SIZE:  0x28
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.int3          c0  // 0x10
  public            Unity.Mathematics.int3          c1  // 0x1c
METHODS:
  RVA=0x03D4FF30  token=0x6000C07  System.Void .ctor(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1)
  RVA=0x03D82EE0  token=0x6000C08  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11, System.Int32 m20, System.Int32 m21)
  RVA=0x03D82F70  token=0x6000C09  System.Void .ctor(System.Int32 v)
  RVA=0x04D29BD0  token=0x6000C0A  System.Void .ctor(System.Boolean v)
  RVA=0x09C73F48  token=0x6000C0B  System.Void .ctor(Unity.Mathematics.bool3x2 v)
  RVA=0x03D82F70  token=0x6000C0C  System.Void .ctor(System.UInt32 v)
  RVA=0x04D29DA0  token=0x6000C0D  System.Void .ctor(Unity.Mathematics.uint3x2 v)
  RVA=0x03D82F20  token=0x6000C0E  System.Void .ctor(System.Single v)
  RVA=0x04D29E14  token=0x6000C0F  System.Void .ctor(Unity.Mathematics.float3x2 v)
  RVA=0x03D82FA0  token=0x6000C10  System.Void .ctor(System.Double v)
  RVA=0x09C73ED0  token=0x6000C11  System.Void .ctor(Unity.Mathematics.double3x2 v)
  RVA=0x0553EA68  token=0x6000C12  System.Boolean Equals(Unity.Mathematics.int3x2 rhs)
  RVA=0x09C73AB8  token=0x6000C13  System.Boolean Equals(System.Object o)
  RVA=0x09C73B2C  token=0x6000C14  System.Int32 GetHashCode()
  RVA=0x09C73D08  token=0x6000C15  System.String ToString()
  RVA=0x09C73B54  token=0x6000C16  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int3x3
TYPE:  sealed struct
TOKEN: 0x2000044
SIZE:  0x34
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.int3          c0  // 0x10
  public            Unity.Mathematics.int3          c1  // 0x1c
  public            Unity.Mathematics.int3          c2  // 0x28
  public    static readonly Unity.Mathematics.int3x3        identity  // static @ 0x0
METHODS:
  RVA=0x03D55290  token=0x6000C17  System.Void .ctor(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1, Unity.Mathematics.int3 c2)
  RVA=0x03B6C9D0  token=0x6000C18  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m20, System.Int32 m21, System.Int32 m22)
  RVA=0x03D82FF0  token=0x6000C19  System.Void .ctor(System.Int32 v)
  RVA=0x04D2A078  token=0x6000C1A  System.Void .ctor(System.Boolean v)
  RVA=0x09C74610  token=0x6000C1B  System.Void .ctor(Unity.Mathematics.bool3x3 v)
  RVA=0x03D82FF0  token=0x6000C1C  System.Void .ctor(System.UInt32 v)
  RVA=0x04D2A108  token=0x6000C1D  System.Void .ctor(Unity.Mathematics.uint3x3 v)
  RVA=0x03D830B0  token=0x6000C1E  System.Void .ctor(System.Single v)
  RVA=0x04D29FD4  token=0x6000C1F  System.Void .ctor(Unity.Mathematics.float3x3 v)
  RVA=0x03D83040  token=0x6000C20  System.Void .ctor(System.Double v)
  RVA=0x09C74758  token=0x6000C21  System.Void .ctor(Unity.Mathematics.double3x3 v)
  RVA=0x09C740B0  token=0x6000C22  System.Boolean Equals(Unity.Mathematics.int3x3 rhs)
  RVA=0x09C74034  token=0x6000C23  System.Boolean Equals(System.Object o)
  RVA=0x09C7413C  token=0x6000C24  System.Int32 GetHashCode()
  RVA=0x09C743AC  token=0x6000C25  System.String ToString()
  RVA=0x09C74168  token=0x6000C26  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x03B6CA30  token=0x6000C27  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.int3x4
TYPE:  sealed struct
TOKEN: 0x2000045
SIZE:  0x40
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.int3          c0  // 0x10
  public            Unity.Mathematics.int3          c1  // 0x1c
  public            Unity.Mathematics.int3          c2  // 0x28
  public            Unity.Mathematics.int3          c3  // 0x34
METHODS:
  RVA=0x03D81850  token=0x6000C28  System.Void .ctor(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1, Unity.Mathematics.int3 c2, Unity.Mathematics.int3 c3)
  RVA=0x03D832A0  token=0x6000C29  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m23)
  RVA=0x03D831B0  token=0x6000C2A  System.Void .ctor(System.Int32 v)
  RVA=0x04D2A3FC  token=0x6000C2B  System.Void .ctor(System.Boolean v)
  RVA=0x09C74F44  token=0x6000C2C  System.Void .ctor(Unity.Mathematics.bool3x4 v)
  RVA=0x03D831B0  token=0x6000C2D  System.Void .ctor(System.UInt32 v)
  RVA=0x04D2A254  token=0x6000C2E  System.Void .ctor(Unity.Mathematics.uint3x4 v)
  RVA=0x03D83120  token=0x6000C2F  System.Void .ctor(System.Single v)
  RVA=0x04D2A328  token=0x6000C30  System.Void .ctor(Unity.Mathematics.float3x4 v)
  RVA=0x03D83210  token=0x6000C31  System.Void .ctor(System.Double v)
  RVA=0x09C750D8  token=0x6000C32  System.Void .ctor(Unity.Mathematics.double3x4 v)
  RVA=0x09C7487C  token=0x6000C33  System.Boolean Equals(Unity.Mathematics.int3x4 rhs)
  RVA=0x09C74800  token=0x6000C34  System.Boolean Equals(System.Object o)
  RVA=0x09C74940  token=0x6000C35  System.Int32 GetHashCode()
  RVA=0x09C74970  token=0x6000C36  System.String ToString()
  RVA=0x09C74C70  token=0x6000C37  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int4
TYPE:  sealed struct
TOKEN: 0x2000046
SIZE:  0x20
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            System.Int32                    x  // 0x10
  public            System.Int32                    y  // 0x14
  public            System.Int32                    z  // 0x18
  public            System.Int32                    w  // 0x1c
  public    static readonly Unity.Mathematics.int4          zero  // static @ 0x0
PROPERTIES:
  Item  get=0x03D55FF0  set=0x03D56010
METHODS:
  RVA=0x03D517E0  token=0x6000C38  System.Void .ctor(System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w)
  RVA=0x03D83330  token=0x6000C39  System.Void .ctor(System.Int32 x, System.Int32 y, Unity.Mathematics.int2 zw)
  RVA=0x03D83430  token=0x6000C3A  System.Void .ctor(System.Int32 x, Unity.Mathematics.int2 yz, System.Int32 w)
  RVA=0x03D83400  token=0x6000C3B  System.Void .ctor(System.Int32 x, Unity.Mathematics.int3 yzw)
  RVA=0x03D83450  token=0x6000C3C  System.Void .ctor(Unity.Mathematics.int2 xy, System.Int32 z, System.Int32 w)
  RVA=0x03D83350  token=0x6000C3D  System.Void .ctor(Unity.Mathematics.int2 xy, Unity.Mathematics.int2 zw)
  RVA=0x03D833E0  token=0x6000C3E  System.Void .ctor(Unity.Mathematics.int3 xyz, System.Int32 w)
  RVA=0x03D5DBB0  token=0x6000C3F  System.Void .ctor(Unity.Mathematics.int4 xyzw)
  RVA=0x03D83390  token=0x6000C40  System.Void .ctor(System.Int32 v)
  RVA=0x09C754EC  token=0x6000C41  System.Void .ctor(System.Boolean v)
  RVA=0x09C75508  token=0x6000C42  System.Void .ctor(Unity.Mathematics.bool4 v)
  RVA=0x03D83390  token=0x6000C43  System.Void .ctor(System.UInt32 v)
  RVA=0x03D5DBB0  token=0x6000C44  System.Void .ctor(Unity.Mathematics.uint4 v)
  RVA=0x03D83370  token=0x6000C45  System.Void .ctor(System.Single v)
  RVA=0x03D83420  token=0x6000C46  System.Void .ctor(Unity.Mathematics.float4 v)
  RVA=0x03D833A0  token=0x6000C47  System.Void .ctor(System.Double v)
  RVA=0x03D833C0  token=0x6000C48  System.Void .ctor(Unity.Mathematics.double4 v)
  RVA=0x03D7B6A0  token=0x6000C49  Unity.Mathematics.int4 op_Implicit(System.Int32 v)
  RVA=0x03D7B6A0  token=0x6000C4A  Unity.Mathematics.int4 op_Explicit(System.UInt32 v)
  RVA=0x09C3D070  token=0x6000C4B  Unity.Mathematics.int4 op_Explicit(Unity.Mathematics.uint4 v)
  RVA=0x03D7B710  token=0x6000C4C  Unity.Mathematics.int4 op_Explicit(System.Single v)
  RVA=0x09C3D130  token=0x6000C4D  Unity.Mathematics.int4 op_Explicit(Unity.Mathematics.float4 v)
  RVA=0x03D7B6F0  token=0x6000C4E  Unity.Mathematics.int4 op_Explicit(System.Double v)
  RVA=0x09C3D100  token=0x6000C4F  Unity.Mathematics.int4 op_Explicit(Unity.Mathematics.double4 v)
  RVA=0x03D834D0  token=0x6000C50  Unity.Mathematics.int4 op_Multiply(Unity.Mathematics.int4 lhs, Unity.Mathematics.int4 rhs)
  RVA=0x03D83500  token=0x6000C51  Unity.Mathematics.int4 op_Multiply(Unity.Mathematics.int4 lhs, System.Int32 rhs)
  RVA=0x03D834A0  token=0x6000C52  Unity.Mathematics.int4 op_Addition(Unity.Mathematics.int4 lhs, Unity.Mathematics.int4 rhs)
  RVA=0x03D83470  token=0x6000C53  Unity.Mathematics.int4 op_Addition(Unity.Mathematics.int4 lhs, System.Int32 rhs)
  RVA=0x03D83560  token=0x6000C54  Unity.Mathematics.int4 op_Subtraction(Unity.Mathematics.int4 lhs, System.Int32 rhs)
  RVA=0x09C75570  token=0x6000C55  Unity.Mathematics.bool4 op_GreaterThan(Unity.Mathematics.int4 lhs, System.Int32 rhs)
  RVA=0x09C7554C  token=0x6000C56  Unity.Mathematics.bool4 op_GreaterThanOrEqual(Unity.Mathematics.int4 lhs, System.Int32 rhs)
  RVA=0x03D83590  token=0x6000C57  Unity.Mathematics.int4 op_UnaryNegation(Unity.Mathematics.int4 val)
  RVA=0x03D83530  token=0x6000C58  Unity.Mathematics.int4 op_RightShift(Unity.Mathematics.int4 x, System.Int32 n)
  RVA=0x028B58B0  token=0x6000C59  Unity.Mathematics.int4 op_BitwiseOr(Unity.Mathematics.int4 lhs, Unity.Mathematics.int4 rhs)
  RVA=0x05688F1C  token=0x6000C5C  System.Boolean Equals(Unity.Mathematics.int4 rhs)
  RVA=0x09C751B4  token=0x6000C5D  System.Boolean Equals(System.Object o)
  RVA=0x09C75220  token=0x6000C5E  System.Int32 GetHashCode()
  RVA=0x09C7523C  token=0x6000C5F  System.String ToString()
  RVA=0x09C75398  token=0x6000C60  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int4x2
TYPE:  sealed struct
TOKEN: 0x2000048
SIZE:  0x30
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.int4          c0  // 0x10
  public            Unity.Mathematics.int4          c1  // 0x20
METHODS:
  RVA=0x03D553F0  token=0x6000C61  System.Void .ctor(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1)
  RVA=0x03D83620  token=0x6000C62  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11, System.Int32 m20, System.Int32 m21, System.Int32 m30, System.Int32 m31)
  RVA=0x03D835C0  token=0x6000C63  System.Void .ctor(System.Int32 v)
  RVA=0x04D2A7F8  token=0x6000C64  System.Void .ctor(System.Boolean v)
  RVA=0x04D2A77C  token=0x6000C65  System.Void .ctor(Unity.Mathematics.bool4x2 v)
  RVA=0x03D835C0  token=0x6000C66  System.Void .ctor(System.UInt32 v)
  RVA=0x09C75B18  token=0x6000C67  System.Void .ctor(Unity.Mathematics.uint4x2 v)
  RVA=0x03D83600  token=0x6000C68  System.Void .ctor(System.Single v)
  RVA=0x04D2A8E8  token=0x6000C69  System.Void .ctor(Unity.Mathematics.float4x2 v)
  RVA=0x03D83670  token=0x6000C6A  System.Void .ctor(System.Double v)
  RVA=0x09C75AB4  token=0x6000C6B  System.Void .ctor(Unity.Mathematics.double4x2 v)
  RVA=0x02293840  token=0x6000C6C  Unity.Mathematics.int4x2 op_Implicit(System.Int32 v)
  RVA=0x09C75594  token=0x6000C6D  System.Boolean Equals(Unity.Mathematics.int4x2 rhs)
  RVA=0x09C755D8  token=0x6000C6E  System.Boolean Equals(System.Object o)
  RVA=0x09C7564C  token=0x6000C6F  System.Int32 GetHashCode()
  RVA=0x09C75670  token=0x6000C70  System.String ToString()
  RVA=0x09C758A0  token=0x6000C71  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int4x3
TYPE:  sealed struct
TOKEN: 0x2000049
SIZE:  0x40
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.int4          c0  // 0x10
  public            Unity.Mathematics.int4          c1  // 0x20
  public            Unity.Mathematics.int4          c2  // 0x30
METHODS:
  RVA=0x03D6B600  token=0x6000C72  System.Void .ctor(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1, Unity.Mathematics.int4 c2)
  RVA=0x03D83750  token=0x6000C73  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m30, System.Int32 m31, System.Int32 m32)
  RVA=0x03D837D0  token=0x6000C74  System.Void .ctor(System.Int32 v)
  RVA=0x04D2AA28  token=0x6000C75  System.Void .ctor(System.Boolean v)
  RVA=0x04D2A970  token=0x6000C76  System.Void .ctor(Unity.Mathematics.bool4x3 v)
  RVA=0x03D837D0  token=0x6000C77  System.Void .ctor(System.UInt32 v)
  RVA=0x09C76260  token=0x6000C78  System.Void .ctor(Unity.Mathematics.uint4x3 v)
  RVA=0x03D83820  token=0x6000C79  System.Void .ctor(System.Single v)
  RVA=0x04D2AAE4  token=0x6000C7A  System.Void .ctor(Unity.Mathematics.float4x3 v)
  RVA=0x03D836D0  token=0x6000C7B  System.Void .ctor(System.Double v)
  RVA=0x09C762E8  token=0x6000C7C  System.Void .ctor(Unity.Mathematics.double4x3 v)
  RVA=0x09C75BFC  token=0x6000C7D  System.Boolean Equals(Unity.Mathematics.int4x3 rhs)
  RVA=0x09C75B80  token=0x6000C7E  System.Boolean Equals(System.Object o)
  RVA=0x09C75C5C  token=0x6000C7F  System.Int32 GetHashCode()
  RVA=0x09C75F60  token=0x6000C80  System.String ToString()
  RVA=0x09C75C8C  token=0x6000C81  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int4x4
TYPE:  sealed struct
TOKEN: 0x200004A
SIZE:  0x50
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.int4          c0  // 0x10
  public            Unity.Mathematics.int4          c1  // 0x20
  public            Unity.Mathematics.int4          c2  // 0x30
  public            Unity.Mathematics.int4          c3  // 0x40
  public    static readonly Unity.Mathematics.int4x4        identity  // static @ 0x0
METHODS:
  RVA=0x03D7E4A0  token=0x6000C82  System.Void .ctor(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1, Unity.Mathematics.int4 c2, Unity.Mathematics.int4 c3)
  RVA=0x03A4DCE0  token=0x6000C83  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m23, System.Int32 m30, System.Int32 m31, System.Int32 m32, System.Int32 m33)
  RVA=0x03D83900  token=0x6000C84  System.Void .ctor(System.Int32 v)
  RVA=0x04D2AC34  token=0x6000C85  System.Void .ctor(System.Boolean v)
  RVA=0x04D2AD24  token=0x6000C86  System.Void .ctor(Unity.Mathematics.bool4x4 v)
  RVA=0x03D83900  token=0x6000C87  System.Void .ctor(System.UInt32 v)
  RVA=0x09C76C10  token=0x6000C88  System.Void .ctor(Unity.Mathematics.uint4x4 v)
  RVA=0x03D83960  token=0x6000C89  System.Void .ctor(System.Single v)
  RVA=0x04D2AEC0  token=0x6000C8A  System.Void .ctor(Unity.Mathematics.float4x4 v)
  RVA=0x03D83850  token=0x6000C8B  System.Void .ctor(System.Double v)
  RVA=0x09C76CBC  token=0x6000C8C  System.Void .ctor(Unity.Mathematics.double4x4 v)
  RVA=0x09C763F8  token=0x6000C8D  System.Boolean Equals(Unity.Mathematics.int4x4 rhs)
  RVA=0x09C76374  token=0x6000C8E  System.Boolean Equals(System.Object o)
  RVA=0x09C76474  token=0x6000C8F  System.Int32 GetHashCode()
  RVA=0x09C76840  token=0x6000C90  System.String ToString()
  RVA=0x09C764AC  token=0x6000C91  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x03A4DD90  token=0x6000C92  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.quaternion
TYPE:  sealed struct
TOKEN: 0x200004B
SIZE:  0x20
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.float4        value  // 0x10
  public    static readonly Unity.Mathematics.quaternion    identity  // static @ 0x0
METHODS:
  RVA=0x0294BC80  token=0x6000C93  UnityEngine.Quaternion op_Implicit(Unity.Mathematics.quaternion q)
  RVA=0x0294BC80  token=0x6000C94  Unity.Mathematics.quaternion op_Implicit(UnityEngine.Quaternion q)
  RVA=0x03D516B0  token=0x6000C95  System.Void .ctor(System.Single x, System.Single y, System.Single z, System.Single w)
  RVA=0x03D5E620  token=0x6000C96  System.Void .ctor(Unity.Mathematics.float4 value)
  RVA=0x03D5B250  token=0x6000C97  Unity.Mathematics.quaternion op_Implicit(Unity.Mathematics.float4 v)
  RVA=0x028B5440  token=0x6000C98  System.Void .ctor(Unity.Mathematics.float3x3 m)
  RVA=0x09C7C788  token=0x6000C99  System.Void .ctor(Unity.Mathematics.float4x4 m)
  RVA=0x050C94C0  token=0x6000C9A  Unity.Mathematics.quaternion AxisAngle(Unity.Mathematics.float3 axis, System.Single angle)
  RVA=0x050C95CC  token=0x6000C9B  Unity.Mathematics.quaternion EulerXYZ(Unity.Mathematics.float3 xyz)
  RVA=0x050C97AC  token=0x6000C9C  Unity.Mathematics.quaternion EulerXZY(Unity.Mathematics.float3 xyz)
  RVA=0x050C998C  token=0x6000C9D  Unity.Mathematics.quaternion EulerYXZ(Unity.Mathematics.float3 xyz)
  RVA=0x050C9B6C  token=0x6000C9E  Unity.Mathematics.quaternion EulerYZX(Unity.Mathematics.float3 xyz)
  RVA=0x09C7BC88  token=0x6000C9F  Unity.Mathematics.quaternion EulerZXY(Unity.Mathematics.float3 xyz)
  RVA=0x050C9D84  token=0x6000CA0  Unity.Mathematics.quaternion EulerZYX(Unity.Mathematics.float3 xyz)
  RVA=0x09C7BBA8  token=0x6000CA1  Unity.Mathematics.quaternion EulerXYZ(System.Single x, System.Single y, System.Single z)
  RVA=0x09C7BBE0  token=0x6000CA2  Unity.Mathematics.quaternion EulerXZY(System.Single x, System.Single y, System.Single z)
  RVA=0x09C7BC18  token=0x6000CA3  Unity.Mathematics.quaternion EulerYXZ(System.Single x, System.Single y, System.Single z)
  RVA=0x09C7BC50  token=0x6000CA4  Unity.Mathematics.quaternion EulerYZX(System.Single x, System.Single y, System.Single z)
  RVA=0x050C9D4C  token=0x6000CA5  Unity.Mathematics.quaternion EulerZXY(System.Single x, System.Single y, System.Single z)
  RVA=0x09C7BE68  token=0x6000CA6  Unity.Mathematics.quaternion EulerZYX(System.Single x, System.Single y, System.Single z)
  RVA=0x09C7BEDC  token=0x6000CA7  Unity.Mathematics.quaternion Euler(Unity.Mathematics.float3 xyz, Unity.Mathematics.math.RotationOrder order)
  RVA=0x09C7BEA0  token=0x6000CA8  Unity.Mathematics.quaternion Euler(System.Single x, System.Single y, System.Single z, Unity.Mathematics.math.RotationOrder order)
  RVA=0x050C9F64  token=0x6000CA9  Unity.Mathematics.quaternion RotateX(System.Single angle)
  RVA=0x09C7C464  token=0x6000CAA  Unity.Mathematics.quaternion RotateY(System.Single angle)
  RVA=0x050C9FC8  token=0x6000CAB  Unity.Mathematics.quaternion RotateZ(System.Single angle)
  RVA=0x09C7C348  token=0x6000CAC  Unity.Mathematics.quaternion LookRotation(Unity.Mathematics.float3 forward, Unity.Mathematics.float3 up)
  RVA=0x09C7C038  token=0x6000CAD  Unity.Mathematics.quaternion LookRotationSafe(Unity.Mathematics.float3 forward, Unity.Mathematics.float3 up)
  RVA=0x022CDA10  token=0x6000CAE  System.Boolean Equals(Unity.Mathematics.quaternion x)
  RVA=0x09C7BB3C  token=0x6000CAF  System.Boolean Equals(System.Object x)
  RVA=0x09C38878  token=0x6000CB0  System.Int32 GetHashCode()
  RVA=0x09C7C4C8  token=0x6000CB1  System.String ToString()
  RVA=0x09C7C634  token=0x6000CB2  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x03D3AA20  token=0x6000CB3  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.noise
TYPE:  static class
TOKEN: 0x200004C
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09C7A550  token=0x6000CB4  System.Single cnoise(Unity.Mathematics.float2 P)
  RVA=0x09C7AE40  token=0x6000CB5  System.Single pnoise(Unity.Mathematics.float2 P, Unity.Mathematics.float2 rep)
  RVA=0x09C7ABF0  token=0x6000CB6  Unity.Mathematics.float2 mod289(Unity.Mathematics.float2 x)
  RVA=0x09C7AB24  token=0x6000CB7  Unity.Mathematics.float3 mod289(Unity.Mathematics.float3 x)
  RVA=0x09C7AC40  token=0x6000CB8  Unity.Mathematics.float4 mod289(Unity.Mathematics.float4 x)
  RVA=0x09C7AD7C  token=0x6000CB9  Unity.Mathematics.float3 permute(Unity.Mathematics.float3 x)
  RVA=0x09C7ACE4  token=0x6000CBA  Unity.Mathematics.float4 permute(Unity.Mathematics.float4 x)
  RVA=0x09C7BAE4  token=0x6000CBB  Unity.Mathematics.float4 taylorInvSqrt(Unity.Mathematics.float4 r)
  RVA=0x09C7AAA8  token=0x6000CBC  Unity.Mathematics.float2 fade(Unity.Mathematics.float2 t)
  RVA=0x09C7B3D4  token=0x6000CBD  System.Single snoise(Unity.Mathematics.float2 v)
END_CLASS

CLASS: Unity.Mathematics.Random
TYPE:  sealed struct
TOKEN: 0x200004D
SIZE:  0x14
FIELDS:
  public            System.UInt32                   state  // 0x10
METHODS:
  RVA=0x03D839D0  token=0x6000CBE  System.Void .ctor(System.UInt32 seed)
  RVA=0x09C7A118  token=0x6000CBF  Unity.Mathematics.Random CreateFromIndex(System.UInt32 index)
  RVA=0x03C843E0  token=0x6000CC0  System.UInt32 WangHash(System.UInt32 n)
  RVA=0x02AF8270  token=0x6000CC1  System.Single NextFloat()
  RVA=0x062C603C  token=0x6000CC2  Unity.Mathematics.float3 NextFloat3()
  RVA=0x03D839A0  token=0x6000CC3  System.UInt32 NextState()
END_CLASS

CLASS: Unity.Mathematics.RigidTransform
TYPE:  sealed struct
TOKEN: 0x200004E
SIZE:  0x2C
FIELDS:
  public            Unity.Mathematics.quaternion    rot  // 0x10
  public            Unity.Mathematics.float3        pos  // 0x20
  public    static readonly Unity.Mathematics.RigidTransformidentity  // static @ 0x0
METHODS:
  RVA=0x03D839F0  token=0x6000CC4  System.Void .ctor(Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 translation)
  RVA=0x09C7A470  token=0x6000CC5  System.Void .ctor(Unity.Mathematics.float3x3 rotation, Unity.Mathematics.float3 translation)
  RVA=0x09C7A4D4  token=0x6000CC6  System.Void .ctor(Unity.Mathematics.float4x4 transform)
  RVA=0x09C7A1BC  token=0x6000CC7  System.Boolean Equals(Unity.Mathematics.RigidTransform x)
  RVA=0x09C7A140  token=0x6000CC8  System.Boolean Equals(System.Object x)
  RVA=0x09C7A20C  token=0x6000CC9  System.Int32 GetHashCode()
  RVA=0x09C7A258  token=0x6000CCA  System.String ToString()
  RVA=0x03D21080  token=0x6000CCB  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.svd
TYPE:  static class
TOKEN: 0x200004F
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x04D5EC88  token=0x6000CCC  System.Void condSwap(System.Boolean c, System.Single& x, System.Single& y)
  RVA=0x04D5EC14  token=0x6000CCD  System.Void condNegSwap(System.Boolean c, Unity.Mathematics.float3& x, Unity.Mathematics.float3& y)
  RVA=0x09C7CB4C  token=0x6000CCE  Unity.Mathematics.quaternion condNegSwapQuat(System.Boolean c, Unity.Mathematics.quaternion q, Unity.Mathematics.float4 mask)
  RVA=0x09C7D718  token=0x6000CCF  System.Void sortSingularValues(Unity.Mathematics.float3x3& b, Unity.Mathematics.quaternion& v)
  RVA=0x09C7CAA8  token=0x6000CD0  Unity.Mathematics.quaternion approxGivensQuat(Unity.Mathematics.float3 pq, Unity.Mathematics.float4 mask)
  RVA=0x09C7D320  token=0x6000CD1  Unity.Mathematics.quaternion qrGivensQuat(Unity.Mathematics.float2 pq, Unity.Mathematics.float4 mask)
  RVA=0x09C7CC08  token=0x6000CD2  Unity.Mathematics.quaternion givensQRFactorization(Unity.Mathematics.float3x3 b, Unity.Mathematics.float3x3& r)
  RVA=0x09C7CEB0  token=0x6000CD3  Unity.Mathematics.quaternion jacobiIteration(Unity.Mathematics.float3x3& s, System.Int32 iterations)
  RVA=0x09C7D52C  token=0x6000CD4  Unity.Mathematics.float3 singularValuesDecomposition(Unity.Mathematics.float3x3 a, Unity.Mathematics.quaternion& u, Unity.Mathematics.quaternion& v)
  RVA=0x09C7D41C  token=0x6000CD5  Unity.Mathematics.float3 rcpsafe(Unity.Mathematics.float3 x, System.Single epsilon)
  RVA=0x09C7D8C0  token=0x6000CD6  Unity.Mathematics.float3x3 svdInverse(Unity.Mathematics.float3x3 a)
  RVA=0x09C7DA88  token=0x6000CD7  Unity.Mathematics.quaternion svdRotation(Unity.Mathematics.float3x3 a)
END_CLASS

CLASS: Unity.Mathematics.uint2
TYPE:  sealed struct
TOKEN: 0x2000050
SIZE:  0x18
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            System.UInt32                   x  // 0x10
  public            System.UInt32                   y  // 0x14
METHODS:
  RVA=0x03D4E4B0  token=0x6000CD8  System.Void .ctor(System.UInt32 x, System.UInt32 y)
  RVA=0x03D824F0  token=0x6000CD9  System.Void .ctor(Unity.Mathematics.uint2 xy)
  RVA=0x03D82490  token=0x6000CDA  System.Void .ctor(System.UInt32 v)
  RVA=0x09C72704  token=0x6000CDB  System.Void .ctor(System.Boolean v)
  RVA=0x09C72714  token=0x6000CDC  System.Void .ctor(Unity.Mathematics.bool2 v)
  RVA=0x03D82490  token=0x6000CDD  System.Void .ctor(System.Int32 v)
  RVA=0x03D824F0  token=0x6000CDE  System.Void .ctor(Unity.Mathematics.int2 v)
  RVA=0x04D5F760  token=0x6000CDF  System.Void .ctor(System.Single v)
  RVA=0x09C7DCFC  token=0x6000CE0  System.Void .ctor(Unity.Mathematics.float2 v)
  RVA=0x09C7DCE0  token=0x6000CE1  System.Void .ctor(System.Double v)
  RVA=0x09C7DD38  token=0x6000CE2  System.Void .ctor(Unity.Mathematics.double2 v)
  RVA=0x03D7B520  token=0x6000CE3  Unity.Mathematics.uint2 op_Implicit(System.UInt32 v)
  RVA=0x03D7B520  token=0x6000CE4  Unity.Mathematics.uint2 op_Explicit(System.Int32 v)
  RVA=0x03D76940  token=0x6000CE5  Unity.Mathematics.uint2 op_Explicit(Unity.Mathematics.int2 v)
  RVA=0x09C57A68  token=0x6000CE6  Unity.Mathematics.uint2 op_Explicit(System.Single v)
  RVA=0x09C57A8C  token=0x6000CE7  Unity.Mathematics.uint2 op_Explicit(Unity.Mathematics.float2 v)
  RVA=0x09C57A48  token=0x6000CE8  Unity.Mathematics.uint2 op_Explicit(System.Double v)
  RVA=0x09C57A18  token=0x6000CE9  Unity.Mathematics.uint2 op_Explicit(Unity.Mathematics.double2 v)
  RVA=0x03D82560  token=0x6000CEA  Unity.Mathematics.uint2 op_Multiply(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs)
  RVA=0x03D82540  token=0x6000CEB  Unity.Mathematics.uint2 op_Multiply(Unity.Mathematics.uint2 lhs, System.UInt32 rhs)
  RVA=0x03D4E4E0  token=0x6000CEC  Unity.Mathematics.uint2 op_Addition(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs)
  RVA=0x03D82500  token=0x6000CED  Unity.Mathematics.uint2 op_Addition(Unity.Mathematics.uint2 lhs, System.UInt32 rhs)
  RVA=0x03D4E500  token=0x6000CEE  Unity.Mathematics.uint2 op_Subtraction(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs)
  RVA=0x03D825B0  token=0x6000CEF  Unity.Mathematics.uint2 op_Subtraction(Unity.Mathematics.uint2 lhs, System.UInt32 rhs)
  RVA=0x09C7DD74  token=0x6000CF0  Unity.Mathematics.bool2 op_GreaterThan(Unity.Mathematics.uint2 lhs, System.UInt32 rhs)
  RVA=0x03D83A50  token=0x6000CF1  Unity.Mathematics.uint2 op_LeftShift(Unity.Mathematics.uint2 x, System.Int32 n)
  RVA=0x03D83A80  token=0x6000CF2  Unity.Mathematics.uint2 op_RightShift(Unity.Mathematics.uint2 x, System.Int32 n)
  RVA=0x09C7DD5C  token=0x6000CF3  Unity.Mathematics.bool2 op_Equality(Unity.Mathematics.uint2 lhs, System.UInt32 rhs)
  RVA=0x03D83A10  token=0x6000CF4  Unity.Mathematics.uint2 op_BitwiseAnd(Unity.Mathematics.uint2 lhs, System.UInt32 rhs)
  RVA=0x03D82520  token=0x6000CF5  Unity.Mathematics.uint2 op_BitwiseOr(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs)
  RVA=0x03D83A30  token=0x6000CF6  Unity.Mathematics.uint2 op_ExclusiveOr(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs)
  RVA=0x051404D0  token=0x6000CF7  System.Boolean Equals(Unity.Mathematics.uint2 rhs)
  RVA=0x09C7DB28  token=0x6000CF8  System.Boolean Equals(System.Object o)
  RVA=0x09C7DB9C  token=0x6000CF9  System.Int32 GetHashCode()
  RVA=0x09C7DC58  token=0x6000CFA  System.String ToString()
  RVA=0x09C7DBD0  token=0x6000CFB  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint2x2
TYPE:  sealed struct
TOKEN: 0x2000052
SIZE:  0x20
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.uint2         c0  // 0x10
  public            Unity.Mathematics.uint2         c1  // 0x18
  public    static readonly Unity.Mathematics.uint2x2       identity  // static @ 0x0
METHODS:
  RVA=0x03D4EA10  token=0x6000CFC  System.Void .ctor(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1)
  RVA=0x03D82730  token=0x6000CFD  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11)
  RVA=0x03D82670  token=0x6000CFE  System.Void .ctor(System.UInt32 v)
  RVA=0x09C72B34  token=0x6000CFF  System.Void .ctor(System.Boolean v)
  RVA=0x09C72AC4  token=0x6000D00  System.Void .ctor(Unity.Mathematics.bool2x2 v)
  RVA=0x03D82670  token=0x6000D01  System.Void .ctor(System.Int32 v)
  RVA=0x03D82760  token=0x6000D02  System.Void .ctor(Unity.Mathematics.int2x2 v)
  RVA=0x04D5F8F8  token=0x6000D03  System.Void .ctor(System.Single v)
  RVA=0x04D5F8C0  token=0x6000D04  System.Void .ctor(Unity.Mathematics.float2x2 v)
  RVA=0x09C7E11C  token=0x6000D05  System.Void .ctor(System.Double v)
  RVA=0x09C7E0C4  token=0x6000D06  System.Void .ctor(Unity.Mathematics.double2x2 v)
  RVA=0x09C6A4D4  token=0x6000D07  System.Boolean Equals(Unity.Mathematics.uint2x2 rhs)
  RVA=0x09C7DD8C  token=0x6000D08  System.Boolean Equals(System.Object o)
  RVA=0x09C7DDF8  token=0x6000D09  System.Int32 GetHashCode()
  RVA=0x09C7DF68  token=0x6000D0A  System.String ToString()
  RVA=0x09C7DE14  token=0x6000D0B  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x03CBAC20  token=0x6000D0C  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.uint2x3
TYPE:  sealed struct
TOKEN: 0x2000053
SIZE:  0x28
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.uint2         c0  // 0x10
  public            Unity.Mathematics.uint2         c1  // 0x18
  public            Unity.Mathematics.uint2         c2  // 0x20
METHODS:
  RVA=0x03D54CF0  token=0x6000D0D  System.Void .ctor(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1, Unity.Mathematics.uint2 c2)
  RVA=0x03D82990  token=0x6000D0E  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12)
  RVA=0x03D82900  token=0x6000D0F  System.Void .ctor(System.UInt32 v)
  RVA=0x09C73090  token=0x6000D10  System.Void .ctor(System.Boolean v)
  RVA=0x09C72FF8  token=0x6000D11  System.Void .ctor(Unity.Mathematics.bool2x3 v)
  RVA=0x03D82900  token=0x6000D12  System.Void .ctor(System.Int32 v)
  RVA=0x03D82940  token=0x6000D13  System.Void .ctor(Unity.Mathematics.int2x3 v)
  RVA=0x04D5F9D8  token=0x6000D14  System.Void .ctor(System.Single v)
  RVA=0x04D5F920  token=0x6000D15  System.Void .ctor(Unity.Mathematics.float2x3 v)
  RVA=0x09C7E578  token=0x6000D16  System.Void .ctor(System.Double v)
  RVA=0x09C7E5D4  token=0x6000D17  System.Void .ctor(Unity.Mathematics.double2x3 v)
  RVA=0x09C72B7C  token=0x6000D18  System.Boolean Equals(Unity.Mathematics.uint2x3 rhs)
  RVA=0x09C7E160  token=0x6000D19  System.Boolean Equals(System.Object o)
  RVA=0x09C7E1D4  token=0x6000D1A  System.Int32 GetHashCode()
  RVA=0x09C7E1FC  token=0x6000D1B  System.String ToString()
  RVA=0x09C7E3C4  token=0x6000D1C  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint2x4
TYPE:  sealed struct
TOKEN: 0x2000054
SIZE:  0x30
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.uint2         c0  // 0x10
  public            Unity.Mathematics.uint2         c1  // 0x18
  public            Unity.Mathematics.uint2         c2  // 0x20
  public            Unity.Mathematics.uint2         c3  // 0x28
METHODS:
  RVA=0x03D4EA20  token=0x6000D1D  System.Void .ctor(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1, Unity.Mathematics.uint2 c2, Unity.Mathematics.uint2 c3)
  RVA=0x03D82AE0  token=0x6000D1E  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13)
  RVA=0x03D82BC0  token=0x6000D1F  System.Void .ctor(System.UInt32 v)
  RVA=0x09C73710  token=0x6000D20  System.Void .ctor(System.Boolean v)
  RVA=0x09C73644  token=0x6000D21  System.Void .ctor(Unity.Mathematics.bool2x4 v)
  RVA=0x03D82BC0  token=0x6000D22  System.Void .ctor(System.Int32 v)
  RVA=0x03D82A70  token=0x6000D23  System.Void .ctor(Unity.Mathematics.int2x4 v)
  RVA=0x04D5FBB0  token=0x6000D24  System.Void .ctor(System.Single v)
  RVA=0x04D5FBF0  token=0x6000D25  System.Void .ctor(Unity.Mathematics.float2x4 v)
  RVA=0x09C7EBCC  token=0x6000D26  System.Void .ctor(System.Double v)
  RVA=0x09C7EB2C  token=0x6000D27  System.Void .ctor(Unity.Mathematics.double2x4 v)
  RVA=0x09C73168  token=0x6000D28  System.Boolean Equals(Unity.Mathematics.uint2x4 rhs)
  RVA=0x09C7E650  token=0x6000D29  System.Boolean Equals(System.Object o)
  RVA=0x09C7E6C4  token=0x6000D2A  System.Int32 GetHashCode()
  RVA=0x09C7E6E8  token=0x6000D2B  System.String ToString()
  RVA=0x09C7E918  token=0x6000D2C  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint3
TYPE:  sealed struct
TOKEN: 0x2000055
SIZE:  0x1C
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            System.UInt32                   x  // 0x10
  public            System.UInt32                   y  // 0x14
  public            System.UInt32                   z  // 0x18
PROPERTIES:
  xyzz  get=0x03D80710
  Item  get=0x03D55FF0  set=0x03D56010
METHODS:
  RVA=0x03D4E5D0  token=0x6000D2D  System.Void .ctor(System.UInt32 x, System.UInt32 y, System.UInt32 z)
  RVA=0x03D82CF0  token=0x6000D2E  System.Void .ctor(System.UInt32 x, Unity.Mathematics.uint2 yz)
  RVA=0x03D82D90  token=0x6000D2F  System.Void .ctor(Unity.Mathematics.uint2 xy, System.UInt32 z)
  RVA=0x03D51BE0  token=0x6000D30  System.Void .ctor(Unity.Mathematics.uint3 xyz)
  RVA=0x03D82D60  token=0x6000D31  System.Void .ctor(System.UInt32 v)
  RVA=0x09C73998  token=0x6000D32  System.Void .ctor(System.Boolean v)
  RVA=0x09C7396C  token=0x6000D33  System.Void .ctor(Unity.Mathematics.bool3 v)
  RVA=0x03D82D60  token=0x6000D34  System.Void .ctor(System.Int32 v)
  RVA=0x03D51BE0  token=0x6000D35  System.Void .ctor(Unity.Mathematics.int3 v)
  RVA=0x04D5FCB0  token=0x6000D36  System.Void .ctor(System.Single v)
  RVA=0x04D5FC64  token=0x6000D37  System.Void .ctor(Unity.Mathematics.float3 v)
  RVA=0x09C7EE90  token=0x6000D38  System.Void .ctor(System.Double v)
  RVA=0x09C7EE60  token=0x6000D39  System.Void .ctor(Unity.Mathematics.double3 v)
  RVA=0x03D7B570  token=0x6000D3A  Unity.Mathematics.uint3 op_Implicit(System.UInt32 v)
  RVA=0x03D7B570  token=0x6000D3B  Unity.Mathematics.uint3 op_Explicit(System.Int32 v)
  RVA=0x03D7B5F0  token=0x6000D3C  Unity.Mathematics.uint3 op_Explicit(Unity.Mathematics.int3 v)
  RVA=0x09C57D5C  token=0x6000D3D  Unity.Mathematics.uint3 op_Explicit(System.Single v)
  RVA=0x04D5FCE8  token=0x6000D3E  Unity.Mathematics.uint3 op_Explicit(Unity.Mathematics.float3 v)
  RVA=0x09C57D34  token=0x6000D3F  Unity.Mathematics.uint3 op_Explicit(System.Double v)
  RVA=0x09C57CFC  token=0x6000D40  Unity.Mathematics.uint3 op_Explicit(Unity.Mathematics.double3 v)
  RVA=0x0304D500  token=0x6000D41  Unity.Mathematics.uint3 op_Multiply(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs)
  RVA=0x03D82E30  token=0x6000D42  Unity.Mathematics.uint3 op_Multiply(Unity.Mathematics.uint3 lhs, System.UInt32 rhs)
  RVA=0x025BE440  token=0x6000D43  Unity.Mathematics.uint3 op_Addition(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs)
  RVA=0x03D82DE0  token=0x6000D44  Unity.Mathematics.uint3 op_Addition(Unity.Mathematics.uint3 lhs, System.UInt32 rhs)
  RVA=0x03D82EA0  token=0x6000D45  Unity.Mathematics.uint3 op_Subtraction(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs)
  RVA=0x03D82E80  token=0x6000D46  Unity.Mathematics.uint3 op_Subtraction(Unity.Mathematics.uint3 lhs, System.UInt32 rhs)
  RVA=0x09C7EED4  token=0x6000D47  Unity.Mathematics.bool3 op_GreaterThan(Unity.Mathematics.uint3 lhs, System.UInt32 rhs)
  RVA=0x03D83AF0  token=0x6000D48  Unity.Mathematics.uint3 op_LeftShift(Unity.Mathematics.uint3 x, System.Int32 n)
  RVA=0x03D83B20  token=0x6000D49  Unity.Mathematics.uint3 op_RightShift(Unity.Mathematics.uint3 x, System.Int32 n)
  RVA=0x09C7EEB4  token=0x6000D4A  Unity.Mathematics.bool3 op_Equality(Unity.Mathematics.uint3 lhs, System.UInt32 rhs)
  RVA=0x03D83AB0  token=0x6000D4B  Unity.Mathematics.uint3 op_BitwiseAnd(Unity.Mathematics.uint3 lhs, System.UInt32 rhs)
  RVA=0x03D82E10  token=0x6000D4C  Unity.Mathematics.uint3 op_BitwiseOr(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs)
  RVA=0x03D83AD0  token=0x6000D4D  Unity.Mathematics.uint3 op_BitwiseOr(System.UInt32 lhs, Unity.Mathematics.uint3 rhs)
  RVA=0x028B79E0  token=0x6000D4E  Unity.Mathematics.uint3 op_ExclusiveOr(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs)
  RVA=0x051408A4  token=0x6000D52  System.Boolean Equals(Unity.Mathematics.uint3 rhs)
  RVA=0x09C7EC44  token=0x6000D53  System.Boolean Equals(System.Object o)
  RVA=0x09C7ECD8  token=0x6000D54  System.Int32 GetHashCode()
  RVA=0x09C7EDAC  token=0x6000D55  System.String ToString()
  RVA=0x09C7ECFC  token=0x6000D56  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint3x2
TYPE:  sealed struct
TOKEN: 0x2000057
SIZE:  0x28
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.uint3         c0  // 0x10
  public            Unity.Mathematics.uint3         c1  // 0x1c
METHODS:
  RVA=0x03D4FF30  token=0x6000D57  System.Void .ctor(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1)
  RVA=0x03D82EE0  token=0x6000D58  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11, System.UInt32 m20, System.UInt32 m21)
  RVA=0x03D82F70  token=0x6000D59  System.Void .ctor(System.UInt32 v)
  RVA=0x04D29BD0  token=0x6000D5A  System.Void .ctor(System.Boolean v)
  RVA=0x09C73F48  token=0x6000D5B  System.Void .ctor(Unity.Mathematics.bool3x2 v)
  RVA=0x03D82F70  token=0x6000D5C  System.Void .ctor(System.Int32 v)
  RVA=0x04D29DA0  token=0x6000D5D  System.Void .ctor(Unity.Mathematics.int3x2 v)
  RVA=0x04D5FD34  token=0x6000D5E  System.Void .ctor(System.Single v)
  RVA=0x04D5FD90  token=0x6000D5F  System.Void .ctor(Unity.Mathematics.float3x2 v)
  RVA=0x09C7F37C  token=0x6000D60  System.Void .ctor(System.Double v)
  RVA=0x09C7F3D8  token=0x6000D61  System.Void .ctor(Unity.Mathematics.double3x2 v)
  RVA=0x09C7EF68  token=0x6000D62  System.Boolean Equals(Unity.Mathematics.uint3x2 rhs)
  RVA=0x09C7EEF4  token=0x6000D63  System.Boolean Equals(System.Object o)
  RVA=0x09C7EFD8  token=0x6000D64  System.Int32 GetHashCode()
  RVA=0x09C7F1B4  token=0x6000D65  System.String ToString()
  RVA=0x09C7F000  token=0x6000D66  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint3x3
TYPE:  sealed struct
TOKEN: 0x2000058
SIZE:  0x34
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.uint3         c0  // 0x10
  public            Unity.Mathematics.uint3         c1  // 0x1c
  public            Unity.Mathematics.uint3         c2  // 0x28
  public    static readonly Unity.Mathematics.uint3x3       identity  // static @ 0x0
METHODS:
  RVA=0x03D55290  token=0x6000D67  System.Void .ctor(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1, Unity.Mathematics.uint3 c2)
  RVA=0x03B6C9D0  token=0x6000D68  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22)
  RVA=0x03D82FF0  token=0x6000D69  System.Void .ctor(System.UInt32 v)
  RVA=0x04D2A078  token=0x6000D6A  System.Void .ctor(System.Boolean v)
  RVA=0x09C74610  token=0x6000D6B  System.Void .ctor(Unity.Mathematics.bool3x3 v)
  RVA=0x03D82FF0  token=0x6000D6C  System.Void .ctor(System.Int32 v)
  RVA=0x04D2A108  token=0x6000D6D  System.Void .ctor(Unity.Mathematics.int3x3 v)
  RVA=0x04D5FF18  token=0x6000D6E  System.Void .ctor(System.Single v)
  RVA=0x04D6005C  token=0x6000D6F  System.Void .ctor(Unity.Mathematics.float3x3 v)
  RVA=0x04D5FE94  token=0x6000D70  System.Void .ctor(System.Double v)
  RVA=0x09C7FA58  token=0x6000D71  System.Void .ctor(Unity.Mathematics.double3x3 v)
  RVA=0x09C7F4E4  token=0x6000D72  System.Boolean Equals(Unity.Mathematics.uint3x3 rhs)
  RVA=0x09C7F468  token=0x6000D73  System.Boolean Equals(System.Object o)
  RVA=0x09C7F584  token=0x6000D74  System.Int32 GetHashCode()
  RVA=0x09C7F5B0  token=0x6000D75  System.String ToString()
  RVA=0x09C7F814  token=0x6000D76  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x03B6C930  token=0x6000D77  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.uint3x4
TYPE:  sealed struct
TOKEN: 0x2000059
SIZE:  0x40
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.uint3         c0  // 0x10
  public            Unity.Mathematics.uint3         c1  // 0x1c
  public            Unity.Mathematics.uint3         c2  // 0x28
  public            Unity.Mathematics.uint3         c3  // 0x34
METHODS:
  RVA=0x03D81850  token=0x6000D78  System.Void .ctor(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1, Unity.Mathematics.uint3 c2, Unity.Mathematics.uint3 c3)
  RVA=0x03D832A0  token=0x6000D79  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m23)
  RVA=0x03D831B0  token=0x6000D7A  System.Void .ctor(System.UInt32 v)
  RVA=0x04D2A3FC  token=0x6000D7B  System.Void .ctor(System.Boolean v)
  RVA=0x09C74F44  token=0x6000D7C  System.Void .ctor(Unity.Mathematics.bool3x4 v)
  RVA=0x03D831B0  token=0x6000D7D  System.Void .ctor(System.Int32 v)
  RVA=0x04D2A254  token=0x6000D7E  System.Void .ctor(Unity.Mathematics.int3x4 v)
  RVA=0x04D6020C  token=0x6000D7F  System.Void .ctor(System.Single v)
  RVA=0x04D60350  token=0x6000D80  System.Void .ctor(Unity.Mathematics.float3x4 v)
  RVA=0x04D602A8  token=0x6000D81  System.Void .ctor(System.Double v)
  RVA=0x09C80260  token=0x6000D82  System.Void .ctor(Unity.Mathematics.double3x4 v)
  RVA=0x09C7FBA0  token=0x6000D83  System.Boolean Equals(Unity.Mathematics.uint3x4 rhs)
  RVA=0x09C7FB24  token=0x6000D84  System.Boolean Equals(System.Object o)
  RVA=0x09C7FC5C  token=0x6000D85  System.Int32 GetHashCode()
  RVA=0x09C7FF60  token=0x6000D86  System.String ToString()
  RVA=0x09C7FC8C  token=0x6000D87  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint4
TYPE:  sealed struct
TOKEN: 0x200005A
SIZE:  0x20
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            System.UInt32                   x  // 0x10
  public            System.UInt32                   y  // 0x14
  public            System.UInt32                   z  // 0x18
  public            System.UInt32                   w  // 0x1c
PROPERTIES:
  Item  get=0x03D55FF0  set=0x03D56010
METHODS:
  RVA=0x03D517E0  token=0x6000D88  System.Void .ctor(System.UInt32 x, System.UInt32 y, System.UInt32 z, System.UInt32 w)
  RVA=0x03D83330  token=0x6000D89  System.Void .ctor(System.UInt32 x, System.UInt32 y, Unity.Mathematics.uint2 zw)
  RVA=0x03D83430  token=0x6000D8A  System.Void .ctor(System.UInt32 x, Unity.Mathematics.uint2 yz, System.UInt32 w)
  RVA=0x03D83400  token=0x6000D8B  System.Void .ctor(System.UInt32 x, Unity.Mathematics.uint3 yzw)
  RVA=0x03D83450  token=0x6000D8C  System.Void .ctor(Unity.Mathematics.uint2 xy, System.UInt32 z, System.UInt32 w)
  RVA=0x03D83350  token=0x6000D8D  System.Void .ctor(Unity.Mathematics.uint2 xy, Unity.Mathematics.uint2 zw)
  RVA=0x03D833E0  token=0x6000D8E  System.Void .ctor(Unity.Mathematics.uint3 xyz, System.UInt32 w)
  RVA=0x03D5DBB0  token=0x6000D8F  System.Void .ctor(Unity.Mathematics.uint4 xyzw)
  RVA=0x03D83390  token=0x6000D90  System.Void .ctor(System.UInt32 v)
  RVA=0x09C754EC  token=0x6000D91  System.Void .ctor(System.Boolean v)
  RVA=0x09C75508  token=0x6000D92  System.Void .ctor(Unity.Mathematics.bool4 v)
  RVA=0x03D83390  token=0x6000D93  System.Void .ctor(System.Int32 v)
  RVA=0x03D5DBB0  token=0x6000D94  System.Void .ctor(Unity.Mathematics.int4 v)
  RVA=0x04D60488  token=0x6000D95  System.Void .ctor(System.Single v)
  RVA=0x04D60424  token=0x6000D96  System.Void .ctor(Unity.Mathematics.float4 v)
  RVA=0x09C806A4  token=0x6000D97  System.Void .ctor(System.Double v)
  RVA=0x09C806D0  token=0x6000D98  System.Void .ctor(Unity.Mathematics.double4 v)
  RVA=0x03D7B6A0  token=0x6000D99  Unity.Mathematics.uint4 op_Implicit(System.UInt32 v)
  RVA=0x03D7B6A0  token=0x6000D9A  Unity.Mathematics.uint4 op_Explicit(System.Int32 v)
  RVA=0x09C3D070  token=0x6000D9B  Unity.Mathematics.uint4 op_Explicit(Unity.Mathematics.int4 v)
  RVA=0x09C58070  token=0x6000D9C  Unity.Mathematics.uint4 op_Explicit(System.Single v)
  RVA=0x09C580B8  token=0x6000D9D  Unity.Mathematics.uint4 op_Explicit(Unity.Mathematics.float4 v)
  RVA=0x09C58088  token=0x6000D9E  Unity.Mathematics.uint4 op_Explicit(System.Double v)
  RVA=0x09C58028  token=0x6000D9F  Unity.Mathematics.uint4 op_Explicit(Unity.Mathematics.double4 v)
  RVA=0x03D834D0  token=0x6000DA0  Unity.Mathematics.uint4 op_Multiply(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs)
  RVA=0x03D83500  token=0x6000DA1  Unity.Mathematics.uint4 op_Multiply(Unity.Mathematics.uint4 lhs, System.UInt32 rhs)
  RVA=0x03D83BC0  token=0x6000DA2  Unity.Mathematics.uint4 op_Multiply(System.UInt32 lhs, Unity.Mathematics.uint4 rhs)
  RVA=0x03D834A0  token=0x6000DA3  Unity.Mathematics.uint4 op_Addition(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs)
  RVA=0x03D83470  token=0x6000DA4  Unity.Mathematics.uint4 op_Addition(Unity.Mathematics.uint4 lhs, System.UInt32 rhs)
  RVA=0x03D83C40  token=0x6000DA5  Unity.Mathematics.uint4 op_Subtraction(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs)
  RVA=0x03D83560  token=0x6000DA6  Unity.Mathematics.uint4 op_Subtraction(Unity.Mathematics.uint4 lhs, System.UInt32 rhs)
  RVA=0x09C80730  token=0x6000DA7  Unity.Mathematics.bool4 op_GreaterThan(Unity.Mathematics.uint4 lhs, System.UInt32 rhs)
  RVA=0x03D83B90  token=0x6000DA8  Unity.Mathematics.uint4 op_LeftShift(Unity.Mathematics.uint4 x, System.Int32 n)
  RVA=0x03D83BF0  token=0x6000DA9  Unity.Mathematics.uint4 op_RightShift(Unity.Mathematics.uint4 x, System.Int32 n)
  RVA=0x09C8070C  token=0x6000DAA  Unity.Mathematics.bool4 op_Equality(Unity.Mathematics.uint4 lhs, System.UInt32 rhs)
  RVA=0x028B5880  token=0x6000DAB  Unity.Mathematics.uint4 op_OnesComplement(Unity.Mathematics.uint4 val)
  RVA=0x028B5820  token=0x6000DAC  Unity.Mathematics.uint4 op_BitwiseAnd(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs)
  RVA=0x03D83B60  token=0x6000DAD  Unity.Mathematics.uint4 op_BitwiseAnd(Unity.Mathematics.uint4 lhs, System.UInt32 rhs)
  RVA=0x028B58B0  token=0x6000DAE  Unity.Mathematics.uint4 op_BitwiseOr(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs)
  RVA=0x028B5850  token=0x6000DAF  Unity.Mathematics.uint4 op_ExclusiveOr(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs)
  RVA=0x05688F1C  token=0x6000DB2  System.Boolean Equals(Unity.Mathematics.uint4 rhs)
  RVA=0x09C8036C  token=0x6000DB3  System.Boolean Equals(System.Object o)
  RVA=0x09C803D8  token=0x6000DB4  System.Int32 GetHashCode()
  RVA=0x09C80548  token=0x6000DB5  System.String ToString()
  RVA=0x09C803F4  token=0x6000DB6  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint4x2
TYPE:  sealed struct
TOKEN: 0x200005C
SIZE:  0x30
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.uint4         c0  // 0x10
  public            Unity.Mathematics.uint4         c1  // 0x20
METHODS:
  RVA=0x03D553F0  token=0x6000DB7  System.Void .ctor(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1)
  RVA=0x03D83620  token=0x6000DB8  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11, System.UInt32 m20, System.UInt32 m21, System.UInt32 m30, System.UInt32 m31)
  RVA=0x03D835C0  token=0x6000DB9  System.Void .ctor(System.UInt32 v)
  RVA=0x04D605C0  token=0x6000DBA  System.Void .ctor(System.Boolean v)
  RVA=0x04D60738  token=0x6000DBB  System.Void .ctor(Unity.Mathematics.bool4x2 v)
  RVA=0x03D835C0  token=0x6000DBC  System.Void .ctor(System.Int32 v)
  RVA=0x09C75B18  token=0x6000DBD  System.Void .ctor(Unity.Mathematics.int4x2 v)
  RVA=0x04D606A0  token=0x6000DBE  System.Void .ctor(System.Single v)
  RVA=0x09C80CCC  token=0x6000DBF  System.Void .ctor(Unity.Mathematics.float4x2 v)
  RVA=0x04D60634  token=0x6000DC0  System.Void .ctor(System.Double v)
  RVA=0x09C80C30  token=0x6000DC1  System.Void .ctor(Unity.Mathematics.double4x2 v)
  RVA=0x09C75594  token=0x6000DC2  System.Boolean Equals(Unity.Mathematics.uint4x2 rhs)
  RVA=0x09C80754  token=0x6000DC3  System.Boolean Equals(System.Object o)
  RVA=0x09C807C8  token=0x6000DC4  System.Int32 GetHashCode()
  RVA=0x09C807EC  token=0x6000DC5  System.String ToString()
  RVA=0x09C80A1C  token=0x6000DC6  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint4x3
TYPE:  sealed struct
TOKEN: 0x200005D
SIZE:  0x40
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.uint4         c0  // 0x10
  public            Unity.Mathematics.uint4         c1  // 0x20
  public            Unity.Mathematics.uint4         c2  // 0x30
METHODS:
  RVA=0x03D6B600  token=0x6000DC7  System.Void .ctor(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1, Unity.Mathematics.uint4 c2)
  RVA=0x03D83750  token=0x6000DC8  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m30, System.UInt32 m31, System.UInt32 m32)
  RVA=0x03D837D0  token=0x6000DC9  System.Void .ctor(System.UInt32 v)
  RVA=0x04D60B74  token=0x6000DCA  System.Void .ctor(System.Boolean v)
  RVA=0x04D60918  token=0x6000DCB  System.Void .ctor(Unity.Mathematics.bool4x3 v)
  RVA=0x03D837D0  token=0x6000DCC  System.Void .ctor(System.Int32 v)
  RVA=0x09C76260  token=0x6000DCD  System.Void .ctor(Unity.Mathematics.int4x3 v)
  RVA=0x04D60A24  token=0x6000DCE  System.Void .ctor(System.Single v)
  RVA=0x09C813A0  token=0x6000DCF  System.Void .ctor(Unity.Mathematics.float4x3 v)
  RVA=0x04D60878  token=0x6000DD0  System.Void .ctor(System.Double v)
  RVA=0x09C81418  token=0x6000DD1  System.Void .ctor(Unity.Mathematics.double4x3 v)
  RVA=0x09C75BFC  token=0x6000DD2  System.Boolean Equals(Unity.Mathematics.uint4x3 rhs)
  RVA=0x09C80D20  token=0x6000DD3  System.Boolean Equals(System.Object o)
  RVA=0x09C80D9C  token=0x6000DD4  System.Int32 GetHashCode()
  RVA=0x09C80DCC  token=0x6000DD5  System.String ToString()
  RVA=0x09C810CC  token=0x6000DD6  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint4x4
TYPE:  sealed struct
TOKEN: 0x200005E
SIZE:  0x50
IMPLEMENTS: System.IEquatable`1 System.IFormattable
FIELDS:
  public            Unity.Mathematics.uint4         c0  // 0x10
  public            Unity.Mathematics.uint4         c1  // 0x20
  public            Unity.Mathematics.uint4         c2  // 0x30
  public            Unity.Mathematics.uint4         c3  // 0x40
  public    static readonly Unity.Mathematics.uint4x4       identity  // static @ 0x0
METHODS:
  RVA=0x03D7E4A0  token=0x6000DD7  System.Void .ctor(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1, Unity.Mathematics.uint4 c2, Unity.Mathematics.uint4 c3)
  RVA=0x03A4DCE0  token=0x6000DD8  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m23, System.UInt32 m30, System.UInt32 m31, System.UInt32 m32, System.UInt32 m33)
  RVA=0x03D83900  token=0x6000DD9  System.Void .ctor(System.UInt32 v)
  RVA=0x04D60C18  token=0x6000DDA  System.Void .ctor(System.Boolean v)
  RVA=0x04D60F6C  token=0x6000DDB  System.Void .ctor(Unity.Mathematics.bool4x4 v)
  RVA=0x03D83900  token=0x6000DDC  System.Void .ctor(System.Int32 v)
  RVA=0x09C76C10  token=0x6000DDD  System.Void .ctor(Unity.Mathematics.int4x4 v)
  RVA=0x04D60DBC  token=0x6000DDE  System.Void .ctor(System.Single v)
  RVA=0x09C81E50  token=0x6000DDF  System.Void .ctor(Unity.Mathematics.float4x4 v)
  RVA=0x04D60CEC  token=0x6000DE0  System.Void .ctor(System.Double v)
  RVA=0x09C81D20  token=0x6000DE1  System.Void .ctor(Unity.Mathematics.double4x4 v)
  RVA=0x09C763F8  token=0x6000DE2  System.Boolean Equals(Unity.Mathematics.uint4x4 rhs)
  RVA=0x09C81500  token=0x6000DE3  System.Boolean Equals(System.Object o)
  RVA=0x09C81584  token=0x6000DE4  System.Int32 GetHashCode()
  RVA=0x09C815BC  token=0x6000DE5  System.String ToString()
  RVA=0x09C8198C  token=0x6000DE6  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  RVA=0x03A4DBF0  token=0x6000DE7  System.Void .cctor()
END_CLASS

