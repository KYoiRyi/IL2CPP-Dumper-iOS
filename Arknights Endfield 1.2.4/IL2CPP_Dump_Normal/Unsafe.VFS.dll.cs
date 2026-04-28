// ========================================================
// Dumped by @desirepro
// Assembly: Unsafe.VFS.dll
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

namespace Beyond.VFS
{

    // TypeToken: 0x2000002  // size: 0x30
    public sealed struct FVFSUntrackedLowIOReadHandle : System.IDisposable
    {
        // Fields
        public Unity.IO.LowLevel.Unsafe.ReadCommand* readCommand;  // 0x10
        public Unity.IO.LowLevel.Unsafe.ReadHandle readHandle;  // 0x18
        public System.Boolean isEnc;  // 0x28

        // Methods
        // RVA: 0x02989E20  token: 0x6000001
        public System.Void .ctor(System.String path, System.Int64 offset, System.Int64 len, System.Boolean async, System.Boolean isEnc) { }
        // RVA: 0x09FA7790  token: 0x6000002
        public System.Void .ctor(Beyond.UnSafeString path, System.Int64 offset, System.Int64 len, System.Boolean async, System.Boolean isEnc) { }
        // RVA: 0x02988A80  token: 0x6000003
        public virtual System.Void Dispose() { }
        // RVA: 0x02989D30  token: 0x6000004
        public System.Boolean IsValid() { }
        // RVA: 0x02F45680  token: 0x6000005
        public System.Boolean IsComplete() { }
        // RVA: 0x02988F90  token: 0x6000006
        public Unity.IO.LowLevel.Unsafe.ReadStatus GetStatus() { }
        // RVA: 0x02F45950  token: 0x6000007
        public Unity.Collections.NativeArray<System.Byte> GetData() { }
        // RVA: 0x0298AAD0  token: 0x6000008
        public Unity.Collections.NativeArray<System.Byte> GetDataThread() { }

    }

    // TypeToken: 0x2000003  // size: 0x30
    public sealed struct FVFSPathInfo
    {
        // Fields
        public System.String fullPathFormat;  // 0x10
        public System.String param0;  // 0x18
        public System.String param1;  // 0x20
        public System.String param2;  // 0x28

        // Methods
        // RVA: 0x024C0E70  token: 0x6000009
        public System.String GetResultString() { }
        // RVA: 0x024BDD30  token: 0x600000A
        public Beyond.UnSafeString GetUnsafeString() { }

    }

    // TypeToken: 0x2000004  // size: 0x10
    public static class ThreadUnsafeStringUtils
    {
        // Fields
        private static System.Collections.Concurrent.ConcurrentStack<Beyond.UnSafeString> s_stack;  // static @ 0x0

        // Methods
        // RVA: 0x02681220  token: 0x600000B
        public static Beyond.UnSafeString ThreadStringAlloc() { }
        // RVA: 0x026824F0  token: 0x600000C
        public static System.Void ThreadStringRelease(Beyond.UnSafeString value) { }
        // RVA: 0x02681410  token: 0x600000D
        public static Beyond.UnSafeString AppendPathInfo(Beyond.UnSafeString str, Beyond.VFS.FVFSPathInfo& info) { }
        // RVA: 0x03CF64F0  token: 0x600000E
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
        // RVA: 0x03020510  token: 0x600000F
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        // RVA: 0x09FA78E0  token: 0x6000010
        public System.Void __Gen_Wrap_0(Beyond.VFS.FVFSUntrackedLowIOReadHandle& P0) { }
        // RVA: 0x09FA7A24  token: 0x6000011
        public System.Boolean __Gen_Wrap_1(Beyond.VFS.FVFSUntrackedLowIOReadHandle& P0) { }
        // RVA: 0x09FA7B78  token: 0x6000012
        public Unity.IO.LowLevel.Unsafe.ReadStatus __Gen_Wrap_2(Beyond.VFS.FVFSUntrackedLowIOReadHandle& P0) { }
        // RVA: 0x09FA7CCC  token: 0x6000013
        public Unity.Collections.NativeArray<System.Byte> __Gen_Wrap_3(Beyond.VFS.FVFSUntrackedLowIOReadHandle& P0) { }
        // RVA: 0x09FA7E4C  token: 0x6000014
        public System.String __Gen_Wrap_4(Beyond.VFS.FVFSPathInfo& P0) { }
        // RVA: 0x09FA7FB8  token: 0x6000015
        public Beyond.UnSafeString __Gen_Wrap_5(Beyond.VFS.FVFSPathInfo& P0) { }
        // RVA: 0x09FA8124  token: 0x6000016
        public Beyond.UnSafeString __Gen_Wrap_6() { }
        // RVA: 0x04274234  token: 0x6000017
        public System.Void __Gen_Wrap_7(System.Object P0) { }
        // RVA: 0x09FA81F0  token: 0x6000018
        public Beyond.UnSafeString __Gen_Wrap_8(System.Object P0, Beyond.VFS.FVFSPathInfo& P1) { }
        // RVA: 0x03D061A0  token: 0x6000019
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000006  // size: 0x40
    public class ILFixInterfaceBridge : IFix.Core.AnonymousStorey
    {
        // Methods
        // RVA: 0x09FA8378  token: 0x600001A
        public System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0350B670  token: 0x600001B
        public System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000007  // size: 0x18
    public class WrappersManagerImpl : IFix.Core.WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x600001C
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x09FA85F4  token: 0x600001D
        public static IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        // RVA: 0x024BDEE0  token: 0x600001E
        public static System.Boolean IsPatched(System.Int32 id) { }
        // RVA: 0x09FA84B0  token: 0x600001F
        public virtual System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        // RVA: 0x09FA857C  token: 0x6000020
        public virtual System.Object CreateWrapper(System.Int32 id) { }
        // RVA: 0x09FA8658  token: 0x6000021
        public virtual System.Object InitWrapperArray(System.Int32 len) { }
        // RVA: 0x09FA840C  token: 0x6000022
        public virtual IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000008  // size: 0x14
    public sealed struct IDMAP0
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static IFix.IDMAP0 Beyond-VFS-FVFSUntrackedLowIOReadHandle-Dispose0;  // const
        public static IFix.IDMAP0 Beyond-VFS-FVFSUntrackedLowIOReadHandle-IsValid0;  // const
        public static IFix.IDMAP0 Beyond-VFS-FVFSUntrackedLowIOReadHandle-IsComplete0;  // const
        public static IFix.IDMAP0 Beyond-VFS-FVFSUntrackedLowIOReadHandle-GetStatus0;  // const
        public static IFix.IDMAP0 Beyond-VFS-FVFSUntrackedLowIOReadHandle-GetData0;  // const
        public static IFix.IDMAP0 Beyond-VFS-FVFSUntrackedLowIOReadHandle-GetDataThread0;  // const
        public static IFix.IDMAP0 Beyond-VFS-FVFSPathInfo-GetResultString0;  // const
        public static IFix.IDMAP0 Beyond-VFS-FVFSPathInfo-GetUnsafeString0;  // const
        public static IFix.IDMAP0 Beyond-VFS-ThreadUnsafeStringUtils-ThreadStringAlloc0;  // const
        public static IFix.IDMAP0 Beyond-VFS-ThreadUnsafeStringUtils-ThreadStringRelease0;  // const
        public static IFix.IDMAP0 Beyond-VFS-ThreadUnsafeStringUtils-AppendPathInfo0;  // const

    }

}

