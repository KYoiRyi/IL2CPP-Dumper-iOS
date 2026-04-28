// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.PhysicsModule.dll
// Classes:  35
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

CLASS: CollisionCallback
TYPE:  sealed class
TOKEN: 0x2000017
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x09E1CA04  token=0x6000267  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x09E1C9B8  token=0x6000268  System.Void Invoke(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider)
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

CLASS: UnityEngine.RigidbodyConstraints
TYPE:  sealed struct
TOKEN: 0x2000004
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RigidbodyConstraintsNone  // const
  public    static  UnityEngine.RigidbodyConstraintsFreezePositionX  // const
  public    static  UnityEngine.RigidbodyConstraintsFreezePositionY  // const
  public    static  UnityEngine.RigidbodyConstraintsFreezePositionZ  // const
  public    static  UnityEngine.RigidbodyConstraintsFreezeRotationX  // const
  public    static  UnityEngine.RigidbodyConstraintsFreezeRotationY  // const
  public    static  UnityEngine.RigidbodyConstraintsFreezeRotationZ  // const
  public    static  UnityEngine.RigidbodyConstraintsFreezePosition  // const
  public    static  UnityEngine.RigidbodyConstraintsFreezeRotation  // const
  public    static  UnityEngine.RigidbodyConstraintsFreezeAll  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ForceMode
TYPE:  sealed struct
TOKEN: 0x2000005
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ForceMode           Force  // const
  public    static  UnityEngine.ForceMode           Acceleration  // const
  public    static  UnityEngine.ForceMode           Impulse  // const
  public    static  UnityEngine.ForceMode           VelocityChange  // const
METHODS:
END_CLASS

CLASS: UnityEngine.MeshColliderCookingOptions
TYPE:  sealed struct
TOKEN: 0x2000006
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.MeshColliderCookingOptionsNone  // const
  public    static  UnityEngine.MeshColliderCookingOptionsInflateConvexMesh  // const
  public    static  UnityEngine.MeshColliderCookingOptionsCookForFasterSimulation  // const
  public    static  UnityEngine.MeshColliderCookingOptionsEnableMeshCleaning  // const
  public    static  UnityEngine.MeshColliderCookingOptionsWeldColocatedVertices  // const
  public    static  UnityEngine.MeshColliderCookingOptionsUseFastMidphase  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ColliderSurfaceType
TYPE:  sealed struct
TOKEN: 0x2000007
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ColliderSurfaceType Default  // const
  public    static  UnityEngine.ColliderSurfaceType Concrete  // const
  public    static  UnityEngine.ColliderSurfaceType Wood  // const
  public    static  UnityEngine.ColliderSurfaceType Dirt  // const
  public    static  UnityEngine.ColliderSurfaceType Grass  // const
  public    static  UnityEngine.ColliderSurfaceType Stone  // const
  public    static  UnityEngine.ColliderSurfaceType Water  // const
  public    static  UnityEngine.ColliderSurfaceType Flesh  // const
  public    static  UnityEngine.ColliderSurfaceType Metal  // const
  public    static  UnityEngine.ColliderSurfaceType Crystal  // const
  public    static  UnityEngine.ColliderSurfaceType Rubber  // const
  public    static  UnityEngine.ColliderSurfaceType Sand  // const
  public    static  UnityEngine.ColliderSurfaceType Gravel  // const
  public    static  UnityEngine.ColliderSurfaceType Moss  // const
  public    static  UnityEngine.ColliderSurfaceType Custom  // const
  public    static  UnityEngine.ColliderSurfaceType Snow  // const
  public    static  UnityEngine.ColliderSurfaceType Mud  // const
  public    static  UnityEngine.ColliderSurfaceType Cardboard  // const
  public    static  UnityEngine.ColliderSurfaceType Plastic  // const
  public    static  UnityEngine.ColliderSurfaceType Ice  // const
  public    static  UnityEngine.ColliderSurfaceType Wet  // const
  public    static  UnityEngine.ColliderSurfaceType WaterV2  // const
METHODS:
END_CLASS

CLASS: UnityEngine.RigidbodyInterpolation
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RigidbodyInterpolationNone  // const
  public    static  UnityEngine.RigidbodyInterpolationInterpolate  // const
  public    static  UnityEngine.RigidbodyInterpolationExtrapolate  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ControllerColliderHit
TYPE:  class
TOKEN: 0x2000009
SIZE:  0x50
FIELDS:
  private           UnityEngine.CharacterController m_Controller  // 0x10
  private           UnityEngine.Collider            m_Collider  // 0x18
  private           UnityEngine.Vector3             m_Point  // 0x20
  private           UnityEngine.Vector3             m_Normal  // 0x2c
  private           UnityEngine.Vector3             m_MoveDirection  // 0x38
  private           System.Single                   m_MoveLength  // 0x44
  private           System.Int32                    m_Push  // 0x48
PROPERTIES:
  gameObject  get=0x09E1CBF4
  point  get=0x03D87FA0
METHODS:
END_CLASS

CLASS: UnityEngine.Collision
TYPE:  class
TOKEN: 0x200000A
SIZE:  0x50
FIELDS:
  private           UnityEngine.Vector3             m_Impulse  // 0x10
  private           UnityEngine.Vector3             m_RelativeVelocity  // 0x1c
  private           UnityEngine.Component           m_Body  // 0x28
  private           UnityEngine.Collider            m_Collider  // 0x30
  private           System.Int32                    m_ContactCount  // 0x38
  private           UnityEngine.ContactPoint[]      m_ReusedContacts  // 0x40
  private           UnityEngine.ContactPoint[]      m_LegacyContacts  // 0x48
PROPERTIES:
  relativeVelocity  get=0x03D85980
  collider  get=0x03D86D10
  gameObject  get=0x09E1CB34
  contacts  get=0x09E1CACC
  impulse  get=0x03D859D0
METHODS:
END_CLASS

CLASS: UnityEngine.QueryTriggerInteraction
TYPE:  sealed struct
TOKEN: 0x200000B
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.QueryTriggerInteractionUseGlobal  // const
  public    static  UnityEngine.QueryTriggerInteractionIgnore  // const
  public    static  UnityEngine.QueryTriggerInteractionCollide  // const
METHODS:
END_CLASS

CLASS: UnityEngine.CollisionDetectionMode
TYPE:  sealed struct
TOKEN: 0x200000C
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.CollisionDetectionModeDiscrete  // const
  public    static  UnityEngine.CollisionDetectionModeContinuous  // const
  public    static  UnityEngine.CollisionDetectionModeContinuousDynamic  // const
  public    static  UnityEngine.CollisionDetectionModeContinuousSpeculative  // const
METHODS:
END_CLASS

CLASS: UnityEngine.ArticulationBody
TYPE:  class
TOKEN: 0x200000D
SIZE:  0x18
EXTENDS: UnityEngine.Behaviour
FIELDS:
METHODS:
  RVA=0x0426FE60  token=0x600000A  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Physics
TYPE:  class
TOKEN: 0x200000E
SIZE:  0x10
FIELDS:
  private   static  System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>>ContactModifyEvent  // static @ 0x0
  private   static  System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>>ContactModifyEventCCD  // static @ 0x8
  private   static  System.Single                   k_MaxFloatMinusEpsilon  // const
  public    static  System.Int32                    IgnoreRaycastLayer  // const
  public    static  System.Int32                    DefaultRaycastLayers  // const
  public    static  System.Int32                    AllLayers  // const
  public    static  System.Int32                    kIgnoreRaycastLayer  // const
  public    static  System.Int32                    kDefaultRaycastLayers  // const
  public    static  System.Int32                    kAllLayers  // const
PROPERTIES:
  gravity  get=0x0282FAC0  set=0x09E26928
  defaultContactOffset  get=0x027E7190  set=0x09E267D8
  sleepThreshold  get=0x09E26598  set=0x09E26AB4
  queriesHitTriggers  get=0x09E26540  set=0x09E26A4C
  queriesHitBackfaces  get=0x09E26514  set=0x09E26A18
  bounceThreshold  get=0x09E262F8  set=0x09E26750
  defaultMaxDepenetrationVelocity  get=0x09E263B4  set=0x09E26850
  defaultSolverIterations  get=0x09E263E0  set=0x09E2688C
  defaultSolverVelocityIterations  get=0x09E2640C  set=0x09E268C0
  defaultMaxAngularSpeed  get=0x09E26388  set=0x09E26814
  improvedPatchFriction  get=0x09E26438  set=0x09E26938
  defaultPhysicsScene  get=0x027EDC40
  logPhysXCheckError  get=0x09E264E8  set=0x02F2EB90
  autoSimulation  get=0x02F50A90  set=0x02F2EBD0
  autoSyncTransforms  get=0x09E262CC  set=0x09E2671C
  reuseCollisionCallbacks  get=0x09E2656C  set=0x09E26A80
  interCollisionDistance  get=0x09E26464  set=0x09E2696C
  interCollisionStiffness  get=0x09E264BC  set=0x09E269DC
  interCollisionSettingsToggle  get=0x09E26490  set=0x09E269A8
  clothGravity  get=0x09E26364  set=0x09E267C8
  minPenetrationForPenalty  get=0x03D85FA0  set=0x0350B670
  bounceTreshold  get=0x09E26324  set=0x09E2678C
  sleepVelocity  get=0x03D85FA0  set=0x0350B670
  sleepAngularVelocity  get=0x03D85FA0  set=0x0350B670
  maxAngularVelocity  get=0x03D85FA0  set=0x0350B670
  solverIterationCount  get=0x09E265C4  set=0x09E26AF0
  solverVelocityIterationCount  get=0x09E265D0  set=0x09E26AF8
  penetrationPenaltyForce  get=0x03D85FA0  set=0x0350B670
EVENTS:
  ContactModifyEvent  add=add_ContactModifyEvent  remove=remove_ContactModifyEvent
  ContactModifyEventCCD  add=add_ContactModifyEventCCD  remove=remove_ContactModifyEventCCD
