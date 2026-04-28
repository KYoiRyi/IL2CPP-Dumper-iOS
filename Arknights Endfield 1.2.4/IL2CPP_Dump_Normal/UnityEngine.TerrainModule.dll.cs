// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TerrainModule.dll
// Classes:  21
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000006  // size: 0x80
    public sealed class HeightmapChangedCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x09E29DB0  token: 0x6000018
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x0500800C  token: 0x6000019
        public virtual System.Void Invoke(UnityEngine.Terrain terrain, UnityEngine.RectInt heightRegion, System.Boolean synched) { }

    }

    // TypeToken: 0x2000007  // size: 0x80
    public sealed class TextureChangedCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x09E2DC64  token: 0x600001A
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x050197BC  token: 0x600001B
        public virtual System.Void Invoke(UnityEngine.Terrain terrain, System.String textureName, UnityEngine.RectInt texelRegion, System.Boolean synched) { }

    }

    // TypeToken: 0x200000D  // size: 0x14
    public sealed struct BoundaryValueType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.TerrainData.BoundaryValueType MaxHeightmapRes;  // const
        public static UnityEngine.TerrainData.BoundaryValueType MinDetailResPerPatch;  // const
        public static UnityEngine.TerrainData.BoundaryValueType MaxDetailResPerPatch;  // const
        public static UnityEngine.TerrainData.BoundaryValueType MaxDetailPatchCount;  // const
        public static UnityEngine.TerrainData.BoundaryValueType MaxDetailsPerRes;  // const
        public static UnityEngine.TerrainData.BoundaryValueType MinAlphamapRes;  // const
        public static UnityEngine.TerrainData.BoundaryValueType MaxAlphamapRes;  // const
        public static UnityEngine.TerrainData.BoundaryValueType MinBaseMapRes;  // const
        public static UnityEngine.TerrainData.BoundaryValueType MaxBaseMapRes;  // const

    }

    // TypeToken: 0x2000012  // size: 0x18
    public sealed class <>c__DisplayClass3_0
    {
        // Fields
        public System.Int32 groupID;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60000B7
        public System.Void .ctor() { }
        // RVA: 0x09E2DEE0  token: 0x60000B8
        private System.Boolean <CreateFromPlacement>b__0(UnityEngine.Terrain x) { }

    }

    // TypeToken: 0x2000014  // size: 0x18
    public sealed class <>c__DisplayClass2_0
    {
        // Fields
        public System.Boolean onlyAutoConnectedTerrains;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x60000BD
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000015  // size: 0x20
    public sealed class <>c__DisplayClass2_1
    {
        // Fields
        public UnityEngine.Terrain t;  // 0x10
        public UnityEngine.TerrainUtils.TerrainUtility.<>c__DisplayClass2_0 CS$<>8__locals1;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x60000BE
        public System.Void .ctor() { }
        // RVA: 0x09E2DE64  token: 0x60000BF
        private System.Boolean <CollectTerrains>b__0(UnityEngine.Terrain x) { }

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
    public sealed class IsReadOnlyAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000002
        public System.Void .ctor() { }

    }

}

namespace UnityEngine
{

    // TypeToken: 0x2000004  // size: 0x18
    public sealed class Terrain : UnityEngine.Behaviour
    {
        // Properties
        UnityEngine.TerrainData terrainData { get; /* RVA: 0x09E2DA00 */ set; /* RVA: 0x09E2DC20 */ }
        System.Single detailObjectDistance { set; /* RVA: 0x09E2DABC */ }
        System.Single detailObjectDensity { set; /* RVA: 0x09E2DA78 */ }
        System.Int32 lightmapIndex { set; /* RVA: 0x09E2DB44 */ }
        UnityEngine.Vector4 lightmapScaleOffset { set; /* RVA: 0x09E2DBC8 */ }
        UnityEngine.Material materialTemplate { get; /* RVA: 0x09E2D9CC */ set; /* RVA: 0x09E2DBDC */ }
        System.Boolean allowAutoConnect { get; /* RVA: 0x09E2D964 */ set; /* RVA: 0x09E2DA34 */ }
        System.Int32 groupingID { get; /* RVA: 0x09E2D998 */ }
        System.Boolean drawInstanced { set; /* RVA: 0x09E2DB00 */ }
        UnityEngine.Terrain[] activeTerrains { get; /* RVA: 0x09E2D938 */ }

