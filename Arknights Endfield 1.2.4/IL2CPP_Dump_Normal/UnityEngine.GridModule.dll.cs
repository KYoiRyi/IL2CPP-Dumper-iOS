// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.GridModule.dll
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

    // TypeToken: 0x2000002  // size: 0x18
    public sealed class Grid : UnityEngine.GridLayout
    {
        // Properties
        UnityEngine.Vector3 cellSize { get; /* RVA: 0x09DF4660 */ }

        // Methods
        // RVA: 0x0426FE60  token: 0x6000002
        public System.Void .ctor() { }
        // RVA: 0x09DF461C  token: 0x6000003
        private System.Void get_cellSize_Injected(UnityEngine.Vector3& ret) { }

    }

    // TypeToken: 0x2000003  // size: 0x18
    public class GridLayout : UnityEngine.Behaviour
    {
        // Methods
        // RVA: 0x09DF45E8  token: 0x6000004
        public UnityEngine.Vector3 CellToLocal(UnityEngine.Vector3Int cellPosition) { }
        // RVA: 0x0350B670  token: 0x6000005
        private System.Void DoNothing() { }
        // RVA: 0x0426FE60  token: 0x6000006
        public System.Void .ctor() { }
        // RVA: 0x09DF4594  token: 0x6000007
        private System.Void CellToLocal_Injected(UnityEngine.Vector3Int& cellPosition, UnityEngine.Vector3& ret) { }

    }

}

