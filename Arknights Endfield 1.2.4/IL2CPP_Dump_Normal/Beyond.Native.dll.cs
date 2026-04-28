// ========================================================
// Dumped by @desirepro
// Assembly: Beyond.Native.dll
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

namespace Beyond.Native
{

    // TypeToken: 0x2000004  // size: 0x10
    public static class NativeHelper
    {
        // Methods
        // RVA: -1  // generic def  token: 0x6000003
        public static System.Span<T> CreateSpan(Unity.Collections.NativeArray<T> arr) { }
        // RVA: 0x0516C2AC  token: 0x6000004
        public static System.String ToStringUTF8(Unity.Collections.NativeArray<System.Byte> arr) { }
        // RVA: -1  // generic def  token: 0x6000005
        public static T& GetElementRef(Unity.Collections.NativeArray<T> array, System.Int32 idx) { }

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
        // RVA: 0x03020510  token: 0x6000006
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        // RVA: 0x0516C0B4  token: 0x6000007
        public System.String __Gen_Wrap_0(Unity.Collections.NativeArray<System.Byte> P0) { }
        // RVA: 0x0516C1B4  token: 0x6000008
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000006  // size: 0x40
    public class ILFixInterfaceBridge : IFix.Core.AnonymousStorey
    {
        // Methods
        // RVA: 0x0516C218  token: 0x6000009
        public System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0350B670  token: 0x600000A
        public System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000007  // size: 0x18
    public class WrappersManagerImpl : IFix.Core.WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;  // 0x10

        // Methods
        // RVA: 0x0426FEE0  token: 0x600000B
        public System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        // RVA: 0x0516C558  token: 0x600000C
        public static IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        // RVA: 0x0516C648  token: 0x600000D
        public static System.Boolean IsPatched(System.Int32 id) { }
        // RVA: 0x0516C414  token: 0x600000E
        public virtual System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        // RVA: 0x0516C4E0  token: 0x600000F
        public virtual System.Object CreateWrapper(System.Int32 id) { }
        // RVA: 0x0516C5BC  token: 0x6000010
        public virtual System.Object InitWrapperArray(System.Int32 len) { }
        // RVA: 0x0516C370  token: 0x6000011
        public virtual IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000008  // size: 0x14
    public sealed struct IDMAP0
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static IFix.IDMAP0 Beyond-Native-NativeHelper-ToStringUTF80;  // const

    }

}

namespace Microsoft.CodeAnalysis
{

    // TypeToken: 0x2000002  // size: 0x10
    public sealed class EmbeddedAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000001
        public System.Void .ctor() { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000003  // size: 0x10
    public sealed class IsUnmanagedAttribute : System.Attribute
    {
        // Methods
        // RVA: 0x0350B670  token: 0x6000002
        public System.Void .ctor() { }

    }

}

