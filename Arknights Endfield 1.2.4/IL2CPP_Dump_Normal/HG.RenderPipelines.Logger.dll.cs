// ========================================================
// Dumped by @desirepro
// Assembly: HG.RenderPipelines.Logger.dll
// Classes:  4
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

namespace HG.Rendering
{

    // TypeToken: 0x2000002  // size: 0x10
    public static class HGRPLogger
    {
        // Methods
        // RVA: 0x028F6E20  token: 0x6000001
        public static System.Void LogWarning(System.String message) { }
        // RVA: -1  // generic def  token: 0x6000002
        public static System.Void LogWarning(System.String message, T param1) { }
        // RVA: 0x08597F98  token: 0x6000003
        public static System.Void LogWarning(UnityEngine.Object context, System.String message) { }
        // RVA: 0x08597EA0  token: 0x6000004
        public static System.Void LogError(System.String message) { }
        // RVA: -1  // generic def  token: 0x6000005
        public static System.Void LogError(System.String message, T param1) { }
        // RVA: -1  // generic def  token: 0x6000006
        public static System.Void LogError(System.String message, T1 param1, T2 param2) { }
        // RVA: -1  // generic def  token: 0x6000007
        public static System.Void LogError(System.String message, T1 param1, T2 param2, T3 param3) { }
        // RVA: -1  // generic def  token: 0x6000008
        public static System.Void LogError(System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        // RVA: 0x08597E24  token: 0x6000009
        public static System.Void LogCritical(System.String message) { }
        // RVA: -1  // generic def  token: 0x600000A
        public static System.Void LogCritical(System.String message, T param1) { }
        // RVA: -1  // generic def  token: 0x600000B
        public static System.Void LogCritical(System.String message, T1 param1, T2 param2) { }
        // RVA: 0x08597F1C  token: 0x600000C
        public static System.Void LogException(System.Exception e) { }
        // RVA: 0x028F6640  token: 0x600000D
        public static System.Void LogImportant(System.String message) { }

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
        // RVA: 0x04274234  token: 0x600000E
        public System.Void __Gen_Wrap_0(System.Object P0) { }
        // RVA: 0x05163BA0  token: 0x600000F
        public System.Void __Gen_Wrap_1(System.Object P0, System.Object P1) { }
        // RVA: 0x03D055D0  token: 0x6000010
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x10
    public class WrappersManagerImpl
    {
        // Methods
        // RVA: 0x08597FE8  token: 0x6000011
        public static IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        // RVA: 0x028F6E50  token: 0x6000012
        public static System.Boolean IsPatched(System.Int32 id) { }

    }

}

