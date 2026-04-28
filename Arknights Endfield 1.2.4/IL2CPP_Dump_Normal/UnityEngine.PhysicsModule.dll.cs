// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.PhysicsModule.dll
// Classes:  35
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000017  // size: 0x80
    public sealed class CollisionCallback : System.MulticastDelegate
    {
        // Methods
        // RVA: 0x09E1CA04  token: 0x6000267
        public System.Void .ctor(System.Object object, System.IntPtr method) { }
        // RVA: 0x09E1C9B8  token: 0x6000268
        public virtual System.Void Invoke(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider) { }

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

    // TypeToken: 0x2000004  // size: 0x14
    public sealed struct RigidbodyConstraints
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.RigidbodyConstraints None;  // const
        public static UnityEngine.RigidbodyConstraints FreezePositionX;  // const
        public static UnityEngine.RigidbodyConstraints FreezePositionY;  // const
        public static UnityEngine.RigidbodyConstraints FreezePositionZ;  // const
        public static UnityEngine.RigidbodyConstraints FreezeRotationX;  // const
        public static UnityEngine.RigidbodyConstraints FreezeRotationY;  // const
        public static UnityEngine.RigidbodyConstraints FreezeRotationZ;  // const
        public static UnityEngine.RigidbodyConstraints FreezePosition;  // const
        public static UnityEngine.RigidbodyConstraints FreezeRotation;  // const
        public static UnityEngine.RigidbodyConstraints FreezeAll;  // const

    }

    // TypeToken: 0x2000005  // size: 0x14
    public sealed struct ForceMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.ForceMode Force;  // const
        public static UnityEngine.ForceMode Acceleration;  // const
        public static UnityEngine.ForceMode Impulse;  // const
        public static UnityEngine.ForceMode VelocityChange;  // const

    }

    // TypeToken: 0x2000006  // size: 0x14
    public sealed struct MeshColliderCookingOptions
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.MeshColliderCookingOptions None;  // const
        public static UnityEngine.MeshColliderCookingOptions InflateConvexMesh;  // const
        public static UnityEngine.MeshColliderCookingOptions CookForFasterSimulation;  // const
        public static UnityEngine.MeshColliderCookingOptions EnableMeshCleaning;  // const
        public static UnityEngine.MeshColliderCookingOptions WeldColocatedVertices;  // const
        public static UnityEngine.MeshColliderCookingOptions UseFastMidphase;  // const

    }

    // TypeToken: 0x2000007  // size: 0x14
    public sealed struct ColliderSurfaceType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.ColliderSurfaceType Default;  // const
        public static UnityEngine.ColliderSurfaceType Concrete;  // const
        public static UnityEngine.ColliderSurfaceType Wood;  // const
        public static UnityEngine.ColliderSurfaceType Dirt;  // const
        public static UnityEngine.ColliderSurfaceType Grass;  // const
        public static UnityEngine.ColliderSurfaceType Stone;  // const
        public static UnityEngine.ColliderSurfaceType Water;  // const
        public static UnityEngine.ColliderSurfaceType Flesh;  // const
        public static UnityEngine.ColliderSurfaceType Metal;  // const
        public static UnityEngine.ColliderSurfaceType Crystal;  // const
        public static UnityEngine.ColliderSurfaceType Rubber;  // const
        public static UnityEngine.ColliderSurfaceType Sand;  // const
        public static UnityEngine.ColliderSurfaceType Gravel;  // const
        public static UnityEngine.ColliderSurfaceType Moss;  // const
        public static UnityEngine.ColliderSurfaceType Custom;  // const
        public static UnityEngine.ColliderSurfaceType Snow;  // const
        public static UnityEngine.ColliderSurfaceType Mud;  // const
        public static UnityEngine.ColliderSurfaceType Cardboard;  // const
        public static UnityEngine.ColliderSurfaceType Plastic;  // const
        public static UnityEngine.ColliderSurfaceType Ice;  // const
        public static UnityEngine.ColliderSurfaceType Wet;  // const
        public static UnityEngine.ColliderSurfaceType WaterV2;  // const

    }

    // TypeToken: 0x2000008  // size: 0x14
    public sealed struct RigidbodyInterpolation
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.RigidbodyInterpolation None;  // const
        public static UnityEngine.RigidbodyInterpolation Interpolate;  // const
        public static UnityEngine.RigidbodyInterpolation Extrapolate;  // const

    }

    // TypeToken: 0x2000009  // size: 0x50
    public class ControllerColliderHit
    {
        // Fields
        private UnityEngine.CharacterController m_Controller;  // 0x10
        private UnityEngine.Collider m_Collider;  // 0x18
        private UnityEngine.Vector3 m_Point;  // 0x20
        private UnityEngine.Vector3 m_Normal;  // 0x2c
        private UnityEngine.Vector3 m_MoveDirection;  // 0x38
        private System.Single m_MoveLength;  // 0x44
        private System.Int32 m_Push;  // 0x48

        // Properties
        UnityEngine.GameObject gameObject { get; /* RVA: 0x09E1CBF4 */ }
        UnityEngine.Vector3 point { get; /* RVA: 0x03D87FA0 */ }

    }

    // TypeToken: 0x200000A  // size: 0x50
    public class Collision
    {
        // Fields
        private UnityEngine.Vector3 m_Impulse;  // 0x10
        private UnityEngine.Vector3 m_RelativeVelocity;  // 0x1c
        private UnityEngine.Component m_Body;  // 0x28
        private UnityEngine.Collider m_Collider;  // 0x30
        private System.Int32 m_ContactCount;  // 0x38
        private UnityEngine.ContactPoint[] m_ReusedContacts;  // 0x40
        private UnityEngine.ContactPoint[] m_LegacyContacts;  // 0x48

        // Properties
        UnityEngine.Vector3 relativeVelocity { get; /* RVA: 0x03D85980 */ }
        UnityEngine.Collider collider { get; /* RVA: 0x03D86D10 */ }
        UnityEngine.GameObject gameObject { get; /* RVA: 0x09E1CB34 */ }
        UnityEngine.ContactPoint[] contacts { get; /* RVA: 0x09E1CACC */ }
        UnityEngine.Vector3 impulse { get; /* RVA: 0x03D859D0 */ }

    }

    // TypeToken: 0x200000B  // size: 0x14
    public sealed struct QueryTriggerInteraction
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.QueryTriggerInteraction UseGlobal;  // const
        public static UnityEngine.QueryTriggerInteraction Ignore;  // const
        public static UnityEngine.QueryTriggerInteraction Collide;  // const

    }

    // TypeToken: 0x200000C  // size: 0x14
    public sealed struct CollisionDetectionMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.CollisionDetectionMode Discrete;  // const
        public static UnityEngine.CollisionDetectionMode Continuous;  // const
        public static UnityEngine.CollisionDetectionMode ContinuousDynamic;  // const
        public static UnityEngine.CollisionDetectionMode ContinuousSpeculative;  // const

    }

    // TypeToken: 0x200000D  // size: 0x18
    public class ArticulationBody : UnityEngine.Behaviour
    {
        // Methods
        // RVA: 0x0426FE60  token: 0x600000A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000E  // size: 0x10
    public class Physics
    {
        // Fields
        private static System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEvent;  // static @ 0x0
        private static System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEventCCD;  // static @ 0x8
        private static System.Single k_MaxFloatMinusEpsilon;  // const
        public static System.Int32 IgnoreRaycastLayer;  // const
        public static System.Int32 DefaultRaycastLayers;  // const
        public static System.Int32 AllLayers;  // const
        public static System.Int32 kIgnoreRaycastLayer;  // const
        public static System.Int32 kDefaultRaycastLayers;  // const
        public static System.Int32 kAllLayers;  // const

        // Properties
        UnityEngine.Vector3 gravity { get; /* RVA: 0x0282FAC0 */ set; /* RVA: 0x09E26928 */ }
        System.Single defaultContactOffset { get; /* RVA: 0x027E7190 */ set; /* RVA: 0x09E267D8 */ }
        System.Single sleepThreshold { get; /* RVA: 0x09E26598 */ set; /* RVA: 0x09E26AB4 */ }
        System.Boolean queriesHitTriggers { get; /* RVA: 0x09E26540 */ set; /* RVA: 0x09E26A4C */ }
        System.Boolean queriesHitBackfaces { get; /* RVA: 0x09E26514 */ set; /* RVA: 0x09E26A18 */ }
        System.Single bounceThreshold { get; /* RVA: 0x09E262F8 */ set; /* RVA: 0x09E26750 */ }
        System.Single defaultMaxDepenetrationVelocity { get; /* RVA: 0x09E263B4 */ set; /* RVA: 0x09E26850 */ }
        System.Int32 defaultSolverIterations { get; /* RVA: 0x09E263E0 */ set; /* RVA: 0x09E2688C */ }
        System.Int32 defaultSolverVelocityIterations { get; /* RVA: 0x09E2640C */ set; /* RVA: 0x09E268C0 */ }
        System.Single defaultMaxAngularSpeed { get; /* RVA: 0x09E26388 */ set; /* RVA: 0x09E26814 */ }
        System.Boolean improvedPatchFriction { get; /* RVA: 0x09E26438 */ set; /* RVA: 0x09E26938 */ }
        UnityEngine.PhysicsScene defaultPhysicsScene { get; /* RVA: 0x027EDC40 */ }
        System.Boolean logPhysXCheckError { get; /* RVA: 0x09E264E8 */ set; /* RVA: 0x02F2EB90 */ }
        System.Boolean autoSimulation { get; /* RVA: 0x02F50A90 */ set; /* RVA: 0x02F2EBD0 */ }
        System.Boolean autoSyncTransforms { get; /* RVA: 0x09E262CC */ set; /* RVA: 0x09E2671C */ }
        System.Boolean reuseCollisionCallbacks { get; /* RVA: 0x09E2656C */ set; /* RVA: 0x09E26A80 */ }
        System.Single interCollisionDistance { get; /* RVA: 0x09E26464 */ set; /* RVA: 0x09E2696C */ }
        System.Single interCollisionStiffness { get; /* RVA: 0x09E264BC */ set; /* RVA: 0x09E269DC */ }
        System.Boolean interCollisionSettingsToggle { get; /* RVA: 0x09E26490 */ set; /* RVA: 0x09E269A8 */ }
        UnityEngine.Vector3 clothGravity { get; /* RVA: 0x09E26364 */ set; /* RVA: 0x09E267C8 */ }
        System.Single minPenetrationForPenalty { get; /* RVA: 0x03D85FA0 */ set; /* RVA: 0x0350B670 */ }
        System.Single bounceTreshold { get; /* RVA: 0x09E26324 */ set; /* RVA: 0x09E2678C */ }
        System.Single sleepVelocity { get; /* RVA: 0x03D85FA0 */ set; /* RVA: 0x0350B670 */ }
        System.Single sleepAngularVelocity { get; /* RVA: 0x03D85FA0 */ set; /* RVA: 0x0350B670 */ }
        System.Single maxAngularVelocity { get; /* RVA: 0x03D85FA0 */ set; /* RVA: 0x0350B670 */ }
        System.Int32 solverIterationCount { get; /* RVA: 0x09E265C4 */ set; /* RVA: 0x09E26AF0 */ }
        System.Int32 solverVelocityIterationCount { get; /* RVA: 0x09E265D0 */ set; /* RVA: 0x09E26AF8 */ }
        System.Single penetrationPenaltyForce { get; /* RVA: 0x03D85FA0 */ set; /* RVA: 0x0350B670 */ }

        // Events
        event System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEvent;
        event System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEventCCD;

        // Methods
        // RVA: 0x09E227F8  token: 0x600000F
        private static System.Void OnSceneContactModify(UnityEngine.PhysicsScene scene, System.IntPtr buffer, System.Int32 count, System.Boolean isCCD) { }
        // RVA: 0x03D46E90  token: 0x6000029
        public static System.Void ClearUnusedMemory() { }
        // RVA: 0x09E221C4  token: 0x600002A
        public static System.Void IgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2, System.Boolean ignore) { }
        // RVA: 0x09E22218  token: 0x600002B
        public static System.Void IgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2) { }
        // RVA: 0x09E22230  token: 0x600002C
        public static System.Void IgnoreLayerCollision(System.Int32 layer1, System.Int32 layer2, System.Boolean ignore) { }
        // RVA: 0x09E220FC  token: 0x600002D
        public static System.Void ForceRebuildDynamicTree(System.Boolean rebuildStatic, System.Boolean rebuildDynamic) { }
        // RVA: 0x09E22224  token: 0x600002E
        public static System.Void IgnoreLayerCollision(System.Int32 layer1, System.Int32 layer2) { }
        // RVA: 0x09E22184  token: 0x600002F
        public static System.Boolean GetIgnoreLayerCollision(System.Int32 layer1, System.Int32 layer2) { }
        // RVA: 0x09E22140  token: 0x6000030
        public static System.Boolean GetIgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2) { }
        // RVA: 0x09E25200  token: 0x6000031
        public static System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E250E0  token: 0x6000032
        public static System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E255B8  token: 0x6000033
        public static System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance) { }
        // RVA: 0x09E254BC  token: 0x6000034
        public static System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction) { }
        // RVA: 0x027EE8C0  token: 0x6000035
        public static System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x02FA35E0  token: 0x6000036
        public static System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x02EC0080  token: 0x6000037
        public static System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance) { }
        // RVA: 0x09E25170  token: 0x6000038
        public static System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo) { }
        // RVA: 0x09E24FB8  token: 0x6000039
        public static System.Boolean RaycastV2(UnityEngine.ECSColliderResultProxy proxy, UnityEngine.Ray ray, System.Single maxDistance, UnityEngine.RaycastHit& hit) { }
        // RVA: 0x09E2504C  token: 0x600003A
        public static System.Boolean RaycastV2(UnityEngine.ECSColliderResultProxy proxy, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, UnityEngine.RaycastHit& hit) { }
        // RVA: 0x09E22428  token: 0x600003B
        private static UnityEngine.RaycastHit Internal_RaycastTestV2(UnityEngine.ECSColliderResultProxy collider, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit) { }
        // RVA: 0x09E2542C  token: 0x600003C
        public static System.Boolean Raycast(UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E25298  token: 0x600003D
        public static System.Boolean Raycast(UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E25320  token: 0x600003E
        public static System.Boolean Raycast(UnityEngine.Ray ray, System.Single maxDistance) { }
        // RVA: 0x09E25640  token: 0x600003F
        public static System.Boolean Raycast(UnityEngine.Ray ray) { }
        // RVA: 0x02DDC180  token: 0x6000040
        public static System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x029119B0  token: 0x6000041
        public static System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E2539C  token: 0x6000042
        public static System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance) { }
        // RVA: 0x09E25534  token: 0x6000043
        public static System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo) { }
        // RVA: 0x09E22698  token: 0x6000044
        public static System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E22768  token: 0x6000045
        public static System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32 layerMask) { }
        // RVA: 0x09E2264C  token: 0x6000046
        public static System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end) { }
        // RVA: 0x09E22528  token: 0x6000047
        public static System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E227B0  token: 0x6000048
        public static System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask) { }
        // RVA: 0x09E22600  token: 0x6000049
        public static System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.RaycastHit& hitInfo) { }
        // RVA: 0x09E21350  token: 0x600004A
        public static System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E215F8  token: 0x600004B
        public static System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E214A8  token: 0x600004C
        public static System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance) { }
        // RVA: 0x09E21254  token: 0x600004D
        public static System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction) { }
        // RVA: 0x09E2151C  token: 0x600004E
        public static System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E212C8  token: 0x600004F
        public static System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E211CC  token: 0x6000050
        public static System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance) { }
        // RVA: 0x09E21424  token: 0x6000051
        public static System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo) { }
        // RVA: 0x027E7EB0  token: 0x6000052
        public static System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E25D64  token: 0x6000053
        public static System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E25FB8  token: 0x6000054
        public static System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance) { }
        // RVA: 0x09E25E3C  token: 0x6000055
        public static System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo) { }
        // RVA: 0x09E25E9C  token: 0x6000056
        public static System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E25F84  token: 0x6000057
        public static System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E25E04  token: 0x6000058
        public static System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance) { }
        // RVA: 0x09E26078  token: 0x6000059
        public static System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius) { }
        // RVA: 0x09E26018  token: 0x600005A
        public static System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E260B8  token: 0x600005B
        public static System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E25DC8  token: 0x600005C
        public static System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance) { }
        // RVA: 0x09E25F40  token: 0x600005D
        public static System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo) { }
        // RVA: 0x09E204B8  token: 0x600005E
        public static System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E20808  token: 0x600005F
        public static System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E206BC  token: 0x6000060
        public static System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance) { }
        // RVA: 0x09E20928  token: 0x6000061
        public static System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation) { }
        // RVA: 0x09E20428  token: 0x6000062
        public static System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction) { }
        // RVA: 0x09E20744  token: 0x6000063
        public static System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E2058C  token: 0x6000064
        public static System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E209B0  token: 0x6000065
        public static System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation, System.Single maxDistance) { }
        // RVA: 0x09E20894  token: 0x6000066
        public static System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation) { }
        // RVA: 0x09E20624  token: 0x6000067
        public static System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo) { }
        // RVA: 0x09E2239C  token: 0x6000068
        private static UnityEngine.RaycastHit[] Internal_RaycastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E24A60  token: 0x6000069
        public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E24A18  token: 0x600006A
        public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E24BD0  token: 0x600006B
        public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance) { }
        // RVA: 0x09E24C1C  token: 0x600006C
        public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction) { }
        // RVA: 0x09E24B84  token: 0x600006D
        public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E249CC  token: 0x600006E
        public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E2497C  token: 0x600006F
        public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, System.Single maxDistance) { }
        // RVA: 0x09E24C70  token: 0x6000070
        public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray) { }
        // RVA: 0x03115370  token: 0x6000071
        public static System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E24D54  token: 0x6000072
        public static System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E24CC4  token: 0x6000073
        public static System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance) { }
        // RVA: 0x03559320  token: 0x6000074
        public static System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results) { }
        // RVA: 0x027ED890  token: 0x6000075
        public static System.Int32 RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E24E88  token: 0x6000076
        public static System.Int32 RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E24DEC  token: 0x6000077
        public static System.Int32 RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance) { }
        // RVA: 0x09E24F28  token: 0x6000078
        public static System.Int32 RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results) { }
        // RVA: 0x09E24328  token: 0x6000079
        private static UnityEngine.RaycastHit[] Query_CapsuleCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E20A44  token: 0x600007A
        public static UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E20BF8  token: 0x600007B
        public static UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E20B84  token: 0x600007C
        public static UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance) { }
        // RVA: 0x09E20C70  token: 0x600007D
        public static UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction) { }
        // RVA: 0x09E24884  token: 0x600007E
        private static UnityEngine.RaycastHit[] Query_SphereCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E259F8  token: 0x600007F
        public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E25830  token: 0x6000080
        public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E25970  token: 0x6000081
        public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance) { }
        // RVA: 0x09E25918  token: 0x6000082
        public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction) { }
        // RVA: 0x09E258C4  token: 0x6000083
        public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E257FC  token: 0x6000084
        public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E259C0  token: 0x6000085
        public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance) { }
        // RVA: 0x09E25884  token: 0x6000086
        public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, System.Single radius) { }
        // RVA: 0x09E23958  token: 0x6000087
        private static UnityEngine.Collider[] OverlapCapsule_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E23A4C  token: 0x6000088
        public static UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E23988  token: 0x6000089
        public static UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask) { }
        // RVA: 0x09E23B24  token: 0x600008A
        public static UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius) { }
        // RVA: 0x09E237A4  token: 0x600008B
        private static UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E23868  token: 0x600008C
        public static UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E23820  token: 0x600008D
        public static UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask) { }
        // RVA: 0x09E237D4  token: 0x600008E
        public static UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius) { }
        // RVA: 0x09E240B0  token: 0x600008F
        private static UnityEngine.Collider[] OverlapSphere_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E24178  token: 0x6000090
        public static UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x0270A7C0  token: 0x6000091
        public static UnityEngine.ECSColliderResultProxy CreateECSProxy(UnityEngine.Collider collider) { }
        // RVA: 0x09E240D8  token: 0x6000092
        public static UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask) { }
        // RVA: 0x09E24230  token: 0x6000093
        public static UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, System.Single radius) { }
        // RVA: 0x09E23F50  token: 0x6000094
        private static UnityEngine.ECSColliderResultProxy[] OverlapSphereV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E23FB0  token: 0x6000095
        public static UnityEngine.ECSColliderResultProxy[] OverlapSphereV2(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E2401C  token: 0x6000096
        public static UnityEngine.ECSColliderResultProxy[] OverlapSphereV2(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask) { }
        // RVA: 0x09E23F78  token: 0x6000097
        public static UnityEngine.ECSColliderResultProxy[] OverlapSphereV2(UnityEngine.Vector3 position, System.Single radius) { }
        // RVA: 0x042747DC  token: 0x6000098
        private static System.Void Simulate_Internal(UnityEngine.PhysicsScene physicsScene, System.Single step) { }
        // RVA: 0x02F50A00  token: 0x6000099
        public static System.Void Simulate(System.Single step) { }
        // RVA: 0x02722980  token: 0x600009C
        public static System.Void SyncTransforms() { }
        // RVA: 0x09E24738  token: 0x60000A1
        private static System.Boolean Query_ComputePenetration(UnityEngine.Collider colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x09E21F14  token: 0x60000A2
        public static System.Boolean ComputePenetration(UnityEngine.Collider colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x04272A3C  token: 0x60000A3
        private static System.Boolean Query_ComputePenetrationV2(UnityEngine.ECSColliderResultProxy colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x02B2F270  token: 0x60000A4
        public static System.Boolean ComputePenetrationV2(UnityEngine.ECSColliderResultProxy colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x09E24688  token: 0x60000A5
        private static System.Boolean Query_ComputeCapsulePenetration(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x09E21DE8  token: 0x60000A6
        public static System.Boolean ComputeCapsulePenetration(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x09E245D8  token: 0x60000A7
        private static System.Boolean Query_ComputeCapsulePenetrationV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x09E21D1C  token: 0x60000A8
        public static System.Boolean ComputeCapsulePenetrationV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x09E247E8  token: 0x60000A9
        private static System.Boolean Query_ComputeSpherePenetrationV2(UnityEngine.Vector3 center, System.Single radius, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x09E2204C  token: 0x60000AA
        public static System.Boolean ComputeSpherePenetrationV2(UnityEngine.Vector3 center, System.Single radius, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x09E24528  token: 0x60000AB
        private static System.Boolean Query_ComputeBoxPenetrationV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtent, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x09E21C40  token: 0x60000AC
        public static System.Boolean ComputeBoxPenetrationV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtent, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x09E224F0  token: 0x60000AD
        private static System.Boolean IsSimulatedThisFrame_Internal() { }
        // RVA: 0x09E2251C  token: 0x60000AE
        public static System.Boolean IsSimulatedThisFrame() { }
        // RVA: 0x09E257C0  token: 0x60000AF
        private static System.Void SetForceSimulateThisFrame_Internal(System.Boolean force) { }
        // RVA: 0x09E257F4  token: 0x60000B0
        public static System.Void SetForceSimulateThisFrame(System.Boolean force) { }
        // RVA: 0x03D1EE20  token: 0x60000B1
        private static System.Void SetFastSimulate_Internal(System.Boolean fast) { }
        // RVA: 0x042746E4  token: 0x60000B2
        public static System.Void SetFastSimulate(System.Boolean fast) { }
        // RVA: 0x09E24484  token: 0x60000B3
        private static UnityEngine.Vector3 Query_ClosestPoint(UnityEngine.Collider collider, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point) { }
        // RVA: 0x09E21B48  token: 0x60000B4
        public static UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 point, UnityEngine.Collider collider, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09E243E0  token: 0x60000B5
        private static UnityEngine.Vector3 Query_ClosestPointV2(UnityEngine.ECSColliderResultProxy colliderProxy, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point) { }
        // RVA: 0x09E21AA4  token: 0x60000B6
        public static UnityEngine.Vector3 ClosestPointV2(UnityEngine.Vector3 point, UnityEngine.ECSColliderResultProxy colliderProxy, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09E24928  token: 0x60000B7
        private static UnityEngine.Vector3 Query_TryGetClosestPoint(UnityEngine.ECSColliderResultProxy colliderProxy, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point, System.Boolean& resultIsValid) { }
        // RVA: 0x09E260F4  token: 0x60000B8
        public static System.Boolean TryGetClosestPoint(UnityEngine.ECSColliderResultProxy colliderProxy, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point, UnityEngine.Vector3& result) { }
        // RVA: 0x09E23E20  token: 0x60000C1
        public static System.Int32 OverlapSphereNonAlloc(UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E23D6C  token: 0x60000C2
        public static System.Int32 OverlapSphereNonAlloc(UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask) { }
        // RVA: 0x09E23CC4  token: 0x60000C3
        public static System.Int32 OverlapSphereNonAlloc(UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results) { }
        // RVA: 0x09E23BDC  token: 0x60000C4
        public static System.Int32 OverlapSphereNonAllocV2(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E23C94  token: 0x60000C5
        public static System.Int32 OverlapSphereNonAllocV2(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask) { }
        // RVA: 0x09E23C5C  token: 0x60000C6
        public static System.Int32 OverlapSphereNonAllocV2(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results) { }
        // RVA: 0x09E219A8  token: 0x60000C7
        private static System.Boolean CheckSphere_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E21A08  token: 0x60000C8
        public static System.Boolean CheckSphere(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E21A74  token: 0x60000C9
        public static System.Boolean CheckSphere(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask) { }
        // RVA: 0x09E219D0  token: 0x60000CA
        public static System.Boolean CheckSphere(UnityEngine.Vector3 position, System.Single radius) { }
        // RVA: 0x02B30890  token: 0x60000CB
        public static System.Int32 CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E20E88  token: 0x60000CC
        public static System.Int32 CapsuleCastNonAllocV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E21038  token: 0x60000CD
        public static System.Int32 CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E20F64  token: 0x60000CE
        public static System.Int32 CapsuleCastNonAllocV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] results, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E21144  token: 0x60000CF
        public static System.Int32 CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance) { }
        // RVA: 0x09E20DB4  token: 0x60000D0
        public static System.Int32 CapsuleCastNonAllocV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] results, System.Single maxDistance) { }
        // RVA: 0x09E210C0  token: 0x60000D1
        public static System.Int32 CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results) { }
        // RVA: 0x09E20CE4  token: 0x60000D2
        public static System.Int32 CapsuleCastNonAllocV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] results) { }
        // RVA: 0x02B32740  token: 0x60000D3
        public static System.Int32 SphereCastNonAlloc(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E25CA0  token: 0x60000D4
        public static System.Int32 SphereCastNonAlloc(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E25BE0  token: 0x60000D5
        public static System.Int32 SphereCastNonAlloc(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance) { }
        // RVA: 0x09E25D04  token: 0x60000D6
        public static System.Int32 SphereCastNonAlloc(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results) { }
        // RVA: 0x09E25C40  token: 0x60000D7
        public static System.Int32 SphereCastNonAlloc(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E25B68  token: 0x60000D8
        public static System.Int32 SphereCastNonAlloc(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E25BA4  token: 0x60000D9
        public static System.Int32 SphereCastNonAlloc(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit[] results, System.Single maxDistance) { }
        // RVA: 0x09E25B24  token: 0x60000DA
        public static System.Int32 SphereCastNonAlloc(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit[] results) { }
        // RVA: 0x04271A08  token: 0x60000DB
        private static System.Boolean CheckCapsule_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x027E6B50  token: 0x60000DC
        public static System.Boolean CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E218B0  token: 0x60000DD
        public static System.Boolean CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single radius, System.Int32 layerMask) { }
        // RVA: 0x09E218F8  token: 0x60000DE
        public static System.Boolean CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single radius) { }
        // RVA: 0x09E216D4  token: 0x60000DF
        private static System.Boolean CheckBox_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E217C8  token: 0x60000E0
        public static System.Boolean CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E2185C  token: 0x60000E1
        public static System.Boolean CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask) { }
        // RVA: 0x09E21704  token: 0x60000E2
        public static System.Boolean CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation) { }
        // RVA: 0x09E21760  token: 0x60000E3
        public static System.Boolean CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents) { }
        // RVA: 0x09E230A8  token: 0x60000E4
        private static UnityEngine.Collider[] OverlapBox_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E2325C  token: 0x60000E5
        public static UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E23340  token: 0x60000E6
        public static UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask) { }
        // RVA: 0x09E230D8  token: 0x60000E7
        public static UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation) { }
        // RVA: 0x09E2319C  token: 0x60000E8
        public static UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents) { }
        // RVA: 0x09E22A84  token: 0x60000E9
        public static System.Int32 OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E22B80  token: 0x60000EA
        public static System.Int32 OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, System.Int32 mask) { }
        // RVA: 0x09E22C5C  token: 0x60000EB
        public static System.Int32 OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation) { }
        // RVA: 0x09E22D34  token: 0x60000EC
        public static System.Int32 OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results) { }
        // RVA: 0x09E22E6C  token: 0x60000ED
        private static UnityEngine.ECSColliderResultProxy[] OverlapBoxV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E22FB0  token: 0x60000EE
        public static UnityEngine.ECSColliderResultProxy[] OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E22F5C  token: 0x60000EF
        public static UnityEngine.ECSColliderResultProxy[] OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask) { }
        // RVA: 0x09E22E9C  token: 0x60000F0
        public static UnityEngine.ECSColliderResultProxy[] OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation) { }
        // RVA: 0x09E22EF4  token: 0x60000F1
        public static UnityEngine.ECSColliderResultProxy[] OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents) { }
        // RVA: 0x09E229D4  token: 0x60000F2
        public static System.Int32 OverlapBoxNonAllocV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E2291C  token: 0x60000F3
        public static System.Int32 OverlapBoxNonAllocV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation, System.Int32 mask) { }
        // RVA: 0x09E2297C  token: 0x60000F4
        public static System.Int32 OverlapBoxNonAllocV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation) { }
        // RVA: 0x09E228B4  token: 0x60000F5
        public static System.Int32 OverlapBoxNonAllocV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results) { }
        // RVA: 0x02423710  token: 0x60000F6
        public static System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E20300  token: 0x60000F7
        public static System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation) { }
        // RVA: 0x09E20394  token: 0x60000F8
        public static System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, System.Single maxDistance) { }
        // RVA: 0x09E201D0  token: 0x60000F9
        public static System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E20268  token: 0x60000FA
        public static System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results) { }
        // RVA: 0x09E222E4  token: 0x60000FB
        private static UnityEngine.RaycastHit[] Internal_BoxCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1FE5C  token: 0x60000FC
        public static UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E200B4  token: 0x60000FD
        public static UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask) { }
        // RVA: 0x09E1FFA4  token: 0x60000FE
        public static UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance) { }
        // RVA: 0x09E2002C  token: 0x60000FF
        public static UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation) { }
        // RVA: 0x09E20140  token: 0x6000100
        public static UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction) { }
        // RVA: 0x09E23650  token: 0x6000101
        public static System.Int32 OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E234B0  token: 0x6000102
        public static System.Int32 OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask) { }
        // RVA: 0x09E23584  token: 0x6000103
        public static System.Int32 OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results) { }
        // RVA: 0x02B34920  token: 0x6000104
        public static System.Int32 OverlapCapsuleNonAllocV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E23460  token: 0x6000105
        public static System.Int32 OverlapCapsuleNonAllocV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask) { }
        // RVA: 0x09E23414  token: 0x6000106
        public static System.Int32 OverlapCapsuleNonAllocV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results) { }
        // RVA: 0x09E224DC  token: 0x6000107
        private static System.Void Internal_RebuildBroadphaseRegions(UnityEngine.Bounds bounds, System.Int32 subdivisions) { }
        // RVA: 0x09E256AC  token: 0x6000108
        public static System.Void RebuildBroadphaseRegions(UnityEngine.Bounds worldBounds, System.Int32 subdivisions) { }
        // RVA: 0x09E1FE1C  token: 0x6000109
        public static System.Void BakeMesh(System.Int32 meshID, System.Boolean convex) { }
        // RVA: 0x0350B670  token: 0x600011A
        public System.Void .ctor() { }
        // RVA: 0x0282FA80  token: 0x600011B
        private static System.Void get_gravity_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x09E268F4  token: 0x600011C
        private static System.Void set_gravity_Injected(UnityEngine.Vector3& value) { }
        // RVA: 0x027EDC90  token: 0x600011D
        private static System.Void get_defaultPhysicsScene_Injected(UnityEngine.PhysicsScene& ret) { }
        // RVA: 0x09E223C4  token: 0x600011E
        private static System.Void Internal_RaycastTestV2_Injected(UnityEngine.ECSColliderResultProxy& collider, UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }
        // RVA: 0x09E22338  token: 0x600011F
        private static UnityEngine.RaycastHit[] Internal_RaycastAll_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Ray& ray, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E242C4  token: 0x6000120
        private static UnityEngine.RaycastHit[] Query_CapsuleCastAll_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E24820  token: 0x6000121
        private static UnityEngine.RaycastHit[] Query_SphereCastAll_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& origin, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E238F4  token: 0x6000122
        private static UnityEngine.Collider[] OverlapCapsule_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E23740  token: 0x6000123
        private static UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E2404C  token: 0x6000124
        private static UnityEngine.Collider[] OverlapSphere_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E23EEC  token: 0x6000125
        private static UnityEngine.ECSColliderResultProxy[] OverlapSphereV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x02F50AD0  token: 0x6000126
        private static System.Void Simulate_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, System.Single step) { }
        // RVA: 0x09E246D4  token: 0x6000127
        private static System.Boolean Query_ComputePenetration_Injected(UnityEngine.Collider colliderA, UnityEngine.Vector3& positionA, UnityEngine.Quaternion& rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x02B2D850  token: 0x6000128
        private static System.Boolean Query_ComputePenetrationV2_Injected(UnityEngine.ECSColliderResultProxy& colliderA, UnityEngine.Vector3& positionA, UnityEngine.Quaternion& rotationA, UnityEngine.ECSColliderResultProxy& colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x09E24624  token: 0x6000129
        private static System.Boolean Query_ComputeCapsulePenetration_Injected(UnityEngine.Vector3& point1, UnityEngine.Vector3& point2, System.Single radius, UnityEngine.Collider colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x09E24574  token: 0x600012A
        private static System.Boolean Query_ComputeCapsulePenetrationV2_Injected(UnityEngine.Vector3& point1, UnityEngine.Vector3& point2, System.Single radius, UnityEngine.ECSColliderResultProxy& colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x09E24784  token: 0x600012B
        private static System.Boolean Query_ComputeSpherePenetrationV2_Injected(UnityEngine.Vector3& center, System.Single radius, UnityEngine.ECSColliderResultProxy& colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x09E244C4  token: 0x600012C
        private static System.Boolean Query_ComputeBoxPenetrationV2_Injected(UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtent, UnityEngine.Quaternion& rotationA, UnityEngine.ECSColliderResultProxy& colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }
        // RVA: 0x09E24420  token: 0x600012D
        private static System.Void Query_ClosestPoint_Injected(UnityEngine.Collider collider, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& point, UnityEngine.Vector3& ret) { }
        // RVA: 0x09E2437C  token: 0x600012E
        private static System.Void Query_ClosestPointV2_Injected(UnityEngine.ECSColliderResultProxy& colliderProxy, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& point, UnityEngine.Vector3& ret) { }
        // RVA: 0x09E248C4  token: 0x600012F
        private static System.Void Query_TryGetClosestPoint_Injected(UnityEngine.ECSColliderResultProxy& colliderProxy, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& point, System.Boolean& resultIsValid, UnityEngine.Vector3& ret) { }
        // RVA: 0x09E26330  token: 0x6000130
        private static System.Void get_clothGravity_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x09E26794  token: 0x6000131
        private static System.Void set_clothGravity_Injected(UnityEngine.Vector3& value) { }
        // RVA: 0x09E21944  token: 0x6000132
        private static System.Boolean CheckSphere_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x034F0100  token: 0x6000133
        private static System.Boolean CheckCapsule_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& start, UnityEngine.Vector3& end, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E21670  token: 0x6000134
        private static System.Boolean CheckBox_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Quaternion& orientation, System.Int32 layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E23044  token: 0x6000135
        private static UnityEngine.Collider[] OverlapBox_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Quaternion& orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E22E08  token: 0x6000136
        private static UnityEngine.ECSColliderResultProxy[] OverlapBoxV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Quaternion& orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E22280  token: 0x6000137
        private static UnityEngine.RaycastHit[] Internal_BoxCastAll_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Vector3& direction, UnityEngine.Quaternion& orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E2249C  token: 0x6000138
        private static System.Void Internal_RebuildBroadphaseRegions_Injected(UnityEngine.Bounds& bounds, System.Int32 subdivisions) { }

    }

    // TypeToken: 0x200000F  // size: 0x78
    public sealed struct ModifiableContactPair
    {
        // Fields
        private System.IntPtr actor;  // 0x10
        private System.IntPtr otherActor;  // 0x18
        private System.IntPtr shape;  // 0x20
        private System.IntPtr otherShape;  // 0x28
        public UnityEngine.Quaternion rotation;  // 0x30
        public UnityEngine.Vector3 position;  // 0x40
        public UnityEngine.Quaternion otherRotation;  // 0x4c
        public UnityEngine.Vector3 otherPosition;  // 0x5c
        private System.Int32 numContacts;  // 0x68
        private System.IntPtr contacts;  // 0x70

    }

    // TypeToken: 0x2000010  // size: 0x18
    public class PhysicMaterial : UnityEngine.Object
    {
        // Methods
        // RVA: 0x09E1EDC4  token: 0x6000139
        public System.Void .ctor() { }
        // RVA: 0x09E1ED80  token: 0x600013A
        private static System.Void Internal_CreateDynamicsMaterial(UnityEngine.PhysicMaterial mat, System.String name) { }

    }

    // TypeToken: 0x2000011  // size: 0x28
    public sealed struct ECSColliderResultProxy : System.IEquatable`1
    {
        // Fields
        private System.IntPtr m_Actor;  // 0x10
        private System.Int32 m_EcsId;  // 0x18
        private System.UInt32 m_EcsVersion;  // 0x1c
        private System.Int32 m_Collider;  // 0x20
        private System.Int32 m_ComponentIndex;  // 0x24
        private static readonly UnityEngine.ECSColliderResultProxy INVALID_PROXY;  // static @ 0x0

        // Properties
        System.Int32 componentIndex { get; /* RVA: 0x03D4FB00 */ }
        UnityEngine.HyperGryph.ECS.Entity colliderEntity { get; /* RVA: 0x038A92F0 */ }
        System.Int32 ecsId { get; /* RVA: 0x03D68070 */ }
        System.UInt32 ecsVersion { get; /* RVA: 0x03D682F0 */ }
        UnityEngine.ECSColliderResultProxy invalid { get; /* RVA: 0x09E1D3FC */ }
        UnityEngine.Collider collider { get; /* RVA: 0x027EBAB0 */ }
        System.Int32 colliderInstanceId { get; /* RVA: 0x03D85B00 */ }
        System.Boolean bIsECS { get; /* RVA: 0x027EC5F0 */ }
        System.Int32 tagConfig { get; /* RVA: 0x02351D80 */ }
        System.Boolean isTrigger { get; /* RVA: 0x09E1D460 */ }
        System.Int32 layer { get; /* RVA: 0x02B334B0 */ }
        UnityEngine.Transform transform { get; /* RVA: 0x02B34130 */ }
        UnityEngine.Vector3 transformPosition { get; /* RVA: 0x02B2EB30 */ }
        UnityEngine.Quaternion transformRotation { get; /* RVA: 0x02B2ECA0 */ }
        UnityEngine.Vector3 transformLossyScale { get; /* RVA: 0x09E1D580 */ }
        UnityEngine.Vector3 shapePosition { get; /* RVA: 0x0301EFB0 */ }
        UnityEngine.Bounds bounds { get; /* RVA: 0x03271780 */ }
        System.Int32 colliderOptions { get; /* RVA: 0x027EC8B0 */ }
        UnityEngine.ColliderSurfaceType surfaceType { get; /* RVA: 0x02FA3070 */ }
        UnityEngine.ECSColliderType colliderType { get; /* RVA: 0x09E1D2A0 */ }
        UnityEngine.GameObject gameObject { get; /* RVA: 0x02B2FBB0 */ }
        System.Boolean hasComplexMesh { get; /* RVA: 0x027EAB90 */ }

        // Methods
        // RVA: 0x027EBDA0  token: 0x600013B
        public System.Void SetColliderAndSetIndex(System.Int32 colliderInstanceID) { }
        // RVA: 0x03D595B0  token: 0x600013C
        public System.Void SetComponentIndex(System.Int32 index) { }
        // RVA: 0x03D51730  token: 0x600013D
        public System.Void SetActor(System.IntPtr actor) { }
        // RVA: 0x03D51710  token: 0x600013E
        public System.Void SetEcsId(System.Int32 id) { }
        // RVA: 0x03D55690  token: 0x600013F
        public System.Void SetEcsVersion(System.UInt32 version) { }
        // RVA: 0x027EC610  token: 0x6000149
        public System.Boolean IsValid() { }
        // RVA: 0x09E1CF68  token: 0x6000154
        public System.String GetColliderGoName() { }
        // RVA: 0x027E5B60  token: 0x6000157
        public System.Int32 GetFactoryBuildingIdentifier() { }
        // RVA: 0x09E1D188  token: 0x6000159
        public System.Boolean TryGetClosestPoint(UnityEngine.Vector3 point, UnityEngine.Vector3& result) { }
        // RVA: 0x09E1CC14  token: 0x600015A
        public UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 position) { }
        // RVA: 0x09E1D028  token: 0x600015B
        public System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance) { }
        // RVA: 0x09E1D688  token: 0x600015C
        public static System.Boolean op_Equality(UnityEngine.ECSColliderResultProxy left, UnityEngine.ECSColliderResultProxy right) { }
        // RVA: 0x0240A950  token: 0x600015D
        public static System.Boolean op_Inequality(UnityEngine.ECSColliderResultProxy left, UnityEngine.ECSColliderResultProxy right) { }
        // RVA: 0x0354DDA0  token: 0x600015E
        public virtual System.Boolean Equals(UnityEngine.ECSColliderResultProxy other) { }
        // RVA: 0x09E1CEC4  token: 0x600015F
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x033018D0  token: 0x6000160
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09E1CD60  token: 0x6000161
        public System.Boolean CompareTag(System.Int32 tagValue) { }
        // RVA: 0x02B34330  token: 0x6000162
        public System.Boolean IsSameCollider(UnityEngine.Collider otherCollider) { }
        // RVA: 0x03D2D040  token: 0x6000163
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000012  // size: 0x50
    public sealed struct RaycastHit
    {
        // Fields
        private UnityEngine.Vector3 m_Point;  // 0x10
        private UnityEngine.Vector3 m_Normal;  // 0x1c
        private System.UInt32 m_FaceID;  // 0x28
        private System.Single m_Distance;  // 0x2c
        private UnityEngine.Vector2 m_UV;  // 0x30
        private System.Int32 m_Collider;  // 0x38
        private System.Int32 m_Index;  // 0x3c
        private System.Int32 m_EcsId;  // 0x40
        private System.UInt32 m_EcsVersion;  // 0x44
        private System.IntPtr m_Actor;  // 0x48

        // Properties
        System.Int32 ecsId { get; /* RVA: 0x03D85A80 */ }
        System.UInt32 ecsVersion { get; /* RVA: 0x03D85A10 */ }
        System.Boolean IsECSCollider { get; /* RVA: 0x027E5B40 */ }
        UnityEngine.Collider collider { get; /* RVA: 0x032E3150 */ }
        System.Int32 colliderInstanceID { get; /* RVA: 0x03D86D30 */ }
        UnityEngine.Collider editorCollider { get; /* RVA: 0x09E26C3C */ }
        UnityEngine.ECSColliderResultProxy colliderProxy { get; /* RVA: 0x027EBB50 */ }
        UnityEngine.Vector3 point { get; /* RVA: 0x03D85920 */ set; /* RVA: 0x03D56570 */ }
        UnityEngine.Vector3 normal { get; /* RVA: 0x03D85900 */ set; /* RVA: 0x03D56580 */ }
        UnityEngine.Vector3 barycentricCoordinate { get; /* RVA: 0x03D87FE0 */ set; /* RVA: 0x09E271E8 */ }
        System.Single distance { get; /* RVA: 0x03D87EB0 */ set; /* RVA: 0x03D4F120 */ }
        System.Int32 triangleIndex { get; /* RVA: 0x03D68AE0 */ }
        System.Int32 componentIndex { get; /* RVA: 0x03D88010 */ }
        UnityEngine.Vector2 textureCoord { get; /* RVA: 0x09E270C8 */ }
        UnityEngine.Vector2 textureCoord2 { get; /* RVA: 0x09E27068 */ }
        UnityEngine.Transform transform { get; /* RVA: 0x09E27124 */ }
        UnityEngine.Vector3 shapePosition { get; /* RVA: 0x09E26FE0 */ }
        UnityEngine.Quaternion shapeRotation { get; /* RVA: 0x09E27020 */ }
        UnityEngine.Vector3 position { get; /* RVA: 0x09E26E38 */ }
        UnityEngine.Quaternion rotation { get; /* RVA: 0x09E26EFC */ }
        UnityEngine.Vector3 scale { get; /* RVA: 0x09E26F28 */ }
        UnityEngine.Rigidbody rigidbody { get; /* RVA: 0x09E26E6C */ }
        UnityEngine.ArticulationBody articulationBody { get; /* RVA: 0x09E26BAC */ }
        UnityEngine.Vector2 lightmapCoord { get; /* RVA: 0x09E26CCC */ }
        UnityEngine.Vector2 textureCoord1 { get; /* RVA: 0x09E27058 */ }

        // Methods
        // RVA: 0x09E26B60  token: 0x6000175
        private static UnityEngine.Vector2 CalculateRaycastTexCoord(UnityEngine.Collider collider, System.Int32 m_Index, UnityEngine.Vector2 uv, UnityEngine.Vector3 pos, System.UInt32 face, System.Int32 textcoord) { }
        // RVA: 0x09E26B00  token: 0x6000182
        private static System.Void CalculateRaycastTexCoord_Injected(UnityEngine.Collider collider, System.Int32 m_Index, UnityEngine.Vector2& uv, UnityEngine.Vector3& pos, System.UInt32 face, System.Int32 textcoord, UnityEngine.Vector2& ret) { }

    }

    // TypeToken: 0x2000013  // size: 0x18
    public class Rigidbody : UnityEngine.Component
    {
        // Properties
        UnityEngine.Vector3 velocity { get; /* RVA: 0x0282DAF0 */ set; /* RVA: 0x09E28A68 */ }
        UnityEngine.Vector3 angularVelocity { get; /* RVA: 0x0282CFE0 */ set; /* RVA: 0x09E28540 */ }
        System.Single drag { get; /* RVA: 0x0282DB70 */ set; /* RVA: 0x09E28670 */ }
        System.Single angularDrag { get; /* RVA: 0x09E27F28 */ set; /* RVA: 0x09E284B8 */ }
        System.Single mass { get; /* RVA: 0x09E281E4 */ set; /* RVA: 0x09E287E8 */ }
        System.Boolean useGravity { get; /* RVA: 0x09E28414 */ set; /* RVA: 0x09E289E0 */ }
        System.Single maxDepenetrationVelocity { get; /* RVA: 0x09E2824C */ set; /* RVA: 0x09E28870 */ }
        System.Boolean isKinematic { get; /* RVA: 0x09E281B0 */ set; /* RVA: 0x0282CDF0 */ }
        System.Boolean freezeRotation { get; /* RVA: 0x09E28068 */ set; /* RVA: 0x09E286B4 */ }
        UnityEngine.RigidbodyConstraints constraints { get; /* RVA: 0x09E28000 */ set; /* RVA: 0x09E285EC */ }
        UnityEngine.CollisionDetectionMode collisionDetectionMode { get; /* RVA: 0x09E27FCC */ set; /* RVA: 0x09E285AC */ }
        UnityEngine.Vector3 centerOfMass { get; /* RVA: 0x09E27FA0 */ set; /* RVA: 0x09E28598 */ }
        UnityEngine.Vector3 worldCenterOfMass { get; /* RVA: 0x09E2848C */ }
        UnityEngine.Quaternion inertiaTensorRotation { get; /* RVA: 0x09E280E0 */ set; /* RVA: 0x09E2873C */ }
        UnityEngine.Vector3 inertiaTensor { get; /* RVA: 0x09E28150 */ set; /* RVA: 0x09E28794 */ }
        System.Boolean detectCollisions { get; /* RVA: 0x09E28034 */ set; /* RVA: 0x09E2862C */ }
        UnityEngine.Vector3 position { get; /* RVA: 0x09E282C4 */ set; /* RVA: 0x04273A90 */ }
        UnityEngine.Quaternion rotation { get; /* RVA: 0x09E28334 */ set; /* RVA: 0x09E288F8 */ }
        UnityEngine.RigidbodyInterpolation interpolation { get; /* RVA: 0x09E2817C */ set; /* RVA: 0x09E287A8 */ }
        System.Int32 solverIterations { get; /* RVA: 0x09E283A0 */ set; /* RVA: 0x09E28958 */ }
        System.Single sleepThreshold { get; /* RVA: 0x09E28360 */ set; /* RVA: 0x09E2890C */ }
        System.Single maxAngularVelocity { get; /* RVA: 0x09E28218 */ set; /* RVA: 0x09E2882C */ }
        System.Int32 solverVelocityIterations { get; /* RVA: 0x09E283E0 */ set; /* RVA: 0x09E289A0 */ }
        System.Single sleepVelocity { get; /* RVA: 0x03D85FA0 */ set; /* RVA: 0x0350B670 */ }
        System.Single sleepAngularVelocity { get; /* RVA: 0x03D85FA0 */ set; /* RVA: 0x0350B670 */ }
        System.Boolean useConeFriction { get; /* RVA: 0x03D4E3A0 */ set; /* RVA: 0x0350B670 */ }
        System.Int32 solverIterationCount { get; /* RVA: 0x09E28394 */ set; /* RVA: 0x09E28950 */ }
        System.Int32 solverVelocityIterationCount { get; /* RVA: 0x09E283D4 */ set; /* RVA: 0x09E28998 */ }

        // Methods
        // RVA: 0x09E27B14  token: 0x600018D
        public System.Void SetDensity(System.Single density) { }
        // RVA: 0x09E27A40  token: 0x60001AF
        public System.Void MovePosition(UnityEngine.Vector3 position) { }
        // RVA: 0x09E27A98  token: 0x60001B0
        public System.Void MoveRotation(UnityEngine.Quaternion rot) { }
        // RVA: 0x09E27B60  token: 0x60001B1
        public System.Void Sleep() { }
        // RVA: 0x0282D4D0  token: 0x60001B2
        public System.Boolean IsSleeping() { }
        // RVA: 0x09E27EF4  token: 0x60001B3
        public System.Void WakeUp() { }
        // RVA: 0x09E27AAC  token: 0x60001B4
        public System.Void ResetCenterOfMass() { }
        // RVA: 0x09E27AE0  token: 0x60001B5
        public System.Void ResetInertiaTensor() { }
        // RVA: 0x09E278D0  token: 0x60001B6
        public UnityEngine.Vector3 GetRelativePointVelocity(UnityEngine.Vector3 relativePoint) { }
        // RVA: 0x09E27848  token: 0x60001B7
        public UnityEngine.Vector3 GetPointVelocity(UnityEngine.Vector3 worldPoint) { }
        // RVA: 0x09E27484  token: 0x60001BA
        public System.Void AddForce(UnityEngine.Vector3 force, UnityEngine.ForceMode mode) { }
        // RVA: 0x09E27458  token: 0x60001BB
        public System.Void AddForce(UnityEngine.Vector3 force) { }
        // RVA: 0x09E2742C  token: 0x60001BC
        public System.Void AddForce(System.Single x, System.Single y, System.Single z, UnityEngine.ForceMode mode) { }
        // RVA: 0x09E27498  token: 0x60001BD
        public System.Void AddForce(System.Single x, System.Single y, System.Single z) { }
        // RVA: 0x09E27568  token: 0x60001BE
        public System.Void AddRelativeForce(UnityEngine.Vector3 force, UnityEngine.ForceMode mode) { }
        // RVA: 0x09E27514  token: 0x60001BF
        public System.Void AddRelativeForce(UnityEngine.Vector3 force) { }
        // RVA: 0x09E2757C  token: 0x60001C0
        public System.Void AddRelativeForce(System.Single x, System.Single y, System.Single z, UnityEngine.ForceMode mode) { }
        // RVA: 0x09E27540  token: 0x60001C1
        public System.Void AddRelativeForce(System.Single x, System.Single y, System.Single z) { }
        // RVA: 0x09E27704  token: 0x60001C2
        public System.Void AddTorque(UnityEngine.Vector3 torque, UnityEngine.ForceMode mode) { }
        // RVA: 0x09E276D8  token: 0x60001C3
        public System.Void AddTorque(UnityEngine.Vector3 torque) { }
        // RVA: 0x09E27740  token: 0x60001C4
        public System.Void AddTorque(System.Single x, System.Single y, System.Single z, UnityEngine.ForceMode mode) { }
        // RVA: 0x09E27718  token: 0x60001C5
        public System.Void AddTorque(System.Single x, System.Single y, System.Single z) { }
        // RVA: 0x09E27654  token: 0x60001C6
        public System.Void AddRelativeTorque(UnityEngine.Vector3 torque, UnityEngine.ForceMode mode) { }
        // RVA: 0x09E27628  token: 0x60001C7
        public System.Void AddRelativeTorque(UnityEngine.Vector3 torque) { }
        // RVA: 0x09E275FC  token: 0x60001C8
        public System.Void AddRelativeTorque(System.Single x, System.Single y, System.Single z, UnityEngine.ForceMode mode) { }
        // RVA: 0x09E27668  token: 0x60001C9
        public System.Void AddRelativeTorque(System.Single x, System.Single y, System.Single z) { }
        // RVA: 0x09E27378  token: 0x60001CA
        public System.Void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position, UnityEngine.ForceMode mode) { }
        // RVA: 0x09E27390  token: 0x60001CB
        public System.Void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position) { }
        // RVA: 0x09E272E8  token: 0x60001CC
        public System.Void AddExplosionForce(System.Single explosionForce, UnityEngine.Vector3 explosionPosition, System.Single explosionRadius, System.Single upwardsModifier, UnityEngine.ForceMode mode) { }
        // RVA: 0x09E272A8  token: 0x60001CD
        public System.Void AddExplosionForce(System.Single explosionForce, UnityEngine.Vector3 explosionPosition, System.Single explosionRadius, System.Single upwardsModifier) { }
        // RVA: 0x09E2726C  token: 0x60001CE
        public System.Void AddExplosionForce(System.Single explosionForce, UnityEngine.Vector3 explosionPosition, System.Single explosionRadius) { }
        // RVA: 0x09E27968  token: 0x60001CF
        private System.Void Internal_ClosestPointOnBounds(UnityEngine.Vector3 point, UnityEngine.Vector3& outPos, System.Single& distance) { }
        // RVA: 0x09E2776C  token: 0x60001D0
        public UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Vector3 position) { }
        // RVA: 0x09E27D54  token: 0x60001D1
        private UnityEngine.RaycastHit SweepTest(UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.Boolean& hasHit) { }
        // RVA: 0x09E27E00  token: 0x60001D2
        public System.Boolean SweepTest(UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E27D24  token: 0x60001D3
        public System.Boolean SweepTest(UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance) { }
        // RVA: 0x09E27DC8  token: 0x60001D4
        public System.Boolean SweepTest(UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo) { }
        // RVA: 0x09E279E4  token: 0x60001D5
        private UnityEngine.RaycastHit[] Internal_SweepTestAll(UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E27BC4  token: 0x60001D6
        public UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E27B94  token: 0x60001D7
        public UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction, System.Single maxDistance) { }
        // RVA: 0x09E27C88  token: 0x60001D8
        public UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction) { }
        // RVA: 0x09E27B58  token: 0x60001DD
        public System.Void SetMaxAngularVelocity(System.Single a) { }
        // RVA: 0x0426FE60  token: 0x60001E4
        public System.Void .ctor() { }
        // RVA: 0x0282DB20  token: 0x60001E5
        private System.Void get_velocity_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x09E28A24  token: 0x60001E6
        private System.Void set_velocity_Injected(UnityEngine.Vector3& value) { }
        // RVA: 0x0282CDA0  token: 0x60001E7
        private System.Void get_angularVelocity_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x09E284FC  token: 0x60001E8
        private System.Void set_angularVelocity_Injected(UnityEngine.Vector3& value) { }
        // RVA: 0x09E27F5C  token: 0x60001E9
        private System.Void get_centerOfMass_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x09E28554  token: 0x60001EA
        private System.Void set_centerOfMass_Injected(UnityEngine.Vector3& value) { }
        // RVA: 0x09E28448  token: 0x60001EB
        private System.Void get_worldCenterOfMass_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x09E2809C  token: 0x60001EC
        private System.Void get_inertiaTensorRotation_Injected(UnityEngine.Quaternion& ret) { }
        // RVA: 0x09E286F8  token: 0x60001ED
        private System.Void set_inertiaTensorRotation_Injected(UnityEngine.Quaternion& value) { }
        // RVA: 0x09E2810C  token: 0x60001EE
        private System.Void get_inertiaTensor_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x09E28750  token: 0x60001EF
        private System.Void set_inertiaTensor_Injected(UnityEngine.Vector3& value) { }
        // RVA: 0x09E28280  token: 0x60001F0
        private System.Void get_position_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x034E5160  token: 0x60001F1
        private System.Void set_position_Injected(UnityEngine.Vector3& value) { }
        // RVA: 0x09E282F0  token: 0x60001F2
        private System.Void get_rotation_Injected(UnityEngine.Quaternion& ret) { }
        // RVA: 0x09E288B4  token: 0x60001F3
        private System.Void set_rotation_Injected(UnityEngine.Quaternion& value) { }
        // RVA: 0x09E279FC  token: 0x60001F4
        private System.Void MovePosition_Injected(UnityEngine.Vector3& position) { }
        // RVA: 0x09E27A54  token: 0x60001F5
        private System.Void MoveRotation_Injected(UnityEngine.Quaternion& rot) { }
        // RVA: 0x09E2787C  token: 0x60001F6
        private System.Void GetRelativePointVelocity_Injected(UnityEngine.Vector3& relativePoint, UnityEngine.Vector3& ret) { }
        // RVA: 0x09E277F4  token: 0x60001F7
        private System.Void GetPointVelocity_Injected(UnityEngine.Vector3& worldPoint, UnityEngine.Vector3& ret) { }
        // RVA: 0x09E273D8  token: 0x60001F8
        private System.Void AddForce_Injected(UnityEngine.Vector3& force, UnityEngine.ForceMode mode) { }
        // RVA: 0x09E274C0  token: 0x60001F9
        private System.Void AddRelativeForce_Injected(UnityEngine.Vector3& force, UnityEngine.ForceMode mode) { }
        // RVA: 0x09E27684  token: 0x60001FA
        private System.Void AddTorque_Injected(UnityEngine.Vector3& torque, UnityEngine.ForceMode mode) { }
        // RVA: 0x09E275A8  token: 0x60001FB
        private System.Void AddRelativeTorque_Injected(UnityEngine.Vector3& torque, UnityEngine.ForceMode mode) { }
        // RVA: 0x09E27314  token: 0x60001FC
        private System.Void AddForceAtPosition_Injected(UnityEngine.Vector3& force, UnityEngine.Vector3& position, UnityEngine.ForceMode mode) { }
        // RVA: 0x09E27208  token: 0x60001FD
        private System.Void AddExplosionForce_Injected(System.Single explosionForce, UnityEngine.Vector3& explosionPosition, System.Single explosionRadius, System.Single upwardsModifier, UnityEngine.ForceMode mode) { }
        // RVA: 0x09E27904  token: 0x60001FE
        private System.Void Internal_ClosestPointOnBounds_Injected(UnityEngine.Vector3& point, UnityEngine.Vector3& outPos, System.Single& distance) { }
        // RVA: 0x09E27CC0  token: 0x60001FF
        private System.Void SweepTest_Injected(UnityEngine.Vector3& direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }
        // RVA: 0x09E27980  token: 0x6000200
        private UnityEngine.RaycastHit[] Internal_SweepTestAll_Injected(UnityEngine.Vector3& direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }

    }

    // TypeToken: 0x2000014  // size: 0x14
    public sealed struct ECSColliderType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static UnityEngine.ECSColliderType Default;  // const
        public static UnityEngine.ECSColliderType BoxCollider;  // const
        public static UnityEngine.ECSColliderType CapsuleCollider;  // const
        public static UnityEngine.ECSColliderType SphereCollider;  // const
        public static UnityEngine.ECSColliderType MeshCollider;  // const
        public static UnityEngine.ECSColliderType MultiCollider;  // const
        public static UnityEngine.ECSColliderType TerrainCollider;  // const
        public static UnityEngine.ECSColliderType ECSCollider;  // const
        public static UnityEngine.ECSColliderType Invalid;  // const

    }

    // TypeToken: 0x2000015  // size: 0x18
    public class Collider : UnityEngine.Component
    {
        // Properties
        System.Boolean enabled { get; /* RVA: 0x02B2EE10 */ set; /* RVA: 0x02833E20 */ }
        UnityEngine.Rigidbody attachedRigidbody { get; /* RVA: 0x09E1C658 */ }
        UnityEngine.ArticulationBody attachedArticulationBody { get; /* RVA: 0x09E1C624 */ }
        System.Boolean isTrigger { get; /* RVA: 0x0282CBA0 */ set; /* RVA: 0x02B94E10 */ }
        System.Boolean enableDither { get; /* RVA: 0x09E1C734 */ }
        System.Single contactOffset { get; /* RVA: 0x09E1C700 */ set; /* RVA: 0x09E1C86C */ }
        UnityEngine.Bounds bounds { get; /* RVA: 0x09E1C6D0 */ }
        System.Boolean hasModifiableContacts { get; /* RVA: 0x09E1C768 */ set; /* RVA: 0x09E1C8B0 */ }
        UnityEngine.ColliderSurfaceType surfaceType { get; /* RVA: 0x09E1C804 */ set; /* RVA: 0x09E1C938 */ }
        System.Int32 tagConfig { get; /* RVA: 0x09E1C838 */ set; /* RVA: 0x09E1C978 */ }
        System.Int32 colliderOptions { get; /* RVA: 0x02B93D40 */ set; /* RVA: 0x02B952A0 */ }
        UnityEngine.PhysicMaterial sharedMaterial { get; /* RVA: 0x09E1C7D0 */ set; /* RVA: 0x09E1C8F4 */ }
        UnityEngine.PhysicMaterial material { get; /* RVA: 0x09E1C79C */ set; /* RVA: 0x02B40D20 */ }

        // Methods
        // RVA: 0x09E1C2D0  token: 0x600020A
        public UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 position) { }
        // RVA: 0x0270A950  token: 0x6000214
        public System.IntPtr GetActor() { }
        // RVA: 0x03300880  token: 0x6000215
        public System.Int32 GetComponentIndex() { }
        // RVA: 0x09E1C304  token: 0x6000216
        public System.Int32 GetFactoryBuildingIdentifier() { }
        // RVA: 0x09E1C4F0  token: 0x6000217
        public System.Void SetFactoryBuildingIdentifier(System.Int32 value) { }
        // RVA: 0x09E1C418  token: 0x600021C
        private UnityEngine.RaycastHit Raycast(UnityEngine.Ray ray, System.Single maxDistance, System.Boolean& hasHit) { }
        // RVA: 0x09E1C47C  token: 0x600021D
        public System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance) { }
        // RVA: 0x09E1C39C  token: 0x600021E
        private System.Void Internal_ClosestPointOnBounds(UnityEngine.Vector3 point, UnityEngine.Vector3& outPos, System.Single& distance) { }
        // RVA: 0x09E1C1F4  token: 0x600021F
        public UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Vector3 position) { }
        // RVA: 0x09E1C1C0  token: 0x6000220
        public System.Boolean CanColliderComputeClosestPoint() { }
        // RVA: 0x09E1C594  token: 0x6000221
        private UnityEngine.Vector3 TryGetClosestPoint_Internal(UnityEngine.Vector3 point, System.Boolean& resultIsValid) { }
        // RVA: 0x09E1C5D0  token: 0x6000222
        public System.Boolean TryGetClosestPoint(UnityEngine.Vector3 point, UnityEngine.Vector3& result) { }
        // RVA: 0x0426FE60  token: 0x6000223
        public System.Void .ctor() { }
        // RVA: 0x09E1C27C  token: 0x6000224
        private System.Void ClosestPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Vector3& ret) { }
        // RVA: 0x09E1C68C  token: 0x6000225
        private System.Void get_bounds_Injected(UnityEngine.Bounds& ret) { }
        // RVA: 0x09E1C3B4  token: 0x6000226
        private System.Void Raycast_Injected(UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }
        // RVA: 0x09E1C338  token: 0x6000227
        private System.Void Internal_ClosestPointOnBounds_Injected(UnityEngine.Vector3& point, UnityEngine.Vector3& outPos, System.Single& distance) { }
        // RVA: 0x09E1C530  token: 0x6000228
        private System.Void TryGetClosestPoint_Internal_Injected(UnityEngine.Vector3& point, System.Boolean& resultIsValid, UnityEngine.Vector3& ret) { }

    }

    // TypeToken: 0x2000016  // size: 0x18
    public class ECSCollider
    {
        // Fields
        private System.IntPtr self;  // 0x10
        public static UnityEngine.ECSCollider.CollisionCallback collisionEnterCallback;  // static @ 0x0
        public static UnityEngine.ECSCollider.CollisionCallback collisionStayCallback;  // static @ 0x8
        public static UnityEngine.ECSCollider.CollisionCallback collisionExitCallback;  // static @ 0x10
        public static UnityEngine.ECSCollider.CollisionCallback triggerEnterCallback;  // static @ 0x18
        public static UnityEngine.ECSCollider.CollisionCallback triggerStayCallback;  // static @ 0x20
        public static UnityEngine.ECSCollider.CollisionCallback triggerExitCallback;  // static @ 0x28

        // Methods
        // RVA: 0x09E1DB24  token: 0x6000229
        public static System.IntPtr CreateActor(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.UInt32 layer, System.Int32 tagInt, System.Boolean movable) { }
        // RVA: 0x09E1DB44  token: 0x600022A
        public static System.Void DestroyActor(System.Int32 id, System.UInt32 version) { }
        // RVA: 0x02769F70  token: 0x600022B
        public static System.IntPtr Decode(System.IntPtr data, System.Int32 length, System.IntPtr meshes, System.Int32 meshesCount, UnityEngine.Texture2D heightmaps) { }
        // RVA: 0x02769ED0  token: 0x600022C
        public static System.IntPtr Decode(System.IntPtr data, System.Int32 length, Unity.Collections.NativeArray<System.Int32> meshInstanceIds, UnityEngine.Texture2D heightmap) { }
        // RVA: 0x09E1E290  token: 0x600022D
        public static System.Void RecordEntity(System.IntPtr actor, UnityEngine.HyperGryph.ECS.Entity entity) { }
        // RVA: 0x0276A110  token: 0x600022E
        public static System.Int32 GetId(System.IntPtr actor) { }
        // RVA: 0x0276A150  token: 0x600022F
        public static System.UInt32 GetVersion(System.IntPtr actor) { }
        // RVA: 0x027EC850  token: 0x6000230
        public static System.Boolean IsValid(System.Int32 id, System.UInt32 version, System.IntPtr actor) { }
        // RVA: 0x038A9300  token: 0x6000231
        public static UnityEngine.HyperGryph.ECS.Entity GetEntity(System.Int32 id, System.UInt32 version) { }
        // RVA: 0x02B2E180  token: 0x6000232
        public static UnityEngine.Vector3 GetPosition(System.Int32 ecsId, System.UInt32 ecsVersion) { }
        // RVA: 0x0301F140  token: 0x6000233
        public static UnityEngine.Vector3 GetShapePosition(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index) { }
        // RVA: 0x04272040  token: 0x6000234
        public static System.Void SetPosition(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 position) { }
        // RVA: 0x09E1DC34  token: 0x6000235
        public static UnityEngine.Quaternion GetShapeRotation(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index) { }
        // RVA: 0x02B2E150  token: 0x6000236
        public static UnityEngine.Quaternion GetRotation(System.Int32 ecsId, System.UInt32 ecsVersion) { }
        // RVA: 0x04272054  token: 0x6000237
        public static System.Void SetRotation(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Quaternion rotation) { }
        // RVA: 0x09E1D778  token: 0x6000238
        public static System.Void AttachBox(System.Int32 id, System.UInt32 version, UnityEngine.Vector3 halfExtent, UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotation, System.Int32 surfaceType, System.Int32 colliderOption, System.Int32 tag, System.Boolean isTrigger, System.Boolean isPrimitive) { }
        // RVA: 0x027EAC40  token: 0x6000239
        public static System.Boolean HasComplexMesh(System.Int32 id, System.UInt32 version) { }
        // RVA: 0x09E1E190  token: 0x600023A
        private static UnityEngine.RaycastHit Raycast_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit) { }
        // RVA: 0x09E1E204  token: 0x600023B
        public static System.Boolean Raycast(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, UnityEngine.RaycastHit& hitInfo) { }
        // RVA: 0x09E1E030  token: 0x600023C
        private static UnityEngine.RaycastHit RaycastComplexMesh_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit) { }
        // RVA: 0x09E1E0A4  token: 0x600023D
        public static System.Boolean RaycastComplexMesh(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, UnityEngine.RaycastHit& hitInfo) { }
        // RVA: 0x09E1D878  token: 0x600023E
        private static UnityEngine.RaycastHit CapsuleCastComplexMesh_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Boolean& hasHit) { }
        // RVA: 0x09E1D914  token: 0x600023F
        public static System.Boolean CapsuleCastComplexMesh(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo) { }
        // RVA: 0x09E1E30C  token: 0x6000240
        private static UnityEngine.RaycastHit SphereCastComplexMesh_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 center, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Boolean& hasHit) { }
        // RVA: 0x09E1E398  token: 0x6000241
        public static System.Boolean SphereCastComplexMesh(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 center, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo) { }
        // RVA: 0x09E1D7D8  token: 0x6000242
        public static System.Boolean CanColliderComputeClosestPoint(System.Int32 ecsId, System.UInt32 ecsVersion) { }
        // RVA: 0x02FA3100  token: 0x6000243
        public static UnityEngine.ColliderSurfaceType GetSurfaceTypeAt(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index) { }
        // RVA: 0x027ECA20  token: 0x6000244
        public static System.Int32 GetColliderOptionAt(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index) { }
        // RVA: 0x02351E50  token: 0x6000245
        public static System.Int32 GetTagConfigAt(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index) { }
        // RVA: 0x09E1DB84  token: 0x6000246
        public static System.Boolean GetIsTrigger(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index) { }
        // RVA: 0x03271870  token: 0x6000247
        public static UnityEngine.Bounds GetBounds(System.Int32 ecsId, System.UInt32 ecsVersion) { }
        // RVA: 0x09E1E4A8  token: 0x6000248
        private static UnityEngine.Vector3 TryGetClosestPoint_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 point, System.Boolean& resultIsValid) { }
        // RVA: 0x09E1E4E8  token: 0x6000249
        public static System.Boolean TryGetClosestPoint(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 point, UnityEngine.Vector3& result) { }
        // RVA: 0x09E1DA34  token: 0x600024A
        public static UnityEngine.Vector3 ClosestPoint(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 position) { }
        // RVA: 0x09E1DA70  token: 0x600024B
        public static System.Boolean CompareTag(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 tagValue) { }
        // RVA: 0x02B335F0  token: 0x600024C
        public static System.Int32 GetLayer(System.Int32 ecsId, System.UInt32 ecsVersion) { }
        // RVA: 0x027E5BE0  token: 0x600024D
        public static System.Int32 GetFactoryBuildingIdentifier(System.Int32 ecsId, System.UInt32 ecsVersion) { }
        // RVA: 0x032F4ED0  token: 0x600024E
        public static System.Void SetFactoryBuildingIdentifier(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 identifier) { }
        // RVA: 0x09E1DC70  token: 0x600024F
        private static System.Void OnCollisionEnterV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider) { }
        // RVA: 0x09E1DD90  token: 0x6000250
        private static System.Void OnCollisionStayV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider) { }
        // RVA: 0x09E1DD00  token: 0x6000251
        private static System.Void OnCollisionExitV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider) { }
        // RVA: 0x09E1DE20  token: 0x6000252
        private static System.Void OnTriggerEnterV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider) { }
        // RVA: 0x09E1DF40  token: 0x6000253
        private static System.Void OnTriggerStayV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider) { }
        // RVA: 0x09E1DEB0  token: 0x6000254
        private static System.Void OnTriggerExitV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider) { }
        // RVA: 0x0294A580  token: 0x6000255
        public static System.Void ToggleCollision(System.Int32 id, System.UInt32 version, System.Boolean enableCollision) { }
        // RVA: 0x09E1DAC0  token: 0x6000256
        private static System.IntPtr CreateActor_Injected(UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, System.UInt32 layer, System.Int32 tagInt, System.Boolean movable) { }
        // RVA: 0x03334210  token: 0x6000257
        private static System.Void RecordEntity_Injected(System.IntPtr actor, UnityEngine.HyperGryph.ECS.Entity& entity) { }
        // RVA: 0x038A9360  token: 0x6000258
        private static System.Void GetEntity_Injected(System.Int32 id, System.UInt32 version, UnityEngine.HyperGryph.ECS.Entity& ret) { }
        // RVA: 0x02B2E090  token: 0x6000259
        private static System.Void GetPosition_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& ret) { }
        // RVA: 0x0301F180  token: 0x600025A
        private static System.Void GetShapePosition_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index, UnityEngine.Vector3& ret) { }
        // RVA: 0x031E7090  token: 0x600025B
        private static System.Void SetPosition_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& position) { }
        // RVA: 0x09E1DBD4  token: 0x600025C
        private static System.Void GetShapeRotation_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index, UnityEngine.Quaternion& ret) { }
        // RVA: 0x02B2E0F0  token: 0x600025D
        private static System.Void GetRotation_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Quaternion& ret) { }
        // RVA: 0x031E7030  token: 0x600025E
        private static System.Void SetRotation_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Quaternion& rotation) { }
        // RVA: 0x09E1D718  token: 0x600025F
        private static System.Void AttachBox_Injected(System.Int32 id, System.UInt32 version, UnityEngine.Vector3& halfExtent, UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation, System.Int32 surfaceType, System.Int32 colliderOption, System.Int32 tag, System.Boolean isTrigger, System.Boolean isPrimitive) { }
        // RVA: 0x09E1E130  token: 0x6000260
        private static System.Void Raycast_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }
        // RVA: 0x09E1DFD0  token: 0x6000261
        private static System.Void RaycastComplexMesh_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }
        // RVA: 0x09E1D818  token: 0x6000262
        private static System.Void CapsuleCastComplexMesh_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }
        // RVA: 0x09E1E2AC  token: 0x6000263
        private static System.Void SphereCastComplexMesh_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& center, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }
        // RVA: 0x032718B0  token: 0x6000264
        private static System.Void GetBounds_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Bounds& ret) { }
        // RVA: 0x09E1E448  token: 0x6000265
        private static System.Void TryGetClosestPoint_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& point, System.Boolean& resultIsValid, UnityEngine.Vector3& ret) { }
        // RVA: 0x09E1D9D4  token: 0x6000266
        private static System.Void ClosestPoint_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& position, UnityEngine.Vector3& ret) { }

    }

    // TypeToken: 0x2000018  // size: 0x18
    public class CharacterController : UnityEngine.Collider
    {
        // Properties
        System.Boolean isGrounded { get; /* RVA: 0x09E1C18C */ }

    }

    // TypeToken: 0x2000019  // size: 0x18
    public class MultiCollider : UnityEngine.Collider
    {
        // Properties
        UnityEngine.Mesh ComplexMesh { get; /* RVA: 0x09E1ED4C */ }

        // Methods
        // RVA: 0x09E1E724  token: 0x600026A
        public System.Void AppendBoxCollider(UnityEngine.BoxCollider boxCollider) { }
        // RVA: 0x09E1E768  token: 0x600026B
        public System.Void AppendCapsuleCollider(UnityEngine.CapsuleCollider collider) { }
        // RVA: 0x09E1E7AC  token: 0x600026C
        public System.Void AppendSphereCollider(UnityEngine.SphereCollider collider) { }
        // RVA: 0x09E1EA7C  token: 0x600026D
        public UnityEngine.ColliderSurfaceType GetSurfaceTypeAt(System.Int32 index) { }
        // RVA: 0x09E1EABC  token: 0x600026E
        public System.Int32 GetTagConfigAt(System.Int32 index) { }
        // RVA: 0x09E1E9FC  token: 0x600026F
        public System.Int32 GetGameplayOptionAt(System.Int32 index) { }
        // RVA: 0x09E1EA3C  token: 0x6000270
        public System.Boolean GetIsTriggerAt(System.Int32 index) { }
        // RVA: 0x09E1EB78  token: 0x6000271
        public System.Void SetGameplayOptionAt(System.Int32 index, System.Int32 value) { }
        // RVA: 0x09E1E994  token: 0x6000272
        public System.Void Flush() { }
        // RVA: 0x09E1EB60  token: 0x6000274
        public System.Boolean RaycastComplexMesh(UnityEngine.Ray ray, System.Single maxDistance, UnityEngine.RaycastHit& hit) { }
        // RVA: 0x09E1E854  token: 0x6000275
        private UnityEngine.RaycastHit CapsuleCastComplexMesh_Internal(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Boolean& hasHit) { }
        // RVA: 0x09E1E8E4  token: 0x6000276
        public System.Boolean CapsuleCastComplexMesh(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hit) { }
        // RVA: 0x09E1EC2C  token: 0x6000277
        private UnityEngine.RaycastHit SphereCastComplexMesh_Internal(UnityEngine.Vector3 center, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Boolean& hasHit) { }
        // RVA: 0x09E1ECAC  token: 0x6000278
        public System.Boolean SphereCastComplexMesh(UnityEngine.Vector3 center, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hit) { }
        // RVA: 0x09E1E9C8  token: 0x6000279
        public System.Int32 GetCountWithoutComplexMesh() { }
        // RVA: 0x09E1EAFC  token: 0x600027A
        private System.Boolean RaycastComplexMesh_Injected(UnityEngine.Ray& ray, System.Single maxDistance, UnityEngine.RaycastHit& hit) { }
        // RVA: 0x09E1E7F0  token: 0x600027B
        private System.Void CapsuleCastComplexMesh_Internal_Injected(UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }
        // RVA: 0x09E1EBC8  token: 0x600027C
        private System.Void SphereCastComplexMesh_Internal_Injected(UnityEngine.Vector3& center, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret) { }

    }

    // TypeToken: 0x200001A  // size: 0x18
    public class MeshCollider : UnityEngine.Collider
    {
        // Properties
        UnityEngine.Mesh sharedMesh { get; /* RVA: 0x09E1E66C */ set; /* RVA: 0x03012920 */ }
        System.Boolean convex { get; /* RVA: 0x09E1E604 */ set; /* RVA: 0x09E1E6A0 */ }
        UnityEngine.MeshColliderCookingOptions cookingOptions { get; /* RVA: 0x09E1E638 */ set; /* RVA: 0x09E1E6E4 */ }
        System.Boolean smoothSphereCollisions { get; /* RVA: 0x03D663A0 */ set; /* RVA: 0x0350B670 */ }
        System.Single skinWidth { get; /* RVA: 0x03D85FA0 */ set; /* RVA: 0x0350B670 */ }
        System.Boolean inflateMesh { get; /* RVA: 0x03D4E3A0 */ set; /* RVA: 0x0350B670 */ }

        // Methods
        // RVA: 0x09E1E5D0  token: 0x6000283
        public System.Boolean NeedsReadWriteEnabled() { }
        // RVA: 0x0426FE60  token: 0x600028A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200001B  // size: 0x18
    public class CapsuleCollider : UnityEngine.Collider
    {
        // Properties
        UnityEngine.Vector3 center { get; /* RVA: 0x02A126C0 */ set; /* RVA: 0x04272BA4 */ }
        System.Single radius { get; /* RVA: 0x02A12F70 */ set; /* RVA: 0x02B40C30 */ }
        System.Single height { get; /* RVA: 0x02A12FB0 */ set; /* RVA: 0x02B40C80 */ }
        System.Int32 direction { get; /* RVA: 0x02A12F30 */ set; /* RVA: 0x02B40CD0 */ }

        // Methods
        // RVA: 0x02A12720  token: 0x6000293
        private System.Void get_center_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x035F5DC0  token: 0x6000294
        private System.Void set_center_Injected(UnityEngine.Vector3& value) { }

    }

    // TypeToken: 0x200001C  // size: 0x18
    public class BoxCollider : UnityEngine.Collider
    {
        // Properties
        UnityEngine.Vector3 center { get; /* RVA: 0x09E1BE18 */ set; /* RVA: 0x04272C44 */ }
        UnityEngine.Vector3 size { get; /* RVA: 0x02B951A0 */ set; /* RVA: 0x04272C30 */ }

        // Methods
        // RVA: 0x09E1BDD4  token: 0x6000299
        private System.Void get_center_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x02F67710  token: 0x600029A
        private System.Void set_center_Injected(UnityEngine.Vector3& value) { }
        // RVA: 0x02B951D0  token: 0x600029B
        private System.Void get_size_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x02F676C0  token: 0x600029C
        private System.Void set_size_Injected(UnityEngine.Vector3& value) { }

    }

    // TypeToken: 0x200001D  // size: 0x18
    public class SphereCollider : UnityEngine.Collider
    {
        // Properties
        UnityEngine.Vector3 center { get; /* RVA: 0x09E28AC0 */ set; /* RVA: 0x09E28B64 */ }
        System.Single radius { get; /* RVA: 0x09E28AEC */ set; /* RVA: 0x02B93E20 */ }

        // Methods
        // RVA: 0x09E28A7C  token: 0x60002A1
        private System.Void get_center_Injected(UnityEngine.Vector3& ret) { }
        // RVA: 0x09E28B20  token: 0x60002A2
        private System.Void set_center_Injected(UnityEngine.Vector3& value) { }

    }

    // TypeToken: 0x200001E  // size: 0x18
    public class Joint : UnityEngine.Component
    {
        // Properties
        UnityEngine.Rigidbody connectedBody { get; /* RVA: 0x09E1E544 */ }
        UnityEngine.Vector3 connectedAnchor { set; /* RVA: 0x09E1E5BC */ }

        // Methods
        // RVA: 0x09E1E578  token: 0x60002A5
        private System.Void set_connectedAnchor_Injected(UnityEngine.Vector3& value) { }

    }

    // TypeToken: 0x200001F  // size: 0x34
    public sealed struct ContactPoint
    {
        // Fields
        private UnityEngine.Vector3 m_Point;  // 0x10
        private UnityEngine.Vector3 m_Normal;  // 0x1c
        private System.Int32 m_ThisColliderInstanceID;  // 0x28
        private System.Int32 m_OtherColliderInstanceID;  // 0x2c
        private System.Single m_Separation;  // 0x30

        // Properties
        UnityEngine.Vector3 point { get; /* RVA: 0x03D85920 */ }
        UnityEngine.Vector3 normal { get; /* RVA: 0x03D85900 */ }
        UnityEngine.Collider thisCollider { get; /* RVA: 0x09E1CBE8 */ }
        UnityEngine.Collider otherCollider { get; /* RVA: 0x09E1CBDC */ }

        // Methods
        // RVA: 0x09E1CBA8  token: 0x60002AA
        private static UnityEngine.Collider GetColliderByInstanceID(System.Int32 instanceID) { }

    }

    // TypeToken: 0x2000020  // size: 0x14
    public sealed struct PhysicsScene : System.IEquatable`1
    {
        // Fields
        private System.Int32 m_Handle;  // 0x10

        // Methods
        // RVA: 0x09E1FD6C  token: 0x60002AB
        public virtual System.String ToString() { }
        // RVA: 0x03D85860  token: 0x60002AC
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x09E1F054  token: 0x60002AD
        public virtual System.Boolean Equals(System.Object other) { }
        // RVA: 0x022A9C10  token: 0x60002AE
        public virtual System.Boolean Equals(UnityEngine.PhysicsScene other) { }
        // RVA: 0x09E1FC74  token: 0x60002AF
        public System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F428  token: 0x60002B0
        private static System.Boolean Internal_RaycastTest(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x0238CFE0  token: 0x60002B1
        public System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F450  token: 0x60002B2
        private static System.Boolean Internal_Raycast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, System.Single maxDistance, UnityEngine.RaycastHit& hit, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x0238CC80  token: 0x60002B3
        public System.Int32 Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x0426FAB8  token: 0x60002B4
        private static System.Int32 Internal_RaycastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1FC14  token: 0x60002B5
        private static System.Boolean Query_CapsuleCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F2A4  token: 0x60002B6
        private static System.Boolean Internal_CapsuleCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1EFB8  token: 0x60002B7
        public System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x04272A88  token: 0x60002B8
        private static System.Int32 Internal_CapsuleCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x02B309D0  token: 0x60002B9
        public System.Int32 CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F244  token: 0x60002BA
        private static System.Int32 Internal_CapsuleCastNonAllocV2(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 diretion, UnityEngine.ECSColliderResultProxy[] proxies, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1EEC4  token: 0x60002BB
        public System.Int32 CapsuleCastV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] proxies, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F794  token: 0x60002BC
        private static System.Int32 OverlapCapsuleNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F7D4  token: 0x60002BD
        public System.Int32 OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x04272B3C  token: 0x60002BE
        private static System.Int32 OverlapCapsuleNonAlloc_InternalV2(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x02B349D0  token: 0x60002BF
        public System.Int32 OverlapCapsuleV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x04271A38  token: 0x60002C0
        private static System.Boolean Query_SphereCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x027E7FE0  token: 0x60002C1
        private static System.Boolean Internal_SphereCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x027E7F60  token: 0x60002C2
        public System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x04272AE8  token: 0x60002C3
        private static System.Int32 Internal_SphereCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x02B328D0  token: 0x60002C4
        public System.Int32 SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F9B0  token: 0x60002C5
        private static System.Int32 OverlapSphereNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1FA28  token: 0x60002C6
        public System.Int32 OverlapSphere(UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F91C  token: 0x60002C7
        private static System.Int32 OverlapSphereNonAllocV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F9E0  token: 0x60002C8
        public System.Int32 OverlapSphereV2(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1FB50  token: 0x60002C9
        private static System.Boolean Query_BoxCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, UnityEngine.RaycastHit& outHit, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F0B8  token: 0x60002CA
        private static System.Boolean Internal_BoxCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1EE18  token: 0x60002CB
        public System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F588  token: 0x60002CC
        private static System.Int32 OverlapBoxNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F63C  token: 0x60002CD
        public System.Int32 OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F4E4  token: 0x60002CE
        private static System.Int32 OverlapBoxNonAllocV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F5C8  token: 0x60002CF
        public System.Int32 OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x0426FD8C  token: 0x60002D0
        private static System.Int32 Internal_BoxCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x02423860  token: 0x60002D1
        public System.Int32 BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F3C4  token: 0x60002D2
        private static System.Boolean Internal_RaycastTest_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Ray& ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x02EC0330  token: 0x60002D3
        private static System.Boolean Internal_Raycast_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Ray& ray, System.Single maxDistance, UnityEngine.RaycastHit& hit, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x02F62F10  token: 0x60002D4
        private static System.Int32 Internal_RaycastNonAlloc_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Ray& ray, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1FBB0  token: 0x60002D5
        private static System.Boolean Query_CapsuleCast_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point1, UnityEngine.Vector3& point2, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x0335D620  token: 0x60002D6
        private static System.Int32 Internal_CapsuleCastNonAlloc_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F1E0  token: 0x60002D7
        private static System.Int32 Internal_CapsuleCastNonAllocV2_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& diretion, UnityEngine.ECSColliderResultProxy[] proxies, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F730  token: 0x60002D8
        private static System.Int32 OverlapCapsuleNonAlloc_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x030CB690  token: 0x60002D9
        private static System.Int32 OverlapCapsuleNonAlloc_InternalV2_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x0335DAB0  token: 0x60002DA
        private static System.Boolean Query_SphereCast_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& origin, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x02741E00  token: 0x60002DB
        private static System.Int32 Internal_SphereCastNonAlloc_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& origin, System.Single radius, UnityEngine.Vector3& direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F94C  token: 0x60002DC
        private static System.Int32 OverlapSphereNonAlloc_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F8B8  token: 0x60002DD
        private static System.Int32 OverlapSphereNonAllocV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1FAEC  token: 0x60002DE
        private static System.Boolean Query_BoxCast_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Vector3& direction, UnityEngine.Quaternion& orientation, System.Single maxDistance, UnityEngine.RaycastHit& outHit, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F524  token: 0x60002DF
        private static System.Int32 OverlapBoxNonAlloc_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion& orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x09E1F480  token: 0x60002E0
        private static System.Int32 OverlapBoxNonAllocV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion& orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        // RVA: 0x030FE4F0  token: 0x60002E1
        private static System.Int32 Internal_BoxCastNonAlloc_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Vector3& direction, UnityEngine.RaycastHit[] raycastHits, UnityEngine.Quaternion& orientation, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }

    }

    // TypeToken: 0x2000021  // size: 0x1C
    public sealed struct QueryParameters
    {
        // Fields
        public System.Int32 layerMask;  // 0x10
        public System.Boolean hitMultipleFaces;  // 0x14
        public System.Boolean hitBackfaces;  // 0x15
        public UnityEngine.QueryTriggerInteraction hitTriggers;  // 0x18

        // Methods
        // RVA: 0x03D87FC0  token: 0x60002E2
        public System.Void .ctor(System.Int32 layerMask, System.Boolean hitMultipleFaces, UnityEngine.QueryTriggerInteraction hitTriggers, System.Boolean hitBackfaces) { }

    }

    // TypeToken: 0x2000022  // size: 0x3C
    public sealed struct RaycastCommand
    {
        // Fields
        private UnityEngine.Vector3 <from>k__BackingField;  // 0x10
        private UnityEngine.Vector3 <direction>k__BackingField;  // 0x1c
        private System.Single <distance>k__BackingField;  // 0x28
        private UnityEngine.PhysicsScene <physicsScene>k__BackingField;  // 0x2c
        public UnityEngine.QueryParameters queryParameters;  // 0x30

        // Properties
        UnityEngine.Vector3 from { get; /* RVA: 0x03D56520 */ set; /* RVA: 0x03D56570 */ }
        UnityEngine.Vector3 direction { get; /* RVA: 0x03D56540 */ set; /* RVA: 0x03D56580 */ }
        System.Single distance { get; /* RVA: 0x03D4EBF0 */ set; /* RVA: 0x03D4EC00 */ }
        UnityEngine.PhysicsScene physicsScene { set; /* RVA: 0x03D4EBC0 */ }

        // Methods
        // RVA: 0x03199660  token: 0x60002E3
        public System.Void .ctor(UnityEngine.Vector3 from, UnityEngine.Vector3 direction, UnityEngine.QueryParameters queryParameters, System.Single distance) { }
        // RVA: 0x030FF560  token: 0x60002EB
        public static Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.RaycastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, System.Int32 minCommandsPerJob, System.Int32 maxHits, Unity.Jobs.JobHandle dependsOn) { }
        // RVA: 0x030FF4E0  token: 0x60002EC
        public static Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.RaycastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, System.Int32 minCommandsPerJob, Unity.Jobs.JobHandle dependsOn) { }
        // RVA: 0x030FF720  token: 0x60002ED
        private static Unity.Jobs.JobHandle ScheduleRaycastBatch(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* commands, System.Int32 commandLen, System.Void* result, System.Int32 resultLen, System.Int32 minCommandsPerJob, System.Int32 maxHits) { }
        // RVA: 0x030FF7C0  token: 0x60002EE
        private static System.Void ScheduleRaycastBatch_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* commands, System.Int32 commandLen, System.Void* result, System.Int32 resultLen, System.Int32 minCommandsPerJob, System.Int32 maxHits, Unity.Jobs.JobHandle& ret) { }

    }

    // TypeToken: 0x2000023  // size: 0x58
    public sealed struct BoxcastCommand
    {
        // Fields
        private UnityEngine.Vector3 <center>k__BackingField;  // 0x10
        private UnityEngine.Vector3 <halfExtents>k__BackingField;  // 0x1c
        private UnityEngine.Quaternion <orientation>k__BackingField;  // 0x28
        private UnityEngine.Vector3 <direction>k__BackingField;  // 0x38
        private System.Single <distance>k__BackingField;  // 0x44
        private UnityEngine.PhysicsScene <physicsScene>k__BackingField;  // 0x48
        public UnityEngine.QueryParameters queryParameters;  // 0x4c

        // Properties
        UnityEngine.Vector3 center { set; /* RVA: 0x03D56570 */ }
        UnityEngine.Vector3 halfExtents { set; /* RVA: 0x03D56580 */ }
        UnityEngine.Quaternion orientation { set; /* RVA: 0x03D51D90 */ }
        UnityEngine.Vector3 direction { set; /* RVA: 0x03D50F50 */ }
        System.Single distance { set; /* RVA: 0x03D56CB0 */ }
        UnityEngine.PhysicsScene physicsScene { set; /* RVA: 0x03D4ECB0 */ }

        // Methods
        // RVA: 0x09E1C118  token: 0x60002EF
        public System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.Vector3 direction, UnityEngine.QueryParameters queryParameters, System.Single distance) { }
        // RVA: 0x09E1BEB8  token: 0x60002F6
        public static Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.BoxcastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, System.Int32 minCommandsPerJob, System.Int32 maxHits, Unity.Jobs.JobHandle dependsOn) { }
        // RVA: 0x09E1BE44  token: 0x60002F7
        public static Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.BoxcastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, System.Int32 minCommandsPerJob, Unity.Jobs.JobHandle dependsOn) { }
        // RVA: 0x09E1C0AC  token: 0x60002F8
        private static Unity.Jobs.JobHandle ScheduleBoxcastBatch(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* commands, System.Int32 commandLen, System.Void* result, System.Int32 resultLen, System.Int32 minCommandsPerJob, System.Int32 maxHits) { }
        // RVA: 0x09E1C048  token: 0x60002F9
        private static System.Void ScheduleBoxcastBatch_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* commands, System.Int32 commandLen, System.Void* result, System.Int32 resultLen, System.Int32 minCommandsPerJob, System.Int32 maxHits, Unity.Jobs.JobHandle& ret) { }

    }

}

