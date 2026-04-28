// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Splines.dll
// Classes:  37
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000008  // size: 0x40
    public sealed struct FrenetFrame
    {
        // Fields
        public Unity.Mathematics.float3 origin;  // 0x10
        public Unity.Mathematics.float3 tangent;  // 0x1c
        public Unity.Mathematics.float3 normal;  // 0x28
        public Unity.Mathematics.float3 binormal;  // 0x34

    }

    // TypeToken: 0x2000011  // size: 0x18
    public sealed class KnotLink : System.Collections.Generic.IReadOnlyList`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection`1
    {
        // Fields
        public UnityEngine.Splines.SplineKnotIndex[] Knots;  // 0x10

        // Properties
        System.Int32 Count { get; /* RVA: 0x042746EC */ }
        UnityEngine.Splines.SplineKnotIndex Item { get; /* RVA: 0x09CD32E4 */ }

        // Methods
        // RVA: 0x09CD329C  token: 0x6000036
        public virtual System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineKnotIndex> GetEnumerator() { }
        // RVA: 0x099DF280  token: 0x6000037
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: 0x0350B670  token: 0x600003A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000013
    public sealed struct Slice`1 : System.Collections.Generic.IReadOnlyList`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection`1
    {
        // Fields
        private Unity.Collections.NativeSlice<T> m_Slice;  // 0x0

        // Properties
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }
        T Item { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x6000047
        public System.Void .ctor(Unity.Collections.NativeArray<T> array, System.Int32 start, System.Int32 count) { }
        // RVA: -1  // not resolved  token: 0x6000048
        public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x6000049
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000015  // size: 0x20
    public sealed class MetaData
    {
        // Fields
        public UnityEngine.Splines.TangentMode Mode;  // 0x10
        public System.Single Tension;  // 0x14
        private UnityEngine.Splines.DistanceToInterpolation[] m_DistanceToInterpolation;  // 0x18

        // Properties
        UnityEngine.Splines.DistanceToInterpolation[] DistanceToInterpolation { get; /* RVA: 0x02E01E20 */ }

        // Methods
        // RVA: 0x02E01F30  token: 0x6000074
        public System.Void .ctor() { }
        // RVA: 0x02E019D0  token: 0x6000075
        public System.Void InvalidateCache() { }

    }

    // TypeToken: 0x2000016  // size: 0x50
    public sealed class <get_embeddedSplineData>d__15 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private UnityEngine.Splines.ISplineModificationHandler <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x20
        public UnityEngine.Splines.Spline <>4__this;  // 0x28
        private System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineDataKeyValuePair<System.Int32>> <>7__wrap1;  // 0x30
        private System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineDataKeyValuePair<System.Single>> <>7__wrap2;  // 0x38
        private System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineDataKeyValuePair<Unity.Mathematics.float4>> <>7__wrap3;  // 0x40
        private System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineDataKeyValuePair<UnityEngine.Object>> <>7__wrap4;  // 0x48

        // Properties
        UnityEngine.Splines.ISplineModificationHandler System.Collections.Generic.IEnumerator<UnityEngine.Splines.ISplineModificationHandler>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x025D6DC0  token: 0x6000076
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x09CD7F8C  token: 0x6000077
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x09CD7660  token: 0x6000078
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x09CD815C  token: 0x6000079
        private System.Void <>m__Finally1() { }
        // RVA: 0x09CD81A4  token: 0x600007A
        private System.Void <>m__Finally2() { }
        // RVA: 0x09CD81EC  token: 0x600007B
        private System.Void <>m__Finally3() { }
        // RVA: 0x09CD8234  token: 0x600007C
        private System.Void <>m__Finally4() { }
        // RVA: 0x09CD7F40  token: 0x600007E
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x09CD7EAC  token: 0x6000080
        private virtual System.Collections.Generic.IEnumerator<UnityEngine.Splines.ISplineModificationHandler> System.Collections.Generic.IEnumerable<UnityEngine.Splines.ISplineModificationHandler>.GetEnumerator() { }
        // RVA: 0x09CD7F38  token: 0x6000081
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000018  // size: 0x28
    public sealed class <>c__DisplayClass18_0
    {
        // Fields
        public System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> value;  // 0x10
        public System.Int32 i;  // 0x18
        public System.Predicate<UnityEngine.Splines.Spline> <>9__0;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x60000A9
        public System.Void .ctor() { }
        // RVA: 0x09CD7608  token: 0x60000AA
        private System.Boolean <set_Splines>b__0(UnityEngine.Splines.Spline spline) { }

    }

    // TypeToken: 0x200001C
    public sealed class <GetEnumerator>d__46 : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x0
        private UnityEngine.Splines.DataPoint<T> <>2__current;  // 0x0
        public UnityEngine.Splines.SplineData<T> <>4__this;  // 0x0
        private System.Int32 <i>5__2;  // 0x0
        private System.Int32 <c>5__3;  // 0x0

        // Properties
        UnityEngine.Splines.DataPoint<T> System.Collections.Generic.IEnumerator<UnityEngine.Splines.DataPoint<T>>.Current { get; /* RVA: -1  // not resolved */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60000B2
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: -1  // not resolved  token: 0x60000B3
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: -1  // not resolved  token: 0x60000B4
        private virtual System.Boolean MoveNext() { }
        // RVA: -1  // not resolved  token: 0x60000B6
        private virtual System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000025  // size: 0x18
    public sealed struct Segment
    {
        // Fields
        public System.Single start;  // 0x10
        public System.Single length;  // 0x14

        // Methods
        // RVA: 0x03D50430  token: 0x60000DD
        public System.Void .ctor(System.Single start, System.Single length) { }

    }

namespace UnityEngine.Splines
{

    // TypeToken: 0x2000002  // size: 0x10
    public static class ArrayUtility
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000001
        public static System.Void RemoveAt(T[]& array, System.Int32 index) { }
        // RVA: -1  // generic def  token: 0x6000002
        public static System.Void Remove(T[]& array, T element) { }

    }

    // TypeToken: 0x2000003  // size: 0x40
    public sealed struct BezierCurve : System.IEquatable`1
    {
        // Fields
        public Unity.Mathematics.float3 P0;  // 0x10
        public Unity.Mathematics.float3 P1;  // 0x1c
        public Unity.Mathematics.float3 P2;  // 0x28
        public Unity.Mathematics.float3 P3;  // 0x34

        // Methods
        // RVA: 0x03D81850  token: 0x6000003
        public System.Void .ctor(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2, Unity.Mathematics.float3 p3) { }
        // RVA: 0x02E02140  token: 0x6000004
        public System.Void .ctor(UnityEngine.Splines.BezierKnot a, UnityEngine.Splines.BezierKnot b) { }
        // RVA: 0x09C6E67C  token: 0x6000005
        public virtual System.Boolean Equals(UnityEngine.Splines.BezierCurve other) { }
        // RVA: 0x09CD11DC  token: 0x6000006
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09CD125C  token: 0x6000007
        public virtual System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000004  // size: 0x48
    public sealed struct BezierKnot : UnityEngine.ISerializationCallbackReceiver, System.IEquatable`1
    {
        // Fields
        public Unity.Mathematics.float3 Position;  // 0x10
        public Unity.Mathematics.float3 TangentIn;  // 0x1c
        public Unity.Mathematics.float3 TangentOut;  // 0x28
        public Unity.Mathematics.quaternion Rotation;  // 0x34
        public System.Single Width;  // 0x44

        // Methods
        // RVA: 0x09CD1CCC  token: 0x6000008
        public System.Void .ctor(Unity.Mathematics.float3 position) { }
        // RVA: 0x03D84A60  token: 0x6000009
        public System.Void .ctor(Unity.Mathematics.float3 position, Unity.Mathematics.float3 tangentIn, Unity.Mathematics.float3 tangentOut, Unity.Mathematics.quaternion rotation, System.Single width) { }
        // RVA: 0x09CD1A40  token: 0x600000A
        public UnityEngine.Splines.BezierKnot Transform(Unity.Mathematics.float4x4 matrix) { }
        // RVA: 0x09CD12EC  token: 0x600000B
        private UnityEngine.Splines.BezierKnot BakeTangentDirectionToRotation(System.Boolean mirrored, UnityEngine.Splines.BezierTangent main) { }
        // RVA: 0x0350B670  token: 0x600000C
        public virtual System.Void OnBeforeSerialize() { }
        // RVA: 0x09CD1848  token: 0x600000D
        public virtual System.Void OnAfterDeserialize() { }
        // RVA: 0x09CD18B4  token: 0x600000E
        public virtual System.String ToString() { }
        // RVA: 0x09CD15F0  token: 0x600000F
        public virtual System.Boolean Equals(UnityEngine.Splines.BezierKnot other) { }
        // RVA: 0x09CD16C4  token: 0x6000010
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x09CD1750  token: 0x6000011
        public virtual System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000005  // size: 0x14
    public sealed struct TangentMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Splines.TangentMode AutoSmooth;  // const
        public static UnityEngine.Splines.TangentMode Linear;  // const
        public static UnityEngine.Splines.TangentMode Mirrored;  // const
        public static UnityEngine.Splines.TangentMode Continuous;  // const
        public static UnityEngine.Splines.TangentMode Broken;  // const

    }

    // TypeToken: 0x2000006  // size: 0x14
    public sealed struct BezierTangent
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Splines.BezierTangent In;  // const
        public static UnityEngine.Splines.BezierTangent Out;  // const

    }

    // TypeToken: 0x2000007  // size: 0x10
    public static class CurveUtility
    {
        // Fields
        private static readonly UnityEngine.Splines.DistanceToInterpolation[] k_DistanceLUT;  // static @ 0x0

        // Methods
        // RVA: 0x02A5DCA0  token: 0x6000012
        public static Unity.Mathematics.float3 EvaluatePosition(UnityEngine.Splines.BezierCurve curve, System.Single t) { }
        // RVA: 0x02E02630  token: 0x6000013
        public static Unity.Mathematics.float3 EvaluateTangent(UnityEngine.Splines.BezierCurve curve, System.Single t) { }
        // RVA: 0x09CD1DB4  token: 0x6000014
        public static Unity.Mathematics.float3 EvaluateAcceleration(UnityEngine.Splines.BezierCurve curve, System.Single t) { }
        // RVA: 0x02A5DA10  token: 0x6000015
        public static System.Void CalculateCurveLengths(UnityEngine.Splines.BezierCurve curve, UnityEngine.Splines.DistanceToInterpolation[] lookupTable) { }
        // RVA: 0x09CD1D54  token: 0x6000016
        private static System.Boolean Approximately(System.Single a, System.Single b) { }
        // RVA: 0x09CD1F38  token: 0x6000017
        private static Unity.Mathematics.float3 EvaluateUpVector(UnityEngine.Splines.BezierCurve curve, System.Single t, Unity.Mathematics.float3 startUp, Unity.Mathematics.float3 endUp) { }
        // RVA: 0x09CD2A28  token: 0x6000018
        private static UnityEngine.Splines.CurveUtility.FrenetFrame GetNextRotationMinimizingFrame(UnityEngine.Splines.BezierCurve curve, UnityEngine.Splines.CurveUtility.FrenetFrame previousRMFrame, System.Single nextRMFrameT) { }
        // RVA: -1  // generic def  token: 0x6000019
        public static System.Single GetDistanceToInterpolation(T lut, System.Single distance) { }
        // RVA: 0x03D06910  token: 0x600001A
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000009
    public interface IDataPoint
    {
        // Properties
        System.Single Index { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x200000A
    public sealed struct DataPoint`1 : System.IComparable`1, System.IComparable`1, UnityEngine.Splines.IDataPoint
    {
        // Fields
        private System.Single m_Index;  // 0x0
        private TDataType m_Value;  // 0x0

        // Properties
        System.Single Index { get; /* RVA: -1  // not resolved */ set; /* RVA: -1  // not resolved */ }
        TDataType Value { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x600001F
        public virtual System.Int32 CompareTo(UnityEngine.Splines.DataPoint<TDataType> other) { }
        // RVA: -1  // not resolved  token: 0x6000020
        public virtual System.Int32 CompareTo(System.Single other) { }
        // RVA: -1  // not resolved  token: 0x6000021
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x200000B
    public class DataPointComparer`1 : System.Collections.Generic.IComparer`1
    {
        // Methods
        // RVA: -1  // not resolved  token: 0x6000022
        public virtual System.Int32 Compare(T x, T y) { }
        // RVA: -1  // not resolved  token: 0x6000023
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000C  // size: 0x18
    public sealed struct DistanceToInterpolation
    {
        // Fields
        public System.Single Distance;  // 0x10
        public System.Single T;  // 0x14
        private static readonly UnityEngine.Splines.DistanceToInterpolation Invalid;  // static @ 0x0

        // Methods
        // RVA: 0x03D41520  token: 0x6000024
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200000D
    public interface IHasEmptyCurves
    {
        // Properties
        System.Collections.Generic.IReadOnlyList<System.Int32> EmptyCurves { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x200000E
    public interface ISpline : System.Collections.Generic.IReadOnlyList`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection`1
    {
        // Properties
        System.Boolean Closed { get; /* RVA: -1  // abstract */ }

        // Methods
        // RVA: -1  // abstract  token: 0x6000027
        public virtual System.Single GetLength() { }
        // RVA: -1  // abstract  token: 0x6000028
        public virtual UnityEngine.Splines.BezierCurve GetCurve(System.Int32 index) { }
        // RVA: -1  // abstract  token: 0x6000029
        public virtual System.Single GetCurveLength(System.Int32 index) { }
        // RVA: -1  // abstract  token: 0x600002A
        public virtual System.Single GetCurveInterpolation(System.Int32 curveIndex, System.Single curveDistance) { }

    }

    // TypeToken: 0x200000F
    public interface ISplineContainer
    {
        // Properties
        System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> Splines { get; /* RVA: -1  // abstract */ }
        UnityEngine.Splines.KnotLinkCollection KnotLinkCollection { get; /* RVA: -1  // abstract */ }

    }

    // TypeToken: 0x2000010  // size: 0x18
    public sealed class KnotLinkCollection
    {
        // Fields
        private UnityEngine.Splines.KnotLinkCollection.KnotLink[] m_KnotsLink;  // 0x10

        // Methods
        // RVA: 0x09CD2F80  token: 0x600002D
        private UnityEngine.Splines.KnotLinkCollection.KnotLink GetKnotLinksInternal(UnityEngine.Splines.SplineKnotIndex index) { }
        // RVA: 0x09CD316C  token: 0x600002E
        public System.Boolean TryGetKnotLinks(UnityEngine.Splines.SplineKnotIndex knotIndex, System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.SplineKnotIndex>& linkedKnots) { }
        // RVA: 0x09CD3198  token: 0x600002F
        public System.Void Unlink(UnityEngine.Splines.SplineKnotIndex knot) { }
        // RVA: 0x09CD304C  token: 0x6000030
        public System.Void KnotRemoved(System.Int32 splineIndex, System.Int32 knotIndex) { }
        // RVA: 0x09CD306C  token: 0x6000031
        public System.Void KnotRemoved(UnityEngine.Splines.SplineKnotIndex index) { }
        // RVA: 0x09CD3018  token: 0x6000032
        public System.Void KnotInserted(System.Int32 splineIndex, System.Int32 knotIndex) { }
        // RVA: 0x09CD303C  token: 0x6000033
        public System.Void KnotInserted(UnityEngine.Splines.SplineKnotIndex index) { }
        // RVA: 0x09CD30A4  token: 0x6000034
        public System.Void ShiftKnotIndices(UnityEngine.Splines.SplineKnotIndex index, System.Int32 offset) { }
        // RVA: 0x09CD3254  token: 0x6000035
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000012  // size: 0x48
    public sealed struct NativeSpline : UnityEngine.Splines.ISpline, System.Collections.Generic.IReadOnlyList`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection`1, System.IDisposable
    {
        // Fields
        private Unity.Collections.NativeArray<UnityEngine.Splines.BezierKnot> m_Knots;  // 0x10
        private Unity.Collections.NativeArray<UnityEngine.Splines.BezierCurve> m_Curves;  // 0x20
        private Unity.Collections.NativeArray<UnityEngine.Splines.DistanceToInterpolation> m_SegmentLengthsLookupTable;  // 0x30
        private System.Boolean m_Closed;  // 0x40
        private System.Single m_Length;  // 0x44

        // Properties
        System.Boolean Closed { get; /* RVA: 0x03D4EF60 */ }
        System.Int32 Count { get; /* RVA: 0x03D516F0 */ }
        UnityEngine.Splines.BezierKnot Item { get; /* RVA: 0x03D6A320 */ }

        // Methods
        // RVA: 0x03D56CA0  token: 0x600003D
        public virtual System.Single GetLength() { }
        // RVA: 0x09CD3478  token: 0x600003F
        public virtual System.Collections.Generic.IEnumerator<UnityEngine.Splines.BezierKnot> GetEnumerator() { }
        // RVA: 0x09CD3514  token: 0x6000040
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: 0x09CD3B48  token: 0x6000041
        public System.Void .ctor(UnityEngine.Splines.ISpline spline, Unity.Mathematics.float4x4 transform, Unity.Collections.Allocator allocator) { }
        // RVA: 0x09CD351C  token: 0x6000042
        public System.Void .ctor(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.BezierKnot> knots, System.Collections.Generic.IReadOnlyList<System.Int32> splits, System.Boolean closed, Unity.Mathematics.float4x4 transform, Unity.Collections.Allocator allocator) { }
        // RVA: 0x03D84AD0  token: 0x6000043
        public virtual UnityEngine.Splines.BezierCurve GetCurve(System.Int32 index) { }
        // RVA: 0x03D84AB0  token: 0x6000044
        public virtual System.Single GetCurveLength(System.Int32 curveIndex) { }
        // RVA: 0x09CD3310  token: 0x6000045
        public virtual System.Void Dispose() { }
        // RVA: 0x09CD3384  token: 0x6000046
        public virtual System.Single GetCurveInterpolation(System.Int32 curveIndex, System.Single curveDistance) { }

    }

    // TypeToken: 0x2000014  // size: 0x68
    public class Spline : UnityEngine.Splines.ISpline, System.Collections.Generic.IReadOnlyList`1, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection`1, System.Collections.Generic.IList`1, System.Collections.Generic.ICollection`1
    {
        // Fields
        private static UnityEngine.Splines.TangentMode k_DefaultTangentMode;  // const
        private static UnityEngine.Splines.BezierTangent k_DefaultMainTangent;  // const
        private static System.Int32 k_BatchModification;  // const
        private static System.Int32 k_CurveDistanceLutResolution;  // const
        private UnityEngine.Splines.SplineType m_EditModeType;  // 0x10
        private System.Collections.Generic.List<UnityEngine.Splines.BezierKnot> m_Knots;  // 0x18
        private System.Single m_Length;  // 0x20
        private System.Collections.Generic.List<UnityEngine.Splines.Spline.MetaData> m_MetaData;  // 0x28
        private System.Boolean m_Closed;  // 0x30
        private UnityEngine.Splines.SplineDataDictionary<System.Int32> m_IntData;  // 0x38
        private UnityEngine.Splines.SplineDataDictionary<System.Single> m_FloatData;  // 0x40
        private UnityEngine.Splines.SplineDataDictionary<Unity.Mathematics.float4> m_Float4Data;  // 0x48
        private UnityEngine.Splines.SplineDataDictionary<UnityEngine.Object> m_ObjectData;  // 0x50
        private System.Action changed;  // 0x58
        private static System.Action<UnityEngine.Splines.Spline,System.Int32,UnityEngine.Splines.SplineModification> Changed;  // static @ 0x0
        private System.ValueTuple<System.Single,System.Single> m_LastKnotChangeCurveLengths;  // 0x60

        // Properties
        System.Collections.Generic.IEnumerable<UnityEngine.Splines.ISplineModificationHandler> embeddedSplineData { get; /* RVA: 0x09CD7494 */ }
        System.Int32 Count { get; /* RVA: 0x02E025F0 */ }
        System.Boolean IsReadOnly { get; /* RVA: 0x0115F4C0 */ }
        System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot> Knots { get; /* RVA: 0x01041090 */ }
        System.Boolean Closed { get; /* RVA: 0x03D4EF60 */ set; /* RVA: 0x09CD75A0 */ }
        UnityEngine.Splines.BezierKnot Item { get; /* RVA: 0x09CD7404 */ set; /* RVA: 0x09CD75BC */ }

        // Events
        event System.Action<UnityEngine.Splines.Spline,System.Int32,UnityEngine.Splines.SplineModification> Changed;

        // Methods
        // RVA: 0x09CD6B24  token: 0x6000051
        private System.Void SetDirtyNoNotify() { }
        // RVA: 0x09CD6BC4  token: 0x6000052
        private System.Void SetDirty(UnityEngine.Splines.SplineModification modificationEvent, System.Int32 knotIndex) { }
        // RVA: 0x0350B670  token: 0x6000053
        protected virtual System.Void OnSplineChanged() { }
        // RVA: 0x02E01E70  token: 0x6000054
        private System.Void EnsureMetaDataValid() { }
        // RVA: 0x09CD6640  token: 0x6000055
        public UnityEngine.Splines.TangentMode GetTangentMode(System.Int32 index) { }
        // RVA: 0x09CD60C0  token: 0x6000056
        private System.Void ApplyTangentModeNoNotify(System.Int32 index, UnityEngine.Splines.BezierTangent main) { }
        // RVA: 0x09CD66A8  token: 0x600005A
        public virtual System.Int32 IndexOf(UnityEngine.Splines.BezierKnot item) { }
        // RVA: 0x09CD691C  token: 0x600005B
        public virtual System.Void Insert(System.Int32 index, UnityEngine.Splines.BezierKnot knot) { }
        // RVA: 0x09CD68CC  token: 0x600005C
        public System.Void Insert(System.Int32 index, UnityEngine.Splines.BezierKnot knot, UnityEngine.Splines.TangentMode mode) { }
        // RVA: 0x09CD6724  token: 0x600005D
        public System.Void Insert(System.Int32 index, UnityEngine.Splines.BezierKnot knot, UnityEngine.Splines.TangentMode mode, System.Single tension) { }
        // RVA: 0x09CD6974  token: 0x600005E
        public virtual System.Void RemoveAt(System.Int32 index) { }
        // RVA: 0x09CD7038  token: 0x6000061
        public System.Void SetKnot(System.Int32 index, UnityEngine.Splines.BezierKnot value, UnityEngine.Splines.BezierTangent main) { }
        // RVA: 0x09CD6EDC  token: 0x6000062
        public System.Void SetKnotNoNotify(System.Int32 index, UnityEngine.Splines.BezierKnot value, UnityEngine.Splines.BezierTangent main) { }
        // RVA: 0x09CD716C  token: 0x6000063
        public System.Void .ctor() { }
        // RVA: 0x02E02B50  token: 0x6000064
        public System.Void .ctor(System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot> knots, System.Boolean closed) { }
        // RVA: 0x02E01FA0  token: 0x6000065
        public virtual UnityEngine.Splines.BezierCurve GetCurve(System.Int32 index) { }
        // RVA: 0x02E01C50  token: 0x6000066
        public virtual System.Single GetCurveLength(System.Int32 index) { }
        // RVA: 0x02E01930  token: 0x6000067
        public virtual System.Single GetLength() { }
        // RVA: 0x02E01760  token: 0x6000068
        private UnityEngine.Splines.DistanceToInterpolation[] GetCurveDistanceLut(System.Int32 index) { }
        // RVA: 0x02E01310  token: 0x6000069
        public virtual System.Single GetCurveInterpolation(System.Int32 curveIndex, System.Single curveDistance) { }
        // RVA: 0x09CD6598  token: 0x600006A
        public virtual System.Collections.Generic.IEnumerator<UnityEngine.Splines.BezierKnot> GetEnumerator() { }
        // RVA: 0x09CD70C4  token: 0x600006B
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: 0x09CD600C  token: 0x600006C
        public virtual System.Void Add(UnityEngine.Splines.BezierKnot item) { }
        // RVA: 0x09CD6050  token: 0x600006D
        public System.Void Add(UnityEngine.Splines.BezierKnot item, UnityEngine.Splines.TangentMode mode) { }
        // RVA: 0x09CD6444  token: 0x600006E
        public virtual System.Void Clear() { }
        // RVA: 0x09CD64B8  token: 0x600006F
        public virtual System.Boolean Contains(UnityEngine.Splines.BezierKnot item) { }
        // RVA: 0x09CD6534  token: 0x6000070
        public virtual System.Void CopyTo(UnityEngine.Splines.BezierKnot[] array, System.Int32 arrayIndex) { }
        // RVA: 0x09CD6A90  token: 0x6000071
        public virtual System.Boolean Remove(UnityEngine.Splines.BezierKnot item) { }
        // RVA: 0x09CD63BC  token: 0x6000072
        private System.Void CacheKnotOperationCurves(System.Int32 index) { }

    }

    // TypeToken: 0x2000017  // size: 0x48
    public class SplineContainer : UnityEngine.MonoBehaviour, UnityEngine.Splines.ISplineContainer, UnityEngine.ISerializationCallbackReceiver
    {
        // Fields
        private static System.String k_IconPath;  // const
        private UnityEngine.Splines.Spline m_Spline;  // 0x18
        private UnityEngine.Splines.Spline[] m_Splines;  // 0x20
        private UnityEngine.Splines.KnotLinkCollection m_Knots;  // 0x28
        private System.Collections.Generic.List<System.ValueTuple<System.Int32,System.Int32>> m_ReorderedSplinesIndices;  // 0x30
        private System.Collections.Generic.List<System.Int32> m_RemovedSplinesIndices;  // 0x38
        private System.Collections.Generic.List<System.Int32> m_AddedSplinesIndices;  // 0x40
        private static System.Action<UnityEngine.Splines.SplineContainer,System.Int32> SplineAdded;  // static @ 0x0
        private static System.Action<UnityEngine.Splines.SplineContainer,System.Int32> SplineRemoved;  // static @ 0x8
        private static System.Action<UnityEngine.Splines.SplineContainer,System.Int32,System.Int32> SplineReordered;  // static @ 0x10

        // Properties
        System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> Splines { get; /* RVA: 0x09CD4A94 */ set; /* RVA: 0x09CD4D34 */ }
        UnityEngine.Splines.KnotLinkCollection KnotLinkCollection { get; /* RVA: 0x03D4EAC0 */ }
        UnityEngine.Splines.Spline Item { get; /* RVA: 0x09CD4A34 */ }
        System.Boolean IsScaled { get; /* RVA: 0x09CD49A4 */ }
        UnityEngine.Splines.Spline Spline { get; /* RVA: 0x09CD4A60 */ set; /* RVA: 0x09CD4CEC */ }

        // Events
        event System.Action<UnityEngine.Splines.SplineContainer,System.Int32> SplineAdded;
        event System.Action<UnityEngine.Splines.SplineContainer,System.Int32> SplineRemoved;
        event System.Action<UnityEngine.Splines.SplineContainer,System.Int32,System.Int32> SplineReordered;

        // Methods
        // RVA: 0x09CD421C  token: 0x600008A
        private static System.Int32 IndexOf(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline> self, UnityEngine.Splines.Spline elementToFind) { }
        // RVA: 0x09CD442C  token: 0x600008D
        private System.Void OnEnable() { }
        // RVA: 0x09CD43B4  token: 0x600008E
        private System.Void OnDisable() { }
        // RVA: 0x09CD4528  token: 0x600008F
        private System.Void OnSplineChanged(UnityEngine.Splines.Spline spline, System.Int32 index, UnityEngine.Splines.SplineModification modificationType) { }
        // RVA: 0x09CD44A4  token: 0x6000090
        private System.Void OnKnotModified(UnityEngine.Splines.Spline spline, System.Int32 index) { }
        // RVA: 0x09CD4150  token: 0x6000094
        public System.Boolean Evaluate(System.Single t, Unity.Mathematics.float3& position, Unity.Mathematics.float3& tangent, Unity.Mathematics.float3& upVector) { }
        // RVA: 0x09CD4180  token: 0x6000095
        public System.Boolean Evaluate(System.Int32 splineIndex, System.Single t, Unity.Mathematics.float3& position, Unity.Mathematics.float3& tangent, Unity.Mathematics.float3& upVector) { }
        // RVA: -1  // generic def  token: 0x6000096
        public System.Boolean Evaluate(T spline, System.Single t, Unity.Mathematics.float3& position, Unity.Mathematics.float3& tangent, Unity.Mathematics.float3& upVector) { }
        // RVA: 0x09CD3E8C  token: 0x6000097
        public Unity.Mathematics.float3 EvaluatePosition(System.Single t) { }
        // RVA: 0x09CD3E30  token: 0x6000098
        public UnityEngine.Vector3 EvaluatePositionV3(System.Single t) { }
        // RVA: 0x09CD3EC8  token: 0x6000099
        public Unity.Mathematics.float3 EvaluatePosition(System.Int32 splineIndex, System.Single t) { }
        // RVA: -1  // generic def  token: 0x600009A
        public Unity.Mathematics.float3 EvaluatePosition(T spline, System.Single t) { }
        // RVA: 0x09CD4028  token: 0x600009B
        public Unity.Mathematics.float3 EvaluateTangent(System.Single t) { }
        // RVA: 0x09CD3F78  token: 0x600009C
        public Unity.Mathematics.float3 EvaluateTangent(System.Int32 splineIndex, System.Single t) { }
        // RVA: -1  // generic def  token: 0x600009D
        public Unity.Mathematics.float3 EvaluateTangent(T spline, System.Single t) { }
        // RVA: 0x09CD4114  token: 0x600009E
        public Unity.Mathematics.float3 EvaluateUpVector(System.Single t) { }
        // RVA: 0x09CD4064  token: 0x600009F
        public Unity.Mathematics.float3 EvaluateUpVector(System.Int32 splineIndex, System.Single t) { }
        // RVA: -1  // generic def  token: 0x60000A0
        public Unity.Mathematics.float3 EvaluateUpVector(T spline, System.Single t) { }
        // RVA: 0x09CD3DF4  token: 0x60000A1
        public Unity.Mathematics.float3 EvaluateAcceleration(System.Single t) { }
        // RVA: 0x09CD3D44  token: 0x60000A2
        public Unity.Mathematics.float3 EvaluateAcceleration(System.Int32 splineIndex, System.Single t) { }
        // RVA: -1  // generic def  token: 0x60000A3
        public Unity.Mathematics.float3 EvaluateAcceleration(T spline, System.Single t) { }
        // RVA: 0x09CD3D38  token: 0x60000A4
        public System.Single CalculateLength() { }
        // RVA: 0x09CD3C34  token: 0x60000A5
        public System.Single CalculateLength(System.Int32 splineIndex) { }
        // RVA: 0x0350B670  token: 0x60000A6
        public virtual System.Void OnBeforeSerialize() { }
        // RVA: 0x09CD42A8  token: 0x60000A7
        public virtual System.Void OnAfterDeserialize() { }
        // RVA: 0x09CD4604  token: 0x60000A8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000019  // size: 0x14
    public sealed struct PathIndexUnit
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Splines.PathIndexUnit Distance;  // const
        public static UnityEngine.Splines.PathIndexUnit Normalized;  // const
        public static UnityEngine.Splines.PathIndexUnit Knot;  // const

    }

    // TypeToken: 0x200001A
    public interface ISplineModificationHandler
    {
        // Methods
        // RVA: -1  // abstract  token: 0x60000AB
        public virtual System.Void OnSplineModified(UnityEngine.Splines.SplineModificationData info) { }

    }

    // TypeToken: 0x200001B
    public class SplineData`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, UnityEngine.Splines.ISplineModificationHandler
    {
        // Fields
        private static readonly UnityEngine.Splines.DataPointComparer<UnityEngine.Splines.DataPoint<T>> k_DataPointComparer;  // static @ 0x0
        private UnityEngine.Splines.PathIndexUnit m_IndexUnit;  // 0x0
        private T m_DefaultValue;  // 0x0
        private System.Collections.Generic.List<UnityEngine.Splines.DataPoint<T>> m_DataPoints;  // 0x0
        private System.Boolean m_NeedsSort;  // 0x0
        private System.Action changed;  // 0x0
        private System.Action Changed;  // 0x0

        // Properties
        System.Int32 Count { get; /* RVA: -1  // not resolved */ }

        // Methods
        // RVA: -1  // not resolved  token: 0x60000AD
        public System.Void .ctor() { }
        // RVA: -1  // not resolved  token: 0x60000AE
        public virtual System.Collections.Generic.IEnumerator<UnityEngine.Splines.DataPoint<T>> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60000AF
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60000B0
        private virtual System.Void UnityEngine.Splines.ISplineModificationHandler.OnSplineModified(UnityEngine.Splines.SplineModificationData data) { }
        // RVA: -1  // not resolved  token: 0x60000B1
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200001D
    public class SplineDataKeyValuePair`1
    {
        // Fields
        public System.String Key;  // 0x0
        public UnityEngine.Splines.SplineData<T> Value;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60000B8
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001E
    public class SplineDataDictionary`1 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Splines.SplineDataKeyValuePair<T>> m_Data;  // 0x0

        // Methods
        // RVA: -1  // not resolved  token: 0x60000B9
        public virtual System.Collections.Generic.IEnumerator<UnityEngine.Splines.SplineDataKeyValuePair<T>> GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60000BA
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        // RVA: -1  // not resolved  token: 0x60000BB
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001F  // size: 0x18
    public sealed struct SplineKnotIndex : System.IEquatable`1
    {
        // Fields
        public System.Int32 Spline;  // 0x10
        public System.Int32 Knot;  // 0x14

        // Methods
        // RVA: 0x03D4E4B0  token: 0x60000BC
        public System.Void .ctor(System.Int32 spline, System.Int32 knot) { }
        // RVA: 0x051404D0  token: 0x60000BD
        public virtual System.Boolean Equals(UnityEngine.Splines.SplineKnotIndex otherIndex) { }
        // RVA: 0x09CD541C  token: 0x60000BE
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x03D84B00  token: 0x60000BF
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09CD5480  token: 0x60000C0
        public virtual System.String ToString() { }

    }

    // TypeToken: 0x2000020  // size: 0x10
    public static class SplineMath
    {
        // Methods
        // RVA: 0x09CD5508  token: 0x60000C1
        public static Unity.Mathematics.float3 PointLineNearestPoint(Unity.Mathematics.float3 p, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, System.Single& lineParam) { }

    }

    // TypeToken: 0x2000021  // size: 0x14
    public sealed struct SplineModification
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Splines.SplineModification Default;  // const
        public static UnityEngine.Splines.SplineModification ClosedModified;  // const
        public static UnityEngine.Splines.SplineModification KnotModified;  // const
        public static UnityEngine.Splines.SplineModification KnotInserted;  // const
        public static UnityEngine.Splines.SplineModification KnotRemoved;  // const
        public static UnityEngine.Splines.SplineModification KnotReordered;  // const

    }

    // TypeToken: 0x2000022  // size: 0x28
    public sealed struct SplineModificationData
    {
        // Fields
        public readonly UnityEngine.Splines.Spline Spline;  // 0x10
        public readonly UnityEngine.Splines.SplineModification Modification;  // 0x18
        public readonly System.Int32 KnotIndex;  // 0x1c
        public readonly System.Single PrevCurveLength;  // 0x20
        public readonly System.Single NextCurveLength;  // 0x24

        // Methods
        // RVA: 0x09CD56BC  token: 0x60000C2
        public System.Void .ctor(UnityEngine.Splines.Spline spline, UnityEngine.Splines.SplineModification modification, System.Int32 knotIndex, System.Single prevCurveLength, System.Single nextCurveLength) { }

    }

    // TypeToken: 0x2000023  // size: 0x11
    public sealed struct SplineType
    {
        // Fields
        public System.Byte value__;  // 0x10
        public static UnityEngine.Splines.SplineType CatmullRom;  // const
        public static UnityEngine.Splines.SplineType Bezier;  // const
        public static UnityEngine.Splines.SplineType Linear;  // const

    }

    // TypeToken: 0x2000024  // size: 0x10
    public static class SplineUtility
    {
        // Methods
        // RVA: -1  // generic def  token: 0x60000C3
        public static System.Boolean Evaluate(T spline, System.Single t, Unity.Mathematics.float3& position, Unity.Mathematics.float3& tangent, Unity.Mathematics.float3& upVector) { }
        // RVA: -1  // generic def  token: 0x60000C4
        public static Unity.Mathematics.float3 EvaluatePosition(T spline, System.Single t) { }
        // RVA: -1  // generic def  token: 0x60000C5
        public static UnityEngine.Vector3 EvaluatePositionV3(T spline, System.Single t) { }
        // RVA: -1  // generic def  token: 0x60000C6
        public static Unity.Mathematics.float3 EvaluateTangent(T spline, System.Single t) { }
        // RVA: -1  // generic def  token: 0x60000C7
        public static Unity.Mathematics.float3 EvaluateUpVector(T spline, System.Single t) { }
        // RVA: -1  // generic def  token: 0x60000C8
        private static Unity.Mathematics.float3 EvaluateUpVector(T spline, System.Int32 curveIndex, System.Single curveT) { }
        // RVA: -1  // generic def  token: 0x60000C9
        public static Unity.Mathematics.float3 EvaluateAcceleration(T spline, System.Single t) { }
        // RVA: -1  // generic def  token: 0x60000CA
        public static System.Int32 SplineToCurveT(T spline, System.Single splineT, System.Single& curveT) { }
        // RVA: -1  // generic def  token: 0x60000CB
        private static System.Int32 SplineToCurveT(T spline, System.Single splineT, System.Single& curveT, System.Boolean useLUT) { }
        // RVA: -1  // generic def  token: 0x60000CC
        public static System.Single CalculateLength(T spline, Unity.Mathematics.float4x4 transform) { }
        // RVA: -1  // generic def  token: 0x60000CD
        public static System.Int32 GetCurveCount(T spline) { }
        // RVA: 0x09CD5F7C  token: 0x60000CE
        public static System.Int32 GetSubdivisionCount(System.Single length, System.Int32 resolution) { }
        // RVA: -1  // generic def  token: 0x60000CF
        private static UnityEngine.Splines.SplineUtility.Segment GetNearestPoint(T spline, Unity.Mathematics.float3 point, UnityEngine.Splines.SplineUtility.Segment range, System.Single& distance, Unity.Mathematics.float3& nearest, System.Single& time, System.Int32 segments) { }
        // RVA: -1  // generic def  token: 0x60000D0
        public static System.Single GetNearestPoint(T spline, Unity.Mathematics.float3 point, Unity.Mathematics.float3& nearest, System.Single& t, System.Int32 resolution, System.Int32 iterations) { }
        // RVA: -1  // generic def  token: 0x60000D1
        public static System.Int32 PreviousIndex(T spline, System.Int32 index) { }
        // RVA: -1  // generic def  token: 0x60000D2
        public static System.Int32 NextIndex(T spline, System.Int32 index) { }
        // RVA: -1  // generic def  token: 0x60000D3
        public static UnityEngine.Splines.BezierKnot Previous(T spline, System.Int32 index) { }
        // RVA: -1  // generic def  token: 0x60000D4
        public static UnityEngine.Splines.BezierKnot Next(T spline, System.Int32 index) { }
        // RVA: 0x09CD5FF0  token: 0x60000D5
        private static System.Int32 PreviousIndex(System.Int32 index, System.Int32 count, System.Boolean wrap) { }
        // RVA: 0x09CD5FD4  token: 0x60000D6
        private static System.Int32 NextIndex(System.Int32 index, System.Int32 count, System.Boolean wrap) { }
        // RVA: 0x09CD5C58  token: 0x60000D7
        private static Unity.Mathematics.float3 GetExplicitLinearTangent(Unity.Mathematics.float3 point, Unity.Mathematics.float3 to) { }
        // RVA: 0x09CD5940  token: 0x60000D8
        public static Unity.Mathematics.float3 GetAutoSmoothTangent(Unity.Mathematics.float3 previous, Unity.Mathematics.float3 current, Unity.Mathematics.float3 next, System.Single tension) { }
        // RVA: 0x09CD56F4  token: 0x60000D9
        public static UnityEngine.Splines.BezierKnot GetAutoSmoothKnot(Unity.Mathematics.float3 position, Unity.Mathematics.float3 previous, Unity.Mathematics.float3 next, Unity.Mathematics.float3 normal, System.Single width, System.Single tension) { }
        // RVA: 0x09CD5CDC  token: 0x60000DA
        private static Unity.Mathematics.quaternion GetKnotRotation(Unity.Mathematics.float3 tangent, Unity.Mathematics.float3 normal) { }
        // RVA: -1  // generic def  token: 0x60000DB
        private static System.Boolean IsIndexValid(T container, UnityEngine.Splines.SplineKnotIndex index) { }
        // RVA: -1  // generic def  token: 0x60000DC
        public static System.Void SetLinkedKnotPosition(T container, UnityEngine.Splines.SplineKnotIndex index) { }

    }

}

