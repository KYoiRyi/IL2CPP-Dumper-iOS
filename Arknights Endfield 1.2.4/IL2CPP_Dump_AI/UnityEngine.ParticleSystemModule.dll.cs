// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.ParticleSystemModule.dll
// Classes:  65
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

CLASS: MainModule
TYPE:  sealed struct
TOKEN: 0x2000003
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
PROPERTIES:
  duration  get=0x04274AF0  set=0x04274AF8
  loop  get=0x09E14FA4  set=0x09E1543C
  startDelayMultiplier  get=0x09E15118  set=0x09E15574
  startLifetime  get=0x09E151A0  set=0x09E1560C
  startLifetimeMultiplier  get=0x09E15154  set=0x09E155C0
  startSpeed  get=0x09E1537C
  startSpeedMultiplier  get=0x09E15330  set=0x09E157E0
  startSizeMultiplier  get=0x09E152F4  set=0x09E15794
  startRotationMultiplier  get=0x09E15204  set=0x09E15664
  startRotationXMultiplier  get=0x09E15240  set=0x09E156B0
  startRotationYMultiplier  get=0x09E1527C  set=0x09E156FC
  startRotationZMultiplier  get=0x09E152B8  set=0x09E15748
  startColor  get=0x09E150AC  set=0x09E1551C
  gravityModifierMultiplier  get=0x09E14F68  set=0x09E153F0
  simulationSpace  get=0x09E15058  set=0x09E154D0
  simulationSpeed  get=0x09E15060  set=0x04271598
  scalingMode  get=0x09E1501C  set=0x04274AB8
  playOnAwake  get=0x09E14FE0  set=0x09E15488
  maxParticles  get=0x04274AB0  set=0x04274AC0
METHODS:
  RVA=0x042715A0  token=0x600008E  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
  RVA=0x03CFA570  token=0x60000B4  System.Single get_duration_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self)
  RVA=0x03CDDB50  token=0x60000B5  System.Void set_duration_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, System.Single value)
  RVA=0x09E14F70  token=0x60000B6  System.Boolean get_loop_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self)
  RVA=0x09E153F8  token=0x60000B7  System.Void set_loop_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, System.Boolean value)
  RVA=0x09E150E4  token=0x60000B8  System.Single get_startDelayMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self)
  RVA=0x09E15530  token=0x60000B9  System.Void set_startDelayMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, System.Single value)
  RVA=0x09E1515C  token=0x60000BA  System.Void get_startLifetime_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, UnityEngine.ParticleSystem.MinMaxCurve& ret)
  RVA=0x09E155C8  token=0x60000BB  System.Void set_startLifetime_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, UnityEngine.ParticleSystem.MinMaxCurve& value)
  RVA=0x09E15120  token=0x60000BC  System.Single get_startLifetimeMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self)
  RVA=0x09E1557C  token=0x60000BD  System.Void set_startLifetimeMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, System.Single value)
  RVA=0x09E15338  token=0x60000BE  System.Void get_startSpeed_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, UnityEngine.ParticleSystem.MinMaxCurve& ret)
  RVA=0x09E152FC  token=0x60000BF  System.Single get_startSpeedMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self)
  RVA=0x09E1579C  token=0x60000C0  System.Void set_startSpeedMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, System.Single value)
  RVA=0x09E152C0  token=0x60000C1  System.Single get_startSizeMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self)
  RVA=0x09E15750  token=0x60000C2  System.Void set_startSizeMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, System.Single value)
  RVA=0x09E151D0  token=0x60000C3  System.Single get_startRotationMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self)
  RVA=0x09E15620  token=0x60000C4  System.Void set_startRotationMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, System.Single value)
  RVA=0x09E1520C  token=0x60000C5  System.Single get_startRotationXMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self)
  RVA=0x09E1566C  token=0x60000C6  System.Void set_startRotationXMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, System.Single value)
  RVA=0x09E15248  token=0x60000C7  System.Single get_startRotationYMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self)
  RVA=0x09E156B8  token=0x60000C8  System.Void set_startRotationYMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, System.Single value)
  RVA=0x09E15284  token=0x60000C9  System.Single get_startRotationZMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self)
  RVA=0x09E15704  token=0x60000CA  System.Void set_startRotationZMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, System.Single value)
  RVA=0x09E15068  token=0x60000CB  System.Void get_startColor_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, UnityEngine.ParticleSystem.MinMaxGradient& ret)
  RVA=0x09E154D8  token=0x60000CC  System.Void set_startColor_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, UnityEngine.ParticleSystem.MinMaxGradient& value)
  RVA=0x09E14F34  token=0x60000CD  System.Single get_gravityModifierMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self)
  RVA=0x09E153AC  token=0x60000CE  System.Void set_gravityModifierMultiplier_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, System.Single value)
  RVA=0x09E15024  token=0x60000CF  UnityEngine.ParticleSystemSimulationSpace get_simulationSpace_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self)
  RVA=0x09E15490  token=0x60000D0  System.Void set_simulationSpace_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, UnityEngine.ParticleSystemSimulationSpace value)
  RVA=0x03288220  token=0x60000D1  System.Single get_simulationSpeed_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self)
  RVA=0x03294C20  token=0x60000D2  System.Void set_simulationSpeed_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, System.Single value)
  RVA=0x09E14FE8  token=0x60000D3  UnityEngine.ParticleSystemScalingMode get_scalingMode_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self)
  RVA=0x0304C6D0  token=0x60000D4  System.Void set_scalingMode_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, UnityEngine.ParticleSystemScalingMode value)
  RVA=0x09E14FAC  token=0x60000D5  System.Boolean get_playOnAwake_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self)
  RVA=0x09E15444  token=0x60000D6  System.Void set_playOnAwake_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, System.Boolean value)
  RVA=0x0304C640  token=0x60000D7  System.Int32 get_maxParticles_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self)
  RVA=0x0304C680  token=0x60000D8  System.Void set_maxParticles_Injected(UnityEngine.ParticleSystem.MainModule& _unity_self, System.Int32 value)
END_CLASS

CLASS: EmissionModule
TYPE:  sealed struct
TOKEN: 0x2000004
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
PROPERTIES:
  enabled  get=0x09E14EA4  set=0x09E14F2C
  rateOverTime  get=0x0304BFF0  set=0x04274AC8
  rateOverTimeMultiplier  get=0x09E14EE0
METHODS:
  RVA=0x042715A0  token=0x60000D9  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
  RVA=0x09E14E70  token=0x60000DF  System.Boolean get_enabled_Injected(UnityEngine.ParticleSystem.EmissionModule& _unity_self)
  RVA=0x09E14EE8  token=0x60000E0  System.Void set_enabled_Injected(UnityEngine.ParticleSystem.EmissionModule& _unity_self, System.Boolean value)
  RVA=0x0304C050  token=0x60000E1  System.Void get_rateOverTime_Injected(UnityEngine.ParticleSystem.EmissionModule& _unity_self, UnityEngine.ParticleSystem.MinMaxCurve& ret)
  RVA=0x0304C770  token=0x60000E2  System.Void set_rateOverTime_Injected(UnityEngine.ParticleSystem.EmissionModule& _unity_self, UnityEngine.ParticleSystem.MinMaxCurve& value)
  RVA=0x09E14EAC  token=0x60000E3  System.Single get_rateOverTimeMultiplier_Injected(UnityEngine.ParticleSystem.EmissionModule& _unity_self)
END_CLASS

CLASS: ShapeModule
TYPE:  sealed struct
TOKEN: 0x2000005
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
PROPERTIES:
  enabled  set=0x09E1974C
  shapeType  set=0x09E19878
  radius  set=0x09E19830
  mesh  set=0x09E197E4
  meshRenderer  set=0x09E19798
  skinnedMeshRenderer  set=0x09E198C4
  textureClipThreshold  set=0x09E1995C
  textureClipThresholdUpper  set=0x09E19910
