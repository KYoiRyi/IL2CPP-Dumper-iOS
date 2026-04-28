// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TerrainModule.dll
// Classes:  21
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

CLASS: HeightmapChangedCallback
TYPE:  sealed class
TOKEN: 0x2000006
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09E29DB0  token=0x6000018  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x0500800C  token=0x6000019  System.Void Invoke(UnityEngine.Terrain terrain, UnityEngine.RectInt heightRegion, System.Boolean synched)
END_CLASS

CLASS: TextureChangedCallback
TYPE:  sealed class
TOKEN: 0x2000007
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09E2DC64  token=0x600001A  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x050197BC  token=0x600001B  System.Void Invoke(UnityEngine.Terrain terrain, System.String textureName, UnityEngine.RectInt texelRegion, System.Boolean synched)
END_CLASS

CLASS: BoundaryValueType
TYPE:  sealed struct
TOKEN: 0x200000D
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMaxHeightmapRes  // const
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMinDetailResPerPatch  // const
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMaxDetailResPerPatch  // const
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMaxDetailPatchCount  // const
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMaxDetailsPerRes  // const
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMinAlphamapRes  // const
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMaxAlphamapRes  // const
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMinBaseMapRes  // const
  public    static  UnityEngine.TerrainData.BoundaryValueTypeMaxBaseMapRes  // const
METHODS:
END_CLASS

CLASS: <>c__DisplayClass3_0
TYPE:  sealed class
TOKEN: 0x2000012
SIZE:  0x18
FIELDS:
  public            System.Int32                    groupID  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60000B7  System.Void .ctor()
  RVA=0x09E2DEE0  token=0x60000B8  System.Boolean <CreateFromPlacement>b__0(UnityEngine.Terrain x)
END_CLASS

CLASS: <>c__DisplayClass2_0
TYPE:  sealed class
TOKEN: 0x2000014
SIZE:  0x18
FIELDS:
  public            System.Boolean                  onlyAutoConnectedTerrains  // 0x10
METHODS:
  RVA=0x0350B670  token=0x60000BD  System.Void .ctor()
END_CLASS

CLASS: <>c__DisplayClass2_1
TYPE:  sealed class
TOKEN: 0x2000015
SIZE:  0x20
FIELDS:
  public            UnityEngine.Terrain             t  // 0x10
  public            UnityEngine.TerrainUtils.TerrainUtility.<>c__DisplayClass2_0CS$<>8__locals1  // 0x18
METHODS:
  RVA=0x0350B670  token=0x60000BE  System.Void .ctor()
  RVA=0x09E2DE64  token=0x60000BF  System.Boolean <CollectTerrains>b__0(UnityEngine.Terrain x)
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

CLASS: UnityEngine.Terrain
TYPE:  sealed class
TOKEN: 0x2000004
SIZE:  0x18
EXTENDS: UnityEngine.Behaviour
FIELDS:
PROPERTIES:
  terrainData  get=0x09E2DA00  set=0x09E2DC20
  detailObjectDistance  set=0x09E2DABC
  detailObjectDensity  set=0x09E2DA78
  lightmapIndex  set=0x09E2DB44
  lightmapScaleOffset  set=0x09E2DBC8
  materialTemplate  get=0x09E2D9CC  set=0x09E2DBDC
  allowAutoConnect  get=0x09E2D964  set=0x09E2DA34
  groupingID  get=0x09E2D998
  drawInstanced  set=0x09E2DB00
  activeTerrains  get=0x09E2D938
METHODS:
  RVA=0x09E2D8D4  token=0x600000F  System.Void SetNeighbors(UnityEngine.Terrain left, UnityEngine.Terrain top, UnityEngine.Terrain right, UnityEngine.Terrain bottom)
  RVA=0x09E2D898  token=0x6000010  System.Void Flush()
  RVA=0x09E2D8CC  token=0x6000012  System.Void GetActiveTerrains(System.Collections.Generic.List<UnityEngine.Terrain> terrainList)
  RVA=0x031B4D60  token=0x6000013  System.Void Internal_FillActiveTerrainList(System.Object terrainList)
  RVA=0x0426FE60  token=0x6000014  System.Void .ctor()
  RVA=0x09E2DB84  token=0x6000015  System.Void set_lightmapScaleOffset_Injected(UnityEngine.Vector4& value)
