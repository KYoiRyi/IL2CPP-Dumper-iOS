// ========================================================
// Dumped by @desirepro
// Assembly: MagicaCloth.dll
// Classes:  308
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000005  // size: 0x14
    public sealed struct ReductionWeightMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaReductionMesh.ReductionMesh.ReductionWeightMode Distance;  // const
        public static MagicaReductionMesh.ReductionMesh.ReductionWeightMode Average;  // const
        public static MagicaReductionMesh.ReductionMesh.ReductionWeightMode DistanceAverage;  // const

    }

    // TypeToken: 0x2000009  // size: 0x18
    public class MeshIndexData
    {
        // Fields
        public System.Collections.Generic.List<System.UInt32> meshIndexPackList;  // 0x10

        // Methods
        // RVA: 0x0895132C  token: 0x6000021
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000A  // size: 0x48
    public class MeshInfo
    {
        // Fields
        public System.Int32 meshIndex;  // 0x10
        public UnityEngine.Mesh mesh;  // 0x18
        public System.Collections.Generic.List<UnityEngine.Vector3> vertices;  // 0x20
        public System.Collections.Generic.List<UnityEngine.Vector3> normals;  // 0x28
        public System.Collections.Generic.List<UnityEngine.Vector4> tangents;  // 0x30
        public System.Collections.Generic.List<UnityEngine.BoneWeight> boneWeights;  // 0x38
        public System.Collections.Generic.List<System.Int32> parents;  // 0x40

        // Properties
        System.Int32 VertexCount { get; /* RVA: 0x089515A8 */ }

        // Methods
        // RVA: 0x089513A4  token: 0x6000023
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000C  // size: 0x18
    public class WeightData
    {
        // Fields
        public System.Int32 boneIndex;  // 0x10
        public System.Single boneWeight;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x600004B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000D  // size: 0x58
    public class Vertex
    {
        // Fields
        public System.Int32 meshIndex;  // 0x10
        public System.Int32 vertexIndex;  // 0x14
        public UnityEngine.Vector3 wpos;  // 0x18
        public UnityEngine.Vector3 wnor;  // 0x24
        public UnityEngine.Vector3 wtan;  // 0x30
        public System.Single tanw;  // 0x3c
        public UnityEngine.Vector2 uv;  // 0x40
        public System.Int32 parentIndex;  // 0x48
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.WeightData> boneWeightList;  // 0x50

        // Methods
        // RVA: 0x0895ADDC  token: 0x600004C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000E  // size: 0x30
    public class MeshInfo
    {
        // Fields
        public System.Int32 index;  // 0x10
        public UnityEngine.Mesh mesh;  // 0x18
        public System.Int32 vertexCount;  // 0x20
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.Vertex> vertexList;  // 0x28

        // Methods
        // RVA: 0x08951530  token: 0x600004D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000010  // size: 0x18
    public sealed class <>c__DisplayClass20_0
    {
        // Fields
        public MagicaReductionMesh.MeshData.WeightData w;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x600005C
        public System.Void .ctor() { }
        // RVA: 0x08959240  token: 0x600005D
        private System.Boolean <CalcBoneWeight_DistanceAverage>b__1(MagicaReductionMesh.MeshData.WeightData wdata) { }

    }

    // TypeToken: 0x2000011  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly MagicaReductionMesh.MeshData.ShareVertex.<>c <>9;  // static @ 0x0
        public static System.Comparison<MagicaReductionMesh.MeshData.WeightData> <>9__20_0;  // static @ 0x8
        public static System.Comparison<MagicaReductionMesh.MeshData.WeightData> <>9__21_0;  // static @ 0x10
        public static System.Comparison<MagicaReductionMesh.MeshData.WeightData> <>9__23_0;  // static @ 0x18

        // Methods
        // RVA: 0x08959364  token: 0x600005E
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600005F
        public System.Void .ctor() { }
        // RVA: 0x089591D8  token: 0x6000060
        private System.Int32 <CalcBoneWeight_DistanceAverage>b__20_0(MagicaReductionMesh.MeshData.WeightData a, MagicaReductionMesh.MeshData.WeightData b) { }
        // RVA: 0x089591D8  token: 0x6000061
        private System.Int32 <CalcBoneWeight_Average>b__21_0(MagicaReductionMesh.MeshData.WeightData a, MagicaReductionMesh.MeshData.WeightData b) { }
        // RVA: 0x089591D8  token: 0x6000062
        private System.Int32 <CalcBoneWeight_Distance>b__23_0(MagicaReductionMesh.MeshData.WeightData a, MagicaReductionMesh.MeshData.WeightData b) { }

    }

    // TypeToken: 0x2000012  // size: 0x18
    public sealed class <>c__DisplayClass21_0
    {
        // Fields
        public MagicaReductionMesh.MeshData.WeightData w;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000063
        public System.Void .ctor() { }
        // RVA: 0x08959240  token: 0x6000064
        private System.Boolean <CalcBoneWeight_Average>b__1(MagicaReductionMesh.MeshData.WeightData wdata) { }

    }

    // TypeToken: 0x2000013  // size: 0x18
    public sealed class <>c__DisplayClass23_0
    {
        // Fields
        public MagicaReductionMesh.MeshData.WeightData w;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000065
        public System.Void .ctor() { }
        // RVA: 0x08959240  token: 0x6000066
        private System.Boolean <CalcBoneWeight_Distance>b__1(MagicaReductionMesh.MeshData.WeightData wdata) { }

    }

    // TypeToken: 0x200000F  // size: 0xE8
    public class ShareVertex
    {
        // Fields
        public System.Int32 sindex;  // 0x10
        public UnityEngine.Vector3 wpos;  // 0x14
        public UnityEngine.Vector3 wnor;  // 0x20
        public UnityEngine.Vector3 wtan;  // 0x2c
        public System.Single tanw;  // 0x38
        public UnityEngine.Vector2 uv;  // 0x3c
        public UnityEngine.Matrix4x4 worldToLocalMatrix;  // 0x44
        public UnityEngine.Matrix4x4 bindpose;  // 0x84
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.WeightData> boneWeightList;  // 0xc8
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.Vertex> vertexList;  // 0xd0
        public System.Collections.Generic.HashSet<MagicaReductionMesh.MeshData.ShareVertex> linkShareVertexSet;  // 0xd8
        public System.Collections.Generic.HashSet<MagicaReductionMesh.MeshData.Triangle> linkTriangleSet;  // 0xe0

        // Methods
        // RVA: 0x08954A28  token: 0x600004E
        public System.Void AddLink(MagicaReductionMesh.MeshData.ShareVertex mv) { }
        // RVA: 0x08956FF4  token: 0x600004F
        public System.Void ReplaseLink(MagicaReductionMesh.MeshData.ShareVertex old, MagicaReductionMesh.MeshData.ShareVertex mv) { }
        // RVA: 0x08956D0C  token: 0x6000050
        public System.Void RecalcCoordinate() { }
        // RVA: 0x089568CC  token: 0x6000051
        public System.Void CalcNormalTangentFromTriangle() { }
        // RVA: 0x089567D8  token: 0x6000052
        public UnityEngine.Vector3 CalcLocalPos(UnityEngine.Vector3 pos) { }
        // RVA: 0x08956728  token: 0x6000053
        public UnityEngine.Vector3 CalcLocalDir(UnityEngine.Vector3 dir) { }
        // RVA: 0x08956B08  token: 0x6000054
        public UnityEngine.Matrix4x4 CalcWorldToLocalMatrix() { }
        // RVA: 0x089566EC  token: 0x6000055
        public System.Void CalcBoneWeight(MagicaReductionMesh.ReductionMesh.ReductionWeightMode weightMode, System.Single weightPow) { }
        // RVA: 0x08955324  token: 0x6000056
        private System.Void CalcBoneWeight_DistanceAverage(System.Single weightPow) { }
        // RVA: 0x08954CB0  token: 0x6000057
        private System.Void CalcBoneWeight_Average() { }
        // RVA: 0x08954A80  token: 0x6000058
        private System.Void AdjustWeight(System.Collections.Generic.List<MagicaReductionMesh.MeshData.WeightData> sumlist) { }
        // RVA: 0x08955E08  token: 0x6000059
        private System.Void CalcBoneWeight_Distance(System.Single weightPow) { }
        // RVA: 0x08956C1C  token: 0x600005A
        public UnityEngine.BoneWeight GetBoneWeight() { }
        // RVA: 0x089570AC  token: 0x600005B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000015  // size: 0x18
    public sealed class <>c__DisplayClass9_0
    {
        // Fields
        public System.Int32 edgev0;  // 0x10
        public System.Int32 edgev1;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x6000070
        public System.Void .ctor() { }
        // RVA: 0x089592D4  token: 0x6000071
        private System.Boolean <GetNonEdgeVertex>b__0(MagicaReductionMesh.MeshData.ShareVertex sv) { }

    }

    // TypeToken: 0x2000014  // size: 0x40
    public class Triangle
    {
        // Fields
        public System.Int32 tindex;  // 0x10
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.ShareVertex> shareVertexList;  // 0x18
        public UnityEngine.Vector3 wnor;  // 0x20
        public UnityEngine.Vector3 wtan;  // 0x2c
        public System.Boolean flipLock;  // 0x38

        // Methods
        // RVA: 0x08958BB0  token: 0x6000067
        public System.Void GetEdge(System.UInt32& edge0, System.UInt32& edge1, System.UInt32& edge2) { }
        // RVA: 0x089583F8  token: 0x6000068
        public UnityEngine.Vector3 CalcTriangleNormal() { }
        // RVA: 0x08958AB8  token: 0x6000069
        public System.Void Flip() { }
        // RVA: 0x08958744  token: 0x600006A
        public UnityEngine.Vector3 CalcTriangleTangent() { }
        // RVA: 0x08958D1C  token: 0x600006B
        public MagicaReductionMesh.MeshData.ShareVertex GetNonEdgeVertex(System.Int32 edgev0, System.Int32 edgev1) { }
        // RVA: 0x08958ED8  token: 0x600006C
        public System.UInt64 GetTriangleHash() { }
        // RVA: 0x08958DF0  token: 0x600006D
        public static System.Single GetTriangleArea(MagicaReductionMesh.MeshData.ShareVertex sv0, MagicaReductionMesh.MeshData.ShareVertex sv1, MagicaReductionMesh.MeshData.ShareVertex sv2) { }
        // RVA: 0x08958F8C  token: 0x600006E
        public virtual System.String ToString() { }
        // RVA: 0x08959160  token: 0x600006F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000016  // size: 0x18
    public class Line
    {
        // Fields
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.ShareVertex> shareVertexList;  // 0x10

        // Methods
        // RVA: 0x08945FF4  token: 0x6000072
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000017  // size: 0x14
    public sealed struct UvWrapMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaReductionMesh.MeshData.UvWrapMode None;  // const
        public static MagicaReductionMesh.MeshData.UvWrapMode Sphere;  // const

    }

    // TypeToken: 0x2000018  // size: 0x28
    public class Square
    {
        // Fields
        public System.UInt64 shash;  // 0x10
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.Triangle> triangleList;  // 0x18
        public System.Single angle;  // 0x20

        // Methods
        // RVA: 0x0895721C  token: 0x6000073
        public virtual System.String ToString() { }
        // RVA: 0x089573A4  token: 0x6000074
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000019  // size: 0x38
    public class Tetra
    {
        // Fields
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.ShareVertex> shareVertexList;  // 0x10
        public UnityEngine.Vector3 circumCenter;  // 0x18
        public System.Single circumRadius;  // 0x24
        public UnityEngine.Vector3 tetraCenter;  // 0x28
        public System.Single tetraSize;  // 0x34

        // Methods
        // RVA: 0x08958264  token: 0x6000075
        public System.Void .ctor() { }
        // RVA: 0x089582DC  token: 0x6000076
        public System.Void .ctor(MagicaReductionMesh.MeshData.ShareVertex a, MagicaReductionMesh.MeshData.ShareVertex b, MagicaReductionMesh.MeshData.ShareVertex c, MagicaReductionMesh.MeshData.ShareVertex d) { }
        // RVA: 0x08957ECC  token: 0x6000077
        public System.UInt64 GetTetraHash() { }
        // RVA: 0x0895741C  token: 0x6000078
        public System.Void CalcCircumcircle() { }
        // RVA: 0x08957FC0  token: 0x6000079
        public System.Boolean IntersectCircumcircle(UnityEngine.Vector3 pos) { }
        // RVA: 0x08957D2C  token: 0x600007A
        public System.Boolean CheckSame(MagicaReductionMesh.MeshData.Tetra tri) { }
        // RVA: 0x08957DAC  token: 0x600007B
        public System.Boolean ContainsPoint(MagicaReductionMesh.MeshData.ShareVertex p1) { }
        // RVA: 0x08957E00  token: 0x600007C
        public System.Boolean ContainsPoint(MagicaReductionMesh.MeshData.ShareVertex p1, MagicaReductionMesh.MeshData.ShareVertex p2, MagicaReductionMesh.MeshData.ShareVertex p3, MagicaReductionMesh.MeshData.ShareVertex p4) { }
        // RVA: 0x08957A84  token: 0x600007D
        public System.Void CalcSize() { }
        // RVA: 0x0895800C  token: 0x600007E
        public System.Boolean Verification() { }

    }

    // TypeToken: 0x200001A  // size: 0x20
    public class LinkInfo
    {
        // Fields
        public MagicaReductionMesh.MeshData.ShareVertex sv;  // 0x10
        public System.Single length;  // 0x18
        public System.Int32 count;  // 0x1c

        // Methods
        // RVA: 0x0350B670  token: 0x600007F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001B  // size: 0x20
    public class VertexLengthInfo
    {
        // Fields
        public MagicaReductionMesh.MeshData.ShareVertex sv;  // 0x10
        public System.Single length;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000080
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001C  // size: 0x18
    public sealed class <>c__DisplayClass65_0
    {
        // Fields
        public System.Single weightLength;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000081
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001D  // size: 0x20
    public sealed class <>c__DisplayClass65_1
    {
        // Fields
        public MagicaReductionMesh.MeshData.Vertex vt;  // 0x10
        public MagicaReductionMesh.MeshData.<>c__DisplayClass65_0 CS$<>8__locals1;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000082
        public System.Void .ctor() { }
        // RVA: 0x08959268  token: 0x6000083
        private System.Boolean <CreateOriginalMeshInfo>b__0(MagicaReductionMesh.MeshData.ShareVertex sv) { }

    }

    // TypeToken: 0x200001E  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly MagicaReductionMesh.MeshData.<>c <>9;  // static @ 0x0
        public static System.Comparison<MagicaReductionMesh.MeshData.VertexLengthInfo> <>9__69_0;  // static @ 0x8

        // Methods
        // RVA: 0x08959300  token: 0x6000084
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000085
        public System.Void .ctor() { }
        // RVA: 0x08959210  token: 0x6000086
        private System.Int32 <SearchNearPointList>b__69_0(MagicaReductionMesh.MeshData.VertexLengthInfo a, MagicaReductionMesh.MeshData.VertexLengthInfo b) { }

    }

    // TypeToken: 0x2000021  // size: 0x40
    public class Point
    {
        // Fields
        public MagicaReductionMesh.MeshData.ShareVertex shareVertex;  // 0x10
        public UnityEngine.Vector3 pos;  // 0x18
        public UnityEngine.Vector3Int grid;  // 0x24
        public MagicaReductionMesh.NearPointReduction.Point nearPoint;  // 0x30
        public System.Single nearDist;  // 0x38

        // Methods
        // RVA: 0x0350B670  token: 0x6000099
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000023  // size: 0x28
    public class Point
    {
        // Fields
        public MagicaReductionMesh.MeshData.ShareVertex shareVertex;  // 0x10
        public MagicaReductionMesh.PolygonLinkReduction.Point nearPoint;  // 0x18
        public System.Single nearDist;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x60000A4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000026  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly MagicaCloth.BaseCloth.<>c <>9;  // static @ 0x0
        public static System.Func<UnityEngine.Renderer,System.Boolean> <>9__106_0;  // static @ 0x8

        // Methods
        // RVA: 0x0896DF90  token: 0x600011B
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600011C
        public System.Void .ctor() { }
        // RVA: 0x0896DBC0  token: 0x600011D
        private System.Boolean <GetCullRenderListCount>b__106_0(UnityEngine.Renderer x) { }

    }

    // TypeToken: 0x2000030  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly MagicaCloth.MagicaPhysicsManager.<>c <>9;  // static @ 0x0
        public static UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunction <>9__69_11;  // static @ 0x8
        public static UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunction <>9__69_12;  // static @ 0x10
        public static UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunction <>9__69_13;  // static @ 0x18
        public static UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunction <>9__69_14;  // static @ 0x20
        public static UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunction <>9__69_15;  // static @ 0x28
        public static UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunction <>9__69_16;  // static @ 0x30
        public static UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunction <>9__69_17;  // static @ 0x38
        public static System.Predicate<UnityEngine.LowLevel.PlayerLoopSystem> <>9__69_0;  // static @ 0x40
        public static System.Predicate<UnityEngine.LowLevel.PlayerLoopSystem> <>9__69_1;  // static @ 0x48
        public static System.Predicate<UnityEngine.LowLevel.PlayerLoopSystem> <>9__69_2;  // static @ 0x50
        public static System.Predicate<UnityEngine.LowLevel.PlayerLoopSystem> <>9__69_3;  // static @ 0x58
        public static System.Predicate<UnityEngine.LowLevel.PlayerLoopSystem> <>9__69_4;  // static @ 0x60
        public static System.Predicate<UnityEngine.LowLevel.PlayerLoopSystem> <>9__69_5;  // static @ 0x68
        public static System.Predicate<UnityEngine.LowLevel.PlayerLoopSystem> <>9__69_6;  // static @ 0x70
        public static System.Predicate<UnityEngine.LowLevel.PlayerLoopSystem> <>9__69_7;  // static @ 0x78
        public static System.Predicate<UnityEngine.LowLevel.PlayerLoopSystem> <>9__69_8;  // static @ 0x80
        public static System.Predicate<UnityEngine.LowLevel.PlayerLoopSystem> <>9__69_9;  // static @ 0x88
        public static System.Predicate<UnityEngine.LowLevel.PlayerLoopSystem> <>9__69_10;  // static @ 0x90

        // Methods
        // RVA: 0x03D14570  token: 0x60001AF
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x60001B0
        public System.Void .ctor() { }
        // RVA: 0x023136E0  token: 0x60001B1
        private System.Void <SetCustomGameLoop>b__69_11() { }
        // RVA: 0x02313910  token: 0x60001B2
        private System.Void <SetCustomGameLoop>b__69_12() { }
        // RVA: 0x02313440  token: 0x60001B3
        private System.Void <SetCustomGameLoop>b__69_13() { }
        // RVA: 0x023134E0  token: 0x60001B4
        private System.Void <SetCustomGameLoop>b__69_14() { }
        // RVA: 0x02313550  token: 0x60001B5
        private System.Void <SetCustomGameLoop>b__69_15() { }
        // RVA: 0x023135D0  token: 0x60001B6
        private System.Void <SetCustomGameLoop>b__69_16() { }
        // RVA: 0x02313650  token: 0x60001B7
        private System.Void <SetCustomGameLoop>b__69_17() { }
        // RVA: 0x033CE2B0  token: 0x60001B8
        private System.Boolean <SetCustomGameLoop>b__69_0(UnityEngine.LowLevel.PlayerLoopSystem s) { }
        // RVA: 0x033CE1E0  token: 0x60001B9
        private System.Boolean <SetCustomGameLoop>b__69_1(UnityEngine.LowLevel.PlayerLoopSystem s) { }
        // RVA: 0x033CE170  token: 0x60001BA
        private System.Boolean <SetCustomGameLoop>b__69_2(UnityEngine.LowLevel.PlayerLoopSystem h) { }
        // RVA: 0x033CE110  token: 0x60001BB
        private System.Boolean <SetCustomGameLoop>b__69_3(UnityEngine.LowLevel.PlayerLoopSystem s) { }
        // RVA: 0x033CE310  token: 0x60001BC
        private System.Boolean <SetCustomGameLoop>b__69_4(UnityEngine.LowLevel.PlayerLoopSystem h) { }
        // RVA: 0x033CE0B0  token: 0x60001BD
        private System.Boolean <SetCustomGameLoop>b__69_5(UnityEngine.LowLevel.PlayerLoopSystem s) { }
        // RVA: 0x033CDF10  token: 0x60001BE
        private System.Boolean <SetCustomGameLoop>b__69_6(UnityEngine.LowLevel.PlayerLoopSystem h) { }
        // RVA: 0x033CE050  token: 0x60001BF
        private System.Boolean <SetCustomGameLoop>b__69_7(UnityEngine.LowLevel.PlayerLoopSystem s) { }
        // RVA: 0x033CE240  token: 0x60001C0
        private System.Boolean <SetCustomGameLoop>b__69_8(UnityEngine.LowLevel.PlayerLoopSystem h) { }
        // RVA: 0x033CDFF0  token: 0x60001C1
        private System.Boolean <SetCustomGameLoop>b__69_9(UnityEngine.LowLevel.PlayerLoopSystem s) { }
        // RVA: 0x033CDEA0  token: 0x60001C2
        private System.Boolean <SetCustomGameLoop>b__69_10(UnityEngine.LowLevel.PlayerLoopSystem h) { }

    }

    // TypeToken: 0x2000031  // size: 0x20
    public sealed class <>c__DisplayClass70_0
    {
        // Fields
        public System.Type t;  // 0x10
        public System.Func<UnityEngine.LowLevel.PlayerLoopSystem,System.Boolean> <>9__0;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60001C3
        public System.Void .ctor() { }
        // RVA: 0x03565FE0  token: 0x60001C4
        private System.Boolean <CheckRegist>b__0(UnityEngine.LowLevel.PlayerLoopSystem x) { }

    }

    // TypeToken: 0x2000036  // size: 0x18
    public sealed class <>c__DisplayClass20_0
    {
        // Fields
        public System.Int32 partsId;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000220
        public System.Void .ctor() { }
        // RVA: 0x0896DF60  token: 0x6000221
        private System.Boolean <RemoveAvatarParts>b__0(MagicaCloth.MagicaAvatarParts p) { }

    }

    // TypeToken: 0x2000038  // size: 0x14
    public sealed struct ConnectionMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.BoneClothTarget.ConnectionMode Line;  // const
        public static MagicaCloth.BoneClothTarget.ConnectionMode MeshAutomatic;  // const
        public static MagicaCloth.BoneClothTarget.ConnectionMode MeshSequentialLoop;  // const
        public static MagicaCloth.BoneClothTarget.ConnectionMode MeshSequentialNoLoop;  // const

    }

    // TypeToken: 0x200003A  // size: 0x18
    public class RestoreDistanceWork
    {
        // Fields
        public System.UInt32 vertexPair;  // 0x10
        public System.Single dist;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x600025D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003B  // size: 0x20
    public class PenetrationBone
    {
        // Fields
        public UnityEngine.Transform bone;  // 0x10
        public UnityEngine.Transform childBone;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600025E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003C  // size: 0x30
    public class PenetrationWork
    {
        // Fields
        public UnityEngine.Transform bone;  // 0x10
        public UnityEngine.Transform childBone;  // 0x18
        public System.Int32 boneIndex;  // 0x20
        public System.Single distance;  // 0x24
        public System.Single weight;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x600025F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003D  // size: 0x30
    public class VertexInfo
    {
        // Fields
        public System.Int32 vertexIndex;  // 0x10
        public System.Int32 parentVertexIndex;  // 0x14
        public System.Collections.Generic.List<System.Int32> childVertexList;  // 0x18
        public MagicaCloth.ClothData.VertexInfo parentInfo;  // 0x20
        public System.Collections.Generic.List<MagicaCloth.ClothData.VertexInfo> childInfoList;  // 0x28

        // Methods
        // RVA: 0x0896E058  token: 0x6000260
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200003E  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly MagicaCloth.ClothData.<>c <>9;  // static @ 0x0
        public static System.Comparison<MagicaCloth.ClothData.RestoreDistanceWork> <>9__108_0;  // static @ 0x8
        public static System.Comparison<MagicaCloth.ClothData.RestoreDistanceWork> <>9__108_1;  // static @ 0x10
        public static System.Comparison<MagicaCloth.PenetrationConstraint.PenetrationData> <>9__108_2;  // static @ 0x18

        // Methods
        // RVA: 0x0896DFF4  token: 0x6000261
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000262
        public System.Void .ctor() { }
        // RVA: 0x0896DB78  token: 0x6000263
        private System.Int32 <CreateConstraintData>b__108_0(MagicaCloth.ClothData.RestoreDistanceWork a, MagicaCloth.ClothData.RestoreDistanceWork b) { }
        // RVA: 0x0896DB78  token: 0x6000264
        private System.Int32 <CreateConstraintData>b__108_1(MagicaCloth.ClothData.RestoreDistanceWork a, MagicaCloth.ClothData.RestoreDistanceWork b) { }
        // RVA: 0x0896DBA8  token: 0x6000265
        private System.Int32 <CreateConstraintData>b__108_2(MagicaCloth.PenetrationConstraint.PenetrationData a, MagicaCloth.PenetrationConstraint.PenetrationData b) { }

    }

    // TypeToken: 0x200003F  // size: 0x18
    public sealed class <>c__DisplayClass110_0
    {
        // Fields
        public System.Collections.Generic.List<System.Single> meshVertexDepthList;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000266
        public System.Void .ctor() { }
        // RVA: 0x0896DC0C  token: 0x6000267
        private System.Int32 <SortTetra>b__0(System.Int32 a, System.Int32 b) { }

    }

    // TypeToken: 0x2000040  // size: 0x18
    public sealed class <>c__DisplayClass111_0
    {
        // Fields
        public System.Collections.Generic.List<System.Single> meshVertexDepthList;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000268
        public System.Void .ctor() { }
        // RVA: 0x0896DCA8  token: 0x6000269
        private System.Int32 <CheckTetraDirection>b__0(System.UInt64 a, System.UInt64 b) { }

    }

    // TypeToken: 0x2000041  // size: 0x20
    public sealed class <>c__DisplayClass114_0
    {
        // Fields
        public System.Collections.Generic.List<System.Single> depthList;  // 0x10
        public System.Collections.Generic.List<System.Single> nearFixedDistList;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x600026A
        public System.Void .ctor() { }
        // RVA: 0x0896DE54  token: 0x600026B
        private System.Int32 <GetUseParentVertexList>b__0(System.Int32 a, System.Int32 b) { }

    }

    // TypeToken: 0x2000043  // size: 0x14
    public sealed struct Algorithm
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.ClothParams.Algorithm Algorithm_1;  // const
        public static MagicaCloth.ClothParams.Algorithm Algorithm_2;  // const

    }

    // TypeToken: 0x2000044  // size: 0x14
    public sealed struct TeleportMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.ClothParams.TeleportMode Reset;  // const
        public static MagicaCloth.ClothParams.TeleportMode Keep;  // const

    }

    // TypeToken: 0x2000045  // size: 0x14
    public sealed struct AdjustMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.ClothParams.AdjustMode Fixed;  // const
        public static MagicaCloth.ClothParams.AdjustMode XYMove;  // const
        public static MagicaCloth.ClothParams.AdjustMode XZMove;  // const
        public static MagicaCloth.ClothParams.AdjustMode YZMove;  // const

    }

    // TypeToken: 0x2000046  // size: 0x14
    public sealed struct PenetrationMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.ClothParams.PenetrationMode SurfacePenetration;  // const
        public static MagicaCloth.ClothParams.PenetrationMode ColliderPenetration;  // const

    }

    // TypeToken: 0x2000047  // size: 0x14
    public sealed struct PenetrationAxis
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.ClothParams.PenetrationAxis X;  // const
        public static MagicaCloth.ClothParams.PenetrationAxis Y;  // const
        public static MagicaCloth.ClothParams.PenetrationAxis Z;  // const
        public static MagicaCloth.ClothParams.PenetrationAxis InverseX;  // const
        public static MagicaCloth.ClothParams.PenetrationAxis InverseY;  // const
        public static MagicaCloth.ClothParams.PenetrationAxis InverseZ;  // const

    }

    // TypeToken: 0x2000048  // size: 0x14
    public sealed struct ParamType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.ClothParams.ParamType Radius;  // const
        public static MagicaCloth.ClothParams.ParamType Mass;  // const
        public static MagicaCloth.ClothParams.ParamType Gravity;  // const
        public static MagicaCloth.ClothParams.ParamType Drag;  // const
        public static MagicaCloth.ClothParams.ParamType MaxVelocity;  // const
        public static MagicaCloth.ClothParams.ParamType WorldInfluence;  // const
        public static MagicaCloth.ClothParams.ParamType ClampDistance;  // const
        public static MagicaCloth.ClothParams.ParamType ClampPosition;  // const
        public static MagicaCloth.ClothParams.ParamType ClampRotation;  // const
        public static MagicaCloth.ClothParams.ParamType RestoreDistance;  // const
        public static MagicaCloth.ClothParams.ParamType RestoreRotation;  // const
        public static MagicaCloth.ClothParams.ParamType Spring;  // const
        public static MagicaCloth.ClothParams.ParamType AdjustRotation;  // const
        public static MagicaCloth.ClothParams.ParamType AirLine;  // const
        public static MagicaCloth.ClothParams.ParamType TriangleBend;  // const
        public static MagicaCloth.ClothParams.ParamType Volume;  // const
        public static MagicaCloth.ClothParams.ParamType ColliderCollision;  // const
        public static MagicaCloth.ClothParams.ParamType RotationInterpolation;  // const
        public static MagicaCloth.ClothParams.ParamType DistanceDisable;  // const
        public static MagicaCloth.ClothParams.ParamType ExternalForce;  // const
        public static MagicaCloth.ClothParams.ParamType Penetration;  // const
        public static MagicaCloth.ClothParams.ParamType Algorithm;  // const
        public static MagicaCloth.ClothParams.ParamType BaseSkinning;  // const
        public static MagicaCloth.ClothParams.ParamType Max;  // const

    }

    // TypeToken: 0x200004A  // size: 0x28
    public sealed class <>c__DisplayClass2_0
    {
        // Fields
        public MagicaCloth.ClothData clothData;  // 0x10
        public System.Func<System.Int32,System.UInt32> funcUserFlag;  // 0x18
        public MagicaCloth.ClothParams param;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x60002FC
        public System.Void .ctor() { }
        // RVA: 0x08980130  token: 0x60002FD
        private System.UInt32 <ClothInit>b__0(System.Int32 i) { }
        // RVA: 0x089801F0  token: 0x60002FE
        private System.Single <ClothInit>b__1(System.Int32 i) { }
        // RVA: 0x0898024C  token: 0x60002FF
        private Unity.Mathematics.float3 <ClothInit>b__2(System.Int32 i) { }

    }

    // TypeToken: 0x200004F  // size: 0x14
    public sealed struct Axis
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.MagicaMeshSpring.Axis X;  // const
        public static MagicaCloth.MagicaMeshSpring.Axis Y;  // const
        public static MagicaCloth.MagicaMeshSpring.Axis Z;  // const
        public static MagicaCloth.MagicaMeshSpring.Axis InverseX;  // const
        public static MagicaCloth.MagicaMeshSpring.Axis InverseY;  // const
        public static MagicaCloth.MagicaMeshSpring.Axis InverseZ;  // const

    }

    // TypeToken: 0x2000051  // size: 0x20
    public class DeformerSelection : MagicaCloth.IDataHash
    {
        // Fields
        public System.Collections.Generic.List<System.Int32> selectData;  // 0x10
        public System.Collections.Generic.List<System.UInt64> vertexHashList;  // 0x18

        // Methods
        // RVA: 0x08972C0C  token: 0x60003A6
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x08972AB8  token: 0x60003A7
        public System.Boolean Compare(MagicaCloth.SelectionData.DeformerSelection data) { }
        // RVA: 0x08972C48  token: 0x60003A8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000053  // size: 0x28
    public class DeformerData : MagicaCloth.IDataHash
    {
        // Fields
        public System.Int32 deformerDataHash;  // 0x10
        public System.Int32 vertexCount;  // 0x14
        public System.Int32[] useVertexIndexList;  // 0x18
        public System.Single[] weightList;  // 0x20

        // Properties
        System.Int32 UseVertexCount { get; /* RVA: 0x08972AA4 */ }

        // Methods
        // RVA: 0x08972A10  token: 0x60003AF
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x0350B670  token: 0x60003B0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000055  // size: 0x10
    public static class Compute
    {
        // Fields
        public static System.Single Epsilon;  // const
        public static System.Single CollisionFrictionRange;  // const
        public static System.Single FrictionDampingRate;  // const
        public static System.Single FrictionMoveRatio;  // const
        public static System.Single FrictionPower;  // const
        public static System.Single ClampPositionMaxVelocity;  // const
        public static System.Single GlobalColliderMaxMoveDistance;  // const
        public static System.Single GlobalColliderMaxRotationAngle;  // const
        public static System.Single ColliderExtrusionMaxPower;  // const
        public static System.Single ColliderExtrusionDirectionPower;  // const
        public static System.Single ColliderExtrusionDistPower;  // const
        public static System.Single ColliderExtrusionVelocityInfluence;  // const
        public static System.Single MaxWindMain;  // const
        public static System.Single ClampRotationMaxVelocity;  // const
        public static System.Single ClampRotationMaxVelocity2;  // const
        public static System.Single TriangleBendVelocityInfluence;  // const

    }

    // TypeToken: 0x2000056  // size: 0x14
    public sealed struct Error
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.Define.Error None;  // const
        public static MagicaCloth.Define.Error Cancel;  // const
        public static MagicaCloth.Define.Error EmptyData;  // const
        public static MagicaCloth.Define.Error InvalidDataHash;  // const
        public static MagicaCloth.Define.Error TooOldDataVersion;  // const
        public static MagicaCloth.Define.Error HigherDataVersion;  // const
        public static MagicaCloth.Define.Error MeshDataNull;  // const
        public static MagicaCloth.Define.Error MeshDataHashMismatch;  // const
        public static MagicaCloth.Define.Error MeshDataVersionMismatch;  // const
        public static MagicaCloth.Define.Error ClothDataNull;  // const
        public static MagicaCloth.Define.Error ClothDataHashMismatch;  // const
        public static MagicaCloth.Define.Error ClothDataVersionMismatch;  // const
        public static MagicaCloth.Define.Error ClothSelectionHashMismatch;  // const
        public static MagicaCloth.Define.Error ClothSelectionVersionMismatch;  // const
        public static MagicaCloth.Define.Error ClothTargetRootCountMismatch;  // const
        public static MagicaCloth.Define.Error UseTransformNull;  // const
        public static MagicaCloth.Define.Error UseTransformCountZero;  // const
        public static MagicaCloth.Define.Error UseTransformCountMismatch;  // const
        public static MagicaCloth.Define.Error DeformerNull;  // const
        public static MagicaCloth.Define.Error DeformerHashMismatch;  // const
        public static MagicaCloth.Define.Error DeformerVersionMismatch;  // const
        public static MagicaCloth.Define.Error DeformerCountZero;  // const
        public static MagicaCloth.Define.Error DeformerCountMismatch;  // const
        public static MagicaCloth.Define.Error VertexCountZero;  // const
        public static MagicaCloth.Define.Error VertexUseCountZero;  // const
        public static MagicaCloth.Define.Error VertexCountMismatch;  // const
        public static MagicaCloth.Define.Error RootListCountMismatch;  // const
        public static MagicaCloth.Define.Error SelectionDataCountMismatch;  // const
        public static MagicaCloth.Define.Error SelectionCountZero;  // const
        public static MagicaCloth.Define.Error CenterTransformNull;  // const
        public static MagicaCloth.Define.Error SpringDataNull;  // const
        public static MagicaCloth.Define.Error SpringDataHashMismatch;  // const
        public static MagicaCloth.Define.Error SpringDataVersionMismatch;  // const
        public static MagicaCloth.Define.Error TargetObjectNull;  // const
        public static MagicaCloth.Define.Error SharedMeshNull;  // const
        public static MagicaCloth.Define.Error SharedMeshCannotRead;  // const
        public static MagicaCloth.Define.Error SharedMeshDifferent;  // const
        public static MagicaCloth.Define.Error SharedMeshDifferentVertexCount;  // const
        public static MagicaCloth.Define.Error MeshOptimizeMismatch;  // const
        public static MagicaCloth.Define.Error MeshVertexCount65535Over;  // const
        public static MagicaCloth.Define.Error MeshKeepQuads;  // const
        public static MagicaCloth.Define.Error BoneListZero;  // const
        public static MagicaCloth.Define.Error BoneListNull;  // const
        public static MagicaCloth.Define.Error RendererNotFound;  // const
        public static MagicaCloth.Define.Error MeshFilterNotFound;  // const
        public static MagicaCloth.Define.Error BuildNoTransformList;  // const
        public static MagicaCloth.Define.Error BuildReadOnlyPrefab;  // const
        public static MagicaCloth.Define.Error BuildFailedSaveAssets;  // const
        public static MagicaCloth.Define.Error BuildPrefabCannotSaved;  // const
        public static MagicaCloth.Define.Error BuildNotSceneObject;  // const
        public static MagicaCloth.Define.Error BuildInvalidComponent;  // const
        public static MagicaCloth.Define.Error BuildInvalidData;  // const
        public static MagicaCloth.Define.Error BuildInvalidMeshData;  // const
        public static MagicaCloth.Define.Error BuildInvalidGameObject;  // const
        public static MagicaCloth.Define.Error BuildInvalidPrefab;  // const
        public static MagicaCloth.Define.Error BuildInvalidRenderDeformer;  // const
        public static MagicaCloth.Define.Error BuildInvalidScene;  // const
        public static MagicaCloth.Define.Error BuildInvalidSelection;  // const
        public static MagicaCloth.Define.Error BuildMissingDeformer;  // const
        public static MagicaCloth.Define.Error BuildMissingSelection;  // const
        public static MagicaCloth.Define.Error BuildMissingMesh;  // const
        public static MagicaCloth.Define.Error BuildMissingScriptOnPrefab;  // const
        public static MagicaCloth.Define.Error OverlappingTransform;  // const
        public static MagicaCloth.Define.Error AddOverlappingTransform;  // const
        public static MagicaCloth.Define.Error OldDataVersion;  // const
        public static MagicaCloth.Define.Error OldAlgorithm;  // const

    }

    // TypeToken: 0x2000057  // size: 0x10
    public static class OptimizeMesh
    {
        // Fields
        public static System.Int32 Unknown;  // const
        public static System.Int32 Nothing;  // const
        public static System.Int32 Unity2018_On;  // const
        public static System.Int32 Unity2019_PolygonOrder;  // const
        public static System.Int32 Unity2019_VertexOrder;  // const

    }

    // TypeToken: 0x2000058  // size: 0x10
    public static class RenderMesh
    {
        // Fields
        public static System.Int32 WorkerMultiplesOfVertexCollection;  // const

    }

    // TypeToken: 0x200005D  // size: 0x3C
    public sealed struct VertexWeight
    {
        // Fields
        public UnityEngine.Vector3 localPos;  // 0x10
        public UnityEngine.Vector3 localNor;  // 0x1c
        public UnityEngine.Vector3 localTan;  // 0x28
        public System.Int32 parentIndex;  // 0x34
        public System.Single weight;  // 0x38

    }

    // TypeToken: 0x200005E  // size: 0x30
    public class ChildData : MagicaCloth.IDataHash
    {
        // Fields
        public System.Int32 childDataHash;  // 0x10
        public System.Int32 vertexCount;  // 0x14
        public System.UInt32[] vertexInfoList;  // 0x18
        public MagicaCloth.MeshData.VertexWeight[] vertexWeightList;  // 0x20
        public System.Int32[] parentIndexList;  // 0x28

        // Properties
        System.Int32 VertexCount { get; /* RVA: 0x03D50CC0 */ }

        // Methods
        // RVA: 0x0896F634  token: 0x600042E
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x0350B670  token: 0x600042F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000060  // size: 0x14
    public sealed struct RecalculateMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.RenderMeshDeformer.RecalculateMode None;  // const
        public static MagicaCloth.RenderMeshDeformer.RecalculateMode UpdateNormalPerFrame;  // const
        public static MagicaCloth.RenderMeshDeformer.RecalculateMode UpdateNormalAndTangentPerFrame;  // const

    }

    // TypeToken: 0x2000061  // size: 0x14
    public sealed struct BoundsMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.RenderMeshDeformer.BoundsMode None;  // const
        public static MagicaCloth.RenderMeshDeformer.BoundsMode ExpandedAtInitialization;  // const

    }

    // TypeToken: 0x2000063  // size: 0x18
    public sealed class <>c__DisplayClass35_0
    {
        // Fields
        public MagicaCloth.RenderMeshDeformer deformer;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000483
        public System.Void .ctor() { }
        // RVA: 0x08994F0C  token: 0x6000484
        private System.Boolean <GetRenderMeshDeformerIndex>b__0(MagicaCloth.MagicaRenderDeformer d) { }

    }

    // TypeToken: 0x2000065  // size: 0x1C
    public sealed struct ClampDistance2Data
    {
        // Fields
        public System.Int32 vertexIndex;  // 0x10
        public System.Int32 parentVertexIndex;  // 0x14
        public System.Single length;  // 0x18

    }

    // TypeToken: 0x2000066  // size: 0x14
    public sealed struct ClampDistance2RootInfo
    {
        // Fields
        public System.UInt16 startIndex;  // 0x10
        public System.UInt16 dataLength;  // 0x12

    }

    // TypeToken: 0x2000067  // size: 0x44
    public sealed struct GroupData
    {
        // Fields
        public System.Int32 teamId;  // 0x10
        public System.Int32 active;  // 0x14
        public System.Single minRatio;  // 0x18
        public System.Single maxRatio;  // 0x1c
        public System.Single velocityInfluence;  // 0x20
        public MagicaCloth.ChunkData dataChunk;  // 0x24
        public MagicaCloth.ChunkData rootInfoChunk;  // 0x34

    }

    // TypeToken: 0x2000068  // size: 0xA8
    public sealed struct ClampDistance2Job : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.ClampDistance2Constraint.ClampDistance2Data> dataList;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.ClampDistance2Constraint.ClampDistance2RootInfo> rootInfoList;  // 0x28
        public Unity.Collections.NativeArray<System.Int32> rootTeamList;  // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.ClampDistance2Constraint.GroupData> groupList;  // 0x48
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x68
        public Unity.Collections.NativeArray<System.Single> frictionList;  // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0x98

        // Methods
        // RVA: 0x08983788  token: 0x600048C
        public virtual System.Void Execute(System.Int32 rootIndex) { }

    }

    // TypeToken: 0x200006A  // size: 0x18
    public sealed struct ClampDistanceData
    {
        // Fields
        public System.UInt16 vertexIndex;  // 0x10
        public System.UInt16 targetVertexIndex;  // 0x12
        public System.Single length;  // 0x14

        // Methods
        // RVA: 0x089845CC  token: 0x6000494
        public System.Boolean IsValid() { }

    }

    // TypeToken: 0x200006B  // size: 0x44
    public sealed struct GroupData
    {
        // Fields
        public System.Int32 teamId;  // 0x10
        public System.Int32 active;  // 0x14
        public System.Single minRatio;  // 0x18
        public System.Single maxRatio;  // 0x1c
        public System.Single velocityInfluence;  // 0x20
        public MagicaCloth.ChunkData dataChunk;  // 0x24
        public MagicaCloth.ChunkData refChunk;  // 0x34

    }

    // TypeToken: 0x200006C  // size: 0xB8
    public sealed struct ClampDistanceJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.ClampDistanceConstraint.ClampDistanceData> clampDistanceList;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.ClampDistanceConstraint.GroupData> groupList;  // 0x28
        public Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex> refDataList;  // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x48
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;  // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0x98
        public Unity.Collections.NativeArray<System.Single> frictionList;  // 0xa8

        // Methods
        // RVA: 0x089845E0  token: 0x6000495
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200006E  // size: 0x38
    public sealed struct GroupData
    {
        // Fields
        public System.Int32 teamId;  // 0x10
        public System.Int32 active;  // 0x14
        public MagicaCloth.CurveParam limitLength;  // 0x18
        public Unity.Mathematics.float3 axisRatio;  // 0x28
        public System.Single velocityInfluence;  // 0x34

        // Methods
        // RVA: 0x0898C0CC  token: 0x600049D
        public System.Boolean IsAxisCheck() { }

    }

    // TypeToken: 0x200006F  // size: 0xB8
    public sealed struct ClampPositionJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;  // 0x10
        public System.Single maxMoveLength;  // 0x14
        public Unity.Collections.NativeArray<MagicaCloth.ClampPositionConstraint.GroupData> clampPositionGroupList;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x28
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x48
        public Unity.Collections.NativeArray<System.Single> depthList;  // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;  // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;  // 0x78
        public Unity.Collections.NativeArray<System.Single> frictionList;  // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0x98
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0xa8

        // Methods
        // RVA: 0x089853A4  token: 0x600049E
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000071  // size: 0x34
    public sealed struct ClampRotationData
    {
        // Fields
        public System.Int32 vertexIndex;  // 0x10
        public System.Int32 parentVertexIndex;  // 0x14
        public Unity.Mathematics.float3 localPos;  // 0x18
        public Unity.Mathematics.quaternion localRot;  // 0x24

        // Methods
        // RVA: 0x0898656C  token: 0x60004A6
        public System.Boolean IsValid() { }

    }

    // TypeToken: 0x2000072  // size: 0x14
    public sealed struct ClampRotationRootInfo
    {
        // Fields
        public System.UInt16 startIndex;  // 0x10
        public System.UInt16 dataLength;  // 0x12

    }

    // TypeToken: 0x2000073  // size: 0x4C
    public sealed struct GroupData
    {
        // Fields
        public System.Int32 teamId;  // 0x10
        public System.Int32 active;  // 0x14
        public MagicaCloth.CurveParam maxAngle;  // 0x18
        public System.Single velocityInfluence;  // 0x28
        public MagicaCloth.ChunkData dataChunk;  // 0x2c
        public MagicaCloth.ChunkData rootInfoChunk;  // 0x3c

    }

    // TypeToken: 0x2000074  // size: 0xD8
    public sealed struct ClampRotationJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;  // 0x10
        public System.Single maxMoveLength;  // 0x14
        public Unity.Collections.NativeArray<MagicaCloth.ClampRotationConstraint.ClampRotationData> dataList;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.ClampRotationConstraint.ClampRotationRootInfo> rootInfoList;  // 0x28
        public Unity.Collections.NativeArray<System.Int32> rootTeamList;  // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.ClampRotationConstraint.GroupData> groupList;  // 0x48
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x58
        public Unity.Collections.NativeArray<System.Single> depthList;  // 0x68
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x78
        public Unity.Collections.NativeArray<System.Single> frictionList;  // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0x98
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;  // 0xa8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0xb8
        public Unity.Collections.NativeArray<System.Single> lengthBuffer;  // 0xc8

        // Methods
        // RVA: 0x0898657C  token: 0x60004A7
        public virtual System.Void Execute(System.Int32 rootIndex) { }

    }

    // TypeToken: 0x2000076  // size: 0x128
    public sealed struct CollisionJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x18
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> radiusList;  // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;  // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;  // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPosList;  // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;  // 0x98
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;  // 0xa8
        public Unity.Collections.NativeArray<System.Int32> transformIndexList;  // 0xb8
        public Unity.Collections.NativeArray<System.Int32> colliderList;  // 0xc8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;  // 0xd8
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0xe8
        public Unity.Collections.NativeArray<System.Single> frictionList;  // 0xf8
        public Unity.Collections.NativeArray<System.Int32> collisionLinkIdList;  // 0x108
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> collisionNormalList;  // 0x118

        // Methods
        // RVA: 0x08988290  token: 0x60004AE
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x08988874  token: 0x60004AF
        private System.Single SphereColliderDetection(Unity.Mathematics.float3& nextpos, System.Single radius, System.Int32 cindex, Unity.Mathematics.float3& normal) { }
        // RVA: 0x08987DDC  token: 0x60004B0
        private System.Single CapsuleColliderDetection(Unity.Mathematics.float3& nextpos, System.Single radius, System.Int32 cindex, Unity.Mathematics.float3 dir, Unity.Mathematics.float3& normal) { }
        // RVA: 0x08988750  token: 0x60004B1
        private System.Single PlaneColliderDetection(Unity.Mathematics.float3& nextpos, System.Single radius, System.Int32 cindex, Unity.Mathematics.float3& normal) { }

    }

    // TypeToken: 0x2000078  // size: 0xB8
    public sealed struct CollisionExtrusionJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x18
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;  // 0x48
        public Unity.Collections.NativeArray<System.Int32> collisionLinkIdList;  // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;  // 0x78
        public Unity.Collections.NativeArray<System.Single> frictionList;  // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> collisionNormalList;  // 0x98
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0xa8

        // Methods
        // RVA: 0x08987960  token: 0x60004B7
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200007A  // size: 0x34
    public sealed struct RotationData
    {
        // Fields
        public System.Int32 vertexIndex;  // 0x10
        public System.Int32 parentVertexIndex;  // 0x14
        public Unity.Mathematics.float3 localPos;  // 0x18
        public Unity.Mathematics.quaternion localRot;  // 0x24

        // Methods
        // RVA: 0x0898656C  token: 0x60004BF
        public System.Boolean IsValid() { }

    }

    // TypeToken: 0x200007B  // size: 0x14
    public sealed struct RootInfo
    {
        // Fields
        public System.UInt16 startIndex;  // 0x10
        public System.UInt16 dataLength;  // 0x12

    }

    // TypeToken: 0x200007C  // size: 0x60
    public sealed struct GroupData
    {
        // Fields
        public System.Int32 teamId;  // 0x10
        public System.Int32 useClamp;  // 0x14
        public System.Int32 useRestore;  // 0x18
        public MagicaCloth.CurveParam maxAngle;  // 0x1c
        public MagicaCloth.CurveParam restorePower;  // 0x2c
        public System.Single restoreVelocityInfluence;  // 0x3c
        public MagicaCloth.ChunkData dataChunk;  // 0x40
        public MagicaCloth.ChunkData rootInfoChunk;  // 0x50

    }

    // TypeToken: 0x200007D  // size: 0x110
    public sealed struct RotationRootLineJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Single updatePower;  // 0x10
        public System.Int32 runCount;  // 0x14
        public System.Single maxMoveSpeed;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.CompositeRotationConstraint.RotationData> dataList;  // 0x20
        public Unity.Collections.NativeArray<MagicaCloth.CompositeRotationConstraint.RootInfo> rootInfoList;  // 0x30
        public Unity.Collections.NativeArray<System.Int32> rootTeamList;  // 0x40
        public Unity.Collections.NativeArray<MagicaCloth.CompositeRotationConstraint.GroupData> groupList;  // 0x50
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x60
        public Unity.Collections.NativeArray<MagicaCloth.CurveParam> teamGravityList;  // 0x70
        public Unity.Collections.NativeArray<System.Single> depthList;  // 0x80
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x90
        public Unity.Collections.NativeArray<System.Single> frictionList;  // 0xa0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;  // 0xb0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;  // 0xc0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0xd0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;  // 0xe0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0xf0
        public Unity.Collections.NativeArray<System.Single> lengthBuffer;  // 0x100

        // Methods
        // RVA: 0x089900C8  token: 0x60004C0
        public virtual System.Void Execute(System.Int32 rootIndex) { }
        // RVA: 0x08982B1C  token: 0x60004C1
        private System.Single GetRotRatio(Unity.Mathematics.float3 tv, Unity.Mathematics.float3 gravityVector, System.Single gravity, System.Single minRatio, System.Single maxRatio) { }

    }

    // TypeToken: 0x200007F  // size: 0x1C
    public sealed struct EdgeCollisionData
    {
        // Fields
        public System.UInt16 vindex0;  // 0x10
        public System.UInt16 vindex1;  // 0x12
        public System.Int32 writeIndex0;  // 0x14
        public System.Int32 writeIndex1;  // 0x18

        // Methods
        // RVA: 0x0898BD74  token: 0x60004C9
        public System.Boolean IsValid() { }

    }

    // TypeToken: 0x2000080  // size: 0x5C
    public sealed struct GroupData
    {
        // Fields
        public System.Int32 teamId;  // 0x10
        public System.Int32 active;  // 0x14
        public System.Single edgeRadius;  // 0x18
        public MagicaCloth.ChunkData dataChunk;  // 0x1c
        public MagicaCloth.ChunkData groupIndexChunk;  // 0x2c
        public MagicaCloth.ChunkData refDataChunk;  // 0x3c
        public MagicaCloth.ChunkData writeDataChunk;  // 0x4c

    }

    // TypeToken: 0x2000081  // size: 0x108
    public sealed struct EdgeCollisionCalcJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Single updatePower;  // 0x10
        public System.Int32 runCount;  // 0x14
        public Unity.Collections.NativeArray<MagicaCloth.EdgeCollisionConstraint.GroupData> groupDataList;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.EdgeCollisionConstraint.EdgeCollisionData> dataList;  // 0x28
        public Unity.Collections.NativeArray<System.Int16> groupIndexList;  // 0x38
        public Unity.Collections.NativeArray<System.Int32> colliderList;  // 0x48
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> radiusList;  // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;  // 0x98
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0xa8
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;  // 0xb8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPosList;  // 0xc8
        public Unity.Collections.NativeArray<System.Int32> transformIndexList;  // 0xd8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;  // 0xe8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBuffer;  // 0xf8

        // Methods
        // RVA: 0x0898A4E0  token: 0x60004CA
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x0898A9B4  token: 0x60004CB
        private System.Boolean SphereColliderDetection(Unity.Mathematics.float3 nextpos0, Unity.Mathematics.float3 nextpos1, Unity.Mathematics.float3& corr0, Unity.Mathematics.float3& corr1, System.Single radius, System.Int32 cindex) { }
        // RVA: 0x08989E4C  token: 0x60004CC
        private System.Boolean CapsuleColliderDetection(Unity.Mathematics.float3 nextpos0, Unity.Mathematics.float3 nextpos1, Unity.Mathematics.float3& corr0, Unity.Mathematics.float3& corr1, System.Single radius, System.Int32 cindex, Unity.Mathematics.float3 dir) { }

    }

    // TypeToken: 0x2000082  // size: 0x98
    public sealed struct EdgeCollisionSumJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.EdgeCollisionConstraint.GroupData> groupDataList;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex> refDataList;  // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBuffer;  // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x48
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> inoutNextPosList;  // 0x78
        public Unity.Collections.NativeArray<System.Single> frictionList;  // 0x88

        // Methods
        // RVA: 0x0898BD88  token: 0x60004CD
        public virtual System.Void Execute(System.Int32 pindex) { }

    }

    // TypeToken: 0x2000084  // size: 0x30
    public sealed struct PenetrationData
    {
        // Fields
        public System.Int16 vertexIndex;  // 0x10
        public System.Int16 colliderIndex;  // 0x12
        public Unity.Mathematics.float3 localPos;  // 0x14
        public Unity.Mathematics.float3 localDir;  // 0x20
        public System.Single distance;  // 0x2c

        // Methods
        // RVA: 0x0898CE54  token: 0x60004D5
        public System.Boolean IsValid() { }

    }

    // TypeToken: 0x2000085  // size: 0x70
    public sealed struct GroupData
    {
        // Fields
        public System.Int32 teamId;  // 0x10
        public System.Int32 active;  // 0x14
        public System.Int32 mode;  // 0x18
        public System.Single maxDepth;  // 0x1c
        public MagicaCloth.CurveParam radius;  // 0x20
        public MagicaCloth.CurveParam distance;  // 0x30
        public MagicaCloth.ChunkData dataChunk;  // 0x40
        public MagicaCloth.ChunkData refDataChunk;  // 0x50
        public MagicaCloth.ChunkData bonePenetrationDataChunk;  // 0x60

    }

    // TypeToken: 0x2000086  // size: 0x158
    public sealed struct PenetrationJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PenetrationConstraint.GroupData> groupList;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.PenetrationConstraint.PenetrationData> dataList;  // 0x28
        public Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex> refDataList;  // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePenetrationDataList;  // 0x48
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x58
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;  // 0x88
        public Unity.Collections.NativeArray<System.Int32> transformIndexList;  // 0x98
        public Unity.Collections.NativeArray<System.Single> depthList;  // 0xa8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;  // 0xb8
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;  // 0xc8
        public Unity.Collections.NativeArray<System.Int32> colliderList;  // 0xd8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;  // 0xe8
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;  // 0xf8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;  // 0x108
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x118
        public Unity.Collections.NativeArray<System.Int32> skinningBoneList;  // 0x128
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> outNextPosList;  // 0x138
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0x148

        // Methods
        // RVA: 0x0898CE60  token: 0x60004D6
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x0898DB00  token: 0x60004D7
        private Unity.Mathematics.float3 InverseSpherePosition(MagicaCloth.PenetrationConstraint.PenetrationData& data, System.Single teamScale, Unity.Mathematics.float3 scaleDirection, System.Single distance, System.Int32 cindex, System.Single cr) { }
        // RVA: 0x0898D9E0  token: 0x60004D8
        private Unity.Mathematics.float3 InverseSpherePenetration(Unity.Mathematics.float3 c, System.Single cr, Unity.Mathematics.float3 nextpos) { }

    }

    // TypeToken: 0x2000088  // size: 0x18
    public sealed struct RestoreDistanceData
    {
        // Fields
        public System.UInt16 vertexIndex;  // 0x10
        public System.UInt16 targetVertexIndex;  // 0x12
        public System.Single length;  // 0x14

        // Methods
        // RVA: 0x089845CC  token: 0x60004E1
        public System.Boolean IsValid() { }

    }

    // TypeToken: 0x2000089  // size: 0xC0
    public sealed struct RestoreDistanceGroupData
    {
        // Fields
        public System.Int32 teamId;  // 0x10
        public MagicaCloth.CurveParam mass;  // 0x14
        public System.Single velocityInfluence;  // 0x24
        public MagicaCloth.CurveParam structStiffness;  // 0x28
        public MagicaCloth.ChunkData structDataChunk;  // 0x38
        public MagicaCloth.ChunkData structRefChunk;  // 0x48
        public System.Int32 useBend;  // 0x58
        public MagicaCloth.CurveParam bendStiffness;  // 0x5c
        public MagicaCloth.ChunkData bendDataChunk;  // 0x6c
        public MagicaCloth.ChunkData bendRefChunk;  // 0x7c
        public System.Int32 useNear;  // 0x8c
        public MagicaCloth.CurveParam nearStiffness;  // 0x90
        public MagicaCloth.ChunkData nearDataChunk;  // 0xa0
        public MagicaCloth.ChunkData nearRefChunk;  // 0xb0

        // Methods
        // RVA: 0x0898EE5C  token: 0x60004E2
        public System.Boolean IsValid(System.Int32 type) { }
        // RVA: 0x0898EE34  token: 0x60004E3
        public MagicaCloth.CurveParam GetStiffness(System.Int32 type) { }
        // RVA: 0x0898EDE4  token: 0x60004E4
        public MagicaCloth.ChunkData GetDataChunk(System.Int32 type) { }
        // RVA: 0x0898EE0C  token: 0x60004E5
        public MagicaCloth.ChunkData GetRefChunk(System.Int32 type) { }

    }

    // TypeToken: 0x200008A  // size: 0xE0
    public sealed struct DistanceJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Single updatePower;  // 0x10
        public System.Int32 runCount;  // 0x14
        public System.Int32 type;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData> restoreDistanceDataList;  // 0x20
        public Unity.Collections.NativeArray<MagicaCloth.RestoreDistanceConstraint.RestoreDistanceGroupData> restoreDistanceGroupDataList;  // 0x30
        public Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex> refDataList;  // 0x40
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x50
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x60
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x70
        public Unity.Collections.NativeArray<System.Single> depthList;  // 0x80
        public Unity.Collections.NativeArray<System.Single> frictionList;  // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;  // 0xa0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0xb0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> outNextPosList;  // 0xc0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0xd0

        // Methods
        // RVA: 0x08989654  token: 0x60004E6
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200008C  // size: 0x20
    public sealed struct RotationData
    {
        // Fields
        public System.UInt16 vertexIndex;  // 0x10
        public System.UInt16 targetVertexIndex;  // 0x12
        public Unity.Mathematics.float3 localPos;  // 0x14

        // Methods
        // RVA: 0x089845CC  token: 0x60004EE
        public System.Boolean IsValid() { }

    }

    // TypeToken: 0x200008D  // size: 0x4C
    public sealed struct GroupData
    {
        // Fields
        public System.Int32 teamId;  // 0x10
        public System.Int32 active;  // 0x14
        public MagicaCloth.CurveParam restorePower;  // 0x18
        public System.Single velocityInfluence;  // 0x28
        public MagicaCloth.ChunkData dataChunk;  // 0x2c
        public MagicaCloth.ChunkData refChunk;  // 0x3c

    }

    // TypeToken: 0x200008E  // size: 0xD8
    public sealed struct RotationJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Single updatePower;  // 0x10
        public System.Int32 runCount;  // 0x14
        public Unity.Collections.NativeArray<MagicaCloth.RestoreRotationConstraint.RotationData> dataList;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.RestoreRotationConstraint.GroupData> groupList;  // 0x28
        public Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex> refDataList;  // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x48
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x68
        public Unity.Collections.NativeArray<System.Single> depthList;  // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;  // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0x98
        public Unity.Collections.NativeArray<System.Single> frictionList;  // 0xa8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> outNextPosList;  // 0xb8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0xc8

        // Methods
        // RVA: 0x0898F990  token: 0x60004EF
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000090  // size: 0x1C
    public sealed struct GroupData
    {
        // Fields
        public System.Int32 teamId;  // 0x10
        public System.Int32 active;  // 0x14
        public System.Single spring;  // 0x18

    }

    // TypeToken: 0x2000091  // size: 0x78
    public sealed struct SpringJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Single updatePower;  // 0x10
        public System.Int32 runCount;  // 0x14
        public Unity.Collections.NativeArray<MagicaCloth.SpringConstraint.GroupData> groupList;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x28
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;  // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0x68

        // Methods
        // RVA: 0x08991DCC  token: 0x60004F7
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000093  // size: 0x3C
    public sealed struct TriangleBendData
    {
        // Fields
        public System.Int32 vindex0;  // 0x10
        public System.Int32 vindex1;  // 0x14
        public System.Int32 vindex2;  // 0x18
        public System.Int32 vindex3;  // 0x1c
        public System.Single restAngle;  // 0x20
        public System.Single direction;  // 0x24
        public System.Single depth;  // 0x28
        public System.Int32 writeIndex0;  // 0x2c
        public System.Int32 writeIndex1;  // 0x30
        public System.Int32 writeIndex2;  // 0x34
        public System.Int32 writeIndex3;  // 0x38

        // Methods
        // RVA: 0x08993A6C  token: 0x60004FF
        public System.Boolean IsValid() { }
        // RVA: 0x08993A64  token: 0x6000500
        public System.Boolean IsPositionBend() { }

    }

    // TypeToken: 0x2000094  // size: 0x6C
    public sealed struct TriangleBendGroupData
    {
        // Fields
        public System.Int32 teamId;  // 0x10
        public System.Int32 active;  // 0x14
        public System.Int32 algorithm;  // 0x18
        public MagicaCloth.CurveParam stiffness;  // 0x1c
        public MagicaCloth.ChunkData dataChunk;  // 0x2c
        public MagicaCloth.ChunkData groupIndexChunk;  // 0x3c
        public MagicaCloth.ChunkData refDataChunk;  // 0x4c
        public MagicaCloth.ChunkData writeDataChunk;  // 0x5c

    }

    // TypeToken: 0x2000095  // size: 0x88
    public sealed struct TriangleBendCalcJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Single updatePower;  // 0x10
        public System.Int32 runCount;  // 0x14
        public Unity.Collections.NativeArray<MagicaCloth.TriangleBendConstraint.TriangleBendGroupData> triangleBendGroupDataList;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.TriangleBendConstraint.TriangleBendData> triangleBendList;  // 0x28
        public Unity.Collections.NativeArray<System.Int16> groupIndexList;  // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;  // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBuffer;  // 0x78

        // Methods
        // RVA: 0x08992034  token: 0x6000501
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000096  // size: 0x98
    public sealed struct TriangleBendSumJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.TriangleBendConstraint.TriangleBendGroupData> triangleBendGroupDataList;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex> refDataList;  // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBuffer;  // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x48
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> inoutNextPosList;  // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0x88

        // Methods
        // RVA: 0x08993A7C  token: 0x6000502
        public virtual System.Void Execute(System.Int32 pindex) { }

    }

    // TypeToken: 0x2000098  // size: 0x14
    public sealed struct TwistData
    {
        // Fields
        public System.UInt16 vertexIndex0;  // 0x10
        public System.UInt16 vertexIndex1;  // 0x12

        // Methods
        // RVA: 0x089845CC  token: 0x600050A
        public System.Boolean IsValid() { }

    }

    // TypeToken: 0x2000099  // size: 0x3C
    public sealed struct GroupData
    {
        // Fields
        public System.Int32 teamId;  // 0x10
        public System.Int32 active;  // 0x14
        public System.Single recoveryPower;  // 0x18
        public MagicaCloth.ChunkData dataChunk;  // 0x1c
        public MagicaCloth.ChunkData refChunk;  // 0x2c

    }

    // TypeToken: 0x200009A  // size: 0xC8
    public sealed struct TwistJob2 : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;  // 0x10
        public System.Single updatePower;  // 0x14
        public Unity.Collections.NativeArray<MagicaCloth.TwistConstraint.TwistData> dataList;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex> refDataList;  // 0x28
        public Unity.Collections.NativeArray<MagicaCloth.TwistConstraint.GroupData> groupList;  // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x48
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;  // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0x88
        public Unity.Collections.NativeArray<System.Single> frictionList;  // 0x98
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> outNextPosList;  // 0xa8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0xb8

        // Methods
        // RVA: 0x08994818  token: 0x600050B
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200009C  // size: 0x5C
    public sealed struct VolumeData
    {
        // Fields
        public System.Int32 vindex0;  // 0x10
        public System.Int32 vindex1;  // 0x14
        public System.Int32 vindex2;  // 0x18
        public System.Int32 vindex3;  // 0x1c
        public Unity.Mathematics.float3x3 ivMat;  // 0x20
        public System.Single depth;  // 0x44
        public System.Int32 direction;  // 0x48
        public System.Int32 writeIndex0;  // 0x4c
        public System.Int32 writeIndex1;  // 0x50
        public System.Int32 writeIndex2;  // 0x54
        public System.Int32 writeIndex3;  // 0x58

        // Methods
        // RVA: 0x08993A6C  token: 0x6000514
        public System.Boolean IsValid() { }

    }

    // TypeToken: 0x200009D  // size: 0x78
    public sealed struct GroupData
    {
        // Fields
        public System.Int32 teamId;  // 0x10
        public System.Int32 active;  // 0x14
        public MagicaCloth.CurveParam stretchStiffness;  // 0x18
        public MagicaCloth.CurveParam shearStiffness;  // 0x28
        public MagicaCloth.ChunkData dataChunk;  // 0x38
        public MagicaCloth.ChunkData groupIndexChunk;  // 0x48
        public MagicaCloth.ChunkData refDataChunk;  // 0x58
        public MagicaCloth.ChunkData writeDataChunk;  // 0x68

    }

    // TypeToken: 0x200009E  // size: 0x78
    public sealed struct VolumeCalcJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Single updatePower;  // 0x10
        public System.Int32 runCount;  // 0x14
        public Unity.Collections.NativeArray<MagicaCloth.VolumeConstraint.GroupData> groupDataList;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.VolumeConstraint.VolumeData> dataList;  // 0x28
        public Unity.Collections.NativeArray<System.Int16> groupIndexList;  // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBuffer;  // 0x68

        // Methods
        // RVA: 0x08994F3C  token: 0x6000515
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x200009F  // size: 0x88
    public sealed struct VolumeSumJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Int32 runCount;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.VolumeConstraint.GroupData> groupDataList;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.ReferenceDataIndex> refDataList;  // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBuffer;  // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x48
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> inoutNextPosList;  // 0x78

        // Methods
        // RVA: 0x089A5CB4  token: 0x6000516
        public virtual System.Void Execute(System.Int32 pindex) { }

    }

    // TypeToken: 0x20000A5  // size: 0x68
    public sealed struct RestoreBoneJob : UnityEngine.Jobs.IJobParallelForTransform
    {
        // Fields
        public System.Boolean fixedUpdate;  // 0x10
        public Unity.Collections.NativeArray<System.Int16> boneUnityPhysicsList;  // 0x18
        public Unity.Collections.NativeArray<System.Byte> boneFlagList;  // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> restoreBoneLocalPosList;  // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> restoreBoneLocalRotList;  // 0x48
        public Unity.Collections.NativeArray<System.Int32> restoreBoneIndexList;  // 0x58

        // Methods
        // RVA: 0x089A5AF8  token: 0x600053F
        public virtual System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x20000A6  // size: 0xA8
    public sealed struct ReadBoneJob0 : UnityEngine.Jobs.IJobParallelForTransform
    {
        // Fields
        public System.Int32 fixedUpdateCount;  // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;  // 0x18
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;  // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;  // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;  // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;  // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> futurePosList;  // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> futureRotList;  // 0x78
        public Unity.Collections.NativeArray<System.Int16> boneUnityPhysicsList;  // 0x88
        public Unity.Collections.NativeArray<System.Byte> boneFlagList;  // 0x98

        // Methods
        // RVA: 0x089A50C0  token: 0x6000540
        public virtual System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x20000A7  // size: 0xB8
    public sealed struct ReadBoneJob1 : UnityEngine.Jobs.IJobParallelForTransform
    {
        // Fields
        public System.Int32 fixedUpdateCount;  // 0x10
        public System.Single normalFutureRatio;  // 0x14
        public System.Single fixedFutureRatio;  // 0x18
        public System.Single normalDeltaTime;  // 0x1c
        public System.Single fixedDeltaTime;  // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;  // 0x28
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;  // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;  // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;  // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;  // 0x68
        public Unity.Collections.NativeArray<System.Int16> boneUnityPhysicsList;  // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> futurePosList;  // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> futureRotList;  // 0x98
        public Unity.Collections.NativeArray<System.Byte> boneFlagList;  // 0xa8

        // Methods
        // RVA: 0x089A541C  token: 0x6000541
        public virtual System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x20000A8  // size: 0x90
    public sealed struct ConvertWorldToLocalJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> writeBoneIndexList;  // 0x10
        public Unity.Collections.NativeArray<System.Byte> boneFlagList;  // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;  // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;  // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;  // 0x50
        public Unity.Collections.NativeArray<System.Int32> boneParentIndexList;  // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBonePosList;  // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> writeBoneRotList;  // 0x80

        // Methods
        // RVA: 0x08996DC8  token: 0x6000542
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000A9  // size: 0x78
    public sealed struct WriteBontToTransformJob2 : UnityEngine.Jobs.IJobParallelForTransform
    {
        // Fields
        public System.Int32 fixedUpdateCount;  // 0x10
        public Unity.Collections.NativeArray<System.Byte> boneFlagList;  // 0x18
        public Unity.Collections.NativeArray<System.Int32> writeBoneIndexList;  // 0x28
        public Unity.Collections.NativeArray<System.Int32> boneParentIndexList;  // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> writeBonePosList;  // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> writeBoneRotList;  // 0x58
        public Unity.Collections.NativeArray<System.Int16> boneUnityPhysicsList;  // 0x68

        // Methods
        // RVA: 0x089A5FEC  token: 0x6000543
        public virtual System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x20000AA  // size: 0x50
    public sealed struct CopyBoneJob0 : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;  // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;  // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> backBonePosList;  // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> backBoneRotList;  // 0x40

        // Methods
        // RVA: 0x03D6E110  token: 0x6000544
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000AB  // size: 0x30
    public sealed struct CopyBoneJob1 : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> writeBoneIndexList;  // 0x10
        public Unity.Collections.NativeArray<System.Int32> backWriteBoneIndexList;  // 0x20

        // Methods
        // RVA: 0x03D6E160  token: 0x6000545
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000AC  // size: 0x30
    public sealed struct CopyBoneJob2 : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Byte> boneFlagList;  // 0x10
        public Unity.Collections.NativeArray<System.Byte> backBoneFlagList;  // 0x20

        // Methods
        // RVA: 0x03D6E180  token: 0x6000546
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000AF  // size: 0x1C0
    public sealed struct ForceAndVelocityJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Single updateDeltaTime;  // 0x10
        public System.Single updatePower;  // 0x14
        public System.Int32 runCount;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x20
        public Unity.Collections.NativeArray<MagicaCloth.CurveParam> teamMassList;  // 0x30
        public Unity.Collections.NativeArray<MagicaCloth.CurveParam> teamGravityList;  // 0x40
        public Unity.Collections.NativeArray<MagicaCloth.CurveParam> teamDragList;  // 0x50
        public Unity.Collections.NativeArray<MagicaCloth.CurveParam> teamDepthInfluenceList;  // 0x60
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.WindInfo> teamWindInfoList;  // 0x70
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x80
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x90
        public Unity.Collections.NativeArray<System.Single> depthList;  // 0xa0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> snapBasePosList;  // 0xb0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> snapBaseRotList;  // 0xc0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;  // 0xd0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;  // 0xe0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldBasePosList;  // 0xf0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldBaseRotList;  // 0x100
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0x110
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;  // 0x120
        public Unity.Collections.NativeArray<System.Single> frictionList;  // 0x130
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0x140
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;  // 0x150
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosList;  // 0x160
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldRotList;  // 0x170
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityList;  // 0x180
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerWindData.WindData> windDataList;  // 0x190
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;  // 0x1a0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;  // 0x1b0

        // Methods
        // RVA: 0x08997998  token: 0x6000596
        public virtual System.Void Execute(System.Int32 index) { }
        // RVA: 0x089983A0  token: 0x6000597
        private Unity.Mathematics.float3 Wind(System.Int32 teamId, MagicaCloth.PhysicsManagerTeamData.TeamData& teamData, Unity.Mathematics.float3& pos) { }

    }

    // TypeToken: 0x20000B0  // size: 0x120
    public sealed struct FixPositionJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Single updatePower;  // 0x10
        public System.Single updateDeltaTime;  // 0x14
        public System.Int32 runCount;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x20
        public Unity.Collections.NativeArray<MagicaCloth.CurveParam> teamMaxVelocityList;  // 0x30
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x40
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x50
        public Unity.Collections.NativeArray<System.Single> depthList;  // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;  // 0x80
        public Unity.Collections.NativeArray<System.Single> frictionList;  // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityList;  // 0xa0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;  // 0xb0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosList;  // 0xc0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldRotList;  // 0xd0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0xe0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPosList;  // 0xf0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> collisionNormalList;  // 0x100
        public Unity.Collections.NativeArray<System.Single> staticFrictionList;  // 0x110

        // Methods
        // RVA: 0x0899719C  token: 0x6000598
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000B1  // size: 0x138
    public sealed struct PostUpdatePhysicsJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Single updateDeltaTime;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x28
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x38
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> snapBasePosList;  // 0x48
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> snapBaseRotList;  // 0x58
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;  // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;  // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldBasePosList;  // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldBaseRotList;  // 0x98
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityList;  // 0xa8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPosList;  // 0xb8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosList;  // 0xc8
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldRotList;  // 0xd8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0xe8
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;  // 0xf8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0x108
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;  // 0x118
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldSlowPosList;  // 0x128

        // Methods
        // RVA: 0x089A4B24  token: 0x6000599
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000B4  // size: 0x60
    public sealed struct SharedVirtualMeshInfo
    {
        // Fields
        public System.Int32 uid;  // 0x10
        public System.Int32 useCount;  // 0x14
        public System.Int32 sharedChildMeshStartIndex;  // 0x18
        public System.Int32 sharedChildMeshCount;  // 0x1c
        public MagicaCloth.ChunkData vertexChunk;  // 0x20
        public MagicaCloth.ChunkData weightChunk;  // 0x30
        public MagicaCloth.ChunkData triangleChunk;  // 0x40
        public MagicaCloth.ChunkData vertexToTriangleChunk;  // 0x50

    }

    // TypeToken: 0x20000B5  // size: 0x54
    public sealed struct VirtualMeshInfo
    {
        // Fields
        public System.UInt32 flag;  // 0x10
        public System.Int32 sharedVirtualMeshIndex;  // 0x14
        public System.Int32 meshUseCount;  // 0x18
        public System.Int32 vertexUseCount;  // 0x1c
        public MagicaCloth.ChunkData vertexChunk;  // 0x20
        public MagicaCloth.ChunkData boneChunk;  // 0x30
        public MagicaCloth.ChunkData triangleChunk;  // 0x40
        public System.Int32 transformIndex;  // 0x50

        // Methods
        // RVA: 0x089A59FC  token: 0x60005EC
        public System.Boolean IsFlag(System.UInt32 flag) { }
        // RVA: 0x089A5ACC  token: 0x60005ED
        public System.Void SetFlag(System.UInt32 flag, System.Boolean sw) { }
        // RVA: 0x04275E20  token: 0x60005EE
        public System.Boolean IsActive() { }
        // RVA: 0x089A5C9C  token: 0x60005EF
        public System.Boolean IsUse() { }
        // RVA: 0x054E505C  token: 0x60005F0
        public System.Boolean IsPause() { }

    }

    // TypeToken: 0x20000B6  // size: 0x48
    public sealed struct SharedChildMeshInfo
    {
        // Fields
        public System.Int64 cuid;  // 0x10
        public System.Int32 sharedVirtualMeshIndex;  // 0x18
        public System.Int32 virtualMeshIndex;  // 0x1c
        public System.Int32 meshUseCount;  // 0x20
        public MagicaCloth.ChunkData vertexChunk;  // 0x24
        public MagicaCloth.ChunkData weightChunk;  // 0x34

    }

    // TypeToken: 0x20000B7  // size: 0x50
    public sealed struct SharedRenderMeshInfo
    {
        // Fields
        public System.Int32 uid;  // 0x10
        public System.Int32 useCount;  // 0x14
        public System.UInt32 flag;  // 0x18
        public MagicaCloth.ChunkData vertexChunk;  // 0x1c
        public MagicaCloth.ChunkData bonePerVertexChunk;  // 0x2c
        public MagicaCloth.ChunkData boneWeightsChunk;  // 0x3c
        public System.Int32 rendererBoneIndex;  // 0x4c

        // Methods
        // RVA: 0x089A5BE0  token: 0x60005F1
        public System.Boolean IsFlag(System.UInt32 flag) { }
        // RVA: 0x089A5BF0  token: 0x60005F2
        public System.Void SetFlag(System.UInt32 flag, System.Boolean sw) { }
        // RVA: 0x089A5BE8  token: 0x60005F3
        public System.Boolean IsSkinning() { }

    }

    // TypeToken: 0x20000B8  // size: 0x98
    public sealed struct RenderMeshInfo
    {
        // Fields
        public System.UInt32 flag;  // 0x10
        public System.Int32 renderSharedMeshIndex;  // 0x14
        public System.Int32 sharedRenderMeshVertexStartIndex;  // 0x18
        public System.Int32 meshUseCount;  // 0x1c
        public Unity.Mathematics.int4 childMeshVertexStartIndex;  // 0x20
        public Unity.Mathematics.int4 childMeshWeightStartIndex;  // 0x30
        public Unity.Mathematics.int4 virtualMeshVertexStartIndex;  // 0x40
        public Unity.Mathematics.int4 sharedVirtualMeshVertexStartIndex;  // 0x50
        public Unity.Mathematics.int4 linkMeshCount;  // 0x60
        public MagicaCloth.ChunkData vertexChunk;  // 0x70
        public MagicaCloth.ChunkData boneWeightsChunk;  // 0x80
        public System.Int32 transformIndex;  // 0x90
        public System.Single baseScale;  // 0x94

        // Methods
        // RVA: 0x089A59FC  token: 0x60005F4
        public System.Boolean IsFlag(System.UInt32 flag) { }
        // RVA: 0x089A5ACC  token: 0x60005F5
        public System.Void SetFlag(System.UInt32 flag, System.Boolean sw) { }
        // RVA: 0x04275E20  token: 0x60005F6
        public System.Boolean IsActive() { }
        // RVA: 0x089A5A1C  token: 0x60005F7
        public System.Boolean IsUse() { }
        // RVA: 0x089A5A04  token: 0x60005F8
        public System.Boolean IsLinkMesh(System.Int32 index) { }
        // RVA: 0x054E505C  token: 0x60005F9
        public System.Boolean IsPause() { }
        // RVA: 0x089A59F0  token: 0x60005FA
        public System.Boolean IsFasterWrite() { }
        // RVA: 0x054E5054  token: 0x60005FB
        public System.Boolean IsSkinning() { }
        // RVA: 0x089A5930  token: 0x60005FC
        public System.Boolean AddLinkMesh(System.Int32 renderMeshIndex, System.Int32 childMeshVertexStart, System.Int32 childMeshWeightStart, System.Int32 virtualMeshVertexStart, System.Int32 sharedVirtualMeshVertexStart) { }
        // RVA: 0x089A5A2C  token: 0x60005FD
        public System.Boolean RemoveLinkMesh(System.Int32 renderMeshIndex, System.Int32 childMeshVertexStart, System.Int32 childMeshWeightStart, System.Int32 virtualMeshVertexStart, System.Int32 sharedVirtualMeshVertexStart) { }

    }

    // TypeToken: 0x20000B9  // size: 0x30
    public class RenderMeshState
    {
        // Fields
        public System.UInt32 flag;  // 0x10
        public System.Int32 RenderSharedMeshIndex;  // 0x14
        public System.Int32 RenderSharedMeshId;  // 0x18
        public System.Int32 VertexChunkStart;  // 0x1c
        public System.Int32 VertexChunkLength;  // 0x20
        public System.Int32 BoneWeightChunkStart;  // 0x24
        public System.Int32 BoneWeightChunkLength;  // 0x28

        // Methods
        // RVA: 0x05D623EC  token: 0x60005FE
        public System.Boolean IsFlag(System.UInt32 flag) { }
        // RVA: 0x089A5AE0  token: 0x60005FF
        public System.Void SetFlag(System.UInt32 flag, System.Boolean sw) { }
        // RVA: 0x0350B670  token: 0x6000600
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000BA  // size: 0x50
    public sealed struct CopyRenderBuffer : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderPosList;  // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderNormalList;  // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderPosArray;  // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderNormalArray;  // 0x40

        // Methods
        // RVA: 0x03D6E1A0  token: 0x6000601
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000BB  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly MagicaCloth.PhysicsManagerMeshData.<>c <>9;  // static @ 0x0
        public static System.Comparison<MagicaCloth.RenderMeshDeformer> <>9__158_0;  // static @ 0x8

        // Methods
        // RVA: 0x089A5C38  token: 0x6000602
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000603
        public System.Void .ctor() { }
        // RVA: 0x089A5C08  token: 0x6000604
        private System.Int32 <DispatchWriting>b__158_0(MagicaCloth.RenderMeshDeformer a, MagicaCloth.RenderMeshDeformer b) { }

    }

    // TypeToken: 0x20000BD  // size: 0x14
    public sealed struct ParticleFlag
    {
        // Fields
        public System.UInt32 flag;  // 0x10

        // Methods
        // RVA: 0x03542BB0  token: 0x600061E
        public System.Void .ctor(System.UInt32[] flags) { }
        // RVA: 0x089A59FC  token: 0x600061F
        public System.Boolean IsFlag(System.UInt32 flag) { }
        // RVA: 0x089A5ACC  token: 0x6000620
        public System.Void SetFlag(System.UInt32 flag, System.Boolean sw) { }
        // RVA: 0x089AFF0C  token: 0x6000621
        public System.Boolean IsValid() { }
        // RVA: 0x03542D60  token: 0x6000622
        public System.Void SetEnable(System.Boolean sw) { }
        // RVA: 0x089AFED0  token: 0x6000623
        public System.Boolean IsFixed() { }
        // RVA: 0x089AFEE0  token: 0x6000624
        public System.Boolean IsMove() { }
        // RVA: 0x089AFED8  token: 0x6000625
        public System.Boolean IsKinematic() { }
        // RVA: 0x054E5054  token: 0x6000626
        public System.Boolean IsHold() { }
        // RVA: 0x03542BA0  token: 0x6000627
        public System.Boolean IsCollider() { }
        // RVA: 0x03542D40  token: 0x6000628
        public System.Boolean IsReadTransform() { }
        // RVA: 0x089AFF14  token: 0x6000629
        public System.Boolean IsWriteTransform() { }
        // RVA: 0x03542D50  token: 0x600062A
        public System.Boolean IsRestoreTransform() { }
        // RVA: 0x089AFF00  token: 0x600062B
        public System.Boolean IsUnityPhysics() { }
        // RVA: 0x089AFEF4  token: 0x600062C
        public System.Boolean IsReadSclTransform() { }
        // RVA: 0x089AFEE8  token: 0x600062D
        public System.Boolean IsParentTransform() { }

    }

    // TypeToken: 0x20000BE  // size: 0x160
    public sealed struct CopyBoneToParticleJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamData;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.WorldInfluence> teamWorldInfluenceList;  // 0x20
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x30
        public Unity.Collections.NativeArray<System.Single> depthList;  // 0x40
        public Unity.Collections.NativeArray<System.Int32> transformIndexList;  // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPosList;  // 0x60
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityList;  // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;  // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;  // 0xa0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;  // 0xb0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0xc0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosList;  // 0xd0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldRotList;  // 0xe0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldSlowPosList;  // 0xf0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;  // 0x100
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> snapBasePosList;  // 0x110
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> snapBaseRotList;  // 0x120
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldBasePosList;  // 0x130
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldBaseRotList;  // 0x140
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0x150

        // Methods
        // RVA: 0x089AAD64  token: 0x600062E
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000BF  // size: 0x130
    public sealed struct ResetParticleJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamData;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x20
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> snapBasePosList;  // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> snapBaseRotList;  // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> basePosList;  // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> baseRotList;  // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldBasePosList;  // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldBaseRotList;  // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0xa0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;  // 0xb0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldPosList;  // 0xc0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> oldRotList;  // 0xd0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> oldSlowPosList;  // 0xe0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> velocityList;  // 0xf0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> nextPosList;  // 0x100
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> nextRotList;  // 0x110
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> localPosList;  // 0x120

        // Methods
        // RVA: 0x089B9C48  token: 0x600062F
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000C0  // size: 0xC0
    public sealed struct CopyParticleToBoneJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;  // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneBasePosList;  // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneBaseRotList;  // 0x50
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x60
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x70
        public Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.Int32> transformParticleIndexMap;  // 0x80
        public Unity.Collections.NativeArray<System.Int32> writeBoneIndexList;  // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;  // 0xa0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;  // 0xb0

        // Methods
        // RVA: 0x089AB674  token: 0x6000630
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000C2  // size: 0x14
    public sealed struct ForceMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.PhysicsManagerTeamData.ForceMode None;  // const
        public static MagicaCloth.PhysicsManagerTeamData.ForceMode VelocityAdd;  // const
        public static MagicaCloth.PhysicsManagerTeamData.ForceMode VelocityChange;  // const
        public static MagicaCloth.PhysicsManagerTeamData.ForceMode VelocityAddWithoutMass;  // const
        public static MagicaCloth.PhysicsManagerTeamData.ForceMode VelocityChangeWithoutMass;  // const

    }

    // TypeToken: 0x20000C3  // size: 0x110
    public sealed struct TeamData
    {
        // Fields
        public MagicaCloth.ChunkData particleChunk;  // 0x10
        public MagicaCloth.ChunkData colliderChunk;  // 0x20
        public MagicaCloth.ChunkData skinningBoneChunk;  // 0x30
        public System.UInt32 flag;  // 0x40
        public System.Single dynamicFriction;  // 0x44
        public System.Single staticFriction;  // 0x48
        public System.Single selfCollisionRange;  // 0x4c
        public System.Int32 boneIndex;  // 0x50
        public Unity.Mathematics.float3 initScale;  // 0x54
        public System.Single scaleRatio;  // 0x60
        public Unity.Mathematics.float3 scaleDirection;  // 0x64
        public Unity.Mathematics.float4 quaternionScale;  // 0x70
        public System.Single time;  // 0x80
        public System.Single oldTime;  // 0x84
        public System.Single addTime;  // 0x88
        public System.Single timeScale;  // 0x8c
        public System.Single nowTime;  // 0x90
        public System.Single startTime;  // 0x94
        public System.Int32 updateCount;  // 0x98
        public System.Single blendRatio;  // 0x9c
        public System.Single outPhysicsPoseBlendRatio;  // 0xa0
        public Unity.Mathematics.float3 externalForce;  // 0xa4
        public System.Single forceMassInfluence;  // 0xb0
        public System.Single forceWindInfluence;  // 0xb4
        public System.Single forceWindRandomScale;  // 0xb8
        public System.Single forceWindSynchronization;  // 0xbc
        public System.Single velocityWeight;  // 0xc0
        public System.Single velocityRecoverySpeed;  // 0xc4
        public Unity.Mathematics.float3 gravityDirection;  // 0xc8
        public MagicaCloth.PhysicsManagerTeamData.ForceMode forceMode;  // 0xd4
        public Unity.Mathematics.float3 impactForce;  // 0xd8
        public System.Int32 calcCount;  // 0xe4
        public System.Int16 restoreDistanceGroupIndex;  // 0xe8
        public System.Int16 triangleBendGroupIndex;  // 0xea
        public System.Int16 clampDistanceGroupIndex;  // 0xec
        public System.Int16 clampDistance2GroupIndex;  // 0xee
        public System.Int16 clampPositionGroupIndex;  // 0xf0
        public System.Int16 clampRotationGroupIndex;  // 0xf2
        public System.Int16 restoreRotationGroupIndex;  // 0xf4
        public System.Int16 adjustRotationGroupIndex;  // 0xf6
        public System.Int16 springGroupIndex;  // 0xf8
        public System.Int16 volumeGroupIndex;  // 0xfa
        public System.Int16 airLineGroupIndex;  // 0xfc
        public System.Int16 lineWorkerGroupIndex;  // 0xfe
        public System.Int16 triangleWorkerGroupIndex;  // 0x100
        public System.Int16 selfCollisionGroupIndex;  // 0x102
        public System.Int16 edgeCollisionGroupIndex;  // 0x104
        public System.Int16 penetrationGroupIndex;  // 0x106
        public System.Int16 baseSkinningGroupIndex;  // 0x108
        public System.Int16 twistGroupIndex;  // 0x10a
        public System.Int16 compositeRotationGroupIndex;  // 0x10c

        // Methods
        // RVA: 0x059CF6F8  token: 0x600066C
        public System.Boolean IsActive() { }
        // RVA: 0x089BA9E0  token: 0x600066D
        public System.Boolean IsRunning() { }
        // RVA: 0x089BA9EC  token: 0x600066E
        public System.Boolean IsUpdate(System.Int32 runCount) { }
        // RVA: 0x059CF700  token: 0x600066F
        public System.Boolean IsInterpolate() { }
        // RVA: 0x089BA9C8  token: 0x6000670
        public System.Boolean IsPhysicsUpdate() { }
        // RVA: 0x089BA9B4  token: 0x6000671
        public System.Boolean IsFlag(System.UInt32 flag) { }
        // RVA: 0x089BA9F8  token: 0x6000672
        public System.Void SetFlag(System.UInt32 flag, System.Boolean sw) { }
        // RVA: 0x089BA9D4  token: 0x6000673
        public System.Boolean IsReset() { }
        // RVA: 0x089BA9BC  token: 0x6000674
        public System.Boolean IsPause() { }

    }

    // TypeToken: 0x20000C4  // size: 0xAC
    public sealed struct WorldInfluence
    {
        // Fields
        public MagicaCloth.CurveParam moveInfluence;  // 0x10
        public MagicaCloth.CurveParam rotInfluence;  // 0x20
        public System.Single maxMoveSpeed;  // 0x30
        public System.Single maxRotationSpeed;  // 0x34
        public Unity.Mathematics.float3 nowPosition;  // 0x38
        public Unity.Mathematics.float3 oldPosition;  // 0x44
        public Unity.Mathematics.float3 moveOffset;  // 0x50
        public System.Single moveIgnoreRatio;  // 0x5c
        public Unity.Mathematics.quaternion nowRotation;  // 0x60
        public Unity.Mathematics.quaternion oldRotation;  // 0x70
        public Unity.Mathematics.quaternion rotationOffset;  // 0x80
        public System.Single rotationIgnoreRatio;  // 0x90
        public System.Int32 resetTeleport;  // 0x94
        public System.Single teleportDistance;  // 0x98
        public System.Single teleportRotation;  // 0x9c
        public MagicaCloth.ClothParams.TeleportMode teleportMode;  // 0xa0
        public System.Single stabilizationTime;  // 0xa4
        public System.Single clampRotationLimit;  // 0xa8

    }

    // TypeToken: 0x20000C5  // size: 0x64
    public sealed struct WindInfo
    {
        // Fields
        public System.Int32 windCount;  // 0x10
        public Unity.Mathematics.int4 windDataIndexList;  // 0x14
        public Unity.Mathematics.float3x4 windDirectionList;  // 0x24
        public Unity.Mathematics.float4 windMainList;  // 0x54

    }

    // TypeToken: 0x20000C6  // size: 0xA8
    public sealed struct PreProcessTeamDataJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Single deltaTime;  // 0x10
        public System.Single physicsDeltaTime;  // 0x14
        public System.Single updateDeltaTime;  // 0x18
        public System.Single globalTimeScale;  // 0x1c
        public System.Int32 maxUpdateCount;  // 0x20
        public System.Single unityTimeScale;  // 0x24
        public System.Single elapsedTime;  // 0x28
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamData;  // 0x30
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.WorldInfluence> teamWorldInfluenceList;  // 0x40
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.WindInfo> teamWindInfoList;  // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;  // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;  // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;  // 0x80
        public System.Int32 windCount;  // 0x90
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerWindData.WindData> windData;  // 0x98

        // Methods
        // RVA: 0x089B620C  token: 0x6000675
        public virtual System.Void Execute(System.Int32 teamId) { }
        // RVA: 0x089B70B0  token: 0x6000676
        private System.Void UpdateTime(MagicaCloth.PhysicsManagerTeamData.TeamData& tdata, System.Boolean reset, System.Single dtime) { }
        // RVA: 0x089B71A4  token: 0x6000677
        private System.Void Wind(MagicaCloth.PhysicsManagerTeamData.TeamData& tdata, Unity.Mathematics.float3 pos, System.Int32 teamId) { }

    }

    // TypeToken: 0x20000C7  // size: 0x38
    public sealed struct PostProcessTeamDataJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Int32 fixedUpdateCount;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamData;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.WorldInfluence> teamWorldInfluenceList;  // 0x28

        // Methods
        // RVA: 0x089B5F08  token: 0x6000678
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000C8  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly MagicaCloth.PhysicsManagerTeamData.<>c <>9;  // static @ 0x0
        public static System.Action<System.Int32> <>9__76_0;  // static @ 0x8

        // Methods
        // RVA: 0x089BB8B8  token: 0x6000679
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600067A
        public System.Void .ctor() { }
        // RVA: 0x089BB85C  token: 0x600067B
        private System.Void <ResetFuturePredictionCollidere>b__76_0(System.Int32 pindex) { }

    }

    // TypeToken: 0x20000CA  // size: 0x14
    public sealed struct WindType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.PhysicsManagerWindData.WindType None;  // const
        public static MagicaCloth.PhysicsManagerWindData.WindType Direction;  // const
        public static MagicaCloth.PhysicsManagerWindData.WindType Area;  // const

    }

    // TypeToken: 0x20000CB  // size: 0x14
    public sealed struct ShapeType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.PhysicsManagerWindData.ShapeType Box;  // const
        public static MagicaCloth.PhysicsManagerWindData.ShapeType Sphere;  // const

    }

    // TypeToken: 0x20000CC  // size: 0x14
    public sealed struct DirectionType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.PhysicsManagerWindData.DirectionType OneDirection;  // const
        public static MagicaCloth.PhysicsManagerWindData.DirectionType Radial;  // const

    }

    // TypeToken: 0x20000CD  // size: 0x60
    public sealed struct WindData
    {
        // Fields
        public System.UInt32 flag;  // 0x10
        public MagicaCloth.PhysicsManagerWindData.WindType windType;  // 0x14
        public MagicaCloth.PhysicsManagerWindData.ShapeType shapeType;  // 0x18
        public System.Int32 transformIndex;  // 0x1c
        public Unity.Mathematics.float3 areaSize;  // 0x20
        public System.Single main;  // 0x2c
        public System.Single turbulence;  // 0x30
        public System.Single frequency;  // 0x34
        public Unity.Mathematics.float3 direction;  // 0x38
        public MagicaCloth.PhysicsManagerWindData.DirectionType directionType;  // 0x44
        public System.Single areaVolume;  // 0x48
        public System.Single areaLength;  // 0x4c
        public MagicaCloth.CurveParam attenuation;  // 0x50

        // Methods
        // RVA: 0x089A59FC  token: 0x6000687
        public System.Boolean IsFlag(System.UInt32 flag) { }
        // RVA: 0x089A5ACC  token: 0x6000688
        public System.Void SetFlag(System.UInt32 flag, System.Boolean sw) { }
        // RVA: 0x089BBA94  token: 0x6000689
        public System.Void SetEnable(System.Boolean sw) { }
        // RVA: 0x089AFF0C  token: 0x600068A
        public System.Boolean IsActive() { }

    }

    // TypeToken: 0x20000D1  // size: 0x14
    public sealed struct Axis
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.MagicaCapsuleCollider.Axis X;  // const
        public static MagicaCloth.MagicaCapsuleCollider.Axis Y;  // const
        public static MagicaCloth.MagicaCapsuleCollider.Axis Z;  // const

    }

    // TypeToken: 0x20000D6  // size: 0x14
    public sealed struct TeamUpdateMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.PhysicsTeam.TeamUpdateMode Normal;  // const
        public static MagicaCloth.PhysicsTeam.TeamUpdateMode UnityPhysics;  // const

    }

    // TypeToken: 0x20000D7  // size: 0x14
    public sealed struct TeamCullingMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.PhysicsTeam.TeamCullingMode Reset;  // const
        public static MagicaCloth.PhysicsTeam.TeamCullingMode Pause;  // const
        public static MagicaCloth.PhysicsTeam.TeamCullingMode Off;  // const

    }

    // TypeToken: 0x20000D8  // size: 0x14
    public sealed struct TeamSkinningMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.PhysicsTeam.TeamSkinningMode None;  // const
        public static MagicaCloth.PhysicsTeam.TeamSkinningMode UserAnimation;  // const

    }

    // TypeToken: 0x20000DB  // size: 0x24
    public sealed struct AdjustRotationData
    {
        // Fields
        public System.Int32 keyIndex;  // 0x10
        public System.Int32 targetIndex;  // 0x14
        public Unity.Mathematics.float3 localPos;  // 0x18

        // Methods
        // RVA: 0x089A7794  token: 0x600071A
        public System.Boolean IsValid() { }

    }

    // TypeToken: 0x20000DC  // size: 0x38
    public sealed struct GroupData
    {
        // Fields
        public System.Int32 teamId;  // 0x10
        public System.Int32 active;  // 0x14
        public System.Int32 adjustMode;  // 0x18
        public Unity.Mathematics.float3 axisRotationPower;  // 0x1c
        public MagicaCloth.ChunkData chunk;  // 0x28

    }

    // TypeToken: 0x20000DD  // size: 0xB0
    public sealed struct AdjustRotationJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.AdjustRotationWorker.AdjustRotationData> dataList;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.AdjustRotationWorker.GroupData> groupList;  // 0x20
        public Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.Int32> particleMap;  // 0x30
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x40
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x50
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> snapBasePosList;  // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> snapBaseRotList;  // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;  // 0xa0

        // Methods
        // RVA: 0x089A77A4  token: 0x600071B
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000DF  // size: 0x58
    public sealed struct BaseSkinningData
    {
        // Fields
        public Unity.Mathematics.float3 localPos;  // 0x10
        public Unity.Mathematics.float3 localNor;  // 0x1c
        public Unity.Mathematics.float3 localTan;  // 0x28
        public Unity.Mathematics.int4 boneIndices;  // 0x34
        public Unity.Mathematics.float4 weights;  // 0x44
        public System.Int16 weightCount;  // 0x54

        // Methods
        // RVA: 0x089A86F0  token: 0x6000725
        public System.Boolean IsValid() { }

    }

    // TypeToken: 0x20000E0  // size: 0x3C
    public sealed struct GroupData
    {
        // Fields
        public System.Int32 teamId;  // 0x10
        public System.Int32 active;  // 0x14
        public System.Int32 updateFixed;  // 0x18
        public MagicaCloth.ChunkData dataChunk;  // 0x1c
        public MagicaCloth.ChunkData bindPoseChunk;  // 0x2c

    }

    // TypeToken: 0x20000E1  // size: 0xD0
    public sealed struct BaseSkinningJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.BaseSkinningWorker.GroupData> groupList;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.BaseSkinningWorker.BaseSkinningData> dataList;  // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float4x4> bindPoseList;  // 0x30
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x40
        public Unity.Collections.NativeArray<System.Int32> skinningBoneList;  // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> bonePosList;  // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> boneRotList;  // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> boneSclList;  // 0x80
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x90
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0xa0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> snapBasePosList;  // 0xb0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> snapBaseRotList;  // 0xc0

        // Methods
        // RVA: 0x089A86FC  token: 0x6000726
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000E3  // size: 0x38
    public sealed struct LineRotationData
    {
        // Fields
        public System.Int32 vertexIndex;  // 0x10
        public System.Int32 childCount;  // 0x14
        public System.Int32 childStartDataIndex;  // 0x18
        public Unity.Mathematics.float3 localPos;  // 0x1c
        public Unity.Mathematics.quaternion localRot;  // 0x28

    }

    // TypeToken: 0x20000E4  // size: 0x14
    public sealed struct LineRotationRootInfo
    {
        // Fields
        public System.UInt16 startIndex;  // 0x10
        public System.UInt16 dataLength;  // 0x12

    }

    // TypeToken: 0x20000E5  // size: 0x38
    public sealed struct GroupData
    {
        // Fields
        public System.Int32 teamId;  // 0x10
        public System.Int32 avarage;  // 0x14
        public MagicaCloth.ChunkData dataChunk;  // 0x18
        public MagicaCloth.ChunkData rootInfoChunk;  // 0x28

    }

    // TypeToken: 0x20000E6  // size: 0x98
    public sealed struct LineRotationJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Int32 fixedUpdateCount;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.LineWorker.LineRotationData> dataList;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.LineWorker.LineRotationRootInfo> rootInfoList;  // 0x28
        public Unity.Collections.NativeArray<System.Int32> rootTeamList;  // 0x38
        public Unity.Collections.NativeArray<MagicaCloth.LineWorker.GroupData> groupList;  // 0x48
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;  // 0x88

        // Methods
        // RVA: 0x089AB9EC  token: 0x6000730
        public virtual System.Void Execute(System.Int32 rootIndex) { }

    }

    // TypeToken: 0x20000E8  // size: 0x18
    public sealed struct CreateData
    {
        // Fields
        public System.Int32 vertexIndex;  // 0x10
        public System.Int32 particleIndex;  // 0x14

    }

    // TypeToken: 0x20000E9  // size: 0xA0
    public sealed struct VertexToParticleJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;  // 0x10
        public Unity.Collections.NativeArray<System.Int32> vertexToParticleList;  // 0x20
        public Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.Int32> vertexToParticleMap;  // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;  // 0x50
        public Unity.Collections.NativeArray<System.Int16> virtualVertexMeshIndexList;  // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> snapBasePosList;  // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> snapBaseRotList;  // 0x80
        private Unity.Collections.NativeParallelMultiHashMapIterator<System.Int32> iterator;  // 0x90

        // Methods
        // RVA: 0x089BB91C  token: 0x6000739
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000EA  // size: 0xE0
    public sealed struct ParticleToVertexJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> vertexToParticleList;  // 0x10
        public Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.Int32> vertexToParticleMap;  // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualPosList;  // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> virtualRotList;  // 0x40
        public Unity.Collections.NativeArray<System.Byte> virtualVertexFlagList;  // 0x50
        public Unity.Collections.NativeArray<System.Int16> virtualVertexMeshIndexList;  // 0x60
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;  // 0x70
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x80
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x90
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> particleFlagList;  // 0xa0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> particlePosList;  // 0xb0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> particleRotList;  // 0xc0
        private Unity.Collections.NativeParallelMultiHashMapIterator<System.Int32> iterator;  // 0xd0

        // Methods
        // RVA: 0x089AFF20  token: 0x600073A
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000EC  // size: 0x148
    public sealed struct CalcVertexUseFlagJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.UInt32 updateFlag;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.RenderMeshInfo> renderMeshInfoList;  // 0x18
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.SharedRenderMeshInfo> sharedRenderMeshInfoList;  // 0x28
        public Unity.Collections.NativeArray<System.Byte> virtualVertexUseList;  // 0x38
        public Unity.Collections.NativeArray<System.Byte> virtualVertexFixList;  // 0x48
        public Unity.Collections.NativeArray<System.UInt32> sharedChildVertexInfoList;  // 0x58
        public Unity.Collections.NativeArray<MagicaCloth.MeshData.VertexWeight> sharedChildVertexWeightList;  // 0x68
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> sharedRenderVertices;  // 0x78
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> sharedRenderNormals;  // 0x88
        public Unity.Collections.NativeArray<Unity.Mathematics.float4> sharedRenderTangents;  // 0x98
        public Unity.Collections.NativeArray<System.Byte> sharedBonesPerVertexList;  // 0xa8
        public Unity.Collections.NativeArray<System.Int32> sharedBonesPerVertexStartList;  // 0xb8
        public Unity.Collections.NativeArray<UnityEngine.BoneWeight1> sharedBoneWeightList;  // 0xc8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderPosList;  // 0xd8
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderNormalList;  // 0xe8
        public Unity.Collections.NativeArray<Unity.Mathematics.float4> renderTangentList;  // 0xf8
        public Unity.Collections.NativeArray<UnityEngine.BoneWeight1> renderBoneWeightList;  // 0x108
        public Unity.Collections.NativeArray<System.UInt32> renderVertexFlagList;  // 0x118
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderPosArray;  // 0x128
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderNormalArray;  // 0x138

        // Methods
        // RVA: 0x089A9A70  token: 0x6000744
        public virtual System.Void Execute(System.Int32 rmindex) { }

    }

    // TypeToken: 0x20000ED  // size: 0xF0
    public sealed struct CollectLocalPositionNormalTangentForEachMeshJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.RenderMeshInfo> renderMeshInfoList;  // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformPosList;  // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformRotList;  // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformSclList;  // 0x40
        public Unity.Collections.NativeArray<System.UInt32> sharedChildVertexInfoList;  // 0x50
        public Unity.Collections.NativeArray<MagicaCloth.MeshData.VertexWeight> sharedChildVertexWeightList;  // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualPosList;  // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> virtualRotList;  // 0x80
        public Unity.Collections.NativeArray<System.UInt32> renderVertexFlagList;  // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderPosList;  // 0xa0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderNormalList;  // 0xb0
        public Unity.Collections.NativeArray<Unity.Mathematics.float4> renderTangentList;  // 0xc0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderPosArray;  // 0xd0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderNormalArray;  // 0xe0

        // Methods
        // RVA: 0x089AA00C  token: 0x6000745
        public virtual System.Void Execute(System.Int32 rmindex) { }

    }

    // TypeToken: 0x20000EE  // size: 0xF0
    public sealed struct CollectLocalPositionNormalTangentForEachVertexJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.RenderMeshInfo> renderMeshInfoList;  // 0x10
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformPosList;  // 0x20
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformRotList;  // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformSclList;  // 0x40
        public Unity.Collections.NativeArray<System.UInt32> sharedChildVertexInfoList;  // 0x50
        public Unity.Collections.NativeArray<MagicaCloth.MeshData.VertexWeight> sharedChildVertexWeightList;  // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualPosList;  // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> virtualRotList;  // 0x80
        public Unity.Collections.NativeArray<System.UInt32> renderVertexFlagList;  // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderPosList;  // 0xa0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderNormalList;  // 0xb0
        public Unity.Collections.NativeArray<Unity.Mathematics.float4> renderTangentList;  // 0xc0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderPosArray;  // 0xd0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> renderNormalArray;  // 0xe0

        // Methods
        // RVA: 0x089AA368  token: 0x6000746
        public virtual System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x20000F0  // size: 0x18
    public sealed struct SpringData
    {
        // Fields
        public System.Int32 particleIndex;  // 0x10
        public System.Single weight;  // 0x14

    }

    // TypeToken: 0x20000F1  // size: 0xD0
    public sealed struct SpringJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> springVertexList;  // 0x10
        public Unity.Collections.NativeParallelMultiHashMap<System.Int32,MagicaCloth.SpringMeshWorker.SpringData> springMap;  // 0x20
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x30
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> particlePosList;  // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> particleRotList;  // 0x50
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> snapBasePosList;  // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> snapBaseRotList;  // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualPosList;  // 0x80
        public Unity.Collections.NativeArray<System.Byte> virtualVertexFlagList;  // 0x90
        public Unity.Collections.NativeArray<System.Int16> virtualVertexMeshIndexList;  // 0xa0
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;  // 0xb0
        private Unity.Collections.NativeParallelMultiHashMapIterator<System.Int32> iterator;  // 0xc0

        // Methods
        // RVA: 0x089B9E2C  token: 0x600074F
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000F3  // size: 0x2C
    public sealed struct TriangleRotationData
    {
        // Fields
        public System.Int32 targetIndex;  // 0x10
        public System.Int32 triangleCount;  // 0x14
        public System.Int32 triangleStartIndex;  // 0x18
        public Unity.Mathematics.quaternion localRot;  // 0x1c

        // Methods
        // RVA: 0x02BB8B20  token: 0x6000758
        public System.Boolean IsValid() { }

    }

    // TypeToken: 0x20000F4  // size: 0x34
    public sealed struct GroupData
    {
        // Fields
        public System.Int32 teamId;  // 0x10
        public MagicaCloth.ChunkData triangleDataChunk;  // 0x14
        public MagicaCloth.ChunkData triangleIndexChunk;  // 0x24

    }

    // TypeToken: 0x20000F5  // size: 0x90
    public sealed struct TriangleRotationJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.TriangleWorker.TriangleRotationData> triangleDataList;  // 0x10
        public Unity.Collections.NativeArray<System.Int32> triangleIndexList;  // 0x20
        public Unity.Collections.NativeArray<MagicaCloth.TriangleWorker.GroupData> groupList;  // 0x30
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x40
        public Unity.Collections.NativeArray<System.Int32> teamIdList;  // 0x50
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> posList;  // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotList;  // 0x80

        // Methods
        // RVA: 0x089BAA10  token: 0x6000759
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x20000F7  // size: 0xE0
    public sealed struct ReadMeshPositionJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList;  // 0x20
        public Unity.Collections.NativeArray<System.Int16> virtualVertexMeshIndexList;  // 0x30
        public Unity.Collections.NativeArray<System.Byte> virtualVertexUseList;  // 0x40
        public Unity.Collections.NativeArray<System.Int32> virtualTransformIndexList;  // 0x50
        public Unity.Collections.NativeArray<System.UInt32> sharedVirtualVertexInfoList;  // 0x60
        public Unity.Collections.NativeArray<MagicaCloth.MeshData.VertexWeight> sharedVirtualWeightList;  // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformPosList;  // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> transformRotList;  // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformSclList;  // 0xa0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualPosList;  // 0xb0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> virtualRotList;  // 0xc0
        public Unity.Collections.NativeArray<System.Byte> virtualVertexFlagList;  // 0xd0

        // Methods
        // RVA: 0x089CDBEC  token: 0x6000762
        public virtual System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x20000F8  // size: 0xB0
    public sealed struct CalcMeshTriangleNormalTangentJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList;  // 0x20
        public Unity.Collections.NativeArray<System.UInt16> virtualTriangleMeshIndexList;  // 0x30
        public Unity.Collections.NativeArray<System.Byte> virtualVertexUseList;  // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualPosList;  // 0x50
        public Unity.Collections.NativeArray<System.Int32> sharedTriangles;  // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float2> sharedMeshUv;  // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualTriangleNormalList;  // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualTriangleTangentList;  // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformSclList;  // 0xa0

        // Methods
        // RVA: 0x089BCB10  token: 0x6000763
        public virtual System.Void Execute(System.Int32 tindex) { }

    }

    // TypeToken: 0x20000F9  // size: 0xB0
    public sealed struct CalcVertexNormalTangentFromTriangleJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList;  // 0x20
        public Unity.Collections.NativeArray<System.Int16> virtualVertexMeshIndexList;  // 0x30
        public Unity.Collections.NativeArray<System.Byte> virtualVertexUseList;  // 0x40
        public Unity.Collections.NativeArray<System.Byte> virtualVertexFlagList;  // 0x50
        public Unity.Collections.NativeArray<System.UInt32> sharedVirtualVertexToTriangleInfoList;  // 0x60
        public Unity.Collections.NativeArray<System.Int32> sharedVirtualVertexToTriangleIndexList;  // 0x70
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualTriangleNormalList;  // 0x80
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualTriangleTangentList;  // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> virtualRotList;  // 0xa0

        // Methods
        // RVA: 0x089BD0FC  token: 0x6000764
        public virtual System.Void Execute(System.Int32 vindex) { }

    }

    // TypeToken: 0x20000FA  // size: 0xE0
    public sealed struct CalcMeshTriangleNormalTangentForEachMeshJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;  // 0x10
        public Unity.Collections.NativeArray<MagicaCloth.PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList;  // 0x20
        public Unity.Collections.NativeArray<System.Byte> virtualVertexUseList;  // 0x30
        public Unity.Collections.NativeArray<System.Byte> virtualVertexFlagList;  // 0x40
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualPosList;  // 0x50
        public Unity.Collections.NativeArray<System.Int32> sharedTriangles;  // 0x60
        public Unity.Collections.NativeArray<Unity.Mathematics.float2> sharedMeshUv;  // 0x70
        public Unity.Collections.NativeArray<System.UInt32> sharedVirtualVertexToTriangleInfoList;  // 0x80
        public Unity.Collections.NativeArray<System.Int32> sharedVirtualVertexToTriangleIndexList;  // 0x90
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> transformSclList;  // 0xa0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualTriangleNormalList;  // 0xb0
        public Unity.Collections.NativeArray<Unity.Mathematics.float3> virtualTriangleTangentList;  // 0xc0
        public Unity.Collections.NativeArray<Unity.Mathematics.quaternion> virtualRotList;  // 0xd0

        // Methods
        // RVA: 0x089BC1D4  token: 0x6000765
        public virtual System.Void Execute(System.Int32 mindex) { }

    }

    // TypeToken: 0x20000FE  // size: 0x30
    public sealed class <Start>d__3 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public MagicaCloth.BlastWaveController <>4__this;  // 0x20
        private System.Single <main>5__2;  // 0x28
        private System.Single <time>5__3;  // 0x2c

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000770
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000771
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x089D06F4  token: 0x6000772
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x089D0884  token: 0x6000774
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000100  // size: 0x14
    public sealed struct MoveMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.CameraOrbit.MoveMode None;  // const
        public static MagicaCloth.CameraOrbit.MoveMode UpDown;  // const
        public static MagicaCloth.CameraOrbit.MoveMode Free;  // const

    }

    // TypeToken: 0x2000102  // size: 0x30
    public sealed class <CreateObject>d__7 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Object <>2__current;  // 0x18
        public MagicaCloth.CopyObject <>4__this;  // 0x20
        private System.Int32 <i>5__2;  // 0x28
        private System.Int32 <j>5__3;  // 0x2c

        // Properties
        System.Object System.Collections.Generic.IEnumerator<System.Object>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x010410F0  token: 0x6000786
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000787
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x089D04C4  token: 0x6000788
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x089D06A8  token: 0x600078A
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000104  // size: 0x30
    public class AvatarPartsGroup
    {
        // Fields
        public System.String groupName;  // 0x10
        public System.Collections.Generic.List<UnityEngine.GameObject> partsPrefabList;  // 0x18
        public System.Int32 id;  // 0x20
        public System.Int32 handle;  // 0x24
        public System.Int32 index;  // 0x28

        // Methods
        // RVA: 0x089BBE78  token: 0x6000794
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000106  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly MagicaCloth.ModelController.<>c <>9;  // static @ 0x0
        public static System.Action<UnityEngine.Animator> <>9__7_0;  // static @ 0x8
        public static System.Action<UnityEngine.Animator> <>9__8_0;  // static @ 0x10
        public static System.Action<MagicaCloth.BaseCloth> <>9__10_0;  // static @ 0x18

        // Methods
        // RVA: 0x089D0A6C  token: 0x600079E
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600079F
        public System.Void .ctor() { }
        // RVA: 0x089D0974  token: 0x60007A0
        private System.Void <OnNextButton>b__7_0(UnityEngine.Animator ani) { }
        // RVA: 0x089D092C  token: 0x60007A1
        private System.Void <OnBackButton>b__8_0(UnityEngine.Animator ani) { }
        // RVA: 0x089D08D0  token: 0x60007A2
        private System.Void <OnActiveButton>b__10_0(MagicaCloth.BaseCloth cloth) { }

    }

    // TypeToken: 0x2000107  // size: 0x18
    public sealed class <>c__DisplayClass9_0
    {
        // Fields
        public System.Single timeScale;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60007A3
        public System.Void .ctor() { }
        // RVA: 0x089D0A24  token: 0x60007A4
        private System.Void <OnSlowButton>b__0(UnityEngine.Animator ani) { }
        // RVA: 0x089D0A48  token: 0x60007A5
        private System.Void <OnSlowButton>b__1(MagicaCloth.BaseCloth cloth) { }

    }

    // TypeToken: 0x200010C  // size: 0x20
    public sealed class <>c__DisplayClass5_0
    {
        // Fields
        public System.Action<System.Int32,System.Int32> onClick;  // 0x10
        public MagicaCloth.UIPartsItem <>4__this;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60007BE
        public System.Void .ctor() { }
        // RVA: 0x089D09BC  token: 0x60007BF
        private System.Void <Init>b__0() { }
        // RVA: 0x089D09F0  token: 0x60007C0
        private System.Void <Init>b__1() { }

    }

    // TypeToken: 0x2000116  // size: 0x20
    public class Point
    {
        // Fields
        public System.Int32 id;  // 0x10
        public Unity.Mathematics.float3 pos;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x600080F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000128  // size: 0x20
    public class TetraVertex
    {
        // Fields
        public System.Int32 index;  // 0x10
        public UnityEngine.Vector3 pos;  // 0x14

        // Methods
        // RVA: 0x0350B670  token: 0x60008F3
        public System.Void .ctor() { }
        // RVA: 0x03D6E3C0  token: 0x60008F4
        public System.Void .ctor(UnityEngine.Vector3 pos, System.Int32 index) { }

    }

    // TypeToken: 0x2000129  // size: 0x38
    public class Tetra
    {
        // Fields
        public System.Collections.Generic.List<MagicaCloth.MeshUtility.TetraVertex> vertexList;  // 0x10
        public UnityEngine.Vector3 circumCenter;  // 0x18
        public System.Single circumRadius;  // 0x24
        public UnityEngine.Vector3 tetraCenter;  // 0x28
        public System.Single tetraSize;  // 0x34

        // Methods
        // RVA: 0x089D35AC  token: 0x60008F5
        public System.Void .ctor() { }
        // RVA: 0x089D3490  token: 0x60008F6
        public System.Void .ctor(MagicaCloth.MeshUtility.TetraVertex a, MagicaCloth.MeshUtility.TetraVertex b, MagicaCloth.MeshUtility.TetraVertex c, MagicaCloth.MeshUtility.TetraVertex d) { }
        // RVA: 0x089D3144  token: 0x60008F7
        public System.UInt64 GetTetraHash() { }
        // RVA: 0x089D2714  token: 0x60008F8
        public System.Void CalcCircumcircle() { }
        // RVA: 0x08957FC0  token: 0x60008F9
        public System.Boolean IntersectCircumcircle(UnityEngine.Vector3 pos) { }
        // RVA: 0x08957D2C  token: 0x60008FA
        public System.Boolean CheckSame(MagicaCloth.MeshUtility.Tetra tri) { }
        // RVA: 0x089D30F0  token: 0x60008FB
        public System.Boolean ContainsPoint(MagicaCloth.MeshUtility.TetraVertex p1) { }
        // RVA: 0x089D3024  token: 0x60008FC
        public System.Boolean ContainsPoint(MagicaCloth.MeshUtility.TetraVertex p1, MagicaCloth.MeshUtility.TetraVertex p2, MagicaCloth.MeshUtility.TetraVertex p3, MagicaCloth.MeshUtility.TetraVertex p4) { }
        // RVA: 0x089D2D7C  token: 0x60008FD
        public System.Void CalcSize() { }
        // RVA: 0x089D3238  token: 0x60008FE
        public System.Boolean Verification() { }

    }

    // TypeToken: 0x200012C  // size: 0x14
    public sealed struct UpdateCount
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.UpdateTimeManager.UpdateCount _60;  // const
        public static MagicaCloth.UpdateTimeManager.UpdateCount _90_Default;  // const
        public static MagicaCloth.UpdateTimeManager.UpdateCount _120;  // const
        public static MagicaCloth.UpdateTimeManager.UpdateCount _150;  // const
        public static MagicaCloth.UpdateTimeManager.UpdateCount _180;  // const

    }

    // TypeToken: 0x200012D  // size: 0x14
    public sealed struct UpdateMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.UpdateTimeManager.UpdateMode UnscaledTime;  // const
        public static MagicaCloth.UpdateTimeManager.UpdateMode OncePerFrame;  // const
        public static MagicaCloth.UpdateTimeManager.UpdateMode DelayUnscaledTime;  // const

    }

    // TypeToken: 0x200012E  // size: 0x14
    public sealed struct UpdateLocation
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.UpdateTimeManager.UpdateLocation AfterLateUpdate;  // const
        public static MagicaCloth.UpdateTimeManager.UpdateLocation BeforeLateUpdate;  // const

    }

namespace MagicaCloth
{

    // TypeToken: 0x2000025  // size: 0xC8
    public abstract class BaseCloth : MagicaCloth.PhysicsTeam
    {
        // Fields
        protected MagicaCloth.ClothParams clothParams;  // 0x78
        protected System.Collections.Generic.List<System.Int32> clothParamDataHashList;  // 0x80
        private MagicaCloth.ClothData clothData;  // 0x88
        protected System.Int32 clothDataHash;  // 0x90
        protected System.Int32 clothDataVersion;  // 0x94
        private MagicaCloth.SelectionData clothSelection;  // 0x98
        private System.Int32 clothSelectionHash;  // 0xa0
        private System.Int32 clothSelectionVersion;  // 0xa4
        private System.Collections.Generic.List<UnityEngine.Renderer> cullRendererList;  // 0xa8
        protected MagicaCloth.ClothSetup setup;  // 0xb0
        private System.Single oldBlendRatio;  // 0xb8
        private MagicaCloth.PhysicsTeam.TeamUpdateMode oldUpdateMode;  // 0xbc
        private MagicaCloth.PhysicsTeam.TeamCullingMode oldCullingMode;  // 0xc0
        private System.Boolean oldUseAnimatedDistance;  // 0xc4

        // Properties
        System.Single BlendWeight { get; /* RVA: 0x03D4EC70 */ set; /* RVA: 0x089438C4 */ }
        UnityEngine.Vector3 Gravity_GravityDirection { get; /* RVA: 0x08943778 */ set; /* RVA: 0x08943BE4 */ }
        System.Boolean DistanceDisable_Active { get; /* RVA: 0x089436B8 */ set; /* RVA: 0x089439A0 */ }
        UnityEngine.Transform DistanceDisable_ReferenceObject { get; /* RVA: 0x08943718 */ set; /* RVA: 0x08943A10 */ }
        System.Single DistanceDisable_Distance { get; /* RVA: 0x089436D8 */ set; /* RVA: 0x089439C0 */ }
        System.Single DistanceDisable_FadeDistance { get; /* RVA: 0x089436F8 */ set; /* RVA: 0x089439E8 */ }
        System.Single ExternalForce_WindInfluence { get; /* RVA: 0x08943738 */ set; /* RVA: 0x08943A3C */ }
        System.Single ExternalForce_WindRandomScale { get; /* RVA: 0x08943758 */ set; /* RVA: 0x08943B10 */ }
        System.Single WorldInfluence_MaxMoveSpeed { get; /* RVA: 0x08943804 */ set; /* RVA: 0x08943F1C */ }
        System.Boolean WorldInfluence_ResetAfterTeleport { get; /* RVA: 0x08943824 */ set; /* RVA: 0x08943FE4 */ }
        System.Single WorldInfluence_TeleportDistance { get; /* RVA: 0x08943864 */ set; /* RVA: 0x0894414C */ }
        System.Single WorldInfluence_TeleportRotation { get; /* RVA: 0x089438A4 */ set; /* RVA: 0x089442D0 */ }
        MagicaCloth.ClothParams.TeleportMode WorldInfluence_TeleportMode { get; /* RVA: 0x08943884 */ set; /* RVA: 0x08944210 */ }
        System.Single WorldInfluence_StabilizationTime { get; /* RVA: 0x08943844 */ set; /* RVA: 0x089440A8 */ }
        System.Boolean ColliderCollision_Active { get; /* RVA: 0x08943698 */ set; /* RVA: 0x089438DC */ }
        System.Boolean Penetration_Active { get; /* RVA: 0x089437A4 */ set; /* RVA: 0x08943CC4 */ }
        System.Boolean Spring_Active { get; /* RVA: 0x089437C4 */ set; /* RVA: 0x08943D8C */ }
        System.Single Spring_Power { get; /* RVA: 0x089437E4 */ set; /* RVA: 0x08943E4C */ }
        MagicaCloth.ClothParams Params { get; /* RVA: 0x03D4EB20 */ }
        MagicaCloth.ClothData ClothData { get; /* RVA: 0x03D4EA60 */ set; /* RVA: 0x04274DA0 */ }
        MagicaCloth.SelectionData ClothSelection { get; /* RVA: 0x011AC510 */ }
        MagicaCloth.ClothSetup Setup { get; /* RVA: 0x03D4EAD0 */ }

        // Methods
        // RVA: 0x08942910  token: 0x60000B5
        public System.Void ResetCloth() { }
        // RVA: 0x089428E0  token: 0x60000B6
        public System.Void ResetCloth(System.Single resetStabilizationTime) { }
        // RVA: 0x08942940  token: 0x60000B7
        public System.Void ResetCloth(MagicaCloth.ClothParams.TeleportMode teleportMode, System.Single resetStabilizationTime) { }
        // RVA: 0x08942948  token: 0x60000B8
        public System.Void SetTimeScale(System.Single timeScale) { }
        // RVA: 0x08941B58  token: 0x60000B9
        public System.Single GetTimeScale() { }
        // RVA: 0x08940DF0  token: 0x60000BA
        public System.Void AddForce(UnityEngine.Vector3 force, MagicaCloth.PhysicsManagerTeamData.ForceMode mode) { }
        // RVA: 0x08940D4C  token: 0x60000BD
        public System.Void AddCollider(MagicaCloth.ColliderComponent collider) { }
        // RVA: 0x08942630  token: 0x60000BE
        public System.Void RemoveCollider(MagicaCloth.ColliderComponent collider) { }
        // RVA: 0x03D4EF20  token: 0x60000BF
        public System.Void SetUpdateMode(MagicaCloth.PhysicsTeam.TeamUpdateMode updateMode) { }
        // RVA: 0x03D4EF10  token: 0x60000C0
        public System.Void SetCullingMode(MagicaCloth.PhysicsTeam.TeamCullingMode cullingMode) { }
        // RVA: 0x089424A8  token: 0x60000C1
        public System.Void Radius_SetRadius(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        // RVA: 0x08941DD8  token: 0x60000C2
        public System.Void Mass_SetMass(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        // RVA: 0x0894110C  token: 0x60000C3
        public System.Void ClampPosition_SetPositionLength(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        // RVA: 0x08941C50  token: 0x60000C4
        public System.Void Gravity_SetGravity(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        // RVA: 0x08941644  token: 0x60000C7
        public System.Void Drag_SetDrag(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        // RVA: 0x08941820  token: 0x60000D0
        public System.Void ExternalForce_DepthInfluence(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        // RVA: 0x08943348  token: 0x60000D5
        public System.Void WorldInfluence_SetMovementInfluence(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        // RVA: 0x08943444  token: 0x60000D6
        public System.Void WorldInfluence_SetRotationInfluence(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        // RVA: 0x08943200  token: 0x60000E3
        public System.Void WorldInfluence_ReplaceInfluenceTarget(UnityEngine.Transform target) { }
        // RVA: 0x08942398  token: 0x60000E8
        public System.Void Penetration_SetMovingRadius(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        // RVA: 0x08941A8C  token: 0x60000ED
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x0350B670  token: 0x60000F3
        protected virtual System.Void Reset() { }
        // RVA: 0x08942350  token: 0x60000F4
        protected virtual System.Void OnValidate() { }
        // RVA: 0x08942330  token: 0x60000F5
        protected virtual System.Void OnInit() { }
        // RVA: 0x08941F70  token: 0x60000F6
        protected virtual System.Void OnActive() { }
        // RVA: 0x089421F4  token: 0x60000F7
        protected virtual System.Void OnInactive() { }
        // RVA: 0x089421D4  token: 0x60000F8
        protected virtual System.Void OnDispose() { }
        // RVA: 0x08942CCC  token: 0x60000F9
        private virtual System.Void UpdateCullingMode(MagicaCloth.CoreComponent caller) { }
        // RVA: 0x089420C0  token: 0x60000FA
        protected virtual System.Void OnChangeCalculation() { }
        // RVA: 0x0894196C  token: 0x60000FB
        public System.Int32 GetCullRenderListCount() { }
        // RVA: 0x08940F84  token: 0x60000FC
        private System.Void BaseClothInit() { }
        // RVA: 0x08940ED0  token: 0x60000FD
        private System.Void BaseClothDispose() { }
        // RVA: 0x08941378  token: 0x60000FE
        protected virtual System.Void ClothInit() { }
        // RVA: 0x089412B8  token: 0x60000FF
        protected virtual System.Void ClothActive() { }
        // RVA: 0x08941350  token: 0x6000100
        protected virtual System.Void ClothInactive() { }
        // RVA: 0x0350B670  token: 0x6000101
        protected virtual System.Void ClothDispose() { }
        // RVA: -1  // abstract  token: 0x6000102
        protected virtual System.UInt32 UserFlag(System.Int32 vindex) { }
        // RVA: -1  // abstract  token: 0x6000103
        protected virtual UnityEngine.Transform UserTransform(System.Int32 vindex) { }
        // RVA: -1  // abstract  token: 0x6000104
        protected virtual Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex) { }
        // RVA: -1  // abstract  token: 0x6000105
        protected virtual Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex) { }
        // RVA: -1  // abstract  token: 0x6000106
        public virtual System.Boolean IsRequiresDeformer() { }
        // RVA: -1  // abstract  token: 0x6000107
        public virtual MagicaCloth.BaseMeshDeformer GetDeformer() { }
        // RVA: -1  // abstract  token: 0x6000108
        protected virtual MagicaCloth.MeshData GetMeshData() { }
        // RVA: -1  // abstract  token: 0x6000109
        protected virtual System.Void WorkerInit() { }
        // RVA: 0x089429D0  token: 0x600010A
        private System.Void SetUseMesh(System.Boolean sw) { }
        // RVA: 0x08942A58  token: 0x600010B
        private System.Void SetUseVertex(System.Boolean sw) { }
        // RVA: -1  // abstract  token: 0x600010C
        protected virtual System.Void SetDeformerUseVertex(System.Boolean sw, MagicaCloth.BaseMeshDeformer deformer) { }
        // RVA: 0x08941608  token: 0x600010D
        private System.Void DeformerForEach(System.Action<MagicaCloth.BaseMeshDeformer> act) { }
        // RVA: 0x08942ADC  token: 0x600010E
        public System.Void UpdateBlend() { }
        // RVA: -1  // generic def  token: 0x600010F
        public virtual System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        // RVA: 0x08941BD4  token: 0x6000110
        public virtual System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        // RVA: 0x08941080  token: 0x6000111
        protected virtual System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        // RVA: 0x0894145C  token: 0x6000112
        public virtual System.Void CreateVerifyData() { }
        // RVA: 0x089430C8  token: 0x6000113
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x08941D28  token: 0x6000114
        public System.Boolean HasChangedParam(MagicaCloth.ClothParams.ParamType ptype) { }
        // RVA: 0x08943040  token: 0x6000115
        public MagicaCloth.Define.Error VerifyAlgorithmVersion() { }
        // RVA: 0x08943008  token: 0x6000116
        public virtual System.Boolean UpgradeFormat() { }
        // RVA: 0x089418F0  token: 0x6000117
        public virtual System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        // RVA: 0x0894171C  token: 0x6000118
        public virtual MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        // RVA: 0x089426BC  token: 0x6000119
        private System.Void ResetClothInternal(MagicaCloth.ClothParams.TeleportMode teleportMode, System.Single resetStabilizationTime) { }
        // RVA: 0x08943540  token: 0x600011A
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000027  // size: 0x38
    public abstract class CoreComponent : MagicaCloth.BaseComponent, MagicaCloth.IShareDataObject, MagicaCloth.IDataVerify, MagicaCloth.IEditorMesh, MagicaCloth.IEditorCloth, MagicaCloth.IDataHash, MagicaCloth.IBoneReplace
    {
        // Fields
        protected System.Int32 dataHash;  // 0x18
        protected System.Int32 dataVersion;  // 0x1c
        protected MagicaCloth.RuntimeStatus status;  // 0x20
        private System.Int32 useUnityPhysicsCount;  // 0x28
        private System.Boolean nowUseUnityPhysics;  // 0x2c
        private System.Boolean <IsVisible>k__BackingField;  // 0x2d
        protected System.Int32 calculateValue;  // 0x30

        // Properties
        MagicaCloth.RuntimeStatus Status { get; /* RVA: 0x03D4EB40 */ }
        System.Boolean IsVisible { get; /* RVA: 0x03D4F4C0 */ set; /* RVA: 0x03D4F4F0 */ }
        System.Boolean IsCalculate { get; /* RVA: 0x056B62D4 */ }
        System.Int32 SaveDataHash { get; /* RVA: 0x020D1AC0 */ }
        System.Int32 SaveDataVersion { get; /* RVA: 0x03D4EBB0 */ }

        // Methods
        // RVA: 0x089696E0  token: 0x600011E
        public System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> GetUsedComponentBones() { }
        // RVA: 0x08969644  token: 0x600011F
        public System.Collections.Generic.List<System.String> GetUsedComponentBoneNames() { }
        // RVA: 0x08969D9C  token: 0x6000120
        public System.Void ReplaceComponentBone(System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform> boneReplaceDict) { }
        // RVA: 0x08969D54  token: 0x6000121
        public System.Void ReplaceComponentBone(System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> boneReplaceDict) { }
        // RVA: -1  // abstract  token: 0x6000126
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x08969E7C  token: 0x6000129
        protected virtual System.Void Start() { }
        // RVA: 0x08969CBC  token: 0x600012A
        public virtual System.Void OnEnable() { }
        // RVA: 0x08969C88  token: 0x600012B
        public virtual System.Void OnDisable() { }
        // RVA: 0x08969BEC  token: 0x600012C
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x089699C0  token: 0x600012D
        public System.Void Init() { }
        // RVA: -1  // abstract  token: 0x600012E
        protected virtual System.Void OnInit() { }
        // RVA: -1  // abstract  token: 0x600012F
        protected virtual System.Void OnDispose() { }
        // RVA: -1  // abstract  token: 0x6000130
        protected virtual System.Void OnUpdate() { }
        // RVA: -1  // abstract  token: 0x6000131
        protected virtual System.Void OnActive() { }
        // RVA: -1  // abstract  token: 0x6000132
        protected virtual System.Void OnInactive() { }
        // RVA: 0x08969CE8  token: 0x6000133
        protected virtual System.Void OnUpdateStatus() { }
        // RVA: 0x08969CB4  token: 0x6000134
        protected virtual System.Void OnDisconnectedStatus() { }
        // RVA: 0x08969DE4  token: 0x6000135
        public System.Void SetUseUnityPhysics(System.Boolean sw) { }
        // RVA: 0x089693EC  token: 0x6000136
        private System.Void ActiveUseUnityPhysics() { }
        // RVA: 0x089699A4  token: 0x6000137
        private System.Void InactiveUseUnityPhysics() { }
        // RVA: 0x0350B670  token: 0x6000138
        protected virtual System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        // RVA: 0x07D5D124  token: 0x6000139
        protected System.Boolean IsUseUnityPhysics() { }
        // RVA: 0x08969440  token: 0x600013A
        public virtual System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        // RVA: -1  // abstract  token: 0x600013B
        public virtual MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        // RVA: 0x08969E48  token: 0x600013C
        protected System.Void SetUserEnable(System.Boolean sw) { }
        // RVA: 0x0350B670  token: 0x600013D
        private virtual System.Void UpdateCullingMode(MagicaCloth.CoreComponent Caller) { }
        // RVA: 0x0350B670  token: 0x600013E
        protected virtual System.Void OnChangeCalculation() { }
        // RVA: -1  // abstract  token: 0x600013F
        public virtual System.Int32 GetVersion() { }
        // RVA: -1  // abstract  token: 0x6000140
        public virtual System.Int32 GetErrorVersion() { }
        // RVA: 0x08969EC0  token: 0x6000141
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x08969E84  token: 0x6000142
        public MagicaCloth.Define.Error VerifyDataVersion() { }
        // RVA: 0x08969BC8  token: 0x6000143
        public System.Boolean IsOldDataVertion() { }
        // RVA: 0x08969410  token: 0x6000144
        public virtual System.Void CreateVerifyData() { }
        // RVA: 0x08969584  token: 0x6000145
        public virtual System.String GetInformation() { }
        // RVA: 0x0115F4C0  token: 0x6000146
        public virtual System.Boolean UpgradeFormat() { }
        // RVA: -1  // generic def  token: 0x6000147
        public System.Void ChangeAvatar(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        // RVA: -1  // generic def  token: 0x6000148
        public virtual System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        // RVA: 0x089695B0  token: 0x6000149
        public virtual System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        // RVA: 0x089694EC  token: 0x600014A
        public virtual System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        // RVA: 0x08969538  token: 0x600014B
        public virtual System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        // RVA: 0x089694A0  token: 0x600014C
        public virtual System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        // RVA: 0x01002730  token: 0x600014D
        public virtual System.Collections.Generic.List<System.Int32> GetSelectionList() { }
        // RVA: 0x01002730  token: 0x600014E
        public virtual System.Collections.Generic.List<System.Int32> GetUseList() { }
        // RVA: 0x08969F44  token: 0x600014F
        protected System.Void .ctor() { }
        // RVA: 0x0339AE90  token: 0x6000150
        private System.Object <Init>b__27_0() { }

    }

    // TypeToken: 0x2000028  // size: 0x30
    public class AvatarPartsAttachEvent : UnityEngine.Events.UnityEvent`2
    {
        // Methods
        // RVA: 0x0895B444  token: 0x6000151
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000029  // size: 0x30
    public class AvatarPartsDetachEvent : UnityEngine.Events.UnityEvent`1
    {
        // Methods
        // RVA: 0x0895B480  token: 0x6000152
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002A  // size: 0x30
    public class PhysicsManagerPreUpdateEvent : UnityEngine.Events.UnityEvent
    {
        // Methods
        // RVA: 0x04271C98  token: 0x6000153
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002B  // size: 0x30
    public class PhysicsManagerPostUpdateEvent : UnityEngine.Events.UnityEvent
    {
        // Methods
        // RVA: 0x04271C98  token: 0x6000154
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002C  // size: 0x60
    public class MagicaAreaWind : MagicaCloth.WindComponent
    {
        // Fields
        private MagicaCloth.PhysicsManagerWindData.ShapeType shapeType;  // 0x58
        private System.Boolean isAddition;  // 0x5c

        // Properties
        MagicaCloth.PhysicsManagerWindData.ShapeType ShapeType { get; /* RVA: 0x03D4EF00 */ set; /* RVA: 0x0896A1DC */ }
        System.Boolean Addition { get; /* RVA: 0x03D4F600 */ set; /* RVA: 0x0896A1BC */ }

        // Methods
        // RVA: 0x03D6DF90  token: 0x6000159
        public virtual MagicaCloth.ComponentType GetComponentType() { }
        // RVA: 0x02102C70  token: 0x600015A
        public virtual MagicaCloth.PhysicsManagerWindData.WindType GetWindType() { }
        // RVA: 0x03D4EF00  token: 0x600015B
        public virtual MagicaCloth.PhysicsManagerWindData.ShapeType GetShapeType() { }
        // RVA: 0x0896A144  token: 0x600015C
        public virtual MagicaCloth.PhysicsManagerWindData.DirectionType GetDirectionType() { }
        // RVA: 0x03D4F600  token: 0x600015D
        public virtual System.Boolean IsAddition() { }
        // RVA: 0x0896A004  token: 0x600015E
        public virtual UnityEngine.Vector3 GetAreaSize() { }
        // RVA: 0x0896A09C  token: 0x600015F
        public virtual System.Single GetAreaVolume() { }
        // RVA: 0x08969FB8  token: 0x6000160
        public virtual System.Single GetAreaLength() { }
        // RVA: 0x0896A154  token: 0x6000161
        protected virtual System.Void ResetParams() { }
        // RVA: 0x0896A1B4  token: 0x6000162
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002D  // size: 0x58
    public class MagicaAvatar : MagicaCloth.CoreComponent
    {
        // Fields
        private static System.Int32 DATA_VERSION;  // const
        private System.Boolean dataReset;  // 0x38
        private MagicaCloth.MagicaAvatarRuntime runtime;  // 0x40
        public MagicaCloth.AvatarPartsAttachEvent OnAttachParts;  // 0x48
        public MagicaCloth.AvatarPartsDetachEvent OnDetachParts;  // 0x50

        // Properties
        System.Boolean DataReset { get; /* RVA: 0x03D4F190 */ set; /* RVA: 0x03D4E280 */ }
        MagicaCloth.MagicaAvatarRuntime Runtime { get; /* RVA: 0x03A46A20 */ }

        // Methods
        // RVA: 0x0896CD9C  token: 0x6000163
        public System.Int32 AttachAvatarParts(UnityEngine.GameObject avatarPartsPrefab, System.Action<UnityEngine.GameObject> instanceAction) { }
        // RVA: 0x0896CE9C  token: 0x6000164
        public System.Void DetachAvatarParts(System.Int32 partsId) { }
        // RVA: 0x0896CEC8  token: 0x6000165
        public System.Void DetachAvatarParts(UnityEngine.GameObject avatarPartsObject) { }
        // RVA: 0x0896CE6C  token: 0x6000166
        public System.Void DetachAvatarParts(MagicaCloth.MagicaAvatarParts parts) { }
        // RVA: 0x03D5D090  token: 0x6000167
        public virtual MagicaCloth.ComponentType GetComponentType() { }
        // RVA: 0x01002730  token: 0x6000168
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x03D5C330  token: 0x600016C
        private System.Void Reset() { }
        // RVA: 0x0350B670  token: 0x600016D
        private System.Void OnValidate() { }
        // RVA: 0x0896D5E4  token: 0x600016E
        protected virtual System.Void OnInit() { }
        // RVA: 0x0896D594  token: 0x600016F
        protected virtual System.Void OnDispose() { }
        // RVA: 0x0350B670  token: 0x6000170
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x0896D56C  token: 0x6000171
        protected virtual System.Void OnActive() { }
        // RVA: 0x0896D5BC  token: 0x6000172
        protected virtual System.Void OnInactive() { }
        // RVA: 0x01168950  token: 0x6000173
        public virtual System.Int32 GetVersion() { }
        // RVA: 0x01002730  token: 0x6000174
        public virtual System.Int32 GetErrorVersion() { }
        // RVA: 0x0896CE64  token: 0x6000175
        public virtual System.Void CreateVerifyData() { }
        // RVA: 0x0896D60C  token: 0x6000176
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x0896CF40  token: 0x6000177
        public virtual System.String GetInformation() { }
        // RVA: 0x0896CF38  token: 0x6000178
        public virtual System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        // RVA: 0x01002730  token: 0x6000179
        public virtual MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        // RVA: 0x0896D684  token: 0x600017A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002E  // size: 0x58
    public class MagicaDirectionalWind : MagicaCloth.WindComponent
    {
        // Methods
        // RVA: 0x03D6DFF0  token: 0x600017B
        public virtual MagicaCloth.ComponentType GetComponentType() { }
        // RVA: 0x01168950  token: 0x600017C
        public virtual MagicaCloth.PhysicsManagerWindData.WindType GetWindType() { }
        // RVA: 0x01002730  token: 0x600017D
        public virtual MagicaCloth.PhysicsManagerWindData.ShapeType GetShapeType() { }
        // RVA: 0x01002730  token: 0x600017E
        public virtual MagicaCloth.PhysicsManagerWindData.DirectionType GetDirectionType() { }
        // RVA: 0x0115F4C0  token: 0x600017F
        public virtual System.Boolean IsAddition() { }
        // RVA: 0x03D6DFC0  token: 0x6000180
        public virtual UnityEngine.Vector3 GetAreaSize() { }
        // RVA: 0x03D6DFE0  token: 0x6000181
        public virtual System.Single GetAreaVolume() { }
        // RVA: 0x03D6DFB0  token: 0x6000182
        public virtual System.Single GetAreaLength() { }
        // RVA: 0x0896D764  token: 0x6000183
        protected virtual System.Void ResetParams() { }
        // RVA: 0x0896A1B4  token: 0x6000184
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200002F  // size: 0x80
    public class MagicaPhysicsManager : MagicaCloth.CreateSingleton`1
    {
        // Fields
        private MagicaCloth.UpdateTimeManager updateTime;  // 0x18
        private MagicaCloth.PhysicsManagerParticleData particle;  // 0x20
        private MagicaCloth.PhysicsManagerBoneData bone;  // 0x28
        private MagicaCloth.PhysicsManagerMeshData mesh;  // 0x30
        private MagicaCloth.PhysicsManagerTeamData team;  // 0x38
        private MagicaCloth.PhysicsManagerWindData wind;  // 0x40
        private MagicaCloth.PhysicsManagerComponent component;  // 0x48
        private MagicaCloth.PhysicsManagerCompute compute;  // 0x50
        private System.Boolean useFasterWrite;  // 0x58
        private UnityEngine.ComputeShader meshWriter;  // 0x60
        public MagicaCloth.PhysicsManagerPreUpdateEvent OnPreUpdate;  // 0x68
        public MagicaCloth.PhysicsManagerPostUpdateEvent OnPostUpdate;  // 0x70
        private System.Boolean useDelay;  // 0x78
        private System.Boolean updatePlayerLoop;  // 0x79
        private System.Boolean isActive;  // 0x7a

        // Properties
        MagicaCloth.UpdateTimeManager.UpdateCount UpdatePerSeccond { get; /* RVA: 0x04273240 */ set; /* RVA: 0x05F30838 */ }
        MagicaCloth.UpdateTimeManager.UpdateMode UpdateMode { get; /* RVA: 0x0896DB10 */ set; /* RVA: 0x0896DB5C */ }
        System.Single FuturePredictionRate { get; /* RVA: 0x04274B54 */ set; /* RVA: 0x0896DB2C */ }
        MagicaCloth.UpdateTimeManager UpdateTime { get; /* RVA: 0x01041090 */ }
        MagicaCloth.PhysicsManagerParticleData Particle { get; /* RVA: 0x03A46A50 */ }
        MagicaCloth.PhysicsManagerBoneData Bone { get; /* RVA: 0x02313050 */ }
        MagicaCloth.PhysicsManagerMeshData Mesh { get; /* RVA: 0x02313BD0 */ }
        MagicaCloth.PhysicsManagerTeamData Team { get; /* RVA: 0x02313C60 */ }
        MagicaCloth.PhysicsManagerWindData Wind { get; /* RVA: 0x03A46A20 */ }
        MagicaCloth.PhysicsManagerComponent Component { get; /* RVA: 0x02313080 */ }
        MagicaCloth.PhysicsManagerCompute Compute { get; /* RVA: 0x023141E0 */ }
        System.Boolean IsDelay { get; /* RVA: 0x03D4F800 */ }
        System.Boolean IsActive { get; /* RVA: 0x03D51AF0 */ set; /* RVA: 0x0896DB54 */ }
        System.Boolean IsFasterWrite { get; /* RVA: 0x0896D998 */ }
        UnityEngine.ComputeShader MeshWriterShader { get; /* RVA: 0x0896DA4C */ }

        // Methods
        // RVA: 0x0896D96C  token: 0x6000189
        public System.Void SetGlobalTimeScale(System.Single timeScale) { }
        // RVA: 0x04273220  token: 0x600018A
        public System.Single GetGlobalTimeScale() { }
        // RVA: 0x03D3DC20  token: 0x600019A
        protected virtual System.Void Awake() { }
        // RVA: 0x03A46940  token: 0x600019B
        protected virtual System.Void InitSingleton() { }
        // RVA: 0x0896D7C4  token: 0x600019C
        protected virtual System.Void DuplicateDetection(MagicaCloth.MagicaPhysicsManager duplicate) { }
        // RVA: 0x03D4D8B0  token: 0x600019D
        protected System.Void OnEnable() { }
        // RVA: 0x0896D938  token: 0x600019E
        protected System.Void OnDisable() { }
        // RVA: 0x032BAA90  token: 0x600019F
        private System.Void Update() { }
        // RVA: 0x0310B760  token: 0x60001A0
        private System.Void FixedUpdate() { }
        // RVA: 0x0896D830  token: 0x60001A1
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x02312BF0  token: 0x60001A2
        private System.Void AfterEarlyUpdate() { }
        // RVA: 0x023139B0  token: 0x60001A3
        private System.Void AfterFixedUpdate() { }
        // RVA: 0x02312C30  token: 0x60001A4
        private System.Void AfterUpdate() { }
        // RVA: 0x02312A50  token: 0x60001A5
        private System.Void BeforeLateUpdate() { }
        // RVA: 0x02312A80  token: 0x60001A6
        private System.Void AfterLateUpdate() { }
        // RVA: 0x02313CF0  token: 0x60001A7
        private System.Void DefaultUpdate() { }
        // RVA: 0x02312AE0  token: 0x60001A8
        private System.Void PostLateUpdate() { }
        // RVA: 0x02312AB0  token: 0x60001A9
        private System.Void AfterRendering() { }
        // RVA: 0x03D47740  token: 0x60001AA
        private static System.Void Init() { }
        // RVA: 0x032BAAC0  token: 0x60001AB
        public static System.Void InitCustomGameLoop() { }
        // RVA: 0x02D95DA0  token: 0x60001AC
        public static System.Void SetCustomGameLoop(UnityEngine.LowLevel.PlayerLoopSystem& playerLoop) { }
        // RVA: 0x02D94370  token: 0x60001AD
        private static System.Boolean CheckRegist(UnityEngine.LowLevel.PlayerLoopSystem& playerLoop) { }
        // RVA: 0x037707F0  token: 0x60001AE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000032  // size: 0x58
    public abstract class WindComponent : MagicaCloth.BaseComponent
    {
        // Fields
        protected System.Single main;  // 0x18
        protected System.Single turbulence;  // 0x1c
        protected System.Single frequency;  // 0x20
        protected UnityEngine.Vector3 areaSize;  // 0x24
        protected System.Single areaRadius;  // 0x30
        protected System.Single directionAngleX;  // 0x34
        protected System.Single directionAngleY;  // 0x38
        protected MagicaCloth.PhysicsManagerWindData.DirectionType directionType;  // 0x3c
        protected MagicaCloth.BezierParam attenuation;  // 0x40
        protected System.Int32 windId;  // 0x48
        protected MagicaCloth.RuntimeStatus status;  // 0x50

        // Properties
        System.Single Main { get; /* RVA: 0x03D4EBF0 */ set; /* RVA: 0x0896EFA0 */ }
        System.Single Turbulence { get; /* RVA: 0x03D4F110 */ set; /* RVA: 0x0896EFE0 */ }
        System.Single Frequency { get; /* RVA: 0x03D4F2E0 */ set; /* RVA: 0x0896EEC0 */ }
        UnityEngine.Vector3 MainDirection { get; /* RVA: 0x0896ECEC */ set; /* RVA: 0x0896EEEC */ }
        System.Single DirectionAngleX { get; /* RVA: 0x03D56CA0 */ set; /* RVA: 0x0896EE58 */ }
        System.Single DirectionAngleY { get; /* RVA: 0x03D51000 */ set; /* RVA: 0x0896EE7C */ }
        UnityEngine.Vector3 AreaSize { get; /* RVA: 0x03D59780 */ set; /* RVA: 0x0896EDA4 */ }
        System.Single AreaRadius { get; /* RVA: 0x03D4F5D0 */ set; /* RVA: 0x0896ED70 */ }
        MagicaCloth.PhysicsManagerWindData.DirectionType DirectionType { get; /* RVA: 0x03D4ED90 */ set; /* RVA: 0x0896EEA0 */ }
        MagicaCloth.RuntimeStatus Status { get; /* RVA: 0x03D4EAF0 */ }

        // Methods
        // RVA: 0x0896EB5C  token: 0x60001D7
        public System.Void SetAttenuation(System.Single sval, System.Single eval, System.Boolean useEval, System.Single cval, System.Boolean useCval) { }
        // RVA: 0x0896EB4C  token: 0x60001D9
        protected virtual System.Void Reset() { }
        // RVA: 0x0896E9E8  token: 0x60001DA
        protected virtual System.Void OnValidate() { }
        // RVA: 0x0896E860  token: 0x60001DB
        private System.Void OnDidApplyAnimationProperties() { }
        // RVA: 0x0896EBA4  token: 0x60001DC
        protected virtual System.Void Start() { }
        // RVA: 0x0896E908  token: 0x60001DD
        private virtual System.Void OnEnable() { }
        // RVA: 0x0896E890  token: 0x60001DE
        private virtual System.Void OnDisable() { }
        // RVA: 0x0896E834  token: 0x60001DF
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x0896EBAC  token: 0x60001E0
        protected virtual System.Void Update() { }
        // RVA: 0x0896E6E0  token: 0x60001E1
        private System.Void Init() { }
        // RVA: 0x0896E97C  token: 0x60001E2
        protected System.Void OnUpdateStatus() { }
        // RVA: 0x0232EB60  token: 0x60001E3
        private virtual System.Boolean VerifyData() { }
        // RVA: 0x0896E93C  token: 0x60001E4
        protected virtual System.Void OnInit() { }
        // RVA: 0x0896E8BC  token: 0x60001E5
        protected virtual System.Void OnDispose() { }
        // RVA: 0x0896E9B8  token: 0x60001E6
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x0896E82C  token: 0x60001E7
        protected virtual System.Void OnActive() { }
        // RVA: 0x0896E934  token: 0x60001E8
        protected virtual System.Void OnInactive() { }
        // RVA: 0x0896E5D8  token: 0x60001E9
        protected System.Void EnableWind() { }
        // RVA: 0x0896E52C  token: 0x60001EA
        protected System.Void DisableWind() { }
        // RVA: 0x0896EAC4  token: 0x60001EB
        private System.Void RemoveWind() { }
        // RVA: 0x0896E304  token: 0x60001EC
        private System.Void CreateWind() { }
        // RVA: 0x0896E668  token: 0x60001ED
        private UnityEngine.Vector3 GetLocalDirection() { }
        // RVA: 0x0896E11C  token: 0x60001EE
        private System.Void ChangeParameter() { }
        // RVA: -1  // abstract  token: 0x60001EF
        public virtual MagicaCloth.PhysicsManagerWindData.WindType GetWindType() { }
        // RVA: -1  // abstract  token: 0x60001F0
        public virtual MagicaCloth.PhysicsManagerWindData.ShapeType GetShapeType() { }
        // RVA: -1  // abstract  token: 0x60001F1
        public virtual MagicaCloth.PhysicsManagerWindData.DirectionType GetDirectionType() { }
        // RVA: -1  // abstract  token: 0x60001F2
        public virtual System.Boolean IsAddition() { }
        // RVA: -1  // abstract  token: 0x60001F3
        public virtual UnityEngine.Vector3 GetAreaSize() { }
        // RVA: -1  // abstract  token: 0x60001F4
        public virtual System.Single GetAreaVolume() { }
        // RVA: -1  // abstract  token: 0x60001F5
        public virtual System.Single GetAreaLength() { }
        // RVA: -1  // abstract  token: 0x60001F6
        protected virtual System.Void ResetParams() { }
        // RVA: 0x0896EC10  token: 0x60001F7
        protected System.Void .ctor() { }
        // RVA: 0x0339AE90  token: 0x60001F8
        private System.Object <Init>b__49_0() { }

    }

    // TypeToken: 0x2000033  // size: 0x18
    public abstract class MagicaAvatarAccess : System.IDisposable
    {
        // Fields
        protected MagicaCloth.MagicaAvatar owner;  // 0x10

        // Properties
        MagicaCloth.MagicaAvatarRuntime Runtime { get; /* RVA: 0x0896A1FC */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x60001FA
        public System.Void SetParent(MagicaCloth.MagicaAvatar avatar) { }
        // RVA: -1  // abstract  token: 0x60001FB
        public virtual System.Void Create() { }
        // RVA: -1  // abstract  token: 0x60001FC
        public virtual System.Void Dispose() { }
        // RVA: -1  // abstract  token: 0x60001FD
        public virtual System.Void Active() { }
        // RVA: -1  // abstract  token: 0x60001FE
        public virtual System.Void Inactive() { }
        // RVA: 0x0350B670  token: 0x60001FF
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000034  // size: 0x30
    public class MagicaAvatarParts : MagicaCloth.BaseComponent, MagicaCloth.IDataVerify
    {
        // Fields
        private MagicaCloth.MagicaAvatar parentAvatar;  // 0x18
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> boneDict;  // 0x20
        private System.Collections.Generic.List<MagicaCloth.CoreComponent> magicaComponentList;  // 0x28

        // Properties
        MagicaCloth.MagicaAvatar ParentAvatar { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.Boolean HasParent { get; /* RVA: 0x0896ACD4 */ }
        System.Int32 PartsId { get; /* RVA: 0x0896AD24 */ }

        // Methods
        // RVA: 0x03D6DFA0  token: 0x6000200
        public virtual MagicaCloth.ComponentType GetComponentType() { }
        // RVA: 0x0896ABE4  token: 0x6000205
        private System.Void OnDestroy() { }
        // RVA: 0x0896A434  token: 0x6000206
        public System.Void Dispose() { }
        // RVA: 0x0896A21C  token: 0x6000207
        public System.Collections.Generic.List<UnityEngine.Transform> CheckOverlappingTransform() { }
        // RVA: 0x0896A4C0  token: 0x6000208
        public System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> GetBoneDict() { }
        // RVA: 0x0896AB38  token: 0x6000209
        public System.Collections.Generic.List<MagicaCloth.CoreComponent> GetMagicaComponentList() { }
        // RVA: 0x01168950  token: 0x600020A
        public virtual System.Int32 GetVersion() { }
        // RVA: 0x0896A3E8  token: 0x600020B
        public virtual System.Void CreateVerifyData() { }
        // RVA: 0x0896ABEC  token: 0x600020C
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x0896A680  token: 0x600020D
        public virtual System.String GetInformation() { }
        // RVA: 0x0896AC54  token: 0x600020E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000035  // size: 0x38
    public class MagicaAvatarRuntime : MagicaCloth.MagicaAvatarAccess
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> boneDict;  // 0x18
        private System.Collections.Generic.Dictionary<UnityEngine.Transform,System.Int32> boneReferenceDict;  // 0x20
        private System.Collections.Generic.List<MagicaCloth.MagicaAvatarParts> avatarPartsList;  // 0x28
        private System.Collections.Generic.List<MagicaCloth.ColliderComponent> colliderList;  // 0x30

        // Properties
        System.Int32 AvatarPartsCount { get; /* RVA: 0x0896CD5C */ }

        // Methods
        // RVA: 0x0896C070  token: 0x600020F
        public virtual System.Void Create() { }
        // RVA: 0x0350B670  token: 0x6000210
        public virtual System.Void Dispose() { }
        // RVA: 0x0350B670  token: 0x6000211
        public virtual System.Void Active() { }
        // RVA: 0x0350B670  token: 0x6000212
        public virtual System.Void Inactive() { }
        // RVA: 0x0896C090  token: 0x6000214
        public MagicaCloth.MagicaAvatarParts GetAvatarParts(System.Int32 index) { }
        // RVA: 0x0896BE50  token: 0x6000215
        private System.Void CreateBoneDict() { }
        // RVA: 0x0896BFF8  token: 0x6000216
        private System.Void CreateColliderList() { }
        // RVA: 0x0896C0E4  token: 0x6000217
        public System.Int32 GetColliderCount() { }
        // RVA: 0x0896BC74  token: 0x6000218
        public System.Collections.Generic.List<UnityEngine.Transform> CheckOverlappingTransform() { }
        // RVA: 0x0896AD2C  token: 0x6000219
        public System.Int32 AddAvatarParts(MagicaCloth.MagicaAvatarParts parts) { }
        // RVA: 0x0896B9A8  token: 0x600021A
        private System.Void AddBone(UnityEngine.Transform root, UnityEngine.Transform croot, UnityEngine.Transform bone) { }
        // RVA: 0x0896CB10  token: 0x600021B
        private System.Void ReplaceSkinMeshRenderer(UnityEngine.SkinnedMeshRenderer skinRenderer, System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform> boneReplaceDict) { }
        // RVA: 0x0896CABC  token: 0x600021C
        private System.Void ReplaceMagicaComponent(MagicaCloth.CoreComponent comp, System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform> boneReplaceDict) { }
        // RVA: 0x0896C150  token: 0x600021D
        public System.Void RemoveAvatarParts(MagicaCloth.MagicaAvatarParts parts) { }
        // RVA: 0x0896C9E0  token: 0x600021E
        public System.Void RemoveAvatarParts(System.Int32 partsId) { }
        // RVA: 0x0896CC04  token: 0x600021F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000037  // size: 0x28
    public class BoneClothTarget : MagicaCloth.IDataHash, MagicaCloth.IBoneReplace
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Transform> rootList;  // 0x10
        private MagicaCloth.BoneClothTarget.ConnectionMode connection;  // 0x18
        private System.Single sameSurfaceAngle;  // 0x1c
        private System.Int32[] parentIndexList;  // 0x20

        // Properties
        System.Int32 RootCount { get; /* RVA: 0x0895BD4C */ }
        MagicaCloth.BoneClothTarget.ConnectionMode Connection { get; /* RVA: 0x020D1AC0 */ }
        System.Single SameSurfaceAngle { get; /* RVA: 0x03D4F110 */ }
        System.Boolean IsMeshConnection { get; /* RVA: 0x0895BD34 */ }

        // Methods
        // RVA: 0x0895B9B8  token: 0x6000222
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x0895BA48  token: 0x6000224
        public UnityEngine.Transform GetRoot(System.Int32 index) { }
        // RVA: 0x0895B9F4  token: 0x6000225
        public System.Int32 GetRootIndex(UnityEngine.Transform root) { }
        // RVA: 0x0895B4BC  token: 0x6000226
        public System.Void AddParentTransform() { }
        // RVA: 0x0895BB28  token: 0x6000227
        public System.Void RemoveParentTransform() { }
        // RVA: 0x0895BC04  token: 0x6000228
        public System.Void ResetFuturePredictionParentTransform() { }
        // RVA: 0x0895B8F8  token: 0x6000229
        public System.Void ChangeUnityPhysicsCount(System.Boolean sw) { }
        // RVA: -1  // generic def  token: 0x600022D
        public virtual System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        // RVA: 0x0895BAB4  token: 0x600022E
        public virtual System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        // RVA: 0x0895BCB4  token: 0x600022F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000039  // size: 0x1A8
    public class ClothData : MagicaCloth.ShareDataObject
    {
        // Fields
        private static System.Int32 DATA_VERSION;  // const
        public static System.UInt32 VertexFlag_End;  // const
        public static System.UInt32 VertexFlag_TriangleRotation;  // const
        public MagicaCloth.ClothParams.Algorithm triangleBendAlgorithm;  // 0x20
        public MagicaCloth.ClothParams.Algorithm restoreRotationAlgorithm;  // 0x24
        public MagicaCloth.ClothParams.Algorithm clampRotationAlgorithm;  // 0x28
        public System.Collections.Generic.List<System.Int32> useVertexList;  // 0x30
        public System.Collections.Generic.List<System.Int32> selectionData;  // 0x38
        public System.UInt32 maxLevel;  // 0x40
        public System.Collections.Generic.List<System.UInt32> vertexFlagLevelList;  // 0x48
        public System.Collections.Generic.List<System.Single> vertexDepthList;  // 0x50
        public System.Collections.Generic.List<System.Int32> rootList;  // 0x58
        public System.Collections.Generic.List<System.Int32> parentList;  // 0x60
        public MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[] structDistanceDataList;  // 0x68
        public MagicaCloth.ReferenceDataIndex[] structDistanceReferenceList;  // 0x70
        public MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[] bendDistanceDataList;  // 0x78
        public MagicaCloth.ReferenceDataIndex[] bendDistanceReferenceList;  // 0x80
        public MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[] nearDistanceDataList;  // 0x88
        public MagicaCloth.ReferenceDataIndex[] nearDistanceReferenceList;  // 0x90
        public MagicaCloth.ClampDistanceConstraint.ClampDistanceData[] rootDistanceDataList;  // 0x98
        public MagicaCloth.ReferenceDataIndex[] rootDistanceReferenceList;  // 0xa0
        public MagicaCloth.ClampDistance2Constraint.ClampDistance2Data[] clampDistance2DataList;  // 0xa8
        public MagicaCloth.ClampDistance2Constraint.ClampDistance2RootInfo[] clampDistance2RootInfoList;  // 0xb0
        public MagicaCloth.RestoreRotationConstraint.RotationData[] restoreRotationDataList;  // 0xb8
        public MagicaCloth.ReferenceDataIndex[] restoreRotationReferenceList;  // 0xc0
        public MagicaCloth.ClampRotationConstraint.ClampRotationData[] clampRotationDataList;  // 0xc8
        public MagicaCloth.ClampRotationConstraint.ClampRotationRootInfo[] clampRotationRootInfoList;  // 0xd0
        public MagicaCloth.CompositeRotationConstraint.RotationData[] compositeRotationDataList;  // 0xd8
        public MagicaCloth.CompositeRotationConstraint.RootInfo[] compositeRotationRootInfoList;  // 0xe0
        public MagicaCloth.TwistConstraint.TwistData[] twistDataList;  // 0xe8
        public MagicaCloth.ReferenceDataIndex[] twistReferenceList;  // 0xf0
        public MagicaCloth.AdjustRotationWorker.AdjustRotationData[] adjustRotationDataList;  // 0xf8
        public MagicaCloth.TriangleBendConstraint.TriangleBendData[] triangleBendDataList;  // 0x100
        public MagicaCloth.ReferenceDataIndex[] triangleBendReferenceList;  // 0x108
        public System.Int32 triangleBendWriteBufferCount;  // 0x110
        public MagicaCloth.VolumeConstraint.VolumeData[] volumeDataList;  // 0x118
        public MagicaCloth.ReferenceDataIndex[] volumeReferenceList;  // 0x120
        public System.Int32 volumeWriteBufferCount;  // 0x128
        public MagicaCloth.LineWorker.LineRotationData[] lineRotationDataList;  // 0x130
        public MagicaCloth.LineWorker.LineRotationRootInfo[] lineRotationRootInfoList;  // 0x138
        public MagicaCloth.TriangleWorker.TriangleRotationData[] triangleRotationDataList;  // 0x140
        public System.Int32[] triangleRotationIndexList;  // 0x148
        public MagicaCloth.EdgeCollisionConstraint.EdgeCollisionData[] edgeCollisionDataList;  // 0x150
        public MagicaCloth.ReferenceDataIndex[] edgeCollisionReferenceList;  // 0x158
        public System.Int32 edgeCollisionWriteBufferCount;  // 0x160
        public MagicaCloth.PenetrationConstraint.PenetrationData[] penetrationDataList;  // 0x168
        public MagicaCloth.ReferenceDataIndex[] penetrationReferenceList;  // 0x170
        public Unity.Mathematics.float3[] penetrationDirectionDataList;  // 0x178
        public MagicaCloth.ClothParams.PenetrationMode penetrationMode;  // 0x180
        public MagicaCloth.BaseSkinningWorker.BaseSkinningData[] baseSkinningDataList;  // 0x188
        public Unity.Mathematics.float4x4[] baseSkinningBindPoseList;  // 0x190
        public UnityEngine.Vector3 initScale;  // 0x198

        // Properties
        System.Int32 VertexUseCount { get; /* RVA: 0x08967C70 */ }
        System.Int32 StructDistanceConstraintCount { get; /* RVA: 0x08967C14 */ }
        System.Int32 BendDistanceConstraintCount { get; /* RVA: 0x08967AF0 */ }
        System.Int32 NearDistanceConstraintCount { get; /* RVA: 0x08967BAC */ }
        System.Int32 ClampDistanceConstraintCount { get; /* RVA: 0x08967B1C */ }
        System.Int32 ClampDistance2ConstraintCount { get; /* RVA: 0x08967B04 */ }
        System.Int32 RestoreRotationConstraintCount { get; /* RVA: 0x08967BFC */ }
        System.Int32 ClampRotationConstraintDataCount { get; /* RVA: 0x08967B34 */ }
        System.Int32 ClampRotationConstraintRootCount { get; /* RVA: 0x08967B4C */ }
        System.Int32 AdjustRotationConstraintCount { get; /* RVA: 0x08967AC0 */ }
        System.Int32 CompositeRotationCount { get; /* RVA: 0x08967B64 */ }
        System.Int32 TwistConstraintCount { get; /* RVA: 0x08967C58 */ }
        System.Int32 TriangleBendConstraintCount { get; /* RVA: 0x08967C28 */ }
        System.Int32 EdgeCollisionConstraintCount { get; /* RVA: 0x08967B7C */ }
        System.Int32 VolumeConstraintCount { get; /* RVA: 0x08967CB0 */ }
        System.Int32 LineRotationWorkerCount { get; /* RVA: 0x08967B94 */ }
        System.Int32 TriangleRotationWorkerCount { get; /* RVA: 0x08967C40 */ }
        System.Int32 PenetrationCount { get; /* RVA: 0x08967BC4 */ }
        System.Int32 BaseSkinningCount { get; /* RVA: 0x08967AD8 */ }

        // Methods
        // RVA: 0x08965068  token: 0x6000230
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x0896502C  token: 0x6000244
        public System.Int32 GetClampRotationCount() { }
        // RVA: 0x08965688  token: 0x6000245
        public System.Int32 GetRestoreRotationCount() { }
        // RVA: 0x08966FF4  token: 0x6000246
        public System.Boolean IsInvalidVertex(System.Int32 vindex) { }
        // RVA: 0x08966F30  token: 0x6000247
        public System.Boolean IsFixedVertex(System.Int32 vindex) { }
        // RVA: 0x0896705C  token: 0x6000248
        public System.Boolean IsMoveVertex(System.Int32 vindex) { }
        // RVA: 0x08966ED4  token: 0x6000249
        public System.Boolean IsExtendVertex(System.Int32 vindex) { }
        // RVA: 0x0896704C  token: 0x600024A
        public System.Boolean IsLastLevel(System.Int32 vindex) { }
        // RVA: 0x08966F8C  token: 0x600024B
        public System.Boolean IsFlag(System.Int32 vindex, System.UInt32 flag) { }
        // RVA: 0x0896762C  token: 0x600024C
        public System.Void SetFlag(System.Int32 vindex, System.UInt32 flag) { }
        // RVA: 0x08965518  token: 0x600024D
        public System.Int32 GetLevel(System.Int32 vindex) { }
        // RVA: 0x03D51100  token: 0x600024E
        public virtual System.Int32 GetVersion() { }
        // RVA: 0x08967830  token: 0x600024F
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x0896470C  token: 0x6000250
        public System.Void CreateData(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams clothParams, MagicaCloth.PhysicsTeamData teamData, MagicaCloth.MeshData meshData, MagicaCloth.IEditorMesh editMesh, System.Collections.Generic.List<System.Int32> selData, System.Action<System.Collections.Generic.List<System.Int32>,System.Collections.Generic.List<System.Int32>,System.Collections.Generic.List<UnityEngine.Vector3>,System.Collections.Generic.List<UnityEngine.Vector3>,System.Collections.Generic.List<UnityEngine.Vector3>,System.Collections.Generic.List<System.Int32>,System.Collections.Generic.List<System.Int32>> extensionAction) { }
        // RVA: 0x08964954  token: 0x6000251
        private System.Void CreateVertexData(System.Int32 vertexCount, System.Collections.Generic.List<System.Int32> lineList, System.Collections.Generic.List<System.Int32> triangleList) { }
        // RVA: 0x0895C498  token: 0x6000252
        private System.Void CreateConstraintData(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams clothParams, MagicaCloth.PhysicsTeamData teamData, System.Int32 vertexCount, System.Collections.Generic.List<UnityEngine.Vector3> wposList, System.Collections.Generic.List<UnityEngine.Vector3> wnorList, System.Collections.Generic.List<UnityEngine.Vector3> wtanList, System.Collections.Generic.List<System.Int32> lineList, System.Collections.Generic.List<System.Int32> triangleList) { }
        // RVA: 0x089670B8  token: 0x6000253
        private System.Void RegistTriangleBend(System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3, System.Collections.Generic.List<UnityEngine.Vector3> wposList, MagicaCloth.ClothParams clothParams, System.Collections.Generic.List<MagicaCloth.TriangleBendConstraint.TriangleBendData> triangleBendData) { }
        // RVA: 0x089676B0  token: 0x6000254
        private System.Collections.Generic.List<System.Int32> SortTetra(System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3, System.Collections.Generic.List<System.Single> meshVertexDepthList) { }
        // RVA: 0x0895C054  token: 0x6000255
        private System.Collections.Generic.List<System.Int32> CheckTetraDirection(System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3, System.Collections.Generic.HashSet<System.UInt64> trianglePackSet, System.Collections.Generic.List<System.Single> meshVertexDepthList) { }
        // RVA: 0x0895BD8C  token: 0x6000256
        private System.Boolean CalcTriangleBendRestAngle(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3, System.Single& restAngle) { }
        // RVA: 0x08965570  token: 0x6000257
        private System.Collections.Generic.List<System.Single> GetMeshVertexDepthList(System.Int32 vertexCount, System.Collections.Generic.List<System.Single> depthList) { }
        // RVA: 0x089656C4  token: 0x6000258
        private System.Collections.Generic.List<System.Int32> GetUseParentVertexList(System.Int32 vertexCount, System.Collections.Generic.List<System.Collections.Generic.HashSet<System.Int32>> vlink, System.Collections.Generic.List<UnityEngine.Vector3> wposList, System.Collections.Generic.List<System.Single> depthList) { }
        // RVA: 0x08966BF4  token: 0x6000259
        private System.Collections.Generic.List<System.Int32> GetUseRootVertexList(System.Collections.Generic.List<System.Int32> parentVertexList) { }
        // RVA: 0x08966CF0  token: 0x600025A
        private System.Collections.Generic.List<MagicaCloth.ClothData.VertexInfo> GetUseVertexInfoList(System.Collections.Generic.List<System.Int32> parentVertexList) { }
        // RVA: 0x089666F4  token: 0x600025B
        private System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> GetUseRootLineList(System.Collections.Generic.List<System.Int32> parentVertexList) { }
        // RVA: 0x08967910  token: 0x600025C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000042  // size: 0x228
    public class ClothParams
    {
        // Fields
        private MagicaCloth.ClothParams.Algorithm algorithm;  // 0x10
        private MagicaCloth.BezierParam radius;  // 0x18
        private MagicaCloth.BezierParam mass;  // 0x20
        private System.Boolean useGravity;  // 0x28
        private MagicaCloth.BezierParam gravity;  // 0x30
        private UnityEngine.Vector3 gravityDirection;  // 0x38
        private System.Boolean useDrag;  // 0x44
        private MagicaCloth.BezierParam drag;  // 0x48
        private System.Boolean useMaxVelocity;  // 0x50
        private MagicaCloth.BezierParam maxVelocity;  // 0x58
        private UnityEngine.Transform influenceTarget;  // 0x60
        private System.Single maxMoveSpeed;  // 0x68
        private System.Single maxRotationSpeed;  // 0x6c
        private MagicaCloth.BezierParam worldMoveInfluence;  // 0x70
        private MagicaCloth.BezierParam worldRotationInfluence;  // 0x78
        private System.Single massInfluence;  // 0x80
        private MagicaCloth.BezierParam depthInfluence;  // 0x88
        private System.Single windInfluence;  // 0x90
        private System.Single windRandomScale;  // 0x94
        private System.Single windSynchronization;  // 0x98
        private System.Boolean useDistanceDisable;  // 0x9c
        private UnityEngine.Transform disableReferenceObject;  // 0xa0
        private System.Single disableDistance;  // 0xa8
        private System.Single disableFadeDistance;  // 0xac
        private System.Boolean useResetTeleport;  // 0xb0
        private System.Single teleportDistance;  // 0xb4
        private System.Single teleportRotation;  // 0xb8
        private MagicaCloth.ClothParams.TeleportMode teleportMode;  // 0xbc
        private System.Single resetStabilizationTime;  // 0xc0
        private System.Boolean useClampDistanceRatio;  // 0xc4
        private System.Single clampDistanceMinRatio;  // 0xc8
        private System.Single clampDistanceMaxRatio;  // 0xcc
        private System.Single clampDistanceVelocityInfluence;  // 0xd0
        private System.Boolean useClampPositionLength;  // 0xd4
        private MagicaCloth.BezierParam clampPositionLength;  // 0xd8
        private System.Single clampPositionRatioX;  // 0xe0
        private System.Single clampPositionRatioY;  // 0xe4
        private System.Single clampPositionRatioZ;  // 0xe8
        private System.Single clampPositionVelocityInfluence;  // 0xec
        private System.Boolean useClampRotation;  // 0xf0
        private MagicaCloth.BezierParam clampRotationAngle;  // 0xf8
        private MagicaCloth.BezierParam clampRotationAngle2;  // 0x100
        private System.Single clampRotationVelocityLimit;  // 0x108
        private System.Single clampRotationVelocityInfluence;  // 0x10c
        private System.Single restoreDistanceVelocityInfluence;  // 0x110
        private MagicaCloth.BezierParam structDistanceStiffness;  // 0x118
        private System.Boolean useBendDistance;  // 0x120
        private System.Int32 bendDistanceMaxCount;  // 0x124
        private MagicaCloth.BezierParam bendDistanceStiffness;  // 0x128
        private System.Boolean useNearDistance;  // 0x130
        private System.Int32 nearDistanceMaxCount;  // 0x134
        private System.Single nearDistanceMaxDepth;  // 0x138
        private MagicaCloth.BezierParam nearDistanceLength;  // 0x140
        private MagicaCloth.BezierParam nearDistanceStiffness;  // 0x148
        private System.Boolean useRestoreRotation;  // 0x150
        private MagicaCloth.BezierParam restoreRotation;  // 0x158
        private MagicaCloth.BezierParam restoreRotation2;  // 0x160
        private System.Single restoreRotationVelocityInfluence;  // 0x168
        private System.Single restoreRotationVelocityInfluence2;  // 0x16c
        private System.Boolean useSpring;  // 0x170
        private System.Single springPower;  // 0x174
        private System.Single springRadius;  // 0x178
        private System.Single springScaleX;  // 0x17c
        private System.Single springScaleY;  // 0x180
        private System.Single springScaleZ;  // 0x184
        private System.Single springIntensity;  // 0x188
        private MagicaCloth.BezierParam springDirectionAtten;  // 0x190
        private MagicaCloth.BezierParam springDistanceAtten;  // 0x198
        private MagicaCloth.ClothParams.AdjustMode adjustMode;  // 0x1a0
        private System.Single adjustRotationPower;  // 0x1a4
        private System.Boolean useTriangleBend;  // 0x1a8
        private MagicaCloth.BezierParam triangleBend;  // 0x1b0
        private MagicaCloth.BezierParam triangleBend2;  // 0x1b8
        private System.Boolean useTwistCorrection;  // 0x1c0
        private System.Single twistRecoveryPower;  // 0x1c4
        private System.Boolean useVolume;  // 0x1c8
        private System.Single maxVolumeLength;  // 0x1cc
        private MagicaCloth.BezierParam volumeStretchStiffness;  // 0x1d0
        private MagicaCloth.BezierParam volumeShearStiffness;  // 0x1d8
        private System.Boolean useCollision;  // 0x1e0
        private System.Single friction;  // 0x1e4
        private System.Single staticFriction;  // 0x1e8
        private System.Boolean usePenetration;  // 0x1ec
        private MagicaCloth.ClothParams.PenetrationMode penetrationMode;  // 0x1f0
        private MagicaCloth.ClothParams.PenetrationAxis penetrationAxis;  // 0x1f4
        private System.Single penetrationMaxDepth;  // 0x1f8
        private MagicaCloth.BezierParam penetrationConnectDistance;  // 0x200
        private MagicaCloth.BezierParam penetrationDistance;  // 0x208
        private MagicaCloth.BezierParam penetrationRadius;  // 0x210
        private System.Boolean useLineAvarageRotation;  // 0x218
        private System.Boolean useFixedNonRotation;  // 0x219
        private System.Collections.Generic.HashSet<MagicaCloth.ClothParams.ParamType> changeSet;  // 0x220

        // Properties
        MagicaCloth.ClothParams.Algorithm AlgorithmType { get; /* RVA: 0x03D4E340 */ set; /* RVA: 0x010410F0 */ }
        System.Boolean UseGravity { get; /* RVA: 0x03D4ED50 */ }
        UnityEngine.Vector3 GravityDirection { get; /* RVA: 0x03D69690 */ set; /* RVA: 0x03D68D90 */ }
        System.Boolean UseDrag { get; /* RVA: 0x03D4F170 */ }
        System.Boolean UseMaxVelocity { get; /* RVA: 0x03D4F000 */ }
        System.Single MassInfluence { get; /* RVA: 0x03D51B00 */ set; /* RVA: 0x03D56E80 */ }
        System.Single WindInfluence { get; /* RVA: 0x03D58560 */ set; /* RVA: 0x03D5C110 */ }
        System.Single WindRandomScale { get; /* RVA: 0x03D58E90 */ set; /* RVA: 0x03D59120 */ }
        System.Single WindSynchronization { get; /* RVA: 0x03D57D90 */ set; /* RVA: 0x03D57DB0 */ }
        System.Single MaxMoveSpeed { get; /* RVA: 0x03D56A40 */ set; /* RVA: 0x03D59110 */ }
        System.Single MaxRotationSpeed { get; /* RVA: 0x03D56C50 */ set; /* RVA: 0x03D5B680 */ }
        System.Boolean UseResetTeleport { get; /* RVA: 0x01151530 */ set; /* RVA: 0x01151540 */ }
        System.Single TeleportDistance { get; /* RVA: 0x03D57F30 */ set; /* RVA: 0x03D57FB0 */ }
        System.Single TeleportRotation { get; /* RVA: 0x03D599C0 */ set; /* RVA: 0x03D50850 */ }
        MagicaCloth.ClothParams.TeleportMode TeleportResetMode { get; /* RVA: 0x03D57F20 */ set; /* RVA: 0x03D57FA0 */ }
        System.Single ResetStabilizationTime { get; /* RVA: 0x03D5D790 */ set; /* RVA: 0x03D5D7B0 */ }
        System.Boolean UseDistanceDisable { get; /* RVA: 0x03D5E1C0 */ set; /* RVA: 0x03D5E200 */ }
        UnityEngine.Transform DisableReferenceObject { get; /* RVA: 0x03D4EA80 */ set; /* RVA: 0x04270264 */ }
        System.Single DisableDistance { get; /* RVA: 0x03D58510 */ set; /* RVA: 0x03D6DF40 */ }
        System.Single DisableFadeDistance { get; /* RVA: 0x03D58380 */ set; /* RVA: 0x03D6DF50 */ }
        System.Boolean UseClampDistanceRatio { get; /* RVA: 0x03D57F00 */ }
        System.Single ClampDistanceMinRatio { get; /* RVA: 0x08969380 */ }
        System.Single ClampDistanceMaxRatio { get; /* RVA: 0x08969368 */ }
        System.Single ClampDistanceVelocityInfluence { get; /* RVA: 0x08969398 */ }
        System.Boolean UseClampPositionLength { get; /* RVA: 0x03D6D690 */ }
        UnityEngine.Vector3 ClampPositionAxisRatio { get; /* RVA: 0x03D6DEE0 */ }
        System.Single ClampPositionVelocityInfluence { get; /* RVA: 0x089693B4 */ }
        System.Boolean UseClampRotation { get; /* RVA: 0x03D57D50 */ }
        System.Single ClampRotationVelocityInfluence { get; /* RVA: 0x089693D0 */ }
        System.Single RestoreDistanceVelocityInfluence { get; /* RVA: 0x03D56EA0 */ }
        System.Boolean UseBendDistance { get; /* RVA: 0x03D57B30 */ }
        System.Int32 BendDistanceMaxCount { get; /* RVA: 0x03D6DED0 */ }
        System.Boolean UseNearDistance { get; /* RVA: 0x03D57B50 */ }
        System.Int32 NearDistanceMaxCount { get; /* RVA: 0x03D4FC40 */ }
        System.Single NearDistanceMaxDepth { get; /* RVA: 0x03D57590 */ }
        System.Boolean UseRestoreRotation { get; /* RVA: 0x03D56A80 */ }
        System.Boolean UseSpring { get; /* RVA: 0x03D57C60 */ set; /* RVA: 0x03D6DF80 */ }
        System.Single SpringPowr { get; /* RVA: 0x03D57CF0 */ set; /* RVA: 0x03D6DF60 */ }
        System.Single SpringRadius { get; /* RVA: 0x03D575D0 */ }
        UnityEngine.Vector3 SpringRadiusScale { get; /* RVA: 0x03D6DF00 */ }
        System.Single SpringIntensity { get; /* RVA: 0x03D58240 */ }
        MagicaCloth.ClothParams.AdjustMode AdjustRotationMode { get; /* RVA: 0x03D586D0 */ }
        UnityEngine.Vector3 AdjustRotationVector { get; /* RVA: 0x08969314 */ }
        System.Boolean UseTriangleBend { get; /* RVA: 0x03D58E80 */ }
        System.Single TwistRecoveryPower { get; /* RVA: 0x03D579D0 */ }
        System.Boolean UseVolume { get; /* RVA: 0x03D57C80 */ }
        System.Boolean UseCollision { get; /* RVA: 0x03D58E20 */ }
        System.Single DynamicFriction { get; /* RVA: 0x03D58CE0 */ }
        System.Single StaticFriction { get; /* RVA: 0x03D59990 */ }
        System.Boolean UsePenetration { get; /* RVA: 0x03D6DF30 */ set; /* RVA: 0x03D6DF70 */ }
        System.Single PenetrationMaxDepth { get; /* RVA: 0x03D58CC0 */ }
        System.Boolean UseLineAvarageRotation { get; /* RVA: 0x03D57B20 */ }
        System.Boolean UseFixedNonRotation { get; /* RVA: 0x03D6DF20 */ }

        // Methods
        // RVA: 0x08968668  token: 0x600026C
        public System.Void SetChangeParam(MagicaCloth.ClothParams.ParamType ptype) { }
        // RVA: 0x08967CC8  token: 0x600026D
        public System.Boolean ChangedParam(MagicaCloth.ClothParams.ParamType ptype) { }
        // RVA: 0x08967D20  token: 0x600026E
        public System.Void ClearChangeParam() { }
        // RVA: 0x08967F80  token: 0x600026F
        public System.Int32 GetParamHash(MagicaCloth.BaseCloth cloth, MagicaCloth.ClothParams.ParamType ptype) { }
        // RVA: 0x089688AC  token: 0x6000272
        public System.Void SetRadius(System.Single sval, System.Single eval) { }
        // RVA: 0x08968590  token: 0x6000273
        public System.Single GetRadius(System.Single depth) { }
        // RVA: 0x01041090  token: 0x6000274
        public MagicaCloth.BezierParam GetRadius() { }
        // RVA: 0x0896883C  token: 0x6000275
        public System.Void SetMass(System.Single sval, System.Single eval, System.Boolean useEval, System.Single cval, System.Boolean useCval) { }
        // RVA: 0x03D4EB40  token: 0x6000276
        public MagicaCloth.BezierParam GetMass() { }
        // RVA: 0x08968808  token: 0x6000277
        public System.Void SetGravity(System.Boolean sw, System.Single sval, System.Single eval) { }
        // RVA: 0x08967E9C  token: 0x6000279
        public MagicaCloth.BezierParam GetGravity() { }
        // RVA: 0x089687D4  token: 0x600027C
        public System.Void SetDrag(System.Boolean sw, System.Single sval, System.Single eval) { }
        // RVA: 0x08967E38  token: 0x600027E
        public MagicaCloth.BezierParam GetDrag() { }
        // RVA: 0x08968878  token: 0x600027F
        public System.Void SetMaxVelocity(System.Boolean sw, System.Single sval, System.Single eval) { }
        // RVA: 0x08967F00  token: 0x6000281
        public MagicaCloth.BezierParam GetMaxVelocity() { }
        // RVA: 0x03D6DE20  token: 0x6000282
        public System.Void SetExternalForce(System.Single massInfluence, System.Single windInfluence, System.Single windRandomScale, System.Single windSynchronization) { }
        // RVA: 0x03D4EA60  token: 0x6000285
        public MagicaCloth.BezierParam GetDepthInfluence() { }
        // RVA: 0x08968AB0  token: 0x600028C
        public System.Void SetWorldInfluence(System.Single maxspeed, System.Single moveval, System.Single rotval) { }
        // RVA: 0x03D4EB30  token: 0x600028D
        public MagicaCloth.BezierParam GetWorldMoveInfluence() { }
        // RVA: 0x03D4EB20  token: 0x600028E
        public MagicaCloth.BezierParam GetWorldRotationInfluence() { }
        // RVA: 0x03D4EB00  token: 0x600028F
        public UnityEngine.Transform GetInfluenceTarget() { }
        // RVA: 0x039274B0  token: 0x6000290
        public System.Void SetInfluenceTarget(UnityEngine.Transform t) { }
        // RVA: 0x03D6DEA0  token: 0x6000295
        public System.Void SetTeleport(System.Boolean sw, System.Single distance, System.Single rotation, MagicaCloth.ClothParams.TeleportMode mode) { }
        // RVA: 0x08968798  token: 0x60002A0
        public System.Void SetDistanceDisable(System.Boolean sw, System.Single distance, System.Single fadeDistance, UnityEngine.Transform referenceObject) { }
        // RVA: 0x03D6DDD0  token: 0x60002A9
        public System.Void SetClampDistanceRatio(System.Boolean sw, System.Single minval, System.Single maxval, System.Single influence) { }
        // RVA: 0x089686C0  token: 0x60002AE
        public System.Void SetClampPositionLength(System.Boolean sw, System.Single sval, System.Single eval, System.Single ratioX, System.Single ratioY, System.Single ratioZ, System.Single influence) { }
        // RVA: 0x03D4E7B0  token: 0x60002B1
        public MagicaCloth.BezierParam GetClampPositionLength() { }
        // RVA: 0x08968730  token: 0x60002B3
        public System.Void SetClampRotationAngle(System.Boolean sw, System.Single sval, System.Single eval, System.Single influence) { }
        // RVA: 0x08967DFC  token: 0x60002B5
        public MagicaCloth.BezierParam GetClampRotationAngle(MagicaCloth.ClothParams.Algorithm algo) { }
        // RVA: 0x08967E14  token: 0x60002B7
        public System.Single GetClampRotationVelocityLimit(MagicaCloth.ClothParams.Algorithm algo) { }
        // RVA: 0x089688E0  token: 0x60002B8
        public System.Void SetRestoreDistance(System.Single influence, System.Single structStiffness) { }
        // RVA: 0x03D571F0  token: 0x60002BA
        public MagicaCloth.BezierParam GetStructDistanceStiffness() { }
        // RVA: 0x03D56F00  token: 0x60002BD
        public MagicaCloth.BezierParam GetBendDistanceStiffness() { }
        // RVA: 0x03D57300  token: 0x60002C1
        public MagicaCloth.BezierParam GetNearDistanceLength() { }
        // RVA: 0x03D571B0  token: 0x60002C2
        public MagicaCloth.BezierParam GetNearDistanceStiffness() { }
        // RVA: 0x0896891C  token: 0x60002C3
        public System.Void SetRestoreRotation(System.Boolean sw, System.Single sval, System.Single eval, System.Single influence) { }
        // RVA: 0x089685B0  token: 0x60002C5
        public MagicaCloth.BezierParam GetRestoreRotationPower(MagicaCloth.ClothParams.Algorithm algo) { }
        // RVA: 0x089685C8  token: 0x60002C6
        public System.Single GetRestoreRotationVelocityInfluence(MagicaCloth.ClothParams.Algorithm algo) { }
        // RVA: 0x03D6DE50  token: 0x60002C7
        public System.Void SetSpring(System.Boolean sw, System.Single power, System.Single r, System.Single sclx, System.Single scly, System.Single sclz, System.Single intensity) { }
        // RVA: 0x0896898C  token: 0x60002C8
        public System.Void SetSpringDirectionAtten(System.Single sval, System.Single eval, System.Single cval) { }
        // RVA: 0x089689C0  token: 0x60002C9
        public System.Void SetSpringDistanceAtten(System.Single sval, System.Single eval, System.Single cval) { }
        // RVA: 0x08968628  token: 0x60002CC
        public System.Single GetSpringPower() { }
        // RVA: 0x089685E0  token: 0x60002D2
        public System.Single GetSpringDirectionAtten(System.Single ratio) { }
        // RVA: 0x08968604  token: 0x60002D3
        public System.Single GetSpringDistanceAtten(System.Single ratio) { }
        // RVA: 0x03D6DDC0  token: 0x60002D4
        public System.Void SetAdjustRotation(MagicaCloth.ClothParams.AdjustMode amode, System.Single power) { }
        // RVA: 0x089689F4  token: 0x60002D7
        public System.Void SetTriangleBend(System.Boolean sw, System.Single sval, System.Single eval) { }
        // RVA: 0x08968640  token: 0x60002D9
        public MagicaCloth.BezierParam GetTriangleBendStiffness(MagicaCloth.ClothParams.Algorithm algo) { }
        // RVA: 0x08968658  token: 0x60002DA
        private System.Boolean GetUseTwistCorrection(MagicaCloth.ClothParams.Algorithm algo) { }
        // RVA: 0x08968A4C  token: 0x60002DC
        public System.Void SetVolume(System.Boolean sw, System.Single maxLength, System.Single stiffness, System.Single shear) { }
        // RVA: 0x08967F68  token: 0x60002DE
        public System.Single GetMaxVolumeLength() { }
        // RVA: 0x03D57000  token: 0x60002DF
        public MagicaCloth.BezierParam GetVolumeStretchStiffness() { }
        // RVA: 0x03D50210  token: 0x60002E0
        public MagicaCloth.BezierParam GetVolumeShearStiffness() { }
        // RVA: 0x03D6DE00  token: 0x60002E1
        public System.Void SetCollision(System.Boolean sw, System.Single dynamicFriction, System.Single staticFriction) { }
        // RVA: 0x03D6D130  token: 0x60002E7
        public MagicaCloth.ClothParams.PenetrationMode GetPenetrationMode() { }
        // RVA: 0x03D6DDB0  token: 0x60002E8
        public MagicaCloth.ClothParams.PenetrationAxis GetPenetrationAxis() { }
        // RVA: 0x03D56BB0  token: 0x60002EA
        public MagicaCloth.BezierParam GetPenetrationConnectDistance() { }
        // RVA: 0x03D570C0  token: 0x60002EB
        public MagicaCloth.BezierParam GetPenetrationRadius() { }
        // RVA: 0x03D57190  token: 0x60002EC
        public MagicaCloth.BezierParam GetPenetrationDistance() { }
        // RVA: 0x08967D68  token: 0x60002EF
        public System.Void ConvertToLatestAlgorithmParameter() { }
        // RVA: 0x08968B00  token: 0x60002F0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000049  // size: 0x18
    public class ClothSetup
    {
        // Fields
        private System.Int32 teamBoneIndex;  // 0x10
        private System.Single distanceBlendRatio;  // 0x14

        // Properties
        System.Single DistanceBlendRatio { get; /* RVA: 0x03D51930 */ set; /* RVA: 0x03D51940 */ }

        // Methods
        // RVA: 0x08970600  token: 0x60002F1
        public System.Void ClothInit(MagicaCloth.PhysicsTeam team, MagicaCloth.MeshData meshData, MagicaCloth.ClothData clothData, MagicaCloth.ClothParams param, System.Func<System.Int32,System.UInt32> funcUserFlag) { }
        // RVA: 0x08970464  token: 0x60002F2
        public System.Void ClothDispose(MagicaCloth.PhysicsTeam team) { }
        // RVA: 0x08970314  token: 0x60002F3
        public System.Void ClothActive(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams param, MagicaCloth.ClothData clothData) { }
        // RVA: 0x089704F0  token: 0x60002F4
        public System.Void ClothInactive(MagicaCloth.PhysicsTeam team) { }
        // RVA: -1  // generic def  token: 0x60002F5
        private System.Void ReplaceBone(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams param, System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        // RVA: 0x08972600  token: 0x60002F6
        private System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams param) { }
        // RVA: 0x089702A8  token: 0x60002F7
        public System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        // RVA: 0x0896F690  token: 0x60002FA
        public System.Void ChangeData(MagicaCloth.PhysicsTeam team, MagicaCloth.ClothParams param, MagicaCloth.ClothData clothData) { }
        // RVA: 0x03D6E000  token: 0x60002FB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004B  // size: 0x100
    public class MagicaBoneCloth : MagicaCloth.BaseCloth
    {
        // Fields
        private static System.Int32 DATA_VERSION;  // const
        private static System.Int32 ERR_DATA_VERSION;  // const
        private MagicaCloth.MeshData meshData;  // 0xc8
        private System.Int32 meshDataHash;  // 0xd0
        private System.Int32 meshDataVersion;  // 0xd4
        private MagicaCloth.BoneClothTarget clothTarget;  // 0xd8
        private System.Collections.Generic.List<UnityEngine.Transform> useTransformList;  // 0xe0
        private System.Collections.Generic.List<UnityEngine.Vector3> useTransformPositionList;  // 0xe8
        private System.Collections.Generic.List<UnityEngine.Quaternion> useTransformRotationList;  // 0xf0
        private System.Collections.Generic.List<UnityEngine.Vector3> useTransformScaleList;  // 0xf8

        // Properties
        MagicaCloth.BoneClothTarget ClothTarget { get; /* RVA: 0x03D4E7B0 */ }
        MagicaCloth.MeshData MeshData { get; /* RVA: 0x03D4E7C0 */ }
        System.Int32 UseTransformCount { get; /* RVA: 0x08975560 */ }

        // Methods
        // RVA: 0x03D5A950  token: 0x6000300
        public virtual MagicaCloth.ComponentType GetComponentType() { }
        // RVA: 0x08972F38  token: 0x6000301
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x08974F50  token: 0x6000304
        protected virtual System.Void Reset() { }
        // RVA: 0x08974BE4  token: 0x6000305
        protected virtual System.Void OnValidate() { }
        // RVA: 0x08972D7C  token: 0x6000306
        protected virtual System.Void ClothInit() { }
        // RVA: 0x08972D58  token: 0x6000307
        protected virtual System.Void ClothDispose() { }
        // RVA: 0x08972D50  token: 0x6000308
        protected virtual System.Void ClothActive() { }
        // RVA: 0x08974F58  token: 0x6000309
        protected virtual System.UInt32 UserFlag(System.Int32 index) { }
        // RVA: 0x0897511C  token: 0x600030A
        protected virtual UnityEngine.Transform UserTransform(System.Int32 index) { }
        // RVA: 0x08974F8C  token: 0x600030B
        protected virtual Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex) { }
        // RVA: 0x0897505C  token: 0x600030C
        protected virtual Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex) { }
        // RVA: 0x01002730  token: 0x600030D
        public virtual MagicaCloth.BaseMeshDeformer GetDeformer() { }
        // RVA: 0x03D4E7C0  token: 0x600030E
        protected virtual MagicaCloth.MeshData GetMeshData() { }
        // RVA: 0x0350B670  token: 0x600030F
        protected virtual System.Void WorkerInit() { }
        // RVA: 0x0115F4C0  token: 0x6000310
        public virtual System.Boolean IsRequiresDeformer() { }
        // RVA: 0x0350B670  token: 0x6000311
        protected virtual System.Void SetDeformerUseVertex(System.Boolean sw, MagicaCloth.BaseMeshDeformer deformer) { }
        // RVA: 0x08972D08  token: 0x6000312
        protected virtual System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        // RVA: 0x08974ADC  token: 0x6000313
        protected virtual System.Void OnChangeCalculation() { }
        // RVA: 0x089746CC  token: 0x6000314
        public System.Collections.Generic.List<UnityEngine.Transform> GetTransformList() { }
        // RVA: 0x089749CC  token: 0x6000315
        private UnityEngine.Transform GetUseTransform(System.Int32 index) { }
        // RVA: 0x08974328  token: 0x6000317
        public System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Transform>>> GetTransformGrid(System.Int32& maxLevel) { }
        // RVA: 0x03D55AA0  token: 0x6000318
        public virtual System.Int32 GetVersion() { }
        // RVA: 0x03D555E0  token: 0x6000319
        public virtual System.Int32 GetErrorVersion() { }
        // RVA: 0x08972DB0  token: 0x600031A
        public virtual System.Void CreateVerifyData() { }
        // RVA: 0x08975124  token: 0x600031B
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x089735A4  token: 0x600031C
        public virtual System.String GetInformation() { }
        // RVA: -1  // generic def  token: 0x600031D
        public virtual System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        // RVA: 0x08974A50  token: 0x600031E
        public virtual System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        // RVA: 0x08973134  token: 0x600031F
        public virtual System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        // RVA: 0x089734C4  token: 0x6000320
        public virtual System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        // RVA: 0x08973054  token: 0x6000321
        public virtual System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        // RVA: 0x08974284  token: 0x6000322
        public virtual System.Collections.Generic.List<System.Int32> GetSelectionList() { }
        // RVA: 0x01002730  token: 0x6000323
        public virtual System.Collections.Generic.List<System.Int32> GetUseList() { }
        // RVA: 0x08972ED0  token: 0x6000324
        public virtual System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        // RVA: 0x08972DF8  token: 0x6000325
        public virtual MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        // RVA: 0x08974BEC  token: 0x6000326
        private System.Void ResetParams() { }
        // RVA: 0x089753C0  token: 0x6000327
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004C  // size: 0x100
    public class MagicaBoneSpring : MagicaCloth.BaseCloth
    {
        // Fields
        private static System.Int32 DATA_VERSION;  // const
        private static System.Int32 ERR_DATA_VERSION;  // const
        private MagicaCloth.MeshData meshData;  // 0xc8
        private System.Int32 meshDataHash;  // 0xd0
        private System.Int32 meshDataVersion;  // 0xd4
        private MagicaCloth.BoneClothTarget clothTarget;  // 0xd8
        private System.Collections.Generic.List<UnityEngine.Transform> useTransformList;  // 0xe0
        private System.Collections.Generic.List<UnityEngine.Vector3> useTransformPositionList;  // 0xe8
        private System.Collections.Generic.List<UnityEngine.Quaternion> useTransformRotationList;  // 0xf0
        private System.Collections.Generic.List<UnityEngine.Vector3> useTransformScaleList;  // 0xf8

        // Properties
        MagicaCloth.BoneClothTarget ClothTarget { get; /* RVA: 0x03D4E7B0 */ }
        MagicaCloth.MeshData MeshData { get; /* RVA: 0x03D4E7C0 */ }
        System.Int32 UseTransformCount { get; /* RVA: 0x08977394 */ }

        // Methods
        // RVA: 0x03D5A5F0  token: 0x6000328
        public virtual MagicaCloth.ComponentType GetComponentType() { }
        // RVA: 0x08975768  token: 0x6000329
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x08976D34  token: 0x600032C
        protected virtual System.Void Reset() { }
        // RVA: 0x08974BE4  token: 0x600032D
        protected virtual System.Void OnValidate() { }
        // RVA: 0x089755A0  token: 0x600032E
        protected virtual System.Void ClothInit() { }
        // RVA: 0x08972D58  token: 0x600032F
        protected virtual System.Void ClothDispose() { }
        // RVA: 0x08972D50  token: 0x6000330
        protected virtual System.Void ClothActive() { }
        // RVA: 0x08974F58  token: 0x6000331
        protected virtual System.UInt32 UserFlag(System.Int32 index) { }
        // RVA: 0x08976ECC  token: 0x6000332
        protected virtual UnityEngine.Transform UserTransform(System.Int32 index) { }
        // RVA: 0x08976D3C  token: 0x6000333
        protected virtual Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex) { }
        // RVA: 0x08976E0C  token: 0x6000334
        protected virtual Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex) { }
        // RVA: 0x0115F4C0  token: 0x6000335
        public virtual System.Boolean IsRequiresDeformer() { }
        // RVA: 0x01002730  token: 0x6000336
        public virtual MagicaCloth.BaseMeshDeformer GetDeformer() { }
        // RVA: 0x03D4E7C0  token: 0x6000337
        protected virtual MagicaCloth.MeshData GetMeshData() { }
        // RVA: 0x0350B670  token: 0x6000338
        protected virtual System.Void WorkerInit() { }
        // RVA: 0x0350B670  token: 0x6000339
        protected virtual System.Void SetDeformerUseVertex(System.Boolean sw, MagicaCloth.BaseMeshDeformer deformer) { }
        // RVA: 0x08972D08  token: 0x600033A
        protected virtual System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        // RVA: 0x089768C0  token: 0x600033B
        protected virtual System.Void OnChangeCalculation() { }
        // RVA: 0x089764B8  token: 0x600033C
        public System.Collections.Generic.List<UnityEngine.Transform> GetTransformList() { }
        // RVA: 0x089767B0  token: 0x600033D
        private UnityEngine.Transform GetUseTransform(System.Int32 index) { }
        // RVA: 0x03D55AA0  token: 0x600033F
        public virtual System.Int32 GetVersion() { }
        // RVA: 0x03D555E0  token: 0x6000340
        public virtual System.Int32 GetErrorVersion() { }
        // RVA: 0x08972DB0  token: 0x6000341
        public virtual System.Void CreateVerifyData() { }
        // RVA: 0x08976ED4  token: 0x6000342
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x08975DD4  token: 0x6000343
        public virtual System.String GetInformation() { }
        // RVA: -1  // generic def  token: 0x6000344
        public virtual System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        // RVA: 0x08976834  token: 0x6000345
        public virtual System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        // RVA: 0x08975964  token: 0x6000346
        public virtual System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        // RVA: 0x08975CF4  token: 0x6000347
        public virtual System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        // RVA: 0x08975884  token: 0x6000348
        public virtual System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        // RVA: 0x08976414  token: 0x6000349
        public virtual System.Collections.Generic.List<System.Int32> GetSelectionList() { }
        // RVA: 0x089765C8  token: 0x600034A
        public virtual System.Collections.Generic.List<System.Int32> GetUseList() { }
        // RVA: 0x08975700  token: 0x600034B
        public virtual System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        // RVA: 0x08975628  token: 0x600034C
        public virtual MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        // RVA: 0x089769C8  token: 0x600034D
        private System.Void ResetParams() { }
        // RVA: 0x089771F4  token: 0x600034E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004D  // size: 0xD8
    public class MagicaMeshCloth : MagicaCloth.BaseCloth
    {
        // Fields
        private static System.Int32 DATA_VERSION;  // const
        private static System.Int32 ERR_DATA_VERSION;  // const
        private MagicaCloth.MagicaVirtualDeformer virtualDeformer;  // 0xc8
        private System.Int32 virtualDeformerHash;  // 0xd0
        private System.Int32 virtualDeformerVersion;  // 0xd4

        // Properties
        MagicaCloth.VirtualMeshDeformer Deformer { get; /* RVA: 0x08978C2C */ }

        // Methods
        // RVA: 0x03D5A720  token: 0x600034F
        public virtual MagicaCloth.ComponentType GetComponentType() { }
        // RVA: 0x089775A0  token: 0x6000350
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x089788A8  token: 0x6000352
        protected virtual System.Void Reset() { }
        // RVA: 0x08974BE4  token: 0x6000353
        protected virtual System.Void OnValidate() { }
        // RVA: 0x08978540  token: 0x6000354
        protected virtual System.Void OnInit() { }
        // RVA: 0x08978528  token: 0x6000355
        protected virtual System.Void OnActive() { }
        // RVA: 0x08978538  token: 0x6000356
        protected virtual System.Void OnInactive() { }
        // RVA: 0x08978530  token: 0x6000357
        protected virtual System.Void OnDispose() { }
        // RVA: 0x01002730  token: 0x6000358
        protected virtual System.UInt32 UserFlag(System.Int32 index) { }
        // RVA: 0x01002730  token: 0x6000359
        protected virtual UnityEngine.Transform UserTransform(System.Int32 index) { }
        // RVA: 0x03D6E010  token: 0x600035A
        protected virtual Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex) { }
        // RVA: 0x0897899C  token: 0x600035B
        protected virtual Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex) { }
        // RVA: 0x0232EB60  token: 0x600035C
        public virtual System.Boolean IsRequiresDeformer() { }
        // RVA: 0x089775E0  token: 0x600035D
        public virtual MagicaCloth.BaseMeshDeformer GetDeformer() { }
        // RVA: 0x08978188  token: 0x600035E
        protected virtual MagicaCloth.MeshData GetMeshData() { }
        // RVA: 0x08978ACC  token: 0x600035F
        protected virtual System.Void WorkerInit() { }
        // RVA: 0x089788B0  token: 0x6000360
        protected virtual System.Void SetDeformerUseVertex(System.Boolean sw, MagicaCloth.BaseMeshDeformer deformer) { }
        // RVA: 0x089773D4  token: 0x6000361
        protected virtual System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        // RVA: 0x03D55AA0  token: 0x6000362
        public virtual System.Int32 GetVersion() { }
        // RVA: 0x03D555E0  token: 0x6000363
        public virtual System.Int32 GetErrorVersion() { }
        // RVA: 0x08972DB0  token: 0x6000364
        public virtual System.Void CreateVerifyData() { }
        // RVA: 0x089789E0  token: 0x6000365
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x08977684  token: 0x6000366
        public virtual System.String GetInformation() { }
        // RVA: 0x0897848C  token: 0x6000367
        public System.Boolean IsValidPointSelect() { }
        // RVA: 0x08977610  token: 0x6000368
        public virtual System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        // RVA: 0x0897765C  token: 0x6000369
        public virtual System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        // RVA: 0x089775E8  token: 0x600036A
        public virtual System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        // RVA: 0x089781A8  token: 0x600036B
        public virtual System.Collections.Generic.List<System.Int32> GetSelectionList() { }
        // RVA: 0x089782BC  token: 0x600036C
        public virtual System.Collections.Generic.List<System.Int32> GetUseList() { }
        // RVA: 0x08977520  token: 0x600036D
        public virtual System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        // RVA: 0x08977410  token: 0x600036E
        public virtual MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        // RVA: 0x08978548  token: 0x600036F
        private System.Void ResetParams() { }
        // RVA: 0x08978C24  token: 0x6000370
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200004E  // size: 0xF8
    public class MagicaMeshSpring : MagicaCloth.BaseCloth
    {
        // Fields
        private static System.Int32 DATA_VERSION;  // const
        private static System.Int32 ERR_DATA_VERSION;  // const
        private MagicaCloth.MagicaVirtualDeformer virtualDeformer;  // 0xc8
        private System.Int32 virtualDeformerHash;  // 0xd0
        private System.Int32 virtualDeformerVersion;  // 0xd4
        private UnityEngine.Transform centerTransform;  // 0xd8
        private MagicaCloth.MagicaMeshSpring.Axis directionAxis;  // 0xe0
        private MagicaCloth.SpringData springData;  // 0xe8
        private System.Int32 springDataHash;  // 0xf0
        private System.Int32 springDataVersion;  // 0xf4

        // Properties
        MagicaCloth.VirtualMeshDeformer Deformer { get; /* RVA: 0x0897A204 */ }
        MagicaCloth.SpringData SpringData { get; /* RVA: 0x03D50EA0 */ }
        System.Int32 UseVertexCount { get; /* RVA: 0x0897A27C */ }
        UnityEngine.Transform CenterTransform { get; /* RVA: 0x03D4E7B0 */ set; /* RVA: 0x05142FC4 */ }
        MagicaCloth.MagicaMeshSpring.Axis DirectionAxis { get; /* RVA: 0x03D50ED0 */ set; /* RVA: 0x03D50FB0 */ }
        UnityEngine.Vector3 CenterTransformDirection { get; /* RVA: 0x0897A070 */ }

        // Methods
        // RVA: 0x03D6E030  token: 0x6000371
        public virtual MagicaCloth.ComponentType GetComponentType() { }
        // RVA: 0x08979030  token: 0x6000372
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x089790B0  token: 0x600037B
        public MagicaCloth.SpringData.DeformerData GetDeformerData() { }
        // RVA: 0x08979C24  token: 0x600037C
        protected virtual System.Void Reset() { }
        // RVA: 0x08974BE4  token: 0x600037D
        protected virtual System.Void OnValidate() { }
        // RVA: 0x08978CA4  token: 0x600037E
        protected virtual System.Void ClothInit() { }
        // RVA: 0x08972D50  token: 0x600037F
        protected virtual System.Void ClothActive() { }
        // RVA: 0x03D6E040  token: 0x6000380
        protected virtual System.UInt32 UserFlag(System.Int32 index) { }
        // RVA: 0x03D4E7B0  token: 0x6000381
        protected virtual UnityEngine.Transform UserTransform(System.Int32 index) { }
        // RVA: 0x08979CD0  token: 0x6000382
        protected virtual Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex) { }
        // RVA: 0x08979D34  token: 0x6000383
        protected virtual Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex) { }
        // RVA: 0x0232EB60  token: 0x6000384
        public virtual System.Boolean IsRequiresDeformer() { }
        // RVA: 0x089790D0  token: 0x6000385
        public virtual MagicaCloth.BaseMeshDeformer GetDeformer() { }
        // RVA: 0x01002730  token: 0x6000386
        protected virtual MagicaCloth.MeshData GetMeshData() { }
        // RVA: 0x08979EF4  token: 0x6000387
        protected virtual System.Void WorkerInit() { }
        // RVA: 0x08979C2C  token: 0x6000388
        protected virtual System.Void SetDeformerUseVertex(System.Boolean sw, MagicaCloth.BaseMeshDeformer deformer) { }
        // RVA: 0x089773D4  token: 0x6000389
        protected virtual System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        // RVA: 0x089797D8  token: 0x600038A
        protected virtual System.Void OnChangeCalculation() { }
        // RVA: 0x03D55AA0  token: 0x600038B
        public virtual System.Int32 GetVersion() { }
        // RVA: 0x03D555E0  token: 0x600038C
        public virtual System.Int32 GetErrorVersion() { }
        // RVA: 0x08978E80  token: 0x600038D
        public virtual System.Void CreateVerifyData() { }
        // RVA: 0x08979D88  token: 0x600038E
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x08979348  token: 0x600038F
        public virtual System.String GetInformation() { }
        // RVA: 0x0350B670  token: 0x6000390
        public System.Void VerifyDeformer() { }
        // RVA: -1  // generic def  token: 0x6000391
        public virtual System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        // RVA: 0x08979770  token: 0x6000392
        public virtual System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        // RVA: 0x08979144  token: 0x6000393
        public virtual System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        // RVA: 0x01002730  token: 0x6000394
        public virtual System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        // RVA: 0x01002730  token: 0x6000395
        public virtual System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        // RVA: 0x01002730  token: 0x6000396
        public virtual System.Collections.Generic.List<System.Int32> GetSelectionList() { }
        // RVA: 0x01002730  token: 0x6000397
        public virtual System.Collections.Generic.List<System.Int32> GetUseList() { }
        // RVA: 0x08978FC8  token: 0x6000398
        public virtual System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        // RVA: 0x08978EF0  token: 0x6000399
        public virtual MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        // RVA: 0x0897986C  token: 0x600039A
        private System.Void ResetParams() { }
        // RVA: 0x08978C24  token: 0x600039B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000050  // size: 0x28
    public class SelectionData : MagicaCloth.ShareDataObject
    {
        // Fields
        private static System.Int32 DATA_VERSION;  // const
        public static System.Int32 Invalid;  // const
        public static System.Int32 Move;  // const
        public static System.Int32 Fixed;  // const
        public static System.Int32 Extend;  // const
        public System.Collections.Generic.List<MagicaCloth.SelectionData.DeformerSelection> selectionList;  // 0x20

        // Properties
        System.Int32 DeformerCount { get; /* RVA: 0x08980098 */ }

        // Methods
        // RVA: 0x0897EFB4  token: 0x600039D
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x02102C70  token: 0x600039E
        public virtual System.Int32 GetVersion() { }
        // RVA: 0x0897FFC0  token: 0x600039F
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x0897EED8  token: 0x60003A0
        public System.Boolean Compare(MagicaCloth.SelectionData sel) { }
        // RVA: 0x0897EFF0  token: 0x60003A1
        public System.Collections.Generic.List<System.Int32> GetSelectionData(MagicaCloth.MeshData meshData, System.Collections.Generic.List<MagicaCloth.MeshData> childMeshDataList) { }
        // RVA: 0x0897F408  token: 0x60003A2
        private System.Int32 GetSelection(MagicaCloth.MeshData meshData, System.Int32 vindex, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.UInt32>> dict, System.Collections.Generic.List<MagicaCloth.MeshData> childMeshDataList, System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.UInt64,System.Int32>> hashList) { }
        // RVA: 0x0897F8D4  token: 0x60003A3
        public System.Void SetSelectionData(MagicaCloth.MeshData meshData, System.Collections.Generic.List<System.Int32> selects, System.Collections.Generic.List<MagicaCloth.MeshData> childMeshDataList) { }
        // RVA: 0x0897F1A8  token: 0x60003A4
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.UInt64,System.Int32>> GetSelectionVertexHashList() { }
        // RVA: 0x08980018  token: 0x60003A5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000052  // size: 0x38
    public class SpringData : MagicaCloth.ShareDataObject
    {
        // Fields
        private static System.Int32 DATA_VERSION;  // const
        public MagicaCloth.SpringData.DeformerData deformerData;  // 0x20
        public UnityEngine.Vector3 initScale;  // 0x28

        // Properties
        System.Int32 UseVertexCount { get; /* RVA: 0x08980114 */ }

        // Methods
        // RVA: 0x089800D8  token: 0x60003A9
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x02102C70  token: 0x60003AB
        public virtual System.Int32 GetVersion() { }
        // RVA: 0x089800F8  token: 0x60003AC
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x0286F540  token: 0x60003AD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000054  // size: 0x10
    public static class Define
    {
        // Methods
        // RVA: 0x056F529C  token: 0x60003B1
        public static System.Boolean IsNormal(MagicaCloth.Define.Error err) { }
        // RVA: 0x089729F0  token: 0x60003B2
        public static System.Boolean IsError(MagicaCloth.Define.Error err) { }
        // RVA: 0x08972A04  token: 0x60003B3
        public static System.Boolean IsWarning(MagicaCloth.Define.Error err) { }
        // RVA: 0x08972690  token: 0x60003B4
        public static System.String GetErrorMessage(MagicaCloth.Define.Error err) { }

    }

    // TypeToken: 0x2000059  // size: 0x48
    public abstract class BaseMeshDeformer : MagicaCloth.IEditorMesh, MagicaCloth.IDataVerify, MagicaCloth.IDataHash
    {
        // Fields
        private MagicaCloth.MeshData meshData;  // 0x10
        private UnityEngine.GameObject targetObject;  // 0x18
        protected System.Int32 dataHash;  // 0x20
        protected System.Int32 dataVersion;  // 0x24
        protected MagicaCloth.RuntimeStatus status;  // 0x28
        private MagicaCloth.CoreComponent parent;  // 0x30
        private System.Int32 <MeshIndex>k__BackingField;  // 0x38
        private System.Int32 <VertexCount>k__BackingField;  // 0x3c
        private System.Int32 <SkinningVertexCount>k__BackingField;  // 0x40
        private System.Int32 <TriangleCount>k__BackingField;  // 0x44

        // Properties
        MagicaCloth.CoreComponent Parent { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }
        MagicaCloth.MeshData MeshData { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }
        UnityEngine.GameObject TargetObject { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        MagicaCloth.RuntimeStatus Status { get; /* RVA: 0x03D4EAC0 */ }
        System.Int32 MeshIndex { get; /* RVA: 0x03D4EC30 */ set; /* RVA: 0x03D4ECB0 */ }
        System.Int32 VertexCount { get; /* RVA: 0x03D4ED90 */ set; /* RVA: 0x03D4EDC0 */ }
        System.Int32 SkinningVertexCount { get; /* RVA: 0x03D4ED80 */ set; /* RVA: 0x03D4EDB0 */ }
        System.Int32 TriangleCount { get; /* RVA: 0x03D4EE80 */ set; /* RVA: 0x03D4EEA0 */ }
        System.Boolean IsSkinning { get; /* RVA: 0x0896F5C8 */ }
        System.Int32 BoneCount { get; /* RVA: 0x0896F550 */ }
        System.Int32 SaveDataHash { get; /* RVA: 0x01003B50 */ }
        System.Int32 SaveDataVersion { get; /* RVA: 0x03D4E2E0 */ }

        // Methods
        // RVA: 0x0896F19C  token: 0x60003C4
        public virtual System.Void Init() { }
        // RVA: 0x0896F348  token: 0x60003C5
        protected virtual System.Void OnInit() { }
        // RVA: 0x0896F03C  token: 0x60003C6
        public virtual System.Void Dispose() { }
        // RVA: 0x0896F31C  token: 0x60003C7
        public virtual System.Void OnEnable() { }
        // RVA: 0x0896F2F0  token: 0x60003C8
        public virtual System.Void OnDisable() { }
        // RVA: 0x0896F3E8  token: 0x60003C9
        public virtual System.Void Update() { }
        // RVA: -1  // abstract  token: 0x60003CA
        private virtual System.Void MeshCalculation(System.Int32 bufferIndex) { }
        // RVA: -1  // abstract  token: 0x60003CB
        private virtual System.Void NormalWriting(System.Int32 bufferIndex) { }
        // RVA: 0x0896F3AC  token: 0x60003CC
        protected System.Void OnUpdateStatus() { }
        // RVA: 0x0350B670  token: 0x60003CD
        protected virtual System.Void OnActive() { }
        // RVA: 0x0350B670  token: 0x60003CE
        protected virtual System.Void OnInactive() { }
        // RVA: 0x0115F4C0  token: 0x60003CF
        public virtual System.Boolean IsMeshUse() { }
        // RVA: 0x0115F4C0  token: 0x60003D0
        public virtual System.Boolean IsActiveMesh() { }
        // RVA: 0x0350B670  token: 0x60003D3
        public virtual System.Void AddUseMesh(System.Object parent) { }
        // RVA: 0x0350B670  token: 0x60003D4
        public virtual System.Void RemoveUseMesh(System.Object parent) { }
        // RVA: 0x0115F4C0  token: 0x60003D5
        public virtual System.Boolean AddUseVertex(System.Int32 vindex, System.Boolean fix) { }
        // RVA: 0x0115F4C0  token: 0x60003D6
        public virtual System.Boolean RemoveUseVertex(System.Int32 vindex, System.Boolean fix) { }
        // RVA: 0x0350B670  token: 0x60003D7
        public virtual System.Void ResetFuturePrediction() { }
        // RVA: 0x0350B670  token: 0x60003D8
        public virtual System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        // RVA: 0x0896F0C4  token: 0x60003D9
        public virtual System.Int32 GetDataHash() { }
        // RVA: -1  // abstract  token: 0x60003DC
        public virtual System.Int32 GetVersion() { }
        // RVA: 0x0896F42C  token: 0x60003DD
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x0896F00C  token: 0x60003DE
        public virtual System.Void CreateVerifyData() { }
        // RVA: 0x0896F170  token: 0x60003DF
        public virtual System.String GetInformation() { }
        // RVA: -1  // abstract  token: 0x60003E0
        public virtual System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        // RVA: -1  // abstract  token: 0x60003E1
        public virtual System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        // RVA: -1  // abstract  token: 0x60003E2
        public virtual System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        // RVA: 0x0896F4E4  token: 0x60003E3
        protected System.Void .ctor() { }
        // RVA: 0x01003830  token: 0x60003E4
        private System.Object <Init>b__33_0() { }

    }

    // TypeToken: 0x200005A  // size: 0x50
    public class MagicaRenderDeformer : MagicaCloth.CoreComponent
    {
        // Fields
        private static System.Int32 DATA_VERSION;  // const
        private static System.Int32 ERR_DATA_VERSION;  // const
        private MagicaCloth.RenderMeshDeformer deformer;  // 0x38
        private System.Int32 deformerHash;  // 0x40
        private System.Int32 deformerVersion;  // 0x44
        private MagicaCloth.PhysicsTeam.TeamCullingMode <cullModeCash>k__BackingField;  // 0x48

        // Properties
        MagicaCloth.PhysicsTeam.TeamCullingMode cullModeCash { get; /* RVA: 0x03D4EC50 */ set; /* RVA: 0x03D4ECD0 */ }
        MagicaCloth.RenderMeshDeformer Deformer { get; /* RVA: 0x0897ACE4 */ }

        // Methods
        // RVA: 0x03D5AB50  token: 0x60003E7
        public virtual MagicaCloth.ComponentType GetComponentType() { }
        // RVA: 0x0897A4C4  token: 0x60003E8
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x0897A844  token: 0x60003EA
        private System.Void OnValidate() { }
        // RVA: 0x0897A7FC  token: 0x60003EB
        protected virtual System.Void OnInit() { }
        // RVA: 0x0897A7B0  token: 0x60003EC
        protected virtual System.Void OnDispose() { }
        // RVA: 0x0897A820  token: 0x60003ED
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x0897A670  token: 0x60003EE
        protected virtual System.Void OnActive() { }
        // RVA: 0x0897A7D8  token: 0x60003EF
        protected virtual System.Void OnInactive() { }
        // RVA: 0x0897A6DC  token: 0x60003F0
        protected System.Void OnBecameVisible() { }
        // RVA: 0x0897A694  token: 0x60003F1
        protected System.Void OnBecameInvisible() { }
        // RVA: 0x0897A868  token: 0x60003F2
        private virtual System.Void UpdateCullingMode(MagicaCloth.CoreComponent caller) { }
        // RVA: 0x0897A724  token: 0x60003F3
        protected virtual System.Void OnChangeCalculation() { }
        // RVA: 0x02102C70  token: 0x60003F4
        public virtual System.Int32 GetVersion() { }
        // RVA: 0x01002730  token: 0x60003F5
        public virtual System.Int32 GetErrorVersion() { }
        // RVA: 0x0897A328  token: 0x60003F6
        public virtual System.Void CreateVerifyData() { }
        // RVA: 0x0897ABD4  token: 0x60003F7
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x0897A588  token: 0x60003F8
        public virtual System.String GetInformation() { }
        // RVA: -1  // generic def  token: 0x60003F9
        public virtual System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        // RVA: 0x0897A5F4  token: 0x60003FA
        public virtual System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        // RVA: 0x0897A2F4  token: 0x60003FB
        protected virtual System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        // RVA: 0x0897A514  token: 0x60003FC
        public virtual System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        // RVA: 0x0897A560  token: 0x60003FD
        public virtual System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        // RVA: 0x0897A4EC  token: 0x60003FE
        public virtual System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        // RVA: 0x0897A5D0  token: 0x60003FF
        public virtual System.Collections.Generic.List<System.Int32> GetUseList() { }
        // RVA: 0x0897A450  token: 0x6000400
        public virtual System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        // RVA: 0x0897A370  token: 0x6000401
        public virtual MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        // RVA: 0x0897AC70  token: 0x6000402
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005B  // size: 0x50
    public class MagicaVirtualDeformer : MagicaCloth.CoreComponent
    {
        // Fields
        private static System.Int32 DATA_VERSION;  // const
        private static System.Int32 ERR_DATA_VERSION;  // const
        private MagicaCloth.VirtualMeshDeformer deformer;  // 0x38
        private System.Int32 deformerHash;  // 0x40
        private System.Int32 deformerVersion;  // 0x44
        private MagicaCloth.PhysicsTeam.TeamCullingMode <cullModeCash>k__BackingField;  // 0x48

        // Properties
        MagicaCloth.PhysicsTeam.TeamCullingMode cullModeCash { get; /* RVA: 0x03D4EC50 */ set; /* RVA: 0x03D4ECD0 */ }
        MagicaCloth.VirtualMeshDeformer Deformer { get; /* RVA: 0x0897ACE4 */ }

        // Methods
        // RVA: 0x03D6E050  token: 0x6000405
        public virtual MagicaCloth.ComponentType GetComponentType() { }
        // RVA: 0x0897A4C4  token: 0x6000406
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x0350B670  token: 0x6000408
        private System.Void OnValidate() { }
        // RVA: 0x0897B274  token: 0x6000409
        protected virtual System.Void OnInit() { }
        // RVA: 0x0897B238  token: 0x600040A
        protected virtual System.Void OnDispose() { }
        // RVA: 0x0897A820  token: 0x600040B
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x0897A670  token: 0x600040C
        protected virtual System.Void OnActive() { }
        // RVA: 0x0897A7D8  token: 0x600040D
        protected virtual System.Void OnInactive() { }
        // RVA: 0x0897B108  token: 0x600040E
        private System.Void LinkRenderDeformerStatus(System.Boolean sw) { }
        // RVA: 0x0897AD10  token: 0x600040F
        protected virtual System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        // RVA: 0x0897B2AC  token: 0x6000410
        private virtual System.Void UpdateCullingMode(MagicaCloth.CoreComponent caller) { }
        // RVA: 0x0897B204  token: 0x6000411
        protected virtual System.Void OnChangeCalculation() { }
        // RVA: 0x02102C70  token: 0x6000412
        public virtual System.Int32 GetVersion() { }
        // RVA: 0x01002730  token: 0x6000413
        public virtual System.Int32 GetErrorVersion() { }
        // RVA: 0x0897A328  token: 0x6000414
        public virtual System.Void CreateVerifyData() { }
        // RVA: 0x0897B690  token: 0x6000415
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x0897A588  token: 0x6000416
        public virtual System.String GetInformation() { }
        // RVA: -1  // generic def  token: 0x6000417
        public virtual System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        // RVA: 0x0897B08C  token: 0x6000418
        public virtual System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        // RVA: 0x0897A514  token: 0x6000419
        public virtual System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        // RVA: 0x0897A560  token: 0x600041A
        public virtual System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        // RVA: 0x0897A4EC  token: 0x600041B
        public virtual System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        // RVA: 0x0897AF00  token: 0x600041C
        public virtual System.Collections.Generic.List<System.Int32> GetUseList() { }
        // RVA: 0x0897AE8C  token: 0x600041D
        public virtual System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        // RVA: 0x0897ADAC  token: 0x600041E
        public virtual MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }
        // RVA: 0x0897B6FC  token: 0x600041F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005C  // size: 0x98
    public class MeshData : MagicaCloth.ShareDataObject
    {
        // Fields
        private static System.Int32 DATA_VERSION;  // const
        public System.Boolean isSkinning;  // 0x20
        public System.Int32 vertexCount;  // 0x24
        public System.UInt32[] vertexInfoList;  // 0x28
        public MagicaCloth.MeshData.VertexWeight[] vertexWeightList;  // 0x30
        public System.UInt64[] vertexHashList;  // 0x38
        public UnityEngine.Vector2[] uvList;  // 0x40
        public System.Int32 lineCount;  // 0x48
        public System.Int32[] lineList;  // 0x50
        public System.Int32 triangleCount;  // 0x58
        public System.Int32[] triangleList;  // 0x60
        public System.Int32 boneCount;  // 0x68
        public System.UInt32[] vertexToTriangleInfoList;  // 0x70
        public System.Int32[] vertexToTriangleIndexList;  // 0x78
        public System.Collections.Generic.List<MagicaCloth.MeshData.ChildData> childDataList;  // 0x80
        public UnityEngine.Vector3 baseScale;  // 0x88

        // Properties
        System.Int32 VertexCount { get; /* RVA: 0x03D4E2E0 */ }
        System.Int32 VertexHashCount { get; /* RVA: 0x0897C334 */ }
        System.Int32 WeightCount { get; /* RVA: 0x0897C348 */ }
        System.Int32 LineCount { get; /* RVA: 0x03D4EC50 */ }
        System.Int32 TriangleCount { get; /* RVA: 0x03D4EF00 */ }
        System.Int32 BoneCount { get; /* RVA: 0x03D4EEE0 */ }
        System.Int32 ChildCount { get; /* RVA: 0x0897C2F4 */ }

        // Methods
        // RVA: 0x0897BE8C  token: 0x6000427
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x02102C70  token: 0x6000428
        public virtual System.Int32 GetVersion() { }
        // RVA: 0x0897C250  token: 0x6000429
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x0897C090  token: 0x600042A
        public System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.UInt32>> GetVirtualToChildVertexDict() { }
        // RVA: 0x0897B770  token: 0x600042B
        public System.Collections.Generic.List<System.Int32> ExtendSelection(System.Collections.Generic.List<System.Int32> originalSelection, System.Boolean extendNext, System.Boolean extendWeight) { }
        // RVA: 0x0897C26C  token: 0x600042C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200005F  // size: 0xA8
    public class RenderMeshDeformer : MagicaCloth.BaseMeshDeformer, MagicaCloth.IBoneReplace
    {
        // Fields
        private static System.Int32 DATA_VERSION;  // const
        private MagicaCloth.RenderMeshDeformer.RecalculateMode normalAndTangentUpdateMode;  // 0x48
        private MagicaCloth.RenderMeshDeformer.BoundsMode boundsUpdateMode;  // 0x4c
        private UnityEngine.Mesh sharedMesh;  // 0x50
        private System.Int32 meshOptimize;  // 0x58
        private UnityEngine.Renderer renderer;  // 0x60
        private UnityEngine.MeshFilter meshFilter;  // 0x68
        private UnityEngine.SkinnedMeshRenderer skinMeshRenderer;  // 0x70
        private UnityEngine.Transform[] originalBones;  // 0x78
        private UnityEngine.Transform[] boneList;  // 0x80
        private UnityEngine.Mesh cloneMesh;  // 0x88
        private UnityEngine.GraphicsBuffer vertexBuffer;  // 0x90
        private System.Boolean <IsChangePosition>k__BackingField;  // 0x98
        private System.Boolean <IsChangeNormalTangent>k__BackingField;  // 0x99
        private System.Boolean <IsChangeBoneWeights>k__BackingField;  // 0x9a
        private System.Boolean oldUse;  // 0x9b
        private System.Boolean <IsWriteSkip>k__BackingField;  // 0x9c
        private System.Boolean <IsFasterWriteUpdate>k__BackingField;  // 0x9d
        private System.Boolean <IsWriteMeshPosition>k__BackingField;  // 0x9e
        private System.Boolean <IsWriteMeshBoneWeight>k__BackingField;  // 0x9f
        private System.Boolean IsWriteMeshNormal;  // 0xa0
        private System.Boolean IsWriteMeshTangent;  // 0xa1
        private System.Boolean <IsFasterWrite>k__BackingField;  // 0xa2

        // Properties
        System.Boolean IsChangePosition { get; /* RVA: 0x03D58690 */ set; /* RVA: 0x03D5CE20 */ }
        System.Boolean IsChangeNormalTangent { get; /* RVA: 0x03D6E080 */ set; /* RVA: 0x03D6E0D0 */ }
        System.Boolean IsChangeBoneWeights { get; /* RVA: 0x03D6E070 */ set; /* RVA: 0x03D6E0C0 */ }
        System.Boolean IsWriteSkip { get; /* RVA: 0x03D5E1C0 */ set; /* RVA: 0x03D5E200 */ }
        System.Boolean IsFasterWriteUpdate { get; /* RVA: 0x03D6E090 */ set; /* RVA: 0x03D6E0E0 */ }
        System.Boolean IsWriteMeshPosition { get; /* RVA: 0x03D6E0B0 */ set; /* RVA: 0x03D6E100 */ }
        System.Boolean IsWriteMeshBoneWeight { get; /* RVA: 0x03D6E0A0 */ set; /* RVA: 0x03D6E0F0 */ }
        UnityEngine.Mesh SharedMesh { get; /* RVA: 0x03D4EAF0 */ }
        System.Boolean IsFasterWrite { get; /* RVA: 0x03D5B390 */ set; /* RVA: 0x03D5B3C0 */ }
        System.Boolean IsRendererVisible { get; /* RVA: 0x0897EE6C */ }
        System.Boolean HasNormal { get; /* RVA: 0x0897EE58 */ }

        // Methods
        // RVA: 0x0897C9A0  token: 0x600043E
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x0897E8FC  token: 0x6000442
        public System.Void OnValidate() { }
        // RVA: 0x0897DFFC  token: 0x6000443
        protected virtual System.Void OnInit() { }
        // RVA: 0x0897DDF8  token: 0x6000444
        protected virtual System.Void OnActive() { }
        // RVA: 0x0897DF08  token: 0x6000445
        protected virtual System.Void OnInactive() { }
        // RVA: 0x0897C760  token: 0x6000446
        public virtual System.Void Dispose() { }
        // RVA: 0x0897EC2C  token: 0x6000447
        private System.Void SetRecalculateNormalAndTangentMode() { }
        // RVA: 0x0897C6DC  token: 0x6000448
        public virtual System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        // RVA: 0x0897C64C  token: 0x6000449
        public System.Void ChangeCalculation(System.Boolean sw) { }
        // RVA: 0x0897D814  token: 0x600044A
        public virtual System.Boolean IsMeshUse() { }
        // RVA: 0x0897D79C  token: 0x600044B
        public virtual System.Boolean IsActiveMesh() { }
        // RVA: 0x0897C35C  token: 0x600044C
        public virtual System.Void AddUseMesh(System.Object parent) { }
        // RVA: 0x0897E93C  token: 0x600044D
        public virtual System.Void RemoveUseMesh(System.Object parent) { }
        // RVA: 0x0897D88C  token: 0x6000450
        private virtual System.Void MeshCalculation(System.Int32 bufferIndex) { }
        // RVA: 0x0897DC80  token: 0x6000451
        private virtual System.Void NormalWriting(System.Int32 bufferIndex) { }
        // RVA: 0x0897C854  token: 0x6000452
        private System.Boolean FasterWriting(System.Int32 bufferIndex, UnityEngine.ComputeShader compute, System.Int32 kernel, System.Int32 index, System.Int32& maxVertexCount) { }
        // RVA: 0x03D6E060  token: 0x6000453
        public System.Void ChangeNormalTangentUpdateMode() { }
        // RVA: -1  // generic def  token: 0x6000454
        public virtual System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        // RVA: 0x0897D698  token: 0x6000455
        public virtual System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        // RVA: 0x0897CA24  token: 0x6000456
        public virtual System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        // RVA: 0x0897CDB4  token: 0x6000457
        public virtual System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        // RVA: 0x01002730  token: 0x6000458
        public virtual System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        // RVA: 0x0897CE64  token: 0x6000459
        public System.Collections.Generic.List<System.Int32> GetEditorUseList() { }
        // RVA: 0x02102C70  token: 0x600045A
        public virtual System.Int32 GetVersion() { }
        // RVA: 0x0897ED04  token: 0x600045B
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x0897D560  token: 0x600045C
        private UnityEngine.Mesh GetTargetSharedMesh() { }
        // RVA: 0x0897CEE8  token: 0x600045D
        public virtual System.String GetInformation() { }
        // RVA: 0x0897EE48  token: 0x600045E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000062  // size: 0x88
    public class VirtualMeshDeformer : MagicaCloth.BaseMeshDeformer, MagicaCloth.IBoneReplace
    {
        // Fields
        private static System.Int32 DATA_VERSION;  // const
        private System.Collections.Generic.List<MagicaCloth.MagicaRenderDeformer> renderDeformerList;  // 0x48
        private System.Collections.Generic.List<System.Int32> renderDeformerHashList;  // 0x50
        private System.Int32 renderDeformerVersion;  // 0x58
        private System.Single mergeVertexDistance;  // 0x5c
        private System.Single mergeTriangleDistance;  // 0x60
        private System.Single sameSurfaceAngle;  // 0x64
        private System.Boolean useSkinning;  // 0x68
        private System.Int32 maxWeightCount;  // 0x6c
        private System.Single weightPow;  // 0x70
        private System.Collections.Generic.List<UnityEngine.Transform> boneList;  // 0x78
        private System.Collections.Generic.List<System.Int32> sharedChildMeshIndexList;  // 0x80

        // Properties
        System.Single MergeVertexDistance { get; /* RVA: 0x03D56C10 */ }
        System.Single MergeTriangleDistance { get; /* RVA: 0x03D50D50 */ }
        System.Single SameSurfaceAngle { get; /* RVA: 0x03D50D60 */ }
        System.Int32 MaxWeightCount { get; /* RVA: 0x0898260C */ }
        System.Single WeightPow { get; /* RVA: 0x03D56C00 */ }
        System.Int32 RenderDeformerCount { get; /* RVA: 0x08982638 */ }

        // Methods
        // RVA: 0x08980918  token: 0x600045F
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x089819C4  token: 0x6000460
        protected virtual System.Void OnInit() { }
        // RVA: 0x089806F0  token: 0x6000461
        public virtual System.Void Dispose() { }
        // RVA: 0x08981858  token: 0x6000462
        protected virtual System.Void OnActive() { }
        // RVA: 0x08981900  token: 0x6000463
        protected virtual System.Void OnInactive() { }
        // RVA: 0x0350B670  token: 0x6000464
        private virtual System.Void MeshCalculation(System.Int32 bufferIndex) { }
        // RVA: 0x0350B670  token: 0x6000465
        private virtual System.Void NormalWriting(System.Int32 bufferIndex) { }
        // RVA: -1  // generic def  token: 0x6000466
        public virtual System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }
        // RVA: 0x089816F4  token: 0x6000467
        public virtual System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        // RVA: 0x0339AE90  token: 0x6000468
        public MagicaCloth.BaseMeshDeformer GetDeformer() { }
        // RVA: 0x089815D0  token: 0x600046F
        public MagicaCloth.MagicaRenderDeformer GetRenderDeformer(System.Int32 index) { }
        // RVA: 0x08981624  token: 0x6000470
        public System.Int32 GetRenderMeshDeformerIndex(MagicaCloth.RenderMeshDeformer deformer) { }
        // RVA: 0x08981480  token: 0x6000471
        public System.Collections.Generic.List<MagicaCloth.MeshData> GetRenderDeformerMeshList() { }
        // RVA: 0x089817E0  token: 0x6000472
        public virtual System.Boolean IsMeshUse() { }
        // RVA: 0x08981768  token: 0x6000473
        public virtual System.Boolean IsActiveMesh() { }
        // RVA: 0x089802DC  token: 0x6000474
        public virtual System.Void AddUseMesh(System.Object parent) { }
        // RVA: 0x08981EC0  token: 0x6000475
        public virtual System.Void RemoveUseMesh(System.Object parent) { }
        // RVA: 0x089803C0  token: 0x6000476
        public virtual System.Boolean AddUseVertex(System.Int32 vindex, System.Boolean fix) { }
        // RVA: 0x08981FA4  token: 0x6000477
        public virtual System.Boolean RemoveUseVertex(System.Int32 vindex, System.Boolean fix) { }
        // RVA: 0x0898203C  token: 0x6000478
        public virtual System.Void ResetFuturePrediction() { }
        // RVA: 0x089804E8  token: 0x6000479
        public virtual System.Void ChangeUseUnityPhysics(System.Boolean sw) { }
        // RVA: 0x08980458  token: 0x600047A
        public System.Void ChangeCalculation(System.Boolean sw) { }
        // RVA: 0x08980AB4  token: 0x600047B
        public virtual System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        // RVA: 0x08980DCC  token: 0x600047C
        public virtual System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        // RVA: 0x08980A00  token: 0x600047D
        public virtual System.Collections.Generic.List<System.Int32> GetEditorLineList() { }
        // RVA: 0x01168950  token: 0x600047E
        public virtual System.Int32 GetVersion() { }
        // RVA: 0x0898056C  token: 0x600047F
        public virtual System.Void CreateVerifyData() { }
        // RVA: 0x0898209C  token: 0x6000480
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x08980E80  token: 0x6000481
        public virtual System.String GetInformation() { }
        // RVA: 0x0898249C  token: 0x6000482
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000064  // size: 0x40
    public class ClampDistance2Constraint : MagicaCloth.PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ClampDistance2Constraint.ClampDistance2Data> dataList;  // 0x20
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ClampDistance2Constraint.ClampDistance2RootInfo> rootInfoList;  // 0x28
        public MagicaCloth.FixedNativeList<MagicaCloth.ClampDistance2Constraint.GroupData> groupList;  // 0x30
        private MagicaCloth.FixedChunkNativeArray<System.Int32> rootTeamList;  // 0x38

        // Methods
        // RVA: 0x08983064  token: 0x6000485
        public virtual System.Void Create() { }
        // RVA: 0x089831BC  token: 0x6000486
        public virtual System.Void Release() { }
        // RVA: 0x08982BF0  token: 0x6000487
        public System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Single minRatio, System.Single maxRatio, System.Single velocityInfluence, MagicaCloth.ClampDistance2Constraint.ClampDistance2Data[] dataArray, MagicaCloth.ClampDistance2Constraint.ClampDistance2RootInfo[] rootInfoArray) { }
        // RVA: 0x08983264  token: 0x6000488
        public virtual System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: 0x08982EB4  token: 0x6000489
        public System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Single minRatio, System.Single maxRatio, System.Single velocityInfluence) { }
        // RVA: 0x08983464  token: 0x600048A
        public virtual Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03D51DD0  token: 0x600048B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000069  // size: 0x38
    public class ClampDistanceConstraint : MagicaCloth.PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ClampDistanceConstraint.ClampDistanceData> dataList;  // 0x20
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex> refDataList;  // 0x28
        public MagicaCloth.FixedNativeList<MagicaCloth.ClampDistanceConstraint.GroupData> groupList;  // 0x30

        // Methods
        // RVA: 0x035406C0  token: 0x600048D
        public virtual System.Void Create() { }
        // RVA: 0x08983FF4  token: 0x600048E
        public virtual System.Void Release() { }
        // RVA: 0x08983BE8  token: 0x600048F
        public System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Single minRatio, System.Single maxRatio, System.Single velocityInfluence, MagicaCloth.ClampDistanceConstraint.ClampDistanceData[] dataArray, MagicaCloth.ReferenceDataIndex[] refDataArray) { }
        // RVA: 0x0898407C  token: 0x6000490
        public virtual System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: 0x08983E44  token: 0x6000491
        public System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Single minRatio, System.Single maxRatio, System.Single velocityInfluence) { }
        // RVA: 0x08984244  token: 0x6000492
        public virtual Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03D51DD0  token: 0x6000493
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200006D  // size: 0x28
    public class ClampPositionConstraint : MagicaCloth.PhysicsManagerConstraint
    {
        // Fields
        public MagicaCloth.FixedNativeList<MagicaCloth.ClampPositionConstraint.GroupData> groupList;  // 0x20

        // Methods
        // RVA: 0x03CFD970  token: 0x6000496
        public virtual System.Void Create() { }
        // RVA: 0x08984E7C  token: 0x6000497
        public virtual System.Void Release() { }
        // RVA: 0x08984B7C  token: 0x6000498
        public System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam limitLength, Unity.Mathematics.float3 axisRatio, System.Single velocityInfluence) { }
        // RVA: 0x08984EC4  token: 0x6000499
        public virtual System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: 0x08984CA8  token: 0x600049A
        public System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam limitLength, Unity.Mathematics.float3 axisRatio, System.Single velocityInfluence) { }
        // RVA: 0x08984FDC  token: 0x600049B
        public virtual Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03D51DD0  token: 0x600049C
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000070  // size: 0x48
    public class ClampRotationConstraint : MagicaCloth.PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ClampRotationConstraint.ClampRotationData> dataList;  // 0x20
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ClampRotationConstraint.ClampRotationRootInfo> rootInfoList;  // 0x28
        public MagicaCloth.FixedNativeList<MagicaCloth.ClampRotationConstraint.GroupData> groupList;  // 0x30
        private MagicaCloth.FixedChunkNativeArray<System.Int32> rootTeamList;  // 0x38
        private MagicaCloth.FixedChunkNativeArray<System.Single> lengthBuffer;  // 0x40

        // Methods
        // RVA: 0x035407D0  token: 0x600049F
        public virtual System.Void Create() { }
        // RVA: 0x08985E6C  token: 0x60004A0
        public virtual System.Void Release() { }
        // RVA: 0x089859C4  token: 0x60004A1
        public System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam maxAngle, System.Single velocityInfluence, MagicaCloth.ClampRotationConstraint.ClampRotationData[] dataArray, MagicaCloth.ClampRotationConstraint.ClampRotationRootInfo[] rootInfoArray) { }
        // RVA: 0x08985F38  token: 0x60004A2
        public virtual System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: 0x08985C8C  token: 0x60004A3
        public System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam maxAngle, System.Single velocityInfluence) { }
        // RVA: 0x08986184  token: 0x60004A4
        public virtual Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03D51DD0  token: 0x60004A5
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000075  // size: 0x20
    public class ColliderCollisionConstraint : MagicaCloth.PhysicsManagerConstraint
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60004A8
        public virtual System.Void Create() { }
        // RVA: 0x0350B670  token: 0x60004A9
        public virtual System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: 0x08986FEC  token: 0x60004AA
        public System.Void ChangeParam(System.Int32 teamId, System.Boolean useCollision) { }
        // RVA: 0x0350B670  token: 0x60004AB
        public virtual System.Void Release() { }
        // RVA: 0x0898703C  token: 0x60004AC
        public virtual Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03D51DD0  token: 0x60004AD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000077  // size: 0x20
    public class ColliderExtrusionConstraint : MagicaCloth.PhysicsManagerConstraint
    {
        // Methods
        // RVA: 0x0350B670  token: 0x60004B2
        public virtual System.Void Create() { }
        // RVA: 0x0350B670  token: 0x60004B3
        public virtual System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: 0x0350B670  token: 0x60004B4
        public virtual System.Void Release() { }
        // RVA: 0x08987590  token: 0x60004B5
        public virtual Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03D51DD0  token: 0x60004B6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000079  // size: 0x48
    public class CompositeRotationConstraint : MagicaCloth.PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.CompositeRotationConstraint.RotationData> dataList;  // 0x20
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.CompositeRotationConstraint.RootInfo> rootInfoList;  // 0x28
        public MagicaCloth.FixedNativeList<MagicaCloth.CompositeRotationConstraint.GroupData> groupList;  // 0x30
        private MagicaCloth.FixedChunkNativeArray<System.Int32> rootTeamList;  // 0x38
        private MagicaCloth.FixedChunkNativeArray<System.Single> lengthBuffer;  // 0x40

        // Methods
        // RVA: 0x03540970  token: 0x60004B8
        public virtual System.Void Create() { }
        // RVA: 0x08988EF8  token: 0x60004B9
        public virtual System.Void Release() { }
        // RVA: 0x08988A24  token: 0x60004BA
        public System.Int32 AddGroup(System.Int32 teamId, System.Boolean useClamp, MagicaCloth.BezierParam maxAngle, System.Boolean useRestore, MagicaCloth.BezierParam restorePower, System.Single velocityInfluence, MagicaCloth.CompositeRotationConstraint.RotationData[] dataArray, MagicaCloth.CompositeRotationConstraint.RootInfo[] rootInfoArray) { }
        // RVA: 0x08988FC4  token: 0x60004BB
        public virtual System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: 0x08988CF4  token: 0x60004BC
        public System.Void ChangeParam(System.Int32 teamId, System.Boolean useClamp, MagicaCloth.BezierParam maxAngle, System.Boolean useRestore, MagicaCloth.BezierParam restorePower, System.Single velocityInfluence) { }
        // RVA: 0x089891D4  token: 0x60004BD
        public virtual Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03D51DD0  token: 0x60004BE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200007E  // size: 0x48
    public class EdgeCollisionConstraint : MagicaCloth.PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.EdgeCollisionConstraint.EdgeCollisionData> dataList;  // 0x20
        private MagicaCloth.FixedChunkNativeArray<System.Int16> groupIndexList;  // 0x28
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex> refDataList;  // 0x30
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> writeBuffer;  // 0x38
        private MagicaCloth.FixedNativeList<MagicaCloth.EdgeCollisionConstraint.GroupData> groupList;  // 0x40

        // Methods
        // RVA: 0x0898B1C4  token: 0x60004C2
        public virtual System.Void Create() { }
        // RVA: 0x0898B368  token: 0x60004C3
        public virtual System.Void Release() { }
        // RVA: 0x0898ACFC  token: 0x60004C4
        public System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Single edgeRadius, MagicaCloth.EdgeCollisionConstraint.EdgeCollisionData[] dataArray, MagicaCloth.ReferenceDataIndex[] refDataArray, System.Int32 writeBufferCount) { }
        // RVA: 0x0898B434  token: 0x60004C5
        public virtual System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: 0x0898B030  token: 0x60004C6
        public System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Single edgeRadius) { }
        // RVA: 0x0898B680  token: 0x60004C7
        public virtual Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03D51DD0  token: 0x60004C8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000083  // size: 0x40
    public class PenetrationConstraint : MagicaCloth.PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.PenetrationConstraint.PenetrationData> dataList;  // 0x20
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex> refDataList;  // 0x28
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> bonePenetrationDataList;  // 0x30
        public MagicaCloth.FixedNativeList<MagicaCloth.PenetrationConstraint.GroupData> groupList;  // 0x38

        // Methods
        // RVA: 0x03540B10  token: 0x60004CE
        public virtual System.Void Create() { }
        // RVA: 0x0898C5B4  token: 0x60004CF
        public virtual System.Void Release() { }
        // RVA: 0x0898C0EC  token: 0x60004D0
        public System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.ClothParams.PenetrationMode mode, MagicaCloth.BezierParam distance, MagicaCloth.BezierParam radius, System.Single maxDepth, MagicaCloth.PenetrationConstraint.PenetrationData[] moveLimitDataList, MagicaCloth.ReferenceDataIndex[] refDataArray, Unity.Mathematics.float3[] bonePenetrationDataArray) { }
        // RVA: 0x0898C65C  token: 0x60004D1
        public virtual System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: 0x0898C3BC  token: 0x60004D2
        public System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam distance, MagicaCloth.BezierParam radius, System.Single maxDepth) { }
        // RVA: 0x0898C848  token: 0x60004D3
        public virtual Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03D51DD0  token: 0x60004D4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000087  // size: 0x38
    public class RestoreDistanceConstraint : MagicaCloth.PhysicsManagerConstraint
    {
        // Fields
        public static System.Int32 StructType;  // const
        public static System.Int32 BendType;  // const
        public static System.Int32 NearType;  // const
        public static System.Int32 TypeCount;  // const
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData>[] dataList;  // 0x20
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex>[] refDataList;  // 0x28
        public MagicaCloth.FixedNativeList<MagicaCloth.RestoreDistanceConstraint.RestoreDistanceGroupData> groupList;  // 0x30

        // Methods
        // RVA: 0x03540E90  token: 0x60004D9
        public virtual System.Void Create() { }
        // RVA: 0x0898E544  token: 0x60004DA
        public virtual System.Void Release() { }
        // RVA: 0x0898DCDC  token: 0x60004DB
        public System.Int32 AddGroup(System.Int32 teamId, MagicaCloth.BezierParam mass, System.Single velocityInfluence, MagicaCloth.BezierParam structStiffness, MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[] structDataArray, MagicaCloth.ReferenceDataIndex[] structRefDataArray, System.Boolean useBend, MagicaCloth.BezierParam bendStiffness, MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[] bendDataArray, MagicaCloth.ReferenceDataIndex[] bendRefDataArray, System.Boolean useNear, MagicaCloth.BezierParam nearStiffness, MagicaCloth.RestoreDistanceConstraint.RestoreDistanceData[] nearDataArray, MagicaCloth.ReferenceDataIndex[] nearRefDataArray) { }
        // RVA: 0x0898E628  token: 0x60004DC
        public virtual System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: 0x0898E2A8  token: 0x60004DD
        public System.Void ChangeParam(System.Int32 teamId, MagicaCloth.BezierParam mass, System.Single velocityInfluence, MagicaCloth.BezierParam structStiffness, System.Boolean useBend, MagicaCloth.BezierParam bendStiffness, System.Boolean useNear, MagicaCloth.BezierParam nearStiffness) { }
        // RVA: 0x03D4E340  token: 0x60004DE
        public virtual System.Int32 GetIterationCount() { }
        // RVA: 0x0898E8D4  token: 0x60004DF
        public virtual Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03D51DD0  token: 0x60004E0
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008B  // size: 0x38
    public class RestoreRotationConstraint : MagicaCloth.PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.RestoreRotationConstraint.RotationData> dataList;  // 0x20
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex> refDataList;  // 0x28
        public MagicaCloth.FixedNativeList<MagicaCloth.RestoreRotationConstraint.GroupData> groupList;  // 0x30

        // Methods
        // RVA: 0x03540C70  token: 0x60004E7
        public virtual System.Void Create() { }
        // RVA: 0x0898F2D4  token: 0x60004E8
        public virtual System.Void Release() { }
        // RVA: 0x0898EE78  token: 0x60004E9
        public System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam power, System.Single velocityInfluence, MagicaCloth.RestoreRotationConstraint.RotationData[] dataArray, MagicaCloth.ReferenceDataIndex[] refDataArray) { }
        // RVA: 0x0898F35C  token: 0x60004EA
        public virtual System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: 0x0898F0F4  token: 0x60004EB
        public System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam power, System.Single velocityInfluence) { }
        // RVA: 0x0898F534  token: 0x60004EC
        public virtual Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03D51DD0  token: 0x60004ED
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200008F  // size: 0x28
    public class SpringConstraint : MagicaCloth.PhysicsManagerConstraint
    {
        // Fields
        public MagicaCloth.FixedNativeList<MagicaCloth.SpringConstraint.GroupData> groupList;  // 0x20

        // Methods
        // RVA: 0x03CFC2F0  token: 0x60004F0
        public virtual System.Void Create() { }
        // RVA: 0x089919BC  token: 0x60004F1
        public virtual System.Void Release() { }
        // RVA: 0x08991790  token: 0x60004F2
        public System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Single spring) { }
        // RVA: 0x08991A04  token: 0x60004F3
        public virtual System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: 0x0899185C  token: 0x60004F4
        public System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Single spring) { }
        // RVA: 0x08991B1C  token: 0x60004F5
        public virtual Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03D51DD0  token: 0x60004F6
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000092  // size: 0x48
    public class TriangleBendConstraint : MagicaCloth.PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.TriangleBendConstraint.TriangleBendData> dataList;  // 0x20
        private MagicaCloth.FixedChunkNativeArray<System.Int16> groupIndexList;  // 0x28
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex> refDataList;  // 0x30
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> writeBuffer;  // 0x38
        private MagicaCloth.FixedNativeList<MagicaCloth.TriangleBendConstraint.TriangleBendGroupData> groupList;  // 0x40

        // Methods
        // RVA: 0x03541070  token: 0x60004F8
        public virtual System.Void Create() { }
        // RVA: 0x0899328C  token: 0x60004F9
        public virtual System.Void Release() { }
        // RVA: 0x08992D28  token: 0x60004FA
        public System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.ClothParams.Algorithm algorithm, MagicaCloth.BezierParam stiffness, MagicaCloth.TriangleBendConstraint.TriangleBendData[] dataArray, MagicaCloth.ReferenceDataIndex[] refDataArray, System.Int32 writeBufferCount) { }
        // RVA: 0x08993358  token: 0x60004FB
        public virtual System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: 0x08993090  token: 0x60004FC
        public System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam stiffness) { }
        // RVA: 0x089935A4  token: 0x60004FD
        public virtual Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03D51DD0  token: 0x60004FE
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000097  // size: 0x38
    public class TwistConstraint : MagicaCloth.PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.TwistConstraint.TwistData> dataList;  // 0x20
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex> refDataList;  // 0x28
        public MagicaCloth.FixedNativeList<MagicaCloth.TwistConstraint.GroupData> groupList;  // 0x30

        // Methods
        // RVA: 0x03540D80  token: 0x6000503
        public virtual System.Void Create() { }
        // RVA: 0x089941A8  token: 0x6000504
        public virtual System.Void Release() { }
        // RVA: 0x08993E40  token: 0x6000505
        public System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Single recoveryPower, MagicaCloth.TwistConstraint.TwistData[] dataArray, MagicaCloth.ReferenceDataIndex[] refArray) { }
        // RVA: 0x08994230  token: 0x6000506
        public virtual System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: 0x08994028  token: 0x6000507
        public System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Single recoveryPower) { }
        // RVA: 0x08994408  token: 0x6000508
        public virtual Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03D51DD0  token: 0x6000509
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200009B  // size: 0x48
    public class VolumeConstraint : MagicaCloth.PhysicsManagerConstraint
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.VolumeConstraint.VolumeData> dataList;  // 0x20
        private MagicaCloth.FixedChunkNativeArray<System.Int16> groupIndexList;  // 0x28
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.ReferenceDataIndex> refDataList;  // 0x30
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> writeBuffer;  // 0x38
        private MagicaCloth.FixedNativeList<MagicaCloth.VolumeConstraint.GroupData> groupList;  // 0x40

        // Methods
        // RVA: 0x08996310  token: 0x600050C
        public virtual System.Void Create() { }
        // RVA: 0x089964B4  token: 0x600050D
        public virtual System.Void Release() { }
        // RVA: 0x08995D88  token: 0x600050E
        public System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam stretchStiffness, MagicaCloth.BezierParam shearStiffness, MagicaCloth.VolumeConstraint.VolumeData[] dataArray, MagicaCloth.ReferenceDataIndex[] refDataArray, System.Int32 writeBufferCount) { }
        // RVA: 0x08996580  token: 0x600050F
        public virtual System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: 0x089960FC  token: 0x6000510
        public System.Void ChangeParam(System.Int32 teamId, System.Boolean active, MagicaCloth.BezierParam stretchStiffness, MagicaCloth.BezierParam shearStiffness) { }
        // RVA: 0x03D4E340  token: 0x6000511
        public virtual System.Int32 GetIterationCount() { }
        // RVA: 0x089967BC  token: 0x6000512
        public virtual Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03D51DD0  token: 0x6000513
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000A0  // size: 0x20
    public sealed struct CurveParam
    {
        // Fields
        public System.Single sval;  // 0x10
        public System.Single eval;  // 0x14
        public System.Single cval;  // 0x18
        public System.Int32 useCurve;  // 0x1c

        // Methods
        // RVA: 0x03D6E200  token: 0x6000517
        public System.Void .ctor(System.Single value) { }
        // RVA: 0x03D6E210  token: 0x6000518
        public System.Void .ctor(System.Single svalue, System.Single evalue) { }
        // RVA: 0x08997188  token: 0x6000519
        public System.Void .ctor(MagicaCloth.BezierParam bezier) { }
        // RVA: 0x089970E8  token: 0x600051A
        public System.Void Setup(MagicaCloth.BezierParam bezier) { }
        // RVA: 0x08997080  token: 0x600051B
        public System.Single Evaluate(System.Single t) { }

    }

    // TypeToken: 0x20000A1  // size: 0x18
    public abstract class BaseComponent : UnityEngine.MonoBehaviour
    {
        // Methods
        // RVA: -1  // abstract  token: 0x600051C
        public virtual MagicaCloth.ComponentType GetComponentType() { }
        // RVA: 0x0426FE60  token: 0x600051D
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000A2  // size: 0x14
    public sealed struct ComponentType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static MagicaCloth.ComponentType None;  // const
        public static MagicaCloth.ComponentType SphereCollider;  // const
        public static MagicaCloth.ComponentType CapsuleCollider;  // const
        public static MagicaCloth.ComponentType PlaneCollider;  // const
        public static MagicaCloth.ComponentType DirectionalWind;  // const
        public static MagicaCloth.ComponentType AreaWind;  // const
        public static MagicaCloth.ComponentType RenderDeformer;  // const
        public static MagicaCloth.ComponentType VirtualDeformer;  // const
        public static MagicaCloth.ComponentType BoneCloth;  // const
        public static MagicaCloth.ComponentType BoneSpring;  // const
        public static MagicaCloth.ComponentType MeshCloth;  // const
        public static MagicaCloth.ComponentType MeshSpring;  // const
        public static MagicaCloth.ComponentType Avatar;  // const
        public static MagicaCloth.ComponentType AvatarParts;  // const

    }

    // TypeToken: 0x20000A3  // size: 0x18
    public abstract class PhysicsManagerAccess : System.IDisposable
    {
        // Fields
        protected MagicaCloth.MagicaPhysicsManager manager;  // 0x10

        // Properties
        MagicaCloth.UpdateTimeManager UpdateTime { get; /* RVA: 0x056B3E18 */ }
        MagicaCloth.PhysicsManagerParticleData Particle { get; /* RVA: 0x08954478 */ }
        MagicaCloth.PhysicsManagerBoneData Bone { get; /* RVA: 0x02312EC0 */ }
        MagicaCloth.PhysicsManagerMeshData Mesh { get; /* RVA: 0x02313B50 */ }
        MagicaCloth.PhysicsManagerTeamData Team { get; /* RVA: 0x02313AD0 */ }
        MagicaCloth.PhysicsManagerWindData Wind { get; /* RVA: 0x0896A1FC */ }
        MagicaCloth.PhysicsManagerComponent Component { get; /* RVA: 0x08998590 */ }
        MagicaCloth.PhysicsManagerCompute Compute { get; /* RVA: 0x089985B0 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000526
        public System.Void SetParent(MagicaCloth.MagicaPhysicsManager manager) { }
        // RVA: -1  // abstract  token: 0x6000527
        public virtual System.Void Create() { }
        // RVA: -1  // abstract  token: 0x6000528
        public virtual System.Void Dispose() { }
        // RVA: 0x0350B670  token: 0x6000529
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000A4  // size: 0xD0
    public class PhysicsManagerBoneData : MagicaCloth.PhysicsManagerAccess
    {
        // Fields
        public static System.Byte Flag_Reset;  // const
        public static System.Byte Flag_Restore;  // const
        public static System.Byte Flag_Write;  // const
        public MagicaCloth.FixedTransformAccessArray boneList;  // 0x18
        public MagicaCloth.FixedNativeList<System.Byte> boneFlagList;  // 0x20
        public MagicaCloth.FixedNativeList<Unity.Mathematics.float3> bonePosList;  // 0x28
        public MagicaCloth.FixedNativeList<Unity.Mathematics.quaternion> boneRotList;  // 0x30
        public MagicaCloth.FixedNativeList<Unity.Mathematics.float3> boneSclList;  // 0x38
        public MagicaCloth.FixedNativeList<System.Int32> boneParentIndexList;  // 0x40
        public MagicaCloth.FixedNativeList<Unity.Mathematics.float3> basePosList;  // 0x48
        public MagicaCloth.FixedNativeList<Unity.Mathematics.quaternion> baseRotList;  // 0x50
        public MagicaCloth.FixedNativeList<System.Int16> boneUnityPhysicsList;  // 0x58
        public MagicaCloth.FixedNativeList<Unity.Mathematics.float3> futurePosList;  // 0x60
        public MagicaCloth.FixedNativeList<Unity.Mathematics.quaternion> futureRotList;  // 0x68
        public MagicaCloth.FixedTransformAccessArray restoreBoneList;  // 0x70
        public MagicaCloth.FixedNativeList<Unity.Mathematics.float3> restoreBoneLocalPosList;  // 0x78
        public MagicaCloth.FixedNativeList<Unity.Mathematics.quaternion> restoreBoneLocalRotList;  // 0x80
        public MagicaCloth.FixedNativeList<System.Int32> restoreBoneIndexList;  // 0x88
        public MagicaCloth.FixedTransformAccessArray writeBoneList;  // 0x90
        public MagicaCloth.FixedNativeList<System.Int32> writeBoneIndexList;  // 0x98
        public MagicaCloth.ExNativeMultiHashMap<System.Int32,System.Int32> writeBoneParticleIndexMap;  // 0xa0
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> boneToWriteIndexDict;  // 0xa8
        public MagicaCloth.FixedNativeList<Unity.Mathematics.float3> writeBonePosList;  // 0xb0
        public MagicaCloth.FixedNativeList<Unity.Mathematics.quaternion> writeBoneRotList;  // 0xb8
        private System.Boolean <hasBoneChanged>k__BackingField;  // 0xc0
        private UnityEngine.Profiling.CustomSampler <SamplerReadBoneScale>k__BackingField;  // 0xc8

        // Properties
        System.Boolean hasBoneChanged { get; /* RVA: 0x03D583F0 */ set; /* RVA: 0x03D5A1B0 */ }
        UnityEngine.Profiling.CustomSampler SamplerReadBoneScale { get; /* RVA: 0x03D4E7C0 */ set; /* RVA: 0x058B4280 */ }
        System.Int32 RestoreBoneCount { get; /* RVA: 0x08999FA0 */ }
        System.Int32 ReadBoneCount { get; /* RVA: 0x08999F80 */ }
        System.Int32 WriteBoneCount { get; /* RVA: 0x02312880 */ }

        // Methods
        // RVA: 0x02E11160  token: 0x600052E
        public virtual System.Void Create() { }
        // RVA: 0x089991A4  token: 0x600052F
        public virtual System.Void Dispose() { }
        // RVA: 0x08998B00  token: 0x6000530
        public System.Int32 AddRestoreBone(UnityEngine.Transform target, Unity.Mathematics.float3 lpos, Unity.Mathematics.quaternion lrot, System.Int32 boneIndex) { }
        // RVA: 0x08999C64  token: 0x6000531
        public System.Void RemoveRestoreBone(System.Int32 restoreBoneIndex) { }
        // RVA: 0x089985D0  token: 0x6000533
        public System.Int32 AddBone(UnityEngine.Transform target, System.Int32 pindex, System.Boolean addParent) { }
        // RVA: 0x08999934  token: 0x6000534
        public System.Boolean RemoveBone(System.Int32 boneIndex, System.Int32 pindex) { }
        // RVA: 0x08998C2C  token: 0x6000535
        public System.Void ChangeUnityPhysicsCount(System.Int32 boneIndex, System.Boolean sw) { }
        // RVA: 0x08999F18  token: 0x6000536
        public System.Void ResetFuturePrediction(System.Int32 boneIndex) { }
        // RVA: 0x08999D34  token: 0x6000539
        public System.Void ResetBoneFromTransform(System.Boolean fixedUpdate) { }
        // RVA: 0x089993FC  token: 0x600053A
        public System.Void ReadBoneFromTransform() { }
        // RVA: 0x08998CA4  token: 0x600053B
        public System.Void ConvertWorldToLocal() { }
        // RVA: 0x02312780  token: 0x600053C
        public System.Void WriteBoneToTransform(System.Int32 bufferIndex) { }
        // RVA: 0x08998EF0  token: 0x600053D
        public System.Void CopyBoneBuffer() { }
        // RVA: 0x03770A70  token: 0x600053E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000AD  // size: 0x28
    public class PhysicsManagerComponent : MagicaCloth.PhysicsManagerAccess
    {
        // Fields
        private readonly System.Collections.Generic.HashSet<MagicaCloth.CoreComponent> componentSet;  // 0x18
        private System.Collections.Generic.HashSet<MagicaCloth.ParticleComponent> dataUpdateParticleSet;  // 0x20

        // Properties
        System.Int32 ComponentCount { get; /* RVA: 0x0899A410 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000547
        public virtual System.Void Create() { }
        // RVA: 0x0350B670  token: 0x6000548
        public virtual System.Void Dispose() { }
        // RVA: 0x0899A164  token: 0x600054A
        public System.Collections.Generic.List<MagicaCloth.CoreComponent> GetComponentList() { }
        // RVA: 0x0899A014  token: 0x600054B
        public System.Void ComponentAction(System.Action<MagicaCloth.CoreComponent> act) { }
        // RVA: 0x0899A2AC  token: 0x600054C
        public System.Void UpdateComponentStatus() { }
        // RVA: 0x08999FC0  token: 0x600054D
        public System.Void AddComponent(MagicaCloth.CoreComponent comp) { }
        // RVA: 0x0899A1D8  token: 0x600054E
        public System.Void RemoveComponent(MagicaCloth.CoreComponent comp) { }
        // RVA: 0x0899A258  token: 0x600054F
        private System.Void ReserveDataUpdateParticleComponent(MagicaCloth.ParticleComponent comp) { }
        // RVA: 0x02312630  token: 0x6000550
        private System.Void DataUpdateParticleComponent() { }
        // RVA: 0x03770B70  token: 0x6000551
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000AE  // size: 0xF8
    public class PhysicsManagerCompute : MagicaCloth.PhysicsManagerAccess
    {
        // Fields
        private System.Int32 solverIteration;  // 0x18
        private System.Collections.Generic.List<MagicaCloth.PhysicsManagerConstraint> constraints;  // 0x20
        private MagicaCloth.ClampPositionConstraint <ClampPosition>k__BackingField;  // 0x28
        private MagicaCloth.ClampDistanceConstraint <ClampDistance>k__BackingField;  // 0x30
        private MagicaCloth.ClampRotationConstraint <ClampRotation>k__BackingField;  // 0x38
        private MagicaCloth.SpringConstraint <Spring>k__BackingField;  // 0x40
        private MagicaCloth.RestoreDistanceConstraint <RestoreDistance>k__BackingField;  // 0x48
        private MagicaCloth.RestoreRotationConstraint <RestoreRotation>k__BackingField;  // 0x50
        private MagicaCloth.TriangleBendConstraint <TriangleBend>k__BackingField;  // 0x58
        private MagicaCloth.ColliderCollisionConstraint <Collision>k__BackingField;  // 0x60
        private MagicaCloth.PenetrationConstraint <Penetration>k__BackingField;  // 0x68
        private MagicaCloth.ColliderExtrusionConstraint <ColliderExtrusion>k__BackingField;  // 0x70
        private MagicaCloth.TwistConstraint <Twist>k__BackingField;  // 0x78
        private MagicaCloth.CompositeRotationConstraint <CompositeRotation>k__BackingField;  // 0x80
        private System.Collections.Generic.List<MagicaCloth.PhysicsManagerWorker> workers;  // 0x88
        private MagicaCloth.RenderMeshWorker <RenderMeshWorker>k__BackingField;  // 0x90
        private MagicaCloth.VirtualMeshWorker <VirtualMeshWorker>k__BackingField;  // 0x98
        private MagicaCloth.MeshParticleWorker <MeshParticleWorker>k__BackingField;  // 0xa0
        private MagicaCloth.SpringMeshWorker <SpringMeshWorker>k__BackingField;  // 0xa8
        private MagicaCloth.AdjustRotationWorker <AdjustRotationWorker>k__BackingField;  // 0xb0
        private MagicaCloth.LineWorker <LineWorker>k__BackingField;  // 0xb8
        private MagicaCloth.TriangleWorker <TriangleWorker>k__BackingField;  // 0xc0
        private MagicaCloth.BaseSkinningWorker <BaseSkinningWorker>k__BackingField;  // 0xc8
        private Unity.Jobs.JobHandle jobHandle;  // 0xd0
        private System.Boolean runMasterJob;  // 0xe0
        private System.Int32 swapIndex;  // 0xe4
        private UnityEngine.Profiling.CustomSampler <SamplerCalcMesh>k__BackingField;  // 0xe8
        private UnityEngine.Profiling.CustomSampler <SamplerWriteMesh>k__BackingField;  // 0xf0

        // Properties
        MagicaCloth.ClampPositionConstraint ClampPosition { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }
        MagicaCloth.ClampDistanceConstraint ClampDistance { get; /* RVA: 0x01003830 */ set; /* RVA: 0x04270470 */ }
        MagicaCloth.ClampRotationConstraint ClampRotation { get; /* RVA: 0x03D4E2A0 */ set; /* RVA: 0x0388FF30 */ }
        MagicaCloth.SpringConstraint Spring { get; /* RVA: 0x03D4E2B0 */ set; /* RVA: 0x03CB2D80 */ }
        MagicaCloth.RestoreDistanceConstraint RestoreDistance { get; /* RVA: 0x03D4EA70 */ set; /* RVA: 0x02692290 */ }
        MagicaCloth.RestoreRotationConstraint RestoreRotation { get; /* RVA: 0x03D4EAF0 */ set; /* RVA: 0x02C926C0 */ }
        MagicaCloth.TriangleBendConstraint TriangleBend { get; /* RVA: 0x03D4EAA0 */ set; /* RVA: 0x03081D30 */ }
        MagicaCloth.ColliderCollisionConstraint Collision { get; /* RVA: 0x03D4EB00 */ set; /* RVA: 0x039274B0 */ }
        MagicaCloth.PenetrationConstraint Penetration { get; /* RVA: 0x03D4EAB0 */ set; /* RVA: 0x038C5570 */ }
        MagicaCloth.ColliderExtrusionConstraint ColliderExtrusion { get; /* RVA: 0x03D4EB30 */ set; /* RVA: 0x0519C3C8 */ }
        MagicaCloth.TwistConstraint Twist { get; /* RVA: 0x03D4EB20 */ set; /* RVA: 0x051DFCA4 */ }
        MagicaCloth.CompositeRotationConstraint CompositeRotation { get; /* RVA: 0x03D4EAE0 */ set; /* RVA: 0x051DFC94 */ }
        MagicaCloth.RenderMeshWorker RenderMeshWorker { get; /* RVA: 0x03D4EA90 */ set; /* RVA: 0x051DFCB4 */ }
        MagicaCloth.VirtualMeshWorker VirtualMeshWorker { get; /* RVA: 0x011AC510 */ set; /* RVA: 0x051417AC */ }
        MagicaCloth.MeshParticleWorker MeshParticleWorker { get; /* RVA: 0x03D4EA80 */ set; /* RVA: 0x04270264 */ }
        MagicaCloth.SpringMeshWorker SpringMeshWorker { get; /* RVA: 0x03D4EB10 */ set; /* RVA: 0x0554A7F4 */ }
        MagicaCloth.AdjustRotationWorker AdjustRotationWorker { get; /* RVA: 0x03D4EAD0 */ set; /* RVA: 0x02B47080 */ }
        MagicaCloth.LineWorker LineWorker { get; /* RVA: 0x03D4E750 */ set; /* RVA: 0x058AAF64 */ }
        MagicaCloth.TriangleWorker TriangleWorker { get; /* RVA: 0x03D50E60 */ set; /* RVA: 0x058B426C */ }
        MagicaCloth.BaseSkinningWorker BaseSkinningWorker { get; /* RVA: 0x03D4E7C0 */ set; /* RVA: 0x058B4280 */ }
        UnityEngine.Profiling.CustomSampler SamplerCalcMesh { get; /* RVA: 0x03D50EA0 */ set; /* RVA: 0x056A2B64 */ }
        UnityEngine.Profiling.CustomSampler SamplerWriteMesh { get; /* RVA: 0x03D51950 */ set; /* RVA: 0x058B408C */ }
        Unity.Jobs.JobHandle MasterJob { get; /* RVA: 0x03D5B210 */ set; /* RVA: 0x03D5B220 */ }
        System.Int32 SwapIndex { get; /* RVA: 0x03D50E70 */ }

        // Methods
        // RVA: 0x02E13DB0  token: 0x600057E
        public virtual System.Void Create() { }
        // RVA: 0x0899A450  token: 0x600057F
        public virtual System.Void Dispose() { }
        // RVA: 0x0899AB04  token: 0x6000580
        public System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: 0x0899BC00  token: 0x6000581
        private System.Void UpdateRestoreBone(MagicaCloth.PhysicsTeam.TeamUpdateMode updateMode) { }
        // RVA: 0x02312DD0  token: 0x6000582
        private System.Void UpdateReadBone() { }
        // RVA: 0x02312E20  token: 0x6000583
        private System.Void UpdateTeamAlways() { }
        // RVA: 0x02312F00  token: 0x6000584
        private System.Void UpdateStartSimulation(MagicaCloth.UpdateTimeManager update) { }
        // RVA: 0x02312D10  token: 0x6000585
        private System.Void UpdateCompleteSimulation() { }
        // RVA: 0x02312E60  token: 0x6000586
        private System.Void UpdateWriteBone() { }
        // RVA: 0x023139F0  token: 0x6000587
        private System.Void MeshCalculation() { }
        // RVA: 0x02312C70  token: 0x6000588
        private System.Void NormalWritingMesh() { }
        // RVA: 0x0899BB80  token: 0x6000589
        private System.Void UpdateReadWriteBone() { }
        // RVA: 0x0899BDD0  token: 0x600058A
        private System.Void UpdateSyncBuffer() { }
        // RVA: 0x0899BC54  token: 0x600058B
        private System.Void UpdateSwapBuffer() { }
        // RVA: 0x03D6E220  token: 0x600058E
        public System.Void InitJob() { }
        // RVA: 0x0899ADAC  token: 0x600058F
        public System.Void ScheduleJob() { }
        // RVA: 0x02312920  token: 0x6000590
        public System.Void CompleteJob() { }
        // RVA: 0x0899ADB4  token: 0x6000592
        private System.Void UpdatePhysics(System.Int32 updateCount, System.Int32 runCount, System.Single updatePower, System.Single updateDeltaTime) { }
        // RVA: 0x0899A674  token: 0x6000593
        private System.Void PostUpdatePhysics(System.Single updateDeltaTime) { }
        // RVA: 0x0899BEFC  token: 0x6000594
        private System.Void WarmupWorker() { }
        // RVA: 0x03770C30  token: 0x6000595
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000B2  // size: 0x20
    public abstract class PhysicsManagerConstraint
    {
        // Fields
        public System.Int32 iteration;  // 0x10
        private MagicaCloth.MagicaPhysicsManager <Manager>k__BackingField;  // 0x18

        // Properties
        MagicaCloth.MagicaPhysicsManager Manager { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }

        // Methods
        // RVA: 0x02E153B0  token: 0x600059C
        public System.Void Init(MagicaCloth.MagicaPhysicsManager manager) { }
        // RVA: -1  // abstract  token: 0x600059D
        public virtual System.Void Create() { }
        // RVA: -1  // abstract  token: 0x600059E
        public virtual System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: -1  // abstract  token: 0x600059F
        public virtual System.Void Release() { }
        // RVA: 0x03D4E340  token: 0x60005A0
        public virtual System.Int32 GetIterationCount() { }
        // RVA: -1  // abstract  token: 0x60005A1
        public virtual Unity.Jobs.JobHandle SolverConstraint(System.Int32 runCount, System.Single dtime, System.Single updatePower, System.Int32 iteration, Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03D51DD0  token: 0x60005A2
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000B3  // size: 0x188
    public class PhysicsManagerMeshData : MagicaCloth.PhysicsManagerAccess
    {
        // Fields
        public static System.UInt32 MeshFlag_Active;  // const
        public static System.UInt32 MeshFlag_Skinning;  // const
        public static System.UInt32 Meshflag_CalcNormal;  // const
        public static System.UInt32 Meshflag_CalcTangent;  // const
        public static System.UInt32 Meshflag_Pause;  // const
        public static System.UInt32 MeshFlag_ExistNormals;  // const
        public static System.UInt32 MeshFlag_ExistTangents;  // const
        public static System.UInt32 MeshFlag_ExistWeights;  // const
        public static System.UInt32 MeshFlag_UpdateUseVertexFront;  // const
        public static System.UInt32 MeshFlag_UpdateUseVertexBack;  // const
        public static System.UInt32 MeshFlag_FasterWrite;  // const
        public static System.UInt32 MeshFlag_MeshLink;  // const
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList;  // 0x18
        public System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedVirtualMeshIdToIndexDict;  // 0x20
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float2> sharedVirtualUvList;  // 0x28
        public MagicaCloth.FixedChunkNativeArray<System.UInt32> sharedVirtualVertexInfoList;  // 0x30
        public MagicaCloth.FixedChunkNativeArray<MagicaCloth.MeshData.VertexWeight> sharedVirtualWeightList;  // 0x38
        public MagicaCloth.FixedChunkNativeArray<System.Int32> sharedVirtualTriangleList;  // 0x40
        public MagicaCloth.FixedChunkNativeArray<System.UInt32> sharedVirtualVertexToTriangleInfoList;  // 0x48
        public MagicaCloth.FixedChunkNativeArray<System.Int32> sharedVirtualVertexToTriangleIndexList;  // 0x50
        public static System.Byte VirtualVertexFlag_Use;  // const
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;  // 0x58
        public MagicaCloth.FixedChunkNativeArray<System.Int16> virtualVertexMeshIndexList;  // 0x60
        public MagicaCloth.FixedChunkNativeArray<System.Byte> virtualVertexUseList;  // 0x68
        public MagicaCloth.FixedChunkNativeArray<System.Byte> virtualVertexFixList;  // 0x70
        public MagicaCloth.FixedChunkNativeArray<System.Byte> virtualVertexFlagList;  // 0x78
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> virtualPosList;  // 0x80
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> virtualRotList;  // 0x88
        public MagicaCloth.FixedChunkNativeArray<System.Int32> virtualTransformIndexList;  // 0x90
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> virtualTriangleNormalList;  // 0x98
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> virtualTriangleTangentList;  // 0xa0
        public MagicaCloth.FixedChunkNativeArray<System.UInt16> virtualTriangleMeshIndexList;  // 0xa8
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerMeshData.SharedChildMeshInfo> sharedChildMeshInfoList;  // 0xb0
        public System.Collections.Generic.Dictionary<System.Int64,System.Int32> sharedChildMeshIdToSharedVirtualMeshIndexDict;  // 0xb8
        public MagicaCloth.FixedChunkNativeArray<System.UInt32> sharedChildVertexInfoList;  // 0xc0
        public MagicaCloth.FixedChunkNativeArray<MagicaCloth.MeshData.VertexWeight> sharedChildWeightList;  // 0xc8
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerMeshData.SharedRenderMeshInfo> sharedRenderMeshInfoList;  // 0xd0
        public System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedRenderMeshIdToIndexDict;  // 0xd8
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> sharedRenderVertices;  // 0xe0
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> sharedRenderNormals;  // 0xe8
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float4> sharedRenderTangents;  // 0xf0
        public MagicaCloth.FixedChunkNativeArray<System.Byte> sharedBonesPerVertexList;  // 0xf8
        public MagicaCloth.FixedChunkNativeArray<System.Int32> sharedBonesPerVertexStartList;  // 0x100
        public MagicaCloth.FixedChunkNativeArray<UnityEngine.BoneWeight1> sharedBoneWeightList;  // 0x108
        public static System.UInt32 RenderVertexFlag_Use;  // const
        public static System.Int32 MaxRenderMeshLinkCount;  // const
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerMeshData.RenderMeshInfo> renderMeshInfoList;  // 0x110
        public static System.UInt32 RenderStateFlag_Use;  // const
        public static System.UInt32 RenderStateFlag_ExistNormal;  // const
        public static System.UInt32 RenderStateFlag_ExistTangent;  // const
        public static System.UInt32 RenderStateFlag_FasterWrite;  // const
        public static System.UInt32 RenderStateFlag_DelayedCalculated;  // const
        public System.Collections.Generic.Dictionary<System.Int32,MagicaCloth.PhysicsManagerMeshData.RenderMeshState> renderMeshStateDict;  // 0x118
        public MagicaCloth.FixedChunkNativeArray<System.UInt32> renderVertexFlagList;  // 0x120
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> renderPosList;  // 0x128
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> renderNormalList;  // 0x130
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float4> renderTangentList;  // 0x138
        public MagicaCloth.FixedChunkNativeArray<UnityEngine.BoneWeight1> renderBoneWeightList;  // 0x140
        private MagicaCloth.DoubleComputeBuffer<Unity.Mathematics.float3> renderPosBuffer;  // 0x148
        private MagicaCloth.DoubleComputeBuffer<Unity.Mathematics.float3> renderNormalBuffer;  // 0x150
        private UnityEngine.ComputeBuffer emptyByteAddressBuffer;  // 0x158
        private System.Boolean isBeginWrite;  // 0x160
        private System.Collections.Generic.HashSet<MagicaCloth.BaseMeshDeformer> renderMeshSet;  // 0x168
        private System.Collections.Generic.List<MagicaCloth.RenderMeshDeformer> normalWriteList;  // 0x170
        private System.Collections.Generic.List<MagicaCloth.RenderMeshDeformer> fasterWritePositionList;  // 0x178
        private System.Collections.Generic.List<MagicaCloth.RenderMeshDeformer> fasterWritePositionNormalList;  // 0x180

        // Properties
        System.Int32 SharedVirtualMeshCount { get; /* RVA: 0x089A2880 */ }
        System.Int32 VirtualMeshCount { get; /* RVA: 0x02312B10 */ }
        System.Int32 VirtualMeshVertexCount { get; /* RVA: 0x089A2A8C */ }
        System.Int32 VirtualMeshTriangleCount { get; /* RVA: 0x089A296C */ }
        System.Int32 VirtualMeshVertexUseCount { get; /* RVA: 0x089A2B08 */ }
        System.Int32 VirtualMeshUseCount { get; /* RVA: 0x089A29E8 */ }
        System.Int32 VirtualMeshPauseCount { get; /* RVA: 0x089A28C8 */ }
        System.Int32 SharedRenderMeshCount { get; /* RVA: 0x089A2838 */ }
        System.Int32 SharedChildMeshCount { get; /* RVA: 0x089A27F0 */ }
        System.Int32 RenderMeshCount { get; /* RVA: 0x089A22E8 */ }
        System.Int32 RenderMeshVertexCount { get; /* RVA: 0x089A25D4 */ }
        System.Int32 RenderMeshUseCount { get; /* RVA: 0x089A247C */ }
        System.Int32 RenderMeshVertexUseCount { get; /* RVA: 0x089A26AC */ }
        System.Int32 RenderMeshPauseCount { get; /* RVA: 0x089A2330 */ }

        // Methods
        // RVA: 0x03541480  token: 0x60005A3
        public virtual System.Void Create() { }
        // RVA: 0x0899E940  token: 0x60005A4
        public virtual System.Void Dispose() { }
        // RVA: 0x0899BF94  token: 0x60005A5
        public System.Void AddMesh(MagicaCloth.BaseMeshDeformer bmesh) { }
        // RVA: 0x0899FAC0  token: 0x60005A6
        public System.Void RemoveMesh(MagicaCloth.BaseMeshDeformer bmesh) { }
        // RVA: 0x0899D02C  token: 0x60005A7
        public System.Int32 AddVirtualMesh(System.Int32 uid, System.Int32 vertexCount, System.Int32 weightCount, System.Int32 boneCount, System.Int32 triangleCount, System.Int32 vertexToTriangleIndexCount, UnityEngine.Transform transform) { }
        // RVA: 0x0899F31C  token: 0x60005A8
        public System.Boolean IsEmptySharedVirtualMesh(System.Int32 uid) { }
        // RVA: 0x089A18F8  token: 0x60005A9
        public System.Void SetSharedVirtualMeshData(System.Int32 virtualMeshIndex, System.UInt32[] sharedVertexInfoList, MagicaCloth.MeshData.VertexWeight[] sharedWeightList, UnityEngine.Vector2[] sharedUv, System.Int32[] sharedTriangles, System.UInt32[] vertexToTriangleInfoList, System.Int32[] vertexToTriangleIndexList) { }
        // RVA: 0x089A08BC  token: 0x60005AA
        public System.Void RemoveVirtualMesh(System.Int32 virtualMeshIndex) { }
        // RVA: 0x0899EE04  token: 0x60005AB
        public System.Boolean ExistsVirtualMesh(System.Int32 virtualMeshIndex) { }
        // RVA: 0x0899F0C8  token: 0x60005AC
        public MagicaCloth.PhysicsManagerMeshData.VirtualMeshInfo GetVirtualMeshInfo(System.Int32 virtualMeshIndex) { }
        // RVA: 0x0899F4D0  token: 0x60005AD
        public System.Boolean IsUseVirtualMesh(System.Int32 virtualMeshIndex) { }
        // RVA: 0x0899F20C  token: 0x60005AE
        public System.Boolean IsActiveVirtualMesh(System.Int32 virtualMeshIndex) { }
        // RVA: 0x089A1B98  token: 0x60005AF
        public System.Void SetVirtualMeshActive(System.Int32 virtualMeshIndex, System.Boolean sw) { }
        // RVA: 0x0899CBEC  token: 0x60005B0
        public System.Void AddUseVirtualMesh(System.Int32 virtualMeshIndex) { }
        // RVA: 0x089A047C  token: 0x60005B1
        public System.Void RemoveUseVirtualMesh(System.Int32 virtualMeshIndex) { }
        // RVA: 0x0899CCC8  token: 0x60005B2
        public System.Boolean AddUseVirtualVertex(System.Int32 virtualMeshIndex, System.Int32 vindex, System.Boolean fix) { }
        // RVA: 0x089A0558  token: 0x60005B3
        public System.Boolean RemoveUseVirtualVertex(System.Int32 virtualMeshIndex, System.Int32 vindex, System.Boolean fix) { }
        // RVA: 0x0899E27C  token: 0x60005B4
        public System.Void CopyToVirtualMeshWorldData(System.Int32 virtualMeshIndex, UnityEngine.Vector3[] vertices, UnityEngine.Vector3[] normals, UnityEngine.Vector3[] tangents) { }
        // RVA: 0x0899CE3C  token: 0x60005B5
        public System.Void AddVirtualMeshBone(System.Int32 virtualMeshIndex, System.Collections.Generic.List<UnityEngine.Transform> boneList) { }
        // RVA: 0x089A06CC  token: 0x60005B6
        public System.Void RemoveVirtualMeshBone(System.Int32 virtualMeshIndex) { }
        // RVA: 0x089A0D88  token: 0x60005B7
        public System.Void ResetFuturePredictionVirtualMeshBone(System.Int32 virtualMeshIndex) { }
        // RVA: 0x0899D710  token: 0x60005B8
        public System.Void ChangeVirtualMeshUseUnityPhysics(System.Int32 virtualMeshIndex, System.Boolean sw) { }
        // RVA: 0x089A1C80  token: 0x60005B9
        public System.Void SetVirtualMeshFlag(System.Int32 virtualMeshIndex, System.UInt32 flag, System.Boolean sw) { }
        // RVA: 0x0899C79C  token: 0x60005C1
        public System.Int32 AddSharedChildMesh(System.Int64 cuid, System.Int32 virtualMeshIndex, System.Int32 vertexCount, System.Int32 weightCount) { }
        // RVA: 0x0899F268  token: 0x60005C2
        public System.Boolean IsEmptySharedChildMesh(System.Int64 cuid) { }
        // RVA: 0x089A17E0  token: 0x60005C3
        public System.Void SetSharedChildMeshData(System.Int32 sharedMeshIndex, System.UInt32[] sharedVertexInfoList, MagicaCloth.MeshData.VertexWeight[] sharedVertexWeightList) { }
        // RVA: 0x089A0148  token: 0x60005C4
        public System.Void RemoveSharedChildMesh(System.Int32 sharedChildMeshIndex) { }
        // RVA: 0x0899C17C  token: 0x60005C7
        public System.Int32 AddRenderMesh(System.Int32 uid, System.Boolean isSkinning, System.Boolean isFasterWrite, UnityEngine.Vector3 baseScale, System.Int32 vertexCount, System.Int32 rendererBoneIndex, System.Int32 boneWeightCount) { }
        // RVA: 0x089A1FA4  token: 0x60005C8
        public System.Void UpdateMeshState(System.Int32 renderMeshIndex) { }
        // RVA: 0x0899C00C  token: 0x60005C9
        public System.Void AddRenderMeshBone(System.Int32 renderMeshIndex, UnityEngine.Transform rendererTransform) { }
        // RVA: 0x0899F2C4  token: 0x60005CA
        public System.Boolean IsEmptySharedRenderMesh(System.Int32 uid) { }
        // RVA: 0x089A1364  token: 0x60005CB
        public System.Void SetRenderSharedMeshData(System.Int32 renderMeshIndex, System.Boolean isSkinning, UnityEngine.Vector3[] sharedVertices, UnityEngine.Vector3[] sharedNormals, UnityEngine.Vector4[] sharedTangents, Unity.Collections.NativeArray<System.Byte> sharedBonesPerVertex, Unity.Collections.NativeArray<UnityEngine.BoneWeight1> sharedBoneWeights) { }
        // RVA: 0x0899FCA8  token: 0x60005CC
        public System.Void RemoveRenderMesh(System.Int32 renderMeshIndex) { }
        // RVA: 0x0899FB44  token: 0x60005CD
        public System.Void RemoveRenderMeshBone(System.Int32 renderMeshIndex) { }
        // RVA: 0x0899D5D4  token: 0x60005CE
        public System.Void ChangeRenderMeshUseUnityPhysics(System.Int32 renderMeshIndex, System.Boolean sw) { }
        // RVA: 0x0899F46C  token: 0x60005CF
        public System.Boolean IsUseRenderMesh(System.Int32 renderMeshIndex) { }
        // RVA: 0x0899F150  token: 0x60005D0
        public System.Boolean IsActiveRenderMesh(System.Int32 renderMeshIndex) { }
        // RVA: 0x089A11E4  token: 0x60005D1
        public System.Void SetRenderMeshFlag(System.Int32 renderMeshIndex, System.UInt32 flag, System.Boolean sw) { }
        // RVA: 0x0899F374  token: 0x60005D2
        public System.Boolean IsRenderMeshFlag(System.Int32 renderMeshIndex, System.UInt32 flag) { }
        // RVA: 0x089A0FF0  token: 0x60005D3
        public System.Void SetRenderMeshActive(System.Int32 renderMeshIndex, System.Boolean sw) { }
        // RVA: 0x0899CA2C  token: 0x60005D4
        public System.Void AddUseRenderMesh(System.Int32 renderMeshIndex) { }
        // RVA: 0x089A02BC  token: 0x60005D5
        public System.Void RemoveUseRenderMesh(System.Int32 renderMeshIndex) { }
        // RVA: 0x0899F560  token: 0x60005D6
        public System.Void LinkRenderMesh(System.Int32 renderMeshIndex, System.Int32 childMeshVertexStart, System.Int32 childMeshWeightStart, System.Int32 virtualMeshVertexStart, System.Int32 sharedVirtualMeshVertexStart) { }
        // RVA: 0x089A1D74  token: 0x60005D7
        public System.Void UnlinkRenderMesh(System.Int32 renderMeshIndex, System.Int32 childMeshVertexStart, System.Int32 childMeshWeightStart, System.Int32 virtualMeshVertexStart, System.Int32 sharedVirtualMeshVertexStart) { }
        // RVA: 0x0899DB74  token: 0x60005D8
        private System.Void CopyToRenderMeshLocalPositionData(System.Int32 renderMeshIndex, UnityEngine.Mesh mesh, System.Int32 bufferIndex) { }
        // RVA: 0x0899D9E0  token: 0x60005D9
        private System.Void CopyToRenderMeshLocalNormalTangentData(System.Int32 renderMeshIndex, UnityEngine.Mesh mesh, System.Int32 bufferIndex, System.Boolean normal, System.Boolean tangent) { }
        // RVA: 0x0899D85C  token: 0x60005DA
        private System.Void CopyToRenderMeshBoneWeightData(System.Int32 renderMeshIndex, UnityEngine.Mesh mesh, UnityEngine.Mesh sharedMesh, System.Int32 bufferIndex) { }
        // RVA: 0x0899DC64  token: 0x60005DB
        private System.Void CopyToRenderMeshWorldData(System.Int32 renderMeshIndex, UnityEngine.Transform target, UnityEngine.Vector3[] vertices, UnityEngine.Vector3[] normals, UnityEngine.Vector3[] tangents) { }
        // RVA: 0x0899EEFC  token: 0x60005DC
        private System.Collections.Generic.List<System.Int32> GetVertexUseList(System.Int32 renderMeshIndex) { }
        // RVA: 0x089A0E88  token: 0x60005E2
        private System.Void SetDelayedCalculatedFlag() { }
        // RVA: 0x02312340  token: 0x60005E3
        private System.Void ClearWritingList() { }
        // RVA: 0x0899F764  token: 0x60005E4
        private System.Void MeshCalculation(System.Int32 bufferIndex) { }
        // RVA: 0x0899F958  token: 0x60005E5
        private System.Void NormalWriting(System.Int32 bufferIndex) { }
        // RVA: 0x0899DFD4  token: 0x60005E6
        private System.Void CopyToRenderVertexBuffer(System.Int32 renderMeshIndex, System.Int32 bufferIndex, UnityEngine.GraphicsBuffer vertexBuffer, System.Boolean normal, UnityEngine.ComputeShader compute, System.Int32 kernel, System.Int32 index) { }
        // RVA: 0x089A205C  token: 0x60005E7
        private System.Void UpdateVertexBuffer() { }
        // RVA: 0x02312A00  token: 0x60005E8
        private System.Void FinishVertexBuffer() { }
        // RVA: 0x0899EE58  token: 0x60005E9
        private System.Void FasterWriting(System.Int32 bufferIndex) { }
        // RVA: 0x0899E4D8  token: 0x60005EA
        private System.Void DispatchWriting(System.Int32 kernel, System.Collections.Generic.List<MagicaCloth.RenderMeshDeformer> rlist, System.Int32 bufferIndex) { }
        // RVA: 0x03770D00  token: 0x60005EB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000BC  // size: 0x100
    public class PhysicsManagerParticleData : MagicaCloth.PhysicsManagerAccess
    {
        // Fields
        public static System.UInt32 Flag_Enable;  // const
        public static System.UInt32 Flag_Kinematic;  // const
        public static System.UInt32 Flag_Hold;  // const
        public static System.UInt32 Flag_Collider;  // const
        public static System.UInt32 Flag_Plane;  // const
        public static System.UInt32 Flag_CapsuleX;  // const
        public static System.UInt32 Flag_CapsuleY;  // const
        public static System.UInt32 Flag_CapsuleZ;  // const
        public static System.UInt32 Flag_Box;  // const
        public static System.UInt32 Flag_TriangleRotation;  // const
        public static System.UInt32 Flag_Transform_Read_Pos;  // const
        public static System.UInt32 Flag_Transform_Read_Rot;  // const
        public static System.UInt32 Flag_Transform_Read_Base;  // const
        public static System.UInt32 Flag_Transform_Read_Local;  // const
        public static System.UInt32 Flag_Transform_Read_Scl;  // const
        public static System.UInt32 Flag_Transform_Write;  // const
        public static System.UInt32 Flag_Transform_Restore;  // const
        public static System.UInt32 Flag_Transform_UnityPhysics;  // const
        public static System.UInt32 Flag_Transform_Parent;  // const
        public static System.UInt32 Flag_Step_Update;  // const
        public static System.UInt32 Flag_Reset_Position;  // const
        public MagicaCloth.FixedChunkNativeArray<MagicaCloth.PhysicsManagerParticleData.ParticleFlag> flagList;  // 0x18
        public MagicaCloth.FixedChunkNativeArray<System.Int32> teamIdList;  // 0x20
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> posList;  // 0x28
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> rotList;  // 0x30
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> oldPosList;  // 0x38
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> oldRotList;  // 0x40
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> oldSlowPosList;  // 0x48
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> localPosList;  // 0x50
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> basePosList;  // 0x58
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> baseRotList;  // 0x60
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> snapBasePosList;  // 0x68
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> snapBaseRotList;  // 0x70
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> oldBasePosList;  // 0x78
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> oldBaseRotList;  // 0x80
        public MagicaCloth.FixedChunkNativeArray<System.Single> depthList;  // 0x88
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> radiusList;  // 0x90
        public MagicaCloth.FixedChunkNativeArray<System.Int32> restoreTransformIndexList;  // 0x98
        public MagicaCloth.FixedChunkNativeArray<System.Int32> transformIndexList;  // 0xa0
        public MagicaCloth.FixedChunkNativeArray<System.Single> frictionList;  // 0xa8
        public MagicaCloth.FixedChunkNativeArray<System.Single> staticFrictionList;  // 0xb0
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> velocityList;  // 0xb8
        public MagicaCloth.FixedChunkNativeArray<System.Int32> collisionLinkIdList;  // 0xc0
        public MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> collisionNormalList;  // 0xc8
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> nextPos0List;  // 0xd0
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> nextPos1List;  // 0xd8
        private System.Int32 nextPosSwitch;  // 0xe0
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> nextRot0List;  // 0xe8
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> nextRot1List;  // 0xf0
        private System.Int32 nextRotSwitch;  // 0xf8
        private System.Int32 colliderCount;  // 0xfc

        // Properties
        System.Int32 Count { get; /* RVA: 0x089A4A1C */ }
        System.Int32 Length { get; /* RVA: 0x089A4AAC */ }
        System.Int32 ColliderCount { get; /* RVA: 0x03D59CE0 */ }
        MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> InNextPosList { get; /* RVA: 0x089A4A74 */ }
        MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float3> OutNextPosList { get; /* RVA: 0x089A4AEC */ }
        MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> InNextRotList { get; /* RVA: 0x089A4A90 */ }
        MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.quaternion> OutNextRotList { get; /* RVA: 0x089A4B08 */ }

        // Methods
        // RVA: 0x03541E60  token: 0x6000605
        public virtual System.Void Create() { }
        // RVA: 0x089A3564  token: 0x6000606
        public virtual System.Void Dispose() { }
        // RVA: 0x035425C0  token: 0x6000607
        public MagicaCloth.ChunkData CreateParticle(System.UInt32 flag, System.Int32 team, Unity.Mathematics.float3 wpos, Unity.Mathematics.quaternion wrot, System.Single depth, Unity.Mathematics.float3 radius, Unity.Mathematics.float3 targetLocalPos) { }
        // RVA: 0x089A2B90  token: 0x6000608
        public MagicaCloth.ChunkData CreateParticle(System.Int32 team, System.Int32 count, System.Func<System.Int32,System.UInt32> funcFlag, System.Func<System.Int32,Unity.Mathematics.float3> funcWpos, System.Func<System.Int32,Unity.Mathematics.quaternion> funcWrot, System.Func<System.Int32,System.Single> funcDepth, System.Func<System.Int32,Unity.Mathematics.float3> funcRadius, System.Func<System.Int32,Unity.Mathematics.float3> funcTargetLocalPos) { }
        // RVA: 0x089A3938  token: 0x6000609
        public System.Void RemoveParticle(MagicaCloth.ChunkData c) { }
        // RVA: 0x03542BF0  token: 0x600060A
        public System.Void SetEnable(MagicaCloth.ChunkData c, System.Boolean sw, System.Func<System.Int32,UnityEngine.Transform> funcTarget, System.Func<System.Int32,Unity.Mathematics.float3> funcLpos, System.Func<System.Int32,Unity.Mathematics.quaternion> funcLrot) { }
        // RVA: 0x089A3E94  token: 0x600060B
        public System.Void SetRadius(System.Int32 index, Unity.Mathematics.float3 radius) { }
        // RVA: 0x089A3E00  token: 0x600060C
        public System.Void SetLocalPos(System.Int32 index, UnityEngine.Vector3 lpos) { }
        // RVA: 0x089A38D0  token: 0x6000610
        public System.Boolean IsValid(System.Int32 index) { }
        // RVA: 0x089A3880  token: 0x6000611
        public System.Int32 GetTeamId(System.Int32 index) { }
        // RVA: 0x089A3D90  token: 0x6000612
        public System.Void ResetFuturePredictionTransform(System.Int32 index) { }
        // RVA: 0x089A3D40  token: 0x6000613
        public System.Void ResetFuturePredictionTransform(MagicaCloth.ChunkData c) { }
        // RVA: 0x03D6E230  token: 0x6000616
        public System.Void SwitchingNextPosList() { }
        // RVA: 0x03D6E250  token: 0x6000619
        public System.Void SwitchingNextRotList() { }
        // RVA: 0x089A3F04  token: 0x600061A
        public System.Void UpdateBoneToParticle() { }
        // RVA: 0x089A46C8  token: 0x600061B
        public System.Void UpdateResetParticle() { }
        // RVA: 0x089A4338  token: 0x600061C
        public System.Boolean UpdateParticleToBone() { }
        // RVA: 0x0350B670  token: 0x600061D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C1  // size: 0x80
    public class PhysicsManagerTeamData : MagicaCloth.PhysicsManagerAccess
    {
        // Fields
        public static System.UInt32 Flag_Enable;  // const
        public static System.UInt32 Flag_Interpolate;  // const
        public static System.UInt32 Flag_FixedNonRotation;  // const
        public static System.UInt32 Flag_AnimatedPose;  // const
        public static System.UInt32 Flag_IgnoreClampPositionVelocity;  // const
        public static System.UInt32 Flag_Collision;  // const
        public static System.UInt32 Flag_AfterCollision;  // const
        public static System.UInt32 Flag_UpdatePhysics;  // const
        public static System.UInt32 Flag_Pause;  // const
        public static System.UInt32 Flag_Reset_WorldInfluence;  // const
        public static System.UInt32 Flag_Reset_Position;  // const
        public static System.UInt32 Flag_Reset_Keep;  // const
        public static System.UInt32 Flag_Wind;  // const
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerTeamData.TeamData> teamDataList;  // 0x18
        public MagicaCloth.FixedNativeList<MagicaCloth.CurveParam> teamMassList;  // 0x20
        public MagicaCloth.FixedNativeList<MagicaCloth.CurveParam> teamGravityList;  // 0x28
        public MagicaCloth.FixedNativeList<MagicaCloth.CurveParam> teamDragList;  // 0x30
        public MagicaCloth.FixedNativeList<MagicaCloth.CurveParam> teamMaxVelocityList;  // 0x38
        public MagicaCloth.FixedNativeList<MagicaCloth.CurveParam> teamDepthInfluenceList;  // 0x40
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerTeamData.WorldInfluence> teamWorldInfluenceList;  // 0x48
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerTeamData.WindInfo> teamWindInfoList;  // 0x50
        public MagicaCloth.FixedMultiNativeList<System.Int32> colliderList;  // 0x58
        public MagicaCloth.FixedMultiNativeList<System.Int32> skinningBoneList;  // 0x60
        private System.Collections.Generic.Dictionary<System.Int32,MagicaCloth.PhysicsTeam> teamComponentDict;  // 0x68
        private System.Int32 activeTeamCount;  // 0x70
        private System.Int32 normalUpdateCount;  // 0x74
        private System.Int32 physicsUpdateCount;  // 0x78

        // Properties
        System.Int32 TeamCount { get; /* RVA: 0x089B46B8 */ }
        System.Int32 TeamLength { get; /* RVA: 0x089B4700 */ }
        System.Int32 ActiveTeamCount { get; /* RVA: 0x03D4F0C0 */ }
        System.Int32 ColliderCount { get; /* RVA: 0x089B4574 */ }
        System.Int32 NormalUpdateCount { get; /* RVA: 0x03D4F0D0 */ }
        System.Int32 PhysicsUpdateCount { get; /* RVA: 0x03D4EC40 */ }
        System.Int32 PauseCount { get; /* RVA: 0x089B45C0 */ }

        // Methods
        // RVA: 0x0243DC60  token: 0x6000631
        public virtual System.Void Create() { }
        // RVA: 0x089B1340  token: 0x6000632
        public virtual System.Void Dispose() { }
        // RVA: 0x0243DF20  token: 0x600063A
        public System.Int32 CreateTeam(MagicaCloth.PhysicsTeam team, System.UInt32 flag) { }
        // RVA: 0x089B22D0  token: 0x600063B
        public System.Void RemoveTeam(System.Int32 teamId) { }
        // RVA: 0x089B30E0  token: 0x600063C
        public System.Void SetEnable(System.Int32 teamId, System.Boolean sw) { }
        // RVA: 0x089B18D8  token: 0x600063D
        public System.Boolean IsValid(System.Int32 teamId) { }
        // RVA: 0x089B187C  token: 0x600063E
        public System.Boolean IsValidData(System.Int32 teamId) { }
        // RVA: 0x089B16E8  token: 0x600063F
        public System.Boolean IsActive(System.Int32 teamId) { }
        // RVA: 0x089B3284  token: 0x6000640
        public System.Void SetFlag(System.Int32 teamId, System.UInt32 flag, System.Boolean sw) { }
        // RVA: 0x089B17AC  token: 0x6000641
        public System.Boolean IsFlag(System.Int32 teamId, System.UInt32 flag) { }
        // RVA: 0x089B3B2C  token: 0x6000642
        public System.Void SetParticleChunk(System.Int32 teamId, MagicaCloth.ChunkData chunk) { }
        // RVA: 0x089B33FC  token: 0x6000643
        public System.Void SetFriction(System.Int32 teamId, System.Single dynamicFriction, System.Single staticFriction) { }
        // RVA: 0x089B38E4  token: 0x6000644
        public System.Void SetMass(System.Int32 teamId, MagicaCloth.BezierParam mass) { }
        // RVA: 0x089B3704  token: 0x6000645
        public System.Void SetGravity(System.Int32 teamId, MagicaCloth.BezierParam gravity) { }
        // RVA: 0x089B354C  token: 0x6000646
        public System.Void SetGravityDirection(System.Int32 teamId, Unity.Mathematics.float3 dir) { }
        // RVA: 0x089B3060  token: 0x6000647
        public System.Void SetDrag(System.Int32 teamId, MagicaCloth.BezierParam drag) { }
        // RVA: 0x089B3964  token: 0x6000648
        public System.Void SetMaxVelocity(System.Int32 teamId, MagicaCloth.BezierParam maxVelocity) { }
        // RVA: 0x089B3108  token: 0x6000649
        public System.Void SetExternalForce(System.Int32 teamId, System.Single massInfluence, System.Single windInfluence, System.Single windRandomScale, System.Single windSynchronization) { }
        // RVA: 0x089B2FE0  token: 0x600064A
        public System.Void SetDepthInfluence(System.Int32 teamId, MagicaCloth.BezierParam depthInfluence) { }
        // RVA: 0x089B41A0  token: 0x600064B
        public System.Void SetWorldInfluence(System.Int32 teamId, System.Single maxSpeed, System.Single maxRotatinSpeed, MagicaCloth.BezierParam moveInfluence, MagicaCloth.BezierParam rotInfluence, System.Boolean resetTeleport, System.Single teleportDistance, System.Single teleportRotation, System.Single resetStabilizationTime, MagicaCloth.ClothParams.TeleportMode teleportMode, System.Boolean useClampRotation, MagicaCloth.BezierParam clampRotation) { }
        // RVA: 0x089B0970  token: 0x600064C
        private System.Single CalcClampRotationLimit(System.Boolean useClampRotation, MagicaCloth.BezierParam clampRotation) { }
        // RVA: 0x089B43AC  token: 0x600064D
        public System.Void SetWorldInfluence(System.Int32 teamId, System.Single maxSpeed, System.Single maxRotationSpeed, MagicaCloth.BezierParam moveInfluence, MagicaCloth.BezierParam rotInfluence) { }
        // RVA: 0x089B29F0  token: 0x600064E
        public System.Void SetAfterTeleport(System.Int32 teamId, System.Boolean resetTeleport, System.Single teleportDistance, System.Single teleportRotation, MagicaCloth.ClothParams.TeleportMode teleportMode) { }
        // RVA: 0x089B3DAC  token: 0x600064F
        public System.Void SetStabilizationTime(System.Int32 teamId, System.Single resetStabilizationTime) { }
        // RVA: 0x089B27EC  token: 0x6000650
        public System.Void ResetWorldInfluenceTarget(System.Int32 teamId, UnityEngine.Transform target) { }
        // RVA: 0x089B2E58  token: 0x6000651
        public System.Void SetClampRotation(System.Int32 teamId, System.Boolean useClampRotation, MagicaCloth.BezierParam clampRotation) { }
        // RVA: 0x089B3C6C  token: 0x6000652
        public System.Void SetSelfCollisionRange(System.Int32 teamId, System.Single range) { }
        // RVA: 0x089B2CCC  token: 0x6000653
        public System.Void SetBoneIndex(System.Int32 teamId, System.Int32 boneIndex, UnityEngine.Vector3 initScale) { }
        // RVA: 0x089B0354  token: 0x6000654
        private System.Void AddColliderParticle(System.Int32 teamId, System.Int32 particleIndex) { }
        // RVA: 0x089B1DA8  token: 0x6000655
        private System.Void RemoveColliderParticle(System.Int32 teamId, System.Int32 particleIndex) { }
        // RVA: 0x089B1FA4  token: 0x6000656
        private System.Void RemoveCollider(System.Int32 teamId, MagicaCloth.ColliderComponent collider) { }
        // RVA: 0x089B2424  token: 0x6000657
        public System.Void ResetFuturePredictionCollidere(System.Int32 teamId) { }
        // RVA: 0x089B057C  token: 0x6000658
        public System.Void AddSkinningBoneIndex(System.Int32 teamId, System.Collections.Generic.List<UnityEngine.Transform> boneList) { }
        // RVA: 0x089B2070  token: 0x6000659
        public System.Void RemoveSkinningBoneIndex(System.Int32 teamId) { }
        // RVA: 0x089B3F0C  token: 0x600065A
        public System.Void SetTimeScale(System.Int32 teamId, System.Single timeScale) { }
        // RVA: 0x089B162C  token: 0x600065B
        public System.Single GetTimeScale(System.Int32 teamId) { }
        // RVA: 0x089B2B84  token: 0x600065C
        public System.Void SetBlendRatio(System.Int32 teamId, System.Single blendRatio) { }
        // RVA: 0x089B14B4  token: 0x600065D
        public System.Single GetBlendRatio(System.Int32 teamId) { }
        // RVA: 0x089B39E4  token: 0x600065E
        public System.Void SetOutPhysicsPoseBlendRatio(System.Int32 teamId, System.Single blendRatio) { }
        // RVA: 0x089B1570  token: 0x600065F
        public System.Single GetOutPhysicsPoseBlendRatio(System.Int32 teamId) { }
        // RVA: 0x089B3784  token: 0x6000660
        public System.Void SetImpactForce(System.Int32 teamId, Unity.Mathematics.float3 force, MagicaCloth.PhysicsManagerTeamData.ForceMode mode) { }
        // RVA: 0x089B25F8  token: 0x6000661
        public System.Void ResetStabilizationTime(System.Int32 teamId, System.Single resetStabilizationTime) { }
        // RVA: 0x089B4054  token: 0x6000662
        public System.Void SetUpdateMode(System.Int32 teamId, MagicaCloth.PhysicsTeam.TeamUpdateMode updateMode) { }
        // RVA: 0x089B112C  token: 0x6000663
        public System.Void ChangeUseUnityPhysics(System.Int32 teamId, System.Boolean sw) { }
        // RVA: 0x089B1010  token: 0x6000664
        private System.Void ChangeParticleUseUnityPhysics(System.Int32 pindex, System.Boolean unityPhysics) { }
        // RVA: 0x089B0DB8  token: 0x6000665
        private System.Void ChangeBoneFlag(System.Int32 teamId, MagicaCloth.PhysicsTeam.TeamCullingMode cullingMode, System.Boolean isCalculation) { }
        // RVA: 0x02639760  token: 0x6000666
        private System.Void EarlyUpdateTeamAlways() { }
        // RVA: 0x02639F30  token: 0x6000667
        private System.Void PreUpdateTeamAlways() { }
        // RVA: 0x089B09CC  token: 0x6000668
        private System.Int32 CalcMaxUpdateCount(System.Int32 ups, System.Single deltaTime, System.Single physicsDeltaTime, System.Single updateDeltaTime) { }
        // RVA: 0x089B1A48  token: 0x6000669
        private System.Void PreUpdateTeamData(System.Single deltaTime, System.Single physicsDeltaTime, System.Single updateDeltaTime, System.Int32 ups, System.Int32 maxUpdateCount) { }
        // RVA: 0x089B18E4  token: 0x600066A
        private System.Void PostUpdateTeamData() { }
        // RVA: 0x03770AF0  token: 0x600066B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000C9  // size: 0x20
    public class PhysicsManagerWindData : MagicaCloth.PhysicsManagerAccess
    {
        // Fields
        public static System.UInt32 Flag_Enable;  // const
        public static System.UInt32 Flag_Addition;  // const
        public MagicaCloth.FixedNativeList<MagicaCloth.PhysicsManagerWindData.WindData> windDataList;  // 0x18

        // Properties
        System.Int32 Count { get; /* RVA: 0x089B4F78 */ }

        // Methods
        // RVA: 0x03CFCE70  token: 0x600067C
        public virtual System.Void Create() { }
        // RVA: 0x089B4AB8  token: 0x600067D
        public virtual System.Void Dispose() { }
        // RVA: 0x089B497C  token: 0x600067E
        public System.Int32 CreateWind(MagicaCloth.PhysicsManagerWindData.WindType windType, MagicaCloth.PhysicsManagerWindData.ShapeType shapeType, Unity.Mathematics.float3 areaSize, System.Boolean addition, System.Single main, System.Single turbulence, System.Single frequency, Unity.Mathematics.float3 direction, MagicaCloth.PhysicsManagerWindData.DirectionType directinType, System.Single areaVolume, System.Single areaLength, MagicaCloth.BezierParam attenuation) { }
        // RVA: 0x089B4B60  token: 0x600067F
        public System.Void RemoveWind(System.Int32 windId) { }
        // RVA: 0x089B4BB8  token: 0x6000680
        public System.Void SetEnable(System.Int32 windId, System.Boolean sw, UnityEngine.Transform target) { }
        // RVA: 0x089B4AFC  token: 0x6000681
        public System.Boolean IsActive(System.Int32 windId) { }
        // RVA: 0x089B4D34  token: 0x6000682
        public System.Void SetFlag(System.Int32 windId, System.UInt32 flag, System.Boolean sw) { }
        // RVA: 0x089B4E08  token: 0x6000683
        public System.Void SetParameter(System.Int32 windId, Unity.Mathematics.float3 areaSize, System.Boolean addition, System.Single main, System.Single turbulence, System.Single frequency, Unity.Mathematics.float3 direction, System.Single areaVolume, System.Single areaLength, MagicaCloth.BezierParam attenuation) { }
        // RVA: 0x089B4740  token: 0x6000685
        private static Unity.Mathematics.float3 CalcWindForce(System.Single time, Unity.Mathematics.float2 noiseBasePos, Unity.Mathematics.float3 mainDir, System.Single main, System.Single turbulence, System.Single frequency, System.Single randomScale) { }
        // RVA: 0x0350B670  token: 0x6000686
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000CE  // size: 0x18
    public abstract class PhysicsManagerWorker
    {
        // Fields
        private MagicaCloth.MagicaPhysicsManager <Manager>k__BackingField;  // 0x10

        // Properties
        MagicaCloth.MagicaPhysicsManager Manager { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x600068D
        protected virtual System.Void Start() { }
        // RVA: 0x02E153E0  token: 0x600068E
        public System.Void Init(MagicaCloth.MagicaPhysicsManager manager) { }
        // RVA: -1  // abstract  token: 0x600068F
        public virtual System.Void Create() { }
        // RVA: -1  // abstract  token: 0x6000690
        public virtual System.Void RemoveGroup(System.Int32 group) { }
        // RVA: -1  // abstract  token: 0x6000691
        public virtual System.Void Release() { }
        // RVA: -1  // abstract  token: 0x6000692
        public virtual System.Void Warmup() { }
        // RVA: -1  // abstract  token: 0x6000693
        public virtual Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: -1  // abstract  token: 0x6000694
        public virtual Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x0350B670  token: 0x6000695
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000CF  // size: 0x38
    public abstract class ColliderComponent : MagicaCloth.ParticleComponent
    {
        // Fields
        protected System.Boolean isGlobal;  // 0x28
        private UnityEngine.Vector3 center;  // 0x2c

        // Properties
        UnityEngine.Vector3 Center { get; /* RVA: 0x03D59800 */ set; /* RVA: 0x089AAD4C */ }

        // Methods
        // RVA: 0x089AABF4  token: 0x6000698
        protected virtual System.Void OnInit() { }
        // RVA: 0x089AA910  token: 0x6000699
        protected virtual System.Void OnDispose() { }
        // RVA: 0x089AA8C4  token: 0x600069A
        public virtual System.Int32 GetDataHash() { }
        // RVA: -1  // abstract  token: 0x600069B
        public virtual System.Boolean CalcNearPoint(UnityEngine.Vector3 pos, UnityEngine.Vector3& p, UnityEngine.Vector3& dir, UnityEngine.Vector3& d, System.Boolean skinning) { }
        // RVA: 0x089AA728  token: 0x600069C
        public UnityEngine.Vector3 CalcLocalPos(UnityEngine.Vector3 pos) { }
        // RVA: 0x089AA6BC  token: 0x600069D
        public UnityEngine.Vector3 CalcLocalDir(UnityEngine.Vector3 dir) { }
        // RVA: 0x089AA838  token: 0x600069E
        public MagicaCloth.ChunkData CreateColliderParticle(System.Int32 teamId) { }
        // RVA: 0x089AAC18  token: 0x600069F
        public System.Void RemoveColliderParticle(System.Int32 teamId) { }
        // RVA: -1  // abstract  token: 0x60006A0
        protected virtual MagicaCloth.ChunkData CreateColliderParticleReal(System.Int32 teamId) { }
        // RVA: 0x089AAD44  token: 0x60006A1
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000D0  // size: 0x48
    public class MagicaCapsuleCollider : MagicaCloth.ColliderComponent
    {
        // Fields
        private MagicaCloth.MagicaCapsuleCollider.Axis axis;  // 0x38
        private System.Single length;  // 0x3c
        private System.Single startRadius;  // 0x40
        private System.Single endRadius;  // 0x44

        // Properties
        MagicaCloth.MagicaCapsuleCollider.Axis AxisMode { get; /* RVA: 0x03D4EC30 */ set; /* RVA: 0x089AD958 */ }
        System.Single Length { get; /* RVA: 0x03D4EC60 */ set; /* RVA: 0x089AD970 */ }
        System.Single StartRadius { get; /* RVA: 0x03D4EC70 */ set; /* RVA: 0x089AD97C */ }
        System.Single EndRadius { get; /* RVA: 0x03D4EC80 */ set; /* RVA: 0x089AD964 */ }

        // Methods
        // RVA: 0x03D562A0  token: 0x60006A2
        public virtual MagicaCloth.ComponentType GetComponentType() { }
        // RVA: 0x089AD910  token: 0x60006A3
        private System.Void OnValidate() { }
        // RVA: 0x089AD3E0  token: 0x60006A4
        private virtual System.Void DataUpdate() { }
        // RVA: 0x089AD730  token: 0x60006A5
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x089AD290  token: 0x60006AE
        protected virtual MagicaCloth.ChunkData CreateColliderParticleReal(System.Int32 teamId) { }
        // RVA: 0x089AD710  token: 0x60006AF
        private System.UInt32 GetCapsuleFlag() { }
        // RVA: 0x089AD834  token: 0x60006B0
        public UnityEngine.Vector3 GetLocalDir() { }
        // RVA: 0x089AD878  token: 0x60006B1
        public UnityEngine.Vector3 GetLocalUp() { }
        // RVA: 0x089AD8B4  token: 0x60006B2
        public System.Single GetScale() { }
        // RVA: 0x089ACB14  token: 0x60006B3
        public virtual System.Boolean CalcNearPoint(UnityEngine.Vector3 pos, UnityEngine.Vector3& p, UnityEngine.Vector3& dir, UnityEngine.Vector3& d, System.Boolean skinning) { }
        // RVA: 0x089AD93C  token: 0x60006B4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D2  // size: 0x38
    public class MagicaPlaneCollider : MagicaCloth.ColliderComponent
    {
        // Methods
        // RVA: 0x03D563D0  token: 0x60006B5
        public virtual MagicaCloth.ComponentType GetComponentType() { }
        // RVA: 0x089AD910  token: 0x60006B6
        private System.Void OnValidate() { }
        // RVA: 0x089ADC80  token: 0x60006B7
        private virtual System.Void DataUpdate() { }
        // RVA: 0x089ADB54  token: 0x60006B8
        protected virtual MagicaCloth.ChunkData CreateColliderParticleReal(System.Int32 teamId) { }
        // RVA: 0x089AD988  token: 0x60006B9
        public virtual System.Boolean CalcNearPoint(UnityEngine.Vector3 pos, UnityEngine.Vector3& p, UnityEngine.Vector3& dir, UnityEngine.Vector3& d, System.Boolean skinning) { }
        // RVA: 0x089AAD44  token: 0x60006BA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D3  // size: 0x40
    public class MagicaSphereCollider : MagicaCloth.ColliderComponent
    {
        // Fields
        private System.Single radius;  // 0x38

        // Properties
        System.Single Radius { get; /* RVA: 0x03D51000 */ set; /* RVA: 0x089AE410 */ }

        // Methods
        // RVA: 0x03D563F0  token: 0x60006BB
        public virtual MagicaCloth.ComponentType GetComponentType() { }
        // RVA: 0x089AD910  token: 0x60006BC
        private System.Void OnValidate() { }
        // RVA: 0x089AE12C  token: 0x60006BD
        private virtual System.Void DataUpdate() { }
        // RVA: 0x089AE368  token: 0x60006C0
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x089AE004  token: 0x60006C1
        protected virtual MagicaCloth.ChunkData CreateColliderParticleReal(System.Int32 teamId) { }
        // RVA: 0x089AE3D0  token: 0x60006C2
        public System.Single GetScale() { }
        // RVA: 0x089ADE4C  token: 0x60006C3
        public virtual System.Boolean CalcNearPoint(UnityEngine.Vector3 pos, UnityEngine.Vector3& p, UnityEngine.Vector3& dir, UnityEngine.Vector3& d, System.Boolean skinning) { }
        // RVA: 0x089AE400  token: 0x60006C4
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000D4  // size: 0x28
    public abstract class ParticleComponent : MagicaCloth.BaseComponent, MagicaCloth.IDataHash
    {
        // Fields
        protected System.Collections.Generic.Dictionary<System.Int32,MagicaCloth.ChunkData> particleDict;  // 0x18
        protected MagicaCloth.RuntimeStatus status;  // 0x20

        // Properties
        MagicaCloth.RuntimeStatus Status { get; /* RVA: 0x03D4EB40 */ }
        System.Int32 CenterParticleIndex { get; /* RVA: 0x089AFE58 */ }

        // Methods
        // RVA: -1  // abstract  token: 0x60006C6
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x089AFCB0  token: 0x60006C8
        protected virtual System.Void Start() { }
        // RVA: 0x08969CBC  token: 0x60006C9
        public virtual System.Void OnEnable() { }
        // RVA: 0x08969C88  token: 0x60006CA
        public virtual System.Void OnDisable() { }
        // RVA: 0x089AF8F0  token: 0x60006CB
        protected virtual System.Void OnDestroy() { }
        // RVA: 0x089AF79C  token: 0x60006CC
        private System.Void Init() { }
        // RVA: 0x089AF974  token: 0x60006CD
        protected System.Void OnUpdateStatus() { }
        // RVA: 0x0232EB60  token: 0x60006CE
        public virtual System.Boolean VerifyData() { }
        // RVA: 0x0350B670  token: 0x60006CF
        protected virtual System.Void OnInit() { }
        // RVA: 0x089AF920  token: 0x60006D0
        protected virtual System.Void OnDispose() { }
        // RVA: 0x0350B670  token: 0x60006D1
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x089AF8E8  token: 0x60006D2
        protected virtual System.Void OnActive() { }
        // RVA: 0x089AF96C  token: 0x60006D3
        protected virtual System.Void OnInactive() { }
        // RVA: 0x089AF4B4  token: 0x60006D4
        protected System.Void EnableParticle() { }
        // RVA: 0x089AF1AC  token: 0x60006D5
        protected System.Void DisableParticle() { }
        // RVA: 0x089AF5F4  token: 0x60006D6
        protected System.Void EnableTeamParticle(System.Int32 teamId) { }
        // RVA: 0x089AF30C  token: 0x60006D7
        protected System.Void DisableTeamParticle(System.Int32 teamId) { }
        // RVA: 0x089AFC34  token: 0x60006D8
        protected System.Void ReserveDataUpdate() { }
        // RVA: 0x0350B670  token: 0x60006D9
        private virtual System.Void DataUpdate() { }
        // RVA: 0x089AFCB8  token: 0x60006DA
        private System.Void UpdateStatus() { }
        // RVA: 0x089AEF4C  token: 0x60006DB
        protected MagicaCloth.ChunkData CreateParticle(System.UInt32 flag, System.Int32 teamId, System.Single depth, Unity.Mathematics.float3 radius, Unity.Mathematics.float3 localPos) { }
        // RVA: 0x089AFB44  token: 0x60006DC
        protected System.Void RemoveTeamParticle(System.Int32 teamId) { }
        // RVA: 0x089AF9B0  token: 0x60006DD
        protected System.Void RemoveParticle() { }
        // RVA: 0x04273A88  token: 0x60006DE
        protected UnityEngine.Transform UserTransform(System.Int32 vindex) { }
        // RVA: 0x089AFCD8  token: 0x60006DF
        protected Unity.Mathematics.float3 UserTransformLocalPosition(System.Int32 vindex) { }
        // RVA: 0x089AFD44  token: 0x60006E0
        protected Unity.Mathematics.quaternion UserTransformLocalRotation(System.Int32 vindex) { }
        // RVA: 0x089AFDA0  token: 0x60006E1
        protected System.Void .ctor() { }
        // RVA: 0x0339AE90  token: 0x60006E2
        private System.Object <Init>b__11_0() { }

    }

    // TypeToken: 0x20000D5  // size: 0x78
    public abstract class PhysicsTeam : MagicaCloth.CoreComponent
    {
        // Fields
        protected MagicaCloth.PhysicsTeamData teamData;  // 0x38
        private System.Single userBlendWeight;  // 0x40
        private System.Single userPhysicsBlendWeight;  // 0x44
        private System.Boolean syncBlendWeightToPoseBlendWeight;  // 0x48
        private System.Single userCloseThreshold;  // 0x4c
        private MagicaCloth.PhysicsTeam.TeamUpdateMode updateMode;  // 0x50
        private MagicaCloth.PhysicsTeam.TeamCullingMode cullingMode;  // 0x54
        private MagicaCloth.PhysicsTeam.TeamSkinningMode skinningMode;  // 0x58
        protected System.Int32 teamId;  // 0x5c
        protected MagicaCloth.ChunkData particleChunk;  // 0x60
        protected UnityEngine.Transform influenceTarget;  // 0x70

        // Properties
        System.Int32 TeamId { get; /* RVA: 0x03D4EEF0 */ }
        MagicaCloth.PhysicsTeamData TeamData { get; /* RVA: 0x03D4E2A0 */ }
        MagicaCloth.ChunkData ParticleChunk { get; /* RVA: 0x03D5A130 */ }
        UnityEngine.Transform InfluenceTarget { get; /* RVA: 0x03D4EB30 */ set; /* RVA: 0x0519C3C8 */ }
        System.Single UserBlendWeight { get; /* RVA: 0x03D4EC70 */ set; /* RVA: 0x089438C4 */ }
        System.Single UserPhysicsBlendWeight { get; /* RVA: 0x03D4EC80 */ set; /* RVA: 0x089B5EF0 */ }
        System.Boolean SyncBlendWeightToPoseBlendWeight { get; /* RVA: 0x03D4EFE0 */ set; /* RVA: 0x03D4F010 */ }
        System.Single UserCloseThreshold { get; /* RVA: 0x03D50200 */ set; /* RVA: 0x089B5ED8 */ }
        MagicaCloth.PhysicsTeam.TeamUpdateMode UpdateMode { get; /* RVA: 0x03D4EED0 */ set; /* RVA: 0x03D4EF20 */ }
        MagicaCloth.PhysicsTeam.TeamCullingMode CullingMode { get; /* RVA: 0x03D4EEC0 */ set; /* RVA: 0x03D4EF10 */ }
        MagicaCloth.PhysicsTeam.TeamSkinningMode SkinningMode { get; /* RVA: 0x03D4EF00 */ set; /* RVA: 0x03D4EF50 */ }
        System.Boolean UseAnimatedPose { get; /* RVA: 0x089B5ED0 */ }

        // Methods
        // RVA: 0x089B5AAC  token: 0x60006E3
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x089B5D44  token: 0x60006F8
        protected virtual System.Void OnInit() { }
        // RVA: 0x089B5C2C  token: 0x60006F9
        protected virtual System.Void OnDispose() { }
        // RVA: 0x0350B670  token: 0x60006FA
        protected virtual System.Void OnUpdate() { }
        // RVA: 0x089B5BC8  token: 0x60006FB
        protected virtual System.Void OnActive() { }
        // RVA: 0x089B5CC4  token: 0x60006FC
        protected virtual System.Void OnInactive() { }
        // RVA: 0x089B5ACC  token: 0x60006FD
        public System.Boolean IsActive() { }
        // RVA: 0x089B5B4C  token: 0x60006FE
        public System.Boolean IsValid() { }
        // RVA: 0x089B584C  token: 0x60006FF
        public MagicaCloth.ChunkData CreateParticle(System.Int32 team, System.Int32 count, System.Func<System.Int32,System.UInt32> funcFlag, System.Func<System.Int32,Unity.Mathematics.float3> funcWpos, System.Func<System.Int32,Unity.Mathematics.quaternion> funcWrot, System.Func<System.Int32,System.Single> funcDepth, System.Func<System.Int32,Unity.Mathematics.float3> funcRadius, System.Func<System.Int32,Unity.Mathematics.float3> funcTargetLocalPos) { }
        // RVA: 0x089B5DBC  token: 0x6000700
        public System.Void RemoveAllParticle() { }
        // RVA: 0x089B5A08  token: 0x6000701
        public System.Void EnableParticle(System.Func<System.Int32,UnityEngine.Transform> funcTarget, System.Func<System.Int32,Unity.Mathematics.float3> funcLpos, System.Func<System.Int32,Unity.Mathematics.quaternion> funcLrot) { }
        // RVA: 0x089B5948  token: 0x6000702
        public System.Void DisableParticle(System.Func<System.Int32,UnityEngine.Transform> funcTarget, System.Func<System.Int32,Unity.Mathematics.float3> funcLpos, System.Func<System.Int32,Unity.Mathematics.quaternion> funcLrot) { }
        // RVA: 0x089B5E38  token: 0x6000703
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x089B5E40  token: 0x6000704
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x20000D9  // size: 0x30
    public class PhysicsTeamData : MagicaCloth.IDataHash
    {
        // Fields
        private System.Collections.Generic.List<MagicaCloth.ColliderComponent> colliderList;  // 0x10
        private System.Collections.Generic.List<MagicaCloth.ColliderComponent> penetrationIgnoreColliderList;  // 0x18
        private System.Boolean mergeAvatarCollider;  // 0x20
        private System.Collections.Generic.List<MagicaCloth.ColliderComponent> addColliderList;  // 0x28

        // Properties
        System.Int32 ColliderCount { get; /* RVA: 0x089B580C */ }
        System.Collections.Generic.List<MagicaCloth.ColliderComponent> ColliderList { get; /* RVA: 0x020B7B20 */ }
        System.Collections.Generic.List<MagicaCloth.ColliderComponent> PenetrationIgnoreColliderList { get; /* RVA: 0x01041090 */ }
        System.Boolean MergeAvatarCollider { get; /* RVA: 0x03D4EF90 */ }

        // Methods
        // RVA: 0x089B5300  token: 0x6000705
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x089B533C  token: 0x6000706
        public System.Void Init(System.Int32 teamId) { }
        // RVA: 0x089B5068  token: 0x6000707
        public System.Void Dispose(System.Int32 teamId) { }
        // RVA: 0x089B4FC4  token: 0x6000708
        public System.Void AddCollider(MagicaCloth.ColliderComponent collider) { }
        // RVA: 0x089B5494  token: 0x6000709
        public System.Void RemoveCollider(MagicaCloth.ColliderComponent collider) { }
        // RVA: 0x089B55AC  token: 0x600070A
        private System.Void UpdateStatus() { }
        // RVA: 0x089B56F0  token: 0x600070F
        public System.Void ValidateColliderList() { }
        // RVA: 0x089B572C  token: 0x6000710
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000DA  // size: 0x30
    public class AdjustRotationWorker : MagicaCloth.PhysicsManagerWorker
    {
        // Fields
        private static System.Int32 AdjustMode_Fixed;  // const
        private static System.Int32 AdjustMode_XYMove;  // const
        private static System.Int32 AdjustMode_XZMove;  // const
        private static System.Int32 AdjustMode_YZMove;  // const
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.AdjustRotationWorker.AdjustRotationData> dataList;  // 0x18
        public MagicaCloth.FixedNativeList<MagicaCloth.AdjustRotationWorker.GroupData> groupList;  // 0x20
        private MagicaCloth.ExNativeMultiHashMap<System.Int32,System.Int32> particleMap;  // 0x28

        // Methods
        // RVA: 0x02E0FCF0  token: 0x6000711
        public virtual System.Void Create() { }
        // RVA: 0x089A837C  token: 0x6000712
        public virtual System.Void Release() { }
        // RVA: 0x089A7BF0  token: 0x6000713
        public System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Int32 adjustMode, Unity.Mathematics.float3 axisRotationPower, MagicaCloth.AdjustRotationWorker.AdjustRotationData[] dataArray) { }
        // RVA: 0x089A8404  token: 0x6000714
        public virtual System.Void RemoveGroup(System.Int32 teamId) { }
        // RVA: 0x089A7E7C  token: 0x6000715
        public System.Void ChangeParam(System.Int32 teamId, System.Boolean active, System.Int32 adjustMode, Unity.Mathematics.float3 axisRotationPower) { }
        // RVA: 0x0350B670  token: 0x6000716
        public virtual System.Void Warmup() { }
        // RVA: 0x03D65E70  token: 0x6000717
        public virtual Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x089A8010  token: 0x6000718
        public virtual Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x0350B670  token: 0x6000719
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000DE  // size: 0x30
    public class BaseSkinningWorker : MagicaCloth.PhysicsManagerWorker
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.BaseSkinningWorker.BaseSkinningData> dataList;  // 0x18
        private MagicaCloth.FixedChunkNativeArray<Unity.Mathematics.float4x4> bindPoseList;  // 0x20
        public MagicaCloth.FixedNativeList<MagicaCloth.BaseSkinningWorker.GroupData> groupList;  // 0x28

        // Methods
        // RVA: 0x03B40AC0  token: 0x600071C
        public virtual System.Void Create() { }
        // RVA: 0x089A9808  token: 0x600071D
        public virtual System.Void Release() { }
        // RVA: 0x089A90C8  token: 0x600071E
        public System.Int32 AddGroup(System.Int32 teamId, System.Boolean active, System.Boolean updateFixed, MagicaCloth.BaseSkinningWorker.BaseSkinningData[] skinningDataList, Unity.Mathematics.float4x4[] skinningBindPoseList) { }
        // RVA: 0x089A9890  token: 0x600071F
        public virtual System.Void RemoveGroup(System.Int32 teamId) { }
        // RVA: 0x089A92AC  token: 0x6000720
        public System.Void ChangeParam(System.Int32 teamId, System.Boolean updateFixed) { }
        // RVA: 0x0350B670  token: 0x6000721
        public virtual System.Void Warmup() { }
        // RVA: 0x089A9404  token: 0x6000722
        public virtual Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03D65E70  token: 0x6000723
        public virtual Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x0350B670  token: 0x6000724
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000E2  // size: 0x38
    public class LineWorker : MagicaCloth.PhysicsManagerWorker
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.LineWorker.LineRotationData> dataList;  // 0x18
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.LineWorker.LineRotationRootInfo> rootInfoList;  // 0x20
        public MagicaCloth.FixedNativeList<MagicaCloth.LineWorker.GroupData> groupList;  // 0x28
        private MagicaCloth.FixedChunkNativeArray<System.Int32> rootTeamList;  // 0x30

        // Methods
        // RVA: 0x03541210  token: 0x6000727
        public virtual System.Void Create() { }
        // RVA: 0x089AC868  token: 0x6000728
        public virtual System.Void Release() { }
        // RVA: 0x089AC190  token: 0x6000729
        public System.Int32 AddGroup(System.Int32 teamId, System.Boolean avarage, MagicaCloth.LineWorker.LineRotationData[] dataArray, MagicaCloth.LineWorker.LineRotationRootInfo[] rootInfoArray) { }
        // RVA: 0x089AC910  token: 0x600072A
        public virtual System.Void RemoveGroup(System.Int32 teamId) { }
        // RVA: 0x089AC41C  token: 0x600072B
        public System.Void ChangeParam(System.Int32 teamId, System.Boolean avarage) { }
        // RVA: 0x0350B670  token: 0x600072C
        public virtual System.Void Warmup() { }
        // RVA: 0x03D65E70  token: 0x600072D
        public virtual Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x089AC57C  token: 0x600072E
        public virtual Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x0350B670  token: 0x600072F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000E7  // size: 0x30
    public class MeshParticleWorker : MagicaCloth.PhysicsManagerWorker
    {
        // Fields
        private MagicaCloth.ExNativeMultiHashMap<System.Int32,System.Int32> vertexToParticleMap;  // 0x18
        private MagicaCloth.FixedNativeListWithCount<System.Int32> vertexToParticleList;  // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<MagicaCloth.MeshParticleWorker.CreateData>> groupCreateDict;  // 0x28

        // Methods
        // RVA: 0x02E0FE00  token: 0x6000731
        public virtual System.Void Create() { }
        // RVA: 0x089AECD0  token: 0x6000732
        public virtual System.Void Release() { }
        // RVA: 0x089AE41C  token: 0x6000733
        public System.Void Add(System.Int32 group, System.Int32 vindex, System.Int32 pindex) { }
        // RVA: 0x089AED38  token: 0x6000734
        public virtual System.Void RemoveGroup(System.Int32 group) { }
        // RVA: 0x0350B670  token: 0x6000735
        public virtual System.Void Warmup() { }
        // RVA: 0x089AE9CC  token: 0x6000736
        public virtual Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x089AE5A4  token: 0x6000737
        public virtual Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03CFD270  token: 0x6000738
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000EB  // size: 0x18
    public class RenderMeshWorker : MagicaCloth.PhysicsManagerWorker
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600073B
        public virtual System.Void Create() { }
        // RVA: 0x0350B670  token: 0x600073C
        public virtual System.Void Release() { }
        // RVA: 0x0350B670  token: 0x600073D
        public virtual System.Void RemoveGroup(System.Int32 group) { }
        // RVA: 0x089B8BF8  token: 0x600073E
        private System.Boolean IsPerformMeshProcessForEachParticle() { }
        // RVA: 0x089B958C  token: 0x600073F
        public virtual System.Void Warmup() { }
        // RVA: 0x03D65E70  token: 0x6000740
        public virtual Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x089B8C80  token: 0x6000741
        public virtual Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x089B7680  token: 0x6000742
        private static System.Void CollectionVertex(MagicaCloth.PhysicsManagerMeshData.RenderMeshInfo& r_minfo, Unity.Collections.NativeArray<System.UInt32>& sharedChildVertexInfoList, Unity.Collections.NativeArray<MagicaCloth.MeshData.VertexWeight>& sharedChildVertexWeightList, Unity.Collections.NativeArray<Unity.Mathematics.float3>& virtualPosList, Unity.Collections.NativeArray<Unity.Mathematics.quaternion>& virtualRotList, Unity.Mathematics.float3& tpos, Unity.Mathematics.quaternion& trot, Unity.Mathematics.float3& tscl, Unity.Mathematics.quaternion& itrot, System.Single scaleRatio, Unity.Mathematics.float3& scaleDirection, System.Boolean calcNormal, System.Boolean calcTangent, System.Int32 vindex, System.Int32 i, System.UInt32 flag, System.Boolean isFasterWrite, Unity.Collections.NativeArray<Unity.Mathematics.float3>& renderPosList, Unity.Collections.NativeArray<Unity.Mathematics.float3>& renderNormalList, Unity.Collections.NativeArray<Unity.Mathematics.float3>& renderPosArray, Unity.Collections.NativeArray<Unity.Mathematics.float3>& renderNomalArray, Unity.Collections.NativeArray<Unity.Mathematics.float4>& renderTangentList) { }
        // RVA: 0x0350B670  token: 0x6000743
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000EF  // size: 0x30
    public class SpringMeshWorker : MagicaCloth.PhysicsManagerWorker
    {
        // Fields
        private MagicaCloth.ExNativeMultiHashMap<System.Int32,MagicaCloth.SpringMeshWorker.SpringData> springMap;  // 0x18
        private MagicaCloth.FixedNativeListWithCount<System.Int32> springVertexList;  // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> groupIndexDict;  // 0x28

        // Methods
        // RVA: 0x02E0FEE0  token: 0x6000747
        public virtual System.Void Create() { }
        // RVA: 0x089BA740  token: 0x6000748
        public virtual System.Void Release() { }
        // RVA: 0x089BA1E8  token: 0x6000749
        public System.Void Add(System.Int32 group, System.Int32 vertexIndex, System.Int32 particleIndex, System.Single weight) { }
        // RVA: 0x089BA7A8  token: 0x600074A
        public virtual System.Void RemoveGroup(System.Int32 group) { }
        // RVA: 0x0350B670  token: 0x600074B
        public virtual System.Void Warmup() { }
        // RVA: 0x03D65E70  token: 0x600074C
        public virtual Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x089BA378  token: 0x600074D
        public virtual Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x03CFC270  token: 0x600074E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000F2  // size: 0x30
    public class TriangleWorker : MagicaCloth.PhysicsManagerWorker
    {
        // Fields
        private MagicaCloth.FixedChunkNativeArray<MagicaCloth.TriangleWorker.TriangleRotationData> triangleDataList;  // 0x18
        private MagicaCloth.FixedChunkNativeArray<System.Int32> triangleIndexList;  // 0x20
        public MagicaCloth.FixedNativeList<MagicaCloth.TriangleWorker.GroupData> groupList;  // 0x28

        // Methods
        // RVA: 0x03541370  token: 0x6000750
        public virtual System.Void Create() { }
        // RVA: 0x089BB60C  token: 0x6000751
        public virtual System.Void Release() { }
        // RVA: 0x089BB0EC  token: 0x6000752
        public System.Int32 AddGroup(System.Int32 teamId, MagicaCloth.TriangleWorker.TriangleRotationData[] dataArray, System.Int32[] indexArray) { }
        // RVA: 0x089BB694  token: 0x6000753
        public virtual System.Void RemoveGroup(System.Int32 teamId) { }
        // RVA: 0x0350B670  token: 0x6000754
        public virtual System.Void Warmup() { }
        // RVA: 0x03D65E70  token: 0x6000755
        public virtual Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x089BB310  token: 0x6000756
        public virtual Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x0350B670  token: 0x6000757
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000F6  // size: 0x18
    public class VirtualMeshWorker : MagicaCloth.PhysicsManagerWorker
    {
        // Methods
        // RVA: 0x0350B670  token: 0x600075A
        public virtual System.Void Create() { }
        // RVA: 0x0350B670  token: 0x600075B
        public virtual System.Void Release() { }
        // RVA: 0x0350B670  token: 0x600075C
        public virtual System.Void RemoveGroup(System.Int32 group) { }
        // RVA: 0x089D0C44  token: 0x600075D
        private System.Boolean IsPerformMeshProcessForEachParticle() { }
        // RVA: 0x0350B670  token: 0x600075E
        public virtual System.Void Warmup() { }
        // RVA: 0x089D1780  token: 0x600075F
        public virtual Unity.Jobs.JobHandle PreUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x089D0CCC  token: 0x6000760
        public virtual Unity.Jobs.JobHandle PostUpdate(Unity.Jobs.JobHandle jobHandle) { }
        // RVA: 0x0350B670  token: 0x6000761
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000FB  // size: 0x40
    public class AutoMove : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector3 direction;  // 0x18
        private System.Single length;  // 0x24
        private System.Single interval;  // 0x28
        private UnityEngine.Vector3 startPosition;  // 0x2c
        private System.Single time;  // 0x38

        // Methods
        // RVA: 0x089BBBD0  token: 0x6000766
        private System.Void Start() { }
        // RVA: 0x089BBC10  token: 0x6000767
        private System.Void Update() { }
        // RVA: 0x089BBBA8  token: 0x6000768
        public System.Void OnMoveButton() { }
        // RVA: 0x089BBD68  token: 0x6000769
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000FC  // size: 0x30
    public class AutoRotate : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector3 rotateAngle;  // 0x18
        private System.Single interval;  // 0x24
        private System.Single time;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x600076A
        private System.Void Start() { }
        // RVA: 0x089BBD98  token: 0x600076B
        private System.Void Update() { }
        // RVA: 0x089BBBA8  token: 0x600076C
        public System.Void OnMoveButton() { }
        // RVA: 0x089BBE54  token: 0x600076D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000FD  // size: 0x28
    public class BlastWaveController : UnityEngine.MonoBehaviour
    {
        // Fields
        public MagicaCloth.MagicaAreaWind wind;  // 0x18
        public System.Single attenuationStartTime;  // 0x20
        public System.Single attenuationTime;  // 0x24

        // Methods
        // RVA: 0x089BC178  token: 0x600076E
        private System.Collections.IEnumerator Start() { }
        // RVA: 0x03D4CC10  token: 0x600076F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x20000FF  // size: 0x98
    public class CameraOrbit : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform cameraTransform;  // 0x18
        public UnityEngine.Transform cameraTarget;  // 0x20
        public UnityEngine.Vector3 cameraTargetPos;  // 0x28
        public UnityEngine.Vector3 cameraTargetOffset;  // 0x34
        private System.Single cameraDist;  // 0x40
        private System.Single cameraPitch;  // 0x44
        private System.Single cameraYaw;  // 0x48
        private System.Single cameraDistHokanTime;  // 0x4c
        private System.Single cameraAngleHokanTime;  // 0x50
        private System.Single cameraDistSpeed;  // 0x54
        private System.Single cameraDistMax;  // 0x58
        private System.Single cameraDistMin;  // 0x5c
        private System.Single cameraYawSpeed;  // 0x60
        private System.Single cameraPitchSpeed;  // 0x64
        private System.Single cameraMaxAngleSpeed;  // 0x68
        private System.Single cameraPitchMax;  // 0x6c
        private System.Single cameraPitchMin;  // 0x70
        private MagicaCloth.CameraOrbit.MoveMode moveMode;  // 0x74
        private System.Single moveSpeed;  // 0x78
        private System.Single setCameraDist;  // 0x7c
        private System.Single setCameraPitch;  // 0x80
        private System.Single setCameraYaw;  // 0x84
        private System.Single cameraDistVelocity;  // 0x88
        private System.Single cameraPitchVelocity;  // 0x8c
        private System.Single cameraYawVelocity;  // 0x90

        // Methods
        // RVA: 0x089BD9C8  token: 0x6000776
        private System.Void Start() { }
        // RVA: 0x089BD6A0  token: 0x6000777
        private System.Void OnEnable() { }
        // RVA: 0x089BD3F0  token: 0x6000778
        private System.Void OnDisable() { }
        // RVA: 0x089BD3E8  token: 0x6000779
        private System.Void LateUpdate() { }
        // RVA: 0x089BDB28  token: 0x600077A
        private System.Void updateCamera() { }
        // RVA: 0x089BDFE0  token: 0x600077B
        private System.Void updatePitchYaw(UnityEngine.Vector2 speed) { }
        // RVA: 0x089BDE04  token: 0x600077C
        private System.Void updateOffset(UnityEngine.Vector2 speed) { }
        // RVA: 0x089BE04C  token: 0x600077D
        private System.Void updateZoom(System.Single speed) { }
        // RVA: 0x089BD8E0  token: 0x600077E
        private System.Void OnTouchMove(System.Int32 fid, UnityEngine.Vector2 screenPos, UnityEngine.Vector2 screenVelocity, UnityEngine.Vector2 cmVelocity) { }
        // RVA: 0x089BD630  token: 0x600077F
        private System.Void OnDoubleTouchMove(System.Int32 fid, UnityEngine.Vector2 screenPos, UnityEngine.Vector2 screenVelocity, UnityEngine.Vector2 cmVelocity) { }
        // RVA: 0x089BD95C  token: 0x6000780
        private System.Void OnTouchPinch(System.Single speedscr, System.Single speedcm) { }
        // RVA: 0x089BDAC0  token: 0x6000781
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000101  // size: 0x38
    public class CopyObject : UnityEngine.MonoBehaviour
    {
        // Fields
        public System.Int32 seed;  // 0x18
        public System.Int32 count;  // 0x1c
        public System.Single radius;  // 0x20
        public UnityEngine.GameObject prefab;  // 0x28
        public System.Int32 delayFrame;  // 0x30

        // Methods
        // RVA: 0x0350B670  token: 0x6000782
        private System.Void Awake() { }
        // RVA: 0x089BE2BC  token: 0x6000783
        private System.Void Start() { }
        // RVA: 0x089BE260  token: 0x6000784
        private System.Collections.IEnumerator CreateObject() { }
        // RVA: 0x089BE2E0  token: 0x6000785
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000103  // size: 0x38
    public class DressUpControl : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject partsItemPrefab;  // 0x18
        private UnityEngine.UI.VerticalLayoutGroup verticalLayoutGroup;  // 0x20
        private MagicaCloth.MagicaAvatar avatar;  // 0x28
        public System.Collections.Generic.List<MagicaCloth.DressUpControl.AvatarPartsGroup> avatarPartsGroupList;  // 0x30

        // Methods
        // RVA: 0x089BED54  token: 0x600078C
        private System.Void Start() { }
        // RVA: 0x0350B670  token: 0x600078D
        private System.Void Update() { }
        // RVA: 0x089BED1C  token: 0x600078E
        private System.Void OnDestroy() { }
        // RVA: 0x089BEB28  token: 0x600078F
        private System.Void Init() { }
        // RVA: 0x089BE8E8  token: 0x6000790
        private System.Void ChangeParts(System.Int32 id, System.Int32 dir) { }
        // RVA: 0x089BE9E4  token: 0x6000791
        public System.Void Clear() { }
        // RVA: 0x089BED64  token: 0x6000792
        public System.Void .ctor() { }
        // RVA: 0x089BED5C  token: 0x6000793
        private System.Void <Init>b__8_0(System.Int32 id, System.Int32 dir) { }

    }

    // TypeToken: 0x2000105  // size: 0x28
    public class ModelController : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.GameObject> characterList;  // 0x18
        private System.Single slowTime;  // 0x20
        private System.Boolean slow;  // 0x24

        // Methods
        // RVA: 0x0350B670  token: 0x6000795
        private System.Void Start() { }
        // RVA: 0x0350B670  token: 0x6000796
        private System.Void Update() { }
        // RVA: 0x089CBDA8  token: 0x6000797
        private System.Void AnimatorAction(System.Action<UnityEngine.Animator> act) { }
        // RVA: 0x089CBF4C  token: 0x6000798
        private System.Void ClothAction(System.Action<MagicaCloth.BaseCloth> act) { }
        // RVA: 0x089CC2F0  token: 0x6000799
        public System.Void OnNextButton() { }
        // RVA: 0x089CC1F4  token: 0x600079A
        public System.Void OnBackButton() { }
        // RVA: 0x089CC3EC  token: 0x600079B
        public System.Void OnSlowButton() { }
        // RVA: 0x089CC0F8  token: 0x600079C
        public System.Void OnActiveButton() { }
        // RVA: 0x089CC508  token: 0x600079D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000108  // size: 0x10
    public static class ObjectUtility
    {
        // Methods
        // RVA: 0x089CD894  token: 0x60007A6
        public static UnityEngine.GameObject[] PlaceRandomCubes(System.Int32 count, UnityEngine.Vector3 center, System.Single radius) { }
        // RVA: 0x089CDA38  token: 0x60007A7
        public static UnityEngine.GameObject[] PlaceRandomCubes(System.Int32 count) { }
        // RVA: 0x089CD7E8  token: 0x60007A8
        public static UnityEngine.GameObject MakeStrippedCube() { }
        // RVA: 0x089CDA64  token: 0x60007A9
        public static UnityEngine.GameObject[] PlaceRandomGameObject(System.Int32 count, UnityEngine.Vector3 center, System.Single radius, UnityEngine.GameObject prefab) { }

    }

    // TypeToken: 0x2000109  // size: 0x70
    public class SimpleInputManager : MagicaCloth.CreateSingleton`1
    {
        // Fields
        private static System.Int32 MaxFinger;  // const
        public System.Single tapRadiusCm;  // 0x18
        public System.Single flickRangeCm;  // 0x1c
        public System.Single flickCheckSpeed;  // 0x20
        public System.Single mouseWheelSpeed;  // 0x24
        private System.Int32 mainFingerId;  // 0x28
        private System.Int32 subFingerId;  // 0x2c
        private UnityEngine.Vector2[] downPos;  // 0x30
        private UnityEngine.Vector2[] lastPos;  // 0x38
        private UnityEngine.Vector2[] flickDownPos;  // 0x40
        private System.Single[] flickDownTime;  // 0x48
        private System.Single lastTime;  // 0x50
        private System.Boolean mobilePlatform;  // 0x54
        private System.Boolean[] mouseDown;  // 0x58
        private UnityEngine.Vector2[] mouseOldMovePos;  // 0x60
        private System.Single screenDpi;  // 0x68
        private System.Single screenDpc;  // 0x6c
        public static UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2> OnTouchDown;  // static @ 0x0
        public static UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2,UnityEngine.Vector2,UnityEngine.Vector2> OnTouchMove;  // static @ 0x8
        public static UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2,UnityEngine.Vector2,UnityEngine.Vector2> OnDoubleTouchMove;  // static @ 0x10
        public static UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2> OnTouchUp;  // static @ 0x18
        public static UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2> OnTouchMoveCancel;  // static @ 0x20
        public static UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2> OnTouchTap;  // static @ 0x28
        public static UnityEngine.Events.UnityAction<System.Int32,UnityEngine.Vector2,UnityEngine.Vector2,UnityEngine.Vector2> OnTouchFlick;  // static @ 0x30
        public static UnityEngine.Events.UnityAction<System.Single,System.Single> OnTouchPinch;  // static @ 0x38
        public static UnityEngine.Events.UnityAction OnBackButton;  // static @ 0x40

        // Properties
        System.Single ScreenDpi { get; /* RVA: 0x089D01D0 */ }
        System.Single ScreenDpc { get; /* RVA: 0x089D018C */ }

        // Methods
        // RVA: 0x03D474A0  token: 0x60007AA
        private static System.Void Init() { }
        // RVA: 0x089CEE78  token: 0x60007AB
        protected virtual System.Void InitSingleton() { }
        // RVA: 0x089D0110  token: 0x60007AC
        private System.Void Update() { }
        // RVA: 0x089CEC44  token: 0x60007AF
        private System.Void CalcScreenDpi() { }
        // RVA: 0x089CEC04  token: 0x60007B0
        private System.Void AllResetTouchInfo() { }
        // RVA: 0x089CEE70  token: 0x60007B1
        public System.Int32 GetTouchCount() { }
        // RVA: 0x089CEF8C  token: 0x60007B2
        public System.Boolean IsUI() { }
        // RVA: 0x089CF028  token: 0x60007B3
        private System.Void UpdateMobile() { }
        // RVA: 0x089CEC84  token: 0x60007B4
        private UnityEngine.Vector2 CalcScreenRatioVector(UnityEngine.Vector2 vec) { }
        // RVA: 0x089CECD4  token: 0x60007B5
        private System.Boolean CheckFlic(System.Int32 fid, UnityEngine.Vector2 oldpos, UnityEngine.Vector2 nowpos, UnityEngine.Vector2 downpos, System.Single flicktime) { }
        // RVA: 0x089CF8B4  token: 0x60007B6
        private System.Void UpdateMouse() { }
        // RVA: 0x089D0130  token: 0x60007B7
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200010A  // size: 0x38
    public class SliderStart : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text text;  // 0x18
        private System.String lable;  // 0x20
        private System.String format;  // 0x28
        private System.String formatString;  // 0x30

        // Methods
        // RVA: 0x089D02E0  token: 0x60007B8
        private System.Void Start() { }
        // RVA: 0x089D0214  token: 0x60007B9
        private System.Void OnChangeValue(System.Single value) { }
        // RVA: 0x089D045C  token: 0x60007BA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200010B  // size: 0x38
    public class UIPartsItem : UnityEngine.MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text text;  // 0x18
        public UnityEngine.UI.Button prefButton;  // 0x20
        public UnityEngine.UI.Button nextButton;  // 0x28
        private System.Int32 id;  // 0x30

        // Methods
        // RVA: 0x0350B670  token: 0x60007BB
        private System.Void Start() { }
        // RVA: 0x089D0AD0  token: 0x60007BC
        public System.Void Init(System.String title, System.Int32 id, System.Action<System.Int32,System.Int32> onClick) { }
        // RVA: 0x0426FE60  token: 0x60007BD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200010D  // size: 0x58
    public class WindController : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.WindZone unityWindZone;  // 0x18
        private System.Single unityWindZoneScale;  // 0x20
        private UnityEngine.Renderer arrowRenderer;  // 0x28
        private UnityEngine.Gradient arrowGradient;  // 0x30
        private System.Collections.Generic.List<UnityEngine.Transform> rotationTransforms;  // 0x38
        private UnityEngine.GameObject blastWavePrefab;  // 0x40
        private System.Single blastWaveSpawnRadius;  // 0x48
        private System.Single angleY;  // 0x4c
        private System.Single angleX;  // 0x50

        // Properties
        MagicaCloth.MagicaDirectionalWind Wind { get; /* RVA: 0x089D21EC */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60007C1
        private System.Void Start() { }
        // RVA: 0x089D1D80  token: 0x60007C2
        public System.Void OnDirectionY(System.Single value) { }
        // RVA: 0x089D1D74  token: 0x60007C3
        public System.Void OnDirectionX(System.Single value) { }
        // RVA: 0x089D1DC4  token: 0x60007C4
        public System.Void OnMain(System.Single value) { }
        // RVA: 0x089D1F0C  token: 0x60007C5
        public System.Void OnTurbulence(System.Single value) { }
        // RVA: 0x089D1D8C  token: 0x60007C6
        public System.Void OnFrequency(System.Single value) { }
        // RVA: 0x089D1C34  token: 0x60007C7
        public System.Void OnBlastWave() { }
        // RVA: 0x089D1F44  token: 0x60007C9
        private System.Void UpdateDirection() { }
        // RVA: 0x089D2124  token: 0x60007CA
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200010E  // size: 0x28
    public class BezierParam : MagicaCloth.IDataHash
    {
        // Fields
        private System.Single startValue;  // 0x10
        private System.Single endValue;  // 0x14
        private System.Boolean useEndValue;  // 0x18
        private System.Single curveValue;  // 0x1c
        private System.Boolean useCurveValue;  // 0x20

        // Properties
        System.Single StartValue { get; /* RVA: 0x03D4E7A0 */ }
        System.Single EndValue { get; /* RVA: 0x089BC154 */ }
        System.Single CurveValue { get; /* RVA: 0x089BC13C */ }
        System.Boolean UseCurve { get; /* RVA: 0x089BC168 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x60007CB
        public System.Void .ctor() { }
        // RVA: 0x03D6E2A0  token: 0x60007CC
        public System.Void .ctor(System.Single val) { }
        // RVA: 0x03D6E2C0  token: 0x60007CD
        public System.Void .ctor(System.Single sval, System.Single eval) { }
        // RVA: 0x03D6E270  token: 0x60007CE
        public System.Void .ctor(System.Single sval, System.Single eval, System.Boolean useEval, System.Single cval, System.Boolean useCval) { }
        // RVA: 0x03D6E270  token: 0x60007CF
        public System.Void SetParam(System.Single sval, System.Single eval, System.Boolean useEval, System.Single cval, System.Boolean useCval) { }
        // RVA: 0x089BBFC8  token: 0x60007D4
        public System.Single Evaluate(System.Single x) { }
        // RVA: 0x089BBEF0  token: 0x60007D5
        public MagicaCloth.BezierParam AutoSetup(System.Single startVal, System.Single endVal, System.Single curveVal) { }
        // RVA: 0x089BC020  token: 0x60007D6
        public virtual System.Int32 GetDataHash() { }
        // RVA: 0x089BBF54  token: 0x60007D7
        public MagicaCloth.BezierParam Clone() { }

    }

    // TypeToken: 0x200010F
    public interface IBoneReplace
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60007D8
        public virtual System.Collections.Generic.HashSet<UnityEngine.Transform> GetUsedBones() { }
        // RVA: -1  // abstract  token: 0x60007D9
        public virtual System.Void ReplaceBone(System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }

    }

    // TypeToken: 0x2000110
    public interface IDataVerify
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60007DA
        public virtual System.Int32 GetVersion() { }
        // RVA: -1  // abstract  token: 0x60007DB
        public virtual System.Void CreateVerifyData() { }
        // RVA: -1  // abstract  token: 0x60007DC
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: -1  // abstract  token: 0x60007DD
        public virtual System.String GetInformation() { }

    }

    // TypeToken: 0x2000111
    public interface IEditorCloth
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60007DE
        public virtual System.Collections.Generic.List<System.Int32> GetSelectionList() { }
        // RVA: -1  // abstract  token: 0x60007DF
        public virtual System.Collections.Generic.List<System.Int32> GetUseList() { }

    }

    // TypeToken: 0x2000112
    public interface IEditorMesh
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60007E0
        public virtual System.Int32 GetEditorPositionNormalTangent(System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        // RVA: -1  // abstract  token: 0x60007E1
        public virtual System.Collections.Generic.List<System.Int32> GetEditorTriangleList() { }
        // RVA: -1  // abstract  token: 0x60007E2
        public virtual System.Collections.Generic.List<System.Int32> GetEditorLineList() { }

    }

    // TypeToken: 0x2000113  // size: 0x48
    public class RuntimeStatus
    {
        // Fields
        private System.Boolean initStart;  // 0x10
        private System.Boolean init;  // 0x11
        private System.Boolean initError;  // 0x12
        private System.Boolean enable;  // 0x13
        private System.Boolean userEnable;  // 0x14
        private System.Boolean runtimeError;  // 0x15
        private System.Boolean dispose;  // 0x16
        private System.Boolean isActive;  // 0x17
        private System.Boolean isDirty;  // 0x18
        private System.Collections.Generic.HashSet<MagicaCloth.RuntimeStatus> <parentStatusSet>k__BackingField;  // 0x20
        private System.Collections.Generic.HashSet<MagicaCloth.RuntimeStatus> <childStatusSet>k__BackingField;  // 0x28
        private System.Action UpdateStatusAction;  // 0x30
        private System.Action DisconnectedAction;  // 0x38
        private System.Func<System.Object> OwnerFunc;  // 0x40

        // Properties
        System.Collections.Generic.HashSet<MagicaCloth.RuntimeStatus> parentStatusSet { get; /* RVA: 0x03D4EB40 */ set; /* RVA: 0x04271930 */ }
        System.Collections.Generic.HashSet<MagicaCloth.RuntimeStatus> childStatusSet { get; /* RVA: 0x03D4EAC0 */ set; /* RVA: 0x02C92F10 */ }
        System.Boolean IsActive { get; /* RVA: 0x089CEBCC */ }
        System.Boolean IsInitStart { get; /* RVA: 0x011797F0 */ }
        System.Boolean IsInitComplete { get; /* RVA: 0x03D510E0 */ }
        System.Boolean IsInitSuccess { get; /* RVA: 0x089CEBF0 */ }
        System.Boolean IsInitError { get; /* RVA: 0x089CEBE0 */ }
        System.Boolean IsDispose { get; /* RVA: 0x03D6DC60 */ }
        System.Boolean IsDirty { get; /* RVA: 0x01002A50 */ }

        // Methods
        // RVA: 0x01168960  token: 0x60007EE
        public System.Void SetInitStart() { }
        // RVA: 0x03D58960  token: 0x60007EF
        public System.Void SetInitComplete() { }
        // RVA: 0x03D64CD0  token: 0x60007F0
        public System.Void SetInitError() { }
        // RVA: 0x089CE8F4  token: 0x60007F1
        public System.Boolean SetEnable(System.Boolean sw) { }
        // RVA: 0x089CE914  token: 0x60007F2
        public System.Boolean SetUserEnable(System.Boolean sw) { }
        // RVA: 0x089CE904  token: 0x60007F3
        public System.Boolean SetRuntimeError(System.Boolean sw) { }
        // RVA: 0x03D6E380  token: 0x60007F4
        public System.Void SetDispose() { }
        // RVA: 0x03D587A0  token: 0x60007F5
        public System.Void SetDirty() { }
        // RVA: 0x03D566B0  token: 0x60007F6
        public System.Void ClearDirty() { }
        // RVA: 0x089CE960  token: 0x60007F7
        public System.Boolean UpdateStatus() { }
        // RVA: 0x089CE5DC  token: 0x60007F8
        public System.Void AddParentStatus(MagicaCloth.RuntimeStatus status) { }
        // RVA: 0x089CE850  token: 0x60007F9
        public System.Void RemoveParentStatus(MagicaCloth.RuntimeStatus status) { }
        // RVA: 0x089CE588  token: 0x60007FA
        public System.Void AddChildStatus(MagicaCloth.RuntimeStatus status) { }
        // RVA: 0x089CE7AC  token: 0x60007FB
        public System.Void RemoveChildStatus(MagicaCloth.RuntimeStatus status) { }
        // RVA: 0x089CE770  token: 0x60007FC
        public System.Void LinkParentStatus(MagicaCloth.RuntimeStatus parent) { }
        // RVA: 0x089CE924  token: 0x60007FD
        public System.Void UnlinkParentStatus(MagicaCloth.RuntimeStatus parent) { }
        // RVA: 0x089CE630  token: 0x60007FE
        private System.Boolean IsParentStatusActive() { }
        // RVA: 0x089CEB20  token: 0x60007FF
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000114  // size: 0x10
    public static class DataHashExtensions
    {
        // Fields
        public static System.Int32 NullHash;  // const
        public static System.Int32 NumberHash;  // const

        // Methods
        // RVA: 0x089BE2F8  token: 0x6000800
        public static System.Int32 GetDataHash(System.Object data) { }
        // RVA: 0x089BE52C  token: 0x6000801
        public static System.Int32 GetDataHash(MagicaCloth.IDataHash data) { }
        // RVA: -1  // generic def  token: 0x6000802
        public static System.Int32 GetDataHash(T[] data) { }
        // RVA: -1  // generic def  token: 0x6000803
        public static System.Int32 GetDataHash(System.Collections.Generic.List<T> data) { }
        // RVA: -1  // generic def  token: 0x6000804
        public static System.Int32 GetDataCountHash(T[] data) { }
        // RVA: -1  // generic def  token: 0x6000805
        public static System.Int32 GetDataCountHash(System.Collections.Generic.List<T> data) { }
        // RVA: 0x089BE544  token: 0x6000806
        public static System.UInt64 GetVectorDataHash(UnityEngine.Vector3 v) { }

    }

    // TypeToken: 0x2000115  // size: 0x20
    public class GridHash
    {
        // Fields
        protected System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.List<MagicaCloth.GridHash.Point>> gridMap;  // 0x10
        protected System.Single gridSize;  // 0x18

        // Methods
        // RVA: 0x089C1148  token: 0x6000807
        public virtual System.Void Create(System.Single gridSize) { }
        // RVA: 0x089C0F78  token: 0x6000808
        public virtual System.Void AddPoint(Unity.Mathematics.float3 pos, System.Int32 id) { }
        // RVA: 0x089C12B8  token: 0x6000809
        public virtual System.Void Remove(Unity.Mathematics.float3 pos, System.Int32 id) { }
        // RVA: 0x089C1100  token: 0x600080A
        public System.Void Clear() { }
        // RVA: 0x089C1234  token: 0x600080B
        public static Unity.Mathematics.int3 GetGridPos(Unity.Mathematics.float3 pos, System.Single gridSize) { }
        // RVA: 0x03D6E350  token: 0x600080C
        public static System.UInt32 GetGridHash(Unity.Mathematics.int3 pos) { }
        // RVA: 0x089C11D0  token: 0x600080D
        public static System.UInt32 GetGridHash(Unity.Mathematics.float3 pos, System.Single gridSize) { }
        // RVA: 0x03D56A30  token: 0x600080E
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000117  // size: 0x40
    public class NearPointSearch : MagicaCloth.GridHash
    {
        // Fields
        private System.Single radius;  // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> nearDict;  // 0x28
        private System.Collections.Generic.Dictionary<System.Int32,System.Single> distDict;  // 0x30
        private System.Collections.Generic.HashSet<System.UInt32> lockPairSet;  // 0x38

        // Methods
        // RVA: 0x089CC628  token: 0x6000810
        public System.Void Create(Unity.Mathematics.float3[] positionList, System.Single radius) { }
        // RVA: 0x089CC9E4  token: 0x6000811
        public System.Void SearchNearPointAll() { }
        // RVA: 0x089CCC64  token: 0x6000812
        public System.Void SearchNearPoint(System.Int32 id, Unity.Mathematics.float3 pos) { }
        // RVA: 0x089CD130  token: 0x6000813
        public System.Void SearchNearPoint(Unity.Mathematics.float3 pos, System.Single r) { }
        // RVA: 0x089CC600  token: 0x6000814
        public virtual System.Void AddPoint(Unity.Mathematics.float3 pos, System.Int32 id) { }
        // RVA: 0x089CC914  token: 0x6000815
        public virtual System.Void Remove(Unity.Mathematics.float3 pos, System.Int32 id) { }
        // RVA: 0x089CC590  token: 0x6000816
        public System.Void AddLockPair(System.Int32 id1, System.Int32 id2) { }
        // RVA: 0x089CC6B4  token: 0x6000817
        public System.Boolean GetNearPointPair(System.Int32& id1, System.Int32& id2) { }
        // RVA: 0x089CD48C  token: 0x6000818
        public virtual System.String ToString() { }
        // RVA: 0x089CD6D4  token: 0x6000819
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000118  // size: 0x20
    public sealed struct ChunkData
    {
        // Fields
        public System.Int32 chunkNo;  // 0x10
        public System.Int32 startIndex;  // 0x14
        public System.Int32 dataLength;  // 0x18
        public System.Int32 useLength;  // 0x1c

        // Methods
        // RVA: 0x03D6E2E0  token: 0x600081A
        public System.Void Clear() { }
        // RVA: 0x04278130  token: 0x600081B
        public System.Boolean IsValid() { }
        // RVA: 0x089BE0C4  token: 0x600081C
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000119
    public class DoubleComputeBuffer`1 : System.IDisposable
    {
        // Fields
        private UnityEngine.ComputeBuffer buffer0;  // 0x0
        private UnityEngine.ComputeBuffer buffer1;  // 0x0
        private Unity.Collections.NativeArray<T> nativeArrya;  // 0x0
        public System.UInt32 bufferID;  // 0x0
        public System.UInt32 bufferOffset;  // 0x0
        public System.Int32 bufferCount;  // 0x0

        // Properties
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600081D
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x600081E
        public System.Void Swap() { }
        // RVA: -1  // not resolved  token: 0x600081F
        public System.Void Create(System.Int32 size, UnityEngine.ComputeBufferType type, UnityEngine.ComputeBufferMode usage) { }
        // RVA: -1  // not resolved  token: 0x6000820
        public System.Void BeginWrite(System.Int32 length) { }
        // RVA: -1  // not resolved  token: 0x6000821
        public System.Void EndWrite(System.Int32 length) { }
        // RVA: -1  // not resolved  token: 0x6000822
        public Unity.Collections.NativeArray<T> GetNativeArray() { }
        // RVA: -1  // not resolved  token: 0x6000823
        public UnityEngine.ComputeBuffer GetBuffer(System.Int32 bufferIndex) { }
        // RVA: -1  // not resolved  token: 0x6000825
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200011A
    public class ExNativeHashMap`2
    {
        // Fields
        private Unity.Collections.NativeParallelHashMap<TKey,TValue> nativeHashMap;  // 0x0
        private System.Int32 nativeLength;  // 0x0
        private System.Collections.Generic.HashSet<TKey> useKeySet;  // 0x0

        // Properties
        System.Int32 NativeCount { get; /* RVA: -1  // not resolved */ }
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        Unity.Collections.NativeParallelHashMap<TKey,TValue> Map { get; /* RVA: -1  // not resolved */ }
        System.Collections.Generic.HashSet<TKey> UseKeySet { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000826
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000827
        public System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000829
        public System.Void Add(TKey key, TValue value) { }
        // RVA: -1  // not resolved  token: 0x600082A
        public TValue Get(TKey key) { }
        // RVA: -1  // not resolved  token: 0x600082B
        public System.Void Remove(System.Func<TKey,TValue,System.Boolean> func) { }
        // RVA: -1  // not resolved  token: 0x600082C
        public System.Void Replace(System.Func<TKey,TValue,System.Boolean> func, System.Func<TValue,TValue> datafunc) { }
        // RVA: -1  // not resolved  token: 0x600082D
        public System.Void Remove(TKey key) { }
        // RVA: -1  // not resolved  token: 0x600082F
        public System.Void Clear() { }

    }

    // TypeToken: 0x200011B
    public class ExNativeMultiHashMap`2
    {
        // Fields
        private Unity.Collections.NativeParallelMultiHashMap<TKey,TValue> nativeMultiHashMap;  // 0x0
        private System.Int32 nativeLength;  // 0x0
        private System.Collections.Generic.Dictionary<TKey,System.Int32> useKeyDict;  // 0x0

        // Properties
        System.Int32 NativeCount { get; /* RVA: -1  // not resolved */ }
        System.Boolean IsCreated { get; /* RVA: -1  // not resolved */ }
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        Unity.Collections.NativeParallelMultiHashMap<TKey,TValue> Map { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000832
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000833
        public System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000836
        public System.Void Add(TKey key, TValue value) { }
        // RVA: -1  // not resolved  token: 0x6000837
        public System.Void Remove(TKey key, TValue value) { }
        // RVA: -1  // not resolved  token: 0x6000838
        public System.Void Remove(System.Func<TKey,TValue,System.Boolean> func) { }
        // RVA: -1  // not resolved  token: 0x6000839
        public System.Void Replace(System.Func<TKey,TValue,System.Boolean> func, System.Func<TValue,TValue> datafunc) { }
        // RVA: -1  // not resolved  token: 0x600083A
        public System.Void Process(System.Action<TKey,TValue> act) { }
        // RVA: -1  // not resolved  token: 0x600083B
        public System.Void Process(TKey key, System.Action<TValue> act) { }
        // RVA: -1  // not resolved  token: 0x600083C
        public System.Boolean Contains(TKey key, TValue value) { }
        // RVA: -1  // not resolved  token: 0x600083D
        public System.Boolean Contains(TKey key) { }
        // RVA: -1  // not resolved  token: 0x600083E
        public System.Void Remove(TKey key) { }
        // RVA: -1  // not resolved  token: 0x6000840
        public System.Void Clear() { }

    }

    // TypeToken: 0x200011C
    public class FixedChunkNativeArray`1 : System.IDisposable
    {
        // Fields
        private Unity.Collections.NativeArray<T> nativeArray0;  // 0x0
        private Unity.Collections.NativeArray<T> nativeArray1;  // 0x0
        private System.Int32 nativeLength;  // 0x0
        private System.Collections.Generic.List<MagicaCloth.ChunkData> emptyChunkList;  // 0x0
        private System.Collections.Generic.List<MagicaCloth.ChunkData> useChunkList;  // 0x0
        private System.Int32 chunkSeed;  // 0x0
        private System.Int32 initLength;  // 0x0
        private T emptyElement;  // 0x0
        private System.Int32 useLength;  // 0x0

        // Properties
        System.Int32 Length { get; /* RVA: -1  // not resolved */ }
        System.Int32 ChunkCount { get; /* RVA: -1  // not resolved */ }
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        T Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000842
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000843
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000844
        public System.Void SetEmptyElement(T empty) { }
        // RVA: -1  // not resolved  token: 0x6000845
        public MagicaCloth.ChunkData AddChunk(System.Int32 length) { }
        // RVA: -1  // not resolved  token: 0x6000846
        public MagicaCloth.ChunkData Add(T data) { }
        // RVA: -1  // not resolved  token: 0x6000847
        public System.Void RemoveChunk(System.Int32 chunkNo) { }
        // RVA: -1  // not resolved  token: 0x6000848
        public System.Void RemoveChunk(MagicaCloth.ChunkData chunk) { }
        // RVA: -1  // not resolved  token: 0x6000849
        public System.Void Fill(MagicaCloth.ChunkData chunk, T data) { }
        // RVA: -1  // not resolved  token: 0x600084F
        public Unity.Collections.NativeArray<T> ToJobArray() { }
        // RVA: -1  // not resolved  token: 0x6000850
        public Unity.Collections.NativeArray<T> ToJobArray(System.Int32 bufferIndex) { }
        // RVA: -1  // not resolved  token: 0x6000851
        public System.Void SwapBuffer() { }
        // RVA: -1  // not resolved  token: 0x6000852
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200011D
    public class FixedMultiNativeList`1 : System.IDisposable
    {
        // Fields
        private Unity.Collections.NativeArray<T> nativeArray;  // 0x0
        private System.Int32 nativeLength;  // 0x0
        private System.Collections.Generic.List<MagicaCloth.ChunkData> emptyChunkList;  // 0x0
        private System.Collections.Generic.List<MagicaCloth.ChunkData> useChunkList;  // 0x0
        private System.Int32 chunkSeed;  // 0x0
        private System.Int32 initLength;  // 0x0
        private T emptyElement;  // 0x0
        private System.Int32 useLength;  // 0x0

        // Properties
        System.Int32 Length { get; /* RVA: -1  // not resolved */ }
        System.Int32 ChunkCount { get; /* RVA: -1  // not resolved */ }
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        T Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000853
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000854
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000855
        public System.Void SetEmptyElement(T empty) { }
        // RVA: -1  // not resolved  token: 0x6000856
        public MagicaCloth.ChunkData AddChunk(System.Int32 length) { }
        // RVA: -1  // not resolved  token: 0x6000857
        public System.Void RemoveChunk(System.Int32 chunkNo) { }
        // RVA: -1  // not resolved  token: 0x6000858
        public System.Void RemoveChunk(MagicaCloth.ChunkData chunk) { }
        // RVA: -1  // not resolved  token: 0x6000859
        public MagicaCloth.ChunkData AddData(MagicaCloth.ChunkData chunk, T data) { }
        // RVA: -1  // not resolved  token: 0x600085A
        public MagicaCloth.ChunkData RemoveData(MagicaCloth.ChunkData chunk, T data) { }
        // RVA: -1  // not resolved  token: 0x600085B
        public MagicaCloth.ChunkData ClearData(MagicaCloth.ChunkData chunk) { }
        // RVA: -1  // not resolved  token: 0x600085C
        public System.Void Process(MagicaCloth.ChunkData chunk, System.Action<T> act) { }
        // RVA: -1  // not resolved  token: 0x6000861
        public Unity.Collections.NativeArray<T> ToJobArray() { }
        // RVA: -1  // not resolved  token: 0x6000862
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200011E
    public class FixedNativeList`1 : System.IDisposable
    {
        // Fields
        private Unity.Collections.NativeArray<T> nativeArray0;  // 0x0
        private Unity.Collections.NativeArray<T> nativeArray1;  // 0x0
        private System.Int32 nativeLength;  // 0x0
        private System.Collections.Generic.Queue<System.Int32> emptyStack;  // 0x0
        private System.Collections.Generic.HashSet<System.Int32> useIndexSet;  // 0x0
        private System.Int32 useLength;  // 0x0

        // Properties
        System.Int32 Length { get; /* RVA: -1  // not resolved */ }
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        T Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000863
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000864
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000865
        public System.Int32 Add(T element) { }
        // RVA: -1  // not resolved  token: 0x6000866
        public System.Void Remove(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x6000867
        public System.Boolean Exists(System.Int32 index) { }
        // RVA: -1  // not resolved  token: 0x600086C
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x600086D
        public Unity.Collections.NativeArray<T> ToJobArray() { }
        // RVA: -1  // not resolved  token: 0x600086E
        public Unity.Collections.NativeArray<T> ToJobArray(System.Int32 bufferIndex) { }
        // RVA: -1  // not resolved  token: 0x600086F
        public System.Void SyncBuffer() { }

    }

    // TypeToken: 0x200011F
    public class FixedNativeListWithCount`1 : System.IDisposable
    {
        // Fields
        private Unity.Collections.NativeList<T> nativeList;  // 0x0
        private System.Int32 nativeLength;  // 0x0
        private System.Collections.Generic.Queue<System.Int32> emptyStack;  // 0x0
        private System.Collections.Generic.HashSet<System.Int32> useIndexSet;  // 0x0
        private System.Collections.Generic.Dictionary<T,System.Int32> indexDict;  // 0x0
        private System.Collections.Generic.Dictionary<T,System.Int32> countDict;  // 0x0
        private T emptyElement;  // 0x0

        // Properties
        System.Int32 Length { get; /* RVA: -1  // not resolved */ }
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        T Item { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000870
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x6000871
        public System.Void .ctor(System.Int32 capacity) { }
        // RVA: -1  // not resolved  token: 0x6000872
        public virtual System.Void Dispose() { }
        // RVA: -1  // not resolved  token: 0x6000873
        public System.Void SetEmptyElement(T empty) { }
        // RVA: -1  // not resolved  token: 0x6000874
        public System.Int32 Add(T element) { }
        // RVA: -1  // not resolved  token: 0x6000875
        public System.Void Remove(T element) { }
        // RVA: -1  // not resolved  token: 0x6000876
        public System.Boolean Exist(T element) { }
        // RVA: -1  // not resolved  token: 0x6000877
        public System.Int32 GetUseCount(T element) { }
        // RVA: -1  // not resolved  token: 0x600087C
        public System.Void Clear() { }
        // RVA: -1  // not resolved  token: 0x600087D
        public T[] ToArray() { }
        // RVA: -1  // not resolved  token: 0x600087E
        public Unity.Collections.NativeArray<T> ToJobArray() { }

    }

    // TypeToken: 0x2000120  // size: 0x40
    public class FixedTransformAccessArray : System.IDisposable
    {
        // Fields
        private UnityEngine.Jobs.TransformAccessArray transformArray;  // 0x10
        private System.Int32 nativeLength;  // 0x18
        private System.Collections.Generic.Queue<System.Int32> emptyStack;  // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> useIndexDict;  // 0x28
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> indexDict;  // 0x30
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> referenceDict;  // 0x38

        // Properties
        System.Int32 Count { get; /* RVA: 0x023128D0 */ }
        System.Int32 Length { get; /* RVA: 0x020D1AC0 */ }
        UnityEngine.Transform Item { get; /* RVA: 0x054694D8 */ }

        // Methods
        // RVA: 0x02E117E0  token: 0x600087F
        public System.Void .ctor(System.Int32 desiredJobCount) { }
        // RVA: 0x089BF56C  token: 0x6000880
        public System.Void .ctor(System.Int32 capacity, System.Int32 desiredJobCount) { }
        // RVA: 0x089BEDE4  token: 0x6000881
        public System.Int32 Add(UnityEngine.Transform element) { }
        // RVA: 0x089BF3F4  token: 0x6000882
        public System.Void Remove(System.Int32 index) { }
        // RVA: 0x089BF2E4  token: 0x6000883
        public System.Boolean Exist(System.Int32 index) { }
        // RVA: 0x089BF250  token: 0x6000884
        public System.Boolean Exist(UnityEngine.Transform element) { }
        // RVA: 0x089BF338  token: 0x6000888
        public System.Int32 GetIndex(UnityEngine.Transform element) { }
        // RVA: 0x089BEFBC  token: 0x6000889
        public System.Void Clear() { }
        // RVA: 0x089BF1A8  token: 0x600088A
        public virtual System.Void Dispose() { }
        // RVA: 0x020B7B20  token: 0x600088B
        public UnityEngine.Jobs.TransformAccessArray GetTransformAccessArray() { }

    }

    // TypeToken: 0x2000121  // size: 0x10
    public static class NativeArrayExtension
    {
        // Methods
        // RVA: -1  // generic def  token: 0x600088C
        public static System.Void CopyToFast(Unity.Collections.NativeArray<T> nativeArray, System.Int32 startIndex, T2[] array) { }
        // RVA: -1  // generic def  token: 0x600088D
        public static System.Void CopyToFast(Unity.Collections.NativeArray<T> nativeArray, System.Int32 startIndex, Unity.Collections.NativeArray<T> array) { }
        // RVA: -1  // generic def  token: 0x600088E
        public static System.Void CopyBlock(Unity.Collections.NativeArray<T> nativeArray, System.Int32 sourceIndex, System.Int32 destinationIndex, System.Int32 count) { }
        // RVA: -1  // generic def  token: 0x600088F
        public static System.Void CopyFromFast(Unity.Collections.NativeArray<T> nativeArray, Unity.Collections.NativeArray<T> array) { }
        // RVA: -1  // generic def  token: 0x6000890
        public static System.Void CopyFromFast(Unity.Collections.NativeArray<T> nativeArray, System.Int32 startIndex, T2[] array) { }
        // RVA: -1  // generic def  token: 0x6000891
        public static System.Void SetValue(Unity.Collections.NativeArray<T> nativeArray, System.Int32 startIndex, System.Int32 count, T value) { }

    }

    // TypeToken: 0x2000122
    public abstract class CreateSingleton`1 : UnityEngine.MonoBehaviour
    {
        // Fields
        private static T instance;  // static @ 0x0
        private static T initInstance;  // static @ 0x0
        private static System.Boolean isDestroy;  // static @ 0x0

        // Properties
        T Instance { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000892
        protected static System.Void InitMember() { }
        // RVA: -1  // not resolved  token: 0x6000894
        private static System.Void InitInstance() { }
        // RVA: -1  // not resolved  token: 0x6000895
        public static System.Boolean IsInstance() { }
        // RVA: -1  // not resolved  token: 0x6000896
        protected virtual System.Void Awake() { }
        // RVA: -1  // not resolved  token: 0x6000897
        protected virtual System.Void OnDestroy() { }
        // RVA: -1  // not resolved  token: 0x6000898
        protected virtual System.Void DuplicateDetection(T duplicate) { }
        // RVA: -1  // abstract  token: 0x6000899
        protected virtual System.Void InitSingleton() { }
        // RVA: -1  // not resolved  token: 0x600089A
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000123  // size: 0x10
    public static class DataUtility
    {
        // Methods
        // RVA: 0x0553DFA0  token: 0x600089B
        public static System.UInt32 PackPair(System.Int32 v0, System.Int32 v1) { }
        // RVA: 0x03D6DD50  token: 0x600089C
        public static System.Void UnpackPair(System.UInt32 pack, System.Int32& v0, System.Int32& v1) { }
        // RVA: 0x03D4FDB0  token: 0x600089D
        public static System.UInt32 Pack16(System.Int32 hi, System.Int32 low) { }
        // RVA: 0x03D4FE90  token: 0x600089E
        public static System.Int32 Unpack16Hi(System.UInt32 pack) { }
        // RVA: 0x03D4FEA0  token: 0x600089F
        public static System.Int32 Unpack16Low(System.UInt32 pack) { }
        // RVA: 0x03D6E2F0  token: 0x60008A0
        public static System.UInt32 Pack4_28(System.Int32 hi, System.Int32 low) { }
        // RVA: 0x03D6E310  token: 0x60008A1
        public static System.Int32 Unpack4_28Hi(System.UInt32 pack) { }
        // RVA: 0x03D6E320  token: 0x60008A2
        public static System.Int32 Unpack4_28Low(System.UInt32 pack) { }
        // RVA: 0x03D6E300  token: 0x60008A3
        public static System.UInt32 Pack8_24(System.Int32 hi, System.Int32 low) { }
        // RVA: 0x03D6E330  token: 0x60008A4
        public static System.Int32 Unpack8_24Hi(System.UInt32 pack) { }
        // RVA: 0x03D6E340  token: 0x60008A5
        public static System.Int32 Unpack8_24Low(System.UInt32 pack) { }
        // RVA: 0x03D5C690  token: 0x60008A6
        public static System.UInt64 Pack32(System.Int32 hi, System.Int32 low) { }
        // RVA: 0x03D68B20  token: 0x60008A7
        public static System.Int32 Unpack32Hi(System.UInt64 pack) { }
        // RVA: 0x03D517B0  token: 0x60008A8
        public static System.Int32 Unpack32Low(System.UInt64 pack) { }
        // RVA: 0x089BE760  token: 0x60008A9
        public static System.UInt64 PackTriple(System.Int32 v0, System.Int32 v1, System.Int32 v2) { }
        // RVA: 0x03D6DD90  token: 0x60008AA
        public static System.Void UnpackTriple(System.UInt64 pack, System.Int32& v0, System.Int32& v1, System.Int32& v2) { }
        // RVA: 0x089BE5E8  token: 0x60008AB
        public static System.UInt64 PackQuater(System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3) { }
        // RVA: 0x03D6DD60  token: 0x60008AC
        public static System.Void UnpackQuater(System.UInt64 pack, System.Int32& v0, System.Int32& v1, System.Int32& v2, System.Int32& v3) { }

    }

    // TypeToken: 0x2000124  // size: 0x10
    public static class Develop
    {
        // Methods
        // RVA: 0x089BE89C  token: 0x60008AD
        public static System.Void Log(System.String str) { }

    }

    // TypeToken: 0x2000125  // size: 0x10
    public static class GizmoUtility
    {
        // Fields
        public static readonly UnityEngine.Color ColorDynamic;  // static @ 0x0
        public static readonly UnityEngine.Color ColorKinematic;  // static @ 0x10
        public static readonly UnityEngine.Color ColorInvalid;  // static @ 0x20
        public static readonly UnityEngine.Color ColorCollider;  // static @ 0x30
        public static readonly UnityEngine.Color ColorNonSelectedCollider;  // static @ 0x40
        public static readonly UnityEngine.Color ColorTriangle;  // static @ 0x50
        public static readonly UnityEngine.Color ColorStructLine;  // static @ 0x60
        public static readonly UnityEngine.Color ColorBendLine;  // static @ 0x70
        public static readonly UnityEngine.Color ColorNearLine;  // static @ 0x80
        public static readonly UnityEngine.Color ColorRotationLine;  // static @ 0x90
        public static readonly UnityEngine.Color ColorAdjustLine;  // static @ 0xa0
        public static readonly UnityEngine.Color ColorAirLine;  // static @ 0xb0
        public static readonly UnityEngine.Color ColorBasePosition;  // static @ 0xc0
        public static readonly UnityEngine.Color ColorDirectionMoveLimit;  // static @ 0xd0
        public static readonly UnityEngine.Color ColorPenetration;  // static @ 0xe0
        public static readonly UnityEngine.Color ColorCollisionNormal;  // static @ 0xf0
        public static readonly UnityEngine.Color ColorVelocity;  // static @ 0x100
        public static readonly UnityEngine.Color ColorSkinningBone;  // static @ 0x110
        public static readonly UnityEngine.Color ColorDeformerPoint;  // static @ 0x120
        public static readonly UnityEngine.Color ColorDeformerPointRange;  // static @ 0x130
        public static readonly UnityEngine.Color ColorWind;  // static @ 0x140

        // Methods
        // RVA: 0x089C00DC  token: 0x60008AE
        public static System.Void DrawWireCapsule(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 scl, UnityEngine.Vector3 ldir, UnityEngine.Vector3 lup, System.Single length, System.Single startRadius, System.Single endRadius, System.Boolean resetMatrix) { }
        // RVA: 0x089C0A7C  token: 0x60008AF
        public static System.Void DrawWireSphere(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 scl, System.Single radius, System.Boolean drawSphere, System.Boolean drawAxis, System.Boolean resetMatrix) { }
        // RVA: 0x089C0960  token: 0x60008B0
        public static System.Void DrawWireCube(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 size, System.Boolean resetMatrix) { }
        // RVA: 0x089C054C  token: 0x60008B1
        public static System.Void DrawWireCone(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, System.Single length, System.Single radius, System.Int32 div) { }
        // RVA: 0x089BFD60  token: 0x60008B2
        public static System.Void DrawWireArrow(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 size, System.Boolean cross) { }
        // RVA: 0x089BF6E0  token: 0x60008B3
        public static System.Void DrawAxis(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, System.Single size, System.Boolean resetMatrix) { }
        // RVA: 0x089BF934  token: 0x60008B4
        public static System.Void DrawBone(UnityEngine.Vector3 pos, UnityEngine.Vector3 tpos, System.Single size) { }
        // RVA: 0x089C0D14  token: 0x60008B5
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000126  // size: 0x10
    public static class MathUtility
    {
        // Methods
        // RVA: 0x05540454  token: 0x60008B6
        public static System.Single Clamp1(System.Single a) { }
        // RVA: 0x089C152C  token: 0x60008B7
        public static System.Single Clamp01(System.Single a) { }
        // RVA: 0x08982AA4  token: 0x60008B8
        public static Unity.Mathematics.float3 Project(Unity.Mathematics.float3 v, Unity.Mathematics.float3 n) { }
        // RVA: 0x05467B08  token: 0x60008B9
        public static System.Single Angle(Unity.Mathematics.float3 v1, Unity.Mathematics.float3 v2) { }
        // RVA: 0x08982678  token: 0x60008BA
        public static Unity.Mathematics.float3 ClampVector(Unity.Mathematics.float3 v, System.Single minlength, System.Single maxlength) { }
        // RVA: 0x089C1854  token: 0x60008BB
        public static Unity.Mathematics.float3 ClampVector(Unity.Mathematics.float3 v, System.Single maxlength) { }
        // RVA: 0x08996D04  token: 0x60008BC
        public static Unity.Mathematics.float3 ClampDistance(Unity.Mathematics.float3 from, Unity.Mathematics.float3 to, System.Single maxlength) { }
        // RVA: 0x089C153C  token: 0x60008BD
        public static System.Boolean ClampAngle(Unity.Mathematics.float3 dir, Unity.Mathematics.float3 basedir, System.Single maxAngle, Unity.Mathematics.float3& outdir) { }
        // RVA: 0x089C2650  token: 0x60008BE
        public static Unity.Mathematics.quaternion FromToRotation(Unity.Mathematics.float3 from, Unity.Mathematics.float3 to, System.Single t) { }
        // RVA: 0x054D91BC  token: 0x60008BF
        public static Unity.Mathematics.quaternion FromToRotation(Unity.Mathematics.quaternion from, Unity.Mathematics.quaternion to) { }
        // RVA: 0x089C1400  token: 0x60008C0
        public static System.Single Angle(Unity.Mathematics.quaternion a, Unity.Mathematics.quaternion b) { }
        // RVA: 0x089C17BC  token: 0x60008C1
        public static Unity.Mathematics.quaternion ClampAngle(Unity.Mathematics.quaternion from, Unity.Mathematics.quaternion to, System.Single maxAngle) { }
        // RVA: 0x089C1464  token: 0x60008C2
        public static Unity.Mathematics.float3 AxisToEuler(Unity.Mathematics.float3 axis) { }
        // RVA: 0x089A6148  token: 0x60008C3
        public static Unity.Mathematics.quaternion AxisQuaternion(Unity.Mathematics.float3 dir) { }
        // RVA: 0x0898274C  token: 0x60008C4
        public static System.Single ClosestPtPointSegmentRatio(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b) { }
        // RVA: 0x089C1A48  token: 0x60008C5
        public static System.Single ClosestPtPointSegmentRatioNoClamp(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b) { }
        // RVA: 0x0895B20C  token: 0x60008C6
        public static Unity.Mathematics.float3 ClosestPtPointSegment(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b) { }
        // RVA: 0x089C1900  token: 0x60008C7
        public static Unity.Mathematics.float3 ClosestPtPointSegmentNoClamp(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b) { }
        // RVA: 0x08982994  token: 0x60008C8
        public static System.Boolean IntersectPointPlane(Unity.Mathematics.float3 planePos, Unity.Mathematics.float3 planeDir, Unity.Mathematics.float3 pos, Unity.Mathematics.float3& outpos) { }
        // RVA: 0x08982834  token: 0x60008C9
        public static System.Single IntersectPointPlaneDist(Unity.Mathematics.float3 planePos, Unity.Mathematics.float3 planeDir, Unity.Mathematics.float3 pos, Unity.Mathematics.float3& outPos) { }
        // RVA: 0x089C4510  token: 0x60008CA
        public static System.Boolean IntersectSegmentPlane(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 p, Unity.Mathematics.float3 pn, Unity.Mathematics.float3& opos) { }
        // RVA: 0x089C3CAC  token: 0x60008CB
        public static System.Boolean IntersectPointSphere(Unity.Mathematics.float3 sc, System.Single sr, Unity.Mathematics.float3 pos, Unity.Mathematics.float3& outPos) { }
        // RVA: 0x089BBB38  token: 0x60008CC
        public static System.Boolean IntersectPointSphere(Unity.Mathematics.float3 p, Unity.Mathematics.float3 sc, System.Single sr) { }
        // RVA: 0x089C4374  token: 0x60008CD
        public static System.Boolean IntersectRaySphere(Unity.Mathematics.float3 p, Unity.Mathematics.float3 d, Unity.Mathematics.float3 sc, System.Single sr, Unity.Mathematics.float3& q, System.Single& t) { }
        // RVA: 0x089C36EC  token: 0x60008CE
        public static System.Boolean IntersectLineSphare(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 sc, System.Single sr, Unity.Mathematics.float3& q) { }
        // RVA: 0x089C3DFC  token: 0x60008CF
        public static System.Boolean IntersectRayCone(Unity.Mathematics.float3 o, Unity.Mathematics.float3 d, Unity.Mathematics.float3 c, Unity.Mathematics.float3 v, System.Single cost, System.Single& t, Unity.Mathematics.float3& p) { }
        // RVA: 0x089C2C48  token: 0x60008D0
        public static System.Boolean IntersectLineConeSurface(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 d, System.Single dlen, Unity.Mathematics.float3 c, Unity.Mathematics.float3 v, System.Single cost, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2, Unity.Mathematics.float3& p) { }
        // RVA: 0x089C32D4  token: 0x60008D1
        public static System.Boolean IntersectLineCylinderSurface(Unity.Mathematics.float3 sa, Unity.Mathematics.float3 sb, Unity.Mathematics.float3 p, Unity.Mathematics.float3 q, System.Single r, System.Single& t) { }
        // RVA: 0x089C2E04  token: 0x60008D2
        public static System.Boolean IntersectLineCylinderSurface(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2, System.Single r1, System.Single r2, Unity.Mathematics.float3& p) { }
        // RVA: 0x089C28E8  token: 0x60008D3
        public static System.Boolean IntersectLineCapsule(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2, System.Single r1, System.Single r2, Unity.Mathematics.float3& p) { }
        // RVA: 0x089C5AF4  token: 0x60008D4
        public static System.Boolean IntersectTrianglePointDistance(Unity.Mathematics.float3 p, Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2, System.Single restDist, System.Single compressionStiffness, System.Single stretchStiffness, Unity.Mathematics.float3& corr, Unity.Mathematics.float3& corr0, Unity.Mathematics.float3& corr1, Unity.Mathematics.float3& corr2) { }
        // RVA: 0x089C5068  token: 0x60008D5
        public static System.Boolean IntersectTrianglePointDistanceSide(Unity.Mathematics.float3 p, Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2, System.Single restDist, System.Single compressionStiffness, System.Single stretchStiffness, System.Single side, Unity.Mathematics.float3& corr, Unity.Mathematics.float3& corr0, Unity.Mathematics.float3& corr1, Unity.Mathematics.float3& corr2) { }
        // RVA: 0x089C468C  token: 0x60008D6
        public static System.Boolean IntersectTrianglePointDistanceSide2(Unity.Mathematics.float3 p, Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2, System.Single radius, System.Single restDist, System.Single compressionStiffness, System.Single stretchStiffness, System.Single side, Unity.Mathematics.float3& corr, Unity.Mathematics.float3& corr0, Unity.Mathematics.float3& corr1, Unity.Mathematics.float3& corr2) { }
        // RVA: 0x089C2010  token: 0x60008D7
        public static System.Single DistanceTrianglePoint(Unity.Mathematics.float3 p, Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2) { }
        // RVA: 0x05543D84  token: 0x60008D8
        public static Unity.Mathematics.float3 TriangleCenter(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2) { }
        // RVA: 0x0895B368  token: 0x60008D9
        public static Unity.Mathematics.float3 TriangleNormal(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2) { }
        // RVA: 0x089C666C  token: 0x60008DA
        public static Unity.Mathematics.quaternion TriangleRotation(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2) { }
        // RVA: 0x089C64C8  token: 0x60008DB
        public static Unity.Mathematics.quaternion TriangleCenterRotation(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2, Unity.Mathematics.float3 p3) { }
        // RVA: 0x055411AC  token: 0x60008DC
        public static System.Single DistanceTriangleCenter(Unity.Mathematics.float3 p, Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2) { }
        // RVA: 0x05541090  token: 0x60008DD
        public static System.Single DirectionPointTriangle(Unity.Mathematics.float3 p, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c) { }
        // RVA: 0x089C389C  token: 0x60008DE
        public static System.Boolean IntersectLineTriangle(Unity.Mathematics.float3 p, Unity.Mathematics.float3 q, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c, Unity.Mathematics.float3& hitpos, System.Single& t, Unity.Mathematics.float3& n) { }
        // RVA: 0x089C1B24  token: 0x60008DF
        public static System.Single ClosestPtSegmentSegment(Unity.Mathematics.float3 p1, Unity.Mathematics.float3 q1, Unity.Mathematics.float3 p2, Unity.Mathematics.float3 q2, System.Single& s, System.Single& t, Unity.Mathematics.float3& c1, Unity.Mathematics.float3& c2) { }
        // RVA: 0x089C2890  token: 0x60008E0
        public static System.Single GetBezierValue(MagicaCloth.BezierParam bparam, System.Single t) { }
        // RVA: 0x089BBAAC  token: 0x60008E1
        public static System.Single GetBezierValue(System.Single sval, System.Single eval, System.Single curve, System.Single t) { }

    }

    // TypeToken: 0x2000127  // size: 0x10
    public static class MeshUtility
    {
        // Methods
        // RVA: 0x089CB930  token: 0x60008E2
        public static UnityEngine.GameObject ReplaceSkinnedMeshRendererToMeshRenderer(UnityEngine.SkinnedMeshRenderer sren, System.Boolean replaceSkinnedMeshRenderer) { }
        // RVA: 0x089C7590  token: 0x60008E3
        public static System.Boolean CalcMeshWorldPositionNormalTangent(MagicaCloth.MeshData meshData, System.Collections.Generic.List<UnityEngine.Transform> boneList, System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        // RVA: 0x089C7BD0  token: 0x60008E4
        public static System.Boolean CalcMeshWorldPositionNormalTangent(UnityEngine.Renderer ren, UnityEngine.Mesh mesh, System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector3>& wtanList) { }
        // RVA: 0x089C68E8  token: 0x60008E5
        public static System.Boolean CalcMeshLocalNormalTangent(System.Collections.Generic.List<System.Int32> selectList, UnityEngine.Vector3[] vlist, UnityEngine.Vector2[] uvlist, System.Int32[] triangles, System.Collections.Generic.List<UnityEngine.Vector3>& lnorList, System.Collections.Generic.List<UnityEngine.Vector3>& ltanList) { }
        // RVA: 0x089CADF8  token: 0x60008E6
        public static System.Collections.Generic.List<System.Collections.Generic.HashSet<System.Int32>> GetTriangleToVertexLinkList(System.Int32 vcnt, System.Collections.Generic.List<System.Int32> lineList, System.Collections.Generic.List<System.Int32> triangleList) { }
        // RVA: 0x089CB50C  token: 0x60008E7
        public static System.Collections.Generic.List<System.Collections.Generic.HashSet<System.Int32>> GetVertexLinkList(System.Int32 vcnt, System.Collections.Generic.HashSet<System.UInt32> lineSet) { }
        // RVA: 0x089CB78C  token: 0x60008E8
        public static System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.HashSet<System.Int32>> GetVertexToTriangles(System.Collections.Generic.List<System.Int32> triangleList) { }
        // RVA: 0x089CBD18  token: 0x60008E9
        public static System.Int32 RestTriangleVertex(System.Int32 tindex, System.Int32 v0, System.Int32 v1, System.Collections.Generic.List<System.Int32> triangleList) { }
        // RVA: 0x089CBC14  token: 0x60008EA
        public static System.Void RestTriangleVertex(System.Int32 tindex, System.Int32 v0, System.Collections.Generic.List<System.Int32> triangleList, System.Int32& v1, System.Int32& v2) { }
        // RVA: 0x089CA7E8  token: 0x60008EB
        public static System.Boolean CheckAdjacentTriangle(System.Int32 tindex0, System.Int32 tindex1, System.Collections.Generic.List<System.Int32> triangleList) { }
        // RVA: 0x089CAB50  token: 0x60008EC
        public static System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.List<System.Int32>> GetTriangleEdgePair(System.Collections.Generic.List<System.Int32> triangleList) { }
        // RVA: 0x089C67C8  token: 0x60008ED
        private static System.Void AddTriangleEdge(System.Int32 v0, System.Int32 v1, System.Int32 tindex, System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.List<System.Int32>> triangleEdgeDict) { }
        // RVA: 0x089CACBC  token: 0x60008EE
        public static System.Collections.Generic.List<System.UInt64> GetTrianglePackList(System.Collections.Generic.List<System.Int32> triangleList) { }
        // RVA: 0x089CA8AC  token: 0x60008EF
        public static System.Single ClosestPtBoneLine(UnityEngine.Vector3 pos, UnityEngine.Transform bone, System.Single lineWidth, UnityEngine.Vector3& d) { }
        // RVA: 0x089CB16C  token: 0x60008F0
        public static System.Collections.Generic.List<UnityEngine.Transform> GetUseBoneTransformList(UnityEngine.Transform[] bones, UnityEngine.Mesh mesh) { }
        // RVA: 0x089C864C  token: 0x60008F1
        public static System.Void CalcTetraMesh(System.Collections.Generic.List<UnityEngine.Vector3> posList, System.Int32& tetraCount, System.Collections.Generic.List<System.Int32>& tetraIndexList, System.Collections.Generic.List<System.Single>& tetraSizeList) { }
        // RVA: -1  // generic def  token: 0x60008F2
        public static UnityEngine.Transform GetReplaceBone(UnityEngine.Transform now, System.Collections.Generic.Dictionary<T,UnityEngine.Transform> boneReplaceDict) { }

    }

    // TypeToken: 0x200012A  // size: 0x10
    public class StaticStringBuilder
    {
        // Fields
        private static System.Text.StringBuilder stringBuilder;  // static @ 0x0

        // Properties
        System.Text.StringBuilder Instance { get; /* RVA: 0x089D2684 */ }

        // Methods
        // RVA: 0x089D2550  token: 0x6000900
        public static System.Void Clear() { }
        // RVA: 0x089D24B0  token: 0x6000901
        public static System.Text.StringBuilder Append(System.Object[] args) { }
        // RVA: 0x089D2284  token: 0x6000902
        public static System.Text.StringBuilder AppendLine(System.Object[] args) { }
        // RVA: 0x089D2358  token: 0x6000903
        public static System.Text.StringBuilder AppendLine() { }
        // RVA: 0x089D23D4  token: 0x6000904
        public static System.String AppendToString(System.Object[] args) { }
        // RVA: 0x089D25A8  token: 0x6000905
        public static System.String ToString() { }
        // RVA: 0x0350B670  token: 0x6000906
        public System.Void .ctor() { }
        // RVA: 0x089D2600  token: 0x6000907
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200012B  // size: 0x30
    public class UpdateTimeManager
    {
        // Fields
        private MagicaCloth.UpdateTimeManager.UpdateCount updatePerSeccond;  // 0x10
        private MagicaCloth.UpdateTimeManager.UpdateMode updateMode;  // 0x14
        private MagicaCloth.UpdateTimeManager.UpdateLocation updateLocation;  // 0x18
        private System.Single timeScale;  // 0x1c
        private System.Single futurePredictionRate;  // 0x20
        private System.Boolean updateBoneScale;  // 0x24
        private System.Int32 fixedUpdateCount;  // 0x28

        // Properties
        System.Int32 FixedUpdateCount { get; /* RVA: 0x03D4EB90 */ }
        System.Int32 UpdatePerSecond { get; /* RVA: 0x03D4E340 */ }
        System.Single UpdateIntervalTime { get; /* RVA: 0x03D6E410 */ }
        System.Single UpdatePower { get; /* RVA: 0x03D6E430 */ }
        System.Single TimeScale { get; /* RVA: 0x03D4F110 */ set; /* RVA: 0x04270578 */ }
        System.Single DeltaTime { get; /* RVA: 0x0426F800 */ }
        System.Single PhysicsDeltaTime { get; /* RVA: 0x02312BC0 */ }
        System.Single AverageDeltaTime { get; /* RVA: 0x089D3624 */ }
        System.Boolean IsUnscaledUpdate { get; /* RVA: 0x089D362C */ }
        System.Boolean IsDelay { get; /* RVA: 0x02312B00 */ }
        System.Single FuturePredictionRate { get; /* RVA: 0x03D4F2E0 */ set; /* RVA: 0x089D3648 */ }
        System.Boolean UpdateBoneScale { get; /* RVA: 0x03D4F090 */ set; /* RVA: 0x03D4F0A0 */ }
        System.Int32 WorkerMaximumCount { get; /* RVA: 0x089D3640 */ }

        // Methods
        // RVA: 0x03D6E3E0  token: 0x6000908
        public System.Void ResetFixedUpdateCount() { }
        // RVA: 0x03D69B30  token: 0x6000909
        public System.Void AddFixedUpdateCount() { }
        // RVA: 0x03D50CC0  token: 0x600090B
        public MagicaCloth.UpdateTimeManager.UpdateMode GetUpdateMode() { }
        // RVA: 0x03D595B0  token: 0x600090C
        public System.Void SetUpdateMode(MagicaCloth.UpdateTimeManager.UpdateMode mode) { }
        // RVA: 0x020D1AC0  token: 0x600090D
        public MagicaCloth.UpdateTimeManager.UpdateLocation GetUpdateLocation() { }
        // RVA: 0x03D4E9C0  token: 0x600090E
        public System.Void SetUpdateLocation(MagicaCloth.UpdateTimeManager.UpdateLocation location) { }
        // RVA: 0x010410F0  token: 0x6000910
        public System.Void SetUpdatePerSecond(MagicaCloth.UpdateTimeManager.UpdateCount ucount) { }
        // RVA: 0x03D6E3F0  token: 0x600091F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200012F
    public class ReferenceDataBuilder`1
    {
        // Fields
        private System.Int32 indexCount;  // 0x0
        private System.Collections.Generic.List<T> dataList;  // 0x0
        private System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> indexToDataIndexList;  // 0x0
        private System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> dataIndexToIndexList;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x6000920
        public System.Void Init(System.Int32 indexCount) { }
        // RVA: -1  // not resolved  token: 0x6000921
        public System.Void AddData(T data, System.Int32[] indexes) { }
        // RVA: -1  // not resolved  token: 0x6000922
        public System.ValueTuple<System.Collections.Generic.List<MagicaCloth.ReferenceDataIndex>,System.Collections.Generic.List<T>> GetDirectReferenceData() { }
        // RVA: -1  // not resolved  token: 0x6000923
        public System.ValueTuple<System.Collections.Generic.List<MagicaCloth.ReferenceDataIndex>,System.Collections.Generic.List<System.Int32>,System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>> GetIndirectReferenceData() { }
        // RVA: -1  // not resolved  token: 0x6000924
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000130  // size: 0x18
    public sealed struct ReferenceDataIndex
    {
        // Fields
        public System.Int32 startIndex;  // 0x10
        public System.Int32 count;  // 0x14

    }

    // TypeToken: 0x2000131
    public interface IDataHash
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000925
        public virtual System.Int32 GetDataHash() { }

    }

    // TypeToken: 0x2000132
    public interface IShareDataObject
    {
        // Methods
        // RVA: -1  // abstract  token: 0x6000926
        public virtual System.Collections.Generic.List<MagicaCloth.ShareDataObject> GetAllShareDataObject() { }
        // RVA: -1  // abstract  token: 0x6000927
        public virtual MagicaCloth.ShareDataObject DuplicateShareDataObject(MagicaCloth.ShareDataObject source) { }

    }

    // TypeToken: 0x2000133  // size: 0x20
    public abstract class ShareDataObject : UnityEngine.ScriptableObject, MagicaCloth.IDataVerify, MagicaCloth.IDataHash
    {
        // Fields
        protected System.Int32 dataHash;  // 0x18
        protected System.Int32 dataVersion;  // 0x1c

        // Properties
        System.Int32 SaveDataHash { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }
        System.Int32 SaveDataVersion { get; /* RVA: 0x03D4EBB0 */ set; /* RVA: 0x03D4EBC0 */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000928
        public virtual System.Int32 GetDataHash() { }
        // RVA: -1  // abstract  token: 0x600092D
        public virtual System.Int32 GetVersion() { }
        // RVA: -1  // abstract  token: 0x600092E
        public virtual MagicaCloth.Define.Error VerifyData() { }
        // RVA: 0x089D2228  token: 0x600092F
        public virtual System.Void CreateVerifyData() { }
        // RVA: 0x089D2258  token: 0x6000930
        public virtual System.String GetInformation() { }
        // RVA: -1  // generic def  token: 0x6000931
        public static T CreateShareData(System.String dataName) { }
        // RVA: -1  // generic def  token: 0x6000932
        public static System.Boolean RemoveNullAndDuplication(System.Collections.Generic.List<T> data) { }
        // RVA: -1  // generic def  token: 0x6000933
        public static T Clone(T source) { }
        // RVA: 0x0286F540  token: 0x6000934
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000134  // size: 0x18
    public class StopWatch
    {
        // Fields
        private System.Single startTime;  // 0x10
        private System.Single endTime;  // 0x14

        // Properties
        System.Single ElapsedSeconds { get; /* RVA: 0x03D6E3B0 */ }
        System.Single ElapsedMilliseconds { get; /* RVA: 0x03D6E390 */ }

        // Methods
        // RVA: 0x089D26D4  token: 0x6000935
        public MagicaCloth.StopWatch Start() { }
        // RVA: 0x089D26F4  token: 0x6000936
        public MagicaCloth.StopWatch Stop() { }
        // RVA: 0x0350B670  token: 0x6000939
        public System.Void .ctor() { }

    }

}

namespace MagicaReductionMesh
{

    // TypeToken: 0x2000004  // size: 0x30
    public class ReductionMesh
    {
        // Fields
        private MagicaReductionMesh.ReductionMesh.ReductionWeightMode <WeightMode>k__BackingField;  // 0x10
        private MagicaReductionMesh.MeshData meshData;  // 0x18
        private MagicaReductionMesh.ReductionData reductionData;  // 0x20
        private MagicaReductionMesh.DebugData debugData;  // 0x28

        // Properties
        MagicaReductionMesh.ReductionMesh.ReductionWeightMode WeightMode { get; /* RVA: 0x03D4E340 */ set; /* RVA: 0x010410F0 */ }
        MagicaReductionMesh.MeshData MeshData { get; /* RVA: 0x089549FC */ }
        MagicaReductionMesh.ReductionData ReductionData { get; /* RVA: 0x03A46A50 */ }
        MagicaReductionMesh.DebugData DebugData { get; /* RVA: 0x089549D0 */ }

        // Methods
        // RVA: 0x08954788  token: 0x6000008
        public System.Int32 AddMesh(System.Boolean isSkinning, UnityEngine.Mesh mesh, System.Collections.Generic.List<UnityEngine.Transform> bones, UnityEngine.Matrix4x4[] bindPoseList, UnityEngine.BoneWeight[] boneWeightList) { }
        // RVA: 0x0895450C  token: 0x6000009
        public System.Int32 AddMesh(UnityEngine.Renderer ren) { }
        // RVA: 0x08954498  token: 0x600000A
        public System.Int32 AddMesh(UnityEngine.Transform root, System.Collections.Generic.List<UnityEngine.Vector3> posList, System.Collections.Generic.List<UnityEngine.Vector3> norList, System.Collections.Generic.List<UnityEngine.Vector4> tanList, System.Collections.Generic.List<UnityEngine.Vector2> uvList, System.Collections.Generic.List<System.Int32> triangleList) { }
        // RVA: 0x08954820  token: 0x600000B
        public System.Void Reduction(System.Single zeroRadius, System.Single radius, System.Single polygonLength, System.Boolean createTetra) { }
        // RVA: 0x089547F0  token: 0x600000C
        public MagicaReductionMesh.FinalData GetFinalData(UnityEngine.Transform root) { }
        // RVA: 0x08954918  token: 0x600000D
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000006  // size: 0x18
    public abstract class ReductionMeshAccess
    {
        // Fields
        protected MagicaReductionMesh.ReductionMesh parent;  // 0x10

        // Properties
        MagicaReductionMesh.MeshData MeshData { get; /* RVA: 0x08954458 */ }
        MagicaReductionMesh.ReductionData ReductionData { get; /* RVA: 0x08954478 */ }
        MagicaReductionMesh.DebugData DebugData { get; /* RVA: 0x08954438 */ }

        // Methods
        // RVA: 0x0426FEE0  token: 0x6000011
        public virtual System.Void SetParent(MagicaReductionMesh.ReductionMesh parent) { }
        // RVA: 0x0350B670  token: 0x6000012
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000007  // size: 0x18
    public class DebugData : MagicaReductionMesh.ReductionMeshAccess
    {
        // Methods
        // RVA: 0x0894540C  token: 0x6000013
        public System.Void DispMeshInfo(System.String header) { }
        // RVA: 0x08944848  token: 0x6000014
        public static System.Void DebugDrawShared(MagicaReductionMesh.FinalData final, System.Boolean drawTriangle, System.Boolean drawLine, System.Boolean drawTetra, System.Boolean drawVertexNormal, System.Boolean drawVertexTangent, System.Boolean drawNumber, System.Int32 maxPolygonCount, System.Int32 layer, System.Int32 tetraIndex, System.Single tetraSize, System.Collections.Generic.List<System.Int32> drawNumberList, System.Single axisSize) { }
        // RVA: 0x089456B8  token: 0x6000015
        private static System.Void DrawTetra(MagicaReductionMesh.FinalData final, System.Int32 tetraIndex, System.Collections.Generic.List<UnityEngine.Vector3> wposList, System.Single tetraSize) { }
        // RVA: 0x08944394  token: 0x6000016
        public static System.Void DebugDrawChild(MagicaReductionMesh.FinalData final, System.Boolean drawPosition, System.Boolean drawNormal, System.Boolean drawTriangle, System.Boolean drawNumber, System.Int32 maxVertexCount, System.Single positionSize, System.Single axisSize) { }
        // RVA: 0x0350B670  token: 0x6000017
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000008  // size: 0x98
    public class FinalData
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Vector3> vertices;  // 0x10
        public System.Collections.Generic.List<UnityEngine.Vector3> normals;  // 0x18
        public System.Collections.Generic.List<UnityEngine.Vector4> tangents;  // 0x20
        public System.Collections.Generic.List<UnityEngine.Vector2> uvs;  // 0x28
        public System.Collections.Generic.List<UnityEngine.BoneWeight> boneWeights;  // 0x30
        public System.Collections.Generic.List<UnityEngine.Matrix4x4> bindPoses;  // 0x38
        public System.Collections.Generic.List<UnityEngine.Transform> bones;  // 0x40
        public System.Collections.Generic.List<System.Int32> lines;  // 0x48
        public System.Collections.Generic.List<System.Int32> triangles;  // 0x50
        public System.Collections.Generic.List<System.Int32> tetras;  // 0x58
        public System.Collections.Generic.List<System.Single> tetraSizes;  // 0x60
        public System.Collections.Generic.List<UnityEngine.Matrix4x4> vertexBindPoses;  // 0x68
        public System.Collections.Generic.List<MagicaReductionMesh.FinalData.MeshIndexData> vertexToMeshIndexList;  // 0x70
        public System.Collections.Generic.List<System.Int32> vertexToTriangleCountList;  // 0x78
        public System.Collections.Generic.List<System.Int32> vertexToTriangleStartList;  // 0x80
        public System.Collections.Generic.List<System.Int32> vertexToTriangleIndexList;  // 0x88
        public System.Collections.Generic.List<MagicaReductionMesh.FinalData.MeshInfo> meshList;  // 0x90

        // Properties
        System.Boolean IsValid { get; /* RVA: 0x08945E58 */ }
        System.Int32 VertexCount { get; /* RVA: 0x08945FB4 */ }
        System.Int32 LineCount { get; /* RVA: 0x08945E9C */ }
        System.Int32 TriangleCount { get; /* RVA: 0x08945F68 */ }
        System.Int32 TetraCount { get; /* RVA: 0x08945F20 */ }
        System.Int32 BoneCount { get; /* RVA: 0x08945E18 */ }
        System.Boolean IsSkinning { get; /* RVA: 0x0232EB60 */ }
        System.Int32 MeshCount { get; /* RVA: 0x08945EE0 */ }

        // Methods
        // RVA: 0x08945978  token: 0x6000020
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000B  // size: 0x68
    public class MeshData : MagicaReductionMesh.ReductionMeshAccess
    {
        // Fields
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.Vertex> originalVertexList;  // 0x18
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.MeshInfo> meshInfoList;  // 0x20
        public System.Collections.Generic.List<MagicaReductionMesh.MeshData.ShareVertex> shareVertexList;  // 0x28
        private System.Collections.Generic.Dictionary<System.UInt64,MagicaReductionMesh.MeshData.Triangle> triangleDict;  // 0x30
        private System.Collections.Generic.Dictionary<System.UInt32,MagicaReductionMesh.MeshData.Line> lineDict;  // 0x38
        public System.Collections.Generic.List<UnityEngine.Transform> boneList;  // 0x40
        private System.Collections.Generic.List<MagicaReductionMesh.MeshData.Tetra> tetraList;  // 0x48
        private System.Single weightPow;  // 0x50
        private System.Int32 maxWeightCount;  // 0x54
        private System.Single sameSurfaceAngle;  // 0x58
        private System.Boolean removeSameTrianglePair;  // 0x5c
        private System.Single removeSameTrianglePairAngle;  // 0x60

        // Properties
        System.Int32 VertexCount { get; /* RVA: 0x089512EC */ }
        System.Int32 LineCount { get; /* RVA: 0x089511EC */ }
        System.Int32 TriangleCount { get; /* RVA: 0x089512AC */ }
        System.Int32 TetraCount { get; /* RVA: 0x0895126C */ }
        System.Int32 MeshCount { get; /* RVA: 0x0895122C */ }
        System.Single WeightPow { get; /* RVA: 0x03D51C90 */ set; /* RVA: 0x03D51CA0 */ }
        System.Int32 MaxWeightCount { get; /* RVA: 0x03D4EEC0 */ set; /* RVA: 0x03D4EF10 */ }
        System.Single SameSurfaceAngle { get; /* RVA: 0x03D51080 */ set; /* RVA: 0x03D510B0 */ }
        System.Boolean RemoveSameTrianglePair { get; /* RVA: 0x03D4F600 */ set; /* RVA: 0x03D4F620 */ }
        System.Single RemoveSameTrianglePairAngle { get; /* RVA: 0x03D50D50 */ set; /* RVA: 0x03D50D80 */ }

        // Methods
        // RVA: 0x089467CC  token: 0x6000033
        public System.Int32 AddMesh(System.Boolean isSkinning, UnityEngine.Mesh mesh, System.Collections.Generic.List<UnityEngine.Transform> bones, UnityEngine.Matrix4x4[] bindPoseList, UnityEngine.BoneWeight[] boneWeightList) { }
        // RVA: 0x0894606C  token: 0x6000034
        public System.Int32 AddMesh(UnityEngine.Transform root, System.Collections.Generic.List<UnityEngine.Vector3> posList, System.Collections.Generic.List<UnityEngine.Vector3> norList, System.Collections.Generic.List<UnityEngine.Vector4> tanList, System.Collections.Generic.List<UnityEngine.Vector2> uvList, System.Collections.Generic.List<System.Int32> triangleList) { }
        // RVA: 0x089499B4  token: 0x6000035
        public System.Void CombineVertex(MagicaReductionMesh.MeshData.ShareVertex sv0, MagicaReductionMesh.MeshData.ShareVertex sv1) { }
        // RVA: 0x08950F24  token: 0x6000036
        public System.Void UpdateMeshData(System.Boolean createTetra) { }
        // RVA: 0x089495B4  token: 0x6000037
        private System.Void CalcVertexIndex() { }
        // RVA: 0x089491DC  token: 0x6000038
        private System.Void CalcUV(MagicaReductionMesh.MeshData.UvWrapMode wrapMode) { }
        // RVA: 0x0894C68C  token: 0x6000039
        private System.Void CreateTriangleAndLine() { }
        // RVA: 0x08948DF8  token: 0x600003A
        private System.Void CalcShareVertexWeight() { }
        // RVA: 0x089476B4  token: 0x600003B
        private System.Void AdjustTriangleNormal() { }
        // RVA: 0x08949870  token: 0x600003C
        private System.Boolean CheckTwoTriangleOpen(MagicaReductionMesh.MeshData.Triangle tri1, MagicaReductionMesh.MeshData.Triangle tri2, System.UInt32 edge) { }
        // RVA: 0x08948F30  token: 0x600003D
        private System.Single CalcTwoTriangleAngle(MagicaReductionMesh.MeshData.Triangle tri1, MagicaReductionMesh.MeshData.Triangle tri2, System.UInt32 edge) { }
        // RVA: 0x0894DA84  token: 0x600003E
        private System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.List<System.UInt64>> GetEdgeToTriangleDict() { }
        // RVA: 0x0894975C  token: 0x600003F
        private System.Void CalcVertexNormalFromTriangle() { }
        // RVA: 0x08950350  token: 0x6000040
        private System.Void RemoveTriangle(System.UInt64 thash) { }
        // RVA: 0x0894F9D0  token: 0x6000041
        private System.Collections.Generic.Dictionary<System.UInt64,System.Collections.Generic.List<MagicaReductionMesh.MeshData.Square>> GetSquareDict() { }
        // RVA: 0x08950240  token: 0x6000042
        private System.Void RemoveOverlappingSquareTriangles() { }
        // RVA: 0x0894ADE0  token: 0x6000043
        private System.Void CreateTetraMesh() { }
        // RVA: 0x08948160  token: 0x6000044
        private UnityEngine.Bounds CalcBounding() { }
        // RVA: 0x0894DFAC  token: 0x6000045
        public MagicaReductionMesh.FinalData GetFinalData(UnityEngine.Transform root) { }
        // RVA: 0x08949CE4  token: 0x6000046
        private System.Void CreateOriginalMeshInfo(MagicaReductionMesh.FinalData final, UnityEngine.Transform root, System.Single weightLength) { }
        // RVA: 0x0894761C  token: 0x6000047
        private System.Void AddVertexToMeshIndexData(MagicaReductionMesh.FinalData final, System.Int32 sindex, System.Int32 meshIndex, System.Int32 meshVertexIndex) { }
        // RVA: 0x08950568  token: 0x6000048
        private System.Collections.Generic.List<MagicaReductionMesh.MeshData.ShareVertex> SearchNearPointList(UnityEngine.Vector3 basePos, MagicaReductionMesh.MeshData.ShareVertex sv, System.Single weightLength, System.Int32 maxCount) { }
        // RVA: 0x08948374  token: 0x6000049
        public System.Void CalcMeshWorldPositionNormalTangent(System.Boolean isSkinning, UnityEngine.Mesh mesh, System.Collections.Generic.List<UnityEngine.Transform> bones, UnityEngine.Matrix4x4[] bindPoseList, UnityEngine.BoneWeight[] boneWeightList, System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector4>& wtanList) { }
        // RVA: 0x08950F8C  token: 0x600004A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001F  // size: 0x18
    public class ReductionData : MagicaReductionMesh.ReductionMeshAccess
    {
        // Methods
        // RVA: 0x089543AC  token: 0x6000087
        public System.Void ReductionZeroDistance(System.Single radius) { }
        // RVA: 0x08954320  token: 0x6000088
        public System.Void ReductionRadius(System.Single radius) { }
        // RVA: 0x08954294  token: 0x6000089
        public System.Void ReductionPolygonLink(System.Single length) { }
        // RVA: 0x08953DC8  token: 0x600008A
        public System.Void ReductionBone() { }
        // RVA: 0x0350B670  token: 0x600008B
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000020  // size: 0x38
    public class NearPointReduction
    {
        // Fields
        protected MagicaReductionMesh.MeshData meshData;  // 0x10
        private System.Collections.Generic.List<MagicaReductionMesh.NearPointReduction.Point> pointList;  // 0x18
        protected System.Collections.Generic.Dictionary<UnityEngine.Vector3Int,System.Collections.Generic.List<MagicaReductionMesh.NearPointReduction.Point>> gridMap;  // 0x20
        protected System.Single gridSize;  // 0x28
        private System.Single searchRadius;  // 0x2c
        private System.Collections.Generic.Dictionary<MagicaReductionMesh.NearPointReduction.Point,System.Collections.Generic.List<MagicaReductionMesh.NearPointReduction.Point>> nearPointDict;  // 0x30

        // Properties
        System.Int32 PointCount { get; /* RVA: 0x08952E60 */ }

        // Methods
        // RVA: 0x08952D34  token: 0x600008C
        public System.Void .ctor(System.Single radius) { }
        // RVA: 0x08951834  token: 0x600008E
        public System.Void Create(MagicaReductionMesh.MeshData meshData) { }
        // RVA: 0x08951BD8  token: 0x600008F
        public System.Void Reduction() { }
        // RVA: 0x08951778  token: 0x6000090
        private MagicaReductionMesh.NearPointReduction.Point AddPoint(MagicaReductionMesh.MeshData.ShareVertex sv, UnityEngine.Vector3 pos) { }
        // RVA: 0x089515E8  token: 0x6000091
        private System.Void AddGrid(MagicaReductionMesh.NearPointReduction.Point p) { }
        // RVA: 0x0895211C  token: 0x6000092
        private System.Void RemoveGrid(MagicaReductionMesh.NearPointReduction.Point p) { }
        // RVA: 0x08951B80  token: 0x6000093
        private System.Void Move(MagicaReductionMesh.NearPointReduction.Point p, UnityEngine.Vector3 newpos) { }
        // RVA: 0x08952298  token: 0x6000094
        private System.Void Remove(MagicaReductionMesh.NearPointReduction.Point p) { }
        // RVA: 0x089519A8  token: 0x6000095
        protected UnityEngine.Vector3Int GetGridPos(UnityEngine.Vector3 pos) { }
        // RVA: 0x089522FC  token: 0x6000096
        private System.Void SearchNearPointAll() { }
        // RVA: 0x08952590  token: 0x6000097
        private System.Void SearchNearPoint(MagicaReductionMesh.NearPointReduction.Point p, System.Single radius, MagicaReductionMesh.NearPointReduction.Point ignorePoint) { }
        // RVA: 0x08951A20  token: 0x6000098
        private MagicaReductionMesh.NearPointReduction.Point GetNearPointPair() { }

    }

    // TypeToken: 0x2000022  // size: 0x30
    public class PolygonLinkReduction
    {
        // Fields
        protected MagicaReductionMesh.MeshData meshData;  // 0x10
        private System.Single reductionLength;  // 0x18
        private System.Collections.Generic.List<MagicaReductionMesh.PolygonLinkReduction.Point> pointList;  // 0x20
        private System.Collections.Generic.Dictionary<MagicaReductionMesh.MeshData.ShareVertex,MagicaReductionMesh.PolygonLinkReduction.Point> pointDict;  // 0x28

        // Properties
        System.Int32 PointCount { get; /* RVA: 0x08953D88 */ }

        // Methods
        // RVA: 0x08953CB8  token: 0x600009A
        public System.Void .ctor(System.Single length) { }
        // RVA: 0x08952F54  token: 0x600009C
        public System.Void Create(MagicaReductionMesh.MeshData meshData) { }
        // RVA: 0x08953284  token: 0x600009D
        public System.Void Reduction() { }
        // RVA: 0x08952EA0  token: 0x600009E
        private System.Void AddPoint(MagicaReductionMesh.MeshData.ShareVertex sv) { }
        // RVA: 0x08953200  token: 0x600009F
        private MagicaReductionMesh.PolygonLinkReduction.Point GetPoint(MagicaReductionMesh.MeshData.ShareVertex sv) { }
        // RVA: 0x089538BC  token: 0x60000A0
        private System.Void Remove(MagicaReductionMesh.PolygonLinkReduction.Point p) { }
        // RVA: 0x0895393C  token: 0x60000A1
        private System.Void SearchNearPointAll() { }
        // RVA: 0x08953A50  token: 0x60000A2
        private System.Void SearchNearPoint(MagicaReductionMesh.PolygonLinkReduction.Point p) { }
        // RVA: 0x089530A0  token: 0x60000A3
        private MagicaReductionMesh.PolygonLinkReduction.Point GetNearPointPair() { }

    }

    // TypeToken: 0x2000024  // size: 0x10
    public class Utility
    {
        // Methods
        // RVA: 0x0553DFA0  token: 0x60000A5
        public static System.UInt32 PackPair(System.Int32 v0, System.Int32 v1) { }
        // RVA: 0x03D6DD50  token: 0x60000A6
        public static System.Void UnpackPair(System.UInt32 pack, System.Int32& v0, System.Int32& v1) { }
        // RVA: 0x0895ACA0  token: 0x60000A7
        public static System.UInt64 PackTriple(System.Int32 v0, System.Int32 v1, System.Int32 v2) { }
        // RVA: 0x03D6DD90  token: 0x60000A8
        public static System.Void UnpackTriple(System.UInt64 pack, System.Int32& v0, System.Int32& v1, System.Int32& v2) { }
        // RVA: 0x0895AB28  token: 0x60000A9
        public static System.UInt64 PackQuater(System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3) { }
        // RVA: 0x03D6DD60  token: 0x60000AA
        public static System.Void UnpackQuater(System.UInt64 pack, System.Int32& v0, System.Int32& v1, System.Int32& v2, System.Int32& v3) { }
        // RVA: 0x03D4FDB0  token: 0x60000AB
        public static System.UInt32 Pack16(System.Int32 hi, System.Int32 low) { }
        // RVA: 0x03D4FE90  token: 0x60000AC
        public static System.Int32 Unpack16Hi(System.UInt32 pack) { }
        // RVA: 0x03D4FEA0  token: 0x60000AD
        public static System.Int32 Unpack16Low(System.UInt32 pack) { }
        // RVA: 0x03D5C690  token: 0x60000AE
        public static System.UInt64 Pack32(System.Int32 hi, System.Int32 low) { }
        // RVA: 0x03D68B20  token: 0x60000AF
        public static System.Int32 Unpack32Hi(System.UInt64 pack) { }
        // RVA: 0x03D517B0  token: 0x60000B0
        public static System.Int32 Unpack32Low(System.UInt64 pack) { }
        // RVA: 0x08959F1C  token: 0x60000B1
        public static System.Void CalcFinalDataWorldPositionNormalTangent(MagicaReductionMesh.FinalData final, System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector4>& wtanList) { }
        // RVA: 0x089593C8  token: 0x60000B2
        public static System.Void CalcFinalDataChildWorldPositionNormalTangent(MagicaReductionMesh.FinalData final, System.Int32 meshIndex, System.Collections.Generic.List<UnityEngine.Vector3> sposList, System.Collections.Generic.List<UnityEngine.Vector3> snorList, System.Collections.Generic.List<UnityEngine.Vector4> stanList, System.Collections.Generic.List<UnityEngine.Vector3>& wposList, System.Collections.Generic.List<UnityEngine.Vector3>& wnorList, System.Collections.Generic.List<UnityEngine.Vector4>& wtanList) { }
        // RVA: 0x0895A8B0  token: 0x60000B3
        public static System.Void CalcLocalPositionNormalTangent(UnityEngine.Transform root, System.Collections.Generic.List<UnityEngine.Vector3> wposList, System.Collections.Generic.List<UnityEngine.Vector3> wnorList, System.Collections.Generic.List<UnityEngine.Vector4> wtanList) { }
        // RVA: 0x0350B670  token: 0x60000B4
        public System.Void .ctor() { }

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