        // Methods
        // RVA: 0x09E2D8D4  token: 0x600000F
        public System.Void SetNeighbors(UnityEngine.Terrain left, UnityEngine.Terrain top, UnityEngine.Terrain right, UnityEngine.Terrain bottom) { }
        // RVA: 0x09E2D898  token: 0x6000010
        public System.Void Flush() { }
        // RVA: 0x09E2D8CC  token: 0x6000012
        public static System.Void GetActiveTerrains(System.Collections.Generic.List<UnityEngine.Terrain> terrainList) { }
        // RVA: 0x031B4D60  token: 0x6000013
        private static System.Void Internal_FillActiveTerrainList(System.Object terrainList) { }
        // RVA: 0x0426FE60  token: 0x6000014
        public System.Void .ctor() { }
        // RVA: 0x09E2DB84  token: 0x6000015
        private System.Void set_lightmapScaleOffset_Injected(UnityEngine.Vector4& value) { }

    }

    // TypeToken: 0x2000005  // size: 0x10
    public static class TerrainCallbacks
    {
        // Fields
        private static UnityEngine.TerrainCallbacks.HeightmapChangedCallback heightmapChanged;  // static @ 0x0
        private static UnityEngine.TerrainCallbacks.TextureChangedCallback textureChanged;  // static @ 0x8

        // Methods
        // RVA: 0x09E29E84  token: 0x6000016
        private static System.Void InvokeHeightmapChangedCallback(UnityEngine.TerrainData terrainData, UnityEngine.RectInt heightRegion, System.Boolean synched) { }
        // RVA: 0x09E29F58  token: 0x6000017
        private static System.Void InvokeTextureChangedCallback(UnityEngine.TerrainData terrainData, System.String textureName, UnityEngine.RectInt texelRegion, System.Boolean synched) { }

    }

    // TypeToken: 0x2000008  // size: 0x20
    public sealed class TreePrototype
    {
        // Fields
        private UnityEngine.GameObject m_Prefab;  // 0x10
        private System.Single m_BendFactor;  // 0x18
        private System.Int32 m_NavMeshLod;  // 0x1c

        // Properties
        UnityEngine.GameObject prefab { get; /* RVA: 0x03D66B80 */ set; /* RVA: 0x0426FEE0 */ }
        System.Single bendFactor { get; /* RVA: 0x03D85C60 */ set; /* RVA: 0x03D4EC00 */ }
        System.Int32 navMeshLod { get; /* RVA: 0x03D66B90 */ }

        // Methods
        // RVA: 0x0350B670  token: 0x6000021
        public System.Void .ctor() { }
        // RVA: 0x09E2DD38  token: 0x6000022
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x03D86D00  token: 0x6000023
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09E2DD9C  token: 0x6000024
        private System.Boolean Equals(UnityEngine.TreePrototype other) { }

    }

