// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AIModule.dll
// Classes:  29
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

CLASS: OnNavMeshPreUpdate
TYPE:  sealed class
TOKEN: 0x2000011
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x042BE04C  token=0x60000A9  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x042BE03C  token=0x60000AA  System.Void Invoke()
END_CLASS

CLASS: OnUnloadFinishDelegate
TYPE:  sealed class
TOKEN: 0x2000012
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x034E42D0  token=0x60000AB  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02149960  token=0x60000AC  System.Void Invoke(System.UInt64 surfTileID)
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

CLASS: System.Runtime.CompilerServices.IsReadOnlyAttribute
TYPE:  sealed class
TOKEN: 0x2000003
SIZE:  0x10
EXTENDS: System.Attribute
FIELDS:
METHODS:
  RVA=0x0350B670  token=0x6000002  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.AI.NavMeshPathStatus
TYPE:  sealed struct
TOKEN: 0x2000004
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AI.NavMeshPathStatusPathComplete  // const
  public    static  UnityEngine.AI.NavMeshPathStatusPathPartial  // const
  public    static  UnityEngine.AI.NavMeshPathStatusPathInvalid  // const
  public    static  UnityEngine.AI.NavMeshPathStatusPathProcessing  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshPath
TYPE:  sealed class
TOKEN: 0x2000005
SIZE:  0x30
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private           UnityEngine.Vector3[]           m_Corners  // 0x18
  private           System.Int32[]                  m_Areas  // 0x20
  private           UnityEngine.Vector3[]           m_DividingPos  // 0x28
PROPERTIES:
  corners  get=0x0427050C
  status  get=0x02549C30
  needRepath  get=0x02792AE0  set=0x0353BA50
  calcAutoRepath  set=0x0353BA00
METHODS:
  RVA=0x02A810E0  token=0x6000003  System.Void .ctor()
  RVA=0x03B29410  token=0x6000004  System.Void Finalize()
  RVA=0x02A81100  token=0x6000005  System.IntPtr InitializeNavMeshPath()
  RVA=0x03B294A0  token=0x6000006  System.Void DestroyNavMeshPath(System.IntPtr ptr)
  RVA=0x039CB050  token=0x6000007  System.Int32 GetCornersNonAlloc(UnityEngine.Vector3[] corners, System.Int32[] areas, UnityEngine.Vector3[] dividingPos)
  RVA=0x03B41FD0  token=0x6000008  System.Int32 GetPolyCount()
  RVA=0x03C9C4B0  token=0x6000009  UnityEngine.Vector3[] CalculateCornersInternal()
  RVA=0x0278F2A0  token=0x600000A  System.Void ClearCornersInternal()
  RVA=0x0278F270  token=0x600000B  System.Void ClearCorners()
  RVA=0x03C9C480  token=0x600000C  System.Void CalculateCorners()
END_CLASS

CLASS: UnityEngine.AI.NavMeshBuilder
TYPE:  static class
TOKEN: 0x2000006
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09D7E590  token=0x6000012  System.Void CollectSources(UnityEngine.Bounds includedWorldBounds, System.Int32 includedLayerMask, UnityEngine.AI.NavMeshCollectGeometry geometry, System.Int32 defaultArea, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results)
  RVA=0x09D7E3E0  token=0x6000013  System.Void CollectSources(UnityEngine.Transform root, System.Int32 includedLayerMask, UnityEngine.AI.NavMeshCollectGeometry geometry, System.Int32 defaultArea, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results)
  RVA=0x09D7E3AC  token=0x6000014  UnityEngine.AI.NavMeshBuildSource[] CollectSourcesInternal(System.Int32 includedLayerMask, UnityEngine.Bounds includedWorldBounds, UnityEngine.Transform root, System.Boolean useBounds, UnityEngine.AI.NavMeshCollectGeometry geometry, System.Int32 defaultArea, UnityEngine.AI.NavMeshBuildMarkup[] markups)
  RVA=0x03B74A70  token=0x6000015  System.Void CollectSourcesV2(UnityEngine.Bounds includedWorldBounds, System.Int32 includedLayerMask, System.Int32 defaultArea, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results)
  RVA=0x04276F7C  token=0x6000016  UnityEngine.AI.NavMeshBuildSource[] CollectSourcesV2Internal(System.Int32 includedLayerMask, UnityEngine.Bounds includedWorldBounds, System.Int32 defaultArea, UnityEngine.AI.NavMeshBuildMarkup[] markups)
  RVA=0x09D7E1BC  token=0x6000017  UnityEngine.AI.NavMeshData BuildNavMeshData(UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources, UnityEngine.Bounds localBounds, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Boolean useSubJob)
  RVA=0x09D7E820  token=0x6000018  System.Boolean UpdateNavMeshData(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources, UnityEngine.Bounds localBounds, System.Boolean useSubJob)
  RVA=0x09D7E800  token=0x6000019  System.Boolean UpdateNavMeshDataListInternal(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Object sources, UnityEngine.Bounds localBounds, System.Boolean useSubJob)
  RVA=0x03CA7E70  token=0x600001A  UnityEngine.AsyncOperation UpdateNavMeshDataAsync(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources, UnityEngine.Bounds localBounds, System.Boolean useSubJob)
  RVA=0x04277004  token=0x600001B  UnityEngine.AsyncOperation UpdateNavMeshDataAsyncListInternal(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Object sources, UnityEngine.Bounds localBounds, System.Boolean useSubJob)
  RVA=0x09D7E34C  token=0x600001C  UnityEngine.AI.NavMeshBuildSource[] CollectSourcesInternal_Injected(System.Int32 includedLayerMask, UnityEngine.Bounds& includedWorldBounds, UnityEngine.Transform root, System.Boolean useBounds, UnityEngine.AI.NavMeshCollectGeometry geometry, System.Int32 defaultArea, UnityEngine.AI.NavMeshBuildMarkup[] markups)
  RVA=0x03D460F0  token=0x600001D  UnityEngine.AI.NavMeshBuildSource[] CollectSourcesV2Internal_Injected(System.Int32 includedLayerMask, UnityEngine.Bounds& includedWorldBounds, System.Int32 defaultArea, UnityEngine.AI.NavMeshBuildMarkup[] markups)
  RVA=0x09D7E79C  token=0x600001E  System.Boolean UpdateNavMeshDataListInternal_Injected(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings& buildSettings, System.Object sources, UnityEngine.Bounds& localBounds, System.Boolean useSubJob)
  RVA=0x03CA7FB0  token=0x600001F  UnityEngine.AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings& buildSettings, System.Object sources, UnityEngine.Bounds& localBounds, System.Boolean useSubJob)
