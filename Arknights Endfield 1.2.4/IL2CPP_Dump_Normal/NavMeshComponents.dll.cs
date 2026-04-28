// ========================================================
// Dumped by @desirepro
// Assembly: NavMeshComponents.dll
// Classes:  9
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000002  // size: 0x48
    public class NavMeshPrefabInstance : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.AI.NavMeshData m_NavMesh;  // 0x18
        private System.Boolean m_FollowTransform;  // 0x20
        private UnityEngine.AI.NavMeshDataInstance m_Instance;  // 0x24
        private static readonly System.Collections.Generic.List<NavMeshPrefabInstance> s_TrackedInstances;  // static @ 0x0
        private UnityEngine.Vector3 m_Position;  // 0x28
        private UnityEngine.Quaternion m_Rotation;  // 0x34

        // Properties
        UnityEngine.AI.NavMeshData navMeshData { get; /* RVA: 0x01041090 */ set; /* RVA: 0x022C3A90 */ }
        System.Boolean followTransform { get; /* RVA: 0x03D4EF90 */ set; /* RVA: 0x0929C3A0 */ }
        System.Collections.Generic.List<NavMeshPrefabInstance> trackedInstances { get; /* RVA: 0x0929C350 */ }

        // Methods
        // RVA: 0x0929BF6C  token: 0x6000006
        private System.Void OnEnable() { }
        // RVA: 0x0929BF48  token: 0x6000007
        private System.Void OnDisable() { }
        // RVA: 0x0929C150  token: 0x6000008
        public System.Void UpdateInstance() { }
        // RVA: 0x0929BB80  token: 0x6000009
        private System.Void AddInstance() { }
        // RVA: 0x0929BCC0  token: 0x600000A
        private System.Void AddTracking() { }
        // RVA: 0x0929BFA8  token: 0x600000B
        private System.Void RemoveTracking() { }
        // RVA: 0x0929C124  token: 0x600000C
        private System.Void SetFollowTransform(System.Boolean value) { }
        // RVA: 0x0929BE54  token: 0x600000D
        private System.Boolean HasMoved() { }
        // RVA: 0x0929C174  token: 0x600000E
        private static System.Void UpdateTrackedInstances() { }
        // RVA: 0x0426FE60  token: 0x600000F
        public System.Void .ctor() { }
        // RVA: 0x0929C2C4  token: 0x6000010
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000009  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly UnityEngine.AI.NavMeshSurface.<>c <>9;  // static @ 0x0
        public static System.Predicate<UnityEngine.AI.NavMeshModifierVolume> <>9__105_0;  // static @ 0x8
        public static System.Predicate<UnityEngine.AI.NavMeshModifier> <>9__106_0;  // static @ 0x10
        public static System.Predicate<UnityEngine.AI.NavMeshBuildSource> <>9__106_1;  // static @ 0x18
        public static System.Predicate<UnityEngine.AI.NavMeshBuildSource> <>9__106_2;  // static @ 0x20

        // Methods
        // RVA: 0x0929F2B8  token: 0x600008D
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x600008E
        public System.Void .ctor() { }
        // RVA: 0x0929F11C  token: 0x600008F
        private System.Boolean <AppendModifierVolumes>b__105_0(UnityEngine.AI.NavMeshModifierVolume x) { }
        // RVA: 0x0929F11C  token: 0x6000090
        private System.Boolean <CollectSources>b__106_0(UnityEngine.AI.NavMeshModifier x) { }
        // RVA: 0x0929F140  token: 0x6000091
        private System.Boolean <CollectSources>b__106_1(UnityEngine.AI.NavMeshBuildSource x) { }
        // RVA: 0x0929F1FC  token: 0x6000092
        private System.Boolean <CollectSources>b__106_2(UnityEngine.AI.NavMeshBuildSource x) { }

    }

namespace UnityEngine.AI
{