METHODS:
  RVA=0x042715A0  token=0x60000E4  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
  RVA=0x09E19708  token=0x60000ED  System.Void set_enabled_Injected(UnityEngine.ParticleSystem.ShapeModule& _unity_self, System.Boolean value)
  RVA=0x09E19838  token=0x60000EE  System.Void set_shapeType_Injected(UnityEngine.ParticleSystem.ShapeModule& _unity_self, UnityEngine.ParticleSystemShapeType value)
  RVA=0x09E197EC  token=0x60000EF  System.Void set_radius_Injected(UnityEngine.ParticleSystem.ShapeModule& _unity_self, System.Single value)
  RVA=0x09E197A0  token=0x60000F0  System.Void set_mesh_Injected(UnityEngine.ParticleSystem.ShapeModule& _unity_self, UnityEngine.Mesh value)
  RVA=0x09E19754  token=0x60000F1  System.Void set_meshRenderer_Injected(UnityEngine.ParticleSystem.ShapeModule& _unity_self, UnityEngine.MeshRenderer value)
  RVA=0x09E19880  token=0x60000F2  System.Void set_skinnedMeshRenderer_Injected(UnityEngine.ParticleSystem.ShapeModule& _unity_self, UnityEngine.SkinnedMeshRenderer value)
  RVA=0x09E19918  token=0x60000F3  System.Void set_textureClipThreshold_Injected(UnityEngine.ParticleSystem.ShapeModule& _unity_self, System.Single value)
  RVA=0x09E198CC  token=0x60000F4  System.Void set_textureClipThresholdUpper_Injected(UnityEngine.ParticleSystem.ShapeModule& _unity_self, System.Single value)
END_CLASS

CLASS: CollisionModule
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
PROPERTIES:
  enabled  get=0x09E14E68
METHODS:
  RVA=0x042715A0  token=0x60000F5  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
  RVA=0x09E14E34  token=0x60000F7  System.Boolean get_enabled_Injected(UnityEngine.ParticleSystem.CollisionModule& _unity_self)
END_CLASS

CLASS: TriggerModule
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x60000F8  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: SubEmittersModule
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
PROPERTIES:
  subEmittersCount  get=0x09E199E0
METHODS:
  RVA=0x042715A0  token=0x60000F9  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
  RVA=0x09E199A4  token=0x60000FB  UnityEngine.ParticleSystem GetSubEmitterSystem(System.Int32 index)
  RVA=0x09E199AC  token=0x60000FC  System.Int32 get_subEmittersCount_Injected(UnityEngine.ParticleSystem.SubEmittersModule& _unity_self)
  RVA=0x09E19964  token=0x60000FD  UnityEngine.ParticleSystem GetSubEmitterSystem_Injected(UnityEngine.ParticleSystem.SubEmittersModule& _unity_self, System.Int32 index)
END_CLASS

CLASS: TextureSheetAnimationModule
TYPE:  sealed struct
TOKEN: 0x2000009
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x60000FE  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: Particle
TYPE:  sealed struct
TOKEN: 0x200000A
SIZE:  0x94
FIELDS:
  private           UnityEngine.Vector3             m_Position  // 0x10
  private           UnityEngine.Vector3             m_Velocity  // 0x1c
  private           UnityEngine.Vector3             m_AnimatedVelocity  // 0x28
  private           UnityEngine.Vector3             m_InitialVelocity  // 0x34
  private           UnityEngine.Vector3             m_AxisOfRotation  // 0x40
  private           UnityEngine.Vector3             m_Rotation  // 0x4c
  private           UnityEngine.Vector3             m_AngularVelocity  // 0x58
  private           UnityEngine.Vector3             m_StartSize  // 0x64
  private           UnityEngine.Color32             m_StartColor  // 0x70
  private           System.UInt32                   m_RandomSeed  // 0x74
  private           System.UInt32                   m_ParentRandomSeed  // 0x78
  private           System.Single                   m_Lifetime  // 0x7c
  private           System.Single                   m_StartLifetime  // 0x80
  private           System.Int32                    m_MeshIndex  // 0x84
  private           System.Single                   m_EmitAccumulator0  // 0x88
  private           System.Single                   m_EmitAccumulator1  // 0x8c
  private           System.UInt32                   m_Flags  // 0x90
PROPERTIES:
  lifetime  set=0x03D5B680
  position  set=0x03D56570
  velocity  set=0x03D56580
  remainingLifetime  set=0x03D5B680
  startLifetime  set=0x03D5BD20
  startColor  set=0x03D4F5A0
  randomSeed  set=0x03D50B40
  startSize  set=0x03D87F30
  rotation3D  set=0x09E196B8
  angularVelocity3D  set=0x09E19668
METHODS:
END_CLASS

CLASS: MinMaxCurve
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x30
FIELDS:
  private           UnityEngine.ParticleSystemCurveModem_Mode  // 0x10
  private           System.Single                   m_CurveMultiplier  // 0x14
  private           UnityEngine.AnimationCurve      m_CurveMin  // 0x18
  private           UnityEngine.AnimationCurve      m_CurveMax  // 0x20
  private           System.Single                   m_ConstantMin  // 0x28
  private           System.Single                   m_ConstantMax  // 0x2c
PROPERTIES:
  mode  get=0x03D85860
  curveMax  get=0x03D66B80
  curveMin  get=0x03D85A90
  constantMax  get=0x03D87EB0
  constantMin  get=0x03D85C60
  constant  get=0x03D87EB0  set=0x03D4F120
  curve  get=0x03D66B80
METHODS:
  RVA=0x0304C110  token=0x6000109  System.Void .ctor(System.Single constant)
  RVA=0x0304C0A0  token=0x6000112  UnityEngine.ParticleSystem.MinMaxCurve op_Implicit(System.Single constant)
END_CLASS

CLASS: MinMaxGradient
TYPE:  sealed struct
TOKEN: 0x200000C
SIZE:  0x48
FIELDS:
  private           UnityEngine.ParticleSystemGradientModem_Mode  // 0x10
  private           UnityEngine.Gradient            m_GradientMin  // 0x18
  private           UnityEngine.Gradient            m_GradientMax  // 0x20
  private           UnityEngine.Color               m_ColorMin  // 0x28
  private           UnityEngine.Color               m_ColorMax  // 0x38
PROPERTIES:
  colorMax  set=0x03D59E30
  colorMin  set=0x03D51D90
  color  get=0x03D87CE0  set=0x03D59E30
METHODS:
  RVA=0x09E157E8  token=0x6000113  System.Void .ctor(UnityEngine.Color color)
  RVA=0x09E15838  token=0x6000118  UnityEngine.ParticleSystem.MinMaxGradient op_Implicit(UnityEngine.Color color)
END_CLASS

CLASS: EmitParams
TYPE:  sealed struct
TOKEN: 0x200000D
SIZE:  0xA0
FIELDS:
  private           UnityEngine.ParticleSystem.Particlem_Particle  // 0x10
  private           System.Boolean                  m_PositionSet  // 0x94
  private           System.Boolean                  m_VelocitySet  // 0x95
  private           System.Boolean                  m_AxisOfRotationSet  // 0x96
  private           System.Boolean                  m_RotationSet  // 0x97
  private           System.Boolean                  m_AngularVelocitySet  // 0x98
  private           System.Boolean                  m_StartSizeSet  // 0x99
  private           System.Boolean                  m_StartColorSet  // 0x9a
  private           System.Boolean                  m_RandomSeedSet  // 0x9b
  private           System.Boolean                  m_StartLifetimeSet  // 0x9c
  private           System.Boolean                  m_MeshIndexSet  // 0x9d
  private           System.Boolean                  m_ApplyShapeToPosition  // 0x9e