END_CLASS

CLASS: UnityEngine.TerrainCallbacks
TYPE:  static class
TOKEN: 0x2000005
SIZE:  0x10
FIELDS:
  private   static  UnityEngine.TerrainCallbacks.HeightmapChangedCallbackheightmapChanged  // static @ 0x0
  private   static  UnityEngine.TerrainCallbacks.TextureChangedCallbacktextureChanged  // static @ 0x8
METHODS:
  RVA=0x09E29E84  token=0x6000016  System.Void InvokeHeightmapChangedCallback(UnityEngine.TerrainData terrainData, UnityEngine.RectInt heightRegion, System.Boolean synched)
  RVA=0x09E29F58  token=0x6000017  System.Void InvokeTextureChangedCallback(UnityEngine.TerrainData terrainData, System.String textureName, UnityEngine.RectInt texelRegion, System.Boolean synched)
END_CLASS

CLASS: UnityEngine.TreePrototype
TYPE:  sealed class
TOKEN: 0x2000008
SIZE:  0x20
FIELDS:
  private           UnityEngine.GameObject          m_Prefab  // 0x10
  private           System.Single                   m_BendFactor  // 0x18
  private           System.Int32                    m_NavMeshLod  // 0x1c
PROPERTIES:
  prefab  get=0x03D66B80  set=0x0426FEE0
  bendFactor  get=0x03D85C60  set=0x03D4EC00
  navMeshLod  get=0x03D66B90
METHODS:
  RVA=0x0350B670  token=0x6000021  System.Void .ctor()
  RVA=0x09E2DD38  token=0x6000022  System.Boolean Equals(System.Object obj)
  RVA=0x03D86D00  token=0x6000023  System.Int32 GetHashCode()
  RVA=0x09E2DD9C  token=0x6000024  System.Boolean Equals(UnityEngine.TreePrototype other)
END_CLASS

CLASS: UnityEngine.DetailRenderMode
TYPE:  sealed struct
TOKEN: 0x2000009
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.DetailRenderMode    GrassBillboard  // const
  public    static  UnityEngine.DetailRenderMode    VertexLit  // const
  public    static  UnityEngine.DetailRenderMode    Grass  // const
METHODS:
END_CLASS

CLASS: UnityEngine.DetailPrototype
TYPE:  sealed class
TOKEN: 0x200000A
SIZE:  0x68
FIELDS:
  private   static readonly UnityEngine.Color               DefaultHealthColor  // static @ 0x0
  private   static readonly UnityEngine.Color               DefaultDryColor  // static @ 0x10
  private           UnityEngine.GameObject          m_Prototype  // 0x10
  private           UnityEngine.Texture2D           m_PrototypeTexture  // 0x18
  private           UnityEngine.Color               m_HealthyColor  // 0x20
  private           UnityEngine.Color               m_DryColor  // 0x30
  private           System.Single                   m_MinWidth  // 0x40
  private           System.Single                   m_MaxWidth  // 0x44
  private           System.Single                   m_MinHeight  // 0x48
  private           System.Single                   m_MaxHeight  // 0x4c
  private           System.Int32                    m_NoiseSeed  // 0x50
  private           System.Single                   m_NoiseSpread  // 0x54
  private           System.Single                   m_HoleEdgePadding  // 0x58
  private           System.Int32                    m_RenderMode  // 0x5c
  private           System.Int32                    m_UsePrototypeMesh  // 0x60
  private           System.Int32                    m_UseInstancing  // 0x64
