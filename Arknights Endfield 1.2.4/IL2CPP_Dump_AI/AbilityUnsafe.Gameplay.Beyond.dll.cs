// ========================================================
// Dumped by @desirepro
// Assembly: AbilityUnsafe.Gameplay.Beyond.dll
// Classes:  14
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

CLASS: KeyframeComparer
TYPE:  sealed struct
TOKEN: 0x2000005
SIZE:  0x11
IMPLEMENTS: System.Collections.Generic.IComparer`1
FIELDS:
METHODS:
  RVA=0x0231AF20  token=0x6000012  System.Int32 Compare(UnityEngine.Keyframe keyframe1, UnityEngine.Keyframe keyframe2)
END_CLASS

CLASS: ENPCUnionAnimationAbilityCommandType
TYPE:  sealed struct
TOKEN: 0x2000009
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.NPC.Ability.FNPCUnionAnimationAbilityCommand.ENPCUnionAnimationAbilityCommandTypeDoAnimatorStepBegin  // const
  public    static  Beyond.NPC.Ability.FNPCUnionAnimationAbilityCommand.ENPCUnionAnimationAbilityCommandTypeDoAnimatorStepEnd  // const
METHODS:
END_CLASS

CLASS: DoAnimatorStepEndParams
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x14
FIELDS:
  public            System.Single                   stepEndDegree  // 0x10
METHODS:
END_CLASS

CLASS: DoAnimatorUpdateStepBeginDegreeParams
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x14
FIELDS:
  public            System.Single                   stepBeginDegree  // 0x10
METHODS:
END_CLASS

CLASS: <m_pathPointQueue>e__FixedBuffer
TYPE:  sealed struct
TOKEN: 0x200000E
SIZE:  0x390
FIELDS:
  public            System.Single                   FixedElementField  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.FPtrAnimNativeCurve
TYPE:  sealed struct
TOKEN: 0x2000004
SIZE:  0x28
FIELDS:
  private           UnityEngine.Keyframe*           m_values  // 0x10
  private           System.Int32                    m_valuesLength  // 0x18
  private           UnityEngine.WrapMode            m_preWrapMode  // 0x1c
  private           UnityEngine.WrapMode            m_postWrapMode  // 0x20
  private   static  Beyond.FPtrAnimNativeCurve.KeyframeComparers_keyframeComparer  // static @ 0x0
  public    static readonly Unity.Mathematics.float4x4      CURVE_MATRIX  // static @ 0x4
  public    static readonly Unity.Mathematics.float3x3      CURVE_MATRIX_PRIME  // static @ 0x44
METHODS:
  RVA=0x04278130  token=0x6000003  System.Boolean IsValid()
  RVA=0x02CFC870  token=0x6000004  Unity.Collections.NativeArray<UnityEngine.Keyframe> CreateCurve(UnityEngine.AnimationCurve animationCurve, Unity.Collections.Allocator allocator)
  RVA=0x02CFC070  token=0x6000005  Unity.Collections.NativeArray<UnityEngine.Keyframe> CreateLine(System.Single val, Unity.Collections.Allocator allocator)
  RVA=0x042778AC  token=0x6000006  System.Single Evaluate(System.Single time)
  RVA=0x04277CC0  token=0x6000007  System.Int32 GetInsertionIndex(UnityEngine.Keyframe* keys, System.Int32 valuesLength, System.Single time)
  RVA=0x042782BC  token=0x6000008  System.Single WrapTime(System.Single time)
  RVA=0x042779D0  token=0x6000009  System.Single Evaluate(System.Single time, UnityEngine.Keyframe& keyframe, UnityEngine.Keyframe& nextKeyframe)
  RVA=0x04277810  token=0x600000A  System.Single CubicBezier(Unity.Mathematics.float4& curveMatrix, System.Single t)
  RVA=0x042777C8  token=0x600000B  System.Single CubicBezier(Unity.Mathematics.float3& curveMatrix, System.Single t)
  RVA=0x04277854  token=0x600000C  System.Single DeCasteljauBezier(System.Int32 degree, Unity.Mathematics.float4 coords, System.Single t)
  RVA=0x04277D24  token=0x600000D  System.Void GetTWithBisectionMethod(System.Single time, Unity.Mathematics.float4& curveXCoords, System.Single& t, System.Single& tBottom, System.Single& tTop, System.Single& diff)
  RVA=0x04277E8C  token=0x600000E  System.Void GetTWithNewtonMethod(System.Single time, Unity.Mathematics.float4& xCoords, Unity.Mathematics.float4& curveXCoords, System.Single& t, System.Single& tBottom, System.Single& tTop, System.Single& diff)
  RVA=0x04278170  token=0x600000F  System.Single UseNewtonMethod(Unity.Mathematics.float4 curveCoords, System.Single coord, System.Single t, Unity.Mathematics.float3 curvePrimeCoords, Unity.Mathematics.float4 primePrimeCoords, System.Single& coordAtT)
  RVA=0x04278138  token=0x6000010  System.Void UpdateTLimits(System.Single x, System.Single time, System.Single t, System.Single& tBottom, System.Single& tTop)
  RVA=0x038A4860  token=0x6000011  System.Void .cctor()
END_CLASS

CLASS: Beyond.FPtrNativeCurve
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x28
FIELDS:
  private           System.Single*                  m_values  // 0x10
  private           System.Int32                    m_valuesLength  // 0x18
  private           UnityEngine.WrapMode            m_preWrapMode  // 0x1c
  private           UnityEngine.WrapMode            m_postWrapMode  // 0x20
METHODS:
  RVA=0x04278130  token=0x6000013  System.Boolean IsValid()
  RVA=0x04278398  token=0x6000014  Unity.Collections.NativeArray<System.Single> CreateCurve(UnityEngine.AnimationCurve curve, System.Int32 resolution)
  RVA=0x0427856C  token=0x6000015  System.Single Evaluate(System.Single t)
  RVA=0x04277234  token=0x6000016  System.Single _Repeat(System.Single t, System.Single length)
  RVA=0x042786BC  token=0x6000017  System.Single _Pingpong(System.Single t, System.Single length)
END_CLASS

CLASS: Beyond.Gameplay.AbilityUnsafe.ENPCAbilityPathFollowStateType
TYPE:  sealed struct
TOKEN: 0x200000C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Gameplay.AbilityUnsafe.ENPCAbilityPathFollowStateTypeIdle  // const
  public    static  Beyond.Gameplay.AbilityUnsafe.ENPCAbilityPathFollowStateTypeMove  // const
  public    static  Beyond.Gameplay.AbilityUnsafe.ENPCAbilityPathFollowStateTypeMoveStop  // const
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.AbilityUnsafe.FNPCAbilityPathFollowFragment
TYPE:  sealed struct
TOKEN: 0x200000D
SIZE:  0x3F0
FIELDS:
  public    static  System.Int32                    TOTAL_POINT_CAPACITY  // const
  public    static  System.Int32                    ELEMENT_PER_POINT  // const
  private           Beyond.Gameplay.AbilityUnsafe.FNPCAbilityPathFollowFragment.<m_pathPointQueue>e__FixedBufferm_pathPointQueue  // 0x10
  private           System.Int32                    m_front  // 0x390
  private           System.Int32                    m_pointCount  // 0x394
  public            Beyond.Gameplay.AbilityUnsafe.ENPCAbilityPathFollowStateTypestate  // 0x398
  public            UnityEngine.Vector3             passedAim  // 0x39c
  public            System.Int32                    passedAimStyle  // 0x3a8
  public            System.Int32                    passedAimExtInfo  // 0x3ac
  public            System.Single                   passedAimSpeed  // 0x3b0
  public            System.Boolean                  passedPatrolActionPoint  // 0x3b4
  private           UnityEngine.Vector3             m_StartPos  // 0x3b8
  public            UnityEngine.Vector3             forward  // 0x3c4
  public            System.Single                   maxDistance  // 0x3d0
  public            System.Single                   progressDistance  // 0x3d4
  public            System.Boolean                  startMoveProcess  // 0x3d8
  public            System.Boolean                  bPathFollowEnd  // 0x3d9
  public            System.Single                   startMoveStopTime  // 0x3dc
  public            System.Int32                    loopCount  // 0x3e0
  public            System.Int32                    loopCountStartIndex  // 0x3e4
  public            System.Boolean                  bRetargetAim  // 0x3e8
  public            System.Boolean                  pathChanged  // 0x3e9
  private           System.Boolean                  m_passedPoint  // 0x3ea
  public            System.Single                   groundSlopeAngle  // 0x3ec
PROPERTIES:
  pointCount  get=0x03D4E230
  aim  get=0x04270088
  aimStyle  get=0x0427007C
  aimExtInfo  get=0x042777BC
  aimDesiredSpeed  get=0x042721A4
  startPos  get=0x03D4E240  set=0x03D4E260
METHODS:
  RVA=0x02983B50  token=0x6000022  System.Void Init()
  RVA=0x03D4E200  token=0x6000023  System.Void MarkPathFollowEnd()
  RVA=0x03D4E1D0  token=0x6000024  System.Void MarkMoveStop(System.Single time)
  RVA=0x042776D8  token=0x6000025  System.Void SetPathIsLoop(System.Boolean bIsLoop)
  RVA=0x024A1A90  token=0x6000026  System.Boolean GetPathIsLoop()
  RVA=0x0254C5C0  token=0x6000027  System.Boolean PushPoint(UnityEngine.Vector3 point, System.Int32 styleEnum, System.Int32 extPointInfo, System.Single desiredSpeed, System.Boolean patrolActionPoint)
  RVA=0x042774BC  token=0x6000028  System.Boolean PopPathPoint()
  RVA=0x0427779C  token=0x6000029  System.Boolean _RefreshScope()
  RVA=0x04277280  token=0x600002A  System.Void CalGroundSlope(UnityEngine.Vector3 curPos, UnityEngine.Vector3 steeringPos, System.Single speed, System.Single smoothTime)
  RVA=0x04277704  token=0x600002B  System.Single SlopeAngleDeg(UnityEngine.Vector3 pos, UnityEngine.Vector3 aim)
  RVA=0x042775D8  token=0x600002C  System.Boolean ReplaceLastPoint(UnityEngine.Vector3 point, System.Int32 styleEnum, System.Int32 extPointInfo, System.Single desiredSpeed)
  RVA=0x03D4E1B0  token=0x600002D  System.Void ClearAllPathPoints()
  RVA=0x024A1D60  token=0x600002E  UnityEngine.Vector3 GetPathPoint(System.Int32 idx)
  RVA=0x024A21E0  token=0x600002F  System.Int32 GetPathPointStyle(System.Int32 idx)
  RVA=0x04277404  token=0x6000030  System.Int32 GetPathPointExtInfo(System.Int32 idx)
  RVA=0x037B1860  token=0x6000031  System.Single GetPathPointDesiredSpeed(System.Int32 idx)
  RVA=0x042776A8  token=0x6000032  System.Void SetAimPointDesiredSpeed(System.Single speed)
  RVA=0x04277484  token=0x6000033  System.Boolean IsSubActionPoint(System.Int32 idx)
  RVA=0x04277478  token=0x6000034  System.Boolean IsPathFull()
  RVA=0x024A1A70  token=0x6000035  System.Int32 GetPointCount()
  RVA=0x024A1BD0  token=0x6000036  System.Single GetPathLength(UnityEngine.Vector3 currentLocation)
  RVA=0x042773F0  token=0x6000037  System.Int32 GetEffectPointCount()
  RVA=0x042773A4  token=0x6000038  System.Int32 FloatToInt32Bits(System.Single v)
  RVA=0x04277434  token=0x6000039  System.Single Int32BitsToFloat(System.Int32 v)
END_CLASS

CLASS: Beyond.NPC.Ability.NPCAbilityUnsafeUtils
TYPE:  class
TOKEN: 0x2000007
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000018  System.Void .ctor()
END_CLASS

CLASS: Beyond.NPC.Ability.FNPCUnionAnimationAbilityCommand
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x1014
FIELDS:
  public            Beyond.NPC.Ability.FNPCUnionAnimationAbilityCommand.ENPCUnionAnimationAbilityCommandTypecmdType  // 0x10
  public            Unity.Collections.FixedBytes4094Payload  // 0x14
METHODS:
  RVA=-1  // generic def  token=0x6000019  System.Void SetData(T& data)
  RVA=-1  // generic def  token=0x600001A  T GetData()
END_CLASS

CLASS: Microsoft.CodeAnalysis.EmbeddedAttribute
TYPE:  sealed class
TOKEN: 0x2000002
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000001  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsUnmanagedAttribute
TYPE:  sealed class
TOKEN: 0x2000003
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000002  System.Void .ctor()
END_CLASS

