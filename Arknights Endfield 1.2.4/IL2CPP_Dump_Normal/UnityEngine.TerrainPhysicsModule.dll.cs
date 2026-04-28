// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TerrainPhysicsModule.dll
// Classes:  3
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

namespace UnityEngine
{

    // TypeToken: 0x2000002  // size: 0x44
    public sealed struct HGTerrainRaycastHit
    {
        // Fields
        private UnityEngine.Vector3 m_Position;  // 0x10
        private UnityEngine.Vector3 m_Normal;  // 0x1c
        private System.Single m_Distance;  // 0x28
        private UnityEngine.Vector3 m_Edge01;  // 0x2c
        private UnityEngine.Vector3 m_Edge02;  // 0x38

        // Properties
        UnityEngine.Vector3 position { get; /* RVA: 0x03D85920 */ }
        UnityEngine.Vector3 normal { get; /* RVA: 0x03D85900 */ }
        UnityEngine.Vector3 edge01 { get; /* RVA: 0x03D85980 */ }
        UnityEngine.Vector3 edge02 { get; /* RVA: 0x03D85960 */ }
        System.Single distance { get; /* RVA: 0x03D85C60 */ }

    }

    // TypeToken: 0x2000003  // size: 0x18
    public class TerrainCollider : UnityEngine.Collider
    {
        // Properties
        UnityEngine.TerrainData terrainData { set; /* RVA: 0x09E2E044 */ }

        // Methods
        // RVA: 0x09E2DF74  token: 0x6000007
        private UnityEngine.HGTerrainRaycastHit HGTerrainRaycast(UnityEngine.Ray ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit) { }
        // RVA: 0x09E2DFC4  token: 0x6000008
        public System.Boolean HGTerrainRaycast(UnityEngine.Ray ray, UnityEngine.HGTerrainRaycastHit& hitInfo, System.Single maxDistance, System.Boolean hitHoles) { }
        // RVA: 0x09E2DF10  token: 0x6000009
        private System.Void HGTerrainRaycast_Injected(UnityEngine.Ray& ray, System.Single maxDistance, System.Boolean hitHoles, System.Boolean& hasHit, UnityEngine.HGTerrainRaycastHit& ret) { }

    }

}

