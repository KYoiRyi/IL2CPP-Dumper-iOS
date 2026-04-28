// ========================================================
// Dumped by @desirepro
// Assembly: NavMeshComponents.dll
// Classes:  9
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

CLASS: NavMeshPrefabInstance
TYPE:  class
TOKEN: 0x2000002
SIZE:  0x48
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           UnityEngine.AI.NavMeshData      m_NavMesh  // 0x18
  private           System.Boolean                  m_FollowTransform  // 0x20
  private           UnityEngine.AI.NavMeshDataInstancem_Instance  // 0x24
  private   static readonly System.Collections.Generic.List<NavMeshPrefabInstance>s_TrackedInstances  // static @ 0x0
  private           UnityEngine.Vector3             m_Position  // 0x28
  private           UnityEngine.Quaternion          m_Rotation  // 0x34
PROPERTIES:
  navMeshData  get=0x01041090  set=0x022C3A90
  followTransform  get=0x03D4EF90  set=0x0929C3A0
  trackedInstances  get=0x0929C350
METHODS:
  RVA=0x0929BF6C  token=0x6000006  System.Void OnEnable()
  RVA=0x0929BF48  token=0x6000007  System.Void OnDisable()
  RVA=0x0929C150  token=0x6000008  System.Void UpdateInstance()
  RVA=0x0929BB80  token=0x6000009  System.Void AddInstance()
  RVA=0x0929BCC0  token=0x600000A  System.Void AddTracking()
  RVA=0x0929BFA8  token=0x600000B  System.Void RemoveTracking()
  RVA=0x0929C124  token=0x600000C  System.Void SetFollowTransform(System.Boolean value)
  RVA=0x0929BE54  token=0x600000D  System.Boolean HasMoved()
  RVA=0x0929C174  token=0x600000E  System.Void UpdateTrackedInstances()
  RVA=0x0426FE60  token=0x600000F  System.Void .ctor()
  RVA=0x0929C2C4  token=0x6000010  System.Void .cctor()
END_CLASS

CLASS: <>c
TYPE:  sealed class
TOKEN: 0x2000009
SIZE:  0x10
FIELDS:
  public    static readonly UnityEngine.AI.NavMeshSurface.<>c<>9  // static @ 0x0
  public    static  System.Predicate<UnityEngine.AI.NavMeshModifierVolume><>9__105_0  // static @ 0x8
  public    static  System.Predicate<UnityEngine.AI.NavMeshModifier><>9__106_0  // static @ 0x10
  public    static  System.Predicate<UnityEngine.AI.NavMeshBuildSource><>9__106_1  // static @ 0x18
  public    static  System.Predicate<UnityEngine.AI.NavMeshBuildSource><>9__106_2  // static @ 0x20
METHODS:
  RVA=0x0929F2B8  token=0x600008D  System.Void .cctor()
  RVA=0x0350B670  token=0x600008E  System.Void .ctor()
  RVA=0x0929F11C  token=0x600008F  System.Boolean <AppendModifierVolumes>b__105_0(UnityEngine.AI.NavMeshModifierVolume x)
  RVA=0x0929F11C  token=0x6000090  System.Boolean <CollectSources>b__106_0(UnityEngine.AI.NavMeshModifier x)
  RVA=0x0929F140  token=0x6000091  System.Boolean <CollectSources>b__106_1(UnityEngine.AI.NavMeshBuildSource x)
  RVA=0x0929F1FC  token=0x6000092  System.Boolean <CollectSources>b__106_2(UnityEngine.AI.NavMeshBuildSource x)
END_CLASS