END_CLASS

CLASS: UnityEngine.AI.HGNavMeshAgent
TYPE:  sealed class
TOKEN: 0x2000007
SIZE:  0x18
EXTENDS: UnityEngine.Behaviour
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshAgent
TYPE:  sealed class
TOKEN: 0x2000008
SIZE:  0x18
EXTENDS: UnityEngine.Behaviour
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshObstacleShape
TYPE:  sealed struct
TOKEN: 0x2000009
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AI.NavMeshObstacleShapeCapsule  // const
  public    static  UnityEngine.AI.NavMeshObstacleShapeBox  // const
  public    static  UnityEngine.AI.NavMeshObstacleShapePolygon  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshObstacle
TYPE:  sealed class
TOKEN: 0x200000A
SIZE:  0x18
EXTENDS: UnityEngine.Behaviour
FIELDS:
PROPERTIES:
  height  get=0x09D7EBF4  set=0x09D7EC5C
  radius  get=0x09D7EC28  set=0x09D7ECA0
  carving  set=0x033913A0
  carveOnlyStationary  set=0x033912B0
  shape  set=0x03391260
  center  get=0x09D7EBC8  set=0x042761A4
  size  get=0x036A9CD0  set=0x042761B8
  ignoredSurfaceID  set=0x03391300
  carveArea  set=0x03391350
METHODS:
  RVA=0x09D7EB84  token=0x600002D  System.Void get_center_Injected(UnityEngine.Vector3& ret)
  RVA=0x03391440  token=0x600002E  System.Void set_center_Injected(UnityEngine.Vector3& value)
  RVA=0x036A9C80  token=0x600002F  System.Void get_size_Injected(UnityEngine.Vector3& ret)
  RVA=0x033913F0  token=0x6000030  System.Void set_size_Injected(UnityEngine.Vector3& value)
END_CLASS

CLASS: UnityEngine.AI.NavMeshHit
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x34
FIELDS:
  private           UnityEngine.Vector3             m_Position  // 0x10
  private           UnityEngine.Vector3             m_Normal  // 0x1c
  private           System.Single                   m_Distance  // 0x28
  private           System.Int32                    m_Mask  // 0x2c
  private           System.Int32                    m_Hit  // 0x30
PROPERTIES:
  position  get=0x03D85920
  normal  get=0x03D85900
  hit  get=0x09D7EAAC
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshData
TYPE:  sealed class
TOKEN: 0x200000C
SIZE:  0x18
EXTENDS: UnityEngine.Object
FIELDS:
PROPERTIES:
  sourceBounds  get=0x02CBB140
  position  get=0x03D2D9D0  set=0x09D7EA84
  rotation  get=0x03D36230  set=0x09D7EA98
