// ========================================================
// Dumped by @desirepro
// Assembly: HG.RenderPipelines.Logger.dll
// Classes:  4
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

CLASS: HG.Rendering.HGRPLogger
TYPE:  static class
TOKEN: 0x2000002
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x028F6E20  token=0x6000001  System.Void LogWarning(System.String message)
  RVA=-1  // generic def  token=0x6000002  System.Void LogWarning(System.String message, T param1)
  RVA=0x08597F98  token=0x6000003  System.Void LogWarning(UnityEngine.Object context, System.String message)
  RVA=0x08597EA0  token=0x6000004  System.Void LogError(System.String message)
  RVA=-1  // generic def  token=0x6000005  System.Void LogError(System.String message, T param1)
  RVA=-1  // generic def  token=0x6000006  System.Void LogError(System.String message, T1 param1, T2 param2)
  RVA=-1  // generic def  token=0x6000007  System.Void LogError(System.String message, T1 param1, T2 param2, T3 param3)
  RVA=-1  // generic def  token=0x6000008  System.Void LogError(System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  RVA=0x08597E24  token=0x6000009  System.Void LogCritical(System.String message)
  RVA=-1  // generic def  token=0x600000A  System.Void LogCritical(System.String message, T param1)
  RVA=-1  // generic def  token=0x600000B  System.Void LogCritical(System.String message, T1 param1, T2 param2)
  RVA=0x08597F1C  token=0x600000C  System.Void LogException(System.Exception e)
  RVA=0x028F6640  token=0x600000D  System.Void LogImportant(System.String message)
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x28
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // static @ 0x0
METHODS:
  RVA=0x04274234  token=0x600000E  System.Void __Gen_Wrap_0(System.Object P0)
  RVA=0x05163BA0  token=0x600000F  System.Void __Gen_Wrap_1(System.Object P0, System.Object P1)
  RVA=0x03D055D0  token=0x6000010  System.Void .cctor()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000004
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x08597FE8  token=0x6000011  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  RVA=0x028F6E50  token=0x6000012  System.Boolean IsPatched(System.Int32 id)
END_CLASS

