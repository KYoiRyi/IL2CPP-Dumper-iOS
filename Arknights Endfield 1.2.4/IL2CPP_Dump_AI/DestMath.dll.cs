// ========================================================
// Dumped by @desirepro
// Assembly: DestMath.dll
// Classes:  152
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

CLASS: Edge
TYPE:  sealed struct
TOKEN: 0x2000005
SIZE:  0x18
FIELDS:
  public            System.Int32                    V0  // 0x10
  public            System.Int32                    V1  // 0x14
METHODS:
  RVA=0x03D4E4B0  token=0x6000017  System.Void .ctor(System.Int32 v0, System.Int32 v1)
END_CLASS

CLASS: InnerPoint
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x20
FIELDS:
  public            System.Single                   AverageDistance  // 0x10
  public            System.Single                   Distance0  // 0x14
  public            System.Single                   Distance1  // 0x18
  public            System.Int32                    Index  // 0x1c
METHODS:
END_CLASS

CLASS: SortedVertex
TYPE:  class
TOKEN: 0x2000009
SIZE:  0x18
FIELDS:
  public            System.Single                   Value  // 0x10
  public            System.Int32                    Index  // 0x14
METHODS:
  RVA=0x0350B670  token=0x600001C  System.Void .ctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x200000A
SIZE:  0x10
FIELDS:
  public    static readonly Dest.Math.ConvexHull1.<>c       <>9  // static @ 0x0
  public    static  System.Comparison<Dest.Math.ConvexHull1.SortedVertex><>9__1_0  // static @ 0x8
METHODS:
  RVA=0x057038A8  token=0x600001D  System.Void .cctor()
  RVA=0x0350B670  token=0x600001E  System.Void .ctor()
  RVA=0x0570383C  token=0x600001F  System.Int32 <Create>b__1_0(Dest.Math.ConvexHull1.SortedVertex e1, Dest.Math.ConvexHull1.SortedVertex e2)
END_CLASS

CLASS: Edge
TYPE:  class
TOKEN: 0x200000C
SIZE:  0x30
FIELDS:
  public            System.Int32                    V0  // 0x10
  public            System.Int32                    V1  // 0x14
  public            Dest.Math.ConvexHull2.Edge      E0  // 0x18
  public            Dest.Math.ConvexHull2.Edge      E1  // 0x20
  public            System.Int32                    Sign  // 0x28
  public            System.Int32                    Time  // 0x2c
METHODS:
  RVA=0x03D52550  token=0x6000023  System.Void .ctor(System.Int32 v0, System.Int32 v1)
  RVA=0x057031AC  token=0x6000024  System.Int32 GetSign(System.Int32 i, Dest.Math.Query2 query)
  RVA=0x057031F0  token=0x6000025  System.Void Insert(Dest.Math.ConvexHull2.Edge adj0, Dest.Math.ConvexHull2.Edge adj1)
  RVA=0x057030C8  token=0x6000026  System.Void DeleteSelf()
  RVA=0x05703108  token=0x6000027  System.Void GetIndices(System.Int32[]& indices)
END_CLASS

CLASS: Triangle
TYPE:  class
TOKEN: 0x200000E
SIZE:  0x48
FIELDS:
  public            System.Int32                    V0  // 0x10
  public            System.Int32                    V1  // 0x14
  public            System.Int32                    V2  // 0x18
  public            Dest.Math.ConvexHull3.Triangle  Adj0  // 0x20
  public            Dest.Math.ConvexHull3.Triangle  Adj1  // 0x28
  public            Dest.Math.ConvexHull3.Triangle  Adj2  // 0x30
  public            System.Int32                    Sign  // 0x38
  public            System.Int32                    Time  // 0x3c
  public            System.Boolean                  OnStack  // 0x40
METHODS:
  RVA=0x03D52560  token=0x600002C  System.Void .ctor(System.Int32 v0, System.Int32 v1, System.Int32 v2)
  RVA=0x05703794  token=0x600002D  Dest.Math.ConvexHull3.Triangle GetAdj(System.Int32 index)
  RVA=0x0570380C  token=0x600002E  System.Void SetAdj(System.Int32 index, Dest.Math.ConvexHull3.Triangle value)
  RVA=0x057037F4  token=0x600002F  System.Int32 GetV(System.Int32 index)
  RVA=0x057037AC  token=0x6000030  System.Int32 GetSign(System.Int32 i, Dest.Math.Query3 query)
  RVA=0x057036C0  token=0x6000031  System.Void AttachTo(Dest.Math.ConvexHull3.Triangle adj0, Dest.Math.ConvexHull3.Triangle adj1, Dest.Math.ConvexHull3.Triangle adj2)
  RVA=0x057036F8  token=0x6000032  System.Int32 DetachFrom(System.Int32 adjIndex, Dest.Math.ConvexHull3.Triangle adj)
END_CLASS

CLASS: TerminatorData
TYPE:  class
TOKEN: 0x200000F
SIZE:  0x28
FIELDS:
  public            System.Int32                    V0  // 0x10
  public            System.Int32                    V1  // 0x14
  public            System.Int32                    NullIndex  // 0x18
  public            Dest.Math.ConvexHull3.Triangle  T  // 0x20
METHODS:
  RVA=0x0570368C  token=0x6000033  System.Void .ctor(System.Int32 v0, System.Int32 v1, System.Int32 nullIndex, Dest.Math.ConvexHull3.Triangle tri)
END_CLASS

CLASS: Information
TYPE:  class
TOKEN: 0x2000055
SIZE:  0x48
FIELDS:
  public            System.Int32                    Dimension  // 0x10
  public            UnityEngine.Vector2             Min  // 0x14
  public            UnityEngine.Vector2             Max  // 0x1c
  public            System.Single                   MaxRange  // 0x24
  public            UnityEngine.Vector2             Origin  // 0x28
  public            UnityEngine.Vector2[]           Direction  // 0x30
  public            System.Int32[]                  Extreme  // 0x38
  public            System.Boolean                  ExtremeCCW  // 0x40
METHODS:
  RVA=0x0571721C  token=0x6000219  System.Void .ctor()
END_CLASS

CLASS: Information
TYPE:  class
TOKEN: 0x2000058
SIZE:  0x58
FIELDS:
  public            System.Int32                    Dimension  // 0x10
  public            UnityEngine.Vector3             Min  // 0x14
  public            UnityEngine.Vector3             Max  // 0x20
  public            System.Single                   MaxRange  // 0x2c
  public            UnityEngine.Vector3             Origin  // 0x30
  public            UnityEngine.Vector3[]           Direction  // 0x40
  public            System.Int32[]                  Extreme  // 0x48
  public            System.Boolean                  ExtremeCCW  // 0x50
METHODS:
  RVA=0x05717290  token=0x6000237  System.Void .ctor()
END_CLASS

CLASS: PolyRootFinder
TYPE:  class
TOKEN: 0x200005B
SIZE:  0x28
FIELDS:
  private           System.Int32                    _count  // 0x10
  private           System.Int32                    _maxRoot  // 0x14
  private           System.Single[]                 _roots  // 0x18
  private           System.Single                   _epsilon  // 0x20
PROPERTIES:
  Roots  get=0x01041090
METHODS:
  RVA=0x0572925C  token=0x6000242  System.Void .ctor(System.Single epsilon)
  RVA=0x05728C8C  token=0x6000243  System.Boolean Bisection(Dest.Math.Polynomial poly, System.Single xMin, System.Single xMax, System.Int32 digits, System.Single& root)
  RVA=0x05728E2C  token=0x6000244  System.Boolean Find(Dest.Math.Polynomial poly, System.Single xMin, System.Single xMax, System.Int32 digits)
END_CLASS

CLASS: ItemData
TYPE:  class
TOKEN: 0x200008A
SIZE:  0x60
FIELDS:
  public            UnityEngine.Vector3             Position  // 0x10
  public            UnityEngine.Vector3             A  // 0x1c
  public            UnityEngine.Vector3             B  // 0x28
  public            UnityEngine.Vector3             C  // 0x34
  public            UnityEngine.Vector3             D  // 0x40
  public            System.Single                   Length  // 0x4c
  public            System.Single                   AccumulatedLength  // 0x50
  private   static  System.Int32                    SegmentCount  // const
  private   static  System.Int32                    SegmentCountPlus1  // const
  private   static  System.Single                   DeltaTime  // const
  public            UnityEngine.Vector3[]           RenderPoints  // 0x58
METHODS:
  RVA=0x0573163C  token=0x600043F  System.Boolean EnsureRenderPointsValidity()
  RVA=0x05731D38  token=0x6000440  System.Void UpdateRenderPoints()
  RVA=0x057318E4  token=0x6000441  UnityEngine.Vector3 EvalPosition(System.Single t)
  RVA=0x0573169C  token=0x6000442  UnityEngine.Vector3 EvalFirstDerivative(System.Single t)
  RVA=0x05731A04  token=0x6000443  UnityEngine.Vector3 EvalSecondDerivative(System.Single t)
  RVA=0x05731CBC  token=0x6000444  UnityEngine.Vector3 EvalThirdDerivative(System.Single t)
  RVA=0x05731AA8  token=0x6000445  System.Single EvalSpeed(System.Single t)
  RVA=0x05731BA4  token=0x6000446  UnityEngine.Vector3 EvalTangent(System.Single t)
  RVA=0x05731794  token=0x6000447  System.Single EvalLength()
  RVA=0x05731830  token=0x6000448  System.Single EvalLength(System.Single t0, System.Single t1)
  RVA=0x05731D04  token=0x6000449  System.Single ProcessLength(System.Single currentLength)
  RVA=0x0350B670  token=0x600044A  System.Void .ctor()
END_CLASS

CLASS: ArcLengthParametrization
TYPE:  class
TOKEN: 0x200008B
SIZE:  0x30
FIELDS:
  public            System.Single[]                 sSample  // 0x10
  public            System.Single[]                 tSample  // 0x18
  public            System.Single[]                 tsSlope  // 0x20
  public            System.Single                   L  // 0x28
METHODS:
  RVA=0x0572C704  token=0x600044B  System.Single GetApproximateTimeParameter(System.Single s)
  RVA=0x0350B670  token=0x600044C  System.Void .ctor()
END_CLASS

CLASS: Data
TYPE:  class
TOKEN: 0x200008D
SIZE:  0x58
FIELDS:
  private           UnityEngine.Vector3[]           _points  // 0x10
  private           System.Collections.Generic.List<System.Int32>[,,]_grid  // 0x18
  private           UnityEngine.Vector3             _min  // 0x20
  private           UnityEngine.Vector3             _max  // 0x2c
  private           System.Int32                    _cellsX  // 0x38
  private           System.Int32                    _cellsY  // 0x3c
  private           System.Int32                    _cellsZ  // 0x40
  private           System.Single                   _cellSize  // 0x44
  private           System.Single                   _radius  // 0x48
  private           Dest.Math.Rand                  _rand  // 0x50
METHODS:
  RVA=0x05730964  token=0x600044E  System.Void .ctor(UnityEngine.Vector3[] points, System.Single radius, Dest.Math.Rand rand, Dest.Math.AAB3 aab)
  RVA=0x0573018C  token=0x600044F  System.Int32 BinarySearch(System.Collections.Generic.List<System.Int32> array, System.Int32 value)
  RVA=0x05730114  token=0x6000450  System.Int32 BinarySearch(System.Int32[] array, System.Int32 length, System.Int32 value)
  RVA=0x0573024C  token=0x6000451  System.Void CalcGridIndices(UnityEngine.Vector3& point, System.Int32& i, System.Int32& j, System.Int32& k)
  RVA=0x05730294  token=0x6000452  System.Collections.Generic.List<System.Int32> Filter()
END_CLASS

CLASS: PointDelegate
TYPE:  sealed class
TOKEN: 0x200008F
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x057341A4  token=0x600045B  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x0102B410  token=0x600045C  System.Single Invoke(UnityEngine.Vector2& point)
  RVA=0x05734124  token=0x600045D  System.IAsyncResult BeginInvoke(UnityEngine.Vector2& point, System.AsyncCallback callback, System.Object object)
  RVA=0x050C43C0  token=0x600045E  System.Single EndInvoke(UnityEngine.Vector2& point, System.IAsyncResult result)
END_CLASS

