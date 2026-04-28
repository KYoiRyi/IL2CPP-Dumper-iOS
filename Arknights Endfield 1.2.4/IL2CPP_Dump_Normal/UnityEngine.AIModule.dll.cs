// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AIModule.dll
// Classes:  29
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000011  // size: 0x80
    public sealed class OnNavMeshPreUpdate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x042BE04C  token: 0x60000A9
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x042BE03C  token: 0x60000AA
        public virtual System.Void Invoke() { }

    }

    // TypeToken: 0x2000012  // size: 0x80
    public sealed class OnUnloadFinishDelegate : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x034E42D0  token: 0x60000AB
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x02149960  token: 0x60000AC
        public virtual System.Void Invoke(System.UInt64 surfTileID) { }

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

namespace UnityEngine.AI
{

    // TypeToken: 0x2000004  // size: 0x14
    public sealed struct NavMeshPathStatus
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AI.NavMeshPathStatus PathComplete;  // const
        public static UnityEngine.AI.NavMeshPathStatus PathPartial;  // const
        public static UnityEngine.AI.NavMeshPathStatus PathInvalid;  // const
        public static UnityEngine.AI.NavMeshPathStatus PathProcessing;  // const

    }

    // TypeToken: 0x2000005  // size: 0x30
    public sealed class NavMeshPath
    {
        // Fields
        private System.IntPtr m_Ptr;  // 0x10
        private UnityEngine.Vector3[] m_Corners;  // 0x18
        private System.Int32[] m_Areas;  // 0x20
        private UnityEngine.Vector3[] m_DividingPos;  // 0x28

        // Properties
        UnityEngine.Vector3[] corners { get; /* RVA: 0x0427050C */ }
        UnityEngine.AI.NavMeshPathStatus status { get; /* RVA: 0x02549C30 */ }
        System.Boolean needRepath { get; /* RVA: 0x02792AE0 */ set; /* RVA: 0x0353BA50 */ }
        System.Boolean calcAutoRepath { set; /* RVA: 0x0353BA00 */ }

        // Methods
        // RVA: 0x02A810E0  token: 0x6000003
        public System.Void .ctor() { }
        // RVA: 0x03B29410  token: 0x6000004
        protected virtual System.Void Finalize() { }
        // RVA: 0x02A81100  token: 0x6000005
        private static System.IntPtr InitializeNavMeshPath() { }
        // RVA: 0x03B294A0  token: 0x6000006
        private static System.Void DestroyNavMeshPath(System.IntPtr ptr) { }
        // RVA: 0x039CB050  token: 0x6000007
        public System.Int32 GetCornersNonAlloc(UnityEngine.Vector3[] corners, System.Int32[] areas, UnityEngine.Vector3[] dividingPos) { }
        // RVA: 0x03B41FD0  token: 0x6000008
        public System.Int32 GetPolyCount() { }
        // RVA: 0x03C9C4B0  token: 0x6000009
        private UnityEngine.Vector3[] CalculateCornersInternal() { }
        // RVA: 0x0278F2A0  token: 0x600000A
        private System.Void ClearCornersInternal() { }
        // RVA: 0x0278F270  token: 0x600000B
        public System.Void ClearCorners() { }
        // RVA: 0x03C9C480  token: 0x600000C
        private System.Void CalculateCorners() { }

    }

    // TypeToken: 0x2000006  // size: 0x10
    public static class NavMeshBuilder
    {
        // Methods
        // RVA: 0x09D7E590  token: 0x6000012
        public static System.Void CollectSources(UnityEngine.Bounds includedWorldBounds, System.Int32 includedLayerMask, UnityEngine.AI.NavMeshCollectGeometry geometry, System.Int32 defaultArea, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results) { }
        // RVA: 0x09D7E3E0  token: 0x6000013
        public static System.Void CollectSources(UnityEngine.Transform root, System.Int32 includedLayerMask, UnityEngine.AI.NavMeshCollectGeometry geometry, System.Int32 defaultArea, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results) { }
        // RVA: 0x09D7E3AC  token: 0x6000014
        private static UnityEngine.AI.NavMeshBuildSource[] CollectSourcesInternal(System.Int32 includedLayerMask, UnityEngine.Bounds includedWorldBounds, UnityEngine.Transform root, System.Boolean useBounds, UnityEngine.AI.NavMeshCollectGeometry geometry, System.Int32 defaultArea, UnityEngine.AI.NavMeshBuildMarkup[] markups) { }
        // RVA: 0x03B74A70  token: 0x6000015
        public static System.Void CollectSourcesV2(UnityEngine.Bounds includedWorldBounds, System.Int32 includedLayerMask, System.Int32 defaultArea, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results) { }
        // RVA: 0x04276F7C  token: 0x6000016
        private static UnityEngine.AI.NavMeshBuildSource[] CollectSourcesV2Internal(System.Int32 includedLayerMask, UnityEngine.Bounds includedWorldBounds, System.Int32 defaultArea, UnityEngine.AI.NavMeshBuildMarkup[] markups) { }
        // RVA: 0x09D7E1BC  token: 0x6000017
        public static UnityEngine.AI.NavMeshData BuildNavMeshData(UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources, UnityEngine.Bounds localBounds, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Boolean useSubJob) { }
        // RVA: 0x09D7E820  token: 0x6000018
        public static System.Boolean UpdateNavMeshData(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources, UnityEngine.Bounds localBounds, System.Boolean useSubJob) { }
        // RVA: 0x09D7E800  token: 0x6000019
        private static System.Boolean UpdateNavMeshDataListInternal(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Object sources, UnityEngine.Bounds localBounds, System.Boolean useSubJob) { }
        // RVA: 0x03CA7E70  token: 0x600001A
        public static UnityEngine.AsyncOperation UpdateNavMeshDataAsync(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources, UnityEngine.Bounds localBounds, System.Boolean useSubJob) { }
        // RVA: 0x04277004  token: 0x600001B
        private static UnityEngine.AsyncOperation UpdateNavMeshDataAsyncListInternal(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Object sources, UnityEngine.Bounds localBounds, System.Boolean useSubJob) { }
        // RVA: 0x09D7E34C  token: 0x600001C
        private static UnityEngine.AI.NavMeshBuildSource[] CollectSourcesInternal_Injected(System.Int32 includedLayerMask, UnityEngine.Bounds& includedWorldBounds, UnityEngine.Transform root, System.Boolean useBounds, UnityEngine.AI.NavMeshCollectGeometry geometry, System.Int32 defaultArea, UnityEngine.AI.NavMeshBuildMarkup[] markups) { }
        // RVA: 0x03D460F0  token: 0x600001D
        private static UnityEngine.AI.NavMeshBuildSource[] CollectSourcesV2Internal_Injected(System.Int32 includedLayerMask, UnityEngine.Bounds& includedWorldBounds, System.Int32 defaultArea, UnityEngine.AI.NavMeshBuildMarkup[] markups) { }
        // RVA: 0x09D7E79C  token: 0x600001E
        private static System.Boolean UpdateNavMeshDataListInternal_Injected(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings& buildSettings, System.Object sources, UnityEngine.Bounds& localBounds, System.Boolean useSubJob) { }
        // RVA: 0x03CA7FB0  token: 0x600001F
        private static UnityEngine.AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings& buildSettings, System.Object sources, UnityEngine.Bounds& localBounds, System.Boolean useSubJob) { }

    }

    // TypeToken: 0x2000007  // size: 0x18
    public sealed class HGNavMeshAgent : UnityEngine.Behaviour
    {
    }

    // TypeToken: 0x2000008  // size: 0x18
    public sealed class NavMeshAgent : UnityEngine.Behaviour
    {
    }

    // TypeToken: 0x2000009  // size: 0x14
    public sealed struct NavMeshObstacleShape
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AI.NavMeshObstacleShape Capsule;  // const
        public static UnityEngine.AI.NavMeshObstacleShape Box;  // const
        public static UnityEngine.AI.NavMeshObstacleShape Polygon;  // const

    }

    // TypeToken: 0x200000A  // size: 0x18
    public sealed class NavMeshObstacle : UnityEngine.Behaviour
    {
        // Properties
        System.Single height { get; /* RVA: 0x09D7EBF4 */ set; /* RVA: 0x09D7EC5C */ }
        System.Single radius { get; /* RVA: 0x09D7EC28 */ set; /* RVA: 0x09D7ECA0 */ }
        System.Boolean carving { set; /* RVA: 0x033913A0 */ }
        System.Boolean carveOnlyStationary { set; /* RVA: 0x033912B0 */ }
        UnityEngine.AI.NavMeshObstacleShape shape { set; /* RVA: 0x03391260 */ }
        UnityEngine.Vector3 center { get; /* RVA: 0x09D7EBC8 */ set; /* RVA: 0x042761A4 */ }
        UnityEngine.Vector3 size { get; /* RVA: 0x036A9CD0 */ set; /* RVA: 0x042761B8 */ }
        System.Int32 ignoredSurfaceID { set; /* RVA: 0x03391300 */ }
        System.Int32 carveArea { set; /* RVA: 0x03391350 */ }

        // Methods
        // RVA: 0x09D7EB84  token: 0x600002D
        private System.Void get_center_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x03391440  token: 0x600002E
        private System.Void set_center_Injected(UnityEngine.Vector3& value) { }
        // RVA: 0x036A9C80  token: 0x600002F
        private System.Void get_size_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x033913F0  token: 0x6000030
        private System.Void set_size_Injected(UnityEngine.Vector3& value) { }

    }

    // TypeToken: 0x200000B  // size: 0x34
    public sealed struct NavMeshHit
    {
        // Fields
        private UnityEngine.Vector3 m_Position;  // 0x10
        private UnityEngine.Vector3 m_Normal;  // 0x1c
        private System.Single m_Distance;  // 0x28
        private System.Int32 m_Mask;  // 0x2c
        private System.Int32 m_Hit;  // 0x30

        // Properties
        UnityEngine.Vector3 position { get; /* RVA: 0x03D85920 */ }
        UnityEngine.Vector3 normal { get; /* RVA: 0x03D85900 */ }
        System.Boolean hit { get; /* RVA: 0x09D7EAAC */ }

    }

    // TypeToken: 0x200000C  // size: 0x18
    public sealed class NavMeshData : UnityEngine.Object
    {
        // Properties
        UnityEngine.Bounds sourceBounds { get; /* RVA: 0x02CBB140 */ }
        UnityEngine.Vector3 position { get; /* RVA: 0x03D2D9D0 */ set; /* RVA: 0x09D7EA84 */ }
        UnityEngine.Quaternion rotation { get; /* RVA: 0x03D36230 */ set; /* RVA: 0x09D7EA98 */ }

        // Methods
        // RVA: 0x03D28AF0  token: 0x6000034
        public System.Void .ctor(System.Int32 agentTypeID) { }
        // RVA: 0x03D28B50  token: 0x6000035
        private static System.Void Internal_Create(UnityEngine.AI.NavMeshData mono, System.Int32 agentTypeID) { }
        // RVA: 0x0359F320  token: 0x600003B
        public System.Void AppendExtOffMeshLink(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single width, System.Boolean bidirectional, System.Int32 area, System.Single costModifier) { }
        // RVA: 0x042766E8  token: 0x600003C
        private System.Void Internal_AppendExtOffMeshLink(UnityEngine.Vector3 startLeft, UnityEngine.Vector3 startRight, UnityEngine.Vector3 endRight, UnityEngine.Vector3 endLeft, System.Boolean bidirectional, System.Int32 area, System.Single costModifier) { }
        // RVA: 0x02CBB170  token: 0x600003D
        private System.Void get_sourceBounds_Injected(UnityEngine.Bounds& ret) { }
        // RVA: 0x03D2DA00  token: 0x600003E
        private System.Void get_position_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x03D49200  token: 0x600003F
        private System.Void set_position_Injected(UnityEngine.Vector3& value) { }
        // RVA: 0x03D36260  token: 0x6000040
        private System.Void get_rotation_Injected(UnityEngine.Quaternion& ret) { }
        // RVA: 0x03D491B0  token: 0x6000041
        private System.Void set_rotation_Injected(UnityEngine.Quaternion& value) { }
        // RVA: 0x0359F600  token: 0x6000042
        private System.Void Internal_AppendExtOffMeshLink_Injected(UnityEngine.Vector3& startLeft, UnityEngine.Vector3& startRight, UnityEngine.Vector3& endRight, UnityEngine.Vector3& endLeft, System.Boolean bidirectional, System.Int32 area, System.Single costModifier) { }

    }

    // TypeToken: 0x200000D  // size: 0x14
    public sealed struct NavMeshDataInstance
    {
        // Fields
        private System.Int32 <id>k__BackingField;  // 0x10

        // Properties
        System.Boolean valid { get; /* RVA: 0x025532C0 */ }
        System.Int32 id { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x03D4E970 */ }
        System.Int32 handleId { get; /* RVA: 0x03D85860 */ set; /* RVA: 0x03D4E970 */ }
        UnityEngine.Object owner { set; /* RVA: 0x09D7E9D4 */ }

        // Methods
        // RVA: 0x09D7E9C8  token: 0x6000048
        public System.Void Remove() { }

    }

    // TypeToken: 0x200000E  // size: 0x54
    public sealed struct NavMeshLinkData
    {
        // Fields
        private System.Boolean m_IsExt;  // 0x10
        private UnityEngine.Vector3 m_StartLeft;  // 0x14
        private UnityEngine.Vector3 m_StartRight;  // 0x20
        private UnityEngine.Vector3 m_EndRight;  // 0x2c
        private UnityEngine.Vector3 m_EndLeft;  // 0x38
        private System.Single m_CostModifier;  // 0x44
        private System.Int32 m_Bidirectional;  // 0x48
        private System.Int32 m_Area;  // 0x4c
        private System.Int32 m_AgentTypeID;  // 0x50

        // Properties
        System.Boolean isExt { get; /* RVA: 0x03D859A0 */ set; /* RVA: 0x03D4F9D0 */ }
        UnityEngine.Vector3 startLeft { get; /* RVA: 0x03D859B0 */ set; /* RVA: 0x03D77290 */ }
        UnityEngine.Vector3 startRight { get; /* RVA: 0x03D859D0 */ set; /* RVA: 0x03D55570 */ }
        UnityEngine.Vector3 endRight { get; /* RVA: 0x03D85980 */ set; /* RVA: 0x03D5CBC0 */ }
        UnityEngine.Vector3 endLeft { get; /* RVA: 0x03D85960 */ set; /* RVA: 0x03D50F50 */ }
        System.Single costModifier { get; /* RVA: 0x042743D0 */ set; /* RVA: 0x03D56CB0 */ }
        System.Boolean bidirectional { get; /* RVA: 0x05F42DD8 */ set; /* RVA: 0x0300B960 */ }
        System.Int32 area { get; /* RVA: 0x03D85950 */ set; /* RVA: 0x03D4EDC0 */ }
        System.Int32 agentTypeID { get; /* RVA: 0x03D85940 */ set; /* RVA: 0x03D4EDB0 */ }

    }

    // TypeToken: 0x200000F  // size: 0x14
    public sealed struct NavMeshLinkInstance
    {
        // Fields
        private System.Int32 <id>k__BackingField;  // 0x10

        // Properties
        System.Boolean valid { get; /* RVA: 0x09D7EAC0 */ }
        System.Int32 id { get; /* RVA: 0x03D4E980 */ set; /* RVA: 0x03D4E970 */ }
        UnityEngine.Object owner { set; /* RVA: 0x09D7EAD4 */ }

        // Methods
        // RVA: 0x09D7EAB4  token: 0x600005F
        public System.Void Remove() { }

    }

    // TypeToken: 0x2000010  // size: 0x10
    public static class NavMesh
    {
        // Fields
        public static UnityEngine.AI.NavMesh.OnNavMeshPreUpdate onPreUpdate;  // static @ 0x0
        public static UnityEngine.AI.NavMesh.OnUnloadFinishDelegate onUnloadFinish;  // static @ 0x8

        // Methods
        // RVA: 0x031AC030  token: 0x6000061
        private static System.Void Internal_CallOnNavMeshPreUpdate() { }
        // RVA: 0x042729A4  token: 0x6000062
        public static System.Boolean Raycast(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask) { }
        // RVA: 0x02549AD0  token: 0x6000063
        public static System.Boolean CalculatePath(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius) { }
        // RVA: 0x042704D4  token: 0x6000064
        private static System.Boolean CalculatePathInternal(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius) { }
        // RVA: 0x09D7EEDC  token: 0x6000065
        public static System.Boolean FindClosestEdge(UnityEngine.Vector3 sourcePosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask) { }
        // RVA: 0x042729BC  token: 0x6000066
        public static System.Boolean SamplePosition(UnityEngine.Vector3 sourcePosition, UnityEngine.AI.NavMeshHit& hit, System.Single maxDistance, System.Int32 areaMask) { }
        // RVA: 0x0384AD30  token: 0x6000067
        public static System.Int32 GetAreaFromName(System.String areaName) { }
        // RVA: 0x0307EDA0  token: 0x6000068
        public static UnityEngine.AI.NavMeshDataInstance AddNavMeshData(UnityEngine.AI.NavMeshData navMeshData) { }
        // RVA: 0x02CBB080  token: 0x6000069
        public static UnityEngine.AI.NavMeshDataInstance AddNavMeshData(UnityEngine.AI.NavMeshData navMeshData, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09D7F21C  token: 0x600006A
        public static System.Void UpdateSurfaceTransform(UnityEngine.AI.NavMeshDataInstance handle, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09D7F1A0  token: 0x600006B
        public static System.Void RemoveNavMeshData(UnityEngine.AI.NavMeshDataInstance handle) { }
        // RVA: 0x025532E0  token: 0x600006C
        private static System.Boolean IsValidNavMeshDataHandle(System.Int32 handle) { }
        // RVA: 0x09D7F074  token: 0x600006D
        private static System.Boolean IsValidLinkHandle(System.Int32 handle) { }
        // RVA: 0x09D7EF38  token: 0x600006E
        private static System.Boolean InternalSetOwner(System.Int32 dataID, System.Int32 ownerID) { }
        // RVA: 0x09D7EEF8  token: 0x600006F
        private static System.Boolean InternalSetLinkOwner(System.Int32 linkID, System.Int32 ownerID) { }
        // RVA: 0x0307EE00  token: 0x6000070
        private static System.Int32 AddNavMeshDataInternal(UnityEngine.AI.NavMeshData navMeshData) { }
        // RVA: 0x042730B8  token: 0x6000071
        private static System.Int32 AddNavMeshDataTransformedInternal(UnityEngine.AI.NavMeshData navMeshData, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09D7F16C  token: 0x6000072
        private static System.Void RemoveNavMeshDataInternal(System.Int32 handle) { }
        // RVA: 0x0300B8D0  token: 0x6000073
        public static UnityEngine.AI.NavMeshLinkInstance AddLink(UnityEngine.AI.NavMeshLinkData link, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09D7F164  token: 0x6000074
        public static System.Void RemoveLink(UnityEngine.AI.NavMeshLinkInstance handle) { }
        // RVA: 0x042749B0  token: 0x6000075
        private static System.Int32 AddLinkInternal(UnityEngine.AI.NavMeshLinkData link, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09D7F130  token: 0x6000076
        private static System.Void RemoveLinkInternal(System.Int32 handle) { }
        // RVA: 0x0307F1C0  token: 0x6000077
        public static UnityEngine.AI.NavMeshBuildSettings GetSettingsByID(System.Int32 agentTypeID) { }
        // RVA: 0x037BD250  token: 0x6000078
        public static UnityEngine.AI.NavMeshBuildSettings GetSettingsByIndex(System.Int32 index) { }
        // RVA: 0x09D7F208  token: 0x6000079
        private static System.Void UpdateSurfaceTransformInternal(System.Int32 surfaceID, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        // RVA: 0x034E3FF0  token: 0x600007A
        public static System.Boolean DetachFromSurface(System.Int32 chunkSurfaceId, System.Int32 builderSurfaceId, System.Int32 indexX, System.Int32 indexZ) { }
        // RVA: 0x0307F250  token: 0x600007B
        public static System.Boolean SetBuilderSurfaceParams(System.Int32 surfID, System.Single chunkSize, System.Single tileSize, System.Single centerX, System.Single centerZ, System.Single sizeX, System.Single sizeZ) { }
        // RVA: 0x034E4000  token: 0x600007C
        private static System.Boolean Internal_DetachFromSurface(System.Int32 chunkSurfaceId, System.Int32 builderSurfaceId, System.Int32 indexX, System.Int32 indexZ) { }
        // RVA: 0x0307F420  token: 0x600007D
        private static System.Boolean Internal_SetBuilderSurfaceParams(System.Int32 surfID, System.Single chunkSize, System.Single tileSize, System.Single centerX, System.Single centerZ, System.Single sizeX, System.Single sizeZ) { }
        // RVA: 0x09D7F0A8  token: 0x600007E
        public static System.Int32 LoadDynamicBakeTile(UnityEngine.AI.NavMeshData navMeshData) { }
        // RVA: 0x09D7F1A8  token: 0x600007F
        public static System.Void UnloadDynamicBakeTile(System.Int32 dynamicTileID) { }
        // RVA: 0x09D7EFD8  token: 0x6000080
        private static System.Int32 Internal_LoadDynamicBakeTile(UnityEngine.AI.NavMeshData navMeshData) { }
        // RVA: 0x09D7F00C  token: 0x6000081
        private static System.Void Internal_UnloadDynamicBakeTile(System.Int32 dynamicTileID) { }
        // RVA: 0x09D7F120  token: 0x6000082
        public static System.Int32 ModifyVolumeArea(System.Collections.Generic.List<UnityEngine.Vector3> center, System.Collections.Generic.List<UnityEngine.Vector3> ext, System.Collections.Generic.List<UnityEngine.Quaternion> rotation, System.Int32 area) { }
        // RVA: 0x09D7F0BC  token: 0x6000083
        private static System.Int32 ModifyBoxAreaInternal(System.Collections.Generic.List<UnityEngine.Vector3> center, System.Collections.Generic.List<UnityEngine.Vector3> ext, System.Collections.Generic.List<UnityEngine.Quaternion> rotation, System.Int32 area) { }
        // RVA: 0x03B46B00  token: 0x6000084
        public static System.Int32 ModifyVolumeArea(System.Collections.Generic.List<UnityEngine.Vector3> verts, System.Single hMin, System.Single hMax, System.Int32 area) { }
        // RVA: 0x03B46B10  token: 0x6000085
        private static System.Int32 ModifyPolygonAreaInternal(System.Collections.Generic.List<UnityEngine.Vector3> verts, System.Single hMin, System.Single hMax, System.Int32 area) { }
        // RVA: 0x09D7F0B4  token: 0x6000086
        public static System.Void LoadExtOffMeshLinks(System.Int32 surfaceID) { }
        // RVA: 0x03D4BEE0  token: 0x6000087
        private static System.Void Internal_LoadExtOffMeshLinks(System.Int32 surfaceID) { }
        // RVA: 0x02553320  token: 0x6000088
        public static UnityEngine.AsyncOperation AddNavMeshDataAsync(System.Int32& surfaceID, UnityEngine.AI.NavMeshData navMeshData, System.UInt64 surfTileID) { }
        // RVA: 0x025533B0  token: 0x6000089
        private static UnityEngine.AsyncOperation AddNavMeshDataAsyncInternal(System.Int32& surfaceID, UnityEngine.AI.NavMeshData navMeshData, System.UInt64 surfTileID) { }
        // RVA: 0x09D7EE80  token: 0x600008A
        public static System.Void CancelAsyncAdd(System.UInt64 surfTileID) { }
        // RVA: 0x09D7EF78  token: 0x600008B
        private static System.Void Internal_CancelAsyncAdd(System.UInt64 surfaceID) { }
        // RVA: 0x04276458  token: 0x600008C
        public static System.Void UnloadDataAsync(System.Int32 surfaceID, System.UInt64 surfTileID) { }
        // RVA: 0x0399FA60  token: 0x600008D
        private static System.Void Internal_UnloadDataAsync(System.Int32 surfaceID, System.UInt64 surfTileID) { }
        // RVA: 0x034E4070  token: 0x600008E
        private static System.Void Internal_InvokeOnUnloadFinish(System.UInt64 surfTileID) { }
        // RVA: 0x04270534  token: 0x600008F
        public static System.Boolean IsSurfaceUnloading(System.UInt64 surfTileID) { }
        // RVA: 0x03828330  token: 0x6000090
        private static System.Boolean Internal_IsSurfaceUnloading(System.UInt64 surfTileID) { }
        // RVA: 0x09D7EEF0  token: 0x6000091
        public static System.Void ForceClearUnloadDataRequest() { }
        // RVA: 0x09D7EFAC  token: 0x6000092
        private static System.Void Internal_ForceClearUnloadDataRequest() { }
        // RVA: 0x0278F190  token: 0x6000093
        public static System.Void CalculatePathAsync(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius) { }
        // RVA: 0x0427183C  token: 0x6000094
        private static System.Void CalculatePathAsyncInternal(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius) { }
        // RVA: 0x04274DB4  token: 0x6000095
        public static System.Void SetFindPathMaxIterPerFrame(System.Int32 maxIterPerFrame) { }
        // RVA: 0x03D3D720  token: 0x6000096
        private static System.Void Internal_SetFindPathMaxIterPerFrame(System.Int32 maxIterPerFrame) { }
        // RVA: 0x04276598  token: 0x6000097
        public static System.Void CancelAsyncCalculatePath(UnityEngine.AI.NavMeshPath path) { }
        // RVA: 0x03B31E70  token: 0x6000098
        private static System.Void Internal_CancelAsyncCalculatePath(UnityEngine.AI.NavMeshPath path) { }
        // RVA: 0x04276590  token: 0x6000099
        public static System.Void RegisterAutoRepath(UnityEngine.AI.NavMeshPath path) { }
        // RVA: 0x03CDDD00  token: 0x600009A
        private static System.Void Internal_RegisterAutoRepath(UnityEngine.AI.NavMeshPath path) { }
        // RVA: 0x09D7F1B0  token: 0x600009B
        public static System.Void UnregisterAutoRepath(UnityEngine.AI.NavMeshPath path) { }
        // RVA: 0x09D7F040  token: 0x600009C
        private static System.Void Internal_UnregisterAutoRepath(UnityEngine.AI.NavMeshPath path) { }
        // RVA: 0x04271874  token: 0x600009D
        public static System.Boolean RaycastNearestPoint(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask) { }
        // RVA: 0x0311BA10  token: 0x600009E
        private static System.Boolean Raycast_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.Vector3& targetPosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask) { }
        // RVA: 0x02549BB0  token: 0x600009F
        private static System.Boolean CalculatePathInternal_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.Vector3& targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius) { }
        // RVA: 0x09D7EE88  token: 0x60000A0
        private static System.Boolean FindClosestEdge_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask) { }
        // RVA: 0x02E53550  token: 0x60000A1
        private static System.Boolean SamplePosition_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.AI.NavMeshHit& hit, System.Single maxDistance, System.Int32 areaMask) { }
        // RVA: 0x02CBADE0  token: 0x60000A2
        private static System.Int32 AddNavMeshDataTransformedInternal_Injected(UnityEngine.AI.NavMeshData navMeshData, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        // RVA: 0x0300B980  token: 0x60000A3
        private static System.Int32 AddLinkInternal_Injected(UnityEngine.AI.NavMeshLinkData& link, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        // RVA: 0x0307F200  token: 0x60000A4
        private static System.Void GetSettingsByID_Injected(System.Int32 agentTypeID, UnityEngine.AI.NavMeshBuildSettings& ret) { }
        // RVA: 0x037BD290  token: 0x60000A5
        private static System.Void GetSettingsByIndex_Injected(System.Int32 index, UnityEngine.AI.NavMeshBuildSettings& ret) { }
        // RVA: 0x09D7F1B8  token: 0x60000A6
        private static System.Void UpdateSurfaceTransformInternal_Injected(System.Int32 surfaceID, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        // RVA: 0x0389F660  token: 0x60000A7
        private static System.Void CalculatePathAsyncInternal_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.Vector3& targetPosition, System.Int32 areaMask, UnityEngine.AI.NavMeshPath path, System.Boolean isReserveEnd, System.Int32 agentTypeID, System.Single radius) { }
        // RVA: 0x03645130  token: 0x60000A8
        private static System.Boolean RaycastNearestPoint_Injected(UnityEngine.Vector3& sourcePosition, UnityEngine.Vector3& targetPosition, UnityEngine.AI.NavMeshHit& hit, System.Int32 areaMask) { }

    }

    // TypeToken: 0x2000013  // size: 0x14
    public sealed struct NavMeshBuildSourceShape
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AI.NavMeshBuildSourceShape Mesh;  // const
        public static UnityEngine.AI.NavMeshBuildSourceShape Terrain;  // const
        public static UnityEngine.AI.NavMeshBuildSourceShape Box;  // const
        public static UnityEngine.AI.NavMeshBuildSourceShape Sphere;  // const
        public static UnityEngine.AI.NavMeshBuildSourceShape Capsule;  // const
        public static UnityEngine.AI.NavMeshBuildSourceShape ModifierBox;  // const
        public static UnityEngine.AI.NavMeshBuildSourceShape PhysicsTriangleMesh;  // const
        public static UnityEngine.AI.NavMeshBuildSourceShape PhysicsConvexMesh;  // const
        public static UnityEngine.AI.NavMeshBuildSourceShape PhysicsTerrain;  // const
        public static UnityEngine.AI.NavMeshBuildSourceShape ModifierPoly;  // const

    }

    // TypeToken: 0x2000014  // size: 0x14
    public sealed struct NavMeshCollectGeometry
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AI.NavMeshCollectGeometry RenderMeshes;  // const
        public static UnityEngine.AI.NavMeshCollectGeometry PhysicsColliders;  // const

    }

    // TypeToken: 0x2000015  // size: 0x88
    public sealed struct NavMeshBuildSource
    {
        // Fields
        private UnityEngine.Matrix4x4 m_Transform;  // 0x10
        private UnityEngine.Vector3 m_Size;  // 0x50
        private UnityEngine.AI.NavMeshBuildSourceShape m_Shape;  // 0x5c
        private System.Int32 m_Area;  // 0x60
        private System.Int32 m_InstanceID;  // 0x64
        private System.Int32 m_ComponentID;  // 0x68
        private System.Boolean m_IsConvex;  // 0x6c
        private System.IntPtr m_EcsShape;  // 0x70
        public System.Collections.Generic.List<UnityEngine.Vector3> convexVerts;  // 0x78
        public System.Single convexHmin;  // 0x80
        public System.Single convexHmax;  // 0x84

        // Properties
        UnityEngine.Matrix4x4 transform { get; /* RVA: 0x03D858B0 */ set; /* RVA: 0x03D858E0 */ }
        UnityEngine.Vector3 size { get; /* RVA: 0x03D85890 */ set; /* RVA: 0x03D52330 */ }
        UnityEngine.AI.NavMeshBuildSourceShape shape { get; /* RVA: 0x03D85880 */ set; /* RVA: 0x03D4EE30 */ }
        System.Int32 area { get; /* RVA: 0x03D85870 */ set; /* RVA: 0x03D4EF20 */ }
        UnityEngine.Object sourceObject { get; /* RVA: 0x09D7E1B0 */ }
        UnityEngine.Component component { get; /* RVA: 0x09D7E1A4 */ }

        // Methods
        // RVA: 0x09D7E13C  token: 0x60000B7
        private static UnityEngine.Component InternalGetComponent(System.Int32 instanceID) { }
        // RVA: 0x09D7E170  token: 0x60000B8
        private static UnityEngine.Object InternalGetObject(System.Int32 instanceID) { }

    }

    // TypeToken: 0x2000016  // size: 0x20
    public sealed struct NavMeshBuildMarkup
    {
        // Fields
        private System.Int32 m_OverrideArea;  // 0x10
        private System.Int32 m_Area;  // 0x14
        private System.Int32 m_IgnoreFromBuild;  // 0x18
        private System.Int32 m_InstanceID;  // 0x1c

        // Properties
        System.Boolean overrideArea { set; /* RVA: 0x09D7E0B8 */ }
        System.Int32 area { set; /* RVA: 0x03D51720 */ }
        System.Boolean ignoreFromBuild { set; /* RVA: 0x0237ACC0 */ }
        UnityEngine.Transform root { set; /* RVA: 0x09D7E0C0 */ }

    }

    // TypeToken: 0x2000017  // size: 0x6C
    public sealed struct NavMeshBuildSettings
    {
        // Fields
        private System.Int32 m_AgentTypeID;  // 0x10
        private System.Single m_AgentRadius;  // 0x14
        private System.Single m_AgentHeight;  // 0x18
        private System.Single m_AgentSlope;  // 0x1c
        private System.Single m_AgentClimb;  // 0x20
        private System.Single m_LedgeDropHeight;  // 0x24
        private System.Single m_MaxJumpAcrossDistance;  // 0x28
        private System.Single m_MinRegionArea;  // 0x2c
        private System.Int32 m_OverrideVoxelSize;  // 0x30
        private System.Single m_VoxelSize;  // 0x34
        private System.Int32 m_OverrideTileSize;  // 0x38
        private System.Int32 m_TileSize;  // 0x3c
        private System.Int32 m_AccuratePlacement;  // 0x40
        private System.UInt32 m_MaxJobWorkers;  // 0x44
        private System.Int32 m_PreserveTilesOutsideBounds;  // 0x48
        private System.Int32 m_PartitioningMethod;  // 0x4c
        private System.Int32 m_FilterLowHangingObstacles;  // 0x50
        private System.Int32 m_FilterLedgeSpans;  // 0x54
        private System.Int32 m_FilterWalkableLowHeightSpans;  // 0x58
        private System.Int32 m_erodeAgainstWallSpans;  // 0x5c
        private System.Int32 m_cliffIndent;  // 0x60
        private System.Int32 m_DynamicNavmeshSurfaceType;  // 0x64
        private UnityEngine.AI.NavMeshBuildDebugSettings m_Debug;  // 0x68

        // Properties
        System.Int32 agentTypeID { get; /* RVA: 0x03D85860 */ set; /* RVA: 0x03D4E970 */ }
        System.Single agentRadius { get; /* RVA: 0x03D85850 */ }
        System.Single agentHeight { get; /* RVA: 0x03D85840 */ }
        System.Single agentClimb { get; /* RVA: 0x03D85830 */ }
        System.Single minRegionArea { set; /* RVA: 0x03D4F120 */ }
        System.Boolean overrideVoxelSize { set; /* RVA: 0x0307F300 */ }
        System.Single voxelSize { set; /* RVA: 0x03D52500 */ }
        System.Boolean overrideTileSize { set; /* RVA: 0x0307F2E0 */ }
        System.Int32 tileSize { set; /* RVA: 0x03D4EDE0 */ }
        System.Int32 partitioningMethod { set; /* RVA: 0x03D4EDC0 */ }
        System.Boolean filterLowHangingObstacles { set; /* RVA: 0x0307F260 */ }
        System.Boolean filterLedgeSpans { set; /* RVA: 0x0307F280 */ }
        System.Boolean filterWalkableLowHeightSpans { set; /* RVA: 0x0307F2A0 */ }
        System.Boolean erodeAgainstWallSpans { set; /* RVA: 0x0307F2C0 */ }
        System.Int32 cliffIndent { set; /* RVA: 0x03D4EF20 */ }

    }

    // TypeToken: 0x2000018  // size: 0x11
    public sealed struct NavMeshBuildDebugSettings
    {
        // Fields
        private System.Byte m_Flags;  // 0x10

    }

}

namespace UnityEngine.Experimental.AI
{

    // TypeToken: 0x2000019  // size: 0x18
    public sealed struct PolygonId : System.IEquatable`1
    {
        // Fields
        private System.UInt64 polyRef;  // 0x10

        // Methods
        // RVA: 0x02361C20  token: 0x60000CD
        public System.Boolean IsNull() { }
        // RVA: 0x0232CE30  token: 0x60000CE
        public static System.Boolean op_Equality(UnityEngine.Experimental.AI.PolygonId x, UnityEngine.Experimental.AI.PolygonId y) { }
        // RVA: 0x03CFE7D0  token: 0x60000CF
        public static System.Boolean op_Inequality(UnityEngine.Experimental.AI.PolygonId x, UnityEngine.Experimental.AI.PolygonId y) { }
        // RVA: 0x03D859F0  token: 0x60000D0
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09D7F378  token: 0x60000D1
        public virtual System.Boolean Equals(UnityEngine.Experimental.AI.PolygonId rhs) { }
        // RVA: 0x09D7F30C  token: 0x60000D2
        public virtual System.Boolean Equals(System.Object obj) { }

    }

    // TypeToken: 0x200001A  // size: 0x28
    public sealed struct NavMeshLocation
    {
        // Fields
        private readonly UnityEngine.Experimental.AI.PolygonId <polygon>k__BackingField;  // 0x10
        private readonly UnityEngine.Vector3 <position>k__BackingField;  // 0x18

        // Properties
        UnityEngine.Experimental.AI.PolygonId polygon { get; /* RVA: 0x020C61B0 */ }
        UnityEngine.Vector3 position { get; /* RVA: 0x03D5E630 */ }

    }

    // TypeToken: 0x200001B  // size: 0x14
    public sealed struct PathQueryStatus
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.Experimental.AI.PathQueryStatus Failure;  // const
        public static UnityEngine.Experimental.AI.PathQueryStatus Success;  // const
        public static UnityEngine.Experimental.AI.PathQueryStatus InProgress;  // const
        public static UnityEngine.Experimental.AI.PathQueryStatus StatusDetailMask;  // const
        public static UnityEngine.Experimental.AI.PathQueryStatus WrongMagic;  // const
        public static UnityEngine.Experimental.AI.PathQueryStatus WrongVersion;  // const
        public static UnityEngine.Experimental.AI.PathQueryStatus OutOfMemory;  // const
        public static UnityEngine.Experimental.AI.PathQueryStatus InvalidParam;  // const
        public static UnityEngine.Experimental.AI.PathQueryStatus BufferTooSmall;  // const
        public static UnityEngine.Experimental.AI.PathQueryStatus OutOfNodes;  // const
        public static UnityEngine.Experimental.AI.PathQueryStatus PartialResult;  // const

    }

    // TypeToken: 0x200001C  // size: 0x18
    public sealed struct NavMeshWorld
    {
        // Fields
        private System.IntPtr world;  // 0x10

        // Methods
        // RVA: 0x02A7A840  token: 0x60000D5
        public static UnityEngine.Experimental.AI.NavMeshWorld GetDefaultWorld() { }
        // RVA: 0x02A7A890  token: 0x60000D6
        private static System.Void GetDefaultWorld_Injected(UnityEngine.Experimental.AI.NavMeshWorld& ret) { }

    }

    // TypeToken: 0x200001D  // size: 0x18
    public sealed struct NavMeshQuery : System.IDisposable
    {
        // Fields
        private System.IntPtr m_NavMeshQuery;  // 0x10

        // Methods
        // RVA: 0x0307F380  token: 0x60000D7
        public System.Void .ctor(UnityEngine.Experimental.AI.NavMeshWorld world, Unity.Collections.Allocator allocator, System.Int32 pathNodePoolSize) { }
        // RVA: 0x03334BD0  token: 0x60000D8
        public virtual System.Void Dispose() { }
        // RVA: 0x04274DBC  token: 0x60000D9
        private static System.IntPtr Create(UnityEngine.Experimental.AI.NavMeshWorld world, System.Int32 nodePoolSize) { }
        // RVA: 0x03334C50  token: 0x60000DA
        private static System.Void Destroy(System.IntPtr navMeshQuery) { }
        // RVA: 0x02792F30  token: 0x60000DB
        private static UnityEngine.Experimental.AI.NavMeshLocation MapLocation(System.IntPtr navMeshQuery, UnityEngine.Vector3 position, UnityEngine.Vector3 extents, System.Int32 agentTypeID, System.Int32 areaMask) { }
        // RVA: 0x02792E60  token: 0x60000DC
        public UnityEngine.Experimental.AI.NavMeshLocation MapLocation(UnityEngine.Vector3 position, UnityEngine.Vector3 extents, System.Int32 agentTypeID, System.Int32 areaMask) { }
        // RVA: 0x02790920  token: 0x60000DD
        private static UnityEngine.Experimental.AI.NavMeshLocation MoveLocation(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation location, UnityEngine.Vector3 target, System.Int32 areaMask) { }
        // RVA: 0x02790850  token: 0x60000DE
        public UnityEngine.Experimental.AI.NavMeshLocation MoveLocation(UnityEngine.Experimental.AI.NavMeshLocation location, UnityEngine.Vector3 target, System.Int32 areaMask) { }
        // RVA: 0x09D7ED48  token: 0x60000DF
        private static UnityEngine.Experimental.AI.PathQueryStatus Raycast(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation start, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, System.Void* costs, UnityEngine.AI.NavMeshHit& hit, System.Void* path, System.Int32& pathCount, System.Int32 maxPath) { }
        // RVA: 0x09D7EDA0  token: 0x60000E0
        public UnityEngine.Experimental.AI.PathQueryStatus Raycast(UnityEngine.AI.NavMeshHit& hit, UnityEngine.Experimental.AI.NavMeshLocation start, UnityEngine.Vector3 targetPosition, System.Int32 areaMask, Unity.Collections.NativeArray<System.Single> costs) { }
        // RVA: 0x03477910  token: 0x60000E1
        private static System.IntPtr Create_Injected(UnityEngine.Experimental.AI.NavMeshWorld& world, System.Int32 nodePoolSize) { }
        // RVA: 0x02792FC0  token: 0x60000E2
        private static System.Void MapLocation_Injected(System.IntPtr navMeshQuery, UnityEngine.Vector3& position, UnityEngine.Vector3& extents, System.Int32 agentTypeID, System.Int32 areaMask, UnityEngine.Experimental.AI.NavMeshLocation& ret) { }
        // RVA: 0x02790670  token: 0x60000E3
        private static System.Void MoveLocation_Injected(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation& location, UnityEngine.Vector3& target, System.Int32 areaMask, UnityEngine.Experimental.AI.NavMeshLocation& ret) { }
        // RVA: 0x09D7ECE4  token: 0x60000E4
        private static UnityEngine.Experimental.AI.PathQueryStatus Raycast_Injected(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation& start, UnityEngine.Vector3& targetPosition, System.Int32 areaMask, System.Void* costs, UnityEngine.AI.NavMeshHit& hit, System.Void* path, System.Int32& pathCount, System.Int32 maxPath) { }

    }

}