METHODS:
  RVA=0x03D28AF0  token=0x6000034  System.Void .ctor(System.Int32 agentTypeID)
  RVA=0x03D28B50  token=0x6000035  System.Void Internal_Create(UnityEngine.AI.NavMeshData mono, System.Int32 agentTypeID)
  RVA=0x0359F320  token=0x600003B  System.Void AppendExtOffMeshLink(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single width, System.Boolean bidirectional, System.Int32 area, System.Single costModifier)
  RVA=0x042766E8  token=0x600003C  System.Void Internal_AppendExtOffMeshLink(UnityEngine.Vector3 startLeft, UnityEngine.Vector3 startRight, UnityEngine.Vector3 endRight, UnityEngine.Vector3 endLeft, System.Boolean bidirectional, System.Int32 area, System.Single costModifier)
  RVA=0x02CBB170  token=0x600003D  System.Void get_sourceBounds_Injected(UnityEngine.Bounds& ret)
  RVA=0x03D2DA00  token=0x600003E  System.Void get_position_Injected(UnityEngine.Vector3& ret)
  RVA=0x03D49200  token=0x600003F  System.Void set_position_Injected(UnityEngine.Vector3& value)
  RVA=0x03D36260  token=0x6000040  System.Void get_rotation_Injected(UnityEngine.Quaternion& ret)
  RVA=0x03D491B0  token=0x6000041  System.Void set_rotation_Injected(UnityEngine.Quaternion& value)
  RVA=0x0359F600  token=0x6000042  System.Void Internal_AppendExtOffMeshLink_Injected(UnityEngine.Vector3& startLeft, UnityEngine.Vector3& startRight, UnityEngine.Vector3& endRight, UnityEngine.Vector3& endLeft, System.Boolean bidirectional, System.Int32 area, System.Single costModifier)
END_CLASS

CLASS: UnityEngine.AI.NavMeshDataInstance
TYPE:  sealed struct
TOKEN: 0x200000D
SIZE:  0x14
FIELDS:
  private           System.Int32                    <id>k__BackingField  // 0x10
PROPERTIES:
  valid  get=0x025532C0
  id  get=0x03D4E980  set=0x03D4E970
  handleId  get=0x03D85860  set=0x03D4E970
  owner  set=0x09D7E9D4
METHODS:
  RVA=0x09D7E9C8  token=0x6000048  System.Void Remove()
END_CLASS

CLASS: UnityEngine.AI.NavMeshLinkData
TYPE:  sealed struct
TOKEN: 0x200000E
SIZE:  0x54
FIELDS:
  private           System.Boolean                  m_IsExt  // 0x10
  private           UnityEngine.Vector3             m_StartLeft  // 0x14
  private           UnityEngine.Vector3             m_StartRight  // 0x20
  private           UnityEngine.Vector3             m_EndRight  // 0x2c
  private           UnityEngine.Vector3             m_EndLeft  // 0x38
  private           System.Single                   m_CostModifier  // 0x44
  private           System.Int32                    m_Bidirectional  // 0x48
  private           System.Int32                    m_Area  // 0x4c
  private           System.Int32                    m_AgentTypeID  // 0x50
PROPERTIES:
  isExt  get=0x03D859A0  set=0x03D4F9D0
  startLeft  get=0x03D859B0  set=0x03D77290
  startRight  get=0x03D859D0  set=0x03D55570
  endRight  get=0x03D85980  set=0x03D5CBC0
  endLeft  get=0x03D85960  set=0x03D50F50
  costModifier  get=0x042743D0  set=0x03D56CB0
  bidirectional  get=0x05F42DD8  set=0x0300B960
  area  get=0x03D85950  set=0x03D4EDC0
  agentTypeID  get=0x03D85940  set=0x03D4EDB0
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshLinkInstance
TYPE:  sealed struct
TOKEN: 0x200000F
SIZE:  0x14
FIELDS:
  private           System.Int32                    <id>k__BackingField  // 0x10
PROPERTIES:
  valid  get=0x09D7EAC0
  id  get=0x03D4E980  set=0x03D4E970
  owner  set=0x09D7EAD4
METHODS:
  RVA=0x09D7EAB4  token=0x600005F  System.Void Remove()
END_CLASS

CLASS: UnityEngine.AI.NavMesh
TYPE:  static class
TOKEN: 0x2000010
SIZE:  0x10
FIELDS:
  public    static  UnityEngine.AI.NavMesh.OnNavMeshPreUpdateonPreUpdate  // static @ 0x0
  public    static  UnityEngine.AI.NavMesh.OnUnloadFinishDelegateonUnloadFinish  // static @ 0x8
