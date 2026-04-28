// ========================================================
// Dumped by @desirepro
// Assembly: SRSA.dll
// Classes:  6
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

namespace Beyond
{

    // TypeToken: 0x2000002  // size: 0x10
    public static class SRSA
    {
        // Fields
        private static System.String EncryptionLib;  // const
        public static System.Int32 s_keyLength;  // const

        // Methods
        // RVA: 0x042728F4  token: 0x6000001
        public static System.IntPtr mono_method_h_get_code(System.IntPtr message, System.Int32 message_size) { }
        // RVA: 0x042728FC  token: 0x6000002
        public static System.IntPtr mono_method_h_set_code(System.IntPtr message) { }
        // RVA: 0x04272904  token: 0x6000003
        public static System.Void mono_method_h_remove_code(System.IntPtr message) { }
        // RVA: 0x02AB0290  token: 0x6000004
        public static System.Void LoadFromFile(System.Span<System.Byte> message, System.Span<System.Byte>& buffer) { }
        // RVA: 0x02AB0100  token: 0x6000005
        public static System.Void LoadFromFile2(System.Span<System.Byte> inputData, System.Span<System.Byte>& outputBytes) { }
        // RVA: 0x096A8BC8  token: 0x6000006
        public static System.Void test() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000003  // size: 0x28
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10
        private System.Int32 methodId;  // 0x18
        private System.Object anonObj;  // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;  // static @ 0x0

        // Methods
        // RVA: 0x03020510  token: 0x6000007
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        // RVA: 0x096A89CC  token: 0x6000008
        public System.Void __Gen_Wrap_0(System.Span<System.Byte> P0, System.Span<System.Byte>& P1) { }
        // RVA: 0x051624BC  token: 0x6000009
        public System.Void __Gen_Wrap_1() { }
        // RVA: 0x03D05D40  token: 0x600000A
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x40
    public class ILFixInterfaceBridge : IFix.Core.AnonymousStorey
    {
        // Methods
        // RVA: 0x096A8B34  token: 0x600000B
        public System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0350B670  token: 0x600000C
        public System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000005  // size: 0x18
    public class WrappersManagerImpl : IFix.Core.WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x600000D
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x096A8DF0  token: 0x600000E
        public static IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        // RVA: 0x02AB0850  token: 0x600000F
        public static System.Boolean IsPatched(System.Int32 id) { }
        // RVA: 0x096A8CAC  token: 0x6000010
        public virtual System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        // RVA: 0x096A8D78  token: 0x6000011
        public virtual System.Object CreateWrapper(System.Int32 id) { }
        // RVA: 0x096A8E54  token: 0x6000012
        public virtual System.Object InitWrapperArray(System.Int32 len) { }
        // RVA: 0x096A8C08  token: 0x6000013
        public virtual IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000006  // size: 0x14
    public sealed struct IDMAP0
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static IFix.IDMAP0 Beyond-SRSA-LoadFromFile0;  // const
        public static IFix.IDMAP0 Beyond-SRSA-LoadFromFile20;  // const
        public static IFix.IDMAP0 Beyond-SRSA-test0;  // const

    }

}