METHODS:
  RVA=0x09E227F8  token=0x600000F  System.Void OnSceneContactModify(UnityEngine.PhysicsScene scene, System.IntPtr buffer, System.Int32 count, System.Boolean isCCD)
  RVA=0x03D46E90  token=0x6000029  System.Void ClearUnusedMemory()
  RVA=0x09E221C4  token=0x600002A  System.Void IgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2, System.Boolean ignore)
  RVA=0x09E22218  token=0x600002B  System.Void IgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2)
  RVA=0x09E22230  token=0x600002C  System.Void IgnoreLayerCollision(System.Int32 layer1, System.Int32 layer2, System.Boolean ignore)
  RVA=0x09E220FC  token=0x600002D  System.Void ForceRebuildDynamicTree(System.Boolean rebuildStatic, System.Boolean rebuildDynamic)
  RVA=0x09E22224  token=0x600002E  System.Void IgnoreLayerCollision(System.Int32 layer1, System.Int32 layer2)
  RVA=0x09E22184  token=0x600002F  System.Boolean GetIgnoreLayerCollision(System.Int32 layer1, System.Int32 layer2)
  RVA=0x09E22140  token=0x6000030  System.Boolean GetIgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2)
  RVA=0x09E25200  token=0x6000031  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E250E0  token=0x6000032  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E255B8  token=0x6000033  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance)
  RVA=0x09E254BC  token=0x6000034  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction)
  RVA=0x027EE8C0  token=0x6000035  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x02FA35E0  token=0x6000036  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x02EC0080  token=0x6000037  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance)
  RVA=0x09E25170  token=0x6000038  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo)
  RVA=0x09E24FB8  token=0x6000039  System.Boolean RaycastV2(UnityEngine.ECSColliderResultProxy proxy, UnityEngine.Ray ray, System.Single maxDistance, UnityEngine.RaycastHit& hit)
  RVA=0x09E2504C  token=0x600003A  System.Boolean RaycastV2(UnityEngine.ECSColliderResultProxy proxy, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, UnityEngine.RaycastHit& hit)
  RVA=0x09E22428  token=0x600003B  UnityEngine.RaycastHit Internal_RaycastTestV2(UnityEngine.ECSColliderResultProxy collider, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit)
  RVA=0x09E2542C  token=0x600003C  System.Boolean Raycast(UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E25298  token=0x600003D  System.Boolean Raycast(UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E25320  token=0x600003E  System.Boolean Raycast(UnityEngine.Ray ray, System.Single maxDistance)
  RVA=0x09E25640  token=0x600003F  System.Boolean Raycast(UnityEngine.Ray ray)
  RVA=0x02DDC180  token=0x6000040  System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x029119B0  token=0x6000041  System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E2539C  token=0x6000042  System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance)
  RVA=0x09E25534  token=0x6000043  System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo)
  RVA=0x09E22698  token=0x6000044  System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E22768  token=0x6000045  System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32 layerMask)
  RVA=0x09E2264C  token=0x6000046  System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end)
  RVA=0x09E22528  token=0x6000047  System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E227B0  token=0x6000048  System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask)
  RVA=0x09E22600  token=0x6000049  System.Boolean Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.RaycastHit& hitInfo)
  RVA=0x09E21350  token=0x600004A  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E215F8  token=0x600004B  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E214A8  token=0x600004C  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance)
  RVA=0x09E21254  token=0x600004D  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction)
  RVA=0x09E2151C  token=0x600004E  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E212C8  token=0x600004F  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E211CC  token=0x6000050  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance)
  RVA=0x09E21424  token=0x6000051  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo)
  RVA=0x027E7EB0  token=0x6000052  System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E25D64  token=0x6000053  System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E25FB8  token=0x6000054  System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance)
  RVA=0x09E25E3C  token=0x6000055  System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo)
  RVA=0x09E25E9C  token=0x6000056  System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E25F84  token=0x6000057  System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E25E04  token=0x6000058  System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance)
  RVA=0x09E26078  token=0x6000059  System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius)
  RVA=0x09E26018  token=0x600005A  System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E260B8  token=0x600005B  System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E25DC8  token=0x600005C  System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance)
  RVA=0x09E25F40  token=0x600005D  System.Boolean SphereCast(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo)
  RVA=0x09E204B8  token=0x600005E  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E20808  token=0x600005F  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E206BC  token=0x6000060  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance)
  RVA=0x09E20928  token=0x6000061  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation)
  RVA=0x09E20428  token=0x6000062  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction)
  RVA=0x09E20744  token=0x6000063  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E2058C  token=0x6000064  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E209B0  token=0x6000065  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation, System.Single maxDistance)
  RVA=0x09E20894  token=0x6000066  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation)
  RVA=0x09E20624  token=0x6000067  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo)
  RVA=0x09E2239C  token=0x6000068  UnityEngine.RaycastHit[] Internal_RaycastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E24A60  token=0x6000069  UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E24A18  token=0x600006A  UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E24BD0  token=0x600006B  UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance)
  RVA=0x09E24C1C  token=0x600006C  UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction)
  RVA=0x09E24B84  token=0x600006D  UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E249CC  token=0x600006E  UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E2497C  token=0x600006F  UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, System.Single maxDistance)
  RVA=0x09E24C70  token=0x6000070  UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray)
  RVA=0x03115370  token=0x6000071  System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E24D54  token=0x6000072  System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E24CC4  token=0x6000073  System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance)
  RVA=0x03559320  token=0x6000074  System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results)
  RVA=0x027ED890  token=0x6000075  System.Int32 RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E24E88  token=0x6000076  System.Int32 RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E24DEC  token=0x6000077  System.Int32 RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance)
  RVA=0x09E24F28  token=0x6000078  System.Int32 RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results)
  RVA=0x09E24328  token=0x6000079  UnityEngine.RaycastHit[] Query_CapsuleCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E20A44  token=0x600007A  UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E20BF8  token=0x600007B  UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E20B84  token=0x600007C  UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance)
  RVA=0x09E20C70  token=0x600007D  UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction)
  RVA=0x09E24884  token=0x600007E  UnityEngine.RaycastHit[] Query_SphereCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E259F8  token=0x600007F  UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E25830  token=0x6000080  UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E25970  token=0x6000081  UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance)
  RVA=0x09E25918  token=0x6000082  UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction)
  RVA=0x09E258C4  token=0x6000083  UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E257FC  token=0x6000084  UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E259C0  token=0x6000085  UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, System.Single radius, System.Single maxDistance)
  RVA=0x09E25884  token=0x6000086  UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, System.Single radius)
  RVA=0x09E23958  token=0x6000087  UnityEngine.Collider[] OverlapCapsule_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E23A4C  token=0x6000088  UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E23988  token=0x6000089  UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask)
  RVA=0x09E23B24  token=0x600008A  UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius)
  RVA=0x09E237A4  token=0x600008B  UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E23868  token=0x600008C  UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E23820  token=0x600008D  UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Int32 layerMask)
  RVA=0x09E237D4  token=0x600008E  UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius)
  RVA=0x09E240B0  token=0x600008F  UnityEngine.Collider[] OverlapSphere_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E24178  token=0x6000090  UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x0270A7C0  token=0x6000091  UnityEngine.ECSColliderResultProxy CreateECSProxy(UnityEngine.Collider collider)
  RVA=0x09E240D8  token=0x6000092  UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask)
  RVA=0x09E24230  token=0x6000093  UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, System.Single radius)
  RVA=0x09E23F50  token=0x6000094  UnityEngine.ECSColliderResultProxy[] OverlapSphereV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E23FB0  token=0x6000095  UnityEngine.ECSColliderResultProxy[] OverlapSphereV2(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E2401C  token=0x6000096  UnityEngine.ECSColliderResultProxy[] OverlapSphereV2(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask)
  RVA=0x09E23F78  token=0x6000097  UnityEngine.ECSColliderResultProxy[] OverlapSphereV2(UnityEngine.Vector3 position, System.Single radius)
  RVA=0x042747DC  token=0x6000098  System.Void Simulate_Internal(UnityEngine.PhysicsScene physicsScene, System.Single step)
  RVA=0x02F50A00  token=0x6000099  System.Void Simulate(System.Single step)
  RVA=0x02722980  token=0x600009C  System.Void SyncTransforms()
  RVA=0x09E24738  token=0x60000A1  System.Boolean Query_ComputePenetration(UnityEngine.Collider colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x09E21F14  token=0x60000A2  System.Boolean ComputePenetration(UnityEngine.Collider colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x04272A3C  token=0x60000A3  System.Boolean Query_ComputePenetrationV2(UnityEngine.ECSColliderResultProxy colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x02B2F270  token=0x60000A4  System.Boolean ComputePenetrationV2(UnityEngine.ECSColliderResultProxy colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x09E24688  token=0x60000A5  System.Boolean Query_ComputeCapsulePenetration(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x09E21DE8  token=0x60000A6  System.Boolean ComputeCapsulePenetration(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x09E245D8  token=0x60000A7  System.Boolean Query_ComputeCapsulePenetrationV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x09E21D1C  token=0x60000A8  System.Boolean ComputeCapsulePenetrationV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x09E247E8  token=0x60000A9  System.Boolean Query_ComputeSpherePenetrationV2(UnityEngine.Vector3 center, System.Single radius, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x09E2204C  token=0x60000AA  System.Boolean ComputeSpherePenetrationV2(UnityEngine.Vector3 center, System.Single radius, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x09E24528  token=0x60000AB  System.Boolean Query_ComputeBoxPenetrationV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtent, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x09E21C40  token=0x60000AC  System.Boolean ComputeBoxPenetrationV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtent, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x09E224F0  token=0x60000AD  System.Boolean IsSimulatedThisFrame_Internal()
  RVA=0x09E2251C  token=0x60000AE  System.Boolean IsSimulatedThisFrame()
  RVA=0x09E257C0  token=0x60000AF  System.Void SetForceSimulateThisFrame_Internal(System.Boolean force)
  RVA=0x09E257F4  token=0x60000B0  System.Void SetForceSimulateThisFrame(System.Boolean force)
  RVA=0x03D1EE20  token=0x60000B1  System.Void SetFastSimulate_Internal(System.Boolean fast)
  RVA=0x042746E4  token=0x60000B2  System.Void SetFastSimulate(System.Boolean fast)
  RVA=0x09E24484  token=0x60000B3  UnityEngine.Vector3 Query_ClosestPoint(UnityEngine.Collider collider, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point)
  RVA=0x09E21B48  token=0x60000B4  UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 point, UnityEngine.Collider collider, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  RVA=0x09E243E0  token=0x60000B5  UnityEngine.Vector3 Query_ClosestPointV2(UnityEngine.ECSColliderResultProxy colliderProxy, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point)
  RVA=0x09E21AA4  token=0x60000B6  UnityEngine.Vector3 ClosestPointV2(UnityEngine.Vector3 point, UnityEngine.ECSColliderResultProxy colliderProxy, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  RVA=0x09E24928  token=0x60000B7  UnityEngine.Vector3 Query_TryGetClosestPoint(UnityEngine.ECSColliderResultProxy colliderProxy, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point, System.Boolean& resultIsValid)
  RVA=0x09E260F4  token=0x60000B8  System.Boolean TryGetClosestPoint(UnityEngine.ECSColliderResultProxy colliderProxy, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point, UnityEngine.Vector3& result)
  RVA=0x09E23E20  token=0x60000C1  System.Int32 OverlapSphereNonAlloc(UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E23D6C  token=0x60000C2  System.Int32 OverlapSphereNonAlloc(UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask)
  RVA=0x09E23CC4  token=0x60000C3  System.Int32 OverlapSphereNonAlloc(UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results)
  RVA=0x09E23BDC  token=0x60000C4  System.Int32 OverlapSphereNonAllocV2(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E23C94  token=0x60000C5  System.Int32 OverlapSphereNonAllocV2(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask)
  RVA=0x09E23C5C  token=0x60000C6  System.Int32 OverlapSphereNonAllocV2(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results)
  RVA=0x09E219A8  token=0x60000C7  System.Boolean CheckSphere_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E21A08  token=0x60000C8  System.Boolean CheckSphere(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E21A74  token=0x60000C9  System.Boolean CheckSphere(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask)
  RVA=0x09E219D0  token=0x60000CA  System.Boolean CheckSphere(UnityEngine.Vector3 position, System.Single radius)
  RVA=0x02B30890  token=0x60000CB  System.Int32 CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E20E88  token=0x60000CC  System.Int32 CapsuleCastNonAllocV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E21038  token=0x60000CD  System.Int32 CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E20F64  token=0x60000CE  System.Int32 CapsuleCastNonAllocV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] results, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E21144  token=0x60000CF  System.Int32 CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance)
  RVA=0x09E20DB4  token=0x60000D0  System.Int32 CapsuleCastNonAllocV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] results, System.Single maxDistance)
  RVA=0x09E210C0  token=0x60000D1  System.Int32 CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results)
  RVA=0x09E20CE4  token=0x60000D2  System.Int32 CapsuleCastNonAllocV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] results)
  RVA=0x02B32740  token=0x60000D3  System.Int32 SphereCastNonAlloc(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E25CA0  token=0x60000D4  System.Int32 SphereCastNonAlloc(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E25BE0  token=0x60000D5  System.Int32 SphereCastNonAlloc(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance)
  RVA=0x09E25D04  token=0x60000D6  System.Int32 SphereCastNonAlloc(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results)
  RVA=0x09E25C40  token=0x60000D7  System.Int32 SphereCastNonAlloc(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E25B68  token=0x60000D8  System.Int32 SphereCastNonAlloc(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E25BA4  token=0x60000D9  System.Int32 SphereCastNonAlloc(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit[] results, System.Single maxDistance)
  RVA=0x09E25B24  token=0x60000DA  System.Int32 SphereCastNonAlloc(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit[] results)
  RVA=0x04271A08  token=0x60000DB  System.Boolean CheckCapsule_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x027E6B50  token=0x60000DC  System.Boolean CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E218B0  token=0x60000DD  System.Boolean CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single radius, System.Int32 layerMask)
  RVA=0x09E218F8  token=0x60000DE  System.Boolean CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single radius)
  RVA=0x09E216D4  token=0x60000DF  System.Boolean CheckBox_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E217C8  token=0x60000E0  System.Boolean CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E2185C  token=0x60000E1  System.Boolean CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask)
  RVA=0x09E21704  token=0x60000E2  System.Boolean CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation)
  RVA=0x09E21760  token=0x60000E3  System.Boolean CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents)
  RVA=0x09E230A8  token=0x60000E4  UnityEngine.Collider[] OverlapBox_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E2325C  token=0x60000E5  UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E23340  token=0x60000E6  UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask)
  RVA=0x09E230D8  token=0x60000E7  UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation)
  RVA=0x09E2319C  token=0x60000E8  UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents)
  RVA=0x09E22A84  token=0x60000E9  System.Int32 OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E22B80  token=0x60000EA  System.Int32 OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, System.Int32 mask)
  RVA=0x09E22C5C  token=0x60000EB  System.Int32 OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation)
  RVA=0x09E22D34  token=0x60000EC  System.Int32 OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results)
  RVA=0x09E22E6C  token=0x60000ED  UnityEngine.ECSColliderResultProxy[] OverlapBoxV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E22FB0  token=0x60000EE  UnityEngine.ECSColliderResultProxy[] OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E22F5C  token=0x60000EF  UnityEngine.ECSColliderResultProxy[] OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, System.Int32 layerMask)
  RVA=0x09E22E9C  token=0x60000F0  UnityEngine.ECSColliderResultProxy[] OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation)
  RVA=0x09E22EF4  token=0x60000F1  UnityEngine.ECSColliderResultProxy[] OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents)
  RVA=0x09E229D4  token=0x60000F2  System.Int32 OverlapBoxNonAllocV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E2291C  token=0x60000F3  System.Int32 OverlapBoxNonAllocV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation, System.Int32 mask)
  RVA=0x09E2297C  token=0x60000F4  System.Int32 OverlapBoxNonAllocV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation)
  RVA=0x09E228B4  token=0x60000F5  System.Int32 OverlapBoxNonAllocV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results)
  RVA=0x02423710  token=0x60000F6  System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E20300  token=0x60000F7  System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation)
  RVA=0x09E20394  token=0x60000F8  System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, System.Single maxDistance)
  RVA=0x09E201D0  token=0x60000F9  System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E20268  token=0x60000FA  System.Int32 BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results)
  RVA=0x09E222E4  token=0x60000FB  UnityEngine.RaycastHit[] Internal_BoxCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1FE5C  token=0x60000FC  UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E200B4  token=0x60000FD  UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask)
  RVA=0x09E1FFA4  token=0x60000FE  UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance)
  RVA=0x09E2002C  token=0x60000FF  UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation)
  RVA=0x09E20140  token=0x6000100  UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction)
  RVA=0x09E23650  token=0x6000101  System.Int32 OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E234B0  token=0x6000102  System.Int32 OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask)
  RVA=0x09E23584  token=0x6000103  System.Int32 OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results)
  RVA=0x02B34920  token=0x6000104  System.Int32 OverlapCapsuleNonAllocV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E23460  token=0x6000105  System.Int32 OverlapCapsuleNonAllocV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask)
  RVA=0x09E23414  token=0x6000106  System.Int32 OverlapCapsuleNonAllocV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results)
  RVA=0x09E224DC  token=0x6000107  System.Void Internal_RebuildBroadphaseRegions(UnityEngine.Bounds bounds, System.Int32 subdivisions)
  RVA=0x09E256AC  token=0x6000108  System.Void RebuildBroadphaseRegions(UnityEngine.Bounds worldBounds, System.Int32 subdivisions)
  RVA=0x09E1FE1C  token=0x6000109  System.Void BakeMesh(System.Int32 meshID, System.Boolean convex)
  RVA=0x0350B670  token=0x600011A  System.Void .ctor()
  RVA=0x0282FA80  token=0x600011B  System.Void get_gravity_Injected(UnityEngine.Vector3& ret)
  RVA=0x09E268F4  token=0x600011C  System.Void set_gravity_Injected(UnityEngine.Vector3& value)
  RVA=0x027EDC90  token=0x600011D  System.Void get_defaultPhysicsScene_Injected(UnityEngine.PhysicsScene& ret)
  RVA=0x09E223C4  token=0x600011E  System.Void Internal_RaycastTestV2_Injected(UnityEngine.ECSColliderResultProxy& collider, UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
  RVA=0x09E22338  token=0x600011F  UnityEngine.RaycastHit[] Internal_RaycastAll_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Ray& ray, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E242C4  token=0x6000120  UnityEngine.RaycastHit[] Query_CapsuleCastAll_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E24820  token=0x6000121  UnityEngine.RaycastHit[] Query_SphereCastAll_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& origin, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E238F4  token=0x6000122  UnityEngine.Collider[] OverlapCapsule_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E23740  token=0x6000123  UnityEngine.ECSColliderResultProxy[] OverlapCapsuleV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E2404C  token=0x6000124  UnityEngine.Collider[] OverlapSphere_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E23EEC  token=0x6000125  UnityEngine.ECSColliderResultProxy[] OverlapSphereV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x02F50AD0  token=0x6000126  System.Void Simulate_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, System.Single step)
  RVA=0x09E246D4  token=0x6000127  System.Boolean Query_ComputePenetration_Injected(UnityEngine.Collider colliderA, UnityEngine.Vector3& positionA, UnityEngine.Quaternion& rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x02B2D850  token=0x6000128  System.Boolean Query_ComputePenetrationV2_Injected(UnityEngine.ECSColliderResultProxy& colliderA, UnityEngine.Vector3& positionA, UnityEngine.Quaternion& rotationA, UnityEngine.ECSColliderResultProxy& colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x09E24624  token=0x6000129  System.Boolean Query_ComputeCapsulePenetration_Injected(UnityEngine.Vector3& point1, UnityEngine.Vector3& point2, System.Single radius, UnityEngine.Collider colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x09E24574  token=0x600012A  System.Boolean Query_ComputeCapsulePenetrationV2_Injected(UnityEngine.Vector3& point1, UnityEngine.Vector3& point2, System.Single radius, UnityEngine.ECSColliderResultProxy& colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x09E24784  token=0x600012B  System.Boolean Query_ComputeSpherePenetrationV2_Injected(UnityEngine.Vector3& center, System.Single radius, UnityEngine.ECSColliderResultProxy& colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x09E244C4  token=0x600012C  System.Boolean Query_ComputeBoxPenetrationV2_Injected(UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtent, UnityEngine.Quaternion& rotationA, UnityEngine.ECSColliderResultProxy& colliderB, UnityEngine.Vector3& positionB, UnityEngine.Quaternion& rotationB, UnityEngine.Vector3& direction, System.Single& distance)
  RVA=0x09E24420  token=0x600012D  System.Void Query_ClosestPoint_Injected(UnityEngine.Collider collider, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& point, UnityEngine.Vector3& ret)
  RVA=0x09E2437C  token=0x600012E  System.Void Query_ClosestPointV2_Injected(UnityEngine.ECSColliderResultProxy& colliderProxy, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& point, UnityEngine.Vector3& ret)
  RVA=0x09E248C4  token=0x600012F  System.Void Query_TryGetClosestPoint_Injected(UnityEngine.ECSColliderResultProxy& colliderProxy, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& point, System.Boolean& resultIsValid, UnityEngine.Vector3& ret)
  RVA=0x09E26330  token=0x6000130  System.Void get_clothGravity_Injected(UnityEngine.Vector3& ret)
  RVA=0x09E26794  token=0x6000131  System.Void set_clothGravity_Injected(UnityEngine.Vector3& value)
  RVA=0x09E21944  token=0x6000132  System.Boolean CheckSphere_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x034F0100  token=0x6000133  System.Boolean CheckCapsule_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& start, UnityEngine.Vector3& end, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E21670  token=0x6000134  System.Boolean CheckBox_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Quaternion& orientation, System.Int32 layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E23044  token=0x6000135  UnityEngine.Collider[] OverlapBox_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Quaternion& orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E22E08  token=0x6000136  UnityEngine.ECSColliderResultProxy[] OverlapBoxV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Quaternion& orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E22280  token=0x6000137  UnityEngine.RaycastHit[] Internal_BoxCastAll_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Vector3& direction, UnityEngine.Quaternion& orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E2249C  token=0x6000138  System.Void Internal_RebuildBroadphaseRegions_Injected(UnityEngine.Bounds& bounds, System.Int32 subdivisions)
END_CLASS

CLASS: UnityEngine.ModifiableContactPair
TYPE:  sealed struct
TOKEN: 0x200000F
SIZE:  0x78
FIELDS:
  private           System.IntPtr                   actor  // 0x10
  private           System.IntPtr                   otherActor  // 0x18
  private           System.IntPtr                   shape  // 0x20
  private           System.IntPtr                   otherShape  // 0x28
  public            UnityEngine.Quaternion          rotation  // 0x30
  public            UnityEngine.Vector3             position  // 0x40
  public            UnityEngine.Quaternion          otherRotation  // 0x4c
  public            UnityEngine.Vector3             otherPosition  // 0x5c
  private           System.Int32                    numContacts  // 0x68
  private           System.IntPtr                   contacts  // 0x70
METHODS:
END_CLASS

CLASS: UnityEngine.PhysicMaterial
TYPE:  class
TOKEN: 0x2000010
SIZE:  0x18
EXTENDS: UnityEngine.Object
FIELDS:
METHODS:
  RVA=0x09E1EDC4  token=0x6000139  System.Void .ctor()
  RVA=0x09E1ED80  token=0x600013A  System.Void Internal_CreateDynamicsMaterial(UnityEngine.PhysicMaterial mat, System.String name)
END_CLASS

CLASS: UnityEngine.ECSColliderResultProxy
TYPE:  sealed struct
TOKEN: 0x2000011
SIZE:  0x28
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           System.IntPtr                   m_Actor  // 0x10
  private           System.Int32                    m_EcsId  // 0x18
  private           System.UInt32                   m_EcsVersion  // 0x1c
  private           System.Int32                    m_Collider  // 0x20
  private           System.Int32                    m_ComponentIndex  // 0x24
  private   static readonly UnityEngine.ECSColliderResultProxyINVALID_PROXY  // static @ 0x0
PROPERTIES:
  componentIndex  get=0x03D4FB00
  colliderEntity  get=0x038A92F0
  ecsId  get=0x03D68070
  ecsVersion  get=0x03D682F0
  invalid  get=0x09E1D3FC
  collider  get=0x027EBAB0
  colliderInstanceId  get=0x03D85B00
  bIsECS  get=0x027EC5F0
  tagConfig  get=0x02351D80
  isTrigger  get=0x09E1D460
  layer  get=0x02B334B0
  transform  get=0x02B34130
  transformPosition  get=0x02B2EB30
  transformRotation  get=0x02B2ECA0
  transformLossyScale  get=0x09E1D580
  shapePosition  get=0x0301EFB0
  bounds  get=0x03271780
  colliderOptions  get=0x027EC8B0
  surfaceType  get=0x02FA3070
  colliderType  get=0x09E1D2A0
  gameObject  get=0x02B2FBB0
  hasComplexMesh  get=0x027EAB90
METHODS:
  RVA=0x027EBDA0  token=0x600013B  System.Void SetColliderAndSetIndex(System.Int32 colliderInstanceID)
  RVA=0x03D595B0  token=0x600013C  System.Void SetComponentIndex(System.Int32 index)
  RVA=0x03D51730  token=0x600013D  System.Void SetActor(System.IntPtr actor)
  RVA=0x03D51710  token=0x600013E  System.Void SetEcsId(System.Int32 id)
  RVA=0x03D55690  token=0x600013F  System.Void SetEcsVersion(System.UInt32 version)
  RVA=0x027EC610  token=0x6000149  System.Boolean IsValid()
  RVA=0x09E1CF68  token=0x6000154  System.String GetColliderGoName()
  RVA=0x027E5B60  token=0x6000157  System.Int32 GetFactoryBuildingIdentifier()
  RVA=0x09E1D188  token=0x6000159  System.Boolean TryGetClosestPoint(UnityEngine.Vector3 point, UnityEngine.Vector3& result)
  RVA=0x09E1CC14  token=0x600015A  UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 position)
  RVA=0x09E1D028  token=0x600015B  System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance)
  RVA=0x09E1D688  token=0x600015C  System.Boolean op_Equality(UnityEngine.ECSColliderResultProxy left, UnityEngine.ECSColliderResultProxy right)
  RVA=0x0240A950  token=0x600015D  System.Boolean op_Inequality(UnityEngine.ECSColliderResultProxy left, UnityEngine.ECSColliderResultProxy right)
  RVA=0x0354DDA0  token=0x600015E  System.Boolean Equals(UnityEngine.ECSColliderResultProxy other)
  RVA=0x09E1CEC4  token=0x600015F  System.Boolean Equals(System.Object obj)
  RVA=0x033018D0  token=0x6000160  System.Int32 GetHashCode()
  RVA=0x09E1CD60  token=0x6000161  System.Boolean CompareTag(System.Int32 tagValue)
  RVA=0x02B34330  token=0x6000162  System.Boolean IsSameCollider(UnityEngine.Collider otherCollider)
  RVA=0x03D2D040  token=0x6000163  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.RaycastHit
TYPE:  sealed struct
TOKEN: 0x2000012
SIZE:  0x50
FIELDS:
  private           UnityEngine.Vector3             m_Point  // 0x10
  private           UnityEngine.Vector3             m_Normal  // 0x1c
  private           System.UInt32                   m_FaceID  // 0x28
  private           System.Single                   m_Distance  // 0x2c
  private           UnityEngine.Vector2             m_UV  // 0x30
  private           System.Int32                    m_Collider  // 0x38
  private           System.Int32                    m_Index  // 0x3c
  private           System.Int32                    m_EcsId  // 0x40
  private           System.UInt32                   m_EcsVersion  // 0x44
  private           System.IntPtr                   m_Actor  // 0x48
PROPERTIES:
  ecsId  get=0x03D85A80
  ecsVersion  get=0x03D85A10
  IsECSCollider  get=0x027E5B40
  collider  get=0x032E3150
  colliderInstanceID  get=0x03D86D30
  editorCollider  get=0x09E26C3C
  colliderProxy  get=0x027EBB50
  point  get=0x03D85920  set=0x03D56570
  normal  get=0x03D85900  set=0x03D56580
  barycentricCoordinate  get=0x03D87FE0  set=0x09E271E8
  distance  get=0x03D87EB0  set=0x03D4F120
  triangleIndex  get=0x03D68AE0
  componentIndex  get=0x03D88010
  textureCoord  get=0x09E270C8
  textureCoord2  get=0x09E27068
  transform  get=0x09E27124
  shapePosition  get=0x09E26FE0
  shapeRotation  get=0x09E27020
  position  get=0x09E26E38
  rotation  get=0x09E26EFC
  scale  get=0x09E26F28
  rigidbody  get=0x09E26E6C
  articulationBody  get=0x09E26BAC
  lightmapCoord  get=0x09E26CCC
  textureCoord1  get=0x09E27058
METHODS:
  RVA=0x09E26B60  token=0x6000175  UnityEngine.Vector2 CalculateRaycastTexCoord(UnityEngine.Collider collider, System.Int32 m_Index, UnityEngine.Vector2 uv, UnityEngine.Vector3 pos, System.UInt32 face, System.Int32 textcoord)
  RVA=0x09E26B00  token=0x6000182  System.Void CalculateRaycastTexCoord_Injected(UnityEngine.Collider collider, System.Int32 m_Index, UnityEngine.Vector2& uv, UnityEngine.Vector3& pos, System.UInt32 face, System.Int32 textcoord, UnityEngine.Vector2& ret)
END_CLASS

CLASS: UnityEngine.Rigidbody
TYPE:  class
TOKEN: 0x2000013
SIZE:  0x18
EXTENDS: UnityEngine.Component
FIELDS:
PROPERTIES:
  velocity  get=0x0282DAF0  set=0x09E28A68
  angularVelocity  get=0x0282CFE0  set=0x09E28540
  drag  get=0x0282DB70  set=0x09E28670
  angularDrag  get=0x09E27F28  set=0x09E284B8
  mass  get=0x09E281E4  set=0x09E287E8
  useGravity  get=0x09E28414  set=0x09E289E0
  maxDepenetrationVelocity  get=0x09E2824C  set=0x09E28870
  isKinematic  get=0x09E281B0  set=0x0282CDF0
  freezeRotation  get=0x09E28068  set=0x09E286B4
  constraints  get=0x09E28000  set=0x09E285EC
  collisionDetectionMode  get=0x09E27FCC  set=0x09E285AC
  centerOfMass  get=0x09E27FA0  set=0x09E28598
  worldCenterOfMass  get=0x09E2848C
  inertiaTensorRotation  get=0x09E280E0  set=0x09E2873C
  inertiaTensor  get=0x09E28150  set=0x09E28794
  detectCollisions  get=0x09E28034  set=0x09E2862C
  position  get=0x09E282C4  set=0x04273A90
  rotation  get=0x09E28334  set=0x09E288F8
  interpolation  get=0x09E2817C  set=0x09E287A8
  solverIterations  get=0x09E283A0  set=0x09E28958
  sleepThreshold  get=0x09E28360  set=0x09E2890C
  maxAngularVelocity  get=0x09E28218  set=0x09E2882C
  solverVelocityIterations  get=0x09E283E0  set=0x09E289A0
  sleepVelocity  get=0x03D85FA0  set=0x0350B670
  sleepAngularVelocity  get=0x03D85FA0  set=0x0350B670
  useConeFriction  get=0x03D4E3A0  set=0x0350B670
  solverIterationCount  get=0x09E28394  set=0x09E28950
  solverVelocityIterationCount  get=0x09E283D4  set=0x09E28998
METHODS:
  RVA=0x09E27B14  token=0x600018D  System.Void SetDensity(System.Single density)
  RVA=0x09E27A40  token=0x60001AF  System.Void MovePosition(UnityEngine.Vector3 position)
  RVA=0x09E27A98  token=0x60001B0  System.Void MoveRotation(UnityEngine.Quaternion rot)
  RVA=0x09E27B60  token=0x60001B1  System.Void Sleep()
  RVA=0x0282D4D0  token=0x60001B2  System.Boolean IsSleeping()
  RVA=0x09E27EF4  token=0x60001B3  System.Void WakeUp()
  RVA=0x09E27AAC  token=0x60001B4  System.Void ResetCenterOfMass()
  RVA=0x09E27AE0  token=0x60001B5  System.Void ResetInertiaTensor()
  RVA=0x09E278D0  token=0x60001B6  UnityEngine.Vector3 GetRelativePointVelocity(UnityEngine.Vector3 relativePoint)
  RVA=0x09E27848  token=0x60001B7  UnityEngine.Vector3 GetPointVelocity(UnityEngine.Vector3 worldPoint)
  RVA=0x09E27484  token=0x60001BA  System.Void AddForce(UnityEngine.Vector3 force, UnityEngine.ForceMode mode)
  RVA=0x09E27458  token=0x60001BB  System.Void AddForce(UnityEngine.Vector3 force)
  RVA=0x09E2742C  token=0x60001BC  System.Void AddForce(System.Single x, System.Single y, System.Single z, UnityEngine.ForceMode mode)
  RVA=0x09E27498  token=0x60001BD  System.Void AddForce(System.Single x, System.Single y, System.Single z)
  RVA=0x09E27568  token=0x60001BE  System.Void AddRelativeForce(UnityEngine.Vector3 force, UnityEngine.ForceMode mode)
  RVA=0x09E27514  token=0x60001BF  System.Void AddRelativeForce(UnityEngine.Vector3 force)
  RVA=0x09E2757C  token=0x60001C0  System.Void AddRelativeForce(System.Single x, System.Single y, System.Single z, UnityEngine.ForceMode mode)
  RVA=0x09E27540  token=0x60001C1  System.Void AddRelativeForce(System.Single x, System.Single y, System.Single z)
  RVA=0x09E27704  token=0x60001C2  System.Void AddTorque(UnityEngine.Vector3 torque, UnityEngine.ForceMode mode)
  RVA=0x09E276D8  token=0x60001C3  System.Void AddTorque(UnityEngine.Vector3 torque)
  RVA=0x09E27740  token=0x60001C4  System.Void AddTorque(System.Single x, System.Single y, System.Single z, UnityEngine.ForceMode mode)
  RVA=0x09E27718  token=0x60001C5  System.Void AddTorque(System.Single x, System.Single y, System.Single z)
  RVA=0x09E27654  token=0x60001C6  System.Void AddRelativeTorque(UnityEngine.Vector3 torque, UnityEngine.ForceMode mode)
  RVA=0x09E27628  token=0x60001C7  System.Void AddRelativeTorque(UnityEngine.Vector3 torque)
  RVA=0x09E275FC  token=0x60001C8  System.Void AddRelativeTorque(System.Single x, System.Single y, System.Single z, UnityEngine.ForceMode mode)
  RVA=0x09E27668  token=0x60001C9  System.Void AddRelativeTorque(System.Single x, System.Single y, System.Single z)
  RVA=0x09E27378  token=0x60001CA  System.Void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position, UnityEngine.ForceMode mode)
  RVA=0x09E27390  token=0x60001CB  System.Void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position)
  RVA=0x09E272E8  token=0x60001CC  System.Void AddExplosionForce(System.Single explosionForce, UnityEngine.Vector3 explosionPosition, System.Single explosionRadius, System.Single upwardsModifier, UnityEngine.ForceMode mode)
  RVA=0x09E272A8  token=0x60001CD  System.Void AddExplosionForce(System.Single explosionForce, UnityEngine.Vector3 explosionPosition, System.Single explosionRadius, System.Single upwardsModifier)
  RVA=0x09E2726C  token=0x60001CE  System.Void AddExplosionForce(System.Single explosionForce, UnityEngine.Vector3 explosionPosition, System.Single explosionRadius)
  RVA=0x09E27968  token=0x60001CF  System.Void Internal_ClosestPointOnBounds(UnityEngine.Vector3 point, UnityEngine.Vector3& outPos, System.Single& distance)
  RVA=0x09E2776C  token=0x60001D0  UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Vector3 position)
  RVA=0x09E27D54  token=0x60001D1  UnityEngine.RaycastHit SweepTest(UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.Boolean& hasHit)
  RVA=0x09E27E00  token=0x60001D2  System.Boolean SweepTest(UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E27D24  token=0x60001D3  System.Boolean SweepTest(UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance)
  RVA=0x09E27DC8  token=0x60001D4  System.Boolean SweepTest(UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo)
  RVA=0x09E279E4  token=0x60001D5  UnityEngine.RaycastHit[] Internal_SweepTestAll(UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E27BC4  token=0x60001D6  UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E27B94  token=0x60001D7  UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction, System.Single maxDistance)
  RVA=0x09E27C88  token=0x60001D8  UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction)
  RVA=0x09E27B58  token=0x60001DD  System.Void SetMaxAngularVelocity(System.Single a)
  RVA=0x0426FE60  token=0x60001E4  System.Void .ctor()
  RVA=0x0282DB20  token=0x60001E5  System.Void get_velocity_Injected(UnityEngine.Vector3& ret)
  RVA=0x09E28A24  token=0x60001E6  System.Void set_velocity_Injected(UnityEngine.Vector3& value)
  RVA=0x0282CDA0  token=0x60001E7  System.Void get_angularVelocity_Injected(UnityEngine.Vector3& ret)
  RVA=0x09E284FC  token=0x60001E8  System.Void set_angularVelocity_Injected(UnityEngine.Vector3& value)
  RVA=0x09E27F5C  token=0x60001E9  System.Void get_centerOfMass_Injected(UnityEngine.Vector3& ret)
  RVA=0x09E28554  token=0x60001EA  System.Void set_centerOfMass_Injected(UnityEngine.Vector3& value)
  RVA=0x09E28448  token=0x60001EB  System.Void get_worldCenterOfMass_Injected(UnityEngine.Vector3& ret)
  RVA=0x09E2809C  token=0x60001EC  System.Void get_inertiaTensorRotation_Injected(UnityEngine.Quaternion& ret)
  RVA=0x09E286F8  token=0x60001ED  System.Void set_inertiaTensorRotation_Injected(UnityEngine.Quaternion& value)
  RVA=0x09E2810C  token=0x60001EE  System.Void get_inertiaTensor_Injected(UnityEngine.Vector3& ret)
  RVA=0x09E28750  token=0x60001EF  System.Void set_inertiaTensor_Injected(UnityEngine.Vector3& value)
  RVA=0x09E28280  token=0x60001F0  System.Void get_position_Injected(UnityEngine.Vector3& ret)
  RVA=0x034E5160  token=0x60001F1  System.Void set_position_Injected(UnityEngine.Vector3& value)
  RVA=0x09E282F0  token=0x60001F2  System.Void get_rotation_Injected(UnityEngine.Quaternion& ret)
  RVA=0x09E288B4  token=0x60001F3  System.Void set_rotation_Injected(UnityEngine.Quaternion& value)
  RVA=0x09E279FC  token=0x60001F4  System.Void MovePosition_Injected(UnityEngine.Vector3& position)
  RVA=0x09E27A54  token=0x60001F5  System.Void MoveRotation_Injected(UnityEngine.Quaternion& rot)
  RVA=0x09E2787C  token=0x60001F6  System.Void GetRelativePointVelocity_Injected(UnityEngine.Vector3& relativePoint, UnityEngine.Vector3& ret)
  RVA=0x09E277F4  token=0x60001F7  System.Void GetPointVelocity_Injected(UnityEngine.Vector3& worldPoint, UnityEngine.Vector3& ret)
  RVA=0x09E273D8  token=0x60001F8  System.Void AddForce_Injected(UnityEngine.Vector3& force, UnityEngine.ForceMode mode)
  RVA=0x09E274C0  token=0x60001F9  System.Void AddRelativeForce_Injected(UnityEngine.Vector3& force, UnityEngine.ForceMode mode)
  RVA=0x09E27684  token=0x60001FA  System.Void AddTorque_Injected(UnityEngine.Vector3& torque, UnityEngine.ForceMode mode)
  RVA=0x09E275A8  token=0x60001FB  System.Void AddRelativeTorque_Injected(UnityEngine.Vector3& torque, UnityEngine.ForceMode mode)
  RVA=0x09E27314  token=0x60001FC  System.Void AddForceAtPosition_Injected(UnityEngine.Vector3& force, UnityEngine.Vector3& position, UnityEngine.ForceMode mode)
  RVA=0x09E27208  token=0x60001FD  System.Void AddExplosionForce_Injected(System.Single explosionForce, UnityEngine.Vector3& explosionPosition, System.Single explosionRadius, System.Single upwardsModifier, UnityEngine.ForceMode mode)
  RVA=0x09E27904  token=0x60001FE  System.Void Internal_ClosestPointOnBounds_Injected(UnityEngine.Vector3& point, UnityEngine.Vector3& outPos, System.Single& distance)
  RVA=0x09E27CC0  token=0x60001FF  System.Void SweepTest_Injected(UnityEngine.Vector3& direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
  RVA=0x09E27980  token=0x6000200  UnityEngine.RaycastHit[] Internal_SweepTestAll_Injected(UnityEngine.Vector3& direction, System.Single maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
END_CLASS

CLASS: UnityEngine.ECSColliderType
TYPE:  sealed struct
TOKEN: 0x2000014
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ECSColliderType     Default  // const
  public    static  UnityEngine.ECSColliderType     BoxCollider  // const
  public    static  UnityEngine.ECSColliderType     CapsuleCollider  // const
  public    static  UnityEngine.ECSColliderType     SphereCollider  // const
  public    static  UnityEngine.ECSColliderType     MeshCollider  // const
  public    static  UnityEngine.ECSColliderType     MultiCollider  // const
  public    static  UnityEngine.ECSColliderType     TerrainCollider  // const
  public    static  UnityEngine.ECSColliderType     ECSCollider  // const
  public    static  UnityEngine.ECSColliderType     Invalid  // const
METHODS:
END_CLASS

CLASS: UnityEngine.Collider
TYPE:  class
TOKEN: 0x2000015
SIZE:  0x18
EXTENDS: UnityEngine.Component
FIELDS:
PROPERTIES:
  enabled  get=0x02B2EE10  set=0x02833E20
  attachedRigidbody  get=0x09E1C658
  attachedArticulationBody  get=0x09E1C624
  isTrigger  get=0x0282CBA0  set=0x02B94E10
  enableDither  get=0x09E1C734
  contactOffset  get=0x09E1C700  set=0x09E1C86C
  bounds  get=0x09E1C6D0
  hasModifiableContacts  get=0x09E1C768  set=0x09E1C8B0
  surfaceType  get=0x09E1C804  set=0x09E1C938
  tagConfig  get=0x09E1C838  set=0x09E1C978
  colliderOptions  get=0x02B93D40  set=0x02B952A0
  sharedMaterial  get=0x09E1C7D0  set=0x09E1C8F4
  material  get=0x09E1C79C  set=0x02B40D20
METHODS:
  RVA=0x09E1C2D0  token=0x600020A  UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 position)
  RVA=0x0270A950  token=0x6000214  System.IntPtr GetActor()
  RVA=0x03300880  token=0x6000215  System.Int32 GetComponentIndex()
  RVA=0x09E1C304  token=0x6000216  System.Int32 GetFactoryBuildingIdentifier()
  RVA=0x09E1C4F0  token=0x6000217  System.Void SetFactoryBuildingIdentifier(System.Int32 value)
  RVA=0x09E1C418  token=0x600021C  UnityEngine.RaycastHit Raycast(UnityEngine.Ray ray, System.Single maxDistance, System.Boolean& hasHit)
  RVA=0x09E1C47C  token=0x600021D  System.Boolean Raycast(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance)
  RVA=0x09E1C39C  token=0x600021E  System.Void Internal_ClosestPointOnBounds(UnityEngine.Vector3 point, UnityEngine.Vector3& outPos, System.Single& distance)
  RVA=0x09E1C1F4  token=0x600021F  UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Vector3 position)
  RVA=0x09E1C1C0  token=0x6000220  System.Boolean CanColliderComputeClosestPoint()
  RVA=0x09E1C594  token=0x6000221  UnityEngine.Vector3 TryGetClosestPoint_Internal(UnityEngine.Vector3 point, System.Boolean& resultIsValid)
  RVA=0x09E1C5D0  token=0x6000222  System.Boolean TryGetClosestPoint(UnityEngine.Vector3 point, UnityEngine.Vector3& result)
  RVA=0x0426FE60  token=0x6000223  System.Void .ctor()
  RVA=0x09E1C27C  token=0x6000224  System.Void ClosestPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Vector3& ret)
  RVA=0x09E1C68C  token=0x6000225  System.Void get_bounds_Injected(UnityEngine.Bounds& ret)
  RVA=0x09E1C3B4  token=0x6000226  System.Void Raycast_Injected(UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
  RVA=0x09E1C338  token=0x6000227  System.Void Internal_ClosestPointOnBounds_Injected(UnityEngine.Vector3& point, UnityEngine.Vector3& outPos, System.Single& distance)
  RVA=0x09E1C530  token=0x6000228  System.Void TryGetClosestPoint_Internal_Injected(UnityEngine.Vector3& point, System.Boolean& resultIsValid, UnityEngine.Vector3& ret)
END_CLASS

CLASS: UnityEngine.ECSCollider
TYPE:  class
TOKEN: 0x2000016
SIZE:  0x18
FIELDS:
  private           System.IntPtr                   self  // 0x10
  public    static  UnityEngine.ECSCollider.CollisionCallbackcollisionEnterCallback  // static @ 0x0
  public    static  UnityEngine.ECSCollider.CollisionCallbackcollisionStayCallback  // static @ 0x8
  public    static  UnityEngine.ECSCollider.CollisionCallbackcollisionExitCallback  // static @ 0x10
  public    static  UnityEngine.ECSCollider.CollisionCallbacktriggerEnterCallback  // static @ 0x18
  public    static  UnityEngine.ECSCollider.CollisionCallbacktriggerStayCallback  // static @ 0x20
  public    static  UnityEngine.ECSCollider.CollisionCallbacktriggerExitCallback  // static @ 0x28
METHODS:
  RVA=0x09E1DB24  token=0x6000229  System.IntPtr CreateActor(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.UInt32 layer, System.Int32 tagInt, System.Boolean movable)
  RVA=0x09E1DB44  token=0x600022A  System.Void DestroyActor(System.Int32 id, System.UInt32 version)
  RVA=0x02769F70  token=0x600022B  System.IntPtr Decode(System.IntPtr data, System.Int32 length, System.IntPtr meshes, System.Int32 meshesCount, UnityEngine.Texture2D heightmaps)
  RVA=0x02769ED0  token=0x600022C  System.IntPtr Decode(System.IntPtr data, System.Int32 length, Unity.Collections.NativeArray<System.Int32> meshInstanceIds, UnityEngine.Texture2D heightmap)
  RVA=0x09E1E290  token=0x600022D  System.Void RecordEntity(System.IntPtr actor, UnityEngine.HyperGryph.ECS.Entity entity)
  RVA=0x0276A110  token=0x600022E  System.Int32 GetId(System.IntPtr actor)
  RVA=0x0276A150  token=0x600022F  System.UInt32 GetVersion(System.IntPtr actor)
  RVA=0x027EC850  token=0x6000230  System.Boolean IsValid(System.Int32 id, System.UInt32 version, System.IntPtr actor)
  RVA=0x038A9300  token=0x6000231  UnityEngine.HyperGryph.ECS.Entity GetEntity(System.Int32 id, System.UInt32 version)
  RVA=0x02B2E180  token=0x6000232  UnityEngine.Vector3 GetPosition(System.Int32 ecsId, System.UInt32 ecsVersion)
  RVA=0x0301F140  token=0x6000233  UnityEngine.Vector3 GetShapePosition(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index)
  RVA=0x04272040  token=0x6000234  System.Void SetPosition(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 position)
  RVA=0x09E1DC34  token=0x6000235  UnityEngine.Quaternion GetShapeRotation(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index)
  RVA=0x02B2E150  token=0x6000236  UnityEngine.Quaternion GetRotation(System.Int32 ecsId, System.UInt32 ecsVersion)
  RVA=0x04272054  token=0x6000237  System.Void SetRotation(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Quaternion rotation)
  RVA=0x09E1D778  token=0x6000238  System.Void AttachBox(System.Int32 id, System.UInt32 version, UnityEngine.Vector3 halfExtent, UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotation, System.Int32 surfaceType, System.Int32 colliderOption, System.Int32 tag, System.Boolean isTrigger, System.Boolean isPrimitive)
  RVA=0x027EAC40  token=0x6000239  System.Boolean HasComplexMesh(System.Int32 id, System.UInt32 version)
  RVA=0x09E1E190  token=0x600023A  UnityEngine.RaycastHit Raycast_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit)
  RVA=0x09E1E204  token=0x600023B  System.Boolean Raycast(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, UnityEngine.RaycastHit& hitInfo)
  RVA=0x09E1E030  token=0x600023C  UnityEngine.RaycastHit RaycastComplexMesh_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit)
  RVA=0x09E1E0A4  token=0x600023D  System.Boolean RaycastComplexMesh(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, UnityEngine.RaycastHit& hitInfo)
  RVA=0x09E1D878  token=0x600023E  UnityEngine.RaycastHit CapsuleCastComplexMesh_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Boolean& hasHit)
  RVA=0x09E1D914  token=0x600023F  System.Boolean CapsuleCastComplexMesh(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo)
  RVA=0x09E1E30C  token=0x6000240  UnityEngine.RaycastHit SphereCastComplexMesh_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 center, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Boolean& hasHit)
  RVA=0x09E1E398  token=0x6000241  System.Boolean SphereCastComplexMesh(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 center, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo)
  RVA=0x09E1D7D8  token=0x6000242  System.Boolean CanColliderComputeClosestPoint(System.Int32 ecsId, System.UInt32 ecsVersion)
  RVA=0x02FA3100  token=0x6000243  UnityEngine.ColliderSurfaceType GetSurfaceTypeAt(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index)
  RVA=0x027ECA20  token=0x6000244  System.Int32 GetColliderOptionAt(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index)
  RVA=0x02351E50  token=0x6000245  System.Int32 GetTagConfigAt(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index)
  RVA=0x09E1DB84  token=0x6000246  System.Boolean GetIsTrigger(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index)
  RVA=0x03271870  token=0x6000247  UnityEngine.Bounds GetBounds(System.Int32 ecsId, System.UInt32 ecsVersion)
  RVA=0x09E1E4A8  token=0x6000248  UnityEngine.Vector3 TryGetClosestPoint_Internal(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 point, System.Boolean& resultIsValid)
  RVA=0x09E1E4E8  token=0x6000249  System.Boolean TryGetClosestPoint(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 point, UnityEngine.Vector3& result)
  RVA=0x09E1DA34  token=0x600024A  UnityEngine.Vector3 ClosestPoint(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3 position)
  RVA=0x09E1DA70  token=0x600024B  System.Boolean CompareTag(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 tagValue)
  RVA=0x02B335F0  token=0x600024C  System.Int32 GetLayer(System.Int32 ecsId, System.UInt32 ecsVersion)
  RVA=0x027E5BE0  token=0x600024D  System.Int32 GetFactoryBuildingIdentifier(System.Int32 ecsId, System.UInt32 ecsVersion)
  RVA=0x032F4ED0  token=0x600024E  System.Void SetFactoryBuildingIdentifier(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 identifier)
  RVA=0x09E1DC70  token=0x600024F  System.Void OnCollisionEnterV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider)
  RVA=0x09E1DD90  token=0x6000250  System.Void OnCollisionStayV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider)
  RVA=0x09E1DD00  token=0x6000251  System.Void OnCollisionExitV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider)
  RVA=0x09E1DE20  token=0x6000252  System.Void OnTriggerEnterV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider)
  RVA=0x09E1DF40  token=0x6000253  System.Void OnTriggerStayV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider)
  RVA=0x09E1DEB0  token=0x6000254  System.Void OnTriggerExitV2(UnityEngine.ECSColliderResultProxy thisCollider, UnityEngine.ECSColliderResultProxy otherCollider)
  RVA=0x0294A580  token=0x6000255  System.Void ToggleCollision(System.Int32 id, System.UInt32 version, System.Boolean enableCollision)
  RVA=0x09E1DAC0  token=0x6000256  System.IntPtr CreateActor_Injected(UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, System.UInt32 layer, System.Int32 tagInt, System.Boolean movable)
  RVA=0x03334210  token=0x6000257  System.Void RecordEntity_Injected(System.IntPtr actor, UnityEngine.HyperGryph.ECS.Entity& entity)
  RVA=0x038A9360  token=0x6000258  System.Void GetEntity_Injected(System.Int32 id, System.UInt32 version, UnityEngine.HyperGryph.ECS.Entity& ret)
  RVA=0x02B2E090  token=0x6000259  System.Void GetPosition_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& ret)
  RVA=0x0301F180  token=0x600025A  System.Void GetShapePosition_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index, UnityEngine.Vector3& ret)
  RVA=0x031E7090  token=0x600025B  System.Void SetPosition_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& position)
  RVA=0x09E1DBD4  token=0x600025C  System.Void GetShapeRotation_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, System.Int32 index, UnityEngine.Quaternion& ret)
  RVA=0x02B2E0F0  token=0x600025D  System.Void GetRotation_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Quaternion& ret)
  RVA=0x031E7030  token=0x600025E  System.Void SetRotation_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Quaternion& rotation)
  RVA=0x09E1D718  token=0x600025F  System.Void AttachBox_Injected(System.Int32 id, System.UInt32 version, UnityEngine.Vector3& halfExtent, UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation, System.Int32 surfaceType, System.Int32 colliderOption, System.Int32 tag, System.Boolean isTrigger, System.Boolean isPrimitive)
  RVA=0x09E1E130  token=0x6000260  System.Void Raycast_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
  RVA=0x09E1DFD0  token=0x6000261  System.Void RaycastComplexMesh_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
  RVA=0x09E1D818  token=0x6000262  System.Void CapsuleCastComplexMesh_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
  RVA=0x09E1E2AC  token=0x6000263  System.Void SphereCastComplexMesh_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& center, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
  RVA=0x032718B0  token=0x6000264  System.Void GetBounds_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Bounds& ret)
  RVA=0x09E1E448  token=0x6000265  System.Void TryGetClosestPoint_Internal_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& point, System.Boolean& resultIsValid, UnityEngine.Vector3& ret)
  RVA=0x09E1D9D4  token=0x6000266  System.Void ClosestPoint_Injected(System.Int32 ecsId, System.UInt32 ecsVersion, UnityEngine.Vector3& position, UnityEngine.Vector3& ret)