    // TypeToken: 0x2000009  // size: 0x14
    public sealed struct DetailRenderMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.DetailRenderMode GrassBillboard;  // const
        public static UnityEngine.DetailRenderMode VertexLit;  // const
        public static UnityEngine.DetailRenderMode Grass;  // const

    }

    // TypeToken: 0x200000A  // size: 0x68
    public sealed class DetailPrototype
    {
        // Fields
        private static readonly UnityEngine.Color DefaultHealthColor;  // static @ 0x0
        private static readonly UnityEngine.Color DefaultDryColor;  // static @ 0x10
        private UnityEngine.GameObject m_Prototype;  // 0x10
        private UnityEngine.Texture2D m_PrototypeTexture;  // 0x18
        private UnityEngine.Color m_HealthyColor;  // 0x20
        private UnityEngine.Color m_DryColor;  // 0x30
        private System.Single m_MinWidth;  // 0x40
        private System.Single m_MaxWidth;  // 0x44
        private System.Single m_MinHeight;  // 0x48
        private System.Single m_MaxHeight;  // 0x4c
        private System.Int32 m_NoiseSeed;  // 0x50
        private System.Single m_NoiseSpread;  // 0x54
        private System.Single m_HoleEdgePadding;  // 0x58
        private System.Int32 m_RenderMode;  // 0x5c
        private System.Int32 m_UsePrototypeMesh;  // 0x60
        private System.Int32 m_UseInstancing;  // 0x64

        // Properties
        UnityEngine.GameObject prototype { get; /* RVA: 0x03D66B80 */ set; /* RVA: 0x0426FEE0 */ }
        UnityEngine.Texture2D prototypeTexture { get; /* RVA: 0x03D61D00 */ set; /* RVA: 0x022C3A90 */ }
        System.Single minWidth { get; /* RVA: 0x04270740 */ set; /* RVA: 0x03D4ECF0 */ }
        System.Single maxWidth { get; /* RVA: 0x04270750 */ set; /* RVA: 0x03D4ED00 */ }
        System.Single minHeight { get; /* RVA: 0x04270760 */ set; /* RVA: 0x03D5BE60 */ }
        System.Single maxHeight { get; /* RVA: 0x03D88030 */ set; /* RVA: 0x03D5E680 */ }
        System.Single noiseSpread { get; /* RVA: 0x03D88040 */ set; /* RVA: 0x03D4F680 */ }
        UnityEngine.Color healthyColor { get; /* RVA: 0x03D88020 */ set; /* RVA: 0x03D54E10 */ }
        UnityEngine.Color dryColor { get; /* RVA: 0x03D87900 */ set; /* RVA: 0x03D4FD40 */ }
        UnityEngine.DetailRenderMode renderMode { get; /* RVA: 0x03D88050 */ set; /* RVA: 0x03D4EF40 */ }
        System.Boolean usePrototypeMesh { set; /* RVA: 0x09E29D94 */ }

        // Methods
        // RVA: 0x09E29B9C  token: 0x600003A
        public System.Void .ctor() { }
        // RVA: 0x09E29C54  token: 0x600003B
        public System.Void .ctor(UnityEngine.DetailPrototype other) { }
        // RVA: 0x09E29934  token: 0x600003C
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x03D86D00  token: 0x600003D
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09E29998  token: 0x600003E
        private System.Boolean Equals(UnityEngine.DetailPrototype other) { }
        // RVA: 0x09E29B44  token: 0x600003F
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200000B  // size: 0x38
    public sealed struct TreeInstance
    {
        // Fields
        public UnityEngine.Vector3 position;  // 0x10
        public System.Single widthScale;  // 0x1c
        public System.Single heightScale;  // 0x20
        public System.Single rotation;  // 0x24
        public UnityEngine.Color32 color;  // 0x28
        public UnityEngine.Color32 lightmapColor;  // 0x2c
        public System.Int32 prototypeIndex;  // 0x30
        private System.Single temporaryDistance;  // 0x34

    }

    // TypeToken: 0x200000C  // size: 0x18
    public sealed class TerrainData : UnityEngine.Object
    {
        // Fields
        private static System.String k_ScriptingInterfaceName;  // const
        private static System.String k_ScriptingInterfacePrefix;  // const
        private static System.String k_HeightmapPrefix;  // const
        private static System.String k_DetailDatabasePrefix;  // const
        private static System.String k_TreeDatabasePrefix;  // const
        private static System.String k_SplatDatabasePrefix;  // const
        private static readonly System.Int32 k_MaximumResolution;  // static @ 0x0
        private static readonly System.Int32 k_MinimumDetailResolutionPerPatch;  // static @ 0x4
        private static readonly System.Int32 k_MaximumDetailResolutionPerPatch;  // static @ 0x8
        private static readonly System.Int32 k_MaximumDetailPatchCount;  // static @ 0xc
        private static readonly System.Int32 k_MaximumDetailsPerRes;  // static @ 0x10
        private static readonly System.Int32 k_MinimumAlphamapResolution;  // static @ 0x14
        private static readonly System.Int32 k_MaximumAlphamapResolution;  // static @ 0x18
        private static readonly System.Int32 k_MinimumBaseMapResolution;  // static @ 0x1c
        private static readonly System.Int32 k_MaximumBaseMapResolution;  // static @ 0x20

        // Properties
        UnityEngine.RenderTexture heightmapTexture { get; /* RVA: 0x09E2B484 */ }
        System.Int32 heightmapResolution { get; /* RVA: 0x09E2B478 */ set; /* RVA: 0x09E2B900 */ }
        System.Int32 internalHeightmapResolution { get; /* RVA: 0x09E2B4FC */ set; /* RVA: 0x09E2BA28 */ }
        UnityEngine.Texture holesTexture { get; /* RVA: 0x09E2B4CC */ }
        System.Boolean enableHolesTextureCompression { get; /* RVA: 0x09E2B444 */ set; /* RVA: 0x09E2B8BC */ }
        System.Int32 holesResolution { get; /* RVA: 0x09E2B4B8 */ }
        UnityEngine.Vector3 size { get; /* RVA: 0x09E2B574 */ set; /* RVA: 0x09E2BAAC */ }
        System.Int32 detailWidth { get; /* RVA: 0x09E2B410 */ }
        System.Int32 detailHeight { get; /* RVA: 0x09E2B340 */ }
        System.Int32 detailResolution { get; /* RVA: 0x09E2B3DC */ }
        System.Int32 detailResolutionPerPatch { get; /* RVA: 0x09E2B3A8 */ }
        UnityEngine.DetailPrototype[] detailPrototypes { get; /* RVA: 0x09E2B374 */ set; /* RVA: 0x09E2B878 */ }
        UnityEngine.TreeInstance[] treeInstances { get; /* RVA: 0x09E2B5D4 */ }
        UnityEngine.TreePrototype[] treePrototypes { get; /* RVA: 0x09E2B5E0 */ set; /* RVA: 0x09E2BB04 */ }
        System.Int32 alphamapLayers { get; /* RVA: 0x09E2B240 */ }
        System.Int32 alphamapResolution { get; /* RVA: 0x09E2B234 */ set; /* RVA: 0x09E2B688 */ }
        System.Int32 Internal_alphamapResolution { get; /* RVA: 0x09E2B1CC */ set; /* RVA: 0x09E2B648 */ }
        System.Int32 alphamapWidth { get; /* RVA: 0x09E2B234 */ }
        System.Int32 alphamapHeight { get; /* RVA: 0x09E2B234 */ }
        System.Int32 baseMapResolution { get; /* RVA: 0x09E2B334 */ }
        System.Int32 Internal_baseMapResolution { get; /* RVA: 0x09E2B200 */ }
        System.Int32 alphamapTextureCount { get; /* RVA: 0x09E2B274 */ }
        UnityEngine.Texture2D[] alphamapTextures { get; /* RVA: 0x09E2B2A8 */ }
        UnityEngine.TerrainLayer[] terrainLayers { get; /* RVA: 0x09E2B5A0 */ set; /* RVA: 0x09E2BAC0 */ }
        UnityEngine.Terrain[] users { get; /* RVA: 0x09E2B614 */ }

        // Methods
        // RVA: 0x09E2A13C  token: 0x6000040
        private static System.Int32 GetBoundaryValue(UnityEngine.TerrainData.BoundaryValueType type) { }
        // RVA: 0x09E2B174  token: 0x6000041
        public System.Void .ctor() { }
        // RVA: 0x09E2A550  token: 0x6000042
        private static System.Void Internal_Create(UnityEngine.TerrainData terrainData) { }
        // RVA: 0x09E2A848  token: 0x600004B
        private System.Boolean IsHolesTextureCompressed() { }
        // RVA: 0x09E2A2EC  token: 0x600004C
        private UnityEngine.RenderTexture GetHolesTexture() { }
        // RVA: 0x09E2A170  token: 0x600004D
        private UnityEngine.Texture2D GetCompressedHolesTexture() { }
        // RVA: 0x09E2A408  token: 0x6000051
        public System.Single GetInterpolatedHeight(System.Single x, System.Single y) { }
        // RVA: 0x09E2A204  token: 0x6000052
        public System.Single[,] GetHeights(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height) { }
        // RVA: 0x09E2A5E4  token: 0x6000053
        private System.Single[,] Internal_GetHeights(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height) { }
        // RVA: 0x09E2AD7C  token: 0x6000054
        public System.Void SetHeights(System.Int32 xBase, System.Int32 yBase, System.Single[,] heights) { }
        // RVA: 0x09E2A7E8  token: 0x6000055
        private System.Void Internal_SetHeights(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height, System.Single[,] heights) { }
        // RVA: 0x09E2A320  token: 0x6000056
        public System.Boolean[,] GetHoles(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height) { }
        // RVA: 0x09E2A644  token: 0x6000057
        private System.Boolean[,] Internal_GetHoles(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height) { }
        // RVA: 0x09E2A4C0  token: 0x6000058
        public UnityEngine.Vector3 GetInterpolatedNormal(System.Single x, System.Single y) { }
        // RVA: 0x09E2AA98  token: 0x600005B
        public System.Void SetDetailResolution(System.Int32 detailResolution, System.Int32 resolutionPerPatch) { }
        // RVA: 0x09E2A798  token: 0x600005C
        private System.Void Internal_SetDetailResolution(System.Int32 patchCount, System.Int32 resolutionPerPatch) { }
        // RVA: 0x09E2A87C  token: 0x600005F
        public System.Void RefreshPrototypes() { }
        // RVA: 0x09E2A4F0  token: 0x6000062
        public System.Int32[] GetSupportedLayers(System.Int32 xBase, System.Int32 yBase, System.Int32 totalWidth, System.Int32 totalHeight) { }
        // RVA: 0x09E2A1A4  token: 0x6000063
        public System.Int32[,] GetDetailLayer(System.Int32 xBase, System.Int32 yBase, System.Int32 width, System.Int32 height, System.Int32 layer) { }
        // RVA: 0x09E2AA08  token: 0x6000064
        public System.Void SetDetailLayer(System.Int32 xBase, System.Int32 yBase, System.Int32 layer, System.Int32[,] details) { }
        // RVA: 0x09E2A738  token: 0x6000065
        private System.Void Internal_SetDetailLayer(System.Int32 xBase, System.Int32 yBase, System.Int32 totalWidth, System.Int32 totalHeight, System.Int32 detailIndex, System.Int32[,] data) { }
        // RVA: 0x09E2A6A4  token: 0x6000067
        private UnityEngine.TreeInstance[] Internal_GetTreeInstances() { }
        // RVA: 0x09E2B008  token: 0x6000068
        public System.Void SetTreeInstances(UnityEngine.TreeInstance[] instances, System.Boolean snapToHeightmap) { }
        // RVA: 0x09E2A0B4  token: 0x600006C
        public System.Single[,,] GetAlphamaps(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height) { }
        // RVA: 0x09E2A584  token: 0x600006D
        private System.Single[,,] Internal_GetAlphamaps(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height) { }
        // RVA: 0x09E2A040  token: 0x6000070
        private System.Single GetAlphamapResolutionInternal() { }
        // RVA: 0x09E2A8B0  token: 0x6000077
        public System.Void SetAlphamaps(System.Int32 x, System.Int32 y, System.Single[,,] map) { }
        // RVA: 0x09E2A6D8  token: 0x6000078
        private System.Void Internal_SetAlphamaps(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, System.Single[,,] map) { }
        // RVA: 0x09E2A074  token: 0x6000079
        public UnityEngine.Texture2D GetAlphamapTexture(System.Int32 index) { }
        // RVA: 0x09E2B05C  token: 0x600007F
        private static System.Void .cctor() { }
        // RVA: 0x09E2B530  token: 0x6000080
        private System.Void get_size_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x09E2BA68  token: 0x6000081
        private System.Void set_size_Injected(UnityEngine.Vector3& value) { }
        // RVA: 0x09E2A45C  token: 0x6000082
        private System.Void GetInterpolatedNormal_Injected(System.Single x, System.Single y, UnityEngine.Vector3& ret) { }

    }

    // TypeToken: 0x200000E  // size: 0x18
    public sealed class TerrainLayer : UnityEngine.Object
    {
        // Properties
        UnityEngine.Texture2D diffuseTexture { get; /* RVA: 0x09E2BCA8 */ set; /* RVA: 0x09E2C0B0 */ }
        UnityEngine.Texture2D normalMapTexture { get; /* RVA: 0x09E2BE24 */ set; /* RVA: 0x09E2C22C */ }
        UnityEngine.Texture2D maskMapTexture { get; /* RVA: 0x09E2BDBC */ set; /* RVA: 0x09E2C1A4 */ }
        UnityEngine.Vector2 tileSize { get; /* RVA: 0x09E2BFDC */ set; /* RVA: 0x09E2C3F4 */ }
        UnityEngine.Vector2 tileOffset { get; /* RVA: 0x09E2BF74 */ set; /* RVA: 0x09E2C394 */ }
        UnityEngine.Color specular { get; /* RVA: 0x09E2BF04 */ set; /* RVA: 0x09E2C33C */ }
        System.Single metallic { get; /* RVA: 0x09E2BDF0 */ set; /* RVA: 0x09E2C1E8 */ }
        System.Single smoothness { get; /* RVA: 0x09E2BE8C */ set; /* RVA: 0x09E2C2B4 */ }
        System.Single normalScale { get; /* RVA: 0x09E2BE58 */ set; /* RVA: 0x09E2C270 */ }
        UnityEngine.Vector4 diffuseRemapMin { get; /* RVA: 0x09E2BC7C */ set; /* RVA: 0x09E2C09C */ }
        UnityEngine.Vector4 diffuseRemapMax { get; /* RVA: 0x09E2BC0C */ set; /* RVA: 0x09E2C044 */ }
        UnityEngine.Vector4 maskMapRemapMin { get; /* RVA: 0x09E2BD90 */ set; /* RVA: 0x09E2C190 */ }
        UnityEngine.Vector4 maskMapRemapMax { get; /* RVA: 0x09E2BD20 */ set; /* RVA: 0x09E2C138 */ }

        // Methods
        // RVA: 0x09E2BB7C  token: 0x6000083
        public System.Void .ctor() { }
        // RVA: 0x09E2BB48  token: 0x6000084
        private static System.Void Internal_Create(UnityEngine.TerrainLayer layer) { }
        // RVA: 0x09E2BF98  token: 0x600009F
        private System.Void get_tileSize_Injected(UnityEngine.Vector2& ret) { }
        // RVA: 0x09E2C3B0  token: 0x60000A0
        private System.Void set_tileSize_Injected(UnityEngine.Vector2& value) { }
        // RVA: 0x09E2BF30  token: 0x60000A1
        private System.Void get_tileOffset_Injected(UnityEngine.Vector2& ret) { }
        // RVA: 0x09E2C350  token: 0x60000A2
        private System.Void set_tileOffset_Injected(UnityEngine.Vector2& value) { }
        // RVA: 0x09E2BEC0  token: 0x60000A3
        private System.Void get_specular_Injected(UnityEngine.Color& ret) { }
        // RVA: 0x09E2C2F8  token: 0x60000A4
        private System.Void set_specular_Injected(UnityEngine.Color& value) { }
        // RVA: 0x09E2BC38  token: 0x60000A5
        private System.Void get_diffuseRemapMin_Injected(UnityEngine.Vector4& ret) { }
        // RVA: 0x09E2C058  token: 0x60000A6
        private System.Void set_diffuseRemapMin_Injected(UnityEngine.Vector4& value) { }
        // RVA: 0x09E2BBC8  token: 0x60000A7
        private System.Void get_diffuseRemapMax_Injected(UnityEngine.Vector4& ret) { }
        // RVA: 0x09E2C000  token: 0x60000A8
        private System.Void set_diffuseRemapMax_Injected(UnityEngine.Vector4& value) { }
        // RVA: 0x09E2BD4C  token: 0x60000A9
        private System.Void get_maskMapRemapMin_Injected(UnityEngine.Vector4& ret) { }
        // RVA: 0x09E2C14C  token: 0x60000AA
        private System.Void set_maskMapRemapMin_Injected(UnityEngine.Vector4& value) { }
        // RVA: 0x09E2BCDC  token: 0x60000AB
        private System.Void get_maskMapRemapMax_Injected(UnityEngine.Vector4& ret) { }
        // RVA: 0x09E2C0F4  token: 0x60000AC
        private System.Void set_maskMapRemapMax_Injected(UnityEngine.Vector4& value) { }

    }

}