PROPERTIES:
  prototype  get=0x03D66B80  set=0x0426FEE0
  prototypeTexture  get=0x03D61D00  set=0x022C3A90
  minWidth  get=0x04270740  set=0x03D4ECF0
  maxWidth  get=0x04270750  set=0x03D4ED00
  minHeight  get=0x04270760  set=0x03D5BE60
  maxHeight  get=0x03D88030  set=0x03D5E680
  noiseSpread  get=0x03D88040  set=0x03D4F680
  healthyColor  get=0x03D88020  set=0x03D54E10
  dryColor  get=0x03D87900  set=0x03D4FD40
  renderMode  get=0x03D88050  set=0x03D4EF40
  usePrototypeMesh  set=0x09E29D94
METHODS:
  RVA=0x09E29B9C  token=0x600003A  System.Void .ctor()
  RVA=0x09E29C54  token=0x600003B  System.Void .ctor(UnityEngine.DetailPrototype other)
  RVA=0x09E29934  token=0x600003C  System.Boolean Equals(System.Object obj)
  RVA=0x03D86D00  token=0x600003D  System.Int32 GetHashCode()
  RVA=0x09E29998  token=0x600003E  System.Boolean Equals(UnityEngine.DetailPrototype other)
  RVA=0x09E29B44  token=0x600003F  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.TreeInstance
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x38
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            System.Single                   widthScale  // 0x1c
  public            System.Single                   heightScale  // 0x20
  public            System.Single                   rotation  // 0x24
  public            UnityEngine.Color32             color  // 0x28
  public            UnityEngine.Color32             lightmapColor  // 0x2c
  public            System.Int32                    prototypeIndex  // 0x30
  private           System.Single                   temporaryDistance  // 0x34
METHODS:
END_CLASS

CLASS: UnityEngine.TerrainData
TYPE:  sealed class
TOKEN: 0x200000C
SIZE:  0x18
EXTENDS: UnityEngine.Object
FIELDS:
  private   static  System.String                   k_ScriptingInterfaceName  // const
  private   static  System.String                   k_ScriptingInterfacePrefix  // const
  private   static  System.String                   k_HeightmapPrefix  // const
  private   static  System.String                   k_DetailDatabasePrefix  // const
  private   static  System.String                   k_TreeDatabasePrefix  // const
  private   static  System.String                   k_SplatDatabasePrefix  // const
  private   static readonly System.Int32                    k_MaximumResolution  // static @ 0x0
  private   static readonly System.Int32                    k_MinimumDetailResolutionPerPatch  // static @ 0x4
  private   static readonly System.Int32                    k_MaximumDetailResolutionPerPatch  // static @ 0x8
  private   static readonly System.Int32                    k_MaximumDetailPatchCount  // static @ 0xc
  private   static readonly System.Int32                    k_MaximumDetailsPerRes  // static @ 0x10
  private   static readonly System.Int32                    k_MinimumAlphamapResolution  // static @ 0x14
  private   static readonly System.Int32                    k_MaximumAlphamapResolution  // static @ 0x18
  private   static readonly System.Int32                    k_MinimumBaseMapResolution  // static @ 0x1c
  private   static readonly System.Int32                    k_MaximumBaseMapResolution  // static @ 0x20
PROPERTIES:
  heightmapTexture  get=0x09E2B484
  heightmapResolution  get=0x09E2B478  set=0x09E2B900
  internalHeightmapResolution  get=0x09E2B4FC  set=0x09E2BA28
  holesTexture  get=0x09E2B4CC
  enableHolesTextureCompression  get=0x09E2B444  set=0x09E2B8BC
  holesResolution  get=0x09E2B4B8
  size  get=0x09E2B574  set=0x09E2BAAC
  detailWidth  get=0x09E2B410
  detailHeight  get=0x09E2B340
  detailResolution  get=0x09E2B3DC
  detailResolutionPerPatch  get=0x09E2B3A8
  detailPrototypes  get=0x09E2B374  set=0x09E2B878
  treeInstances  get=0x09E2B5D4
  treePrototypes  get=0x09E2B5E0  set=0x09E2BB04
  alphamapLayers  get=0x09E2B240
  alphamapResolution  get=0x09E2B234  set=0x09E2B688
  Internal_alphamapResolution  get=0x09E2B1CC  set=0x09E2B648
  alphamapWidth  get=0x09E2B234
  alphamapHeight  get=0x09E2B234
  baseMapResolution  get=0x09E2B334
  Internal_baseMapResolution  get=0x09E2B200
  alphamapTextureCount  get=0x09E2B274
  alphamapTextures  get=0x09E2B2A8
  terrainLayers  get=0x09E2B5A0  set=0x09E2BAC0
  users  get=0x09E2B614
