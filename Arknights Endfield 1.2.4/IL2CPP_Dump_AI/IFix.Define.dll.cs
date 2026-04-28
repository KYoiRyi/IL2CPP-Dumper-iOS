// ========================================================
// Dumped by @desirepro
// Assembly: IFix.Define.dll
// Classes:  8
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

CLASS: Beyond.HotFix.PatchClipboardData
TYPE:  class
TOKEN: 0x2000002
SIZE:  0x38
FIELDS:
  public            System.Int32                    ver  // 0x10
  public            System.Int32                    overrideVFSIFixVersionFrom  // 0x14
  public            System.Int32                    overrideVFSIFixVersionTo  // 0x18
  public            System.String                   platform  // 0x20
  public            System.Collections.Generic.List<Beyond.HotFix.PatchItem>patches  // 0x28
  public            System.Collections.Generic.List<Beyond.HotFix.PatchItem>luaPatches  // 0x30
METHODS:
  RVA=0x0350B670  token=0x6000001  System.Void .ctor()
END_CLASS

CLASS: Beyond.HotFix.PatchItem
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x30
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   md5  // 0x18
  public            System.Int32                    size  // 0x20
  public            System.String                   data  // 0x28
METHODS:
  RVA=0x0350B670  token=0x6000002  System.Void .ctor()
END_CLASS

CLASS: Beyond.HotFix.HotFixPatchDefine
TYPE:  static class
TOKEN: 0x2000004
SIZE:  0x10
FIELDS:
  public    static readonly System.String                   hotFixPatchFileExtension  // static @ 0x0
  public    static readonly System.String                   CLIENT_NET_RSA_PUBLIC_KEY  // static @ 0x8
METHODS:
  RVA=0x08899E04  token=0x6000003  System.Boolean VerifyMD5(System.Byte[] bytes, System.String expectMd5)
  RVA=0x08899FE4  token=0x6000004  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000005
SIZE:  0x28
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // static @ 0x0
METHODS:
  RVA=0x03020510  token=0x6000005  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  RVA=0x05153920  token=0x6000006  System.Boolean __Gen_Wrap_0(System.Object P0, System.Object P1)
  RVA=0x0889A07C  token=0x6000007  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000006
SIZE:  0x40
EXTENDS: IFix.Core.AnonymousStorey
FIELDS:
METHODS:
  RVA=0x0889A0E0  token=0x6000008  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  RVA=0x0350B670  token=0x6000009  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000007
SIZE:  0x18
IMPLEMENTS: IFix.Core.WrappersManager
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
METHODS:
  RVA=0x0426FEE0  token=0x600000A  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine)
  RVA=0x0889A35C  token=0x600000B  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  RVA=0x0889A44C  token=0x600000C  System.Boolean IsPatched(System.Int32 id)
  RVA=0x0889A218  token=0x600000D  System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon)
  RVA=0x0889A2E4  token=0x600000E  System.Object CreateWrapper(System.Int32 id)
  RVA=0x0889A3C0  token=0x600000F  System.Object InitWrapperArray(System.Int32 len)
  RVA=0x0889A174  token=0x6000010  IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine)
END_CLASS

CLASS: IFix.IDMAP0
TYPE:  sealed struct
TOKEN: 0x2000008
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-HotFix-HotFixPatchDefine-VerifyMD50  // const
METHODS:
END_CLASS