CLASS: UnityEngine.AI.NavMeshLink
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x90
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.Int32                    m_AgentTypeID  // 0x18
  private           UnityEngine.Vector3             m_StartRight  // 0x1c
  private           UnityEngine.Vector3             m_StartLeft  // 0x28
  private           UnityEngine.Vector3             m_EndRight  // 0x34
  private           UnityEngine.Vector3             m_EndLeft  // 0x40
  private           System.Boolean                  m_IsExt  // 0x4c
  private           System.Single                   m_CostModifier  // 0x50
  private           System.Boolean                  m_Bidirectional  // 0x54
  private           System.Boolean                  m_AutoUpdatePosition  // 0x55
  private           System.Int32                    m_Area  // 0x58
  public            System.Boolean                  autoSnapExtent  // 0x5c
  public            UnityEngine.Vector3             snapExtent  // 0x60
  private           UnityEngine.AI.NavMeshLinkInstancem_LinkInstance  // 0x6c
  private           UnityEngine.Vector3             m_LastPosition  // 0x70
  private           UnityEngine.Quaternion          m_LastRotation  // 0x7c
  private   static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshLink>s_Tracked  // static @ 0x0
PROPERTIES:
  agentTypeID  get=0x020D1AC0  set=0x0929B244
  startRight  get=0x03D568F0  set=0x0929B414
  startLeft  get=0x03D50E80  set=0x0929B3A0
  startMid  get=0x0929B1C4
  endRight  get=0x03D522E0  set=0x0929B31C
  endLeft  get=0x03D52300  set=0x0929B2A8
  endMid  get=0x0929B144
  isExt  get=0x03D4F520  set=0x0929B390
  costModifier  get=0x03D51C90  set=0x0929B27C
  bidirectional  get=0x03D4F320  set=0x0929B26C
  autoUpdate  get=0x03D4F310  set=0x0929B264
  area  get=0x03D4EF00  set=0x0929B254
METHODS:
  RVA=0x0929ABDC  token=0x6000027  System.Void OnEnable()
  RVA=0x0929AB90  token=0x6000028  System.Void OnDisable()
  RVA=0x0929AE80  token=0x6000029  System.Void UpdateLink()
  RVA=0x0929A900  token=0x600002A  System.Void AddTracking(UnityEngine.AI.NavMeshLink link)
  RVA=0x0929AC3C  token=0x600002B  System.Void RemoveTracking(UnityEngine.AI.NavMeshLink link)
  RVA=0x0929ADB8  token=0x600002C  System.Void SetAutoUpdate(System.Boolean value)
  RVA=0x0929A73C  token=0x600002D  System.Void AddLink()
  RVA=0x0929AE1C  token=0x600002E  System.Void SetByLinkData(UnityEngine.AI.NavMeshLinkData data)
  RVA=0x0929AA94  token=0x600002F  System.Boolean HasTransformChanged()
  RVA=0x0929AB88  token=0x6000030  System.Void OnDidApplyAnimationProperties()
  RVA=0x0929AEA4  token=0x6000031  System.Void UpdateTrackedInstances()
  RVA=0x0929B080  token=0x6000032  System.Void .ctor()
  RVA=0x0929AFF4  token=0x6000033  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.AI.NavMeshModifier
TYPE:  class
TOKEN: 0x2000004
SIZE:  0x30
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.Boolean                  m_OverrideArea  // 0x18
  private           System.Int32                    m_Area  // 0x1c
  private           System.Boolean                  m_IgnoreFromBuild  // 0x20
  private           System.Collections.Generic.List<System.Int32>m_AffectedAgents  // 0x28
  private   static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshModifier>s_NavMeshModifiers  // static @ 0x0
PROPERTIES:
  overrideArea  get=0x01002A50  set=0x01002B40
  area  get=0x03D4EBB0  set=0x03D4EBC0
  ignoreFromBuild  get=0x03D4EF90  set=0x03D4EFC0
  activeModifiers  get=0x0929BB30
METHODS:
  RVA=0x0929B930  token=0x600003B  System.Void OnEnable()
  RVA=0x0929B8C0  token=0x600003C  System.Void OnDisable()
  RVA=0x0929B820  token=0x600003D  System.Boolean AffectsAgentType(System.Int32 agentTypeID)
  RVA=0x0929BA6C  token=0x600003E  System.Void .ctor()
  RVA=0x0929B9E0  token=0x600003F  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.AI.NavMeshModifierVolume