METHODS:
END_CLASS

CLASS: Seed
TYPE:  sealed struct
TOKEN: 0x200000F
SIZE:  0x20
FIELDS:
  public            System.UInt32                   x  // 0x10
  public            System.UInt32                   y  // 0x14
  public            System.UInt32                   z  // 0x18
  public            System.UInt32                   w  // 0x1c
METHODS:
END_CLASS

CLASS: Seed4
TYPE:  sealed struct
TOKEN: 0x2000010
SIZE:  0x50
FIELDS:
  public            UnityEngine.ParticleSystem.PlaybackState.Seedx  // 0x10
  public            UnityEngine.ParticleSystem.PlaybackState.Seedy  // 0x20
  public            UnityEngine.ParticleSystem.PlaybackState.Seedz  // 0x30
  public            UnityEngine.ParticleSystem.PlaybackState.Seedw  // 0x40
METHODS:
END_CLASS

CLASS: Emission
TYPE:  sealed struct
TOKEN: 0x2000011
SIZE:  0x28
FIELDS:
  public            System.Single                   m_ParticleSpacing  // 0x10
  public            System.Single                   m_ToEmitAccumulator  // 0x14
  public            UnityEngine.ParticleSystem.PlaybackState.Seedm_Random  // 0x18
METHODS:
END_CLASS

CLASS: Initial
TYPE:  sealed struct
TOKEN: 0x2000012
SIZE:  0x50
FIELDS:
  public            UnityEngine.ParticleSystem.PlaybackState.Seed4m_Random  // 0x10
METHODS:
END_CLASS

CLASS: Shape
TYPE:  sealed struct
TOKEN: 0x2000013
SIZE:  0x6C
FIELDS:
  public            UnityEngine.ParticleSystem.PlaybackState.Seed4m_Random  // 0x10
  public            System.Single                   m_RadiusTimer  // 0x50
  public            System.Single                   m_RadiusTimerPrev  // 0x54
  public            System.Single                   m_ArcTimer  // 0x58
  public            System.Single                   m_ArcTimerPrev  // 0x5c
  public            System.Single                   m_MeshSpawnTimer  // 0x60
  public            System.Single                   m_MeshSpawnTimerPrev  // 0x64
  public            System.Int32                    m_OrderedMeshVertexIndex  // 0x68
METHODS:
END_CLASS

CLASS: Force
TYPE:  sealed struct
TOKEN: 0x2000014
SIZE:  0x50
FIELDS:
  public            UnityEngine.ParticleSystem.PlaybackState.Seed4m_Random  // 0x10
METHODS:
END_CLASS

CLASS: Collision
TYPE:  sealed struct
TOKEN: 0x2000015
SIZE:  0x50
FIELDS:
  public            UnityEngine.ParticleSystem.PlaybackState.Seed4m_Random  // 0x10
METHODS:
END_CLASS

CLASS: Noise
TYPE:  sealed struct
TOKEN: 0x2000016
SIZE:  0x14
FIELDS:
  public            System.Single                   m_ScrollOffset  // 0x10
METHODS:
END_CLASS

CLASS: Lights
TYPE:  sealed struct
TOKEN: 0x2000017
SIZE:  0x24
FIELDS:
  public            UnityEngine.ParticleSystem.PlaybackState.Seedm_Random  // 0x10
  public            System.Single                   m_ParticleEmissionCounter  // 0x20
METHODS:
END_CLASS

CLASS: Trail
TYPE:  sealed struct
TOKEN: 0x2000018
SIZE:  0x14
FIELDS:
  public            System.Single                   m_Timer  // 0x10
METHODS:
END_CLASS

CLASS: PlaybackState
TYPE:  sealed struct
TOKEN: 0x200000E
SIZE:  0x170
FIELDS:
  private           System.Single                   m_AccumulatedDt  // 0x10
  private           System.Single                   m_StartDelay  // 0x14
  private           System.Single                   m_PlaybackTime  // 0x18
  private           System.Int32                    m_RingBufferIndex  // 0x1c
  private           UnityEngine.ParticleSystem.PlaybackState.Emissionm_Emission  // 0x20
  private           UnityEngine.ParticleSystem.PlaybackState.Initialm_Initial  // 0x38
  private           UnityEngine.ParticleSystem.PlaybackState.Shapem_Shape  // 0x78
  private           UnityEngine.ParticleSystem.PlaybackState.Forcem_Force  // 0xd4
  private           UnityEngine.ParticleSystem.PlaybackState.Collisionm_Collision  // 0x114
  private           UnityEngine.ParticleSystem.PlaybackState.Noisem_Noise  // 0x154
  private           UnityEngine.ParticleSystem.PlaybackState.Lightsm_Lights  // 0x158
  private           UnityEngine.ParticleSystem.PlaybackState.Trailm_Trail  // 0x16c
METHODS:
END_CLASS

CLASS: Trails
TYPE:  sealed struct
TOKEN: 0x2000019
SIZE:  0x38
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.Vector4>positions  // 0x10
  private           System.Collections.Generic.List<System.Int32>frontPositions  // 0x18
  private           System.Collections.Generic.List<System.Int32>backPositions  // 0x20
  private           System.Collections.Generic.List<System.Int32>positionCounts  // 0x28
  private           System.Int32                    maxTrailCount  // 0x30
  private           System.Int32                    maxPositionsPerTrailCount  // 0x34
METHODS:
  RVA=0x09E199E8  token=0x6000119  System.Void Allocate()
END_CLASS

CLASS: VelocityOverLifetimeModule
TYPE:  sealed struct
TOKEN: 0x200001A
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x600011A  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: LimitVelocityOverLifetimeModule
TYPE:  sealed struct
TOKEN: 0x200001B
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x600011B  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: InheritVelocityModule
TYPE:  sealed struct
TOKEN: 0x200001C
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x600011C  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: LifetimeByEmitterSpeedModule
TYPE:  sealed struct
TOKEN: 0x200001D
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x600011D  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: ForceOverLifetimeModule
TYPE:  sealed struct
TOKEN: 0x200001E
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x600011E  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: ColorOverLifetimeModule
TYPE:  sealed struct
TOKEN: 0x200001F
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x600011F  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: ColorBySpeedModule
TYPE:  sealed struct
TOKEN: 0x2000020
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x6000120  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: SizeOverLifetimeModule
TYPE:  sealed struct
TOKEN: 0x2000021
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x6000121  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: SizeBySpeedModule
TYPE:  sealed struct
TOKEN: 0x2000022
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x6000122  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: RotationOverLifetimeModule
TYPE:  sealed struct
TOKEN: 0x2000023
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x6000123  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: RotationBySpeedModule
TYPE:  sealed struct
TOKEN: 0x2000024
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x6000124  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: ExternalForcesModule
TYPE:  sealed struct
TOKEN: 0x2000025
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x6000125  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: NoiseModule
TYPE:  sealed struct
TOKEN: 0x2000026
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x6000126  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: LightsModule
TYPE:  sealed struct
TOKEN: 0x2000027
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x6000127  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: TrailModule
TYPE:  sealed struct
TOKEN: 0x2000028
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x6000128  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: CustomDataModule
TYPE:  sealed struct
TOKEN: 0x2000029
SIZE:  0x18
FIELDS:
  private           UnityEngine.ParticleSystem      m_ParticleSystem  // 0x10
METHODS:
  RVA=0x042715A0  token=0x6000129  System.Void .ctor(UnityEngine.ParticleSystem particleSystem)