namespace UnityEngine.TerrainUtils
{

    // TypeToken: 0x200000F  // size: 0x14
    public sealed struct TerrainMapStatusCode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.TerrainUtils.TerrainMapStatusCode OK;  // const
        public static UnityEngine.TerrainUtils.TerrainMapStatusCode Overlapping;  // const
        public static UnityEngine.TerrainUtils.TerrainMapStatusCode SizeMismatch;  // const
        public static UnityEngine.TerrainUtils.TerrainMapStatusCode EdgeAlignmentMismatch;  // const

    }

    // TypeToken: 0x2000010  // size: 0x18
    public sealed struct TerrainTileCoord
    {
        // Fields
        public readonly System.Int32 tileX;  // 0x10
        public readonly System.Int32 tileZ;  // 0x14

        // Methods
        // RVA: 0x03D4E4B0  token: 0x60000AD
        public System.Void .ctor(System.Int32 tileX, System.Int32 tileZ) { }

    }

    // TypeToken: 0x2000011  // size: 0x28
    public class TerrainMap
    {
        // Fields
        private UnityEngine.Vector3 m_patchSize;  // 0x10
        private UnityEngine.TerrainUtils.TerrainMapStatusCode m_errorCode;  // 0x1c
        private System.Collections.Generic.Dictionary<UnityEngine.TerrainUtils.TerrainTileCoord,UnityEngine.Terrain> m_terrainTiles;  // 0x20

        // Properties
        System.Collections.Generic.Dictionary<UnityEngine.TerrainUtils.TerrainTileCoord,UnityEngine.Terrain> terrainTiles { get; /* RVA: 0x03D4EB40 */ }

        // Methods
        // RVA: 0x09E2C9D4  token: 0x60000AE
        public UnityEngine.Terrain GetTerrain(System.Int32 tileX, System.Int32 tileZ) { }
        // RVA: 0x09E2C788  token: 0x60000AF
        public static UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Terrain originTerrain, System.Predicate<UnityEngine.Terrain> filter, System.Boolean fullValidation) { }
        // RVA: 0x09E2C56C  token: 0x60000B0
        public static UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Vector2 gridOrigin, UnityEngine.Vector2 gridSize, System.Predicate<UnityEngine.Terrain> filter, System.Boolean fullValidation) { }
        // RVA: 0x09E2D1CC  token: 0x60000B2
        public System.Void .ctor() { }
        // RVA: 0x09E2C410  token: 0x60000B3
        private System.Void AddTerrainInternal(System.Int32 x, System.Int32 z, UnityEngine.Terrain terrain) { }
        // RVA: 0x09E2CA50  token: 0x60000B4
        private System.Boolean TryToAddTerrain(System.Int32 tileX, System.Int32 tileZ, UnityEngine.Terrain terrain) { }
        // RVA: 0x09E2CB38  token: 0x60000B5
        private System.Void ValidateTerrain(System.Int32 tileX, System.Int32 tileZ) { }
        // RVA: 0x09E2D078  token: 0x60000B6
        private UnityEngine.TerrainUtils.TerrainMapStatusCode Validate() { }

    }

    // TypeToken: 0x2000013  // size: 0x10
    public static class TerrainUtility
    {
        // Methods
        // RVA: 0x09E2D864  token: 0x60000B9
        private static System.Boolean ValidTerrainsExist() { }
        // RVA: 0x09E2D58C  token: 0x60000BA
        private static System.Void ClearConnectivity() { }
        // RVA: 0x09E2D60C  token: 0x60000BB
        private static System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TerrainUtils.TerrainMap> CollectTerrains(System.Boolean onlyAutoConnectedTerrains) { }
        // RVA: 0x09E2D248  token: 0x60000BC
        public static System.Void AutoConnect() { }

    }

}