METHODS:
  RVA=0x09E2A13C  token=0x6000040  System.Int32 GetBoundaryValue(UnityEngine.TerrainData.BoundaryValueType type)
  RVA=0x09E2B174  token=0x6000041  System.Void .ctor()
  RVA=0x09E2A550  token=0x6000042  System.Void Internal_Create(UnityEngine.TerrainData terrainData)
  RVA=0x09E2A848  token=0x600004B  System.Boolean IsHolesTextureCompressed()
  RVA=0x09E2A2EC  token=0x600004C  UnityEngine.RenderTexture GetHolesTexture()
  RVA=0x09E2A170  token=0x600004D  UnityEngine.Texture2D GetCompressedHolesTexture()
  RVA=0x09E2A408  token=0x6000051  System.Single GetInterpolatedHeight(System.Single x, System.Single y)
  RVA=0x09E2A204  token=0x6000052  System.Single[,] GetHeights(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height)
  RVA=0x09E2A5E4  token=0x6000053  System.Single[,] Internal_GetHeights(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height)
  RVA=0x09E2AD7C  token=0x6000054  System.Void SetHeights(System.Int32 xBase, System.Int32 yBase, System.Single[,] heights)
  RVA=0x09E2A7E8  token=0x6000055  System.Void Internal_SetHeights(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height, System.Single[,] heights)
  RVA=0x09E2A320  token=0x6000056  System.Boolean[,] GetHoles(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height)
  RVA=0x09E2A644  token=0x6000057  System.Boolean[,] Internal_GetHoles(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height)
  RVA=0x09E2A4C0  token=0x6000058  UnityEngine.Vector3 GetInterpolatedNormal(System.Single x, System.Single y)
  RVA=0x09E2AA98  token=0x600005B  System.Void SetDetailResolution(System.Int32 detailResolution, System.Int32 resolutionPerPatch)
  RVA=0x09E2A798  token=0x600005C  System.Void Internal_SetDetailResolution(System.Int32 patchCount, System.Int32 resolutionPerPatch)
  RVA=0x09E2A87C  token=0x600005F  System.Void RefreshPrototypes()
  RVA=0x09E2A4F0  token=0x6000062  System.Int32[] GetSupportedLayers(System.Int32 xBase, System.Int32 yBase, System.Int32 totalWidth, System.Int32 totalHeight)
  RVA=0x09E2A1A4  token=0x6000063  System.Int32[,] GetDetailLayer(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height, System.Int32 layer)
  RVA=0x09E2AA08  token=0x6000064  System.Void SetDetailLayer(System.Int32 xBase, System.Int32 yBase, System.Int32 layer, System.Int32[,] details)
  RVA=0x09E2A738  token=0x6000065  System.Void Internal_SetDetailLayer(System.Int32 xBase, System.Int32 yBase, System.Int32 totalWidth, System.Int32 totalHeight, System.Int32 detailIndex, System.Int32[,] data)
  RVA=0x09E2A6A4  token=0x6000067  UnityEngine.TreeInstance[] Internal_GetTreeInstances()
  RVA=0x09E2B008  token=0x6000068  System.Void SetTreeInstances(UnityEngine.TreeInstance[] instances, System.Boolean snapToHeightmap)
  RVA=0x09E2A0B4  token=0x600006C  System.Single[,,] GetAlphamaps(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height)
  RVA=0x09E2A584  token=0x600006D  System.Single[,,] Internal_GetAlphamaps(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height)
  RVA=0x09E2A040  token=0x6000070  System.Single GetAlphamapResolutionInternal()
  RVA=0x09E2A8B0  token=0x6000077  System.Void SetAlphamaps(System.Int32 x, System.Int32 y, System.Single[,,] map)
  RVA=0x09E2A6D8  token=0x6000078  System.Void Internal_SetAlphamaps(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, System.Single[,,] map)
  RVA=0x09E2A074  token=0x6000079  UnityEngine.Texture2D GetAlphamapTexture(System.Int32 index)
  RVA=0x09E2B05C  token=0x600007F  System.Void .cctor()
  RVA=0x09E2B530  token=0x6000080  System.Void get_size_Injected(UnityEngine.Vector3& ret)
  RVA=0x09E2BA68  token=0x6000081  System.Void set_size_Injected(UnityEngine.Vector3& value)
  RVA=0x09E2A45C  token=0x6000082  System.Void GetInterpolatedNormal_Injected(System.Single x, System.Single y, UnityEngine.Vector3& ret)
