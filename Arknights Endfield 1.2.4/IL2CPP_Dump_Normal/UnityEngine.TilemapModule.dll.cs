// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TilemapModule.dll
// Classes:  12
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000004  // size: 0x14
    public sealed struct ColliderType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Tilemaps.Tile.ColliderType None;  // const
        public static UnityEngine.Tilemaps.Tile.ColliderType Sprite;  // const
        public static UnityEngine.Tilemaps.Tile.ColliderType Grid;  // const

    }

namespace UnityEngine.Tilemaps
{

    // TypeToken: 0x2000002  // size: 0x30
    public class ITilemap
    {
        // Fields
        private static UnityEngine.Tilemaps.ITilemap s_Instance;  // static @ 0x0
        private UnityEngine.Tilemaps.Tilemap m_Tilemap;  // 0x10
        private System.Boolean m_AddToList;  // 0x18
        private System.Int32 m_RefreshCount;  // 0x1c
        private Unity.Collections.NativeArray<UnityEngine.Vector3Int> m_RefreshPos;  // 0x20

        // Methods
        // RVA: 0x0350B670  token: 0x6000001
        private System.Void .ctor() { }
        // RVA: 0x09E5B80C  token: 0x6000002
        public System.Void RefreshTile(UnityEngine.Vector3Int position) { }
        // RVA: 0x09E5B2E4  token: 0x6000003
        private static UnityEngine.Tilemaps.ITilemap CreateInstance() { }
        // RVA: 0x09E5B358  token: 0x6000004
        private static System.Void FindAllRefreshPositions(UnityEngine.Tilemaps.ITilemap tilemap, System.Int32 count, System.IntPtr oldTilesIntPtr, System.IntPtr newTilesIntPtr, System.IntPtr positionsIntPtr) { }
        // RVA: 0x09E5B5F4  token: 0x6000005
        private static System.Void GetAllTileData(UnityEngine.Tilemaps.ITilemap tilemap, System.Int32 count, System.IntPtr tilesIntPtr, System.IntPtr positionsIntPtr, System.IntPtr outTileDataIntPtr) { }

    }

    // TypeToken: 0x2000003  // size: 0x80
    public class Tile : UnityEngine.Tilemaps.TileBase
    {
        // Fields
        private UnityEngine.Sprite m_Sprite;  // 0x18
        private UnityEngine.Color m_Color;  // 0x20
        private UnityEngine.Matrix4x4 m_Transform;  // 0x30
        private UnityEngine.GameObject m_InstancedGameObject;  // 0x70
        private UnityEngine.Tilemaps.TileFlags m_Flags;  // 0x78
        private UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType;  // 0x7c

        // Properties
        UnityEngine.Sprite sprite { get; /* RVA: 0x03D61D00 */ set; /* RVA: 0x022C3A90 */ }
        UnityEngine.Color color { get; /* RVA: 0x03D88020 */ set; /* RVA: 0x03D54E10 */ }
        UnityEngine.Matrix4x4 transform { get; /* RVA: 0x03D883F0 */ set; /* RVA: 0x03D88420 */ }
        UnityEngine.GameObject gameObject { get; /* RVA: 0x03D87E20 */ set; /* RVA: 0x0519C3C8 */ }
        UnityEngine.Tilemaps.TileFlags flags { get; /* RVA: 0x03D87E70 */ set; /* RVA: 0x03D4ECC0 */ }
        UnityEngine.Tilemaps.Tile.ColliderType colliderType { get; /* RVA: 0x03D883E0 */ set; /* RVA: 0x03D4ED10 */ }

