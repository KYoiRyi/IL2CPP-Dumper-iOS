// ========================================================
// Dumped by @desirepro
// Assembly: clipper_library.dll
// Classes:  26
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

CLASS: ClipperLib.DoublePoint
TYPE:  sealed struct
TOKEN: 0x2000002
SIZE:  0x20
FIELDS:
  public            System.Double                   X  // 0x10
  public            System.Double                   Y  // 0x18
METHODS:
  RVA=0x03D50BD0  token=0x6000001  System.Void .ctor(System.Double x, System.Double y)
  RVA=0x03D50BC0  token=0x6000002  System.Void .ctor(ClipperLib.DoublePoint dp)
END_CLASS

CLASS: ClipperLib.PolyNode
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x40
FIELDS:
  private           ClipperLib.PolyNode             m_Parent  // 0x10
  private           System.Collections.Generic.List<ClipperLib.IntPoint>m_polygon  // 0x18
  private           System.Int32                    m_Index  // 0x20
  private           ClipperLib.JoinType             m_jointype  // 0x24
  private           ClipperLib.EndType              m_endtype  // 0x28
  private           System.Collections.Generic.List<ClipperLib.PolyNode>m_Childs  // 0x30
  private           System.Boolean                  <IsOpen>k__BackingField  // 0x38
PROPERTIES:
  ChildCount  get=0x05582648
  Childs  get=0x01003830
METHODS:
  RVA=0x05582500  token=0x6000004  System.Void AddChild(ClipperLib.PolyNode Child)
  RVA=0x05582588  token=0x6000006  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.Int128
TYPE:  sealed struct
TOKEN: 0x2000004
SIZE:  0x20
FIELDS:
  private           System.Int64                    hi  // 0x10
  private           System.UInt64                   lo  // 0x18
METHODS:
  RVA=0x03D50C00  token=0x6000007  System.Void .ctor(System.Int64 _hi, System.UInt64 _lo)
  RVA=0x05582314  token=0x6000008  System.Boolean op_Equality(ClipperLib.Int128 val1, ClipperLib.Int128 val2)
  RVA=0x055821E4  token=0x6000009  System.Boolean Equals(System.Object obj)
  RVA=0x03D50BE0  token=0x600000A  System.Int32 GetHashCode()
  RVA=0x055823AC  token=0x600000B  ClipperLib.Int128 op_UnaryNegation(ClipperLib.Int128 val)
  RVA=0x05582258  token=0x600000C  ClipperLib.Int128 Int128Mul(System.Int64 lhs, System.Int64 rhs)
END_CLASS

CLASS: ClipperLib.IntPoint
TYPE:  sealed struct
TOKEN: 0x2000005
SIZE:  0x20
FIELDS:
  public            System.Int64                    X  // 0x10
  public            System.Int64                    Y  // 0x18
METHODS:
  RVA=0x03D4EA10  token=0x600000D  System.Void .ctor(System.Int64 X, System.Int64 Y)
  RVA=0x03D50C10  token=0x600000E  System.Void .ctor(System.Double x, System.Double y)
  RVA=0x03D50BC0  token=0x600000F  System.Void .ctor(ClipperLib.IntPoint pt)
  RVA=0x0558249C  token=0x6000010  System.Boolean op_Equality(ClipperLib.IntPoint a, ClipperLib.IntPoint b)
  RVA=0x055824B4  token=0x6000011  System.Boolean op_Inequality(ClipperLib.IntPoint a, ClipperLib.IntPoint b)
  RVA=0x055823D8  token=0x6000012  System.Boolean Equals(System.Object obj)
  RVA=0x0558244C  token=0x6000013  System.Int32 GetHashCode()
END_CLASS

CLASS: ClipperLib.IntRect
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x30
FIELDS:
  public            System.Int64                    left  // 0x10
  public            System.Int64                    top  // 0x18
  public            System.Int64                    right  // 0x20
  public            System.Int64                    bottom  // 0x28
METHODS:
  RVA=0x03D4EA20  token=0x6000014  System.Void .ctor(System.Int64 l, System.Int64 t, System.Int64 r, System.Int64 b)
