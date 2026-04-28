// ========================================================
// Dumped by @desirepro
// Assembly: IFix.Define.dll
// Classes:  8
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

namespace Beyond.HotFix
{

    // TypeToken: 0x2000002  // size: 0x38
    public class PatchClipboardData
    {
        // Fields
        public System.Int32 ver;  // 0x10
        public System.Int32 overrideVFSIFixVersionFrom;  // 0x14
        public System.Int32 overrideVFSIFixVersionTo;  // 0x18
        public System.String platform;  // 0x20
        public System.Collections.Generic.List<Beyond.HotFix.PatchItem> patches;  // 0x28
        public System.Collections.Generic.List<Beyond.HotFix.PatchItem> luaPatches;  // 0x30

        // Methods
        // RVA: 0x0350B670  token: 0x6000001
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000003  // size: 0x30
    public class PatchItem
    {
        // Fields
        public System.String name;  // 0x10
        public System.String md5;  // 0x18
        public System.Int32 size;  // 0x20
        public System.String data;  // 0x28

        // Methods
        // RVA: 0x0350B670  token: 0x6000002
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x10
    public static class HotFixPatchDefine
    {
        // Fields
        public static readonly System.String hotFixPatchFileExtension;  // static @ 0x0
        public static readonly System.String CLIENT_NET_RSA_PUBLIC_KEY;  // static @ 0x8

        // Methods
        // RVA: 0x08899E04  token: 0x6000003
        public static System.Boolean VerifyMD5(System.Byte[] bytes, System.String expectMd5) { }
        // RVA: 0x08899FE4  token: 0x6000004
        private static System.Void .cctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000005  // size: 0x28
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10
        private System.Int32 methodId;  // 0x18
        private System.Object anonObj;  // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;  // static @ 0x0

        // Methods
        // RVA: 0x03020510  token: 0x6000005
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        // RVA: 0x05153920  token: 0x6000006
        public System.Boolean __Gen_Wrap_0(System.Object P0, System.Object P1) { }
        // RVA: 0x0889A07C  token: 0x6000007
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000006  // size: 0x40
    public class ILFixInterfaceBridge : IFix.Core.AnonymousStorey
    {
        // Methods
        // RVA: 0x0889A0E0  token: 0x6000008
        public System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0350B670  token: 0x6000009
        public System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000007  // size: 0x18
    public class WrappersManagerImpl : IFix.Core.WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x600000A
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0889A35C  token: 0x600000B
        public static IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        // RVA: 0x0889A44C  token: 0x600000C
        public static System.Boolean IsPatched(System.Int32 id) { }
        // RVA: 0x0889A218  token: 0x600000D
        public virtual System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        // RVA: 0x0889A2E4  token: 0x600000E
        public virtual System.Object CreateWrapper(System.Int32 id) { }
        // RVA: 0x0889A3C0  token: 0x600000F
        public virtual System.Object InitWrapperArray(System.Int32 len) { }
        // RVA: 0x0889A174  token: 0x6000010
        public virtual IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000008  // size: 0x14
    public sealed struct IDMAP0
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static IFix.IDMAP0 Beyond-HotFix-HotFixPatchDefine-VerifyMD50;  // const

    }

}

