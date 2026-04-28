// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.GridModule.dll
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

CLASS: UnityEngine.Grid
TYPE:  sealed class
TOKEN: 0x2000002
SIZE:  0x18
EXTENDS: UnityEngine.GridLayout
FIELDS:
PROPERTIES:
  cellSize  get=0x09DF4660
METHODS:
  RVA=0x0426FE60  token=0x6000002  System.Void .ctor()
  RVA=0x09DF461C  token=0x6000003  System.Void get_cellSize_Injected(UnityEngine.Vector3& ret)
END_CLASS

CLASS: UnityEngine.GridLayout
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x18
EXTENDS: UnityEngine.Behaviour
FIELDS:
METHODS:
  RVA=0x09DF45E8  token=0x6000004  UnityEngine.Vector3 CellToLocal(UnityEngine.Vector3Int cellPosition)
  RVA=0x0350B670  token=0x6000005  System.Void DoNothing()
  RVA=0x0426FE60  token=0x6000006  System.Void .ctor()
  RVA=0x09DF4594  token=0x6000007  System.Void CellToLocal_Injected(UnityEngine.Vector3Int& cellPosition, UnityEngine.Vector3& ret)
END_CLASS