END_CLASS

CLASS: Array3
TYPE:  sealed struct
TOKEN: 0x2000040
SIZE:  0x28
FIELDS:
  private           System.Single*                  x  // 0x10
  private           System.Single*                  y  // 0x18
  private           System.Single*                  z  // 0x20
METHODS:
END_CLASS

CLASS: Array4
TYPE:  sealed struct
TOKEN: 0x2000041
SIZE:  0x30
FIELDS:
  private           System.Single*                  x  // 0x10
  private           System.Single*                  y  // 0x18
  private           System.Single*                  z  // 0x20
  private           System.Single*                  w  // 0x28
METHODS:
END_CLASS

CLASS: UnityEngine.ParticleSystem
TYPE:  sealed class
TOKEN: 0x2000002
SIZE:  0x18
EXTENDS: UnityEngine.Component
FIELDS:
PROPERTIES:
  startDelay  get=0x09E18FE0  set=0x09E194A0
  loop  get=0x09E18DBC  set=0x09E1929C
  playOnAwake  get=0x09E18E50  set=0x09E1930C
  duration  get=0x09E18C2C
  playbackSpeed  get=0x09E18E80  set=0x09E19344
  enableEmission  get=0x09E18C8C  set=0x09E19234
  emissionRate  get=0x09E18C5C  set=0x09E191D8
  startSpeed  get=0x09E19140  set=0x09E195B0
  startSize  get=0x09E19110  set=0x09E19580
  startColor  get=0x09E18F78  set=0x09E19424
  startRotation  get=0x09E190E0  set=0x09E19550
  startRotation3D  get=0x09E19040  set=0x09E19500
  startLifetime  get=0x09E19010  set=0x09E194D0
  gravityModifier  get=0x09E18CBC  set=0x09E1926C
  maxParticles  get=0x09E18DEC  set=0x09E192D4
  simulationSpace  get=0x09E18F48  set=0x09E193EC
  scalingMode  get=0x09E18F18  set=0x09E193B4
  automaticCullingEnabled  get=0x09E18C20
  isPlaying  get=0x09E18D54
  isEmitting  get=0x09E18CEC
  isStopped  get=0x09E18D88
  isPaused  get=0x09E18D20
  particleCount  get=0x09E18E1C
  time  get=0x09E19170  set=0x09E195E0
  randomSeed  get=0x09E18EE4  set=0x09E19374
  useAutoRandomSeed  get=0x09E191A4  set=0x09E19624
  proceduralSimulationSupported  get=0x09E18EB0
  main  get=0x02712100
  emission  get=0x02712100
  shape  get=0x02712100
  velocityOverLifetime  get=0x02712100
  limitVelocityOverLifetime  get=0x02712100
  inheritVelocity  get=0x02712100
  lifetimeByEmitterSpeed  get=0x02712100
  forceOverLifetime  get=0x02712100
  colorOverLifetime  get=0x02712100
  colorBySpeed  get=0x02712100
  sizeOverLifetime  get=0x02712100
  sizeBySpeed  get=0x02712100
  rotationOverLifetime  get=0x02712100
  rotationBySpeed  get=0x02712100
  externalForces  get=0x02712100
  noise  get=0x02712100
  collision  get=0x02712100
  trigger  get=0x02712100
  subEmitters  get=0x02712100
  textureSheetAnimation  get=0x02712100
  lights  get=0x02712100
  trails  get=0x02712100
  customData  get=0x02712100
