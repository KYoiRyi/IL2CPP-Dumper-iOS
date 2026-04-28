// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TerrainPhysicsModule.dll
// Classes:  3
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

CLASS: UnityEngine.HGTerrainRaycastHit
TYPE:  sealed struct
TOKEN: 0x2000002
SIZE:  0x44
FIELDS:
  private           UnityEngine.Vector3             m_Position  // 0x10
  private           UnityEngine.Vector3             m_Normal  // 0x1c
  private           System.Single                   m_Distance  // 0x28
  private           UnityEngine.Vector3             m_Edge01  // 0x2c
  private           UnityEngine.Vector3             m_Edge02  // 0x38
PROPERTIES:
  position  get=0x03D85920
  normal  get=0x03D85900
  edge01  get=0x03D85980
  edge02  get=0x03D85960
  distance  get=0x03D85C60
METHODS:
END_CLASS

CLASS: UnityEngine.TerrainCollider
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x18
EXTENDS: UnityEngine.Collider
FIELDS:
PROPERTIES:
  terrainData  set=0x09E2E044
METHODS:
  RVA=0x09E2DF74  token=0x6000007  UnityEngine.HGTerrainRaycastHit HGTerrainRaycast(UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit)
  RVA=0x09E2DFC4  token=0x6000008  System.Boolean HGTerrainRaycast(UnityEngine.Ray ray, UnityEngine.HGTerrainRaycastHit& hitInfo, System.Single maxDistance, System.Boolean hitHoles)
  RVA=0x09E2DF10  token=0x6000009  System.Void HGTerrainRaycast_Injected(UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit, UnityEngine.HGTerrainRaycastHit& ret)
END_CLASS