        // Methods
        // RVA: 0x09E5BCBC  token: 0x6000012
        public virtual System.Void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.Tilemaps.TileData& tileData) { }
        // RVA: 0x09E5BD60  token: 0x6000013
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000005  // size: 0x18
    public abstract class TileBase : UnityEngine.ScriptableObject
    {
        // Methods
        // RVA: 0x09E5BA34  token: 0x6000014
        public virtual System.Void RefreshTile(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap) { }
        // RVA: 0x0350B670  token: 0x6000015
        public virtual System.Void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.Tilemaps.TileData& tileData) { }
        // RVA: 0x09E5B970  token: 0x6000016
        private UnityEngine.Tilemaps.TileData GetTileDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap) { }
        // RVA: 0x03D4E3A0  token: 0x6000017
        public virtual System.Boolean GetTileAnimationData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.Tilemaps.TileAnimationData& tileAnimationData) { }
        // RVA: 0x03D86200  token: 0x6000018
        private UnityEngine.Tilemaps.TileAnimationData GetTileAnimationDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap) { }
        // RVA: 0x03D883B0  token: 0x6000019
        private System.Void GetTileAnimationDataRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.Tilemaps.TileAnimationData& tileAnimationData, System.Boolean& hasAnimation) { }
        // RVA: 0x03D4E3A0  token: 0x600001A
        public virtual System.Boolean StartUp(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go) { }
        // RVA: 0x03D883B0  token: 0x600001B
        private System.Void StartUpRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go, System.Boolean& startUpInvokedByUser) { }
        // RVA: 0x0286F540  token: 0x600001C
        protected System.Void .ctor() { }

    }

    // TypeToken: 0x2000006  // size: 0x18
    public sealed class Tilemap : UnityEngine.GridLayout
    {
        // Properties
        UnityEngine.Grid layoutGrid { get; /* RVA: 0x09E5C318 */ }
        UnityEngine.BoundsInt cellBounds { get; /* RVA: 0x09E5C284 */ }
        UnityEngine.Vector3Int origin { get; /* RVA: 0x09E5C40C */ }
        UnityEngine.Vector3Int size { get; /* RVA: 0x09E5C47C */ }
        UnityEngine.Vector3 tileAnchor { get; /* RVA: 0x09E5C4EC */ }
        UnityEngine.Matrix4x4 orientationMatrix { get; /* RVA: 0x09E5C390 */ }

        // Methods
        // RVA: 0x09E5BF38  token: 0x6000023
        private UnityEngine.Object GetTileAsset(UnityEngine.Vector3Int position) { }
        // RVA: -1  // generic def  token: 0x6000024
        public T GetTile(UnityEngine.Vector3Int position) { }
        // RVA: 0x09E5BFA0  token: 0x6000025
        private UnityEngine.Object[] GetTileAssetsBlock(UnityEngine.Vector3Int position, UnityEngine.Vector3Int blockDimensions) { }
        // RVA: 0x09E5BFB4  token: 0x6000026
        public UnityEngine.Tilemaps.TileBase[] GetTilesBlock(UnityEngine.BoundsInt bounds) { }
        // RVA: 0x09E5C120  token: 0x6000027
        public System.Boolean HasTile(UnityEngine.Vector3Int position) { }
        // RVA: 0x09E5C21C  token: 0x6000028
        public System.Void RefreshTile(UnityEngine.Vector3Int position) { }
        // RVA: 0x09E5C230  token: 0x6000029
        private System.Void RefreshTilesNative(System.Void* positions, System.Int32 count) { }
        // RVA: 0x09E5C0E0  token: 0x600002A
        public System.Int32 GetUsedTilesCount() { }
        // RVA: 0x09E5C114  token: 0x600002B
        public System.Int32 GetUsedTilesNonAlloc(UnityEngine.Tilemaps.TileBase[] usedTiles) { }
        // RVA: 0x09E5C194  token: 0x600002C
        private System.Int32 Internal_GetUsedTilesNonAlloc(UnityEngine.Object[] usedTiles) { }
        // RVA: 0x09E5C3C8  token: 0x600002D
        private System.Void get_origin_Injected(UnityEngine.Vector3Int& ret) { }
        // RVA: 0x09E5C438  token: 0x600002E
        private System.Void get_size_Injected(UnityEngine.Vector3Int& ret) { }
        // RVA: 0x09E5C4A8  token: 0x600002F
        private System.Void get_tileAnchor_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x09E5C34C  token: 0x6000030
        private System.Void get_orientationMatrix_Injected(UnityEngine.Matrix4x4& ret) { }
        // RVA: 0x09E5BEF4  token: 0x6000031
        private UnityEngine.Object GetTileAsset_Injected(UnityEngine.Vector3Int& position) { }
        // RVA: 0x09E5BF4C  token: 0x6000032
        private UnityEngine.Object[] GetTileAssetsBlock_Injected(UnityEngine.Vector3Int& position, UnityEngine.Vector3Int& blockDimensions) { }
        // RVA: 0x09E5C1D8  token: 0x6000033
        private System.Void RefreshTile_Injected(UnityEngine.Vector3Int& position) { }

    }

    // TypeToken: 0x2000007  // size: 0x14
    public sealed struct TileFlags
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Tilemaps.TileFlags None;  // const
        public static UnityEngine.Tilemaps.TileFlags LockColor;  // const
        public static UnityEngine.Tilemaps.TileFlags LockTransform;  // const
        public static UnityEngine.Tilemaps.TileFlags InstantiateGameObjectRuntimeOnly;  // const
        public static UnityEngine.Tilemaps.TileFlags KeepGameObjectRuntimeOnly;  // const
        public static UnityEngine.Tilemaps.TileFlags LockAll;  // const

    }

    // TypeToken: 0x2000008  // size: 0x18
    public sealed class TilemapRenderer : UnityEngine.Renderer
    {
        // Methods
        // RVA: 0x09E5BE04  token: 0x6000034
        private System.Void RegisterSpriteAtlasRegistered() { }
        // RVA: 0x09E5BE7C  token: 0x6000035
        private System.Void UnregisterSpriteAtlasRegistered() { }
        // RVA: 0x09E5BDC0  token: 0x6000036
        private System.Void OnSpriteAtlasRegistered(UnityEngine.U2D.SpriteAtlas atlas) { }

    }

    // TypeToken: 0x2000009  // size: 0x70
    public sealed struct TileData
    {
        // Fields
        private System.Int32 m_Sprite;  // 0x10
        private UnityEngine.Color m_Color;  // 0x14
        private UnityEngine.Matrix4x4 m_Transform;  // 0x24
        private System.Int32 m_GameObject;  // 0x64
        private UnityEngine.Tilemaps.TileFlags m_Flags;  // 0x68
        private UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType;  // 0x6c
        private static readonly UnityEngine.Tilemaps.TileData Default;  // static @ 0x0

        // Properties
        UnityEngine.Sprite sprite { set; /* RVA: 0x09E5BC44 */ }
        UnityEngine.Color color { set; /* RVA: 0x03D84E00 */ }
        UnityEngine.Matrix4x4 transform { set; /* RVA: 0x03D883C0 */ }
        UnityEngine.GameObject gameObject { set; /* RVA: 0x09E5BBC8 */ }
        UnityEngine.Tilemaps.TileFlags flags { set; /* RVA: 0x03D4EF50 */ }
        UnityEngine.Tilemaps.Tile.ColliderType colliderType { set; /* RVA: 0x03D4EF40 */ }

        // Methods
        // RVA: 0x09E5BA6C  token: 0x600003D
        private static UnityEngine.Tilemaps.TileData CreateDefault() { }
        // RVA: 0x09E5BB54  token: 0x600003E
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200000A  // size: 0x70
    public sealed struct TileDataNative
    {
        // Fields
        private System.Int32 m_Sprite;  // 0x10
        private UnityEngine.Color m_Color;  // 0x14
        private UnityEngine.Matrix4x4 m_Transform;  // 0x24
        private System.Int32 m_GameObject;  // 0x64
        private UnityEngine.Tilemaps.TileFlags m_Flags;  // 0x68
        private UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType;  // 0x6c

    }

    // TypeToken: 0x200000B  // size: 0x78
    public sealed struct TileChangeData
    {
        // Fields
        private UnityEngine.Vector3Int m_Position;  // 0x10
        private UnityEngine.Object m_TileAsset;  // 0x20
        private UnityEngine.Color m_Color;  // 0x28
        private UnityEngine.Matrix4x4 m_Transform;  // 0x38

    }

    // TypeToken: 0x200000C  // size: 0x20
    public sealed struct TileAnimationData
    {
        // Fields
        private UnityEngine.Sprite[] m_AnimatedSprites;  // 0x10
        private System.Single m_AnimationSpeed;  // 0x18
        private System.Single m_AnimationStartTime;  // 0x1c

    }

}