METHODS:
  RVA=0x09E17E88  token=0x6000001  System.Void Emit(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity, System.Single size, System.Single lifetime, UnityEngine.Color32 color)
  RVA=0x09E17F90  token=0x6000002  System.Void Emit(UnityEngine.ParticleSystem.Particle particle)
  RVA=0x09E181B8  token=0x6000031  System.Single GetParticleCurrentSize(UnityEngine.ParticleSystem.Particle& particle)
  RVA=0x09E18184  token=0x6000032  UnityEngine.Vector3 GetParticleCurrentSize3D(UnityEngine.ParticleSystem.Particle& particle)
  RVA=0x09E1810C  token=0x6000033  UnityEngine.Color32 GetParticleCurrentColor(UnityEngine.ParticleSystem.Particle& particle)
  RVA=0x09E181FC  token=0x6000034  System.Int32 GetParticleMeshIndex(UnityEngine.ParticleSystem.Particle& particle)
  RVA=0x09E188A4  token=0x6000035  System.Void SetParticles(UnityEngine.ParticleSystem.Particle[] particles, System.Int32 size, System.Int32 offset)
  RVA=0x09E18888  token=0x6000036  System.Void SetParticles(UnityEngine.ParticleSystem.Particle[] particles, System.Int32 size)
  RVA=0x09E1882C  token=0x6000037  System.Void SetParticles(UnityEngine.ParticleSystem.Particle[] particles)
  RVA=0x09E187C8  token=0x6000038  System.Void SetParticlesWithNativeArray(System.IntPtr particles, System.Int32 particlesLength, System.Int32 size, System.Int32 offset)
  RVA=0x09E18908  token=0x6000039  System.Void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, System.Int32 size, System.Int32 offset)
  RVA=0x09E18860  token=0x600003A  System.Void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, System.Int32 size)
  RVA=0x09E1883C  token=0x600003B  System.Void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles)
  RVA=0x09E18370  token=0x600003C  System.Int32 GetParticles(UnityEngine.ParticleSystem.Particle[] particles, System.Int32 size, System.Int32 offset)
  RVA=0x09E183D4  token=0x600003D  System.Int32 GetParticles(UnityEngine.ParticleSystem.Particle[] particles, System.Int32 size)
  RVA=0x09E182A4  token=0x600003E  System.Int32 GetParticles(UnityEngine.ParticleSystem.Particle[] particles)
  RVA=0x09E18240  token=0x600003F  System.Int32 GetParticlesWithNativeArray(System.IntPtr particles, System.Int32 particlesLength, System.Int32 size, System.Int32 offset)
  RVA=0x09E18300  token=0x6000040  System.Int32 GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, System.Int32 size, System.Int32 offset)
  RVA=0x09E182D8  token=0x6000041  System.Int32 GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, System.Int32 size)
  RVA=0x09E182B4  token=0x6000042  System.Int32 GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles)
  RVA=0x09E186DC  token=0x6000043  System.Void SetCustomParticleData(System.Collections.Generic.List<UnityEngine.Vector4> customData, UnityEngine.ParticleSystemCustomData streamIndex)
  RVA=0x09E17FC0  token=0x6000044  System.Int32 GetCustomParticleData(System.Collections.Generic.List<UnityEngine.Vector4> customData, UnityEngine.ParticleSystemCustomData streamIndex)
  RVA=0x09E18434  token=0x6000045  UnityEngine.ParticleSystem.PlaybackState GetPlaybackState()
  RVA=0x09E189BC  token=0x6000046  System.Void SetPlaybackState(UnityEngine.ParticleSystem.PlaybackState playbackState)
  RVA=0x09E18470  token=0x6000047  System.Void GetTrailDataInternal(UnityEngine.ParticleSystem.Trails& trailData)
  RVA=0x09E184B4  token=0x6000048  UnityEngine.ParticleSystem.Trails GetTrails()
  RVA=0x09E1852C  token=0x6000049  System.Int32 GetTrails(UnityEngine.ParticleSystem.Trails& trailData)
  RVA=0x09E18A14  token=0x600004A  System.Void SetTrails(UnityEngine.ParticleSystem.Trails trailData)
  RVA=0x09E18A28  token=0x600004B  System.Void Simulate(System.Single t, System.Boolean withChildren, System.Boolean restart, System.Boolean fixedTimeStep)
  RVA=0x09E18AB4  token=0x600004C  System.Void Simulate(System.Single t, System.Boolean withChildren, System.Boolean restart)
  RVA=0x09E18A98  token=0x600004D  System.Void Simulate(System.Single t, System.Boolean withChildren)
  RVA=0x09E18A8C  token=0x600004E  System.Void Simulate(System.Single t)
  RVA=0x035A5250  token=0x600004F  System.Void Play(System.Boolean withChildren)
  RVA=0x04274AA4  token=0x6000050  System.Void Play()
  RVA=0x09E185E8  token=0x6000051  System.Void Pause(System.Boolean withChildren)
  RVA=0x09E185DC  token=0x6000052  System.Void Pause()
  RVA=0x03242240  token=0x6000053  System.Void Stop(System.Boolean withChildren, UnityEngine.ParticleSystemStopBehavior stopBehavior)
  RVA=0x09E18AD0  token=0x6000054  System.Void Stop(System.Boolean withChildren)
  RVA=0x04271578  token=0x6000055  System.Void Stop()
  RVA=0x0329C870  token=0x6000056  System.Void Clear(System.Boolean withChildren)
  RVA=0x0427158C  token=0x6000057  System.Void Clear()
  RVA=0x09E1858C  token=0x6000058  System.Boolean IsAlive(System.Boolean withChildren)
  RVA=0x09E185D0  token=0x6000059  System.Boolean IsAlive()
  RVA=0x09E17FA4  token=0x600005A  System.Void Emit(System.Int32 count)
  RVA=0x09E17E48  token=0x600005B  System.Void Emit_Internal(System.Int32 count)
  RVA=0x09E17FAC  token=0x600005C  System.Void Emit(UnityEngine.ParticleSystem.EmitParams emitParams, System.Int32 count)
  RVA=0x09E17DB0  token=0x600005D  System.Void EmitOld_Internal(UnityEngine.ParticleSystem.Particle& particle)
  RVA=0x09E18B44  token=0x600005E  System.Void TriggerSubEmitter(System.Int32 subEmitterIndex)
  RVA=0x09E18BA0  token=0x600005F  System.Void TriggerSubEmitter(System.Int32 subEmitterIndex, UnityEngine.ParticleSystem.Particle& particle)
  RVA=0x09E18B30  token=0x6000060  System.Void TriggerSubEmitterForParticle(System.Int32 subEmitterIndex, UnityEngine.ParticleSystem.Particle particle)
  RVA=0x09E18B50  token=0x6000061  System.Void TriggerSubEmitter(System.Int32 subEmitterIndex, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles)
  RVA=0x09E1862C  token=0x6000062  System.Void ResetPreMappedBufferMemory()
  RVA=0x09E18788  token=0x6000063  System.Void SetMaximumPreMappedBufferCounts(System.Int32 vertexBuffersCount, System.Int32 indexBuffersCount)
  RVA=0x09E17CC4  token=0x6000064  System.Void AllocateAxisOfRotationAttribute()
  RVA=0x09E17D38  token=0x6000065  System.Void AllocateMeshIndexAttribute()
  RVA=0x09E17CF8  token=0x6000066  System.Void AllocateCustomDataAttribute(UnityEngine.ParticleSystemCustomData stream)
  RVA=0x09E18014  token=0x6000067  System.Void* GetManagedJobData()
  RVA=0x09E1808C  token=0x6000068  Unity.Jobs.JobHandle GetManagedJobHandle()
  RVA=0x09E18774  token=0x6000069  System.Void SetManagedJobHandle(Unity.Jobs.JobHandle handle)
  RVA=0x09E186AC  token=0x600006A  Unity.Jobs.JobHandle ScheduleManagedJob(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* additionalData)
  RVA=0x09E17D6C  token=0x600006B  System.Void CopyManagedJobData(System.Void* systemPtr, UnityEngine.ParticleSystemJobs.NativeParticleData& particleData)
  RVA=0x0426FE60  token=0x6000083  System.Void .ctor()
  RVA=0x09E18130  token=0x6000084  System.Void GetParticleCurrentSize3D_Injected(UnityEngine.ParticleSystem.Particle& particle, UnityEngine.Vector3& ret)
  RVA=0x09E180B8  token=0x6000085  System.Void GetParticleCurrentColor_Injected(UnityEngine.ParticleSystem.Particle& particle, UnityEngine.Color32& ret)
  RVA=0x09E183F0  token=0x6000086  System.Void GetPlaybackState_Injected(UnityEngine.ParticleSystem.PlaybackState& ret)
  RVA=0x09E18978  token=0x6000087  System.Void SetPlaybackState_Injected(UnityEngine.ParticleSystem.PlaybackState& playbackState)
  RVA=0x09E189D0  token=0x6000088  System.Void SetTrails_Injected(UnityEngine.ParticleSystem.Trails& trailData)
  RVA=0x09E17DF4  token=0x6000089  System.Void Emit_Injected(UnityEngine.ParticleSystem.EmitParams& emitParams, System.Int32 count)
  RVA=0x09E18AE0  token=0x600008A  System.Void TriggerSubEmitterForParticle_Injected(System.Int32 subEmitterIndex, UnityEngine.ParticleSystem.Particle& particle)
  RVA=0x09E18048  token=0x600008B  System.Void GetManagedJobHandle_Injected(Unity.Jobs.JobHandle& ret)
  RVA=0x09E18730  token=0x600008C  System.Void SetManagedJobHandle_Injected(Unity.Jobs.JobHandle& handle)
  RVA=0x09E18658  token=0x600008D  System.Void ScheduleManagedJob_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* additionalData, Unity.Jobs.JobHandle& ret)
END_CLASS

CLASS: UnityEngine.ParticlePhysicsExtensions
TYPE:  static class
TOKEN: 0x200002A
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09E15900  token=0x600012A  System.Int32 GetSafeCollisionEventSize(UnityEngine.ParticleSystem ps)
  RVA=0x09E158F4  token=0x600012B  System.Int32 GetCollisionEvents(UnityEngine.ParticleSystem ps, UnityEngine.GameObject go, System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent> collisionEvents)
END_CLASS

CLASS: UnityEngine.ParticleSystemRenderMode
TYPE:  sealed struct
TOKEN: 0x200002B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ParticleSystemRenderModeBillboard  // const
  public    static  UnityEngine.ParticleSystemRenderModeStretch  // const
  public    static  UnityEngine.ParticleSystemRenderModeHorizontalBillboard  // const
  public    static  UnityEngine.ParticleSystemRenderModeVerticalBillboard  // const
  public    static  UnityEngine.ParticleSystemRenderModeMesh  // const
  public    static  UnityEngine.ParticleSystemRenderModeNone  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ParticleSystemMeshDistribution
TYPE:  sealed struct
TOKEN: 0x200002C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ParticleSystemMeshDistributionUniformRandom  // const
  public    static  UnityEngine.ParticleSystemMeshDistributionNonUniformRandom  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ParticleSystemSortMode
TYPE:  sealed struct
TOKEN: 0x200002D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ParticleSystemSortModeNone  // const
  public    static  UnityEngine.ParticleSystemSortModeDistance  // const
  public    static  UnityEngine.ParticleSystemSortModeOldestInFront  // const
  public    static  UnityEngine.ParticleSystemSortModeYoungestInFront  // const
  public    static  UnityEngine.ParticleSystemSortModeDepth  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ParticleSystemRenderSpace