END_CLASS

CLASS: UnityEngine.TerrainLayer
TYPE:  sealed class
TOKEN: 0x200000E
SIZE:  0x18
EXTENDS: UnityEngine.Object
FIELDS:
PROPERTIES:
  diffuseTexture  get=0x09E2BCA8  set=0x09E2C0B0
  normalMapTexture  get=0x09E2BE24  set=0x09E2C22C
  maskMapTexture  get=0x09E2BDBC  set=0x09E2C1A4
  tileSize  get=0x09E2BFDC  set=0x09E2C3F4
  tileOffset  get=0x09E2BF74  set=0x09E2C394
  specular  get=0x09E2BF04  set=0x09E2C33C
  metallic  get=0x09E2BDF0  set=0x09E2C1E8
  smoothness  get=0x09E2BE8C  set=0x09E2C2B4
  normalScale  get=0x09E2BE58  set=0x09E2C270
  diffuseRemapMin  get=0x09E2BC7C  set=0x09E2C09C
  diffuseRemapMax  get=0x09E2BC0C  set=0x09E2C044
  maskMapRemapMin  get=0x09E2BD90  set=0x09E2C190
  maskMapRemapMax  get=0x09E2BD20  set=0x09E2C138
METHODS:
  RVA=0x09E2BB7C  token=0x6000083  System.Void .ctor()
  RVA=0x09E2BB48  token=0x6000084  System.Void Internal_Create(UnityEngine.TerrainLayer layer)
  RVA=0x09E2BF98  token=0x600009F  System.Void get_tileSize_Injected(UnityEngine.Vector2& ret)
  RVA=0x09E2C3B0  token=0x60000A0  System.Void set_tileSize_Injected(UnityEngine.Vector2& value)
  RVA=0x09E2BF30  token=0x60000A1  System.Void get_tileOffset_Injected(UnityEngine.Vector2& ret)
  RVA=0x09E2C350  token=0x60000A2  System.Void set_tileOffset_Injected(UnityEngine.Vector2& value)
  RVA=0x09E2BEC0  token=0x60000A3  System.Void get_specular_Injected(UnityEngine.Color& ret)
  RVA=0x09E2C2F8  token=0x60000A4  System.Void set_specular_Injected(UnityEngine.Color& value)
  RVA=0x09E2BC38  token=0x60000A5  System.Void get_diffuseRemapMin_Injected(UnityEngine.Vector4& ret)
  RVA=0x09E2C058  token=0x60000A6  System.Void set_diffuseRemapMin_Injected(UnityEngine.Vector4& value)
  RVA=0x09E2BBC8  token=0x60000A7  System.Void get_diffuseRemapMax_Injected(UnityEngine.Vector4& ret)
  RVA=0x09E2C000  token=0x60000A8  System.Void set_diffuseRemapMax_Injected(UnityEngine.Vector4& value)
  RVA=0x09E2BD4C  token=0x60000A9  System.Void get_maskMapRemapMin_Injected(UnityEngine.Vector4& ret)
  RVA=0x09E2C14C  token=0x60000AA  System.Void set_maskMapRemapMin_Injected(UnityEngine.Vector4& value)
  RVA=0x09E2BCDC  token=0x60000AB  System.Void get_maskMapRemapMax_Injected(UnityEngine.Vector4& ret)
  RVA=0x09E2C0F4  token=0x60000AC  System.Void set_maskMapRemapMax_Injected(UnityEngine.Vector4& value)
