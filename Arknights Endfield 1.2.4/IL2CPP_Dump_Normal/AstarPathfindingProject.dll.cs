// ========================================================
// Dumped by @desirepro
// Assembly: AstarPathfindingProject.dll
// Classes:  22
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x200000F  // size: 0x90
    public sealed struct RVOParallelJob : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Int32 agentCount;  // 0x10
        public Unity.Collections.NativeList<RVO.RVOAgentJobData> agents;  // 0x18
        public System.Int32 obstacleCount;  // 0x28
        public System.Single breakingBias;  // 0x2c
        public Unity.Collections.NativeArray<System.Int32> obsBufferMaxIndex;  // 0x30
        public Unity.Collections.NativeArray<System.Int32> agentBufferMaxIndex;  // 0x40
        public Unity.Collections.NativeArray<RVO.VO> obsVoBuffer;  // 0x50
        public Unity.Collections.NativeArray<RVO.VO> agentVoBuffer;  // 0x60
        public Unity.Collections.NativeArray<System.Single> calculatedSpeeds;  // 0x70
        public Unity.Collections.NativeArray<UnityEngine.Vector2> calculatedTargetPoints;  // 0x80

        // Methods
        // RVA: 0x05141A68  token: 0x6000097
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000010  // size: 0x68
    public sealed struct JobForCalcObstacleVO : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Int32 agentCount;  // 0x10
        public Unity.Collections.NativeList<RVO.RVOAgentJobData> agents;  // 0x18
        public System.Int32 obstacleCount;  // 0x28
        public Unity.Collections.NativeList<RVO.RVOObstacleJobData> obstacles;  // 0x30
        public System.Single deltaTime;  // 0x40
        public Unity.Collections.NativeArray<System.Int32> obsBufferMaxIndex;  // 0x48
        public Unity.Collections.NativeArray<RVO.VO> obsVoBuffer;  // 0x58

        // Methods
        // RVA: 0x05141208  token: 0x6000098
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000011  // size: 0x60
    public sealed struct JobForCalcAgentNeighbourVO : Unity.Jobs.IJobParallelFor
    {
        // Fields
        public System.Int32 agentCount;  // 0x10
        public Unity.Collections.NativeList<RVO.RVOAgentJobData> agents;  // 0x18
        public Unity.Collections.NativeList<System.Boolean> agentNeighbours;  // 0x28
        public System.Single deltaTime;  // 0x38
        public Unity.Collections.NativeArray<System.Int32> agentBufferMaxIndex;  // 0x40
        public Unity.Collections.NativeArray<RVO.VO> agentVoBuffer;  // 0x50

        // Methods
        // RVA: 0x05140E84  token: 0x6000099
        public virtual System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000014  // size: 0x28
    public sealed struct Node
    {
        // Fields
        public System.Int32 child00;  // 0x10
        public RVO.RVOAgent linkedList;  // 0x18
        public System.Byte count;  // 0x20
        public System.Single maxSpeed;  // 0x24

        // Methods
        // RVA: 0x023E9600  token: 0x60000A3
        public System.Void Add(RVO.RVOAgent rvoAgent) { }
        // RVA: 0x02ED2800  token: 0x60000A4
        public System.Void Distribute(RVO.RVOQuadtree.Node[] nodes, UnityEngine.Rect r) { }
        // RVA: 0x02EC0480  token: 0x60000A5
        public System.Single CalculateMaxSpeed(RVO.RVOQuadtree.Node[] nodes, System.Int32 index) { }

    }

    // TypeToken: 0x2000015  // size: 0x38
    public sealed struct QuadtreeQuery
    {
        // Fields
        public UnityEngine.Vector2 p;  // 0x10
        public System.Single speed;  // 0x18
        public System.Single timeHorizon;  // 0x1c
        public System.Single agentRadius;  // 0x20
        public System.Single maxRadius;  // 0x24
        public RVO.RVOAgent RvoAgent;  // 0x28
        public RVO.RVOQuadtree.Node[] nodes;  // 0x30

        // Methods
        // RVA: 0x023E87B0  token: 0x60000A6
        public System.Void QueryRec(System.Int32 i, UnityEngine.Rect r) { }

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

namespace RVO
{

    // TypeToken: 0x2000004  // size: 0x10
    public static class AstarMemory
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000003
        public static T[] ShrinkArray(T[] arr, System.Int32 newLength) { }
        // RVA: -1  // generic def  token: 0x6000004
        public static System.Void Swap(T& a, T& b) { }
        // RVA: -1  // generic def  token: 0x6000005
        public static System.Void Realloc(Unity.Collections.NativeArray<T>& arr, System.Int32 newSize, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options) { }
        // RVA: -1  // generic def  token: 0x6000006
        public static System.Void Realloc(T[]& arr, System.Int32 newSize) { }
        // RVA: -1  // generic def  token: 0x6000007
        public static T[] UnsafeAppendBufferToArray(Unity.Collections.LowLevel.Unsafe.UnsafeAppendBuffer src) { }

    }

    // TypeToken: 0x2000005  // size: 0x10
    public static class NativeCollectionExtensions
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000008
        public static System.Void FillIn(Unity.Collections.NativeArray<T>& array, System.Int32 start, System.Int32 length, T value) { }
        // RVA: -1  // generic def  token: 0x6000009
        public static System.Void SetValueAt(Unity.Collections.NativeArray<T>& array, System.Int32 index, T value) { }
        // RVA: -1  // generic def  token: 0x600000A
        public static T GetValueAt(Unity.Collections.NativeArray<T>& array, System.Int32 index) { }

    }

    // TypeToken: 0x2000006  // size: 0x14
    public sealed struct RVOLayer
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static RVO.RVOLayer DefaultAgent;  // const
        public static RVO.RVOLayer DefaultObstacle;  // const
        public static RVO.RVOLayer Character;  // const
        public static RVO.RVOLayer Enemy;  // const
        public static RVO.RVOLayer NPC;  // const
        public static RVO.RVOLayer FactoryObstacle;  // const
        public static RVO.RVOLayer Layer6;  // const
        public static RVO.RVOLayer Layer7;  // const
        public static RVO.RVOLayer Layer8;  // const
        public static RVO.RVOLayer Layer9;  // const
        public static RVO.RVOLayer Layer10;  // const
        public static RVO.RVOLayer Layer11;  // const
        public static RVO.RVOLayer Layer12;  // const
        public static RVO.RVOLayer Layer13;  // const
        public static RVO.RVOLayer Layer14;  // const
        public static RVO.RVOLayer Layer15;  // const
        public static RVO.RVOLayer Layer16;  // const
        public static RVO.RVOLayer Layer17;  // const
        public static RVO.RVOLayer Layer18;  // const
        public static RVO.RVOLayer Layer19;  // const
        public static RVO.RVOLayer Layer20;  // const
        public static RVO.RVOLayer Layer21;  // const
        public static RVO.RVOLayer Layer22;  // const
        public static RVO.RVOLayer Layer23;  // const
        public static RVO.RVOLayer Layer24;  // const
        public static RVO.RVOLayer Layer25;  // const
        public static RVO.RVOLayer Layer26;  // const
        public static RVO.RVOLayer Layer27;  // const
        public static RVO.RVOLayer Layer28;  // const
        public static RVO.RVOLayer Layer29;  // const
        public static RVO.RVOLayer Layer30;  // const

    }

    // TypeToken: 0x2000007  // size: 0x11
    public sealed struct Side
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static RVO.Side Colinear;  // const
        public static RVO.Side Left;  // const
        public static RVO.Side Right;  // const

    }

    // TypeToken: 0x2000008  // size: 0x10
    public static class VectorMath
    {
        // Methods
        // RVA: 0x03D4E860  token: 0x600000B
        public static UnityEngine.Vector2 ComplexMultiply(UnityEngine.Vector2 a, UnityEngine.Vector2 b) { }
        // RVA: 0x03D4E810  token: 0x600000C
        public static UnityEngine.Vector2 ComplexMultiplyConjugate(UnityEngine.Vector2 a, UnityEngine.Vector2 b) { }
        // RVA: 0x05143A80  token: 0x600000D
        public static UnityEngine.Vector3 ClosestPointOnLine(UnityEngine.Vector3 lineStart, UnityEngine.Vector3 lineEnd, UnityEngine.Vector3 point) { }
        // RVA: 0x051437E8  token: 0x600000E
        public static System.Single ClosestPointOnLineFactor(UnityEngine.Vector3 lineStart, UnityEngine.Vector3 lineEnd, UnityEngine.Vector3 point) { }
        // RVA: 0x051438C8  token: 0x600000F
        public static System.Single ClosestPointOnLineFactor(RVO.Int3 lineStart, RVO.Int3 lineEnd, RVO.Int3 point) { }
        // RVA: 0x051439D0  token: 0x6000010
        public static System.Single ClosestPointOnLineFactor(RVO.Int2 lineStart, RVO.Int2 lineEnd, RVO.Int2 point) { }
        // RVA: 0x05143D8C  token: 0x6000011
        public static UnityEngine.Vector3 ClosestPointOnSegment(UnityEngine.Vector3 lineStart, UnityEngine.Vector3 lineEnd, UnityEngine.Vector3 point) { }
        // RVA: 0x05143BC4  token: 0x6000012
        public static UnityEngine.Vector3 ClosestPointOnSegmentXZ(UnityEngine.Vector3 lineStart, UnityEngine.Vector3 lineEnd, UnityEngine.Vector3 point) { }
        // RVA: 0x05145DC4  token: 0x6000013
        public static System.Single SqrDistancePointSegmentApproximate(System.Int32 x, System.Int32 z, System.Int32 px, System.Int32 pz, System.Int32 qx, System.Int32 qz) { }
        // RVA: 0x05145CF0  token: 0x6000014
        public static System.Single SqrDistancePointSegmentApproximate(RVO.Int3 a, RVO.Int3 b, RVO.Int3 p) { }
        // RVA: 0x05145E98  token: 0x6000015
        public static System.Single SqrDistancePointSegment(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 p) { }
        // RVA: 0x05145F40  token: 0x6000016
        public static System.Single SqrDistanceSegmentSegment(UnityEngine.Vector3 s1, UnityEngine.Vector3 e1, UnityEngine.Vector3 s2, UnityEngine.Vector3 e2) { }
        // RVA: 0x051463AC  token: 0x6000017
        public static System.Single SqrDistanceXZ(UnityEngine.Vector3 a, UnityEngine.Vector3 b) { }
        // RVA: 0x03D4E920  token: 0x6000018
        public static System.Int64 SignedTriangleAreaTimes2XZ(RVO.Int3 a, RVO.Int3 b, RVO.Int3 c) { }
        // RVA: 0x03D4E8E0  token: 0x6000019
        public static System.Single SignedTriangleAreaTimes2XZ(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c) { }
        // RVA: 0x051452F0  token: 0x600001A
        public static System.Boolean RightXZ(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 p) { }
        // RVA: 0x05145334  token: 0x600001B
        public static System.Boolean RightXZ(RVO.Int3 a, RVO.Int3 b, RVO.Int3 p) { }
        // RVA: 0x05145CB4  token: 0x600001C
        public static RVO.Side SideXZ(RVO.Int3 a, RVO.Int3 b, RVO.Int3 p) { }
        // RVA: 0x05145294  token: 0x600001D
        public static System.Boolean RightOrColinear(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 p) { }
        // RVA: 0x05145258  token: 0x600001E
        public static System.Boolean RightOrColinear(RVO.Int2 a, RVO.Int2 b, RVO.Int2 p) { }
        // RVA: 0x051451E8  token: 0x600001F
        public static System.Boolean RightOrColinearXZ(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 p) { }
        // RVA: 0x05145224  token: 0x6000020
        public static System.Boolean RightOrColinearXZ(RVO.Int3 a, RVO.Int3 b, RVO.Int3 p) { }
        // RVA: 0x05143EEC  token: 0x6000021
        public static System.Boolean IsClockwiseMarginXZ(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c) { }
        // RVA: 0x0294A370  token: 0x6000022
        public static System.Boolean IsClockwiseXZ(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c) { }
        // RVA: 0x05143FF0  token: 0x6000023
        public static System.Boolean IsClockwiseXZ(RVO.Int3 a, RVO.Int3 b, RVO.Int3 c) { }
        // RVA: 0x05143F30  token: 0x6000024
        public static System.Boolean IsClockwiseOrColinearXZ(RVO.Int3 a, RVO.Int3 b, RVO.Int3 c) { }
        // RVA: 0x05143FB4  token: 0x6000025
        public static System.Boolean IsClockwiseOrColinear(RVO.Int2 a, RVO.Int2 b, RVO.Int2 c) { }
        // RVA: 0x0514419C  token: 0x6000026
        public static System.Boolean IsColinear(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c) { }
        // RVA: 0x05144130  token: 0x6000027
        public static System.Boolean IsColinear(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c) { }
        // RVA: 0x05144100  token: 0x6000028
        public static System.Boolean IsColinearXZ(RVO.Int3 a, RVO.Int3 b, RVO.Int3 c) { }
        // RVA: 0x051440B0  token: 0x6000029
        public static System.Boolean IsColinearXZ(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c) { }
        // RVA: 0x05144074  token: 0x600002A
        public static System.Boolean IsColinearAlmostXZ(RVO.Int3 a, RVO.Int3 b, RVO.Int3 c) { }
        // RVA: 0x05145B9C  token: 0x600002B
        public static System.Boolean SegmentsIntersect(RVO.Int2 start1, RVO.Int2 end1, RVO.Int2 start2, RVO.Int2 end2) { }
        // RVA: 0x05145874  token: 0x600002C
        public static System.Boolean SegmentsIntersectXZ(RVO.Int3 start1, RVO.Int3 end1, RVO.Int3 start2, RVO.Int3 end2) { }
        // RVA: 0x05145A6C  token: 0x600002D
        public static System.Boolean SegmentsIntersectXZ(UnityEngine.Vector3 start1, UnityEngine.Vector3 end1, UnityEngine.Vector3 start2, UnityEngine.Vector3 end2) { }
        // RVA: 0x05144C34  token: 0x600002E
        public static System.Boolean LineLineIntersectionFactor(UnityEngine.Vector2 start1, UnityEngine.Vector2 dir1, UnityEngine.Vector2 start2, UnityEngine.Vector2 dir2, System.Single& t) { }
        // RVA: 0x05144400  token: 0x600002F
        public static UnityEngine.Vector3 LineDirIntersectionPointXZ(UnityEngine.Vector3 start1, UnityEngine.Vector3 dir1, UnityEngine.Vector3 start2, UnityEngine.Vector3 dir2) { }
        // RVA: 0x051444D8  token: 0x6000030
        public static UnityEngine.Vector3 LineDirIntersectionPointXZ(UnityEngine.Vector3 start1, UnityEngine.Vector3 dir1, UnityEngine.Vector3 start2, UnityEngine.Vector3 dir2, System.Boolean& intersects) { }
        // RVA: 0x05144ED0  token: 0x6000031
        public static System.Boolean RaySegmentIntersectXZ(RVO.Int3 start1, RVO.Int3 end1, RVO.Int3 start2, RVO.Int3 end2) { }
        // RVA: 0x051445C8  token: 0x6000032
        public static System.Boolean LineIntersectionFactorXZ(RVO.Int3 start1, RVO.Int3 end1, RVO.Int3 start2, RVO.Int3 end2, System.Single& factor1, System.Single& factor2) { }
        // RVA: 0x051447FC  token: 0x6000033
        public static System.Boolean LineIntersectionFactorXZ(UnityEngine.Vector3 start1, UnityEngine.Vector3 end1, UnityEngine.Vector3 start2, UnityEngine.Vector3 end2, System.Single& factor1, System.Single& factor2) { }
        // RVA: 0x05144CC0  token: 0x6000034
        public static System.Single LineRayIntersectionFactorXZ(RVO.Int3 start1, RVO.Int3 end1, RVO.Int3 start2, RVO.Int3 end2) { }
        // RVA: 0x0514470C  token: 0x6000035
        public static System.Single LineIntersectionFactorXZ(UnityEngine.Vector3 start1, UnityEngine.Vector3 end1, UnityEngine.Vector3 start2, UnityEngine.Vector3 end2) { }
        // RVA: 0x05144938  token: 0x6000036
        public static UnityEngine.Vector3 LineIntersectionPointXZ(UnityEngine.Vector3 start1, UnityEngine.Vector3 end1, UnityEngine.Vector3 start2, UnityEngine.Vector3 end2) { }
        // RVA: 0x051449E4  token: 0x6000037
        public static UnityEngine.Vector3 LineIntersectionPointXZ(UnityEngine.Vector3 start1, UnityEngine.Vector3 end1, UnityEngine.Vector3 start2, UnityEngine.Vector3 end2, System.Boolean& intersects) { }
        // RVA: 0x05144B3C  token: 0x6000038
        public static UnityEngine.Vector2 LineIntersectionPoint(UnityEngine.Vector2 start1, UnityEngine.Vector2 end1, UnityEngine.Vector2 start2, UnityEngine.Vector2 end2) { }
        // RVA: 0x05144B60  token: 0x6000039
        public static UnityEngine.Vector2 LineIntersectionPoint(UnityEngine.Vector2 start1, UnityEngine.Vector2 end1, UnityEngine.Vector2 start2, UnityEngine.Vector2 end2, System.Boolean& intersects) { }
        // RVA: 0x05145378  token: 0x600003A
        public static UnityEngine.Vector3 SegmentIntersectionPointXZ(UnityEngine.Vector3 start1, UnityEngine.Vector3 end1, UnityEngine.Vector3 start2, UnityEngine.Vector3 end2, System.Boolean& intersects) { }
        // RVA: 0x05145528  token: 0x600003B
        public static System.Boolean SegmentIntersectsBounds(UnityEngine.Bounds bounds, UnityEngine.Vector3 a, UnityEngine.Vector3 b) { }
        // RVA: 0x05144290  token: 0x600003C
        public static System.Single LineCircleIntersectionFactor(UnityEngine.Vector3 circleCenter, UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 linePoint2, System.Single radius) { }
        // RVA: 0x051450C4  token: 0x600003D
        public static System.Boolean ReversesFaceOrientations(UnityEngine.Matrix4x4 matrix) { }
        // RVA: 0x05145004  token: 0x600003E
        public static System.Boolean ReversesFaceOrientationsXZ(UnityEngine.Matrix4x4 matrix) { }
        // RVA: 0x05144DEC  token: 0x600003F
        public static UnityEngine.Vector3 Normalize(UnityEngine.Vector3 v, System.Single& magnitude) { }
        // RVA: 0x05144E7C  token: 0x6000040
        public static UnityEngine.Vector2 Normalize(UnityEngine.Vector2 v, System.Single& magnitude) { }
        // RVA: 0x05143764  token: 0x6000041
        public static UnityEngine.Vector3 ClampMagnitudeXZ(UnityEngine.Vector3 v, System.Single maxMagnitude) { }
        // RVA: 0x03D4E8B0  token: 0x6000042
        public static System.Single MagnitudeXZ(UnityEngine.Vector3 v) { }

    }

    // TypeToken: 0x2000009  // size: 0x1C
    public sealed struct Int3 : System.IEquatable`1
    {
        // Fields
        public System.Int32 x;  // 0x10
        public System.Int32 y;  // 0x14
        public System.Int32 z;  // 0x18
        public static System.Int32 Precision;  // const
        public static System.Single FloatPrecision;  // const
        public static System.Single PrecisionFactor;  // const

        // Properties
        RVO.Int3 zero { get; /* RVA: 0x03D4E630 */ }
        System.Int32 Item { get; /* RVA: 0x05140A78 */ set; /* RVA: 0x05140E6C */ }
        System.Single magnitude { get; /* RVA: 0x05140AEC */ }
        System.Int32 costMagnitude { get; /* RVA: 0x05140A8C */ }
        System.Single sqrMagnitude { get; /* RVA: 0x03D4E600 */ }
        System.Int64 sqrMagnitudeLong { get; /* RVA: 0x03D4E5E0 */ }

        // Methods
        // RVA: 0x051409E0  token: 0x6000044
        public System.Void .ctor(UnityEngine.Vector3 position) { }
        // RVA: 0x03D4E5D0  token: 0x6000045
        public System.Void .ctor(System.Int32 _x, System.Int32 _y, System.Int32 _z) { }
        // RVA: 0x051408A4  token: 0x6000046
        public static System.Boolean op_Equality(RVO.Int3 lhs, RVO.Int3 rhs) { }
        // RVA: 0x05140CF8  token: 0x6000047
        public static System.Boolean op_Inequality(RVO.Int3 lhs, RVO.Int3 rhs) { }
        // RVA: 0x05140C30  token: 0x6000048
        public static RVO.Int3 op_Explicit(UnityEngine.Vector3 ob) { }
        // RVA: 0x03D4E670  token: 0x6000049
        public static UnityEngine.Vector3 op_Explicit(RVO.Int3 ob) { }
        // RVA: 0x03D4E6E0  token: 0x600004A
        public static RVO.Int3 op_Subtraction(RVO.Int3 lhs, RVO.Int3 rhs) { }
        // RVA: 0x03D4E710  token: 0x600004B
        public static RVO.Int3 op_UnaryNegation(RVO.Int3 lhs) { }
        // RVA: 0x03D4E640  token: 0x600004C
        public static RVO.Int3 op_Addition(RVO.Int3 lhs, RVO.Int3 rhs) { }
        // RVA: 0x03D4E6B0  token: 0x600004D
        public static RVO.Int3 op_Multiply(RVO.Int3 lhs, System.Int32 rhs) { }
        // RVA: 0x05140D14  token: 0x600004E
        public static RVO.Int3 op_Multiply(RVO.Int3 lhs, System.Single rhs) { }
        // RVA: 0x05140DC4  token: 0x600004F
        public static RVO.Int3 op_Multiply(RVO.Int3 lhs, System.Double rhs) { }
        // RVA: 0x05140B80  token: 0x6000050
        public static RVO.Int3 op_Division(RVO.Int3 lhs, System.Single rhs) { }
        // RVA: 0x0514073C  token: 0x6000053
        public static System.Single Angle(RVO.Int3 lhs, RVO.Int3 rhs) { }
        // RVA: 0x03D4E570  token: 0x6000054
        public static System.Int32 Dot(RVO.Int3 lhs, RVO.Int3 rhs) { }
        // RVA: 0x03D4E540  token: 0x6000055
        public static System.Int64 DotLong(RVO.Int3 lhs, RVO.Int3 rhs) { }
        // RVA: 0x03D4E5B0  token: 0x6000056
        public RVO.Int3 Normal2D() { }
        // RVA: 0x05140CE8  token: 0x600005B
        public static System.String op_Implicit(RVO.Int3 obj) { }
        // RVA: 0x051408C0  token: 0x600005C
        public virtual System.String ToString() { }
        // RVA: 0x0514082C  token: 0x600005D
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x051408A4  token: 0x600005E
        public virtual System.Boolean Equals(RVO.Int3 other) { }
        // RVA: 0x03D4E590  token: 0x600005F
        public virtual System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200000A  // size: 0x18
    public sealed struct Int2 : System.IEquatable`1
    {
        // Fields
        public System.Int32 x;  // 0x10
        public System.Int32 y;  // 0x14

        // Properties
        System.Int64 sqrMagnitudeLong { get; /* RVA: 0x03D4E4C0 */ }

        // Methods
        // RVA: 0x03D4E4B0  token: 0x6000060
        public System.Void .ctor(System.Int32 x, System.Int32 y) { }
        // RVA: 0x03D4E520  token: 0x6000062
        public static RVO.Int2 op_UnaryNegation(RVO.Int2 lhs) { }
        // RVA: 0x03D4E4E0  token: 0x6000063
        public static RVO.Int2 op_Addition(RVO.Int2 a, RVO.Int2 b) { }
        // RVA: 0x03D4E500  token: 0x6000064
        public static RVO.Int2 op_Subtraction(RVO.Int2 a, RVO.Int2 b) { }
        // RVA: 0x0514070C  token: 0x6000065
        public static System.Boolean op_Equality(RVO.Int2 a, RVO.Int2 b) { }
        // RVA: 0x05140724  token: 0x6000066
        public static System.Boolean op_Inequality(RVO.Int2 a, RVO.Int2 b) { }
        // RVA: 0x03D4E430  token: 0x6000067
        public static System.Int64 DotLong(RVO.Int2 a, RVO.Int2 b) { }
        // RVA: 0x051404E4  token: 0x6000068
        public virtual System.Boolean Equals(System.Object o) { }
        // RVA: 0x051404D0  token: 0x6000069
        public virtual System.Boolean Equals(RVO.Int2 other) { }
        // RVA: 0x03D4E480  token: 0x600006A
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x051405B0  token: 0x600006B
        public static RVO.Int2 Min(RVO.Int2 a, RVO.Int2 b) { }
        // RVA: 0x05140544  token: 0x600006C
        public static RVO.Int2 Max(RVO.Int2 a, RVO.Int2 b) { }
        // RVA: 0x03D4E460  token: 0x600006D
        public static RVO.Int2 FromInt3XZ(RVO.Int3 o) { }
        // RVA: 0x03D4E490  token: 0x600006E
        public static RVO.Int3 ToInt3XZ(RVO.Int2 o) { }
        // RVA: 0x0514061C  token: 0x600006F
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200000B  // size: 0x64
    public sealed struct RVOAgentJobData
    {
        // Fields
        public System.Int32 agentID;  // 0x10
        public System.Int32 agentIndex;  // 0x14
        public System.Boolean manuallyControlled;  // 0x18
        public System.Boolean locked;  // 0x19
        public System.Single radius;  // 0x1c
        public System.Single height;  // 0x20
        public System.Single desiredSpeed;  // 0x24
        public System.Single maxSpeed;  // 0x28
        public System.Single agentTimeHorizon;  // 0x2c
        public System.Single obstacleTimeHorizon;  // 0x30
        public System.Single priority;  // 0x34
        public System.Single elevationCoordinate;  // 0x38
        public RVO.RVOLayer layer;  // 0x3c
        public RVO.RVOLayer collidesWith;  // 0x40
        public UnityEngine.Vector2 position;  // 0x44
        public UnityEngine.Vector2 currentVelocity;  // 0x4c
        public UnityEngine.Vector2 desiredVelocity;  // 0x54
        public UnityEngine.Vector2 desiredTargetPointInVelocitySpace;  // 0x5c

    }

    // TypeToken: 0x200000C  // size: 0xC8
    public class RVOAgent
    {
        // Fields
        public System.Int32 agentID;  // 0x10
        public System.Int32 agentIndex;  // 0x14
        public System.Single radius;  // 0x18
        public System.Single height;  // 0x1c
        public System.Single desiredSpeed;  // 0x20
        public System.Single maxSpeed;  // 0x24
        public System.Single agentTimeHorizon;  // 0x28
        public System.Single obstacleTimeHorizon;  // 0x2c
        public System.Single priority;  // 0x30
        public System.Boolean locked;  // 0x34
        public RVO.RVOLayer layer;  // 0x38
        public RVO.RVOLayer collidesWith;  // 0x3c
        public System.Int32 maxNeighbours;  // 0x40
        public UnityEngine.Vector2 position;  // 0x44
        public UnityEngine.Vector3 position3;  // 0x4c
        public System.Single elevationCoordinate;  // 0x58
        public RVO.RVOAgent ignoreAgent;  // 0x60
        public UnityEngine.Vector2 currentVelocity;  // 0x68
        public UnityEngine.Vector2 desiredTargetPointInVelocitySpace;  // 0x70
        public UnityEngine.Vector2 desiredVelocity;  // 0x78
        public UnityEngine.Vector2 nextTargetPoint;  // 0x80
        public UnityEngine.Vector2 collisionNormal;  // 0x88
        public System.Boolean manuallyControlled;  // 0x90
        private System.Action <PreCalculationCallback>k__BackingField;  // 0x98
        public RVO.RVOAgent next;  // 0xa0
        public System.Single calculatedSpeed;  // 0xa8
        public UnityEngine.Vector2 calculatedTargetPoint;  // 0xac
        private System.Collections.Generic.List<RVO.RVOAgent> m_neighbours;  // 0xb8
        private System.Collections.Generic.List<System.Single> m_neighbourDists;  // 0xc0

        // Properties
        System.Action PreCalculationCallback { get; /* RVA: 0x011AC510 */ set; /* RVA: 0x051417AC */ }
        System.Collections.Generic.List<RVO.RVOAgent> neighbours { get; /* RVA: 0x03D4E750 */ }

        // Methods
        // RVA: 0x02AC89F0  token: 0x6000072
        public System.Void SetTarget(UnityEngine.Vector2 targetPoint, System.Single desiredSpeed, System.Single maxSpeed) { }
        // RVA: 0x03D4E740  token: 0x6000073
        public System.Void SetCollisionNormal(UnityEngine.Vector2 normal) { }
        // RVA: 0x0353B8E0  token: 0x6000074
        public System.Void ForceSetVelocity(UnityEngine.Vector2 velocity) { }
        // RVA: 0x02F33320  token: 0x6000076
        public System.Void .ctor() { }
        // RVA: 0x023EB470  token: 0x6000077
        public System.Void PreCalculation() { }
        // RVA: 0x023EB3B0  token: 0x6000078
        public RVO.RVOAgentJobData CreateJobData() { }
        // RVA: 0x02948DF0  token: 0x6000079
        public System.Void PostCalculation(System.Single resultSpeed, UnityEngine.Vector2 resultTargetPoint) { }
        // RVA: 0x023EB490  token: 0x600007A
        public System.Void CalculateNeighbours(RVO.RVOQuadtree quadtree, System.Single desiredDeltaTime) { }
        // RVA: 0x023E8C40  token: 0x600007B
        private System.Single InsertAgentNeighbour(RVO.RVOAgent rvoAgent, System.Single rangeSq) { }
        // RVA: 0x05141764  token: 0x600007C
        private static UnityEngine.Color Rainbow(System.Single v) { }

    }

    // TypeToken: 0x200000D  // size: 0x2C
    public sealed struct RVOObstacleJobData
    {
        // Fields
        public System.Int32 obstacleID;  // 0x10
        public System.Int32 obstacleIndex;  // 0x14
        public RVO.RVOLayer layer;  // 0x18
        public System.Single height;  // 0x1c
        public UnityEngine.Vector3 position;  // 0x20

        // Methods
        // RVA: 0x0514191C  token: 0x600007D
        public static System.Boolean op_Equality(RVO.RVOObstacleJobData a, RVO.RVOObstacleJobData b) { }
        // RVA: 0x05141A14  token: 0x600007E
        public static System.Boolean op_Inequality(RVO.RVOObstacleJobData a, RVO.RVOObstacleJobData b) { }
        // RVA: 0x051417C0  token: 0x600007F
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x05141864  token: 0x6000080
        public virtual System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200000E  // size: 0x110
    public class Simulator
    {
        // Fields
        private System.Single desiredDeltaTime;  // 0x10
        private Unity.Collections.NativeList<RVO.RVOAgentJobData> m_jobAgents;  // 0x18
        private Unity.Collections.NativeList<System.Boolean> m_jobNeighbours;  // 0x28
        private Unity.Collections.NativeList<RVO.RVOObstacleJobData> m_jobObstacles;  // 0x38
        private Unity.Collections.NativeArray<System.Single> m_jobCalculatedSpeeds;  // 0x48
        private Unity.Collections.NativeArray<UnityEngine.Vector2> m_jobCalculatedTargetPoints;  // 0x58
        private Unity.Collections.NativeArray<System.Int32> m_jobAgentBufferMaxIndex;  // 0x68
        private Unity.Collections.NativeArray<RVO.VO> m_jobAgentVoBuffer;  // 0x78
        private Unity.Collections.NativeArray<System.Int32> m_jobObsBufferMaxIndex;  // 0x88
        private Unity.Collections.NativeArray<RVO.VO> m_jobObsVoBuffer;  // 0x98
        private Unity.Collections.NativeList<RVO.RVOObstacleJobData> m_obstacles;  // 0xa8
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_obstacleIDToIndex;  // 0xb8
        private static System.Int32 s_nextObstacleID;  // static @ 0x0
        private System.Boolean m_obstaclesChanged;  // 0xc0
        private System.Collections.Generic.List<RVO.RVOAgent> m_agents;  // 0xc8
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_agentIDToIndex;  // 0xd0
        private static System.Int32 s_nextAgentID;  // static @ 0x4
        private RVO.RVOQuadtree <Quadtree>k__BackingField;  // 0xd8
        private System.Single deltaTime;  // 0xe0
        private System.Single lastStep;  // 0xe4
        private readonly System.Single m_symmetryBreakingBias;  // 0xe8
        private readonly System.Int32 m_simulationFPS;  // 0xec
        private readonly System.Int32 m_vertexCount;  // 0xf0
        private static System.Single SHRINK_FACTOR;  // const
        private static System.Int32 INIT_AGENT_COUNT;  // const
        private static System.Int32 INIT_OBSTACLE_COUNT;  // const
        private static System.Int32 INIT_AGENT_VO_COUNT;  // const
        private static System.Int32 INIT_OBS_VO_COUNT;  // const
        private System.Int32 m_agentCount;  // 0xf4
        private System.Int32 m_agentVOCount;  // 0xf8
        private System.Int32 m_obsVOCount;  // 0xfc
        private Unity.Jobs.JobHandle m_handle;  // 0x100

        // Properties
        System.Single DesiredDeltaTime { get; /* RVA: 0x03D4E7A0 */ set; /* RVA: 0x0319C760 */ }
        System.Collections.Generic.List<RVO.RVOAgent> agents { get; /* RVA: 0x03D4E7C0 */ }
        RVO.RVOQuadtree Quadtree { get; /* RVA: 0x03D4E7B0 */ set; /* RVA: 0x05142FC4 */ }

        // Methods
        // RVA: 0x0319BE20  token: 0x6000086
        public System.Void .ctor() { }
        // RVA: 0x05142348  token: 0x6000087
        public System.Void OnDestroy() { }
        // RVA: 0x02F33220  token: 0x6000088
        public RVO.RVOAgent AddAgent() { }
        // RVA: 0x02AFBD10  token: 0x6000089
        public System.Void RemoveAgent(RVO.RVOAgent agent) { }
        // RVA: 0x0294A1C0  token: 0x600008A
        public System.Int32 AddObstacle(UnityEngine.Vector3[] vertices, System.Single height, RVO.RVOLayer layer) { }
        // RVA: 0x05142EB0  token: 0x600008B
        public System.Void UpdateObstacle(System.Int32 obstacleID, UnityEngine.Vector3[] vertices) { }
        // RVA: 0x0514251C  token: 0x600008C
        public System.Void RemoveObstacle(System.Int32 obstacleID) { }
        // RVA: 0x023E96E0  token: 0x600008D
        private System.Void BuildQuadtree() { }
        // RVA: 0x023E99C0  token: 0x600008E
        public System.Void Update() { }
        // RVA: 0x0319C230  token: 0x600008F
        private System.Void _Realloc(System.Int32 agentCount, System.Int32 obstacleCount) { }
        // RVA: 0x02948BD0  token: 0x6000090
        private System.Void _WriteBackResult() { }
        // RVA: 0x03D4E780  token: 0x6000091
        private static UnityEngine.Vector2 _To2D(UnityEngine.Vector3 p, System.Single& elevation) { }
        // RVA: 0x05142700  token: 0x6000092
        public static RVO.VO SegmentObstacle(UnityEngine.Vector2 segmentStart, UnityEngine.Vector2 segmentEnd, UnityEngine.Vector2 offset, System.Single radius, System.Single inverseDt, System.Single inverseDeltaTime) { }
        // RVA: 0x05141D28  token: 0x6000093
        private static System.Boolean BiasDesiredVelocity(System.Int32 obsStart, System.Int32 obsEnd, Unity.Collections.NativeArray<RVO.VO>& obsVos, System.Int32 agentStart, System.Int32 agentEnd, Unity.Collections.NativeArray<RVO.VO>& agentVos, UnityEngine.Vector2& desiredVelocity, UnityEngine.Vector2& targetPointInVelocitySpace, System.Single maxBiasRadians) { }
        // RVA: 0x05142208  token: 0x6000094
        private static UnityEngine.Vector2 GradientDescent(System.Int32 obsStart, System.Int32 obsEnd, Unity.Collections.NativeArray<RVO.VO>& obsVos, System.Int32 agentStart, System.Int32 agentEnd, Unity.Collections.NativeArray<RVO.VO>& agentVos, RVO.RVOAgentJobData agent, UnityEngine.Vector2 sampleAround1, UnityEngine.Vector2 sampleAround2) { }
        // RVA: 0x05142CB8  token: 0x6000095
        private static UnityEngine.Vector2 Trace(System.Int32 obsStart, System.Int32 obsEnd, Unity.Collections.NativeArray<RVO.VO>& obsVos, System.Int32 agentStart, System.Int32 agentEnd, Unity.Collections.NativeArray<RVO.VO>& agentVos, RVO.RVOAgentJobData agent, UnityEngine.Vector2 p, System.Single& score) { }
        // RVA: 0x05141F28  token: 0x6000096
        private static UnityEngine.Vector2 EvaluateGradient(System.Int32 obsStart, System.Int32 obsEnd, Unity.Collections.NativeArray<RVO.VO>& obsVos, System.Int32 agentStart, System.Int32 agentEnd, Unity.Collections.NativeArray<RVO.VO>& agentVos, RVO.RVOAgentJobData agent, UnityEngine.Vector2 p, System.Single& value) { }

    }

    // TypeToken: 0x2000012  // size: 0x20
    public sealed struct Line
    {
        // Fields
        public UnityEngine.Vector2 point;  // 0x10
        public UnityEngine.Vector2 dir;  // 0x18

    }

    // TypeToken: 0x2000013  // size: 0x38
    public class RVOQuadtree
    {
        // Fields
        private static System.Int32 LeafSize;  // const
        private System.Single maxRadius;  // 0x10
        private RVO.RVOQuadtree.Node[] m_nodes;  // 0x18
        private System.Int32 filledNodes;  // 0x20
        private UnityEngine.Rect m_bounds;  // 0x24

        // Properties
        RVO.RVOQuadtree.Node[] nodes { get; /* RVA: 0x01041090 */ }
        UnityEngine.Rect bounds { get; /* RVA: 0x03D4E770 */ }

        // Methods
        // RVA: 0x033C0E90  token: 0x600009C
        public System.Void Clear() { }
        // RVA: 0x03D4E760  token: 0x600009D
        public System.Void SetBounds(UnityEngine.Rect r) { }
        // RVA: 0x03114440  token: 0x600009E
        private System.Int32 GetNodeIndex() { }
        // RVA: 0x023E82F0  token: 0x600009F
        public System.Void Insert(RVO.RVOAgent rvoAgent) { }
        // RVA: 0x02EC0440  token: 0x60000A0
        public System.Void CalculateSpeeds() { }
        // RVA: 0x02E67BC0  token: 0x60000A1
        public System.Void Query(UnityEngine.Vector2 p, System.Single speed, System.Single timeHorizon, System.Single agentRadius, RVO.RVOAgent rvoAgent) { }
        // RVA: 0x0319C710  token: 0x60000A2
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000016  // size: 0x6C
    public sealed struct VO
    {
        // Fields
        public UnityEngine.Vector2 line1;  // 0x10
        public UnityEngine.Vector2 line2;  // 0x18
        public UnityEngine.Vector2 dir1;  // 0x20
        public UnityEngine.Vector2 dir2;  // 0x28
        public UnityEngine.Vector2 cutoffLine;  // 0x30
        public UnityEngine.Vector2 cutoffDir;  // 0x38
        public UnityEngine.Vector2 circleCenter;  // 0x40
        public System.Boolean colliding;  // 0x48
        public System.Single radius;  // 0x4c
        public System.Single weightFactor;  // 0x50
        public System.Single weightBonus;  // 0x54
        public UnityEngine.Vector2 segmentStart;  // 0x58
        public UnityEngine.Vector2 segmentEnd;  // 0x60
        public System.Boolean segment;  // 0x68

        // Methods
        // RVA: 0x05143394  token: 0x60000A7
        public System.Void .ctor(UnityEngine.Vector2 center, UnityEngine.Vector2 offset, System.Single radius, System.Single inverseDt, System.Single inverseDeltaTime) { }
        // RVA: 0x03D4E7D0  token: 0x60000A8
        public static System.Single SignedDistanceFromLine(UnityEngine.Vector2 a, UnityEngine.Vector2 dir, UnityEngine.Vector2 p) { }
        // RVA: 0x0514331C  token: 0x60000A9
        public UnityEngine.Vector2 ScaledGradient(UnityEngine.Vector2 p, System.Single& weight) { }
        // RVA: 0x05142FD8  token: 0x60000AA
        public UnityEngine.Vector2 Gradient(UnityEngine.Vector2 p, System.Single& weight) { }

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

