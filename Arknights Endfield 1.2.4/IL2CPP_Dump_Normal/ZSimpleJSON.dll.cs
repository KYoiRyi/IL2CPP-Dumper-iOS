// ========================================================
// Dumped by @desirepro
// Assembly: ZSimpleJSON.dll
// Classes:  23
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000001  // size: 0x1
    public class <Module>
    {
    }

    // TypeToken: 0x2000004  // size: 0x14
    public sealed struct Type
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static ZSimpleJSON.JSONNode.Enumerator.Type None;  // const
        public static ZSimpleJSON.JSONNode.Enumerator.Type Array;  // const
        public static ZSimpleJSON.JSONNode.Enumerator.Type Object;  // const

    }

    // TypeToken: 0x2000003  // size: 0x58
    public sealed struct Enumerator
    {
        // Fields
        private ZSimpleJSON.JSONNode.Enumerator.Type type;  // 0x10
        private System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode> m_Object;  // 0x18
        private System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode> m_Array;  // 0x40

        // Properties
        System.Boolean IsValid { get; /* RVA: 0x0426F724 */ }
        System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode> Current { get; /* RVA: 0x025F6B90 */ }

        // Methods
        // RVA: 0x08854824  token: 0x60000C1
        public System.Void .ctor(System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode> aArrayEnum) { }
        // RVA: 0x03B109F0  token: 0x60000C2
        public System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode> aDictEnum) { }
        // RVA: 0x025F6930  token: 0x60000C4
        public System.Boolean MoveNext() { }

    }

    // TypeToken: 0x2000005  // size: 0x58
    public sealed struct ValueEnumerator
    {
        // Fields
        private ZSimpleJSON.JSONNode.Enumerator m_Enumerator;  // 0x10

        // Properties
        ZSimpleJSON.JSONNode Current { get; /* RVA: 0x0A2BDE64 */ }

        // Methods
        // RVA: 0x0885EBAC  token: 0x60000C5
        public System.Void .ctor(System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode> aArrayEnum) { }
        // RVA: 0x0885EAD8  token: 0x60000C6
        public System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode> aDictEnum) { }
        // RVA: 0x0885EB78  token: 0x60000C7
        public System.Void .ctor(ZSimpleJSON.JSONNode.Enumerator aEnumerator) { }
        // RVA: 0x0A2BCC00  token: 0x60000C9
        public System.Boolean MoveNext() { }
        // RVA: 0x03D6D9B0  token: 0x60000CA
        public ZSimpleJSON.JSONNode.ValueEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x2000006  // size: 0x58
    public sealed struct KeyEnumerator
    {
        // Fields
        private ZSimpleJSON.JSONNode.Enumerator m_Enumerator;  // 0x10

        // Properties
        System.String Current { get; /* RVA: 0x0A2BCC08 */ }

        // Methods
        // RVA: 0x0885EBAC  token: 0x60000CB
        public System.Void .ctor(System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode> aArrayEnum) { }
        // RVA: 0x0885EAD8  token: 0x60000CC
        public System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode> aDictEnum) { }
        // RVA: 0x0885EB78  token: 0x60000CD
        public System.Void .ctor(ZSimpleJSON.JSONNode.Enumerator aEnumerator) { }
        // RVA: 0x0A2BCC00  token: 0x60000CF
        public System.Boolean MoveNext() { }
        // RVA: 0x03D6D9B0  token: 0x60000D0
        public ZSimpleJSON.JSONNode.KeyEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x2000007  // size: 0x60
    public class LinqEnumerator : System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable, System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable
    {
        // Fields
        private ZSimpleJSON.JSONNode m_Node;  // 0x10
        private ZSimpleJSON.JSONNode.Enumerator m_Enumerator;  // 0x18

        // Properties
        System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode> Current { get; /* RVA: 0x0A2BCECC */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x0A2BCDC0 */ }

        // Methods
        // RVA: 0x0A2BCE18  token: 0x60000D1
        private System.Void .ctor(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BCCAC  token: 0x60000D4
        public virtual System.Boolean MoveNext() { }
        // RVA: 0x0885EC84  token: 0x60000D5
        public virtual System.Void Dispose() { }
        // RVA: 0x0A2BCC48  token: 0x60000D6
        public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode>> GetEnumerator() { }
        // RVA: 0x0A2BCCB8  token: 0x60000D7
        public virtual System.Void Reset() { }
        // RVA: 0x0A2BCD5C  token: 0x60000D8
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000008  // size: 0x28
    public sealed class <get_Children>d__181 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private ZSimpleJSON.JSONNode <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x20

        // Properties
        ZSimpleJSON.JSONNode System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x025D6DC0  token: 0x60000D9
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0350B670  token: 0x60000DA
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x03D4C410  token: 0x60000DB
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0A2BCFDC  token: 0x60000DD
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x0A2BCF5C  token: 0x60000DF
        private virtual System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode>.GetEnumerator() { }
        // RVA: 0x0A2BCFD4  token: 0x60000E0
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000009  // size: 0x40
    public sealed class <get_DeepChildren>d__183 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private ZSimpleJSON.JSONNode <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x20
        public ZSimpleJSON.JSONNode <>4__this;  // 0x28
        private System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode> <>7__wrap1;  // 0x30
        private System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode> <>7__wrap2;  // 0x38

        // Properties
        ZSimpleJSON.JSONNode System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x025D6DC0  token: 0x60000E1
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0A2BDCE4  token: 0x60000E2
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0A2BD80C  token: 0x60000E3
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0A2BDDD0  token: 0x60000E4
        private System.Void <>m__Finally1() { }
        // RVA: 0x0A2BDE18  token: 0x60000E5
        private System.Void <>m__Finally2() { }
        // RVA: 0x0A2BDC98  token: 0x60000E7
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x0A2BDC04  token: 0x60000E9
        private virtual System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode>.GetEnumerator() { }
        // RVA: 0x0A2BDC90  token: 0x60000EA
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200000E  // size: 0x48
    public sealed class <get_Children>d__24 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private ZSimpleJSON.JSONNode <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x20
        public ZSimpleJSON.JSONArray <>4__this;  // 0x28
        private System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode> <>7__wrap1;  // 0x30

        // Properties
        ZSimpleJSON.JSONNode System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x025D6DC0  token: 0x60000FD
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0A2BD350  token: 0x60000FE
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0A2BD028  token: 0x60000FF
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0A2BD3C8  token: 0x6000100
        private System.Void <>m__Finally1() { }
        // RVA: 0x0A2BD304  token: 0x6000102
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x0A2BD270  token: 0x6000104
        private virtual System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode>.GetEnumerator() { }
        // RVA: 0x0A2BD2FC  token: 0x6000105
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000010  // size: 0x18
    public sealed class <>c__DisplayClass21_0
    {
        // Fields
        public ZSimpleJSON.JSONNode aNode;  // 0x10

        // Methods
        // RVA: 0x0350B670  token: 0x600011B
        public System.Void .ctor() { }
        // RVA: 0x0A2BCEF8  token: 0x600011C
        private System.Boolean <Remove>b__0(System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode> k) { }

    }

    // TypeToken: 0x2000011  // size: 0x58
    public sealed class <get_Children>d__27 : System.Collections.Generic.IEnumerable`1, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator`1, System.Collections.IEnumerator, System.IDisposable
    {
        // Fields
        private System.Int32 <>1__state;  // 0x10
        private ZSimpleJSON.JSONNode <>2__current;  // 0x18
        private System.Int32 <>l__initialThreadId;  // 0x20
        public ZSimpleJSON.JSONObject <>4__this;  // 0x28
        private System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode> <>7__wrap1;  // 0x30

        // Properties
        ZSimpleJSON.JSONNode System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode>.Current { get; /* RVA: 0x01041090 */ }
        System.Object System.Collections.IEnumerator.Current { get; /* RVA: 0x01041090 */ }

        // Methods
        // RVA: 0x025D6DC0  token: 0x600011D
        public System.Void .ctor(System.Int32 <>1__state) { }
        // RVA: 0x0A2BD758  token: 0x600011E
        private virtual System.Void System.IDisposable.Dispose() { }
        // RVA: 0x0A2BD404  token: 0x600011F
        private virtual System.Boolean MoveNext() { }
        // RVA: 0x0A2BD7D0  token: 0x6000120
        private System.Void <>m__Finally1() { }
        // RVA: 0x0A2BD70C  token: 0x6000122
        private virtual System.Void System.Collections.IEnumerator.Reset() { }
        // RVA: 0x0A2BD678  token: 0x6000124
        private virtual System.Collections.Generic.IEnumerator<ZSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode>.GetEnumerator() { }
        // RVA: 0x0A2BD704  token: 0x6000125
        private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

namespace ZSimpleJSON
{

    // TypeToken: 0x2000002  // size: 0x10
    public abstract class JSONNode
    {
        // Fields
        public static System.Byte Color32DefaultAlpha;  // static @ 0x0
        public static System.Single ColorDefaultAlpha;  // static @ 0x4
        public static ZSimpleJSON.JSONContainerType VectorContainerType;  // static @ 0x8
        public static ZSimpleJSON.JSONContainerType QuaternionContainerType;  // static @ 0xc
        public static ZSimpleJSON.JSONContainerType RectContainerType;  // static @ 0x10
        public static ZSimpleJSON.JSONContainerType ColorContainerType;  // static @ 0x14
        public static System.Boolean forceASCII;  // static @ 0x18
        public static System.Boolean longAsString;  // static @ 0x19
        public static System.Boolean allowLineComments;  // static @ 0x1a
        private static System.Text.StringBuilder m_EscapeBuilder;  // static @ 0xffffffff

        // Properties
        System.Decimal AsDecimal { get; /* RVA: 0x0A2B9774 */ set; /* RVA: 0x0A2BBA90 */ }
        System.Char AsChar { get; /* RVA: 0x0A2B9638 */ set; /* RVA: 0x0A2BB970 */ }
        System.UInt32 AsUInt { get; /* RVA: 0x0A2B9C1C */ set; /* RVA: 0x0A2BBE00 */ }
        System.Byte AsByte { get; /* RVA: 0x0A2B9628 */ set; /* RVA: 0x0A2BB95C */ }
        System.SByte AsSByte { get; /* RVA: 0x0A2B9628 */ set; /* RVA: 0x0A2BBC0C */ }
        System.Int16 AsShort { get; /* RVA: 0x0A2B9628 */ set; /* RVA: 0x0A2BBC20 */ }
        System.UInt16 AsUShort { get; /* RVA: 0x0A2B9628 */ set; /* RVA: 0x0A2BBE80 */ }
        System.DateTime AsDateTime { get; /* RVA: 0x0A2B96C0 */ set; /* RVA: 0x0A2BBA08 */ }
        System.TimeSpan AsTimeSpan { get; /* RVA: 0x0A2B9B6C */ set; /* RVA: 0x0A2BBDA8 */ }
        System.Guid AsGuid { get; /* RVA: 0x0A2B9890 */ set; /* RVA: 0x0A2BBB64 */ }
        System.Byte[] AsByteArray { get; /* RVA: 0x0A2B9454 */ set; /* RVA: 0x0A2BB7F0 */ }
        System.Collections.Generic.List<System.Byte> AsByteList { get; /* RVA: 0x0A2B9528 */ set; /* RVA: 0x0A2BB898 */ }
        System.UInt64[] AsUlongArray { get; /* RVA: 0x0A2B9CB4 */ set; /* RVA: 0x0A2BBE94 */ }
        System.String[] AsStringArray { get; /* RVA: 0x0A2B9994 */ set; /* RVA: 0x0A2BBC34 */ }
        System.Collections.Generic.List<System.String> AsStringList { get; /* RVA: 0x0A2B9A68 */ set; /* RVA: 0x0A2BBCE0 */ }
        ZSimpleJSON.JSONNodeType Tag { get; /* RVA: -1  // abstract */ }
        ZSimpleJSON.JSONNode Item { get; /* RVA: 0x01002730 */ set; /* RVA: 0x0350B670 */ }
        ZSimpleJSON.JSONNode Item { get; /* RVA: 0x01002730 */ set; /* RVA: 0x0350B670 */ }
        System.String Value { get; /* RVA: 0x0A2B9F64 */ set; /* RVA: 0x0350B670 */ }
        System.Int32 Count { get; /* RVA: 0x01002730 */ }
        System.Boolean IsNumber { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean IsString { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean IsBoolean { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean IsNull { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean IsArray { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean IsObject { get; /* RVA: 0x0115F4C0 */ }
        System.Boolean Inline { get; /* RVA: 0x0115F4C0 */ set; /* RVA: 0x0350B670 */ }
        System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode> Children { get; /* RVA: 0x0A2B9D8C */ }
        System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode> DeepChildren { get; /* RVA: 0x0A2B9DE0 */ }
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode>> Linq { get; /* RVA: 0x0A2B9F04 */ }
        ZSimpleJSON.JSONNode.KeyEnumerator Keys { get; /* RVA: 0x0A2B9E50 */ }
        ZSimpleJSON.JSONNode.ValueEnumerator Values { get; /* RVA: 0x0A2B9E50 */ }
        System.Double AsDouble { get; /* RVA: 0x0A2B97E8 */ set; /* RVA: 0x0A2BBAEC */ }
        System.Int32 AsInt { get; /* RVA: 0x0A2B98C0 */ set; /* RVA: 0x0A2BBB90 */ }
        System.Single AsFloat { get; /* RVA: 0x0A2B9874 */ set; /* RVA: 0x0A2BBB50 */ }
        System.Boolean AsBool { get; /* RVA: 0x0A2B93B8 */ set; /* RVA: 0x0A2BB784 */ }
        System.Int64 AsLong { get; /* RVA: 0x0A2B98DC */ set; /* RVA: 0x0A2BBBA8 */ }
        System.UInt64 AsULong { get; /* RVA: 0x0A2B9C38 */ set; /* RVA: 0x0A2BBE1C */ }
        ZSimpleJSON.JSONArray AsArray { get; /* RVA: 0x0A2B937C */ }
        ZSimpleJSON.JSONObject AsObject { get; /* RVA: 0x0A2B9958 */ }
        System.Text.StringBuilder EscapeBuilder { get; /* RVA: 0x025F39E0 */ }

        // Methods
        // RVA: 0x0A2BA6F0  token: 0x6000003
        public static ZSimpleJSON.JSONNode op_Implicit(System.Decimal aDecimal) { }
        // RVA: 0x0A2BACB4  token: 0x6000004
        public static System.Decimal op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BB3FC  token: 0x6000007
        public static ZSimpleJSON.JSONNode op_Implicit(System.Char aChar) { }
        // RVA: 0x0A2BB3C4  token: 0x6000008
        public static System.Char op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x03B33880  token: 0x600000B
        public static ZSimpleJSON.JSONNode op_Implicit(System.UInt32 aUInt) { }
        // RVA: 0x0A2BB324  token: 0x600000C
        public static System.UInt32 op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BAEB4  token: 0x600000F
        public static ZSimpleJSON.JSONNode op_Implicit(System.Byte aByte) { }
        // RVA: 0x0A2BA410  token: 0x6000010
        public static System.Byte op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BB654  token: 0x6000013
        public static ZSimpleJSON.JSONNode op_Implicit(System.SByte aSByte) { }
        // RVA: 0x0A2BA410  token: 0x6000014
        public static System.SByte op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BA3AC  token: 0x6000017
        public static ZSimpleJSON.JSONNode op_Implicit(System.Int16 aShort) { }
        // RVA: 0x0A2BA410  token: 0x6000018
        public static System.Int16 op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BB208  token: 0x600001B
        public static ZSimpleJSON.JSONNode op_Implicit(System.UInt16 aUShort) { }
        // RVA: 0x0A2BA410  token: 0x600001C
        public static System.UInt16 op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BA1BC  token: 0x600001F
        public static ZSimpleJSON.JSONNode op_Implicit(System.DateTime aDateTime) { }
        // RVA: 0x0A2BAD4C  token: 0x6000020
        public static System.DateTime op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BA324  token: 0x6000023
        public static ZSimpleJSON.JSONNode op_Implicit(System.TimeSpan aTimeSpan) { }
        // RVA: 0x0A2BAC7C  token: 0x6000024
        public static System.TimeSpan op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BA150  token: 0x6000027
        public static ZSimpleJSON.JSONNode op_Implicit(System.Guid aGuid) { }
        // RVA: 0x0A2BAE84  token: 0x6000028
        public static System.Guid op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BA684  token: 0x600002B
        public static ZSimpleJSON.JSONNode op_Implicit(System.Byte[] aByteArray) { }
        // RVA: 0x0A2BAE00  token: 0x600002C
        public static System.Byte[] op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BB19C  token: 0x600002F
        public static ZSimpleJSON.JSONNode op_Implicit(System.Collections.Generic.List<System.Byte> aByteList) { }
        // RVA: 0x0A2BA42C  token: 0x6000030
        public static System.Collections.Generic.List<System.Byte> op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BB4FC  token: 0x6000033
        public static ZSimpleJSON.JSONNode op_Implicit(System.UInt64[] aStringArray) { }
        // RVA: 0x0A2BAAC0  token: 0x6000034
        public static System.UInt64[] op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BA508  token: 0x6000037
        public static ZSimpleJSON.JSONNode op_Implicit(System.String[] aStringArray) { }
        // RVA: 0x0A2BAC98  token: 0x6000038
        public static System.String[] op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BAF80  token: 0x600003B
        public static ZSimpleJSON.JSONNode op_Implicit(System.Collections.Generic.List<System.String> aStringList) { }
        // RVA: 0x0A2BB080  token: 0x600003C
        public static System.Collections.Generic.List<System.String> op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x03B36560  token: 0x600003D
        public static ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Int32> aValue) { }
        // RVA: 0x0A2BAD68  token: 0x600003E
        public static System.Nullable<System.Int32> op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BAA04  token: 0x600003F
        public static ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Single> aValue) { }
        // RVA: 0x0A2BB104  token: 0x6000040
        public static System.Nullable<System.Single> op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BA954  token: 0x6000041
        public static ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Double> aValue) { }
        // RVA: 0x0A2BA820  token: 0x6000042
        public static System.Nullable<System.Double> op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BA068  token: 0x6000043
        public static ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Boolean> aValue) { }
        // RVA: 0x0A2BB26C  token: 0x6000044
        public static System.Nullable<System.Boolean> op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BAB44  token: 0x6000045
        public static ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Int64> aValue) { }
        // RVA: 0x0A2BA774  token: 0x6000046
        public static System.Nullable<System.Int64> op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BA26C  token: 0x6000047
        public static ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Int16> aValue) { }
        // RVA: 0x0A2BAFEC  token: 0x6000048
        public static System.Nullable<System.Int16> op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2B722C  token: 0x6000049
        private static ZSimpleJSON.JSONNode GetContainer(ZSimpleJSON.JSONContainerType aType) { }
        // RVA: 0x0A2BA574  token: 0x600004A
        public static ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Vector2 aVec) { }
        // RVA: 0x0A2BB6B8  token: 0x600004B
        public static ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Vector3 aVec) { }
        // RVA: 0x0A2BB568  token: 0x600004C
        public static ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Vector4 aVec) { }
        // RVA: 0x0A2BABF8  token: 0x600004D
        public static ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Color aCol) { }
        // RVA: 0x0A2B9FC0  token: 0x600004E
        public static ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Color32 aCol) { }
        // RVA: 0x0A2BA8D0  token: 0x600004F
        public static ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Quaternion aRot) { }
        // RVA: 0x0A2BB340  token: 0x6000050
        public static ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Rect aRect) { }
        // RVA: 0x0A2BB484  token: 0x6000051
        public static ZSimpleJSON.JSONNode op_Implicit(UnityEngine.RectOffset aRect) { }
        // RVA: 0x0A2BB3E0  token: 0x6000052
        public static UnityEngine.Vector2 op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BA4D0  token: 0x6000053
        public static UnityEngine.Vector3 op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BAF18  token: 0x6000054
        public static UnityEngine.Vector4 op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2B9F90  token: 0x6000055
        public static UnityEngine.Color op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BA4B0  token: 0x6000056
        public static UnityEngine.Color32 op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BA038  token: 0x6000057
        public static UnityEngine.Quaternion op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BA120  token: 0x6000058
        public static UnityEngine.Rect op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2BB308  token: 0x6000059
        public static UnityEngine.RectOffset op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2B7F3C  token: 0x600005A
        public UnityEngine.Vector2 ReadVector2(UnityEngine.Vector2 aDefault) { }
        // RVA: 0x0A2B7E9C  token: 0x600005B
        public UnityEngine.Vector2 ReadVector2(System.String aXName, System.String aYName) { }
        // RVA: 0x0A2B7E84  token: 0x600005C
        public UnityEngine.Vector2 ReadVector2() { }
        // RVA: 0x0A2B8F78  token: 0x600005D
        public ZSimpleJSON.JSONNode WriteVector2(UnityEngine.Vector2 aVec, System.String aXName, System.String aYName) { }
        // RVA: 0x0A2B815C  token: 0x600005E
        public UnityEngine.Vector3 ReadVector3(UnityEngine.Vector3 aDefault) { }
        // RVA: 0x0A2B8074  token: 0x600005F
        public UnityEngine.Vector3 ReadVector3(System.String aXName, System.String aYName, System.String aZName) { }
        // RVA: 0x0A2B8024  token: 0x6000060
        public UnityEngine.Vector3 ReadVector3() { }
        // RVA: 0x0A2B9070  token: 0x6000061
        public ZSimpleJSON.JSONNode WriteVector3(UnityEngine.Vector3 aVec, System.String aXName, System.String aYName, System.String aZName) { }
        // RVA: 0x0A2B82D8  token: 0x6000062
        public UnityEngine.Vector4 ReadVector4(UnityEngine.Vector4 aDefault) { }
        // RVA: 0x0A2B84B4  token: 0x6000063
        public UnityEngine.Vector4 ReadVector4() { }
        // RVA: 0x0A2B91B0  token: 0x6000064
        public ZSimpleJSON.JSONNode WriteVector4(UnityEngine.Vector4 aVec) { }
        // RVA: 0x0A2B74C8  token: 0x6000065
        public UnityEngine.Color ReadColor(UnityEngine.Color aDefault) { }
        // RVA: 0x0A2B76FC  token: 0x6000066
        public UnityEngine.Color ReadColor() { }
        // RVA: 0x0A2B8748  token: 0x6000067
        public ZSimpleJSON.JSONNode WriteColor(UnityEngine.Color aCol) { }
        // RVA: 0x0A2B72BC  token: 0x6000068
        public UnityEngine.Color32 ReadColor32(UnityEngine.Color32 aDefault) { }
        // RVA: 0x0A2B72B0  token: 0x6000069
        public UnityEngine.Color32 ReadColor32() { }
        // RVA: 0x0A2B8580  token: 0x600006A
        public ZSimpleJSON.JSONNode WriteColor32(UnityEngine.Color32 aCol) { }
        // RVA: 0x0A2B77E0  token: 0x600006B
        public UnityEngine.Quaternion ReadQuaternion(UnityEngine.Quaternion aDefault) { }
        // RVA: 0x0A2B79BC  token: 0x600006C
        public UnityEngine.Quaternion ReadQuaternion() { }
        // RVA: 0x0A2B89A8  token: 0x600006D
        public ZSimpleJSON.JSONNode WriteQuaternion(UnityEngine.Quaternion aRot) { }
        // RVA: 0x0A2B7C74  token: 0x600006E
        public UnityEngine.Rect ReadRect(UnityEngine.Rect aDefault) { }
        // RVA: 0x0A2B7E50  token: 0x600006F
        public UnityEngine.Rect ReadRect() { }
        // RVA: 0x0A2B8DAC  token: 0x6000070
        public ZSimpleJSON.JSONNode WriteRect(UnityEngine.Rect aRect) { }
        // RVA: 0x0A2B7A60  token: 0x6000071
        public UnityEngine.RectOffset ReadRectOffset(UnityEngine.RectOffset aDefault) { }
        // RVA: 0x0A2B79F8  token: 0x6000072
        public UnityEngine.RectOffset ReadRectOffset() { }
        // RVA: 0x0A2B8B74  token: 0x6000073
        public ZSimpleJSON.JSONNode WriteRectOffset(UnityEngine.RectOffset aRect) { }
        // RVA: 0x0A2B7738  token: 0x6000074
        public UnityEngine.Matrix4x4 ReadMatrix() { }
        // RVA: 0x0A2B8914  token: 0x6000075
        public ZSimpleJSON.JSONNode WriteMatrix(UnityEngine.Matrix4x4 aMatrix) { }
        // RVA: 0x0350B670  token: 0x6000086
        public virtual System.Void Add(System.String aKey, ZSimpleJSON.JSONNode aItem) { }
        // RVA: 0x0299FA70  token: 0x6000087
        public virtual System.Void Add(ZSimpleJSON.JSONNode aItem) { }
        // RVA: 0x01002730  token: 0x6000088
        public virtual ZSimpleJSON.JSONNode Remove(System.String aKey) { }
        // RVA: 0x01002730  token: 0x6000089
        public virtual ZSimpleJSON.JSONNode Remove(System.Int32 aIndex) { }
        // RVA: 0x03D51810  token: 0x600008A
        public virtual ZSimpleJSON.JSONNode Remove(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0350B670  token: 0x600008B
        public virtual System.Void Clear() { }
        // RVA: 0x01002730  token: 0x600008C
        public virtual ZSimpleJSON.JSONNode Clone() { }
        // RVA: 0x0115F4C0  token: 0x600008F
        public virtual System.Boolean HasKey(System.String aKey) { }
        // RVA: 0x03D553C0  token: 0x6000090
        public virtual ZSimpleJSON.JSONNode GetValueOrDefault(System.String aKey, ZSimpleJSON.JSONNode aDefault) { }
        // RVA: 0x037078B0  token: 0x6000091
        public virtual System.String ToString() { }
        // RVA: 0x0A2B84F0  token: 0x6000092
        public virtual System.String ToString(System.Int32 aIndent) { }
        // RVA: 0x0267F1C0  token: 0x6000093
        public virtual System.Void ToStringBuild(System.Text.StringBuilder& sb) { }
        // RVA: -1  // abstract  token: 0x6000094
        private virtual System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode) { }
        // RVA: -1  // abstract  token: 0x6000095
        public virtual ZSimpleJSON.JSONNode.Enumerator GetEnumerator() { }
        // RVA: 0x029A38F0  token: 0x60000A7
        public static ZSimpleJSON.JSONNode op_Implicit(System.String s) { }
        // RVA: 0x0A2BA61C  token: 0x60000A8
        public static System.String op_Implicit(ZSimpleJSON.JSONNode d) { }
        // RVA: 0x0268C840  token: 0x60000A9
        public static ZSimpleJSON.JSONNode op_Implicit(System.Double n) { }
        // RVA: 0x0A2BAADC  token: 0x60000AA
        public static System.Double op_Implicit(ZSimpleJSON.JSONNode d) { }
        // RVA: 0x0299F790  token: 0x60000AB
        public static ZSimpleJSON.JSONNode op_Implicit(System.Single n) { }
        // RVA: 0x0A2BACE4  token: 0x60000AC
        public static System.Single op_Implicit(ZSimpleJSON.JSONNode d) { }
        // RVA: 0x0299F800  token: 0x60000AD
        public static ZSimpleJSON.JSONNode op_Implicit(System.Int32 n) { }
        // RVA: 0x0A2BAE1C  token: 0x60000AE
        public static System.Int32 op_Implicit(ZSimpleJSON.JSONNode d) { }
        // RVA: 0x0299F6C0  token: 0x60000AF
        public static ZSimpleJSON.JSONNode op_Implicit(System.Int64 n) { }
        // RVA: 0x0A2BB09C  token: 0x60000B0
        public static System.Int64 op_Implicit(ZSimpleJSON.JSONNode d) { }
        // RVA: 0x02BFEFD0  token: 0x60000B1
        public static ZSimpleJSON.JSONNode op_Implicit(System.UInt64 n) { }
        // RVA: 0x0A2BA448  token: 0x60000B2
        public static System.UInt64 op_Implicit(ZSimpleJSON.JSONNode d) { }
        // RVA: 0x029A6DA0  token: 0x60000B3
        public static ZSimpleJSON.JSONNode op_Implicit(System.Boolean b) { }
        // RVA: 0x0A2BB5EC  token: 0x60000B4
        public static System.Boolean op_Implicit(ZSimpleJSON.JSONNode d) { }
        // RVA: 0x0A2BAF48  token: 0x60000B5
        public static ZSimpleJSON.JSONNode op_Implicit(System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode> aKeyValue) { }
        // RVA: 0x030467A0  token: 0x60000B6
        public static System.Boolean op_Equality(ZSimpleJSON.JSONNode a, System.Object b) { }
        // RVA: 0x03046600  token: 0x60000B7
        public static System.Boolean op_Inequality(ZSimpleJSON.JSONNode a, System.Object b) { }
        // RVA: 0x030465F0  token: 0x60000B8
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x03D4F970  token: 0x60000B9
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x025F3500  token: 0x60000BB
        private static System.String Escape(System.String aText) { }
        // RVA: 0x029A3840  token: 0x60000BC
        private static ZSimpleJSON.JSONNode ParseElement(System.String token, System.Boolean quoted) { }
        // RVA: 0x029A3260  token: 0x60000BD
        public static ZSimpleJSON.JSONNode Parse(System.String aJSON) { }
        // RVA: 0x0350B670  token: 0x60000BE
        protected System.Void .ctor() { }
        // RVA: 0x03CA8AC0  token: 0x60000BF
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x200000A  // size: 0x14
    public sealed struct JSONContainerType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static ZSimpleJSON.JSONContainerType Array;  // const
        public static ZSimpleJSON.JSONContainerType Object;  // const

    }

    // TypeToken: 0x200000B  // size: 0x14
    public sealed struct JSONNodeType
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static ZSimpleJSON.JSONNodeType Array;  // const
        public static ZSimpleJSON.JSONNodeType Object;  // const
        public static ZSimpleJSON.JSONNodeType String;  // const
        public static ZSimpleJSON.JSONNodeType Number;  // const
        public static ZSimpleJSON.JSONNodeType NullValue;  // const
        public static ZSimpleJSON.JSONNodeType Boolean;  // const
        public static ZSimpleJSON.JSONNodeType None;  // const
        public static ZSimpleJSON.JSONNodeType Custom;  // const

    }

    // TypeToken: 0x200000C  // size: 0x14
    public sealed struct JSONTextMode
    {
        // Fields
        public System.Int32 value__;  // 0x10
        public static ZSimpleJSON.JSONTextMode Compact;  // const
        public static ZSimpleJSON.JSONTextMode Indent;  // const

    }

    // TypeToken: 0x200000D  // size: 0x20
    public class JSONArray : ZSimpleJSON.JSONNode
    {
        // Fields
        private System.Collections.Generic.List<ZSimpleJSON.JSONNode> m_List;  // 0x10
        private System.Boolean inline;  // 0x18

        // Properties
        System.Boolean Inline { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        ZSimpleJSON.JSONNodeType Tag { get; /* RVA: 0x01168950 */ }
        System.Boolean IsArray { get; /* RVA: 0x0232EB60 */ }
        ZSimpleJSON.JSONNode Item { get; /* RVA: 0x0A2B614C */ set; /* RVA: 0x03046420 */ }
        ZSimpleJSON.JSONNode Item { get; /* RVA: 0x0A2B614C */ set; /* RVA: 0x03046420 */ }
        System.Int32 Count { get; /* RVA: 0x0A2B60AC */ }
        System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode> Children { get; /* RVA: 0x0A2B603C */ }

        // Methods
        // RVA: 0x0A2B5EB0  token: 0x60000EF
        public virtual ZSimpleJSON.JSONNode.Enumerator GetEnumerator() { }
        // RVA: 0x03046380  token: 0x60000F5
        public virtual System.Void Add(System.String aKey, ZSimpleJSON.JSONNode aItem) { }
        // RVA: 0x0A2B5F40  token: 0x60000F6
        public virtual ZSimpleJSON.JSONNode Remove(System.Int32 aIndex) { }
        // RVA: 0x0A2B5FE4  token: 0x60000F7
        public virtual ZSimpleJSON.JSONNode Remove(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2B5C38  token: 0x60000F8
        public virtual System.Void Clear() { }
        // RVA: 0x0A2B5C80  token: 0x60000F9
        public virtual ZSimpleJSON.JSONNode Clone() { }
        // RVA: 0x025F6160  token: 0x60000FB
        private virtual System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode) { }
        // RVA: 0x029A5A60  token: 0x60000FC
        public System.Void .ctor() { }

    }

    // TypeToken: 0x200000F  // size: 0x20
    public class JSONObject : ZSimpleJSON.JSONNode
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,ZSimpleJSON.JSONNode> m_Dict;  // 0x10
        private System.Boolean inline;  // 0x18

        // Properties
        System.Boolean Inline { get; /* RVA: 0x01002A50 */ set; /* RVA: 0x01002B40 */ }
        ZSimpleJSON.JSONNodeType Tag { get; /* RVA: 0x02102C70 */ }
        System.Boolean IsObject { get; /* RVA: 0x0232EB60 */ }
        ZSimpleJSON.JSONNode Item { get; /* RVA: 0x0A2BC998 */ set; /* RVA: 0x03046660 */ }
        ZSimpleJSON.JSONNode Item { get; /* RVA: 0x0A2BC998 */ set; /* RVA: 0x03046660 */ }
        System.Int32 Count { get; /* RVA: 0x0A2BC8CC */ }
        System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode> Children { get; /* RVA: 0x0A2BC85C */ }

        // Methods
        // RVA: 0x03B10940  token: 0x600010A
        public virtual ZSimpleJSON.JSONNode.Enumerator GetEnumerator() { }
        // RVA: 0x03046260  token: 0x6000110
        public virtual System.Void Add(System.String aKey, ZSimpleJSON.JSONNode aItem) { }
        // RVA: 0x0A2BC538  token: 0x6000111
        public virtual ZSimpleJSON.JSONNode Remove(System.String aKey) { }
        // RVA: 0x0A2BC5F0  token: 0x6000112
        public virtual ZSimpleJSON.JSONNode Remove(System.Int32 aIndex) { }
        // RVA: 0x0A2BC6B0  token: 0x6000113
        public virtual ZSimpleJSON.JSONNode Remove(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0368EAF0  token: 0x6000114
        public virtual System.Void Clear() { }
        // RVA: 0x0A2BC29C  token: 0x6000115
        public virtual ZSimpleJSON.JSONNode Clone() { }
        // RVA: 0x0A2BC4E4  token: 0x6000116
        public virtual System.Boolean HasKey(System.String aKey) { }
        // RVA: 0x0A2BC468  token: 0x6000117
        public virtual ZSimpleJSON.JSONNode GetValueOrDefault(System.String aKey, ZSimpleJSON.JSONNode aDefault) { }
        // RVA: 0x025F52C0  token: 0x6000119
        private virtual System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode) { }
        // RVA: 0x0299F420  token: 0x600011A
        public System.Void .ctor() { }

    }

    // TypeToken: 0x2000012  // size: 0x18
    public class JSONString : ZSimpleJSON.JSONNode
    {
        // Fields
        private System.String m_Data;  // 0x10

        // Properties
        ZSimpleJSON.JSONNodeType Tag { get; /* RVA: 0x03D555E0 */ }
        System.Boolean IsString { get; /* RVA: 0x0232EB60 */ }
        System.String Value { get; /* RVA: 0x020B7B20 */ set; /* RVA: 0x0426FEE0 */ }

        // Methods
        // RVA: 0x03D60600  token: 0x6000128
        public virtual ZSimpleJSON.JSONNode.Enumerator GetEnumerator() { }
        // RVA: 0x029A3990  token: 0x600012B
        public System.Void .ctor(System.String aData) { }
        // RVA: 0x0A2BCB9C  token: 0x600012C
        public virtual ZSimpleJSON.JSONNode Clone() { }
        // RVA: 0x025EF9D0  token: 0x600012D
        private virtual System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode) { }
        // RVA: 0x03046520  token: 0x600012E
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x06FAB9A8  token: 0x600012F
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0A2BCB5C  token: 0x6000130
        public virtual System.Void Clear() { }

    }

    // TypeToken: 0x2000013  // size: 0x18
    public class JSONNumber : ZSimpleJSON.JSONNode
    {
        // Fields
        private System.Double m_Data;  // 0x10

        // Properties
        ZSimpleJSON.JSONNodeType Tag { get; /* RVA: 0x03D50CD0 */ }
        System.Boolean IsNumber { get; /* RVA: 0x0232EB60 */ }
        System.String Value { get; /* RVA: 0x022FC830 */ set; /* RVA: 0x0A2BC21C */ }
        System.Double AsDouble { get; /* RVA: 0x03D61CF0 */ set; /* RVA: 0x03D4E410 */ }
        System.Int64 AsLong { get; /* RVA: 0x03D6D990 */ set; /* RVA: 0x03D6D9A0 */ }
        System.UInt64 AsULong { get; /* RVA: 0x0A2BC210 */ set; /* RVA: 0x03D8A1F0 */ }

        // Methods
        // RVA: 0x03D60600  token: 0x6000133
        public virtual ZSimpleJSON.JSONNode.Enumerator GetEnumerator() { }
        // RVA: 0x0299F870  token: 0x600013C
        public System.Void .ctor(System.Double aData) { }
        // RVA: 0x0A2BC1B4  token: 0x600013D
        public System.Void .ctor(System.String aData) { }
        // RVA: 0x0A2BC004  token: 0x600013E
        public virtual ZSimpleJSON.JSONNode Clone() { }
        // RVA: 0x025EF5D0  token: 0x600013F
        private virtual System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode) { }
        // RVA: 0x0A2BC06C  token: 0x6000140
        private static System.Boolean IsNumeric(System.Object value) { }
        // RVA: 0x0343A070  token: 0x6000141
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x0885DAE0  token: 0x6000142
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x03D735B0  token: 0x6000143
        public virtual System.Void Clear() { }

    }

    // TypeToken: 0x2000014  // size: 0x18
    public class JSONBool : ZSimpleJSON.JSONNode
    {
        // Fields
        private System.Boolean m_Data;  // 0x10

        // Properties
        ZSimpleJSON.JSONNodeType Tag { get; /* RVA: 0x03D51110 */ }
        System.Boolean IsBoolean { get; /* RVA: 0x0232EB60 */ }
        System.String Value { get; /* RVA: 0x0A2B6394 */ set; /* RVA: 0x0A2B63E0 */ }
        System.Boolean AsBool { get; /* RVA: 0x011797F0 */ set; /* RVA: 0x03D4E960 */ }

        // Methods
        // RVA: 0x03D60600  token: 0x6000146
        public virtual ZSimpleJSON.JSONNode.Enumerator GetEnumerator() { }
        // RVA: 0x029A6E10  token: 0x600014B
        public System.Void .ctor(System.Boolean aData) { }
        // RVA: 0x0A2B6338  token: 0x600014C
        public System.Void .ctor(System.String aData) { }
        // RVA: 0x0A2B628C  token: 0x600014D
        public virtual ZSimpleJSON.JSONNode Clone() { }
        // RVA: 0x0367B270  token: 0x600014E
        private virtual System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode) { }
        // RVA: 0x0371BBB0  token: 0x600014F
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x0A2B62F0  token: 0x6000150
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x03D557C0  token: 0x6000151
        public virtual System.Void Clear() { }

    }

    // TypeToken: 0x2000015  // size: 0x10
    public class JSONNull : ZSimpleJSON.JSONNode
    {
        // Fields
        private static ZSimpleJSON.JSONNull m_StaticInstance;  // static @ 0x0
        public static System.Boolean reuseSameInstance;  // static @ 0x8

        // Properties
        ZSimpleJSON.JSONNodeType Tag { get; /* RVA: 0x03D51100 */ }
        System.Boolean IsNull { get; /* RVA: 0x0232EB60 */ }
        System.String Value { get; /* RVA: 0x0A2BBFD8 */ set; /* RVA: 0x0350B670 */ }
        System.Boolean AsBool { get; /* RVA: 0x0115F4C0 */ set; /* RVA: 0x0350B670 */ }

        // Methods
        // RVA: 0x03046880  token: 0x6000152
        public static ZSimpleJSON.JSONNull CreateOrGet() { }
        // RVA: 0x03CB7240  token: 0x6000153
        private System.Void .ctor() { }
        // RVA: 0x03D60600  token: 0x6000156
        public virtual ZSimpleJSON.JSONNode.Enumerator GetEnumerator() { }
        // RVA: 0x0A2BBF40  token: 0x600015B
        public virtual ZSimpleJSON.JSONNode Clone() { }
        // RVA: 0x0A2BBF80  token: 0x600015C
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x01002730  token: 0x600015D
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x037904F0  token: 0x600015E
        private virtual System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode) { }
        // RVA: 0x03CB71B0  token: 0x600015F
        private static System.Void .cctor() { }

    }

    // TypeToken: 0x2000016  // size: 0x20
    public class JSONLazyCreator : ZSimpleJSON.JSONNode
    {
        // Fields
        private ZSimpleJSON.JSONNode m_Node;  // 0x10
        private System.String m_Key;  // 0x18

        // Properties
        ZSimpleJSON.JSONNodeType Tag { get; /* RVA: 0x03D55AA0 */ }
        ZSimpleJSON.JSONNode Item { get; /* RVA: 0x0A2B6B74 */ set; /* RVA: 0x0A2B7198 */ }
        ZSimpleJSON.JSONNode Item { get; /* RVA: 0x0A2B6B74 */ set; /* RVA: 0x0A2B7198 */ }
        System.Int32 AsInt { get; /* RVA: 0x0A2B6888 */ set; /* RVA: 0x0A2B6DE0 */ }
        System.Single AsFloat { get; /* RVA: 0x0A2B6808 */ set; /* RVA: 0x0A2B6D54 */ }
        System.Double AsDouble { get; /* RVA: 0x0A2B6788 */ set; /* RVA: 0x0A2B6CCC */ }
        System.Int64 AsLong { get; /* RVA: 0x0A2B6904 */ set; /* RVA: 0x0A2B6E6C */ }
        System.UInt64 AsULong { get; /* RVA: 0x0A2B6A78 */ set; /* RVA: 0x0A2B6FA0 */ }
        System.Boolean AsBool { get; /* RVA: 0x0A2B670C */ set; /* RVA: 0x0A2B6C44 */ }
        ZSimpleJSON.JSONArray AsArray { get; /* RVA: 0x0A2B6694 */ }
        ZSimpleJSON.JSONObject AsObject { get; /* RVA: 0x0A2B6A00 */ }

        // Methods
        // RVA: 0x03D60600  token: 0x6000161
        public virtual ZSimpleJSON.JSONNode.Enumerator GetEnumerator() { }
        // RVA: 0x0A2B65C8  token: 0x6000162
        public System.Void .ctor(ZSimpleJSON.JSONNode aNode) { }
        // RVA: 0x0A2B6628  token: 0x6000163
        public System.Void .ctor(ZSimpleJSON.JSONNode aNode, System.String aKey) { }
        // RVA: -1  // generic def  token: 0x6000164
        private T Set(T aVal) { }
        // RVA: 0x0A2B6444  token: 0x6000169
        public virtual System.Void Add(ZSimpleJSON.JSONNode aItem) { }
        // RVA: 0x0A2B64D8  token: 0x600016A
        public virtual System.Void Add(System.String aKey, ZSimpleJSON.JSONNode aItem) { }
        // RVA: 0x0885CFA4  token: 0x600016B
        public static System.Boolean op_Equality(ZSimpleJSON.JSONLazyCreator a, System.Object b) { }
        // RVA: 0x0885D444  token: 0x600016C
        public static System.Boolean op_Inequality(ZSimpleJSON.JSONLazyCreator a, System.Object b) { }
        // RVA: 0x0885CFA4  token: 0x600016D
        public virtual System.Boolean Equals(System.Object obj) { }
        // RVA: 0x01002730  token: 0x600016E
        public virtual System.Int32 GetHashCode() { }
        // RVA: 0x0A2B6580  token: 0x600017D
        private virtual System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode) { }

    }

    // TypeToken: 0x2000017  // size: 0x10
    public static class JSON
    {
        // Methods
        // RVA: 0x03D2C120  token: 0x600017E
        public static ZSimpleJSON.JSONNode Parse(System.String aJSON) { }

    }

}