    // TypeToken: 0x2000003  // size: 0x90
    public class NavMeshLink : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Int32 m_AgentTypeID;  // 0x18
        private UnityEngine.Vector3 m_StartRight;  // 0x1c
        private UnityEngine.Vector3 m_StartLeft;  // 0x28
        private UnityEngine.Vector3 m_EndRight;  // 0x34
        private UnityEngine.Vector3 m_EndLeft;  // 0x40
        private System.Boolean m_IsExt;  // 0x4c
        private System.Single m_CostModifier;  // 0x50
        private System.Boolean m_Bidirectional;  // 0x54
        private System.Boolean m_AutoUpdatePosition;  // 0x55
        private System.Int32 m_Area;  // 0x58
        public System.Boolean autoSnapExtent;  // 0x5c
        public UnityEngine.Vector3 snapExtent;  // 0x60
        private UnityEngine.AI.NavMeshLinkInstance m_LinkInstance;  // 0x6c
        private UnityEngine.Vector3 m_LastPosition;  // 0x70
        private UnityEngine.Quaternion m_LastRotation;  // 0x7c
        private static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshLink> s_Tracked;  // static @ 0x0

        // Properties
        System.Int32 agentTypeID { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x0929B244 */ }
        UnityEngine.Vector3 startRight { get; /* RVA: 0x03D568F0 */ set; /* RVA: 0x0929B414 */ }
        UnityEngine.Vector3 startLeft { get; /* RVA: 0x03D50E80 */ set; /* RVA: 0x0929B3A0 */ }
        UnityEngine.Vector3 startMid { get; /* RVA: 0x0929B1C4 */ }
        UnityEngine.Vector3 endRight { get; /* RVA: 0x03D522E0 */ set; /* RVA: 0x0929B31C */ }
        UnityEngine.Vector3 endLeft { get; /* RVA: 0x03D52300 */ set; /* RVA: 0x0929B2A8 */ }
        UnityEngine.Vector3 endMid { get; /* RVA: 0x0929B144 */ }
        System.Boolean isExt { get; /* RVA: 0x03D4F520 */ set; /* RVA: 0x0929B390 */ }
        System.Single costModifier { get; /* RVA: 0x03D51C90 */ set; /* RVA: 0x0929B27C */ }
        System.Boolean bidirectional { get; /* RVA: 0x03D4F320 */ set; /* RVA: 0x0929B26C */ }
        System.Boolean autoUpdate { get; /* RVA: 0x03D4F310 */ set; /* RVA: 0x0929B264 */ }
        System.Int32 area { get; /* RVA: 0x03D4EF00 */ set; /* RVA: 0x0929B254 */ }

        // Methods
        // RVA: 0x0929ABDC  token: 0x6000027
        private System.Void OnEnable() { }
        // RVA: 0x0929AB90  token: 0x6000028
        private System.Void OnDisable() { }
        // RVA: 0x0929AE80  token: 0x6000029
        public System.Void UpdateLink() { }
        // RVA: 0x0929A900  token: 0x600002A
        private static System.Void AddTracking(UnityEngine.AI.NavMeshLink link) { }
        // RVA: 0x0929AC3C  token: 0x600002B
        private static System.Void RemoveTracking(UnityEngine.AI.NavMeshLink link) { }
        // RVA: 0x0929ADB8  token: 0x600002C
        private System.Void SetAutoUpdate(System.Boolean value) { }
        // RVA: 0x0929A73C  token: 0x600002D
        private System.Void AddLink() { }
        // RVA: 0x0929AE1C  token: 0x600002E
        public System.Void SetByLinkData(UnityEngine.AI.NavMeshLinkData data) { }
        // RVA: 0x0929AA94  token: 0x600002F
        private System.Boolean HasTransformChanged() { }
        // RVA: 0x0929AB88  token: 0x6000030
        private System.Void OnDidApplyAnimationProperties() { }
        // RVA: 0x0929AEA4  token: 0x6000031
        private static System.Void UpdateTrackedInstances() { }
        // RVA: 0x0929B080  token: 0x6000032
        public System.Void .ctor() { }
        // RVA: 0x0929AFF4  token: 0x6000033
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x30
    public class NavMeshModifier : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Boolean m_OverrideArea;  // 0x18
        private System.Int32 m_Area;  // 0x1c
        private System.Boolean m_IgnoreFromBuild;  // 0x20
        private System.Collections.Generic.List<System.Int32> m_AffectedAgents;  // 0x28
        private static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshModifier> s_NavMeshModifiers;  // static @ 0x0