METHODS:
  RVA=0x031AC030  token=0x6000061  System.Void Internal_CallOnNavMeshPreUpdate()
  RVA=0x042729A4  token=0x6000062  System.Boolean Raycast(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask)
  RVA=0x02549AD0  token=0x6000063  System.Boolean CalculatePath(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius)
  RVA=0x042704D4  token=0x6000064  System.Boolean CalculatePathInternal(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius)
  RVA=0x09D7EEDC  token=0x6000065  System.Boolean FindClosestEdge(UnityEngine.Vector3 sourcePosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask)
  RVA=0x042729BC  token=0x6000066  System.Boolean SamplePosition(UnityEngine.Vector3 sourcePosition, UnityEngine.AI.NavMeshHit& hit, System.Single maxDistance, System.Int32 areaMask)
  RVA=0x0384AD30  token=0x6000067  System.Int32 GetAreaFromName(System.String areaName)
  RVA=0x0307EDA0  token=0x6000068  UnityEngine.AI.NavMeshDataInstance AddNavMeshData(UnityEngine.AI.NavMeshData navMeshData)
  RVA=0x02CBB080  token=0x6000069  UnityEngine.AI.NavMeshDataInstance AddNavMeshData(UnityEngine.AI.NavMeshData navMeshData, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  RVA=0x09D7F21C  token=0x600006A  System.Void UpdateSurfaceTransform(UnityEngine.AI.NavMeshDataInstance handle, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  RVA=0x09D7F1A0  token=0x600006B  System.Void RemoveNavMeshData(UnityEngine.AI.NavMeshDataInstance handle)
  RVA=0x025532E0  token=0x600006C  System.Boolean IsValidNavMeshDataHandle(System.Int32 handle)
  RVA=0x09D7F074  token=0x600006D  System.Boolean IsValidLinkHandle(System.Int32 handle)
  RVA=0x09D7EF38  token=0x600006E  System.Boolean InternalSetOwner(System.Int32 dataID, System.Int32 ownerID)
  RVA=0x09D7EEF8  token=0x600006F  System.Boolean InternalSetLinkOwner(System.Int32 linkID, System.Int32 ownerID)
  RVA=0x0307EE00  token=0x6000070  System.Int32 AddNavMeshDataInternal(UnityEngine.AI.NavMeshData navMeshData)
  RVA=0x042730B8  token=0x6000071  System.Int32 AddNavMeshDataTransformedInternal(UnityEngine.AI.NavMeshData navMeshData, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  RVA=0x09D7F16C  token=0x6000072  System.Void RemoveNavMeshDataInternal(System.Int32 handle)
  RVA=0x0300B8D0  token=0x6000073  UnityEngine.AI.NavMeshLinkInstance AddLink(UnityEngine.AI.NavMeshLinkData link, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  RVA=0x09D7F164  token=0x6000074  System.Void RemoveLink(UnityEngine.AI.NavMeshLinkInstance handle)
  RVA=0x042749B0  token=0x6000075  System.Int32 AddLinkInternal(UnityEngine.AI.NavMeshLinkData link, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  RVA=0x09D7F130  token=0x6000076  System.Void RemoveLinkInternal(System.Int32 handle)
  RVA=0x0307F1C0  token=0x6000077  UnityEngine.AI.NavMeshBuildSettings GetSettingsByID(System.Int32 agentTypeID)
  RVA=0x037BD250  token=0x6000078  UnityEngine.AI.NavMeshBuildSettings GetSettingsByIndex(System.Int32 index)
  RVA=0x09D7F208  token=0x6000079  System.Void UpdateSurfaceTransformInternal(System.Int32 surfaceID, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  RVA=0x034E3FF0  token=0x600007A  System.Boolean DetachFromSurface(System.Int32 chunkSurfaceId, System.Int32 builderSurfaceId, System.Int32 indexX, System.Int32 indexZ)
  RVA=0x0307F250  token=0x600007B  System.Boolean SetBuilderSurfaceParams(System.Int32 surfID, System.Single chunkSize, System.Single tileSize, System.Single centerX, System.Single centerZ, System.Single sizeX, System.Single sizeZ)
  RVA=0x034E4000  token=0x600007C  System.Boolean Internal_DetachFromSurface(System.Int32 chunkSurfaceId, System.Int32 builderSurfaceId, System.Int32 indexX, System.Int32 indexZ)
  RVA=0x0307F420  token=0x600007D  System.Boolean Internal_SetBuilderSurfaceParams(System.Int32 surfID, System.Single chunkSize, System.Single tileSize, System.Single centerX, System.Single centerZ, System.Single sizeX, System.Single sizeZ)
  RVA=0x09D7F0A8  token=0x600007E  System.Int32 LoadDynamicBakeTile(UnityEngine.AI.NavMeshData navMeshData)
  RVA=0x09D7F1A8  token=0x600007F  System.Void UnloadDynamicBakeTile(System.Int32 dynamicTileID)
  RVA=0x09D7EFD8  token=0x6000080  System.Int32 Internal_LoadDynamicBakeTile(UnityEngine.AI.NavMeshData navMeshData)
  RVA=0x09D7F00C  token=0x6000081  System.Void Internal_UnloadDynamicBakeTile(System.Int32 dynamicTileID)
  RVA=0x09D7F120  token=0x6000082  System.Int32 ModifyVolumeArea(System.Collections.Generic.List<UnityEngine.Vector3> center, System.Collections.Generic.List<UnityEngine.Vector3> ext, System.Collections.Generic.List<UnityEngine.Quaternion> rotation, System.Int32 area)
  RVA=0x09D7F0BC  token=0x6000083  System.Int32 ModifyBoxAreaInternal(System.Collections.Generic.List<UnityEngine.Vector3> center, System.Collections.Generic.List<UnityEngine.Vector3> ext, System.Collections.Generic.List<UnityEngine.Quaternion> rotation, System.Int32 area)
  RVA=0x03B46B00  token=0x6000084  System.Int32 ModifyVolumeArea(System.Collections.Generic.List<UnityEngine.Vector3> verts, System.Single hMin, System.Single hMax, System.Int32 area)
  RVA=0x03B46B10  token=0x6000085  System.Int32 ModifyPolygonAreaInternal(System.Collections.Generic.List<UnityEngine.Vector3> verts, System.Single hMin, System.Single hMax, System.Int32 area)
  RVA=0x09D7F0B4  token=0x6000086  System.Void LoadExtOffMeshLinks(System.Int32 surfaceID)
  RVA=0x03D4BEE0  token=0x6000087  System.Void Internal_LoadExtOffMeshLinks(System.Int32 surfaceID)
  RVA=0x02553320  token=0x6000088  UnityEngine.AsyncOperation AddNavMeshDataAsync(System.Int32& surfaceID, UnityEngine.AI.NavMeshData navMeshData, System.UInt64 surfTileID)
  RVA=0x025533B0  token=0x6000089  UnityEngine.AsyncOperation AddNavMeshDataAsyncInternal(System.Int32& surfaceID, UnityEngine.AI.NavMeshData navMeshData, System.UInt64 surfTileID)
  RVA=0x09D7EE80  token=0x600008A  System.Void CancelAsyncAdd(System.UInt64 surfTileID)
  RVA=0x09D7EF78  token=0x600008B  System.Void Internal_CancelAsyncAdd(System.UInt64 surfaceID)
  RVA=0x04276458  token=0x600008C  System.Void UnloadDataAsync(System.Int32 surfaceID, System.UInt64 surfTileID)
  RVA=0x0399FA60  token=0x600008D  System.Void Internal_UnloadDataAsync(System.Int32 surfaceID, System.UInt64 surfTileID)
  RVA=0x034E4070  token=0x600008E  System.Void Internal_InvokeOnUnloadFinish(System.UInt64 surfTileID)
  RVA=0x04270534  token=0x600008F  System.Boolean IsSurfaceUnloading(System.UInt64 surfTileID)
  RVA=0x03828330  token=0x6000090  System.Boolean Internal_IsSurfaceUnloading(System.UInt64 surfTileID)
  RVA=0x09D7EEF0  token=0x6000091  System.Void ForceClearUnloadDataRequest()
  RVA=0x09D7EFAC  token=0x6000092  System.Void Internal_ForceClearUnloadDataRequest()
  RVA=0x0278F190  token=0x6000093  System.Void CalculatePathAsync(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius)
  RVA=0x0427183C  token=0x6000094  System.Void CalculatePathAsyncInternal(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius)
  RVA=0x04274DB4  token=0x6000095  System.Void SetFindPathMaxIterPerFrame(System.Int32 maxIterPerFrame)
  RVA=0x03D3D720  token=0x6000096  System.Void Internal_SetFindPathMaxIterPerFrame(System.Int32 maxIterPerFrame)
  RVA=0x04276598  token=0x6000097  System.Void CancelAsyncCalculatePath(UnityEngine.AI.NavMeshPath path)
  RVA=0x03B31E70  token=0x6000098  System.Void Internal_CancelAsyncCalculatePath(UnityEngine.AI.NavMeshPath path)
  RVA=0x04276590  token=0x6000099  System.Void RegisterAutoRepath(UnityEngine.AI.NavMeshPath path)
  RVA=0x03CDDD00  token=0x600009A  System.Void Internal_RegisterAutoRepath(UnityEngine.AI.NavMeshPath path)
  RVA=0x09D7F1B0  token=0x600009B  System.Void UnregisterAutoRepath(UnityEngine.AI.NavMeshPath path)
  RVA=0x09D7F040  token=0x600009C  System.Void Internal_UnregisterAutoRepath(UnityEngine.AI.NavMeshPath path)
  RVA=0x04271874  token=0x600009D  System.Boolean RaycastNearestPoint(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask)
  RVA=0x0311BA10  token=0x600009E  System.Boolean Raycast_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.Vector3& targetPosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask)
  RVA=0x02549BB0  token=0x600009F  System.Boolean CalculatePathInternal_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.Vector3& targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius)
  RVA=0x09D7EE88  token=0x60000A0  System.Boolean FindClosestEdge_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask)
  RVA=0x02E53550  token=0x60000A1  System.Boolean SamplePosition_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.AI.NavMeshHit& hit, System.Single maxDistance, System.Int32 areaMask)
  RVA=0x02CBADE0  token=0x60000A2  System.Int32 AddNavMeshDataTransformedInternal_Injected(UnityEngine.AI.NavMeshData navMeshData, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  RVA=0x0300B980  token=0x60000A3  System.Int32 AddLinkInternal_Injected(UnityEngine.AI.NavMeshLinkData& link, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  RVA=0x0307F200  token=0x60000A4  System.Void GetSettingsByID_Injected(System.Int32 agentTypeID, UnityEngine.AI.NavMeshBuildSettings& ret)
  RVA=0x037BD290  token=0x60000A5  System.Void GetSettingsByIndex_Injected(System.Int32 index, UnityEngine.AI.NavMeshBuildSettings& ret)
  RVA=0x09D7F1B8  token=0x60000A6  System.Void UpdateSurfaceTransformInternal_Injected(System.Int32 surfaceID, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  RVA=0x0389F660  token=0x60000A7  System.Void CalculatePathAsyncInternal_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.Vector3& targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius)
  RVA=0x03645130  token=0x60000A8  System.Boolean RaycastNearestPoint_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.Vector3& targetPosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask)
END_CLASS

CLASS: UnityEngine.AI.NavMeshBuildSourceShape
TYPE:  sealed struct
TOKEN: 0x2000013
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AI.NavMeshBuildSourceShapeMesh  // const
  public    static  UnityEngine.AI.NavMeshBuildSourceShapeTerrain  // const
  public    static  UnityEngine.AI.NavMeshBuildSourceShapeBox  // const
  public    static  UnityEngine.AI.NavMeshBuildSourceShapeSphere  // const
  public    static  UnityEngine.AI.NavMeshBuildSourceShapeCapsule  // const
  public    static  UnityEngine.AI.NavMeshBuildSourceShapeModifierBox  // const
  public    static  UnityEngine.AI.NavMeshBuildSourceShapePhysicsTriangleMesh  // const
  public    static  UnityEngine.AI.NavMeshBuildSourceShapePhysicsConvexMesh  // const
  public    static  UnityEngine.AI.NavMeshBuildSourceShapePhysicsTerrain  // const
  public    static  UnityEngine.AI.NavMeshBuildSourceShapeModifierPoly  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshCollectGeometry
TYPE:  sealed struct
TOKEN: 0x2000014
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AI.NavMeshCollectGeometryRenderMeshes  // const
  public    static  UnityEngine.AI.NavMeshCollectGeometryPhysicsColliders  // const
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshBuildSource
TYPE:  sealed struct
TOKEN: 0x2000015
SIZE:  0x88
FIELDS:
  private           UnityEngine.Matrix4x4           m_Transform  // 0x10
  private           UnityEngine.Vector3             m_Size  // 0x50
  private           UnityEngine.AI.NavMeshBuildSourceShapem_Shape  // 0x5c
  private           System.Int32                    m_Area  // 0x60
  private           System.Int32                    m_InstanceID  // 0x64
  private           System.Int32                    m_ComponentID  // 0x68
  private           System.Boolean                  m_IsConvex  // 0x6c
  private           System.IntPtr                   m_EcsShape  // 0x70
  public            System.Collections.Generic.List<UnityEngine.Vector3>convexVerts  // 0x78
  public            System.Single                   convexHmin  // 0x80
  public            System.Single                   convexHmax  // 0x84
PROPERTIES:
  transform  get=0x03D858B0  set=0x03D858E0
  size  get=0x03D85890  set=0x03D52330
  shape  get=0x03D85880  set=0x03D4EE30
  area  get=0x03D85870  set=0x03D4EF20
  sourceObject  get=0x09D7E1B0
  component  get=0x09D7E1A4
METHODS:
  RVA=0x09D7E13C  token=0x60000B7  UnityEngine.Component InternalGetComponent(System.Int32 instanceID)
  RVA=0x09D7E170  token=0x60000B8  UnityEngine.Object InternalGetObject(System.Int32 instanceID)
END_CLASS

CLASS: UnityEngine.AI.NavMeshBuildMarkup
TYPE:  sealed struct
TOKEN: 0x2000016
SIZE:  0x20
FIELDS:
  private           System.Int32                    m_OverrideArea  // 0x10
  private           System.Int32                    m_Area  // 0x14
  private           System.Int32                    m_IgnoreFromBuild  // 0x18
  private           System.Int32                    m_InstanceID  // 0x1c
PROPERTIES:
  overrideArea  set=0x09D7E0B8
  area  set=0x03D51720
  ignoreFromBuild  set=0x0237ACC0
  root  set=0x09D7E0C0
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshBuildSettings
TYPE:  sealed struct
TOKEN: 0x2000017
SIZE:  0x6C
FIELDS:
  private           System.Int32                    m_AgentTypeID  // 0x10
  private           System.Single                   m_AgentRadius  // 0x14
  private           System.Single                   m_AgentHeight  // 0x18
  private           System.Single                   m_AgentSlope  // 0x1c
  private           System.Single                   m_AgentClimb  // 0x20
  private           System.Single                   m_LedgeDropHeight  // 0x24
  private           System.Single                   m_MaxJumpAcrossDistance  // 0x28
  private           System.Single                   m_MinRegionArea  // 0x2c
  private           System.Int32                    m_OverrideVoxelSize  // 0x30
  private           System.Single                   m_VoxelSize  // 0x34
  private           System.Int32                    m_OverrideTileSize  // 0x38
  private           System.Int32                    m_TileSize  // 0x3c
  private           System.Int32                    m_AccuratePlacement  // 0x40
  private           System.UInt32                   m_MaxJobWorkers  // 0x44
  private           System.Int32                    m_PreserveTilesOutsideBounds  // 0x48
  private           System.Int32                    m_PartitioningMethod  // 0x4c
  private           System.Int32                    m_FilterLowHangingObstacles  // 0x50
  private           System.Int32                    m_FilterLedgeSpans  // 0x54
  private           System.Int32                    m_FilterWalkableLowHeightSpans  // 0x58
  private           System.Int32                    m_erodeAgainstWallSpans  // 0x5c
  private           System.Int32                    m_cliffIndent  // 0x60
  private           System.Int32                    m_DynamicNavmeshSurfaceType  // 0x64
  private           UnityEngine.AI.NavMeshBuildDebugSettingsm_Debug  // 0x68
PROPERTIES:
  agentTypeID  get=0x03D85860  set=0x03D4E970
  agentRadius  get=0x03D85850
  agentHeight  get=0x03D85840
  agentClimb  get=0x03D85830
  minRegionArea  set=0x03D4F120
  overrideVoxelSize  set=0x0307F300
  voxelSize  set=0x03D52500
  overrideTileSize  set=0x0307F2E0
  tileSize  set=0x03D4EDE0
  partitioningMethod  set=0x03D4EDC0
  filterLowHangingObstacles  set=0x0307F260
  filterLedgeSpans  set=0x0307F280
  filterWalkableLowHeightSpans  set=0x0307F2A0
  erodeAgainstWallSpans  set=0x0307F2C0
  cliffIndent  set=0x03D4EF20
METHODS:
END_CLASS

CLASS: UnityEngine.AI.NavMeshBuildDebugSettings
TYPE:  sealed struct
TOKEN: 0x2000018
SIZE:  0x11
FIELDS:
  private           System.Byte                     m_Flags  // 0x10
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.AI.PolygonId
TYPE:  sealed struct
TOKEN: 0x2000019
SIZE:  0x18
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           System.UInt64                   polyRef  // 0x10
METHODS:
  RVA=0x02361C20  token=0x60000CD  System.Boolean IsNull()
  RVA=0x0232CE30  token=0x60000CE  System.Boolean op_Equality(UnityEngine.Experimental.AI.PolygonId x, UnityEngine.Experimental.AI.PolygonId y)
  RVA=0x03CFE7D0  token=0x60000CF  System.Boolean op_Inequality(UnityEngine.Experimental.AI.PolygonId x, UnityEngine.Experimental.AI.PolygonId y)
  RVA=0x03D859F0  token=0x60000D0  System.Int32 GetHashCode()
  RVA=0x09D7F378  token=0x60000D1  System.Boolean Equals(UnityEngine.Experimental.AI.PolygonId rhs)
  RVA=0x09D7F30C  token=0x60000D2  System.Boolean Equals(System.Object obj)
END_CLASS

CLASS: UnityEngine.Experimental.AI.NavMeshLocation
TYPE:  sealed struct
TOKEN: 0x200001A
SIZE:  0x28
FIELDS:
  private   readonly UnityEngine.Experimental.AI.PolygonId<polygon>k__BackingField  // 0x10
  private   readonly UnityEngine.Vector3             <position>k__BackingField  // 0x18
PROPERTIES:
  polygon  get=0x020C61B0
  position  get=0x03D5E630
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.AI.PathQueryStatus
TYPE:  sealed struct
TOKEN: 0x200001B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.AI.PathQueryStatusFailure  // const
  public    static  UnityEngine.Experimental.AI.PathQueryStatusSuccess  // const
  public    static  UnityEngine.Experimental.AI.PathQueryStatusInProgress  // const
  public    static  UnityEngine.Experimental.AI.PathQueryStatusStatusDetailMask  // const
  public    static  UnityEngine.Experimental.AI.PathQueryStatusWrongMagic  // const
  public    static  UnityEngine.Experimental.AI.PathQueryStatusWrongVersion  // const
  public    static  UnityEngine.Experimental.AI.PathQueryStatusOutOfMemory  // const
  public    static  UnityEngine.Experimental.AI.PathQueryStatusInvalidParam  // const
  public    static  UnityEngine.Experimental.AI.PathQueryStatusBufferTooSmall  // const
  public    static  UnityEngine.Experimental.AI.PathQueryStatusOutOfNodes  // const
  public    static  UnityEngine.Experimental.AI.PathQueryStatusPartialResult  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.AI.NavMeshWorld
TYPE:  sealed struct
TOKEN: 0x200001C
SIZE:  0x18
FIELDS:
  private           System.IntPtr                   world  // 0x10
METHODS:
  RVA=0x02A7A840  token=0x60000D5  UnityEngine.Experimental.AI.NavMeshWorld GetDefaultWorld()
  RVA=0x02A7A890  token=0x60000D6  System.Void GetDefaultWorld_Injected(UnityEngine.Experimental.AI.NavMeshWorld& ret)
END_CLASS

CLASS: UnityEngine.Experimental.AI.NavMeshQuery
TYPE:  sealed struct
TOKEN: 0x200001D
SIZE:  0x18
IMPLEMENTS: System.IDisposable
FIELDS:
  private           System.IntPtr                   m_NavMeshQuery  // 0x10
METHODS:
  RVA=0x0307F380  token=0x60000D7  System.Void .ctor(UnityEngine.Experimental.AI.NavMeshWorld world, Unity.Collections.Allocator allocator, System.Int32 pathNodePoolSize)
  RVA=0x03334BD0  token=0x60000D8  System.Void Dispose()
  RVA=0x04274DBC  token=0x60000D9  System.IntPtr Create(UnityEngine.Experimental.AI.NavMeshWorld world, System.Int32 nodePoolSize)
  RVA=0x03334C50  token=0x60000DA  System.Void Destroy(System.IntPtr navMeshQuery)
  RVA=0x02792F30  token=0x60000DB  UnityEngine.Experimental.AI.NavMeshLocation MapLocation(System.IntPtr navMeshQuery, UnityEngine.Vector3 position, UnityEngine.Vector3 extents, System.Int32 agentTypeID, System.Int32 areaMask)
  RVA=0x02792E60  token=0x60000DC  UnityEngine.Experimental.AI.NavMeshLocation MapLocation(UnityEngine.Vector3 position, UnityEngine.Vector3 extents, System.Int32 agentTypeID, System.Int32 areaMask)
  RVA=0x02790920  token=0x60000DD  UnityEngine.Experimental.AI.NavMeshLocation MoveLocation(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation location, UnityEngine.Vector3 target, System.Int32 areaMask)
  RVA=0x02790850  token=0x60000DE  UnityEngine.Experimental.AI.NavMeshLocation MoveLocation(UnityEngine.Experimental.AI.NavMeshLocation location, UnityEngine.Vector3 target, System.Int32 areaMask)
  RVA=0x09D7ED48  token=0x60000DF  UnityEngine.Experimental.AI.PathQueryStatus Raycast(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation start, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, System.Void* costs, UnityEngine.AI.NavMeshHit& hit, System.Void* path, System.Int32& pathCount, System.Int32 maxPath)
  RVA=0x09D7EDA0  token=0x60000E0  UnityEngine.Experimental.AI.PathQueryStatus Raycast(UnityEngine.AI.NavMeshHit& hit, UnityEngine.Experimental.AI.NavMeshLocation start, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, Unity.Collections.NativeArray<System.Single> costs)
  RVA=0x03477910  token=0x60000E1  System.IntPtr Create_Injected(UnityEngine.Experimental.AI.NavMeshWorld& world, System.Int32 nodePoolSize)
  RVA=0x02792FC0  token=0x60000E2  System.Void MapLocation_Injected(System.IntPtr navMeshQuery, UnityEngine.Vector3& position, UnityEngine.Vector3& extents, System.Int32 agentTypeID, System.Int32 areaMask, UnityEngine.Experimental.AI.NavMeshLocation& ret)
  RVA=0x02790670  token=0x60000E3  System.Void MoveLocation_Injected(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation& location, UnityEngine.Vector3& target, System.Int32 areaMask, UnityEngine.Experimental.AI.NavMeshLocation& ret)
  RVA=0x09D7ECE4  token=0x60000E4  UnityEngine.Experimental.AI.PathQueryStatus Raycast_Injected(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation& start, UnityEngine.Vector3& targetPosition, System.Int32 areaMask, System.Void* costs, UnityEngine.AI.NavMeshHit& hit, System.Void* path, System.Int32& pathCount, System.Int32 maxPath)
END_CLASS

