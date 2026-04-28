// ========================================================
// Dumped by @desirepro
// Assembly: IFix.Tools.dll
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

    // TypeToken: 0x2000003  // size: 0x40
    public class WrapperArrayCandidate
    {
        // Fields
        public System.String Source;  // 0x10
        public System.String OwnerTypeName;  // 0x18
        public System.String FieldName;  // 0x20
        public System.String ElementTypeName;  // 0x28
        public System.Int32 Length;  // 0x30
        public System.Int32 NonNullCount;  // 0x34
        public System.Func<System.Int32,System.Object> Getter;  // 0x38

        // Methods
        // RVA: 0x088A1484  token: 0x600001E
        public System.Object GetValue(System.Int32 index) { }
        // RVA: 0x0350B670  token: 0x600001F
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000004  // size: 0x10
    public sealed class <>c
    {
        // Fields
        public static readonly IFix.IFixMethodPrinter.<>c <>9;  // static @ 0x0
        public static System.Func<System.Collections.Generic.KeyValuePair<System.Int32,System.String>,System.Int32> <>9__7_0;  // static @ 0x8

        // Methods
        // RVA: 0x088A1420  token: 0x6000020
        private static System.Void .cctor() { }
        // RVA: 0x0350B670  token: 0x6000021
        public System.Void .ctor() { }
        // RVA: 0x088A13AC  token: 0x6000022
        private System.Int32 <GetAllIFixMethodStrs>b__7_0(System.Collections.Generic.KeyValuePair<System.Int32,System.String> k) { }

    }

    // TypeToken: 0x2000005  // size: 0x18
    public sealed class <>c__DisplayClass17_0
    {
        // Fields
        public System.Array arr;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x6000023
        public System.Void .ctor() { }
        // RVA: 0x088A13E0  token: 0x6000024
        private System.Object <TryGetWrapperArrayDirect>b__0(System.Int32 i) { }

    }

    // TypeToken: 0x2000006  // size: 0x20
    public sealed class <>c__DisplayClass26_0
    {
        // Fields
        public System.Array arr;  // 0x10
        public System.Collections.IList listValue;  // 0x18

        // Methods
        // RVA: 0x0350B670  token: 0x6000025
        public System.Void .ctor() { }
        // RVA: 0x088A13E0  token: 0x6000026
        private System.Object <AddWrapperCandidate>b__0(System.Int32 i) { }
        // RVA: 0x088A1400  token: 0x6000027
        private System.Object <AddWrapperCandidate>b__1(System.Int32 i) { }

    }

    // TypeToken: 0x2000007  // size: 0x58
    public sealed class <GetAllFieldsIncludingBase>d__29 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Reflection.FieldInfo <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x20
        private System.Type type;  // 0x28
        public System.Type <>3__type;  // 0x30
        private System.Reflection.BindingFlags flags;  // 0x38
        public System.Reflection.BindingFlags <>3__flags;  // 0x3c
        private System.Type <t>5__2;  // 0x40
        private System.Reflection.FieldInfo[] <>7__wrap2;  // 0x48
        private System.Int32 <>7__wrap3;  // 0x50

        // Properties
        System.Reflection.FieldInfo System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x025D6DC0  token: 0x6000028
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000029
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x088A0F6C  token: 0x600002A
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x088A1140  token: 0x600002C
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x088A109C  token: 0x600002E
        private virtual System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo> System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>.GetEnumerator() { }
        // RVA: 0x088A1138  token: 0x600002F
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000008  // size: 0x58
    public sealed class <GetAllPropertiesIncludingBase>d__30 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private System.Reflection.PropertyInfo <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x20
        private System.Type type;  // 0x28
        public System.Type <>3__type;  // 0x30
        private System.Reflection.BindingFlags flags;  // 0x38
        public System.Reflection.BindingFlags <>3__flags;  // 0x3c
        private System.Type <t>5__2;  // 0x40
        private System.Reflection.PropertyInfo[] <>7__wrap2;  // 0x48
        private System.Int32 <>7__wrap3;  // 0x50

        // Properties
        System.Reflection.PropertyInfo System.Collections.Generic.IEnumerator<System.Reflection.PropertyInfo>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x025D6DC0  token: 0x6000030
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x6000031
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x088A118C  token: 0x6000032
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x088A1360  token: 0x6000034
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x088A12BC  token: 0x6000036
        private virtual System.Collections.Generic.IEnumerator<System.Reflection.PropertyInfo> System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>.GetEnumerator() { }
        // RVA: 0x088A1358  token: 0x6000037
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

namespace IFix
{

    // TypeToken: 0x2000002  // size: 0x28
    public class IFixMethodPrinter
    {
        // Fields
        private System.Reflection.FieldInfo unmanagedCodesField;  // 0x10
        private System.Reflection.PropertyInfo exceptionHandlersProperty;  // 0x18
        private System.Reflection.PropertyInfo externMethodsProperty;  // 0x20

        // Methods
        // RVA: 0x0889F804  token: 0x6000001
        private System.Void InitializeReflection() { }
        // RVA: 0x0889F034  token: 0x6000002
        private System.Int32 GetMethodCount(IFix.Core.VirtualMachine vm) { }
        // RVA: 0x0889F0B4  token: 0x6000003
        private IFix.Core.Instruction[] GetMethodInstructions(IFix.Core.VirtualMachine vm, System.Int32 methodIndex) { }
        // RVA: 0x0889D5D4  token: 0x6000004
        private System.Int32 EstimateInstructionCount(IFix.Core.Instruction* codePtr) { }
        // RVA: 0x0889DB5C  token: 0x6000005
        public System.String GetAllIFixMethodStrs(IFix.Core.VirtualMachine vm) { }
        // RVA: 0x0889CB88  token: 0x6000006
        private System.Void DumpRedirectToMappings(System.Text.StringBuilder sb, IFix.Core.WrappersManager wrappersManager) { }
        // RVA: 0x0889AE48  token: 0x6000007
        private System.Collections.Generic.Dictionary<System.Int32,System.String> BuildIdMap(System.Reflection.Assembly preferredAssembly) { }
        // RVA: 0x0889D628  token: 0x6000008
        private System.Void ForceLoadIdMapTypes(System.Collections.Generic.Dictionary<System.Int32,System.String> result) { }
        // RVA: 0x0889A4E4  token: 0x6000009
        private System.Void AddIdMapFields(System.Collections.Generic.Dictionary<System.Int32,System.String> result, System.Type idMapType) { }
        // RVA: 0x0889B1B8  token: 0x600000A
        private System.String BuildMethodLabelFromIdMapField(System.Reflection.FieldInfo field) { }
        // RVA: 0x0889F958  token: 0x600000B
        private System.Boolean IsNumericField(System.Type type) { }
        // RVA: 0x0889B7BC  token: 0x600000C
        private System.Collections.Generic.List<IFix.IFixMethodPrinter.WrapperArrayCandidate> CollectWrapperArrays(IFix.Core.WrappersManager wrappersManager) { }
        // RVA: 0x0889B340  token: 0x600000D
        private System.Collections.Generic.List<IFix.IFixMethodPrinter.WrapperArrayCandidate> CollectWrapperArraysFromAssembly(System.Reflection.Assembly asm) { }
        // RVA: 0x0889FE30  token: 0x600000E
        private IFix.IFixMethodPrinter.WrapperArrayCandidate SelectBestWrapperArray(System.Collections.Generic.List<IFix.IFixMethodPrinter.WrapperArrayCandidate> candidates, System.Collections.Generic.Dictionary<System.Int32,System.String> idMap) { }
        // RVA: 0x088A035C  token: 0x600000F
        private IFix.IFixMethodPrinter.WrapperArrayCandidate TryGetWrapperArrayDirect(System.Reflection.Assembly asm) { }
        // RVA: 0x088A0A6C  token: 0x6000010
        private System.String TryResolveWrapperTarget(System.Object wrapperObj) { }
        // RVA: 0x0889F3F0  token: 0x6000011
        private System.String GetWrapperDebugInfo(System.Object wrapperObj) { }
        // RVA: 0x0889FFFC  token: 0x6000012
        private System.String SummarizeValue(System.Object val) { }
        // RVA: 0x088A06C4  token: 0x6000013
        private System.Nullable<System.Int32> TryGetWrapperMethodId(System.Object wrapperObj) { }
        // RVA: 0x0889AA9C  token: 0x6000014
        private System.Void AppendILSummary(System.Text.StringBuilder sb, IFix.Core.VirtualMachine vm, System.Int32 methodId, System.Reflection.MethodBase[] externMethods) { }
        // RVA: 0x0889D8A8  token: 0x6000015
        private System.String FormatOperand(IFix.Core.VirtualMachine vm, IFix.Core.Instruction inst, System.Reflection.MethodBase[] externMethods) { }
        // RVA: 0x0889FB14  token: 0x6000016
        private System.Int32 ScoreWrapperCandidate(IFix.IFixMethodPrinter.WrapperArrayCandidate candidate, System.Int32 minLen) { }
        // RVA: 0x0889A6C0  token: 0x6000017
        private System.Void AddWrapperCandidate(System.Collections.Generic.List<IFix.IFixMethodPrinter.WrapperArrayCandidate> list, System.String source, System.String ownerTypeName, System.String name, System.Type valueType, System.Object value) { }
        // RVA: 0x0889CEF4  token: 0x6000018
        private System.Void DumpWrappersManagerMembers(System.Text.StringBuilder sb, IFix.Core.WrappersManager wrappersManager) { }
        // RVA: 0x0889C4CC  token: 0x6000019
        private System.Void DumpAssemblyPotentialStores(System.Text.StringBuilder sb, System.Reflection.Assembly asm) { }
        // RVA: 0x0889DADC  token: 0x600001A
        private System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetAllFieldsIncludingBase(System.Type type, System.Reflection.BindingFlags flags) { }
        // RVA: 0x0889EFB4  token: 0x600001B
        private System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetAllPropertiesIncludingBase(System.Type type, System.Reflection.BindingFlags flags) { }
        // RVA: 0x0889C380  token: 0x600001C
        private System.String DescribeValue(System.Object value) { }
        // RVA: 0x0350B670  token: 0x600001D
        public System.Void .ctor() { }

    }

}