        // Properties
        System.Boolean overrideArea { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        System.Int32 area { get; /* RVA: 0x03D4EBB0 */ set; /* RVA: 0x03D4EBC0 */ }
        System.Boolean ignoreFromBuild { get; /* RVA: 0x03D4EF90 */ set; /* RVA: 0x03D4EFC0 */ }
        System.Collections.Generic.List<UnityEngine.AI.NavMeshModifier> activeModifiers { get; /* RVA: 0x0929BB30 */ }

        // Methods
        // RVA: 0x0929B930  token: 0x600003B
        private System.Void OnEnable() { }
        // RVA: 0x0929B8C0  token: 0x600003C
        private System.Void OnDisable() { }
        // RVA: 0x0929B820  token: 0x600003D
        public System.Boolean AffectsAgentType(System.Int32 agentTypeID) { }
        // RVA: 0x0929BA6C  token: 0x600003E
        public System.Void .ctor() { }
        // RVA: 0x0929B9E0  token: 0x600003F
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000005  // size: 0x40
    public class NavMeshModifierVolume : UnityEngine.MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector3 m_Size;  // 0x18
        private UnityEngine.Vector3 m_Center;  // 0x24
        private System.Int32 m_Area;  // 0x30
        private System.Collections.Generic.List<System.Int32> m_AffectedAgents;  // 0x38
        private static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshModifierVolume> s_NavMeshModifiers;  // static @ 0x0

        // Properties
        UnityEngine.Vector3 size { get; /* RVA: 0x03D52510 */ set; /* RVA: 0x03D52530 */ }
        UnityEngine.Vector3 center { get; /* RVA: 0x03D59780 */ set; /* RVA: 0x03D5A9E0 */ }
        System.Int32 area { get; /* RVA: 0x03D4ED20 */ set; /* RVA: 0x03D4EE10 */ }
        System.Collections.Generic.List<UnityEngine.AI.NavMeshModifierVolume> activeModifiers { get; /* RVA: 0x0929B7D0 */ }

        // Methods
        // RVA: 0x0929B598  token: 0x6000047
        private System.Void OnEnable() { }
        // RVA: 0x0929B528  token: 0x6000048
        private System.Void OnDisable() { }
        // RVA: 0x0929B488  token: 0x6000049
        public System.Boolean AffectsAgentType(System.Int32 agentTypeID) { }
        // RVA: 0x0929B6D4  token: 0x600004A
        public System.Void .ctor() { }
        // RVA: 0x0929B648  token: 0x600004B
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000006  // size: 0x14
    public sealed struct CollectObjects
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AI.CollectObjects All;  // const
        public static UnityEngine.AI.CollectObjects Volume;  // const
        public static UnityEngine.AI.CollectObjects Children;  // const

    }