TYPE:  sealed struct
TOKEN: 0x200002E
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ParticleSystemRenderSpaceView  // const
  public    static  UnityEngine.ParticleSystemRenderSpaceWorld  // const
  public    static  UnityEngine.ParticleSystemRenderSpaceLocal  // const
  public    static  UnityEngine.ParticleSystemRenderSpaceFacing  // const
  public    static  UnityEngine.ParticleSystemRenderSpaceVelocity  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ParticleSystemCurveMode
TYPE:  sealed struct
TOKEN: 0x200002F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ParticleSystemCurveModeConstant  // const
  public    static  UnityEngine.ParticleSystemCurveModeCurve  // const
  public    static  UnityEngine.ParticleSystemCurveModeTwoCurves  // const
  public    static  UnityEngine.ParticleSystemCurveModeTwoConstants  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ParticleSystemGradientMode
TYPE:  sealed struct
TOKEN: 0x2000030
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ParticleSystemGradientModeColor  // const
  public    static  UnityEngine.ParticleSystemGradientModeGradient  // const
  public    static  UnityEngine.ParticleSystemGradientModeTwoColors  // const
  public    static  UnityEngine.ParticleSystemGradientModeTwoGradients  // const
  public    static  UnityEngine.ParticleSystemGradientModeRandomColor  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ParticleSystemShapeType
TYPE:  sealed struct
TOKEN: 0x2000031
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ParticleSystemShapeTypeSphere  // const
  public    static  UnityEngine.ParticleSystemShapeTypeSphereShell  // const
  public    static  UnityEngine.ParticleSystemShapeTypeHemisphere  // const
  public    static  UnityEngine.ParticleSystemShapeTypeHemisphereShell  // const
  public    static  UnityEngine.ParticleSystemShapeTypeCone  // const
  public    static  UnityEngine.ParticleSystemShapeTypeBox  // const
  public    static  UnityEngine.ParticleSystemShapeTypeMesh  // const
  public    static  UnityEngine.ParticleSystemShapeTypeConeShell  // const
  public    static  UnityEngine.ParticleSystemShapeTypeConeVolume  // const
  public    static  UnityEngine.ParticleSystemShapeTypeConeVolumeShell  // const
  public    static  UnityEngine.ParticleSystemShapeTypeCircle  // const
  public    static  UnityEngine.ParticleSystemShapeTypeCircleEdge  // const
  public    static  UnityEngine.ParticleSystemShapeTypeSingleSidedEdge  // const
  public    static  UnityEngine.ParticleSystemShapeTypeMeshRenderer  // const
  public    static  UnityEngine.ParticleSystemShapeTypeSkinnedMeshRenderer  // const
  public    static  UnityEngine.ParticleSystemShapeTypeBoxShell  // const
  public    static  UnityEngine.ParticleSystemShapeTypeBoxEdge  // const
  public    static  UnityEngine.ParticleSystemShapeTypeDonut  // const
  public    static  UnityEngine.ParticleSystemShapeTypeRectangle  // const
  public    static  UnityEngine.ParticleSystemShapeTypeSprite  // const
  public    static  UnityEngine.ParticleSystemShapeTypeSpriteRenderer  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ParticleSystemSimulationSpace
TYPE:  sealed struct
TOKEN: 0x2000032
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ParticleSystemSimulationSpaceLocal  // const
  public    static  UnityEngine.ParticleSystemSimulationSpaceWorld  // const
  public    static  UnityEngine.ParticleSystemSimulationSpaceCustom  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ParticleSystemStopBehavior
TYPE:  sealed struct
TOKEN: 0x2000033
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ParticleSystemStopBehaviorStopEmittingAndClear  // const
  public    static  UnityEngine.ParticleSystemStopBehaviorStopEmitting  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ParticleSystemScalingMode
TYPE:  sealed struct
TOKEN: 0x2000034
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ParticleSystemScalingModeHierarchy  // const
  public    static  UnityEngine.ParticleSystemScalingModeLocal  // const
  public    static  UnityEngine.ParticleSystemScalingModeShape  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ParticleSystemVertexStream
TYPE:  sealed struct
TOKEN: 0x2000035
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ParticleSystemVertexStreamPosition  // const
  public    static  UnityEngine.ParticleSystemVertexStreamNormal  // const
  public    static  UnityEngine.ParticleSystemVertexStreamTangent  // const
  public    static  UnityEngine.ParticleSystemVertexStreamColor  // const
  public    static  UnityEngine.ParticleSystemVertexStreamUV  // const
  public    static  UnityEngine.ParticleSystemVertexStreamUV2  // const
  public    static  UnityEngine.ParticleSystemVertexStreamUV3  // const
  public    static  UnityEngine.ParticleSystemVertexStreamUV4  // const
  public    static  UnityEngine.ParticleSystemVertexStreamAnimBlend  // const
  public    static  UnityEngine.ParticleSystemVertexStreamAnimFrame  // const
  public    static  UnityEngine.ParticleSystemVertexStreamCenter  // const
  public    static  UnityEngine.ParticleSystemVertexStreamVertexID  // const
  public    static  UnityEngine.ParticleSystemVertexStreamSizeX  // const
  public    static  UnityEngine.ParticleSystemVertexStreamSizeXY  // const
  public    static  UnityEngine.ParticleSystemVertexStreamSizeXYZ  // const
  public    static  UnityEngine.ParticleSystemVertexStreamRotation  // const
  public    static  UnityEngine.ParticleSystemVertexStreamRotation3D  // const
  public    static  UnityEngine.ParticleSystemVertexStreamRotationSpeed  // const
  public    static  UnityEngine.ParticleSystemVertexStreamRotationSpeed3D  // const
  public    static  UnityEngine.ParticleSystemVertexStreamVelocity  // const
  public    static  UnityEngine.ParticleSystemVertexStreamSpeed  // const
  public    static  UnityEngine.ParticleSystemVertexStreamAgePercent  // const
  public    static  UnityEngine.ParticleSystemVertexStreamInvStartLifetime  // const
  public    static  UnityEngine.ParticleSystemVertexStreamStableRandomX  // const
  public    static  UnityEngine.ParticleSystemVertexStreamStableRandomXY  // const
  public    static  UnityEngine.ParticleSystemVertexStreamStableRandomXYZ  // const
  public    static  UnityEngine.ParticleSystemVertexStreamStableRandomXYZW  // const
  public    static  UnityEngine.ParticleSystemVertexStreamVaryingRandomX  // const
  public    static  UnityEngine.ParticleSystemVertexStreamVaryingRandomXY  // const
  public    static  UnityEngine.ParticleSystemVertexStreamVaryingRandomXYZ  // const
  public    static  UnityEngine.ParticleSystemVertexStreamVaryingRandomXYZW  // const
  public    static  UnityEngine.ParticleSystemVertexStreamCustom1X  // const
  public    static  UnityEngine.ParticleSystemVertexStreamCustom1XY  // const
  public    static  UnityEngine.ParticleSystemVertexStreamCustom1XYZ  // const
  public    static  UnityEngine.ParticleSystemVertexStreamCustom1XYZW  // const
  public    static  UnityEngine.ParticleSystemVertexStreamCustom2X  // const
  public    static  UnityEngine.ParticleSystemVertexStreamCustom2XY  // const
  public    static  UnityEngine.ParticleSystemVertexStreamCustom2XYZ  // const
  public    static  UnityEngine.ParticleSystemVertexStreamCustom2XYZW  // const
  public    static  UnityEngine.ParticleSystemVertexStreamNoiseSumX  // const
  public    static  UnityEngine.ParticleSystemVertexStreamNoiseSumXY  // const
  public    static  UnityEngine.ParticleSystemVertexStreamNoiseSumXYZ  // const
  public    static  UnityEngine.ParticleSystemVertexStreamNoiseImpulseX  // const
  public    static  UnityEngine.ParticleSystemVertexStreamNoiseImpulseXY  // const
  public    static  UnityEngine.ParticleSystemVertexStreamNoiseImpulseXYZ  // const
  public    static  UnityEngine.ParticleSystemVertexStreamMeshIndex  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ParticleSystemCustomData