TYPE:  class
TOKEN: 0x2000005
SIZE:  0x40
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           UnityEngine.Vector3             m_Size  // 0x18
  private           UnityEngine.Vector3             m_Center  // 0x24
  private           System.Int32                    m_Area  // 0x30
  private           System.Collections.Generic.List<System.Int32>m_AffectedAgents  // 0x38
  private   static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshModifierVolume>s_NavMeshModifiers  // static @ 0x0
PROPERTIES:
  size  get=0x03D52510  set=0x03D52530
  center  get=0x03D59780  set=0x03D5A9E0
  area  get=0x03D4ED20  set=0x03D4EE10
  activeModifiers  get=0x0929B7D0
METHODS:
  RVA=0x0929B598  token=0x6000047  System.Void OnEnable()
  RVA=0x0929B528  token=0x6000048  System.Void OnDisable()
  RVA=0x0929B488  token=0x6000049  System.Boolean AffectsAgentType(System.Int32 agentTypeID)
  RVA=0x0929B6D4  token=0x600004A  System.Void .ctor()
  RVA=0x0929B648  token=0x600004B  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.AI.CollectObjects
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AI.CollectObjects   All  // const
  public    static  UnityEngine.AI.CollectObjects   Volume  // const
  public    static  UnityEngine.AI.CollectObjects   Children  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AI.PartitioningMethod
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AI.PartitioningMethodLayers  // const
  public    static  UnityEngine.AI.PartitioningMethodMonotone  // const
  public    static  UnityEngine.AI.PartitioningMethodWatershed  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshSurface
TYPE:  class
TOKEN: 0x2000008
SIZE:  0x98
EXTENDS: UnityEngine.MonoBehaviour
FIELDS:
  private           System.Int32                    m_AgentTypeID  // 0x18
  private           UnityEngine.AI.CollectObjects   m_CollectObjects  // 0x1c
  private           UnityEngine.Vector3             m_Size  // 0x20
  private           UnityEngine.Vector3             m_Center  // 0x2c
  private           UnityEngine.LayerMask           m_LayerMask  // 0x38
  private           System.String                   m_BlockTag  // 0x40
  private           UnityEngine.AI.PartitioningMethodm_PartitioningMethod  // 0x48
  private           System.Boolean                  m_FilterLowHangingObstacles  // 0x4c
  private           System.Boolean                  m_FilterLedgeSpans  // 0x4d
  private           System.Boolean                  m_FilterWalkableLowHeightSpans  // 0x4e
  private           System.Boolean                  m_OverrideMinRegionArea  // 0x4f
  private           System.Single                   m_MinRegionArea  // 0x50
  private           UnityEngine.AI.NavMeshCollectGeometrym_UseGeometry  // 0x54
  private           System.Int32                    m_DefaultArea  // 0x58
  private           System.Boolean                  m_IgnoreNavMeshAgent  // 0x5c
  private           System.Boolean                  m_IgnoreNavMeshObstacle  // 0x5d
  private           System.Boolean                  m_OverrideTileSize  // 0x5e
  private           System.Int32                    m_TileSize  // 0x60
  private           System.Boolean                  m_OverrideVoxelSize  // 0x64
  private           System.Single                   m_VoxelSize  // 0x68
  private           System.Boolean                  m_BuildHeightMesh  // 0x6c
  private           UnityEngine.AI.NavMeshData      m_NavMeshData  // 0x70
  private           UnityEngine.AI.NavMeshDataInstancem_NavMeshDataInstance  // 0x78
  private           UnityEngine.Vector3             m_LastPosition  // 0x7c
  private           UnityEngine.Quaternion          m_LastRotation  // 0x88
  private   static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshSurface>s_NavMeshSurfaces  // static @ 0x0