END_CLASS

CLASS: UnityEngine.TerrainUtils.TerrainMapStatusCode
TYPE:  sealed struct
TOKEN: 0x200000F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TerrainUtils.TerrainMapStatusCodeOK  // const
  public    static  UnityEngine.TerrainUtils.TerrainMapStatusCodeOverlapping  // const
  public    static  UnityEngine.TerrainUtils.TerrainMapStatusCodeSizeMismatch  // const
  public    static  UnityEngine.TerrainUtils.TerrainMapStatusCodeEdgeAlignmentMismatch  // const
METHODS:
END_CLASS

CLASS: UnityEngine.TerrainUtils.TerrainTileCoord
TYPE:  sealed struct
TOKEN: 0x2000010
SIZE:  0x18
FIELDS:
  public    readonly System.Int32                    tileX  // 0x10
  public    readonly System.Int32                    tileZ  // 0x14
METHODS:
  RVA=0x03D4E4B0  token=0x60000AD  System.Void .ctor(System.Int32 tileX, System.Int32 tileZ)
END_CLASS

CLASS: UnityEngine.TerrainUtils.TerrainMap
TYPE:  class
TOKEN: 0x2000011
SIZE:  0x28
FIELDS:
  private           UnityEngine.Vector3             m_patchSize  // 0x10
  private           UnityEngine.TerrainUtils.TerrainMapStatusCodem_errorCode  // 0x1c
  private           System.Collections.Generic.Dictionary<UnityEngine.TerrainUtils.TerrainTileCoord,UnityEngine.Terrain>m_terrainTiles  // 0x20
PROPERTIES:
  terrainTiles  get=0x03D4EB40
METHODS:
  RVA=0x09E2C9D4  token=0x60000AE  UnityEngine.Terrain GetTerrain(System.Int32 tileX, System.Int32 tileZ)
  RVA=0x09E2C788  token=0x60000AF  UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Terrain originTerrain, System.Predicate<UnityEngine.Terrain> filter, System.Boolean fullValidation)
  RVA=0x09E2C56C  token=0x60000B0  UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Vector2 gridOrigin, UnityEngine.Vector2 gridSize, System.Predicate<UnityEngine.Terrain> filter, System.Boolean fullValidation)
  RVA=0x09E2D1CC  token=0x60000B2  System.Void .ctor()
  RVA=0x09E2C410  token=0x60000B3  System.Void AddTerrainInternal(System.Int32 x, System.Int32 z, UnityEngine.Terrain terrain)
  RVA=0x09E2CA50  token=0x60000B4  System.Boolean TryToAddTerrain(System.Int32 tileX, System.Int32 tileZ, UnityEngine.Terrain terrain)
  RVA=0x09E2CB38  token=0x60000B5  System.Void ValidateTerrain(System.Int32 tileX, System.Int32 tileZ)
  RVA=0x09E2D078  token=0x60000B6  UnityEngine.TerrainUtils.TerrainMapStatusCode Validate()
END_CLASS

CLASS: UnityEngine.TerrainUtils.TerrainUtility
TYPE:  static class
TOKEN: 0x2000013
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09E2D864  token=0x60000B9  System.Boolean ValidTerrainsExist()
  RVA=0x09E2D58C  token=0x60000BA  System.Void ClearConnectivity()
  RVA=0x09E2D60C  token=0x60000BB  System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TerrainUtils.TerrainMap> CollectTerrains(System.Boolean onlyAutoConnectedTerrains)
  RVA=0x09E2D248  token=0x60000BC  System.Void AutoConnect()
END_CLASS