    // TypeToken: 0x2000007  // size: 0x14
    public sealed struct PartitioningMethod
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.AI.PartitioningMethod Layers;  // const
        public static UnityEngine.AI.PartitioningMethod Monotone;  // const
        public static UnityEngine.AI.PartitioningMethod Watershed;  // const

    }

    // TypeToken: 0x2000008  // size: 0x98
    public class NavMeshSurface : UnityEngine.MonoBehaviour
    {
        // Fields
        private System.Int32 m_AgentTypeID;  // 0x18
        private UnityEngine.AI.CollectObjects m_CollectObjects;  // 0x1c
        private UnityEngine.Vector3 m_Size;  // 0x20
        private UnityEngine.Vector3 m_Center;  // 0x2c
        private UnityEngine.LayerMask m_LayerMask;  // 0x38
        private System.String m_BlockTag;  // 0x40
        private UnityEngine.AI.PartitioningMethod m_PartitioningMethod;  // 0x48
        private System.Boolean m_FilterLowHangingObstacles;  // 0x4c
        private System.Boolean m_FilterLedgeSpans;  // 0x4d
        private System.Boolean m_FilterWalkableLowHeightSpans;  // 0x4e
        private System.Boolean m_OverrideMinRegionArea;  // 0x4f
        private System.Single m_MinRegionArea;  // 0x50
        private UnityEngine.AI.NavMeshCollectGeometry m_UseGeometry;  // 0x54
        private System.Int32 m_DefaultArea;  // 0x58
        private System.Boolean m_IgnoreNavMeshAgent;  // 0x5c
        private System.Boolean m_IgnoreNavMeshObstacle;  // 0x5d
        private System.Boolean m_OverrideTileSize;  // 0x5e
        private System.Int32 m_TileSize;  // 0x60
        private System.Boolean m_OverrideVoxelSize;  // 0x64
        private System.Single m_VoxelSize;  // 0x68
        private System.Boolean m_BuildHeightMesh;  // 0x6c
        private UnityEngine.AI.NavMeshData m_NavMeshData;  // 0x70
        private UnityEngine.AI.NavMeshDataInstance m_NavMeshDataInstance;  // 0x78
        private UnityEngine.Vector3 m_LastPosition;  // 0x7c
        private UnityEngine.Quaternion m_LastRotation;  // 0x88
        private static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshSurface> s_NavMeshSurfaces;  // static @ 0x0

        // Properties
        System.Int32 agentTypeID { get; /* RVA: 0x020D1AC0 */ set; /* RVA: 0x03D4E9C0 */ }
        UnityEngine.AI.CollectObjects collectObjects { get; /* RVA: 0x03D4EBB0 */ set; /* RVA: 0x03D4EBC0 */ }
        UnityEngine.Vector3 size { get; /* RVA: 0x03D59660 */ set; /* RVA: 0x03D5AE00 */ }
        UnityEngine.Vector3 center { get; /* RVA: 0x03D59800 */ set; /* RVA: 0x03D5BF30 */ }
        UnityEngine.LayerMask layerMask { get; /* RVA: 0x03D4EC30 */ set; /* RVA: 0x03D4ECB0 */ }
        System.String BlockTag { get; /* RVA: 0x03D4E2B0 */ set; /* RVA: 0x03CB2D80 */ }
        UnityEngine.AI.PartitioningMethod partitioningMethod { get; /* RVA: 0x03D4EC50 */ set; /* RVA: 0x03D4ECD0 */ }
        System.Boolean filterLowHangingObstacles { get; /* RVA: 0x03D4F520 */ set; /* RVA: 0x03D4F550 */ }
        System.Boolean filterLedgeSpans { get; /* RVA: 0x03D5CEB0 */ set; /* RVA: 0x03D5CEC0 */ }
        System.Boolean filterWalkableLowHeightSpans { get; /* RVA: 0x03D71340 */ set; /* RVA: 0x03D71380 */ }
        System.Boolean overrideMinRegionArea { get; /* RVA: 0x03D71360 */ set; /* RVA: 0x03D713A0 */ }
        System.Single minRegionArea { get; /* RVA: 0x03D51C90 */ set; /* RVA: 0x03D51CA0 */ }
        UnityEngine.AI.NavMeshCollectGeometry useGeometry { get; /* RVA: 0x03D4EEC0 */ set; /* RVA: 0x03D4EF10 */ }
        System.Int32 defaultArea { get; /* RVA: 0x03D4EF00 */ set; /* RVA: 0x03D4EF50 */ }
        System.Boolean ignoreNavMeshAgent { get; /* RVA: 0x03D4F600 */ set; /* RVA: 0x03D4F620 */ }
        System.Boolean ignoreNavMeshObstacle { get; /* RVA: 0x03D71350 */ set; /* RVA: 0x03D71390 */ }
        System.Boolean overrideTileSize { get; /* RVA: 0x03D71370 */ set; /* RVA: 0x03D713B0 */ }
        System.Int32 tileSize { get; /* RVA: 0x03D4F050 */ set; /* RVA: 0x03D4F5A0 */ }
        System.Boolean overrideVoxelSize { get; /* RVA: 0x03D590F0 */ set; /* RVA: 0x03D59100 */ }
        System.Single voxelSize { get; /* RVA: 0x03D56A40 */ set; /* RVA: 0x03D59110 */ }
        System.Boolean buildHeightMesh { get; /* RVA: 0x03D590E0 */ set; /* RVA: 0x03D50950 */ }
        UnityEngine.AI.NavMeshData navMeshData { get; /* RVA: 0x03D4EB30 */ set; /* RVA: 0x0519C3C8 */ }
        System.Collections.Generic.List<UnityEngine.AI.NavMeshSurface> activeSurfaces { get; /* RVA: 0x0929F0CC */ }

        // Methods
        // RVA: 0x0929E77C  token: 0x6000079
        private System.Void OnEnable() { }
        // RVA: 0x0929E730  token: 0x600007A
        private System.Void OnDisable() { }
        // RVA: 0x0929C3A8  token: 0x600007B
        public System.Void AddData() { }
        // RVA: 0x0929E99C  token: 0x600007C
        public System.Void RemoveData() { }
        // RVA: 0x0929E1F8  token: 0x600007D
        public UnityEngine.AI.NavMeshBuildSettings GetBuildSettings() { }
        // RVA: 0x0929CACC  token: 0x600007E
        public System.Void BuildNavMesh() { }
        // RVA: 0x0929EDC8  token: 0x600007F
        public UnityEngine.AsyncOperation UpdateNavMesh(UnityEngine.AI.NavMeshData data) { }
        // RVA: 0x0929EC18  token: 0x6000080
        public System.Boolean UpdateNavMeshSync(UnityEngine.AI.NavMeshData data) { }
        // RVA: 0x0929E7C8  token: 0x6000081
        private static System.Void Register(UnityEngine.AI.NavMeshSurface surface) { }
        // RVA: 0x0929E9BC  token: 0x6000082
        private static System.Void Unregister(UnityEngine.AI.NavMeshSurface surface) { }
        // RVA: 0x0929EB38  token: 0x6000083
        private static System.Void UpdateActive() { }
        // RVA: 0x0929C518  token: 0x6000084
        private System.Void AppendModifierVolumes(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>& sources) { }
        // RVA: 0x0929D694  token: 0x6000085
        private System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> CollectSources() { }
        // RVA: 0x03D5DA60  token: 0x6000086
        private static UnityEngine.Vector3 Abs(UnityEngine.Vector3 v) { }
        // RVA: 0x0929E358  token: 0x6000087
        private static UnityEngine.Bounds GetWorldBounds(UnityEngine.Matrix4x4 mat, UnityEngine.Bounds bounds) { }
        // RVA: 0x0929CDC4  token: 0x6000088
        private UnityEngine.Bounds CalculateWorldBounds(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources) { }
        // RVA: 0x0929E634  token: 0x6000089
        private System.Boolean HasTransformChanged() { }
        // RVA: 0x0929EBE4  token: 0x600008A
        private System.Void UpdateDataIfTransformChanged() { }
        // RVA: 0x0929F004  token: 0x600008B
        public System.Void .ctor() { }
        // RVA: 0x0929EF78  token: 0x600008C
        private static System.Void .cctor() { }

    }

}