END_CLASS

CLASS: UnityEngine.CharacterController
TYPE:  class
TOKEN: 0x2000018
SIZE:  0x18
EXTENDS: UnityEngine.Collider
FIELDS:
PROPERTIES:
  isGrounded  get=0x09E1C18C
METHODS:
END_CLASS

CLASS: UnityEngine.MultiCollider
TYPE:  class
TOKEN: 0x2000019
SIZE:  0x18
EXTENDS: UnityEngine.Collider
FIELDS:
PROPERTIES:
  ComplexMesh  get=0x09E1ED4C
METHODS:
  RVA=0x09E1E724  token=0x600026A  System.Void AppendBoxCollider(UnityEngine.BoxCollider boxCollider)
  RVA=0x09E1E768  token=0x600026B  System.Void AppendCapsuleCollider(UnityEngine.CapsuleCollider collider)
  RVA=0x09E1E7AC  token=0x600026C  System.Void AppendSphereCollider(UnityEngine.SphereCollider collider)
  RVA=0x09E1EA7C  token=0x600026D  UnityEngine.ColliderSurfaceType GetSurfaceTypeAt(System.Int32 index)
  RVA=0x09E1EABC  token=0x600026E  System.Int32 GetTagConfigAt(System.Int32 index)
  RVA=0x09E1E9FC  token=0x600026F  System.Int32 GetGameplayOptionAt(System.Int32 index)
  RVA=0x09E1EA3C  token=0x6000270  System.Boolean GetIsTriggerAt(System.Int32 index)
  RVA=0x09E1EB78  token=0x6000271  System.Void SetGameplayOptionAt(System.Int32 index, System.Int32 value)
  RVA=0x09E1E994  token=0x6000272  System.Void Flush()
  RVA=0x09E1EB60  token=0x6000274  System.Boolean RaycastComplexMesh(UnityEngine.Ray ray, System.Single maxDistance, UnityEngine.RaycastHit& hit)
  RVA=0x09E1E854  token=0x6000275  UnityEngine.RaycastHit CapsuleCastComplexMesh_Internal(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Boolean& hasHit)
  RVA=0x09E1E8E4  token=0x6000276  System.Boolean CapsuleCastComplexMesh(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hit)
  RVA=0x09E1EC2C  token=0x6000277  UnityEngine.RaycastHit SphereCastComplexMesh_Internal(UnityEngine.Vector3 center, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, System.Boolean& hasHit)
  RVA=0x09E1ECAC  token=0x6000278  System.Boolean SphereCastComplexMesh(UnityEngine.Vector3 center, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hit)
  RVA=0x09E1E9C8  token=0x6000279  System.Int32 GetCountWithoutComplexMesh()
  RVA=0x09E1EAFC  token=0x600027A  System.Boolean RaycastComplexMesh_Injected(UnityEngine.Ray& ray, System.Single maxDistance, UnityEngine.RaycastHit& hit)
  RVA=0x09E1E7F0  token=0x600027B  System.Void CapsuleCastComplexMesh_Internal_Injected(UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
  RVA=0x09E1EBC8  token=0x600027C  System.Void SphereCastComplexMesh_Internal_Injected(UnityEngine.Vector3& center, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, System.Boolean& hasHit, UnityEngine.RaycastHit& ret)
END_CLASS

CLASS: UnityEngine.MeshCollider
TYPE:  class
TOKEN: 0x200001A
SIZE:  0x18
EXTENDS: UnityEngine.Collider
FIELDS:
PROPERTIES:
  sharedMesh  get=0x09E1E66C  set=0x03012920
  convex  get=0x09E1E604  set=0x09E1E6A0
  cookingOptions  get=0x09E1E638  set=0x09E1E6E4
  smoothSphereCollisions  get=0x03D663A0  set=0x0350B670
  skinWidth  get=0x03D85FA0  set=0x0350B670
  inflateMesh  get=0x03D4E3A0  set=0x0350B670
METHODS:
  RVA=0x09E1E5D0  token=0x6000283  System.Boolean NeedsReadWriteEnabled()
  RVA=0x0426FE60  token=0x600028A  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.CapsuleCollider
TYPE:  class
TOKEN: 0x200001B
SIZE:  0x18
EXTENDS: UnityEngine.Collider
FIELDS:
PROPERTIES:
  center  get=0x02A126C0  set=0x04272BA4
  radius  get=0x02A12F70  set=0x02B40C30
  height  get=0x02A12FB0  set=0x02B40C80
  direction  get=0x02A12F30  set=0x02B40CD0
METHODS:
  RVA=0x02A12720  token=0x6000293  System.Void get_center_Injected(UnityEngine.Vector3& ret)
  RVA=0x035F5DC0  token=0x6000294  System.Void set_center_Injected(UnityEngine.Vector3& value)
END_CLASS

CLASS: UnityEngine.BoxCollider
TYPE:  class
TOKEN: 0x200001C
SIZE:  0x18
EXTENDS: UnityEngine.Collider
FIELDS:
PROPERTIES:
  center  get=0x09E1BE18  set=0x04272C44
  size  get=0x02B951A0  set=0x04272C30
METHODS:
  RVA=0x09E1BDD4  token=0x6000299  System.Void get_center_Injected(UnityEngine.Vector3& ret)
  RVA=0x02F67710  token=0x600029A  System.Void set_center_Injected(UnityEngine.Vector3& value)
  RVA=0x02B951D0  token=0x600029B  System.Void get_size_Injected(UnityEngine.Vector3& ret)
  RVA=0x02F676C0  token=0x600029C  System.Void set_size_Injected(UnityEngine.Vector3& value)
END_CLASS

CLASS: UnityEngine.SphereCollider
TYPE:  class
TOKEN: 0x200001D
SIZE:  0x18
EXTENDS: UnityEngine.Collider
FIELDS:
PROPERTIES:
  center  get=0x09E28AC0  set=0x09E28B64
  radius  get=0x09E28AEC  set=0x02B93E20
METHODS:
  RVA=0x09E28A7C  token=0x60002A1  System.Void get_center_Injected(UnityEngine.Vector3& ret)
  RVA=0x09E28B20  token=0x60002A2  System.Void set_center_Injected(UnityEngine.Vector3& value)
END_CLASS

CLASS: UnityEngine.Joint
TYPE:  class
TOKEN: 0x200001E
SIZE:  0x18
EXTENDS: UnityEngine.Component
FIELDS:
PROPERTIES:
  connectedBody  get=0x09E1E544
  connectedAnchor  set=0x09E1E5BC
METHODS:
  RVA=0x09E1E578  token=0x60002A5  System.Void set_connectedAnchor_Injected(UnityEngine.Vector3& value)
END_CLASS

CLASS: UnityEngine.ContactPoint
TYPE:  sealed struct
TOKEN: 0x200001F
SIZE:  0x34
FIELDS:
  private           UnityEngine.Vector3             m_Point  // 0x10
  private           UnityEngine.Vector3             m_Normal  // 0x1c
  private           System.Int32                    m_ThisColliderInstanceID  // 0x28
  private           System.Int32                    m_OtherColliderInstanceID  // 0x2c
  private           System.Single                   m_Separation  // 0x30
PROPERTIES:
  point  get=0x03D85920
  normal  get=0x03D85900
  thisCollider  get=0x09E1CBE8
  otherCollider  get=0x09E1CBDC
METHODS:
  RVA=0x09E1CBA8  token=0x60002AA  UnityEngine.Collider GetColliderByInstanceID(System.Int32 instanceID)
END_CLASS

CLASS: UnityEngine.PhysicsScene
TYPE:  sealed struct
TOKEN: 0x2000020
SIZE:  0x14
IMPLEMENTS: System.IEquatable`1
FIELDS:
  private           System.Int32                    m_Handle  // 0x10
METHODS:
  RVA=0x09E1FD6C  token=0x60002AB  System.String ToString()
  RVA=0x03D85860  token=0x60002AC  System.Int32 GetHashCode()
  RVA=0x09E1F054  token=0x60002AD  System.Boolean Equals(System.Object other)
  RVA=0x022A9C10  token=0x60002AE  System.Boolean Equals(UnityEngine.PhysicsScene other)
  RVA=0x09E1FC74  token=0x60002AF  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F428  token=0x60002B0  System.Boolean Internal_RaycastTest(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x0238CFE0  token=0x60002B1  System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F450  token=0x60002B2  System.Boolean Internal_Raycast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, System.Single maxDistance, UnityEngine.RaycastHit& hit, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x0238CC80  token=0x60002B3  System.Int32 Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x0426FAB8  token=0x60002B4  System.Int32 Internal_RaycastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1FC14  token=0x60002B5  System.Boolean Query_CapsuleCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F2A4  token=0x60002B6  System.Boolean Internal_CapsuleCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1EFB8  token=0x60002B7  System.Boolean CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x04272A88  token=0x60002B8  System.Int32 Internal_CapsuleCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x02B309D0  token=0x60002B9  System.Int32 CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F244  token=0x60002BA  System.Int32 Internal_CapsuleCastNonAllocV2(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, System.Single radius, UnityEngine.Vector3 diretion, UnityEngine.ECSColliderResultProxy[] proxies, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1EEC4  token=0x60002BB  System.Int32 CapsuleCastV2(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.ECSColliderResultProxy[] proxies, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F794  token=0x60002BC  System.Int32 OverlapCapsuleNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F7D4  token=0x60002BD  System.Int32 OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x04272B3C  token=0x60002BE  System.Int32 OverlapCapsuleNonAlloc_InternalV2(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x02B349D0  token=0x60002BF  System.Int32 OverlapCapsuleV2(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x04271A38  token=0x60002C0  System.Boolean Query_SphereCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x027E7FE0  token=0x60002C1  System.Boolean Internal_SphereCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x027E7F60  token=0x60002C2  System.Boolean SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x04272AE8  token=0x60002C3  System.Int32 Internal_SphereCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x02B328D0  token=0x60002C4  System.Int32 SphereCast(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F9B0  token=0x60002C5  System.Int32 OverlapSphereNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1FA28  token=0x60002C6  System.Int32 OverlapSphere(UnityEngine.Vector3 position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F91C  token=0x60002C7  System.Int32 OverlapSphereNonAllocV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F9E0  token=0x60002C8  System.Int32 OverlapSphereV2(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1FB50  token=0x60002C9  System.Boolean Query_BoxCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDistance, UnityEngine.RaycastHit& outHit, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F0B8  token=0x60002CA  System.Boolean Internal_BoxCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1EE18  token=0x60002CB  System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F588  token=0x60002CC  System.Int32 OverlapBoxNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F63C  token=0x60002CD  System.Int32 OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F4E4  token=0x60002CE  System.Int32 OverlapBoxNonAllocV2_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F5C8  token=0x60002CF  System.Int32 OverlapBoxV2(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion orientation, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x0426FD8C  token=0x60002D0  System.Int32 Internal_BoxCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x02423860  token=0x60002D1  System.Int32 BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F3C4  token=0x60002D2  System.Boolean Internal_RaycastTest_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Ray& ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x02EC0330  token=0x60002D3  System.Boolean Internal_Raycast_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Ray& ray, System.Single maxDistance, UnityEngine.RaycastHit& hit, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x02F62F10  token=0x60002D4  System.Int32 Internal_RaycastNonAlloc_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Ray& ray, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1FBB0  token=0x60002D5  System.Boolean Query_CapsuleCast_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point1, UnityEngine.Vector3& point2, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x0335D620  token=0x60002D6  System.Int32 Internal_CapsuleCastNonAlloc_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F1E0  token=0x60002D7  System.Int32 Internal_CapsuleCastNonAllocV2_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& p0, UnityEngine.Vector3& p1, System.Single radius, UnityEngine.Vector3& diretion, UnityEngine.ECSColliderResultProxy[] proxies, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F730  token=0x60002D8  System.Int32 OverlapCapsuleNonAlloc_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x030CB690  token=0x60002D9  System.Int32 OverlapCapsuleNonAlloc_InternalV2_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& point0, UnityEngine.Vector3& point1, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x0335DAB0  token=0x60002DA  System.Boolean Query_SphereCast_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& origin, System.Single radius, UnityEngine.Vector3& direction, System.Single maxDistance, UnityEngine.RaycastHit& hitInfo, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x02741E00  token=0x60002DB  System.Int32 Internal_SphereCastNonAlloc_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& origin, System.Single radius, UnityEngine.Vector3& direction, UnityEngine.RaycastHit[] raycastHits, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F94C  token=0x60002DC  System.Int32 OverlapSphereNonAlloc_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, UnityEngine.Collider[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F8B8  token=0x60002DD  System.Int32 OverlapSphereNonAllocV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1FAEC  token=0x60002DE  System.Boolean Query_BoxCast_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Vector3& direction, UnityEngine.Quaternion& orientation, System.Single maxDistance, UnityEngine.RaycastHit& outHit, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F524  token=0x60002DF  System.Int32 OverlapBoxNonAlloc_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion& orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x09E1F480  token=0x60002E0  System.Int32 OverlapBoxNonAllocV2_Internal_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.ECSColliderResultProxy[] results, UnityEngine.Quaternion& orientation, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  RVA=0x030FE4F0  token=0x60002E1  System.Int32 Internal_BoxCastNonAlloc_Injected(UnityEngine.PhysicsScene& physicsScene, UnityEngine.Vector3& center, UnityEngine.Vector3& halfExtents, UnityEngine.Vector3& direction, UnityEngine.RaycastHit[] raycastHits, UnityEngine.Quaternion& orientation, System.Single maxDistance, System.Int32 mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
END_CLASS

CLASS: UnityEngine.QueryParameters
TYPE:  sealed struct
TOKEN: 0x2000021
SIZE:  0x1C
FIELDS:
  public            System.Int32                    layerMask  // 0x10
  public            System.Boolean                  hitMultipleFaces  // 0x14
  public            System.Boolean                  hitBackfaces  // 0x15
  public            UnityEngine.QueryTriggerInteractionhitTriggers  // 0x18
METHODS:
  RVA=0x03D87FC0  token=0x60002E2  System.Void .ctor(System.Int32 layerMask, System.Boolean hitMultipleFaces, UnityEngine.QueryTriggerInteraction hitTriggers, System.Boolean hitBackfaces)
END_CLASS

CLASS: UnityEngine.RaycastCommand
TYPE:  sealed struct
TOKEN: 0x2000022
SIZE:  0x3C
FIELDS:
  private           UnityEngine.Vector3             <from>k__BackingField  // 0x10
  private           UnityEngine.Vector3             <direction>k__BackingField  // 0x1c
  private           System.Single                   <distance>k__BackingField  // 0x28
  private           UnityEngine.PhysicsScene        <physicsScene>k__BackingField  // 0x2c
  public            UnityEngine.QueryParameters     queryParameters  // 0x30
PROPERTIES:
  from  get=0x03D56520  set=0x03D56570
  direction  get=0x03D56540  set=0x03D56580
  distance  get=0x03D4EBF0  set=0x03D4EC00
  physicsScene  set=0x03D4EBC0
METHODS:
  RVA=0x03199660  token=0x60002E3  System.Void .ctor(UnityEngine.Vector3 from, UnityEngine.Vector3 direction, UnityEngine.QueryParameters queryParameters, System.Single distance)
  RVA=0x030FF560  token=0x60002EB  Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.RaycastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, System.Int32 minCommandsPerJob, System.Int32 maxHits, Unity.Jobs.JobHandle dependsOn)
  RVA=0x030FF4E0  token=0x60002EC  Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.RaycastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, System.Int32 minCommandsPerJob, Unity.Jobs.JobHandle dependsOn)
  RVA=0x030FF720  token=0x60002ED  Unity.Jobs.JobHandle ScheduleRaycastBatch(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* commands, System.Int32 commandLen, System.Void* result, System.Int32 resultLen, System.Int32 minCommandsPerJob, System.Int32 maxHits)
  RVA=0x030FF7C0  token=0x60002EE  System.Void ScheduleRaycastBatch_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* commands, System.Int32 commandLen, System.Void* result, System.Int32 resultLen, System.Int32 minCommandsPerJob, System.Int32 maxHits, Unity.Jobs.JobHandle& ret)
END_CLASS

CLASS: UnityEngine.BoxcastCommand
TYPE:  sealed struct
TOKEN: 0x2000023
SIZE:  0x58
FIELDS:
  private           UnityEngine.Vector3             <center>k__BackingField  // 0x10
  private           UnityEngine.Vector3             <halfExtents>k__BackingField  // 0x1c
  private           UnityEngine.Quaternion          <orientation>k__BackingField  // 0x28
  private           UnityEngine.Vector3             <direction>k__BackingField  // 0x38
  private           System.Single                   <distance>k__BackingField  // 0x44
  private           UnityEngine.PhysicsScene        <physicsScene>k__BackingField  // 0x48
  public            UnityEngine.QueryParameters     queryParameters  // 0x4c
PROPERTIES:
  center  set=0x03D56570
  halfExtents  set=0x03D56580
  orientation  set=0x03D51D90
  direction  set=0x03D50F50
  distance  set=0x03D56CB0
  physicsScene  set=0x03D4ECB0
METHODS:
  RVA=0x09E1C118  token=0x60002EF  System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.Vector3 direction, UnityEngine.QueryParameters queryParameters, System.Single distance)
  RVA=0x09E1BEB8  token=0x60002F6  Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.BoxcastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, System.Int32 minCommandsPerJob, System.Int32 maxHits, Unity.Jobs.JobHandle dependsOn)
  RVA=0x09E1BE44  token=0x60002F7  Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.BoxcastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, System.Int32 minCommandsPerJob, Unity.Jobs.JobHandle dependsOn)
  RVA=0x09E1C0AC  token=0x60002F8  Unity.Jobs.JobHandle ScheduleBoxcastBatch(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* commands, System.Int32 commandLen, System.Void* result, System.Int32 resultLen, System.Int32 minCommandsPerJob, System.Int32 maxHits)
  RVA=0x09E1C048  token=0x60002F9  System.Void ScheduleBoxcastBatch_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Void* commands, System.Int32 commandLen, System.Void* result, System.Int32 resultLen, System.Int32 minCommandsPerJob, System.Int32 maxHits, Unity.Jobs.JobHandle& ret)
END_CLASS