TYPE:  sealed struct
TOKEN: 0x2000036
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ParticleSystemCustomDataCustom1  // const
  public    static  UnityEngine.ParticleSystemCustomDataCustom2  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ParticleSystemTrailTextureMode
TYPE:  sealed struct
TOKEN: 0x2000037
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ParticleSystemTrailTextureModeStretch  // const
  public    static  UnityEngine.ParticleSystemTrailTextureModeTile  // const
  public    static  UnityEngine.ParticleSystemTrailTextureModeDistributePerSegment  // const
  public    static  UnityEngine.ParticleSystemTrailTextureModeRepeatPerSegment  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ParticleSystemForceFieldShape
TYPE:  sealed struct
TOKEN: 0x2000038
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ParticleSystemForceFieldShapeSphere  // const
  public    static  UnityEngine.ParticleSystemForceFieldShapeHemisphere  // const
  public    static  UnityEngine.ParticleSystemForceFieldShapeCylinder  // const
  public    static  UnityEngine.ParticleSystemForceFieldShapeBox  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ParticleSystemVertexStreams
TYPE:  sealed struct
TOKEN: 0x2000039
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ParticleSystemVertexStreamsPosition  // const
  public    static  UnityEngine.ParticleSystemVertexStreamsNormal  // const
  public    static  UnityEngine.ParticleSystemVertexStreamsTangent  // const
  public    static  UnityEngine.ParticleSystemVertexStreamsColor  // const
  public    static  UnityEngine.ParticleSystemVertexStreamsUV  // const
  public    static  UnityEngine.ParticleSystemVertexStreamsUV2BlendAndFrame  // const
  public    static  UnityEngine.ParticleSystemVertexStreamsCenterAndVertexID  // const
  public    static  UnityEngine.ParticleSystemVertexStreamsSize  // const
  public    static  UnityEngine.ParticleSystemVertexStreamsRotation  // const
  public    static  UnityEngine.ParticleSystemVertexStreamsVelocity  // const
  public    static  UnityEngine.ParticleSystemVertexStreamsLifetime  // const
  public    static  UnityEngine.ParticleSystemVertexStreamsCustom1  // const
  public    static  UnityEngine.ParticleSystemVertexStreamsCustom2  // const
  public    static  UnityEngine.ParticleSystemVertexStreamsRandom  // const
  public    static  UnityEngine.ParticleSystemVertexStreamsNone  // const
  public    static  UnityEngine.ParticleSystemVertexStreamsAll  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ParticleSystemRenderer
TYPE:  sealed class
TOKEN: 0x200003A
SIZE:  0x18
EXTENDS: UnityEngine.Renderer
FIELDS:
PROPERTIES:
  alignment  get=0x09E171E8  set=0x09E176D8
  renderMode  get=0x09E175A0  set=0x09E17B34
  meshDistribution  get=0x09E17460  set=0x09E1798C
  sortMode  get=0x09E1763C  set=0x09E17BFC
  lengthScale  get=0x09E17390  set=0x09E178C4
  velocityScale  get=0x09E176A4  set=0x09E17C80
  cameraVelocityScale  get=0x09E17250  set=0x09E1775C
  normalDirection  get=0x09E174FC  set=0x09E17A54
  shadowBias  get=0x09E17608  set=0x09E17BB8
  minParticleSize  get=0x09E174C8  set=0x09E17A10
  maxParticleSize  get=0x09E173F8  set=0x09E17948
  pivot  get=0x09E17574  set=0x09E17B20
  flip  get=0x09E17330  set=0x09E1786C
  maskInteraction  get=0x09E173C4  set=0x09E17908
  trailMaterial  get=0x09E17670  set=0x09E17C3C
  oldTrailMaterial  set=0x09E17A98
  enableGPUInstancing  get=0x09E17284  set=0x09E177A0
  allowRoll  get=0x09E1721C  set=0x09E17718
  freeformStretching  get=0x09E1735C  set=0x09E17880
  rotateWithStretchDirection  get=0x09E175D4  set=0x09E17B74
  enableHGGPUInstancing  get=0x09E172B8  set=0x09E177E4
  mesh  get=0x09E17494  set=0x09E179CC
  meshCount  get=0x09E1742C
  activeVertexStreamsCount  get=0x09E171B4
  DisableCutOutAnimation  get=0x09E17180
  CutOutMode  get=0x09E1714C
  CutOutDataSize  get=0x09E17118
METHODS:
  RVA=0x09E166CC  token=0x600012C  System.Void EnableVertexStreams(UnityEngine.ParticleSystemVertexStreams streams)
  RVA=0x09E166C0  token=0x600012D  System.Void DisableVertexStreams(UnityEngine.ParticleSystemVertexStreams streams)
  RVA=0x09E16544  token=0x600012E  System.Boolean AreVertexStreamsEnabled(UnityEngine.ParticleSystemVertexStreams streams)
  RVA=0x09E1671C  token=0x600012F  UnityEngine.ParticleSystemVertexStreams GetEnabledVertexStreams(UnityEngine.ParticleSystemVertexStreams streams)
  RVA=0x09E16A08  token=0x6000130  System.Void Internal_SetVertexStreams(UnityEngine.ParticleSystemVertexStreams streams, System.Boolean enabled)
  RVA=0x09E167B0  token=0x6000131  UnityEngine.ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(UnityEngine.ParticleSystemVertexStreams streams)
  RVA=0x09E1676C  token=0x600015D  System.Int32 GetMeshes(UnityEngine.Mesh[] meshes)
  RVA=0x09E170A4  token=0x600015E  System.Void SetMeshes(UnityEngine.Mesh[] meshes, System.Int32 size)
  RVA=0x09E170F8  token=0x600015F  System.Void SetMeshes(UnityEngine.Mesh[] meshes)
  RVA=0x09E16728  token=0x6000160  System.Int32 GetMeshWeightings(System.Single[] weightings)
  RVA=0x09E17030  token=0x6000161  System.Void SetMeshWeightings(System.Single[] weightings, System.Int32 size)
  RVA=0x09E17084  token=0x6000162  System.Void SetMeshWeightings(System.Single[] weightings)
  RVA=0x09E165C4  token=0x6000164  System.Void BakeMesh(UnityEngine.Mesh mesh, System.Boolean useTransform)
  RVA=0x09E16560  token=0x6000165  System.Void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, System.Boolean useTransform)
  RVA=0x09E16610  token=0x6000166  System.Void BakeTrailsMesh(UnityEngine.Mesh mesh, System.Boolean useTransform)
  RVA=0x09E1665C  token=0x6000167  System.Void BakeTrailsMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, System.Boolean useTransform)
  RVA=0x09E16FEC  token=0x6000169  System.Void SetActiveVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams)
  RVA=0x09E166D8  token=0x600016A  System.Void GetActiveVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams)
  RVA=0x0426FE60  token=0x600016E  System.Void .ctor()
  RVA=0x09E17530  token=0x600016F  System.Void get_pivot_Injected(UnityEngine.Vector3& ret)
  RVA=0x09E17ADC  token=0x6000170  System.Void set_pivot_Injected(UnityEngine.Vector3& value)
  RVA=0x09E172EC  token=0x6000171  System.Void get_flip_Injected(UnityEngine.Vector3& ret)
  RVA=0x09E17828  token=0x6000172  System.Void set_flip_Injected(UnityEngine.Vector3& value)