CLASS: <GetEnumerator>d__13
TYPE:  sealed class
TOKEN: 0x2000095
IMPLEMENTS: System.Collections.Generic.IEnumerator`1 System.Collections.IEnumerator System.IDisposable
FIELDS:
  private           System.Int32                    <>1__state  // 0x0
  private           T                               <>2__current  // 0x0
  public            Dest.Math.ShuffleBag<T>         <>4__this  // 0x0
  private           System.Int32                    <i>5__2  // 0x0
  private           System.Int32                    <len>5__3  // 0x0
PROPERTIES:
  System.Collections.Generic.IEnumerator<T>.Current  get=-1  // not resolved
  System.Collections.IEnumerator.Current  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000481  System.Void .ctor(System.Int32 <>1__state)
  RVA=-1  // not resolved  token=0x6000482  System.Void System.IDisposable.Dispose()
  RVA=-1  // not resolved  token=0x6000483  System.Boolean MoveNext()
  RVA=-1  // not resolved  token=0x6000485  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: __StaticArrayInitTypeSize=20
TYPE:  sealed struct
TOKEN: 0x2000098
SIZE:  0x24
FIELDS:
METHODS:
END_CLASS

CLASS: <PrivateImplementationDetails>
TYPE:  sealed class
TOKEN: 0x2000097
SIZE:  0x10
FIELDS:
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20170A8789272DFBCBA0E6B7D2530CAA16D9199834934F442421DAB41C5EEA8C29  // static @ 0x0
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2092052E6D9D3C30FD20B710DFB226BEEA15F69C2188B5AA373563D6966493C59C  // static @ 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Polynomial
TYPE:  class
TOKEN: 0x2000002
SIZE:  0x20
FIELDS:
  private           System.Int32                    _degree  // 0x10
  private           System.Single[]                 _coeffs  // 0x18
PROPERTIES:
  Degree  get=0x03D4E340  set=0x05703608
  Item  get=0x057035D8  set=0x0570365C
METHODS:
  RVA=0x057035D0  token=0x6000005  System.Void .ctor(System.Int32 degree)
  RVA=0x057034CC  token=0x6000006  Dest.Math.Polynomial DeepCopy()
  RVA=0x05703248  token=0x6000007  Dest.Math.Polynomial CalcDerivative()
  RVA=0x0570334C  token=0x6000008  Dest.Math.Polynomial CalcInversion()
  RVA=0x05703400  token=0x6000009  System.Void Compress(System.Single epsilon)
  RVA=0x0570357C  token=0x600000A  System.Single Eval(System.Single t)
END_CLASS

CLASS: Dest.Math.Approximation
TYPE:  static class
TOKEN: 0x2000003
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x056F5A74  token=0x600000B  Dest.Math.Box2 GaussPointsFit2(System.Collections.Generic.IList<UnityEngine.Vector2> points)
  RVA=0x056F6304  token=0x600000C  System.Boolean HeightLineFit2(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Single& a, System.Single& b)
  RVA=0x056F6A6C  token=0x600000D  Dest.Math.Line2 LeastSquaresLineFit2(System.Collections.Generic.IList<UnityEngine.Vector2> points)
  RVA=0x056F5E20  token=0x600000E  Dest.Math.Box3 GaussPointsFit3(System.Collections.Generic.IList<UnityEngine.Vector3> points)
  RVA=0x056F7114  token=0x600000F  Dest.Math.Line3 LeastsSquaresLineFit3(System.Collections.Generic.IList<UnityEngine.Vector3> points)
  RVA=0x056F65D4  token=0x6000010  System.Boolean HeightPlaneFit3(System.Collections.Generic.IList<UnityEngine.Vector3> points, System.Single& a, System.Single& b, System.Single& c)
  RVA=0x056F6D58  token=0x6000011  Dest.Math.Plane3 LeastSquaresPlaneFit3(System.Collections.Generic.IList<UnityEngine.Vector3> points)
END_CLASS

CLASS: Dest.Math.ConcaveHull2
TYPE:  class
TOKEN: 0x2000004
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x056F82D4  token=0x6000012  System.Boolean _TryFastSort(Dest.Math.ConcaveHull2.InnerPoint[] x, System.Int32 first, System.Int32 last)
  RVA=0x056F8130  token=0x6000013  System.Void Quicksort(Dest.Math.ConcaveHull2.InnerPoint[] x, System.Int32 first, System.Int32 last)
  RVA=0x056F7548  token=0x6000014  System.Single CalcDistanceFromPointToEdge(UnityEngine.Vector2& pointA, UnityEngine.Vector2& v0, UnityEngine.Vector2& v1)
  RVA=0x056F7658  token=0x6000015  System.Boolean Create(UnityEngine.Vector2[] points, System.Int32[]& concaveHull, System.Int32[] convexHull, System.Single N, System.Single epsilon)
  RVA=0x0350B670  token=0x6000016  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.ConcaveHull
TYPE:  static class
TOKEN: 0x2000007
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x056F83D0  token=0x6000018  System.Boolean Create2D(UnityEngine.Vector2[] points, System.Int32[]& concaveHull, System.Int32[]& convexHull, System.Single algorithmThreshold, System.Single epsilon)
  RVA=0x056F83A8  token=0x6000019  System.Boolean Create2D(UnityEngine.Vector2[] points, System.Int32[]& concaveHull, System.Single algorithmThreshold, System.Single epsilon)
END_CLASS

CLASS: Dest.Math.ConvexHull1
TYPE:  class
TOKEN: 0x2000008
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x056F851C  token=0x600001A  System.Void Create(System.Single[] vertices, System.Single epsilon, System.Int32& dimension, System.Int32[]& indices)
  RVA=0x0350B670  token=0x600001B  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.ConvexHull2
TYPE:  class
TOKEN: 0x200000B
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x056F87D4  token=0x6000020  System.Boolean Create(System.Collections.Generic.IList<UnityEngine.Vector2> vertices, System.Single epsilon, System.Int32& dimension, System.Int32[]& indices)
  RVA=0x056F8C88  token=0x6000021  System.Boolean Update(Dest.Math.ConvexHull2.Edge& hull, System.Int32 i, Dest.Math.Query2 query)
  RVA=0x0350B670  token=0x6000022  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.ConvexHull3
TYPE:  class
TOKEN: 0x200000D
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x056F8E60  token=0x6000028  System.Boolean Create(System.Collections.Generic.IList<UnityEngine.Vector3> vertices, System.Single epsilon, System.Int32& dimension, System.Int32[]& indices)
  RVA=0x056F986C  token=0x6000029  System.Boolean Update(System.Collections.Generic.HashSet<Dest.Math.ConvexHull3.Triangle> hull, System.Int32 i, Dest.Math.Query3 query)
  RVA=0x056F9654  token=0x600002A  System.Void ExtractIndices(System.Collections.Generic.HashSet<Dest.Math.ConvexHull3.Triangle> hull, System.Int32[]& indices)
  RVA=0x0350B670  token=0x600002B  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.ConvexHull
TYPE:  static class
TOKEN: 0x2000010
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x056FA1F4  token=0x6000034  System.Boolean Create2D(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Int32[]& indices, System.Int32& dimension, System.Single epsilon)
  RVA=0x056FA294  token=0x6000035  System.Boolean Create3D(System.Collections.Generic.IList<UnityEngine.Vector3> points, System.Int32[]& indices, System.Int32& dimension, System.Single epsilon)
END_CLASS

CLASS: Dest.Math.Distance
TYPE:  static class
TOKEN: 0x2000011
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x056FB9CC  token=0x6000036  System.Single Line2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1)
  RVA=0x056FB9F4  token=0x6000037  System.Single Line2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  RVA=0x056FCCBC  token=0x6000038  System.Single SqrLine2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1)
  RVA=0x056FCDD4  token=0x6000039  System.Single SqrLine2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  RVA=0x056FBA24  token=0x600003A  System.Single Line2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray)
  RVA=0x056FBA4C  token=0x600003B  System.Single Line2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  RVA=0x056FD000  token=0x600003C  System.Single SqrLine2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray)
  RVA=0x056FD18C  token=0x600003D  System.Single SqrLine2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  RVA=0x056FBAAC  token=0x600003E  System.Single Line2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment)
  RVA=0x056FBA7C  token=0x600003F  System.Single Line2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  RVA=0x056FD3E8  token=0x6000040  System.Single SqrLine2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment)
  RVA=0x056FD618  token=0x6000041  System.Single SqrLine2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  RVA=0x056FBD24  token=0x6000042  System.Single Point2AAB2(UnityEngine.Vector2& point, Dest.Math.AAB2& box)
  RVA=0x056FBC68  token=0x6000043  System.Single Point2AAB2(UnityEngine.Vector2& point, Dest.Math.AAB2& box, UnityEngine.Vector2& closestPoint)
  RVA=0x056FE9C0  token=0x6000044  System.Single SqrPoint2AAB2(UnityEngine.Vector2& point, Dest.Math.AAB2& box)
  RVA=0x056FEA30  token=0x6000045  System.Single SqrPoint2AAB2(UnityEngine.Vector2& point, Dest.Math.AAB2& box, UnityEngine.Vector2& closestPoint)
  RVA=0x056FBDC0  token=0x6000046  System.Single Point2Box2(UnityEngine.Vector2& point, Dest.Math.Box2& box)
  RVA=0x056FBD98  token=0x6000047  System.Single Point2Box2(UnityEngine.Vector2& point, Dest.Math.Box2& box, UnityEngine.Vector2& closestPoint)
  RVA=0x056FEAE8  token=0x6000048  System.Single SqrPoint2Box2(UnityEngine.Vector2& point, Dest.Math.Box2& box)
  RVA=0x056FEC00  token=0x6000049  System.Single SqrPoint2Box2(UnityEngine.Vector2& point, Dest.Math.Box2& box, UnityEngine.Vector2& closestPoint)
  RVA=0x056FBE98  token=0x600004A  System.Single Point2Circle2(UnityEngine.Vector2& point, Dest.Math.Circle2& circle)
  RVA=0x056FBDE8  token=0x600004B  System.Single Point2Circle2(UnityEngine.Vector2& point, Dest.Math.Circle2& circle, UnityEngine.Vector2& closestPoint)
  RVA=0x056FEE74  token=0x600004C  System.Single SqrPoint2Circle2(UnityEngine.Vector2& point, Dest.Math.Circle2& circle)
  RVA=0x056FEDC0  token=0x600004D  System.Single SqrPoint2Circle2(UnityEngine.Vector2& point, Dest.Math.Circle2& circle, UnityEngine.Vector2& closestPoint)
  RVA=0x056FBEFC  token=0x600004E  System.Single Point2Line2(UnityEngine.Vector2& point, Dest.Math.Line2& line)
  RVA=0x056FBED4  token=0x600004F  System.Single Point2Line2(UnityEngine.Vector2& point, Dest.Math.Line2& line, UnityEngine.Vector2& closestPoint)
  RVA=0x056FEF98  token=0x6000050  System.Single SqrPoint2Line2(UnityEngine.Vector2& point, Dest.Math.Line2& line)
  RVA=0x056FEEB4  token=0x6000051  System.Single SqrPoint2Line2(UnityEngine.Vector2& point, Dest.Math.Line2& line, UnityEngine.Vector2& closestPoint)
  RVA=0x056FBF24  token=0x6000052  System.Single Point2Ray2(UnityEngine.Vector2& point, Dest.Math.Ray2& ray)
  RVA=0x056FBF4C  token=0x6000053  System.Single Point2Ray2(UnityEngine.Vector2& point, Dest.Math.Ray2& ray, UnityEngine.Vector2& closestPoint)
  RVA=0x056FF178  token=0x6000054  System.Single SqrPoint2Ray2(UnityEngine.Vector2& point, Dest.Math.Ray2& ray)
  RVA=0x056FF06C  token=0x6000055  System.Single SqrPoint2Ray2(UnityEngine.Vector2& point, Dest.Math.Ray2& ray, UnityEngine.Vector2& closestPoint)
  RVA=0x056FBF74  token=0x6000056  System.Single Point2Segment2(UnityEngine.Vector2& point, Dest.Math.Segment2& segment)
  RVA=0x056FBF9C  token=0x6000057  System.Single Point2Segment2(UnityEngine.Vector2& point, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint)
  RVA=0x056FF398  token=0x6000058  System.Single SqrPoint2Segment2(UnityEngine.Vector2& point, Dest.Math.Segment2& segment)
  RVA=0x056FF264  token=0x6000059  System.Single SqrPoint2Segment2(UnityEngine.Vector2& point, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint)
  RVA=0x056FBFC4  token=0x600005A  System.Single Point2Triangle2(UnityEngine.Vector2& point, Dest.Math.Triangle2& triangle)
  RVA=0x056FC12C  token=0x600005B  System.Single Point2Triangle2(UnityEngine.Vector2& point, Dest.Math.Triangle2& triangle, UnityEngine.Vector2& closestPoint)
  RVA=0x056FF4C0  token=0x600005C  System.Single SqrPoint2Triangle2(UnityEngine.Vector2& point, Dest.Math.Triangle2& triangle)
  RVA=0x056FF628  token=0x600005D  System.Single SqrPoint2Triangle2(UnityEngine.Vector2& point, Dest.Math.Triangle2& triangle, UnityEngine.Vector2& closestPoint)
  RVA=0x056FCA0C  token=0x600005E  System.Single Ray2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1)
  RVA=0x056FC9DC  token=0x600005F  System.Single Ray2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  RVA=0x05701688  token=0x6000060  System.Single SqrRay2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1)
  RVA=0x05701398  token=0x6000061  System.Single SqrRay2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  RVA=0x056FCA4C  token=0x6000062  System.Single Ray2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment)
  RVA=0x056FCA8C  token=0x6000063  System.Single Ray2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  RVA=0x05701A18  token=0x6000064  System.Single SqrRay2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment)
  RVA=0x057016B4  token=0x6000065  System.Single SqrRay2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  RVA=0x056FCBB4  token=0x6000066  System.Single Segment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1)
  RVA=0x056FCB84  token=0x6000067  System.Single Segment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  RVA=0x05702324  token=0x6000068  System.Single SqrSegment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1)
  RVA=0x05702350  token=0x6000069  System.Single SqrSegment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1, UnityEngine.Vector2& closestPoint0, UnityEngine.Vector2& closestPoint1)
  RVA=0x056FABA0  token=0x600006A  System.Void Face(Dest.Math.Box3& mBox, System.Single& mLineParameter, System.Int32 i0, System.Int32 i1, System.Int32 i2, UnityEngine.Vector3& pnt, UnityEngine.Vector3& dir, UnityEngine.Vector3& PmE, System.Single& sqrDistance)
  RVA=0x056FAAC0  token=0x600006B  System.Void CaseNoZeros(Dest.Math.Box3& mBox, System.Single& mLineParameter, UnityEngine.Vector3& pnt, UnityEngine.Vector3& dir, System.Single& sqrDistance)
  RVA=0x056FA65C  token=0x600006C  System.Void Case0(Dest.Math.Box3& mBox, System.Single& mLineParameter, System.Int32 i0, System.Int32 i1, System.Int32 i2, UnityEngine.Vector3& pnt, UnityEngine.Vector3& dir, System.Single& sqrDistance)
  RVA=0x056FA44C  token=0x600006D  System.Void Case00(Dest.Math.Box3& mBox, System.Single& mLineParameter, System.Int32 i0, System.Int32 i1, System.Int32 i2, UnityEngine.Vector3& pnt, UnityEngine.Vector3& dir, System.Single& sqrDistance)
  RVA=0x056FA334  token=0x600006E  System.Void Case000(Dest.Math.Box3& mBox, System.Single& mLineParameter, UnityEngine.Vector3& pnt, System.Single& sqrDistance)
  RVA=0x056FBAD4  token=0x600006F  System.Single Line3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box, Dest.Math.Line3Box3Dist& info)
  RVA=0x056FBAFC  token=0x6000070  System.Single Line3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box)
  RVA=0x056FD8E8  token=0x6000071  System.Single SqrLine3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box, Dest.Math.Line3Box3Dist& info)
  RVA=0x056FDEA0  token=0x6000072  System.Single SqrLine3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box)
  RVA=0x056FBB3C  token=0x6000073  System.Single Line3Line3(Dest.Math.Line3& line0, Dest.Math.Line3& line1)
  RVA=0x056FBB70  token=0x6000074  System.Single Line3Line3(Dest.Math.Line3& line0, Dest.Math.Line3& line1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  RVA=0x056FDECC  token=0x6000075  System.Single SqrLine3Line3(Dest.Math.Line3& line0, Dest.Math.Line3& line1)
  RVA=0x056FDF00  token=0x6000076  System.Single SqrLine3Line3(Dest.Math.Line3& line0, Dest.Math.Line3& line1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  RVA=0x056FBBA0  token=0x6000077  System.Single Line3Ray3(Dest.Math.Line3& line, Dest.Math.Ray3& ray)
  RVA=0x056FBBD4  token=0x6000078  System.Single Line3Ray3(Dest.Math.Line3& line, Dest.Math.Ray3& ray, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  RVA=0x056FE590  token=0x6000079  System.Single SqrLine3Ray3(Dest.Math.Line3& line, Dest.Math.Ray3& ray)
  RVA=0x056FE250  token=0x600007A  System.Single SqrLine3Ray3(Dest.Math.Line3& line, Dest.Math.Ray3& ray, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  RVA=0x056FBC04  token=0x600007B  System.Single Line3Segment3(Dest.Math.Line3& line, Dest.Math.Segment3& segment)
  RVA=0x056FBC38  token=0x600007C  System.Single Line3Segment3(Dest.Math.Line3& line, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  RVA=0x056FE5C4  token=0x600007D  System.Single SqrLine3Segment3(Dest.Math.Line3& line, Dest.Math.Segment3& segment)
  RVA=0x056FE5F8  token=0x600007E  System.Single SqrLine3Segment3(Dest.Math.Line3& line, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  RVA=0x056FC2E4  token=0x600007F  System.Single Point3AAB3(UnityEngine.Vector3& point, Dest.Math.AAB3& box)
  RVA=0x056FC388  token=0x6000080  System.Single Point3AAB3(UnityEngine.Vector3& point, Dest.Math.AAB3& box, UnityEngine.Vector3& closestPoint)
  RVA=0x056FF8EC  token=0x6000081  System.Single SqrPoint3AAB3(UnityEngine.Vector3& point, Dest.Math.AAB3& box)
  RVA=0x056FF7E0  token=0x6000082  System.Single SqrPoint3AAB3(UnityEngine.Vector3& point, Dest.Math.AAB3& box, UnityEngine.Vector3& closestPoint)
  RVA=0x056FC4C0  token=0x6000083  System.Single Point3Box3(UnityEngine.Vector3& point, Dest.Math.Box3& box)
  RVA=0x056FC498  token=0x6000084  System.Single Point3Box3(UnityEngine.Vector3& point, Dest.Math.Box3& box, UnityEngine.Vector3& closestPoint)
  RVA=0x056FF98C  token=0x6000085  System.Single SqrPoint3Box3(UnityEngine.Vector3& point, Dest.Math.Box3& box)
  RVA=0x056FFB68  token=0x6000086  System.Single SqrPoint3Box3(UnityEngine.Vector3& point, Dest.Math.Box3& box, UnityEngine.Vector3& closestPoint)
  RVA=0x056FC518  token=0x6000087  System.Single Point3Circle3(UnityEngine.Vector3& point, Dest.Math.Circle3& circle, System.Boolean solid)
  RVA=0x056FC4E8  token=0x6000088  System.Single Point3Circle3(UnityEngine.Vector3& point, Dest.Math.Circle3& circle, UnityEngine.Vector3& closestPoint, System.Boolean solid)
  RVA=0x057002B0  token=0x6000089  System.Single SqrPoint3Circle3(UnityEngine.Vector3& point, Dest.Math.Circle3& circle, System.Boolean solid)
  RVA=0x056FFEB8  token=0x600008A  System.Single SqrPoint3Circle3(UnityEngine.Vector3& point, Dest.Math.Circle3& circle, UnityEngine.Vector3& closestPoint, System.Boolean solid)
  RVA=0x056FC558  token=0x600008B  System.Single Point3Line3(UnityEngine.Vector3& point, Dest.Math.Line3& line)
  RVA=0x056FC580  token=0x600008C  System.Single Point3Line3(UnityEngine.Vector3& point, Dest.Math.Line3& line, UnityEngine.Vector3& closestPoint)
  RVA=0x05700454  token=0x600008D  System.Single SqrPoint3Line3(UnityEngine.Vector3& point, Dest.Math.Line3& line)
  RVA=0x057002D8  token=0x600008E  System.Single SqrPoint3Line3(UnityEngine.Vector3& point, Dest.Math.Line3& line, UnityEngine.Vector3& closestPoint)
  RVA=0x056FC6C4  token=0x600008F  System.Single Point3Plane3(UnityEngine.Vector3& point, Dest.Math.Plane3& plane)
  RVA=0x056FC5A8  token=0x6000090  System.Single Point3Plane3(UnityEngine.Vector3& point, Dest.Math.Plane3& plane, UnityEngine.Vector3& closestPoint)
  RVA=0x057006E0  token=0x6000091  System.Single SqrPoint3Plane3(UnityEngine.Vector3& point, Dest.Math.Plane3& plane)
  RVA=0x057005C8  token=0x6000092  System.Single SqrPoint3Plane3(UnityEngine.Vector3& point, Dest.Math.Plane3& plane, UnityEngine.Vector3& closestPoint)
  RVA=0x056FC78C  token=0x6000093  System.Single Point3Ray3(UnityEngine.Vector3& point, Dest.Math.Ray3& ray)
  RVA=0x056FC764  token=0x6000094  System.Single Point3Ray3(UnityEngine.Vector3& point, Dest.Math.Ray3& ray, UnityEngine.Vector3& closestPoint)
  RVA=0x05700924  token=0x6000095  System.Single SqrPoint3Ray3(UnityEngine.Vector3& point, Dest.Math.Ray3& ray)
  RVA=0x05700780  token=0x6000096  System.Single SqrPoint3Ray3(UnityEngine.Vector3& point, Dest.Math.Ray3& ray, UnityEngine.Vector3& closestPoint)
  RVA=0x056FC7DC  token=0x6000097  System.Single Point3Rectangle3(UnityEngine.Vector3& point, Dest.Math.Rectangle3& rectangle)
  RVA=0x056FC7B4  token=0x6000098  System.Single Point3Rectangle3(UnityEngine.Vector3& point, Dest.Math.Rectangle3& rectangle, UnityEngine.Vector3& closestPoint)
  RVA=0x05700D08  token=0x6000099  System.Single SqrPoint3Rectangle3(UnityEngine.Vector3& point, Dest.Math.Rectangle3& rectangle)
  RVA=0x05700AA4  token=0x600009A  System.Single SqrPoint3Rectangle3(UnityEngine.Vector3& point, Dest.Math.Rectangle3& rectangle, UnityEngine.Vector3& closestPoint)
  RVA=0x056FC82C  token=0x600009B  System.Single Point3Segment3(UnityEngine.Vector3& point, Dest.Math.Segment3& segment)
  RVA=0x056FC804  token=0x600009C  System.Single Point3Segment3(UnityEngine.Vector3& point, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint)
  RVA=0x05701068  token=0x600009D  System.Single SqrPoint3Segment3(UnityEngine.Vector3& point, Dest.Math.Segment3& segment)
  RVA=0x05700EA8  token=0x600009E  System.Single SqrPoint3Segment3(UnityEngine.Vector3& point, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint)
  RVA=0x056FC968  token=0x600009F  System.Single Point3Sphere3(UnityEngine.Vector3& point, Dest.Math.Sphere3& sphere)
  RVA=0x056FC854  token=0x60000A0  System.Single Point3Sphere3(UnityEngine.Vector3& point, Dest.Math.Sphere3& sphere, UnityEngine.Vector3& closestPoint)
  RVA=0x05701208  token=0x60000A1  System.Single SqrPoint3Sphere3(UnityEngine.Vector3& point, Dest.Math.Sphere3& sphere)
  RVA=0x05701280  token=0x60000A2  System.Single SqrPoint3Sphere3(UnityEngine.Vector3& point, Dest.Math.Sphere3& sphere, UnityEngine.Vector3& closestPoint)
  RVA=0x056FCAEC  token=0x60000A3  System.Single Ray3Ray3(Dest.Math.Ray3& ray0, Dest.Math.Ray3& ray1)
  RVA=0x056FCABC  token=0x60000A4  System.Single Ray3Ray3(Dest.Math.Ray3& ray0, Dest.Math.Ray3& ray1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  RVA=0x05701E74  token=0x60000A5  System.Single SqrRay3Ray3(Dest.Math.Ray3& ray0, Dest.Math.Ray3& ray1)
  RVA=0x05701A44  token=0x60000A6  System.Single SqrRay3Ray3(Dest.Math.Ray3& ray0, Dest.Math.Ray3& ray1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  RVA=0x056FCB50  token=0x60000A7  System.Single Ray3Segment3(Dest.Math.Ray3& ray, Dest.Math.Segment3& segment)
  RVA=0x056FCB20  token=0x60000A8  System.Single Ray3Segment3(Dest.Math.Ray3& ray, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  RVA=0x057022F0  token=0x60000A9  System.Single SqrRay3Segment3(Dest.Math.Ray3& ray, Dest.Math.Segment3& segment)
  RVA=0x05701EA8  token=0x60000AA  System.Single SqrRay3Segment3(Dest.Math.Ray3& ray, Dest.Math.Segment3& segment, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  RVA=0x056FCBF4  token=0x60000AB  System.Single Segment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  RVA=0x056FCC24  token=0x60000AC  System.Single Segment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box)
  RVA=0x05702908  token=0x60000AD  System.Single SqrSegment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  RVA=0x057028D4  token=0x60000AE  System.Single SqrSegment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box)
  RVA=0x056FCC88  token=0x60000AF  System.Single Segment3Segment3(Dest.Math.Segment3& segment0, Dest.Math.Segment3& segment1)
  RVA=0x056FCC58  token=0x60000B0  System.Single Segment3Segment3(Dest.Math.Segment3& segment0, Dest.Math.Segment3& segment1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
  RVA=0x05702A0C  token=0x60000B1  System.Single SqrSegment3Segment3(Dest.Math.Segment3& segment0, Dest.Math.Segment3& segment1)
  RVA=0x05702A40  token=0x60000B2  System.Single SqrSegment3Segment3(Dest.Math.Segment3& segment0, Dest.Math.Segment3& segment1, UnityEngine.Vector3& closestPoint0, UnityEngine.Vector3& closestPoint1)
END_CLASS

CLASS: Dest.Math.Line3Box3Dist
TYPE:  sealed struct
TOKEN: 0x2000012
SIZE:  0x2C
FIELDS:
  public            UnityEngine.Vector3             ClosestPoint0  // 0x10
  public            UnityEngine.Vector3             ClosestPoint1  // 0x1c
  public            System.Single                   LineParameter  // 0x28
METHODS:
END_CLASS

CLASS: Dest.Math.Intersection
TYPE:  static class
TOKEN: 0x2000013
SIZE:  0x10
FIELDS:
  private   static  System.Single                   _intervalThreshold  // static @ 0x0
  private   static  System.Single                   _dotThreshold  // static @ 0x4
  private   static  System.Single                   _distanceThreshold  // static @ 0x8
PROPERTIES:
  IntervalThreshold  get=0x05716E88  set=0x05717008
  DotThreshold  get=0x05716E38  set=0x05716F70
  DistanceThreshold  get=0x05716DE8  set=0x05716ED8
METHODS:
  RVA=0x0570F998  token=0x60000B3  System.Boolean TestAAB2AAB2(Dest.Math.AAB2& box0, Dest.Math.AAB2& box1)
  RVA=0x0570636C  token=0x60000B4  System.Boolean FindAAB2AAB2(Dest.Math.AAB2& box0, Dest.Math.AAB2& box1, Dest.Math.AAB2& intersection)
  RVA=0x0570F960  token=0x60000B5  System.Boolean TestAAB2AAB2OverlapX(Dest.Math.AAB2& box0, Dest.Math.AAB2& box1)
  RVA=0x0570F97C  token=0x60000B6  System.Boolean TestAAB2AAB2OverlapY(Dest.Math.AAB2& box0, Dest.Math.AAB2& box1)
  RVA=0x02EE72E0  token=0x60000B7  System.Boolean TestAAB2Circle2(Dest.Math.AAB2& box, Dest.Math.Circle2& circle)
  RVA=0x0570FA64  token=0x60000B8  System.Boolean TestBox2Box2(Dest.Math.Box2& box0, Dest.Math.Box2& box1)
  RVA=0x0570FD34  token=0x60000B9  System.Boolean TestBox2Circle2(Dest.Math.Box2& box, Dest.Math.Circle2& circle)
  RVA=0x05710098  token=0x60000BA  System.Boolean TestCircle2Circle2(Dest.Math.Circle2& circle0, Dest.Math.Circle2& circle1)
  RVA=0x057064E4  token=0x60000BB  System.Boolean FindCircle2Circle2(Dest.Math.Circle2& circle0, Dest.Math.Circle2& circle1, Dest.Math.Circle2Circle2Intr& info)
  RVA=0x05716AE4  token=0x60000BC  System.Int32 WhichSide(Dest.Math.Polygon2 V, UnityEngine.Vector2 P, UnityEngine.Vector2& D)
  RVA=0x057100E8  token=0x60000BD  System.Boolean TestConvexPolygon2ConvexPolygon2(Dest.Math.Polygon2 convexPolygon0, Dest.Math.Polygon2 convexPolygon1)
  RVA=0x0570608C  token=0x60000BE  System.Boolean DoClipping(System.Single t0, System.Single t1, UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, Dest.Math.AAB2& box, System.Boolean solid, System.Int32& quantity, UnityEngine.Vector2& point0, UnityEngine.Vector2& point1, Dest.Math.IntersectionTypes& intrType)
  RVA=0x057102E0  token=0x60000BF  System.Boolean TestLine2AAB2(Dest.Math.Line2& line, Dest.Math.AAB2& box)
  RVA=0x0570673C  token=0x60000C0  System.Boolean FindLine2AAB2(Dest.Math.Line2& line, Dest.Math.AAB2& box, Dest.Math.Line2AAB2Intr& info)
  RVA=0x05704F40  token=0x60000C1  System.Boolean Clip(System.Single denom, System.Single numer, System.Single& t0, System.Single& t1)
  RVA=0x05705730  token=0x60000C2  System.Boolean DoClipping(System.Single t0, System.Single t1, UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, Dest.Math.Box2& box, System.Boolean solid, System.Int32& quantity, UnityEngine.Vector2& point0, UnityEngine.Vector2& point1, Dest.Math.IntersectionTypes& intrType)
  RVA=0x05710438  token=0x60000C3  System.Boolean TestLine2Box2(Dest.Math.Line2& line, Dest.Math.Box2& box)
  RVA=0x057067D8  token=0x60000C4  System.Boolean FindLine2Box2(Dest.Math.Line2& line, Dest.Math.Box2& box, Dest.Math.Line2Box2Intr& info)
  RVA=0x0570E714  token=0x60000C5  System.Boolean Find(UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, UnityEngine.Vector2& center, System.Single radius, System.Int32& rootCount, System.Single& t0, System.Single& t1)
  RVA=0x05710528  token=0x60000C6  System.Boolean TestLine2Circle2(Dest.Math.Line2& line, Dest.Math.Circle2& circle)
  RVA=0x05706874  token=0x60000C7  System.Boolean FindLine2Circle2(Dest.Math.Line2& line, Dest.Math.Circle2& circle, Dest.Math.Line2Circle2Intr& info)
  RVA=0x057105B0  token=0x60000C8  System.Boolean TestLine2ConvexPolygon2(Dest.Math.Line2& line, Dest.Math.Polygon2 convexPolygon)
  RVA=0x05706A20  token=0x60000C9  System.Boolean FindLine2ConvexPolygon2(Dest.Math.Line2& line, Dest.Math.Polygon2 convexPolygon, Dest.Math.Line2ConvexPolygon2Intr& info)
  RVA=0x05703B50  token=0x60000CA  Dest.Math.IntersectionTypes Classify(Dest.Math.Line2& line0, Dest.Math.Line2& line1, System.Single& s0)
  RVA=0x05710718  token=0x60000CB  System.Boolean TestLine2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x057106BC  token=0x60000CC  System.Boolean TestLine2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1)
  RVA=0x05706D6C  token=0x60000CD  System.Boolean FindLine2Line2(Dest.Math.Line2& line0, Dest.Math.Line2& line1, Dest.Math.Line2Line2Intr& info)
  RVA=0x0570429C  token=0x60000CE  Dest.Math.IntersectionTypes Classify(Dest.Math.Line2& line, Dest.Math.Ray2& ray, System.Single& s0, System.Single& s1)
  RVA=0x057107E4  token=0x60000CF  System.Boolean TestLine2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x05710788  token=0x60000D0  System.Boolean TestLine2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray)
  RVA=0x05706E40  token=0x60000D1  System.Boolean FindLine2Ray2(Dest.Math.Line2& line, Dest.Math.Ray2& ray, Dest.Math.Line2Ray2Intr& info)
  RVA=0x057044A4  token=0x60000D2  Dest.Math.IntersectionTypes Classify(Dest.Math.Segment2& segment, Dest.Math.Line2& line, System.Single& s0, System.Single& s1)
  RVA=0x057108F8  token=0x60000D3  System.Boolean TestLine2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x0571089C  token=0x60000D4  System.Boolean TestLine2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment)
  RVA=0x05706F80  token=0x60000D5  System.Boolean FindLine2Segment2(Dest.Math.Line2& line, Dest.Math.Segment2& segment, Dest.Math.Line2Segment2Intr& info)
  RVA=0x0571664C  token=0x60000D6  System.Void TriangleLineRelations(UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, Dest.Math.Triangle2& triangle, System.Single& dist0, System.Single& dist1, System.Single& dist2, System.Int32& sign0, System.Int32& sign1, System.Int32& sign2, System.Int32& positive, System.Int32& negative, System.Int32& zero)
  RVA=0x0570EE84  token=0x60000D7  System.Boolean GetInterval(UnityEngine.Vector2& origin, UnityEngine.Vector2& direction, Dest.Math.Triangle2& triangle, System.Single dist0, System.Single dist1, System.Single dist2, System.Int32 sign0, System.Int32 sign1, System.Int32 sign2, System.Single& param0, System.Single& param1)
  RVA=0x05710994  token=0x60000D8  System.Boolean TestLine2Triangle2(Dest.Math.Line2& line, Dest.Math.Triangle2& triangle, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x05710B5C  token=0x60000D9  System.Boolean TestLine2Triangle2(Dest.Math.Line2& line, Dest.Math.Triangle2& triangle)
  RVA=0x057070A4  token=0x60000DA  System.Boolean FindLine2Triangle2(Dest.Math.Line2& line, Dest.Math.Triangle2& triangle, Dest.Math.Line2Triangle2Intr& info)
  RVA=0x05711EE0  token=0x60000DB  System.Boolean TestRay2AAB2(Dest.Math.Ray2& ray, Dest.Math.AAB2& box)
  RVA=0x05708FD8  token=0x60000DC  System.Boolean FindRay2AAB2(Dest.Math.Ray2& ray, Dest.Math.AAB2& box, Dest.Math.Ray2AAB2Intr& info)
  RVA=0x05712008  token=0x60000DD  System.Boolean TestRay2Box2(Dest.Math.Ray2& ray, Dest.Math.Box2& box)
  RVA=0x05709070  token=0x60000DE  System.Boolean FindRay2Box2(Dest.Math.Ray2& ray, Dest.Math.Box2& box, Dest.Math.Ray2Box2Intr& info)
  RVA=0x057121F4  token=0x60000DF  System.Boolean TestRay2Circle2(Dest.Math.Ray2& ray, Dest.Math.Circle2& circle)
  RVA=0x05709108  token=0x60000E0  System.Boolean FindRay2Circle2(Dest.Math.Ray2& ray, Dest.Math.Circle2& circle, Dest.Math.Ray2Circle2Intr& info)
  RVA=0x05712288  token=0x60000E1  System.Boolean TestRay2ConvexPolygon2(Dest.Math.Ray2& ray, Dest.Math.Polygon2 convexPolygon)
  RVA=0x057092E4  token=0x60000E2  System.Boolean FindRay2ConvexPolygon2(Dest.Math.Ray2& ray, Dest.Math.Polygon2 convexPolygon, Dest.Math.Ray2ConvexPolygon2Intr& info)
  RVA=0x05712394  token=0x60000E3  System.Boolean TestRay2Polygon2(Dest.Math.Ray2& ray, Dest.Math.Polygon2 polygon)
  RVA=0x057124A0  token=0x60000E4  System.Boolean TestRay2Polygon2(Dest.Math.Ray2& ray, Dest.Math.Segment2[] segments)
  RVA=0x057097A8  token=0x60000E5  System.Boolean FindRay2Polygon2(Dest.Math.Ray2& ray, Dest.Math.Polygon2 polygon, Dest.Math.Ray2Polygon2Intr& info)
  RVA=0x0570962C  token=0x60000E6  System.Boolean FindRay2Polygon2(Dest.Math.Ray2& ray, Dest.Math.Segment2[] segments, Dest.Math.Ray2Polygon2Intr& info)
  RVA=0x0570390C  token=0x60000E7  Dest.Math.IntersectionTypes Classify(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1, System.Single& s0, System.Single& s1)
  RVA=0x05712540  token=0x60000E8  System.Boolean TestRay2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x0571269C  token=0x60000E9  System.Boolean TestRay2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1)
  RVA=0x057099A0  token=0x60000EA  System.Boolean FindRay2Ray2(Dest.Math.Ray2& ray0, Dest.Math.Ray2& ray1, Dest.Math.Ray2Ray2Intr& info)
  RVA=0x05703FF0  token=0x60000EB  Dest.Math.IntersectionTypes Classify(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment, System.Single& s0, System.Single& s1)
  RVA=0x05712754  token=0x60000EC  System.Boolean TestRay2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x057126F8  token=0x60000ED  System.Boolean TestRay2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment)
  RVA=0x05709BA4  token=0x60000EE  System.Boolean FindRay2Segment2(Dest.Math.Ray2& ray, Dest.Math.Segment2& segment, Dest.Math.Ray2Segment2Intr& info)
  RVA=0x057128A0  token=0x60000EF  System.Boolean TestRay2Triangle2(Dest.Math.Ray2& ray, Dest.Math.Triangle2& triangle, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x05712A64  token=0x60000F0  System.Boolean TestRay2Triangle2(Dest.Math.Ray2& ray, Dest.Math.Triangle2& triangle)
  RVA=0x05709DB4  token=0x60000F1  System.Boolean FindRay2Triangle2(Dest.Math.Ray2& ray, Dest.Math.Triangle2& triangle, Dest.Math.Ray2Triangle2Intr& info)
  RVA=0x05713B2C  token=0x60000F2  System.Boolean TestSegment2AAB2(Dest.Math.Segment2& segment, Dest.Math.AAB2& box)
  RVA=0x0570B558  token=0x60000F3  System.Boolean FindSegment2AAB2(Dest.Math.Segment2& segment, Dest.Math.AAB2& box, Dest.Math.Segment2AAB2Intr& info)
  RVA=0x05713C6C  token=0x60000F4  System.Boolean TestSegment2Box2(Dest.Math.Segment2& segment, Dest.Math.Box2& box)
  RVA=0x0570B618  token=0x60000F5  System.Boolean FindSegment2Box2(Dest.Math.Segment2& segment, Dest.Math.Box2& box, Dest.Math.Segment2Box2Intr& info)
  RVA=0x05713E6C  token=0x60000F6  System.Boolean TestSegment2Circle2(Dest.Math.Segment2& segment, Dest.Math.Circle2& circle)
  RVA=0x0570B6D8  token=0x60000F7  System.Boolean FindSegment2Circle2(Dest.Math.Segment2& segment, Dest.Math.Circle2& circle, Dest.Math.Segment2Circle2Intr& info)
  RVA=0x05713F40  token=0x60000F8  System.Boolean TestSegment2ConvexPolygon2(Dest.Math.Segment2& segment, Dest.Math.Polygon2 convexPolygon)
  RVA=0x0570B940  token=0x60000F9  System.Boolean FindSegment2ConvexPolygon2(Dest.Math.Segment2& segment, Dest.Math.Polygon2 convexPolygon, Dest.Math.Segment2ConvexPolygon2Intr& info)
  RVA=0x05703D18  token=0x60000FA  Dest.Math.IntersectionTypes Classify(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1, System.Single& s0, System.Single& s1)
  RVA=0x05714000  token=0x60000FB  System.Boolean TestSegment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x05713FA4  token=0x60000FC  System.Boolean TestSegment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1)
  RVA=0x0570BC84  token=0x60000FD  System.Boolean FindSegment2Segment2(Dest.Math.Segment2& segment0, Dest.Math.Segment2& segment1, Dest.Math.Segment2Segment2Intr& info)
  RVA=0x057141C0  token=0x60000FE  System.Boolean TestSegment2Triangle2(Dest.Math.Segment2& segment, Dest.Math.Triangle2& triangle, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x05714164  token=0x60000FF  System.Boolean TestSegment2Triangle2(Dest.Math.Segment2& segment, Dest.Math.Triangle2& triangle)
  RVA=0x0570BFA0  token=0x6000100  System.Boolean FindSegment2Triangle2(Dest.Math.Segment2& segment, Dest.Math.Triangle2& triangle, Dest.Math.Segment2Triangle2Intr& info)
  RVA=0x05716C14  token=0x6000101  System.Int32 WhichSide(Dest.Math.Triangle2& triangle, UnityEngine.Vector2& P, UnityEngine.Vector2& D)
  RVA=0x057046BC  token=0x6000102  System.Void ClipConvexPolygonAgainstLine(UnityEngine.Vector2& edgeStart, UnityEngine.Vector2& edgeEnd, System.Int32& quantity, Dest.Math.Triangle2Triangle2Intr& info)
  RVA=0x057154F0  token=0x6000103  System.Boolean TestTriangle2Triangle2(Dest.Math.Triangle2& triangle0, Dest.Math.Triangle2& triangle1)
  RVA=0x0570DCD4  token=0x6000104  System.Boolean FindTriangle2Triangle2(Dest.Math.Triangle2& triangle0, Dest.Math.Triangle2& triangle1, Dest.Math.Triangle2Triangle2Intr& info)
  RVA=0x0570FA1C  token=0x6000105  System.Boolean TestAAB3AAB3(Dest.Math.AAB3& box0, Dest.Math.AAB3& box1)
  RVA=0x057063F8  token=0x6000106  System.Boolean FindAAB3AAB3(Dest.Math.AAB3& box0, Dest.Math.AAB3& box1, Dest.Math.AAB3& intersection)
  RVA=0x0570F9C8  token=0x6000107  System.Boolean TestAAB3AAB3OverlapX(Dest.Math.AAB3& box0, Dest.Math.AAB3& box1)
  RVA=0x0570F9E4  token=0x6000108  System.Boolean TestAAB3AAB3OverlapY(Dest.Math.AAB3& box0, Dest.Math.AAB3& box1)
  RVA=0x0570FA00  token=0x6000109  System.Boolean TestAAB3AAB3OverlapZ(Dest.Math.AAB3& box0, Dest.Math.AAB3& box1)
  RVA=0x0294A0B0  token=0x600010A  System.Boolean TestAAB3Sphere3(Dest.Math.AAB3& box, Dest.Math.Sphere3& sphere)
  RVA=0x02A5CC80  token=0x600010B  System.Boolean TestBox3Box3(Dest.Math.Box3& box0, Dest.Math.Box3& box1)
  RVA=0x0570FE6C  token=0x600010C  System.Boolean TestBox3Capsule3(Dest.Math.Box3& box, Dest.Math.Capsule3& capsule)
  RVA=0x0570FE94  token=0x600010D  System.Boolean TestBox3Sphere3(Dest.Math.Box3& box, Dest.Math.Sphere3& sphere)
  RVA=0x057052E0  token=0x600010E  System.Boolean DoClipping(System.Single t0, System.Single t1, UnityEngine.Vector3& origin, UnityEngine.Vector3& direction, Dest.Math.AAB3& box, System.Boolean solid, System.Int32& quantity, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, Dest.Math.IntersectionTypes& intrType)
  RVA=0x05710BB8  token=0x600010F  System.Boolean TestLine3AAB3(Dest.Math.Line3& line, Dest.Math.AAB3& box)
  RVA=0x05707344  token=0x6000110  System.Boolean FindLine3AAB3(Dest.Math.Line3& line, Dest.Math.AAB3& box, Dest.Math.Line3AAB3Intr& info)
  RVA=0x05705A94  token=0x6000111  System.Boolean DoClipping(System.Single t0, System.Single t1, UnityEngine.Vector3& origin, UnityEngine.Vector3& direction, Dest.Math.Box3& box, System.Boolean solid, System.Int32& quantity, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, Dest.Math.IntersectionTypes& intrType)
  RVA=0x05710D54  token=0x6000112  System.Boolean TestLine3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box)
  RVA=0x057073E0  token=0x6000113  System.Boolean FindLine3Box3(Dest.Math.Line3& line, Dest.Math.Box3& box, Dest.Math.Line3Box3Intr& info)
  RVA=0x05711014  token=0x6000114  System.Boolean TestLine3Circle3(Dest.Math.Line3& line, Dest.Math.Circle3& circle)
  RVA=0x0570747C  token=0x6000115  System.Boolean FindLine3Circle3(Dest.Math.Line3& line, Dest.Math.Circle3& circle, Dest.Math.Line3Circle3Intr& info)
  RVA=0x05711074  token=0x6000116  System.Boolean TestLine3Plane3(Dest.Math.Line3& line, Dest.Math.Plane3& plane, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x057111AC  token=0x6000117  System.Boolean TestLine3Plane3(Dest.Math.Line3& line, Dest.Math.Plane3& plane)
  RVA=0x05707690  token=0x6000118  System.Boolean FindLine3Plane3(Dest.Math.Line3& line, Dest.Math.Plane3& plane, Dest.Math.Line3Plane3Intr& info)
  RVA=0x05711208  token=0x6000119  System.Boolean TestLine3Polygon3(Dest.Math.Line3& line, Dest.Math.Polygon3 polygon)
  RVA=0x05707810  token=0x600011A  System.Boolean FindLine3Polygon3(Dest.Math.Line3& line, Dest.Math.Polygon3 polygon, Dest.Math.Line3Polygon3Intr& info)
  RVA=0x0570F5A0  token=0x600011B  System.Boolean Point3InsideRectangle3(UnityEngine.Vector3& point, Dest.Math.Rectangle3& rectangle)
  RVA=0x05711268  token=0x600011C  System.Boolean TestLine3Rectangle3(Dest.Math.Line3& line, Dest.Math.Rectangle3& rectangle)
  RVA=0x057079F0  token=0x600011D  System.Boolean FindLine3Rectangle3(Dest.Math.Line3& line, Dest.Math.Rectangle3& rectangle, Dest.Math.Line3Rectangle3Intr& info)
  RVA=0x057112C8  token=0x600011E  System.Boolean TestLine3Sphere3(Dest.Math.Line3& line, Dest.Math.Sphere3& sphere)
  RVA=0x05707BD8  token=0x600011F  System.Boolean FindLine3Sphere3(Dest.Math.Line3& line, Dest.Math.Sphere3& sphere, Dest.Math.Line3Sphere3Intr& info)
  RVA=0x05711740  token=0x6000120  System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, Dest.Math.Triangle3& triangle, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x0571167C  token=0x6000121  System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x057114F8  token=0x6000122  System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x057113DC  token=0x6000123  System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, Dest.Math.Triangle3& triangle)
  RVA=0x057115BC  token=0x6000124  System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2)
  RVA=0x05711438  token=0x6000125  System.Boolean TestLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  RVA=0x05708058  token=0x6000126  System.Boolean FindLine3Triangle3(Dest.Math.Line3& line, Dest.Math.Triangle3& triangle, Dest.Math.Line3Triangle3Intr& info)
  RVA=0x05707ED0  token=0x6000127  System.Boolean FindLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.Line3Triangle3Intr& info)
  RVA=0x05707F94  token=0x6000128  System.Boolean FindLine3Triangle3(Dest.Math.Line3& line, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.Line3Triangle3Intr& info)
  RVA=0x05711A70  token=0x6000129  System.Boolean TestPlane3AAB3(Dest.Math.Plane3& plane, Dest.Math.AAB3& box)
  RVA=0x05711B40  token=0x600012A  System.Boolean TestPlane3Box3(Dest.Math.Plane3& plane, Dest.Math.Box3& box)
  RVA=0x05711CAC  token=0x600012B  System.Boolean TestPlane3Plane3(Dest.Math.Plane3& plane0, Dest.Math.Plane3& plane1)
  RVA=0x05708460  token=0x600012C  System.Boolean FindPlane3Plane3(Dest.Math.Plane3& plane0, Dest.Math.Plane3& plane1, Dest.Math.Plane3Plane3Intr& info)
  RVA=0x05711D4C  token=0x600012D  System.Boolean TestPlane3Sphere3(Dest.Math.Plane3& plane, Dest.Math.Sphere3& sphere)
  RVA=0x0570869C  token=0x600012E  System.Boolean FindPlane3Sphere3(Dest.Math.Plane3& plane, Dest.Math.Sphere3& sphere, Dest.Math.Plane3Sphere3Intr& info)
  RVA=0x05711D80  token=0x600012F  System.Boolean TestPlane3Triangle3(Dest.Math.Plane3& plane, Dest.Math.Triangle3& triangle)
  RVA=0x0570881C  token=0x6000130  System.Boolean FindPlane3Triangle3(Dest.Math.Plane3& plane, Dest.Math.Triangle3& triangle, Dest.Math.Plane3Triangle3Intr& info)
  RVA=0x05712AC0  token=0x6000131  System.Boolean TestRay3AAB3(Dest.Math.Ray3& ray, Dest.Math.AAB3& box)
  RVA=0x0570A050  token=0x6000132  System.Boolean FindRay3AAB3(Dest.Math.Ray3& ray, Dest.Math.AAB3& box, Dest.Math.Ray3AAB3Intr& info)
  RVA=0x05712D0C  token=0x6000133  System.Boolean TestRay3Box3(Dest.Math.Ray3& ray, Dest.Math.Box3& box)
  RVA=0x0570A0E8  token=0x6000134  System.Boolean FindRay3Box3(Dest.Math.Ray3& ray, Dest.Math.Box3& box, Dest.Math.Ray3Box3Intr& info)
  RVA=0x057130D4  token=0x6000135  System.Boolean TestRay3Circle3(Dest.Math.Ray3& ray, Dest.Math.Circle3& circle)
  RVA=0x0570A180  token=0x6000136  System.Boolean FindRay3Circle3(Dest.Math.Ray3& ray, Dest.Math.Circle3& circle, Dest.Math.Ray3Circle3Intr& info)
  RVA=0x05713198  token=0x6000137  System.Boolean TestRay3Plane3(Dest.Math.Ray3& ray, Dest.Math.Plane3& plane, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x05713134  token=0x6000138  System.Boolean TestRay3Plane3(Dest.Math.Ray3& ray, Dest.Math.Plane3& plane)
  RVA=0x0570A408  token=0x6000139  System.Boolean FindRay3Plane3(Dest.Math.Ray3& ray, Dest.Math.Plane3& plane, Dest.Math.Ray3Plane3Intr& info)
  RVA=0x05713210  token=0x600013A  System.Boolean TestRay3Polygon3(Dest.Math.Ray3& ray, Dest.Math.Polygon3 polygon)
  RVA=0x0570A60C  token=0x600013B  System.Boolean FindRay3Polygon3(Dest.Math.Ray3& ray, Dest.Math.Polygon3 polygon, Dest.Math.Ray3Polygon3Intr& info)
  RVA=0x05713270  token=0x600013C  System.Boolean TestRay3Rectangle3(Dest.Math.Ray3& ray, Dest.Math.Rectangle3& rectangle)
  RVA=0x0570A864  token=0x600013D  System.Boolean FindRay3Rectangle3(Dest.Math.Ray3& ray, Dest.Math.Rectangle3& rectangle, Dest.Math.Ray3Rectangle3Intr& info)
  RVA=0x057132D0  token=0x600013E  System.Boolean TestRay3Sphere3(Dest.Math.Ray3& ray, Dest.Math.Sphere3& sphere)
  RVA=0x0570AAB8  token=0x600013F  System.Boolean FindRay3Sphere3(Dest.Math.Ray3& ray, Dest.Math.Sphere3& sphere, Dest.Math.Ray3Sphere3Intr& info)
  RVA=0x0571377C  token=0x6000140  System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, Dest.Math.Triangle3& triangle, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x05713418  token=0x6000141  System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x057134DC  token=0x6000142  System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x05713660  token=0x6000143  System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, Dest.Math.Triangle3& triangle)
  RVA=0x057136BC  token=0x6000144  System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2)
  RVA=0x057135A0  token=0x6000145  System.Boolean TestRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  RVA=0x0570AF48  token=0x6000146  System.Boolean FindRay3Triangle3(Dest.Math.Ray3& ray, Dest.Math.Triangle3& triangle, Dest.Math.Ray3Triangle3Intr& info)
  RVA=0x0570AE84  token=0x6000147  System.Boolean FindRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.Ray3Triangle3Intr& info)
  RVA=0x0570B380  token=0x6000148  System.Boolean FindRay3Triangle3(Dest.Math.Ray3& ray, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.Ray3Triangle3Intr& info)
  RVA=0x057143A8  token=0x6000149  System.Boolean TestSegment3AAB3(Dest.Math.Segment3& segment, Dest.Math.AAB3& box)
  RVA=0x0570C2B0  token=0x600014A  System.Boolean FindSegment3AAB3(Dest.Math.Segment3& segment, Dest.Math.AAB3& box, Dest.Math.Segment3AAB3Intr& info)
  RVA=0x057145F4  token=0x600014B  System.Boolean TestSegment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box)
  RVA=0x0570C370  token=0x600014C  System.Boolean FindSegment3Box3(Dest.Math.Segment3& segment, Dest.Math.Box3& box, Dest.Math.Segment3Box3Intr& info)
  RVA=0x057149A8  token=0x600014D  System.Boolean TestSegment3Circle3(Dest.Math.Segment3& segment, Dest.Math.Circle3& circle)
  RVA=0x0570C430  token=0x600014E  System.Boolean FindSegment3Circle3(Dest.Math.Segment3& segment, Dest.Math.Circle3& circle, Dest.Math.Segment3Circle3Intr& info)
  RVA=0x05714A64  token=0x600014F  System.Boolean TestSegment3Plane3(Dest.Math.Segment3& segment, Dest.Math.Plane3& plane, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x05714A08  token=0x6000150  System.Boolean TestSegment3Plane3(Dest.Math.Segment3& segment, Dest.Math.Plane3& plane)
  RVA=0x0570C6C0  token=0x6000151  System.Boolean FindSegment3Plane3(Dest.Math.Segment3& segment, Dest.Math.Plane3& plane, Dest.Math.Segment3Plane3Intr& info)
  RVA=0x05714BB0  token=0x6000152  System.Boolean TestSegment3Polygon3(Dest.Math.Segment3& segment, Dest.Math.Polygon3 polygon)
  RVA=0x0570C8F8  token=0x6000153  System.Boolean FindSegment3Polygon3(Dest.Math.Segment3& segment, Dest.Math.Polygon3 polygon, Dest.Math.Segment3Polygon3Intr& info)
  RVA=0x05714C10  token=0x6000154  System.Boolean TestSegment3Rectangle3(Dest.Math.Segment3& segment, Dest.Math.Rectangle3& rectangle)
  RVA=0x0570CB4C  token=0x6000155  System.Boolean FindSegment3Rectangle3(Dest.Math.Segment3& segment, Dest.Math.Rectangle3& rectangle, Dest.Math.Segment3Rectangle3Intr& info)
  RVA=0x05714C70  token=0x6000156  System.Boolean TestSegment3Sphere3(Dest.Math.Segment3& segment, Dest.Math.Sphere3& sphere)
  RVA=0x0570CDAC  token=0x6000157  System.Boolean FindSegment3Sphere3(Dest.Math.Segment3& segment, Dest.Math.Sphere3& sphere, Dest.Math.Segment3Sphere3Intr& info)
  RVA=0x057150EC  token=0x6000158  System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, Dest.Math.Triangle3& triangle, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x05715028  token=0x6000159  System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x05714EA4  token=0x600015A  System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x05715494  token=0x600015B  System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, Dest.Math.Triangle3& triangle)
  RVA=0x05714F68  token=0x600015C  System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2)
  RVA=0x05714DE4  token=0x600015D  System.Boolean TestSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  RVA=0x0570D2DC  token=0x600015E  System.Boolean FindSegment3Triangle3(Dest.Math.Segment3& segment, Dest.Math.Triangle3& triangle, Dest.Math.Segment3Triangle3Intr& info)
  RVA=0x0570D764  token=0x600015F  System.Boolean FindSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, Dest.Math.Segment3Triangle3Intr& info)
  RVA=0x0570D218  token=0x6000160  System.Boolean FindSegment3Triangle3(Dest.Math.Segment3& segment, UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.Segment3Triangle3Intr& info)
  RVA=0x03496D10  token=0x6000161  System.Boolean TestSphere3Sphere3(Dest.Math.Sphere3& sphere0, Dest.Math.Sphere3& sphere1)
  RVA=0x0570D828  token=0x6000162  System.Boolean FindSphere3Sphere3(Dest.Math.Sphere3& sphere0, Dest.Math.Sphere3& sphere1, Dest.Math.Sphere3Sphere3Intr& info)
  RVA=0x0570F6CC  token=0x6000163  System.Void ProjectOntoAxis(Dest.Math.Triangle3& triangle, UnityEngine.Vector3& axis, System.Single& fmin, System.Single& fmax)
  RVA=0x05716988  token=0x6000164  System.Void TrianglePlaneRelations(Dest.Math.Triangle3& triangle, Dest.Math.Plane3& plane, System.Single& dist0, System.Single& dist1, System.Single& dist2, System.Int32& sign0, System.Int32& sign1, System.Int32& sign2, System.Int32& positive, System.Int32& negative, System.Int32& zero)
  RVA=0x057168D4  token=0x6000165  System.Boolean TrianglePlaneRelationsQuick(Dest.Math.Triangle3& triangle, Dest.Math.Plane3& plane)
  RVA=0x0570F0F0  token=0x6000166  System.Boolean IntersectsSegment(Dest.Math.Plane3& plane, Dest.Math.Triangle3& triangle, UnityEngine.Vector3& end0, UnityEngine.Vector3& end1, System.Boolean grazing, Dest.Math.Triangle3Triangle3Intr& info)
  RVA=0x0570F830  token=0x6000167  System.Int32 QueryToLine(UnityEngine.Vector2& test, UnityEngine.Vector2& vec0, UnityEngine.Vector2& vec1)
  RVA=0x0570F884  token=0x6000168  System.Int32 QueryToTriangle(UnityEngine.Vector2& test, UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2)
  RVA=0x05704FA0  token=0x6000169  System.Boolean ContainsPoint(Dest.Math.Triangle3& triangle, Dest.Math.Plane3& plane, UnityEngine.Vector3& point, Dest.Math.Triangle3Triangle3Intr& info)
  RVA=0x0570E86C  token=0x600016A  System.Boolean GetCoplanarIntersection(Dest.Math.Plane3& plane, Dest.Math.Triangle3& tri0, Dest.Math.Triangle3& tri1, Dest.Math.Triangle3Triangle3Intr& info)
  RVA=0x0571573C  token=0x600016B  System.Boolean TestTriangle3Triangle3(Dest.Math.Triangle3& triangle0, Dest.Math.Triangle3& triangle1, Dest.Math.IntersectionTypes& intersectionType)
  RVA=0x057165F0  token=0x600016C  System.Boolean TestTriangle3Triangle3(Dest.Math.Triangle3& triangle0, Dest.Math.Triangle3& triangle1)
  RVA=0x0570DE1C  token=0x600016D  System.Boolean FindTriangle3Triangle3(Dest.Math.Triangle3& triangle0, Dest.Math.Triangle3& triangle1, Dest.Math.Triangle3Triangle3Intr& info, System.Boolean reportCoplanarIntersections)
  RVA=0x03D20950  token=0x6000174  System.Void .cctor()
  RVA=0x0570B444  token=0x6000175  System.Int32 FindSegment1Segment1(System.Single seg0Start, System.Single seg0End, System.Single seg1Start, System.Single seg1End, System.Single& w0, System.Single& w1)
END_CLASS

CLASS: Dest.Math.Circle2Circle2Intr
TYPE:  sealed struct
TOKEN: 0x2000014
SIZE:  0x28
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Line2AAB2Intr
TYPE:  sealed struct
TOKEN: 0x2000015
SIZE:  0x28
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Line2Box2Intr
TYPE:  sealed struct
TOKEN: 0x2000016
SIZE:  0x28
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Line2Circle2Intr
TYPE:  sealed struct
TOKEN: 0x2000017
SIZE:  0x24
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point0  // 0x14
  public            UnityEngine.Vector2             Point1  // 0x1c
METHODS:
END_CLASS

CLASS: Dest.Math.Line2ConvexPolygon2Intr
TYPE:  sealed struct
TOKEN: 0x2000018
SIZE:  0x30
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
  public            System.Single                   Parameter0  // 0x28
  public            System.Single                   Parameter1  // 0x2c
METHODS:
END_CLASS

CLASS: Dest.Math.Line2Line2Intr
TYPE:  sealed struct
TOKEN: 0x2000019
SIZE:  0x20
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point  // 0x14
  public            System.Single                   Parameter  // 0x1c
METHODS:
END_CLASS

CLASS: Dest.Math.Line2Ray2Intr
TYPE:  sealed struct
TOKEN: 0x200001A
SIZE:  0x20
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point  // 0x14
  public            System.Single                   Parameter  // 0x1c
METHODS:
END_CLASS

CLASS: Dest.Math.Line2Segment2Intr
TYPE:  sealed struct
TOKEN: 0x200001B
SIZE:  0x20
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point  // 0x14
  public            System.Single                   Parameter  // 0x1c
METHODS:
END_CLASS

CLASS: Dest.Math.Line2Triangle2Intr
TYPE:  sealed struct
TOKEN: 0x200001C
SIZE:  0x28
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Ray2AAB2Intr
TYPE:  sealed struct
TOKEN: 0x200001D
SIZE:  0x28
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Ray2Box2Intr
TYPE:  sealed struct
TOKEN: 0x200001E
SIZE:  0x28
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Ray2Circle2Intr
TYPE:  sealed struct
TOKEN: 0x200001F
SIZE:  0x24
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point0  // 0x14
  public            UnityEngine.Vector2             Point1  // 0x1c
METHODS:
END_CLASS

CLASS: Dest.Math.Ray2ConvexPolygon2Intr
TYPE:  sealed struct
TOKEN: 0x2000020
SIZE:  0x30
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
  public            System.Single                   Parameter0  // 0x28
  public            System.Single                   Parameter1  // 0x2c
METHODS:
END_CLASS

CLASS: Dest.Math.Ray2Polygon2Intr
TYPE:  sealed struct
TOKEN: 0x2000021
SIZE:  0x2C
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point0  // 0x14
  public            UnityEngine.Vector2             Point1  // 0x1c
  public            System.Single                   Parameter0  // 0x24
  public            System.Single                   Parameter1  // 0x28
METHODS:
END_CLASS

CLASS: Dest.Math.Ray2Ray2Intr
TYPE:  sealed struct
TOKEN: 0x2000022
SIZE:  0x20
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point  // 0x14
  public            System.Single                   Parameter  // 0x1c
METHODS:
END_CLASS

CLASS: Dest.Math.Ray2Segment2Intr
TYPE:  sealed struct
TOKEN: 0x2000023
SIZE:  0x2C
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point0  // 0x14
  public            UnityEngine.Vector2             Point1  // 0x1c
  public            System.Single                   Parameter0  // 0x24
  public            System.Single                   Parameter1  // 0x28
METHODS:
END_CLASS

CLASS: Dest.Math.Ray2Triangle2Intr
TYPE:  sealed struct
TOKEN: 0x2000024
SIZE:  0x28
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Segment2AAB2Intr
TYPE:  sealed struct
TOKEN: 0x2000025
SIZE:  0x28
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Segment2Box2Intr
TYPE:  sealed struct
TOKEN: 0x2000026
SIZE:  0x28
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Segment2Circle2Intr
TYPE:  sealed struct
TOKEN: 0x2000027
SIZE:  0x24
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point0  // 0x14
  public            UnityEngine.Vector2             Point1  // 0x1c
METHODS:
END_CLASS

CLASS: Dest.Math.Segment2ConvexPolygon2Intr
TYPE:  sealed struct
TOKEN: 0x2000028
SIZE:  0x30
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
  public            System.Single                   Parameter0  // 0x28
  public            System.Single                   Parameter1  // 0x2c
METHODS:
END_CLASS

CLASS: Dest.Math.Segment2Segment2Intr
TYPE:  sealed struct
TOKEN: 0x2000029
SIZE:  0x2C
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector2             Point0  // 0x14
  public            UnityEngine.Vector2             Point1  // 0x1c
  public            System.Single                   Parameter0  // 0x24
  public            System.Single                   Parameter1  // 0x28
METHODS:
END_CLASS

CLASS: Dest.Math.Segment2Triangle2Intr
TYPE:  sealed struct
TOKEN: 0x200002A
SIZE:  0x28
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Triangle2Triangle2Intr
TYPE:  sealed struct
TOKEN: 0x200002B
SIZE:  0x48
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector2             Point0  // 0x18
  public            UnityEngine.Vector2             Point1  // 0x20
  public            UnityEngine.Vector2             Point2  // 0x28
  public            UnityEngine.Vector2             Point3  // 0x30
  public            UnityEngine.Vector2             Point4  // 0x38
  public            UnityEngine.Vector2             Point5  // 0x40
PROPERTIES:
  Item  get=0x0571CAF0  set=0x0571CB6C
METHODS:
END_CLASS

CLASS: Dest.Math.Float6
TYPE:  sealed struct
TOKEN: 0x200002C
SIZE:  0x28
FIELDS:
  private           System.Single                   _0  // 0x10
  private           System.Single                   _1  // 0x14
  private           System.Single                   _2  // 0x18
  private           System.Single                   _3  // 0x1c
  private           System.Single                   _4  // 0x20
  private           System.Single                   _5  // 0x24
PROPERTIES:
  Item  get=0x05717180  set=0x057171C4
METHODS:
END_CLASS

CLASS: Dest.Math.Line3AAB3Intr
TYPE:  sealed struct
TOKEN: 0x200002D
SIZE:  0x30
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
METHODS:
END_CLASS

CLASS: Dest.Math.Line3Box3Intr
TYPE:  sealed struct
TOKEN: 0x200002E
SIZE:  0x30
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
METHODS:
END_CLASS

CLASS: Dest.Math.Line3Circle3Intr
TYPE:  sealed struct
TOKEN: 0x200002F
SIZE:  0x20
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Line3Plane3Intr
TYPE:  sealed struct
TOKEN: 0x2000030
SIZE:  0x24
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
  public            System.Single                   LineParameter  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Line3Polygon3Intr
TYPE:  sealed struct
TOKEN: 0x2000031
SIZE:  0x20
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Line3Rectangle3Intr
TYPE:  sealed struct
TOKEN: 0x2000032
SIZE:  0x20
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Line3Sphere3Intr
TYPE:  sealed struct
TOKEN: 0x2000033
SIZE:  0x38
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
  public            System.Single                   LineParameter0  // 0x30
  public            System.Single                   LineParameter1  // 0x34
METHODS:
END_CLASS

CLASS: Dest.Math.Line3Triangle3Intr
TYPE:  sealed struct
TOKEN: 0x2000034
SIZE:  0x30
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
  public            System.Single                   LineParameter  // 0x20
  public            System.Single                   TriBary0  // 0x24
  public            System.Single                   TriBary1  // 0x28
  public            System.Single                   TriBary2  // 0x2c
METHODS:
END_CLASS

CLASS: Dest.Math.Plane3Plane3Intr
TYPE:  sealed struct
TOKEN: 0x2000035
SIZE:  0x2C
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            Dest.Math.Line3                 Line  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Plane3Sphere3Intr
TYPE:  sealed struct
TOKEN: 0x2000036
SIZE:  0x48
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            Dest.Math.Circle3               Circle  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Plane3Triangle3Intr
TYPE:  sealed struct
TOKEN: 0x2000037
SIZE:  0x3C
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
  public            UnityEngine.Vector3             Point2  // 0x30
METHODS:
END_CLASS

CLASS: Dest.Math.Ray3AAB3Intr
TYPE:  sealed struct
TOKEN: 0x2000038
SIZE:  0x30
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
METHODS:
END_CLASS

CLASS: Dest.Math.Ray3Box3Intr
TYPE:  sealed struct
TOKEN: 0x2000039
SIZE:  0x30
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
METHODS:
END_CLASS

CLASS: Dest.Math.Ray3Circle3Intr
TYPE:  sealed struct
TOKEN: 0x200003A
SIZE:  0x20
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Ray3Plane3Intr
TYPE:  sealed struct
TOKEN: 0x200003B
SIZE:  0x24
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
  public            System.Single                   RayParameter  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Ray3Polygon3Intr
TYPE:  sealed struct
TOKEN: 0x200003C
SIZE:  0x20
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Ray3Rectangle3Intr
TYPE:  sealed struct
TOKEN: 0x200003D
SIZE:  0x20
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Ray3Sphere3Intr
TYPE:  sealed struct
TOKEN: 0x200003E
SIZE:  0x38
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
  public            System.Single                   RayParameter0  // 0x30
  public            System.Single                   RayParameter1  // 0x34
METHODS:
END_CLASS

CLASS: Dest.Math.Ray3Triangle3Intr
TYPE:  sealed struct
TOKEN: 0x200003F
SIZE:  0x30
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
  public            System.Single                   RayParameter  // 0x20
  public            System.Single                   TriBary0  // 0x24
  public            System.Single                   TriBary1  // 0x28
  public            System.Single                   TriBary2  // 0x2c
METHODS:
END_CLASS

CLASS: Dest.Math.Segment3AAB3Intr
TYPE:  sealed struct
TOKEN: 0x2000040
SIZE:  0x30
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
METHODS:
END_CLASS

CLASS: Dest.Math.Segment3Box3Intr
TYPE:  sealed struct
TOKEN: 0x2000041
SIZE:  0x30
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
METHODS:
END_CLASS

CLASS: Dest.Math.Segment3Circle3Intr
TYPE:  sealed struct
TOKEN: 0x2000042
SIZE:  0x20
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Segment3Plane3Intr
TYPE:  sealed struct
TOKEN: 0x2000043
SIZE:  0x24
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
  public            System.Single                   SegmentParameter  // 0x20
METHODS:
END_CLASS

CLASS: Dest.Math.Segment3Polygon3Intr
TYPE:  sealed struct
TOKEN: 0x2000044
SIZE:  0x20
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Segment3Rectangle3Intr
TYPE:  sealed struct
TOKEN: 0x2000045
SIZE:  0x20
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
METHODS:
END_CLASS

CLASS: Dest.Math.Segment3Sphere3Intr
TYPE:  sealed struct
TOKEN: 0x2000046
SIZE:  0x38
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            System.Int32                    Quantity  // 0x14
  public            UnityEngine.Vector3             Point0  // 0x18
  public            UnityEngine.Vector3             Point1  // 0x24
  public            System.Single                   SegmentParameter0  // 0x30
  public            System.Single                   SegmentParameter1  // 0x34
METHODS:
END_CLASS

CLASS: Dest.Math.Segment3Triangle3Intr
TYPE:  sealed struct
TOKEN: 0x2000047
SIZE:  0x30
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            UnityEngine.Vector3             Point  // 0x14
  public            System.Single                   SegmentParameter  // 0x20
  public            System.Single                   TriBary0  // 0x24
  public            System.Single                   TriBary1  // 0x28
  public            System.Single                   TriBary2  // 0x2c
METHODS:
END_CLASS

CLASS: Dest.Math.Sphere3Sphere3IntrTypes
TYPE:  sealed struct
TOKEN: 0x2000048
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Dest.Math.Sphere3Sphere3IntrTypesEmpty  // const
  public    static  Dest.Math.Sphere3Sphere3IntrTypesPoint  // const
  public    static  Dest.Math.Sphere3Sphere3IntrTypesCircle  // const
  public    static  Dest.Math.Sphere3Sphere3IntrTypesSphere0  // const
  public    static  Dest.Math.Sphere3Sphere3IntrTypesSphere0Point  // const
  public    static  Dest.Math.Sphere3Sphere3IntrTypesSphere1  // const
  public    static  Dest.Math.Sphere3Sphere3IntrTypesSphere1Point  // const
  public    static  Dest.Math.Sphere3Sphere3IntrTypesSame  // const
METHODS:
END_CLASS

CLASS: Dest.Math.Sphere3Sphere3Intr
TYPE:  sealed struct
TOKEN: 0x2000049
SIZE:  0x54
FIELDS:
  public            Dest.Math.Sphere3Sphere3IntrTypesIntersectionType  // 0x10
  public            Dest.Math.Circle3               Circle  // 0x14
  public            UnityEngine.Vector3             ContactPoint  // 0x48
METHODS:
END_CLASS

CLASS: Dest.Math.Triangle3Triangle3Intr
TYPE:  sealed struct
TOKEN: 0x200004A
SIZE:  0x68
FIELDS:
  public            Dest.Math.IntersectionTypes     IntersectionType  // 0x10
  public            Dest.Math.IntersectionTypes     CoplanarIntersectionType  // 0x14
  public            System.Boolean                  Touching  // 0x18
  public            System.Int32                    Quantity  // 0x1c
  public            UnityEngine.Vector3             Point0  // 0x20
  public            UnityEngine.Vector3             Point1  // 0x2c
  public            UnityEngine.Vector3             Point2  // 0x38
  public            UnityEngine.Vector3             Point3  // 0x44
  public            UnityEngine.Vector3             Point4  // 0x50
  public            UnityEngine.Vector3             Point5  // 0x5c
PROPERTIES:
  Item  get=0x0571CBA8  set=0x0571CC38
METHODS:
END_CLASS

CLASS: Dest.Math.IntersectionTypes
TYPE:  sealed struct
TOKEN: 0x200004B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Dest.Math.IntersectionTypes     Empty  // const
  public    static  Dest.Math.IntersectionTypes     Point  // const
  public    static  Dest.Math.IntersectionTypes     Segment  // const
  public    static  Dest.Math.IntersectionTypes     Ray  // const
  public    static  Dest.Math.IntersectionTypes     Line  // const
  public    static  Dest.Math.IntersectionTypes     Polygon  // const
  public    static  Dest.Math.IntersectionTypes     Plane  // const
  public    static  Dest.Math.IntersectionTypes     Polyhedron  // const
  public    static  Dest.Math.IntersectionTypes     Other  // const
METHODS:
END_CLASS

CLASS: Dest.Math.ILogger
TYPE:  interface
TOKEN: 0x200004C
FIELDS:
METHODS:
  RVA=-1  // abstract  token=0x600017C  System.Void LogInfo(System.Object value)
  RVA=-1  // abstract  token=0x600017D  System.Void LogWarning(System.Object value)
  RVA=-1  // abstract  token=0x600017E  System.Void LogError(System.Object value)
END_CLASS

CLASS: Dest.Math.Logger
TYPE:  class
TOKEN: 0x200004D
SIZE:  0x10
FIELDS:
  private   static  Dest.Math.ILogger               _instance  // static @ 0x0
METHODS:
  RVA=0x057175B0  token=0x600017F  System.Void .cctor()
  RVA=0x057173BC  token=0x6000180  System.Void LogInfo(System.Object value)
  RVA=0x05717470  token=0x6000181  System.Void LogWarning(System.Object value)
  RVA=0x05717304  token=0x6000182  System.Void LogError(System.Object value)
  RVA=0x05717528  token=0x6000183  System.Void SetLogger(Dest.Math.ILogger logger)
  RVA=0x0350B670  token=0x6000184  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.DefaultLogger
TYPE:  class
TOKEN: 0x200004E
SIZE:  0x10
IMPLEMENTS: Dest.Math.ILogger
FIELDS:
METHODS:
  RVA=0x057170E8  token=0x6000185  System.Void LogInfo(System.Object value)
  RVA=0x05717134  token=0x6000186  System.Void LogWarning(System.Object value)
  RVA=0x0571709C  token=0x6000187  System.Void LogError(System.Object value)
  RVA=0x0350B670  token=0x6000188  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.EmptyLogger
TYPE:  class
TOKEN: 0x200004F
SIZE:  0x10
IMPLEMENTS: Dest.Math.ILogger
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000189  System.Void LogInfo(System.Object value)
  RVA=0x0350B670  token=0x600018A  System.Void LogWarning(System.Object value)
  RVA=0x0350B670  token=0x600018B  System.Void LogError(System.Object value)
  RVA=0x0350B670  token=0x600018C  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.Mathfex
TYPE:  static class
TOKEN: 0x2000050
SIZE:  0x10
FIELDS:
  public    static  System.Single                   ZeroTolerance  // const
  public    static  System.Single                   NegativeZeroTolerance  // const
  public    static  System.Single                   ZeroToleranceSqr  // const
  public    static  System.Single                   Pi  // const
  public    static  System.Single                   HalfPi  // const
  public    static  System.Single                   TwoPi  // const
METHODS:
  RVA=0x03D51490  token=0x600018D  System.Single EvalSquared(System.Single x)
  RVA=0x03D51630  token=0x600018E  System.Single EvalInvSquared(System.Single x)
  RVA=0x03D525D0  token=0x600018F  System.Single EvalCubic(System.Single x)
  RVA=0x03D52640  token=0x6000190  System.Single EvalInvCubic(System.Single x)
  RVA=0x03D52650  token=0x6000191  System.Single EvalQuadratic(System.Single x, System.Single a, System.Single b, System.Single c)
  RVA=0x03D52670  token=0x6000192  System.Single EvalSigmoid(System.Single x)
  RVA=0x05717A20  token=0x6000193  System.Single EvalOverlappedStep(System.Single x, System.Single overlap, System.Int32 objectIndex, System.Int32 objectCount)
  RVA=0x05717A70  token=0x6000194  System.Single EvalSmoothOverlappedStep(System.Single x, System.Single overlap, System.Int32 objectIndex, System.Int32 objectCount)
  RVA=0x057179E4  token=0x6000195  System.Single EvalGaussian(System.Single x, System.Single a, System.Single b, System.Single c)
  RVA=0x03D525E0  token=0x6000196  System.Single EvalGaussian2D(System.Single x, System.Single y, System.Single x0, System.Single y0, System.Single A, System.Single a, System.Single b, System.Single c)
  RVA=0x05717B88  token=0x6000197  System.Single Lerp(System.Single value0, System.Single value1, System.Single factor)
  RVA=0x03D52690  token=0x6000198  System.Single LerpUnclamped(System.Single value0, System.Single value1, System.Single factor)
  RVA=0x05717BDC  token=0x6000199  System.Single SigmoidInterp(System.Single value0, System.Single value1, System.Single factor)
  RVA=0x05717C28  token=0x600019A  System.Single SinInterp(System.Single value0, System.Single value1, System.Single factor)
  RVA=0x05717908  token=0x600019B  System.Single CosInterp(System.Single value0, System.Single value1, System.Single factor)
  RVA=0x05717C84  token=0x600019C  System.Single WobbleInterp(System.Single value0, System.Single value1, System.Single factor)
  RVA=0x0571797C  token=0x600019D  System.Single CurveInterp(System.Single value0, System.Single value1, System.Single factor, UnityEngine.AnimationCurve curve)
  RVA=0x05717AD8  token=0x600019E  System.Single FuncInterp(System.Single value0, System.Single value1, System.Single factor, System.Func<System.Single,System.Single> func)
  RVA=0x05717B58  token=0x600019F  System.Single InvSqrt(System.Single value)
  RVA=0x05717BC8  token=0x60001A0  System.Boolean Near(System.Single value0, System.Single value1, System.Single epsilon)
  RVA=0x05717BB8  token=0x60001A1  System.Boolean NearZero(System.Single value, System.Single epsilon)
  RVA=0x05717708  token=0x60001A2  UnityEngine.Vector2 CartesianToPolar(UnityEngine.Vector2 cartesianCoordinates)
  RVA=0x03D526A0  token=0x60001A3  UnityEngine.Vector2 PolarToCartesian(UnityEngine.Vector2 polarCoordinates)
  RVA=0x057177EC  token=0x60001A4  UnityEngine.Vector3 CartesianToSpherical(UnityEngine.Vector3 cartesianCoordinates)
  RVA=0x03D526F0  token=0x60001A5  UnityEngine.Vector3 SphericalToCartesian(UnityEngine.Vector3 sphericalCoordinates)
  RVA=0x05717620  token=0x60001A6  UnityEngine.Vector3 CartesianToCylindrical(UnityEngine.Vector3 cartesianCoordinates)
  RVA=0x03D52580  token=0x60001A7  UnityEngine.Vector3 CylindricalToCartesian(UnityEngine.Vector3 cylindricalCoordinates)
END_CLASS

CLASS: Dest.Math.Matrix4x4ex
TYPE:  static class
TOKEN: 0x2000051
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.Matrix4x4           Identity  // static @ 0x0
METHODS:
  RVA=0x0571A5C0  token=0x60001A8  System.Void RotationMatrixToQuaternion(UnityEngine.Matrix4x4& matrix, UnityEngine.Quaternion& quaternion)
  RVA=0x03D53CF0  token=0x60001A9  System.Void QuaternionToRotationMatrix(UnityEngine.Quaternion quaternion, UnityEngine.Matrix4x4& matrix)
  RVA=0x03D53E70  token=0x60001AA  System.Void QuaternionToRotationMatrix(UnityEngine.Quaternion& quaternion, UnityEngine.Matrix4x4& matrix)
  RVA=0x03D53660  token=0x60001AB  System.Void CreateTranslation(UnityEngine.Vector3 position, UnityEngine.Matrix4x4& matrix)
  RVA=0x03D53620  token=0x60001AC  System.Void CreateTranslation(UnityEngine.Vector3& position, UnityEngine.Matrix4x4& matrix)
  RVA=0x03D52CA0  token=0x60001AD  System.Void CreateScale(UnityEngine.Vector3 scale, UnityEngine.Matrix4x4& matrix)
  RVA=0x03D52CE0  token=0x60001AE  System.Void CreateScale(UnityEngine.Vector3& scale, UnityEngine.Matrix4x4& matrix)
  RVA=0x03D52D20  token=0x60001AF  System.Void CreateScale(System.Single scale, UnityEngine.Matrix4x4& matrix)
  RVA=0x057181FC  token=0x60001B0  System.Void CreateRotationEuler(System.Single eulerX, System.Single eulerY, System.Single eulerZ, UnityEngine.Matrix4x4& matrix)
  RVA=0x05718300  token=0x60001B1  System.Void CreateRotationEuler(UnityEngine.Vector3 eulerAngles, UnityEngine.Matrix4x4& matrix)
  RVA=0x0571828C  token=0x60001B2  System.Void CreateRotationEuler(UnityEngine.Vector3& eulerAngles, UnityEngine.Matrix4x4& matrix)
  RVA=0x03D52AA0  token=0x60001B3  System.Void CreateRotationX(System.Single angleInDegrees, UnityEngine.Matrix4x4& matrix)
  RVA=0x03D52B30  token=0x60001B4  System.Void CreateRotationY(System.Single angleInDegrees, UnityEngine.Matrix4x4& matrix)
  RVA=0x03D52BC0  token=0x60001B5  System.Void CreateRotationZ(System.Single angleInDegrees, UnityEngine.Matrix4x4& matrix)
  RVA=0x05718078  token=0x60001B6  System.Void CreateRotationAngleAxis(System.Single angleInDegrees, UnityEngine.Vector3 rotationAxis, UnityEngine.Matrix4x4& matrix)
  RVA=0x03D52940  token=0x60001B7  System.Void CreateRotationAngleUnitAxis(System.Single angleInDegrees, UnityEngine.Vector3 normalizedAxis, UnityEngine.Matrix4x4& matrix)
  RVA=0x057186A0  token=0x60001B8  System.Void CreateRotation(UnityEngine.Vector3 rotationOrigin, UnityEngine.Quaternion rotation, UnityEngine.Matrix4x4& result)
  RVA=0x057185A4  token=0x60001B9  System.Void CreateRotation(UnityEngine.Vector3& rotationOrigin, UnityEngine.Quaternion& rotation, UnityEngine.Matrix4x4& result)
  RVA=0x03D53FF0  token=0x60001BA  System.Void Transpose(UnityEngine.Matrix4x4& matrix)
  RVA=0x03D54060  token=0x60001BB  System.Void Transpose(UnityEngine.Matrix4x4& matrix, UnityEngine.Matrix4x4& transpose)
  RVA=0x03D52790  token=0x60001BC  System.Single CalcDeterminant(UnityEngine.Matrix4x4& matrix)
  RVA=0x057197C4  token=0x60001BD  System.Void Inverse(UnityEngine.Matrix4x4& matrix, System.Single epsilon)
  RVA=0x057191EC  token=0x60001BE  System.Void Inverse(UnityEngine.Matrix4x4& matrix, UnityEngine.Matrix4x4& inverse, System.Single epsilon)
  RVA=0x03D528E0  token=0x60001BF  System.Void CopyMatrix(UnityEngine.Matrix4x4& source, UnityEngine.Matrix4x4& destination)
  RVA=0x03D53870  token=0x60001C0  System.Void Multiply(UnityEngine.Matrix4x4& matrix0, UnityEngine.Matrix4x4& matrix1, UnityEngine.Matrix4x4& result)
  RVA=0x0571A1D8  token=0x60001C1  System.Void MultiplyRight(UnityEngine.Matrix4x4& matrix0, UnityEngine.Matrix4x4& matrix1)
  RVA=0x05719DF0  token=0x60001C2  System.Void MultiplyLeft(UnityEngine.Matrix4x4& matrix1, UnityEngine.Matrix4x4& matrix0)
  RVA=0x03D536A0  token=0x60001C3  System.Void Multiply(UnityEngine.Matrix4x4& matrix, System.Single scalar)
  RVA=0x03D53C10  token=0x60001C4  System.Void Multiply(UnityEngine.Matrix4x4& matrix, System.Single scalar, UnityEngine.Matrix4x4& result)
  RVA=0x03D53770  token=0x60001C5  UnityEngine.Vector4 Multiply(UnityEngine.Matrix4x4& matrix, UnityEngine.Vector4 vector)
  RVA=0x03D53770  token=0x60001C6  UnityEngine.Vector4 Multiply(UnityEngine.Matrix4x4& matrix, UnityEngine.Vector4& vector)
  RVA=0x05718BD8  token=0x60001C7  System.Void CreateSRT(UnityEngine.Vector3 scaling, UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result)
  RVA=0x05718AD8  token=0x60001C8  System.Void CreateSRT(UnityEngine.Vector3& scaling, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result)
  RVA=0x05719014  token=0x60001C9  System.Void CreateSRT(System.Single scaling, UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result)
  RVA=0x05719100  token=0x60001CA  System.Void CreateSRT(System.Single scaling, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result)
  RVA=0x05718E6C  token=0x60001CB  System.Void CreateSRT(UnityEngine.Vector3 scaling, UnityEngine.Vector3 rotationOrigin, UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result)
  RVA=0x05718930  token=0x60001CC  System.Void CreateSRT(UnityEngine.Vector3& scaling, UnityEngine.Vector3& rotationOrigin, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result)
  RVA=0x0571879C  token=0x60001CD  System.Void CreateSRT(System.Single scaling, UnityEngine.Vector3 rotationOrigin, UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result)
  RVA=0x05718CD8  token=0x60001CE  System.Void CreateSRT(System.Single scaling, UnityEngine.Vector3& rotationOrigin, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result)
  RVA=0x05717E80  token=0x60001CF  System.Void CreateRT(UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result)
  RVA=0x05717EF0  token=0x60001D0  System.Void CreateRT(UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result)
  RVA=0x05717D68  token=0x60001D1  System.Void CreateRT(UnityEngine.Vector3 rotationOrigin, UnityEngine.Quaternion rotation, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result)
  RVA=0x05717F60  token=0x60001D2  System.Void CreateRT(UnityEngine.Vector3& rotationOrigin, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result)
  RVA=0x03D52C50  token=0x60001D3  System.Void CreateST(UnityEngine.Vector3 scaling, UnityEngine.Vector3 translation, UnityEngine.Matrix4x4& result)
  RVA=0x03D52C50  token=0x60001D4  System.Void CreateST(UnityEngine.Vector3& scaling, UnityEngine.Vector3& translation, UnityEngine.Matrix4x4& result)
  RVA=0x0571848C  token=0x60001D5  System.Void CreateRotationFromColumns(UnityEngine.Vector3 column0, UnityEngine.Vector3 column1, UnityEngine.Vector3 column2, UnityEngine.Matrix4x4& matrix)
  RVA=0x05718374  token=0x60001D6  System.Void CreateRotationFromColumns(UnityEngine.Vector3& column0, UnityEngine.Vector3& column1, UnityEngine.Vector3& column2, UnityEngine.Matrix4x4& matrix)
  RVA=0x03D52D60  token=0x60001D7  System.Void CreateShadowDirectional(Dest.Math.Plane3 shadowPlane, UnityEngine.Vector3 dirLightOppositeDirection, UnityEngine.Matrix4x4& result)
  RVA=0x03D52EC0  token=0x60001D8  System.Void CreateShadowDirectional(Dest.Math.Plane3& shadowPlane, UnityEngine.Vector3& dirLightOppositeDirection, UnityEngine.Matrix4x4& result)
  RVA=0x03D53020  token=0x60001D9  System.Void CreateShadowPoint(Dest.Math.Plane3 shadowPlane, UnityEngine.Vector3 pointLightPosition, UnityEngine.Matrix4x4& result)
  RVA=0x03D53180  token=0x60001DA  System.Void CreateShadowPoint(Dest.Math.Plane3& shadowPlane, UnityEngine.Vector3& pointLightPosition, UnityEngine.Matrix4x4& result)
  RVA=0x03D53480  token=0x60001DB  System.Void CreateShadow(Dest.Math.Plane3 shadowPlane, UnityEngine.Vector4 lightData, UnityEngine.Matrix4x4& result)
  RVA=0x03D532E0  token=0x60001DC  System.Void CreateShadow(Dest.Math.Plane3& shadowPlane, UnityEngine.Vector4& lightData, UnityEngine.Matrix4x4& result)
  RVA=0x0571A688  token=0x60001DD  System.Void .cctor()
END_CLASS

CLASS: Dest.Math.Quaternionex
TYPE:  static class
TOKEN: 0x2000052
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0571A710  token=0x60001DE  UnityEngine.Quaternion DeltaTo(UnityEngine.Quaternion quat, UnityEngine.Quaternion target)
  RVA=0x0571A778  token=0x60001DF  System.String ToStringEx(UnityEngine.Quaternion quat)
END_CLASS

CLASS: Dest.Math.Rand
TYPE:  class
TOKEN: 0x2000053
SIZE:  0x20
FIELDS:
  private   static  System.Int32                    a  // const
  private   static  System.Int32                    b  // const
  private   static  System.Int32                    c  // const
  private   static  System.UInt32                   DefaultY  // const
  private   static  System.UInt32                   DefaultZ  // const
  private   static  System.UInt32                   DefaultW  // const
  private   static  System.UInt32                   PositiveMask  // const
  private   static  System.UInt32                   BoolModuloMask  // const
  private   static  System.UInt32                   ByteModuloMask  // const
  private   static  System.Double                   One_div_uintMaxValuePlusOne  // const
  private   static  System.Double                   TwoPi  // const
  private   static  Dest.Math.Rand                  _seedGenerator  // static @ 0x0
  private           System.UInt32                   _x  // 0x10
  private           System.UInt32                   _y  // 0x14
  private           System.UInt32                   _z  // 0x18
  private           System.UInt32                   _w  // 0x1c
  public    static  Dest.Math.Rand                  Instance  // static @ 0x8
METHODS:
  RVA=0x0571B8D0  token=0x60001E0  System.Void .cctor()
  RVA=0x0571B9A0  token=0x60001E1  System.Void .ctor()
  RVA=0x03D54240  token=0x60001E2  System.Void .ctor(System.Int32 seed)
  RVA=0x03D54240  token=0x60001E3  System.Void ResetSeed(System.Int32 seed)
  RVA=0x03D540C0  token=0x60001E4  System.Void GetState(System.UInt32& x, System.UInt32& y, System.UInt32& z, System.UInt32& w)
  RVA=0x03D54260  token=0x60001E5  System.Void SetState(System.UInt32 x, System.UInt32 y, System.UInt32 z, System.UInt32 w)
  RVA=0x03D540E0  token=0x60001E6  System.Int32 NextInt()
  RVA=0x03D541A0  token=0x60001E7  System.Int32 NextInt(System.Int32 max)
  RVA=0x0571B06C  token=0x60001E8  System.Int32 NextInt(System.Int32 min, System.Int32 max)
  RVA=0x0571B060  token=0x60001E9  System.Int32 NextIntInclusive(System.Int32 min, System.Int32 max)
  RVA=0x03D54200  token=0x60001EA  System.Int32 NextPositiveInt()
  RVA=0x03D540E0  token=0x60001EB  System.UInt32 NextUInt()
  RVA=0x03D54110  token=0x60001EC  System.Double NextDouble()
  RVA=0x0571AEDC  token=0x60001ED  System.Double NextDouble(System.Double min, System.Double max)
  RVA=0x03D54150  token=0x60001EE  System.Single NextFloat()
  RVA=0x0571AF9C  token=0x60001EF  System.Single NextFloat(System.Single min, System.Single max)
  RVA=0x0571AEA8  token=0x60001F0  System.Boolean NextBool()
  RVA=0x03D540E0  token=0x60001F1  System.Byte NextByte()
  RVA=0x0571B6B4  token=0x60001F2  UnityEngine.Color RandomColorOpaque()
  RVA=0x0571B720  token=0x60001F3  UnityEngine.Color RandomColorTransparent()
  RVA=0x0571B620  token=0x60001F4  UnityEngine.Color32 RandomColor32Opaque()
  RVA=0x0571B660  token=0x60001F5  UnityEngine.Color32 RandomColor32Transparent()
  RVA=0x0571B608  token=0x60001F6  System.Single RandomAngleRadians()
  RVA=0x0571B5F0  token=0x60001F7  System.Single RandomAngleDegrees()
  RVA=0x0571AB3C  token=0x60001F8  UnityEngine.Vector2 InSquare(System.Single side)
  RVA=0x0571B4B8  token=0x60001F9  UnityEngine.Vector2 OnSquare(System.Single side)
  RVA=0x0571A9AC  token=0x60001FA  UnityEngine.Vector3 InCube(System.Single side)
  RVA=0x0571B1A8  token=0x60001FB  UnityEngine.Vector3 OnCube(System.Single side)
  RVA=0x0571A934  token=0x60001FC  UnityEngine.Vector2 InCircle(System.Single radius)
  RVA=0x0571A894  token=0x60001FD  UnityEngine.Vector2 InCircle(System.Single radiusMin, System.Single radiusMax)
  RVA=0x0571B14C  token=0x60001FE  UnityEngine.Vector2 OnCircle(System.Single radius)
  RVA=0x0571AA5C  token=0x60001FF  UnityEngine.Vector3 InSphere(System.Single radius)
  RVA=0x0571B3EC  token=0x6000200  UnityEngine.Vector3 OnSphere(System.Single radius)
  RVA=0x0571AD2C  token=0x6000201  UnityEngine.Vector3 InTriangle(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2)
  RVA=0x0571ABB0  token=0x6000202  UnityEngine.Vector3 InTriangle(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  RVA=0x0571B7A4  token=0x6000203  UnityEngine.Quaternion RandomRotation()
END_CLASS

CLASS: Dest.Math.Vector2ex
TYPE:  static class
TOKEN: 0x2000054
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.Vector2             Zero  // static @ 0x0
  public    static readonly UnityEngine.Vector2             One  // static @ 0x8
  public    static readonly UnityEngine.Vector2             UnitX  // static @ 0x10
  public    static readonly UnityEngine.Vector2             UnitY  // static @ 0x18
  public    static readonly UnityEngine.Vector2             PositiveInfinity  // static @ 0x20
  public    static readonly UnityEngine.Vector2             NegativeInfinity  // static @ 0x28
METHODS:
  RVA=0x0571CE24  token=0x6000204  Dest.Math.Vector2ex.Information GetInformation(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Single epsilon)
  RVA=0x03D54350  token=0x6000205  System.Single Length(UnityEngine.Vector2 vector)
  RVA=0x03D54330  token=0x6000206  System.Single LengthSqr(UnityEngine.Vector2 vector)
  RVA=0x03D51240  token=0x6000207  System.Single DotPerp(UnityEngine.Vector2 vector, UnityEngine.Vector2 value)
  RVA=0x03D54280  token=0x6000208  System.Single DotPerp(UnityEngine.Vector2 vector, UnityEngine.Vector2& value)
  RVA=0x03D542A0  token=0x6000209  System.Single DotPerp(UnityEngine.Vector2& vector, UnityEngine.Vector2& value)
  RVA=0x03D542E0  token=0x600020A  System.Single Dot(UnityEngine.Vector2 vector, UnityEngine.Vector2 value)
  RVA=0x03D542C0  token=0x600020B  System.Single Dot(UnityEngine.Vector2 vector, UnityEngine.Vector2& value)
  RVA=0x03D54310  token=0x600020C  System.Single Dot(UnityEngine.Vector2& vector, UnityEngine.Vector2& value)
  RVA=0x03D54390  token=0x600020D  UnityEngine.Vector2 Perp(UnityEngine.Vector2 vector)
  RVA=0x0571CCC4  token=0x600020E  System.Single AngleDeg(UnityEngine.Vector2 vector, UnityEngine.Vector2 target)
  RVA=0x0571CD78  token=0x600020F  System.Single AngleRad(UnityEngine.Vector2 vector, UnityEngine.Vector2 target)
  RVA=0x0571D4D8  token=0x6000210  System.Single Normalize(UnityEngine.Vector2& vector, System.Single epsilon)
  RVA=0x0571D548  token=0x6000211  System.Single SetLength(UnityEngine.Vector2& vector, System.Single lengthValue, System.Single epsilon)
  RVA=0x0571D460  token=0x6000212  System.Single GrowLength(UnityEngine.Vector2& vector, System.Single lengthDelta, System.Single epsilon)
  RVA=0x03D543C0  token=0x6000213  UnityEngine.Vector2 Replicate(System.Single value)
  RVA=0x03D51560  token=0x6000214  UnityEngine.Vector3 ToVector3XY(UnityEngine.Vector2 vector)
  RVA=0x03D515B0  token=0x6000215  UnityEngine.Vector3 ToVector3XZ(UnityEngine.Vector2 vector)
  RVA=0x03D543D0  token=0x6000216  UnityEngine.Vector3 ToVector3YZ(UnityEngine.Vector2 vector)
  RVA=0x0571D5BC  token=0x6000217  System.String ToStringEx(UnityEngine.Vector2 vector)
  RVA=0x0571D618  token=0x6000218  System.Void .cctor()
END_CLASS

CLASS: Dest.Math.ProjectionPlanes
TYPE:  sealed struct
TOKEN: 0x2000056
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Dest.Math.ProjectionPlanes      XY  // const
  public    static  Dest.Math.ProjectionPlanes      XZ  // const
  public    static  Dest.Math.ProjectionPlanes      YZ  // const
METHODS:
END_CLASS

CLASS: Dest.Math.Vector3ex
TYPE:  static class
TOKEN: 0x2000057
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.Vector3             Zero  // static @ 0x0
  public    static readonly UnityEngine.Vector3             One  // static @ 0xc
  public    static readonly UnityEngine.Vector3             UnitX  // static @ 0x18
  public    static readonly UnityEngine.Vector3             UnitY  // static @ 0x24
  public    static readonly UnityEngine.Vector3             UnitZ  // static @ 0x30
  public    static readonly UnityEngine.Vector3             PositiveInfinity  // static @ 0x3c
  public    static readonly UnityEngine.Vector3             NegativeInfinity  // static @ 0x48
METHODS:
  RVA=0x0571D960  token=0x600021A  Dest.Math.Vector3ex.Information GetInformation(System.Collections.Generic.IList<UnityEngine.Vector3> points, System.Single epsilon)
  RVA=0x03D544C0  token=0x600021B  System.Single Length(UnityEngine.Vector3 vector)
  RVA=0x03D54490  token=0x600021C  System.Single LengthSqr(UnityEngine.Vector3 vector)
  RVA=0x03D54460  token=0x600021D  System.Single Dot(UnityEngine.Vector3 vector, UnityEngine.Vector3 value)
  RVA=0x03D54460  token=0x600021E  System.Single Dot(UnityEngine.Vector3 vector, UnityEngine.Vector3& value)
  RVA=0x03D54460  token=0x600021F  System.Single Dot(UnityEngine.Vector3& vector, UnityEngine.Vector3& value)
  RVA=0x0571D6C8  token=0x6000220  System.Single AngleDeg(UnityEngine.Vector3 vector, UnityEngine.Vector3 target)
  RVA=0x0571D784  token=0x6000221  System.Single AngleRad(UnityEngine.Vector3 vector, UnityEngine.Vector3 target)
  RVA=0x0571E790  token=0x6000222  System.Single SignedAngleDeg(UnityEngine.Vector3 vector, UnityEngine.Vector3 target, UnityEngine.Vector3 normal)
  RVA=0x0571E8F0  token=0x6000223  System.Single SignedAngleRad(UnityEngine.Vector3 vector, UnityEngine.Vector3 target, UnityEngine.Vector3 normal)
  RVA=0x03D54400  token=0x6000224  UnityEngine.Vector3 Cross(UnityEngine.Vector3 vector, UnityEngine.Vector3 value)
  RVA=0x03D54400  token=0x6000225  UnityEngine.Vector3 Cross(UnityEngine.Vector3 vector, UnityEngine.Vector3& value)
  RVA=0x03D54400  token=0x6000226  UnityEngine.Vector3 Cross(UnityEngine.Vector3& vector, UnityEngine.Vector3& value)
  RVA=0x0571EBB0  token=0x6000227  UnityEngine.Vector3 UnitCross(UnityEngine.Vector3 vector, UnityEngine.Vector3 value)
  RVA=0x0571EAF0  token=0x6000228  UnityEngine.Vector3 UnitCross(UnityEngine.Vector3 vector, UnityEngine.Vector3& value)
  RVA=0x0571EC68  token=0x6000229  UnityEngine.Vector3 UnitCross(UnityEngine.Vector3& vector, UnityEngine.Vector3& value)
  RVA=0x0571E5F0  token=0x600022A  System.Single Normalize(UnityEngine.Vector3& vector, System.Single epsilon)
  RVA=0x0571E700  token=0x600022B  System.Single SetLength(UnityEngine.Vector3& vector, System.Single lengthValue, System.Single epsilon)
  RVA=0x0571E55C  token=0x600022C  System.Single GrowLength(UnityEngine.Vector3& vector, System.Single lengthDelta, System.Single epsilon)
  RVA=0x03D54500  token=0x600022D  UnityEngine.Vector3 Replicate(System.Single value)
  RVA=0x0571D838  token=0x600022E  System.Void CreateOrthonormalBasis(UnityEngine.Vector3& u, UnityEngine.Vector3& v, UnityEngine.Vector3& w)
  RVA=0x0571E67C  token=0x600022F  System.Boolean SameDirection(UnityEngine.Vector3 value0, UnityEngine.Vector3 value1)
  RVA=0x03D51540  token=0x6000230  UnityEngine.Vector2 ToVector2XY(UnityEngine.Vector3 vector)
  RVA=0x03D51590  token=0x6000231  UnityEngine.Vector2 ToVector2XZ(UnityEngine.Vector3 vector)
  RVA=0x03D54520  token=0x6000232  UnityEngine.Vector2 ToVector2YZ(UnityEngine.Vector3 vector)
  RVA=0x0571EAC8  token=0x6000233  UnityEngine.Vector2 ToVector2(UnityEngine.Vector3 vector, Dest.Math.ProjectionPlanes projectionPlane)
  RVA=0x0571E51C  token=0x6000234  Dest.Math.ProjectionPlanes GetProjectionPlane(UnityEngine.Vector3 vector)
  RVA=0x0571EA48  token=0x6000235  System.String ToStringEx(UnityEngine.Vector3 vector)
  RVA=0x03CE1DD0  token=0x6000236  System.Void .cctor()
END_CLASS

CLASS: Dest.Math.BrentsRoot
TYPE:  sealed struct
TOKEN: 0x2000059
SIZE:  0x1C
FIELDS:
  public            System.Single                   X  // 0x10
  public            System.Int32                    Iterations  // 0x14
  public            System.Boolean                  ExceededMaxIterations  // 0x18
METHODS:
END_CLASS

CLASS: Dest.Math.RootFinder
TYPE:  static class
TOKEN: 0x200005A
SIZE:  0x10
FIELDS:
  private   static  System.Single                   third  // const
  private   static  System.Single                   twentySeventh  // const
  private   static  System.Single                   sqrt3  // static @ 0x0
METHODS:
  RVA=0x0571BA18  token=0x6000238  System.Boolean BrentsMethod(System.Func<System.Single,System.Single> function, System.Single x0, System.Single x1, Dest.Math.BrentsRoot& root, System.Int32 maxIterations, System.Single negativeTolerance, System.Single positiveTolerance, System.Single stepTolerance, System.Single segmentTolerance)
  RVA=0x0571C1AC  token=0x6000239  System.Boolean Linear(System.Single c0, System.Single c1, System.Single& root, System.Single epsilon)
  RVA=0x0571C470  token=0x600023A  System.Boolean Quadratic(System.Single c0, System.Single c1, System.Single c2, Dest.Math.QuadraticRoots& roots, System.Single epsilon)
  RVA=0x0571BDF0  token=0x600023B  System.Boolean Cubic(System.Single c0, System.Single c1, System.Single c2, System.Single c3, Dest.Math.CubicRoots& roots, System.Single epsilon)
  RVA=0x0571C5F8  token=0x600023C  System.Boolean Quartic(System.Single c0, System.Single c1, System.Single c2, System.Single c3, System.Single c4, Dest.Math.QuarticRoots& roots, System.Single epsilon)
  RVA=0x0571C1D8  token=0x600023D  System.Single PolynomialBound(Dest.Math.Polynomial poly, System.Single epsilon)
  RVA=0x0571C388  token=0x600023E  System.Boolean Polynomial(Dest.Math.Polynomial poly, System.Single xMin, System.Single xMax, System.Single[]& roots, System.Int32 digits, System.Single epsilon)
  RVA=0x0571C2A4  token=0x600023F  System.Boolean Polynomial(Dest.Math.Polynomial poly, System.Single[]& roots, System.Int32 digits, System.Single epsilon)
  RVA=0x0571CAAC  token=0x6000240  System.Void .cctor()
END_CLASS

CLASS: Dest.Math.EigenData
TYPE:  class
TOKEN: 0x200005C
SIZE:  0x28
FIELDS:
  private           System.Int32                    _size  // 0x10
  private           System.Single[]                 _diagonal  // 0x18
  private           System.Single[,]                _matrix  // 0x20
PROPERTIES:
  Size  get=0x03D4E340
METHODS:
  RVA=0x057242F8  token=0x6000246  System.Void .ctor(System.Single[] diagonal, System.Single[,] matrix)
  RVA=0x057035D8  token=0x6000247  System.Single GetEigenvalue(System.Int32 index)
  RVA=0x05724058  token=0x6000248  UnityEngine.Vector2 GetEigenvector2(System.Int32 index)
  RVA=0x05724110  token=0x6000249  UnityEngine.Vector3 GetEigenvector3(System.Int32 index)
  RVA=0x057241E0  token=0x600024A  System.Single[] GetEigenvector(System.Int32 index)
  RVA=0x05724284  token=0x600024B  System.Void GetEigenvector(System.Int32 index, System.Single[] out_eigenvector)
END_CLASS

CLASS: Dest.Math.EigenDecomposition
TYPE:  static class
TOKEN: 0x200005D
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x05724C90  token=0x600024C  System.Void Tridiagonal2(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix, System.Boolean& isRotation)
  RVA=0x05724DA4  token=0x600024D  System.Void Tridiagonal3(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix, System.Boolean& isRotation)
  RVA=0x05725118  token=0x600024E  System.Void TridiagonalN(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix, System.Boolean& isRotation)
  RVA=0x05724670  token=0x600024F  System.Boolean QLAlgorithm(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix)
  RVA=0x0572450C  token=0x6000250  System.Void IncreasingSort(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix, System.Boolean& isRotation)
  RVA=0x05724334  token=0x6000251  System.Void DecreasingSort(System.Single[] diagonal, System.Single[] subdiagonal, System.Single[,] matrix, System.Boolean& isRotation)
  RVA=0x0572449C  token=0x6000252  System.Void GuaranteeRotation(System.Single[,] matrix, System.Boolean isRotation)
  RVA=0x05724AE0  token=0x6000253  Dest.Math.EigenData Solve(System.Single[,] symmetricSquareMatrix, System.Boolean increasingSort)
END_CLASS

CLASS: Dest.Math.Integrator
TYPE:  static class
TOKEN: 0x200005E
SIZE:  0x10
FIELDS:
  private   static  System.Int32                    _degree  // const
  private   static  System.Single[]                 root  // static @ 0x0
  private   static  System.Single[]                 coeff  // static @ 0x8
METHODS:
  RVA=0x05725B2C  token=0x6000254  System.Single TrapezoidRule(System.Func<System.Single,System.Single> function, System.Single a, System.Single b, System.Int32 sampleCount)
  RVA=0x057258C0  token=0x6000255  System.Single RombergIntegral(System.Func<System.Single,System.Single> function, System.Single a, System.Single b, System.Int32 order)
  RVA=0x057257A4  token=0x6000256  System.Single GaussianQuadrature(System.Func<System.Single,System.Single> function, System.Single a, System.Single b)
  RVA=0x05725C30  token=0x6000257  System.Void .cctor()
END_CLASS

CLASS: Dest.Math.LinearSystem
TYPE:  static class
TOKEN: 0x200005F
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0572708C  token=0x6000258  System.Boolean Solve2(System.Single[,] A, System.Single[] B, System.Single[]& X, System.Single zeroTolerance)
  RVA=0x05727294  token=0x6000259  System.Boolean Solve2(System.Single[,] A, System.Single[] B, UnityEngine.Vector2& X, System.Single zeroTolerance)
  RVA=0x05727448  token=0x600025A  System.Boolean Solve3(System.Single[,] A, System.Single[] B, System.Single[]& X, System.Single zeroTolerance)
  RVA=0x05727368  token=0x600025B  System.Boolean Solve3(System.Single[,] A, System.Single[] B, UnityEngine.Vector3& X, System.Single zeroTolerance)
  RVA=0x057282F0  token=0x600025C  System.Void SwapRows(System.Single[,] matrix, System.Int32 row0, System.Int32 row1, System.Int32 columnCount)
  RVA=0x05727E04  token=0x600025D  System.Boolean Solve(System.Single[,] A, System.Single[] B, System.Single[]& X)
  RVA=0x05727B5C  token=0x600025E  System.Boolean SolveTridiagonal(System.Single[] A, System.Single[] B, System.Single[] C, System.Single[] R, System.Single[]& U)
  RVA=0x05726BC4  token=0x600025F  System.Boolean Inverse(System.Single[,] A, System.Single[,]& invA)
END_CLASS

CLASS: Dest.Math.OdeFunction
TYPE:  sealed class
TOKEN: 0x2000060
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x05728508  token=0x6000260  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x057284F4  token=0x6000261  System.Void Invoke(System.Single t, System.Single[] y, System.Single[] F)
  RVA=0x0572846C  token=0x6000262  System.IAsyncResult BeginInvoke(System.Single t, System.Single[] y, System.Single[] F, System.AsyncCallback callback, System.Object object)
  RVA=0x042BD330  token=0x6000263  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Dest.Math.OdeSolver
TYPE:  abstract class
TOKEN: 0x2000061
SIZE:  0x28
FIELDS:
  protected         System.Int32                    _dim  // 0x10
  protected         System.Single                   _step  // 0x14
  protected         Dest.Math.OdeFunction           _function  // 0x18
  protected         System.Single[]                 _FValue  // 0x20
PROPERTIES:
  Step  get=0x03D51930  set=0x03D51940
METHODS:
  RVA=0x05728C0C  token=0x6000266  System.Void .ctor(System.Int32 dim, System.Single step, Dest.Math.OdeFunction function)
  RVA=-1  // abstract  token=0x6000267  System.Void Update(System.Single tIn, System.Single[] yIn, System.Single& tOut, System.Single[] yOut)
END_CLASS

CLASS: Dest.Math.OdeEuler
TYPE:  class
TOKEN: 0x2000062
SIZE:  0x28
EXTENDS: Dest.Math.OdeSolver
FIELDS:
METHODS:
  RVA=0x0572845C  token=0x6000268  System.Void .ctor(System.Int32 dim, System.Single step, Dest.Math.OdeFunction function)
  RVA=0x05728398  token=0x6000269  System.Void Update(System.Single tIn, System.Single[] yIn, System.Single& tOut, System.Single[] yOut)
END_CLASS

CLASS: Dest.Math.OdeMidpoint
TYPE:  class
TOKEN: 0x2000063
SIZE:  0x38
EXTENDS: Dest.Math.OdeSolver
FIELDS:
  private           System.Single                   _halfStep  // 0x28
  private           System.Single[]                 _yTemp  // 0x30
PROPERTIES:
  Step  get=0x03D51930  set=0x03D54B60
METHODS:
  RVA=0x05728730  token=0x600026C  System.Void .ctor(System.Int32 dim, System.Single step, Dest.Math.OdeFunction function)
  RVA=0x057285D0  token=0x600026D  System.Void Update(System.Single tIn, System.Single[] yIn, System.Single& tOut, System.Single[] yOut)
END_CLASS

CLASS: Dest.Math.OdeRungeKutta4
TYPE:  class
TOKEN: 0x2000064
SIZE:  0x58
EXTENDS: Dest.Math.OdeSolver
FIELDS:
  private           System.Single                   _halfStep  // 0x28
  private           System.Single                   _sixthStep  // 0x2c
  private           System.Single[]                 _temp1  // 0x30
  private           System.Single[]                 _temp2  // 0x38
  private           System.Single[]                 _temp3  // 0x40
  private           System.Single[]                 _temp4  // 0x48
  private           System.Single[]                 _yTemp  // 0x50
PROPERTIES:
  Step  get=0x03D51930  set=0x05728BE8
METHODS:
  RVA=0x05728AD8  token=0x6000270  System.Void .ctor(System.Int32 dim, System.Single step, Dest.Math.OdeFunction function)
  RVA=0x057287C4  token=0x6000271  System.Void Update(System.Single tIn, System.Single[] yIn, System.Single& tOut, System.Single[] yOut)
END_CLASS

CLASS: Dest.Math.QuadraticRoots
TYPE:  sealed struct
TOKEN: 0x2000065
SIZE:  0x1C
FIELDS:
  public            System.Single                   X0  // 0x10
  public            System.Single                   X1  // 0x14
  public            System.Int32                    RootCount  // 0x18
PROPERTIES:
  Item  get=0x0572B19C
METHODS:
END_CLASS

CLASS: Dest.Math.CubicRoots
TYPE:  sealed struct
TOKEN: 0x2000066
SIZE:  0x20
FIELDS:
  public            System.Single                   X0  // 0x10
  public            System.Single                   X1  // 0x14
  public            System.Single                   X2  // 0x18
  public            System.Int32                    RootCount  // 0x1c
PROPERTIES:
  Item  get=0x05724030
METHODS:
END_CLASS

CLASS: Dest.Math.QuarticRoots
TYPE:  sealed struct
TOKEN: 0x2000067
SIZE:  0x24
FIELDS:
  public            System.Single                   X0  // 0x10
  public            System.Single                   X1  // 0x14
  public            System.Single                   X2  // 0x18
  public            System.Single                   X3  // 0x1c
  public            System.Int32                    RootCount  // 0x20
PROPERTIES:
  Item  get=0x0572B1BC
METHODS:
END_CLASS

CLASS: Dest.Math.AAB2
TYPE:  sealed struct
TOKEN: 0x2000068
SIZE:  0x20
FIELDS:
  public            UnityEngine.Vector2             Min  // 0x10
  public            UnityEngine.Vector2             Max  // 0x18
METHODS:
  RVA=0x03D54650  token=0x6000275  System.Void .ctor(UnityEngine.Vector2& min, UnityEngine.Vector2& max)
  RVA=0x03D4EA10  token=0x6000276  System.Void .ctor(UnityEngine.Vector2 min, UnityEngine.Vector2 max)
  RVA=0x03D54670  token=0x6000277  System.Void .ctor(System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax)
  RVA=0x0571F410  token=0x6000278  UnityEngine.Rect op_Implicit(Dest.Math.AAB2 value)
  RVA=0x03D54690  token=0x6000279  Dest.Math.AAB2 op_Implicit(UnityEngine.Rect value)
  RVA=0x03D54620  token=0x600027A  Dest.Math.AAB2 CreateFromPoint(UnityEngine.Vector2& point)
  RVA=0x03D54610  token=0x600027B  Dest.Math.AAB2 CreateFromPoint(UnityEngine.Vector2 point)
  RVA=0x0571F1EC  token=0x600027C  Dest.Math.AAB2 CreateFromTwoPoints(UnityEngine.Vector2& point0, UnityEngine.Vector2& point1)
  RVA=0x0571F1B0  token=0x600027D  Dest.Math.AAB2 CreateFromTwoPoints(UnityEngine.Vector2 point0, UnityEngine.Vector2 point1)
  RVA=0x0571EF6C  token=0x600027E  Dest.Math.AAB2 CreateFromPoints(System.Collections.Generic.IEnumerable<UnityEngine.Vector2> points)
  RVA=0x0571F0A4  token=0x600027F  Dest.Math.AAB2 CreateFromPoints(System.Collections.Generic.IList<UnityEngine.Vector2> points)
  RVA=0x0571EEB0  token=0x6000280  Dest.Math.AAB2 CreateFromPoints(UnityEngine.Vector2[] points)
  RVA=0x03D54560  token=0x6000281  System.Void CalcCenterExtents(UnityEngine.Vector2& center, UnityEngine.Vector2& extents)
  RVA=0x03D545C0  token=0x6000282  System.Void CalcVertices(UnityEngine.Vector2& vertex0, UnityEngine.Vector2& vertex1, UnityEngine.Vector2& vertex2, UnityEngine.Vector2& vertex3)
  RVA=0x0571ED28  token=0x6000283  UnityEngine.Vector2[] CalcVertices()
  RVA=0x0571EDE8  token=0x6000284  System.Void CalcVertices(UnityEngine.Vector2[] array)
  RVA=0x03D54540  token=0x6000285  System.Single CalcArea()
  RVA=0x0571F238  token=0x6000286  System.Single DistanceTo(UnityEngine.Vector2 point)
  RVA=0x0571F348  token=0x6000287  UnityEngine.Vector2 Project(UnityEngine.Vector2 point)
  RVA=0x02411D30  token=0x6000288  System.Boolean Contains(UnityEngine.Vector2& point)
  RVA=0x0571EE78  token=0x6000289  System.Boolean Contains(UnityEngine.Vector2 point)
  RVA=0x0571F308  token=0x600028A  System.Void Include(UnityEngine.Vector2& point)
  RVA=0x0571F258  token=0x600028B  System.Void Include(UnityEngine.Vector2 point)
  RVA=0x0571F2D4  token=0x600028C  System.Void Include(Dest.Math.AAB2& box)
  RVA=0x0571F2A0  token=0x600028D  System.Void Include(Dest.Math.AAB2 box)
  RVA=0x0571F378  token=0x600028E  System.String ToString()
END_CLASS

CLASS: Dest.Math.Box2
TYPE:  sealed struct
TOKEN: 0x2000069
SIZE:  0x30
FIELDS:
  public            UnityEngine.Vector2             Center  // 0x10
  public            UnityEngine.Vector2             Axis0  // 0x18
  public            UnityEngine.Vector2             Axis1  // 0x20
  public            UnityEngine.Vector2             Extents  // 0x28
METHODS:
  RVA=0x03D54880  token=0x600028F  System.Void .ctor(UnityEngine.Vector2& center, UnityEngine.Vector2& axis0, UnityEngine.Vector2& axis1, UnityEngine.Vector2& extents)
  RVA=0x03D548D0  token=0x6000290  System.Void .ctor(UnityEngine.Vector2 center, UnityEngine.Vector2 axis0, UnityEngine.Vector2 axis1, UnityEngine.Vector2 extents)
  RVA=0x05720EC0  token=0x6000291  System.Void .ctor(Dest.Math.AAB2& box)
  RVA=0x05720F5C  token=0x6000292  System.Void .ctor(Dest.Math.AAB2 box)
  RVA=0x0572047C  token=0x6000293  Dest.Math.Box2 CreateFromPoints(System.Collections.Generic.IList<UnityEngine.Vector2> points)
  RVA=0x05720818  token=0x6000294  UnityEngine.Vector2 GetAxis(System.Int32 index)
  RVA=0x0571FEB0  token=0x6000295  System.Void CalcVertices(UnityEngine.Vector2& vertex0, UnityEngine.Vector2& vertex1, UnityEngine.Vector2& vertex2, UnityEngine.Vector2& vertex3)
  RVA=0x0571FF84  token=0x6000296  UnityEngine.Vector2[] CalcVertices()
  RVA=0x05720130  token=0x6000297  System.Void CalcVertices(UnityEngine.Vector2[] array)
  RVA=0x03D54860  token=0x6000298  System.Single CalcArea()
  RVA=0x057207F8  token=0x6000299  System.Single DistanceTo(UnityEngine.Vector2 point)
  RVA=0x05720D24  token=0x600029A  UnityEngine.Vector2 Project(UnityEngine.Vector2 point)
  RVA=0x05720298  token=0x600029B  System.Boolean Contains(UnityEngine.Vector2& point)
  RVA=0x0572038C  token=0x600029C  System.Boolean Contains(UnityEngine.Vector2 point)
  RVA=0x0572089C  token=0x600029D  System.Void Include(Dest.Math.Box2& box)
  RVA=0x05720D10  token=0x600029E  System.Void Include(Dest.Math.Box2 box)
  RVA=0x05720D54  token=0x600029F  System.String ToString()
END_CLASS

CLASS: Dest.Math.Circle2
TYPE:  sealed struct
TOKEN: 0x200006A
SIZE:  0x1C
FIELDS:
  public            UnityEngine.Vector2             Center  // 0x10
  public            System.Single                   Radius  // 0x18
METHODS:
  RVA=0x03D54AD0  token=0x60002A0  System.Void .ctor(UnityEngine.Vector2& center, System.Single radius)
  RVA=0x03D54AE0  token=0x60002A1  System.Void .ctor(UnityEngine.Vector2 center, System.Single radius)
  RVA=0x05723634  token=0x60002A2  Dest.Math.Circle2 CreateFromPointsAAB(System.Collections.Generic.IEnumerable<UnityEngine.Vector2> points)
  RVA=0x0572356C  token=0x60002A3  Dest.Math.Circle2 CreateFromPointsAAB(System.Collections.Generic.IList<UnityEngine.Vector2> points)
  RVA=0x05723918  token=0x60002A4  Dest.Math.Circle2 CreateFromPointsAverage(System.Collections.Generic.IEnumerable<UnityEngine.Vector2> points)
  RVA=0x05723744  token=0x60002A5  Dest.Math.Circle2 CreateFromPointsAverage(System.Collections.Generic.IList<UnityEngine.Vector2> points)
  RVA=0x05723350  token=0x60002A6  System.Boolean CreateCircumscribed(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2, Dest.Math.Circle2& circle)
  RVA=0x05723C4C  token=0x60002A7  System.Boolean CreateInscribed(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2, Dest.Math.Circle2& circle)
  RVA=0x03D549F0  token=0x60002A8  System.Single CalcPerimeter()
  RVA=0x03D549D0  token=0x60002A9  System.Single CalcArea()
  RVA=0x03D54A00  token=0x60002AA  UnityEngine.Vector2 Eval(System.Single t)
  RVA=0x03D54A60  token=0x60002AB  UnityEngine.Vector2 Eval(System.Single t, System.Single radius)
  RVA=0x05723E5C  token=0x60002AC  System.Single DistanceTo(UnityEngine.Vector2 point)
  RVA=0x05723F78  token=0x60002AD  UnityEngine.Vector2 Project(UnityEngine.Vector2 point)
  RVA=0x05723308  token=0x60002AE  System.Boolean Contains(UnityEngine.Vector2& point)
  RVA=0x057232BC  token=0x60002AF  System.Boolean Contains(UnityEngine.Vector2 point)
  RVA=0x05723E90  token=0x60002B0  System.Void Include(Dest.Math.Circle2& circle)
  RVA=0x05723E7C  token=0x60002B1  System.Void Include(Dest.Math.Circle2 circle)
  RVA=0x05723FA8  token=0x60002B2  System.String ToString()
END_CLASS

CLASS: Dest.Math.Line2
TYPE:  sealed struct
TOKEN: 0x200006B
SIZE:  0x20
FIELDS:
  public            UnityEngine.Vector2             Center  // 0x10
  public            UnityEngine.Vector2             Direction  // 0x18
METHODS:
  RVA=0x03D54650  token=0x60002B3  System.Void .ctor(UnityEngine.Vector2& center, UnityEngine.Vector2& direction)
  RVA=0x03D4EA10  token=0x60002B4  System.Void .ctor(UnityEngine.Vector2 center, UnityEngine.Vector2 direction)
  RVA=0x05725E24  token=0x60002B5  Dest.Math.Line2 CreateFromTwoPoints(UnityEngine.Vector2& p0, UnityEngine.Vector2& p1)
  RVA=0x05725DD8  token=0x60002B6  Dest.Math.Line2 CreateFromTwoPoints(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1)
  RVA=0x05725EF4  token=0x60002B7  Dest.Math.Line2 CreatePerpToLineTrhoughPoint(Dest.Math.Line2 line, UnityEngine.Vector2 point)
  RVA=0x03D54AF0  token=0x60002B8  Dest.Math.Line2 CreateBetweenAndEquidistantToPoints(UnityEngine.Vector2 point0, UnityEngine.Vector2 point1)
  RVA=0x05725E90  token=0x60002B9  Dest.Math.Line2 CreateParallelToGivenLineAtGivenDistance(Dest.Math.Line2 line, System.Single distance)
  RVA=0x05725F98  token=0x60002BA  UnityEngine.Vector2 Eval(System.Single t)
  RVA=0x05726AA8  token=0x60002BB  System.Single SignedDistanceTo(UnityEngine.Vector2 point)
  RVA=0x05725F78  token=0x60002BC  System.Single DistanceTo(UnityEngine.Vector2 point)
  RVA=0x057267C8  token=0x60002BD  System.Int32 QuerySide(UnityEngine.Vector2 point, System.Single epsilon)
  RVA=0x05725FF8  token=0x60002BE  System.Boolean QuerySideNegative(UnityEngine.Vector2 point, System.Single epsilon)
  RVA=0x057263CC  token=0x60002BF  System.Boolean QuerySidePositive(UnityEngine.Vector2 point, System.Single epsilon)
  RVA=0x05726958  token=0x60002C0  System.Int32 QuerySide(Dest.Math.Box2& box, System.Single epsilon)
  RVA=0x05726154  token=0x60002C1  System.Boolean QuerySideNegative(Dest.Math.Box2& box, System.Single epsilon)
  RVA=0x05726468  token=0x60002C2  System.Boolean QuerySidePositive(Dest.Math.Box2& box, System.Single epsilon)
  RVA=0x05726660  token=0x60002C3  System.Int32 QuerySide(Dest.Math.AAB2& box, System.Single epsilon)
  RVA=0x0572608C  token=0x60002C4  System.Boolean QuerySideNegative(Dest.Math.AAB2& box, System.Single epsilon)
  RVA=0x05726590  token=0x60002C5  System.Boolean QuerySidePositive(Dest.Math.AAB2& box, System.Single epsilon)
  RVA=0x05726884  token=0x60002C6  System.Int32 QuerySide(Dest.Math.Circle2& circle, System.Single epsilon)
  RVA=0x05726284  token=0x60002C7  System.Boolean QuerySideNegative(Dest.Math.Circle2& circle, System.Single epsilon)
  RVA=0x0572632C  token=0x60002C8  System.Boolean QuerySidePositive(Dest.Math.Circle2& circle, System.Single epsilon)
  RVA=0x05725FC8  token=0x60002C9  UnityEngine.Vector2 Project(UnityEngine.Vector2 point)
  RVA=0x05725D14  token=0x60002CA  System.Single AngleBetweenTwoLines(Dest.Math.Line2 anotherLine, System.Boolean acuteAngleDesired)
  RVA=0x05726B2C  token=0x60002CB  System.String ToString()
END_CLASS

CLASS: Dest.Math.Edge2
TYPE:  sealed struct
TOKEN: 0x200006C
SIZE:  0x34
FIELDS:
  public            UnityEngine.Vector2             Point0  // 0x10
  public            UnityEngine.Vector2             Point1  // 0x18
  public            UnityEngine.Vector2             Direction  // 0x20
  public            UnityEngine.Vector2             Normal  // 0x28
  public            System.Single                   Length  // 0x30
METHODS:
END_CLASS

CLASS: Dest.Math.Polygon2
TYPE:  class
TOKEN: 0x200006D
SIZE:  0x20
FIELDS:
  private           UnityEngine.Vector2[]           _vertices  // 0x10
  private           Dest.Math.Edge2[]               _edges  // 0x18
PROPERTIES:
  Vertices  get=0x020B7B20
  Edges  get=0x01041090
  VertexCount  get=0x042746EC
  Item  get=0x0572B128  set=0x0572B154
METHODS:
  RVA=0x0350B670  token=0x60002D1  System.Void .ctor()
  RVA=0x0572B008  token=0x60002D2  System.Void .ctor(UnityEngine.Vector2[] vertices)
  RVA=0x0572B0AC  token=0x60002D3  System.Void .ctor(System.Int32 vertexCount)
  RVA=0x05729F20  token=0x60002D4  Dest.Math.Polygon2 CreateProjected(Dest.Math.Polygon3 polygon, Dest.Math.ProjectionPlanes projectionPlane)
  RVA=0x0572A134  token=0x60002D5  Dest.Math.Edge2 GetEdge(System.Int32 edgeIndex)
  RVA=0x0572AE48  token=0x60002D6  System.Void UpdateEdges()
  RVA=0x0572ACA8  token=0x60002D7  System.Void UpdateEdge(System.Int32 edgeIndex)
  RVA=0x05729450  token=0x60002D8  UnityEngine.Vector2 CalcCenter()
  RVA=0x05729518  token=0x60002D9  System.Single CalcPerimeter()
  RVA=0x057292C0  token=0x60002DA  System.Single CalcArea()
  RVA=0x0572A270  token=0x60002DB  System.Boolean IsConvex(Dest.Math.Orientations& orientation, System.Single threshold)
  RVA=0x0572A248  token=0x60002DC  System.Boolean IsConvex(System.Single threshold)
  RVA=0x0572A184  token=0x60002DD  System.Boolean HasZeroCorners(System.Single threshold)
  RVA=0x0572A3EC  token=0x60002DE  System.Void ReverseVertices()
  RVA=0x05729614  token=0x60002DF  System.Boolean ContainsConvexQuadCCW(UnityEngine.Vector2& point)
  RVA=0x057295F8  token=0x60002E0  System.Boolean ContainsConvexQuadCCW(UnityEngine.Vector2 point)
  RVA=0x057299F4  token=0x60002E1  System.Boolean ContainsConvexQuadCW(UnityEngine.Vector2& point)
  RVA=0x05729DD4  token=0x60002E2  System.Boolean ContainsConvexQuadCW(UnityEngine.Vector2 point)
  RVA=0x05729580  token=0x60002E3  System.Boolean ContainsConvexCCW(UnityEngine.Vector2& point)
  RVA=0x057295A0  token=0x60002E4  System.Boolean ContainsConvexCCW(UnityEngine.Vector2 point)
  RVA=0x0572A4E0  token=0x60002E5  System.Boolean SubContainsPointCCW(UnityEngine.Vector2& p, System.Int32 i0, System.Int32 i1)
  RVA=0x057295BC  token=0x60002E6  System.Boolean ContainsConvexCW(UnityEngine.Vector2& point)
  RVA=0x057295DC  token=0x60002E7  System.Boolean ContainsConvexCW(UnityEngine.Vector2 point)
  RVA=0x0572A760  token=0x60002E8  System.Boolean SubContainsPointCW(UnityEngine.Vector2& p, System.Int32 i0, System.Int32 i1)
  RVA=0x05729E0C  token=0x60002E9  System.Boolean ContainsSimple(UnityEngine.Vector2& point)
  RVA=0x05729DF0  token=0x60002EA  System.Boolean ContainsSimple(UnityEngine.Vector2 point)
  RVA=0x0572A9E0  token=0x60002EB  Dest.Math.Segment2[] ToSegmentArray()
  RVA=0x0572AB24  token=0x60002EC  System.String ToString()
END_CLASS

CLASS: Dest.Math.Ray2
TYPE:  sealed struct
TOKEN: 0x200006E
SIZE:  0x20
FIELDS:
  public            UnityEngine.Vector2             Center  // 0x10
  public            UnityEngine.Vector2             Direction  // 0x18
METHODS:
  RVA=0x03D54650  token=0x60002ED  System.Void .ctor(UnityEngine.Vector2& center, UnityEngine.Vector2& direction)
  RVA=0x03D4EA10  token=0x60002EE  System.Void .ctor(UnityEngine.Vector2 center, UnityEngine.Vector2 direction)
  RVA=0x05725F98  token=0x60002EF  UnityEngine.Vector2 Eval(System.Single t)
  RVA=0x0572B1F0  token=0x60002F0  System.Single DistanceTo(UnityEngine.Vector2 point)
  RVA=0x0572B210  token=0x60002F1  UnityEngine.Vector2 Project(UnityEngine.Vector2 point)
  RVA=0x0572B240  token=0x60002F2  System.String ToString()
END_CLASS

CLASS: Dest.Math.Segment2
TYPE:  sealed struct
TOKEN: 0x200006F
SIZE:  0x34
FIELDS:
  public            UnityEngine.Vector2             P0  // 0x10
  public            UnityEngine.Vector2             P1  // 0x18
  public            UnityEngine.Vector2             Center  // 0x20
  public            UnityEngine.Vector2             Direction  // 0x28
  public            System.Single                   Extent  // 0x30
METHODS:
  RVA=0x0572B6EC  token=0x60002F3  System.Void .ctor(UnityEngine.Vector2& p0, UnityEngine.Vector2& p1)
  RVA=0x0572B6A8  token=0x60002F4  System.Void .ctor(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1)
  RVA=0x0572B72C  token=0x60002F5  System.Void .ctor(UnityEngine.Vector2& center, UnityEngine.Vector2& direction, System.Single extent)
  RVA=0x0572B6C4  token=0x60002F6  System.Void .ctor(UnityEngine.Vector2 center, UnityEngine.Vector2 direction, System.Single extent)
  RVA=0x0572B500  token=0x60002F7  System.Void SetEndpoints(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1)
  RVA=0x0572B4EC  token=0x60002F8  System.Void SetCenterDirectionExtent(UnityEngine.Vector2 center, UnityEngine.Vector2 direction, System.Single extent)
  RVA=0x0572B2D8  token=0x60002F9  System.Void CalcCenterDirectionExtent()
  RVA=0x0572B3B8  token=0x60002FA  System.Void CalcEndPoints()
  RVA=0x0572B470  token=0x60002FB  UnityEngine.Vector2 Eval(System.Single s)
  RVA=0x0572B450  token=0x60002FC  System.Single DistanceTo(UnityEngine.Vector2 point)
  RVA=0x0572B4BC  token=0x60002FD  UnityEngine.Vector2 Project(UnityEngine.Vector2 point)
  RVA=0x0572B510  token=0x60002FE  System.String ToString()
END_CLASS

CLASS: Dest.Math.Triangle2
TYPE:  sealed struct
TOKEN: 0x2000070
SIZE:  0x28
FIELDS:
  public            UnityEngine.Vector2             V0  // 0x10
  public            UnityEngine.Vector2             V1  // 0x18
  public            UnityEngine.Vector2             V2  // 0x20
PROPERTIES:
  Item  get=0x0572C6A8  set=0x0572C6E8
METHODS:
  RVA=0x03D54D00  token=0x6000301  System.Void .ctor(UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2)
  RVA=0x03D54CF0  token=0x6000302  System.Void .ctor(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2)
  RVA=0x0572BF64  token=0x6000303  UnityEngine.Vector2 CalcEdge(System.Int32 edgeIndex)
  RVA=0x03D54C90  token=0x6000304  System.Single CalcDeterminant()
  RVA=0x0572BFD8  token=0x6000305  Dest.Math.Orientations CalcOrientation(System.Single threshold)
  RVA=0x0572BD28  token=0x6000306  System.Single CalcArea()
  RVA=0x03D54B80  token=0x6000307  System.Single CalcArea(UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2)
  RVA=0x03D54BF0  token=0x6000308  System.Single CalcArea(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2)
  RVA=0x0572B8E4  token=0x6000309  UnityEngine.Vector3 CalcAnglesDeg()
  RVA=0x0572B790  token=0x600030A  UnityEngine.Vector3 CalcAnglesDeg(UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2)
  RVA=0x0572BA38  token=0x600030B  UnityEngine.Vector3 CalcAnglesDeg(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2)
  RVA=0x0572BBF8  token=0x600030C  UnityEngine.Vector3 CalcAnglesRad()
  RVA=0x0572BAC8  token=0x600030D  UnityEngine.Vector3 CalcAnglesRad(UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2)
  RVA=0x0572BA80  token=0x600030E  UnityEngine.Vector3 CalcAnglesRad(UnityEngine.Vector2 v0, UnityEngine.Vector2 v1, UnityEngine.Vector2 v2)
  RVA=0x0572C2CC  token=0x600030F  UnityEngine.Vector2 EvalBarycentric(System.Single c0, System.Single c1)
  RVA=0x0572C364  token=0x6000310  UnityEngine.Vector2 EvalBarycentric(UnityEngine.Vector3& baryCoords)
  RVA=0x0572C364  token=0x6000311  UnityEngine.Vector2 EvalBarycentric(UnityEngine.Vector3 baryCoords)
  RVA=0x0572BD80  token=0x6000312  System.Void CalcBarycentricCoords(UnityEngine.Vector2& point, UnityEngine.Vector2& v0, UnityEngine.Vector2& v1, UnityEngine.Vector2& v2, UnityEngine.Vector3& baryCoords)
  RVA=0x0572BD48  token=0x6000313  UnityEngine.Vector3 CalcBarycentricCoords(UnityEngine.Vector2& point)
  RVA=0x0572BF28  token=0x6000314  UnityEngine.Vector3 CalcBarycentricCoords(UnityEngine.Vector2 point)
  RVA=0x0572C2AC  token=0x6000315  System.Single DistanceTo(UnityEngine.Vector2 point)
  RVA=0x0572C410  token=0x6000316  System.Int32 QuerySideCCW(UnityEngine.Vector2 point, System.Single epsilon)
  RVA=0x0572C4F4  token=0x6000317  System.Int32 QuerySideCW(UnityEngine.Vector2 point, System.Single epsilon)
  RVA=0x0572C3E0  token=0x6000318  UnityEngine.Vector2 Project(UnityEngine.Vector2 point)
  RVA=0x0572C1B0  token=0x6000319  System.Boolean Contains(UnityEngine.Vector2& point)
  RVA=0x0572C290  token=0x600031A  System.Boolean Contains(UnityEngine.Vector2 point)
  RVA=0x0572C034  token=0x600031B  System.Boolean ContainsCCW(UnityEngine.Vector2& point)
  RVA=0x0572C018  token=0x600031C  System.Boolean ContainsCCW(UnityEngine.Vector2 point)
  RVA=0x0572C100  token=0x600031D  System.Boolean ContainsCW(UnityEngine.Vector2& point)
  RVA=0x0572C0E4  token=0x600031E  System.Boolean ContainsCW(UnityEngine.Vector2 point)
  RVA=0x0572C5E4  token=0x600031F  System.String ToString()
END_CLASS

CLASS: Dest.Math.AAB3
TYPE:  sealed struct
TOKEN: 0x2000071
SIZE:  0x28
FIELDS:
  public            UnityEngine.Vector3             Min  // 0x10
  public            UnityEngine.Vector3             Max  // 0x1c
METHODS:
  RVA=0x03D54810  token=0x6000320  System.Void .ctor(UnityEngine.Vector3& min, UnityEngine.Vector3& max)
  RVA=0x03D4FF30  token=0x6000321  System.Void .ctor(UnityEngine.Vector3 min, UnityEngine.Vector3 max)
  RVA=0x03D54830  token=0x6000322  System.Void .ctor(System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax, System.Single zMin, System.Single zMax)
  RVA=0x0571FE44  token=0x6000323  UnityEngine.Bounds op_Implicit(Dest.Math.AAB3 value)
  RVA=0x0571FDE0  token=0x6000324  Dest.Math.AAB3 op_Implicit(UnityEngine.Bounds value)
  RVA=0x03D547F0  token=0x6000325  Dest.Math.AAB3 CreateFromPoint(UnityEngine.Vector3& point)
  RVA=0x03D547F0  token=0x6000326  Dest.Math.AAB3 CreateFromPoint(UnityEngine.Vector3 point)
  RVA=0x0571FBA8  token=0x6000327  Dest.Math.AAB3 CreateFromTwoPoints(UnityEngine.Vector3& point0, UnityEngine.Vector3& point1)
  RVA=0x0571FB78  token=0x6000328  Dest.Math.AAB3 CreateFromTwoPoints(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1)
  RVA=0x0571F7C4  token=0x6000329  Dest.Math.AAB3 CreateFromPoints(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> points)
  RVA=0x0571F93C  token=0x600032A  Dest.Math.AAB3 CreateFromPoints(System.Collections.Generic.IList<UnityEngine.Vector3> points)
  RVA=0x0571FA8C  token=0x600032B  Dest.Math.AAB3 CreateFromPoints(UnityEngine.Vector3[] points)
  RVA=0x02A5CC00  token=0x600032C  System.Void CalcCenterExtents(UnityEngine.Vector3& center, UnityEngine.Vector3& extents)
  RVA=0x03D546D0  token=0x600032D  System.Void CalcVertices(UnityEngine.Vector3& vertex0, UnityEngine.Vector3& vertex1, UnityEngine.Vector3& vertex2, UnityEngine.Vector3& vertex3, UnityEngine.Vector3& vertex4, UnityEngine.Vector3& vertex5, UnityEngine.Vector3& vertex6, UnityEngine.Vector3& vertex7)
  RVA=0x0571F5D0  token=0x600032E  UnityEngine.Vector3[] CalcVertices()
  RVA=0x0571F454  token=0x600032F  System.Void CalcVertices(UnityEngine.Vector3[] array)
  RVA=0x03D547C0  token=0x6000330  System.Single CalcVolume()
  RVA=0x0571FC20  token=0x6000331  System.Single DistanceTo(UnityEngine.Vector3 point)
  RVA=0x0571FD08  token=0x6000332  UnityEngine.Vector3 Project(UnityEngine.Vector3 point)
  RVA=0x0294A060  token=0x6000333  System.Boolean Contains(UnityEngine.Vector3& point)
  RVA=0x0571F77C  token=0x6000334  System.Boolean Contains(UnityEngine.Vector3 point)
  RVA=0x0571FC3C  token=0x6000335  System.Void Include(UnityEngine.Vector3& point)
  RVA=0x0571FC3C  token=0x6000336  System.Void Include(UnityEngine.Vector3 point)
  RVA=0x0571FCA0  token=0x6000337  System.Void Include(Dest.Math.AAB3& box)
  RVA=0x0571FCD4  token=0x6000338  System.Void Include(Dest.Math.AAB3 box)
  RVA=0x0571FD34  token=0x6000339  System.String ToString()
END_CLASS

CLASS: Dest.Math.Box3
TYPE:  sealed struct
TOKEN: 0x2000072
SIZE:  0x4C
FIELDS:
  public            UnityEngine.Vector3             Center  // 0x10
  public            UnityEngine.Vector3             Axis0  // 0x1c
  public            UnityEngine.Vector3             Axis1  // 0x28
  public            UnityEngine.Vector3             Axis2  // 0x34
  public            UnityEngine.Vector3             Extents  // 0x40
METHODS:
  RVA=0x03D54910  token=0x600033A  System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& axis0, UnityEngine.Vector3& axis1, UnityEngine.Vector3& axis2, UnityEngine.Vector3& extents)
  RVA=0x03D54970  token=0x600033B  System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 axis0, UnityEngine.Vector3 axis1, UnityEngine.Vector3 axis2, UnityEngine.Vector3 extents)
  RVA=0x0572320C  token=0x600033C  System.Void .ctor(Dest.Math.AAB3& box)
  RVA=0x02A5CB30  token=0x600033D  System.Void .ctor(Dest.Math.AAB3 box)
  RVA=0x05722294  token=0x600033E  Dest.Math.Box3 CreateFromPoints(System.Collections.Generic.IList<UnityEngine.Vector3> points)
  RVA=0x05722810  token=0x600033F  UnityEngine.Vector3 GetAxis(System.Int32 index)
  RVA=0x05721BA0  token=0x6000340  System.Void CalcVertices(UnityEngine.Vector3& vertex0, UnityEngine.Vector3& vertex1, UnityEngine.Vector3& vertex2, UnityEngine.Vector3& vertex3, UnityEngine.Vector3& vertex4, UnityEngine.Vector3& vertex5, UnityEngine.Vector3& vertex6, UnityEngine.Vector3& vertex7)
  RVA=0x05720FF8  token=0x6000341  UnityEngine.Vector3[] CalcVertices()
  RVA=0x057215E4  token=0x6000342  System.Void CalcVertices(UnityEngine.Vector3[] array)
  RVA=0x03D548F0  token=0x6000343  System.Single CalcVolume()
  RVA=0x057227F4  token=0x6000344  System.Single DistanceTo(UnityEngine.Vector3 point)
  RVA=0x0572301C  token=0x6000345  UnityEngine.Vector3 Project(UnityEngine.Vector3 point)
  RVA=0x057220E8  token=0x6000346  System.Boolean Contains(UnityEngine.Vector3& point)
  RVA=0x05722280  token=0x6000347  System.Boolean Contains(UnityEngine.Vector3 point)
  RVA=0x057228AC  token=0x6000348  System.Void Include(Dest.Math.Box3& box)
  RVA=0x05723008  token=0x6000349  System.Void Include(Dest.Math.Box3 box)
  RVA=0x05723048  token=0x600034A  System.String ToString()
END_CLASS

CLASS: Dest.Math.Capsule3
TYPE:  sealed struct
TOKEN: 0x2000073
SIZE:  0x48
FIELDS:
  public            Dest.Math.Segment3              Segment  // 0x10
  public            System.Single                   Radius  // 0x44
METHODS:
  RVA=0x03D54D40  token=0x600034B  System.Void .ctor(Dest.Math.Segment3& segment, System.Single radius)
  RVA=0x03D54D70  token=0x600034C  System.Void .ctor(Dest.Math.Segment3 segment, System.Single radius)
END_CLASS

CLASS: Dest.Math.Circle3
TYPE:  sealed struct
TOKEN: 0x2000074
SIZE:  0x44
FIELDS:
  public            UnityEngine.Vector3             Center  // 0x10
  public            UnityEngine.Vector3             Axis0  // 0x1c
  public            UnityEngine.Vector3             Axis1  // 0x28
  public            UnityEngine.Vector3             Normal  // 0x34
  public            System.Single                   Radius  // 0x40
METHODS:
  RVA=0x0572E214  token=0x600034D  System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& axis0, UnityEngine.Vector3& axis1, System.Single radius)
  RVA=0x0572E308  token=0x600034E  System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 axis0, UnityEngine.Vector3 axis1, System.Single radius)
  RVA=0x0572E180  token=0x600034F  System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& normal, System.Single radius)
  RVA=0x0572E3E8  token=0x6000350  System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 normal, System.Single radius)
  RVA=0x0572D4C4  token=0x6000351  System.Boolean CreateCircumscribed(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.Circle3& circle)
  RVA=0x0572D864  token=0x6000352  System.Boolean CreateInscribed(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, Dest.Math.Circle3& circle)
  RVA=0x03D54DC0  token=0x6000353  System.Single CalcPerimeter()
  RVA=0x03D54DA0  token=0x6000354  System.Single CalcArea()
  RVA=0x0572DD60  token=0x6000355  UnityEngine.Vector3 Eval(System.Single t)
  RVA=0x0572DE78  token=0x6000356  UnityEngine.Vector3 Eval(System.Single t, System.Single radius)
  RVA=0x0572DD44  token=0x6000357  System.Single DistanceTo(UnityEngine.Vector3 point, System.Boolean solid)
  RVA=0x0572DF9C  token=0x6000358  UnityEngine.Vector3 Project(UnityEngine.Vector3 point, System.Boolean solid)
  RVA=0x0572DFCC  token=0x6000359  System.String ToString()
END_CLASS

CLASS: Dest.Math.Line3
TYPE:  sealed struct
TOKEN: 0x2000075
SIZE:  0x28
FIELDS:
  public            UnityEngine.Vector3             Center  // 0x10
  public            UnityEngine.Vector3             Direction  // 0x1c
METHODS:
  RVA=0x03D54810  token=0x600035A  System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& direction)
  RVA=0x03D4FF30  token=0x600035B  System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 direction)
  RVA=0x05731E78  token=0x600035C  Dest.Math.Line3 CreateFromTwoPoints(UnityEngine.Vector3& p0, UnityEngine.Vector3& p1)
  RVA=0x05731E78  token=0x600035D  Dest.Math.Line3 CreateFromTwoPoints(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1)
  RVA=0x05731F20  token=0x600035E  UnityEngine.Vector3 Eval(System.Single t)
  RVA=0x05731F04  token=0x600035F  System.Single DistanceTo(UnityEngine.Vector3 point)
  RVA=0x05731F9C  token=0x6000360  UnityEngine.Vector3 Project(UnityEngine.Vector3 point)
  RVA=0x05731DB0  token=0x6000361  System.Single AngleBetweenTwoLines(Dest.Math.Line3 anotherLine, System.Boolean acuteAngleDesired)
  RVA=0x05731FC8  token=0x6000362  System.String ToString()
END_CLASS

CLASS: Dest.Math.Plane3
TYPE:  sealed struct
TOKEN: 0x2000076
SIZE:  0x20
FIELDS:
  public            UnityEngine.Vector3             Normal  // 0x10
  public            System.Single                   Constant  // 0x1c
METHODS:
  RVA=0x02103850  token=0x6000363  System.Void .ctor(UnityEngine.Vector3& normal, System.Single constant)
  RVA=0x02103850  token=0x6000364  System.Void .ctor(UnityEngine.Vector3 normal, System.Single constant)
  RVA=0x05733DA4  token=0x6000365  System.Void .ctor(UnityEngine.Vector3& normal, UnityEngine.Vector3& point)
  RVA=0x05733D0C  token=0x6000366  System.Void .ctor(UnityEngine.Vector3 normal, UnityEngine.Vector3 point)
  RVA=0x05733F98  token=0x6000367  System.Void .ctor(UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, UnityEngine.Vector3& p2)
  RVA=0x05733E50  token=0x6000368  System.Void .ctor(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)
  RVA=0x057340E0  token=0x6000369  UnityEngine.Plane op_Implicit(Dest.Math.Plane3 value)
  RVA=0x03D54DD0  token=0x600036A  Dest.Math.Plane3 op_Implicit(UnityEngine.Plane value)
  RVA=0x05732AB0  token=0x600036B  UnityEngine.Vector3 CalcOrigin()
  RVA=0x05732AF4  token=0x600036C  System.Void CreateOrthonormalBasis(UnityEngine.Vector3& u, UnityEngine.Vector3& v, UnityEngine.Vector3& n)
  RVA=0x05733BD8  token=0x600036D  System.Single SignedDistanceTo(UnityEngine.Vector3& point)
  RVA=0x05733B48  token=0x600036E  System.Single SignedDistanceTo(UnityEngine.Vector3 point)
  RVA=0x05732BFC  token=0x600036F  System.Single DistanceTo(UnityEngine.Vector3 point)
  RVA=0x05733A80  token=0x6000370  System.Int32 QuerySide(UnityEngine.Vector3 point, System.Single epsilon)
  RVA=0x05733074  token=0x6000371  System.Boolean QuerySideNegative(UnityEngine.Vector3 point, System.Single epsilon)
  RVA=0x057333BC  token=0x6000372  System.Boolean QuerySidePositive(UnityEngine.Vector3 point, System.Single epsilon)
  RVA=0x057338B8  token=0x6000373  System.Int32 QuerySide(Dest.Math.Box3& box, System.Single epsilon)
  RVA=0x05732DC0  token=0x6000374  System.Boolean QuerySideNegative(Dest.Math.Box3& box, System.Single epsilon)
  RVA=0x05733468  token=0x6000375  System.Boolean QuerySidePositive(Dest.Math.Box3& box, System.Single epsilon)
  RVA=0x05733700  token=0x6000376  System.Int32 QuerySide(Dest.Math.AAB3& box, System.Single epsilon)
  RVA=0x05732F68  token=0x6000377  System.Boolean QuerySideNegative(Dest.Math.AAB3& box, System.Single epsilon)
  RVA=0x057332A8  token=0x6000378  System.Boolean QuerySidePositive(Dest.Math.AAB3& box, System.Single epsilon)
  RVA=0x05733608  token=0x6000379  System.Int32 QuerySide(Dest.Math.Sphere3& sphere, System.Single epsilon)
  RVA=0x05733118  token=0x600037A  System.Boolean QuerySideNegative(Dest.Math.Sphere3& sphere, System.Single epsilon)
  RVA=0x057331E4  token=0x600037B  System.Boolean QuerySidePositive(Dest.Math.Sphere3& sphere, System.Single epsilon)
  RVA=0x05732D94  token=0x600037C  UnityEngine.Vector3 Project(UnityEngine.Vector3 point)
  RVA=0x05732C94  token=0x600037D  UnityEngine.Vector3 ProjectVector(UnityEngine.Vector3 vector)
  RVA=0x05732954  token=0x600037E  System.Single AngleBetweenPlaneNormalAndLine(Dest.Math.Line3 line)
  RVA=0x057328A8  token=0x600037F  System.Single AngleBetweenPlaneNormalAndLine(UnityEngine.Vector3 direction)
  RVA=0x057327E0  token=0x6000380  System.Single AngleBetweenPlaneAndLine(Dest.Math.Line3 line)
  RVA=0x05732724  token=0x6000381  System.Single AngleBetweenPlaneAndLine(UnityEngine.Vector3 direction)
  RVA=0x05732A0C  token=0x6000382  System.Single AngleBetweenTwoPlanes(Dest.Math.Plane3 anotherPlane)
  RVA=0x05733C74  token=0x6000383  System.String ToString()
END_CLASS

CLASS: Dest.Math.Edge3
TYPE:  sealed struct
TOKEN: 0x2000077
SIZE:  0x44
FIELDS:
  public            UnityEngine.Vector3             Point0  // 0x10
  public            UnityEngine.Vector3             Point1  // 0x1c
  public            UnityEngine.Vector3             Direction  // 0x28
  public            UnityEngine.Vector3             Normal  // 0x34
  public            System.Single                   Length  // 0x40
METHODS:
END_CLASS

CLASS: Dest.Math.Polygon3
TYPE:  class
TOKEN: 0x2000078
SIZE:  0x30
FIELDS:
  private           UnityEngine.Vector3[]           _vertices  // 0x10
  private           Dest.Math.Edge3[]               _edges  // 0x18
  private           Dest.Math.Plane3                _plane  // 0x20
PROPERTIES:
  Vertices  get=0x020B7B20
  Edges  get=0x01041090
  VertexCount  get=0x042746EC
  Item  get=0x05735A50  set=0x05735A7C
  Plane  get=0x03D54E00  set=0x03D54E10
METHODS:
  RVA=0x0350B670  token=0x600038B  System.Void .ctor()
  RVA=0x05735998  token=0x600038C  System.Void .ctor(UnityEngine.Vector3[] vertices, Dest.Math.Plane3 plane)
  RVA=0x05735908  token=0x600038D  System.Void .ctor(System.Int32 vertexCount, Dest.Math.Plane3 plane)
  RVA=0x0573510C  token=0x600038E  System.Void SetVertexProjected(System.Int32 vertexIndex, UnityEngine.Vector3 vertex)
  RVA=0x05734EAC  token=0x600038F  System.Void ProjectVertices()
  RVA=0x05734D4C  token=0x6000390  Dest.Math.Edge3 GetEdge(System.Int32 edgeIndex)
  RVA=0x05735700  token=0x6000391  System.Void UpdateEdges()
  RVA=0x05735528  token=0x6000392  System.Void UpdateEdge(System.Int32 edgeIndex)
  RVA=0x05734BB4  token=0x6000393  UnityEngine.Vector3 CalcCenter()
  RVA=0x05734CE4  token=0x6000394  System.Single CalcPerimeter()
  RVA=0x05734DA8  token=0x6000395  System.Boolean HasZeroCorners(System.Single threshold)
  RVA=0x05735020  token=0x6000396  System.Void ReverseVertices()
  RVA=0x05735230  token=0x6000397  Dest.Math.Segment3[] ToSegmentArray()
  RVA=0x05735388  token=0x6000398  System.String ToString()
END_CLASS

CLASS: Dest.Math.Ray3
TYPE:  sealed struct
TOKEN: 0x2000079
SIZE:  0x28
FIELDS:
  public            UnityEngine.Vector3             Center  // 0x10
  public            UnityEngine.Vector3             Direction  // 0x1c
METHODS:
  RVA=0x03D54810  token=0x6000399  System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& direction)
  RVA=0x03D4FF30  token=0x600039A  System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 direction)
  RVA=0x057369D4  token=0x600039B  UnityEngine.Ray op_Implicit(Dest.Math.Ray3 value)
  RVA=0x03D55160  token=0x600039C  Dest.Math.Ray3 op_Implicit(UnityEngine.Ray value)
  RVA=0x05731F20  token=0x600039D  UnityEngine.Vector3 Eval(System.Single t)
  RVA=0x057368E0  token=0x600039E  System.Single DistanceTo(UnityEngine.Vector3 point)
  RVA=0x057368FC  token=0x600039F  UnityEngine.Vector3 Project(UnityEngine.Vector3 point)
  RVA=0x05736928  token=0x60003A0  System.String ToString()
END_CLASS

CLASS: Dest.Math.Rectangle3
TYPE:  sealed struct
TOKEN: 0x200007A
SIZE:  0x48
FIELDS:
  public            UnityEngine.Vector3             Center  // 0x10
  public            UnityEngine.Vector3             Axis0  // 0x1c
  public            UnityEngine.Vector3             Axis1  // 0x28
  public            UnityEngine.Vector3             Normal  // 0x34
  public            UnityEngine.Vector2             Extents  // 0x40
METHODS:
  RVA=0x05737858  token=0x60003A1  System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& axis0, UnityEngine.Vector3& axis1, UnityEngine.Vector2& extents)
  RVA=0x05737778  token=0x60003A2  System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 axis0, UnityEngine.Vector3 axis1, UnityEngine.Vector2 extents)
  RVA=0x05737160  token=0x60003A3  Dest.Math.Rectangle3 CreateFromCCWPoints(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3)
  RVA=0x05737358  token=0x60003A4  Dest.Math.Rectangle3 CreateFromCWPoints(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3)
  RVA=0x05736C9C  token=0x60003A5  System.Void CalcVertices(UnityEngine.Vector3& vertex0, UnityEngine.Vector3& vertex1, UnityEngine.Vector3& vertex2, UnityEngine.Vector3& vertex3)
  RVA=0x05736EBC  token=0x60003A6  UnityEngine.Vector3[] CalcVertices()
  RVA=0x05736A28  token=0x60003A7  System.Void CalcVertices(UnityEngine.Vector3[] array)
  RVA=0x03D55190  token=0x60003A8  System.Single CalcArea()
  RVA=0x05737550  token=0x60003A9  System.Single DistanceTo(UnityEngine.Vector3 point)
  RVA=0x0573756C  token=0x60003AA  UnityEngine.Vector3 Project(UnityEngine.Vector3 point)
  RVA=0x05737598  token=0x60003AB  System.String ToString()
END_CLASS

CLASS: Dest.Math.Segment3
TYPE:  sealed struct
TOKEN: 0x200007B
SIZE:  0x44
FIELDS:
  public            UnityEngine.Vector3             P0  // 0x10
  public            UnityEngine.Vector3             P1  // 0x1c
  public            UnityEngine.Vector3             Center  // 0x28
  public            UnityEngine.Vector3             Direction  // 0x34
  public            System.Single                   Extent  // 0x40
METHODS:
  RVA=0x05737EB0  token=0x60003AC  System.Void .ctor(UnityEngine.Vector3& p0, UnityEngine.Vector3& p1)
  RVA=0x05737E50  token=0x60003AD  System.Void .ctor(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1)
  RVA=0x05737F70  token=0x60003AE  System.Void .ctor(UnityEngine.Vector3& center, UnityEngine.Vector3& direction, System.Single extent)
  RVA=0x05737F10  token=0x60003AF  System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 direction, System.Single extent)
  RVA=0x05737C74  token=0x60003B0  System.Void SetEndpoints(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1)
  RVA=0x05737C48  token=0x60003B1  System.Void SetCenterDirectionExtent(UnityEngine.Vector3 center, UnityEngine.Vector3 direction, System.Single extent)
  RVA=0x05737970  token=0x60003B2  System.Void CalcCenterDirectionExtent()
  RVA=0x05737A80  token=0x60003B3  System.Void CalcEndPoints()
  RVA=0x05737B7C  token=0x60003B4  UnityEngine.Vector3 Eval(System.Single s)
  RVA=0x05737B60  token=0x60003B5  System.Single DistanceTo(UnityEngine.Vector3 point)
  RVA=0x05737C1C  token=0x60003B6  UnityEngine.Vector3 Project(UnityEngine.Vector3 point)
  RVA=0x05737C9C  token=0x60003B7  System.String ToString()
END_CLASS

CLASS: Dest.Math.Sphere3
TYPE:  sealed struct
TOKEN: 0x200007C
SIZE:  0x20
FIELDS:
  private   static  System.Single                   _4div3mulPi  // const
  public            UnityEngine.Vector3             Center  // 0x10
  public            System.Single                   Radius  // 0x1c
METHODS:
  RVA=0x02103850  token=0x60003B8  System.Void .ctor(UnityEngine.Vector3& center, System.Single radius)
  RVA=0x02103850  token=0x60003B9  System.Void .ctor(UnityEngine.Vector3 center, System.Single radius)
  RVA=0x0573843C  token=0x60003BA  Dest.Math.Sphere3 CreateFromPointsAAB(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> points)
  RVA=0x05738364  token=0x60003BB  Dest.Math.Sphere3 CreateFromPointsAAB(System.Collections.Generic.IList<UnityEngine.Vector3> points)
  RVA=0x05738560  token=0x60003BC  Dest.Math.Sphere3 CreateFromPointsAverage(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> points)
  RVA=0x0573890C  token=0x60003BD  Dest.Math.Sphere3 CreateFromPointsAverage(System.Collections.Generic.IList<UnityEngine.Vector3> points)
  RVA=0x05738040  token=0x60003BE  System.Boolean CreateCircumscribed(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 v3, Dest.Math.Sphere3& sphere)
  RVA=0x05738B00  token=0x60003BF  System.Boolean CreateInscribed(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 v3, Dest.Math.Sphere3& sphere)
  RVA=0x03D551B0  token=0x60003C0  System.Single CalcArea()
  RVA=0x03D551D0  token=0x60003C1  System.Single CalcVolume()
  RVA=0x03D551F0  token=0x60003C2  UnityEngine.Vector3 Eval(System.Single theta, System.Single phi)
  RVA=0x05739128  token=0x60003C3  System.Single DistanceTo(UnityEngine.Vector3 point)
  RVA=0x057392A0  token=0x60003C4  UnityEngine.Vector3 Project(UnityEngine.Vector3 point)
  RVA=0x05737FD0  token=0x60003C5  System.Boolean Contains(UnityEngine.Vector3& point)
  RVA=0x05737FD0  token=0x60003C6  System.Boolean Contains(UnityEngine.Vector3 point)
  RVA=0x05739144  token=0x60003C7  System.Void Include(Dest.Math.Sphere3& sphere)
  RVA=0x0573928C  token=0x60003C8  System.Void Include(Dest.Math.Sphere3 sphere)
  RVA=0x057392CC  token=0x60003C9  System.String ToString()
END_CLASS

CLASS: Dest.Math.Triangle3
TYPE:  sealed struct
TOKEN: 0x200007D
SIZE:  0x34
FIELDS:
  public            UnityEngine.Vector3             V0  // 0x10
  public            UnityEngine.Vector3             V1  // 0x1c
  public            UnityEngine.Vector3             V2  // 0x28
PROPERTIES:
  Item  get=0x0573BFF0  set=0x0573C050
METHODS:
  RVA=0x03D552D0  token=0x60003CC  System.Void .ctor(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2)
  RVA=0x03D55290  token=0x60003CD  System.Void .ctor(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  RVA=0x0573BBB4  token=0x60003CE  UnityEngine.Vector3 CalcEdge(System.Int32 edgeIndex)
  RVA=0x0573BC78  token=0x60003CF  UnityEngine.Vector3 CalcNormal()
  RVA=0x0573B8A4  token=0x60003D0  System.Single CalcArea()
  RVA=0x0573B7E4  token=0x60003D1  System.Single CalcArea(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2)
  RVA=0x0573B7E4  token=0x60003D2  System.Single CalcArea(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  RVA=0x0573B350  token=0x60003D3  UnityEngine.Vector3 CalcAnglesDeg()
  RVA=0x0573B18C  token=0x60003D4  UnityEngine.Vector3 CalcAnglesDeg(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2)
  RVA=0x0573B31C  token=0x60003D5  UnityEngine.Vector3 CalcAnglesDeg(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  RVA=0x0573B67C  token=0x60003D6  UnityEngine.Vector3 CalcAnglesRad()
  RVA=0x0573B4DC  token=0x60003D7  UnityEngine.Vector3 CalcAnglesRad(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2)
  RVA=0x0573B648  token=0x60003D8  UnityEngine.Vector3 CalcAnglesRad(UnityEngine.Vector3 v0, UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  RVA=0x0573BE1C  token=0x60003D9  UnityEngine.Vector3 EvalBarycentric(System.Single c0, System.Single c1)
  RVA=0x0573BD2C  token=0x60003DA  UnityEngine.Vector3 EvalBarycentric(UnityEngine.Vector3& baryCoords)
  RVA=0x0573BD2C  token=0x60003DB  UnityEngine.Vector3 EvalBarycentric(UnityEngine.Vector3 baryCoords)
  RVA=0x0573B99C  token=0x60003DC  System.Void CalcBarycentricCoords(UnityEngine.Vector3& point, UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3& v2, UnityEngine.Vector3& baryCoords)
  RVA=0x0573B964  token=0x60003DD  UnityEngine.Vector3 CalcBarycentricCoords(UnityEngine.Vector3& point)
  RVA=0x0573B964  token=0x60003DE  UnityEngine.Vector3 CalcBarycentricCoords(UnityEngine.Vector3 point)
  RVA=0x0573BF14  token=0x60003DF  System.String ToString()
END_CLASS

CLASS: Dest.Math.Orientations
TYPE:  sealed struct
TOKEN: 0x200007E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Dest.Math.Orientations          CW  // const
  public    static  Dest.Math.Orientations          CCW  // const
  public    static  Dest.Math.Orientations          None  // const
METHODS:
END_CLASS

CLASS: Dest.Math.Query2
TYPE:  class
TOKEN: 0x200007F
SIZE:  0x18
EXTENDS: Dest.Math.Query
FIELDS:
  private   static  System.Single                   Zero  // static @ 0x0
  private           UnityEngine.Vector2[]           _vertices  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60003E0  System.Void .ctor(UnityEngine.Vector2[] vertices)
  RVA=0x05735E00  token=0x60003E1  System.Int32 ToLine(System.Int32 i, System.Int32 v0, System.Int32 v1)
  RVA=0x05735D0C  token=0x60003E2  System.Int32 ToLine(UnityEngine.Vector2& test, System.Int32 v0, System.Int32 v1)
  RVA=0x05735F00  token=0x60003E3  System.Int32 ToTriangle(System.Int32 i, System.Int32 v0, System.Int32 v1, System.Int32 v2)
  RVA=0x05735E58  token=0x60003E4  System.Int32 ToTriangle(UnityEngine.Vector2& test, System.Int32 v0, System.Int32 v1, System.Int32 v2)
  RVA=0x05735AB4  token=0x60003E5  System.Int32 ToCircumcircle(System.Int32 i, System.Int32 v0, System.Int32 v1, System.Int32 v2)
  RVA=0x05735B14  token=0x60003E6  System.Int32 ToCircumcircle(UnityEngine.Vector2& test, System.Int32 v0, System.Int32 v1, System.Int32 v2)
  RVA=0x03D54F00  token=0x60003E7  System.Single Dot(System.Single x0, System.Single y0, System.Single x1, System.Single y1)
  RVA=0x03D54E20  token=0x60003E8  System.Single Det2(System.Single x0, System.Single y0, System.Single x1, System.Single y1)
  RVA=0x03D54E40  token=0x60003E9  System.Single Det3(System.Single x0, System.Single y0, System.Single z0, System.Single x1, System.Single y1, System.Single z1, System.Single x2, System.Single y2, System.Single z2)
END_CLASS

CLASS: Dest.Math.Query3
TYPE:  class
TOKEN: 0x2000080
SIZE:  0x18
EXTENDS: Dest.Math.Query
FIELDS:
  private   static  System.Single                   Zero  // static @ 0x0
  private           UnityEngine.Vector3[]           _vertices  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x60003EA  System.Void .ctor(UnityEngine.Vector3[] vertices)
  RVA=0x0573635C  token=0x60003EB  System.Int32 ToPlane(System.Int32 i, System.Int32 v0, System.Int32 v1, System.Int32 v2)
  RVA=0x057363BC  token=0x60003EC  System.Int32 ToPlane(UnityEngine.Vector3& test, System.Int32 v0, System.Int32 v1, System.Int32 v2)
  RVA=0x05736578  token=0x60003ED  System.Int32 ToTetrahedron(System.Int32 i, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3)
  RVA=0x057365E0  token=0x60003EE  System.Int32 ToTetrahedron(UnityEngine.Vector3& test, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3)
  RVA=0x057362F4  token=0x60003EF  System.Int32 ToCircumsphere(System.Int32 i, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3)
  RVA=0x05735F60  token=0x60003F0  System.Int32 ToCircumsphere(UnityEngine.Vector3& test, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3)
  RVA=0x03D55140  token=0x60003F1  System.Single Dot(System.Single x0, System.Single y0, System.Single z0, System.Single x1, System.Single y1, System.Single z1)
  RVA=0x03D54E40  token=0x60003F2  System.Single Det3(System.Single x0, System.Single y0, System.Single z0, System.Single x1, System.Single y1, System.Single z1, System.Single x2, System.Single y2, System.Single z2)
  RVA=0x03D54F20  token=0x60003F3  System.Single Det4(System.Single x0, System.Single y0, System.Single z0, System.Single w0, System.Single x1, System.Single y1, System.Single z1, System.Single w1, System.Single x2, System.Single y2, System.Single z2, System.Single w2, System.Single x3, System.Single y3, System.Single z3, System.Single w3)
END_CLASS

CLASS: Dest.Math.QueryTypes
TYPE:  sealed struct
TOKEN: 0x2000081
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Dest.Math.QueryTypes            Int64  // const
  public    static  Dest.Math.QueryTypes            Integer  // const
  public    static  Dest.Math.QueryTypes            Rational  // const
  public    static  Dest.Math.QueryTypes            Real  // const
  public    static  Dest.Math.QueryTypes            Filtered  // const
METHODS:
END_CLASS

CLASS: Dest.Math.Query
TYPE:  class
TOKEN: 0x2000082
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x60003F4  System.Void .ctor()
  RVA=0x057368CC  token=0x60003F5  System.Boolean Sort(System.Int32& v0, System.Int32& v1)
  RVA=0x057366CC  token=0x60003F6  System.Boolean Sort(System.Int32& v0, System.Int32& v1, System.Int32& v2)
  RVA=0x0573673C  token=0x60003F7  System.Boolean Sort(System.Int32& v0, System.Int32& v1, System.Int32& v2, System.Int32& v3)
END_CLASS

CLASS: Dest.Math.CatmullRomSpline3
TYPE:  class
TOKEN: 0x2000083
SIZE:  0x48
EXTENDS: Dest.Math.SplineBase
FIELDS:
PROPERTIES:
  SplineType  get=0x03D4EB90  set=0x0572D454
METHODS:
  RVA=0x0572C900  token=0x60003FA  Dest.Math.CatmullRomSpline3 Create()
  RVA=0x0572C97C  token=0x60003FB  Dest.Math.CatmullRomSpline3 Create(System.Collections.Generic.IList<UnityEngine.Vector3> points, Dest.Math.SplineTypes type)
  RVA=0x0572CF68  token=0x60003FC  System.Void UpdateSegment(System.Int32 index)
  RVA=0x0572CE38  token=0x60003FD  System.Void UpdateAdjacentSegments(System.Int32 vertexIndex)
  RVA=0x0572C7D4  token=0x60003FE  System.Void AddVertexFirst(UnityEngine.Vector3 position)
  RVA=0x0572C808  token=0x60003FF  System.Void AddVertexLast(UnityEngine.Vector3 position)
  RVA=0x0572CD48  token=0x6000400  System.Void RemoveVertex(System.Int32 index)
  RVA=0x0572C8B4  token=0x6000401  System.Void Clear()
  RVA=0x0572CCA8  token=0x6000402  System.Void InsertBefore(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  RVA=0x0572CC04  token=0x6000403  System.Void InsertAfter(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  RVA=0x0572CB8C  token=0x6000404  UnityEngine.Vector3 GetVertex(System.Int32 vertexIndex)
  RVA=0x0572CDB0  token=0x6000405  System.Void SetVertex(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  RVA=0x0572D44C  token=0x6000406  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.CubicSpline3
TYPE:  class
TOKEN: 0x2000084
SIZE:  0x48
EXTENDS: Dest.Math.SplineBase
FIELDS:
PROPERTIES:
  SplineType  get=0x03D4EB90  set=0x05730100
METHODS:
  RVA=0x0572FBFC  token=0x6000409  Dest.Math.CubicSpline3 Create()
  RVA=0x0572FC78  token=0x600040A  Dest.Math.CubicSpline3 Create(System.Collections.Generic.IList<UnityEngine.Vector3> points, Dest.Math.SplineTypes type)
  RVA=0x0572E5A0  token=0x600040B  System.Void BuildSpline()
  RVA=0x0572F418  token=0x600040C  System.Void CreateOpenedSpline()
  RVA=0x0572E654  token=0x600040D  System.Void CreateClosedSpline()
  RVA=0x0572E47C  token=0x600040E  System.Void AddVertexFirst(UnityEngine.Vector3 position)
  RVA=0x0572E510  token=0x600040F  System.Void AddVertexLast(UnityEngine.Vector3 position)
  RVA=0x05730018  token=0x6000410  System.Void RemoveVertex(System.Int32 index)
  RVA=0x0572E608  token=0x6000411  System.Void Clear()
  RVA=0x0572FF78  token=0x6000412  System.Void InsertBefore(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  RVA=0x0572FED8  token=0x6000413  System.Void InsertAfter(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  RVA=0x0572FE60  token=0x6000414  UnityEngine.Vector3 GetVertex(System.Int32 vertexIndex)
  RVA=0x0573007C  token=0x6000415  System.Void SetVertex(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  RVA=0x0572D44C  token=0x6000416  System.Void .ctor()
END_CLASS

CLASS: Dest.Math.SplineTypes
TYPE:  sealed struct
TOKEN: 0x2000085
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Dest.Math.SplineTypes           Open  // const
  public    static  Dest.Math.SplineTypes           Closed  // const
METHODS:
END_CLASS

CLASS: Dest.Math.SplinePlaneTypes
TYPE:  sealed struct
TOKEN: 0x2000086
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Dest.Math.SplinePlaneTypes      XZ  // const
  public    static  Dest.Math.SplinePlaneTypes      XY  // const
  public    static  Dest.Math.SplinePlaneTypes      YZ  // const
METHODS:
END_CLASS

CLASS: Dest.Math.PositionTangent
TYPE:  sealed struct
TOKEN: 0x2000087
SIZE:  0x28
FIELDS:
  public            UnityEngine.Vector3             Position  // 0x10
  public            UnityEngine.Vector3             Tangent  // 0x1c
METHODS:
END_CLASS

CLASS: Dest.Math.CurveFrame
TYPE:  sealed struct
TOKEN: 0x2000088
SIZE:  0x40
FIELDS:
  public            UnityEngine.Vector3             Position  // 0x10
  public            UnityEngine.Vector3             Tangent  // 0x1c
  public            UnityEngine.Vector3             Normal  // 0x28
  public            UnityEngine.Vector3             Binormal  // 0x34
METHODS:
END_CLASS

CLASS: Dest.Math.SplineBase
TYPE:  abstract class
TOKEN: 0x2000089
SIZE:  0x48
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  protected         Dest.Math.SplineBase.ArcLengthParametrization_parametrization  // 0x18
  protected         System.Collections.Generic.List<Dest.Math.SplineBase.ItemData>_data  // 0x20
  protected         Dest.Math.SplineTypes           _type  // 0x28
  protected         System.Boolean                  _recalcSegmentsLength  // 0x2c
  protected         UnityEngine.Color               _renderColor  // 0x30
  protected         Dest.Math.SplinePlaneTypes      _creationPlane  // 0x40
PROPERTIES:
  SegmentCount  get=0x0573B0B8
  VertexCount  get=0x0573B14C
  Valid  get=0x0573B108
  SplineType  get=-1  // abstract  set=-1  // abstract
METHODS:
  RVA=0x05739364  token=0x600041C  System.Void Awake()
  RVA=0x0573B020  token=0x600041D  System.Void .ctor()
  RVA=0x0573A888  token=0x600041E  System.Void GetSegmentIndexAndTime(System.Single time, System.Int32& segmentIndex, System.Single& segmentTime)
  RVA=0x0573AEB8  token=0x600041F  System.Void PrepareForRuntime()
  RVA=0x0573AF4C  token=0x6000420  System.Void RecalcSegmentsLength()
  RVA=-1  // abstract  token=0x6000421  System.Void AddVertexFirst(UnityEngine.Vector3 position)
  RVA=-1  // abstract  token=0x6000422  System.Void AddVertexLast(UnityEngine.Vector3 position)
  RVA=-1  // abstract  token=0x6000423  System.Void RemoveVertex(System.Int32 index)
  RVA=-1  // abstract  token=0x6000424  System.Void Clear()
  RVA=-1  // abstract  token=0x6000425  System.Void InsertBefore(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  RVA=-1  // abstract  token=0x6000426  System.Void InsertAfter(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  RVA=-1  // abstract  token=0x6000427  UnityEngine.Vector3 GetVertex(System.Int32 vertexIndex)
  RVA=-1  // abstract  token=0x6000428  System.Void SetVertex(System.Int32 vertexIndex, UnityEngine.Vector3 position)
  RVA=0x0573A184  token=0x6000429  UnityEngine.Vector3 EvalPosition(System.Single time)
  RVA=0x0573A3C8  token=0x600042A  UnityEngine.Vector3 EvalTangent(System.Single time)
  RVA=0x05739FE8  token=0x600042B  Dest.Math.PositionTangent EvalPositionTangent(System.Single time)
  RVA=0x0573A0D0  token=0x600042C  System.Void EvalPosition(System.Single time, UnityEngine.Vector3& position)
  RVA=0x0573A47C  token=0x600042D  System.Void EvalTangent(System.Single time, UnityEngine.Vector3& tangent)
  RVA=0x05739F0C  token=0x600042E  System.Void EvalPositionTangent(System.Single time, Dest.Math.PositionTangent& positionTangent)
  RVA=0x05739960  token=0x600042F  System.Void EvalFrame(System.Single time, Dest.Math.CurveFrame& frame)
  RVA=0x0573959C  token=0x6000430  System.Single EvalCurvature(System.Single time)
  RVA=0x0573A6E8  token=0x6000431  System.Single EvalTorsion(System.Single time)
  RVA=0x05739B88  token=0x6000432  UnityEngine.Vector3 EvalPositionParametrized(System.Single length)
  RVA=0x0573A300  token=0x6000433  UnityEngine.Vector3 EvalTangentParametrized(System.Single length)
  RVA=0x05739D18  token=0x6000434  Dest.Math.PositionTangent EvalPositionTangentParametrized(System.Single length)
  RVA=0x05739C50  token=0x6000435  System.Void EvalPositionParametrized(System.Single length, UnityEngine.Vector3& position)
  RVA=0x0573A238  token=0x6000436  System.Void EvalTangentParametrized(System.Single length, UnityEngine.Vector3& tangent)
  RVA=0x05739E18  token=0x6000437  System.Void EvalPositionTangentParametrized(System.Single length, Dest.Math.PositionTangent& positionTangent)
  RVA=0x05739720  token=0x6000438  System.Void EvalFrameParametrized(System.Single length, Dest.Math.CurveFrame& frame)
  RVA=0x05739400  token=0x6000439  System.Single EvalCurvatureParametrized(System.Single length)
  RVA=0x0573A530  token=0x600043A  System.Single EvalTorsionParametrized(System.Single length)
  RVA=0x0573936C  token=0x600043B  System.Single CalcTotalLength()
  RVA=0x0573A940  token=0x600043C  System.Single LengthToTime(System.Single length, System.Int32 iterations, System.Single tolerance)
  RVA=0x0573A918  token=0x600043D  System.Single LengthToTime(System.Single length)
  RVA=0x0573AC08  token=0x600043E  System.Single ParametrizeByArcLength(System.Int32 pointCount)
END_CLASS

CLASS: Dest.Math.PointsFilter
TYPE:  static class
TOKEN: 0x200008C
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x05734278  token=0x600044D  System.Collections.Generic.List<System.Int32> DistanceFilter(UnityEngine.Vector3[] points, Dest.Math.AAB3 pointsAAB, System.Single radius, Dest.Math.Rand rand)
END_CLASS

CLASS: Dest.Math.PoissonDiskSampler
TYPE:  class
TOKEN: 0x200008E
SIZE:  0x78
FIELDS:
  private   static readonly System.Single                   one_div_sqrtTwo  // static @ 0x0
  private           Dest.Math.Rand                  _rand  // 0x10
  private           System.Collections.Generic.List<System.Int32>_activeList  // 0x18
  private           System.Collections.Generic.List<UnityEngine.Vector2>_points  // 0x20
  private           System.Nullable<System.Int32>[,]_grid  // 0x28
  private           System.Single                   _r  // 0x30
  private           System.Single                   _rSquared  // 0x34
  private           System.Single                   _rTwo  // 0x38
  private           System.Single                   _rMin  // 0x3c
  private           UnityEngine.Vector2             _min  // 0x40
  private           UnityEngine.Vector2             _max  // 0x48
  private           UnityEngine.Vector2             _size  // 0x50
  private           System.Single                   _cellSize  // 0x58
  private           System.Int32                    _cellsX  // 0x5c
  private           System.Int32                    _cellsY  // 0x60
  public            Dest.Math.PoissonDiskSampler.PointDelegateDistanceFilter  // 0x68
  public            System.Int32                    PointsPerStep  // 0x70
  private           System.Int32                    <MaxPoints>k__BackingField  // 0x74
PROPERTIES:
  MaxPoints  get=0x03D4F0D0  set=0x03D4F100
METHODS:
  RVA=0x0573491C  token=0x6000455  System.Void .cctor()
  RVA=0x0573496C  token=0x6000456  System.Void .ctor(Dest.Math.Rand rand, UnityEngine.Vector2 minCorner, UnityEngine.Vector2 maxCorner, System.Single minDistanceOuter, System.Single minDistanceInner)
  RVA=0x05734654  token=0x6000457  System.Void CalcGridIndices(UnityEngine.Vector2& point, System.Int32& i, System.Int32& j)
  RVA=0x05734680  token=0x6000458  System.Void InsertIntoGrid(UnityEngine.Vector2& point, System.Int32 index)
  RVA=0x0573432C  token=0x6000459  System.Boolean AddPoint(UnityEngine.Vector2& center)
  RVA=0x05734718  token=0x600045A  System.Collections.Generic.List<UnityEngine.Vector2> Sample()
END_CLASS

CLASS: Dest.Math.WeightedSampler
TYPE:  class
TOKEN: 0x2000090
SIZE:  0x28
FIELDS:
  protected         System.Single[]                 _accum  // 0x10
  protected         System.Single                   _total  // 0x18
  protected         Dest.Math.Rand                  _rand  // 0x20
METHODS:
  RVA=0x04271930  token=0x600045F  System.Void .ctor(Dest.Math.Rand rand)
  RVA=0x0573C094  token=0x6000460  System.Int32 BinarySearch(System.Single[] array, System.Single value)
  RVA=0x0573C268  token=0x6000461  System.Void .ctor(System.Single[] weights)
  RVA=0x0573C23C  token=0x6000462  System.Void .ctor(System.Single[] weights, Dest.Math.Rand rand)
  RVA=0x0573C100  token=0x6000463  System.Void Init(System.Single[] weights)
  RVA=0x0573C1FC  token=0x6000464  System.Int32 SampleIndex()
END_CLASS

CLASS: Dest.Math.TrianglesSamplerBase
TYPE:  class
TOKEN: 0x2000091
SIZE:  0x30
EXTENDS: Dest.Math.WeightedSampler
FIELDS:
  protected         UnityEngine.Vector3[]           _vertices  // 0x28
METHODS:
  RVA=0x04271930  token=0x6000465  System.Void .ctor(Dest.Math.Rand rand)
  RVA=0x03D55310  token=0x6000466  System.Single CalclTriangleArea(UnityEngine.Vector3& e0, UnityEngine.Vector3& e1)
END_CLASS

CLASS: Dest.Math.IndexedTrianglesSampler
TYPE:  class
TOKEN: 0x2000092
SIZE:  0x38
EXTENDS: Dest.Math.TrianglesSamplerBase
FIELDS:
  protected         System.Int32[]                  _indices  // 0x30
METHODS:
  RVA=0x0573143C  token=0x6000467  System.Void .ctor(UnityEngine.Vector3[] vertices, System.Int32[] indices)
  RVA=0x057314CC  token=0x6000468  System.Void .ctor(UnityEngine.Vector3[] vertices, System.Int32[] indices, Dest.Math.Rand rand)
  RVA=0x05731524  token=0x6000469  System.Void .ctor(UnityEngine.Mesh mesh)
  RVA=0x057315CC  token=0x600046A  System.Void .ctor(UnityEngine.Mesh mesh, Dest.Math.Rand rand)
  RVA=0x05730AD0  token=0x600046B  System.Void Init()
  RVA=0x05731330  token=0x600046C  UnityEngine.Vector3 Sample()
  RVA=0x057311C8  token=0x600046D  UnityEngine.Vector3[] SampleArray(System.Int32 count)
  RVA=0x05730E90  token=0x600046E  UnityEngine.Vector3[] SampleArray(System.Int32 count, UnityEngine.Vector2[] uvs, UnityEngine.Texture2D sampleMap, System.Single min, System.Single max)
END_CLASS

CLASS: Dest.Math.NonIndexedTrianglesSampler
TYPE:  class
TOKEN: 0x2000093
SIZE:  0x30
EXTENDS: Dest.Math.TrianglesSamplerBase
FIELDS:
METHODS:
  RVA=0x057326AC  token=0x600046F  System.Void .ctor(UnityEngine.Vector3[] vertices)
  RVA=0x05732598  token=0x6000470  System.Void .ctor(UnityEngine.Vector3[] vertices, Dest.Math.Rand rand)
  RVA=0x057325CC  token=0x6000471  System.Void .ctor(UnityEngine.Mesh mesh)
  RVA=0x05732658  token=0x6000472  System.Void .ctor(UnityEngine.Mesh mesh, Dest.Math.Rand rand)
  RVA=0x05732074  token=0x6000473  System.Void Init()
  RVA=0x057324CC  token=0x6000474  UnityEngine.Vector3 Sample()
  RVA=0x057323A8  token=0x6000475  UnityEngine.Vector3[] SampleArray(System.Int32 count)
END_CLASS

CLASS: Dest.Math.ShuffleBag`1
TYPE:  class
TOKEN: 0x2000094
IMPLEMENTS: System.Collections.Generic.IEnumerable`1 System.Collections.IEnumerable
FIELDS:
  private           Dest.Math.Rand                  _rand  // 0x0
  private           System.Collections.Generic.List<T>_items  // 0x0
  private           System.Int32                    _index  // 0x0
PROPERTIES:
  Count  get=-1  // not resolved
METHODS:
  RVA=-1  // not resolved  token=0x6000477  System.Void .ctor()
  RVA=-1  // not resolved  token=0x6000478  System.Void .ctor(System.Int32 capacity)
  RVA=-1  // not resolved  token=0x6000479  System.Void .ctor(Dest.Math.Rand rand)
  RVA=-1  // not resolved  token=0x600047A  System.Void .ctor(Dest.Math.Rand rand, System.Int32 capacity)
  RVA=-1  // not resolved  token=0x600047B  System.Void Add(T item, System.UInt32 count)
  RVA=-1  // not resolved  token=0x600047C  T NextItem()
  RVA=-1  // not resolved  token=0x600047D  System.Void Reset()
  RVA=-1  // not resolved  token=0x600047E  System.Void Clear()
  RVA=-1  // not resolved  token=0x600047F  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  RVA=-1  // not resolved  token=0x6000480  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Dest.Math.Util
TYPE:  static class
TOKEN: 0x2000096
SIZE:  0x10
FIELDS:
METHODS:
  RVA=-1  // generic def  token=0x6000487  System.Void Shuffle(System.Collections.Generic.IList<T> collection)
  RVA=-1  // generic def  token=0x6000488  System.Void Shuffle(System.Collections.Generic.IList<T> collection, Dest.Math.Rand rand)
  RVA=-1  // generic def  token=0x6000489  System.Void Shuffle(T[] collection)
  RVA=-1  // generic def  token=0x600048A  System.Void Shuffle(T[] collection, Dest.Math.Rand rand)
END_CLASS