PROPERTIES:
  agentTypeID  get=0x020D1AC0  set=0x03D4E9C0
  collectObjects  get=0x03D4EBB0  set=0x03D4EBC0
  size  get=0x03D59660  set=0x03D5AE00
  center  get=0x03D59800  set=0x03D5BF30
  layerMask  get=0x03D4EC30  set=0x03D4ECB0
  BlockTag  get=0x03D4E2B0  set=0x03CB2D80
  partitioningMethod  get=0x03D4EC50  set=0x03D4ECD0
  filterLowHangingObstacles  get=0x03D4F520  set=0x03D4F550
  filterLedgeSpans  get=0x03D5CEB0  set=0x03D5CEC0
  filterWalkableLowHeightSpans  get=0x03D71340  set=0x03D71380
  overrideMinRegionArea  get=0x03D71360  set=0x03D713A0
  minRegionArea  get=0x03D51C90  set=0x03D51CA0
  useGeometry  get=0x03D4EEC0  set=0x03D4EF10
  defaultArea  get=0x03D4EF00  set=0x03D4EF50
  ignoreNavMeshAgent  get=0x03D4F600  set=0x03D4F620
  ignoreNavMeshObstacle  get=0x03D71350  set=0x03D71390
  overrideTileSize  get=0x03D71370  set=0x03D713B0
  tileSize  get=0x03D4F050  set=0x03D4F5A0
  overrideVoxelSize  get=0x03D590F0  set=0x03D59100
  voxelSize  get=0x03D56A40  set=0x03D59110
  buildHeightMesh  get=0x03D590E0  set=0x03D50950
  navMeshData  get=0x03D4EB30  set=0x0519C3C8
  activeSurfaces  get=0x0929F0CC
METHODS:
  RVA=0x0929E77C  token=0x6000079  System.Void OnEnable()
  RVA=0x0929E730  token=0x600007A  System.Void OnDisable()
  RVA=0x0929C3A8  token=0x600007B  System.Void AddData()
  RVA=0x0929E99C  token=0x600007C  System.Void RemoveData()
  RVA=0x0929E1F8  token=0x600007D  UnityEngine.AI.NavMeshBuildSettings GetBuildSettings()
  RVA=0x0929CACC  token=0x600007E  System.Void BuildNavMesh()
  RVA=0x0929EDC8  token=0x600007F  UnityEngine.AsyncOperation UpdateNavMesh(UnityEngine.AI.NavMeshData data)
  RVA=0x0929EC18  token=0x6000080  System.Boolean UpdateNavMeshSync(UnityEngine.AI.NavMeshData data)
  RVA=0x0929E7C8  token=0x6000081  System.Void Register(UnityEngine.AI.NavMeshSurface surface)
  RVA=0x0929E9BC  token=0x6000082  System.Void Unregister(UnityEngine.AI.NavMeshSurface surface)
  RVA=0x0929EB38  token=0x6000083  System.Void UpdateActive()
  RVA=0x0929C518  token=0x6000084  System.Void AppendModifierVolumes(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>& sources)
  RVA=0x0929D694  token=0x6000085  System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> CollectSources()
  RVA=0x03D5DA60  token=0x6000086  UnityEngine.Vector3 Abs(UnityEngine.Vector3 v)
  RVA=0x0929E358  token=0x6000087  UnityEngine.Bounds GetWorldBounds(UnityEngine.Matrix4x4 mat, UnityEngine.Bounds bounds)
  RVA=0x0929CDC4  token=0x6000088  UnityEngine.Bounds CalculateWorldBounds(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources)
  RVA=0x0929E634  token=0x6000089  System.Boolean HasTransformChanged()
  RVA=0x0929EBE4  token=0x600008A  System.Void UpdateDataIfTransformChanged()
  RVA=0x0929F004  token=0x600008B  System.Void .ctor()
  RVA=0x0929EF78  token=0x600008C  System.Void .cctor()
END_CLASS