END_CLASS

CLASS: UnityEngine.ParticleCollisionEvent
TYPE:  sealed struct
TOKEN: 0x200003B
SIZE:  0x38
FIELDS:
  private           UnityEngine.Vector3             m_Intersection  // 0x10
  private           UnityEngine.Vector3             m_Normal  // 0x1c
  private           UnityEngine.Vector3             m_Velocity  // 0x28
  private           System.Int32                    m_ColliderInstanceID  // 0x34
PROPERTIES:
  intersection  get=0x03D85920
  normal  get=0x03D85900
  velocity  get=0x03D85CF0
  colliderComponent  get=0x09E158E8
METHODS:
  RVA=0x09E158B4  token=0x6000177  UnityEngine.Component InstanceIDToColliderComponent(System.Int32 instanceID)
END_CLASS

CLASS: UnityEngine.ParticleSystemExtensionsImpl
TYPE:  class
TOKEN: 0x200003C
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09E15960  token=0x6000178  System.Int32 GetSafeCollisionEventSize(UnityEngine.ParticleSystem ps)
  RVA=0x09E1590C  token=0x6000179  System.Int32 GetCollisionEvents(UnityEngine.ParticleSystem ps, UnityEngine.GameObject go, System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent> collisionEvents)
END_CLASS

CLASS: UnityEngine.ParticleSystemForceField
TYPE:  class
TOKEN: 0x200003D
SIZE:  0x18
EXTENDS: UnityEngine.Behaviour
FIELDS:
PROPERTIES:
  shape  get=0x09E15E2C  set=0x09E163CC
  startRange  get=0x09E15E60  set=0x09E1640C
  endRange  get=0x09E15B64  set=0x09E16110
  length  get=0x09E15C40  set=0x09E161F0
  gravityFocus  get=0x09E15B98  set=0x09E16154
  rotationRandomness  get=0x09E15D94  set=0x09E16358
  multiplyDragByParticleSize  get=0x09E15C74  set=0x09E16234
  multiplyDragByParticleVelocity  get=0x09E15CA8  set=0x09E16278
  vectorField  get=0x09E15F7C  set=0x09E16500
  directionX  get=0x09E159D8  set=0x09E15FF4
  directionY  get=0x09E15A4C  set=0x09E1604C
  directionZ  get=0x09E15AC0  set=0x09E160A4
  gravity  get=0x09E15C10  set=0x09E161DC
  rotationSpeed  get=0x09E15DFC  set=0x09E163B8
  rotationAttraction  get=0x09E15D20  set=0x09E16300
  drag  get=0x09E15B34  set=0x09E160FC
  vectorFieldSpeed  get=0x09E15F4C  set=0x09E164EC
  vectorFieldAttraction  get=0x09E15ED8  set=0x09E16494
METHODS:
  RVA=0x0426FE60  token=0x600019E  System.Void .ctor()
  RVA=0x09E15D50  token=0x600019F  System.Void get_rotationRandomness_Injected(UnityEngine.Vector2& ret)
  RVA=0x09E16314  token=0x60001A0  System.Void set_rotationRandomness_Injected(UnityEngine.Vector2& value)
  RVA=0x09E15994  token=0x60001A1  System.Void get_directionX_Injected(UnityEngine.ParticleSystem.MinMaxCurve& ret)
  RVA=0x09E15FB0  token=0x60001A2  System.Void set_directionX_Injected(UnityEngine.ParticleSystem.MinMaxCurve& value)
  RVA=0x09E15A08  token=0x60001A3  System.Void get_directionY_Injected(UnityEngine.ParticleSystem.MinMaxCurve& ret)
  RVA=0x09E16008  token=0x60001A4  System.Void set_directionY_Injected(UnityEngine.ParticleSystem.MinMaxCurve& value)
  RVA=0x09E15A7C  token=0x60001A5  System.Void get_directionZ_Injected(UnityEngine.ParticleSystem.MinMaxCurve& ret)
  RVA=0x09E16060  token=0x60001A6  System.Void set_directionZ_Injected(UnityEngine.ParticleSystem.MinMaxCurve& value)
  RVA=0x09E15BCC  token=0x60001A7  System.Void get_gravity_Injected(UnityEngine.ParticleSystem.MinMaxCurve& ret)
  RVA=0x09E16198  token=0x60001A8  System.Void set_gravity_Injected(UnityEngine.ParticleSystem.MinMaxCurve& value)
  RVA=0x09E15DB8  token=0x60001A9  System.Void get_rotationSpeed_Injected(UnityEngine.ParticleSystem.MinMaxCurve& ret)
  RVA=0x09E16374  token=0x60001AA  System.Void set_rotationSpeed_Injected(UnityEngine.ParticleSystem.MinMaxCurve& value)
  RVA=0x09E15CDC  token=0x60001AB  System.Void get_rotationAttraction_Injected(UnityEngine.ParticleSystem.MinMaxCurve& ret)
  RVA=0x09E162BC  token=0x60001AC  System.Void set_rotationAttraction_Injected(UnityEngine.ParticleSystem.MinMaxCurve& value)
  RVA=0x09E15AF0  token=0x60001AD  System.Void get_drag_Injected(UnityEngine.ParticleSystem.MinMaxCurve& ret)
  RVA=0x09E160B8  token=0x60001AE  System.Void set_drag_Injected(UnityEngine.ParticleSystem.MinMaxCurve& value)
  RVA=0x09E15F08  token=0x60001AF  System.Void get_vectorFieldSpeed_Injected(UnityEngine.ParticleSystem.MinMaxCurve& ret)
  RVA=0x09E164A8  token=0x60001B0  System.Void set_vectorFieldSpeed_Injected(UnityEngine.ParticleSystem.MinMaxCurve& value)
  RVA=0x09E15E94  token=0x60001B1  System.Void get_vectorFieldAttraction_Injected(UnityEngine.ParticleSystem.MinMaxCurve& ret)
  RVA=0x09E16450  token=0x60001B2  System.Void set_vectorFieldAttraction_Injected(UnityEngine.ParticleSystem.MinMaxCurve& value)
END_CLASS

CLASS: UnityEngine.HGParticleMeshInstanceRenderer
TYPE:  sealed class
TOKEN: 0x200003E
SIZE:  0x18
EXTENDS: UnityEngine.Renderer
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.ParticleSystemJobs.NativeParticleData
TYPE:  sealed struct
TOKEN: 0x200003F
SIZE:  0x110
FIELDS:
  private           System.Int32                    count  // 0x10
  private           UnityEngine.ParticleSystemJobs.NativeParticleData.Array3positions  // 0x18
  private           UnityEngine.ParticleSystemJobs.NativeParticleData.Array3velocities  // 0x30
  private           UnityEngine.ParticleSystemJobs.NativeParticleData.Array3axisOfRotations  // 0x48
  private           UnityEngine.ParticleSystemJobs.NativeParticleData.Array3rotations  // 0x60
  private           UnityEngine.ParticleSystemJobs.NativeParticleData.Array3rotationalSpeeds  // 0x78
  private           UnityEngine.ParticleSystemJobs.NativeParticleData.Array3sizes  // 0x90
  private           System.Void*                    startColors  // 0xa8
  private           System.Void*                    aliveTimePercent  // 0xb0
  private           System.Void*                    inverseStartLifetimes  // 0xb8
  private           System.Void*                    randomSeeds  // 0xc0
  private           UnityEngine.ParticleSystemJobs.NativeParticleData.Array4customData1  // 0xc8
  private           UnityEngine.ParticleSystemJobs.NativeParticleData.Array4customData2  // 0xe8
  private           System.Void*                    meshIndices  // 0x108
METHODS:
END_CLASS