END_CLASS

CLASS: ClipperLib.ClipType
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ClipperLib.ClipType             ctIntersection  // const
  public    static  ClipperLib.ClipType             ctUnion  // const
  public    static  ClipperLib.ClipType             ctDifference  // const
  public    static  ClipperLib.ClipType             ctXor  // const
METHODS:
END_CLASS

CLASS: ClipperLib.PolyType
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ClipperLib.PolyType             ptSubject  // const
  public    static  ClipperLib.PolyType             ptClip  // const
METHODS:
END_CLASS

CLASS: ClipperLib.PolyFillType
TYPE:  sealed struct
TOKEN: 0x2000009
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ClipperLib.PolyFillType         pftEvenOdd  // const
  public    static  ClipperLib.PolyFillType         pftNonZero  // const
  public    static  ClipperLib.PolyFillType         pftPositive  // const
  public    static  ClipperLib.PolyFillType         pftNegative  // const
METHODS:
END_CLASS

CLASS: ClipperLib.JoinType
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ClipperLib.JoinType             jtSquare  // const
  public    static  ClipperLib.JoinType             jtRound  // const
  public    static  ClipperLib.JoinType             jtMiter  // const
METHODS:
END_CLASS

CLASS: ClipperLib.EndType
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ClipperLib.EndType              etClosedPolygon  // const
  public    static  ClipperLib.EndType              etClosedLine  // const
  public    static  ClipperLib.EndType              etOpenButt  // const
  public    static  ClipperLib.EndType              etOpenSquare  // const
  public    static  ClipperLib.EndType              etOpenRound  // const
METHODS:
END_CLASS

CLASS: ClipperLib.EdgeSide
TYPE:  sealed struct
TOKEN: 0x200000C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ClipperLib.EdgeSide             esLeft  // const
  public    static  ClipperLib.EdgeSide             esRight  // const
METHODS:
END_CLASS

CLASS: ClipperLib.Direction
TYPE:  sealed struct
TOKEN: 0x200000D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ClipperLib.Direction            dRightToLeft  // const
  public    static  ClipperLib.Direction            dLeftToRight  // const
METHODS:
END_CLASS

CLASS: ClipperLib.TEdge
TYPE:  class
TOKEN: 0x200000E
SIZE:  0xA8
FIELDS:
  private           ClipperLib.IntPoint             Bot  // 0x10
  private           ClipperLib.IntPoint             Curr  // 0x20
  private           ClipperLib.IntPoint             Top  // 0x30
  private           ClipperLib.IntPoint             Delta  // 0x40
  private           System.Double                   Dx  // 0x50
  private           ClipperLib.PolyType             PolyTyp  // 0x58
  private           ClipperLib.EdgeSide             Side  // 0x5c
  private           System.Int32                    WindDelta  // 0x60
  private           System.Int32                    WindCnt  // 0x64
  private           System.Int32                    WindCnt2  // 0x68
  private           System.Int32                    OutIdx  // 0x6c
  private           ClipperLib.TEdge                Next  // 0x70
  private           ClipperLib.TEdge                Prev  // 0x78
  private           ClipperLib.TEdge                NextInLML  // 0x80
  private           ClipperLib.TEdge                NextInAEL  // 0x88
  private           ClipperLib.TEdge                PrevInAEL  // 0x90
  private           ClipperLib.TEdge                NextInSEL  // 0x98
  private           ClipperLib.TEdge                PrevInSEL  // 0xa0
METHODS:
  RVA=0x0350B670  token=0x6000015  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.IntersectNode
TYPE:  class
TOKEN: 0x200000F
SIZE:  0x30
FIELDS:
  private           ClipperLib.TEdge                Edge1  // 0x10
  private           ClipperLib.TEdge                Edge2  // 0x18
  private           ClipperLib.IntPoint             Pt  // 0x20
METHODS:
  RVA=0x0350B670  token=0x6000016  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.MyIntersectNodeSort
TYPE:  class
TOKEN: 0x2000010
SIZE:  0x10
IMPLEMENTS: System.Collections.Generic.IComparer`1
FIELDS:
METHODS:
  RVA=0x055824CC  token=0x6000017  System.Int32 Compare(ClipperLib.IntersectNode node1, ClipperLib.IntersectNode node2)
  RVA=0x0350B670  token=0x6000018  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.LocalMinima
TYPE:  class
TOKEN: 0x2000011
SIZE:  0x30
FIELDS:
  private           System.Int64                    Y  // 0x10
  private           ClipperLib.TEdge                LeftBound  // 0x18
  private           ClipperLib.TEdge                RightBound  // 0x20
  private           ClipperLib.LocalMinima          Next  // 0x28
METHODS:
  RVA=0x0350B670  token=0x6000019  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.Scanbeam
TYPE:  class
TOKEN: 0x2000012
SIZE:  0x20
FIELDS:
  private           System.Int64                    Y  // 0x10
  private           ClipperLib.Scanbeam             Next  // 0x18
METHODS:
  RVA=0x0350B670  token=0x600001A  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.Maxima
TYPE:  class
TOKEN: 0x2000013
SIZE:  0x28
FIELDS:
  private           System.Int64                    X  // 0x10
  private           ClipperLib.Maxima               Next  // 0x18
  private           ClipperLib.Maxima               Prev  // 0x20
METHODS:
  RVA=0x0350B670  token=0x600001B  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.OutRec
TYPE:  class
TOKEN: 0x2000014
SIZE:  0x38
FIELDS:
  private           System.Int32                    Idx  // 0x10
  private           System.Boolean                  IsHole  // 0x14
  private           System.Boolean                  IsOpen  // 0x15
  private           ClipperLib.OutRec               FirstLeft  // 0x18
  private           ClipperLib.OutPt                Pts  // 0x20
  private           ClipperLib.OutPt                BottomPt  // 0x28
  private           ClipperLib.PolyNode             PolyNode  // 0x30
METHODS:
  RVA=0x0350B670  token=0x600001C  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.OutPt
TYPE:  class
TOKEN: 0x2000015
SIZE:  0x38
FIELDS:
  private           System.Int32                    Idx  // 0x10
  private           ClipperLib.IntPoint             Pt  // 0x18
  private           ClipperLib.OutPt                Next  // 0x28
  private           ClipperLib.OutPt                Prev  // 0x30
METHODS:
  RVA=0x0350B670  token=0x600001D  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.Join
TYPE:  class
TOKEN: 0x2000016
SIZE:  0x30
FIELDS:
  private           ClipperLib.OutPt                OutPt1  // 0x10
  private           ClipperLib.OutPt                OutPt2  // 0x18
  private           ClipperLib.IntPoint             OffPt  // 0x20
METHODS:
  RVA=0x0350B670  token=0x600001E  System.Void .ctor()
END_CLASS

CLASS: ClipperLib.ClipperBase
TYPE:  class
TOKEN: 0x2000017
SIZE:  0x48
FIELDS:
  private           ClipperLib.LocalMinima          m_MinimaList  // 0x10
  private           ClipperLib.LocalMinima          m_CurrentLM  // 0x18
  private           System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.TEdge>>m_edges  // 0x20
  private           ClipperLib.Scanbeam             m_Scanbeam  // 0x28
  private           System.Collections.Generic.List<ClipperLib.OutRec>m_PolyOuts  // 0x30
  private           ClipperLib.TEdge                m_ActiveEdges  // 0x38
  private           System.Boolean                  m_UseFullRange  // 0x40
  private           System.Boolean                  m_HasOpenPaths  // 0x41
  private           System.Boolean                  <PreserveCollinear>k__BackingField  // 0x42
PROPERTIES:
  PreserveCollinear  get=0x03D4F7A0  set=0x03D4F7C0
METHODS:
  RVA=0x055785B0  token=0x600001F  System.Boolean near_zero(System.Double val)
  RVA=0x03D50B50  token=0x6000022  System.Void Swap(System.Int64& val1, System.Int64& val2)
  RVA=0x055775A0  token=0x6000023  System.Boolean IsHorizontal(ClipperLib.TEdge e)
  RVA=0x05577EC4  token=0x6000024  System.Boolean SlopesEqual(ClipperLib.TEdge e1, ClipperLib.TEdge e2, System.Boolean UseFullRange)
  RVA=0x05577E10  token=0x6000025  System.Boolean SlopesEqual(ClipperLib.IntPoint pt1, ClipperLib.IntPoint pt2, ClipperLib.IntPoint pt3, System.Boolean UseFullRange)
  RVA=0x05577F78  token=0x6000026  System.Boolean SlopesEqual(ClipperLib.IntPoint pt1, ClipperLib.IntPoint pt2, ClipperLib.IntPoint pt3, ClipperLib.IntPoint pt4, System.Boolean UseFullRange)
  RVA=0x05578518  token=0x6000027  System.Void .ctor()
  RVA=0x05576B1C  token=0x6000028  System.Void Clear()
  RVA=0x05576DD4  token=0x6000029  System.Void DisposeLocalMinimaList()
  RVA=0x05577BC8  token=0x600002A  System.Void RangeTest(ClipperLib.IntPoint Pt, System.Boolean& useFullRange)
  RVA=0x055773B0  token=0x600002B  System.Void InitEdge(ClipperLib.TEdge e, ClipperLib.TEdge eNext, ClipperLib.TEdge ePrev, ClipperLib.IntPoint pt)
  RVA=0x05577338  token=0x600002C  System.Void InitEdge2(ClipperLib.TEdge e, ClipperLib.PolyType polyType)
  RVA=0x05576EB4  token=0x600002D  ClipperLib.TEdge FindNextLocMin(ClipperLib.TEdge E)
  RVA=0x0557764C  token=0x600002E  ClipperLib.TEdge ProcessBound(ClipperLib.TEdge E, System.Boolean LeftBoundIsForward)
  RVA=0x05575F7C  token=0x600002F  System.Boolean AddPath(System.Collections.Generic.List<ClipperLib.IntPoint> pg, ClipperLib.PolyType polyType, System.Boolean Closed)
  RVA=0x05576A58  token=0x6000030  System.Boolean AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> ppg, ClipperLib.PolyType polyType, System.Boolean closed)
  RVA=0x05577AF0  token=0x6000031  System.Boolean Pt2IsBetweenPt1AndPt3(ClipperLib.IntPoint pt1, ClipperLib.IntPoint pt2, ClipperLib.IntPoint pt3)
  RVA=0x05577C9C  token=0x6000032  ClipperLib.TEdge RemoveEdge(ClipperLib.TEdge e)
  RVA=0x05577DB8  token=0x6000033  System.Void SetDx(ClipperLib.TEdge e)
  RVA=0x055773F8  token=0x6000034  System.Void InsertLocalMinima(ClipperLib.LocalMinima newLm)
  RVA=0x055775BC  token=0x6000035  System.Boolean PopLocalMinima(System.Int64 Y, ClipperLib.LocalMinima& current)
  RVA=0x05577D94  token=0x6000036  System.Void ReverseHorizontal(ClipperLib.TEdge e)
  RVA=0x05577CFC  token=0x6000037  System.Void Reset()
  RVA=0x05576FDC  token=0x6000038  ClipperLib.IntRect GetBounds(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> paths)
  RVA=0x05577480  token=0x6000039  System.Void InsertScanbeam(System.Int64 Y)
  RVA=0x05577604  token=0x600003A  System.Boolean PopScanbeam(System.Int64& Y)
  RVA=0x02702DB0  token=0x600003B  System.Boolean LocalMinimaPending()
  RVA=0x05576C68  token=0x600003C  ClipperLib.OutRec CreateOutRec()
  RVA=0x05576E28  token=0x600003D  System.Void DisposeOutRec(System.Int32 index)
  RVA=0x055782D8  token=0x600003E  System.Void UpdateEdgeIntoAEL(ClipperLib.TEdge& e)
  RVA=0x0557803C  token=0x600003F  System.Void SwapPositionsInAEL(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2)
  RVA=0x05576D3C  token=0x6000040  System.Void DeleteFromAEL(ClipperLib.TEdge e)
END_CLASS

CLASS: ClipperLib.Clipper
TYPE:  class
TOKEN: 0x2000018
SIZE:  0x98
EXTENDS: ClipperLib.ClipperBase
FIELDS:
  private           ClipperLib.ClipType             m_ClipType  // 0x48
  private           ClipperLib.Maxima               m_Maxima  // 0x50
  private           ClipperLib.TEdge                m_SortedEdges  // 0x58
  private           System.Collections.Generic.List<ClipperLib.IntersectNode>m_IntersectList  // 0x60
  private           System.Collections.Generic.IComparer<ClipperLib.IntersectNode>m_IntersectNodeComparer  // 0x68
  private           System.Boolean                  m_ExecuteLocked  // 0x70
  private           ClipperLib.PolyFillType         m_ClipFillType  // 0x74
  private           ClipperLib.PolyFillType         m_SubjFillType  // 0x78
  private           System.Collections.Generic.List<ClipperLib.Join>m_Joins  // 0x80
  private           System.Collections.Generic.List<ClipperLib.Join>m_GhostJoins  // 0x88
  private           System.Boolean                  m_UsingPolyTree  // 0x90
  private           System.Boolean                  <ReverseSolution>k__BackingField  // 0x91
  private           System.Boolean                  <StrictlySimple>k__BackingField  // 0x92
PROPERTIES:
  ReverseSolution  get=0x03D50B80  set=0x03D50BA0
  StrictlySimple  get=0x03D50B90  set=0x03D50BB0
METHODS:
  RVA=0x05581FE8  token=0x6000041  System.Void .ctor(System.Int32 InitOptions)
  RVA=0x0557EBC0  token=0x6000042  System.Void InsertMaxima(System.Int64 X)
  RVA=0x0557CFA4  token=0x6000047  System.Boolean Execute(ClipperLib.ClipType clipType, System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> solution, ClipperLib.PolyFillType subjFillType, ClipperLib.PolyFillType clipFillType)
  RVA=0x0557CA60  token=0x6000048  System.Boolean ExecuteInternal()
  RVA=0x0557C3CC  token=0x6000049  System.Void DisposeAllPolyPts()
  RVA=0x0557B4F8  token=0x600004A  System.Void AddJoin(ClipperLib.OutPt Op1, ClipperLib.OutPt Op2, ClipperLib.IntPoint OffPt)
  RVA=0x0557B45C  token=0x600004B  System.Void AddGhostJoin(ClipperLib.OutPt Op, ClipperLib.IntPoint OffPt)
  RVA=0x0557E6CC  token=0x600004C  System.Void InsertLocalMinimaIntoAEL(System.Int64 botY)
  RVA=0x0557E550  token=0x600004D  System.Void InsertEdgeIntoAEL(ClipperLib.TEdge edge, ClipperLib.TEdge startEdge)
  RVA=0x0557C9AC  token=0x600004E  System.Boolean E2InsertsBeforeE1(ClipperLib.TEdge e1, ClipperLib.TEdge e2)
  RVA=0x0557F59C  token=0x600004F  System.Boolean IsEvenOddFillType(ClipperLib.TEdge edge)
  RVA=0x0557F574  token=0x6000050  System.Boolean IsEvenOddAltFillType(ClipperLib.TEdge edge)
  RVA=0x0557F458  token=0x6000051  System.Boolean IsContributing(ClipperLib.TEdge edge)
  RVA=0x05581A8C  token=0x6000052  System.Void SetWindingCount(ClipperLib.TEdge edge)
  RVA=0x0557B3B0  token=0x6000053  System.Void AddEdgeToSEL(ClipperLib.TEdge edge)
  RVA=0x05580928  token=0x6000054  System.Boolean PopEdgeFromSEL(ClipperLib.TEdge& e)
  RVA=0x0557C370  token=0x6000055  System.Void CopyAELToSEL()
  RVA=0x05581C9C  token=0x6000056  System.Void SwapPositionsInSEL(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2)
  RVA=0x0557B5AC  token=0x6000057  System.Void AddLocalMaxPoly(ClipperLib.TEdge e1, ClipperLib.TEdge e2, ClipperLib.IntPoint pt)
  RVA=0x0557B658  token=0x6000058  ClipperLib.OutPt AddLocalMinPoly(ClipperLib.TEdge e1, ClipperLib.TEdge e2, ClipperLib.IntPoint pt)
  RVA=0x0557B888  token=0x6000059  ClipperLib.OutPt AddOutPt(ClipperLib.TEdge e, ClipperLib.IntPoint pt)
  RVA=0x0557E13C  token=0x600005A  ClipperLib.OutPt GetLastOutPt(ClipperLib.TEdge e)
  RVA=0x0557E518  token=0x600005B  System.Boolean HorzSegmentsOverlap(System.Int64 seg1a, System.Int64 seg1b, System.Int64 seg2a, System.Int64 seg2b)
  RVA=0x0558199C  token=0x600005C  System.Void SetHoleState(ClipperLib.TEdge e, ClipperLib.OutRec outRec)
  RVA=0x0557E0B4  token=0x600005D  System.Double GetDx(ClipperLib.IntPoint pt1, ClipperLib.IntPoint pt2)
  RVA=0x0557D138  token=0x600005E  System.Boolean FirstIsBottomPt(ClipperLib.OutPt btmPt1, ClipperLib.OutPt btmPt2)
  RVA=0x0557DFC0  token=0x600005F  ClipperLib.OutPt GetBottomPt(ClipperLib.OutPt pp)
  RVA=0x0557E1BC  token=0x6000060  ClipperLib.OutRec GetLowermostRec(ClipperLib.OutRec outRec1, ClipperLib.OutRec outRec2)
  RVA=0x05580540  token=0x6000061  System.Boolean OutRec1RightOfOutRec2(ClipperLib.OutRec outRec1, ClipperLib.OutRec outRec2)
  RVA=0x0557E3B4  token=0x6000062  ClipperLib.OutRec GetOutRec(System.Int32 idx)
  RVA=0x0557BAD0  token=0x6000063  System.Void AppendPolygon(ClipperLib.TEdge e1, ClipperLib.TEdge e2)
  RVA=0x05581950  token=0x6000064  System.Void ReversePolyPtLinks(ClipperLib.OutPt pp)
  RVA=0x05581F4C  token=0x6000065  System.Void SwapSides(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2)
  RVA=0x05581C74  token=0x6000066  System.Void SwapPolyIndexes(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2)
  RVA=0x0557ECF0  token=0x6000067  System.Void IntersectEdges(ClipperLib.TEdge e1, ClipperLib.TEdge e2, ClipperLib.IntPoint pt)
  RVA=0x05581694  token=0x6000068  System.Void ProcessHorizontals()
  RVA=0x0557E0EC  token=0x6000069  System.Void GetHorzDirection(ClipperLib.TEdge HorzEdge, ClipperLib.Direction& Dir, System.Int64& Left, System.Int64& Right)
  RVA=0x05580EA4  token=0x600006A  System.Void ProcessHorizontal(ClipperLib.TEdge horzEdge)
  RVA=0x0557E384  token=0x600006B  ClipperLib.TEdge GetNextInAEL(ClipperLib.TEdge e, ClipperLib.Direction Direction)
  RVA=0x0557F5F8  token=0x600006C  System.Boolean IsMaxima(ClipperLib.TEdge e, System.Double Y)
  RVA=0x0557F5C4  token=0x600006D  System.Boolean IsIntermediate(ClipperLib.TEdge e, System.Double Y)
  RVA=0x0557E2D4  token=0x600006E  ClipperLib.TEdge GetMaximaPair(ClipperLib.TEdge e)
  RVA=0x0557E28C  token=0x600006F  ClipperLib.TEdge GetMaximaPairEx(ClipperLib.TEdge e)
  RVA=0x055817B8  token=0x6000070  System.Boolean ProcessIntersections(System.Int64 topY)
  RVA=0x0557BFC0  token=0x6000071  System.Void BuildIntersectList(System.Int64 topY)
  RVA=0x0557CA20  token=0x6000072  System.Boolean EdgesAdjacent(ClipperLib.IntersectNode inode)
  RVA=0x0557DAB0  token=0x6000073  System.Boolean FixupIntersectionOrder()
  RVA=0x055816E4  token=0x6000074  System.Void ProcessIntersectList()
  RVA=0x0557B2B0  token=0x6000075  System.Int64 Round(System.Double value)
  RVA=0x05581F74  token=0x6000076  System.Int64 TopX(ClipperLib.TEdge edge, System.Int64 currentY)
  RVA=0x0557F1AC  token=0x6000077  System.Void IntersectPoint(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2, ClipperLib.IntPoint& ip)
  RVA=0x055809B0  token=0x6000078  System.Void ProcessEdgesAtTopOfScanbeam(System.Int64 topY)
  RVA=0x0557C448  token=0x6000079  System.Void DoMaxima(ClipperLib.TEdge e)
  RVA=0x05580524  token=0x600007A  System.Boolean Orientation(System.Collections.Generic.List<ClipperLib.IntPoint> poly)
  RVA=0x05580584  token=0x600007B  System.Int32 PointCount(ClipperLib.OutPt pts)
  RVA=0x0557C1B4  token=0x600007C  System.Void BuildResult(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> polyg)
  RVA=0x0557DED0  token=0x600007D  System.Void FixupOutPolyline(ClipperLib.OutRec outrec)
  RVA=0x0557DCB0  token=0x600007E  System.Void FixupOutPolygon(ClipperLib.OutRec outRec)
  RVA=0x0557C8B0  token=0x600007F  ClipperLib.OutPt DupOutPt(ClipperLib.OutPt outPt, System.Boolean InsertAfter)
  RVA=0x0557E440  token=0x6000080  System.Boolean GetOverlap(System.Int64 a1, System.Int64 a2, System.Int64 b1, System.Int64 b2, System.Int64& Left, System.Int64& Right)
  RVA=0x0557F9CC  token=0x6000081  System.Boolean JoinHorz(ClipperLib.OutPt op1, ClipperLib.OutPt op1b, ClipperLib.OutPt op2, ClipperLib.OutPt op2b, ClipperLib.IntPoint Pt, System.Boolean DiscardLeft)
  RVA=0x0557FDBC  token=0x6000082  System.Boolean JoinPoints(ClipperLib.Join j, ClipperLib.OutRec outRec1, ClipperLib.OutRec outRec2)
  RVA=0x055805B0  token=0x6000083  System.Int32 PointInPolygon(ClipperLib.IntPoint pt, System.Collections.Generic.List<ClipperLib.IntPoint> path)
  RVA=0x05580788  token=0x6000084  System.Int32 PointInPolygon(ClipperLib.IntPoint pt, ClipperLib.OutPt op)
  RVA=0x055808C4  token=0x6000085  System.Boolean Poly2ContainsPoly1(ClipperLib.OutPt outPt1, ClipperLib.OutPt outPt2)
  RVA=0x0557D474  token=0x6000086  System.Void FixupFirstLefts1(ClipperLib.OutRec OldOutRec, ClipperLib.OutRec NewOutRec)
  RVA=0x0557D634  token=0x6000087  System.Void FixupFirstLefts2(ClipperLib.OutRec innerOutRec, ClipperLib.OutRec outerOutRec)
  RVA=0x0557D918  token=0x6000088  System.Void FixupFirstLefts3(ClipperLib.OutRec OldOutRec, ClipperLib.OutRec NewOutRec)
  RVA=0x05580568  token=0x6000089  ClipperLib.OutRec ParseFirstLeft(ClipperLib.OutRec FirstLeft)
  RVA=0x0557F620  token=0x600008A  System.Void JoinCommonEdges()
  RVA=0x05581FB8  token=0x600008B  System.Void UpdateOutPtIdxs(ClipperLib.OutRec outrec)
  RVA=0x0557C628  token=0x600008C  System.Void DoSimplePolygons()
  RVA=0x0557BE8C  token=0x600008D  System.Double Area(System.Collections.Generic.List<ClipperLib.IntPoint> poly)
  RVA=0x0557BE08  token=0x600008E  System.Double Area(ClipperLib.OutRec outRec)
  RVA=0x0557BE28  token=0x600008F  System.Double Area(ClipperLib.OutPt op)
END_CLASS

CLASS: ClipperLib.ClipperOffset
TYPE:  class
TOKEN: 0x2000019
SIZE:  0x88
FIELDS:
  private           System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>>m_destPolys  // 0x10
  private           System.Collections.Generic.List<ClipperLib.IntPoint>m_srcPoly  // 0x18
  private           System.Collections.Generic.List<ClipperLib.IntPoint>m_destPoly  // 0x20
  private           System.Collections.Generic.List<ClipperLib.DoublePoint>m_normals  // 0x28
  private           System.Double                   m_delta  // 0x30
  private           System.Double                   m_sinA  // 0x38
  private           System.Double                   m_sin  // 0x40
  private           System.Double                   m_cos  // 0x48
  private           System.Double                   m_miterLim  // 0x50
  private           System.Double                   m_StepsPerRad  // 0x58
  private           ClipperLib.IntPoint             m_lowest  // 0x60
  private           ClipperLib.PolyNode             m_polyNodes  // 0x70
  private           System.Double                   <ArcTolerance>k__BackingField  // 0x78
  private           System.Double                   <MiterLimit>k__BackingField  // 0x80
  private   static  System.Double                   two_pi  // const
  private   static  System.Double                   def_arc_tolerance  // const
PROPERTIES:
  ArcTolerance  get=0x03D4F6C0  set=0x03D4F710
  MiterLimit  get=0x03D50B60  set=0x03D50B70
METHODS:
  RVA=0x0557B2D4  token=0x6000094  System.Void .ctor(System.Double miterLimit, System.Double arcTolerance)
  RVA=0x05578B78  token=0x6000095  System.Void Clear()
  RVA=0x0557B2B0  token=0x6000096  System.Int64 Round(System.Double value)
  RVA=0x055785D0  token=0x6000097  System.Void AddPath(System.Collections.Generic.List<ClipperLib.IntPoint> path, ClipperLib.JoinType joinType, ClipperLib.EndType endType)
  RVA=0x05578A40  token=0x6000098  System.Void AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> paths, ClipperLib.JoinType joinType, ClipperLib.EndType endType)
  RVA=0x0557A9B4  token=0x6000099  System.Void FixOrientations()
  RVA=0x0557AB4C  token=0x600009A  ClipperLib.DoublePoint GetUnitNormal(ClipperLib.IntPoint pt1, ClipperLib.IntPoint pt2)
  RVA=0x05578D9C  token=0x600009B  System.Void DoOffset(System.Double delta)
  RVA=0x0557A6D8  token=0x600009C  System.Void Execute(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>>& solution, System.Double delta)
  RVA=0x0557AC28  token=0x600009D  System.Void OffsetPoint(System.Int32 j, System.Int32& k, ClipperLib.JoinType jointype)
  RVA=0x0557A2D8  token=0x600009E  System.Void DoSquare(System.Int32 j, System.Int32 k)
  RVA=0x05578BCC  token=0x600009F  System.Void DoMiter(System.Int32 j, System.Int32 k, System.Double r)
  RVA=0x05579F38  token=0x60000A0  System.Void DoRound(System.Int32 j, System.Int32 k)
END_CLASS

CLASS: ClipperLib.ClipperException
TYPE:  class
TOKEN: 0x200001A
SIZE:  0x90
EXTENDS: System.Exception
FIELDS:
METHODS:
  RVA=0x05582688  token=0x60000A1  System.Void .ctor(System.String description)
END_CLASS

